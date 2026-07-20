namespace http.www.gsi.dit.upm.es.ontologies.marl.ns.hash

open DoxAletheia

module marl =
    let _namespace_name = "http://www.gsi.dit.upm.es/ontologies/marl/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Neutral polarity
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Neutral"></see></summary>
    let Neutral = _prefix "Neutral"
    /// <summary>
    /// Positive polarity
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Positive"></see></summary>
    let Positive = _prefix "Positive"
    /// <summary>
    /// Negative polarity.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Negative"></see></summary>
    let Negative = _prefix "Negative"
    /// <summary>
    /// The same as Opinion class but indicates that the properties of this class aggregate all the opinions specified in the "extractedFrom" source. Optionally, if the aggregatesOpinion property is used this class could be created to aggregate only certain opinions (e.g. in a text about political scene it there could be many AggregatedOpinion classes each with opinions per different politician).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#AggregatedOpinion"></see></summary>
    let AggregatedOpinion = _prefix "AggregatedOpinion"
    /// <summary>
    /// Describes the concept of opinion expressed in a certain text.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Opinion"></see></summary>
    let Opinion = _prefix "Opinion"
    /// <summary>
    /// Class that represents the opinion polarity. Use instances to express if the polarity is positive, neutral or negative.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Polarity"></see></summary>
    let Polarity = _prefix "Polarity"
    /// <summary>
    /// &lt;p style="margin-top: 0"&gt;
    ///       The action of analysing the sentiment in an entity. It produces a
    ///       marl:opinion
    ///     &lt;/p&gt;
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#SentimentAnalysis"></see></summary>
    let SentimentAnalysis = _prefix "SentimentAnalysis"
    /// <summary>
    /// Indicates that the polarity described with the class is a calculation (eg. sum) of other opinions polarity (eg. aggregated opinion about the movie derived from many sentiments expressed in one text).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#aggregatesOpinion"></see></summary>
    let aggregatesOpinion = _prefix "aggregatesOpinion"
    /// <summary>
    /// The algorithm used in the Sentiment Analysis.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithm"></see></summary>
    let algorithm = _prefix "algorithm"
    /// <summary>
    /// A numerical value that describe how much the algorithm was confident of the assessment of the opinion (eg. how much the opinion matches a gives object/product).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithmConfidence"></see></summary>
    let algorithmConfidence = _prefix "algorithmConfidence"
    /// <summary>
    /// Indicates a feature of an object or object part that the opinion refers to (eg. laptop battery life or laptop battery size etc.).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesFeature"></see></summary>
    let describesFeature = _prefix "describesFeature"
    /// <summary>
    /// Indicates the object that the opinion refers to.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObject"></see></summary>
    let describesObject = _prefix "describesObject"
    /// <summary>
    /// Indicates a particular element or part of the object that the opinion refers to (eg. laptop screen or camera battery).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObjectPart"></see></summary>
    let describesObjectPart = _prefix "describesObjectPart"
    /// <summary>
    ///   <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#domain"></see>
    /// </summary>
    let domain = _prefix "domain"
    /// <summary>
    /// Indicates the text from which the opinion has been extracted.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#extractedFrom"></see></summary>
    let extractedFrom = _prefix "extractedFrom"
    /// <summary>
    /// Indicates that a certain text has a subjective opinion expressed in it.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasOpinion"></see></summary>
    let hasOpinion = _prefix "hasOpinion"
    /// <summary>
    /// Indicates if the opinion is positive/negative or neutral. Use instances of class marl:Polarity.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasPolarity"></see></summary>
    let hasPolarity = _prefix "hasPolarity"
    /// <summary>
    /// Maximal possible numerical value for the opinion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#maxPolarityValue"></see></summary>
    let maxPolarityValue = _prefix "maxPolarityValue"
    /// <summary>
    /// Lowest possible numerical value of the opinion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#minPolarityValue"></see></summary>
    let minPolarityValue = _prefix "minPolarityValue"
    /// <summary>
    /// Amount of negative opinions aggregated.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#negativeOpinionCount"></see></summary>
    let negativeOpinionCount = _prefix "negativeOpinionCount"
    /// <summary>
    /// Amount of neutral opinions aggregated.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#neutralOpinionCount"></see></summary>
    let neutralOpinionCount = _prefix "neutralOpinionCount"
    /// <summary>
    /// Amount of all aggregated opinions.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionCount"></see></summary>
    let opinionCount = _prefix "opinionCount"
    /// <summary>
    /// The exact text extract that expresses the opinion. This can be used when entity/text pointed by extractedFrom contains many opinions.
    ///
    /// For example extractedFrom can point to a comment that contains many opinions about a movie, each opinion should have a separate marl:Opinion and optionally an opinionText  property to indicate the specific text fragment of the comment.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionText"></see></summary>
    let opinionText = _prefix "opinionText"
    /// <summary>
    /// A numerical representation of the polarity value. The recommended use is by specifying % by using a real number from 0..1. In case this is not feasible in a given solution use minOpinionValue and maxOpinionValue to provide additional information.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#polarityValue"></see></summary>
    let polarityValue = _prefix "polarityValue"
    /// <summary>
    /// Amount of positive opinions aggregated.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#positiveOpinionsCount"></see></summary>
    let positiveOpinionsCount = _prefix "positiveOpinionsCount"
    /// <summary>
    /// Source from which the opinion was extracted (URL, Site, Entity...)
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// Text analysed
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#sourceText"></see></summary>
    let sourceText = _prefix "sourceText"
