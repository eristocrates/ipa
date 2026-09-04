#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module onyx =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.gsi.dit.upm.es/ontologies/onyx/ns#" "onyx"

    /// <summary>
    ///   <para>rdfs:label : ActionTendency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Action Tendency of the emotion: a desire to behave in select communicative or important actions that are connected to a particular feeling.^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#ActionTendency">onyx:ActionTendency</a>
    /// </summary>
    let ActionTendency = _prefixId.prefix "ActionTendency"
    /// <summary>
    ///   <para>rdfs:label : AggregatedEmotion^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : The same as Emotion, used to aggregate several emotions</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotion">onyx:AggregatedEmotion</a>
    /// </summary>
    let AggregatedEmotion = _prefixId.prefix "AggregatedEmotion"
    /// <summary>
    ///   <para>rdfs:label : AggregatedEmotionSet</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : The same as the EmotionSet class but indicates that the properties of this class aggregate all the emotions detected in the "extractedFrom" source. If the aggregatesEmotionSet property is used this class could be created to aggregate only certain emotions.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotionSet">onyx:AggregatedEmotionSet</a>
    /// </summary>
    let AggregatedEmotionSet = _prefixId.prefix "AggregatedEmotionSet"
    /// <summary>
    ///   <para>rdfs:label : AppraisalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Parent for Appraisal properties.^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AppraisalProperty">onyx:AppraisalProperty</a>
    /// </summary>
    let AppraisalProperty = _prefixId.prefix "AppraisalProperty"
    /// <summary>
    ///   <para>rdfs:label : DimensionProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Parent for Dimension properties.^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#DimensionProperty">onyx:DimensionProperty</a>
    /// </summary>
    let DimensionProperty = _prefixId.prefix "DimensionProperty"
    /// <summary>
    ///   <para>rdfs:label : Emotion^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Class that represents emotions in a generic way</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#Emotion">onyx:Emotion</a>
    /// </summary>
    let Emotion = _prefixId.prefix "Emotion"
    /// <summary>
    ///   <para>rdfs:label : EmotionAnalysis^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : The action of analysing the sentiment in an entity. It produces an onyx:emotion</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionAnalysis">onyx:EmotionAnalysis</a>
    /// </summary>
    let EmotionAnalysis = _prefixId.prefix "EmotionAnalysis"
    /// <summary>
    ///   <para>rdfs:label : EmotionCategory^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Class that represents an emotion category (anger, happiness, etc.)^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionCategory">onyx:EmotionCategory</a>
    /// </summary>
    let EmotionCategory = _prefixId.prefix "EmotionCategory"
    /// <summary>
    ///   <para>rdfs:label : EmotionModel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an Emotion Representation Model, grouping its categories, dimensions, properties...^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionModel">onyx:EmotionModel</a>
    /// </summary>
    let EmotionModel = _prefixId.prefix "EmotionModel"
    /// <summary>
    ///   <para>rdfs:label : EmotionSet</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the concept of emotion expressed in a certain text.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionSet">onyx:EmotionSet</a>
    /// </summary>
    let EmotionSet = _prefixId.prefix "EmotionSet"
    /// <summary>
    ///   <para>rdfs:label : aggregatesEmotion</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the AggregatedEmotion has been derived from other Emotions.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotion">onyx:aggregatesEmotion</a>
    /// </summary>
    let aggregatesEmotion = _prefixId.prefix "aggregatesEmotion"
    /// <summary>
    ///   <para>rdfs:label : aggregatesEmotionSet</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the emotions associated to this entity are a calculation (eg. average) of the emotions in other EmotionSets.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotionSet">onyx:aggregatesEmotionSet</a>
    /// </summary>
    let aggregatesEmotionSet = _prefixId.prefix "aggregatesEmotionSet"
    /// <summary>
    ///   <para>rdfs:label : algorithm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : The algorithm used in the Sentiment Analysis.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithm">onyx:algorithm</a>
    /// </summary>
    let algorithm = _prefixId.prefix "algorithm"
    /// <summary>
    ///   <para>rdfs:label : algorithmConfidence</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : A numerical value that represents the accuracy of result as estimated by the algorithm itself (how much the emotion matches a gives object/product).</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithmConfidence">onyx:algorithmConfidence</a>
    /// </summary>
    let algorithmConfidence = _prefixId.prefix "algorithmConfidence"
    /// <summary>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#domain">onyx:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:label : emotionText</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : The exact text extract that expresses the emotion. This can be used when entity/text pointed by extractedFrom contains many emotions.
    ///
    /// For example extractedFrom can point to a comment that contains many emotions about a movie, each emotion should have a separate onyx:Emotion and optionally an emotionText  property to indicate the specific text fragment of the comment.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#emotionText">onyx:emotionText</a>
    /// </summary>
    let emotionText = _prefixId.prefix "emotionText"
    /// <summary>
    ///   <para>rdfs:label : extractedFrom</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the text from which the emotion has been extracted.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#extractedFrom">onyx:extractedFrom</a>
    /// </summary>
    let extractedFrom = _prefixId.prefix "extractedFrom"
    /// <summary>
    ///   <para>rdfs:label : hasActionTendency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Action tendency of the Emotion.^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasActionTendency">onyx:hasActionTendency</a>
    /// </summary>
    let hasActionTendency = _prefixId.prefix "hasActionTendency"
    /// <summary>
    ///   <para>rdfs:label : hasAppraisalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment :  Used to list the appraisals that a model defines^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasAppraisalProperty">onyx:hasAppraisalProperty</a>
    /// </summary>
    let hasAppraisalProperty = _prefixId.prefix "hasAppraisalProperty"
    /// <summary>
    ///   <para>rdfs:label : hasDimensionProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment :  Used to define the Dimensions of an Emotion Model^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasDimensionProperty">onyx:hasDimensionProperty</a>
    /// </summary>
    let hasDimensionProperty = _prefixId.prefix "hasDimensionProperty"
    /// <summary>
    ///   <para>rdfs:label : hasEmotion</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a certain text has a subjective emotion expressed in it.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotion">onyx:hasEmotion</a>
    /// </summary>
    let hasEmotion = _prefixId.prefix "hasEmotion"
    /// <summary>
    ///   <para>rdfs:label : hasEmotionCategory^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Value that represents the type of emotion.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionCategory">onyx:hasEmotionCategory</a>
    /// </summary>
    let hasEmotionCategory = _prefixId.prefix "hasEmotionCategory"
    /// <summary>
    ///   <para>rdfs:label : hasEmotionIntensity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Value that quantifies the intensity of the emotion.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionIntensity">onyx:hasEmotionIntensity</a>
    /// </summary>
    let hasEmotionIntensity = _prefixId.prefix "hasEmotionIntensity"
    /// <summary>
    ///   <para>rdfs:label : modelName^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Human readable name of the model^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#modelName">onyx:modelName</a>
    /// </summary>
    let modelName = _prefixId.prefix "modelName"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Source from which the emotion was extracted (URL, Site, Entity...)^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#source">onyx:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : sourceText^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Optional value that contains the text from which the emotionText was taken.^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#sourceText">onyx:sourceText</a>
    /// </summary>
    let sourceText = _prefixId.prefix "sourceText"
    /// <summary>
    ///   <para>rdfs:label : usesEmotionModel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/onyx/ns^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the Emotion Model used. Mainly used to describe Emotion Analysis activities.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#usesEmotionModel">onyx:usesEmotionModel</a>
    /// </summary>
    let usesEmotionModel = _prefixId.prefix "usesEmotionModel"
