#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tsnc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/tsnchange#" "tsnc"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : AcronymChange</para>
    ///   <para>rdfs:comment : The acronym of a TSNFeature changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#AcronymChange">tsnc:AcronymChange</a>
    /// </summary>
    let AcronymChange = _prefixId.prefix "AcronymChange"
    /// <summary>
    ///   <para>rdfs:label : Appearance</para>
    ///   <para>rdfs:comment : The Appearance concept describes the appearance (or creation) of a new TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion) as an output to the change event. "Appearance" means the identifier of the new TSNFeature is different from all that already exist, in the input and output NomenclatureVersion. This concept is equivalent to the "Appearance" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    ///   <a href="http://purl.org/net/tsnchange#Appearance">tsnc:Appearance</a>
    /// </summary>
    let Appearance = _prefixId.prefix "Appearance"
    /// <summary>
    ///   <para>rdfs:label : Change</para>
    ///   <para>rdfs:comment : The Change concept is the super class of all types of change that may occur from one TSN version to another. A Change node may group under one node several changes on TSNFeatures that make sense grouped together. As "a change is rarely isolated and independent from the other changes that occur simultaneously within the other units inside a given area", we have to link "together all the various units that were involved in a common territorial change"  (Plumejeaud, C., Mathian, H., Gensel, J., Grasland, C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 25, 1597–1612 (2011)). The Change concept is based on the Change Bridge concept of (Kauppinen T, Hyvönen E. Modeling and reasoning about changes in ontology time series. In: Ontologies [Internet]. Springer; 2007. p. 319–338. Available from: http://link.springer.com/chapter/10.1007/978-0-387-37022-4_11): "A change bridge is associated with a change point and tells, what current concepts become obsolete (if any), what new concepts are created (if any), and how the new concepts overlap with older ones.".</para>
    ///   <a href="http://purl.org/net/tsnchange#Change">tsnc:Change</a>
    /// </summary>
    let Change = _prefixId.prefix "Change"
    /// <summary>
    ///   <para>rdfs:label : ContinuationChange</para>
    ///   <para>rdfs:comment : The ContinuationChange concept describes restructuration operations that do not modify the identity of all the involved TSNFeatures that comes as input to the Change Operation.</para>
    ///   <a href="http://purl.org/net/tsnchange#ContinuationChange">tsnc:ContinuationChange</a>
    /// </summary>
    let ContinuationChange = _prefixId.prefix "ContinuationChange"
    /// <summary>
    ///   <para>rdfs:label : Contraction</para>
    ///   <para>rdfs:comment : Contraction of a TSNFeature, in terms of shape, means its size decrease between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Contraction" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    ///   <a href="http://purl.org/net/tsnchange#Contraction">tsnc:Contraction</a>
    /// </summary>
    let Contraction = _prefixId.prefix "Contraction"
    /// <summary>
    ///   <para>rdfs:label : Deformation</para>
    ///   <para>rdfs:comment : Deformation of a TSNFeature describes shape modification without size change between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Deformation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    ///   <a href="http://purl.org/net/tsnchange#Deformation">tsnc:Deformation</a>
    /// </summary>
    let Deformation = _prefixId.prefix "Deformation"
    /// <summary>
    ///   <para>rdfs:label : DerivationChange</para>
    ///   <para>rdfs:comment : The DerivationChange concept describes restructuration operations that do modify the identity of  TSNFeatures that comes as input to the Change Operation.</para>
    ///   <a href="http://purl.org/net/tsnchange#DerivationChange">tsnc:DerivationChange</a>
    /// </summary>
    let DerivationChange = _prefixId.prefix "DerivationChange"
    /// <summary>
    ///   <para>rdfs:label : DescriptionChange</para>
    ///   <para>rdfs:comment : The description of a TSNFeature changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#DescriptionChange">tsnc:DescriptionChange</a>
    /// </summary>
    let DescriptionChange = _prefixId.prefix "DescriptionChange"
    /// <summary>
    ///   <para>rdfs:label : Disappearance</para>
    ///   <para>rdfs:comment : The Disappearance concept describes the disappearance (or end) of a TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion) that comes as an input resource to the change event: the TSNFeature no longer exists after the change event i.e., no TSNFeature will carry its identifier in the output NomenclatureVersion. This concept is equivalent to the "Disappearance" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    ///   <a href="http://purl.org/net/tsnchange#Disappearance">tsnc:Disappearance</a>
    /// </summary>
    let Disappearance = _prefixId.prefix "Disappearance"
    /// <summary>
    ///   <para>rdfs:label : Expansion</para>
    ///   <para>rdfs:comment : Expansion of a TSNFeature, in terms of shape, means its size increase between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Expansion" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    ///   <a href="http://purl.org/net/tsnchange#Expansion">tsnc:Expansion</a>
    /// </summary>
    let Expansion = _prefixId.prefix "Expansion"
    /// <summary>
    ///   <para>rdfs:label : Extraction</para>
    ///   <para>rdfs:comment : The Extraction concept describes the split of one TSNFeature (into two or more TSNFeatures) that nevertheless maintains its identity after the change event (i.e., its identifier is not modified). This operation leads to: (1) the Appearance of at least one new TSNFeature as an output of the change event: this/those new TSNFeature(s) take(s) territory from the input TSNFeature ; (2) the Contraction of the footprint of the input TSNFeature that nevertheless still exist after the change event. This concept is equivalent to the "Extraction" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#Extraction">tsnc:Extraction</a>
    /// </summary>
    let Extraction = _prefixId.prefix "Extraction"
    /// <summary>
    ///   <para>rdfs:label : FeatureChange</para>
    ///   <para>rdfs:comment : The FeatureChange concept describes one or a set of changes that occur simultaneously and affect only one TSNFeature resource (i.e., TerritoryVersion, LevelVersion or UnitVersion). This concept is closed to the concept "Basic change" of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2). And, this concept is equivalent to the "LifeEvent:Transformation" concept from the model of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#FeatureChange">tsnc:FeatureChange</a>
    /// </summary>
    let FeatureChange = _prefixId.prefix "FeatureChange"
    /// <summary>
    ///   <para>rdfs:label : Fusion</para>
    ///   <para>rdfs:comment : The Fusion concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single new TSNFeature that do not existed before the change. This operation leads to: (1) the disappearance of all the input TSNFeature(s) (i.e., the identity of the involved TSNFeatures is not extended after the Fusion); (2) the creation of one output TSNFeature whose footprint is equal to the combination of all the footprint of the input TSNFeatures. This concept is equivalent to the "Fusion" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#Fusion">tsnc:Fusion</a>
    /// </summary>
    let Fusion = _prefixId.prefix "Fusion"
    /// <summary>
    ///   <para>rdfs:label : GeometryChange</para>
    ///   <para>rdfs:comment : The GeometryChange concept describes modification of the Geometry of one TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion). This concept is equivalent to the "Transformation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "transformations processes involving chn-ange in shape or size: expansion, contraction and deformation (i.e. shape modification without size change)".</para>
    ///   <a href="http://purl.org/net/tsnchange#GeometryChange">tsnc:GeometryChange</a>
    /// </summary>
    let GeometryChange = _prefixId.prefix "GeometryChange"
    /// <summary>
    ///   <para>rdfs:label : GeometryRestructuration</para>
    ///   <para>rdfs:comment : The GeometryRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying their Geometry and sometime other attributs of the TSNFeatures. The set of TSNFeatures (TerritoryVersion, LevelVersion or UnitVersion) impacted by the GeometryRestructuration event is determined following the rule described by (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 25, 1597–1612 (2011)):"For any event type, a geometrical invariant defines the set of units involved in the one event: the combination of unit footprints that existed prior the event (preceding ones) is equal to the combination of unit footprints that are still in existence after the event (succeeding ones).". Except in case of GeometryRestructuration caused by a TerritoryChange that affect the external boundaries of the TerritoryVersion observed. Then, in this case, the set of TSNFeature (TerritoryVersion, LevelVersion or UnitVersion) impacted by the StructureChange event is determined following the rule: changes are grouped together if they occur simultaneously, inside a area which extends from the new territory boundaries to unit(s) boundaries that match the ones of unit(s) before the event. This concept is equivalent to the "evolution of spatial structure" notion from (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    ///   <a href="http://purl.org/net/tsnchange#GeometryRestructuration">tsnc:GeometryRestructuration</a>
    /// </summary>
    let GeometryRestructuration = _prefixId.prefix "GeometryRestructuration"
    /// <summary>
    ///   <para>rdfs:label : HierarchyChange</para>
    ///   <para>rdfs:comment : The HierarchyChange concept describes modification of the position of one TSNFeature (LevelVersion or UnitVersion) in the NomenclatureVersion hierarchy. For example, a Unit may change the Level it belongs to.</para>
    ///   <a href="http://purl.org/net/tsnchange#HierarchyChange">tsnc:HierarchyChange</a>
    /// </summary>
    let HierarchyChange = _prefixId.prefix "HierarchyChange"
    /// <summary>
    ///   <para>rdfs:label : HierarchyRestructuration</para>
    ///   <para>rdfs:comment : The HierarchyRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying the hierarchy of the TSN. Those changes make sense grouped together (e.g., if a new Level integrate the nomenclature as well as new Unit composing this Level, then all those Appearance event of TSNFeatures will be grouped under one HierarchyRestructuration node).</para>
    ///   <a href="http://purl.org/net/tsnchange#HierarchyRestructuration">tsnc:HierarchyRestructuration</a>
    /// </summary>
    let HierarchyRestructuration = _prefixId.prefix "HierarchyRestructuration"
    /// <summary>
    ///   <para>rdfs:label : IdentificationChange</para>
    ///   <para>rdfs:comment : The IdentificationChange concept describes change(s) that modify the identifier, name, acronym and/or description attributs of one TSNFeature.</para>
    ///   <a href="http://purl.org/net/tsnchange#IdentificationChange">tsnc:IdentificationChange</a>
    /// </summary>
    let IdentificationChange = _prefixId.prefix "IdentificationChange"
    /// <summary>
    ///   <para>rdfs:label : IdentificationRestructuration</para>
    ///   <para>rdfs:comment : The IdentificationRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying their attributs of identification. Those changes make sense grouped together (e.g., all the sub-units of a Super one are renamed).</para>
    ///   <a href="http://purl.org/net/tsnchange#IdentificationRestructuration">tsnc:IdentificationRestructuration</a>
    /// </summary>
    let IdentificationRestructuration = _prefixId.prefix "IdentificationRestructuration"
    /// <summary>
    ///   <para>rdfs:label : IdentifierChange</para>
    ///   <para>rdfs:comment : The identifier (within the TSN) of a TSNFeature changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#IdentifierChange">tsnc:IdentifierChange</a>
    /// </summary>
    let IdentifierChange = _prefixId.prefix "IdentifierChange"
    /// <summary>
    ///   <para>rdfs:label : Integration</para>
    ///   <para>rdfs:comment : The Integration concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single TSNFeature that existed before the change and maintains its identity after the change event (i.e., its identifier is not modified). This operation leads to: (1) the disappearance of at least one input TSNFeature ; (2) the Expansion of the footprint of the output TSNFeatures. Its new footprint is equal to the combination of all the footprint of the input TSNFeatures. This concept is equivalent to the "Integration" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#Integration">tsnc:Integration</a>
    /// </summary>
    let Integration = _prefixId.prefix "Integration"
    /// <summary>
    ///   <para>rdfs:label : LevelBelongingChange</para>
    ///   <para>rdfs:comment : The level a Unit belongs to changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#LevelBelongingChange">tsnc:LevelBelongingChange</a>
    /// </summary>
    let LevelBelongingChange = _prefixId.prefix "LevelBelongingChange"
    /// <summary>
    ///   <para>rdfs:label : LevelChange</para>
    ///   <para>rdfs:comment : The LevelChange concept describes all the changes undergone by a LevelVersion feature from one TSN version to another.</para>
    ///   <a href="http://purl.org/net/tsnchange#LevelChange">tsnc:LevelChange</a>
    /// </summary>
    let LevelChange = _prefixId.prefix "LevelChange"
    /// <summary>
    ///   <para>rdfs:label : LevelHierarchyChange</para>
    ///   <para>rdfs:comment : The LevelHierarchyChange concept describes changes that affect TSNFeatures that are of type LevelVersion. It describes changes of the Level position within the TSN hierarchy.</para>
    ///   <a href="http://purl.org/net/tsnchange#LevelHierarchyChange">tsnc:LevelHierarchyChange</a>
    /// </summary>
    let LevelHierarchyChange = _prefixId.prefix "LevelHierarchyChange"
    /// <summary>
    ///   <para>rdfs:label : LowerLevelChange</para>
    ///   <para>rdfs:comment : The lower level  of a level changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#LowerLevelChange">tsnc:LowerLevelChange</a>
    /// </summary>
    let LowerLevelChange = _prefixId.prefix "LowerLevelChange"
    /// <summary>
    ///   <para>rdfs:label : Merge</para>
    ///   <para>rdfs:comment : The Merge concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single TSNFeature. This concept is equivalent to the "Union" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "fusion of 'n' zones into a single entity (union)".</para>
    ///   <a href="http://purl.org/net/tsnchange#Merge">tsnc:Merge</a>
    /// </summary>
    let Merge = _prefixId.prefix "Merge"
    /// <summary>
    ///   <para>rdfs:label : NameChange</para>
    ///   <para>rdfs:comment : The name of a TSNFeature changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#NameChange">tsnc:NameChange</a>
    /// </summary>
    let NameChange = _prefixId.prefix "NameChange"
    /// <summary>
    ///   <para>rdfs:label : Reallocation</para>
    ///   <para>rdfs:comment : The Reallocation concept describes operations of redistribution of the spatial area that modify the identity of all the input TSNFeatures (i.e., their identifier is modified), and modify their Geometry. The combination of footprints of the input TSNFeatures is equal to the combination of footprints of the output TSNFeatures. This operation leads to: (1) the disappearance of all the 'n' input TSNFeatures ; (2) the creation of 'p' TSNFeatures as output to the change event by redistribution of the spatial area covered by the 'n' input TSNFeatures. This concept is equivalent to the "Reallocation" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#Reallocation">tsnc:Reallocation</a>
    /// </summary>
    let Reallocation = _prefixId.prefix "Reallocation"
    /// <summary>
    ///   <para>rdfs:label : Rectification</para>
    ///   <para>rdfs:comment : The Rectification concept describes operations of redistribution of the spatial area, without modifying the identity of all the input TSNFeatures (i.e., their identifier is not modified), but modifying their Geometry. The combination of footprints of the input TSNFeatures is equal to the combination of footprints of the output TSNFeatures. This concept is equivalent to the "Rectification" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#Rectification">tsnc:Rectification</a>
    /// </summary>
    let Rectification = _prefixId.prefix "Rectification"
    /// <summary>
    ///   <para>rdfs:label : Redistribution</para>
    ///   <para>rdfs:comment : The Redistribution concept describes operations of redistribution of the spatial area covered by 'n' TSNFeature(s) in the input NomenclatureVersion to form 'p' TSNFeature(s) in the output NomenclatureVersion. This concept is equivalent to the "Re-allocation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "reallocation of land covered by 'n' initial zones to form 'p' new zones ".</para>
    ///   <a href="http://purl.org/net/tsnchange#Redistribution">tsnc:Redistribution</a>
    /// </summary>
    let Redistribution = _prefixId.prefix "Redistribution"
    /// <summary>
    ///   <para>rdfs:label : Scission</para>
    ///   <para>rdfs:comment : The Scission concept describes the split of one TSNFeature (into two or more TSNFeatures) that ceases to exist after the change event. This operation leads to: (1) the disappearance of the input TSNFeature (i.e., the identity of this TSNFeature is not extended after the event i.e., at least the identifier of the TSNFeature is modified); (2) the creation of two or more Units in the NomenclatureVersion V+1 by split of the footprint of the input Unit in NomenclatureVersion V. This concept is equivalent to the "Scission" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    ///   <a href="http://purl.org/net/tsnchange#Scission">tsnc:Scission</a>
    /// </summary>
    let Scission = _prefixId.prefix "Scission"
    /// <summary>
    ///   <para>rdfs:label : Split</para>
    ///   <para>rdfs:comment : The Split concept describes the split of a TSNFeature, into two or more TSNFeature. This concept is equivalent to the "Split" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "division of a zone into 'n' parts (split)".</para>
    ///   <a href="http://purl.org/net/tsnchange#Split">tsnc:Split</a>
    /// </summary>
    let Split = _prefixId.prefix "Split"
    /// <summary>
    ///   <para>rdfs:label : StructureChange</para>
    ///   <para>rdfs:comment : The StructureChange concept describes restructuration operations that impact the TSN and several of its features simultaneously.</para>
    ///   <a href="http://purl.org/net/tsnchange#StructureChange">tsnc:StructureChange</a>
    /// </summary>
    let StructureChange = _prefixId.prefix "StructureChange"
    /// <summary>
    ///   <para>rdfs:label : SuperUnitChange</para>
    ///   <para>rdfs:comment : The Super Unit of a Unit changes i.e., the Identifier of the Super Unit is not the same between the input and output NomenclatureVersion.</para>
    ///   <a href="http://purl.org/net/tsnchange#SuperUnitChange">tsnc:SuperUnitChange</a>
    /// </summary>
    let SuperUnitChange = _prefixId.prefix "SuperUnitChange"
    /// <summary>
    ///   <para>rdfs:label : TerritoryChange</para>
    ///   <para>rdfs:comment : The TerritoryChange concept describes all the changes undergone by a TerritoryVersion feature from one TSN version to another.</para>
    ///   <a href="http://purl.org/net/tsnchange#TerritoryChange">tsnc:TerritoryChange</a>
    /// </summary>
    let TerritoryChange = _prefixId.prefix "TerritoryChange"
    /// <summary>
    ///   <para>rdfs:label : UnitChange</para>
    ///   <para>rdfs:comment : The UnitChange concept describes all the changes undergone by a UnitVersion feature from one TSN version to another.</para>
    ///   <a href="http://purl.org/net/tsnchange#UnitChange">tsnc:UnitChange</a>
    /// </summary>
    let UnitChange = _prefixId.prefix "UnitChange"
    /// <summary>
    ///   <para>rdfs:label : UnitHierarchyChange</para>
    ///   <para>rdfs:comment : The UnitHierarchyChange concept describes changes that affect TSNFeatures that are of type UnitVersion. It describes changes of the Unit position within the TSN hierarchy (e.g., change in the level it belongs to and/or Super unit change).</para>
    ///   <a href="http://purl.org/net/tsnchange#UnitHierarchyChange">tsnc:UnitHierarchyChange</a>
    /// </summary>
    let UnitHierarchyChange = _prefixId.prefix "UnitHierarchyChange"
    /// <summary>
    ///   <para>rdfs:label : UpperLevelChange</para>
    ///   <para>rdfs:comment : The upper level  of a level changes.</para>
    ///   <a href="http://purl.org/net/tsnchange#UpperLevelChange">tsnc:UpperLevelChange</a>
    /// </summary>
    let UpperLevelChange = _prefixId.prefix "UpperLevelChange"
    /// <summary>
    ///   <para>rdfs:label : after</para>
    ///   <para>rdfs:comment : Indicates a TSNComponent after a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#after">tsnc:after</a>
    /// </summary>
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>rdfs:label : before</para>
    ///   <para>rdfs:comment : Indicates a TSNComponent before a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#before">tsnc:before</a>
    /// </summary>
    let before = _prefixId.prefix "before"
    /// <summary>
    ///   <para>rdfs:label : date</para>
    ///   <para>rdfs:comment : Assign a date to the change that occurred.</para>
    ///   <a href="http://purl.org/net/tsnchange#date">tsnc:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : input</para>
    ///   <para>rdfs:comment : Indicates a Change resource  of which a TSNComponent is an input resource (i.e., an object subject to change).</para>
    ///   <a href="http://purl.org/net/tsnchange#input">tsnc:input</a>
    /// </summary>
    let input = _prefixId.prefix "input"
    /// <summary>
    ///   <para>rdfs:label : inputLevelVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a LevelVersion is an input resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#inputLevelVersion">tsnc:inputLevelVersion</a>
    /// </summary>
    let inputLevelVersion = _prefixId.prefix "inputLevelVersion"
    /// <summary>
    ///   <para>rdfs:label : inputNomenclatureVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a NomenclatureVersion is an input resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#inputNomenclatureVersion">tsnc:inputNomenclatureVersion</a>
    /// </summary>
    let inputNomenclatureVersion = _prefixId.prefix "inputNomenclatureVersion"
    /// <summary>
    ///   <para>rdfs:label : inputTerritoryVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a TerritoryVersion is an input resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#inputTerritoryVersion">tsnc:inputTerritoryVersion</a>
    /// </summary>
    let inputTerritoryVersion = _prefixId.prefix "inputTerritoryVersion"
    /// <summary>
    ///   <para>rdfs:label : inputUnitVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a UnitVersion is an input resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#inputUnitVersion">tsnc:inputUnitVersion</a>
    /// </summary>
    let inputUnitVersion = _prefixId.prefix "inputUnitVersion"
    /// <summary>
    ///   <para>rdfs:label : isCausedBy</para>
    ///   <para>rdfs:comment : Indicates a societal or other cause to the described Change (e.g., administrative reform).</para>
    ///   <a href="http://purl.org/net/tsnchange#isCausedBy">tsnc:isCausedBy</a>
    /// </summary>
    let isCausedBy = _prefixId.prefix "isCausedBy"
    /// <summary>
    ///   <para>rdfs:label : isPredecessorOf</para>
    ///   <para>rdfs:comment : Indicates the predecessor Version of a Version resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#isPredecessorOf">tsnc:isPredecessorOf</a>
    /// </summary>
    let isPredecessorOf = _prefixId.prefix "isPredecessorOf"
    /// <summary>
    ///   <para>rdfs:label : isSuccessorOf</para>
    ///   <para>rdfs:comment : Indicates the successor Version of a Version resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#isSuccessorOf">tsnc:isSuccessorOf</a>
    /// </summary>
    let isSuccessorOf = _prefixId.prefix "isSuccessorOf"
    /// <summary>
    ///   <para>rdfs:label : label</para>
    ///   <para>rdfs:comment : Assign a name to the change that occurred.</para>
    ///   <a href="http://purl.org/net/tsnchange#label">tsnc:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : levelVersionAfter</para>
    ///   <para>rdfs:comment : Indicates a LevelVersion after a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#levelVersionAfter">tsnc:levelVersionAfter</a>
    /// </summary>
    let levelVersionAfter = _prefixId.prefix "levelVersionAfter"
    /// <summary>
    ///   <para>rdfs:label : levelVersionBefore</para>
    ///   <para>rdfs:comment : Indicates a Level before a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#levelVersionBefore">tsnc:levelVersionBefore</a>
    /// </summary>
    let levelVersionBefore = _prefixId.prefix "levelVersionBefore"
    /// <summary>
    ///   <para>rdfs:label : lowerChange</para>
    ///   <para>rdfs:comment : Indicates a lower Change that is caused by the described Change. The Change hierarchy is alligned on the Nomenclature components hierarchy i.e., Nomenclature &gt; Territory &gt; Level &gt; Unit. Then a change that affect a Territory is above a change that affect the levels of the TSN.</para>
    ///   <a href="http://purl.org/net/tsnchange#lowerChange">tsnc:lowerChange</a>
    /// </summary>
    let lowerChange = _prefixId.prefix "lowerChange"
    /// <summary>
    ///   <para>rdfs:label : nomenclatureVersionAfter</para>
    ///   <para>rdfs:comment : Indicates a NomenclatureVersion after a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#nomenclatureVersionAfter">tsnc:nomenclatureVersionAfter</a>
    /// </summary>
    let nomenclatureVersionAfter = _prefixId.prefix "nomenclatureVersionAfter"
    /// <summary>
    ///   <para>rdfs:label : nomenclatureVersionBefore</para>
    ///   <para>rdfs:comment : Indicates a NomenclatureVersion before a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#nomenclatureVersionBefore">tsnc:nomenclatureVersionBefore</a>
    /// </summary>
    let nomenclatureVersionBefore = _prefixId.prefix "nomenclatureVersionBefore"
    /// <summary>
    ///   <para>rdfs:label : output</para>
    ///   <para>rdfs:comment : Indicates a Change resource of which a TSNComponent is an output resource (i.e., a result of the Change event).</para>
    ///   <a href="http://purl.org/net/tsnchange#output">tsnc:output</a>
    /// </summary>
    let output = _prefixId.prefix "output"
    /// <summary>
    ///   <para>rdfs:label : outputLevelVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a LevelVersion is an output resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#outputLevelVersion">tsnc:outputLevelVersion</a>
    /// </summary>
    let outputLevelVersion = _prefixId.prefix "outputLevelVersion"
    /// <summary>
    ///   <para>rdfs:label : outputNomenclatureVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a NomenclatureVersion is an output resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#outputNomenclatureVersion">tsnc:outputNomenclatureVersion</a>
    /// </summary>
    let outputNomenclatureVersion = _prefixId.prefix "outputNomenclatureVersion"
    /// <summary>
    ///   <para>rdfs:label : outputTerritoryVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a TerritoryVersion is an output resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#outputTerritoryVersion">tsnc:outputTerritoryVersion</a>
    /// </summary>
    let outputTerritoryVersion = _prefixId.prefix "outputTerritoryVersion"
    /// <summary>
    ///   <para>rdfs:label : outputUnitVersion</para>
    ///   <para>rdfs:comment : Indicates a Change of which a UnitVersion is an output resource.</para>
    ///   <a href="http://purl.org/net/tsnchange#outputUnitVersion">tsnc:outputUnitVersion</a>
    /// </summary>
    let outputUnitVersion = _prefixId.prefix "outputUnitVersion"
    /// <summary>
    ///   <para>rdfs:label : territoryVersionAfter</para>
    ///   <para>rdfs:comment : Indicates a TerritoryVersion after a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#territoryVersionAfter">tsnc:territoryVersionAfter</a>
    /// </summary>
    let territoryVersionAfter = _prefixId.prefix "territoryVersionAfter"
    /// <summary>
    ///   <para>rdfs:label : territoryVersionBefore</para>
    ///   <para>rdfs:comment : Indicates a TerritoryVersion before a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#territoryVersionBefore">tsnc:territoryVersionBefore</a>
    /// </summary>
    let territoryVersionBefore = _prefixId.prefix "territoryVersionBefore"
    /// <summary>
    ///   <para>rdfs:label : unitVersionAfter</para>
    ///   <para>rdfs:comment : Indicates a UnitVersion after a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#unitVersionAfter">tsnc:unitVersionAfter</a>
    /// </summary>
    let unitVersionAfter = _prefixId.prefix "unitVersionAfter"
    /// <summary>
    ///   <para>rdfs:label : unitVersionBefore</para>
    ///   <para>rdfs:comment : Indicates a UnitVersion before a change event.</para>
    ///   <a href="http://purl.org/net/tsnchange#unitVersionBefore">tsnc:unitVersionBefore</a>
    /// </summary>
    let unitVersionBefore = _prefixId.prefix "unitVersionBefore"
    /// <summary>
    ///   <para>rdfs:label : upperChange</para>
    ///   <para>rdfs:comment : Indicates an upper Change that causes the described Change. The Change hierarchy is alligned on the Nomenclature components hierarchy i.e., Nomenclature &gt; Territory &gt; Level &gt; Unit. Then a change that affect a Territory is above a change that affect the levels of the TSN.</para>
    ///   <a href="http://purl.org/net/tsnchange#upperChange">tsnc:upperChange</a>
    /// </summary>
    let upperChange = _prefixId.prefix "upperChange"
