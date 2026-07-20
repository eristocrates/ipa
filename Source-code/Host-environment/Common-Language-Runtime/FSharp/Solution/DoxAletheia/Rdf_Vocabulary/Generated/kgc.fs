namespace http.kgc.knowledge_graph.jp.ontology.kgc.owl.hash

open DoxAletheia

module kgc =
    let _namespace_name = "http://kgc.knowledge-graph.jp/ontology/kgc.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = _prefix "1.0.0"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#AbstractTime"></see>
    /// </summary>
    let AbstractTime = _prefix "AbstractTime"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ActionOption"></see>
    /// </summary>
    let ActionOption = _prefix "ActionOption"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Animal"></see>
    /// </summary>
    let Animal = _prefix "Animal"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#CanNotAction"></see>
    /// </summary>
    let CanNotAction = _prefix "CanNotAction"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#NotAction"></see>
    /// </summary>
    let NotAction = _prefix "NotAction"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#LocationProperty"></see>
    /// </summary>
    let LocationProperty = _prefix "LocationProperty"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneObjectProperty"></see>
    /// </summary>
    let SceneObjectProperty = _prefix "SceneObjectProperty"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Not"></see>
    /// </summary>
    let Not = _prefix "Not"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#OFobj"></see>
    /// </summary>
    let OFobj = _prefix "OFobj"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ORobj"></see>
    /// </summary>
    let ORobj = _prefix "ORobj"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Property"></see>
    /// </summary>
    let Property = _prefix "Property"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#RelationBetweenScene"></see>
    /// </summary>
    let RelationBetweenScene = _prefix "RelationBetweenScene"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Scene"></see>
    /// </summary>
    let Scene = _prefix "Scene"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneProperty"></see>
    /// </summary>
    let SceneProperty = _prefix "SceneProperty"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Situation"></see>
    /// </summary>
    let Situation = _prefix "Situation"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Statement"></see>
    /// </summary>
    let Statement = _prefix "Statement"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Talk"></see>
    /// </summary>
    let Talk = _prefix "Talk"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#TargetObjProperty"></see>
    /// </summary>
    let TargetObjProperty = _prefix "TargetObjProperty"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Thought"></see>
    /// </summary>
    let Thought = _prefix "Thought"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#adjunct"></see>
    /// </summary>
    let adjunct = _prefix "adjunct"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#around"></see>
    /// </summary>
    let around = _prefix "around"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#at_the_same_time"></see>
    /// </summary>
    let at_the_same_time = _prefix "at_the_same_time"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#because"></see>
    /// </summary>
    let because = _prefix "because"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#canNot"></see>
    /// </summary>
    let canNot = _prefix "canNot"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#from"></see>
    /// </summary>
    let from = _prefix "from"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPredicate"></see>
    /// </summary>
    let hasPredicate = _prefix "hasPredicate"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasProperty"></see>
    /// </summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#how"></see>
    /// </summary>
    let how = _prefix "how"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#if"></see>
    /// </summary>
    let if_ = _prefix "if"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoReceiver"></see>
    /// </summary>
    let infoReceiver = _prefix "infoReceiver"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoSource"></see>
    /// </summary>
    let infoSource = _prefix "infoSource"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#left"></see>
    /// </summary>
    let left = _prefix "left"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#middle"></see>
    /// </summary>
    let middle = _prefix "middle"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#near"></see>
    /// </summary>
    let near = _prefix "near"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#next_to"></see>
    /// </summary>
    let next_to = _prefix "next_to"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofPart"></see>
    /// </summary>
    let ofPart = _prefix "ofPart"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofWhole"></see>
    /// </summary>
    let ofWhole = _prefix "ofWhole"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#on"></see>
    /// </summary>
    let on = _prefix "on"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#opposite"></see>
    /// </summary>
    let opposite = _prefix "opposite"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#orTarget"></see>
    /// </summary>
    let orTarget = _prefix "orTarget"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#otherwise"></see>
    /// </summary>
    let otherwise = _prefix "otherwise"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#right"></see>
    /// </summary>
    let right = _prefix "right"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#then"></see>
    /// </summary>
    let then_ = _prefix "then"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#therefore"></see>
    /// </summary>
    let therefore = _prefix "therefore"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#time"></see>
    /// </summary>
    let time = _prefix "time"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#to"></see>
    /// </summary>
    let to_ = _prefix "to"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#what"></see>
    /// </summary>
    let what = _prefix "what"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#when"></see>
    /// </summary>
    let when_ = _prefix "when"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#when_during"></see>
    /// </summary>
    let when_during = _prefix "when_during"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#where"></see>
    /// </summary>
    let where = _prefix "where"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#whom"></see>
    /// </summary>
    let whom = _prefix "whom"
    /// <summary>
    ///   <see href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#why"></see>
    /// </summary>
    let why = _prefix "why"
