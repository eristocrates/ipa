namespace http.purl.org.cld.freq.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module freq =
    let _namespace_iri = Namespace_Iri freq |> NamespaceIRI
    /// <summary>
    ///   <para>freq:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cld/freq/">http://purl.org/cld/freq/</seealso>
    let _prefix_iri = Prefixed_Name(freq, "") |> PrefixedName
    /// <summary>
    ///   <para>freq:annual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/annual">http://purl.org/cld/freq/annual</seealso>
    let annual = Prefixed_Name(freq, "annual") |> PrefixedName
    /// <summary>
    ///   <para>freq:biennial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/biennial">http://purl.org/cld/freq/biennial</seealso>
    let biennial = Prefixed_Name(freq, "biennial") |> PrefixedName
    /// <summary>
    ///   <para>freq:bimonthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/bimonthly">http://purl.org/cld/freq/bimonthly</seealso>
    let bimonthly = Prefixed_Name(freq, "bimonthly") |> PrefixedName
    /// <summary>
    ///   <para>freq:biweekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/biweekly">http://purl.org/cld/freq/biweekly</seealso>
    let biweekly = Prefixed_Name(freq, "biweekly") |> PrefixedName
    /// <summary>
    ///   <para>freq:continuous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/continuous">http://purl.org/cld/freq/continuous</seealso>
    let continuous = Prefixed_Name(freq, "continuous") |> PrefixedName
    /// <summary>
    ///   <para>freq:daily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/daily">http://purl.org/cld/freq/daily</seealso>
    let daily = Prefixed_Name(freq, "daily") |> PrefixedName
    /// <summary>
    ///   <para>freq:irregular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/irregular">http://purl.org/cld/freq/irregular</seealso>
    let irregular = Prefixed_Name(freq, "irregular") |> PrefixedName
    /// <summary>
    ///   <para>freq:monthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/monthly">http://purl.org/cld/freq/monthly</seealso>
    let monthly = Prefixed_Name(freq, "monthly") |> PrefixedName
    /// <summary>
    ///   <para>freq:quarterly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/quarterly">http://purl.org/cld/freq/quarterly</seealso>
    let quarterly = Prefixed_Name(freq, "quarterly") |> PrefixedName
    /// <summary>
    ///   <para>freq:semiannual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/semiannual">http://purl.org/cld/freq/semiannual</seealso>
    let semiannual = Prefixed_Name(freq, "semiannual") |> PrefixedName
    /// <summary>
    ///   <para>freq:semimonthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/semimonthly">http://purl.org/cld/freq/semimonthly</seealso>
    let semimonthly = Prefixed_Name(freq, "semimonthly") |> PrefixedName
    /// <summary>
    ///   <para>freq:semiweekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/semiweekly">http://purl.org/cld/freq/semiweekly</seealso>
    let semiweekly = Prefixed_Name(freq, "semiweekly") |> PrefixedName
    /// <summary>
    ///   <para>freq:threeTimesAMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/threeTimesAMonth">http://purl.org/cld/freq/threeTimesAMonth</seealso>
    let threeTimesAMonth = Prefixed_Name(freq, "threeTimesAMonth") |> PrefixedName
    /// <summary>
    ///   <para>freq:threeTimesAWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/threeTimesAWeek">http://purl.org/cld/freq/threeTimesAWeek</seealso>
    let threeTimesAWeek = Prefixed_Name(freq, "threeTimesAWeek") |> PrefixedName
    /// <summary>
    ///   <para>freq:threeTimesAYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/threeTimesAYear">http://purl.org/cld/freq/threeTimesAYear</seealso>
    let threeTimesAYear = Prefixed_Name(freq, "threeTimesAYear") |> PrefixedName
    /// <summary>
    ///   <para>freq:triennial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/triennial">http://purl.org/cld/freq/triennial</seealso>
    let triennial = Prefixed_Name(freq, "triennial") |> PrefixedName
    /// <summary>
    ///   <para>freq:weekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/cld/freq/weekly">http://purl.org/cld/freq/weekly</seealso>
    let weekly = Prefixed_Name(freq, "weekly") |> PrefixedName
