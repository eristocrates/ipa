namespace http.www.biopax.org.release.biopax_level3.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module biopax =
    let _namespace_iri = Namespace_Iri biopax |> NamespaceIRI

    /// <summary>
    ///   <para>biopax:stoichiometricCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Stoichiometric coefficient for one of the entities in an interaction or complex. This value can be any rational number. Generic values such as "n" or "n+1" should not be used - polymers are currently not covered.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#stoichiometricCoefficient">http://www.biopax.org/release/biopax-level3.owl#stoichiometricCoefficient</seealso>
    let stoichiometricCoefficient =
        Prefixed_Name(biopax, "stoichiometricCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>biopax:experimentalFormDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Descriptor of this experimental form from a controlled vocabulary.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#experimentalFormDescription">http://www.biopax.org/release/biopax-level3.owl#experimentalFormDescription</seealso>
    let experimentalFormDescription =
        Prefixed_Name(biopax, "experimentalFormDescription") |> PrefixedName

    /// <summary>
    ///   <para>biopax:BindingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition : An entity feature that represent the bound state of a physical entity. A pair of binding features represents a bond.
    ///
    /// Rationale: A physical entity in a molecular complex is considered as a new state of an entity as it is structurally and functionally different. Binding features provide facilities for describing these states. Similar to other features, a molecule can have bound and not-bound states.
    ///
    /// Usage: Typically, binding features are present in pairs, each describing the binding characteristic for one of the interacting physical entities. One exception is using a binding feature with no paired feature to describe any potential binding. For example, an unbound receptor can be described by using a "not-feature" property with an unpaired binding feature as its value.  BindingSiteType and featureLocation allows annotating the binding location.
    ///
    /// IntraMolecular property should be set to "true" if the bond links two parts of the same molecule. A pair of binding features are still used where they are owned by the same physical entity.
    ///
    /// If the binding is due to the covalent interactions, for example in the case of lipoproteins, CovalentBindingFeature subclass should be used instead of this class.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#BindingFeature">http://www.biopax.org/release/biopax-level3.owl#BindingFeature</seealso>
    let BindingFeature = Prefixed_Name(biopax, "BindingFeature") |> PrefixedName
    /// <summary>
    ///   <para>biopax:EntityFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description: A characteristic of a physical entity that can change while the entity still retains its biological identity.
    ///
    /// Rationale: Two phosphorylated forms of a protein are strictly speaking different chemical  molecules. It is, however, standard in biology to treat them as different states of the same entity, where the entity is loosely defined based on sequence. Entity Feature class and its subclassses captures these variable characteristics. A Physical Entity in BioPAX represents a pool of  molecules rather than an individual molecule. This is a notion imported from chemistry( See PhysicalEntity). Pools are defined by a set of Entity Features in the sense that a single molecule must have all of the features in the set in order to be considered a member of the pool. Since it is impossible to list and experimentally test all potential features for an  entity, features that are not listed in the selection criteria is neglected Pools can also be defined by the converse by specifying features  that are known to NOT exist in a specific context. As DNA, RNA and Proteins can be hierarchically organized into families based on sequence homology so can entity features. The memberFeature property allows capturing such hierarchical classifications among entity features.
    ///
    ///
    /// Usage: Subclasses of entity feature describe most common biological instances and should be preferred whenever possible. One common usecase for instantiating  entity feature is, for describing active/inactive states of proteins where more specific feature information is not available.
    ///
    /// Examples: Open/close conformational state of channel proteins, "active"/"inactive" states, excited states of photoreactive groups.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#EntityFeature">http://www.biopax.org/release/biopax-level3.owl#EntityFeature</seealso>
    let EntityFeature = Prefixed_Name(biopax, "EntityFeature") |> PrefixedName

    /// <summary>
    ///   <para>biopax:ControlledVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: This class represents a term from an external controlled vocabulary (CV).
    /// Rationale: Controlled Vocabularies mark cases where BioPAX delegates the representation of a complex biological phenomena to an external controlled vocabulary development effort such as Gene Ontology. Each subclass of this class represents one such case and often has an associated "Best-Practice" external resource to use. See the documentation of each subclass for more specific information. Correct usage of controlled vocabularies are critical to data exchange and integration.
    /// Usage: The individuals belonging to this class must unambiguously refer to the source controlled vocabulary. This can be achieved in two manners:
    /// The xref property of this class is restricted to the unification xref class. It must point to the source controlled vocabulary.
    /// Alternatively the rdf-id of the member individuals can be set to the designated MIRIAM URN.
    /// It is a best practice to do both whenever possible.
    /// Although it is possible to use multiple unification xrefs to identify semantically identical terms across alternative controlled vocabularies, this is not a recommended practice as it might lead to maintenance issues as the controlled vocabularies change.
    /// There is no recommended use-case for directly instantiating this class. Please use its subclasses instead.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ControlledVocabulary">http://www.biopax.org/release/biopax-level3.owl#ControlledVocabulary</seealso>
    let ControlledVocabulary =
        Prefixed_Name(biopax, "ControlledVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:KPrime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The apparent equilibrium constant, K', and associated values.
    /// Usage: Concentrations in the equilibrium constant equation refer to the total concentrations of  all forms of particular biochemical reactants. For example, in the equilibrium constant equation for the biochemical reaction in which ATP is hydrolyzed to ADP and inorganic phosphate:
    ///
    /// K' = [ADP][P&lt;sub&gt;i&lt;/sub&gt;]/[ATP],
    ///
    /// The concentration of ATP refers to the total concentration of all of the following species:
    ///
    /// [ATP] = [ATP&lt;sup&gt;4-&lt;/sup&gt;] + [HATP&lt;sup&gt;3-&lt;/sup&gt;] + [H&lt;sub&gt;2&lt;/sub&gt;ATP&lt;sup&gt;2-&lt;/sup&gt;] + [MgATP&lt;sup&gt;2-&lt;/sup&gt;] + [MgHATP&lt;sup&gt;-&lt;/sup&gt;] + [Mg&lt;sub&gt;2&lt;/sub&gt;ATP].
    ///
    /// The apparent equilibrium constant is formally dimensionless, and can be kept so by inclusion of as many of the terms (1 mol/dm&lt;sup&gt;3&lt;/sup&gt;) in the numerator or denominator as necessary.  It is a function of temperature (T), ionic strength (I), pH, and pMg (pMg = -log&lt;sub&gt;10&lt;/sub&gt;[Mg&lt;sup&gt;2+&lt;/sup&gt;]). Therefore, these quantities must be specified to be precise, and values for KEQ for biochemical reactions may be represented as 5-tuples of the form (K' T I pH pMg).  This property may have multiple values, representing different measurements for K' obtained under the different experimental conditions listed in the 5-tuple. (This definition adapted from EcoCyc)
    ///
    /// See http://www.chem.qmul.ac.uk/iubmb/thermod/ for a thermodynamics tutorial.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#KPrime">http://www.biopax.org/release/biopax-level3.owl#KPrime</seealso>
    let KPrime = Prefixed_Name(biopax, "KPrime") |> PrefixedName
    /// <summary>
    ///   <para>biopax:ExperimentalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The form of a physical entity in a particular experiment, as it may be modified for purposes of experimental design.
    /// Examples: A His-tagged protein in a binding assay. A protein can be tagged by multiple tags, so can have more than 1 experimental form type terms</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ExperimentalForm">http://www.biopax.org/release/biopax-level3.owl#ExperimentalForm</seealso>
    let ExperimentalForm = Prefixed_Name(biopax, "ExperimentalForm") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Xref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference from an instance of a class in this ontology to an object in an external resource.
    /// Rationale: Xrefs in the future can be removed in the future in favor of explicit miram links.
    /// Usage: For most cases one of the subclasses of xref should be used.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Xref">http://www.biopax.org/release/biopax-level3.owl#Xref</seealso>
    let Xref = Prefixed_Name(biopax, "Xref") |> PrefixedName
    /// <summary>
    ///   <para>biopax:SequenceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A location on a nucleotide or amino acid sequence.
    /// Usage: For most purposes it is more appropriate to use subclasses of this class. Direct instances of SequenceLocation can be used for uknown locations that can not be classified neither as an interval nor a site.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SequenceLocation">http://www.biopax.org/release/biopax-level3.owl#SequenceLocation</seealso>
    let SequenceLocation = Prefixed_Name(biopax, "SequenceLocation") |> PrefixedName
    /// <summary>
    ///   <para>biopax:ChemicalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The chemical structure of a small molecule.
    ///
    /// Usage: Structure information is stored in the property structureData, in one of three formats: the CML format (see www.xml-cml.org), the SMILES format (see  www.daylight.com/dayhtml/smiles/) or the InChI format (http://www.iupac.org/inchi/). The structureFormat property specifies which format is used.
    ///
    /// Examples: The following SMILES string describes the structure of glucose-6-phosphate:
    /// 'C(OP(=O)(O)O)[CH]1([CH](O)[CH](O)[CH](O)[CH](O)O1)'.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ChemicalStructure">http://www.biopax.org/release/biopax-level3.owl#ChemicalStructure</seealso>
    let ChemicalStructure = Prefixed_Name(biopax, "ChemicalStructure") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A score associated with a publication reference describing how the score was determined, the name of the method and a comment briefly describing the method.
    /// Usage:  The xref must contain at least one publication that describes the method used to determine the score value. There is currently no standard way of describing  values, so any string is valid.
    /// Examples: The statistical significance of a result, e.g. "p&lt;0.05".</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Score">http://www.biopax.org/release/biopax-level3.owl#Score</seealso>
    let Score = Prefixed_Name(biopax, "Score") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The direct source of pathway data or score.
    /// Usage: This does not store the trail of sources from the generation of the data to this point, only the last known source, such as a database, tool or algorithm. The xref property may contain a publicationXref referencing a publication describing the data source (e.g. a database publication). A unificationXref may be used when pointing to an entry in a database of databases describing this database.
    /// Examples: A database, scoring method or person name.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Provenance">http://www.biopax.org/release/biopax-level3.owl#Provenance</seealso>
    let Provenance = Prefixed_Name(biopax, "Provenance") |> PrefixedName
    /// <summary>
    ///   <para>biopax:notFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sequence features where the owner physical entity has a feature. If not specified, other potential features are not known.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#notFeature">http://www.biopax.org/release/biopax-level3.owl#notFeature</seealso>
    let notFeature = Prefixed_Name(biopax, "notFeature") |> PrefixedName
    /// <summary>
    ///   <para>biopax:physicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The physical entity to be annotated with stoichiometry.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#physicalEntity">http://www.biopax.org/release/biopax-level3.owl#physicalEntity</seealso>
    let physicalEntity = Prefixed_Name(biopax, "physicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biopax:TransportWithBiochemicalReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A conversion interaction that is both a biochemicalReaction and a transport. In transportWithBiochemicalReaction interactions, one or more of the substrates changes both their location and their physical structure. Active transport reactions that use ATP as an energy source fall under this category, even if the only covalent change is the hydrolysis of ATP to ADP.
    ///
    /// Rationale: This class was added to support a large number of transport events in pathway databases that have a biochemical reaction during the transport process. It is not expected that other double inheritance subclasses will be added to the ontology at the same level as this class.
    ///
    /// Examples: In the PEP-dependent phosphotransferase system, transportation of sugar into an E. coli cell is accompanied by the sugar's phosphorylation as it crosses the plasma membrane.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#TransportWithBiochemicalReaction">http://www.biopax.org/release/biopax-level3.owl#TransportWithBiochemicalReaction</seealso>
    let TransportWithBiochemicalReaction =
        Prefixed_Name(biopax, "TransportWithBiochemicalReaction") |> PrefixedName

    /// <summary>
    ///   <para>biopax:db</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The name of the external database to which this xref refers.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#db">http://www.biopax.org/release/biopax-level3.owl#db</seealso>
    let db = Prefixed_Name(biopax, "db") |> PrefixedName
    /// <summary>
    ///   <para>biopax:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The primary identifier in the external database of the object to which this xref refers.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#id">http://www.biopax.org/release/biopax-level3.owl#id</seealso>
    let id = Prefixed_Name(biopax, "id") |> PrefixedName
    /// <summary>
    ///   <para>biopax:absoluteRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Absolute location as defined by the referenced sequence database record. E.g. an operon has a absolute region on the DNA molecule referenced by the UnificationXref.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#absoluteRegion">http://www.biopax.org/release/biopax-level3.owl#absoluteRegion</seealso>
    let absoluteRegion = Prefixed_Name(biopax, "absoluteRegion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The authors of this publication, one per property value.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#author">http://www.biopax.org/release/biopax-level3.owl#author</seealso>
    let author = Prefixed_Name(biopax, "author") |> PrefixedName
    /// <summary>
    ///   <para>biopax:bindsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>A binding feature represents a "half" of the bond between two entities. This property points to another binding feature which represents the other half. The bond can be covalent or non-covalent.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#bindsTo">http://www.biopax.org/release/biopax-level3.owl#bindsTo</seealso>
    let bindsTo = Prefixed_Name(biopax, "bindsTo") |> PrefixedName
    /// <summary>
    ///   <para>biopax:catalysisDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the direction of this catalysis under all
    /// physiological conditions if there is one.
    ///
    /// Note that chemically a catalyst will increase the rate of the reaction
    /// in both directions. In biology, however, there are cases where the
    /// enzyme is expressed only when the controlled bidirectional conversion is
    /// on one side of the chemical equilibrium. For example E.Coli's lac operon ensures that lacZ gene is only synthesized when there is enough lactose in the medium.  If that is the case and the controller, under biological conditions, is always catalyzing the conversion in one direction then this fact can be
    /// captured using this property. If the enzyme is active for both
    /// directions, or the conversion is not bidirectional, this property should
    /// be left empty.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#catalysisDirection">http://www.biopax.org/release/biopax-level3.owl#catalysisDirection</seealso>
    let catalysisDirection = Prefixed_Name(biopax, "catalysisDirection") |> PrefixedName
    /// <summary>
    ///   <para>biopax:cellType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A cell type, e.g. 'HeLa'. This should reference a term in a controlled vocabulary of cell types. Best practice is to refer to OBO Cell Ontology. http://www.obofoundry.org/cgi-bin/detail.cgi?id=cell</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#cellType">http://www.biopax.org/release/biopax-level3.owl#cellType</seealso>
    let cellType = Prefixed_Name(biopax, "cellType") |> PrefixedName
    /// <summary>
    ///   <para>biopax:cellularLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A cellular location, e.g. 'cytoplasm'. This should reference a term in the Gene Ontology Cellular Component ontology. The location referred to by this property should be as specific as is known. If an interaction is known to occur in multiple locations, separate interactions (and physicalEntities) must be created for each different location.  If the location of a participant in a complex is unspecified, it may be assumed to be the same location as that of the complex.
    ///
    ///  A molecule in two different cellular locations are considered two different physical entities.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#cellularLocation">http://www.biopax.org/release/biopax-level3.owl#cellularLocation</seealso>
    let cellularLocation = Prefixed_Name(biopax, "cellularLocation") |> PrefixedName
    /// <summary>
    ///   <para>biopax:chemicalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The chemical formula of the small molecule. Note: chemical formula can also be stored in the STRUCTURE property (in CML). In case of disagreement between the value of this property and that in the CML file, the CML value takes precedence.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#chemicalFormula">http://www.biopax.org/release/biopax-level3.owl#chemicalFormula</seealso>
    let chemicalFormula = Prefixed_Name(biopax, "chemicalFormula") |> PrefixedName
    /// <summary>
    ///   <para>biopax:cofactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any cofactor(s) or coenzyme(s) required for catalysis of the conversion by the enzyme. This is a suproperty of participants.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#cofactor">http://www.biopax.org/release/biopax-level3.owl#cofactor</seealso>
    let cofactor = Prefixed_Name(biopax, "cofactor") |> PrefixedName
    /// <summary>
    ///   <para>biopax:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#component">http://www.biopax.org/release/biopax-level3.owl#component</seealso>
    let component_ = Prefixed_Name(biopax, "component") |> PrefixedName

    /// <summary>
    ///   <para>biopax:componentStoichiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The stoichiometry of components in a complex</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#componentStoichiometry">http://www.biopax.org/release/biopax-level3.owl#componentStoichiometry</seealso>
    let componentStoichiometry =
        Prefixed_Name(biopax, "componentStoichiometry") |> PrefixedName

    /// <summary>
    ///   <para>biopax:dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A free text description of the source of this data, e.g. a database or person name. This property should be used to describe the source of the data. This is meant to be used by databases that export their data to the BioPAX format or by systems that are integrating data from multiple sources. The granularity of use (specifying the data source in many or few instances) is up to the user. It is intended that this property report the last data source, not all data sources that the data has passed through from creation.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#dataSource">http://www.biopax.org/release/biopax-level3.owl#dataSource</seealso>
    let dataSource = Prefixed_Name(biopax, "dataSource") |> PrefixedName
    /// <summary>
    ///   <para>biopax:dbVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The version of the external database in which this xref was last known to be valid. Resources may have recommendations for referencing dataset versions. For instance, the Gene Ontology recommends listing the date the GO terms were downloaded.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#dbVersion">http://www.biopax.org/release/biopax-level3.owl#dbVersion</seealso>
    let dbVersion = Prefixed_Name(biopax, "dbVersion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:deltaG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>For biochemical reactions, this property refers to the standard transformed Gibbs energy change for a reaction written in terms of biochemical reactants (sums of species), delta-G
    ///
    /// Since Delta-G can change based on multiple factors including ionic strength and temperature a reaction can have multiple DeltaG values.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#deltaG">http://www.biopax.org/release/biopax-level3.owl#deltaG</seealso>
    let deltaG = Prefixed_Name(biopax, "deltaG") |> PrefixedName
    /// <summary>
    ///   <para>biopax:deltaH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For biochemical reactions, this property refers to the standard transformed enthalpy change for a reaction written in terms of biochemical reactants (sums of species), delta-H'&lt;sup&gt;o&lt;/sup&gt;.
    ///
    ///   delta-G'&lt;sup&gt;o&lt;/sup&gt; = delta-H'&lt;sup&gt;o&lt;/sup&gt; - T delta-S'&lt;sup&gt;o&lt;/sup&gt;
    ///
    /// Units: kJ/mole
    ///
    /// (This definition from EcoCyc)</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#deltaH">http://www.biopax.org/release/biopax-level3.owl#deltaH</seealso>
    let deltaH = Prefixed_Name(biopax, "deltaH") |> PrefixedName
    /// <summary>
    ///   <para>biopax:deltaS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For biochemical reactions, this property refers to the standard transformed entropy change for a reaction written in terms of biochemical reactants (sums of species), delta-S'&lt;sup&gt;o&lt;/sup&gt;.
    ///
    ///   delta-G'&lt;sup&gt;o&lt;/sup&gt; = delta-H'&lt;sup&gt;o&lt;/sup&gt; - T delta-S'&lt;sup&gt;o&lt;/sup&gt;
    ///
    /// (This definition from EcoCyc)</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#deltaS">http://www.biopax.org/release/biopax-level3.owl#deltaS</seealso>
    let deltaS = Prefixed_Name(biopax, "deltaS") |> PrefixedName
    /// <summary>
    ///   <para>biopax:displayName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An abbreviated name for this entity, preferably a name that is short enough to be used in a visualization application to label a graphical element that represents this entity. If no short name is available, an xref may be used for this purpose by the visualization application.
    ///
    /// Warning:  Subproperties of name are functional, that is we expect to have only one standardName and shortName for a given entity. If a user decides to assign a different name to standardName or shortName, they have to remove the old triplet from the model too. If the old name should be retained as a synonym a regular "name" property should also be introduced with the old name.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#displayName">http://www.biopax.org/release/biopax-level3.owl#displayName</seealso>
    let displayName = Prefixed_Name(biopax, "displayName") |> PrefixedName
    /// <summary>
    ///   <para>biopax:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Synonyms for this entity.  standardName and shortName are subproperties of this property and if declared they are automatically considered as names.
    ///
    /// Warning:  Subproperties of name are functional, that is we expect to have only one standardName and shortName for a given entity. If a user decides to assign a different name to standardName or shortName, they have to remove the old triplet from the model too. If the old name should be retained as a synonym a regular "name" property should also be introduced with the old name.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#name">http://www.biopax.org/release/biopax-level3.owl#name</seealso>
    let name = Prefixed_Name(biopax, "name") |> PrefixedName
    /// <summary>
    ///   <para>biopax:entityFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Variable features that are observed for the entities of this entityReference - such as known PTM or methylation sites and non-covalent bonds. Note that this is an aggregate list of all known features and it does not represent a state itself.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#entityFeature">http://www.biopax.org/release/biopax-level3.owl#entityFeature</seealso>
    let entityFeature = Prefixed_Name(biopax, "entityFeature") |> PrefixedName

    /// <summary>
    ///   <para>biopax:entityReferenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A controlled vocabulary term that is used to describe the type of grouping such as homology or functional group.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#entityReferenceType">http://www.biopax.org/release/biopax-level3.owl#entityReferenceType</seealso>
    let entityReferenceType =
        Prefixed_Name(biopax, "entityReferenceType") |> PrefixedName

    /// <summary>
    ///   <para>biopax:evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Scientific evidence supporting the existence of the entity as described.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#evidence">http://www.biopax.org/release/biopax-level3.owl#evidence</seealso>
    let evidence = Prefixed_Name(biopax, "evidence") |> PrefixedName

    /// <summary>
    ///   <para>biopax:experimentalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A feature of the experimental form of the participant of the interaction, such as a protein tag. It is not expected to occur in vivo or be necessary for the interaction.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#experimentalFeature">http://www.biopax.org/release/biopax-level3.owl#experimentalFeature</seealso>
    let experimentalFeature =
        Prefixed_Name(biopax, "experimentalFeature") |> PrefixedName

    /// <summary>
    ///   <para>biopax:experimentalFormEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The gene or physical entity that this experimental form describes.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#experimentalFormEntity">http://www.biopax.org/release/biopax-level3.owl#experimentalFormEntity</seealso>
    let experimentalFormEntity =
        Prefixed_Name(biopax, "experimentalFormEntity") |> PrefixedName

    /// <summary>
    ///   <para>biopax:featureLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Location of the feature on the sequence of the interactor.
    /// For modification features this is the modified base or residue. For binding features this is the binding site and for fragment features this is the location of the fragment on the "base" sequence.
    /// One feature may have more than one location, used e.g. for features which involve sequence positions close in the folded, three-dimensional state of a protein, but non-continuous along the sequence.
    /// Small Molecules can have binding features but currently it is not possible to define the binding site on the small molecules. In those cases this property should not be specified.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#featureLocation">http://www.biopax.org/release/biopax-level3.owl#featureLocation</seealso>
    let featureLocation = Prefixed_Name(biopax, "featureLocation") |> PrefixedName

    /// <summary>
    ///   <para>biopax:featureLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A controlled vocabulary term describing the type of the sequence location of the feature such as C-Terminal or SH2 Domain.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#featureLocationType">http://www.biopax.org/release/biopax-level3.owl#featureLocationType</seealso>
    let featureLocationType =
        Prefixed_Name(biopax, "featureLocationType") |> PrefixedName

    /// <summary>
    ///   <para>biopax:idVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The version number of the identifier (ID). E.g. The RefSeq accession number NM_005228.3 should be split into NM_005228 as the ID and 3 as the ID-VERSION.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#idVersion">http://www.biopax.org/release/biopax-level3.owl#idVersion</seealso>
    let idVersion = Prefixed_Name(biopax, "idVersion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:interactionScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The score of an interaction e.g. a genetic interaction score.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#interactionScore">http://www.biopax.org/release/biopax-level3.owl#interactionScore</seealso>
    let interactionScore = Prefixed_Name(biopax, "interactionScore") |> PrefixedName
    /// <summary>
    ///   <para>biopax:intraMolecular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This flag represents whether the binding feature is within the same molecule or not. A true value implies that the entityReferences of this feature and its binding partner are the same.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#intraMolecular">http://www.biopax.org/release/biopax-level3.owl#intraMolecular</seealso>
    let intraMolecular = Prefixed_Name(biopax, "intraMolecular") |> PrefixedName
    /// <summary>
    ///   <para>biopax:ionicStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ionic strength is defined as half of the total sum of the concentration (ci) of every ionic species (i) in the solution times the square of its charge (zi). For example, the ionic strength of a 0.1 M solution of CaCl2 is 0.5 x (0.1 x 22 + 0.2 x 12) = 0.3 M</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ionicStrength">http://www.biopax.org/release/biopax-level3.owl#ionicStrength</seealso>
    let ionicStrength = Prefixed_Name(biopax, "ionicStrength") |> PrefixedName
    /// <summary>
    ///   <para>biopax:kEQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This quantity is dimensionless and is usually a single number. The measured equilibrium constant for a biochemical reaction, encoded by the slot KEQ, is actually the apparent equilibrium constant, K'.  Concentrations in the equilibrium constant equation refer to the total concentrations of  all forms of particular biochemical reactants. For example, in the equilibrium constant equation for the biochemical reaction in which ATP is hydrolyzed to ADP and inorganic phosphate:
    ///
    /// K' = [ADP][P&lt;sub&gt;i&lt;/sub&gt;]/[ATP],
    ///
    /// The concentration of ATP refers to the total concentration of all of the following species:
    ///
    /// [ATP] = [ATP&lt;sup&gt;4-&lt;/sup&gt;] + [HATP&lt;sup&gt;3-&lt;/sup&gt;] + [H&lt;sub&gt;2&lt;/sub&gt;ATP&lt;sup&gt;2-&lt;/sup&gt;] + [MgATP&lt;sup&gt;2-&lt;/sup&gt;] + [MgHATP&lt;sup&gt;-&lt;/sup&gt;] + [Mg&lt;sub&gt;2&lt;/sub&gt;ATP].
    ///
    /// The apparent equilibrium constant is formally dimensionless, and can be kept so by inclusion of as many of the terms (1 mol/dm&lt;sup&gt;3&lt;/sup&gt;) in the numerator or denominator as necessary.  It is a function of temperature (T), ionic strength (I), pH, and pMg (pMg = -log&lt;sub&gt;10&lt;/sub&gt;[Mg&lt;sup&gt;2+&lt;/sup&gt;]). Therefore, these quantities must be specified to be precise, and values for KEQ for biochemical reactions may be represented as 5-tuples of the form (K' T I pH pMg).  This property may have multiple values, representing different measurements for K' obtained under the different experimental conditions listed in the 5-tuple. (This definition adapted from EcoCyc)</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#kEQ">http://www.biopax.org/release/biopax-level3.owl#kEQ</seealso>
    let kEQ = Prefixed_Name(biopax, "kEQ") |> PrefixedName
    /// <summary>
    ///   <para>biopax:memberFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>An entity feature that belongs to this homology grouping.
    /// These features should be of the same class of this EntityFeature
    /// These features should be an EntityFeature of an EntityReference which is a memberEntityReference of the EntityReference of this feature.
    /// If this set is not empty than the sequenceLocation of this feature should be non-specified.
    /// Example: a homologous phosphorylation site across a protein family.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#memberFeature">http://www.biopax.org/release/biopax-level3.owl#memberFeature</seealso>
    let memberFeature = Prefixed_Name(biopax, "memberFeature") |> PrefixedName
    /// <summary>
    ///   <para>biopax:modificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Description and classification of the feature.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#modificationType">http://www.biopax.org/release/biopax-level3.owl#modificationType</seealso>
    let modificationType = Prefixed_Name(biopax, "modificationType") |> PrefixedName
    /// <summary>
    ///   <para>biopax:molecularWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the molecular weight of the molecule, in daltons.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#molecularWeight">http://www.biopax.org/release/biopax-level3.owl#molecularWeight</seealso>
    let molecularWeight = Prefixed_Name(biopax, "molecularWeight") |> PrefixedName
    /// <summary>
    ///   <para>biopax:pMg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A measure of the concentration of magnesium (Mg) in solution. (pMg = -log&lt;sub&gt;10&lt;/sub&gt;[Mg&lt;sup&gt;2+&lt;/sup&gt;])</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#pMg">http://www.biopax.org/release/biopax-level3.owl#pMg</seealso>
    let pMg = Prefixed_Name(biopax, "pMg") |> PrefixedName

    /// <summary>
    ///   <para>biopax:participantStoichiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Stoichiometry of the left and right participants.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#participantStoichiometry">http://www.biopax.org/release/biopax-level3.owl#participantStoichiometry</seealso>
    let participantStoichiometry =
        Prefixed_Name(biopax, "participantStoichiometry") |> PrefixedName

    /// <summary>
    ///   <para>biopax:pathwayComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The set of interactions and/or pathwaySteps in this pathway/network. Each instance of the pathwayStep class defines: 1) a set of interactions that together define a particular step in the pathway, for example a catalysis instance and the conversion that it catalyzes; 2) an order relationship to one or more other pathway steps (via the NEXT-STEP property). Note: This ordering is not necessarily temporal - the order described may simply represent connectivity between adjacent steps. Temporal ordering information should only be inferred from the direction of each interaction.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#pathwayComponent">http://www.biopax.org/release/biopax-level3.owl#pathwayComponent</seealso>
    let pathwayComponent = Prefixed_Name(biopax, "pathwayComponent") |> PrefixedName
    /// <summary>
    ///   <para>biopax:pathwayOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ordering of components (interactions and pathways) in the context of this pathway. This is useful to specific circular or branched pathways or orderings when component biochemical reactions are normally reversible, but are directed in the context of this pathway.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#pathwayOrder">http://www.biopax.org/release/biopax-level3.owl#pathwayOrder</seealso>
    let pathwayOrder = Prefixed_Name(biopax, "pathwayOrder") |> PrefixedName
    /// <summary>
    ///   <para>biopax:patoData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The phenotype data from PATO, formatted as PhenoXML (defined at http://www.fruitfly.org/~cjm/obd/formats.html)</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#patoData">http://www.biopax.org/release/biopax-level3.owl#patoData</seealso>
    let patoData = Prefixed_Name(biopax, "patoData") |> PrefixedName
    /// <summary>
    ///   <para>biopax:ph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A measure of acidity and alkalinity of a solution that is a number on a scale on which a value of 7 represents neutrality and lower numbers indicate increasing acidity and higher numbers increasing alkalinity and on which each unit of change represents a tenfold change in acidity or alkalinity and that is the negative logarithm of the effective hydrogen-ion concentration or hydrogen-ion activity in gram equivalents per liter of the solution. (Definition from Merriam-Webster Dictionary)</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ph">http://www.biopax.org/release/biopax-level3.owl#ph</seealso>
    let ph = Prefixed_Name(biopax, "ph") |> PrefixedName
    /// <summary>
    ///   <para>biopax:positionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The confidence status of the sequence position. This could be:
    /// EQUAL: The SEQUENCE-POSITION is known to be at the SEQUENCE-POSITION.
    /// GREATER-THAN: The site is greater than the SEQUENCE-POSITION.
    /// LESS-THAN: The site is less than the SEQUENCE-POSITION.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#positionStatus">http://www.biopax.org/release/biopax-level3.owl#positionStatus</seealso>
    let positionStatus = Prefixed_Name(biopax, "positionStatus") |> PrefixedName
    /// <summary>
    ///   <para>biopax:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The product of a template reaction.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#product">http://www.biopax.org/release/biopax-level3.owl#product</seealso>
    let product = Prefixed_Name(biopax, "product") |> PrefixedName
    /// <summary>
    ///   <para>biopax:regionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#regionType">http://www.biopax.org/release/biopax-level3.owl#regionType</seealso>
    let regionType = Prefixed_Name(biopax, "regionType") |> PrefixedName
    /// <summary>
    ///   <para>biopax:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Polymer sequence in uppercase letters. For DNA, usually A,C,G,T letters representing the nucleosides of adenine, cytosine, guanine and thymine, respectively; for RNA, usually A, C, U, G; for protein, usually the letters corresponding to the 20 letter IUPAC amino acid code.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#sequence">http://www.biopax.org/release/biopax-level3.owl#sequence</seealso>
    let sequence = Prefixed_Name(biopax, "sequence") |> PrefixedName

    /// <summary>
    ///   <para>biopax:sequenceIntervalBegin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The begin position of a sequence interval.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#sequenceIntervalBegin">http://www.biopax.org/release/biopax-level3.owl#sequenceIntervalBegin</seealso>
    let sequenceIntervalBegin =
        Prefixed_Name(biopax, "sequenceIntervalBegin") |> PrefixedName

    /// <summary>
    ///   <para>biopax:sequenceIntervalEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The end position of a sequence interval.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#sequenceIntervalEnd">http://www.biopax.org/release/biopax-level3.owl#sequenceIntervalEnd</seealso>
    let sequenceIntervalEnd =
        Prefixed_Name(biopax, "sequenceIntervalEnd") |> PrefixedName

    /// <summary>
    ///   <para>biopax:sequencePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The integer listed gives the position. The first base or amino acid is position 1. In combination with the numeric value, the property 'POSITION-STATUS' allows to express fuzzy positions, e.g. 'less than 4'.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#sequencePosition">http://www.biopax.org/release/biopax-level3.owl#sequencePosition</seealso>
    let sequencePosition = Prefixed_Name(biopax, "sequencePosition") |> PrefixedName
    /// <summary>
    ///   <para>biopax:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The source  in which the reference was published, such as: a book title, or a journal title and volume and pages.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#source">http://www.biopax.org/release/biopax-level3.owl#source</seealso>
    let source = Prefixed_Name(biopax, "source") |> PrefixedName
    /// <summary>
    ///   <para>biopax:spontaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Specifies whether a conversion occurs spontaneously or not. If the spontaneity is not known, the SPONTANEOUS property should be left empty.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#spontaneous">http://www.biopax.org/release/biopax-level3.owl#spontaneous</seealso>
    let spontaneous = Prefixed_Name(biopax, "spontaneous") |> PrefixedName
    /// <summary>
    ///   <para>biopax:standardName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The preferred full name for this entity, if exists assigned by a standard nomenclature organization such as HUGO Gene Nomenclature Committee.
    ///
    /// Warning:  Subproperties of name are functional, that is we expect to have only one standardName and shortName for a given entity. If a user decides to assign a different name to standardName or shortName, they have to remove the old triplet from the model too. If the old name should be retained as a synonym a regular "name" property should also be introduced with the old name.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#standardName">http://www.biopax.org/release/biopax-level3.owl#standardName</seealso>
    let standardName = Prefixed_Name(biopax, "standardName") |> PrefixedName
    /// <summary>
    ///   <para>biopax:stepConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The central process that take place at this step of the biochemical pathway.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#stepConversion">http://www.biopax.org/release/biopax-level3.owl#stepConversion</seealso>
    let stepConversion = Prefixed_Name(biopax, "stepConversion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:stepDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Direction of the conversion in this particular pathway context.
    /// This property can be used for annotating direction of enzymatic activity. Even if an enzyme catalyzes a reaction reversibly, the flow of matter through the pathway will force the equilibrium in a given direction for that particular pathway.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#stepDirection">http://www.biopax.org/release/biopax-level3.owl#stepDirection</seealso>
    let stepDirection = Prefixed_Name(biopax, "stepDirection") |> PrefixedName
    /// <summary>
    ///   <para>biopax:DnaRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A region on a DNA molecule.
    /// Usage:  DNARegion is not a pool of independent molecules but a subregion on these molecules. As such, every DNARegion has a defining DNA molecule.
    /// Examples: Protein encoding region, promoter</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#DnaRegion">http://www.biopax.org/release/biopax-level3.owl#DnaRegion</seealso>
    let DnaRegion = Prefixed_Name(biopax, "DnaRegion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Rna</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A physical entity consisting of a sequence of ribonucleotide monophosphates; a ribonucleic acid.
    /// Usage: RNA should be used for pools of individual RNA molecules. For describing subregions on those molecules use RNARegion.
    /// Examples: messengerRNA, microRNA, ribosomalRNA. A specific example is the let-7 microRNA.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Rna">http://www.biopax.org/release/biopax-level3.owl#Rna</seealso>
    let Rna = Prefixed_Name(biopax, "Rna") |> PrefixedName

    /// <summary>
    ///   <para>biopax:MolecularInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An interaction in which participants bind physically to each other, directly or indirectly through intermediary molecules.
    ///
    /// Rationale: There is a large body of interaction data, mostly produced by high throughput systems, that does not satisfy the level of detail required to model them with ComplexAssembly class. Specifically, what is lacking is the stoichiometric information and completeness (closed-world) of participants required to model them as chemical processes. Nevertheless interaction data is extremely useful and can be captured in BioPAX using this class.
    ///
    /// Usage: This class should be used by default for representing molecular interactions such as those defined by PSI-MI level 2.5. The participants in a molecular interaction should be listed in the PARTICIPANT slot. Note that this is one of the few cases in which the PARTICPANT slot should be directly populated with instances (see comments on the PARTICPANTS property in the interaction class description). If all participants are known with exact stoichiometry, ComplexAssembly class should be used instead.
    ///
    /// Example: Two proteins observed to interact in a yeast-two-hybrid experiment where there is not enough experimental evidence to suggest that the proteins are forming a complex by themselves without any indirect involvement of other proteins. This is the case for most large-scale yeast two-hybrid screens.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#MolecularInteraction">http://www.biopax.org/release/biopax-level3.owl#MolecularInteraction</seealso>
    let MolecularInteraction =
        Prefixed_Name(biopax, "MolecularInteraction") |> PrefixedName

    /// <summary>
    ///   <para>biopax:UnificationXref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A unification xref defines a reference to an entity in an external resource that has the same biological identity as the referring entity
    /// Rationale: Unification xrefs are critically important for data integration. In the future they may be replaced by direct miriam links and rdf:id based identity management.
    ///
    /// Usage: For example, if one wished to link from a database record, C, describing a chemical compound in a BioPAX data collection to a record, C', describing the same chemical compound in an external database, one would use a unification xref since records C and C' describe the same biological identity. Generally, unification xrefs should be used whenever possible, although there are cases where they might not be useful, such as application to application data exchange.Identity of interactions can be computed based on the  identity of its participants. An xref in a protein pointing to a gene, e.g. in the LocusLink database17, would not be a unification xref since the two entities do not have the same biological identity (one is a protein, the other is a gene). Instead, this link should be a captured as a relationship xref. References to an external controlled vocabulary term within the OpenControlledVocabulary class should use a unification xref where possible (e.g. GO:0005737).
    /// Examples: An xref in a protein instance pointing to an entry in the Swiss-Prot database, and an xref in an RNA instance pointing to the corresponding RNA sequence in the RefSeq database..</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#UnificationXref">http://www.biopax.org/release/biopax-level3.owl#UnificationXref</seealso>
    let UnificationXref = Prefixed_Name(biopax, "UnificationXref") |> PrefixedName
    /// <summary>
    ///   <para>biopax:left</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The participants on the left side of the conversion interaction. Since conversion interactions may proceed in either the left-to-right or right-to-left direction, occupants of the left property may be either reactants or products. left is a sub-property of participants.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#left">http://www.biopax.org/release/biopax-level3.owl#left</seealso>
    let left = Prefixed_Name(biopax, "left") |> PrefixedName
    /// <summary>
    ///   <para>biopax:template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The template molecule that is used in this template reaction.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#template">http://www.biopax.org/release/biopax-level3.owl#template</seealso>
    let template = Prefixed_Name(biopax, "template") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Gene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A continuant that encodes information that can be inherited through replication.
    /// Rationale: Gene is an abstract continuant that can be best described as a "schema", a common conception commonly used by biologists to demark a component within genome. In BioPAX, Gene is considered a generalization over eukaryotic and prokaryotic genes and is used only in genetic interactions.  Gene is often confused with DNA and RNA fragments, however, these are considered the physical encoding of a gene.  N.B. Gene expression regulation makes use of DNA and RNA physical entities and not this class.
    /// Usage: Gene should only be used for describing GeneticInteractions.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Gene">http://www.biopax.org/release/biopax-level3.owl#Gene</seealso>
    let Gene = Prefixed_Name(biopax, "Gene") |> PrefixedName
    /// <summary>
    ///   <para>biopax:phenotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The phenotype quality used to define this genetic interaction e.g. viability.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#phenotype">http://www.biopax.org/release/biopax-level3.owl#phenotype</seealso>
    let phenotype = Prefixed_Name(biopax, "phenotype") |> PrefixedName
    /// <summary>
    ///   <para>biopax:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year in which this publication was published.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#year">http://www.biopax.org/release/biopax-level3.owl#year</seealso>
    let year = Prefixed_Name(biopax, "year") |> PrefixedName
    /// <summary>
    ///   <para>biopax:UtilityClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: This is a placeholder for classes, used for annotating the "Entity" and its subclasses. Mostly, these are not  an "Entity" themselves. Examples include references to external databases, controlled vocabularies, evidence and provenance.
    ///
    /// Rationale: Utility classes are created when simple slots are insufficient to describe an aspect of an entity or to increase compatibility of this ontology with other standards.
    ///
    /// Usage: The utilityClass class is actually a metaclass and is only present to organize the other helper classes under one class hierarchy; instances of utilityClass should never be created.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#UtilityClass">http://www.biopax.org/release/biopax-level3.owl#UtilityClass</seealso>
    let UtilityClass = Prefixed_Name(biopax, "UtilityClass") |> PrefixedName
    /// <summary>
    ///   <para>biopax:DeltaG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: Standard transformed Gibbs energy change for a reaction written in terms of biochemical reactants.
    /// Usage: Delta-G is represented as a 5-tuple of delta-G'&lt;sup&gt;0&lt;/sup&gt;, temperature, ionic strength , pH, and pMg . A conversion in BioPAX may have multiple Delta-G values, representing different measurements for delta-G'&lt;sup&gt;0&lt;/sup&gt; obtained under the different experimental conditions.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#DeltaG">http://www.biopax.org/release/biopax-level3.owl#DeltaG</seealso>
    let DeltaG = Prefixed_Name(biopax, "DeltaG") |> PrefixedName
    /// <summary>
    ///   <para>biopax:organism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An organism, e.g. 'Homo sapiens'. This is the organism that the entity is found in. Pathways may not have an organism associated with them, for instance, reference pathways from KEGG. Sequence-based entities (DNA, protein, RNA) may contain an xref to a sequence database that contains organism information, in which case the information should be consistent with the value for ORGANISM.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#organism">http://www.biopax.org/release/biopax-level3.owl#organism</seealso>
    let organism = Prefixed_Name(biopax, "organism") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Pathway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A set or series of interactions, often forming a network, which biologists have found useful to group together for organizational, historic, biophysical or other reasons.
    ///
    /// Usage: Pathways can be used for demarcating any subnetwork of a BioPAX model. It is also possible to define a pathway without specifying the interactions within the pathway. In this case, the pathway instance could consist simply of a name and could be treated as a 'black box'.  Pathways can also soverlap, i.e. a single interaction might belong to multiple pathways. Pathways can also contain sub-pathways. Pathways are continuants.
    ///
    /// Synonyms: network, module, cascade,
    /// Examples: glycolysis, valine biosynthesis, EGFR signaling</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Pathway">http://www.biopax.org/release/biopax-level3.owl#Pathway</seealso>
    let Pathway = Prefixed_Name(biopax, "Pathway") |> PrefixedName
    /// <summary>
    ///   <para>biopax:interactionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Controlled vocabulary annotating the interaction type for example, "phosphorylation reaction". This annotation is meant to be human readable and may not be suitable for computing tasks, like reasoning, that require formal vocabulary systems. For instance, this information would be useful for display on a web page or for querying a database. The PSI-MI interaction type controlled vocabulary should be used. This is browsable at:
    /// http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0190&amp;termName=interaction%20type</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#interactionType">http://www.biopax.org/release/biopax-level3.owl#interactionType</seealso>
    let interactionType = Prefixed_Name(biopax, "interactionType") |> PrefixedName
    /// <summary>
    ///   <para>biopax:FragmentFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An entity feature that represents the resulting physical entity subsequent to a cleavage or degradation event.
    ///
    /// Usage: Fragment Feature can be used to cover multiple types of modfications to the sequence of the physical entity:
    /// 1.    A protein with a single cleavage site that converts the protein into two fragments (e.g. pro-insulin converted to insulin and C-peptide). TODO: CV term for sequence fragment?  PSI-MI CV term for cleavage site?
    /// 2.    A protein with two cleavage sites that removes an internal sequence e.g. an intein i.e. ABC -&gt; A
    /// 3.    Cleavage of a circular sequence e.g. a plasmid.
    ///
    /// In the case of removal ( e.g. intron)  the fragment that is *removed* is specified in the feature location property. In the case of a "cut" (e.g. restriction enzyme cut site) the location of the cut is specified instead.
    /// Examples: Insulin Hormone</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#FragmentFeature">http://www.biopax.org/release/biopax-level3.owl#FragmentFeature</seealso>
    let FragmentFeature = Prefixed_Name(biopax, "FragmentFeature") |> PrefixedName
    /// <summary>
    ///   <para>biopax:PathwayStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A step in an ordered pathway.
    /// Rationale: Some pathways can have a temporal order. For example,  if the pathway boundaries are based on a perturbation phenotype link, the pathway might start with the perturbing agent and end at gene expression leading to the observed changes. Pathway steps can represent directed compound graphs.
    /// Usage: Multiple interactions may occur in a pathway step, each should be listed in the stepProcess property. Order relationships between pathway steps may be established with the nextStep slot. If the reaction contained in the step is a reversible biochemical reaction but physiologically has a direction in the context of this pathway, use the subclass BiochemicalPathwayStep.
    ///
    /// Example: A metabolic pathway may contain a pathway step composed of one biochemical reaction (BR1) and one catalysis (CAT1) instance, where CAT1 describes the catalysis of BR1. The M phase of the cell cycle, defined as a pathway, precedes the G1 phase, also defined as a pathway.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#PathwayStep">http://www.biopax.org/release/biopax-level3.owl#PathwayStep</seealso>
    let PathwayStep = Prefixed_Name(biopax, "PathwayStep") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Degradation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A conversion in which a pool of macromolecules are degraded into their elementary units.
    ///
    /// Usage: This conversion always has a direction of left-to-right and is irreversible. Degraded molecules are always represented on the left, degradation products on the right.
    ///
    /// Comments: Degradation is a complex abstraction over multiple reactions. Although it obeys law of mass conservation and stoichiometric, the products are rarely specified since they are ubiquitous.
    ///
    /// Example:  Degradation of a protein to amino acids.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Degradation">http://www.biopax.org/release/biopax-level3.owl#Degradation</seealso>
    let Degradation = Prefixed_Name(biopax, "Degradation") |> PrefixedName
    /// <summary>
    ///   <para>biopax:ComplexAssembly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A conversion interaction in which a set of physical entities, at least one being a macromolecule (e.g. protein, RNA, DNA), aggregate to from a complex physicalEntity. One of the participants of a complexAssembly must be an instance of the class Complex. The modification of the physicalentities involved in the ComplexAssembly is captured via BindingFeature class.
    ///
    /// Usage: This class is also used to represent complex disassembly. The assembly or disassembly of a complex is often a spontaneous process, in which case the direction of the complexAssembly (toward either assembly or disassembly) should be specified via the SPONTANEOUS property. Conversions in which participants obtain or lose CovalentBindingFeatures ( e.g. glycolysation of proteins) should be modeled with BiochemicalReaction.
    ///
    /// Synonyms: aggregation, complex formation
    ///
    /// Examples: Assembly of the TFB2 and TFB3 proteins into the TFIIH complex, and assembly of the ribosome through aggregation of its subunits.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ComplexAssembly">http://www.biopax.org/release/biopax-level3.owl#ComplexAssembly</seealso>
    let ComplexAssembly = Prefixed_Name(biopax, "ComplexAssembly") |> PrefixedName
    /// <summary>
    ///   <para>biopax:EntityReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An entity reference is a grouping of several physical entities across different contexts and molecular states, that share common physical properties and often named and treated as a single entity with multiple states by biologists.
    ///
    /// Rationale:   Many protein, small molecule and gene databases share this point of view, and such a grouping is an important prerequisite for interoperability with those databases. Biologists would often group different pools of molecules in different contexts under the same name. For example cytoplasmic and extracellular calcium have different effects on the cell's behavior, but they are still called calcium. For DNA, RNA and Proteins the grouping is defined based on a wildtype sequence, for small molecules it is defined by the chemical structure.
    ///
    /// Usage: Entity references store the information common to a set of molecules in various states described in the BioPAX document, including database cross-references. For instance, the P53 protein can be phosphorylated in multiple different ways. Each separate P53 protein (pool) in a phosphorylation state would be represented as a different protein (child of physicalEntity) and all things common to all P53 proteins, including all possible phosphorylation sites, the sequence common to all of them and common references to protein databases containing more information about P53 would be stored in a Entity Reference.
    ///
    /// Comments: This grouping has three semantic implications:
    ///
    /// 1.  Members of different pools share many physical and biochemical properties. This includes their chemical structure, sequence, organism and set of molecules they react with. They will also share a lot of secondary information such as their names, functional groupings, annotation terms and database identifiers.
    ///
    /// 2. A small number of transitions seperates these pools. In other words it is relatively easy and frequent for a molecule to transform from one physical entity to another that belong to the same reference entity. For example an extracellular calcium can become cytoplasmic, and p53 can become phosphorylated. However no calcium virtually becomes sodium, or no p53 becomes mdm2. In the former it is the sheer energy barrier of a nuclear reaction, in the latter sheer statistical improbability of synthesizing the same sequence without a template. If one thinks about the biochemical network as molecules transforming into each other, and remove edges that respond to transcription, translation, degradation and covalent modification of small molecules, each remaining component is a reference entity.
    ///
    /// 3. Some of the pools in the same group can overlap. p53-p@ser15 can overlap with p53-p@thr18. Most of the experiments in molecular biology will only check for one state variable, rarely multiple, and never for the all possible combinations. So almost all statements that refer to the state of the molecule talk about a pool that can overlap with other pools. However no overlaps is possible between molecules of different groups.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#EntityReference">http://www.biopax.org/release/biopax-level3.owl#EntityReference</seealso>
    let EntityReference = Prefixed_Name(biopax, "EntityReference") |> PrefixedName
    /// <summary>
    ///   <para>biopax:stepProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An interaction or a pathway that are a part of this pathway step.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#stepProcess">http://www.biopax.org/release/biopax-level3.owl#stepProcess</seealso>
    let stepProcess = Prefixed_Name(biopax, "stepProcess") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An interaction in which one entity regulates, modifies, or otherwise influences a continuant entity, i.e. pathway or interaction.
    ///
    /// Usage: Conceptually, physical entities are involved in interactions (or events) and the events are controlled or modified, not the physical entities themselves. For example, a kinase activating a protein is a frequent event in signaling pathways and is usually represented as an 'activation' arrow from the kinase to the substrate in signaling diagrams. This is an abstraction, called "Activity Flow" representation,  that can be ambiguous without context. In BioPAX, this information should be captured as the kinase catalyzing (via an instance of the catalysis class) a Biochemical Reaction in which the substrate is phosphorylated.
    /// Subclasses of control define types specific to the biological process that is being controlled and should be used instead of the generic "control" class when applicable.
    ///
    /// A control can potentially have multiple controllers. This acts as a logical AND, i.e. both controllers are needed to regulate the  controlled event. Alternatively multiple controllers can control the same event and this acts as a logical OR, i.e. any one of them is sufficient to regulate the controlled event. Using this structure it is possible to describe arbitrary control logic using BioPAX.
    ///
    /// Rationale: Control can be temporally non-atomic, for example a pathway can control another pathway in BioPAX.
    /// Synonyms: regulation, mediation
    ///
    /// Examples: A small molecule that inhibits a pathway by an unknown mechanism.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Control">http://www.biopax.org/release/biopax-level3.owl#Control</seealso>
    let Control = Prefixed_Name(biopax, "Control") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Catalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A control interaction in which a physical entity (a catalyst) increases the rate of a conversion interaction by lowering its activation energy. Instances of this class describe a pairing between a catalyzing entity and a catalyzed conversion.
    /// Rationale: Catalysis, theoretically, is always bidirectional since it acts by lowering the activation energy. Physiologically, however, it can have a direction because of the concentration of the participants. For example, the oxidative decarboxylation catalyzed by Isocitrate dehydrogenase always happens in one direction under physiological conditions since the produced carbon dioxide is constantly removed from the system.
    ///
    /// Usage: A separate catalysis instance should be created for each different conversion that a physicalEntity may catalyze and for each different physicalEntity that may catalyze a conversion. For example, a bifunctional enzyme that catalyzes two different biochemical reactions would be linked to each of those biochemical reactions by two separate instances of the catalysis class. Also, catalysis reactions from multiple different organisms could be linked to the same generic biochemical reaction (a biochemical reaction is generic if it only includes small molecules). Generally, the enzyme catalyzing a conversion is known and the use of this class is obvious, however, in the cases where a catalyzed reaction is known to occur but the enzyme is not known, a catalysis instance can be created without a controller specified.
    /// Synonyms: facilitation, acceleration.
    /// Examples: The catalysis of a biochemical reaction by an enzyme, the enabling of a transport interaction by a membrane pore complex, and the facilitation of a complex assembly by a scaffold protein. Hexokinase -&gt; (The "Glucose + ATP -&gt; Glucose-6-phosphate +ADP" reaction). A plasma membrane Na+/K+ ATPase is an active transporter (antiport pump) using the energy of ATP to pump Na+ out of the cell and K+ in. Na+ from cytoplasm to extracellular space would be described in a transport instance. K+ from extracellular space to cytoplasm would be described in a transport instance. The ATPase pump would be stored in a catalysis instance controlling each of the above transport instances. A biochemical reaction that does not occur by itself under physiological conditions, but has been observed to occur in the presence of cell extract, likely via one or more unknown enzymes present in the extract, would be stored in the CONTROLLED property, with the CONTROLLER property empty.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Catalysis">http://www.biopax.org/release/biopax-level3.owl#Catalysis</seealso>
    let Catalysis = Prefixed_Name(biopax, "Catalysis") |> PrefixedName
    /// <summary>
    ///   <para>biopax:PhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A pool of molecules or molecular complexes.
    ///
    /// Comments: Each PhysicalEntity is defined by a  sequence or structure based on an EntityReference AND any set of Features that are given. For example,  ser46 phosphorylated p53 is a physical entity in BioPAX defined by the p53 sequence and the phosphorylation feature on the serine at position 46 in the sequence.  Features are any combination of cellular location, covalent and non-covalent bonds with other molecules and covalent modifications.
    ///
    /// For a specific molecule to be a member of the pool it has to satisfy all of the specified features. Unspecified features are treated as unknowns or unneccesary. Features that are known to not be on the molecules should be explicitly stated with the "not feature" property.
    /// A physical entity in BioPAX  never represents a specific molecular instance.
    ///
    /// Physical Entity can be heterogenous and potentially overlap, i.e. a single molecule can be counted as a member of multiple pools. This makes BioPAX semantics different than regular chemical notation but is necessary for dealing with combinatorial complexity.
    ///
    /// Synonyms: part, interactor, object, species
    ///
    /// Examples: extracellular calcium, ser 64 phosphorylated p53</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#PhysicalEntity">http://www.biopax.org/release/biopax-level3.owl#PhysicalEntity</seealso>
    let PhysicalEntity = Prefixed_Name(biopax, "PhysicalEntity") |> PrefixedName
    /// <summary>
    ///   <para>biopax:availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the availability of this data (e.g. a copyright statement).</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#availability">http://www.biopax.org/release/biopax-level3.owl#availability</seealso>
    let availability = Prefixed_Name(biopax, "availability") |> PrefixedName

    /// <summary>
    ///   <para>biopax:BiochemicalReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A conversion in which molecules of one or more physicalEntity pools, undergo covalent modifications and become a member of one or more other physicalEntity pools. The substrates of biochemical reactions are defined in terms of sums of species. This is a convention in biochemistry, and, in principle, all EC reactions should be biochemical reactions.
    ///
    /// Examples: ATP + H2O = ADP + Pi
    ///
    /// Comment: In the example reaction above, ATP is considered to be an equilibrium mixture of several species, namely ATP4-, HATP3-, H2ATP2-, MgATP2-, MgHATP-, and Mg2ATP. Additional species may also need to be considered if other ions (e.g. Ca2+) that bind ATP are present. Similar considerations apply to ADP and to inorganic phosphate (Pi). When writing biochemical reactions, it is not necessary to attach charges to the biochemical reactants or to include ions such as H+ and Mg2+ in the equation. The reaction is written in the direction specified by the EC nomenclature system, if applicable, regardless of the physiological direction(s) in which the reaction proceeds. Polymerization reactions involving large polymers whose structure is not explicitly captured should generally be represented as unbalanced reactions in which the monomer is consumed but the polymer remains unchanged, e.g. glycogen + glucose = glycogen. A better coverage for polymerization will be developed.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#BiochemicalReaction">http://www.biopax.org/release/biopax-level3.owl#BiochemicalReaction</seealso>
    let BiochemicalReaction =
        Prefixed_Name(biopax, "BiochemicalReaction") |> PrefixedName

    /// <summary>
    ///   <para>biopax:Conversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An interaction in which molecules of one or more PhysicalEntity pools are physically transformed and become a member of one or more other PhysicalEntity pools.
    /// Rationale: Conversion is Comments: Conversions in BioPAX are stoichiometric and closed world, i.e. it is assumed that all of the participants are listed. Both properties are due to the law of mass conservation.
    /// Usage: Subclasses of conversion represent different types of transformation reflected by the properties of different physicalEntity. BiochemicalReactions will change the ModificationFeatures on a PhysicalEntity, Transport will change the Cellular Location and ComplexAssembly will change BindingFeatures. Generic Conversion class should only be used when the modification does not fit into a any of these classes.
    /// Example: Opening of a voltage gated channel.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Conversion">http://www.biopax.org/release/biopax-level3.owl#Conversion</seealso>
    let Conversion = Prefixed_Name(biopax, "Conversion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The controlling entity, e.g., in a biochemical reaction, an enzyme is the controlling entity of the reaction. CONTROLLER is a sub-property of PARTICIPANTS.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#controller">http://www.biopax.org/release/biopax-level3.owl#controller</seealso>
    let controller = Prefixed_Name(biopax, "controller") |> PrefixedName
    /// <summary>
    ///   <para>biopax:controlType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the nature of the control relationship between the controller and the controlled entities.
    ///
    /// The following terms are possible values:
    ///
    /// ACTIVATION: General activation. Compounds that activate the specified enzyme activity by an unknown mechanism. The mechanism is defined as unknown, because either the mechanism has yet to be elucidated in the experimental literature, or the paper(s) curated thus far do not define the mechanism, and a full literature search has yet to be performed.
    ///
    /// The following term can not be used in the catalysis class:
    /// INHIBITION: General inhibition. Compounds that inhibit the specified enzyme activity by an unknown mechanism. The mechanism is defined as unknown, because either the mechanism has yet to be elucidated in the experimental literature, or the paper(s) curated thus far do not define the mechanism, and a full literature search has yet to be performed.
    ///
    /// The following terms can only be used in the modulation class (these definitions from EcoCyc):
    /// INHIBITION-ALLOSTERIC
    /// Allosteric inhibitors decrease the specified enzyme activity by binding reversibly to the enzyme and inducing a conformational change that decreases the affinity of the enzyme to its substrates without affecting its VMAX. Allosteric inhibitors can be competitive or noncompetitive inhibitors, therefore, those inhibition categories can be used in conjunction with this category.
    ///
    /// INHIBITION-COMPETITIVE
    /// Competitive inhibitors are compounds that competitively inhibit the specified enzyme activity by binding reversibly to the enzyme and preventing the substrate from binding. Binding of the inhibitor and substrate are mutually exclusive because it is assumed that the inhibitor and substrate can both bind only to the free enzyme. A competitive inhibitor can either bind to the active site of the enzyme, directly excluding the substrate from binding there, or it can bind to another site on the enzyme, altering the conformation of the enzyme such that the substrate can not bind to the active site.
    ///
    /// INHIBITION-IRREVERSIBLE
    /// Irreversible inhibitors are compounds that irreversibly inhibit the specified enzyme activity by binding to the enzyme and dissociating so slowly that it is considered irreversible. For example, alkylating agents, such as iodoacetamide, irreversibly inhibit the catalytic activity of some enzymes by modifying cysteine side chains.
    ///
    /// INHIBITION-NONCOMPETITIVE
    /// Noncompetitive inhibitors are compounds that noncompetitively inhibit the specified enzyme by binding reversibly to both the free enzyme and to the enzyme-substrate complex. The inhibitor and substrate may be bound to the enzyme simultaneously and do not exclude each other. However, only the enzyme-substrate complex (not the enzyme-substrate-inhibitor complex) is catalytically active.
    ///
    /// INHIBITION-OTHER
    /// Compounds that inhibit the specified enzyme activity by a mechanism that has been characterized, but that cannot be clearly classified as irreversible, competitive, noncompetitive, uncompetitive, or allosteric.
    ///
    /// INHIBITION-UNCOMPETITIVE
    /// Uncompetitive inhibitors are compounds that uncompetitively inhibit the specified enzyme activity by binding reversibly to the enzyme-substrate complex but not to the enzyme alone.
    ///
    /// ACTIVATION-NONALLOSTERIC
    /// Nonallosteric activators increase the specified enzyme activity by means other than allosteric.
    ///
    /// ACTIVATION-ALLOSTERIC
    /// Allosteric activators increase the specified enzyme activity by binding reversibly to the enzyme and inducing a conformational change that increases the affinity of the enzyme to its substrates without affecting its VMAX.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#controlType">http://www.biopax.org/release/biopax-level3.owl#controlType</seealso>
    let controlType = Prefixed_Name(biopax, "controlType") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Modulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A control interaction in which a physical entity modulates a catalysis interaction.
    ///
    /// Rationale: Biologically, most modulation interactions describe an interaction in which a small molecule alters the ability of an enzyme to catalyze a specific reaction. Instances of this class describe a pairing between a modulating entity and a catalysis interaction.
    ///
    /// Usage:  A typical modulation instance has a small molecule as the controller entity and a catalysis instance as the controlled entity. A separate modulation instance should be created for each different catalysis instance that a physical entity may modulate, and for each different physical entity that may modulate a catalysis instance.
    /// Examples: Allosteric activation and competitive inhibition of an enzyme's ability to catalyze a specific reaction.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Modulation">http://www.biopax.org/release/biopax-level3.owl#Modulation</seealso>
    let Modulation = Prefixed_Name(biopax, "Modulation") |> PrefixedName

    /// <summary>
    ///   <para>biopax:ExperimentalFormVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to the PSI Molecular Interaction ontology (MI) participant identification method (e.g. mass spectrometry), experimental role (e.g. bait, prey), experimental preparation (e.g. expression level) type. Homepage at http://www.psidev.info/.  Browse http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0002&amp;termName=participant%20identification%20method
    ///
    /// http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0495&amp;termName=experimental%20role
    ///
    /// http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0346&amp;termName=experimental%20preparation</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ExperimentalFormVocabulary">http://www.biopax.org/release/biopax-level3.owl#ExperimentalFormVocabulary</seealso>
    let ExperimentalFormVocabulary =
        Prefixed_Name(biopax, "ExperimentalFormVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:RelationshipTypeVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: Vocabulary for defining relationship Xref types. A reference to the PSI Molecular Interaction ontology (MI) Cross Reference type. Homepage at http://www.psidev.info/.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0353&amp;termName=cross-reference%20type</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#RelationshipTypeVocabulary">http://www.biopax.org/release/biopax-level3.owl#RelationshipTypeVocabulary</seealso>
    let RelationshipTypeVocabulary =
        Prefixed_Name(biopax, "RelationshipTypeVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:TissueVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to the BRENDA (BTO). Homepage at http://www.brenda-enzymes.info/.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=BTO</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#TissueVocabulary">http://www.biopax.org/release/biopax-level3.owl#TissueVocabulary</seealso>
    let TissueVocabulary = Prefixed_Name(biopax, "TissueVocabulary") |> PrefixedName
    /// <summary>
    ///   <para>biopax:structureData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property holds a string of data defining chemical structure,in one of the three formats:&lt;a href ="www.xml-cml.org"&gt;CML&lt;/a&gt;, &lt;a href = "www.daylight.com/dayhtml/smiles/"&gt;SMILES&lt;/a&gt; or &lt;a href="http://www.iupac.org/inchi/"&gt;InChI&lt;/a&gt;. If, for example,the CML format is used, then the value of this property is a string containing the XML encoding of the CML data.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#structureData">http://www.biopax.org/release/biopax-level3.owl#structureData</seealso>
    let structureData = Prefixed_Name(biopax, "structureData") |> PrefixedName
    /// <summary>
    ///   <para>biopax:controlled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The entity that is controlled, e.g., in a biochemical reaction, the reaction is controlled by an enzyme. Controlled is a sub-property of participants.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#controlled">http://www.biopax.org/release/biopax-level3.owl#controlled</seealso>
    let controlled = Prefixed_Name(biopax, "controlled") |> PrefixedName

    /// <summary>
    ///   <para>biopax:TemplateReactionRegulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: Regulation of an expression reaction by a controlling element such as a transcription factor or microRNA.
    ///
    /// Usage: To represent the binding of the transcription factor to a regulatory element in the TemplateReaction, create a complex of the transcription factor and the regulatory element and set that as the controller.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#TemplateReactionRegulation">http://www.biopax.org/release/biopax-level3.owl#TemplateReactionRegulation</seealso>
    let TemplateReactionRegulation =
        Prefixed_Name(biopax, "TemplateReactionRegulation") |> PrefixedName

    /// <summary>
    ///   <para>biopax:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment on the data in the container class. This property should be used instead of the OWL documentation elements (rdfs:comment) for instances because information in 'comment' is data to be exchanged, whereas the rdfs:comment field is used for metadata about the structure of the BioPAX ontology.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#comment">http://www.biopax.org/release/biopax-level3.owl#comment</seealso>
    let comment = Prefixed_Name(biopax, "comment") |> PrefixedName
    /// <summary>
    ///   <para>biopax:CellVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to the Cell Type Ontology (CL). Homepage at http://obofoundry.org/cgi-bin/detail.cgi?cell.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=CL</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#CellVocabulary">http://www.biopax.org/release/biopax-level3.owl#CellVocabulary</seealso>
    let CellVocabulary = Prefixed_Name(biopax, "CellVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:SequenceModificationVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definiiton: A reference to the PSI Molecular Interaction ontology (MI) of covalent sequence modifications. Homepage at http://www.psidev.info/.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0252&amp;termName=biological%20feature. Only children that are covelent modifications at specific positions can be used.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SequenceModificationVocabulary">http://www.biopax.org/release/biopax-level3.owl#SequenceModificationVocabulary</seealso>
    let SequenceModificationVocabulary =
        Prefixed_Name(biopax, "SequenceModificationVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:SequenceRegionVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to a controlled vocabulary of sequence regions, such as InterPro or Sequence Ontology (SO). Homepage at http://www.sequenceontology.org/.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=SO</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SequenceRegionVocabulary">http://www.biopax.org/release/biopax-level3.owl#SequenceRegionVocabulary</seealso>
    let SequenceRegionVocabulary =
        Prefixed_Name(biopax, "SequenceRegionVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:eCNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The unique number assigned to a reaction by the Enzyme Commission of the International Union of Biochemistry and Molecular Biology.
    ///
    /// Note that not all biochemical reactions currently have EC numbers assigned to them.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#eCNumber">http://www.biopax.org/release/biopax-level3.owl#eCNumber</seealso>
    let eCNumber = Prefixed_Name(biopax, "eCNumber") |> PrefixedName

    /// <summary>
    ///   <para>biopax:PhenotypeVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The phenotype measured in the experiment e.g. growth rate or viability of a cell. This is only the type, not the value e.g. for a synthetic lethal interaction, the phenotype is viability, specified by ID: PATO:0000169, "viability", not the value (specified by ID: PATO:0000718, "lethal (sensu genetics)". A single term in a phenotype controlled vocabulary can be referenced using the xref, or the PhenoXML describing the PATO EQ model phenotype description can be stored as a string in PATO-DATA.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#PhenotypeVocabulary">http://www.biopax.org/release/biopax-level3.owl#PhenotypeVocabulary</seealso>
    let PhenotypeVocabulary =
        Prefixed_Name(biopax, "PhenotypeVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:InteractionVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to the PSI Molecular Interaction ontology (MI) interaction type. Homepage at http://www.psidev.info/.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI&amp;termId=MI%3A0190&amp;termName=interaction%20type</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#InteractionVocabulary">http://www.biopax.org/release/biopax-level3.owl#InteractionVocabulary</seealso>
    let InteractionVocabulary =
        Prefixed_Name(biopax, "InteractionVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:CellularLocationVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to the Gene Ontology Cellular Component (GO CC) ontology. Homepage at http://www.geneontology.org.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=GO</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#CellularLocationVocabulary">http://www.biopax.org/release/biopax-level3.owl#CellularLocationVocabulary</seealso>
    let CellularLocationVocabulary =
        Prefixed_Name(biopax, "CellularLocationVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:EvidenceCodeVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A reference to the PSI Molecular Interaction ontology (MI) experimental method types, including "interaction detection method", "participant identification method", "feature detection method". Homepage at http://www.psidev.info/.  Browse at http://www.ebi.ac.uk/ontology-lookup/browse.do?ontName=MI
    ///
    /// Terms from the Pathway Tools Evidence Ontology may also be used. Homepage http://brg.ai.sri.com/evidence-ontology/</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#EvidenceCodeVocabulary">http://www.biopax.org/release/biopax-level3.owl#EvidenceCodeVocabulary</seealso>
    let EvidenceCodeVocabulary =
        Prefixed_Name(biopax, "EvidenceCodeVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:EntityReferenceTypeVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definiiton: A reference to a term from an entity reference group ontology. As of the writing of this documentation, there is no standard ontology of these terms, though a common type is ‘homology’.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#EntityReferenceTypeVocabulary">http://www.biopax.org/release/biopax-level3.owl#EntityReferenceTypeVocabulary</seealso>
    let EntityReferenceTypeVocabulary =
        Prefixed_Name(biopax, "EntityReferenceTypeVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>biopax:structureFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies which format is used to define chemical structure data.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#structureFormat">http://www.biopax.org/release/biopax-level3.owl#structureFormat</seealso>
    let structureFormat = Prefixed_Name(biopax, "structureFormat") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A physical entity whose structure is comprised of other physical entities bound to each other covalently or non-covalently, at least one of which is a macromolecule (e.g. protein, DNA, or RNA) and the Stoichiometry of the components are known.
    ///
    /// Comment: Complexes must be stable enough to function as a biological unit; in general, the temporary association of an enzyme with its substrate(s) should not be considered or represented as a complex. A complex is the physical product of an interaction (complexAssembly) and is not itself considered an interaction.
    /// The boundaries on the size of complexes described by this class are not defined here, although possible, elements of the cell  such a mitochondria would typically not be described using this class (later versions of this ontology may include a cellularComponent class to represent these). The strength of binding cannot be described currently, but may be included in future versions of the ontology, depending on community need.
    /// Examples: Ribosome, RNA polymerase II. Other examples of this class include complexes of multiple protein monomers and complexes of proteins and small molecules.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Complex">http://www.biopax.org/release/biopax-level3.owl#Complex</seealso>
    let Complex = Prefixed_Name(biopax, "Complex") |> PrefixedName
    /// <summary>
    ///   <para>biopax:SmallMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A pool of molecules that are neither complexes nor are genetically encoded.
    ///
    /// Rationale: Identity of small molecules are based on structure, rather than sequence as in the case of DNA, RNA or Protein. A small molecule reference is a grouping of several small molecule entities  that have the same chemical structure.
    ///
    /// Usage : Smalle Molecules can have a cellular location and binding features. They can't have modification features as covalent modifications of small molecules are not considered as state changes but treated as different molecules.
    /// Some non-genomic macromolecules, such as large complex carbohydrates are currently covered by small molecules despite they lack a static structure. Better coverage for such molecules require representation of generic stoichiometry and polymerization, currently planned for BioPAX level 4.
    ///
    /// Examples: glucose, penicillin, phosphatidylinositol</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SmallMolecule">http://www.biopax.org/release/biopax-level3.owl#SmallMolecule</seealso>
    let SmallMolecule = Prefixed_Name(biopax, "SmallMolecule") |> PrefixedName

    /// <summary>
    ///   <para>biopax:memberPhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property stores the members of a generic physical entity.
    ///
    /// For representing homology generics a better way is to use generic entity references and generic features. However not all generic logic can be captured by this, such as complex generics or rare cases where feature cardinality is variable. Usages of this property should be limited to such cases.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#memberPhysicalEntity">http://www.biopax.org/release/biopax-level3.owl#memberPhysicalEntity</seealso>
    let memberPhysicalEntity =
        Prefixed_Name(biopax, "memberPhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biopax:Protein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A physical entity consisting of a sequence of amino acids; a protein monomer; a single polypeptide chain.
    /// Examples: The epidermal growth factor receptor (EGFR) protein.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Protein">http://www.biopax.org/release/biopax-level3.owl#Protein</seealso>
    let Protein = Prefixed_Name(biopax, "Protein") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An conversion in which molecules of one or more physicalEntity pools change their subcellular location and become a member of one or more other physicalEntity pools. A transport interaction does not include the transporter entity, even if one is required in order for the transport to occur. Instead, transporters are linked to transport interactions via the catalysis class.
    ///
    /// Usage: If there is a simultaneous chemical modification of the participant(s), use transportWithBiochemicalReaction class.
    ///
    /// Synonyms: translocation.
    ///
    /// Examples: The movement of Na+ into the cell through an open voltage-gated channel.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Transport">http://www.biopax.org/release/biopax-level3.owl#Transport</seealso>
    let Transport = Prefixed_Name(biopax, "Transport") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A biological relationship between two or more entities.
    ///
    /// Rationale: In BioPAX, interactions are atomic from a database modeling perspective, i.e. interactions can not be decomposed into sub-interactions. When representing non-atomic continuants with explicit subevents the pathway class should be used instead. Interactions are not necessarily  temporally atomic, for example genetic interactions cover a large span of time. Interactions as a formal concept is a continuant, it retains its identitiy regardless of time, or any differences in specific states or properties.
    ///
    /// Usage: Interaction is a highly abstract class and in almost all cases it is more appropriate to use one of the subclasses of interaction.
    /// It is partially possible to define generic reactions by using generic participants. A more comprehensive method is planned for BioPAX L4 for covering all generic cases like oxidization of a generic alcohol.
    ///
    /// Synonyms: Process, relationship, event.
    ///
    /// Examples: protein-protein interaction, biochemical reaction, enzyme catalysis</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Interaction">http://www.biopax.org/release/biopax-level3.owl#Interaction</seealso>
    let Interaction = Prefixed_Name(biopax, "Interaction") |> PrefixedName
    /// <summary>
    ///   <para>biopax:xref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Values of this property define external cross-references from this entity to entities in external databases.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#xref">http://www.biopax.org/release/biopax-level3.owl#xref</seealso>
    let xref = Prefixed_Name(biopax, "xref") |> PrefixedName

    /// <summary>
    ///   <para>biopax:CovalentBindingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition : An entity feature that represent the covalently bound state of  a physical entity.
    ///
    /// Rationale: Most frequent covalent modifications to proteins and DNA, such as phosphorylation and metylation are covered by the ModificationFeature class. In these cases, the added groups are simple and stateless therefore they can be captured by a controlled vocabulary. In other cases, such as ThiS-Thilacyl-disulfide, the covalently linked molecules are best represented as a molecular complex. CovalentBindingFeature should be used to model such covalently linked complexes.
    ///
    /// Usage: Using this construct, it is possible to represent small molecules as a covalent complex of two other small molecules. The demarcation of small molecules is a general problem and is delegated to small molecule databases.The best practice is not to model using covalent complexes unless at least one of the participants is a protein, DNA or RNA.
    ///
    /// Examples:
    /// disulfide bond
    /// UhpC + glc-6P -&gt; Uhpc-glc-6p
    /// acetyl-ACP -&gt; decenoyl-ACP
    /// charged tRNA</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#CovalentBindingFeature">http://www.biopax.org/release/biopax-level3.owl#CovalentBindingFeature</seealso>
    let CovalentBindingFeature =
        Prefixed_Name(biopax, "CovalentBindingFeature") |> PrefixedName

    /// <summary>
    ///   <para>biopax:conversionDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents the direction of the reaction. If a reaction will run in a single direction under all biological contexts then it is considered irreversible and has a direction. Otherwise it is reversible.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#conversionDirection">http://www.biopax.org/release/biopax-level3.owl#conversionDirection</seealso>
    let conversionDirection =
        Prefixed_Name(biopax, "conversionDirection") |> PrefixedName

    /// <summary>
    ///   <para>biopax:relationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Definition:A controlled vocabulary term that defines the type of relationship that this xref defines.
    /// Usage: There is currently no controlled vocabulary of relationship types for BioPAX, although one will be created in the future as the usage of this property increases.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#relationshipType">http://www.biopax.org/release/biopax-level3.owl#relationshipType</seealso>
    let relationshipType = Prefixed_Name(biopax, "relationshipType") |> PrefixedName
    /// <summary>
    ///   <para>biopax:right</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The participants on the right side of the conversion interaction. Since conversion interactions may proceed in either the left-to-right or right-to-left direction, occupants of the RIGHT property may be either reactants or products. RIGHT is a sub-property of PARTICIPANTS.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#right">http://www.biopax.org/release/biopax-level3.owl#right</seealso>
    let right = Prefixed_Name(biopax, "right") |> PrefixedName
    /// <summary>
    ///   <para>biopax:RnaRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A region on a RNA molecule.
    /// Usage: RNARegion is not a pool of independent molecules but a subregion on these molecules. As such, every RNARegion has a defining RNA molecule.
    /// Examples: CDS, 3' UTR, Hairpin</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#RnaRegion">http://www.biopax.org/release/biopax-level3.owl#RnaRegion</seealso>
    let RnaRegion = Prefixed_Name(biopax, "RnaRegion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Dna</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A physical entity consisting of a sequence of deoxyribonucleotide monophosphates; a deoxyribonucleic acid.
    /// Usage: DNA should be used for pools of individual DNA molecules. For describing subregions on those molecules use DNARegion.
    /// Examples: a chromosome, a plasmid. A specific example is chromosome 7 of Homo sapiens.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Dna">http://www.biopax.org/release/biopax-level3.owl#Dna</seealso>
    let Dna = Prefixed_Name(biopax, "Dna") |> PrefixedName
    /// <summary>
    ///   <para>biopax:TemplateReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definiton: An interaction where a macromolecule is polymerized from a
    ///     template macromolecule.
    ///
    /// Rationale: This is an abstraction over multiple (not explicitly stated) biochemical
    ///     reactions. The ubiquitous molecules (NTP and amino acids) consumed are also usually
    ///     omitted. Template reaction is non-stoichiometric, does not obey law of
    ///     mass conservation and temporally non-atomic. It, however, provides a
    ///     mechanism to capture processes that are central to all living organisms.
    ///
    /// Usage: Regulation of TemplateReaction, e.g. via a transcription factor can be
    ///     captured using TemplateReactionRegulation. TemplateReaction can also be
    ///     indirect  for example, it is not necessary to represent intermediary mRNA
    ///     for describing expression of a protein. It was decided to not subclass
    ///     TemplateReaction to subtypes such as transcription of translation for the
    ///     sake of  simplicity. If needed these subclasses can be added in the
    ///     future.
    ///
    /// Examples: Transcription, translation, replication, reverse transcription. E.g.
    ///     DNA to RNA is transcription, RNA to protein is translation and DNA to
    ///     protein is protein expression from DNA.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#TemplateReaction">http://www.biopax.org/release/biopax-level3.owl#TemplateReaction</seealso>
    let TemplateReaction = Prefixed_Name(biopax, "TemplateReaction") |> PrefixedName
    /// <summary>
    ///   <para>biopax:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property lists the entities that participate in this interaction. For example, in a biochemical reaction, the participants are the union of the reactants and the products of the reaction. This property has a number of sub-properties, such as LEFT and RIGHT used in the biochemicalInteraction class. Any participant listed in a sub-property will automatically be assumed to also be in PARTICIPANTS by a number of software systems, including Protege, so this property should not contain any instances if there are instances contained in a sub-property.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#participant">http://www.biopax.org/release/biopax-level3.owl#participant</seealso>
    let participant = Prefixed_Name(biopax, "participant") |> PrefixedName

    /// <summary>
    ///   <para>biopax:ModificationFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An entity feature that represents  the covalently modified state of a dna, rna or a protein.
    ///
    /// Rationale: In Biology, identity of DNA, RNA and Protein entities are defined around a wildtype sequence. Covalent modifications to this basal sequence are represented using modificaton features. Since small molecules are identified based on their chemical structure, not sequence, a covalent modification to a small molecule would result in a different molecule.
    ///
    /// Usage: The added groups should be simple and stateless, such as phosphate or methyl groups and are captured by the modificationType controlled vocabulary. In other cases, such as covalently linked proteins, use CovalentBindingFeature instead.
    ///
    /// Instances: A phosphorylation on a protein, a methylation on a DNA.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ModificationFeature">http://www.biopax.org/release/biopax-level3.owl#ModificationFeature</seealso>
    let ModificationFeature =
        Prefixed_Name(biopax, "ModificationFeature") |> PrefixedName

    /// <summary>
    ///   <para>biopax:deltaGPrime0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>For biochemical reactions, this property refers to the standard transformed Gibbs energy change for a reaction written in terms of biochemical reactants (sums of species), delta-G'&lt;sup&gt;o&lt;/sup&gt;.
    ///
    ///   delta-G'&lt;sup&gt;o&lt;/sup&gt; = -RT lnK'
    /// and
    ///   delta-G'&lt;sup&gt;o&lt;/sup&gt; = delta-H'&lt;sup&gt;o&lt;/sup&gt; - T delta-S'&lt;sup&gt;o&lt;/sup&gt;
    ///
    /// delta-G'&lt;sup&gt;o&lt;/sup&gt; has units of kJ/mol.  Like K', it is a function of temperature (T), ionic strength (I), pH, and pMg (pMg = -log&lt;sub&gt;10&lt;/sub&gt;[Mg&lt;sup&gt;2+&lt;/sup&gt;]). Therefore, these quantities must be specified, and values for DELTA-G for biochemical reactions are represented as 5-tuples of the form (delta-G'&lt;sup&gt;o&lt;/sup&gt; T I pH pMg).</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#deltaGPrime0">http://www.biopax.org/release/biopax-level3.owl#deltaGPrime0</seealso>
    let deltaGPrime0 = Prefixed_Name(biopax, "deltaGPrime0") |> PrefixedName

    /// <summary>
    ///   <para>biopax:memberEntityReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An entity reference that qualifies for the definition of this group. For example a member of a PFAM protein family.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#memberEntityReference">http://www.biopax.org/release/biopax-level3.owl#memberEntityReference</seealso>
    let memberEntityReference =
        Prefixed_Name(biopax, "memberEntityReference") |> PrefixedName

    /// <summary>
    ///   <para>biopax:ProteinReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description: A protein reference is a grouping of several protein entities that are encoded by the same genetic sequence. Members can differ in any combination of cellular location, sequence features and bound partners.
    /// Rationale: Protein molecules, encoded by the same genetic sequence can be present in (combinatorially many) different states, as a result of post translational modifications and non-covalent bonds. Each state, chemically, is a different pool of molecules. They are, however, related to each other because:
    /// They all share the same "base" genetic sequence.
    /// They can only be converted to each other but not to any other protein
    /// Comments:Most Protein databases, including UniProt would map one to one with ProteinReferences in BioPAX.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#ProteinReference">http://www.biopax.org/release/biopax-level3.owl#ProteinReference</seealso>
    let ProteinReference = Prefixed_Name(biopax, "ProteinReference") |> PrefixedName

    /// <summary>
    ///   <para>biopax:SmallMoleculeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A small molecule reference is a grouping of several small molecule entities  that have the same chemical structure.  Members can differ in celular location and bound partners. Covalent modifications of small molecules are not considered as state changes but treated as different molecules.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SmallMoleculeReference">http://www.biopax.org/release/biopax-level3.owl#SmallMoleculeReference</seealso>
    let SmallMoleculeReference =
        Prefixed_Name(biopax, "SmallMoleculeReference") |> PrefixedName

    /// <summary>
    ///   <para>biopax:structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Defines the chemical structure and other information about this molecule, using an instance of class chemicalStructure.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#structure">http://www.biopax.org/release/biopax-level3.owl#structure</seealso>
    let structure = Prefixed_Name(biopax, "structure") |> PrefixedName
    /// <summary>
    ///   <para>biopax:GeneticInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition : Genetic interactions between genes occur when two genetic perturbations (e.g. mutations) have a combined phenotypic effect not caused by either perturbation alone. A gene participant in a genetic interaction represents the gene that is perturbed. Genetic interactions are not physical interactions but logical (AND) relationships. Their physical manifestations can be complex and span an arbitarily long duration.
    ///
    /// Rationale: Currently,  BioPAX provides a simple definition that can capture most genetic interactions described in the literature. In the future, if required, the definition can be extended to capture other logical relationships and different, participant specific phenotypes.
    ///
    /// Example: A synthetic lethal interaction occurs when cell growth is possible without either gene A OR B, but not without both gene A AND B. If you knock out A and B together, the cell will die.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#GeneticInteraction">http://www.biopax.org/release/biopax-level3.owl#GeneticInteraction</seealso>
    let GeneticInteraction = Prefixed_Name(biopax, "GeneticInteraction") |> PrefixedName
    /// <summary>
    ///   <para>biopax:nextStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The next step(s) of the pathway.  Contains zero or more pathwayStep instances.  If there is no next step, this property is empty. Multiple pathwayStep instances indicate pathway branching.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#nextStep">http://www.biopax.org/release/biopax-level3.owl#nextStep</seealso>
    let nextStep = Prefixed_Name(biopax, "nextStep") |> PrefixedName
    /// <summary>
    ///   <para>biopax:entityReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference entity for this physical entity.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#entityReference">http://www.biopax.org/release/biopax-level3.owl#entityReference</seealso>
    let entityReference = Prefixed_Name(biopax, "entityReference") |> PrefixedName
    /// <summary>
    ///   <para>biopax:RnaReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defintion: A RNA  reference is a grouping of several RNA entities that are either encoded by the same gene or replicates of the same genome.  Members can differ in celular location, sequence features and bound partners. Currently conformational states (such as hairpin) are not covered.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#RnaReference">http://www.biopax.org/release/biopax-level3.owl#RnaReference</seealso>
    let RnaReference = Prefixed_Name(biopax, "RnaReference") |> PrefixedName
    /// <summary>
    ///   <para>biopax:scoreSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property defines the source of the scoring methodology --
    /// a publication or web site describing the scoring methodology and the range of values.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#scoreSource">http://www.biopax.org/release/biopax-level3.owl#scoreSource</seealso>
    let scoreSource = Prefixed_Name(biopax, "scoreSource") |> PrefixedName
    /// <summary>
    ///   <para>biopax:DnaReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A DNA reference is a grouping of several DNA entities that are common in sequence.  Members can differ in celular location, sequence features, SNPs, mutations and bound partners.
    ///
    /// Comments : Note that this is not a reference gene. Genes are non-physical,stateless continuants. Their physical manifestations can span multiple DNA molecules, sometimes even across chromosomes due to regulatory regions. Similarly a gene is not necessarily made up of deoxyribonucleic acid and can be present in multiple copies ( which are different DNA regions).</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#DnaReference">http://www.biopax.org/release/biopax-level3.owl#DnaReference</seealso>
    let DnaReference = Prefixed_Name(biopax, "DnaReference") |> PrefixedName
    /// <summary>
    ///   <para>biopax:DnaRegionReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A DNARegionReference is a grouping of several DNARegion entities that are common in sequence and genomic position.  Members can differ in cellular location, sequence features, SNPs, mutations and bound partners.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#DnaRegionReference">http://www.biopax.org/release/biopax-level3.owl#DnaRegionReference</seealso>
    let DnaRegionReference = Prefixed_Name(biopax, "DnaRegionReference") |> PrefixedName
    /// <summary>
    ///   <para>biopax:RnaRegionReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A RNARegion reference is a grouping of several RNARegion entities that are common in sequence and genomic position.  Members can differ in celular location, sequence features, mutations and bound partners.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#RnaRegionReference">http://www.biopax.org/release/biopax-level3.owl#RnaRegionReference</seealso>
    let RnaRegionReference = Prefixed_Name(biopax, "RnaRegionReference") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: A discrete biological unit used when describing pathways.
    ///
    /// Rationale: Entity is the most abstract class for representing components of  a pathway. It includes both occurents (interactions and  pathways) and continuants (physical entities and genes). Loosely speaking, BioPAX Entity is an atomic scientific statement with an associated source, evidence and references.
    /// Usage: There is no recommended use-cases for instantiating this class. Please, use its subclasses instead.
    /// Synonyms: element, thing,biological unit, statement, observable.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Entity">http://www.biopax.org/release/biopax-level3.owl#Entity</seealso>
    let Entity = Prefixed_Name(biopax, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>biopax:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Confidence in the containing instance.  Usually a statistical measure.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#confidence">http://www.biopax.org/release/biopax-level3.owl#confidence</seealso>
    let confidence = Prefixed_Name(biopax, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>biopax:evidenceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A pointer to a term in an external controlled vocabulary, such as the GO, PSI-MI or BioCyc evidence codes, that describes the nature of the support, such as 'traceable author statement' or 'yeast two-hybrid'.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#evidenceCode">http://www.biopax.org/release/biopax-level3.owl#evidenceCode</seealso>
    let evidenceCode = Prefixed_Name(biopax, "evidenceCode") |> PrefixedName
    /// <summary>
    ///   <para>biopax:experimentalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The experimental forms associated with an evidence instance.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#experimentalForm">http://www.biopax.org/release/biopax-level3.owl#experimentalForm</seealso>
    let experimentalForm = Prefixed_Name(biopax, "experimentalForm") |> PrefixedName
    /// <summary>
    ///   <para>biopax:tissue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An external controlled vocabulary of tissue types.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#tissue">http://www.biopax.org/release/biopax-level3.owl#tissue</seealso>
    let tissue = Prefixed_Name(biopax, "tissue") |> PrefixedName
    /// <summary>
    ///   <para>biopax:subRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The sub region of a region or nucleic acid molecule. The sub region must be wholly part of the region, not outside of it.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#subRegion">http://www.biopax.org/release/biopax-level3.owl#subRegion</seealso>
    let subRegion = Prefixed_Name(biopax, "subRegion") |> PrefixedName
    /// <summary>
    ///   <para>biopax:temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Temperature in Celsius</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#temperature">http://www.biopax.org/release/biopax-level3.owl#temperature</seealso>
    let temperature = Prefixed_Name(biopax, "temperature") |> PrefixedName
    /// <summary>
    ///   <para>biopax:templateDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The direction of the template reaction on the template.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#templateDirection">http://www.biopax.org/release/biopax-level3.owl#templateDirection</seealso>
    let templateDirection = Prefixed_Name(biopax, "templateDirection") |> PrefixedName
    /// <summary>
    ///   <para>biopax:term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The external controlled vocabulary term.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#term">http://www.biopax.org/release/biopax-level3.owl#term</seealso>
    let term = Prefixed_Name(biopax, "term") |> PrefixedName
    /// <summary>
    ///   <para>biopax:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of the publication.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#title">http://www.biopax.org/release/biopax-level3.owl#title</seealso>
    let title = Prefixed_Name(biopax, "title") |> PrefixedName
    /// <summary>
    ///   <para>biopax:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The URL at which the publication can be found, if it is available through the Web.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#url">http://www.biopax.org/release/biopax-level3.owl#url</seealso>
    let url = Prefixed_Name(biopax, "url") |> PrefixedName
    /// <summary>
    ///   <para>biopax:BioSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The biological source (organism, tissue or cell type) of an Entity.
    ///
    /// Usage: Some entities are considered source-neutral (e.g. small molecules), and the biological source of others can be deduced from their constituentss (e.g. complex, pathway).
    ///
    /// Instances: HeLa cells, Homo sapiens, and mouse liver tissue.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#BioSource">http://www.biopax.org/release/biopax-level3.owl#BioSource</seealso>
    let BioSource = Prefixed_Name(biopax, "BioSource") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: The support for a particular assertion, such as the existence of an interaction or pathway.
    /// Usage: At least one of confidence, evidenceCode, or experimentalForm must be instantiated when creating an evidence instance. XREF may reference a publication describing the experimental evidence using a publicationXref or may store a description of the experiment in an experimental description database using a unificationXref (if the referenced experiment is the same) or relationshipXref (if it is not identical, but similar in some way e.g. similar in protocol). Evidence is meant to provide more information than just an xref to the source paper.
    /// Examples: A description of a molecular binding assay that was used to detect a protein-protein interaction.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Evidence">http://www.biopax.org/release/biopax-level3.owl#Evidence</seealso>
    let Evidence = Prefixed_Name(biopax, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>biopax:Stoichiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: Stoichiometric coefficient of a physical entity in the context of a conversion or complex.
    /// Usage: For each participating element there must be 0 or 1 stoichiometry element. A non-existing stoichiometric element is treated as unknown.
    /// This is an n-ary bridge for left, right and component properties. Relative stoichiometries ( e.g n, n+1) often used for describing polymerization is not supported.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#Stoichiometry">http://www.biopax.org/release/biopax-level3.owl#Stoichiometry</seealso>
    let Stoichiometry = Prefixed_Name(biopax, "Stoichiometry") |> PrefixedName

    /// <summary>
    ///   <para>biopax:BiochemicalPathwayStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: Imposes ordering on a step in a biochemical pathway.
    /// Retionale: A biochemical reaction can be reversible by itself, but can be physiologically directed in the context of a pathway, for instance due to flux of reactants and products.
    /// Usage: Only one conversion interaction can be ordered at a time, but multiple catalysis or modulation instances can be part of one step.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#BiochemicalPathwayStep">http://www.biopax.org/release/biopax-level3.owl#BiochemicalPathwayStep</seealso>
    let BiochemicalPathwayStep =
        Prefixed_Name(biopax, "BiochemicalPathwayStep") |> PrefixedName

    /// <summary>
    ///   <para>biopax:kPrime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The apparent equilibrium constant K'. Concentrations in the equilibrium constant equation refer to the total concentrations of  all forms of particular biochemical reactants. For example, in the equilibrium constant equation for the biochemical reaction in which ATP is hydrolyzed to ADP and inorganic phosphate:
    ///
    /// K' = [ADP][P&lt;sub&gt;i&lt;/sub&gt;]/[ATP],
    ///
    /// The concentration of ATP refers to the total concentration of all of the following species:
    ///
    /// [ATP] = [ATP&lt;sup&gt;4-&lt;/sup&gt;] + [HATP&lt;sup&gt;3-&lt;/sup&gt;] + [H&lt;sub&gt;2&lt;/sub&gt;ATP&lt;sup&gt;2-&lt;/sup&gt;] + [MgATP&lt;sup&gt;2-&lt;/sup&gt;] + [MgHATP&lt;sup&gt;-&lt;/sup&gt;] + [Mg&lt;sub&gt;2&lt;/sub&gt;ATP].
    ///
    /// The apparent equilibrium constant is formally dimensionless, and can be kept so by inclusion of as many of the terms (1 mol/dm&lt;sup&gt;3&lt;/sup&gt;) in the numerator or denominator as necessary.  It is a function of temperature (T), ionic strength (I), pH, and pMg (pMg = -log&lt;sub&gt;10&lt;/sub&gt;[Mg&lt;sup&gt;2+&lt;/sup&gt;]).
    /// (Definition from EcoCyc)</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#kPrime">http://www.biopax.org/release/biopax-level3.owl#kPrime</seealso>
    let kPrime = Prefixed_Name(biopax, "kPrime") |> PrefixedName
    /// <summary>
    ///   <para>biopax:PublicationXref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An xref that defines a reference to a publication such as a book, journal article, web page, or software manual.
    /// Usage:  The reference may or may not be in a database, although references to PubMed are preferred when possible. The publication should make a direct reference to the instance it is attached to. Publication xrefs should make use of PubMed IDs wherever possible. The DB property of an xref to an entry in PubMed should use the string "PubMed" and not "MEDLINE".
    /// Examples: PubMed:10234245</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#PublicationXref">http://www.biopax.org/release/biopax-level3.owl#PublicationXref</seealso>
    let PublicationXref = Prefixed_Name(biopax, "PublicationXref") |> PrefixedName
    /// <summary>
    ///   <para>biopax:RelationshipXref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An xref that defines a reference to an entity in an external resource that does not have the same biological identity as the referring entity.
    /// Usage: There is currently no controlled vocabulary of relationship types for BioPAX, although one will be created in the future if a need develops.
    /// Examples: A link between a gene G in a BioPAX data collection, and the protein product P of that gene in an external database. This is not a unification xref because G and P are different biological entities (one is a gene and one is a protein). Another example is a relationship xref for a protein that refers to the Gene Ontology biological process, e.g. 'immune response,' that the protein is involved in.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#RelationshipXref">http://www.biopax.org/release/biopax-level3.owl#RelationshipXref</seealso>
    let RelationshipXref = Prefixed_Name(biopax, "RelationshipXref") |> PrefixedName
    /// <summary>
    ///   <para>biopax:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The value of the score. This can be a numerical or categorical value.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#value">http://www.biopax.org/release/biopax-level3.owl#value</seealso>
    let value = Prefixed_Name(biopax, "value") |> PrefixedName
    /// <summary>
    ///   <para>biopax:SequenceInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: An interval on a sequence.
    /// Usage: Interval is defined as an ordered pair of SequenceSites. All of the sequence from the begin site to the end site (inclusive) is described, not any subset.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SequenceInterval">http://www.biopax.org/release/biopax-level3.owl#SequenceInterval</seealso>
    let SequenceInterval = Prefixed_Name(biopax, "SequenceInterval") |> PrefixedName
    /// <summary>
    ///   <para>biopax:SequenceSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Definition: Describes a site on a sequence, i.e. the position of a single nucleotide or amino acid.
    /// Usage: A sequence site is always defined based on the reference sequence of the owning entity. For DNARegion and RNARegion it is relative to the region itself not the genome or full RNA molecule.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#SequenceSite">http://www.biopax.org/release/biopax-level3.owl#SequenceSite</seealso>
    let SequenceSite = Prefixed_Name(biopax, "SequenceSite") |> PrefixedName
    /// <summary>
    ///   <para>biopax:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sequence features of the owner physical entity.</para>
    /// </remarks>
    /// <seealso href="http://www.biopax.org/release/biopax-level3.owl#feature">http://www.biopax.org/release/biopax-level3.owl#feature</seealso>
    let feature = Prefixed_Name(biopax, "feature") |> PrefixedName
