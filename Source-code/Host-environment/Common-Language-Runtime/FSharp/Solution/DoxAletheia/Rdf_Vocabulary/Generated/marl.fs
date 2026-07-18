namespace http.www.gsi.dit.upm.es.ontologies.marl.ns.hash

open DoxAletheia.Rdf_Vocabulary

module marl =
    let _namespace_name = "http://www.gsi.dit.upm.es/ontologies/marl/ns#"
    /// <summary>
    /// Neutral polarity
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Neutral"></see></summary>
    let Neutral = Namespaced_IRI.parse _namespace_name "Neutral" |> NamespacedName
    /// <summary>
    /// Positive polarity
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Positive"></see></summary>
    let Positive = Namespaced_IRI.parse _namespace_name "Positive" |> NamespacedName
    /// <summary>
    /// Negative polarity.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Negative"></see></summary>
    let Negative = Namespaced_IRI.parse _namespace_name "Negative" |> NamespacedName

    /// <summary>
    /// The same as Opinion class but indicates that the properties of this class aggregate all the opinions specified in the "extractedFrom" source. Optionally, if the aggregatesOpinion property is used this class could be created to aggregate only certain opinions (e.g. in a text about political scene it there could be many AggregatedOpinion classes each with opinions per different politician).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#AggregatedOpinion"></see></summary>
    let AggregatedOpinion =
        Namespaced_IRI.parse _namespace_name "AggregatedOpinion" |> NamespacedName

    /// <summary>
    /// Describes the concept of opinion expressed in a certain text.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Opinion"></see></summary>
    let Opinion = Namespaced_IRI.parse _namespace_name "Opinion" |> NamespacedName
    /// <summary>
    /// Class that represents the opinion polarity. Use instances to express if the polarity is positive, neutral or negative.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Polarity"></see></summary>
    let Polarity = Namespaced_IRI.parse _namespace_name "Polarity" |> NamespacedName

    /// <summary>
    /// &lt;p style="margin-top: 0"&gt;
    ///       The action of analysing the sentiment in an entity. It produces a
    ///       marl:opinion
    ///     &lt;/p&gt;
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#SentimentAnalysis"></see></summary>
    let SentimentAnalysis =
        Namespaced_IRI.parse _namespace_name "SentimentAnalysis" |> NamespacedName

    /// <summary>
    /// Indicates that the polarity described with the class is a calculation (eg. sum) of other opinions polarity (eg. aggregated opinion about the movie derived from many sentiments expressed in one text).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#aggregatesOpinion"></see></summary>
    let aggregatesOpinion =
        Namespaced_IRI.parse _namespace_name "aggregatesOpinion" |> NamespacedName

    /// <summary>
    /// The algorithm used in the Sentiment Analysis.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithm"></see></summary>
    let algorithm = Namespaced_IRI.parse _namespace_name "algorithm" |> NamespacedName

    /// <summary>
    /// A numerical value that describe how much the algorithm was confident of the assessment of the opinion (eg. how much the opinion matches a gives object/product).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithmConfidence"></see></summary>
    let algorithmConfidence =
        Namespaced_IRI.parse _namespace_name "algorithmConfidence" |> NamespacedName

    /// <summary>
    /// Indicates a feature of an object or object part that the opinion refers to (eg. laptop battery life or laptop battery size etc.).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesFeature"></see></summary>
    let describesFeature =
        Namespaced_IRI.parse _namespace_name "describesFeature" |> NamespacedName

    /// <summary>
    /// Indicates the object that the opinion refers to.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObject"></see></summary>
    let describesObject =
        Namespaced_IRI.parse _namespace_name "describesObject" |> NamespacedName

    /// <summary>
    /// Indicates a particular element or part of the object that the opinion refers to (eg. laptop screen or camera battery).
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObjectPart"></see></summary>
    let describesObjectPart =
        Namespaced_IRI.parse _namespace_name "describesObjectPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#domain"></see>
    /// </summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName

    /// <summary>
    /// Indicates the text from which the opinion has been extracted.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#extractedFrom"></see></summary>
    let extractedFrom =
        Namespaced_IRI.parse _namespace_name "extractedFrom" |> NamespacedName

    /// <summary>
    /// Indicates that a certain text has a subjective opinion expressed in it.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasOpinion"></see></summary>
    let hasOpinion = Namespaced_IRI.parse _namespace_name "hasOpinion" |> NamespacedName

    /// <summary>
    /// Indicates if the opinion is positive/negative or neutral. Use instances of class marl:Polarity.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasPolarity"></see></summary>
    let hasPolarity =
        Namespaced_IRI.parse _namespace_name "hasPolarity" |> NamespacedName

    /// <summary>
    /// Maximal possible numerical value for the opinion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#maxPolarityValue"></see></summary>
    let maxPolarityValue =
        Namespaced_IRI.parse _namespace_name "maxPolarityValue" |> NamespacedName

    /// <summary>
    /// Lowest possible numerical value of the opinion.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#minPolarityValue"></see></summary>
    let minPolarityValue =
        Namespaced_IRI.parse _namespace_name "minPolarityValue" |> NamespacedName

    /// <summary>
    /// Amount of negative opinions aggregated.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#negativeOpinionCount"></see></summary>
    let negativeOpinionCount =
        Namespaced_IRI.parse _namespace_name "negativeOpinionCount" |> NamespacedName

    /// <summary>
    /// Amount of neutral opinions aggregated.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#neutralOpinionCount"></see></summary>
    let neutralOpinionCount =
        Namespaced_IRI.parse _namespace_name "neutralOpinionCount" |> NamespacedName

    /// <summary>
    /// Amount of all aggregated opinions.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionCount"></see></summary>
    let opinionCount =
        Namespaced_IRI.parse _namespace_name "opinionCount" |> NamespacedName

    /// <summary>
    /// The exact text extract that expresses the opinion. This can be used when entity/text pointed by extractedFrom contains many opinions.
    ///
    /// For example extractedFrom can point to a comment that contains many opinions about a movie, each opinion should have a separate marl:Opinion and optionally an opinionText  property to indicate the specific text fragment of the comment.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionText"></see></summary>
    let opinionText =
        Namespaced_IRI.parse _namespace_name "opinionText" |> NamespacedName

    /// <summary>
    /// A numerical representation of the polarity value. The recommended use is by specifying % by using a real number from 0..1. In case this is not feasible in a given solution use minOpinionValue and maxOpinionValue to provide additional information.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#polarityValue"></see></summary>
    let polarityValue =
        Namespaced_IRI.parse _namespace_name "polarityValue" |> NamespacedName

    /// <summary>
    /// Amount of positive opinions aggregated.
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#positiveOpinionsCount"></see></summary>
    let positiveOpinionsCount =
        Namespaced_IRI.parse _namespace_name "positiveOpinionsCount" |> NamespacedName

    /// <summary>
    /// Source from which the opinion was extracted (URL, Site, Entity...)
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// Text analysed
    /// <see href="http://www.gsi.dit.upm.es/ontologies/marl/ns#sourceText"></see></summary>
    let sourceText = Namespaced_IRI.parse _namespace_name "sourceText" |> NamespacedName
