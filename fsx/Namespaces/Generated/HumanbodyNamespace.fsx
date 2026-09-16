#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module humanbody =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/humanBody#" "humanbody"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : acquired human body structure</para>
    ///   <para>skos:definition : Any acquired human body structure, e.g. a scar, an amputation stump.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AcquiredStructure">humanbody:AcquiredStructure</a>
    /// </summary>
    let AcquiredStructure = _prefixId.prefix "AcquiredStructure"
    /// <summary>
    ///   <para>rdfs:label : adult body mass index</para>
    ///   <para>skos:definition : Physical quantity expressing total body fat based on body length and body weight applying to adult men and women.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndex">humanbody:AdultBodyMassIndex</a>
    /// </summary>
    let AdultBodyMassIndex = _prefixId.prefix "AdultBodyMassIndex"
    /// <summary>
    ///   <para>rdfs:label : adult body mass index measurement</para>
    ///   <para>skos:definition : Estimation of total body fat based on body length and body weight applying to adult men and women.</para>
    ///   <para>rdfs:comment : May overestimate body fat in athletes and others who have a muscular build; may underestimate body fat in older persons and others who have lost muscle mass.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndexMeasurement">humanbody:AdultBodyMassIndexMeasurement</a>
    /// </summary>
    let AdultBodyMassIndexMeasurement = _prefixId.prefix "AdultBodyMassIndexMeasurement"
    /// <summary>
    ///   <para>rdfs:label : human anatomical structure</para>
    ///   <para>skos:definition : Human structure of any kind as result of species evolution.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AnatomicalStructure">humanbody:AnatomicalStructure</a>
    /// </summary>
    let AnatomicalStructure = _prefixId.prefix "AnatomicalStructure"
    /// <summary>
    ///   <para>rdfs:label : human body birth weight</para>
    ///   <para>skos:definition : Mass of a human body at birth.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeight">humanbody:BirthWeight</a>
    /// </summary>
    let BirthWeight = _prefixId.prefix "BirthWeight"
    /// <summary>
    ///   <para>rdfs:label : human body birth weight measurement</para>
    ///   <para>skos:definition : Measurement of a weight of a human body at birth.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeightMeasurement">humanbody:BirthWeightMeasurement</a>
    /// </summary>
    let BirthWeightMeasurement = _prefixId.prefix "BirthWeightMeasurement"
    /// <summary>
    ///   <para>rdfs:label : human body</para>
    ///   <para>skos:definition : The whole body of a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Body">humanbody:Body</a>
    /// </summary>
    let Body = _prefixId.prefix "Body"
    /// <summary>
    ///   <para>rdfs:label : human dead body</para>
    ///   <para>skos:definition : Remainings of a human after life.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#DeadBody">humanbody:DeadBody</a>
    /// </summary>
    let DeadBody = _prefixId.prefix "DeadBody"
    /// <summary>
    ///   <para>rdfs:label : human death</para>
    ///   <para>skos:definition : Finding of a human body that stopped being a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Death">humanbody:Death</a>
    /// </summary>
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>rdfs:label : human body length</para>
    ///   <para>skos:definition : Length as physical property of a human body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Length">humanbody:Length</a>
    /// </summary>
    let Length = _prefixId.prefix "Length"
    /// <summary>
    ///   <para>rdfs:label : human body length measurement</para>
    ///   <para>skos:definition : Measurement of the length of a human body from the vertex to the sole of the foot in upright position.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasurement">humanbody:LengthMeasurement</a>
    /// </summary>
    let LengthMeasurement = _prefixId.prefix "LengthMeasurement"
    /// <summary>
    ///   <para>rdfs:label : measuring a human body length</para>
    ///   <para>skos:definition : Measuring of the length of a human body from the vertex to the sole of the foot in upright position.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasuring">humanbody:LengthMeasuring</a>
    /// </summary>
    let LengthMeasuring = _prefixId.prefix "LengthMeasuring"
    let MorbidlyObese = _prefixId.prefix "MorbidlyObese"
    /// <summary>
    ///   <para>rdfs:label : newborn body</para>
    ///   <para>skos:definition : The whole body of a newborn human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Newborn">humanbody:Newborn</a>
    /// </summary>
    let Newborn = _prefixId.prefix "Newborn"
    let NormalWeight = _prefixId.prefix "NormalWeight"
    let Obese = _prefixId.prefix "Obese"
    let Overweight = _prefixId.prefix "Overweight"
    let SeverelyUnderweight = _prefixId.prefix "SeverelyUnderweight"
    /// <summary>
    ///   <para>rdfs:label : human body structure</para>
    ///   <para>skos:definition : Any structural part of the human body.</para>
    ///   <para>skos:note : This can be a site as object of a disease or a procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Structure">humanbody:Structure</a>
    /// </summary>
    let Structure = _prefixId.prefix "Structure"
    /// <summary>
    ///   <para>rdfs:label : human body substance</para>
    ///   <para>skos:definition : Any sui generis substance contained by a human body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Substance">humanbody:Substance</a>
    /// </summary>
    let Substance = _prefixId.prefix "Substance"
    let SuperObese = _prefixId.prefix "SuperObese"
    /// <summary>
    ///   <para>rdfs:label : human body surface</para>
    ///   <para>skos:definition : Outer surface of a human body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Surface">humanbody:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : human body surface area</para>
    ///   <para>skos:definition : Area as physical property of a human body surface.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceArea">humanbody:SurfaceArea</a>
    /// </summary>
    let SurfaceArea = _prefixId.prefix "SurfaceArea"
    /// <summary>
    ///   <para>rdfs:label : human body surface area measurement</para>
    ///   <para>skos:definition : Measurement of an area of a human body surface.</para>
    ///   <para>rdfs:comment : Approximative calculation, e.g. in an N3 rule with formula of Mosteller, see http://eulersharp.sourceforge.net/2003/03swap/bodySurfaceArea_rules.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceAreaMeasurement">humanbody:SurfaceAreaMeasurement</a>
    /// </summary>
    let SurfaceAreaMeasurement = _prefixId.prefix "SurfaceAreaMeasurement"
    let Underweight = _prefixId.prefix "Underweight"
    /// <summary>
    ///   <para>rdfs:label : weighing a human body</para>
    ///   <para>skos:definition : Measuring a weight of a human body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weighing">humanbody:Weighing</a>
    /// </summary>
    let Weighing = _prefixId.prefix "Weighing"
    /// <summary>
    ///   <para>rdfs:label : human body weighing device</para>
    ///   <para>skos:definition : Device to measure the human body weight.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeighingDevice">humanbody:WeighingDevice</a>
    /// </summary>
    let WeighingDevice = _prefixId.prefix "WeighingDevice"
    /// <summary>
    ///   <para>rdfs:label : human body weight</para>
    ///   <para>skos:definition : Mass as physical property of a human body, since abstraction made of the gravitational acceleration.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weight">humanbody:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>rdfs:label : human body weight measurement</para>
    ///   <para>skos:definition : Measurement of a weight of a human body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightMeasurement">humanbody:WeightMeasurement</a>
    /// </summary>
    let WeightMeasurement = _prefixId.prefix "WeightMeasurement"
    /// <summary>
    ///   <para>rdfs:label : weight status</para>
    ///   <para>skos:definition : Status of a human's weight</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightStatus">humanbody:WeightStatus</a>
    /// </summary>
    let WeightStatus = _prefixId.prefix "WeightStatus"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's body weight at birth.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBirthWeight">humanbody:hasBirthWeight</a>
    /// </summary>
    let hasBirthWeight = _prefixId.prefix "hasBirthWeight"
    /// <summary>
    ///   <para>skos:definition : Specifying a body mass index of a human adult's body'.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBodyMassIndex">humanbody:hasBodyMassIndex</a>
    /// </summary>
    let hasBodyMassIndex = _prefixId.prefix "hasBodyMassIndex"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's body length.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasLength">humanbody:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's body surface area.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasSurfaceArea">humanbody:hasSurfaceArea</a>
    /// </summary>
    let hasSurfaceArea = _prefixId.prefix "hasSurfaceArea"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's body weight.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeight">humanbody:hasWeight</a>
    /// </summary>
    let hasWeight = _prefixId.prefix "hasWeight"
    /// <summary>
    ///   <para>skos:definition : Specifying a human body's weight status.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeightStatus">humanbody:hasWeightStatus</a>
    /// </summary>
    let hasWeightStatus = _prefixId.prefix "hasWeightStatus"
    /// <summary>
    ///   <para>skos:definition : Specifying a human body having a weight.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#weightOf">humanbody:weightOf</a>
    /// </summary>
    let weightOf = _prefixId.prefix "weightOf"
