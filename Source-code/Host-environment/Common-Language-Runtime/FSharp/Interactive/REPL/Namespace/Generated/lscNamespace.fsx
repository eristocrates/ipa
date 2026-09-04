#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lsc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://linkedscience.org/lsc/ns#" "lsc"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Conclusion is made by research.</para>
    ///   <para>rdfs:label : Conclusion</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Conclusion">lsc:Conclusion</a>
    /// </summary>
    let Conclusion = _prefixId.prefix "Conclusion"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of data.</para>
    ///   <para>rdfs:label : Data</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Data">lsc:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of hypothesis.</para>
    ///   <para>rdfs:label : Hypothesis</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Hypothesis">lsc:Hypothesis</a>
    /// </summary>
    let Hypothesis = _prefixId.prefix "Hypothesis"
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:comment : Prediction made by a hypothesis.</para>
    ///   <para>rdfs:label : Prediction</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Prediction">lsc:Prediction</a>
    /// </summary>
    let Prediction = _prefixId.prefix "Prediction"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of publication eg. scientific paper, book, journal publication.</para>
    ///   <para>rdfs:label : Publication</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Publication">lsc:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of research.</para>
    ///   <para>rdfs:label : Research</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Research">lsc:Research</a>
    /// </summary>
    let Research = _prefixId.prefix "Research"
    /// <summary>
    ///   <para>rdfs:comment : A researcher that conducts research.</para>
    ///   <para>rdfs:label : Researcher</para>
    ///   <a href="http://linkedscience.org/lsc/ns#Researcher">lsc:Researcher</a>
    /// </summary>
    let Researcher = _prefixId.prefix "Researcher"
    /// <summary>
    ///   <para>rdfs:comment : A research confirms a hypothesis.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#confirms">lsc:confirms</a>
    /// </summary>
    let confirms = _prefixId.prefix "confirms"
    /// <summary>
    ///   <para>rdfs:comment : Describes the relation between a research and the data produced in it.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#dataProduced">lsc:dataProduced</a>
    /// </summary>
    let dataProduced = _prefixId.prefix "dataProduced"
    /// <summary>
    ///   <para>rdfs:comment : Describes the relation between a research and the data used to conduct it.</para>
    ///   <para>rdfs:label : reportTemplate</para>
    ///   <a href="http://linkedscience.org/lsc/ns#dataUsed">lsc:dataUsed</a>
    /// </summary>
    let dataUsed = _prefixId.prefix "dataUsed"
    /// <summary>
    ///   <para>rdfs:comment : A research falsifies a hypothesis.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#falsifies">lsc:falsifies</a>
    /// </summary>
    let falsifies = _prefixId.prefix "falsifies"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to define the region a research refers to.</para>
    ///   <para>rdfs:label : weeklyHours</para>
    ///   <a href="http://linkedscience.org/lsc/ns#isAboutRegion">lsc:isAboutRegion</a>
    /// </summary>
    let isAboutRegion = _prefixId.prefix "isAboutRegion"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to relate a research to the time period it refers.</para>
    ///   <para>rdfs:label : isAboutTime</para>
    ///   <a href="http://linkedscience.org/lsc/ns#isAboutTime">lsc:isAboutTime</a>
    /// </summary>
    let isAboutTime = _prefixId.prefix "isAboutTime"
    let isSupportedBy = _prefixId.prefix "isSupportedBy"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to express the relation between the hypothesis and the evidence of a research.</para>
    ///   <para>rdfs:label : isSupportedBy</para>
    ///   <a href="http://linkedscience.org/lsc/ns#isSupprtedBy">lsc:isSupprtedBy</a>
    /// </summary>
    let isSupprtedBy = _prefixId.prefix "isSupprtedBy"
    /// <summary>
    ///   <para>rdfs:comment : A hypothesis makes a prediction.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#makes">lsc:makes</a>
    /// </summary>
    let makes = _prefixId.prefix "makes"
    /// <summary>
    ///   <para>rdfs:comment : A method used in a research.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#methodUsed">lsc:methodUsed</a>
    /// </summary>
    let methodUsed = _prefixId.prefix "methodUsed"
    /// <summary>
    ///   <para>rdfs:comment : A researcher participates in some research.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#participatesIn">lsc:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>rdfs:comment : A research produces a conclusion.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#produces">lsc:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to relate a research to the publications it is reported in.</para>
    ///   <para>rdfs:label : reportedIn</para>
    ///   <a href="http://linkedscience.org/lsc/ns#reportedIn">lsc:reportedIn</a>
    /// </summary>
    let reportedIn = _prefixId.prefix "reportedIn"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to report the research of a publication.</para>
    ///   <para>rdfs:label : grading</para>
    ///   <a href="http://linkedscience.org/lsc/ns#reports">lsc:reports</a>
    /// </summary>
    let reports = _prefixId.prefix "reports"
    /// <summary>
    ///   <para>rdfs:comment : A research tests a hypothesis.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#tests">lsc:tests</a>
    /// </summary>
    let tests = _prefixId.prefix "tests"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to relate a publication to the time it was accepted.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#timeAccepted">lsc:timeAccepted</a>
    /// </summary>
    let timeAccepted = _prefixId.prefix "timeAccepted"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to relate a publication to the time it was revised.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#timeRevised">lsc:timeRevised</a>
    /// </summary>
    let timeRevised = _prefixId.prefix "timeRevised"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property to relate a publication to the time it was submitted.</para>
    ///   <para>rdfs:label : room</para>
    ///   <a href="http://linkedscience.org/lsc/ns#timeSubmitted">lsc:timeSubmitted</a>
    /// </summary>
    let timeSubmitted = _prefixId.prefix "timeSubmitted"
