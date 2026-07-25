namespace http.purl.org.net.tsnchange.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tsnchange =
    let _namespace_iri = Namespace_Iri tsnchange |> NamespaceIRI
    /// <summary>
    ///   <para>tsnchange:Appearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Appearance concept describes the appearance (or creation) of a new TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion) as an output to the change event. "Appearance" means the identifier of the new TSNFeature is different from all that already exist, in the input and output NomenclatureVersion. This concept is equivalent to the "Appearance" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    /// labels<para>Appearance</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Appearance">http://purl.org/net/tsnchange#Appearance</seealso>
    let Appearance = Prefixed_Name(tsnchange, "Appearance") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:inputLevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a LevelVersion is an input resource.</para>
    /// labels<para>inputLevelVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#inputLevelVersion">http://purl.org/net/tsnchange#inputLevelVersion</seealso>
    let inputLevelVersion =
        Prefixed_Name(tsnchange, "inputLevelVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:outputNomenclatureVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a NomenclatureVersion is an output resource.</para>
    /// labels<para>outputNomenclatureVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#outputNomenclatureVersion">http://purl.org/net/tsnchange#outputNomenclatureVersion</seealso>
    let outputNomenclatureVersion =
        Prefixed_Name(tsnchange, "outputNomenclatureVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:nomenclatureVersionBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a NomenclatureVersion before a change event.</para>
    /// labels<para>nomenclatureVersionBefore</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#nomenclatureVersionBefore">http://purl.org/net/tsnchange#nomenclatureVersionBefore</seealso>
    let nomenclatureVersionBefore =
        Prefixed_Name(tsnchange, "nomenclatureVersionBefore") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:outputTerritoryVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a TerritoryVersion is an output resource.</para>
    /// labels<para>outputTerritoryVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#outputTerritoryVersion">http://purl.org/net/tsnchange#outputTerritoryVersion</seealso>
    let outputTerritoryVersion =
        Prefixed_Name(tsnchange, "outputTerritoryVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:territoryVersionAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a TerritoryVersion after a change event.</para>
    /// labels<para>territoryVersionAfter</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#territoryVersionAfter">http://purl.org/net/tsnchange#territoryVersionAfter</seealso>
    let territoryVersionAfter =
        Prefixed_Name(tsnchange, "territoryVersionAfter") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change resource of which a TSNComponent is an output resource (i.e., a result of the Change event).</para>
    /// labels<para>output</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#output">http://purl.org/net/tsnchange#output</seealso>
    let output = Prefixed_Name(tsnchange, "output") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Assign a date to the change that occurred.</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#date">http://purl.org/net/tsnchange#date</seealso>
    let date = Prefixed_Name(tsnchange, "date") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:LevelChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The LevelChange concept describes all the changes undergone by a LevelVersion feature from one TSN version to another.</para>
    /// labels<para>LevelChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#LevelChange">http://purl.org/net/tsnchange#LevelChange</seealso>
    let LevelChange = Prefixed_Name(tsnchange, "LevelChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:outputUnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a UnitVersion is an output resource.</para>
    /// labels<para>outputUnitVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#outputUnitVersion">http://purl.org/net/tsnchange#outputUnitVersion</seealso>
    let outputUnitVersion =
        Prefixed_Name(tsnchange, "outputUnitVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:Rectification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Rectification concept describes operations of redistribution of the spatial area, without modifying the identity of all the input TSNFeatures (i.e., their identifier is not modified), but modifying their Geometry. The combination of footprints of the input TSNFeatures is equal to the combination of footprints of the output TSNFeatures. This concept is equivalent to the "Rectification" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>Rectification</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Rectification">http://purl.org/net/tsnchange#Rectification</seealso>
    let Rectification = Prefixed_Name(tsnchange, "Rectification") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Fusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Fusion concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single new TSNFeature that do not existed before the change. This operation leads to: (1) the disappearance of all the input TSNFeature(s) (i.e., the identity of the involved TSNFeatures is not extended after the Fusion); (2) the creation of one output TSNFeature whose footprint is equal to the combination of all the footprint of the input TSNFeatures. This concept is equivalent to the "Fusion" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>Fusion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Fusion">http://purl.org/net/tsnchange#Fusion</seealso>
    let Fusion = Prefixed_Name(tsnchange, "Fusion") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Merge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Merge concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single TSNFeature. This concept is equivalent to the "Union" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "fusion of 'n' zones into a single entity (union)".</para>
    /// labels<para>Merge</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Merge">http://purl.org/net/tsnchange#Merge</seealso>
    let Merge = Prefixed_Name(tsnchange, "Merge") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:levelVersionAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a LevelVersion after a change event.</para>
    /// labels<para>levelVersionAfter</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#levelVersionAfter">http://purl.org/net/tsnchange#levelVersionAfter</seealso>
    let levelVersionAfter =
        Prefixed_Name(tsnchange, "levelVersionAfter") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:levelVersionBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Level before a change event.</para>
    /// labels<para>levelVersionBefore</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#levelVersionBefore">http://purl.org/net/tsnchange#levelVersionBefore</seealso>
    let levelVersionBefore =
        Prefixed_Name(tsnchange, "levelVersionBefore") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:lowerChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a lower Change that is caused by the described Change. The Change hierarchy is alligned on the Nomenclature components hierarchy i.e., Nomenclature &gt; Territory &gt; Level &gt; Unit. Then a change that affect a Territory is above a change that affect the levels of the TSN.</para>
    /// labels<para>lowerChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#lowerChange">http://purl.org/net/tsnchange#lowerChange</seealso>
    let lowerChange = Prefixed_Name(tsnchange, "lowerChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:isPredecessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the predecessor Version of a Version resource.</para>
    /// labels<para>isPredecessorOf</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#isPredecessorOf">http://purl.org/net/tsnchange#isPredecessorOf</seealso>
    let isPredecessorOf = Prefixed_Name(tsnchange, "isPredecessorOf") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:isSuccessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the successor Version of a Version resource.</para>
    /// labels<para>isSuccessorOf</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#isSuccessorOf">http://purl.org/net/tsnchange#isSuccessorOf</seealso>
    let isSuccessorOf = Prefixed_Name(tsnchange, "isSuccessorOf") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Assign a name to the change that occurred.</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#label">http://purl.org/net/tsnchange#label</seealso>
    let label = Prefixed_Name(tsnchange, "label") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:territoryVersionBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a TerritoryVersion before a change event.</para>
    /// labels<para>territoryVersionBefore</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#territoryVersionBefore">http://purl.org/net/tsnchange#territoryVersionBefore</seealso>
    let territoryVersionBefore =
        Prefixed_Name(tsnchange, "territoryVersionBefore") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:unitVersionAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a UnitVersion after a change event.</para>
    /// labels<para>unitVersionAfter</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#unitVersionAfter">http://purl.org/net/tsnchange#unitVersionAfter</seealso>
    let unitVersionAfter = Prefixed_Name(tsnchange, "unitVersionAfter") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:unitVersionBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a UnitVersion before a change event.</para>
    /// labels<para>unitVersionBefore</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#unitVersionBefore">http://purl.org/net/tsnchange#unitVersionBefore</seealso>
    let unitVersionBefore =
        Prefixed_Name(tsnchange, "unitVersionBefore") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:AcronymChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The acronym of a TSNFeature changes.</para>
    /// labels<para>AcronymChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#AcronymChange">http://purl.org/net/tsnchange#AcronymChange</seealso>
    let AcronymChange = Prefixed_Name(tsnchange, "AcronymChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:ContinuationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContinuationChange concept describes restructuration operations that do not modify the identity of all the involved TSNFeatures that comes as input to the Change Operation.</para>
    /// labels<para>ContinuationChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#ContinuationChange">http://purl.org/net/tsnchange#ContinuationChange</seealso>
    let ContinuationChange =
        Prefixed_Name(tsnchange, "ContinuationChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:GeometryChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The GeometryChange concept describes modification of the Geometry of one TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion). This concept is equivalent to the "Transformation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "transformations processes involving chn-ange in shape or size: expansion, contraction and deformation (i.e. shape modification without size change)".</para>
    /// labels<para>GeometryChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#GeometryChange">http://purl.org/net/tsnchange#GeometryChange</seealso>
    let GeometryChange = Prefixed_Name(tsnchange, "GeometryChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:DerivationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The DerivationChange concept describes restructuration operations that do modify the identity of  TSNFeatures that comes as input to the Change Operation.</para>
    /// labels<para>DerivationChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#DerivationChange">http://purl.org/net/tsnchange#DerivationChange</seealso>
    let DerivationChange = Prefixed_Name(tsnchange, "DerivationChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Disappearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Disappearance concept describes the disappearance (or end) of a TSNFeature (i.e., TerritoryVersion, LevelVersion or UnitVersion) that comes as an input resource to the change event: the TSNFeature no longer exists after the change event i.e., no TSNFeature will carry its identifier in the output NomenclatureVersion. This concept is equivalent to the "Disappearance" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    /// labels<para>Disappearance</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Disappearance">http://purl.org/net/tsnchange#Disappearance</seealso>
    let Disappearance = Prefixed_Name(tsnchange, "Disappearance") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Extraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Extraction concept describes the split of one TSNFeature (into two or more TSNFeatures) that nevertheless maintains its identity after the change event (i.e., its identifier is not modified). This operation leads to: (1) the Appearance of at least one new TSNFeature as an output of the change event: this/those new TSNFeature(s) take(s) territory from the input TSNFeature ; (2) the Contraction of the footprint of the input TSNFeature that nevertheless still exist after the change event. This concept is equivalent to the "Extraction" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>Extraction</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Extraction">http://purl.org/net/tsnchange#Extraction</seealso>
    let Extraction = Prefixed_Name(tsnchange, "Extraction") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:inputTerritoryVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a TerritoryVersion is an input resource.</para>
    /// labels<para>inputTerritoryVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#inputTerritoryVersion">http://purl.org/net/tsnchange#inputTerritoryVersion</seealso>
    let inputTerritoryVersion =
        Prefixed_Name(tsnchange, "inputTerritoryVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:IdentificationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The IdentificationChange concept describes change(s) that modify the identifier, name, acronym and/or description attributs of one TSNFeature.</para>
    /// labels<para>IdentificationChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#IdentificationChange">http://purl.org/net/tsnchange#IdentificationChange</seealso>
    let IdentificationChange =
        Prefixed_Name(tsnchange, "IdentificationChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:FeatureChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The FeatureChange concept describes one or a set of changes that occur simultaneously and affect only one TSNFeature resource (i.e., TerritoryVersion, LevelVersion or UnitVersion). This concept is closed to the concept "Basic change" of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2). And, this concept is equivalent to the "LifeEvent:Transformation" concept from the model of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>FeatureChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#FeatureChange">http://purl.org/net/tsnchange#FeatureChange</seealso>
    let FeatureChange = Prefixed_Name(tsnchange, "FeatureChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Change</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Change concept is the super class of all types of change that may occur from one TSN version to another. A Change node may group under one node several changes on TSNFeatures that make sense grouped together. As "a change is rarely isolated and independent from the other changes that occur simultaneously within the other units inside a given area", we have to link "together all the various units that were involved in a common territorial change"  (Plumejeaud, C., Mathian, H., Gensel, J., Grasland, C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 25, 1597–1612 (2011)). The Change concept is based on the Change Bridge concept of (Kauppinen T, Hyvönen E. Modeling and reasoning about changes in ontology time series. In: Ontologies [Internet]. Springer; 2007. p. 319–338. Available from: http://link.springer.com/chapter/10.1007/978-0-387-37022-4_11): "A change bridge is associated with a change point and tells, what current concepts become obsolete (if any), what new concepts are created (if any), and how the new concepts overlap with older ones.".</para>
    /// labels<para>Change</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Change">http://purl.org/net/tsnchange#Change</seealso>
    let Change = Prefixed_Name(tsnchange, "Change") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:GeometryRestructuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The GeometryRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying their Geometry and sometime other attributs of the TSNFeatures. The set of TSNFeatures (TerritoryVersion, LevelVersion or UnitVersion) impacted by the GeometryRestructuration event is determined following the rule described by (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 25, 1597–1612 (2011)):"For any event type, a geometrical invariant defines the set of units involved in the one event: the combination of unit footprints that existed prior the event (preceding ones) is equal to the combination of unit footprints that are still in existence after the event (succeeding ones).". Except in case of GeometryRestructuration caused by a TerritoryChange that affect the external boundaries of the TerritoryVersion observed. Then, in this case, the set of TSNFeature (TerritoryVersion, LevelVersion or UnitVersion) impacted by the StructureChange event is determined following the rule: changes are grouped together if they occur simultaneously, inside a area which extends from the new territory boundaries to unit(s) boundaries that match the ones of unit(s) before the event. This concept is equivalent to the "evolution of spatial structure" notion from (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    /// labels<para>GeometryRestructuration</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#GeometryRestructuration">http://purl.org/net/tsnchange#GeometryRestructuration</seealso>
    let GeometryRestructuration =
        Prefixed_Name(tsnchange, "GeometryRestructuration") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:Contraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contraction of a TSNFeature, in terms of shape, means its size decrease between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Contraction" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    /// labels<para>Contraction</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Contraction">http://purl.org/net/tsnchange#Contraction</seealso>
    let Contraction = Prefixed_Name(tsnchange, "Contraction") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:DescriptionChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The description of a TSNFeature changes.</para>
    /// labels<para>DescriptionChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#DescriptionChange">http://purl.org/net/tsnchange#DescriptionChange</seealso>
    let DescriptionChange =
        Prefixed_Name(tsnchange, "DescriptionChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:Expansion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Expansion of a TSNFeature, in terms of shape, means its size increase between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Expansion" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    /// labels<para>Expansion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Expansion">http://purl.org/net/tsnchange#Expansion</seealso>
    let Expansion = Prefixed_Name(tsnchange, "Expansion") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Split</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Split concept describes the split of a TSNFeature, into two or more TSNFeature. This concept is equivalent to the "Split" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "division of a zone into 'n' parts (split)".</para>
    /// labels<para>Split</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Split">http://purl.org/net/tsnchange#Split</seealso>
    let Split = Prefixed_Name(tsnchange, "Split") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:inputUnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a UnitVersion is an input resource.</para>
    /// labels<para>inputUnitVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#inputUnitVersion">http://purl.org/net/tsnchange#inputUnitVersion</seealso>
    let inputUnitVersion = Prefixed_Name(tsnchange, "inputUnitVersion") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:isCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a societal or other cause to the described Change (e.g., administrative reform).</para>
    /// labels<para>isCausedBy</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#isCausedBy">http://purl.org/net/tsnchange#isCausedBy</seealso>
    let isCausedBy = Prefixed_Name(tsnchange, "isCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Reallocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Reallocation concept describes operations of redistribution of the spatial area that modify the identity of all the input TSNFeatures (i.e., their identifier is modified), and modify their Geometry. The combination of footprints of the input TSNFeatures is equal to the combination of footprints of the output TSNFeatures. This operation leads to: (1) the disappearance of all the 'n' input TSNFeatures ; (2) the creation of 'p' TSNFeatures as output to the change event by redistribution of the spatial area covered by the 'n' input TSNFeatures. This concept is equivalent to the "Reallocation" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>Reallocation</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Reallocation">http://purl.org/net/tsnchange#Reallocation</seealso>
    let Reallocation = Prefixed_Name(tsnchange, "Reallocation") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Deformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deformation of a TSNFeature describes shape modification without size change between the input NomenclatureVersion and the output NomenclatureVersion. This concept is equivalent to the "Deformation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2).</para>
    /// labels<para>Deformation</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Deformation">http://purl.org/net/tsnchange#Deformation</seealso>
    let Deformation = Prefixed_Name(tsnchange, "Deformation") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:UpperLevelChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The upper level  of a level changes.</para>
    /// labels<para>UpperLevelChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#UpperLevelChange">http://purl.org/net/tsnchange#UpperLevelChange</seealso>
    let UpperLevelChange = Prefixed_Name(tsnchange, "UpperLevelChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a TSNComponent after a change event.</para>
    /// labels<para>after</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#after">http://purl.org/net/tsnchange#after</seealso>
    let after = Prefixed_Name(tsnchange, "after") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a TSNComponent before a change event.</para>
    /// labels<para>before</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#before">http://purl.org/net/tsnchange#before</seealso>
    let before = Prefixed_Name(tsnchange, "before") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change resource  of which a TSNComponent is an input resource (i.e., an object subject to change).</para>
    /// labels<para>input</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#input">http://purl.org/net/tsnchange#input</seealso>
    let input = Prefixed_Name(tsnchange, "input") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:inputNomenclatureVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a NomenclatureVersion is an input resource.</para>
    /// labels<para>inputNomenclatureVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#inputNomenclatureVersion">http://purl.org/net/tsnchange#inputNomenclatureVersion</seealso>
    let inputNomenclatureVersion =
        Prefixed_Name(tsnchange, "inputNomenclatureVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:HierarchyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The HierarchyChange concept describes modification of the position of one TSNFeature (LevelVersion or UnitVersion) in the NomenclatureVersion hierarchy. For example, a Unit may change the Level it belongs to.</para>
    /// labels<para>HierarchyChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#HierarchyChange">http://purl.org/net/tsnchange#HierarchyChange</seealso>
    let HierarchyChange = Prefixed_Name(tsnchange, "HierarchyChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:IdentifierChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The identifier (within the TSN) of a TSNFeature changes.</para>
    /// labels<para>IdentifierChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#IdentifierChange">http://purl.org/net/tsnchange#IdentifierChange</seealso>
    let IdentifierChange = Prefixed_Name(tsnchange, "IdentifierChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:LevelBelongingChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The level a Unit belongs to changes.</para>
    /// labels<para>LevelBelongingChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#LevelBelongingChange">http://purl.org/net/tsnchange#LevelBelongingChange</seealso>
    let LevelBelongingChange =
        Prefixed_Name(tsnchange, "LevelBelongingChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:UnitHierarchyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The UnitHierarchyChange concept describes changes that affect TSNFeatures that are of type UnitVersion. It describes changes of the Unit position within the TSN hierarchy (e.g., change in the level it belongs to and/or Super unit change).</para>
    /// labels<para>UnitHierarchyChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#UnitHierarchyChange">http://purl.org/net/tsnchange#UnitHierarchyChange</seealso>
    let UnitHierarchyChange =
        Prefixed_Name(tsnchange, "UnitHierarchyChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:outputLevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Change of which a LevelVersion is an output resource.</para>
    /// labels<para>outputLevelVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#outputLevelVersion">http://purl.org/net/tsnchange#outputLevelVersion</seealso>
    let outputLevelVersion =
        Prefixed_Name(tsnchange, "outputLevelVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:nomenclatureVersionAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a NomenclatureVersion after a change event.</para>
    /// labels<para>nomenclatureVersionAfter</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#nomenclatureVersionAfter">http://purl.org/net/tsnchange#nomenclatureVersionAfter</seealso>
    let nomenclatureVersionAfter =
        Prefixed_Name(tsnchange, "nomenclatureVersionAfter") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:StructureChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The StructureChange concept describes restructuration operations that impact the TSN and several of its features simultaneously.</para>
    /// labels<para>StructureChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#StructureChange">http://purl.org/net/tsnchange#StructureChange</seealso>
    let StructureChange = Prefixed_Name(tsnchange, "StructureChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:HierarchyRestructuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The HierarchyRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying the hierarchy of the TSN. Those changes make sense grouped together (e.g., if a new Level integrate the nomenclature as well as new Unit composing this Level, then all those Appearance event of TSNFeatures will be grouped under one HierarchyRestructuration node).</para>
    /// labels<para>HierarchyRestructuration</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#HierarchyRestructuration">http://purl.org/net/tsnchange#HierarchyRestructuration</seealso>
    let HierarchyRestructuration =
        Prefixed_Name(tsnchange, "HierarchyRestructuration") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:IdentificationRestructuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The IdentificationRestructuration concept is a sub concept of the StructureChange concept. It describes changes that simultaneously affect several TSNFeature by modifying their attributs of identification. Those changes make sense grouped together (e.g., all the sub-units of a Super one are renamed).</para>
    /// labels<para>IdentificationRestructuration</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#IdentificationRestructuration">http://purl.org/net/tsnchange#IdentificationRestructuration</seealso>
    let IdentificationRestructuration =
        Prefixed_Name(tsnchange, "IdentificationRestructuration") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:Integration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Integration concept describes the merge of two or more TSNFeatures (e.g., merge of two TerritoryVersion or merge of two UnitVersion), into a single TSNFeature that existed before the change and maintains its identity after the change event (i.e., its identifier is not modified). This operation leads to: (1) the disappearance of at least one input TSNFeature ; (2) the Expansion of the footprint of the output TSNFeatures. Its new footprint is equal to the combination of all the footprint of the input TSNFeatures. This concept is equivalent to the "Integration" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>Integration</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Integration">http://purl.org/net/tsnchange#Integration</seealso>
    let Integration = Prefixed_Name(tsnchange, "Integration") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:LevelHierarchyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The LevelHierarchyChange concept describes changes that affect TSNFeatures that are of type LevelVersion. It describes changes of the Level position within the TSN hierarchy.</para>
    /// labels<para>LevelHierarchyChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#LevelHierarchyChange">http://purl.org/net/tsnchange#LevelHierarchyChange</seealso>
    let LevelHierarchyChange =
        Prefixed_Name(tsnchange, "LevelHierarchyChange") |> PrefixedName

    /// <summary>
    ///   <para>tsnchange:LowerLevelChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The lower level  of a level changes.</para>
    /// labels<para>LowerLevelChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#LowerLevelChange">http://purl.org/net/tsnchange#LowerLevelChange</seealso>
    let LowerLevelChange = Prefixed_Name(tsnchange, "LowerLevelChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:NameChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The name of a TSNFeature changes.</para>
    /// labels<para>NameChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#NameChange">http://purl.org/net/tsnchange#NameChange</seealso>
    let NameChange = Prefixed_Name(tsnchange, "NameChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:upperChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an upper Change that causes the described Change. The Change hierarchy is alligned on the Nomenclature components hierarchy i.e., Nomenclature &gt; Territory &gt; Level &gt; Unit. Then a change that affect a Territory is above a change that affect the levels of the TSN.</para>
    /// labels<para>upperChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#upperChange">http://purl.org/net/tsnchange#upperChange</seealso>
    let upperChange = Prefixed_Name(tsnchange, "upperChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Redistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Redistribution concept describes operations of redistribution of the spatial area covered by 'n' TSNFeature(s) in the input NomenclatureVersion to form 'p' TSNFeature(s) in the output NomenclatureVersion. This concept is equivalent to the "Re-allocation" concept of (Claramunt C, Thériault M. Managing Time in GIS An Event-Oriented Approach. In: Clifford J, Tuzhilin A, editors. Recent Advances in Temporal Databases. London: Springer London; 1995. p. 23–42. Available from: http://link.springer.com/10.1007/978-1-4471-3033-8_2): "reallocation of land covered by 'n' initial zones to form 'p' new zones ".</para>
    /// labels<para>Redistribution</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Redistribution">http://purl.org/net/tsnchange#Redistribution</seealso>
    let Redistribution = Prefixed_Name(tsnchange, "Redistribution") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:Scission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Scission concept describes the split of one TSNFeature (into two or more TSNFeatures) that ceases to exist after the change event. This operation leads to: (1) the disappearance of the input TSNFeature (i.e., the identity of this TSNFeature is not extended after the event i.e., at least the identifier of the TSNFeature is modified); (2) the creation of two or more Units in the NomenclatureVersion V+1 by split of the footprint of the input Unit in NomenclatureVersion V. This concept is equivalent to the "Scission" concept from the classification of territorial events of (Plumejeaud C, Mathian H, Gensel J, Grasland C. Spatio-temporal analysis of territorial changes from a multi-scale perspective. International Journal of Geographical Information Science. 2011;25(10):1597–1612).</para>
    /// labels<para>Scission</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#Scission">http://purl.org/net/tsnchange#Scission</seealso>
    let Scission = Prefixed_Name(tsnchange, "Scission") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:TerritoryChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The TerritoryChange concept describes all the changes undergone by a TerritoryVersion feature from one TSN version to another.</para>
    /// labels<para>TerritoryChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#TerritoryChange">http://purl.org/net/tsnchange#TerritoryChange</seealso>
    let TerritoryChange = Prefixed_Name(tsnchange, "TerritoryChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:UnitChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The UnitChange concept describes all the changes undergone by a UnitVersion feature from one TSN version to another.</para>
    /// labels<para>UnitChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#UnitChange">http://purl.org/net/tsnchange#UnitChange</seealso>
    let UnitChange = Prefixed_Name(tsnchange, "UnitChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:SuperUnitChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Super Unit of a Unit changes i.e., the Identifier of the Super Unit is not the same between the input and output NomenclatureVersion.</para>
    /// labels<para>SuperUnitChange</para></remarks>
    /// <seealso href="http://purl.org/net/tsnchange#SuperUnitChange">http://purl.org/net/tsnchange#SuperUnitChange</seealso>
    let SuperUnitChange = Prefixed_Name(tsnchange, "SuperUnitChange") |> PrefixedName
    /// <summary>
    ///   <para>tsnchange:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Second version of the vocabulary. It enables the description of new operations of restructuration of the TSN: IdentificationRestructuration and HierarchyRestructuration, operation that impact several features at the same time.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/tsnchange#">http://purl.org/net/tsnchange#</seealso>
    let _prefix_iri = Prefixed_Name(tsnchange, "") |> PrefixedName
