#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oum =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.ontology-of-units-of-measure.org/resource/om-2/" "oum"

    let _namespaceIri = _prefixId.prefix ""
    let AFS = _prefixId.prefix "AFS"
    /// <summary>
    ///   <para>rdfs:label : aberration</para>
    ///   <para>rdfs:comment : The apparent angular displacement of the observed position of a celestial object from its geometric position, caused by the finite velocity of light in combination with the motions of the observer and of the observed object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Aberration">oum:Aberration</a>
    /// </summary>
    let Aberration = _prefixId.prefix "Aberration"
    /// <summary>
    ///   <para>oum:symbol : Δβ^^xsd:string</para>
    ///   <para>rdfs:comment : The apparent angular displacement in ecliptical latitude of the observed position of a celestial object from its geometric position, caused by the finite velocity of light in combination with the motions of the observer and of the observed object.</para>
    ///   <para>rdfs:label : aberration in latitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AberrationInLatitude">oum:AberrationInLatitude</a>
    /// </summary>
    let AberrationInLatitude = _prefixId.prefix "AberrationInLatitude"
    /// <summary>
    ///   <para>rdfs:label : aberration in longitude</para>
    ///   <para>rdfs:comment : The apparent angular displacement in ecliptical longitude of the observed position of a celestial object from its geometric position, caused by the finite velocity of light in combination with the motions of the observer and of the observed object.</para>
    ///   <para>oum:symbol : Δλ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AberrationInLongitude">oum:AberrationInLongitude</a>
    /// </summary>
    let AberrationInLongitude = _prefixId.prefix "AberrationInLongitude"
    /// <summary>
    ///   <para>oum:symbol : M_bol^^xsd:string</para>
    ///   <para>rdfs:label : absolute bolometric magnitude</para>
    ///   <para>rdfs:comment : The absolute magnitude (see absolute magnitude) of a star is a measure of its total energy emission per second, or luminosity, i.e., the bolometric magnitude from a standard distance (10 pc).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AbsoluteBolometricMagnitude">oum:AbsoluteBolometricMagnitude</a>
    /// </summary>
    let AbsoluteBolometricMagnitude = _prefixId.prefix "AbsoluteBolometricMagnitude"
    /// <summary>
    ///   <para>oum:symbol : M^^xsd:string</para>
    ///   <para>rdfs:label : absolute magnituderdfs:label : absolute magnitude</para>
    ///   <para>rdfs:comment : Logarithmic measure of the brightness of an object as seen from a standard distance of 10 pc. Units usually not indicated (http://en.wikipedia.org/wiki/Magnitude_(astronomy).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AbsoluteMagnitude">oum:AbsoluteMagnitude</a>
    /// </summary>
    let AbsoluteMagnitude = _prefixId.prefix "AbsoluteMagnitude"
    /// <summary>
    ///   <para>rdfs:label : absorbed dose</para>
    ///   <para>rdfs:comment : Absorbed dose is the energy deposited in a medium by ionizing radiation. It is a derived quantity in the International System of Units. Absorbed dose is energy divided by mass.</para>
    ///   <para>oum:alternativeLabel : total ionizing dose</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AbsorbedDose">oum:AbsorbedDose</a>
    /// </summary>
    let AbsorbedDose = _prefixId.prefix "AbsorbedDose"
    /// <summary>
    ///   <para>rdfs:label : absorbed dose rate</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AbsorbedDoseRate">oum:AbsorbedDoseRate</a>
    /// </summary>
    let AbsorbedDoseRate = _prefixId.prefix "AbsorbedDoseRate"
    /// <summary>
    ///   <para>rdfs:label : absorbed dose rate unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AbsorbedDoseRateUnit">oum:AbsorbedDoseRateUnit</a>
    /// </summary>
    let AbsorbedDoseRateUnit = _prefixId.prefix "AbsorbedDoseRateUnit"
    /// <summary>
    ///   <para>rdfs:label : absorbed dose unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AbsorbedDoseUnit">oum:AbsorbedDoseUnit</a>
    /// </summary>
    let AbsorbedDoseUnit = _prefixId.prefix "AbsorbedDoseUnit"
    /// <summary>
    ///   <para>rdfs:label : accelerationrdfs:label : versnelling</para>
    ///   <para>oum:alternativeLabel : acceleratie</para>
    ///   <para>oum:symbol : a^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Acceleration">oum:Acceleration</a>
    /// </summary>
    let Acceleration = _prefixId.prefix "Acceleration"
    /// <summary>
    ///   <para>rdfs:label : acceleration unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AccelerationUnit">oum:AccelerationUnit</a>
    /// </summary>
    let AccelerationUnit = _prefixId.prefix "AccelerationUnit"
    /// <summary>
    ///   <para>rdfs:label : acetic acid mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of acetic acid in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AceticAcidMassFraction">oum:AceticAcidMassFraction</a>
    /// </summary>
    let AceticAcidMassFraction = _prefixId.prefix "AceticAcidMassFraction"
    /// <summary>
    ///   <para>oum:symbol : pH^^xsd:string</para>
    ///   <para>rdfs:label : acidity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Acidity">oum:Acidity</a>
    /// </summary>
    let Acidity = _prefixId.prefix "Acidity"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_ac</para>
    ///   <para>rdfs:label : acoustic firmnessrdfs:label : akoestische stevigheid</para>
    ///   <para>rdfs:comment : Stevigheid gemeten met AWETA (acoustic firmness value). AFS value.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AcousticFirmness">oum:AcousticFirmness</a>
    /// </summary>
    let AcousticFirmness = _prefixId.prefix "AcousticFirmness"
    /// <summary>
    ///   <para>rdfs:label : actionrdfs:label : actie</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Action">oum:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : action unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ActionUnit">oum:ActionUnit</a>
    /// </summary>
    let ActionUnit = _prefixId.prefix "ActionUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : activity (of a radionuclide)oum:alternativeLabel : activity of a radionuclide</para>
    ///   <para>oum:symbol : A^^xsd:string</para>
    ///   <para>rdfs:label : activityrdfs:label : activiteit</para>
    ///   <para>rdfs:comment : Activity is the decay rate of a radioactive substance. It is a derived quantity in the International System of Units. Activity is 1 divided by time.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Activity">oum:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : activity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ActivityUnit">oum:ActivityUnit</a>
    /// </summary>
    let ActivityUnit = _prefixId.prefix "ActivityUnit"
    /// <summary>
    ///   <para>oum:symbol : Y^^xsd:string</para>
    ///   <para>rdfs:label : admittance</para>
    ///   <para>rdfs:comment : Admittance is a measure of how easily a circuit or device will allow a current to flow. It is electric current divided by electric potential.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Admittance">oum:Admittance</a>
    /// </summary>
    let Admittance = _prefixId.prefix "Admittance"
    /// <summary>
    ///   <para>oum:symbol : α^^xsd:string</para>
    ///   <para>rdfs:label : albedordfs:label : albedo</para>
    ///   <para>rdfs:comment : Ratio between radiation falling onto an object and the radiation reflected or scattered back. Or the ratio between the illumination and observed brightness.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Albedo">oum:Albedo</a>
    /// </summary>
    let Albedo = _prefixId.prefix "Albedo"
    /// <summary>
    ///   <para>oum:symbol : Al^^xsd:string</para>
    ///   <para>rdfs:label : Alfvén number</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AlfvenNumber">oum:AlfvenNumber</a>
    /// </summary>
    let AlfvenNumber = _prefixId.prefix "AlfvenNumber"
    /// <summary>
    ///   <para>rdfs:label : Alfvén number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AlfvenNumberUnit">oum:AlfvenNumberUnit</a>
    /// </summary>
    let AlfvenNumberUnit = _prefixId.prefix "AlfvenNumberUnit"
    /// <summary>
    ///   <para>oum:symbol : h^^xsd:string</para>
    ///   <para>rdfs:label : altitude</para>
    ///   <para>rdfs:comment : The angular distance of a celestial body above or below the horizon, measured along the great circle passing through the body and the zenith.</para>
    ///   <para>oum:alternativeLabel : elevation</para>
    ///   <para>oum:alternativeSymbol : Alt^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Altitude">oum:Altitude</a>
    /// </summary>
    let Altitude = _prefixId.prefix "Altitude"
    /// <summary>
    ///   <para>rdfs:label : ambient dose equivalent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmbientDoseEquivalent">oum:AmbientDoseEquivalent</a>
    /// </summary>
    let AmbientDoseEquivalent = _prefixId.prefix "AmbientDoseEquivalent"
    /// <summary>
    ///   <para>rdfs:label : amount of money</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfMoney">oum:AmountOfMoney</a>
    /// </summary>
    let AmountOfMoney = _prefixId.prefix "AmountOfMoney"
    /// <summary>
    ///   <para>rdfs:label : amount of money unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfMoneyUnit">oum:AmountOfMoneyUnit</a>
    /// </summary>
    let AmountOfMoneyUnit = _prefixId.prefix "AmountOfMoneyUnit"
    /// <summary>
    ///   <para>rdfs:label : amount of substancerdfs:label : stofhoeveelheid</para>
    ///   <para>oum:symbol : n^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of substance is the number of elementary entities such as atoms, molecules, electrons, particles, etc. present in a phenomenon. It is a base quantity in the International System of Units.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstance">oum:AmountOfSubstance</a>
    /// </summary>
    let AmountOfSubstance = _prefixId.prefix "AmountOfSubstance"

    /// <summary>
    ///   <para>rdfs:label : amount of substance concentration</para>
    ///   <para>oum:symbol : C^^xsd:string</para>
    ///   <para>oum:alternativeLabel : molaire concentratieoum:alternativeLabel : molar concentration</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceConcentration">oum:AmountOfSubstanceConcentration</a>
    /// </summary>
    let AmountOfSubstanceConcentration = _prefixId.prefix "AmountOfSubstanceConcentration"

    /// <summary>
    ///   <para>rdfs:label : amount of substance concentration unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceConcentrationUnit">oum:AmountOfSubstanceConcentrationUnit</a>
    /// </summary>
    let AmountOfSubstanceConcentrationUnit = _prefixId.prefix "AmountOfSubstanceConcentrationUnit"

    /// <summary>
    ///   <para>oum:alternativeLabel : amount-of-substance flowoum:alternativeLabel : molar flow</para>
    ///   <para>rdfs:label : amount of substance flow</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceFlow">oum:AmountOfSubstanceFlow</a>
    /// </summary>
    let AmountOfSubstanceFlow = _prefixId.prefix "AmountOfSubstanceFlow"
    /// <summary>
    ///   <para>rdfs:label : amount of substance flow unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceFlowUnit">oum:AmountOfSubstanceFlowUnit</a>
    /// </summary>
    let AmountOfSubstanceFlowUnit = _prefixId.prefix "AmountOfSubstanceFlowUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : mole fractionoum:alternativeLabel : amount-of-substance fractionoum:alternativeLabel : molfractie</para>
    ///   <para>rdfs:label : amount of substance fraction</para>
    ///   <para>oum:symbol : x^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : y^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceFraction">oum:AmountOfSubstanceFraction</a>
    /// </summary>
    let AmountOfSubstanceFraction = _prefixId.prefix "AmountOfSubstanceFraction"
    /// <summary>
    ///   <para>oum:alternativeLabel : amount-of-substance fraction flowoum:alternativeLabel : mole fraction flow</para>
    ///   <para>rdfs:label : amount of substance fraction flow</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceFractionFlow">oum:AmountOfSubstanceFractionFlow</a>
    /// </summary>
    let AmountOfSubstanceFractionFlow = _prefixId.prefix "AmountOfSubstanceFractionFlow"
    /// <summary>
    ///   <para>rdfs:label : amount of substance fraction unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceFractionUnit">oum:AmountOfSubstanceFractionUnit</a>
    /// </summary>
    let AmountOfSubstanceFractionUnit = _prefixId.prefix "AmountOfSubstanceFractionUnit"
    /// <summary>
    ///   <para>rdfs:label : amount of substance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AmountOfSubstanceUnit">oum:AmountOfSubstanceUnit</a>
    /// </summary>
    let AmountOfSubstanceUnit = _prefixId.prefix "AmountOfSubstanceUnit"
    /// <summary>
    ///   <para>rdfs:label : amphiphilicityrdfs:label : amfifiliciteit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Amphiphilicity">oum:Amphiphilicity</a>
    /// </summary>
    let Amphiphilicity = _prefixId.prefix "Amphiphilicity"
    /// <summary>
    ///   <para>rdfs:label : amplitude</para>
    ///   <para>rdfs:comment : The difference between the maximum and minimum magnitudes of a variable star, i.e., the total range of its brightness.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Amplitude">oum:Amplitude</a>
    /// </summary>
    let Amplitude = _prefixId.prefix "Amplitude"
    /// <summary>
    ///   <para>oum:alternativeSymbol : θ^^xsd:stringoum:alternativeSymbol : γ^^xsd:stringoum:alternativeSymbol : φ^^xsd:stringoum:alternativeSymbol : β^^xsd:string</para>
    ///   <para>rdfs:label : anglerdfs:label : hoekrdfs:label : 角度</para>
    ///   <para>oum:symbol : α^^xsd:string</para>
    ///   <para>rdfs:comment : Angle is the ratio between an arc and its radius.</para>
    ///   <para>oum:alternativeLabel : plane angle</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Angle">oum:Angle</a>
    /// </summary>
    let Angle = _prefixId.prefix "Angle"
    /// <summary>
    ///   <para>rdfs:label : angle unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngleUnit">oum:AngleUnit</a>
    /// </summary>
    let AngleUnit = _prefixId.prefix "AngleUnit"
    /// <summary>
    ///   <para>oum:symbol : α^^xsd:string</para>
    ///   <para>rdfs:label : angular accelerationrdfs:label : hoekversnelling</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularAcceleration">oum:AngularAcceleration</a>
    /// </summary>
    let AngularAcceleration = _prefixId.prefix "AngularAcceleration"
    /// <summary>
    ///   <para>rdfs:label : angular acceleration unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularAccelerationUnit">oum:AngularAccelerationUnit</a>
    /// </summary>
    let AngularAccelerationUnit = _prefixId.prefix "AngularAccelerationUnit"
    /// <summary>
    ///   <para>rdfs:label : angular displacement</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularDisplacement">oum:AngularDisplacement</a>
    /// </summary>
    let AngularDisplacement = _prefixId.prefix "AngularDisplacement"
    /// <summary>
    ///   <para>oum:alternativeSymbol : J^^xsd:string</para>
    ///   <para>oum:alternativeLabel : draaimomentoum:alternativeLabel : draaiimpulsoum:alternativeLabel : hoekmoment</para>
    ///   <para>oum:symbol : L^^xsd:string</para>
    ///   <para>rdfs:label : impulsmomentrdfs:label : angular momentum</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularMomentum">oum:AngularMomentum</a>
    /// </summary>
    let AngularMomentum = _prefixId.prefix "AngularMomentum"
    /// <summary>
    ///   <para>rdfs:label : angular momentum unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularMomentumUnit">oum:AngularMomentumUnit</a>
    /// </summary>
    let AngularMomentumUnit = _prefixId.prefix "AngularMomentumUnit"
    /// <summary>
    ///   <para>rdfs:label : angular size</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularSize">oum:AngularSize</a>
    /// </summary>
    let AngularSize = _prefixId.prefix "AngularSize"
    /// <summary>
    ///   <para>oum:alternativeLabel : angular frequencyoum:alternativeLabel : hoekfrequentie</para>
    ///   <para>oum:alternativeSymbol : Ω^^xsd:string</para>
    ///   <para>oum:symbol : ω^^xsd:string</para>
    ///   <para>rdfs:label : angular speedrdfs:label : hoeksnelheid</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularSpeed">oum:AngularSpeed</a>
    /// </summary>
    let AngularSpeed = _prefixId.prefix "AngularSpeed"
    /// <summary>
    ///   <para>rdfs:label : angular speed unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularSpeedUnit">oum:AngularSpeedUnit</a>
    /// </summary>
    let AngularSpeedUnit = _prefixId.prefix "AngularSpeedUnit"
    /// <summary>
    ///   <para>oum:symbol : ω^^xsd:string</para>
    ///   <para>rdfs:label : angular velocity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AngularVelocity">oum:AngularVelocity</a>
    /// </summary>
    let AngularVelocity = _prefixId.prefix "AngularVelocity"
    /// <summary>
    ///   <para>rdfs:label : annual aberration</para>
    ///   <para>rdfs:comment : The component of the stellar abberation resulting from the motion of the Earth about the Sun. The abberation is the apparent angular displacement of the observed position of a celestial object from its geometric position, caused by the finite velocity of light in combination with the motions of the observer and of the observed object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AnnualAberration">oum:AnnualAberration</a>
    /// </summary>
    let AnnualAberration = _prefixId.prefix "AnnualAberration"
    /// <summary>
    ///   <para>rdfs:comment : The angle that the actual diameter of an object makes in the sky; also known as angular size. Most often small, so units are mostly arcminutes, arcseconds, or even milli- or microarcseconds.</para>
    ///   <para>rdfs:label : apparent diameter</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ApparentDiameter">oum:ApparentDiameter</a>
    /// </summary>
    let ApparentDiameter = _prefixId.prefix "ApparentDiameter"
    /// <summary>
    ///   <para>rdfs:label : apparent distance modulus</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ApparentDistanceModulus">oum:ApparentDistanceModulus</a>
    /// </summary>
    let ApparentDistanceModulus = _prefixId.prefix "ApparentDistanceModulus"
    /// <summary>
    ///   <para>oum:symbol : m^^xsd:string</para>
    ///   <para>rdfs:label : apparent magnituderdfs:label : schijnbare magnitude</para>
    ///   <para>rdfs:comment : Logarithmic measure of the apparent brightness of an object. Units usually not indicated(http://en.wikipedia.org/wiki/Magnitude_(astronomy).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ApparentMagnitude">oum:ApparentMagnitude</a>
    /// </summary>
    let ApparentMagnitude = _prefixId.prefix "ApparentMagnitude"
    /// <summary>
    ///   <para>rdfs:label : application area</para>
    ///   <para>rdfs:comment : An application area groups quantities and units of measure for application areas such as scientific disciplines (e.g., thermodynamics, mechanics).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ApplicationArea">oum:ApplicationArea</a>
    /// </summary>
    let ApplicationArea = _prefixId.prefix "ApplicationArea"
    /// <summary>
    ///   <para>oum:symbol : A^^xsd:string</para>
    ///   <para>rdfs:comment : Area expresses the two-dimensional size of a defined part of a surface, typically a region bounded by a closed curve. It is a derived quantity in the International System of Units. Area is length squared.</para>
    ///   <para>rdfs:label : oppervlakterdfs:label : areardfs:label : 面积</para>
    ///   <para>oum:alternativeLabel : oppervlak</para>
    ///   <para>oum:alternativeSymbol : S^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Area">oum:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : area densityrdfs:label : oppervlaktedichtheid</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaDensity">oum:AreaDensity</a>
    /// </summary>
    let AreaDensity = _prefixId.prefix "AreaDensity"
    /// <summary>
    ///   <para>rdfs:label : area density rate</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaDensityRate">oum:AreaDensityRate</a>
    /// </summary>
    let AreaDensityRate = _prefixId.prefix "AreaDensityRate"
    /// <summary>
    ///   <para>rdfs:label : area density rate unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaDensityRateUnit">oum:AreaDensityRateUnit</a>
    /// </summary>
    let AreaDensityRateUnit = _prefixId.prefix "AreaDensityRateUnit"
    /// <summary>
    ///   <para>rdfs:label : area density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaDensityUnit">oum:AreaDensityUnit</a>
    /// </summary>
    let AreaDensityUnit = _prefixId.prefix "AreaDensityUnit"
    /// <summary>
    ///   <para>rdfs:label : oppervlaktefractierdfs:label : area fraction</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaFraction">oum:AreaFraction</a>
    /// </summary>
    let AreaFraction = _prefixId.prefix "AreaFraction"
    /// <summary>
    ///   <para>rdfs:label : area fraction unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaFractionUnit">oum:AreaFractionUnit</a>
    /// </summary>
    let AreaFractionUnit = _prefixId.prefix "AreaFractionUnit"
    /// <summary>
    ///   <para>rdfs:label : area unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AreaUnit">oum:AreaUnit</a>
    /// </summary>
    let AreaUnit = _prefixId.prefix "AreaUnit"
    /// <summary>
    ///   <para>oum:symbol : m_a^^xsd:string</para>
    ///   <para>rdfs:label : atomic mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AtomicMass">oum:AtomicMass</a>
    /// </summary>
    let AtomicMass = _prefixId.prefix "AtomicMass"
    let AustralianDollar = _prefixId.prefix "AustralianDollar"
    /// <summary>
    ///   <para>rdfs:label : average speed</para>
    ///   <para>oum:symbol : u^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/AverageSpeed">oum:AverageSpeed</a>
    /// </summary>
    let AverageSpeed = _prefixId.prefix "AverageSpeed"
    /// <summary>
    ///   <para>oum:symbol : A^^xsd:string</para>
    ///   <para>rdfs:label : azimutrdfs:label : azimuth</para>
    ///   <para>rdfs:comment : The angular distance measured clockwise along the horizon from a specified reference point (usually north) to the intersection with the great circle drawn from the zenith through a body on the celestial sphere.</para>
    ///   <para>oum:alternativeSymbol : Az^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Azimuth">oum:Azimuth</a>
    /// </summary>
    let Azimuth = _prefixId.prefix "Azimuth"
    /// <summary>
    ///   <para>oum:alternativeSymbol : m_B^^xsd:string</para>
    ///   <para>rdfs:comment : Johnson B magnitude. The Johnson B band is a standard filter in the blue area. The central wavelength is 440nm and the bandwidth is 100nm.  The filter to be used is the Corning 5030 filter plus the Schott GG13 filter.</para>
    ///   <para>oum:symbol : B^^xsd:string</para>
    ///   <para>rdfs:label : B magnitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BMagnitude">oum:BMagnitude</a>
    /// </summary>
    let BMagnitude = _prefixId.prefix "BMagnitude"
    /// <summary>
    ///   <para>oum:symbol : B_max^^xsd:string</para>
    ///   <para>rdfs:label : B magnitude at maximum brightness</para>
    ///   <para>rdfs:comment : Johnson B magnitude at maximum brightness (i.e. for a variable star). The Johnson B band is a standard filter in the blue area. The central wavelength is 440nm and the bandwidth is 100nm.  The filter to be used is the Corning 5030 filter plus the Schott GG13 filter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BMagnitudeAtMaximumBrightness">oum:BMagnitudeAtMaximumBrightness</a>
    /// </summary>
    let BMagnitudeAtMaximumBrightness = _prefixId.prefix "BMagnitudeAtMaximumBrightness"
    /// <summary>
    ///   <para>oum:symbol : B_min^^xsd:string</para>
    ///   <para>rdfs:label : B magnitude at minimum brightness</para>
    ///   <para>rdfs:comment : Johnson B magnitude at minimum brightness (i.e. for a variable star). The Johnson B band is a standard filter in the blue area. The central wavelength is 440nm and the bandwidth is 100nm.  The filter to be used is the Corning 5030 filter plus the Schott GG13 filter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BMagnitudeAtMinimumBrightness">oum:BMagnitudeAtMinimumBrightness</a>
    /// </summary>
    let BMagnitudeAtMinimumBrightness = _prefixId.prefix "BMagnitudeAtMinimumBrightness"
    /// <summary>
    ///   <para>oum:symbol : β_n^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : β_narrow^^xsd:string</para>
    ///   <para>rdfs:label : β_narrow magnitude</para>
    ///   <para>rdfs:comment : β_narrow  Magnitude in the Strömgren-Crawford photometric system with a peak wavelength at 485.8 nm and a peak-half-width of 2.9 nm.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BetaNarrowMagnitude">oum:BetaNarrowMagnitude</a>
    /// </summary>
    let BetaNarrowMagnitude = _prefixId.prefix "BetaNarrowMagnitude"
    /// <summary>
    ///   <para>oum:symbol : β_w^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : β_wide^^xsd:string</para>
    ///   <para>rdfs:label : β_wide magnitude</para>
    ///   <para>rdfs:comment : β_wide  Magnitude in the Strömgren-Crawford photometric system with a peak wavelength at 485 nm and a peak-half-width of 12.9 nm.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BetaWideMagnitude">oum:BetaWideMagnitude</a>
    /// </summary>
    let BetaWideMagnitude = _prefixId.prefix "BetaWideMagnitude"
    /// <summary>
    ///   <para>rdfs:label : binary prefix</para>
    ///   <para>rdfs:comment : IEC prefix</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BinaryPrefix">oum:BinaryPrefix</a>
    /// </summary>
    let BinaryPrefix = _prefixId.prefix "BinaryPrefix"
    /// <summary>
    ///   <para>oum:unofficialLabel : body label weight^^xsd:string</para>
    ///   <para>rdfs:label : body label mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BodyLabelMass">oum:BodyLabelMass</a>
    /// </summary>
    let BodyLabelMass = _prefixId.prefix "BodyLabelMass"
    /// <summary>
    ///   <para>oum:unofficialLabel : body weight^^xsd:string</para>
    ///   <para>rdfs:label : body mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BodyMass">oum:BodyMass</a>
    /// </summary>
    let BodyMass = _prefixId.prefix "BodyMass"
    /// <summary>
    ///   <para>oum:symbol : BC^^xsd:string</para>
    ///   <para>rdfs:label : bolometric correction</para>
    ///   <para>rdfs:comment : The visual magnitude of an object minus its bolometric magnitude.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BolometricCorrection">oum:BolometricCorrection</a>
    /// </summary>
    let BolometricCorrection = _prefixId.prefix "BolometricCorrection"
    /// <summary>
    ///   <para>oum:symbol : m_bol^^xsd:string</para>
    ///   <para>rdfs:label : bolometric magnitude</para>
    ///   <para>rdfs:comment : The magnitude of a star measured across all wavelengths, so that it takes into account the total amount of energy radiated. If a star is a strong infrared or ultraviolet emitter, its bolometric magnitude  will differ greatly from its visual magnitude.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BolometricMagnitude">oum:BolometricMagnitude</a>
    /// </summary>
    let BolometricMagnitude = _prefixId.prefix "BolometricMagnitude"
    /// <summary>
    ///   <para>oum:alternativeLabel : spherical albedo</para>
    ///   <para>rdfs:label : bond albedo</para>
    ///   <para>rdfs:comment : Is the fraction of the total incident solar radiation - the radiation at all wavelengths - that is reflected or scattered by an object in all directions.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BondAlbedo">oum:BondAlbedo</a>
    /// </summary>
    let BondAlbedo = _prefixId.prefix "BondAlbedo"
    let BrazilianReal = _prefixId.prefix "BrazilianReal"
    /// <summary>
    ///   <para>rdfs:label : breadthrdfs:label : breedte</para>
    ///   <para>oum:symbol : b^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Breadth">oum:Breadth</a>
    /// </summary>
    let Breadth = _prefixId.prefix "Breadth"
    /// <summary>
    ///   <para>rdfs:label : brightness temperature</para>
    ///   <para>rdfs:comment : The temperature that a blackbody would need to have in order to emit radiation of the observed intensity at a given wavelength (mostly used in radio astronomy).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BrightnessTemperature">oum:BrightnessTemperature</a>
    /// </summary>
    let BrightnessTemperature = _prefixId.prefix "BrightnessTemperature"
    let BritishThermalUnit_39F = _prefixId.prefix "BritishThermalUnit-39F"
    let BritishThermalUnit_59F = _prefixId.prefix "BritishThermalUnit-59F"
    let BritishThermalUnit_60F = _prefixId.prefix "BritishThermalUnit-60F"

    let BritishThermalUnit_InternationalTable = _prefixId.prefix "BritishThermalUnit-InternationalTable"

    let BritishThermalUnit_Mean = _prefixId.prefix "BritishThermalUnit-Mean"

    let BritishThermalUnit_Thermochemical = _prefixId.prefix "BritishThermalUnit-Thermochemical"

    /// <summary>
    ///   <para>rdfs:label : bud stadiumrdfs:label : knopstadium</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BudStadium">oum:BudStadium</a>
    /// </summary>
    let BudStadium = _prefixId.prefix "BudStadium"
    /// <summary>
    ///   <para>oum:alternativeLabel : sday0</para>
    ///   <para>rdfs:label : bud stadium day 0rdfs:label : knopstadium dag 0</para>
    ///   <para>rdfs:comment : Knopstadium vaasdag 0 (start vaasleven) (code).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BudStadiumDay0">oum:BudStadiumDay0</a>
    /// </summary>
    let BudStadiumDay0 = _prefixId.prefix "BudStadiumDay0"
    /// <summary>
    ///   <para>oum:alternativeLabel : sday4</para>
    ///   <para>rdfs:label : bud stadium day 4rdfs:label : knopstadium dag 4</para>
    ///   <para>rdfs:comment : Knopstadium vaasdag 4 (code).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BudStadiumDay4">oum:BudStadiumDay4</a>
    /// </summary>
    let BudStadiumDay4 = _prefixId.prefix "BudStadiumDay4"
    /// <summary>
    ///   <para>oum:alternativeLabel : sday7</para>
    ///   <para>rdfs:label : bud stadium day 7rdfs:label : knopstadium dag 7</para>
    ///   <para>rdfs:comment : Knopstadium vaasdag 7 (code).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BudStadiumDay7">oum:BudStadiumDay7</a>
    /// </summary>
    let BudStadiumDay7 = _prefixId.prefix "BudStadiumDay7"
    /// <summary>
    ///   <para>rdfs:label : compressiemodulusrdfs:label : bulk modulus</para>
    ///   <para>oum:symbol : K^^xsd:string</para>
    ///   <para>rdfs:comment : Bulk modulus is a substance's resistance to uniform compression.</para>
    ///   <para>oum:alternativeSymbol : κ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/BulkModulus">oum:BulkModulus</a>
    /// </summary>
    let BulkModulus = _prefixId.prefix "BulkModulus"
    let CanadianDollar = _prefixId.prefix "CanadianDollar"
    /// <summary>
    ///   <para>oum:unofficialLabel : cap weight^^xsd:string</para>
    ///   <para>rdfs:label : cap mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CapMass">oum:CapMass</a>
    /// </summary>
    let CapMass = _prefixId.prefix "CapMass"
    /// <summary>
    ///   <para>oum:alternativeLabel : electrische capaciteitoum:alternativeLabel : electric capacitance</para>
    ///   <para>rdfs:comment : Capacitance is the ability to hold electrical charge. It is a derived quantity in the International System of Units. Capacitance is electric charge divided by electric potential.</para>
    ///   <para>rdfs:label : capaciteitrdfs:label : capacitance</para>
    ///   <para>oum:symbol : C^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Capacitance">oum:Capacitance</a>
    /// </summary>
    let Capacitance = _prefixId.prefix "Capacitance"
    /// <summary>
    ///   <para>rdfs:label : capacitance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CapacitanceUnit">oum:CapacitanceUnit</a>
    /// </summary>
    let CapacitanceUnit = _prefixId.prefix "CapacitanceUnit"
    /// <summary>
    ///   <para>oum:unofficialLabel : carton weight^^xsd:string</para>
    ///   <para>rdfs:label : carton mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CartonMass">oum:CartonMass</a>
    /// </summary>
    let CartonMass = _prefixId.prefix "CartonMass"
    /// <summary>
    ///   <para>rdfs:label : catalytic activity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CatalyticActivity">oum:CatalyticActivity</a>
    /// </summary>
    let CatalyticActivity = _prefixId.prefix "CatalyticActivity"

    /// <summary>
    ///   <para>oum:alternativeLabel : catalytic concentration</para>
    ///   <para>rdfs:label : catalytic activity concentration</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CatalyticActivityConcentration">oum:CatalyticActivityConcentration</a>
    /// </summary>
    let CatalyticActivityConcentration = _prefixId.prefix "CatalyticActivityConcentration"

    /// <summary>
    ///   <para>rdfs:label : catalytic activity concentration unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CatalyticActivityConcentrationUnit">oum:CatalyticActivityConcentrationUnit</a>
    /// </summary>
    let CatalyticActivityConcentrationUnit = _prefixId.prefix "CatalyticActivityConcentrationUnit"

    /// <summary>
    ///   <para>rdfs:label : catalytic activity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CatalyticActivityUnit">oum:CatalyticActivityUnit</a>
    /// </summary>
    let CatalyticActivityUnit = _prefixId.prefix "CatalyticActivityUnit"

    /// <summary>
    ///   <para>oum:alternativeLabel : abscised buds</para>
    ///   <para>rdfs:label : cause end of vase life abscised budsrdfs:label : oorzaak einde vaasleven knopval</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven knopval (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeAbscisedBuds">oum:CauseEndOfVaseLifeAbscisedBuds</a>
    /// </summary>
    let CauseEndOfVaseLifeAbscisedBuds = _prefixId.prefix "CauseEndOfVaseLifeAbscisedBuds"

    /// <summary>
    ///   <para>oum:alternativeLabel : abscised flowers</para>
    ///   <para>rdfs:label : cause end of vase life abscised flowersrdfs:label : oorzaak einde vaasleven bloemval</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bloemval (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeAbscisedFlowers">oum:CauseEndOfVaseLifeAbscisedFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeAbscisedFlowers = _prefixId.prefix "CauseEndOfVaseLifeAbscisedFlowers"

    /// <summary>
    ///   <para>oum:alternativeLabel : abscised leaves</para>
    ///   <para>rdfs:label : cause end of vase life abscised leavesrdfs:label : oorzaak einde vaasleven bladval</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bladval (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeAbscisedLeaves">oum:CauseEndOfVaseLifeAbscisedLeaves</a>
    /// </summary>
    let CauseEndOfVaseLifeAbscisedLeaves = _prefixId.prefix "CauseEndOfVaseLifeAbscisedLeaves"

    /// <summary>
    ///   <para>oum:alternativeLabel : blue flowers</para>
    ///   <para>rdfs:label : cause end of vase life blue flowersrdfs:label : oorzaak einde vaasleven blauwe bloemen</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven blauwe bloemen (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeBlueFlowers">oum:CauseEndOfVaseLifeBlueFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeBlueFlowers = _prefixId.prefix "CauseEndOfVaseLifeBlueFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : bot</para>
    ///   <para>rdfs:label : cause end of vase life Botrytisrdfs:label : oorzaak einde vaasleven Botrytis</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven Botrytis (b3 of b4) (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeBotrytis">oum:CauseEndOfVaseLifeBotrytis</a>
    /// </summary>
    let CauseEndOfVaseLifeBotrytis = _prefixId.prefix "CauseEndOfVaseLifeBotrytis"
    /// <summary>
    ///   <para>oum:alternativeLabel : dry buds</para>
    ///   <para>rdfs:label : cause end of vase life dry budsrdfs:label : oorzaak einde vaasleven knopverdroging</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven knopverdroging (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeDryBuds">oum:CauseEndOfVaseLifeDryBuds</a>
    /// </summary>
    let CauseEndOfVaseLifeDryBuds = _prefixId.prefix "CauseEndOfVaseLifeDryBuds"
    /// <summary>
    ///   <para>oum:alternativeLabel : dry flowers</para>
    ///   <para>rdfs:label : cause end of vase life dry flowersrdfs:label : oorzaak einde vaasleven bloemverdroging</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bloemverdroging (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeDryFlowers">oum:CauseEndOfVaseLifeDryFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeDryFlowers = _prefixId.prefix "CauseEndOfVaseLifeDryFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : dry leaves</para>
    ///   <para>rdfs:label : cause end of vase life dry leavesrdfs:label : oorzaak einde vaasleven bladverdroging</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bladverdroging (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeDryLeaves">oum:CauseEndOfVaseLifeDryLeaves</a>
    /// </summary>
    let CauseEndOfVaseLifeDryLeaves = _prefixId.prefix "CauseEndOfVaseLifeDryLeaves"

    /// <summary>
    ///   <para>oum:alternativeLabel : malformed buds</para>
    ///   <para>rdfs:label : cause end of vase life malformed budsrdfs:label : oorzaak einde vaasleven misvormde knoppen</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven misvormde knoppen (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeMalformedBuds">oum:CauseEndOfVaseLifeMalformedBuds</a>
    /// </summary>
    let CauseEndOfVaseLifeMalformedBuds = _prefixId.prefix "CauseEndOfVaseLifeMalformedBuds"

    /// <summary>
    ///   <para>oum:alternativeLabel : malformed flowers</para>
    ///   <para>rdfs:label : cause end of vase life malformed flowersrdfs:label : oorzaak einde vaasleven misvormde bloemen</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven misvormde bloemen (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeMalformedFlowers">oum:CauseEndOfVaseLifeMalformedFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeMalformedFlowers = _prefixId.prefix "CauseEndOfVaseLifeMalformedFlowers"

    /// <summary>
    ///   <para>oum:alternativeLabel : nonturgid flowers</para>
    ///   <para>rdfs:label : cause end of vase life nonturgid flowersrdfs:label : oorzaak einde vaasleven slappe bloemen</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven slappe bloemen (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeNonturgidFlowers">oum:CauseEndOfVaseLifeNonturgidFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeNonturgidFlowers = _prefixId.prefix "CauseEndOfVaseLifeNonturgidFlowers"

    /// <summary>
    ///   <para>oum:alternativeLabel : nonturgid leaves</para>
    ///   <para>rdfs:label : cause end of vase life nonturgid leavesrdfs:label : oorzaak einde vaasleven slappe bladeren</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven slappe bladeren (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeNonturgidLeaves">oum:CauseEndOfVaseLifeNonturgidLeaves</a>
    /// </summary>
    let CauseEndOfVaseLifeNonturgidLeaves = _prefixId.prefix "CauseEndOfVaseLifeNonturgidLeaves"

    /// <summary>
    ///   <para>oum:alternativeLabel : rotten flowers</para>
    ///   <para>rdfs:label : cause end of vase life rotten flowersrdfs:label : oorzaak einde vaasleven bloemrot</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bloemrot (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeRottenFlowers">oum:CauseEndOfVaseLifeRottenFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeRottenFlowers = _prefixId.prefix "CauseEndOfVaseLifeRottenFlowers"

    /// <summary>
    ///   <para>oum:alternativeLabel : rotten leaves</para>
    ///   <para>rdfs:label : cause end of vase life rotten leavesrdfs:label : oorzaak einde vaasleven rotte bladeren</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven rotte bladeren (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeRottenLeaves">oum:CauseEndOfVaseLifeRottenLeaves</a>
    /// </summary>
    let CauseEndOfVaseLifeRottenLeaves = _prefixId.prefix "CauseEndOfVaseLifeRottenLeaves"

    /// <summary>
    ///   <para>oum:alternativeLabel : wilted flowers</para>
    ///   <para>rdfs:label : cause end of vase life wilted flowersrdfs:label : oorzaak einde vaasleven bloemverwelking</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bloemverwelking (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeWiltedFlowers">oum:CauseEndOfVaseLifeWiltedFlowers</a>
    /// </summary>
    let CauseEndOfVaseLifeWiltedFlowers = _prefixId.prefix "CauseEndOfVaseLifeWiltedFlowers"

    /// <summary>
    ///   <para>oum:alternativeLabel : wilted leaves</para>
    ///   <para>rdfs:label : cause end of vase life wilted leavesrdfs:label : oorzaak einde vaasleven bladverwelking</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bladverwelking (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeWiltedLeaves">oum:CauseEndOfVaseLifeWiltedLeaves</a>
    /// </summary>
    let CauseEndOfVaseLifeWiltedLeaves = _prefixId.prefix "CauseEndOfVaseLifeWiltedLeaves"

    /// <summary>
    ///   <para>oum:alternativeLabel : yellow leaves</para>
    ///   <para>rdfs:label : cause end of vase life yellow leavesrdfs:label : oorzaak einde vaasleven bladvergeling</para>
    ///   <para>rdfs:comment : Oorzaak einde vaasleven bladvergeling (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CauseEndOfVaseLifeYellowLeaves">oum:CauseEndOfVaseLifeYellowLeaves</a>
    /// </summary>
    let CauseEndOfVaseLifeYellowLeaves = _prefixId.prefix "CauseEndOfVaseLifeYellowLeaves"

    let CelsiusScale = _prefixId.prefix "CelsiusScale"
    /// <summary>
    ///   <para>rdfs:label : Celsius temperaturerdfs:label : Celsiustemperatuur</para>
    ///   <para>oum:symbol : t^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : θ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CelsiusTemperature">oum:CelsiusTemperature</a>
    /// </summary>
    let CelsiusTemperature = _prefixId.prefix "CelsiusTemperature"
    /// <summary>
    ///   <para>rdfs:label : Celsius temperature scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CelsiusTemperatureScale">oum:CelsiusTemperatureScale</a>
    /// </summary>
    let CelsiusTemperatureScale = _prefixId.prefix "CelsiusTemperatureScale"
    /// <summary>
    ///   <para>rdfs:label : Celsius temperature unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CelsiusTemperatureUnit">oum:CelsiusTemperatureUnit</a>
    /// </summary>
    let CelsiusTemperatureUnit = _prefixId.prefix "CelsiusTemperatureUnit"
    let ChineseYuan = _prefixId.prefix "ChineseYuan"
    /// <summary>
    ///   <para>rdfs:label : circumferencerdfs:label : omtrekrdfs:label : 圆周</para>
    ///   <para>oum:symbol : C^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Circumference">oum:Circumference</a>
    /// </summary>
    let Circumference = _prefixId.prefix "Circumference"
    /// <summary>
    ///   <para>oum:symbol : r_c^^xsd:string</para>
    ///   <para>rdfs:label : co-rotation radius</para>
    ///   <para>rdfs:comment : The radius (distance from the galaxy's centre) at which the stars move at the same speed as the spiral pattern or bar in a galaxy.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Co-RotationRadius">oum:Co-RotationRadius</a>
    /// </summary>
    let Co_RotationRadius = _prefixId.prefix "Co-RotationRadius"
    /// <summary>
    ///   <para>rdfs:label : cold gas mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of a galaxy that is in the form of cold gas ~10s K.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ColdGasMassFraction">oum:ColdGasMassFraction</a>
    /// </summary>
    let ColdGasMassFraction = _prefixId.prefix "ColdGasMassFraction"
    /// <summary>
    ///   <para>oum:symbol : ν_coll^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : ν_c^^xsd:string</para>
    ///   <para>rdfs:label : collision frequency</para>
    ///   <para>rdfs:comment : Collision frequency is the average number of collisions between reacting molecules per unit time.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CollisionFrequency">oum:CollisionFrequency</a>
    /// </summary>
    let CollisionFrequency = _prefixId.prefix "CollisionFrequency"
    /// <summary>
    ///   <para>oum:alternativeLabel : color%</para>
    ///   <para>rdfs:label : color area fractionrdfs:label : kleuroppervlaktefractie</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: percentage oppervlak donker.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ColorAreaFraction">oum:ColorAreaFraction</a>
    /// </summary>
    let ColorAreaFraction = _prefixId.prefix "ColorAreaFraction"
    /// <summary>
    ///   <para>rdfs:label : colour indexrdfs:label : kleurindex</para>
    ///   <para>rdfs:comment : The difference between the apparent magnitude of a star at two different wavelengths (always the shorter-wavelength magnitude minus the longer-wavelength magnitude) to give a quantification of the star's colour. The magnitude of an object at different wavelengths are measured by using different filters before the detector. Often the Johnson system with UBV passbands are used. Other passbands may also be used (for instance g-r).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ColourIndex">oum:ColourIndex</a>
    /// </summary>
    let ColourIndex = _prefixId.prefix "ColourIndex"
    /// <summary>
    ///   <para>rdfs:label : colour temperature</para>
    ///   <para>rdfs:comment : The temperature of a blackbody that has the same colour index as a given star.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ColourTemperature">oum:ColourTemperature</a>
    /// </summary>
    let ColourTemperature = _prefixId.prefix "ColourTemperature"
    /// <summary>
    ///   <para>oum:unofficialLabel : number density^^xsd:stringoum:unofficialLabel : density^^xsd:string</para>
    ///   <para>rdfs:label : column number density</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ColumnNumberDensity">oum:ColumnNumberDensity</a>
    /// </summary>
    let ColumnNumberDensity = _prefixId.prefix "ColumnNumberDensity"
    /// <summary>
    ///   <para>rdfs:label : column number density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ColumnNumberDensityUnit">oum:ColumnNumberDensityUnit</a>
    /// </summary>
    let ColumnNumberDensityUnit = _prefixId.prefix "ColumnNumberDensityUnit"
    /// <summary>
    ///   <para>rdfs:label : compound unitrdfs:label : 複合単位</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CompoundUnit">oum:CompoundUnit</a>
    /// </summary>
    let CompoundUnit = _prefixId.prefix "CompoundUnit"
    /// <summary>
    ///   <para>rdfs:comment : Compressive stress is a stress that, when applied, acts towards the center of a material.</para>
    ///   <para>rdfs:label : compressive stress</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CompressiveStress">oum:CompressiveStress</a>
    /// </summary>
    let CompressiveStress = _prefixId.prefix "CompressiveStress"
    /// <summary>
    ///   <para>rdfs:label : contact angle</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ContactAngle">oum:ContactAngle</a>
    /// </summary>
    let ContactAngle = _prefixId.prefix "ContactAngle"
    /// <summary>
    ///   <para>oum:symbol : Λ^^xsd:string</para>
    ///   <para>rdfs:label : cosmological constantrdfs:label : kosmologische constante</para>
    ///   <para>rdfs:comment : The cosmological constant.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CosmologicalConstant">oum:CosmologicalConstant</a>
    /// </summary>
    let CosmologicalConstant = _prefixId.prefix "CosmologicalConstant"
    /// <summary>
    ///   <para>rdfs:label : cost</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Cost">oum:Cost</a>
    /// </summary>
    let Cost = _prefixId.prefix "Cost"
    /// <summary>
    ///   <para>rdfs:label : Cousins magnitude</para>
    ///   <para>rdfs:comment : A magnitude measured in one of Cousins standard passbands (using a standard filter, i.e. I or R).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CousinsMagnitude">oum:CousinsMagnitude</a>
    /// </summary>
    let CousinsMagnitude = _prefixId.prefix "CousinsMagnitude"
    /// <summary>
    ///   <para>rdfs:label : coverage</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Coverage">oum:Coverage</a>
    /// </summary>
    let Coverage = _prefixId.prefix "Coverage"
    /// <summary>
    ///   <para>oum:symbol : Co^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : Co2^^xsd:string</para>
    ///   <para>oum:alternativeLabel : second Cowling number</para>
    ///   <para>rdfs:label : Cowling number</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CowlingNumber">oum:CowlingNumber</a>
    /// </summary>
    let CowlingNumber = _prefixId.prefix "CowlingNumber"
    /// <summary>
    ///   <para>rdfs:label : Cowling number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CowlingNumberUnit">oum:CowlingNumberUnit</a>
    /// </summary>
    let CowlingNumberUnit = _prefixId.prefix "CowlingNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : kritieke dichtheidrdfs:label : critical density</para>
    ///   <para>rdfs:comment : The density needed for a closed universe.</para>
    ///   <para>oum:symbol : ρ_c^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CriticalDensity">oum:CriticalDensity</a>
    /// </summary>
    let CriticalDensity = _prefixId.prefix "CriticalDensity"
    /// <summary>
    ///   <para>rdfs:label : cubic prefixed metre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CubicPrefixedMetre">oum:CubicPrefixedMetre</a>
    /// </summary>
    let CubicPrefixedMetre = _prefixId.prefix "CubicPrefixedMetre"
    /// <summary>
    ///   <para>oum:symbol : J^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : j^^xsd:string</para>
    ///   <para>rdfs:label : current density</para>
    ///   <para>rdfs:comment : Current density is the density of flow of a conserved charge. It is a derived quantity in the International System of Units. Current density is electric current divided by area.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CurrentDensity">oum:CurrentDensity</a>
    /// </summary>
    let CurrentDensity = _prefixId.prefix "CurrentDensity"
    /// <summary>
    ///   <para>rdfs:label : current density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CurrentDensityUnit">oum:CurrentDensityUnit</a>
    /// </summary>
    let CurrentDensityUnit = _prefixId.prefix "CurrentDensityUnit"
    /// <summary>
    ///   <para>oum:symbol : k^^xsd:string</para>
    ///   <para>rdfs:label : curvature constant</para>
    ///   <para>rdfs:comment : The curvature constant k=-1, 0, or 1.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CurvatureConstant">oum:CurvatureConstant</a>
    /// </summary>
    let CurvatureConstant = _prefixId.prefix "CurvatureConstant"
    /// <summary>
    ///   <para>rdfs:label : curvature constant unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/CurvatureConstantUnit">oum:CurvatureConstantUnit</a>
    /// </summary>
    let CurvatureConstantUnit = _prefixId.prefix "CurvatureConstantUnit"
    /// <summary>
    ///   <para>rdfs:label : cut-off wavelength</para>
    ///   <para>oum:symbol : λ_c^^xsd:string</para>
    ///   <para>rdfs:comment : Either: wavelengths at which the detectivity (D) falls to 0, or the wavelengths at which the detectivity falls to 1% of the peak value, or the wavelengths at which the normalised detectivity (D*) has fallen to half its peak value.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Cut-OffWavelength">oum:Cut-OffWavelength</a>
    /// </summary>
    let Cut_OffWavelength = _prefixId.prefix "Cut-OffWavelength"
    /// <summary>
    ///   <para>rdfs:label : dark noise</para>
    ///   <para>rdfs:comment : Output from a detector when unilluminated - usually as RMS voltage or current (Kitchin, Astrophysical Techniques, IoP, Table 1.1.2).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DarkNoise">oum:DarkNoise</a>
    /// </summary>
    let DarkNoise = _prefixId.prefix "DarkNoise"
    /// <summary>
    ///   <para>rdfs:label : datumrdfs:label : date</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Date">oum:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>oum:symbol : q^^xsd:string</para>
    ///   <para>rdfs:label : deceleration parameter</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DecelerationParameter">oum:DecelerationParameter</a>
    /// </summary>
    let DecelerationParameter = _prefixId.prefix "DecelerationParameter"
    /// <summary>
    ///   <para>rdfs:label : deceleration parameter unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DecelerationParameterUnit">oum:DecelerationParameterUnit</a>
    /// </summary>
    let DecelerationParameterUnit = _prefixId.prefix "DecelerationParameterUnit"
    /// <summary>
    ///   <para>oum:symbol : δ^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : dec^^xsd:string</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere north or south of the celestial equator. It is measured along the hour circle passing through the celestial object. Declination is usually given in combination with right ascension or hour angle.</para>
    ///   <para>rdfs:label : declinatierdfs:label : declination</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Declination">oum:Declination</a>
    /// </summary>
    let Declination = _prefixId.prefix "Declination"
    /// <summary>
    ///   <para>oum:alternativeLabel : concentration (w/v)oum:alternativeLabel : soortelijke massaoum:alternativeLabel : mass density</para>
    ///   <para>rdfs:label : densityrdfs:label : 密度rdfs:label : dichtheid</para>
    ///   <para>rdfs:comment : Density is the concentration of matter. It is a derived quantity in the International System of Units. Density is mass divided by volume.</para>
    ///   <para>oum:symbol : ρ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Density">oum:Density</a>
    /// </summary>
    let Density = _prefixId.prefix "Density"
    /// <summary>
    ///   <para>oum:symbol : Ω^^xsd:string</para>
    ///   <para>rdfs:label : density parameter</para>
    ///   <para>rdfs:comment : Ratio of the average density and the critical density.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityParameter">oum:DensityParameter</a>
    /// </summary>
    let DensityParameter = _prefixId.prefix "DensityParameter"

    /// <summary>
    ///   <para>oum:symbol : Ω_B^^xsd:string</para>
    ///   <para>rdfs:label : density parameter for baryonic matter</para>
    ///   <para>rdfs:comment : The density parameter for baryonic (oridnary) matter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityParameterForBaryonicMatter">oum:DensityParameterForBaryonicMatter</a>
    /// </summary>
    let DensityParameterForBaryonicMatter = _prefixId.prefix "DensityParameterForBaryonicMatter"

    /// <summary>
    ///   <para>oum:symbol : Ω_M^^xsd:string</para>
    ///   <para>rdfs:label : density parameter for matter</para>
    ///   <para>rdfs:comment : The density parameter for matter (either baryonic or dark).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityParameterForMatter">oum:DensityParameterForMatter</a>
    /// </summary>
    let DensityParameterForMatter = _prefixId.prefix "DensityParameterForMatter"
    /// <summary>
    ///   <para>oum:symbol : Ω_R^^xsd:string</para>
    ///   <para>rdfs:label : density parameter for radiation</para>
    ///   <para>rdfs:comment : The density parameter for radiation.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityParameterForRadiation">oum:DensityParameterForRadiation</a>
    /// </summary>
    let DensityParameterForRadiation = _prefixId.prefix "DensityParameterForRadiation"
    /// <summary>
    ///   <para>oum:symbol : Ω_Λ^^xsd:string</para>
    ///   <para>rdfs:label : density parameter for vacuum</para>
    ///   <para>rdfs:comment : The density parameter for vacuum.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityParameterForVacuum">oum:DensityParameterForVacuum</a>
    /// </summary>
    let DensityParameterForVacuum = _prefixId.prefix "DensityParameterForVacuum"
    /// <summary>
    ///   <para>rdfs:label : density parameter unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityParameterUnit">oum:DensityParameterUnit</a>
    /// </summary>
    let DensityParameterUnit = _prefixId.prefix "DensityParameterUnit"
    /// <summary>
    ///   <para>rdfs:label : density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DensityUnit">oum:DensityUnit</a>
    /// </summary>
    let DensityUnit = _prefixId.prefix "DensityUnit"
    /// <summary>
    ///   <para>rdfs:label : depthrdfs:label : diepte</para>
    ///   <para>oum:symbol : d^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Depth">oum:Depth</a>
    /// </summary>
    let Depth = _prefixId.prefix "Depth"
    /// <summary>
    ///   <para>oum:symbol : DQE^^xsd:string</para>
    ///   <para>rdfs:label : detective quantum efficiency</para>
    ///   <para>rdfs:comment : Square of ratio between the output signal noise ratio and the input signal noise ratio.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DetectiveQuantumEfficiency">oum:DetectiveQuantumEfficiency</a>
    /// </summary>
    let DetectiveQuantumEfficiency = _prefixId.prefix "DetectiveQuantumEfficiency"
    /// <summary>
    ///   <para>oum:symbol : D^^xsd:string</para>
    ///   <para>rdfs:label : detectivity</para>
    ///   <para>rdfs:comment : Reciprocal of Noise equivalent power. The signal-to-noise ratio for incident radiation of unit intensity.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Detectivity">oum:Detectivity</a>
    /// </summary>
    let Detectivity = _prefixId.prefix "Detectivity"
    /// <summary>
    ///   <para>rdfs:label : detectivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DetectivityUnit">oum:DetectivityUnit</a>
    /// </summary>
    let DetectivityUnit = _prefixId.prefix "DetectivityUnit"
    /// <summary>
    ///   <para>rdfs:label : diameterrdfs:label : diameterrdfs:label : 直径</para>
    ///   <para>oum:symbol : d^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Diameter">oum:Diameter</a>
    /// </summary>
    let Diameter = _prefixId.prefix "Diameter"
    /// <summary>
    ///   <para>rdfs:label : diameter (angle)rdfs:label : diameter (hoek)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Diameter-Angle">oum:Diameter-Angle</a>
    /// </summary>
    let Diameter_Angle = _prefixId.prefix "Diameter-Angle"
    /// <summary>
    ///   <para>rdfs:label : dimension</para>
    ///   <para>rdfs:comment : Dimensions are abstract properties of units and quantities neglecting their vectorial or tensorial character and all numerical factors including their sign.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Dimension">oum:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : directional dose equivalent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DirectionalDoseEquivalent">oum:DirectionalDoseEquivalent</a>
    /// </summary>
    let DirectionalDoseEquivalent = _prefixId.prefix "DirectionalDoseEquivalent"

    /// <summary>
    ///   <para>oum:alternativeLabel : NaEDTA mass fraction</para>
    ///   <para>rdfs:label : disodium ethylene diamine tetra acetate mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of disodium ethylene diamine tetra acetate in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DisodiumEthyleneDiamineTetreAcetateMassFraction">oum:DisodiumEthyleneDiamineTetreAcetateMassFraction</a>
    /// </summary>
    let DisodiumEthyleneDiamineTetreAcetateMassFraction = _prefixId.prefix "DisodiumEthyleneDiamineTetreAcetateMassFraction"

    /// <summary>
    ///   <para>rdfs:label : verplaatsingrdfs:label : displacement</para>
    ///   <para>oum:symbol : d^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Displacement">oum:Displacement</a>
    /// </summary>
    let Displacement = _prefixId.prefix "Displacement"
    /// <summary>
    ///   <para>rdfs:label : 距离rdfs:label : afstandrdfs:label : distance</para>
    ///   <para>oum:symbol : d^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Distance">oum:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    /// <summary>
    ///   <para>oum:symbol : m-M^^xsd:string</para>
    ///   <para>rdfs:label : distance modulus</para>
    ///   <para>rdfs:comment : The difference between the apparent magnitude (m) of an astronomical object, such as a star, and its absolute magnitude (M), used as a distance measurement. Distances can be expressed in distance modulii as $$m-M = 5\log d + 10 = 10-5 log \varpi$$ where \(d\) is the distance in kiloparsec and \(\varpi\) is the parallax in milliarcseconds.
    ///     </para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DistanceModulus">oum:DistanceModulus</a>
    /// </summary>
    let DistanceModulus = _prefixId.prefix "DistanceModulus"
    /// <summary>
    ///   <para>rdfs:label : diurnal aberration</para>
    ///   <para>rdfs:comment : The component of the stellar abberation resulting from the diurnal motion of the observer around the centre of the Earth. The abberation is the apparent angular displacement of the observed position of a celestial object from its geometric position, caused by the finite velocity of light in combination with the motions of the observer and of the observed object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DiurnalAberration">oum:DiurnalAberration</a>
    /// </summary>
    let DiurnalAberration = _prefixId.prefix "DiurnalAberration"
    /// <summary>
    ///   <para>rdfs:label : dose equivalent</para>
    ///   <para>rdfs:comment : Dose equivalent is a measure of the radiation dose to tissue where an attempt has been made to allow for the different relative biological effects of different types of ionizing radiation.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DoseEquivalent">oum:DoseEquivalent</a>
    /// </summary>
    let DoseEquivalent = _prefixId.prefix "DoseEquivalent"
    /// <summary>
    ///   <para>rdfs:label : dose equivalent unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DoseEquivalentUnit">oum:DoseEquivalentUnit</a>
    /// </summary>
    let DoseEquivalentUnit = _prefixId.prefix "DoseEquivalentUnit"
    /// <summary>
    ///   <para>rdfs:label : drainage speed</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DrainageSpeed">oum:DrainageSpeed</a>
    /// </summary>
    let DrainageSpeed = _prefixId.prefix "DrainageSpeed"
    /// <summary>
    ///   <para>oum:unofficialLabel : dry body weight^^xsd:string</para>
    ///   <para>rdfs:label : dry body mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DryBodyMass">oum:DryBodyMass</a>
    /// </summary>
    let DryBodyMass = _prefixId.prefix "DryBodyMass"
    /// <summary>
    ///   <para>oum:unofficialLabel : dry weight^^xsd:string</para>
    ///   <para>rdfs:label : dry mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DryMass">oum:DryMass</a>
    /// </summary>
    let DryMass = _prefixId.prefix "DryMass"
    /// <summary>
    ///   <para>rdfs:label : dry matter mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of dry matter in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DryMatterMassFraction">oum:DryMatterMassFraction</a>
    /// </summary>
    let DryMatterMassFraction = _prefixId.prefix "DryMatterMassFraction"
    /// <summary>
    ///   <para>rdfs:label : duurrdfs:label : duration</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Duration">oum:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:label : dynamic modulus</para>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DynamicModulus">oum:DynamicModulus</a>
    /// </summary>
    let DynamicModulus = _prefixId.prefix "DynamicModulus"
    /// <summary>
    ///   <para>rdfs:label : dynamic range</para>
    ///   <para>rdfs:comment : Ratio between the saturation output and the dark signal, sometimes only over the region of linearity.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DynamicRange">oum:DynamicRange</a>
    /// </summary>
    let DynamicRange = _prefixId.prefix "DynamicRange"
    /// <summary>
    ///   <para>rdfs:label : dynamic range unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DynamicRangeUnit">oum:DynamicRangeUnit</a>
    /// </summary>
    let DynamicRangeUnit = _prefixId.prefix "DynamicRangeUnit"
    /// <summary>
    ///   <para>rdfs:label : dynamische viscositeitrdfs:label : dynamic viscosity</para>
    ///   <para>oum:unofficialLabel : viscosity^^xsd:string</para>
    ///   <para>rdfs:comment : Viscosity is the definite resistance to change of form of many materials.</para>
    ///   <para>oum:alternativeSymbol : η^^xsd:string</para>
    ///   <para>oum:symbol : μ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DynamicViscosity">oum:DynamicViscosity</a>
    /// </summary>
    let DynamicViscosity = _prefixId.prefix "DynamicViscosity"
    /// <summary>
    ///   <para>rdfs:label : dynamic viscosity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/DynamicViscosityUnit">oum:DynamicViscosityUnit</a>
    /// </summary>
    let DynamicViscosityUnit = _prefixId.prefix "DynamicViscosityUnit"
    /// <summary>
    ///   <para>oum:symbol : e^^xsd:string</para>
    ///   <para>rdfs:label : eccentricityrdfs:label : eccentriciteit</para>
    ///   <para>rdfs:comment : A measure of the deviation from a circle for an orbit.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Eccentricity">oum:Eccentricity</a>
    /// </summary>
    let Eccentricity = _prefixId.prefix "Eccentricity"
    /// <summary>
    ///   <para>oum:symbol : β^^xsd:string</para>
    ///   <para>rdfs:label : ecliptic latitude</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere north or south of the ecliptic (the path of the Sun on the celestial sphere during one year). It is measured along the great circle passing through the object and the ecliptic poles and perpendicular to the ecliptic.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EclipticLatitude">oum:EclipticLatitude</a>
    /// </summary>
    let EclipticLatitude = _prefixId.prefix "EclipticLatitude"
    /// <summary>
    ///   <para>oum:symbol : λ^^xsd:string</para>
    ///   <para>rdfs:label : ecliptic longitude</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere measured clockwise from the vernal equinox along the ecliptic (the path of the Sun on the celestial sphere during one year) to the intersection with the great circle drawn from the ecliptical north pole through the object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EclipticLongitude">oum:EclipticLongitude</a>
    /// </summary>
    let EclipticLongitude = _prefixId.prefix "EclipticLongitude"
    /// <summary>
    ///   <para>rdfs:label : egg mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of egg in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EggMassFraction">oum:EggMassFraction</a>
    /// </summary>
    let EggMassFraction = _prefixId.prefix "EggMassFraction"
    /// <summary>
    ///   <para>oum:symbol : c_ijkl^^xsd:string</para>
    ///   <para>oum:alternativeLabel : stiffness tensor</para>
    ///   <para>rdfs:label : elasticity tensorrdfs:label : elasticiteitstensor</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElasticityTensor">oum:ElasticityTensor</a>
    /// </summary>
    let ElasticityTensor = _prefixId.prefix "ElasticityTensor"
    /// <summary>
    ///   <para>oum:alternativeSymbol : q^^xsd:string</para>
    ///   <para>oum:symbol : Q^^xsd:string</para>
    ///   <para>rdfs:comment : Electric charge is a conserved property of some subatomic particles, which determines their electromagnetic interaction. It is a derived quantity in the International System of Units. Electric charge is electric current times time.</para>
    ///   <para>oum:alternativeLabel : ladingoum:alternativeLabel : quantity of electricity</para>
    ///   <para>rdfs:label : electrische ladingrdfs:label : electric charge</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricCharge">oum:ElectricCharge</a>
    /// </summary>
    let ElectricCharge = _prefixId.prefix "ElectricCharge"
    /// <summary>
    ///   <para>oum:alternativeLabel : charge density</para>
    ///   <para>rdfs:label : electric charge density</para>
    ///   <para>rdfs:comment : Electric charge density is the amount of electric charge in a volume. It is a derived quantity in the International System of Units. Electric charge density is electric charge divided by volume.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricChargeDensity">oum:ElectricChargeDensity</a>
    /// </summary>
    let ElectricChargeDensity = _prefixId.prefix "ElectricChargeDensity"
    /// <summary>
    ///   <para>rdfs:label : electric charge density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricChargeDensityUnit">oum:ElectricChargeDensityUnit</a>
    /// </summary>
    let ElectricChargeDensityUnit = _prefixId.prefix "ElectricChargeDensityUnit"
    /// <summary>
    ///   <para>rdfs:label : electric charge unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricChargeUnit">oum:ElectricChargeUnit</a>
    /// </summary>
    let ElectricChargeUnit = _prefixId.prefix "ElectricChargeUnit"
    /// <summary>
    ///   <para>oum:symbol : I^^xsd:string</para>
    ///   <para>rdfs:comment : Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time.</para>
    ///   <para>rdfs:label : electric current</para>
    ///   <para>oum:alternativeSymbol : i^^xsd:string</para>
    ///   <para>oum:alternativeLabel : current</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricCurrent">oum:ElectricCurrent</a>
    /// </summary>
    let ElectricCurrent = _prefixId.prefix "ElectricCurrent"
    /// <summary>
    ///   <para>rdfs:label : electric current unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricCurrentUnit">oum:ElectricCurrentUnit</a>
    /// </summary>
    let ElectricCurrentUnit = _prefixId.prefix "ElectricCurrentUnit"
    /// <summary>
    ///   <para>oum:symbol : p^^xsd:string</para>
    ///   <para>rdfs:label : electric dipole moment</para>
    ///   <para>rdfs:comment : Electric dipole moment is a measure of the polarity of a system of electric charges.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricDipoleMoment">oum:ElectricDipoleMoment</a>
    /// </summary>
    let ElectricDipoleMoment = _prefixId.prefix "ElectricDipoleMoment"
    /// <summary>
    ///   <para>rdfs:label : electric dipole moment unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricDipoleMomentUnit">oum:ElectricDipoleMomentUnit</a>
    /// </summary>
    let ElectricDipoleMomentUnit = _prefixId.prefix "ElectricDipoleMomentUnit"
    /// <summary>
    ///   <para>rdfs:label : electrisch veldrdfs:label : electric field</para>
    ///   <para>oum:alternativeLabel : electric field strength</para>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <para>rdfs:comment : Electric field is a property of the space surrounding an electric charge or in the presence of a time-varying magnetic field which exerts a forceon other electrically charged objects.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricField">oum:ElectricField</a>
    /// </summary>
    let ElectricField = _prefixId.prefix "ElectricField"
    /// <summary>
    ///   <para>rdfs:label : electric field unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricFieldUnit">oum:ElectricFieldUnit</a>
    /// </summary>
    let ElectricFieldUnit = _prefixId.prefix "ElectricFieldUnit"
    /// <summary>
    ///   <para>rdfs:label : electric flux density</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricFluxDensity">oum:ElectricFluxDensity</a>
    /// </summary>
    let ElectricFluxDensity = _prefixId.prefix "ElectricFluxDensity"
    /// <summary>
    ///   <para>rdfs:label : electric flux density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricFluxDensityUnit">oum:ElectricFluxDensityUnit</a>
    /// </summary>
    let ElectricFluxDensityUnit = _prefixId.prefix "ElectricFluxDensityUnit"
    /// <summary>
    ///   <para>oum:alternativeSymbol : φ^^xsd:string</para>
    ///   <para>rdfs:label : electric potentialrdfs:label : electrische potentiaal</para>
    ///   <para>oum:symbol : V^^xsd:string</para>
    ///   <para>oum:alternativeLabel : voltageoum:alternativeLabel : voltage</para>
    ///   <para>rdfs:comment : Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricPotential">oum:ElectricPotential</a>
    /// </summary>
    let ElectricPotential = _prefixId.prefix "ElectricPotential"
    /// <summary>
    ///   <para>rdfs:label : electric potential unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricPotentialUnit">oum:ElectricPotentialUnit</a>
    /// </summary>
    let ElectricPotentialUnit = _prefixId.prefix "ElectricPotentialUnit"
    /// <summary>
    ///   <para>rdfs:label : electrical conductance</para>
    ///   <para>rdfs:comment : Electrical conductance is a measure of how easily electricity flows along a certain path through an electrical element.</para>
    ///   <para>oum:alternativeLabel : conductanceoum:alternativeLabel : electric conductance</para>
    ///   <para>oum:symbol : G^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalConductance">oum:ElectricalConductance</a>
    /// </summary>
    let ElectricalConductance = _prefixId.prefix "ElectricalConductance"
    /// <summary>
    ///   <para>rdfs:label : electrical conductance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalConductanceUnit">oum:ElectricalConductanceUnit</a>
    /// </summary>
    let ElectricalConductanceUnit = _prefixId.prefix "ElectricalConductanceUnit"
    /// <summary>
    ///   <para>rdfs:label : electrical conductivity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalConductivity">oum:ElectricalConductivity</a>
    /// </summary>
    let ElectricalConductivity = _prefixId.prefix "ElectricalConductivity"
    /// <summary>
    ///   <para>rdfs:label : electrical conductivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalConductivityUnit">oum:ElectricalConductivityUnit</a>
    /// </summary>
    let ElectricalConductivityUnit = _prefixId.prefix "ElectricalConductivityUnit"
    /// <summary>
    ///   <para>rdfs:label : electrical resistance</para>
    ///   <para>oum:alternativeLabel : resistanceoum:alternativeLabel : electric resistance</para>
    ///   <para>oum:symbol : R^^xsd:string</para>
    ///   <para>rdfs:comment : Electrical resistance is the degree to which an object opposes an electric current through it. It is a derived quantity in the International System of Units.  Electrical resistance is electric potential divided by electric current.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalResistance">oum:ElectricalResistance</a>
    /// </summary>
    let ElectricalResistance = _prefixId.prefix "ElectricalResistance"
    /// <summary>
    ///   <para>rdfs:label : electrical resistance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalResistanceUnit">oum:ElectricalResistanceUnit</a>
    /// </summary>
    let ElectricalResistanceUnit = _prefixId.prefix "ElectricalResistanceUnit"
    /// <summary>
    ///   <para>rdfs:label : electrical resistivity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalResistivity">oum:ElectricalResistivity</a>
    /// </summary>
    let ElectricalResistivity = _prefixId.prefix "ElectricalResistivity"
    /// <summary>
    ///   <para>rdfs:label : electrical resistivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectricalResistivityUnit">oum:ElectricalResistivityUnit</a>
    /// </summary>
    let ElectricalResistivityUnit = _prefixId.prefix "ElectricalResistivityUnit"
    /// <summary>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <para>rdfs:label : electromotive force</para>
    ///   <para>rdfs:comment : Electromotive force is that which causes a flow of current.</para>
    ///   <para>oum:alternativeSymbol : emf^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectromotiveForce">oum:ElectromotiveForce</a>
    /// </summary>
    let ElectromotiveForce = _prefixId.prefix "ElectromotiveForce"
    /// <summary>
    ///   <para>oum:symbol : T_e^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : T_k^^xsd:string</para>
    ///   <para>oum:alternativeLabel : kinetic temperature</para>
    ///   <para>rdfs:label : electron temperature</para>
    ///   <para>rdfs:comment : The temperature determined by the mean kinetic energy of free electrons in a plasma; also known as kinetic temperature.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ElectronTemperature">oum:ElectronTemperature</a>
    /// </summary>
    let ElectronTemperature = _prefixId.prefix "ElectronTemperature"
    /// <summary>
    ///   <para>oum:symbol : f^^xsd:string</para>
    ///   <para>oum:alternativeLabel : oblatenessoum:alternativeLabel : flattening</para>
    ///   <para>rdfs:label : ellipticity</para>
    ///   <para>rdfs:comment : A measure of the amount by which an object, such as a planet or a galaxy, deviates from a perfect sphere.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Ellipticity">oum:Ellipticity</a>
    /// </summary>
    let Ellipticity = _prefixId.prefix "Ellipticity"
    /// <summary>
    ///   <para>oum:alternativeSymbol : W^^xsd:string</para>
    ///   <para>rdfs:comment : Energy can be defined as the ability to do work. It is a derived quantity in the International System of Units.</para>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <para>rdfs:label : 能量rdfs:label : energyrdfs:label : energie</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Energy">oum:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : energy densityrdfs:label : energiedichtheid</para>
    ///   <para>rdfs:comment : Energy density is the amount of energy stored in a given system or region of space per unit volume.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EnergyDensity">oum:EnergyDensity</a>
    /// </summary>
    let EnergyDensity = _prefixId.prefix "EnergyDensity"
    /// <summary>
    ///   <para>rdfs:label : energy density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EnergyDensityUnit">oum:EnergyDensityUnit</a>
    /// </summary>
    let EnergyDensityUnit = _prefixId.prefix "EnergyDensityUnit"
    /// <summary>
    ///   <para>rdfs:label : energy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EnergyUnit">oum:EnergyUnit</a>
    /// </summary>
    let EnergyUnit = _prefixId.prefix "EnergyUnit"
    /// <summary>
    ///   <para>oum:symbol : H^^xsd:string</para>
    ///   <para>rdfs:label : enthalpierdfs:label : 焓rdfs:label : enthalpy</para>
    ///   <para>rdfs:comment : Enthalpy is the sum of the internal energy of a system plus the product of the pressure-volume work done on the system.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Enthalpy">oum:Enthalpy</a>
    /// </summary>
    let Enthalpy = _prefixId.prefix "Enthalpy"
    /// <summary>
    ///   <para>rdfs:label : entropierdfs:label : entropyrdfs:label : 熵单位</para>
    ///   <para>oum:symbol : S^^xsd:string</para>
    ///   <para>rdfs:comment : Entropy is a measure of the unavailability of a system’s energy to do work.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Entropy">oum:Entropy</a>
    /// </summary>
    let Entropy = _prefixId.prefix "Entropy"
    /// <summary>
    ///   <para>rdfs:label : entropy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EntropyUnit">oum:EntropyUnit</a>
    /// </summary>
    let EntropyUnit = _prefixId.prefix "EntropyUnit"
    /// <summary>
    ///   <para>rdfs:label : epoch</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Epoch">oum:Epoch</a>
    /// </summary>
    let Epoch = _prefixId.prefix "Epoch"
    /// <summary>
    ///   <para>rdfs:label : epoch at maximum brightness</para>
    ///   <para>rdfs:comment : A moment when the object (i.e. a variable star) was at maximum brightness.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EpochAtMaximumBrightness">oum:EpochAtMaximumBrightness</a>
    /// </summary>
    let EpochAtMaximumBrightness = _prefixId.prefix "EpochAtMaximumBrightness"
    /// <summary>
    ///   <para>oum:symbol : Eu^^xsd:string</para>
    ///   <para>rdfs:label : Euler numberrdfs:label : getal van Euler</para>
    ///   <para>rdfs:comment : The Euler number is a dimensionless number that expresses the relationship between a local pressure drop e.g. over a restriction and the kinetic energy per unit volume.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EulerNumber">oum:EulerNumber</a>
    /// </summary>
    let EulerNumber = _prefixId.prefix "EulerNumber"
    /// <summary>
    ///   <para>rdfs:label : Euler number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/EulerNumberUnit">oum:EulerNumberUnit</a>
    /// </summary>
    let EulerNumberUnit = _prefixId.prefix "EulerNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : exposure</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Exposure">oum:Exposure</a>
    /// </summary>
    let Exposure = _prefixId.prefix "Exposure"
    /// <summary>
    ///   <para>oum:alternativeLabel : exposure (to x and gamma rays)oum:alternativeLabel : exposure to x and gamma raysoum:alternativeLabel : exposure (to x and γ rays)oum:alternativeLabel : exposure</para>
    ///   <para>rdfs:label : exposure to x and γ rays</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExposureToXAndGammaRays">oum:ExposureToXAndGammaRays</a>
    /// </summary>
    let ExposureToXAndGammaRays = _prefixId.prefix "ExposureToXAndGammaRays"
    /// <summary>
    ///   <para>rdfs:label : exposure to x and γ rays unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExposureToXAndGammaRaysUnit">oum:ExposureToXAndGammaRaysUnit</a>
    /// </summary>
    let ExposureToXAndGammaRaysUnit = _prefixId.prefix "ExposureToXAndGammaRaysUnit"
    /// <summary>
    ///   <para>rdfs:label : exposure unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExposureUnit">oum:ExposureUnit</a>
    /// </summary>
    let ExposureUnit = _prefixId.prefix "ExposureUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : ext_brown</para>
    ///   <para>rdfs:label : external browning</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: poster (code).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExternalBrowning">oum:ExternalBrowning</a>
    /// </summary>
    let ExternalBrowning = _prefixId.prefix "ExternalBrowning"
    /// <summary>
    ///   <para>oum:symbol : A^^xsd:string</para>
    ///   <para>rdfs:label : extinctionrdfs:label : extinctie</para>
    ///   <para>rdfs:comment : Total extinction at a specific wavelength. The extinction is caused by dust and gas between a star and the observer. It is the difference between the observed magnitude and the magnitude the source would have had if no extinction had taken place.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Extinction">oum:Extinction</a>
    /// </summary>
    let Extinction = _prefixId.prefix "Extinction"
    /// <summary>
    ///   <para>oum:symbol : A_X^^xsd:string</para>
    ///   <para>rdfs:label : extinction at waveband</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExtinctionAtWaveband">oum:ExtinctionAtWaveband</a>
    /// </summary>
    let ExtinctionAtWaveband = _prefixId.prefix "ExtinctionAtWaveband"
    /// <summary>
    ///   <para>oum:symbol : A_λ^^xsd:string</para>
    ///   <para>rdfs:label : extinction at wavelength</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExtinctionAtWavelength">oum:ExtinctionAtWavelength</a>
    /// </summary>
    let ExtinctionAtWavelength = _prefixId.prefix "ExtinctionAtWavelength"
    /// <summary>
    ///   <para>oum:symbol : A_B^^xsd:string</para>
    ///   <para>rdfs:label : extinction in B</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExtinctionInB">oum:ExtinctionInB</a>
    /// </summary>
    let ExtinctionInB = _prefixId.prefix "ExtinctionInB"
    /// <summary>
    ///   <para>oum:symbol : A_U^^xsd:string</para>
    ///   <para>rdfs:label : extinction in U</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExtinctionInU">oum:ExtinctionInU</a>
    /// </summary>
    let ExtinctionInU = _prefixId.prefix "ExtinctionInU"
    /// <summary>
    ///   <para>oum:symbol : A_V^^xsd:string</para>
    ///   <para>rdfs:label : extinction in V</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ExtinctionInV">oum:ExtinctionInV</a>
    /// </summary>
    let ExtinctionInV = _prefixId.prefix "ExtinctionInV"
    let FahrenheitScale = _prefixId.prefix "FahrenheitScale"
    /// <summary>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <para>rdfs:label : Fahrenheit temperaturerdfs:label : Fahrenheittemperatuur</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FahrenheitTemperature">oum:FahrenheitTemperature</a>
    /// </summary>
    let FahrenheitTemperature = _prefixId.prefix "FahrenheitTemperature"
    /// <summary>
    ///   <para>rdfs:label : Fahrenheit temperature scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FahrenheitTemperatureScale">oum:FahrenheitTemperatureScale</a>
    /// </summary>
    let FahrenheitTemperatureScale = _prefixId.prefix "FahrenheitTemperatureScale"
    /// <summary>
    ///   <para>rdfs:label : Fahrenheit temperature unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FahrenheitTemperatureUnit">oum:FahrenheitTemperatureUnit</a>
    /// </summary>
    let FahrenheitTemperatureUnit = _prefixId.prefix "FahrenheitTemperatureUnit"
    /// <summary>
    ///   <para>rdfs:label : fat mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of fat in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FatMassFraction">oum:FatMassFraction</a>
    /// </summary>
    let FatMassFraction = _prefixId.prefix "FatMassFraction"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_pen_1</para>
    ///   <para>rdfs:label : firmness (penetrometer) (method 1)rdfs:label : stevigheid (penetrometer) (methode 1)</para>
    ///   <para>rdfs:comment : Stevigheid gemeten met penetrometer methode 1.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Firmness-Penetrometer-Method1">oum:Firmness-Penetrometer-Method1</a>
    /// </summary>
    let Firmness_Penetrometer_Method1 = _prefixId.prefix "Firmness-Penetrometer-Method1"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_pen_2</para>
    ///   <para>rdfs:label : firmness (penetrometer) (method 2)rdfs:label : stevigheid (penetrometer) (methode 2)</para>
    ///   <para>rdfs:comment : Stevigheid gemeten met penetrometer methode 2.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Firmness-Penetrometer-Method2">oum:Firmness-Penetrometer-Method2</a>
    /// </summary>
    let Firmness_Penetrometer_Method2 = _prefixId.prefix "Firmness-Penetrometer-Method2"
    /// <summary>
    ///   <para>oum:symbol : Co_1^^xsd:string</para>
    ///   <para>rdfs:label : first Cowling number</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FirstCowlingNumber">oum:FirstCowlingNumber</a>
    /// </summary>
    let FirstCowlingNumber = _prefixId.prefix "FirstCowlingNumber"
    /// <summary>
    ///   <para>rdfs:label : first Cowling number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FirstCowlingNumberUnit">oum:FirstCowlingNumberUnit</a>
    /// </summary>
    let FirstCowlingNumberUnit = _prefixId.prefix "FirstCowlingNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : fixed point</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FixedPoint">oum:FixedPoint</a>
    /// </summary>
    let FixedPoint = _prefixId.prefix "FixedPoint"
    /// <summary>
    ///   <para>rdfs:label : fixed zero point</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FixedZeroPoint">oum:FixedZeroPoint</a>
    /// </summary>
    let FixedZeroPoint = _prefixId.prefix "FixedZeroPoint"
    /// <summary>
    ///   <para>oum:unofficialLabel : flowpack weight^^xsd:string</para>
    ///   <para>rdfs:label : flowpack mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FlowpackMass">oum:FlowpackMass</a>
    /// </summary>
    let FlowpackMass = _prefixId.prefix "FlowpackMass"
    /// <summary>
    ///   <para>rdfs:label : fluidity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Fluidity">oum:Fluidity</a>
    /// </summary>
    let Fluidity = _prefixId.prefix "Fluidity"
    /// <summary>
    ///   <para>rdfs:label : fluidity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FluidityUnit">oum:FluidityUnit</a>
    /// </summary>
    let FluidityUnit = _prefixId.prefix "FluidityUnit"
    /// <summary>
    ///   <para>rdfs:label : font sizerdfs:label : fontgrootte</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FontSize">oum:FontSize</a>
    /// </summary>
    let FontSize = _prefixId.prefix "FontSize"
    /// <summary>
    ///   <para>rdfs:label : font size unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FontSizeUnit">oum:FontSizeUnit</a>
    /// </summary>
    let FontSizeUnit = _prefixId.prefix "FontSizeUnit"
    /// <summary>
    ///   <para>rdfs:label : forcerdfs:label : krachtrdfs:label : 力</para>
    ///   <para>rdfs:comment : Force is the extent to which an object with mass can be caused to accelerate. It is a derived quantity in the International System of Units. Force is mass times acceleration.</para>
    ///   <para>oum:symbol : F^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Force">oum:Force</a>
    /// </summary>
    let Force = _prefixId.prefix "Force"
    /// <summary>
    ///   <para>rdfs:label : force unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ForceUnit">oum:ForceUnit</a>
    /// </summary>
    let ForceUnit = _prefixId.prefix "ForceUnit"
    /// <summary>
    ///   <para>oum:symbol : Fo^^xsd:string</para>
    ///   <para>rdfs:label : Fourier numberrdfs:label : getal van Fourier</para>
    ///   <para>rdfs:comment : The Fourier number is a dimensionless number that characterises heat conduction. It is the ratio of heat conduction rate to rate of thermal energy storage. The Fourier number is a dimensionless time.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FourierNumber">oum:FourierNumber</a>
    /// </summary>
    let FourierNumber = _prefixId.prefix "FourierNumber"
    /// <summary>
    ///   <para>oum:symbol : Fo*^^xsd:string</para>
    ///   <para>rdfs:label : Fourier number for mass transfer</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FourierNumberForMassTransfer">oum:FourierNumberForMassTransfer</a>
    /// </summary>
    let FourierNumberForMassTransfer = _prefixId.prefix "FourierNumberForMassTransfer"

    /// <summary>
    ///   <para>rdfs:label : Fourier number for mass transfer unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FourierNumberForMassTransferUnit">oum:FourierNumberForMassTransferUnit</a>
    /// </summary>
    let FourierNumberForMassTransferUnit = _prefixId.prefix "FourierNumberForMassTransferUnit"

    /// <summary>
    ///   <para>rdfs:label : Fourier number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FourierNumberUnit">oum:FourierNumberUnit</a>
    /// </summary>
    let FourierNumberUnit = _prefixId.prefix "FourierNumberUnit"
    /// <summary>
    ///   <para>oum:alternativeSymbol : ν^^xsd:string</para>
    ///   <para>oum:unofficialAbbreviation : freq^^xsd:string</para>
    ///   <para>rdfs:label : frequentierdfs:label : frequencyrdfs:label : 频率</para>
    ///   <para>rdfs:comment : Frequency is a measure of the number of occurrences of a repeating event per unit time.</para>
    ///   <para>oum:symbol : f^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Frequency">oum:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : frequency unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FrequencyUnit">oum:FrequencyUnit</a>
    /// </summary>
    let FrequencyUnit = _prefixId.prefix "FrequencyUnit"
    /// <summary>
    ///   <para>rdfs:label : wrijvingrdfs:label : friction</para>
    ///   <para>rdfs:comment : Friction is a force that resists the relative motion of solid surfaces, fluid layers, or material elements sliding against each other.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Friction">oum:Friction</a>
    /// </summary>
    let Friction = _prefixId.prefix "Friction"
    /// <summary>
    ///   <para>oum:symbol : Fr^^xsd:string</para>
    ///   <para>rdfs:label : Froude numberrdfs:label : getal van Froude</para>
    ///   <para>rdfs:comment : The Froude number is a dimensionless number that compares inertial and gravitational forces. It may be used to quantify the resistance of an object moving through water, and compare objects of different sizes.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FroudeNumber">oum:FroudeNumber</a>
    /// </summary>
    let FroudeNumber = _prefixId.prefix "FroudeNumber"
    /// <summary>
    ///   <para>rdfs:label : Froude number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/FroudeNumberUnit">oum:FroudeNumberUnit</a>
    /// </summary>
    let FroudeNumberUnit = _prefixId.prefix "FroudeNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : functionrdfs:label : 関数</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Function">oum:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"

    /// <summary>
    ///   <para>oum:symbol : φ^^xsd:string</para>
    ///   <para>rdfs:label : galactic cylindrical polar angle coordinate</para>
    ///   <para>rdfs:comment : The angle from the Galactic centre between the perpendicular projection of the Sun on the Galactic plane and the projection of the object. This is one of the three Galactic Cylindrical Polar Coordinates.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GalacticCylindricalPolarAngleCoordinate">oum:GalacticCylindricalPolarAngleCoordinate</a>
    /// </summary>
    let GalacticCylindricalPolarAngleCoordinate = _prefixId.prefix "GalacticCylindricalPolarAngleCoordinate"

    /// <summary>
    ///   <para>oum:symbol : b^^xsd:string</para>
    ///   <para>rdfs:label : galactic latitude</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere north or south of the galactic equator. It is measured along the great circle passing through the object and the galactic poles and perpendicular to the galactic equator.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GalacticLatitude">oum:GalacticLatitude</a>
    /// </summary>
    let GalacticLatitude = _prefixId.prefix "GalacticLatitude"
    /// <summary>
    ///   <para>oum:symbol : l^^xsd:string</para>
    ///   <para>rdfs:label : galactic longitude</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere measured clockwise from the galactic centre (as defined by the International Astronomical Union (IAU)) along the galactic equator to the intersection with the great circle drawn from the galactic north pole through the object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GalacticLongitude">oum:GalacticLongitude</a>
    /// </summary>
    let GalacticLongitude = _prefixId.prefix "GalacticLongitude"
    /// <summary>
    ///   <para>oum:alternativeLabel : universele gasconstanteoum:alternativeLabel : universal gas constant</para>
    ///   <para>oum:symbol : R^^xsd:string</para>
    ///   <para>rdfs:label : gasconstanterdfs:label : gas constant</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GasConstant">oum:GasConstant</a>
    /// </summary>
    let GasConstant = _prefixId.prefix "GasConstant"
    /// <summary>
    ///   <para>rdfs:label : gas constant unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GasConstantUnit">oum:GasConstantUnit</a>
    /// </summary>
    let GasConstantUnit = _prefixId.prefix "GasConstantUnit"
    let GaussianSystemOfUnits = _prefixId.prefix "GaussianSystemOfUnits"
    /// <summary>
    ///   <para>rdfs:label : gelatin mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of gelatin in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GelatinMassFraction">oum:GelatinMassFraction</a>
    /// </summary>
    let GelatinMassFraction = _prefixId.prefix "GelatinMassFraction"
    /// <summary>
    ///   <para>oum:symbol : A^^xsd:string</para>
    ///   <para>oum:alternativeLabel : astronomical albedooum:alternativeLabel : physical albedo</para>
    ///   <para>rdfs:label : geometrical albedo</para>
    ///   <para>rdfs:comment : Ratio between the brightness of an object as seen from the direction of a hypothetical white, diffusely reflecting sphere of the same size and at the same distance.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GeometricalAlbedo">oum:GeometricalAlbedo</a>
    /// </summary>
    let GeometricalAlbedo = _prefixId.prefix "GeometricalAlbedo"
    /// <summary>
    ///   <para>rdfs:label : gram per prefixed litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GramPerPrefixedLitre">oum:GramPerPrefixedLitre</a>
    /// </summary>
    let GramPerPrefixedLitre = _prefixId.prefix "GramPerPrefixedLitre"
    /// <summary>
    ///   <para>oum:symbol : Gr^^xsd:string</para>
    ///   <para>rdfs:label : Grashof numberrdfs:label : getal van Grashof</para>
    ///   <para>rdfs:comment : The Grashof number is a dimensionless number that approximates the ratio of buoyancy to viscous force that acts on a fluid.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GrashofNumber">oum:GrashofNumber</a>
    /// </summary>
    let GrashofNumber = _prefixId.prefix "GrashofNumber"
    /// <summary>
    ///   <para>oum:symbol : Gr*^^xsd:string</para>
    ///   <para>rdfs:label : Grashof number for mass transfer</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GrashofNumberForMassTransfer">oum:GrashofNumberForMassTransfer</a>
    /// </summary>
    let GrashofNumberForMassTransfer = _prefixId.prefix "GrashofNumberForMassTransfer"

    /// <summary>
    ///   <para>rdfs:label : Grashof number for mass transfer unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GrashofNumberForMassTransferUnit">oum:GrashofNumberForMassTransferUnit</a>
    /// </summary>
    let GrashofNumberForMassTransferUnit = _prefixId.prefix "GrashofNumberForMassTransferUnit"

    /// <summary>
    ///   <para>rdfs:label : Grashof number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GrashofNumberUnit">oum:GrashofNumberUnit</a>
    /// </summary>
    let GrashofNumberUnit = _prefixId.prefix "GrashofNumberUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : acceleration of free falloum:alternativeLabel : gravitatieveldsterkteoum:alternativeLabel : zwaarteveldsterkte</para>
    ///   <para>rdfs:label : valversnellingrdfs:label : gravitational acceleration</para>
    ///   <para>oum:symbol : g^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GravitationalAcceleration">oum:GravitationalAcceleration</a>
    /// </summary>
    let GravitationalAcceleration = _prefixId.prefix "GravitationalAcceleration"
    /// <summary>
    ///   <para>rdfs:label : guar gum mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of guar gum in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/GuarGumMassFraction">oum:GuarGumMassFraction</a>
    /// </summary>
    let GuarGumMassFraction = _prefixId.prefix "GuarGumMassFraction"
    /// <summary>
    ///   <para>rdfs:label : half-life</para>
    ///   <para>oum:LaTeXSymbol : T_{\frac{1}{2}}^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : T_½^^xsd:stringoum:alternativeSymbol : t_1/2^^xsd:stringoum:alternativeSymbol : τ_½^^xsd:string</para>
    ///   <para>oum:LaTeXCommand : \Halflife^^xsd:string</para>
    ///   <para>oum:symbol : t_½^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Half-Life">oum:Half-Life</a>
    /// </summary>
    let Half_Life = _prefixId.prefix "Half-Life"
    /// <summary>
    ///   <para>oum:symbol : Ha^^xsd:string</para>
    ///   <para>rdfs:label : Hartmann numberrdfs:label : getal van Hartmann</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HartmannNumber">oum:HartmannNumber</a>
    /// </summary>
    let HartmannNumber = _prefixId.prefix "HartmannNumber"
    /// <summary>
    ///   <para>rdfs:label : Hartmann number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HartmannNumberUnit">oum:HartmannNumberUnit</a>
    /// </summary>
    let HartmannNumberUnit = _prefixId.prefix "HartmannNumberUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : quantity of heat</para>
    ///   <para>rdfs:label : warmterdfs:label : heat</para>
    ///   <para>rdfs:comment : Heat is any flow of energy from one body or system to another due to a difference in temperature.</para>
    ///   <para>oum:symbol : Q^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Heat">oum:Heat</a>
    /// </summary>
    let Heat = _prefixId.prefix "Heat"
    /// <summary>
    ///   <para>rdfs:label : heat capacityrdfs:label : 热容量rdfs:label : warmtecapaciteit</para>
    ///   <para>oum:alternativeSymbol : C_v^^xsd:string</para>
    ///   <para>oum:symbol : C_p^^xsd:string</para>
    ///   <para>rdfs:comment : Heat capacity is the heat required to increase the temperature of a system or substance one unit temperature.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HeatCapacity">oum:HeatCapacity</a>
    /// </summary>
    let HeatCapacity = _prefixId.prefix "HeatCapacity"
    /// <summary>
    ///   <para>rdfs:label : heat capacity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HeatCapacityUnit">oum:HeatCapacityUnit</a>
    /// </summary>
    let HeatCapacityUnit = _prefixId.prefix "HeatCapacityUnit"
    /// <summary>
    ///   <para>rdfs:label : heat flow rate</para>
    ///   <para>oum:symbol : Φ^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : q^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HeatFlowRate">oum:HeatFlowRate</a>
    /// </summary>
    let HeatFlowRate = _prefixId.prefix "HeatFlowRate"
    /// <summary>
    ///   <para>rdfs:label : heat flux density</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HeatFluxDensity">oum:HeatFluxDensity</a>
    /// </summary>
    let HeatFluxDensity = _prefixId.prefix "HeatFluxDensity"
    /// <summary>
    ///   <para>rdfs:label : heat transfer coefficient</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HeatTransferCoefficient">oum:HeatTransferCoefficient</a>
    /// </summary>
    let HeatTransferCoefficient = _prefixId.prefix "HeatTransferCoefficient"
    /// <summary>
    ///   <para>rdfs:label : heat transfer coefficient unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HeatTransferCoefficientUnit">oum:HeatTransferCoefficientUnit</a>
    /// </summary>
    let HeatTransferCoefficientUnit = _prefixId.prefix "HeatTransferCoefficientUnit"
    /// <summary>
    ///   <para>oum:symbol : h^^xsd:string</para>
    ///   <para>rdfs:label : heightrdfs:label : hoogte</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Height">oum:Height</a>
    /// </summary>
    let Height = _prefixId.prefix "Height"
    let HongKongDollar = _prefixId.prefix "HongKongDollar"
    /// <summary>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere measured westward along the celestial equator from the meridian to the hour circle that passes through the celestial object.</para>
    ///   <para>rdfs:label : uurhoekrdfs:label : hour angle</para>
    ///   <para>oum:symbol : H^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HourAngle">oum:HourAngle</a>
    /// </summary>
    let HourAngle = _prefixId.prefix "HourAngle"
    /// <summary>
    ///   <para>rdfs:label : Hubble constantrdfs:label : constante van Hubble</para>
    ///   <para>rdfs:comment : The Hubble constant (NOT a constant over time).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HubbleConstant">oum:HubbleConstant</a>
    /// </summary>
    let HubbleConstant = _prefixId.prefix "HubbleConstant"
    /// <summary>
    ///   <para>oum:symbol : H_0^^xsd:string</para>
    ///   <para>rdfs:label : Hubble constant at present epochrdfs:label : constante van Hubble tijdens het huidige epoch</para>
    ///   <para>rdfs:comment : The Hubble constant at the present epoch (a constant).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HubbleConstantAtPresentEpoch">oum:HubbleConstantAtPresentEpoch</a>
    /// </summary>
    let HubbleConstantAtPresentEpoch = _prefixId.prefix "HubbleConstantAtPresentEpoch"
    /// <summary>
    ///   <para>rdfs:label : Hubble constant unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/HubbleConstantUnit">oum:HubbleConstantUnit</a>
    /// </summary>
    let HubbleConstantUnit = _prefixId.prefix "HubbleConstantUnit"
    /// <summary>
    ///   <para>rdfs:label : hydrophilicityrdfs:label : hydrofiliciteit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Hydrophilicity">oum:Hydrophilicity</a>
    /// </summary>
    let Hydrophilicity = _prefixId.prefix "Hydrophilicity"
    /// <summary>
    ///   <para>rdfs:label : hydrophobicityrdfs:label : hydrofobiciteit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Hydrophobicity">oum:Hydrophobicity</a>
    /// </summary>
    let Hydrophobicity = _prefixId.prefix "Hydrophobicity"
    /// <summary>
    ///   <para>oum:symbol : I^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m_I^^xsd:string</para>
    ///   <para>rdfs:label : I magnitude</para>
    ///   <para>rdfs:comment : I magnitude in the Cousins photometric system.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/IMagnitude">oum:IMagnitude</a>
    /// </summary>
    let IMagnitude = _prefixId.prefix "IMagnitude"
    /// <summary>
    ///   <para>oum:symbol : Φ^^xsd:string</para>
    ///   <para>rdfs:label : illuminance</para>
    ///   <para>oum:alternativeSymbol : Φ_v^^xsd:string</para>
    ///   <para>rdfs:comment : Illuminance is the total luminous flux incident on a surface per unit area.</para>
    ///   <para>oum:alternativeLabel : illumination</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Illuminance">oum:Illuminance</a>
    /// </summary>
    let Illuminance = _prefixId.prefix "Illuminance"
    /// <summary>
    ///   <para>rdfs:label : illuminance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/IlluminanceUnit">oum:IlluminanceUnit</a>
    /// </summary>
    let IlluminanceUnit = _prefixId.prefix "IlluminanceUnit"
    /// <summary>
    ///   <para>oum:symbol : I^^xsd:string</para>
    ///   <para>rdfs:label : impulserdfs:label : stoot</para>
    ///   <para>rdfs:comment : Impulse is the integral of a force with respect to time.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Impulse">oum:Impulse</a>
    /// </summary>
    let Impulse = _prefixId.prefix "Impulse"
    let IndianRupee = _prefixId.prefix "IndianRupee"
    /// <summary>
    ///   <para>rdfs:comment : Inductance is that property in an electrical circuit where a change in the current flowing through that circuit induces an electromotive force that opposes the change in current.</para>
    ///   <para>rdfs:label : inductance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Inductance">oum:Inductance</a>
    /// </summary>
    let Inductance = _prefixId.prefix "Inductance"
    /// <summary>
    ///   <para>rdfs:label : inductance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/InductanceUnit">oum:InductanceUnit</a>
    /// </summary>
    let InductanceUnit = _prefixId.prefix "InductanceUnit"
    /// <summary>
    ///   <para>rdfs:label : information capacityrdfs:label : informatiecapaciteit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/InformationCapacity">oum:InformationCapacity</a>
    /// </summary>
    let InformationCapacity = _prefixId.prefix "InformationCapacity"
    /// <summary>
    ///   <para>rdfs:label : information capacity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/InformationCapacityUnit">oum:InformationCapacityUnit</a>
    /// </summary>
    let InformationCapacityUnit = _prefixId.prefix "InformationCapacityUnit"
    /// <summary>
    ///   <para>oum:symbol : IMF^^xsd:string</para>
    ///   <para>rdfs:label : initial mass function</para>
    ///   <para>rdfs:comment : The number of stars in mass fraction dM around mass M. Used in Salpeter's Initial Mass Function (IMF).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/InitialMassFunction">oum:InitialMassFunction</a>
    /// </summary>
    let InitialMassFunction = _prefixId.prefix "InitialMassFunction"
    /// <summary>
    ///   <para>rdfs:label : integrated magnitude</para>
    ///   <para>rdfs:comment : The apparent magnitude that an extended object, such as a nebula or galaxy, would have if all its light were concentrated at a starlike point.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/IntegratedMagnitude">oum:IntegratedMagnitude</a>
    /// </summary>
    let IntegratedMagnitude = _prefixId.prefix "IntegratedMagnitude"
    /// <summary>
    ///   <para>oum:symbol : U^^xsd:string</para>
    ///   <para>rdfs:label : inwendige energierdfs:label : internal energy</para>
    ///   <para>rdfs:comment : The internal energy of a thermodynamic system, or a body with well-defined boundaries is the total of the kinetic energy due to the motion of molecules (translational, rotational, vibrational) and the potential energy associated with the vibrational and electric energy of atoms within molecules or crystals.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/InternalEnergy">oum:InternalEnergy</a>
    /// </summary>
    let InternalEnergy = _prefixId.prefix "InternalEnergy"
    let InternationalSystemOfUnits = _prefixId.prefix "InternationalSystemOfUnits"
    let InternationalUnit = _prefixId.prefix "InternationalUnit"
    /// <summary>
    ///   <para>rdfs:label : interval scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/IntervalScale">oum:IntervalScale</a>
    /// </summary>
    let IntervalScale = _prefixId.prefix "IntervalScale"
    /// <summary>
    ///   <para>rdfs:label : intrinsic colour index</para>
    ///   <para>rdfs:comment : The colour index a star would have in the absence of interstellar extinction (reddening). It is assumed that all stars of the same spectral type and luminosity class have the same colour index.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/IntrinsicColourIndex">oum:IntrinsicColourIndex</a>
    /// </summary>
    let IntrinsicColourIndex = _prefixId.prefix "IntrinsicColourIndex"
    /// <summary>
    ///   <para>oum:symbol : T_ion^^xsd:string</para>
    ///   <para>rdfs:label : ionization temperature</para>
    ///   <para>rdfs:comment : The temperature of a gas or plasma derived from the relative numbers of neutral atoms and ions. Specifically, it is the temperature for which the Saha equations would predict these relative numbers, assuming the atoms and ions are in thermodynamic equilibrium.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/IonizationTemperature">oum:IonizationTemperature</a>
    /// </summary>
    let IonizationTemperature = _prefixId.prefix "IonizationTemperature"
    /// <summary>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : E_e^^xsd:string</para>
    ///   <para>rdfs:label : irradiance</para>
    ///   <para>rdfs:comment : Irradiance is the power of electromagnetic radiation at a surface per unit area.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Irradiance">oum:Irradiance</a>
    /// </summary>
    let Irradiance = _prefixId.prefix "Irradiance"
    let JapaneseYen = _prefixId.prefix "JapaneseYen"
    /// <summary>
    ///   <para>oum:symbol : M_J^^xsd:string</para>
    ///   <para>rdfs:label : Jeans mass</para>
    ///   <para>rdfs:comment : The critical mass of a molecular cloud, above which it will be unstable to collapse.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/JeansMass">oum:JeansMass</a>
    /// </summary>
    let JeansMass = _prefixId.prefix "JeansMass"
    /// <summary>
    ///   <para>oum:longcomment : For accurate photometry the magnitude needs to be determined over well-defined spectral regions as the spectrum of to objects may be quite different. These magnitudes are measured using filters that allows only radiation within specific spectral regions (passbands) to pass through to the detector. These filters have accurately defined transmission curves characterised by a central wavelength and a bandwidth. The UBV system devised by Harold Johnson and William Morgan has been the most important general system until recently. The precise definition requires a reflecting telescope with aluminised mirrors fitted with an RCA 1P21 photomultiplier. The U region corresponds to a region in the violet and ultraviolet, the B region corresponds to typical photographic response and the V region to the visual response region (approximating the eye's response curve).^^rdf:XMLLiteral</para>
    ///   <para>rdfs:label : Johnson magnitude</para>
    ///   <para>rdfs:comment : A magnitude measured in one of Johnson's standard passbands (using a standard filter, i.e. U, B, or V).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/JohnsonMagnitude">oum:JohnsonMagnitude</a>
    /// </summary>
    let JohnsonMagnitude = _prefixId.prefix "JohnsonMagnitude"
    let KelvinScale = _prefixId.prefix "KelvinScale"
    /// <summary>
    ///   <para>rdfs:label : kerma</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Kerma">oum:Kerma</a>
    /// </summary>
    let Kerma = _prefixId.prefix "Kerma"
    /// <summary>
    ///   <para>rdfs:label : kinematische viscositeitrdfs:label : kinematic viscosity</para>
    ///   <para>oum:symbol : ν^^xsd:string</para>
    ///   <para>oum:unofficialLabel : viscosity^^xsd:string</para>
    ///   <para>rdfs:comment : Kinematic viscosity is the ratio of viscosity to density.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/KinematicViscosity">oum:KinematicViscosity</a>
    /// </summary>
    let KinematicViscosity = _prefixId.prefix "KinematicViscosity"
    /// <summary>
    ///   <para>rdfs:label : kinematic viscosity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/KinematicViscosityUnit">oum:KinematicViscosityUnit</a>
    /// </summary>
    let KinematicViscosityUnit = _prefixId.prefix "KinematicViscosityUnit"
    /// <summary>
    ///   <para>rdfs:label : 动能rdfs:label : kinetic energyrdfs:label : kinetische energie</para>
    ///   <para>oum:alternativeLabel : bewegingsenergie</para>
    ///   <para>oum:symbol : E_k^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : T^^xsd:stringoum:alternativeSymbol : K^^xsd:string</para>
    ///   <para>rdfs:comment : Kinetic energy is energy due to motion.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/KineticEnergy">oum:KineticEnergy</a>
    /// </summary>
    let KineticEnergy = _prefixId.prefix "KineticEnergy"
    /// <summary>
    ///   <para>oum:symbol : Kn^^xsd:string</para>
    ///   <para>rdfs:label : Knudsen numberrdfs:label : getal van Knudsen</para>
    ///   <para>rdfs:comment : The Knudsen number is a dimensionless number defined as the ratio of the molecular mean free path length to a representative physical length scale.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/KnudsenNumber">oum:KnudsenNumber</a>
    /// </summary>
    let KnudsenNumber = _prefixId.prefix "KnudsenNumber"
    /// <summary>
    ///   <para>rdfs:label : Knudsen number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/KnudsenNumberUnit">oum:KnudsenNumberUnit</a>
    /// </summary>
    let KnudsenNumberUnit = _prefixId.prefix "KnudsenNumberUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : typeset by LaTeX command</para>
    ///   <para>rdfs:label : LaTeX command</para>
    ///   <para>rdfs:comment : OMLaTeX command that can be used to render this quantity or unit.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LaTeXCommand">oum:LaTeXCommand</a>
    /// </summary>
    let LaTeXCommand = _prefixId.prefix "LaTeXCommand"
    /// <summary>
    ///   <para>oum:alternativeLabel : has LaTeX symboloum:alternativeLabel : LaTeX formatted symbol</para>
    ///   <para>rdfs:label : LaTeX symbol</para>
    ///   <para>rdfs:comment : OMLaTeX formatted symbol may include commands such as \unit and \E as defined in OMLaTeX.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LaTeXSymbol">oum:LaTeXSymbol</a>
    /// </summary>
    let LaTeXSymbol = _prefixId.prefix "LaTeXSymbol"
    /// <summary>
    ///   <para>oum:unofficialLabel : label weight^^xsd:string</para>
    ///   <para>rdfs:label : label mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LabelMass">oum:LabelMass</a>
    /// </summary>
    let LabelMass = _prefixId.prefix "LabelMass"
    /// <summary>
    ///   <para>rdfs:label : lactose mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of lactose in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LactoseMassFraction">oum:LactoseMassFraction</a>
    /// </summary>
    let LactoseMassFraction = _prefixId.prefix "LactoseMassFraction"
    /// <summary>
    ///   <para>rdfs:label : lengterdfs:label : lengthrdfs:label : 长度</para>
    ///   <para>oum:symbol : l^^xsd:string</para>
    ///   <para>rdfs:comment : Length is the amount of space between two geographical points along a curve. It is a base quantity in the International System of Units and other systems of units. Length is speed times time. The metre, a base unit of length in the International System of Units, is defined in terms of speed of light during a certain time interval.</para>
    ///   <para>oum:alternativeSymbol : L^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Length">oum:Length</a>
    /// </summary>
    let Length = _prefixId.prefix "Length"
    /// <summary>
    ///   <para>rdfs:label : length unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LengthUnit">oum:LengthUnit</a>
    /// </summary>
    let LengthUnit = _prefixId.prefix "LengthUnit"
    /// <summary>
    ///   <para>oum:symbol : Le^^xsd:string</para>
    ///   <para>rdfs:label : Lewis numberrdfs:label : getal van Lewis</para>
    ///   <para>rdfs:comment : The Lewis number is a dimensionless number defined as the ratio of thermal diffusivity to mass diffusivity.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LewisNumber">oum:LewisNumber</a>
    /// </summary>
    let LewisNumber = _prefixId.prefix "LewisNumber"
    /// <summary>
    ///   <para>rdfs:label : Lewis number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LewisNumberUnit">oum:LewisNumberUnit</a>
    /// </summary>
    let LewisNumberUnit = _prefixId.prefix "LewisNumberUnit"
    /// <summary>
    ///   <para>oum:symbol : τ^^xsd:string</para>
    ///   <para>rdfs:label : light time</para>
    ///   <para>rdfs:comment : The time electromagnetic radiation takes to reach Earth from a distant source. Often the correction in light time is needed to accurately calculate the apparent position of solar system objects or to calculate the period of variable stars (different times are observed when the Earth is at a different position in its orbit).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LightTime">oum:LightTime</a>
    /// </summary>
    let LightTime = _prefixId.prefix "LightTime"
    /// <summary>
    ///   <para>rdfs:label : limiting magnitude</para>
    ///   <para>rdfs:comment : The magnitude of the faintest object (star) that can be detected by a telescope or other instrument. Depends not only on the telescope but also on the detector and on the observing method.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LimitingMagnitude">oum:LimitingMagnitude</a>
    /// </summary>
    let LimitingMagnitude = _prefixId.prefix "LimitingMagnitude"
    /// <summary>
    ///   <para>oum:alternativeSymbol : e^^xsd:string</para>
    ///   <para>rdfs:label : linear strainrdfs:label : lineaire vervorming</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LinearStrain">oum:LinearStrain</a>
    /// </summary>
    let LinearStrain = _prefixId.prefix "LinearStrain"
    /// <summary>
    ///   <para>rdfs:label : lipophilicityrdfs:label : lipofiliciteit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Lipophilicity">oum:Lipophilicity</a>
    /// </summary>
    let Lipophilicity = _prefixId.prefix "Lipophilicity"
    /// <summary>
    ///   <para>rdfs:label : locust bean gum mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of locust bean gum in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LocustBeanGumMassFraction">oum:LocustBeanGumMassFraction</a>
    /// </summary>
    let LocustBeanGumMassFraction = _prefixId.prefix "LocustBeanGumMassFraction"
    /// <summary>
    ///   <para>oum:symbol : E''^^xsd:string</para>
    ///   <para>rdfs:label : loss modulus</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LossModulus">oum:LossModulus</a>
    /// </summary>
    let LossModulus = _prefixId.prefix "LossModulus"
    /// <summary>
    ///   <para>rdfs:comment : Luminous flux is the total visible energy emitted by a source per unit time.</para>
    ///   <para>oum:symbol : L^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : L_v^^xsd:string</para>
    ///   <para>rdfs:label : luminance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Luminance">oum:Luminance</a>
    /// </summary>
    let Luminance = _prefixId.prefix "Luminance"
    /// <summary>
    ///   <para>rdfs:label : luminance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminanceUnit">oum:LuminanceUnit</a>
    /// </summary>
    let LuminanceUnit = _prefixId.prefix "LuminanceUnit"
    /// <summary>
    ///   <para>rdfs:label : luminosity function</para>
    ///   <para>rdfs:comment : The number of stars of absolute magnitudes between Mv and Mv+ΔMv per cubic parsec.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminosityFunction">oum:LuminosityFunction</a>
    /// </summary>
    let LuminosityFunction = _prefixId.prefix "LuminosityFunction"
    /// <summary>
    ///   <para>rdfs:label : luminous efficacy</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousEfficacy">oum:LuminousEfficacy</a>
    /// </summary>
    let LuminousEfficacy = _prefixId.prefix "LuminousEfficacy"
    /// <summary>
    ///   <para>rdfs:label : luminous efficacy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousEfficacyUnit">oum:LuminousEfficacyUnit</a>
    /// </summary>
    let LuminousEfficacyUnit = _prefixId.prefix "LuminousEfficacyUnit"
    /// <summary>
    ///   <para>oum:symbol : F^^xsd:string</para>
    ///   <para>rdfs:label : luminous energy</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousEnergy">oum:LuminousEnergy</a>
    /// </summary>
    let LuminousEnergy = _prefixId.prefix "LuminousEnergy"
    /// <summary>
    ///   <para>rdfs:label : luminous energy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousEnergyUnit">oum:LuminousEnergyUnit</a>
    /// </summary>
    let LuminousEnergyUnit = _prefixId.prefix "LuminousEnergyUnit"
    /// <summary>
    ///   <para>rdfs:comment : Luminous flux is the total visible energy emitted by a source per unit time.</para>
    ///   <para>oum:symbol : F^^xsd:string</para>
    ///   <para>rdfs:label : luminous flux</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousFlux">oum:LuminousFlux</a>
    /// </summary>
    let LuminousFlux = _prefixId.prefix "LuminousFlux"
    /// <summary>
    ///   <para>rdfs:label : luminous flux unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousFluxUnit">oum:LuminousFluxUnit</a>
    /// </summary>
    let LuminousFluxUnit = _prefixId.prefix "LuminousFluxUnit"
    /// <summary>
    ///   <para>oum:alternativeSymbol : I_v^^xsd:string</para>
    ///   <para>oum:symbol : I^^xsd:string</para>
    ///   <para>rdfs:label : lichtsterkterdfs:label : luminous intensity</para>
    ///   <para>rdfs:comment : Luminous intensity is the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle. It is a base quantity in the International System of Units. Luminous intensity is luminous flux divided by solid angle.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousIntensity">oum:LuminousIntensity</a>
    /// </summary>
    let LuminousIntensity = _prefixId.prefix "LuminousIntensity"
    /// <summary>
    ///   <para>rdfs:label : luminous intensity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/LuminousIntensityUnit">oum:LuminousIntensityUnit</a>
    /// </summary>
    let LuminousIntensityUnit = _prefixId.prefix "LuminousIntensityUnit"
    /// <summary>
    ///   <para>oum:symbol : Ma^^xsd:string</para>
    ///   <para>rdfs:label : Mach numberrdfs:label : Machgetal</para>
    ///   <para>rdfs:comment : The Mach number is the speed of an object that moves through air, or any fluid substance, divided by the speed of sound as it is in that substance.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MachNumber">oum:MachNumber</a>
    /// </summary>
    let MachNumber = _prefixId.prefix "MachNumber"
    /// <summary>
    ///   <para>rdfs:label : Mach number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MachNumberUnit">oum:MachNumberUnit</a>
    /// </summary>
    let MachNumberUnit = _prefixId.prefix "MachNumberUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : magnetic field strengthoum:alternativeLabel : magnetic field intensityoum:alternativeLabel : magnetizing field</para>
    ///   <para>oum:symbol : H^^xsd:string</para>
    ///   <para>rdfs:label : magnetic field</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticField">oum:MagneticField</a>
    /// </summary>
    let MagneticField = _prefixId.prefix "MagneticField"
    let MagneticField_Dimension = _prefixId.prefix "MagneticField-Dimension"
    /// <summary>
    ///   <para>rdfs:label : magnetic field unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticFieldUnit">oum:MagneticFieldUnit</a>
    /// </summary>
    let MagneticFieldUnit = _prefixId.prefix "MagneticFieldUnit"
    /// <summary>
    ///   <para>oum:symbol : Φ^^xsd:string</para>
    ///   <para>rdfs:label : magnetic flux</para>
    ///   <para>rdfs:comment : Magnetic flux through any area perpendicular to a magnetic field is the product of the area by the field strength.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticFlux">oum:MagneticFlux</a>
    /// </summary>
    let MagneticFlux = _prefixId.prefix "MagneticFlux"
    /// <summary>
    ///   <para>oum:alternativeLabel : magnetic fieldoum:alternativeLabel : magnetic induction</para>
    ///   <para>oum:symbol : B^^xsd:string</para>
    ///   <para>rdfs:label : magnetic flux density</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticFluxDensity">oum:MagneticFluxDensity</a>
    /// </summary>
    let MagneticFluxDensity = _prefixId.prefix "MagneticFluxDensity"
    /// <summary>
    ///   <para>rdfs:label : magnetic flux density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticFluxDensityUnit">oum:MagneticFluxDensityUnit</a>
    /// </summary>
    let MagneticFluxDensityUnit = _prefixId.prefix "MagneticFluxDensityUnit"
    /// <summary>
    ///   <para>rdfs:label : magnetic flux unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticFluxUnit">oum:MagneticFluxUnit</a>
    /// </summary>
    let MagneticFluxUnit = _prefixId.prefix "MagneticFluxUnit"
    /// <summary>
    ///   <para>oum:symbol : Rm^^xsd:string</para>
    ///   <para>rdfs:label : magnetic Reynolds numberrdfs:label : magnetisch getal van Reynolds</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticReynoldsNumber">oum:MagneticReynoldsNumber</a>
    /// </summary>
    let MagneticReynoldsNumber = _prefixId.prefix "MagneticReynoldsNumber"
    /// <summary>
    ///   <para>rdfs:label : magnetic Reynolds number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagneticReynoldsNumberUnit">oum:MagneticReynoldsNumberUnit</a>
    /// </summary>
    let MagneticReynoldsNumberUnit = _prefixId.prefix "MagneticReynoldsNumberUnit"
    /// <summary>
    ///   <para>oum:symbol : F^^xsd:string</para>
    ///   <para>rdfs:label : magnetomotive force</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagnetomotiveForce">oum:MagnetomotiveForce</a>
    /// </summary>
    let MagnetomotiveForce = _prefixId.prefix "MagnetomotiveForce"
    /// <summary>
    ///   <para>rdfs:label : magnetomotive force unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagnetomotiveForceUnit">oum:MagnetomotiveForceUnit</a>
    /// </summary>
    let MagnetomotiveForceUnit = _prefixId.prefix "MagnetomotiveForceUnit"
    /// <summary>
    ///   <para>rdfs:label : magnituderdfs:label : magnitude</para>
    ///   <para>oum:longcomment : The magnitude scale was originally created by Hipparchos of Nicea (160-127 BCE) and was measured by comparing the brightness between stars. Initially this was done inaccurately by eye but is currently done by using photoelectric photometers or even more recently by CCDs. Hipparchos divided the stars into six magnitude (brightness classes), the brightest stars being assigned to the first class and the faintest to the sixth class. By about the middle 1800s it became apparent that the traditional magnitude scale is close to a logarithmic scale with base 2.5. This is due to the fact that the response of the eye is nearly logarithmic. N.R. Pogson formalised the magnitude scale to closely match the traditional (visual) scale. It is now defined as:
    ///     &lt;math xmlns="http://www.w3.org/1998/Math/MathML" display="block"&gt;
    ///    		&lt;msub&gt;&lt;mi&gt;m&lt;/mi&gt;&lt;mn&gt;1&lt;/mn&gt;&lt;/msub&gt; &lt;mo&gt;-&lt;/mo&gt; &lt;msub&gt;&lt;mi&gt;m&lt;/mi&gt;&lt;mn&gt;2&lt;/mn&gt;  &lt;/msub&gt;&lt;mo&gt;=&lt;/mo&gt;
    ///    		&lt;mn&gt;-2.5&lt;/mn&gt;&lt;mi&gt;log&lt;/mi&gt;
    ///     	&lt;mfrac linethickness="1"&gt;
    ///     		&lt;mrow&gt;
    ///     			&lt;msub&gt;&lt;mi&gt;f&lt;/mi&gt;&lt;mn&gt;1&lt;/mn&gt;&lt;/msub&gt;
    ///     		&lt;/mrow&gt;
    ///     		&lt;mrow&gt;&lt;msub&gt;&lt;mi&gt;f&lt;/mi&gt;&lt;mn&gt;2&lt;/mn&gt;&lt;/msub&gt;
    ///     		&lt;/mrow&gt;
    ///     	&lt;/mfrac&gt;
    ///     &lt;/math&gt;
    ///     where &lt;math xmlns="http://www.w3.org/1998/Math/MathML" display="inline"&gt;&lt;msub&gt;&lt;mi&gt;m&lt;/mi&gt;&lt;mn&gt;1&lt;/mn&gt;&lt;/msub&gt; &lt;mo&gt;-&lt;/mo&gt; &lt;msub&gt;&lt;mi&gt;m&lt;/mi&gt;&lt;mn&gt;2&lt;/mn&gt;  &lt;/msub&gt;&lt;/math&gt; is the magnitude difference between two objects, and &lt;math xmlns="http://www.w3.org/1998/Math/MathML" display="inline"&gt;&lt;msub&gt;&lt;mi&gt;f&lt;/mi&gt;&lt;mn&gt;1&lt;/mn&gt;&lt;/msub&gt;&lt;/math&gt; and &lt;math xmlns="http://www.w3.org/1998/Math/MathML" display="inline"&gt;&lt;msub&gt;&lt;mi&gt;f&lt;/mi&gt;&lt;mn&gt;2&lt;/mn&gt;&lt;/msub&gt;&lt;/math&gt; are the luminous fluxes of the two objects. The magnitude of Vega (α Lyrae, HD 172167) is defined to be 0 in all wavelengths and passbands, although in practice this can only be an approximation. The zero point is now defined using multiple standard stars from the north polar sequence (non-variable stars within 2 degrees of the north celestial pole) or secondary standard stars from other parts of the sky. Please note that the scale is inverted, objects of magnitude 1 have a higher luminous flux than objects of magnitude 5. Stars of magnitude 6 are just visible to the naked eye under good observing conditions.
    ///     The units of magnitude, also called magnitude, are usually not indicated except when indicating small magnitude differences when milli- or micromagnitudes are used.^^rdf:XMLLiteral</para>
    ///   <para>oum:symbol : m^^xsd:string</para>
    ///   <para>rdfs:comment : Reverse logarithmic measure of the brightness of an object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Magnitude">oum:Magnitude</a>
    /// </summary>
    let Magnitude = _prefixId.prefix "Magnitude"
    /// <summary>
    ///   <para>oum:symbol : m_max^^xsd:string</para>
    ///   <para>rdfs:label : magnitude at maximum brightness</para>
    ///   <para>rdfs:comment : The magnitude at maximum brightness of a variable star.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagnitudeAtMaximumBrightness">oum:MagnitudeAtMaximumBrightness</a>
    /// </summary>
    let MagnitudeAtMaximumBrightness = _prefixId.prefix "MagnitudeAtMaximumBrightness"
    /// <summary>
    ///   <para>oum:symbol : m_min^^xsd:string</para>
    ///   <para>rdfs:label : magnitude at minimum brightness</para>
    ///   <para>rdfs:comment : The magnitude at minimum brightness of a variable star.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagnitudeAtMinimumBrightness">oum:MagnitudeAtMinimumBrightness</a>
    /// </summary>
    let MagnitudeAtMinimumBrightness = _prefixId.prefix "MagnitudeAtMinimumBrightness"
    /// <summary>
    ///   <para>rdfs:label : magnitude unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MagnitudeUnit">oum:MagnitudeUnit</a>
    /// </summary>
    let MagnitudeUnit = _prefixId.prefix "MagnitudeUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m</para>
    ///   <para>rdfs:label : manual firmnessrdfs:label : manuele stevigheid</para>
    ///   <para>rdfs:comment : Firmness manueel: code 0 - 5.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ManualFirmness">oum:ManualFirmness</a>
    /// </summary>
    let ManualFirmness = _prefixId.prefix "ManualFirmness"
    /// <summary>
    ///   <para>oum:unofficialLabel : weight^^xsd:string</para>
    ///   <para>rdfs:comment : Mass is the amount of matter of a phenomenon. It is a base quantity in the International System of Units. Mass is force divided by acceleration.</para>
    ///   <para>rdfs:label : 质量rdfs:label : massardfs:label : mass</para>
    ///   <para>oum:symbol : m^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Mass">oum:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>rdfs:label : mass flow</para>
    ///   <para>rdfs:comment : Mass flow is the movement of substances at equal rates or as a single body.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MassFlow">oum:MassFlow</a>
    /// </summary>
    let MassFlow = _prefixId.prefix "MassFlow"
    /// <summary>
    ///   <para>rdfs:label : mass flow unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MassFlowUnit">oum:MassFlowUnit</a>
    /// </summary>
    let MassFlowUnit = _prefixId.prefix "MassFlowUnit"
    /// <summary>
    ///   <para>oum:symbol : w^^xsd:string</para>
    ///   <para>oum:alternativeLabel : concentration (w/w)</para>
    ///   <para>rdfs:label : mass fractionrdfs:label : massafractie</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MassFraction">oum:MassFraction</a>
    /// </summary>
    let MassFraction = _prefixId.prefix "MassFraction"
    /// <summary>
    ///   <para>rdfs:label : mass fraction unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MassFractionUnit">oum:MassFractionUnit</a>
    /// </summary>
    let MassFractionUnit = _prefixId.prefix "MassFractionUnit"
    /// <summary>
    ///   <para>rdfs:label : mass unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MassUnit">oum:MassUnit</a>
    /// </summary>
    let MassUnit = _prefixId.prefix "MassUnit"
    /// <summary>
    ///   <para>rdfs:label : measure</para>
    ///   <para>rdfs:comment : A measure combines a number to a unit of measure. For example, "3 m" is a measure.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Measure">oum:Measure</a>
    /// </summary>
    let Measure = _prefixId.prefix "Measure"
    /// <summary>
    ///   <para>rdfs:label : metallicity</para>
    ///   <para>rdfs:comment : The log of the ratio between the ratios of the observed Fe and H quantities in a star and the same ratio in the Sun. This is a very important quantity that is often used in astronomy as an indicator of the age of a star.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Metallicity">oum:Metallicity</a>
    /// </summary>
    let Metallicity = _prefixId.prefix "Metallicity"
    /// <summary>
    ///   <para>rdfs:label : metre per prefixed second (time)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MetrePerPrefixedSecond-Time">oum:MetrePerPrefixedSecond-Time</a>
    /// </summary>
    let MetrePerPrefixedSecond_Time = _prefixId.prefix "MetrePerPrefixedSecond-Time"

    /// <summary>
    ///   <para>rdfs:label : metre per prefixed second (time) squared</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MetrePerPrefixedSecond-TimeSquared">oum:MetrePerPrefixedSecond-TimeSquared</a>
    /// </summary>
    let MetrePerPrefixedSecond_TimeSquared = _prefixId.prefix "MetrePerPrefixedSecond-TimeSquared"

    let MexicanPeso = _prefixId.prefix "MexicanPeso"
    /// <summary>
    ///   <para>rdfs:label : moderated starch mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of moderated starch in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ModeratedStarchMassFraction">oum:ModeratedStarchMassFraction</a>
    /// </summary>
    let ModeratedStarchMassFraction = _prefixId.prefix "ModeratedStarchMassFraction"
    /// <summary>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <para>oum:alternativeLabel : Young's modulus</para>
    ///   <para>rdfs:label : modulus of elasticityrdfs:label : elasticiteitsmodulus</para>
    ///   <para>oum:alternativeSymbol : Y^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ModulusOfElasticity">oum:ModulusOfElasticity</a>
    /// </summary>
    let ModulusOfElasticity = _prefixId.prefix "ModulusOfElasticity"
    /// <summary>
    ///   <para>rdfs:label : molalityrdfs:label : molaliteit</para>
    ///   <para>oum:symbol : b^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m^^xsd:string</para>
    ///   <para>rdfs:comment : Molality is the number of moles of solute per kilogram of solvent.</para>
    ///   <para>oum:alternativeLabel : molality of solution</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Molality">oum:Molality</a>
    /// </summary>
    let Molality = _prefixId.prefix "Molality"
    /// <summary>
    ///   <para>rdfs:label : molality unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolalityUnit">oum:MolalityUnit</a>
    /// </summary>
    let MolalityUnit = _prefixId.prefix "MolalityUnit"
    /// <summary>
    ///   <para>rdfs:label : molar energyrdfs:label : molaire energie</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarEnergy">oum:MolarEnergy</a>
    /// </summary>
    let MolarEnergy = _prefixId.prefix "MolarEnergy"
    /// <summary>
    ///   <para>rdfs:label : molar energy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarEnergyUnit">oum:MolarEnergyUnit</a>
    /// </summary>
    let MolarEnergyUnit = _prefixId.prefix "MolarEnergyUnit"
    /// <summary>
    ///   <para>rdfs:label : molar entropyrdfs:label : molaire entropie</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarEntropy">oum:MolarEntropy</a>
    /// </summary>
    let MolarEntropy = _prefixId.prefix "MolarEntropy"
    /// <summary>
    ///   <para>rdfs:label : molar entropy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarEntropyUnit">oum:MolarEntropyUnit</a>
    /// </summary>
    let MolarEntropyUnit = _prefixId.prefix "MolarEntropyUnit"
    /// <summary>
    ///   <para>rdfs:label : molar heat capacityrdfs:label : molaire warmtecapaciteit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarHeatCapacity">oum:MolarHeatCapacity</a>
    /// </summary>
    let MolarHeatCapacity = _prefixId.prefix "MolarHeatCapacity"
    /// <summary>
    ///   <para>rdfs:label : molar heat capacity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarHeatCapacityUnit">oum:MolarHeatCapacityUnit</a>
    /// </summary>
    let MolarHeatCapacityUnit = _prefixId.prefix "MolarHeatCapacityUnit"
    /// <summary>
    ///   <para>oum:symbol : M^^xsd:string</para>
    ///   <para>rdfs:label : molar massrdfs:label : molaire massa</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarMass">oum:MolarMass</a>
    /// </summary>
    let MolarMass = _prefixId.prefix "MolarMass"
    /// <summary>
    ///   <para>rdfs:label : molar mass unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarMassUnit">oum:MolarMassUnit</a>
    /// </summary>
    let MolarMassUnit = _prefixId.prefix "MolarMassUnit"
    /// <summary>
    ///   <para>oum:symbol : V_m^^xsd:string</para>
    ///   <para>rdfs:label : molar volumerdfs:label : molair volume</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarVolume">oum:MolarVolume</a>
    /// </summary>
    let MolarVolume = _prefixId.prefix "MolarVolume"
    /// <summary>
    ///   <para>rdfs:label : molar volume unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolarVolumeUnit">oum:MolarVolumeUnit</a>
    /// </summary>
    let MolarVolumeUnit = _prefixId.prefix "MolarVolumeUnit"
    /// <summary>
    ///   <para>rdfs:label : mole per prefixed litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolePerPrefixedLitre">oum:MolePerPrefixedLitre</a>
    /// </summary>
    let MolePerPrefixedLitre = _prefixId.prefix "MolePerPrefixedLitre"
    /// <summary>
    ///   <para>rdfs:label : mole per prefixed metre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MolePerPrefixedMetre">oum:MolePerPrefixedMetre</a>
    /// </summary>
    let MolePerPrefixedMetre = _prefixId.prefix "MolePerPrefixedMetre"
    /// <summary>
    ///   <para>oum:symbol : M^^xsd:string</para>
    ///   <para>rdfs:label : moment of force</para>
    ///   <para>oum:alternativeLabel : moment</para>
    ///   <para>rdfs:comment : Moment of force is the effectiveness of a force to produce rotation about an axis measured by the product of the force and the perpendicular distance from the line of action of the force to the axis.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MomentOfForce">oum:MomentOfForce</a>
    /// </summary>
    let MomentOfForce = _prefixId.prefix "MomentOfForce"
    /// <summary>
    ///   <para>rdfs:label : moment of force unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MomentOfForceUnit">oum:MomentOfForceUnit</a>
    /// </summary>
    let MomentOfForceUnit = _prefixId.prefix "MomentOfForceUnit"
    /// <summary>
    ///   <para>rdfs:label : traagheidsmomentrdfs:label : moment of inertia</para>
    ///   <para>rdfs:comment : Moment of inertia is a measure of the effectiveness of mass in rotation.</para>
    ///   <para>oum:symbol : I^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : J^^xsd:string</para>
    ///   <para>oum:alternativeLabel : massatraagheidsmoment</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MomentOfInertia">oum:MomentOfInertia</a>
    /// </summary>
    let MomentOfInertia = _prefixId.prefix "MomentOfInertia"
    /// <summary>
    ///   <para>rdfs:label : moment of inertia unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MomentOfInertiaUnit">oum:MomentOfInertiaUnit</a>
    /// </summary>
    let MomentOfInertiaUnit = _prefixId.prefix "MomentOfInertiaUnit"
    /// <summary>
    ///   <para>oum:symbol : p^^xsd:string</para>
    ///   <para>oum:alternativeLabel : linear momentum</para>
    ///   <para>rdfs:label : momentumrdfs:label : impuls</para>
    ///   <para>rdfs:comment : Momentum is the product of mass and velocity of an object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Momentum">oum:Momentum</a>
    /// </summary>
    let Momentum = _prefixId.prefix "Momentum"
    /// <summary>
    ///   <para>rdfs:label : momentum unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MomentumUnit">oum:MomentumUnit</a>
    /// </summary>
    let MomentumUnit = _prefixId.prefix "MomentumUnit"
    /// <summary>
    ///   <para>rdfs:label : mustard powder mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of mustard powder in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/MustardPowderMassFraction">oum:MustardPowderMassFraction</a>
    /// </summary>
    let MustardPowderMassFraction = _prefixId.prefix "MustardPowderMassFraction"
    /// <summary>
    ///   <para>oum:unofficialLabel : neck ring weight^^xsd:string</para>
    ///   <para>rdfs:label : neck ring mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NeckRingMass">oum:NeckRingMass</a>
    /// </summary>
    let NeckRingMass = _prefixId.prefix "NeckRingMass"
    let NewZealandDollar = _prefixId.prefix "NewZealandDollar"
    /// <summary>
    ///   <para>oum:symbol : NEP^^xsd:string</para>
    ///   <para>rdfs:label : noise equivalent power</para>
    ///   <para>rdfs:comment : Radiative flux on a detector needed for a signal/noise ratio of 1 (Kitchin, Astrophysical Techniques, IoP, Table 1.1.2).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NoiseEquivalentPower">oum:NoiseEquivalentPower</a>
    /// </summary>
    let NoiseEquivalentPower = _prefixId.prefix "NoiseEquivalentPower"
    /// <summary>
    ///   <para>rdfs:label : normal albedo</para>
    ///   <para>rdfs:comment : Ratio between radiation falling vertically onto an object and the radiation radiated back vertically.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NormalAlbedo">oum:NormalAlbedo</a>
    /// </summary>
    let NormalAlbedo = _prefixId.prefix "NormalAlbedo"
    /// <summary>
    ///   <para>rdfs:label : normal strainrdfs:label : normaalvervorming</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NormalStrain">oum:NormalStrain</a>
    /// </summary>
    let NormalStrain = _prefixId.prefix "NormalStrain"
    /// <summary>
    ///   <para>rdfs:label : normal stressrdfs:label : normaalspanning</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NormalStress">oum:NormalStress</a>
    /// </summary>
    let NormalStress = _prefixId.prefix "NormalStress"
    /// <summary>
    ///   <para>oum:symbol : D*^^xsd:string</para>
    ///   <para>rdfs:label : normalised detectivity</para>
    ///   <para>rdfs:comment : The detectivity normalised by multiplying by the square root of the detector area, and by the electrical bandwidth. The units cm Hz(1/2)/W are commonly used and it then represents the signal-to-noise ratio when 1 W of radiation is incident on a detector with an area of 1 cm2, and the electrical bandwidth is 1 Hz.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NormalisedDetectivity">oum:NormalisedDetectivity</a>
    /// </summary>
    let NormalisedDetectivity = _prefixId.prefix "NormalisedDetectivity"
    let NorwegianKrone = _prefixId.prefix "NorwegianKrone"
    /// <summary>
    ///   <para>oum:unofficialAbbreviation : no^^xsd:stringoum:unofficialAbbreviation : nr^^xsd:stringoum:unofficialAbbreviation : #^^xsd:string</para>
    ///   <para>rdfs:label : number</para>
    ///   <para>oum:symbol : N^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Number">oum:Number</a>
    /// </summary>
    let Number = _prefixId.prefix "Number"
    /// <summary>
    ///   <para>oum:alternativeLabel : #abscised buds</para>
    ///   <para>rdfs:label : number abscised budsrdfs:label : aantal gevallen knoppen</para>
    ///   <para>rdfs:comment : Aantal gevallen knoppen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberAbscisedBuds">oum:NumberAbscisedBuds</a>
    /// </summary>
    let NumberAbscisedBuds = _prefixId.prefix "NumberAbscisedBuds"
    /// <summary>
    ///   <para>oum:alternativeLabel : #abscised flowers</para>
    ///   <para>rdfs:label : number abscised flowersrdfs:label : aantal gevallen bloemen</para>
    ///   <para>rdfs:comment : Aantal gevallen bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberAbscisedFlowers">oum:NumberAbscisedFlowers</a>
    /// </summary>
    let NumberAbscisedFlowers = _prefixId.prefix "NumberAbscisedFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : #abscised leaves</para>
    ///   <para>rdfs:label : number abscised leavesrdfs:label : aantal gevallen bladeren</para>
    ///   <para>rdfs:comment : Aantal gevallen bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberAbscisedLeaves">oum:NumberAbscisedLeaves</a>
    /// </summary>
    let NumberAbscisedLeaves = _prefixId.prefix "NumberAbscisedLeaves"
    /// <summary>
    ///   <para>oum:alternativeLabel : #blue flowers</para>
    ///   <para>rdfs:label : number blue-discolored flowersrdfs:label : aantal blauwverkleurde bloemen</para>
    ///   <para>rdfs:comment : Aantal blauwverkleurde bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBlue-DiscoloredFlowers">oum:NumberBlue-DiscoloredFlowers</a>
    /// </summary>
    let NumberBlue_DiscoloredFlowers = _prefixId.prefix "NumberBlue-DiscoloredFlowers"
    /// <summary>
    ///   <para>rdfs:label : number Botrytisrdfs:label : aantal Botrytis</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBotrytis">oum:NumberBotrytis</a>
    /// </summary>
    let NumberBotrytis = _prefixId.prefix "NumberBotrytis"
    /// <summary>
    ///   <para>oum:alternativeLabel : b0</para>
    ///   <para>rdfs:label : number Botrytis 0rdfs:label : aantal Botrytis 0</para>
    ///   <para>rdfs:comment : Aantal bloemen zonder Botrytis.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBotrytis0">oum:NumberBotrytis0</a>
    /// </summary>
    let NumberBotrytis0 = _prefixId.prefix "NumberBotrytis0"
    /// <summary>
    ///   <para>oum:alternativeLabel : b1</para>
    ///   <para>rdfs:label : number Botrytis 1rdfs:label : aantal Botrytis 1</para>
    ///   <para>rdfs:comment : Aantal bloemen met Botrytis 1: enkele laesies: max 3 op één petaal of max 5 op meerdere plekken.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBotrytis1">oum:NumberBotrytis1</a>
    /// </summary>
    let NumberBotrytis1 = _prefixId.prefix "NumberBotrytis1"
    /// <summary>
    ///   <para>oum:alternativeLabel : b2</para>
    ///   <para>rdfs:label : number Botrytis 2rdfs:label : aantal Botrytis 2</para>
    ///   <para>rdfs:comment : Aantal bloemen met Botrytis 2: grotere vlek(ken) op één petaal.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBotrytis2">oum:NumberBotrytis2</a>
    /// </summary>
    let NumberBotrytis2 = _prefixId.prefix "NumberBotrytis2"
    /// <summary>
    ///   <para>oum:alternativeLabel : b3</para>
    ///   <para>rdfs:label : number Botrytis 3rdfs:label : aantal Botrytis 3</para>
    ///   <para>rdfs:comment : Aantal bloemen met Botrytis 3: één bruin petaal of vlekken op meer petalen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBotrytis3">oum:NumberBotrytis3</a>
    /// </summary>
    let NumberBotrytis3 = _prefixId.prefix "NumberBotrytis3"
    /// <summary>
    ///   <para>oum:alternativeLabel : b4</para>
    ///   <para>rdfs:label : number Botrytis 4rdfs:label : aantal Botrytis 4</para>
    ///   <para>rdfs:comment : Aantal bloemen met Botrytis 4: minimaal één bruin petaal en hart aangetast.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBotrytis4">oum:NumberBotrytis4</a>
    /// </summary>
    let NumberBotrytis4 = _prefixId.prefix "NumberBotrytis4"
    /// <summary>
    ///   <para>rdfs:label : number bud stadiumrdfs:label : aantal knopstadium</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBudStadium">oum:NumberBudStadium</a>
    /// </summary>
    let NumberBudStadium = _prefixId.prefix "NumberBudStadium"
    /// <summary>
    ///   <para>oum:alternativeLabel : s1</para>
    ///   <para>rdfs:label : number bud stadium 1rdfs:label : aantal knopstadium 1</para>
    ///   <para>rdfs:comment : Roos aantal in knopstadium 1: spitse knop.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBudStadium1">oum:NumberBudStadium1</a>
    /// </summary>
    let NumberBudStadium1 = _prefixId.prefix "NumberBudStadium1"
    /// <summary>
    ///   <para>oum:alternativeLabel : s2</para>
    ///   <para>rdfs:label : number bud stadium 2rdfs:label : aantal knopstadium 2</para>
    ///   <para>rdfs:comment : Roos aantal in knopstadium 2: spitse knop.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBudStadium2">oum:NumberBudStadium2</a>
    /// </summary>
    let NumberBudStadium2 = _prefixId.prefix "NumberBudStadium2"
    /// <summary>
    ///   <para>oum:alternativeLabel : s3</para>
    ///   <para>rdfs:label : number bud stadium 3rdfs:label : aantal knopstadium 3</para>
    ///   <para>rdfs:comment : Roos aantal in knopstadium 3: spitse knop.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBudStadium3">oum:NumberBudStadium3</a>
    /// </summary>
    let NumberBudStadium3 = _prefixId.prefix "NumberBudStadium3"
    /// <summary>
    ///   <para>oum:alternativeLabel : s4</para>
    ///   <para>rdfs:label : number bud stadium 4rdfs:label : aantal knopstadium 4</para>
    ///   <para>rdfs:comment : Roos aantal in knopstadium 4: spitse knop.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBudStadium4">oum:NumberBudStadium4</a>
    /// </summary>
    let NumberBudStadium4 = _prefixId.prefix "NumberBudStadium4"
    /// <summary>
    ///   <para>oum:alternativeLabel : s5</para>
    ///   <para>rdfs:label : number bud stadium 5rdfs:label : aantal knopstadium 5</para>
    ///   <para>rdfs:comment : Roos aantal in knopstadium 5: spitse knop.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBudStadium5">oum:NumberBudStadium5</a>
    /// </summary>
    let NumberBudStadium5 = _prefixId.prefix "NumberBudStadium5"
    /// <summary>
    ///   <para>rdfs:label : number budsrdfs:label : aantal knoppen</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberBuds">oum:NumberBuds</a>
    /// </summary>
    let NumberBuds = _prefixId.prefix "NumberBuds"
    /// <summary>
    ///   <para>rdfs:label : number colorrdfs:label : aantal kleur</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberColor">oum:NumberColor</a>
    /// </summary>
    let NumberColor = _prefixId.prefix "NumberColor"
    /// <summary>
    ///   <para>oum:alternativeLabel : color_1</para>
    ///   <para>rdfs:label : number color 1rdfs:label : aantal kleur 1</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 1 poster (vrijwel) geheel groen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberColor1">oum:NumberColor1</a>
    /// </summary>
    let NumberColor1 = _prefixId.prefix "NumberColor1"
    /// <summary>
    ///   <para>oum:alternativeLabel : color_2</para>
    ///   <para>rdfs:label : number color 2rdfs:label : aantal kleur 2</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 2 poster meer groen dan donker.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberColor2">oum:NumberColor2</a>
    /// </summary>
    let NumberColor2 = _prefixId.prefix "NumberColor2"
    /// <summary>
    ///   <para>oum:alternativeLabel : color_3</para>
    ///   <para>rdfs:label : number color 3rdfs:label : aantal kleur 3</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 3 poster 50% groen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberColor3">oum:NumberColor3</a>
    /// </summary>
    let NumberColor3 = _prefixId.prefix "NumberColor3"
    /// <summary>
    ///   <para>oum:alternativeLabel : color_4</para>
    ///   <para>rdfs:label : number color 4rdfs:label : aantal kleur 4</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 4 poster meer donker dan groen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberColor4">oum:NumberColor4</a>
    /// </summary>
    let NumberColor4 = _prefixId.prefix "NumberColor4"
    /// <summary>
    ///   <para>oum:alternativeLabel : color_5</para>
    ///   <para>rdfs:label : number color 5rdfs:label : aantal kleur 5</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 5 poster (vrijwel) geheel donker.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberColor5">oum:NumberColor5</a>
    /// </summary>
    let NumberColor5 = _prefixId.prefix "NumberColor5"
    /// <summary>
    ///   <para>oum:symbol : n^^xsd:string</para>
    ///   <para>rdfs:label : number density</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberDensity">oum:NumberDensity</a>
    /// </summary>
    let NumberDensity = _prefixId.prefix "NumberDensity"
    /// <summary>
    ///   <para>rdfs:label : number density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberDensityUnit">oum:NumberDensityUnit</a>
    /// </summary>
    let NumberDensityUnit = _prefixId.prefix "NumberDensityUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : #dry buds</para>
    ///   <para>rdfs:label : number dry budsrdfs:label : aantal verdroogde knoppen</para>
    ///   <para>rdfs:comment : Aantal verdroogde knoppen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberDryBuds">oum:NumberDryBuds</a>
    /// </summary>
    let NumberDryBuds = _prefixId.prefix "NumberDryBuds"
    /// <summary>
    ///   <para>oum:alternativeLabel : #dry flowers</para>
    ///   <para>rdfs:label : number dry flowersrdfs:label : aantal verdroogde bloemen</para>
    ///   <para>rdfs:comment : Aantal verdroogde bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberDryFlowers">oum:NumberDryFlowers</a>
    /// </summary>
    let NumberDryFlowers = _prefixId.prefix "NumberDryFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : #dry leaves</para>
    ///   <para>rdfs:label : number dry leavesrdfs:label : aantal verdroogde bladeren</para>
    ///   <para>rdfs:comment : Aantal verdroogde bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberDryLeaves">oum:NumberDryLeaves</a>
    /// </summary>
    let NumberDryLeaves = _prefixId.prefix "NumberDryLeaves"
    /// <summary>
    ///   <para>rdfs:label : number external browning</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberExternalBrowning">oum:NumberExternalBrowning</a>
    /// </summary>
    let NumberExternalBrowning = _prefixId.prefix "NumberExternalBrowning"
    /// <summary>
    ///   <para>oum:alternativeLabel : ext_brown_1</para>
    ///   <para>rdfs:label : number external browning 1</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 1 poster.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberExternalBrowning1">oum:NumberExternalBrowning1</a>
    /// </summary>
    let NumberExternalBrowning1 = _prefixId.prefix "NumberExternalBrowning1"
    /// <summary>
    ///   <para>oum:alternativeLabel : ext_brown_2</para>
    ///   <para>rdfs:label : number external browning 2</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 2 poster.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberExternalBrowning2">oum:NumberExternalBrowning2</a>
    /// </summary>
    let NumberExternalBrowning2 = _prefixId.prefix "NumberExternalBrowning2"
    /// <summary>
    ///   <para>oum:alternativeLabel : ext_brown_3</para>
    ///   <para>rdfs:label : number external browning 3</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 3 poster.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberExternalBrowning3">oum:NumberExternalBrowning3</a>
    /// </summary>
    let NumberExternalBrowning3 = _prefixId.prefix "NumberExternalBrowning3"
    /// <summary>
    ///   <para>oum:alternativeLabel : ext_brown_4</para>
    ///   <para>rdfs:label : number external browning 4</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 4 poster.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberExternalBrowning4">oum:NumberExternalBrowning4</a>
    /// </summary>
    let NumberExternalBrowning4 = _prefixId.prefix "NumberExternalBrowning4"
    /// <summary>
    ///   <para>oum:alternativeLabel : ext_brown_5</para>
    ///   <para>rdfs:label : number external browning 5</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 5 poster.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberExternalBrowning5">oum:NumberExternalBrowning5</a>
    /// </summary>
    let NumberExternalBrowning5 = _prefixId.prefix "NumberExternalBrowning5"
    /// <summary>
    ///   <para>rdfs:label : number flowersrdfs:label : aantal bloemen</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberFlowers">oum:NumberFlowers</a>
    /// </summary>
    let NumberFlowers = _prefixId.prefix "NumberFlowers"
    /// <summary>
    ///   <para>rdfs:label : number leavesrdfs:label : aantal bladeren</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberLeaves">oum:NumberLeaves</a>
    /// </summary>
    let NumberLeaves = _prefixId.prefix "NumberLeaves"
    /// <summary>
    ///   <para>oum:alternativeLabel : #malformed buds</para>
    ///   <para>rdfs:label : number malformed budsrdfs:label : aantal misvormde knoppen</para>
    ///   <para>rdfs:comment : Aantal misvormde knoppen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberMalformedBuds">oum:NumberMalformedBuds</a>
    /// </summary>
    let NumberMalformedBuds = _prefixId.prefix "NumberMalformedBuds"
    /// <summary>
    ///   <para>oum:alternativeLabel : #malformed flowers</para>
    ///   <para>rdfs:label : number malformed flowersrdfs:label : aantal misvormde bloemen</para>
    ///   <para>rdfs:comment : Aantal misvormde bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberMalformedFlowers">oum:NumberMalformedFlowers</a>
    /// </summary>
    let NumberMalformedFlowers = _prefixId.prefix "NumberMalformedFlowers"
    /// <summary>
    ///   <para>rdfs:label : number manual firmnessrdfs:label : aantal manuele stevigheid</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness">oum:NumberManualFirmness</a>
    /// </summary>
    let NumberManualFirmness = _prefixId.prefix "NumberManualFirmness"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_0</para>
    ///   <para>rdfs:label : number manual firmness 0rdfs:label : aantal manuele stevigheid 0</para>
    ///   <para>rdfs:comment : Firmness manueel: 0 = steenhard.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness0">oum:NumberManualFirmness0</a>
    /// </summary>
    let NumberManualFirmness0 = _prefixId.prefix "NumberManualFirmness0"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_0.5</para>
    ///   <para>rdfs:label : number manual firmness 0.5rdfs:label : aantal manuele stevigheid 0.5</para>
    ///   <para>rdfs:comment : Firmness manueel: 0.5 = hard.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness0.5">oum:NumberManualFirmness0.5</a>
    /// </summary>
    let NumberManualFirmness0'_period_'5 = _prefixId.prefix "NumberManualFirmness0.5"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_1</para>
    ///   <para>rdfs:label : number manual firmness 1rdfs:label : aantal manuele stevigheid 1</para>
    ///   <para>rdfs:comment : Firmness manueel: 1 = zeer stevig.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness1">oum:NumberManualFirmness1</a>
    /// </summary>
    let NumberManualFirmness1 = _prefixId.prefix "NumberManualFirmness1"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_1.5</para>
    ///   <para>rdfs:label : number manual firmness 1.5rdfs:label : aantal manuele stevigheid 1.5</para>
    ///   <para>rdfs:comment : Firmness manueel: 1.5 = stevig.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness1.5">oum:NumberManualFirmness1.5</a>
    /// </summary>
    let NumberManualFirmness1'_period_'5 = _prefixId.prefix "NumberManualFirmness1.5"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_2</para>
    ///   <para>rdfs:label : number manual firmness 2rdfs:label : aantal manuele stevigheid 2</para>
    ///   <para>rdfs:comment : Firmness manueel: 2 = halfzacht.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness2">oum:NumberManualFirmness2</a>
    /// </summary>
    let NumberManualFirmness2 = _prefixId.prefix "NumberManualFirmness2"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_2.5</para>
    ///   <para>rdfs:label : number manual firmness 2.5rdfs:label : aantal manuele stevigheid 2.5</para>
    ///   <para>rdfs:comment : Firmness manueel: 2.5 = eetrijp.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness2.5">oum:NumberManualFirmness2.5</a>
    /// </summary>
    let NumberManualFirmness2'_period_'5 = _prefixId.prefix "NumberManualFirmness2.5"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_3</para>
    ///   <para>rdfs:label : number manual firmness 3rdfs:label : aantal manuele stevigheid 3</para>
    ///   <para>rdfs:comment : Firmness manueel: 3 = zacht.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness3">oum:NumberManualFirmness3</a>
    /// </summary>
    let NumberManualFirmness3 = _prefixId.prefix "NumberManualFirmness3"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_3.5</para>
    ///   <para>rdfs:label : number manual firmness 3.5rdfs:label : aantal manuele stevigheid 3.5</para>
    ///   <para>rdfs:comment : Firmness manueel: 3.5 = te zacht.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness3.5">oum:NumberManualFirmness3.5</a>
    /// </summary>
    let NumberManualFirmness3'_period_'5 = _prefixId.prefix "NumberManualFirmness3.5"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_4</para>
    ///   <para>rdfs:label : number manual firmness 4rdfs:label : aantal manuele stevigheid 4</para>
    ///   <para>rdfs:comment : Firmness manueel: 4 = week.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness4">oum:NumberManualFirmness4</a>
    /// </summary>
    let NumberManualFirmness4 = _prefixId.prefix "NumberManualFirmness4"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_4.5</para>
    ///   <para>rdfs:label : number manual firmness 4.5rdfs:label : aantal manuele stevigheid 4.5</para>
    ///   <para>rdfs:comment : Firmness manueel: 4.5 = vies.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness4.5">oum:NumberManualFirmness4.5</a>
    /// </summary>
    let NumberManualFirmness4'_period_'5 = _prefixId.prefix "NumberManualFirmness4.5"
    /// <summary>
    ///   <para>oum:alternativeLabel : firmness_m_5</para>
    ///   <para>rdfs:label : number manual firmness 5rdfs:label : aantal manuele stevigheid 5</para>
    ///   <para>rdfs:comment : Firmness manueel: 5 = zeer vies.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberManualFirmness5">oum:NumberManualFirmness5</a>
    /// </summary>
    let NumberManualFirmness5 = _prefixId.prefix "NumberManualFirmness5"
    /// <summary>
    ///   <para>oum:alternativeLabel : #nonturgid flowers</para>
    ///   <para>rdfs:label : number nonturgid flowersrdfs:label : aantal slappe bloemen</para>
    ///   <para>rdfs:comment : Aantal slappe bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberNonturgidFlowers">oum:NumberNonturgidFlowers</a>
    /// </summary>
    let NumberNonturgidFlowers = _prefixId.prefix "NumberNonturgidFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : #nonturgid leaves</para>
    ///   <para>rdfs:label : number nonturgid leavesrdfs:label : aantal slappe bladeren</para>
    ///   <para>rdfs:comment : Aantal slappe bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberNonturgidLeaves">oum:NumberNonturgidLeaves</a>
    /// </summary>
    let NumberNonturgidLeaves = _prefixId.prefix "NumberNonturgidLeaves"
    /// <summary>
    ///   <para>rdfs:label : number pulp browning</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberPulpBrowning">oum:NumberPulpBrowning</a>
    /// </summary>
    let NumberPulpBrowning = _prefixId.prefix "NumberPulpBrowning"
    /// <summary>
    ///   <para>oum:alternativeLabel : pulp_1</para>
    ///   <para>rdfs:label : number pulp browning 1</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 1 poster pulp browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberPulpBrowning1">oum:NumberPulpBrowning1</a>
    /// </summary>
    let NumberPulpBrowning1 = _prefixId.prefix "NumberPulpBrowning1"
    /// <summary>
    ///   <para>oum:alternativeLabel : pulp_2</para>
    ///   <para>rdfs:label : number pulp browning 2</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 2 poster pulp browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberPulpBrowning2">oum:NumberPulpBrowning2</a>
    /// </summary>
    let NumberPulpBrowning2 = _prefixId.prefix "NumberPulpBrowning2"
    /// <summary>
    ///   <para>oum:alternativeLabel : pulp_3</para>
    ///   <para>rdfs:label : number pulp browning 3</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 3 poster pulp browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberPulpBrowning3">oum:NumberPulpBrowning3</a>
    /// </summary>
    let NumberPulpBrowning3 = _prefixId.prefix "NumberPulpBrowning3"
    /// <summary>
    ///   <para>oum:alternativeLabel : pulp_4</para>
    ///   <para>rdfs:label : number pulp browning 4</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 4 poster pulp browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberPulpBrowning4">oum:NumberPulpBrowning4</a>
    /// </summary>
    let NumberPulpBrowning4 = _prefixId.prefix "NumberPulpBrowning4"
    /// <summary>
    ///   <para>oum:alternativeLabel : pulp_5</para>
    ///   <para>rdfs:label : number pulp browning 5</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 5 poster pulp browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberPulpBrowning5">oum:NumberPulpBrowning5</a>
    /// </summary>
    let NumberPulpBrowning5 = _prefixId.prefix "NumberPulpBrowning5"
    /// <summary>
    ///   <para>oum:alternativeLabel : #rotten flowers</para>
    ///   <para>rdfs:label : number rotten flowersrdfs:label : aantal rotte bloemen</para>
    ///   <para>rdfs:comment : Aantal rotte bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberRottenFlowers">oum:NumberRottenFlowers</a>
    /// </summary>
    let NumberRottenFlowers = _prefixId.prefix "NumberRottenFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : #rotten leaves</para>
    ///   <para>rdfs:label : number rotten leavesrdfs:label : aantal rotte bladeren</para>
    ///   <para>rdfs:comment : Aantal rotte bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberRottenLeaves">oum:NumberRottenLeaves</a>
    /// </summary>
    let NumberRottenLeaves = _prefixId.prefix "NumberRottenLeaves"
    /// <summary>
    ///   <para>rdfs:label : number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberUnit">oum:NumberUnit</a>
    /// </summary>
    let NumberUnit = _prefixId.prefix "NumberUnit"
    /// <summary>
    ///   <para>rdfs:label : number vascular browning</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberVascularBrowning">oum:NumberVascularBrowning</a>
    /// </summary>
    let NumberVascularBrowning = _prefixId.prefix "NumberVascularBrowning"
    /// <summary>
    ///   <para>oum:alternativeLabel : vascular_1</para>
    ///   <para>rdfs:label : number vascular browning 1</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 1 poster vascular browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberVascularBrowning1">oum:NumberVascularBrowning1</a>
    /// </summary>
    let NumberVascularBrowning1 = _prefixId.prefix "NumberVascularBrowning1"
    /// <summary>
    ///   <para>oum:alternativeLabel : vascular_2</para>
    ///   <para>rdfs:label : number vascular browning 2</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 2 poster vascular browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberVascularBrowning2">oum:NumberVascularBrowning2</a>
    /// </summary>
    let NumberVascularBrowning2 = _prefixId.prefix "NumberVascularBrowning2"
    /// <summary>
    ///   <para>oum:alternativeLabel : vascular_3</para>
    ///   <para>rdfs:label : number vascular browning 3</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 3 poster vascular browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberVascularBrowning3">oum:NumberVascularBrowning3</a>
    /// </summary>
    let NumberVascularBrowning3 = _prefixId.prefix "NumberVascularBrowning3"
    /// <summary>
    ///   <para>oum:alternativeLabel : vascular_4</para>
    ///   <para>rdfs:label : number vascular browning 4</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 4 poster vascular browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberVascularBrowning4">oum:NumberVascularBrowning4</a>
    /// </summary>
    let NumberVascularBrowning4 = _prefixId.prefix "NumberVascularBrowning4"
    /// <summary>
    ///   <para>oum:alternativeLabel : vascular_5</para>
    ///   <para>rdfs:label : number vascular browning 5</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: code 5 poster vascular browning.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberVascularBrowning5">oum:NumberVascularBrowning5</a>
    /// </summary>
    let NumberVascularBrowning5 = _prefixId.prefix "NumberVascularBrowning5"
    /// <summary>
    ///   <para>oum:alternativeLabel : #wilted flowers</para>
    ///   <para>rdfs:label : number wilted flowersrdfs:label : aantal verwelkte bloemen</para>
    ///   <para>rdfs:comment : Aantal verwelkte bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberWiltedFlowers">oum:NumberWiltedFlowers</a>
    /// </summary>
    let NumberWiltedFlowers = _prefixId.prefix "NumberWiltedFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : #wilted leaves</para>
    ///   <para>rdfs:label : number wilted leavesrdfs:label : aantal verwelkte bladeren</para>
    ///   <para>rdfs:comment : Aantal verwelkte bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberWiltedLeaves">oum:NumberWiltedLeaves</a>
    /// </summary>
    let NumberWiltedLeaves = _prefixId.prefix "NumberWiltedLeaves"
    /// <summary>
    ///   <para>oum:alternativeLabel : #yellow leaves</para>
    ///   <para>rdfs:label : number yellow leavesrdfs:label : aantal vergeelde bladeren</para>
    ///   <para>rdfs:comment : Aantal yellow bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NumberYellowLeaves">oum:NumberYellowLeaves</a>
    /// </summary>
    let NumberYellowLeaves = _prefixId.prefix "NumberYellowLeaves"
    /// <summary>
    ///   <para>oum:symbol : Nu^^xsd:string</para>
    ///   <para>rdfs:label : Nusselt numberrdfs:label : getal van Nusselt</para>
    ///   <para>rdfs:comment : The Nusselt number is the ratio of convective to conductive heat transfer across (normal to) the boundary.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NusseltNumber">oum:NusseltNumber</a>
    /// </summary>
    let NusseltNumber = _prefixId.prefix "NusseltNumber"
    /// <summary>
    ///   <para>oum:symbol : Nu*^^xsd:string</para>
    ///   <para>rdfs:label : Nusselt number for mass transfer</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NusseltNumberForMassTransfer">oum:NusseltNumberForMassTransfer</a>
    /// </summary>
    let NusseltNumberForMassTransfer = _prefixId.prefix "NusseltNumberForMassTransfer"

    /// <summary>
    ///   <para>rdfs:label : Nusselt number for mass transfer unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NusseltNumberForMassTransferUnit">oum:NusseltNumberForMassTransferUnit</a>
    /// </summary>
    let NusseltNumberForMassTransferUnit = _prefixId.prefix "NusseltNumberForMassTransferUnit"

    /// <summary>
    ///   <para>rdfs:label : Nusselt number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/NusseltNumberUnit">oum:NusseltNumberUnit</a>
    /// </summary>
    let NusseltNumberUnit = _prefixId.prefix "NusseltNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : organ dose equivalent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/OrganDoseEquivalent">oum:OrganDoseEquivalent</a>
    /// </summary>
    let OrganDoseEquivalent = _prefixId.prefix "OrganDoseEquivalent"
    /// <summary>
    ///   <para>rdfs:label : overrun</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Overrun">oum:Overrun</a>
    /// </summary>
    let Overrun = _prefixId.prefix "Overrun"
    /// <summary>
    ///   <para>rdfs:comment : Wavelength for which the detectivity is at a maximum.</para>
    ///   <para>oum:symbol : λ_m^^xsd:string</para>
    ///   <para>rdfs:label : peak wavelength</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PeakWavelength">oum:PeakWavelength</a>
    /// </summary>
    let PeakWavelength = _prefixId.prefix "PeakWavelength"
    /// <summary>
    ///   <para>oum:symbol : Pe^^xsd:string</para>
    ///   <para>rdfs:label : Péclet numberrdfs:label : getal van Péclet</para>
    ///   <para>rdfs:comment : The Péclet number is a dimensionless number that relates the rate of advection of a flow to its rate of diffusion, often thermal diffusion.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PecletNumber">oum:PecletNumber</a>
    /// </summary>
    let PecletNumber = _prefixId.prefix "PecletNumber"
    /// <summary>
    ///   <para>oum:symbol : Pe*^^xsd:string</para>
    ///   <para>rdfs:label : Péclet number for mass transfer</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PecletNumberForMassTransfer">oum:PecletNumberForMassTransfer</a>
    /// </summary>
    let PecletNumberForMassTransfer = _prefixId.prefix "PecletNumberForMassTransfer"

    /// <summary>
    ///   <para>rdfs:label : Péclet number for mass transfer unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PecletNumberForMassTransferUnit">oum:PecletNumberForMassTransferUnit</a>
    /// </summary>
    let PecletNumberForMassTransferUnit = _prefixId.prefix "PecletNumberForMassTransferUnit"

    /// <summary>
    ///   <para>rdfs:label : Péclet number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PecletNumberUnit">oum:PecletNumberUnit</a>
    /// </summary>
    let PecletNumberUnit = _prefixId.prefix "PecletNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : percentage</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Percentage">oum:Percentage</a>
    /// </summary>
    let Percentage = _prefixId.prefix "Percentage"
    /// <summary>
    ///   <para>rdfs:label : percentage unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PercentageUnit">oum:PercentageUnit</a>
    /// </summary>
    let PercentageUnit = _prefixId.prefix "PercentageUnit"
    /// <summary>
    ///   <para>rdfs:label : periodrdfs:label : periode</para>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Period">oum:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : period of variability</para>
    ///   <para>rdfs:comment : The duration of one cycle in a (semi) periodical star.</para>
    ///   <para>oum:symbol : P^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PeriodOfVariability">oum:PeriodOfVariability</a>
    /// </summary>
    let PeriodOfVariability = _prefixId.prefix "PeriodOfVariability"
    /// <summary>
    ///   <para>oum:alternativeLabel : intrinsieke permeabiliteitoum:alternativeLabel : intrinsic permeability</para>
    ///   <para>rdfs:label : permeabiliteit (aardwetenschappen)rdfs:label : permeability (earth science)</para>
    ///   <para>oum:alternativeSymbol : k^^xsd:string</para>
    ///   <para>oum:symbol : κ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permeability-EarthScience">oum:Permeability-EarthScience</a>
    /// </summary>
    let Permeability_EarthScience = _prefixId.prefix "Permeability-EarthScience"
    /// <summary>
    ///   <para>rdfs:label : permeability (earth science) unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permeability-EarthScienceUnit">oum:Permeability-EarthScienceUnit</a>
    /// </summary>
    let Permeability_EarthScienceUnit = _prefixId.prefix "Permeability-EarthScienceUnit"
    /// <summary>
    ///   <para>oum:symbol : μ^^xsd:string</para>
    ///   <para>oum:alternativeLabel : vacuum permeability</para>
    ///   <para>rdfs:label : permeability of free space</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PermeabilityOfFreeSpace">oum:PermeabilityOfFreeSpace</a>
    /// </summary>
    let PermeabilityOfFreeSpace = _prefixId.prefix "PermeabilityOfFreeSpace"
    /// <summary>
    ///   <para>rdfs:label : permeability of free space unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PermeabilityOfFreeSpaceUnit">oum:PermeabilityOfFreeSpaceUnit</a>
    /// </summary>
    let PermeabilityOfFreeSpaceUnit = _prefixId.prefix "PermeabilityOfFreeSpaceUnit"
    /// <summary>
    ///   <para>rdfs:label : permeance (electromagnetic)</para>
    ///   <para>rdfs:comment : Electromagnetic permeance is a measure of flux for a number of current-turns in magnetic circuit.</para>
    ///   <para>oum:alternativeLabel : electromagnetic permeance</para>
    ///   <para>oum:symbol : Λ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permeance-Electromagnetic">oum:Permeance-Electromagnetic</a>
    /// </summary>
    let Permeance_Electromagnetic = _prefixId.prefix "Permeance-Electromagnetic"
    /// <summary>
    ///   <para>rdfs:label : permeance (electromagnetic) unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permeance-ElectromagneticUnit">oum:Permeance-ElectromagneticUnit</a>
    /// </summary>
    let Permeance_ElectromagneticUnit = _prefixId.prefix "Permeance-ElectromagneticUnit"
    /// <summary>
    ///   <para>rdfs:label : permeance (materials science)</para>
    ///   <para>rdfs:comment : Permeance is the degree to which a material transmits another substance.</para>
    ///   <para>oum:symbol : Λ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permeance-MaterialsScience">oum:Permeance-MaterialsScience</a>
    /// </summary>
    let Permeance_MaterialsScience = _prefixId.prefix "Permeance-MaterialsScience"

    /// <summary>
    ///   <para>rdfs:label : permeance (materials science) unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permeance-MaterialsScienceUnit">oum:Permeance-MaterialsScienceUnit</a>
    /// </summary>
    let Permeance_MaterialsScienceUnit = _prefixId.prefix "Permeance-MaterialsScienceUnit"

    /// <summary>
    ///   <para>oum:symbol : ε^^xsd:string</para>
    ///   <para>rdfs:label : permittivity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Permittivity">oum:Permittivity</a>
    /// </summary>
    let Permittivity = _prefixId.prefix "Permittivity"
    /// <summary>
    ///   <para>rdfs:label : permittivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PermittivityUnit">oum:PermittivityUnit</a>
    /// </summary>
    let PermittivityUnit = _prefixId.prefix "PermittivityUnit"
    /// <summary>
    ///   <para>rdfs:label : personal dose equivalent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PersonalDoseEquivalent">oum:PersonalDoseEquivalent</a>
    /// </summary>
    let PersonalDoseEquivalent = _prefixId.prefix "PersonalDoseEquivalent"
    /// <summary>
    ///   <para>oum:symbol : A_V^^xsd:string</para>
    ///   <para>rdfs:label : photographic amplitude</para>
    ///   <para>rdfs:comment : Amplitude of the light variation in photographic magnitude.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PhotographicAmplitude">oum:PhotographicAmplitude</a>
    /// </summary>
    let PhotographicAmplitude = _prefixId.prefix "PhotographicAmplitude"
    /// <summary>
    ///   <para>oum:symbol : m_photo^^xsd:string</para>
    ///   <para>rdfs:label : photographic magnitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PhotographicMagnitude">oum:PhotographicMagnitude</a>
    /// </summary>
    let PhotographicMagnitude = _prefixId.prefix "PhotographicMagnitude"

    /// <summary>
    ///   <para>oum:symbol : m_p,max^^xsd:string</para>
    ///   <para>rdfs:label : photographic magnitude at maximum brightness</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PhotographicMagnitudeAtMaximumBrightness">oum:PhotographicMagnitudeAtMaximumBrightness</a>
    /// </summary>
    let PhotographicMagnitudeAtMaximumBrightness = _prefixId.prefix "PhotographicMagnitudeAtMaximumBrightness"

    /// <summary>
    ///   <para>oum:symbol : m_p,min^^xsd:string</para>
    ///   <para>rdfs:label : photographic magnitude at minimum brightness</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PhotographicMagnitudeAtMinimumBrightness">oum:PhotographicMagnitudeAtMinimumBrightness</a>
    /// </summary>
    let PhotographicMagnitudeAtMinimumBrightness = _prefixId.prefix "PhotographicMagnitudeAtMinimumBrightness"

    /// <summary>
    ///   <para>rdfs:label : planetary aberration</para>
    ///   <para>rdfs:comment : The apparent angular displacement of the observed position of a celestial object produced by the motion of the observer and the actual motion of the observed object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PlanetaryAberration">oum:PlanetaryAberration</a>
    /// </summary>
    let PlanetaryAberration = _prefixId.prefix "PlanetaryAberration"
    /// <summary>
    ///   <para>rdfs:label : point</para>
    ///   <para>rdfs:comment : A point is an element of an interval scale or a ratio scale, for example, 273.16 on the Kelvin scale indicates the triple point of water thermodynamic temperature.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Point">oum:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : potassium sorbate mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of potassium sorbate in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PotassiumSorbateMassFraction">oum:PotassiumSorbateMassFraction</a>
    /// </summary>
    let PotassiumSorbateMassFraction = _prefixId.prefix "PotassiumSorbateMassFraction"
    /// <summary>
    ///   <para>rdfs:label : potential differencerdfs:label : potentiaalverschil</para>
    ///   <para>oum:alternativeSymbol : V^^xsd:string</para>
    ///   <para>oum:symbol : U^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PotentialDifference">oum:PotentialDifference</a>
    /// </summary>
    let PotentialDifference = _prefixId.prefix "PotentialDifference"
    /// <summary>
    ///   <para>oum:alternativeSymbol : V^^xsd:stringoum:alternativeSymbol : Φ^^xsd:stringoum:alternativeSymbol : U^^xsd:string</para>
    ///   <para>rdfs:label : 势能rdfs:label : potential energyrdfs:label : potentiële energie</para>
    ///   <para>oum:symbol : E_p^^xsd:string</para>
    ///   <para>rdfs:comment : Potential energy is energy due to position of one body with respect to another or to the relative parts of the same body.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PotentialEnergy">oum:PotentialEnergy</a>
    /// </summary>
    let PotentialEnergy = _prefixId.prefix "PotentialEnergy"
    /// <summary>
    ///   <para>rdfs:label : powerrdfs:label : 功率rdfs:label : vermogen</para>
    ///   <para>oum:symbol : P^^xsd:string</para>
    ///   <para>rdfs:comment : Power is the time rate at which work is done. It is a derived quantity in the International System of Units. Power is energy divided by time.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Power">oum:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:label : power density</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PowerDensity">oum:PowerDensity</a>
    /// </summary>
    let PowerDensity = _prefixId.prefix "PowerDensity"
    /// <summary>
    ///   <para>rdfs:label : power density unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PowerDensityUnit">oum:PowerDensityUnit</a>
    /// </summary>
    let PowerDensityUnit = _prefixId.prefix "PowerDensityUnit"
    /// <summary>
    ///   <para>rdfs:label : power unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PowerUnit">oum:PowerUnit</a>
    /// </summary>
    let PowerUnit = _prefixId.prefix "PowerUnit"
    /// <summary>
    ///   <para>oum:symbol : Pr^^xsd:string</para>
    ///   <para>rdfs:label : Prandtl numberrdfs:label : getal van Prandtl</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrandtlNumber">oum:PrandtlNumber</a>
    /// </summary>
    let PrandtlNumber = _prefixId.prefix "PrandtlNumber"
    /// <summary>
    ///   <para>rdfs:label : Prandtl number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrandtlNumberUnit">oum:PrandtlNumberUnit</a>
    /// </summary>
    let PrandtlNumberUnit = _prefixId.prefix "PrandtlNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : prefix</para>
    ///   <para>rdfs:comment : A prefix is a name that precedes a basic unit of measure to indicate a decimal or binary multiple or fraction of the unit. Each prefix has a unique symbol that is prepended to the unit symbol. For example, an electric current of 0.000 000 001 ampere is written by using the SI-prefix nano as 1 nanoampere or 1 nA.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Prefix">oum:Prefix</a>
    /// </summary>
    let Prefix = _prefixId.prefix "Prefix"
    /// <summary>
    ///   <para>rdfs:label : prefixed ampere</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedAmpere">oum:PrefixedAmpere</a>
    /// </summary>
    let PrefixedAmpere = _prefixId.prefix "PrefixedAmpere"
    /// <summary>
    ///   <para>rdfs:label : prefixed are</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedAre">oum:PrefixedAre</a>
    /// </summary>
    let PrefixedAre = _prefixId.prefix "PrefixedAre"
    /// <summary>
    ///   <para>rdfs:label : prefixed becquerel</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedBecquerel">oum:PrefixedBecquerel</a>
    /// </summary>
    let PrefixedBecquerel = _prefixId.prefix "PrefixedBecquerel"
    /// <summary>
    ///   <para>rdfs:label : prefixed bit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedBit">oum:PrefixedBit</a>
    /// </summary>
    let PrefixedBit = _prefixId.prefix "PrefixedBit"
    /// <summary>
    ///   <para>rdfs:label : prefixed byte</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedByte">oum:PrefixedByte</a>
    /// </summary>
    let PrefixedByte = _prefixId.prefix "PrefixedByte"
    /// <summary>
    ///   <para>rdfs:label : prefixed calorie (mean)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedCalorie-Mean">oum:PrefixedCalorie-Mean</a>
    /// </summary>
    let PrefixedCalorie_Mean = _prefixId.prefix "PrefixedCalorie-Mean"
    /// <summary>
    ///   <para>rdfs:label : prefixed candela</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedCandela">oum:PrefixedCandela</a>
    /// </summary>
    let PrefixedCandela = _prefixId.prefix "PrefixedCandela"
    /// <summary>
    ///   <para>rdfs:label : prefixed coulomb</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedCoulomb">oum:PrefixedCoulomb</a>
    /// </summary>
    let PrefixedCoulomb = _prefixId.prefix "PrefixedCoulomb"
    /// <summary>
    ///   <para>rdfs:label : prefixed degree Celsius</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedDegreeCelsius">oum:PrefixedDegreeCelsius</a>
    /// </summary>
    let PrefixedDegreeCelsius = _prefixId.prefix "PrefixedDegreeCelsius"
    /// <summary>
    ///   <para>rdfs:label : prefixed electronvolt</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedElectronvolt">oum:PrefixedElectronvolt</a>
    /// </summary>
    let PrefixedElectronvolt = _prefixId.prefix "PrefixedElectronvolt"
    /// <summary>
    ///   <para>rdfs:label : prefixed farad</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedFarad">oum:PrefixedFarad</a>
    /// </summary>
    let PrefixedFarad = _prefixId.prefix "PrefixedFarad"
    /// <summary>
    ///   <para>rdfs:label : prefixed gram</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedGram">oum:PrefixedGram</a>
    /// </summary>
    let PrefixedGram = _prefixId.prefix "PrefixedGram"
    /// <summary>
    ///   <para>rdfs:label : prefixed gram per litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedGramPerLitre">oum:PrefixedGramPerLitre</a>
    /// </summary>
    let PrefixedGramPerLitre = _prefixId.prefix "PrefixedGramPerLitre"
    /// <summary>
    ///   <para>rdfs:label : prefixed gram per prefixed litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedGramPerPrefixedLitre">oum:PrefixedGramPerPrefixedLitre</a>
    /// </summary>
    let PrefixedGramPerPrefixedLitre = _prefixId.prefix "PrefixedGramPerPrefixedLitre"
    /// <summary>
    ///   <para>rdfs:label : prefixed gray</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedGray">oum:PrefixedGray</a>
    /// </summary>
    let PrefixedGray = _prefixId.prefix "PrefixedGray"
    /// <summary>
    ///   <para>rdfs:label : prefixed henry</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedHenry">oum:PrefixedHenry</a>
    /// </summary>
    let PrefixedHenry = _prefixId.prefix "PrefixedHenry"
    /// <summary>
    ///   <para>rdfs:label : prefixed hertz</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedHertz">oum:PrefixedHertz</a>
    /// </summary>
    let PrefixedHertz = _prefixId.prefix "PrefixedHertz"
    /// <summary>
    ///   <para>rdfs:label : prefixed joule</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedJoule">oum:PrefixedJoule</a>
    /// </summary>
    let PrefixedJoule = _prefixId.prefix "PrefixedJoule"
    /// <summary>
    ///   <para>rdfs:label : prefixed katal</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedKatal">oum:PrefixedKatal</a>
    /// </summary>
    let PrefixedKatal = _prefixId.prefix "PrefixedKatal"
    /// <summary>
    ///   <para>rdfs:label : prefixed kelvin</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedKelvin">oum:PrefixedKelvin</a>
    /// </summary>
    let PrefixedKelvin = _prefixId.prefix "PrefixedKelvin"
    /// <summary>
    ///   <para>rdfs:label : prefixed litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedLitre">oum:PrefixedLitre</a>
    /// </summary>
    let PrefixedLitre = _prefixId.prefix "PrefixedLitre"
    /// <summary>
    ///   <para>rdfs:label : prefixed lumen</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedLumen">oum:PrefixedLumen</a>
    /// </summary>
    let PrefixedLumen = _prefixId.prefix "PrefixedLumen"
    /// <summary>
    ///   <para>rdfs:label : prefixed lux</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedLux">oum:PrefixedLux</a>
    /// </summary>
    let PrefixedLux = _prefixId.prefix "PrefixedLux"
    /// <summary>
    ///   <para>rdfs:label : prefixed metre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMetre">oum:PrefixedMetre</a>
    /// </summary>
    let PrefixedMetre = _prefixId.prefix "PrefixedMetre"

    /// <summary>
    ///   <para>rdfs:label : prefixed metre per prefixed second (time)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMetrePerPrefixedSecond-Time">oum:PrefixedMetrePerPrefixedSecond-Time</a>
    /// </summary>
    let PrefixedMetrePerPrefixedSecond_Time = _prefixId.prefix "PrefixedMetrePerPrefixedSecond-Time"

    /// <summary>
    ///   <para>rdfs:label : prefixed metre per prefixed secon (time) squared</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMetrePerPrefixedSecond-TimeSquared">oum:PrefixedMetrePerPrefixedSecond-TimeSquared</a>
    /// </summary>
    let PrefixedMetrePerPrefixedSecond_TimeSquared = _prefixId.prefix "PrefixedMetrePerPrefixedSecond-TimeSquared"

    /// <summary>
    ///   <para>rdfs:label : prefixed metre per second (time)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMetrePerSecond-Time">oum:PrefixedMetrePerSecond-Time</a>
    /// </summary>
    let PrefixedMetrePerSecond_Time = _prefixId.prefix "PrefixedMetrePerSecond-Time"

    /// <summary>
    ///   <para>rdfs:label : prefixed metre per second (time) squared</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMetrePerSecond-TimeSquared">oum:PrefixedMetrePerSecond-TimeSquared</a>
    /// </summary>
    let PrefixedMetrePerSecond_TimeSquared = _prefixId.prefix "PrefixedMetrePerSecond-TimeSquared"

    /// <summary>
    ///   <para>rdfs:label : prefixed metre prefixed gram</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMetrePrefixedGram">oum:PrefixedMetrePrefixedGram</a>
    /// </summary>
    let PrefixedMetrePrefixedGram = _prefixId.prefix "PrefixedMetrePrefixedGram"
    /// <summary>
    ///   <para>rdfs:label : prefixed molair</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMolair">oum:PrefixedMolair</a>
    /// </summary>
    let PrefixedMolair = _prefixId.prefix "PrefixedMolair"
    /// <summary>
    ///   <para>rdfs:label : prefixed mole</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMole">oum:PrefixedMole</a>
    /// </summary>
    let PrefixedMole = _prefixId.prefix "PrefixedMole"
    /// <summary>
    ///   <para>rdfs:label : prefixed mole per litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMolePerLitre">oum:PrefixedMolePerLitre</a>
    /// </summary>
    let PrefixedMolePerLitre = _prefixId.prefix "PrefixedMolePerLitre"
    /// <summary>
    ///   <para>rdfs:label : prefixed mole per metre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMolePerMetre">oum:PrefixedMolePerMetre</a>
    /// </summary>
    let PrefixedMolePerMetre = _prefixId.prefix "PrefixedMolePerMetre"
    /// <summary>
    ///   <para>rdfs:label : prefixed mole per prefixed litre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMolePerPrefixedLitre">oum:PrefixedMolePerPrefixedLitre</a>
    /// </summary>
    let PrefixedMolePerPrefixedLitre = _prefixId.prefix "PrefixedMolePerPrefixedLitre"
    /// <summary>
    ///   <para>rdfs:label : prefixed mole per prefixed metre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedMolePerPrefixedMetre">oum:PrefixedMolePerPrefixedMetre</a>
    /// </summary>
    let PrefixedMolePerPrefixedMetre = _prefixId.prefix "PrefixedMolePerPrefixedMetre"
    /// <summary>
    ///   <para>rdfs:label : prefixed newton</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedNewton">oum:PrefixedNewton</a>
    /// </summary>
    let PrefixedNewton = _prefixId.prefix "PrefixedNewton"
    /// <summary>
    ///   <para>rdfs:label : prefixed ohm</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedOhm">oum:PrefixedOhm</a>
    /// </summary>
    let PrefixedOhm = _prefixId.prefix "PrefixedOhm"
    /// <summary>
    ///   <para>rdfs:label : prefixed pascal</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedPascal">oum:PrefixedPascal</a>
    /// </summary>
    let PrefixedPascal = _prefixId.prefix "PrefixedPascal"
    /// <summary>
    ///   <para>rdfs:label : prefixed poise</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedPoise">oum:PrefixedPoise</a>
    /// </summary>
    let PrefixedPoise = _prefixId.prefix "PrefixedPoise"
    /// <summary>
    ///   <para>rdfs:label : prefixed radian</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedRadian">oum:PrefixedRadian</a>
    /// </summary>
    let PrefixedRadian = _prefixId.prefix "PrefixedRadian"
    /// <summary>
    ///   <para>rdfs:label : prefixed second (time)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedSecond-Time">oum:PrefixedSecond-Time</a>
    /// </summary>
    let PrefixedSecond_Time = _prefixId.prefix "PrefixedSecond-Time"
    /// <summary>
    ///   <para>rdfs:label : prefixed second (time) squared</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedSecond-TimeSquared">oum:PrefixedSecond-TimeSquared</a>
    /// </summary>
    let PrefixedSecond_TimeSquared = _prefixId.prefix "PrefixedSecond-TimeSquared"
    /// <summary>
    ///   <para>rdfs:label : prefixed siemens</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedSiemens">oum:PrefixedSiemens</a>
    /// </summary>
    let PrefixedSiemens = _prefixId.prefix "PrefixedSiemens"
    /// <summary>
    ///   <para>rdfs:label : prefixed sievert</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedSievert">oum:PrefixedSievert</a>
    /// </summary>
    let PrefixedSievert = _prefixId.prefix "PrefixedSievert"
    /// <summary>
    ///   <para>rdfs:label : prefixed steradian</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedSteradian">oum:PrefixedSteradian</a>
    /// </summary>
    let PrefixedSteradian = _prefixId.prefix "PrefixedSteradian"
    /// <summary>
    ///   <para>rdfs:label : prefixed stokes</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedStokes">oum:PrefixedStokes</a>
    /// </summary>
    let PrefixedStokes = _prefixId.prefix "PrefixedStokes"
    /// <summary>
    ///   <para>rdfs:label : prefixed tesla</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedTesla">oum:PrefixedTesla</a>
    /// </summary>
    let PrefixedTesla = _prefixId.prefix "PrefixedTesla"
    /// <summary>
    ///   <para>rdfs:label : prefixed tonne</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedTonne">oum:PrefixedTonne</a>
    /// </summary>
    let PrefixedTonne = _prefixId.prefix "PrefixedTonne"
    /// <summary>
    ///   <para>rdfs:label : prefixed unified atomic mass unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedUnifiedAtomicMassUnit">oum:PrefixedUnifiedAtomicMassUnit</a>
    /// </summary>
    let PrefixedUnifiedAtomicMassUnit = _prefixId.prefix "PrefixedUnifiedAtomicMassUnit"
    /// <summary>
    ///   <para>rdfs:label : prefixed unitrdfs:label : 補助単位</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedUnit">oum:PrefixedUnit</a>
    /// </summary>
    let PrefixedUnit = _prefixId.prefix "PrefixedUnit"
    /// <summary>
    ///   <para>rdfs:label : prefixed volt</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedVolt">oum:PrefixedVolt</a>
    /// </summary>
    let PrefixedVolt = _prefixId.prefix "PrefixedVolt"
    /// <summary>
    ///   <para>rdfs:label : prefixed watt</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedWatt">oum:PrefixedWatt</a>
    /// </summary>
    let PrefixedWatt = _prefixId.prefix "PrefixedWatt"
    /// <summary>
    ///   <para>rdfs:label : prefixed weber</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PrefixedWeber">oum:PrefixedWeber</a>
    /// </summary>
    let PrefixedWeber = _prefixId.prefix "PrefixedWeber"
    /// <summary>
    ///   <para>oum:alternativeSymbol : P^^xsd:string</para>
    ///   <para>rdfs:label : drukrdfs:label : pressurerdfs:label : 压力</para>
    ///   <para>oum:symbol : p^^xsd:string</para>
    ///   <para>rdfs:comment : Pressure is the force applied to or distributed over a surface. It is a derived quantity in the International System of Units. Pressure is force divided by area.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Pressure">oum:Pressure</a>
    /// </summary>
    let Pressure = _prefixId.prefix "Pressure"
    /// <summary>
    ///   <para>rdfs:label : pressure unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PressureUnit">oum:PressureUnit</a>
    /// </summary>
    let PressureUnit = _prefixId.prefix "PressureUnit"
    /// <summary>
    ///   <para>rdfs:label : protein mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of protein in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ProteinMassFraction">oum:ProteinMassFraction</a>
    /// </summary>
    let ProteinMassFraction = _prefixId.prefix "ProteinMassFraction"
    /// <summary>
    ///   <para>oum:alternativeLabel : pulp</para>
    ///   <para>rdfs:label : pulp browning</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: poster (code).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/PulpBrowning">oum:PulpBrowning</a>
    /// </summary>
    let PulpBrowning = _prefixId.prefix "PulpBrowning"
    /// <summary>
    ///   <para>oum:alternativeLabel : Qcijfer</para>
    ///   <para>rdfs:label : quality markrdfs:label : kwaliteitscijfer</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QualityMark">oum:QualityMark</a>
    /// </summary>
    let QualityMark = _prefixId.prefix "QualityMark"
    /// <summary>
    ///   <para>oum:alternativeLabel : Qcijfer flower</para>
    ///   <para>rdfs:label : quality mark flower(s)rdfs:label : kwaliteitscijfer bloem(en)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QualityMarkFlower">oum:QualityMarkFlower</a>
    /// </summary>
    let QualityMarkFlower = _prefixId.prefix "QualityMarkFlower"
    /// <summary>
    ///   <para>oum:alternativeLabel : Qcijfer leaf</para>
    ///   <para>rdfs:label : quality mark leafsrdfs:label : kwaliteitscijfer bladeren</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QualityMarkLeaf">oum:QualityMarkLeaf</a>
    /// </summary>
    let QualityMarkLeaf = _prefixId.prefix "QualityMarkLeaf"
    /// <summary>
    ///   <para>oum:alternativeLabel : Qcijfer total</para>
    ///   <para>rdfs:label : quality mark totalrdfs:label : kwaliteitscijfer total</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QualityMarkTotal">oum:QualityMarkTotal</a>
    /// </summary>
    let QualityMarkTotal = _prefixId.prefix "QualityMarkTotal"
    /// <summary>
    ///   <para>rdfs:label : quantityrdfs:label : 量</para>
    ///   <para>rdfs:comment : A quantity is a representation of a quantifiable (standardised) aspect (such as length, mass, and time) of a phenomenon (e.g., a star, a molecule, or a food product). Quantities are classified according to similarity in their (implicit) metrological aspect, e.g. the length of my table and the length of my chair are both classified as length.rdfs:comment : 量とは，ある現象（例: 星・分子・食品）の定量化できる（標準化された）性質（例: 長さ・質量・時間）の表現である。量は（暗黙の）計量的類似性に従って分離される。例: 机の長さ及び椅子の長さは双方とも長さに分類される。</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Quantity">oum:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>rdfs:label : quantity of dimension one</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QuantityOfDimensionOne">oum:QuantityOfDimensionOne</a>
    /// </summary>
    let QuantityOfDimensionOne = _prefixId.prefix "QuantityOfDimensionOne"
    /// <summary>
    ///   <para>rdfs:label : quantity of dimension one unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QuantityOfDimensionOneUnit">oum:QuantityOfDimensionOneUnit</a>
    /// </summary>
    let QuantityOfDimensionOneUnit = _prefixId.prefix "QuantityOfDimensionOneUnit"
    /// <summary>
    ///   <para>oum:symbol : QE^^xsd:string</para>
    ///   <para>rdfs:label : quantum efficiency</para>
    ///   <para>rdfs:comment : Ratio (of a detector such as a CCD) of actual number of detected photons and the number of incident photons.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QuantumEfficiency">oum:QuantumEfficiency</a>
    /// </summary>
    let QuantumEfficiency = _prefixId.prefix "QuantumEfficiency"
    /// <summary>
    ///   <para>rdfs:label : quantum efficiency unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/QuantumEfficiencyUnit">oum:QuantumEfficiencyUnit</a>
    /// </summary>
    let QuantumEfficiencyUnit = _prefixId.prefix "QuantumEfficiencyUnit"
    /// <summary>
    ///   <para>oum:symbol : R^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m_R^^xsd:string</para>
    ///   <para>rdfs:label : R magnitude</para>
    ///   <para>rdfs:comment : R magnitude in the Cousins photometric system.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RMagnitude">oum:RMagnitude</a>
    /// </summary>
    let RMagnitude = _prefixId.prefix "RMagnitude"
    /// <summary>
    ///   <para>oum:symbol : L^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : L_e^^xsd:string</para>
    ///   <para>rdfs:label : radiance</para>
    ///   <para>rdfs:comment : Radiance is a radiometric measure that describes the amount of light that passes through or is emitted from a particular area and falls within a given solid angle in a specified direction.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Radiance">oum:Radiance</a>
    /// </summary>
    let Radiance = _prefixId.prefix "Radiance"
    /// <summary>
    ///   <para>rdfs:label : radiance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RadianceUnit">oum:RadianceUnit</a>
    /// </summary>
    let RadianceUnit = _prefixId.prefix "RadianceUnit"
    /// <summary>
    ///   <para>rdfs:label : radiant energy</para>
    ///   <para>oum:alternativeSymbol : Q_e^^xsd:stringoum:alternativeSymbol : W^^xsd:string</para>
    ///   <para>oum:symbol : Q^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RadiantEnergy">oum:RadiantEnergy</a>
    /// </summary>
    let RadiantEnergy = _prefixId.prefix "RadiantEnergy"
    /// <summary>
    ///   <para>oum:alternativeLabel : radiant poweroum:alternativeLabel : radiant energy flux</para>
    ///   <para>rdfs:label : radiant flux</para>
    ///   <para>oum:alternativeSymbol : Φ_e^^xsd:stringoum:alternativeSymbol : P^^xsd:string</para>
    ///   <para>rdfs:comment : Radiant flux is the measure of the total power of electromagnetic radiation.</para>
    ///   <para>oum:symbol : Φ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RadiantFlux">oum:RadiantFlux</a>
    /// </summary>
    let RadiantFlux = _prefixId.prefix "RadiantFlux"
    /// <summary>
    ///   <para>oum:symbol : I^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : I_e^^xsd:string</para>
    ///   <para>rdfs:label : radiant intensity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RadiantIntensity">oum:RadiantIntensity</a>
    /// </summary>
    let RadiantIntensity = _prefixId.prefix "RadiantIntensity"
    /// <summary>
    ///   <para>rdfs:label : radiant intensity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RadiantIntensityUnit">oum:RadiantIntensityUnit</a>
    /// </summary>
    let RadiantIntensityUnit = _prefixId.prefix "RadiantIntensityUnit"
    /// <summary>
    ///   <para>oum:symbol : r^^xsd:string</para>
    ///   <para>rdfs:label : straalrdfs:label : radiusrdfs:label : 半径</para>
    ///   <para>oum:alternativeLabel : radius</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Radius">oum:Radius</a>
    /// </summary>
    let Radius = _prefixId.prefix "Radius"
    /// <summary>
    ///   <para>rdfs:label : radius (angle)rdfs:label : radius (hoek)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Radius-Angle">oum:Radius-Angle</a>
    /// </summary>
    let Radius_Angle = _prefixId.prefix "Radius-Angle"
    let RankineScale = _prefixId.prefix "RankineScale"
    /// <summary>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <para>rdfs:label : Rankine temperaturerdfs:label : Rankinetemperatuur</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RankineTemperature">oum:RankineTemperature</a>
    /// </summary>
    let RankineTemperature = _prefixId.prefix "RankineTemperature"
    /// <summary>
    ///   <para>rdfs:label : Rankine temperature scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RankineTemperatureScale">oum:RankineTemperatureScale</a>
    /// </summary>
    let RankineTemperatureScale = _prefixId.prefix "RankineTemperatureScale"
    /// <summary>
    ///   <para>rdfs:label : Rankine temperature unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RankineTemperatureUnit">oum:RankineTemperatureUnit</a>
    /// </summary>
    let RankineTemperatureUnit = _prefixId.prefix "RankineTemperatureUnit"
    /// <summary>
    ///   <para>rdfs:label : ratio</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Ratio">oum:Ratio</a>
    /// </summary>
    let Ratio = _prefixId.prefix "Ratio"
    /// <summary>
    ///   <para>rdfs:label : ratio scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RatioScale">oum:RatioScale</a>
    /// </summary>
    let RatioScale = _prefixId.prefix "RatioScale"
    /// <summary>
    ///   <para>rdfs:label : ratio unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RatioUnit">oum:RatioUnit</a>
    /// </summary>
    let RatioUnit = _prefixId.prefix "RatioUnit"
    /// <summary>
    ///   <para>oum:symbol : Ra^^xsd:string</para>
    ///   <para>rdfs:label : Rayleigh numberrdfs:label : getal van Rayleigh</para>
    ///   <para>rdfs:comment : The Rayleigh number for a fluid is a dimensionless number associated with buoyancy driven flow.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RayleighNumber">oum:RayleighNumber</a>
    /// </summary>
    let RayleighNumber = _prefixId.prefix "RayleighNumber"
    /// <summary>
    ///   <para>rdfs:label : Rayleigh number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RayleighNumberUnit">oum:RayleighNumberUnit</a>
    /// </summary>
    let RayleighNumberUnit = _prefixId.prefix "RayleighNumberUnit"
    let ReaumurScale = _prefixId.prefix "ReaumurScale"
    /// <summary>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <para>rdfs:label : Réaumur temperaturerdfs:label : Réaumurtemperatuur</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReaumurTemperature">oum:ReaumurTemperature</a>
    /// </summary>
    let ReaumurTemperature = _prefixId.prefix "ReaumurTemperature"
    /// <summary>
    ///   <para>rdfs:label : Réaumur temperature scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReaumurTemperatureScale">oum:ReaumurTemperatureScale</a>
    /// </summary>
    let ReaumurTemperatureScale = _prefixId.prefix "ReaumurTemperatureScale"
    /// <summary>
    ///   <para>rdfs:label : Réaumur temperature unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReaumurTemperatureUnit">oum:ReaumurTemperatureUnit</a>
    /// </summary>
    let ReaumurTemperatureUnit = _prefixId.prefix "ReaumurTemperatureUnit"
    /// <summary>
    ///   <para>oum:symbol : r^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m_r^^xsd:string</para>
    ///   <para>rdfs:label : red magnitude</para>
    ///   <para>rdfs:comment : A red magnitude not specified for a specific photometric system.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RedMagnitude">oum:RedMagnitude</a>
    /// </summary>
    let RedMagnitude = _prefixId.prefix "RedMagnitude"
    /// <summary>
    ///   <para>oum:symbol : E^^xsd:string</para>
    ///   <para>oum:alternativeLabel : colour excessoum:alternativeLabel : wavelength-selective extinction</para>
    ///   <para>rdfs:label : reddening</para>
    ///   <para>rdfs:comment : Reddening causes the star to appear redder if more dust or gas is between the star and the observer.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Reddening">oum:Reddening</a>
    /// </summary>
    let Reddening = _prefixId.prefix "Reddening"
    /// <summary>
    ///   <para>oum:symbol : E_B-V^^xsd:string</para>
    ///   <para>oum:alternativeLabel : colour excess (B-V)oum:alternativeLabel : wavelength-selective extinction (B-V)</para>
    ///   <para>oum:LaTeXSymbol : E_{\mathit{B-V}}^^xsd:string</para>
    ///   <para>rdfs:label : reddening (B-V)</para>
    ///   <para>rdfs:comment : Reddening causes the star to appear redder if more dust or gas is between the star and the observer. The standard reddening is measured using the B and V passbands.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReddeningB-V">oum:ReddeningB-V</a>
    /// </summary>
    let ReddeningB_V = _prefixId.prefix "ReddeningB-V"
    /// <summary>
    ///   <para>oum:symbol : E_U-B^^xsd:string</para>
    ///   <para>oum:alternativeLabel : colour excess (U-B)oum:alternativeLabel : wavelength-selective extinction (U-B)</para>
    ///   <para>oum:LaTeXSymbol : E_{\mathit{U-B}}^^xsd:string</para>
    ///   <para>rdfs:label : reddening (U-B)</para>
    ///   <para>rdfs:comment : Reddening measured with the U and B passbands.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReddeningU-B">oum:ReddeningU-B</a>
    /// </summary>
    let ReddeningU_B = _prefixId.prefix "ReddeningU-B"
    /// <summary>
    ///   <para>oum:symbol : RH^^xsd:string</para>
    ///   <para>rdfs:label : relative humidityrdfs:label : relatieve luchtvochtigheid</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RelativeHumidity">oum:RelativeHumidity</a>
    /// </summary>
    let RelativeHumidity = _prefixId.prefix "RelativeHumidity"
    /// <summary>
    ///   <para>rdfs:label : relative humidity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RelativeHumidityUnit">oum:RelativeHumidityUnit</a>
    /// </summary>
    let RelativeHumidityUnit = _prefixId.prefix "RelativeHumidityUnit"
    /// <summary>
    ///   <para>oum:symbol : τ^^xsd:string</para>
    ///   <para>rdfs:label : reluctance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Reluctance">oum:Reluctance</a>
    /// </summary>
    let Reluctance = _prefixId.prefix "Reluctance"
    /// <summary>
    ///   <para>rdfs:label : reluctance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReluctanceUnit">oum:ReluctanceUnit</a>
    /// </summary>
    let ReluctanceUnit = _prefixId.prefix "ReluctanceUnit"
    /// <summary>
    ///   <para>rdfs:label : resonance energy</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ResonanceEnergy">oum:ResonanceEnergy</a>
    /// </summary>
    let ResonanceEnergy = _prefixId.prefix "ResonanceEnergy"
    /// <summary>
    ///   <para>oum:symbol : R^^xsd:string</para>
    ///   <para>rdfs:label : responsivity</para>
    ///   <para>rdfs:comment : Detector output for unit intensity input. Units are usually volts per watt or amps per watt.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Responsivity">oum:Responsivity</a>
    /// </summary>
    let Responsivity = _prefixId.prefix "Responsivity"
    /// <summary>
    ///   <para>rdfs:label : responsivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ResponsivityUnit">oum:ResponsivityUnit</a>
    /// </summary>
    let ResponsivityUnit = _prefixId.prefix "ResponsivityUnit"
    /// <summary>
    ///   <para>oum:symbol : Re^^xsd:string</para>
    ///   <para>rdfs:label : Reynolds numberrdfs:label : getal van Reynolds</para>
    ///   <para>rdfs:comment : The Reynolds number is a dimensionless number that gives a measure of the ratio of inertial forces to viscous forces and, consequently, quantifies the relative importance of these two types of forces for given flow conditions.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReynoldsNumber">oum:ReynoldsNumber</a>
    /// </summary>
    let ReynoldsNumber = _prefixId.prefix "ReynoldsNumber"
    /// <summary>
    ///   <para>rdfs:label : Reynolds number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ReynoldsNumberUnit">oum:ReynoldsNumberUnit</a>
    /// </summary>
    let ReynoldsNumberUnit = _prefixId.prefix "ReynoldsNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : right ascensionrdfs:label : rechte klimming</para>
    ///   <para>oum:symbol : α^^xsd:string</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere measured eastward along the celestial equator from the equinox to the great circle passing through the celestial object and the celestial north pole.</para>
    ///   <para>oum:alternativeSymbol : ra^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/RightAscension">oum:RightAscension</a>
    /// </summary>
    let RightAscension = _prefixId.prefix "RightAscension"
    let RussianRuble = _prefixId.prefix "RussianRuble"
    /// <summary>
    ///   <para>rdfs:label : SI prefix</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SIPrefix">oum:SIPrefix</a>
    /// </summary>
    let SIPrefix = _prefixId.prefix "SIPrefix"
    /// <summary>
    ///   <para>rdfs:label : salt mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of salt in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SaltMassFraction">oum:SaltMassFraction</a>
    /// </summary>
    let SaltMassFraction = _prefixId.prefix "SaltMassFraction"
    /// <summary>
    ///   <para>rdfs:label : salt strengthrdfs:label : zoutsterkte</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SaltStrength">oum:SaltStrength</a>
    /// </summary>
    let SaltStrength = _prefixId.prefix "SaltStrength"
    /// <summary>
    ///   <para>oum:alternativeLabel : measurement scaleoum:alternativeLabel : schaaloum:alternativeLabel : meetschaal</para>
    ///   <para>rdfs:label : scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Scale">oum:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:label : scale factorrdfs:label : schaalfactor</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ScaleFactor">oum:ScaleFactor</a>
    /// </summary>
    let ScaleFactor = _prefixId.prefix "ScaleFactor"
    /// <summary>
    ///   <para>oum:symbol : h_z^^xsd:string</para>
    ///   <para>rdfs:label : scale height</para>
    ///   <para>rdfs:comment : The scale height of a feature (such as the thin galactic disk) is the height (or position) at which the number density of the feature (for instance of the number of Population II stars) is equal to 1/e times the number density at the origin (for instance the Galactic Plane).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ScaleHeight">oum:ScaleHeight</a>
    /// </summary>
    let ScaleHeight = _prefixId.prefix "ScaleHeight"
    /// <summary>
    ///   <para>oum:symbol : r^^xsd:string</para>
    ///   <para>oum:alternativeLabel : scale radius</para>
    ///   <para>rdfs:label : scale length</para>
    ///   <para>rdfs:comment : The radial distance from a galaxy's core at which the average intensity has fallen to 1/e of the intensity at the centre of the galaxy.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ScaleLength">oum:ScaleLength</a>
    /// </summary>
    let ScaleLength = _prefixId.prefix "ScaleLength"
    /// <summary>
    ///   <para>oum:symbol : Sc^^xsd:string</para>
    ///   <para>rdfs:label : Schmidt numberrdfs:label : getal van Schmidt</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SchmidtNumber">oum:SchmidtNumber</a>
    /// </summary>
    let SchmidtNumber = _prefixId.prefix "SchmidtNumber"
    /// <summary>
    ///   <para>rdfs:label : Schmidt number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SchmidtNumberUnit">oum:SchmidtNumberUnit</a>
    /// </summary>
    let SchmidtNumberUnit = _prefixId.prefix "SchmidtNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : secular aberration</para>
    ///   <para>rdfs:comment : The component of the stellar abberation resulting from the motion of the solar system in space. This component is usually ignored. The abberation is the apparent angular displacement of the observed position of a celestial object from its geometric position, caused by the finite velocity of light in combination with the motions of the observer and of the observed object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SecularAberration">oum:SecularAberration</a>
    /// </summary>
    let SecularAberration = _prefixId.prefix "SecularAberration"
    /// <summary>
    ///   <para>rdfs:label : shear loss modulus</para>
    ///   <para>oum:symbol : G''^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearLossModulus">oum:ShearLossModulus</a>
    /// </summary>
    let ShearLossModulus = _prefixId.prefix "ShearLossModulus"
    /// <summary>
    ///   <para>oum:alternativeSymbol : S^^xsd:stringoum:alternativeSymbol : μ^^xsd:string</para>
    ///   <para>rdfs:comment : Shear modulus is the ratio of shear stress to shear strain.</para>
    ///   <para>oum:symbol : G^^xsd:string</para>
    ///   <para>rdfs:label : shear modulusrdfs:label : schuifmodulus</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearModulus">oum:ShearModulus</a>
    /// </summary>
    let ShearModulus = _prefixId.prefix "ShearModulus"
    /// <summary>
    ///   <para>oum:symbol : S^^xsd:string</para>
    ///   <para>rdfs:label : shear rate</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearRate">oum:ShearRate</a>
    /// </summary>
    let ShearRate = _prefixId.prefix "ShearRate"
    /// <summary>
    ///   <para>rdfs:label : shear rate unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearRateUnit">oum:ShearRateUnit</a>
    /// </summary>
    let ShearRateUnit = _prefixId.prefix "ShearRateUnit"
    /// <summary>
    ///   <para>rdfs:label : shear storage modulus</para>
    ///   <para>oum:symbol : G'^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearStorageModulus">oum:ShearStorageModulus</a>
    /// </summary>
    let ShearStorageModulus = _prefixId.prefix "ShearStorageModulus"
    /// <summary>
    ///   <para>rdfs:label : shear strainrdfs:label : schuifvervorming</para>
    ///   <para>rdfs:comment : Shear strain is a strain that acts parallel to the surface of a material that it acts on.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearStrain">oum:ShearStrain</a>
    /// </summary>
    let ShearStrain = _prefixId.prefix "ShearStrain"
    /// <summary>
    ///   <para>rdfs:comment : Shear stress is a stress that is applied parallel or tangential to a face of a material.</para>
    ///   <para>rdfs:label : schuifspanningrdfs:label : shear stress</para>
    ///   <para>oum:symbol : τ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ShearStress">oum:ShearStress</a>
    /// </summary>
    let ShearStress = _prefixId.prefix "ShearStress"
    let SingaporeDollar = _prefixId.prefix "SingaporeDollar"
    /// <summary>
    ///   <para>rdfs:label : singular unitrdfs:label : 単数単位</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SingularUnit">oum:SingularUnit</a>
    /// </summary>
    let SingularUnit = _prefixId.prefix "SingularUnit"
    /// <summary>
    ///   <para>rdfs:comment : Solid angle is the ratio of the surface of a portion of a sphere enclosed by the conical surface that forms an angle to the square of the radius of the sphere.</para>
    ///   <para>rdfs:label : ruimtehoekrdfs:label : solid anglerdfs:label : 立体角</para>
    ///   <para>oum:alternativeSymbol : ω^^xsd:string</para>
    ///   <para>oum:symbol : Ω^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SolidAngle">oum:SolidAngle</a>
    /// </summary>
    let SolidAngle = _prefixId.prefix "SolidAngle"
    /// <summary>
    ///   <para>rdfs:label : solid angle unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SolidAngleUnit">oum:SolidAngleUnit</a>
    /// </summary>
    let SolidAngleUnit = _prefixId.prefix "SolidAngleUnit"
    let SouthAfricanRand = _prefixId.prefix "SouthAfricanRand"
    let SouthKoreanWon = _prefixId.prefix "SouthKoreanWon"
    /// <summary>
    ///   <para>rdfs:label : soy bean mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of soy bean oil in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SoyBeanMassFraction">oum:SoyBeanMassFraction</a>
    /// </summary>
    let SoyBeanMassFraction = _prefixId.prefix "SoyBeanMassFraction"
    /// <summary>
    ///   <para>rdfs:label : specific amount of money</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificAmountOfMoney">oum:SpecificAmountOfMoney</a>
    /// </summary>
    let SpecificAmountOfMoney = _prefixId.prefix "SpecificAmountOfMoney"
    /// <summary>
    ///   <para>rdfs:label : specific amount of money unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificAmountOfMoneyUnit">oum:SpecificAmountOfMoneyUnit</a>
    /// </summary>
    let SpecificAmountOfMoneyUnit = _prefixId.prefix "SpecificAmountOfMoneyUnit"
    /// <summary>
    ///   <para>rdfs:label : specific amylase activity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificAmylaseActivity">oum:SpecificAmylaseActivity</a>
    /// </summary>
    let SpecificAmylaseActivity = _prefixId.prefix "SpecificAmylaseActivity"
    /// <summary>
    ///   <para>rdfs:label : specific catalytic activity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificCatalyticActivity">oum:SpecificCatalyticActivity</a>
    /// </summary>
    let SpecificCatalyticActivity = _prefixId.prefix "SpecificCatalyticActivity"
    /// <summary>
    ///   <para>rdfs:label : specific catalytic activity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificCatalyticActivityUnit">oum:SpecificCatalyticActivityUnit</a>
    /// </summary>
    let SpecificCatalyticActivityUnit = _prefixId.prefix "SpecificCatalyticActivityUnit"
    /// <summary>
    ///   <para>rdfs:label : coliform bacteria count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificColiformBacterieCount">oum:SpecificColiformBacterieCount</a>
    /// </summary>
    let SpecificColiformBacterieCount = _prefixId.prefix "SpecificColiformBacterieCount"

    /// <summary>
    ///   <para>rdfs:label : Corynebacterium bovis count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificCorynebacteriumBovisCount">oum:SpecificCorynebacteriumBovisCount</a>
    /// </summary>
    let SpecificCorynebacteriumBovisCount = _prefixId.prefix "SpecificCorynebacteriumBovisCount"

    /// <summary>
    ///   <para>oum:alternativeLabel : Arcanobacterium count (specific)</para>
    ///   <para>rdfs:label : Corynebacterium count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificCorynebacteriumCount">oum:SpecificCorynebacteriumCount</a>
    /// </summary>
    let SpecificCorynebacteriumCount = _prefixId.prefix "SpecificCorynebacteriumCount"
    /// <summary>
    ///   <para>rdfs:label : specific cost</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificCost">oum:SpecificCost</a>
    /// </summary>
    let SpecificCost = _prefixId.prefix "SpecificCost"
    /// <summary>
    ///   <para>rdfs:label : specific energy</para>
    ///   <para>rdfs:comment : Specific energy is energy per unit mass.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEnergy">oum:SpecificEnergy</a>
    /// </summary>
    let SpecificEnergy = _prefixId.prefix "SpecificEnergy"
    /// <summary>
    ///   <para>oum:alternativeLabel : specific energy (imparted)</para>
    ///   <para>rdfs:label : specific energy imparted</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEnergyImparted">oum:SpecificEnergyImparted</a>
    /// </summary>
    let SpecificEnergyImparted = _prefixId.prefix "SpecificEnergyImparted"
    /// <summary>
    ///   <para>rdfs:label : specific energy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEnergyUnit">oum:SpecificEnergyUnit</a>
    /// </summary>
    let SpecificEnergyUnit = _prefixId.prefix "SpecificEnergyUnit"

    /// <summary>
    ///   <para>rdfs:label : Enterobacteriaceae count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEnterobacteriaceaeCount">oum:SpecificEnterobacteriaceaeCount</a>
    /// </summary>
    let SpecificEnterobacteriaceaeCount = _prefixId.prefix "SpecificEnterobacteriaceaeCount"

    /// <summary>
    ///   <para>rdfs:label : Enterococcus count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEnterococcusCount">oum:SpecificEnterococcusCount</a>
    /// </summary>
    let SpecificEnterococcusCount = _prefixId.prefix "SpecificEnterococcusCount"
    /// <summary>
    ///   <para>rdfs:label : specific entropy</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEntropy">oum:SpecificEntropy</a>
    /// </summary>
    let SpecificEntropy = _prefixId.prefix "SpecificEntropy"
    /// <summary>
    ///   <para>rdfs:label : specific entropy unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEntropyUnit">oum:SpecificEntropyUnit</a>
    /// </summary>
    let SpecificEntropyUnit = _prefixId.prefix "SpecificEntropyUnit"
    /// <summary>
    ///   <para>rdfs:label : Escherichia coli count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificEscherichiaColiCount">oum:SpecificEscherichiaColiCount</a>
    /// </summary>
    let SpecificEscherichiaColiCount = _prefixId.prefix "SpecificEscherichiaColiCount"
    /// <summary>
    ///   <para>oum:alternativeLabel : specifieke warmteoum:alternativeLabel : specifieke warmtecapaciteit</para>
    ///   <para>rdfs:label : specific heat capacityrdfs:label : soortelijke warmte</para>
    ///   <para>oum:alternativeSymbol : c_v^^xsd:string</para>
    ///   <para>oum:symbol : c_p^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificHeatCapacity">oum:SpecificHeatCapacity</a>
    /// </summary>
    let SpecificHeatCapacity = _prefixId.prefix "SpecificHeatCapacity"
    /// <summary>
    ///   <para>rdfs:label : specific heat capacity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificHeatCapacityUnit">oum:SpecificHeatCapacityUnit</a>
    /// </summary>
    let SpecificHeatCapacityUnit = _prefixId.prefix "SpecificHeatCapacityUnit"
    /// <summary>
    ///   <para>rdfs:label : Klebsiella count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificKlebsiellaCount">oum:SpecificKlebsiellaCount</a>
    /// </summary>
    let SpecificKlebsiellaCount = _prefixId.prefix "SpecificKlebsiellaCount"

    /// <summary>
    ///   <para>rdfs:label : Listeria monocytogenes count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificListeriaMonocytogenesCount">oum:SpecificListeriaMonocytogenesCount</a>
    /// </summary>
    let SpecificListeriaMonocytogenesCount = _prefixId.prefix "SpecificListeriaMonocytogenesCount"

    /// <summary>
    ///   <para>rdfs:label : specific protease activity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificProteaseActivity">oum:SpecificProteaseActivity</a>
    /// </summary>
    let SpecificProteaseActivity = _prefixId.prefix "SpecificProteaseActivity"
    /// <summary>
    ///   <para>rdfs:label : Salmonella count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificSalmonellaCount">oum:SpecificSalmonellaCount</a>
    /// </summary>
    let SpecificSalmonellaCount = _prefixId.prefix "SpecificSalmonellaCount"

    /// <summary>
    ///   <para>rdfs:label : Serratia marcescens count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificSerratiaMarcescensCount">oum:SpecificSerratiaMarcescensCount</a>
    /// </summary>
    let SpecificSerratiaMarcescensCount = _prefixId.prefix "SpecificSerratiaMarcescensCount"

    /// <summary>
    ///   <para>rdfs:label : Staphylococcus aureus count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificStaphylococcusAureusCount">oum:SpecificStaphylococcusAureusCount</a>
    /// </summary>
    let SpecificStaphylococcusAureusCount = _prefixId.prefix "SpecificStaphylococcusAureusCount"

    /// <summary>
    ///   <para>rdfs:label : Streptococcus agalactiae count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificStreptococcusAgalactiaeCount">oum:SpecificStreptococcusAgalactiaeCount</a>
    /// </summary>
    let SpecificStreptococcusAgalactiaeCount = _prefixId.prefix "SpecificStreptococcusAgalactiaeCount"

    /// <summary>
    ///   <para>rdfs:label : Streptococcus dysgalactiae count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificStreptococcusDysgalactiaeCount">oum:SpecificStreptococcusDysgalactiaeCount</a>
    /// </summary>
    let SpecificStreptococcusDysgalactiaeCount = _prefixId.prefix "SpecificStreptococcusDysgalactiaeCount"

    /// <summary>
    ///   <para>rdfs:label : Streptococcus uberis count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificStreptococcusUberisCount">oum:SpecificStreptococcusUberisCount</a>
    /// </summary>
    let SpecificStreptococcusUberisCount = _prefixId.prefix "SpecificStreptococcusUberisCount"

    /// <summary>
    ///   <para>rdfs:label : viable count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificViableCount">oum:SpecificViableCount</a>
    /// </summary>
    let SpecificViableCount = _prefixId.prefix "SpecificViableCount"
    /// <summary>
    ///   <para>rdfs:label : specific viable count unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificViableCountUnit">oum:SpecificViableCountUnit</a>
    /// </summary>
    let SpecificViableCountUnit = _prefixId.prefix "SpecificViableCountUnit"
    /// <summary>
    ///   <para>oum:alternativeLabel : concentration (v/w)oum:alternativeLabel : specifiek volume</para>
    ///   <para>rdfs:label : soortelijk volumerdfs:label : specific volume</para>
    ///   <para>oum:symbol : v^^xsd:string</para>
    ///   <para>rdfs:comment : Specific volume is volume per unit mass.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificVolume">oum:SpecificVolume</a>
    /// </summary>
    let SpecificVolume = _prefixId.prefix "SpecificVolume"
    /// <summary>
    ///   <para>rdfs:label : specific volume unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificVolumeUnit">oum:SpecificVolumeUnit</a>
    /// </summary>
    let SpecificVolumeUnit = _prefixId.prefix "SpecificVolumeUnit"
    /// <summary>
    ///   <para>rdfs:label : yeast and fungi count (specific)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpecificYeastAndFungiCount">oum:SpecificYeastAndFungiCount</a>
    /// </summary>
    let SpecificYeastAndFungiCount = _prefixId.prefix "SpecificYeastAndFungiCount"
    /// <summary>
    ///   <para>rdfs:label : spectral response</para>
    ///   <para>rdfs:comment : The change in output signal as a function of changes in the wavelength of the input signal.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpectralResponse">oum:SpectralResponse</a>
    /// </summary>
    let SpectralResponse = _prefixId.prefix "SpectralResponse"
    /// <summary>
    ///   <para>rdfs:label : 速度rdfs:label : snelheid (scalair)rdfs:label : speed</para>
    ///   <para>oum:alternativeSymbol : u^^xsd:string</para>
    ///   <para>oum:symbol : v^^xsd:string</para>
    ///   <para>rdfs:comment : Speed is the time rate of motion measured by the distance moved over in unit time.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Speed">oum:Speed</a>
    /// </summary>
    let Speed = _prefixId.prefix "Speed"
    /// <summary>
    ///   <para>rdfs:label : speed unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SpeedUnit">oum:SpeedUnit</a>
    /// </summary>
    let SpeedUnit = _prefixId.prefix "SpeedUnit"
    /// <summary>
    ///   <para>rdfs:label : square prefixed metre</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SquarePrefixedMetre">oum:SquarePrefixedMetre</a>
    /// </summary>
    let SquarePrefixedMetre = _prefixId.prefix "SquarePrefixedMetre"
    /// <summary>
    ///   <para>oum:symbol : St^^xsd:string</para>
    ///   <para>rdfs:label : Stanton numberrdfs:label : getal van Stanton</para>
    ///   <para>rdfs:comment : The Stanton number is a dimensionless number that measures the ratio of heat transferred into a fluid to the thermal capacity of fluid.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StantonNumber">oum:StantonNumber</a>
    /// </summary>
    let StantonNumber = _prefixId.prefix "StantonNumber"
    /// <summary>
    ///   <para>oum:symbol : St*^^xsd:string</para>
    ///   <para>rdfs:label : Stanton number for mass transfer</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StantonNumberForMassTransfer">oum:StantonNumberForMassTransfer</a>
    /// </summary>
    let StantonNumberForMassTransfer = _prefixId.prefix "StantonNumberForMassTransfer"

    /// <summary>
    ///   <para>rdfs:label : Stanton number for mass transfer unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StantonNumberForMassTransferUnit">oum:StantonNumberForMassTransferUnit</a>
    /// </summary>
    let StantonNumberForMassTransferUnit = _prefixId.prefix "StantonNumberForMassTransferUnit"

    /// <summary>
    ///   <para>rdfs:label : Stanton number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StantonNumberUnit">oum:StantonNumberUnit</a>
    /// </summary>
    let StantonNumberUnit = _prefixId.prefix "StantonNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : starch mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of starch in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StarchMassFraction">oum:StarchMassFraction</a>
    /// </summary>
    let StarchMassFraction = _prefixId.prefix "StarchMassFraction"
    /// <summary>
    ///   <para>rdfs:label : starch VA40 mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of starch VA40 in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StarchVA40MassFraction">oum:StarchVA40MassFraction</a>
    /// </summary>
    let StarchVA40MassFraction = _prefixId.prefix "StarchVA40MassFraction"
    /// <summary>
    ///   <para>rdfs:label : starch VA85 mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of starch VA85 in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StarchVA85MassFraction">oum:StarchVA85MassFraction</a>
    /// </summary>
    let StarchVA85MassFraction = _prefixId.prefix "StarchVA85MassFraction"
    /// <summary>
    ///   <para>rdfs:label : stellar aberration</para>
    ///   <para>rdfs:comment : The apparent angular displacement of the observed position of a celestial object resulting from the motion of the observer. Stellar aberration is divided into diurnal, annual, and secular components.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StellarAberration">oum:StellarAberration</a>
    /// </summary>
    let StellarAberration = _prefixId.prefix "StellarAberration"
    /// <summary>
    ///   <para>oum:alternativeLabel : stemendrot</para>
    ///   <para>rdfs:label : stem end rot</para>
    ///   <para>rdfs:comment : Aanwezigheid stem end rot (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StemEndRot">oum:StemEndRot</a>
    /// </summary>
    let StemEndRot = _prefixId.prefix "StemEndRot"
    /// <summary>
    ///   <para>oum:alternativeLabel : stemendrot%</para>
    ///   <para>rdfs:label : stem end rot area fractionrdfs:label : stem-end-rot-oppervlaktefractie</para>
    ///   <para>rdfs:comment : Percentage van het oppervlak stem end rot.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StemEndRotAreaFraction">oum:StemEndRotAreaFraction</a>
    /// </summary>
    let StemEndRotAreaFraction = _prefixId.prefix "StemEndRotAreaFraction"
    /// <summary>
    ///   <para>oum:alternativeLabel : stickstone</para>
    ///   <para>rdfs:label : stick stone</para>
    ///   <para>rdfs:comment : Kleefpit of niet (1/0).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StickStone">oum:StickStone</a>
    /// </summary>
    let StickStone = _prefixId.prefix "StickStone"
    /// <summary>
    ///   <para>oum:symbol : E'^^xsd:string</para>
    ///   <para>rdfs:label : storage modulus</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StorageModulus">oum:StorageModulus</a>
    /// </summary>
    let StorageModulus = _prefixId.prefix "StorageModulus"
    /// <summary>
    ///   <para>oum:alternativeSymbol : γ^^xsd:string</para>
    ///   <para>oum:symbol : ε^^xsd:string</para>
    ///   <para>rdfs:label : strainrdfs:label : vervorming</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Strain">oum:Strain</a>
    /// </summary>
    let Strain = _prefixId.prefix "Strain"
    /// <summary>
    ///   <para>oum:symbol : ε_ij^^xsd:string</para>
    ///   <para>oum:alternativeLabel : vervormingstensoroum:alternativeLabel : rektensor</para>
    ///   <para>rdfs:label : strain tensor</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StrainTensor">oum:StrainTensor</a>
    /// </summary>
    let StrainTensor = _prefixId.prefix "StrainTensor"
    /// <summary>
    ///   <para>rdfs:label : strain unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StrainUnit">oum:StrainUnit</a>
    /// </summary>
    let StrainUnit = _prefixId.prefix "StrainUnit"
    /// <summary>
    ///   <para>oum:unofficialLabel : straw weight^^xsd:string</para>
    ///   <para>rdfs:label : straw mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StrawMass">oum:StrawMass</a>
    /// </summary>
    let StrawMass = _prefixId.prefix "StrawMass"
    /// <summary>
    ///   <para>rdfs:label : stressrdfs:label : mechanische spanning</para>
    ///   <para>oum:symbol : σ^^xsd:string</para>
    ///   <para>rdfs:comment : Stress is a force that produces or tends to produce deformation in a body measured by the force applied per unit area.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Stress">oum:Stress</a>
    /// </summary>
    let Stress = _prefixId.prefix "Stress"
    /// <summary>
    ///   <para>rdfs:label : stress tensorrdfs:label : mechanische-spanningstensor</para>
    ///   <para>oum:symbol : τ_ij^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StressTensor">oum:StressTensor</a>
    /// </summary>
    let StressTensor = _prefixId.prefix "StressTensor"
    /// <summary>
    ///   <para>rdfs:label : stress unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StressUnit">oum:StressUnit</a>
    /// </summary>
    let StressUnit = _prefixId.prefix "StressUnit"
    /// <summary>
    ///   <para>rdfs:label : Strömgren magnitude</para>
    ///   <para>rdfs:comment : A magnitude measured in one of Strömgren's standard passbands (using a standard filter, u, b, v, or y) or in the passbands defined by Crawford (β_narrow or β_wide).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StroemgrenMagnitude">oum:StroemgrenMagnitude</a>
    /// </summary>
    let StroemgrenMagnitude = _prefixId.prefix "StroemgrenMagnitude"
    /// <summary>
    ///   <para>oum:symbol : Sr^^xsd:string</para>
    ///   <para>rdfs:label : Strouhal numberrdfs:label : getal van Strouhal</para>
    ///   <para>rdfs:comment : The Strouhal number is a dimensionless number that describes oscillating flow mechanisms.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StrouhalNumber">oum:StrouhalNumber</a>
    /// </summary>
    let StrouhalNumber = _prefixId.prefix "StrouhalNumber"
    /// <summary>
    ///   <para>rdfs:label : Strouhal number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/StrouhalNumberUnit">oum:StrouhalNumberUnit</a>
    /// </summary>
    let StrouhalNumberUnit = _prefixId.prefix "StrouhalNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : sugar mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of sugar in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SugarMassFraction">oum:SugarMassFraction</a>
    /// </summary>
    let SugarMassFraction = _prefixId.prefix "SugarMassFraction"
    /// <summary>
    ///   <para>oum:symbol : SGB^^xsd:string</para>
    ///   <para>rdfs:label : supergalactic latitude</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere north or south of the supergalactic equator. It is measured along the great circle passing through the object and the supergalactic poles and perpendicular to the supergalactic equator.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SupergalacticLatitude">oum:SupergalacticLatitude</a>
    /// </summary>
    let SupergalacticLatitude = _prefixId.prefix "SupergalacticLatitude"
    /// <summary>
    ///   <para>oum:symbol : SGL^^xsd:string</para>
    ///   <para>rdfs:label : supergalactic longitude</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere measured clockwise from the supergalactic centre (as defined by the International Astronomical Union (IAU)) along the supergalactic equator to the intersection with the great circle drawn from the supergalactic north pole through the object.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SupergalacticLongitude">oum:SupergalacticLongitude</a>
    /// </summary>
    let SupergalacticLongitude = _prefixId.prefix "SupergalacticLongitude"
    /// <summary>
    ///   <para>oum:alternativeSymbol : σ^^xsd:string</para>
    ///   <para>rdfs:comment : Surface tension is an attractive property of the surface of a liquid.</para>
    ///   <para>oum:symbol : γ^^xsd:string</para>
    ///   <para>rdfs:label : surface tensionrdfs:label : oppervlaktespanning</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SurfaceTension">oum:SurfaceTension</a>
    /// </summary>
    let SurfaceTension = _prefixId.prefix "SurfaceTension"
    /// <summary>
    ///   <para>rdfs:label : surface tension unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SurfaceTensionUnit">oum:SurfaceTensionUnit</a>
    /// </summary>
    let SurfaceTensionUnit = _prefixId.prefix "SurfaceTensionUnit"
    let SwedishKrona = _prefixId.prefix "SwedishKrona"
    let SwissFranc = _prefixId.prefix "SwissFranc"
    /// <summary>
    ///   <para>oum:alternativeLabel : baud rateoum:alternativeLabel : modulation rate</para>
    ///   <para>rdfs:label : symbol rate</para>
    ///   <para>rdfs:comment : Symbol rate is the number of symbol changes (signalling events) made to the transmission medium per second using a digitally modulated signal or a line code.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SymbolRate">oum:SymbolRate</a>
    /// </summary>
    let SymbolRate = _prefixId.prefix "SymbolRate"
    /// <summary>
    ///   <para>rdfs:label : symbol rate unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SymbolRateUnit">oum:SymbolRateUnit</a>
    /// </summary>
    let SymbolRateUnit = _prefixId.prefix "SymbolRateUnit"
    /// <summary>
    ///   <para>rdfs:label : system of units</para>
    ///   <para>rdfs:comment : In order to achieve a coherent, interdependent set of units of measure in the wide variety of units that exist, units are organised in systems of units. A system of units is based on a set of units chosen by convention to be the system’s base units, units that are considered to be mutually independent (i.e., can’t be expressed in terms of each other).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/SystemOfUnits">oum:SystemOfUnits</a>
    /// </summary>
    let SystemOfUnits = _prefixId.prefix "SystemOfUnits"
    /// <summary>
    ///   <para>rdfs:label : temperatuurrdfs:label : temperaturerdfs:label : 温度</para>
    ///   <para>rdfs:comment : Temperature is the extent to which an object is hot.</para>
    ///   <para>oum:alternativeSymbol : θ^^xsd:stringoum:alternativeSymbol : t^^xsd:string</para>
    ///   <para>oum:unofficialAbbreviation : temp^^xsd:string</para>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Temperature">oum:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>oum:unofficialLabel : heating rate^^xsd:string</para>
    ///   <para>rdfs:label : temperature raterdfs:label : temperatuur-rate</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TemperatureRate">oum:TemperatureRate</a>
    /// </summary>
    let TemperatureRate = _prefixId.prefix "TemperatureRate"
    /// <summary>
    ///   <para>rdfs:label : temperature rate unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TemperatureRateUnit">oum:TemperatureRateUnit</a>
    /// </summary>
    let TemperatureRateUnit = _prefixId.prefix "TemperatureRateUnit"
    /// <summary>
    ///   <para>rdfs:label : temperature unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TemperatureUnit">oum:TemperatureUnit</a>
    /// </summary>
    let TemperatureUnit = _prefixId.prefix "TemperatureUnit"
    let Temperature_scale = _prefixId.prefix "Temperature_scale"
    /// <summary>
    ///   <para>rdfs:label : thermische geleidbaarheidrdfs:label : thermal conductivity</para>
    ///   <para>oum:symbol : κ^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : k^^xsd:stringoum:alternativeSymbol : λ^^xsd:stringoum:alternativeSymbol : K^^xsd:string</para>
    ///   <para>rdfs:comment : Termal conductivity indicates the ability of a material to conduct heat.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalConductivity">oum:ThermalConductivity</a>
    /// </summary>
    let ThermalConductivity = _prefixId.prefix "ThermalConductivity"
    /// <summary>
    ///   <para>rdfs:label : thermal conductivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalConductivityUnit">oum:ThermalConductivityUnit</a>
    /// </summary>
    let ThermalConductivityUnit = _prefixId.prefix "ThermalConductivityUnit"
    /// <summary>
    ///   <para>rdfs:label : thermal diffusivity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalDiffusivity">oum:ThermalDiffusivity</a>
    /// </summary>
    let ThermalDiffusivity = _prefixId.prefix "ThermalDiffusivity"
    /// <summary>
    ///   <para>rdfs:label : thermal diffusivity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalDiffusivityUnit">oum:ThermalDiffusivityUnit</a>
    /// </summary>
    let ThermalDiffusivityUnit = _prefixId.prefix "ThermalDiffusivityUnit"
    /// <summary>
    ///   <para>rdfs:label : thermal insulance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalInsulance">oum:ThermalInsulance</a>
    /// </summary>
    let ThermalInsulance = _prefixId.prefix "ThermalInsulance"
    /// <summary>
    ///   <para>rdfs:label : thermal insulance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalInsulanceUnit">oum:ThermalInsulanceUnit</a>
    /// </summary>
    let ThermalInsulanceUnit = _prefixId.prefix "ThermalInsulanceUnit"
    /// <summary>
    ///   <para>rdfs:label : thermal resistance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalResistance">oum:ThermalResistance</a>
    /// </summary>
    let ThermalResistance = _prefixId.prefix "ThermalResistance"
    /// <summary>
    ///   <para>rdfs:label : thermal resistance unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermalResistanceUnit">oum:ThermalResistanceUnit</a>
    /// </summary>
    let ThermalResistanceUnit = _prefixId.prefix "ThermalResistanceUnit"
    /// <summary>
    ///   <para>rdfs:label : thermodynamic temperaturerdfs:label : absolute temperatuur</para>
    ///   <para>oum:alternativeLabel : thermodynamische temperatuur</para>
    ///   <para>rdfs:comment : Thermodynamic temperature is the absolute measure of temperature. Its zero point is the temperature at which the particle constituents of matter have minimal motion and can be no colder. Thermodynamic temperature is a base quantity in the International System of Units.</para>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermodynamicTemperature">oum:ThermodynamicTemperature</a>
    /// </summary>
    let ThermodynamicTemperature = _prefixId.prefix "ThermodynamicTemperature"
    /// <summary>
    ///   <para>rdfs:label : thermodynamic temperature scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermodynamicTemperatureScale">oum:ThermodynamicTemperatureScale</a>
    /// </summary>
    let ThermodynamicTemperatureScale = _prefixId.prefix "ThermodynamicTemperatureScale"
    /// <summary>
    ///   <para>rdfs:label : thermodynamic temperature unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThermodynamicTemperatureUnit">oum:ThermodynamicTemperatureUnit</a>
    /// </summary>
    let ThermodynamicTemperatureUnit = _prefixId.prefix "ThermodynamicTemperatureUnit"
    /// <summary>
    ///   <para>rdfs:label : dikterdfs:label : thickness</para>
    ///   <para>oum:alternativeSymbol : δ^^xsd:string</para>
    ///   <para>oum:symbol : d^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Thickness">oum:Thickness</a>
    /// </summary>
    let Thickness = _prefixId.prefix "Thickness"
    /// <summary>
    ///   <para>rdfs:label : thrustrdfs:label : stuwkracht</para>
    ///   <para>rdfs:comment : Thrust is a reaction force that is caused by an accelerated mass expelled by a system in one direction.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Thrust">oum:Thrust</a>
    /// </summary>
    let Thrust = _prefixId.prefix "Thrust"
    /// <summary>
    ///   <para>rdfs:label : Thuan and Gunn magnitude</para>
    ///   <para>rdfs:comment : A magnitude measured in one of Thuan and Gunn's standard passbands (using a standard filter, i.e. g).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ThuanAndGunnMagnitude">oum:ThuanAndGunnMagnitude</a>
    /// </summary>
    let ThuanAndGunnMagnitude = _prefixId.prefix "ThuanAndGunnMagnitude"
    /// <summary>
    ///   <para>rdfs:comment : Time is a base quantity in the International System of Units and other systems of units. It is measured by numbers of repetitions of cyclical events.</para>
    ///   <para>rdfs:label : 时间rdfs:label : timerdfs:label : tijd</para>
    ///   <para>oum:symbol : t^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Time">oum:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>oum:symbol : τ^^xsd:string</para>
    ///   <para>rdfs:label : time constant</para>
    ///   <para>rdfs:comment : Time required to approach (1-1/e) of the final output value of a detector (about 63%) (Kitchin, Astrophysical Techniques, IoP, Table 1.1.2).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TimeConstant">oum:TimeConstant</a>
    /// </summary>
    let TimeConstant = _prefixId.prefix "TimeConstant"
    /// <summary>
    ///   <para>rdfs:label : time unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TimeUnit">oum:TimeUnit</a>
    /// </summary>
    let TimeUnit = _prefixId.prefix "TimeUnit"
    /// <summary>
    ///   <para>oum:unofficialLabel : top weight^^xsd:string</para>
    ///   <para>rdfs:label : top mass</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TopMass">oum:TopMass</a>
    /// </summary>
    let TopMass = _prefixId.prefix "TopMass"
    /// <summary>
    ///   <para>rdfs:label : 扭矩rdfs:label : torquerdfs:label : koppel</para>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <para>rdfs:comment : Torque is the effectiveness of a force to produce rotation about an axis, measured by the product of the force and the perpendicular distance from the line of action of the force to the axis.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Torque">oum:Torque</a>
    /// </summary>
    let Torque = _prefixId.prefix "Torque"
    /// <summary>
    ///   <para>rdfs:label : torque unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TorqueUnit">oum:TorqueUnit</a>
    /// </summary>
    let TorqueUnit = _prefixId.prefix "TorqueUnit"
    /// <summary>
    ///   <para>rdfs:label : total 3D start-end distance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Total3DStartEndDistance">oum:Total3DStartEndDistance</a>
    /// </summary>
    let Total3DStartEndDistance = _prefixId.prefix "Total3DStartEndDistance"
    /// <summary>
    ///   <para>oum:symbol : Ω_T^^xsd:string</para>
    ///   <para>rdfs:label : total density parameter</para>
    ///   <para>rdfs:comment : The total density parameter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TotalDensityParameter">oum:TotalDensityParameter</a>
    /// </summary>
    let TotalDensityParameter = _prefixId.prefix "TotalDensityParameter"
    /// <summary>
    ///   <para>rdfs:label : total distance travelled</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TotalDistanceTravelled">oum:TotalDistanceTravelled</a>
    /// </summary>
    let TotalDistanceTravelled = _prefixId.prefix "TotalDistanceTravelled"
    /// <summary>
    ///   <para>oum:alternativeLabel : #buds</para>
    ///   <para>rdfs:label : total number budsrdfs:label : totaal aantal knoppen</para>
    ///   <para>rdfs:comment : Totaal aantal knoppen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TotalNumberBuds">oum:TotalNumberBuds</a>
    /// </summary>
    let TotalNumberBuds = _prefixId.prefix "TotalNumberBuds"
    /// <summary>
    ///   <para>oum:alternativeLabel : #flowers</para>
    ///   <para>rdfs:label : total number flowersrdfs:label : totaal aantal bloemen</para>
    ///   <para>rdfs:comment : Totaal aantal bloemen.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TotalNumberFlowers">oum:TotalNumberFlowers</a>
    /// </summary>
    let TotalNumberFlowers = _prefixId.prefix "TotalNumberFlowers"
    /// <summary>
    ///   <para>oum:alternativeLabel : #leaves</para>
    ///   <para>rdfs:label : total number leavesrdfs:label : totaal aantal bladeren</para>
    ///   <para>rdfs:comment : Totaal aantal bladeren.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TotalNumberLeaves">oum:TotalNumberLeaves</a>
    /// </summary>
    let TotalNumberLeaves = _prefixId.prefix "TotalNumberLeaves"
    /// <summary>
    ///   <para>rdfs:label : true distance modulus</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TrueDistanceModulus">oum:TrueDistanceModulus</a>
    /// </summary>
    let TrueDistanceModulus = _prefixId.prefix "TrueDistanceModulus"
    let TurkishLira = _prefixId.prefix "TurkishLira"
    /// <summary>
    ///   <para>rdfs:label : tween mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of tween in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TweenMassFraction">oum:TweenMassFraction</a>
    /// </summary>
    let TweenMassFraction = _prefixId.prefix "TweenMassFraction"
    /// <summary>
    ///   <para>oum:symbol : T^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m_T^^xsd:string</para>
    ///   <para>rdfs:label : Tycho broadband magnitude</para>
    ///   <para>rdfs:comment : Broadband Tycho magnitude (formed from B and V magintude measurements.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/TychoBroadbandMagnitude">oum:TychoBroadbandMagnitude</a>
    /// </summary>
    let TychoBroadbandMagnitude = _prefixId.prefix "TychoBroadbandMagnitude"
    /// <summary>
    ///   <para>oum:alternativeSymbol : m_U^^xsd:string</para>
    ///   <para>rdfs:comment : Johnson U magnitude. The Johnson U band is a standard passband in the ultraviolet area. The central wavelength is 365nm and the bandwidth is 70nm.  The filter to be used is the Corning 9863 filter.</para>
    ///   <para>rdfs:label : U magnitude</para>
    ///   <para>oum:symbol : U^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/UMagnitude">oum:UMagnitude</a>
    /// </summary>
    let UMagnitude = _prefixId.prefix "UMagnitude"
    /// <summary>
    ///   <para>oum:alternativeLabel : unit of measureoum:alternativeLabel : 測定単位oum:alternativeLabel : unit of measurementoum:alternativeLabel : 測定の単位</para>
    ///   <para>rdfs:label : unitrdfs:label : 単位</para>
    ///   <para>rdfs:comment : A unit of measure is a definite magnitude of a quantity, defined and adopted by convention or by law. It is used as a standard for measurement of the same quantity, where any other value of the quantity can be expressed as a simple multiple of the unit. For example, length is a quantity; the metre is a unit of length that represents a definite predetermined length. When we say 10 metre (or 10 m), we actually mean 10 times the definite predetermined length called "metre".rdfs:comment : 測定単位とは，量の確定的な大きさであり，慣例又は法律によって定義し採用されている。同じ量の測定の標準として用いられ，他の如何なる量の値も当該単位の単純な倍数として表わせる。例えば，長さも量である; メートルは長さの単位であり，確定的な所定の長さを表している。10メートル（又は10 m）とは，「メートル」と呼ばれる確定的な所定の長さの10倍を，実際に意味している。</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Unit">oum:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : unit division</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/UnitDivision">oum:UnitDivision</a>
    /// </summary>
    let UnitDivision = _prefixId.prefix "UnitDivision"
    /// <summary>
    ///   <para>rdfs:label : unit exponentiation</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/UnitExponentiation">oum:UnitExponentiation</a>
    /// </summary>
    let UnitExponentiation = _prefixId.prefix "UnitExponentiation"
    /// <summary>
    ///   <para>rdfs:label : unit multiplerdfs:label : 単位倍量</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/UnitMultiple">oum:UnitMultiple</a>
    /// </summary>
    let UnitMultiple = _prefixId.prefix "UnitMultiple"
    /// <summary>
    ///   <para>rdfs:label : unit multiplicationrdfs:label : 単位乗算</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/UnitMultiplication">oum:UnitMultiplication</a>
    /// </summary>
    let UnitMultiplication = _prefixId.prefix "UnitMultiplication"
    let UnitedStatesDollar = _prefixId.prefix "UnitedStatesDollar"
    /// <summary>
    ///   <para>oum:symbol : A_V^^xsd:string</para>
    ///   <para>rdfs:label : V amplitude</para>
    ///   <para>rdfs:comment : Amplitude of the light variation in Johnson V magnitude. The Johnson V band is a standard passband in the visual area, matching the response curve of the human eye. The central wavelength is 550nm and the bandwidth is 90nm.  The filter to be used is the Corning 3384 filter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VAmplitude">oum:VAmplitude</a>
    /// </summary>
    let VAmplitude = _prefixId.prefix "VAmplitude"
    /// <summary>
    ///   <para>oum:symbol : V^^xsd:string</para>
    ///   <para>rdfs:comment : Johnson V magnitude. The Johnson V band is a standard passband in the visual area, matching the response curve of the human eye. The central wavelength is 550nm and the bandwidth is 90nm.  The filter to be used is the Corning 3384 filter.</para>
    ///   <para>oum:alternativeSymbol : m_V^^xsd:string</para>
    ///   <para>rdfs:label : V magnitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VMagnitude">oum:VMagnitude</a>
    /// </summary>
    let VMagnitude = _prefixId.prefix "VMagnitude"
    /// <summary>
    ///   <para>oum:symbol : V_max^^xsd:string</para>
    ///   <para>rdfs:label : V magnitude at maximum brightness</para>
    ///   <para>rdfs:comment : Johnson V magnitude (apparent) at maximum brightness (i.e. for a variable star). The Johnson V band is a standard filter in the visual area, matching the response curve of the human eye. The central wavelength is 550nm and the bandwidth is 90nm.  The filter to be used is the Corning 3384 filter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VMagnitudeAtMaximumBrightness">oum:VMagnitudeAtMaximumBrightness</a>
    /// </summary>
    let VMagnitudeAtMaximumBrightness = _prefixId.prefix "VMagnitudeAtMaximumBrightness"
    /// <summary>
    ///   <para>oum:symbol : V_min^^xsd:string</para>
    ///   <para>rdfs:label : V magnitude at minimum brightness</para>
    ///   <para>rdfs:comment : Johnson V magnitude (apparent) at minimum brightness (i.e. for a variable star). The Johnson V band is a standard filter in the visual area, matching the response curve of the human eye. The central wavelength is 550nm and the bandwidth is 90nm.  The filter to be used is the Corning 3384 filter.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VMagnitudeAtMinimumBrightness">oum:VMagnitudeAtMinimumBrightness</a>
    /// </summary>
    let VMagnitudeAtMinimumBrightness = _prefixId.prefix "VMagnitudeAtMinimumBrightness"
    /// <summary>
    ///   <para>oum:alternativeLabel : vascular</para>
    ///   <para>rdfs:label : vascular browning</para>
    ///   <para>rdfs:comment : Voorbeeld avocado Hass: poster (code).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VascularBrowning">oum:VascularBrowning</a>
    /// </summary>
    let VascularBrowning = _prefixId.prefix "VascularBrowning"
    /// <summary>
    ///   <para>rdfs:label : vase liferdfs:label : vaasleven</para>
    ///   <para>rdfs:comment : Aantal dagen op de vaas tot onvoldoende.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VaseLife">oum:VaseLife</a>
    /// </summary>
    let VaseLife = _prefixId.prefix "VaseLife"
    /// <summary>
    ///   <para>oum:alternativeLabel : vase plus water weightoum:alternativeLabel : weight vase</para>
    ///   <para>rdfs:label : vase plus water massrdfs:label : vaas- plus watermassa</para>
    ///   <para>rdfs:comment : Gewicht vaas plus water.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VasePlusWaterMass">oum:VasePlusWaterMass</a>
    /// </summary>
    let VasePlusWaterMass = _prefixId.prefix "VasePlusWaterMass"
    /// <summary>
    ///   <para>oum:alternativeLabel : vase plus water plus flower weightoum:alternativeLabel : weight flo and vase</para>
    ///   <para>rdfs:label : vase plus water plus flower massrdfs:label : vaas- plus water- plus bloemmassa</para>
    ///   <para>rdfs:comment : Gewicht vaas plus water plus bloem (= steel plus blad plus bloem).</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VasePlusWaterPlusFlowerMass">oum:VasePlusWaterPlusFlowerMass</a>
    /// </summary>
    let VasePlusWaterPlusFlowerMass = _prefixId.prefix "VasePlusWaterPlusFlowerMass"
    /// <summary>
    ///   <para>oum:symbol : u^^xsd:string</para>
    ///   <para>rdfs:comment : Velocity is the rate of change of position.</para>
    ///   <para>oum:alternativeSymbol : w^^xsd:stringoum:alternativeSymbol : v^^xsd:string</para>
    ///   <para>rdfs:label : velocityrdfs:label : snelheid (vector)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Velocity">oum:Velocity</a>
    /// </summary>
    let Velocity = _prefixId.prefix "Velocity"
    /// <summary>
    ///   <para>rdfs:label : visual albedo</para>
    ///   <para>rdfs:comment : The albedo only for radiation in the visual part of the spectrum.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VisualAlbedo">oum:VisualAlbedo</a>
    /// </summary>
    let VisualAlbedo = _prefixId.prefix "VisualAlbedo"
    /// <summary>
    ///   <para>oum:symbol : V^^xsd:string</para>
    ///   <para>rdfs:comment : Volume is a measure of how much three-dimensional space any phenomenon occupies. It is a derived quantity in the International System of Units. Volume is length to the power 3.</para>
    ///   <para>rdfs:label : volumerdfs:label : volumerdfs:label : 体积</para>
    ///   <para>oum:alternativeSymbol : v^^xsd:string</para>
    ///   <para>oum:alternativeLabel : inhoud</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Volume">oum:Volume</a>
    /// </summary>
    let Volume = _prefixId.prefix "Volume"
    /// <summary>
    ///   <para>oum:alternativeLabel : concentration (v/v)</para>
    ///   <para>rdfs:label : volumefractierdfs:label : volume fraction</para>
    ///   <para>oum:symbol : φ^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumeFraction">oum:VolumeFraction</a>
    /// </summary>
    let VolumeFraction = _prefixId.prefix "VolumeFraction"
    /// <summary>
    ///   <para>rdfs:label : volume fraction unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumeFractionUnit">oum:VolumeFractionUnit</a>
    /// </summary>
    let VolumeFractionUnit = _prefixId.prefix "VolumeFractionUnit"
    /// <summary>
    ///   <para>oum:symbol : θ^^xsd:string</para>
    ///   <para>oum:alternativeLabel : bulk strain</para>
    ///   <para>rdfs:label : volume strain</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumeStrain">oum:VolumeStrain</a>
    /// </summary>
    let VolumeStrain = _prefixId.prefix "VolumeStrain"
    /// <summary>
    ///   <para>rdfs:label : volume unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumeUnit">oum:VolumeUnit</a>
    /// </summary>
    let VolumeUnit = _prefixId.prefix "VolumeUnit"

    /// <summary>
    ///   <para>rdfs:label : coliform bacteria count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricColiformBacterieCount">oum:VolumetricColiformBacterieCount</a>
    /// </summary>
    let VolumetricColiformBacterieCount = _prefixId.prefix "VolumetricColiformBacterieCount"

    /// <summary>
    ///   <para>rdfs:label : Corynebacterium bovis count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricCorynebacteriumBovisCount">oum:VolumetricCorynebacteriumBovisCount</a>
    /// </summary>
    let VolumetricCorynebacteriumBovisCount = _prefixId.prefix "VolumetricCorynebacteriumBovisCount"

    /// <summary>
    ///   <para>oum:alternativeLabel : Arcanobacterium count (volumetric)</para>
    ///   <para>rdfs:label : Corynebacterium count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricCorynebacteriumCount">oum:VolumetricCorynebacteriumCount</a>
    /// </summary>
    let VolumetricCorynebacteriumCount = _prefixId.prefix "VolumetricCorynebacteriumCount"

    /// <summary>
    ///   <para>rdfs:label : Enterobacteriaceae count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricEnterobacteriaceaeCount">oum:VolumetricEnterobacteriaceaeCount</a>
    /// </summary>
    let VolumetricEnterobacteriaceaeCount = _prefixId.prefix "VolumetricEnterobacteriaceaeCount"

    /// <summary>
    ///   <para>rdfs:label : Enterococcus count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricEnterococcusCount">oum:VolumetricEnterococcusCount</a>
    /// </summary>
    let VolumetricEnterococcusCount = _prefixId.prefix "VolumetricEnterococcusCount"

    /// <summary>
    ///   <para>rdfs:label : Escherichia coli count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricEscherichiaColiCount">oum:VolumetricEscherichiaColiCount</a>
    /// </summary>
    let VolumetricEscherichiaColiCount = _prefixId.prefix "VolumetricEscherichiaColiCount"

    /// <summary>
    ///   <para>oum:alternativeLabel : volume flowoum:alternativeLabel : flow rateoum:alternativeLabel : volume flow rate</para>
    ///   <para>rdfs:label : volumetric flow rate</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricFlowRate">oum:VolumetricFlowRate</a>
    /// </summary>
    let VolumetricFlowRate = _prefixId.prefix "VolumetricFlowRate"
    /// <summary>
    ///   <para>rdfs:label : volumetric flow rate unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricFlowRateUnit">oum:VolumetricFlowRateUnit</a>
    /// </summary>
    let VolumetricFlowRateUnit = _prefixId.prefix "VolumetricFlowRateUnit"
    /// <summary>
    ///   <para>rdfs:label : volumetric heat capacity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricHeatCapacity">oum:VolumetricHeatCapacity</a>
    /// </summary>
    let VolumetricHeatCapacity = _prefixId.prefix "VolumetricHeatCapacity"
    /// <summary>
    ///   <para>rdfs:label : volumetric heat capacity unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricHeatCapacityUnit">oum:VolumetricHeatCapacityUnit</a>
    /// </summary>
    let VolumetricHeatCapacityUnit = _prefixId.prefix "VolumetricHeatCapacityUnit"
    /// <summary>
    ///   <para>rdfs:label : Klebsiella count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricKlebsiellaCount">oum:VolumetricKlebsiellaCount</a>
    /// </summary>
    let VolumetricKlebsiellaCount = _prefixId.prefix "VolumetricKlebsiellaCount"

    /// <summary>
    ///   <para>rdfs:label : Listeria monocytogenes count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricListeriaMonocytogenesCount">oum:VolumetricListeriaMonocytogenesCount</a>
    /// </summary>
    let VolumetricListeriaMonocytogenesCount = _prefixId.prefix "VolumetricListeriaMonocytogenesCount"

    /// <summary>
    ///   <para>rdfs:label : Salmonella count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricSalmonellaCount">oum:VolumetricSalmonellaCount</a>
    /// </summary>
    let VolumetricSalmonellaCount = _prefixId.prefix "VolumetricSalmonellaCount"

    /// <summary>
    ///   <para>rdfs:label : Serratia marcescens count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricSerratiaMarcescensCount">oum:VolumetricSerratiaMarcescensCount</a>
    /// </summary>
    let VolumetricSerratiaMarcescensCount = _prefixId.prefix "VolumetricSerratiaMarcescensCount"

    /// <summary>
    ///   <para>rdfs:label : Staphylococcus aureus count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricStaphylococcusAureusCount">oum:VolumetricStaphylococcusAureusCount</a>
    /// </summary>
    let VolumetricStaphylococcusAureusCount = _prefixId.prefix "VolumetricStaphylococcusAureusCount"

    /// <summary>
    ///   <para>rdfs:label : Streptococcus agalactiae count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricStreptococcusAgalactiaeCount">oum:VolumetricStreptococcusAgalactiaeCount</a>
    /// </summary>
    let VolumetricStreptococcusAgalactiaeCount = _prefixId.prefix "VolumetricStreptococcusAgalactiaeCount"

    /// <summary>
    ///   <para>rdfs:label : Streptococcus dysgalactiae count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricStreptococcusDysgalactiaeCount">oum:VolumetricStreptococcusDysgalactiaeCount</a>
    /// </summary>
    let VolumetricStreptococcusDysgalactiaeCount = _prefixId.prefix "VolumetricStreptococcusDysgalactiaeCount"

    /// <summary>
    ///   <para>rdfs:label : Streptococcus uberis count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricStreptococcusUberisCount">oum:VolumetricStreptococcusUberisCount</a>
    /// </summary>
    let VolumetricStreptococcusUberisCount = _prefixId.prefix "VolumetricStreptococcusUberisCount"

    /// <summary>
    ///   <para>rdfs:label : viable count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricViableCount">oum:VolumetricViableCount</a>
    /// </summary>
    let VolumetricViableCount = _prefixId.prefix "VolumetricViableCount"
    /// <summary>
    ///   <para>rdfs:label : volumetric viable count unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricViableCountUnit">oum:VolumetricViableCountUnit</a>
    /// </summary>
    let VolumetricViableCountUnit = _prefixId.prefix "VolumetricViableCountUnit"
    /// <summary>
    ///   <para>rdfs:label : yeast and fungi count (volumetric)</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/VolumetricYeastAndFungiCount">oum:VolumetricYeastAndFungiCount</a>
    /// </summary>
    let VolumetricYeastAndFungiCount = _prefixId.prefix "VolumetricYeastAndFungiCount"
    /// <summary>
    ///   <para>rdfs:label : water mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of water in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WaterMassFraction">oum:WaterMassFraction</a>
    /// </summary>
    let WaterMassFraction = _prefixId.prefix "WaterMassFraction"
    /// <summary>
    ///   <para>oum:symbol : λ^^xsd:string</para>
    ///   <para>rdfs:label : golflengterdfs:label : wavelength</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Wavelength">oum:Wavelength</a>
    /// </summary>
    let Wavelength = _prefixId.prefix "Wavelength"
    /// <summary>
    ///   <para>oum:symbol : σ^^xsd:string</para>
    ///   <para>rdfs:label : wavenumberrdfs:label : golfgetal</para>
    ///   <para>rdfs:comment : Wavenumber is the number of repeating units of a propagating wave (the number of times a wave has the same phase) per unit of space.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Wavenumber">oum:Wavenumber</a>
    /// </summary>
    let Wavenumber = _prefixId.prefix "Wavenumber"
    /// <summary>
    ///   <para>rdfs:label : wave number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WavenumberUnit">oum:WavenumberUnit</a>
    /// </summary>
    let WavenumberUnit = _prefixId.prefix "WavenumberUnit"
    /// <summary>
    ///   <para>oum:symbol : We^^xsd:string</para>
    ///   <para>rdfs:label : Weber numberrdfs:label : getal van Weber</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WeberNumber">oum:WeberNumber</a>
    /// </summary>
    let WeberNumber = _prefixId.prefix "WeberNumber"
    /// <summary>
    ///   <para>rdfs:label : Weber number unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WeberNumberUnit">oum:WeberNumberUnit</a>
    /// </summary>
    let WeberNumberUnit = _prefixId.prefix "WeberNumberUnit"
    /// <summary>
    ///   <para>rdfs:label : gewichtrdfs:label : weight</para>
    ///   <para>oum:alternativeSymbol : P^^xsd:stringoum:alternativeSymbol : W^^xsd:string</para>
    ///   <para>oum:symbol : G^^xsd:string</para>
    ///   <para>rdfs:comment : Weight is a force that attracts a body towards another (reference) body.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Weight">oum:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>rdfs:label : wetting angle</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WettingAngle">oum:WettingAngle</a>
    /// </summary>
    let WettingAngle = _prefixId.prefix "WettingAngle"

    /// <summary>
    ///   <para>rdfs:label : whey protein aggregate mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of whey protein aggregate in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WheyProteinAggregateMassFraction">oum:WheyProteinAggregateMassFraction</a>
    /// </summary>
    let WheyProteinAggregateMassFraction = _prefixId.prefix "WheyProteinAggregateMassFraction"

    /// <summary>
    ///   <para>rdfs:label : whey protein beads mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of whey protein beads in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WheyProteinBeadsMassFraction">oum:WheyProteinBeadsMassFraction</a>
    /// </summary>
    let WheyProteinBeadsMassFraction = _prefixId.prefix "WheyProteinBeadsMassFraction"
    /// <summary>
    ///   <para>rdfs:label : whey protein mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of whey protein in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WheyProteinMassFraction">oum:WheyProteinMassFraction</a>
    /// </summary>
    let WheyProteinMassFraction = _prefixId.prefix "WheyProteinMassFraction"
    /// <summary>
    ///   <para>oum:symbol : m^^xsd:string</para>
    ///   <para>rdfs:label : white light magnitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WhiteLightMagnitude">oum:WhiteLightMagnitude</a>
    /// </summary>
    let WhiteLightMagnitude = _prefixId.prefix "WhiteLightMagnitude"

    /// <summary>
    ///   <para>oum:symbol : m_max^^xsd:string</para>
    ///   <para>rdfs:label : white light magnitude at maximum brightness</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WhiteLightMagnitudeAtMaximumBrightness">oum:WhiteLightMagnitudeAtMaximumBrightness</a>
    /// </summary>
    let WhiteLightMagnitudeAtMaximumBrightness = _prefixId.prefix "WhiteLightMagnitudeAtMaximumBrightness"

    /// <summary>
    ///   <para>oum:symbol : m_min^^xsd:string</para>
    ///   <para>rdfs:label : white light magnitude at minimum brightness</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/WhiteLightMagnitudeAtMinimumBrightness">oum:WhiteLightMagnitudeAtMinimumBrightness</a>
    /// </summary>
    let WhiteLightMagnitudeAtMinimumBrightness = _prefixId.prefix "WhiteLightMagnitudeAtMinimumBrightness"

    /// <summary>
    ///   <para>rdfs:label : widthrdfs:label : breedte</para>
    ///   <para>oum:symbol : w^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Width">oum:Width</a>
    /// </summary>
    let Width = _prefixId.prefix "Width"
    /// <summary>
    ///   <para>oum:alternativeSymbol : A^^xsd:string</para>
    ///   <para>rdfs:comment : Work is the energy when a force acts against resistance to produce motion in a body.</para>
    ///   <para>rdfs:label : 工作rdfs:label : arbeidrdfs:label : work</para>
    ///   <para>oum:symbol : W^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/Work">oum:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : xanthan mass fraction</para>
    ///   <para>rdfs:comment : The fraction of the mass of xanthan in a phenomenon</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/XanthanMassFraction">oum:XanthanMassFraction</a>
    /// </summary>
    let XanthanMassFraction = _prefixId.prefix "XanthanMassFraction"
    /// <summary>
    ///   <para>oum:alternativeLabel : zenith angleoum:alternativeLabel : zenithoek</para>
    ///   <para>rdfs:label : zenitafstandrdfs:label : zenith distance</para>
    ///   <para>rdfs:comment : The angular distance on the celestial sphere measured along the great circle from the zenith to the celestial object. z = 90° - h.</para>
    ///   <para>oum:symbol : z^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/ZenithDistance">oum:ZenithDistance</a>
    /// </summary>
    let ZenithDistance = _prefixId.prefix "ZenithDistance"

    let __189'_period_'3442OnTheCelsiusScale = _prefixId.prefix "_-189.3442OnTheCelsiusScale"

    let __218'_period_'7916OnTheCelsiusScale = _prefixId.prefix "_-218.7916OnTheCelsiusScale"

    let __248'_period_'5939OnTheCelsiusScale = _prefixId.prefix "_-248.5939OnTheCelsiusScale"

    let __259'_period_'3467OnTheCelsiusScale = _prefixId.prefix "_-259.3467OnTheCelsiusScale"

    let __270'_period_'15To_268'_period_'15OnTheCelsiusScale = _prefixId.prefix "_-270.15To-268.15OnTheCelsiusScale"

    let __38'_period_'8344OnTheCelsiusScale = _prefixId.prefix "_-38.8344OnTheCelsiusScale"

    let _0_100 = _prefixId.prefix "_0-100"
    let _0_5 = _prefixId.prefix "_0-5"
    let _0'_period_'01OnTheCelsiusScale = _prefixId.prefix "_0.01OnTheCelsiusScale"
    let _1_0 = _prefixId.prefix "_1-0"
    let _1_10 = _prefixId.prefix "_1-10"
    let _1_5 = _prefixId.prefix "_1-5"
    let _1000ColonyFormingUnit = _prefixId.prefix "_1000ColonyFormingUnit"

    let _1000ColonyFormingUnitPerMillilitre = _prefixId.prefix "_1000ColonyFormingUnitPerMillilitre"

    let _100Kilometre = _prefixId.prefix "_100Kilometre"

    /// <summary>
    ///   <para>oum:symbol : m_L1040^^xsd:string</para>
    ///   <para>rdfs:label : 1040 nm Lockwood magnitude</para>
    ///   <para>rdfs:comment : A magnitude in the 1.04 micrometre band of the photometric system introduced by G.W. Lockwood.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/_1040NanometreLockwoodMagnitude">oum:_1040NanometreLockwoodMagnitude</a>
    /// </summary>
    let _1040NanometreLockwoodMagnitude = _prefixId.prefix "_1040NanometreLockwoodMagnitude"

    let _1064'_period_'18OnTheCelsiusScale = _prefixId.prefix "_1064.18OnTheCelsiusScale"

    let _1084'_period_'62OnTheCelsiusScale = _prefixId.prefix "_1084.62OnTheCelsiusScale"

    let _1234'_period_'93OnTheKelvinScale = _prefixId.prefix "_1234.93OnTheKelvinScale"

    let _127316OfTheThermodynamicTemperatureOfTheTriplePointOfWater = _prefixId.prefix "_127316OfTheThermodynamicTemperatureOfTheTriplePointOfWater"

    let _13'_period_'8033OnTheKelvinScale = _prefixId.prefix "_13.8033OnTheKelvinScale"
    let _1337'_period_'33OnTheKelvinScale = _prefixId.prefix "_1337.33OnTheKelvinScale"
    let _1357'_period_'77OnTheKelvinScale = _prefixId.prefix "_1357.77OnTheKelvinScale"

    let _156'_period_'5985OnTheCelsiusScale = _prefixId.prefix "_156.5985OnTheCelsiusScale"

    let _231'_period_'928OnTheCelsiusScale = _prefixId.prefix "_231.928OnTheCelsiusScale"

    let _234'_period_'3156OnTheKelvinScale = _prefixId.prefix "_234.3156OnTheKelvinScale"

    let _24'_period_'5561OnTheKelvinScale = _prefixId.prefix "_24.5561OnTheKelvinScale"
    let _25Millilitre = _prefixId.prefix "_25Millilitre"
    let _273'_period_'16OnTheKelvinScale = _prefixId.prefix "_273.16OnTheKelvinScale"

    let _29'_period_'7646OnTheCelsiusScale = _prefixId.prefix "_29.7646OnTheCelsiusScale"

    let _302'_period_'9146OnTheKelvinScale = _prefixId.prefix "_302.9146OnTheKelvinScale"

    let _3To5OnTheKelvinScale = _prefixId.prefix "_3To5OnTheKelvinScale"

    let _419'_period_'527OnTheCelsiusScale = _prefixId.prefix "_419.527OnTheCelsiusScale"

    let _429'_period_'7485OnTheKelvinScale = _prefixId.prefix "_429.7485OnTheKelvinScale"

    let _505'_period_'078OnTheKelvinScale = _prefixId.prefix "_505.078OnTheKelvinScale"
    let _54'_period_'3584OnTheKelvinScale = _prefixId.prefix "_54.3584OnTheKelvinScale"

    let _660'_period_'323OnTheCelsiusScale = _prefixId.prefix "_660.323OnTheCelsiusScale"

    let _692'_period_'677OnTheKelvinScale = _prefixId.prefix "_692.677OnTheKelvinScale"
    let _83'_period_'8058OnTheKelvinScale = _prefixId.prefix "_83.8058OnTheKelvinScale"

    let _9192631770PeriodsOfTheRadiationCorrespondingToTheTransitionBetweenTheTwoHyperfineLevelsOfTheGroundStateOfTheCesium133Atom =
        _prefixId.prefix "_9192631770PeriodsOfTheRadiationCorrespondingToTheTransitionBetweenTheTwoHyperfineLevelsOfTheGroundStateOfTheCesium133Atom"

    let _933'_period_'473OnTheKelvinScale = _prefixId.prefix "_933.473OnTheKelvinScale"
    let _961'_period_'78OnTheCelsiusScale = _prefixId.prefix "_961.78OnTheCelsiusScale"
    let abampere = _prefixId.prefix "abampere"
    /// <summary>
    ///   <para>oum:alternativeLabel : has abbreviationoum:alternativeLabel : 略記がある</para>
    ///   <para>rdfs:label : abbreviationrdfs:label : 略記</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/abbreviation">oum:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    let abcoulomb = _prefixId.prefix "abcoulomb"
    let abfarad = _prefixId.prefix "abfarad"
    let abhenry = _prefixId.prefix "abhenry"
    let abmho = _prefixId.prefix "abmho"
    let abohm = _prefixId.prefix "abohm"
    let absorbedDoseRate_Dimension = _prefixId.prefix "absorbedDoseRate-Dimension"
    let abvolt = _prefixId.prefix "abvolt"
    let acceleration_Dmension = _prefixId.prefix "acceleration-Dmension"
    let acre_International = _prefixId.prefix "acre-International"
    let acre_USSurvey = _prefixId.prefix "acre-USSurvey"
    let acreFoot = _prefixId.prefix "acreFoot"

    let actionOrAngularMomentum_Dimension = _prefixId.prefix "actionOrAngularMomentum-Dimension"

    /// <summary>
    ///   <para>oum:alternativeLabel : has alternative LaTeX symboloum:alternativeLabel : alternative LaTeX formatted symbol</para>
    ///   <para>rdfs:label : alternative LaTeX symbol</para>
    ///   <para>rdfs:comment : An alternative OMLaTeX formatted symbol, which may include commands such as \unit and \E as defined in OMLaTeX.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/alternativeLaTeXSymbol">oum:alternativeLaTeXSymbol</a>
    /// </summary>
    let alternativeLaTeXSymbol = _prefixId.prefix "alternativeLaTeXSymbol"
    /// <summary>
    ///   <para>rdfs:label : alternative labelrdfs:label : 標識の別名</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/alternativeLabel">oum:alternativeLabel</a>
    /// </summary>
    let alternativeLabel = _prefixId.prefix "alternativeLabel"
    /// <summary>
    ///   <para>oum:alternativeLabel : has alternative symboloum:alternativeLabel : 別の記号を持つ</para>
    ///   <para>rdfs:label : alternative symbolrdfs:label : 別の記号</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/alternativeSymbol">oum:alternativeSymbol</a>
    /// </summary>
    let alternativeSymbol = _prefixId.prefix "alternativeSymbol"
    let amountOfSubstance_Dimension = _prefixId.prefix "amountOfSubstance-Dimension"

    let amountOfSubstanceConcentration_Dimension = _prefixId.prefix "amountOfSubstanceConcentration-Dimension"

    let amountOfSubstanceOfASystemThatContainsAsManyElementaryEntitiesAsThereAreAtomsIn0'_period_'012KilogramOfCarbon12 =
        _prefixId.prefix "amountOfSubstanceOfASystemThatContainsAsManyElementaryEntitiesAsThereAreAtomsIn0.012KilogramOfCarbon12"

    let ampere = _prefixId.prefix "ampere"
    let amperePerMetre = _prefixId.prefix "amperePerMetre"
    let amperePerSquareMetre = _prefixId.prefix "amperePerSquareMetre"
    let amperePerVolt = _prefixId.prefix "amperePerVolt"
    let amperePerWatt = _prefixId.prefix "amperePerWatt"
    let amylaseUnit = _prefixId.prefix "amylaseUnit"
    let angstrom = _prefixId.prefix "angstrom"
    let angularAcceleration_Dmension = _prefixId.prefix "angularAcceleration-Dmension"
    let angularSpeed_Dimension = _prefixId.prefix "angularSpeed-Dimension"

    let approximately_252'_period_'85OnTheCelsiusScale = _prefixId.prefix "approximately-252.85OnTheCelsiusScale"

    let approximately_256'_period_'15OnTheCelsiusScale = _prefixId.prefix "approximately-256.15OnTheCelsiusScale"

    let approximately17OnTheKelvinScale = _prefixId.prefix "approximately17OnTheKelvinScale"

    let approximately203OnTheKelvinScale = _prefixId.prefix "approximately203OnTheKelvinScale"

    let are = _prefixId.prefix "are"
    let area_Dimension = _prefixId.prefix "area-Dimension"
    let astronomicalUnit = _prefixId.prefix "astronomicalUnit"
    let astronomyAndAstrophysics = _prefixId.prefix "astronomyAndAstrophysics"
    let atmosphere_Standard = _prefixId.prefix "atmosphere-Standard"
    let atmosphere_Technical = _prefixId.prefix "atmosphere-Technical"
    let atto = _prefixId.prefix "atto"
    let attoampere = _prefixId.prefix "attoampere"
    let attobecquerel = _prefixId.prefix "attobecquerel"
    let attocandela = _prefixId.prefix "attocandela"
    let attocoulomb = _prefixId.prefix "attocoulomb"
    let attodegreeCelsius = _prefixId.prefix "attodegreeCelsius"
    let attofarad = _prefixId.prefix "attofarad"
    let attogram = _prefixId.prefix "attogram"
    let attogramPerLitre = _prefixId.prefix "attogramPerLitre"
    let attogray = _prefixId.prefix "attogray"
    let attohenry = _prefixId.prefix "attohenry"
    let attohertz = _prefixId.prefix "attohertz"
    let attojoule = _prefixId.prefix "attojoule"
    let attokatal = _prefixId.prefix "attokatal"
    let attokelvin = _prefixId.prefix "attokelvin"
    let attolitre = _prefixId.prefix "attolitre"
    let attolumen = _prefixId.prefix "attolumen"
    let attolux = _prefixId.prefix "attolux"
    let attometre = _prefixId.prefix "attometre"
    let attometrePerSecond_Time = _prefixId.prefix "attometrePerSecond-Time"

    let attometrePerSecond_TimeSquared = _prefixId.prefix "attometrePerSecond-TimeSquared"

    let attomolair = _prefixId.prefix "attomolair"
    let attomole = _prefixId.prefix "attomole"
    let attomolePerLitre = _prefixId.prefix "attomolePerLitre"
    let attomolePerMetre = _prefixId.prefix "attomolePerMetre"
    let attonewton = _prefixId.prefix "attonewton"
    let attoohm = _prefixId.prefix "attoohm"
    let attopascal = _prefixId.prefix "attopascal"
    let attoradian = _prefixId.prefix "attoradian"
    let attosecond_Time = _prefixId.prefix "attosecond-Time"
    let attosecond_TimeSquared = _prefixId.prefix "attosecond-TimeSquared"
    let attosiemens = _prefixId.prefix "attosiemens"
    let attosievert = _prefixId.prefix "attosievert"
    let attosteradian = _prefixId.prefix "attosteradian"
    let attotesla = _prefixId.prefix "attotesla"
    let attovolt = _prefixId.prefix "attovolt"
    let attowatt = _prefixId.prefix "attowatt"
    let attoweber = _prefixId.prefix "attoweber"
    let average = _prefixId.prefix "average"
    /// <summary>
    ///   <para>rdfs:comment : b Magnitude in the Strömgren photometric system with a peak wavelength at 467 nm and a peak-half-width of 18 nm.</para>
    ///   <para>oum:alternativeSymbol : m_b^^xsd:string</para>
    ///   <para>oum:symbol : b^^xsd:string</para>
    ///   <para>rdfs:label : b magnitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/bMagnitude">oum:bMagnitude</a>
    /// </summary>
    let bMagnitude = _prefixId.prefix "bMagnitude"
    let bar = _prefixId.prefix "bar"
    let bar_Food = _prefixId.prefix "bar-Food"
    let barn = _prefixId.prefix "barn"
    let barrel_US = _prefixId.prefix "barrel-US"
    let barye = _prefixId.prefix "barye"
    let baud = _prefixId.prefix "baud"
    let becquerel = _prefixId.prefix "becquerel"
    let biot = _prefixId.prefix "biot"
    let bit = _prefixId.prefix "bit"
    let bitPerSecond_Time = _prefixId.prefix "bitPerSecond-Time"
    let bottle = _prefixId.prefix "bottle"
    let bowl = _prefixId.prefix "bowl"
    let bushel_US = _prefixId.prefix "bushel-US"
    let byte = _prefixId.prefix "byte"
    let calorie_15C = _prefixId.prefix "calorie-15C"
    let calorie_20C = _prefixId.prefix "calorie-20C"
    let calorie_InternationalTable = _prefixId.prefix "calorie-InternationalTable"
    let calorie_Mean = _prefixId.prefix "calorie-Mean"
    let calorie_Thermochemical = _prefixId.prefix "calorie-Thermochemical"
    let candela = _prefixId.prefix "candela"
    let candelaPerSquareCentimetre = _prefixId.prefix "candelaPerSquareCentimetre"
    let candelaPerSquareMetre = _prefixId.prefix "candelaPerSquareMetre"
    let candelaSteradian = _prefixId.prefix "candelaSteradian"
    let capacitance_Dimension = _prefixId.prefix "capacitance-Dimension"
    let carat_Mass = _prefixId.prefix "carat-Mass"
    let catalyticActivity_Dimension = _prefixId.prefix "catalyticActivity-Dimension"

    let catalyticActivityConcentration_Dimension = _prefixId.prefix "catalyticActivityConcentration-Dimension"

    let centi = _prefixId.prefix "centi"
    let centiampere = _prefixId.prefix "centiampere"
    let centiare = _prefixId.prefix "centiare"
    let centibecquerel = _prefixId.prefix "centibecquerel"
    let centicandela = _prefixId.prefix "centicandela"
    let centicoulomb = _prefixId.prefix "centicoulomb"
    let centidegreeCelsius = _prefixId.prefix "centidegreeCelsius"
    let centifarad = _prefixId.prefix "centifarad"
    let centigram = _prefixId.prefix "centigram"
    let centigramPerLitre = _prefixId.prefix "centigramPerLitre"
    let centigray = _prefixId.prefix "centigray"
    let centihenry = _prefixId.prefix "centihenry"
    let centihertz = _prefixId.prefix "centihertz"
    let centijoule = _prefixId.prefix "centijoule"
    let centikatal = _prefixId.prefix "centikatal"
    let centikelvin = _prefixId.prefix "centikelvin"
    let centilitre = _prefixId.prefix "centilitre"
    let centilumen = _prefixId.prefix "centilumen"
    let centilux = _prefixId.prefix "centilux"
    let centimetre = _prefixId.prefix "centimetre"

    let centimetre_Gram_Second_BiotSystemOfUnits = _prefixId.prefix "centimetre-Gram-Second-BiotSystemOfUnits"

    let centimetre_Gram_Second_FranklinSystemOfUnits = _prefixId.prefix "centimetre-Gram-Second-FranklinSystemOfUnits"

    let centimetre_Gram_SecondElectromagneticSystemOfUnits = _prefixId.prefix "centimetre-Gram-SecondElectromagneticSystemOfUnits"

    let centimetre_Gram_SecondElectrostaticSystemOfUnits = _prefixId.prefix "centimetre-Gram-SecondElectrostaticSystemOfUnits"

    let centimetre_Gram_SecondSystemOfUnits = _prefixId.prefix "centimetre-Gram-SecondSystemOfUnits"

    let centimetreOfMercury = _prefixId.prefix "centimetreOfMercury"
    let centimetrePerCubicCentimetre = _prefixId.prefix "centimetrePerCubicCentimetre"
    let centimetrePerDay = _prefixId.prefix "centimetrePerDay"
    let centimetrePerSecond_Time = _prefixId.prefix "centimetrePerSecond-Time"

    let centimetrePerSecond_TimeSquared = _prefixId.prefix "centimetrePerSecond-TimeSquared"

    let centimolair = _prefixId.prefix "centimolair"
    let centimole = _prefixId.prefix "centimole"
    let centimolePerLitre = _prefixId.prefix "centimolePerLitre"
    let centimolePerMetre = _prefixId.prefix "centimolePerMetre"
    let centinewton = _prefixId.prefix "centinewton"
    let centiohm = _prefixId.prefix "centiohm"
    let centipascal = _prefixId.prefix "centipascal"
    let centipoise = _prefixId.prefix "centipoise"
    let centiradian = _prefixId.prefix "centiradian"
    let centisecond_Time = _prefixId.prefix "centisecond-Time"
    let centisecond_TimeSquared = _prefixId.prefix "centisecond-TimeSquared"
    let centisiemens = _prefixId.prefix "centisiemens"
    let centisievert = _prefixId.prefix "centisievert"
    let centisteradian = _prefixId.prefix "centisteradian"
    let centistokes = _prefixId.prefix "centistokes"
    let centitesla = _prefixId.prefix "centitesla"
    let centivolt = _prefixId.prefix "centivolt"
    let centiwatt = _prefixId.prefix "centiwatt"
    let centiweber = _prefixId.prefix "centiweber"
    let chain = _prefixId.prefix "chain"
    let chemicalPhysics = _prefixId.prefix "chemicalPhysics"
    let chemistry = _prefixId.prefix "chemistry"
    let cicero = _prefixId.prefix "cicero"
    let circularMil = _prefixId.prefix "circularMil"
    let colonyFormingUnit = _prefixId.prefix "colonyFormingUnit"

    let colonyFormingUnitPer25Millilitre = _prefixId.prefix "colonyFormingUnitPer25Millilitre"

    let colonyFormingUnitPerGram = _prefixId.prefix "colonyFormingUnitPerGram"

    let colonyFormingUnitPerMillilitre = _prefixId.prefix "colonyFormingUnitPerMillilitre"

    let columnNumberDensity_Dimension = _prefixId.prefix "columnNumberDensity-Dimension"
    let commonApplicationArea = _prefixId.prefix "commonApplicationArea"
    /// <summary>
    ///   <para>oum:alternativeLabel : commonly has unit of measureoum:alternativeLabel : 通常は測定単位を持つ</para>
    ///   <para>rdfs:label : commonly has unitrdfs:label : 通常は単位を持つ</para>
    ///   <para>rdfs:comment : This property indicates a commonly-used unit.^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/commonlyHasUnit">oum:commonlyHasUnit</a>
    /// </summary>
    let commonlyHasUnit = _prefixId.prefix "commonlyHasUnit"

    let constantCurrentThatProducesAnAttractiveForceOf2e_7NewtonPerMetreOfLengthBetweenTwoStraightParallelConductorsOfInfiniteLengthAndNegligibleCircularCrossSectionPlacedOneMetreApartInAVacuum =
        _prefixId.prefix
            "constantCurrentThatProducesAnAttractiveForceOf2e-7NewtonPerMetreOfLengthBetweenTwoStraightParallelConductorsOfInfiniteLengthAndNegligibleCircularCrossSectionPlacedOneMetreApartInAVacuum"

    let cord = _prefixId.prefix "cord"
    let cosmology = _prefixId.prefix "cosmology"
    let coulomb = _prefixId.prefix "coulomb"
    let coulombMetre = _prefixId.prefix "coulombMetre"
    let coulombPerCubicmetre = _prefixId.prefix "coulombPerCubicmetre"
    let coulombPerKilogram = _prefixId.prefix "coulombPerKilogram"
    let coulombPerSquareMetre = _prefixId.prefix "coulombPerSquareMetre"
    let coulombPerVolt = _prefixId.prefix "coulombPerVolt"
    let count = _prefixId.prefix "count"
    let cubicAttometre = _prefixId.prefix "cubicAttometre"
    let cubicCentimetre = _prefixId.prefix "cubicCentimetre"

    let cubicCentimetrePerCubicCentimetre = _prefixId.prefix "cubicCentimetrePerCubicCentimetre"

    let cubicDecametre = _prefixId.prefix "cubicDecametre"
    let cubicDecimetre = _prefixId.prefix "cubicDecimetre"
    let cubicExametre = _prefixId.prefix "cubicExametre"
    let cubicFemtometre = _prefixId.prefix "cubicFemtometre"
    let cubicGigametre = _prefixId.prefix "cubicGigametre"
    let cubicHectometre = _prefixId.prefix "cubicHectometre"
    let cubicKilometre = _prefixId.prefix "cubicKilometre"
    let cubicKiloparsec = _prefixId.prefix "cubicKiloparsec"
    let cubicMegametre = _prefixId.prefix "cubicMegametre"
    let cubicMetre = _prefixId.prefix "cubicMetre"
    let cubicMetreKelvin = _prefixId.prefix "cubicMetreKelvin"
    let cubicMetrePerCubicmetre = _prefixId.prefix "cubicMetrePerCubicmetre"
    let cubicMetrePerKilogram = _prefixId.prefix "cubicMetrePerKilogram"
    let cubicMetrePerMole = _prefixId.prefix "cubicMetrePerMole"
    let cubicMetrePerSecond_Time = _prefixId.prefix "cubicMetrePerSecond-Time"
    let cubicMetrePerYear = _prefixId.prefix "cubicMetrePerYear"
    let cubicMicrometre = _prefixId.prefix "cubicMicrometre"
    let cubicMillimetre = _prefixId.prefix "cubicMillimetre"

    let cubicMillimetrePerCubicMillimetre = _prefixId.prefix "cubicMillimetrePerCubicMillimetre"

    let cubicNanometre = _prefixId.prefix "cubicNanometre"
    let cubicParsec = _prefixId.prefix "cubicParsec"
    let cubicPetametre = _prefixId.prefix "cubicPetametre"
    let cubicPicometre = _prefixId.prefix "cubicPicometre"
    let cubicTerametre = _prefixId.prefix "cubicTerametre"
    let cubicYoctometre = _prefixId.prefix "cubicYoctometre"
    let cubicYottametre = _prefixId.prefix "cubicYottametre"
    let cubicZeptometre = _prefixId.prefix "cubicZeptometre"
    let cubicZettametre = _prefixId.prefix "cubicZettametre"
    let cup = _prefixId.prefix "cup"
    let cup_USCustomary = _prefixId.prefix "cup-USCustomary"
    let curie = _prefixId.prefix "curie"
    let currentDensity_Dimension = _prefixId.prefix "currentDensity-Dimension"
    let darcy = _prefixId.prefix "darcy"
    let dash = _prefixId.prefix "dash"
    let day = _prefixId.prefix "day"
    let day_Sidereal = _prefixId.prefix "day-Sidereal"
    let debye = _prefixId.prefix "debye"
    let deca = _prefixId.prefix "deca"
    let decaampere = _prefixId.prefix "decaampere"
    let decabecquerel = _prefixId.prefix "decabecquerel"
    let decacandela = _prefixId.prefix "decacandela"
    let decacoulomb = _prefixId.prefix "decacoulomb"
    let decafarad = _prefixId.prefix "decafarad"
    let decagram = _prefixId.prefix "decagram"
    let decagramPerLitre = _prefixId.prefix "decagramPerLitre"
    let decagray = _prefixId.prefix "decagray"
    let decahenry = _prefixId.prefix "decahenry"
    let decahertz = _prefixId.prefix "decahertz"
    let decajoule = _prefixId.prefix "decajoule"
    let decakatal = _prefixId.prefix "decakatal"
    let decakelvin = _prefixId.prefix "decakelvin"
    let decalitre = _prefixId.prefix "decalitre"
    let decalumen = _prefixId.prefix "decalumen"
    let decalux = _prefixId.prefix "decalux"
    let decametre = _prefixId.prefix "decametre"
    let decametrePerSecond_Time = _prefixId.prefix "decametrePerSecond-Time"

    let decametrePerSecond_TimeSquared = _prefixId.prefix "decametrePerSecond-TimeSquared"

    let decamolair = _prefixId.prefix "decamolair"
    let decamole = _prefixId.prefix "decamole"
    let decamolePerLitre = _prefixId.prefix "decamolePerLitre"
    let decamolePerMetre = _prefixId.prefix "decamolePerMetre"
    let decanewton = _prefixId.prefix "decanewton"
    let decaohm = _prefixId.prefix "decaohm"
    let decapascal = _prefixId.prefix "decapascal"
    let decasecond_Time = _prefixId.prefix "decasecond-Time"
    let decasecond_TimeSquared = _prefixId.prefix "decasecond-TimeSquared"
    let decasiemens = _prefixId.prefix "decasiemens"
    let decasievert = _prefixId.prefix "decasievert"
    let decatesla = _prefixId.prefix "decatesla"
    let decavolt = _prefixId.prefix "decavolt"
    let decawatt = _prefixId.prefix "decawatt"
    let decaweber = _prefixId.prefix "decaweber"
    let deci = _prefixId.prefix "deci"
    let deciampere = _prefixId.prefix "deciampere"
    let decibar = _prefixId.prefix "decibar"
    let decibecquerel = _prefixId.prefix "decibecquerel"
    let decicandela = _prefixId.prefix "decicandela"
    let decicoulomb = _prefixId.prefix "decicoulomb"
    let decidegreeCelsius = _prefixId.prefix "decidegreeCelsius"
    let decifarad = _prefixId.prefix "decifarad"
    let decigram = _prefixId.prefix "decigram"
    let decigramPerLitre = _prefixId.prefix "decigramPerLitre"
    let decigray = _prefixId.prefix "decigray"
    let decihenry = _prefixId.prefix "decihenry"
    let decihertz = _prefixId.prefix "decihertz"
    let decijoule = _prefixId.prefix "decijoule"
    let decikatal = _prefixId.prefix "decikatal"
    let decikelvin = _prefixId.prefix "decikelvin"
    let decilitre = _prefixId.prefix "decilitre"
    let decilumen = _prefixId.prefix "decilumen"
    let decilux = _prefixId.prefix "decilux"
    let decimetre = _prefixId.prefix "decimetre"
    let decimetrePerSecond_Time = _prefixId.prefix "decimetrePerSecond-Time"

    let decimetrePerSecond_TimeSquared = _prefixId.prefix "decimetrePerSecond-TimeSquared"

    let decimolair = _prefixId.prefix "decimolair"
    let decimole = _prefixId.prefix "decimole"
    let decimolePerLitre = _prefixId.prefix "decimolePerLitre"
    let decimolePerMetre = _prefixId.prefix "decimolePerMetre"
    let decinewton = _prefixId.prefix "decinewton"
    let deciohm = _prefixId.prefix "deciohm"
    let decipascal = _prefixId.prefix "decipascal"
    let deciradian = _prefixId.prefix "deciradian"
    let decisecond_Time = _prefixId.prefix "decisecond-Time"
    let decisecond_TimeSquared = _prefixId.prefix "decisecond-TimeSquared"
    let decisiemens = _prefixId.prefix "decisiemens"
    let decisievert = _prefixId.prefix "decisievert"
    let decisteradian = _prefixId.prefix "decisteradian"
    let decitesla = _prefixId.prefix "decitesla"
    let decivolt = _prefixId.prefix "decivolt"
    let deciwatt = _prefixId.prefix "deciwatt"
    let deciweber = _prefixId.prefix "deciweber"
    let deepBowl = _prefixId.prefix "deepBowl"
    let degree = _prefixId.prefix "degree"
    let degreeCelsius = _prefixId.prefix "degreeCelsius"
    let degreeCelsiusDay = _prefixId.prefix "degreeCelsiusDay"
    let degreeCelsiusPerHour = _prefixId.prefix "degreeCelsiusPerHour"
    let degreeCelsiusPerMinute_Time = _prefixId.prefix "degreeCelsiusPerMinute-Time"
    let degreeCelsiusPerSecond_Time = _prefixId.prefix "degreeCelsiusPerSecond-Time"
    let degreeFahrenheit = _prefixId.prefix "degreeFahrenheit"
    let degreeRankine = _prefixId.prefix "degreeRankine"
    let degreeReaumur = _prefixId.prefix "degreeReaumur"
    let degreeSquared = _prefixId.prefix "degreeSquared"
    let deltaA450 = _prefixId.prefix "deltaA450"
    let deltaA450PerSecond_Time = _prefixId.prefix "deltaA450PerSecond-Time"

    let deltaA450PerSecond_TimePerMilligram = _prefixId.prefix "deltaA450PerSecond-TimePerMilligram"

    let density_Dimension = _prefixId.prefix "density-Dimension"
    let dessertspoon = _prefixId.prefix "dessertspoon"
    let dimensionOne = _prefixId.prefix "dimensionOne"
    let drop = _prefixId.prefix "drop"
    let dryGallon_US = _prefixId.prefix "dryGallon-US"
    let dryPint_US = _prefixId.prefix "dryPint-US"
    let dryQuart_US = _prefixId.prefix "dryQuart-US"

    let durationOf9192631770PeriodsOfTheRadiationCorrespondingToTheTransitionBetweenTheTwoHyperfineLevelsOfTheGroundStateOfTheCesium133Atom =
        _prefixId.prefix "durationOf9192631770PeriodsOfTheRadiationCorrespondingToTheTransitionBetweenTheTwoHyperfineLevelsOfTheGroundStateOfTheCesium133Atom"

    let dynamicViscosity_Dimension = _prefixId.prefix "dynamicViscosity-Dimension"
    let dyne = _prefixId.prefix "dyne"
    let economics = _prefixId.prefix "economics"
    let electricCharge_Dimension = _prefixId.prefix "electricCharge-Dimension"

    let electricChargeDensity_Dimension = _prefixId.prefix "electricChargeDensity-Dimension"

    let electricCurrent_Dimension = _prefixId.prefix "electricCurrent-Dimension"

    let electricDipoleMoment_Dimension = _prefixId.prefix "electricDipoleMoment-Dimension"

    let electricField_Dimension = _prefixId.prefix "electricField-Dimension"
    let electricFluxDensity_Dimension = _prefixId.prefix "electricFluxDensity-Dimension"
    let electricPotential_Dimension = _prefixId.prefix "electricPotential-Dimension"

    let electricalConductance_Dimension = _prefixId.prefix "electricalConductance-Dimension"

    let electricalConductivity_Dimension = _prefixId.prefix "electricalConductivity-Dimension"

    let electricalResistance_Dimension = _prefixId.prefix "electricalResistance-Dimension"

    let electricalResistivity_Dimension = _prefixId.prefix "electricalResistivity-Dimension"

    let electromagnetism = _prefixId.prefix "electromagnetism"
    let electronvolt = _prefixId.prefix "electronvolt"
    let energy_Dimension = _prefixId.prefix "energy-Dimension"
    let energyDensity_Dimension = _prefixId.prefix "energyDensity-Dimension"

    let entropyOrHeatCapacity_Dimension = _prefixId.prefix "entropyOrHeatCapacity-Dimension"

    let erg = _prefixId.prefix "erg"
    let ergSecond_Time = _prefixId.prefix "ergSecond-Time"
    let euro = _prefixId.prefix "euro"
    let euroPerTonne = _prefixId.prefix "euroPerTonne"
    let exa = _prefixId.prefix "exa"
    let exaampere = _prefixId.prefix "exaampere"
    let exabecquerel = _prefixId.prefix "exabecquerel"
    let exabit = _prefixId.prefix "exabit"
    let exabyte = _prefixId.prefix "exabyte"
    let exacandela = _prefixId.prefix "exacandela"
    let exacoulomb = _prefixId.prefix "exacoulomb"
    let exafarad = _prefixId.prefix "exafarad"
    let exagram = _prefixId.prefix "exagram"
    let exagramPerLitre = _prefixId.prefix "exagramPerLitre"
    let exagray = _prefixId.prefix "exagray"
    let exahenry = _prefixId.prefix "exahenry"
    let exahertz = _prefixId.prefix "exahertz"
    let exajoule = _prefixId.prefix "exajoule"
    let exakatal = _prefixId.prefix "exakatal"
    let exakelvin = _prefixId.prefix "exakelvin"
    let exalitre = _prefixId.prefix "exalitre"
    let exalumen = _prefixId.prefix "exalumen"
    let exalux = _prefixId.prefix "exalux"
    let exametre = _prefixId.prefix "exametre"
    let exametrePerSecond_Time = _prefixId.prefix "exametrePerSecond-Time"
    let exametrePerSecond_TimeSquared = _prefixId.prefix "exametrePerSecond-TimeSquared"
    let examolair = _prefixId.prefix "examolair"
    let examole = _prefixId.prefix "examole"
    let examolePerLitre = _prefixId.prefix "examolePerLitre"
    let examolePerMetre = _prefixId.prefix "examolePerMetre"
    let exanewton = _prefixId.prefix "exanewton"
    let exaohm = _prefixId.prefix "exaohm"
    let exapascal = _prefixId.prefix "exapascal"
    let exasecond_Time = _prefixId.prefix "exasecond-Time"
    let exasecond_TimeSquared = _prefixId.prefix "exasecond-TimeSquared"
    let exasiemens = _prefixId.prefix "exasiemens"
    let exasievert = _prefixId.prefix "exasievert"
    let exatesla = _prefixId.prefix "exatesla"
    let exavolt = _prefixId.prefix "exavolt"
    let exawatt = _prefixId.prefix "exawatt"
    let exaweber = _prefixId.prefix "exaweber"
    let exbi = _prefixId.prefix "exbi"
    let exbibit = _prefixId.prefix "exbibit"
    let exbibyte = _prefixId.prefix "exbibyte"
    let exposure_Dimension = _prefixId.prefix "exposure-Dimension"

    let exposureToXAndGammaRays_Dimension = _prefixId.prefix "exposureToXAndGammaRays-Dimension"

    let farad = _prefixId.prefix "farad"
    let faradPerMetre = _prefixId.prefix "faradPerMetre"
    let faraday = _prefixId.prefix "faraday"
    let fathom_USSurvey = _prefixId.prefix "fathom-USSurvey"
    let femto = _prefixId.prefix "femto"
    let femtoampere = _prefixId.prefix "femtoampere"
    let femtobecquerel = _prefixId.prefix "femtobecquerel"
    let femtocandela = _prefixId.prefix "femtocandela"
    let femtocoulomb = _prefixId.prefix "femtocoulomb"
    let femtodegreeCelsius = _prefixId.prefix "femtodegreeCelsius"
    let femtofarad = _prefixId.prefix "femtofarad"
    let femtogram = _prefixId.prefix "femtogram"
    let femtogramPerLitre = _prefixId.prefix "femtogramPerLitre"
    let femtogray = _prefixId.prefix "femtogray"
    let femtohenry = _prefixId.prefix "femtohenry"
    let femtohertz = _prefixId.prefix "femtohertz"
    let femtojoule = _prefixId.prefix "femtojoule"
    let femtokatal = _prefixId.prefix "femtokatal"
    let femtokelvin = _prefixId.prefix "femtokelvin"
    let femtolitre = _prefixId.prefix "femtolitre"
    let femtolumen = _prefixId.prefix "femtolumen"
    let femtolux = _prefixId.prefix "femtolux"
    let femtometre = _prefixId.prefix "femtometre"
    let femtometrePerSecond_Time = _prefixId.prefix "femtometrePerSecond-Time"

    let femtometrePerSecond_TimeSquared = _prefixId.prefix "femtometrePerSecond-TimeSquared"

    let femtomolair = _prefixId.prefix "femtomolair"
    let femtomole = _prefixId.prefix "femtomole"
    let femtomolePerLitre = _prefixId.prefix "femtomolePerLitre"
    let femtomolePerMetre = _prefixId.prefix "femtomolePerMetre"
    let femtonewton = _prefixId.prefix "femtonewton"
    let femtoohm = _prefixId.prefix "femtoohm"
    let femtopascal = _prefixId.prefix "femtopascal"
    let femtoradian = _prefixId.prefix "femtoradian"
    let femtosecond_Time = _prefixId.prefix "femtosecond-Time"
    let femtosecond_TimeSquared = _prefixId.prefix "femtosecond-TimeSquared"
    let femtosiemens = _prefixId.prefix "femtosiemens"
    let femtosievert = _prefixId.prefix "femtosievert"
    let femtosteradian = _prefixId.prefix "femtosteradian"
    let femtotesla = _prefixId.prefix "femtotesla"
    let femtovolt = _prefixId.prefix "femtovolt"
    let femtowatt = _prefixId.prefix "femtowatt"
    let femtoweber = _prefixId.prefix "femtoweber"
    let fermi = _prefixId.prefix "fermi"
    let fillet = _prefixId.prefix "fillet"
    let first = _prefixId.prefix "first"
    let fluidMechanics = _prefixId.prefix "fluidMechanics"

    let fluidMechanicsDimensionlessNumbers = _prefixId.prefix "fluidMechanicsDimensionlessNumbers"

    let fluidOunce_Imperial = _prefixId.prefix "fluidOunce-Imperial"
    let fluidOunce_US = _prefixId.prefix "fluidOunce-US"
    let fluidity_Dimension = _prefixId.prefix "fluidity-Dimension"
    let foot_International = _prefixId.prefix "foot-International"
    let foot_USSurvey = _prefixId.prefix "foot-USSurvey"
    let footPoundal = _prefixId.prefix "footPoundal"
    let footcandle = _prefixId.prefix "footcandle"
    let footlambert = _prefixId.prefix "footlambert"
    let force_Dimension = _prefixId.prefix "force-Dimension"
    let franklin = _prefixId.prefix "franklin"
    let frequency_Dimension = _prefixId.prefix "frequency-Dimension"
    let furlong_International = _prefixId.prefix "furlong-International"
    /// <summary>
    ///   <para>oum:symbol : g^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m_g^^xsd:string</para>
    ///   <para>rdfs:label : g magnitude</para>
    ///   <para>rdfs:comment : g Magnitude in the Thuan and Gunn photometric system.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/gMagnitude">oum:gMagnitude</a>
    /// </summary>
    let gMagnitude = _prefixId.prefix "gMagnitude"
    let gal = _prefixId.prefix "gal"
    let gallon_Imperial = _prefixId.prefix "gallon-Imperial"
    let gallon_US = _prefixId.prefix "gallon-US"
    let gamma = _prefixId.prefix "gamma"
    let gauss = _prefixId.prefix "gauss"
    let geometry = _prefixId.prefix "geometry"
    let gibi = _prefixId.prefix "gibi"
    let gibibit = _prefixId.prefix "gibibit"
    let gibibyte = _prefixId.prefix "gibibyte"
    let giga = _prefixId.prefix "giga"
    let gigaampere = _prefixId.prefix "gigaampere"
    let gigabecquerel = _prefixId.prefix "gigabecquerel"
    let gigabit = _prefixId.prefix "gigabit"
    let gigabyte = _prefixId.prefix "gigabyte"
    let gigacandela = _prefixId.prefix "gigacandela"
    let gigacoulomb = _prefixId.prefix "gigacoulomb"
    let gigaelectronvolt = _prefixId.prefix "gigaelectronvolt"
    let gigafarad = _prefixId.prefix "gigafarad"
    let gigagram = _prefixId.prefix "gigagram"
    let gigagramPerLitre = _prefixId.prefix "gigagramPerLitre"
    let gigagray = _prefixId.prefix "gigagray"
    let gigahenry = _prefixId.prefix "gigahenry"
    let gigahertz = _prefixId.prefix "gigahertz"
    let gigajoule = _prefixId.prefix "gigajoule"
    let gigakatal = _prefixId.prefix "gigakatal"
    let gigakelvin = _prefixId.prefix "gigakelvin"
    let gigalitre = _prefixId.prefix "gigalitre"
    let gigalumen = _prefixId.prefix "gigalumen"
    let gigalux = _prefixId.prefix "gigalux"
    let gigametre = _prefixId.prefix "gigametre"
    let gigametrePerSecond_Time = _prefixId.prefix "gigametrePerSecond-Time"

    let gigametrePerSecond_TimeSquared = _prefixId.prefix "gigametrePerSecond-TimeSquared"

    let gigamolair = _prefixId.prefix "gigamolair"
    let gigamole = _prefixId.prefix "gigamole"
    let gigamolePerLitre = _prefixId.prefix "gigamolePerLitre"
    let gigamolePerMetre = _prefixId.prefix "gigamolePerMetre"
    let giganewton = _prefixId.prefix "giganewton"
    let gigaohm = _prefixId.prefix "gigaohm"
    let gigaparsec = _prefixId.prefix "gigaparsec"
    let gigapascal = _prefixId.prefix "gigapascal"
    let gigasecond_Time = _prefixId.prefix "gigasecond-Time"
    let gigasecond_TimeSquared = _prefixId.prefix "gigasecond-TimeSquared"
    let gigasiemens = _prefixId.prefix "gigasiemens"
    let gigasievert = _prefixId.prefix "gigasievert"
    let gigatesla = _prefixId.prefix "gigatesla"
    let gigavolt = _prefixId.prefix "gigavolt"
    let gigawatt = _prefixId.prefix "gigawatt"
    let gigaweber = _prefixId.prefix "gigaweber"
    let gigayear = _prefixId.prefix "gigayear"
    let gigayearCubicKiloparsec = _prefixId.prefix "gigayearCubicKiloparsec"
    let gigayearCubicParsec = _prefixId.prefix "gigayearCubicParsec"
    let gilbert = _prefixId.prefix "gilbert"
    let gill_Imperial = _prefixId.prefix "gill-Imperial"
    let gill_US = _prefixId.prefix "gill-US"
    let glass = _prefixId.prefix "glass"
    let gon = _prefixId.prefix "gon"
    let grain = _prefixId.prefix "grain"
    let gram = _prefixId.prefix "gram"
    let gramPerAttolitre = _prefixId.prefix "gramPerAttolitre"
    let gramPerCentilitre = _prefixId.prefix "gramPerCentilitre"
    let gramPerCubicCentimetre = _prefixId.prefix "gramPerCubicCentimetre"
    let gramPerCubicmetre = _prefixId.prefix "gramPerCubicmetre"
    let gramPerDay = _prefixId.prefix "gramPerDay"
    let gramPerDecalitre = _prefixId.prefix "gramPerDecalitre"
    let gramPerDecilitre = _prefixId.prefix "gramPerDecilitre"
    let gramPerExalitre = _prefixId.prefix "gramPerExalitre"
    let gramPerFemtolitre = _prefixId.prefix "gramPerFemtolitre"
    let gramPerGigalitre = _prefixId.prefix "gramPerGigalitre"
    let gramPerGram = _prefixId.prefix "gramPerGram"
    let gramPerHectogram = _prefixId.prefix "gramPerHectogram"
    let gramPerHectolitre = _prefixId.prefix "gramPerHectolitre"
    let gramPerJoule = _prefixId.prefix "gramPerJoule"
    let gramPerKilogram = _prefixId.prefix "gramPerKilogram"
    let gramPerKilolitre = _prefixId.prefix "gramPerKilolitre"
    let gramPerLitre = _prefixId.prefix "gramPerLitre"
    let gramPerMegajoule = _prefixId.prefix "gramPerMegajoule"
    let gramPerMegalitre = _prefixId.prefix "gramPerMegalitre"
    let gramPerMetre = _prefixId.prefix "gramPerMetre"
    let gramPerMicrolitre = _prefixId.prefix "gramPerMicrolitre"
    let gramPerMillilitre = _prefixId.prefix "gramPerMillilitre"
    let gramPerNanolitre = _prefixId.prefix "gramPerNanolitre"
    let gramPerPetalitre = _prefixId.prefix "gramPerPetalitre"
    let gramPerPicolitre = _prefixId.prefix "gramPerPicolitre"
    let gramPerSquareMetre = _prefixId.prefix "gramPerSquareMetre"
    let gramPerSquareMetreCentimetre = _prefixId.prefix "gramPerSquareMetreCentimetre"
    let gramPerSquareMetreDay = _prefixId.prefix "gramPerSquareMetreDay"
    let gramPerSquareMetreMetre = _prefixId.prefix "gramPerSquareMetreMetre"
    let gramPerSquareMetreSecond_Time = _prefixId.prefix "gramPerSquareMetreSecond-Time"
    let gramPerTeralitre = _prefixId.prefix "gramPerTeralitre"
    let gramPerYoctolitre = _prefixId.prefix "gramPerYoctolitre"
    let gramPerYottalitre = _prefixId.prefix "gramPerYottalitre"
    let gramPerZeptolitre = _prefixId.prefix "gramPerZeptolitre"
    let gramPerZettalitre = _prefixId.prefix "gramPerZettalitre"
    let gramPerday = _prefixId.prefix "gramPerday"
    let gray = _prefixId.prefix "gray"
    let grayPerSecond_Time = _prefixId.prefix "grayPerSecond-Time"
    let handful = _prefixId.prefix "handful"
    let hartley = _prefixId.prefix "hartley"
    /// <summary>
    ///   <para>rdfs:label : has aggregate functionrdfs:label : 集計関数を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasAggregateFunction">oum:hasAggregateFunction</a>
    /// </summary>
    let hasAggregateFunction = _prefixId.prefix "hasAggregateFunction"
    /// <summary>
    ///   <para>rdfs:label : has base</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasBase">oum:hasBase</a>
    /// </summary>
    let hasBase = _prefixId.prefix "hasBase"
    /// <summary>
    ///   <para>rdfs:label : has base quantity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasBaseQuantity">oum:hasBaseQuantity</a>
    /// </summary>
    let hasBaseQuantity = _prefixId.prefix "hasBaseQuantity"
    /// <summary>
    ///   <para>rdfs:label : has base unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasBaseUnit">oum:hasBaseUnit</a>
    /// </summary>
    let hasBaseUnit = _prefixId.prefix "hasBaseUnit"
    /// <summary>
    ///   <para>rdfs:label : has contextrdfs:label : 文脈を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasContext">oum:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:label : has denominator</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasDenominator">oum:hasDenominator</a>
    /// </summary>
    let hasDenominator = _prefixId.prefix "hasDenominator"
    /// <summary>
    ///   <para>rdfs:label : has derived quantity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasDerivedQuantity">oum:hasDerivedQuantity</a>
    /// </summary>
    let hasDerivedQuantity = _prefixId.prefix "hasDerivedQuantity"
    /// <summary>
    ///   <para>rdfs:label : has derived unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasDerivedUnit">oum:hasDerivedUnit</a>
    /// </summary>
    let hasDerivedUnit = _prefixId.prefix "hasDerivedUnit"
    /// <summary>
    ///   <para>rdfs:label : has dimension</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasDimension">oum:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>rdfs:label : has exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasExponent">oum:hasExponent</a>
    /// </summary>
    let hasExponent = _prefixId.prefix "hasExponent"
    /// <summary>
    ///   <para>rdfs:label : has factorrdfs:label : 因子を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasFactor">oum:hasFactor</a>
    /// </summary>
    let hasFactor = _prefixId.prefix "hasFactor"
    /// <summary>
    ///   <para>rdfs:label : has numerator</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasNumerator">oum:hasNumerator</a>
    /// </summary>
    let hasNumerator = _prefixId.prefix "hasNumerator"
    /// <summary>
    ///   <para>rdfs:label : has numerical value</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasNumericalValue">oum:hasNumericalValue</a>
    /// </summary>
    let hasNumericalValue = _prefixId.prefix "hasNumericalValue"
    /// <summary>
    ///   <para>rdfs:label : has off-set</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasOff-Set">oum:hasOff-Set</a>
    /// </summary>
    let hasOff_Set = _prefixId.prefix "hasOff-Set"
    /// <summary>
    ///   <para>rdfs:label : has phenomenonrdfs:label : 現象がある</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasPhenomenon">oum:hasPhenomenon</a>
    /// </summary>
    let hasPhenomenon = _prefixId.prefix "hasPhenomenon"
    /// <summary>
    ///   <para>rdfs:label : has point</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasPoint">oum:hasPoint</a>
    /// </summary>
    let hasPoint = _prefixId.prefix "hasPoint"
    /// <summary>
    ///   <para>rdfs:label : has prefixrdfs:label : 補助単位を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasPrefix">oum:hasPrefix</a>
    /// </summary>
    let hasPrefix = _prefixId.prefix "hasPrefix"
    /// <summary>
    ///   <para>rdfs:label : has quantityrdfs:label : 量を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasQuantity">oum:hasQuantity</a>
    /// </summary>
    let hasQuantity = _prefixId.prefix "hasQuantity"

    /// <summary>
    ///   <para>rdfs:label : has SI amount of substance dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSIAmountOfSubstanceDimensionExponent">oum:hasSIAmountOfSubstanceDimensionExponent</a>
    /// </summary>
    let hasSIAmountOfSubstanceDimensionExponent = _prefixId.prefix "hasSIAmountOfSubstanceDimensionExponent"

    /// <summary>
    ///   <para>rdfs:label : has SI electric current dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSIElectricCurrentDimensionExponent">oum:hasSIElectricCurrentDimensionExponent</a>
    /// </summary>
    let hasSIElectricCurrentDimensionExponent = _prefixId.prefix "hasSIElectricCurrentDimensionExponent"

    /// <summary>
    ///   <para>rdfs:label : has SI length dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSILengthDimensionExponent">oum:hasSILengthDimensionExponent</a>
    /// </summary>
    let hasSILengthDimensionExponent = _prefixId.prefix "hasSILengthDimensionExponent"

    /// <summary>
    ///   <para>rdfs:label : has SI luminous intensity dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSILuminousIntensityDimensionExponent">oum:hasSILuminousIntensityDimensionExponent</a>
    /// </summary>
    let hasSILuminousIntensityDimensionExponent = _prefixId.prefix "hasSILuminousIntensityDimensionExponent"

    /// <summary>
    ///   <para>rdfs:label : has SI mass dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSIMassDimensionExponent">oum:hasSIMassDimensionExponent</a>
    /// </summary>
    let hasSIMassDimensionExponent = _prefixId.prefix "hasSIMassDimensionExponent"

    /// <summary>
    ///   <para>rdfs:label : has SI thermodynamic temperature dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSIThermodynamicTemperatureDimensionExponent">oum:hasSIThermodynamicTemperatureDimensionExponent</a>
    /// </summary>
    let hasSIThermodynamicTemperatureDimensionExponent = _prefixId.prefix "hasSIThermodynamicTemperatureDimensionExponent"

    /// <summary>
    ///   <para>rdfs:label : has SI time dimension exponent</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasSITimeDimensionExponent">oum:hasSITimeDimensionExponent</a>
    /// </summary>
    let hasSITimeDimensionExponent = _prefixId.prefix "hasSITimeDimensionExponent"
    /// <summary>
    ///   <para>rdfs:label : has scale</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasScale">oum:hasScale</a>
    /// </summary>
    let hasScale = _prefixId.prefix "hasScale"
    /// <summary>
    ///   <para>rdfs:label : has term 1</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasTerm1">oum:hasTerm1</a>
    /// </summary>
    let hasTerm1 = _prefixId.prefix "hasTerm1"
    /// <summary>
    ///   <para>rdfs:label : has term 2</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasTerm2">oum:hasTerm2</a>
    /// </summary>
    let hasTerm2 = _prefixId.prefix "hasTerm2"
    /// <summary>
    ///   <para>rdfs:label : has unitrdfs:label : 単位を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasUnit">oum:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : has valuerdfs:label : 値を持つ</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/hasValue">oum:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"

    let heatTransferCoefficient_Dimension = _prefixId.prefix "heatTransferCoefficient-Dimension"

    let hectare = _prefixId.prefix "hectare"
    let hectareDay = _prefixId.prefix "hectareDay"
    let hecto = _prefixId.prefix "hecto"
    let hectoampere = _prefixId.prefix "hectoampere"
    let hectobecquerel = _prefixId.prefix "hectobecquerel"
    let hectocandela = _prefixId.prefix "hectocandela"
    let hectocoulomb = _prefixId.prefix "hectocoulomb"
    let hectofarad = _prefixId.prefix "hectofarad"
    let hectogram = _prefixId.prefix "hectogram"
    let hectogramPerLitre = _prefixId.prefix "hectogramPerLitre"
    let hectogray = _prefixId.prefix "hectogray"
    let hectohenry = _prefixId.prefix "hectohenry"
    let hectohertz = _prefixId.prefix "hectohertz"
    let hectojoule = _prefixId.prefix "hectojoule"
    let hectokatal = _prefixId.prefix "hectokatal"
    let hectokelvin = _prefixId.prefix "hectokelvin"
    let hectolitre = _prefixId.prefix "hectolitre"
    let hectolumen = _prefixId.prefix "hectolumen"
    let hectolux = _prefixId.prefix "hectolux"
    let hectometre = _prefixId.prefix "hectometre"
    let hectometrePerSecond_Time = _prefixId.prefix "hectometrePerSecond-Time"

    let hectometrePerSecond_TimeSquared = _prefixId.prefix "hectometrePerSecond-TimeSquared"

    let hectomolair = _prefixId.prefix "hectomolair"
    let hectomole = _prefixId.prefix "hectomole"
    let hectomolePerLitre = _prefixId.prefix "hectomolePerLitre"
    let hectomolePerMetre = _prefixId.prefix "hectomolePerMetre"
    let hectonewton = _prefixId.prefix "hectonewton"
    let hectoohm = _prefixId.prefix "hectoohm"
    let hectopascal = _prefixId.prefix "hectopascal"
    let hectosecond_Time = _prefixId.prefix "hectosecond-Time"
    let hectosecond_TimeSquared = _prefixId.prefix "hectosecond-TimeSquared"
    let hectosiemens = _prefixId.prefix "hectosiemens"
    let hectosievert = _prefixId.prefix "hectosievert"
    let hectotesla = _prefixId.prefix "hectotesla"
    let hectovolt = _prefixId.prefix "hectovolt"
    let hectowatt = _prefixId.prefix "hectowatt"
    let hectoweber = _prefixId.prefix "hectoweber"
    let henry = _prefixId.prefix "henry"
    let henryPerMetre = _prefixId.prefix "henryPerMetre"
    let hertz = _prefixId.prefix "hertz"
    let horsepower_Boiler = _prefixId.prefix "horsepower-Boiler"
    let horsepower_British = _prefixId.prefix "horsepower-British"
    let horsepower_Electric = _prefixId.prefix "horsepower-Electric"
    let horsepower_Metric = _prefixId.prefix "horsepower-Metric"
    let horsepower_Water = _prefixId.prefix "horsepower-Water"
    let hour = _prefixId.prefix "hour"
    let hour_HourAngle = _prefixId.prefix "hour-HourAngle"
    let hour_Sidereal = _prefixId.prefix "hour-Sidereal"
    let hundredweight_British = _prefixId.prefix "hundredweight-British"
    let hundredweight_US = _prefixId.prefix "hundredweight-US"
    let illuminance_Dimension = _prefixId.prefix "illuminance-Dimension"
    let inch_International = _prefixId.prefix "inch-International"

    let inductanceOrPermeance_Electromagnetic_Dimension = _prefixId.prefix "inductanceOrPermeance-Electromagnetic-Dimension"

    let informationCapacityOfOneBinaryDigit = _prefixId.prefix "informationCapacityOfOneBinaryDigit"

    let informationTechnology = _prefixId.prefix "informationTechnology"

    let internationalPrototypeOfTheKilogram = _prefixId.prefix "internationalPrototypeOfTheKilogram"

    let jansky = _prefixId.prefix "jansky"
    let joule = _prefixId.prefix "joule"
    let joulePerCubicMetreKelvin = _prefixId.prefix "joulePerCubicMetreKelvin"
    let joulePerCubicmetre = _prefixId.prefix "joulePerCubicmetre"
    let joulePerKelvin = _prefixId.prefix "joulePerKelvin"
    let joulePerKelvinKilogram = _prefixId.prefix "joulePerKelvinKilogram"
    let joulePerKelvinMole = _prefixId.prefix "joulePerKelvinMole"
    let joulePerKilogram = _prefixId.prefix "joulePerKilogram"
    let joulePerMole = _prefixId.prefix "joulePerMole"
    let joulePerSecond_Time = _prefixId.prefix "joulePerSecond-Time"
    let joulePerSquareMetre = _prefixId.prefix "joulePerSquareMetre"
    let joulePerSquareMetreDay = _prefixId.prefix "joulePerSquareMetreDay"

    let joulePerSquareMetreSecond_Time = _prefixId.prefix "joulePerSquareMetreSecond-Time"

    let jouleSecond_Time = _prefixId.prefix "jouleSecond-Time"
    let katal = _prefixId.prefix "katal"
    let katalPerCubicmetre = _prefixId.prefix "katalPerCubicmetre"
    let kayser = _prefixId.prefix "kayser"
    let kelvin = _prefixId.prefix "kelvin"
    let kelvinKilogram = _prefixId.prefix "kelvinKilogram"
    let kelvinMole = _prefixId.prefix "kelvinMole"
    let kelvinPerWatt = _prefixId.prefix "kelvinPerWatt"
    let kibi = _prefixId.prefix "kibi"
    let kibibit = _prefixId.prefix "kibibit"
    let kibibyte = _prefixId.prefix "kibibyte"
    let kilo = _prefixId.prefix "kilo"
    let kiloampere = _prefixId.prefix "kiloampere"
    let kilobecquerel = _prefixId.prefix "kilobecquerel"
    let kilobit = _prefixId.prefix "kilobit"
    let kilobyte = _prefixId.prefix "kilobyte"
    let kilocalorie_Mean = _prefixId.prefix "kilocalorie-Mean"
    let kilocalorie_MeanPerDay = _prefixId.prefix "kilocalorie-MeanPerDay"
    let kilocalorie_MeanPerHectogram = _prefixId.prefix "kilocalorie-MeanPerHectogram"
    let kilocandela = _prefixId.prefix "kilocandela"
    let kilocoulomb = _prefixId.prefix "kilocoulomb"
    let kiloelectronvolt = _prefixId.prefix "kiloelectronvolt"
    let kilofarad = _prefixId.prefix "kilofarad"
    let kilogram = _prefixId.prefix "kilogram"
    let kilogramPerCubicDecimetre = _prefixId.prefix "kilogramPerCubicDecimetre"
    let kilogramPerCubicmetre = _prefixId.prefix "kilogramPerCubicmetre"
    let kilogramPerGigajoule = _prefixId.prefix "kilogramPerGigajoule"
    let kilogramPerHectare = _prefixId.prefix "kilogramPerHectare"
    let kilogramPerHectareDay = _prefixId.prefix "kilogramPerHectareDay"
    let kilogramPerKilogram = _prefixId.prefix "kilogramPerKilogram"
    let kilogramPerLitre = _prefixId.prefix "kilogramPerLitre"
    let kilogramPerMole = _prefixId.prefix "kilogramPerMole"

    let kilogramPerPascalSecond_TimeSquareMetre = _prefixId.prefix "kilogramPerPascalSecond-TimeSquareMetre"

    let kilogramPerSecond_Time = _prefixId.prefix "kilogramPerSecond-Time"
    let kilogramPerSquareMetre = _prefixId.prefix "kilogramPerSquareMetre"

    let kilogramSecond_TimeToThePower_2 = _prefixId.prefix "kilogramSecond-TimeToThePower-2"

    let kilogramSecond_TimeToThePower_2ReciprocalMetre = _prefixId.prefix "kilogramSecond-TimeToThePower-2ReciprocalMetre"

    let kilogramSquareMetre = _prefixId.prefix "kilogramSquareMetre"
    let kilogray = _prefixId.prefix "kilogray"
    let kilohenry = _prefixId.prefix "kilohenry"
    let kilohertz = _prefixId.prefix "kilohertz"
    let kilohm = _prefixId.prefix "kilohm"
    let kilojoule = _prefixId.prefix "kilojoule"
    let kilojoulePerHectogram = _prefixId.prefix "kilojoulePerHectogram"
    let kilojoulePerSquareMetreDay = _prefixId.prefix "kilojoulePerSquareMetreDay"
    let kilokatal = _prefixId.prefix "kilokatal"
    let kilokelvin = _prefixId.prefix "kilokelvin"
    let kilolitre = _prefixId.prefix "kilolitre"
    let kilolumen = _prefixId.prefix "kilolumen"
    let kilolux = _prefixId.prefix "kilolux"
    let kilometre = _prefixId.prefix "kilometre"
    let kilometrePerHour = _prefixId.prefix "kilometrePerHour"
    let kilometrePerSecond_Time = _prefixId.prefix "kilometrePerSecond-Time"

    let kilometrePerSecond_TimePerMegaparsec = _prefixId.prefix "kilometrePerSecond-TimePerMegaparsec"

    let kilometrePerSecond_TimeSquared = _prefixId.prefix "kilometrePerSecond-TimeSquared"

    let kilomolair = _prefixId.prefix "kilomolair"
    let kilomole = _prefixId.prefix "kilomole"
    let kilomolePerLitre = _prefixId.prefix "kilomolePerLitre"
    let kilomolePerMetre = _prefixId.prefix "kilomolePerMetre"
    let kilonewton = _prefixId.prefix "kilonewton"
    let kiloparsec = _prefixId.prefix "kiloparsec"
    let kilopascal = _prefixId.prefix "kilopascal"
    let kilosecond_Time = _prefixId.prefix "kilosecond-Time"
    let kilosecond_TimeSquared = _prefixId.prefix "kilosecond-TimeSquared"
    let kilosiemens = _prefixId.prefix "kilosiemens"
    let kilosievert = _prefixId.prefix "kilosievert"
    let kilotesla = _prefixId.prefix "kilotesla"
    let kilotonne = _prefixId.prefix "kilotonne"
    let kilovolt = _prefixId.prefix "kilovolt"
    let kilowatt = _prefixId.prefix "kilowatt"
    let kilowattHour = _prefixId.prefix "kilowattHour"
    let kiloweber = _prefixId.prefix "kiloweber"

    let kinematicViscosityOrThermalDiffusivity_Dimension = _prefixId.prefix "kinematicViscosityOrThermalDiffusivity-Dimension"

    let kip = _prefixId.prefix "kip"
    let knot_International = _prefixId.prefix "knot-International"
    let lambert = _prefixId.prefix "lambert"
    let last = _prefixId.prefix "last"
    let length_Dimension = _prefixId.prefix "length-Dimension"

    let lengthOfThePathTravelledByLightInVacuumDuringATimeIntervalOf1299792458OfASecond =
        _prefixId.prefix "lengthOfThePathTravelledByLightInVacuumDuringATimeIntervalOf1299792458OfASecond"

    let lightYear = _prefixId.prefix "lightYear"
    let liquidPint_US = _prefixId.prefix "liquidPint-US"
    let liquidQuart_US = _prefixId.prefix "liquidQuart-US"
    let litre = _prefixId.prefix "litre"
    let litrePer100Kilometre = _prefixId.prefix "litrePer100Kilometre"
    let litrePerHour = _prefixId.prefix "litrePerHour"
    let litrePerMole = _prefixId.prefix "litrePerMole"
    /// <summary>
    ///   <para>oum:alternativeLabel : long commentoum:alternativeLabel : has longcommentoum:alternativeLabel : 詳細な注釈がある</para>
    ///   <para>rdfs:label : longcommentrdfs:label : 詳細な注釈</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/longcomment">oum:longcomment</a>
    /// </summary>
    let longcomment = _prefixId.prefix "longcomment"
    let lumen = _prefixId.prefix "lumen"
    let lumenPerSquareMetre = _prefixId.prefix "lumenPerSquareMetre"
    let lumenPerWatt = _prefixId.prefix "lumenPerWatt"
    let lumenSecond_Time = _prefixId.prefix "lumenSecond-Time"
    let luminance_Dimension = _prefixId.prefix "luminance-Dimension"
    let luminousEfficacy_Dimension = _prefixId.prefix "luminousEfficacy-Dimension"
    let luminousEnergy_Dimension = _prefixId.prefix "luminousEnergy-Dimension"
    let luminousFlux_Dimension = _prefixId.prefix "luminousFlux-Dimension"
    let luminousIntensity_Dimension = _prefixId.prefix "luminousIntensity-Dimension"

    let luminousIntensityInAGivenDirectionOfASourceThatEmitsMonochromaticRadiationOfFrequency540e12HertzAndThatHasARadiantIntensityInThatDirectionOf1683WattPerSteradian =
        _prefixId.prefix
            "luminousIntensityInAGivenDirectionOfASourceThatEmitsMonochromaticRadiationOfFrequency540e12HertzAndThatHasARadiantIntensityInThatDirectionOf1683WattPerSteradian"

    let lux = _prefixId.prefix "lux"
    let luxSecond_Time = _prefixId.prefix "luxSecond-Time"
    let magneticFlux_Dimension = _prefixId.prefix "magneticFlux-Dimension"
    let magneticFluxDensity_Dimension = _prefixId.prefix "magneticFluxDensity-Dimension"
    let magnitude = _prefixId.prefix "magnitude"

    let magnitudePerSecond_AngleSquared = _prefixId.prefix "magnitudePerSecond-AngleSquared"

    let mass_Dimension = _prefixId.prefix "mass-Dimension"
    let massFlow_Dimension = _prefixId.prefix "massFlow-Dimension"

    let massOfTheInternationalPrototypeOfTheKilogram = _prefixId.prefix "massOfTheInternationalPrototypeOfTheKilogram"

    let maximum = _prefixId.prefix "maximum"
    let maxwell = _prefixId.prefix "maxwell"
    let mebi = _prefixId.prefix "mebi"
    let mebibit = _prefixId.prefix "mebibit"
    let mebibyte = _prefixId.prefix "mebibyte"
    let mechanics = _prefixId.prefix "mechanics"
    let median = _prefixId.prefix "median"
    let mega = _prefixId.prefix "mega"
    let megaampere = _prefixId.prefix "megaampere"
    let megabecquerel = _prefixId.prefix "megabecquerel"
    let megabit = _prefixId.prefix "megabit"
    let megabyte = _prefixId.prefix "megabyte"
    let megacandela = _prefixId.prefix "megacandela"
    let megacoulomb = _prefixId.prefix "megacoulomb"
    let megaelectronvolt = _prefixId.prefix "megaelectronvolt"
    let megaerg = _prefixId.prefix "megaerg"
    let megaeuro = _prefixId.prefix "megaeuro"
    let megaeuroPerMegatonne = _prefixId.prefix "megaeuroPerMegatonne"
    let megaeuroPerMegawatt = _prefixId.prefix "megaeuroPerMegawatt"
    let megaeuroPerPetajoule = _prefixId.prefix "megaeuroPerPetajoule"
    let megafarad = _prefixId.prefix "megafarad"
    let megagram = _prefixId.prefix "megagram"
    let megagramPerLitre = _prefixId.prefix "megagramPerLitre"
    let megagray = _prefixId.prefix "megagray"
    let megahenry = _prefixId.prefix "megahenry"
    let megahertz = _prefixId.prefix "megahertz"
    let megajoule = _prefixId.prefix "megajoule"
    let megajoulePerSquareMetre = _prefixId.prefix "megajoulePerSquareMetre"
    let megajoulePerSquareMetreDay = _prefixId.prefix "megajoulePerSquareMetreDay"
    let megakatal = _prefixId.prefix "megakatal"
    let megakelvin = _prefixId.prefix "megakelvin"
    let megalitre = _prefixId.prefix "megalitre"
    let megalumen = _prefixId.prefix "megalumen"
    let megalux = _prefixId.prefix "megalux"
    let megametre = _prefixId.prefix "megametre"
    let megametrePerKilojoule = _prefixId.prefix "megametrePerKilojoule"
    let megametrePerSecond_Time = _prefixId.prefix "megametrePerSecond-Time"

    let megametrePerSecond_TimeSquared = _prefixId.prefix "megametrePerSecond-TimeSquared"

    let megamolair = _prefixId.prefix "megamolair"
    let megamole = _prefixId.prefix "megamole"
    let megamolePerLitre = _prefixId.prefix "megamolePerLitre"
    let megamolePerMetre = _prefixId.prefix "megamolePerMetre"
    let meganewton = _prefixId.prefix "meganewton"
    let megaparsec = _prefixId.prefix "megaparsec"
    let megapascal = _prefixId.prefix "megapascal"
    let megasecond_Time = _prefixId.prefix "megasecond-Time"
    let megasecond_TimeSquared = _prefixId.prefix "megasecond-TimeSquared"
    let megasiemens = _prefixId.prefix "megasiemens"
    let megasievert = _prefixId.prefix "megasievert"
    let megatesla = _prefixId.prefix "megatesla"
    let megatonne = _prefixId.prefix "megatonne"
    let megavolt = _prefixId.prefix "megavolt"
    let megawatt = _prefixId.prefix "megawatt"
    let megaweber = _prefixId.prefix "megaweber"
    let megohm = _prefixId.prefix "megohm"
    let metre = _prefixId.prefix "metre"

    let metre_Kilogram_Second_AmpereSystemOfUnits = _prefixId.prefix "metre-Kilogram-Second-AmpereSystemOfUnits"

    let metreKelvin = _prefixId.prefix "metreKelvin"
    let metreKilogram = _prefixId.prefix "metreKilogram"
    let metreKilogramPerSecond_Time = _prefixId.prefix "metreKilogramPerSecond-Time"

    let metreKilogramPerSecond_TimeSquared = _prefixId.prefix "metreKilogramPerSecond-TimeSquared"

    let metreOfMercury = _prefixId.prefix "metreOfMercury"
    let metrePerAttosecond_Time = _prefixId.prefix "metrePerAttosecond-Time"

    let metrePerAttosecond_TimeSquared = _prefixId.prefix "metrePerAttosecond-TimeSquared"

    let metrePerCentisecond_Time = _prefixId.prefix "metrePerCentisecond-Time"

    let metrePerCentisecond_TimeSquared = _prefixId.prefix "metrePerCentisecond-TimeSquared"

    let metrePerCubicMetre = _prefixId.prefix "metrePerCubicMetre"
    let metrePerDay = _prefixId.prefix "metrePerDay"
    let metrePerDecasecond_Time = _prefixId.prefix "metrePerDecasecond-Time"

    let metrePerDecasecond_TimeSquared = _prefixId.prefix "metrePerDecasecond-TimeSquared"

    let metrePerDecisecond_Time = _prefixId.prefix "metrePerDecisecond-Time"

    let metrePerDecisecond_TimeSquared = _prefixId.prefix "metrePerDecisecond-TimeSquared"

    let metrePerExasecond_Time = _prefixId.prefix "metrePerExasecond-Time"
    let metrePerExasecond_TimeSquared = _prefixId.prefix "metrePerExasecond-TimeSquared"
    let metrePerFemtosecond_Time = _prefixId.prefix "metrePerFemtosecond-Time"

    let metrePerFemtosecond_TimeSquared = _prefixId.prefix "metrePerFemtosecond-TimeSquared"

    let metrePerGigasecond_Time = _prefixId.prefix "metrePerGigasecond-Time"

    let metrePerGigasecond_TimeSquared = _prefixId.prefix "metrePerGigasecond-TimeSquared"

    let metrePerHectosecond_Time = _prefixId.prefix "metrePerHectosecond-Time"

    let metrePerHectosecond_TimeSquared = _prefixId.prefix "metrePerHectosecond-TimeSquared"

    let metrePerKilosecond_Time = _prefixId.prefix "metrePerKilosecond-Time"

    let metrePerKilosecond_TimeSquared = _prefixId.prefix "metrePerKilosecond-TimeSquared"

    let metrePerMegasecond_Time = _prefixId.prefix "metrePerMegasecond-Time"

    let metrePerMegasecond_TimeSquared = _prefixId.prefix "metrePerMegasecond-TimeSquared"

    let metrePerMetre = _prefixId.prefix "metrePerMetre"
    let metrePerMicrosecond_Time = _prefixId.prefix "metrePerMicrosecond-Time"

    let metrePerMicrosecond_TimeSquared = _prefixId.prefix "metrePerMicrosecond-TimeSquared"

    let metrePerMillisecond_Time = _prefixId.prefix "metrePerMillisecond-Time"

    let metrePerMillisecond_TimeSquared = _prefixId.prefix "metrePerMillisecond-TimeSquared"

    let metrePerNanosecond_Time = _prefixId.prefix "metrePerNanosecond-Time"

    let metrePerNanosecond_TimeSquared = _prefixId.prefix "metrePerNanosecond-TimeSquared"

    let metrePerPetasecond_Time = _prefixId.prefix "metrePerPetasecond-Time"

    let metrePerPetasecond_TimeSquared = _prefixId.prefix "metrePerPetasecond-TimeSquared"

    let metrePerPicosecond_Time = _prefixId.prefix "metrePerPicosecond-Time"

    let metrePerPicosecond_TimeSquared = _prefixId.prefix "metrePerPicosecond-TimeSquared"

    let metrePerSecond_Time = _prefixId.prefix "metrePerSecond-Time"
    let metrePerSecond_TimePerMetre = _prefixId.prefix "metrePerSecond-TimePerMetre"
    let metrePerSecond_TimeSquared = _prefixId.prefix "metrePerSecond-TimeSquared"
    let metrePerTerasecond_Time = _prefixId.prefix "metrePerTerasecond-Time"

    let metrePerTerasecond_TimeSquared = _prefixId.prefix "metrePerTerasecond-TimeSquared"

    let metrePerYoctosecond_Time = _prefixId.prefix "metrePerYoctosecond-Time"

    let metrePerYoctosecond_TimeSquared = _prefixId.prefix "metrePerYoctosecond-TimeSquared"

    let metrePerYottasecond_Time = _prefixId.prefix "metrePerYottasecond-Time"

    let metrePerYottasecond_TimeSquared = _prefixId.prefix "metrePerYottasecond-TimeSquared"

    let metrePerZeptosecond_Time = _prefixId.prefix "metrePerZeptosecond-Time"

    let metrePerZeptosecond_TimeSquared = _prefixId.prefix "metrePerZeptosecond-TimeSquared"

    let metrePerZettasecond_Time = _prefixId.prefix "metrePerZettasecond-Time"

    let metrePerZettasecond_TimeSquared = _prefixId.prefix "metrePerZettasecond-TimeSquared"

    let mho = _prefixId.prefix "mho"
    let micro = _prefixId.prefix "micro"
    let microampere = _prefixId.prefix "microampere"
    let microbar = _prefixId.prefix "microbar"
    let microbecquerel = _prefixId.prefix "microbecquerel"
    let microcandela = _prefixId.prefix "microcandela"
    let microcoulomb = _prefixId.prefix "microcoulomb"
    let microdegreeCelsius = _prefixId.prefix "microdegreeCelsius"
    let microfarad = _prefixId.prefix "microfarad"
    let microgram = _prefixId.prefix "microgram"
    let microgramPerCubicCentimetre = _prefixId.prefix "microgramPerCubicCentimetre"
    let microgramPerHectogram = _prefixId.prefix "microgramPerHectogram"
    let microgramPerJoule = _prefixId.prefix "microgramPerJoule"
    let microgramPerLitre = _prefixId.prefix "microgramPerLitre"

    let microgramPerSquareMetreSecond_Time = _prefixId.prefix "microgramPerSquareMetreSecond-Time"

    let microgray = _prefixId.prefix "microgray"
    let microhenry = _prefixId.prefix "microhenry"
    let microhertz = _prefixId.prefix "microhertz"
    let microjoule = _prefixId.prefix "microjoule"
    let microkatal = _prefixId.prefix "microkatal"
    let microkelvin = _prefixId.prefix "microkelvin"
    let microlitre = _prefixId.prefix "microlitre"
    let microlumen = _prefixId.prefix "microlumen"
    let microlux = _prefixId.prefix "microlux"
    let micromagnitude = _prefixId.prefix "micromagnitude"
    let micrometre = _prefixId.prefix "micrometre"
    let micrometrePerSecond_Time = _prefixId.prefix "micrometrePerSecond-Time"

    let micrometrePerSecond_TimeSquared = _prefixId.prefix "micrometrePerSecond-TimeSquared"

    let micromolair = _prefixId.prefix "micromolair"
    let micromole = _prefixId.prefix "micromole"
    let micromolePerLitre = _prefixId.prefix "micromolePerLitre"
    let micromolePerMetre = _prefixId.prefix "micromolePerMetre"
    let micromolePerMole = _prefixId.prefix "micromolePerMole"
    let micromolePerSecond_Time = _prefixId.prefix "micromolePerSecond-Time"
    let micromolePerSecond_TimeGram = _prefixId.prefix "micromolePerSecond-TimeGram"
    let micron = _prefixId.prefix "micron"
    let micronewton = _prefixId.prefix "micronewton"
    let micronewtonMetre = _prefixId.prefix "micronewtonMetre"
    let microohm = _prefixId.prefix "microohm"
    let micropascal = _prefixId.prefix "micropascal"
    let microradian = _prefixId.prefix "microradian"
    let microsecond_Angle = _prefixId.prefix "microsecond-Angle"
    let microsecond_Time = _prefixId.prefix "microsecond-Time"
    let microsecond_TimeSquared = _prefixId.prefix "microsecond-TimeSquared"
    let microsiemens = _prefixId.prefix "microsiemens"
    let microsievert = _prefixId.prefix "microsievert"
    let microsteradian = _prefixId.prefix "microsteradian"
    let microtesla = _prefixId.prefix "microtesla"
    let microvolt = _prefixId.prefix "microvolt"
    let microwatt = _prefixId.prefix "microwatt"
    let microweber = _prefixId.prefix "microweber"
    let mil_Angle = _prefixId.prefix "mil-Angle"
    let mil_Length = _prefixId.prefix "mil-Length"
    let mile_Statute = _prefixId.prefix "mile-Statute"
    let mile_StatutePerHour = _prefixId.prefix "mile-StatutePerHour"
    let mile_USSurvey = _prefixId.prefix "mile-USSurvey"
    let milli = _prefixId.prefix "milli"
    let milliampere = _prefixId.prefix "milliampere"
    let millibar = _prefixId.prefix "millibar"
    let millibecquerel = _prefixId.prefix "millibecquerel"
    let millicandela = _prefixId.prefix "millicandela"
    let millicoulomb = _prefixId.prefix "millicoulomb"
    let millidegreeCelsius = _prefixId.prefix "millidegreeCelsius"
    let millifarad = _prefixId.prefix "millifarad"
    let milligauss = _prefixId.prefix "milligauss"
    let milligram = _prefixId.prefix "milligram"
    let milligramPerCubicmetre = _prefixId.prefix "milligramPerCubicmetre"
    let milligramPerDay = _prefixId.prefix "milligramPerDay"
    let milligramPerHectogram = _prefixId.prefix "milligramPerHectogram"
    let milligramPerKilogram = _prefixId.prefix "milligramPerKilogram"
    let milligramPerKilometre = _prefixId.prefix "milligramPerKilometre"
    let milligramPerLitre = _prefixId.prefix "milligramPerLitre"
    let milligramPerday = _prefixId.prefix "milligramPerday"
    let milligramRAE = _prefixId.prefix "milligramRAE"
    let milligray = _prefixId.prefix "milligray"
    let millihenry = _prefixId.prefix "millihenry"
    let millihertz = _prefixId.prefix "millihertz"
    let millijoule = _prefixId.prefix "millijoule"
    let millikatal = _prefixId.prefix "millikatal"
    let millikelvin = _prefixId.prefix "millikelvin"
    let millilitre = _prefixId.prefix "millilitre"
    let millilumen = _prefixId.prefix "millilumen"
    let millilux = _prefixId.prefix "millilux"
    let millimagnitude = _prefixId.prefix "millimagnitude"
    let millimetre = _prefixId.prefix "millimetre"
    let millimetreOfMercury = _prefixId.prefix "millimetreOfMercury"
    let millimetrePerDay = _prefixId.prefix "millimetrePerDay"
    let millimetrePerHour = _prefixId.prefix "millimetrePerHour"
    let millimetrePerSecond_Time = _prefixId.prefix "millimetrePerSecond-Time"

    let millimetrePerSecond_TimeSquared = _prefixId.prefix "millimetrePerSecond-TimeSquared"

    let millimolair = _prefixId.prefix "millimolair"
    let millimole = _prefixId.prefix "millimole"
    let millimolePerLitre = _prefixId.prefix "millimolePerLitre"
    let millimolePerMetre = _prefixId.prefix "millimolePerMetre"
    let millinewton = _prefixId.prefix "millinewton"
    let millinewtonMetre = _prefixId.prefix "millinewtonMetre"
    let milliohm = _prefixId.prefix "milliohm"
    let millipascal = _prefixId.prefix "millipascal"
    let milliradian = _prefixId.prefix "milliradian"
    let millisecond_Angle = _prefixId.prefix "millisecond-Angle"
    let millisecond_AnglePerYear = _prefixId.prefix "millisecond-AnglePerYear"
    let millisecond_Time = _prefixId.prefix "millisecond-Time"
    let millisecond_TimeSquared = _prefixId.prefix "millisecond-TimeSquared"
    let millisiemens = _prefixId.prefix "millisiemens"
    let millisievert = _prefixId.prefix "millisievert"
    let millisteradian = _prefixId.prefix "millisteradian"
    let millitesla = _prefixId.prefix "millitesla"
    let millivolt = _prefixId.prefix "millivolt"
    let milliwatt = _prefixId.prefix "milliwatt"
    let milliweber = _prefixId.prefix "milliweber"
    let minimum = _prefixId.prefix "minimum"
    let minute_Angle = _prefixId.prefix "minute-Angle"
    let minute_HourAngle = _prefixId.prefix "minute-HourAngle"
    let minute_Sidereal = _prefixId.prefix "minute-Sidereal"
    let minute_Time = _prefixId.prefix "minute-Time"
    let molair = _prefixId.prefix "molair"
    let molarEnergy_Dimension = _prefixId.prefix "molarEnergy-Dimension"

    let molarEntropyOrMolarHeatCapacityOrGasConstant_Dimension = _prefixId.prefix "molarEntropyOrMolarHeatCapacityOrGasConstant-Dimension"

    let mole = _prefixId.prefix "mole"
    let moleMicrometre = _prefixId.prefix "moleMicrometre"

    let moleMicrometreReciprocalSquareCentimetre = _prefixId.prefix "moleMicrometreReciprocalSquareCentimetre"

    let moleMicrometreReciprocalSquareCentimetreReciprocalSecond_Time = _prefixId.prefix "moleMicrometreReciprocalSquareCentimetreReciprocalSecond-Time"

    let molePerAttolitre = _prefixId.prefix "molePerAttolitre"
    let molePerAttometre = _prefixId.prefix "molePerAttometre"
    let molePerCentilitre = _prefixId.prefix "molePerCentilitre"
    let molePerCentimetre = _prefixId.prefix "molePerCentimetre"
    let molePerCubicmetre = _prefixId.prefix "molePerCubicmetre"
    let molePerDecalitre = _prefixId.prefix "molePerDecalitre"
    let molePerDecametre = _prefixId.prefix "molePerDecametre"
    let molePerDecilitre = _prefixId.prefix "molePerDecilitre"
    let molePerDecimetre = _prefixId.prefix "molePerDecimetre"
    let molePerExalitre = _prefixId.prefix "molePerExalitre"
    let molePerExametre = _prefixId.prefix "molePerExametre"
    let molePerFemtolitre = _prefixId.prefix "molePerFemtolitre"
    let molePerFemtometre = _prefixId.prefix "molePerFemtometre"
    let molePerGigalitre = _prefixId.prefix "molePerGigalitre"
    let molePerGigametre = _prefixId.prefix "molePerGigametre"
    let molePerHectolitre = _prefixId.prefix "molePerHectolitre"
    let molePerHectometre = _prefixId.prefix "molePerHectometre"
    let molePerKilogram = _prefixId.prefix "molePerKilogram"
    let molePerKilolitre = _prefixId.prefix "molePerKilolitre"
    let molePerKilometre = _prefixId.prefix "molePerKilometre"
    let molePerLitre = _prefixId.prefix "molePerLitre"
    let molePerMegalitre = _prefixId.prefix "molePerMegalitre"
    let molePerMetre = _prefixId.prefix "molePerMetre"
    let molePerMicrolitre = _prefixId.prefix "molePerMicrolitre"
    let molePerMicrometre = _prefixId.prefix "molePerMicrometre"
    let molePerMillilitre = _prefixId.prefix "molePerMillilitre"
    let molePerMillimetre = _prefixId.prefix "molePerMillimetre"
    let molePerMole = _prefixId.prefix "molePerMole"
    let molePerNanolitre = _prefixId.prefix "molePerNanolitre"
    let molePerNanometre = _prefixId.prefix "molePerNanometre"
    let molePerPetalitre = _prefixId.prefix "molePerPetalitre"
    let molePerPetametre = _prefixId.prefix "molePerPetametre"
    let molePerPicolitre = _prefixId.prefix "molePerPicolitre"
    let molePerPicometre = _prefixId.prefix "molePerPicometre"
    let molePerSecond_Time = _prefixId.prefix "molePerSecond-Time"
    let molePerTeralitre = _prefixId.prefix "molePerTeralitre"
    let molePerTerametre = _prefixId.prefix "molePerTerametre"
    let molePerYoctolitre = _prefixId.prefix "molePerYoctolitre"
    let molePerYoctometre = _prefixId.prefix "molePerYoctometre"
    let molePerYottalitre = _prefixId.prefix "molePerYottalitre"
    let molePerYottametre = _prefixId.prefix "molePerYottametre"
    let molePerZeptolitre = _prefixId.prefix "molePerZeptolitre"
    let molePerZeptometre = _prefixId.prefix "molePerZeptometre"
    let molePerZettalitre = _prefixId.prefix "molePerZettalitre"
    let molePerZettametre = _prefixId.prefix "molePerZettametre"
    let molePermegametre = _prefixId.prefix "molePermegametre"
    let month = _prefixId.prefix "month"
    let nano = _prefixId.prefix "nano"
    let nanoampere = _prefixId.prefix "nanoampere"
    let nanobecquerel = _prefixId.prefix "nanobecquerel"
    let nanocandela = _prefixId.prefix "nanocandela"
    let nanocoulomb = _prefixId.prefix "nanocoulomb"
    let nanodegreeCelsius = _prefixId.prefix "nanodegreeCelsius"
    let nanofarad = _prefixId.prefix "nanofarad"
    let nanogram = _prefixId.prefix "nanogram"
    let nanogramPerLitre = _prefixId.prefix "nanogramPerLitre"
    let nanogray = _prefixId.prefix "nanogray"
    let nanohenry = _prefixId.prefix "nanohenry"
    let nanohertz = _prefixId.prefix "nanohertz"
    let nanojoule = _prefixId.prefix "nanojoule"
    let nanokatal = _prefixId.prefix "nanokatal"
    let nanokatalPerMilligram = _prefixId.prefix "nanokatalPerMilligram"
    let nanokelvin = _prefixId.prefix "nanokelvin"
    let nanolitre = _prefixId.prefix "nanolitre"
    let nanolumen = _prefixId.prefix "nanolumen"
    let nanolux = _prefixId.prefix "nanolux"
    let nanometre = _prefixId.prefix "nanometre"
    let nanometrePerSecond_Time = _prefixId.prefix "nanometrePerSecond-Time"

    let nanometrePerSecond_TimeSquared = _prefixId.prefix "nanometrePerSecond-TimeSquared"

    let nanomolair = _prefixId.prefix "nanomolair"
    let nanomole = _prefixId.prefix "nanomole"
    let nanomolePerLitre = _prefixId.prefix "nanomolePerLitre"
    let nanomolePerMetre = _prefixId.prefix "nanomolePerMetre"
    let nanonewton = _prefixId.prefix "nanonewton"
    let nanoohm = _prefixId.prefix "nanoohm"
    let nanopascal = _prefixId.prefix "nanopascal"
    let nanoradian = _prefixId.prefix "nanoradian"
    let nanosecond_Time = _prefixId.prefix "nanosecond-Time"
    let nanosecond_TimeSquared = _prefixId.prefix "nanosecond-TimeSquared"
    let nanosiemens = _prefixId.prefix "nanosiemens"
    let nanosievert = _prefixId.prefix "nanosievert"
    let nanosteradian = _prefixId.prefix "nanosteradian"
    let nanotesla = _prefixId.prefix "nanotesla"
    let nanounifiedAtomicMassUnit = _prefixId.prefix "nanounifiedAtomicMassUnit"
    let nanovolt = _prefixId.prefix "nanovolt"
    let nanowatt = _prefixId.prefix "nanowatt"
    let nanoweber = _prefixId.prefix "nanoweber"
    let nauticalMile_International = _prefixId.prefix "nauticalMile-International"

    let nauticalMile_InternationalPerHour = _prefixId.prefix "nauticalMile-InternationalPerHour"

    let newton = _prefixId.prefix "newton"
    let newtonMetre = _prefixId.prefix "newtonMetre"
    let newtonPerCoulomb = _prefixId.prefix "newtonPerCoulomb"
    let newtonPerMetre = _prefixId.prefix "newtonPerMetre"
    let newtonPerSquareMetre = _prefixId.prefix "newtonPerSquareMetre"
    let numberDensity_Dimension = _prefixId.prefix "numberDensity-Dimension"
    let oersted = _prefixId.prefix "oersted"
    let ohm = _prefixId.prefix "ohm"
    let ohmMetre = _prefixId.prefix "ohmMetre"
    let one = _prefixId.prefix "one"
    let oneBinaryDigit = _prefixId.prefix "oneBinaryDigit"

    let oneDistinctSymbolChangeOrSignallingEventMadeToTheTransmissionMediumPerSecondInADigitallyModulatedSignalOrALineCode =
        _prefixId.prefix "oneDistinctSymbolChangeOrSignallingEventMadeToTheTransmissionMediumPerSecondInADigitallyModulatedSignalOrALineCode"

    let ounceApothecaries = _prefixId.prefix "ounceApothecaries"
    let ounceAvoirdupois = _prefixId.prefix "ounceAvoirdupois"
    let parsec = _prefixId.prefix "parsec"
    let partsPerMillion = _prefixId.prefix "partsPerMillion"
    let partsPerMillionPerYear = _prefixId.prefix "partsPerMillionPerYear"
    let pascal = _prefixId.prefix "pascal"
    let pascalSecond_Time = _prefixId.prefix "pascalSecond-Time"
    let pascalSecond_TimeSquareMetre = _prefixId.prefix "pascalSecond-TimeSquareMetre"

    let pathTravelledByLightInVacuumDuringATimeIntervalOf1299792458OfASecond = _prefixId.prefix "pathTravelledByLightInVacuumDuringATimeIntervalOf1299792458OfASecond"

    let pebi = _prefixId.prefix "pebi"
    let pebibit = _prefixId.prefix "pebibit"
    let pebibyte = _prefixId.prefix "pebibyte"
    let peck_US = _prefixId.prefix "peck-US"
    let pennyweight_Troy = _prefixId.prefix "pennyweight-Troy"
    let percent = _prefixId.prefix "percent"
    let perm_0C = _prefixId.prefix "perm-0C"
    let perm_23C = _prefixId.prefix "perm-23C"

    let permeabilityOfFreeSpace_Dimension = _prefixId.prefix "permeabilityOfFreeSpace-Dimension"

    let permeance_MaterialsScience_Dimension = _prefixId.prefix "permeance-MaterialsScience-Dimension"

    let permittivity_Dimension = _prefixId.prefix "permittivity-Dimension"
    let peta = _prefixId.prefix "peta"
    let petaampere = _prefixId.prefix "petaampere"
    let petabecquerel = _prefixId.prefix "petabecquerel"
    let petabit = _prefixId.prefix "petabit"
    let petabyte = _prefixId.prefix "petabyte"
    let petacandela = _prefixId.prefix "petacandela"
    let petacoulomb = _prefixId.prefix "petacoulomb"
    let petafarad = _prefixId.prefix "petafarad"
    let petagram = _prefixId.prefix "petagram"
    let petagramPerLitre = _prefixId.prefix "petagramPerLitre"
    let petagray = _prefixId.prefix "petagray"
    let petahenry = _prefixId.prefix "petahenry"
    let petahertz = _prefixId.prefix "petahertz"
    let petajoule = _prefixId.prefix "petajoule"
    let petakatal = _prefixId.prefix "petakatal"
    let petakelvin = _prefixId.prefix "petakelvin"
    let petalitre = _prefixId.prefix "petalitre"
    let petalumen = _prefixId.prefix "petalumen"
    let petalux = _prefixId.prefix "petalux"
    let petametre = _prefixId.prefix "petametre"
    let petametrePerSecond_Time = _prefixId.prefix "petametrePerSecond-Time"

    let petametrePerSecond_TimeSquared = _prefixId.prefix "petametrePerSecond-TimeSquared"

    let petamolair = _prefixId.prefix "petamolair"
    let petamole = _prefixId.prefix "petamole"
    let petamolePerLitre = _prefixId.prefix "petamolePerLitre"
    let petamolePerMetre = _prefixId.prefix "petamolePerMetre"
    let petanewton = _prefixId.prefix "petanewton"
    let petaohm = _prefixId.prefix "petaohm"
    let petapascal = _prefixId.prefix "petapascal"
    let petasecond_Time = _prefixId.prefix "petasecond-Time"
    let petasecond_TimeSquared = _prefixId.prefix "petasecond-TimeSquared"
    let petasiemens = _prefixId.prefix "petasiemens"
    let petasievert = _prefixId.prefix "petasievert"
    let petatesla = _prefixId.prefix "petatesla"
    let petavolt = _prefixId.prefix "petavolt"
    let petawatt = _prefixId.prefix "petawatt"
    let petaweber = _prefixId.prefix "petaweber"
    let phot = _prefixId.prefix "phot"
    let photometry = _prefixId.prefix "photometry"
    let pica_ATA = _prefixId.prefix "pica-ATA"
    let pica_Postscript = _prefixId.prefix "pica-Postscript"
    let pica_TeX = _prefixId.prefix "pica-TeX"
    let pico = _prefixId.prefix "pico"
    let picoampere = _prefixId.prefix "picoampere"
    let picobecquerel = _prefixId.prefix "picobecquerel"
    let picocandela = _prefixId.prefix "picocandela"
    let picocoulomb = _prefixId.prefix "picocoulomb"
    let picodegreeCelsius = _prefixId.prefix "picodegreeCelsius"
    let picofarad = _prefixId.prefix "picofarad"
    let picogram = _prefixId.prefix "picogram"
    let picogramPerLitre = _prefixId.prefix "picogramPerLitre"
    let picogray = _prefixId.prefix "picogray"
    let picohenry = _prefixId.prefix "picohenry"
    let picohertz = _prefixId.prefix "picohertz"
    let picojoule = _prefixId.prefix "picojoule"
    let picokatal = _prefixId.prefix "picokatal"
    let picokelvin = _prefixId.prefix "picokelvin"
    let picolitre = _prefixId.prefix "picolitre"
    let picolumen = _prefixId.prefix "picolumen"
    let picolux = _prefixId.prefix "picolux"
    let picometre = _prefixId.prefix "picometre"
    let picometrePerSecond_Time = _prefixId.prefix "picometrePerSecond-Time"

    let picometrePerSecond_TimeSquared = _prefixId.prefix "picometrePerSecond-TimeSquared"

    let picomolair = _prefixId.prefix "picomolair"
    let picomole = _prefixId.prefix "picomole"
    let picomolePerLitre = _prefixId.prefix "picomolePerLitre"
    let picomolePerMetre = _prefixId.prefix "picomolePerMetre"
    let piconewton = _prefixId.prefix "piconewton"
    let picoohm = _prefixId.prefix "picoohm"
    let picopascal = _prefixId.prefix "picopascal"
    let picoradian = _prefixId.prefix "picoradian"
    let picosecond_Time = _prefixId.prefix "picosecond-Time"
    let picosecond_TimeSquared = _prefixId.prefix "picosecond-TimeSquared"
    let picosiemens = _prefixId.prefix "picosiemens"
    let picosievert = _prefixId.prefix "picosievert"
    let picosteradian = _prefixId.prefix "picosteradian"
    let picotesla = _prefixId.prefix "picotesla"
    let picovolt = _prefixId.prefix "picovolt"
    let picowatt = _prefixId.prefix "picowatt"
    let picoweber = _prefixId.prefix "picoweber"
    let piece = _prefixId.prefix "piece"
    let pinch = _prefixId.prefix "pinch"
    let pint_Imperial = _prefixId.prefix "pint-Imperial"
    let point_ATA = _prefixId.prefix "point-ATA"
    let point_Didot = _prefixId.prefix "point-Didot"
    let point_Postscript = _prefixId.prefix "point-Postscript"
    let point_TeX = _prefixId.prefix "point-TeX"
    let poise = _prefixId.prefix "poise"
    let portion = _prefixId.prefix "portion"
    let pound_Force = _prefixId.prefix "pound-Force"
    let poundApothecaries = _prefixId.prefix "poundApothecaries"
    let poundAvoirdupois = _prefixId.prefix "poundAvoirdupois"
    let poundSterling = _prefixId.prefix "poundSterling"
    let poundal = _prefixId.prefix "poundal"
    let power_Dimension = _prefixId.prefix "power-Dimension"
    let powerDensity_Dimension = _prefixId.prefix "powerDensity-Dimension"
    let pressure_Dimension = _prefixId.prefix "pressure-Dimension"
    let product = _prefixId.prefix "product"
    let quad = _prefixId.prefix "quad"
    let quart_Imperial = _prefixId.prefix "quart-Imperial"
    let rad = _prefixId.prefix "rad"
    let radian = _prefixId.prefix "radian"
    let radianPerSecond_Time = _prefixId.prefix "radianPerSecond-Time"
    let radianPerSecond_TimeSquared = _prefixId.prefix "radianPerSecond-TimeSquared"
    let radiance_Dimension = _prefixId.prefix "radiance-Dimension"
    let radiometryAndRadiobiology = _prefixId.prefix "radiometryAndRadiobiology"
    let reciprocalAtmosphere_Standard = _prefixId.prefix "reciprocalAtmosphere-Standard"
    let reciprocalCubicCentimetre = _prefixId.prefix "reciprocalCubicCentimetre"
    let reciprocalCubicMetre = _prefixId.prefix "reciprocalCubicMetre"
    let reciprocalCubicParsec = _prefixId.prefix "reciprocalCubicParsec"
    let reciprocalDay = _prefixId.prefix "reciprocalDay"
    let reciprocalDegreeCelsius = _prefixId.prefix "reciprocalDegreeCelsius"
    let reciprocalDegreeCelsiusDay = _prefixId.prefix "reciprocalDegreeCelsiusDay"
    let reciprocalGram = _prefixId.prefix "reciprocalGram"
    let reciprocalHenry = _prefixId.prefix "reciprocalHenry"
    let reciprocalHour = _prefixId.prefix "reciprocalHour"
    let reciprocalKelvin = _prefixId.prefix "reciprocalKelvin"
    let reciprocalMetre = _prefixId.prefix "reciprocalMetre"
    let reciprocalMinute_Time = _prefixId.prefix "reciprocalMinute-Time"

    let reciprocalPartsPerMillionPerYear = _prefixId.prefix "reciprocalPartsPerMillionPerYear"

    let reciprocalPascalSecond_Time = _prefixId.prefix "reciprocalPascalSecond-Time"
    let reciprocalSecond_Time = _prefixId.prefix "reciprocalSecond-Time"
    let reciprocalSquareCentimetre = _prefixId.prefix "reciprocalSquareCentimetre"
    let reciprocalSquareMetre = _prefixId.prefix "reciprocalSquareMetre"

    let reciprocalSquareMetreReciprocalGram = _prefixId.prefix "reciprocalSquareMetreReciprocalGram"

    let reciprocalSquareMetreReciprocalMetre = _prefixId.prefix "reciprocalSquareMetreReciprocalMetre"

    let reciprocalWatt = _prefixId.prefix "reciprocalWatt"
    let reciprocalYear = _prefixId.prefix "reciprocalYear"
    let reluctance_Dimension = _prefixId.prefix "reluctance-Dimension"
    let rem = _prefixId.prefix "rem"
    let revolution = _prefixId.prefix "revolution"
    let rhe = _prefixId.prefix "rhe"
    let rod_US = _prefixId.prefix "rod-US"
    let röntgen = _prefixId.prefix "röntgen"
    let scoop = _prefixId.prefix "scoop"
    let second_Angle = _prefixId.prefix "second-Angle"
    let second_AngleSquared = _prefixId.prefix "second-AngleSquared"
    let second_Anglee = _prefixId.prefix "second-Anglee"
    let second_HourAngle = _prefixId.prefix "second-HourAngle"
    let second_Sidereal = _prefixId.prefix "second-Sidereal"
    let second_Time = _prefixId.prefix "second-Time"
    let second_TimeAmpere = _prefixId.prefix "second-TimeAmpere"
    let second_TimePerDay = _prefixId.prefix "second-TimePerDay"
    let second_TimePerSquareMetre = _prefixId.prefix "second-TimePerSquareMetre"
    let second_TimeSquared = _prefixId.prefix "second-TimeSquared"
    let second_TimeToThePower_2 = _prefixId.prefix "second-TimeToThePower-2"
    let servingSpoon = _prefixId.prefix "servingSpoon"
    let shake = _prefixId.prefix "shake"
    let shannon = _prefixId.prefix "shannon"
    let shipping = _prefixId.prefix "shipping"
    let siemens = _prefixId.prefix "siemens"
    let siemensPerMetre = _prefixId.prefix "siemensPerMetre"
    let sievert = _prefixId.prefix "sievert"
    let slice = _prefixId.prefix "slice"
    let slug = _prefixId.prefix "slug"
    let solarLuminosity = _prefixId.prefix "solarLuminosity"
    let solarMass = _prefixId.prefix "solarMass"
    let solarMassPerCubicParsec = _prefixId.prefix "solarMassPerCubicParsec"

    let solarMassPerGigayearCubicKiloparsec = _prefixId.prefix "solarMassPerGigayearCubicKiloparsec"

    let solarMassPerGigayearCubicParsec = _prefixId.prefix "solarMassPerGigayearCubicParsec"

    let solarRadius = _prefixId.prefix "solarRadius"

    let specificCatalyticActivity_Dimension = _prefixId.prefix "specificCatalyticActivity-Dimension"

    let specificEnergyOrAbsorbedDoseOrDoseEquivalent_Dimension = _prefixId.prefix "specificEnergyOrAbsorbedDoseOrDoseEquivalent-Dimension"

    let specificEntropyOrSpecificHeatCapacity_Dimension = _prefixId.prefix "specificEntropyOrSpecificHeatCapacity-Dimension"

    let specificVolume_Dimension = _prefixId.prefix "specificVolume-Dimension"
    let speed_Dimension = _prefixId.prefix "speed-Dimension"
    let spread = _prefixId.prefix "spread"
    let squareAttometre = _prefixId.prefix "squareAttometre"
    let squareCentimetre = _prefixId.prefix "squareCentimetre"
    let squareDecametre = _prefixId.prefix "squareDecametre"
    let squareDecimetre = _prefixId.prefix "squareDecimetre"
    let squareExametre = _prefixId.prefix "squareExametre"
    let squareFemtometre = _prefixId.prefix "squareFemtometre"
    let squareGigametre = _prefixId.prefix "squareGigametre"
    let squareHectometre = _prefixId.prefix "squareHectometre"
    let squareKilometre = _prefixId.prefix "squareKilometre"
    let squareMegametre = _prefixId.prefix "squareMegametre"
    let squareMetre = _prefixId.prefix "squareMetre"
    let squareMetreDay = _prefixId.prefix "squareMetreDay"
    let squareMetreHertz = _prefixId.prefix "squareMetreHertz"
    let squareMetreKelvin = _prefixId.prefix "squareMetreKelvin"
    let squareMetreKelvinPerWatt = _prefixId.prefix "squareMetreKelvinPerWatt"
    let squareMetreNanometre = _prefixId.prefix "squareMetreNanometre"
    let squareMetrePerGram = _prefixId.prefix "squareMetrePerGram"
    let squareMetrePerSecond_Time = _prefixId.prefix "squareMetrePerSecond-Time"
    let squareMetrePerSquareMetre = _prefixId.prefix "squareMetrePerSquareMetre"
    let squareMetrePerSquareMetreDay = _prefixId.prefix "squareMetrePerSquareMetreDay"
    let squareMetreSecond_Time = _prefixId.prefix "squareMetreSecond-Time"
    let squareMetreSteradian = _prefixId.prefix "squareMetreSteradian"
    let squareMicrometre = _prefixId.prefix "squareMicrometre"
    let squareMillimetre = _prefixId.prefix "squareMillimetre"
    let squareNanometre = _prefixId.prefix "squareNanometre"
    let squarePetametre = _prefixId.prefix "squarePetametre"
    let squarePicometre = _prefixId.prefix "squarePicometre"
    let squareTerametre = _prefixId.prefix "squareTerametre"
    let squareYoctometre = _prefixId.prefix "squareYoctometre"
    let squareYottametre = _prefixId.prefix "squareYottametre"
    let squareZeptometre = _prefixId.prefix "squareZeptometre"
    let squareZettametre = _prefixId.prefix "squareZettametre"
    let standardDeviation = _prefixId.prefix "standardDeviation"
    let statampere = _prefixId.prefix "statampere"
    let statcoulomb = _prefixId.prefix "statcoulomb"
    let statfarad = _prefixId.prefix "statfarad"
    let stathenry = _prefixId.prefix "stathenry"
    let statmho = _prefixId.prefix "statmho"
    let statohm = _prefixId.prefix "statohm"
    let stattesla = _prefixId.prefix "stattesla"
    let statvolt = _prefixId.prefix "statvolt"
    let statweber = _prefixId.prefix "statweber"
    let steradian = _prefixId.prefix "steradian"
    let steradianSquareMetre = _prefixId.prefix "steradianSquareMetre"
    let steradianSquareMetreHertz = _prefixId.prefix "steradianSquareMetreHertz"
    let stere = _prefixId.prefix "stere"
    let stilb = _prefixId.prefix "stilb"
    let stokes = _prefixId.prefix "stokes"
    let sum = _prefixId.prefix "sum"
    let surfaceTension_Dimension = _prefixId.prefix "surfaceTension-Dimension"
    /// <summary>
    ///   <para>oum:alternativeLabel : has symboloum:alternativeLabel : 記号を持つ</para>
    ///   <para>rdfs:label : symbolrdfs:label : 記号</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/symbol">oum:symbol</a>
    /// </summary>
    let symbol = _prefixId.prefix "symbol"

    let systemThatContainsAsManyElementaryEntitiesAsThereAreAtomsIn0'_period_'012KilogramOfCarbon12 =
        _prefixId.prefix "systemThatContainsAsManyElementaryEntitiesAsThereAreAtomsIn0.012KilogramOfCarbon12"

    let tablespoon_US = _prefixId.prefix "tablespoon-US"
    let teaspoon_US = _prefixId.prefix "teaspoon-US"
    let tebi = _prefixId.prefix "tebi"
    let tebibit = _prefixId.prefix "tebibit"
    let tebibyte = _prefixId.prefix "tebibyte"
    let tera = _prefixId.prefix "tera"
    let teraampere = _prefixId.prefix "teraampere"
    let terabecquerel = _prefixId.prefix "terabecquerel"
    let terabit = _prefixId.prefix "terabit"
    let terabyte = _prefixId.prefix "terabyte"
    let teracandela = _prefixId.prefix "teracandela"
    let teracoulomb = _prefixId.prefix "teracoulomb"
    let terafarad = _prefixId.prefix "terafarad"
    let teragram = _prefixId.prefix "teragram"
    let teragramPerLitre = _prefixId.prefix "teragramPerLitre"
    let teragray = _prefixId.prefix "teragray"
    let terahenry = _prefixId.prefix "terahenry"
    let terahertz = _prefixId.prefix "terahertz"
    let terajoule = _prefixId.prefix "terajoule"
    let terakatal = _prefixId.prefix "terakatal"
    let terakelvin = _prefixId.prefix "terakelvin"
    let teralitre = _prefixId.prefix "teralitre"
    let teralumen = _prefixId.prefix "teralumen"
    let teralux = _prefixId.prefix "teralux"
    let terametre = _prefixId.prefix "terametre"
    let terametrePerSecond_Time = _prefixId.prefix "terametrePerSecond-Time"

    let terametrePerSecond_TimeSquared = _prefixId.prefix "terametrePerSecond-TimeSquared"

    let teramolair = _prefixId.prefix "teramolair"
    let teramole = _prefixId.prefix "teramole"
    let teramolePerLitre = _prefixId.prefix "teramolePerLitre"
    let teramolePerMetre = _prefixId.prefix "teramolePerMetre"
    let teranewton = _prefixId.prefix "teranewton"
    let teraohm = _prefixId.prefix "teraohm"
    let terapascal = _prefixId.prefix "terapascal"
    let terasecond_Time = _prefixId.prefix "terasecond-Time"
    let terasecond_TimeSquared = _prefixId.prefix "terasecond-TimeSquared"
    let terasiemens = _prefixId.prefix "terasiemens"
    let terasievert = _prefixId.prefix "terasievert"
    let teratesla = _prefixId.prefix "teratesla"
    let teravolt = _prefixId.prefix "teravolt"
    let terawatt = _prefixId.prefix "terawatt"
    let terawattHour = _prefixId.prefix "terawattHour"
    let teraweber = _prefixId.prefix "teraweber"
    let tesla = _prefixId.prefix "tesla"
    let therm_EC = _prefixId.prefix "therm-EC"
    let therm_US = _prefixId.prefix "therm-US"
    let thermalConductivity_Dimension = _prefixId.prefix "thermalConductivity-Dimension"
    let thermalInsulance_Dimension = _prefixId.prefix "thermalInsulance-Dimension"
    let thermalResistance_Dimension = _prefixId.prefix "thermalResistance-Dimension"

    let thermodynamicTemperature_Dimension = _prefixId.prefix "thermodynamicTemperature-Dimension"

    let thermodynamicTemperatureOfTheTriplePointOfWater = _prefixId.prefix "thermodynamicTemperatureOfTheTriplePointOfWater"

    let thermodynamics = _prefixId.prefix "thermodynamics"
    let time_Dimension = _prefixId.prefix "time-Dimension"
    let ton_Force_Short = _prefixId.prefix "ton-Force-Short"
    let ton_Long = _prefixId.prefix "ton-Long"
    let ton_Register = _prefixId.prefix "ton-Register"
    let ton_Short = _prefixId.prefix "ton-Short"
    let ton_ShortAssay = _prefixId.prefix "ton-ShortAssay"
    let tonOfRefrigeration = _prefixId.prefix "tonOfRefrigeration"
    let tonOfTNT = _prefixId.prefix "tonOfTNT"
    let tonne = _prefixId.prefix "tonne"
    let tonnePerCubicmetre = _prefixId.prefix "tonnePerCubicmetre"
    let tonnePerHectare = _prefixId.prefix "tonnePerHectare"
    let torr = _prefixId.prefix "torr"
    let triplePointOfWater = _prefixId.prefix "triplePointOfWater"
    let typography = _prefixId.prefix "typography"
    /// <summary>
    ///   <para>oum:symbol : u^^xsd:string</para>
    ///   <para>rdfs:comment : u Magnitude in the Strömgren photometric system with a peak wavelength at 350 nm and a peak-half-width of 30 nm.</para>
    ///   <para>oum:alternativeSymbol : m_u^^xsd:string</para>
    ///   <para>rdfs:label : u magnitude</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/uMagnitude">oum:uMagnitude</a>
    /// </summary>
    let uMagnitude = _prefixId.prefix "uMagnitude"
    let unifiedAtomicMassUnit = _prefixId.prefix "unifiedAtomicMassUnit"
    let unitPole = _prefixId.prefix "unitPole"
    /// <summary>
    ///   <para>oum:alternativeLabel : has unofficial abbreviationoum:alternativeLabel : 非公式な略記がある</para>
    ///   <para>rdfs:label : unofficial abbreviationrdfs:label : 非公式な略記</para>
    ///   <para>rdfs:comment : Used to specify abbreviations that are used in e.g. every day speech but are not defined in any standard.^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/unofficialAbbreviation">oum:unofficialAbbreviation</a>
    /// </summary>
    let unofficialAbbreviation = _prefixId.prefix "unofficialAbbreviation"
    /// <summary>
    ///   <para>oum:alternativeLabel : has unofficial labeloum:alternativeLabel : 非公式な記号を持つ</para>
    ///   <para>rdfs:label : unofficial labelrdfs:label : 非公式な記号</para>
    ///   <para>rdfs:comment : Used to specify labels that are used in e.g. every day speech but are not defined in any standard.^^xsd:string</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/unofficialLabel">oum:unofficialLabel</a>
    /// </summary>
    let unofficialLabel = _prefixId.prefix "unofficialLabel"
    /// <summary>
    ///   <para>rdfs:label : uses quantity</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/usesQuantity">oum:usesQuantity</a>
    /// </summary>
    let usesQuantity = _prefixId.prefix "usesQuantity"
    /// <summary>
    ///   <para>rdfs:label : uses unit</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/usesUnit">oum:usesUnit</a>
    /// </summary>
    let usesUnit = _prefixId.prefix "usesUnit"
    /// <summary>
    ///   <para>oum:symbol : v^^xsd:string</para>
    ///   <para>oum:alternativeSymbol : m_v^^xsd:string</para>
    ///   <para>rdfs:label : v magnitude</para>
    ///   <para>rdfs:comment : v Magnitude in the Strömgren photometric system with a peak wavelength at 411 nm and a peak-half-width of 19 nm.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/vMagnitude">oum:vMagnitude</a>
    /// </summary>
    let vMagnitude = _prefixId.prefix "vMagnitude"
    let volt = _prefixId.prefix "volt"
    let voltPerAmpere = _prefixId.prefix "voltPerAmpere"
    let voltPerMetre = _prefixId.prefix "voltPerMetre"
    let voltPerWatt = _prefixId.prefix "voltPerWatt"
    let voltSecond_Time = _prefixId.prefix "voltSecond-Time"
    let volume_Dimension = _prefixId.prefix "volume-Dimension"
    let volumetricFlowRate_Dimension = _prefixId.prefix "volumetricFlowRate-Dimension"

    let volumetricHeatCapacity_Dimension = _prefixId.prefix "volumetricHeatCapacity-Dimension"

    let watt = _prefixId.prefix "watt"
    let wattHour = _prefixId.prefix "wattHour"
    let wattPerAmpere = _prefixId.prefix "wattPerAmpere"
    let wattPerCubicmetre = _prefixId.prefix "wattPerCubicmetre"
    let wattPerHertz = _prefixId.prefix "wattPerHertz"
    let wattPerMetreKelvin = _prefixId.prefix "wattPerMetreKelvin"
    let wattPerNanometre = _prefixId.prefix "wattPerNanometre"
    let wattPerSecond_AngleSquared = _prefixId.prefix "wattPerSecond-AngleSquared"
    let wattPerSquareMetre = _prefixId.prefix "wattPerSquareMetre"
    let wattPerSquareMetreHertz = _prefixId.prefix "wattPerSquareMetreHertz"
    let wattPerSquareMetreKelvin = _prefixId.prefix "wattPerSquareMetreKelvin"
    let wattPerSquareMetreNanometre = _prefixId.prefix "wattPerSquareMetreNanometre"
    let wattPerSquareMetreSteradian = _prefixId.prefix "wattPerSquareMetreSteradian"
    let wattPerSteradian = _prefixId.prefix "wattPerSteradian"
    let wattPerSteradianSquareMetre = _prefixId.prefix "wattPerSteradianSquareMetre"

    let wattPerSteradianSquareMetreHertz = _prefixId.prefix "wattPerSteradianSquareMetreHertz"

    let wattSquareMetre = _prefixId.prefix "wattSquareMetre"
    let wavenumber_Dimension = _prefixId.prefix "wavenumber-Dimension"
    let weber = _prefixId.prefix "weber"
    let weberPerAmpere = _prefixId.prefix "weberPerAmpere"
    let weberPerSquareMetre = _prefixId.prefix "weberPerSquareMetre"
    let wedge = _prefixId.prefix "wedge"
    let week = _prefixId.prefix "week"
    let wineGlass = _prefixId.prefix "wineGlass"
    /// <summary>
    ///   <para>rdfs:label : x range</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/xRange">oum:xRange</a>
    /// </summary>
    let xRange = _prefixId.prefix "xRange"
    /// <summary>
    ///   <para>rdfs:label : xy 2D start-end distance</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/xy2DStartEndDistance">oum:xy2DStartEndDistance</a>
    /// </summary>
    let xy2DStartEndDistance = _prefixId.prefix "xy2DStartEndDistance"
    /// <summary>
    ///   <para>rdfs:label : xy distance travelled</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/xyDistanceTravelled">oum:xyDistanceTravelled</a>
    /// </summary>
    let xyDistanceTravelled = _prefixId.prefix "xyDistanceTravelled"
    /// <summary>
    ///   <para>oum:alternativeSymbol : m_y^^xsd:string</para>
    ///   <para>rdfs:label : y magnitude</para>
    ///   <para>oum:symbol : y^^xsd:string</para>
    ///   <para>rdfs:comment : y Magnitude in the Strömgren photometric system with a peak wavelength at 547 nm and a peak-half-width of 23 nm.</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/yMagnitude">oum:yMagnitude</a>
    /// </summary>
    let yMagnitude = _prefixId.prefix "yMagnitude"
    /// <summary>
    ///   <para>rdfs:label : y range</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/yRange">oum:yRange</a>
    /// </summary>
    let yRange = _prefixId.prefix "yRange"
    let yard_International = _prefixId.prefix "yard-International"
    let year = _prefixId.prefix "year"
    let year_Sidereal = _prefixId.prefix "year-Sidereal"
    let year_Tropical = _prefixId.prefix "year-Tropical"
    let yobi = _prefixId.prefix "yobi"
    let yobibit = _prefixId.prefix "yobibit"
    let yobibyte = _prefixId.prefix "yobibyte"
    let yocto = _prefixId.prefix "yocto"
    let yoctoampere = _prefixId.prefix "yoctoampere"
    let yoctobecquerel = _prefixId.prefix "yoctobecquerel"
    let yoctocandela = _prefixId.prefix "yoctocandela"
    let yoctocoulomb = _prefixId.prefix "yoctocoulomb"
    let yoctodegreeCelsius = _prefixId.prefix "yoctodegreeCelsius"
    let yoctofarad = _prefixId.prefix "yoctofarad"
    let yoctogram = _prefixId.prefix "yoctogram"
    let yoctogramPerLitre = _prefixId.prefix "yoctogramPerLitre"
    let yoctogray = _prefixId.prefix "yoctogray"
    let yoctohenry = _prefixId.prefix "yoctohenry"
    let yoctohertz = _prefixId.prefix "yoctohertz"
    let yoctojoule = _prefixId.prefix "yoctojoule"
    let yoctokatal = _prefixId.prefix "yoctokatal"
    let yoctokelvin = _prefixId.prefix "yoctokelvin"
    let yoctolitre = _prefixId.prefix "yoctolitre"
    let yoctolumen = _prefixId.prefix "yoctolumen"
    let yoctolux = _prefixId.prefix "yoctolux"
    let yoctometre = _prefixId.prefix "yoctometre"
    let yoctometrePerSecond_Time = _prefixId.prefix "yoctometrePerSecond-Time"

    let yoctometrePerSecond_TimeSquared = _prefixId.prefix "yoctometrePerSecond-TimeSquared"

    let yoctomolair = _prefixId.prefix "yoctomolair"
    let yoctomole = _prefixId.prefix "yoctomole"
    let yoctomolePerLitre = _prefixId.prefix "yoctomolePerLitre"
    let yoctomolePerMetre = _prefixId.prefix "yoctomolePerMetre"
    let yoctonewton = _prefixId.prefix "yoctonewton"
    let yoctoohm = _prefixId.prefix "yoctoohm"
    let yoctopascal = _prefixId.prefix "yoctopascal"
    let yoctoradian = _prefixId.prefix "yoctoradian"
    let yoctosecond_Time = _prefixId.prefix "yoctosecond-Time"
    let yoctosecond_TimeSquared = _prefixId.prefix "yoctosecond-TimeSquared"
    let yoctosiemens = _prefixId.prefix "yoctosiemens"
    let yoctosievert = _prefixId.prefix "yoctosievert"
    let yoctosteradian = _prefixId.prefix "yoctosteradian"
    let yoctotesla = _prefixId.prefix "yoctotesla"
    let yoctovolt = _prefixId.prefix "yoctovolt"
    let yoctowatt = _prefixId.prefix "yoctowatt"
    let yoctoweber = _prefixId.prefix "yoctoweber"
    let yotta = _prefixId.prefix "yotta"
    let yottaampere = _prefixId.prefix "yottaampere"
    let yottabecquerel = _prefixId.prefix "yottabecquerel"
    let yottabit = _prefixId.prefix "yottabit"
    let yottabyte = _prefixId.prefix "yottabyte"
    let yottacandela = _prefixId.prefix "yottacandela"
    let yottacoulomb = _prefixId.prefix "yottacoulomb"
    let yottafarad = _prefixId.prefix "yottafarad"
    let yottagram = _prefixId.prefix "yottagram"
    let yottagramPerLitre = _prefixId.prefix "yottagramPerLitre"
    let yottagray = _prefixId.prefix "yottagray"
    let yottahenry = _prefixId.prefix "yottahenry"
    let yottahertz = _prefixId.prefix "yottahertz"
    let yottajoule = _prefixId.prefix "yottajoule"
    let yottakatal = _prefixId.prefix "yottakatal"
    let yottakelvin = _prefixId.prefix "yottakelvin"
    let yottalitre = _prefixId.prefix "yottalitre"
    let yottalumen = _prefixId.prefix "yottalumen"
    let yottalux = _prefixId.prefix "yottalux"
    let yottametre = _prefixId.prefix "yottametre"
    let yottametrePerSecond_Time = _prefixId.prefix "yottametrePerSecond-Time"

    let yottametrePerSecond_TimeSquared = _prefixId.prefix "yottametrePerSecond-TimeSquared"

    let yottamolair = _prefixId.prefix "yottamolair"
    let yottamole = _prefixId.prefix "yottamole"
    let yottamolePerLitre = _prefixId.prefix "yottamolePerLitre"
    let yottamolePerMetre = _prefixId.prefix "yottamolePerMetre"
    let yottanewton = _prefixId.prefix "yottanewton"
    let yottaohm = _prefixId.prefix "yottaohm"
    let yottapascal = _prefixId.prefix "yottapascal"
    let yottasecond_Time = _prefixId.prefix "yottasecond-Time"
    let yottasecond_TimeSquared = _prefixId.prefix "yottasecond-TimeSquared"
    let yottasiemens = _prefixId.prefix "yottasiemens"
    let yottasievert = _prefixId.prefix "yottasievert"
    let yottatesla = _prefixId.prefix "yottatesla"
    let yottavolt = _prefixId.prefix "yottavolt"
    let yottawatt = _prefixId.prefix "yottawatt"
    let yottaweber = _prefixId.prefix "yottaweber"
    /// <summary>
    ///   <para>rdfs:label : z range</para>
    ///   <a href="http://www.ontology-of-units-of-measure.org/resource/om-2/zRange">oum:zRange</a>
    /// </summary>
    let zRange = _prefixId.prefix "zRange"
    let zebi = _prefixId.prefix "zebi"
    let zebibit = _prefixId.prefix "zebibit"
    let zebibyte = _prefixId.prefix "zebibyte"
    let zepto = _prefixId.prefix "zepto"
    let zeptoampere = _prefixId.prefix "zeptoampere"
    let zeptobecquerel = _prefixId.prefix "zeptobecquerel"
    let zeptocandela = _prefixId.prefix "zeptocandela"
    let zeptocoulomb = _prefixId.prefix "zeptocoulomb"
    let zeptodegreeCelsius = _prefixId.prefix "zeptodegreeCelsius"
    let zeptofarad = _prefixId.prefix "zeptofarad"
    let zeptogram = _prefixId.prefix "zeptogram"
    let zeptogramPerLitre = _prefixId.prefix "zeptogramPerLitre"
    let zeptogray = _prefixId.prefix "zeptogray"
    let zeptohenry = _prefixId.prefix "zeptohenry"
    let zeptohertz = _prefixId.prefix "zeptohertz"
    let zeptojoule = _prefixId.prefix "zeptojoule"
    let zeptokatal = _prefixId.prefix "zeptokatal"
    let zeptokelvin = _prefixId.prefix "zeptokelvin"
    let zeptolitre = _prefixId.prefix "zeptolitre"
    let zeptolumen = _prefixId.prefix "zeptolumen"
    let zeptolux = _prefixId.prefix "zeptolux"
    let zeptometre = _prefixId.prefix "zeptometre"
    let zeptometrePerSecond_Time = _prefixId.prefix "zeptometrePerSecond-Time"

    let zeptometrePerSecond_TimeSquared = _prefixId.prefix "zeptometrePerSecond-TimeSquared"

    let zeptomolair = _prefixId.prefix "zeptomolair"
    let zeptomole = _prefixId.prefix "zeptomole"
    let zeptomolePerLitre = _prefixId.prefix "zeptomolePerLitre"
    let zeptomolePerMetre = _prefixId.prefix "zeptomolePerMetre"
    let zeptonewton = _prefixId.prefix "zeptonewton"
    let zeptoohm = _prefixId.prefix "zeptoohm"
    let zeptopascal = _prefixId.prefix "zeptopascal"
    let zeptoradian = _prefixId.prefix "zeptoradian"
    let zeptosecond_Time = _prefixId.prefix "zeptosecond-Time"
    let zeptosecond_TimeSquared = _prefixId.prefix "zeptosecond-TimeSquared"
    let zeptosiemens = _prefixId.prefix "zeptosiemens"
    let zeptosievert = _prefixId.prefix "zeptosievert"
    let zeptosteradian = _prefixId.prefix "zeptosteradian"
    let zeptotesla = _prefixId.prefix "zeptotesla"
    let zeptovolt = _prefixId.prefix "zeptovolt"
    let zeptowatt = _prefixId.prefix "zeptowatt"
    let zeptoweber = _prefixId.prefix "zeptoweber"
    let zetta = _prefixId.prefix "zetta"
    let zettaampere = _prefixId.prefix "zettaampere"
    let zettabecquerel = _prefixId.prefix "zettabecquerel"
    let zettabit = _prefixId.prefix "zettabit"
    let zettabyte = _prefixId.prefix "zettabyte"
    let zettacandela = _prefixId.prefix "zettacandela"
    let zettacoulomb = _prefixId.prefix "zettacoulomb"
    let zettafarad = _prefixId.prefix "zettafarad"
    let zettagram = _prefixId.prefix "zettagram"
    let zettagramPerLitre = _prefixId.prefix "zettagramPerLitre"
    let zettagray = _prefixId.prefix "zettagray"
    let zettahenry = _prefixId.prefix "zettahenry"
    let zettahertz = _prefixId.prefix "zettahertz"
    let zettajoule = _prefixId.prefix "zettajoule"
    let zettakatal = _prefixId.prefix "zettakatal"
    let zettakelvin = _prefixId.prefix "zettakelvin"
    let zettalitre = _prefixId.prefix "zettalitre"
    let zettalumen = _prefixId.prefix "zettalumen"
    let zettalux = _prefixId.prefix "zettalux"
    let zettametre = _prefixId.prefix "zettametre"
    let zettametrePerSecond_Time = _prefixId.prefix "zettametrePerSecond-Time"

    let zettametrePerSecond_TimeSquared = _prefixId.prefix "zettametrePerSecond-TimeSquared"

    let zettamolair = _prefixId.prefix "zettamolair"
    let zettamole = _prefixId.prefix "zettamole"
    let zettamolePerLitre = _prefixId.prefix "zettamolePerLitre"
    let zettamolePerMetre = _prefixId.prefix "zettamolePerMetre"
    let zettanewton = _prefixId.prefix "zettanewton"
    let zettaohm = _prefixId.prefix "zettaohm"
    let zettapascal = _prefixId.prefix "zettapascal"
    let zettasecond_Time = _prefixId.prefix "zettasecond-Time"
    let zettasecond_TimeSquared = _prefixId.prefix "zettasecond-TimeSquared"
    let zettasiemens = _prefixId.prefix "zettasiemens"
    let zettasievert = _prefixId.prefix "zettasievert"
    let zettatesla = _prefixId.prefix "zettatesla"
    let zettavolt = _prefixId.prefix "zettavolt"
    let zettawatt = _prefixId.prefix "zettawatt"
    let zettaweber = _prefixId.prefix "zettaweber"
