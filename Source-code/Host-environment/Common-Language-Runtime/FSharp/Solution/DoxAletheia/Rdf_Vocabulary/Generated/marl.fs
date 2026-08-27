namespace http.www.gsi.dit.upm.es.ontologies.marl.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module marl =
    let _namespace_iri = Namespace_Iri marl |> NamespaceIRI
    /// <summary>
    ///   <para>marl:AggregatedOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The same as Opinion class but indicates that the properties of this class aggregate all the opinions specified in the "extractedFrom" source. Optionally, if the aggregatesOpinion property is used this class could be created to aggregate only certain opinions (e.g. in a text about political scene it there could be many AggregatedOpinion classes each with opinions per different politician)."</para>
    /// labels<para>"AggregatedOpinion"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#AggregatedOpinion">http://www.gsi.dit.upm.es/ontologies/marl/ns#AggregatedOpinion</seealso>
    let AggregatedOpinion = Prefixed_Name(marl, "AggregatedOpinion") |> PrefixedName
    /// <summary>
    ///   <para>marl:Negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>marl:Polarity</para>
    ///   <para>"Negative polarity."</para>
    /// labels<para>"Negative"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Negative">http://www.gsi.dit.upm.es/ontologies/marl/ns#Negative</seealso>
    let Negative = Prefixed_Name(marl, "Negative") |> PrefixedName
    /// <summary>
    ///   <para>marl:Neutral</para>
    /// </summary>
    /// <remarks>
    ///   <para>marl:Polarity</para>
    ///   <para>"Neutral polarity"</para>
    /// labels<para>"Neutral"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Neutral">http://www.gsi.dit.upm.es/ontologies/marl/ns#Neutral</seealso>
    let Neutral = Prefixed_Name(marl, "Neutral") |> PrefixedName
    /// <summary>
    ///   <para>marl:Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the concept of opinion expressed in a certain text."</para>
    /// labels<para>"Opinion"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Opinion">http://www.gsi.dit.upm.es/ontologies/marl/ns#Opinion</seealso>
    let Opinion = Prefixed_Name(marl, "Opinion") |> PrefixedName
    /// <summary>
    ///   <para>marl:Polarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents the opinion polarity. Use instances to express if the polarity is positive, neutral or negative."</para>
    /// labels<para>"Polarity"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Polarity">http://www.gsi.dit.upm.es/ontologies/marl/ns#Polarity</seealso>
    let Polarity = Prefixed_Name(marl, "Polarity") |> PrefixedName
    /// <summary>
    ///   <para>marl:Positive</para>
    /// </summary>
    /// <remarks>
    ///   <para>marl:Polarity</para>
    ///   <para>"Positive polarity"</para>
    /// labels<para>"Positive"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Positive">http://www.gsi.dit.upm.es/ontologies/marl/ns#Positive</seealso>
    let Positive = Prefixed_Name(marl, "Positive") |> PrefixedName
    /// <summary>
    ///   <para>marl:SentimentAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"&lt;p style="margin-top: 0"&gt;
    ///       The action of analysing the sentiment in an entity. It produces a
    ///       marl:opinion
    ///     &lt;/p&gt;"</para>
    /// labels<para>"SentimentAnalysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#SentimentAnalysis">http://www.gsi.dit.upm.es/ontologies/marl/ns#SentimentAnalysis</seealso>
    let SentimentAnalysis = Prefixed_Name(marl, "SentimentAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>marl:aggregatesOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the polarity described with the class is a calculation (eg. sum) of other opinions polarity (eg. aggregated opinion about the movie derived from many sentiments expressed in one text)."</para>
    /// labels<para>"aggregatesOpinion"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#aggregatesOpinion">http://www.gsi.dit.upm.es/ontologies/marl/ns#aggregatesOpinion</seealso>
    let aggregatesOpinion = Prefixed_Name(marl, "aggregatesOpinion") |> PrefixedName
    /// <summary>
    ///   <para>marl:algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The algorithm used in the Sentiment Analysis."</para>
    /// labels<para>"algorithm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithm">http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithm</seealso>
    let algorithm = Prefixed_Name(marl, "algorithm") |> PrefixedName
    /// <summary>
    ///   <para>marl:algorithmConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A numerical value that describe how much the algorithm was confident of the assessment of the opinion (eg. how much the opinion matches a gives object/product)."</para>
    /// labels<para>"algorithmConfidence"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithmConfidence">http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithmConfidence</seealso>
    let algorithmConfidence = Prefixed_Name(marl, "algorithmConfidence") |> PrefixedName
    /// <summary>
    ///   <para>marl:describesFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a feature of an object or object part that the opinion refers to (eg. laptop battery life or laptop battery size etc.)."</para>
    /// labels<para>"describesFeature"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesFeature">http://www.gsi.dit.upm.es/ontologies/marl/ns#describesFeature</seealso>
    let describesFeature = Prefixed_Name(marl, "describesFeature") |> PrefixedName
    /// <summary>
    ///   <para>marl:describesObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the object that the opinion refers to."</para>
    /// labels<para>"describesObject"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObject">http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObject</seealso>
    let describesObject = Prefixed_Name(marl, "describesObject") |> PrefixedName
    /// <summary>
    ///   <para>marl:describesObjectPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a particular element or part of the object that the opinion refers to (eg. laptop screen or camera battery)."</para>
    /// labels<para>"describesObjectPart"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObjectPart">http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObjectPart</seealso>
    let describesObjectPart = Prefixed_Name(marl, "describesObjectPart") |> PrefixedName
    /// <summary>
    ///   <para>marl:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#domain">http://www.gsi.dit.upm.es/ontologies/marl/ns#domain</seealso>
    let domain = Prefixed_Name(marl, "domain") |> PrefixedName
    /// <summary>
    ///   <para>marl:extractedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the text from which the opinion has been extracted."</para>
    /// labels<para>"extractedFrom"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#extractedFrom">http://www.gsi.dit.upm.es/ontologies/marl/ns#extractedFrom</seealso>
    let extractedFrom = Prefixed_Name(marl, "extractedFrom") |> PrefixedName
    /// <summary>
    ///   <para>marl:hasOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a certain text has a subjective opinion expressed in it."</para>
    /// labels<para>"hasOpinion"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasOpinion">http://www.gsi.dit.upm.es/ontologies/marl/ns#hasOpinion</seealso>
    let hasOpinion = Prefixed_Name(marl, "hasOpinion") |> PrefixedName
    /// <summary>
    ///   <para>marl:hasPolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates if the opinion is positive/negative or neutral. Use instances of class marl:Polarity."</para>
    /// labels<para>"hasPolarity"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasPolarity">http://www.gsi.dit.upm.es/ontologies/marl/ns#hasPolarity</seealso>
    let hasPolarity = Prefixed_Name(marl, "hasPolarity") |> PrefixedName
    /// <summary>
    ///   <para>marl:maxPolarityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximal possible numerical value for the opinion."</para>
    /// labels<para>"algorithmConfidence"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#maxPolarityValue">http://www.gsi.dit.upm.es/ontologies/marl/ns#maxPolarityValue</seealso>
    let maxPolarityValue = Prefixed_Name(marl, "maxPolarityValue") |> PrefixedName
    /// <summary>
    ///   <para>marl:minPolarityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Lowest possible numerical value of the opinion."</para>
    /// labels<para>"minPolarityValue"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#minPolarityValue">http://www.gsi.dit.upm.es/ontologies/marl/ns#minPolarityValue</seealso>
    let minPolarityValue = Prefixed_Name(marl, "minPolarityValue") |> PrefixedName

    /// <summary>
    ///   <para>marl:negativeOpinionCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount of negative opinions aggregated."</para>
    /// labels<para>"negativeOpinionCount"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#negativeOpinionCount">http://www.gsi.dit.upm.es/ontologies/marl/ns#negativeOpinionCount</seealso>
    let negativeOpinionCount =
        Prefixed_Name(marl, "negativeOpinionCount") |> PrefixedName

    /// <summary>
    ///   <para>marl:neutralOpinionCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount of neutral opinions aggregated."</para>
    /// labels<para>"neutralOpinionCount"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#neutralOpinionCount">http://www.gsi.dit.upm.es/ontologies/marl/ns#neutralOpinionCount</seealso>
    let neutralOpinionCount = Prefixed_Name(marl, "neutralOpinionCount") |> PrefixedName
    /// <summary>
    ///   <para>marl:opinionCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount of all aggregated opinions."</para>
    /// labels<para>"opinionCount"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionCount">http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionCount</seealso>
    let opinionCount = Prefixed_Name(marl, "opinionCount") |> PrefixedName
    /// <summary>
    ///   <para>marl:opinionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The exact text extract that expresses the opinion. This can be used when entity/text pointed by extractedFrom contains many opinions.
    ///
    /// For example extractedFrom can point to a comment that contains many opinions about a movie, each opinion should have a separate marl:Opinion and optionally an opinionText  property to indicate the specific text fragment of the comment."</para>
    /// labels<para>"opinionText"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionText">http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionText</seealso>
    let opinionText = Prefixed_Name(marl, "opinionText") |> PrefixedName
    /// <summary>
    ///   <para>marl:polarityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A numerical representation of the polarity value. The recommended use is by specifying % by using a real number from 0..1. In case this is not feasible in a given solution use minOpinionValue and maxOpinionValue to provide additional information."</para>
    /// labels<para>"polarityValue"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#polarityValue">http://www.gsi.dit.upm.es/ontologies/marl/ns#polarityValue</seealso>
    let polarityValue = Prefixed_Name(marl, "polarityValue") |> PrefixedName

    /// <summary>
    ///   <para>marl:positiveOpinionsCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount of positive opinions aggregated."</para>
    /// labels<para>"positiveOpinionCount"</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#positiveOpinionsCount">http://www.gsi.dit.upm.es/ontologies/marl/ns#positiveOpinionsCount</seealso>
    let positiveOpinionsCount =
        Prefixed_Name(marl, "positiveOpinionsCount") |> PrefixedName

    /// <summary>
    ///   <para>marl:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Source from which the opinion was extracted (URL, Site, Entity...)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#source">http://www.gsi.dit.upm.es/ontologies/marl/ns#source</seealso>
    let source = Prefixed_Name(marl, "source") |> PrefixedName
    /// <summary>
    ///   <para>marl:sourceText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Text analysed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sourceText"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.gsi.dit.upm.es/ontologies/marl/ns#sourceText">http://www.gsi.dit.upm.es/ontologies/marl/ns#sourceText</seealso>
    let sourceText = Prefixed_Name(marl, "sourceText") |> PrefixedName
