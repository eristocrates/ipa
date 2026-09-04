#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``sdmx-dimension`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/linked-data/sdmx/2009/dimension#" "sdmx-dimension"

    /// <summary>
    ///   <para>rdfs:comment : The length of time that a person has lived or a thing has existed.</para>
    ///   <para>rdfs:label : Age</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#age">sdmx-dimension:age</a>
    /// </summary>
    let age = _prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:comment : Legal, conjugal status of each individual in relation to the marriage laws or customs of the country.</para>
    ///   <para>rdfs:label : Civil Status</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#civilStatus">sdmx-dimension:civilStatus</a>
    /// </summary>
    let civilStatus = _prefixId.prefix "civilStatus"
    /// <summary>
    ///   <para>rdfs:label : Currency</para>
    ///   <para>rdfs:comment : Monetary denomination of the object being measured.</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#currency">sdmx-dimension:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:comment : The highest level of an educational programme the person has successfully completed.</para>
    ///   <para>rdfs:label : Education Level</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#educationLev">sdmx-dimension:educationLev</a>
    /// </summary>
    let educationLev = _prefixId.prefix "educationLev"
    /// <summary>
    ///   <para>rdfs:comment : The time interval at which observations occur over a given time period.</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#freq">sdmx-dimension:freq</a>
    /// </summary>
    let freq = _prefixId.prefix "freq"
    /// <summary>
    ///   <para>rdfs:comment : Job or position held by an individual who performs a set of tasks and duties.</para>
    ///   <para>rdfs:label : Occupation</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#occupation">sdmx-dimension:occupation</a>
    /// </summary>
    let occupation = _prefixId.prefix "occupation"
    /// <summary>
    ///   <para>rdfs:comment : The country or geographic area to which the measured statistical phenomenon relates.</para>
    ///   <para>rdfs:label : Reference Area</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#refArea">sdmx-dimension:refArea</a>
    /// </summary>
    let refArea = _prefixId.prefix "refArea"
    /// <summary>
    ///   <para>rdfs:comment : The period of time or point in time to which the measured observation is intended to refer.</para>
    ///   <para>rdfs:label : Reference Period</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#refPeriod">sdmx-dimension:refPeriod</a>
    /// </summary>
    let refPeriod = _prefixId.prefix "refPeriod"
    /// <summary>
    ///   <para>rdfs:comment : The state of being male or female.</para>
    ///   <para>rdfs:label : Sex</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#sex">sdmx-dimension:sex</a>
    /// </summary>
    let sex = _prefixId.prefix "sex"
    /// <summary>
    ///   <para>rdfs:comment : The period of time or point in time to which the measured observation refers.</para>
    ///   <para>rdfs:label : Time Period</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/dimension#timePeriod">sdmx-dimension:timePeriod</a>
    /// </summary>
    let timePeriod = _prefixId.prefix "timePeriod"
