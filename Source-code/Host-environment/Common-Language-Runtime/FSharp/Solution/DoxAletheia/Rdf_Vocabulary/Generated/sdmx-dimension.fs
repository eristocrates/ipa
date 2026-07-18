namespace http.purl.org.linked_data.sdmx._2009.dimension.hash

open DoxAletheia.Rdf_Vocabulary

module sdmx_dimension =
    let _namespace_name = "http://purl.org/linked-data/sdmx/2009/dimension#"
    /// <summary>
    /// The length of time that a person has lived or a thing has existed.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#age"></see></summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName

    /// <summary>
    /// Legal, conjugal status of each individual in relation to the marriage laws or customs of the country.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#civilStatus"></see></summary>
    let civilStatus =
        Namespaced_IRI.parse _namespace_name "civilStatus" |> NamespacedName

    /// <summary>
    /// Monetary denomination of the object being measured.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName

    /// <summary>
    /// The highest level of an educational programme the person has successfully completed.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#educationLev"></see></summary>
    let educationLev =
        Namespaced_IRI.parse _namespace_name "educationLev" |> NamespacedName

    /// <summary>
    /// The time interval at which observations occur over a given time period.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#freq"></see></summary>
    let freq = Namespaced_IRI.parse _namespace_name "freq" |> NamespacedName
    /// <summary>
    /// Job or position held by an individual who performs a set of tasks and duties.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#occupation"></see></summary>
    let occupation = Namespaced_IRI.parse _namespace_name "occupation" |> NamespacedName
    /// <summary>
    /// The country or geographic area to which the measured statistical phenomenon relates.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#refArea"></see></summary>
    let refArea = Namespaced_IRI.parse _namespace_name "refArea" |> NamespacedName
    /// <summary>
    /// The period of time or point in time to which the measured observation is intended to refer.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#refPeriod"></see></summary>
    let refPeriod = Namespaced_IRI.parse _namespace_name "refPeriod" |> NamespacedName
    /// <summary>
    /// The state of being male or female.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#sex"></see></summary>
    let sex = Namespaced_IRI.parse _namespace_name "sex" |> NamespacedName
    /// <summary>
    /// The period of time or point in time to which the measured observation refers.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#timePeriod"></see></summary>
    let timePeriod = Namespaced_IRI.parse _namespace_name "timePeriod" |> NamespacedName
