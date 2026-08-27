namespace http.purl.org.tempo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tempo =
    let _namespace_iri = Namespace_Iri tempo |> NamespaceIRI
    /// <summary>
    ///   <para>tempo:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/tempo/">http://purl.org/tempo/</seealso>
    let _prefix_iri = Prefixed_Name(tempo, "") |> PrefixedName
    /// <summary>
    ///   <para>tempo:0.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/tempo/0.1/">http://purl.org/tempo/0.1/</seealso>
    let ``_0.1/`` = Prefixed_Name(tempo, "0.1/") |> PrefixedName
    /// <summary>
    ///   <para>tempo:TemporalConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Temporal constraint box to capture a consistent set of validity and efficacy intervals.
    ///
    /// Objects of this class also serve the purpose to capture additional constraints or annotations, in particular when they are also temporally constrained.
    ///
    /// Example
    /// -------
    ///
    ///     ccy:EUR
    ///         a ccy:ISO4217-CurrencyCode ;
    ///         ccy:usedIn cc:DE , cc:GR ;
    ///         rdfs:label "EUR" ;
    ///         tempo:constrainedBy [
    ///             a tempo:TemporalConstraint ;
    ///             tempo:validFrom "1999-01-01"^^xsd:date ;
    ///             ccy:usedIn cc:DE ;
    ///         ] , [
    ///             a tempo:TemporalConstraint ;
    ///             tempo:validFrom "2001-01-01"^^xsd:date ;
    ///             ccy:usedIn cc:GR ;
    ///         ] .
    ///
    /// meaning the currency code 'EUR' became valid in Germany in 1999 whereas in Greece it became valid in 2001."</para>
    /// labels<para>"Temporal Constraint"</para></remarks>
    /// <seealso href="http://purl.org/tempo/TemporalConstraint">http://purl.org/tempo/TemporalConstraint</seealso>
    let TemporalConstraint = Prefixed_Name(tempo, "TemporalConstraint") |> PrefixedName
    /// <summary>
    ///   <para>tempo:constrainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A temporal constraint associated with this resource."</para>
    /// labels<para>"constrained by"</para></remarks>
    /// <seealso href="http://purl.org/tempo/constrainedBy">http://purl.org/tempo/constrainedBy</seealso>
    let constrainedBy = Prefixed_Name(tempo, "constrainedBy") |> PrefixedName
    /// <summary>
    ///   <para>tempo:efficaciousFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date or time when this resource becomes efficacious.
    ///
    /// If omitted the resource is said to be efficacious in the past from a tempo:efficaciousTill's point of view.
    /// If neither is present the resource is said to be forever efficacious.
    ///
    /// A resource might not exist yet or have ceased to exist during its efficacy,
    /// Use tempo:validFrom/tempo:validTill to track validity.
    ///
    /// Example
    /// -------
    /// The Federal Republic of Germany was formed on 1949-05-23.
    /// In 1974 ISO 3166 assigns the country code 'DE' to Germany.
    /// With today's knowledge it is safe to assume that no other country would have been assigned the country code 'DE' so we use information from the future to roll out the efficacy of the code into the past:
    ///
    ///     cc:DE
    ///         a cc:ISO3166-CountryCode ;
    ///         rdfs:label "DE" ;
    ///         cc:refersTo "Germany" ;
    ///         tempo:validFrom "1974"^^xsd:gYear ;
    ///         tempo:efficaciousFrom "1949-05-23"^^xsd:date .
    ///
    /// With this resource, a consumer of the dataset may safely liken the ccTLD '.de' to the country Germany as long as the temporal context is not older than 1949-05-23, while at the same time being aware that uses of the country code before 1974 are anachronistic.
    ///
    /// The notes about incomplete date or time types and mixing different date or time types in intervals made up from tempo:efficaciousFrom/tempo:efficaciousTill values as outlined in tempo:validFrom apply to efficacy annotations too.
    /// However, seeing as efficacy and validity are orthogonal concepts it is permissible to use incomplete date or time types on the efficacy axis different from the ones used on the validity axis.
    ///
    /// Example
    /// -------
    /// It is up further clarification whether in this resource:
    ///
    ///     ex:XY
    ///         rdfs:label "XY" ;
    ///         tempo:validFrom "2004-08-02"^^xsd:date ;
    ///         tempo:efficaciousFrom "2004-08"^^xsd:gYearMonth .
    ///
    /// the use of ex:XY's label on 2004-08-01 is anachronistic (use before its validated life-span) or illegal (use before efficacy)."</para>
    /// labels<para>"efficacious from"</para></remarks>
    /// <seealso href="http://purl.org/tempo/efficaciousFrom">http://purl.org/tempo/efficaciousFrom</seealso>
    let efficaciousFrom = Prefixed_Name(tempo, "efficaciousFrom") |> PrefixedName
    /// <summary>
    ///   <para>tempo:efficaciousTill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date or time when this resource becomes inefficacious.
    ///
    /// If omitted the resource is said to be efficacious in the future from a tempo:efficaciousFrom's point of view.
    /// If neither is present the resource is said to be forever efficacious.
    ///
    /// A resource might not exist yet or have ceased to exist during its efficacy,
    /// Use tempo:validFrom/tempo:validTill to track validity.
    ///
    /// Example
    /// -------
    /// The country code for Czechoslovkia had been 'CS' until 1993 when Czechoslovakia divided into Czechia and Slovakia.
    /// In 2003 then-Yugoslavia changed its name to Serbia and Montenegro, the ISO 3166 assignment is 'CS'.
    ///
    ///     cc:CSHH
    ///         a cc:ISO3166-CountryCode ;
    ///         rdfs:label "CS" ;
    ///         cc:refersTo "Czechoslovakia" ;
    ///         tempo:validFrom "1974"^^xsd:gYear ;
    ///         tempo:validTill "1993"^^xsd:gYear ;
    ///         tempo:efficaciousTill "2003"^^xsd:gYear .
    ///
    /// With this resource, a consumer of the dataset may safely attribute any occurrence of the label 'CS' before 2003 to Czechoslovakia.
    ///
    /// A point in time in tempo:efficaciousTill is always exclusive.  See tempo:validTill for further explanation and implications."</para>
    /// labels<para>"efficacious till"</para></remarks>
    /// <seealso href="http://purl.org/tempo/efficaciousTill">http://purl.org/tempo/efficaciousTill</seealso>
    let efficaciousTill = Prefixed_Name(tempo, "efficaciousTill") |> PrefixedName
    /// <summary>
    ///   <para>tempo:rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/tempo/rdf">http://purl.org/tempo/rdf</seealso>
    let rdf = Prefixed_Name(tempo, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>tempo:ttl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/tempo/ttl">http://purl.org/tempo/ttl</seealso>
    let ttl = Prefixed_Name(tempo, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>tempo:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date or time when this resource becomes valid.
    ///
    /// If omitted the resource is said to be valid in the past from a tempo:validTill's point of view.
    /// If neither is present the resource is said to be forever valid.
    ///
    /// A resource can be formally invalid and yet efficacious, like the future name of an unborn baby can be used to refer to the baby during pregnancy knowing that a birth certificate with this name will exist one day.
    /// Use tempo:efficaciousFrom/tempo:efficaciousTill to track efficacy.
    ///
    /// There are no restrictions on the multiplicity of tempo:validFrom.
    /// A resource can be valid during a number of non-overlapping time periods (intervals) which implies that multiple tempo:validFrom's can be ordered chronologically and paired with a chronological ordering of tempo:validTill's such that there is an alternating sequence of elements from the validFrom set and the validTill set with respect to chronologicity.
    ///
    /// Example
    /// -------
    /// The resource
    ///
    ///     []
    ///         tempo:validFrom "1998-01-01"^^xsd:date , "2004-01-01"^^xsd:date ;
    ///         tempo:validTill "2001-01-01"^^xsd:date , "2008-01-01"^^xsd:date .
    ///
    /// is valid during the union of the intervals [1998-01-01, 2001-01-01) and [2004-01-01, 2008-01-01).  Note: the textual order cannot be preserved so this resource
    ///
    ///     []
    ///         tempo:validFrom "1998-01-01"^^xsd:date ;
    ///         tempo:validTill "2008-01-01"^^xsd:date ;
    ///         tempo:validFrom "2004-01-01"^^xsd:date ;
    ///         tempo:validTill "2001-01-01"^^xsd:date .
    ///
    /// conveys the same validity statement as above.
    ///
    /// Example
    /// -------
    /// Omission of the time value for the most distant point in the past and/or the most distant point in the future mandates this resource
    ///
    ///     []
    ///         tempo:validFrom "2004-01-01"^^xsd:date ;
    ///         tempo:validTill "2001-01-01"^^xsd:date .
    ///
    /// to be interpreted as valid in [-infinity, 2001-01-01) u [2004-01-01, infinity), i.e. invalid during [2001-01-01, 2004-01-01).
    ///
    /// Illegal example
    /// ---------------
    /// The following resource
    ///
    ///     []
    ///         tempo:validFrom "1998-01-01"^^xsd:date , "2000-01-01"^^xsd:date , "2004-01-01"^^xsd:date ;
    ///         tempo:validTill "2001-01-01"^^xsd:date , "2008-01-01"^^xsd:date .
    ///
    /// does not convey proper validity information because 1998-01-01 would have to be paired with 2001-01-01 chronologically whilst alternatingly choosing from the 'from' and 'till' sets but [2000-01-01, 2008-01-01), interval next in line, overlaps with the first interval, i.e. there is a point in time that is invalid according to the first interval, to wit 2001-01-01, but at the same time valid according to the second interval.
    ///
    /// The use of incomplete date or time types is generally up to further clarification.  As far as temporal logic and constraints in TempO are concerned, a value of, say, "1999-02"^^xsd:gYearMonth is interpreted as "at some point in February 1999".  All of these points are considered equivalent as long as all values in tempo:validFrom (and paired up corresponding values in tempo:validTill) use the same scale.
    ///
    /// Using different date or time types is generally discouraged in situations where the coarser scale's value contains points before and after the finer scale's value.  That is the following is permissible
    ///
    ///     []
    ///         tempo:validFrom "2019"^^xsd:gYear ;
    ///         tempo:validTill "2022-02"^^xsd:gYearMonth .
    ///
    /// whereas
    ///
    ///     []
    ///         tempo:validFrom "2019"^^xsd:gYear ;
    ///         tempo:validTill "2019-02"^^xsd:gYearMonth .
    ///
    /// is discouraged.
    /// "</para>
    /// labels<para>"valid from"</para></remarks>
    /// <seealso href="http://purl.org/tempo/validFrom">http://purl.org/tempo/validFrom</seealso>
    let validFrom = Prefixed_Name(tempo, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>tempo:validTill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The date or time when this resource becomes invalid.
    ///
    /// If omitted the resource is said to be valid in the future from a tempo:validFrom's point of view.
    /// If neither is present the resource is said to be forever valid.
    ///
    /// A resource can be formally invalid and yet efficacious, like an expired passport can be used still to identify a person.
    /// Use tempo:efficaciousFrom/tempo:efficaciousTill to track efficacy.
    ///
    /// There are no restrictions on the multiplicity of tempo:validTill.
    /// A resource can be valid during a number of non-overlapping time periods (intervals) which implies that multiple tempo:validTill's can be ordered chronologically and paired with a chronological ordering of tempo:validFrom's such that there is an alternating sequence of elements from the validTill set and the validFrom set with respect to chronologicity.  See tempo:validFrom for an example.
    ///
    /// A point in time in tempo:validTill is always exclusive.
    /// Combined with the policy about omissible far-in-the-future and far-in-the-past time points this implies that the resource
    ///
    ///     []
    ///         tempo:validFrom "2009-09-09"^^xsd:date ;
    ///         tempo:validTill "2009-09-09"^^xsd:date .
    ///
    /// is to be interpreted as valid in [-infinity, 2009-09-09) and valid again in [2009-09-09, infinity), or in other words forever-valid.  There is no way to encode that a resource is valid only at exactly one point in time or during an infinitesimally small period of time.
    ///
    /// The use of incomplete date or time types is generally up to further clarification.  As far as temporal logic and constraints in TempO are concerned, a value of, say, "1999-02"^^xsd:gYearMonth is interpreted as "at some point in February 1999".  All of these points are considered equivalent as long as all values in tempo:validTill (and paired up corresponding values in tempo:validFrom) use the same scale.
    ///
    /// Using different date or time types is generally discouraged in situations where the coarser scale's value contains points before and after the finer scale's value.  That is the following is permissible
    ///
    ///     []
    ///         tempo:validFrom "2019"^^xsd:gYear ;
    ///         tempo:validTill "2022-02"^^xsd:gYearMonth .
    ///
    /// whereas
    ///
    ///     []
    ///         tempo:validFrom "2019"^^xsd:gYear ;
    ///         tempo:validTill "2019-02"^^xsd:gYearMonth .
    ///
    /// is discouraged.
    /// "</para>
    /// labels<para>"valid till"</para></remarks>
    /// <seealso href="http://purl.org/tempo/validTill">http://purl.org/tempo/validTill</seealso>
    let validTill = Prefixed_Name(tempo, "validTill") |> PrefixedName
