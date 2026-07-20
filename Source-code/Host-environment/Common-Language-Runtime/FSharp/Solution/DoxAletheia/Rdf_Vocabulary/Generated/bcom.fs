namespace https.w3id.org.bcom.hash

open DoxAletheia

module bcom =
    let _namespace_name = "https://w3id.org/bcom#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// air temperature during concreting or testing on fresh concrete in degree Celsius
    /// <see href="https://w3id.org/bcom#AirTemperature"></see></summary>
    let AirTemperature = _prefix "AirTemperature"
    /// <summary>
    /// This class provides information about a concreting process itself.
    /// <see href="https://w3id.org/bcom#ConcretePlacement"></see></summary>
    let ConcretePlacement = _prefix "ConcretePlacement"
    /// <summary>
    /// This class provides information about test samples.
    /// <see href="https://w3id.org/bcom#TestSample"></see></summary>
    let TestSample = _prefix "TestSample"
    /// <summary>
    /// begin date of concrete curing with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#BeginDate"></see></summary>
    let BeginDate = _prefix "BeginDate"
    /// <summary>
    /// This class provides information about the curing process after a concrete placement.
    /// <see href="https://w3id.org/bcom#ConcreteCuring"></see></summary>
    let ConcreteCuring = _prefix "ConcreteCuring"
    /// <summary>
    /// begin time of concrete placement with format hour-minute-second in hh:mm:ss
    /// <see href="https://w3id.org/bcom#BeginTimeOfPlacement"></see></summary>
    let BeginTimeOfPlacement = _prefix "BeginTimeOfPlacement"
    /// <summary>
    /// This class provides information about a concrete delivery.
    /// <see href="https://w3id.org/bcom#ConcreteDelivery"></see></summary>
    let ConcreteDelivery = _prefix "ConcreteDelivery"
    /// <summary>
    /// bulk density of fresh concrete in kg/m^3
    /// <see href="https://w3id.org/bcom#BulkDensity"></see></summary>
    let BulkDensity = _prefix "BulkDensity"
    /// <summary>
    /// This class represents a group of fresh concrete properties.  A fresh concrete propertyset object will usually contain density, voids ratio, consistency.
    /// <see href="https://w3id.org/bcom#FreshConcreteProperties"></see></summary>
    let FreshConcreteProperties = _prefix "FreshConcreteProperties"
    /// <summary>
    /// class of concrete monitoring according to DIN EN 13670 / DIN 1045-3 related to the properties of hardened concrete
    /// <see href="https://w3id.org/bcom#ClassOfMonitoring"></see></summary>
    let ClassOfMonitoring = _prefix "ClassOfMonitoring"
    /// <summary>
    /// fresh concrete temperature during testing of properties in degree Celsius
    /// <see href="https://w3id.org/bcom#ConcreteTemperature"></see></summary>
    let ConcreteTemperature = _prefix "ConcreteTemperature"
    /// <summary>
    /// description of storage conditions
    /// <see href="https://w3id.org/bcom#Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// This class represents the storage conditions of a test sample.
    /// <see href="https://w3id.org/bcom#Storage"></see></summary>
    let Storage = _prefix "Storage"
    /// <summary>
    /// This class provides information needed for performing and evaluating the conformity of concrete compressive strength.
    /// <see href="https://w3id.org/bcom#ConformityOfCompressiveStrength"></see></summary>
    let ConformityOfCompressiveStrength = _prefix "ConformityOfCompressiveStrength"
    /// <summary>
    /// This class represents the super-class for different types of tests, that can be performed on placed concrete.
    /// <see href="https://w3id.org/bcom#Test"></see></summary>
    let Test = _prefix "Test"
    /// <summary>
    /// conversion factor of compressive strength testing
    /// <see href="https://w3id.org/bcom#ConversionFactor"></see></summary>
    let ConversionFactor = _prefix "ConversionFactor"
    /// <summary>
    /// date of concreting with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#DateOfConcreting"></see></summary>
    let DateOfConcreting = _prefix "DateOfConcreting"
    /// <summary>
    /// date of stripping with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#DateOfStripping"></see></summary>
    let DateOfStripping = _prefix "DateOfStripping"
    /// <summary>
    /// This property links a concrete delivery to its concrete placement activity where it was used for.
    /// <see href="https://w3id.org/bcom#DeliversConcreteFor"></see></summary>
    let DeliversConcreteFor = _prefix "DeliversConcreteFor"
    /// <summary>
    /// This property links a concrete placement activity to its concrete delivery providing the used concrete.
    /// <see href="https://w3id.org/bcom#HasDelivery"></see></summary>
    let HasDelivery = _prefix "HasDelivery"
    /// <summary>
    /// delivery note of mixed-ready concrete
    /// <see href="https://w3id.org/bcom#DeliveryNote"></see></summary>
    let DeliveryNote = _prefix "DeliveryNote"
    /// <summary>
    /// duration of  storage for test sample in days
    /// <see href="https://w3id.org/bcom#Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// end date of concrete curing with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#EndDate"></see></summary>
    let EndDate = _prefix "EndDate"
    /// <summary>
    /// end time of concrete placement with format hour-minute-second in hh:mm:ss
    /// <see href="https://w3id.org/bcom#EndTimeOfPlacement"></see></summary>
    let EndTimeOfPlacement = _prefix "EndTimeOfPlacement"
    /// <summary>
    /// evaluation of the mean value of the test in N/mm^2
    /// <see href="https://w3id.org/bcom#EvaluationOfTest"></see></summary>
    let EvaluationOfTest = _prefix "EvaluationOfTest"
    /// <summary>
    /// result of the compressive strength of the respective test sample under consideration of the conversion factor in N/mm^2
    /// <see href="https://w3id.org/bcom#FinalCompressiveStrength"></see></summary>
    let FinalCompressiveStrength = _prefix "FinalCompressiveStrength"
    /// <summary>
    /// fresh concrete temperature before concrete placement in degree Celsius
    /// <see href="https://w3id.org/bcom#FreshConcreteTemperature"></see></summary>
    let FreshConcreteTemperature = _prefix "FreshConcreteTemperature"
    /// <summary>
    /// This property links a concrete curing process to its concrete placement activity.
    /// <see href="https://w3id.org/bcom#HasConcretePlacement"></see></summary>
    let HasConcretePlacement = _prefix "HasConcretePlacement"
    /// <summary>
    /// This property links a concrete placement activity to its curing process.
    /// <see href="https://w3id.org/bcom#HasCuring"></see></summary>
    let HasCuring = _prefix "HasCuring"
    /// <summary>
    /// This property links an organization to its concrete placement activities where it delivered concrete for.
    /// <see href="https://w3id.org/bcom#SuppliesConcreteTo"></see></summary>
    let SuppliesConcreteTo = _prefix "SuppliesConcreteTo"
    /// <summary>
    /// This property links a concrete test sample to its storage details.
    /// <see href="https://w3id.org/bcom#HasStorage"></see></summary>
    let HasStorage = _prefix "HasStorage"
    /// <summary>
    /// This property links storage details to its test samples that has been stored under the specific storage conditions.
    /// <see href="https://w3id.org/bcom#StoresSample"></see></summary>
    let StoresSample = _prefix "StoresSample"
    /// <summary>
    /// This property links a concrete delivery to its supplier.
    /// <see href="https://w3id.org/bcom#HasSupplier"></see></summary>
    let HasSupplier = _prefix "HasSupplier"
    /// <summary>
    /// This property links a concrete placement activity to its test procedure.
    /// <see href="https://w3id.org/bcom#HasTest"></see></summary>
    let HasTest = _prefix "HasTest"
    /// <summary>
    /// This property links a test procedure to its concrete placement activity whithin its test samples have been concreted.
    /// <see href="https://w3id.org/bcom#IsTestOf"></see></summary>
    let IsTestOf = _prefix "IsTestOf"
    /// <summary>
    /// This property links a test procedure to its organization which is performing the test.
    /// <see href="https://w3id.org/bcom#HasTestOrganisation"></see></summary>
    let HasTestOrganisation = _prefix "HasTestOrganisation"
    /// <summary>
    /// This property links an organization to its test procedures that have been performed by itself.
    /// <see href="https://w3id.org/bcom#IsTestOrganisationOf"></see></summary>
    let IsTestOrganisationOf = _prefix "IsTestOrganisationOf"
    /// <summary>
    /// This property links a test procedure to its person who is performing the test.
    /// <see href="https://w3id.org/bcom#HasTestPerson"></see></summary>
    let HasTestPerson = _prefix "HasTestPerson"
    /// <summary>
    /// This property links a test examining person to its test procedures that have been performed by itslef.
    /// <see href="https://w3id.org/bcom#IsTestPersonOf"></see></summary>
    let IsTestPersonOf = _prefix "IsTestPersonOf"
    /// <summary>
    /// This property links a test procedure to its test samples tested within this procedure.
    /// <see href="https://w3id.org/bcom#HasTestSample"></see></summary>
    let HasTestSample = _prefix "HasTestSample"
    /// <summary>
    /// This property links a test sample to its test procedure within which it has been tested.
    /// <see href="https://w3id.org/bcom#IsTestSampleOf"></see></summary>
    let IsTestSampleOf = _prefix "IsTestSampleOf"
    /// <summary>
    /// height of a test sample as cube or as cylinder in mm
    /// <see href="https://w3id.org/bcom#Height"></see></summary>
    let Height = _prefix "Height"
    /// <summary>
    /// relative humidity of storage condition in %
    /// <see href="https://w3id.org/bcom#Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    /// intermediate result of the compressive strength of the respective sample without conversion factor of in N/mm^2
    /// <see href="https://w3id.org/bcom#InterimCompressiveStrength"></see></summary>
    let InterimCompressiveStrength = _prefix "InterimCompressiveStrength"
    /// <summary>
    /// length of a test sample for cubes in mm
    /// <see href="https://w3id.org/bcom#Length"></see></summary>
    let Length = _prefix "Length"
    /// <summary>
    /// maturity of concrete in minutes
    /// <see href="https://w3id.org/bcom#MaturityOfConcrete"></see></summary>
    let MaturityOfConcrete = _prefix "MaturityOfConcrete"
    /// <summary>
    /// maximum air temperature during post-treatment in degree Celsius
    /// <see href="https://w3id.org/bcom#MaxAirTemperature"></see></summary>
    let MaxAirTemperature = _prefix "MaxAirTemperature"
    /// <summary>
    /// description for the method of concrete curing
    /// <see href="https://w3id.org/bcom#MethodOfAftertreatment"></see></summary>
    let MethodOfAftertreatment = _prefix "MethodOfAftertreatment"
    /// <summary>
    /// minimum air temperature during post-treatment in degree Celsius
    /// <see href="https://w3id.org/bcom#MinAirTemperature"></see></summary>
    let MinAirTemperature = _prefix "MinAirTemperature"
    /// <summary>
    /// norm or standard of the test method
    /// <see href="https://w3id.org/bcom#NormativeReference"></see></summary>
    let NormativeReference = _prefix "NormativeReference"
    /// <summary>
    /// object temperature of a test sample in degree Celsius
    /// <see href="https://w3id.org/bcom#ObjectTemperature"></see></summary>
    let ObjectTemperature = _prefix "ObjectTemperature"
    /// <summary>
    /// quantity of the concrete placement in cubature m^3
    /// <see href="https://w3id.org/bcom#QuantityOfConcrete"></see></summary>
    let QuantityOfConcrete = _prefix "QuantityOfConcrete"
    /// <summary>
    /// rate of flow table test according to DIN EN 12350-5 in mm
    /// <see href="https://w3id.org/bcom#RateOfFlowTableTest"></see></summary>
    let RateOfFlowTableTest = _prefix "RateOfFlowTableTest"
    /// <summary>
    /// name or ID of the test sample
    /// <see href="https://w3id.org/bcom#SampleID"></see></summary>
    let SampleID = _prefix "SampleID"
    /// <summary>
    /// date of sampling with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#SamplingDate"></see></summary>
    let SamplingDate = _prefix "SamplingDate"
    /// <summary>
    /// storage temperature in degree Celsius
    /// <see href="https://w3id.org/bcom#Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// the material property that has to be tested
    /// <see href="https://w3id.org/bcom#TestCharacteristic"></see></summary>
    let TestCharacteristic = _prefix "TestCharacteristic"
    /// <summary>
    /// date of testing with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#TestDate"></see></summary>
    let TestDate = _prefix "TestDate"
    /// <summary>
    /// report of conformity test of concrete
    /// <see href="https://w3id.org/bcom#TestReport"></see></summary>
    let TestReport = _prefix "TestReport"
    /// <summary>
    /// time of testing with format hour-minute-second in hh:mm:ss
    /// <see href="https://w3id.org/bcom#TestTime"></see></summary>
    let TestTime = _prefix "TestTime"
    /// <summary>
    /// type of test as self-inspection or third-party monitoring
    /// <see href="https://w3id.org/bcom#TestType"></see></summary>
    let TestType = _prefix "TestType"
    /// <summary>
    /// value of breaking load of test procedure in N
    /// <see href="https://w3id.org/bcom#TestedBreakingLoad"></see></summary>
    let TestedBreakingLoad = _prefix "TestedBreakingLoad"
    /// <summary>
    /// value of density from a sample in kg/m^3
    /// <see href="https://w3id.org/bcom#TestedDensity"></see></summary>
    let TestedDensity = _prefix "TestedDensity"
    /// <summary>
    /// voids ratio of fresh concrete in V-%
    /// <see href="https://w3id.org/bcom#VoidsRatio"></see></summary>
    let VoidsRatio = _prefix "VoidsRatio"
    /// <summary>
    /// weigth of a test sample in kg
    /// <see href="https://w3id.org/bcom#Weigth"></see></summary>
    let Weigth = _prefix "Weigth"
    /// <summary>
    /// width of a test sample as cube or diameter of a test sample as cylinder in mm
    /// <see href="https://w3id.org/bcom#WidthOrDia"></see></summary>
    let WidthOrDia = _prefix "WidthOrDia"
