namespace http.purl.org.linked_data.sdmx._2009.code.hash

open DoxAletheia.Rdf_Vocabulary

module sdmx_code =
    let _namespace_name = "http://purl.org/linked-data/sdmx/2009/code#"
    /// <summary>
    /// : This code list provides code values for geographical areas, defined as areas included within the borders of a country, region, group of countries, etc.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#area"></see>
    /// </summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName
    /// <summary>
    /// this code list provides coded information about the sensitivity and confidentiality status of the data.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#ConfStatus"></see></summary>
    let ConfStatus = Namespaced_IRI.parse _namespace_name "ConfStatus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus"></see>
    /// </summary>
    let confStatus = Namespaced_IRI.parse _namespace_name "confStatus" |> NamespacedName
    /// <summary>
    /// This code list provides code values for currencies.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Currency"></see></summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#currency"></see>
    /// </summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName
    /// <summary>
    /// It provides a list of values showing the number of decimal digits used in the data.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Decimals"></see></summary>
    let Decimals = Namespaced_IRI.parse _namespace_name "Decimals" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals"></see>
    /// </summary>
    let decimals = Namespaced_IRI.parse _namespace_name "decimals" |> NamespacedName
    /// <summary>
    /// It provides a list of values indicating the "frequency" of the data (e.g. monthly) and, thus, indirectly, also implying the type of "time reference" that could be used for identifying the data with respect time.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Freq"></see></summary>
    let Freq = Namespaced_IRI.parse _namespace_name "Freq" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq"></see>
    /// </summary>
    let freq = Namespaced_IRI.parse _namespace_name "freq" |> NamespacedName
    /// <summary>
    /// This code list provides coded information about the "status" of an observation (with respect events such as the ones reflected in the codes composing the code list).
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#ObsStatus"></see></summary>
    let ObsStatus = Namespaced_IRI.parse _namespace_name "ObsStatus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus"></see>
    /// </summary>
    let obsStatus = Namespaced_IRI.parse _namespace_name "obsStatus" |> NamespacedName
    /// <summary>
    /// This  code list provides the gender.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Sex"></see></summary>
    let Sex = Namespaced_IRI.parse _namespace_name "Sex" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex"></see>
    /// </summary>
    let sex = Namespaced_IRI.parse _namespace_name "sex" |> NamespacedName
    /// <summary>
    /// These codes (based on the ISO 8601 standard) indicate the type of time references used in the data. The numeric codes below (203, 102,...,702) are used only in the SDMX-EDI messages; and the alphanumeric codes (P1D...PT1M) only in the SDMX-ML messages.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#TimeFormat"></see></summary>
    let TimeFormat = Namespaced_IRI.parse _namespace_name "TimeFormat" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat"></see>
    /// </summary>
    let timeFormat = Namespaced_IRI.parse _namespace_name "timeFormat" |> NamespacedName
    /// <summary>
    /// it provides code values for indicating the magnitude in the units of measurements.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#UnitMult"></see></summary>
    let UnitMult = Namespaced_IRI.parse _namespace_name "UnitMult" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult"></see>
    /// </summary>
    let unitMult = Namespaced_IRI.parse _namespace_name "unitMult" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-F"></see>
    /// </summary>
    let ``confStatus-F`` =
        Namespaced_IRI.parse _namespace_name "confStatus-F" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-S"></see>
    /// </summary>
    let ``confStatus-S`` =
        Namespaced_IRI.parse _namespace_name "confStatus-S" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-D"></see>
    /// </summary>
    let ``confStatus-D`` =
        Namespaced_IRI.parse _namespace_name "confStatus-D" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-N"></see>
    /// </summary>
    let ``confStatus-N`` =
        Namespaced_IRI.parse _namespace_name "confStatus-N" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-C"></see>
    /// </summary>
    let ``confStatus-C`` =
        Namespaced_IRI.parse _namespace_name "confStatus-C" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-5"></see>
    /// </summary>
    let ``decimals-5`` =
        Namespaced_IRI.parse _namespace_name "decimals-5" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-3"></see>
    /// </summary>
    let ``decimals-3`` =
        Namespaced_IRI.parse _namespace_name "decimals-3" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-8"></see>
    /// </summary>
    let ``decimals-8`` =
        Namespaced_IRI.parse _namespace_name "decimals-8" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-6"></see>
    /// </summary>
    let ``decimals-6`` =
        Namespaced_IRI.parse _namespace_name "decimals-6" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-1"></see>
    /// </summary>
    let ``decimals-1`` =
        Namespaced_IRI.parse _namespace_name "decimals-1" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-4"></see>
    /// </summary>
    let ``decimals-4`` =
        Namespaced_IRI.parse _namespace_name "decimals-4" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-2"></see>
    /// </summary>
    let ``decimals-2`` =
        Namespaced_IRI.parse _namespace_name "decimals-2" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-9"></see>
    /// </summary>
    let ``decimals-9`` =
        Namespaced_IRI.parse _namespace_name "decimals-9" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-0"></see>
    /// </summary>
    let ``decimals-0`` =
        Namespaced_IRI.parse _namespace_name "decimals-0" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-7"></see>
    /// </summary>
    let ``decimals-7`` =
        Namespaced_IRI.parse _namespace_name "decimals-7" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-D"></see>
    /// </summary>
    let ``freq-D`` = Namespaced_IRI.parse _namespace_name "freq-D" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-W"></see>
    /// </summary>
    let ``freq-W`` = Namespaced_IRI.parse _namespace_name "freq-W" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-M"></see>
    /// </summary>
    let ``freq-M`` = Namespaced_IRI.parse _namespace_name "freq-M" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-Q"></see>
    /// </summary>
    let ``freq-Q`` = Namespaced_IRI.parse _namespace_name "freq-Q" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-B"></see>
    /// </summary>
    let ``freq-B`` = Namespaced_IRI.parse _namespace_name "freq-B" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-S"></see>
    /// </summary>
    let ``freq-S`` = Namespaced_IRI.parse _namespace_name "freq-S" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-N"></see>
    /// </summary>
    let ``freq-N`` = Namespaced_IRI.parse _namespace_name "freq-N" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-A"></see>
    /// </summary>
    let ``freq-A`` = Namespaced_IRI.parse _namespace_name "freq-A" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-A"></see>
    /// </summary>
    let ``obsStatus-A`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-A" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-M"></see>
    /// </summary>
    let ``obsStatus-M`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-M" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-F"></see>
    /// </summary>
    let ``obsStatus-F`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-F" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-I"></see>
    /// </summary>
    let ``obsStatus-I`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-I" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-B"></see>
    /// </summary>
    let ``obsStatus-B`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-B" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-E"></see>
    /// </summary>
    let ``obsStatus-E`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-E" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-P"></see>
    /// </summary>
    let ``obsStatus-P`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-P" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-S"></see>
    /// </summary>
    let ``obsStatus-S`` =
        Namespaced_IRI.parse _namespace_name "obsStatus-S" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-U"></see>
    /// </summary>
    let ``sex-U`` = Namespaced_IRI.parse _namespace_name "sex-U" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-M"></see>
    /// </summary>
    let ``sex-M`` = Namespaced_IRI.parse _namespace_name "sex-M" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-F"></see>
    /// </summary>
    let ``sex-F`` = Namespaced_IRI.parse _namespace_name "sex-F" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-N"></see>
    /// </summary>
    let ``sex-N`` = Namespaced_IRI.parse _namespace_name "sex-N" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-T"></see>
    /// </summary>
    let ``sex-T`` = Namespaced_IRI.parse _namespace_name "sex-T" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-708"></see>
    /// </summary>
    let ``timeFormat-708`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-708" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-604"></see>
    /// </summary>
    let ``timeFormat-604`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-604" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-710"></see>
    /// </summary>
    let ``timeFormat-710`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-710" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-102"></see>
    /// </summary>
    let ``timeFormat-102`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-102" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P3M"></see>
    /// </summary>
    let ``timeFormat-P3M`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-P3M" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-719"></see>
    /// </summary>
    let ``timeFormat-719`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-719" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-PT1M"></see>
    /// </summary>
    let ``timeFormat-PT1M`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-PT1M" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P6M"></see>
    /// </summary>
    let ``timeFormat-P6M`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-P6M" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-610"></see>
    /// </summary>
    let ``timeFormat-610`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-610" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-608"></see>
    /// </summary>
    let ``timeFormat-608`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-608" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-602"></see>
    /// </summary>
    let ``timeFormat-602`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-602" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1D"></see>
    /// </summary>
    let ``timeFormat-P1D`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-P1D" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-716"></see>
    /// </summary>
    let ``timeFormat-716`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-716" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1Y"></see>
    /// </summary>
    let ``timeFormat-P1Y`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-P1Y" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1M"></see>
    /// </summary>
    let ``timeFormat-P1M`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-P1M" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-616"></see>
    /// </summary>
    let ``timeFormat-616`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-616" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-203"></see>
    /// </summary>
    let ``timeFormat-203`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-203" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-704"></see>
    /// </summary>
    let ``timeFormat-704`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-704" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P7D"></see>
    /// </summary>
    let ``timeFormat-P7D`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-P7D" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-711"></see>
    /// </summary>
    let ``timeFormat-711`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-711" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-702"></see>
    /// </summary>
    let ``timeFormat-702`` =
        Namespaced_IRI.parse _namespace_name "timeFormat-702" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-2"></see>
    /// </summary>
    let ``unitMult-2`` =
        Namespaced_IRI.parse _namespace_name "unitMult-2" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-6"></see>
    /// </summary>
    let ``unitMult-6`` =
        Namespaced_IRI.parse _namespace_name "unitMult-6" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-3"></see>
    /// </summary>
    let ``unitMult-3`` =
        Namespaced_IRI.parse _namespace_name "unitMult-3" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-12"></see>
    /// </summary>
    let ``unitMult-12`` =
        Namespaced_IRI.parse _namespace_name "unitMult-12" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-4"></see>
    /// </summary>
    let ``unitMult-4`` =
        Namespaced_IRI.parse _namespace_name "unitMult-4" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-0"></see>
    /// </summary>
    let ``unitMult-0`` =
        Namespaced_IRI.parse _namespace_name "unitMult-0" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-1"></see>
    /// </summary>
    let ``unitMult-1`` =
        Namespaced_IRI.parse _namespace_name "unitMult-1" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-9"></see>
    /// </summary>
    let ``unitMult-9`` =
        Namespaced_IRI.parse _namespace_name "unitMult-9" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-15"></see>
    /// </summary>
    let ``unitMult-15`` =
        Namespaced_IRI.parse _namespace_name "unitMult-15" |> NamespacedName
