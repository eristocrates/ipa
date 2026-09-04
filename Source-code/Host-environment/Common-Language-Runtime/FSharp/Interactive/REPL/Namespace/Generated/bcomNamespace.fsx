#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bcom =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/bcom#" "bcom"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : air temperature</para>
    ///   <para>rdfs:comment : air temperature during concreting or testing on fresh concrete in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#AirTemperature">bcom:AirTemperature</a>
    /// </summary>
    let AirTemperature = _prefixId.prefix "AirTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : begin date</para>
    ///   <para>rdfs:comment : begin date of concrete curing with format year-month-day in yyyy-mm-dd</para>
    ///   <a href="https://w3id.org/bcom#BeginDate">bcom:BeginDate</a>
    /// </summary>
    let BeginDate = _prefixId.prefix "BeginDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : begin time</para>
    ///   <para>rdfs:comment : begin time of concrete placement with format hour-minute-second in hh:mm:ss</para>
    ///   <a href="https://w3id.org/bcom#BeginTimeOfPlacement">bcom:BeginTimeOfPlacement</a>
    /// </summary>
    let BeginTimeOfPlacement = _prefixId.prefix "BeginTimeOfPlacement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : bulk density</para>
    ///   <para>rdfs:comment : bulk density of fresh concrete in kg/m^3</para>
    ///   <a href="https://w3id.org/bcom#BulkDensity">bcom:BulkDensity</a>
    /// </summary>
    let BulkDensity = _prefixId.prefix "BulkDensity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : class of monitoring</para>
    ///   <para>rdfs:comment : class of concrete monitoring according to DIN EN 13670 / DIN 1045-3 related to the properties of hardened concrete</para>
    ///   <a href="https://w3id.org/bcom#ClassOfMonitoring">bcom:ClassOfMonitoring</a>
    /// </summary>
    let ClassOfMonitoring = _prefixId.prefix "ClassOfMonitoring"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Concrete curing</para>
    ///   <para>rdfs:comment : This class provides information about the curing process after a concrete placement.</para>
    ///   <a href="https://w3id.org/bcom#ConcreteCuring">bcom:ConcreteCuring</a>
    /// </summary>
    let ConcreteCuring = _prefixId.prefix "ConcreteCuring"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Concrete delivery</para>
    ///   <para>rdfs:comment : This class provides information about a concrete delivery.</para>
    ///   <a href="https://w3id.org/bcom#ConcreteDelivery">bcom:ConcreteDelivery</a>
    /// </summary>
    let ConcreteDelivery = _prefixId.prefix "ConcreteDelivery"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Concrete placement</para>
    ///   <para>rdfs:comment : This class provides information about a concreting process itself.</para>
    ///   <a href="https://w3id.org/bcom#ConcretePlacement">bcom:ConcretePlacement</a>
    /// </summary>
    let ConcretePlacement = _prefixId.prefix "ConcretePlacement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : fresh concrete temperature</para>
    ///   <para>rdfs:comment : fresh concrete temperature during testing of properties in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#ConcreteTemperature">bcom:ConcreteTemperature</a>
    /// </summary>
    let ConcreteTemperature = _prefixId.prefix "ConcreteTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : storage condition</para>
    ///   <para>rdfs:comment : description of storage conditions</para>
    ///   <a href="https://w3id.org/bcom#Condition">bcom:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Conformity testing of compressive strength</para>
    ///   <para>rdfs:comment : This class provides information needed for performing and evaluating the conformity of concrete compressive strength.</para>
    ///   <a href="https://w3id.org/bcom#ConformityOfCompressiveStrength">bcom:ConformityOfCompressiveStrength</a>
    /// </summary>
    let ConformityOfCompressiveStrength =
        _prefixId.prefix "ConformityOfCompressiveStrength"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : conversion factor</para>
    ///   <para>rdfs:comment : conversion factor of compressive strength testing</para>
    ///   <a href="https://w3id.org/bcom#ConversionFactor">bcom:ConversionFactor</a>
    /// </summary>
    let ConversionFactor = _prefixId.prefix "ConversionFactor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : date of concreting</para>
    ///   <para>rdfs:comment : date of concreting with format year-month-day in yyyy-mm-dd</para>
    ///   <a href="https://w3id.org/bcom#DateOfConcreting">bcom:DateOfConcreting</a>
    /// </summary>
    let DateOfConcreting = _prefixId.prefix "DateOfConcreting"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : date of stripping</para>
    ///   <para>rdfs:comment : date of stripping with format year-month-day in yyyy-mm-dd</para>
    ///   <a href="https://w3id.org/bcom#DateOfStripping">bcom:DateOfStripping</a>
    /// </summary>
    let DateOfStripping = _prefixId.prefix "DateOfStripping"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : delivers concrete for</para>
    ///   <para>rdfs:comment : This property links a concrete delivery to its concrete placement activity where it was used for.</para>
    ///   <a href="https://w3id.org/bcom#DeliversConcreteFor">bcom:DeliversConcreteFor</a>
    /// </summary>
    let DeliversConcreteFor = _prefixId.prefix "DeliversConcreteFor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : delivery note</para>
    ///   <para>rdfs:comment : delivery note of mixed-ready concrete</para>
    ///   <a href="https://w3id.org/bcom#DeliveryNote">bcom:DeliveryNote</a>
    /// </summary>
    let DeliveryNote = _prefixId.prefix "DeliveryNote"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : duration</para>
    ///   <para>rdfs:comment : duration of  storage for test sample in days</para>
    ///   <a href="https://w3id.org/bcom#Duration">bcom:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : end date</para>
    ///   <para>rdfs:comment : end date of concrete curing with format year-month-day in yyyy-mm-dd</para>
    ///   <a href="https://w3id.org/bcom#EndDate">bcom:EndDate</a>
    /// </summary>
    let EndDate = _prefixId.prefix "EndDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : end time of placement</para>
    ///   <para>rdfs:comment : end time of concrete placement with format hour-minute-second in hh:mm:ss</para>
    ///   <a href="https://w3id.org/bcom#EndTimeOfPlacement">bcom:EndTimeOfPlacement</a>
    /// </summary>
    let EndTimeOfPlacement = _prefixId.prefix "EndTimeOfPlacement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : evaluation of test</para>
    ///   <para>rdfs:comment : evaluation of the mean value of the test in N/mm^2</para>
    ///   <a href="https://w3id.org/bcom#EvaluationOfTest">bcom:EvaluationOfTest</a>
    /// </summary>
    let EvaluationOfTest = _prefixId.prefix "EvaluationOfTest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : final compressive strength</para>
    ///   <para>rdfs:comment : result of the compressive strength of the respective test sample under consideration of the conversion factor in N/mm^2</para>
    ///   <a href="https://w3id.org/bcom#FinalCompressiveStrength">bcom:FinalCompressiveStrength</a>
    /// </summary>
    let FinalCompressiveStrength = _prefixId.prefix "FinalCompressiveStrength"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fresh concrete properties</para>
    ///   <para>rdfs:comment : This class represents a group of fresh concrete properties.  A fresh concrete propertyset object will usually contain density, voids ratio, consistency.</para>
    ///   <a href="https://w3id.org/bcom#FreshConcreteProperties">bcom:FreshConcreteProperties</a>
    /// </summary>
    let FreshConcreteProperties = _prefixId.prefix "FreshConcreteProperties"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : fresh concrete temperature</para>
    ///   <para>rdfs:comment : fresh concrete temperature before concrete placement in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#FreshConcreteTemperature">bcom:FreshConcreteTemperature</a>
    /// </summary>
    let FreshConcreteTemperature = _prefixId.prefix "FreshConcreteTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has concrete placement</para>
    ///   <para>rdfs:comment : This property links a concrete curing process to its concrete placement activity.</para>
    ///   <a href="https://w3id.org/bcom#HasConcretePlacement">bcom:HasConcretePlacement</a>
    /// </summary>
    let HasConcretePlacement = _prefixId.prefix "HasConcretePlacement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has curing</para>
    ///   <para>rdfs:comment : This property links a concrete placement activity to its curing process.</para>
    ///   <a href="https://w3id.org/bcom#HasCuring">bcom:HasCuring</a>
    /// </summary>
    let HasCuring = _prefixId.prefix "HasCuring"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has delivery</para>
    ///   <para>rdfs:comment : This property links a concrete placement activity to its concrete delivery providing the used concrete.</para>
    ///   <a href="https://w3id.org/bcom#HasDelivery">bcom:HasDelivery</a>
    /// </summary>
    let HasDelivery = _prefixId.prefix "HasDelivery"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has storage</para>
    ///   <para>rdfs:comment : This property links a concrete test sample to its storage details.</para>
    ///   <a href="https://w3id.org/bcom#HasStorage">bcom:HasStorage</a>
    /// </summary>
    let HasStorage = _prefixId.prefix "HasStorage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has supplier</para>
    ///   <para>rdfs:comment : This property links a concrete delivery to its supplier.</para>
    ///   <a href="https://w3id.org/bcom#HasSupplier">bcom:HasSupplier</a>
    /// </summary>
    let HasSupplier = _prefixId.prefix "HasSupplier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has test</para>
    ///   <para>rdfs:comment : This property links a concrete placement activity to its test procedure.</para>
    ///   <a href="https://w3id.org/bcom#HasTest">bcom:HasTest</a>
    /// </summary>
    let HasTest = _prefixId.prefix "HasTest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has test organisation</para>
    ///   <para>rdfs:comment : This property links a test procedure to its organization which is performing the test.</para>
    ///   <a href="https://w3id.org/bcom#HasTestOrganisation">bcom:HasTestOrganisation</a>
    /// </summary>
    let HasTestOrganisation = _prefixId.prefix "HasTestOrganisation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has test person</para>
    ///   <para>rdfs:comment : This property links a test procedure to its person who is performing the test.</para>
    ///   <a href="https://w3id.org/bcom#HasTestPerson">bcom:HasTestPerson</a>
    /// </summary>
    let HasTestPerson = _prefixId.prefix "HasTestPerson"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has test sample</para>
    ///   <para>rdfs:comment : This property links a test procedure to its test samples tested within this procedure.</para>
    ///   <a href="https://w3id.org/bcom#HasTestSample">bcom:HasTestSample</a>
    /// </summary>
    let HasTestSample = _prefixId.prefix "HasTestSample"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : height</para>
    ///   <para>rdfs:comment : height of a test sample as cube or as cylinder in mm</para>
    ///   <a href="https://w3id.org/bcom#Height">bcom:Height</a>
    /// </summary>
    let Height = _prefixId.prefix "Height"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : humidity</para>
    ///   <para>rdfs:comment : relative humidity of storage condition in %</para>
    ///   <a href="https://w3id.org/bcom#Humidity">bcom:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : intermediate compressive strength</para>
    ///   <para>rdfs:comment : intermediate result of the compressive strength of the respective sample without conversion factor of in N/mm^2</para>
    ///   <a href="https://w3id.org/bcom#InterimCompressiveStrength">bcom:InterimCompressiveStrength</a>
    /// </summary>
    let InterimCompressiveStrength = _prefixId.prefix "InterimCompressiveStrength"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is test of</para>
    ///   <para>rdfs:comment : This property links a test procedure to its concrete placement activity whithin its test samples have been concreted.</para>
    ///   <a href="https://w3id.org/bcom#IsTestOf">bcom:IsTestOf</a>
    /// </summary>
    let IsTestOf = _prefixId.prefix "IsTestOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is test organisation of</para>
    ///   <para>rdfs:comment : This property links an organization to its test procedures that have been performed by itself.</para>
    ///   <a href="https://w3id.org/bcom#IsTestOrganisationOf">bcom:IsTestOrganisationOf</a>
    /// </summary>
    let IsTestOrganisationOf = _prefixId.prefix "IsTestOrganisationOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is test person of^^xsd:string</para>
    ///   <para>rdfs:comment : This property links a test examining person to its test procedures that have been performed by itslef.</para>
    ///   <a href="https://w3id.org/bcom#IsTestPersonOf">bcom:IsTestPersonOf</a>
    /// </summary>
    let IsTestPersonOf = _prefixId.prefix "IsTestPersonOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is test sample of</para>
    ///   <para>rdfs:comment : This property links a test sample to its test procedure within which it has been tested.</para>
    ///   <a href="https://w3id.org/bcom#IsTestSampleOf">bcom:IsTestSampleOf</a>
    /// </summary>
    let IsTestSampleOf = _prefixId.prefix "IsTestSampleOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : length</para>
    ///   <para>rdfs:comment : length of a test sample for cubes in mm</para>
    ///   <a href="https://w3id.org/bcom#Length">bcom:Length</a>
    /// </summary>
    let Length = _prefixId.prefix "Length"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : maturity of concrete</para>
    ///   <para>rdfs:comment : maturity of concrete in minutes</para>
    ///   <a href="https://w3id.org/bcom#MaturityOfConcrete">bcom:MaturityOfConcrete</a>
    /// </summary>
    let MaturityOfConcrete = _prefixId.prefix "MaturityOfConcrete"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : max air temperature</para>
    ///   <para>rdfs:comment : maximum air temperature during post-treatment in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#MaxAirTemperature">bcom:MaxAirTemperature</a>
    /// </summary>
    let MaxAirTemperature = _prefixId.prefix "MaxAirTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : method of aftertreatment</para>
    ///   <para>rdfs:comment : description for the method of concrete curing</para>
    ///   <a href="https://w3id.org/bcom#MethodOfAftertreatment">bcom:MethodOfAftertreatment</a>
    /// </summary>
    let MethodOfAftertreatment = _prefixId.prefix "MethodOfAftertreatment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : min air temperature</para>
    ///   <para>rdfs:comment : minimum air temperature during post-treatment in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#MinAirTemperature">bcom:MinAirTemperature</a>
    /// </summary>
    let MinAirTemperature = _prefixId.prefix "MinAirTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : normative reference</para>
    ///   <para>rdfs:comment : norm or standard of the test method</para>
    ///   <a href="https://w3id.org/bcom#NormativeReference">bcom:NormativeReference</a>
    /// </summary>
    let NormativeReference = _prefixId.prefix "NormativeReference"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : object temperature</para>
    ///   <para>rdfs:comment : object temperature of a test sample in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#ObjectTemperature">bcom:ObjectTemperature</a>
    /// </summary>
    let ObjectTemperature = _prefixId.prefix "ObjectTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : quantity of concrete</para>
    ///   <para>rdfs:comment : quantity of the concrete placement in cubature m^3</para>
    ///   <a href="https://w3id.org/bcom#QuantityOfConcrete">bcom:QuantityOfConcrete</a>
    /// </summary>
    let QuantityOfConcrete = _prefixId.prefix "QuantityOfConcrete"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : rate of flow table test</para>
    ///   <para>rdfs:comment : rate of flow table test according to DIN EN 12350-5 in mm</para>
    ///   <a href="https://w3id.org/bcom#RateOfFlowTableTest">bcom:RateOfFlowTableTest</a>
    /// </summary>
    let RateOfFlowTableTest = _prefixId.prefix "RateOfFlowTableTest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : sample ID</para>
    ///   <para>rdfs:comment : name or ID of the test sample</para>
    ///   <a href="https://w3id.org/bcom#SampleID">bcom:SampleID</a>
    /// </summary>
    let SampleID = _prefixId.prefix "SampleID"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : sampling date</para>
    ///   <para>rdfs:comment : date of sampling with format year-month-day in yyyy-mm-dd</para>
    ///   <a href="https://w3id.org/bcom#SamplingDate">bcom:SamplingDate</a>
    /// </summary>
    let SamplingDate = _prefixId.prefix "SamplingDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Storage</para>
    ///   <para>rdfs:comment : This class represents the storage conditions of a test sample.</para>
    ///   <a href="https://w3id.org/bcom#Storage">bcom:Storage</a>
    /// </summary>
    let Storage = _prefixId.prefix "Storage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : stores sample</para>
    ///   <para>rdfs:comment : This property links storage details to its test samples that has been stored under the specific storage conditions.</para>
    ///   <a href="https://w3id.org/bcom#StoresSample">bcom:StoresSample</a>
    /// </summary>
    let StoresSample = _prefixId.prefix "StoresSample"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : supplies concrete to</para>
    ///   <para>rdfs:comment : This property links an organization to its concrete placement activities where it delivered concrete for.</para>
    ///   <a href="https://w3id.org/bcom#SuppliesConcreteTo">bcom:SuppliesConcreteTo</a>
    /// </summary>
    let SuppliesConcreteTo = _prefixId.prefix "SuppliesConcreteTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : temperature</para>
    ///   <para>rdfs:comment : storage temperature in degree Celsius</para>
    ///   <a href="https://w3id.org/bcom#Temperature">bcom:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Test</para>
    ///   <para>rdfs:comment : This class represents the super-class for different types of tests, that can be performed on placed concrete.</para>
    ///   <a href="https://w3id.org/bcom#Test">bcom:Test</a>
    /// </summary>
    let Test = _prefixId.prefix "Test"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : tested characteristic</para>
    ///   <para>rdfs:comment : the material property that has to be tested</para>
    ///   <a href="https://w3id.org/bcom#TestCharacteristic">bcom:TestCharacteristic</a>
    /// </summary>
    let TestCharacteristic = _prefixId.prefix "TestCharacteristic"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : test date</para>
    ///   <para>rdfs:comment : date of testing with format year-month-day in yyyy-mm-dd</para>
    ///   <a href="https://w3id.org/bcom#TestDate">bcom:TestDate</a>
    /// </summary>
    let TestDate = _prefixId.prefix "TestDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : test report</para>
    ///   <para>rdfs:comment : report of conformity test of concrete</para>
    ///   <a href="https://w3id.org/bcom#TestReport">bcom:TestReport</a>
    /// </summary>
    let TestReport = _prefixId.prefix "TestReport"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Test sample</para>
    ///   <para>rdfs:comment : This class provides information about test samples.</para>
    ///   <a href="https://w3id.org/bcom#TestSample">bcom:TestSample</a>
    /// </summary>
    let TestSample = _prefixId.prefix "TestSample"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : test time</para>
    ///   <para>rdfs:comment : time of testing with format hour-minute-second in hh:mm:ss</para>
    ///   <a href="https://w3id.org/bcom#TestTime">bcom:TestTime</a>
    /// </summary>
    let TestTime = _prefixId.prefix "TestTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : test type</para>
    ///   <para>rdfs:comment : type of test as self-inspection or third-party monitoring</para>
    ///   <a href="https://w3id.org/bcom#TestType">bcom:TestType</a>
    /// </summary>
    let TestType = _prefixId.prefix "TestType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : tested breaking load</para>
    ///   <para>rdfs:comment : value of breaking load of test procedure in N</para>
    ///   <a href="https://w3id.org/bcom#TestedBreakingLoad">bcom:TestedBreakingLoad</a>
    /// </summary>
    let TestedBreakingLoad = _prefixId.prefix "TestedBreakingLoad"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : tested density</para>
    ///   <para>rdfs:comment : value of density from a sample in kg/m^3</para>
    ///   <a href="https://w3id.org/bcom#TestedDensity">bcom:TestedDensity</a>
    /// </summary>
    let TestedDensity = _prefixId.prefix "TestedDensity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : voids ratio</para>
    ///   <para>rdfs:comment : voids ratio of fresh concrete in V-%</para>
    ///   <a href="https://w3id.org/bcom#VoidsRatio">bcom:VoidsRatio</a>
    /// </summary>
    let VoidsRatio = _prefixId.prefix "VoidsRatio"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : weigth</para>
    ///   <para>rdfs:comment : weigth of a test sample in kg</para>
    ///   <a href="https://w3id.org/bcom#Weigth">bcom:Weigth</a>
    /// </summary>
    let Weigth = _prefixId.prefix "Weigth"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : width or dia</para>
    ///   <para>rdfs:comment : width of a test sample as cube or diameter of a test sample as cylinder in mm</para>
    ///   <a href="https://w3id.org/bcom#WidthOrDia">bcom:WidthOrDia</a>
    /// </summary>
    let WidthOrDia = _prefixId.prefix "WidthOrDia"
