namespace https.spdx.org.rdf._3._1.terms.Dataset.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns3 =
    let _namespace_iri = Namespace_Iri ns3 |> NamespaceIRI

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Confidentiality level."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType</seealso>
    let ConfidentialityLevelType =
        Prefixed_Name(ns3, "ConfidentialityLevelType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/amber</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data points in the dataset can be shared only with specific organizations and their clients on a need to know basis."</para>
    /// labels<para>"amber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/amber">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/amber</seealso>
    let ``ConfidentialityLevelType/amber`` =
        Prefixed_Name(ns3, "ConfidentialityLevelType/amber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/clear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>"Dataset may be distributed freely, without restriction."</para>
    /// labels<para>"clear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/clear">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/clear</seealso>
    let ``ConfidentialityLevelType/clear`` =
        Prefixed_Name(ns3, "ConfidentialityLevelType/clear") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/green</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Dataset can be shared within a community of peers and partners."</para>
    /// labels<para>"green"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/green">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/green</seealso>
    let ``ConfidentialityLevelType/green`` =
        Prefixed_Name(ns3, "ConfidentialityLevelType/green") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/red</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data points in the dataset are highly confidential and can only be shared with named recipients."</para>
    /// labels<para>"red"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/red">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/red</seealso>
    let ``ConfidentialityLevelType/red`` =
        Prefixed_Name(ns3, "ConfidentialityLevelType/red") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Availability of dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType</seealso>
    let DatasetAvailabilityType =
        Prefixed_Name(ns3, "DatasetAvailabilityType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/clickthrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Dataset is not publicly available and can only be accessed after affirmatively accepting terms on a clickthrough webpage."</para>
    /// labels<para>"clickthrough"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/clickthrough">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/clickthrough</seealso>
    let ``DatasetAvailabilityType/clickthrough`` =
        Prefixed_Name(ns3, "DatasetAvailabilityType/clickthrough") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/directDownload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>"Dataset is publicly available and can be downloaded directly."</para>
    /// labels<para>"directDownload"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/directDownload">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/directDownload</seealso>
    let ``DatasetAvailabilityType/directDownload`` =
        Prefixed_Name(ns3, "DatasetAvailabilityType/directDownload") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>"Dataset is publicly available, but not all at once, and can only be accessed through queries which return parts of the dataset."</para>
    /// labels<para>"query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/query">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/query</seealso>
    let ``DatasetAvailabilityType/query`` =
        Prefixed_Name(ns3, "DatasetAvailabilityType/query") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Dataset is not publicly available and an email registration is required before accessing the dataset, although without an affirmative acceptance of terms."</para>
    /// labels<para>"registration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/registration">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/registration</seealso>
    let ``DatasetAvailabilityType/registration`` =
        Prefixed_Name(ns3, "DatasetAvailabilityType/registration") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/scrapingScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>"Dataset provider is not making available the underlying data and the dataset shall be reassembled, typically using the provided script for scraping the data."</para>
    /// labels<para>"scrapingScript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/scrapingScript">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/scrapingScript</seealso>
    let ``DatasetAvailabilityType/scrapingScript`` =
        Prefixed_Name(ns3, "DatasetAvailabilityType/scrapingScript") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Package that contains a dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetPackage">https://spdx.org/rdf/3.1/terms/Dataset/DatasetPackage</seealso>
    let DatasetPackage = Prefixed_Name(ns3, "DatasetPackage") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/DatasetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumeration of dataset types."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType</seealso>
    let DatasetType = Prefixed_Name(ns3, "DatasetType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data is audio based, such as a collection of music from the 80s."</para>
    /// labels<para>"audio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/audio">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/audio</seealso>
    let ``DatasetType/audio`` = Prefixed_Name(ns3, "DatasetType/audio") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/categorical</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data that is classified into a discrete number of categories, such as the eye color of a population of people."</para>
    /// labels<para>"categorical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/categorical">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/categorical</seealso>
    let ``DatasetType/categorical`` =
        Prefixed_Name(ns3, "DatasetType/categorical") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>"Data is in the form of a graph where entries are somehow related to each other through edges, such a social network of friends."</para>
    /// labels<para>"graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/graph">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/graph</seealso>
    let ``DatasetType/graph`` = Prefixed_Name(ns3, "DatasetType/graph") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/image</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data is a collection of images such as pictures of animals."</para>
    /// labels<para>"image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/image">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/image</seealso>
    let ``DatasetType/image`` = Prefixed_Name(ns3, "DatasetType/image") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data type is not known."</para>
    /// labels<para>"noAssertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/noAssertion">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/noAssertion</seealso>
    let ``DatasetType/noAssertion`` =
        Prefixed_Name(ns3, "DatasetType/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/numeric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>"Data consists only of numeric entries."</para>
    /// labels<para>"numeric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/numeric">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/numeric</seealso>
    let ``DatasetType/numeric`` =
        Prefixed_Name(ns3, "DatasetType/numeric") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data is of a type not included in this list."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/other">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/other</seealso>
    let ``DatasetType/other`` = Prefixed_Name(ns3, "DatasetType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data is recorded from a physical sensor, such as a thermometer reading or biometric device."</para>
    /// labels<para>"sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/sensor">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/sensor</seealso>
    let ``DatasetType/sensor`` =
        Prefixed_Name(ns3, "DatasetType/sensor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/structured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>"Data is stored in tabular format or retrieved from a relational database."</para>
    /// labels<para>"structured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/structured">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/structured</seealso>
    let ``DatasetType/structured`` =
        Prefixed_Name(ns3, "DatasetType/structured") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/syntactic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>"Data describes the syntax or semantics of a language or text, such as a parse tree used for natural language processing."</para>
    /// labels<para>"syntactic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/syntactic">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/syntactic</seealso>
    let ``DatasetType/syntactic`` =
        Prefixed_Name(ns3, "DatasetType/syntactic") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>"Data consists of unstructured text, such as a book, a Wikipedia article (without images), or a transcript."</para>
    /// labels<para>"text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/text">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/text</seealso>
    let ``DatasetType/text`` = Prefixed_Name(ns3, "DatasetType/text") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/timeseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data is recorded in an ordered sequence of timestamped entries, such as the price of a stock over the course of a day."</para>
    /// labels<para>"timeseries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timeseries">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timeseries</seealso>
    let ``DatasetType/timeseries`` =
        Prefixed_Name(ns3, "DatasetType/timeseries") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data is recorded with a timestamp for each entry, but not necessarily ordered or at specific intervals, such as when a taxi ride starts and ends."</para>
    /// labels<para>"timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timestamp">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timestamp</seealso>
    let ``DatasetType/timestamp`` =
        Prefixed_Name(ns3, "DatasetType/timestamp") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>"Data is video based, such as a collection of movie clips featuring Tom Hanks."</para>
    /// labels<para>"video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/video">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/video</seealso>
    let ``DatasetType/video`` = Prefixed_Name(ns3, "DatasetType/video") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/anonymizationMethodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Anonymization methods used."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/anonymizationMethodUsed">https://spdx.org/rdf/3.1/terms/Dataset/anonymizationMethodUsed</seealso>
    let anonymizationMethodUsed =
        Prefixed_Name(ns3, "anonymizationMethodUsed") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/confidentialityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Confidentiality level of the data points contained in the dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/confidentialityLevel">https://spdx.org/rdf/3.1/terms/Dataset/confidentialityLevel</seealso>
    let confidentialityLevel =
        Prefixed_Name(ns3, "confidentialityLevel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/dataCollectionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"How the dataset was collected."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/dataCollectionProcess">https://spdx.org/rdf/3.1/terms/Dataset/dataCollectionProcess</seealso>
    let dataCollectionProcess =
        Prefixed_Name(ns3, "dataCollectionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/dataPreprocessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Preprocessing steps that were applied to the raw data to create the given dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/dataPreprocessing">https://spdx.org/rdf/3.1/terms/Dataset/dataPreprocessing</seealso>
    let dataPreprocessing = Prefixed_Name(ns3, "dataPreprocessing") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/datasetAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Availability of a dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetAvailability">https://spdx.org/rdf/3.1/terms/Dataset/datasetAvailability</seealso>
    let datasetAvailability = Prefixed_Name(ns3, "datasetAvailability") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/datasetNoise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Potentially noisy elements of the dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetNoise">https://spdx.org/rdf/3.1/terms/Dataset/datasetNoise</seealso>
    let datasetNoise = Prefixed_Name(ns3, "datasetNoise") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/datasetSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"**DEPRECATED in SPDX 3.1.**
    /// Use [/Software/artifactSize](../../Software/Properties/artifactSize.md)
    /// instead.
    ///
    /// Size of the dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetSize">https://spdx.org/rdf/3.1/terms/Dataset/datasetSize</seealso>
    let datasetSize = Prefixed_Name(ns3, "datasetSize") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/datasetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type of data in a dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetType">https://spdx.org/rdf/3.1/terms/Dataset/datasetType</seealso>
    let datasetType = Prefixed_Name(ns3, "datasetType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/datasetUpdateMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Mechanism to update the dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetUpdateMechanism">https://spdx.org/rdf/3.1/terms/Dataset/datasetUpdateMechanism</seealso>
    let datasetUpdateMechanism =
        Prefixed_Name(ns3, "datasetUpdateMechanism") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/hasSensitivePersonalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes if any sensitive personal information is present in the dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/hasSensitivePersonalInformation">https://spdx.org/rdf/3.1/terms/Dataset/hasSensitivePersonalInformation</seealso>
    let hasSensitivePersonalInformation =
        Prefixed_Name(ns3, "hasSensitivePersonalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/intendedUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"**DEPRECATED in SPDX 3.1.**
    /// Use [/Core/intendedUse](../../Core/Properties/intendedUse.md) instead.
    ///
    /// The intended use of a given dataset."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/intendedUse">https://spdx.org/rdf/3.1/terms/Dataset/intendedUse</seealso>
    let intendedUse = Prefixed_Name(ns3, "intendedUse") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/knownBias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Records the biases that the dataset is known to encompass."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/knownBias">https://spdx.org/rdf/3.1/terms/Dataset/knownBias</seealso>
    let knownBias = Prefixed_Name(ns3, "knownBias") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Dataset/sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes a sensor used for collecting the data."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/sensor">https://spdx.org/rdf/3.1/terms/Dataset/sensor</seealso>
    let sensor = Prefixed_Name(ns3, "sensor") |> PrefixedName
