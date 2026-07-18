namespace http.kdo.render_project.eu.kdo.hash

open DoxAletheia.Rdf_Vocabulary

module kdo =
    let _namespace_name = "http://kdo.render-project.eu/kdo#"
    /// <summary>
    /// A bias can be attached to a kdo:Statement and can therefore also relate to agents, posts, and opinions. More specifically, a bias can also relate to another bias.
    ///
    ///
    /// <see href="http://kdo.render-project.eu/kdo#Bias"></see></summary>
    let Bias = Namespaced_IRI.parse _namespace_name "Bias" |> NamespacedName

    /// <summary>
    /// The kdo:NewsArticle class represents news articles. The news article class is defined because there is no class to represent news articles in the SIOC ontology. The NewsArticle is a subclass of the sioc:Post class which is itself a subclass of the foaf:Document.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#NewsArticle"></see></summary>
    let NewsArticle =
        Namespaced_IRI.parse _namespace_name "NewsArticle" |> NamespacedName

    /// <summary>
    /// The kdo:NewsWebsite class represents news publisher containers that are commonly related to a single web site. The NewsWebsite class is defined because there is no container class to represent the news publisher web sites in the SIOC ontology. The NewsWebsite class is defined as a subclass of the sioc:Container.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#NewsWebsite"></see></summary>
    let NewsWebsite =
        Namespaced_IRI.parse _namespace_name "NewsWebsite" |> NamespacedName

    /// <summary>
    /// The opinion class represents is used to contextualize2 provenance, crawling other meta-information. A blank node may be used to represent opinions. Opinions are connected to statement through kdo:hasOpinion.
    ///
    ///
    /// <see href="http://kdo.render-project.eu/kdo#Opinion"></see></summary>
    let Opinion = Namespaced_IRI.parse _namespace_name "Opinion" |> NamespacedName
    /// <summary>
    /// The kdo:Polarity class is used to express the polarity of sentiments. The predefined instances of this class are: kdo:neutralPolarity, kdo:positivePolarity, kdo:negativePolarity.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#Polarity"></see></summary>
    let Polarity = Namespaced_IRI.parse _namespace_name "Polarity" |> NamespacedName
    /// <summary>
    /// The sentiment class represents the sentiments expressed by the opinions and posts. A sentiment can have (kdo:hasPolarity) different types of polarity (positive, negative, and neutral) and a decimal score (kdo:hasScore). It is in the range of kdo:hasSentiment.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#Sentiment"></see></summary>
    let Sentiment = Namespaced_IRI.parse _namespace_name "Sentiment" |> NamespacedName
    /// <summary>
    /// The statement class is the central class in the core of the KD ontology. It serves as a hub that connects sentiments (kdo:hasSentiment), opinions (kdo:hasOpinion), biases (kdo:hasBias), posts (kdo:hasPost), and agents (kdo:involvedAgent). Moreover, each statement may have an expression which is a string literal.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    /// The kdo:hasBias property is used associate a kdo:Bias with a sioc:Post.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#hasBias"></see></summary>
    let hasBias = Namespaced_IRI.parse _namespace_name "hasBias" |> NamespacedName

    /// <summary>
    /// This property attaches a string literal to a kdo:Statement. This literal should be a text excerpt which states a statement and is extracted from a related post.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#hasExpression"></see></summary>
    let hasExpression =
        Namespaced_IRI.parse _namespace_name "hasExpression" |> NamespacedName

    /// <summary>
    /// Relates a sioc:Post to a kdo:Opinion.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#hasOpinion"></see></summary>
    let hasOpinion = Namespaced_IRI.parse _namespace_name "hasOpinion" |> NamespacedName

    /// <summary>
    /// The kdo:hasPolarity is used to specify the polarity of a kdo:Sentiment. It has three individuals: kdo:positivePolarity representing the positive orientation, kdo:negativePolarity representing the negative orientation, kdo:neutralPolarity representing the neutral.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#hasPolarity"></see></summary>
    let hasPolarity =
        Namespaced_IRI.parse _namespace_name "hasPolarity" |> NamespacedName

    /// <summary>
    /// This class attaches a statement to a post
    /// <see href="http://kdo.render-project.eu/kdo#hasPost"></see></summary>
    let hasPost = Namespaced_IRI.parse _namespace_name "hasPost" |> NamespacedName
    /// <summary>
    /// This property indicates the score of a kdo:Sentiment. This score is denoted as a decimal. However, the range can vary and depends on the implementation of the sentiment extraction process.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#hasScore"></see></summary>
    let hasScore = Namespaced_IRI.parse _namespace_name "hasScore" |> NamespacedName

    /// <summary>
    /// The kdo:hasSentiment property is used to specify which kdo:Sentiment is attached to a sioc:Post.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#hasSentiment"></see></summary>
    let hasSentiment =
        Namespaced_IRI.parse _namespace_name "hasSentiment" |> NamespacedName

    /// <summary>
    /// The kdo:involvedAgent property is used to specify the holder of an opinion. An opinion holder is represented by the foaf:Agent class.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#involvedAgent"></see></summary>
    let involvedAgent =
        Namespaced_IRI.parse _namespace_name "involvedAgent" |> NamespacedName

    /// <summary>
    /// This individual is used to mark a negative polarity.
    /// <see href="http://kdo.render-project.eu/kdo#negativePolarity"></see></summary>
    let negativePolarity =
        Namespaced_IRI.parse _namespace_name "negativePolarity" |> NamespacedName

    /// <summary>
    /// This individual is used to mark a neutral polarity.
    /// <see href="http://kdo.render-project.eu/kdo#neutralPolarity"></see></summary>
    let neutralPolarity =
        Namespaced_IRI.parse _namespace_name "neutralPolarity" |> NamespacedName

    /// <summary>
    /// This individual is used to mark a postitive polarity.
    /// <see href="http://kdo.render-project.eu/kdo#positivePolarity"></see></summary>
    let positivePolarity =
        Namespaced_IRI.parse _namespace_name "positivePolarity" |> NamespacedName

    /// <summary>
    /// Relates one bias to another.
    ///
    /// <see href="http://kdo.render-project.eu/kdo#relatedTo"></see></summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName
