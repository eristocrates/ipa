namespace http.qudt.org.vocab.quantitykind.bare

open DoxAletheia.Rdf_Vocabulary

module qudt_quantitykind =
    let _namespace_name = "http://qudt.org/vocab/quantitykind"

    /// <summary>
    /// Applicable units are those of quantitykind:APIGravity
    /// <see href="http://qudt.org/vocab/quantitykind/APIGravity"></see></summary>
    let ``_/APIGravity`` =
        Namespaced_IRI.parse _namespace_name "/APIGravity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/DimensionlessRatio"></see></summary>
    let ``_/DimensionlessRatio`` =
        Namespaced_IRI.parse _namespace_name "/DimensionlessRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AbsoluteActivity
    /// <see href="http://qudt.org/vocab/quantitykind/AbsoluteActivity"></see></summary>
    let ``_/AbsoluteActivity`` =
        Namespaced_IRI.parse _namespace_name "/AbsoluteActivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseVolume
    /// <see href="http://qudt.org/vocab/quantitykind/InverseVolume"></see></summary>
    let ``_/InverseVolume`` =
        Namespaced_IRI.parse _namespace_name "/InverseVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/AbsoluteHumidity"></see></summary>
    let ``_/AbsoluteHumidity`` =
        Namespaced_IRI.parse _namespace_name "/AbsoluteHumidity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativeHumidity
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeHumidity"></see></summary>
    let ``_/RelativeHumidity`` =
        Namespaced_IRI.parse _namespace_name "/RelativeHumidity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/Density"></see></summary>
    let ``_/Density`` =
        Namespaced_IRI.parse _namespace_name "/Density" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/AbsoluteTypographicMeasurement"></see></summary>
    let ``_/AbsoluteTypographicMeasurement`` =
        Namespaced_IRI.parse _namespace_name "/AbsoluteTypographicMeasurement" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Length"></see></summary>
    let ``_/Length`` = Namespaced_IRI.parse _namespace_name "/Length" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AbsorbedDose
    /// Note that the absorbed dose is not a good indicator of the likely biological effect. 1 Gy of alpha radiation would be much more biologically damaging than 1 Gy of photon radiation for example. Appropriate weighting factors can be applied reflecting the different relative biological effects to find the equivalent dose. The risk of stoctic effects due to radiation exposure can be quantified using the effective dose, which is a weighted average of the equivalent dose to each organ depending upon its radiosensitivity. When ionising radiation is used to treat cancer, the doctor will usually prescribe the radiotherapy treatment in Gy. When risk from ionising radiation is being discussed, a related unit, the Sievert is used.
    /// <see href="http://qudt.org/vocab/quantitykind/AbsorbedDose"></see></summary>
    let ``_/AbsorbedDose`` =
        Namespaced_IRI.parse _namespace_name "/AbsorbedDose" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEnergy"></see></summary>
    let ``_/SpecificEnergy`` =
        Namespaced_IRI.parse _namespace_name "/SpecificEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AbsorbedDoseRate
    /// <see href="http://qudt.org/vocab/quantitykind/AbsorbedDoseRate"></see></summary>
    let ``_/AbsorbedDoseRate`` =
        Namespaced_IRI.parse _namespace_name "/AbsorbedDoseRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Absorptance
    /// <see href="http://qudt.org/vocab/quantitykind/Absorptance"></see></summary>
    let ``_/Absorptance`` =
        Namespaced_IRI.parse _namespace_name "/Absorptance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Acceleration
    /// <see href="http://qudt.org/vocab/quantitykind/Acceleration"></see></summary>
    let ``_/Acceleration`` =
        Namespaced_IRI.parse _namespace_name "/Acceleration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearAcceleration
    /// <see href="http://qudt.org/vocab/quantitykind/LinearAcceleration"></see></summary>
    let ``_/LinearAcceleration`` =
        Namespaced_IRI.parse _namespace_name "/LinearAcceleration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Acceleration
    /// <see href="http://qudt.org/vocab/quantitykind/AccelerationOfGravity"></see></summary>
    let ``_/AccelerationOfGravity`` =
        Namespaced_IRI.parse _namespace_name "/AccelerationOfGravity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/AcceptorDensity"></see></summary>
    let ``_/AcceptorDensity`` =
        Namespaced_IRI.parse _namespace_name "/AcceptorDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/NumberDensity"></see></summary>
    let ``_/NumberDensity`` =
        Namespaced_IRI.parse _namespace_name "/NumberDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AcceptorIonizationEnergy"></see></summary>
    let ``_/AcceptorIonizationEnergy`` =
        Namespaced_IRI.parse _namespace_name "/AcceptorIonizationEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/IonizationEnergy"></see></summary>
    let ``_/IonizationEnergy`` =
        Namespaced_IRI.parse _namespace_name "/IonizationEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/DonorIonizationEnergy"></see></summary>
    let ``_/DonorIonizationEnergy`` =
        Namespaced_IRI.parse _namespace_name "/DonorIonizationEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Acidity
    /// <see href="http://qudt.org/vocab/quantitykind/Acidity"></see></summary>
    let ``_/Acidity`` =
        Namespaced_IRI.parse _namespace_name "/Acidity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Basicity
    /// <see href="http://qudt.org/vocab/quantitykind/Basicity"></see></summary>
    let ``_/Basicity`` =
        Namespaced_IRI.parse _namespace_name "/Basicity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AcousticImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/AcousticImpedance"></see></summary>
    let ``_/AcousticImpedance`` =
        Namespaced_IRI.parse _namespace_name "/AcousticImpedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerAreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerAreaTime"></see></summary>
    let ``_/MassPerAreaTime`` =
        Namespaced_IRI.parse _namespace_name "/MassPerAreaTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Action
    /// <see href="http://qudt.org/vocab/quantitykind/Action"></see></summary>
    let ``_/Action`` = Namespaced_IRI.parse _namespace_name "/Action" |> NamespacedName

    /// <summary>
    /// Action Time (sec)
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/ActionTime"></see></summary>
    let ``_/ActionTime`` =
        Namespaced_IRI.parse _namespace_name "/ActionTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/Time"></see></summary>
    let ``_/Time`` = Namespaced_IRI.parse _namespace_name "/Time" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ActiveEnergy"></see></summary>
    let ``_/ActiveEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ActiveEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/InstantaneousPower"></see></summary>
    let ``_/InstantaneousPower`` =
        Namespaced_IRI.parse _namespace_name "/InstantaneousPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/Energy"></see></summary>
    let ``_/Energy`` = Namespaced_IRI.parse _namespace_name "/Energy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/ActivePower"></see></summary>
    let ``_/ActivePower`` =
        Namespaced_IRI.parse _namespace_name "/ActivePower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPower"></see></summary>
    let ``_/ElectricPower`` =
        Namespaced_IRI.parse _namespace_name "/ElectricPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Activity
    /// <see href="http://qudt.org/vocab/quantitykind/Activity"></see></summary>
    let ``_/Activity`` =
        Namespaced_IRI.parse _namespace_name "/Activity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/StochasticProcess"></see></summary>
    let ``_/StochasticProcess`` =
        Namespaced_IRI.parse _namespace_name "/StochasticProcess" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ActivityCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ActivityCoefficient"></see></summary>
    let ``_/ActivityCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/ActivityCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ActivityConcentration
    /// <see href="http://qudt.org/vocab/quantitykind/ActivityConcentration"></see></summary>
    let ``_/ActivityConcentration`` =
        Namespaced_IRI.parse _namespace_name "/ActivityConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassicActivity
    /// <see href="http://qudt.org/vocab/quantitykind/ActivityRelatedByMass"></see></summary>
    let ``_/ActivityRelatedByMass`` =
        Namespaced_IRI.parse _namespace_name "/ActivityRelatedByMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassicActivity
    /// <see href="http://qudt.org/vocab/quantitykind/MassicActivity"></see></summary>
    let ``_/MassicActivity`` =
        Namespaced_IRI.parse _namespace_name "/MassicActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ActivityThresholds"></see>
    /// </summary>
    let ``_/ActivityThresholds`` =
        Namespaced_IRI.parse _namespace_name "/ActivityThresholds" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/Adaptation"></see></summary>
    let ``_/Adaptation`` =
        Namespaced_IRI.parse _namespace_name "/Adaptation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Admittance
    /// <see href="http://qudt.org/vocab/quantitykind/Admittance"></see></summary>
    let ``_/Admittance`` =
        Namespaced_IRI.parse _namespace_name "/Admittance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Impedance
    /// <see href="http://qudt.org/vocab/quantitykind/Impedance"></see></summary>
    let ``_/Impedance`` =
        Namespaced_IRI.parse _namespace_name "/Impedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AlphaDisintegrationEnergy"></see></summary>
    let ``_/AlphaDisintegrationEnergy`` =
        Namespaced_IRI.parse _namespace_name "/AlphaDisintegrationEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Altitude"></see></summary>
    let ``_/Altitude`` =
        Namespaced_IRI.parse _namespace_name "/Altitude" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AmbientPressure"></see></summary>
    let ``_/AmbientPressure`` =
        Namespaced_IRI.parse _namespace_name "/AmbientPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/Pressure"></see></summary>
    let ``_/Pressure`` =
        Namespaced_IRI.parse _namespace_name "/Pressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AmountOfBiologicallyActiveSubstance"></see>
    /// </summary>
    let ``_/AmountOfBiologicallyActiveSubstance`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfBiologicallyActiveSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfCloudCover
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfCloudCover"></see></summary>
    let ``_/AmountOfCloudCover`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfCloudCover" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstance"></see></summary>
    let ``_/AmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceConcentration"></see></summary>
    let ``_/AmountOfSubstanceConcentration`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstanceConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerVolume"></see></summary>
    let ``_/AmountOfSubstancePerVolume`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstancePerVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/Concentration"></see></summary>
    let ``_/Concentration`` =
        Namespaced_IRI.parse _namespace_name "/Concentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstanceFraction
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceFraction"></see></summary>
    let ``_/AmountOfSubstanceFraction`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstanceFraction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstanceIonConcentration"></see></summary>
    let ``_/AmountOfSubstanceIonConcentration`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstanceIonConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstancePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMass"></see></summary>
    let ``_/AmountOfSubstancePerMass`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstancePerMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstancePerMassPressure
    /// <see href="http://qudt.org/vocab/quantitykind/AmountOfSubstancePerMassPressure"></see></summary>
    let ``_/AmountOfSubstancePerMassPressure`` =
        Namespaced_IRI.parse _namespace_name "/AmountOfSubstancePerMassPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/Angle"></see></summary>
    let ``_/Angle`` = Namespaced_IRI.parse _namespace_name "/Angle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PlaneAngle
    /// <see href="http://qudt.org/vocab/quantitykind/PlaneAngle"></see></summary>
    let ``_/PlaneAngle`` =
        Namespaced_IRI.parse _namespace_name "/PlaneAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/AngleOfAttack"></see></summary>
    let ``_/AngleOfAttack`` =
        Namespaced_IRI.parse _namespace_name "/AngleOfAttack" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/AngleOfOpticalRotation"></see></summary>
    let ``_/AngleOfOpticalRotation`` =
        Namespaced_IRI.parse _namespace_name "/AngleOfOpticalRotation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularAcceleration
    /// <see href="http://qudt.org/vocab/quantitykind/AngularAcceleration"></see></summary>
    let ``_/AngularAcceleration`` =
        Namespaced_IRI.parse _namespace_name "/AngularAcceleration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseSquareTime
    /// <see href="http://qudt.org/vocab/quantitykind/InverseSquareTime"></see></summary>
    let ``_/InverseSquareTime`` =
        Namespaced_IRI.parse _namespace_name "/InverseSquareTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularCrossSection
    /// <see href="http://qudt.org/vocab/quantitykind/AngularCrossSection"></see></summary>
    let ``_/AngularCrossSection`` =
        Namespaced_IRI.parse _namespace_name "/AngularCrossSection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpectralCrossSection
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralCrossSection"></see></summary>
    let ``_/SpectralCrossSection`` =
        Namespaced_IRI.parse _namespace_name "/SpectralCrossSection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/AngularDistance"></see></summary>
    let ``_/AngularDistance`` =
        Namespaced_IRI.parse _namespace_name "/AngularDistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/AngularFrequency"></see></summary>
    let ``_/AngularFrequency`` =
        Namespaced_IRI.parse _namespace_name "/AngularFrequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/AngularVelocity"></see></summary>
    let ``_/AngularVelocity`` =
        Namespaced_IRI.parse _namespace_name "/AngularVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RotationalFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalFrequency"></see></summary>
    let ``_/RotationalFrequency`` =
        Namespaced_IRI.parse _namespace_name "/RotationalFrequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RotationalVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalVelocity"></see></summary>
    let ``_/RotationalVelocity`` =
        Namespaced_IRI.parse _namespace_name "/RotationalVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularImpulse
    /// <see href="http://qudt.org/vocab/quantitykind/AngularImpulse"></see></summary>
    let ``_/AngularImpulse`` =
        Namespaced_IRI.parse _namespace_name "/AngularImpulse" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/AngularMomentum"></see></summary>
    let ``_/AngularMomentum`` =
        Namespaced_IRI.parse _namespace_name "/AngularMomentum" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentumPerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/AngularMomentumPerAngle"></see></summary>
    let ``_/AngularMomentumPerAngle`` =
        Namespaced_IRI.parse _namespace_name "/AngularMomentumPerAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularReciprocalLatticeVector
    /// <see href="http://qudt.org/vocab/quantitykind/AngularReciprocalLatticeVector"></see></summary>
    let ``_/AngularReciprocalLatticeVector`` =
        Namespaced_IRI.parse _namespace_name "/AngularReciprocalLatticeVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularWavenumber
    /// <see href="http://qudt.org/vocab/quantitykind/AngularWavenumber"></see></summary>
    let ``_/AngularWavenumber`` =
        Namespaced_IRI.parse _namespace_name "/AngularWavenumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseLength
    /// <see href="http://qudt.org/vocab/quantitykind/InverseLength"></see></summary>
    let ``_/InverseLength`` =
        Namespaced_IRI.parse _namespace_name "/InverseLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ApogeeRadius"></see></summary>
    let ``_/ApogeeRadius`` =
        Namespaced_IRI.parse _namespace_name "/ApogeeRadius" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Radius"></see></summary>
    let ``_/Radius`` = Namespaced_IRI.parse _namespace_name "/Radius" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ApparentPower
    /// <see href="http://qudt.org/vocab/quantitykind/ApparentPower"></see></summary>
    let ``_/ApparentPower`` =
        Namespaced_IRI.parse _namespace_name "/ApparentPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrent"></see></summary>
    let ``_/ElectricCurrent`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Voltage
    /// <see href="http://qudt.org/vocab/quantitykind/Voltage"></see></summary>
    let ``_/Voltage`` =
        Namespaced_IRI.parse _namespace_name "/Voltage" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ApparentThermalInertia
    /// <see href="http://qudt.org/vocab/quantitykind/ApparentThermalInertia"></see></summary>
    let ``_/ApparentThermalInertia`` =
        Namespaced_IRI.parse _namespace_name "/ApparentThermalInertia" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/Area"></see></summary>
    let ``_/Area`` = Namespaced_IRI.parse _namespace_name "/Area" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaAngle
    /// <see href="http://qudt.org/vocab/quantitykind/AreaAngle"></see></summary>
    let ``_/AreaAngle`` =
        Namespaced_IRI.parse _namespace_name "/AreaAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaBitDensity
    /// <see href="http://qudt.org/vocab/quantitykind/AreaBitDensity"></see></summary>
    let ``_/AreaBitDensity`` =
        Namespaced_IRI.parse _namespace_name "/AreaBitDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreaChargeDensity"></see></summary>
    let ``_/AreaChargeDensity`` =
        Namespaced_IRI.parse _namespace_name "/AreaChargeDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargePerArea"></see></summary>
    let ``_/ElectricChargePerArea`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargePerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreaMass"></see></summary>
    let ``_/AreaMass`` =
        Namespaced_IRI.parse _namespace_name "/AreaMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerArea"></see></summary>
    let ``_/MassPerArea`` =
        Namespaced_IRI.parse _namespace_name "/MassPerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/AreaPerLength"></see></summary>
    let ``_/AreaPerLength`` =
        Namespaced_IRI.parse _namespace_name "/AreaPerLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerPower
    /// <see href="http://qudt.org/vocab/quantitykind/AreaPerPower"></see></summary>
    let ``_/AreaPerPower`` =
        Namespaced_IRI.parse _namespace_name "/AreaPerPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/AreaPerTime"></see></summary>
    let ``_/AreaPerTime`` =
        Namespaced_IRI.parse _namespace_name "/AreaPerTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaRatio
    /// <see href="http://qudt.org/vocab/quantitykind/AreaRatio"></see></summary>
    let ``_/AreaRatio`` =
        Namespaced_IRI.parse _namespace_name "/AreaRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/AreaTemperature"></see></summary>
    let ``_/AreaTemperature`` =
        Namespaced_IRI.parse _namespace_name "/AreaTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaThermalExpansion
    /// <see href="http://qudt.org/vocab/quantitykind/AreaThermalExpansion"></see></summary>
    let ``_/AreaThermalExpansion`` =
        Namespaced_IRI.parse _namespace_name "/AreaThermalExpansion" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/AreaTime"></see></summary>
    let ``_/AreaTime`` =
        Namespaced_IRI.parse _namespace_name "/AreaTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaTimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/AreaTimeTemperature"></see></summary>
    let ``_/AreaTimeTemperature`` =
        Namespaced_IRI.parse _namespace_name "/AreaTimeTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization"></see>
    /// </summary>
    let ``_/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization`` =
        Namespaced_IRI.parse _namespace_name "/AreicChargeDensityOrElectricFluxDensityOrElectricPolarization" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AreicDataVolume"></see>
    /// </summary>
    let ``_/AreicDataVolume`` =
        Namespaced_IRI.parse _namespace_name "/AreicDataVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreicEnergyFlow"></see></summary>
    let ``_/AreicEnergyFlow`` =
        Namespaced_IRI.parse _namespace_name "/AreicEnergyFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerArea"></see></summary>
    let ``_/PowerPerArea`` =
        Namespaced_IRI.parse _namespace_name "/PowerPerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreicHeatFlowRate"></see></summary>
    let ``_/AreicHeatFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/AreicHeatFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AreicMass"></see></summary>
    let ``_/AreicMass`` =
        Namespaced_IRI.parse _namespace_name "/AreicMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AreicTorque"></see>
    /// </summary>
    let ``_/AreicTorque`` =
        Namespaced_IRI.parse _namespace_name "/AreicTorque" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Asset"></see>
    /// </summary>
    let ``_/Asset`` = Namespaced_IRI.parse _namespace_name "/Asset" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AtmosphericHydroxylationRate
    /// <see href="http://qudt.org/vocab/quantitykind/AtmosphericHydroxylationRate"></see></summary>
    let ``_/AtmosphericHydroxylationRate`` =
        Namespaced_IRI.parse _namespace_name "/AtmosphericHydroxylationRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SecondOrderReactionRateConstant
    /// <see href="http://qudt.org/vocab/quantitykind/SecondOrderReactionRateConstant"></see></summary>
    let ``_/SecondOrderReactionRateConstant`` =
        Namespaced_IRI.parse _namespace_name "/SecondOrderReactionRateConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AtmosphericPressure"></see></summary>
    let ``_/AtmosphericPressure`` =
        Namespaced_IRI.parse _namespace_name "/AtmosphericPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AtomScatteringFactor
    /// <see href="http://qudt.org/vocab/quantitykind/AtomScatteringFactor"></see></summary>
    let ``_/AtomScatteringFactor`` =
        Namespaced_IRI.parse _namespace_name "/AtomScatteringFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicAttenuationCoefficient"></see></summary>
    let ``_/AtomicAttenuationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/AtomicAttenuationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarAttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MolarAttenuationCoefficient"></see></summary>
    let ``_/MolarAttenuationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/MolarAttenuationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicCharge"></see></summary>
    let ``_/AtomicCharge`` =
        Namespaced_IRI.parse _namespace_name "/AtomicCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCharge"></see></summary>
    let ``_/ElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicEnergy"></see></summary>
    let ``_/AtomicEnergy`` =
        Namespaced_IRI.parse _namespace_name "/AtomicEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicMass"></see></summary>
    let ``_/AtomicMass`` =
        Namespaced_IRI.parse _namespace_name "/AtomicMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/Mass"></see></summary>
    let ``_/Mass`` = Namespaced_IRI.parse _namespace_name "/Mass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AtomicNumber
    /// <see href="http://qudt.org/vocab/quantitykind/AtomicNumber"></see></summary>
    let ``_/AtomicNumber`` =
        Namespaced_IRI.parse _namespace_name "/AtomicNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Count
    /// <see href="http://qudt.org/vocab/quantitykind/Count"></see></summary>
    let ``_/Count`` = Namespaced_IRI.parse _namespace_name "/Count" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/AtomicStoppingPower"></see>
    /// </summary>
    let ``_/AtomicStoppingPower`` =
        Namespaced_IRI.parse _namespace_name "/AtomicStoppingPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/AttenuationCoefficient"></see></summary>
    let ``_/AttenuationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/AttenuationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundPowerLevel
    /// <see href="http://qudt.org/vocab/quantitykind/AuditoryThresholds"></see></summary>
    let ``_/AuditoryThresholds`` =
        Namespaced_IRI.parse _namespace_name "/AuditoryThresholds" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundPowerLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPowerLevel"></see></summary>
    let ``_/SoundPowerLevel`` =
        Namespaced_IRI.parse _namespace_name "/SoundPowerLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFieldStrength
    /// <see href="http://qudt.org/vocab/quantitykind/AuxillaryMagneticField"></see></summary>
    let ``_/AuxillaryMagneticField`` =
        Namespaced_IRI.parse _namespace_name "/AuxillaryMagneticField" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFieldStrength
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFieldStrength"></see></summary>
    let ``_/MagneticFieldStrength`` =
        Namespaced_IRI.parse _namespace_name "/MagneticFieldStrength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/AverageEnergyLossPerElementaryChargeProduced"></see></summary>
    let ``_/AverageEnergyLossPerElementaryChargeProduced`` =
        Namespaced_IRI.parse _namespace_name "/AverageEnergyLossPerElementaryChargeProduced" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/AverageHeadEndPressure"></see></summary>
    let ``_/AverageHeadEndPressure`` =
        Namespaced_IRI.parse _namespace_name "/AverageHeadEndPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/HeadEndPressure"></see></summary>
    let ``_/HeadEndPressure`` =
        Namespaced_IRI.parse _namespace_name "/HeadEndPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AverageLogarithmicEnergyDecrement
    /// <see href="http://qudt.org/vocab/quantitykind/AverageLogarithmicEnergyDecrement"></see></summary>
    let ``_/AverageLogarithmicEnergyDecrement`` =
        Namespaced_IRI.parse _namespace_name "/AverageLogarithmicEnergyDecrement" |> NamespacedName

    /// <summary>
    /// Avg Specific Impulse (lbf-sec/lbm)
    /// <see href="http://qudt.org/vocab/quantitykind/AverageSpecificImpulse"></see></summary>
    let ``_/AverageSpecificImpulse`` =
        Namespaced_IRI.parse _namespace_name "/AverageSpecificImpulse" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpecificImpulse"></see>
    /// </summary>
    let ``_/SpecificImpulse`` =
        Namespaced_IRI.parse _namespace_name "/SpecificImpulse" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/AverageVacuumThrust"></see></summary>
    let ``_/AverageVacuumThrust`` =
        Namespaced_IRI.parse _namespace_name "/AverageVacuumThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/VacuumThrust"></see></summary>
    let ``_/VacuumThrust`` =
        Namespaced_IRI.parse _namespace_name "/VacuumThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/Azimuth"></see></summary>
    let ``_/Azimuth`` =
        Namespaced_IRI.parse _namespace_name "/Azimuth" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BandwidthDistanceProduct"></see>
    /// </summary>
    let ``_/BandwidthDistanceProduct`` =
        Namespaced_IRI.parse _namespace_name "/BandwidthDistanceProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BandwidthLengthProduct"></see>
    /// </summary>
    let ``_/BandwidthLengthProduct`` =
        Namespaced_IRI.parse _namespace_name "/BandwidthLengthProduct" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BatteryCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/BatteryCapacity"></see></summary>
    let ``_/BatteryCapacity`` =
        Namespaced_IRI.parse _namespace_name "/BatteryCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Torque
    /// <see href="http://qudt.org/vocab/quantitykind/BendingMomentOfForce"></see></summary>
    let ``_/BendingMomentOfForce`` =
        Namespaced_IRI.parse _namespace_name "/BendingMomentOfForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Torque
    /// <see href="http://qudt.org/vocab/quantitykind/Torque"></see></summary>
    let ``_/Torque`` = Namespaced_IRI.parse _namespace_name "/Torque" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/BetaDisintegrationEnergy"></see></summary>
    let ``_/BetaDisintegrationEnergy`` =
        Namespaced_IRI.parse _namespace_name "/BetaDisintegrationEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/BevelGearPitchAngle"></see></summary>
    let ``_/BevelGearPitchAngle`` =
        Namespaced_IRI.parse _namespace_name "/BevelGearPitchAngle" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BinaryLogarithmicMedianInformationFlow"></see>
    /// </summary>
    let ``_/BinaryLogarithmicMedianInformationFlow`` =
        Namespaced_IRI.parse _namespace_name "/BinaryLogarithmicMedianInformationFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BindingFraction
    /// <see href="http://qudt.org/vocab/quantitykind/BindingFraction"></see></summary>
    let ``_/BindingFraction`` =
        Namespaced_IRI.parse _namespace_name "/BindingFraction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BioconcentrationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/BioconcentrationFactor"></see></summary>
    let ``_/BioconcentrationFactor`` =
        Namespaced_IRI.parse _namespace_name "/BioconcentrationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BiodegredationHalfLife
    /// <see href="http://qudt.org/vocab/quantitykind/BiodegredationHalfLife"></see></summary>
    let ``_/BiodegredationHalfLife`` =
        Namespaced_IRI.parse _namespace_name "/BiodegredationHalfLife" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BiogeochemicalRate
    /// <see href="http://qudt.org/vocab/quantitykind/BiogeochemicalRate"></see></summary>
    let ``_/BiogeochemicalRate`` =
        Namespaced_IRI.parse _namespace_name "/BiogeochemicalRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BitDataVolume"></see>
    /// </summary>
    let ``_/BitDataVolume`` =
        Namespaced_IRI.parse _namespace_name "/BitDataVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BitRate
    /// <see href="http://qudt.org/vocab/quantitykind/BitRate"></see></summary>
    let ``_/BitRate`` =
        Namespaced_IRI.parse _namespace_name "/BitRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BitRate
    /// <see href="http://qudt.org/vocab/quantitykind/BitTransmissionRate"></see></summary>
    let ``_/BitTransmissionRate`` =
        Namespaced_IRI.parse _namespace_name "/BitTransmissionRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BloodGlucoseLevel
    /// <see href="http://qudt.org/vocab/quantitykind/BloodGlucoseLevel"></see></summary>
    let ``_/BloodGlucoseLevel`` =
        Namespaced_IRI.parse _namespace_name "/BloodGlucoseLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassBasedBloodGlucoseLevel
    /// <see href="http://qudt.org/vocab/quantitykind/MassBasedBloodGlucoseLevel"></see></summary>
    let ``_/MassBasedBloodGlucoseLevel`` =
        Namespaced_IRI.parse _namespace_name "/MassBasedBloodGlucoseLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/BloodGlucoseLevel_Mass"></see>
    /// </summary>
    let ``_/BloodGlucoseLevel_Mass`` =
        Namespaced_IRI.parse _namespace_name "/BloodGlucoseLevel_Mass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BodyMassIndex
    /// <see href="http://qudt.org/vocab/quantitykind/BodyMassIndex"></see></summary>
    let ``_/BodyMassIndex`` =
        Namespaced_IRI.parse _namespace_name "/BodyMassIndex" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BoilingPoint
    /// <see href="http://qudt.org/vocab/quantitykind/BoilingPoint"></see></summary>
    let ``_/BoilingPoint`` =
        Namespaced_IRI.parse _namespace_name "/BoilingPoint" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/Temperature"></see></summary>
    let ``_/Temperature`` =
        Namespaced_IRI.parse _namespace_name "/Temperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/BraggAngle"></see></summary>
    let ``_/BraggAngle`` =
        Namespaced_IRI.parse _namespace_name "/BraggAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Breadth"></see></summary>
    let ``_/Breadth`` =
        Namespaced_IRI.parse _namespace_name "/Breadth" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/BucklingFactor"></see></summary>
    let ``_/BucklingFactor`` =
        Namespaced_IRI.parse _namespace_name "/BucklingFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/Dimensionless"></see></summary>
    let ``_/Dimensionless`` =
        Namespaced_IRI.parse _namespace_name "/Dimensionless" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BulkModulus
    /// <see href="http://qudt.org/vocab/quantitykind/BulkModulus"></see></summary>
    let ``_/BulkModulus`` =
        Namespaced_IRI.parse _namespace_name "/BulkModulus" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/BurgersVector"></see></summary>
    let ``_/BurgersVector`` =
        Namespaced_IRI.parse _namespace_name "/BurgersVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/BurnRate"></see></summary>
    let ``_/BurnRate`` =
        Namespaced_IRI.parse _namespace_name "/BurnRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/Velocity"></see></summary>
    let ``_/Velocity`` =
        Namespaced_IRI.parse _namespace_name "/Velocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/BurnTime"></see></summary>
    let ``_/BurnTime`` =
        Namespaced_IRI.parse _namespace_name "/BurnTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:BurstFactor
    /// <see href="http://qudt.org/vocab/quantitykind/BurstFactor"></see></summary>
    let ``_/BurstFactor`` =
        Namespaced_IRI.parse _namespace_name "/BurstFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Count
    /// <see href="http://qudt.org/vocab/quantitykind/ByteDataVolume"></see></summary>
    let ``_/ByteDataVolume`` =
        Namespaced_IRI.parse _namespace_name "/ByteDataVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ByteRate
    /// <see href="http://qudt.org/vocab/quantitykind/ByteRate"></see></summary>
    let ``_/ByteRate`` =
        Namespaced_IRI.parse _namespace_name "/ByteRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ByteRate
    /// <see href="http://qudt.org/vocab/quantitykind/ByteTransmissionRate"></see></summary>
    let ``_/ByteTransmissionRate`` =
        Namespaced_IRI.parse _namespace_name "/ByteTransmissionRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_X"></see></summary>
    let ``_/CENTER-OF-GRAVITY_X`` =
        Namespaced_IRI.parse _namespace_name "/CENTER-OF-GRAVITY_X" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CenterOfGravity_X"></see></summary>
    let ``_/CenterOfGravity_X`` =
        Namespaced_IRI.parse _namespace_name "/CenterOfGravity_X" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Y"></see></summary>
    let ``_/CENTER-OF-GRAVITY_Y`` =
        Namespaced_IRI.parse _namespace_name "/CENTER-OF-GRAVITY_Y" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CenterOfGravity_Y"></see></summary>
    let ``_/CenterOfGravity_Y`` =
        Namespaced_IRI.parse _namespace_name "/CenterOfGravity_Y" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-GRAVITY_Z"></see></summary>
    let ``_/CENTER-OF-GRAVITY_Z`` =
        Namespaced_IRI.parse _namespace_name "/CENTER-OF-GRAVITY_Z" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CenterOfGravity_Z"></see></summary>
    let ``_/CenterOfGravity_Z`` =
        Namespaced_IRI.parse _namespace_name "/CenterOfGravity_Z" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CENTER-OF-MASS"></see></summary>
    let ``_/CENTER-OF-MASS`` =
        Namespaced_IRI.parse _namespace_name "/CENTER-OF-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PositionVector"></see></summary>
    let ``_/PositionVector`` =
        Namespaced_IRI.parse _namespace_name "/PositionVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CO2Equivalent
    /// <see href="http://qudt.org/vocab/quantitykind/CO2Equivalent"></see></summary>
    let ``_/CO2Equivalent`` =
        Namespaced_IRI.parse _namespace_name "/CO2Equivalent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassEquivalent"></see></summary>
    let ``_/MassEquivalent`` =
        Namespaced_IRI.parse _namespace_name "/MassEquivalent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/CONTRACT-END-ITEM-SPECIFICATION-MASS"></see></summary>
    let ``_/CONTRACT-END-ITEM-SPECIFICATION-MASS`` =
        Namespaced_IRI.parse _namespace_name "/CONTRACT-END-ITEM-SPECIFICATION-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/CONTROL-MASS"></see></summary>
    let ``_/CONTROL-MASS`` =
        Namespaced_IRI.parse _namespace_name "/CONTROL-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CanonicalPartitionFunction
    /// <see href="http://qudt.org/vocab/quantitykind/CanonicalPartitionFunction"></see></summary>
    let ``_/CanonicalPartitionFunction`` =
        Namespaced_IRI.parse _namespace_name "/CanonicalPartitionFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Capacitance
    /// <see href="http://qudt.org/vocab/quantitykind/Capacitance"></see></summary>
    let ``_/Capacitance`` =
        Namespaced_IRI.parse _namespace_name "/Capacitance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Capacity"></see>
    /// </summary>
    let ``_/Capacity`` =
        Namespaced_IRI.parse _namespace_name "/Capacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/CarrierLifetime"></see></summary>
    let ``_/CarrierLifetime`` =
        Namespaced_IRI.parse _namespace_name "/CarrierLifetime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/CartesianArea"></see></summary>
    let ``_/CartesianArea`` =
        Namespaced_IRI.parse _namespace_name "/CartesianArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CartesianCoordinates"></see></summary>
    let ``_/CartesianCoordinates`` =
        Namespaced_IRI.parse _namespace_name "/CartesianCoordinates" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Volume
    /// <see href="http://qudt.org/vocab/quantitykind/CartesianVolume"></see></summary>
    let ``_/CartesianVolume`` =
        Namespaced_IRI.parse _namespace_name "/CartesianVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Volume
    /// <see href="http://qudt.org/vocab/quantitykind/Volume"></see></summary>
    let ``_/Volume`` = Namespaced_IRI.parse _namespace_name "/Volume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CatalyticActivity
    /// <see href="http://qudt.org/vocab/quantitykind/CatalyticActivity"></see></summary>
    let ``_/CatalyticActivity`` =
        Namespaced_IRI.parse _namespace_name "/CatalyticActivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CatalyticActivityConcentration
    /// <see href="http://qudt.org/vocab/quantitykind/CatalyticActivityConcentration"></see></summary>
    let ``_/CatalyticActivityConcentration`` =
        Namespaced_IRI.parse _namespace_name "/CatalyticActivityConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReactiveChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/CationExchangeCapacity"></see></summary>
    let ``_/CationExchangeCapacity`` =
        Namespaced_IRI.parse _namespace_name "/CationExchangeCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReactiveChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/ReactiveChargePerMass"></see></summary>
    let ``_/ReactiveChargePerMass`` =
        Namespaced_IRI.parse _namespace_name "/ReactiveChargePerMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/CelsiusTemperature"></see></summary>
    let ``_/CelsiusTemperature`` =
        Namespaced_IRI.parse _namespace_name "/CelsiusTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermodynamicTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicTemperature"></see></summary>
    let ``_/ThermodynamicTemperature`` =
        Namespaced_IRI.parse _namespace_name "/ThermodynamicTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AcousticImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/CharacteristicAcousticImpedance"></see></summary>
    let ``_/CharacteristicAcousticImpedance`` =
        Namespaced_IRI.parse _namespace_name "/CharacteristicAcousticImpedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/CharacteristicNumber"></see></summary>
    let ``_/CharacteristicNumber`` =
        Namespaced_IRI.parse _namespace_name "/CharacteristicNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/CharacteristicVelocity"></see></summary>
    let ``_/CharacteristicVelocity`` =
        Namespaced_IRI.parse _namespace_name "/CharacteristicVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ChargeNumber
    /// <see href="http://qudt.org/vocab/quantitykind/ChargeNumber"></see></summary>
    let ``_/ChargeNumber`` =
        Namespaced_IRI.parse _namespace_name "/ChargeNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ChemicalAffinity
    /// <see href="http://qudt.org/vocab/quantitykind/ChemicalAffinity"></see></summary>
    let ``_/ChemicalAffinity`` =
        Namespaced_IRI.parse _namespace_name "/ChemicalAffinity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificVolume
    /// <see href="http://qudt.org/vocab/quantitykind/ChemicalConsumptionPerMass"></see></summary>
    let ``_/ChemicalConsumptionPerMass`` =
        Namespaced_IRI.parse _namespace_name "/ChemicalConsumptionPerMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificVolume
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificVolume"></see></summary>
    let ``_/SpecificVolume`` =
        Namespaced_IRI.parse _namespace_name "/SpecificVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/ChemicalPotential"></see></summary>
    let ``_/ChemicalPotential`` =
        Namespaced_IRI.parse _namespace_name "/ChemicalPotential" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarEnergy"></see></summary>
    let ``_/MolarEnergy`` =
        Namespaced_IRI.parse _namespace_name "/MolarEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Chromaticity
    /// <see href="http://qudt.org/vocab/quantitykind/Chromaticity"></see></summary>
    let ``_/Chromaticity`` =
        Namespaced_IRI.parse _namespace_name "/Chromaticity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/Circulation"></see></summary>
    let ``_/Circulation`` =
        Namespaced_IRI.parse _namespace_name "/Circulation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ClosestApproachRadius"></see></summary>
    let ``_/ClosestApproachRadius`` =
        Namespaced_IRI.parse _namespace_name "/ClosestApproachRadius" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/CoefficientOfHeatTransfer"></see></summary>
    let ``_/CoefficientOfHeatTransfer`` =
        Namespaced_IRI.parse _namespace_name "/CoefficientOfHeatTransfer" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfPerformance
    /// <see href="http://qudt.org/vocab/quantitykind/CoefficientOfPerformance"></see></summary>
    let ``_/CoefficientOfPerformance`` =
        Namespaced_IRI.parse _namespace_name "/CoefficientOfPerformance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Coercivity
    /// <see href="http://qudt.org/vocab/quantitykind/Coercivity"></see></summary>
    let ``_/Coercivity`` =
        Namespaced_IRI.parse _namespace_name "/Coercivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/CoherenceLength"></see></summary>
    let ``_/CoherenceLength`` =
        Namespaced_IRI.parse _namespace_name "/CoherenceLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/ColdReceptorThreshold"></see></summary>
    let ``_/ColdReceptorThreshold`` =
        Namespaced_IRI.parse _namespace_name "/ColdReceptorThreshold" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CombinedNonEvaporativeHeatTransferCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/CombinedNonEvaporativeHeatTransferCoefficient"></see></summary>
    let ``_/CombinedNonEvaporativeHeatTransferCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/CombinedNonEvaporativeHeatTransferCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermodynamicTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/CombustionChamberTemperature"></see></summary>
    let ``_/CombustionChamberTemperature`` =
        Namespaced_IRI.parse _namespace_name "/CombustionChamberTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/CommonLogarithmicMedianInformationFlow"></see>
    /// </summary>
    let ``_/CommonLogarithmicMedianInformationFlow`` =
        Namespaced_IRI.parse _namespace_name "/CommonLogarithmicMedianInformationFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/ComplexFrequency_Imaginary"></see></summary>
    let ``_/ComplexFrequency_Imaginary`` =
        Namespaced_IRI.parse _namespace_name "/ComplexFrequency_Imaginary" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/Frequency"></see></summary>
    let ``_/Frequency`` =
        Namespaced_IRI.parse _namespace_name "/Frequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/ComplexFrequency_Real"></see></summary>
    let ``_/ComplexFrequency_Real`` =
        Namespaced_IRI.parse _namespace_name "/ComplexFrequency_Real" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPower
    /// <see href="http://qudt.org/vocab/quantitykind/ComplexPower"></see></summary>
    let ``_/ComplexPower`` =
        Namespaced_IRI.parse _namespace_name "/ComplexPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPhasor
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPhasor"></see></summary>
    let ``_/ElectricCurrentPhasor`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrentPhasor" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VoltagePhasor"></see>
    /// </summary>
    let ``_/VoltagePhasor`` =
        Namespaced_IRI.parse _namespace_name "/VoltagePhasor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PlaneAngle
    /// <see href="http://qudt.org/vocab/quantitykind/CompoundPlaneAngle"></see></summary>
    let ``_/CompoundPlaneAngle`` =
        Namespaced_IRI.parse _namespace_name "/CompoundPlaneAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Compressibility
    /// <see href="http://qudt.org/vocab/quantitykind/Compressibility"></see></summary>
    let ``_/Compressibility`` =
        Namespaced_IRI.parse _namespace_name "/Compressibility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/CompressibilityFactor"></see></summary>
    let ``_/CompressibilityFactor`` =
        Namespaced_IRI.parse _namespace_name "/CompressibilityFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Conductance
    /// <see href="http://qudt.org/vocab/quantitykind/Conductance"></see></summary>
    let ``_/Conductance`` =
        Namespaced_IRI.parse _namespace_name "/Conductance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ConductionSpeed
    /// <see href="http://qudt.org/vocab/quantitykind/ConductionSpeed"></see></summary>
    let ``_/ConductionSpeed`` =
        Namespaced_IRI.parse _namespace_name "/ConductionSpeed" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Speed
    /// <see href="http://qudt.org/vocab/quantitykind/Speed"></see></summary>
    let ``_/Speed`` = Namespaced_IRI.parse _namespace_name "/Speed" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/ConductiveHeatTransferRate"></see></summary>
    let ``_/ConductiveHeatTransferRate`` =
        Namespaced_IRI.parse _namespace_name "/ConductiveHeatTransferRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/HeatFlowRate"></see></summary>
    let ``_/HeatFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/HeatFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Conductivity
    /// <see href="http://qudt.org/vocab/quantitykind/Conductivity"></see></summary>
    let ``_/Conductivity`` =
        Namespaced_IRI.parse _namespace_name "/Conductivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentDensity"></see></summary>
    let ``_/ElectricCurrentDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrentDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricFieldStrength
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricFieldStrength"></see></summary>
    let ``_/ElectricFieldStrength`` =
        Namespaced_IRI.parse _namespace_name "/ElectricFieldStrength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ConductivityVariance
    /// <see href="http://qudt.org/vocab/quantitykind/ConductivityVariance"></see></summary>
    let ``_/ConductivityVariance`` =
        Namespaced_IRI.parse _namespace_name "/ConductivityVariance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ConductivityVariance_NEON"></see>
    /// </summary>
    let ``_/ConductivityVariance_NEON`` =
        Namespaced_IRI.parse _namespace_name "/ConductivityVariance_NEON" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Constringence
    /// <see href="http://qudt.org/vocab/quantitykind/Constringence"></see></summary>
    let ``_/Constringence`` =
        Namespaced_IRI.parse _namespace_name "/Constringence" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/ConvectiveHeatTransfer"></see></summary>
    let ``_/ConvectiveHeatTransfer`` =
        Namespaced_IRI.parse _namespace_name "/ConvectiveHeatTransfer" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CoolingPerformanceRatio
    /// <see href="http://qudt.org/vocab/quantitykind/CoolingPerformanceRatio"></see></summary>
    let ``_/CoolingPerformanceRatio`` =
        Namespaced_IRI.parse _namespace_name "/CoolingPerformanceRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CorrelatedColorTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/CorrelatedColorTemperature"></see></summary>
    let ``_/CorrelatedColorTemperature`` =
        Namespaced_IRI.parse _namespace_name "/CorrelatedColorTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Duv
    /// <see href="http://qudt.org/vocab/quantitykind/Duv"></see></summary>
    let ``_/Duv`` = Namespaced_IRI.parse _namespace_name "/Duv" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CostPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerArea"></see></summary>
    let ``_/CostPerArea`` =
        Namespaced_IRI.parse _namespace_name "/CostPerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CostPerEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerEnergy"></see></summary>
    let ``_/CostPerEnergy`` =
        Namespaced_IRI.parse _namespace_name "/CostPerEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CostPerMass
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerMass"></see></summary>
    let ``_/CostPerMass`` =
        Namespaced_IRI.parse _namespace_name "/CostPerMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CostPerPower
    /// <see href="http://qudt.org/vocab/quantitykind/CostPerPower"></see></summary>
    let ``_/CostPerPower`` =
        Namespaced_IRI.parse _namespace_name "/CostPerPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CountRate
    /// <see href="http://qudt.org/vocab/quantitykind/CountRate"></see></summary>
    let ``_/CountRate`` =
        Namespaced_IRI.parse _namespace_name "/CountRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CouplingFactor
    /// <see href="http://qudt.org/vocab/quantitykind/CouplingFactor"></see></summary>
    let ``_/CouplingFactor`` =
        Namespaced_IRI.parse _namespace_name "/CouplingFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/CrossSection"></see></summary>
    let ``_/CrossSection`` =
        Namespaced_IRI.parse _namespace_name "/CrossSection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/CrossSectionalArea"></see></summary>
    let ``_/CrossSectionalArea`` =
        Namespaced_IRI.parse _namespace_name "/CrossSectionalArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CubicElectricDipoleMomentPerSquareEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/CubicElectricDipoleMomentPerSquareEnergy"></see></summary>
    let ``_/CubicElectricDipoleMomentPerSquareEnergy`` =
        Namespaced_IRI.parse _namespace_name "/CubicElectricDipoleMomentPerSquareEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ExpansionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/CubicExpansionCoefficient"></see></summary>
    let ``_/CubicExpansionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/CubicExpansionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ExpansionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ExpansionRatio"></see></summary>
    let ``_/ExpansionRatio`` =
        Namespaced_IRI.parse _namespace_name "/ExpansionRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/CurieTemperature"></see></summary>
    let ``_/CurieTemperature`` =
        Namespaced_IRI.parse _namespace_name "/CurieTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/NeelTemperature"></see></summary>
    let ``_/NeelTemperature`` =
        Namespaced_IRI.parse _namespace_name "/NeelTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/SuperconductionTransitionTemperature"></see></summary>
    let ``_/SuperconductionTransitionTemperature`` =
        Namespaced_IRI.parse _namespace_name "/SuperconductionTransitionTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Currency
    /// <see href="http://qudt.org/vocab/quantitykind/Currency"></see></summary>
    let ``_/Currency`` =
        Namespaced_IRI.parse _namespace_name "/Currency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CurrencyPerFlight
    /// <see href="http://qudt.org/vocab/quantitykind/CurrencyPerFlight"></see></summary>
    let ``_/CurrencyPerFlight`` =
        Namespaced_IRI.parse _namespace_name "/CurrencyPerFlight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CurrentLinkage
    /// <see href="http://qudt.org/vocab/quantitykind/CurrentLinkage"></see></summary>
    let ``_/CurrentLinkage`` =
        Namespaced_IRI.parse _namespace_name "/CurrentLinkage" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/CurrentOfTheAmountOfSubstance"></see>
    /// </summary>
    let ``_/CurrentOfTheAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/CurrentOfTheAmountOfSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Curvature
    /// <see href="http://qudt.org/vocab/quantitykind/Curvature"></see></summary>
    let ``_/Curvature`` =
        Namespaced_IRI.parse _namespace_name "/Curvature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CurvatureFromRadius
    /// <see href="http://qudt.org/vocab/quantitykind/CurvatureFromRadius"></see></summary>
    let ``_/CurvatureFromRadius`` =
        Namespaced_IRI.parse _namespace_name "/CurvatureFromRadius" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/CutoffCurrentRating"></see>
    /// </summary>
    let ``_/CutoffCurrentRating`` =
        Namespaced_IRI.parse _namespace_name "/CutoffCurrentRating" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/CyclotronAngularFrequency"></see></summary>
    let ``_/CyclotronAngularFrequency`` =
        Namespaced_IRI.parse _namespace_name "/CyclotronAngularFrequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/DELTA-V"></see></summary>
    let ``_/DELTA-V`` =
        Namespaced_IRI.parse _namespace_name "/DELTA-V" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/DRY-MASS"></see></summary>
    let ``_/DRY-MASS`` =
        Namespaced_IRI.parse _namespace_name "/DRY-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DataRate
    /// <see href="http://qudt.org/vocab/quantitykind/DataRate"></see></summary>
    let ``_/DataRate`` =
        Namespaced_IRI.parse _namespace_name "/DataRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InformationFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/InformationFlowRate"></see></summary>
    let ``_/InformationFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/InformationFlowRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DataTransmissionRate"></see>
    /// </summary>
    let ``_/DataTransmissionRate`` =
        Namespaced_IRI.parse _namespace_name "/DataTransmissionRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DatasetOfBits
    /// <see href="http://qudt.org/vocab/quantitykind/DatasetOfBits"></see></summary>
    let ``_/DatasetOfBits`` =
        Namespaced_IRI.parse _namespace_name "/DatasetOfBits" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DatasetOfBytes"></see>
    /// </summary>
    let ``_/DatasetOfBytes`` =
        Namespaced_IRI.parse _namespace_name "/DatasetOfBytes" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Debye-WallerFactor
    /// <see href="http://qudt.org/vocab/quantitykind/Debye-WallerFactor"></see></summary>
    let ``_/Debye-WallerFactor`` =
        Namespaced_IRI.parse _namespace_name "/Debye-WallerFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/DebyeAngularFrequency"></see></summary>
    let ``_/DebyeAngularFrequency`` =
        Namespaced_IRI.parse _namespace_name "/DebyeAngularFrequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DebyeAngularWavenumber
    /// <see href="http://qudt.org/vocab/quantitykind/DebyeAngularWavenumber"></see></summary>
    let ``_/DebyeAngularWavenumber`` =
        Namespaced_IRI.parse _namespace_name "/DebyeAngularWavenumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/DebyeTemperature"></see></summary>
    let ``_/DebyeTemperature`` =
        Namespaced_IRI.parse _namespace_name "/DebyeTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DecayConstant
    /// <see href="http://qudt.org/vocab/quantitykind/DecayConstant"></see></summary>
    let ``_/DecayConstant`` =
        Namespaced_IRI.parse _namespace_name "/DecayConstant" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseTime"></see>
    /// </summary>
    let ``_/InverseTime`` =
        Namespaced_IRI.parse _namespace_name "/InverseTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DegreeOfDissociation
    /// <see href="http://qudt.org/vocab/quantitykind/DegreeOfDissociation"></see></summary>
    let ``_/DegreeOfDissociation`` =
        Namespaced_IRI.parse _namespace_name "/DegreeOfDissociation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MassDensity"></see></summary>
    let ``_/MassDensity`` =
        Namespaced_IRI.parse _namespace_name "/MassDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassDensity
    /// <see href="http://qudt.org/vocab/quantitykind/DensityInCombustionChamber"></see></summary>
    let ``_/DensityInCombustionChamber`` =
        Namespaced_IRI.parse _namespace_name "/DensityInCombustionChamber" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DensityOfStates"></see>
    /// </summary>
    let ``_/DensityOfStates`` =
        Namespaced_IRI.parse _namespace_name "/DensityOfStates" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VibrationalDensityOfStates
    /// <see href="http://qudt.org/vocab/quantitykind/VibrationalDensityOfStates"></see></summary>
    let ``_/VibrationalDensityOfStates`` =
        Namespaced_IRI.parse _namespace_name "/VibrationalDensityOfStates" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/DensityOfTheExhaustGases"></see></summary>
    let ``_/DensityOfTheExhaustGases`` =
        Namespaced_IRI.parse _namespace_name "/DensityOfTheExhaustGases" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Depth"></see></summary>
    let ``_/Depth`` = Namespaced_IRI.parse _namespace_name "/Depth" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/DewPointTemperature"></see></summary>
    let ``_/DewPointTemperature`` =
        Namespaced_IRI.parse _namespace_name "/DewPointTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Diameter"></see></summary>
    let ``_/Diameter`` =
        Namespaced_IRI.parse _namespace_name "/Diameter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/DiastolicBloodPressure"></see></summary>
    let ``_/DiastolicBloodPressure`` =
        Namespaced_IRI.parse _namespace_name "/DiastolicBloodPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SystolicBloodPressure"></see></summary>
    let ``_/SystolicBloodPressure`` =
        Namespaced_IRI.parse _namespace_name "/SystolicBloodPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionArea"></see></summary>
    let ``_/DiffusionArea`` =
        Namespaced_IRI.parse _namespace_name "/DiffusionArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DiffusionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionCoefficient"></see></summary>
    let ``_/DiffusionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/DiffusionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionCoefficientForFluenceRate"></see></summary>
    let ``_/DiffusionCoefficientForFluenceRate`` =
        Namespaced_IRI.parse _namespace_name "/DiffusionCoefficientForFluenceRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/DiffusionLength"></see></summary>
    let ``_/DiffusionLength`` =
        Namespaced_IRI.parse _namespace_name "/DiffusionLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DigitRate
    /// <see href="http://qudt.org/vocab/quantitykind/DigitRate"></see></summary>
    let ``_/DigitRate`` =
        Namespaced_IRI.parse _namespace_name "/DigitRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Displacement"></see></summary>
    let ``_/Displacement`` =
        Namespaced_IRI.parse _namespace_name "/Displacement" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DisplacementCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/DisplacementCurrent"></see></summary>
    let ``_/DisplacementCurrent`` =
        Namespaced_IRI.parse _namespace_name "/DisplacementCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricFluxDensity"></see></summary>
    let ``_/ElectricFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DisplacementCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/DisplacementCurrentDensity"></see></summary>
    let ``_/DisplacementCurrentDensity`` =
        Namespaced_IRI.parse _namespace_name "/DisplacementCurrentDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/DisplacementVectorOfIon"></see></summary>
    let ``_/DisplacementVectorOfIon`` =
        Namespaced_IRI.parse _namespace_name "/DisplacementVectorOfIon" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dissipance
    /// <see href="http://qudt.org/vocab/quantitykind/Dissipance"></see></summary>
    let ``_/Dissipance`` =
        Namespaced_IRI.parse _namespace_name "/Dissipance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Distance
    /// <see href="http://qudt.org/vocab/quantitykind/Distance"></see></summary>
    let ``_/Distance`` =
        Namespaced_IRI.parse _namespace_name "/Distance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Distance
    /// <see href="http://qudt.org/vocab/quantitykind/DistanceTraveledDuringBurn"></see></summary>
    let ``_/DistanceTraveledDuringBurn`` =
        Namespaced_IRI.parse _namespace_name "/DistanceTraveledDuringBurn" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/DonorDensity"></see></summary>
    let ``_/DonorDensity`` =
        Namespaced_IRI.parse _namespace_name "/DonorDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DoseEquivalent
    /// <see href="http://qudt.org/vocab/quantitykind/DoseEquivalent"></see></summary>
    let ``_/DoseEquivalent`` =
        Namespaced_IRI.parse _namespace_name "/DoseEquivalent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DoseEquivalentQualityFactor
    /// <see href="http://qudt.org/vocab/quantitykind/DoseEquivalentQualityFactor"></see></summary>
    let ``_/DoseEquivalentQualityFactor`` =
        Namespaced_IRI.parse _namespace_name "/DoseEquivalentQualityFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/DoseEquivalentRate"></see>
    /// </summary>
    let ``_/DoseEquivalentRate`` =
        Namespaced_IRI.parse _namespace_name "/DoseEquivalentRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DotsPerInch
    /// <see href="http://qudt.org/vocab/quantitykind/DotsPerInch"></see></summary>
    let ``_/DotsPerInch`` =
        Namespaced_IRI.parse _namespace_name "/DotsPerInch" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/DragCoefficient"></see></summary>
    let ``_/DragCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/DragCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/DragForce"></see></summary>
    let ``_/DragForce`` =
        Namespaced_IRI.parse _namespace_name "/DragForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Force"></see></summary>
    let ``_/Force`` = Namespaced_IRI.parse _namespace_name "/Force" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/DryBulbTemperature"></see></summary>
    let ``_/DryBulbTemperature`` =
        Namespaced_IRI.parse _namespace_name "/DryBulbTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DryVolume
    /// <see href="http://qudt.org/vocab/quantitykind/DryVolume"></see></summary>
    let ``_/DryVolume`` =
        Namespaced_IRI.parse _namespace_name "/DryVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DutyCycle
    /// <see href="http://qudt.org/vocab/quantitykind/DutyCycle"></see></summary>
    let ``_/DutyCycle`` =
        Namespaced_IRI.parse _namespace_name "/DutyCycle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicFriction"></see></summary>
    let ``_/DynamicFriction`` =
        Namespaced_IRI.parse _namespace_name "/DynamicFriction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Friction"></see></summary>
    let ``_/Friction`` =
        Namespaced_IRI.parse _namespace_name "/Friction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FrictionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicFrictionCoefficient"></see></summary>
    let ``_/DynamicFrictionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/DynamicFrictionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FrictionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/FrictionCoefficient"></see></summary>
    let ``_/FrictionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/FrictionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicPressure"></see></summary>
    let ``_/DynamicPressure`` =
        Namespaced_IRI.parse _namespace_name "/DynamicPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DynamicViscosity
    /// <see href="http://qudt.org/vocab/quantitykind/DynamicViscosity"></see></summary>
    let ``_/DynamicViscosity`` =
        Namespaced_IRI.parse _namespace_name "/DynamicViscosity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Viscosity
    /// <see href="http://qudt.org/vocab/quantitykind/Viscosity"></see></summary>
    let ``_/Viscosity`` =
        Namespaced_IRI.parse _namespace_name "/Viscosity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EarthClosestApproachVehicleVelocity"></see></summary>
    let ``_/EarthClosestApproachVehicleVelocity`` =
        Namespaced_IRI.parse _namespace_name "/EarthClosestApproachVehicleVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/VehicleVelocity"></see></summary>
    let ``_/VehicleVelocity`` =
        Namespaced_IRI.parse _namespace_name "/VehicleVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EarthquakeMagnitude
    /// <see href="http://qudt.org/vocab/quantitykind/EarthquakeMagnitude"></see></summary>
    let ``_/EarthquakeMagnitude`` =
        Namespaced_IRI.parse _namespace_name "/EarthquakeMagnitude" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/EccentricityOfOrbit"></see></summary>
    let ``_/EccentricityOfOrbit`` =
        Namespaced_IRI.parse _namespace_name "/EccentricityOfOrbit" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EffectiveExhaustVelocity"></see></summary>
    let ``_/EffectiveExhaustVelocity`` =
        Namespaced_IRI.parse _namespace_name "/EffectiveExhaustVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/EffectiveMass"></see></summary>
    let ``_/EffectiveMass`` =
        Namespaced_IRI.parse _namespace_name "/EffectiveMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MultiplicationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/EffectiveMultiplicationFactor"></see></summary>
    let ``_/EffectiveMultiplicationFactor`` =
        Namespaced_IRI.parse _namespace_name "/EffectiveMultiplicationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MultiplicationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/MultiplicationFactor"></see></summary>
    let ``_/MultiplicationFactor`` =
        Namespaced_IRI.parse _namespace_name "/MultiplicationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MultiplicationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/InfiniteMultiplicationFactor"></see></summary>
    let ``_/InfiniteMultiplicationFactor`` =
        Namespaced_IRI.parse _namespace_name "/InfiniteMultiplicationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Efficiency"></see></summary>
    let ``_/Efficiency`` =
        Namespaced_IRI.parse _namespace_name "/Efficiency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EinsteinCoefficients
    /// <see href="http://qudt.org/vocab/quantitykind/EinsteinCoefficients"></see></summary>
    let ``_/EinsteinCoefficients`` =
        Namespaced_IRI.parse _namespace_name "/EinsteinCoefficients" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EinsteinTransitionProbability
    /// <see href="http://qudt.org/vocab/quantitykind/EinsteinTransitionProbability"></see></summary>
    let ``_/EinsteinTransitionProbability`` =
        Namespaced_IRI.parse _namespace_name "/EinsteinTransitionProbability" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption"></see>
    /// </summary>
    let ``_/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption`` =
        Namespaced_IRI.parse _namespace_name "/EinsteinTransitionProbabilityForSpontaneousOrInducedEmissionAndAbsorption" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeDensity"></see></summary>
    let ``_/ElectricChargeDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargeDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeSurfaceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeSurfaceDensity"></see></summary>
    let ``_/ElectricChargeSurfaceDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargeSurfaceDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeLineDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeLineDensity"></see></summary>
    let ``_/ElectricChargeLineDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargeLineDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeLinearDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeLinearDensity"></see></summary>
    let ``_/ElectricChargeLinearDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargeLinearDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargePerAmountOfSubstance"></see></summary>
    let ``_/ElectricChargePerAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargePerAmountOfSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargePerMass"></see></summary>
    let ``_/ElectricChargePerMass`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargePerMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargeVolumeDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricChargeVolumeDensity"></see></summary>
    let ``_/ElectricChargeVolumeDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricChargeVolumeDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricConductivity"></see></summary>
    let ``_/ElectricConductivity`` =
        Namespaced_IRI.parse _namespace_name "/ElectricConductivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerAngle"></see></summary>
    let ``_/ElectricCurrentPerAngle`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrentPerAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPerEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerEnergy"></see></summary>
    let ``_/ElectricCurrentPerEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrentPerEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerLength"></see></summary>
    let ``_/ElectricCurrentPerLength`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrentPerLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearElectricCurrentDensity"></see></summary>
    let ``_/LinearElectricCurrentDensity`` =
        Namespaced_IRI.parse _namespace_name "/LinearElectricCurrentDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrentPerTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricCurrentPerTemperature"></see></summary>
    let ``_/ElectricCurrentPerTemperature`` =
        Namespaced_IRI.parse _namespace_name "/ElectricCurrentPerTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricDipoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment"></see></summary>
    let ``_/ElectricDipoleMoment`` =
        Namespaced_IRI.parse _namespace_name "/ElectricDipoleMoment" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_CubicPerEnergy_Squared"></see>
    /// </summary>
    let ``_/ElectricDipoleMoment_CubicPerEnergy_Squared`` =
        Namespaced_IRI.parse _namespace_name "/ElectricDipoleMoment_CubicPerEnergy_Squared" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ElectricDipoleMoment_QuarticPerEnergy_Cubic"></see>
    /// </summary>
    let ``_/ElectricDipoleMoment_QuarticPerEnergy_Cubic`` =
        Namespaced_IRI.parse _namespace_name "/ElectricDipoleMoment_QuarticPerEnergy_Cubic" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:QuarticElectricDipoleMomentPerCubicEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/QuarticElectricDipoleMomentPerCubicEnergy"></see></summary>
    let ``_/QuarticElectricDipoleMomentPerCubicEnergy`` =
        Namespaced_IRI.parse _namespace_name "/QuarticElectricDipoleMomentPerCubicEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricDisplacement"></see></summary>
    let ``_/ElectricDisplacement`` =
        Namespaced_IRI.parse _namespace_name "/ElectricDisplacement" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricDisplacementField"></see></summary>
    let ``_/ElectricDisplacementField`` =
        Namespaced_IRI.parse _namespace_name "/ElectricDisplacementField" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricField
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricField"></see></summary>
    let ``_/ElectricField`` =
        Namespaced_IRI.parse _namespace_name "/ElectricField" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricFlux
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricFlux"></see></summary>
    let ``_/ElectricFlux`` =
        Namespaced_IRI.parse _namespace_name "/ElectricFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPolarizability
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPolarizability"></see></summary>
    let ``_/ElectricPolarizability`` =
        Namespaced_IRI.parse _namespace_name "/ElectricPolarizability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPolarization
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPolarization"></see></summary>
    let ``_/ElectricPolarization`` =
        Namespaced_IRI.parse _namespace_name "/ElectricPolarization" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPotential
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPotential"></see></summary>
    let ``_/ElectricPotential`` =
        Namespaced_IRI.parse _namespace_name "/ElectricPotential" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricPotentialDifference
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPotentialDifference"></see></summary>
    let ``_/ElectricPotentialDifference`` =
        Namespaced_IRI.parse _namespace_name "/ElectricPotentialDifference" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerElectricCharge"></see></summary>
    let ``_/EnergyPerElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/Power"></see></summary>
    let ``_/Power`` = Namespaced_IRI.parse _namespace_name "/Power" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricPropulsionPropellantMass"></see></summary>
    let ``_/ElectricPropulsionPropellantMass`` =
        Namespaced_IRI.parse _namespace_name "/ElectricPropulsionPropellantMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantMass"></see></summary>
    let ``_/PropellantMass`` =
        Namespaced_IRI.parse _namespace_name "/PropellantMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricQuadrupoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricQuadrupoleMoment"></see></summary>
    let ``_/ElectricQuadrupoleMoment`` =
        Namespaced_IRI.parse _namespace_name "/ElectricQuadrupoleMoment" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricSusceptibility
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricSusceptibility"></see></summary>
    let ``_/ElectricSusceptibility`` =
        Namespaced_IRI.parse _namespace_name "/ElectricSusceptibility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricalConductance
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricalConductance"></see></summary>
    let ``_/ElectricalConductance`` =
        Namespaced_IRI.parse _namespace_name "/ElectricalConductance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificPower
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricalPowerToMassRatio"></see></summary>
    let ``_/ElectricalPowerToMassRatio`` =
        Namespaced_IRI.parse _namespace_name "/ElectricalPowerToMassRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificPower
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificPower"></see></summary>
    let ``_/SpecificPower`` =
        Namespaced_IRI.parse _namespace_name "/SpecificPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricalResistance
    /// <see href="http://qudt.org/vocab/quantitykind/ElectricalResistance"></see></summary>
    let ``_/ElectricalResistance`` =
        Namespaced_IRI.parse _namespace_name "/ElectricalResistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectrolyticConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectrolyticConductivity"></see></summary>
    let ``_/ElectrolyticConductivity`` =
        Namespaced_IRI.parse _namespace_name "/ElectrolyticConductivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticEnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticEnergyDensity"></see></summary>
    let ``_/ElectromagneticEnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectromagneticEnergyDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumicElectromagneticEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/VolumicElectromagneticEnergy"></see></summary>
    let ``_/VolumicElectromagneticEnergy`` =
        Namespaced_IRI.parse _namespace_name "/VolumicElectromagneticEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFluxDensity"></see></summary>
    let ``_/MagneticFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/MagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticPermeability
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticPermeability"></see></summary>
    let ``_/ElectromagneticPermeability`` =
        Namespaced_IRI.parse _namespace_name "/ElectromagneticPermeability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Permeability
    /// <see href="http://qudt.org/vocab/quantitykind/Permeability"></see></summary>
    let ``_/Permeability`` =
        Namespaced_IRI.parse _namespace_name "/Permeability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticPermeabilityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticPermeabilityRatio"></see></summary>
    let ``_/ElectromagneticPermeabilityRatio`` =
        Namespaced_IRI.parse _namespace_name "/ElectromagneticPermeabilityRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectromagneticWavePhaseSpeed
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromagneticWavePhaseSpeed"></see></summary>
    let ``_/ElectromagneticWavePhaseSpeed`` =
        Namespaced_IRI.parse _namespace_name "/ElectromagneticWavePhaseSpeed" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ElectromotiveForce"></see></summary>
    let ``_/ElectromotiveForce`` =
        Namespaced_IRI.parse _namespace_name "/ElectromotiveForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronAffinity"></see></summary>
    let ``_/ElectronAffinity`` =
        Namespaced_IRI.parse _namespace_name "/ElectronAffinity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronDensity"></see></summary>
    let ``_/ElectronDensity`` =
        Namespaced_IRI.parse _namespace_name "/ElectronDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronMeanFreePath"></see></summary>
    let ``_/ElectronMeanFreePath`` =
        Namespaced_IRI.parse _namespace_name "/ElectronMeanFreePath" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mobility
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronMobility"></see></summary>
    let ``_/ElectronMobility`` =
        Namespaced_IRI.parse _namespace_name "/ElectronMobility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mobility
    /// <see href="http://qudt.org/vocab/quantitykind/Mobility"></see></summary>
    let ``_/Mobility`` =
        Namespaced_IRI.parse _namespace_name "/Mobility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ElectronRadius"></see></summary>
    let ``_/ElectronRadius`` =
        Namespaced_IRI.parse _namespace_name "/ElectronRadius" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElevationRelativeToNAP
    /// Height measurement relative to the Normaal Amsterdams Peil (NAP) (en: Amsterdam Ordnance System). Being a form of gravity related height
    /// <see href="http://qudt.org/vocab/quantitykind/ElevationRelativeToNAP"></see></summary>
    let ``_/ElevationRelativeToNAP`` =
        Namespaced_IRI.parse _namespace_name "/ElevationRelativeToNAP" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EllipticalOrbitApogeeVelocity"></see></summary>
    let ``_/EllipticalOrbitApogeeVelocity`` =
        Namespaced_IRI.parse _namespace_name "/EllipticalOrbitApogeeVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/EllipticalOrbitPerigeeVelocity"></see></summary>
    let ``_/EllipticalOrbitPerigeeVelocity`` =
        Namespaced_IRI.parse _namespace_name "/EllipticalOrbitPerigeeVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Emissivity
    /// <see href="http://qudt.org/vocab/quantitykind/Emissivity"></see></summary>
    let ``_/Emissivity`` =
        Namespaced_IRI.parse _namespace_name "/Emissivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/Enthalpy"></see></summary>
    let ``_/Enthalpy`` =
        Namespaced_IRI.parse _namespace_name "/Enthalpy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Entropy
    /// <see href="http://qudt.org/vocab/quantitykind/Entropy"></see></summary>
    let ``_/Entropy`` =
        Namespaced_IRI.parse _namespace_name "/Entropy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/GibbsEnergy"></see></summary>
    let ``_/GibbsEnergy`` =
        Namespaced_IRI.parse _namespace_name "/GibbsEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/HelmholtzEnergy"></see></summary>
    let ``_/HelmholtzEnergy`` =
        Namespaced_IRI.parse _namespace_name "/HelmholtzEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/InternalEnergy"></see></summary>
    let ``_/InternalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/InternalEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/Work"></see></summary>
    let ``_/Work`` = Namespaced_IRI.parse _namespace_name "/Work" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyContent"></see></summary>
    let ``_/EnergyContent`` =
        Namespaced_IRI.parse _namespace_name "/EnergyContent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyDensity"></see></summary>
    let ``_/EnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/EnergyDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensityOfStates
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyDensityOfStates"></see></summary>
    let ``_/EnergyDensityOfStates`` =
        Namespaced_IRI.parse _namespace_name "/EnergyDensityOfStates" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EnergyExpenditure"></see>
    /// </summary>
    let ``_/EnergyExpenditure`` =
        Namespaced_IRI.parse _namespace_name "/EnergyExpenditure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyFluence
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyFluence"></see></summary>
    let ``_/EnergyFluence`` =
        Namespaced_IRI.parse _namespace_name "/EnergyFluence" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyFluenceRate"></see></summary>
    let ``_/EnergyFluenceRate`` =
        Namespaced_IRI.parse _namespace_name "/EnergyFluenceRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyImparted"></see></summary>
    let ``_/EnergyImparted`` =
        Namespaced_IRI.parse _namespace_name "/EnergyImparted" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyInternal"></see></summary>
    let ``_/EnergyInternal`` =
        Namespaced_IRI.parse _namespace_name "/EnergyInternal" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicEnergy"></see></summary>
    let ``_/ThermodynamicEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ThermodynamicEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyKinetic"></see></summary>
    let ``_/EnergyKinetic`` =
        Namespaced_IRI.parse _namespace_name "/EnergyKinetic" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyLevel"></see></summary>
    let ``_/EnergyLevel`` =
        Namespaced_IRI.parse _namespace_name "/EnergyLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerArea"></see></summary>
    let ``_/EnergyPerArea`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerAreaElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerAreaElectricCharge"></see></summary>
    let ``_/EnergyPerAreaElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerAreaElectricCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EnergyPerMagneticFluxDensity_Squared"></see>
    /// </summary>
    let ``_/EnergyPerMagneticFluxDensity_Squared`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerMagneticFluxDensity_Squared" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerSquareMagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerSquareMagneticFluxDensity"></see></summary>
    let ``_/EnergyPerSquareMagneticFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerSquareMagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerMassAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerMassAmountOfSubstance"></see></summary>
    let ``_/EnergyPerMassAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerMassAmountOfSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/EnergyPerTemperature"></see></summary>
    let ``_/EnergyPerTemperature`` =
        Namespaced_IRI.parse _namespace_name "/EnergyPerTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Energy_Squared"></see>
    /// </summary>
    let ``_/Energy_Squared`` =
        Namespaced_IRI.parse _namespace_name "/Energy_Squared" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SquareEnergy"></see>
    /// </summary>
    let ``_/SquareEnergy`` =
        Namespaced_IRI.parse _namespace_name "/SquareEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EquilibriumConstant
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstant"></see></summary>
    let ``_/EquilibriumConstant`` =
        Namespaced_IRI.parse _namespace_name "/EquilibriumConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EquilibriumConstant
    /// The unit is unit:MOL-PER-M3 raised to the N where N is the summation of stoichiometric numbers. I don't know what to do with this.
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantOnConcentrationBasis"></see></summary>
    let ``_/EquilibriumConstantOnConcentrationBasis`` =
        Namespaced_IRI.parse _namespace_name "/EquilibriumConstantOnConcentrationBasis" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EquilibriumConstant
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantOnPressureBasis"></see></summary>
    let ``_/EquilibriumConstantOnPressureBasis`` =
        Namespaced_IRI.parse _namespace_name "/EquilibriumConstantOnPressureBasis" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnConcentration"></see>
    /// </summary>
    let ``_/EquilibriumConstantBasedOnConcentration`` =
        Namespaced_IRI.parse _namespace_name "/EquilibriumConstantBasedOnConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EquilibriumConstantBasedOnPressure"></see>
    /// </summary>
    let ``_/EquilibriumConstantBasedOnPressure`` =
        Namespaced_IRI.parse _namespace_name "/EquilibriumConstantBasedOnPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/EquilibriumPositionVectorOfIon"></see></summary>
    let ``_/EquilibriumPositionVectorOfIon`` =
        Namespaced_IRI.parse _namespace_name "/EquilibriumPositionVectorOfIon" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EquivalenceDoseOutput"></see>
    /// </summary>
    let ``_/EquivalenceDoseOutput`` =
        Namespaced_IRI.parse _namespace_name "/EquivalenceDoseOutput" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/EquivalentAbsorptionArea"></see></summary>
    let ``_/EquivalentAbsorptionArea`` =
        Namespaced_IRI.parse _namespace_name "/EquivalentAbsorptionArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/EquivalentConcentration"></see></summary>
    let ``_/EquivalentConcentration`` =
        Namespaced_IRI.parse _namespace_name "/EquivalentConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Density
    /// <see href="http://qudt.org/vocab/quantitykind/EquivalentDensity"></see></summary>
    let ``_/EquivalentDensity`` =
        Namespaced_IRI.parse _namespace_name "/EquivalentDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/Equivalent_Mass"></see></summary>
    let ``_/Equivalent_Mass`` =
        Namespaced_IRI.parse _namespace_name "/Equivalent_Mass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/Equivalent_Molar"></see></summary>
    let ``_/Equivalent_Molar`` =
        Namespaced_IRI.parse _namespace_name "/Equivalent_Molar" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/MolarEquivalent"></see></summary>
    let ``_/MolarEquivalent`` =
        Namespaced_IRI.parse _namespace_name "/MolarEquivalent" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/EvaporativeHeatTransfer"></see>
    /// </summary>
    let ``_/EvaporativeHeatTransfer`` =
        Namespaced_IRI.parse _namespace_name "/EvaporativeHeatTransfer" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EvaporativeHeatTransferCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/EvaporativeHeatTransferCoefficient"></see></summary>
    let ``_/EvaporativeHeatTransferCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/EvaporativeHeatTransferCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ExchangeIntegral
    /// <see href="http://qudt.org/vocab/quantitykind/ExchangeIntegral"></see></summary>
    let ``_/ExchangeIntegral`` =
        Namespaced_IRI.parse _namespace_name "/ExchangeIntegral" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ExhaustGasMeanMolecularWeight"></see>
    /// </summary>
    let ``_/ExhaustGasMeanMolecularWeight`` =
        Namespaced_IRI.parse _namespace_name "/ExhaustGasMeanMolecularWeight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/ExhaustGasesSpecificHeat"></see></summary>
    let ``_/ExhaustGasesSpecificHeat`` =
        Namespaced_IRI.parse _namespace_name "/ExhaustGasesSpecificHeat" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacity"></see></summary>
    let ``_/SpecificHeatCapacity`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/ExhaustStreamPower"></see></summary>
    let ``_/ExhaustStreamPower`` =
        Namespaced_IRI.parse _namespace_name "/ExhaustStreamPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/ExitPlaneCrossSectionalArea"></see></summary>
    let ``_/ExitPlaneCrossSectionalArea`` =
        Namespaced_IRI.parse _namespace_name "/ExitPlaneCrossSectionalArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ExitPlanePressure"></see></summary>
    let ``_/ExitPlanePressure`` =
        Namespaced_IRI.parse _namespace_name "/ExitPlanePressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/ExitPlaneTemperature"></see></summary>
    let ``_/ExitPlaneTemperature`` =
        Namespaced_IRI.parse _namespace_name "/ExitPlaneTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerMass
    /// <see href="http://qudt.org/vocab/quantitykind/Exposure"></see></summary>
    let ``_/Exposure`` =
        Namespaced_IRI.parse _namespace_name "/Exposure" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ExposureOfIonizingRadiation"></see>
    /// </summary>
    let ``_/ExposureOfIonizingRadiation`` =
        Namespaced_IRI.parse _namespace_name "/ExposureOfIonizingRadiation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ExposureRate
    /// <see href="http://qudt.org/vocab/quantitykind/ExposureRate"></see></summary>
    let ``_/ExposureRate`` =
        Namespaced_IRI.parse _namespace_name "/ExposureRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ExposureRateOfIonizingRadiation"></see>
    /// </summary>
    let ``_/ExposureRateOfIonizingRadiation`` =
        Namespaced_IRI.parse _namespace_name "/ExposureRateOfIonizingRadiation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ExtentOfReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ExtentOfReaction"></see></summary>
    let ``_/ExtentOfReaction`` =
        Namespaced_IRI.parse _namespace_name "/ExtentOfReaction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS"></see></summary>
    let ``_/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS`` =
        Namespaced_IRI.parse _namespace_name "/FLIGHT-PERFORMANCE-RESERVE-PROPELLANT-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/FUEL-BIAS"></see></summary>
    let ``_/FUEL-BIAS`` =
        Namespaced_IRI.parse _namespace_name "/FUEL-BIAS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/FahrenheitTemperature"></see></summary>
    let ``_/FahrenheitTemperature`` =
        Namespaced_IRI.parse _namespace_name "/FahrenheitTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/FailureRate"></see></summary>
    let ``_/FailureRate`` =
        Namespaced_IRI.parse _namespace_name "/FailureRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/Incidence"></see></summary>
    let ``_/Incidence`` =
        Namespaced_IRI.parse _namespace_name "/Incidence" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FastFissionFactor
    /// <see href="http://qudt.org/vocab/quantitykind/FastFissionFactor"></see></summary>
    let ``_/FastFissionFactor`` =
        Namespaced_IRI.parse _namespace_name "/FastFissionFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FermiAngularWavenumber
    /// <see href="http://qudt.org/vocab/quantitykind/FermiAngularWavenumber"></see></summary>
    let ``_/FermiAngularWavenumber`` =
        Namespaced_IRI.parse _namespace_name "/FermiAngularWavenumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/FermiEnergy"></see></summary>
    let ``_/FermiEnergy`` =
        Namespaced_IRI.parse _namespace_name "/FermiEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/FermiTemperature"></see></summary>
    let ``_/FermiTemperature`` =
        Namespaced_IRI.parse _namespace_name "/FermiTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/FinalOrCurrentVehicleMass"></see></summary>
    let ``_/FinalOrCurrentVehicleMass`` =
        Namespaced_IRI.parse _namespace_name "/FinalOrCurrentVehicleMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Volume
    /// <see href="http://qudt.org/vocab/quantitykind/FirstMomentOfArea"></see></summary>
    let ``_/FirstMomentOfArea`` =
        Namespaced_IRI.parse _namespace_name "/FirstMomentOfArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/FirstStageMassRatio"></see></summary>
    let ``_/FirstStageMassRatio`` =
        Namespaced_IRI.parse _namespace_name "/FirstStageMassRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/MassRatio"></see></summary>
    let ``_/MassRatio`` =
        Namespaced_IRI.parse _namespace_name "/MassRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FishBiotransformationHalfLife
    /// <see href="http://qudt.org/vocab/quantitykind/FishBiotransformationHalfLife"></see></summary>
    let ``_/FishBiotransformationHalfLife`` =
        Namespaced_IRI.parse _namespace_name "/FishBiotransformationHalfLife" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/FissionCoreRadiusToHeightRatio"></see></summary>
    let ``_/FissionCoreRadiusToHeightRatio`` =
        Namespaced_IRI.parse _namespace_name "/FissionCoreRadiusToHeightRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/FissionFuelUtilizationFactor"></see></summary>
    let ``_/FissionFuelUtilizationFactor`` =
        Namespaced_IRI.parse _namespace_name "/FissionFuelUtilizationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/FissionMultiplicationFactor"></see></summary>
    let ``_/FissionMultiplicationFactor`` =
        Namespaced_IRI.parse _namespace_name "/FissionMultiplicationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FlashPoint
    /// <see href="http://qudt.org/vocab/quantitykind/FlashPoint"></see></summary>
    let ``_/FlashPoint`` =
        Namespaced_IRI.parse _namespace_name "/FlashPoint" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/FlightPathAngle"></see></summary>
    let ``_/FlightPathAngle`` =
        Namespaced_IRI.parse _namespace_name "/FlightPathAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FloatingPointCalculationCapability
    /// <see href="http://qudt.org/vocab/quantitykind/FloatingPointCalculationCapability"></see></summary>
    let ``_/FloatingPointCalculationCapability`` =
        Namespaced_IRI.parse _namespace_name "/FloatingPointCalculationCapability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Fluidity
    /// <see href="http://qudt.org/vocab/quantitykind/Fluidity"></see></summary>
    let ``_/Fluidity`` =
        Namespaced_IRI.parse _namespace_name "/Fluidity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Flux
    /// <see href="http://qudt.org/vocab/quantitykind/Flux"></see></summary>
    let ``_/Flux`` = Namespaced_IRI.parse _namespace_name "/Flux" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ForceConstant"></see>
    /// </summary>
    let ``_/ForceConstant`` =
        Namespaced_IRI.parse _namespace_name "/ForceConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/ForceMagnitude"></see></summary>
    let ``_/ForceMagnitude`` =
        Namespaced_IRI.parse _namespace_name "/ForceMagnitude" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerAngle"></see></summary>
    let ``_/ForcePerAngle`` =
        Namespaced_IRI.parse _namespace_name "/ForcePerAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerArea"></see></summary>
    let ``_/ForcePerArea`` =
        Namespaced_IRI.parse _namespace_name "/ForcePerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerAreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerAreaTime"></see></summary>
    let ``_/ForcePerAreaTime`` =
        Namespaced_IRI.parse _namespace_name "/ForcePerAreaTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerElectricCharge"></see></summary>
    let ``_/ForcePerElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/ForcePerElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/ForcePerLength"></see></summary>
    let ``_/ForcePerLength`` =
        Namespaced_IRI.parse _namespace_name "/ForcePerLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Fugacity
    /// <see href="http://qudt.org/vocab/quantitykind/Fugacity"></see></summary>
    let ``_/Fugacity`` =
        Namespaced_IRI.parse _namespace_name "/Fugacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/FundamentalLatticeVector"></see></summary>
    let ``_/FundamentalLatticeVector`` =
        Namespaced_IRI.parse _namespace_name "/FundamentalLatticeVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/LatticeVector"></see></summary>
    let ``_/LatticeVector`` =
        Namespaced_IRI.parse _namespace_name "/LatticeVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularReciprocalLatticeVector
    /// <see href="http://qudt.org/vocab/quantitykind/FundamentalReciprocalLatticeVector"></see></summary>
    let ``_/FundamentalReciprocalLatticeVector`` =
        Namespaced_IRI.parse _namespace_name "/FundamentalReciprocalLatticeVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GFactorOfNucleus
    /// <see href="http://qudt.org/vocab/quantitykind/GFactorOfNucleus"></see></summary>
    let ``_/GFactorOfNucleus`` =
        Namespaced_IRI.parse _namespace_name "/GFactorOfNucleus" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/GROSS-LIFT-OFF-WEIGHT"></see></summary>
    let ``_/GROSS-LIFT-OFF-WEIGHT`` =
        Namespaced_IRI.parse _namespace_name "/GROSS-LIFT-OFF-WEIGHT" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Gain"></see></summary>
    let ``_/Gain`` = Namespaced_IRI.parse _namespace_name "/Gain" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/GapEnergy"></see></summary>
    let ``_/GapEnergy`` =
        Namespaced_IRI.parse _namespace_name "/GapEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/GasLeakRate"></see>
    /// </summary>
    let ``_/GasLeakRate`` =
        Namespaced_IRI.parse _namespace_name "/GasLeakRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/GaugePressure"></see></summary>
    let ``_/GaugePressure`` =
        Namespaced_IRI.parse _namespace_name "/GaugePressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GeneFamilyAbundance
    /// <see href="http://qudt.org/vocab/quantitykind/GeneFamilyAbundance"></see></summary>
    let ``_/GeneFamilyAbundance`` =
        Namespaced_IRI.parse _namespace_name "/GeneFamilyAbundance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedCoordinate
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedCoordinate"></see></summary>
    let ``_/GeneralizedCoordinate`` =
        Namespaced_IRI.parse _namespace_name "/GeneralizedCoordinate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedForce
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedForce"></see></summary>
    let ``_/GeneralizedForce`` =
        Namespaced_IRI.parse _namespace_name "/GeneralizedForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedMomentum"></see></summary>
    let ``_/GeneralizedMomentum`` =
        Namespaced_IRI.parse _namespace_name "/GeneralizedMomentum" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GeneralizedVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/GeneralizedVelocity"></see></summary>
    let ``_/GeneralizedVelocity`` =
        Namespaced_IRI.parse _namespace_name "/GeneralizedVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Gradient
    /// <see href="http://qudt.org/vocab/quantitykind/Gradient"></see></summary>
    let ``_/Gradient`` =
        Namespaced_IRI.parse _namespace_name "/Gradient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CanonicalPartitionFunction
    /// <see href="http://qudt.org/vocab/quantitykind/GrandCanonicalPartitionFunction"></see></summary>
    let ``_/GrandCanonicalPartitionFunction`` =
        Namespaced_IRI.parse _namespace_name "/GrandCanonicalPartitionFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/GravitationalAttraction"></see></summary>
    let ``_/GravitationalAttraction`` =
        Namespaced_IRI.parse _namespace_name "/GravitationalAttraction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Gravity_API"></see></summary>
    let ``_/Gravity_API`` =
        Namespaced_IRI.parse _namespace_name "/Gravity_API" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GroupSpeedOfSound
    /// <see href="http://qudt.org/vocab/quantitykind/GroupSpeedOfSound"></see></summary>
    let ``_/GroupSpeedOfSound`` =
        Namespaced_IRI.parse _namespace_name "/GroupSpeedOfSound" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Speed
    /// <see href="http://qudt.org/vocab/quantitykind/SpeedOfSound"></see></summary>
    let ``_/SpeedOfSound`` =
        Namespaced_IRI.parse _namespace_name "/SpeedOfSound" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GrowingDegreeDay
    /// <see href="http://qudt.org/vocab/quantitykind/GrowingDegreeDay"></see></summary>
    let ``_/GrowingDegreeDay`` =
        Namespaced_IRI.parse _namespace_name "/GrowingDegreeDay" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/TimeTemperature"></see></summary>
    let ``_/TimeTemperature`` =
        Namespaced_IRI.parse _namespace_name "/TimeTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/GrowingDegreeDay_Cereal"></see></summary>
    let ``_/GrowingDegreeDay_Cereal`` =
        Namespaced_IRI.parse _namespace_name "/GrowingDegreeDay_Cereal" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:GruneisenParameter
    /// <see href="http://qudt.org/vocab/quantitykind/GruneisenParameter"></see></summary>
    let ``_/GruneisenParameter`` =
        Namespaced_IRI.parse _namespace_name "/GruneisenParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/GustatoryThreshold"></see>
    /// </summary>
    let ``_/GustatoryThreshold`` =
        Namespaced_IRI.parse _namespace_name "/GustatoryThreshold" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/GyromagneticRatio"></see>
    /// </summary>
    let ``_/GyromagneticRatio`` =
        Namespaced_IRI.parse _namespace_name "/GyromagneticRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/Half-Life"></see></summary>
    let ``_/Half-Life`` =
        Namespaced_IRI.parse _namespace_name "/Half-Life" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Half-ValueThickness"></see></summary>
    let ``_/Half-ValueThickness`` =
        Namespaced_IRI.parse _namespace_name "/Half-ValueThickness" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HallCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/HallCoefficient"></see></summary>
    let ``_/HallCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/HallCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HamiltonFunction
    /// <see href="http://qudt.org/vocab/quantitykind/HamiltonFunction"></see></summary>
    let ``_/HamiltonFunction`` =
        Namespaced_IRI.parse _namespace_name "/HamiltonFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HeartRate
    /// <see href="http://qudt.org/vocab/quantitykind/HeartRate"></see></summary>
    let ``_/HeartRate`` =
        Namespaced_IRI.parse _namespace_name "/HeartRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/Heat"></see></summary>
    let ``_/Heat`` = Namespaced_IRI.parse _namespace_name "/Heat" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalEnergy"></see></summary>
    let ``_/ThermalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ThermalEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/HeatCapacity"></see></summary>
    let ``_/HeatCapacity`` =
        Namespaced_IRI.parse _namespace_name "/HeatCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/HeatCapacityRatio"></see></summary>
    let ``_/HeatCapacityRatio`` =
        Namespaced_IRI.parse _namespace_name "/HeatCapacityRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/HeatFlowRatePerArea"></see></summary>
    let ``_/HeatFlowRatePerArea`` =
        Namespaced_IRI.parse _namespace_name "/HeatFlowRatePerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/HeatFluxDensity"></see></summary>
    let ``_/HeatFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/HeatFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/HeatingValue"></see></summary>
    let ``_/HeatingValue`` =
        Namespaced_IRI.parse _namespace_name "/HeatingValue" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Height"></see></summary>
    let ``_/Height`` = Namespaced_IRI.parse _namespace_name "/Height" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HenrysLawVolatilityConstant
    /// <see href="http://qudt.org/vocab/quantitykind/HenrysLawVolatilityConstant"></see></summary>
    let ``_/HenrysLawVolatilityConstant`` =
        Namespaced_IRI.parse _namespace_name "/HenrysLawVolatilityConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/HoleDensity"></see></summary>
    let ``_/HoleDensity`` =
        Namespaced_IRI.parse _namespace_name "/HoleDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/HorizontalVelocity"></see></summary>
    let ``_/HorizontalVelocity`` =
        Namespaced_IRI.parse _namespace_name "/HorizontalVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HydraulicPermeability
    /// <see href="http://qudt.org/vocab/quantitykind/HydraulicPermeability"></see></summary>
    let ``_/HydraulicPermeability`` =
        Namespaced_IRI.parse _namespace_name "/HydraulicPermeability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HyperfineStructureQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/HyperfineStructureQuantumNumber"></see></summary>
    let ``_/HyperfineStructureQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/HyperfineStructureQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:QuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/QuantumNumber"></see></summary>
    let ``_/QuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/QuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/INERT-MASS"></see></summary>
    let ``_/INERT-MASS`` =
        Namespaced_IRI.parse _namespace_name "/INERT-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/IgnitionIntervalTime"></see></summary>
    let ``_/IgnitionIntervalTime`` =
        Namespaced_IRI.parse _namespace_name "/IgnitionIntervalTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/Illuminance"></see></summary>
    let ``_/Illuminance`` =
        Namespaced_IRI.parse _namespace_name "/Illuminance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousFluxPerArea"></see></summary>
    let ``_/LuminousFluxPerArea`` =
        Namespaced_IRI.parse _namespace_name "/LuminousFluxPerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Impulse
    /// <see href="http://qudt.org/vocab/quantitykind/Impulse"></see></summary>
    let ``_/Impulse`` =
        Namespaced_IRI.parse _namespace_name "/Impulse" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/IncidenceProportion"></see></summary>
    let ``_/IncidenceProportion`` =
        Namespaced_IRI.parse _namespace_name "/IncidenceProportion" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Incidence
    /// <see href="http://qudt.org/vocab/quantitykind/IncidenceRate"></see></summary>
    let ``_/IncidenceRate`` =
        Namespaced_IRI.parse _namespace_name "/IncidenceRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Inductance
    /// <see href="http://qudt.org/vocab/quantitykind/Inductance"></see></summary>
    let ``_/Inductance`` =
        Namespaced_IRI.parse _namespace_name "/Inductance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Inductance
    /// <see href="http://qudt.org/vocab/quantitykind/MutualInductance"></see></summary>
    let ``_/MutualInductance`` =
        Namespaced_IRI.parse _namespace_name "/MutualInductance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InductanceBasedTimeConstant"></see>
    /// </summary>
    let ``_/InductanceBasedTimeConstant`` =
        Namespaced_IRI.parse _namespace_name "/InductanceBasedTimeConstant" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContent"></see>
    /// </summary>
    let ``_/InformationContent`` =
        Namespaced_IRI.parse _namespace_name "/InformationContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase10"></see>
    /// </summary>
    let ``_/InformationContentExpressedAsALogarithmToBase10`` =
        Namespaced_IRI.parse _namespace_name "/InformationContentExpressedAsALogarithmToBase10" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBase2"></see>
    /// </summary>
    let ``_/InformationContentExpressedAsALogarithmToBase2`` =
        Namespaced_IRI.parse _namespace_name "/InformationContentExpressedAsALogarithmToBase2" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InformationContentExpressedAsALogarithmToBaseE"></see>
    /// </summary>
    let ``_/InformationContentExpressedAsALogarithmToBaseE`` =
        Namespaced_IRI.parse _namespace_name "/InformationContentExpressedAsALogarithmToBaseE" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InformationEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/InformationEntropy"></see></summary>
    let ``_/InformationEntropy`` =
        Namespaced_IRI.parse _namespace_name "/InformationEntropy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ExpansionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/InitialExpansionRatio"></see></summary>
    let ``_/InitialExpansionRatio`` =
        Namespaced_IRI.parse _namespace_name "/InitialExpansionRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/InitialNozzleThroatDiameter"></see></summary>
    let ``_/InitialNozzleThroatDiameter`` =
        Namespaced_IRI.parse _namespace_name "/InitialNozzleThroatDiameter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleThroatDiameter"></see></summary>
    let ``_/NozzleThroatDiameter`` =
        Namespaced_IRI.parse _namespace_name "/NozzleThroatDiameter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/InitialVehicleMass"></see></summary>
    let ``_/InitialVehicleMass`` =
        Namespaced_IRI.parse _namespace_name "/InitialVehicleMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/InitialVelocity"></see></summary>
    let ``_/InitialVelocity`` =
        Namespaced_IRI.parse _namespace_name "/InitialVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InternalConversionFactor
    /// <see href="http://qudt.org/vocab/quantitykind/InternalConversionFactor"></see></summary>
    let ``_/InternalConversionFactor`` =
        Namespaced_IRI.parse _namespace_name "/InternalConversionFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/IntinsicCarrierDensity"></see></summary>
    let ``_/IntinsicCarrierDensity`` =
        Namespaced_IRI.parse _namespace_name "/IntinsicCarrierDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/InverseAmountOfSubstance"></see></summary>
    let ``_/InverseAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/InverseAmountOfSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/InverseEnergy"></see></summary>
    let ``_/InverseEnergy`` =
        Namespaced_IRI.parse _namespace_name "/InverseEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseEnergy_Squared"></see>
    /// </summary>
    let ``_/InverseEnergy_Squared`` =
        Namespaced_IRI.parse _namespace_name "/InverseEnergy_Squared" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseSquareEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/InverseSquareEnergy"></see></summary>
    let ``_/InverseSquareEnergy`` =
        Namespaced_IRI.parse _namespace_name "/InverseSquareEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseLengthTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/InverseLengthTemperature"></see></summary>
    let ``_/InverseLengthTemperature`` =
        Namespaced_IRI.parse _namespace_name "/InverseLengthTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseMagneticFlux
    /// <see href="http://qudt.org/vocab/quantitykind/InverseMagneticFlux"></see></summary>
    let ``_/InverseMagneticFlux`` =
        Namespaced_IRI.parse _namespace_name "/InverseMagneticFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseMass
    /// <see href="http://qudt.org/vocab/quantitykind/InverseMass"></see></summary>
    let ``_/InverseMass`` =
        Namespaced_IRI.parse _namespace_name "/InverseMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseMass_Squared"></see>
    /// </summary>
    let ``_/InverseMass_Squared`` =
        Namespaced_IRI.parse _namespace_name "/InverseMass_Squared" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseSquareMass
    /// <see href="http://qudt.org/vocab/quantitykind/InverseSquareMass"></see></summary>
    let ``_/InverseSquareMass`` =
        Namespaced_IRI.parse _namespace_name "/InverseSquareMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InversePermittivity
    /// <see href="http://qudt.org/vocab/quantitykind/InversePermittivity"></see></summary>
    let ``_/InversePermittivity`` =
        Namespaced_IRI.parse _namespace_name "/InversePermittivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InversePressure
    /// <see href="http://qudt.org/vocab/quantitykind/InversePressure"></see></summary>
    let ``_/InversePressure`` =
        Namespaced_IRI.parse _namespace_name "/InversePressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:IsothermalCompressibility
    /// <see href="http://qudt.org/vocab/quantitykind/IsothermalCompressibility"></see></summary>
    let ``_/IsothermalCompressibility`` =
        Namespaced_IRI.parse _namespace_name "/IsothermalCompressibility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/InverseTemperature"></see></summary>
    let ``_/InverseTemperature`` =
        Namespaced_IRI.parse _namespace_name "/InverseTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseTimeTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/InverseTimeTemperature"></see></summary>
    let ``_/InverseTimeTemperature`` =
        Namespaced_IRI.parse _namespace_name "/InverseTimeTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/InverseTime_Squared"></see>
    /// </summary>
    let ``_/InverseTime_Squared`` =
        Namespaced_IRI.parse _namespace_name "/InverseTime_Squared" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseVolume
    /// <see href="http://qudt.org/vocab/quantitykind/IonConcentration"></see></summary>
    let ``_/IonConcentration`` =
        Namespaced_IRI.parse _namespace_name "/IonConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/IonDensity"></see></summary>
    let ``_/IonDensity`` =
        Namespaced_IRI.parse _namespace_name "/IonDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/IonCurrent"></see></summary>
    let ``_/IonCurrent`` =
        Namespaced_IRI.parse _namespace_name "/IonCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:IonTransportNumber
    /// <see href="http://qudt.org/vocab/quantitykind/IonTransportNumber"></see></summary>
    let ``_/IonTransportNumber`` =
        Namespaced_IRI.parse _namespace_name "/IonTransportNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/IonicCharge"></see></summary>
    let ``_/IonicCharge`` =
        Namespaced_IRI.parse _namespace_name "/IonicCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:IonicStrength
    /// <see href="http://qudt.org/vocab/quantitykind/IonicStrength"></see></summary>
    let ``_/IonicStrength`` =
        Namespaced_IRI.parse _namespace_name "/IonicStrength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Irradiance
    /// <see href="http://qudt.org/vocab/quantitykind/Irradiance"></see></summary>
    let ``_/Irradiance`` =
        Namespaced_IRI.parse _namespace_name "/Irradiance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:IsentropicCompressibility
    /// <see href="http://qudt.org/vocab/quantitykind/IsentropicCompressibility"></see></summary>
    let ``_/IsentropicCompressibility`` =
        Namespaced_IRI.parse _namespace_name "/IsentropicCompressibility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:IsentropicExponent
    /// <see href="http://qudt.org/vocab/quantitykind/IsentropicExponent"></see></summary>
    let ``_/IsentropicExponent`` =
        Namespaced_IRI.parse _namespace_name "/IsentropicExponent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificVolume
    /// <see href="http://qudt.org/vocab/quantitykind/IsothermalMoistureCapacity"></see></summary>
    let ``_/IsothermalMoistureCapacity`` =
        Namespaced_IRI.parse _namespace_name "/IsothermalMoistureCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Kerma
    /// <see href="http://qudt.org/vocab/quantitykind/Kerma"></see></summary>
    let ``_/Kerma`` = Namespaced_IRI.parse _namespace_name "/Kerma" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:KermaRate
    /// <see href="http://qudt.org/vocab/quantitykind/KermaRate"></see></summary>
    let ``_/KermaRate`` =
        Namespaced_IRI.parse _namespace_name "/KermaRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:KinematicViscosity
    /// <see href="http://qudt.org/vocab/quantitykind/KinematicViscosity"></see></summary>
    let ``_/KinematicViscosity`` =
        Namespaced_IRI.parse _namespace_name "/KinematicViscosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolecularViscosity"></see>
    /// </summary>
    let ``_/MolecularViscosity`` =
        Namespaced_IRI.parse _namespace_name "/MolecularViscosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity"></see>
    /// </summary>
    let ``_/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity`` =
        Namespaced_IRI.parse _namespace_name "/KinematicViscosityOrDiffusionConstantOrThermalDiffusivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/KineticEnergy"></see></summary>
    let ``_/KineticEnergy`` =
        Namespaced_IRI.parse _namespace_name "/KineticEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/KineticOrThermalEnergy"></see></summary>
    let ``_/KineticOrThermalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/KineticOrThermalEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LagrangeFunction
    /// <see href="http://qudt.org/vocab/quantitykind/LagrangeFunction"></see></summary>
    let ``_/LagrangeFunction`` =
        Namespaced_IRI.parse _namespace_name "/LagrangeFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Landau-GinzburgNumber
    /// <see href="http://qudt.org/vocab/quantitykind/Landau-GinzburgNumber"></see></summary>
    let ``_/Landau-GinzburgNumber`` =
        Namespaced_IRI.parse _namespace_name "/Landau-GinzburgNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LandeGFactor
    /// <see href="http://qudt.org/vocab/quantitykind/LandeGFactor"></see></summary>
    let ``_/LandeGFactor`` =
        Namespaced_IRI.parse _namespace_name "/LandeGFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularFrequency
    /// <see href="http://qudt.org/vocab/quantitykind/LarmorAngularFrequency"></see></summary>
    let ``_/LarmorAngularFrequency`` =
        Namespaced_IRI.parse _namespace_name "/LarmorAngularFrequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/LatticePlaneSpacing"></see></summary>
    let ``_/LatticePlaneSpacing`` =
        Namespaced_IRI.parse _namespace_name "/LatticePlaneSpacing" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LeakageFactor
    /// <see href="http://qudt.org/vocab/quantitykind/LeakageFactor"></see></summary>
    let ``_/LeakageFactor`` =
        Namespaced_IRI.parse _namespace_name "/LeakageFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/LengthByForce"></see></summary>
    let ``_/LengthByForce`` =
        Namespaced_IRI.parse _namespace_name "/LengthByForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/LengthEnergy"></see></summary>
    let ``_/LengthEnergy`` =
        Namespaced_IRI.parse _namespace_name "/LengthEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthMass
    /// <see href="http://qudt.org/vocab/quantitykind/LengthMass"></see></summary>
    let ``_/LengthMass`` =
        Namespaced_IRI.parse _namespace_name "/LengthMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthMolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/LengthMolarEnergy"></see></summary>
    let ``_/LengthMolarEnergy`` =
        Namespaced_IRI.parse _namespace_name "/LengthMolarEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LengthPerElectricCurrent"></see>
    /// </summary>
    let ``_/LengthPerElectricCurrent`` =
        Namespaced_IRI.parse _namespace_name "/LengthPerElectricCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LengthRatio"></see></summary>
    let ``_/LengthRatio`` =
        Namespaced_IRI.parse _namespace_name "/LengthRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/LengthTemperature"></see></summary>
    let ``_/LengthTemperature`` =
        Namespaced_IRI.parse _namespace_name "/LengthTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthTemperatureTime
    /// <see href="http://qudt.org/vocab/quantitykind/LengthTemperatureTime"></see></summary>
    let ``_/LengthTemperatureTime`` =
        Namespaced_IRI.parse _namespace_name "/LengthTemperatureTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Lethargy
    /// <see href="http://qudt.org/vocab/quantitykind/Lethargy"></see></summary>
    let ``_/Lethargy`` =
        Namespaced_IRI.parse _namespace_name "/Lethargy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LevelWidth
    /// <see href="http://qudt.org/vocab/quantitykind/LevelWidth"></see></summary>
    let ``_/LevelWidth`` =
        Namespaced_IRI.parse _namespace_name "/LevelWidth" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/LiftCoefficient"></see></summary>
    let ``_/LiftCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LiftCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/LiftForce"></see></summary>
    let ``_/LiftForce`` =
        Namespaced_IRI.parse _namespace_name "/LiftForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearAbsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LinearAbsorptionCoefficient"></see></summary>
    let ``_/LinearAbsorptionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LinearAbsorptionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearAttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LinearAttenuationCoefficient"></see></summary>
    let ``_/LinearAttenuationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LinearAttenuationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearBitDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearBitDensity"></see></summary>
    let ``_/LinearBitDensity`` =
        Namespaced_IRI.parse _namespace_name "/LinearBitDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearCompressibility
    /// <see href="http://qudt.org/vocab/quantitykind/LinearCompressibility"></see></summary>
    let ``_/LinearCompressibility`` =
        Namespaced_IRI.parse _namespace_name "/LinearCompressibility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearDensity"></see></summary>
    let ``_/LinearDensity`` =
        Namespaced_IRI.parse _namespace_name "/LinearDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LinearElectricCharge"></see>
    /// </summary>
    let ``_/LinearElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/LinearElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearElectricCurrent"></see></summary>
    let ``_/LinearElectricCurrent`` =
        Namespaced_IRI.parse _namespace_name "/LinearElectricCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearEnergyTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/LinearEnergyTransfer"></see></summary>
    let ``_/LinearEnergyTransfer`` =
        Namespaced_IRI.parse _namespace_name "/LinearEnergyTransfer" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearExpansionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LinearExpansionCoefficient"></see></summary>
    let ``_/LinearExpansionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LinearExpansionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/LinearForce"></see></summary>
    let ``_/LinearForce`` =
        Namespaced_IRI.parse _namespace_name "/LinearForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearIonization
    /// <see href="http://qudt.org/vocab/quantitykind/LinearIonization"></see></summary>
    let ``_/LinearIonization`` =
        Namespaced_IRI.parse _namespace_name "/LinearIonization" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearLogarithmicRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LinearLogarithmicRatio"></see></summary>
    let ``_/LinearLogarithmicRatio`` =
        Namespaced_IRI.parse _namespace_name "/LinearLogarithmicRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearMass
    /// <see href="http://qudt.org/vocab/quantitykind/LinearMass"></see></summary>
    let ``_/LinearMass`` =
        Namespaced_IRI.parse _namespace_name "/LinearMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/LinearMomentum"></see></summary>
    let ``_/LinearMomentum`` =
        Namespaced_IRI.parse _namespace_name "/LinearMomentum" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Momentum
    /// <see href="http://qudt.org/vocab/quantitykind/Momentum"></see></summary>
    let ``_/Momentum`` =
        Namespaced_IRI.parse _namespace_name "/Momentum" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LinearPower"></see>
    /// </summary>
    let ``_/LinearPower`` =
        Namespaced_IRI.parse _namespace_name "/LinearPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearResistance
    /// <see href="http://qudt.org/vocab/quantitykind/LinearResistance"></see></summary>
    let ``_/LinearResistance`` =
        Namespaced_IRI.parse _namespace_name "/LinearResistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/LinearStiffness"></see></summary>
    let ``_/LinearStiffness`` =
        Namespaced_IRI.parse _namespace_name "/LinearStiffness" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LengthRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LinearStrain"></see></summary>
    let ``_/LinearStrain`` =
        Namespaced_IRI.parse _namespace_name "/LinearStrain" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Strain"></see></summary>
    let ``_/Strain`` = Namespaced_IRI.parse _namespace_name "/Strain" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearThermalExpansion
    /// <see href="http://qudt.org/vocab/quantitykind/LinearThermalExpansion"></see></summary>
    let ``_/LinearThermalExpansion`` =
        Namespaced_IRI.parse _namespace_name "/LinearThermalExpansion" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearTorque
    /// <see href="http://qudt.org/vocab/quantitykind/LinearTorque"></see></summary>
    let ``_/LinearTorque`` =
        Namespaced_IRI.parse _namespace_name "/LinearTorque" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/LinearVelocity"></see></summary>
    let ``_/LinearVelocity`` =
        Namespaced_IRI.parse _namespace_name "/LinearVelocity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LinearVoltageCoefficient"></see>
    /// </summary>
    let ``_/LinearVoltageCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LinearVoltageCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicCharge"></see>
    /// </summary>
    let ``_/LineicCharge`` =
        Namespaced_IRI.parse _namespace_name "/LineicCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicDataVolume"></see>
    /// </summary>
    let ``_/LineicDataVolume`` =
        Namespaced_IRI.parse _namespace_name "/LineicDataVolume" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicLogarithmicRatio"></see>
    /// </summary>
    let ``_/LineicLogarithmicRatio`` =
        Namespaced_IRI.parse _namespace_name "/LineicLogarithmicRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicMass"></see>
    /// </summary>
    let ``_/LineicMass`` =
        Namespaced_IRI.parse _namespace_name "/LineicMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LineicPower
    /// <see href="http://qudt.org/vocab/quantitykind/LineicPower"></see></summary>
    let ``_/LineicPower`` =
        Namespaced_IRI.parse _namespace_name "/LineicPower" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicQuantity"></see>
    /// </summary>
    let ``_/LineicQuantity`` =
        Namespaced_IRI.parse _namespace_name "/LineicQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicResistance"></see>
    /// </summary>
    let ``_/LineicResistance`` =
        Namespaced_IRI.parse _namespace_name "/LineicResistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LineicResolution
    /// <see href="http://qudt.org/vocab/quantitykind/LineicResolution"></see></summary>
    let ``_/LineicResolution`` =
        Namespaced_IRI.parse _namespace_name "/LineicResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LineicTorque"></see>
    /// </summary>
    let ``_/LineicTorque`` =
        Namespaced_IRI.parse _namespace_name "/LineicTorque" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFlux
    /// <see href="http://qudt.org/vocab/quantitykind/LinkedFlux"></see></summary>
    let ``_/LinkedFlux`` =
        Namespaced_IRI.parse _namespace_name "/LinkedFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFlux
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFlux"></see></summary>
    let ``_/MagneticFlux`` =
        Namespaced_IRI.parse _namespace_name "/MagneticFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LiquidVolume
    /// <see href="http://qudt.org/vocab/quantitykind/LiquidVolume"></see></summary>
    let ``_/LiquidVolume`` =
        Namespaced_IRI.parse _namespace_name "/LiquidVolume" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Log10FrequencyInterval"></see>
    /// </summary>
    let ``_/Log10FrequencyInterval`` =
        Namespaced_IRI.parse _namespace_name "/Log10FrequencyInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Log10Ratio"></see>
    /// </summary>
    let ``_/Log10Ratio`` =
        Namespaced_IRI.parse _namespace_name "/Log10Ratio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogERatio"></see>
    /// </summary>
    let ``_/LogERatio`` =
        Namespaced_IRI.parse _namespace_name "/LogERatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LogOctanolAirPartitionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LogOctanolAirPartitionCoefficient"></see></summary>
    let ``_/LogOctanolAirPartitionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LogOctanolAirPartitionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LogOctanolWaterPartitionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LogOctanolWaterPartitionCoefficient"></see></summary>
    let ``_/LogOctanolWaterPartitionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LogOctanolWaterPartitionCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmRatioToBase10"></see>
    /// </summary>
    let ``_/LogarithmRatioToBase10`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmRatioToBase10" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmRatioToBaseE"></see>
    /// </summary>
    let ``_/LogarithmRatioToBaseE`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmRatioToBaseE" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LogarithmicFrequencyInterval
    /// <see href="http://qudt.org/vocab/quantitykind/LogarithmicFrequencyInterval"></see></summary>
    let ``_/LogarithmicFrequencyInterval`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmicFrequencyInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicFrequencyIntervalToBase10"></see>
    /// </summary>
    let ``_/LogarithmicFrequencyIntervalToBase10`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmicFrequencyIntervalToBase10" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase10"></see>
    /// </summary>
    let ``_/LogarithmicMedianInformationFlow_SourceToBase10`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmicMedianInformationFlow_SourceToBase10" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBase2"></see>
    /// </summary>
    let ``_/LogarithmicMedianInformationFlow_SourceToBase2`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmicMedianInformationFlow_SourceToBase2" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/LogarithmicMedianInformationFlow_SourceToBaseE"></see>
    /// </summary>
    let ``_/LogarithmicMedianInformationFlow_SourceToBaseE`` =
        Namespaced_IRI.parse _namespace_name "/LogarithmicMedianInformationFlow_SourceToBaseE" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/NaturalLogarithmicMedianInformationFlow"></see>
    /// </summary>
    let ``_/NaturalLogarithmicMedianInformationFlow`` =
        Namespaced_IRI.parse _namespace_name "/NaturalLogarithmicMedianInformationFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/LondonPenetrationDepth"></see></summary>
    let ``_/LondonPenetrationDepth`` =
        Namespaced_IRI.parse _namespace_name "/LondonPenetrationDepth" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Long-RangeOrderParameter
    /// <see href="http://qudt.org/vocab/quantitykind/Long-RangeOrderParameter"></see></summary>
    let ``_/Long-RangeOrderParameter`` =
        Namespaced_IRI.parse _namespace_name "/Long-RangeOrderParameter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LorenzCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/LorenzCoefficient"></see></summary>
    let ``_/LorenzCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/LorenzCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/LossAngle"></see></summary>
    let ``_/LossAngle`` =
        Namespaced_IRI.parse _namespace_name "/LossAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LossFactor
    /// <see href="http://qudt.org/vocab/quantitykind/LossFactor"></see></summary>
    let ``_/LossFactor`` =
        Namespaced_IRI.parse _namespace_name "/LossFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:QualityFactor
    /// <see href="http://qudt.org/vocab/quantitykind/QualityFactor"></see></summary>
    let ``_/QualityFactor`` =
        Namespaced_IRI.parse _namespace_name "/QualityFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Reactance
    /// <see href="http://qudt.org/vocab/quantitykind/Reactance"></see></summary>
    let ``_/Reactance`` =
        Namespaced_IRI.parse _namespace_name "/Reactance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Resistance
    /// <see href="http://qudt.org/vocab/quantitykind/Resistance"></see></summary>
    let ``_/Resistance`` =
        Namespaced_IRI.parse _namespace_name "/Resistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/Loudness"></see></summary>
    let ``_/Loudness`` =
        Namespaced_IRI.parse _namespace_name "/Loudness" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/LoudnessLevel"></see></summary>
    let ``_/LoudnessLevel`` =
        Namespaced_IRI.parse _namespace_name "/LoudnessLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/LowerCriticalMagneticFluxDensity"></see></summary>
    let ``_/LowerCriticalMagneticFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/LowerCriticalMagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/UpperCriticalMagneticFluxDensity"></see></summary>
    let ``_/UpperCriticalMagneticFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/UpperCriticalMagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Luminance
    /// <see href="http://qudt.org/vocab/quantitykind/Luminance"></see></summary>
    let ``_/Luminance`` =
        Namespaced_IRI.parse _namespace_name "/Luminance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousEfficacy
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousEfficacy"></see></summary>
    let ``_/LuminousEfficacy`` =
        Namespaced_IRI.parse _namespace_name "/LuminousEfficacy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousEmittance"></see></summary>
    let ``_/LuminousEmittance`` =
        Namespaced_IRI.parse _namespace_name "/LuminousEmittance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousEnergy"></see></summary>
    let ``_/LuminousEnergy`` =
        Namespaced_IRI.parse _namespace_name "/LuminousEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantEnergy"></see></summary>
    let ``_/RadiantEnergy`` =
        Namespaced_IRI.parse _namespace_name "/RadiantEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousExitance"></see></summary>
    let ``_/LuminousExitance`` =
        Namespaced_IRI.parse _namespace_name "/LuminousExitance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousExposure
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousExposure"></see></summary>
    let ``_/LuminousExposure`` =
        Namespaced_IRI.parse _namespace_name "/LuminousExposure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFlux
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousFlux"></see></summary>
    let ``_/LuminousFlux`` =
        Namespaced_IRI.parse _namespace_name "/LuminousFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxRatio
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousFluxRatio"></see></summary>
    let ``_/LuminousFluxRatio`` =
        Namespaced_IRI.parse _namespace_name "/LuminousFluxRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousIntensity
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousIntensity"></see></summary>
    let ``_/LuminousIntensity`` =
        Namespaced_IRI.parse _namespace_name "/LuminousIntensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousIntensityDistribution
    /// <see href="http://qudt.org/vocab/quantitykind/LuminousIntensityDistribution"></see></summary>
    let ``_/LuminousIntensityDistribution`` =
        Namespaced_IRI.parse _namespace_name "/LuminousIntensityDistribution" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-DELIVERED"></see></summary>
    let ``_/MASS-DELIVERED`` =
        Namespaced_IRI.parse _namespace_name "/MASS-DELIVERED" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-GROWTH-ALLOWANCE"></see></summary>
    let ``_/MASS-GROWTH-ALLOWANCE`` =
        Namespaced_IRI.parse _namespace_name "/MASS-GROWTH-ALLOWANCE" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-MARGIN"></see></summary>
    let ``_/MASS-MARGIN`` =
        Namespaced_IRI.parse _namespace_name "/MASS-MARGIN" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MASS-PROPERTY-UNCERTAINTY"></see></summary>
    let ``_/MASS-PROPERTY-UNCERTAINTY`` =
        Namespaced_IRI.parse _namespace_name "/MASS-PROPERTY-UNCERTAINTY" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Y"></see></summary>
    let ``_/MOMENT-OF-INERTIA_Y`` =
        Namespaced_IRI.parse _namespace_name "/MOMENT-OF-INERTIA_Y" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfInertia_Y"></see></summary>
    let ``_/MomentOfInertia_Y`` =
        Namespaced_IRI.parse _namespace_name "/MomentOfInertia_Y" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfInertia"></see></summary>
    let ``_/MomentOfInertia`` =
        Namespaced_IRI.parse _namespace_name "/MomentOfInertia" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MOMENT-OF-INERTIA_Z"></see></summary>
    let ``_/MOMENT-OF-INERTIA_Z`` =
        Namespaced_IRI.parse _namespace_name "/MOMENT-OF-INERTIA_Z" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfInertia_Z"></see></summary>
    let ``_/MomentOfInertia_Z`` =
        Namespaced_IRI.parse _namespace_name "/MomentOfInertia_Z" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MachNumber
    /// <see href="http://qudt.org/vocab/quantitykind/MachNumber"></see></summary>
    let ``_/MachNumber`` =
        Namespaced_IRI.parse _namespace_name "/MachNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/MacroscopicCrossSection"></see></summary>
    let ``_/MacroscopicCrossSection`` =
        Namespaced_IRI.parse _namespace_name "/MacroscopicCrossSection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/MacroscopicTotalCrossSection"></see></summary>
    let ``_/MacroscopicTotalCrossSection`` =
        Namespaced_IRI.parse _namespace_name "/MacroscopicTotalCrossSection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MadelungConstant
    /// <see href="http://qudt.org/vocab/quantitykind/MadelungConstant"></see></summary>
    let ``_/MadelungConstant`` =
        Namespaced_IRI.parse _namespace_name "/MadelungConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticAreaMoment
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticAreaMoment"></see></summary>
    let ``_/MagneticAreaMoment`` =
        Namespaced_IRI.parse _namespace_name "/MagneticAreaMoment" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticMoment
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticMoment"></see></summary>
    let ``_/MagneticMoment`` =
        Namespaced_IRI.parse _namespace_name "/MagneticMoment" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticDipoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticDipoleMoment"></see></summary>
    let ``_/MagneticDipoleMoment`` =
        Namespaced_IRI.parse _namespace_name "/MagneticDipoleMoment" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MagneticDipoleMomentOfAMolecule"></see>
    /// </summary>
    let ``_/MagneticDipoleMomentOfAMolecule`` =
        Namespaced_IRI.parse _namespace_name "/MagneticDipoleMomentOfAMolecule" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticField
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticField"></see></summary>
    let ``_/MagneticField`` =
        Namespaced_IRI.parse _namespace_name "/MagneticField" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFieldStrength_H"></see></summary>
    let ``_/MagneticFieldStrength_H`` =
        Namespaced_IRI.parse _namespace_name "/MagneticFieldStrength_H" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MagneticFluxDensityOrMagneticPolarization"></see>
    /// </summary>
    let ``_/MagneticFluxDensityOrMagneticPolarization`` =
        Namespaced_IRI.parse _namespace_name "/MagneticFluxDensityOrMagneticPolarization" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticFluxPerLength"></see></summary>
    let ``_/MagneticFluxPerLength`` =
        Namespaced_IRI.parse _namespace_name "/MagneticFluxPerLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MagneticPolarization"></see>
    /// </summary>
    let ``_/MagneticPolarization`` =
        Namespaced_IRI.parse _namespace_name "/MagneticPolarization" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/Magnetization"></see></summary>
    let ``_/Magnetization`` =
        Namespaced_IRI.parse _namespace_name "/Magnetization" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticQuantumNumber"></see></summary>
    let ``_/MagneticQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/MagneticQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:OrbitalAngularMomentumQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumQuantumNumber"></see></summary>
    let ``_/OrbitalAngularMomentumQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/OrbitalAngularMomentumQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PrincipalQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/PrincipalQuantumNumber"></see></summary>
    let ``_/PrincipalQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/PrincipalQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpinQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/SpinQuantumNumber"></see></summary>
    let ``_/SpinQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/SpinQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticReluctivity
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticReluctivity"></see></summary>
    let ``_/MagneticReluctivity`` =
        Namespaced_IRI.parse _namespace_name "/MagneticReluctivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticSusceptability
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticSusceptability"></see></summary>
    let ``_/MagneticSusceptability`` =
        Namespaced_IRI.parse _namespace_name "/MagneticSusceptability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticTension
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticTension"></see></summary>
    let ``_/MagneticTension`` =
        Namespaced_IRI.parse _namespace_name "/MagneticTension" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticVectorPotential
    /// <see href="http://qudt.org/vocab/quantitykind/MagneticVectorPotential"></see></summary>
    let ``_/MagneticVectorPotential`` =
        Namespaced_IRI.parse _namespace_name "/MagneticVectorPotential" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LinearElectricCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MagnetizationField"></see></summary>
    let ``_/MagnetizationField`` =
        Namespaced_IRI.parse _namespace_name "/MagnetizationField" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagnetomotiveForce
    /// <see href="http://qudt.org/vocab/quantitykind/MagnetomotiveForce"></see></summary>
    let ``_/MagnetomotiveForce`` =
        Namespaced_IRI.parse _namespace_name "/MagnetomotiveForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassAbsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MassAbsorptionCoefficient"></see></summary>
    let ``_/MassAbsorptionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/MassAbsorptionCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassAmountOfSubstance"></see>
    /// </summary>
    let ``_/MassAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/MassAmountOfSubstance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassAmountOfSubstanceTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/MassAmountOfSubstanceTemperature"></see></summary>
    let ``_/MassAmountOfSubstanceTemperature`` =
        Namespaced_IRI.parse _namespace_name "/MassAmountOfSubstanceTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassAttenuationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MassAttenuationCoefficient"></see></summary>
    let ``_/MassAttenuationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/MassAttenuationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentration
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentration"></see></summary>
    let ``_/MassConcentration`` =
        Namespaced_IRI.parse _namespace_name "/MassConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentrationOfWater
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentrationOfWater"></see></summary>
    let ``_/MassConcentrationOfWater`` =
        Namespaced_IRI.parse _namespace_name "/MassConcentrationOfWater" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentrationOfWaterVapour
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentrationOfWaterVapour"></see></summary>
    let ``_/MassConcentrationOfWaterVapour`` =
        Namespaced_IRI.parse _namespace_name "/MassConcentrationOfWaterVapour" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassConcentrationRateOfChange
    /// <see href="http://qudt.org/vocab/quantitykind/MassConcentrationRateOfChange"></see></summary>
    let ``_/MassConcentrationRateOfChange`` =
        Namespaced_IRI.parse _namespace_name "/MassConcentrationRateOfChange" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassDefect"></see></summary>
    let ``_/MassDefect`` =
        Namespaced_IRI.parse _namespace_name "/MassDefect" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassEnergyTransferCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MassEnergyTransferCoefficient"></see></summary>
    let ``_/MassEnergyTransferCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/MassEnergyTransferCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassExcess"></see></summary>
    let ``_/MassExcess`` =
        Namespaced_IRI.parse _namespace_name "/MassExcess" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/MassFlowRate"></see></summary>
    let ``_/MassFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/MassFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerAreaTime
    /// <see href="http://qudt.org/vocab/quantitykind/MassFluxDensity"></see></summary>
    let ``_/MassFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/MassFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassFraction
    /// <see href="http://qudt.org/vocab/quantitykind/MassFraction"></see></summary>
    let ``_/MassFraction`` =
        Namespaced_IRI.parse _namespace_name "/MassFraction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassFractionOfDryMatter
    /// <see href="http://qudt.org/vocab/quantitykind/MassFractionOfDryMatter"></see></summary>
    let ``_/MassFractionOfDryMatter`` =
        Namespaced_IRI.parse _namespace_name "/MassFractionOfDryMatter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassFractionOfWater
    /// <see href="http://qudt.org/vocab/quantitykind/MassFractionOfWater"></see></summary>
    let ``_/MassFractionOfWater`` =
        Namespaced_IRI.parse _namespace_name "/MassFractionOfWater" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassNumber
    /// <see href="http://qudt.org/vocab/quantitykind/MassNumber"></see></summary>
    let ``_/MassNumber`` =
        Namespaced_IRI.parse _namespace_name "/MassNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassOfElectricalPowerSupply"></see></summary>
    let ``_/MassOfElectricalPowerSupply`` =
        Namespaced_IRI.parse _namespace_name "/MassOfElectricalPowerSupply" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassOfSolidBooster"></see></summary>
    let ``_/MassOfSolidBooster`` =
        Namespaced_IRI.parse _namespace_name "/MassOfSolidBooster" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/MassOfTheEarth"></see></summary>
    let ``_/MassOfTheEarth`` =
        Namespaced_IRI.parse _namespace_name "/MassOfTheEarth" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerElectricCharge"></see></summary>
    let ``_/MassPerElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/MassPerElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerEnergy"></see></summary>
    let ``_/MassPerEnergy`` =
        Namespaced_IRI.parse _namespace_name "/MassPerEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerLength"></see></summary>
    let ``_/MassPerLength`` =
        Namespaced_IRI.parse _namespace_name "/MassPerLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/MassPerTime"></see></summary>
    let ``_/MassPerTime`` =
        Namespaced_IRI.parse _namespace_name "/MassPerTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassRatioOfWaterToDryMatter
    /// <see href="http://qudt.org/vocab/quantitykind/MassRatioOfWaterToDryMatter"></see></summary>
    let ``_/MassRatioOfWaterToDryMatter`` =
        Namespaced_IRI.parse _namespace_name "/MassRatioOfWaterToDryMatter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassRatioOfWaterVapourToDryGas
    /// <see href="http://qudt.org/vocab/quantitykind/MassRatioOfWaterVapourToDryGas"></see></summary>
    let ``_/MassRatioOfWaterVapourToDryGas`` =
        Namespaced_IRI.parse _namespace_name "/MassRatioOfWaterVapourToDryGas" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassRelatedElectricalCurrent"></see>
    /// </summary>
    let ``_/MassRelatedElectricalCurrent`` =
        Namespaced_IRI.parse _namespace_name "/MassRelatedElectricalCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassSpecificBiogeochemicalRate
    /// <see href="http://qudt.org/vocab/quantitykind/MassSpecificBiogeochemicalRate"></see></summary>
    let ``_/MassSpecificBiogeochemicalRate`` =
        Namespaced_IRI.parse _namespace_name "/MassSpecificBiogeochemicalRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/MassStoppingPower"></see></summary>
    let ``_/MassStoppingPower`` =
        Namespaced_IRI.parse _namespace_name "/MassStoppingPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/MassTemperature"></see></summary>
    let ``_/MassTemperature`` =
        Namespaced_IRI.parse _namespace_name "/MassTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassicElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/MassicElectricCurrent"></see></summary>
    let ``_/MassicElectricCurrent`` =
        Namespaced_IRI.parse _namespace_name "/MassicElectricCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassicHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/MassicHeatCapacity"></see></summary>
    let ``_/MassicHeatCapacity`` =
        Namespaced_IRI.parse _namespace_name "/MassicHeatCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificPower
    /// <see href="http://qudt.org/vocab/quantitykind/MassicPower"></see></summary>
    let ``_/MassicPower`` =
        Namespaced_IRI.parse _namespace_name "/MassicPower" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassicTorque"></see>
    /// </summary>
    let ``_/MassicTorque`` =
        Namespaced_IRI.parse _namespace_name "/MassicTorque" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MassieuFunction"></see>
    /// </summary>
    let ``_/MassieuFunction`` =
        Namespaced_IRI.parse _namespace_name "/MassieuFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PlanckFunction"></see>
    /// </summary>
    let ``_/PlanckFunction`` =
        Namespaced_IRI.parse _namespace_name "/PlanckFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEnthalpy"></see></summary>
    let ``_/SpecificEnthalpy`` =
        Namespaced_IRI.parse _namespace_name "/SpecificEnthalpy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificGibbsEnergy"></see></summary>
    let ``_/SpecificGibbsEnergy`` =
        Namespaced_IRI.parse _namespace_name "/SpecificGibbsEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHelmholtzEnergy"></see></summary>
    let ``_/SpecificHelmholtzEnergy`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHelmholtzEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificInternalEnergy"></see></summary>
    let ``_/SpecificInternalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/SpecificInternalEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/MaxExpectedOperatingThrust"></see></summary>
    let ``_/MaxExpectedOperatingThrust`` =
        Namespaced_IRI.parse _namespace_name "/MaxExpectedOperatingThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/MaxOperatingThrust"></see></summary>
    let ``_/MaxOperatingThrust`` =
        Namespaced_IRI.parse _namespace_name "/MaxOperatingThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Thrust"></see></summary>
    let ``_/Thrust`` = Namespaced_IRI.parse _namespace_name "/Thrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// Max Sea Level thrust (Mlbf)
    /// <see href="http://qudt.org/vocab/quantitykind/MaxSeaLevelThrust"></see></summary>
    let ``_/MaxSeaLevelThrust`` =
        Namespaced_IRI.parse _namespace_name "/MaxSeaLevelThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/MaximumBeta-ParticleEnergy"></see></summary>
    let ``_/MaximumBeta-ParticleEnergy`` =
        Namespaced_IRI.parse _namespace_name "/MaximumBeta-ParticleEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MaximumExpectedOperatingPressure"></see></summary>
    let ``_/MaximumExpectedOperatingPressure`` =
        Namespaced_IRI.parse _namespace_name "/MaximumExpectedOperatingPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MaximumOperatingPressure"></see></summary>
    let ``_/MaximumOperatingPressure`` =
        Namespaced_IRI.parse _namespace_name "/MaximumOperatingPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/MeanEnergyImparted"></see></summary>
    let ``_/MeanEnergyImparted`` =
        Namespaced_IRI.parse _namespace_name "/MeanEnergyImparted" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/MeanFreePath"></see></summary>
    let ``_/MeanFreePath`` =
        Namespaced_IRI.parse _namespace_name "/MeanFreePath" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/MeanLifetime"></see></summary>
    let ``_/MeanLifetime`` =
        Namespaced_IRI.parse _namespace_name "/MeanLifetime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/MeanLinearRange"></see></summary>
    let ``_/MeanLinearRange`` =
        Namespaced_IRI.parse _namespace_name "/MeanLinearRange" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MeanMassRange
    /// <see href="http://qudt.org/vocab/quantitykind/MeanMassRange"></see></summary>
    let ``_/MeanMassRange`` =
        Namespaced_IRI.parse _namespace_name "/MeanMassRange" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalEnergy"></see></summary>
    let ``_/MechanicalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/MechanicalEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MechanicalImpedance"></see>
    /// </summary>
    let ``_/MechanicalImpedance`` =
        Namespaced_IRI.parse _namespace_name "/MechanicalImpedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MechanicalMobility
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalMobility"></see></summary>
    let ``_/MechanicalMobility`` =
        Namespaced_IRI.parse _namespace_name "/MechanicalMobility" |> NamespacedName

    /// <summary>
    /// There are various interpretations of MechanicalSurfaceImpedance: Pressure/Velocity - https://apps.dtic.mil/sti/pdfs/ADA315595.pdf, Force / Speed - https://www.wikidata.org/wiki/Q6421317, and (Pressure / Velocity)**0.5 - https://www.sciencedirect.com/topics/engineering/mechanical-impedance. We are seeking a resolution to these differences.
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalSurfaceImpedance"></see></summary>
    let ``_/MechanicalSurfaceImpedance`` =
        Namespaced_IRI.parse _namespace_name "/MechanicalSurfaceImpedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/MechanicalTension"></see></summary>
    let ``_/MechanicalTension`` =
        Namespaced_IRI.parse _namespace_name "/MechanicalTension" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MeltingPoint
    /// <see href="http://qudt.org/vocab/quantitykind/MeltingPoint"></see></summary>
    let ``_/MeltingPoint`` =
        Namespaced_IRI.parse _namespace_name "/MeltingPoint" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CanonicalPartitionFunction
    /// <see href="http://qudt.org/vocab/quantitykind/MicroCanonicalPartitionFunction"></see></summary>
    let ``_/MicroCanonicalPartitionFunction`` =
        Namespaced_IRI.parse _namespace_name "/MicroCanonicalPartitionFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MicrobialFormation"></see>
    /// </summary>
    let ``_/MicrobialFormation`` =
        Namespaced_IRI.parse _namespace_name "/MicrobialFormation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/MigrationArea"></see></summary>
    let ``_/MigrationArea`` =
        Namespaced_IRI.parse _namespace_name "/MigrationArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/MigrationLength"></see></summary>
    let ``_/MigrationLength`` =
        Namespaced_IRI.parse _namespace_name "/MigrationLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MobilityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/MobilityRatio"></see></summary>
    let ``_/MobilityRatio`` =
        Namespaced_IRI.parse _namespace_name "/MobilityRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ModulusOfAdmittance"></see>
    /// </summary>
    let ``_/ModulusOfAdmittance`` =
        Namespaced_IRI.parse _namespace_name "/ModulusOfAdmittance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfElasticity
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfElasticity"></see></summary>
    let ``_/ModulusOfElasticity`` =
        Namespaced_IRI.parse _namespace_name "/ModulusOfElasticity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfImpedance"></see></summary>
    let ``_/ModulusOfImpedance`` =
        Namespaced_IRI.parse _namespace_name "/ModulusOfImpedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfLinearSubgradeReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfLinearSubgradeReaction"></see></summary>
    let ``_/ModulusOfLinearSubgradeReaction`` =
        Namespaced_IRI.parse _namespace_name "/ModulusOfLinearSubgradeReaction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfRotationalSubgradeReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfRotationalSubgradeReaction"></see></summary>
    let ``_/ModulusOfRotationalSubgradeReaction`` =
        Namespaced_IRI.parse _namespace_name "/ModulusOfRotationalSubgradeReaction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ModulusOfSubgradeReaction
    /// <see href="http://qudt.org/vocab/quantitykind/ModulusOfSubgradeReaction"></see></summary>
    let ``_/ModulusOfSubgradeReaction`` =
        Namespaced_IRI.parse _namespace_name "/ModulusOfSubgradeReaction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/MoistureDiffusivity"></see></summary>
    let ``_/MoistureDiffusivity`` =
        Namespaced_IRI.parse _namespace_name "/MoistureDiffusivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeFlowRate"></see></summary>
    let ``_/VolumeFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/VolumeFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolalityOfSolute
    /// <see href="http://qudt.org/vocab/quantitykind/MolalityOfSolute"></see></summary>
    let ``_/MolalityOfSolute`` =
        Namespaced_IRI.parse _namespace_name "/MolalityOfSolute" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarAbsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/MolarAbsorptionCoefficient"></see></summary>
    let ``_/MolarAbsorptionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/MolarAbsorptionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarAngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/MolarAngularMomentum"></see></summary>
    let ``_/MolarAngularMomentum`` =
        Namespaced_IRI.parse _namespace_name "/MolarAngularMomentum" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarConductivity"></see></summary>
    let ``_/MolarConductivity`` =
        Namespaced_IRI.parse _namespace_name "/MolarConductivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarDensity"></see>
    /// </summary>
    let ``_/MolarDensity`` =
        Namespaced_IRI.parse _namespace_name "/MolarDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarEntropy"></see></summary>
    let ``_/MolarEntropy`` =
        Namespaced_IRI.parse _namespace_name "/MolarEntropy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/MolarFlowRate"></see></summary>
    let ``_/MolarFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/MolarFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarFluxDensity"></see></summary>
    let ``_/MolarFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/MolarFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarFluxDensityVariance
    /// <see href="http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance"></see></summary>
    let ``_/MolarFluxDensityVariance`` =
        Namespaced_IRI.parse _namespace_name "/MolarFluxDensityVariance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarFluxDensityVariance_NEON"></see>
    /// </summary>
    let ``_/MolarFluxDensityVariance_NEON`` =
        Namespaced_IRI.parse _namespace_name "/MolarFluxDensityVariance_NEON" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarHeatCapacity"></see></summary>
    let ``_/MolarHeatCapacity`` =
        Namespaced_IRI.parse _namespace_name "/MolarHeatCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarInternalEnergy"></see></summary>
    let ``_/MolarInternalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/MolarInternalEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarMass
    /// <see href="http://qudt.org/vocab/quantitykind/MolarMass"></see></summary>
    let ``_/MolarMass`` =
        Namespaced_IRI.parse _namespace_name "/MolarMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarOpticalRotationalAbility"></see>
    /// </summary>
    let ``_/MolarOpticalRotationalAbility`` =
        Namespaced_IRI.parse _namespace_name "/MolarOpticalRotationalAbility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarOpticalRotatoryPower
    /// <see href="http://qudt.org/vocab/quantitykind/MolarOpticalRotatoryPower"></see></summary>
    let ``_/MolarOpticalRotatoryPower`` =
        Namespaced_IRI.parse _namespace_name "/MolarOpticalRotatoryPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarRefractivity
    /// <see href="http://qudt.org/vocab/quantitykind/MolarRefractivity"></see></summary>
    let ``_/MolarRefractivity`` =
        Namespaced_IRI.parse _namespace_name "/MolarRefractivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MolarThermalCapacity"></see>
    /// </summary>
    let ``_/MolarThermalCapacity`` =
        Namespaced_IRI.parse _namespace_name "/MolarThermalCapacity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/MolarThermodynamicEnergy"></see></summary>
    let ``_/MolarThermodynamicEnergy`` =
        Namespaced_IRI.parse _namespace_name "/MolarThermodynamicEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarVolume
    /// <see href="http://qudt.org/vocab/quantitykind/MolarVolume"></see></summary>
    let ``_/MolarVolume`` =
        Namespaced_IRI.parse _namespace_name "/MolarVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/MoleFraction"></see></summary>
    let ``_/MoleFraction`` =
        Namespaced_IRI.parse _namespace_name "/MoleFraction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/MolecularConcentration"></see></summary>
    let ``_/MolecularConcentration`` =
        Namespaced_IRI.parse _namespace_name "/MolecularConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolecularMass
    /// <see href="http://qudt.org/vocab/quantitykind/MolecularMass"></see></summary>
    let ``_/MolecularMass`` =
        Namespaced_IRI.parse _namespace_name "/MolecularMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfForce
    /// <see href="http://qudt.org/vocab/quantitykind/MomentOfForce"></see></summary>
    let ``_/MomentOfForce`` =
        Namespaced_IRI.parse _namespace_name "/MomentOfForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RotationalMass
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalMass"></see></summary>
    let ``_/RotationalMass`` =
        Namespaced_IRI.parse _namespace_name "/RotationalMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentumPerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/MomentumPerAngle"></see></summary>
    let ``_/MomentumPerAngle`` =
        Namespaced_IRI.parse _namespace_name "/MomentumPerAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MorbidityRate
    /// <see href="http://qudt.org/vocab/quantitykind/MorbidityRate"></see></summary>
    let ``_/MorbidityRate`` =
        Namespaced_IRI.parse _namespace_name "/MorbidityRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MortalityRate
    /// <see href="http://qudt.org/vocab/quantitykind/MortalityRate"></see></summary>
    let ``_/MortalityRate`` =
        Namespaced_IRI.parse _namespace_name "/MortalityRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/MotorConstant"></see>
    /// </summary>
    let ``_/MotorConstant`` =
        Namespaced_IRI.parse _namespace_name "/MotorConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/NOMINAL-ASCENT-PROPELLANT-MASS"></see></summary>
    let ``_/NOMINAL-ASCENT-PROPELLANT-MASS`` =
        Namespaced_IRI.parse _namespace_name "/NOMINAL-ASCENT-PROPELLANT-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NapierianAbsorbance
    /// <see href="http://qudt.org/vocab/quantitykind/NapierianAbsorbance"></see></summary>
    let ``_/NapierianAbsorbance`` =
        Namespaced_IRI.parse _namespace_name "/NapierianAbsorbance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/NeutralRatio"></see></summary>
    let ``_/NeutralRatio`` =
        Namespaced_IRI.parse _namespace_name "/NeutralRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NeutronDiffusionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronDiffusionCoefficient"></see></summary>
    let ``_/NeutronDiffusionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/NeutronDiffusionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronDiffusionLength"></see></summary>
    let ``_/NeutronDiffusionLength`` =
        Namespaced_IRI.parse _namespace_name "/NeutronDiffusionLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NeutronNumber
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronNumber"></see></summary>
    let ``_/NeutronNumber`` =
        Namespaced_IRI.parse _namespace_name "/NeutronNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NeutronYieldPerAbsorption
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronYieldPerAbsorption"></see></summary>
    let ``_/NeutronYieldPerAbsorption`` =
        Namespaced_IRI.parse _namespace_name "/NeutronYieldPerAbsorption" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NeutronYieldPerFission
    /// <see href="http://qudt.org/vocab/quantitykind/NeutronYieldPerFission"></see></summary>
    let ``_/NeutronYieldPerFission`` =
        Namespaced_IRI.parse _namespace_name "/NeutronYieldPerFission" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Non-LeakageProbability
    /// <see href="http://qudt.org/vocab/quantitykind/Non-LeakageProbability"></see></summary>
    let ``_/Non-LeakageProbability`` =
        Namespaced_IRI.parse _namespace_name "/Non-LeakageProbability" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/NonActivePower"></see>
    /// </summary>
    let ``_/NonActivePower`` =
        Namespaced_IRI.parse _namespace_name "/NonActivePower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NonNegativeLength"></see></summary>
    let ``_/NonNegativeLength`` =
        Namespaced_IRI.parse _namespace_name "/NonNegativeLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/NormalStress"></see></summary>
    let ``_/NormalStress`` =
        Namespaced_IRI.parse _namespace_name "/NormalStress" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/Stress"></see></summary>
    let ``_/Stress`` = Namespaced_IRI.parse _namespace_name "/Stress" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/NormalizedDimensionlessRatio"></see></summary>
    let ``_/NormalizedDimensionlessRatio`` =
        Namespaced_IRI.parse _namespace_name "/NormalizedDimensionlessRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleThroatCrossSectionalArea"></see></summary>
    let ``_/NozzleThroatCrossSectionalArea`` =
        Namespaced_IRI.parse _namespace_name "/NozzleThroatCrossSectionalArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleThroatPressure"></see></summary>
    let ``_/NozzleThroatPressure`` =
        Namespaced_IRI.parse _namespace_name "/NozzleThroatPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/NozzleWallsThrustReaction"></see></summary>
    let ``_/NozzleWallsThrustReaction`` =
        Namespaced_IRI.parse _namespace_name "/NozzleWallsThrustReaction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearEnergy"></see></summary>
    let ``_/NuclearEnergy`` =
        Namespaced_IRI.parse _namespace_name "/NuclearEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NuclearQuadrupoleMoment
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearQuadrupoleMoment"></see></summary>
    let ``_/NuclearQuadrupoleMoment`` =
        Namespaced_IRI.parse _namespace_name "/NuclearQuadrupoleMoment" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearRadius"></see></summary>
    let ``_/NuclearRadius`` =
        Namespaced_IRI.parse _namespace_name "/NuclearRadius" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NuclearSpinQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/NuclearSpinQuantumNumber"></see></summary>
    let ``_/NuclearSpinQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/NuclearSpinQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NucleonNumber
    /// <see href="http://qudt.org/vocab/quantitykind/NucleonNumber"></see></summary>
    let ``_/NucleonNumber`` =
        Namespaced_IRI.parse _namespace_name "/NucleonNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberOfElectricalPhases
    /// <see href="http://qudt.org/vocab/quantitykind/NumberOfElectricalPhases"></see></summary>
    let ``_/NumberOfElectricalPhases`` =
        Namespaced_IRI.parse _namespace_name "/NumberOfElectricalPhases" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberOfParticles
    /// <see href="http://qudt.org/vocab/quantitykind/NumberOfParticles"></see></summary>
    let ``_/NumberOfParticles`` =
        Namespaced_IRI.parse _namespace_name "/NumberOfParticles" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/OlfactoryThreshold"></see></summary>
    let ``_/OlfactoryThreshold`` =
        Namespaced_IRI.parse _namespace_name "/OlfactoryThreshold" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:OpeningRatio
    /// <see href="http://qudt.org/vocab/quantitykind/OpeningRatio"></see></summary>
    let ``_/OpeningRatio`` =
        Namespaced_IRI.parse _namespace_name "/OpeningRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/OrbitalAngularMomentumPerMass"></see>
    /// </summary>
    let ``_/OrbitalAngularMomentumPerMass`` =
        Namespaced_IRI.parse _namespace_name "/OrbitalAngularMomentumPerMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/OrbitalRadialDistance"></see></summary>
    let ``_/OrbitalRadialDistance`` =
        Namespaced_IRI.parse _namespace_name "/OrbitalRadialDistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:OrderOfReflection
    /// <see href="http://qudt.org/vocab/quantitykind/OrderOfReflection"></see></summary>
    let ``_/OrderOfReflection`` =
        Namespaced_IRI.parse _namespace_name "/OrderOfReflection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:OsmoticCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/OsmoticCoefficient"></see></summary>
    let ``_/OsmoticCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/OsmoticCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/OsmoticConcentration"></see>
    /// </summary>
    let ``_/OsmoticConcentration`` =
        Namespaced_IRI.parse _namespace_name "/OsmoticConcentration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/OsmoticPressure"></see></summary>
    let ``_/OsmoticPressure`` =
        Namespaced_IRI.parse _namespace_name "/OsmoticPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/OverRangeDistance"></see></summary>
    let ``_/OverRangeDistance`` =
        Namespaced_IRI.parse _namespace_name "/OverRangeDistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/PREDICTED-MASS"></see></summary>
    let ``_/PREDICTED-MASS`` =
        Namespaced_IRI.parse _namespace_name "/PREDICTED-MASS" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA`` =
        Namespaced_IRI.parse _namespace_name "/PRODUCT-OF-INERTIA" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_X"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA_X`` =
        Namespaced_IRI.parse _namespace_name "/PRODUCT-OF-INERTIA_X" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ProductOfInertia_X"></see>
    /// </summary>
    let ``_/ProductOfInertia_X`` =
        Namespaced_IRI.parse _namespace_name "/ProductOfInertia_X" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Y"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA_Y`` =
        Namespaced_IRI.parse _namespace_name "/PRODUCT-OF-INERTIA_Y" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ProductOfInertia_Y"></see>
    /// </summary>
    let ``_/ProductOfInertia_Y`` =
        Namespaced_IRI.parse _namespace_name "/ProductOfInertia_Y" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PRODUCT-OF-INERTIA_Z"></see>
    /// </summary>
    let ``_/PRODUCT-OF-INERTIA_Z`` =
        Namespaced_IRI.parse _namespace_name "/PRODUCT-OF-INERTIA_Z" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ProductOfInertia_Z"></see>
    /// </summary>
    let ``_/ProductOfInertia_Z`` =
        Namespaced_IRI.parse _namespace_name "/ProductOfInertia_Z" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Pace
    /// <see href="http://qudt.org/vocab/quantitykind/Pace"></see></summary>
    let ``_/Pace`` = Namespaced_IRI.parse _namespace_name "/Pace" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PackingFraction
    /// <see href="http://qudt.org/vocab/quantitykind/PackingFraction"></see></summary>
    let ``_/PackingFraction`` =
        Namespaced_IRI.parse _namespace_name "/PackingFraction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PartialPressure"></see></summary>
    let ``_/PartialPressure`` =
        Namespaced_IRI.parse _namespace_name "/PartialPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Frequency
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleCurrent"></see></summary>
    let ``_/ParticleCurrent`` =
        Namespaced_IRI.parse _namespace_name "/ParticleCurrent" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ParticleCurrentDensity"></see>
    /// </summary>
    let ``_/ParticleCurrentDensity`` =
        Namespaced_IRI.parse _namespace_name "/ParticleCurrentDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ParticleFluence
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleFluence"></see></summary>
    let ``_/ParticleFluence`` =
        Namespaced_IRI.parse _namespace_name "/ParticleFluence" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ParticleFluenceRate
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleFluenceRate"></see></summary>
    let ``_/ParticleFluenceRate`` =
        Namespaced_IRI.parse _namespace_name "/ParticleFluenceRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:NumberDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleNumberDensity"></see></summary>
    let ``_/ParticleNumberDensity`` =
        Namespaced_IRI.parse _namespace_name "/ParticleNumberDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/ParticlePositionVector"></see></summary>
    let ``_/ParticlePositionVector`` =
        Namespaced_IRI.parse _namespace_name "/ParticlePositionVector" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ParticleSourceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ParticleSourceDensity"></see></summary>
    let ``_/ParticleSourceDensity`` =
        Namespaced_IRI.parse _namespace_name "/ParticleSourceDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PathLength"></see></summary>
    let ``_/PathLength`` =
        Namespaced_IRI.parse _namespace_name "/PathLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/PayloadMass"></see></summary>
    let ``_/PayloadMass`` =
        Namespaced_IRI.parse _namespace_name "/PayloadMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PayloadRatio"></see></summary>
    let ``_/PayloadRatio`` =
        Namespaced_IRI.parse _namespace_name "/PayloadRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PeltierCoefficient"></see>
    /// </summary>
    let ``_/PeltierCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/PeltierCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Period
    /// <see href="http://qudt.org/vocab/quantitykind/Period"></see></summary>
    let ``_/Period`` = Namespaced_IRI.parse _namespace_name "/Period" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PermeabilityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PermeabilityRatio"></see></summary>
    let ``_/PermeabilityRatio`` =
        Namespaced_IRI.parse _namespace_name "/PermeabilityRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Permeance
    /// <see href="http://qudt.org/vocab/quantitykind/Permeance"></see></summary>
    let ``_/Permeance`` =
        Namespaced_IRI.parse _namespace_name "/Permeance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Reluctance
    /// <see href="http://qudt.org/vocab/quantitykind/Reluctance"></see></summary>
    let ``_/Reluctance`` =
        Namespaced_IRI.parse _namespace_name "/Reluctance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Permittivity
    /// <see href="http://qudt.org/vocab/quantitykind/Permittivity"></see></summary>
    let ``_/Permittivity`` =
        Namespaced_IRI.parse _namespace_name "/Permittivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PermittivityRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PermittivityRatio"></see></summary>
    let ``_/PermittivityRatio`` =
        Namespaced_IRI.parse _namespace_name "/PermittivityRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PhaseCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/PhaseCoefficient"></see></summary>
    let ``_/PhaseCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/PhaseCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/PhaseDifference"></see></summary>
    let ``_/PhaseDifference`` =
        Namespaced_IRI.parse _namespace_name "/PhaseDifference" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PhaseSpeedOfSound
    /// <see href="http://qudt.org/vocab/quantitykind/PhaseSpeedOfSound"></see></summary>
    let ``_/PhaseSpeedOfSound`` =
        Namespaced_IRI.parse _namespace_name "/PhaseSpeedOfSound" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PhononMeanFreePath"></see></summary>
    let ``_/PhononMeanFreePath`` =
        Namespaced_IRI.parse _namespace_name "/PhononMeanFreePath" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PhotoThresholdOfAwarenessFunction"></see>
    /// </summary>
    let ``_/PhotoThresholdOfAwarenessFunction`` =
        Namespaced_IRI.parse _namespace_name "/PhotoThresholdOfAwarenessFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PhotonIntensity
    /// <see href="http://qudt.org/vocab/quantitykind/PhotonIntensity"></see></summary>
    let ``_/PhotonIntensity`` =
        Namespaced_IRI.parse _namespace_name "/PhotonIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PhotonLuminance"></see>
    /// </summary>
    let ``_/PhotonLuminance`` =
        Namespaced_IRI.parse _namespace_name "/PhotonLuminance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PhotonRadiance
    /// <see href="http://qudt.org/vocab/quantitykind/PhotonRadiance"></see></summary>
    let ``_/PhotonRadiance`` =
        Namespaced_IRI.parse _namespace_name "/PhotonRadiance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PhotosyntheticPhotonFlux
    /// <see href="http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFlux"></see></summary>
    let ``_/PhotosyntheticPhotonFlux`` =
        Namespaced_IRI.parse _namespace_name "/PhotosyntheticPhotonFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PhotosyntheticPhotonFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/PhotosyntheticPhotonFluxDensity"></see></summary>
    let ``_/PhotosyntheticPhotonFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/PhotosyntheticPhotonFluxDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PictureElement"></see>
    /// </summary>
    let ``_/PictureElement`` =
        Namespaced_IRI.parse _namespace_name "/PictureElement" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Count
    /// <see href="http://qudt.org/vocab/quantitykind/Piece"></see></summary>
    let ``_/Piece`` = Namespaced_IRI.parse _namespace_name "/Piece" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PlanarForce"></see></summary>
    let ``_/PlanarForce`` =
        Namespaced_IRI.parse _namespace_name "/PlanarForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PlasmaLevel
    /// <see href="http://qudt.org/vocab/quantitykind/PlasmaLevel"></see></summary>
    let ``_/PlasmaLevel`` =
        Namespaced_IRI.parse _namespace_name "/PlasmaLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PoissonRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PoissonRatio"></see></summary>
    let ``_/PoissonRatio`` =
        Namespaced_IRI.parse _namespace_name "/PoissonRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MomentOfInertia
    /// <see href="http://qudt.org/vocab/quantitykind/PolarMomentOfInertia"></see></summary>
    let ``_/PolarMomentOfInertia`` =
        Namespaced_IRI.parse _namespace_name "/PolarMomentOfInertia" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Polarizability
    /// <see href="http://qudt.org/vocab/quantitykind/Polarizability"></see></summary>
    let ``_/Polarizability`` =
        Namespaced_IRI.parse _namespace_name "/Polarizability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricChargePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PolarizationField"></see></summary>
    let ``_/PolarizationField`` =
        Namespaced_IRI.parse _namespace_name "/PolarizationField" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Population
    /// <see href="http://qudt.org/vocab/quantitykind/Population"></see></summary>
    let ``_/Population`` =
        Namespaced_IRI.parse _namespace_name "/Population" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PositiveDimensionlessRatio"></see></summary>
    let ``_/PositiveDimensionlessRatio`` =
        Namespaced_IRI.parse _namespace_name "/PositiveDimensionlessRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/PositiveLength"></see></summary>
    let ``_/PositiveLength`` =
        Namespaced_IRI.parse _namespace_name "/PositiveLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PlaneAngle
    /// <see href="http://qudt.org/vocab/quantitykind/PositivePlaneAngle"></see></summary>
    let ``_/PositivePlaneAngle`` =
        Namespaced_IRI.parse _namespace_name "/PositivePlaneAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/PotentialEnergy"></see></summary>
    let ``_/PotentialEnergy`` =
        Namespaced_IRI.parse _namespace_name "/PotentialEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerArea
    /// <see href="http://qudt.org/vocab/quantitykind/PowerArea"></see></summary>
    let ``_/PowerArea`` =
        Namespaced_IRI.parse _namespace_name "/PowerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerAreaPerSolidAngle
    /// <see href="http://qudt.org/vocab/quantitykind/PowerAreaPerSolidAngle"></see></summary>
    let ``_/PowerAreaPerSolidAngle`` =
        Namespaced_IRI.parse _namespace_name "/PowerAreaPerSolidAngle" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PowerConstant"></see>
    /// </summary>
    let ``_/PowerConstant`` =
        Namespaced_IRI.parse _namespace_name "/PowerConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerDensity
    /// <see href="http://qudt.org/vocab/quantitykind/PowerDensity"></see></summary>
    let ``_/PowerDensity`` =
        Namespaced_IRI.parse _namespace_name "/PowerDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerVolume
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerVolume"></see></summary>
    let ``_/PowerPerVolume`` =
        Namespaced_IRI.parse _namespace_name "/PowerPerVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerFactor
    /// <see href="http://qudt.org/vocab/quantitykind/PowerFactor"></see></summary>
    let ``_/PowerFactor`` =
        Namespaced_IRI.parse _namespace_name "/PowerFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PowerPerAreaAngle"></see>
    /// </summary>
    let ``_/PowerPerAreaAngle`` =
        Namespaced_IRI.parse _namespace_name "/PowerPerAreaAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerAreaQuarticTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerAreaQuarticTemperature"></see></summary>
    let ``_/PowerPerAreaQuarticTemperature`` =
        Namespaced_IRI.parse _namespace_name "/PowerPerAreaQuarticTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/PowerPerElectricCharge"></see></summary>
    let ``_/PowerPerElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/PowerPerElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PoyntingVector
    /// <see href="http://qudt.org/vocab/quantitykind/PoyntingVector"></see></summary>
    let ``_/PoyntingVector`` =
        Namespaced_IRI.parse _namespace_name "/PoyntingVector" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedAmountOfSubstanceConcentration"></see>
    /// </summary>
    let ``_/PressureBasedAmountOfSubstanceConcentration`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedAmountOfSubstanceConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedDensity"></see>
    /// </summary>
    let ``_/PressureBasedDensity`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedDynamicViscosity"></see>
    /// </summary>
    let ``_/PressureBasedDynamicViscosity`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedDynamicViscosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedElectricCurrent"></see>
    /// </summary>
    let ``_/PressureBasedElectricCurrent`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedElectricCurrent" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedElectricVoltage"></see>
    /// </summary>
    let ``_/PressureBasedElectricVoltage`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedElectricVoltage" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedKinematicViscosity"></see>
    /// </summary>
    let ``_/PressureBasedKinematicViscosity`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedKinematicViscosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedLength"></see>
    /// </summary>
    let ``_/PressureBasedLength`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedMass"></see>
    /// </summary>
    let ``_/PressureBasedMass`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedMassFlow"></see>
    /// </summary>
    let ``_/PressureBasedMassFlow`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedMassFlow" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedMolality"></see>
    /// </summary>
    let ``_/PressureBasedMolality`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedMolality" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedQuantity"></see>
    /// </summary>
    let ``_/PressureBasedQuantity`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedTemperature"></see>
    /// </summary>
    let ``_/PressureBasedTemperature`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedVelocity"></see>
    /// </summary>
    let ``_/PressureBasedVelocity`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedVelocity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedVolume"></see>
    /// </summary>
    let ``_/PressureBasedVolume`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedVolume" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureBasedVolumeFlow"></see>
    /// </summary>
    let ``_/PressureBasedVolumeFlow`` =
        Namespaced_IRI.parse _namespace_name "/PressureBasedVolumeFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/PressureBurningRateConstant"></see></summary>
    let ``_/PressureBurningRateConstant`` =
        Namespaced_IRI.parse _namespace_name "/PressureBurningRateConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/PressureBurningRateIndex"></see></summary>
    let ``_/PressureBurningRateIndex`` =
        Namespaced_IRI.parse _namespace_name "/PressureBurningRateIndex" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PressureCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/PressureCoefficient"></see></summary>
    let ``_/PressureCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/PressureCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PressureGradient
    /// <see href="http://qudt.org/vocab/quantitykind/PressureGradient"></see></summary>
    let ``_/PressureGradient`` =
        Namespaced_IRI.parse _namespace_name "/PressureGradient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlow"></see>
    /// </summary>
    let ``_/PressureInRelationToVolumeFlow`` =
        Namespaced_IRI.parse _namespace_name "/PressureInRelationToVolumeFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PressureInRelationToVolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/PressureInRelationToVolumeFlowRate"></see></summary>
    let ``_/PressureInRelationToVolumeFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/PressureInRelationToVolumeFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PressureLossPerLength
    /// <see href="http://qudt.org/vocab/quantitykind/PressureLossPerLength"></see></summary>
    let ``_/PressureLossPerLength`` =
        Namespaced_IRI.parse _namespace_name "/PressureLossPerLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PressureRatio
    /// <see href="http://qudt.org/vocab/quantitykind/PressureRatio"></see></summary>
    let ``_/PressureRatio`` =
        Namespaced_IRI.parse _namespace_name "/PressureRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Prevalence
    /// <see href="http://qudt.org/vocab/quantitykind/Prevalence"></see></summary>
    let ``_/Prevalence`` =
        Namespaced_IRI.parse _namespace_name "/Prevalence" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PropagationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/PropagationCoefficient"></see></summary>
    let ``_/PropagationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/PropagationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PropellantBurnRate
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantBurnRate"></see></summary>
    let ``_/PropellantBurnRate`` =
        Namespaced_IRI.parse _namespace_name "/PropellantBurnRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantMeanBulkTemperature"></see></summary>
    let ``_/PropellantMeanBulkTemperature`` =
        Namespaced_IRI.parse _namespace_name "/PropellantMeanBulkTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/PropellantTemperature"></see></summary>
    let ``_/PropellantTemperature`` =
        Namespaced_IRI.parse _namespace_name "/PropellantTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/QuantityOfLight"></see>
    /// </summary>
    let ``_/QuantityOfLight`` =
        Namespaced_IRI.parse _namespace_name "/QuantityOfLight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/RESERVE-MASS"></see></summary>
    let ``_/RESERVE-MASS`` =
        Namespaced_IRI.parse _namespace_name "/RESERVE-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricField
    /// <see href="http://qudt.org/vocab/quantitykind/RF-Power"></see></summary>
    let ``_/RF-Power`` =
        Namespaced_IRI.parse _namespace_name "/RF-Power" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ElectricField
    /// <see href="http://qudt.org/vocab/quantitykind/SignalStrength"></see></summary>
    let ``_/SignalStrength`` =
        Namespaced_IRI.parse _namespace_name "/SignalStrength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/RadialDistance"></see></summary>
    let ``_/RadialDistance`` =
        Namespaced_IRI.parse _namespace_name "/RadialDistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Radiance
    /// <see href="http://qudt.org/vocab/quantitykind/Radiance"></see></summary>
    let ``_/Radiance`` =
        Namespaced_IRI.parse _namespace_name "/Radiance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RadianceFactor
    /// <see href="http://qudt.org/vocab/quantitykind/RadianceFactor"></see></summary>
    let ``_/RadianceFactor`` =
        Namespaced_IRI.parse _namespace_name "/RadianceFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantEmmitance"></see></summary>
    let ``_/RadiantEmmitance`` =
        Namespaced_IRI.parse _namespace_name "/RadiantEmmitance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RadiantEnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantEnergyDensity"></see></summary>
    let ``_/RadiantEnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/RadiantEnergyDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RadiantEnergyExposure"></see>
    /// </summary>
    let ``_/RadiantEnergyExposure`` =
        Namespaced_IRI.parse _namespace_name "/RadiantEnergyExposure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantExposure"></see></summary>
    let ``_/RadiantExposure`` =
        Namespaced_IRI.parse _namespace_name "/RadiantExposure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RadiantFluence
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantFluence"></see></summary>
    let ``_/RadiantFluence`` =
        Namespaced_IRI.parse _namespace_name "/RadiantFluence" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantFluenceRate"></see></summary>
    let ``_/RadiantFluenceRate`` =
        Namespaced_IRI.parse _namespace_name "/RadiantFluenceRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantFlux"></see></summary>
    let ``_/RadiantFlux`` =
        Namespaced_IRI.parse _namespace_name "/RadiantFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RadiantIntensity
    /// <see href="http://qudt.org/vocab/quantitykind/RadiantIntensity"></see></summary>
    let ``_/RadiantIntensity`` =
        Namespaced_IRI.parse _namespace_name "/RadiantIntensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:HeatFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/RadiativeHeatTransfer"></see></summary>
    let ``_/RadiativeHeatTransfer`` =
        Namespaced_IRI.parse _namespace_name "/RadiativeHeatTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RadioactiveDecay"></see>
    /// </summary>
    let ``_/RadioactiveDecay`` =
        Namespaced_IRI.parse _namespace_name "/RadioactiveDecay" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Radioactivity"></see>
    /// </summary>
    let ``_/Radioactivity`` =
        Namespaced_IRI.parse _namespace_name "/Radioactivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Radiosity
    /// <see href="http://qudt.org/vocab/quantitykind/Radiosity"></see></summary>
    let ``_/Radiosity`` =
        Namespaced_IRI.parse _namespace_name "/Radiosity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/RadiusOfCurvature"></see></summary>
    let ``_/RadiusOfCurvature`` =
        Namespaced_IRI.parse _namespace_name "/RadiusOfCurvature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermodynamicTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/RankineTemperature"></see></summary>
    let ``_/RankineTemperature`` =
        Namespaced_IRI.parse _namespace_name "/RankineTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RateOfChange
    /// <see href="http://qudt.org/vocab/quantitykind/RateOfChange"></see></summary>
    let ``_/RateOfChange`` =
        Namespaced_IRI.parse _namespace_name "/RateOfChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RateOfRiseOfVoltage"></see>
    /// </summary>
    let ``_/RateOfRiseOfVoltage`` =
        Namespaced_IRI.parse _namespace_name "/RateOfRiseOfVoltage" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Ratio
    /// <see href="http://qudt.org/vocab/quantitykind/Ratio"></see></summary>
    let ``_/Ratio`` = Namespaced_IRI.parse _namespace_name "/Ratio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RatioOfSpecificHeatCapacities
    /// <see href="http://qudt.org/vocab/quantitykind/RatioOfSpecificHeatCapacities"></see></summary>
    let ``_/RatioOfSpecificHeatCapacities`` =
        Namespaced_IRI.parse _namespace_name "/RatioOfSpecificHeatCapacities" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ReactionEnergy"></see></summary>
    let ``_/ReactionEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ReactionEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReactiveCharge
    /// <see href="http://qudt.org/vocab/quantitykind/ReactiveCharge"></see></summary>
    let ``_/ReactiveCharge`` =
        Namespaced_IRI.parse _namespace_name "/ReactiveCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReactivePower
    /// <see href="http://qudt.org/vocab/quantitykind/ReactivePower"></see></summary>
    let ``_/ReactivePower`` =
        Namespaced_IRI.parse _namespace_name "/ReactivePower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Reactivity
    /// <see href="http://qudt.org/vocab/quantitykind/Reactivity"></see></summary>
    let ``_/Reactivity`` =
        Namespaced_IRI.parse _namespace_name "/Reactivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/ReactorTimeConstant"></see></summary>
    let ``_/ReactorTimeConstant`` =
        Namespaced_IRI.parse _namespace_name "/ReactorTimeConstant" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ReciprocalElectricResistance"></see>
    /// </summary>
    let ``_/ReciprocalElectricResistance`` =
        Namespaced_IRI.parse _namespace_name "/ReciprocalElectricResistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ReciprocalEnergy"></see>
    /// </summary>
    let ``_/ReciprocalEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ReciprocalEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ReciprocalPlaneAngle"></see>
    /// </summary>
    let ``_/ReciprocalPlaneAngle`` =
        Namespaced_IRI.parse _namespace_name "/ReciprocalPlaneAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReciprocalVoltage
    /// <see href="http://qudt.org/vocab/quantitykind/ReciprocalVoltage"></see></summary>
    let ``_/ReciprocalVoltage`` =
        Namespaced_IRI.parse _namespace_name "/ReciprocalVoltage" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RecombinationCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/RecombinationCoefficient"></see></summary>
    let ``_/RecombinationCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/RecombinationCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Reflectance
    /// <see href="http://qudt.org/vocab/quantitykind/Reflectance"></see></summary>
    let ``_/Reflectance`` =
        Namespaced_IRI.parse _namespace_name "/Reflectance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReflectanceFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ReflectanceFactor"></see></summary>
    let ``_/ReflectanceFactor`` =
        Namespaced_IRI.parse _namespace_name "/ReflectanceFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Reflectance
    /// <see href="http://qudt.org/vocab/quantitykind/Reflectivity"></see></summary>
    let ``_/Reflectivity`` =
        Namespaced_IRI.parse _namespace_name "/Reflectivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RefractiveIndex
    /// <see href="http://qudt.org/vocab/quantitykind/RefractiveIndex"></see></summary>
    let ``_/RefractiveIndex`` =
        Namespaced_IRI.parse _namespace_name "/RefractiveIndex" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeAtomicMass"></see></summary>
    let ``_/RelativeAtomicMass`` =
        Namespaced_IRI.parse _namespace_name "/RelativeAtomicMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativePartialPressure
    /// <see href="http://qudt.org/vocab/quantitykind/RelativePartialPressure"></see></summary>
    let ``_/RelativePartialPressure`` =
        Namespaced_IRI.parse _namespace_name "/RelativePartialPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassConcentrationOfVapour
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassConcentrationOfVapour"></see></summary>
    let ``_/RelativeMassConcentrationOfVapour`` =
        Namespaced_IRI.parse _namespace_name "/RelativeMassConcentrationOfVapour" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassDefect"></see></summary>
    let ``_/RelativeMassDefect`` =
        Namespaced_IRI.parse _namespace_name "/RelativeMassDefect" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassDensity
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassDensity"></see></summary>
    let ``_/RelativeMassDensity`` =
        Namespaced_IRI.parse _namespace_name "/RelativeMassDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassExcess
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassExcess"></see></summary>
    let ``_/RelativeMassExcess`` =
        Namespaced_IRI.parse _namespace_name "/RelativeMassExcess" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativeMassRatioOfVapour
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMassRatioOfVapour"></see></summary>
    let ``_/RelativeMassRatioOfVapour`` =
        Namespaced_IRI.parse _namespace_name "/RelativeMassRatioOfVapour" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/RelativeMolecularMass"></see></summary>
    let ``_/RelativeMolecularMass`` =
        Namespaced_IRI.parse _namespace_name "/RelativeMolecularMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RelativePermittivity"></see>
    /// </summary>
    let ``_/RelativePermittivity`` =
        Namespaced_IRI.parse _namespace_name "/RelativePermittivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RelativePressureCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/RelativePressureCoefficient"></see></summary>
    let ``_/RelativePressureCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/RelativePressureCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/RelaxationTIme"></see></summary>
    let ``_/RelaxationTIme`` =
        Namespaced_IRI.parse _namespace_name "/RelaxationTIme" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Repetency
    /// <see href="http://qudt.org/vocab/quantitykind/Repetency"></see></summary>
    let ``_/Repetency`` =
        Namespaced_IRI.parse _namespace_name "/Repetency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ResidualResistivity
    /// <see href="http://qudt.org/vocab/quantitykind/ResidualResistivity"></see></summary>
    let ``_/ResidualResistivity`` =
        Namespaced_IRI.parse _namespace_name "/ResidualResistivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ResistanceBasedInductance"></see>
    /// </summary>
    let ``_/ResistanceBasedInductance`` =
        Namespaced_IRI.parse _namespace_name "/ResistanceBasedInductance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ResistanceRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ResistanceRatio"></see></summary>
    let ``_/ResistanceRatio`` =
        Namespaced_IRI.parse _namespace_name "/ResistanceRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Resistivity
    /// <see href="http://qudt.org/vocab/quantitykind/Resistivity"></see></summary>
    let ``_/Resistivity`` =
        Namespaced_IRI.parse _namespace_name "/Resistivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/ResonanceEnergy"></see></summary>
    let ``_/ResonanceEnergy`` =
        Namespaced_IRI.parse _namespace_name "/ResonanceEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ResonanceEscapeProbability
    /// <see href="http://qudt.org/vocab/quantitykind/ResonanceEscapeProbability"></see></summary>
    let ``_/ResonanceEscapeProbability`` =
        Namespaced_IRI.parse _namespace_name "/ResonanceEscapeProbability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/ResonanceEscapeProbabilityForFission"></see></summary>
    let ``_/ResonanceEscapeProbabilityForFission`` =
        Namespaced_IRI.parse _namespace_name "/ResonanceEscapeProbabilityForFission" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RespiratoryRate
    /// <see href="http://qudt.org/vocab/quantitykind/RespiratoryRate"></see></summary>
    let ``_/RespiratoryRate`` =
        Namespaced_IRI.parse _namespace_name "/RespiratoryRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/RestEnergy"></see></summary>
    let ``_/RestEnergy`` =
        Namespaced_IRI.parse _namespace_name "/RestEnergy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/RestMass"></see></summary>
    let ``_/RestMass`` =
        Namespaced_IRI.parse _namespace_name "/RestMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/ReverberationTime"></see></summary>
    let ``_/ReverberationTime`` =
        Namespaced_IRI.parse _namespace_name "/ReverberationTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ReynoldsNumber
    /// <see href="http://qudt.org/vocab/quantitykind/ReynoldsNumber"></see></summary>
    let ``_/ReynoldsNumber`` =
        Namespaced_IRI.parse _namespace_name "/ReynoldsNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:RichardsonConstant
    /// <see href="http://qudt.org/vocab/quantitykind/RichardsonConstant"></see></summary>
    let ``_/RichardsonConstant`` =
        Namespaced_IRI.parse _namespace_name "/RichardsonConstant" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RiseOfOffStateVoltage"></see>
    /// </summary>
    let ``_/RiseOfOffStateVoltage`` =
        Namespaced_IRI.parse _namespace_name "/RiseOfOffStateVoltage" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/RocketAtmosphericTransverseForce"></see></summary>
    let ``_/RocketAtmosphericTransverseForce`` =
        Namespaced_IRI.parse _namespace_name "/RocketAtmosphericTransverseForce" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Rotary-TranslatoryMotionConversion
    /// <see href="http://qudt.org/vocab/quantitykind/Rotary-TranslatoryMotionConversion"></see></summary>
    let ``_/Rotary-TranslatoryMotionConversion`` =
        Namespaced_IRI.parse _namespace_name "/Rotary-TranslatoryMotionConversion" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/RotaryShock"></see>
    /// </summary>
    let ``_/RotaryShock`` =
        Namespaced_IRI.parse _namespace_name "/RotaryShock" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TorquePerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/RotationalStiffness"></see></summary>
    let ``_/RotationalStiffness`` =
        Namespaced_IRI.parse _namespace_name "/RotationalStiffness" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TorquePerAngle
    /// <see href="http://qudt.org/vocab/quantitykind/TorquePerAngle"></see></summary>
    let ``_/TorquePerAngle`` =
        Namespaced_IRI.parse _namespace_name "/TorquePerAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ScalarMagneticPotential
    /// <see href="http://qudt.org/vocab/quantitykind/ScalarMagneticPotential"></see></summary>
    let ``_/ScalarMagneticPotential`` =
        Namespaced_IRI.parse _namespace_name "/ScalarMagneticPotential" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SecondAxialMomentOfArea
    /// <see href="http://qudt.org/vocab/quantitykind/SecondAxialMomentOfArea"></see></summary>
    let ``_/SecondAxialMomentOfArea`` =
        Namespaced_IRI.parse _namespace_name "/SecondAxialMomentOfArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SecondMomentOfArea
    /// <see href="http://qudt.org/vocab/quantitykind/SecondMomentOfArea"></see></summary>
    let ``_/SecondMomentOfArea`` =
        Namespaced_IRI.parse _namespace_name "/SecondMomentOfArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SecondPolarMomentOfArea
    /// <see href="http://qudt.org/vocab/quantitykind/SecondPolarMomentOfArea"></see></summary>
    let ``_/SecondPolarMomentOfArea`` =
        Namespaced_IRI.parse _namespace_name "/SecondPolarMomentOfArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SecondRadiationConstant"></see>
    /// </summary>
    let ``_/SecondRadiationConstant`` =
        Namespaced_IRI.parse _namespace_name "/SecondRadiationConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SecondStageMassRatio"></see></summary>
    let ``_/SecondStageMassRatio`` =
        Namespaced_IRI.parse _namespace_name "/SecondStageMassRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SectionAreaIntegral
    /// <see href="http://qudt.org/vocab/quantitykind/SectionAreaIntegral"></see></summary>
    let ``_/SectionAreaIntegral`` =
        Namespaced_IRI.parse _namespace_name "/SectionAreaIntegral" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SectionModulus
    /// <see href="http://qudt.org/vocab/quantitykind/SectionModulus"></see></summary>
    let ``_/SectionModulus`` =
        Namespaced_IRI.parse _namespace_name "/SectionModulus" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SeebeckCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/SeebeckCoefficient"></see></summary>
    let ``_/SeebeckCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/SeebeckCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SerumLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SerumLevel"></see></summary>
    let ``_/SerumLevel`` =
        Namespaced_IRI.parse _namespace_name "/SerumLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/SerumOrPlasmaLevel"></see></summary>
    let ``_/SerumOrPlasmaLevel`` =
        Namespaced_IRI.parse _namespace_name "/SerumOrPlasmaLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ServiceFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ServiceFactor"></see></summary>
    let ``_/ServiceFactor`` =
        Namespaced_IRI.parse _namespace_name "/ServiceFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InformationEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/ShannonDiversityIndex"></see></summary>
    let ``_/ShannonDiversityIndex`` =
        Namespaced_IRI.parse _namespace_name "/ShannonDiversityIndex" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ShearModulus
    /// <see href="http://qudt.org/vocab/quantitykind/ShearModulus"></see></summary>
    let ``_/ShearModulus`` =
        Namespaced_IRI.parse _namespace_name "/ShearModulus" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ShearStrain"></see></summary>
    let ``_/ShearStrain`` =
        Namespaced_IRI.parse _namespace_name "/ShearStrain" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/ShearStress"></see></summary>
    let ``_/ShearStress`` =
        Namespaced_IRI.parse _namespace_name "/ShearStress" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Short-RangeOrderParameter
    /// <see href="http://qudt.org/vocab/quantitykind/Short-RangeOrderParameter"></see></summary>
    let ``_/Short-RangeOrderParameter`` =
        Namespaced_IRI.parse _namespace_name "/Short-RangeOrderParameter" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SignalDetectionThreshold
    /// <see href="http://qudt.org/vocab/quantitykind/SignalDetectionThreshold"></see></summary>
    let ``_/SignalDetectionThreshold`` =
        Namespaced_IRI.parse _namespace_name "/SignalDetectionThreshold" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SingleStageLauncherMassRatio"></see></summary>
    let ``_/SingleStageLauncherMassRatio`` =
        Namespaced_IRI.parse _namespace_name "/SingleStageLauncherMassRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/Slowing-DownArea"></see></summary>
    let ``_/Slowing-DownArea`` =
        Namespaced_IRI.parse _namespace_name "/Slowing-DownArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Slowing-DownDensity
    /// <see href="http://qudt.org/vocab/quantitykind/Slowing-DownDensity"></see></summary>
    let ``_/Slowing-DownDensity`` =
        Namespaced_IRI.parse _namespace_name "/Slowing-DownDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Slowing-DownLength"></see></summary>
    let ``_/Slowing-DownLength`` =
        Namespaced_IRI.parse _namespace_name "/Slowing-DownLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoilAdsorptionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/SoilAdsorptionCoefficient"></see></summary>
    let ``_/SoilAdsorptionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/SoilAdsorptionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SolidAngle
    /// <see href="http://qudt.org/vocab/quantitykind/SolidAngle"></see></summary>
    let ``_/SolidAngle`` =
        Namespaced_IRI.parse _namespace_name "/SolidAngle" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/SolidStateDiffusionLength"></see></summary>
    let ``_/SolidStateDiffusionLength`` =
        Namespaced_IRI.parse _namespace_name "/SolidStateDiffusionLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Concentration
    /// <see href="http://qudt.org/vocab/quantitykind/Solubility_Water"></see></summary>
    let ``_/Solubility_Water`` =
        Namespaced_IRI.parse _namespace_name "/Solubility_Water" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:WaterSolubility
    /// <see href="http://qudt.org/vocab/quantitykind/WaterSolubility"></see></summary>
    let ``_/WaterSolubility`` =
        Namespaced_IRI.parse _namespace_name "/WaterSolubility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SoundEnergyDensity"></see></summary>
    let ``_/SoundEnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/SoundEnergyDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundExposure
    /// <see href="http://qudt.org/vocab/quantitykind/SoundExposure"></see></summary>
    let ``_/SoundExposure`` =
        Namespaced_IRI.parse _namespace_name "/SoundExposure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundExposureLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SoundExposureLevel"></see></summary>
    let ``_/SoundExposureLevel`` =
        Namespaced_IRI.parse _namespace_name "/SoundExposureLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SoundIntensity"></see></summary>
    let ``_/SoundIntensity`` =
        Namespaced_IRI.parse _namespace_name "/SoundIntensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Acceleration
    /// <see href="http://qudt.org/vocab/quantitykind/SoundParticleAcceleration"></see></summary>
    let ``_/SoundParticleAcceleration`` =
        Namespaced_IRI.parse _namespace_name "/SoundParticleAcceleration" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/SoundParticleDisplacement"></see></summary>
    let ``_/SoundParticleDisplacement`` =
        Namespaced_IRI.parse _namespace_name "/SoundParticleDisplacement" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundParticleVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/SoundParticleVelocity"></see></summary>
    let ``_/SoundParticleVelocity`` =
        Namespaced_IRI.parse _namespace_name "/SoundParticleVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPower"></see></summary>
    let ``_/SoundPower`` =
        Namespaced_IRI.parse _namespace_name "/SoundPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPressure"></see></summary>
    let ``_/SoundPressure`` =
        Namespaced_IRI.parse _namespace_name "/SoundPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundPressureLevel
    /// <see href="http://qudt.org/vocab/quantitykind/SoundPressureLevel"></see></summary>
    let ``_/SoundPressureLevel`` =
        Namespaced_IRI.parse _namespace_name "/SoundPressureLevel" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundReductionIndex
    /// <see href="http://qudt.org/vocab/quantitykind/SoundReductionIndex"></see></summary>
    let ``_/SoundReductionIndex`` =
        Namespaced_IRI.parse _namespace_name "/SoundReductionIndex" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SoundVolumeVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/SoundVolumeVelocity"></see></summary>
    let ``_/SoundVolumeVelocity`` =
        Namespaced_IRI.parse _namespace_name "/SoundVolumeVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Voltage
    /// <see href="http://qudt.org/vocab/quantitykind/SourceVoltage"></see></summary>
    let ``_/SourceVoltage`` =
        Namespaced_IRI.parse _namespace_name "/SourceVoltage" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Voltage
    /// <see href="http://qudt.org/vocab/quantitykind/SourceVoltageBetweenSubstances"></see></summary>
    let ``_/SourceVoltageBetweenSubstances`` =
        Namespaced_IRI.parse _namespace_name "/SourceVoltageBetweenSubstances" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/SpatialSummationFunction"></see></summary>
    let ``_/SpatialSummationFunction`` =
        Namespaced_IRI.parse _namespace_name "/SpatialSummationFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificAcousticImpedance
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificAcousticImpedance"></see></summary>
    let ``_/SpecificAcousticImpedance`` =
        Namespaced_IRI.parse _namespace_name "/SpecificAcousticImpedance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificActivity
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificActivity"></see></summary>
    let ``_/SpecificActivity`` =
        Namespaced_IRI.parse _namespace_name "/SpecificActivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificElectricCharge
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificElectricCharge"></see></summary>
    let ``_/SpecificElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/SpecificElectricCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificElectricCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificElectricCurrent"></see></summary>
    let ``_/SpecificElectricCurrent`` =
        Namespaced_IRI.parse _namespace_name "/SpecificElectricCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEnergyImparted"></see></summary>
    let ``_/SpecificEnergyImparted`` =
        Namespaced_IRI.parse _namespace_name "/SpecificEnergyImparted" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificEntropy
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificEntropy"></see></summary>
    let ``_/SpecificEntropy`` =
        Namespaced_IRI.parse _namespace_name "/SpecificEntropy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacityAtConstantPressure
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantPressure"></see></summary>
    let ``_/SpecificHeatCapacityAtConstantPressure`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatCapacityAtConstantPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacityAtConstantVolume
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtConstantVolume"></see></summary>
    let ``_/SpecificHeatCapacityAtConstantVolume`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatCapacityAtConstantVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatCapacityAtSaturation
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatCapacityAtSaturation"></see></summary>
    let ``_/SpecificHeatCapacityAtSaturation`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatCapacityAtSaturation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatPressure
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatPressure"></see></summary>
    let ``_/SpecificHeatPressure`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificHeatVolume
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatVolume"></see></summary>
    let ``_/SpecificHeatVolume`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificHeatsRatio"></see></summary>
    let ``_/SpecificHeatsRatio`` =
        Namespaced_IRI.parse _namespace_name "/SpecificHeatsRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificImpulseByMass"></see></summary>
    let ``_/SpecificImpulseByMass`` =
        Namespaced_IRI.parse _namespace_name "/SpecificImpulseByMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificImpulseByWeight"></see></summary>
    let ``_/SpecificImpulseByWeight`` =
        Namespaced_IRI.parse _namespace_name "/SpecificImpulseByWeight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificModulus
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificModulus"></see></summary>
    let ``_/SpecificModulus`` =
        Namespaced_IRI.parse _namespace_name "/SpecificModulus" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpecificOpticalRotationalAbility"></see>
    /// </summary>
    let ``_/SpecificOpticalRotationalAbility`` =
        Namespaced_IRI.parse _namespace_name "/SpecificOpticalRotationalAbility" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificOpticalRotatoryPower
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificOpticalRotatoryPower"></see></summary>
    let ``_/SpecificOpticalRotatoryPower`` =
        Namespaced_IRI.parse _namespace_name "/SpecificOpticalRotatoryPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificSurfaceArea
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificSurfaceArea"></see></summary>
    let ``_/SpecificSurfaceArea`` =
        Namespaced_IRI.parse _namespace_name "/SpecificSurfaceArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpecificThrust"></see>
    /// </summary>
    let ``_/SpecificThrust`` =
        Namespaced_IRI.parse _namespace_name "/SpecificThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpecificWeight
    /// <see href="http://qudt.org/vocab/quantitykind/SpecificWeight"></see></summary>
    let ``_/SpecificWeight`` =
        Namespaced_IRI.parse _namespace_name "/SpecificWeight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpectralAngularCrossSection
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralAngularCrossSection"></see></summary>
    let ``_/SpectralAngularCrossSection`` =
        Namespaced_IRI.parse _namespace_name "/SpectralAngularCrossSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralConcentrationOfRadiantEnergyDensity"></see>
    /// </summary>
    let ``_/SpectralConcentrationOfRadiantEnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/SpectralConcentrationOfRadiantEnergyDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralConcentrationOfVibrationalModes"></see>
    /// </summary>
    let ``_/SpectralConcentrationOfVibrationalModes`` =
        Namespaced_IRI.parse _namespace_name "/SpectralConcentrationOfVibrationalModes" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpectralDensityOfVibrationalModes
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralDensityOfVibrationalModes"></see></summary>
    let ``_/SpectralDensityOfVibrationalModes`` =
        Namespaced_IRI.parse _namespace_name "/SpectralDensityOfVibrationalModes" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralEmittance"></see>
    /// </summary>
    let ``_/SpectralEmittance`` =
        Namespaced_IRI.parse _namespace_name "/SpectralEmittance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralIrradiance"></see>
    /// </summary>
    let ``_/SpectralIrradiance`` =
        Namespaced_IRI.parse _namespace_name "/SpectralIrradiance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralLuminousEfficiency"></see>
    /// </summary>
    let ``_/SpectralLuminousEfficiency`` =
        Namespaced_IRI.parse _namespace_name "/SpectralLuminousEfficiency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpectralRadiance
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralRadiance"></see></summary>
    let ``_/SpectralRadiance`` =
        Namespaced_IRI.parse _namespace_name "/SpectralRadiance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpectralRadiantEnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensity"></see></summary>
    let ``_/SpectralRadiantEnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/SpectralRadiantEnergyDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SpectralRadiantEnergyDensityInTermsOfWavelength"></see>
    /// </summary>
    let ``_/SpectralRadiantEnergyDensityInTermsOfWavelength`` =
        Namespaced_IRI.parse _namespace_name "/SpectralRadiantEnergyDensityInTermsOfWavelength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SpeedOfLight
    /// <see href="http://qudt.org/vocab/quantitykind/SpeedOfLight"></see></summary>
    let ``_/SpeedOfLight`` =
        Namespaced_IRI.parse _namespace_name "/SpeedOfLight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/SpeedRatio"></see></summary>
    let ``_/SpeedRatio`` =
        Namespaced_IRI.parse _namespace_name "/SpeedRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:LuminousFluxPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SphericalIlluminance"></see></summary>
    let ``_/SphericalIlluminance`` =
        Namespaced_IRI.parse _namespace_name "/SphericalIlluminance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/Spin"></see></summary>
    let ``_/Spin`` = Namespaced_IRI.parse _namespace_name "/Spin" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SquareTime
    /// <see href="http://qudt.org/vocab/quantitykind/SquareTime"></see></summary>
    let ``_/SquareTime`` =
        Namespaced_IRI.parse _namespace_name "/SquareTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/StagePropellantMass"></see></summary>
    let ``_/StagePropellantMass`` =
        Namespaced_IRI.parse _namespace_name "/StagePropellantMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/StageStructuralMass"></see></summary>
    let ``_/StageStructuralMass`` =
        Namespaced_IRI.parse _namespace_name "/StageStructuralMass" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StandardAbsoluteActivity
    /// <see href="http://qudt.org/vocab/quantitykind/StandardAbsoluteActivity"></see></summary>
    let ``_/StandardAbsoluteActivity`` =
        Namespaced_IRI.parse _namespace_name "/StandardAbsoluteActivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MolarEnergy
    /// <see href="http://qudt.org/vocab/quantitykind/StandardChemicalPotential"></see></summary>
    let ``_/StandardChemicalPotential`` =
        Namespaced_IRI.parse _namespace_name "/StandardChemicalPotential" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StandardGravitationalParameter
    /// <see href="http://qudt.org/vocab/quantitykind/StandardGravitationalParameter"></see></summary>
    let ``_/StandardGravitationalParameter`` =
        Namespaced_IRI.parse _namespace_name "/StandardGravitationalParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/StateDensity"></see>
    /// </summary>
    let ``_/StateDensity`` =
        Namespaced_IRI.parse _namespace_name "/StateDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/StateDensityAsExpressionOfAngularFrequency"></see>
    /// </summary>
    let ``_/StateDensityAsExpressionOfAngularFrequency`` =
        Namespaced_IRI.parse _namespace_name "/StateDensityAsExpressionOfAngularFrequency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StateOfCharge
    /// <see href="http://qudt.org/vocab/quantitykind/StateOfCharge"></see></summary>
    let ``_/StateOfCharge`` =
        Namespaced_IRI.parse _namespace_name "/StateOfCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/StaticFriction"></see></summary>
    let ``_/StaticFriction`` =
        Namespaced_IRI.parse _namespace_name "/StaticFriction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:FrictionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/StaticFrictionCoefficient"></see></summary>
    let ``_/StaticFrictionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/StaticFrictionCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/StaticPressure"></see></summary>
    let ``_/StaticPressure`` =
        Namespaced_IRI.parse _namespace_name "/StaticPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StatisticalWeight
    /// <see href="http://qudt.org/vocab/quantitykind/StatisticalWeight"></see></summary>
    let ``_/StatisticalWeight`` =
        Namespaced_IRI.parse _namespace_name "/StatisticalWeight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StoichiometricNumber
    /// <see href="http://qudt.org/vocab/quantitykind/StoichiometricNumber"></see></summary>
    let ``_/StoichiometricNumber`` =
        Namespaced_IRI.parse _namespace_name "/StoichiometricNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyDensity
    /// <see href="http://qudt.org/vocab/quantitykind/StrainEnergyDensity"></see></summary>
    let ``_/StrainEnergyDensity`` =
        Namespaced_IRI.parse _namespace_name "/StrainEnergyDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StrainEnergyReleaseRate
    /// <see href="http://qudt.org/vocab/quantitykind/StrainEnergyReleaseRate"></see></summary>
    let ``_/StrainEnergyReleaseRate`` =
        Namespaced_IRI.parse _namespace_name "/StrainEnergyReleaseRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StressIntensityFactor
    /// <see href="http://qudt.org/vocab/quantitykind/StressIntensityFactor"></see></summary>
    let ``_/StressIntensityFactor`` =
        Namespaced_IRI.parse _namespace_name "/StressIntensityFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StressOpticCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/StressOpticCoefficient"></see></summary>
    let ``_/StressOpticCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/StressOpticCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/StructuralEfficiency"></see></summary>
    let ``_/StructuralEfficiency`` =
        Namespaced_IRI.parse _namespace_name "/StructuralEfficiency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:StructureFactor
    /// <see href="http://qudt.org/vocab/quantitykind/StructureFactor"></see></summary>
    let ``_/StructureFactor`` =
        Namespaced_IRI.parse _namespace_name "/StructureFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SunProtectionFactorOfAProduct
    /// <see href="http://qudt.org/vocab/quantitykind/SunProtectionFactorOfAProduct"></see></summary>
    let ``_/SunProtectionFactorOfAProduct`` =
        Namespaced_IRI.parse _namespace_name "/SunProtectionFactorOfAProduct" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/SuperconductorEnergyGap"></see></summary>
    let ``_/SuperconductorEnergyGap`` =
        Namespaced_IRI.parse _namespace_name "/SuperconductorEnergyGap" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceActivityDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceActivityDensity"></see></summary>
    let ``_/SurfaceActivityDensity`` =
        Namespaced_IRI.parse _namespace_name "/SurfaceActivityDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceCoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceCoefficientOfHeatTransfer"></see></summary>
    let ``_/SurfaceCoefficientOfHeatTransfer`` =
        Namespaced_IRI.parse _namespace_name "/SurfaceCoefficientOfHeatTransfer" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceDensity"></see></summary>
    let ``_/SurfaceDensity`` =
        Namespaced_IRI.parse _namespace_name "/SurfaceDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceRelatedVolumeFlow
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlow"></see></summary>
    let ``_/SurfaceRelatedVolumeFlow`` =
        Namespaced_IRI.parse _namespace_name "/SurfaceRelatedVolumeFlow" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:SurfaceRelatedVolumeFlowRate
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceRelatedVolumeFlowRate"></see></summary>
    let ``_/SurfaceRelatedVolumeFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/SurfaceRelatedVolumeFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/SurfaceTension"></see></summary>
    let ``_/SurfaceTension`` =
        Namespaced_IRI.parse _namespace_name "/SurfaceTension" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SurgeImpedanceOfTheMedium"></see>
    /// </summary>
    let ``_/SurgeImpedanceOfTheMedium`` =
        Namespaced_IRI.parse _namespace_name "/SurgeImpedanceOfTheMedium" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Susceptance"></see>
    /// </summary>
    let ``_/Susceptance`` =
        Namespaced_IRI.parse _namespace_name "/Susceptance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/SymbolTransmissionRate"></see>
    /// </summary>
    let ``_/SymbolTransmissionRate`` =
        Namespaced_IRI.parse _namespace_name "/SymbolTransmissionRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Mass
    /// <see href="http://qudt.org/vocab/quantitykind/TARGET-BOGIE-MASS"></see></summary>
    let ``_/TARGET-BOGIE-MASS`` =
        Namespaced_IRI.parse _namespace_name "/TARGET-BOGIE-MASS" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureAmountOfSubstance
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureAmountOfSubstance"></see></summary>
    let ``_/TemperatureAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureAmountOfSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedAmountOfSubstanceConcentration"></see>
    /// </summary>
    let ``_/TemperatureBasedAmountOfSubstanceConcentration`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedAmountOfSubstanceConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedDensity"></see>
    /// </summary>
    let ``_/TemperatureBasedDensity`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedDynamicViscosity"></see>
    /// </summary>
    let ``_/TemperatureBasedDynamicViscosity`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedDynamicViscosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedKinematicViscosity"></see>
    /// </summary>
    let ``_/TemperatureBasedKinematicViscosity`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedKinematicViscosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedLength"></see>
    /// </summary>
    let ``_/TemperatureBasedLength`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedMass"></see>
    /// </summary>
    let ``_/TemperatureBasedMass`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedMassFlowRate"></see>
    /// </summary>
    let ``_/TemperatureBasedMassFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedMassFlowRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedQuantity"></see>
    /// </summary>
    let ``_/TemperatureBasedQuantity`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedVelocity"></see>
    /// </summary>
    let ``_/TemperatureBasedVelocity`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedVelocity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureBasedVolumeFlowRate"></see>
    /// </summary>
    let ``_/TemperatureBasedVolumeFlowRate`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureBasedVolumeFlowRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureDifference"></see></summary>
    let ``_/TemperatureDifference`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureDifference" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureGradient
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureGradient"></see></summary>
    let ``_/TemperatureGradient`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureGradient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerMagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/TemperaturePerMagneticFluxDensity"></see></summary>
    let ``_/TemperaturePerMagneticFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/TemperaturePerMagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerSquareTime
    /// <see href="http://qudt.org/vocab/quantitykind/TemperaturePerSquareTime"></see></summary>
    let ``_/TemperaturePerSquareTime`` =
        Namespaced_IRI.parse _namespace_name "/TemperaturePerSquareTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerTime
    /// <see href="http://qudt.org/vocab/quantitykind/TemperaturePerTime"></see></summary>
    let ``_/TemperaturePerTime`` =
        Namespaced_IRI.parse _namespace_name "/TemperaturePerTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperaturePerTime_Squared"></see>
    /// </summary>
    let ``_/TemperaturePerTime_Squared`` =
        Namespaced_IRI.parse _namespace_name "/TemperaturePerTime_Squared" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperaturePerTime
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureRateOfChange"></see></summary>
    let ``_/TemperatureRateOfChange`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureRateOfChange" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureRatio
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureRatio"></see></summary>
    let ``_/TemperatureRatio`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureRelatedMolarMass"></see>
    /// </summary>
    let ``_/TemperatureRelatedMolarMass`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureRelatedMolarMass" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureRelatedVolume"></see>
    /// </summary>
    let ``_/TemperatureRelatedVolume`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureRelatedVolume" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemperatureVariance
    /// <see href="http://qudt.org/vocab/quantitykind/TemperatureVariance"></see></summary>
    let ``_/TemperatureVariance`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureVariance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TemperatureVariance_NEON"></see>
    /// </summary>
    let ``_/TemperatureVariance_NEON`` =
        Namespaced_IRI.parse _namespace_name "/TemperatureVariance_NEON" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TemporalSummationFunction
    /// <see href="http://qudt.org/vocab/quantitykind/TemporalSummationFunction"></see></summary>
    let ``_/TemporalSummationFunction`` =
        Namespaced_IRI.parse _namespace_name "/TemporalSummationFunction" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Tension"></see></summary>
    let ``_/Tension`` =
        Namespaced_IRI.parse _namespace_name "/Tension" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalAdmittance"></see></summary>
    let ``_/ThermalAdmittance`` =
        Namespaced_IRI.parse _namespace_name "/ThermalAdmittance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalCapacitance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalCapacitance"></see></summary>
    let ``_/ThermalCapacitance`` =
        Namespaced_IRI.parse _namespace_name "/ThermalCapacitance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThermalCoefficientOfLinearExpansion"></see>
    /// </summary>
    let ``_/ThermalCoefficientOfLinearExpansion`` =
        Namespaced_IRI.parse _namespace_name "/ThermalCoefficientOfLinearExpansion" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalConductance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalConductance"></see></summary>
    let ``_/ThermalConductance`` =
        Namespaced_IRI.parse _namespace_name "/ThermalConductance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalConductivity
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalConductivity"></see></summary>
    let ``_/ThermalConductivity`` =
        Namespaced_IRI.parse _namespace_name "/ThermalConductivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalDiffusionFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusionFactor"></see></summary>
    let ``_/ThermalDiffusionFactor`` =
        Namespaced_IRI.parse _namespace_name "/ThermalDiffusionFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalDiffusionRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusionRatio"></see></summary>
    let ``_/ThermalDiffusionRatio`` =
        Namespaced_IRI.parse _namespace_name "/ThermalDiffusionRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalDiffusionRatioCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusionRatioCoefficient"></see></summary>
    let ``_/ThermalDiffusionRatioCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/ThermalDiffusionRatioCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AreaPerTime
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalDiffusivity"></see></summary>
    let ``_/ThermalDiffusivity`` =
        Namespaced_IRI.parse _namespace_name "/ThermalDiffusivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalEfficiency"></see></summary>
    let ``_/ThermalEfficiency`` =
        Namespaced_IRI.parse _namespace_name "/ThermalEfficiency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalEnergyLength
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalEnergyLength"></see></summary>
    let ``_/ThermalEnergyLength`` =
        Namespaced_IRI.parse _namespace_name "/ThermalEnergyLength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalExpansionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalExpansionCoefficient"></see></summary>
    let ``_/ThermalExpansionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/ThermalExpansionCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThermalInertia"></see>
    /// </summary>
    let ``_/ThermalInertia`` =
        Namespaced_IRI.parse _namespace_name "/ThermalInertia" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalInsulance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalInsulance"></see></summary>
    let ``_/ThermalInsulance`` =
        Namespaced_IRI.parse _namespace_name "/ThermalInsulance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThermalInsulation"></see>
    /// </summary>
    let ``_/ThermalInsulation`` =
        Namespaced_IRI.parse _namespace_name "/ThermalInsulation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalResistance
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalResistance"></see></summary>
    let ``_/ThermalResistance`` =
        Namespaced_IRI.parse _namespace_name "/ThermalResistance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalResistivity
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalResistivity"></see></summary>
    let ``_/ThermalResistivity`` =
        Namespaced_IRI.parse _namespace_name "/ThermalResistivity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:CoefficientOfHeatTransfer
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalTransmittance"></see></summary>
    let ``_/ThermalTransmittance`` =
        Namespaced_IRI.parse _namespace_name "/ThermalTransmittance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThermalUtilizationFactor
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalUtilizationFactor"></see></summary>
    let ``_/ThermalUtilizationFactor`` =
        Namespaced_IRI.parse _namespace_name "/ThermalUtilizationFactor" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Dimensionless
    /// <see href="http://qudt.org/vocab/quantitykind/ThermalUtilizationFactorForFission"></see></summary>
    let ``_/ThermalUtilizationFactorForFission`` =
        Namespaced_IRI.parse _namespace_name "/ThermalUtilizationFactorForFission" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:MagneticFluxDensity
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicCriticalMagneticFluxDensity"></see></summary>
    let ``_/ThermodynamicCriticalMagneticFluxDensity`` =
        Namespaced_IRI.parse _namespace_name "/ThermodynamicCriticalMagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:EnergyPerTemperature
    /// <see href="http://qudt.org/vocab/quantitykind/ThermodynamicEntropy"></see></summary>
    let ``_/ThermodynamicEntropy`` =
        Namespaced_IRI.parse _namespace_name "/ThermodynamicEntropy" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Thickness"></see></summary>
    let ``_/Thickness`` =
        Namespaced_IRI.parse _namespace_name "/Thickness" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThomsonCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/ThomsonCoefficient"></see></summary>
    let ``_/ThomsonCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/ThomsonCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/ThrustCoefficient"></see>
    /// </summary>
    let ``_/ThrustCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/ThrustCoefficient" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThrustToMassRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThrustToMassRatio"></see></summary>
    let ``_/ThrustToMassRatio`` =
        Namespaced_IRI.parse _namespace_name "/ThrustToMassRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/ThrustToWeightRatio"></see></summary>
    let ``_/ThrustToWeightRatio`` =
        Namespaced_IRI.parse _namespace_name "/ThrustToWeightRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ThrusterPowerToThrustEfficiency
    /// <see href="http://qudt.org/vocab/quantitykind/ThrusterPowerToThrustEfficiency"></see></summary>
    let ``_/ThrusterPowerToThrustEfficiency`` =
        Namespaced_IRI.parse _namespace_name "/ThrusterPowerToThrustEfficiency" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Angle
    /// <see href="http://qudt.org/vocab/quantitykind/Tilt"></see></summary>
    let ``_/Tilt`` = Namespaced_IRI.parse _namespace_name "/Tilt" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:PowerPerArea
    /// <see href="http://qudt.org/vocab/quantitykind/TimeAveragedSoundIntensity"></see></summary>
    let ``_/TimeAveragedSoundIntensity`` =
        Namespaced_IRI.parse _namespace_name "/TimeAveragedSoundIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TimeConstant_Inductance"></see>
    /// </summary>
    let ``_/TimeConstant_Inductance`` =
        Namespaced_IRI.parse _namespace_name "/TimeConstant_Inductance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TimePerCount
    /// <see href="http://qudt.org/vocab/quantitykind/TimePerCount"></see></summary>
    let ``_/TimePerCount`` =
        Namespaced_IRI.parse _namespace_name "/TimePerCount" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TimeRatio
    /// <see href="http://qudt.org/vocab/quantitykind/TimeRatio"></see></summary>
    let ``_/TimeRatio`` =
        Namespaced_IRI.parse _namespace_name "/TimeRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TimeRelatedLogarithmicRatio"></see>
    /// </summary>
    let ``_/TimeRelatedLogarithmicRatio`` =
        Namespaced_IRI.parse _namespace_name "/TimeRelatedLogarithmicRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/Time_Squared"></see>
    /// </summary>
    let ``_/Time_Squared`` =
        Namespaced_IRI.parse _namespace_name "/Time_Squared" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TorqueConstant"></see>
    /// </summary>
    let ``_/TorqueConstant`` =
        Namespaced_IRI.parse _namespace_name "/TorqueConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TorquePerLength
    /// <see href="http://qudt.org/vocab/quantitykind/TorquePerLength"></see></summary>
    let ``_/TorquePerLength`` =
        Namespaced_IRI.parse _namespace_name "/TorquePerLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TorsionalRigidity"></see>
    /// </summary>
    let ``_/TorsionalRigidity`` =
        Namespaced_IRI.parse _namespace_name "/TorsionalRigidity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TorsionalSpringConstant
    /// <see href="http://qudt.org/vocab/quantitykind/TorsionalSpringConstant"></see></summary>
    let ``_/TorsionalSpringConstant`` =
        Namespaced_IRI.parse _namespace_name "/TorsionalSpringConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularMomentum
    /// <see href="http://qudt.org/vocab/quantitykind/TotalAngularMomentum"></see></summary>
    let ``_/TotalAngularMomentum`` =
        Namespaced_IRI.parse _namespace_name "/TotalAngularMomentum" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalAngularMomentumQuantumNumber
    /// <see href="http://qudt.org/vocab/quantitykind/TotalAngularMomentumQuantumNumber"></see></summary>
    let ``_/TotalAngularMomentumQuantumNumber`` =
        Namespaced_IRI.parse _namespace_name "/TotalAngularMomentumQuantumNumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalAtomicStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/TotalAtomicStoppingPower"></see></summary>
    let ``_/TotalAtomicStoppingPower`` =
        Namespaced_IRI.parse _namespace_name "/TotalAtomicStoppingPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Area
    /// <see href="http://qudt.org/vocab/quantitykind/TotalCrossSection"></see></summary>
    let ``_/TotalCrossSection`` =
        Namespaced_IRI.parse _namespace_name "/TotalCrossSection" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalCurrent
    /// <see href="http://qudt.org/vocab/quantitykind/TotalCurrent"></see></summary>
    let ``_/TotalCurrent`` =
        Namespaced_IRI.parse _namespace_name "/TotalCurrent" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalCurrentDensity
    /// <see href="http://qudt.org/vocab/quantitykind/TotalCurrentDensity"></see></summary>
    let ``_/TotalCurrentDensity`` =
        Namespaced_IRI.parse _namespace_name "/TotalCurrentDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalIonization
    /// <see href="http://qudt.org/vocab/quantitykind/TotalIonization"></see></summary>
    let ``_/TotalIonization`` =
        Namespaced_IRI.parse _namespace_name "/TotalIonization" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalLinearStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/TotalLinearStoppingPower"></see></summary>
    let ``_/TotalLinearStoppingPower`` =
        Namespaced_IRI.parse _namespace_name "/TotalLinearStoppingPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TotalMassStoppingPower
    /// <see href="http://qudt.org/vocab/quantitykind/TotalMassStoppingPower"></see></summary>
    let ``_/TotalMassStoppingPower`` =
        Namespaced_IRI.parse _namespace_name "/TotalMassStoppingPower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/TotalPressure"></see></summary>
    let ``_/TotalPressure`` =
        Namespaced_IRI.parse _namespace_name "/TotalPressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TotalRadiance"></see>
    /// </summary>
    let ``_/TotalRadiance`` =
        Namespaced_IRI.parse _namespace_name "/TotalRadiance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TouchThresholds"></see>
    /// </summary>
    let ``_/TouchThresholds`` =
        Namespaced_IRI.parse _namespace_name "/TouchThresholds" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TrafficIntensity"></see>
    /// </summary>
    let ``_/TrafficIntensity`` =
        Namespaced_IRI.parse _namespace_name "/TrafficIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/TransmissionRatioBetweenRotationAndTranslation"></see>
    /// </summary>
    let ``_/TransmissionRatioBetweenRotationAndTranslation`` =
        Namespaced_IRI.parse _namespace_name "/TransmissionRatioBetweenRotationAndTranslation" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/Transmittance"></see></summary>
    let ``_/Transmittance`` =
        Namespaced_IRI.parse _namespace_name "/Transmittance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:TransmittanceDensity
    /// <see href="http://qudt.org/vocab/quantitykind/TransmittanceDensity"></see></summary>
    let ``_/TransmittanceDensity`` =
        Namespaced_IRI.parse _namespace_name "/TransmittanceDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/TrueExhaustVelocity"></see></summary>
    let ``_/TrueExhaustVelocity`` =
        Namespaced_IRI.parse _namespace_name "/TrueExhaustVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Turbidity
    /// <see href="http://qudt.org/vocab/quantitykind/Turbidity"></see></summary>
    let ``_/Turbidity`` =
        Namespaced_IRI.parse _namespace_name "/Turbidity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Turns
    /// <see href="http://qudt.org/vocab/quantitykind/Turns"></see></summary>
    let ``_/Turns`` = Namespaced_IRI.parse _namespace_name "/Turns" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Unbalance
    /// <see href="http://qudt.org/vocab/quantitykind/Unbalance"></see></summary>
    let ``_/Unbalance`` =
        Namespaced_IRI.parse _namespace_name "/Unbalance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Unknown
    /// <see href="http://qudt.org/vocab/quantitykind/Unknown"></see></summary>
    let ``_/Unknown`` =
        Namespaced_IRI.parse _namespace_name "/Unknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VaporPermeability"></see>
    /// </summary>
    let ``_/VaporPermeability`` =
        Namespaced_IRI.parse _namespace_name "/VaporPermeability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VapourPermeability
    /// <see href="http://qudt.org/vocab/quantitykind/VapourPermeability"></see></summary>
    let ``_/VapourPermeability`` =
        Namespaced_IRI.parse _namespace_name "/VapourPermeability" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VaporPermeance"></see>
    /// </summary>
    let ``_/VaporPermeance`` =
        Namespaced_IRI.parse _namespace_name "/VaporPermeance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VapourPermeance
    /// <see href="http://qudt.org/vocab/quantitykind/VapourPermeance"></see></summary>
    let ``_/VapourPermeance`` =
        Namespaced_IRI.parse _namespace_name "/VapourPermeance" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VaporPressure
    /// <see href="http://qudt.org/vocab/quantitykind/VaporPressure"></see></summary>
    let ``_/VaporPressure`` =
        Namespaced_IRI.parse _namespace_name "/VaporPressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VentilationRatePerFloorArea
    /// <see href="http://qudt.org/vocab/quantitykind/VentilationRatePerFloorArea"></see></summary>
    let ``_/VentilationRatePerFloorArea`` =
        Namespaced_IRI.parse _namespace_name "/VentilationRatePerFloorArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Velocity
    /// <see href="http://qudt.org/vocab/quantitykind/VerticalVelocity"></see></summary>
    let ``_/VerticalVelocity`` =
        Namespaced_IRI.parse _namespace_name "/VerticalVelocity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VideoFrameRate
    /// <see href="http://qudt.org/vocab/quantitykind/VideoFrameRate"></see></summary>
    let ``_/VideoFrameRate`` =
        Namespaced_IRI.parse _namespace_name "/VideoFrameRate" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/VisibleRadiantEnergy"></see></summary>
    let ``_/VisibleRadiantEnergy`` =
        Namespaced_IRI.parse _namespace_name "/VisibleRadiantEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VisionThresholds"></see>
    /// </summary>
    let ``_/VisionThresholds`` =
        Namespaced_IRI.parse _namespace_name "/VisionThresholds" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VoltageRatio
    /// <see href="http://qudt.org/vocab/quantitykind/VoltageRatio"></see></summary>
    let ``_/VoltageRatio`` =
        Namespaced_IRI.parse _namespace_name "/VoltageRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumeDensityOfCharge"></see>
    /// </summary>
    let ``_/VolumeDensityOfCharge`` =
        Namespaced_IRI.parse _namespace_name "/VolumeDensityOfCharge" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumePerTime
    /// <see href="http://qudt.org/vocab/quantitykind/VolumePerTime"></see></summary>
    let ``_/VolumePerTime`` =
        Namespaced_IRI.parse _namespace_name "/VolumePerTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumeFlowRate_SurfaceRelated"></see>
    /// </summary>
    let ``_/VolumeFlowRate_SurfaceRelated`` =
        Namespaced_IRI.parse _namespace_name "/VolumeFlowRate_SurfaceRelated" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeFlowRatio"></see></summary>
    let ``_/VolumeFlowRatio`` =
        Namespaced_IRI.parse _namespace_name "/VolumeFlowRatio" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumeFraction
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeFraction"></see></summary>
    let ``_/VolumeFraction`` =
        Namespaced_IRI.parse _namespace_name "/VolumeFraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumeOrSectionModulus"></see>
    /// </summary>
    let ``_/VolumeOrSectionModulus`` =
        Namespaced_IRI.parse _namespace_name "/VolumeOrSectionModulus" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/VolumePerArea"></see></summary>
    let ``_/VolumePerArea`` =
        Namespaced_IRI.parse _namespace_name "/VolumePerArea" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:DimensionlessRatio
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeStrain"></see></summary>
    let ``_/VolumeStrain`` =
        Namespaced_IRI.parse _namespace_name "/VolumeStrain" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumeThermalExpansion
    /// <see href="http://qudt.org/vocab/quantitykind/VolumeThermalExpansion"></see></summary>
    let ``_/VolumeThermalExpansion`` =
        Namespaced_IRI.parse _namespace_name "/VolumeThermalExpansion" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumetricBitDensity
    /// <see href="http://qudt.org/vocab/quantitykind/VolumetricBitDensity"></see></summary>
    let ``_/VolumetricBitDensity`` =
        Namespaced_IRI.parse _namespace_name "/VolumetricBitDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumetricElectricCharge"></see>
    /// </summary>
    let ``_/VolumetricElectricCharge`` =
        Namespaced_IRI.parse _namespace_name "/VolumetricElectricCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumetricEntityDensity"></see>
    /// </summary>
    let ``_/VolumetricEntityDensity`` =
        Namespaced_IRI.parse _namespace_name "/VolumetricEntityDensity" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumetricFlux
    /// <see href="http://qudt.org/vocab/quantitykind/VolumetricFlux"></see></summary>
    let ``_/VolumetricFlux`` =
        Namespaced_IRI.parse _namespace_name "/VolumetricFlux" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:VolumetricHeatCapacity
    /// <see href="http://qudt.org/vocab/quantitykind/VolumetricHeatCapacity"></see></summary>
    let ``_/VolumetricHeatCapacity`` =
        Namespaced_IRI.parse _namespace_name "/VolumetricHeatCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumetricOutputPower"></see>
    /// </summary>
    let ``_/VolumetricOutputPower`` =
        Namespaced_IRI.parse _namespace_name "/VolumetricOutputPower" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumicAmountOfSubstance"></see>
    /// </summary>
    let ``_/VolumicAmountOfSubstance`` =
        Namespaced_IRI.parse _namespace_name "/VolumicAmountOfSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumicDataQuantity"></see>
    /// </summary>
    let ``_/VolumicDataQuantity`` =
        Namespaced_IRI.parse _namespace_name "/VolumicDataQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/VolumicOutput"></see>
    /// </summary>
    let ``_/VolumicOutput`` =
        Namespaced_IRI.parse _namespace_name "/VolumicOutput" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:AngularVelocity
    /// <see href="http://qudt.org/vocab/quantitykind/Vorticity"></see></summary>
    let ``_/Vorticity`` =
        Namespaced_IRI.parse _namespace_name "/Vorticity" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/WarmReceptorThreshold"></see>
    /// </summary>
    let ``_/WarmReceptorThreshold`` =
        Namespaced_IRI.parse _namespace_name "/WarmReceptorThreshold" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:WarpingConstant
    /// <see href="http://qudt.org/vocab/quantitykind/WarpingConstant"></see></summary>
    let ``_/WarpingConstant`` =
        Namespaced_IRI.parse _namespace_name "/WarpingConstant" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:WarpingMoment
    /// <see href="http://qudt.org/vocab/quantitykind/WarpingMoment"></see></summary>
    let ``_/WarpingMoment`` =
        Namespaced_IRI.parse _namespace_name "/WarpingMoment" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Power
    /// <see href="http://qudt.org/vocab/quantitykind/WaterHorsepower"></see></summary>
    let ``_/WaterHorsepower`` =
        Namespaced_IRI.parse _namespace_name "/WaterHorsepower" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:WaterVaporDiffusionCoefficient
    /// <see href="http://qudt.org/vocab/quantitykind/WaterVaporDiffusionCoefficient"></see></summary>
    let ``_/WaterVaporDiffusionCoefficient`` =
        Namespaced_IRI.parse _namespace_name "/WaterVaporDiffusionCoefficient" |> NamespacedName

    /// <summary>
    ///   <see href="http://qudt.org/vocab/quantitykind/WaterVapourPermeability"></see>
    /// </summary>
    let ``_/WaterVapourPermeability`` =
        Namespaced_IRI.parse _namespace_name "/WaterVapourPermeability" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Wavelength"></see></summary>
    let ``_/Wavelength`` =
        Namespaced_IRI.parse _namespace_name "/Wavelength" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:InverseLength
    /// <see href="http://qudt.org/vocab/quantitykind/Wavenumber"></see></summary>
    let ``_/Wavenumber`` =
        Namespaced_IRI.parse _namespace_name "/Wavenumber" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Time
    /// <see href="http://qudt.org/vocab/quantitykind/WebTime"></see></summary>
    let ``_/WebTime`` =
        Namespaced_IRI.parse _namespace_name "/WebTime" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:ForcePerArea
    /// <see href="http://qudt.org/vocab/quantitykind/WebTimeAveragePressure"></see></summary>
    let ``_/WebTimeAveragePressure`` =
        Namespaced_IRI.parse _namespace_name "/WebTimeAveragePressure" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// Web Time Avg Thrust (Mlbf)
    /// <see href="http://qudt.org/vocab/quantitykind/WebTimeAverageThrust"></see></summary>
    let ``_/WebTimeAverageThrust`` =
        Namespaced_IRI.parse _namespace_name "/WebTimeAverageThrust" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Force
    /// <see href="http://qudt.org/vocab/quantitykind/Weight"></see></summary>
    let ``_/Weight`` = Namespaced_IRI.parse _namespace_name "/Weight" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Temperature
    /// <see href="http://qudt.org/vocab/quantitykind/WetBulbTemperature"></see></summary>
    let ``_/WetBulbTemperature`` =
        Namespaced_IRI.parse _namespace_name "/WetBulbTemperature" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Length
    /// <see href="http://qudt.org/vocab/quantitykind/Width"></see></summary>
    let ``_/Width`` = Namespaced_IRI.parse _namespace_name "/Width" |> NamespacedName

    /// <summary>
    /// Applicable units are those of quantitykind:Energy
    /// <see href="http://qudt.org/vocab/quantitykind/WorkFunction"></see></summary>
    let ``_/WorkFunction`` =
        Namespaced_IRI.parse _namespace_name "/WorkFunction" |> NamespacedName
