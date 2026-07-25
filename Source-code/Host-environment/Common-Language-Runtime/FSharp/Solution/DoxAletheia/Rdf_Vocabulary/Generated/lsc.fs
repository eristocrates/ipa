namespace http.linkedscience.org.lsc.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lsc =
    let _namespace_iri = Namespace_Iri lsc |> NamespaceIRI
    /// <summary>
    ///   <para>lsc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>hartigprov:DataItem</para>
    /// </remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#">http://linkedscience.org/lsc/ns#</seealso>
    let _prefix_iri = Prefixed_Name(lsc, "") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Hypothesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of hypothesis.</para>
    /// labels<para>Hypothesis</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Hypothesis">http://linkedscience.org/lsc/ns#Hypothesis</seealso>
    let Hypothesis = Prefixed_Name(lsc, "Hypothesis") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Research</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of research.</para>
    /// labels<para>Research</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Research">http://linkedscience.org/lsc/ns#Research</seealso>
    let Research = Prefixed_Name(lsc, "Research") |> PrefixedName
    /// <summary>
    ///   <para>lsc:confirms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A research confirms a hypothesis.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#confirms">http://linkedscience.org/lsc/ns#confirms</seealso>
    let confirms = Prefixed_Name(lsc, "confirms") |> PrefixedName
    /// <summary>
    ///   <para>lsc:dataProduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relation between a research and the data produced in it.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#dataProduced">http://linkedscience.org/lsc/ns#dataProduced</seealso>
    let dataProduced = Prefixed_Name(lsc, "dataProduced") |> PrefixedName
    /// <summary>
    ///   <para>lsc:isSupprtedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to express the relation between the hypothesis and the evidence of a research.</para>
    /// labels<para>isSupportedBy</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#isSupprtedBy">http://linkedscience.org/lsc/ns#isSupprtedBy</seealso>
    let isSupprtedBy = Prefixed_Name(lsc, "isSupprtedBy") |> PrefixedName
    /// <summary>
    ///   <para>lsc:isSupportedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#isSupportedBy">http://linkedscience.org/lsc/ns#isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(lsc, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>lsc:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A researcher participates in some research.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#participatesIn">http://linkedscience.org/lsc/ns#participatesIn</seealso>
    let participatesIn = Prefixed_Name(lsc, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>lsc:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A research produces a conclusion.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#produces">http://linkedscience.org/lsc/ns#produces</seealso>
    let produces = Prefixed_Name(lsc, "produces") |> PrefixedName
    /// <summary>
    ///   <para>lsc:tests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A research tests a hypothesis.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#tests">http://linkedscience.org/lsc/ns#tests</seealso>
    let tests = Prefixed_Name(lsc, "tests") |> PrefixedName
    /// <summary>
    ///   <para>lsc:timeAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to relate a publication to the time it was accepted.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#timeAccepted">http://linkedscience.org/lsc/ns#timeAccepted</seealso>
    let timeAccepted = Prefixed_Name(lsc, "timeAccepted") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of data.</para>
    /// labels<para>Data</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Data">http://linkedscience.org/lsc/ns#Data</seealso>
    let Data = Prefixed_Name(lsc, "Data") |> PrefixedName
    /// <summary>
    ///   <para>lsc:isAboutRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to define the region a research refers to.</para>
    /// labels<para>weeklyHours</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#isAboutRegion">http://linkedscience.org/lsc/ns#isAboutRegion</seealso>
    let isAboutRegion = Prefixed_Name(lsc, "isAboutRegion") |> PrefixedName
    /// <summary>
    ///   <para>lsc:makes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A hypothesis makes a prediction.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#makes">http://linkedscience.org/lsc/ns#makes</seealso>
    let makes = Prefixed_Name(lsc, "makes") |> PrefixedName
    /// <summary>
    ///   <para>lsc:reportedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to relate a research to the publications it is reported in.</para>
    /// labels<para>reportedIn</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#reportedIn">http://linkedscience.org/lsc/ns#reportedIn</seealso>
    let reportedIn = Prefixed_Name(lsc, "reportedIn") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Conclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conclusion is made by research.</para>
    /// labels<para>Conclusion</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Conclusion">http://linkedscience.org/lsc/ns#Conclusion</seealso>
    let Conclusion = Prefixed_Name(lsc, "Conclusion") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Prediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Prediction made by a hypothesis.</para>
    /// labels<para>Prediction</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Prediction">http://linkedscience.org/lsc/ns#Prediction</seealso>
    let Prediction = Prefixed_Name(lsc, "Prediction") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any kind of publication eg. scientific paper, book, journal publication.</para>
    /// labels<para>Publication</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Publication">http://linkedscience.org/lsc/ns#Publication</seealso>
    let Publication = Prefixed_Name(lsc, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A researcher that conducts research.</para>
    /// labels<para>Researcher</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Researcher">http://linkedscience.org/lsc/ns#Researcher</seealso>
    let Researcher = Prefixed_Name(lsc, "Researcher") |> PrefixedName
    /// <summary>
    ///   <para>lsc:dataUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relation between a research and the data used to conduct it.</para>
    /// labels<para>reportTemplate</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#dataUsed">http://linkedscience.org/lsc/ns#dataUsed</seealso>
    let dataUsed = Prefixed_Name(lsc, "dataUsed") |> PrefixedName
    /// <summary>
    ///   <para>lsc:falsifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A research falsifies a hypothesis.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#falsifies">http://linkedscience.org/lsc/ns#falsifies</seealso>
    let falsifies = Prefixed_Name(lsc, "falsifies") |> PrefixedName
    /// <summary>
    ///   <para>lsc:isAboutTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to relate a research to the time period it refers.</para>
    /// labels<para>isAboutTime</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#isAboutTime">http://linkedscience.org/lsc/ns#isAboutTime</seealso>
    let isAboutTime = Prefixed_Name(lsc, "isAboutTime") |> PrefixedName
    /// <summary>
    ///   <para>lsc:methodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A method used in a research.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#methodUsed">http://linkedscience.org/lsc/ns#methodUsed</seealso>
    let methodUsed = Prefixed_Name(lsc, "methodUsed") |> PrefixedName
    /// <summary>
    ///   <para>lsc:Method</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#Method">http://linkedscience.org/lsc/ns#Method</seealso>
    let Method = Prefixed_Name(lsc, "Method") |> PrefixedName
    /// <summary>
    ///   <para>lsc:reports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to report the research of a publication.</para>
    /// labels<para>grading</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#reports">http://linkedscience.org/lsc/ns#reports</seealso>
    let reports = Prefixed_Name(lsc, "reports") |> PrefixedName
    /// <summary>
    ///   <para>lsc:timeRevised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to relate a publication to the time it was revised.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#timeRevised">http://linkedscience.org/lsc/ns#timeRevised</seealso>
    let timeRevised = Prefixed_Name(lsc, "timeRevised") |> PrefixedName
    /// <summary>
    ///   <para>lsc:timeSubmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Abstract property to relate a publication to the time it was submitted.</para>
    /// labels<para>room</para></remarks>
    /// <seealso href="http://linkedscience.org/lsc/ns#timeSubmitted">http://linkedscience.org/lsc/ns#timeSubmitted</seealso>
    let timeSubmitted = Prefixed_Name(lsc, "timeSubmitted") |> PrefixedName
