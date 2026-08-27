namespace http.eulersharp.sourceforge.net._2003._03swap.humanBody.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module humanbody =
    let _namespace_iri = Namespace_Iri humanbody |> NamespaceIRI
    /// <summary>
    ///   <para>humanbody:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#">http://eulersharp.sourceforge.net/2003/03swap/humanBody#</seealso>
    let _prefix_iri = Prefixed_Name(humanbody, "") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:AcquiredStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"acquired human body structure"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AcquiredStructure">http://eulersharp.sourceforge.net/2003/03swap/humanBody#AcquiredStructure</seealso>
    let AcquiredStructure =
        Prefixed_Name(humanbody, "AcquiredStructure") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:AdultBodyMassIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"adult body mass index"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndex">http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndex</seealso>
    let AdultBodyMassIndex =
        Prefixed_Name(humanbody, "AdultBodyMassIndex") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:AdultBodyMassIndexMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"May overestimate body fat in athletes and others who have a muscular build; may underestimate body fat in older persons and others who have lost muscle mass."</para>
    /// labels<para>"adult body mass index measurement"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndexMeasurement">http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndexMeasurement</seealso>
    let AdultBodyMassIndexMeasurement =
        Prefixed_Name(humanbody, "AdultBodyMassIndexMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:AnatomicalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"human anatomical structure"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AnatomicalStructure">http://eulersharp.sourceforge.net/2003/03swap/humanBody#AnatomicalStructure</seealso>
    let AnatomicalStructure =
        Prefixed_Name(humanbody, "AnatomicalStructure") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:BirthWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body birth weight"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeight</seealso>
    let BirthWeight = Prefixed_Name(humanbody, "BirthWeight") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:BirthWeightMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body birth weight measurement"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeightMeasurement">http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeightMeasurement</seealso>
    let BirthWeightMeasurement =
        Prefixed_Name(humanbody, "BirthWeightMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Body">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Body</seealso>
    let Body = Prefixed_Name(humanbody, "Body") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:DeadBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human dead body"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#DeadBody">http://eulersharp.sourceforge.net/2003/03swap/humanBody#DeadBody</seealso>
    let DeadBody = Prefixed_Name(humanbody, "DeadBody") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human death"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Death">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Death</seealso>
    let Death = Prefixed_Name(humanbody, "Death") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body length"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Length">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Length</seealso>
    let Length = Prefixed_Name(humanbody, "Length") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:LengthMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"human body length measurement"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasurement">http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasurement</seealso>
    let LengthMeasurement =
        Prefixed_Name(humanbody, "LengthMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:LengthMeasuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"measuring a human body length"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasuring">http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasuring</seealso>
    let LengthMeasuring = Prefixed_Name(humanbody, "LengthMeasuring") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:MorbidlyObese</para>
    /// </summary>
    /// <remarks>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>"Body mass index ranging 35-44.9 kg/m2."</para>
    /// labels<para>"morbidly obese"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#MorbidlyObese">http://eulersharp.sourceforge.net/2003/03swap/humanBody#MorbidlyObese</seealso>
    let MorbidlyObese = Prefixed_Name(humanbody, "MorbidlyObese") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Newborn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"newborn body"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Newborn">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Newborn</seealso>
    let Newborn = Prefixed_Name(humanbody, "Newborn") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:NormalWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>"Body mass index ranging 18.5-24.9 kg/m2."</para>
    /// labels<para>"normal weight"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#NormalWeight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#NormalWeight</seealso>
    let NormalWeight = Prefixed_Name(humanbody, "NormalWeight") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Obese</para>
    /// </summary>
    /// <remarks>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Body mass index ranging 30-34.9 kg/m2."</para>
    /// labels<para>"obese"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Obese">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Obese</seealso>
    let Obese = Prefixed_Name(humanbody, "Obese") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Overweight</para>
    /// </summary>
    /// <remarks>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>"Body mass index ranging 25-29.9 kg/m2."</para>
    /// labels<para>"overweight"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Overweight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Overweight</seealso>
    let Overweight = Prefixed_Name(humanbody, "Overweight") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:SeverelyUnderweight</para>
    /// </summary>
    /// <remarks>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>"Body mass index lower than 16 kg/m2."</para>
    /// labels<para>"severely underweight"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SeverelyUnderweight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#SeverelyUnderweight</seealso>
    let SeverelyUnderweight =
        Prefixed_Name(humanbody, "SeverelyUnderweight") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"human body structure"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Structure">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Structure</seealso>
    let Structure = Prefixed_Name(humanbody, "Structure") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Substance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body substance"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Substance">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Substance</seealso>
    let Substance = Prefixed_Name(humanbody, "Substance") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:SuperObese</para>
    /// </summary>
    /// <remarks>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>"Body mass index over 44.9 kg/m2."</para>
    /// labels<para>"super obese"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SuperObese">http://eulersharp.sourceforge.net/2003/03swap/humanBody#SuperObese</seealso>
    let SuperObese = Prefixed_Name(humanbody, "SuperObese") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body surface"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Surface">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Surface</seealso>
    let Surface = Prefixed_Name(humanbody, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:SurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body surface area"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceArea">http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceArea</seealso>
    let SurfaceArea = Prefixed_Name(humanbody, "SurfaceArea") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:SurfaceAreaMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Approximative calculation, e.g. in an N3 rule with formula of Mosteller, see http://eulersharp.sourceforge.net/2003/03swap/bodySurfaceArea_rules."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"human body surface area measurement"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceAreaMeasurement">http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceAreaMeasurement</seealso>
    let SurfaceAreaMeasurement =
        Prefixed_Name(humanbody, "SurfaceAreaMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:Underweight</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>humanbody:WeightStatus</para>
    ///   <para>"Body mass index ranging 16-18.4 kg/m2."</para>
    /// labels<para>"underweight"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Underweight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Underweight</seealso>
    let Underweight = Prefixed_Name(humanbody, "Underweight") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Weighing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"weighing a human body"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weighing">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weighing</seealso>
    let Weighing = Prefixed_Name(humanbody, "Weighing") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:WeighingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body weighing device"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeighingDevice">http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeighingDevice</seealso>
    let WeighingDevice = Prefixed_Name(humanbody, "WeighingDevice") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body weight"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weight</seealso>
    let Weight = Prefixed_Name(humanbody, "Weight") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:WeightMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human body weight measurement"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightMeasurement">http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightMeasurement</seealso>
    let WeightMeasurement =
        Prefixed_Name(humanbody, "WeightMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>humanbody:WeightStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"weight status"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightStatus">http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightStatus</seealso>
    let WeightStatus = Prefixed_Name(humanbody, "WeightStatus") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:hasBirthWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBirthWeight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBirthWeight</seealso>
    let hasBirthWeight = Prefixed_Name(humanbody, "hasBirthWeight") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:hasBodyMassIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBodyMassIndex">http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBodyMassIndex</seealso>
    let hasBodyMassIndex = Prefixed_Name(humanbody, "hasBodyMassIndex") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasLength">http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasLength</seealso>
    let hasLength = Prefixed_Name(humanbody, "hasLength") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:hasSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasSurfaceArea">http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasSurfaceArea</seealso>
    let hasSurfaceArea = Prefixed_Name(humanbody, "hasSurfaceArea") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:hasWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeight">http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeight</seealso>
    let hasWeight = Prefixed_Name(humanbody, "hasWeight") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:hasWeightStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeightStatus">http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeightStatus</seealso>
    let hasWeightStatus = Prefixed_Name(humanbody, "hasWeightStatus") |> PrefixedName
    /// <summary>
    ///   <para>humanbody:weightOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#weightOf">http://eulersharp.sourceforge.net/2003/03swap/humanBody#weightOf</seealso>
    let weightOf = Prefixed_Name(humanbody, "weightOf") |> PrefixedName
