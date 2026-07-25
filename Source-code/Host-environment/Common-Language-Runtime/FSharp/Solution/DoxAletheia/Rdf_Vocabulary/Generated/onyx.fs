namespace http.www.gsi.dit.upm.es.ontologies.onyx.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module onyx =
    let _namespace_iri = Namespace_Iri onyx |> NamespaceIRI
    /// <summary>
    ///   <para>onyx:AppraisalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parent for Appraisal properties.</para>
    /// labels<para>AppraisalProperty</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AppraisalProperty">http://www.gsi.dit.upm.es/ontologies/onyx/ns#AppraisalProperty</seealso>
    let AppraisalProperty = Prefixed_Name(onyx, "AppraisalProperty") |> PrefixedName
    /// <summary>
    ///   <para>onyx:EmotionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the concept of emotion expressed in a certain text.</para>
    /// labels<para>EmotionSet</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionSet">http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionSet</seealso>
    let EmotionSet = Prefixed_Name(onyx, "EmotionSet") |> PrefixedName
    /// <summary>
    ///   <para>onyx:AggregatedEmotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The same as Emotion, used to aggregate several emotions</para>
    /// labels<para>AggregatedEmotion</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotion">http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotion</seealso>
    let AggregatedEmotion = Prefixed_Name(onyx, "AggregatedEmotion") |> PrefixedName
    /// <summary>
    ///   <para>onyx:EmotionAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of analysing the sentiment in an entity. It produces an onyx:emotion</para>
    /// labels<para>EmotionAnalysis</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionAnalysis">http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionAnalysis</seealso>
    let EmotionAnalysis = Prefixed_Name(onyx, "EmotionAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>onyx:EmotionModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents an Emotion Representation Model, grouping its categories, dimensions, properties...</para>
    /// labels<para>EmotionModel</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionModel">http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionModel</seealso>
    let EmotionModel = Prefixed_Name(onyx, "EmotionModel") |> PrefixedName
    /// <summary>
    ///   <para>onyx:Emotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that represents emotions in a generic way</para>
    /// labels<para>Emotion</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#Emotion">http://www.gsi.dit.upm.es/ontologies/onyx/ns#Emotion</seealso>
    let Emotion = Prefixed_Name(onyx, "Emotion") |> PrefixedName

    /// <summary>
    ///   <para>onyx:aggregatesEmotionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the emotions associated to this entity are a calculation (eg. average) of the emotions in other EmotionSets.</para>
    /// labels<para>aggregatesEmotionSet</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotionSet">http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotionSet</seealso>
    let aggregatesEmotionSet =
        Prefixed_Name(onyx, "aggregatesEmotionSet") |> PrefixedName

    /// <summary>
    ///   <para>onyx:extractedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the text from which the emotion has been extracted.</para>
    /// labels<para>extractedFrom</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#extractedFrom">http://www.gsi.dit.upm.es/ontologies/onyx/ns#extractedFrom</seealso>
    let extractedFrom = Prefixed_Name(onyx, "extractedFrom") |> PrefixedName
    /// <summary>
    ///   <para>onyx:aggregatesEmotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the AggregatedEmotion has been derived from other Emotions.</para>
    /// labels<para>aggregatesEmotion</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotion">http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotion</seealso>
    let aggregatesEmotion = Prefixed_Name(onyx, "aggregatesEmotion") |> PrefixedName
    /// <summary>
    ///   <para>onyx:algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The algorithm used in the Sentiment Analysis.</para>
    /// labels<para>algorithm</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithm">http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithm</seealso>
    let algorithm = Prefixed_Name(onyx, "algorithm") |> PrefixedName
    /// <summary>
    ///   <para>onyx:algorithmConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A numerical value that represents the accuracy of result as estimated by the algorithm itself (how much the emotion matches a gives object/product).</para>
    /// labels<para>algorithmConfidence</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithmConfidence">http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithmConfidence</seealso>
    let algorithmConfidence = Prefixed_Name(onyx, "algorithmConfidence") |> PrefixedName
    /// <summary>
    ///   <para>onyx:emotionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The exact text extract that expresses the emotion. This can be used when entity/text pointed by extractedFrom contains many emotions.
    ///
    /// For example extractedFrom can point to a comment that contains many emotions about a movie, each emotion should have a separate onyx:Emotion and optionally an emotionText  property to indicate the specific text fragment of the comment.</para>
    /// labels<para>emotionText</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#emotionText">http://www.gsi.dit.upm.es/ontologies/onyx/ns#emotionText</seealso>
    let emotionText = Prefixed_Name(onyx, "emotionText") |> PrefixedName
    /// <summary>
    ///   <para>onyx:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#domain">http://www.gsi.dit.upm.es/ontologies/onyx/ns#domain</seealso>
    let domain = Prefixed_Name(onyx, "domain") |> PrefixedName
    /// <summary>
    ///   <para>onyx:hasEmotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a certain text has a subjective emotion expressed in it.</para>
    /// labels<para>hasEmotion</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotion">http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotion</seealso>
    let hasEmotion = Prefixed_Name(onyx, "hasEmotion") |> PrefixedName
    /// <summary>
    ///   <para>onyx:hasEmotionCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value that represents the type of emotion.</para>
    /// labels<para>hasEmotionCategory</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionCategory">http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionCategory</seealso>
    let hasEmotionCategory = Prefixed_Name(onyx, "hasEmotionCategory") |> PrefixedName
    /// <summary>
    ///   <para>onyx:modelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Human readable name of the model</para>
    /// labels<para>modelName</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#modelName">http://www.gsi.dit.upm.es/ontologies/onyx/ns#modelName</seealso>
    let modelName = Prefixed_Name(onyx, "modelName") |> PrefixedName

    /// <summary>
    ///   <para>onyx:hasAppraisalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> Used to list the appraisals that a model defines</para>
    /// labels<para>hasAppraisalProperty</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasAppraisalProperty">http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasAppraisalProperty</seealso>
    let hasAppraisalProperty =
        Prefixed_Name(onyx, "hasAppraisalProperty") |> PrefixedName

    /// <summary>
    ///   <para>onyx:hasActionTendency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Action tendency of the Emotion.</para>
    /// labels<para>hasActionTendency</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasActionTendency">http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasActionTendency</seealso>
    let hasActionTendency = Prefixed_Name(onyx, "hasActionTendency") |> PrefixedName

    /// <summary>
    ///   <para>onyx:hasDimensionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> Used to define the Dimensions of an Emotion Model</para>
    /// labels<para>hasDimensionProperty</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasDimensionProperty">http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasDimensionProperty</seealso>
    let hasDimensionProperty =
        Prefixed_Name(onyx, "hasDimensionProperty") |> PrefixedName

    /// <summary>
    ///   <para>onyx:hasEmotionIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Value that quantifies the intensity of the emotion.</para>
    /// labels<para>hasEmotionIntensity</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionIntensity">http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionIntensity</seealso>
    let hasEmotionIntensity = Prefixed_Name(onyx, "hasEmotionIntensity") |> PrefixedName
    /// <summary>
    ///   <para>onyx:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source from which the emotion was extracted (URL, Site, Entity...)</para>
    /// labels<para>source</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#source">http://www.gsi.dit.upm.es/ontologies/onyx/ns#source</seealso>
    let source = Prefixed_Name(onyx, "source") |> PrefixedName
    /// <summary>
    ///   <para>onyx:sourceText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Optional value that contains the text from which the emotionText was taken.</para>
    /// labels<para>sourceText</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#sourceText">http://www.gsi.dit.upm.es/ontologies/onyx/ns#sourceText</seealso>
    let sourceText = Prefixed_Name(onyx, "sourceText") |> PrefixedName
    /// <summary>
    ///   <para>onyx:usesEmotionModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the Emotion Model used. Mainly used to describe Emotion Analysis activities.</para>
    /// labels<para>usesEmotionModel</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#usesEmotionModel">http://www.gsi.dit.upm.es/ontologies/onyx/ns#usesEmotionModel</seealso>
    let usesEmotionModel = Prefixed_Name(onyx, "usesEmotionModel") |> PrefixedName
    /// <summary>
    ///   <para>onyx:ActionTendency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action Tendency of the emotion: a desire to behave in select communicative or important actions that are connected to a particular feeling.</para>
    /// labels<para>ActionTendency</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#ActionTendency">http://www.gsi.dit.upm.es/ontologies/onyx/ns#ActionTendency</seealso>
    let ActionTendency = Prefixed_Name(onyx, "ActionTendency") |> PrefixedName

    /// <summary>
    ///   <para>onyx:AggregatedEmotionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The same as the EmotionSet class but indicates that the properties of this class aggregate all the emotions detected in the "extractedFrom" source. If the aggregatesEmotionSet property is used this class could be created to aggregate only certain emotions.</para>
    /// labels<para>AggregatedEmotionSet</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotionSet">http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotionSet</seealso>
    let AggregatedEmotionSet =
        Prefixed_Name(onyx, "AggregatedEmotionSet") |> PrefixedName

    /// <summary>
    ///   <para>onyx:DimensionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parent for Dimension properties.</para>
    /// labels<para>DimensionProperty</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#DimensionProperty">http://www.gsi.dit.upm.es/ontologies/onyx/ns#DimensionProperty</seealso>
    let DimensionProperty = Prefixed_Name(onyx, "DimensionProperty") |> PrefixedName
    /// <summary>
    ///   <para>onyx:EmotionCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that represents an emotion category (anger, happiness, etc.)</para>
    /// labels<para>EmotionCategory</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionCategory">http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionCategory</seealso>
    let EmotionCategory = Prefixed_Name(onyx, "EmotionCategory") |> PrefixedName
