namespace http.www.gsi.dit.upm.es.ontologies.onyx.ns.hash

open DoxAletheia

module onyx =
    let _namespace_name = "http://www.gsi.dit.upm.es/ontologies/onyx/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Action Tendency of the emotion: a desire to behave in select communicative or important actions that are connected to a particular feeling.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#ActionTendency"></see></summary>
    let ActionTendency = _prefix "ActionTendency"
    /// <summary>
    /// The same as Emotion, used to aggregate several emotions
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotion"></see></summary>
    let AggregatedEmotion = _prefix "AggregatedEmotion"
    /// <summary>
    /// The same as the EmotionSet class but indicates that the properties of this class aggregate all the emotions detected in the "extractedFrom" source. If the aggregatesEmotionSet property is used this class could be created to aggregate only certain emotions.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AggregatedEmotionSet"></see></summary>
    let AggregatedEmotionSet = _prefix "AggregatedEmotionSet"
    /// <summary>
    /// Describes the concept of emotion expressed in a certain text.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionSet"></see></summary>
    let EmotionSet = _prefix "EmotionSet"
    /// <summary>
    /// Parent for Appraisal properties.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#AppraisalProperty"></see></summary>
    let AppraisalProperty = _prefix "AppraisalProperty"
    /// <summary>
    /// Parent for Dimension properties.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#DimensionProperty"></see></summary>
    let DimensionProperty = _prefix "DimensionProperty"
    /// <summary>
    /// Class that represents emotions in a generic way
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#Emotion"></see></summary>
    let Emotion = _prefix "Emotion"
    /// <summary>
    /// The action of analysing the sentiment in an entity. It produces an onyx:emotion
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionAnalysis"></see></summary>
    let EmotionAnalysis = _prefix "EmotionAnalysis"
    /// <summary>
    /// Class that represents an emotion category (anger, happiness, etc.)
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionCategory"></see></summary>
    let EmotionCategory = _prefix "EmotionCategory"
    /// <summary>
    /// Represents an Emotion Representation Model, grouping its categories, dimensions, properties...
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#EmotionModel"></see></summary>
    let EmotionModel = _prefix "EmotionModel"
    /// <summary>
    /// Indicates that the AggregatedEmotion has been derived from other Emotions.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotion"></see></summary>
    let aggregatesEmotion = _prefix "aggregatesEmotion"
    /// <summary>
    /// Indicates that the emotions associated to this entity are a calculation (eg. average) of the emotions in other EmotionSets.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#aggregatesEmotionSet"></see></summary>
    let aggregatesEmotionSet = _prefix "aggregatesEmotionSet"
    /// <summary>
    /// The algorithm used in the Sentiment Analysis.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithm"></see></summary>
    let algorithm = _prefix "algorithm"
    /// <summary>
    /// A numerical value that represents the accuracy of result as estimated by the algorithm itself (how much the emotion matches a gives object/product).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#algorithmConfidence"></see></summary>
    let algorithmConfidence = _prefix "algorithmConfidence"
    /// <summary>
    ///   <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#domain"></see>
    /// </summary>
    let domain = _prefix "domain"
    /// <summary>
    /// The exact text extract that expresses the emotion. This can be used when entity/text pointed by extractedFrom contains many emotions.
    ///
    /// For example extractedFrom can point to a comment that contains many emotions about a movie, each emotion should have a separate onyx:Emotion and optionally an emotionText  property to indicate the specific text fragment of the comment.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#emotionText"></see></summary>
    let emotionText = _prefix "emotionText"
    /// <summary>
    /// Indicates the text from which the emotion has been extracted.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#extractedFrom"></see></summary>
    let extractedFrom = _prefix "extractedFrom"
    /// <summary>
    /// Indicates that a certain text has a subjective emotion expressed in it.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotion"></see></summary>
    let hasEmotion = _prefix "hasEmotion"
    /// <summary>
    /// Action tendency of the Emotion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasActionTendency"></see></summary>
    let hasActionTendency = _prefix "hasActionTendency"
    /// <summary>
    ///  Used to list the appraisals that a model defines
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasAppraisalProperty"></see></summary>
    let hasAppraisalProperty = _prefix "hasAppraisalProperty"
    /// <summary>
    ///  Used to define the Dimensions of an Emotion Model
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasDimensionProperty"></see></summary>
    let hasDimensionProperty = _prefix "hasDimensionProperty"
    /// <summary>
    /// Value that represents the type of emotion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionCategory"></see></summary>
    let hasEmotionCategory = _prefix "hasEmotionCategory"
    /// <summary>
    /// Value that quantifies the intensity of the emotion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#hasEmotionIntensity"></see></summary>
    let hasEmotionIntensity = _prefix "hasEmotionIntensity"
    /// <summary>
    /// Human readable name of the model
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#modelName"></see></summary>
    let modelName = _prefix "modelName"
    /// <summary>
    /// Source from which the emotion was extracted (URL, Site, Entity...)
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// Optional value that contains the text from which the emotionText was taken.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#sourceText"></see></summary>
    let sourceText = _prefix "sourceText"
    /// <summary>
    /// Specifies the Emotion Model used. Mainly used to describe Emotion Analysis activities.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/onyx/ns#usesEmotionModel"></see></summary>
    let usesEmotionModel = _prefix "usesEmotionModel"
