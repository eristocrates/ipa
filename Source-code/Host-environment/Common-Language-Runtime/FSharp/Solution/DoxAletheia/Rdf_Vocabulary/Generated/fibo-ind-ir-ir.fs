namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.InterestRates.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ir_ir =
    let _namespace_iri = Namespace_Iri fibo_ind_ir_ir |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ir-ir:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Interest Rates Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ir_ir, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:BaseRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"base rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/BaseRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/BaseRate</seealso>
    let BaseRate = Prefixed_Name(fibo_ind_ir_ir, "BaseRate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:EighteenMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"eighteen months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/EighteenMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/EighteenMonths</seealso>
    let EighteenMonths = Prefixed_Name(fibo_ind_ir_ir, "EighteenMonths") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:FifteenYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"fifteen years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FifteenYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FifteenYears</seealso>
    let FifteenYears = Prefixed_Name(fibo_ind_ir_ir, "FifteenYears") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:FiveYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"five years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FiveYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FiveYears</seealso>
    let FiveYears = Prefixed_Name(fibo_ind_ir_ir, "FiveYears") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:FortyEightMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"forty-eight months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FortyEightMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FortyEightMonths</seealso>
    let FortyEightMonths =
        Prefixed_Name(fibo_ind_ir_ir, "FortyEightMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:FourYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"four years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FourYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/FourYears</seealso>
    let FourYears = Prefixed_Name(fibo_ind_ir_ir, "FourYears") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterbankBidRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interbank bid rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankBidRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankBidRate</seealso>
    let InterbankBidRate =
        Prefixed_Name(fibo_ind_ir_ir, "InterbankBidRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterbankMidRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interbank mid rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankMidRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankMidRate</seealso>
    let InterbankMidRate =
        Prefixed_Name(fibo_ind_ir_ir, "InterbankMidRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterbankOfferedRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interbank offered rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankOfferedRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankOfferedRate</seealso>
    let InterbankOfferedRate =
        Prefixed_Name(fibo_ind_ir_ir, "InterbankOfferedRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterbankRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interbank rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankRate</seealso>
    let InterbankRate = Prefixed_Name(fibo_ind_ir_ir, "InterbankRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterestRateAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateAuthority">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateAuthority</seealso>
    let InterestRateAuthority =
        Prefixed_Name(fibo_ind_ir_ir, "InterestRateAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate benchmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmark">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmark</seealso>
    let InterestRateBenchmark =
        Prefixed_Name(fibo_ind_ir_ir, "InterestRateBenchmark") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmarkClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate benchmark classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmarkClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmarkClassificationScheme</seealso>
    let InterestRateBenchmarkClassificationScheme =
        Prefixed_Name(fibo_ind_ir_ir, "InterestRateBenchmarkClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:NineMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"nine months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/NineMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/NineMonths</seealso>
    let NineMonths = Prefixed_Name(fibo_ind_ir_ir, "NineMonths") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:OneDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"one day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneDay">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneDay</seealso>
    let OneDay = Prefixed_Name(fibo_ind_ir_ir, "OneDay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:OneHundredEightyMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"one hundred eighty months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneHundredEightyMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneHundredEightyMonths</seealso>
    let OneHundredEightyMonths =
        Prefixed_Name(fibo_ind_ir_ir, "OneHundredEightyMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:OneMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"one month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneMonth">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneMonth</seealso>
    let OneMonth = Prefixed_Name(fibo_ind_ir_ir, "OneMonth") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:OneWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"one week"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneWeek">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneWeek</seealso>
    let OneWeek = Prefixed_Name(fibo_ind_ir_ir, "OneWeek") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:OneYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"one year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneYear">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OneYear</seealso>
    let OneYear = Prefixed_Name(fibo_ind_ir_ir, "OneYear") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:OvernightRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"overnight rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OvernightRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OvernightRate</seealso>
    let OvernightRate = Prefixed_Name(fibo_ind_ir_ir, "OvernightRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:ReferenceInterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reference interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ReferenceInterestRate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ReferenceInterestRate</seealso>
    let ReferenceInterestRate =
        Prefixed_Name(fibo_ind_ir_ir, "ReferenceInterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:SixMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"six months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixMonths</seealso>
    let SixMonths = Prefixed_Name(fibo_ind_ir_ir, "SixMonths") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:SixtyMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"sixty months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixtyMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SixtyMonths</seealso>
    let SixtyMonths = Prefixed_Name(fibo_ind_ir_ir, "SixtyMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:SpecificProviderInterestRateBenchmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specific-provider interest rate benchmark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SpecificProviderInterestRateBenchmark">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SpecificProviderInterestRateBenchmark</seealso>
    let SpecificProviderInterestRateBenchmark =
        Prefixed_Name(fibo_ind_ir_ir, "SpecificProviderInterestRateBenchmark") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:TenYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ten years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TenYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TenYears</seealso>
    let TenYears = Prefixed_Name(fibo_ind_ir_ir, "TenYears") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:ThirtySixMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"thirty-six months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtySixMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtySixMonths</seealso>
    let ThirtySixMonths =
        Prefixed_Name(fibo_ind_ir_ir, "ThirtySixMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:ThirtyYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"thirty years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtyYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThirtyYears</seealso>
    let ThirtyYears = Prefixed_Name(fibo_ind_ir_ir, "ThirtyYears") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:ThreeHundredSixtyMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"three hundred sixty months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeHundredSixtyMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeHundredSixtyMonths</seealso>
    let ThreeHundredSixtyMonths =
        Prefixed_Name(fibo_ind_ir_ir, "ThreeHundredSixtyMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:ThreeMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"three months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeMonths</seealso>
    let ThreeMonths = Prefixed_Name(fibo_ind_ir_ir, "ThreeMonths") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:ThreeYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"three years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ThreeYears</seealso>
    let ThreeYears = Prefixed_Name(fibo_ind_ir_ir, "ThreeYears") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:TwelveMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"twelve months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwelveMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwelveMonths</seealso>
    let TwelveMonths = Prefixed_Name(fibo_ind_ir_ir, "TwelveMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:TwentyFourMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///
    /// labels<para>"twenty-four months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyFourMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyFourMonths</seealso>
    let TwentyFourMonths =
        Prefixed_Name(fibo_ind_ir_ir, "TwentyFourMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:TwentyYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"twenty years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwentyYears</seealso>
    let TwentyYears = Prefixed_Name(fibo_ind_ir_ir, "TwentyYears") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:TwoMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"two months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoMonths">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoMonths</seealso>
    let TwoMonths = Prefixed_Name(fibo_ind_ir_ir, "TwoMonths") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-ir:TwoYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"two years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoYears">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/TwoYears</seealso>
    let TwoYears = Prefixed_Name(fibo_ind_ir_ir, "TwoYears") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:hasRateResetTimeOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has rate reset time of day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasRateResetTimeOfDay">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasRateResetTimeOfDay</seealso>
    let hasRateResetTimeOfDay =
        Prefixed_Name(fibo_ind_ir_ir, "hasRateResetTimeOfDay") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:hasReferenceCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reference currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasReferenceCurrency">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasReferenceCurrency</seealso>
    let hasReferenceCurrency =
        Prefixed_Name(fibo_ind_ir_ir, "hasReferenceCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-ir:hasTenor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has tenor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasTenor">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasTenor</seealso>
    let hasTenor = Prefixed_Name(fibo_ind_ir_ir, "hasTenor") |> PrefixedName
