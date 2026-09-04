#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module kdo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://kdo.render-project.eu/kdo#" "kdo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Bias</para>
    ///   <para>rdfs:comment : A bias can be attached to a kdo:Statement and can therefore also relate to agents, posts, and opinions. More specifically, a bias can also relate to another bias.
    ///
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#Bias">kdo:Bias</a>
    /// </summary>
    let Bias = _prefixId.prefix "Bias"
    /// <summary>
    ///   <para>rdfs:label : News article</para>
    ///   <para>rdfs:comment : The kdo:NewsArticle class represents news articles. The news article class is defined because there is no class to represent news articles in the SIOC ontology. The NewsArticle is a subclass of the sioc:Post class which is itself a subclass of the foaf:Document.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#NewsArticle">kdo:NewsArticle</a>
    /// </summary>
    let NewsArticle = _prefixId.prefix "NewsArticle"
    /// <summary>
    ///   <para>rdfs:label : News web site</para>
    ///   <para>rdfs:comment : The kdo:NewsWebsite class represents news publisher containers that are commonly related to a single web site. The NewsWebsite class is defined because there is no container class to represent the news publisher web sites in the SIOC ontology. The NewsWebsite class is defined as a subclass of the sioc:Container.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#NewsWebsite">kdo:NewsWebsite</a>
    /// </summary>
    let NewsWebsite = _prefixId.prefix "NewsWebsite"
    /// <summary>
    ///   <para>rdfs:label : Opinion</para>
    ///   <para>rdfs:comment : The opinion class represents is used to contextualize2 provenance, crawling other meta-information. A blank node may be used to represent opinions. Opinions are connected to statement through kdo:hasOpinion.
    ///
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#Opinion">kdo:Opinion</a>
    /// </summary>
    let Opinion = _prefixId.prefix "Opinion"
    /// <summary>
    ///   <para>rdfs:comment : The kdo:Polarity class is used to express the polarity of sentiments. The predefined instances of this class are: kdo:neutralPolarity, kdo:positivePolarity, kdo:negativePolarity.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#Polarity">kdo:Polarity</a>
    /// </summary>
    let Polarity = _prefixId.prefix "Polarity"
    /// <summary>
    ///   <para>rdfs:label : Sentiment</para>
    ///   <para>rdfs:comment : The sentiment class represents the sentiments expressed by the opinions and posts. A sentiment can have (kdo:hasPolarity) different types of polarity (positive, negative, and neutral) and a decimal score (kdo:hasScore). It is in the range of kdo:hasSentiment.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#Sentiment">kdo:Sentiment</a>
    /// </summary>
    let Sentiment = _prefixId.prefix "Sentiment"
    /// <summary>
    ///   <para>rdfs:label : Statement</para>
    ///   <para>rdfs:comment : The statement class is the central class in the core of the KD ontology. It serves as a hub that connects sentiments (kdo:hasSentiment), opinions (kdo:hasOpinion), biases (kdo:hasBias), posts (kdo:hasPost), and agents (kdo:involvedAgent). Moreover, each statement may have an expression which is a string literal.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#Statement">kdo:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:label : has bias</para>
    ///   <para>rdfs:comment : The kdo:hasBias property is used associate a kdo:Bias with a sioc:Post.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasBias">kdo:hasBias</a>
    /// </summary>
    let hasBias = _prefixId.prefix "hasBias"
    /// <summary>
    ///   <para>rdfs:label : has expression</para>
    ///   <para>rdfs:comment : This property attaches a string literal to a kdo:Statement. This literal should be a text excerpt which states a statement and is extracted from a related post.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasExpression">kdo:hasExpression</a>
    /// </summary>
    let hasExpression = _prefixId.prefix "hasExpression"
    /// <summary>
    ///   <para>rdfs:label : has opinion</para>
    ///   <para>rdfs:comment : Relates a sioc:Post to a kdo:Opinion.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasOpinion">kdo:hasOpinion</a>
    /// </summary>
    let hasOpinion = _prefixId.prefix "hasOpinion"
    /// <summary>
    ///   <para>rdfs:label : has polarity</para>
    ///   <para>rdfs:comment : The kdo:hasPolarity is used to specify the polarity of a kdo:Sentiment. It has three individuals: kdo:positivePolarity representing the positive orientation, kdo:negativePolarity representing the negative orientation, kdo:neutralPolarity representing the neutral.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasPolarity">kdo:hasPolarity</a>
    /// </summary>
    let hasPolarity = _prefixId.prefix "hasPolarity"
    /// <summary>
    ///   <para>rdfs:label : has post</para>
    ///   <para>rdfs:comment : This class attaches a statement to a post^^xsd:string</para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasPost">kdo:hasPost</a>
    /// </summary>
    let hasPost = _prefixId.prefix "hasPost"
    /// <summary>
    ///   <para>rdfs:label : has score</para>
    ///   <para>rdfs:comment : This property indicates the score of a kdo:Sentiment. This score is denoted as a decimal. However, the range can vary and depends on the implementation of the sentiment extraction process.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasScore">kdo:hasScore</a>
    /// </summary>
    let hasScore = _prefixId.prefix "hasScore"
    /// <summary>
    ///   <para>rdfs:label : has sentiment</para>
    ///   <para>rdfs:comment : The kdo:hasSentiment property is used to specify which kdo:Sentiment is attached to a sioc:Post.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#hasSentiment">kdo:hasSentiment</a>
    /// </summary>
    let hasSentiment = _prefixId.prefix "hasSentiment"
    /// <summary>
    ///   <para>rdfs:label : involved agent</para>
    ///   <para>rdfs:comment : The kdo:involvedAgent property is used to specify the holder of an opinion. An opinion holder is represented by the foaf:Agent class.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#involvedAgent">kdo:involvedAgent</a>
    /// </summary>
    let involvedAgent = _prefixId.prefix "involvedAgent"
    let negativePolarity = _prefixId.prefix "negativePolarity"
    let neutralPolarity = _prefixId.prefix "neutralPolarity"
    let positivePolarity = _prefixId.prefix "positivePolarity"
    /// <summary>
    ///   <para>rdfs:label : related to</para>
    ///   <para>rdfs:comment : Relates one bias to another.
    /// </para>
    ///   <a href="http://kdo.render-project.eu/kdo#relatedTo">kdo:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
