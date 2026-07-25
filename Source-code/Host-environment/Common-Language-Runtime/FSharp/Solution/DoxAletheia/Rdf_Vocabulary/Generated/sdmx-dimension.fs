namespace http.purl.org.linked_data.sdmx._2009.dimension.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdmx_dimension =
    let _namespace_iri = Namespace_Iri sdmx_dimension |> NamespaceIRI
    /// <summary>
    ///   <para>sdmx-dimension:civilStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Legal, conjugal status of each individual in relation to the marriage laws or customs of the country.</para>
    /// labels<para>Civil Status</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#civilStatus">http://purl.org/linked-data/sdmx/2009/dimension#civilStatus</seealso>
    let civilStatus = Prefixed_Name(sdmx_dimension, "civilStatus") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:educationLev</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>The highest level of an educational programme the person has successfully completed.</para>
    /// labels<para>Education Level</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#educationLev">http://purl.org/linked-data/sdmx/2009/dimension#educationLev</seealso>
    let educationLev = Prefixed_Name(sdmx_dimension, "educationLev") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>Job or position held by an individual who performs a set of tasks and duties.</para>
    /// labels<para>Occupation</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#occupation">http://purl.org/linked-data/sdmx/2009/dimension#occupation</seealso>
    let occupation = Prefixed_Name(sdmx_dimension, "occupation") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>qb:CodedProperty</para>
    ///   <para>The state of being male or female.</para>
    /// labels<para>Sex</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#sex">http://purl.org/linked-data/sdmx/2009/dimension#sex</seealso>
    let sex = Prefixed_Name(sdmx_dimension, "sex") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:timePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>The period of time or point in time to which the measured observation refers.</para>
    /// labels<para>Time Period</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#timePeriod">http://purl.org/linked-data/sdmx/2009/dimension#timePeriod</seealso>
    let timePeriod = Prefixed_Name(sdmx_dimension, "timePeriod") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:freq</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:CodedProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>The time interval at which observations occur over a given time period.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#freq">http://purl.org/linked-data/sdmx/2009/dimension#freq</seealso>
    let freq = Prefixed_Name(sdmx_dimension, "freq") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:refArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The country or geographic area to which the measured statistical phenomenon relates.</para>
    /// labels<para>Reference Area</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#refArea">http://purl.org/linked-data/sdmx/2009/dimension#refArea</seealso>
    let refArea = Prefixed_Name(sdmx_dimension, "refArea") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:refPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The period of time or point in time to which the measured observation is intended to refer.</para>
    /// labels<para>Reference Period</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#refPeriod">http://purl.org/linked-data/sdmx/2009/dimension#refPeriod</seealso>
    let refPeriod = Prefixed_Name(sdmx_dimension, "refPeriod") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The length of time that a person has lived or a thing has existed.</para>
    /// labels<para>Age</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#age">http://purl.org/linked-data/sdmx/2009/dimension#age</seealso>
    let age = Prefixed_Name(sdmx_dimension, "age") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-dimension:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>qb:CodedProperty</para>
    ///   <para>Monetary denomination of the object being measured.</para>
    /// labels<para>Currency</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/dimension#currency">http://purl.org/linked-data/sdmx/2009/dimension#currency</seealso>
    let currency = Prefixed_Name(sdmx_dimension, "currency") |> PrefixedName
