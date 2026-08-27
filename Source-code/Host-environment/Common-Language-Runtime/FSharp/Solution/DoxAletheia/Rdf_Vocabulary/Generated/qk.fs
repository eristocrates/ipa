namespace http.qudt.org.vocab.quantitykind.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qk =
    let _namespace_iri = Namespace_Iri qk |> NamespaceIRI

    /// <summary>
    ///   <para>quantitykind:/InformationContentExpressedAsALogarithmToBaseE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"information content expressed as a logarithm to base e"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBaseE">http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBaseE</seealso>
    let InformationContentExpressedAsALogarithmToBaseE =
        Prefixed_Name(qk, "InformationContentExpressedAsALogarithmToBaseE") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InformationEntropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InformationEntropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information Entropy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InformationEntropy">http://qudt.org/vocab/quantitykind/InformationEntropy</seealso>
    let InformationEntropy = Prefixed_Name(qk, "InformationEntropy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InformationFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InformationFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information flow rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InformationFlowRate">http://qudt.org/vocab/quantitykind/InformationFlowRate</seealso>
    let InformationFlowRate = Prefixed_Name(qk, "InformationFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InitialExpansionRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ExpansionRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Initial Expansion Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InitialExpansionRatio">http://qudt.org/vocab/quantitykind/InitialExpansionRatio</seealso>
    let InitialExpansionRatio =
        Prefixed_Name(qk, "InitialExpansionRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InitialNozzleThroatDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Initial Nozzle Throat Diameter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InitialNozzleThroatDiameter">http://qudt.org/vocab/quantitykind/InitialNozzleThroatDiameter</seealso>
    let InitialNozzleThroatDiameter =
        Prefixed_Name(qk, "InitialNozzleThroatDiameter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InitialVehicleMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Initial Vehicle Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InitialVehicleMass">http://qudt.org/vocab/quantitykind/InitialVehicleMass</seealso>
    let InitialVehicleMass = Prefixed_Name(qk, "InitialVehicleMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InitialVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Initial Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InitialVelocity">http://qudt.org/vocab/quantitykind/InitialVelocity</seealso>
    let InitialVelocity = Prefixed_Name(qk, "InitialVelocity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InstantaneousPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Instantaneous Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InstantaneousPower">http://qudt.org/vocab/quantitykind/InstantaneousPower</seealso>
    let InstantaneousPower = Prefixed_Name(qk, "InstantaneousPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InternalConversionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InternalConversionFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InternalConversionFactor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InternalConversionFactor">http://qudt.org/vocab/quantitykind/InternalConversionFactor</seealso>
    let InternalConversionFactor =
        Prefixed_Name(qk, "InternalConversionFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InternalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Internal Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InternalEnergy">http://qudt.org/vocab/quantitykind/InternalEnergy</seealso>
    let InternalEnergy = Prefixed_Name(qk, "InternalEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/IntinsicCarrierDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Intinsic Carrier Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IntinsicCarrierDensity">http://qudt.org/vocab/quantitykind/IntinsicCarrierDensity</seealso>
    let IntinsicCarrierDensity =
        Prefixed_Name(qk, "IntinsicCarrierDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseAmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse amount of substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseAmountOfSubstance">http://qudt.org/vocab/quantitykind/InverseAmountOfSubstance</seealso>
    let InverseAmountOfSubstance =
        Prefixed_Name(qk, "InverseAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseEnergy">http://qudt.org/vocab/quantitykind/InverseEnergy</seealso>
    let InverseEnergy = Prefixed_Name(qk, "InverseEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseEnergy_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Inverse Square Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseEnergy_Squared">http://qudt.org/vocab/quantitykind/InverseEnergy_Squared</seealso>
    let InverseEnergy_Squared =
        Prefixed_Name(qk, "InverseEnergy_Squared") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseLength">http://qudt.org/vocab/quantitykind/InverseLength</seealso>
    let InverseLength = Prefixed_Name(qk, "InverseLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseLengthTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseLengthTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Length Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseLengthTemperature">http://qudt.org/vocab/quantitykind/InverseLengthTemperature</seealso>
    let InverseLengthTemperature =
        Prefixed_Name(qk, "InverseLengthTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseMagneticFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseMagneticFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Magnetic Flux"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseMagneticFlux">http://qudt.org/vocab/quantitykind/InverseMagneticFlux</seealso>
    let InverseMagneticFlux = Prefixed_Name(qk, "InverseMagneticFlux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reciprocal mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseMass">http://qudt.org/vocab/quantitykind/InverseMass</seealso>
    let InverseMass = Prefixed_Name(qk, "InverseMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseMass_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Inverse Square Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseMass_Squared">http://qudt.org/vocab/quantitykind/InverseMass_Squared</seealso>
    let InverseMass_Squared = Prefixed_Name(qk, "InverseMass_Squared") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InversePermittivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InversePermittivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Permittivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InversePermittivity">http://qudt.org/vocab/quantitykind/InversePermittivity</seealso>
    let InversePermittivity = Prefixed_Name(qk, "InversePermittivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InversePressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InversePressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InversePressure">http://qudt.org/vocab/quantitykind/InversePressure</seealso>
    let InversePressure = Prefixed_Name(qk, "InversePressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseSquareEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseSquareEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Square Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseSquareEnergy">http://qudt.org/vocab/quantitykind/InverseSquareEnergy</seealso>
    let InverseSquareEnergy = Prefixed_Name(qk, "InverseSquareEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseSquareMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseSquareMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Square Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseSquareMass">http://qudt.org/vocab/quantitykind/InverseSquareMass</seealso>
    let InverseSquareMass = Prefixed_Name(qk, "InverseSquareMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseSquareTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseSquareTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Square Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseSquareTime">http://qudt.org/vocab/quantitykind/InverseSquareTime</seealso>
    let InverseSquareTime = Prefixed_Name(qk, "InverseSquareTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseTemperature">http://qudt.org/vocab/quantitykind/InverseTemperature</seealso>
    let InverseTemperature = Prefixed_Name(qk, "InverseTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Inverse Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseTime">http://qudt.org/vocab/quantitykind/InverseTime</seealso>
    let InverseTime = Prefixed_Name(qk, "InverseTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseTimeTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseTimeTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Time Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseTimeTemperature">http://qudt.org/vocab/quantitykind/InverseTimeTemperature</seealso>
    let InverseTimeTemperature =
        Prefixed_Name(qk, "InverseTimeTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InverseTime_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Inverse Square Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseTime_Squared">http://qudt.org/vocab/quantitykind/InverseTime_Squared</seealso>
    let InverseTime_Squared = Prefixed_Name(qk, "InverseTime_Squared") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/InverseVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InverseVolume">http://qudt.org/vocab/quantitykind/InverseVolume</seealso>
    let InverseVolume = Prefixed_Name(qk, "InverseVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ion Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonConcentration">http://qudt.org/vocab/quantitykind/IonConcentration</seealso>
    let IonConcentration = Prefixed_Name(qk, "IonConcentration") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ion Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonCurrent">http://qudt.org/vocab/quantitykind/IonCurrent</seealso>
    let IonCurrent = Prefixed_Name(qk, "IonCurrent") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ion Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonDensity">http://qudt.org/vocab/quantitykind/IonDensity</seealso>
    let IonDensity = Prefixed_Name(qk, "IonDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonTransportNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:IonTransportNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ion Transport Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonTransportNumber">http://qudt.org/vocab/quantitykind/IonTransportNumber</seealso>
    let IonTransportNumber = Prefixed_Name(qk, "IonTransportNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonicCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ionic Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonicCharge">http://qudt.org/vocab/quantitykind/IonicCharge</seealso>
    let IonicCharge = Prefixed_Name(qk, "IonicCharge") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonicStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:IonicStrength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ionic Strength"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonicStrength">http://qudt.org/vocab/quantitykind/IonicStrength</seealso>
    let IonicStrength = Prefixed_Name(qk, "IonicStrength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IonizationEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ionization Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IonizationEnergy">http://qudt.org/vocab/quantitykind/IonizationEnergy</seealso>
    let IonizationEnergy = Prefixed_Name(qk, "IonizationEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Irradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Irradiance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"熱流束"</para><para>"yoğunluk"</para><para>"éclairement énergétique"</para><para>"irradiância"</para><para>"Intenzita záření"</para><para>"پرتو افکنی/چگالی تابش"</para><para>"irradiance"</para><para>"irradianza"</para><para>"الطاقة الهلامية"</para><para>"Bestrahlungsstärke"</para><para>"Поверхностная плотность потока энергии"</para><para>"Kepenyinaran"</para><para>"辐照度"</para><para>"irradiancia"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Irradiance">http://qudt.org/vocab/quantitykind/Irradiance</seealso>
    let Irradiance = Prefixed_Name(qk, "Irradiance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/IsentropicCompressibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:IsentropicCompressibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Isentropic Compressibility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IsentropicCompressibility">http://qudt.org/vocab/quantitykind/IsentropicCompressibility</seealso>
    let IsentropicCompressibility =
        Prefixed_Name(qk, "IsentropicCompressibility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/IsentropicExponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:IsentropicExponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isentropic exponent"</para><para>"绝热指数"</para><para>"Poissonova konstanta"</para><para>"نسبة السعة الحرارية"</para><para>"Coeficiente de expansão adiabática"</para><para>"Wykładnik adiabaty"</para><para>"Isentropenexponent"</para><para>"Coeficient de transformare adiabatică"</para><para>"比熱比"</para><para>"Показатель адиабаты"</para><para>"exposant isoentropique"</para><para>"Coeficiente de dilatación adiabática"</para><para>"Coefficiente di dilatazione adiabatica"</para><para>"adiabatni eksponent"</para><para>"ısı sığası oranı; adyabatik indeks"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IsentropicExponent">http://qudt.org/vocab/quantitykind/IsentropicExponent</seealso>
    let IsentropicExponent = Prefixed_Name(qk, "IsentropicExponent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/IsothermalCompressibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:IsothermalCompressibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isotherme Kompressibilität"</para><para>"isothermal compressibility"</para><para>"معامل الانضغاط عند ثبوت درجة الحرارة"</para><para>"comprimibilità isotermica"</para><para>"compressibilité isotherme"</para><para>"изотермический коэффициент сжимаемости"</para><para>"Izotermna stisljivost"</para><para>"Ketermampatan isotermik"</para><para>"compressibilidade isotérmica"</para><para>"等温压缩率"</para><para>"ضریب تراکم‌پذیری همدما"</para><para>"ściśliwość izotermiczna"</para><para>"objemová stlačitelnost"</para><para>"等温圧縮率"</para><para>"compresibilidad isotérmica"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IsothermalCompressibility">http://qudt.org/vocab/quantitykind/IsothermalCompressibility</seealso>
    let IsothermalCompressibility =
        Prefixed_Name(qk, "IsothermalCompressibility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/IsothermalMoistureCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Isothermal Moisture Capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IsothermalMoistureCapacity">http://qudt.org/vocab/quantitykind/IsothermalMoistureCapacity</seealso>
    let IsothermalMoistureCapacity =
        Prefixed_Name(qk, "IsothermalMoistureCapacity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Kerma</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Kerma"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kerma"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Kerma">http://qudt.org/vocab/quantitykind/Kerma</seealso>
    let Kerma = Prefixed_Name(qk, "Kerma") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/KermaRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:KermaRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kerma Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/KermaRate">http://qudt.org/vocab/quantitykind/KermaRate</seealso>
    let KermaRate = Prefixed_Name(qk, "KermaRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/KinematicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:KinematicViscosity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kinematik akmazlık"</para><para>"Viscozitate cinematică"</para><para>"لزوجة"</para><para>"viscosité cinématique"</para><para>"viscosità cinematica"</para><para>"viskozita"</para><para>"кинематическую вязкость"</para><para>"粘度"</para><para>"kinematična viskoznost"</para><para>"viscosidad cinemática"</para><para>"lepkość kinematyczna"</para><para>"Kelikatan kinematik"</para><para>"运动粘度"</para><para>"kinematische Viskosität"</para><para>"گرانروی جنبشی/ویسکوزیته جنبشی"</para><para>"श्यानता"</para><para>"viscosidade cinemática"</para><para>"kinematic viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/KinematicViscosity">http://qudt.org/vocab/quantitykind/KinematicViscosity</seealso>
    let KinematicViscosity = Prefixed_Name(qk, "KinematicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"kinematic viscosity or diffusion constant or thermal diffusivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity">http://qudt.org/vocab/quantitykind/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity</seealso>
    let KinematicViscosityOrDiffusionConstantOrThermalDiffusivity =
        Prefixed_Name(qk, "KinematicViscosityOrDiffusionConstantOrThermalDiffusivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/KineticEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kinetic Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/KineticEnergy">http://qudt.org/vocab/quantitykind/KineticEnergy</seealso>
    let KineticEnergy = Prefixed_Name(qk, "KineticEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/KineticOrThermalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kinetic or thermal energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/KineticOrThermalEnergy">http://qudt.org/vocab/quantitykind/KineticOrThermalEnergy</seealso>
    let KineticOrThermalEnergy =
        Prefixed_Name(qk, "KineticOrThermalEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LagrangeFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LagrangeFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lagrange Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LagrangeFunction">http://qudt.org/vocab/quantitykind/LagrangeFunction</seealso>
    let LagrangeFunction = Prefixed_Name(qk, "LagrangeFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Landau-GinzburgNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Landau-GinzburgNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Landau-Ginzburg Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Landau-GinzburgNumber">http://qudt.org/vocab/quantitykind/Landau-GinzburgNumber</seealso>
    let Landau_GinzburgNumber =
        Prefixed_Name(qk, "Landau-GinzburgNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LandeGFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LandeGFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lande g-Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LandeGFactor">http://qudt.org/vocab/quantitykind/LandeGFactor</seealso>
    let LandeGFactor = Prefixed_Name(qk, "LandeGFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LarmorAngularFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularFrequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Larmor Angular Frequency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LarmorAngularFrequency">http://qudt.org/vocab/quantitykind/LarmorAngularFrequency</seealso>
    let LarmorAngularFrequency =
        Prefixed_Name(qk, "LarmorAngularFrequency") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LatticePlaneSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lattice Plane Spacing"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LatticePlaneSpacing">http://qudt.org/vocab/quantitykind/LatticePlaneSpacing</seealso>
    let LatticePlaneSpacing = Prefixed_Name(qk, "LatticePlaneSpacing") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LatticeVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lattice Vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LatticeVector">http://qudt.org/vocab/quantitykind/LatticeVector</seealso>
    let LatticeVector = Prefixed_Name(qk, "LatticeVector") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LeakageFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LeakageFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Leakage Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LeakageFactor">http://qudt.org/vocab/quantitykind/LeakageFactor</seealso>
    let LeakageFactor = Prefixed_Name(qk, "LeakageFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dolžina"</para><para>"Panjang"</para><para>"lunghezza"</para><para>"longueur"</para><para>"comprimento"</para><para>"Μήκος"</para><para>"długość"</para><para>"طول"</para><para>"Длина"</para><para>"Дължина"</para><para>"लम्बाई"</para><para>"lungime"</para><para>"אורך"</para><para>"uzunluk"</para><para>"length"</para><para>"longitud"</para><para>"長さ"</para><para>"Länge"</para><para>"长度"</para><para>"hossz"</para><para>"longitudo"</para><para>"Délka"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Length">http://qudt.org/vocab/quantitykind/Length</seealso>
    let Length = Prefixed_Name(qk, "Length") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LengthByForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthByForce">http://qudt.org/vocab/quantitykind/LengthByForce</seealso>
    let LengthByForce = Prefixed_Name(qk, "LengthByForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LengthEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthEnergy">http://qudt.org/vocab/quantitykind/LengthEnergy</seealso>
    let LengthEnergy = Prefixed_Name(qk, "LengthEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LengthMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthMass">http://qudt.org/vocab/quantitykind/LengthMass</seealso>
    let LengthMass = Prefixed_Name(qk, "LengthMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LengthMolarEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthMolarEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Molar Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthMolarEnergy">http://qudt.org/vocab/quantitykind/LengthMolarEnergy</seealso>
    let LengthMolarEnergy = Prefixed_Name(qk, "LengthMolarEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LengthPerElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Length per Electric Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthPerElectricCurrent">http://qudt.org/vocab/quantitykind/LengthPerElectricCurrent</seealso>
    let LengthPerElectricCurrent =
        Prefixed_Name(qk, "LengthPerElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LengthRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthRatio">http://qudt.org/vocab/quantitykind/LengthRatio</seealso>
    let LengthRatio = Prefixed_Name(qk, "LengthRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LengthTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthTemperature">http://qudt.org/vocab/quantitykind/LengthTemperature</seealso>
    let LengthTemperature = Prefixed_Name(qk, "LengthTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LengthTemperatureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthTemperatureTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length Temperature Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LengthTemperatureTime">http://qudt.org/vocab/quantitykind/LengthTemperatureTime</seealso>
    let LengthTemperatureTime =
        Prefixed_Name(qk, "LengthTemperatureTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Lethargy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Lethargy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lethargy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Lethargy">http://qudt.org/vocab/quantitykind/Lethargy</seealso>
    let Lethargy = Prefixed_Name(qk, "Lethargy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LevelWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LevelWidth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Level Width"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LevelWidth">http://qudt.org/vocab/quantitykind/LevelWidth</seealso>
    let LevelWidth = Prefixed_Name(qk, "LevelWidth") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LiftCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lift Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LiftCoefficient">http://qudt.org/vocab/quantitykind/LiftCoefficient</seealso>
    let LiftCoefficient = Prefixed_Name(qk, "LiftCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LiftForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lift Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LiftForce">http://qudt.org/vocab/quantitykind/LiftForce</seealso>
    let LiftForce = Prefixed_Name(qk, "LiftForce") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearAbsorptionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearAbsorptionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Absorption Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearAbsorptionCoefficient">http://qudt.org/vocab/quantitykind/LinearAbsorptionCoefficient</seealso>
    let LinearAbsorptionCoefficient =
        Prefixed_Name(qk, "LinearAbsorptionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearAcceleration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Acceleration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearAcceleration">http://qudt.org/vocab/quantitykind/LinearAcceleration</seealso>
    let LinearAcceleration = Prefixed_Name(qk, "LinearAcceleration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearAttenuationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearAttenuationCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Attenuation Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearAttenuationCoefficient">http://qudt.org/vocab/quantitykind/LinearAttenuationCoefficient</seealso>
    let LinearAttenuationCoefficient =
        Prefixed_Name(qk, "LinearAttenuationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearBitDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearBitDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic bit density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearBitDensity">http://qudt.org/vocab/quantitykind/LinearBitDensity</seealso>
    let LinearBitDensity = Prefixed_Name(qk, "LinearBitDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearCompressibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearCompressibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Compressibility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearCompressibility">http://qudt.org/vocab/quantitykind/LinearCompressibility</seealso>
    let LinearCompressibility =
        Prefixed_Name(qk, "LinearCompressibility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearDensity">http://qudt.org/vocab/quantitykind/LinearDensity</seealso>
    let LinearDensity = Prefixed_Name(qk, "LinearDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic electric charge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearElectricCharge">http://qudt.org/vocab/quantitykind/LinearElectricCharge</seealso>
    let LinearElectricCharge = Prefixed_Name(qk, "LinearElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Electric Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearElectricCurrent">http://qudt.org/vocab/quantitykind/LinearElectricCurrent</seealso>
    let LinearElectricCurrent =
        Prefixed_Name(qk, "LinearElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearElectricCurrentDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Electric Current Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearElectricCurrentDensity">http://qudt.org/vocab/quantitykind/LinearElectricCurrentDensity</seealso>
    let LinearElectricCurrentDensity =
        Prefixed_Name(qk, "LinearElectricCurrentDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearEnergyTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearEnergyTransfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Energy Transfer"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearEnergyTransfer">http://qudt.org/vocab/quantitykind/LinearEnergyTransfer</seealso>
    let LinearEnergyTransfer = Prefixed_Name(qk, "LinearEnergyTransfer") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearExpansionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearExpansionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"線熱膨張係数"</para><para>"coefficiente di dilatazione lineare"</para><para>"coeficiente de dilatação térmica linear"</para><para>"współczynnik liniowej rozszerzalności cieplnej"</para><para>"线性热膨胀系数"</para><para>"coefficient de dilatation linéique"</para><para>"linearer Ausdehnungskoeffizient"</para><para>"coeficiente de expansión térmica lineal"</para><para>"معدل التمدد الحراري الخطي"</para><para>"linear expansion coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearExpansionCoefficient">http://qudt.org/vocab/quantitykind/LinearExpansionCoefficient</seealso>
    let LinearExpansionCoefficient =
        Prefixed_Name(qk, "LinearExpansionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Force"</para><para>"Streckenlast"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearForce">http://qudt.org/vocab/quantitykind/LinearForce</seealso>
    let LinearForce = Prefixed_Name(qk, "LinearForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearIonization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearIonization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Ionization"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearIonization">http://qudt.org/vocab/quantitykind/LinearIonization</seealso>
    let LinearIonization = Prefixed_Name(qk, "LinearIonization") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearLogarithmicRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearLogarithmicRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic logarithmic ratio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearLogarithmicRatio">http://qudt.org/vocab/quantitykind/LinearLogarithmicRatio</seealso>
    let LinearLogarithmicRatio =
        Prefixed_Name(qk, "LinearLogarithmicRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearMass">http://qudt.org/vocab/quantitykind/LinearMass</seealso>
    let LinearMass = Prefixed_Name(qk, "LinearMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearMomentum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearMomentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Momentum"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearMomentum">http://qudt.org/vocab/quantitykind/LinearMomentum</seealso>
    let LinearMomentum = Prefixed_Name(qk, "LinearMomentum") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearPower">http://qudt.org/vocab/quantitykind/LinearPower</seealso>
    let LinearPower = Prefixed_Name(qk, "LinearPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearResistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic resistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearResistance">http://qudt.org/vocab/quantitykind/LinearResistance</seealso>
    let LinearResistance = Prefixed_Name(qk, "LinearResistance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearStiffness</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Streckenlast"</para><para>"Linear Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearStiffness">http://qudt.org/vocab/quantitykind/LinearStiffness</seealso>
    let LinearStiffness = Prefixed_Name(qk, "LinearStiffness") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearStrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LengthRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Strain"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearStrain">http://qudt.org/vocab/quantitykind/LinearStrain</seealso>
    let LinearStrain = Prefixed_Name(qk, "LinearStrain") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearThermalExpansion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearThermalExpansion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Thermal Expansion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearThermalExpansion">http://qudt.org/vocab/quantitykind/LinearThermalExpansion</seealso>
    let LinearThermalExpansion =
        Prefixed_Name(qk, "LinearThermalExpansion") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearTorque</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearTorque"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic torque"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearTorque">http://qudt.org/vocab/quantitykind/LinearTorque</seealso>
    let LinearTorque = Prefixed_Name(qk, "LinearTorque") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinearVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linear Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearVelocity">http://qudt.org/vocab/quantitykind/LinearVelocity</seealso>
    let LinearVelocity = Prefixed_Name(qk, "LinearVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LinearVoltageCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"linear voltage coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinearVoltageCoefficient">http://qudt.org/vocab/quantitykind/LinearVoltageCoefficient</seealso>
    let LinearVoltageCoefficient =
        Prefixed_Name(qk, "LinearVoltageCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LineicCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicCharge">http://qudt.org/vocab/quantitykind/LineicCharge</seealso>
    let LineicCharge = Prefixed_Name(qk, "LineicCharge") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LineicDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic data volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicDataVolume">http://qudt.org/vocab/quantitykind/LineicDataVolume</seealso>
    let LineicDataVolume = Prefixed_Name(qk, "LineicDataVolume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LineicLogarithmicRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic logarithmic ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicLogarithmicRatio">http://qudt.org/vocab/quantitykind/LineicLogarithmicRatio</seealso>
    let LineicLogarithmicRatio =
        Prefixed_Name(qk, "LineicLogarithmicRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LineicMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicMass">http://qudt.org/vocab/quantitykind/LineicMass</seealso>
    let LineicMass = Prefixed_Name(qk, "LineicMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LineicPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LineicPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicPower">http://qudt.org/vocab/quantitykind/LineicPower</seealso>
    let LineicPower = Prefixed_Name(qk, "LineicPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LineicQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic quantity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicQuantity">http://qudt.org/vocab/quantitykind/LineicQuantity</seealso>
    let LineicQuantity = Prefixed_Name(qk, "LineicQuantity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LineicResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic resistance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicResistance">http://qudt.org/vocab/quantitykind/LineicResistance</seealso>
    let LineicResistance = Prefixed_Name(qk, "LineicResistance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LineicResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LineicResolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lineic resolution"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicResolution">http://qudt.org/vocab/quantitykind/LineicResolution</seealso>
    let LineicResolution = Prefixed_Name(qk, "LineicResolution") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LineicTorque</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"lineic torque"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LineicTorque">http://qudt.org/vocab/quantitykind/LineicTorque</seealso>
    let LineicTorque = Prefixed_Name(qk, "LineicTorque") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LinkedFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linked Flux"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LinkedFlux">http://qudt.org/vocab/quantitykind/LinkedFlux</seealso>
    let LinkedFlux = Prefixed_Name(qk, "LinkedFlux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LiquidVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LiquidVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Liquid Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LiquidVolume">http://qudt.org/vocab/quantitykind/LiquidVolume</seealso>
    let LiquidVolume = Prefixed_Name(qk, "LiquidVolume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Log10FrequencyInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"logarithmic frequency interval to base 10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Log10FrequencyInterval">http://qudt.org/vocab/quantitykind/Log10FrequencyInterval</seealso>
    let Log10FrequencyInterval =
        Prefixed_Name(qk, "Log10FrequencyInterval") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Log10Ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"logarithmic ratio to base 10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Log10Ratio">http://qudt.org/vocab/quantitykind/Log10Ratio</seealso>
    let Log10Ratio = Prefixed_Name(qk, "Log10Ratio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LogERatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"logarithmic ratio to base e"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogERatio">http://qudt.org/vocab/quantitykind/LogERatio</seealso>
    let LogERatio = Prefixed_Name(qk, "LogERatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogOctanolAirPartitionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LogOctanolAirPartitionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Octanol Air Partition Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogOctanolAirPartitionCoefficient">http://qudt.org/vocab/quantitykind/LogOctanolAirPartitionCoefficient</seealso>
    let LogOctanolAirPartitionCoefficient =
        Prefixed_Name(qk, "LogOctanolAirPartitionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogOctanolWaterPartitionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LogOctanolWaterPartitionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Logarithm of Octanol Water Partition Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogOctanolWaterPartitionCoefficient">http://qudt.org/vocab/quantitykind/LogOctanolWaterPartitionCoefficient</seealso>
    let LogOctanolWaterPartitionCoefficient =
        Prefixed_Name(qk, "LogOctanolWaterPartitionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmRatioToBase10</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"logarithm ratio to base 10"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmRatioToBase10">http://qudt.org/vocab/quantitykind/LogarithmRatioToBase10</seealso>
    let LogarithmRatioToBase10 =
        Prefixed_Name(qk, "LogarithmRatioToBase10") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmRatioToBaseE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"logarithm ratio to base e"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmRatioToBaseE">http://qudt.org/vocab/quantitykind/LogarithmRatioToBaseE</seealso>
    let LogarithmRatioToBaseE =
        Prefixed_Name(qk, "LogarithmRatioToBaseE") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmicFrequencyInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LogarithmicFrequencyInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"logaritmik frekans aralığı"</para><para>"частотный интервал"</para><para>"Interval měření frekvence ?"</para><para>"logarithmic frequency interval"</para><para>"对数频率间隔"</para><para>"intervalle de fréquence logarithmique"</para><para>"Frequenzmaßintervall"</para><para>"intervallo logaritmico di frequenza"</para><para>"intervalo logarítmico de frequência"</para><para>"فاصله فرکانس لگاریتمی"</para><para>"Selang kekerapan logaritma"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmicFrequencyInterval">http://qudt.org/vocab/quantitykind/LogarithmicFrequencyInterval</seealso>
    let LogarithmicFrequencyInterval =
        Prefixed_Name(qk, "LogarithmicFrequencyInterval") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmicFrequencyIntervalToBase10</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"logarithmic frequency interval to base 10"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmicFrequencyIntervalToBase10">http://qudt.org/vocab/quantitykind/LogarithmicFrequencyIntervalToBase10</seealso>
    let LogarithmicFrequencyIntervalToBase10 =
        Prefixed_Name(qk, "LogarithmicFrequencyIntervalToBase10") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmicMedianInformationFlow_SourceToBase10</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"median information flow (from a source of information), expressed as a common logarithm "</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase10">http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase10</seealso>
    let LogarithmicMedianInformationFlow_SourceToBase10 =
        Prefixed_Name(qk, "LogarithmicMedianInformationFlow_SourceToBase10") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmicMedianInformationFlow_SourceToBase2</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"median information flow (from a source of information), expressed as a binary logarithm"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase2">http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase2</seealso>
    let LogarithmicMedianInformationFlow_SourceToBase2 =
        Prefixed_Name(qk, "LogarithmicMedianInformationFlow_SourceToBase2") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LogarithmicMedianInformationFlow_SourceToBaseE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"median information flow (from a source of information), expressed as a natural logarithm "</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBaseE">http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBaseE</seealso>
    let LogarithmicMedianInformationFlow_SourceToBaseE =
        Prefixed_Name(qk, "LogarithmicMedianInformationFlow_SourceToBaseE") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LondonPenetrationDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"London Penetration Depth"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LondonPenetrationDepth">http://qudt.org/vocab/quantitykind/LondonPenetrationDepth</seealso>
    let LondonPenetrationDepth =
        Prefixed_Name(qk, "LondonPenetrationDepth") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Long-RangeOrderParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Long-RangeOrderParameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Long-Range Order Parameter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Long-RangeOrderParameter">http://qudt.org/vocab/quantitykind/Long-RangeOrderParameter</seealso>
    let Long_RangeOrderParameter =
        Prefixed_Name(qk, "Long-RangeOrderParameter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LorenzCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LorenzCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lorenz Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LorenzCoefficient">http://qudt.org/vocab/quantitykind/LorenzCoefficient</seealso>
    let LorenzCoefficient = Prefixed_Name(qk, "LorenzCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LossAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Loss Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LossAngle">http://qudt.org/vocab/quantitykind/LossAngle</seealso>
    let LossAngle = Prefixed_Name(qk, "LossAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LossFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LossFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Loss Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LossFactor">http://qudt.org/vocab/quantitykind/LossFactor</seealso>
    let LossFactor = Prefixed_Name(qk, "LossFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Loudness</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"loudness"</para><para>"loudness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Loudness">http://qudt.org/vocab/quantitykind/Loudness</seealso>
    let Loudness = Prefixed_Name(qk, "Loudness") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LoudnessLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"loudness level"</para><para>"loudness level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LoudnessLevel">http://qudt.org/vocab/quantitykind/LoudnessLevel</seealso>
    let LoudnessLevel = Prefixed_Name(qk, "LoudnessLevel") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LowerCriticalMagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lower Critical Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LowerCriticalMagneticFluxDensity">http://qudt.org/vocab/quantitykind/LowerCriticalMagneticFluxDensity</seealso>
    let LowerCriticalMagneticFluxDensity =
        Prefixed_Name(qk, "LowerCriticalMagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Luminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Luminance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Luminance">http://qudt.org/vocab/quantitykind/Luminance</seealso>
    let Luminance = Prefixed_Name(qk, "Luminance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousEfficacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminous Efficacy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousEfficacy">http://qudt.org/vocab/quantitykind/LuminousEfficacy</seealso>
    let LuminousEfficacy = Prefixed_Name(qk, "LuminousEfficacy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousEmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFluxPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminous Emmitance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousEmittance">http://qudt.org/vocab/quantitykind/LuminousEmittance</seealso>
    let LuminousEmittance = Prefixed_Name(qk, "LuminousEmittance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminous Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousEnergy">http://qudt.org/vocab/quantitykind/LuminousEnergy</seealso>
    let LuminousEnergy = Prefixed_Name(qk, "LuminousEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousExitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFluxPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luminous exitance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousExitance">http://qudt.org/vocab/quantitykind/LuminousExitance</seealso>
    let LuminousExitance = Prefixed_Name(qk, "LuminousExitance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousExposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousExposure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminous Exposure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousExposure">http://qudt.org/vocab/quantitykind/LuminousExposure</seealso>
    let LuminousExposure = Prefixed_Name(qk, "LuminousExposure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"strumień świetlny"</para><para>"fluxo luminoso"</para><para>"işık akısı"</para><para>"flux lumineux"</para><para>"fluctús lucis"</para><para>"svetlobni tok"</para><para>"شار نوری"</para><para>"Světelný tok"</para><para>"Светлинен поток"</para><para>"flujo luminoso"</para><para>"fényáram"</para><para>"flux luminos"</para><para>"Световой поток"</para><para>"Lichtstrom"</para><para>"光通量"</para><para>"flusso luminoso"</para><para>"luminous flux"</para><para>"التدفق الضوئي"</para><para>"Fluks berluminositi"</para><para>"प्रकाशीय बहाव"</para><para>"שטף הארה"</para><para>"光束"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousFlux">http://qudt.org/vocab/quantitykind/LuminousFlux</seealso>
    let LuminousFlux = Prefixed_Name(qk, "LuminousFlux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousFluxPerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFluxPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminous Flux per Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousFluxPerArea">http://qudt.org/vocab/quantitykind/LuminousFluxPerArea</seealso>
    let LuminousFluxPerArea = Prefixed_Name(qk, "LuminousFluxPerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousFluxRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFluxRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luminous Flux Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousFluxRatio">http://qudt.org/vocab/quantitykind/LuminousFluxRatio</seealso>
    let LuminousFluxRatio = Prefixed_Name(qk, "LuminousFluxRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/LuminousIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousIntensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"شدة الإضاءة"</para><para>"intensité lumineuse"</para><para>"ışık şiddeti"</para><para>"Lichtstärke"</para><para>"intensitas luminosa"</para><para>"intensidade luminosa"</para><para>"Keamatan berluminositi"</para><para>"fényerősség"</para><para>"światłość"</para><para>"شدت نور"</para><para>"Svítivost"</para><para>"intensidad luminosa"</para><para>"Ένταση Φωτεινότητας"</para><para>"发光强度"</para><para>"光度"</para><para>"intensità luminosa"</para><para>"प्रकाशीय तीव्रता"</para><para>"Интензитет на светлината"</para><para>"Сила света"</para><para>"svetilnost"</para><para>"intensitate luminoasă"</para><para>"luminous intensity"</para><para>"עוצמת הארה"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousIntensity">http://qudt.org/vocab/quantitykind/LuminousIntensity</seealso>
    let LuminousIntensity = Prefixed_Name(qk, "LuminousIntensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/LuminousIntensityDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousIntensityDistribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ion Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/LuminousIntensityDistribution">http://qudt.org/vocab/quantitykind/LuminousIntensityDistribution</seealso>
    let LuminousIntensityDistribution =
        Prefixed_Name(qk, "LuminousIntensityDistribution") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MASS-DELIVERED</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Delivered"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MASS-DELIVERED">http://qudt.org/vocab/quantitykind/MASS-DELIVERED</seealso>
    let MASS_DELIVERED = Prefixed_Name(qk, "MASS-DELIVERED") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MASS-GROWTH-ALLOWANCE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Growth Allowance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MASS-GROWTH-ALLOWANCE">http://qudt.org/vocab/quantitykind/MASS-GROWTH-ALLOWANCE</seealso>
    let MASS_GROWTH_ALLOWANCE =
        Prefixed_Name(qk, "MASS-GROWTH-ALLOWANCE") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MASS-MARGIN</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Margin"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MASS-MARGIN">http://qudt.org/vocab/quantitykind/MASS-MARGIN</seealso>
    let MASS_MARGIN = Prefixed_Name(qk, "MASS-MARGIN") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MASS-PROPERTY-UNCERTAINTY</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Property Uncertainty"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MASS-PROPERTY-UNCERTAINTY">http://qudt.org/vocab/quantitykind/MASS-PROPERTY-UNCERTAINTY</seealso>
    let MASS_PROPERTY_UNCERTAINTY =
        Prefixed_Name(qk, "MASS-PROPERTY-UNCERTAINTY") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MOMENT-OF-INERTIA_Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moment of Inertia in the Y axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Y">http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Y</seealso>
    let MOMENT_OF_INERTIA_Y = Prefixed_Name(qk, "MOMENT-OF-INERTIA_Y") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MOMENT-OF-INERTIA_Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moment of Inertia in the Z axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Z">http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Z</seealso>
    let MOMENT_OF_INERTIA_Z = Prefixed_Name(qk, "MOMENT-OF-INERTIA_Z") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MachNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MachNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"马赫"</para><para>"عدد ماخ"</para><para>"मैक संख्या"</para><para>"マッハ数n"</para><para>"nombre de Mach"</para><para>"numero di Mach"</para><para>"liczba Macha"</para><para>"Machovo číslo"</para><para>"Mach-Zahl"</para><para>"Nombor Mach"</para><para>"número de Mach"</para><para>"Machovo število"</para><para>"Mach sayısı"</para><para>"număr Mach"</para><para>"Mach number"</para><para>"число Маха"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MachNumber">http://qudt.org/vocab/quantitykind/MachNumber</seealso>
    let MachNumber = Prefixed_Name(qk, "MachNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MacroscopicCrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Macroscopic Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MacroscopicCrossSection">http://qudt.org/vocab/quantitykind/MacroscopicCrossSection</seealso>
    let MacroscopicCrossSection =
        Prefixed_Name(qk, "MacroscopicCrossSection") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MacroscopicTotalCrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Macroscopic Total Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MacroscopicTotalCrossSection">http://qudt.org/vocab/quantitykind/MacroscopicTotalCrossSection</seealso>
    let MacroscopicTotalCrossSection =
        Prefixed_Name(qk, "MacroscopicTotalCrossSection") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MadelungConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MadelungConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Costante di Madelung"</para><para>"Stała Madelunga"</para><para>"постоянная Маделунга"</para><para>"ثابت مادلونك"</para><para>"Madelung-Konstante"</para><para>"マーデルングエネルギー"</para><para>"Constante de Madelung"</para><para>"Madelung constant"</para><para>"ثابت مادلونگ"</para><para>"馬德隆常數"</para><para>"constante de Madelung"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MadelungConstant">http://qudt.org/vocab/quantitykind/MadelungConstant</seealso>
    let MadelungConstant = Prefixed_Name(qk, "MadelungConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MagneticAreaMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticAreaMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Area Moment"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticAreaMoment">http://qudt.org/vocab/quantitykind/MagneticAreaMoment</seealso>
    let MagneticAreaMoment = Prefixed_Name(qk, "MagneticAreaMoment") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MagneticDipoleMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticDipoleMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Dipole Moment"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticDipoleMoment">http://qudt.org/vocab/quantitykind/MagneticDipoleMoment</seealso>
    let MagneticDipoleMoment = Prefixed_Name(qk, "MagneticDipoleMoment") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticDipoleMomentOfAMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"magnetic dipole moment of a molecule"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticDipoleMomentOfAMolecule">http://qudt.org/vocab/quantitykind/MagneticDipoleMomentOfAMolecule</seealso>
    let MagneticDipoleMomentOfAMolecule =
        Prefixed_Name(qk, "MagneticDipoleMomentOfAMolecule") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticField</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticField"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Field"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticField">http://qudt.org/vocab/quantitykind/MagneticField</seealso>
    let MagneticField = Prefixed_Name(qk, "MagneticField") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticFieldStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFieldStrength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"magnetic field strength"</para><para>"pole magnetyczne"</para><para>"شدت میدان مغناطیسی"</para><para>"磁場"</para><para>"jakost magnetnega polja"</para><para>"Магнитное поле"</para><para>"Câmp magnetic"</para><para>"حقل مغناطيسي"</para><para>"intensità di campo magnetico"</para><para>"Kekuatan medan magnetik"</para><para>"intensidade de campo magnético"</para><para>"Manyetik alan"</para><para>"intensité de champ magnétique"</para><para>"Magnetické pole"</para><para>"magnetische Feldstärke"</para><para>"intensidad de campo magnético"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticFieldStrength">http://qudt.org/vocab/quantitykind/MagneticFieldStrength</seealso>
    let MagneticFieldStrength =
        Prefixed_Name(qk, "MagneticFieldStrength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticFieldStrength_H</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pole magnetyczne"</para><para>"شدت میدان مغناطیسی"</para><para>"Câmp magnetic"</para><para>"magnetische Feldstärke"</para><para>"intensidade de campo magnético"</para><para>"Magnetické pole"</para><para>"Kekuatan medan magnetik"</para><para>"intensità di campo magnetico"</para><para>"intensité de champ magnétique"</para><para>"magnetic field strength"</para><para>"Manyetik alan"</para><para>"jakost magnetnega polja"</para><para>"حقل مغناطيسي"</para><para>"intensidad de campo magnético"</para><para>"Магнитное поле"</para><para>"磁場"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticFieldStrength_H">http://qudt.org/vocab/quantitykind/MagneticFieldStrength_H</seealso>
    let MagneticFieldStrength_H =
        Prefixed_Name(qk, "MagneticFieldStrength_H") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fluxo magnético"</para><para>"Магнитен поток"</para><para>"Магнитный поток"</para><para>"mágneses fluxus"</para><para>"strumień magnetyczny"</para><para>"磁束"</para><para>"flux de inducție magnetică"</para><para>"Flux d'induction magnétique"</para><para>"fluxus magneticus"</para><para>"flujo magnético"</para><para>"磁通量"</para><para>"التدفق المغناطيسي"</para><para>"שטף מגנטי"</para><para>"flusso magnetico"</para><para>"Magnetický tok"</para><para>"magnetic flux"</para><para>"Fluks magnet"</para><para>"चुम्बकीय बहाव"</para><para>"شار مغناطیسی"</para><para>"magnetischer Flux"</para><para>"manyetik akı"</para><para>"magnetni pretok"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticFlux">http://qudt.org/vocab/quantitykind/MagneticFlux</seealso>
    let MagneticFlux = Prefixed_Name(qk, "MagneticFlux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Магнитна индукция"</para><para>"magnetic flux density"</para><para>"磁通量密度"</para><para>"磁束密度"</para><para>"Ketumpatan fluks magnet"</para><para>"inducție magnetică"</para><para>"צפיפות שטף מגנטי"</para><para>"المجال المغناطيسي"</para><para>"densitas fluxus magnetici"</para><para>"densità di flusso magnetico"</para><para>"magnetische Flussdichte"</para><para>"Магнитная индукция"</para><para>"چگالی شار مغناطیسی"</para><para>"mágneses indukció"</para><para>"Densidad de flujo magnético"</para><para>"चुम्बकीय क्षेत्र"</para><para>"densidade de fluxo magnético"</para><para>"Magnetická indukce"</para><para>"indukcja magnetyczna"</para><para>"Densité de flux magnétique"</para><para>"manyetik akı yoğunluğu"</para><para>"gostota magnetnega pretoka"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticFluxDensity">http://qudt.org/vocab/quantitykind/MagneticFluxDensity</seealso>
    let MagneticFluxDensity = Prefixed_Name(qk, "MagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticFluxDensityOrMagneticPolarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"magnetic flux density or magnetic polarization"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticFluxDensityOrMagneticPolarization">http://qudt.org/vocab/quantitykind/MagneticFluxDensityOrMagneticPolarization</seealso>
    let MagneticFluxDensityOrMagneticPolarization =
        Prefixed_Name(qk, "MagneticFluxDensityOrMagneticPolarization") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticFluxPerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFluxPerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic flux per length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticFluxPerLength">http://qudt.org/vocab/quantitykind/MagneticFluxPerLength</seealso>
    let MagneticFluxPerLength =
        Prefixed_Name(qk, "MagneticFluxPerLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"magnetic moment"</para><para>"moment magnétique"</para><para>"Manyetik moment"</para><para>"Магнитный момент"</para><para>"دوقطبی مغناطیسی"</para><para>"momento di dipolo magnetico"</para><para>"磁気双極子"</para><para>"磁偶极"</para><para>"dipol magnetyczny"</para><para>"चुम्बकीय द्विध्रुव"</para><para>"momento de dipolo magnético"</para><para>"عزم مغناطيسي"</para><para>"magnetisches Dipolmoment"</para><para>"Magnetický dipól"</para><para>"Momen magnetik"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticMoment">http://qudt.org/vocab/quantitykind/MagneticMoment</seealso>
    let MagneticMoment = Prefixed_Name(qk, "MagneticMoment") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MagneticPolarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Magnetic Polarization"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticPolarization">http://qudt.org/vocab/quantitykind/MagneticPolarization</seealso>
    let MagneticPolarization = Prefixed_Name(qk, "MagneticPolarization") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticQuantumNumber">http://qudt.org/vocab/quantitykind/MagneticQuantumNumber</seealso>
    let MagneticQuantumNumber =
        Prefixed_Name(qk, "MagneticQuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticReluctivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticReluctivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Reluctivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticReluctivity">http://qudt.org/vocab/quantitykind/MagneticReluctivity</seealso>
    let MagneticReluctivity = Prefixed_Name(qk, "MagneticReluctivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticSusceptability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticSusceptability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Susceptability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticSusceptability">http://qudt.org/vocab/quantitykind/MagneticSusceptability</seealso>
    let MagneticSusceptability =
        Prefixed_Name(qk, "MagneticSusceptability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticTension</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticTension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetic Tension"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticTension">http://qudt.org/vocab/quantitykind/MagneticTension</seealso>
    let MagneticTension = Prefixed_Name(qk, "MagneticTension") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MagneticVectorPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticVectorPotential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"پتانسیل برداری مغناطیسی"</para><para>"Keupayaan vektor magnetik"</para><para>"potencial magnético"</para><para>"magnetisches Potenzial"</para><para>"potentiel magnétique"</para><para>"magnetický potenciál"</para><para>"potențial magnetic"</para><para>"potenziale vettore magnetico"</para><para>"Магнитний потенциал"</para><para>"manyetik potansiyeli"</para><para>"potencjał magnetyczny"</para><para>"magnetic vector potential"</para><para>"磁向量势"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagneticVectorPotential">http://qudt.org/vocab/quantitykind/MagneticVectorPotential</seealso>
    let MagneticVectorPotential =
        Prefixed_Name(qk, "MagneticVectorPotential") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Magnetization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"magnetización"</para><para>"磁化"</para><para>"намагниченность"</para><para>"magnetyzacia"</para><para>"magnetization"</para><para>"مغنطة"</para><para>"aimantation"</para><para>"magnetização"</para><para>"Magnetisierung"</para><para>"magnetizzazione"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Magnetization">http://qudt.org/vocab/quantitykind/Magnetization</seealso>
    let Magnetization = Prefixed_Name(qk, "Magnetization") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MagnetizationField</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetization Field"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagnetizationField">http://qudt.org/vocab/quantitykind/MagnetizationField</seealso>
    let MagnetizationField = Prefixed_Name(qk, "MagnetizationField") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MagnetomotiveForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagnetomotiveForce"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnetomotive Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MagnetomotiveForce">http://qudt.org/vocab/quantitykind/MagnetomotiveForce</seealso>
    let MagnetomotiveForce = Prefixed_Name(qk, "MagnetomotiveForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"质量"</para><para>"Масса"</para><para>"tömeg"</para><para>"masse"</para><para>"Μάζα"</para><para>"masa"</para><para>"Jisim"</para><para>"جرم"</para><para>"מסה"</para><para>"Masse"</para><para>"massa"</para><para>"كتلة"</para><para>"Маса"</para><para>"Hmotnost"</para><para>"質量"</para><para>"kütle"</para><para>"mass"</para><para>"masă"</para><para>"भार"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Mass">http://qudt.org/vocab/quantitykind/Mass</seealso>
    let Mass = Prefixed_Name(qk, "Mass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassAbsorptionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassAbsorptionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Absorption Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassAbsorptionCoefficient">http://qudt.org/vocab/quantitykind/MassAbsorptionCoefficient</seealso>
    let MassAbsorptionCoefficient =
        Prefixed_Name(qk, "MassAbsorptionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Mass Amount of Substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassAmountOfSubstance">http://qudt.org/vocab/quantitykind/MassAmountOfSubstance</seealso>
    let MassAmountOfSubstance =
        Prefixed_Name(qk, "MassAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassAmountOfSubstanceTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassAmountOfSubstanceTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Amount of Substance Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassAmountOfSubstanceTemperature">http://qudt.org/vocab/quantitykind/MassAmountOfSubstanceTemperature</seealso>
    let MassAmountOfSubstanceTemperature =
        Prefixed_Name(qk, "MassAmountOfSubstanceTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassAttenuationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassAttenuationCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Attenuation Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassAttenuationCoefficient">http://qudt.org/vocab/quantitykind/MassAttenuationCoefficient</seealso>
    let MassAttenuationCoefficient =
        Prefixed_Name(qk, "MassAttenuationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassBasedBloodGlucoseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassBasedBloodGlucoseLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Blood Glucose Level by Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassBasedBloodGlucoseLevel">http://qudt.org/vocab/quantitykind/MassBasedBloodGlucoseLevel</seealso>
    let MassBasedBloodGlucoseLevel =
        Prefixed_Name(qk, "MassBasedBloodGlucoseLevel") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassConcentration">http://qudt.org/vocab/quantitykind/MassConcentration</seealso>
    let MassConcentration = Prefixed_Name(qk, "MassConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassConcentrationOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassConcentrationOfWater"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Concentration of Water"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassConcentrationOfWater">http://qudt.org/vocab/quantitykind/MassConcentrationOfWater</seealso>
    let MassConcentrationOfWater =
        Prefixed_Name(qk, "MassConcentrationOfWater") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassConcentrationOfWaterVapour</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassConcentrationOfWaterVapour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Concentration of Water Vapour"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassConcentrationOfWaterVapour">http://qudt.org/vocab/quantitykind/MassConcentrationOfWaterVapour</seealso>
    let MassConcentrationOfWaterVapour =
        Prefixed_Name(qk, "MassConcentrationOfWaterVapour") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassConcentrationRateOfChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassConcentrationRateOfChange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Concentration Rate Of Change"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassConcentrationRateOfChange">http://qudt.org/vocab/quantitykind/MassConcentrationRateOfChange</seealso>
    let MassConcentrationRateOfChange =
        Prefixed_Name(qk, "MassConcentrationRateOfChange") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassDefect</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Defect"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassDefect">http://qudt.org/vocab/quantitykind/MassDefect</seealso>
    let MassDefect = Prefixed_Name(qk, "MassDefect") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"چگالی"</para><para>"yoğunluk"</para><para>"Ketumpatan jisim"</para><para>"密度"</para><para>"hustota"</para><para>"gęstość"</para><para>"mass density"</para><para>"densidad"</para><para>"densità"</para><para>"Gostôta"</para><para>"densidade"</para><para>"الكثافة"</para><para>"плотность"</para><para>"densitate"</para><para>"घनत्व"</para><para>"Massendichte"</para><para>"densité"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassDensity">http://qudt.org/vocab/quantitykind/MassDensity</seealso>
    let MassDensity = Prefixed_Name(qk, "MassDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassEnergyTransferCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassEnergyTransferCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Energy Transfer Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassEnergyTransferCoefficient">http://qudt.org/vocab/quantitykind/MassEnergyTransferCoefficient</seealso>
    let MassEnergyTransferCoefficient =
        Prefixed_Name(qk, "MassEnergyTransferCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Equivalent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassEquivalent">http://qudt.org/vocab/quantitykind/MassEquivalent</seealso>
    let MassEquivalent = Prefixed_Name(qk, "MassEquivalent") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassExcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Excess"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassExcess">http://qudt.org/vocab/quantitykind/MassExcess</seealso>
    let MassExcess = Prefixed_Name(qk, "MassExcess") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Flow Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassFlowRate">http://qudt.org/vocab/quantitykind/MassFlowRate</seealso>
    let MassFlowRate = Prefixed_Name(qk, "MassFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerAreaTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mass flux density"</para><para>"mass flux density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassFluxDensity">http://qudt.org/vocab/quantitykind/MassFluxDensity</seealso>
    let MassFluxDensity = Prefixed_Name(qk, "MassFluxDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassFraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Fraction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassFraction">http://qudt.org/vocab/quantitykind/MassFraction</seealso>
    let MassFraction = Prefixed_Name(qk, "MassFraction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassFractionOfDryMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassFractionOfDryMatter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Fraction of Dry Matter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassFractionOfDryMatter">http://qudt.org/vocab/quantitykind/MassFractionOfDryMatter</seealso>
    let MassFractionOfDryMatter =
        Prefixed_Name(qk, "MassFractionOfDryMatter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassFractionOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassFractionOfWater"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Fraction of Water"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassFractionOfWater">http://qudt.org/vocab/quantitykind/MassFractionOfWater</seealso>
    let MassFractionOfWater = Prefixed_Name(qk, "MassFractionOfWater") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassNumber">http://qudt.org/vocab/quantitykind/MassNumber</seealso>
    let MassNumber = Prefixed_Name(qk, "MassNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassOfElectricalPowerSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Of Electrical Power Supply"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassOfElectricalPowerSupply">http://qudt.org/vocab/quantitykind/MassOfElectricalPowerSupply</seealso>
    let MassOfElectricalPowerSupply =
        Prefixed_Name(qk, "MassOfElectricalPowerSupply") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassOfSolidBooster</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Of Solid Booster"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassOfSolidBooster">http://qudt.org/vocab/quantitykind/MassOfSolidBooster</seealso>
    let MassOfSolidBooster = Prefixed_Name(qk, "MassOfSolidBooster") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassOfTheEarth</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Of The Earth"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassOfTheEarth">http://qudt.org/vocab/quantitykind/MassOfTheEarth</seealso>
    let MassOfTheEarth = Prefixed_Name(qk, "MassOfTheEarth") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassPerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass per Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassPerArea">http://qudt.org/vocab/quantitykind/MassPerArea</seealso>
    let MassPerArea = Prefixed_Name(qk, "MassPerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassPerAreaTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerAreaTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass per Area Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassPerAreaTime">http://qudt.org/vocab/quantitykind/MassPerAreaTime</seealso>
    let MassPerAreaTime = Prefixed_Name(qk, "MassPerAreaTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassPerElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass per Electric Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassPerElectricCharge">http://qudt.org/vocab/quantitykind/MassPerElectricCharge</seealso>
    let MassPerElectricCharge =
        Prefixed_Name(qk, "MassPerElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassPerEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass per Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassPerEnergy">http://qudt.org/vocab/quantitykind/MassPerEnergy</seealso>
    let MassPerEnergy = Prefixed_Name(qk, "MassPerEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassPerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass per Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassPerLength">http://qudt.org/vocab/quantitykind/MassPerLength</seealso>
    let MassPerLength = Prefixed_Name(qk, "MassPerLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassPerTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass per Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassPerTime">http://qudt.org/vocab/quantitykind/MassPerTime</seealso>
    let MassPerTime = Prefixed_Name(qk, "MassPerTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassRatio">http://qudt.org/vocab/quantitykind/MassRatio</seealso>
    let MassRatio = Prefixed_Name(qk, "MassRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassRatioOfWaterToDryMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassRatioOfWaterToDryMatter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Concentration of Water To Dry Matter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassRatioOfWaterToDryMatter">http://qudt.org/vocab/quantitykind/MassRatioOfWaterToDryMatter</seealso>
    let MassRatioOfWaterToDryMatter =
        Prefixed_Name(qk, "MassRatioOfWaterToDryMatter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassRatioOfWaterVapourToDryGas</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassRatioOfWaterVapourToDryGas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Ratio of Water Vapour to Dry Gas"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassRatioOfWaterVapourToDryGas">http://qudt.org/vocab/quantitykind/MassRatioOfWaterVapourToDryGas</seealso>
    let MassRatioOfWaterVapourToDryGas =
        Prefixed_Name(qk, "MassRatioOfWaterVapourToDryGas") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassRelatedElectricalCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"mass-related electrical current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassRelatedElectricalCurrent">http://qudt.org/vocab/quantitykind/MassRelatedElectricalCurrent</seealso>
    let MassRelatedElectricalCurrent =
        Prefixed_Name(qk, "MassRelatedElectricalCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassSpecificBiogeochemicalRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassSpecificBiogeochemicalRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Specific Biogeochemical Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassSpecificBiogeochemicalRate">http://qudt.org/vocab/quantitykind/MassSpecificBiogeochemicalRate</seealso>
    let MassSpecificBiogeochemicalRate =
        Prefixed_Name(qk, "MassSpecificBiogeochemicalRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassStoppingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassStoppingPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mass stopping power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassStoppingPower">http://qudt.org/vocab/quantitykind/MassStoppingPower</seealso>
    let MassStoppingPower = Prefixed_Name(qk, "MassStoppingPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassTemperature">http://qudt.org/vocab/quantitykind/MassTemperature</seealso>
    let MassTemperature = Prefixed_Name(qk, "MassTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassicActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassicActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Massic Activity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassicActivity">http://qudt.org/vocab/quantitykind/MassicActivity</seealso>
    let MassicActivity = Prefixed_Name(qk, "MassicActivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassicElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassicElectricCurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"massic electric current"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassicElectricCurrent">http://qudt.org/vocab/quantitykind/MassicElectricCurrent</seealso>
    let MassicElectricCurrent =
        Prefixed_Name(qk, "MassicElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MassicHeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassicHeatCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"massic heat capacity"</para><para>"massic heat capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassicHeatCapacity">http://qudt.org/vocab/quantitykind/MassicHeatCapacity</seealso>
    let MassicHeatCapacity = Prefixed_Name(qk, "MassicHeatCapacity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassicPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"massic power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"massic power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassicPower">http://qudt.org/vocab/quantitykind/MassicPower</seealso>
    let MassicPower = Prefixed_Name(qk, "MassicPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassicTorque</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"massic torque"</para><para>"massic torque"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassicTorque">http://qudt.org/vocab/quantitykind/MassicTorque</seealso>
    let MassicTorque = Prefixed_Name(qk, "MassicTorque") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MassieuFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Massieu Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MassieuFunction">http://qudt.org/vocab/quantitykind/MassieuFunction</seealso>
    let MassieuFunction = Prefixed_Name(qk, "MassieuFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MaxExpectedOperatingThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Expected Operating Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MaxExpectedOperatingThrust">http://qudt.org/vocab/quantitykind/MaxExpectedOperatingThrust</seealso>
    let MaxExpectedOperatingThrust =
        Prefixed_Name(qk, "MaxExpectedOperatingThrust") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MaxOperatingThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Max Operating Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MaxOperatingThrust">http://qudt.org/vocab/quantitykind/MaxOperatingThrust</seealso>
    let MaxOperatingThrust = Prefixed_Name(qk, "MaxOperatingThrust") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MaxSeaLevelThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Max Sea Level thrust (Mlbf) "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Max Sea Level Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MaxSeaLevelThrust">http://qudt.org/vocab/quantitykind/MaxSeaLevelThrust</seealso>
    let MaxSeaLevelThrust = Prefixed_Name(qk, "MaxSeaLevelThrust") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MaximumBeta-ParticleEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Beta-Particle Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MaximumBeta-ParticleEnergy">http://qudt.org/vocab/quantitykind/MaximumBeta-ParticleEnergy</seealso>
    let MaximumBeta_ParticleEnergy =
        Prefixed_Name(qk, "MaximumBeta-ParticleEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MaximumExpectedOperatingPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Expected Operating Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MaximumExpectedOperatingPressure">http://qudt.org/vocab/quantitykind/MaximumExpectedOperatingPressure</seealso>
    let MaximumExpectedOperatingPressure =
        Prefixed_Name(qk, "MaximumExpectedOperatingPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MaximumOperatingPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Operating Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MaximumOperatingPressure">http://qudt.org/vocab/quantitykind/MaximumOperatingPressure</seealso>
    let MaximumOperatingPressure =
        Prefixed_Name(qk, "MaximumOperatingPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MeanEnergyImparted</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mean Energy Imparted"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MeanEnergyImparted">http://qudt.org/vocab/quantitykind/MeanEnergyImparted</seealso>
    let MeanEnergyImparted = Prefixed_Name(qk, "MeanEnergyImparted") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MeanFreePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mean Free Path"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MeanFreePath">http://qudt.org/vocab/quantitykind/MeanFreePath</seealso>
    let MeanFreePath = Prefixed_Name(qk, "MeanFreePath") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MeanLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mean Lifetime"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MeanLifetime">http://qudt.org/vocab/quantitykind/MeanLifetime</seealso>
    let MeanLifetime = Prefixed_Name(qk, "MeanLifetime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MeanLinearRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mean Linear Range"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MeanLinearRange">http://qudt.org/vocab/quantitykind/MeanLinearRange</seealso>
    let MeanLinearRange = Prefixed_Name(qk, "MeanLinearRange") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MeanMassRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MeanMassRange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mean Mass Range"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MeanMassRange">http://qudt.org/vocab/quantitykind/MeanMassRange</seealso>
    let MeanMassRange = Prefixed_Name(qk, "MeanMassRange") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MechanicalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mechanical Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MechanicalEnergy">http://qudt.org/vocab/quantitykind/MechanicalEnergy</seealso>
    let MechanicalEnergy = Prefixed_Name(qk, "MechanicalEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MechanicalImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Mechanical Impedance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MechanicalImpedance">http://qudt.org/vocab/quantitykind/MechanicalImpedance</seealso>
    let MechanicalImpedance = Prefixed_Name(qk, "MechanicalImpedance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MechanicalMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MechanicalMobility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mechanical Mobility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MechanicalMobility">http://qudt.org/vocab/quantitykind/MechanicalMobility</seealso>
    let MechanicalMobility = Prefixed_Name(qk, "MechanicalMobility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MechanicalSurfaceImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"There are various interpretations of MechanicalSurfaceImpedance: Pressure/Velocity - https://apps.dtic.mil/sti/pdfs/ADA315595.pdf, Force / Speed - https://www.wikidata.org/wiki/Q6421317, and (Pressure / Velocity)**0.5 - https://www.sciencedirect.com/topics/engineering/mechanical-impedance. We are seeking a resolution to these differences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mechanical surface impedance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MechanicalSurfaceImpedance">http://qudt.org/vocab/quantitykind/MechanicalSurfaceImpedance</seealso>
    let MechanicalSurfaceImpedance =
        Prefixed_Name(qk, "MechanicalSurfaceImpedance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MechanicalTension</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mechanical tension"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MechanicalTension">http://qudt.org/vocab/quantitykind/MechanicalTension</seealso>
    let MechanicalTension = Prefixed_Name(qk, "MechanicalTension") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MeltingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MeltingPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Melting Point Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MeltingPoint">http://qudt.org/vocab/quantitykind/MeltingPoint</seealso>
    let MeltingPoint = Prefixed_Name(qk, "MeltingPoint") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MicroCanonicalPartitionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CanonicalPartitionFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Micro Canonical Partition Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MicroCanonicalPartitionFunction">http://qudt.org/vocab/quantitykind/MicroCanonicalPartitionFunction</seealso>
    let MicroCanonicalPartitionFunction =
        Prefixed_Name(qk, "MicroCanonicalPartitionFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MicrobialFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Microbial Formation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MicrobialFormation">http://qudt.org/vocab/quantitykind/MicrobialFormation</seealso>
    let MicrobialFormation = Prefixed_Name(qk, "MicrobialFormation") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MigrationArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Migration Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MigrationArea">http://qudt.org/vocab/quantitykind/MigrationArea</seealso>
    let MigrationArea = Prefixed_Name(qk, "MigrationArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MigrationLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Migration Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MigrationLength">http://qudt.org/vocab/quantitykind/MigrationLength</seealso>
    let MigrationLength = Prefixed_Name(qk, "MigrationLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Mobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mobility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"移動度"</para><para>"mobilità"</para><para>"قابلية التحرك"</para><para>"mobilidade"</para><para>"mobilité"</para><para>"Beweglichkeit"</para><para>"mobility"</para><para>"mobilność"</para><para>"movilidad"</para><para>"迁移率"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Mobility">http://qudt.org/vocab/quantitykind/Mobility</seealso>
    let Mobility = Prefixed_Name(qk, "Mobility") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MobilityRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MobilityRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mobility Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MobilityRatio">http://qudt.org/vocab/quantitykind/MobilityRatio</seealso>
    let MobilityRatio = Prefixed_Name(qk, "MobilityRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ModulusOfAdmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Modulus Of Admittance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ModulusOfAdmittance">http://qudt.org/vocab/quantitykind/ModulusOfAdmittance</seealso>
    let ModulusOfAdmittance = Prefixed_Name(qk, "ModulusOfAdmittance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ModulusOfElasticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ModulusOfElasticity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modulus of Elasticity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ModulusOfElasticity">http://qudt.org/vocab/quantitykind/ModulusOfElasticity</seealso>
    let ModulusOfElasticity = Prefixed_Name(qk, "ModulusOfElasticity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ModulusOfImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ModulusOfImpedance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modulus Of Impedance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ModulusOfImpedance">http://qudt.org/vocab/quantitykind/ModulusOfImpedance</seealso>
    let ModulusOfImpedance = Prefixed_Name(qk, "ModulusOfImpedance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ModulusOfLinearSubgradeReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ModulusOfLinearSubgradeReaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modulus of Linear Subgrade Reaction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ModulusOfLinearSubgradeReaction">http://qudt.org/vocab/quantitykind/ModulusOfLinearSubgradeReaction</seealso>
    let ModulusOfLinearSubgradeReaction =
        Prefixed_Name(qk, "ModulusOfLinearSubgradeReaction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ModulusOfRotationalSubgradeReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ModulusOfRotationalSubgradeReaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modulus of Rotational Subgrade Reaction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ModulusOfRotationalSubgradeReaction">http://qudt.org/vocab/quantitykind/ModulusOfRotationalSubgradeReaction</seealso>
    let ModulusOfRotationalSubgradeReaction =
        Prefixed_Name(qk, "ModulusOfRotationalSubgradeReaction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ModulusOfSubgradeReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ModulusOfSubgradeReaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modulus of Subgrade Reaction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ModulusOfSubgradeReaction">http://qudt.org/vocab/quantitykind/ModulusOfSubgradeReaction</seealso>
    let ModulusOfSubgradeReaction =
        Prefixed_Name(qk, "ModulusOfSubgradeReaction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MoistureDiffusivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumeFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moisture Diffusivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MoistureDiffusivity">http://qudt.org/vocab/quantitykind/MoistureDiffusivity</seealso>
    let MoistureDiffusivity = Prefixed_Name(qk, "MoistureDiffusivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolalityOfSolute</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolalityOfSolute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molality of Solute"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolalityOfSolute">http://qudt.org/vocab/quantitykind/MolalityOfSolute</seealso>
    let MolalityOfSolute = Prefixed_Name(qk, "MolalityOfSolute") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarAbsorptionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarAbsorptionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Absorption Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarAbsorptionCoefficient">http://qudt.org/vocab/quantitykind/MolarAbsorptionCoefficient</seealso>
    let MolarAbsorptionCoefficient =
        Prefixed_Name(qk, "MolarAbsorptionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarAngularMomentum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarAngularMomentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Angular Momentum"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarAngularMomentum">http://qudt.org/vocab/quantitykind/MolarAngularMomentum</seealso>
    let MolarAngularMomentum = Prefixed_Name(qk, "MolarAngularMomentum") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarAttenuationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarAttenuationCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Attenuation Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarAttenuationCoefficient">http://qudt.org/vocab/quantitykind/MolarAttenuationCoefficient</seealso>
    let MolarAttenuationCoefficient =
        Prefixed_Name(qk, "MolarAttenuationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarConductivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Conductivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarConductivity">http://qudt.org/vocab/quantitykind/MolarConductivity</seealso>
    let MolarConductivity = Prefixed_Name(qk, "MolarConductivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"molar density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarDensity">http://qudt.org/vocab/quantitykind/MolarDensity</seealso>
    let MolarDensity = Prefixed_Name(qk, "MolarDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarEnergy">http://qudt.org/vocab/quantitykind/MolarEnergy</seealso>
    let MolarEnergy = Prefixed_Name(qk, "MolarEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarEntropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarEntropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Entropy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarEntropy">http://qudt.org/vocab/quantitykind/MolarEntropy</seealso>
    let MolarEntropy = Prefixed_Name(qk, "MolarEntropy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Equivalent"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarEquivalent">http://qudt.org/vocab/quantitykind/MolarEquivalent</seealso>
    let MolarEquivalent = Prefixed_Name(qk, "MolarEquivalent") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Flow Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarFlowRate">http://qudt.org/vocab/quantitykind/MolarFlowRate</seealso>
    let MolarFlowRate = Prefixed_Name(qk, "MolarFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarFluxDensity">http://qudt.org/vocab/quantitykind/MolarFluxDensity</seealso>
    let MolarFluxDensity = Prefixed_Name(qk, "MolarFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarFluxDensityVariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarFluxDensityVariance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Flux Density Variance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance">http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance</seealso>
    let MolarFluxDensityVariance =
        Prefixed_Name(qk, "MolarFluxDensityVariance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarFluxDensityVariance_NEON</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Molar Flux Density Variance, NEON"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance_NEON">http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance_NEON</seealso>
    let MolarFluxDensityVariance_NEON =
        Prefixed_Name(qk, "MolarFluxDensityVariance_NEON") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarHeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarHeatCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Heat Capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarHeatCapacity">http://qudt.org/vocab/quantitykind/MolarHeatCapacity</seealso>
    let MolarHeatCapacity = Prefixed_Name(qk, "MolarHeatCapacity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarInternalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"molar internal energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarInternalEnergy">http://qudt.org/vocab/quantitykind/MolarInternalEnergy</seealso>
    let MolarInternalEnergy = Prefixed_Name(qk, "MolarInternalEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"جرم مولی"</para><para>"Masă molară"</para><para>"Молярная масса"</para><para>"masa molar"</para><para>"massa molare"</para><para>"masse molaire"</para><para>"Molmasse"</para><para>"molar mass"</para><para>"摩尔质量"</para><para>"मोलर द्रव्यमान"</para><para>"molar kütle"</para><para>"molska masa"</para><para>"Molární hmotnost"</para><para>"massa molar"</para><para>"Masa molowa"</para><para>"كتلة مولية"</para><para>"モル質量"</para><para>"Jisim molar"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarMass">http://qudt.org/vocab/quantitykind/MolarMass</seealso>
    let MolarMass = Prefixed_Name(qk, "MolarMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarOpticalRotationalAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"molar optical rotational ability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarOpticalRotationalAbility">http://qudt.org/vocab/quantitykind/MolarOpticalRotationalAbility</seealso>
    let MolarOpticalRotationalAbility =
        Prefixed_Name(qk, "MolarOpticalRotationalAbility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarOpticalRotatoryPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarOpticalRotatoryPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Optical Rotatory Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarOpticalRotatoryPower">http://qudt.org/vocab/quantitykind/MolarOpticalRotatoryPower</seealso>
    let MolarOpticalRotatoryPower =
        Prefixed_Name(qk, "MolarOpticalRotatoryPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarRefractivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarRefractivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Refractivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarRefractivity">http://qudt.org/vocab/quantitykind/MolarRefractivity</seealso>
    let MolarRefractivity = Prefixed_Name(qk, "MolarRefractivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolarThermalCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"molar thermal capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarThermalCapacity">http://qudt.org/vocab/quantitykind/MolarThermalCapacity</seealso>
    let MolarThermalCapacity = Prefixed_Name(qk, "MolarThermalCapacity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarThermodynamicEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"molar thermodynamic energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarThermodynamicEnergy">http://qudt.org/vocab/quantitykind/MolarThermodynamicEnergy</seealso>
    let MolarThermodynamicEnergy =
        Prefixed_Name(qk, "MolarThermodynamicEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolarVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molvolumen"</para><para>"volume molare"</para><para>"volume molar"</para><para>"Молярный объём"</para><para>"حجم مولي"</para><para>"摩尔体积"</para><para>"molární objem"</para><para>"molski volumen"</para><para>"حجم مولی"</para><para>"molar hacim"</para><para>"volumen molar"</para><para>"モル体積"</para><para>"Isipadu molar"</para><para>"molar volume"</para><para>"volume molaire"</para><para>"volum molar"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolarVolume">http://qudt.org/vocab/quantitykind/MolarVolume</seealso>
    let MolarVolume = Prefixed_Name(qk, "MolarVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MoleFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mole Fraction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MoleFraction">http://qudt.org/vocab/quantitykind/MoleFraction</seealso>
    let MoleFraction = Prefixed_Name(qk, "MoleFraction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolecularConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molecular Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolecularConcentration">http://qudt.org/vocab/quantitykind/MolecularConcentration</seealso>
    let MolecularConcentration =
        Prefixed_Name(qk, "MolecularConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/MolecularMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolecularMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molecular Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolecularMass">http://qudt.org/vocab/quantitykind/MolecularMass</seealso>
    let MolecularMass = Prefixed_Name(qk, "MolecularMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MolecularViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Molecular Viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MolecularViscosity">http://qudt.org/vocab/quantitykind/MolecularViscosity</seealso>
    let MolecularViscosity = Prefixed_Name(qk, "MolecularViscosity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MomentOfForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfForce"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moment of Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MomentOfForce">http://qudt.org/vocab/quantitykind/MomentOfForce</seealso>
    let MomentOfForce = Prefixed_Name(qk, "MomentOfForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MomentOfInertia</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moment bezwładności"</para><para>"Massenträgheitsmoment"</para><para>"momento de inércia"</para><para>"گشتاور لختی"</para><para>"慣性モーメント"</para><para>"moment of inertia"</para><para>"momento de inercia"</para><para>"momento di inerzia"</para><para>"Moment de inerție"</para><para>"Momen inersia"</para><para>"Момент инерции"</para><para>"moment d'inertie"</para><para>"轉動慣量"</para><para>"जड़त्वाघूर्ण"</para><para>"Moment setrvačnosti"</para><para>"عزم القصور الذاتي"</para><para>"Eylemsizlik momenti"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MomentOfInertia">http://qudt.org/vocab/quantitykind/MomentOfInertia</seealso>
    let MomentOfInertia = Prefixed_Name(qk, "MomentOfInertia") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MomentOfInertia_Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moment of Inertia in the Y axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MomentOfInertia_Y">http://qudt.org/vocab/quantitykind/MomentOfInertia_Y</seealso>
    let MomentOfInertia_Y = Prefixed_Name(qk, "MomentOfInertia_Y") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MomentOfInertia_Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Moment of Inertia in the Z axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MomentOfInertia_Z">http://qudt.org/vocab/quantitykind/MomentOfInertia_Z</seealso>
    let MomentOfInertia_Z = Prefixed_Name(qk, "MomentOfInertia_Z") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Momentum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Momentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Momentum"</para><para>"زخم الحركة"</para><para>"運動量"</para><para>"تکانه"</para><para>"cantidad de movimiento"</para><para>"hybnost"</para><para>"quantità di moto"</para><para>"momento linear"</para><para>"pęd"</para><para>"quantité de mouvement"</para><para>"импульс"</para><para>"impuls"</para><para>"动量"</para><para>"Impuls"</para><para>"momentum"</para><para>"gibalna količina"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Momentum">http://qudt.org/vocab/quantitykind/Momentum</seealso>
    let Momentum = Prefixed_Name(qk, "Momentum") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MomentumPerAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentumPerAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Momentum per Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MomentumPerAngle">http://qudt.org/vocab/quantitykind/MomentumPerAngle</seealso>
    let MomentumPerAngle = Prefixed_Name(qk, "MomentumPerAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MorbidityRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MorbidityRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Morbidity Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MorbidityRate">http://qudt.org/vocab/quantitykind/MorbidityRate</seealso>
    let MorbidityRate = Prefixed_Name(qk, "MorbidityRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MortalityRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MortalityRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mortality Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MortalityRate">http://qudt.org/vocab/quantitykind/MortalityRate</seealso>
    let MortalityRate = Prefixed_Name(qk, "MortalityRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MotorConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"motor constant"</para><para>"motor constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MotorConstant">http://qudt.org/vocab/quantitykind/MotorConstant</seealso>
    let MotorConstant = Prefixed_Name(qk, "MotorConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MultiplicationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MultiplicationFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Multiplication Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MultiplicationFactor">http://qudt.org/vocab/quantitykind/MultiplicationFactor</seealso>
    let MultiplicationFactor = Prefixed_Name(qk, "MultiplicationFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/MutualInductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Inductance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mutual Inductance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/MutualInductance">http://qudt.org/vocab/quantitykind/MutualInductance</seealso>
    let MutualInductance = Prefixed_Name(qk, "MutualInductance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NOMINAL-ASCENT-PROPELLANT-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nominal Ascent Propellant Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NOMINAL-ASCENT-PROPELLANT-MASS">http://qudt.org/vocab/quantitykind/NOMINAL-ASCENT-PROPELLANT-MASS</seealso>
    let NOMINAL_ASCENT_PROPELLANT_MASS =
        Prefixed_Name(qk, "NOMINAL-ASCENT-PROPELLANT-MASS") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NapierianAbsorbance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NapierianAbsorbance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Napierian Absorbance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NapierianAbsorbance">http://qudt.org/vocab/quantitykind/NapierianAbsorbance</seealso>
    let NapierianAbsorbance = Prefixed_Name(qk, "NapierianAbsorbance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NaturalLogarithmicMedianInformationFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"median information flow (from a source of information), expressed as a natural logarithm "</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NaturalLogarithmicMedianInformationFlow">http://qudt.org/vocab/quantitykind/NaturalLogarithmicMedianInformationFlow</seealso>
    let NaturalLogarithmicMedianInformationFlow =
        Prefixed_Name(qk, "NaturalLogarithmicMedianInformationFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NeelTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neel Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeelTemperature">http://qudt.org/vocab/quantitykind/NeelTemperature</seealso>
    let NeelTemperature = Prefixed_Name(qk, "NeelTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/NeutralRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"neutral ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeutralRatio">http://qudt.org/vocab/quantitykind/NeutralRatio</seealso>
    let NeutralRatio = Prefixed_Name(qk, "NeutralRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NeutronDiffusionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NeutronDiffusionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coefficiente di diffusione"</para><para>"diffusion coefficient"</para><para>"difuzijski koeficient"</para><para>"coeficiente de difusão"</para><para>"coeficiente de difusión"</para><para>"Diffusionskoeffizient"</para><para>"coefficient de diffusion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeutronDiffusionCoefficient">http://qudt.org/vocab/quantitykind/NeutronDiffusionCoefficient</seealso>
    let NeutronDiffusionCoefficient =
        Prefixed_Name(qk, "NeutronDiffusionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NeutronDiffusionLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutron Diffusion Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeutronDiffusionLength">http://qudt.org/vocab/quantitykind/NeutronDiffusionLength</seealso>
    let NeutronDiffusionLength =
        Prefixed_Name(qk, "NeutronDiffusionLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NeutronNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NeutronNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"عدد النيوترونات"</para><para>"número de neutrons"</para><para>"liczba neutronowa"</para><para>"عدد نوترون"</para><para>"nötron snumarası"</para><para>"numero neutronico"</para><para>"neutron number"</para><para>"Neutronové číslo"</para><para>"число нейтронов"</para><para>"Nombre de neutrons"</para><para>"中子數"</para><para>"Nombor neutron"</para><para>"número neutrónico"</para><para>"Neutronenzahl"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeutronNumber">http://qudt.org/vocab/quantitykind/NeutronNumber</seealso>
    let NeutronNumber = Prefixed_Name(qk, "NeutronNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NeutronYieldPerAbsorption</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NeutronYieldPerAbsorption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutron Yield per Absorption"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeutronYieldPerAbsorption">http://qudt.org/vocab/quantitykind/NeutronYieldPerAbsorption</seealso>
    let NeutronYieldPerAbsorption =
        Prefixed_Name(qk, "NeutronYieldPerAbsorption") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NeutronYieldPerFission</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NeutronYieldPerFission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutron Yield per Fission"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NeutronYieldPerFission">http://qudt.org/vocab/quantitykind/NeutronYieldPerFission</seealso>
    let NeutronYieldPerFission =
        Prefixed_Name(qk, "NeutronYieldPerFission") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Non-LeakageProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Non-LeakageProbability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Non-Leakage Probability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Non-LeakageProbability">http://qudt.org/vocab/quantitykind/Non-LeakageProbability</seealso>
    let Non_LeakageProbability =
        Prefixed_Name(qk, "Non-LeakageProbability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NonActivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Non-active Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NonActivePower">http://qudt.org/vocab/quantitykind/NonActivePower</seealso>
    let NonActivePower = Prefixed_Name(qk, "NonActivePower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/NonNegativeLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Positive Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NonNegativeLength">http://qudt.org/vocab/quantitykind/NonNegativeLength</seealso>
    let NonNegativeLength = Prefixed_Name(qk, "NonNegativeLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/NormalStress</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Normal Stress"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NormalStress">http://qudt.org/vocab/quantitykind/NormalStress</seealso>
    let NormalStress = Prefixed_Name(qk, "NormalStress") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NormalizedDimensionlessRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Positive Dimensionless Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NormalizedDimensionlessRatio">http://qudt.org/vocab/quantitykind/NormalizedDimensionlessRatio</seealso>
    let NormalizedDimensionlessRatio =
        Prefixed_Name(qk, "NormalizedDimensionlessRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NozzleThroatCrossSectionalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nozzle Throat Cross-sectional Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NozzleThroatCrossSectionalArea">http://qudt.org/vocab/quantitykind/NozzleThroatCrossSectionalArea</seealso>
    let NozzleThroatCrossSectionalArea =
        Prefixed_Name(qk, "NozzleThroatCrossSectionalArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NozzleThroatDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nozzle Throat Diameter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NozzleThroatDiameter">http://qudt.org/vocab/quantitykind/NozzleThroatDiameter</seealso>
    let NozzleThroatDiameter = Prefixed_Name(qk, "NozzleThroatDiameter") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/NozzleThroatPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nozzle Throat Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NozzleThroatPressure">http://qudt.org/vocab/quantitykind/NozzleThroatPressure</seealso>
    let NozzleThroatPressure = Prefixed_Name(qk, "NozzleThroatPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NozzleWallsThrustReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nozzle Walls Thrust Reaction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NozzleWallsThrustReaction">http://qudt.org/vocab/quantitykind/NozzleWallsThrustReaction</seealso>
    let NozzleWallsThrustReaction =
        Prefixed_Name(qk, "NozzleWallsThrustReaction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NuclearEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nuclear energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NuclearEnergy">http://qudt.org/vocab/quantitykind/NuclearEnergy</seealso>
    let NuclearEnergy = Prefixed_Name(qk, "NuclearEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NuclearQuadrupoleMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NuclearQuadrupoleMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nuclear Quadrupole Moment"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NuclearQuadrupoleMoment">http://qudt.org/vocab/quantitykind/NuclearQuadrupoleMoment</seealso>
    let NuclearQuadrupoleMoment =
        Prefixed_Name(qk, "NuclearQuadrupoleMoment") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NuclearRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nuclear Radius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NuclearRadius">http://qudt.org/vocab/quantitykind/NuclearRadius</seealso>
    let NuclearRadius = Prefixed_Name(qk, "NuclearRadius") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NuclearSpinQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NuclearSpinQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spin Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NuclearSpinQuantumNumber">http://qudt.org/vocab/quantitykind/NuclearSpinQuantumNumber</seealso>
    let NuclearSpinQuantumNumber =
        Prefixed_Name(qk, "NuclearSpinQuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NucleonNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NucleonNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"عدد كتلي"</para><para>"Nombor nukleon"</para><para>"liczba masowa"</para><para>"número másico"</para><para>"Nukleové číslo"</para><para>"nükleon numarası"</para><para>"número de massa"</para><para>"nombre de masse"</para><para>"質量数"</para><para>"nucleon number"</para><para>"质量数"</para><para>"numero di massa"</para><para>"Nukleonenzahl"</para><para>"عدد جرمی"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NucleonNumber">http://qudt.org/vocab/quantitykind/NucleonNumber</seealso>
    let NucleonNumber = Prefixed_Name(qk, "NucleonNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/NumberDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NumberDensity">http://qudt.org/vocab/quantitykind/NumberDensity</seealso>
    let NumberDensity = Prefixed_Name(qk, "NumberDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NumberOfElectricalPhases</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberOfElectricalPhases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number of Electrical Phases"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NumberOfElectricalPhases">http://qudt.org/vocab/quantitykind/NumberOfElectricalPhases</seealso>
    let NumberOfElectricalPhases =
        Prefixed_Name(qk, "NumberOfElectricalPhases") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/NumberOfParticles</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberOfParticles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number of Particles"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/NumberOfParticles">http://qudt.org/vocab/quantitykind/NumberOfParticles</seealso>
    let NumberOfParticles = Prefixed_Name(qk, "NumberOfParticles") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/OlfactoryThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Olfactory Threshold"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OlfactoryThreshold">http://qudt.org/vocab/quantitykind/OlfactoryThreshold</seealso>
    let OlfactoryThreshold = Prefixed_Name(qk, "OlfactoryThreshold") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/OpeningRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:OpeningRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Opening Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OpeningRatio">http://qudt.org/vocab/quantitykind/OpeningRatio</seealso>
    let OpeningRatio = Prefixed_Name(qk, "OpeningRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/OrbitalAngularMomentumPerMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Orbital Angular Momentum per Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumPerMass">http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumPerMass</seealso>
    let OrbitalAngularMomentumPerMass =
        Prefixed_Name(qk, "OrbitalAngularMomentumPerMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/OrbitalAngularMomentumQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:OrbitalAngularMomentumQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orbital Angular Momentum Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumQuantumNumber">http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumQuantumNumber</seealso>
    let OrbitalAngularMomentumQuantumNumber =
        Prefixed_Name(qk, "OrbitalAngularMomentumQuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/OrbitalRadialDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orbital Radial Distance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OrbitalRadialDistance">http://qudt.org/vocab/quantitykind/OrbitalRadialDistance</seealso>
    let OrbitalRadialDistance =
        Prefixed_Name(qk, "OrbitalRadialDistance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/OrderOfReflection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:OrderOfReflection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Order of Reflection"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OrderOfReflection">http://qudt.org/vocab/quantitykind/OrderOfReflection</seealso>
    let OrderOfReflection = Prefixed_Name(qk, "OrderOfReflection") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/OsmoticCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:OsmoticCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Osmotic Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OsmoticCoefficient">http://qudt.org/vocab/quantitykind/OsmoticCoefficient</seealso>
    let OsmoticCoefficient = Prefixed_Name(qk, "OsmoticCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/OsmoticConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Osmotic Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OsmoticConcentration">http://qudt.org/vocab/quantitykind/OsmoticConcentration</seealso>
    let OsmoticConcentration = Prefixed_Name(qk, "OsmoticConcentration") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/OsmoticPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"فشار اسمزی"</para><para>"osmotischer Druck"</para><para>"ozmotik basıç"</para><para>"pressione osmotica"</para><para>"Osmotický tlak"</para><para>"渗透压"</para><para>"pressão osmótica"</para><para>"pression osmotique"</para><para>"osmotic pressure"</para><para>"presión osmótica"</para><para>"Tekanan osmotik"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OsmoticPressure">http://qudt.org/vocab/quantitykind/OsmoticPressure</seealso>
    let OsmoticPressure = Prefixed_Name(qk, "OsmoticPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/OverRangeDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Over-range distance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/OverRangeDistance">http://qudt.org/vocab/quantitykind/OverRangeDistance</seealso>
    let OverRangeDistance = Prefixed_Name(qk, "OverRangeDistance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PREDICTED-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Predicted Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PREDICTED-MASS">http://qudt.org/vocab/quantitykind/PREDICTED-MASS</seealso>
    let PREDICTED_MASS = Prefixed_Name(qk, "PREDICTED-MASS") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PRODUCT-OF-INERTIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA">http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA</seealso>
    let PRODUCT_OF_INERTIA = Prefixed_Name(qk, "PRODUCT-OF-INERTIA") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PRODUCT-OF-INERTIA_X</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia in the X axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_X">http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_X</seealso>
    let PRODUCT_OF_INERTIA_X = Prefixed_Name(qk, "PRODUCT-OF-INERTIA_X") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PRODUCT-OF-INERTIA_Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia in the Y axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Y">http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Y</seealso>
    let PRODUCT_OF_INERTIA_Y = Prefixed_Name(qk, "PRODUCT-OF-INERTIA_Y") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PRODUCT-OF-INERTIA_Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia in the Z axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Z">http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Z</seealso>
    let PRODUCT_OF_INERTIA_Z = Prefixed_Name(qk, "PRODUCT-OF-INERTIA_Z") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Pace</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Pace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pace"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Pace">http://qudt.org/vocab/quantitykind/Pace</seealso>
    let Pace = Prefixed_Name(qk, "Pace") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PackingFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PackingFraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Packing Fraction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PackingFraction">http://qudt.org/vocab/quantitykind/PackingFraction</seealso>
    let PackingFraction = Prefixed_Name(qk, "PackingFraction") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PartialPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Partial Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PartialPressure">http://qudt.org/vocab/quantitykind/PartialPressure</seealso>
    let PartialPressure = Prefixed_Name(qk, "PartialPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ParticleCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticleCurrent">http://qudt.org/vocab/quantitykind/ParticleCurrent</seealso>
    let ParticleCurrent = Prefixed_Name(qk, "ParticleCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ParticleCurrentDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"particle current density"</para><para>"particle current density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticleCurrentDensity">http://qudt.org/vocab/quantitykind/ParticleCurrentDensity</seealso>
    let ParticleCurrentDensity =
        Prefixed_Name(qk, "ParticleCurrentDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ParticleFluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ParticleFluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Fluence"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticleFluence">http://qudt.org/vocab/quantitykind/ParticleFluence</seealso>
    let ParticleFluence = Prefixed_Name(qk, "ParticleFluence") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ParticleFluenceRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ParticleFluenceRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Fluence Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticleFluenceRate">http://qudt.org/vocab/quantitykind/ParticleFluenceRate</seealso>
    let ParticleFluenceRate = Prefixed_Name(qk, "ParticleFluenceRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ParticleNumberDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Number Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticleNumberDensity">http://qudt.org/vocab/quantitykind/ParticleNumberDensity</seealso>
    let ParticleNumberDensity =
        Prefixed_Name(qk, "ParticleNumberDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ParticlePositionVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Position Vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticlePositionVector">http://qudt.org/vocab/quantitykind/ParticlePositionVector</seealso>
    let ParticlePositionVector =
        Prefixed_Name(qk, "ParticlePositionVector") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ParticleSourceDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ParticleSourceDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Source Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ParticleSourceDensity">http://qudt.org/vocab/quantitykind/ParticleSourceDensity</seealso>
    let ParticleSourceDensity =
        Prefixed_Name(qk, "ParticleSourceDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PathLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Path Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PathLength">http://qudt.org/vocab/quantitykind/PathLength</seealso>
    let PathLength = Prefixed_Name(qk, "PathLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PayloadMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Payload Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PayloadMass">http://qudt.org/vocab/quantitykind/PayloadMass</seealso>
    let PayloadMass = Prefixed_Name(qk, "PayloadMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PayloadRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Payload Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PayloadRatio">http://qudt.org/vocab/quantitykind/PayloadRatio</seealso>
    let PayloadRatio = Prefixed_Name(qk, "PayloadRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PeltierCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Peltier Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PeltierCoefficient">http://qudt.org/vocab/quantitykind/PeltierCoefficient</seealso>
    let PeltierCoefficient = Prefixed_Name(qk, "PeltierCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Period"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Period">http://qudt.org/vocab/quantitykind/Period</seealso>
    let Period = Prefixed_Name(qk, "Period") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Permeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Permeability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permeability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Permeability">http://qudt.org/vocab/quantitykind/Permeability</seealso>
    let Permeability = Prefixed_Name(qk, "Permeability") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PermeabilityRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PermeabilityRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permeability Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PermeabilityRatio">http://qudt.org/vocab/quantitykind/PermeabilityRatio</seealso>
    let PermeabilityRatio = Prefixed_Name(qk, "PermeabilityRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Permeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Permeance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permeance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Permeance">http://qudt.org/vocab/quantitykind/Permeance</seealso>
    let Permeance = Prefixed_Name(qk, "Permeance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Permittivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Permittivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permittivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Permittivity">http://qudt.org/vocab/quantitykind/Permittivity</seealso>
    let Permittivity = Prefixed_Name(qk, "Permittivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PermittivityRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PermittivityRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permittivity Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PermittivityRatio">http://qudt.org/vocab/quantitykind/PermittivityRatio</seealso>
    let PermittivityRatio = Prefixed_Name(qk, "PermittivityRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PhaseCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PhaseCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phase coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhaseCoefficient">http://qudt.org/vocab/quantitykind/PhaseCoefficient</seealso>
    let PhaseCoefficient = Prefixed_Name(qk, "PhaseCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PhaseDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"diferença de fase"</para><para>"différence de phase"</para><para>"phase difference"</para><para>"diferencia de fase"</para><para>"Phasenverschiebungswinkel"</para><para>"przesunięcie fazowe"</para><para>"اختلاف طور"</para><para>"位相差"</para><para>"sfasamento angolare"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhaseDifference">http://qudt.org/vocab/quantitykind/PhaseDifference</seealso>
    let PhaseDifference = Prefixed_Name(qk, "PhaseDifference") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PhaseSpeedOfSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PhaseSpeedOfSound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phase speed of sound"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhaseSpeedOfSound">http://qudt.org/vocab/quantitykind/PhaseSpeedOfSound</seealso>
    let PhaseSpeedOfSound = Prefixed_Name(qk, "PhaseSpeedOfSound") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PhononMeanFreePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phonon Mean Free Path"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhononMeanFreePath">http://qudt.org/vocab/quantitykind/PhononMeanFreePath</seealso>
    let PhononMeanFreePath = Prefixed_Name(qk, "PhononMeanFreePath") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PhotoThresholdOfAwarenessFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Photo Threshold of Awareness Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhotoThresholdOfAwarenessFunction">http://qudt.org/vocab/quantitykind/PhotoThresholdOfAwarenessFunction</seealso>
    let PhotoThresholdOfAwarenessFunction =
        Prefixed_Name(qk, "PhotoThresholdOfAwarenessFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PhotonIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PhotonIntensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photon Intensity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhotonIntensity">http://qudt.org/vocab/quantitykind/PhotonIntensity</seealso>
    let PhotonIntensity = Prefixed_Name(qk, "PhotonIntensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PhotonLuminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"photon luminance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"photon luminance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhotonLuminance">http://qudt.org/vocab/quantitykind/PhotonLuminance</seealso>
    let PhotonLuminance = Prefixed_Name(qk, "PhotonLuminance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PhotonRadiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PhotonRadiance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photon Radiance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhotonRadiance">http://qudt.org/vocab/quantitykind/PhotonRadiance</seealso>
    let PhotonRadiance = Prefixed_Name(qk, "PhotonRadiance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PhotosyntheticPhotonFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PhotosyntheticPhotonFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photosynthetic Photon Flux"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFlux">http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFlux</seealso>
    let PhotosyntheticPhotonFlux =
        Prefixed_Name(qk, "PhotosyntheticPhotonFlux") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PhotosyntheticPhotonFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PhotosyntheticPhotonFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photosynthetic Photon Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFluxDensity">http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFluxDensity</seealso>
    let PhotosyntheticPhotonFluxDensity =
        Prefixed_Name(qk, "PhotosyntheticPhotonFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PictureElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"picture element"</para><para>"picture element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PictureElement">http://qudt.org/vocab/quantitykind/PictureElement</seealso>
    let PictureElement = Prefixed_Name(qk, "PictureElement") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Piece</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"piece"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Piece">http://qudt.org/vocab/quantitykind/Piece</seealso>
    let Piece = Prefixed_Name(qk, "Piece") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PlanarForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flächenlast"</para><para>"Planar Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PlanarForce">http://qudt.org/vocab/quantitykind/PlanarForce</seealso>
    let PlanarForce = Prefixed_Name(qk, "PlanarForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PlanckFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Planck Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PlanckFunction">http://qudt.org/vocab/quantitykind/PlanckFunction</seealso>
    let PlanckFunction = Prefixed_Name(qk, "PlanckFunction") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PlaneAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PlaneAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"angolo piano"</para><para>"Равнинен ъгъл"</para><para>"plane angle"</para><para>"Sudut satah"</para><para>"Επίπεδη γωνία"</para><para>"kąt płaski"</para><para>"זווית"</para><para>"弧度"</para><para>"medida angular"</para><para>"ravninski kot"</para><para>"angle plan"</para><para>"unghi plan"</para><para>"ebener Winkel"</para><para>"الزاوية النصف قطرية"</para><para>"szög"</para><para>"زاویه مستوی"</para><para>"ángulo plano"</para><para>"Rovinný úhel"</para><para>"Плоский угол"</para><para>"角度"</para><para>"क्षेत्र"</para><para>"düzlemsel açı"</para><para>"angulus planus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PlaneAngle">http://qudt.org/vocab/quantitykind/PlaneAngle</seealso>
    let PlaneAngle = Prefixed_Name(qk, "PlaneAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PlasmaLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PlasmaLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plasma Level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PlasmaLevel">http://qudt.org/vocab/quantitykind/PlasmaLevel</seealso>
    let PlasmaLevel = Prefixed_Name(qk, "PlasmaLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PoissonRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PoissonRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Poisson Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PoissonRatio">http://qudt.org/vocab/quantitykind/PoissonRatio</seealso>
    let PoissonRatio = Prefixed_Name(qk, "PoissonRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PolarMomentOfInertia</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MomentOfInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polar moment of inertia"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PolarMomentOfInertia">http://qudt.org/vocab/quantitykind/PolarMomentOfInertia</seealso>
    let PolarMomentOfInertia = Prefixed_Name(qk, "PolarMomentOfInertia") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Polarizability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Polarizability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"polarisability"</para><para>"Polarizability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Polarizability">http://qudt.org/vocab/quantitykind/Polarizability</seealso>
    let Polarizability = Prefixed_Name(qk, "Polarizability") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PolarizationField</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polarization Field"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PolarizationField">http://qudt.org/vocab/quantitykind/PolarizationField</seealso>
    let PolarizationField = Prefixed_Name(qk, "PolarizationField") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Population</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Population"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Population">http://qudt.org/vocab/quantitykind/Population</seealso>
    let Population = Prefixed_Name(qk, "Population") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PositionVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Position Vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PositionVector">http://qudt.org/vocab/quantitykind/PositionVector</seealso>
    let PositionVector = Prefixed_Name(qk, "PositionVector") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PositiveDimensionlessRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Positive Dimensionless Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PositiveDimensionlessRatio">http://qudt.org/vocab/quantitykind/PositiveDimensionlessRatio</seealso>
    let PositiveDimensionlessRatio =
        Prefixed_Name(qk, "PositiveDimensionlessRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PositiveLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Positive Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PositiveLength">http://qudt.org/vocab/quantitykind/PositiveLength</seealso>
    let PositiveLength = Prefixed_Name(qk, "PositiveLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PositivePlaneAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PlaneAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Positive Plane Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PositivePlaneAngle">http://qudt.org/vocab/quantitykind/PositivePlaneAngle</seealso>
    let PositivePlaneAngle = Prefixed_Name(qk, "PositivePlaneAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PotentialEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"potentielle Energie"</para><para>"Energia potencjalna"</para><para>"طاقة وضع"</para><para>"énergie potentielle"</para><para>"energia potenziale"</para><para>"Potansiyel enerji"</para><para>"energia potencial"</para><para>"Energie potențială"</para><para>"انرژی پتانسیل"</para><para>"स्थितिज ऊर्जा"</para><para>"位置エネルギー"</para><para>"potenciální energie"</para><para>"Tenaga keupayaan"</para><para>"势能"</para><para>"energía potencial"</para><para>"potential energy"</para><para>"потенциальная энергия"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PotentialEnergy">http://qudt.org/vocab/quantitykind/PotentialEnergy</seealso>
    let PotentialEnergy = Prefixed_Name(qk, "PotentialEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"teljesítmény , hőáramlás"</para><para>"電力・仕事率"</para><para>"הספק"</para><para>"Мощность"</para><para>"potentia"</para><para>"power"</para><para>"Ισχύς"</para><para>"القدرة"</para><para>"puissance"</para><para>"शक्ति"</para><para>"功率、热流"</para><para>"توان، نرخ جریان گرما"</para><para>"potencia"</para><para>"moč"</para><para>"Kuasa"</para><para>"Leistung"</para><para>"Výkon"</para><para>"güç"</para><para>"putere"</para><para>"potência"</para><para>"potenza"</para><para>"Мощност"</para><para>"moc"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Power">http://qudt.org/vocab/quantitykind/Power</seealso>
    let Power = Prefixed_Name(qk, "Power") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PowerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerArea">http://qudt.org/vocab/quantitykind/PowerArea</seealso>
    let PowerArea = Prefixed_Name(qk, "PowerArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PowerAreaPerSolidAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerAreaPerSolidAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power Area per Solid Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerAreaPerSolidAngle">http://qudt.org/vocab/quantitykind/PowerAreaPerSolidAngle</seealso>
    let PowerAreaPerSolidAngle =
        Prefixed_Name(qk, "PowerAreaPerSolidAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PowerConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"power constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerConstant">http://qudt.org/vocab/quantitykind/PowerConstant</seealso>
    let PowerConstant = Prefixed_Name(qk, "PowerConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PowerDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PowerDensity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerDensity">http://qudt.org/vocab/quantitykind/PowerDensity</seealso>
    let PowerDensity = Prefixed_Name(qk, "PowerDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PowerFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"facteur de puissance"</para><para>"faktor kuasa"</para><para>"fattore di potenza"</para><para>"güç faktörü"</para><para>"功率因数"</para><para>"factor de potencia"</para><para>"factor de putere"</para><para>"力率"</para><para>"معامل القدرة"</para><para>"Účiník"</para><para>"Współczynnik mocy"</para><para>"fator de potência"</para><para>"ضریب توان"</para><para>"power factor"</para><para>"शक्ति गुणांक"</para><para>"Leistungsfaktor"</para><para>"Коэффициент_мощности"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerFactor">http://qudt.org/vocab/quantitykind/PowerFactor</seealso>
    let PowerFactor = Prefixed_Name(qk, "PowerFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PowerPerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power Per Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerPerArea">http://qudt.org/vocab/quantitykind/PowerPerArea</seealso>
    let PowerPerArea = Prefixed_Name(qk, "PowerPerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PowerPerAreaAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Power per Area Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerPerAreaAngle">http://qudt.org/vocab/quantitykind/PowerPerAreaAngle</seealso>
    let PowerPerAreaAngle = Prefixed_Name(qk, "PowerPerAreaAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PowerPerAreaQuarticTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerAreaQuarticTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power per area quartic temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerPerAreaQuarticTemperature">http://qudt.org/vocab/quantitykind/PowerPerAreaQuarticTemperature</seealso>
    let PowerPerAreaQuarticTemperature =
        Prefixed_Name(qk, "PowerPerAreaQuarticTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PowerPerElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power Per Electric Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerPerElectricCharge">http://qudt.org/vocab/quantitykind/PowerPerElectricCharge</seealso>
    let PowerPerElectricCharge =
        Prefixed_Name(qk, "PowerPerElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PowerPerVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Power per Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PowerPerVolume">http://qudt.org/vocab/quantitykind/PowerPerVolume</seealso>
    let PowerPerVolume = Prefixed_Name(qk, "PowerPerVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PoyntingVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PoyntingVector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vettore di Poynting"</para><para>"wektor Poyntinga"</para><para>"متجَه بوينتنج"</para><para>"ポインティングベクトル"</para><para>"Poynting vector"</para><para>"vector de Poynting"</para><para>"вектор Пойнтинга"</para><para>"Poynting-Vektor"</para><para>"vecteur de Poynting"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PoyntingVector">http://qudt.org/vocab/quantitykind/PoyntingVector</seealso>
    let PoyntingVector = Prefixed_Name(qk, "PoyntingVector") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"basınç"</para><para>"tlak"</para><para>"Druck"</para><para>"pressione"</para><para>"pressio"</para><para>"ciśnienie"</para><para>"الضغط أو الإجهاد"</para><para>"presión"</para><para>"presiune"</para><para>"दबाव"</para><para>"pressure"</para><para>"فشار، تنش"</para><para>"pressão"</para><para>"压强、压力"</para><para>"Налягане"</para><para>"לחץ"</para><para>"Tekanan"</para><para>"Давление"</para><para>"Tlak"</para><para>"nyomás"</para><para>"pression"</para><para>"Πίεση - τάση"</para><para>"圧力"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Pressure">http://qudt.org/vocab/quantitykind/Pressure</seealso>
    let Pressure = Prefixed_Name(qk, "Pressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedAmountOfSubstanceConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based amount-of-substance concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedAmountOfSubstanceConcentration">http://qudt.org/vocab/quantitykind/PressureBasedAmountOfSubstanceConcentration</seealso>
    let PressureBasedAmountOfSubstanceConcentration =
        Prefixed_Name(qk, "PressureBasedAmountOfSubstanceConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedDensity">http://qudt.org/vocab/quantitykind/PressureBasedDensity</seealso>
    let PressureBasedDensity = Prefixed_Name(qk, "PressureBasedDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedDynamicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based dynamic viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedDynamicViscosity">http://qudt.org/vocab/quantitykind/PressureBasedDynamicViscosity</seealso>
    let PressureBasedDynamicViscosity =
        Prefixed_Name(qk, "PressureBasedDynamicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based electric current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedElectricCurrent">http://qudt.org/vocab/quantitykind/PressureBasedElectricCurrent</seealso>
    let PressureBasedElectricCurrent =
        Prefixed_Name(qk, "PressureBasedElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedElectricVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based electric voltage"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedElectricVoltage">http://qudt.org/vocab/quantitykind/PressureBasedElectricVoltage</seealso>
    let PressureBasedElectricVoltage =
        Prefixed_Name(qk, "PressureBasedElectricVoltage") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedKinematicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based kinematic viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedKinematicViscosity">http://qudt.org/vocab/quantitykind/PressureBasedKinematicViscosity</seealso>
    let PressureBasedKinematicViscosity =
        Prefixed_Name(qk, "PressureBasedKinematicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedLength">http://qudt.org/vocab/quantitykind/PressureBasedLength</seealso>
    let PressureBasedLength = Prefixed_Name(qk, "PressureBasedLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PressureBasedMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedMass">http://qudt.org/vocab/quantitykind/PressureBasedMass</seealso>
    let PressureBasedMass = Prefixed_Name(qk, "PressureBasedMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedMassFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based mass flow"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedMassFlow">http://qudt.org/vocab/quantitykind/PressureBasedMassFlow</seealso>
    let PressureBasedMassFlow =
        Prefixed_Name(qk, "PressureBasedMassFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedMolality</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based molality"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedMolality">http://qudt.org/vocab/quantitykind/PressureBasedMolality</seealso>
    let PressureBasedMolality =
        Prefixed_Name(qk, "PressureBasedMolality") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based quantity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedQuantity">http://qudt.org/vocab/quantitykind/PressureBasedQuantity</seealso>
    let PressureBasedQuantity =
        Prefixed_Name(qk, "PressureBasedQuantity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedTemperature">http://qudt.org/vocab/quantitykind/PressureBasedTemperature</seealso>
    let PressureBasedTemperature =
        Prefixed_Name(qk, "PressureBasedTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedVelocity">http://qudt.org/vocab/quantitykind/PressureBasedVelocity</seealso>
    let PressureBasedVelocity =
        Prefixed_Name(qk, "PressureBasedVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedVolume">http://qudt.org/vocab/quantitykind/PressureBasedVolume</seealso>
    let PressureBasedVolume = Prefixed_Name(qk, "PressureBasedVolume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBasedVolumeFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure-based volume flow"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBasedVolumeFlow">http://qudt.org/vocab/quantitykind/PressureBasedVolumeFlow</seealso>
    let PressureBasedVolumeFlow =
        Prefixed_Name(qk, "PressureBasedVolumeFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBurningRateConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pressure Burning Rate Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBurningRateConstant">http://qudt.org/vocab/quantitykind/PressureBurningRateConstant</seealso>
    let PressureBurningRateConstant =
        Prefixed_Name(qk, "PressureBurningRateConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureBurningRateIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pressure Burning Rate Index"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureBurningRateIndex">http://qudt.org/vocab/quantitykind/PressureBurningRateIndex</seealso>
    let PressureBurningRateIndex =
        Prefixed_Name(qk, "PressureBurningRateIndex") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PressureCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pressure Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureCoefficient">http://qudt.org/vocab/quantitykind/PressureCoefficient</seealso>
    let PressureCoefficient = Prefixed_Name(qk, "PressureCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PressureGradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PressureGradient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pressure gradient"</para><para>"pressure gradient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureGradient">http://qudt.org/vocab/quantitykind/PressureGradient</seealso>
    let PressureGradient = Prefixed_Name(qk, "PressureGradient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureInRelationToVolumeFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"pressure in relation to volume flow"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlow">http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlow</seealso>
    let PressureInRelationToVolumeFlow =
        Prefixed_Name(qk, "PressureInRelationToVolumeFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureInRelationToVolumeFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PressureInRelationToVolumeFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pressure in relation to volume flow rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlowRate">http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlowRate</seealso>
    let PressureInRelationToVolumeFlowRate =
        Prefixed_Name(qk, "PressureInRelationToVolumeFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureLossPerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PressureLossPerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pressure Loss per Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureLossPerLength">http://qudt.org/vocab/quantitykind/PressureLossPerLength</seealso>
    let PressureLossPerLength =
        Prefixed_Name(qk, "PressureLossPerLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PressureRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PressureRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pressure Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PressureRatio">http://qudt.org/vocab/quantitykind/PressureRatio</seealso>
    let PressureRatio = Prefixed_Name(qk, "PressureRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Prevalence</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Prevalence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prevalence"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Prevalence">http://qudt.org/vocab/quantitykind/Prevalence</seealso>
    let Prevalence = Prefixed_Name(qk, "Prevalence") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PrincipalQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PrincipalQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Principal Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PrincipalQuantumNumber">http://qudt.org/vocab/quantitykind/PrincipalQuantumNumber</seealso>
    let PrincipalQuantumNumber =
        Prefixed_Name(qk, "PrincipalQuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ProductOfInertia_X</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia in the X axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ProductOfInertia_X">http://qudt.org/vocab/quantitykind/ProductOfInertia_X</seealso>
    let ProductOfInertia_X = Prefixed_Name(qk, "ProductOfInertia_X") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ProductOfInertia_Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia in the Y axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ProductOfInertia_Y">http://qudt.org/vocab/quantitykind/ProductOfInertia_Y</seealso>
    let ProductOfInertia_Y = Prefixed_Name(qk, "ProductOfInertia_Y") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ProductOfInertia_Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Product of Inertia in the Z axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ProductOfInertia_Z">http://qudt.org/vocab/quantitykind/ProductOfInertia_Z</seealso>
    let ProductOfInertia_Z = Prefixed_Name(qk, "ProductOfInertia_Z") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PropagationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PropagationCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Propagation coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PropagationCoefficient">http://qudt.org/vocab/quantitykind/PropagationCoefficient</seealso>
    let PropagationCoefficient =
        Prefixed_Name(qk, "PropagationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PropellantBurnRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PropellantBurnRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Propellant Burn Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PropellantBurnRate">http://qudt.org/vocab/quantitykind/PropellantBurnRate</seealso>
    let PropellantBurnRate = Prefixed_Name(qk, "PropellantBurnRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/PropellantMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Propellant Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PropellantMass">http://qudt.org/vocab/quantitykind/PropellantMass</seealso>
    let PropellantMass = Prefixed_Name(qk, "PropellantMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PropellantMeanBulkTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Propellant Mean Bulk Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PropellantMeanBulkTemperature">http://qudt.org/vocab/quantitykind/PropellantMeanBulkTemperature</seealso>
    let PropellantMeanBulkTemperature =
        Prefixed_Name(qk, "PropellantMeanBulkTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/PropellantTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Propellant Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/PropellantTemperature">http://qudt.org/vocab/quantitykind/PropellantTemperature</seealso>
    let PropellantTemperature =
        Prefixed_Name(qk, "PropellantTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/QualityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:QualityFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quality Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/QualityFactor">http://qudt.org/vocab/quantitykind/QualityFactor</seealso>
    let QualityFactor = Prefixed_Name(qk, "QualityFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/QuantityOfLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"quantity of light"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"quantity of light"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/QuantityOfLight">http://qudt.org/vocab/quantitykind/QuantityOfLight</seealso>
    let QuantityOfLight = Prefixed_Name(qk, "QuantityOfLight") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/QuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:QuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/QuantumNumber">http://qudt.org/vocab/quantitykind/QuantumNumber</seealso>
    let QuantumNumber = Prefixed_Name(qk, "QuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/QuarticElectricDipoleMomentPerCubicEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:QuarticElectricDipoleMomentPerCubicEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quartic Electric Dipole Moment per Cubic Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/QuarticElectricDipoleMomentPerCubicEnergy">http://qudt.org/vocab/quantitykind/QuarticElectricDipoleMomentPerCubicEnergy</seealso>
    let QuarticElectricDipoleMomentPerCubicEnergy =
        Prefixed_Name(qk, "QuarticElectricDipoleMomentPerCubicEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RESERVE-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reserve Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RESERVE-MASS">http://qudt.org/vocab/quantitykind/RESERVE-MASS</seealso>
    let RESERVE_MASS = Prefixed_Name(qk, "RESERVE-MASS") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RF-Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricField"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RF-Power Level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RF-Power">http://qudt.org/vocab/quantitykind/RF-Power</seealso>
    let RF_Power = Prefixed_Name(qk, "RF-Power") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadialDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radial Distance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadialDistance">http://qudt.org/vocab/quantitykind/RadialDistance</seealso>
    let RadialDistance = Prefixed_Name(qk, "RadialDistance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Radiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Radiance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Radiance">http://qudt.org/vocab/quantitykind/Radiance</seealso>
    let Radiance = Prefixed_Name(qk, "Radiance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadianceFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RadianceFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiance Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadianceFactor">http://qudt.org/vocab/quantitykind/RadianceFactor</seealso>
    let RadianceFactor = Prefixed_Name(qk, "RadianceFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantEmmitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiant Emmitance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantEmmitance">http://qudt.org/vocab/quantitykind/RadiantEmmitance</seealso>
    let RadiantEmmitance = Prefixed_Name(qk, "RadiantEmmitance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"विकिरण ऊर्जा"</para><para>"energía radiante"</para><para>"energia radiante"</para><para>"energie záření"</para><para>"radiant energy"</para><para>"energia promienista"</para><para>"énergie rayonnante"</para><para>"Strahlungsenergie"</para><para>"طاقة إشعاعية"</para><para>"энергия излучения"</para><para>"Tenaga sinaran"</para><para>"辐射能"</para><para>"放射エネルギー"</para><para>"Işınım erkesi"</para><para>"انرژی تابشی"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantEnergy">http://qudt.org/vocab/quantitykind/RadiantEnergy</seealso>
    let RadiantEnergy = Prefixed_Name(qk, "RadiantEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantEnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RadiantEnergyDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiant Energy Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantEnergyDensity">http://qudt.org/vocab/quantitykind/RadiantEnergyDensity</seealso>
    let RadiantEnergyDensity = Prefixed_Name(qk, "RadiantEnergyDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RadiantEnergyExposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"radiant energy exposure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantEnergyExposure">http://qudt.org/vocab/quantitykind/RadiantEnergyExposure</seealso>
    let RadiantEnergyExposure =
        Prefixed_Name(qk, "RadiantEnergyExposure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RadiantExposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiant Exposure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantExposure">http://qudt.org/vocab/quantitykind/RadiantExposure</seealso>
    let RadiantExposure = Prefixed_Name(qk, "RadiantExposure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantFluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RadiantFluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiant Fluence"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantFluence">http://qudt.org/vocab/quantitykind/RadiantFluence</seealso>
    let RadiantFluence = Prefixed_Name(qk, "RadiantFluence") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantFluenceRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiant Fluence Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantFluenceRate">http://qudt.org/vocab/quantitykind/RadiantFluenceRate</seealso>
    let RadiantFluenceRate = Prefixed_Name(qk, "RadiantFluenceRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"potencia radiante"</para><para>"flusso radiante"</para><para>"flux énergétique"</para><para>"moc promieniowania"</para><para>"radiant flux"</para><para>"potência radiante"</para><para>"放射パワー"</para><para>"قدرة إشعاعية"</para><para>"Strahlungsfluss"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantFlux">http://qudt.org/vocab/quantitykind/RadiantFlux</seealso>
    let RadiantFlux = Prefixed_Name(qk, "RadiantFlux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiantIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RadiantIntensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiant Intensity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiantIntensity">http://qudt.org/vocab/quantitykind/RadiantIntensity</seealso>
    let RadiantIntensity = Prefixed_Name(qk, "RadiantIntensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RadiativeHeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HeatFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiative Heat Transfer"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiativeHeatTransfer">http://qudt.org/vocab/quantitykind/RadiativeHeatTransfer</seealso>
    let RadiativeHeatTransfer =
        Prefixed_Name(qk, "RadiativeHeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RadioactiveDecay</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"radioactive decay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadioactiveDecay">http://qudt.org/vocab/quantitykind/RadioactiveDecay</seealso>
    let RadioactiveDecay = Prefixed_Name(qk, "RadioactiveDecay") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Radioactivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"radioactivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Radioactivity">http://qudt.org/vocab/quantitykind/Radioactivity</seealso>
    let Radioactivity = Prefixed_Name(qk, "Radioactivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Radiosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Radiosity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Radiosity">http://qudt.org/vocab/quantitykind/Radiosity</seealso>
    let Radiosity = Prefixed_Name(qk, "Radiosity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Radius">http://qudt.org/vocab/quantitykind/Radius</seealso>
    let Radius = Prefixed_Name(qk, "Radius") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RadiusOfCurvature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radius of Curvature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RadiusOfCurvature">http://qudt.org/vocab/quantitykind/RadiusOfCurvature</seealso>
    let RadiusOfCurvature = Prefixed_Name(qk, "RadiusOfCurvature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RankineTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermodynamicTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rankine temperature"</para><para>"Rankine temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RankineTemperature">http://qudt.org/vocab/quantitykind/RankineTemperature</seealso>
    let RankineTemperature = Prefixed_Name(qk, "RankineTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RateOfChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RateOfChange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rate of Change"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RateOfChange">http://qudt.org/vocab/quantitykind/RateOfChange</seealso>
    let RateOfChange = Prefixed_Name(qk, "RateOfChange") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RateOfRiseOfVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"rate of rise of voltage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RateOfRiseOfVoltage">http://qudt.org/vocab/quantitykind/RateOfRiseOfVoltage</seealso>
    let RateOfRiseOfVoltage = Prefixed_Name(qk, "RateOfRiseOfVoltage") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Ratio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ratio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Ratio">http://qudt.org/vocab/quantitykind/Ratio</seealso>
    let Ratio = Prefixed_Name(qk, "Ratio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RatioOfSpecificHeatCapacities</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RatioOfSpecificHeatCapacities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ratio of Specific Heat Capacities"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RatioOfSpecificHeatCapacities">http://qudt.org/vocab/quantitykind/RatioOfSpecificHeatCapacities</seealso>
    let RatioOfSpecificHeatCapacities =
        Prefixed_Name(qk, "RatioOfSpecificHeatCapacities") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Reactance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Reactance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reactance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Reactance">http://qudt.org/vocab/quantitykind/Reactance</seealso>
    let Reactance = Prefixed_Name(qk, "Reactance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReactionEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reaction Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReactionEnergy">http://qudt.org/vocab/quantitykind/ReactionEnergy</seealso>
    let ReactionEnergy = Prefixed_Name(qk, "ReactionEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReactiveCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReactiveCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reactive Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReactiveCharge">http://qudt.org/vocab/quantitykind/ReactiveCharge</seealso>
    let ReactiveCharge = Prefixed_Name(qk, "ReactiveCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ReactiveChargePerMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReactiveChargePerMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reactive Charge per Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReactiveChargePerMass">http://qudt.org/vocab/quantitykind/ReactiveChargePerMass</seealso>
    let ReactiveChargePerMass =
        Prefixed_Name(qk, "ReactiveChargePerMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ReactivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReactivePower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"puissance réactive"</para><para>"توان راکتیو"</para><para>"potenza reattiva"</para><para>"potência reativa"</para><para>"Jalový výkon"</para><para>"potencia reactiva"</para><para>"reactive power"</para><para>"无功功率"</para><para>"moc bierna"</para><para>"القدرة الكهربائية الردفعلية;الردية"</para><para>"Kuasa reaktif"</para><para>"Blindleistung"</para><para>"reaktif güç"</para><para>"無効電力"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReactivePower">http://qudt.org/vocab/quantitykind/ReactivePower</seealso>
    let ReactivePower = Prefixed_Name(qk, "ReactivePower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Reactivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Reactivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reactivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Reactivity">http://qudt.org/vocab/quantitykind/Reactivity</seealso>
    let Reactivity = Prefixed_Name(qk, "Reactivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReactorTimeConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reactor Time Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReactorTimeConstant">http://qudt.org/vocab/quantitykind/ReactorTimeConstant</seealso>
    let ReactorTimeConstant = Prefixed_Name(qk, "ReactorTimeConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ReciprocalElectricResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"reciprocal electric resistance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReciprocalElectricResistance">http://qudt.org/vocab/quantitykind/ReciprocalElectricResistance</seealso>
    let ReciprocalElectricResistance =
        Prefixed_Name(qk, "ReciprocalElectricResistance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ReciprocalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"reciprocal energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReciprocalEnergy">http://qudt.org/vocab/quantitykind/ReciprocalEnergy</seealso>
    let ReciprocalEnergy = Prefixed_Name(qk, "ReciprocalEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReciprocalPlaneAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"reciprocal plane angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReciprocalPlaneAngle">http://qudt.org/vocab/quantitykind/ReciprocalPlaneAngle</seealso>
    let ReciprocalPlaneAngle = Prefixed_Name(qk, "ReciprocalPlaneAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReciprocalVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReciprocalVoltage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reciprocal voltage"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReciprocalVoltage">http://qudt.org/vocab/quantitykind/ReciprocalVoltage</seealso>
    let ReciprocalVoltage = Prefixed_Name(qk, "ReciprocalVoltage") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RecombinationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RecombinationCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Recombination Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RecombinationCoefficient">http://qudt.org/vocab/quantitykind/RecombinationCoefficient</seealso>
    let RecombinationCoefficient =
        Prefixed_Name(qk, "RecombinationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Reflectance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Reflectance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reflectance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Reflectance">http://qudt.org/vocab/quantitykind/Reflectance</seealso>
    let Reflectance = Prefixed_Name(qk, "Reflectance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReflectanceFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReflectanceFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reflectance Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReflectanceFactor">http://qudt.org/vocab/quantitykind/ReflectanceFactor</seealso>
    let ReflectanceFactor = Prefixed_Name(qk, "ReflectanceFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Reflectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Reflectance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reflectivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Reflectivity">http://qudt.org/vocab/quantitykind/Reflectivity</seealso>
    let Reflectivity = Prefixed_Name(qk, "Reflectivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RefractiveIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RefractiveIndex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kırılma indeksi"</para><para>"índice de refracción"</para><para>"अपवर्तनांक"</para><para>"ضریب شکست"</para><para>"Brechzahl"</para><para>"refractive index"</para><para>"Indice de refracție"</para><para>"屈折率"</para><para>"índice refrativo"</para><para>"Indeks biasan"</para><para>"折射率"</para><para>"Współczynnik załamania"</para><para>"indice de réfraction"</para><para>"معامل الانكسار"</para><para>"Index lomu"</para><para>"Показатель преломления"</para><para>"indice di rifrazione"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RefractiveIndex">http://qudt.org/vocab/quantitykind/RefractiveIndex</seealso>
    let RefractiveIndex = Prefixed_Name(qk, "RefractiveIndex") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RelativeAtomicMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Atomic Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeAtomicMass">http://qudt.org/vocab/quantitykind/RelativeAtomicMass</seealso>
    let RelativeAtomicMass = Prefixed_Name(qk, "RelativeAtomicMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RelativeHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativeHumidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Humidity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeHumidity">http://qudt.org/vocab/quantitykind/RelativeHumidity</seealso>
    let RelativeHumidity = Prefixed_Name(qk, "RelativeHumidity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativeMassConcentrationOfVapour</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativeMassConcentrationOfVapour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Mass Concentration of Vapour"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeMassConcentrationOfVapour">http://qudt.org/vocab/quantitykind/RelativeMassConcentrationOfVapour</seealso>
    let RelativeMassConcentrationOfVapour =
        Prefixed_Name(qk, "RelativeMassConcentrationOfVapour") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativeMassDefect</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Mass Defect"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeMassDefect">http://qudt.org/vocab/quantitykind/RelativeMassDefect</seealso>
    let RelativeMassDefect = Prefixed_Name(qk, "RelativeMassDefect") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RelativeMassDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativeMassDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Mass Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeMassDensity">http://qudt.org/vocab/quantitykind/RelativeMassDensity</seealso>
    let RelativeMassDensity = Prefixed_Name(qk, "RelativeMassDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RelativeMassExcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativeMassExcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Mass Excess"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeMassExcess">http://qudt.org/vocab/quantitykind/RelativeMassExcess</seealso>
    let RelativeMassExcess = Prefixed_Name(qk, "RelativeMassExcess") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativeMassRatioOfVapour</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativeMassRatioOfVapour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Mass Ratio of Vapour"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeMassRatioOfVapour">http://qudt.org/vocab/quantitykind/RelativeMassRatioOfVapour</seealso>
    let RelativeMassRatioOfVapour =
        Prefixed_Name(qk, "RelativeMassRatioOfVapour") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativeMolecularMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Molecular Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativeMolecularMass">http://qudt.org/vocab/quantitykind/RelativeMolecularMass</seealso>
    let RelativeMolecularMass =
        Prefixed_Name(qk, "RelativeMolecularMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativePartialPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativePartialPressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Partial Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativePartialPressure">http://qudt.org/vocab/quantitykind/RelativePartialPressure</seealso>
    let RelativePartialPressure =
        Prefixed_Name(qk, "RelativePartialPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativePermittivity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativePermittivity">http://qudt.org/vocab/quantitykind/RelativePermittivity</seealso>
    let RelativePermittivity = Prefixed_Name(qk, "RelativePermittivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelativePressureCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RelativePressureCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relative Pressure Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelativePressureCoefficient">http://qudt.org/vocab/quantitykind/RelativePressureCoefficient</seealso>
    let RelativePressureCoefficient =
        Prefixed_Name(qk, "RelativePressureCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RelaxationTIme</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relaxation TIme"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RelaxationTIme">http://qudt.org/vocab/quantitykind/RelaxationTIme</seealso>
    let RelaxationTIme = Prefixed_Name(qk, "RelaxationTIme") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Reluctance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Reluctance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reluctance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Reluctance">http://qudt.org/vocab/quantitykind/Reluctance</seealso>
    let Reluctance = Prefixed_Name(qk, "Reluctance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Repetency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Repetency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"repetency"</para><para>"repetency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Repetency">http://qudt.org/vocab/quantitykind/Repetency</seealso>
    let Repetency = Prefixed_Name(qk, "Repetency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ResidualResistivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ResidualResistivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Residual Resistivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ResidualResistivity">http://qudt.org/vocab/quantitykind/ResidualResistivity</seealso>
    let ResidualResistivity = Prefixed_Name(qk, "ResidualResistivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Resistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Resistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resistance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Resistance">http://qudt.org/vocab/quantitykind/Resistance</seealso>
    let Resistance = Prefixed_Name(qk, "Resistance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ResistanceBasedInductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"resistance-based inductance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ResistanceBasedInductance">http://qudt.org/vocab/quantitykind/ResistanceBasedInductance</seealso>
    let ResistanceBasedInductance =
        Prefixed_Name(qk, "ResistanceBasedInductance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ResistanceRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ResistanceRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resistance Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ResistanceRatio">http://qudt.org/vocab/quantitykind/ResistanceRatio</seealso>
    let ResistanceRatio = Prefixed_Name(qk, "ResistanceRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Resistivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Resistivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resistivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Resistivity">http://qudt.org/vocab/quantitykind/Resistivity</seealso>
    let Resistivity = Prefixed_Name(qk, "Resistivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ResonanceEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resonance Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ResonanceEnergy">http://qudt.org/vocab/quantitykind/ResonanceEnergy</seealso>
    let ResonanceEnergy = Prefixed_Name(qk, "ResonanceEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ResonanceEscapeProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ResonanceEscapeProbability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resonance Escape Probability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ResonanceEscapeProbability">http://qudt.org/vocab/quantitykind/ResonanceEscapeProbability</seealso>
    let ResonanceEscapeProbability =
        Prefixed_Name(qk, "ResonanceEscapeProbability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ResonanceEscapeProbabilityForFission</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resonance Escape Probability For Fission"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ResonanceEscapeProbabilityForFission">http://qudt.org/vocab/quantitykind/ResonanceEscapeProbabilityForFission</seealso>
    let ResonanceEscapeProbabilityForFission =
        Prefixed_Name(qk, "ResonanceEscapeProbabilityForFission") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RespiratoryRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RespiratoryRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Respiratory Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RespiratoryRate">http://qudt.org/vocab/quantitykind/RespiratoryRate</seealso>
    let RespiratoryRate = Prefixed_Name(qk, "RespiratoryRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RestEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rest Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RestEnergy">http://qudt.org/vocab/quantitykind/RestEnergy</seealso>
    let RestEnergy = Prefixed_Name(qk, "RestEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RestMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"massa de repouso"</para><para>"निश्चर द्रव्यमान"</para><para>"masa spoczynkowa"</para><para>"dinlenme kütlesi"</para><para>"инвариантная масса"</para><para>"静止质量"</para><para>"Klidová hmotnost"</para><para>"massa a riposo"</para><para>"rest mass"</para><para>"Ruhemasse"</para><para>"masa invariante"</para><para>"不変質量"</para><para>"Jisim rehat"</para><para>"كتلة ساكنة"</para><para>"masa invariantă"</para><para>"masse au repos"</para><para>"جرم سکون"</para><para>"Mirovna masa"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RestMass">http://qudt.org/vocab/quantitykind/RestMass</seealso>
    let RestMass = Prefixed_Name(qk, "RestMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReverberationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reverberation Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReverberationTime">http://qudt.org/vocab/quantitykind/ReverberationTime</seealso>
    let ReverberationTime = Prefixed_Name(qk, "ReverberationTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ReynoldsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReynoldsNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reynolds Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ReynoldsNumber">http://qudt.org/vocab/quantitykind/ReynoldsNumber</seealso>
    let ReynoldsNumber = Prefixed_Name(qk, "ReynoldsNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RichardsonConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RichardsonConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Richardson Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RichardsonConstant">http://qudt.org/vocab/quantitykind/RichardsonConstant</seealso>
    let RichardsonConstant = Prefixed_Name(qk, "RichardsonConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RiseOfOffStateVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"rise of off-state voltage"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RiseOfOffStateVoltage">http://qudt.org/vocab/quantitykind/RiseOfOffStateVoltage</seealso>
    let RiseOfOffStateVoltage =
        Prefixed_Name(qk, "RiseOfOffStateVoltage") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RocketAtmosphericTransverseForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rocket Atmospheric Transverse Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RocketAtmosphericTransverseForce">http://qudt.org/vocab/quantitykind/RocketAtmosphericTransverseForce</seealso>
    let RocketAtmosphericTransverseForce =
        Prefixed_Name(qk, "RocketAtmosphericTransverseForce") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Rotary-TranslatoryMotionConversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Rotary-TranslatoryMotionConversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rotary-translatory motion conversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Rotary-TranslatoryMotionConversion">http://qudt.org/vocab/quantitykind/Rotary-TranslatoryMotionConversion</seealso>
    let Rotary_TranslatoryMotionConversion =
        Prefixed_Name(qk, "Rotary-TranslatoryMotionConversion") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/RotaryShock</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"rotary shock"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RotaryShock">http://qudt.org/vocab/quantitykind/RotaryShock</seealso>
    let RotaryShock = Prefixed_Name(qk, "RotaryShock") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RotationalFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RotationalFrequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RotationalFrequency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RotationalFrequency">http://qudt.org/vocab/quantitykind/RotationalFrequency</seealso>
    let RotationalFrequency = Prefixed_Name(qk, "RotationalFrequency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RotationalMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RotationalMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rotational Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RotationalMass">http://qudt.org/vocab/quantitykind/RotationalMass</seealso>
    let RotationalMass = Prefixed_Name(qk, "RotationalMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RotationalStiffness</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TorquePerAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rotational Stiffness"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RotationalStiffness">http://qudt.org/vocab/quantitykind/RotationalStiffness</seealso>
    let RotationalStiffness = Prefixed_Name(qk, "RotationalStiffness") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/RotationalVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:RotationalVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RotationalFrequency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/RotationalVelocity">http://qudt.org/vocab/quantitykind/RotationalVelocity</seealso>
    let RotationalVelocity = Prefixed_Name(qk, "RotationalVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ScalarMagneticPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ScalarMagneticPotential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scalar Magnetic Potential"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ScalarMagneticPotential">http://qudt.org/vocab/quantitykind/ScalarMagneticPotential</seealso>
    let ScalarMagneticPotential =
        Prefixed_Name(qk, "ScalarMagneticPotential") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SecondAxialMomentOfArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SecondAxialMomentOfArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Second Axial Moment of Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SecondAxialMomentOfArea">http://qudt.org/vocab/quantitykind/SecondAxialMomentOfArea</seealso>
    let SecondAxialMomentOfArea =
        Prefixed_Name(qk, "SecondAxialMomentOfArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SecondMomentOfArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SecondMomentOfArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"moment quadratique"</para><para>"second moment of area"</para><para>"截面二次轴矩"</para><para>"Segundo momento de área"</para><para>"secondo momento di area"</para><para>"گشتاور دوم سطح"</para><para>"segundo momento de érea"</para><para>"Flächenträgheitsmoment"</para><para>"क्षेत्रफल का द्वितीय आघूर्ण"</para><para>"Geometryczny moment bezwładności"</para><para>"断面二次モーメント"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SecondMomentOfArea">http://qudt.org/vocab/quantitykind/SecondMomentOfArea</seealso>
    let SecondMomentOfArea = Prefixed_Name(qk, "SecondMomentOfArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SecondOrderReactionRateConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SecondOrderReactionRateConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reaction Rate Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SecondOrderReactionRateConstant">http://qudt.org/vocab/quantitykind/SecondOrderReactionRateConstant</seealso>
    let SecondOrderReactionRateConstant =
        Prefixed_Name(qk, "SecondOrderReactionRateConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SecondPolarMomentOfArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SecondPolarMomentOfArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Second Polar Moment of Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SecondPolarMomentOfArea">http://qudt.org/vocab/quantitykind/SecondPolarMomentOfArea</seealso>
    let SecondPolarMomentOfArea =
        Prefixed_Name(qk, "SecondPolarMomentOfArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SecondRadiationConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"second radiation constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SecondRadiationConstant">http://qudt.org/vocab/quantitykind/SecondRadiationConstant</seealso>
    let SecondRadiationConstant =
        Prefixed_Name(qk, "SecondRadiationConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SecondStageMassRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Second Stage Mass Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SecondStageMassRatio">http://qudt.org/vocab/quantitykind/SecondStageMassRatio</seealso>
    let SecondStageMassRatio = Prefixed_Name(qk, "SecondStageMassRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SectionAreaIntegral</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SectionAreaIntegral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Section Area Integral"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SectionAreaIntegral">http://qudt.org/vocab/quantitykind/SectionAreaIntegral</seealso>
    let SectionAreaIntegral = Prefixed_Name(qk, "SectionAreaIntegral") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SectionModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SectionModulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Section Modulus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SectionModulus">http://qudt.org/vocab/quantitykind/SectionModulus</seealso>
    let SectionModulus = Prefixed_Name(qk, "SectionModulus") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SeebeckCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SeebeckCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seebeck Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SeebeckCoefficient">http://qudt.org/vocab/quantitykind/SeebeckCoefficient</seealso>
    let SeebeckCoefficient = Prefixed_Name(qk, "SeebeckCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SerumLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SerumLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Serum Level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SerumLevel">http://qudt.org/vocab/quantitykind/SerumLevel</seealso>
    let SerumLevel = Prefixed_Name(qk, "SerumLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SerumOrPlasmaLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Serum or Plasma Level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SerumOrPlasmaLevel">http://qudt.org/vocab/quantitykind/SerumOrPlasmaLevel</seealso>
    let SerumOrPlasmaLevel = Prefixed_Name(qk, "SerumOrPlasmaLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ServiceFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ServiceFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ServiceFactor">http://qudt.org/vocab/quantitykind/ServiceFactor</seealso>
    let ServiceFactor = Prefixed_Name(qk, "ServiceFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ShannonDiversityIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InformationEntropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shannon Diversity Index"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ShannonDiversityIndex">http://qudt.org/vocab/quantitykind/ShannonDiversityIndex</seealso>
    let ShannonDiversityIndex =
        Prefixed_Name(qk, "ShannonDiversityIndex") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ShearModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ShearModulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shear Modulus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ShearModulus">http://qudt.org/vocab/quantitykind/ShearModulus</seealso>
    let ShearModulus = Prefixed_Name(qk, "ShearModulus") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ShearStrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shear Strain"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ShearStrain">http://qudt.org/vocab/quantitykind/ShearStrain</seealso>
    let ShearStrain = Prefixed_Name(qk, "ShearStrain") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ShearStress</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shear Stress"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ShearStress">http://qudt.org/vocab/quantitykind/ShearStress</seealso>
    let ShearStress = Prefixed_Name(qk, "ShearStress") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Short-RangeOrderParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Short-RangeOrderParameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Short-Range Order Parameter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Short-RangeOrderParameter">http://qudt.org/vocab/quantitykind/Short-RangeOrderParameter</seealso>
    let Short_RangeOrderParameter =
        Prefixed_Name(qk, "Short-RangeOrderParameter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SignalDetectionThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SignalDetectionThreshold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Signal Detection Threshold"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SignalDetectionThreshold">http://qudt.org/vocab/quantitykind/SignalDetectionThreshold</seealso>
    let SignalDetectionThreshold =
        Prefixed_Name(qk, "SignalDetectionThreshold") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SignalStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricField"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Signal Strength"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SignalStrength">http://qudt.org/vocab/quantitykind/SignalStrength</seealso>
    let SignalStrength = Prefixed_Name(qk, "SignalStrength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SingleStageLauncherMassRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Single Stage Launcher Mass Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SingleStageLauncherMassRatio">http://qudt.org/vocab/quantitykind/SingleStageLauncherMassRatio</seealso>
    let SingleStageLauncherMassRatio =
        Prefixed_Name(qk, "SingleStageLauncherMassRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Slowing-DownArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Slowing-Down Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Slowing-DownArea">http://qudt.org/vocab/quantitykind/Slowing-DownArea</seealso>
    let Slowing_DownArea = Prefixed_Name(qk, "Slowing-DownArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Slowing-DownDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Slowing-DownDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Slowing-Down Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Slowing-DownDensity">http://qudt.org/vocab/quantitykind/Slowing-DownDensity</seealso>
    let Slowing_DownDensity = Prefixed_Name(qk, "Slowing-DownDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Slowing-DownLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Slowing-Down Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Slowing-DownLength">http://qudt.org/vocab/quantitykind/Slowing-DownLength</seealso>
    let Slowing_DownLength = Prefixed_Name(qk, "Slowing-DownLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SoilAdsorptionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoilAdsorptionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soil Adsorption Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoilAdsorptionCoefficient">http://qudt.org/vocab/quantitykind/SoilAdsorptionCoefficient</seealso>
    let SoilAdsorptionCoefficient =
        Prefixed_Name(qk, "SoilAdsorptionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SolidAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SolidAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"angle solide"</para><para>"Prostorový úhel"</para><para>"solid angle"</para><para>"unghi solid"</para><para>"katı cisimdeki açı"</para><para>"立体角度"</para><para>"Телесный угол"</para><para>"kąt bryłowy"</para><para>"Raumwinkel"</para><para>"زاویه فضایی"</para><para>"Στερεά γωνία"</para><para>"आयतन"</para><para>"Sudut padu"</para><para>"זווית מרחבית"</para><para>"ângulo sólido"</para><para>"الزاوية الصلبة"</para><para>"térszög"</para><para>"立体角"</para><para>"prostorski kot"</para><para>"ángulo sólido"</para><para>"angulus solidus"</para><para>"Пространствен ъгъл"</para><para>"angolo solido"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SolidAngle">http://qudt.org/vocab/quantitykind/SolidAngle</seealso>
    let SolidAngle = Prefixed_Name(qk, "SolidAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SolidStateDiffusionLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diffusion Length (Solid State Physics)"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SolidStateDiffusionLength">http://qudt.org/vocab/quantitykind/SolidStateDiffusionLength</seealso>
    let SolidStateDiffusionLength =
        Prefixed_Name(qk, "SolidStateDiffusionLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Solubility_Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Water Solubility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Solubility_Water">http://qudt.org/vocab/quantitykind/Solubility_Water</seealso>
    let Solubility_Water = Prefixed_Name(qk, "Solubility_Water") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundEnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound energy density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundEnergyDensity">http://qudt.org/vocab/quantitykind/SoundEnergyDensity</seealso>
    let SoundEnergyDensity = Prefixed_Name(qk, "SoundEnergyDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundExposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundExposure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound exposure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundExposure">http://qudt.org/vocab/quantitykind/SoundExposure</seealso>
    let SoundExposure = Prefixed_Name(qk, "SoundExposure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundExposureLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundExposureLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound exposure level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundExposureLevel">http://qudt.org/vocab/quantitykind/SoundExposureLevel</seealso>
    let SoundExposureLevel = Prefixed_Name(qk, "SoundExposureLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound intensity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundIntensity">http://qudt.org/vocab/quantitykind/SoundIntensity</seealso>
    let SoundIntensity = Prefixed_Name(qk, "SoundIntensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SoundParticleAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Acceleration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound particle acceleration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundParticleAcceleration">http://qudt.org/vocab/quantitykind/SoundParticleAcceleration</seealso>
    let SoundParticleAcceleration =
        Prefixed_Name(qk, "SoundParticleAcceleration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SoundParticleDisplacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound Particle Displacement"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundParticleDisplacement">http://qudt.org/vocab/quantitykind/SoundParticleDisplacement</seealso>
    let SoundParticleDisplacement =
        Prefixed_Name(qk, "SoundParticleDisplacement") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SoundParticleVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundParticleVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"velocità di spostamento"</para><para>"粒子速度"</para><para>"velocidade acústica de uma partícula"</para><para>"prędkość akustyczna"</para><para>"Schallschnelle"</para><para>"سرعة جسيم"</para><para>"vitesse  acoustique d‘une particule"</para><para>"velocidad acústica de una partícula"</para><para>"sound particle velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundParticleVelocity">http://qudt.org/vocab/quantitykind/SoundParticleVelocity</seealso>
    let SoundParticleVelocity =
        Prefixed_Name(qk, "SoundParticleVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SoundPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"puissance acoustique"</para><para>"potência acústica"</para><para>"sound power"</para><para>"moc akustyczna"</para><para>"potenza sonora"</para><para>"potencie acústica"</para><para>"音源の音響出力"</para><para>"Schallleistung"</para><para>"звуковая мощность"</para><para>"القدرة الصوتية"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundPower">http://qudt.org/vocab/quantitykind/SoundPower</seealso>
    let SoundPower = Prefixed_Name(qk, "SoundPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundPowerLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundPowerLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound power level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundPowerLevel">http://qudt.org/vocab/quantitykind/SoundPowerLevel</seealso>
    let SoundPowerLevel = Prefixed_Name(qk, "SoundPowerLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundPressure">http://qudt.org/vocab/quantitykind/SoundPressure</seealso>
    let SoundPressure = Prefixed_Name(qk, "SoundPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundPressureLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundPressureLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nivel de presión sonora"</para><para>"كمية جذر الطاقة"</para><para>"声压级"</para><para>"sound pressure level"</para><para>"miary wielkości ilorazowych"</para><para>"nível de pressão acústica"</para><para>"Schalldruckpegel"</para><para>"利得"</para><para>"gerilim veya akım oranı"</para><para>"livello di pressione sonora"</para><para>"Tahap medan"</para><para>"سطح یک کمیت توان-ریشه"</para><para>"Hladina akustického tlaku"</para><para>"niveau de pression acoustique"</para><para>"уровень звукового давления"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundPressureLevel">http://qudt.org/vocab/quantitykind/SoundPressureLevel</seealso>
    let SoundPressureLevel = Prefixed_Name(qk, "SoundPressureLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundReductionIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundReductionIndex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound reduction index"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundReductionIndex">http://qudt.org/vocab/quantitykind/SoundReductionIndex</seealso>
    let SoundReductionIndex = Prefixed_Name(qk, "SoundReductionIndex") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SoundVolumeVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundVolumeVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sound volume velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SoundVolumeVelocity">http://qudt.org/vocab/quantitykind/SoundVolumeVelocity</seealso>
    let SoundVolumeVelocity = Prefixed_Name(qk, "SoundVolumeVelocity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SourceVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Voltage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source Voltage"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SourceVoltage">http://qudt.org/vocab/quantitykind/SourceVoltage</seealso>
    let SourceVoltage = Prefixed_Name(qk, "SourceVoltage") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SourceVoltageBetweenSubstances</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Voltage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source Voltage Between Substances"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SourceVoltageBetweenSubstances">http://qudt.org/vocab/quantitykind/SourceVoltageBetweenSubstances</seealso>
    let SourceVoltageBetweenSubstances =
        Prefixed_Name(qk, "SourceVoltageBetweenSubstances") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpatialSummationFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spatial Summation Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpatialSummationFunction">http://qudt.org/vocab/quantitykind/SpatialSummationFunction</seealso>
    let SpatialSummationFunction =
        Prefixed_Name(qk, "SpatialSummationFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificAcousticImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificAcousticImpedance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Acoustic Impedance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificAcousticImpedance">http://qudt.org/vocab/quantitykind/SpecificAcousticImpedance</seealso>
    let SpecificAcousticImpedance =
        Prefixed_Name(qk, "SpecificAcousticImpedance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Activity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificActivity">http://qudt.org/vocab/quantitykind/SpecificActivity</seealso>
    let SpecificActivity = Prefixed_Name(qk, "SpecificActivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Electric Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificElectricCharge">http://qudt.org/vocab/quantitykind/SpecificElectricCharge</seealso>
    let SpecificElectricCharge =
        Prefixed_Name(qk, "SpecificElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificElectricCurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Electrical Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificElectricCurrent">http://qudt.org/vocab/quantitykind/SpecificElectricCurrent</seealso>
    let SpecificElectricCurrent =
        Prefixed_Name(qk, "SpecificElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificEnergy">http://qudt.org/vocab/quantitykind/SpecificEnergy</seealso>
    let SpecificEnergy = Prefixed_Name(qk, "SpecificEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificEnergyImparted</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Energy Imparted"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificEnergyImparted">http://qudt.org/vocab/quantitykind/SpecificEnergyImparted</seealso>
    let SpecificEnergyImparted =
        Prefixed_Name(qk, "SpecificEnergyImparted") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificEnthalpy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Enthalpy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificEnthalpy">http://qudt.org/vocab/quantitykind/SpecificEnthalpy</seealso>
    let SpecificEnthalpy = Prefixed_Name(qk, "SpecificEnthalpy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificEntropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEntropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Entropy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificEntropy">http://qudt.org/vocab/quantitykind/SpecificEntropy</seealso>
    let SpecificEntropy = Prefixed_Name(qk, "SpecificEntropy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificGibbsEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Gibbs Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificGibbsEnergy">http://qudt.org/vocab/quantitykind/SpecificGibbsEnergy</seealso>
    let SpecificGibbsEnergy = Prefixed_Name(qk, "SpecificGibbsEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificHeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Heat Capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacity">http://qudt.org/vocab/quantitykind/SpecificHeatCapacity</seealso>
    let SpecificHeatCapacity = Prefixed_Name(qk, "SpecificHeatCapacity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificHeatCapacityAtConstantPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatCapacityAtConstantPressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific heat capacity at constant pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantPressure">http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantPressure</seealso>
    let SpecificHeatCapacityAtConstantPressure =
        Prefixed_Name(qk, "SpecificHeatCapacityAtConstantPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificHeatCapacityAtConstantVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatCapacityAtConstantVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific heat capacity at constant volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantVolume">http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantVolume</seealso>
    let SpecificHeatCapacityAtConstantVolume =
        Prefixed_Name(qk, "SpecificHeatCapacityAtConstantVolume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificHeatCapacityAtSaturation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatCapacityAtSaturation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Heat Capacity at Saturation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtSaturation">http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtSaturation</seealso>
    let SpecificHeatCapacityAtSaturation =
        Prefixed_Name(qk, "SpecificHeatCapacityAtSaturation") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificHeatPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatPressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Heat Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatPressure">http://qudt.org/vocab/quantitykind/SpecificHeatPressure</seealso>
    let SpecificHeatPressure = Prefixed_Name(qk, "SpecificHeatPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificHeatVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Heat Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatVolume">http://qudt.org/vocab/quantitykind/SpecificHeatVolume</seealso>
    let SpecificHeatVolume = Prefixed_Name(qk, "SpecificHeatVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificHeatsRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Heats Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHeatsRatio">http://qudt.org/vocab/quantitykind/SpecificHeatsRatio</seealso>
    let SpecificHeatsRatio = Prefixed_Name(qk, "SpecificHeatsRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificHelmholtzEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Helmholtz Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificHelmholtzEnergy">http://qudt.org/vocab/quantitykind/SpecificHelmholtzEnergy</seealso>
    let SpecificHelmholtzEnergy =
        Prefixed_Name(qk, "SpecificHelmholtzEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificImpulse</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Specific Impulse"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificImpulse">http://qudt.org/vocab/quantitykind/SpecificImpulse</seealso>
    let SpecificImpulse = Prefixed_Name(qk, "SpecificImpulse") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificImpulseByMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Impulse by Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificImpulseByMass">http://qudt.org/vocab/quantitykind/SpecificImpulseByMass</seealso>
    let SpecificImpulseByMass =
        Prefixed_Name(qk, "SpecificImpulseByMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificImpulseByWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Impulse by Weight"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificImpulseByWeight">http://qudt.org/vocab/quantitykind/SpecificImpulseByWeight</seealso>
    let SpecificImpulseByWeight =
        Prefixed_Name(qk, "SpecificImpulseByWeight") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificInternalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Internal Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificInternalEnergy">http://qudt.org/vocab/quantitykind/SpecificInternalEnergy</seealso>
    let SpecificInternalEnergy =
        Prefixed_Name(qk, "SpecificInternalEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificModulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Modulus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificModulus">http://qudt.org/vocab/quantitykind/SpecificModulus</seealso>
    let SpecificModulus = Prefixed_Name(qk, "SpecificModulus") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificOpticalRotationalAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"specific optical rotational ability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"specific optical rotational ability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificOpticalRotationalAbility">http://qudt.org/vocab/quantitykind/SpecificOpticalRotationalAbility</seealso>
    let SpecificOpticalRotationalAbility =
        Prefixed_Name(qk, "SpecificOpticalRotationalAbility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificOpticalRotatoryPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificOpticalRotatoryPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Optical Rotatory Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificOpticalRotatoryPower">http://qudt.org/vocab/quantitykind/SpecificOpticalRotatoryPower</seealso>
    let SpecificOpticalRotatoryPower =
        Prefixed_Name(qk, "SpecificOpticalRotatoryPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpecificPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificPower">http://qudt.org/vocab/quantitykind/SpecificPower</seealso>
    let SpecificPower = Prefixed_Name(qk, "SpecificPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificSurfaceArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Surface Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificSurfaceArea">http://qudt.org/vocab/quantitykind/SpecificSurfaceArea</seealso>
    let SpecificSurfaceArea = Prefixed_Name(qk, "SpecificSurfaceArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Specific thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificThrust">http://qudt.org/vocab/quantitykind/SpecificThrust</seealso>
    let SpecificThrust = Prefixed_Name(qk, "SpecificThrust") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificVolume">http://qudt.org/vocab/quantitykind/SpecificVolume</seealso>
    let SpecificVolume = Prefixed_Name(qk, "SpecificVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpecificWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificWeight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"specific weight"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpecificWeight">http://qudt.org/vocab/quantitykind/SpecificWeight</seealso>
    let SpecificWeight = Prefixed_Name(qk, "SpecificWeight") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralAngularCrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpectralAngularCrossSection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spectral Angular Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralAngularCrossSection">http://qudt.org/vocab/quantitykind/SpectralAngularCrossSection</seealso>
    let SpectralAngularCrossSection =
        Prefixed_Name(qk, "SpectralAngularCrossSection") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralConcentrationOfRadiantEnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"spectral concentration of radiant energy density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralConcentrationOfRadiantEnergyDensity">http://qudt.org/vocab/quantitykind/SpectralConcentrationOfRadiantEnergyDensity</seealso>
    let SpectralConcentrationOfRadiantEnergyDensity =
        Prefixed_Name(qk, "SpectralConcentrationOfRadiantEnergyDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralConcentrationOfVibrationalModes</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"spectral concentration of vibrational modes (in terms of angular frequency)"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralConcentrationOfVibrationalModes">http://qudt.org/vocab/quantitykind/SpectralConcentrationOfVibrationalModes</seealso>
    let SpectralConcentrationOfVibrationalModes =
        Prefixed_Name(qk, "SpectralConcentrationOfVibrationalModes") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralCrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpectralCrossSection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spectral Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralCrossSection">http://qudt.org/vocab/quantitykind/SpectralCrossSection</seealso>
    let SpectralCrossSection = Prefixed_Name(qk, "SpectralCrossSection") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralDensityOfVibrationalModes</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpectralDensityOfVibrationalModes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"spectral density of vibrational modes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralDensityOfVibrationalModes">http://qudt.org/vocab/quantitykind/SpectralDensityOfVibrationalModes</seealso>
    let SpectralDensityOfVibrationalModes =
        Prefixed_Name(qk, "SpectralDensityOfVibrationalModes") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralEmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Measurement Unit of Spectral Emittance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralEmittance">http://qudt.org/vocab/quantitykind/SpectralEmittance</seealso>
    let SpectralEmittance = Prefixed_Name(qk, "SpectralEmittance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpectralIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Measurement Unit of Spectral Irradiance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralIrradiance">http://qudt.org/vocab/quantitykind/SpectralIrradiance</seealso>
    let SpectralIrradiance = Prefixed_Name(qk, "SpectralIrradiance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralLuminousEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Spectral Luminous Efficiency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralLuminousEfficiency">http://qudt.org/vocab/quantitykind/SpectralLuminousEfficiency</seealso>
    let SpectralLuminousEfficiency =
        Prefixed_Name(qk, "SpectralLuminousEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralRadiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpectralRadiance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement Unit of Spectral Radiance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralRadiance">http://qudt.org/vocab/quantitykind/SpectralRadiance</seealso>
    let SpectralRadiance = Prefixed_Name(qk, "SpectralRadiance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralRadiantEnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpectralRadiantEnergyDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spectral Radiant Energy Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensity">http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensity</seealso>
    let SpectralRadiantEnergyDensity =
        Prefixed_Name(qk, "SpectralRadiantEnergyDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SpectralRadiantEnergyDensityInTermsOfWavelength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"spectral radiant energy density in terms of wavelength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensityInTermsOfWavelength">http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensityInTermsOfWavelength</seealso>
    let SpectralRadiantEnergyDensityInTermsOfWavelength =
        Prefixed_Name(qk, "SpectralRadiantEnergyDensityInTermsOfWavelength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Speed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Speed"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Speed">http://qudt.org/vocab/quantitykind/Speed</seealso>
    let Speed = Prefixed_Name(qk, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpeedOfLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpeedOfLight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Işık hızı"</para><para>"Rychlost světla"</para><para>"velocità della luce"</para><para>"Lichtgeschwindigkeit"</para><para>"光速"</para><para>"سرعت نور"</para><para>"Скорость света"</para><para>"velocidad de la luz"</para><para>"Velocidade da luz"</para><para>"Prędkość światła"</para><para>"vitesse de la lumière"</para><para>"speed of light"</para><para>"سرعة الضوء"</para><para>"Hitrost svetlobe"</para><para>"प्रकाश का वेग"</para><para>"Kelajuan cahaya"</para><para>"Viteza luminii"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpeedOfLight">http://qudt.org/vocab/quantitykind/SpeedOfLight</seealso>
    let SpeedOfLight = Prefixed_Name(qk, "SpeedOfLight") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpeedOfSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Speed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"velocidad del sonido"</para><para>"rychlost zvuku"</para><para>"speed of sound"</para><para>"سرعت صوت"</para><para>"Hitrost zvoka"</para><para>"velocità del suono"</para><para>"Kelajuan bunyi"</para><para>"Schallgeschwindigkeit"</para><para>"Ses hızı"</para><para>"prędkość dźwięku"</para><para>"سرعة الصوت"</para><para>"vitesse du son"</para><para>"ध्वनि का वेग"</para><para>"скорость звука"</para><para>"viteza sunetului"</para><para>"音速"</para><para>"velocidade do som"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpeedOfSound">http://qudt.org/vocab/quantitykind/SpeedOfSound</seealso>
    let SpeedOfSound = Prefixed_Name(qk, "SpeedOfSound") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpeedRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Speed Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpeedRatio">http://qudt.org/vocab/quantitykind/SpeedRatio</seealso>
    let SpeedRatio = Prefixed_Name(qk, "SpeedRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SphericalIlluminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFluxPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Illuminance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SphericalIlluminance">http://qudt.org/vocab/quantitykind/SphericalIlluminance</seealso>
    let SphericalIlluminance = Prefixed_Name(qk, "SphericalIlluminance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Spin</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularMomentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spin"</para><para>"spin"</para><para>"لف مغزلي"</para><para>"اسپین/چرخش"</para><para>"espín"</para><para>"Спин"</para><para>"自旋"</para><para>"スピン角運動量"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Spin">http://qudt.org/vocab/quantitykind/Spin</seealso>
    let Spin = Prefixed_Name(qk, "Spin") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SpinQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpinQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spin Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SpinQuantumNumber">http://qudt.org/vocab/quantitykind/SpinQuantumNumber</seealso>
    let SpinQuantumNumber = Prefixed_Name(qk, "SpinQuantumNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SquareEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Square Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SquareEnergy">http://qudt.org/vocab/quantitykind/SquareEnergy</seealso>
    let SquareEnergy = Prefixed_Name(qk, "SquareEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/SquareTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SquareTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Square Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SquareTime">http://qudt.org/vocab/quantitykind/SquareTime</seealso>
    let SquareTime = Prefixed_Name(qk, "SquareTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StagePropellantMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stage Propellant Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StagePropellantMass">http://qudt.org/vocab/quantitykind/StagePropellantMass</seealso>
    let StagePropellantMass = Prefixed_Name(qk, "StagePropellantMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StageStructuralMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stage Structure Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StageStructuralMass">http://qudt.org/vocab/quantitykind/StageStructuralMass</seealso>
    let StageStructuralMass = Prefixed_Name(qk, "StageStructuralMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StandardAbsoluteActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StandardAbsoluteActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Standard Absolute Activity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StandardAbsoluteActivity">http://qudt.org/vocab/quantitykind/StandardAbsoluteActivity</seealso>
    let StandardAbsoluteActivity =
        Prefixed_Name(qk, "StandardAbsoluteActivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StandardChemicalPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Standard Chemical Potential"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StandardChemicalPotential">http://qudt.org/vocab/quantitykind/StandardChemicalPotential</seealso>
    let StandardChemicalPotential =
        Prefixed_Name(qk, "StandardChemicalPotential") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StandardGravitationalParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StandardGravitationalParameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Standard Gravitational Parameter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StandardGravitationalParameter">http://qudt.org/vocab/quantitykind/StandardGravitationalParameter</seealso>
    let StandardGravitationalParameter =
        Prefixed_Name(qk, "StandardGravitationalParameter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StateDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"state density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StateDensity">http://qudt.org/vocab/quantitykind/StateDensity</seealso>
    let StateDensity = Prefixed_Name(qk, "StateDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StateDensityAsExpressionOfAngularFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"state density as expression of angular frequency"</para><para>"state density as expression of angular frequency)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StateDensityAsExpressionOfAngularFrequency">http://qudt.org/vocab/quantitykind/StateDensityAsExpressionOfAngularFrequency</seealso>
    let StateDensityAsExpressionOfAngularFrequency =
        Prefixed_Name(qk, "StateDensityAsExpressionOfAngularFrequency") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StateOfCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StateOfCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"State of charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StateOfCharge">http://qudt.org/vocab/quantitykind/StateOfCharge</seealso>
    let StateOfCharge = Prefixed_Name(qk, "StateOfCharge") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StaticFriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Static Friction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StaticFriction">http://qudt.org/vocab/quantitykind/StaticFriction</seealso>
    let StaticFriction = Prefixed_Name(qk, "StaticFriction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StaticFrictionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FrictionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Static Friction Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StaticFrictionCoefficient">http://qudt.org/vocab/quantitykind/StaticFrictionCoefficient</seealso>
    let StaticFrictionCoefficient =
        Prefixed_Name(qk, "StaticFrictionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StaticPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Static pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StaticPressure">http://qudt.org/vocab/quantitykind/StaticPressure</seealso>
    let StaticPressure = Prefixed_Name(qk, "StaticPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StatisticalWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StatisticalWeight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Statistical Weight"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StatisticalWeight">http://qudt.org/vocab/quantitykind/StatisticalWeight</seealso>
    let StatisticalWeight = Prefixed_Name(qk, "StatisticalWeight") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StochasticProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stochastic Process"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StochasticProcess">http://qudt.org/vocab/quantitykind/StochasticProcess</seealso>
    let StochasticProcess = Prefixed_Name(qk, "StochasticProcess") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StoichiometricNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StoichiometricNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stoichiometric Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StoichiometricNumber">http://qudt.org/vocab/quantitykind/StoichiometricNumber</seealso>
    let StoichiometricNumber = Prefixed_Name(qk, "StoichiometricNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Strain</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Strain"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Strain">http://qudt.org/vocab/quantitykind/Strain</seealso>
    let Strain = Prefixed_Name(qk, "Strain") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StrainEnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Strain Energy Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StrainEnergyDensity">http://qudt.org/vocab/quantitykind/StrainEnergyDensity</seealso>
    let StrainEnergyDensity = Prefixed_Name(qk, "StrainEnergyDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StrainEnergyReleaseRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StrainEnergyReleaseRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Strain Energy Release Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StrainEnergyReleaseRate">http://qudt.org/vocab/quantitykind/StrainEnergyReleaseRate</seealso>
    let StrainEnergyReleaseRate =
        Prefixed_Name(qk, "StrainEnergyReleaseRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Stress</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stress"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Stress">http://qudt.org/vocab/quantitykind/Stress</seealso>
    let Stress = Prefixed_Name(qk, "Stress") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StressIntensityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StressIntensityFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stress Intensity Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StressIntensityFactor">http://qudt.org/vocab/quantitykind/StressIntensityFactor</seealso>
    let StressIntensityFactor =
        Prefixed_Name(qk, "StressIntensityFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StressOpticCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StressOpticCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stress-Optic Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StressOpticCoefficient">http://qudt.org/vocab/quantitykind/StressOpticCoefficient</seealso>
    let StressOpticCoefficient =
        Prefixed_Name(qk, "StressOpticCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/StructuralEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Structural Efficiency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StructuralEfficiency">http://qudt.org/vocab/quantitykind/StructuralEfficiency</seealso>
    let StructuralEfficiency = Prefixed_Name(qk, "StructuralEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/StructureFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:StructureFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Structure Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/StructureFactor">http://qudt.org/vocab/quantitykind/StructureFactor</seealso>
    let StructureFactor = Prefixed_Name(qk, "StructureFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SunProtectionFactorOfAProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SunProtectionFactorOfAProduct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sun protection factor of a product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SunProtectionFactorOfAProduct">http://qudt.org/vocab/quantitykind/SunProtectionFactorOfAProduct</seealso>
    let SunProtectionFactorOfAProduct =
        Prefixed_Name(qk, "SunProtectionFactorOfAProduct") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SuperconductionTransitionTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Superconduction Transition Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SuperconductionTransitionTemperature">http://qudt.org/vocab/quantitykind/SuperconductionTransitionTemperature</seealso>
    let SuperconductionTransitionTemperature =
        Prefixed_Name(qk, "SuperconductionTransitionTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SuperconductorEnergyGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Superconductor Energy Gap"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SuperconductorEnergyGap">http://qudt.org/vocab/quantitykind/SuperconductorEnergyGap</seealso>
    let SuperconductorEnergyGap =
        Prefixed_Name(qk, "SuperconductorEnergyGap") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurfaceActivityDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SurfaceActivityDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Surface Activity Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurfaceActivityDensity">http://qudt.org/vocab/quantitykind/SurfaceActivityDensity</seealso>
    let SurfaceActivityDensity =
        Prefixed_Name(qk, "SurfaceActivityDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurfaceCoefficientOfHeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SurfaceCoefficientOfHeatTransfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Surface Coefficient of Heat Transfer"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurfaceCoefficientOfHeatTransfer">http://qudt.org/vocab/quantitykind/SurfaceCoefficientOfHeatTransfer</seealso>
    let SurfaceCoefficientOfHeatTransfer =
        Prefixed_Name(qk, "SurfaceCoefficientOfHeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurfaceDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SurfaceDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Surface Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurfaceDensity">http://qudt.org/vocab/quantitykind/SurfaceDensity</seealso>
    let SurfaceDensity = Prefixed_Name(qk, "SurfaceDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurfaceRelatedVolumeFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SurfaceRelatedVolumeFlow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"surface-related volume flow"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlow">http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlow</seealso>
    let SurfaceRelatedVolumeFlow =
        Prefixed_Name(qk, "SurfaceRelatedVolumeFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurfaceRelatedVolumeFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SurfaceRelatedVolumeFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"surface‑related volume flow rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlowRate">http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlowRate</seealso>
    let SurfaceRelatedVolumeFlowRate =
        Prefixed_Name(qk, "SurfaceRelatedVolumeFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurfaceTension</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"поверхностное натяжение"</para><para>"पृष्ठ तनाव"</para><para>"توتر سطحي"</para><para>"表面张力"</para><para>"tensione superficiale"</para><para>"Tensiune superficială"</para><para>"کشش سطحی"</para><para>"povrchové napětí"</para><para>"površinska napetost"</para><para>"tension superficielle"</para><para>"Yüzey gerilimi"</para><para>"napięcie powierzchniowe"</para><para>"surface tension"</para><para>"Oberflächenspannung"</para><para>"Tegangan permukaan"</para><para>"tensão superficial"</para><para>"表面張力"</para><para>"tensión superficial"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurfaceTension">http://qudt.org/vocab/quantitykind/SurfaceTension</seealso>
    let SurfaceTension = Prefixed_Name(qk, "SurfaceTension") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SurgeImpedanceOfTheMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"surge impedance of the medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"surge impedance of the medium"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SurgeImpedanceOfTheMedium">http://qudt.org/vocab/quantitykind/SurgeImpedanceOfTheMedium</seealso>
    let SurgeImpedanceOfTheMedium =
        Prefixed_Name(qk, "SurgeImpedanceOfTheMedium") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Susceptance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Susceptance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Susceptance">http://qudt.org/vocab/quantitykind/Susceptance</seealso>
    let Susceptance = Prefixed_Name(qk, "Susceptance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SymbolTransmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"symbol transmission rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SymbolTransmissionRate">http://qudt.org/vocab/quantitykind/SymbolTransmissionRate</seealso>
    let SymbolTransmissionRate =
        Prefixed_Name(qk, "SymbolTransmissionRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/SystolicBloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Systolic Blood Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/SystolicBloodPressure">http://qudt.org/vocab/quantitykind/SystolicBloodPressure</seealso>
    let SystolicBloodPressure =
        Prefixed_Name(qk, "SystolicBloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TARGET-BOGIE-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Target Bogie Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TARGET-BOGIE-MASS">http://qudt.org/vocab/quantitykind/TARGET-BOGIE-MASS</seealso>
    let TARGET_BOGIE_MASS = Prefixed_Name(qk, "TARGET-BOGIE-MASS") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Temperature">http://qudt.org/vocab/quantitykind/Temperature</seealso>
    let Temperature = Prefixed_Name(qk, "Temperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperatureAmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature Amount of Substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureAmountOfSubstance">http://qudt.org/vocab/quantitykind/TemperatureAmountOfSubstance</seealso>
    let TemperatureAmountOfSubstance =
        Prefixed_Name(qk, "TemperatureAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedAmountOfSubstanceConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based amount-of-substance concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedAmountOfSubstanceConcentration">http://qudt.org/vocab/quantitykind/TemperatureBasedAmountOfSubstanceConcentration</seealso>
    let TemperatureBasedAmountOfSubstanceConcentration =
        Prefixed_Name(qk, "TemperatureBasedAmountOfSubstanceConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedDensity">http://qudt.org/vocab/quantitykind/TemperatureBasedDensity</seealso>
    let TemperatureBasedDensity =
        Prefixed_Name(qk, "TemperatureBasedDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedDynamicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based dynamic viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedDynamicViscosity">http://qudt.org/vocab/quantitykind/TemperatureBasedDynamicViscosity</seealso>
    let TemperatureBasedDynamicViscosity =
        Prefixed_Name(qk, "TemperatureBasedDynamicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedKinematicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based kinematic viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedKinematicViscosity">http://qudt.org/vocab/quantitykind/TemperatureBasedKinematicViscosity</seealso>
    let TemperatureBasedKinematicViscosity =
        Prefixed_Name(qk, "TemperatureBasedKinematicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedLength">http://qudt.org/vocab/quantitykind/TemperatureBasedLength</seealso>
    let TemperatureBasedLength =
        Prefixed_Name(qk, "TemperatureBasedLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedMass">http://qudt.org/vocab/quantitykind/TemperatureBasedMass</seealso>
    let TemperatureBasedMass = Prefixed_Name(qk, "TemperatureBasedMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedMassFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based mass flow rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedMassFlowRate">http://qudt.org/vocab/quantitykind/TemperatureBasedMassFlowRate</seealso>
    let TemperatureBasedMassFlowRate =
        Prefixed_Name(qk, "TemperatureBasedMassFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based quantity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedQuantity">http://qudt.org/vocab/quantitykind/TemperatureBasedQuantity</seealso>
    let TemperatureBasedQuantity =
        Prefixed_Name(qk, "TemperatureBasedQuantity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedVelocity">http://qudt.org/vocab/quantitykind/TemperatureBasedVelocity</seealso>
    let TemperatureBasedVelocity =
        Prefixed_Name(qk, "TemperatureBasedVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureBasedVolumeFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-based volume flow rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureBasedVolumeFlowRate">http://qudt.org/vocab/quantitykind/TemperatureBasedVolumeFlowRate</seealso>
    let TemperatureBasedVolumeFlowRate =
        Prefixed_Name(qk, "TemperatureBasedVolumeFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperaturdifferenz"</para><para>"temperature difference"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureDifference">http://qudt.org/vocab/quantitykind/TemperatureDifference</seealso>
    let TemperatureDifference =
        Prefixed_Name(qk, "TemperatureDifference") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureGradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperatureGradient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature Gradient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureGradient">http://qudt.org/vocab/quantitykind/TemperatureGradient</seealso>
    let TemperatureGradient = Prefixed_Name(qk, "TemperatureGradient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperaturePerMagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperaturePerMagneticFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature per Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperaturePerMagneticFluxDensity">http://qudt.org/vocab/quantitykind/TemperaturePerMagneticFluxDensity</seealso>
    let TemperaturePerMagneticFluxDensity =
        Prefixed_Name(qk, "TemperaturePerMagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperaturePerSquareTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperaturePerSquareTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature per Square Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperaturePerSquareTime">http://qudt.org/vocab/quantitykind/TemperaturePerSquareTime</seealso>
    let TemperaturePerSquareTime =
        Prefixed_Name(qk, "TemperaturePerSquareTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperaturePerTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperaturePerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature per Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperaturePerTime">http://qudt.org/vocab/quantitykind/TemperaturePerTime</seealso>
    let TemperaturePerTime = Prefixed_Name(qk, "TemperaturePerTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperaturePerTime_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Temperature per Time Squared"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperaturePerTime_Squared">http://qudt.org/vocab/quantitykind/TemperaturePerTime_Squared</seealso>
    let TemperaturePerTime_Squared =
        Prefixed_Name(qk, "TemperaturePerTime_Squared") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureRateOfChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperaturePerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature Rate of Change"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureRateOfChange">http://qudt.org/vocab/quantitykind/TemperatureRateOfChange</seealso>
    let TemperatureRateOfChange =
        Prefixed_Name(qk, "TemperatureRateOfChange") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperatureRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureRatio">http://qudt.org/vocab/quantitykind/TemperatureRatio</seealso>
    let TemperatureRatio = Prefixed_Name(qk, "TemperatureRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureRelatedMolarMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-related molar mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureRelatedMolarMass">http://qudt.org/vocab/quantitykind/TemperatureRelatedMolarMass</seealso>
    let TemperatureRelatedMolarMass =
        Prefixed_Name(qk, "TemperatureRelatedMolarMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureRelatedVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"temperature-related volume  "</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureRelatedVolume">http://qudt.org/vocab/quantitykind/TemperatureRelatedVolume</seealso>
    let TemperatureRelatedVolume =
        Prefixed_Name(qk, "TemperatureRelatedVolume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureVariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemperatureVariance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temperature Variance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureVariance">http://qudt.org/vocab/quantitykind/TemperatureVariance</seealso>
    let TemperatureVariance = Prefixed_Name(qk, "TemperatureVariance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemperatureVariance_NEON</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Temperature Variance, NEON"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemperatureVariance_NEON">http://qudt.org/vocab/quantitykind/TemperatureVariance_NEON</seealso>
    let TemperatureVariance_NEON =
        Prefixed_Name(qk, "TemperatureVariance_NEON") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TemporalSummationFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TemporalSummationFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temporal Summation Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TemporalSummationFunction">http://qudt.org/vocab/quantitykind/TemporalSummationFunction</seealso>
    let TemporalSummationFunction =
        Prefixed_Name(qk, "TemporalSummationFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Tension</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tension"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Tension">http://qudt.org/vocab/quantitykind/Tension</seealso>
    let Tension = Prefixed_Name(qk, "Tension") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalAdmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CoefficientOfHeatTransfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Admittance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalAdmittance">http://qudt.org/vocab/quantitykind/ThermalAdmittance</seealso>
    let ThermalAdmittance = Prefixed_Name(qk, "ThermalAdmittance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalCapacitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalCapacitance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"thermal capacitance"</para><para>"thermal capacitance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalCapacitance">http://qudt.org/vocab/quantitykind/ThermalCapacitance</seealso>
    let ThermalCapacitance = Prefixed_Name(qk, "ThermalCapacitance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalCoefficientOfLinearExpansion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"thermal coefficient of linear expansion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalCoefficientOfLinearExpansion">http://qudt.org/vocab/quantitykind/ThermalCoefficientOfLinearExpansion</seealso>
    let ThermalCoefficientOfLinearExpansion =
        Prefixed_Name(qk, "ThermalCoefficientOfLinearExpansion") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalConductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalConductance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Conductance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalConductance">http://qudt.org/vocab/quantitykind/ThermalConductance</seealso>
    let ThermalConductance = Prefixed_Name(qk, "ThermalConductance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalConductivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Conductivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalConductivity">http://qudt.org/vocab/quantitykind/ThermalConductivity</seealso>
    let ThermalConductivity = Prefixed_Name(qk, "ThermalConductivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalDiffusionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalDiffusionFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Diffusion Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalDiffusionFactor">http://qudt.org/vocab/quantitykind/ThermalDiffusionFactor</seealso>
    let ThermalDiffusionFactor =
        Prefixed_Name(qk, "ThermalDiffusionFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalDiffusionRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalDiffusionRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Diffusion Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalDiffusionRatio">http://qudt.org/vocab/quantitykind/ThermalDiffusionRatio</seealso>
    let ThermalDiffusionRatio =
        Prefixed_Name(qk, "ThermalDiffusionRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalDiffusionRatioCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalDiffusionRatioCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Diffusion Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalDiffusionRatioCoefficient">http://qudt.org/vocab/quantitykind/ThermalDiffusionRatioCoefficient</seealso>
    let ThermalDiffusionRatioCoefficient =
        Prefixed_Name(qk, "ThermalDiffusionRatioCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalDiffusivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaPerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Diffusivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalDiffusivity">http://qudt.org/vocab/quantitykind/ThermalDiffusivity</seealso>
    let ThermalDiffusivity = Prefixed_Name(qk, "ThermalDiffusivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Efficiency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalEfficiency">http://qudt.org/vocab/quantitykind/ThermalEfficiency</seealso>
    let ThermalEfficiency = Prefixed_Name(qk, "ThermalEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalEnergy">http://qudt.org/vocab/quantitykind/ThermalEnergy</seealso>
    let ThermalEnergy = Prefixed_Name(qk, "ThermalEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalEnergyLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalEnergyLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Energy Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalEnergyLength">http://qudt.org/vocab/quantitykind/ThermalEnergyLength</seealso>
    let ThermalEnergyLength = Prefixed_Name(qk, "ThermalEnergyLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalExpansionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalExpansionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Expansion Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalExpansionCoefficient">http://qudt.org/vocab/quantitykind/ThermalExpansionCoefficient</seealso>
    let ThermalExpansionCoefficient =
        Prefixed_Name(qk, "ThermalExpansionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalInertia</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Measurement Unit of Thermal Inertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalInertia">http://qudt.org/vocab/quantitykind/ThermalInertia</seealso>
    let ThermalInertia = Prefixed_Name(qk, "ThermalInertia") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalInsulance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalInsulance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Insulance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalInsulance">http://qudt.org/vocab/quantitykind/ThermalInsulance</seealso>
    let ThermalInsulance = Prefixed_Name(qk, "ThermalInsulance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalInsulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"thermal insulation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalInsulation">http://qudt.org/vocab/quantitykind/ThermalInsulation</seealso>
    let ThermalInsulation = Prefixed_Name(qk, "ThermalInsulation") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalResistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resistência térmica"</para><para>"résistance thermique"</para><para>"مقاومة حرارية"</para><para>"熱抵抗"</para><para>"thermischer Widerstand"</para><para>"opór cieplny"</para><para>"热阻"</para><para>"thermal resistance"</para><para>"resistencia térmica"</para><para>"resistenza termica"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalResistance">http://qudt.org/vocab/quantitykind/ThermalResistance</seealso>
    let ThermalResistance = Prefixed_Name(qk, "ThermalResistance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalResistivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalResistivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Resistivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalResistivity">http://qudt.org/vocab/quantitykind/ThermalResistivity</seealso>
    let ThermalResistivity = Prefixed_Name(qk, "ThermalResistivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermalTransmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CoefficientOfHeatTransfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Transmittance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalTransmittance">http://qudt.org/vocab/quantitykind/ThermalTransmittance</seealso>
    let ThermalTransmittance = Prefixed_Name(qk, "ThermalTransmittance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalUtilizationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalUtilizationFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Utilization Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalUtilizationFactor">http://qudt.org/vocab/quantitykind/ThermalUtilizationFactor</seealso>
    let ThermalUtilizationFactor =
        Prefixed_Name(qk, "ThermalUtilizationFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermalUtilizationFactorForFission</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermal Utilization Factor For Fission"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermalUtilizationFactorForFission">http://qudt.org/vocab/quantitykind/ThermalUtilizationFactorForFission</seealso>
    let ThermalUtilizationFactorForFission =
        Prefixed_Name(qk, "ThermalUtilizationFactorForFission") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermodynamicCriticalMagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermodynamic Critical Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermodynamicCriticalMagneticFluxDensity">http://qudt.org/vocab/quantitykind/ThermodynamicCriticalMagneticFluxDensity</seealso>
    let ThermodynamicCriticalMagneticFluxDensity =
        Prefixed_Name(qk, "ThermodynamicCriticalMagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermodynamicEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermodynamic Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermodynamicEnergy">http://qudt.org/vocab/quantitykind/ThermodynamicEnergy</seealso>
    let ThermodynamicEnergy = Prefixed_Name(qk, "ThermodynamicEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThermodynamicEntropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermodynamic Entropy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermodynamicEntropy">http://qudt.org/vocab/quantitykind/ThermodynamicEntropy</seealso>
    let ThermodynamicEntropy = Prefixed_Name(qk, "ThermodynamicEntropy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThermodynamicTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermodynamicTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Termodynamická teplota"</para><para>"thermodynamic temperature"</para><para>"temperatura"</para><para>"درجة الحرارة المطلقة"</para><para>"ऊष्मगतिकीय तापमान"</para><para>"دمای ترمودینامیکی"</para><para>"Suhu termodinamik"</para><para>"température thermodynamique"</para><para>"热力学温度"</para><para>"טמפרטורה מוחלטת"</para><para>"thermodynamische Temperatur"</para><para>"temperatura termodinamica"</para><para>"Термодинамична температура"</para><para>"temperatura thermodynamica absoluta"</para><para>"熱力学温度"</para><para>"termodinamik sıcaklık"</para><para>"temperatură termodinamică"</para><para>"abszolút hőmérséklet"</para><para>"Термодинамическая температура"</para><para>"Απόλυτη"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThermodynamicTemperature">http://qudt.org/vocab/quantitykind/ThermodynamicTemperature</seealso>
    let ThermodynamicTemperature =
        Prefixed_Name(qk, "ThermodynamicTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Thickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thickness"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Thickness">http://qudt.org/vocab/quantitykind/Thickness</seealso>
    let Thickness = Prefixed_Name(qk, "Thickness") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThomsonCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThomsonCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thomson Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThomsonCoefficient">http://qudt.org/vocab/quantitykind/ThomsonCoefficient</seealso>
    let ThomsonCoefficient = Prefixed_Name(qk, "ThomsonCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Thrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Thrust">http://qudt.org/vocab/quantitykind/Thrust</seealso>
    let Thrust = Prefixed_Name(qk, "Thrust") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThrustCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Thrust Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThrustCoefficient">http://qudt.org/vocab/quantitykind/ThrustCoefficient</seealso>
    let ThrustCoefficient = Prefixed_Name(qk, "ThrustCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThrustToMassRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThrustToMassRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thrust To Mass Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThrustToMassRatio">http://qudt.org/vocab/quantitykind/ThrustToMassRatio</seealso>
    let ThrustToMassRatio = Prefixed_Name(qk, "ThrustToMassRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ThrustToWeightRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thrust To Weight Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThrustToWeightRatio">http://qudt.org/vocab/quantitykind/ThrustToWeightRatio</seealso>
    let ThrustToWeightRatio = Prefixed_Name(qk, "ThrustToWeightRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ThrusterPowerToThrustEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThrusterPowerToThrustEfficiency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thruster Power To Thrust Efficiency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ThrusterPowerToThrustEfficiency">http://qudt.org/vocab/quantitykind/ThrusterPowerToThrustEfficiency</seealso>
    let ThrusterPowerToThrustEfficiency =
        Prefixed_Name(qk, "ThrusterPowerToThrustEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Tilt</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tilt"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Tilt">http://qudt.org/vocab/quantitykind/Tilt</seealso>
    let Tilt = Prefixed_Name(qk, "Tilt") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"समय"</para><para>"timp"</para><para>"زمان"</para><para>"Време"</para><para>"temps"</para><para>"زمن"</para><para>"tempus"</para><para>"時間"</para><para>"tempo"</para><para>"tiempo"</para><para>"zaman"</para><para>"זמן"</para><para>"czas"</para><para>"čas"</para><para>"time"</para><para>"时间"</para><para>"idő"</para><para>"Čas"</para><para>"Masa"</para><para>"Zeit"</para><para>"Время"</para><para>"Χρόνος"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Time">http://qudt.org/vocab/quantitykind/Time</seealso>
    let Time = Prefixed_Name(qk, "Time") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TimeAveragedSoundIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time averaged sound intensity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TimeAveragedSoundIntensity">http://qudt.org/vocab/quantitykind/TimeAveragedSoundIntensity</seealso>
    let TimeAveragedSoundIntensity =
        Prefixed_Name(qk, "TimeAveragedSoundIntensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TimeConstant_Inductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"time constant (inductance based)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TimeConstant_Inductance">http://qudt.org/vocab/quantitykind/TimeConstant_Inductance</seealso>
    let TimeConstant_Inductance =
        Prefixed_Name(qk, "TimeConstant_Inductance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TimePerCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TimePerCount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time per Count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TimePerCount">http://qudt.org/vocab/quantitykind/TimePerCount</seealso>
    let TimePerCount = Prefixed_Name(qk, "TimePerCount") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TimeRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TimeRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TimeRatio">http://qudt.org/vocab/quantitykind/TimeRatio</seealso>
    let TimeRatio = Prefixed_Name(qk, "TimeRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TimeRelatedLogarithmicRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"time-related logarithmic ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TimeRelatedLogarithmicRatio">http://qudt.org/vocab/quantitykind/TimeRelatedLogarithmicRatio</seealso>
    let TimeRelatedLogarithmicRatio =
        Prefixed_Name(qk, "TimeRelatedLogarithmicRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TimeTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TimeTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TimeTemperature">http://qudt.org/vocab/quantitykind/TimeTemperature</seealso>
    let TimeTemperature = Prefixed_Name(qk, "TimeTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Time_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Time Squared"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Time_Squared">http://qudt.org/vocab/quantitykind/Time_Squared</seealso>
    let Time_Squared = Prefixed_Name(qk, "Time_Squared") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Torque</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Torque"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"torque"</para><para>"moment obrotowy"</para><para>"par"</para><para>"عزم محورى"</para><para>"couple"</para><para>"momento de torção"</para><para>"coppia"</para><para>"トルク"</para><para>"转矩"</para><para>"Torsionmoment"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Torque">http://qudt.org/vocab/quantitykind/Torque</seealso>
    let Torque = Prefixed_Name(qk, "Torque") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TorqueConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"torque constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"torque constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TorqueConstant">http://qudt.org/vocab/quantitykind/TorqueConstant</seealso>
    let TorqueConstant = Prefixed_Name(qk, "TorqueConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TorquePerAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TorquePerAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Torque per Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TorquePerAngle">http://qudt.org/vocab/quantitykind/TorquePerAngle</seealso>
    let TorquePerAngle = Prefixed_Name(qk, "TorquePerAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TorquePerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TorquePerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Torque per Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TorquePerLength">http://qudt.org/vocab/quantitykind/TorquePerLength</seealso>
    let TorquePerLength = Prefixed_Name(qk, "TorquePerLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TorsionalRigidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"torsional rigidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TorsionalRigidity">http://qudt.org/vocab/quantitykind/TorsionalRigidity</seealso>
    let TorsionalRigidity = Prefixed_Name(qk, "TorsionalRigidity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TorsionalSpringConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TorsionalSpringConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"torsional spring constant"</para><para>"Federkonstante Drehfeder"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TorsionalSpringConstant">http://qudt.org/vocab/quantitykind/TorsionalSpringConstant</seealso>
    let TorsionalSpringConstant =
        Prefixed_Name(qk, "TorsionalSpringConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalAngularMomentum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularMomentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Angular Momentum"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalAngularMomentum">http://qudt.org/vocab/quantitykind/TotalAngularMomentum</seealso>
    let TotalAngularMomentum = Prefixed_Name(qk, "TotalAngularMomentum") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalAngularMomentumQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalAngularMomentumQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Angular Momentum Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalAngularMomentumQuantumNumber">http://qudt.org/vocab/quantitykind/TotalAngularMomentumQuantumNumber</seealso>
    let TotalAngularMomentumQuantumNumber =
        Prefixed_Name(qk, "TotalAngularMomentumQuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalAtomicStoppingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalAtomicStoppingPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Atomic Stopping Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalAtomicStoppingPower">http://qudt.org/vocab/quantitykind/TotalAtomicStoppingPower</seealso>
    let TotalAtomicStoppingPower =
        Prefixed_Name(qk, "TotalAtomicStoppingPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalCrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalCrossSection">http://qudt.org/vocab/quantitykind/TotalCrossSection</seealso>
    let TotalCrossSection = Prefixed_Name(qk, "TotalCrossSection") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TotalCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalCurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalCurrent">http://qudt.org/vocab/quantitykind/TotalCurrent</seealso>
    let TotalCurrent = Prefixed_Name(qk, "TotalCurrent") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TotalCurrentDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Current Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalCurrentDensity">http://qudt.org/vocab/quantitykind/TotalCurrentDensity</seealso>
    let TotalCurrentDensity = Prefixed_Name(qk, "TotalCurrentDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TotalIonization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalIonization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Ionization"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalIonization">http://qudt.org/vocab/quantitykind/TotalIonization</seealso>
    let TotalIonization = Prefixed_Name(qk, "TotalIonization") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalLinearStoppingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalLinearStoppingPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Linear Stopping Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalLinearStoppingPower">http://qudt.org/vocab/quantitykind/TotalLinearStoppingPower</seealso>
    let TotalLinearStoppingPower =
        Prefixed_Name(qk, "TotalLinearStoppingPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalMassStoppingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TotalMassStoppingPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Mass Stopping Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalMassStoppingPower">http://qudt.org/vocab/quantitykind/TotalMassStoppingPower</seealso>
    let TotalMassStoppingPower =
        Prefixed_Name(qk, "TotalMassStoppingPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TotalPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalPressure">http://qudt.org/vocab/quantitykind/TotalPressure</seealso>
    let TotalPressure = Prefixed_Name(qk, "TotalPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TotalRadiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"total radiance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TotalRadiance">http://qudt.org/vocab/quantitykind/TotalRadiance</seealso>
    let TotalRadiance = Prefixed_Name(qk, "TotalRadiance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TouchThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Touch Thresholds"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TouchThresholds">http://qudt.org/vocab/quantitykind/TouchThresholds</seealso>
    let TouchThresholds = Prefixed_Name(qk, "TouchThresholds") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TrafficIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"traffic intensity"</para><para>"traffic intensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TrafficIntensity">http://qudt.org/vocab/quantitykind/TrafficIntensity</seealso>
    let TrafficIntensity = Prefixed_Name(qk, "TrafficIntensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/TransmissionRatioBetweenRotationAndTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"transmission ratio between rotation and translation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TransmissionRatioBetweenRotationAndTranslation">http://qudt.org/vocab/quantitykind/TransmissionRatioBetweenRotationAndTranslation</seealso>
    let TransmissionRatioBetweenRotationAndTranslation =
        Prefixed_Name(qk, "TransmissionRatioBetweenRotationAndTranslation") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Transmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transmittance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Transmittance">http://qudt.org/vocab/quantitykind/Transmittance</seealso>
    let Transmittance = Prefixed_Name(qk, "Transmittance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TransmittanceDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TransmittanceDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transmittance Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TransmittanceDensity">http://qudt.org/vocab/quantitykind/TransmittanceDensity</seealso>
    let TransmittanceDensity = Prefixed_Name(qk, "TransmittanceDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/TrueExhaustVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"True Exhaust Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/TrueExhaustVelocity">http://qudt.org/vocab/quantitykind/TrueExhaustVelocity</seealso>
    let TrueExhaustVelocity = Prefixed_Name(qk, "TrueExhaustVelocity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Turbidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Turbidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Turbidity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Turbidity">http://qudt.org/vocab/quantitykind/Turbidity</seealso>
    let Turbidity = Prefixed_Name(qk, "Turbidity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Turns</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Turns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Turns"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Turns">http://qudt.org/vocab/quantitykind/Turns</seealso>
    let Turns = Prefixed_Name(qk, "Turns") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Unbalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Unbalance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unbalance"</para><para>"unbalance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Unbalance">http://qudt.org/vocab/quantitykind/Unbalance</seealso>
    let Unbalance = Prefixed_Name(qk, "Unbalance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Unknown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unknown"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Unknown">http://qudt.org/vocab/quantitykind/Unknown</seealso>
    let Unknown = Prefixed_Name(qk, "Unknown") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/UpperCriticalMagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Upper Critical Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/UpperCriticalMagneticFluxDensity">http://qudt.org/vocab/quantitykind/UpperCriticalMagneticFluxDensity</seealso>
    let UpperCriticalMagneticFluxDensity =
        Prefixed_Name(qk, "UpperCriticalMagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VacuumThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vacuum Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VacuumThrust">http://qudt.org/vocab/quantitykind/VacuumThrust</seealso>
    let VacuumThrust = Prefixed_Name(qk, "VacuumThrust") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VaporPermeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Vapor Permeability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VaporPermeability">http://qudt.org/vocab/quantitykind/VaporPermeability</seealso>
    let VaporPermeability = Prefixed_Name(qk, "VaporPermeability") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VaporPermeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Vapor Permeance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VaporPermeance">http://qudt.org/vocab/quantitykind/VaporPermeance</seealso>
    let VaporPermeance = Prefixed_Name(qk, "VaporPermeance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VaporPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VaporPressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vapor Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VaporPressure">http://qudt.org/vocab/quantitykind/VaporPressure</seealso>
    let VaporPressure = Prefixed_Name(qk, "VaporPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VapourPermeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VapourPermeability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vapour Permeability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VapourPermeability">http://qudt.org/vocab/quantitykind/VapourPermeability</seealso>
    let VapourPermeability = Prefixed_Name(qk, "VapourPermeability") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VapourPermeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VapourPermeance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vapour Permeance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VapourPermeance">http://qudt.org/vocab/quantitykind/VapourPermeance</seealso>
    let VapourPermeance = Prefixed_Name(qk, "VapourPermeance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VehicleVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vehicle Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VehicleVelocity">http://qudt.org/vocab/quantitykind/VehicleVelocity</seealso>
    let VehicleVelocity = Prefixed_Name(qk, "VehicleVelocity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Velocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"速度"</para><para>"سرعت/تندی"</para><para>"Επιφάνεια"</para><para>"velocitas"</para><para>"velocità"</para><para>"Ско́рость"</para><para>"Geschwindigkeit"</para><para>"Rychlost"</para><para>"velocidad"</para><para>"hız"</para><para>"velocidade"</para><para>"السرعة"</para><para>"prędkość"</para><para>"מהירות"</para><para>"velocity"</para><para>"viteză"</para><para>"गति"</para><para>"Halaju"</para><para>"vitesse"</para><para>"速力"</para><para>"hitrost"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Velocity">http://qudt.org/vocab/quantitykind/Velocity</seealso>
    let Velocity = Prefixed_Name(qk, "Velocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VentilationRatePerFloorArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VentilationRatePerFloorArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ventilation Rate per Floor Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VentilationRatePerFloorArea">http://qudt.org/vocab/quantitykind/VentilationRatePerFloorArea</seealso>
    let VentilationRatePerFloorArea =
        Prefixed_Name(qk, "VentilationRatePerFloorArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VerticalVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vertical Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VerticalVelocity">http://qudt.org/vocab/quantitykind/VerticalVelocity</seealso>
    let VerticalVelocity = Prefixed_Name(qk, "VerticalVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VibrationalDensityOfStates</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VibrationalDensityOfStates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vibrational density of states"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VibrationalDensityOfStates">http://qudt.org/vocab/quantitykind/VibrationalDensityOfStates</seealso>
    let VibrationalDensityOfStates =
        Prefixed_Name(qk, "VibrationalDensityOfStates") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VideoFrameRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VideoFrameRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Video Frame Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VideoFrameRate">http://qudt.org/vocab/quantitykind/VideoFrameRate</seealso>
    let VideoFrameRate = Prefixed_Name(qk, "VideoFrameRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Viscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Viscosity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Viscosity">http://qudt.org/vocab/quantitykind/Viscosity</seealso>
    let Viscosity = Prefixed_Name(qk, "Viscosity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VisibleRadiantEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Visible Radiant Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VisibleRadiantEnergy">http://qudt.org/vocab/quantitykind/VisibleRadiantEnergy</seealso>
    let VisibleRadiantEnergy = Prefixed_Name(qk, "VisibleRadiantEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VisionThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Vision Thresholds"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VisionThresholds">http://qudt.org/vocab/quantitykind/VisionThresholds</seealso>
    let VisionThresholds = Prefixed_Name(qk, "VisionThresholds") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Voltage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Voltage"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Voltage">http://qudt.org/vocab/quantitykind/Voltage</seealso>
    let Voltage = Prefixed_Name(qk, "Voltage") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VoltagePhasor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Voltage Phasor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VoltagePhasor">http://qudt.org/vocab/quantitykind/VoltagePhasor</seealso>
    let VoltagePhasor = Prefixed_Name(qk, "VoltagePhasor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VoltageRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VoltageRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Voltage Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VoltageRatio">http://qudt.org/vocab/quantitykind/VoltageRatio</seealso>
    let VoltageRatio = Prefixed_Name(qk, "VoltageRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Volume">http://qudt.org/vocab/quantitykind/Volume</seealso>
    let Volume = Prefixed_Name(qk, "Volume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumeDensityOfCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volume density of charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeDensityOfCharge">http://qudt.org/vocab/quantitykind/VolumeDensityOfCharge</seealso>
    let VolumeDensityOfCharge =
        Prefixed_Name(qk, "VolumeDensityOfCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumeFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumeFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Flow Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeFlowRate">http://qudt.org/vocab/quantitykind/VolumeFlowRate</seealso>
    let VolumeFlowRate = Prefixed_Name(qk, "VolumeFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumeFlowRate_SurfaceRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"surface‑related volume flow rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeFlowRate_SurfaceRelated">http://qudt.org/vocab/quantitykind/VolumeFlowRate_SurfaceRelated</seealso>
    let VolumeFlowRate_SurfaceRelated =
        Prefixed_Name(qk, "VolumeFlowRate_SurfaceRelated") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumeFlowRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Flow Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeFlowRatio">http://qudt.org/vocab/quantitykind/VolumeFlowRatio</seealso>
    let VolumeFlowRatio = Prefixed_Name(qk, "VolumeFlowRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VolumeFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumeFraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Fraction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeFraction">http://qudt.org/vocab/quantitykind/VolumeFraction</seealso>
    let VolumeFraction = Prefixed_Name(qk, "VolumeFraction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumeOrSectionModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volume or section modulus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeOrSectionModulus">http://qudt.org/vocab/quantitykind/VolumeOrSectionModulus</seealso>
    let VolumeOrSectionModulus =
        Prefixed_Name(qk, "VolumeOrSectionModulus") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumePerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume per Unit Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumePerArea">http://qudt.org/vocab/quantitykind/VolumePerArea</seealso>
    let VolumePerArea = Prefixed_Name(qk, "VolumePerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VolumePerTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumePerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume per Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumePerTime">http://qudt.org/vocab/quantitykind/VolumePerTime</seealso>
    let VolumePerTime = Prefixed_Name(qk, "VolumePerTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/VolumeStrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Strain"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeStrain">http://qudt.org/vocab/quantitykind/VolumeStrain</seealso>
    let VolumeStrain = Prefixed_Name(qk, "VolumeStrain") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumeThermalExpansion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumeThermalExpansion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Thermal Expansion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumeThermalExpansion">http://qudt.org/vocab/quantitykind/VolumeThermalExpansion</seealso>
    let VolumeThermalExpansion =
        Prefixed_Name(qk, "VolumeThermalExpansion") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumetricBitDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumetricBitDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"volumic bit density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumetricBitDensity">http://qudt.org/vocab/quantitykind/VolumetricBitDensity</seealso>
    let VolumetricBitDensity = Prefixed_Name(qk, "VolumetricBitDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumetricElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volumic electric charge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumetricElectricCharge">http://qudt.org/vocab/quantitykind/VolumetricElectricCharge</seealso>
    let VolumetricElectricCharge =
        Prefixed_Name(qk, "VolumetricElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumetricEntityDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volumetric entity density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumetricEntityDensity">http://qudt.org/vocab/quantitykind/VolumetricEntityDensity</seealso>
    let VolumetricEntityDensity =
        Prefixed_Name(qk, "VolumetricEntityDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumetricFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumetricFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volumetric Flux"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumetricFlux">http://qudt.org/vocab/quantitykind/VolumetricFlux</seealso>
    let VolumetricFlux = Prefixed_Name(qk, "VolumetricFlux") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumetricHeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumetricHeatCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volumetric Heat Capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumetricHeatCapacity">http://qudt.org/vocab/quantitykind/VolumetricHeatCapacity</seealso>
    let VolumetricHeatCapacity =
        Prefixed_Name(qk, "VolumetricHeatCapacity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumetricOutputPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volumic output power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumetricOutputPower">http://qudt.org/vocab/quantitykind/VolumetricOutputPower</seealso>
    let VolumetricOutputPower =
        Prefixed_Name(qk, "VolumetricOutputPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumicAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volumic amount of substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumicAmountOfSubstance">http://qudt.org/vocab/quantitykind/VolumicAmountOfSubstance</seealso>
    let VolumicAmountOfSubstance =
        Prefixed_Name(qk, "VolumicAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumicDataQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volumic data quantity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumicDataQuantity">http://qudt.org/vocab/quantitykind/VolumicDataQuantity</seealso>
    let VolumicDataQuantity = Prefixed_Name(qk, "VolumicDataQuantity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumicElectromagneticEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:VolumicElectromagneticEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volumic Electromagnetic Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumicElectromagneticEnergy">http://qudt.org/vocab/quantitykind/VolumicElectromagneticEnergy</seealso>
    let VolumicElectromagneticEnergy =
        Prefixed_Name(qk, "VolumicElectromagneticEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/VolumicOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"volumic output"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/VolumicOutput">http://qudt.org/vocab/quantitykind/VolumicOutput</seealso>
    let VolumicOutput = Prefixed_Name(qk, "VolumicOutput") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Vorticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vorticity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Vorticity">http://qudt.org/vocab/quantitykind/Vorticity</seealso>
    let Vorticity = Prefixed_Name(qk, "Vorticity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/WarmReceptorThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Warm Receptor Threshold"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WarmReceptorThreshold">http://qudt.org/vocab/quantitykind/WarmReceptorThreshold</seealso>
    let WarmReceptorThreshold =
        Prefixed_Name(qk, "WarmReceptorThreshold") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/WarpingConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:WarpingConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Warping Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WarpingConstant">http://qudt.org/vocab/quantitykind/WarpingConstant</seealso>
    let WarpingConstant = Prefixed_Name(qk, "WarpingConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/WarpingMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:WarpingMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Warping Moment"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WarpingMoment">http://qudt.org/vocab/quantitykind/WarpingMoment</seealso>
    let WarpingMoment = Prefixed_Name(qk, "WarpingMoment") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/WaterHorsepower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Water Horsepower"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WaterHorsepower">http://qudt.org/vocab/quantitykind/WaterHorsepower</seealso>
    let WaterHorsepower = Prefixed_Name(qk, "WaterHorsepower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/WaterSolubility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:WaterSolubility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Water Solubility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WaterSolubility">http://qudt.org/vocab/quantitykind/WaterSolubility</seealso>
    let WaterSolubility = Prefixed_Name(qk, "WaterSolubility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/WaterVaporDiffusionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:WaterVaporDiffusionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wasserdampfdiffusionsleitkoeffizient"</para><para>"Water vapour diffusion coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WaterVaporDiffusionCoefficient">http://qudt.org/vocab/quantitykind/WaterVaporDiffusionCoefficient</seealso>
    let WaterVaporDiffusionCoefficient =
        Prefixed_Name(qk, "WaterVaporDiffusionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/WaterVapourPermeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"water vapour permeability"</para><para>"water vapour permeability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WaterVapourPermeability">http://qudt.org/vocab/quantitykind/WaterVapourPermeability</seealso>
    let WaterVapourPermeability =
        Prefixed_Name(qk, "WaterVapourPermeability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Wavelength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dalga boyu"</para><para>"длина волны"</para><para>"wavelength"</para><para>"Wellenlänge"</para><para>"طول موج"</para><para>"lunghezza d'onda"</para><para>"Vlnové délka"</para><para>"comprimento de onda"</para><para>"Jarak gelombang"</para><para>"longitud de onda"</para><para>"longueur d'onde"</para><para>"波长"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Wavelength">http://qudt.org/vocab/quantitykind/Wavelength</seealso>
    let Wavelength = Prefixed_Name(qk, "Wavelength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Wavenumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:InverseLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"波数"</para><para>"wavenumber"</para><para>"numero d'onda"</para><para>"عدد الموجة"</para><para>"valovno število"</para><para>"número de onda"</para><para>"Vlnové číslo"</para><para>"Liczba falowa"</para><para>"número de ola"</para><para>"Repetenz"</para><para>"Волновое число"</para><para>"Bilangan gelombang"</para><para>"nombre d'onde"</para><para>"عدد موج"</para><para>"dalga sayısı"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Wavenumber">http://qudt.org/vocab/quantitykind/Wavenumber</seealso>
    let Wavenumber = Prefixed_Name(qk, "Wavenumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/WebTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WebTime">http://qudt.org/vocab/quantitykind/WebTime</seealso>
    let WebTime = Prefixed_Name(qk, "WebTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/WebTimeAveragePressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Time Average Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WebTimeAveragePressure">http://qudt.org/vocab/quantitykind/WebTimeAveragePressure</seealso>
    let WebTimeAveragePressure =
        Prefixed_Name(qk, "WebTimeAveragePressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/WebTimeAverageThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Web Time Avg Thrust (Mlbf)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Time Average Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WebTimeAverageThrust">http://qudt.org/vocab/quantitykind/WebTimeAverageThrust</seealso>
    let WebTimeAverageThrust = Prefixed_Name(qk, "WebTimeAverageThrust") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"greutate"</para><para>"وزن"</para><para>"poids"</para><para>"weight"</para><para>"peso"</para><para>"Siła ciężkości"</para><para>"Gewicht"</para><para>"Berat"</para><para>"重さ"</para><para>"forza peso"</para><para>"Ağırlık"</para><para>"重量"</para><para>"tíha"</para><para>"Вес"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Weight">http://qudt.org/vocab/quantitykind/Weight</seealso>
    let Weight = Prefixed_Name(qk, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/WetBulbTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wet Bulb Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WetBulbTemperature">http://qudt.org/vocab/quantitykind/WetBulbTemperature</seealso>
    let WetBulbTemperature = Prefixed_Name(qk, "WetBulbTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Width</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Width"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Width">http://qudt.org/vocab/quantitykind/Width</seealso>
    let Width = Prefixed_Name(qk, "Width") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Arbeit"</para><para>"iş"</para><para>"delo"</para><para>"práce"</para><para>"कार्य"</para><para>"trabalho"</para><para>"kerja"</para><para>"travail"</para><para>"lucru mecanic"</para><para>"کار"</para><para>"仕事量"</para><para>"praca"</para><para>"trabajo"</para><para>"功"</para><para>"work"</para><para>"lavoro"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Work">http://qudt.org/vocab/quantitykind/Work</seealso>
    let Work = Prefixed_Name(qk, "Work") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/WorkFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Work Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/WorkFunction">http://qudt.org/vocab/quantitykind/WorkFunction</seealso>
    let WorkFunction = Prefixed_Name(qk, "WorkFunction") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/APIGravity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:APIGravity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"API Gravity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/APIGravity">http://qudt.org/vocab/quantitykind/APIGravity</seealso>
    let APIGravity = Prefixed_Name(qk, "APIGravity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AbsoluteActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AbsoluteActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absolute Activity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AbsoluteActivity">http://qudt.org/vocab/quantitykind/AbsoluteActivity</seealso>
    let AbsoluteActivity = Prefixed_Name(qk, "AbsoluteActivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AbsoluteHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absolute Humidity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AbsoluteHumidity">http://qudt.org/vocab/quantitykind/AbsoluteHumidity</seealso>
    let AbsoluteHumidity = Prefixed_Name(qk, "AbsoluteHumidity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AbsoluteTypographicMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"absolute typographic measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AbsoluteTypographicMeasurement">http://qudt.org/vocab/quantitykind/AbsoluteTypographicMeasurement</seealso>
    let AbsoluteTypographicMeasurement =
        Prefixed_Name(qk, "AbsoluteTypographicMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AbsorbedDose</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Note that the absorbed dose is not a good indicator of the likely biological effect. 1 Gy of alpha radiation would be much more biologically damaging than 1 Gy of photon radiation for example. Appropriate weighting factors can be applied reflecting the different relative biological effects to find the equivalent dose. The risk of stoctic effects due to radiation exposure can be quantified using the effective dose, which is a weighted average of the equivalent dose to each organ depending upon its radiosensitivity. When ionising radiation is used to treat cancer, the doctor will usually prescribe the radiotherapy treatment in Gy. When risk from ionising radiation is being discussed, a related unit, the Sievert is used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Applicable units are those of quantitykind:AbsorbedDose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absorbed Dose"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AbsorbedDose">http://qudt.org/vocab/quantitykind/AbsorbedDose</seealso>
    let AbsorbedDose = Prefixed_Name(qk, "AbsorbedDose") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AbsorbedDoseRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AbsorbedDoseRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absorbed Dose Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AbsorbedDoseRate">http://qudt.org/vocab/quantitykind/AbsorbedDoseRate</seealso>
    let AbsorbedDoseRate = Prefixed_Name(qk, "AbsorbedDoseRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Absorptance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Absorptance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Absorptance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Absorptance">http://qudt.org/vocab/quantitykind/Absorptance</seealso>
    let Absorptance = Prefixed_Name(qk, "Absorptance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Acceleration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pospešek"</para><para>"ivme"</para><para>"accélération"</para><para>"accelerație"</para><para>"aceleração"</para><para>"acceleratio"</para><para>"加速度"</para><para>"Zrychlení"</para><para>"accelerazione"</para><para>"aceleración"</para><para>"त्वरण"</para><para>"التسارع"</para><para>"شتاب"</para><para>"Pecutan"</para><para>"przyspieszenie"</para><para>"Beschleunigung"</para><para>"Ускоре́ние"</para><para>"Όγκος"</para><para>"acceleration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Acceleration">http://qudt.org/vocab/quantitykind/Acceleration</seealso>
    let Acceleration = Prefixed_Name(qk, "Acceleration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AccelerationOfGravity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Acceleration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acceleration Of Gravity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AccelerationOfGravity">http://qudt.org/vocab/quantitykind/AccelerationOfGravity</seealso>
    let AccelerationOfGravity =
        Prefixed_Name(qk, "AccelerationOfGravity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AcceptorDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acceptor Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AcceptorDensity">http://qudt.org/vocab/quantitykind/AcceptorDensity</seealso>
    let AcceptorDensity = Prefixed_Name(qk, "AcceptorDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AcceptorIonizationEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acceptor Ionization Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AcceptorIonizationEnergy">http://qudt.org/vocab/quantitykind/AcceptorIonizationEnergy</seealso>
    let AcceptorIonizationEnergy =
        Prefixed_Name(qk, "AcceptorIonizationEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Acidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Acidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acidity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Acidity">http://qudt.org/vocab/quantitykind/Acidity</seealso>
    let Acidity = Prefixed_Name(qk, "Acidity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AcousticImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AcousticImpedance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acoustic Impediance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AcousticImpedance">http://qudt.org/vocab/quantitykind/AcousticImpedance</seealso>
    let AcousticImpedance = Prefixed_Name(qk, "AcousticImpedance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Action">http://qudt.org/vocab/quantitykind/Action</seealso>
    let Action = Prefixed_Name(qk, "Action") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ActionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Action Time (sec) "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Action Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActionTime">http://qudt.org/vocab/quantitykind/ActionTime</seealso>
    let ActionTime = Prefixed_Name(qk, "ActionTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ActiveEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Active Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActiveEnergy">http://qudt.org/vocab/quantitykind/ActiveEnergy</seealso>
    let ActiveEnergy = Prefixed_Name(qk, "ActiveEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ActivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Active Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActivePower">http://qudt.org/vocab/quantitykind/ActivePower</seealso>
    let ActivePower = Prefixed_Name(qk, "ActivePower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Activity">http://qudt.org/vocab/quantitykind/Activity</seealso>
    let Activity = Prefixed_Name(qk, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ActivityCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ActivityCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activity Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActivityCoefficient">http://qudt.org/vocab/quantitykind/ActivityCoefficient</seealso>
    let ActivityCoefficient = Prefixed_Name(qk, "ActivityCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ActivityConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ActivityConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activity Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActivityConcentration">http://qudt.org/vocab/quantitykind/ActivityConcentration</seealso>
    let ActivityConcentration =
        Prefixed_Name(qk, "ActivityConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ActivityRelatedByMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassicActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"activity related by mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActivityRelatedByMass">http://qudt.org/vocab/quantitykind/ActivityRelatedByMass</seealso>
    let ActivityRelatedByMass =
        Prefixed_Name(qk, "ActivityRelatedByMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ActivityThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Activity Thresholds"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ActivityThresholds">http://qudt.org/vocab/quantitykind/ActivityThresholds</seealso>
    let ActivityThresholds = Prefixed_Name(qk, "ActivityThresholds") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Adaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Adaptation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Adaptation">http://qudt.org/vocab/quantitykind/Adaptation</seealso>
    let Adaptation = Prefixed_Name(qk, "Adaptation") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Admittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Admittance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Admittance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Admittance">http://qudt.org/vocab/quantitykind/Admittance</seealso>
    let Admittance = Prefixed_Name(qk, "Admittance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AlphaDisintegrationEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alpha Disintegration Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AlphaDisintegrationEnergy">http://qudt.org/vocab/quantitykind/AlphaDisintegrationEnergy</seealso>
    let AlphaDisintegrationEnergy =
        Prefixed_Name(qk, "AlphaDisintegrationEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Altitude"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Altitude">http://qudt.org/vocab/quantitykind/Altitude</seealso>
    let Altitude = Prefixed_Name(qk, "Altitude") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AmbientPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ambient Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmbientPressure">http://qudt.org/vocab/quantitykind/AmbientPressure</seealso>
    let AmbientPressure = Prefixed_Name(qk, "AmbientPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfBiologicallyActiveSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"amount of biologically active substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfBiologicallyActiveSubstance">http://qudt.org/vocab/quantitykind/AmountOfBiologicallyActiveSubstance</seealso>
    let AmountOfBiologicallyActiveSubstance =
        Prefixed_Name(qk, "AmountOfBiologicallyActiveSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfCloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfCloudCover"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Amount of cloud cover"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfCloudCover">http://qudt.org/vocab/quantitykind/AmountOfCloudCover</seealso>
    let AmountOfCloudCover = Prefixed_Name(qk, "AmountOfCloudCover") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ποσότητα Ουσίας"</para><para>"Количество вещества"</para><para>"Látkové množství"</para><para>"Количество вещество"</para><para>"quantité de matière"</para><para>"quantità di sostanza"</para><para>"cantidad de sustancia"</para><para>"množina snovi"</para><para>"كمية المادة"</para><para>"liczność materii"</para><para>"cantitate de substanță"</para><para>"مقدار ماده"</para><para>"quantidade de substância"</para><para>"anyagmennyiség"</para><para>"पदार्थ की मात्रा"</para><para>"Jumlah bahan"</para><para>"Stoffmenge"</para><para>"madde miktarı"</para><para>"quantitas substantiae"</para><para>"כמות חומר"</para><para>"物質量"</para><para>"物质的量"</para><para>"amount of substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstance">http://qudt.org/vocab/quantitykind/AmountOfSubstance</seealso>
    let AmountOfSubstance = Prefixed_Name(qk, "AmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstanceConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Amount of Substance of Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceConcentration">http://qudt.org/vocab/quantitykind/AmountOfSubstanceConcentration</seealso>
    let AmountOfSubstanceConcentration =
        Prefixed_Name(qk, "AmountOfSubstanceConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstanceFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfSubstanceFraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fractional Amount of Substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceFraction">http://qudt.org/vocab/quantitykind/AmountOfSubstanceFraction</seealso>
    let AmountOfSubstanceFraction =
        Prefixed_Name(qk, "AmountOfSubstanceFraction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstanceIonConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ion Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceIonConcentration">http://qudt.org/vocab/quantitykind/AmountOfSubstanceIonConcentration</seealso>
    let AmountOfSubstanceIonConcentration =
        Prefixed_Name(qk, "AmountOfSubstanceIonConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstancePerMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfSubstancePerMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Amount of Substance per Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMass">http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMass</seealso>
    let AmountOfSubstancePerMass =
        Prefixed_Name(qk, "AmountOfSubstancePerMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstancePerMassPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfSubstancePerMassPressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Mass variation due to Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMassPressure">http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMassPressure</seealso>
    let AmountOfSubstancePerMassPressure =
        Prefixed_Name(qk, "AmountOfSubstancePerMassPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AmountOfSubstancePerVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Amount of Substance per Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerVolume">http://qudt.org/vocab/quantitykind/AmountOfSubstancePerVolume</seealso>
    let AmountOfSubstancePerVolume =
        Prefixed_Name(qk, "AmountOfSubstancePerVolume") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Angle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Angle">http://qudt.org/vocab/quantitykind/Angle</seealso>
    let Angle = Prefixed_Name(qk, "Angle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngleOfAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angle Of Attack"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngleOfAttack">http://qudt.org/vocab/quantitykind/AngleOfAttack</seealso>
    let AngleOfAttack = Prefixed_Name(qk, "AngleOfAttack") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AngleOfOpticalRotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angle of Optical Rotation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngleOfOpticalRotation">http://qudt.org/vocab/quantitykind/AngleOfOpticalRotation</seealso>
    let AngleOfOpticalRotation =
        Prefixed_Name(qk, "AngleOfOpticalRotation") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AngularAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularAcceleration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accelerație unghiulară"</para><para>"aceleração angular"</para><para>"angular acceleration"</para><para>"Úhlové zrychlení"</para><para>"Угловое ускорение"</para><para>"Winkelbeschleunigung"</para><para>"कोणीय त्वरण"</para><para>"Pecutan bersudut"</para><para>"accelerazione angolare"</para><para>"Przyspieszenie kątowe"</para><para>"تسارع زاوي"</para><para>"角加速度"</para><para>"Açısal ivme"</para><para>"accélération angulaire"</para><para>"شتاب زاویه‌ای"</para><para>"aceleración angular"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularAcceleration">http://qudt.org/vocab/quantitykind/AngularAcceleration</seealso>
    let AngularAcceleration = Prefixed_Name(qk, "AngularAcceleration") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngularCrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularCrossSection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angular Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularCrossSection">http://qudt.org/vocab/quantitykind/AngularCrossSection</seealso>
    let AngularCrossSection = Prefixed_Name(qk, "AngularCrossSection") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngularDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angular Distance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularDistance">http://qudt.org/vocab/quantitykind/AngularDistance</seealso>
    let AngularDistance = Prefixed_Name(qk, "AngularDistance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngularFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularFrequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kreisfrequenz"</para><para>"angular frequency"</para><para>"pulsacja"</para><para>"pulsación"</para><para>"角振動数"</para><para>"角频率"</para><para>"تردد زاوى"</para><para>"frequenza angolare"</para><para>"frequência angular"</para><para>"Pulsación"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularFrequency">http://qudt.org/vocab/quantitykind/AngularFrequency</seealso>
    let AngularFrequency = Prefixed_Name(qk, "AngularFrequency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngularImpulse</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularImpulse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"popęd kątowy"</para><para>"angular impulse"</para><para>"impulsion angulaire"</para><para>"impulso angular"</para><para>"Drehstoß"</para><para>"impulsão angular"</para><para>"角冲量;冲量矩"</para><para>"نبضة دفعية زاوية"</para><para>"角力積"</para><para>"impulso angolare"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularImpulse">http://qudt.org/vocab/quantitykind/AngularImpulse</seealso>
    let AngularImpulse = Prefixed_Name(qk, "AngularImpulse") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngularMomentum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularMomentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angular Momentum"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularMomentum">http://qudt.org/vocab/quantitykind/AngularMomentum</seealso>
    let AngularMomentum = Prefixed_Name(qk, "AngularMomentum") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AngularMomentumPerAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularMomentumPerAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angular Momentum per Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularMomentumPerAngle">http://qudt.org/vocab/quantitykind/AngularMomentumPerAngle</seealso>
    let AngularMomentumPerAngle =
        Prefixed_Name(qk, "AngularMomentumPerAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AngularReciprocalLatticeVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularReciprocalLatticeVector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angular Reciprocal Lattice Vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularReciprocalLatticeVector">http://qudt.org/vocab/quantitykind/AngularReciprocalLatticeVector</seealso>
    let AngularReciprocalLatticeVector =
        Prefixed_Name(qk, "AngularReciprocalLatticeVector") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AngularVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"angular velocity"</para><para>"سرعة زاوية"</para><para>"Úhlová rychlost"</para><para>"velocità angolare"</para><para>"Açısal hız"</para><para>"velocidad angular"</para><para>"سرعت زاویه‌ای"</para><para>"kotna hitrost"</para><para>"कोणीय वेग"</para><para>"Winkelgeschwindigkeit"</para><para>"Halaju bersudut"</para><para>"velocidade angular"</para><para>"Viteză unghiulară"</para><para>"Prędkość kątowa"</para><para>"Угловая скорость"</para><para>"vitesse angulaire"</para><para>"角速度"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularVelocity">http://qudt.org/vocab/quantitykind/AngularVelocity</seealso>
    let AngularVelocity = Prefixed_Name(qk, "AngularVelocity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AngularWavenumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularWavenumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"nombre d'onde angulaire"</para><para>"número de onda angular"</para><para>"liczba falowa kątowa"</para><para>"角波数"</para><para>"Kreisrepetenz"</para><para>"عدد موجى زاوى"</para><para>"numero d'onda angolare"</para><para>"angular wavenumber"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AngularWavenumber">http://qudt.org/vocab/quantitykind/AngularWavenumber</seealso>
    let AngularWavenumber = Prefixed_Name(qk, "AngularWavenumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ApogeeRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Apogee Radius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ApogeeRadius">http://qudt.org/vocab/quantitykind/ApogeeRadius</seealso>
    let ApogeeRadius = Prefixed_Name(qk, "ApogeeRadius") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ApparentPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ApparentPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"puissance apparente"</para><para>"Scheinleistung"</para><para>"moc pozorna"</para><para>"皮相電力"</para><para>"apparent power"</para><para>"potenza apparente"</para><para>"potencia aparente"</para><para>"视在功率"</para><para>"potência aparente"</para><para>"القدرة الظاهرية"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ApparentPower">http://qudt.org/vocab/quantitykind/ApparentPower</seealso>
    let ApparentPower = Prefixed_Name(qk, "ApparentPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ApparentThermalInertia</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ApparentThermalInertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement Unit for a quantity approximately proportional to Thermal Inertia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ApparentThermalInertia">http://qudt.org/vocab/quantitykind/ApparentThermalInertia</seealso>
    let ApparentThermalInertia =
        Prefixed_Name(qk, "ApparentThermalInertia") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pole powierzchni"</para><para>"area"</para><para>"Fläche"</para><para>"área"</para><para>"مساحت"</para><para>"مساحة"</para><para>"plocha"</para><para>"površina"</para><para>"arie"</para><para>"Ταχύτητα"</para><para>"שטח"</para><para>"Площ"</para><para>"aire"</para><para>"Keluasan"</para><para>"Площадь"</para><para>"alan"</para><para>"面積"</para><para>"面积"</para><para>"क्षेत्रफल"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Area">http://qudt.org/vocab/quantitykind/Area</seealso>
    let Area = Prefixed_Name(qk, "Area") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaAngle">http://qudt.org/vocab/quantitykind/AreaAngle</seealso>
    let AreaAngle = Prefixed_Name(qk, "AreaAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaBitDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaBitDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"areic bit density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaBitDensity">http://qudt.org/vocab/quantitykind/AreaBitDensity</seealso>
    let AreaBitDensity = Prefixed_Name(qk, "AreaBitDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaChargeDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"areic charge density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaChargeDensity">http://qudt.org/vocab/quantitykind/AreaChargeDensity</seealso>
    let AreaChargeDensity = Prefixed_Name(qk, "AreaChargeDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"areic mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaMass">http://qudt.org/vocab/quantitykind/AreaMass</seealso>
    let AreaMass = Prefixed_Name(qk, "AreaMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaPerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaPerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"area per length"</para><para>"Fläche pro Längeneinheit"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaPerLength">http://qudt.org/vocab/quantitykind/AreaPerLength</seealso>
    let AreaPerLength = Prefixed_Name(qk, "AreaPerLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaPerPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaPerPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"area per heating load"</para><para>"Fläche pro Heizlast"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaPerPower">http://qudt.org/vocab/quantitykind/AreaPerPower</seealso>
    let AreaPerPower = Prefixed_Name(qk, "AreaPerPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaPerTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaPerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area per Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaPerTime">http://qudt.org/vocab/quantitykind/AreaPerTime</seealso>
    let AreaPerTime = Prefixed_Name(qk, "AreaPerTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaRatio">http://qudt.org/vocab/quantitykind/AreaRatio</seealso>
    let AreaRatio = Prefixed_Name(qk, "AreaRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaTemperature">http://qudt.org/vocab/quantitykind/AreaTemperature</seealso>
    let AreaTemperature = Prefixed_Name(qk, "AreaTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaThermalExpansion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaThermalExpansion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area Thermal Expansion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaThermalExpansion">http://qudt.org/vocab/quantitykind/AreaThermalExpansion</seealso>
    let AreaThermalExpansion = Prefixed_Name(qk, "AreaThermalExpansion") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaTime">http://qudt.org/vocab/quantitykind/AreaTime</seealso>
    let AreaTime = Prefixed_Name(qk, "AreaTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreaTimeTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaTimeTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area Time Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreaTimeTemperature">http://qudt.org/vocab/quantitykind/AreaTimeTemperature</seealso>
    let AreaTimeTemperature = Prefixed_Name(qk, "AreaTimeTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"areic charge density or electric flux density or electric polarization"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization">http://qudt.org/vocab/quantitykind/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization</seealso>
    let AreicChargeDensityOrElectricFluxDensityOrElectricPolarization =
        Prefixed_Name(qk, "AreicChargeDensityOrElectricFluxDensityOrElectricPolarization") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AreicDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"areic data volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreicDataVolume">http://qudt.org/vocab/quantitykind/AreicDataVolume</seealso>
    let AreicDataVolume = Prefixed_Name(qk, "AreicDataVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreicEnergyFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"areic energy flow"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreicEnergyFlow">http://qudt.org/vocab/quantitykind/AreicEnergyFlow</seealso>
    let AreicEnergyFlow = Prefixed_Name(qk, "AreicEnergyFlow") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreicHeatFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aeric Heat Flow Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreicHeatFlowRate">http://qudt.org/vocab/quantitykind/AreicHeatFlowRate</seealso>
    let AreicHeatFlowRate = Prefixed_Name(qk, "AreicHeatFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreicMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"areic mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreicMass">http://qudt.org/vocab/quantitykind/AreicMass</seealso>
    let AreicMass = Prefixed_Name(qk, "AreicMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AreicTorque</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"areic torque"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AreicTorque">http://qudt.org/vocab/quantitykind/AreicTorque</seealso>
    let AreicTorque = Prefixed_Name(qk, "AreicTorque") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Asset"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Asset">http://qudt.org/vocab/quantitykind/Asset</seealso>
    let Asset = Prefixed_Name(qk, "Asset") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AtmosphericHydroxylationRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AtmosphericHydroxylationRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atmospheric Hydroxylation Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtmosphericHydroxylationRate">http://qudt.org/vocab/quantitykind/AtmosphericHydroxylationRate</seealso>
    let AtmosphericHydroxylationRate =
        Prefixed_Name(qk, "AtmosphericHydroxylationRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atmospheric Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtmosphericPressure">http://qudt.org/vocab/quantitykind/AtmosphericPressure</seealso>
    let AtmosphericPressure = Prefixed_Name(qk, "AtmosphericPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AtomScatteringFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AtomScatteringFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atom Scattering Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomScatteringFactor">http://qudt.org/vocab/quantitykind/AtomScatteringFactor</seealso>
    let AtomScatteringFactor = Prefixed_Name(qk, "AtomScatteringFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AtomicAttenuationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atomic Attenuation Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomicAttenuationCoefficient">http://qudt.org/vocab/quantitykind/AtomicAttenuationCoefficient</seealso>
    let AtomicAttenuationCoefficient =
        Prefixed_Name(qk, "AtomicAttenuationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AtomicCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atomic Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomicCharge">http://qudt.org/vocab/quantitykind/AtomicCharge</seealso>
    let AtomicCharge = Prefixed_Name(qk, "AtomicCharge") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AtomicEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"atomic energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomicEnergy">http://qudt.org/vocab/quantitykind/AtomicEnergy</seealso>
    let AtomicEnergy = Prefixed_Name(qk, "AtomicEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AtomicMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atomic Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomicMass">http://qudt.org/vocab/quantitykind/AtomicMass</seealso>
    let AtomicMass = Prefixed_Name(qk, "AtomicMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AtomicNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AtomicNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atomic Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomicNumber">http://qudt.org/vocab/quantitykind/AtomicNumber</seealso>
    let AtomicNumber = Prefixed_Name(qk, "AtomicNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/AtomicStoppingPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"atomic stopping power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AtomicStoppingPower">http://qudt.org/vocab/quantitykind/AtomicStoppingPower</seealso>
    let AtomicStoppingPower = Prefixed_Name(qk, "AtomicStoppingPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AttenuationCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AttenuationCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attenuation Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AttenuationCoefficient">http://qudt.org/vocab/quantitykind/AttenuationCoefficient</seealso>
    let AttenuationCoefficient =
        Prefixed_Name(qk, "AttenuationCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AuditoryThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SoundPowerLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Auditory Thresholds"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AuditoryThresholds">http://qudt.org/vocab/quantitykind/AuditoryThresholds</seealso>
    let AuditoryThresholds = Prefixed_Name(qk, "AuditoryThresholds") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AuxillaryMagneticField</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MagneticFieldStrength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Auxillary Magnetic Field"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AuxillaryMagneticField">http://qudt.org/vocab/quantitykind/AuxillaryMagneticField</seealso>
    let AuxillaryMagneticField =
        Prefixed_Name(qk, "AuxillaryMagneticField") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AverageEnergyLossPerElementaryChargeProduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Energy Loss per Elementary Charge Produced"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AverageEnergyLossPerElementaryChargeProduced">http://qudt.org/vocab/quantitykind/AverageEnergyLossPerElementaryChargeProduced</seealso>
    let AverageEnergyLossPerElementaryChargeProduced =
        Prefixed_Name(qk, "AverageEnergyLossPerElementaryChargeProduced") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AverageHeadEndPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Head End Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AverageHeadEndPressure">http://qudt.org/vocab/quantitykind/AverageHeadEndPressure</seealso>
    let AverageHeadEndPressure =
        Prefixed_Name(qk, "AverageHeadEndPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AverageLogarithmicEnergyDecrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AverageLogarithmicEnergyDecrement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Logarithmic Energy Decrement"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AverageLogarithmicEnergyDecrement">http://qudt.org/vocab/quantitykind/AverageLogarithmicEnergyDecrement</seealso>
    let AverageLogarithmicEnergyDecrement =
        Prefixed_Name(qk, "AverageLogarithmicEnergyDecrement") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AverageSpecificImpulse</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Avg Specific Impulse (lbf-sec/lbm) "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Specific Impulse"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AverageSpecificImpulse">http://qudt.org/vocab/quantitykind/AverageSpecificImpulse</seealso>
    let AverageSpecificImpulse =
        Prefixed_Name(qk, "AverageSpecificImpulse") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/AverageVacuumThrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Vacuum Thrust"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/AverageVacuumThrust">http://qudt.org/vocab/quantitykind/AverageVacuumThrust</seealso>
    let AverageVacuumThrust = Prefixed_Name(qk, "AverageVacuumThrust") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Azimuth</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Azimuth"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Azimuth">http://qudt.org/vocab/quantitykind/Azimuth</seealso>
    let Azimuth = Prefixed_Name(qk, "Azimuth") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BandwidthDistanceProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"bandwidth distance product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BandwidthDistanceProduct">http://qudt.org/vocab/quantitykind/BandwidthDistanceProduct</seealso>
    let BandwidthDistanceProduct =
        Prefixed_Name(qk, "BandwidthDistanceProduct") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BandwidthLengthProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"bandwidth length product"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BandwidthLengthProduct">http://qudt.org/vocab/quantitykind/BandwidthLengthProduct</seealso>
    let BandwidthLengthProduct =
        Prefixed_Name(qk, "BandwidthLengthProduct") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Basicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Basicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Basicity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Basicity">http://qudt.org/vocab/quantitykind/Basicity</seealso>
    let Basicity = Prefixed_Name(qk, "Basicity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BatteryCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BatteryCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"battery capacity"</para><para>"battery capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BatteryCapacity">http://qudt.org/vocab/quantitykind/BatteryCapacity</seealso>
    let BatteryCapacity = Prefixed_Name(qk, "BatteryCapacity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BendingMomentOfForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Torque"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bending Moment of Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BendingMomentOfForce">http://qudt.org/vocab/quantitykind/BendingMomentOfForce</seealso>
    let BendingMomentOfForce = Prefixed_Name(qk, "BendingMomentOfForce") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BetaDisintegrationEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beta Disintegration Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BetaDisintegrationEnergy">http://qudt.org/vocab/quantitykind/BetaDisintegrationEnergy</seealso>
    let BetaDisintegrationEnergy =
        Prefixed_Name(qk, "BetaDisintegrationEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BevelGearPitchAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bevel Gear Pitch Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BevelGearPitchAngle">http://qudt.org/vocab/quantitykind/BevelGearPitchAngle</seealso>
    let BevelGearPitchAngle = Prefixed_Name(qk, "BevelGearPitchAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BinaryLogarithmicMedianInformationFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"median information flow (from a source of information), expressed as a binary logarithm"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BinaryLogarithmicMedianInformationFlow">http://qudt.org/vocab/quantitykind/BinaryLogarithmicMedianInformationFlow</seealso>
    let BinaryLogarithmicMedianInformationFlow =
        Prefixed_Name(qk, "BinaryLogarithmicMedianInformationFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BindingFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BindingFraction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Binding Fraction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BindingFraction">http://qudt.org/vocab/quantitykind/BindingFraction</seealso>
    let BindingFraction = Prefixed_Name(qk, "BindingFraction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BioconcentrationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BioconcentrationFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bioconcentration Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BioconcentrationFactor">http://qudt.org/vocab/quantitykind/BioconcentrationFactor</seealso>
    let BioconcentrationFactor =
        Prefixed_Name(qk, "BioconcentrationFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BiodegredationHalfLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BiodegredationHalfLife"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biodegredation Half Life"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BiodegredationHalfLife">http://qudt.org/vocab/quantitykind/BiodegredationHalfLife</seealso>
    let BiodegredationHalfLife =
        Prefixed_Name(qk, "BiodegredationHalfLife") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BiogeochemicalRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BiogeochemicalRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biogeochemical Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BiogeochemicalRate">http://qudt.org/vocab/quantitykind/BiogeochemicalRate</seealso>
    let BiogeochemicalRate = Prefixed_Name(qk, "BiogeochemicalRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BitDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"bit data volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BitDataVolume">http://qudt.org/vocab/quantitykind/BitDataVolume</seealso>
    let BitDataVolume = Prefixed_Name(qk, "BitDataVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BitRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bit rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BitRate">http://qudt.org/vocab/quantitykind/BitRate</seealso>
    let BitRate = Prefixed_Name(qk, "BitRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BitTransmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BitRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bit transmission rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BitTransmissionRate">http://qudt.org/vocab/quantitykind/BitTransmissionRate</seealso>
    let BitTransmissionRate = Prefixed_Name(qk, "BitTransmissionRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BloodGlucoseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BloodGlucoseLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Blood Glucose Level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BloodGlucoseLevel">http://qudt.org/vocab/quantitykind/BloodGlucoseLevel</seealso>
    let BloodGlucoseLevel = Prefixed_Name(qk, "BloodGlucoseLevel") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BloodGlucoseLevel_Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Blood Glucose Level by Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BloodGlucoseLevel_Mass">http://qudt.org/vocab/quantitykind/BloodGlucoseLevel_Mass</seealso>
    let BloodGlucoseLevel_Mass =
        Prefixed_Name(qk, "BloodGlucoseLevel_Mass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/BodyMassIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BodyMassIndex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Body Mass Index"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BodyMassIndex">http://qudt.org/vocab/quantitykind/BodyMassIndex</seealso>
    let BodyMassIndex = Prefixed_Name(qk, "BodyMassIndex") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BoilingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BoilingPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boiling Point Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BoilingPoint">http://qudt.org/vocab/quantitykind/BoilingPoint</seealso>
    let BoilingPoint = Prefixed_Name(qk, "BoilingPoint") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BraggAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bragg Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BraggAngle">http://qudt.org/vocab/quantitykind/BraggAngle</seealso>
    let BraggAngle = Prefixed_Name(qk, "BraggAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Breadth</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"širina"</para><para>"largeur"</para><para>"genişliği"</para><para>"العرض"</para><para>"breadth"</para><para>"larghezza"</para><para>"寬度"</para><para>"szerokość"</para><para>"ancho"</para><para>"عرض"</para><para>"ширина"</para><para>"lebar"</para><para>"Breite"</para><para>"šířka"</para><para>"largura"</para><para>"幅"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Breadth">http://qudt.org/vocab/quantitykind/Breadth</seealso>
    let Breadth = Prefixed_Name(qk, "Breadth") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BucklingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Buckling Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BucklingFactor">http://qudt.org/vocab/quantitykind/BucklingFactor</seealso>
    let BucklingFactor = Prefixed_Name(qk, "BucklingFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BulkModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BulkModulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bulk Modulus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BulkModulus">http://qudt.org/vocab/quantitykind/BulkModulus</seealso>
    let BulkModulus = Prefixed_Name(qk, "BulkModulus") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BurgersVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Burgers Vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BurgersVector">http://qudt.org/vocab/quantitykind/BurgersVector</seealso>
    let BurgersVector = Prefixed_Name(qk, "BurgersVector") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BurnRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Burn Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BurnRate">http://qudt.org/vocab/quantitykind/BurnRate</seealso>
    let BurnRate = Prefixed_Name(qk, "BurnRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BurnTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Burn Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BurnTime">http://qudt.org/vocab/quantitykind/BurnTime</seealso>
    let BurnTime = Prefixed_Name(qk, "BurnTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/BurstFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:BurstFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"burst factor"</para><para>"burst factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/BurstFactor">http://qudt.org/vocab/quantitykind/BurstFactor</seealso>
    let BurstFactor = Prefixed_Name(qk, "BurstFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ByteDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"byte data volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ByteDataVolume">http://qudt.org/vocab/quantitykind/ByteDataVolume</seealso>
    let ByteDataVolume = Prefixed_Name(qk, "ByteDataVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ByteRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ByteRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"byte rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ByteRate">http://qudt.org/vocab/quantitykind/ByteRate</seealso>
    let ByteRate = Prefixed_Name(qk, "ByteRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ByteTransmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ByteRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"byte transmission rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ByteTransmissionRate">http://qudt.org/vocab/quantitykind/ByteTransmissionRate</seealso>
    let ByteTransmissionRate = Prefixed_Name(qk, "ByteTransmissionRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CENTER-OF-GRAVITY_X</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Gravity in the X axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_X">http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_X</seealso>
    let CENTER_OF_GRAVITY_X = Prefixed_Name(qk, "CENTER-OF-GRAVITY_X") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CENTER-OF-GRAVITY_Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Gravity in the Y axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Y">http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Y</seealso>
    let CENTER_OF_GRAVITY_Y = Prefixed_Name(qk, "CENTER-OF-GRAVITY_Y") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CENTER-OF-GRAVITY_Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Gravity in the Z axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Z">http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Z</seealso>
    let CENTER_OF_GRAVITY_Z = Prefixed_Name(qk, "CENTER-OF-GRAVITY_Z") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CENTER-OF-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Mass (CoM)"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CENTER-OF-MASS">http://qudt.org/vocab/quantitykind/CENTER-OF-MASS</seealso>
    let CENTER_OF_MASS = Prefixed_Name(qk, "CENTER-OF-MASS") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CO2Equivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CO2Equivalent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CO2Equivalent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CO2Equivalent">http://qudt.org/vocab/quantitykind/CO2Equivalent</seealso>
    let CO2Equivalent = Prefixed_Name(qk, "CO2Equivalent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CONTRACT-END-ITEM-SPECIFICATION-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contract End Item (CEI) Specification Mass."</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CONTRACT-END-ITEM-SPECIFICATION-MASS">http://qudt.org/vocab/quantitykind/CONTRACT-END-ITEM-SPECIFICATION-MASS</seealso>
    let CONTRACT_END_ITEM_SPECIFICATION_MASS =
        Prefixed_Name(qk, "CONTRACT-END-ITEM-SPECIFICATION-MASS") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CONTROL-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Control Mass."</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CONTROL-MASS">http://qudt.org/vocab/quantitykind/CONTROL-MASS</seealso>
    let CONTROL_MASS = Prefixed_Name(qk, "CONTROL-MASS") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CanonicalPartitionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CanonicalPartitionFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Canonical Partition Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CanonicalPartitionFunction">http://qudt.org/vocab/quantitykind/CanonicalPartitionFunction</seealso>
    let CanonicalPartitionFunction =
        Prefixed_Name(qk, "CanonicalPartitionFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Capacitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Capacitance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Capacitance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Capacitance">http://qudt.org/vocab/quantitykind/Capacitance</seealso>
    let Capacitance = Prefixed_Name(qk, "Capacitance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Capacity">http://qudt.org/vocab/quantitykind/Capacity</seealso>
    let Capacity = Prefixed_Name(qk, "Capacity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CarrierLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Carrier LifetIme"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CarrierLifetime">http://qudt.org/vocab/quantitykind/CarrierLifetime</seealso>
    let CarrierLifetime = Prefixed_Name(qk, "CarrierLifetime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CartesianArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cartesian Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CartesianArea">http://qudt.org/vocab/quantitykind/CartesianArea</seealso>
    let CartesianArea = Prefixed_Name(qk, "CartesianArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CartesianCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kartézská soustava souřadnic"</para><para>"直角坐标系"</para><para>"coordinate cartesiane"</para><para>"Cartesian coordinates"</para><para>"kartezyen koordinatları"</para><para>"kartesische Koordinaten"</para><para>"مختصات دکارتی"</para><para>"coordonnées cartésiennes"</para><para>"coordenadas cartesianas"</para><para>"Koordiant Kartesius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CartesianCoordinates">http://qudt.org/vocab/quantitykind/CartesianCoordinates</seealso>
    let CartesianCoordinates = Prefixed_Name(qk, "CartesianCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CartesianVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"prostornina"</para><para>"volume"</para><para>"Обем"</para><para>"volum"</para><para>"आयतन"</para><para>"Объём"</para><para>"Isipadu"</para><para>"体积"</para><para>"objętość"</para><para>"Επιτάχυνση"</para><para>"Volumen"</para><para>"Objem"</para><para>"حجم"</para><para>"נפח"</para><para>"hacim"</para><para>"volumen"</para><para>"体積"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CartesianVolume">http://qudt.org/vocab/quantitykind/CartesianVolume</seealso>
    let CartesianVolume = Prefixed_Name(qk, "CartesianVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CatalyticActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CatalyticActivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Catalytic Activity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CatalyticActivity">http://qudt.org/vocab/quantitykind/CatalyticActivity</seealso>
    let CatalyticActivity = Prefixed_Name(qk, "CatalyticActivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CatalyticActivityConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CatalyticActivityConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Catalytic Activity Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CatalyticActivityConcentration">http://qudt.org/vocab/quantitykind/CatalyticActivityConcentration</seealso>
    let CatalyticActivityConcentration =
        Prefixed_Name(qk, "CatalyticActivityConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CationExchangeCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ReactiveChargePerMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cation Exchange Capacity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CationExchangeCapacity">http://qudt.org/vocab/quantitykind/CationExchangeCapacity</seealso>
    let CationExchangeCapacity =
        Prefixed_Name(qk, "CationExchangeCapacity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CelsiusTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Температура Цельсия"</para><para>"Suhu Celsius"</para><para>"درجة الحرارة المئوية أو السيلسيوس"</para><para>"teplota"</para><para>"temperatură Celsius"</para><para>"دمای سلسیوس/سانتیگراد"</para><para>"Celsius sıcaklık"</para><para>"सेल्सियस तापमान"</para><para>"温度"</para><para>"temperatura"</para><para>"צלזיוס"</para><para>"Celsius temperature"</para><para>"temperatura Celsius"</para><para>"Celsius-Temperatur"</para><para>"temperatura celsius"</para><para>"température Celsius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CelsiusTemperature">http://qudt.org/vocab/quantitykind/CelsiusTemperature</seealso>
    let CelsiusTemperature = Prefixed_Name(qk, "CelsiusTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CenterOfGravity_X</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Gravity in the X axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CenterOfGravity_X">http://qudt.org/vocab/quantitykind/CenterOfGravity_X</seealso>
    let CenterOfGravity_X = Prefixed_Name(qk, "CenterOfGravity_X") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CenterOfGravity_Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Gravity in the Y axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CenterOfGravity_Y">http://qudt.org/vocab/quantitykind/CenterOfGravity_Y</seealso>
    let CenterOfGravity_Y = Prefixed_Name(qk, "CenterOfGravity_Y") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CenterOfGravity_Z</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Center of Gravity in the Z axis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CenterOfGravity_Z">http://qudt.org/vocab/quantitykind/CenterOfGravity_Z</seealso>
    let CenterOfGravity_Z = Prefixed_Name(qk, "CenterOfGravity_Z") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CharacteristicAcousticImpedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AcousticImpedance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Characteristic Acoustic Impedance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CharacteristicAcousticImpedance">http://qudt.org/vocab/quantitykind/CharacteristicAcousticImpedance</seealso>
    let CharacteristicAcousticImpedance =
        Prefixed_Name(qk, "CharacteristicAcousticImpedance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CharacteristicNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"characteristic number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CharacteristicNumber">http://qudt.org/vocab/quantitykind/CharacteristicNumber</seealso>
    let CharacteristicNumber = Prefixed_Name(qk, "CharacteristicNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CharacteristicVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Characteristic Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CharacteristicVelocity">http://qudt.org/vocab/quantitykind/CharacteristicVelocity</seealso>
    let CharacteristicVelocity =
        Prefixed_Name(qk, "CharacteristicVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ChargeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ChargeNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Charge Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ChargeNumber">http://qudt.org/vocab/quantitykind/ChargeNumber</seealso>
    let ChargeNumber = Prefixed_Name(qk, "ChargeNumber") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ChemicalAffinity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ChemicalAffinity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemical Affinity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ChemicalAffinity">http://qudt.org/vocab/quantitykind/ChemicalAffinity</seealso>
    let ChemicalAffinity = Prefixed_Name(qk, "ChemicalAffinity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ChemicalConsumptionPerMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemical Consumption per Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ChemicalConsumptionPerMass">http://qudt.org/vocab/quantitykind/ChemicalConsumptionPerMass</seealso>
    let ChemicalConsumptionPerMass =
        Prefixed_Name(qk, "ChemicalConsumptionPerMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ChemicalPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MolarEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"potencial químico"</para><para>"جهد كيميائي"</para><para>"化学ポテンシャル"</para><para>"پتانسیل شیمیایی"</para><para>"Potențial chimic"</para><para>"chemical potential"</para><para>"potential chimique"</para><para>"kimyasal potansiyel"</para><para>"chemisches Potential des Stoffs B"</para><para>"Potencjał chemiczny"</para><para>"Химический потенциал"</para><para>"potenziale chimico"</para><para>"Keupayaan kimia"</para><para>"化学势"</para><para>"Chemický potenciál"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ChemicalPotential">http://qudt.org/vocab/quantitykind/ChemicalPotential</seealso>
    let ChemicalPotential = Prefixed_Name(qk, "ChemicalPotential") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Chromaticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Chromaticity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chromaticity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Chromaticity">http://qudt.org/vocab/quantitykind/Chromaticity</seealso>
    let Chromaticity = Prefixed_Name(qk, "Chromaticity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Circulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AreaPerTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Circulation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Circulation">http://qudt.org/vocab/quantitykind/Circulation</seealso>
    let Circulation = Prefixed_Name(qk, "Circulation") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ClosestApproachRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Closest Approach Radius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ClosestApproachRadius">http://qudt.org/vocab/quantitykind/ClosestApproachRadius</seealso>
    let ClosestApproachRadius =
        Prefixed_Name(qk, "ClosestApproachRadius") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CoefficientOfHeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CoefficientOfHeatTransfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coefficient of heat transfer"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CoefficientOfHeatTransfer">http://qudt.org/vocab/quantitykind/CoefficientOfHeatTransfer</seealso>
    let CoefficientOfHeatTransfer =
        Prefixed_Name(qk, "CoefficientOfHeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CoefficientOfPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CoefficientOfPerformance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CoefficientOfPerformance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CoefficientOfPerformance">http://qudt.org/vocab/quantitykind/CoefficientOfPerformance</seealso>
    let CoefficientOfPerformance =
        Prefixed_Name(qk, "CoefficientOfPerformance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Coercivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Coercivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coercivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Coercivity">http://qudt.org/vocab/quantitykind/Coercivity</seealso>
    let Coercivity = Prefixed_Name(qk, "Coercivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CoherenceLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coherence Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CoherenceLength">http://qudt.org/vocab/quantitykind/CoherenceLength</seealso>
    let CoherenceLength = Prefixed_Name(qk, "CoherenceLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ColdReceptorThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cold Receptor Threshold"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ColdReceptorThreshold">http://qudt.org/vocab/quantitykind/ColdReceptorThreshold</seealso>
    let ColdReceptorThreshold =
        Prefixed_Name(qk, "ColdReceptorThreshold") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CombinedNonEvaporativeHeatTransferCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CombinedNonEvaporativeHeatTransferCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Combined Non Evaporative Heat Transfer Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CombinedNonEvaporativeHeatTransferCoefficient">http://qudt.org/vocab/quantitykind/CombinedNonEvaporativeHeatTransferCoefficient</seealso>
    let CombinedNonEvaporativeHeatTransferCoefficient =
        Prefixed_Name(qk, "CombinedNonEvaporativeHeatTransferCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CombustionChamberTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermodynamicTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Combustion Chamber Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CombustionChamberTemperature">http://qudt.org/vocab/quantitykind/CombustionChamberTemperature</seealso>
    let CombustionChamberTemperature =
        Prefixed_Name(qk, "CombustionChamberTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CommonLogarithmicMedianInformationFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"median information flow (from a source of information), expressed as a common logarithm "</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CommonLogarithmicMedianInformationFlow">http://qudt.org/vocab/quantitykind/CommonLogarithmicMedianInformationFlow</seealso>
    let CommonLogarithmicMedianInformationFlow =
        Prefixed_Name(qk, "CommonLogarithmicMedianInformationFlow") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ComplexFrequency_Imaginary</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imaginary part of complex frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ComplexFrequency_Imaginary">http://qudt.org/vocab/quantitykind/ComplexFrequency_Imaginary</seealso>
    let ComplexFrequency_Imaginary =
        Prefixed_Name(qk, "ComplexFrequency_Imaginary") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ComplexFrequency_Real</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"real part of complex frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ComplexFrequency_Real">http://qudt.org/vocab/quantitykind/ComplexFrequency_Real</seealso>
    let ComplexFrequency_Real =
        Prefixed_Name(qk, "ComplexFrequency_Real") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ComplexPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Complex Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ComplexPower">http://qudt.org/vocab/quantitykind/ComplexPower</seealso>
    let ComplexPower = Prefixed_Name(qk, "ComplexPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CompoundPlaneAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PlaneAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compound Plane Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CompoundPlaneAngle">http://qudt.org/vocab/quantitykind/CompoundPlaneAngle</seealso>
    let CompoundPlaneAngle = Prefixed_Name(qk, "CompoundPlaneAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Compressibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Compressibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compressibility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Compressibility">http://qudt.org/vocab/quantitykind/Compressibility</seealso>
    let Compressibility = Prefixed_Name(qk, "Compressibility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CompressibilityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compressibility Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CompressibilityFactor">http://qudt.org/vocab/quantitykind/CompressibilityFactor</seealso>
    let CompressibilityFactor =
        Prefixed_Name(qk, "CompressibilityFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Concentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Concentration">http://qudt.org/vocab/quantitykind/Concentration</seealso>
    let Concentration = Prefixed_Name(qk, "Concentration") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Conductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Conductance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Conductance">http://qudt.org/vocab/quantitykind/Conductance</seealso>
    let Conductance = Prefixed_Name(qk, "Conductance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ConductionSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ConductionSpeed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conduction Speed"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ConductionSpeed">http://qudt.org/vocab/quantitykind/ConductionSpeed</seealso>
    let ConductionSpeed = Prefixed_Name(qk, "ConductionSpeed") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ConductiveHeatTransferRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HeatFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductive Heat Transfer Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ConductiveHeatTransferRate">http://qudt.org/vocab/quantitykind/ConductiveHeatTransferRate</seealso>
    let ConductiveHeatTransferRate =
        Prefixed_Name(qk, "ConductiveHeatTransferRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Conductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Conductivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Conductivity">http://qudt.org/vocab/quantitykind/Conductivity</seealso>
    let Conductivity = Prefixed_Name(qk, "Conductivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ConductivityVariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ConductivityVariance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conductivity Variance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ConductivityVariance">http://qudt.org/vocab/quantitykind/ConductivityVariance</seealso>
    let ConductivityVariance = Prefixed_Name(qk, "ConductivityVariance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ConductivityVariance_NEON</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Conductivity Variance, NEON"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ConductivityVariance_NEON">http://qudt.org/vocab/quantitykind/ConductivityVariance_NEON</seealso>
    let ConductivityVariance_NEON =
        Prefixed_Name(qk, "ConductivityVariance_NEON") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Constringence</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Constringence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constringence"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Constringence">http://qudt.org/vocab/quantitykind/Constringence</seealso>
    let Constringence = Prefixed_Name(qk, "Constringence") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ConvectiveHeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HeatFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convective Heat Transfer"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ConvectiveHeatTransfer">http://qudt.org/vocab/quantitykind/ConvectiveHeatTransfer</seealso>
    let ConvectiveHeatTransfer =
        Prefixed_Name(qk, "ConvectiveHeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CoolingPerformanceRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CoolingPerformanceRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cooling Performance Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CoolingPerformanceRatio">http://qudt.org/vocab/quantitykind/CoolingPerformanceRatio</seealso>
    let CoolingPerformanceRatio =
        Prefixed_Name(qk, "CoolingPerformanceRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CorrelatedColorTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CorrelatedColorTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Correlated Colour Temperature"</para><para>"Correlated Color Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CorrelatedColorTemperature">http://qudt.org/vocab/quantitykind/CorrelatedColorTemperature</seealso>
    let CorrelatedColorTemperature =
        Prefixed_Name(qk, "CorrelatedColorTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CostPerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CostPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cost per area"</para><para>"Kosten pro Fläche"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CostPerArea">http://qudt.org/vocab/quantitykind/CostPerArea</seealso>
    let CostPerArea = Prefixed_Name(qk, "CostPerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CostPerEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CostPerEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energiekosten"</para><para>"energy cost"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CostPerEnergy">http://qudt.org/vocab/quantitykind/CostPerEnergy</seealso>
    let CostPerEnergy = Prefixed_Name(qk, "CostPerEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CostPerMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CostPerMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kosten pro Masse"</para><para>"cost per mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CostPerMass">http://qudt.org/vocab/quantitykind/CostPerMass</seealso>
    let CostPerMass = Prefixed_Name(qk, "CostPerMass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CostPerPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CostPerPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anschaffungskosten pro Watt"</para><para>"cost per power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CostPerPower">http://qudt.org/vocab/quantitykind/CostPerPower</seealso>
    let CostPerPower = Prefixed_Name(qk, "CostPerPower") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Count"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Count">http://qudt.org/vocab/quantitykind/Count</seealso>
    let Count = Prefixed_Name(qk, "Count") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CountRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CountRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CountRate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CountRate">http://qudt.org/vocab/quantitykind/CountRate</seealso>
    let CountRate = Prefixed_Name(qk, "CountRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CouplingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CouplingFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"結合定数"</para><para>"Constantă de cuplaj"</para><para>"耦合常數"</para><para>"constante de couplage"</para><para>"coupling factor"</para><para>"fattore di accoppiamento"</para><para>"stała sprzężenia"</para><para>"constante de acoplamiento"</para><para>"Çiftlenim sabiti"</para><para>"Константа взаимодействия"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CouplingFactor">http://qudt.org/vocab/quantitykind/CouplingFactor</seealso>
    let CouplingFactor = Prefixed_Name(qk, "CouplingFactor") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CrossSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cross-section"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CrossSection">http://qudt.org/vocab/quantitykind/CrossSection</seealso>
    let CrossSection = Prefixed_Name(qk, "CrossSection") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CrossSectionalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cross-sectional Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CrossSectionalArea">http://qudt.org/vocab/quantitykind/CrossSectionalArea</seealso>
    let CrossSectionalArea = Prefixed_Name(qk, "CrossSectionalArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CubicElectricDipoleMomentPerSquareEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CubicElectricDipoleMomentPerSquareEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cubic Electric Dipole Moment per Square Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CubicElectricDipoleMomentPerSquareEnergy">http://qudt.org/vocab/quantitykind/CubicElectricDipoleMomentPerSquareEnergy</seealso>
    let CubicElectricDipoleMomentPerSquareEnergy =
        Prefixed_Name(qk, "CubicElectricDipoleMomentPerSquareEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CubicExpansionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ExpansionRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"معامل التمدد الحجمى"</para><para>"מספר גל"</para><para>"coefficient de dilatation volumique"</para><para>"Температурный коэффициент"</para><para>"Вълново число"</para><para>"kübik genleşme katsayısı"</para><para>"coeficiente de dilatación cúbica"</para><para>"線膨張係数"</para><para>"coefficiente di dilatazione volumica"</para><para>"Κυματαριθμός"</para><para>"cubic expansion coefficient"</para><para>"Volumenausdehnungskoeffizient"</para><para>"ضریب انبساط گرمایی"</para><para>"współczynnik rozszerzalności objętościowej"</para><para>"coeficiente de dilatação volúmica"</para><para>"体膨胀系数"</para><para>"Hullámszám"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CubicExpansionCoefficient">http://qudt.org/vocab/quantitykind/CubicExpansionCoefficient</seealso>
    let CubicExpansionCoefficient =
        Prefixed_Name(qk, "CubicExpansionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CurieTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"क्यूरी ताप"</para><para>"Точка Кюри"</para><para>"居里点"</para><para>"Curie temperature"</para><para>"temperatura Curie"</para><para>"température de Curie"</para><para>"temperatura de Curie"</para><para>"نقطه کوری"</para><para>"キュリー温度"</para><para>"Curie-Temperatur"</para><para>"Suhu Curie"</para><para>"Curie sıcaklığı"</para><para>"Curieova teplota"</para><para>"Punct Curie"</para><para>"punto di Curie"</para><para>"درجة حرارة كوري"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CurieTemperature">http://qudt.org/vocab/quantitykind/CurieTemperature</seealso>
    let CurieTemperature = Prefixed_Name(qk, "CurieTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Currency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Currency">http://qudt.org/vocab/quantitykind/Currency</seealso>
    let Currency = Prefixed_Name(qk, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CurrencyPerFlight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CurrencyPerFlight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Currency Per Flight"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CurrencyPerFlight">http://qudt.org/vocab/quantitykind/CurrencyPerFlight</seealso>
    let CurrencyPerFlight = Prefixed_Name(qk, "CurrencyPerFlight") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CurrentLinkage</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CurrentLinkage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Current Linkage"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CurrentLinkage">http://qudt.org/vocab/quantitykind/CurrentLinkage</seealso>
    let CurrentLinkage = Prefixed_Name(qk, "CurrentLinkage") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CurrentOfTheAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"current of the amount of substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CurrentOfTheAmountOfSubstance">http://qudt.org/vocab/quantitykind/CurrentOfTheAmountOfSubstance</seealso>
    let CurrentOfTheAmountOfSubstance =
        Prefixed_Name(qk, "CurrentOfTheAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Curvature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Curvature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Curvature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Curvature">http://qudt.org/vocab/quantitykind/Curvature</seealso>
    let Curvature = Prefixed_Name(qk, "Curvature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CurvatureFromRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CurvatureFromRadius"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Curvature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CurvatureFromRadius">http://qudt.org/vocab/quantitykind/CurvatureFromRadius</seealso>
    let CurvatureFromRadius = Prefixed_Name(qk, "CurvatureFromRadius") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/CutoffCurrentRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"I²t-value"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CutoffCurrentRating">http://qudt.org/vocab/quantitykind/CutoffCurrentRating</seealso>
    let CutoffCurrentRating = Prefixed_Name(qk, "CutoffCurrentRating") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/CyclotronAngularFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularFrequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Larmor Angular Frequency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/CyclotronAngularFrequency">http://qudt.org/vocab/quantitykind/CyclotronAngularFrequency</seealso>
    let CyclotronAngularFrequency =
        Prefixed_Name(qk, "CyclotronAngularFrequency") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DELTA-V</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delta-V"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DELTA-V">http://qudt.org/vocab/quantitykind/DELTA-V</seealso>
    let DELTA_V = Prefixed_Name(qk, "DELTA-V") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DRY-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dry Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DRY-MASS">http://qudt.org/vocab/quantitykind/DRY-MASS</seealso>
    let DRY_MASS = Prefixed_Name(qk, "DRY-MASS") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DataRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DataRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DataRate">http://qudt.org/vocab/quantitykind/DataRate</seealso>
    let DataRate = Prefixed_Name(qk, "DataRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DataTransmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"data transmission rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DataTransmissionRate">http://qudt.org/vocab/quantitykind/DataTransmissionRate</seealso>
    let DataTransmissionRate = Prefixed_Name(qk, "DataTransmissionRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DatasetOfBits</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DatasetOfBits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dataset of bits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DatasetOfBits">http://qudt.org/vocab/quantitykind/DatasetOfBits</seealso>
    let DatasetOfBits = Prefixed_Name(qk, "DatasetOfBits") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DatasetOfBytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"dataset of bytes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DatasetOfBytes">http://qudt.org/vocab/quantitykind/DatasetOfBytes</seealso>
    let DatasetOfBytes = Prefixed_Name(qk, "DatasetOfBytes") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Debye-WallerFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Debye-WallerFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Debye-Waller Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Debye-WallerFactor">http://qudt.org/vocab/quantitykind/Debye-WallerFactor</seealso>
    let Debye_WallerFactor = Prefixed_Name(qk, "Debye-WallerFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DebyeAngularFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularFrequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Debye Angular Frequency"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DebyeAngularFrequency">http://qudt.org/vocab/quantitykind/DebyeAngularFrequency</seealso>
    let DebyeAngularFrequency =
        Prefixed_Name(qk, "DebyeAngularFrequency") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DebyeAngularWavenumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DebyeAngularWavenumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Debye Angular Wavenumber"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DebyeAngularWavenumber">http://qudt.org/vocab/quantitykind/DebyeAngularWavenumber</seealso>
    let DebyeAngularWavenumber =
        Prefixed_Name(qk, "DebyeAngularWavenumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DebyeTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Debye Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DebyeTemperature">http://qudt.org/vocab/quantitykind/DebyeTemperature</seealso>
    let DebyeTemperature = Prefixed_Name(qk, "DebyeTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DecayConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DecayConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Decay Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DecayConstant">http://qudt.org/vocab/quantitykind/DecayConstant</seealso>
    let DecayConstant = Prefixed_Name(qk, "DecayConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DegreeOfDissociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DegreeOfDissociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Degree of Dissociation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DegreeOfDissociation">http://qudt.org/vocab/quantitykind/DegreeOfDissociation</seealso>
    let DegreeOfDissociation = Prefixed_Name(qk, "DegreeOfDissociation") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Density</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Density">http://qudt.org/vocab/quantitykind/Density</seealso>
    let Density = Prefixed_Name(qk, "Density") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DensityInCombustionChamber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Density In Combustion Chamber"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DensityInCombustionChamber">http://qudt.org/vocab/quantitykind/DensityInCombustionChamber</seealso>
    let DensityInCombustionChamber =
        Prefixed_Name(qk, "DensityInCombustionChamber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DensityOfStates</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Density of states"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DensityOfStates">http://qudt.org/vocab/quantitykind/DensityOfStates</seealso>
    let DensityOfStates = Prefixed_Name(qk, "DensityOfStates") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DensityOfTheExhaustGases</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Density Of The Exhaust Gases"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DensityOfTheExhaustGases">http://qudt.org/vocab/quantitykind/DensityOfTheExhaustGases</seealso>
    let DensityOfTheExhaustGases =
        Prefixed_Name(qk, "DensityOfTheExhaustGases") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Depth"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Depth">http://qudt.org/vocab/quantitykind/Depth</seealso>
    let Depth = Prefixed_Name(qk, "Depth") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dew Point Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DewPointTemperature">http://qudt.org/vocab/quantitykind/DewPointTemperature</seealso>
    let DewPointTemperature = Prefixed_Name(qk, "DewPointTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"قطر"</para><para>"diâmetro"</para><para>"диаметр"</para><para>"Durchmesser"</para><para>"直径"</para><para>"diámetro"</para><para>"průměr"</para><para>"średnica"</para><para>"çap"</para><para>"diametro"</para><para>"premer"</para><para>"diameter"</para><para>"diamètre"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Diameter">http://qudt.org/vocab/quantitykind/Diameter</seealso>
    let Diameter = Prefixed_Name(qk, "Diameter") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DiastolicBloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diastolic Blood Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DiastolicBloodPressure">http://qudt.org/vocab/quantitykind/DiastolicBloodPressure</seealso>
    let DiastolicBloodPressure =
        Prefixed_Name(qk, "DiastolicBloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DiffusionArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diffusion Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DiffusionArea">http://qudt.org/vocab/quantitykind/DiffusionArea</seealso>
    let DiffusionArea = Prefixed_Name(qk, "DiffusionArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DiffusionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DiffusionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coeficiente de difusión"</para><para>"coeficiente de difusão"</para><para>"coefficiente di diffusione"</para><para>"difuzijski koeficient"</para><para>"coefficient de diffusion"</para><para>"diffusion coefficient"</para><para>"Diffusionskoeffizient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DiffusionCoefficient">http://qudt.org/vocab/quantitykind/DiffusionCoefficient</seealso>
    let DiffusionCoefficient = Prefixed_Name(qk, "DiffusionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DiffusionCoefficientForFluenceRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diffusion Coefficient for Fluence Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DiffusionCoefficientForFluenceRate">http://qudt.org/vocab/quantitykind/DiffusionCoefficientForFluenceRate</seealso>
    let DiffusionCoefficientForFluenceRate =
        Prefixed_Name(qk, "DiffusionCoefficientForFluenceRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DiffusionLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diffusion Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DiffusionLength">http://qudt.org/vocab/quantitykind/DiffusionLength</seealso>
    let DiffusionLength = Prefixed_Name(qk, "DiffusionLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DigitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DigitRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"digit rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DigitRate">http://qudt.org/vocab/quantitykind/DigitRate</seealso>
    let DigitRate = Prefixed_Name(qk, "DigitRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Dimensionless</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dimensionless"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Dimensionless">http://qudt.org/vocab/quantitykind/Dimensionless</seealso>
    let Dimensionless = Prefixed_Name(qk, "Dimensionless") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DimensionlessRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dimensionless Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DimensionlessRatio">http://qudt.org/vocab/quantitykind/DimensionlessRatio</seealso>
    let DimensionlessRatio = Prefixed_Name(qk, "DimensionlessRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Displacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Displacement"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Displacement">http://qudt.org/vocab/quantitykind/Displacement</seealso>
    let Displacement = Prefixed_Name(qk, "Displacement") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DisplacementCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DisplacementCurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Displacement Current"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DisplacementCurrent">http://qudt.org/vocab/quantitykind/DisplacementCurrent</seealso>
    let DisplacementCurrent = Prefixed_Name(qk, "DisplacementCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DisplacementCurrentDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DisplacementCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Displacement Current Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DisplacementCurrentDensity">http://qudt.org/vocab/quantitykind/DisplacementCurrentDensity</seealso>
    let DisplacementCurrentDensity =
        Prefixed_Name(qk, "DisplacementCurrentDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DisplacementVectorOfIon</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Displacement Vector of Ion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DisplacementVectorOfIon">http://qudt.org/vocab/quantitykind/DisplacementVectorOfIon</seealso>
    let DisplacementVectorOfIon =
        Prefixed_Name(qk, "DisplacementVectorOfIon") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Dissipance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dissipance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dissipance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Dissipance">http://qudt.org/vocab/quantitykind/Dissipance</seealso>
    let Dissipance = Prefixed_Name(qk, "Dissipance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Distance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"distanza"</para><para>"distancia"</para><para>"distance"</para><para>"مسافت"</para><para>"Vzdálenost"</para><para>"Entfernung"</para><para>"uzaklık"</para><para>"distância"</para><para>"距离"</para><para>"Jarak"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Distance">http://qudt.org/vocab/quantitykind/Distance</seealso>
    let Distance = Prefixed_Name(qk, "Distance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DistanceTraveledDuringBurn</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Distance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Distance Traveled During a Burn"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DistanceTraveledDuringBurn">http://qudt.org/vocab/quantitykind/DistanceTraveledDuringBurn</seealso>
    let DistanceTraveledDuringBurn =
        Prefixed_Name(qk, "DistanceTraveledDuringBurn") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DonorDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Donor Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DonorDensity">http://qudt.org/vocab/quantitykind/DonorDensity</seealso>
    let DonorDensity = Prefixed_Name(qk, "DonorDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DonorIonizationEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Donor Ionization Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DonorIonizationEnergy">http://qudt.org/vocab/quantitykind/DonorIonizationEnergy</seealso>
    let DonorIonizationEnergy =
        Prefixed_Name(qk, "DonorIonizationEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DoseEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DoseEquivalent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dose Equivalent"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DoseEquivalent">http://qudt.org/vocab/quantitykind/DoseEquivalent</seealso>
    let DoseEquivalent = Prefixed_Name(qk, "DoseEquivalent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DoseEquivalentQualityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DoseEquivalentQualityFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dose Equivalent Quality Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DoseEquivalentQualityFactor">http://qudt.org/vocab/quantitykind/DoseEquivalentQualityFactor</seealso>
    let DoseEquivalentQualityFactor =
        Prefixed_Name(qk, "DoseEquivalentQualityFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DoseEquivalentRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"dose equivalent rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DoseEquivalentRate">http://qudt.org/vocab/quantitykind/DoseEquivalentRate</seealso>
    let DoseEquivalentRate = Prefixed_Name(qk, "DoseEquivalentRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DotsPerInch</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DotsPerInch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dots per inch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DotsPerInch">http://qudt.org/vocab/quantitykind/DotsPerInch</seealso>
    let DotsPerInch = Prefixed_Name(qk, "DotsPerInch") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DragCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drag Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DragCoefficient">http://qudt.org/vocab/quantitykind/DragCoefficient</seealso>
    let DragCoefficient = Prefixed_Name(qk, "DragCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DragForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drag Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DragForce">http://qudt.org/vocab/quantitykind/DragForce</seealso>
    let DragForce = Prefixed_Name(qk, "DragForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DryBulbTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dry Bulb Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DryBulbTemperature">http://qudt.org/vocab/quantitykind/DryBulbTemperature</seealso>
    let DryBulbTemperature = Prefixed_Name(qk, "DryBulbTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DryVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DryVolume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dry Volume"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DryVolume">http://qudt.org/vocab/quantitykind/DryVolume</seealso>
    let DryVolume = Prefixed_Name(qk, "DryVolume") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DutyCycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DutyCycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Duty Cycle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DutyCycle">http://qudt.org/vocab/quantitykind/DutyCycle</seealso>
    let DutyCycle = Prefixed_Name(qk, "DutyCycle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Duv</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Duv"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Delta u,v"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Duv">http://qudt.org/vocab/quantitykind/Duv</seealso>
    let Duv = Prefixed_Name(qk, "Duv") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DynamicFriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dynamic Friction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DynamicFriction">http://qudt.org/vocab/quantitykind/DynamicFriction</seealso>
    let DynamicFriction = Prefixed_Name(qk, "DynamicFriction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DynamicFrictionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FrictionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dynamic Friction Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DynamicFrictionCoefficient">http://qudt.org/vocab/quantitykind/DynamicFrictionCoefficient</seealso>
    let DynamicFrictionCoefficient =
        Prefixed_Name(qk, "DynamicFrictionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/DynamicPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dynamic Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DynamicPressure">http://qudt.org/vocab/quantitykind/DynamicPressure</seealso>
    let DynamicPressure = Prefixed_Name(qk, "DynamicPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/DynamicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DynamicViscosity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"viskozita"</para><para>"viscosité dynamique"</para><para>"گرانروی دینامیکی/ویسکوزیته دینامیکی"</para><para>"Viscozitate dinamică"</para><para>"لزوجة"</para><para>"viscosidad dinámica"</para><para>"lepkość dynamiczna"</para><para>"viscosità dinamica"</para><para>"粘度"</para><para>"dinamik akmazlık"</para><para>"viscosidade dinâmica"</para><para>"श्यानता"</para><para>"динамическую вязкость"</para><para>"dinamična viskoznost"</para><para>"dynamische Viskosität"</para><para>"Kelikatan dinamik"</para><para>"动力粘度"</para><para>"dynamic viscosity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/DynamicViscosity">http://qudt.org/vocab/quantitykind/DynamicViscosity</seealso>
    let DynamicViscosity = Prefixed_Name(qk, "DynamicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EarthClosestApproachVehicleVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Earth Closest Approach Vehicle Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EarthClosestApproachVehicleVelocity">http://qudt.org/vocab/quantitykind/EarthClosestApproachVehicleVelocity</seealso>
    let EarthClosestApproachVehicleVelocity =
        Prefixed_Name(qk, "EarthClosestApproachVehicleVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EarthquakeMagnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EarthquakeMagnitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"earthquake magnitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EarthquakeMagnitude">http://qudt.org/vocab/quantitykind/EarthquakeMagnitude</seealso>
    let EarthquakeMagnitude = Prefixed_Name(qk, "EarthquakeMagnitude") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EccentricityOfOrbit</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Eccentricity Of Orbit"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EccentricityOfOrbit">http://qudt.org/vocab/quantitykind/EccentricityOfOrbit</seealso>
    let EccentricityOfOrbit = Prefixed_Name(qk, "EccentricityOfOrbit") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EffectiveExhaustVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Effective Exhaustvelocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EffectiveExhaustVelocity">http://qudt.org/vocab/quantitykind/EffectiveExhaustVelocity</seealso>
    let EffectiveExhaustVelocity =
        Prefixed_Name(qk, "EffectiveExhaustVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EffectiveMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Effective Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EffectiveMass">http://qudt.org/vocab/quantitykind/EffectiveMass</seealso>
    let EffectiveMass = Prefixed_Name(qk, "EffectiveMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EffectiveMultiplicationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MultiplicationFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Effective Multiplication Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EffectiveMultiplicationFactor">http://qudt.org/vocab/quantitykind/EffectiveMultiplicationFactor</seealso>
    let EffectiveMultiplicationFactor =
        Prefixed_Name(qk, "EffectiveMultiplicationFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Efficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rendimiento"</para><para>"efficiency"</para><para>"كفاءة"</para><para>"sprawność"</para><para>"Wirkungsgrad"</para><para>"efficienza"</para><para>"eficiência"</para><para>"коэффициент полезного действия"</para><para>"效率"</para><para>"rendement"</para><para>"効率"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Efficiency">http://qudt.org/vocab/quantitykind/Efficiency</seealso>
    let Efficiency = Prefixed_Name(qk, "Efficiency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EinsteinCoefficients</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EinsteinCoefficients"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Einstein coefficients"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EinsteinCoefficients">http://qudt.org/vocab/quantitykind/EinsteinCoefficients</seealso>
    let EinsteinCoefficients = Prefixed_Name(qk, "EinsteinCoefficients") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EinsteinTransitionProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EinsteinTransitionProbability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Einstein Transition Probability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EinsteinTransitionProbability">http://qudt.org/vocab/quantitykind/EinsteinTransitionProbability</seealso>
    let EinsteinTransitionProbability =
        Prefixed_Name(qk, "EinsteinTransitionProbability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Einstein transition probability for spontaneous or induced emission and absorption"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption">http://qudt.org/vocab/quantitykind/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption</seealso>
    let EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption =
        Prefixed_Name(qk, "EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onus electricum"</para><para>"ładunek elektryczny"</para><para>"carica elettrica"</para><para>"电荷"</para><para>"Електрически заряд"</para><para>"الشحنة الكهربائية"</para><para>"sarcină electrică"</para><para>"Электрический заряд"</para><para>"Charge électrique"</para><para>"電荷"</para><para>"electric charge"</para><para>"Elektrický náboj"</para><para>"विद्युत आवेग या विद्युत बहाव"</para><para>"Cas elektrik"</para><para>"بار الکتریکی"</para><para>"carga eléctrica"</para><para>"električni naboj"</para><para>"carga elétrica"</para><para>"מטען חשמלי"</para><para>"elektrische Ladung"</para><para>"elektromos töltés"</para><para>"elektrik yükü"</para><para>"Ηλεκτρικό φορτίο"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCharge">http://qudt.org/vocab/quantitykind/ElectricCharge</seealso>
    let ElectricCharge = Prefixed_Name(qk, "ElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargeDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargeDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Charge Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargeDensity">http://qudt.org/vocab/quantitykind/ElectricChargeDensity</seealso>
    let ElectricChargeDensity =
        Prefixed_Name(qk, "ElectricChargeDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargeLineDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargeLineDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Charge Line Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargeLineDensity">http://qudt.org/vocab/quantitykind/ElectricChargeLineDensity</seealso>
    let ElectricChargeLineDensity =
        Prefixed_Name(qk, "ElectricChargeLineDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargeLinearDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargeLinearDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Charge Linear Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargeLinearDensity">http://qudt.org/vocab/quantitykind/ElectricChargeLinearDensity</seealso>
    let ElectricChargeLinearDensity =
        Prefixed_Name(qk, "ElectricChargeLinearDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargePerAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerAmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric charge per amount of substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargePerAmountOfSubstance">http://qudt.org/vocab/quantitykind/ElectricChargePerAmountOfSubstance</seealso>
    let ElectricChargePerAmountOfSubstance =
        Prefixed_Name(qk, "ElectricChargePerAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargePerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric charge per area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargePerArea">http://qudt.org/vocab/quantitykind/ElectricChargePerArea</seealso>
    let ElectricChargePerArea =
        Prefixed_Name(qk, "ElectricChargePerArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargePerMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Charge Per Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargePerMass">http://qudt.org/vocab/quantitykind/ElectricChargePerMass</seealso>
    let ElectricChargePerMass =
        Prefixed_Name(qk, "ElectricChargePerMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargeSurfaceDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargeSurfaceDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Charge Surface Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargeSurfaceDensity">http://qudt.org/vocab/quantitykind/ElectricChargeSurfaceDensity</seealso>
    let ElectricChargeSurfaceDensity =
        Prefixed_Name(qk, "ElectricChargeSurfaceDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricChargeVolumeDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargeVolumeDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Charge Volume Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricChargeVolumeDensity">http://qudt.org/vocab/quantitykind/ElectricChargeVolumeDensity</seealso>
    let ElectricChargeVolumeDensity =
        Prefixed_Name(qk, "ElectricChargeVolumeDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricConductivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conducibilità elettrica"</para><para>"رسانايى الکتريکى/هدایت الکتریکی"</para><para>"conductivité électrique"</para><para>"conductividad eléctrica"</para><para>"električna prevodnost"</para><para>"elektrik iletkenliği"</para><para>"elektrische Leitfähigkeit"</para><para>"condutividade elétrica"</para><para>"电导率"</para><para>"electric conductivity"</para><para>"Kekonduksian elektrik"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricConductivity">http://qudt.org/vocab/quantitykind/ElectricConductivity</seealso>
    let ElectricConductivity = Prefixed_Name(qk, "ElectricConductivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Сила электрического тока"</para><para>"električni tok"</para><para>"electric current"</para><para>"تيار كهربائي"</para><para>"זרם חשמלי"</para><para>"elektromos áramerősség"</para><para>"جریان الکتریکی"</para><para>"corriente eléctrica"</para><para>"विद्युत धारा"</para><para>"Arus elektrik"</para><para>"電流"</para><para>"prąd elektryczny"</para><para>"intensité de courant électrique"</para><para>"Elektrický proud"</para><para>"Електрически ток"</para><para>"elektrik akımı"</para><para>"elektrische Stromstärke"</para><para>"curent electric"</para><para>"Ένταση ηλεκτρικού ρεύματος"</para><para>"电流"</para><para>"fluxio electrica"</para><para>"corrente elétrica"</para><para>"corrente elettrica"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrent">http://qudt.org/vocab/quantitykind/ElectricCurrent</seealso>
    let ElectricCurrent = Prefixed_Name(qk, "ElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCurrentDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Akım yoğunluğu"</para><para>"Gęstość prądu elektrycznego"</para><para>"كثافة التيار"</para><para>"gostota električnega toka"</para><para>"Ketumpatan arus elektrik"</para><para>"densité de courant"</para><para>"چگالی جریان الکتریکی"</para><para>"電流密度"</para><para>"धारा घनत्व"</para><para>"densità di corrente elettrica"</para><para>"densidade de corrente elétrica"</para><para>"Densitate de curent"</para><para>"电流密度"</para><para>"densidad de corriente"</para><para>"плотность тока"</para><para>"electric current density"</para><para>"Hustota elektrického proudu"</para><para>"elektrische Stromdichte"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrentDensity">http://qudt.org/vocab/quantitykind/ElectricCurrentDensity</seealso>
    let ElectricCurrentDensity =
        Prefixed_Name(qk, "ElectricCurrentDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCurrentPerAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrentPerAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Current per Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerAngle">http://qudt.org/vocab/quantitykind/ElectricCurrentPerAngle</seealso>
    let ElectricCurrentPerAngle =
        Prefixed_Name(qk, "ElectricCurrentPerAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCurrentPerEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrentPerEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Current per Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerEnergy">http://qudt.org/vocab/quantitykind/ElectricCurrentPerEnergy</seealso>
    let ElectricCurrentPerEnergy =
        Prefixed_Name(qk, "ElectricCurrentPerEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCurrentPerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LinearElectricCurrentDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Current per Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerLength">http://qudt.org/vocab/quantitykind/ElectricCurrentPerLength</seealso>
    let ElectricCurrentPerLength =
        Prefixed_Name(qk, "ElectricCurrentPerLength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCurrentPerTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrentPerTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Current per Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerTemperature">http://qudt.org/vocab/quantitykind/ElectricCurrentPerTemperature</seealso>
    let ElectricCurrentPerTemperature =
        Prefixed_Name(qk, "ElectricCurrentPerTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricCurrentPhasor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricCurrentPhasor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Current Phasor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricCurrentPhasor">http://qudt.org/vocab/quantitykind/ElectricCurrentPhasor</seealso>
    let ElectricCurrentPhasor =
        Prefixed_Name(qk, "ElectricCurrentPhasor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricDipoleMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricDipoleMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"電気双極子"</para><para>"momento di dipolo elettrico"</para><para>"电偶极矩"</para><para>"moment dipolaire"</para><para>"Momen dwikutub elektrik"</para><para>"momento do dipolo elétrico"</para><para>"عزم ثنائي قطب"</para><para>"Электрический дипольный момент"</para><para>"momento de dipolo eléctrico"</para><para>"विद्युत द्विध्रुव आघूर्ण"</para><para>"گشتاور دوقطبی الکتریکی"</para><para>"elektrik dipol momenti"</para><para>"Dipólový moment"</para><para>"moment electric dipolar"</para><para>"elektrisches Dipolmoment"</para><para>"electric dipole moment"</para><para>"elektryczny moment dipolowy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment">http://qudt.org/vocab/quantitykind/ElectricDipoleMoment</seealso>
    let ElectricDipoleMoment = Prefixed_Name(qk, "ElectricDipoleMoment") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricDipoleMoment_CubicPerEnergy_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Cubic Electric Dipole Moment per Square Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_CubicPerEnergy_Squared">http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_CubicPerEnergy_Squared</seealso>
    let ElectricDipoleMoment_CubicPerEnergy_Squared =
        Prefixed_Name(qk, "ElectricDipoleMoment_CubicPerEnergy_Squared") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricDipoleMoment_QuarticPerEnergy_Cubic</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Quartic Electric Dipole Moment per Cubic Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_QuarticPerEnergy_Cubic">http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_QuarticPerEnergy_Cubic</seealso>
    let ElectricDipoleMoment_QuarticPerEnergy_Cubic =
        Prefixed_Name(qk, "ElectricDipoleMoment_QuarticPerEnergy_Cubic") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricDisplacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Displacement"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricDisplacement">http://qudt.org/vocab/quantitykind/ElectricDisplacement</seealso>
    let ElectricDisplacement = Prefixed_Name(qk, "ElectricDisplacement") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricDisplacementField</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Displacement Field"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricDisplacementField">http://qudt.org/vocab/quantitykind/ElectricDisplacementField</seealso>
    let ElectricDisplacementField =
        Prefixed_Name(qk, "ElectricDisplacementField") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricField</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricField"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Field"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricField">http://qudt.org/vocab/quantitykind/ElectricField</seealso>
    let ElectricField = Prefixed_Name(qk, "ElectricField") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricFieldStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricFieldStrength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"電界強度"</para><para>"電場"</para><para>"intensité de champ électrique"</para><para>"electric field strength"</para><para>"elektrické pole"</para><para>"شدة المجال الكهربائي"</para><para>"שדה חשמלי"</para><para>"Електрично поле"</para><para>"Ηλεκτρικό πεδίο"</para><para>"elektrische Feldstärke"</para><para>"jakost električnega polja"</para><para>"intensità di campo elettrico"</para><para>"intensidade de campo elétrico"</para><para>"natężenie pola elektrycznego"</para><para>"विद्युत्-क्षेत्र"</para><para>"Elektromos mező"</para><para>"elektriksel alan kuvveti"</para><para>"intensidad de campo eléctrico"</para><para>"Kekuatan medan elektrik"</para><para>"câmp electric"</para><para>"شدت میدان الکتریکی"</para><para>"Напряженность электрического поля"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricFieldStrength">http://qudt.org/vocab/quantitykind/ElectricFieldStrength</seealso>
    let ElectricFieldStrength =
        Prefixed_Name(qk, "ElectricFieldStrength") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricFlux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Flux"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricFlux">http://qudt.org/vocab/quantitykind/ElectricFlux</seealso>
    let ElectricFlux = Prefixed_Name(qk, "ElectricFlux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectricFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electric flux density"</para><para>"電位移"</para><para>"電束密度"</para><para>"elektrische Flussdichte"</para><para>"Электрическая индукция"</para><para>"Densidad de flujo eléctrico"</para><para>"Inducție electrică"</para><para>"Elektrická indukce"</para><para>"چگالی شار الکتریکی"</para><para>"Ketumpatan fluks elektrik"</para><para>"إزاحة كهربائية"</para><para>"campo de deslocamento elétrico"</para><para>"elektrik akı yoğunluğu"</para><para>"Indukcja elektryczna"</para><para>"Induction électrique"</para><para>"spostamento elettrico"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricFluxDensity">http://qudt.org/vocab/quantitykind/ElectricFluxDensity</seealso>
    let ElectricFluxDensity = Prefixed_Name(qk, "ElectricFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricPolarizability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPolarizability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polarisabilité"</para><para>"elektrische Polarisierbarkeit"</para><para>"Kutuplanabilirlik"</para><para>"極化性"</para><para>"قابلية استقطاب"</para><para>"Kepengkutuban elektrik"</para><para>"Polarizovatelnost"</para><para>"Polarizabilidad"</para><para>"Polaryzowalność"</para><para>"Поляризуемость"</para><para>"分極率"</para><para>"polarizzabilità elettrica"</para><para>"polarizabilidade"</para><para>"electric polarizability"</para><para>"قطبیت پذیری الکتریکی"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricPolarizability">http://qudt.org/vocab/quantitykind/ElectricPolarizability</seealso>
    let ElectricPolarizability =
        Prefixed_Name(qk, "ElectricPolarizability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricPolarization</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPolarization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"elektrische Polarisation"</para><para>"электрическая поляризация"</para><para>"polaryzacja elektryczna"</para><para>"polarizzazione elettrica"</para><para>"polarização eléctrica"</para><para>"polarización eléctrica"</para><para>"electric polarization"</para><para>"電気分極"</para><para>"polarisation électrique"</para><para>"إستقطاب كهربائي"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricPolarization">http://qudt.org/vocab/quantitykind/ElectricPolarization</seealso>
    let ElectricPolarization = Prefixed_Name(qk, "ElectricPolarization") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectricPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPotential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tensio electrica"</para><para>"potencial elétrico"</para><para>"električni potencial"</para><para>"potenziale elettrico"</para><para>"электростатический потенциал"</para><para>"potencjał elektryczny"</para><para>"Keupayaan elektrik"</para><para>"potentiel électrique"</para><para>"Електрически потенциал"</para><para>"potencial eléctrico"</para><para>"potențial electric"</para><para>"電位"</para><para>"elektromos feszültség , elektromos potenciálkülönbség"</para><para>"كمون كهربائي"</para><para>"پتانسیل الکتریکی"</para><para>"elektrisches Potenzial"</para><para>"elektrický potenciál"</para><para>"elektrik potansiyeli"</para><para>"電勢"</para><para>"विद्युत विभव"</para><para>"electric potential"</para><para>"מתח חשמלי (הפרש פוטנציאלים)"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricPotential">http://qudt.org/vocab/quantitykind/ElectricPotential</seealso>
    let ElectricPotential = Prefixed_Name(qk, "ElectricPotential") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricPotentialDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPotentialDifference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electric potential difference"</para><para>"Voltan Perbezaan keupayaan elektrik"</para><para>"電圧"</para><para>"электрическое напряжение"</para><para>"gerilim"</para><para>"جهد كهربائي"</para><para>"tensión eléctrica"</para><para>"विभवांतर"</para><para>"ولتاژ/ اختلاف پتانسیل"</para><para>"tensão elétrica (diferença de potencial)"</para><para>"elektrische Spannung"</para><para>"diferență de potențial electric"</para><para>"električna napetost"</para><para>"電壓"</para><para>"elektrické napětí"</para><para>"tension électrique"</para><para>"differenza di potenziale elettrico"</para><para>"napięcie elektryczne"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricPotentialDifference">http://qudt.org/vocab/quantitykind/ElectricPotentialDifference</seealso>
    let ElectricPotentialDifference =
        Prefixed_Name(qk, "ElectricPotentialDifference") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"有効電力"</para><para>"Wirkleistung"</para><para>"moc czynna"</para><para>"potência activa"</para><para>"puissance active"</para><para>"electric power"</para><para>"potenza attiva"</para><para>"potencia activa"</para><para>"有功功率"</para><para>"القدرة الفعالة"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricPower">http://qudt.org/vocab/quantitykind/ElectricPower</seealso>
    let ElectricPower = Prefixed_Name(qk, "ElectricPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricPropulsionPropellantMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electric Propulsion Propellant Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricPropulsionPropellantMass">http://qudt.org/vocab/quantitykind/ElectricPropulsionPropellantMass</seealso>
    let ElectricPropulsionPropellantMass =
        Prefixed_Name(qk, "ElectricPropulsionPropellantMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricQuadrupoleMoment</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricQuadrupoleMoment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"四極子"</para><para>"electric quadrupole moment"</para><para>"moment quadrupolaire électrique"</para><para>"elektrik kuadrupol momenti"</para><para>"elektrisches Quadrupolmoment"</para><para>"momento di quadrupolo elettrico"</para><para>"momento de cuadrupolo eléctrico"</para><para>"Электрический квадрупольный момент"</para><para>"گشتاور چهار قطبی الکتریکی"</para><para>"momento de quadrupolo elétrico"</para><para>"elektryczny moment kwadrupolowy"</para><para>"电四极矩"</para><para>"Momen kuadrupol elektrik"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricQuadrupoleMoment">http://qudt.org/vocab/quantitykind/ElectricQuadrupoleMoment</seealso>
    let ElectricQuadrupoleMoment =
        Prefixed_Name(qk, "ElectricQuadrupoleMoment") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricSusceptibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricSusceptibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"podatność elektryczna"</para><para>"susceptibilidad eléctrica"</para><para>"المتأثرية الكهربائية، سرعة التأثر الكهربائية"</para><para>"elektrische Suszeptibilität"</para><para>"電気感受率"</para><para>"suscettività elettrica"</para><para>"susceptibilidade eléctrica"</para><para>"электрическая восприимчивость"</para><para>"susceptibilité électrique"</para><para>"electric susceptibility"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricSusceptibility">http://qudt.org/vocab/quantitykind/ElectricSusceptibility</seealso>
    let ElectricSusceptibility =
        Prefixed_Name(qk, "ElectricSusceptibility") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricalConductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricalConductance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electrical conductance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"electrical conductance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricalConductance">http://qudt.org/vocab/quantitykind/ElectricalConductance</seealso>
    let ElectricalConductance =
        Prefixed_Name(qk, "ElectricalConductance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricalPowerToMassRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificPower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electrical Power To Mass Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricalPowerToMassRatio">http://qudt.org/vocab/quantitykind/ElectricalPowerToMassRatio</seealso>
    let ElectricalPowerToMassRatio =
        Prefixed_Name(qk, "ElectricalPowerToMassRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectricalResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricalResistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electrical resistance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectricalResistance">http://qudt.org/vocab/quantitykind/ElectricalResistance</seealso>
    let ElectricalResistance = Prefixed_Name(qk, "ElectricalResistance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectrolyticConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectrolyticConductivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electrolytic Conductivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectrolyticConductivity">http://qudt.org/vocab/quantitykind/ElectrolyticConductivity</seealso>
    let ElectrolyticConductivity =
        Prefixed_Name(qk, "ElectrolyticConductivity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectromagneticEnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectromagneticEnergyDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electromagnetic Energy Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectromagneticEnergyDensity">http://qudt.org/vocab/quantitykind/ElectromagneticEnergyDensity</seealso>
    let ElectromagneticEnergyDensity =
        Prefixed_Name(qk, "ElectromagneticEnergyDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectromagneticPermeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectromagneticPermeability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permeability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectromagneticPermeability">http://qudt.org/vocab/quantitykind/ElectromagneticPermeability</seealso>
    let ElectromagneticPermeability =
        Prefixed_Name(qk, "ElectromagneticPermeability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectromagneticPermeabilityRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectromagneticPermeabilityRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electromagnetic Permeability Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectromagneticPermeabilityRatio">http://qudt.org/vocab/quantitykind/ElectromagneticPermeabilityRatio</seealso>
    let ElectromagneticPermeabilityRatio =
        Prefixed_Name(qk, "ElectromagneticPermeabilityRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectromagneticWavePhaseSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectromagneticWavePhaseSpeed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electromagnetic Wave Phase Speed"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectromagneticWavePhaseSpeed">http://qudt.org/vocab/quantitykind/ElectromagneticWavePhaseSpeed</seealso>
    let ElectromagneticWavePhaseSpeed =
        Prefixed_Name(qk, "ElectromagneticWavePhaseSpeed") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElectromotiveForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"força eletromotriz"</para><para>"Daya gerak elektrik"</para><para>"قوة محركة كهربائية"</para><para>"電動勢"</para><para>"نیروی محرک الکتریکی"</para><para>"起電力"</para><para>"siła elektromotoryczna"</para><para>"forță electromotoare"</para><para>"elektromotorische Kraft"</para><para>"electromotive force"</para><para>"force électromotrice"</para><para>"Elektromotor kuvvet"</para><para>"электродвижущая сила"</para><para>"elektromotorna sila"</para><para>"fuerza electromotriz"</para><para>"forza elettromotrice"</para><para>"विद्युतवाहक बल"</para><para>"Elektromotorické napětí"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectromotiveForce">http://qudt.org/vocab/quantitykind/ElectromotiveForce</seealso>
    let ElectromotiveForce = Prefixed_Name(qk, "ElectromotiveForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectronAffinity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electron Affinity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectronAffinity">http://qudt.org/vocab/quantitykind/ElectronAffinity</seealso>
    let ElectronAffinity = Prefixed_Name(qk, "ElectronAffinity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectronDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electron Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectronDensity">http://qudt.org/vocab/quantitykind/ElectronDensity</seealso>
    let ElectronDensity = Prefixed_Name(qk, "ElectronDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectronMeanFreePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electron Mean Free Path"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectronMeanFreePath">http://qudt.org/vocab/quantitykind/ElectronMeanFreePath</seealso>
    let ElectronMeanFreePath = Prefixed_Name(qk, "ElectronMeanFreePath") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectronMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mobility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"electron mobility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectronMobility">http://qudt.org/vocab/quantitykind/ElectronMobility</seealso>
    let ElectronMobility = Prefixed_Name(qk, "ElectronMobility") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ElectronRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electron Radius"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElectronRadius">http://qudt.org/vocab/quantitykind/ElectronRadius</seealso>
    let ElectronRadius = Prefixed_Name(qk, "ElectronRadius") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ElevationRelativeToNAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElevationRelativeToNAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Height measurement relative to the Normaal Amsterdams Peil (NAP) (en: Amsterdam Ordnance System). Being a form of gravity related height"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Elevation relative to NAP"</para><para>"Hoogte ten opzichte van NAP"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ElevationRelativeToNAP">http://qudt.org/vocab/quantitykind/ElevationRelativeToNAP</seealso>
    let ElevationRelativeToNAP =
        Prefixed_Name(qk, "ElevationRelativeToNAP") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EllipticalOrbitApogeeVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Elliptical Orbit Apogee Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EllipticalOrbitApogeeVelocity">http://qudt.org/vocab/quantitykind/EllipticalOrbitApogeeVelocity</seealso>
    let EllipticalOrbitApogeeVelocity =
        Prefixed_Name(qk, "EllipticalOrbitApogeeVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EllipticalOrbitPerigeeVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Elliptical Orbit Perigee Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EllipticalOrbitPerigeeVelocity">http://qudt.org/vocab/quantitykind/EllipticalOrbitPerigeeVelocity</seealso>
    let EllipticalOrbitPerigeeVelocity =
        Prefixed_Name(qk, "EllipticalOrbitPerigeeVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Emissivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Emissivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emissivity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Emissivity">http://qudt.org/vocab/quantitykind/Emissivity</seealso>
    let Emissivity = Prefixed_Name(qk, "Emissivity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tenaga"</para><para>"エネルギー"</para><para>"energia , munka , hő"</para><para>"انرژی"</para><para>"enerji"</para><para>"Энергия"</para><para>"energie"</para><para>"Έργο - Ενέργεια"</para><para>"Energie"</para><para>"energia"</para><para>"الطاقة"</para><para>"énergie"</para><para>"能量"</para><para>"energija"</para><para>"Енергия"</para><para>"אנרגיה ועבודה"</para><para>"ऊर्जा"</para><para>"energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Energy">http://qudt.org/vocab/quantitykind/Energy</seealso>
    let Energy = Prefixed_Name(qk, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"energy content"</para><para>"energy content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyContent">http://qudt.org/vocab/quantitykind/EnergyContent</seealso>
    let EnergyContent = Prefixed_Name(qk, "EnergyContent") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyDensity">http://qudt.org/vocab/quantitykind/EnergyDensity</seealso>
    let EnergyDensity = Prefixed_Name(qk, "EnergyDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyDensityOfStates</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyDensityOfStates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Density of States"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyDensityOfStates">http://qudt.org/vocab/quantitykind/EnergyDensityOfStates</seealso>
    let EnergyDensityOfStates =
        Prefixed_Name(qk, "EnergyDensityOfStates") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyExpenditure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Energy Expenditure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyExpenditure">http://qudt.org/vocab/quantitykind/EnergyExpenditure</seealso>
    let EnergyExpenditure = Prefixed_Name(qk, "EnergyExpenditure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyFluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyFluence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Fluence"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyFluence">http://qudt.org/vocab/quantitykind/EnergyFluence</seealso>
    let EnergyFluence = Prefixed_Name(qk, "EnergyFluence") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyFluenceRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Fluence Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyFluenceRate">http://qudt.org/vocab/quantitykind/EnergyFluenceRate</seealso>
    let EnergyFluenceRate = Prefixed_Name(qk, "EnergyFluenceRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyImparted</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Imparted"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyImparted">http://qudt.org/vocab/quantitykind/EnergyImparted</seealso>
    let EnergyImparted = Prefixed_Name(qk, "EnergyImparted") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyInternal</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"आन्तरिक ऊर्जा"</para><para>"vnitřní energie"</para><para>"İç enerji"</para><para>"内部エネルギー"</para><para>"energía interna"</para><para>"внутренняя энергия"</para><para>"内能"</para><para>"energia wewnętrzna"</para><para>"انرژی درونی"</para><para>"energia interna"</para><para>"innere Energie"</para><para>"Tenaga dalaman"</para><para>"energie internă"</para><para>"internal energy"</para><para>"طاقة داخلية"</para><para>"Notranja energija"</para><para>"énergie interne"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyInternal">http://qudt.org/vocab/quantitykind/EnergyInternal</seealso>
    let EnergyInternal = Prefixed_Name(qk, "EnergyInternal") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyKinetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"动能"</para><para>"energia kinetyczna"</para><para>"énergie cinétique"</para><para>"طاقة حركية"</para><para>"energia cinética"</para><para>"energía cinética"</para><para>"गतिज ऊर्जा"</para><para>"kinetická energie"</para><para>"Kinetik enerji"</para><para>"انرژی جنبشی"</para><para>"energia cinetica"</para><para>"kinetic energy"</para><para>"運動エネルギー"</para><para>"Tenaga kinetik"</para><para>"кинетическая энергия"</para><para>"Energie cinetică"</para><para>"kinetische Energie"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyKinetic">http://qudt.org/vocab/quantitykind/EnergyKinetic</seealso>
    let EnergyKinetic = Prefixed_Name(qk, "EnergyKinetic") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Level"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyLevel">http://qudt.org/vocab/quantitykind/EnergyLevel</seealso>
    let EnergyLevel = Prefixed_Name(qk, "EnergyLevel") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EnergyPerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy per Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerArea">http://qudt.org/vocab/quantitykind/EnergyPerArea</seealso>
    let EnergyPerArea = Prefixed_Name(qk, "EnergyPerArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyPerAreaElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerAreaElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Per Area Electric Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerAreaElectricCharge">http://qudt.org/vocab/quantitykind/EnergyPerAreaElectricCharge</seealso>
    let EnergyPerAreaElectricCharge =
        Prefixed_Name(qk, "EnergyPerAreaElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyPerElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy per electric charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerElectricCharge">http://qudt.org/vocab/quantitykind/EnergyPerElectricCharge</seealso>
    let EnergyPerElectricCharge =
        Prefixed_Name(qk, "EnergyPerElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyPerMagneticFluxDensity_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Energy Per Square Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerMagneticFluxDensity_Squared">http://qudt.org/vocab/quantitykind/EnergyPerMagneticFluxDensity_Squared</seealso>
    let EnergyPerMagneticFluxDensity_Squared =
        Prefixed_Name(qk, "EnergyPerMagneticFluxDensity_Squared") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyPerMassAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerMassAmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy and work per mass amount of substance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerMassAmountOfSubstance">http://qudt.org/vocab/quantitykind/EnergyPerMassAmountOfSubstance</seealso>
    let EnergyPerMassAmountOfSubstance =
        Prefixed_Name(qk, "EnergyPerMassAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyPerSquareMagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerSquareMagneticFluxDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Per Square Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerSquareMagneticFluxDensity">http://qudt.org/vocab/quantitykind/EnergyPerSquareMagneticFluxDensity</seealso>
    let EnergyPerSquareMagneticFluxDensity =
        Prefixed_Name(qk, "EnergyPerSquareMagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EnergyPerTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EnergyPerTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy per temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EnergyPerTemperature">http://qudt.org/vocab/quantitykind/EnergyPerTemperature</seealso>
    let EnergyPerTemperature = Prefixed_Name(qk, "EnergyPerTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Energy_Squared</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Square Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Energy_Squared">http://qudt.org/vocab/quantitykind/Energy_Squared</seealso>
    let Energy_Squared = Prefixed_Name(qk, "Energy_Squared") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Enthalpy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entalpi"</para><para>"Entalpie"</para><para>"entalpía"</para><para>"آنتالپی"</para><para>"entalpia"</para><para>"entalpija"</para><para>"エンタルピー"</para><para>"entalpie"</para><para>"पूर्ण ऊष्मा"</para><para>"焓"</para><para>"энтальпия"</para><para>"Enthalpie"</para><para>"enthalpie"</para><para>"محتوى حراري"</para><para>"enthalpy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Enthalpy">http://qudt.org/vocab/quantitykind/Enthalpy</seealso>
    let Enthalpy = Prefixed_Name(qk, "Enthalpy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Entropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Entropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"एन्ट्रॉपी"</para><para>"entropia"</para><para>"entropi"</para><para>"熵"</para><para>"Entropi"</para><para>"Энтропия"</para><para>"entropie"</para><para>"Entropie"</para><para>"آنتروپی"</para><para>"entropija"</para><para>"entropy"</para><para>"エントロピー"</para><para>"إنتروبيا"</para><para>"entropía"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Entropy">http://qudt.org/vocab/quantitykind/Entropy</seealso>
    let Entropy = Prefixed_Name(qk, "Entropy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/EquilibriumConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EquilibriumConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equilibrium Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquilibriumConstant">http://qudt.org/vocab/quantitykind/EquilibriumConstant</seealso>
    let EquilibriumConstant = Prefixed_Name(qk, "EquilibriumConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquilibriumConstantBasedOnConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"equilibrium constant based on concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnConcentration">http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnConcentration</seealso>
    let EquilibriumConstantBasedOnConcentration =
        Prefixed_Name(qk, "EquilibriumConstantBasedOnConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquilibriumConstantBasedOnPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"equilibrium constant based on pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnPressure">http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnPressure</seealso>
    let EquilibriumConstantBasedOnPressure =
        Prefixed_Name(qk, "EquilibriumConstantBasedOnPressure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquilibriumConstantOnConcentrationBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"The unit is unit:MOL-PER-M3 raised to the N where N is the summation of stoichiometric numbers. I don't know what to do with this."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Applicable units are those of quantitykind:EquilibriumConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equilibrium Constant on Concentration Basis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquilibriumConstantOnConcentrationBasis">http://qudt.org/vocab/quantitykind/EquilibriumConstantOnConcentrationBasis</seealso>
    let EquilibriumConstantOnConcentrationBasis =
        Prefixed_Name(qk, "EquilibriumConstantOnConcentrationBasis") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquilibriumConstantOnPressureBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EquilibriumConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equilibrium Constant on Pressure Basis"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquilibriumConstantOnPressureBasis">http://qudt.org/vocab/quantitykind/EquilibriumConstantOnPressureBasis</seealso>
    let EquilibriumConstantOnPressureBasis =
        Prefixed_Name(qk, "EquilibriumConstantOnPressureBasis") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquilibriumPositionVectorOfIon</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equilibrium Position Vector of Ion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquilibriumPositionVectorOfIon">http://qudt.org/vocab/quantitykind/EquilibriumPositionVectorOfIon</seealso>
    let EquilibriumPositionVectorOfIon =
        Prefixed_Name(qk, "EquilibriumPositionVectorOfIon") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquivalenceDoseOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"equivalence dose output"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquivalenceDoseOutput">http://qudt.org/vocab/quantitykind/EquivalenceDoseOutput</seealso>
    let EquivalenceDoseOutput =
        Prefixed_Name(qk, "EquivalenceDoseOutput") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquivalentAbsorptionArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equivalent absorption area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquivalentAbsorptionArea">http://qudt.org/vocab/quantitykind/EquivalentAbsorptionArea</seealso>
    let EquivalentAbsorptionArea =
        Prefixed_Name(qk, "EquivalentAbsorptionArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquivalentConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equivalent Concentration"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquivalentConcentration">http://qudt.org/vocab/quantitykind/EquivalentConcentration</seealso>
    let EquivalentConcentration =
        Prefixed_Name(qk, "EquivalentConcentration") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EquivalentDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Density"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equivalent Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EquivalentDensity">http://qudt.org/vocab/quantitykind/EquivalentDensity</seealso>
    let EquivalentDensity = Prefixed_Name(qk, "EquivalentDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Equivalent_Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass Equivalent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Equivalent_Mass">http://qudt.org/vocab/quantitykind/Equivalent_Mass</seealso>
    let Equivalent_Mass = Prefixed_Name(qk, "Equivalent_Mass") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Equivalent_Molar</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AmountOfSubstance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molar Equivalent"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Equivalent_Molar">http://qudt.org/vocab/quantitykind/Equivalent_Molar</seealso>
    let Equivalent_Molar = Prefixed_Name(qk, "Equivalent_Molar") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EvaporativeHeatTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Evaporative Heat Transfer"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EvaporativeHeatTransfer">http://qudt.org/vocab/quantitykind/EvaporativeHeatTransfer</seealso>
    let EvaporativeHeatTransfer =
        Prefixed_Name(qk, "EvaporativeHeatTransfer") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/EvaporativeHeatTransferCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:EvaporativeHeatTransferCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Combined Non Evaporative Heat Transfer Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/EvaporativeHeatTransferCoefficient">http://qudt.org/vocab/quantitykind/EvaporativeHeatTransferCoefficient</seealso>
    let EvaporativeHeatTransferCoefficient =
        Prefixed_Name(qk, "EvaporativeHeatTransferCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExchangeIntegral</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ExchangeIntegral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exchange Integral"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExchangeIntegral">http://qudt.org/vocab/quantitykind/ExchangeIntegral</seealso>
    let ExchangeIntegral = Prefixed_Name(qk, "ExchangeIntegral") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExhaustGasMeanMolecularWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Exhaust Gas Mean Molecular Weight"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExhaustGasMeanMolecularWeight">http://qudt.org/vocab/quantitykind/ExhaustGasMeanMolecularWeight</seealso>
    let ExhaustGasMeanMolecularWeight =
        Prefixed_Name(qk, "ExhaustGasMeanMolecularWeight") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExhaustGasesSpecificHeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificHeatCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exhaust Gases Specific Heat"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExhaustGasesSpecificHeat">http://qudt.org/vocab/quantitykind/ExhaustGasesSpecificHeat</seealso>
    let ExhaustGasesSpecificHeat =
        Prefixed_Name(qk, "ExhaustGasesSpecificHeat") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExhaustStreamPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exhaust Stream Power"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExhaustStreamPower">http://qudt.org/vocab/quantitykind/ExhaustStreamPower</seealso>
    let ExhaustStreamPower = Prefixed_Name(qk, "ExhaustStreamPower") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExitPlaneCrossSectionalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exit Plane Cross-sectional Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExitPlaneCrossSectionalArea">http://qudt.org/vocab/quantitykind/ExitPlaneCrossSectionalArea</seealso>
    let ExitPlaneCrossSectionalArea =
        Prefixed_Name(qk, "ExitPlaneCrossSectionalArea") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExitPlanePressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exit Plane Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExitPlanePressure">http://qudt.org/vocab/quantitykind/ExitPlanePressure</seealso>
    let ExitPlanePressure = Prefixed_Name(qk, "ExitPlanePressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ExitPlaneTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exit Plane Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExitPlaneTemperature">http://qudt.org/vocab/quantitykind/ExitPlaneTemperature</seealso>
    let ExitPlaneTemperature = Prefixed_Name(qk, "ExitPlaneTemperature") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ExpansionRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ExpansionRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expansion Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExpansionRatio">http://qudt.org/vocab/quantitykind/ExpansionRatio</seealso>
    let ExpansionRatio = Prefixed_Name(qk, "ExpansionRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Exposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ElectricChargePerMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exposure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Exposure">http://qudt.org/vocab/quantitykind/Exposure</seealso>
    let Exposure = Prefixed_Name(qk, "Exposure") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExposureOfIonizingRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"exposure of ionizing radiation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExposureOfIonizingRadiation">http://qudt.org/vocab/quantitykind/ExposureOfIonizingRadiation</seealso>
    let ExposureOfIonizingRadiation =
        Prefixed_Name(qk, "ExposureOfIonizingRadiation") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExposureRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ExposureRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exposure Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExposureRate">http://qudt.org/vocab/quantitykind/ExposureRate</seealso>
    let ExposureRate = Prefixed_Name(qk, "ExposureRate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExposureRateOfIonizingRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"exposure rate of ionizing radiation"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExposureRateOfIonizingRadiation">http://qudt.org/vocab/quantitykind/ExposureRateOfIonizingRadiation</seealso>
    let ExposureRateOfIonizingRadiation =
        Prefixed_Name(qk, "ExposureRateOfIonizingRadiation") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ExtentOfReaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ExtentOfReaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Extent of Reaction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ExtentOfReaction">http://qudt.org/vocab/quantitykind/ExtentOfReaction</seealso>
    let ExtentOfReaction = Prefixed_Name(qk, "ExtentOfReaction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flight Performance Reserve Propellant Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS">http://qudt.org/vocab/quantitykind/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS</seealso>
    let FLIGHT_PERFORMANCE_RESERVE_PROPELLANT_MASS =
        Prefixed_Name(qk, "FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FUEL-BIAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fuel Bias"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FUEL-BIAS">http://qudt.org/vocab/quantitykind/FUEL-BIAS</seealso>
    let FUEL_BIAS = Prefixed_Name(qk, "FUEL-BIAS") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FahrenheitTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fahrenheit temperature"</para><para>"Fahrenheit temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FahrenheitTemperature">http://qudt.org/vocab/quantitykind/FahrenheitTemperature</seealso>
    let FahrenheitTemperature =
        Prefixed_Name(qk, "FahrenheitTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FailureRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Incidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"failure rate"</para><para>"failure rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FailureRate">http://qudt.org/vocab/quantitykind/FailureRate</seealso>
    let FailureRate = Prefixed_Name(qk, "FailureRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/FastFissionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FastFissionFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fast Fission Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FastFissionFactor">http://qudt.org/vocab/quantitykind/FastFissionFactor</seealso>
    let FastFissionFactor = Prefixed_Name(qk, "FastFissionFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FermiAngularWavenumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FermiAngularWavenumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fermi Angular Wavenumber"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FermiAngularWavenumber">http://qudt.org/vocab/quantitykind/FermiAngularWavenumber</seealso>
    let FermiAngularWavenumber =
        Prefixed_Name(qk, "FermiAngularWavenumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FermiEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fermi Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FermiEnergy">http://qudt.org/vocab/quantitykind/FermiEnergy</seealso>
    let FermiEnergy = Prefixed_Name(qk, "FermiEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/FermiTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fermi Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FermiTemperature">http://qudt.org/vocab/quantitykind/FermiTemperature</seealso>
    let FermiTemperature = Prefixed_Name(qk, "FermiTemperature") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FinalOrCurrentVehicleMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Final Or Current Vehicle Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FinalOrCurrentVehicleMass">http://qudt.org/vocab/quantitykind/FinalOrCurrentVehicleMass</seealso>
    let FinalOrCurrentVehicleMass =
        Prefixed_Name(qk, "FinalOrCurrentVehicleMass") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FirstMomentOfArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"First Moment of Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FirstMomentOfArea">http://qudt.org/vocab/quantitykind/FirstMomentOfArea</seealso>
    let FirstMomentOfArea = Prefixed_Name(qk, "FirstMomentOfArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/FirstStageMassRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MassRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"First Stage Mass Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FirstStageMassRatio">http://qudt.org/vocab/quantitykind/FirstStageMassRatio</seealso>
    let FirstStageMassRatio = Prefixed_Name(qk, "FirstStageMassRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FishBiotransformationHalfLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FishBiotransformationHalfLife"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fish Biotransformation Half Life"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FishBiotransformationHalfLife">http://qudt.org/vocab/quantitykind/FishBiotransformationHalfLife</seealso>
    let FishBiotransformationHalfLife =
        Prefixed_Name(qk, "FishBiotransformationHalfLife") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FissionCoreRadiusToHeightRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fission Core Radius To Height Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FissionCoreRadiusToHeightRatio">http://qudt.org/vocab/quantitykind/FissionCoreRadiusToHeightRatio</seealso>
    let FissionCoreRadiusToHeightRatio =
        Prefixed_Name(qk, "FissionCoreRadiusToHeightRatio") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FissionFuelUtilizationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fission Fuel Utilization Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FissionFuelUtilizationFactor">http://qudt.org/vocab/quantitykind/FissionFuelUtilizationFactor</seealso>
    let FissionFuelUtilizationFactor =
        Prefixed_Name(qk, "FissionFuelUtilizationFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FissionMultiplicationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Dimensionless"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fission Multiplication Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FissionMultiplicationFactor">http://qudt.org/vocab/quantitykind/FissionMultiplicationFactor</seealso>
    let FissionMultiplicationFactor =
        Prefixed_Name(qk, "FissionMultiplicationFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FlashPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FlashPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flash Point Temperature"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FlashPoint">http://qudt.org/vocab/quantitykind/FlashPoint</seealso>
    let FlashPoint = Prefixed_Name(qk, "FlashPoint") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/FlightPathAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flight Path Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FlightPathAngle">http://qudt.org/vocab/quantitykind/FlightPathAngle</seealso>
    let FlightPathAngle = Prefixed_Name(qk, "FlightPathAngle") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FloatingPointCalculationCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FloatingPointCalculationCapability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"floating point calculation capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FloatingPointCalculationCapability">http://qudt.org/vocab/quantitykind/FloatingPointCalculationCapability</seealso>
    let FloatingPointCalculationCapability =
        Prefixed_Name(qk, "FloatingPointCalculationCapability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Fluidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Fluidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fluidity"</para><para>"fluidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Fluidity">http://qudt.org/vocab/quantitykind/Fluidity</seealso>
    let Fluidity = Prefixed_Name(qk, "Fluidity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Flux</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Flux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flux"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Flux">http://qudt.org/vocab/quantitykind/Flux</seealso>
    let Flux = Prefixed_Name(qk, "Flux") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Force</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Δύναμη"</para><para>"Сила"</para><para>"Kraft"</para><para>"erő"</para><para>"forță"</para><para>"force"</para><para>"力"</para><para>"وحدة القوة في نظام متر كيلوغرام ثانية"</para><para>"força"</para><para>"כוח"</para><para>"fuerza"</para><para>"نیرو"</para><para>"сила"</para><para>"siła"</para><para>"sila"</para><para>"forza"</para><para>"vis"</para><para>"Síla"</para><para>"Daya"</para><para>"kuvvet"</para><para>"बल"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Force">http://qudt.org/vocab/quantitykind/Force</seealso>
    let Force = Prefixed_Name(qk, "Force") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ForceConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"force constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForceConstant">http://qudt.org/vocab/quantitykind/ForceConstant</seealso>
    let ForceConstant = Prefixed_Name(qk, "ForceConstant") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ForceMagnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Force Magnitude"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForceMagnitude">http://qudt.org/vocab/quantitykind/ForceMagnitude</seealso>
    let ForceMagnitude = Prefixed_Name(qk, "ForceMagnitude") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ForcePerAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerAngle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Force per Angle"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForcePerAngle">http://qudt.org/vocab/quantitykind/ForcePerAngle</seealso>
    let ForcePerAngle = Prefixed_Name(qk, "ForcePerAngle") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ForcePerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Force Per Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForcePerArea">http://qudt.org/vocab/quantitykind/ForcePerArea</seealso>
    let ForcePerArea = Prefixed_Name(qk, "ForcePerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/ForcePerAreaTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerAreaTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Force Per Area Time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForcePerAreaTime">http://qudt.org/vocab/quantitykind/ForcePerAreaTime</seealso>
    let ForcePerAreaTime = Prefixed_Name(qk, "ForcePerAreaTime") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ForcePerElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerElectricCharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Force per Electric Charge"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForcePerElectricCharge">http://qudt.org/vocab/quantitykind/ForcePerElectricCharge</seealso>
    let ForcePerElectricCharge =
        Prefixed_Name(qk, "ForcePerElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/ForcePerLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerLength"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Force per Length"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/ForcePerLength">http://qudt.org/vocab/quantitykind/ForcePerLength</seealso>
    let ForcePerLength = Prefixed_Name(qk, "ForcePerLength") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Συχνότητα"</para><para>"频率"</para><para>"frekvencia"</para><para>"Частота"</para><para>"Frekvence"</para><para>"आवृत्ति"</para><para>"fréquence"</para><para>"frekvenca"</para><para>"częstotliwość"</para><para>"תדירות"</para><para>"frecuencia"</para><para>"Frekuensi"</para><para>"frequentia"</para><para>"frequenza"</para><para>"周波数"</para><para>"التردد لدى نظام الوحدات الدولي"</para><para>"frequency"</para><para>"Честота"</para><para>"frecvență"</para><para>"frekans"</para><para>"Frequenz"</para><para>"frequência"</para><para>"بسامد"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Frequency">http://qudt.org/vocab/quantitykind/Frequency</seealso>
    let Frequency = Prefixed_Name(qk, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Friction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Friction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Friction">http://qudt.org/vocab/quantitykind/Friction</seealso>
    let Friction = Prefixed_Name(qk, "Friction") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/FrictionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:FrictionCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Friction Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FrictionCoefficient">http://qudt.org/vocab/quantitykind/FrictionCoefficient</seealso>
    let FrictionCoefficient = Prefixed_Name(qk, "FrictionCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Fugacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Fugacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fugacidad"</para><para>"fugacitate"</para><para>"フガシティー"</para><para>"Lotność"</para><para>"fugacité"</para><para>"逸度"</para><para>"fugacity"</para><para>"Fugazität"</para><para>"fugacidade"</para><para>"fugacita"</para><para>"بی‌دوامی"</para><para>"انفلاتية"</para><para>"fügasite"</para><para>"fugacità"</para><para>"Fugasiti"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Fugacity">http://qudt.org/vocab/quantitykind/Fugacity</seealso>
    let Fugacity = Prefixed_Name(qk, "Fugacity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FundamentalLatticeVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fundamental Lattice vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FundamentalLatticeVector">http://qudt.org/vocab/quantitykind/FundamentalLatticeVector</seealso>
    let FundamentalLatticeVector =
        Prefixed_Name(qk, "FundamentalLatticeVector") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/FundamentalReciprocalLatticeVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:AngularReciprocalLatticeVector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fundamental Reciprocal Lattice Vector"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/FundamentalReciprocalLatticeVector">http://qudt.org/vocab/quantitykind/FundamentalReciprocalLatticeVector</seealso>
    let FundamentalReciprocalLatticeVector =
        Prefixed_Name(qk, "FundamentalReciprocalLatticeVector") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GFactorOfNucleus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GFactorOfNucleus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"g-Factor of Nucleus"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GFactorOfNucleus">http://qudt.org/vocab/quantitykind/GFactorOfNucleus</seealso>
    let GFactorOfNucleus = Prefixed_Name(qk, "GFactorOfNucleus") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GROSS-LIFT-OFF-WEIGHT</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gross Lift-Off Weight"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GROSS-LIFT-OFF-WEIGHT">http://qudt.org/vocab/quantitykind/GROSS-LIFT-OFF-WEIGHT</seealso>
    let GROSS_LIFT_OFF_WEIGHT =
        Prefixed_Name(qk, "GROSS-LIFT-OFF-WEIGHT") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Gain</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gain"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Gain">http://qudt.org/vocab/quantitykind/Gain</seealso>
    let Gain = Prefixed_Name(qk, "Gain") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GapEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gap Energy"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GapEnergy">http://qudt.org/vocab/quantitykind/GapEnergy</seealso>
    let GapEnergy = Prefixed_Name(qk, "GapEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GasLeakRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"gas leak rate"</para><para>"gas leak rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GasLeakRate">http://qudt.org/vocab/quantitykind/GasLeakRate</seealso>
    let GasLeakRate = Prefixed_Name(qk, "GasLeakRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GaugePressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gauge Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GaugePressure">http://qudt.org/vocab/quantitykind/GaugePressure</seealso>
    let GaugePressure = Prefixed_Name(qk, "GaugePressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GeneFamilyAbundance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GeneFamilyAbundance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gene Family Abundance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GeneFamilyAbundance">http://qudt.org/vocab/quantitykind/GeneFamilyAbundance</seealso>
    let GeneFamilyAbundance = Prefixed_Name(qk, "GeneFamilyAbundance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GeneralizedCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GeneralizedCoordinate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Generalized Coordinate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GeneralizedCoordinate">http://qudt.org/vocab/quantitykind/GeneralizedCoordinate</seealso>
    let GeneralizedCoordinate =
        Prefixed_Name(qk, "GeneralizedCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GeneralizedForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GeneralizedForce"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Generalized Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GeneralizedForce">http://qudt.org/vocab/quantitykind/GeneralizedForce</seealso>
    let GeneralizedForce = Prefixed_Name(qk, "GeneralizedForce") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GeneralizedMomentum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GeneralizedMomentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Generalized Force"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GeneralizedMomentum">http://qudt.org/vocab/quantitykind/GeneralizedMomentum</seealso>
    let GeneralizedMomentum = Prefixed_Name(qk, "GeneralizedMomentum") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GeneralizedVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GeneralizedVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Generalized Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GeneralizedVelocity">http://qudt.org/vocab/quantitykind/GeneralizedVelocity</seealso>
    let GeneralizedVelocity = Prefixed_Name(qk, "GeneralizedVelocity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GibbsEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prosta entalpija"</para><para>"Gibbs energy"</para><para>"Energía de Gibbs"</para><para>"freie Enthalpie"</para><para>"energia libera di Gibbs"</para><para>"طاقة غيبس الحرة"</para><para>"энергия Гиббса"</para><para>"吉布斯自由能"</para><para>"entalpia swobodna"</para><para>"energia livre de Gibbs"</para><para>"Tenaga Gibbs"</para><para>"انرژی آزاد گیبس"</para><para>"enthalpie libre"</para><para>"Gibbsova volná energie"</para><para>"Entalpie liberă"</para><para>"ギブズエネルギー"</para><para>"Gibbs Serbest Enerjisi"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GibbsEnergy">http://qudt.org/vocab/quantitykind/GibbsEnergy</seealso>
    let GibbsEnergy = Prefixed_Name(qk, "GibbsEnergy") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Gradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Gradient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gradient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Gradient">http://qudt.org/vocab/quantitykind/Gradient</seealso>
    let Gradient = Prefixed_Name(qk, "Gradient") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GrandCanonicalPartitionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:CanonicalPartitionFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Grand Canonical Partition Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GrandCanonicalPartitionFunction">http://qudt.org/vocab/quantitykind/GrandCanonicalPartitionFunction</seealso>
    let GrandCanonicalPartitionFunction =
        Prefixed_Name(qk, "GrandCanonicalPartitionFunction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GravitationalAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gravitational Attraction"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GravitationalAttraction">http://qudt.org/vocab/quantitykind/GravitationalAttraction</seealso>
    let GravitationalAttraction =
        Prefixed_Name(qk, "GravitationalAttraction") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/Gravity_API</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"API Gravity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Gravity_API">http://qudt.org/vocab/quantitykind/Gravity_API</seealso>
    let Gravity_API = Prefixed_Name(qk, "Gravity_API") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GroupSpeedOfSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GroupSpeedOfSound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group Speed of Sound"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GroupSpeedOfSound">http://qudt.org/vocab/quantitykind/GroupSpeedOfSound</seealso>
    let GroupSpeedOfSound = Prefixed_Name(qk, "GroupSpeedOfSound") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GrowingDegreeDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GrowingDegreeDay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Growing Degree Days (Cereals)"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GrowingDegreeDay">http://qudt.org/vocab/quantitykind/GrowingDegreeDay</seealso>
    let GrowingDegreeDay = Prefixed_Name(qk, "GrowingDegreeDay") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GrowingDegreeDay_Cereal</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:TimeTemperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Growing Degree Days (Cereals)"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GrowingDegreeDay_Cereal">http://qudt.org/vocab/quantitykind/GrowingDegreeDay_Cereal</seealso>
    let GrowingDegreeDay_Cereal =
        Prefixed_Name(qk, "GrowingDegreeDay_Cereal") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/GruneisenParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:GruneisenParameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gruneisen Parameter"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GruneisenParameter">http://qudt.org/vocab/quantitykind/GruneisenParameter</seealso>
    let GruneisenParameter = Prefixed_Name(qk, "GruneisenParameter") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GustatoryThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Gustatory Threshold"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GustatoryThreshold">http://qudt.org/vocab/quantitykind/GustatoryThreshold</seealso>
    let GustatoryThreshold = Prefixed_Name(qk, "GustatoryThreshold") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/GyromagneticRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Gyromagnetic Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/GyromagneticRatio">http://qudt.org/vocab/quantitykind/GyromagneticRatio</seealso>
    let GyromagneticRatio = Prefixed_Name(qk, "GyromagneticRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Half-Life</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"half-life"</para><para>"半衰期"</para><para>"tempo di dimezzamento"</para><para>"temps de demi-vie"</para><para>"نیمه عمر"</para><para>"yarılanma süresi"</para><para>"semiperiodo"</para><para>"Separuh hayat"</para><para>"meia-vida"</para><para>"Poločas rozpadu"</para><para>"Halbwertszeit"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Half-Life">http://qudt.org/vocab/quantitykind/Half-Life</seealso>
    let Half_Life = Prefixed_Name(qk, "Half-Life") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Half-ValueThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Half-Value Thickness"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Half-ValueThickness">http://qudt.org/vocab/quantitykind/Half-ValueThickness</seealso>
    let Half_ValueThickness = Prefixed_Name(qk, "Half-ValueThickness") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HallCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HallCoefficient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hall Coefficient"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HallCoefficient">http://qudt.org/vocab/quantitykind/HallCoefficient</seealso>
    let HallCoefficient = Prefixed_Name(qk, "HallCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HamiltonFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HamiltonFunction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hamilton Function"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HamiltonFunction">http://qudt.org/vocab/quantitykind/HamiltonFunction</seealso>
    let HamiltonFunction = Prefixed_Name(qk, "HamiltonFunction") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeadEndPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ForcePerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Head End Pressure"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeadEndPressure">http://qudt.org/vocab/quantitykind/HeadEndPressure</seealso>
    let HeadEndPressure = Prefixed_Name(qk, "HeadEndPressure") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeartRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HeartRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heart Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeartRate">http://qudt.org/vocab/quantitykind/HeartRate</seealso>
    let HeartRate = Prefixed_Name(qk, "HeartRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Heat</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:ThermalEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wärme"</para><para>"ऊष्मा"</para><para>"ciepło"</para><para>"calore"</para><para>"熱量"</para><para>"quantité de chaleur"</para><para>"حرارة"</para><para>"cantitate de căldură"</para><para>"کمیت گرما"</para><para>"jednotka tepla"</para><para>"heat"</para><para>"Теплота"</para><para>"calor"</para><para>"toplota"</para><para>"quantidade de calor"</para><para>"labor"</para><para>"kuantiti haba Haba"</para><para>"热量"</para><para>"ısı miktarı"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Heat">http://qudt.org/vocab/quantitykind/Heat</seealso>
    let Heat = Prefixed_Name(qk, "Heat") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HeatCapacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"capacità termica"</para><para>"سعة حرارية"</para><para>"heat capacity"</para><para>"tepelná kapacita"</para><para>"muatan haba"</para><para>"Wärmekapazität"</para><para>"capacidade térmica"</para><para>"isı kapasitesi"</para><para>"capacitate termică"</para><para>"теплоёмкость"</para><para>"ظرفیت گرمایی"</para><para>"toplotna kapaciteta"</para><para>"热容"</para><para>"熱容量"</para><para>"ऊष्मा धारिता"</para><para>"capacidad calorífica"</para><para>"capacité thermique"</para><para>"pojemność cieplna"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeatCapacity">http://qudt.org/vocab/quantitykind/HeatCapacity</seealso>
    let HeatCapacity = Prefixed_Name(qk, "HeatCapacity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeatCapacityRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:DimensionlessRatio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heat Capacity Ratio"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeatCapacityRatio">http://qudt.org/vocab/quantitykind/HeatCapacityRatio</seealso>
    let HeatCapacityRatio = Prefixed_Name(qk, "HeatCapacityRatio") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeatFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HeatFlowRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heat Flow Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeatFlowRate">http://qudt.org/vocab/quantitykind/HeatFlowRate</seealso>
    let HeatFlowRate = Prefixed_Name(qk, "HeatFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeatFlowRatePerArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heat Flow Rate per Unit Area"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeatFlowRatePerArea">http://qudt.org/vocab/quantitykind/HeatFlowRatePerArea</seealso>
    let HeatFlowRatePerArea = Prefixed_Name(qk, "HeatFlowRatePerArea") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeatFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:PowerPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heat Flux Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeatFluxDensity">http://qudt.org/vocab/quantitykind/HeatFluxDensity</seealso>
    let HeatFluxDensity = Prefixed_Name(qk, "HeatFluxDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HeatingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:SpecificEnergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Calorific Value"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HeatingValue">http://qudt.org/vocab/quantitykind/HeatingValue</seealso>
    let HeatingValue = Prefixed_Name(qk, "HeatingValue") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Height</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Výška"</para><para>"высота"</para><para>"yükseklik"</para><para>"Höhe"</para><para>"高度"</para><para>"height"</para><para>"altura"</para><para>"Înălțime"</para><para>"ارتفاع"</para><para>"Ketinggian"</para><para>"hauteur"</para><para>"altezza"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Height">http://qudt.org/vocab/quantitykind/Height</seealso>
    let Height = Prefixed_Name(qk, "Height") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HelmholtzEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tenaga Helmholtz"</para><para>"Helmholtz enerjisi"</para><para>"свободная энергия Гельмгольца"</para><para>"Helmholtz energy"</para><para>"energia swobodna"</para><para>"Prosta energija"</para><para>"energia libera di Helmholz"</para><para>"طاقة هلمهولتز الحرة"</para><para>"亥姆霍兹自由能"</para><para>"Helmholtzova volná energie"</para><para>"ヘルムホルツの自由エネルギー"</para><para>"energia livre de Helmholtz"</para><para>"énergie libre"</para><para>"freie Energie"</para><para>"Energía de Helmholtz"</para><para>"انرژی آزاد هلمولتز"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HelmholtzEnergy">http://qudt.org/vocab/quantitykind/HelmholtzEnergy</seealso>
    let HelmholtzEnergy = Prefixed_Name(qk, "HelmholtzEnergy") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/HenrysLawVolatilityConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HenrysLawVolatilityConstant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Henry's Law Volatility Constant"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HenrysLawVolatilityConstant">http://qudt.org/vocab/quantitykind/HenrysLawVolatilityConstant</seealso>
    let HenrysLawVolatilityConstant =
        Prefixed_Name(qk, "HenrysLawVolatilityConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/HoleDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:NumberDensity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hole Density"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HoleDensity">http://qudt.org/vocab/quantitykind/HoleDensity</seealso>
    let HoleDensity = Prefixed_Name(qk, "HoleDensity") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/HorizontalVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Horizontal Velocity"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HorizontalVelocity">http://qudt.org/vocab/quantitykind/HorizontalVelocity</seealso>
    let HorizontalVelocity = Prefixed_Name(qk, "HorizontalVelocity") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/HydraulicPermeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HydraulicPermeability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hydraulic Permeability"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HydraulicPermeability">http://qudt.org/vocab/quantitykind/HydraulicPermeability</seealso>
    let HydraulicPermeability =
        Prefixed_Name(qk, "HydraulicPermeability") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/HyperfineStructureQuantumNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:HyperfineStructureQuantumNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hyperfine Structure Quantum Number"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/HyperfineStructureQuantumNumber">http://qudt.org/vocab/quantitykind/HyperfineStructureQuantumNumber</seealso>
    let HyperfineStructureQuantumNumber =
        Prefixed_Name(qk, "HyperfineStructureQuantumNumber") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/INERT-MASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inert Mass"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/INERT-MASS">http://qudt.org/vocab/quantitykind/INERT-MASS</seealso>
    let INERT_MASS = Prefixed_Name(qk, "INERT-MASS") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IgnitionIntervalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ignition interval time"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IgnitionIntervalTime">http://qudt.org/vocab/quantitykind/IgnitionIntervalTime</seealso>
    let IgnitionIntervalTime = Prefixed_Name(qk, "IgnitionIntervalTime") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Illuminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:LuminousFluxPerArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pencahayaan"</para><para>"照度"</para><para>"प्रदीपन"</para><para>"Освещённость"</para><para>"illuminamento"</para><para>"הארה (שטף ליחידת שטח)"</para><para>"شدة الضوء"</para><para>"iluminamento"</para><para>"iluminare"</para><para>"luminosidad"</para><para>"Intenzita osvětlení"</para><para>"natężenie oświetlenia"</para><para>"éclairement lumineux"</para><para>"Beleuchtungsstärke"</para><para>"megvilágítás"</para><para>"illuminance"</para><para>"Осветеност"</para><para>"aydınlanma şiddeti"</para><para>"osvetljenost"</para><para>"شدت روشنایی"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Illuminance">http://qudt.org/vocab/quantitykind/Illuminance</seealso>
    let Illuminance = Prefixed_Name(qk, "Illuminance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Impedance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Impedance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Impedance"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Impedance">http://qudt.org/vocab/quantitykind/Impedance</seealso>
    let Impedance = Prefixed_Name(qk, "Impedance") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Impulse</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Impulse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"impulse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"impulse"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Impulse">http://qudt.org/vocab/quantitykind/Impulse</seealso>
    let Impulse = Prefixed_Name(qk, "Impulse") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Incidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Incidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incidence"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Incidence">http://qudt.org/vocab/quantitykind/Incidence</seealso>
    let Incidence = Prefixed_Name(qk, "Incidence") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IncidenceProportion</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Incidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incidence Proportion"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IncidenceProportion">http://qudt.org/vocab/quantitykind/IncidenceProportion</seealso>
    let IncidenceProportion = Prefixed_Name(qk, "IncidenceProportion") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/IncidenceRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Incidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Incidence Rate"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/IncidenceRate">http://qudt.org/vocab/quantitykind/IncidenceRate</seealso>
    let IncidenceRate = Prefixed_Name(qk, "IncidenceRate") |> PrefixedName
    /// <summary>
    ///   <para>quantitykind:/Inductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:Inductance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"induttanza"</para><para>"インダクタンス・誘導係数"</para><para>"Индуктивность"</para><para>"indutância"</para><para>"inductancia"</para><para>"المحاثة (التحريض)"</para><para>"Indukstans"</para><para>"Inductance électrique"</para><para>"inductantia"</para><para>"induktivitás"</para><para>"İndüktans"</para><para>"Indukčnost"</para><para>"القاوری"</para><para>"inductance"</para><para>"Induktivität"</para><para>"induktivnost"</para><para>"השראות"</para><para>"电感"</para><para>"Индуктивност"</para><para>"indukcyjność"</para><para>"प्रेरकत्व"</para><para>"inductanță"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/Inductance">http://qudt.org/vocab/quantitykind/Inductance</seealso>
    let Inductance = Prefixed_Name(qk, "Inductance") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InductanceBasedTimeConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"Inductance based time constant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InductanceBasedTimeConstant">http://qudt.org/vocab/quantitykind/InductanceBasedTimeConstant</seealso>
    let InductanceBasedTimeConstant =
        Prefixed_Name(qk, "InductanceBasedTimeConstant") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InfiniteMultiplicationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///   <para>"Applicable units are those of quantitykind:MultiplicationFactor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Infinite Multiplication Factor"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InfiniteMultiplicationFactor">http://qudt.org/vocab/quantitykind/InfiniteMultiplicationFactor</seealso>
    let InfiniteMultiplicationFactor =
        Prefixed_Name(qk, "InfiniteMultiplicationFactor") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InformationContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"information content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InformationContent">http://qudt.org/vocab/quantitykind/InformationContent</seealso>
    let InformationContent = Prefixed_Name(qk, "InformationContent") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InformationContentExpressedAsALogarithmToBase10</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"information content expressed as a logarithm to base 10"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase10">http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase10</seealso>
    let InformationContentExpressedAsALogarithmToBase10 =
        Prefixed_Name(qk, "InformationContentExpressedAsALogarithmToBase10") |> PrefixedName

    /// <summary>
    ///   <para>quantitykind:/InformationContentExpressedAsALogarithmToBase2</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:QuantityKind</para>
    ///
    /// labels<para>"information content expressed as a logarithm to base 2"</para></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase2">http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase2</seealso>
    let InformationContentExpressedAsALogarithmToBase2 =
        Prefixed_Name(qk, "InformationContentExpressedAsALogarithmToBase2") |> PrefixedName
