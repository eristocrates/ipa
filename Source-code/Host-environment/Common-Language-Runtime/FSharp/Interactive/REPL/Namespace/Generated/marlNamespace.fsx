#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module marl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.gsi.dit.upm.es/ontologies/marl/ns#" "marl"

    /// <summary>
    ///   <para>rdfs:comment : The same as Opinion class but indicates that the properties of this class aggregate all the opinions specified in the "extractedFrom" source. Optionally, if the aggregatesOpinion property is used this class could be created to aggregate only certain opinions (e.g. in a text about political scene it there could be many AggregatedOpinion classes each with opinions per different politician).</para>
    ///   <para>rdfs:label : AggregatedOpinion</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#AggregatedOpinion">marl:AggregatedOpinion</a>
    /// </summary>
    let AggregatedOpinion = _prefixId.prefix "AggregatedOpinion"
    let Negative = _prefixId.prefix "Negative"
    let Neutral = _prefixId.prefix "Neutral"
    /// <summary>
    ///   <para>rdfs:label : Opinion</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the concept of opinion expressed in a certain text.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Opinion">marl:Opinion</a>
    /// </summary>
    let Opinion = _prefixId.prefix "Opinion"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Class that represents the opinion polarity. Use instances to express if the polarity is positive, neutral or negative.</para>
    ///   <para>rdfs:label : Polarity</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#Polarity">marl:Polarity</a>
    /// </summary>
    let Polarity = _prefixId.prefix "Polarity"
    let Positive = _prefixId.prefix "Positive"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : SentimentAnalysis^^xsd:string</para>
    ///   <para>rdfs:comment : &lt;p style="margin-top: 0"&gt;
    ///       The action of analysing the sentiment in an entity. It produces a
    ///       marl:opinion
    ///     &lt;/p&gt;</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#SentimentAnalysis">marl:SentimentAnalysis</a>
    /// </summary>
    let SentimentAnalysis = _prefixId.prefix "SentimentAnalysis"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the polarity described with the class is a calculation (eg. sum) of other opinions polarity (eg. aggregated opinion about the movie derived from many sentiments expressed in one text).</para>
    ///   <para>rdfs:label : aggregatesOpinion</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#aggregatesOpinion">marl:aggregatesOpinion</a>
    /// </summary>
    let aggregatesOpinion = _prefixId.prefix "aggregatesOpinion"
    /// <summary>
    ///   <para>rdfs:comment : The algorithm used in the Sentiment Analysis.</para>
    ///   <para>rdfs:label : algorithm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithm">marl:algorithm</a>
    /// </summary>
    let algorithm = _prefixId.prefix "algorithm"
    /// <summary>
    ///   <para>rdfs:label : algorithmConfidence</para>
    ///   <para>rdfs:comment : A numerical value that describe how much the algorithm was confident of the assessment of the opinion (eg. how much the opinion matches a gives object/product).</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#algorithmConfidence">marl:algorithmConfidence</a>
    /// </summary>
    let algorithmConfidence = _prefixId.prefix "algorithmConfidence"
    /// <summary>
    ///   <para>rdfs:label : describesFeature</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a feature of an object or object part that the opinion refers to (eg. laptop battery life or laptop battery size etc.).</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesFeature">marl:describesFeature</a>
    /// </summary>
    let describesFeature = _prefixId.prefix "describesFeature"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : describesObject</para>
    ///   <para>rdfs:comment : Indicates the object that the opinion refers to.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObject">marl:describesObject</a>
    /// </summary>
    let describesObject = _prefixId.prefix "describesObject"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a particular element or part of the object that the opinion refers to (eg. laptop screen or camera battery).</para>
    ///   <para>rdfs:label : describesObjectPart</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#describesObjectPart">marl:describesObjectPart</a>
    /// </summary>
    let describesObjectPart = _prefixId.prefix "describesObjectPart"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : domain^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#domain">marl:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the text from which the opinion has been extracted.</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : extractedFrom</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#extractedFrom">marl:extractedFrom</a>
    /// </summary>
    let extractedFrom = _prefixId.prefix "extractedFrom"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a certain text has a subjective opinion expressed in it.</para>
    ///   <para>rdfs:label : hasOpinion</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasOpinion">marl:hasOpinion</a>
    /// </summary>
    let hasOpinion = _prefixId.prefix "hasOpinion"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates if the opinion is positive/negative or neutral. Use instances of class marl:Polarity.</para>
    ///   <para>rdfs:label : hasPolarity</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#hasPolarity">marl:hasPolarity</a>
    /// </summary>
    let hasPolarity = _prefixId.prefix "hasPolarity"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : algorithmConfidence</para>
    ///   <para>rdfs:comment : Maximal possible numerical value for the opinion.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#maxPolarityValue">marl:maxPolarityValue</a>
    /// </summary>
    let maxPolarityValue = _prefixId.prefix "maxPolarityValue"
    /// <summary>
    ///   <para>rdfs:comment : Lowest possible numerical value of the opinion.</para>
    ///   <para>rdfs:label : minPolarityValue</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#minPolarityValue">marl:minPolarityValue</a>
    /// </summary>
    let minPolarityValue = _prefixId.prefix "minPolarityValue"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : negativeOpinionCount</para>
    ///   <para>rdfs:comment : Amount of negative opinions aggregated.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#negativeOpinionCount">marl:negativeOpinionCount</a>
    /// </summary>
    let negativeOpinionCount = _prefixId.prefix "negativeOpinionCount"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : neutralOpinionCount</para>
    ///   <para>rdfs:comment : Amount of neutral opinions aggregated.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#neutralOpinionCount">marl:neutralOpinionCount</a>
    /// </summary>
    let neutralOpinionCount = _prefixId.prefix "neutralOpinionCount"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of all aggregated opinions.</para>
    ///   <para>rdfs:label : opinionCount</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionCount">marl:opinionCount</a>
    /// </summary>
    let opinionCount = _prefixId.prefix "opinionCount"
    /// <summary>
    ///   <para>rdfs:comment : The exact text extract that expresses the opinion. This can be used when entity/text pointed by extractedFrom contains many opinions.
    ///
    /// For example extractedFrom can point to a comment that contains many opinions about a movie, each opinion should have a separate marl:Opinion and optionally an opinionText  property to indicate the specific text fragment of the comment.</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : opinionText</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#opinionText">marl:opinionText</a>
    /// </summary>
    let opinionText = _prefixId.prefix "opinionText"
    /// <summary>
    ///   <para>rdfs:comment : A numerical representation of the polarity value. The recommended use is by specifying % by using a real number from 0..1. In case this is not feasible in a given solution use minOpinionValue and maxOpinionValue to provide additional information.</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : polarityValue</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#polarityValue">marl:polarityValue</a>
    /// </summary>
    let polarityValue = _prefixId.prefix "polarityValue"
    /// <summary>
    ///   <para>rdfs:label : positiveOpinionCount</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of positive opinions aggregated.</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#positiveOpinionsCount">marl:positiveOpinionsCount</a>
    /// </summary>
    let positiveOpinionsCount = _prefixId.prefix "positiveOpinionsCount"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <para>rdfs:comment : Source from which the opinion was extracted (URL, Site, Entity...)^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#source">marl:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:comment : Text analysed^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://www.gsi.dit.upm.es/ontologies/marl/ns#^^xsd:string</para>
    ///   <para>rdfs:label : sourceText^^xsd:string</para>
    ///   <a href="http://www.gsi.dit.upm.es/ontologies/marl/ns#sourceText">marl:sourceText</a>
    /// </summary>
    let sourceText = _prefixId.prefix "sourceText"
