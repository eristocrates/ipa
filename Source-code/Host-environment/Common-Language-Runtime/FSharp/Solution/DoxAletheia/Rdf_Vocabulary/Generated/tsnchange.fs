namespace http.purl.org.net.tsnchange.hash

open DoxAletheia

module tsnchange =
    let _namespace_name = "http://purl.org/net/tsnchange#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The acronym of a TSNFeature changes.
    /// <see href="http://purl.org/net/tsnchange#AcronymChange"></see></summary>
    let AcronymChange = _prefix "AcronymChange"
    /// <summary>
    /// The IdentificationChange concept describes change(s) that modify the identifier, name, acronym and/or description attributs of one TSNFeature.
    /// <see href="http://purl.org/net/tsnchange#IdentificationChange"></see></summary>
    let IdentificationChange = _prefix "IdentificationChange"
    /// <summary>
    /// The Appearance concept describes the appearance (or creation) of a new TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion) as an output to the change event. "Appearance" means the identifier of the new TSNFeature is different from all that already exist, in the input and output NomenclatureVersion. This concept is equivalent to the "Appearance" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).
    /// <see href="http://purl.org/net/tsnchange#Appearance"></see></summary>
    let Appearance = _prefix "Appearance"
    /// <summary>
    /// The FeatureChange concept describes one or a set of changes that occur simultaneously and affect only one TSNFeature resource (i.e., TerritoryVersion, LevelVersion or UnitVersion). This concept is closed to the concept "Basic change" of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2). And, this concept is equivalent to the "LifeEvent:Transformation" concept from the model of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#FeatureChange"></see></summary>
    let FeatureChange = _prefix "FeatureChange"
    /// <summary>
    /// The Change concept is the super class of all types of change that may occur from one TSN version to another. A Change node may group under one node several changes on TSNFeatures that make sense grouped together. As "a change is rarely isolated and independent from the other changes that occur simultaneously within the other units inside a given area", we have to link "together all the various units that were involved in a common territorial change"  (Plumejeaud, C., Mathian, H., Gensel, J., Grasland, C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 25, 1597–1612 (2011)). The Change concept is based on the Change Bridge concept of (Kauppinen T, Hyvönen E. Modeling and reasoning about changes in ontology time series. In: Ontologies [Internet]. Springer; 2007. p. 319–338. Available from: http://link.springer.com/chapter/10.1007/978-0-387-37022-4_11): "A change bridge is associated with a change point and tells, what current concepts become obsolete (if any), what new concepts are created (if any), and how the new concepts overlap with older ones.".
    /// <see href="http://purl.org/net/tsnchange#Change"></see></summary>
    let Change = _prefix "Change"
    /// <summary>
    /// The ContinuationChange concept describes restructuration operations that do not modify the identity of all the involved TSNFeatures that comes as input to the Change Operation.
    /// <see href="http://purl.org/net/tsnchange#ContinuationChange"></see></summary>
    let ContinuationChange = _prefix "ContinuationChange"
    /// <summary>
    /// The GeometryRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying their Geometry and sometime other attributs of the TSNFeatures. The set of TSNFeatures (TerritoryVersion, LevelVersion or UnitVersion) impacted by the GeometryRestructuration event is determined following the rule described by (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 25, 1597–1612 (2011)):"For any event type, a geometrical invariant defines the set of units involved in the one event: the combination of unit footprints that existed prior the event (preceding ones) is equal to the combination of unit footprints that are still in existence after the event (succeeding ones).". Except in case of GeometryRestructuration caused by a TerritoryChange that affect the external boundaries of the TerritoryVersion observed. Then, in this case, the set of TSNFeature (TerritoryVersion, LevelVersion or UnitVersion) impacted by the StructureChange event is determined following the rule: changes are grouped together if they occur simultaneously, inside a area which extends from the new territory boundaries to unit(s) boundaries that match the ones of unit(s) before the event. This concept is equivalent to the "evolution of spatial structure" notion from (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).
    /// <see href="http://purl.org/net/tsnchange#GeometryRestructuration"></see></summary>
    let GeometryRestructuration = _prefix "GeometryRestructuration"
    /// <summary>
    /// Contraction of a TSNFeature, in terms of shape, means its size decrease between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Contraction" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).
    /// <see href="http://purl.org/net/tsnchange#Contraction"></see></summary>
    let Contraction = _prefix "Contraction"
    /// <summary>
    /// The GeometryChange concept describes modification of the Geometry of one TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion). This concept is equivalent to the "Transformation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "transformations processes involving chn-ange in shape or size: expansion, contraction and deformation (i.e. shape modification without size change)".
    /// <see href="http://purl.org/net/tsnchange#GeometryChange"></see></summary>
    let GeometryChange = _prefix "GeometryChange"
    /// <summary>
    /// Deformation of a TSNFeature describes shape modification without size change between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Deformation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).
    /// <see href="http://purl.org/net/tsnchange#Deformation"></see></summary>
    let Deformation = _prefix "Deformation"
    /// <summary>
    /// The DerivationChange concept describes restructuration operations that do modify the identity of  TSNFeatures that comes as input to the Change Operation.
    /// <see href="http://purl.org/net/tsnchange#DerivationChange"></see></summary>
    let DerivationChange = _prefix "DerivationChange"
    /// <summary>
    /// The description of a TSNFeature changes.
    /// <see href="http://purl.org/net/tsnchange#DescriptionChange"></see></summary>
    let DescriptionChange = _prefix "DescriptionChange"
    /// <summary>
    /// The Disappearance concept describes the disappearance (or end) of a TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion) that comes as an input resource to the change event: the TSNFeature no longer exists after the change event i.e., no TSNFeature will carry its identifier in the output NomenclatureVersion. This concept is equivalent to the "Disappearance" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).
    /// <see href="http://purl.org/net/tsnchange#Disappearance"></see></summary>
    let Disappearance = _prefix "Disappearance"
    /// <summary>
    /// Expansion of a TSNFeature, in terms of shape, means its size increase between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Expansion" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).
    /// <see href="http://purl.org/net/tsnchange#Expansion"></see></summary>
    let Expansion = _prefix "Expansion"
    /// <summary>
    /// The Extraction concept describes the split of one TSNFeature (into two or more TSNFeatures) that nevertheless maintains its identity after the change event (i.e., its identifier is not modified). This operation leads to: (1) the Appearance of at least one new TSNFeature as an output of the change event: this/those new TSNFeature(s) take(s) territory from the input TSNFeature ; (2) the Contraction of the footprint of the input TSNFeature that nevertheless still exist after the change event. This concept is equivalent to the "Extraction" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#Extraction"></see></summary>
    let Extraction = _prefix "Extraction"
    /// <summary>
    /// The Split concept describes the split of a TSNFeature, into two or more TSNFeature. This concept is equivalent to the "Split" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "division of a zone into 'n' parts (split)".
    /// <see href="http://purl.org/net/tsnchange#Split"></see></summary>
    let Split = _prefix "Split"
    /// <summary>
    /// The Fusion concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single new TSNFeature that do not existed before the change. This operation leads to: (1) the disappearance of all the input TSNFeature(s) (i.e., the identity of the involved TSNFeatures is not extended after the Fusion); (2) the creation of one output TSNFeature whose footprint is equal to the combination of all the footprint of the input TSNFeatures. This concept is equivalent to the "Fusion" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#Fusion"></see></summary>
    let Fusion = _prefix "Fusion"
    /// <summary>
    /// The Merge concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single TSNFeature. This concept is equivalent to the "Union" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "fusion of 'n' zones into a single entity (union)".
    /// <see href="http://purl.org/net/tsnchange#Merge"></see></summary>
    let Merge = _prefix "Merge"
    /// <summary>
    /// The StructureChange concept describes restructuration operations that impact the TSN and several of its features simultaneously.
    /// <see href="http://purl.org/net/tsnchange#StructureChange"></see></summary>
    let StructureChange = _prefix "StructureChange"
    /// <summary>
    /// The HierarchyChange concept describes modification of the position of one TSNFeature (LevelVersion or UnitVersion) in the NomenclatureVersion hierarchy. For example, a Unit may change the Level it belongs to.
    /// <see href="http://purl.org/net/tsnchange#HierarchyChange"></see></summary>
    let HierarchyChange = _prefix "HierarchyChange"
    /// <summary>
    /// The HierarchyRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying the hierarchy of the TSN. Those changes make sense grouped together (e.g., if a new Level integrate the nomenclature as well as new Unit composing this Level, then all those Appearance event of TSNFeatures will be grouped under one HierarchyRestructuration node).
    /// <see href="http://purl.org/net/tsnchange#HierarchyRestructuration"></see></summary>
    let HierarchyRestructuration = _prefix "HierarchyRestructuration"
    /// <summary>
    /// The IdentificationRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying their attributs of identification. Those changes make sense grouped together (e.g., all the sub-units of a Super one are renamed).
    /// <see href="http://purl.org/net/tsnchange#IdentificationRestructuration"></see></summary>
    let IdentificationRestructuration = _prefix "IdentificationRestructuration"
    /// <summary>
    /// The identifier (within the TSN) of a TSNFeature changes.
    /// <see href="http://purl.org/net/tsnchange#IdentifierChange"></see></summary>
    let IdentifierChange = _prefix "IdentifierChange"
    /// <summary>
    /// The Integration concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single TSNFeature that existed before the change and maintains its identity after the change event (i.e., its identifier is not modified). This operation leads to: (1) the disappearance of at least one input TSNFeature ; (2) the Expansion of the footprint of the output TSNFeatures. Its new footprint is equal to the combination of all the footprint of the input TSNFeatures. This concept is equivalent to the "Integration" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#Integration"></see></summary>
    let Integration = _prefix "Integration"
    /// <summary>
    /// The level a Unit belongs to changes.
    /// <see href="http://purl.org/net/tsnchange#LevelBelongingChange"></see></summary>
    let LevelBelongingChange = _prefix "LevelBelongingChange"
    /// <summary>
    /// The UnitHierarchyChange concept describes changes that affect TSNFeatures that are of type UnitVersion. It describes changes of the Unit position within the TSN hierarchy (e.g., change in the level it belongs to and/or Super unit change).
    /// <see href="http://purl.org/net/tsnchange#UnitHierarchyChange"></see></summary>
    let UnitHierarchyChange = _prefix "UnitHierarchyChange"
    /// <summary>
    /// The LevelChange concept describes all the changes undergone by a LevelVersion feature from one TSN version to another.
    /// <see href="http://purl.org/net/tsnchange#LevelChange"></see></summary>
    let LevelChange = _prefix "LevelChange"
    /// <summary>
    /// The LevelHierarchyChange concept describes changes that affect TSNFeatures that are of type LevelVersion. It describes changes of the Level position within the TSN hierarchy.
    /// <see href="http://purl.org/net/tsnchange#LevelHierarchyChange"></see></summary>
    let LevelHierarchyChange = _prefix "LevelHierarchyChange"
    /// <summary>
    /// The lower level  of a level changes.
    /// <see href="http://purl.org/net/tsnchange#LowerLevelChange"></see></summary>
    let LowerLevelChange = _prefix "LowerLevelChange"
    /// <summary>
    /// The name of a TSNFeature changes.
    /// <see href="http://purl.org/net/tsnchange#NameChange"></see></summary>
    let NameChange = _prefix "NameChange"
    /// <summary>
    /// The Reallocation concept describes operations of redistribution of the spatial area that modify the identity of all the input TSNFeatures (i.e., their identifier is modified), and modify their Geometry. The combination of footprints of the input TSNFeatures is equal to the combination of footprints of the output TSNFeatures. This operation leads to: (1) the disappearance of all the 'n' input TSNFeatures ; (2) the creation of 'p' TSNFeatures as output to the change event by redistribution of the spatial area covered by the 'n' input TSNFeatures. This concept is equivalent to the "Reallocation" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#Reallocation"></see></summary>
    let Reallocation = _prefix "Reallocation"
    /// <summary>
    /// The Redistribution concept describes operations of redistribution of the spatial area covered by 'n' TSNFeature(s) in the input NomenclatureVersion to form 'p' TSNFeature(s) in the output NomenclatureVersion. This concept is equivalent to the "Re-allocation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "reallocation of land covered by 'n' initial zones to form 'p' new zones ".
    /// <see href="http://purl.org/net/tsnchange#Redistribution"></see></summary>
    let Redistribution = _prefix "Redistribution"
    /// <summary>
    /// The Rectification concept describes operations of redistribution of the spatial area, without modifying the identity of all the input TSNFeatures (i.e., their identifier is not modified), but modifying their Geometry. The combination of footprints of the input TSNFeatures is equal to the combination of footprints of the output TSNFeatures. This concept is equivalent to the "Rectification" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#Rectification"></see></summary>
    let Rectification = _prefix "Rectification"
    /// <summary>
    /// The Scission concept describes the split of one TSNFeature (into two or more TSNFeatures) that ceases to exist after the change event. This operation leads to: (1) the disappearance of the input TSNFeature (i.e., the identity of this TSNFeature is not extended after the event i.e., at least the identifier of the TSNFeature is modified); (2) the creation of two or more Units in the NomenclatureVersion V+1 by split of the footprint of the input Unit in NomenclatureVersion V. This concept is equivalent to the "Scission" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).
    /// <see href="http://purl.org/net/tsnchange#Scission"></see></summary>
    let Scission = _prefix "Scission"
    /// <summary>
    /// The Super Unit of a Unit changes i.e., the Identifier of the Super Unit is not the same between the input and output NomenclatureVersion.
    /// <see href="http://purl.org/net/tsnchange#SuperUnitChange"></see></summary>
    let SuperUnitChange = _prefix "SuperUnitChange"
    /// <summary>
    /// The TerritoryChange concept describes all the changes undergone by a TerritoryVersion feature from one TSN version to another.
    /// <see href="http://purl.org/net/tsnchange#TerritoryChange"></see></summary>
    let TerritoryChange = _prefix "TerritoryChange"
    /// <summary>
    /// The UnitChange concept describes all the changes undergone by a UnitVersion feature from one TSN version to another.
    /// <see href="http://purl.org/net/tsnchange#UnitChange"></see></summary>
    let UnitChange = _prefix "UnitChange"
    /// <summary>
    /// The upper level  of a level changes.
    /// <see href="http://purl.org/net/tsnchange#UpperLevelChange"></see></summary>
    let UpperLevelChange = _prefix "UpperLevelChange"
    /// <summary>
    /// Indicates a TSNComponent after a change event.
    /// <see href="http://purl.org/net/tsnchange#after"></see></summary>
    let after = _prefix "after"
    /// <summary>
    /// Indicates a Change resource of which a TSNComponent is an output resource (i.e., a result of the Change event).
    /// <see href="http://purl.org/net/tsnchange#output"></see></summary>
    let output = _prefix "output"
    /// <summary>
    /// Indicates a TSNComponent before a change event.
    /// <see href="http://purl.org/net/tsnchange#before"></see></summary>
    let before = _prefix "before"
    /// <summary>
    /// Indicates a Change resource  of which a TSNComponent is an input resource (i.e., an object subject to change).
    /// <see href="http://purl.org/net/tsnchange#input"></see></summary>
    let input = _prefix "input"
    /// <summary>
    /// Assign a date to the change that occurred.
    /// <see href="http://purl.org/net/tsnchange#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// Indicates a Change of which a LevelVersion is an input resource.
    /// <see href="http://purl.org/net/tsnchange#inputLevelVersion"></see></summary>
    let inputLevelVersion = _prefix "inputLevelVersion"
    /// <summary>
    /// Indicates a Change of which a NomenclatureVersion is an input resource.
    /// <see href="http://purl.org/net/tsnchange#inputNomenclatureVersion"></see></summary>
    let inputNomenclatureVersion = _prefix "inputNomenclatureVersion"
    /// <summary>
    /// Indicates a Change of which a TerritoryVersion is an input resource.
    /// <see href="http://purl.org/net/tsnchange#inputTerritoryVersion"></see></summary>
    let inputTerritoryVersion = _prefix "inputTerritoryVersion"
    /// <summary>
    /// Indicates a Change of which a UnitVersion is an input resource.
    /// <see href="http://purl.org/net/tsnchange#inputUnitVersion"></see></summary>
    let inputUnitVersion = _prefix "inputUnitVersion"
    /// <summary>
    /// Indicates a societal or other cause to the described Change (e.g., administrative reform).
    /// <see href="http://purl.org/net/tsnchange#isCausedBy"></see></summary>
    let isCausedBy = _prefix "isCausedBy"
    /// <summary>
    /// Indicates the predecessor Version of a Version resource.
    /// <see href="http://purl.org/net/tsnchange#isPredecessorOf"></see></summary>
    let isPredecessorOf = _prefix "isPredecessorOf"
    /// <summary>
    /// Indicates the successor Version of a Version resource.
    /// <see href="http://purl.org/net/tsnchange#isSuccessorOf"></see></summary>
    let isSuccessorOf = _prefix "isSuccessorOf"
    /// <summary>
    /// Assign a name to the change that occurred.
    /// <see href="http://purl.org/net/tsnchange#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// Indicates a LevelVersion after a change event.
    /// <see href="http://purl.org/net/tsnchange#levelVersionAfter"></see></summary>
    let levelVersionAfter = _prefix "levelVersionAfter"
    /// <summary>
    /// Indicates a Change of which a LevelVersion is an output resource.
    /// <see href="http://purl.org/net/tsnchange#outputLevelVersion"></see></summary>
    let outputLevelVersion = _prefix "outputLevelVersion"
    /// <summary>
    /// Indicates a Level before a change event.
    /// <see href="http://purl.org/net/tsnchange#levelVersionBefore"></see></summary>
    let levelVersionBefore = _prefix "levelVersionBefore"
    /// <summary>
    /// Indicates a lower Change that is caused by the described Change. The Change hierarchy is alligned on the Nomenclature components hierarchy i.e., Nomenclature &gt; Territory &gt; Level &gt; Unit. Then a change that affect a Territory is above a change that affect the levels of the TSN.
    /// <see href="http://purl.org/net/tsnchange#lowerChange"></see></summary>
    let lowerChange = _prefix "lowerChange"
    /// <summary>
    /// Indicates a NomenclatureVersion after a change event.
    /// <see href="http://purl.org/net/tsnchange#nomenclatureVersionAfter"></see></summary>
    let nomenclatureVersionAfter = _prefix "nomenclatureVersionAfter"
    /// <summary>
    /// Indicates a Change of which a NomenclatureVersion is an output resource.
    /// <see href="http://purl.org/net/tsnchange#outputNomenclatureVersion"></see></summary>
    let outputNomenclatureVersion = _prefix "outputNomenclatureVersion"
    /// <summary>
    /// Indicates a NomenclatureVersion before a change event.
    /// <see href="http://purl.org/net/tsnchange#nomenclatureVersionBefore"></see></summary>
    let nomenclatureVersionBefore = _prefix "nomenclatureVersionBefore"
    /// <summary>
    /// Indicates a Change of which a TerritoryVersion is an output resource.
    /// <see href="http://purl.org/net/tsnchange#outputTerritoryVersion"></see></summary>
    let outputTerritoryVersion = _prefix "outputTerritoryVersion"
    /// <summary>
    /// Indicates a Change of which a UnitVersion is an output resource.
    /// <see href="http://purl.org/net/tsnchange#outputUnitVersion"></see></summary>
    let outputUnitVersion = _prefix "outputUnitVersion"
    /// <summary>
    /// Indicates a TerritoryVersion after a change event.
    /// <see href="http://purl.org/net/tsnchange#territoryVersionAfter"></see></summary>
    let territoryVersionAfter = _prefix "territoryVersionAfter"
    /// <summary>
    /// Indicates a TerritoryVersion before a change event.
    /// <see href="http://purl.org/net/tsnchange#territoryVersionBefore"></see></summary>
    let territoryVersionBefore = _prefix "territoryVersionBefore"
    /// <summary>
    /// Indicates a UnitVersion after a change event.
    /// <see href="http://purl.org/net/tsnchange#unitVersionAfter"></see></summary>
    let unitVersionAfter = _prefix "unitVersionAfter"
    /// <summary>
    /// Indicates a UnitVersion before a change event.
    /// <see href="http://purl.org/net/tsnchange#unitVersionBefore"></see></summary>
    let unitVersionBefore = _prefix "unitVersionBefore"
    /// <summary>
    /// Indicates an upper Change that causes the described Change. The Change hierarchy is alligned on the Nomenclature components hierarchy i.e., Nomenclature &gt; Territory &gt; Level &gt; Unit. Then a change that affect a Territory is above a change that affect the levels of the TSN.
    /// <see href="http://purl.org/net/tsnchange#upperChange"></see></summary>
    let upperChange = _prefix "upperChange"
