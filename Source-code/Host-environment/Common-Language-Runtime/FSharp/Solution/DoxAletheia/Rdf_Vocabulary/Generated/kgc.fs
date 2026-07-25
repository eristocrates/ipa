namespace http.kgc.knowledge_graph.jp.ontology.kgc.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module kgc =
    let _namespace_iri = Namespace_Iri kgc |> NamespaceIRI
    /// <summary>
    ///   <para>kgc:AbstractTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#AbstractTime">http://kgc.knowledge-graph.jp/ontology/kgc.owl#AbstractTime</seealso>
    let AbstractTime = Prefixed_Name(kgc, "AbstractTime") |> PrefixedName
    /// <summary>
    ///   <para>kgc:CanNotAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#CanNotAction">http://kgc.knowledge-graph.jp/ontology/kgc.owl#CanNotAction</seealso>
    let CanNotAction = Prefixed_Name(kgc, "CanNotAction") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Object">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Object</seealso>
    let Object = Prefixed_Name(kgc, "Object") |> PrefixedName
    /// <summary>
    ///   <para>kgc:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#from">http://kgc.knowledge-graph.jp/ontology/kgc.owl#from</seealso>
    let from = Prefixed_Name(kgc, "from") |> PrefixedName
    /// <summary>
    ///   <para>kgc:infoSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoSource">http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoSource</seealso>
    let infoSource = Prefixed_Name(kgc, "infoSource") |> PrefixedName
    /// <summary>
    ///   <para>kgc:ofPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofPart">http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofPart</seealso>
    let ofPart = Prefixed_Name(kgc, "ofPart") |> PrefixedName
    /// <summary>
    ///   <para>kgc:orTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#orTarget">http://kgc.knowledge-graph.jp/ontology/kgc.owl#orTarget</seealso>
    let orTarget = Prefixed_Name(kgc, "orTarget") |> PrefixedName
    /// <summary>
    ///   <para>kgc:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#subject">http://kgc.knowledge-graph.jp/ontology/kgc.owl#subject</seealso>
    let subject = Prefixed_Name(kgc, "subject") |> PrefixedName
    /// <summary>
    ///   <para>kgc:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#to">http://kgc.knowledge-graph.jp/ontology/kgc.owl#to</seealso>
    let to_ = Prefixed_Name(kgc, "to") |> PrefixedName
    /// <summary>
    ///   <para>kgc:when_during</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#when_during">http://kgc.knowledge-graph.jp/ontology/kgc.owl#when_during</seealso>
    let when_during = Prefixed_Name(kgc, "when_during") |> PrefixedName
    /// <summary>
    ///   <para>kgc:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#where">http://kgc.knowledge-graph.jp/ontology/kgc.owl#where</seealso>
    let where = Prefixed_Name(kgc, "where") |> PrefixedName
    /// <summary>
    ///   <para>kgc:ActionOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ActionOption">http://kgc.knowledge-graph.jp/ontology/kgc.owl#ActionOption</seealso>
    let ActionOption = Prefixed_Name(kgc, "ActionOption") |> PrefixedName
    /// <summary>
    ///   <para>kgc:ORobj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ORobj">http://kgc.knowledge-graph.jp/ontology/kgc.owl#ORobj</seealso>
    let ORobj = Prefixed_Name(kgc, "ORobj") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Action">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Action</seealso>
    let Action = Prefixed_Name(kgc, "Action") |> PrefixedName
    /// <summary>
    ///   <para>kgc:LocationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#LocationProperty">http://kgc.knowledge-graph.jp/ontology/kgc.owl#LocationProperty</seealso>
    let LocationProperty = Prefixed_Name(kgc, "LocationProperty") |> PrefixedName
    /// <summary>
    ///   <para>kgc:OFobj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#OFobj">http://kgc.knowledge-graph.jp/ontology/kgc.owl#OFobj</seealso>
    let OFobj = Prefixed_Name(kgc, "OFobj") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Scene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Scene">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Scene</seealso>
    let Scene = Prefixed_Name(kgc, "Scene") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Statement">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Statement</seealso>
    let Statement = Prefixed_Name(kgc, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Thought</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Thought">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Thought</seealso>
    let Thought = Prefixed_Name(kgc, "Thought") |> PrefixedName
    /// <summary>
    ///   <para>kgc:around</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#around">http://kgc.knowledge-graph.jp/ontology/kgc.owl#around</seealso>
    let around = Prefixed_Name(kgc, "around") |> PrefixedName
    /// <summary>
    ///   <para>kgc:canNot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#canNot">http://kgc.knowledge-graph.jp/ontology/kgc.owl#canNot</seealso>
    let canNot = Prefixed_Name(kgc, "canNot") |> PrefixedName
    /// <summary>
    ///   <para>kgc:hasPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPredicate">http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPredicate</seealso>
    let hasPredicate = Prefixed_Name(kgc, "hasPredicate") |> PrefixedName
    /// <summary>
    ///   <para>kgc:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasProperty">http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasProperty</seealso>
    let hasProperty = Prefixed_Name(kgc, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>kgc:NotAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#NotAction">http://kgc.knowledge-graph.jp/ontology/kgc.owl#NotAction</seealso>
    let NotAction = Prefixed_Name(kgc, "NotAction") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Person">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Person</seealso>
    let Person = Prefixed_Name(kgc, "Person") |> PrefixedName
    /// <summary>
    ///   <para>kgc:SceneProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneProperty">http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneProperty</seealso>
    let SceneProperty = Prefixed_Name(kgc, "SceneProperty") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Place">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Place</seealso>
    let Place = Prefixed_Name(kgc, "Place") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Situation">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Situation</seealso>
    let Situation = Prefixed_Name(kgc, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>kgc:adjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#adjunct">http://kgc.knowledge-graph.jp/ontology/kgc.owl#adjunct</seealso>
    let adjunct = Prefixed_Name(kgc, "adjunct") |> PrefixedName
    /// <summary>
    ///   <para>kgc:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPart">http://kgc.knowledge-graph.jp/ontology/kgc.owl#hasPart</seealso>
    let hasPart = Prefixed_Name(kgc, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>kgc:infoReceiver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoReceiver">http://kgc.knowledge-graph.jp/ontology/kgc.owl#infoReceiver</seealso>
    let infoReceiver = Prefixed_Name(kgc, "infoReceiver") |> PrefixedName
    /// <summary>
    ///   <para>kgc:near</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#near">http://kgc.knowledge-graph.jp/ontology/kgc.owl#near</seealso>
    let near = Prefixed_Name(kgc, "near") |> PrefixedName
    /// <summary>
    ///   <para>kgc:ofWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofWhole">http://kgc.knowledge-graph.jp/ontology/kgc.owl#ofWhole</seealso>
    let ofWhole = Prefixed_Name(kgc, "ofWhole") |> PrefixedName
    /// <summary>
    ///   <para>kgc:right</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#right">http://kgc.knowledge-graph.jp/ontology/kgc.owl#right</seealso>
    let right = Prefixed_Name(kgc, "right") |> PrefixedName
    /// <summary>
    ///   <para>kgc:what</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#what">http://kgc.knowledge-graph.jp/ontology/kgc.owl#what</seealso>
    let what = Prefixed_Name(kgc, "what") |> PrefixedName
    /// <summary>
    ///   <para>kgc:next_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#next_to">http://kgc.knowledge-graph.jp/ontology/kgc.owl#next_to</seealso>
    let next_to = Prefixed_Name(kgc, "next_to") |> PrefixedName
    /// <summary>
    ///   <para>kgc:otherwise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#otherwise">http://kgc.knowledge-graph.jp/ontology/kgc.owl#otherwise</seealso>
    let otherwise = Prefixed_Name(kgc, "otherwise") |> PrefixedName
    /// <summary>
    ///   <para>kgc:when</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#when">http://kgc.knowledge-graph.jp/ontology/kgc.owl#when</seealso>
    let when_ = Prefixed_Name(kgc, "when") |> PrefixedName
    /// <summary>
    ///   <para>kgc:1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#1.0.0">http://kgc.knowledge-graph.jp/ontology/kgc.owl#1.0.0</seealso>
    let ``_1.0.0`` = Prefixed_Name(kgc, "1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Animal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Animal">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Animal</seealso>
    let Animal = Prefixed_Name(kgc, "Animal") |> PrefixedName
    /// <summary>
    ///   <para>kgc:SceneObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneObjectProperty">http://kgc.knowledge-graph.jp/ontology/kgc.owl#SceneObjectProperty</seealso>
    let SceneObjectProperty = Prefixed_Name(kgc, "SceneObjectProperty") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Not</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Not">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Not</seealso>
    let Not = Prefixed_Name(kgc, "Not") |> PrefixedName
    /// <summary>
    ///   <para>kgc:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Property">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Property</seealso>
    let Property = Prefixed_Name(kgc, "Property") |> PrefixedName

    /// <summary>
    ///   <para>kgc:RelationBetweenScene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#RelationBetweenScene">http://kgc.knowledge-graph.jp/ontology/kgc.owl#RelationBetweenScene</seealso>
    let RelationBetweenScene =
        Prefixed_Name(kgc, "RelationBetweenScene") |> PrefixedName

    /// <summary>
    ///   <para>kgc:Talk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#Talk">http://kgc.knowledge-graph.jp/ontology/kgc.owl#Talk</seealso>
    let Talk = Prefixed_Name(kgc, "Talk") |> PrefixedName
    /// <summary>
    ///   <para>kgc:TargetObjProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#TargetObjProperty">http://kgc.knowledge-graph.jp/ontology/kgc.owl#TargetObjProperty</seealso>
    let TargetObjProperty = Prefixed_Name(kgc, "TargetObjProperty") |> PrefixedName
    /// <summary>
    ///   <para>kgc:at_the_same_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#at_the_same_time">http://kgc.knowledge-graph.jp/ontology/kgc.owl#at_the_same_time</seealso>
    let at_the_same_time = Prefixed_Name(kgc, "at_the_same_time") |> PrefixedName
    /// <summary>
    ///   <para>kgc:because</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#because">http://kgc.knowledge-graph.jp/ontology/kgc.owl#because</seealso>
    let because = Prefixed_Name(kgc, "because") |> PrefixedName
    /// <summary>
    ///   <para>kgc:how</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#how">http://kgc.knowledge-graph.jp/ontology/kgc.owl#how</seealso>
    let how = Prefixed_Name(kgc, "how") |> PrefixedName
    /// <summary>
    ///   <para>kgc:if</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#if">http://kgc.knowledge-graph.jp/ontology/kgc.owl#if</seealso>
    let if_ = Prefixed_Name(kgc, "if") |> PrefixedName
    /// <summary>
    ///   <para>kgc:left</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#left">http://kgc.knowledge-graph.jp/ontology/kgc.owl#left</seealso>
    let left = Prefixed_Name(kgc, "left") |> PrefixedName
    /// <summary>
    ///   <para>kgc:middle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#middle">http://kgc.knowledge-graph.jp/ontology/kgc.owl#middle</seealso>
    let middle = Prefixed_Name(kgc, "middle") |> PrefixedName
    /// <summary>
    ///   <para>kgc:on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#on">http://kgc.knowledge-graph.jp/ontology/kgc.owl#on</seealso>
    let on = Prefixed_Name(kgc, "on") |> PrefixedName
    /// <summary>
    ///   <para>kgc:opposite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#opposite">http://kgc.knowledge-graph.jp/ontology/kgc.owl#opposite</seealso>
    let opposite = Prefixed_Name(kgc, "opposite") |> PrefixedName
    /// <summary>
    ///   <para>kgc:then</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#then">http://kgc.knowledge-graph.jp/ontology/kgc.owl#then</seealso>
    let then_ = Prefixed_Name(kgc, "then") |> PrefixedName
    /// <summary>
    ///   <para>kgc:therefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#therefore">http://kgc.knowledge-graph.jp/ontology/kgc.owl#therefore</seealso>
    let therefore = Prefixed_Name(kgc, "therefore") |> PrefixedName
    /// <summary>
    ///   <para>kgc:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#time">http://kgc.knowledge-graph.jp/ontology/kgc.owl#time</seealso>
    let time = Prefixed_Name(kgc, "time") |> PrefixedName
    /// <summary>
    ///   <para>kgc:whom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#whom">http://kgc.knowledge-graph.jp/ontology/kgc.owl#whom</seealso>
    let whom = Prefixed_Name(kgc, "whom") |> PrefixedName
    /// <summary>
    ///   <para>kgc:why</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://kgc.knowledge-graph.jp/ontology/kgc.owl#why">http://kgc.knowledge-graph.jp/ontology/kgc.owl#why</seealso>
    let why = Prefixed_Name(kgc, "why") |> PrefixedName
