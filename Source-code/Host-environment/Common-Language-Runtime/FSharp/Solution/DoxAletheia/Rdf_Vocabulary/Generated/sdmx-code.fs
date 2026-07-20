namespace http.purl.org.linked_data.sdmx._2009.code.hash

open DoxAletheia

module sdmx_code =
    let _namespace_name = "http://purl.org/linked-data/sdmx/2009/code#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// : This code list provides code values for geographical areas, defined as areas included within the borders of a country, region, group of countries, etc.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#area"></see>
    /// </summary>
    let area = _prefix "area"
    /// <summary>
    /// this code list provides coded information about the sensitivity and confidentiality status of the data.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#ConfStatus"></see></summary>
    let ConfStatus = _prefix "ConfStatus"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus"></see>
    /// </summary>
    let confStatus = _prefix "confStatus"
    /// <summary>
    /// This code list provides code values for currencies.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Currency"></see></summary>
    let Currency = _prefix "Currency"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#currency"></see>
    /// </summary>
    let currency = _prefix "currency"
    /// <summary>
    /// It provides a list of values showing the number of decimal digits used in the data.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Decimals"></see></summary>
    let Decimals = _prefix "Decimals"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals"></see>
    /// </summary>
    let decimals = _prefix "decimals"
    /// <summary>
    /// It provides a list of values indicating the "frequency" of the data (e.g. monthly) and, thus, indirectly, also implying the type of "time reference" that could be used for identifying the data with respect time.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Freq"></see></summary>
    let Freq = _prefix "Freq"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq"></see>
    /// </summary>
    let freq = _prefix "freq"
    /// <summary>
    /// This code list provides coded information about the "status" of an observation (with respect events such as the ones reflected in the codes composing the code list).
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#ObsStatus"></see></summary>
    let ObsStatus = _prefix "ObsStatus"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus"></see>
    /// </summary>
    let obsStatus = _prefix "obsStatus"
    /// <summary>
    /// This  code list provides the gender.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#Sex"></see></summary>
    let Sex = _prefix "Sex"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex"></see>
    /// </summary>
    let sex = _prefix "sex"
    /// <summary>
    /// These codes (based on the ISO 8601 standard) indicate the type of time references used in the data. The numeric codes below (203, 102,...,702) are used only in the SDMX-EDI messages; and the alphanumeric codes (P1D...PT1M) only in the SDMX-ML messages.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#TimeFormat"></see></summary>
    let TimeFormat = _prefix "TimeFormat"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat"></see>
    /// </summary>
    let timeFormat = _prefix "timeFormat"
    /// <summary>
    /// it provides code values for indicating the magnitude in the units of measurements.
    /// <see href="http://purl.org/linked-data/sdmx/2009/code#UnitMult"></see></summary>
    let UnitMult = _prefix "UnitMult"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult"></see>
    /// </summary>
    let unitMult = _prefix "unitMult"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-F"></see>
    /// </summary>
    let ``confStatus-F`` = _prefix "confStatus-F"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-S"></see>
    /// </summary>
    let ``confStatus-S`` = _prefix "confStatus-S"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-D"></see>
    /// </summary>
    let ``confStatus-D`` = _prefix "confStatus-D"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-N"></see>
    /// </summary>
    let ``confStatus-N`` = _prefix "confStatus-N"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#confStatus-C"></see>
    /// </summary>
    let ``confStatus-C`` = _prefix "confStatus-C"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-5"></see>
    /// </summary>
    let ``decimals-5`` = _prefix "decimals-5"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-3"></see>
    /// </summary>
    let ``decimals-3`` = _prefix "decimals-3"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-8"></see>
    /// </summary>
    let ``decimals-8`` = _prefix "decimals-8"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-6"></see>
    /// </summary>
    let ``decimals-6`` = _prefix "decimals-6"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-1"></see>
    /// </summary>
    let ``decimals-1`` = _prefix "decimals-1"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-4"></see>
    /// </summary>
    let ``decimals-4`` = _prefix "decimals-4"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-2"></see>
    /// </summary>
    let ``decimals-2`` = _prefix "decimals-2"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-9"></see>
    /// </summary>
    let ``decimals-9`` = _prefix "decimals-9"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-0"></see>
    /// </summary>
    let ``decimals-0`` = _prefix "decimals-0"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#decimals-7"></see>
    /// </summary>
    let ``decimals-7`` = _prefix "decimals-7"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-D"></see>
    /// </summary>
    let ``freq-D`` = _prefix "freq-D"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-W"></see>
    /// </summary>
    let ``freq-W`` = _prefix "freq-W"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-M"></see>
    /// </summary>
    let ``freq-M`` = _prefix "freq-M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-Q"></see>
    /// </summary>
    let ``freq-Q`` = _prefix "freq-Q"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-B"></see>
    /// </summary>
    let ``freq-B`` = _prefix "freq-B"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-S"></see>
    /// </summary>
    let ``freq-S`` = _prefix "freq-S"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-N"></see>
    /// </summary>
    let ``freq-N`` = _prefix "freq-N"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#freq-A"></see>
    /// </summary>
    let ``freq-A`` = _prefix "freq-A"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-A"></see>
    /// </summary>
    let ``obsStatus-A`` = _prefix "obsStatus-A"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-M"></see>
    /// </summary>
    let ``obsStatus-M`` = _prefix "obsStatus-M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-F"></see>
    /// </summary>
    let ``obsStatus-F`` = _prefix "obsStatus-F"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-I"></see>
    /// </summary>
    let ``obsStatus-I`` = _prefix "obsStatus-I"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-B"></see>
    /// </summary>
    let ``obsStatus-B`` = _prefix "obsStatus-B"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-E"></see>
    /// </summary>
    let ``obsStatus-E`` = _prefix "obsStatus-E"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-P"></see>
    /// </summary>
    let ``obsStatus-P`` = _prefix "obsStatus-P"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-S"></see>
    /// </summary>
    let ``obsStatus-S`` = _prefix "obsStatus-S"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-U"></see>
    /// </summary>
    let ``sex-U`` = _prefix "sex-U"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-M"></see>
    /// </summary>
    let ``sex-M`` = _prefix "sex-M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-F"></see>
    /// </summary>
    let ``sex-F`` = _prefix "sex-F"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-N"></see>
    /// </summary>
    let ``sex-N`` = _prefix "sex-N"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#sex-T"></see>
    /// </summary>
    let ``sex-T`` = _prefix "sex-T"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-708"></see>
    /// </summary>
    let ``timeFormat-708`` = _prefix "timeFormat-708"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-604"></see>
    /// </summary>
    let ``timeFormat-604`` = _prefix "timeFormat-604"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-710"></see>
    /// </summary>
    let ``timeFormat-710`` = _prefix "timeFormat-710"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-102"></see>
    /// </summary>
    let ``timeFormat-102`` = _prefix "timeFormat-102"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P3M"></see>
    /// </summary>
    let ``timeFormat-P3M`` = _prefix "timeFormat-P3M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-719"></see>
    /// </summary>
    let ``timeFormat-719`` = _prefix "timeFormat-719"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-PT1M"></see>
    /// </summary>
    let ``timeFormat-PT1M`` = _prefix "timeFormat-PT1M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P6M"></see>
    /// </summary>
    let ``timeFormat-P6M`` = _prefix "timeFormat-P6M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-610"></see>
    /// </summary>
    let ``timeFormat-610`` = _prefix "timeFormat-610"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-608"></see>
    /// </summary>
    let ``timeFormat-608`` = _prefix "timeFormat-608"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-602"></see>
    /// </summary>
    let ``timeFormat-602`` = _prefix "timeFormat-602"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1D"></see>
    /// </summary>
    let ``timeFormat-P1D`` = _prefix "timeFormat-P1D"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-716"></see>
    /// </summary>
    let ``timeFormat-716`` = _prefix "timeFormat-716"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1Y"></see>
    /// </summary>
    let ``timeFormat-P1Y`` = _prefix "timeFormat-P1Y"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1M"></see>
    /// </summary>
    let ``timeFormat-P1M`` = _prefix "timeFormat-P1M"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-616"></see>
    /// </summary>
    let ``timeFormat-616`` = _prefix "timeFormat-616"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-203"></see>
    /// </summary>
    let ``timeFormat-203`` = _prefix "timeFormat-203"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-704"></see>
    /// </summary>
    let ``timeFormat-704`` = _prefix "timeFormat-704"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P7D"></see>
    /// </summary>
    let ``timeFormat-P7D`` = _prefix "timeFormat-P7D"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-711"></see>
    /// </summary>
    let ``timeFormat-711`` = _prefix "timeFormat-711"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-702"></see>
    /// </summary>
    let ``timeFormat-702`` = _prefix "timeFormat-702"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-2"></see>
    /// </summary>
    let ``unitMult-2`` = _prefix "unitMult-2"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-6"></see>
    /// </summary>
    let ``unitMult-6`` = _prefix "unitMult-6"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-3"></see>
    /// </summary>
    let ``unitMult-3`` = _prefix "unitMult-3"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-12"></see>
    /// </summary>
    let ``unitMult-12`` = _prefix "unitMult-12"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-4"></see>
    /// </summary>
    let ``unitMult-4`` = _prefix "unitMult-4"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-0"></see>
    /// </summary>
    let ``unitMult-0`` = _prefix "unitMult-0"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-1"></see>
    /// </summary>
    let ``unitMult-1`` = _prefix "unitMult-1"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-9"></see>
    /// </summary>
    let ``unitMult-9`` = _prefix "unitMult-9"
    /// <summary>
    ///   <see href="http://purl.org/linked-data/sdmx/2009/code#unitMult-15"></see>
    /// </summary>
    let ``unitMult-15`` = _prefix "unitMult-15"
