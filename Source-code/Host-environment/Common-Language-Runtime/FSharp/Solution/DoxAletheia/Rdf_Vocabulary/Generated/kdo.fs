namespace http.kdo.render_project.eu.kdo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module kdo =
    let _namespace_iri = Namespace_Iri kdo |> NamespaceIRI
    /// <summary>
    ///   <para>kdo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology has been developed in context with the RENDER project.</para>
    /// </remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#">http://kdo.render-project.eu/kdo#</seealso>
    let _prefix_iri = Prefixed_Name(kdo, "") |> PrefixedName
    /// <summary>
    ///   <para>kdo:NewsWebsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The kdo:NewsWebsite class represents news publisher containers that are commonly related to a single web site. The NewsWebsite class is defined because there is no container class to represent the news publisher web sites in the SIOC ontology. The NewsWebsite class is defined as a subclass of the sioc:Container.
    /// </para>
    /// labels<para>News web site</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#NewsWebsite">http://kdo.render-project.eu/kdo#NewsWebsite</seealso>
    let NewsWebsite = Prefixed_Name(kdo, "NewsWebsite") |> PrefixedName
    /// <summary>
    ///   <para>kdo:Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The opinion class represents is used to contextualize2 provenance, crawling other meta-information. A blank node may be used to represent opinions. Opinions are connected to statement through kdo:hasOpinion.
    ///
    /// </para>
    /// labels<para>Opinion</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#Opinion">http://kdo.render-project.eu/kdo#Opinion</seealso>
    let Opinion = Prefixed_Name(kdo, "Opinion") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property attaches a string literal to a kdo:Statement. This literal should be a text excerpt which states a statement and is extracted from a related post.
    /// </para>
    /// labels<para>has expression</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasExpression">http://kdo.render-project.eu/kdo#hasExpression</seealso>
    let hasExpression = Prefixed_Name(kdo, "hasExpression") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasSentiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The kdo:hasSentiment property is used to specify which kdo:Sentiment is attached to a sioc:Post.
    /// </para>
    /// labels<para>has sentiment</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasSentiment">http://kdo.render-project.eu/kdo#hasSentiment</seealso>
    let hasSentiment = Prefixed_Name(kdo, "hasSentiment") |> PrefixedName
    /// <summary>
    ///   <para>kdo:Bias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A bias can be attached to a kdo:Statement and can therefore also relate to agents, posts, and opinions. More specifically, a bias can also relate to another bias.
    ///
    /// </para>
    /// labels<para>Bias</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#Bias">http://kdo.render-project.eu/kdo#Bias</seealso>
    let Bias = Prefixed_Name(kdo, "Bias") |> PrefixedName
    /// <summary>
    ///   <para>kdo:Polarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The kdo:Polarity class is used to express the polarity of sentiments. The predefined instances of this class are: kdo:neutralPolarity, kdo:positivePolarity, kdo:negativePolarity.
    /// </para>
    /// </remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#Polarity">http://kdo.render-project.eu/kdo#Polarity</seealso>
    let Polarity = Prefixed_Name(kdo, "Polarity") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasBias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The kdo:hasBias property is used associate a kdo:Bias with a sioc:Post.
    /// </para>
    /// labels<para>has bias</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasBias">http://kdo.render-project.eu/kdo#hasBias</seealso>
    let hasBias = Prefixed_Name(kdo, "hasBias") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a sioc:Post to a kdo:Opinion.
    /// </para>
    /// labels<para>has opinion</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasOpinion">http://kdo.render-project.eu/kdo#hasOpinion</seealso>
    let hasOpinion = Prefixed_Name(kdo, "hasOpinion") |> PrefixedName
    /// <summary>
    ///   <para>kdo:negativePolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>kdo:Polarity</para>
    ///   <para>This individual is used to mark a negative polarity.</para>
    /// labels<para>Negative polarity</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#negativePolarity">http://kdo.render-project.eu/kdo#negativePolarity</seealso>
    let negativePolarity = Prefixed_Name(kdo, "negativePolarity") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasPolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The kdo:hasPolarity is used to specify the polarity of a kdo:Sentiment. It has three individuals: kdo:positivePolarity representing the positive orientation, kdo:negativePolarity representing the negative orientation, kdo:neutralPolarity representing the neutral.
    /// </para>
    /// labels<para>has polarity</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasPolarity">http://kdo.render-project.eu/kdo#hasPolarity</seealso>
    let hasPolarity = Prefixed_Name(kdo, "hasPolarity") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property indicates the score of a kdo:Sentiment. This score is denoted as a decimal. However, the range can vary and depends on the implementation of the sentiment extraction process.
    /// </para>
    /// labels<para>has score</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasScore">http://kdo.render-project.eu/kdo#hasScore</seealso>
    let hasScore = Prefixed_Name(kdo, "hasScore") |> PrefixedName
    /// <summary>
    ///   <para>kdo:hasPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This class attaches a statement to a post</para>
    /// labels<para>has post</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#hasPost">http://kdo.render-project.eu/kdo#hasPost</seealso>
    let hasPost = Prefixed_Name(kdo, "hasPost") |> PrefixedName
    /// <summary>
    ///   <para>kdo:involvedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The kdo:involvedAgent property is used to specify the holder of an opinion. An opinion holder is represented by the foaf:Agent class.
    /// </para>
    /// labels<para>involved agent</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#involvedAgent">http://kdo.render-project.eu/kdo#involvedAgent</seealso>
    let involvedAgent = Prefixed_Name(kdo, "involvedAgent") |> PrefixedName
    /// <summary>
    ///   <para>kdo:positivePolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>kdo:Polarity</para>
    ///   <para>This individual is used to mark a postitive polarity.</para>
    /// labels<para>Positive polarity</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#positivePolarity">http://kdo.render-project.eu/kdo#positivePolarity</seealso>
    let positivePolarity = Prefixed_Name(kdo, "positivePolarity") |> PrefixedName
    /// <summary>
    ///   <para>kdo:neutralPolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>kdo:Polarity</para>
    ///   <para>This individual is used to mark a neutral polarity.</para>
    /// labels<para>Neutral polarity</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#neutralPolarity">http://kdo.render-project.eu/kdo#neutralPolarity</seealso>
    let neutralPolarity = Prefixed_Name(kdo, "neutralPolarity") |> PrefixedName
    /// <summary>
    ///   <para>kdo:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates one bias to another.
    /// </para>
    /// labels<para>related to</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#relatedTo">http://kdo.render-project.eu/kdo#relatedTo</seealso>
    let relatedTo = Prefixed_Name(kdo, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>kdo:NewsArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The kdo:NewsArticle class represents news articles. The news article class is defined because there is no class to represent news articles in the SIOC ontology. The NewsArticle is a subclass of the sioc:Post class which is itself a subclass of the foaf:Document.
    /// </para>
    /// labels<para>News article</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#NewsArticle">http://kdo.render-project.eu/kdo#NewsArticle</seealso>
    let NewsArticle = Prefixed_Name(kdo, "NewsArticle") |> PrefixedName
    /// <summary>
    ///   <para>kdo:Sentiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The sentiment class represents the sentiments expressed by the opinions and posts. A sentiment can have (kdo:hasPolarity) different types of polarity (positive, negative, and neutral) and a decimal score (kdo:hasScore). It is in the range of kdo:hasSentiment.
    /// </para>
    /// labels<para>Sentiment</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#Sentiment">http://kdo.render-project.eu/kdo#Sentiment</seealso>
    let Sentiment = Prefixed_Name(kdo, "Sentiment") |> PrefixedName
    /// <summary>
    ///   <para>kdo:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The statement class is the central class in the core of the KD ontology. It serves as a hub that connects sentiments (kdo:hasSentiment), opinions (kdo:hasOpinion), biases (kdo:hasBias), posts (kdo:hasPost), and agents (kdo:involvedAgent). Moreover, each statement may have an expression which is a string literal.
    /// </para>
    /// labels<para>Statement</para></remarks>
    /// <seealso href="http://kdo.render-project.eu/kdo#Statement">http://kdo.render-project.eu/kdo#Statement</seealso>
    let Statement = Prefixed_Name(kdo, "Statement") |> PrefixedName
