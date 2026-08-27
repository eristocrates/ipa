namespace https.w3id.org.semts.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module semts =
    let _namespace_iri = Namespace_Iri semts |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:semts/ontology#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Semantic Time Series"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#">https://w3id.org/semts/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(semts, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to any algorithmic solution in the context of time series analysis. While this class extends the mls:Algorithm class, it enables a reference to further details on specific task specifics and experiments. It is considered method knowledge as this class can be used to define knowledge about an appropriate or optimal algorithmic solution associated with a time series segment."</para>
    /// labels<para>"Algorithm Recommendation"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#Algorithm">https://w3id.org/semts/ontology#Algorithm</seealso>
    let Algorithm = Prefixed_Name(semts, "Algorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#ArtificialTimeSeriesSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A time series segment that does not, or only partially refer to concrete time series data. It represents an artificially generated time series segment that might for instance describe the result of a forecast with a time index not being in the range of the original time series data."</para>
    /// labels<para>"Artificial Time Series Segment"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#ArtificialTimeSeriesSegment">https://w3id.org/semts/ontology#ArtificialTimeSeriesSegment</seealso>
    let ArtificialTimeSeriesSegment =
        Prefixed_Name(semts, "ArtificialTimeSeriesSegment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#DataDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines a data dimension (or also referred to as feature or attribute) in a time series segment."</para>
    /// labels<para>"Data Dimension"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#DataDimension">https://w3id.org/semts/ontology#DataDimension</seealso>
    let DataDimension = Prefixed_Name(semts, "DataDimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#DataKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines any knowledge that is derived from the data. This includes statistics, other signal characteristics or knowledge generated thorugh data analysis methods. Examples for the latter case are predictions, anomalies or cluster group memberships."</para>
    /// labels<para>"Data Knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#DataKnowledge">https://w3id.org/semts/ontology#DataKnowledge</seealso>
    let DataKnowledge = Prefixed_Name(semts, "DataKnowledge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#EmbeddedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to a value that is directly stored in the knowledge graph. Compared to referenced values, these values are rather single, non-complex values having a primitive type.
    /// One example could be the mean value of a univariate time series."</para>
    /// labels<para>"Embedded Value"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#EmbeddedValue">https://w3id.org/semts/ontology#EmbeddedValue</seealso>
    let EmbeddedValue = Prefixed_Name(semts, "EmbeddedValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#Hyperparameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hyperparameter is considered method knowledge as this class can be used to define knowledge about an appropriate or optimal hyperparameter setting associated with the analysis of a time series segment for a concrete task."</para>
    /// labels<para>"Parameter Recommendation"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#Hyperparameter">https://w3id.org/semts/ontology#Hyperparameter</seealso>
    let Hyperparameter = Prefixed_Name(semts, "Hyperparameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#Knowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the highest level of any knowledge associated with time series data. Knowledge can be made more specific via subclasses or associated concepts."</para>
    /// labels<para>"Knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#Knowledge">https://w3id.org/semts/ontology#Knowledge</seealso>
    let Knowledge = Prefixed_Name(semts, "Knowledge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeComparisonMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any knowledge that is generated by a comparison of compatible inputs. This might either be raw data or already defined knowledge. A simple example might be the result of a Euclidean distance."</para>
    /// labels<para>"Knowledge Comparison Measure"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeComparisonMeasure">https://w3id.org/semts/ontology#KnowledgeComparisonMeasure</seealso>
    let KnowledgeComparisonMeasure =
        Prefixed_Name(semts, "KnowledgeComparisonMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An SKOS concept associated with the knowledge class or any corresponding subclass"</para>
    /// labels<para>"Knowledge Concept"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeConcept">https://w3id.org/semts/ontology#KnowledgeConcept</seealso>
    let KnowledgeConcept = Prefixed_Name(semts, "KnowledgeConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGenerationConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An SKOS concept associated with the knowledge generation entity class or any corresponding subclass"</para>
    /// labels<para>"Knowledge Generation Concept"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGenerationConcept">https://w3id.org/semts/ontology#KnowledgeGenerationConcept</seealso>
    let KnowledgeGenerationConcept =
        Prefixed_Name(semts, "KnowledgeGenerationConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGenerationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the highest entity to define the process of knowledge generation. A more specific description can be provided by subclasses or assigned concepts. This class inherits from prov:Agent and thus allows for provenance during knowledge propagation."</para>
    /// labels<para>"Knowledge Generation Entity"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGenerationEntity">https://w3id.org/semts/ontology#KnowledgeGenerationEntity</seealso>
    let KnowledgeGenerationEntity =
        Prefixed_Name(semts, "KnowledgeGenerationEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGenerationIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines any input and output of a knowledge generation entity. It inherits from prov:Entity to define instances that are used by or generated by a prov:Activity, which in turn is the parental class of a knowledge generation entity."</para>
    /// labels<para>"Knowledge Generation IO"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGenerationIO">https://w3id.org/semts/ontology#KnowledgeGenerationIO</seealso>
    let KnowledgeGenerationIO =
        Prefixed_Name(semts, "KnowledgeGenerationIO") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGenerationInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines the input of a knowledge generation entity. While outputs can only contain produced knowledge, inputs might either reference knowledge or raw data."</para>
    /// labels<para>"Knowledge Generation Input"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGenerationInput">https://w3id.org/semts/ontology#KnowledgeGenerationInput</seealso>
    let KnowledgeGenerationInput =
        Prefixed_Name(semts, "KnowledgeGenerationInput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGenerationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines a knowledge generation entity, which corresponds to method-based solution. Compared to other knowledge generation entities this class is a subclass of Algorithm and thus can be linked to algorithmic details."</para>
    /// labels<para>"Knowledge Generation Method"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGenerationMethod">https://w3id.org/semts/ontology#KnowledgeGenerationMethod</seealso>
    let KnowledgeGenerationMethod =
        Prefixed_Name(semts, "KnowledgeGenerationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGenerationOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines the output of a knowledge generation entity. Compared to inputs, outputs only allow for a reference to generated knowledge and not to raw data. This, on purpose, excludes data transformations from the overall ontology concept by only focusing on a propagation of knowledge."</para>
    /// labels<para>"Knowledge Generation Output"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGenerationOutput">https://w3id.org/semts/ontology#KnowledgeGenerationOutput</seealso>
    let KnowledgeGenerationOutput =
        Prefixed_Name(semts, "KnowledgeGenerationOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A grouping of knowledge which itself is again considered knowledge. Can be used to structure knowledge and create hierarchies."</para>
    /// labels<para>"Knowledge Group"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeGroup">https://w3id.org/semts/ontology#KnowledgeGroup</seealso>
    let KnowledgeGroup = Prefixed_Name(semts, "KnowledgeGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeQualityMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines the goodness or confidence of time series knowledge associated with one or multiple segments. For knowledge produced by a knowledge generation method the quality measure is often equal to the evaluation metric of the generation method, which is why this class inherits from mls:EvaluationMeasure."</para>
    /// labels<para>"Knowledge Quality Measure"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeQualityMeasure">https://w3id.org/semts/ontology#KnowledgeQualityMeasure</seealso>
    let KnowledgeQualityMeasure =
        Prefixed_Name(semts, "KnowledgeQualityMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#KnowledgeReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To complement any knowledge that is generated via analytical methods, this class represents knowledge generated from reasoning processes. This also includes validation processes from human experts or results from reasoning tools.
    /// While many analysis results can be regarded unvalidated predictions, this class defines subsequent evaluations to further derive concrete facts or confirmations."</para>
    /// labels<para>"Knowledge Reasoning"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#KnowledgeReasoning">https://w3id.org/semts/ontology#KnowledgeReasoning</seealso>
    let KnowledgeReasoning = Prefixed_Name(semts, "KnowledgeReasoning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#MethodKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any knowledge that defines an appropriate setting, regarding a particular method that is beneficial or even optimal when analyzing a segment given a particular task."</para>
    /// labels<para>"Method Knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#MethodKnowledge">https://w3id.org/semts/ontology#MethodKnowledge</seealso>
    let MethodKnowledge = Prefixed_Name(semts, "MethodKnowledge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#ModelInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes a trained model in the traditional machine learning sense. It inherits from mls:Model and serves as a knowledge entity for subsequent predictions."</para>
    /// labels<para>"Model Instance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#ModelInstance">https://w3id.org/semts/ontology#ModelInstance</seealso>
    let ModelInstance = Prefixed_Name(semts, "ModelInstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#QualityMeasureConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An SKOS concept associated with the quality measure class"</para>
    /// labels<para>"Quality Measure Concept"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#QualityMeasureConcept">https://w3id.org/semts/ontology#QualityMeasureConcept</seealso>
    let QualityMeasureConcept =
        Prefixed_Name(semts, "QualityMeasureConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#ReferencedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to a value that is of arbitrary complexity and not directly stored in the knowledge graph. This class inherits from dcat:Dataset and can be retrieved by the associated metainformation. One example could be a set of generated shapelets defining representative segments of a time series."</para>
    /// labels<para>"Referenced Value"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#ReferencedValue">https://w3id.org/semts/ontology#ReferencedValue</seealso>
    let ReferencedValue = Prefixed_Name(semts, "ReferencedValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#ScenarioKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines any knowledge that is associated with a particular scenario or domain. Scenario knowledge corresponds to validated expert knowledge or scenario-specific facts. It includes simple notes, predefined labels or mathematical expressions describing the underlying time series data."</para>
    /// labels<para>"Scenario Knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#ScenarioKnowledge">https://w3id.org/semts/ontology#ScenarioKnowledge</seealso>
    let ScenarioKnowledge = Prefixed_Name(semts, "ScenarioKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#SegmentDataCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines analytical, data-specific insights including derived statistics or other structural characteristics such as representative kernel expressions. Knowledge of this class mostly equals extracted data features."</para>
    /// labels<para>"Segment Data Characteristic"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#SegmentDataCharacteristic">https://w3id.org/semts/ontology#SegmentDataCharacteristic</seealso>
    let SegmentDataCharacteristic =
        Prefixed_Name(semts, "SegmentDataCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#SegmentPrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines knowledge derived from data-driven analyses. This for instance includes anomalies and predictions."</para>
    /// labels<para>"Segment Prediction"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#SegmentPrediction">https://w3id.org/semts/ontology#SegmentPrediction</seealso>
    let SegmentPrediction = Prefixed_Name(semts, "SegmentPrediction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#SegmentRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SegmentRelation defines relations between multiple segment. Such a relation could for instance be a cross-correlation or the result of a distance metric."</para>
    /// labels<para>"Segment Relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#SegmentRelation">https://w3id.org/semts/ontology#SegmentRelation</seealso>
    let SegmentRelation = Prefixed_Name(semts, "SegmentRelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#TimeSeriesSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a segment (also referred to as slice) of a uni- or multivariate time series. Any segment can correspond to the whole time series, a subintervall potentially further limited to a subset of dimensions or only to a single data point. This class inherits from dcat:Dataset and is enriched by an additional time index, information about represented data dimensions and information about associated time series knowledge."</para>
    /// labels<para>"Time Series Segment"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#TimeSeriesSegment">https://w3id.org/semts/ontology#TimeSeriesSegment</seealso>
    let TimeSeriesSegment = Prefixed_Name(semts, "TimeSeriesSegment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This abstract class serves as parental class of EmbeddedValue and ReferencedValue."</para>
    /// labels<para>"Value"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#Value">https://w3id.org/semts/ontology#Value</seealso>
    let Value = Prefixed_Name(semts, "Value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#datasetColumnIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the column index of a time series segment within a data file or database, in case a source contains multiple time series (e.g. nested dataframes)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"column index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#datasetColumnIndex">https://w3id.org/semts/ontology#datasetColumnIndex</seealso>
    let datasetColumnIndex = Prefixed_Name(semts, "datasetColumnIndex") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#datasetRowIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the row index of a time series segment within a data file or database, in case a source contains multiple time series (e.g. nested dataframes)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"row index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#datasetRowIndex">https://w3id.org/semts/ontology#datasetRowIndex</seealso>
    let datasetRowIndex = Prefixed_Name(semts, "datasetRowIndex") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Can be used to optionally add a description to an entity of the domain."</para>
    /// labels<para>"description"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#description">https://w3id.org/semts/ontology#description</seealso>
    let description = Prefixed_Name(semts, "description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#dimensionPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies the position of the associated dimension within a dataframe or similar ordered data structures."</para>
    /// labels<para>"dimension position"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#dimensionPosition">https://w3id.org/semts/ontology#dimensionPosition</seealso>
    let dimensionPosition = Prefixed_Name(semts, "dimensionPosition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#generated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property reusing prov:generated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"generated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#generated">https://w3id.org/semts/ontology#generated</seealso>
    let generated = Prefixed_Name(semts, "generated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#groupKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"References any knowledge within a particular knowledge group."</para>
    /// labels<para>"group knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#groupKnowledge">https://w3id.org/semts/ontology#groupKnowledge</seealso>
    let groupKnowledge = Prefixed_Name(semts, "groupKnowledge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#hasDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Assigns a qudt:Datatype instance to an instance of a Value subclass or DataDimension"</para>
    /// labels<para>"value datatype"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#hasDatatype">https://w3id.org/semts/ontology#hasDatatype</seealso>
    let hasDatatype = Prefixed_Name(semts, "hasDatatype") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"dimensionUnit is the relation, which assigns a qudt:Unit instance to a DataDimension or a subclass of Value"</para>
    /// labels<para>"dimension unit"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#hasUnit">https://w3id.org/semts/ontology#hasUnit</seealso>
    let hasUnit = Prefixed_Name(semts, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relationship to the Value class and thus to allow for a reference to stored data."</para>
    /// labels<para>"has value"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#hasValue">https://w3id.org/semts/ontology#hasValue</seealso>
    let hasValue = Prefixed_Name(semts, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#inputDataReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the relation from a Knowledge Generation Input to a Time Series Segment and thus to metadata which specifies the underlying data."</para>
    /// labels<para>"input data reference"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#inputDataReference">https://w3id.org/semts/ontology#inputDataReference</seealso>
    let inputDataReference = Prefixed_Name(semts, "inputDataReference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#inputKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Similar to the Input Data Reference, this relation defines all the knowledge associated with the input of a Knowledge Generation Entity."</para>
    /// labels<para>"input knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#inputKnowledge">https://w3id.org/semts/ontology#inputKnowledge</seealso>
    let inputKnowledge = Prefixed_Name(semts, "inputKnowledge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a hierarchic relationship between time series segments. The intuition of this property is to differentiate between complete time series, in a sense that it includes the data from start to end and subsegments which are reduced in time or dimensionality and thus can be considered a slice of this original data."</para>
    /// labels<para>"is part of"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#isPartOf">https://w3id.org/semts/ontology#isPartOf</seealso>
    let isPartOf = Prefixed_Name(semts, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#knowledgeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a concept for a Knowledge instance. Can be used to assign concrete instances from the SemTS taxonomy."</para>
    /// labels<para>"knowledge concept"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#knowledgeConcept">https://w3id.org/semts/ontology#knowledgeConcept</seealso>
    let knowledgeConcept = Prefixed_Name(semts, "knowledgeConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#knowledgeGenerationConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relates a concept for a Knowledge Generation instance."</para>
    /// labels<para>"knowledge generation concept"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#knowledgeGenerationConcept">https://w3id.org/semts/ontology#knowledgeGenerationConcept</seealso>
    let knowledgeGenerationConcept =
        Prefixed_Name(semts, "knowledgeGenerationConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#knowledgeGenerationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates the Knowledge Generation Entity, which produced this Knowledge instance."</para>
    /// labels<para>"knowledge generation entity"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#knowledgeGenerationEntity">https://w3id.org/semts/ontology#knowledgeGenerationEntity</seealso>
    let knowledgeGenerationEntity =
        Prefixed_Name(semts, "knowledgeGenerationEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#knowledgeQualityMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allows to assign a quality measure to instantiated knowledge."</para>
    /// labels<para>"knowledge quality measure"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#knowledgeQualityMeasure">https://w3id.org/semts/ontology#knowledgeQualityMeasure</seealso>
    let knowledgeQualityMeasure =
        Prefixed_Name(semts, "knowledgeQualityMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#multiSegmentKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates any shared Knowledge available for a set of instances from the class Time Series Segment. One example is the generation of Knowledge that is not specific to a single, but to a group of time series segments."</para>
    /// labels<para>"multi segment knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#multiSegmentKnowledge">https://w3id.org/semts/ontology#multiSegmentKnowledge</seealso>
    let multiSegmentKnowledge =
        Prefixed_Name(semts, "multiSegmentKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#outputKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Opposed to Input Knowledge, this property defines the knowledge included in the output of a Knowledge generation Entity."</para>
    /// labels<para>"output knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#outputKnowledge">https://w3id.org/semts/ontology#outputKnowledge</seealso>
    let outputKnowledge = Prefixed_Name(semts, "outputKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#qualityMeasureConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the concept of a particular Knowledge Quality Measure."</para>
    /// labels<para>"quality measure concept"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#qualityMeasureConcept">https://w3id.org/semts/ontology#qualityMeasureConcept</seealso>
    let qualityMeasureConcept =
        Prefixed_Name(semts, "qualityMeasureConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:semts/ontology#segmentDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the dimensions associated with a Time Series Segment. Multiple dimensions indicate that the segment corresponds to a multivariate time series."</para>
    /// labels<para>"segment dimension"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#segmentDimension">https://w3id.org/semts/ontology#segmentDimension</seealso>
    let segmentDimension = Prefixed_Name(semts, "segmentDimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#segmentIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the index associated with a Time Series Segment. Inherits from the time:TemporalEntity."</para>
    /// labels<para>"segment index"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#segmentIndex">https://w3id.org/semts/ontology#segmentIndex</seealso>
    let segmentIndex = Prefixed_Name(semts, "segmentIndex") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#segmentKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates any Knowledge available for a particular Time Series Segment."</para>
    /// labels<para>"segment knowledge"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#segmentKnowledge">https://w3id.org/semts/ontology#segmentKnowledge</seealso>
    let segmentKnowledge = Prefixed_Name(semts, "segmentKnowledge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Can be used to optionally add a title to an entity of the domain."</para>
    /// labels<para>"title"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#title">https://w3id.org/semts/ontology#title</seealso>
    let title = Prefixed_Name(semts, "title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property reusing prov:used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#used">https://w3id.org/semts/ontology#used</seealso>
    let used = Prefixed_Name(semts, "used") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#valueString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The string representation for a concrete value of an Embedded Value. Complementary, the actual data type is defined via the dType property."</para>
    /// labels<para>"value string"</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#valueString">https://w3id.org/semts/ontology#valueString</seealso>
    let valueString = Prefixed_Name(semts, "valueString") |> PrefixedName
    /// <summary>
    ///   <para>w3id:semts/ontology#wasDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property reusing prov:wasDerivedFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"was derived from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/semts/ontology#wasDerivedFrom">https://w3id.org/semts/ontology#wasDerivedFrom</seealso>
    let wasDerivedFrom = Prefixed_Name(semts, "wasDerivedFrom") |> PrefixedName
