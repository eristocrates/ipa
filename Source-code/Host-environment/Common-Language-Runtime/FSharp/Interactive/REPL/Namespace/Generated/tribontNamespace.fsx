#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tribont =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/tribont#" "tribont"
    /// <summary>
    ///   <para>rdfs:comment : A series of activities to carry out an experimentation procedure and measure its outputs.^^xsd:string</para>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Experiment^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#Experiment">tribont:Experiment</a>
    /// </summary>
    let Experiment = _prefixId.prefix "Experiment"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ExperimentalTest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A testing activity that reproduces certain operation conditions to assess one or more technical attributes or characteristics of a given sample or sample system.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#ExperimentalTest">tribont:ExperimentalTest</a>
    /// </summary>
    let ExperimentalTest = _prefixId.prefix "ExperimentalTest"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessMeasurement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A testing activity to measure  one or more  hardness attributes or characteristics of  a given sample.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#HardnessMeasurement">tribont:HardnessMeasurement</a>
    /// </summary>
    let HardnessMeasurement = _prefixId.prefix "HardnessMeasurement"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MeasuringTest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A testing activity that measures one or more attributes or characteristics of a given sample.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#MeasuringTest">tribont:MeasuringTest</a>
    /// </summary>
    let MeasuringTest = _prefixId.prefix "MeasuringTest"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Operator^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Person performing an specific activity or operation.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#Operator">tribont:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Test^^xsd:string</para>
    ///   <para>rdfs:comment : An activity intended to establish the techncial attributes or characteristics of something,^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#Test">tribont:Test</a>
    /// </summary>
    let Test = _prefixId.prefix "Test"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TestOutputDocument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A document compiling the outputs of a given test.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#TestOutputDocument">tribont:TestOutputDocument</a>
    /// </summary>
    let TestOutputDocument = _prefixId.prefix "TestOutputDocument"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TestOutputMeasurementFile^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Document including the output measures (i.e., technical properties) from a  test.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#TestOutputMeasurementFile">tribont:TestOutputMeasurementFile</a>
    /// </summary>
    let TestOutputMeasurementFile = _prefixId.prefix "TestOutputMeasurementFile"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TestOutputReport^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Document report ing the results of a test.  technical properties) from a  test.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#TestOutputReport">tribont:TestOutputReport</a>
    /// </summary>
    let TestOutputReport = _prefixId.prefix "TestOutputReport"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TestStandard^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A document approved by a recognized bodythat provides common to by fullfiled by a test.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#TestStandard">tribont:TestStandard</a>
    /// </summary>
    let TestStandard = _prefixId.prefix "TestStandard"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:comment : Each of the steps into which a given test can be subdivided^^xsd:string</para>
    ///   <para>rdfs:label : TestStep^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#TestStep">tribont:TestStep</a>
    /// </summary>
    let TestStep = _prefixId.prefix "TestStep"
    /// <summary>
    ///   <para>rdfs:label : TribologicalTest^^xsd:string</para>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A testing activity that reproduces certain operation conditions to assess one or more tribological attributes or characteristics of a given sample system.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#TribologicalTest">tribont:TribologicalTest</a>
    /// </summary>
    let TribologicalTest = _prefixId.prefix "TribologicalTest"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WearScarMeasurement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A testing activity to measure  one or more attributes or characteristics of the resulting scar in a given sample.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#WearScarMeasurement">tribont:WearScarMeasurement</a>
    /// </summary>
    let WearScarMeasurement = _prefixId.prefix "WearScarMeasurement"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WeightMeasurement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : A testing activity to measure the weight of a given sample.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#WeightMeasurement">tribont:WeightMeasurement</a>
    /// </summary>
    let WeightMeasurement = _prefixId.prefix "WeightMeasurement"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : executes^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an equipment and the activity it carries out.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#executes">tribont:executes</a>
    /// </summary>
    let executes = _prefixId.prefix "executes"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasAfterEndDependency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between an activity and the one preceeding it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#hasAfterEndDependency">tribont:hasAfterEndDependency</a>
    /// </summary>
    let hasAfterEndDependency = _prefixId.prefix "hasAfterEndDependency"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasDependency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies the dependency between two activities.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#hasDependency">tribont:hasDependency</a>
    /// </summary>
    let hasDependency = _prefixId.prefix "hasDependency"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasNofollowDependency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an activity has not a following dependency.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#hasNofollowDependency">tribont:hasNofollowDependency</a>
    /// </summary>
    let hasNofollowDependency = _prefixId.prefix "hasNofollowDependency"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isExecutedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an activity and the equipment that executes it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#isExecutedBy">tribont:isExecutedBy</a>
    /// </summary>
    let isExecutedBy = _prefixId.prefix "isExecutedBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isNext^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an activity and the one preceding it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#isNext">tribont:isNext</a>
    /// </summary>
    let isNext = _prefixId.prefix "isNext"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isPerformedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an activity and the person who performs it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#isPerformedBy">tribont:isPerformedBy</a>
    /// </summary>
    let isPerformedBy = _prefixId.prefix "isPerformedBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isPrevious^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an activity and the one following it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#isPrevious">tribont:isPrevious</a>
    /// </summary>
    let isPrevious = _prefixId.prefix "isPrevious"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isTestedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample body or sample system and the testing activity testing it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#isTestedBy">tribont:isTestedBy</a>
    /// </summary>
    let isTestedBy = _prefixId.prefix "isTestedBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : performs^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a person and the activity he/she performs.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#performs">tribont:performs</a>
    /// </summary>
    let performs = _prefixId.prefix "performs"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : tests^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a testing activity and what it tests (i.e., sample,  sample system).^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont#tests">tribont:tests</a>
    /// </summary>
    let tests = _prefixId.prefix "tests"
