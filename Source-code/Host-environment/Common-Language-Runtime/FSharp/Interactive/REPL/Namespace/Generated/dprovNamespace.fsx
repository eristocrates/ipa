#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dprov =
    let _prefixId = PrefixId.fromNamespaceLabel "http://promsns.org/def/do#" "dprov"
    /// <summary>
    ///   <para>rdfs:label : Answer</para>
    ///   <para>rdfs:comment : A recorded answer to a Question</para>
    ///   <a href="http://promsns.org/def/do#Answer">dprov:Answer</a>
    /// </summary>
    let Answer = _prefixId.prefix "Answer"
    let DecisionMaker = _prefixId.prefix "DecisionMaker"
    /// <summary>
    ///   <para>rdfs:label : Decision Making</para>
    ///   <para>rdfs:comment : A temporal event in which decision processes are undertaken, such as initiating sub-questions for the question to be answered, consideration of options etc.</para>
    ///   <a href="http://promsns.org/def/do#DecisionMaking">dprov:DecisionMaking</a>
    /// </summary>
    let DecisionMaking = _prefixId.prefix "DecisionMaking"
    let Decision_making = _prefixId.prefix "Decision_making"
    /// <summary>
    ///   <para>rdfs:label : OptionSelectionrdfs:label : Wybór opcji</para>
    ///   <para>rdfs:comment : Option Selection is a process (prov:Activity) through which a decision-making Agent selects something.
    ///
    /// At least two Option Selection Activities, possibly more, must be run in parrallel by an Agent and at least one must yield an outcome in order for a Question to be answered.</para>
    ///   <a href="http://promsns.org/def/do#OptionSelection">dprov:OptionSelection</a>
    /// </summary>
    let OptionSelection = _prefixId.prefix "OptionSelection"
    /// <summary>
    ///   <para>rdfs:label : Question</para>
    ///   <para>rdfs:comment : A recorded question</para>
    ///   <a href="http://promsns.org/def/do#Question">dprov:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>rdfs:label : Requirement</para>
    ///   <para>rdfs:comment : Requirements require something from an OptionSelection Activity. They indicate their requirement with a set (a class) of objects. They are then satisified by the presense of an onject within that class. Multiple Requirements can be intersected to require very specific OptionSelection outcomes.</para>
    ///   <a href="http://promsns.org/def/do#Requirement">dprov:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
