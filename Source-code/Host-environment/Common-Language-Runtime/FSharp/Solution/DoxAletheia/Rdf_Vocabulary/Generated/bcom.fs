namespace https.w3id.org.bcom.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bcom =
    let _namespace_iri = Namespace_Iri bcom |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:bcom#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/bcom#">https://w3id.org/bcom#</seealso>
    let _prefix_iri = Prefixed_Name(bcom, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#AirTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"air temperature during concreting or testing on fresh concrete in degree Celsius"</para>
    /// labels<para>"air temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#AirTemperature">https://w3id.org/bcom#AirTemperature</seealso>
    let AirTemperature = Prefixed_Name(bcom, "AirTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#BeginDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"begin date of concrete curing with format year-month-day in yyyy-mm-dd"</para>
    /// labels<para>"begin date"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#BeginDate">https://w3id.org/bcom#BeginDate</seealso>
    let BeginDate = Prefixed_Name(bcom, "BeginDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#BeginTimeOfPlacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"begin time of concrete placement with format hour-minute-second in hh:mm:ss"</para>
    /// labels<para>"begin time"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#BeginTimeOfPlacement">https://w3id.org/bcom#BeginTimeOfPlacement</seealso>
    let BeginTimeOfPlacement =
        Prefixed_Name(bcom, "BeginTimeOfPlacement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#BulkDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"bulk density of fresh concrete in kg/m^3"</para>
    /// labels<para>"bulk density"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#BulkDensity">https://w3id.org/bcom#BulkDensity</seealso>
    let BulkDensity = Prefixed_Name(bcom, "BulkDensity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#ClassOfMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"class of concrete monitoring according to DIN EN 13670 / DIN 1045-3 related to the properties of hardened concrete"</para>
    /// labels<para>"class of monitoring"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ClassOfMonitoring">https://w3id.org/bcom#ClassOfMonitoring</seealso>
    let ClassOfMonitoring = Prefixed_Name(bcom, "ClassOfMonitoring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#ConcreteCuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class provides information about the curing process after a concrete placement."</para>
    /// labels<para>"Concrete curing"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ConcreteCuring">https://w3id.org/bcom#ConcreteCuring</seealso>
    let ConcreteCuring = Prefixed_Name(bcom, "ConcreteCuring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#ConcreteDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class provides information about a concrete delivery."</para>
    /// labels<para>"Concrete delivery"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ConcreteDelivery">https://w3id.org/bcom#ConcreteDelivery</seealso>
    let ConcreteDelivery = Prefixed_Name(bcom, "ConcreteDelivery") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#ConcretePlacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class provides information about a concreting process itself."</para>
    /// labels<para>"Concrete placement"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ConcretePlacement">https://w3id.org/bcom#ConcretePlacement</seealso>
    let ConcretePlacement = Prefixed_Name(bcom, "ConcretePlacement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#ConcreteTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"fresh concrete temperature during testing of properties in degree Celsius"</para>
    /// labels<para>"fresh concrete temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ConcreteTemperature">https://w3id.org/bcom#ConcreteTemperature</seealso>
    let ConcreteTemperature = Prefixed_Name(bcom, "ConcreteTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"description of storage conditions"</para>
    /// labels<para>"storage condition"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Condition">https://w3id.org/bcom#Condition</seealso>
    let Condition = Prefixed_Name(bcom, "Condition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#ConformityOfCompressiveStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class provides information needed for performing and evaluating the conformity of concrete compressive strength."</para>
    /// labels<para>"Conformity testing of compressive strength"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ConformityOfCompressiveStrength">https://w3id.org/bcom#ConformityOfCompressiveStrength</seealso>
    let ConformityOfCompressiveStrength =
        Prefixed_Name(bcom, "ConformityOfCompressiveStrength") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#ConversionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"conversion factor of compressive strength testing"</para>
    /// labels<para>"conversion factor"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ConversionFactor">https://w3id.org/bcom#ConversionFactor</seealso>
    let ConversionFactor = Prefixed_Name(bcom, "ConversionFactor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#DateOfConcreting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"date of concreting with format year-month-day in yyyy-mm-dd"</para>
    /// labels<para>"date of concreting"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#DateOfConcreting">https://w3id.org/bcom#DateOfConcreting</seealso>
    let DateOfConcreting = Prefixed_Name(bcom, "DateOfConcreting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#DateOfStripping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"date of stripping with format year-month-day in yyyy-mm-dd"</para>
    /// labels<para>"date of stripping"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#DateOfStripping">https://w3id.org/bcom#DateOfStripping</seealso>
    let DateOfStripping = Prefixed_Name(bcom, "DateOfStripping") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#DeliversConcreteFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete delivery to its concrete placement activity where it was used for."</para>
    /// labels<para>"delivers concrete for"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#DeliversConcreteFor">https://w3id.org/bcom#DeliversConcreteFor</seealso>
    let DeliversConcreteFor = Prefixed_Name(bcom, "DeliversConcreteFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#DeliveryNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"delivery note of mixed-ready concrete"</para>
    /// labels<para>"delivery note"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#DeliveryNote">https://w3id.org/bcom#DeliveryNote</seealso>
    let DeliveryNote = Prefixed_Name(bcom, "DeliveryNote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"duration of  storage for test sample in days"</para>
    /// labels<para>"duration"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Duration">https://w3id.org/bcom#Duration</seealso>
    let Duration = Prefixed_Name(bcom, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#EndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"end date of concrete curing with format year-month-day in yyyy-mm-dd"</para>
    /// labels<para>"end date"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#EndDate">https://w3id.org/bcom#EndDate</seealso>
    let EndDate = Prefixed_Name(bcom, "EndDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#EndTimeOfPlacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"end time of concrete placement with format hour-minute-second in hh:mm:ss"</para>
    /// labels<para>"end time of placement"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#EndTimeOfPlacement">https://w3id.org/bcom#EndTimeOfPlacement</seealso>
    let EndTimeOfPlacement = Prefixed_Name(bcom, "EndTimeOfPlacement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#EvaluationOfTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"evaluation of the mean value of the test in N/mm^2"</para>
    /// labels<para>"evaluation of test"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#EvaluationOfTest">https://w3id.org/bcom#EvaluationOfTest</seealso>
    let EvaluationOfTest = Prefixed_Name(bcom, "EvaluationOfTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#FinalCompressiveStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"result of the compressive strength of the respective test sample under consideration of the conversion factor in N/mm^2"</para>
    /// labels<para>"final compressive strength"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#FinalCompressiveStrength">https://w3id.org/bcom#FinalCompressiveStrength</seealso>
    let FinalCompressiveStrength =
        Prefixed_Name(bcom, "FinalCompressiveStrength") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#FreshConcreteProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a group of fresh concrete properties.  A fresh concrete propertyset object will usually contain density, voids ratio, consistency."</para>
    /// labels<para>"Fresh concrete properties"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#FreshConcreteProperties">https://w3id.org/bcom#FreshConcreteProperties</seealso>
    let FreshConcreteProperties =
        Prefixed_Name(bcom, "FreshConcreteProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#FreshConcreteTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"fresh concrete temperature before concrete placement in degree Celsius"</para>
    /// labels<para>"fresh concrete temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#FreshConcreteTemperature">https://w3id.org/bcom#FreshConcreteTemperature</seealso>
    let FreshConcreteTemperature =
        Prefixed_Name(bcom, "FreshConcreteTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#HasConcretePlacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete curing process to its concrete placement activity."</para>
    /// labels<para>"has concrete placement"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasConcretePlacement">https://w3id.org/bcom#HasConcretePlacement</seealso>
    let HasConcretePlacement =
        Prefixed_Name(bcom, "HasConcretePlacement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#HasCuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete placement activity to its curing process."</para>
    /// labels<para>"has curing"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasCuring">https://w3id.org/bcom#HasCuring</seealso>
    let HasCuring = Prefixed_Name(bcom, "HasCuring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete placement activity to its concrete delivery providing the used concrete."</para>
    /// labels<para>"has delivery"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasDelivery">https://w3id.org/bcom#HasDelivery</seealso>
    let HasDelivery = Prefixed_Name(bcom, "HasDelivery") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete test sample to its storage details."</para>
    /// labels<para>"has storage"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasStorage">https://w3id.org/bcom#HasStorage</seealso>
    let HasStorage = Prefixed_Name(bcom, "HasStorage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete delivery to its supplier."</para>
    /// labels<para>"has supplier"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasSupplier">https://w3id.org/bcom#HasSupplier</seealso>
    let HasSupplier = Prefixed_Name(bcom, "HasSupplier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a concrete placement activity to its test procedure."</para>
    /// labels<para>"has test"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasTest">https://w3id.org/bcom#HasTest</seealso>
    let HasTest = Prefixed_Name(bcom, "HasTest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasTestOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a test procedure to its organization which is performing the test."</para>
    /// labels<para>"has test organisation"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasTestOrganisation">https://w3id.org/bcom#HasTestOrganisation</seealso>
    let HasTestOrganisation = Prefixed_Name(bcom, "HasTestOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasTestPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a test procedure to its person who is performing the test."</para>
    /// labels<para>"has test person"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasTestPerson">https://w3id.org/bcom#HasTestPerson</seealso>
    let HasTestPerson = Prefixed_Name(bcom, "HasTestPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#HasTestSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a test procedure to its test samples tested within this procedure."</para>
    /// labels<para>"has test sample"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#HasTestSample">https://w3id.org/bcom#HasTestSample</seealso>
    let HasTestSample = Prefixed_Name(bcom, "HasTestSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"height of a test sample as cube or as cylinder in mm"</para>
    /// labels<para>"height"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Height">https://w3id.org/bcom#Height</seealso>
    let Height = Prefixed_Name(bcom, "Height") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"relative humidity of storage condition in %"</para>
    /// labels<para>"humidity"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Humidity">https://w3id.org/bcom#Humidity</seealso>
    let Humidity = Prefixed_Name(bcom, "Humidity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#InterimCompressiveStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"intermediate result of the compressive strength of the respective sample without conversion factor of in N/mm^2"</para>
    /// labels<para>"intermediate compressive strength"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#InterimCompressiveStrength">https://w3id.org/bcom#InterimCompressiveStrength</seealso>
    let InterimCompressiveStrength =
        Prefixed_Name(bcom, "InterimCompressiveStrength") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#IsTestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a test procedure to its concrete placement activity whithin its test samples have been concreted."</para>
    /// labels<para>"is test of"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#IsTestOf">https://w3id.org/bcom#IsTestOf</seealso>
    let IsTestOf = Prefixed_Name(bcom, "IsTestOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#IsTestOrganisationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links an organization to its test procedures that have been performed by itself."</para>
    /// labels<para>"is test organisation of"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#IsTestOrganisationOf">https://w3id.org/bcom#IsTestOrganisationOf</seealso>
    let IsTestOrganisationOf =
        Prefixed_Name(bcom, "IsTestOrganisationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#IsTestPersonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a test examining person to its test procedures that have been performed by itslef."</para>
    /// labels<para>"is test person of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/bcom#IsTestPersonOf">https://w3id.org/bcom#IsTestPersonOf</seealso>
    let IsTestPersonOf = Prefixed_Name(bcom, "IsTestPersonOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#IsTestSampleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a test sample to its test procedure within which it has been tested."</para>
    /// labels<para>"is test sample of"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#IsTestSampleOf">https://w3id.org/bcom#IsTestSampleOf</seealso>
    let IsTestSampleOf = Prefixed_Name(bcom, "IsTestSampleOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"length of a test sample for cubes in mm"</para>
    /// labels<para>"length"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Length">https://w3id.org/bcom#Length</seealso>
    let Length = Prefixed_Name(bcom, "Length") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#MaturityOfConcrete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"maturity of concrete in minutes"</para>
    /// labels<para>"maturity of concrete"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#MaturityOfConcrete">https://w3id.org/bcom#MaturityOfConcrete</seealso>
    let MaturityOfConcrete = Prefixed_Name(bcom, "MaturityOfConcrete") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#MaxAirTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"maximum air temperature during post-treatment in degree Celsius"</para>
    /// labels<para>"max air temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#MaxAirTemperature">https://w3id.org/bcom#MaxAirTemperature</seealso>
    let MaxAirTemperature = Prefixed_Name(bcom, "MaxAirTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#MethodOfAftertreatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"description for the method of concrete curing"</para>
    /// labels<para>"method of aftertreatment"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#MethodOfAftertreatment">https://w3id.org/bcom#MethodOfAftertreatment</seealso>
    let MethodOfAftertreatment =
        Prefixed_Name(bcom, "MethodOfAftertreatment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:bcom#MinAirTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"minimum air temperature during post-treatment in degree Celsius"</para>
    /// labels<para>"min air temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#MinAirTemperature">https://w3id.org/bcom#MinAirTemperature</seealso>
    let MinAirTemperature = Prefixed_Name(bcom, "MinAirTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#NormativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"norm or standard of the test method"</para>
    /// labels<para>"normative reference"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#NormativeReference">https://w3id.org/bcom#NormativeReference</seealso>
    let NormativeReference = Prefixed_Name(bcom, "NormativeReference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#ObjectTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"object temperature of a test sample in degree Celsius"</para>
    /// labels<para>"object temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#ObjectTemperature">https://w3id.org/bcom#ObjectTemperature</seealso>
    let ObjectTemperature = Prefixed_Name(bcom, "ObjectTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#QuantityOfConcrete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"quantity of the concrete placement in cubature m^3"</para>
    /// labels<para>"quantity of concrete"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#QuantityOfConcrete">https://w3id.org/bcom#QuantityOfConcrete</seealso>
    let QuantityOfConcrete = Prefixed_Name(bcom, "QuantityOfConcrete") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#RateOfFlowTableTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"rate of flow table test according to DIN EN 12350-5 in mm"</para>
    /// labels<para>"rate of flow table test"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#RateOfFlowTableTest">https://w3id.org/bcom#RateOfFlowTableTest</seealso>
    let RateOfFlowTableTest = Prefixed_Name(bcom, "RateOfFlowTableTest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#SampleID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"name or ID of the test sample"</para>
    /// labels<para>"sample ID"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#SampleID">https://w3id.org/bcom#SampleID</seealso>
    let SampleID = Prefixed_Name(bcom, "SampleID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#SamplingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"date of sampling with format year-month-day in yyyy-mm-dd"</para>
    /// labels<para>"sampling date"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#SamplingDate">https://w3id.org/bcom#SamplingDate</seealso>
    let SamplingDate = Prefixed_Name(bcom, "SamplingDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the storage conditions of a test sample."</para>
    /// labels<para>"Storage"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Storage">https://w3id.org/bcom#Storage</seealso>
    let Storage = Prefixed_Name(bcom, "Storage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#StoresSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links storage details to its test samples that has been stored under the specific storage conditions."</para>
    /// labels<para>"stores sample"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#StoresSample">https://w3id.org/bcom#StoresSample</seealso>
    let StoresSample = Prefixed_Name(bcom, "StoresSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#SuppliesConcreteTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links an organization to its concrete placement activities where it delivered concrete for."</para>
    /// labels<para>"supplies concrete to"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#SuppliesConcreteTo">https://w3id.org/bcom#SuppliesConcreteTo</seealso>
    let SuppliesConcreteTo = Prefixed_Name(bcom, "SuppliesConcreteTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"storage temperature in degree Celsius"</para>
    /// labels<para>"temperature"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Temperature">https://w3id.org/bcom#Temperature</seealso>
    let Temperature = Prefixed_Name(bcom, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the super-class for different types of tests, that can be performed on placed concrete."</para>
    /// labels<para>"Test"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Test">https://w3id.org/bcom#Test</seealso>
    let Test = Prefixed_Name(bcom, "Test") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the material property that has to be tested"</para>
    /// labels<para>"tested characteristic"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestCharacteristic">https://w3id.org/bcom#TestCharacteristic</seealso>
    let TestCharacteristic = Prefixed_Name(bcom, "TestCharacteristic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"date of testing with format year-month-day in yyyy-mm-dd"</para>
    /// labels<para>"test date"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestDate">https://w3id.org/bcom#TestDate</seealso>
    let TestDate = Prefixed_Name(bcom, "TestDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"report of conformity test of concrete"</para>
    /// labels<para>"test report"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestReport">https://w3id.org/bcom#TestReport</seealso>
    let TestReport = Prefixed_Name(bcom, "TestReport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class provides information about test samples."</para>
    /// labels<para>"Test sample"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestSample">https://w3id.org/bcom#TestSample</seealso>
    let TestSample = Prefixed_Name(bcom, "TestSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"time of testing with format hour-minute-second in hh:mm:ss"</para>
    /// labels<para>"test time"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestTime">https://w3id.org/bcom#TestTime</seealso>
    let TestTime = Prefixed_Name(bcom, "TestTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"type of test as self-inspection or third-party monitoring"</para>
    /// labels<para>"test type"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestType">https://w3id.org/bcom#TestType</seealso>
    let TestType = Prefixed_Name(bcom, "TestType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestedBreakingLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value of breaking load of test procedure in N"</para>
    /// labels<para>"tested breaking load"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestedBreakingLoad">https://w3id.org/bcom#TestedBreakingLoad</seealso>
    let TestedBreakingLoad = Prefixed_Name(bcom, "TestedBreakingLoad") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#TestedDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value of density from a sample in kg/m^3"</para>
    /// labels<para>"tested density"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#TestedDensity">https://w3id.org/bcom#TestedDensity</seealso>
    let TestedDensity = Prefixed_Name(bcom, "TestedDensity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#VoidsRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"voids ratio of fresh concrete in V-%"</para>
    /// labels<para>"voids ratio"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#VoidsRatio">https://w3id.org/bcom#VoidsRatio</seealso>
    let VoidsRatio = Prefixed_Name(bcom, "VoidsRatio") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#Weigth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"weigth of a test sample in kg"</para>
    /// labels<para>"weigth"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#Weigth">https://w3id.org/bcom#Weigth</seealso>
    let Weigth = Prefixed_Name(bcom, "Weigth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:bcom#WidthOrDia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"width of a test sample as cube or diameter of a test sample as cylinder in mm"</para>
    /// labels<para>"width or dia"</para></remarks>
    /// <seealso href="https://w3id.org/bcom#WidthOrDia">https://w3id.org/bcom#WidthOrDia</seealso>
    let WidthOrDia = Prefixed_Name(bcom, "WidthOrDia") |> PrefixedName
