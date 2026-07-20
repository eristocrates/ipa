namespace http.qudt.org.vocab.quantitykind.bare

open DoxAletheia

module qudt_quantitykind =
    let _namespace_name = "http://qudt.org/vocab/quantitykind"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:APIGravity
    /// <see href="http://qudt.org/vocab/quantitykind/APIGravity"></see></summary>
    let ``_/APIGravity`` = _prefix "/APIGravity"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/DimensionlessRatio"></see></summary>
    let ``_/DimensionlessRatio`` = _prefix "/DimensionlessRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:AbsoluteActivity
    /// <see href="http://qudt.org/vocab/quantitykind/AbsoluteActivity"></see></summary>
    let ``_/AbsoluteActivity`` = _prefix "/AbsoluteActivity"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseVolume
    /// <see href="http://qudt.org/vocab/quantitykind/InverseVolume"></see></summary>
    let ``_/InverseVolume`` = _prefix "/InverseVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/AbsoluteHumidity"></see></summary>
    let ``_/AbsoluteHumidity`` = _prefix "/AbsoluteHumidity"
    /// <summary>
    /// Applicable units are those of quantitykind:RelativeHumidity
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeHumidity"></see></summary>
    let ``_/RelativeHumidity`` = _prefix "/RelativeHumidity"
    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/Density"></see></summary>
    let ``_/Density`` = _prefix "/Density"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/AbsoluteTypographicMeasurement"></see></summary>
    let ``_/AbsoluteTypographicMeasurement`` = _prefix "/AbsoluteTypographicMeasurement"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Length"></see></summary>
    let ``_/Length`` = _prefix "/Length"
    /// <summary>
    /// Applicable units are those of quantitykind:AbsorbedDose
    /// Note that the absorbed dose is not a good indicator of the likely biological effect. 1 Gy of alpha radiation would be much more biologically damaging than 1 Gy of photon radiation for example. Appropriate weighting factors can be applied reflecting the different relative biological effects to find the equivalent dose. The risk of stoctic effects due to radiation exposure can be quantified using the effective dose, which is a weighted average of the equivalent dose to each organ depending upon its radiosensitivity. When ionising radiation is used to treat cancer, the doctor will usually prescribe the radiotherapy treatment in Gy. When risk from ionising radiation is being discussed, a related unit, the Sievert is used.
    /// <see href="http://qudt.org/vocab/quantitykind/AbsorbedDose"></see></summary>
    let ``_/AbsorbedDose`` = _prefix "/AbsorbedDose"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEnergy"></see></summary>
    let ``_/SpecificEnergy`` = _prefix "/SpecificEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:AbsorbedDoseRate
    /// <see href="http://qudt.org/vocab/quantitykind/AbsorbedDoseRate"></see></summary>
    let ``_/AbsorbedDoseRate`` = _prefix "/AbsorbedDoseRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Absorptance
    /// <see href="http://qudt.org/vocab/quantitykind/Absorptance"></see></summary>
    let ``_/Absorptance`` = _prefix "/Absorptance"
    /// <summary>
    /// Applicable units are those of quantitykind:Acceleration
    /// <see href="http://qudt.org/vocab/quantitykind/Acceleration"></see></summary>
    let ``_/Acceleration`` = _prefix "/Acceleration"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearAcceleration
    /// <see href="http://qudt.org/vocab/quantitykind/LinearAcceleration"></see></summary>
    let ``_/LinearAcceleration`` = _prefix "/LinearAcceleration"
    /// <summary>
    /// Applicable units are those of quantitykind:Acceleration
    /// <see href="http://qudt.org/vocab/quantitykind/AccelerationOfGravity"></see></summary>
    let ``_/AccelerationOfGravity`` = _prefix "/AccelerationOfGravity"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/AcceptorDensity"></see></summary>
    let ``_/AcceptorDensity`` = _prefix "/AcceptorDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/NumberDensity"></see></summary>
    let ``_/NumberDensity`` = _prefix "/NumberDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AcceptorIonizationEnergy"></see></summary>
    let ``_/AcceptorIonizationEnergy`` = _prefix "/AcceptorIonizationEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/IonizationEnergy"></see></summary>
    let ``_/IonizationEnergy`` = _prefix "/IonizationEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/DonorIonizationEnergy"></see></summary>
    let ``_/DonorIonizationEnergy`` = _prefix "/DonorIonizationEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Acidity
    /// <see href="http://qudt.org/vocab/quantitykind/Acidity"></see></summary>
    let ``_/Acidity`` = _prefix "/Acidity"
    /// <summary>
    /// Applicable units are those of quantitykind:Basicity
    /// <see href="http://qudt.org/vocab/quantitykind/Basicity"></see></summary>
    let ``_/Basicity`` = _prefix "/Basicity"
    /// <summary>
    /// Applicable units are those of quantitykind:AcousticImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/AcousticImpedance"></see></summary>
    let ``_/AcousticImpedance`` = _prefix "/AcousticImpedance"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerAreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerAreaTime"></see></summary>
    let ``_/MassPerAreaTime`` = _prefix "/MassPerAreaTime"
    /// <summary>
    /// Applicable units are those of quantitykind:Action
    /// <see href="http://qudt.org/vocab/quantitykind/Action"></see></summary>
    let ``_/Action`` = _prefix "/Action"
    /// <summary>
    /// Action Time (sec)
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/ActionTime"></see></summary>
    let ``_/ActionTime`` = _prefix "/ActionTime"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/Time"></see></summary>
    let ``_/Time`` = _prefix "/Time"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ActiveEnergy"></see></summary>
    let ``_/ActiveEnergy`` = _prefix "/ActiveEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/InstantaneousPower"></see></summary>
    let ``_/InstantaneousPower`` = _prefix "/InstantaneousPower"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/Energy"></see></summary>
    let ``_/Energy`` = _prefix "/Energy"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/ActivePower"></see></summary>
    let ``_/ActivePower`` = _prefix "/ActivePower"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPower"></see></summary>
    let ``_/ElectricPower`` = _prefix "/ElectricPower"
    /// <summary>
    /// Applicable units are those of quantitykind:Activity
    /// <see href="http://qudt.org/vocab/quantitykind/Activity"></see></summary>
    let ``_/Activity`` = _prefix "/Activity"
    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/StochasticProcess"></see></summary>
    let ``_/StochasticProcess`` = _prefix "/StochasticProcess"
    /// <summary>
    /// Applicable units are those of quantitykind:ActivityCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ActivityCoefficient"></see></summary>
    let ``_/ActivityCoefficient`` = _prefix "/ActivityCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ActivityConcentration
    /// <see href="http://qudt.org/vocab/quantitykind/ActivityConcentration"></see></summary>
    let ``_/ActivityConcentration`` = _prefix "/ActivityConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:MassicActivity
    /// <see href="http://qudt.org/vocab/quantitykind/ActivityRelatedByMass"></see></summary>
    let ``_/ActivityRelatedByMass`` = _prefix "/ActivityRelatedByMass"
    /// <summary>
    /// Applicable units are those of quantitykind:MassicActivity
    /// <see href="http://qudt.org/vocab/quantitykind/MassicActivity"></see></summary>
    let ``_/MassicActivity`` = _prefix "/MassicActivity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ActivityThresholds"></see>
    /// </summary>
    let ``_/ActivityThresholds`` = _prefix "/ActivityThresholds"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/Adaptation"></see></summary>
    let ``_/Adaptation`` = _prefix "/Adaptation"
    /// <summary>
    /// Applicable units are those of quantitykind:Admittance
    /// <see href="http://qudt.org/vocab/quantitykind/Admittance"></see></summary>
    let ``_/Admittance`` = _prefix "/Admittance"
    /// <summary>
    /// Applicable units are those of quantitykind:Impedance
    /// <see href="http://qudt.org/vocab/quantitykind/Impedance"></see></summary>
    let ``_/Impedance`` = _prefix "/Impedance"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AlphaDisintegrationEnergy"></see></summary>
    let ``_/AlphaDisintegrationEnergy`` = _prefix "/AlphaDisintegrationEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Altitude"></see></summary>
    let ``_/Altitude`` = _prefix "/Altitude"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AmbientPressure"></see></summary>
    let ``_/AmbientPressure`` = _prefix "/AmbientPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/Pressure"></see></summary>
    let ``_/Pressure`` = _prefix "/Pressure"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AmountOfBiologicallyActiveSubstance"></see>
    /// </summary>
    let ``_/AmountOfBiologicallyActiveSubstance`` =
        _prefix "/AmountOfBiologicallyActiveSubstance"

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfCloudCover
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfCloudCover"></see></summary>
    let ``_/AmountOfCloudCover`` = _prefix "/AmountOfCloudCover"
    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstance"></see></summary>
    let ``_/AmountOfSubstance`` = _prefix "/AmountOfSubstance"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceConcentration"></see></summary>
    let ``_/AmountOfSubstanceConcentration`` = _prefix "/AmountOfSubstanceConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerVolume"></see></summary>
    let ``_/AmountOfSubstancePerVolume`` = _prefix "/AmountOfSubstancePerVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/Concentration"></see></summary>
    let ``_/Concentration`` = _prefix "/Concentration"
    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstanceFraction
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceFraction"></see></summary>
    let ``_/AmountOfSubstanceFraction`` = _prefix "/AmountOfSubstanceFraction"

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceIonConcentration"></see></summary>
    let ``_/AmountOfSubstanceIonConcentration`` =
        _prefix "/AmountOfSubstanceIonConcentration"

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstancePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMass"></see></summary>
    let ``_/AmountOfSubstancePerMass`` = _prefix "/AmountOfSubstancePerMass"

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstancePerMassPressure
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMassPressure"></see></summary>
    let ``_/AmountOfSubstancePerMassPressure`` =
        _prefix "/AmountOfSubstancePerMassPressure"

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/Angle"></see></summary>
    let ``_/Angle`` = _prefix "/Angle"
    /// <summary>
    /// Applicable units are those of quantitykind:PlaneAngle
    /// <see href="http://qudt.org/vocab/quantitykind/PlaneAngle"></see></summary>
    let ``_/PlaneAngle`` = _prefix "/PlaneAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/AngleOfAttack"></see></summary>
    let ``_/AngleOfAttack`` = _prefix "/AngleOfAttack"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/AngleOfOpticalRotation"></see></summary>
    let ``_/AngleOfOpticalRotation`` = _prefix "/AngleOfOpticalRotation"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularAcceleration
    /// <see href="http://qudt.org/vocab/quantitykind/AngularAcceleration"></see></summary>
    let ``_/AngularAcceleration`` = _prefix "/AngularAcceleration"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseSquareTime
    /// <see href="http://qudt.org/vocab/quantitykind/InverseSquareTime"></see></summary>
    let ``_/InverseSquareTime`` = _prefix "/InverseSquareTime"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularCrossSection
    /// <see href="http://qudt.org/vocab/quantitykind/AngularCrossSection"></see></summary>
    let ``_/AngularCrossSection`` = _prefix "/AngularCrossSection"
    /// <summary>
    /// Applicable units are those of quantitykind:SpectralCrossSection
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralCrossSection"></see></summary>
    let ``_/SpectralCrossSection`` = _prefix "/SpectralCrossSection"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/AngularDistance"></see></summary>
    let ``_/AngularDistance`` = _prefix "/AngularDistance"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/AngularFrequency"></see></summary>
    let ``_/AngularFrequency`` = _prefix "/AngularFrequency"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/AngularVelocity"></see></summary>
    let ``_/AngularVelocity`` = _prefix "/AngularVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:RotationalFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalFrequency"></see></summary>
    let ``_/RotationalFrequency`` = _prefix "/RotationalFrequency"
    /// <summary>
    /// Applicable units are those of quantitykind:RotationalVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalVelocity"></see></summary>
    let ``_/RotationalVelocity`` = _prefix "/RotationalVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularImpulse
    /// <see href="http://qudt.org/vocab/quantitykind/AngularImpulse"></see></summary>
    let ``_/AngularImpulse`` = _prefix "/AngularImpulse"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/AngularMomentum"></see></summary>
    let ``_/AngularMomentum`` = _prefix "/AngularMomentum"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentumPerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/AngularMomentumPerAngle"></see></summary>
    let ``_/AngularMomentumPerAngle`` = _prefix "/AngularMomentumPerAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularReciprocalLatticeVector
    /// <see href="http://qudt.org/vocab/quantitykind/AngularReciprocalLatticeVector"></see></summary>
    let ``_/AngularReciprocalLatticeVector`` = _prefix "/AngularReciprocalLatticeVector"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularWavenumber
    /// <see href="http://qudt.org/vocab/quantitykind/AngularWavenumber"></see></summary>
    let ``_/AngularWavenumber`` = _prefix "/AngularWavenumber"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseLength
    /// <see href="http://qudt.org/vocab/quantitykind/InverseLength"></see></summary>
    let ``_/InverseLength`` = _prefix "/InverseLength"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ApogeeRadius"></see></summary>
    let ``_/ApogeeRadius`` = _prefix "/ApogeeRadius"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Radius"></see></summary>
    let ``_/Radius`` = _prefix "/Radius"
    /// <summary>
    /// Applicable units are those of quantitykind:ApparentPower
    /// <see href="http://qudt.org/vocab/quantitykind/ApparentPower"></see></summary>
    let ``_/ApparentPower`` = _prefix "/ApparentPower"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrent"></see></summary>
    let ``_/ElectricCurrent`` = _prefix "/ElectricCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:Voltage
    /// <see href="http://qudt.org/vocab/quantitykind/Voltage"></see></summary>
    let ``_/Voltage`` = _prefix "/Voltage"
    /// <summary>
    /// Applicable units are those of quantitykind:ApparentThermalInertia
    /// <see href="http://qudt.org/vocab/quantitykind/ApparentThermalInertia"></see></summary>
    let ``_/ApparentThermalInertia`` = _prefix "/ApparentThermalInertia"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/Area"></see></summary>
    let ``_/Area`` = _prefix "/Area"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaAngle
    /// <see href="http://qudt.org/vocab/quantitykind/AreaAngle"></see></summary>
    let ``_/AreaAngle`` = _prefix "/AreaAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaBitDensity
    /// <see href="http://qudt.org/vocab/quantitykind/AreaBitDensity"></see></summary>
    let ``_/AreaBitDensity`` = _prefix "/AreaBitDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreaChargeDensity"></see></summary>
    let ``_/AreaChargeDensity`` = _prefix "/AreaChargeDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargePerArea"></see></summary>
    let ``_/ElectricChargePerArea`` = _prefix "/ElectricChargePerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreaMass"></see></summary>
    let ``_/AreaMass`` = _prefix "/AreaMass"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerArea"></see></summary>
    let ``_/MassPerArea`` = _prefix "/MassPerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/AreaPerLength"></see></summary>
    let ``_/AreaPerLength`` = _prefix "/AreaPerLength"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerPower
    /// <see href="http://qudt.org/vocab/quantitykind/AreaPerPower"></see></summary>
    let ``_/AreaPerPower`` = _prefix "/AreaPerPower"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/AreaPerTime"></see></summary>
    let ``_/AreaPerTime`` = _prefix "/AreaPerTime"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaRatio
    /// <see href="http://qudt.org/vocab/quantitykind/AreaRatio"></see></summary>
    let ``_/AreaRatio`` = _prefix "/AreaRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/AreaTemperature"></see></summary>
    let ``_/AreaTemperature`` = _prefix "/AreaTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaThermalExpansion
    /// <see href="http://qudt.org/vocab/quantitykind/AreaThermalExpansion"></see></summary>
    let ``_/AreaThermalExpansion`` = _prefix "/AreaThermalExpansion"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/AreaTime"></see></summary>
    let ``_/AreaTime`` = _prefix "/AreaTime"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaTimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/AreaTimeTemperature"></see></summary>
    let ``_/AreaTimeTemperature`` = _prefix "/AreaTimeTemperature"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization"></see>
    /// </summary>
    let ``_/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization`` =
        _prefix "/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AreicDataVolume"></see>
    /// </summary>
    let ``_/AreicDataVolume`` = _prefix "/AreicDataVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreicEnergyFlow"></see></summary>
    let ``_/AreicEnergyFlow`` = _prefix "/AreicEnergyFlow"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerArea"></see></summary>
    let ``_/PowerPerArea`` = _prefix "/PowerPerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreicHeatFlowRate"></see></summary>
    let ``_/AreicHeatFlowRate`` = _prefix "/AreicHeatFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreicMass"></see></summary>
    let ``_/AreicMass`` = _prefix "/AreicMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AreicTorque"></see>
    /// </summary>
    let ``_/AreicTorque`` = _prefix "/AreicTorque"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Asset"></see>
    /// </summary>
    let ``_/Asset`` = _prefix "/Asset"
    /// <summary>
    /// Applicable units are those of quantitykind:AtmosphericHydroxylationRate
    /// <see href="http://qudt.org/vocab/quantitykind/AtmosphericHydroxylationRate"></see></summary>
    let ``_/AtmosphericHydroxylationRate`` = _prefix "/AtmosphericHydroxylationRate"

    /// <summary>
    /// Applicable units are those of quantitykind:SecondOrderReactionRateConstant
    /// <see href="http://qudt.org/vocab/quantitykind/SecondOrderReactionRateConstant"></see></summary>
    let ``_/SecondOrderReactionRateConstant`` =
        _prefix "/SecondOrderReactionRateConstant"

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AtmosphericPressure"></see></summary>
    let ``_/AtmosphericPressure`` = _prefix "/AtmosphericPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:AtomScatteringFactor
    /// <see href="http://qudt.org/vocab/quantitykind/AtomScatteringFactor"></see></summary>
    let ``_/AtomScatteringFactor`` = _prefix "/AtomScatteringFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicAttenuationCoefficient"></see></summary>
    let ``_/AtomicAttenuationCoefficient`` = _prefix "/AtomicAttenuationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarAttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MolarAttenuationCoefficient"></see></summary>
    let ``_/MolarAttenuationCoefficient`` = _prefix "/MolarAttenuationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicCharge"></see></summary>
    let ``_/AtomicCharge`` = _prefix "/AtomicCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCharge"></see></summary>
    let ``_/ElectricCharge`` = _prefix "/ElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicEnergy"></see></summary>
    let ``_/AtomicEnergy`` = _prefix "/AtomicEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicMass"></see></summary>
    let ``_/AtomicMass`` = _prefix "/AtomicMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/Mass"></see></summary>
    let ``_/Mass`` = _prefix "/Mass"
    /// <summary>
    /// Applicable units are those of quantitykind:AtomicNumber
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicNumber"></see></summary>
    let ``_/AtomicNumber`` = _prefix "/AtomicNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Count
    /// <see href="http://qudt.org/vocab/quantitykind/Count"></see></summary>
    let ``_/Count`` = _prefix "/Count"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AtomicStoppingPower"></see>
    /// </summary>
    let ``_/AtomicStoppingPower`` = _prefix "/AtomicStoppingPower"
    /// <summary>
    /// Applicable units are those of quantitykind:AttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/AttenuationCoefficient"></see></summary>
    let ``_/AttenuationCoefficient`` = _prefix "/AttenuationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundPowerLevel
    /// <see href="http://qudt.org/vocab/quantitykind/AuditoryThresholds"></see></summary>
    let ``_/AuditoryThresholds`` = _prefix "/AuditoryThresholds"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundPowerLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPowerLevel"></see></summary>
    let ``_/SoundPowerLevel`` = _prefix "/SoundPowerLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFieldStrength
    /// <see href="http://qudt.org/vocab/quantitykind/AuxillaryMagneticField"></see></summary>
    let ``_/AuxillaryMagneticField`` = _prefix "/AuxillaryMagneticField"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFieldStrength
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFieldStrength"></see></summary>
    let ``_/MagneticFieldStrength`` = _prefix "/MagneticFieldStrength"

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AverageEnergyLossPerElementaryChargeProduced"></see></summary>
    let ``_/AverageEnergyLossPerElementaryChargeProduced`` =
        _prefix "/AverageEnergyLossPerElementaryChargeProduced"

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AverageHeadEndPressure"></see></summary>
    let ``_/AverageHeadEndPressure`` = _prefix "/AverageHeadEndPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/HeadEndPressure"></see></summary>
    let ``_/HeadEndPressure`` = _prefix "/HeadEndPressure"

    /// <summary>
    /// Applicable units are those of quantitykind:AverageLogarithmicEnergyDecrement
    /// <see href="http://qudt.org/vocab/quantitykind/AverageLogarithmicEnergyDecrement"></see></summary>
    let ``_/AverageLogarithmicEnergyDecrement`` =
        _prefix "/AverageLogarithmicEnergyDecrement"

    /// <summary>
    /// Avg Specific Impulse (lbf-sec/lbm)
    /// <see href="http://qudt.org/vocab/quantitykind/AverageSpecificImpulse"></see></summary>
    let ``_/AverageSpecificImpulse`` = _prefix "/AverageSpecificImpulse"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpecificImpulse"></see>
    /// </summary>
    let ``_/SpecificImpulse`` = _prefix "/SpecificImpulse"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/AverageVacuumThrust"></see></summary>
    let ``_/AverageVacuumThrust`` = _prefix "/AverageVacuumThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/VacuumThrust"></see></summary>
    let ``_/VacuumThrust`` = _prefix "/VacuumThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/Azimuth"></see></summary>
    let ``_/Azimuth`` = _prefix "/Azimuth"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BandwidthDistanceProduct"></see>
    /// </summary>
    let ``_/BandwidthDistanceProduct`` = _prefix "/BandwidthDistanceProduct"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BandwidthLengthProduct"></see>
    /// </summary>
    let ``_/BandwidthLengthProduct`` = _prefix "/BandwidthLengthProduct"
    /// <summary>
    /// Applicable units are those of quantitykind:BatteryCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/BatteryCapacity"></see></summary>
    let ``_/BatteryCapacity`` = _prefix "/BatteryCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:Torque
    /// <see href="http://qudt.org/vocab/quantitykind/BendingMomentOfForce"></see></summary>
    let ``_/BendingMomentOfForce`` = _prefix "/BendingMomentOfForce"
    /// <summary>
    /// Applicable units are those of quantitykind:Torque
    /// <see href="http://qudt.org/vocab/quantitykind/Torque"></see></summary>
    let ``_/Torque`` = _prefix "/Torque"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/BetaDisintegrationEnergy"></see></summary>
    let ``_/BetaDisintegrationEnergy`` = _prefix "/BetaDisintegrationEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/BevelGearPitchAngle"></see></summary>
    let ``_/BevelGearPitchAngle`` = _prefix "/BevelGearPitchAngle"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BinaryLogarithmicMedianInformationFlow"></see>
    /// </summary>
    let ``_/BinaryLogarithmicMedianInformationFlow`` =
        _prefix "/BinaryLogarithmicMedianInformationFlow"

    /// <summary>
    /// Applicable units are those of quantitykind:BindingFraction
    /// <see href="http://qudt.org/vocab/quantitykind/BindingFraction"></see></summary>
    let ``_/BindingFraction`` = _prefix "/BindingFraction"
    /// <summary>
    /// Applicable units are those of quantitykind:BioconcentrationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/BioconcentrationFactor"></see></summary>
    let ``_/BioconcentrationFactor`` = _prefix "/BioconcentrationFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:BiodegredationHalfLife
    /// <see href="http://qudt.org/vocab/quantitykind/BiodegredationHalfLife"></see></summary>
    let ``_/BiodegredationHalfLife`` = _prefix "/BiodegredationHalfLife"
    /// <summary>
    /// Applicable units are those of quantitykind:BiogeochemicalRate
    /// <see href="http://qudt.org/vocab/quantitykind/BiogeochemicalRate"></see></summary>
    let ``_/BiogeochemicalRate`` = _prefix "/BiogeochemicalRate"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BitDataVolume"></see>
    /// </summary>
    let ``_/BitDataVolume`` = _prefix "/BitDataVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:BitRate
    /// <see href="http://qudt.org/vocab/quantitykind/BitRate"></see></summary>
    let ``_/BitRate`` = _prefix "/BitRate"
    /// <summary>
    /// Applicable units are those of quantitykind:BitRate
    /// <see href="http://qudt.org/vocab/quantitykind/BitTransmissionRate"></see></summary>
    let ``_/BitTransmissionRate`` = _prefix "/BitTransmissionRate"
    /// <summary>
    /// Applicable units are those of quantitykind:BloodGlucoseLevel
    /// <see href="http://qudt.org/vocab/quantitykind/BloodGlucoseLevel"></see></summary>
    let ``_/BloodGlucoseLevel`` = _prefix "/BloodGlucoseLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:MassBasedBloodGlucoseLevel
    /// <see href="http://qudt.org/vocab/quantitykind/MassBasedBloodGlucoseLevel"></see></summary>
    let ``_/MassBasedBloodGlucoseLevel`` = _prefix "/MassBasedBloodGlucoseLevel"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BloodGlucoseLevel_Mass"></see>
    /// </summary>
    let ``_/BloodGlucoseLevel_Mass`` = _prefix "/BloodGlucoseLevel_Mass"
    /// <summary>
    /// Applicable units are those of quantitykind:BodyMassIndex
    /// <see href="http://qudt.org/vocab/quantitykind/BodyMassIndex"></see></summary>
    let ``_/BodyMassIndex`` = _prefix "/BodyMassIndex"
    /// <summary>
    /// Applicable units are those of quantitykind:BoilingPoint
    /// <see href="http://qudt.org/vocab/quantitykind/BoilingPoint"></see></summary>
    let ``_/BoilingPoint`` = _prefix "/BoilingPoint"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/Temperature"></see></summary>
    let ``_/Temperature`` = _prefix "/Temperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/BraggAngle"></see></summary>
    let ``_/BraggAngle`` = _prefix "/BraggAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Breadth"></see></summary>
    let ``_/Breadth`` = _prefix "/Breadth"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/BucklingFactor"></see></summary>
    let ``_/BucklingFactor`` = _prefix "/BucklingFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/Dimensionless"></see></summary>
    let ``_/Dimensionless`` = _prefix "/Dimensionless"
    /// <summary>
    /// Applicable units are those of quantitykind:BulkModulus
    /// <see href="http://qudt.org/vocab/quantitykind/BulkModulus"></see></summary>
    let ``_/BulkModulus`` = _prefix "/BulkModulus"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/BurgersVector"></see></summary>
    let ``_/BurgersVector`` = _prefix "/BurgersVector"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/BurnRate"></see></summary>
    let ``_/BurnRate`` = _prefix "/BurnRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/Velocity"></see></summary>
    let ``_/Velocity`` = _prefix "/Velocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/BurnTime"></see></summary>
    let ``_/BurnTime`` = _prefix "/BurnTime"
    /// <summary>
    /// Applicable units are those of quantitykind:BurstFactor
    /// <see href="http://qudt.org/vocab/quantitykind/BurstFactor"></see></summary>
    let ``_/BurstFactor`` = _prefix "/BurstFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Count
    /// <see href="http://qudt.org/vocab/quantitykind/ByteDataVolume"></see></summary>
    let ``_/ByteDataVolume`` = _prefix "/ByteDataVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:ByteRate
    /// <see href="http://qudt.org/vocab/quantitykind/ByteRate"></see></summary>
    let ``_/ByteRate`` = _prefix "/ByteRate"
    /// <summary>
    /// Applicable units are those of quantitykind:ByteRate
    /// <see href="http://qudt.org/vocab/quantitykind/ByteTransmissionRate"></see></summary>
    let ``_/ByteTransmissionRate`` = _prefix "/ByteTransmissionRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_X"></see></summary>
    let ``_/CENTER-OF-GRAVITY_X`` = _prefix "/CENTER-OF-GRAVITY_X"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CenterOfGravity_X"></see></summary>
    let ``_/CenterOfGravity_X`` = _prefix "/CenterOfGravity_X"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Y"></see></summary>
    let ``_/CENTER-OF-GRAVITY_Y`` = _prefix "/CENTER-OF-GRAVITY_Y"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CenterOfGravity_Y"></see></summary>
    let ``_/CenterOfGravity_Y`` = _prefix "/CenterOfGravity_Y"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Z"></see></summary>
    let ``_/CENTER-OF-GRAVITY_Z`` = _prefix "/CENTER-OF-GRAVITY_Z"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CenterOfGravity_Z"></see></summary>
    let ``_/CenterOfGravity_Z`` = _prefix "/CenterOfGravity_Z"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-MASS"></see></summary>
    let ``_/CENTER-OF-MASS`` = _prefix "/CENTER-OF-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PositionVector"></see></summary>
    let ``_/PositionVector`` = _prefix "/PositionVector"
    /// <summary>
    /// Applicable units are those of quantitykind:CO2Equivalent
    /// <see href="http://qudt.org/vocab/quantitykind/CO2Equivalent"></see></summary>
    let ``_/CO2Equivalent`` = _prefix "/CO2Equivalent"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassEquivalent"></see></summary>
    let ``_/MassEquivalent`` = _prefix "/MassEquivalent"

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/CONTRACT-END-ITEM-SPECIFICATION-MASS"></see></summary>
    let ``_/CONTRACT-END-ITEM-SPECIFICATION-MASS`` =
        _prefix "/CONTRACT-END-ITEM-SPECIFICATION-MASS"

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/CONTROL-MASS"></see></summary>
    let ``_/CONTROL-MASS`` = _prefix "/CONTROL-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:CanonicalPartitionFunction
    /// <see href="http://qudt.org/vocab/quantitykind/CanonicalPartitionFunction"></see></summary>
    let ``_/CanonicalPartitionFunction`` = _prefix "/CanonicalPartitionFunction"
    /// <summary>
    /// Applicable units are those of quantitykind:Capacitance
    /// <see href="http://qudt.org/vocab/quantitykind/Capacitance"></see></summary>
    let ``_/Capacitance`` = _prefix "/Capacitance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Capacity"></see>
    /// </summary>
    let ``_/Capacity`` = _prefix "/Capacity"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/CarrierLifetime"></see></summary>
    let ``_/CarrierLifetime`` = _prefix "/CarrierLifetime"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/CartesianArea"></see></summary>
    let ``_/CartesianArea`` = _prefix "/CartesianArea"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CartesianCoordinates"></see></summary>
    let ``_/CartesianCoordinates`` = _prefix "/CartesianCoordinates"
    /// <summary>
    /// Applicable units are those of quantitykind:Volume
    /// <see href="http://qudt.org/vocab/quantitykind/CartesianVolume"></see></summary>
    let ``_/CartesianVolume`` = _prefix "/CartesianVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:Volume
    /// <see href="http://qudt.org/vocab/quantitykind/Volume"></see></summary>
    let ``_/Volume`` = _prefix "/Volume"
    /// <summary>
    /// Applicable units are those of quantitykind:CatalyticActivity
    /// <see href="http://qudt.org/vocab/quantitykind/CatalyticActivity"></see></summary>
    let ``_/CatalyticActivity`` = _prefix "/CatalyticActivity"
    /// <summary>
    /// Applicable units are those of quantitykind:CatalyticActivityConcentration
    /// <see href="http://qudt.org/vocab/quantitykind/CatalyticActivityConcentration"></see></summary>
    let ``_/CatalyticActivityConcentration`` = _prefix "/CatalyticActivityConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:ReactiveChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/CationExchangeCapacity"></see></summary>
    let ``_/CationExchangeCapacity`` = _prefix "/CationExchangeCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:ReactiveChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/ReactiveChargePerMass"></see></summary>
    let ``_/ReactiveChargePerMass`` = _prefix "/ReactiveChargePerMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/CelsiusTemperature"></see></summary>
    let ``_/CelsiusTemperature`` = _prefix "/CelsiusTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermodynamicTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicTemperature"></see></summary>
    let ``_/ThermodynamicTemperature`` = _prefix "/ThermodynamicTemperature"

    /// <summary>
    /// Applicable units are those of quantitykind:AcousticImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/CharacteristicAcousticImpedance"></see></summary>
    let ``_/CharacteristicAcousticImpedance`` =
        _prefix "/CharacteristicAcousticImpedance"

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/CharacteristicNumber"></see></summary>
    let ``_/CharacteristicNumber`` = _prefix "/CharacteristicNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/CharacteristicVelocity"></see></summary>
    let ``_/CharacteristicVelocity`` = _prefix "/CharacteristicVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:ChargeNumber
    /// <see href="http://qudt.org/vocab/quantitykind/ChargeNumber"></see></summary>
    let ``_/ChargeNumber`` = _prefix "/ChargeNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:ChemicalAffinity
    /// <see href="http://qudt.org/vocab/quantitykind/ChemicalAffinity"></see></summary>
    let ``_/ChemicalAffinity`` = _prefix "/ChemicalAffinity"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificVolume
    /// <see href="http://qudt.org/vocab/quantitykind/ChemicalConsumptionPerMass"></see></summary>
    let ``_/ChemicalConsumptionPerMass`` = _prefix "/ChemicalConsumptionPerMass"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificVolume
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificVolume"></see></summary>
    let ``_/SpecificVolume`` = _prefix "/SpecificVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/ChemicalPotential"></see></summary>
    let ``_/ChemicalPotential`` = _prefix "/ChemicalPotential"

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPropulsionPropellantMass"></see></summary>
    let ``_/ElectricPropulsionPropellantMass`` =
        _prefix "/ElectricPropulsionPropellantMass"

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarEnergy"></see></summary>
    let ``_/MolarEnergy`` = _prefix "/MolarEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Chromaticity
    /// <see href="http://qudt.org/vocab/quantitykind/Chromaticity"></see></summary>
    let ``_/Chromaticity`` = _prefix "/Chromaticity"
    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/Circulation"></see></summary>
    let ``_/Circulation`` = _prefix "/Circulation"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ClosestApproachRadius"></see></summary>
    let ``_/ClosestApproachRadius`` = _prefix "/ClosestApproachRadius"
    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/CoefficientOfHeatTransfer"></see></summary>
    let ``_/CoefficientOfHeatTransfer`` = _prefix "/CoefficientOfHeatTransfer"
    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfPerformance
    /// <see href="http://qudt.org/vocab/quantitykind/CoefficientOfPerformance"></see></summary>
    let ``_/CoefficientOfPerformance`` = _prefix "/CoefficientOfPerformance"
    /// <summary>
    /// Applicable units are those of quantitykind:Coercivity
    /// <see href="http://qudt.org/vocab/quantitykind/Coercivity"></see></summary>
    let ``_/Coercivity`` = _prefix "/Coercivity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CoherenceLength"></see></summary>
    let ``_/CoherenceLength`` = _prefix "/CoherenceLength"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/ColdReceptorThreshold"></see></summary>
    let ``_/ColdReceptorThreshold`` = _prefix "/ColdReceptorThreshold"

    /// <summary>
    /// Applicable units are those of quantitykind:CombinedNonEvaporativeHeatTransferCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/CombinedNonEvaporativeHeatTransferCoefficient"></see></summary>
    let ``_/CombinedNonEvaporativeHeatTransferCoefficient`` =
        _prefix "/CombinedNonEvaporativeHeatTransferCoefficient"

    /// <summary>
    /// Applicable units are those of quantitykind:ThermodynamicTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/CombustionChamberTemperature"></see></summary>
    let ``_/CombustionChamberTemperature`` = _prefix "/CombustionChamberTemperature"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/CommonLogarithmicMedianInformationFlow"></see>
    /// </summary>
    let ``_/CommonLogarithmicMedianInformationFlow`` =
        _prefix "/CommonLogarithmicMedianInformationFlow"

    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/ComplexFrequency_Imaginary"></see></summary>
    let ``_/ComplexFrequency_Imaginary`` = _prefix "/ComplexFrequency_Imaginary"
    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/Frequency"></see></summary>
    let ``_/Frequency`` = _prefix "/Frequency"
    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/ComplexFrequency_Real"></see></summary>
    let ``_/ComplexFrequency_Real`` = _prefix "/ComplexFrequency_Real"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/ComplexPower"></see></summary>
    let ``_/ComplexPower`` = _prefix "/ComplexPower"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPhasor
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPhasor"></see></summary>
    let ``_/ElectricCurrentPhasor`` = _prefix "/ElectricCurrentPhasor"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VoltagePhasor"></see>
    /// </summary>
    let ``_/VoltagePhasor`` = _prefix "/VoltagePhasor"
    /// <summary>
    /// Applicable units are those of quantitykind:PlaneAngle
    /// <see href="http://qudt.org/vocab/quantitykind/CompoundPlaneAngle"></see></summary>
    let ``_/CompoundPlaneAngle`` = _prefix "/CompoundPlaneAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:Compressibility
    /// <see href="http://qudt.org/vocab/quantitykind/Compressibility"></see></summary>
    let ``_/Compressibility`` = _prefix "/Compressibility"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/CompressibilityFactor"></see></summary>
    let ``_/CompressibilityFactor`` = _prefix "/CompressibilityFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Conductance
    /// <see href="http://qudt.org/vocab/quantitykind/Conductance"></see></summary>
    let ``_/Conductance`` = _prefix "/Conductance"
    /// <summary>
    /// Applicable units are those of quantitykind:ConductionSpeed
    /// <see href="http://qudt.org/vocab/quantitykind/ConductionSpeed"></see></summary>
    let ``_/ConductionSpeed`` = _prefix "/ConductionSpeed"
    /// <summary>
    /// Applicable units are those of quantitykind:Speed
    /// <see href="http://qudt.org/vocab/quantitykind/Speed"></see></summary>
    let ``_/Speed`` = _prefix "/Speed"
    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/ConductiveHeatTransferRate"></see></summary>
    let ``_/ConductiveHeatTransferRate`` = _prefix "/ConductiveHeatTransferRate"
    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/HeatFlowRate"></see></summary>
    let ``_/HeatFlowRate`` = _prefix "/HeatFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Conductivity
    /// <see href="http://qudt.org/vocab/quantitykind/Conductivity"></see></summary>
    let ``_/Conductivity`` = _prefix "/Conductivity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentDensity"></see></summary>
    let ``_/ElectricCurrentDensity`` = _prefix "/ElectricCurrentDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricFieldStrength
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricFieldStrength"></see></summary>
    let ``_/ElectricFieldStrength`` = _prefix "/ElectricFieldStrength"
    /// <summary>
    /// Applicable units are those of quantitykind:ConductivityVariance
    /// <see href="http://qudt.org/vocab/quantitykind/ConductivityVariance"></see></summary>
    let ``_/ConductivityVariance`` = _prefix "/ConductivityVariance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ConductivityVariance_NEON"></see>
    /// </summary>
    let ``_/ConductivityVariance_NEON`` = _prefix "/ConductivityVariance_NEON"
    /// <summary>
    /// Applicable units are those of quantitykind:Constringence
    /// <see href="http://qudt.org/vocab/quantitykind/Constringence"></see></summary>
    let ``_/Constringence`` = _prefix "/Constringence"
    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/ConvectiveHeatTransfer"></see></summary>
    let ``_/ConvectiveHeatTransfer`` = _prefix "/ConvectiveHeatTransfer"
    /// <summary>
    /// Applicable units are those of quantitykind:CoolingPerformanceRatio
    /// <see href="http://qudt.org/vocab/quantitykind/CoolingPerformanceRatio"></see></summary>
    let ``_/CoolingPerformanceRatio`` = _prefix "/CoolingPerformanceRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:CorrelatedColorTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/CorrelatedColorTemperature"></see></summary>
    let ``_/CorrelatedColorTemperature`` = _prefix "/CorrelatedColorTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Duv
    /// <see href="http://qudt.org/vocab/quantitykind/Duv"></see></summary>
    let ``_/Duv`` = _prefix "/Duv"
    /// <summary>
    /// Applicable units are those of quantitykind:CostPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerArea"></see></summary>
    let ``_/CostPerArea`` = _prefix "/CostPerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:CostPerEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerEnergy"></see></summary>
    let ``_/CostPerEnergy`` = _prefix "/CostPerEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:CostPerMass
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerMass"></see></summary>
    let ``_/CostPerMass`` = _prefix "/CostPerMass"
    /// <summary>
    /// Applicable units are those of quantitykind:CostPerPower
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerPower"></see></summary>
    let ``_/CostPerPower`` = _prefix "/CostPerPower"
    /// <summary>
    /// Applicable units are those of quantitykind:CountRate
    /// <see href="http://qudt.org/vocab/quantitykind/CountRate"></see></summary>
    let ``_/CountRate`` = _prefix "/CountRate"
    /// <summary>
    /// Applicable units are those of quantitykind:CouplingFactor
    /// <see href="http://qudt.org/vocab/quantitykind/CouplingFactor"></see></summary>
    let ``_/CouplingFactor`` = _prefix "/CouplingFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/CrossSection"></see></summary>
    let ``_/CrossSection`` = _prefix "/CrossSection"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/CrossSectionalArea"></see></summary>
    let ``_/CrossSectionalArea`` = _prefix "/CrossSectionalArea"

    /// <summary>
    /// Applicable units are those of quantitykind:CubicElectricDipoleMomentPerSquareEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/CubicElectricDipoleMomentPerSquareEnergy"></see></summary>
    let ``_/CubicElectricDipoleMomentPerSquareEnergy`` =
        _prefix "/CubicElectricDipoleMomentPerSquareEnergy"

    /// <summary>
    /// Applicable units are those of quantitykind:ExpansionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/CubicExpansionCoefficient"></see></summary>
    let ``_/CubicExpansionCoefficient`` = _prefix "/CubicExpansionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ExpansionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ExpansionRatio"></see></summary>
    let ``_/ExpansionRatio`` = _prefix "/ExpansionRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/CurieTemperature"></see></summary>
    let ``_/CurieTemperature`` = _prefix "/CurieTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/NeelTemperature"></see></summary>
    let ``_/NeelTemperature`` = _prefix "/NeelTemperature"

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/SuperconductionTransitionTemperature"></see></summary>
    let ``_/SuperconductionTransitionTemperature`` =
        _prefix "/SuperconductionTransitionTemperature"

    /// <summary>
    /// Applicable units are those of quantitykind:Currency
    /// <see href="http://qudt.org/vocab/quantitykind/Currency"></see></summary>
    let ``_/Currency`` = _prefix "/Currency"
    /// <summary>
    /// Applicable units are those of quantitykind:CurrencyPerFlight
    /// <see href="http://qudt.org/vocab/quantitykind/CurrencyPerFlight"></see></summary>
    let ``_/CurrencyPerFlight`` = _prefix "/CurrencyPerFlight"
    /// <summary>
    /// Applicable units are those of quantitykind:CurrentLinkage
    /// <see href="http://qudt.org/vocab/quantitykind/CurrentLinkage"></see></summary>
    let ``_/CurrentLinkage`` = _prefix "/CurrentLinkage"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/CurrentOfTheAmountOfSubstance"></see>
    /// </summary>
    let ``_/CurrentOfTheAmountOfSubstance`` = _prefix "/CurrentOfTheAmountOfSubstance"
    /// <summary>
    /// Applicable units are those of quantitykind:Curvature
    /// <see href="http://qudt.org/vocab/quantitykind/Curvature"></see></summary>
    let ``_/Curvature`` = _prefix "/Curvature"
    /// <summary>
    /// Applicable units are those of quantitykind:CurvatureFromRadius
    /// <see href="http://qudt.org/vocab/quantitykind/CurvatureFromRadius"></see></summary>
    let ``_/CurvatureFromRadius`` = _prefix "/CurvatureFromRadius"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/CutoffCurrentRating"></see>
    /// </summary>
    let ``_/CutoffCurrentRating`` = _prefix "/CutoffCurrentRating"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/CyclotronAngularFrequency"></see></summary>
    let ``_/CyclotronAngularFrequency`` = _prefix "/CyclotronAngularFrequency"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/DELTA-V"></see></summary>
    let ``_/DELTA-V`` = _prefix "/DELTA-V"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/DRY-MASS"></see></summary>
    let ``_/DRY-MASS`` = _prefix "/DRY-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:DataRate
    /// <see href="http://qudt.org/vocab/quantitykind/DataRate"></see></summary>
    let ``_/DataRate`` = _prefix "/DataRate"
    /// <summary>
    /// Applicable units are those of quantitykind:InformationFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/InformationFlowRate"></see></summary>
    let ``_/InformationFlowRate`` = _prefix "/InformationFlowRate"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DataTransmissionRate"></see>
    /// </summary>
    let ``_/DataTransmissionRate`` = _prefix "/DataTransmissionRate"
    /// <summary>
    /// Applicable units are those of quantitykind:DatasetOfBits
    /// <see href="http://qudt.org/vocab/quantitykind/DatasetOfBits"></see></summary>
    let ``_/DatasetOfBits`` = _prefix "/DatasetOfBits"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DatasetOfBytes"></see>
    /// </summary>
    let ``_/DatasetOfBytes`` = _prefix "/DatasetOfBytes"
    /// <summary>
    /// Applicable units are those of quantitykind:Debye-WallerFactor
    /// <see href="http://qudt.org/vocab/quantitykind/Debye-WallerFactor"></see></summary>
    let ``_/Debye-WallerFactor`` = _prefix "/Debye-WallerFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/DebyeAngularFrequency"></see></summary>
    let ``_/DebyeAngularFrequency`` = _prefix "/DebyeAngularFrequency"
    /// <summary>
    /// Applicable units are those of quantitykind:DebyeAngularWavenumber
    /// <see href="http://qudt.org/vocab/quantitykind/DebyeAngularWavenumber"></see></summary>
    let ``_/DebyeAngularWavenumber`` = _prefix "/DebyeAngularWavenumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/DebyeTemperature"></see></summary>
    let ``_/DebyeTemperature`` = _prefix "/DebyeTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:DecayConstant
    /// <see href="http://qudt.org/vocab/quantitykind/DecayConstant"></see></summary>
    let ``_/DecayConstant`` = _prefix "/DecayConstant"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseTime"></see>
    /// </summary>
    let ``_/InverseTime`` = _prefix "/InverseTime"
    /// <summary>
    /// Applicable units are those of quantitykind:DegreeOfDissociation
    /// <see href="http://qudt.org/vocab/quantitykind/DegreeOfDissociation"></see></summary>
    let ``_/DegreeOfDissociation`` = _prefix "/DegreeOfDissociation"
    /// <summary>
    /// Applicable units are those of quantitykind:MassDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MassDensity"></see></summary>
    let ``_/MassDensity`` = _prefix "/MassDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:MassDensity
    /// <see href="http://qudt.org/vocab/quantitykind/DensityInCombustionChamber"></see></summary>
    let ``_/DensityInCombustionChamber`` = _prefix "/DensityInCombustionChamber"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DensityOfStates"></see>
    /// </summary>
    let ``_/DensityOfStates`` = _prefix "/DensityOfStates"
    /// <summary>
    /// Applicable units are those of quantitykind:VibrationalDensityOfStates
    /// <see href="http://qudt.org/vocab/quantitykind/VibrationalDensityOfStates"></see></summary>
    let ``_/VibrationalDensityOfStates`` = _prefix "/VibrationalDensityOfStates"
    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/DensityOfTheExhaustGases"></see></summary>
    let ``_/DensityOfTheExhaustGases`` = _prefix "/DensityOfTheExhaustGases"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Depth"></see></summary>
    let ``_/Depth`` = _prefix "/Depth"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/DewPointTemperature"></see></summary>
    let ``_/DewPointTemperature`` = _prefix "/DewPointTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Diameter"></see></summary>
    let ``_/Diameter`` = _prefix "/Diameter"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/DiastolicBloodPressure"></see></summary>
    let ``_/DiastolicBloodPressure`` = _prefix "/DiastolicBloodPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SystolicBloodPressure"></see></summary>
    let ``_/SystolicBloodPressure`` = _prefix "/SystolicBloodPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionArea"></see></summary>
    let ``_/DiffusionArea`` = _prefix "/DiffusionArea"
    /// <summary>
    /// Applicable units are those of quantitykind:DiffusionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionCoefficient"></see></summary>
    let ``_/DiffusionCoefficient`` = _prefix "/DiffusionCoefficient"

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionCoefficientForFluenceRate"></see></summary>
    let ``_/DiffusionCoefficientForFluenceRate`` =
        _prefix "/DiffusionCoefficientForFluenceRate"

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionLength"></see></summary>
    let ``_/DiffusionLength`` = _prefix "/DiffusionLength"
    /// <summary>
    /// Applicable units are those of quantitykind:DigitRate
    /// <see href="http://qudt.org/vocab/quantitykind/DigitRate"></see></summary>
    let ``_/DigitRate`` = _prefix "/DigitRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Displacement"></see></summary>
    let ``_/Displacement`` = _prefix "/Displacement"
    /// <summary>
    /// Applicable units are those of quantitykind:DisplacementCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/DisplacementCurrent"></see></summary>
    let ``_/DisplacementCurrent`` = _prefix "/DisplacementCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricFluxDensity"></see></summary>
    let ``_/ElectricFluxDensity`` = _prefix "/ElectricFluxDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:DisplacementCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/DisplacementCurrentDensity"></see></summary>
    let ``_/DisplacementCurrentDensity`` = _prefix "/DisplacementCurrentDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/DisplacementVectorOfIon"></see></summary>
    let ``_/DisplacementVectorOfIon`` = _prefix "/DisplacementVectorOfIon"
    /// <summary>
    /// Applicable units are those of quantitykind:Dissipance
    /// <see href="http://qudt.org/vocab/quantitykind/Dissipance"></see></summary>
    let ``_/Dissipance`` = _prefix "/Dissipance"
    /// <summary>
    /// Applicable units are those of quantitykind:Distance
    /// <see href="http://qudt.org/vocab/quantitykind/Distance"></see></summary>
    let ``_/Distance`` = _prefix "/Distance"
    /// <summary>
    /// Applicable units are those of quantitykind:Distance
    /// <see href="http://qudt.org/vocab/quantitykind/DistanceTraveledDuringBurn"></see></summary>
    let ``_/DistanceTraveledDuringBurn`` = _prefix "/DistanceTraveledDuringBurn"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/DonorDensity"></see></summary>
    let ``_/DonorDensity`` = _prefix "/DonorDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:DoseEquivalent
    /// <see href="http://qudt.org/vocab/quantitykind/DoseEquivalent"></see></summary>
    let ``_/DoseEquivalent`` = _prefix "/DoseEquivalent"
    /// <summary>
    /// Applicable units are those of quantitykind:DoseEquivalentQualityFactor
    /// <see href="http://qudt.org/vocab/quantitykind/DoseEquivalentQualityFactor"></see></summary>
    let ``_/DoseEquivalentQualityFactor`` = _prefix "/DoseEquivalentQualityFactor"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DoseEquivalentRate"></see>
    /// </summary>
    let ``_/DoseEquivalentRate`` = _prefix "/DoseEquivalentRate"
    /// <summary>
    /// Applicable units are those of quantitykind:DotsPerInch
    /// <see href="http://qudt.org/vocab/quantitykind/DotsPerInch"></see></summary>
    let ``_/DotsPerInch`` = _prefix "/DotsPerInch"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/DragCoefficient"></see></summary>
    let ``_/DragCoefficient`` = _prefix "/DragCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/DragForce"></see></summary>
    let ``_/DragForce`` = _prefix "/DragForce"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Force"></see></summary>
    let ``_/Force`` = _prefix "/Force"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/DryBulbTemperature"></see></summary>
    let ``_/DryBulbTemperature`` = _prefix "/DryBulbTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:DryVolume
    /// <see href="http://qudt.org/vocab/quantitykind/DryVolume"></see></summary>
    let ``_/DryVolume`` = _prefix "/DryVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:DutyCycle
    /// <see href="http://qudt.org/vocab/quantitykind/DutyCycle"></see></summary>
    let ``_/DutyCycle`` = _prefix "/DutyCycle"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicFriction"></see></summary>
    let ``_/DynamicFriction`` = _prefix "/DynamicFriction"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Friction"></see></summary>
    let ``_/Friction`` = _prefix "/Friction"
    /// <summary>
    /// Applicable units are those of quantitykind:FrictionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicFrictionCoefficient"></see></summary>
    let ``_/DynamicFrictionCoefficient`` = _prefix "/DynamicFrictionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:FrictionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/FrictionCoefficient"></see></summary>
    let ``_/FrictionCoefficient`` = _prefix "/FrictionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicPressure"></see></summary>
    let ``_/DynamicPressure`` = _prefix "/DynamicPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:DynamicViscosity
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicViscosity"></see></summary>
    let ``_/DynamicViscosity`` = _prefix "/DynamicViscosity"
    /// <summary>
    /// Applicable units are those of quantitykind:Viscosity
    /// <see href="http://qudt.org/vocab/quantitykind/Viscosity"></see></summary>
    let ``_/Viscosity`` = _prefix "/Viscosity"

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EarthClosestApproachVehicleVelocity"></see></summary>
    let ``_/EarthClosestApproachVehicleVelocity`` =
        _prefix "/EarthClosestApproachVehicleVelocity"

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/VehicleVelocity"></see></summary>
    let ``_/VehicleVelocity`` = _prefix "/VehicleVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:EarthquakeMagnitude
    /// <see href="http://qudt.org/vocab/quantitykind/EarthquakeMagnitude"></see></summary>
    let ``_/EarthquakeMagnitude`` = _prefix "/EarthquakeMagnitude"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/EccentricityOfOrbit"></see></summary>
    let ``_/EccentricityOfOrbit`` = _prefix "/EccentricityOfOrbit"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EffectiveExhaustVelocity"></see></summary>
    let ``_/EffectiveExhaustVelocity`` = _prefix "/EffectiveExhaustVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/EffectiveMass"></see></summary>
    let ``_/EffectiveMass`` = _prefix "/EffectiveMass"
    /// <summary>
    /// Applicable units are those of quantitykind:MultiplicationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/EffectiveMultiplicationFactor"></see></summary>
    let ``_/EffectiveMultiplicationFactor`` = _prefix "/EffectiveMultiplicationFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:MultiplicationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/MultiplicationFactor"></see></summary>
    let ``_/MultiplicationFactor`` = _prefix "/MultiplicationFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:MultiplicationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/InfiniteMultiplicationFactor"></see></summary>
    let ``_/InfiniteMultiplicationFactor`` = _prefix "/InfiniteMultiplicationFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Efficiency"></see></summary>
    let ``_/Efficiency`` = _prefix "/Efficiency"
    /// <summary>
    /// Applicable units are those of quantitykind:EinsteinCoefficients
    /// <see href="http://qudt.org/vocab/quantitykind/EinsteinCoefficients"></see></summary>
    let ``_/EinsteinCoefficients`` = _prefix "/EinsteinCoefficients"
    /// <summary>
    /// Applicable units are those of quantitykind:EinsteinTransitionProbability
    /// <see href="http://qudt.org/vocab/quantitykind/EinsteinTransitionProbability"></see></summary>
    let ``_/EinsteinTransitionProbability`` = _prefix "/EinsteinTransitionProbability"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption"></see>
    /// </summary>
    let ``_/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption`` =
        _prefix "/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption"

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeDensity"></see></summary>
    let ``_/ElectricChargeDensity`` = _prefix "/ElectricChargeDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeSurfaceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeSurfaceDensity"></see></summary>
    let ``_/ElectricChargeSurfaceDensity`` = _prefix "/ElectricChargeSurfaceDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeLineDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeLineDensity"></see></summary>
    let ``_/ElectricChargeLineDensity`` = _prefix "/ElectricChargeLineDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeLinearDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeLinearDensity"></see></summary>
    let ``_/ElectricChargeLinearDensity`` = _prefix "/ElectricChargeLinearDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargePerAmountOfSubstance"></see></summary>
    let ``_/ElectricChargePerAmountOfSubstance`` =
        _prefix "/ElectricChargePerAmountOfSubstance"

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargePerMass"></see></summary>
    let ``_/ElectricChargePerMass`` = _prefix "/ElectricChargePerMass"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeVolumeDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeVolumeDensity"></see></summary>
    let ``_/ElectricChargeVolumeDensity`` = _prefix "/ElectricChargeVolumeDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricConductivity"></see></summary>
    let ``_/ElectricConductivity`` = _prefix "/ElectricConductivity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerAngle"></see></summary>
    let ``_/ElectricCurrentPerAngle`` = _prefix "/ElectricCurrentPerAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPerEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerEnergy"></see></summary>
    let ``_/ElectricCurrentPerEnergy`` = _prefix "/ElectricCurrentPerEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerLength"></see></summary>
    let ``_/ElectricCurrentPerLength`` = _prefix "/ElectricCurrentPerLength"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearElectricCurrentDensity"></see></summary>
    let ``_/LinearElectricCurrentDensity`` = _prefix "/LinearElectricCurrentDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPerTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerTemperature"></see></summary>
    let ``_/ElectricCurrentPerTemperature`` = _prefix "/ElectricCurrentPerTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricDipoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment"></see></summary>
    let ``_/ElectricDipoleMoment`` = _prefix "/ElectricDipoleMoment"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_CubicPerEnergy_Squared"></see>
    /// </summary>
    let ``_/ElectricDipoleMoment_CubicPerEnergy_Squared`` =
        _prefix "/ElectricDipoleMoment_CubicPerEnergy_Squared"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_QuarticPerEnergy_Cubic"></see>
    /// </summary>
    let ``_/ElectricDipoleMoment_QuarticPerEnergy_Cubic`` =
        _prefix "/ElectricDipoleMoment_QuarticPerEnergy_Cubic"

    /// <summary>
    /// Applicable units are those of quantitykind:QuarticElectricDipoleMomentPerCubicEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/QuarticElectricDipoleMomentPerCubicEnergy"></see></summary>
    let ``_/QuarticElectricDipoleMomentPerCubicEnergy`` =
        _prefix "/QuarticElectricDipoleMomentPerCubicEnergy"

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricDisplacement"></see></summary>
    let ``_/ElectricDisplacement`` = _prefix "/ElectricDisplacement"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricDisplacementField"></see></summary>
    let ``_/ElectricDisplacementField`` = _prefix "/ElectricDisplacementField"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricField
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricField"></see></summary>
    let ``_/ElectricField`` = _prefix "/ElectricField"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricFlux
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricFlux"></see></summary>
    let ``_/ElectricFlux`` = _prefix "/ElectricFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPolarizability
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPolarizability"></see></summary>
    let ``_/ElectricPolarizability`` = _prefix "/ElectricPolarizability"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPolarization
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPolarization"></see></summary>
    let ``_/ElectricPolarization`` = _prefix "/ElectricPolarization"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPotential
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPotential"></see></summary>
    let ``_/ElectricPotential`` = _prefix "/ElectricPotential"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPotentialDifference
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPotentialDifference"></see></summary>
    let ``_/ElectricPotentialDifference`` = _prefix "/ElectricPotentialDifference"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerElectricCharge"></see></summary>
    let ``_/EnergyPerElectricCharge`` = _prefix "/EnergyPerElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/Power"></see></summary>
    let ``_/Power`` = _prefix "/Power"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantMass"></see></summary>
    let ``_/PropellantMass`` = _prefix "/PropellantMass"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricQuadrupoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricQuadrupoleMoment"></see></summary>
    let ``_/ElectricQuadrupoleMoment`` = _prefix "/ElectricQuadrupoleMoment"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricSusceptibility
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricSusceptibility"></see></summary>
    let ``_/ElectricSusceptibility`` = _prefix "/ElectricSusceptibility"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricalConductance
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricalConductance"></see></summary>
    let ``_/ElectricalConductance`` = _prefix "/ElectricalConductance"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificPower
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricalPowerToMassRatio"></see></summary>
    let ``_/ElectricalPowerToMassRatio`` = _prefix "/ElectricalPowerToMassRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificPower
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificPower"></see></summary>
    let ``_/SpecificPower`` = _prefix "/SpecificPower"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricalResistance
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricalResistance"></see></summary>
    let ``_/ElectricalResistance`` = _prefix "/ElectricalResistance"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectrolyticConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectrolyticConductivity"></see></summary>
    let ``_/ElectrolyticConductivity`` = _prefix "/ElectrolyticConductivity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticEnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticEnergyDensity"></see></summary>
    let ``_/ElectromagneticEnergyDensity`` = _prefix "/ElectromagneticEnergyDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumicElectromagneticEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/VolumicElectromagneticEnergy"></see></summary>
    let ``_/VolumicElectromagneticEnergy`` = _prefix "/VolumicElectromagneticEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFluxDensity"></see></summary>
    let ``_/MagneticFluxDensity`` = _prefix "/MagneticFluxDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticPermeability
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticPermeability"></see></summary>
    let ``_/ElectromagneticPermeability`` = _prefix "/ElectromagneticPermeability"
    /// <summary>
    /// Applicable units are those of quantitykind:Permeability
    /// <see href="http://qudt.org/vocab/quantitykind/Permeability"></see></summary>
    let ``_/Permeability`` = _prefix "/Permeability"

    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticPermeabilityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticPermeabilityRatio"></see></summary>
    let ``_/ElectromagneticPermeabilityRatio`` =
        _prefix "/ElectromagneticPermeabilityRatio"

    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticWavePhaseSpeed
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticWavePhaseSpeed"></see></summary>
    let ``_/ElectromagneticWavePhaseSpeed`` = _prefix "/ElectromagneticWavePhaseSpeed"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromotiveForce"></see></summary>
    let ``_/ElectromotiveForce`` = _prefix "/ElectromotiveForce"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronAffinity"></see></summary>
    let ``_/ElectronAffinity`` = _prefix "/ElectronAffinity"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronDensity"></see></summary>
    let ``_/ElectronDensity`` = _prefix "/ElectronDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronMeanFreePath"></see></summary>
    let ``_/ElectronMeanFreePath`` = _prefix "/ElectronMeanFreePath"
    /// <summary>
    /// Applicable units are those of quantitykind:Mobility
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronMobility"></see></summary>
    let ``_/ElectronMobility`` = _prefix "/ElectronMobility"
    /// <summary>
    /// Applicable units are those of quantitykind:Mobility
    /// <see href="http://qudt.org/vocab/quantitykind/Mobility"></see></summary>
    let ``_/Mobility`` = _prefix "/Mobility"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronRadius"></see></summary>
    let ``_/ElectronRadius`` = _prefix "/ElectronRadius"
    /// <summary>
    /// Applicable units are those of quantitykind:ElevationRelativeToNAP
    /// Height measurement relative to the Normaal Amsterdams Peil (NAP) (en: Amsterdam Ordnance System). Being a form of gravity related height
    /// <see href="http://qudt.org/vocab/quantitykind/ElevationRelativeToNAP"></see></summary>
    let ``_/ElevationRelativeToNAP`` = _prefix "/ElevationRelativeToNAP"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EllipticalOrbitApogeeVelocity"></see></summary>
    let ``_/EllipticalOrbitApogeeVelocity`` = _prefix "/EllipticalOrbitApogeeVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EllipticalOrbitPerigeeVelocity"></see></summary>
    let ``_/EllipticalOrbitPerigeeVelocity`` = _prefix "/EllipticalOrbitPerigeeVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Emissivity
    /// <see href="http://qudt.org/vocab/quantitykind/Emissivity"></see></summary>
    let ``_/Emissivity`` = _prefix "/Emissivity"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/Enthalpy"></see></summary>
    let ``_/Enthalpy`` = _prefix "/Enthalpy"
    /// <summary>
    /// Applicable units are those of quantitykind:Entropy
    /// <see href="http://qudt.org/vocab/quantitykind/Entropy"></see></summary>
    let ``_/Entropy`` = _prefix "/Entropy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/GibbsEnergy"></see></summary>
    let ``_/GibbsEnergy`` = _prefix "/GibbsEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/HelmholtzEnergy"></see></summary>
    let ``_/HelmholtzEnergy`` = _prefix "/HelmholtzEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/InternalEnergy"></see></summary>
    let ``_/InternalEnergy`` = _prefix "/InternalEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/Work"></see></summary>
    let ``_/Work`` = _prefix "/Work"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyContent"></see></summary>
    let ``_/EnergyContent`` = _prefix "/EnergyContent"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyDensity"></see></summary>
    let ``_/EnergyDensity`` = _prefix "/EnergyDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensityOfStates
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyDensityOfStates"></see></summary>
    let ``_/EnergyDensityOfStates`` = _prefix "/EnergyDensityOfStates"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EnergyExpenditure"></see>
    /// </summary>
    let ``_/EnergyExpenditure`` = _prefix "/EnergyExpenditure"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyFluence
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyFluence"></see></summary>
    let ``_/EnergyFluence`` = _prefix "/EnergyFluence"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyFluenceRate"></see></summary>
    let ``_/EnergyFluenceRate`` = _prefix "/EnergyFluenceRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyImparted"></see></summary>
    let ``_/EnergyImparted`` = _prefix "/EnergyImparted"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyInternal"></see></summary>
    let ``_/EnergyInternal`` = _prefix "/EnergyInternal"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicEnergy"></see></summary>
    let ``_/ThermodynamicEnergy`` = _prefix "/ThermodynamicEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyKinetic"></see></summary>
    let ``_/EnergyKinetic`` = _prefix "/EnergyKinetic"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyLevel"></see></summary>
    let ``_/EnergyLevel`` = _prefix "/EnergyLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerArea"></see></summary>
    let ``_/EnergyPerArea`` = _prefix "/EnergyPerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerAreaElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerAreaElectricCharge"></see></summary>
    let ``_/EnergyPerAreaElectricCharge`` = _prefix "/EnergyPerAreaElectricCharge"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EnergyPerMagneticFluxDensity_Squared"></see>
    /// </summary>
    let ``_/EnergyPerMagneticFluxDensity_Squared`` =
        _prefix "/EnergyPerMagneticFluxDensity_Squared"

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerSquareMagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerSquareMagneticFluxDensity"></see></summary>
    let ``_/EnergyPerSquareMagneticFluxDensity`` =
        _prefix "/EnergyPerSquareMagneticFluxDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerMassAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerMassAmountOfSubstance"></see></summary>
    let ``_/EnergyPerMassAmountOfSubstance`` = _prefix "/EnergyPerMassAmountOfSubstance"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerTemperature"></see></summary>
    let ``_/EnergyPerTemperature`` = _prefix "/EnergyPerTemperature"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Energy_Squared"></see>
    /// </summary>
    let ``_/Energy_Squared`` = _prefix "/Energy_Squared"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SquareEnergy"></see>
    /// </summary>
    let ``_/SquareEnergy`` = _prefix "/SquareEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:EquilibriumConstant
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstant"></see></summary>
    let ``_/EquilibriumConstant`` = _prefix "/EquilibriumConstant"

    /// <summary>
    /// Applicable units are those of quantitykind:EquilibriumConstant
    /// The unit is unit:MOL-PER-M3 raised to the N where N is the summation of stoichiometric numbers. I don't know what to do with this.
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantOnConcentrationBasis"></see></summary>
    let ``_/EquilibriumConstantOnConcentrationBasis`` =
        _prefix "/EquilibriumConstantOnConcentrationBasis"

    /// <summary>
    /// Applicable units are those of quantitykind:EquilibriumConstant
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantOnPressureBasis"></see></summary>
    let ``_/EquilibriumConstantOnPressureBasis`` =
        _prefix "/EquilibriumConstantOnPressureBasis"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnConcentration"></see>
    /// </summary>
    let ``_/EquilibriumConstantBasedOnConcentration`` =
        _prefix "/EquilibriumConstantBasedOnConcentration"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnPressure"></see>
    /// </summary>
    let ``_/EquilibriumConstantBasedOnPressure`` =
        _prefix "/EquilibriumConstantBasedOnPressure"

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumPositionVectorOfIon"></see></summary>
    let ``_/EquilibriumPositionVectorOfIon`` = _prefix "/EquilibriumPositionVectorOfIon"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EquivalenceDoseOutput"></see>
    /// </summary>
    let ``_/EquivalenceDoseOutput`` = _prefix "/EquivalenceDoseOutput"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/EquivalentAbsorptionArea"></see></summary>
    let ``_/EquivalentAbsorptionArea`` = _prefix "/EquivalentAbsorptionArea"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/EquivalentConcentration"></see></summary>
    let ``_/EquivalentConcentration`` = _prefix "/EquivalentConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/EquivalentDensity"></see></summary>
    let ``_/EquivalentDensity`` = _prefix "/EquivalentDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/Equivalent_Mass"></see></summary>
    let ``_/Equivalent_Mass`` = _prefix "/Equivalent_Mass"
    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/Equivalent_Molar"></see></summary>
    let ``_/Equivalent_Molar`` = _prefix "/Equivalent_Molar"
    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/MolarEquivalent"></see></summary>
    let ``_/MolarEquivalent`` = _prefix "/MolarEquivalent"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EvaporativeHeatTransfer"></see>
    /// </summary>
    let ``_/EvaporativeHeatTransfer`` = _prefix "/EvaporativeHeatTransfer"

    /// <summary>
    /// Applicable units are those of quantitykind:EvaporativeHeatTransferCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/EvaporativeHeatTransferCoefficient"></see></summary>
    let ``_/EvaporativeHeatTransferCoefficient`` =
        _prefix "/EvaporativeHeatTransferCoefficient"

    /// <summary>
    /// Applicable units are those of quantitykind:ExchangeIntegral
    /// <see href="http://qudt.org/vocab/quantitykind/ExchangeIntegral"></see></summary>
    let ``_/ExchangeIntegral`` = _prefix "/ExchangeIntegral"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ExhaustGasMeanMolecularWeight"></see>
    /// </summary>
    let ``_/ExhaustGasMeanMolecularWeight`` = _prefix "/ExhaustGasMeanMolecularWeight"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/ExhaustGasesSpecificHeat"></see></summary>
    let ``_/ExhaustGasesSpecificHeat`` = _prefix "/ExhaustGasesSpecificHeat"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacity"></see></summary>
    let ``_/SpecificHeatCapacity`` = _prefix "/SpecificHeatCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/ExhaustStreamPower"></see></summary>
    let ``_/ExhaustStreamPower`` = _prefix "/ExhaustStreamPower"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/ExitPlaneCrossSectionalArea"></see></summary>
    let ``_/ExitPlaneCrossSectionalArea`` = _prefix "/ExitPlaneCrossSectionalArea"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ExitPlanePressure"></see></summary>
    let ``_/ExitPlanePressure`` = _prefix "/ExitPlanePressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/ExitPlaneTemperature"></see></summary>
    let ``_/ExitPlaneTemperature`` = _prefix "/ExitPlaneTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/Exposure"></see></summary>
    let ``_/Exposure`` = _prefix "/Exposure"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ExposureOfIonizingRadiation"></see>
    /// </summary>
    let ``_/ExposureOfIonizingRadiation`` = _prefix "/ExposureOfIonizingRadiation"
    /// <summary>
    /// Applicable units are those of quantitykind:ExposureRate
    /// <see href="http://qudt.org/vocab/quantitykind/ExposureRate"></see></summary>
    let ``_/ExposureRate`` = _prefix "/ExposureRate"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ExposureRateOfIonizingRadiation"></see>
    /// </summary>
    let ``_/ExposureRateOfIonizingRadiation`` =
        _prefix "/ExposureRateOfIonizingRadiation"

    /// <summary>
    /// Applicable units are those of quantitykind:ExtentOfReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ExtentOfReaction"></see></summary>
    let ``_/ExtentOfReaction`` = _prefix "/ExtentOfReaction"

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS"></see></summary>
    let ``_/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS`` =
        _prefix "/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS"

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/FUEL-BIAS"></see></summary>
    let ``_/FUEL-BIAS`` = _prefix "/FUEL-BIAS"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/FahrenheitTemperature"></see></summary>
    let ``_/FahrenheitTemperature`` = _prefix "/FahrenheitTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/FailureRate"></see></summary>
    let ``_/FailureRate`` = _prefix "/FailureRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/Incidence"></see></summary>
    let ``_/Incidence`` = _prefix "/Incidence"
    /// <summary>
    /// Applicable units are those of quantitykind:FastFissionFactor
    /// <see href="http://qudt.org/vocab/quantitykind/FastFissionFactor"></see></summary>
    let ``_/FastFissionFactor`` = _prefix "/FastFissionFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:FermiAngularWavenumber
    /// <see href="http://qudt.org/vocab/quantitykind/FermiAngularWavenumber"></see></summary>
    let ``_/FermiAngularWavenumber`` = _prefix "/FermiAngularWavenumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/FermiEnergy"></see></summary>
    let ``_/FermiEnergy`` = _prefix "/FermiEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/FermiTemperature"></see></summary>
    let ``_/FermiTemperature`` = _prefix "/FermiTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/FinalOrCurrentVehicleMass"></see></summary>
    let ``_/FinalOrCurrentVehicleMass`` = _prefix "/FinalOrCurrentVehicleMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Volume
    /// <see href="http://qudt.org/vocab/quantitykind/FirstMomentOfArea"></see></summary>
    let ``_/FirstMomentOfArea`` = _prefix "/FirstMomentOfArea"
    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/FirstStageMassRatio"></see></summary>
    let ``_/FirstStageMassRatio`` = _prefix "/FirstStageMassRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/MassRatio"></see></summary>
    let ``_/MassRatio`` = _prefix "/MassRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:FishBiotransformationHalfLife
    /// <see href="http://qudt.org/vocab/quantitykind/FishBiotransformationHalfLife"></see></summary>
    let ``_/FishBiotransformationHalfLife`` = _prefix "/FishBiotransformationHalfLife"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/FissionCoreRadiusToHeightRatio"></see></summary>
    let ``_/FissionCoreRadiusToHeightRatio`` = _prefix "/FissionCoreRadiusToHeightRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/FissionFuelUtilizationFactor"></see></summary>
    let ``_/FissionFuelUtilizationFactor`` = _prefix "/FissionFuelUtilizationFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/FissionMultiplicationFactor"></see></summary>
    let ``_/FissionMultiplicationFactor`` = _prefix "/FissionMultiplicationFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:FlashPoint
    /// <see href="http://qudt.org/vocab/quantitykind/FlashPoint"></see></summary>
    let ``_/FlashPoint`` = _prefix "/FlashPoint"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/FlightPathAngle"></see></summary>
    let ``_/FlightPathAngle`` = _prefix "/FlightPathAngle"

    /// <summary>
    /// Applicable units are those of quantitykind:FloatingPointCalculationCapability
    /// <see href="http://qudt.org/vocab/quantitykind/FloatingPointCalculationCapability"></see></summary>
    let ``_/FloatingPointCalculationCapability`` =
        _prefix "/FloatingPointCalculationCapability"

    /// <summary>
    /// Applicable units are those of quantitykind:Fluidity
    /// <see href="http://qudt.org/vocab/quantitykind/Fluidity"></see></summary>
    let ``_/Fluidity`` = _prefix "/Fluidity"
    /// <summary>
    /// Applicable units are those of quantitykind:Flux
    /// <see href="http://qudt.org/vocab/quantitykind/Flux"></see></summary>
    let ``_/Flux`` = _prefix "/Flux"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ForceConstant"></see>
    /// </summary>
    let ``_/ForceConstant`` = _prefix "/ForceConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/ForceMagnitude"></see></summary>
    let ``_/ForceMagnitude`` = _prefix "/ForceMagnitude"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerAngle"></see></summary>
    let ``_/ForcePerAngle`` = _prefix "/ForcePerAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerArea"></see></summary>
    let ``_/ForcePerArea`` = _prefix "/ForcePerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerAreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerAreaTime"></see></summary>
    let ``_/ForcePerAreaTime`` = _prefix "/ForcePerAreaTime"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerElectricCharge"></see></summary>
    let ``_/ForcePerElectricCharge`` = _prefix "/ForcePerElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerLength"></see></summary>
    let ``_/ForcePerLength`` = _prefix "/ForcePerLength"
    /// <summary>
    /// Applicable units are those of quantitykind:Fugacity
    /// <see href="http://qudt.org/vocab/quantitykind/Fugacity"></see></summary>
    let ``_/Fugacity`` = _prefix "/Fugacity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/FundamentalLatticeVector"></see></summary>
    let ``_/FundamentalLatticeVector`` = _prefix "/FundamentalLatticeVector"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/LatticeVector"></see></summary>
    let ``_/LatticeVector`` = _prefix "/LatticeVector"

    /// <summary>
    /// Applicable units are those of quantitykind:AngularReciprocalLatticeVector
    /// <see href="http://qudt.org/vocab/quantitykind/FundamentalReciprocalLatticeVector"></see></summary>
    let ``_/FundamentalReciprocalLatticeVector`` =
        _prefix "/FundamentalReciprocalLatticeVector"

    /// <summary>
    /// Applicable units are those of quantitykind:GFactorOfNucleus
    /// <see href="http://qudt.org/vocab/quantitykind/GFactorOfNucleus"></see></summary>
    let ``_/GFactorOfNucleus`` = _prefix "/GFactorOfNucleus"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/GROSS-LIFT-OFF-WEIGHT"></see></summary>
    let ``_/GROSS-LIFT-OFF-WEIGHT`` = _prefix "/GROSS-LIFT-OFF-WEIGHT"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Gain"></see></summary>
    let ``_/Gain`` = _prefix "/Gain"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/GapEnergy"></see></summary>
    let ``_/GapEnergy`` = _prefix "/GapEnergy"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/GasLeakRate"></see>
    /// </summary>
    let ``_/GasLeakRate`` = _prefix "/GasLeakRate"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/GaugePressure"></see></summary>
    let ``_/GaugePressure`` = _prefix "/GaugePressure"
    /// <summary>
    /// Applicable units are those of quantitykind:GeneFamilyAbundance
    /// <see href="http://qudt.org/vocab/quantitykind/GeneFamilyAbundance"></see></summary>
    let ``_/GeneFamilyAbundance`` = _prefix "/GeneFamilyAbundance"
    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedCoordinate
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedCoordinate"></see></summary>
    let ``_/GeneralizedCoordinate`` = _prefix "/GeneralizedCoordinate"
    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedForce
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedForce"></see></summary>
    let ``_/GeneralizedForce`` = _prefix "/GeneralizedForce"
    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedMomentum"></see></summary>
    let ``_/GeneralizedMomentum`` = _prefix "/GeneralizedMomentum"
    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedVelocity"></see></summary>
    let ``_/GeneralizedVelocity`` = _prefix "/GeneralizedVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Gradient
    /// <see href="http://qudt.org/vocab/quantitykind/Gradient"></see></summary>
    let ``_/Gradient`` = _prefix "/Gradient"

    /// <summary>
    /// Applicable units are those of quantitykind:CanonicalPartitionFunction
    /// <see href="http://qudt.org/vocab/quantitykind/GrandCanonicalPartitionFunction"></see></summary>
    let ``_/GrandCanonicalPartitionFunction`` =
        _prefix "/GrandCanonicalPartitionFunction"

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/GravitationalAttraction"></see></summary>
    let ``_/GravitationalAttraction`` = _prefix "/GravitationalAttraction"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Gravity_API"></see></summary>
    let ``_/Gravity_API`` = _prefix "/Gravity_API"
    /// <summary>
    /// Applicable units are those of quantitykind:GroupSpeedOfSound
    /// <see href="http://qudt.org/vocab/quantitykind/GroupSpeedOfSound"></see></summary>
    let ``_/GroupSpeedOfSound`` = _prefix "/GroupSpeedOfSound"
    /// <summary>
    /// Applicable units are those of quantitykind:Speed
    /// <see href="http://qudt.org/vocab/quantitykind/SpeedOfSound"></see></summary>
    let ``_/SpeedOfSound`` = _prefix "/SpeedOfSound"
    /// <summary>
    /// Applicable units are those of quantitykind:GrowingDegreeDay
    /// <see href="http://qudt.org/vocab/quantitykind/GrowingDegreeDay"></see></summary>
    let ``_/GrowingDegreeDay`` = _prefix "/GrowingDegreeDay"
    /// <summary>
    /// Applicable units are those of quantitykind:TimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/TimeTemperature"></see></summary>
    let ``_/TimeTemperature`` = _prefix "/TimeTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:TimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/GrowingDegreeDay_Cereal"></see></summary>
    let ``_/GrowingDegreeDay_Cereal`` = _prefix "/GrowingDegreeDay_Cereal"
    /// <summary>
    /// Applicable units are those of quantitykind:GruneisenParameter
    /// <see href="http://qudt.org/vocab/quantitykind/GruneisenParameter"></see></summary>
    let ``_/GruneisenParameter`` = _prefix "/GruneisenParameter"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/GustatoryThreshold"></see>
    /// </summary>
    let ``_/GustatoryThreshold`` = _prefix "/GustatoryThreshold"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/GyromagneticRatio"></see>
    /// </summary>
    let ``_/GyromagneticRatio`` = _prefix "/GyromagneticRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/Half-Life"></see></summary>
    let ``_/Half-Life`` = _prefix "/Half-Life"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Half-ValueThickness"></see></summary>
    let ``_/Half-ValueThickness`` = _prefix "/Half-ValueThickness"
    /// <summary>
    /// Applicable units are those of quantitykind:HallCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/HallCoefficient"></see></summary>
    let ``_/HallCoefficient`` = _prefix "/HallCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:HamiltonFunction
    /// <see href="http://qudt.org/vocab/quantitykind/HamiltonFunction"></see></summary>
    let ``_/HamiltonFunction`` = _prefix "/HamiltonFunction"
    /// <summary>
    /// Applicable units are those of quantitykind:HeartRate
    /// <see href="http://qudt.org/vocab/quantitykind/HeartRate"></see></summary>
    let ``_/HeartRate`` = _prefix "/HeartRate"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/Heat"></see></summary>
    let ``_/Heat`` = _prefix "/Heat"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalEnergy"></see></summary>
    let ``_/ThermalEnergy`` = _prefix "/ThermalEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:HeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/HeatCapacity"></see></summary>
    let ``_/HeatCapacity`` = _prefix "/HeatCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/HeatCapacityRatio"></see></summary>
    let ``_/HeatCapacityRatio`` = _prefix "/HeatCapacityRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/HeatFlowRatePerArea"></see></summary>
    let ``_/HeatFlowRatePerArea`` = _prefix "/HeatFlowRatePerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/HeatFluxDensity"></see></summary>
    let ``_/HeatFluxDensity`` = _prefix "/HeatFluxDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/HeatingValue"></see></summary>
    let ``_/HeatingValue`` = _prefix "/HeatingValue"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Height"></see></summary>
    let ``_/Height`` = _prefix "/Height"
    /// <summary>
    /// Applicable units are those of quantitykind:HenrysLawVolatilityConstant
    /// <see href="http://qudt.org/vocab/quantitykind/HenrysLawVolatilityConstant"></see></summary>
    let ``_/HenrysLawVolatilityConstant`` = _prefix "/HenrysLawVolatilityConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/HoleDensity"></see></summary>
    let ``_/HoleDensity`` = _prefix "/HoleDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/HorizontalVelocity"></see></summary>
    let ``_/HorizontalVelocity`` = _prefix "/HorizontalVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:HydraulicPermeability
    /// <see href="http://qudt.org/vocab/quantitykind/HydraulicPermeability"></see></summary>
    let ``_/HydraulicPermeability`` = _prefix "/HydraulicPermeability"

    /// <summary>
    /// Applicable units are those of quantitykind:HyperfineStructureQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/HyperfineStructureQuantumNumber"></see></summary>
    let ``_/HyperfineStructureQuantumNumber`` =
        _prefix "/HyperfineStructureQuantumNumber"

    /// <summary>
    /// Applicable units are those of quantitykind:QuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/QuantumNumber"></see></summary>
    let ``_/QuantumNumber`` = _prefix "/QuantumNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/INERT-MASS"></see></summary>
    let ``_/INERT-MASS`` = _prefix "/INERT-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/IgnitionIntervalTime"></see></summary>
    let ``_/IgnitionIntervalTime`` = _prefix "/IgnitionIntervalTime"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/Illuminance"></see></summary>
    let ``_/Illuminance`` = _prefix "/Illuminance"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousFluxPerArea"></see></summary>
    let ``_/LuminousFluxPerArea`` = _prefix "/LuminousFluxPerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:Impulse
    /// <see href="http://qudt.org/vocab/quantitykind/Impulse"></see></summary>
    let ``_/Impulse`` = _prefix "/Impulse"
    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/IncidenceProportion"></see></summary>
    let ``_/IncidenceProportion`` = _prefix "/IncidenceProportion"
    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/IncidenceRate"></see></summary>
    let ``_/IncidenceRate`` = _prefix "/IncidenceRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Inductance
    /// <see href="http://qudt.org/vocab/quantitykind/Inductance"></see></summary>
    let ``_/Inductance`` = _prefix "/Inductance"
    /// <summary>
    /// Applicable units are those of quantitykind:Inductance
    /// <see href="http://qudt.org/vocab/quantitykind/MutualInductance"></see></summary>
    let ``_/MutualInductance`` = _prefix "/MutualInductance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InductanceBasedTimeConstant"></see>
    /// </summary>
    let ``_/InductanceBasedTimeConstant`` = _prefix "/InductanceBasedTimeConstant"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContent"></see>
    /// </summary>
    let ``_/InformationContent`` = _prefix "/InformationContent"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase10"></see>
    /// </summary>
    let ``_/InformationContentExpressedAsALogarithmToBase10`` =
        _prefix "/InformationContentExpressedAsALogarithmToBase10"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase2"></see>
    /// </summary>
    let ``_/InformationContentExpressedAsALogarithmToBase2`` =
        _prefix "/InformationContentExpressedAsALogarithmToBase2"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBaseE"></see>
    /// </summary>
    let ``_/InformationContentExpressedAsALogarithmToBaseE`` =
        _prefix "/InformationContentExpressedAsALogarithmToBaseE"

    /// <summary>
    /// Applicable units are those of quantitykind:InformationEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/InformationEntropy"></see></summary>
    let ``_/InformationEntropy`` = _prefix "/InformationEntropy"
    /// <summary>
    /// Applicable units are those of quantitykind:ExpansionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/InitialExpansionRatio"></see></summary>
    let ``_/InitialExpansionRatio`` = _prefix "/InitialExpansionRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/InitialNozzleThroatDiameter"></see></summary>
    let ``_/InitialNozzleThroatDiameter`` = _prefix "/InitialNozzleThroatDiameter"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleThroatDiameter"></see></summary>
    let ``_/NozzleThroatDiameter`` = _prefix "/NozzleThroatDiameter"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/InitialVehicleMass"></see></summary>
    let ``_/InitialVehicleMass`` = _prefix "/InitialVehicleMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/InitialVelocity"></see></summary>
    let ``_/InitialVelocity`` = _prefix "/InitialVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:InternalConversionFactor
    /// <see href="http://qudt.org/vocab/quantitykind/InternalConversionFactor"></see></summary>
    let ``_/InternalConversionFactor`` = _prefix "/InternalConversionFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/IntinsicCarrierDensity"></see></summary>
    let ``_/IntinsicCarrierDensity`` = _prefix "/IntinsicCarrierDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/InverseAmountOfSubstance"></see></summary>
    let ``_/InverseAmountOfSubstance`` = _prefix "/InverseAmountOfSubstance"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/InverseEnergy"></see></summary>
    let ``_/InverseEnergy`` = _prefix "/InverseEnergy"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseEnergy_Squared"></see>
    /// </summary>
    let ``_/InverseEnergy_Squared`` = _prefix "/InverseEnergy_Squared"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseSquareEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/InverseSquareEnergy"></see></summary>
    let ``_/InverseSquareEnergy`` = _prefix "/InverseSquareEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseLengthTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/InverseLengthTemperature"></see></summary>
    let ``_/InverseLengthTemperature`` = _prefix "/InverseLengthTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseMagneticFlux
    /// <see href="http://qudt.org/vocab/quantitykind/InverseMagneticFlux"></see></summary>
    let ``_/InverseMagneticFlux`` = _prefix "/InverseMagneticFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseMass
    /// <see href="http://qudt.org/vocab/quantitykind/InverseMass"></see></summary>
    let ``_/InverseMass`` = _prefix "/InverseMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseMass_Squared"></see>
    /// </summary>
    let ``_/InverseMass_Squared`` = _prefix "/InverseMass_Squared"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseSquareMass
    /// <see href="http://qudt.org/vocab/quantitykind/InverseSquareMass"></see></summary>
    let ``_/InverseSquareMass`` = _prefix "/InverseSquareMass"
    /// <summary>
    /// Applicable units are those of quantitykind:InversePermittivity
    /// <see href="http://qudt.org/vocab/quantitykind/InversePermittivity"></see></summary>
    let ``_/InversePermittivity`` = _prefix "/InversePermittivity"
    /// <summary>
    /// Applicable units are those of quantitykind:InversePressure
    /// <see href="http://qudt.org/vocab/quantitykind/InversePressure"></see></summary>
    let ``_/InversePressure`` = _prefix "/InversePressure"
    /// <summary>
    /// Applicable units are those of quantitykind:IsothermalCompressibility
    /// <see href="http://qudt.org/vocab/quantitykind/IsothermalCompressibility"></see></summary>
    let ``_/IsothermalCompressibility`` = _prefix "/IsothermalCompressibility"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/InverseTemperature"></see></summary>
    let ``_/InverseTemperature`` = _prefix "/InverseTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseTimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/InverseTimeTemperature"></see></summary>
    let ``_/InverseTimeTemperature`` = _prefix "/InverseTimeTemperature"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseTime_Squared"></see>
    /// </summary>
    let ``_/InverseTime_Squared`` = _prefix "/InverseTime_Squared"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseVolume
    /// <see href="http://qudt.org/vocab/quantitykind/IonConcentration"></see></summary>
    let ``_/IonConcentration`` = _prefix "/IonConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/IonDensity"></see></summary>
    let ``_/IonDensity`` = _prefix "/IonDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/IonCurrent"></see></summary>
    let ``_/IonCurrent`` = _prefix "/IonCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:IonTransportNumber
    /// <see href="http://qudt.org/vocab/quantitykind/IonTransportNumber"></see></summary>
    let ``_/IonTransportNumber`` = _prefix "/IonTransportNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/IonicCharge"></see></summary>
    let ``_/IonicCharge`` = _prefix "/IonicCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:IonicStrength
    /// <see href="http://qudt.org/vocab/quantitykind/IonicStrength"></see></summary>
    let ``_/IonicStrength`` = _prefix "/IonicStrength"
    /// <summary>
    /// Applicable units are those of quantitykind:Irradiance
    /// <see href="http://qudt.org/vocab/quantitykind/Irradiance"></see></summary>
    let ``_/Irradiance`` = _prefix "/Irradiance"
    /// <summary>
    /// Applicable units are those of quantitykind:IsentropicCompressibility
    /// <see href="http://qudt.org/vocab/quantitykind/IsentropicCompressibility"></see></summary>
    let ``_/IsentropicCompressibility`` = _prefix "/IsentropicCompressibility"
    /// <summary>
    /// Applicable units are those of quantitykind:IsentropicExponent
    /// <see href="http://qudt.org/vocab/quantitykind/IsentropicExponent"></see></summary>
    let ``_/IsentropicExponent`` = _prefix "/IsentropicExponent"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificVolume
    /// <see href="http://qudt.org/vocab/quantitykind/IsothermalMoistureCapacity"></see></summary>
    let ``_/IsothermalMoistureCapacity`` = _prefix "/IsothermalMoistureCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:Kerma
    /// <see href="http://qudt.org/vocab/quantitykind/Kerma"></see></summary>
    let ``_/Kerma`` = _prefix "/Kerma"
    /// <summary>
    /// Applicable units are those of quantitykind:KermaRate
    /// <see href="http://qudt.org/vocab/quantitykind/KermaRate"></see></summary>
    let ``_/KermaRate`` = _prefix "/KermaRate"
    /// <summary>
    /// Applicable units are those of quantitykind:KinematicViscosity
    /// <see href="http://qudt.org/vocab/quantitykind/KinematicViscosity"></see></summary>
    let ``_/KinematicViscosity`` = _prefix "/KinematicViscosity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolecularViscosity"></see>
    /// </summary>
    let ``_/MolecularViscosity`` = _prefix "/MolecularViscosity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity"></see>
    /// </summary>
    let ``_/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity`` =
        _prefix "/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity"

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/KineticEnergy"></see></summary>
    let ``_/KineticEnergy`` = _prefix "/KineticEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/KineticOrThermalEnergy"></see></summary>
    let ``_/KineticOrThermalEnergy`` = _prefix "/KineticOrThermalEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:LagrangeFunction
    /// <see href="http://qudt.org/vocab/quantitykind/LagrangeFunction"></see></summary>
    let ``_/LagrangeFunction`` = _prefix "/LagrangeFunction"
    /// <summary>
    /// Applicable units are those of quantitykind:Landau-GinzburgNumber
    /// <see href="http://qudt.org/vocab/quantitykind/Landau-GinzburgNumber"></see></summary>
    let ``_/Landau-GinzburgNumber`` = _prefix "/Landau-GinzburgNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:LandeGFactor
    /// <see href="http://qudt.org/vocab/quantitykind/LandeGFactor"></see></summary>
    let ``_/LandeGFactor`` = _prefix "/LandeGFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/LarmorAngularFrequency"></see></summary>
    let ``_/LarmorAngularFrequency`` = _prefix "/LarmorAngularFrequency"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/LatticePlaneSpacing"></see></summary>
    let ``_/LatticePlaneSpacing`` = _prefix "/LatticePlaneSpacing"
    /// <summary>
    /// Applicable units are those of quantitykind:LeakageFactor
    /// <see href="http://qudt.org/vocab/quantitykind/LeakageFactor"></see></summary>
    let ``_/LeakageFactor`` = _prefix "/LeakageFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/LengthByForce"></see></summary>
    let ``_/LengthByForce`` = _prefix "/LengthByForce"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/LengthEnergy"></see></summary>
    let ``_/LengthEnergy`` = _prefix "/LengthEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthMass
    /// <see href="http://qudt.org/vocab/quantitykind/LengthMass"></see></summary>
    let ``_/LengthMass`` = _prefix "/LengthMass"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthMolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/LengthMolarEnergy"></see></summary>
    let ``_/LengthMolarEnergy`` = _prefix "/LengthMolarEnergy"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LengthPerElectricCurrent"></see>
    /// </summary>
    let ``_/LengthPerElectricCurrent`` = _prefix "/LengthPerElectricCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LengthRatio"></see></summary>
    let ``_/LengthRatio`` = _prefix "/LengthRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/LengthTemperature"></see></summary>
    let ``_/LengthTemperature`` = _prefix "/LengthTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthTemperatureTime
    /// <see href="http://qudt.org/vocab/quantitykind/LengthTemperatureTime"></see></summary>
    let ``_/LengthTemperatureTime`` = _prefix "/LengthTemperatureTime"
    /// <summary>
    /// Applicable units are those of quantitykind:Lethargy
    /// <see href="http://qudt.org/vocab/quantitykind/Lethargy"></see></summary>
    let ``_/Lethargy`` = _prefix "/Lethargy"
    /// <summary>
    /// Applicable units are those of quantitykind:LevelWidth
    /// <see href="http://qudt.org/vocab/quantitykind/LevelWidth"></see></summary>
    let ``_/LevelWidth`` = _prefix "/LevelWidth"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/LiftCoefficient"></see></summary>
    let ``_/LiftCoefficient`` = _prefix "/LiftCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/LiftForce"></see></summary>
    let ``_/LiftForce`` = _prefix "/LiftForce"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearAbsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LinearAbsorptionCoefficient"></see></summary>
    let ``_/LinearAbsorptionCoefficient`` = _prefix "/LinearAbsorptionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearAttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LinearAttenuationCoefficient"></see></summary>
    let ``_/LinearAttenuationCoefficient`` = _prefix "/LinearAttenuationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearBitDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearBitDensity"></see></summary>
    let ``_/LinearBitDensity`` = _prefix "/LinearBitDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearCompressibility
    /// <see href="http://qudt.org/vocab/quantitykind/LinearCompressibility"></see></summary>
    let ``_/LinearCompressibility`` = _prefix "/LinearCompressibility"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearDensity"></see></summary>
    let ``_/LinearDensity`` = _prefix "/LinearDensity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LinearElectricCharge"></see>
    /// </summary>
    let ``_/LinearElectricCharge`` = _prefix "/LinearElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearElectricCurrent"></see></summary>
    let ``_/LinearElectricCurrent`` = _prefix "/LinearElectricCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearEnergyTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/LinearEnergyTransfer"></see></summary>
    let ``_/LinearEnergyTransfer`` = _prefix "/LinearEnergyTransfer"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearExpansionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LinearExpansionCoefficient"></see></summary>
    let ``_/LinearExpansionCoefficient`` = _prefix "/LinearExpansionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/LinearForce"></see></summary>
    let ``_/LinearForce`` = _prefix "/LinearForce"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearIonization
    /// <see href="http://qudt.org/vocab/quantitykind/LinearIonization"></see></summary>
    let ``_/LinearIonization`` = _prefix "/LinearIonization"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearLogarithmicRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LinearLogarithmicRatio"></see></summary>
    let ``_/LinearLogarithmicRatio`` = _prefix "/LinearLogarithmicRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearMass
    /// <see href="http://qudt.org/vocab/quantitykind/LinearMass"></see></summary>
    let ``_/LinearMass`` = _prefix "/LinearMass"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/LinearMomentum"></see></summary>
    let ``_/LinearMomentum`` = _prefix "/LinearMomentum"
    /// <summary>
    /// Applicable units are those of quantitykind:Momentum
    /// <see href="http://qudt.org/vocab/quantitykind/Momentum"></see></summary>
    let ``_/Momentum`` = _prefix "/Momentum"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LinearPower"></see>
    /// </summary>
    let ``_/LinearPower`` = _prefix "/LinearPower"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearResistance
    /// <see href="http://qudt.org/vocab/quantitykind/LinearResistance"></see></summary>
    let ``_/LinearResistance`` = _prefix "/LinearResistance"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/LinearStiffness"></see></summary>
    let ``_/LinearStiffness`` = _prefix "/LinearStiffness"
    /// <summary>
    /// Applicable units are those of quantitykind:LengthRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LinearStrain"></see></summary>
    let ``_/LinearStrain`` = _prefix "/LinearStrain"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Strain"></see></summary>
    let ``_/Strain`` = _prefix "/Strain"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearThermalExpansion
    /// <see href="http://qudt.org/vocab/quantitykind/LinearThermalExpansion"></see></summary>
    let ``_/LinearThermalExpansion`` = _prefix "/LinearThermalExpansion"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearTorque
    /// <see href="http://qudt.org/vocab/quantitykind/LinearTorque"></see></summary>
    let ``_/LinearTorque`` = _prefix "/LinearTorque"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearVelocity"></see></summary>
    let ``_/LinearVelocity`` = _prefix "/LinearVelocity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LinearVoltageCoefficient"></see>
    /// </summary>
    let ``_/LinearVoltageCoefficient`` = _prefix "/LinearVoltageCoefficient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicCharge"></see>
    /// </summary>
    let ``_/LineicCharge`` = _prefix "/LineicCharge"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicDataVolume"></see>
    /// </summary>
    let ``_/LineicDataVolume`` = _prefix "/LineicDataVolume"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicLogarithmicRatio"></see>
    /// </summary>
    let ``_/LineicLogarithmicRatio`` = _prefix "/LineicLogarithmicRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicMass"></see>
    /// </summary>
    let ``_/LineicMass`` = _prefix "/LineicMass"
    /// <summary>
    /// Applicable units are those of quantitykind:LineicPower
    /// <see href="http://qudt.org/vocab/quantitykind/LineicPower"></see></summary>
    let ``_/LineicPower`` = _prefix "/LineicPower"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicQuantity"></see>
    /// </summary>
    let ``_/LineicQuantity`` = _prefix "/LineicQuantity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicResistance"></see>
    /// </summary>
    let ``_/LineicResistance`` = _prefix "/LineicResistance"
    /// <summary>
    /// Applicable units are those of quantitykind:LineicResolution
    /// <see href="http://qudt.org/vocab/quantitykind/LineicResolution"></see></summary>
    let ``_/LineicResolution`` = _prefix "/LineicResolution"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicTorque"></see>
    /// </summary>
    let ``_/LineicTorque`` = _prefix "/LineicTorque"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFlux
    /// <see href="http://qudt.org/vocab/quantitykind/LinkedFlux"></see></summary>
    let ``_/LinkedFlux`` = _prefix "/LinkedFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFlux
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFlux"></see></summary>
    let ``_/MagneticFlux`` = _prefix "/MagneticFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:LiquidVolume
    /// <see href="http://qudt.org/vocab/quantitykind/LiquidVolume"></see></summary>
    let ``_/LiquidVolume`` = _prefix "/LiquidVolume"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Log10FrequencyInterval"></see>
    /// </summary>
    let ``_/Log10FrequencyInterval`` = _prefix "/Log10FrequencyInterval"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Log10Ratio"></see>
    /// </summary>
    let ``_/Log10Ratio`` = _prefix "/Log10Ratio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogERatio"></see>
    /// </summary>
    let ``_/LogERatio`` = _prefix "/LogERatio"

    /// <summary>
    /// Applicable units are those of quantitykind:LogOctanolAirPartitionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LogOctanolAirPartitionCoefficient"></see></summary>
    let ``_/LogOctanolAirPartitionCoefficient`` =
        _prefix "/LogOctanolAirPartitionCoefficient"

    /// <summary>
    /// Applicable units are those of quantitykind:LogOctanolWaterPartitionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LogOctanolWaterPartitionCoefficient"></see></summary>
    let ``_/LogOctanolWaterPartitionCoefficient`` =
        _prefix "/LogOctanolWaterPartitionCoefficient"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmRatioToBase10"></see>
    /// </summary>
    let ``_/LogarithmRatioToBase10`` = _prefix "/LogarithmRatioToBase10"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmRatioToBaseE"></see>
    /// </summary>
    let ``_/LogarithmRatioToBaseE`` = _prefix "/LogarithmRatioToBaseE"
    /// <summary>
    /// Applicable units are those of quantitykind:LogarithmicFrequencyInterval
    /// <see href="http://qudt.org/vocab/quantitykind/LogarithmicFrequencyInterval"></see></summary>
    let ``_/LogarithmicFrequencyInterval`` = _prefix "/LogarithmicFrequencyInterval"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicFrequencyIntervalToBase10"></see>
    /// </summary>
    let ``_/LogarithmicFrequencyIntervalToBase10`` =
        _prefix "/LogarithmicFrequencyIntervalToBase10"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase10"></see>
    /// </summary>
    let ``_/LogarithmicMedianInformationFlow_SourceToBase10`` =
        _prefix "/LogarithmicMedianInformationFlow_SourceToBase10"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase2"></see>
    /// </summary>
    let ``_/LogarithmicMedianInformationFlow_SourceToBase2`` =
        _prefix "/LogarithmicMedianInformationFlow_SourceToBase2"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBaseE"></see>
    /// </summary>
    let ``_/LogarithmicMedianInformationFlow_SourceToBaseE`` =
        _prefix "/LogarithmicMedianInformationFlow_SourceToBaseE"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/NaturalLogarithmicMedianInformationFlow"></see>
    /// </summary>
    let ``_/NaturalLogarithmicMedianInformationFlow`` =
        _prefix "/NaturalLogarithmicMedianInformationFlow"

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/LondonPenetrationDepth"></see></summary>
    let ``_/LondonPenetrationDepth`` = _prefix "/LondonPenetrationDepth"
    /// <summary>
    /// Applicable units are those of quantitykind:Long-RangeOrderParameter
    /// <see href="http://qudt.org/vocab/quantitykind/Long-RangeOrderParameter"></see></summary>
    let ``_/Long-RangeOrderParameter`` = _prefix "/Long-RangeOrderParameter"
    /// <summary>
    /// Applicable units are those of quantitykind:LorenzCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LorenzCoefficient"></see></summary>
    let ``_/LorenzCoefficient`` = _prefix "/LorenzCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/LossAngle"></see></summary>
    let ``_/LossAngle`` = _prefix "/LossAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:LossFactor
    /// <see href="http://qudt.org/vocab/quantitykind/LossFactor"></see></summary>
    let ``_/LossFactor`` = _prefix "/LossFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:QualityFactor
    /// <see href="http://qudt.org/vocab/quantitykind/QualityFactor"></see></summary>
    let ``_/QualityFactor`` = _prefix "/QualityFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Reactance
    /// <see href="http://qudt.org/vocab/quantitykind/Reactance"></see></summary>
    let ``_/Reactance`` = _prefix "/Reactance"
    /// <summary>
    /// Applicable units are those of quantitykind:Resistance
    /// <see href="http://qudt.org/vocab/quantitykind/Resistance"></see></summary>
    let ``_/Resistance`` = _prefix "/Resistance"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/Loudness"></see></summary>
    let ``_/Loudness`` = _prefix "/Loudness"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/LoudnessLevel"></see></summary>
    let ``_/LoudnessLevel`` = _prefix "/LoudnessLevel"

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LowerCriticalMagneticFluxDensity"></see></summary>
    let ``_/LowerCriticalMagneticFluxDensity`` =
        _prefix "/LowerCriticalMagneticFluxDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/UpperCriticalMagneticFluxDensity"></see></summary>
    let ``_/UpperCriticalMagneticFluxDensity`` =
        _prefix "/UpperCriticalMagneticFluxDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:Luminance
    /// <see href="http://qudt.org/vocab/quantitykind/Luminance"></see></summary>
    let ``_/Luminance`` = _prefix "/Luminance"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousEfficacy
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousEfficacy"></see></summary>
    let ``_/LuminousEfficacy`` = _prefix "/LuminousEfficacy"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousEmittance"></see></summary>
    let ``_/LuminousEmittance`` = _prefix "/LuminousEmittance"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousEnergy"></see></summary>
    let ``_/LuminousEnergy`` = _prefix "/LuminousEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantEnergy"></see></summary>
    let ``_/RadiantEnergy`` = _prefix "/RadiantEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousExitance"></see></summary>
    let ``_/LuminousExitance`` = _prefix "/LuminousExitance"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousExposure
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousExposure"></see></summary>
    let ``_/LuminousExposure`` = _prefix "/LuminousExposure"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFlux
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousFlux"></see></summary>
    let ``_/LuminousFlux`` = _prefix "/LuminousFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousFluxRatio"></see></summary>
    let ``_/LuminousFluxRatio`` = _prefix "/LuminousFluxRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousIntensity
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousIntensity"></see></summary>
    let ``_/LuminousIntensity`` = _prefix "/LuminousIntensity"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousIntensityDistribution
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousIntensityDistribution"></see></summary>
    let ``_/LuminousIntensityDistribution`` = _prefix "/LuminousIntensityDistribution"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-DELIVERED"></see></summary>
    let ``_/MASS-DELIVERED`` = _prefix "/MASS-DELIVERED"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-GROWTH-ALLOWANCE"></see></summary>
    let ``_/MASS-GROWTH-ALLOWANCE`` = _prefix "/MASS-GROWTH-ALLOWANCE"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-MARGIN"></see></summary>
    let ``_/MASS-MARGIN`` = _prefix "/MASS-MARGIN"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-PROPERTY-UNCERTAINTY"></see></summary>
    let ``_/MASS-PROPERTY-UNCERTAINTY`` = _prefix "/MASS-PROPERTY-UNCERTAINTY"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Y"></see></summary>
    let ``_/MOMENT-OF-INERTIA_Y`` = _prefix "/MOMENT-OF-INERTIA_Y"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfInertia_Y"></see></summary>
    let ``_/MomentOfInertia_Y`` = _prefix "/MomentOfInertia_Y"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfInertia"></see></summary>
    let ``_/MomentOfInertia`` = _prefix "/MomentOfInertia"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Z"></see></summary>
    let ``_/MOMENT-OF-INERTIA_Z`` = _prefix "/MOMENT-OF-INERTIA_Z"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfInertia_Z"></see></summary>
    let ``_/MomentOfInertia_Z`` = _prefix "/MomentOfInertia_Z"
    /// <summary>
    /// Applicable units are those of quantitykind:MachNumber
    /// <see href="http://qudt.org/vocab/quantitykind/MachNumber"></see></summary>
    let ``_/MachNumber`` = _prefix "/MachNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/MacroscopicCrossSection"></see></summary>
    let ``_/MacroscopicCrossSection`` = _prefix "/MacroscopicCrossSection"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/MacroscopicTotalCrossSection"></see></summary>
    let ``_/MacroscopicTotalCrossSection`` = _prefix "/MacroscopicTotalCrossSection"
    /// <summary>
    /// Applicable units are those of quantitykind:MadelungConstant
    /// <see href="http://qudt.org/vocab/quantitykind/MadelungConstant"></see></summary>
    let ``_/MadelungConstant`` = _prefix "/MadelungConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticAreaMoment
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticAreaMoment"></see></summary>
    let ``_/MagneticAreaMoment`` = _prefix "/MagneticAreaMoment"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticMoment
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticMoment"></see></summary>
    let ``_/MagneticMoment`` = _prefix "/MagneticMoment"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticDipoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticDipoleMoment"></see></summary>
    let ``_/MagneticDipoleMoment`` = _prefix "/MagneticDipoleMoment"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MagneticDipoleMomentOfAMolecule"></see>
    /// </summary>
    let ``_/MagneticDipoleMomentOfAMolecule`` =
        _prefix "/MagneticDipoleMomentOfAMolecule"

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticField
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticField"></see></summary>
    let ``_/MagneticField`` = _prefix "/MagneticField"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFieldStrength_H"></see></summary>
    let ``_/MagneticFieldStrength_H`` = _prefix "/MagneticFieldStrength_H"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MagneticFluxDensityOrMagneticPolarization"></see>
    /// </summary>
    let ``_/MagneticFluxDensityOrMagneticPolarization`` =
        _prefix "/MagneticFluxDensityOrMagneticPolarization"

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFluxPerLength"></see></summary>
    let ``_/MagneticFluxPerLength`` = _prefix "/MagneticFluxPerLength"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MagneticPolarization"></see>
    /// </summary>
    let ``_/MagneticPolarization`` = _prefix "/MagneticPolarization"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/Magnetization"></see></summary>
    let ``_/Magnetization`` = _prefix "/Magnetization"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticQuantumNumber"></see></summary>
    let ``_/MagneticQuantumNumber`` = _prefix "/MagneticQuantumNumber"

    /// <summary>
    /// Applicable units are those of quantitykind:OrbitalAngularMomentumQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumQuantumNumber"></see></summary>
    let ``_/OrbitalAngularMomentumQuantumNumber`` =
        _prefix "/OrbitalAngularMomentumQuantumNumber"

    /// <summary>
    /// Applicable units are those of quantitykind:PrincipalQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/PrincipalQuantumNumber"></see></summary>
    let ``_/PrincipalQuantumNumber`` = _prefix "/PrincipalQuantumNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:SpinQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/SpinQuantumNumber"></see></summary>
    let ``_/SpinQuantumNumber`` = _prefix "/SpinQuantumNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticReluctivity
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticReluctivity"></see></summary>
    let ``_/MagneticReluctivity`` = _prefix "/MagneticReluctivity"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticSusceptability
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticSusceptability"></see></summary>
    let ``_/MagneticSusceptability`` = _prefix "/MagneticSusceptability"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticTension
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticTension"></see></summary>
    let ``_/MagneticTension`` = _prefix "/MagneticTension"
    /// <summary>
    /// Applicable units are those of quantitykind:MagneticVectorPotential
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticVectorPotential"></see></summary>
    let ``_/MagneticVectorPotential`` = _prefix "/MagneticVectorPotential"
    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MagnetizationField"></see></summary>
    let ``_/MagnetizationField`` = _prefix "/MagnetizationField"
    /// <summary>
    /// Applicable units are those of quantitykind:MagnetomotiveForce
    /// <see href="http://qudt.org/vocab/quantitykind/MagnetomotiveForce"></see></summary>
    let ``_/MagnetomotiveForce`` = _prefix "/MagnetomotiveForce"
    /// <summary>
    /// Applicable units are those of quantitykind:MassAbsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MassAbsorptionCoefficient"></see></summary>
    let ``_/MassAbsorptionCoefficient`` = _prefix "/MassAbsorptionCoefficient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassAmountOfSubstance"></see>
    /// </summary>
    let ``_/MassAmountOfSubstance`` = _prefix "/MassAmountOfSubstance"

    /// <summary>
    /// Applicable units are those of quantitykind:MassAmountOfSubstanceTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/MassAmountOfSubstanceTemperature"></see></summary>
    let ``_/MassAmountOfSubstanceTemperature`` =
        _prefix "/MassAmountOfSubstanceTemperature"

    /// <summary>
    /// Applicable units are those of quantitykind:MassAttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MassAttenuationCoefficient"></see></summary>
    let ``_/MassAttenuationCoefficient`` = _prefix "/MassAttenuationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentration
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentration"></see></summary>
    let ``_/MassConcentration`` = _prefix "/MassConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentrationOfWater
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentrationOfWater"></see></summary>
    let ``_/MassConcentrationOfWater`` = _prefix "/MassConcentrationOfWater"
    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentrationOfWaterVapour
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentrationOfWaterVapour"></see></summary>
    let ``_/MassConcentrationOfWaterVapour`` = _prefix "/MassConcentrationOfWaterVapour"
    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentrationRateOfChange
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentrationRateOfChange"></see></summary>
    let ``_/MassConcentrationRateOfChange`` = _prefix "/MassConcentrationRateOfChange"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassDefect"></see></summary>
    let ``_/MassDefect`` = _prefix "/MassDefect"
    /// <summary>
    /// Applicable units are those of quantitykind:MassEnergyTransferCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MassEnergyTransferCoefficient"></see></summary>
    let ``_/MassEnergyTransferCoefficient`` = _prefix "/MassEnergyTransferCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassExcess"></see></summary>
    let ``_/MassExcess`` = _prefix "/MassExcess"
    /// <summary>
    /// Applicable units are those of quantitykind:MassFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/MassFlowRate"></see></summary>
    let ``_/MassFlowRate`` = _prefix "/MassFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerAreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/MassFluxDensity"></see></summary>
    let ``_/MassFluxDensity`` = _prefix "/MassFluxDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:MassFraction
    /// <see href="http://qudt.org/vocab/quantitykind/MassFraction"></see></summary>
    let ``_/MassFraction`` = _prefix "/MassFraction"
    /// <summary>
    /// Applicable units are those of quantitykind:MassFractionOfDryMatter
    /// <see href="http://qudt.org/vocab/quantitykind/MassFractionOfDryMatter"></see></summary>
    let ``_/MassFractionOfDryMatter`` = _prefix "/MassFractionOfDryMatter"
    /// <summary>
    /// Applicable units are those of quantitykind:MassFractionOfWater
    /// <see href="http://qudt.org/vocab/quantitykind/MassFractionOfWater"></see></summary>
    let ``_/MassFractionOfWater`` = _prefix "/MassFractionOfWater"
    /// <summary>
    /// Applicable units are those of quantitykind:MassNumber
    /// <see href="http://qudt.org/vocab/quantitykind/MassNumber"></see></summary>
    let ``_/MassNumber`` = _prefix "/MassNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassOfElectricalPowerSupply"></see></summary>
    let ``_/MassOfElectricalPowerSupply`` = _prefix "/MassOfElectricalPowerSupply"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassOfSolidBooster"></see></summary>
    let ``_/MassOfSolidBooster`` = _prefix "/MassOfSolidBooster"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassOfTheEarth"></see></summary>
    let ``_/MassOfTheEarth`` = _prefix "/MassOfTheEarth"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerElectricCharge"></see></summary>
    let ``_/MassPerElectricCharge`` = _prefix "/MassPerElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerEnergy"></see></summary>
    let ``_/MassPerEnergy`` = _prefix "/MassPerEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerLength"></see></summary>
    let ``_/MassPerLength`` = _prefix "/MassPerLength"
    /// <summary>
    /// Applicable units are those of quantitykind:MassPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerTime"></see></summary>
    let ``_/MassPerTime`` = _prefix "/MassPerTime"
    /// <summary>
    /// Applicable units are those of quantitykind:MassRatioOfWaterToDryMatter
    /// <see href="http://qudt.org/vocab/quantitykind/MassRatioOfWaterToDryMatter"></see></summary>
    let ``_/MassRatioOfWaterToDryMatter`` = _prefix "/MassRatioOfWaterToDryMatter"
    /// <summary>
    /// Applicable units are those of quantitykind:MassRatioOfWaterVapourToDryGas
    /// <see href="http://qudt.org/vocab/quantitykind/MassRatioOfWaterVapourToDryGas"></see></summary>
    let ``_/MassRatioOfWaterVapourToDryGas`` = _prefix "/MassRatioOfWaterVapourToDryGas"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassRelatedElectricalCurrent"></see>
    /// </summary>
    let ``_/MassRelatedElectricalCurrent`` = _prefix "/MassRelatedElectricalCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:MassSpecificBiogeochemicalRate
    /// <see href="http://qudt.org/vocab/quantitykind/MassSpecificBiogeochemicalRate"></see></summary>
    let ``_/MassSpecificBiogeochemicalRate`` = _prefix "/MassSpecificBiogeochemicalRate"
    /// <summary>
    /// Applicable units are those of quantitykind:MassStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/MassStoppingPower"></see></summary>
    let ``_/MassStoppingPower`` = _prefix "/MassStoppingPower"
    /// <summary>
    /// Applicable units are those of quantitykind:MassTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/MassTemperature"></see></summary>
    let ``_/MassTemperature`` = _prefix "/MassTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:MassicElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/MassicElectricCurrent"></see></summary>
    let ``_/MassicElectricCurrent`` = _prefix "/MassicElectricCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:MassicHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/MassicHeatCapacity"></see></summary>
    let ``_/MassicHeatCapacity`` = _prefix "/MassicHeatCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificPower
    /// <see href="http://qudt.org/vocab/quantitykind/MassicPower"></see></summary>
    let ``_/MassicPower`` = _prefix "/MassicPower"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassicTorque"></see>
    /// </summary>
    let ``_/MassicTorque`` = _prefix "/MassicTorque"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassieuFunction"></see>
    /// </summary>
    let ``_/MassieuFunction`` = _prefix "/MassieuFunction"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PlanckFunction"></see>
    /// </summary>
    let ``_/PlanckFunction`` = _prefix "/PlanckFunction"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEnthalpy"></see></summary>
    let ``_/SpecificEnthalpy`` = _prefix "/SpecificEnthalpy"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificGibbsEnergy"></see></summary>
    let ``_/SpecificGibbsEnergy`` = _prefix "/SpecificGibbsEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHelmholtzEnergy"></see></summary>
    let ``_/SpecificHelmholtzEnergy`` = _prefix "/SpecificHelmholtzEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificInternalEnergy"></see></summary>
    let ``_/SpecificInternalEnergy`` = _prefix "/SpecificInternalEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/MaxExpectedOperatingThrust"></see></summary>
    let ``_/MaxExpectedOperatingThrust`` = _prefix "/MaxExpectedOperatingThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/MaxOperatingThrust"></see></summary>
    let ``_/MaxOperatingThrust`` = _prefix "/MaxOperatingThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Thrust"></see></summary>
    let ``_/Thrust`` = _prefix "/Thrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// Max Sea Level thrust (Mlbf)
    /// <see href="http://qudt.org/vocab/quantitykind/MaxSeaLevelThrust"></see></summary>
    let ``_/MaxSeaLevelThrust`` = _prefix "/MaxSeaLevelThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/MaximumBeta-ParticleEnergy"></see></summary>
    let ``_/MaximumBeta-ParticleEnergy`` = _prefix "/MaximumBeta-ParticleEnergy"

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MaximumExpectedOperatingPressure"></see></summary>
    let ``_/MaximumExpectedOperatingPressure`` =
        _prefix "/MaximumExpectedOperatingPressure"

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MaximumOperatingPressure"></see></summary>
    let ``_/MaximumOperatingPressure`` = _prefix "/MaximumOperatingPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/MeanEnergyImparted"></see></summary>
    let ``_/MeanEnergyImparted`` = _prefix "/MeanEnergyImparted"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/MeanFreePath"></see></summary>
    let ``_/MeanFreePath`` = _prefix "/MeanFreePath"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/MeanLifetime"></see></summary>
    let ``_/MeanLifetime`` = _prefix "/MeanLifetime"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/MeanLinearRange"></see></summary>
    let ``_/MeanLinearRange`` = _prefix "/MeanLinearRange"
    /// <summary>
    /// Applicable units are those of quantitykind:MeanMassRange
    /// <see href="http://qudt.org/vocab/quantitykind/MeanMassRange"></see></summary>
    let ``_/MeanMassRange`` = _prefix "/MeanMassRange"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalEnergy"></see></summary>
    let ``_/MechanicalEnergy`` = _prefix "/MechanicalEnergy"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MechanicalImpedance"></see>
    /// </summary>
    let ``_/MechanicalImpedance`` = _prefix "/MechanicalImpedance"
    /// <summary>
    /// Applicable units are those of quantitykind:MechanicalMobility
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalMobility"></see></summary>
    let ``_/MechanicalMobility`` = _prefix "/MechanicalMobility"
    /// <summary>
    /// There are various interpretations of MechanicalSurfaceImpedance: Pressure/Velocity - https://apps.dtic.mil/sti/pdfs/ADA315595.pdf, Force / Speed - https://www.wikidata.org/wiki/Q6421317, and (Pressure / Velocity)**0.5 - https://www.sciencedirect.com/topics/engineering/mechanical-impedance. We are seeking a resolution to these differences.
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalSurfaceImpedance"></see></summary>
    let ``_/MechanicalSurfaceImpedance`` = _prefix "/MechanicalSurfaceImpedance"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalTension"></see></summary>
    let ``_/MechanicalTension`` = _prefix "/MechanicalTension"
    /// <summary>
    /// Applicable units are those of quantitykind:MeltingPoint
    /// <see href="http://qudt.org/vocab/quantitykind/MeltingPoint"></see></summary>
    let ``_/MeltingPoint`` = _prefix "/MeltingPoint"

    /// <summary>
    /// Applicable units are those of quantitykind:CanonicalPartitionFunction
    /// <see href="http://qudt.org/vocab/quantitykind/MicroCanonicalPartitionFunction"></see></summary>
    let ``_/MicroCanonicalPartitionFunction`` =
        _prefix "/MicroCanonicalPartitionFunction"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MicrobialFormation"></see>
    /// </summary>
    let ``_/MicrobialFormation`` = _prefix "/MicrobialFormation"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/MigrationArea"></see></summary>
    let ``_/MigrationArea`` = _prefix "/MigrationArea"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/MigrationLength"></see></summary>
    let ``_/MigrationLength`` = _prefix "/MigrationLength"
    /// <summary>
    /// Applicable units are those of quantitykind:MobilityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/MobilityRatio"></see></summary>
    let ``_/MobilityRatio`` = _prefix "/MobilityRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ModulusOfAdmittance"></see>
    /// </summary>
    let ``_/ModulusOfAdmittance`` = _prefix "/ModulusOfAdmittance"
    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfElasticity
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfElasticity"></see></summary>
    let ``_/ModulusOfElasticity`` = _prefix "/ModulusOfElasticity"
    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfImpedance"></see></summary>
    let ``_/ModulusOfImpedance`` = _prefix "/ModulusOfImpedance"

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfLinearSubgradeReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfLinearSubgradeReaction"></see></summary>
    let ``_/ModulusOfLinearSubgradeReaction`` =
        _prefix "/ModulusOfLinearSubgradeReaction"

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfRotationalSubgradeReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfRotationalSubgradeReaction"></see></summary>
    let ``_/ModulusOfRotationalSubgradeReaction`` =
        _prefix "/ModulusOfRotationalSubgradeReaction"

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfSubgradeReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfSubgradeReaction"></see></summary>
    let ``_/ModulusOfSubgradeReaction`` = _prefix "/ModulusOfSubgradeReaction"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/MoistureDiffusivity"></see></summary>
    let ``_/MoistureDiffusivity`` = _prefix "/MoistureDiffusivity"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeFlowRate"></see></summary>
    let ``_/VolumeFlowRate`` = _prefix "/VolumeFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:MolalityOfSolute
    /// <see href="http://qudt.org/vocab/quantitykind/MolalityOfSolute"></see></summary>
    let ``_/MolalityOfSolute`` = _prefix "/MolalityOfSolute"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarAbsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MolarAbsorptionCoefficient"></see></summary>
    let ``_/MolarAbsorptionCoefficient`` = _prefix "/MolarAbsorptionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarAngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/MolarAngularMomentum"></see></summary>
    let ``_/MolarAngularMomentum`` = _prefix "/MolarAngularMomentum"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarConductivity"></see></summary>
    let ``_/MolarConductivity`` = _prefix "/MolarConductivity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarDensity"></see>
    /// </summary>
    let ``_/MolarDensity`` = _prefix "/MolarDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarEntropy"></see></summary>
    let ``_/MolarEntropy`` = _prefix "/MolarEntropy"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/MolarFlowRate"></see></summary>
    let ``_/MolarFlowRate`` = _prefix "/MolarFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarFluxDensity"></see></summary>
    let ``_/MolarFluxDensity`` = _prefix "/MolarFluxDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarFluxDensityVariance
    /// <see href="http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance"></see></summary>
    let ``_/MolarFluxDensityVariance`` = _prefix "/MolarFluxDensityVariance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance_NEON"></see>
    /// </summary>
    let ``_/MolarFluxDensityVariance_NEON`` = _prefix "/MolarFluxDensityVariance_NEON"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarHeatCapacity"></see></summary>
    let ``_/MolarHeatCapacity`` = _prefix "/MolarHeatCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarInternalEnergy"></see></summary>
    let ``_/MolarInternalEnergy`` = _prefix "/MolarInternalEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarMass
    /// <see href="http://qudt.org/vocab/quantitykind/MolarMass"></see></summary>
    let ``_/MolarMass`` = _prefix "/MolarMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarOpticalRotationalAbility"></see>
    /// </summary>
    let ``_/MolarOpticalRotationalAbility`` = _prefix "/MolarOpticalRotationalAbility"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarOpticalRotatoryPower
    /// <see href="http://qudt.org/vocab/quantitykind/MolarOpticalRotatoryPower"></see></summary>
    let ``_/MolarOpticalRotatoryPower`` = _prefix "/MolarOpticalRotatoryPower"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarRefractivity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarRefractivity"></see></summary>
    let ``_/MolarRefractivity`` = _prefix "/MolarRefractivity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarThermalCapacity"></see>
    /// </summary>
    let ``_/MolarThermalCapacity`` = _prefix "/MolarThermalCapacity"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarThermodynamicEnergy"></see></summary>
    let ``_/MolarThermodynamicEnergy`` = _prefix "/MolarThermodynamicEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarVolume
    /// <see href="http://qudt.org/vocab/quantitykind/MolarVolume"></see></summary>
    let ``_/MolarVolume`` = _prefix "/MolarVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/MoleFraction"></see></summary>
    let ``_/MoleFraction`` = _prefix "/MoleFraction"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MolecularConcentration"></see></summary>
    let ``_/MolecularConcentration`` = _prefix "/MolecularConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:MolecularMass
    /// <see href="http://qudt.org/vocab/quantitykind/MolecularMass"></see></summary>
    let ``_/MolecularMass`` = _prefix "/MolecularMass"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfForce
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfForce"></see></summary>
    let ``_/MomentOfForce`` = _prefix "/MomentOfForce"
    /// <summary>
    /// Applicable units are those of quantitykind:RotationalMass
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalMass"></see></summary>
    let ``_/RotationalMass`` = _prefix "/RotationalMass"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentumPerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/MomentumPerAngle"></see></summary>
    let ``_/MomentumPerAngle`` = _prefix "/MomentumPerAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:MorbidityRate
    /// <see href="http://qudt.org/vocab/quantitykind/MorbidityRate"></see></summary>
    let ``_/MorbidityRate`` = _prefix "/MorbidityRate"
    /// <summary>
    /// Applicable units are those of quantitykind:MortalityRate
    /// <see href="http://qudt.org/vocab/quantitykind/MortalityRate"></see></summary>
    let ``_/MortalityRate`` = _prefix "/MortalityRate"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MotorConstant"></see>
    /// </summary>
    let ``_/MotorConstant`` = _prefix "/MotorConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/NOMINAL-ASCENT-PROPELLANT-MASS"></see></summary>
    let ``_/NOMINAL-ASCENT-PROPELLANT-MASS`` = _prefix "/NOMINAL-ASCENT-PROPELLANT-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:NapierianAbsorbance
    /// <see href="http://qudt.org/vocab/quantitykind/NapierianAbsorbance"></see></summary>
    let ``_/NapierianAbsorbance`` = _prefix "/NapierianAbsorbance"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/NeutralRatio"></see></summary>
    let ``_/NeutralRatio`` = _prefix "/NeutralRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:NeutronDiffusionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronDiffusionCoefficient"></see></summary>
    let ``_/NeutronDiffusionCoefficient`` = _prefix "/NeutronDiffusionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronDiffusionLength"></see></summary>
    let ``_/NeutronDiffusionLength`` = _prefix "/NeutronDiffusionLength"
    /// <summary>
    /// Applicable units are those of quantitykind:NeutronNumber
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronNumber"></see></summary>
    let ``_/NeutronNumber`` = _prefix "/NeutronNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:NeutronYieldPerAbsorption
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronYieldPerAbsorption"></see></summary>
    let ``_/NeutronYieldPerAbsorption`` = _prefix "/NeutronYieldPerAbsorption"
    /// <summary>
    /// Applicable units are those of quantitykind:NeutronYieldPerFission
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronYieldPerFission"></see></summary>
    let ``_/NeutronYieldPerFission`` = _prefix "/NeutronYieldPerFission"
    /// <summary>
    /// Applicable units are those of quantitykind:Non-LeakageProbability
    /// <see href="http://qudt.org/vocab/quantitykind/Non-LeakageProbability"></see></summary>
    let ``_/Non-LeakageProbability`` = _prefix "/Non-LeakageProbability"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/NonActivePower"></see>
    /// </summary>
    let ``_/NonActivePower`` = _prefix "/NonActivePower"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NonNegativeLength"></see></summary>
    let ``_/NonNegativeLength`` = _prefix "/NonNegativeLength"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/NormalStress"></see></summary>
    let ``_/NormalStress`` = _prefix "/NormalStress"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/Stress"></see></summary>
    let ``_/Stress`` = _prefix "/Stress"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/NormalizedDimensionlessRatio"></see></summary>
    let ``_/NormalizedDimensionlessRatio`` = _prefix "/NormalizedDimensionlessRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleThroatCrossSectionalArea"></see></summary>
    let ``_/NozzleThroatCrossSectionalArea`` = _prefix "/NozzleThroatCrossSectionalArea"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleThroatPressure"></see></summary>
    let ``_/NozzleThroatPressure`` = _prefix "/NozzleThroatPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleWallsThrustReaction"></see></summary>
    let ``_/NozzleWallsThrustReaction`` = _prefix "/NozzleWallsThrustReaction"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearEnergy"></see></summary>
    let ``_/NuclearEnergy`` = _prefix "/NuclearEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:NuclearQuadrupoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearQuadrupoleMoment"></see></summary>
    let ``_/NuclearQuadrupoleMoment`` = _prefix "/NuclearQuadrupoleMoment"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearRadius"></see></summary>
    let ``_/NuclearRadius`` = _prefix "/NuclearRadius"
    /// <summary>
    /// Applicable units are those of quantitykind:NuclearSpinQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearSpinQuantumNumber"></see></summary>
    let ``_/NuclearSpinQuantumNumber`` = _prefix "/NuclearSpinQuantumNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:NucleonNumber
    /// <see href="http://qudt.org/vocab/quantitykind/NucleonNumber"></see></summary>
    let ``_/NucleonNumber`` = _prefix "/NucleonNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberOfElectricalPhases
    /// <see href="http://qudt.org/vocab/quantitykind/NumberOfElectricalPhases"></see></summary>
    let ``_/NumberOfElectricalPhases`` = _prefix "/NumberOfElectricalPhases"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberOfParticles
    /// <see href="http://qudt.org/vocab/quantitykind/NumberOfParticles"></see></summary>
    let ``_/NumberOfParticles`` = _prefix "/NumberOfParticles"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/OlfactoryThreshold"></see></summary>
    let ``_/OlfactoryThreshold`` = _prefix "/OlfactoryThreshold"
    /// <summary>
    /// Applicable units are those of quantitykind:OpeningRatio
    /// <see href="http://qudt.org/vocab/quantitykind/OpeningRatio"></see></summary>
    let ``_/OpeningRatio`` = _prefix "/OpeningRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumPerMass"></see>
    /// </summary>
    let ``_/OrbitalAngularMomentumPerMass`` = _prefix "/OrbitalAngularMomentumPerMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/OrbitalRadialDistance"></see></summary>
    let ``_/OrbitalRadialDistance`` = _prefix "/OrbitalRadialDistance"
    /// <summary>
    /// Applicable units are those of quantitykind:OrderOfReflection
    /// <see href="http://qudt.org/vocab/quantitykind/OrderOfReflection"></see></summary>
    let ``_/OrderOfReflection`` = _prefix "/OrderOfReflection"
    /// <summary>
    /// Applicable units are those of quantitykind:OsmoticCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/OsmoticCoefficient"></see></summary>
    let ``_/OsmoticCoefficient`` = _prefix "/OsmoticCoefficient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/OsmoticConcentration"></see>
    /// </summary>
    let ``_/OsmoticConcentration`` = _prefix "/OsmoticConcentration"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/OsmoticPressure"></see></summary>
    let ``_/OsmoticPressure`` = _prefix "/OsmoticPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/OverRangeDistance"></see></summary>
    let ``_/OverRangeDistance`` = _prefix "/OverRangeDistance"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/PREDICTED-MASS"></see></summary>
    let ``_/PREDICTED-MASS`` = _prefix "/PREDICTED-MASS"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA`` = _prefix "/PRODUCT-OF-INERTIA"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_X"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA_X`` = _prefix "/PRODUCT-OF-INERTIA_X"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ProductOfInertia_X"></see>
    /// </summary>
    let ``_/ProductOfInertia_X`` = _prefix "/ProductOfInertia_X"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Y"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA_Y`` = _prefix "/PRODUCT-OF-INERTIA_Y"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ProductOfInertia_Y"></see>
    /// </summary>
    let ``_/ProductOfInertia_Y`` = _prefix "/ProductOfInertia_Y"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Z"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA_Z`` = _prefix "/PRODUCT-OF-INERTIA_Z"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ProductOfInertia_Z"></see>
    /// </summary>
    let ``_/ProductOfInertia_Z`` = _prefix "/ProductOfInertia_Z"
    /// <summary>
    /// Applicable units are those of quantitykind:Pace
    /// <see href="http://qudt.org/vocab/quantitykind/Pace"></see></summary>
    let ``_/Pace`` = _prefix "/Pace"
    /// <summary>
    /// Applicable units are those of quantitykind:PackingFraction
    /// <see href="http://qudt.org/vocab/quantitykind/PackingFraction"></see></summary>
    let ``_/PackingFraction`` = _prefix "/PackingFraction"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PartialPressure"></see></summary>
    let ``_/PartialPressure`` = _prefix "/PartialPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleCurrent"></see></summary>
    let ``_/ParticleCurrent`` = _prefix "/ParticleCurrent"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ParticleCurrentDensity"></see>
    /// </summary>
    let ``_/ParticleCurrentDensity`` = _prefix "/ParticleCurrentDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:ParticleFluence
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleFluence"></see></summary>
    let ``_/ParticleFluence`` = _prefix "/ParticleFluence"
    /// <summary>
    /// Applicable units are those of quantitykind:ParticleFluenceRate
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleFluenceRate"></see></summary>
    let ``_/ParticleFluenceRate`` = _prefix "/ParticleFluenceRate"
    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleNumberDensity"></see></summary>
    let ``_/ParticleNumberDensity`` = _prefix "/ParticleNumberDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ParticlePositionVector"></see></summary>
    let ``_/ParticlePositionVector`` = _prefix "/ParticlePositionVector"
    /// <summary>
    /// Applicable units are those of quantitykind:ParticleSourceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleSourceDensity"></see></summary>
    let ``_/ParticleSourceDensity`` = _prefix "/ParticleSourceDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PathLength"></see></summary>
    let ``_/PathLength`` = _prefix "/PathLength"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/PayloadMass"></see></summary>
    let ``_/PayloadMass`` = _prefix "/PayloadMass"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PayloadRatio"></see></summary>
    let ``_/PayloadRatio`` = _prefix "/PayloadRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PeltierCoefficient"></see>
    /// </summary>
    let ``_/PeltierCoefficient`` = _prefix "/PeltierCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Period
    /// <see href="http://qudt.org/vocab/quantitykind/Period"></see></summary>
    let ``_/Period`` = _prefix "/Period"
    /// <summary>
    /// Applicable units are those of quantitykind:PermeabilityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PermeabilityRatio"></see></summary>
    let ``_/PermeabilityRatio`` = _prefix "/PermeabilityRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Permeance
    /// <see href="http://qudt.org/vocab/quantitykind/Permeance"></see></summary>
    let ``_/Permeance`` = _prefix "/Permeance"
    /// <summary>
    /// Applicable units are those of quantitykind:Reluctance
    /// <see href="http://qudt.org/vocab/quantitykind/Reluctance"></see></summary>
    let ``_/Reluctance`` = _prefix "/Reluctance"
    /// <summary>
    /// Applicable units are those of quantitykind:Permittivity
    /// <see href="http://qudt.org/vocab/quantitykind/Permittivity"></see></summary>
    let ``_/Permittivity`` = _prefix "/Permittivity"
    /// <summary>
    /// Applicable units are those of quantitykind:PermittivityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PermittivityRatio"></see></summary>
    let ``_/PermittivityRatio`` = _prefix "/PermittivityRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:PhaseCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/PhaseCoefficient"></see></summary>
    let ``_/PhaseCoefficient`` = _prefix "/PhaseCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/PhaseDifference"></see></summary>
    let ``_/PhaseDifference`` = _prefix "/PhaseDifference"
    /// <summary>
    /// Applicable units are those of quantitykind:PhaseSpeedOfSound
    /// <see href="http://qudt.org/vocab/quantitykind/PhaseSpeedOfSound"></see></summary>
    let ``_/PhaseSpeedOfSound`` = _prefix "/PhaseSpeedOfSound"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PhononMeanFreePath"></see></summary>
    let ``_/PhononMeanFreePath`` = _prefix "/PhononMeanFreePath"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PhotoThresholdOfAwarenessFunction"></see>
    /// </summary>
    let ``_/PhotoThresholdOfAwarenessFunction`` =
        _prefix "/PhotoThresholdOfAwarenessFunction"

    /// <summary>
    /// Applicable units are those of quantitykind:PhotonIntensity
    /// <see href="http://qudt.org/vocab/quantitykind/PhotonIntensity"></see></summary>
    let ``_/PhotonIntensity`` = _prefix "/PhotonIntensity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PhotonLuminance"></see>
    /// </summary>
    let ``_/PhotonLuminance`` = _prefix "/PhotonLuminance"
    /// <summary>
    /// Applicable units are those of quantitykind:PhotonRadiance
    /// <see href="http://qudt.org/vocab/quantitykind/PhotonRadiance"></see></summary>
    let ``_/PhotonRadiance`` = _prefix "/PhotonRadiance"
    /// <summary>
    /// Applicable units are those of quantitykind:PhotosyntheticPhotonFlux
    /// <see href="http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFlux"></see></summary>
    let ``_/PhotosyntheticPhotonFlux`` = _prefix "/PhotosyntheticPhotonFlux"

    /// <summary>
    /// Applicable units are those of quantitykind:PhotosyntheticPhotonFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFluxDensity"></see></summary>
    let ``_/PhotosyntheticPhotonFluxDensity`` =
        _prefix "/PhotosyntheticPhotonFluxDensity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PictureElement"></see>
    /// </summary>
    let ``_/PictureElement`` = _prefix "/PictureElement"
    /// <summary>
    /// Applicable units are those of quantitykind:Count
    /// <see href="http://qudt.org/vocab/quantitykind/Piece"></see></summary>
    let ``_/Piece`` = _prefix "/Piece"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PlanarForce"></see></summary>
    let ``_/PlanarForce`` = _prefix "/PlanarForce"
    /// <summary>
    /// Applicable units are those of quantitykind:PlasmaLevel
    /// <see href="http://qudt.org/vocab/quantitykind/PlasmaLevel"></see></summary>
    let ``_/PlasmaLevel`` = _prefix "/PlasmaLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:PoissonRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PoissonRatio"></see></summary>
    let ``_/PoissonRatio`` = _prefix "/PoissonRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/PolarMomentOfInertia"></see></summary>
    let ``_/PolarMomentOfInertia`` = _prefix "/PolarMomentOfInertia"
    /// <summary>
    /// Applicable units are those of quantitykind:Polarizability
    /// <see href="http://qudt.org/vocab/quantitykind/Polarizability"></see></summary>
    let ``_/Polarizability`` = _prefix "/Polarizability"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PolarizationField"></see></summary>
    let ``_/PolarizationField`` = _prefix "/PolarizationField"
    /// <summary>
    /// Applicable units are those of quantitykind:Population
    /// <see href="http://qudt.org/vocab/quantitykind/Population"></see></summary>
    let ``_/Population`` = _prefix "/Population"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PositiveDimensionlessRatio"></see></summary>
    let ``_/PositiveDimensionlessRatio`` = _prefix "/PositiveDimensionlessRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PositiveLength"></see></summary>
    let ``_/PositiveLength`` = _prefix "/PositiveLength"
    /// <summary>
    /// Applicable units are those of quantitykind:PlaneAngle
    /// <see href="http://qudt.org/vocab/quantitykind/PositivePlaneAngle"></see></summary>
    let ``_/PositivePlaneAngle`` = _prefix "/PositivePlaneAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/PotentialEnergy"></see></summary>
    let ``_/PotentialEnergy`` = _prefix "/PotentialEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PowerArea"></see></summary>
    let ``_/PowerArea`` = _prefix "/PowerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerAreaPerSolidAngle
    /// <see href="http://qudt.org/vocab/quantitykind/PowerAreaPerSolidAngle"></see></summary>
    let ``_/PowerAreaPerSolidAngle`` = _prefix "/PowerAreaPerSolidAngle"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PowerConstant"></see>
    /// </summary>
    let ``_/PowerConstant`` = _prefix "/PowerConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerDensity
    /// <see href="http://qudt.org/vocab/quantitykind/PowerDensity"></see></summary>
    let ``_/PowerDensity`` = _prefix "/PowerDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerVolume
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerVolume"></see></summary>
    let ``_/PowerPerVolume`` = _prefix "/PowerPerVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerFactor
    /// <see href="http://qudt.org/vocab/quantitykind/PowerFactor"></see></summary>
    let ``_/PowerFactor`` = _prefix "/PowerFactor"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PowerPerAreaAngle"></see>
    /// </summary>
    let ``_/PowerPerAreaAngle`` = _prefix "/PowerPerAreaAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerAreaQuarticTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerAreaQuarticTemperature"></see></summary>
    let ``_/PowerPerAreaQuarticTemperature`` = _prefix "/PowerPerAreaQuarticTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerElectricCharge"></see></summary>
    let ``_/PowerPerElectricCharge`` = _prefix "/PowerPerElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:PoyntingVector
    /// <see href="http://qudt.org/vocab/quantitykind/PoyntingVector"></see></summary>
    let ``_/PoyntingVector`` = _prefix "/PoyntingVector"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedAmountOfSubstanceConcentration"></see>
    /// </summary>
    let ``_/PressureBasedAmountOfSubstanceConcentration`` =
        _prefix "/PressureBasedAmountOfSubstanceConcentration"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedDensity"></see>
    /// </summary>
    let ``_/PressureBasedDensity`` = _prefix "/PressureBasedDensity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedDynamicViscosity"></see>
    /// </summary>
    let ``_/PressureBasedDynamicViscosity`` = _prefix "/PressureBasedDynamicViscosity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedElectricCurrent"></see>
    /// </summary>
    let ``_/PressureBasedElectricCurrent`` = _prefix "/PressureBasedElectricCurrent"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedElectricVoltage"></see>
    /// </summary>
    let ``_/PressureBasedElectricVoltage`` = _prefix "/PressureBasedElectricVoltage"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedKinematicViscosity"></see>
    /// </summary>
    let ``_/PressureBasedKinematicViscosity`` =
        _prefix "/PressureBasedKinematicViscosity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedLength"></see>
    /// </summary>
    let ``_/PressureBasedLength`` = _prefix "/PressureBasedLength"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedMass"></see>
    /// </summary>
    let ``_/PressureBasedMass`` = _prefix "/PressureBasedMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedMassFlow"></see>
    /// </summary>
    let ``_/PressureBasedMassFlow`` = _prefix "/PressureBasedMassFlow"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedMolality"></see>
    /// </summary>
    let ``_/PressureBasedMolality`` = _prefix "/PressureBasedMolality"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedQuantity"></see>
    /// </summary>
    let ``_/PressureBasedQuantity`` = _prefix "/PressureBasedQuantity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedTemperature"></see>
    /// </summary>
    let ``_/PressureBasedTemperature`` = _prefix "/PressureBasedTemperature"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedVelocity"></see>
    /// </summary>
    let ``_/PressureBasedVelocity`` = _prefix "/PressureBasedVelocity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedVolume"></see>
    /// </summary>
    let ``_/PressureBasedVolume`` = _prefix "/PressureBasedVolume"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedVolumeFlow"></see>
    /// </summary>
    let ``_/PressureBasedVolumeFlow`` = _prefix "/PressureBasedVolumeFlow"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/PressureBurningRateConstant"></see></summary>
    let ``_/PressureBurningRateConstant`` = _prefix "/PressureBurningRateConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/PressureBurningRateIndex"></see></summary>
    let ``_/PressureBurningRateIndex`` = _prefix "/PressureBurningRateIndex"
    /// <summary>
    /// Applicable units are those of quantitykind:PressureCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/PressureCoefficient"></see></summary>
    let ``_/PressureCoefficient`` = _prefix "/PressureCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:PressureGradient
    /// <see href="http://qudt.org/vocab/quantitykind/PressureGradient"></see></summary>
    let ``_/PressureGradient`` = _prefix "/PressureGradient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlow"></see>
    /// </summary>
    let ``_/PressureInRelationToVolumeFlow`` = _prefix "/PressureInRelationToVolumeFlow"

    /// <summary>
    /// Applicable units are those of quantitykind:PressureInRelationToVolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlowRate"></see></summary>
    let ``_/PressureInRelationToVolumeFlowRate`` =
        _prefix "/PressureInRelationToVolumeFlowRate"

    /// <summary>
    /// Applicable units are those of quantitykind:PressureLossPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/PressureLossPerLength"></see></summary>
    let ``_/PressureLossPerLength`` = _prefix "/PressureLossPerLength"
    /// <summary>
    /// Applicable units are those of quantitykind:PressureRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PressureRatio"></see></summary>
    let ``_/PressureRatio`` = _prefix "/PressureRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Prevalence
    /// <see href="http://qudt.org/vocab/quantitykind/Prevalence"></see></summary>
    let ``_/Prevalence`` = _prefix "/Prevalence"
    /// <summary>
    /// Applicable units are those of quantitykind:PropagationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/PropagationCoefficient"></see></summary>
    let ``_/PropagationCoefficient`` = _prefix "/PropagationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:PropellantBurnRate
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantBurnRate"></see></summary>
    let ``_/PropellantBurnRate`` = _prefix "/PropellantBurnRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantMeanBulkTemperature"></see></summary>
    let ``_/PropellantMeanBulkTemperature`` = _prefix "/PropellantMeanBulkTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantTemperature"></see></summary>
    let ``_/PropellantTemperature`` = _prefix "/PropellantTemperature"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/QuantityOfLight"></see>
    /// </summary>
    let ``_/QuantityOfLight`` = _prefix "/QuantityOfLight"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/RESERVE-MASS"></see></summary>
    let ``_/RESERVE-MASS`` = _prefix "/RESERVE-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricField
    /// <see href="http://qudt.org/vocab/quantitykind/RF-Power"></see></summary>
    let ``_/RF-Power`` = _prefix "/RF-Power"
    /// <summary>
    /// Applicable units are those of quantitykind:ElectricField
    /// <see href="http://qudt.org/vocab/quantitykind/SignalStrength"></see></summary>
    let ``_/SignalStrength`` = _prefix "/SignalStrength"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/RadialDistance"></see></summary>
    let ``_/RadialDistance`` = _prefix "/RadialDistance"
    /// <summary>
    /// Applicable units are those of quantitykind:Radiance
    /// <see href="http://qudt.org/vocab/quantitykind/Radiance"></see></summary>
    let ``_/Radiance`` = _prefix "/Radiance"
    /// <summary>
    /// Applicable units are those of quantitykind:RadianceFactor
    /// <see href="http://qudt.org/vocab/quantitykind/RadianceFactor"></see></summary>
    let ``_/RadianceFactor`` = _prefix "/RadianceFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantEmmitance"></see></summary>
    let ``_/RadiantEmmitance`` = _prefix "/RadiantEmmitance"
    /// <summary>
    /// Applicable units are those of quantitykind:RadiantEnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantEnergyDensity"></see></summary>
    let ``_/RadiantEnergyDensity`` = _prefix "/RadiantEnergyDensity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RadiantEnergyExposure"></see>
    /// </summary>
    let ``_/RadiantEnergyExposure`` = _prefix "/RadiantEnergyExposure"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantExposure"></see></summary>
    let ``_/RadiantExposure`` = _prefix "/RadiantExposure"
    /// <summary>
    /// Applicable units are those of quantitykind:RadiantFluence
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantFluence"></see></summary>
    let ``_/RadiantFluence`` = _prefix "/RadiantFluence"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantFluenceRate"></see></summary>
    let ``_/RadiantFluenceRate`` = _prefix "/RadiantFluenceRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantFlux"></see></summary>
    let ``_/RadiantFlux`` = _prefix "/RadiantFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:RadiantIntensity
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantIntensity"></see></summary>
    let ``_/RadiantIntensity`` = _prefix "/RadiantIntensity"
    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/RadiativeHeatTransfer"></see></summary>
    let ``_/RadiativeHeatTransfer`` = _prefix "/RadiativeHeatTransfer"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RadioactiveDecay"></see>
    /// </summary>
    let ``_/RadioactiveDecay`` = _prefix "/RadioactiveDecay"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Radioactivity"></see>
    /// </summary>
    let ``_/Radioactivity`` = _prefix "/Radioactivity"
    /// <summary>
    /// Applicable units are those of quantitykind:Radiosity
    /// <see href="http://qudt.org/vocab/quantitykind/Radiosity"></see></summary>
    let ``_/Radiosity`` = _prefix "/Radiosity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/RadiusOfCurvature"></see></summary>
    let ``_/RadiusOfCurvature`` = _prefix "/RadiusOfCurvature"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermodynamicTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/RankineTemperature"></see></summary>
    let ``_/RankineTemperature`` = _prefix "/RankineTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:RateOfChange
    /// <see href="http://qudt.org/vocab/quantitykind/RateOfChange"></see></summary>
    let ``_/RateOfChange`` = _prefix "/RateOfChange"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RateOfRiseOfVoltage"></see>
    /// </summary>
    let ``_/RateOfRiseOfVoltage`` = _prefix "/RateOfRiseOfVoltage"
    /// <summary>
    /// Applicable units are those of quantitykind:Ratio
    /// <see href="http://qudt.org/vocab/quantitykind/Ratio"></see></summary>
    let ``_/Ratio`` = _prefix "/Ratio"
    /// <summary>
    /// Applicable units are those of quantitykind:RatioOfSpecificHeatCapacities
    /// <see href="http://qudt.org/vocab/quantitykind/RatioOfSpecificHeatCapacities"></see></summary>
    let ``_/RatioOfSpecificHeatCapacities`` = _prefix "/RatioOfSpecificHeatCapacities"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ReactionEnergy"></see></summary>
    let ``_/ReactionEnergy`` = _prefix "/ReactionEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:ReactiveCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ReactiveCharge"></see></summary>
    let ``_/ReactiveCharge`` = _prefix "/ReactiveCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:ReactivePower
    /// <see href="http://qudt.org/vocab/quantitykind/ReactivePower"></see></summary>
    let ``_/ReactivePower`` = _prefix "/ReactivePower"
    /// <summary>
    /// Applicable units are those of quantitykind:Reactivity
    /// <see href="http://qudt.org/vocab/quantitykind/Reactivity"></see></summary>
    let ``_/Reactivity`` = _prefix "/Reactivity"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/ReactorTimeConstant"></see></summary>
    let ``_/ReactorTimeConstant`` = _prefix "/ReactorTimeConstant"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ReciprocalElectricResistance"></see>
    /// </summary>
    let ``_/ReciprocalElectricResistance`` = _prefix "/ReciprocalElectricResistance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ReciprocalEnergy"></see>
    /// </summary>
    let ``_/ReciprocalEnergy`` = _prefix "/ReciprocalEnergy"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ReciprocalPlaneAngle"></see>
    /// </summary>
    let ``_/ReciprocalPlaneAngle`` = _prefix "/ReciprocalPlaneAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:ReciprocalVoltage
    /// <see href="http://qudt.org/vocab/quantitykind/ReciprocalVoltage"></see></summary>
    let ``_/ReciprocalVoltage`` = _prefix "/ReciprocalVoltage"
    /// <summary>
    /// Applicable units are those of quantitykind:RecombinationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/RecombinationCoefficient"></see></summary>
    let ``_/RecombinationCoefficient`` = _prefix "/RecombinationCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Reflectance
    /// <see href="http://qudt.org/vocab/quantitykind/Reflectance"></see></summary>
    let ``_/Reflectance`` = _prefix "/Reflectance"
    /// <summary>
    /// Applicable units are those of quantitykind:ReflectanceFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ReflectanceFactor"></see></summary>
    let ``_/ReflectanceFactor`` = _prefix "/ReflectanceFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:Reflectance
    /// <see href="http://qudt.org/vocab/quantitykind/Reflectivity"></see></summary>
    let ``_/Reflectivity`` = _prefix "/Reflectivity"
    /// <summary>
    /// Applicable units are those of quantitykind:RefractiveIndex
    /// <see href="http://qudt.org/vocab/quantitykind/RefractiveIndex"></see></summary>
    let ``_/RefractiveIndex`` = _prefix "/RefractiveIndex"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeAtomicMass"></see></summary>
    let ``_/RelativeAtomicMass`` = _prefix "/RelativeAtomicMass"
    /// <summary>
    /// Applicable units are those of quantitykind:RelativePartialPressure
    /// <see href="http://qudt.org/vocab/quantitykind/RelativePartialPressure"></see></summary>
    let ``_/RelativePartialPressure`` = _prefix "/RelativePartialPressure"

    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassConcentrationOfVapour
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassConcentrationOfVapour"></see></summary>
    let ``_/RelativeMassConcentrationOfVapour`` =
        _prefix "/RelativeMassConcentrationOfVapour"

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassDefect"></see></summary>
    let ``_/RelativeMassDefect`` = _prefix "/RelativeMassDefect"
    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassDensity
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassDensity"></see></summary>
    let ``_/RelativeMassDensity`` = _prefix "/RelativeMassDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassExcess
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassExcess"></see></summary>
    let ``_/RelativeMassExcess`` = _prefix "/RelativeMassExcess"
    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassRatioOfVapour
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassRatioOfVapour"></see></summary>
    let ``_/RelativeMassRatioOfVapour`` = _prefix "/RelativeMassRatioOfVapour"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMolecularMass"></see></summary>
    let ``_/RelativeMolecularMass`` = _prefix "/RelativeMolecularMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RelativePermittivity"></see>
    /// </summary>
    let ``_/RelativePermittivity`` = _prefix "/RelativePermittivity"
    /// <summary>
    /// Applicable units are those of quantitykind:RelativePressureCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/RelativePressureCoefficient"></see></summary>
    let ``_/RelativePressureCoefficient`` = _prefix "/RelativePressureCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/RelaxationTIme"></see></summary>
    let ``_/RelaxationTIme`` = _prefix "/RelaxationTIme"
    /// <summary>
    /// Applicable units are those of quantitykind:Repetency
    /// <see href="http://qudt.org/vocab/quantitykind/Repetency"></see></summary>
    let ``_/Repetency`` = _prefix "/Repetency"
    /// <summary>
    /// Applicable units are those of quantitykind:ResidualResistivity
    /// <see href="http://qudt.org/vocab/quantitykind/ResidualResistivity"></see></summary>
    let ``_/ResidualResistivity`` = _prefix "/ResidualResistivity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ResistanceBasedInductance"></see>
    /// </summary>
    let ``_/ResistanceBasedInductance`` = _prefix "/ResistanceBasedInductance"
    /// <summary>
    /// Applicable units are those of quantitykind:ResistanceRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ResistanceRatio"></see></summary>
    let ``_/ResistanceRatio`` = _prefix "/ResistanceRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Resistivity
    /// <see href="http://qudt.org/vocab/quantitykind/Resistivity"></see></summary>
    let ``_/Resistivity`` = _prefix "/Resistivity"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ResonanceEnergy"></see></summary>
    let ``_/ResonanceEnergy`` = _prefix "/ResonanceEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:ResonanceEscapeProbability
    /// <see href="http://qudt.org/vocab/quantitykind/ResonanceEscapeProbability"></see></summary>
    let ``_/ResonanceEscapeProbability`` = _prefix "/ResonanceEscapeProbability"

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/ResonanceEscapeProbabilityForFission"></see></summary>
    let ``_/ResonanceEscapeProbabilityForFission`` =
        _prefix "/ResonanceEscapeProbabilityForFission"

    /// <summary>
    /// Applicable units are those of quantitykind:RespiratoryRate
    /// <see href="http://qudt.org/vocab/quantitykind/RespiratoryRate"></see></summary>
    let ``_/RespiratoryRate`` = _prefix "/RespiratoryRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/RestEnergy"></see></summary>
    let ``_/RestEnergy`` = _prefix "/RestEnergy"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/RestMass"></see></summary>
    let ``_/RestMass`` = _prefix "/RestMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/ReverberationTime"></see></summary>
    let ``_/ReverberationTime`` = _prefix "/ReverberationTime"
    /// <summary>
    /// Applicable units are those of quantitykind:ReynoldsNumber
    /// <see href="http://qudt.org/vocab/quantitykind/ReynoldsNumber"></see></summary>
    let ``_/ReynoldsNumber`` = _prefix "/ReynoldsNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:RichardsonConstant
    /// <see href="http://qudt.org/vocab/quantitykind/RichardsonConstant"></see></summary>
    let ``_/RichardsonConstant`` = _prefix "/RichardsonConstant"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RiseOfOffStateVoltage"></see>
    /// </summary>
    let ``_/RiseOfOffStateVoltage`` = _prefix "/RiseOfOffStateVoltage"

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/RocketAtmosphericTransverseForce"></see></summary>
    let ``_/RocketAtmosphericTransverseForce`` =
        _prefix "/RocketAtmosphericTransverseForce"

    /// <summary>
    /// Applicable units are those of quantitykind:Rotary-TranslatoryMotionConversion
    /// <see href="http://qudt.org/vocab/quantitykind/Rotary-TranslatoryMotionConversion"></see></summary>
    let ``_/Rotary-TranslatoryMotionConversion`` =
        _prefix "/Rotary-TranslatoryMotionConversion"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RotaryShock"></see>
    /// </summary>
    let ``_/RotaryShock`` = _prefix "/RotaryShock"
    /// <summary>
    /// Applicable units are those of quantitykind:TorquePerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalStiffness"></see></summary>
    let ``_/RotationalStiffness`` = _prefix "/RotationalStiffness"
    /// <summary>
    /// Applicable units are those of quantitykind:TorquePerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/TorquePerAngle"></see></summary>
    let ``_/TorquePerAngle`` = _prefix "/TorquePerAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:ScalarMagneticPotential
    /// <see href="http://qudt.org/vocab/quantitykind/ScalarMagneticPotential"></see></summary>
    let ``_/ScalarMagneticPotential`` = _prefix "/ScalarMagneticPotential"
    /// <summary>
    /// Applicable units are those of quantitykind:SecondAxialMomentOfArea
    /// <see href="http://qudt.org/vocab/quantitykind/SecondAxialMomentOfArea"></see></summary>
    let ``_/SecondAxialMomentOfArea`` = _prefix "/SecondAxialMomentOfArea"
    /// <summary>
    /// Applicable units are those of quantitykind:SecondMomentOfArea
    /// <see href="http://qudt.org/vocab/quantitykind/SecondMomentOfArea"></see></summary>
    let ``_/SecondMomentOfArea`` = _prefix "/SecondMomentOfArea"
    /// <summary>
    /// Applicable units are those of quantitykind:SecondPolarMomentOfArea
    /// <see href="http://qudt.org/vocab/quantitykind/SecondPolarMomentOfArea"></see></summary>
    let ``_/SecondPolarMomentOfArea`` = _prefix "/SecondPolarMomentOfArea"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SecondRadiationConstant"></see>
    /// </summary>
    let ``_/SecondRadiationConstant`` = _prefix "/SecondRadiationConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SecondStageMassRatio"></see></summary>
    let ``_/SecondStageMassRatio`` = _prefix "/SecondStageMassRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:SectionAreaIntegral
    /// <see href="http://qudt.org/vocab/quantitykind/SectionAreaIntegral"></see></summary>
    let ``_/SectionAreaIntegral`` = _prefix "/SectionAreaIntegral"
    /// <summary>
    /// Applicable units are those of quantitykind:SectionModulus
    /// <see href="http://qudt.org/vocab/quantitykind/SectionModulus"></see></summary>
    let ``_/SectionModulus`` = _prefix "/SectionModulus"
    /// <summary>
    /// Applicable units are those of quantitykind:SeebeckCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/SeebeckCoefficient"></see></summary>
    let ``_/SeebeckCoefficient`` = _prefix "/SeebeckCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:SerumLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SerumLevel"></see></summary>
    let ``_/SerumLevel`` = _prefix "/SerumLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/SerumOrPlasmaLevel"></see></summary>
    let ``_/SerumOrPlasmaLevel`` = _prefix "/SerumOrPlasmaLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:ServiceFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ServiceFactor"></see></summary>
    let ``_/ServiceFactor`` = _prefix "/ServiceFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:InformationEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/ShannonDiversityIndex"></see></summary>
    let ``_/ShannonDiversityIndex`` = _prefix "/ShannonDiversityIndex"
    /// <summary>
    /// Applicable units are those of quantitykind:ShearModulus
    /// <see href="http://qudt.org/vocab/quantitykind/ShearModulus"></see></summary>
    let ``_/ShearModulus`` = _prefix "/ShearModulus"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ShearStrain"></see></summary>
    let ``_/ShearStrain`` = _prefix "/ShearStrain"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ShearStress"></see></summary>
    let ``_/ShearStress`` = _prefix "/ShearStress"
    /// <summary>
    /// Applicable units are those of quantitykind:Short-RangeOrderParameter
    /// <see href="http://qudt.org/vocab/quantitykind/Short-RangeOrderParameter"></see></summary>
    let ``_/Short-RangeOrderParameter`` = _prefix "/Short-RangeOrderParameter"
    /// <summary>
    /// Applicable units are those of quantitykind:SignalDetectionThreshold
    /// <see href="http://qudt.org/vocab/quantitykind/SignalDetectionThreshold"></see></summary>
    let ``_/SignalDetectionThreshold`` = _prefix "/SignalDetectionThreshold"
    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SingleStageLauncherMassRatio"></see></summary>
    let ``_/SingleStageLauncherMassRatio`` = _prefix "/SingleStageLauncherMassRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/Slowing-DownArea"></see></summary>
    let ``_/Slowing-DownArea`` = _prefix "/Slowing-DownArea"
    /// <summary>
    /// Applicable units are those of quantitykind:Slowing-DownDensity
    /// <see href="http://qudt.org/vocab/quantitykind/Slowing-DownDensity"></see></summary>
    let ``_/Slowing-DownDensity`` = _prefix "/Slowing-DownDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Slowing-DownLength"></see></summary>
    let ``_/Slowing-DownLength`` = _prefix "/Slowing-DownLength"
    /// <summary>
    /// Applicable units are those of quantitykind:SoilAdsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/SoilAdsorptionCoefficient"></see></summary>
    let ``_/SoilAdsorptionCoefficient`` = _prefix "/SoilAdsorptionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:SolidAngle
    /// <see href="http://qudt.org/vocab/quantitykind/SolidAngle"></see></summary>
    let ``_/SolidAngle`` = _prefix "/SolidAngle"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/SolidStateDiffusionLength"></see></summary>
    let ``_/SolidStateDiffusionLength`` = _prefix "/SolidStateDiffusionLength"
    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/Solubility_Water"></see></summary>
    let ``_/Solubility_Water`` = _prefix "/Solubility_Water"
    /// <summary>
    /// Applicable units are those of quantitykind:WaterSolubility
    /// <see href="http://qudt.org/vocab/quantitykind/WaterSolubility"></see></summary>
    let ``_/WaterSolubility`` = _prefix "/WaterSolubility"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SoundEnergyDensity"></see></summary>
    let ``_/SoundEnergyDensity`` = _prefix "/SoundEnergyDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundExposure
    /// <see href="http://qudt.org/vocab/quantitykind/SoundExposure"></see></summary>
    let ``_/SoundExposure`` = _prefix "/SoundExposure"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundExposureLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SoundExposureLevel"></see></summary>
    let ``_/SoundExposureLevel`` = _prefix "/SoundExposureLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SoundIntensity"></see></summary>
    let ``_/SoundIntensity`` = _prefix "/SoundIntensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Acceleration
    /// <see href="http://qudt.org/vocab/quantitykind/SoundParticleAcceleration"></see></summary>
    let ``_/SoundParticleAcceleration`` = _prefix "/SoundParticleAcceleration"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/SoundParticleDisplacement"></see></summary>
    let ``_/SoundParticleDisplacement`` = _prefix "/SoundParticleDisplacement"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundParticleVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/SoundParticleVelocity"></see></summary>
    let ``_/SoundParticleVelocity`` = _prefix "/SoundParticleVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPower"></see></summary>
    let ``_/SoundPower`` = _prefix "/SoundPower"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPressure"></see></summary>
    let ``_/SoundPressure`` = _prefix "/SoundPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundPressureLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPressureLevel"></see></summary>
    let ``_/SoundPressureLevel`` = _prefix "/SoundPressureLevel"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundReductionIndex
    /// <see href="http://qudt.org/vocab/quantitykind/SoundReductionIndex"></see></summary>
    let ``_/SoundReductionIndex`` = _prefix "/SoundReductionIndex"
    /// <summary>
    /// Applicable units are those of quantitykind:SoundVolumeVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/SoundVolumeVelocity"></see></summary>
    let ``_/SoundVolumeVelocity`` = _prefix "/SoundVolumeVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Voltage
    /// <see href="http://qudt.org/vocab/quantitykind/SourceVoltage"></see></summary>
    let ``_/SourceVoltage`` = _prefix "/SourceVoltage"
    /// <summary>
    /// Applicable units are those of quantitykind:Voltage
    /// <see href="http://qudt.org/vocab/quantitykind/SourceVoltageBetweenSubstances"></see></summary>
    let ``_/SourceVoltageBetweenSubstances`` = _prefix "/SourceVoltageBetweenSubstances"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/SpatialSummationFunction"></see></summary>
    let ``_/SpatialSummationFunction`` = _prefix "/SpatialSummationFunction"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificAcousticImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificAcousticImpedance"></see></summary>
    let ``_/SpecificAcousticImpedance`` = _prefix "/SpecificAcousticImpedance"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificActivity
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificActivity"></see></summary>
    let ``_/SpecificActivity`` = _prefix "/SpecificActivity"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificElectricCharge"></see></summary>
    let ``_/SpecificElectricCharge`` = _prefix "/SpecificElectricCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificElectricCurrent"></see></summary>
    let ``_/SpecificElectricCurrent`` = _prefix "/SpecificElectricCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEnergyImparted"></see></summary>
    let ``_/SpecificEnergyImparted`` = _prefix "/SpecificEnergyImparted"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEntropy"></see></summary>
    let ``_/SpecificEntropy`` = _prefix "/SpecificEntropy"

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacityAtConstantPressure
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantPressure"></see></summary>
    let ``_/SpecificHeatCapacityAtConstantPressure`` =
        _prefix "/SpecificHeatCapacityAtConstantPressure"

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacityAtConstantVolume
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantVolume"></see></summary>
    let ``_/SpecificHeatCapacityAtConstantVolume`` =
        _prefix "/SpecificHeatCapacityAtConstantVolume"

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacityAtSaturation
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtSaturation"></see></summary>
    let ``_/SpecificHeatCapacityAtSaturation`` =
        _prefix "/SpecificHeatCapacityAtSaturation"

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatPressure
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatPressure"></see></summary>
    let ``_/SpecificHeatPressure`` = _prefix "/SpecificHeatPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatVolume
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatVolume"></see></summary>
    let ``_/SpecificHeatVolume`` = _prefix "/SpecificHeatVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatsRatio"></see></summary>
    let ``_/SpecificHeatsRatio`` = _prefix "/SpecificHeatsRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificImpulseByMass"></see></summary>
    let ``_/SpecificImpulseByMass`` = _prefix "/SpecificImpulseByMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificImpulseByWeight"></see></summary>
    let ``_/SpecificImpulseByWeight`` = _prefix "/SpecificImpulseByWeight"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificModulus
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificModulus"></see></summary>
    let ``_/SpecificModulus`` = _prefix "/SpecificModulus"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpecificOpticalRotationalAbility"></see>
    /// </summary>
    let ``_/SpecificOpticalRotationalAbility`` =
        _prefix "/SpecificOpticalRotationalAbility"

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificOpticalRotatoryPower
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificOpticalRotatoryPower"></see></summary>
    let ``_/SpecificOpticalRotatoryPower`` = _prefix "/SpecificOpticalRotatoryPower"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificSurfaceArea
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificSurfaceArea"></see></summary>
    let ``_/SpecificSurfaceArea`` = _prefix "/SpecificSurfaceArea"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpecificThrust"></see>
    /// </summary>
    let ``_/SpecificThrust`` = _prefix "/SpecificThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:SpecificWeight
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificWeight"></see></summary>
    let ``_/SpecificWeight`` = _prefix "/SpecificWeight"
    /// <summary>
    /// Applicable units are those of quantitykind:SpectralAngularCrossSection
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralAngularCrossSection"></see></summary>
    let ``_/SpectralAngularCrossSection`` = _prefix "/SpectralAngularCrossSection"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralConcentrationOfRadiantEnergyDensity"></see>
    /// </summary>
    let ``_/SpectralConcentrationOfRadiantEnergyDensity`` =
        _prefix "/SpectralConcentrationOfRadiantEnergyDensity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralConcentrationOfVibrationalModes"></see>
    /// </summary>
    let ``_/SpectralConcentrationOfVibrationalModes`` =
        _prefix "/SpectralConcentrationOfVibrationalModes"

    /// <summary>
    /// Applicable units are those of quantitykind:SpectralDensityOfVibrationalModes
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralDensityOfVibrationalModes"></see></summary>
    let ``_/SpectralDensityOfVibrationalModes`` =
        _prefix "/SpectralDensityOfVibrationalModes"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralEmittance"></see>
    /// </summary>
    let ``_/SpectralEmittance`` = _prefix "/SpectralEmittance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralIrradiance"></see>
    /// </summary>
    let ``_/SpectralIrradiance`` = _prefix "/SpectralIrradiance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralLuminousEfficiency"></see>
    /// </summary>
    let ``_/SpectralLuminousEfficiency`` = _prefix "/SpectralLuminousEfficiency"
    /// <summary>
    /// Applicable units are those of quantitykind:SpectralRadiance
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralRadiance"></see></summary>
    let ``_/SpectralRadiance`` = _prefix "/SpectralRadiance"
    /// <summary>
    /// Applicable units are those of quantitykind:SpectralRadiantEnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensity"></see></summary>
    let ``_/SpectralRadiantEnergyDensity`` = _prefix "/SpectralRadiantEnergyDensity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensityInTermsOfWavelength"></see>
    /// </summary>
    let ``_/SpectralRadiantEnergyDensityInTermsOfWavelength`` =
        _prefix "/SpectralRadiantEnergyDensityInTermsOfWavelength"

    /// <summary>
    /// Applicable units are those of quantitykind:SpeedOfLight
    /// <see href="http://qudt.org/vocab/quantitykind/SpeedOfLight"></see></summary>
    let ``_/SpeedOfLight`` = _prefix "/SpeedOfLight"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SpeedRatio"></see></summary>
    let ``_/SpeedRatio`` = _prefix "/SpeedRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SphericalIlluminance"></see></summary>
    let ``_/SphericalIlluminance`` = _prefix "/SphericalIlluminance"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/Spin"></see></summary>
    let ``_/Spin`` = _prefix "/Spin"
    /// <summary>
    /// Applicable units are those of quantitykind:SquareTime
    /// <see href="http://qudt.org/vocab/quantitykind/SquareTime"></see></summary>
    let ``_/SquareTime`` = _prefix "/SquareTime"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/StagePropellantMass"></see></summary>
    let ``_/StagePropellantMass`` = _prefix "/StagePropellantMass"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/StageStructuralMass"></see></summary>
    let ``_/StageStructuralMass`` = _prefix "/StageStructuralMass"
    /// <summary>
    /// Applicable units are those of quantitykind:StandardAbsoluteActivity
    /// <see href="http://qudt.org/vocab/quantitykind/StandardAbsoluteActivity"></see></summary>
    let ``_/StandardAbsoluteActivity`` = _prefix "/StandardAbsoluteActivity"
    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/StandardChemicalPotential"></see></summary>
    let ``_/StandardChemicalPotential`` = _prefix "/StandardChemicalPotential"
    /// <summary>
    /// Applicable units are those of quantitykind:StandardGravitationalParameter
    /// <see href="http://qudt.org/vocab/quantitykind/StandardGravitationalParameter"></see></summary>
    let ``_/StandardGravitationalParameter`` = _prefix "/StandardGravitationalParameter"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/StateDensity"></see>
    /// </summary>
    let ``_/StateDensity`` = _prefix "/StateDensity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/StateDensityAsExpressionOfAngularFrequency"></see>
    /// </summary>
    let ``_/StateDensityAsExpressionOfAngularFrequency`` =
        _prefix "/StateDensityAsExpressionOfAngularFrequency"

    /// <summary>
    /// Applicable units are those of quantitykind:StateOfCharge
    /// <see href="http://qudt.org/vocab/quantitykind/StateOfCharge"></see></summary>
    let ``_/StateOfCharge`` = _prefix "/StateOfCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/StaticFriction"></see></summary>
    let ``_/StaticFriction`` = _prefix "/StaticFriction"
    /// <summary>
    /// Applicable units are those of quantitykind:FrictionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/StaticFrictionCoefficient"></see></summary>
    let ``_/StaticFrictionCoefficient`` = _prefix "/StaticFrictionCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/StaticPressure"></see></summary>
    let ``_/StaticPressure`` = _prefix "/StaticPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:StatisticalWeight
    /// <see href="http://qudt.org/vocab/quantitykind/StatisticalWeight"></see></summary>
    let ``_/StatisticalWeight`` = _prefix "/StatisticalWeight"
    /// <summary>
    /// Applicable units are those of quantitykind:StoichiometricNumber
    /// <see href="http://qudt.org/vocab/quantitykind/StoichiometricNumber"></see></summary>
    let ``_/StoichiometricNumber`` = _prefix "/StoichiometricNumber"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/StrainEnergyDensity"></see></summary>
    let ``_/StrainEnergyDensity`` = _prefix "/StrainEnergyDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:StrainEnergyReleaseRate
    /// <see href="http://qudt.org/vocab/quantitykind/StrainEnergyReleaseRate"></see></summary>
    let ``_/StrainEnergyReleaseRate`` = _prefix "/StrainEnergyReleaseRate"
    /// <summary>
    /// Applicable units are those of quantitykind:StressIntensityFactor
    /// <see href="http://qudt.org/vocab/quantitykind/StressIntensityFactor"></see></summary>
    let ``_/StressIntensityFactor`` = _prefix "/StressIntensityFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:StressOpticCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/StressOpticCoefficient"></see></summary>
    let ``_/StressOpticCoefficient`` = _prefix "/StressOpticCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/StructuralEfficiency"></see></summary>
    let ``_/StructuralEfficiency`` = _prefix "/StructuralEfficiency"
    /// <summary>
    /// Applicable units are those of quantitykind:StructureFactor
    /// <see href="http://qudt.org/vocab/quantitykind/StructureFactor"></see></summary>
    let ``_/StructureFactor`` = _prefix "/StructureFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:SunProtectionFactorOfAProduct
    /// <see href="http://qudt.org/vocab/quantitykind/SunProtectionFactorOfAProduct"></see></summary>
    let ``_/SunProtectionFactorOfAProduct`` = _prefix "/SunProtectionFactorOfAProduct"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/SuperconductorEnergyGap"></see></summary>
    let ``_/SuperconductorEnergyGap`` = _prefix "/SuperconductorEnergyGap"
    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceActivityDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceActivityDensity"></see></summary>
    let ``_/SurfaceActivityDensity`` = _prefix "/SurfaceActivityDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceCoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceCoefficientOfHeatTransfer"></see></summary>
    let ``_/SurfaceCoefficientOfHeatTransfer`` =
        _prefix "/SurfaceCoefficientOfHeatTransfer"

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceDensity"></see></summary>
    let ``_/SurfaceDensity`` = _prefix "/SurfaceDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceRelatedVolumeFlow
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlow"></see></summary>
    let ``_/SurfaceRelatedVolumeFlow`` = _prefix "/SurfaceRelatedVolumeFlow"
    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceRelatedVolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlowRate"></see></summary>
    let ``_/SurfaceRelatedVolumeFlowRate`` = _prefix "/SurfaceRelatedVolumeFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceTension"></see></summary>
    let ``_/SurfaceTension`` = _prefix "/SurfaceTension"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SurgeImpedanceOfTheMedium"></see>
    /// </summary>
    let ``_/SurgeImpedanceOfTheMedium`` = _prefix "/SurgeImpedanceOfTheMedium"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Susceptance"></see>
    /// </summary>
    let ``_/Susceptance`` = _prefix "/Susceptance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SymbolTransmissionRate"></see>
    /// </summary>
    let ``_/SymbolTransmissionRate`` = _prefix "/SymbolTransmissionRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/TARGET-BOGIE-MASS"></see></summary>
    let ``_/TARGET-BOGIE-MASS`` = _prefix "/TARGET-BOGIE-MASS"
    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureAmountOfSubstance"></see></summary>
    let ``_/TemperatureAmountOfSubstance`` = _prefix "/TemperatureAmountOfSubstance"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedAmountOfSubstanceConcentration"></see>
    /// </summary>
    let ``_/TemperatureBasedAmountOfSubstanceConcentration`` =
        _prefix "/TemperatureBasedAmountOfSubstanceConcentration"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedDensity"></see>
    /// </summary>
    let ``_/TemperatureBasedDensity`` = _prefix "/TemperatureBasedDensity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedDynamicViscosity"></see>
    /// </summary>
    let ``_/TemperatureBasedDynamicViscosity`` =
        _prefix "/TemperatureBasedDynamicViscosity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedKinematicViscosity"></see>
    /// </summary>
    let ``_/TemperatureBasedKinematicViscosity`` =
        _prefix "/TemperatureBasedKinematicViscosity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedLength"></see>
    /// </summary>
    let ``_/TemperatureBasedLength`` = _prefix "/TemperatureBasedLength"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedMass"></see>
    /// </summary>
    let ``_/TemperatureBasedMass`` = _prefix "/TemperatureBasedMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedMassFlowRate"></see>
    /// </summary>
    let ``_/TemperatureBasedMassFlowRate`` = _prefix "/TemperatureBasedMassFlowRate"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedQuantity"></see>
    /// </summary>
    let ``_/TemperatureBasedQuantity`` = _prefix "/TemperatureBasedQuantity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedVelocity"></see>
    /// </summary>
    let ``_/TemperatureBasedVelocity`` = _prefix "/TemperatureBasedVelocity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedVolumeFlowRate"></see>
    /// </summary>
    let ``_/TemperatureBasedVolumeFlowRate`` = _prefix "/TemperatureBasedVolumeFlowRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureDifference"></see></summary>
    let ``_/TemperatureDifference`` = _prefix "/TemperatureDifference"
    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureGradient
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureGradient"></see></summary>
    let ``_/TemperatureGradient`` = _prefix "/TemperatureGradient"

    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerMagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/TemperaturePerMagneticFluxDensity"></see></summary>
    let ``_/TemperaturePerMagneticFluxDensity`` =
        _prefix "/TemperaturePerMagneticFluxDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerSquareTime
    /// <see href="http://qudt.org/vocab/quantitykind/TemperaturePerSquareTime"></see></summary>
    let ``_/TemperaturePerSquareTime`` = _prefix "/TemperaturePerSquareTime"
    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerTime
    /// <see href="http://qudt.org/vocab/quantitykind/TemperaturePerTime"></see></summary>
    let ``_/TemperaturePerTime`` = _prefix "/TemperaturePerTime"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperaturePerTime_Squared"></see>
    /// </summary>
    let ``_/TemperaturePerTime_Squared`` = _prefix "/TemperaturePerTime_Squared"
    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerTime
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureRateOfChange"></see></summary>
    let ``_/TemperatureRateOfChange`` = _prefix "/TemperatureRateOfChange"
    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureRatio
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureRatio"></see></summary>
    let ``_/TemperatureRatio`` = _prefix "/TemperatureRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureRelatedMolarMass"></see>
    /// </summary>
    let ``_/TemperatureRelatedMolarMass`` = _prefix "/TemperatureRelatedMolarMass"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureRelatedVolume"></see>
    /// </summary>
    let ``_/TemperatureRelatedVolume`` = _prefix "/TemperatureRelatedVolume"
    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureVariance
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureVariance"></see></summary>
    let ``_/TemperatureVariance`` = _prefix "/TemperatureVariance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureVariance_NEON"></see>
    /// </summary>
    let ``_/TemperatureVariance_NEON`` = _prefix "/TemperatureVariance_NEON"
    /// <summary>
    /// Applicable units are those of quantitykind:TemporalSummationFunction
    /// <see href="http://qudt.org/vocab/quantitykind/TemporalSummationFunction"></see></summary>
    let ``_/TemporalSummationFunction`` = _prefix "/TemporalSummationFunction"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Tension"></see></summary>
    let ``_/Tension`` = _prefix "/Tension"
    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalAdmittance"></see></summary>
    let ``_/ThermalAdmittance`` = _prefix "/ThermalAdmittance"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalCapacitance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalCapacitance"></see></summary>
    let ``_/ThermalCapacitance`` = _prefix "/ThermalCapacitance"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThermalCoefficientOfLinearExpansion"></see>
    /// </summary>
    let ``_/ThermalCoefficientOfLinearExpansion`` =
        _prefix "/ThermalCoefficientOfLinearExpansion"

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalConductance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalConductance"></see></summary>
    let ``_/ThermalConductance`` = _prefix "/ThermalConductance"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalConductivity"></see></summary>
    let ``_/ThermalConductivity`` = _prefix "/ThermalConductivity"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalDiffusionFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusionFactor"></see></summary>
    let ``_/ThermalDiffusionFactor`` = _prefix "/ThermalDiffusionFactor"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalDiffusionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusionRatio"></see></summary>
    let ``_/ThermalDiffusionRatio`` = _prefix "/ThermalDiffusionRatio"

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalDiffusionRatioCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusionRatioCoefficient"></see></summary>
    let ``_/ThermalDiffusionRatioCoefficient`` =
        _prefix "/ThermalDiffusionRatioCoefficient"

    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusivity"></see></summary>
    let ``_/ThermalDiffusivity`` = _prefix "/ThermalDiffusivity"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalEfficiency"></see></summary>
    let ``_/ThermalEfficiency`` = _prefix "/ThermalEfficiency"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalEnergyLength
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalEnergyLength"></see></summary>
    let ``_/ThermalEnergyLength`` = _prefix "/ThermalEnergyLength"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalExpansionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalExpansionCoefficient"></see></summary>
    let ``_/ThermalExpansionCoefficient`` = _prefix "/ThermalExpansionCoefficient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThermalInertia"></see>
    /// </summary>
    let ``_/ThermalInertia`` = _prefix "/ThermalInertia"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalInsulance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalInsulance"></see></summary>
    let ``_/ThermalInsulance`` = _prefix "/ThermalInsulance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThermalInsulation"></see>
    /// </summary>
    let ``_/ThermalInsulation`` = _prefix "/ThermalInsulation"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalResistance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalResistance"></see></summary>
    let ``_/ThermalResistance`` = _prefix "/ThermalResistance"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalResistivity
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalResistivity"></see></summary>
    let ``_/ThermalResistivity`` = _prefix "/ThermalResistivity"
    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalTransmittance"></see></summary>
    let ``_/ThermalTransmittance`` = _prefix "/ThermalTransmittance"
    /// <summary>
    /// Applicable units are those of quantitykind:ThermalUtilizationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalUtilizationFactor"></see></summary>
    let ``_/ThermalUtilizationFactor`` = _prefix "/ThermalUtilizationFactor"

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalUtilizationFactorForFission"></see></summary>
    let ``_/ThermalUtilizationFactorForFission`` =
        _prefix "/ThermalUtilizationFactorForFission"

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicCriticalMagneticFluxDensity"></see></summary>
    let ``_/ThermodynamicCriticalMagneticFluxDensity`` =
        _prefix "/ThermodynamicCriticalMagneticFluxDensity"

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicEntropy"></see></summary>
    let ``_/ThermodynamicEntropy`` = _prefix "/ThermodynamicEntropy"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Thickness"></see></summary>
    let ``_/Thickness`` = _prefix "/Thickness"
    /// <summary>
    /// Applicable units are those of quantitykind:ThomsonCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ThomsonCoefficient"></see></summary>
    let ``_/ThomsonCoefficient`` = _prefix "/ThomsonCoefficient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThrustCoefficient"></see>
    /// </summary>
    let ``_/ThrustCoefficient`` = _prefix "/ThrustCoefficient"
    /// <summary>
    /// Applicable units are those of quantitykind:ThrustToMassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThrustToMassRatio"></see></summary>
    let ``_/ThrustToMassRatio`` = _prefix "/ThrustToMassRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThrustToWeightRatio"></see></summary>
    let ``_/ThrustToWeightRatio`` = _prefix "/ThrustToWeightRatio"

    /// <summary>
    /// Applicable units are those of quantitykind:ThrusterPowerToThrustEfficiency
    /// <see href="http://qudt.org/vocab/quantitykind/ThrusterPowerToThrustEfficiency"></see></summary>
    let ``_/ThrusterPowerToThrustEfficiency`` =
        _prefix "/ThrusterPowerToThrustEfficiency"

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/Tilt"></see></summary>
    let ``_/Tilt`` = _prefix "/Tilt"
    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/TimeAveragedSoundIntensity"></see></summary>
    let ``_/TimeAveragedSoundIntensity`` = _prefix "/TimeAveragedSoundIntensity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TimeConstant_Inductance"></see>
    /// </summary>
    let ``_/TimeConstant_Inductance`` = _prefix "/TimeConstant_Inductance"
    /// <summary>
    /// Applicable units are those of quantitykind:TimePerCount
    /// <see href="http://qudt.org/vocab/quantitykind/TimePerCount"></see></summary>
    let ``_/TimePerCount`` = _prefix "/TimePerCount"
    /// <summary>
    /// Applicable units are those of quantitykind:TimeRatio
    /// <see href="http://qudt.org/vocab/quantitykind/TimeRatio"></see></summary>
    let ``_/TimeRatio`` = _prefix "/TimeRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TimeRelatedLogarithmicRatio"></see>
    /// </summary>
    let ``_/TimeRelatedLogarithmicRatio`` = _prefix "/TimeRelatedLogarithmicRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Time_Squared"></see>
    /// </summary>
    let ``_/Time_Squared`` = _prefix "/Time_Squared"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TorqueConstant"></see>
    /// </summary>
    let ``_/TorqueConstant`` = _prefix "/TorqueConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:TorquePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/TorquePerLength"></see></summary>
    let ``_/TorquePerLength`` = _prefix "/TorquePerLength"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TorsionalRigidity"></see>
    /// </summary>
    let ``_/TorsionalRigidity`` = _prefix "/TorsionalRigidity"
    /// <summary>
    /// Applicable units are those of quantitykind:TorsionalSpringConstant
    /// <see href="http://qudt.org/vocab/quantitykind/TorsionalSpringConstant"></see></summary>
    let ``_/TorsionalSpringConstant`` = _prefix "/TorsionalSpringConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/TotalAngularMomentum"></see></summary>
    let ``_/TotalAngularMomentum`` = _prefix "/TotalAngularMomentum"

    /// <summary>
    /// Applicable units are those of quantitykind:TotalAngularMomentumQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/TotalAngularMomentumQuantumNumber"></see></summary>
    let ``_/TotalAngularMomentumQuantumNumber`` =
        _prefix "/TotalAngularMomentumQuantumNumber"

    /// <summary>
    /// Applicable units are those of quantitykind:TotalAtomicStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/TotalAtomicStoppingPower"></see></summary>
    let ``_/TotalAtomicStoppingPower`` = _prefix "/TotalAtomicStoppingPower"
    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/TotalCrossSection"></see></summary>
    let ``_/TotalCrossSection`` = _prefix "/TotalCrossSection"
    /// <summary>
    /// Applicable units are those of quantitykind:TotalCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/TotalCurrent"></see></summary>
    let ``_/TotalCurrent`` = _prefix "/TotalCurrent"
    /// <summary>
    /// Applicable units are those of quantitykind:TotalCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/TotalCurrentDensity"></see></summary>
    let ``_/TotalCurrentDensity`` = _prefix "/TotalCurrentDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:TotalIonization
    /// <see href="http://qudt.org/vocab/quantitykind/TotalIonization"></see></summary>
    let ``_/TotalIonization`` = _prefix "/TotalIonization"
    /// <summary>
    /// Applicable units are those of quantitykind:TotalLinearStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/TotalLinearStoppingPower"></see></summary>
    let ``_/TotalLinearStoppingPower`` = _prefix "/TotalLinearStoppingPower"
    /// <summary>
    /// Applicable units are those of quantitykind:TotalMassStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/TotalMassStoppingPower"></see></summary>
    let ``_/TotalMassStoppingPower`` = _prefix "/TotalMassStoppingPower"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/TotalPressure"></see></summary>
    let ``_/TotalPressure`` = _prefix "/TotalPressure"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TotalRadiance"></see>
    /// </summary>
    let ``_/TotalRadiance`` = _prefix "/TotalRadiance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TouchThresholds"></see>
    /// </summary>
    let ``_/TouchThresholds`` = _prefix "/TouchThresholds"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TrafficIntensity"></see>
    /// </summary>
    let ``_/TrafficIntensity`` = _prefix "/TrafficIntensity"

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TransmissionRatioBetweenRotationAndTranslation"></see>
    /// </summary>
    let ``_/TransmissionRatioBetweenRotationAndTranslation`` =
        _prefix "/TransmissionRatioBetweenRotationAndTranslation"

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Transmittance"></see></summary>
    let ``_/Transmittance`` = _prefix "/Transmittance"
    /// <summary>
    /// Applicable units are those of quantitykind:TransmittanceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/TransmittanceDensity"></see></summary>
    let ``_/TransmittanceDensity`` = _prefix "/TransmittanceDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/TrueExhaustVelocity"></see></summary>
    let ``_/TrueExhaustVelocity`` = _prefix "/TrueExhaustVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:Turbidity
    /// <see href="http://qudt.org/vocab/quantitykind/Turbidity"></see></summary>
    let ``_/Turbidity`` = _prefix "/Turbidity"
    /// <summary>
    /// Applicable units are those of quantitykind:Turns
    /// <see href="http://qudt.org/vocab/quantitykind/Turns"></see></summary>
    let ``_/Turns`` = _prefix "/Turns"
    /// <summary>
    /// Applicable units are those of quantitykind:Unbalance
    /// <see href="http://qudt.org/vocab/quantitykind/Unbalance"></see></summary>
    let ``_/Unbalance`` = _prefix "/Unbalance"
    /// <summary>
    /// Applicable units are those of quantitykind:Unknown
    /// <see href="http://qudt.org/vocab/quantitykind/Unknown"></see></summary>
    let ``_/Unknown`` = _prefix "/Unknown"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VaporPermeability"></see>
    /// </summary>
    let ``_/VaporPermeability`` = _prefix "/VaporPermeability"
    /// <summary>
    /// Applicable units are those of quantitykind:VapourPermeability
    /// <see href="http://qudt.org/vocab/quantitykind/VapourPermeability"></see></summary>
    let ``_/VapourPermeability`` = _prefix "/VapourPermeability"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VaporPermeance"></see>
    /// </summary>
    let ``_/VaporPermeance`` = _prefix "/VaporPermeance"
    /// <summary>
    /// Applicable units are those of quantitykind:VapourPermeance
    /// <see href="http://qudt.org/vocab/quantitykind/VapourPermeance"></see></summary>
    let ``_/VapourPermeance`` = _prefix "/VapourPermeance"
    /// <summary>
    /// Applicable units are those of quantitykind:VaporPressure
    /// <see href="http://qudt.org/vocab/quantitykind/VaporPressure"></see></summary>
    let ``_/VaporPressure`` = _prefix "/VaporPressure"
    /// <summary>
    /// Applicable units are those of quantitykind:VentilationRatePerFloorArea
    /// <see href="http://qudt.org/vocab/quantitykind/VentilationRatePerFloorArea"></see></summary>
    let ``_/VentilationRatePerFloorArea`` = _prefix "/VentilationRatePerFloorArea"
    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/VerticalVelocity"></see></summary>
    let ``_/VerticalVelocity`` = _prefix "/VerticalVelocity"
    /// <summary>
    /// Applicable units are those of quantitykind:VideoFrameRate
    /// <see href="http://qudt.org/vocab/quantitykind/VideoFrameRate"></see></summary>
    let ``_/VideoFrameRate`` = _prefix "/VideoFrameRate"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/VisibleRadiantEnergy"></see></summary>
    let ``_/VisibleRadiantEnergy`` = _prefix "/VisibleRadiantEnergy"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VisionThresholds"></see>
    /// </summary>
    let ``_/VisionThresholds`` = _prefix "/VisionThresholds"
    /// <summary>
    /// Applicable units are those of quantitykind:VoltageRatio
    /// <see href="http://qudt.org/vocab/quantitykind/VoltageRatio"></see></summary>
    let ``_/VoltageRatio`` = _prefix "/VoltageRatio"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumeDensityOfCharge"></see>
    /// </summary>
    let ``_/VolumeDensityOfCharge`` = _prefix "/VolumeDensityOfCharge"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumePerTime
    /// <see href="http://qudt.org/vocab/quantitykind/VolumePerTime"></see></summary>
    let ``_/VolumePerTime`` = _prefix "/VolumePerTime"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumeFlowRate_SurfaceRelated"></see>
    /// </summary>
    let ``_/VolumeFlowRate_SurfaceRelated`` = _prefix "/VolumeFlowRate_SurfaceRelated"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeFlowRatio"></see></summary>
    let ``_/VolumeFlowRatio`` = _prefix "/VolumeFlowRatio"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumeFraction
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeFraction"></see></summary>
    let ``_/VolumeFraction`` = _prefix "/VolumeFraction"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumeOrSectionModulus"></see>
    /// </summary>
    let ``_/VolumeOrSectionModulus`` = _prefix "/VolumeOrSectionModulus"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/VolumePerArea"></see></summary>
    let ``_/VolumePerArea`` = _prefix "/VolumePerArea"
    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeStrain"></see></summary>
    let ``_/VolumeStrain`` = _prefix "/VolumeStrain"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumeThermalExpansion
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeThermalExpansion"></see></summary>
    let ``_/VolumeThermalExpansion`` = _prefix "/VolumeThermalExpansion"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumetricBitDensity
    /// <see href="http://qudt.org/vocab/quantitykind/VolumetricBitDensity"></see></summary>
    let ``_/VolumetricBitDensity`` = _prefix "/VolumetricBitDensity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumetricElectricCharge"></see>
    /// </summary>
    let ``_/VolumetricElectricCharge`` = _prefix "/VolumetricElectricCharge"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumetricEntityDensity"></see>
    /// </summary>
    let ``_/VolumetricEntityDensity`` = _prefix "/VolumetricEntityDensity"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumetricFlux
    /// <see href="http://qudt.org/vocab/quantitykind/VolumetricFlux"></see></summary>
    let ``_/VolumetricFlux`` = _prefix "/VolumetricFlux"
    /// <summary>
    /// Applicable units are those of quantitykind:VolumetricHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/VolumetricHeatCapacity"></see></summary>
    let ``_/VolumetricHeatCapacity`` = _prefix "/VolumetricHeatCapacity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumetricOutputPower"></see>
    /// </summary>
    let ``_/VolumetricOutputPower`` = _prefix "/VolumetricOutputPower"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumicAmountOfSubstance"></see>
    /// </summary>
    let ``_/VolumicAmountOfSubstance`` = _prefix "/VolumicAmountOfSubstance"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumicDataQuantity"></see>
    /// </summary>
    let ``_/VolumicDataQuantity`` = _prefix "/VolumicDataQuantity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumicOutput"></see>
    /// </summary>
    let ``_/VolumicOutput`` = _prefix "/VolumicOutput"
    /// <summary>
    /// Applicable units are those of quantitykind:AngularVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/Vorticity"></see></summary>
    let ``_/Vorticity`` = _prefix "/Vorticity"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/WarmReceptorThreshold"></see>
    /// </summary>
    let ``_/WarmReceptorThreshold`` = _prefix "/WarmReceptorThreshold"
    /// <summary>
    /// Applicable units are those of quantitykind:WarpingConstant
    /// <see href="http://qudt.org/vocab/quantitykind/WarpingConstant"></see></summary>
    let ``_/WarpingConstant`` = _prefix "/WarpingConstant"
    /// <summary>
    /// Applicable units are those of quantitykind:WarpingMoment
    /// <see href="http://qudt.org/vocab/quantitykind/WarpingMoment"></see></summary>
    let ``_/WarpingMoment`` = _prefix "/WarpingMoment"
    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/WaterHorsepower"></see></summary>
    let ``_/WaterHorsepower`` = _prefix "/WaterHorsepower"
    /// <summary>
    /// Applicable units are those of quantitykind:WaterVaporDiffusionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/WaterVaporDiffusionCoefficient"></see></summary>
    let ``_/WaterVaporDiffusionCoefficient`` = _prefix "/WaterVaporDiffusionCoefficient"
    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/WaterVapourPermeability"></see>
    /// </summary>
    let ``_/WaterVapourPermeability`` = _prefix "/WaterVapourPermeability"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Wavelength"></see></summary>
    let ``_/Wavelength`` = _prefix "/Wavelength"
    /// <summary>
    /// Applicable units are those of quantitykind:InverseLength
    /// <see href="http://qudt.org/vocab/quantitykind/Wavenumber"></see></summary>
    let ``_/Wavenumber`` = _prefix "/Wavenumber"
    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/WebTime"></see></summary>
    let ``_/WebTime`` = _prefix "/WebTime"
    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/WebTimeAveragePressure"></see></summary>
    let ``_/WebTimeAveragePressure`` = _prefix "/WebTimeAveragePressure"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// Web Time Avg Thrust (Mlbf)
    /// <see href="http://qudt.org/vocab/quantitykind/WebTimeAverageThrust"></see></summary>
    let ``_/WebTimeAverageThrust`` = _prefix "/WebTimeAverageThrust"
    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Weight"></see></summary>
    let ``_/Weight`` = _prefix "/Weight"
    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/WetBulbTemperature"></see></summary>
    let ``_/WetBulbTemperature`` = _prefix "/WetBulbTemperature"
    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Width"></see></summary>
    let ``_/Width`` = _prefix "/Width"
    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/WorkFunction"></see></summary>
    let ``_/WorkFunction`` = _prefix "/WorkFunction"
