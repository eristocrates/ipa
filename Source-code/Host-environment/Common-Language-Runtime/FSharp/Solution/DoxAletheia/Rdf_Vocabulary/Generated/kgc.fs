namespace http.kgc.knowledge_graph.jp.ontology.kgc.owl.hash

open DoxAletheia.Rdf_Vocabulary

module kgc =
    let _namespace_name = "http://kgc.knowledge-graph.jp/ontology/kgc.owl#"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = Namespaced_IRI.parse _namespace_name "1.0.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#AbstractTime"></see>
    /// </summary>
    let AbstractTime =
        Namespaced_IRI.parse _namespace_name "AbstractTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ActionOption"></see>
    /// </summary>
    let ActionOption =
        Namespaced_IRI.parse _namespace_name "ActionOption" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Animal"></see>
    /// </summary>
    let Animal = Namespaced_IRI.parse _namespace_name "Animal" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#CanNotAction"></see>
    /// </summary>
    let CanNotAction =
        Namespaced_IRI.parse _namespace_name "CanNotAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#NotAction"></see>
    /// </summary>
    let NotAction = Namespaced_IRI.parse _namespace_name "NotAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#LocationProperty"></see>
    /// </summary>
    let LocationProperty =
        Namespaced_IRI.parse _namespace_name "LocationProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneObjectProperty"></see>
    /// </summary>
    let SceneObjectProperty =
        Namespaced_IRI.parse _namespace_name "SceneObjectProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Not"></see>
    /// </summary>
    let Not = Namespaced_IRI.parse _namespace_name "Not" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#OFobj"></see>
    /// </summary>
    let OFobj = Namespaced_IRI.parse _namespace_name "OFobj" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ORobj"></see>
    /// </summary>
    let ORobj = Namespaced_IRI.parse _namespace_name "ORobj" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Property"></see>
    /// </summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#RelationBetweenScene"></see>
    /// </summary>
    let RelationBetweenScene =
        Namespaced_IRI.parse _namespace_name "RelationBetweenScene" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Scene"></see>
    /// </summary>
    let Scene = Namespaced_IRI.parse _namespace_name "Scene" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneProperty"></see>
    /// </summary>
    let SceneProperty =
        Namespaced_IRI.parse _namespace_name "SceneProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Situation"></see>
    /// </summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Statement"></see>
    /// </summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Talk"></see>
    /// </summary>
    let Talk = Namespaced_IRI.parse _namespace_name "Talk" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#TargetObjProperty"></see>
    /// </summary>
    let TargetObjProperty =
        Namespaced_IRI.parse _namespace_name "TargetObjProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Thought"></see>
    /// </summary>
    let Thought = Namespaced_IRI.parse _namespace_name "Thought" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#adjunct"></see>
    /// </summary>
    let adjunct = Namespaced_IRI.parse _namespace_name "adjunct" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#around"></see>
    /// </summary>
    let around = Namespaced_IRI.parse _namespace_name "around" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#at_the_same_time"></see>
    /// </summary>
    let at_the_same_time =
        Namespaced_IRI.parse _namespace_name "at_the_same_time" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#because"></see>
    /// </summary>
    let because = Namespaced_IRI.parse _namespace_name "because" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#canNot"></see>
    /// </summary>
    let canNot = Namespaced_IRI.parse _namespace_name "canNot" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#from"></see>
    /// </summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPredicate"></see>
    /// </summary>
    let hasPredicate =
        Namespaced_IRI.parse _namespace_name "hasPredicate" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasProperty"></see>
    /// </summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#how"></see>
    /// </summary>
    let how = Namespaced_IRI.parse _namespace_name "how" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#if"></see>
    /// </summary>
    let if_ = Namespaced_IRI.parse _namespace_name "if" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoReceiver"></see>
    /// </summary>
    let infoReceiver =
        Namespaced_IRI.parse _namespace_name "infoReceiver" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoSource"></see>
    /// </summary>
    let infoSource = Namespaced_IRI.parse _namespace_name "infoSource" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#left"></see>
    /// </summary>
    let left = Namespaced_IRI.parse _namespace_name "left" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#middle"></see>
    /// </summary>
    let middle = Namespaced_IRI.parse _namespace_name "middle" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#near"></see>
    /// </summary>
    let near = Namespaced_IRI.parse _namespace_name "near" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#next_to"></see>
    /// </summary>
    let next_to = Namespaced_IRI.parse _namespace_name "next_to" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofPart"></see>
    /// </summary>
    let ofPart = Namespaced_IRI.parse _namespace_name "ofPart" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofWhole"></see>
    /// </summary>
    let ofWhole = Namespaced_IRI.parse _namespace_name "ofWhole" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#on"></see>
    /// </summary>
    let on = Namespaced_IRI.parse _namespace_name "on" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#opposite"></see>
    /// </summary>
    let opposite = Namespaced_IRI.parse _namespace_name "opposite" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#orTarget"></see>
    /// </summary>
    let orTarget = Namespaced_IRI.parse _namespace_name "orTarget" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#otherwise"></see>
    /// </summary>
    let otherwise = Namespaced_IRI.parse _namespace_name "otherwise" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#right"></see>
    /// </summary>
    let right = Namespaced_IRI.parse _namespace_name "right" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#then"></see>
    /// </summary>
    let then_ = Namespaced_IRI.parse _namespace_name "then" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#therefore"></see>
    /// </summary>
    let therefore = Namespaced_IRI.parse _namespace_name "therefore" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#time"></see>
    /// </summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#to"></see>
    /// </summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#what"></see>
    /// </summary>
    let what = Namespaced_IRI.parse _namespace_name "what" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#when"></see>
    /// </summary>
    let when_ = Namespaced_IRI.parse _namespace_name "when" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#when_during"></see>
    /// </summary>
    let when_during =
        Namespaced_IRI.parse _namespace_name "when_during" |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#where"></see>
    /// </summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#whom"></see>
    /// </summary>
    let whom = Namespaced_IRI.parse _namespace_name "whom" |> NamespacedName
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#why"></see>
    /// </summary>
    let why = Namespaced_IRI.parse _namespace_name "why" |> NamespacedName
