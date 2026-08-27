namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesListings.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_lst =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_lst |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-lst:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Listings Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_lst, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:ListedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"listed security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListedSecurity</seealso>
    let ListedSecurity =
        Prefixed_Name(fibo_sec_sec_lst, "ListedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:Listing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"listing"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/Listing">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/Listing</seealso>
    let Listing = Prefixed_Name(fibo_sec_sec_lst, "Listing") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:ListingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"listing service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListingService">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListingService</seealso>
    let ListingService =
        Prefixed_Name(fibo_sec_sec_lst, "ListingService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:RegisteredSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registered security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/RegisteredSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/RegisteredSecurity</seealso>
    let RegisteredSecurity =
        Prefixed_Name(fibo_sec_sec_lst, "RegisteredSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:hasDelistingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has delisting date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasDelistingDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasDelistingDate</seealso>
    let hasDelistingDate =
        Prefixed_Name(fibo_sec_sec_lst, "hasDelistingDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:hasHomeExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has home exchange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasHomeExchange">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasHomeExchange</seealso>
    let hasHomeExchange =
        Prefixed_Name(fibo_sec_sec_lst, "hasHomeExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:hasLastTradingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last trading date and time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasLastTradingDateTime">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasLastTradingDateTime</seealso>
    let hasLastTradingDateTime =
        Prefixed_Name(fibo_sec_sec_lst, "hasLastTradingDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:hasListingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has listing date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasListingDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasListingDate</seealso>
    let hasListingDate =
        Prefixed_Name(fibo_sec_sec_lst, "hasListingDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:hasOriginalPlaceOfListing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has original place of listing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasOriginalPlaceOfListing">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasOriginalPlaceOfListing</seealso>
    let hasOriginalPlaceOfListing =
        Prefixed_Name(fibo_sec_sec_lst, "hasOriginalPlaceOfListing") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-lst:hasTickSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has tick size"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasTickSize">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasTickSize</seealso>
    let hasTickSize = Prefixed_Name(fibo_sec_sec_lst, "hasTickSize") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-lst:isListedVia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is listed via"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isListedVia">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isListedVia</seealso>
    let isListedVia = Prefixed_Name(fibo_sec_sec_lst, "isListedVia") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-lst:isSeasoned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is seasoned"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isSeasoned">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isSeasoned</seealso>
    let isSeasoned = Prefixed_Name(fibo_sec_sec_lst, "isSeasoned") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-lst:isTradedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is traded on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isTradedOn">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isTradedOn</seealso>
    let isTradedOn = Prefixed_Name(fibo_sec_sec_lst, "isTradedOn") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-lst:lists</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"lists"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/lists">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/lists</seealso>
    let lists = Prefixed_Name(fibo_sec_sec_lst, "lists") |> PrefixedName
