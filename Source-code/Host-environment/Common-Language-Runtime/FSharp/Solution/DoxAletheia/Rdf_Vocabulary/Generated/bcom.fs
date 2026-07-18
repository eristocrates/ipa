namespace https.w3id.org.bcom.hash

open DoxAletheia.Rdf_Vocabulary

module bcom =
    let _namespace_name = "https://w3id.org/bcom#"

    /// <summary>
    /// air temperature during concreting or testing on fresh concrete in degree Celsius
    /// <see href="https://w3id.org/bcom#AirTemperature"></see></summary>
    let AirTemperature =
        Namespaced_IRI.parse _namespace_name "AirTemperature" |> NamespacedName

    /// <summary>
    /// This class provides information about a concreting process itself.
    /// <see href="https://w3id.org/bcom#ConcretePlacement"></see></summary>
    let ConcretePlacement =
        Namespaced_IRI.parse _namespace_name "ConcretePlacement" |> NamespacedName

    /// <summary>
    /// This class provides information about test samples.
    /// <see href="https://w3id.org/bcom#TestSample"></see></summary>
    let TestSample = Namespaced_IRI.parse _namespace_name "TestSample" |> NamespacedName
    /// <summary>
    /// begin date of concrete curing with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#BeginDate"></see></summary>
    let BeginDate = Namespaced_IRI.parse _namespace_name "BeginDate" |> NamespacedName

    /// <summary>
    /// This class provides information about the curing process after a concrete placement.
    /// <see href="https://w3id.org/bcom#ConcreteCuring"></see></summary>
    let ConcreteCuring =
        Namespaced_IRI.parse _namespace_name "ConcreteCuring" |> NamespacedName

    /// <summary>
    /// begin time of concrete placement with format hour-minute-second in hh:mm:ss
    /// <see href="https://w3id.org/bcom#BeginTimeOfPlacement"></see></summary>
    let BeginTimeOfPlacement =
        Namespaced_IRI.parse _namespace_name "BeginTimeOfPlacement" |> NamespacedName

    /// <summary>
    /// This class provides information about a concrete delivery.
    /// <see href="https://w3id.org/bcom#ConcreteDelivery"></see></summary>
    let ConcreteDelivery =
        Namespaced_IRI.parse _namespace_name "ConcreteDelivery" |> NamespacedName

    /// <summary>
    /// bulk density of fresh concrete in kg/m^3
    /// <see href="https://w3id.org/bcom#BulkDensity"></see></summary>
    let BulkDensity =
        Namespaced_IRI.parse _namespace_name "BulkDensity" |> NamespacedName

    /// <summary>
    /// This class represents a group of fresh concrete properties.  A fresh concrete propertyset object will usually contain density, voids ratio, consistency.
    /// <see href="https://w3id.org/bcom#FreshConcreteProperties"></see></summary>
    let FreshConcreteProperties =
        Namespaced_IRI.parse _namespace_name "FreshConcreteProperties" |> NamespacedName

    /// <summary>
    /// class of concrete monitoring according to DIN EN 13670 / DIN 1045-3 related to the properties of hardened concrete
    /// <see href="https://w3id.org/bcom#ClassOfMonitoring"></see></summary>
    let ClassOfMonitoring =
        Namespaced_IRI.parse _namespace_name "ClassOfMonitoring" |> NamespacedName

    /// <summary>
    /// fresh concrete temperature during testing of properties in degree Celsius
    /// <see href="https://w3id.org/bcom#ConcreteTemperature"></see></summary>
    let ConcreteTemperature =
        Namespaced_IRI.parse _namespace_name "ConcreteTemperature" |> NamespacedName

    /// <summary>
    /// description of storage conditions
    /// <see href="https://w3id.org/bcom#Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// This class represents the storage conditions of a test sample.
    /// <see href="https://w3id.org/bcom#Storage"></see></summary>
    let Storage = Namespaced_IRI.parse _namespace_name "Storage" |> NamespacedName

    /// <summary>
    /// This class provides information needed for performing and evaluating the conformity of concrete compressive strength.
    /// <see href="https://w3id.org/bcom#ConformityOfCompressiveStrength"></see></summary>
    let ConformityOfCompressiveStrength =
        Namespaced_IRI.parse _namespace_name "ConformityOfCompressiveStrength" |> NamespacedName

    /// <summary>
    /// This class represents the super-class for different types of tests, that can be performed on placed concrete.
    /// <see href="https://w3id.org/bcom#Test"></see></summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName

    /// <summary>
    /// conversion factor of compressive strength testing
    /// <see href="https://w3id.org/bcom#ConversionFactor"></see></summary>
    let ConversionFactor =
        Namespaced_IRI.parse _namespace_name "ConversionFactor" |> NamespacedName

    /// <summary>
    /// date of concreting with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#DateOfConcreting"></see></summary>
    let DateOfConcreting =
        Namespaced_IRI.parse _namespace_name "DateOfConcreting" |> NamespacedName

    /// <summary>
    /// date of stripping with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#DateOfStripping"></see></summary>
    let DateOfStripping =
        Namespaced_IRI.parse _namespace_name "DateOfStripping" |> NamespacedName

    /// <summary>
    /// This property links a concrete delivery to its concrete placement activity where it was used for.
    /// <see href="https://w3id.org/bcom#DeliversConcreteFor"></see></summary>
    let DeliversConcreteFor =
        Namespaced_IRI.parse _namespace_name "DeliversConcreteFor" |> NamespacedName

    /// <summary>
    /// This property links a concrete placement activity to its concrete delivery providing the used concrete.
    /// <see href="https://w3id.org/bcom#HasDelivery"></see></summary>
    let HasDelivery =
        Namespaced_IRI.parse _namespace_name "HasDelivery" |> NamespacedName

    /// <summary>
    /// delivery note of mixed-ready concrete
    /// <see href="https://w3id.org/bcom#DeliveryNote"></see></summary>
    let DeliveryNote =
        Namespaced_IRI.parse _namespace_name "DeliveryNote" |> NamespacedName

    /// <summary>
    /// duration of  storage for test sample in days
    /// <see href="https://w3id.org/bcom#Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    /// end date of concrete curing with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#EndDate"></see></summary>
    let EndDate = Namespaced_IRI.parse _namespace_name "EndDate" |> NamespacedName

    /// <summary>
    /// end time of concrete placement with format hour-minute-second in hh:mm:ss
    /// <see href="https://w3id.org/bcom#EndTimeOfPlacement"></see></summary>
    let EndTimeOfPlacement =
        Namespaced_IRI.parse _namespace_name "EndTimeOfPlacement" |> NamespacedName

    /// <summary>
    /// evaluation of the mean value of the test in N/mm^2
    /// <see href="https://w3id.org/bcom#EvaluationOfTest"></see></summary>
    let EvaluationOfTest =
        Namespaced_IRI.parse _namespace_name "EvaluationOfTest" |> NamespacedName

    /// <summary>
    /// result of the compressive strength of the respective test sample under consideration of the conversion factor in N/mm^2
    /// <see href="https://w3id.org/bcom#FinalCompressiveStrength"></see></summary>
    let FinalCompressiveStrength =
        Namespaced_IRI.parse _namespace_name "FinalCompressiveStrength" |> NamespacedName

    /// <summary>
    /// fresh concrete temperature before concrete placement in degree Celsius
    /// <see href="https://w3id.org/bcom#FreshConcreteTemperature"></see></summary>
    let FreshConcreteTemperature =
        Namespaced_IRI.parse _namespace_name "FreshConcreteTemperature" |> NamespacedName

    /// <summary>
    /// This property links a concrete curing process to its concrete placement activity.
    /// <see href="https://w3id.org/bcom#HasConcretePlacement"></see></summary>
    let HasConcretePlacement =
        Namespaced_IRI.parse _namespace_name "HasConcretePlacement" |> NamespacedName

    /// <summary>
    /// This property links a concrete placement activity to its curing process.
    /// <see href="https://w3id.org/bcom#HasCuring"></see></summary>
    let HasCuring = Namespaced_IRI.parse _namespace_name "HasCuring" |> NamespacedName

    /// <summary>
    /// This property links an organization to its concrete placement activities where it delivered concrete for.
    /// <see href="https://w3id.org/bcom#SuppliesConcreteTo"></see></summary>
    let SuppliesConcreteTo =
        Namespaced_IRI.parse _namespace_name "SuppliesConcreteTo" |> NamespacedName

    /// <summary>
    /// This property links a concrete test sample to its storage details.
    /// <see href="https://w3id.org/bcom#HasStorage"></see></summary>
    let HasStorage = Namespaced_IRI.parse _namespace_name "HasStorage" |> NamespacedName

    /// <summary>
    /// This property links storage details to its test samples that has been stored under the specific storage conditions.
    /// <see href="https://w3id.org/bcom#StoresSample"></see></summary>
    let StoresSample =
        Namespaced_IRI.parse _namespace_name "StoresSample" |> NamespacedName

    /// <summary>
    /// This property links a concrete delivery to its supplier.
    /// <see href="https://w3id.org/bcom#HasSupplier"></see></summary>
    let HasSupplier =
        Namespaced_IRI.parse _namespace_name "HasSupplier" |> NamespacedName

    /// <summary>
    /// This property links a concrete placement activity to its test procedure.
    /// <see href="https://w3id.org/bcom#HasTest"></see></summary>
    let HasTest = Namespaced_IRI.parse _namespace_name "HasTest" |> NamespacedName
    /// <summary>
    /// This property links a test procedure to its concrete placement activity whithin its test samples have been concreted.
    /// <see href="https://w3id.org/bcom#IsTestOf"></see></summary>
    let IsTestOf = Namespaced_IRI.parse _namespace_name "IsTestOf" |> NamespacedName

    /// <summary>
    /// This property links a test procedure to its organization which is performing the test.
    /// <see href="https://w3id.org/bcom#HasTestOrganisation"></see></summary>
    let HasTestOrganisation =
        Namespaced_IRI.parse _namespace_name "HasTestOrganisation" |> NamespacedName

    /// <summary>
    /// This property links an organization to its test procedures that have been performed by itself.
    /// <see href="https://w3id.org/bcom#IsTestOrganisationOf"></see></summary>
    let IsTestOrganisationOf =
        Namespaced_IRI.parse _namespace_name "IsTestOrganisationOf" |> NamespacedName

    /// <summary>
    /// This property links a test procedure to its person who is performing the test.
    /// <see href="https://w3id.org/bcom#HasTestPerson"></see></summary>
    let HasTestPerson =
        Namespaced_IRI.parse _namespace_name "HasTestPerson" |> NamespacedName

    /// <summary>
    /// This property links a test examining person to its test procedures that have been performed by itslef.
    /// <see href="https://w3id.org/bcom#IsTestPersonOf"></see></summary>
    let IsTestPersonOf =
        Namespaced_IRI.parse _namespace_name "IsTestPersonOf" |> NamespacedName

    /// <summary>
    /// This property links a test procedure to its test samples tested within this procedure.
    /// <see href="https://w3id.org/bcom#HasTestSample"></see></summary>
    let HasTestSample =
        Namespaced_IRI.parse _namespace_name "HasTestSample" |> NamespacedName

    /// <summary>
    /// This property links a test sample to its test procedure within which it has been tested.
    /// <see href="https://w3id.org/bcom#IsTestSampleOf"></see></summary>
    let IsTestSampleOf =
        Namespaced_IRI.parse _namespace_name "IsTestSampleOf" |> NamespacedName

    /// <summary>
    /// height of a test sample as cube or as cylinder in mm
    /// <see href="https://w3id.org/bcom#Height"></see></summary>
    let Height = Namespaced_IRI.parse _namespace_name "Height" |> NamespacedName
    /// <summary>
    /// relative humidity of storage condition in %
    /// <see href="https://w3id.org/bcom#Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    /// intermediate result of the compressive strength of the respective sample without conversion factor of in N/mm^2
    /// <see href="https://w3id.org/bcom#InterimCompressiveStrength"></see></summary>
    let InterimCompressiveStrength =
        Namespaced_IRI.parse _namespace_name "InterimCompressiveStrength" |> NamespacedName

    /// <summary>
    /// length of a test sample for cubes in mm
    /// <see href="https://w3id.org/bcom#Length"></see></summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName

    /// <summary>
    /// maturity of concrete in minutes
    /// <see href="https://w3id.org/bcom#MaturityOfConcrete"></see></summary>
    let MaturityOfConcrete =
        Namespaced_IRI.parse _namespace_name "MaturityOfConcrete" |> NamespacedName

    /// <summary>
    /// maximum air temperature during post-treatment in degree Celsius
    /// <see href="https://w3id.org/bcom#MaxAirTemperature"></see></summary>
    let MaxAirTemperature =
        Namespaced_IRI.parse _namespace_name "MaxAirTemperature" |> NamespacedName

    /// <summary>
    /// description for the method of concrete curing
    /// <see href="https://w3id.org/bcom#MethodOfAftertreatment"></see></summary>
    let MethodOfAftertreatment =
        Namespaced_IRI.parse _namespace_name "MethodOfAftertreatment" |> NamespacedName

    /// <summary>
    /// minimum air temperature during post-treatment in degree Celsius
    /// <see href="https://w3id.org/bcom#MinAirTemperature"></see></summary>
    let MinAirTemperature =
        Namespaced_IRI.parse _namespace_name "MinAirTemperature" |> NamespacedName

    /// <summary>
    /// norm or standard of the test method
    /// <see href="https://w3id.org/bcom#NormativeReference"></see></summary>
    let NormativeReference =
        Namespaced_IRI.parse _namespace_name "NormativeReference" |> NamespacedName

    /// <summary>
    /// object temperature of a test sample in degree Celsius
    /// <see href="https://w3id.org/bcom#ObjectTemperature"></see></summary>
    let ObjectTemperature =
        Namespaced_IRI.parse _namespace_name "ObjectTemperature" |> NamespacedName

    /// <summary>
    /// quantity of the concrete placement in cubature m^3
    /// <see href="https://w3id.org/bcom#QuantityOfConcrete"></see></summary>
    let QuantityOfConcrete =
        Namespaced_IRI.parse _namespace_name "QuantityOfConcrete" |> NamespacedName

    /// <summary>
    /// rate of flow table test according to DIN EN 12350-5 in mm
    /// <see href="https://w3id.org/bcom#RateOfFlowTableTest"></see></summary>
    let RateOfFlowTableTest =
        Namespaced_IRI.parse _namespace_name "RateOfFlowTableTest" |> NamespacedName

    /// <summary>
    /// name or ID of the test sample
    /// <see href="https://w3id.org/bcom#SampleID"></see></summary>
    let SampleID = Namespaced_IRI.parse _namespace_name "SampleID" |> NamespacedName

    /// <summary>
    /// date of sampling with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#SamplingDate"></see></summary>
    let SamplingDate =
        Namespaced_IRI.parse _namespace_name "SamplingDate" |> NamespacedName

    /// <summary>
    /// storage temperature in degree Celsius
    /// <see href="https://w3id.org/bcom#Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// the material property that has to be tested
    /// <see href="https://w3id.org/bcom#TestCharacteristic"></see></summary>
    let TestCharacteristic =
        Namespaced_IRI.parse _namespace_name "TestCharacteristic" |> NamespacedName

    /// <summary>
    /// date of testing with format year-month-day in yyyy-mm-dd
    /// <see href="https://w3id.org/bcom#TestDate"></see></summary>
    let TestDate = Namespaced_IRI.parse _namespace_name "TestDate" |> NamespacedName
    /// <summary>
    /// report of conformity test of concrete
    /// <see href="https://w3id.org/bcom#TestReport"></see></summary>
    let TestReport = Namespaced_IRI.parse _namespace_name "TestReport" |> NamespacedName
    /// <summary>
    /// time of testing with format hour-minute-second in hh:mm:ss
    /// <see href="https://w3id.org/bcom#TestTime"></see></summary>
    let TestTime = Namespaced_IRI.parse _namespace_name "TestTime" |> NamespacedName
    /// <summary>
    /// type of test as self-inspection or third-party monitoring
    /// <see href="https://w3id.org/bcom#TestType"></see></summary>
    let TestType = Namespaced_IRI.parse _namespace_name "TestType" |> NamespacedName

    /// <summary>
    /// value of breaking load of test procedure in N
    /// <see href="https://w3id.org/bcom#TestedBreakingLoad"></see></summary>
    let TestedBreakingLoad =
        Namespaced_IRI.parse _namespace_name "TestedBreakingLoad" |> NamespacedName

    /// <summary>
    /// value of density from a sample in kg/m^3
    /// <see href="https://w3id.org/bcom#TestedDensity"></see></summary>
    let TestedDensity =
        Namespaced_IRI.parse _namespace_name "TestedDensity" |> NamespacedName

    /// <summary>
    /// voids ratio of fresh concrete in V-%
    /// <see href="https://w3id.org/bcom#VoidsRatio"></see></summary>
    let VoidsRatio = Namespaced_IRI.parse _namespace_name "VoidsRatio" |> NamespacedName
    /// <summary>
    /// weigth of a test sample in kg
    /// <see href="https://w3id.org/bcom#Weigth"></see></summary>
    let Weigth = Namespaced_IRI.parse _namespace_name "Weigth" |> NamespacedName
    /// <summary>
    /// width of a test sample as cube or diameter of a test sample as cylinder in mm
    /// <see href="https://w3id.org/bcom#WidthOrDia"></see></summary>
    let WidthOrDia = Namespaced_IRI.parse _namespace_name "WidthOrDia" |> NamespacedName
