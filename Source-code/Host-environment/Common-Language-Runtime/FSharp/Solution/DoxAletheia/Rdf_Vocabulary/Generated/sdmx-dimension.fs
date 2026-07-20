namespace http.purl.org.linked_data.sdmx._2009.dimension.hash

open DoxAletheia

module sdmx_dimension =
    let _namespace_name = "http://purl.org/linked-data/sdmx/2009/dimension#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The length of time that a person has lived or a thing has existed.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#age"></see></summary>
    let age = _prefix "age"
    /// <summary>
    /// Legal, conjugal status of each individual in relation to the marriage laws or customs of the country.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#civilStatus"></see></summary>
    let civilStatus = _prefix "civilStatus"
    /// <summary>
    /// Monetary denomination of the object being measured.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// The highest level of an educational programme the person has successfully completed.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#educationLev"></see></summary>
    let educationLev = _prefix "educationLev"
    /// <summary>
    /// The time interval at which observations occur over a given time period.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#freq"></see></summary>
    let freq = _prefix "freq"
    /// <summary>
    /// Job or position held by an individual who performs a set of tasks and duties.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#occupation"></see></summary>
    let occupation = _prefix "occupation"
    /// <summary>
    /// The country or geographic area to which the measured statistical phenomenon relates.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#refArea"></see></summary>
    let refArea = _prefix "refArea"
    /// <summary>
    /// The period of time or point in time to which the measured observation is intended to refer.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#refPeriod"></see></summary>
    let refPeriod = _prefix "refPeriod"
    /// <summary>
    /// The state of being male or female.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#sex"></see></summary>
    let sex = _prefix "sex"
    /// <summary>
    /// The period of time or point in time to which the measured observation refers.
    /// <see href="http://purl.org/linked-data/sdmx/2009/dimension#timePeriod"></see></summary>
    let timePeriod = _prefix "timePeriod"
