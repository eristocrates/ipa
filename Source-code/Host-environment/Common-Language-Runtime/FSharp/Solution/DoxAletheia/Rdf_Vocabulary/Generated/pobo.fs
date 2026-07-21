namespace http.purl.obolibrary.org.obo.slash

open DoxAletheia

module pobo =
    let _namespace_name = "http://purl.obolibrary.org/obo/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0010000"></see>
    /// </summary>
    let IAO_0010000 = _prefix "IAO_0010000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/093-002"></see>
    /// </summary>
    let ``bfo/axiom/093-002`` = _prefix "bfo/axiom/093-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000115"></see>
    /// </summary>
    let IAO_0000115 = _prefix "IAO_0000115"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000144"></see>
    /// </summary>
    let BFO_0000144 = _prefix "BFO_0000144"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/027-004"></see>
    /// </summary>
    let ``bfo/axiom/027-004`` = _prefix "bfo/axiom/027-004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000602"></see>
    /// </summary>
    let IAO_0000602 = _prefix "IAO_0000602"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000024"></see>
    /// </summary>
    let BFO_0000024 = _prefix "BFO_0000024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/062-002"></see>
    /// </summary>
    let ``bfo/axiom/062-002`` = _prefix "bfo/axiom/062-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000600"></see>
    /// </summary>
    let IAO_0000600 = _prefix "IAO_0000600"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000016"></see>
    /// </summary>
    let BFO_0000016 = _prefix "BFO_0000016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/102-001"></see>
    /// </summary>
    let ``bfo/axiom/102-001`` = _prefix "bfo/axiom/102-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000148"></see>
    /// </summary>
    let BFO_0000148 = _prefix "BFO_0000148"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000001"></see>
    /// </summary>
    let ``bfo/axiom/0000001`` = _prefix "bfo/axiom/0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000116"></see>
    /// </summary>
    let IAO_0000116 = _prefix "IAO_0000116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000147"></see>
    /// </summary>
    let BFO_0000147 = _prefix "BFO_0000147"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/009-002"></see>
    /// </summary>
    let ``bfo/axiom/009-002`` = _prefix "bfo/axiom/009-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000601"></see>
    /// </summary>
    let IAO_0000601 = _prefix "IAO_0000601"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000002"></see>
    /// </summary>
    let BFO_0000002 = _prefix "BFO_0000002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/017-002"></see>
    /// </summary>
    let ``bfo/axiom/017-002`` = _prefix "bfo/axiom/017-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000004"></see>
    /// </summary>
    let BFO_0000004 = _prefix "BFO_0000004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/063-002"></see>
    /// </summary>
    let ``bfo/axiom/063-002`` = _prefix "bfo/axiom/063-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000007"></see>
    /// </summary>
    let ``bfo/axiom/0000007`` = _prefix "bfo/axiom/0000007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/029-001"></see>
    /// </summary>
    let ``bfo/axiom/029-001`` = _prefix "bfo/axiom/029-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000140"></see>
    /// </summary>
    let BFO_0000140 = _prefix "BFO_0000140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/055-001"></see>
    /// </summary>
    let ``bfo/axiom/055-001`` = _prefix "bfo/axiom/055-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000019"></see>
    /// </summary>
    let BFO_0000019 = _prefix "BFO_0000019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/019-002"></see>
    /// </summary>
    let ``bfo/axiom/019-002`` = _prefix "bfo/axiom/019-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000040"></see>
    /// </summary>
    let BFO_0000040 = _prefix "BFO_0000040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/108-001"></see>
    /// </summary>
    let ``bfo/axiom/108-001`` = _prefix "bfo/axiom/108-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000003"></see>
    /// </summary>
    let BFO_0000003 = _prefix "BFO_0000003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/021-002"></see>
    /// </summary>
    let ``bfo/axiom/021-002`` = _prefix "bfo/axiom/021-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000226"></see>
    /// </summary>
    let IAO_0000226 = _prefix "IAO_0000226"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000227"></see>
    /// </summary>
    let IAO_0000227 = _prefix "IAO_0000227"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000228"></see>
    /// </summary>
    let IAO_0000228 = _prefix "IAO_0000228"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000229"></see>
    /// </summary>
    let IAO_0000229 = _prefix "IAO_0000229"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000142"></see>
    /// </summary>
    let BFO_0000142 = _prefix "BFO_0000142"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000146"></see>
    /// </summary>
    let BFO_0000146 = _prefix "BFO_0000146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/107-002"></see>
    /// </summary>
    let ``bfo/axiom/107-002`` = _prefix "bfo/axiom/107-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000011"></see>
    /// </summary>
    let BFO_0000011 = _prefix "BFO_0000011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/037-001"></see>
    /// </summary>
    let ``bfo/axiom/037-001`` = _prefix "bfo/axiom/037-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000018"></see>
    /// </summary>
    let BFO_0000018 = _prefix "BFO_0000018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/138-001"></see>
    /// </summary>
    let ``bfo/axiom/138-001`` = _prefix "bfo/axiom/138-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000182"></see>
    /// </summary>
    let BFO_0000182 = _prefix "BFO_0000182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000020"></see>
    /// </summary>
    let BFO_0000020 = _prefix "BFO_0000020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000031"></see>
    /// </summary>
    let BFO_0000031 = _prefix "BFO_0000031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000301"></see>
    /// </summary>
    let ``bfo/axiom/0000301`` = _prefix "bfo/axiom/0000301"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000027"></see>
    /// </summary>
    let BFO_0000027 = _prefix "BFO_0000027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/061-001"></see>
    /// </summary>
    let ``bfo/axiom/061-001`` = _prefix "bfo/axiom/061-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000023"></see>
    /// </summary>
    let BFO_0000023 = _prefix "BFO_0000023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/094-005"></see>
    /// </summary>
    let ``bfo/axiom/094-005`` = _prefix "bfo/axiom/094-005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/126-001"></see>
    /// </summary>
    let ``bfo/axiom/126-001`` = _prefix "bfo/axiom/126-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/074-001"></see>
    /// </summary>
    let ``bfo/axiom/074-001`` = _prefix "bfo/axiom/074-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/018-002"></see>
    /// </summary>
    let ``bfo/axiom/018-002`` = _prefix "bfo/axiom/018-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/058-002"></see>
    /// </summary>
    let ``bfo/axiom/058-002`` = _prefix "bfo/axiom/058-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000017"></see>
    /// </summary>
    let BFO_0000017 = _prefix "BFO_0000017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/101-001"></see>
    /// </summary>
    let ``bfo/axiom/101-001`` = _prefix "bfo/axiom/101-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000008"></see>
    /// </summary>
    let BFO_0000008 = _prefix "BFO_0000008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/105-001"></see>
    /// </summary>
    let ``bfo/axiom/105-001`` = _prefix "bfo/axiom/105-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/038-001"></see>
    /// </summary>
    let ``bfo/axiom/038-001`` = _prefix "bfo/axiom/038-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000026"></see>
    /// </summary>
    let BFO_0000026 = _prefix "BFO_0000026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/050-003"></see>
    /// </summary>
    let ``bfo/axiom/050-003`` = _prefix "bfo/axiom/050-003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/099-001"></see>
    /// </summary>
    let ``bfo/axiom/099-001`` = _prefix "bfo/axiom/099-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/035-001"></see>
    /// </summary>
    let ``bfo/axiom/035-001`` = _prefix "bfo/axiom/035-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000006"></see>
    /// </summary>
    let BFO_0000006 = _prefix "BFO_0000006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/103-001"></see>
    /// </summary>
    let ``bfo/axiom/103-001`` = _prefix "bfo/axiom/103-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000038"></see>
    /// </summary>
    let BFO_0000038 = _prefix "BFO_0000038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/083-003"></see>
    /// </summary>
    let ``bfo/axiom/083-003`` = _prefix "bfo/axiom/083-003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000015"></see>
    /// </summary>
    let BFO_0000015 = _prefix "BFO_0000015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000008"></see>
    /// </summary>
    let ``bfo/axiom/0000008`` = _prefix "bfo/axiom/0000008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/020-002"></see>
    /// </summary>
    let ``bfo/axiom/020-002`` = _prefix "bfo/axiom/020-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/060-002"></see>
    /// </summary>
    let ``bfo/axiom/060-002`` = _prefix "bfo/axiom/060-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/064-001"></see>
    /// </summary>
    let ``bfo/axiom/064-001`` = _prefix "bfo/axiom/064-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000034"></see>
    /// </summary>
    let BFO_0000034 = _prefix "BFO_0000034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/031-001"></see>
    /// </summary>
    let ``bfo/axiom/031-001`` = _prefix "bfo/axiom/031-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000009"></see>
    /// </summary>
    let BFO_0000009 = _prefix "BFO_0000009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000028"></see>
    /// </summary>
    let BFO_0000028 = _prefix "BFO_0000028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/040-001"></see>
    /// </summary>
    let ``bfo/axiom/040-001`` = _prefix "bfo/axiom/040-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000005"></see>
    /// </summary>
    let ``bfo/axiom/0000005`` = _prefix "bfo/axiom/0000005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100061"></see>
    /// </summary>
    let OBI_0100061 = _prefix "OBI_0100061"
    /// <summary>
    /// An active cell culture is typically split when it has grown to confluence in its culture dish.  Cell culture splitting of a cell culture sample results in an increase in its passage number, which measures how long a sample has been propagated in vitro, and therefore how many selective or genetic changes it is likely to have undergone.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0600037"></see></summary>
    let OBI_0600037 = _prefix "OBI_0600037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000312"></see>
    /// </summary>
    let OBI_0000312 = _prefix "OBI_0000312"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CLO_0000001"></see>
    /// </summary>
    let CLO_0000001 = _prefix "CLO_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000001"></see>
    /// </summary>
    let CL_0000001 = _prefix "CL_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001000"></see>
    /// </summary>
    let RO_0001000 = _prefix "RO_0001000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000006"></see>
    /// </summary>
    let ``bfo/axiom/0000006`` = _prefix "bfo/axiom/0000006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/008-002"></see>
    /// </summary>
    let ``bfo/axiom/008-002`` = _prefix "bfo/axiom/008-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/033-001"></see>
    /// </summary>
    let ``bfo/axiom/033-001`` = _prefix "bfo/axiom/033-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/032-001"></see>
    /// </summary>
    let ``bfo/axiom/032-001`` = _prefix "bfo/axiom/032-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/100-001"></see>
    /// </summary>
    let ``bfo/axiom/100-001`` = _prefix "bfo/axiom/100-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/077-002"></see>
    /// </summary>
    let ``bfo/axiom/077-002`` = _prefix "bfo/axiom/077-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000412"></see>
    /// </summary>
    let IAO_0000412 = _prefix "IAO_0000412"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/uberon.owl"></see>
    /// </summary>
    let ``uberon.owl`` = _prefix "uberon.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/024-001"></see>
    /// </summary>
    let ``bfo/axiom/024-001`` = _prefix "bfo/axiom/024-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000030"></see>
    /// </summary>
    let BFO_0000030 = _prefix "BFO_0000030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/001-001"></see>
    /// </summary>
    let ``bfo/axiom/001-001`` = _prefix "bfo/axiom/001-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000001"></see>
    /// </summary>
    let BFO_0000001 = _prefix "BFO_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/034-002"></see>
    /// </summary>
    let ``bfo/axiom/034-002`` = _prefix "bfo/axiom/034-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000029"></see>
    /// </summary>
    let BFO_0000029 = _prefix "BFO_0000029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000120"></see>
    /// </summary>
    let IAO_0000120 = _prefix "IAO_0000120"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000121"></see>
    /// </summary>
    let IAO_0000121 = _prefix "IAO_0000121"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000122"></see>
    /// </summary>
    let IAO_0000122 = _prefix "IAO_0000122"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000123"></see>
    /// </summary>
    let IAO_0000123 = _prefix "IAO_0000123"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000124"></see>
    /// </summary>
    let IAO_0000124 = _prefix "IAO_0000124"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000125"></see>
    /// </summary>
    let IAO_0000125 = _prefix "IAO_0000125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000423"></see>
    /// </summary>
    let IAO_0000423 = _prefix "IAO_0000423"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000428"></see>
    /// </summary>
    let IAO_0000428 = _prefix "IAO_0000428"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/084-001"></see>
    /// </summary>
    let ``bfo/axiom/084-001`` = _prefix "bfo/axiom/084-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000035"></see>
    /// </summary>
    let BFO_0000035 = _prefix "BFO_0000035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/096-001"></see>
    /// </summary>
    let ``bfo/axiom/096-001`` = _prefix "bfo/axiom/096-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/039-001"></see>
    /// </summary>
    let ``bfo/axiom/039-001`` = _prefix "bfo/axiom/039-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/057-001"></see>
    /// </summary>
    let ``bfo/axiom/057-001`` = _prefix "bfo/axiom/057-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000145"></see>
    /// </summary>
    let BFO_0000145 = _prefix "BFO_0000145"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/134-001"></see>
    /// </summary>
    let ``bfo/axiom/134-001`` = _prefix "bfo/axiom/134-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/036-001"></see>
    /// </summary>
    let ``bfo/axiom/036-001`` = _prefix "bfo/axiom/036-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/085-002"></see>
    /// </summary>
    let ``bfo/axiom/085-002`` = _prefix "bfo/axiom/085-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000002"></see>
    /// </summary>
    let ``bfo/axiom/0000002`` = _prefix "bfo/axiom/0000002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/080-003"></see>
    /// </summary>
    let ``bfo/axiom/080-003`` = _prefix "bfo/axiom/080-003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000134"></see>
    /// </summary>
    let BFO_0000134 = _prefix "BFO_0000134"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/011-002"></see>
    /// </summary>
    let ``bfo/axiom/011-002`` = _prefix "bfo/axiom/011-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/079-001"></see>
    /// </summary>
    let ``bfo/axiom/079-001`` = _prefix "bfo/axiom/079-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/131-004"></see>
    /// </summary>
    let ``bfo/axiom/131-004`` = _prefix "bfo/axiom/131-004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000300"></see>
    /// </summary>
    let ``bfo/axiom/0000300`` = _prefix "bfo/axiom/0000300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000119"></see>
    /// </summary>
    let IAO_0000119 = _prefix "IAO_0000119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/098-001"></see>
    /// </summary>
    let ``bfo/axiom/098-001`` = _prefix "bfo/axiom/098-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/081-003"></see>
    /// </summary>
    let ``bfo/axiom/081-003`` = _prefix "bfo/axiom/081-003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/119-002"></see>
    /// </summary>
    let ``bfo/axiom/119-002`` = _prefix "bfo/axiom/119-002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/025-004"></see>
    /// </summary>
    let ``bfo/axiom/025-004`` = _prefix "bfo/axiom/025-004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000003"></see>
    /// </summary>
    let ``bfo/axiom/0000003`` = _prefix "bfo/axiom/0000003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000011"></see>
    /// </summary>
    let ``bfo/axiom/0000011`` = _prefix "bfo/axiom/0000011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/095-001"></see>
    /// </summary>
    let ``bfo/axiom/095-001`` = _prefix "bfo/axiom/095-001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000012"></see>
    /// </summary>
    let ``bfo/axiom/0000012`` = _prefix "bfo/axiom/0000012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo/axiom/0000004"></see>
    /// </summary>
    let ``bfo/axiom/0000004`` = _prefix "bfo/axiom/0000004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000179"></see>
    /// </summary>
    let BFO_0000179 = _prefix "BFO_0000179"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000180"></see>
    /// </summary>
    let BFO_0000180 = _prefix "BFO_0000180"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000112"></see>
    /// </summary>
    let IAO_0000112 = _prefix "IAO_0000112"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/bfo.owl"></see>
    /// </summary>
    let ``bfo.owl`` = _prefix "bfo.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000005"></see>
    /// </summary>
    let BFO_0000005 = _prefix "BFO_0000005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000141"></see>
    /// </summary>
    let BFO_0000141 = _prefix "BFO_0000141"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000050"></see>
    /// </summary>
    let BFO_0000050 = _prefix "BFO_0000050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000111"></see>
    /// </summary>
    let IAO_0000111 = _prefix "IAO_0000111"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000118"></see>
    /// </summary>
    let IAO_0000118 = _prefix "IAO_0000118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001900"></see>
    /// </summary>
    let RO_0001900 = _prefix "RO_0001900"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001901"></see>
    /// </summary>
    let RO_0001901 = _prefix "RO_0001901"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000051"></see>
    /// </summary>
    let BFO_0000051 = _prefix "BFO_0000051"
    /// <summary>
    /// Paraphrase of elucidation: a relation between a realizable entity and a process, where there is some material entity that is bearer of the realizable entity and participates in the process, and the realizable entity comes to be realized in the course of the process
    /// <see href="http://purl.obolibrary.org/obo/BFO_0000054"></see></summary>
    let BFO_0000054 = _prefix "BFO_0000054"
    /// <summary>
    /// Paraphrase of elucidation: a relation between a process and a realizable entity, where there is some material entity that is bearer of the realizable entity and participates in the process, and the realizable entity comes to be realized in the course of the process
    /// <see href="http://purl.obolibrary.org/obo/BFO_0000055"></see></summary>
    let BFO_0000055 = _prefix "BFO_0000055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/iao.owl"></see>
    /// </summary>
    let ``iao.owl`` = _prefix "iao.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000062"></see>
    /// </summary>
    let BFO_0000062 = _prefix "BFO_0000062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/BFO_0000063"></see>
    /// </summary>
    let BFO_0000063 = _prefix "BFO_0000063"
    /// <summary>
    /// A relation that holds between two occurrents. This is a grouping relation that collects together all the Allen relations.
    /// <see href="http://purl.obolibrary.org/obo/RO_0002222"></see></summary>
    let RO_0002222 = _prefix "RO_0002222"
    /// <summary>
    /// Paraphrase of definition: a relation between a process and an independent continuant, in which the process takes place entirely within the independent continuant
    /// <see href="http://purl.obolibrary.org/obo/BFO_0000066"></see></summary>
    let BFO_0000066 = _prefix "BFO_0000066"
    /// <summary>
    /// Paraphrase of definition: a relation between an independent continuant and a process, in which the process takes place entirely within the independent continuant
    /// <see href="http://purl.obolibrary.org/obo/BFO_0000067"></see></summary>
    let BFO_0000067 = _prefix "BFO_0000067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000232"></see>
    /// </summary>
    let IAO_0000232 = _prefix "IAO_0000232"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_15377"></see>
    /// </summary>
    let CHEBI_15377 = _prefix "CHEBI_15377"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/chebi.owl"></see>
    /// </summary>
    let ``chebi.owl`` = _prefix "chebi.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_23367"></see>
    /// </summary>
    let CHEBI_23367 = _prefix "CHEBI_23367"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_15422"></see>
    /// </summary>
    let CHEBI_15422 = _prefix "CHEBI_15422"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_15956"></see>
    /// </summary>
    let CHEBI_15956 = _prefix "CHEBI_15956"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/REO_0000171"></see>
    /// </summary>
    let REO_0000171 = _prefix "REO_0000171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000087"></see>
    /// </summary>
    let RO_0000087 = _prefix "RO_0000087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/REO_0000280"></see>
    /// </summary>
    let REO_0000280 = _prefix "REO_0000280"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_16670"></see>
    /// </summary>
    let CHEBI_16670 = _prefix "CHEBI_16670"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33839"></see>
    /// </summary>
    let CHEBI_33839 = _prefix "CHEBI_33839"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_16991"></see>
    /// </summary>
    let CHEBI_16991 = _prefix "CHEBI_16991"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33696"></see>
    /// </summary>
    let CHEBI_33696 = _prefix "CHEBI_33696"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_17137"></see>
    /// </summary>
    let CHEBI_17137 = _prefix "CHEBI_17137"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_17234"></see>
    /// </summary>
    let CHEBI_17234 = _prefix "CHEBI_17234"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_17709"></see>
    /// </summary>
    let CHEBI_17709 = _prefix "CHEBI_17709"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_23528"></see>
    /// </summary>
    let CHEBI_23528 = _prefix "CHEBI_23528"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_23995"></see>
    /// </summary>
    let CHEBI_23995 = _prefix "CHEBI_23995"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_24636"></see>
    /// </summary>
    let CHEBI_24636 = _prefix "CHEBI_24636"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_25078"></see>
    /// </summary>
    let CHEBI_25078 = _prefix "CHEBI_25078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_26710"></see>
    /// </summary>
    let CHEBI_26710 = _prefix "CHEBI_26710"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_27889"></see>
    /// </summary>
    let CHEBI_27889 = _prefix "CHEBI_27889"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_28619"></see>
    /// </summary>
    let CHEBI_28619 = _prefix "CHEBI_28619"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_29191"></see>
    /// </summary>
    let CHEBI_29191 = _prefix "CHEBI_29191"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_29237"></see>
    /// </summary>
    let CHEBI_29237 = _prefix "CHEBI_29237"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33250"></see>
    /// </summary>
    let CHEBI_33250 = _prefix "CHEBI_33250"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_30682"></see>
    /// </summary>
    let CHEBI_30682 = _prefix "CHEBI_30682"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_31624"></see>
    /// </summary>
    let CHEBI_31624 = _prefix "CHEBI_31624"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_31642"></see>
    /// </summary>
    let CHEBI_31642 = _prefix "CHEBI_31642"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_31643"></see>
    /// </summary>
    let CHEBI_31643 = _prefix "CHEBI_31643"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_31991"></see>
    /// </summary>
    let CHEBI_31991 = _prefix "CHEBI_31991"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_32142"></see>
    /// </summary>
    let CHEBI_32142 = _prefix "CHEBI_32142"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33321"></see>
    /// </summary>
    let CHEBI_33321 = _prefix "CHEBI_33321"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33359"></see>
    /// </summary>
    let CHEBI_33359 = _prefix "CHEBI_33359"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33375"></see>
    /// </summary>
    let CHEBI_33375 = _prefix "CHEBI_33375"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33376"></see>
    /// </summary>
    let CHEBI_33376 = _prefix "CHEBI_33376"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33697"></see>
    /// </summary>
    let CHEBI_33697 = _prefix "CHEBI_33697"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_33709"></see>
    /// </summary>
    let CHEBI_33709 = _prefix "CHEBI_33709"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_35729"></see>
    /// </summary>
    let CHEBI_35729 = _prefix "CHEBI_35729"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_37333"></see>
    /// </summary>
    let CHEBI_37333 = _prefix "CHEBI_37333"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_37586"></see>
    /// </summary>
    let CHEBI_37586 = _prefix "CHEBI_37586"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_37972"></see>
    /// </summary>
    let CHEBI_37972 = _prefix "CHEBI_37972"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_37973"></see>
    /// </summary>
    let CHEBI_37973 = _prefix "CHEBI_37973"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_37987"></see>
    /// </summary>
    let CHEBI_37987 = _prefix "CHEBI_37987"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_37989"></see>
    /// </summary>
    let CHEBI_37989 = _prefix "CHEBI_37989"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_42098"></see>
    /// </summary>
    let CHEBI_42098 = _prefix "CHEBI_42098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_42191"></see>
    /// </summary>
    let CHEBI_42191 = _prefix "CHEBI_42191"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_4705"></see>
    /// </summary>
    let CHEBI_4705 = _prefix "CHEBI_4705"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_472552"></see>
    /// </summary>
    let CHEBI_472552 = _prefix "CHEBI_472552"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_50076"></see>
    /// </summary>
    let CHEBI_50076 = _prefix "CHEBI_50076"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_51756"></see>
    /// </summary>
    let CHEBI_51756 = _prefix "CHEBI_51756"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_51760"></see>
    /// </summary>
    let CHEBI_51760 = _prefix "CHEBI_51760"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_52673"></see>
    /// </summary>
    let CHEBI_52673 = _prefix "CHEBI_52673"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_53526"></see>
    /// </summary>
    let CHEBI_53526 = _prefix "CHEBI_53526"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59050"></see>
    /// </summary>
    let CHEBI_59050 = _prefix "CHEBI_59050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59051"></see>
    /// </summary>
    let CHEBI_59051 = _prefix "CHEBI_59051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59052"></see>
    /// </summary>
    let CHEBI_59052 = _prefix "CHEBI_59052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59053"></see>
    /// </summary>
    let CHEBI_59053 = _prefix "CHEBI_59053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59054"></see>
    /// </summary>
    let CHEBI_59054 = _prefix "CHEBI_59054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59055"></see>
    /// </summary>
    let CHEBI_59055 = _prefix "CHEBI_59055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59056"></see>
    /// </summary>
    let CHEBI_59056 = _prefix "CHEBI_59056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_59424"></see>
    /// </summary>
    let CHEBI_59424 = _prefix "CHEBI_59424"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_61073"></see>
    /// </summary>
    let CHEBI_61073 = _prefix "CHEBI_61073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHEBI_9754"></see>
    /// </summary>
    let CHEBI_9754 = _prefix "CHEBI_9754"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHMO_0000087"></see>
    /// </summary>
    let CHMO_0000087 = _prefix "CHMO_0000087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002119"></see>
    /// </summary>
    let OBI_0002119 = _prefix "OBI_0002119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHMO_0000089"></see>
    /// </summary>
    let CHMO_0000089 = _prefix "CHMO_0000089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHMO_0000102"></see>
    /// </summary>
    let CHMO_0000102 = _prefix "CHMO_0000102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CHMO_0000701"></see>
    /// </summary>
    let CHMO_0000701 = _prefix "CHMO_0000701"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200198"></see>
    /// </summary>
    let OBI_0200198 = _prefix "OBI_0200198"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/clo.owl"></see>
    /// </summary>
    let ``clo.owl`` = _prefix "clo.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001867"></see>
    /// </summary>
    let OBI_0001867 = _prefix "OBI_0001867"
    /// <summary>
    /// A secondary cultured cell has been passaged in culture or is a descendant of such a cell that is derived through propagation in culture.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001866"></see></summary>
    let OBI_0001866 = _prefix "OBI_0001866"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CLO_0000018"></see>
    /// </summary>
    let CLO_0000018 = _prefix "CLO_0000018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CLO_0000019"></see>
    /// </summary>
    let CLO_0000019 = _prefix "CLO_0000019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CLO_0000031"></see>
    /// </summary>
    let CLO_0000031 = _prefix "CLO_0000031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000643"></see>
    /// </summary>
    let OBI_0000643 = _prefix "OBI_0000643"
    /// <summary>
    /// The concept of a 'secondary cultured cell population' covers cell lines as well as cultured cell populations more immediately derived from a primary culture which have yet to achieve adequate genetic stability and compositional homogeneity to be considered a cell line. The extent of the collection of cells in a 'secondary cultured cell population' is restricted only in that all cell members must share a propagation history (ie be derived through a common lineage of passages from an initial culture).  Secondary cultured cell populations can be under active culture, stored in a quiescent state for future use, or applied experimentally.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001905"></see></summary>
    let OBI_0001905 = _prefix "OBI_0001905"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CLO_0009828"></see>
    /// </summary>
    let CLO_0009828 = _prefix "CLO_0009828"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CLO_0009829"></see>
    /// </summary>
    let CLO_0009829 = _prefix "CLO_0009829"
    /// <summary>
    /// A immortalizing genetic transformation of an existing population of cell line cells is required as part of this process, as are additional steps for  selecting and propagating the cells output form this process into a cell line.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000877"></see></summary>
    let OBI_0000877 = _prefix "OBI_0000877"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000000"></see>
    /// </summary>
    let CL_0000000 = _prefix "CL_0000000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/cl.owl"></see>
    /// </summary>
    let ``cl.owl`` = _prefix "cl.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000010"></see>
    /// </summary>
    let CL_0000010 = _prefix "CL_0000010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000003"></see>
    /// </summary>
    let CL_0000003 = _prefix "CL_0000003"
    /// <summary>
    /// A 'cell culture' as used here referes to a new lineage of cells in culture deriving from a single biological source.. New cultures are established through the initial isolation and culturing of cells from an organismal source, or through changes in an existing cell culture or line that result in a new culture with unique characteristics.  This can occur through the passaging/selection of a primary culture into a secondary culture or line, or experimental modifications of an existing cell culture or line such as an immortalization process or other stable genetic modification. This class covers establishment of cultures of either multicellular organism cells or unicellular organisms.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0600036"></see></summary>
    let OBI_0600036 = _prefix "OBI_0600036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000578"></see>
    /// </summary>
    let CL_0000578 = _prefix "CL_0000578"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000057"></see>
    /// </summary>
    let CL_0000057 = _prefix "CL_0000057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000066"></see>
    /// </summary>
    let CL_0000066 = _prefix "CL_0000066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000084"></see>
    /// </summary>
    let CL_0000084 = _prefix "CL_0000084"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000542"></see>
    /// </summary>
    let CL_0000542 = _prefix "CL_0000542"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000097"></see>
    /// </summary>
    let CL_0000097 = _prefix "CL_0000097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000182"></see>
    /// </summary>
    let CL_0000182 = _prefix "CL_0000182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000232"></see>
    /// </summary>
    let CL_0000232 = _prefix "CL_0000232"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000235"></see>
    /// </summary>
    let CL_0000235 = _prefix "CL_0000235"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000236"></see>
    /// </summary>
    let CL_0000236 = _prefix "CL_0000236"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000451"></see>
    /// </summary>
    let CL_0000451 = _prefix "CL_0000451"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000842"></see>
    /// </summary>
    let CL_0000842 = _prefix "CL_0000842"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000094"></see>
    /// </summary>
    let OBI_0000094 = _prefix "OBI_0000094"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000047"></see>
    /// </summary>
    let OBI_0000047 = _prefix "OBI_0000047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000624"></see>
    /// </summary>
    let CL_0000624 = _prefix "CL_0000624"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000789"></see>
    /// </summary>
    let CL_0000789 = _prefix "CL_0000789"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000625"></see>
    /// </summary>
    let CL_0000625 = _prefix "CL_0000625"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000767"></see>
    /// </summary>
    let CL_0000767 = _prefix "CL_0000767"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000786"></see>
    /// </summary>
    let CL_0000786 = _prefix "CL_0000786"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000794"></see>
    /// </summary>
    let CL_0000794 = _prefix "CL_0000794"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000814"></see>
    /// </summary>
    let CL_0000814 = _prefix "CL_0000814"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ENVO_00001998"></see>
    /// </summary>
    let ENVO_00001998 = _prefix "ENVO_00001998"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/envo.owl"></see>
    /// </summary>
    let ``envo.owl`` = _prefix "envo.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ENVO_00010483"></see>
    /// </summary>
    let ENVO_00010483 = _prefix "ENVO_00010483"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ENVO_00002257"></see>
    /// </summary>
    let ENVO_00002257 = _prefix "ENVO_00002257"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GAZ_00000448"></see>
    /// </summary>
    let GAZ_00000448 = _prefix "GAZ_00000448"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/gaz.owl"></see>
    /// </summary>
    let ``gaz.owl`` = _prefix "gaz.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0000785"></see>
    /// </summary>
    let GO_0000785 = _prefix "GO_0000785"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/go.owl"></see>
    /// </summary>
    let ``go.owl`` = _prefix "go.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0005575"></see>
    /// </summary>
    let GO_0005575 = _prefix "GO_0005575"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001047"></see>
    /// </summary>
    let GO_0001047 = _prefix "GO_0001047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001588"></see>
    /// </summary>
    let OBI_0001588 = _prefix "OBI_0001588"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001508"></see>
    /// </summary>
    let GO_0001508 = _prefix "GO_0001508"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0008150"></see>
    /// </summary>
    let GO_0008150 = _prefix "GO_0008150"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001788"></see>
    /// </summary>
    let GO_0001788 = _prefix "GO_0001788"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001806"></see>
    /// </summary>
    let GO_0001806 = _prefix "GO_0001806"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002524"></see>
    /// </summary>
    let GO_0002524 = _prefix "GO_0002524"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001816"></see>
    /// </summary>
    let GO_0001816 = _prefix "GO_0001816"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001906"></see>
    /// </summary>
    let GO_0001906 = _prefix "GO_0001906"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0001913"></see>
    /// </summary>
    let GO_0001913 = _prefix "GO_0001913"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002250"></see>
    /// </summary>
    let GO_0002250 = _prefix "GO_0002250"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006955"></see>
    /// </summary>
    let GO_0006955 = _prefix "GO_0006955"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002367"></see>
    /// </summary>
    let GO_0002367 = _prefix "GO_0002367"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002390"></see>
    /// </summary>
    let GO_0002390 = _prefix "GO_0002390"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002507"></see>
    /// </summary>
    let GO_0002507 = _prefix "GO_0002507"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002514"></see>
    /// </summary>
    let GO_0002514 = _prefix "GO_0002514"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002517"></see>
    /// </summary>
    let GO_0002517 = _prefix "GO_0002517"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0002534"></see>
    /// </summary>
    let GO_0002534 = _prefix "GO_0002534"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0003674"></see>
    /// </summary>
    let GO_0003674 = _prefix "GO_0003674"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0003823"></see>
    /// </summary>
    let GO_0003823 = _prefix "GO_0003823"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0003824"></see>
    /// </summary>
    let GO_0003824 = _prefix "GO_0003824"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0003964"></see>
    /// </summary>
    let GO_0003964 = _prefix "GO_0003964"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0005216"></see>
    /// </summary>
    let GO_0005216 = _prefix "GO_0005216"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0009987"></see>
    /// </summary>
    let GO_0009987 = _prefix "GO_0009987"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0005694"></see>
    /// </summary>
    let GO_0005694 = _prefix "GO_0005694"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0005739"></see>
    /// </summary>
    let GO_0005739 = _prefix "GO_0005739"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0043227"></see>
    /// </summary>
    let GO_0043227 = _prefix "GO_0043227"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006006"></see>
    /// </summary>
    let GO_0006006 = _prefix "GO_0006006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006260"></see>
    /// </summary>
    let GO_0006260 = _prefix "GO_0006260"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006306"></see>
    /// </summary>
    let GO_0006306 = _prefix "GO_0006306"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006338"></see>
    /// </summary>
    let GO_0006338 = _prefix "GO_0006338"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006909"></see>
    /// </summary>
    let GO_0006909 = _prefix "GO_0006909"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0050896"></see>
    /// </summary>
    let GO_0050896 = _prefix "GO_0050896"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0006974"></see>
    /// </summary>
    let GO_0006974 = _prefix "GO_0006974"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0007049"></see>
    /// </summary>
    let GO_0007049 = _prefix "GO_0007049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0007596"></see>
    /// </summary>
    let GO_0007596 = _prefix "GO_0007596"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000011"></see>
    /// </summary>
    let OBI_0000011 = _prefix "OBI_0000011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0008228"></see>
    /// </summary>
    let GO_0008228 = _prefix "GO_0008228"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0008283"></see>
    /// </summary>
    let GO_0008283 = _prefix "GO_0008283"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0009566"></see>
    /// </summary>
    let GO_0009566 = _prefix "GO_0009566"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0010467"></see>
    /// </summary>
    let GO_0010467 = _prefix "GO_0010467"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0010573"></see>
    /// </summary>
    let GO_0010573 = _prefix "GO_0010573"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0016064"></see>
    /// </summary>
    let GO_0016064 = _prefix "GO_0016064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0016570"></see>
    /// </summary>
    let GO_0016570 = _prefix "GO_0016570"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0019814"></see>
    /// </summary>
    let GO_0019814 = _prefix "GO_0019814"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0043234"></see>
    /// </summary>
    let GO_0043234 = _prefix "GO_0043234"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0019815"></see>
    /// </summary>
    let GO_0019815 = _prefix "GO_0019815"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110022"></see>
    /// </summary>
    let OBI_1110022 = _prefix "OBI_1110022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0019882"></see>
    /// </summary>
    let GO_0019882 = _prefix "GO_0019882"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0019904"></see>
    /// </summary>
    let GO_0019904 = _prefix "GO_0019904"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0030041"></see>
    /// </summary>
    let GO_0030041 = _prefix "GO_0030041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0030097"></see>
    /// </summary>
    let GO_0030097 = _prefix "GO_0030097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032601"></see>
    /// </summary>
    let GO_0032601 = _prefix "GO_0032601"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032602"></see>
    /// </summary>
    let GO_0032602 = _prefix "GO_0032602"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032604"></see>
    /// </summary>
    let GO_0032604 = _prefix "GO_0032604"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032605"></see>
    /// </summary>
    let GO_0032605 = _prefix "GO_0032605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032606"></see>
    /// </summary>
    let GO_0032606 = _prefix "GO_0032606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032607"></see>
    /// </summary>
    let GO_0032607 = _prefix "GO_0032607"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032608"></see>
    /// </summary>
    let GO_0032608 = _prefix "GO_0032608"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032609"></see>
    /// </summary>
    let GO_0032609 = _prefix "GO_0032609"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032610"></see>
    /// </summary>
    let GO_0032610 = _prefix "GO_0032610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032612"></see>
    /// </summary>
    let GO_0032612 = _prefix "GO_0032612"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032611"></see>
    /// </summary>
    let GO_0032611 = _prefix "GO_0032611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032613"></see>
    /// </summary>
    let GO_0032613 = _prefix "GO_0032613"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032614"></see>
    /// </summary>
    let GO_0032614 = _prefix "GO_0032614"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032615"></see>
    /// </summary>
    let GO_0032615 = _prefix "GO_0032615"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032616"></see>
    /// </summary>
    let GO_0032616 = _prefix "GO_0032616"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032617"></see>
    /// </summary>
    let GO_0032617 = _prefix "GO_0032617"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032618"></see>
    /// </summary>
    let GO_0032618 = _prefix "GO_0032618"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032619"></see>
    /// </summary>
    let GO_0032619 = _prefix "GO_0032619"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032620"></see>
    /// </summary>
    let GO_0032620 = _prefix "GO_0032620"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032621"></see>
    /// </summary>
    let GO_0032621 = _prefix "GO_0032621"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032622"></see>
    /// </summary>
    let GO_0032622 = _prefix "GO_0032622"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032623"></see>
    /// </summary>
    let GO_0032623 = _prefix "GO_0032623"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032624"></see>
    /// </summary>
    let GO_0032624 = _prefix "GO_0032624"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032625"></see>
    /// </summary>
    let GO_0032625 = _prefix "GO_0032625"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032626"></see>
    /// </summary>
    let GO_0032626 = _prefix "GO_0032626"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032627"></see>
    /// </summary>
    let GO_0032627 = _prefix "GO_0032627"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032628"></see>
    /// </summary>
    let GO_0032628 = _prefix "GO_0032628"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032629"></see>
    /// </summary>
    let GO_0032629 = _prefix "GO_0032629"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032630"></see>
    /// </summary>
    let GO_0032630 = _prefix "GO_0032630"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032631"></see>
    /// </summary>
    let GO_0032631 = _prefix "GO_0032631"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032632"></see>
    /// </summary>
    let GO_0032632 = _prefix "GO_0032632"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032633"></see>
    /// </summary>
    let GO_0032633 = _prefix "GO_0032633"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032634"></see>
    /// </summary>
    let GO_0032634 = _prefix "GO_0032634"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032635"></see>
    /// </summary>
    let GO_0032635 = _prefix "GO_0032635"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032636"></see>
    /// </summary>
    let GO_0032636 = _prefix "GO_0032636"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032637"></see>
    /// </summary>
    let GO_0032637 = _prefix "GO_0032637"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032638"></see>
    /// </summary>
    let GO_0032638 = _prefix "GO_0032638"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032639"></see>
    /// </summary>
    let GO_0032639 = _prefix "GO_0032639"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032640"></see>
    /// </summary>
    let GO_0032640 = _prefix "GO_0032640"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071706"></see>
    /// </summary>
    let GO_0071706 = _prefix "GO_0071706"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032641"></see>
    /// </summary>
    let GO_0032641 = _prefix "GO_0032641"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032905"></see>
    /// </summary>
    let GO_0032905 = _prefix "GO_0032905"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032906"></see>
    /// </summary>
    let GO_0032906 = _prefix "GO_0032906"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0032907"></see>
    /// </summary>
    let GO_0032907 = _prefix "GO_0032907"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0033036"></see>
    /// </summary>
    let GO_0033036 = _prefix "GO_0033036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0034061"></see>
    /// </summary>
    let GO_0034061 = _prefix "GO_0034061"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0034343"></see>
    /// </summary>
    let GO_0034343 = _prefix "GO_0034343"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0035393"></see>
    /// </summary>
    let GO_0035393 = _prefix "GO_0035393"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0035397"></see>
    /// </summary>
    let GO_0035397 = _prefix "GO_0035397"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0035398"></see>
    /// </summary>
    let GO_0035398 = _prefix "GO_0035398"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0035399"></see>
    /// </summary>
    let GO_0035399 = _prefix "GO_0035399"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0035746"></see>
    /// </summary>
    let GO_0035746 = _prefix "GO_0035746"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0035944"></see>
    /// </summary>
    let GO_0035944 = _prefix "GO_0035944"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0036262"></see>
    /// </summary>
    let GO_0036262 = _prefix "GO_0036262"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0036392"></see>
    /// </summary>
    let GO_0036392 = _prefix "GO_0036392"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0040029"></see>
    /// </summary>
    let GO_0040029 = _prefix "GO_0040029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0040030"></see>
    /// </summary>
    let GO_0040030 = _prefix "GO_0040030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042098"></see>
    /// </summary>
    let GO_0042098 = _prefix "GO_0042098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042101"></see>
    /// </summary>
    let GO_0042101 = _prefix "GO_0042101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042110"></see>
    /// </summary>
    let GO_0042110 = _prefix "GO_0042110"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042571"></see>
    /// </summary>
    let GO_0042571 = _prefix "GO_0042571"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_9991118"></see>
    /// </summary>
    let OBI_9991118 = _prefix "OBI_9991118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042575"></see>
    /// </summary>
    let GO_0042575 = _prefix "GO_0042575"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000085"></see>
    /// </summary>
    let RO_0000085 = _prefix "RO_0000085"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000427"></see>
    /// </summary>
    let OBI_0000427 = _prefix "OBI_0000427"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042605"></see>
    /// </summary>
    let GO_0042605 = _prefix "GO_0042605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0042611"></see>
    /// </summary>
    let GO_0042611 = _prefix "GO_0042611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000000001"></see>
    /// </summary>
    let PR_000000001 = _prefix "PR_000000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0043316"></see>
    /// </summary>
    let GO_0043316 = _prefix "GO_0043316"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0043565"></see>
    /// </summary>
    let GO_0043565 = _prefix "GO_0043565"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0044030"></see>
    /// </summary>
    let GO_0044030 = _prefix "GO_0044030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0044807"></see>
    /// </summary>
    let GO_0044807 = _prefix "GO_0044807"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0044808"></see>
    /// </summary>
    let GO_0044808 = _prefix "GO_0044808"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0044809"></see>
    /// </summary>
    let GO_0044809 = _prefix "GO_0044809"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0048869"></see>
    /// </summary>
    let GO_0048869 = _prefix "GO_0048869"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0051276"></see>
    /// </summary>
    let GO_0051276 = _prefix "GO_0051276"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0070358"></see>
    /// </summary>
    let GO_0070358 = _prefix "GO_0070358"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071604"></see>
    /// </summary>
    let GO_0071604 = _prefix "GO_0071604"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071605"></see>
    /// </summary>
    let GO_0071605 = _prefix "GO_0071605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071606"></see>
    /// </summary>
    let GO_0071606 = _prefix "GO_0071606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071607"></see>
    /// </summary>
    let GO_0071607 = _prefix "GO_0071607"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071608"></see>
    /// </summary>
    let GO_0071608 = _prefix "GO_0071608"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071609"></see>
    /// </summary>
    let GO_0071609 = _prefix "GO_0071609"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071610"></see>
    /// </summary>
    let GO_0071610 = _prefix "GO_0071610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071611"></see>
    /// </summary>
    let GO_0071611 = _prefix "GO_0071611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071612"></see>
    /// </summary>
    let GO_0071612 = _prefix "GO_0071612"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071613"></see>
    /// </summary>
    let GO_0071613 = _prefix "GO_0071613"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0071924"></see>
    /// </summary>
    let GO_0071924 = _prefix "GO_0071924"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0072535"></see>
    /// </summary>
    let GO_0072535 = _prefix "GO_0072535"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097087"></see>
    /// </summary>
    let GO_0097087 = _prefix "GO_0097087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097088"></see>
    /// </summary>
    let GO_0097088 = _prefix "GO_0097088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097278"></see>
    /// </summary>
    let GO_0097278 = _prefix "GO_0097278"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097280"></see>
    /// </summary>
    let GO_0097280 = _prefix "GO_0097280"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097281"></see>
    /// </summary>
    let GO_0097281 = _prefix "GO_0097281"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097282"></see>
    /// </summary>
    let GO_0097282 = _prefix "GO_0097282"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097388"></see>
    /// </summary>
    let GO_0097388 = _prefix "GO_0097388"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097389"></see>
    /// </summary>
    let GO_0097389 = _prefix "GO_0097389"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097390"></see>
    /// </summary>
    let GO_0097390 = _prefix "GO_0097390"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097391"></see>
    /// </summary>
    let GO_0097391 = _prefix "GO_0097391"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097392"></see>
    /// </summary>
    let GO_0097392 = _prefix "GO_0097392"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/GO_0097458"></see>
    /// </summary>
    let GO_0097458 = _prefix "GO_0097458"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/HP_0000855"></see>
    /// </summary>
    let HP_0000855 = _prefix "HP_0000855"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/hp.owl"></see>
    /// </summary>
    let ``hp.owl`` = _prefix "hp.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000001"></see>
    /// </summary>
    let IAO_0000001 = _prefix "IAO_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000114"></see>
    /// </summary>
    let IAO_0000114 = _prefix "IAO_0000114"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000117"></see>
    /// </summary>
    let IAO_0000117 = _prefix "IAO_0000117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000033"></see>
    /// </summary>
    let IAO_0000033 = _prefix "IAO_0000033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000002"></see>
    /// </summary>
    let IAO_0000002 = _prefix "IAO_0000002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000078"></see>
    /// </summary>
    let IAO_0000078 = _prefix "IAO_0000078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000003"></see>
    /// </summary>
    let IAO_0000003 = _prefix "IAO_0000003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000009"></see>
    /// </summary>
    let IAO_0000009 = _prefix "IAO_0000009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000004"></see>
    /// </summary>
    let IAO_0000004 = _prefix "IAO_0000004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000032"></see>
    /// </summary>
    let IAO_0000032 = _prefix "IAO_0000032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000005"></see>
    /// </summary>
    let IAO_0000005 = _prefix "IAO_0000005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000006"></see>
    /// </summary>
    let IAO_0000006 = _prefix "IAO_0000006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000030"></see>
    /// </summary>
    let IAO_0000030 = _prefix "IAO_0000030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000007"></see>
    /// </summary>
    let IAO_0000007 = _prefix "IAO_0000007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000008"></see>
    /// </summary>
    let IAO_0000008 = _prefix "IAO_0000008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000231"></see>
    /// </summary>
    let IAO_0000231 = _prefix "IAO_0000231"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000103"></see>
    /// </summary>
    let IAO_0000103 = _prefix "IAO_0000103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000010"></see>
    /// </summary>
    let IAO_0000010 = _prefix "IAO_0000010"
    /// <summary>
    /// 2/3/2009 Comment from OBI review.
    ///
    /// Action specification not well enough specified.
    /// Conditional specification not well enough specified.
    /// Question whether all plan specifications have objective specifications.
    ///
    /// Request that IAO either clarify these or change definitions not to use them
    /// <see href="http://purl.obolibrary.org/obo/IAO_0000104"></see></summary>
    let IAO_0000104 = _prefix "IAO_0000104"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000012"></see>
    /// </summary>
    let IAO_0000012 = _prefix "IAO_0000012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000013"></see>
    /// </summary>
    let IAO_0000013 = _prefix "IAO_0000013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000088"></see>
    /// </summary>
    let IAO_0000088 = _prefix "IAO_0000088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000015"></see>
    /// </summary>
    let IAO_0000015 = _prefix "IAO_0000015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000059"></see>
    /// </summary>
    let RO_0000059 = _prefix "RO_0000059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000017"></see>
    /// </summary>
    let IAO_0000017 = _prefix "IAO_0000017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000028"></see>
    /// </summary>
    let IAO_0000028 = _prefix "IAO_0000028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000018"></see>
    /// </summary>
    let IAO_0000018 = _prefix "IAO_0000018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000019"></see>
    /// </summary>
    let IAO_0000019 = _prefix "IAO_0000019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000024"></see>
    /// </summary>
    let IAO_0000024 = _prefix "IAO_0000024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000025"></see>
    /// </summary>
    let IAO_0000025 = _prefix "IAO_0000025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000027"></see>
    /// </summary>
    let IAO_0000027 = _prefix "IAO_0000027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000029"></see>
    /// </summary>
    let IAO_0000029 = _prefix "IAO_0000029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000136"></see>
    /// </summary>
    let IAO_0000136 = _prefix "IAO_0000136"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000031"></see>
    /// </summary>
    let IAO_0000031 = _prefix "IAO_0000031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000109"></see>
    /// </summary>
    let IAO_0000109 = _prefix "IAO_0000109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000039"></see>
    /// </summary>
    let IAO_0000039 = _prefix "IAO_0000039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001931"></see>
    /// </summary>
    let OBI_0001931 = _prefix "OBI_0001931"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001938"></see>
    /// </summary>
    let OBI_0001938 = _prefix "OBI_0001938"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000034"></see>
    /// </summary>
    let IAO_0000034 = _prefix "IAO_0000034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000035"></see>
    /// </summary>
    let IAO_0000035 = _prefix "IAO_0000035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000037"></see>
    /// </summary>
    let IAO_0000037 = _prefix "IAO_0000037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000038"></see>
    /// </summary>
    let IAO_0000038 = _prefix "IAO_0000038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000309"></see>
    /// </summary>
    let IAO_0000309 = _prefix "IAO_0000309"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000047"></see>
    /// </summary>
    let IAO_0000047 = _prefix "IAO_0000047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000055"></see>
    /// </summary>
    let IAO_0000055 = _prefix "IAO_0000055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000057"></see>
    /// </summary>
    let IAO_0000057 = _prefix "IAO_0000057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000059"></see>
    /// </summary>
    let IAO_0000059 = _prefix "IAO_0000059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000064"></see>
    /// </summary>
    let IAO_0000064 = _prefix "IAO_0000064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000065"></see>
    /// </summary>
    let IAO_0000065 = _prefix "IAO_0000065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000102"></see>
    /// </summary>
    let IAO_0000102 = _prefix "IAO_0000102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000079"></see>
    /// </summary>
    let IAO_0000079 = _prefix "IAO_0000079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000310"></see>
    /// </summary>
    let IAO_0000310 = _prefix "IAO_0000310"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000091"></see>
    /// </summary>
    let IAO_0000091 = _prefix "IAO_0000091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000093"></see>
    /// </summary>
    let IAO_0000093 = _prefix "IAO_0000093"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000096"></see>
    /// </summary>
    let IAO_0000096 = _prefix "IAO_0000096"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000097"></see>
    /// </summary>
    let IAO_0000097 = _prefix "IAO_0000097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000098"></see>
    /// </summary>
    let IAO_0000098 = _prefix "IAO_0000098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000100"></see>
    /// </summary>
    let IAO_0000100 = _prefix "IAO_0000100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000101"></see>
    /// </summary>
    let IAO_0000101 = _prefix "IAO_0000101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000308"></see>
    /// </summary>
    let IAO_0000308 = _prefix "IAO_0000308"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000225"></see>
    /// </summary>
    let IAO_0000225 = _prefix "IAO_0000225"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000105"></see>
    /// </summary>
    let IAO_0000105 = _prefix "IAO_0000105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001933"></see>
    /// </summary>
    let OBI_0001933 = _prefix "OBI_0001933"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000113"></see>
    /// </summary>
    let IAO_0000113 = _prefix "IAO_0000113"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000128"></see>
    /// </summary>
    let IAO_0000128 = _prefix "IAO_0000128"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000129"></see>
    /// </summary>
    let IAO_0000129 = _prefix "IAO_0000129"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000131"></see>
    /// </summary>
    let IAO_0000131 = _prefix "IAO_0000131"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000132"></see>
    /// </summary>
    let IAO_0000132 = _prefix "IAO_0000132"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000135"></see>
    /// </summary>
    let IAO_0000135 = _prefix "IAO_0000135"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000140"></see>
    /// </summary>
    let IAO_0000140 = _prefix "IAO_0000140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000141"></see>
    /// </summary>
    let IAO_0000141 = _prefix "IAO_0000141"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000142"></see>
    /// </summary>
    let IAO_0000142 = _prefix "IAO_0000142"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000144"></see>
    /// </summary>
    let IAO_0000144 = _prefix "IAO_0000144"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000338"></see>
    /// </summary>
    let OBI_0000338 = _prefix "OBI_0000338"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000300"></see>
    /// </summary>
    let IAO_0000300 = _prefix "IAO_0000300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001909"></see>
    /// </summary>
    let OBI_0001909 = _prefix "OBI_0001909"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000124"></see>
    /// </summary>
    let OBI_0000124 = _prefix "OBI_0000124"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000178"></see>
    /// </summary>
    let IAO_0000178 = _prefix "IAO_0000178"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000053"></see>
    /// </summary>
    let RO_0000053 = _prefix "RO_0000053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000179"></see>
    /// </summary>
    let IAO_0000179 = _prefix "IAO_0000179"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000180"></see>
    /// </summary>
    let IAO_0000180 = _prefix "IAO_0000180"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000181"></see>
    /// </summary>
    let IAO_0000181 = _prefix "IAO_0000181"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000182"></see>
    /// </summary>
    let IAO_0000182 = _prefix "IAO_0000182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000183"></see>
    /// </summary>
    let IAO_0000183 = _prefix "IAO_0000183"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000184"></see>
    /// </summary>
    let IAO_0000184 = _prefix "IAO_0000184"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000185"></see>
    /// </summary>
    let IAO_0000185 = _prefix "IAO_0000185"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000186"></see>
    /// </summary>
    let IAO_0000186 = _prefix "IAO_0000186"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000219"></see>
    /// </summary>
    let IAO_0000219 = _prefix "IAO_0000219"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000220"></see>
    /// </summary>
    let IAO_0000220 = _prefix "IAO_0000220"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000221"></see>
    /// </summary>
    let IAO_0000221 = _prefix "IAO_0000221"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000417"></see>
    /// </summary>
    let IAO_0000417 = _prefix "IAO_0000417"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000222"></see>
    /// </summary>
    let IAO_0000222 = _prefix "IAO_0000222"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000223"></see>
    /// </summary>
    let IAO_0000223 = _prefix "IAO_0000223"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000224"></see>
    /// </summary>
    let IAO_0000224 = _prefix "IAO_0000224"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000230"></see>
    /// </summary>
    let IAO_0000230 = _prefix "IAO_0000230"
    /// <summary>
    /// The 'tracker item' can associate a tracker with a specific ontology term.
    /// <see href="http://purl.obolibrary.org/obo/IAO_0000233"></see></summary>
    let IAO_0000233 = _prefix "IAO_0000233"
    /// <summary>
    /// The 'term requester' can credit the person, organization or project who request the ontology term.
    /// <see href="http://purl.obolibrary.org/obo/IAO_0000234"></see></summary>
    let IAO_0000234 = _prefix "IAO_0000234"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000301"></see>
    /// </summary>
    let IAO_0000301 = _prefix "IAO_0000301"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000302"></see>
    /// </summary>
    let IAO_0000302 = _prefix "IAO_0000302"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000590"></see>
    /// </summary>
    let IAO_0000590 = _prefix "IAO_0000590"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000303"></see>
    /// </summary>
    let IAO_0000303 = _prefix "IAO_0000303"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000304"></see>
    /// </summary>
    let IAO_0000304 = _prefix "IAO_0000304"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000305"></see>
    /// </summary>
    let IAO_0000305 = _prefix "IAO_0000305"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000306"></see>
    /// </summary>
    let IAO_0000306 = _prefix "IAO_0000306"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000307"></see>
    /// </summary>
    let IAO_0000307 = _prefix "IAO_0000307"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000311"></see>
    /// </summary>
    let IAO_0000311 = _prefix "IAO_0000311"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000312"></see>
    /// </summary>
    let IAO_0000312 = _prefix "IAO_0000312"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000066"></see>
    /// </summary>
    let OBI_0000066 = _prefix "OBI_0000066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000313"></see>
    /// </summary>
    let IAO_0000313 = _prefix "IAO_0000313"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000314"></see>
    /// </summary>
    let IAO_0000314 = _prefix "IAO_0000314"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000315"></see>
    /// </summary>
    let IAO_0000315 = _prefix "IAO_0000315"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000316"></see>
    /// </summary>
    let IAO_0000316 = _prefix "IAO_0000316"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000317"></see>
    /// </summary>
    let IAO_0000317 = _prefix "IAO_0000317"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500000"></see>
    /// </summary>
    let OBI_0500000 = _prefix "OBI_0500000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000318"></see>
    /// </summary>
    let IAO_0000318 = _prefix "IAO_0000318"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000471"></see>
    /// </summary>
    let OBI_0000471 = _prefix "OBI_0000471"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000319"></see>
    /// </summary>
    let IAO_0000319 = _prefix "IAO_0000319"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000320"></see>
    /// </summary>
    let IAO_0000320 = _prefix "IAO_0000320"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000321"></see>
    /// </summary>
    let IAO_0000321 = _prefix "IAO_0000321"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000322"></see>
    /// </summary>
    let IAO_0000322 = _prefix "IAO_0000322"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000323"></see>
    /// </summary>
    let IAO_0000323 = _prefix "IAO_0000323"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000324"></see>
    /// </summary>
    let IAO_0000324 = _prefix "IAO_0000324"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000325"></see>
    /// </summary>
    let IAO_0000325 = _prefix "IAO_0000325"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000326"></see>
    /// </summary>
    let IAO_0000326 = _prefix "IAO_0000326"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000327"></see>
    /// </summary>
    let IAO_0000327 = _prefix "IAO_0000327"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000328"></see>
    /// </summary>
    let IAO_0000328 = _prefix "IAO_0000328"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000329"></see>
    /// </summary>
    let IAO_0000329 = _prefix "IAO_0000329"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000330"></see>
    /// </summary>
    let IAO_0000330 = _prefix "IAO_0000330"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000400"></see>
    /// </summary>
    let IAO_0000400 = _prefix "IAO_0000400"
    /// <summary>
    /// relating a cartesian spatial coordinate datum to a unit label that together with the values represent a point
    /// <see href="http://purl.obolibrary.org/obo/IAO_0000407"></see></summary>
    let IAO_0000407 = _prefix "IAO_0000407"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000401"></see>
    /// </summary>
    let IAO_0000401 = _prefix "IAO_0000401"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000404"></see>
    /// </summary>
    let IAO_0000404 = _prefix "IAO_0000404"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000402"></see>
    /// </summary>
    let IAO_0000402 = _prefix "IAO_0000402"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000406"></see>
    /// </summary>
    let IAO_0000406 = _prefix "IAO_0000406"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000403"></see>
    /// </summary>
    let IAO_0000403 = _prefix "IAO_0000403"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000405"></see>
    /// </summary>
    let IAO_0000405 = _prefix "IAO_0000405"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000001"></see>
    /// </summary>
    let UO_0000001 = _prefix "UO_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000408"></see>
    /// </summary>
    let IAO_0000408 = _prefix "IAO_0000408"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000122"></see>
    /// </summary>
    let PATO_0000122 = _prefix "PATO_0000122"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000409"></see>
    /// </summary>
    let IAO_0000409 = _prefix "IAO_0000409"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000410"></see>
    /// </summary>
    let IAO_0000410 = _prefix "IAO_0000410"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000420"></see>
    /// </summary>
    let IAO_0000420 = _prefix "IAO_0000420"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000421"></see>
    /// </summary>
    let IAO_0000421 = _prefix "IAO_0000421"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000411"></see>
    /// </summary>
    let IAO_0000411 = _prefix "IAO_0000411"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000413"></see>
    /// </summary>
    let IAO_0000413 = _prefix "IAO_0000413"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000416"></see>
    /// </summary>
    let IAO_0000416 = _prefix "IAO_0000416"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000414"></see>
    /// </summary>
    let IAO_0000414 = _prefix "IAO_0000414"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000002"></see>
    /// </summary>
    let UO_0000002 = _prefix "UO_0000002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000125"></see>
    /// </summary>
    let PATO_0000125 = _prefix "PATO_0000125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000415"></see>
    /// </summary>
    let IAO_0000415 = _prefix "IAO_0000415"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000003"></see>
    /// </summary>
    let UO_0000003 = _prefix "UO_0000003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000418"></see>
    /// </summary>
    let IAO_0000418 = _prefix "IAO_0000418"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000419"></see>
    /// </summary>
    let IAO_0000419 = _prefix "IAO_0000419"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000422"></see>
    /// </summary>
    let IAO_0000422 = _prefix "IAO_0000422"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000424"></see>
    /// </summary>
    let IAO_0000424 = _prefix "IAO_0000424"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000425"></see>
    /// </summary>
    let IAO_0000425 = _prefix "IAO_0000425"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000426"></see>
    /// </summary>
    let IAO_0000426 = _prefix "IAO_0000426"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000427"></see>
    /// </summary>
    let IAO_0000427 = _prefix "IAO_0000427"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000429"></see>
    /// </summary>
    let IAO_0000429 = _prefix "IAO_0000429"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000442"></see>
    /// </summary>
    let IAO_0000442 = _prefix "IAO_0000442"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000443"></see>
    /// </summary>
    let IAO_0000443 = _prefix "IAO_0000443"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000299"></see>
    /// </summary>
    let OBI_0000299 = _prefix "OBI_0000299"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000293"></see>
    /// </summary>
    let OBI_0000293 = _prefix "OBI_0000293"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000572"></see>
    /// </summary>
    let IAO_0000572 = _prefix "IAO_0000572"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000573"></see>
    /// </summary>
    let IAO_0000573 = _prefix "IAO_0000573"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000574"></see>
    /// </summary>
    let IAO_0000574 = _prefix "IAO_0000574"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000577"></see>
    /// </summary>
    let IAO_0000577 = _prefix "IAO_0000577"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000579"></see>
    /// </summary>
    let IAO_0000579 = _prefix "IAO_0000579"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000057"></see>
    /// </summary>
    let RO_0000057 = _prefix "RO_0000057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000575"></see>
    /// </summary>
    let IAO_0000575 = _prefix "IAO_0000575"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000576"></see>
    /// </summary>
    let IAO_0000576 = _prefix "IAO_0000576"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000578"></see>
    /// </summary>
    let IAO_0000578 = _prefix "IAO_0000578"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000580"></see>
    /// </summary>
    let IAO_0000580 = _prefix "IAO_0000580"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000581"></see>
    /// </summary>
    let IAO_0000581 = _prefix "IAO_0000581"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000582"></see>
    /// </summary>
    let IAO_0000582 = _prefix "IAO_0000582"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000583"></see>
    /// </summary>
    let IAO_0000583 = _prefix "IAO_0000583"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000584"></see>
    /// </summary>
    let IAO_0000584 = _prefix "IAO_0000584"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000589"></see>
    /// </summary>
    let IAO_0000589 = _prefix "IAO_0000589"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000591"></see>
    /// </summary>
    let IAO_0000591 = _prefix "IAO_0000591"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000592"></see>
    /// </summary>
    let IAO_0000592 = _prefix "IAO_0000592"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000593"></see>
    /// </summary>
    let IAO_0000593 = _prefix "IAO_0000593"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000594"></see>
    /// </summary>
    let IAO_0000594 = _prefix "IAO_0000594"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000595"></see>
    /// </summary>
    let IAO_0000595 = _prefix "IAO_0000595"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000596"></see>
    /// </summary>
    let IAO_0000596 = _prefix "IAO_0000596"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000597"></see>
    /// </summary>
    let IAO_0000597 = _prefix "IAO_0000597"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000598"></see>
    /// </summary>
    let IAO_0000598 = _prefix "IAO_0000598"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000599"></see>
    /// </summary>
    let IAO_0000599 = _prefix "IAO_0000599"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000603"></see>
    /// </summary>
    let IAO_0000603 = _prefix "IAO_0000603"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000604"></see>
    /// </summary>
    let IAO_0000604 = _prefix "IAO_0000604"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000605"></see>
    /// </summary>
    let IAO_0000605 = _prefix "IAO_0000605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000606"></see>
    /// </summary>
    let IAO_0000606 = _prefix "IAO_0000606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000607"></see>
    /// </summary>
    let IAO_0000607 = _prefix "IAO_0000607"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000608"></see>
    /// </summary>
    let IAO_0000608 = _prefix "IAO_0000608"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000609"></see>
    /// </summary>
    let IAO_0000609 = _prefix "IAO_0000609"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000610"></see>
    /// </summary>
    let IAO_0000610 = _prefix "IAO_0000610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000611"></see>
    /// </summary>
    let IAO_0000611 = _prefix "IAO_0000611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000612"></see>
    /// </summary>
    let IAO_0000612 = _prefix "IAO_0000612"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000613"></see>
    /// </summary>
    let IAO_0000613 = _prefix "IAO_0000613"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000614"></see>
    /// </summary>
    let IAO_0000614 = _prefix "IAO_0000614"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000615"></see>
    /// </summary>
    let IAO_0000615 = _prefix "IAO_0000615"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000616"></see>
    /// </summary>
    let IAO_0000616 = _prefix "IAO_0000616"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000617"></see>
    /// </summary>
    let IAO_0000617 = _prefix "IAO_0000617"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000618"></see>
    /// </summary>
    let IAO_0000618 = _prefix "IAO_0000618"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000619"></see>
    /// </summary>
    let IAO_0000619 = _prefix "IAO_0000619"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000620"></see>
    /// </summary>
    let IAO_0000620 = _prefix "IAO_0000620"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000621"></see>
    /// </summary>
    let IAO_0000621 = _prefix "IAO_0000621"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000622"></see>
    /// </summary>
    let IAO_0000622 = _prefix "IAO_0000622"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000623"></see>
    /// </summary>
    let IAO_0000623 = _prefix "IAO_0000623"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000624"></see>
    /// </summary>
    let IAO_0000624 = _prefix "IAO_0000624"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000625"></see>
    /// </summary>
    let IAO_0000625 = _prefix "IAO_0000625"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000626"></see>
    /// </summary>
    let IAO_0000626 = _prefix "IAO_0000626"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000627"></see>
    /// </summary>
    let IAO_0000627 = _prefix "IAO_0000627"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000628"></see>
    /// </summary>
    let IAO_0000628 = _prefix "IAO_0000628"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000629"></see>
    /// </summary>
    let IAO_0000629 = _prefix "IAO_0000629"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000630"></see>
    /// </summary>
    let IAO_0000630 = _prefix "IAO_0000630"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000631"></see>
    /// </summary>
    let IAO_0000631 = _prefix "IAO_0000631"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000632"></see>
    /// </summary>
    let IAO_0000632 = _prefix "IAO_0000632"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000633"></see>
    /// </summary>
    let IAO_0000633 = _prefix "IAO_0000633"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000634"></see>
    /// </summary>
    let IAO_0000634 = _prefix "IAO_0000634"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000635"></see>
    /// </summary>
    let IAO_0000635 = _prefix "IAO_0000635"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000636"></see>
    /// </summary>
    let IAO_0000636 = _prefix "IAO_0000636"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000637"></see>
    /// </summary>
    let IAO_0000637 = _prefix "IAO_0000637"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000638"></see>
    /// </summary>
    let IAO_0000638 = _prefix "IAO_0000638"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000639"></see>
    /// </summary>
    let IAO_0000639 = _prefix "IAO_0000639"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000640"></see>
    /// </summary>
    let IAO_0000640 = _prefix "IAO_0000640"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000641"></see>
    /// </summary>
    let IAO_0000641 = _prefix "IAO_0000641"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000642"></see>
    /// </summary>
    let IAO_0000642 = _prefix "IAO_0000642"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000643"></see>
    /// </summary>
    let IAO_0000643 = _prefix "IAO_0000643"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000644"></see>
    /// </summary>
    let IAO_0000644 = _prefix "IAO_0000644"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000645"></see>
    /// </summary>
    let IAO_0000645 = _prefix "IAO_0000645"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0000650"></see>
    /// </summary>
    let IAO_0000650 = _prefix "IAO_0000650"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IAO_0100001"></see>
    /// </summary>
    let IAO_0100001 = _prefix "IAO_0100001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IDO_0000586"></see>
    /// </summary>
    let IDO_0000586 = _prefix "IDO_0000586"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ido.owl"></see>
    /// </summary>
    let ``ido.owl`` = _prefix "ido.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/IDO_0000666"></see>
    /// </summary>
    let IDO_0000666 = _prefix "IDO_0000666"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10090"></see>
    /// </summary>
    let NCBITaxon_10090 = _prefix "NCBITaxon_10090"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ncbitaxon.owl"></see>
    /// </summary>
    let ``ncbitaxon.owl`` = _prefix "ncbitaxon.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_39107"></see>
    /// </summary>
    let NCBITaxon_39107 = _prefix "NCBITaxon_39107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10116"></see>
    /// </summary>
    let NCBITaxon_10116 = _prefix "NCBITaxon_10116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10239"></see>
    /// </summary>
    let NCBITaxon_10239 = _prefix "NCBITaxon_10239"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100026"></see>
    /// </summary>
    let OBI_0100026 = _prefix "OBI_0100026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10292"></see>
    /// </summary>
    let NCBITaxon_10292 = _prefix "NCBITaxon_10292"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10358"></see>
    /// </summary>
    let NCBITaxon_10358 = _prefix "NCBITaxon_10358"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10376"></see>
    /// </summary>
    let NCBITaxon_10376 = _prefix "NCBITaxon_10376"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_10407"></see>
    /// </summary>
    let NCBITaxon_10407 = _prefix "NCBITaxon_10407"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_35268"></see>
    /// </summary>
    let NCBITaxon_35268 = _prefix "NCBITaxon_35268"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_11103"></see>
    /// </summary>
    let NCBITaxon_11103 = _prefix "NCBITaxon_11103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_11652"></see>
    /// </summary>
    let NCBITaxon_11652 = _prefix "NCBITaxon_11652"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_11676"></see>
    /// </summary>
    let NCBITaxon_11676 = _prefix "NCBITaxon_11676"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_11709"></see>
    /// </summary>
    let NCBITaxon_11709 = _prefix "NCBITaxon_11709"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_117571"></see>
    /// </summary>
    let NCBITaxon_117571 = _prefix "NCBITaxon_117571"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_7742"></see>
    /// </summary>
    let NCBITaxon_7742 = _prefix "NCBITaxon_7742"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_1206794"></see>
    /// </summary>
    let NCBITaxon_1206794 = _prefix "NCBITaxon_1206794"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_33213"></see>
    /// </summary>
    let NCBITaxon_33213 = _prefix "NCBITaxon_33213"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_160"></see>
    /// </summary>
    let NCBITaxon_160 = _prefix "NCBITaxon_160"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_2"></see>
    /// </summary>
    let NCBITaxon_2 = _prefix "NCBITaxon_2"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_197562"></see>
    /// </summary>
    let NCBITaxon_197562 = _prefix "NCBITaxon_197562"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_2157"></see>
    /// </summary>
    let NCBITaxon_2157 = _prefix "NCBITaxon_2157"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_2759"></see>
    /// </summary>
    let NCBITaxon_2759 = _prefix "NCBITaxon_2759"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_314146"></see>
    /// </summary>
    let NCBITaxon_314146 = _prefix "NCBITaxon_314146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_40674"></see>
    /// </summary>
    let NCBITaxon_40674 = _prefix "NCBITaxon_40674"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_32523"></see>
    /// </summary>
    let NCBITaxon_32523 = _prefix "NCBITaxon_32523"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_32524"></see>
    /// </summary>
    let NCBITaxon_32524 = _prefix "NCBITaxon_32524"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_33154"></see>
    /// </summary>
    let NCBITaxon_33154 = _prefix "NCBITaxon_33154"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_3702"></see>
    /// </summary>
    let NCBITaxon_3702 = _prefix "NCBITaxon_3702"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_388799"></see>
    /// </summary>
    let NCBITaxon_388799 = _prefix "NCBITaxon_388799"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_9989"></see>
    /// </summary>
    let NCBITaxon_9989 = _prefix "NCBITaxon_9989"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_44689"></see>
    /// </summary>
    let NCBITaxon_44689 = _prefix "NCBITaxon_44689"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_4890"></see>
    /// </summary>
    let NCBITaxon_4890 = _prefix "NCBITaxon_4890"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_4896"></see>
    /// </summary>
    let NCBITaxon_4896 = _prefix "NCBITaxon_4896"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_4932"></see>
    /// </summary>
    let NCBITaxon_4932 = _prefix "NCBITaxon_4932"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_716545"></see>
    /// </summary>
    let NCBITaxon_716545 = _prefix "NCBITaxon_716545"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_5140"></see>
    /// </summary>
    let NCBITaxon_5140 = _prefix "NCBITaxon_5140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_6239"></see>
    /// </summary>
    let NCBITaxon_6239 = _prefix "NCBITaxon_6239"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_6668"></see>
    /// </summary>
    let NCBITaxon_6668 = _prefix "NCBITaxon_6668"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_7227"></see>
    /// </summary>
    let NCBITaxon_7227 = _prefix "NCBITaxon_7227"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_7955"></see>
    /// </summary>
    let NCBITaxon_7955 = _prefix "NCBITaxon_7955"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_8353"></see>
    /// </summary>
    let NCBITaxon_8353 = _prefix "NCBITaxon_8353"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_9031"></see>
    /// </summary>
    let NCBITaxon_9031 = _prefix "NCBITaxon_9031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/NCBITaxon_9606"></see>
    /// </summary>
    let NCBITaxon_9606 = _prefix "NCBITaxon_9606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000006"></see>
    /// </summary>
    let OBI_0000006 = _prefix "OBI_0000006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000273"></see>
    /// </summary>
    let OBI_0000273 = _prefix "OBI_0000273"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000010"></see>
    /// </summary>
    let OBI_0000010 = _prefix "OBI_0000010"
    /// <summary>
    /// Please cite the OBI consortium http://purl.obolibrary.org/obo/obi where traditional citation is called for. However it is adequate that individual terms be attributed simply by use of the identifying PURL for the term, in projects that refer to them.
    /// <see href="http://purl.obolibrary.org/obo/obi.owl"></see></summary>
    let ``obi.owl`` = _prefix "obi.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000014"></see>
    /// </summary>
    let OBI_0000014 = _prefix "OBI_0000014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000017"></see>
    /// </summary>
    let OBI_0000017 = _prefix "OBI_0000017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000015"></see>
    /// </summary>
    let OBI_0000015 = _prefix "OBI_0000015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000016"></see>
    /// </summary>
    let OBI_0000016 = _prefix "OBI_0000016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000018"></see>
    /// </summary>
    let OBI_0000018 = _prefix "OBI_0000018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000947"></see>
    /// </summary>
    let OBI_0000947 = _prefix "OBI_0000947"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000020"></see>
    /// </summary>
    let OBI_0000020 = _prefix "OBI_0000020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000116"></see>
    /// </summary>
    let OBI_0000116 = _prefix "OBI_0000116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000021"></see>
    /// </summary>
    let OBI_0000021 = _prefix "OBI_0000021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000023"></see>
    /// </summary>
    let OBI_0000023 = _prefix "OBI_0000023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000663"></see>
    /// </summary>
    let OBI_0000663 = _prefix "OBI_0000663"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000025"></see>
    /// </summary>
    let OBI_0000025 = _prefix "OBI_0000025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000052"></see>
    /// </summary>
    let RO_0000052 = _prefix "RO_0000052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000026"></see>
    /// </summary>
    let OBI_0000026 = _prefix "OBI_0000026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000250"></see>
    /// </summary>
    let OBI_0000250 = _prefix "OBI_0000250"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000029"></see>
    /// </summary>
    let OBI_0000029 = _prefix "OBI_0000029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302886"></see>
    /// </summary>
    let OBI_0302886 = _prefix "OBI_0302886"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000032"></see>
    /// </summary>
    let OBI_0000032 = _prefix "OBI_0000032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000034"></see>
    /// </summary>
    let OBI_0000034 = _prefix "OBI_0000034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600014"></see>
    /// </summary>
    let OBI_0600014 = _prefix "OBI_0600014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000038"></see>
    /// </summary>
    let OBI_0000038 = _prefix "OBI_0000038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000372"></see>
    /// </summary>
    let OBI_0000372 = _prefix "OBI_0000372"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600046"></see>
    /// </summary>
    let OBI_0600046 = _prefix "OBI_0600046"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000932"></see>
    /// </summary>
    let OBI_0000932 = _prefix "OBI_0000932"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000967"></see>
    /// </summary>
    let OBI_0000967 = _prefix "OBI_0000967"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000040"></see>
    /// </summary>
    let OBI_0000040 = _prefix "OBI_0000040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000041"></see>
    /// </summary>
    let OBI_0000041 = _prefix "OBI_0000041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000379"></see>
    /// </summary>
    let OBI_0000379 = _prefix "OBI_0000379"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000968"></see>
    /// </summary>
    let OBI_0000968 = _prefix "OBI_0000968"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000043"></see>
    /// </summary>
    let OBI_0000043 = _prefix "OBI_0000043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000105"></see>
    /// </summary>
    let OBI_0000105 = _prefix "OBI_0000105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000044"></see>
    /// </summary>
    let OBI_0000044 = _prefix "OBI_0000044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000045"></see>
    /// </summary>
    let OBI_0000045 = _prefix "OBI_0000045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600009"></see>
    /// </summary>
    let OBI_0600009 = _prefix "OBI_0600009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000048"></see>
    /// </summary>
    let OBI_0000048 = _prefix "OBI_0000048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000370"></see>
    /// </summary>
    let OBI_0000370 = _prefix "OBI_0000370"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002089"></see>
    /// </summary>
    let OBI_0002089 = _prefix "OBI_0002089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000832"></see>
    /// </summary>
    let OBI_0000832 = _prefix "OBI_0000832"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000401"></see>
    /// </summary>
    let OBI_0000401 = _prefix "OBI_0000401"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000453"></see>
    /// </summary>
    let OBI_0000453 = _prefix "OBI_0000453"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000049"></see>
    /// </summary>
    let OBI_0000049 = _prefix "OBI_0000049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000654"></see>
    /// </summary>
    let OBI_0000654 = _prefix "OBI_0000654"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000345"></see>
    /// </summary>
    let OBI_0000345 = _prefix "OBI_0000345"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000361"></see>
    /// </summary>
    let OBI_0000361 = _prefix "OBI_0000361"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000364"></see>
    /// </summary>
    let OBI_0000364 = _prefix "OBI_0000364"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000245"></see>
    /// </summary>
    let OBI_0000245 = _prefix "OBI_0000245"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000647"></see>
    /// </summary>
    let OBI_0000647 = _prefix "OBI_0000647"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000050"></see>
    /// </summary>
    let OBI_0000050 = _prefix "OBI_0000050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000051"></see>
    /// </summary>
    let OBI_0000051 = _prefix "OBI_0000051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000052"></see>
    /// </summary>
    let OBI_0000052 = _prefix "OBI_0000052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400147"></see>
    /// </summary>
    let OBI_0400147 = _prefix "OBI_0400147"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000054"></see>
    /// </summary>
    let OBI_0000054 = _prefix "OBI_0000054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000055"></see>
    /// </summary>
    let OBI_0000055 = _prefix "OBI_0000055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000242"></see>
    /// </summary>
    let OBI_0000242 = _prefix "OBI_0000242"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000056"></see>
    /// </summary>
    let OBI_0000056 = _prefix "OBI_0000056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000057"></see>
    /// </summary>
    let OBI_0000057 = _prefix "OBI_0000057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000059"></see>
    /// </summary>
    let OBI_0000059 = _prefix "OBI_0000059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000060"></see>
    /// </summary>
    let OBI_0000060 = _prefix "OBI_0000060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000102"></see>
    /// </summary>
    let OBI_0000102 = _prefix "OBI_0000102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000064"></see>
    /// </summary>
    let OBI_0000064 = _prefix "OBI_0000064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000070"></see>
    /// </summary>
    let OBI_0000070 = _prefix "OBI_0000070"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000065"></see>
    /// </summary>
    let OBI_0000065 = _prefix "OBI_0000065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001847"></see>
    /// </summary>
    let OBI_0001847 = _prefix "OBI_0001847"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000339"></see>
    /// </summary>
    let OBI_0000339 = _prefix "OBI_0000339"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000067"></see>
    /// </summary>
    let OBI_0000067 = _prefix "OBI_0000067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000068"></see>
    /// </summary>
    let OBI_0000068 = _prefix "OBI_0000068"
    /// <summary>
    /// Philly2013: Historically, this role would have been borne only by humans or organizations. However, we now also want to enable investigations run by robot scientists such as ADAM (King et al, Science, 2009)
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000202"></see></summary>
    let OBI_0000202 = _prefix "OBI_0000202"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200000"></see>
    /// </summary>
    let OBI_0200000 = _prefix "OBI_0200000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600013"></see>
    /// </summary>
    let OBI_0600013 = _prefix "OBI_0600013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000441"></see>
    /// </summary>
    let OBI_0000441 = _prefix "OBI_0000441"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000417"></see>
    /// </summary>
    let OBI_0000417 = _prefix "OBI_0000417"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000071"></see>
    /// </summary>
    let OBI_0000071 = _prefix "OBI_0000071"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000073"></see>
    /// </summary>
    let OBI_0000073 = _prefix "OBI_0000073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000456"></see>
    /// </summary>
    let OBI_0000456 = _prefix "OBI_0000456"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000075"></see>
    /// </summary>
    let OBI_0000075 = _prefix "OBI_0000075"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000076"></see>
    /// </summary>
    let OBI_0000076 = _prefix "OBI_0000076"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000078"></see>
    /// </summary>
    let OBI_0000078 = _prefix "OBI_0000078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000079"></see>
    /// </summary>
    let OBI_0000079 = _prefix "OBI_0000079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000083"></see>
    /// </summary>
    let OBI_0000083 = _prefix "OBI_0000083"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000084"></see>
    /// </summary>
    let OBI_0000084 = _prefix "OBI_0000084"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000836"></see>
    /// </summary>
    let OBI_0000836 = _prefix "OBI_0000836"
    /// <summary>
    /// (copied from ReO)
    /// Reagents are distinguished from instruments or devices that also participate in scientific techniques by the fact that reagents are chemical or biological in nature and necessarily participate in or have parts that participate in some chemical interaction or reaction during their intended participation in some technique.  By contrast, instruments do not participate in a chemical reaction/interaction during the technique.
    ///
    /// Reagents are distinguished from study subjects/evaluants in that study subjects and evaluants are that about which conclusions are drawn and knowledge is sought in an investigation - while reagents, by definition, are not.  It should be noted, however, that reagent and study subject/evaluant roles can be borne by instances of the same type of material entity - but a given instance will realize only one of these roles in the execution of a given assay or technique. For example, taq polymerase can bear a reagent role or an evaluant role.  In a DNA sequencing assay aimed at generating sequence data about some plasmid, the reagent role of the taq polymerase is realized. In an assay to evaluate the quality of the taq polymerase itself, the evaluant/study subject role of the taq is realized, but not the reagent role since the taq is the subject about which data is generated.
    ///
    /// In regard to the statement that reagents are 'distinct' from the specified outputs of a technique, note that a reagent may be incorporated into a material output of a technique, as long as the IDENTITY of this output is distinct from that of the bearer of the reagent role.  For example, dNTPs input into a PCR are reagents that become part of the material output of this technique, but this output has a new identity (ie that of a 'nucleic acid molecule') that is distinct from the identity of the dNTPs that comprise it.  Similarly, a biotin molecule input into a cell labeling technique are reagents that become part of the specified output, but the identity of the output is that of some modified cell specimen which shares identity with the input unmodified cell specimen, and not with the biotin label. Thus, we see that an important criteria of 'reagent-ness' is that it is a facilitator, and not the primary focus of an investigation or material processing technique (ie not the specified subject/evaluant about which knowledge is sought, or the specified output material of the technique).
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000086"></see></summary>
    let OBI_0000086 = _prefix "OBI_0000086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000089"></see>
    /// </summary>
    let OBI_0000089 = _prefix "OBI_0000089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000091"></see>
    /// </summary>
    let OBI_0000091 = _prefix "OBI_0000091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000092"></see>
    /// </summary>
    let OBI_0000092 = _prefix "OBI_0000092"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000093"></see>
    /// </summary>
    let OBI_0000093 = _prefix "OBI_0000093"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600010"></see>
    /// </summary>
    let OBI_0600010 = _prefix "OBI_0600010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000096"></see>
    /// </summary>
    let OBI_0000096 = _prefix "OBI_0000096"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000208"></see>
    /// </summary>
    let OBI_0000208 = _prefix "OBI_0000208"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000097"></see>
    /// </summary>
    let OBI_0000097 = _prefix "OBI_0000097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000100"></see>
    /// </summary>
    let OBI_0000100 = _prefix "OBI_0000100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000101"></see>
    /// </summary>
    let OBI_0000101 = _prefix "OBI_0000101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000103"></see>
    /// </summary>
    let OBI_0000103 = _prefix "OBI_0000103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000107"></see>
    /// </summary>
    let OBI_0000107 = _prefix "OBI_0000107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001173"></see>
    /// </summary>
    let OBI_0001173 = _prefix "OBI_0001173"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000109"></see>
    /// </summary>
    let OBI_0000109 = _prefix "OBI_0000109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000110"></see>
    /// </summary>
    let OBI_0000110 = _prefix "OBI_0000110"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000112"></see>
    /// </summary>
    let OBI_0000112 = _prefix "OBI_0000112"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000659"></see>
    /// </summary>
    let OBI_0000659 = _prefix "OBI_0000659"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000113"></see>
    /// </summary>
    let OBI_0000113 = _prefix "OBI_0000113"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000115"></see>
    /// </summary>
    let OBI_0000115 = _prefix "OBI_0000115"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000750"></see>
    /// </summary>
    let OBI_0000750 = _prefix "OBI_0000750"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000931"></see>
    /// </summary>
    let OBI_0000931 = _prefix "OBI_0000931"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000117"></see>
    /// </summary>
    let OBI_0000117 = _prefix "OBI_0000117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000118"></see>
    /// </summary>
    let OBI_0000118 = _prefix "OBI_0000118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000119"></see>
    /// </summary>
    let OBI_0000119 = _prefix "OBI_0000119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000125"></see>
    /// </summary>
    let OBI_0000125 = _prefix "OBI_0000125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000129"></see>
    /// </summary>
    let OBI_0000129 = _prefix "OBI_0000129"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000818"></see>
    /// </summary>
    let OBI_0000818 = _prefix "OBI_0000818"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000131"></see>
    /// </summary>
    let OBI_0000131 = _prefix "OBI_0000131"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000134"></see>
    /// </summary>
    let OBI_0000134 = _prefix "OBI_0000134"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000136"></see>
    /// </summary>
    let OBI_0000136 = _prefix "OBI_0000136"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000140"></see>
    /// </summary>
    let OBI_0000140 = _prefix "OBI_0000140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000143"></see>
    /// </summary>
    let OBI_0000143 = _prefix "OBI_0000143"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000220"></see>
    /// </summary>
    let OBI_0000220 = _prefix "OBI_0000220"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000144"></see>
    /// </summary>
    let OBI_0000144 = _prefix "OBI_0000144"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000145"></see>
    /// </summary>
    let OBI_0000145 = _prefix "OBI_0000145"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000146"></see>
    /// </summary>
    let OBI_0000146 = _prefix "OBI_0000146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000151"></see>
    /// </summary>
    let OBI_0000151 = _prefix "OBI_0000151"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000378"></see>
    /// </summary>
    let OBI_0000378 = _prefix "OBI_0000378"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000153"></see>
    /// </summary>
    let OBI_0000153 = _prefix "OBI_0000153"
    /// <summary>
    /// The extent of a 'cultured cell population' is restricted only in that all cell members must share a propagation history (ie be derived through a common lineage of passages from an initial culture). In being defined in this way, this class can be used to refer to the populations that researchers actually use in the practice of science - ie are the inputs to culturing, experimentation, and sharing. The cells in such populations will be a relatively uniform population as they have experienced similar selective pressures due to their continuous co-propagation. And this population will also have a single passage number, again owing to their common passaging history. Cultured cell populations represent only a collection of cells (ie do not include media, culture dishes, etc), and include populations of cultured unicellular organisms or cultured multicellular organism cells. They can exist under active culture, stored in a quiescent state for future use, or applied experimentally.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0100060"></see></summary>
    let OBI_0100060 = _prefix "OBI_0100060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000154"></see>
    /// </summary>
    let OBI_0000154 = _prefix "OBI_0000154"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000158"></see>
    /// </summary>
    let OBI_0000158 = _prefix "OBI_0000158"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000161"></see>
    /// </summary>
    let OBI_0000161 = _prefix "OBI_0000161"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000162"></see>
    /// </summary>
    let OBI_0000162 = _prefix "OBI_0000162"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000204"></see>
    /// </summary>
    let OBI_0000204 = _prefix "OBI_0000204"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000163"></see>
    /// </summary>
    let OBI_0000163 = _prefix "OBI_0000163"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000164"></see>
    /// </summary>
    let OBI_0000164 = _prefix "OBI_0000164"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000731"></see>
    /// </summary>
    let OBI_0000731 = _prefix "OBI_0000731"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600064"></see>
    /// </summary>
    let OBI_0600064 = _prefix "OBI_0600064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000167"></see>
    /// </summary>
    let OBI_0000167 = _prefix "OBI_0000167"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000169"></see>
    /// </summary>
    let OBI_0000169 = _prefix "OBI_0000169"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000214"></see>
    /// </summary>
    let OBI_0000214 = _prefix "OBI_0000214"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000171"></see>
    /// </summary>
    let OBI_0000171 = _prefix "OBI_0000171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000172"></see>
    /// </summary>
    let OBI_0000172 = _prefix "OBI_0000172"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000174"></see>
    /// </summary>
    let OBI_0000174 = _prefix "OBI_0000174"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000175"></see>
    /// </summary>
    let OBI_0000175 = _prefix "OBI_0000175"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000181"></see>
    /// </summary>
    let OBI_0000181 = _prefix "OBI_0000181"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000182"></see>
    /// </summary>
    let OBI_0000182 = _prefix "OBI_0000182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600045"></see>
    /// </summary>
    let OBI_0600045 = _prefix "OBI_0600045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000566"></see>
    /// </summary>
    let OBI_0000566 = _prefix "OBI_0000566"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001155"></see>
    /// </summary>
    let OBI_0001155 = _prefix "OBI_0001155"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000185"></see>
    /// </summary>
    let OBI_0000185 = _prefix "OBI_0000185"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000186"></see>
    /// </summary>
    let OBI_0000186 = _prefix "OBI_0000186"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000188"></see>
    /// </summary>
    let OBI_0000188 = _prefix "OBI_0000188"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000192"></see>
    /// </summary>
    let OBI_0000192 = _prefix "OBI_0000192"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000196"></see>
    /// </summary>
    let OBI_0000196 = _prefix "OBI_0000196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_00001975"></see>
    /// </summary>
    let OBI_00001975 = _prefix "OBI_00001975"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000690"></see>
    /// </summary>
    let OBI_0000690 = _prefix "OBI_0000690"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000198"></see>
    /// </summary>
    let OBI_0000198 = _prefix "OBI_0000198"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000201"></see>
    /// </summary>
    let OBI_0000201 = _prefix "OBI_0000201"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001741"></see>
    /// </summary>
    let PATO_0001741 = _prefix "PATO_0001741"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000833"></see>
    /// </summary>
    let OBI_0000833 = _prefix "OBI_0000833"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000205"></see>
    /// </summary>
    let OBI_0000205 = _prefix "OBI_0000205"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000207"></see>
    /// </summary>
    let OBI_0000207 = _prefix "OBI_0000207"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000210"></see>
    /// </summary>
    let OBI_0000210 = _prefix "OBI_0000210"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000211"></see>
    /// </summary>
    let OBI_0000211 = _prefix "OBI_0000211"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000213"></see>
    /// </summary>
    let OBI_0000213 = _prefix "OBI_0000213"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000215"></see>
    /// </summary>
    let OBI_0000215 = _prefix "OBI_0000215"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000218"></see>
    /// </summary>
    let OBI_0000218 = _prefix "OBI_0000218"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000219"></see>
    /// </summary>
    let OBI_0000219 = _prefix "OBI_0000219"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100051"></see>
    /// </summary>
    let OBI_0100051 = _prefix "OBI_0100051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000221"></see>
    /// </summary>
    let OBI_0000221 = _prefix "OBI_0000221"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000223"></see>
    /// </summary>
    let OBI_0000223 = _prefix "OBI_0000223"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000224"></see>
    /// </summary>
    let OBI_0000224 = _prefix "OBI_0000224"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000227"></see>
    /// </summary>
    let OBI_0000227 = _prefix "OBI_0000227"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000231"></see>
    /// </summary>
    let OBI_0000231 = _prefix "OBI_0000231"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000232"></see>
    /// </summary>
    let OBI_0000232 = _prefix "OBI_0000232"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000233"></see>
    /// </summary>
    let OBI_0000233 = _prefix "OBI_0000233"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000234"></see>
    /// </summary>
    let OBI_0000234 = _prefix "OBI_0000234"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500001"></see>
    /// </summary>
    let OBI_0500001 = _prefix "OBI_0500001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000235"></see>
    /// </summary>
    let OBI_0000235 = _prefix "OBI_0000235"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000237"></see>
    /// </summary>
    let OBI_0000237 = _prefix "OBI_0000237"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000243"></see>
    /// </summary>
    let OBI_0000243 = _prefix "OBI_0000243"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000248"></see>
    /// </summary>
    let OBI_0000248 = _prefix "OBI_0000248"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000249"></see>
    /// </summary>
    let OBI_0000249 = _prefix "OBI_0000249"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000251"></see>
    /// </summary>
    let OBI_0000251 = _prefix "OBI_0000251"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000252"></see>
    /// </summary>
    let OBI_0000252 = _prefix "OBI_0000252"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000253"></see>
    /// </summary>
    let OBI_0000253 = _prefix "OBI_0000253"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000257"></see>
    /// </summary>
    let OBI_0000257 = _prefix "OBI_0000257"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0666667"></see>
    /// </summary>
    let OBI_0666667 = _prefix "OBI_0666667"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000260"></see>
    /// </summary>
    let OBI_0000260 = _prefix "OBI_0000260"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000264"></see>
    /// </summary>
    let OBI_0000264 = _prefix "OBI_0000264"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000268"></see>
    /// </summary>
    let OBI_0000268 = _prefix "OBI_0000268"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000269"></see>
    /// </summary>
    let OBI_0000269 = _prefix "OBI_0000269"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000272"></see>
    /// </summary>
    let OBI_0000272 = _prefix "OBI_0000272"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000274"></see>
    /// </summary>
    let OBI_0000274 = _prefix "OBI_0000274"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000652"></see>
    /// </summary>
    let OBI_0000652 = _prefix "OBI_0000652"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000319"></see>
    /// </summary>
    let OBI_0000319 = _prefix "OBI_0000319"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000444"></see>
    /// </summary>
    let OBI_0000444 = _prefix "OBI_0000444"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001025"></see>
    /// </summary>
    let RO_0001025 = _prefix "RO_0001025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000434"></see>
    /// </summary>
    let OBI_0000434 = _prefix "OBI_0000434"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000275"></see>
    /// </summary>
    let OBI_0000275 = _prefix "OBI_0000275"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000081"></see>
    /// </summary>
    let RO_0000081 = _prefix "RO_0000081"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002444"></see>
    /// </summary>
    let OBI_0002444 = _prefix "OBI_0002444"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000278"></see>
    /// </summary>
    let OBI_0000278 = _prefix "OBI_0000278"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OGMS_0000063"></see>
    /// </summary>
    let OGMS_0000063 = _prefix "OGMS_0000063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000281"></see>
    /// </summary>
    let OBI_0000281 = _prefix "OBI_0000281"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000426"></see>
    /// </summary>
    let OBI_0000426 = _prefix "OBI_0000426"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000429"></see>
    /// </summary>
    let OBI_0000429 = _prefix "OBI_0000429"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000422"></see>
    /// </summary>
    let OBI_0000422 = _prefix "OBI_0000422"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002358"></see>
    /// </summary>
    let UBERON_0002358 = _prefix "UBERON_0002358"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000286"></see>
    /// </summary>
    let OBI_0000286 = _prefix "OBI_0000286"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600034"></see>
    /// </summary>
    let OBI_0600034 = _prefix "OBI_0600034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000288"></see>
    /// </summary>
    let OBI_0000288 = _prefix "OBI_0000288"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000291"></see>
    /// </summary>
    let OBI_0000291 = _prefix "OBI_0000291"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001146"></see>
    /// </summary>
    let OBI_0001146 = _prefix "OBI_0001146"
    /// <summary>
    /// PLace_holder for sequence ontology term
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000794"></see></summary>
    let OBI_0000794 = _prefix "OBI_0000794"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000292"></see>
    /// </summary>
    let OBI_0000292 = _prefix "OBI_0000292"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200140"></see>
    /// </summary>
    let OBI_0200140 = _prefix "OBI_0200140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000295"></see>
    /// </summary>
    let OBI_0000295 = _prefix "OBI_0000295"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000294"></see>
    /// </summary>
    let OBI_0000294 = _prefix "OBI_0000294"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000056"></see>
    /// </summary>
    let RO_0000056 = _prefix "RO_0000056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000296"></see>
    /// </summary>
    let OBI_0000296 = _prefix "OBI_0000296"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000297"></see>
    /// </summary>
    let OBI_0000297 = _prefix "OBI_0000297"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000298"></see>
    /// </summary>
    let OBI_0000298 = _prefix "OBI_0000298"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000300"></see>
    /// </summary>
    let OBI_0000300 = _prefix "OBI_0000300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000301"></see>
    /// </summary>
    let OBI_0000301 = _prefix "OBI_0000301"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000304"></see>
    /// </summary>
    let OBI_0000304 = _prefix "OBI_0000304"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000306"></see>
    /// </summary>
    let OBI_0000306 = _prefix "OBI_0000306"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000307"></see>
    /// </summary>
    let OBI_0000307 = _prefix "OBI_0000307"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000308"></see>
    /// </summary>
    let OBI_0000308 = _prefix "OBI_0000308"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000309"></see>
    /// </summary>
    let OBI_0000309 = _prefix "OBI_0000309"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000310"></see>
    /// </summary>
    let OBI_0000310 = _prefix "OBI_0000310"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000311"></see>
    /// </summary>
    let OBI_0000311 = _prefix "OBI_0000311"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000313"></see>
    /// </summary>
    let OBI_0000313 = _prefix "OBI_0000313"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000314"></see>
    /// </summary>
    let OBI_0000314 = _prefix "OBI_0000314"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000315"></see>
    /// </summary>
    let OBI_0000315 = _prefix "OBI_0000315"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000316"></see>
    /// </summary>
    let OBI_0000316 = _prefix "OBI_0000316"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000317"></see>
    /// </summary>
    let OBI_0000317 = _prefix "OBI_0000317"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000318"></see>
    /// </summary>
    let OBI_0000318 = _prefix "OBI_0000318"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302905"></see>
    /// </summary>
    let OBI_0302905 = _prefix "OBI_0302905"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302732"></see>
    /// </summary>
    let OBI_0302732 = _prefix "OBI_0302732"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000321"></see>
    /// </summary>
    let OBI_0000321 = _prefix "OBI_0000321"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000322"></see>
    /// </summary>
    let OBI_0000322 = _prefix "OBI_0000322"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000323"></see>
    /// </summary>
    let OBI_0000323 = _prefix "OBI_0000323"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000324"></see>
    /// </summary>
    let OBI_0000324 = _prefix "OBI_0000324"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000325"></see>
    /// </summary>
    let OBI_0000325 = _prefix "OBI_0000325"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000326"></see>
    /// </summary>
    let OBI_0000326 = _prefix "OBI_0000326"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000327"></see>
    /// </summary>
    let OBI_0000327 = _prefix "OBI_0000327"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000329"></see>
    /// </summary>
    let OBI_0000329 = _prefix "OBI_0000329"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000330"></see>
    /// </summary>
    let OBI_0000330 = _prefix "OBI_0000330"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000332"></see>
    /// </summary>
    let OBI_0000332 = _prefix "OBI_0000332"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000340"></see>
    /// </summary>
    let OBI_0000340 = _prefix "OBI_0000340"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000341"></see>
    /// </summary>
    let OBI_0000341 = _prefix "OBI_0000341"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400168"></see>
    /// </summary>
    let OBI_0400168 = _prefix "OBI_0400168"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100066"></see>
    /// </summary>
    let OBI_0100066 = _prefix "OBI_0100066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000684"></see>
    /// </summary>
    let OBI_0000684 = _prefix "OBI_0000684"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000343"></see>
    /// </summary>
    let OBI_0000343 = _prefix "OBI_0000343"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000355"></see>
    /// </summary>
    let OBI_0000355 = _prefix "OBI_0000355"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000356"></see>
    /// </summary>
    let OBI_0000356 = _prefix "OBI_0000356"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000385"></see>
    /// </summary>
    let OBI_0000385 = _prefix "OBI_0000385"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000365"></see>
    /// </summary>
    let OBI_0000365 = _prefix "OBI_0000365"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000366"></see>
    /// </summary>
    let OBI_0000366 = _prefix "OBI_0000366"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000367"></see>
    /// </summary>
    let OBI_0000367 = _prefix "OBI_0000367"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000374"></see>
    /// </summary>
    let OBI_0000374 = _prefix "OBI_0000374"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000368"></see>
    /// </summary>
    let OBI_0000368 = _prefix "OBI_0000368"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000369"></see>
    /// </summary>
    let OBI_0000369 = _prefix "OBI_0000369"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000371"></see>
    /// </summary>
    let OBI_0000371 = _prefix "OBI_0000371"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000373"></see>
    /// </summary>
    let OBI_0000373 = _prefix "OBI_0000373"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000375"></see>
    /// </summary>
    let OBI_0000375 = _prefix "OBI_0000375"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000376"></see>
    /// </summary>
    let OBI_0000376 = _prefix "OBI_0000376"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000377"></see>
    /// </summary>
    let OBI_0000377 = _prefix "OBI_0000377"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000380"></see>
    /// </summary>
    let OBI_0000380 = _prefix "OBI_0000380"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000381"></see>
    /// </summary>
    let OBI_0000381 = _prefix "OBI_0000381"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000383"></see>
    /// </summary>
    let OBI_0000383 = _prefix "OBI_0000383"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000384"></see>
    /// </summary>
    let OBI_0000384 = _prefix "OBI_0000384"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000391"></see>
    /// </summary>
    let OBI_0000391 = _prefix "OBI_0000391"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000387"></see>
    /// </summary>
    let OBI_0000387 = _prefix "OBI_0000387"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000388"></see>
    /// </summary>
    let OBI_0000388 = _prefix "OBI_0000388"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000389"></see>
    /// </summary>
    let OBI_0000389 = _prefix "OBI_0000389"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000390"></see>
    /// </summary>
    let OBI_0000390 = _prefix "OBI_0000390"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000392"></see>
    /// </summary>
    let OBI_0000392 = _prefix "OBI_0000392"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000455"></see>
    /// </summary>
    let OBI_0000455 = _prefix "OBI_0000455"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000393"></see>
    /// </summary>
    let OBI_0000393 = _prefix "OBI_0000393"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000394"></see>
    /// </summary>
    let OBI_0000394 = _prefix "OBI_0000394"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000395"></see>
    /// </summary>
    let OBI_0000395 = _prefix "OBI_0000395"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000397"></see>
    /// </summary>
    let OBI_0000397 = _prefix "OBI_0000397"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001007"></see>
    /// </summary>
    let OBI_0001007 = _prefix "OBI_0001007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000398"></see>
    /// </summary>
    let OBI_0000398 = _prefix "OBI_0000398"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000399"></see>
    /// </summary>
    let OBI_0000399 = _prefix "OBI_0000399"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000400"></see>
    /// </summary>
    let OBI_0000400 = _prefix "OBI_0000400"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000403"></see>
    /// </summary>
    let OBI_0000403 = _prefix "OBI_0000403"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000404"></see>
    /// </summary>
    let OBI_0000404 = _prefix "OBI_0000404"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000405"></see>
    /// </summary>
    let OBI_0000405 = _prefix "OBI_0000405"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000415"></see>
    /// </summary>
    let OBI_0000415 = _prefix "OBI_0000415"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000857"></see>
    /// </summary>
    let OBI_0000857 = _prefix "OBI_0000857"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000406"></see>
    /// </summary>
    let OBI_0000406 = _prefix "OBI_0000406"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000809"></see>
    /// </summary>
    let OBI_0000809 = _prefix "OBI_0000809"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000407"></see>
    /// </summary>
    let OBI_0000407 = _prefix "OBI_0000407"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0666666"></see>
    /// </summary>
    let OBI_0666666 = _prefix "OBI_0666666"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000409"></see>
    /// </summary>
    let OBI_0000409 = _prefix "OBI_0000409"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000410"></see>
    /// </summary>
    let OBI_0000410 = _prefix "OBI_0000410"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000430"></see>
    /// </summary>
    let OBI_0000430 = _prefix "OBI_0000430"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000411"></see>
    /// </summary>
    let OBI_0000411 = _prefix "OBI_0000411"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000413"></see>
    /// </summary>
    let OBI_0000413 = _prefix "OBI_0000413"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600058"></see>
    /// </summary>
    let OBI_0600058 = _prefix "OBI_0600058"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000416"></see>
    /// </summary>
    let OBI_0000416 = _prefix "OBI_0000416"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000418"></see>
    /// </summary>
    let OBI_0000418 = _prefix "OBI_0000418"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100017"></see>
    /// </summary>
    let OBI_0100017 = _prefix "OBI_0100017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000443"></see>
    /// </summary>
    let OBI_0000443 = _prefix "OBI_0000443"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000419"></see>
    /// </summary>
    let OBI_0000419 = _prefix "OBI_0000419"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000420"></see>
    /// </summary>
    let OBI_0000420 = _prefix "OBI_0000420"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000423"></see>
    /// </summary>
    let OBI_0000423 = _prefix "OBI_0000423"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302884"></see>
    /// </summary>
    let OBI_0302884 = _prefix "OBI_0302884"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000424"></see>
    /// </summary>
    let OBI_0000424 = _prefix "OBI_0000424"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000880"></see>
    /// </summary>
    let OBI_0000880 = _prefix "OBI_0000880"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001331"></see>
    /// </summary>
    let OBI_0001331 = _prefix "OBI_0001331"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000425"></see>
    /// </summary>
    let OBI_0000425 = _prefix "OBI_0000425"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200166"></see>
    /// </summary>
    let OBI_0200166 = _prefix "OBI_0200166"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600007"></see>
    /// </summary>
    let OBI_0600007 = _prefix "OBI_0600007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000988"></see>
    /// </summary>
    let SO_0000988 = _prefix "SO_0000988"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000086"></see>
    /// </summary>
    let RO_0000086 = _prefix "RO_0000086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000431"></see>
    /// </summary>
    let OBI_0000431 = _prefix "OBI_0000431"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000432"></see>
    /// </summary>
    let OBI_0000432 = _prefix "OBI_0000432"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302890"></see>
    /// </summary>
    let OBI_0302890 = _prefix "OBI_0302890"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000433"></see>
    /// </summary>
    let OBI_0000433 = _prefix "OBI_0000433"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001051"></see>
    /// </summary>
    let OBI_0001051 = _prefix "OBI_0001051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000686"></see>
    /// </summary>
    let OBI_0000686 = _prefix "OBI_0000686"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000435"></see>
    /// </summary>
    let OBI_0000435 = _prefix "OBI_0000435"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001305"></see>
    /// </summary>
    let OBI_0001305 = _prefix "OBI_0001305"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000436"></see>
    /// </summary>
    let OBI_0000436 = _prefix "OBI_0000436"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000437"></see>
    /// </summary>
    let OBI_0000437 = _prefix "OBI_0000437"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000438"></see>
    /// </summary>
    let OBI_0000438 = _prefix "OBI_0000438"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000439"></see>
    /// </summary>
    let OBI_0000439 = _prefix "OBI_0000439"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000442"></see>
    /// </summary>
    let OBI_0000442 = _prefix "OBI_0000442"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000445"></see>
    /// </summary>
    let OBI_0000445 = _prefix "OBI_0000445"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000446"></see>
    /// </summary>
    let OBI_0000446 = _prefix "OBI_0000446"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000447"></see>
    /// </summary>
    let OBI_0000447 = _prefix "OBI_0000447"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000448"></see>
    /// </summary>
    let OBI_0000448 = _prefix "OBI_0000448"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000449"></see>
    /// </summary>
    let OBI_0000449 = _prefix "OBI_0000449"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000450"></see>
    /// </summary>
    let OBI_0000450 = _prefix "OBI_0000450"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000451"></see>
    /// </summary>
    let OBI_0000451 = _prefix "OBI_0000451"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200169"></see>
    /// </summary>
    let OBI_0200169 = _prefix "OBI_0200169"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000079"></see>
    /// </summary>
    let RO_0000079 = _prefix "RO_0000079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000454"></see>
    /// </summary>
    let OBI_0000454 = _prefix "OBI_0000454"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000457"></see>
    /// </summary>
    let OBI_0000457 = _prefix "OBI_0000457"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000458"></see>
    /// </summary>
    let OBI_0000458 = _prefix "OBI_0000458"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000459"></see>
    /// </summary>
    let OBI_0000459 = _prefix "OBI_0000459"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000461"></see>
    /// </summary>
    let OBI_0000461 = _prefix "OBI_0000461"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000462"></see>
    /// </summary>
    let OBI_0000462 = _prefix "OBI_0000462"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000571"></see>
    /// </summary>
    let OBI_0000571 = _prefix "OBI_0000571"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000463"></see>
    /// </summary>
    let OBI_0000463 = _prefix "OBI_0000463"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000464"></see>
    /// </summary>
    let OBI_0000464 = _prefix "OBI_0000464"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000555"></see>
    /// </summary>
    let OBI_0000555 = _prefix "OBI_0000555"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000465"></see>
    /// </summary>
    let OBI_0000465 = _prefix "OBI_0000465"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000466"></see>
    /// </summary>
    let OBI_0000466 = _prefix "OBI_0000466"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000637"></see>
    /// </summary>
    let OBI_0000637 = _prefix "OBI_0000637"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000467"></see>
    /// </summary>
    let OBI_0000467 = _prefix "OBI_0000467"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000597"></see>
    /// </summary>
    let OBI_0000597 = _prefix "OBI_0000597"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000468"></see>
    /// </summary>
    let OBI_0000468 = _prefix "OBI_0000468"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000469"></see>
    /// </summary>
    let OBI_0000469 = _prefix "OBI_0000469"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000485"></see>
    /// </summary>
    let OBI_0000485 = _prefix "OBI_0000485"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000470"></see>
    /// </summary>
    let OBI_0000470 = _prefix "OBI_0000470"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000473"></see>
    /// </summary>
    let OBI_0000473 = _prefix "OBI_0000473"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000474"></see>
    /// </summary>
    let OBI_0000474 = _prefix "OBI_0000474"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000589"></see>
    /// </summary>
    let OBI_0000589 = _prefix "OBI_0000589"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000475"></see>
    /// </summary>
    let OBI_0000475 = _prefix "OBI_0000475"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000498"></see>
    /// </summary>
    let OBI_0000498 = _prefix "OBI_0000498"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000476"></see>
    /// </summary>
    let OBI_0000476 = _prefix "OBI_0000476"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000504"></see>
    /// </summary>
    let OBI_0000504 = _prefix "OBI_0000504"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000477"></see>
    /// </summary>
    let OBI_0000477 = _prefix "OBI_0000477"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000611"></see>
    /// </summary>
    let OBI_0000611 = _prefix "OBI_0000611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000478"></see>
    /// </summary>
    let OBI_0000478 = _prefix "OBI_0000478"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000479"></see>
    /// </summary>
    let OBI_0000479 = _prefix "OBI_0000479"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000516"></see>
    /// </summary>
    let OBI_0000516 = _prefix "OBI_0000516"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000480"></see>
    /// </summary>
    let OBI_0000480 = _prefix "OBI_0000480"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000561"></see>
    /// </summary>
    let OBI_0000561 = _prefix "OBI_0000561"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000481"></see>
    /// </summary>
    let OBI_0000481 = _prefix "OBI_0000481"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000482"></see>
    /// </summary>
    let OBI_0000482 = _prefix "OBI_0000482"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000483"></see>
    /// </summary>
    let OBI_0000483 = _prefix "OBI_0000483"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000599"></see>
    /// </summary>
    let OBI_0000599 = _prefix "OBI_0000599"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000484"></see>
    /// </summary>
    let OBI_0000484 = _prefix "OBI_0000484"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000486"></see>
    /// </summary>
    let OBI_0000486 = _prefix "OBI_0000486"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000487"></see>
    /// </summary>
    let OBI_0000487 = _prefix "OBI_0000487"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000489"></see>
    /// </summary>
    let OBI_0000489 = _prefix "OBI_0000489"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000490"></see>
    /// </summary>
    let OBI_0000490 = _prefix "OBI_0000490"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000560"></see>
    /// </summary>
    let OBI_0000560 = _prefix "OBI_0000560"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000491"></see>
    /// </summary>
    let OBI_0000491 = _prefix "OBI_0000491"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000492"></see>
    /// </summary>
    let OBI_0000492 = _prefix "OBI_0000492"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000493"></see>
    /// </summary>
    let OBI_0000493 = _prefix "OBI_0000493"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000494"></see>
    /// </summary>
    let OBI_0000494 = _prefix "OBI_0000494"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000495"></see>
    /// </summary>
    let OBI_0000495 = _prefix "OBI_0000495"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000496"></see>
    /// </summary>
    let OBI_0000496 = _prefix "OBI_0000496"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000497"></see>
    /// </summary>
    let OBI_0000497 = _prefix "OBI_0000497"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000499"></see>
    /// </summary>
    let OBI_0000499 = _prefix "OBI_0000499"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000500"></see>
    /// </summary>
    let OBI_0000500 = _prefix "OBI_0000500"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000501"></see>
    /// </summary>
    let OBI_0000501 = _prefix "OBI_0000501"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000503"></see>
    /// </summary>
    let OBI_0000503 = _prefix "OBI_0000503"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000596"></see>
    /// </summary>
    let OBI_0000596 = _prefix "OBI_0000596"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000505"></see>
    /// </summary>
    let OBI_0000505 = _prefix "OBI_0000505"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000506"></see>
    /// </summary>
    let OBI_0000506 = _prefix "OBI_0000506"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000507"></see>
    /// </summary>
    let OBI_0000507 = _prefix "OBI_0000507"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000542"></see>
    /// </summary>
    let OBI_0000542 = _prefix "OBI_0000542"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000508"></see>
    /// </summary>
    let OBI_0000508 = _prefix "OBI_0000508"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000509"></see>
    /// </summary>
    let OBI_0000509 = _prefix "OBI_0000509"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000510"></see>
    /// </summary>
    let OBI_0000510 = _prefix "OBI_0000510"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000511"></see>
    /// </summary>
    let OBI_0000511 = _prefix "OBI_0000511"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000601"></see>
    /// </summary>
    let OBI_0000601 = _prefix "OBI_0000601"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000512"></see>
    /// </summary>
    let OBI_0000512 = _prefix "OBI_0000512"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000681"></see>
    /// </summary>
    let OBI_0000681 = _prefix "OBI_0000681"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000513"></see>
    /// </summary>
    let OBI_0000513 = _prefix "OBI_0000513"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000514"></see>
    /// </summary>
    let OBI_0000514 = _prefix "OBI_0000514"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000515"></see>
    /// </summary>
    let OBI_0000515 = _prefix "OBI_0000515"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000517"></see>
    /// </summary>
    let OBI_0000517 = _prefix "OBI_0000517"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000518"></see>
    /// </summary>
    let OBI_0000518 = _prefix "OBI_0000518"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000519"></see>
    /// </summary>
    let OBI_0000519 = _prefix "OBI_0000519"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000520"></see>
    /// </summary>
    let OBI_0000520 = _prefix "OBI_0000520"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000576"></see>
    /// </summary>
    let OBI_0000576 = _prefix "OBI_0000576"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000655"></see>
    /// </summary>
    let OBI_0000655 = _prefix "OBI_0000655"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000521"></see>
    /// </summary>
    let OBI_0000521 = _prefix "OBI_0000521"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000522"></see>
    /// </summary>
    let OBI_0000522 = _prefix "OBI_0000522"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000523"></see>
    /// </summary>
    let OBI_0000523 = _prefix "OBI_0000523"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000524"></see>
    /// </summary>
    let OBI_0000524 = _prefix "OBI_0000524"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000525"></see>
    /// </summary>
    let OBI_0000525 = _prefix "OBI_0000525"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000526"></see>
    /// </summary>
    let OBI_0000526 = _prefix "OBI_0000526"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000527"></see>
    /// </summary>
    let OBI_0000527 = _prefix "OBI_0000527"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000528"></see>
    /// </summary>
    let OBI_0000528 = _prefix "OBI_0000528"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000529"></see>
    /// </summary>
    let OBI_0000529 = _prefix "OBI_0000529"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000530"></see>
    /// </summary>
    let OBI_0000530 = _prefix "OBI_0000530"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000531"></see>
    /// </summary>
    let OBI_0000531 = _prefix "OBI_0000531"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000532"></see>
    /// </summary>
    let OBI_0000532 = _prefix "OBI_0000532"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000533"></see>
    /// </summary>
    let OBI_0000533 = _prefix "OBI_0000533"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000534"></see>
    /// </summary>
    let OBI_0000534 = _prefix "OBI_0000534"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000535"></see>
    /// </summary>
    let OBI_0000535 = _prefix "OBI_0000535"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000618"></see>
    /// </summary>
    let OBI_0000618 = _prefix "OBI_0000618"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000536"></see>
    /// </summary>
    let OBI_0000536 = _prefix "OBI_0000536"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000537"></see>
    /// </summary>
    let OBI_0000537 = _prefix "OBI_0000537"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001404"></see>
    /// </summary>
    let OBI_0001404 = _prefix "OBI_0001404"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000538"></see>
    /// </summary>
    let OBI_0000538 = _prefix "OBI_0000538"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000592"></see>
    /// </summary>
    let OBI_0000592 = _prefix "OBI_0000592"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000539"></see>
    /// </summary>
    let OBI_0000539 = _prefix "OBI_0000539"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000540"></see>
    /// </summary>
    let OBI_0000540 = _prefix "OBI_0000540"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000541"></see>
    /// </summary>
    let OBI_0000541 = _prefix "OBI_0000541"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000543"></see>
    /// </summary>
    let OBI_0000543 = _prefix "OBI_0000543"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000544"></see>
    /// </summary>
    let OBI_0000544 = _prefix "OBI_0000544"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000545"></see>
    /// </summary>
    let OBI_0000545 = _prefix "OBI_0000545"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000546"></see>
    /// </summary>
    let OBI_0000546 = _prefix "OBI_0000546"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000547"></see>
    /// </summary>
    let OBI_0000547 = _prefix "OBI_0000547"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000548"></see>
    /// </summary>
    let OBI_0000548 = _prefix "OBI_0000548"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000178"></see>
    /// </summary>
    let UBERON_0000178 = _prefix "UBERON_0000178"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000549"></see>
    /// </summary>
    let OBI_0000549 = _prefix "OBI_0000549"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000550"></see>
    /// </summary>
    let OBI_0000550 = _prefix "OBI_0000550"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000551"></see>
    /// </summary>
    let OBI_0000551 = _prefix "OBI_0000551"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000552"></see>
    /// </summary>
    let OBI_0000552 = _prefix "OBI_0000552"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600028"></see>
    /// </summary>
    let OBI_0600028 = _prefix "OBI_0600028"
    /// <summary>
    /// X immediately_preceded_by Y iff: end(X) simultaneous_with start(Y)
    /// <see href="http://purl.obolibrary.org/obo/RO_0002087"></see></summary>
    let RO_0002087 = _prefix "RO_0002087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000553"></see>
    /// </summary>
    let OBI_0000553 = _prefix "OBI_0000553"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000554"></see>
    /// </summary>
    let OBI_0000554 = _prefix "OBI_0000554"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000556"></see>
    /// </summary>
    let OBI_0000556 = _prefix "OBI_0000556"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000557"></see>
    /// </summary>
    let OBI_0000557 = _prefix "OBI_0000557"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000558"></see>
    /// </summary>
    let OBI_0000558 = _prefix "OBI_0000558"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000559"></see>
    /// </summary>
    let OBI_0000559 = _prefix "OBI_0000559"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000562"></see>
    /// </summary>
    let OBI_0000562 = _prefix "OBI_0000562"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000563"></see>
    /// </summary>
    let OBI_0000563 = _prefix "OBI_0000563"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000564"></see>
    /// </summary>
    let OBI_0000564 = _prefix "OBI_0000564"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000565"></see>
    /// </summary>
    let OBI_0000565 = _prefix "OBI_0000565"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000567"></see>
    /// </summary>
    let OBI_0000567 = _prefix "OBI_0000567"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000568"></see>
    /// </summary>
    let OBI_0000568 = _prefix "OBI_0000568"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000569"></see>
    /// </summary>
    let OBI_0000569 = _prefix "OBI_0000569"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000570"></see>
    /// </summary>
    let OBI_0000570 = _prefix "OBI_0000570"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000572"></see>
    /// </summary>
    let OBI_0000572 = _prefix "OBI_0000572"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000573"></see>
    /// </summary>
    let OBI_0000573 = _prefix "OBI_0000573"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000574"></see>
    /// </summary>
    let OBI_0000574 = _prefix "OBI_0000574"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000575"></see>
    /// </summary>
    let OBI_0000575 = _prefix "OBI_0000575"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000577"></see>
    /// </summary>
    let OBI_0000577 = _prefix "OBI_0000577"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000578"></see>
    /// </summary>
    let OBI_0000578 = _prefix "OBI_0000578"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000579"></see>
    /// </summary>
    let OBI_0000579 = _prefix "OBI_0000579"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000580"></see>
    /// </summary>
    let OBI_0000580 = _prefix "OBI_0000580"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000581"></see>
    /// </summary>
    let OBI_0000581 = _prefix "OBI_0000581"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000582"></see>
    /// </summary>
    let OBI_0000582 = _prefix "OBI_0000582"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000583"></see>
    /// </summary>
    let OBI_0000583 = _prefix "OBI_0000583"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000584"></see>
    /// </summary>
    let OBI_0000584 = _prefix "OBI_0000584"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000586"></see>
    /// </summary>
    let OBI_0000586 = _prefix "OBI_0000586"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000588"></see>
    /// </summary>
    let OBI_0000588 = _prefix "OBI_0000588"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000590"></see>
    /// </summary>
    let OBI_0000590 = _prefix "OBI_0000590"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000591"></see>
    /// </summary>
    let OBI_0000591 = _prefix "OBI_0000591"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000593"></see>
    /// </summary>
    let OBI_0000593 = _prefix "OBI_0000593"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000594"></see>
    /// </summary>
    let OBI_0000594 = _prefix "OBI_0000594"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000595"></see>
    /// </summary>
    let OBI_0000595 = _prefix "OBI_0000595"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000598"></see>
    /// </summary>
    let OBI_0000598 = _prefix "OBI_0000598"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000600"></see>
    /// </summary>
    let OBI_0000600 = _prefix "OBI_0000600"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000602"></see>
    /// </summary>
    let OBI_0000602 = _prefix "OBI_0000602"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000603"></see>
    /// </summary>
    let OBI_0000603 = _prefix "OBI_0000603"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000604"></see>
    /// </summary>
    let OBI_0000604 = _prefix "OBI_0000604"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000605"></see>
    /// </summary>
    let OBI_0000605 = _prefix "OBI_0000605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000606"></see>
    /// </summary>
    let OBI_0000606 = _prefix "OBI_0000606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000607"></see>
    /// </summary>
    let OBI_0000607 = _prefix "OBI_0000607"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000608"></see>
    /// </summary>
    let OBI_0000608 = _prefix "OBI_0000608"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000609"></see>
    /// </summary>
    let OBI_0000609 = _prefix "OBI_0000609"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000610"></see>
    /// </summary>
    let OBI_0000610 = _prefix "OBI_0000610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000612"></see>
    /// </summary>
    let OBI_0000612 = _prefix "OBI_0000612"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000613"></see>
    /// </summary>
    let OBI_0000613 = _prefix "OBI_0000613"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000614"></see>
    /// </summary>
    let OBI_0000614 = _prefix "OBI_0000614"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000615"></see>
    /// </summary>
    let OBI_0000615 = _prefix "OBI_0000615"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000616"></see>
    /// </summary>
    let OBI_0000616 = _prefix "OBI_0000616"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000617"></see>
    /// </summary>
    let OBI_0000617 = _prefix "OBI_0000617"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000619"></see>
    /// </summary>
    let OBI_0000619 = _prefix "OBI_0000619"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000620"></see>
    /// </summary>
    let OBI_0000620 = _prefix "OBI_0000620"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000621"></see>
    /// </summary>
    let OBI_0000621 = _prefix "OBI_0000621"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000622"></see>
    /// </summary>
    let OBI_0000622 = _prefix "OBI_0000622"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000623"></see>
    /// </summary>
    let OBI_0000623 = _prefix "OBI_0000623"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000624"></see>
    /// </summary>
    let OBI_0000624 = _prefix "OBI_0000624"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000625"></see>
    /// </summary>
    let OBI_0000625 = _prefix "OBI_0000625"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000626"></see>
    /// </summary>
    let OBI_0000626 = _prefix "OBI_0000626"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600047"></see>
    /// </summary>
    let OBI_0600047 = _prefix "OBI_0600047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400103"></see>
    /// </summary>
    let OBI_0400103 = _prefix "OBI_0400103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001573"></see>
    /// </summary>
    let OBI_0001573 = _prefix "OBI_0001573"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000627"></see>
    /// </summary>
    let OBI_0000627 = _prefix "OBI_0000627"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000628"></see>
    /// </summary>
    let OBI_0000628 = _prefix "OBI_0000628"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000629"></see>
    /// </summary>
    let OBI_0000629 = _prefix "OBI_0000629"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000630"></see>
    /// </summary>
    let OBI_0000630 = _prefix "OBI_0000630"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000631"></see>
    /// </summary>
    let OBI_0000631 = _prefix "OBI_0000631"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000632"></see>
    /// </summary>
    let OBI_0000632 = _prefix "OBI_0000632"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000633"></see>
    /// </summary>
    let OBI_0000633 = _prefix "OBI_0000633"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000634"></see>
    /// </summary>
    let OBI_0000634 = _prefix "OBI_0000634"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002020"></see>
    /// </summary>
    let OBI_0002020 = _prefix "OBI_0002020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001234"></see>
    /// </summary>
    let OBI_0001234 = _prefix "OBI_0001234"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000635"></see>
    /// </summary>
    let OBI_0000635 = _prefix "OBI_0000635"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000636"></see>
    /// </summary>
    let OBI_0000636 = _prefix "OBI_0000636"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400107"></see>
    /// </summary>
    let OBI_0400107 = _prefix "OBI_0400107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000638"></see>
    /// </summary>
    let OBI_0000638 = _prefix "OBI_0000638"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000639"></see>
    /// </summary>
    let OBI_0000639 = _prefix "OBI_0000639"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000678"></see>
    /// </summary>
    let OBI_0000678 = _prefix "OBI_0000678"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000640"></see>
    /// </summary>
    let OBI_0000640 = _prefix "OBI_0000640"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000641"></see>
    /// </summary>
    let OBI_0000641 = _prefix "OBI_0000641"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000642"></see>
    /// </summary>
    let OBI_0000642 = _prefix "OBI_0000642"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000644"></see>
    /// </summary>
    let OBI_0000644 = _prefix "OBI_0000644"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000645"></see>
    /// </summary>
    let OBI_0000645 = _prefix "OBI_0000645"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000646"></see>
    /// </summary>
    let OBI_0000646 = _prefix "OBI_0000646"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000648"></see>
    /// </summary>
    let OBI_0000648 = _prefix "OBI_0000648"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200175"></see>
    /// </summary>
    let OBI_0200175 = _prefix "OBI_0200175"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000649"></see>
    /// </summary>
    let OBI_0000649 = _prefix "OBI_0000649"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200184"></see>
    /// </summary>
    let OBI_0200184 = _prefix "OBI_0200184"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000650"></see>
    /// </summary>
    let OBI_0000650 = _prefix "OBI_0000650"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200031"></see>
    /// </summary>
    let OBI_0200031 = _prefix "OBI_0200031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000651"></see>
    /// </summary>
    let OBI_0000651 = _prefix "OBI_0000651"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600005"></see>
    /// </summary>
    let OBI_0600005 = _prefix "OBI_0600005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001479"></see>
    /// </summary>
    let OBI_0001479 = _prefix "OBI_0001479"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001088"></see>
    /// </summary>
    let UBERON_0001088 = _prefix "UBERON_0001088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000653"></see>
    /// </summary>
    let OBI_0000653 = _prefix "OBI_0000653"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000656"></see>
    /// </summary>
    let OBI_0000656 = _prefix "OBI_0000656"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200072"></see>
    /// </summary>
    let OBI_0200072 = _prefix "OBI_0200072"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000658"></see>
    /// </summary>
    let OBI_0000658 = _prefix "OBI_0000658"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000660"></see>
    /// </summary>
    let OBI_0000660 = _prefix "OBI_0000660"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000666"></see>
    /// </summary>
    let OBI_0000666 = _prefix "OBI_0000666"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000661"></see>
    /// </summary>
    let OBI_0000661 = _prefix "OBI_0000661"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000662"></see>
    /// </summary>
    let OBI_0000662 = _prefix "OBI_0000662"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000668"></see>
    /// </summary>
    let OBI_0000668 = _prefix "OBI_0000668"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200179"></see>
    /// </summary>
    let OBI_0200179 = _prefix "OBI_0200179"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000664"></see>
    /// </summary>
    let OBI_0000664 = _prefix "OBI_0000664"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000891"></see>
    /// </summary>
    let OBI_0000891 = _prefix "OBI_0000891"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000665"></see>
    /// </summary>
    let OBI_0000665 = _prefix "OBI_0000665"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000916"></see>
    /// </summary>
    let OBI_0000916 = _prefix "OBI_0000916"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200173"></see>
    /// </summary>
    let OBI_0200173 = _prefix "OBI_0200173"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000667"></see>
    /// </summary>
    let OBI_0000667 = _prefix "OBI_0000667"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110179"></see>
    /// </summary>
    let OBI_1110179 = _prefix "OBI_1110179"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200186"></see>
    /// </summary>
    let OBI_0200186 = _prefix "OBI_0200186"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000669"></see>
    /// </summary>
    let OBI_0000669 = _prefix "OBI_0000669"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000671"></see>
    /// </summary>
    let OBI_0000671 = _prefix "OBI_0000671"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000465"></see>
    /// </summary>
    let UBERON_0000465 = _prefix "UBERON_0000465"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000747"></see>
    /// </summary>
    let OBI_0000747 = _prefix "OBI_0000747"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000740"></see>
    /// </summary>
    let OBI_0000740 = _prefix "OBI_0000740"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000673"></see>
    /// </summary>
    let OBI_0000673 = _prefix "OBI_0000673"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000675"></see>
    /// </summary>
    let OBI_0000675 = _prefix "OBI_0000675"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000674"></see>
    /// </summary>
    let OBI_0000674 = _prefix "OBI_0000674"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200181"></see>
    /// </summary>
    let OBI_0200181 = _prefix "OBI_0200181"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000676"></see>
    /// </summary>
    let OBI_0000676 = _prefix "OBI_0000676"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200182"></see>
    /// </summary>
    let OBI_0200182 = _prefix "OBI_0200182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000679"></see>
    /// </summary>
    let OBI_0000679 = _prefix "OBI_0000679"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200170"></see>
    /// </summary>
    let OBI_0200170 = _prefix "OBI_0200170"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000680"></see>
    /// </summary>
    let OBI_0000680 = _prefix "OBI_0000680"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000682"></see>
    /// </summary>
    let OBI_0000682 = _prefix "OBI_0000682"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000685"></see>
    /// </summary>
    let OBI_0000685 = _prefix "OBI_0000685"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302729"></see>
    /// </summary>
    let OBI_0302729 = _prefix "OBI_0302729"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000687"></see>
    /// </summary>
    let OBI_0000687 = _prefix "OBI_0000687"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000688"></see>
    /// </summary>
    let OBI_0000688 = _prefix "OBI_0000688"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000715"></see>
    /// </summary>
    let OBI_0000715 = _prefix "OBI_0000715"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000689"></see>
    /// </summary>
    let OBI_0000689 = _prefix "OBI_0000689"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000758"></see>
    /// </summary>
    let OBI_0000758 = _prefix "OBI_0000758"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000691"></see>
    /// </summary>
    let OBI_0000691 = _prefix "OBI_0000691"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000776"></see>
    /// </summary>
    let OBI_0000776 = _prefix "OBI_0000776"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000692"></see>
    /// </summary>
    let OBI_0000692 = _prefix "OBI_0000692"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000693"></see>
    /// </summary>
    let OBI_0000693 = _prefix "OBI_0000693"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001954"></see>
    /// </summary>
    let OBI_0001954 = _prefix "OBI_0001954"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000711"></see>
    /// </summary>
    let OBI_0000711 = _prefix "OBI_0000711"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000973"></see>
    /// </summary>
    let OBI_0000973 = _prefix "OBI_0000973"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000694"></see>
    /// </summary>
    let OBI_0000694 = _prefix "OBI_0000694"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000695"></see>
    /// </summary>
    let OBI_0000695 = _prefix "OBI_0000695"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000710"></see>
    /// </summary>
    let OBI_0000710 = _prefix "OBI_0000710"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000734"></see>
    /// </summary>
    let OBI_0000734 = _prefix "OBI_0000734"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000696"></see>
    /// </summary>
    let OBI_0000696 = _prefix "OBI_0000696"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000697"></see>
    /// </summary>
    let OBI_0000697 = _prefix "OBI_0000697"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000717"></see>
    /// </summary>
    let OBI_0000717 = _prefix "OBI_0000717"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000698"></see>
    /// </summary>
    let OBI_0000698 = _prefix "OBI_0000698"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000699"></see>
    /// </summary>
    let OBI_0000699 = _prefix "OBI_0000699"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000789"></see>
    /// </summary>
    let OBI_0000789 = _prefix "OBI_0000789"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000700"></see>
    /// </summary>
    let OBI_0000700 = _prefix "OBI_0000700"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000701"></see>
    /// </summary>
    let OBI_0000701 = _prefix "OBI_0000701"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000741"></see>
    /// </summary>
    let OBI_0000741 = _prefix "OBI_0000741"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200178"></see>
    /// </summary>
    let OBI_0200178 = _prefix "OBI_0200178"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000702"></see>
    /// </summary>
    let OBI_0000702 = _prefix "OBI_0000702"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000703"></see>
    /// </summary>
    let OBI_0000703 = _prefix "OBI_0000703"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000759"></see>
    /// </summary>
    let OBI_0000759 = _prefix "OBI_0000759"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000704"></see>
    /// </summary>
    let OBI_0000704 = _prefix "OBI_0000704"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000705"></see>
    /// </summary>
    let OBI_0000705 = _prefix "OBI_0000705"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000104"></see>
    /// </summary>
    let SO_0000104 = _prefix "SO_0000104"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000706"></see>
    /// </summary>
    let OBI_0000706 = _prefix "OBI_0000706"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000722"></see>
    /// </summary>
    let OBI_0000722 = _prefix "OBI_0000722"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000736"></see>
    /// </summary>
    let OBI_0000736 = _prefix "OBI_0000736"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000023089"></see>
    /// </summary>
    let PR_000023089 = _prefix "PR_000023089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000723"></see>
    /// </summary>
    let OBI_0000723 = _prefix "OBI_0000723"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000707"></see>
    /// </summary>
    let OBI_0000707 = _prefix "OBI_0000707"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000708"></see>
    /// </summary>
    let OBI_0000708 = _prefix "OBI_0000708"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000709"></see>
    /// </summary>
    let OBI_0000709 = _prefix "OBI_0000709"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000737"></see>
    /// </summary>
    let OBI_0000737 = _prefix "OBI_0000737"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000769"></see>
    /// </summary>
    let OBI_0000769 = _prefix "OBI_0000769"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000029"></see>
    /// </summary>
    let OBI_1000029 = _prefix "OBI_1000029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000712"></see>
    /// </summary>
    let OBI_0000712 = _prefix "OBI_0000712"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000725"></see>
    /// </summary>
    let OBI_0000725 = _prefix "OBI_0000725"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000718"></see>
    /// </summary>
    let OBI_0000718 = _prefix "OBI_0000718"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000713"></see>
    /// </summary>
    let OBI_0000713 = _prefix "OBI_0000713"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000714"></see>
    /// </summary>
    let OBI_0000714 = _prefix "OBI_0000714"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000716"></see>
    /// </summary>
    let OBI_0000716 = _prefix "OBI_0000716"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000757"></see>
    /// </summary>
    let OBI_0000757 = _prefix "OBI_0000757"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000719"></see>
    /// </summary>
    let OBI_0000719 = _prefix "OBI_0000719"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000720"></see>
    /// </summary>
    let OBI_0000720 = _prefix "OBI_0000720"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110092"></see>
    /// </summary>
    let OBI_1110092 = _prefix "OBI_1110092"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000721"></see>
    /// </summary>
    let OBI_0000721 = _prefix "OBI_0000721"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000724"></see>
    /// </summary>
    let OBI_0000724 = _prefix "OBI_0000724"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000726"></see>
    /// </summary>
    let OBI_0000726 = _prefix "OBI_0000726"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000727"></see>
    /// </summary>
    let OBI_0000727 = _prefix "OBI_0000727"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200172"></see>
    /// </summary>
    let OBI_0200172 = _prefix "OBI_0200172"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200171"></see>
    /// </summary>
    let OBI_0200171 = _prefix "OBI_0200171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000728"></see>
    /// </summary>
    let OBI_0000728 = _prefix "OBI_0000728"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400171"></see>
    /// </summary>
    let OBI_0400171 = _prefix "OBI_0400171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000729"></see>
    /// </summary>
    let OBI_0000729 = _prefix "OBI_0000729"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000730"></see>
    /// </summary>
    let OBI_0000730 = _prefix "OBI_0000730"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000732"></see>
    /// </summary>
    let OBI_0000732 = _prefix "OBI_0000732"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000735"></see>
    /// </summary>
    let OBI_0000735 = _prefix "OBI_0000735"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110108"></see>
    /// </summary>
    let OBI_1110108 = _prefix "OBI_1110108"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000738"></see>
    /// </summary>
    let OBI_0000738 = _prefix "OBI_0000738"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000742"></see>
    /// </summary>
    let OBI_0000742 = _prefix "OBI_0000742"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302892"></see>
    /// </summary>
    let OBI_0302892 = _prefix "OBI_0302892"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000739"></see>
    /// </summary>
    let OBI_0000739 = _prefix "OBI_0000739"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600050"></see>
    /// </summary>
    let OBI_0600050 = _prefix "OBI_0600050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000743"></see>
    /// </summary>
    let OBI_0000743 = _prefix "OBI_0000743"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000744"></see>
    /// </summary>
    let OBI_0000744 = _prefix "OBI_0000744"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000748"></see>
    /// </summary>
    let OBI_0000748 = _prefix "OBI_0000748"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000749"></see>
    /// </summary>
    let OBI_0000749 = _prefix "OBI_0000749"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000751"></see>
    /// </summary>
    let OBI_0000751 = _prefix "OBI_0000751"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000752"></see>
    /// </summary>
    let OBI_0000752 = _prefix "OBI_0000752"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000753"></see>
    /// </summary>
    let OBI_0000753 = _prefix "OBI_0000753"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000754"></see>
    /// </summary>
    let OBI_0000754 = _prefix "OBI_0000754"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000755"></see>
    /// </summary>
    let OBI_0000755 = _prefix "OBI_0000755"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200042"></see>
    /// </summary>
    let OBI_0200042 = _prefix "OBI_0200042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000756"></see>
    /// </summary>
    let OBI_0000756 = _prefix "OBI_0000756"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000760"></see>
    /// </summary>
    let OBI_0000760 = _prefix "OBI_0000760"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200051"></see>
    /// </summary>
    let OBI_0200051 = _prefix "OBI_0200051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000761"></see>
    /// </summary>
    let OBI_0000761 = _prefix "OBI_0000761"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000775"></see>
    /// </summary>
    let OBI_0000775 = _prefix "OBI_0000775"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000762"></see>
    /// </summary>
    let OBI_0000762 = _prefix "OBI_0000762"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000763"></see>
    /// </summary>
    let OBI_0000763 = _prefix "OBI_0000763"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200033"></see>
    /// </summary>
    let OBI_0200033 = _prefix "OBI_0200033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000764"></see>
    /// </summary>
    let OBI_0000764 = _prefix "OBI_0000764"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200041"></see>
    /// </summary>
    let OBI_0200041 = _prefix "OBI_0200041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000765"></see>
    /// </summary>
    let OBI_0000765 = _prefix "OBI_0000765"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000766"></see>
    /// </summary>
    let OBI_0000766 = _prefix "OBI_0000766"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000767"></see>
    /// </summary>
    let OBI_0000767 = _prefix "OBI_0000767"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000768"></see>
    /// </summary>
    let OBI_0000768 = _prefix "OBI_0000768"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000770"></see>
    /// </summary>
    let OBI_0000770 = _prefix "OBI_0000770"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000771"></see>
    /// </summary>
    let OBI_0000771 = _prefix "OBI_0000771"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000772"></see>
    /// </summary>
    let OBI_0000772 = _prefix "OBI_0000772"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000778"></see>
    /// </summary>
    let OBI_0000778 = _prefix "OBI_0000778"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000773"></see>
    /// </summary>
    let OBI_0000773 = _prefix "OBI_0000773"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000774"></see>
    /// </summary>
    let OBI_0000774 = _prefix "OBI_0000774"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000777"></see>
    /// </summary>
    let OBI_0000777 = _prefix "OBI_0000777"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000779"></see>
    /// </summary>
    let OBI_0000779 = _prefix "OBI_0000779"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000780"></see>
    /// </summary>
    let OBI_0000780 = _prefix "OBI_0000780"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200190"></see>
    /// </summary>
    let OBI_0200190 = _prefix "OBI_0200190"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000781"></see>
    /// </summary>
    let OBI_0000781 = _prefix "OBI_0000781"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000782"></see>
    /// </summary>
    let OBI_0000782 = _prefix "OBI_0000782"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000783"></see>
    /// </summary>
    let OBI_0000783 = _prefix "OBI_0000783"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000784"></see>
    /// </summary>
    let OBI_0000784 = _prefix "OBI_0000784"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002219"></see>
    /// </summary>
    let RO_0002219 = _prefix "RO_0002219"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000785"></see>
    /// </summary>
    let OBI_0000785 = _prefix "OBI_0000785"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000787"></see>
    /// </summary>
    let OBI_0000787 = _prefix "OBI_0000787"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000003252"></see>
    /// </summary>
    let PR_000003252 = _prefix "PR_000003252"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000788"></see>
    /// </summary>
    let OBI_0000788 = _prefix "OBI_0000788"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000018"></see>
    /// </summary>
    let PATO_0000018 = _prefix "PATO_0000018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600038"></see>
    /// </summary>
    let OBI_0600038 = _prefix "OBI_0600038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001936"></see>
    /// </summary>
    let OBI_0001936 = _prefix "OBI_0001936"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000790"></see>
    /// </summary>
    let OBI_0000790 = _prefix "OBI_0000790"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000791"></see>
    /// </summary>
    let OBI_0000791 = _prefix "OBI_0000791"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000792"></see>
    /// </summary>
    let OBI_0000792 = _prefix "OBI_0000792"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200188"></see>
    /// </summary>
    let OBI_0200188 = _prefix "OBI_0200188"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000793"></see>
    /// </summary>
    let OBI_0000793 = _prefix "OBI_0000793"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000822"></see>
    /// </summary>
    let OBI_0000822 = _prefix "OBI_0000822"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000826"></see>
    /// </summary>
    let OBI_0000826 = _prefix "OBI_0000826"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000804"></see>
    /// </summary>
    let OBI_0000804 = _prefix "OBI_0000804"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000842"></see>
    /// </summary>
    let OBI_0000842 = _prefix "OBI_0000842"
    /// <summary>
    /// place holder for sequence ontology term
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000905"></see></summary>
    let OBI_0000905 = _prefix "OBI_0000905"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000795"></see>
    /// </summary>
    let OBI_0000795 = _prefix "OBI_0000795"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000796"></see>
    /// </summary>
    let OBI_0000796 = _prefix "OBI_0000796"
    /// <summary>
    /// replaced by SO_0000104 polypeptide
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000797"></see></summary>
    let OBI_0000797 = _prefix "OBI_0000797"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000798"></see>
    /// </summary>
    let OBI_0000798 = _prefix "OBI_0000798"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000799"></see>
    /// </summary>
    let OBI_0000799 = _prefix "OBI_0000799"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000800"></see>
    /// </summary>
    let OBI_0000800 = _prefix "OBI_0000800"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000801"></see>
    /// </summary>
    let OBI_0000801 = _prefix "OBI_0000801"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000802"></see>
    /// </summary>
    let OBI_0000802 = _prefix "OBI_0000802"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000803"></see>
    /// </summary>
    let OBI_0000803 = _prefix "OBI_0000803"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000805"></see>
    /// </summary>
    let OBI_0000805 = _prefix "OBI_0000805"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000815"></see>
    /// </summary>
    let OBI_0000815 = _prefix "OBI_0000815"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000806"></see>
    /// </summary>
    let OBI_0000806 = _prefix "OBI_0000806"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000807"></see>
    /// </summary>
    let OBI_0000807 = _prefix "OBI_0000807"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000808"></see>
    /// </summary>
    let OBI_0000808 = _prefix "OBI_0000808"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000810"></see>
    /// </summary>
    let OBI_0000810 = _prefix "OBI_0000810"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000811"></see>
    /// </summary>
    let OBI_0000811 = _prefix "OBI_0000811"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000001"></see>
    /// </summary>
    let SO_0000001 = _prefix "SO_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000058"></see>
    /// </summary>
    let RO_0000058 = _prefix "RO_0000058"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000812"></see>
    /// </summary>
    let OBI_0000812 = _prefix "OBI_0000812"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000813"></see>
    /// </summary>
    let OBI_0000813 = _prefix "OBI_0000813"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000814"></see>
    /// </summary>
    let OBI_0000814 = _prefix "OBI_0000814"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000816"></see>
    /// </summary>
    let OBI_0000816 = _prefix "OBI_0000816"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000817"></see>
    /// </summary>
    let OBI_0000817 = _prefix "OBI_0000817"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000819"></see>
    /// </summary>
    let OBI_0000819 = _prefix "OBI_0000819"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302893"></see>
    /// </summary>
    let OBI_0302893 = _prefix "OBI_0302893"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000820"></see>
    /// </summary>
    let OBI_0000820 = _prefix "OBI_0000820"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100016"></see>
    /// </summary>
    let OBI_0100016 = _prefix "OBI_0100016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000821"></see>
    /// </summary>
    let OBI_0000821 = _prefix "OBI_0000821"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000827"></see>
    /// </summary>
    let OBI_0000827 = _prefix "OBI_0000827"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000823"></see>
    /// </summary>
    let OBI_0000823 = _prefix "OBI_0000823"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000824"></see>
    /// </summary>
    let OBI_0000824 = _prefix "OBI_0000824"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000825"></see>
    /// </summary>
    let OBI_0000825 = _prefix "OBI_0000825"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000828"></see>
    /// </summary>
    let OBI_0000828 = _prefix "OBI_0000828"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000829"></see>
    /// </summary>
    let OBI_0000829 = _prefix "OBI_0000829"
    /// <summary>
    /// replaced by SO_0000001 region
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000830"></see></summary>
    let OBI_0000830 = _prefix "OBI_0000830"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000831"></see>
    /// </summary>
    let OBI_0000831 = _prefix "OBI_0000831"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001241"></see>
    /// </summary>
    let PATO_0001241 = _prefix "PATO_0001241"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000834"></see>
    /// </summary>
    let OBI_0000834 = _prefix "OBI_0000834"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000835"></see>
    /// </summary>
    let OBI_0000835 = _prefix "OBI_0000835"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000837"></see>
    /// </summary>
    let OBI_0000837 = _prefix "OBI_0000837"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000952"></see>
    /// </summary>
    let OBI_0000952 = _prefix "OBI_0000952"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000165"></see>
    /// </summary>
    let UBERON_0000165 = _prefix "UBERON_0000165"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000838"></see>
    /// </summary>
    let OBI_0000838 = _prefix "OBI_0000838"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000839"></see>
    /// </summary>
    let OBI_0000839 = _prefix "OBI_0000839"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000840"></see>
    /// </summary>
    let OBI_0000840 = _prefix "OBI_0000840"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000841"></see>
    /// </summary>
    let OBI_0000841 = _prefix "OBI_0000841"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000843"></see>
    /// </summary>
    let OBI_0000843 = _prefix "OBI_0000843"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000844"></see>
    /// </summary>
    let OBI_0000844 = _prefix "OBI_0000844"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000845"></see>
    /// </summary>
    let OBI_0000845 = _prefix "OBI_0000845"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000846"></see>
    /// </summary>
    let OBI_0000846 = _prefix "OBI_0000846"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001688"></see>
    /// </summary>
    let OBI_0001688 = _prefix "OBI_0001688"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000847"></see>
    /// </summary>
    let OBI_0000847 = _prefix "OBI_0000847"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000848"></see>
    /// </summary>
    let OBI_0000848 = _prefix "OBI_0000848"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000849"></see>
    /// </summary>
    let OBI_0000849 = _prefix "OBI_0000849"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000850"></see>
    /// </summary>
    let OBI_0000850 = _prefix "OBI_0000850"
    /// <summary>
    /// Replaced by CHEBI_59051 Diethylpyrocarbonate
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000851"></see></summary>
    let OBI_0000851 = _prefix "OBI_0000851"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000852"></see>
    /// </summary>
    let OBI_0000852 = _prefix "OBI_0000852"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000853"></see>
    /// </summary>
    let OBI_0000853 = _prefix "OBI_0000853"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000854"></see>
    /// </summary>
    let OBI_0000854 = _prefix "OBI_0000854"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001978"></see>
    /// </summary>
    let OBI_0001978 = _prefix "OBI_0001978"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000855"></see>
    /// </summary>
    let OBI_0000855 = _prefix "OBI_0000855"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000856"></see>
    /// </summary>
    let OBI_0000856 = _prefix "OBI_0000856"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000858"></see>
    /// </summary>
    let OBI_0000858 = _prefix "OBI_0000858"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000047"></see>
    /// </summary>
    let PATO_0000047 = _prefix "PATO_0000047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000859"></see>
    /// </summary>
    let OBI_0000859 = _prefix "OBI_0000859"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000860"></see>
    /// </summary>
    let OBI_0000860 = _prefix "OBI_0000860"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000861"></see>
    /// </summary>
    let OBI_0000861 = _prefix "OBI_0000861"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000862"></see>
    /// </summary>
    let OBI_0000862 = _prefix "OBI_0000862"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000888"></see>
    /// </summary>
    let OBI_0000888 = _prefix "OBI_0000888"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000863"></see>
    /// </summary>
    let OBI_0000863 = _prefix "OBI_0000863"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000864"></see>
    /// </summary>
    let OBI_0000864 = _prefix "OBI_0000864"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000865"></see>
    /// </summary>
    let OBI_0000865 = _prefix "OBI_0000865"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400076"></see>
    /// </summary>
    let OBI_0400076 = _prefix "OBI_0400076"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000872"></see>
    /// </summary>
    let OBI_0000872 = _prefix "OBI_0000872"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000866"></see>
    /// </summary>
    let OBI_0000866 = _prefix "OBI_0000866"
    /// <summary>
    /// Helen Parkinson
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000867"></see></summary>
    let OBI_0000867 = _prefix "OBI_0000867"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001906"></see>
    /// </summary>
    let OBI_0001906 = _prefix "OBI_0001906"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000868"></see>
    /// </summary>
    let OBI_0000868 = _prefix "OBI_0000868"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000869"></see>
    /// </summary>
    let OBI_0000869 = _prefix "OBI_0000869"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000870"></see>
    /// </summary>
    let OBI_0000870 = _prefix "OBI_0000870"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000885"></see>
    /// </summary>
    let OBI_0000885 = _prefix "OBI_0000885"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000871"></see>
    /// </summary>
    let OBI_0000871 = _prefix "OBI_0000871"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000906"></see>
    /// </summary>
    let OBI_0000906 = _prefix "OBI_0000906"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000873"></see>
    /// </summary>
    let OBI_0000873 = _prefix "OBI_0000873"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001506"></see>
    /// </summary>
    let OBI_0001506 = _prefix "OBI_0001506"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000902"></see>
    /// </summary>
    let OBI_0000902 = _prefix "OBI_0000902"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001421"></see>
    /// </summary>
    let PATO_0001421 = _prefix "PATO_0001421"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000874"></see>
    /// </summary>
    let OBI_0000874 = _prefix "OBI_0000874"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000875"></see>
    /// </summary>
    let OBI_0000875 = _prefix "OBI_0000875"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000876"></see>
    /// </summary>
    let OBI_0000876 = _prefix "OBI_0000876"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001907"></see>
    /// </summary>
    let OBI_0001907 = _prefix "OBI_0001907"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000878"></see>
    /// </summary>
    let OBI_0000878 = _prefix "OBI_0000878"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000879"></see>
    /// </summary>
    let OBI_0000879 = _prefix "OBI_0000879"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001010"></see>
    /// </summary>
    let OBI_0001010 = _prefix "OBI_0001010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000881"></see>
    /// </summary>
    let OBI_0000881 = _prefix "OBI_0000881"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000882"></see>
    /// </summary>
    let OBI_0000882 = _prefix "OBI_0000882"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001977"></see>
    /// </summary>
    let OBI_0001977 = _prefix "OBI_0001977"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000883"></see>
    /// </summary>
    let OBI_0000883 = _prefix "OBI_0000883"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000884"></see>
    /// </summary>
    let OBI_0000884 = _prefix "OBI_0000884"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000886"></see>
    /// </summary>
    let OBI_0000886 = _prefix "OBI_0000886"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000887"></see>
    /// </summary>
    let OBI_0000887 = _prefix "OBI_0000887"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000889"></see>
    /// </summary>
    let OBI_0000889 = _prefix "OBI_0000889"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000890"></see>
    /// </summary>
    let OBI_0000890 = _prefix "OBI_0000890"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000892"></see>
    /// </summary>
    let OBI_0000892 = _prefix "OBI_0000892"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302903"></see>
    /// </summary>
    let OBI_0302903 = _prefix "OBI_0302903"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000893"></see>
    /// </summary>
    let OBI_0000893 = _prefix "OBI_0000893"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000894"></see>
    /// </summary>
    let OBI_0000894 = _prefix "OBI_0000894"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000895"></see>
    /// </summary>
    let OBI_0000895 = _prefix "OBI_0000895"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000896"></see>
    /// </summary>
    let OBI_0000896 = _prefix "OBI_0000896"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000897"></see>
    /// </summary>
    let OBI_0000897 = _prefix "OBI_0000897"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001017"></see>
    /// </summary>
    let OBI_0001017 = _prefix "OBI_0001017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000898"></see>
    /// </summary>
    let OBI_0000898 = _prefix "OBI_0000898"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000899"></see>
    /// </summary>
    let OBI_0000899 = _prefix "OBI_0000899"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000900"></see>
    /// </summary>
    let OBI_0000900 = _prefix "OBI_0000900"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000901"></see>
    /// </summary>
    let OBI_0000901 = _prefix "OBI_0000901"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001422"></see>
    /// </summary>
    let PATO_0001422 = _prefix "PATO_0001422"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000903"></see>
    /// </summary>
    let OBI_0000903 = _prefix "OBI_0000903"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000904"></see>
    /// </summary>
    let OBI_0000904 = _prefix "OBI_0000904"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600024"></see>
    /// </summary>
    let OBI_0600024 = _prefix "OBI_0600024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000907"></see>
    /// </summary>
    let OBI_0000907 = _prefix "OBI_0000907"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000908"></see>
    /// </summary>
    let OBI_0000908 = _prefix "OBI_0000908"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001143"></see>
    /// </summary>
    let OBI_0001143 = _prefix "OBI_0001143"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000909"></see>
    /// </summary>
    let OBI_0000909 = _prefix "OBI_0000909"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000910"></see>
    /// </summary>
    let OBI_0000910 = _prefix "OBI_0000910"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000911"></see>
    /// </summary>
    let OBI_0000911 = _prefix "OBI_0000911"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000912"></see>
    /// </summary>
    let OBI_0000912 = _prefix "OBI_0000912"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001138"></see>
    /// </summary>
    let OBI_0001138 = _prefix "OBI_0001138"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000913"></see>
    /// </summary>
    let OBI_0000913 = _prefix "OBI_0000913"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000914"></see>
    /// </summary>
    let OBI_0000914 = _prefix "OBI_0000914"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000915"></see>
    /// </summary>
    let OBI_0000915 = _prefix "OBI_0000915"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001985"></see>
    /// </summary>
    let PATO_0001985 = _prefix "PATO_0001985"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400044"></see>
    /// </summary>
    let OBI_0400044 = _prefix "OBI_0400044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001501"></see>
    /// </summary>
    let OBI_0001501 = _prefix "OBI_0001501"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000917"></see>
    /// </summary>
    let OBI_0000917 = _prefix "OBI_0000917"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002599"></see>
    /// </summary>
    let OBI_0002599 = _prefix "OBI_0002599"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002600"></see>
    /// </summary>
    let OBI_0002600 = _prefix "OBI_0002600"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000918"></see>
    /// </summary>
    let OBI_0000918 = _prefix "OBI_0000918"
    /// <summary>
    /// may later be refined with more specific list of organisms
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000919"></see></summary>
    let OBI_0000919 = _prefix "OBI_0000919"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600006"></see>
    /// </summary>
    let OBI_0600006 = _prefix "OBI_0600006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000920"></see>
    /// </summary>
    let OBI_0000920 = _prefix "OBI_0000920"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000207"></see>
    /// </summary>
    let OBI_1000207 = _prefix "OBI_1000207"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000921"></see>
    /// </summary>
    let OBI_0000921 = _prefix "OBI_0000921"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000922"></see>
    /// </summary>
    let OBI_0000922 = _prefix "OBI_0000922"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001472"></see>
    /// </summary>
    let OBI_0001472 = _prefix "OBI_0001472"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000981"></see>
    /// </summary>
    let OBI_0000981 = _prefix "OBI_0000981"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000965"></see>
    /// </summary>
    let OBI_0000965 = _prefix "OBI_0000965"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000950"></see>
    /// </summary>
    let OBI_0000950 = _prefix "OBI_0000950"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000971"></see>
    /// </summary>
    let OBI_0000971 = _prefix "OBI_0000971"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000923"></see>
    /// </summary>
    let OBI_0000923 = _prefix "OBI_0000923"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001136"></see>
    /// </summary>
    let OBI_0001136 = _prefix "OBI_0001136"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000924"></see>
    /// </summary>
    let OBI_0000924 = _prefix "OBI_0000924"
    /// <summary>
    /// A tissue sample that has been sliced and stained for a histology study.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000953"></see></summary>
    let OBI_0000953 = _prefix "OBI_0000953"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000925"></see>
    /// </summary>
    let OBI_0000925 = _prefix "OBI_0000925"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110093"></see>
    /// </summary>
    let OBI_1110093 = _prefix "OBI_1110093"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000926"></see>
    /// </summary>
    let OBI_0000926 = _prefix "OBI_0000926"
    /// <summary>
    /// can link to freezing-dying equipment, such as freeze-dryer, rotary evaporator, if needed
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000927"></see></summary>
    let OBI_0000927 = _prefix "OBI_0000927"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000928"></see>
    /// </summary>
    let OBI_0000928 = _prefix "OBI_0000928"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000929"></see>
    /// </summary>
    let OBI_0000929 = _prefix "OBI_0000929"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000930"></see>
    /// </summary>
    let OBI_0000930 = _prefix "OBI_0000930"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000933"></see>
    /// </summary>
    let OBI_0000933 = _prefix "OBI_0000933"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000934"></see>
    /// </summary>
    let OBI_0000934 = _prefix "OBI_0000934"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001134"></see>
    /// </summary>
    let UBERON_0001134 = _prefix "UBERON_0001134"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000935"></see>
    /// </summary>
    let OBI_0000935 = _prefix "OBI_0000935"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000936"></see>
    /// </summary>
    let OBI_0000936 = _prefix "OBI_0000936"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000937"></see>
    /// </summary>
    let OBI_0000937 = _prefix "OBI_0000937"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000938"></see>
    /// </summary>
    let OBI_0000938 = _prefix "OBI_0000938"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001930"></see>
    /// </summary>
    let OBI_0001930 = _prefix "OBI_0001930"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000939"></see>
    /// </summary>
    let OBI_0000939 = _prefix "OBI_0000939"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000962"></see>
    /// </summary>
    let OBI_0000962 = _prefix "OBI_0000962"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000940"></see>
    /// </summary>
    let OBI_0000940 = _prefix "OBI_0000940"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400169"></see>
    /// </summary>
    let OBI_0400169 = _prefix "OBI_0400169"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000941"></see>
    /// </summary>
    let OBI_0000941 = _prefix "OBI_0000941"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000942"></see>
    /// </summary>
    let OBI_0000942 = _prefix "OBI_0000942"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002067"></see>
    /// </summary>
    let UBERON_0002067 = _prefix "UBERON_0002067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000943"></see>
    /// </summary>
    let OBI_0000943 = _prefix "OBI_0000943"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000944"></see>
    /// </summary>
    let OBI_0000944 = _prefix "OBI_0000944"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002201"></see>
    /// </summary>
    let PATO_0002201 = _prefix "PATO_0002201"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000945"></see>
    /// </summary>
    let OBI_0000945 = _prefix "OBI_0000945"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000946"></see>
    /// </summary>
    let OBI_0000946 = _prefix "OBI_0000946"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000948"></see>
    /// </summary>
    let OBI_0000948 = _prefix "OBI_0000948"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000949"></see>
    /// </summary>
    let OBI_0000949 = _prefix "OBI_0000949"
    /// <summary>
    /// need to specify paraffin or wax is one of specified input of the process
    /// <see href="http://purl.obolibrary.org/obo/OBI_0000977"></see></summary>
    let OBI_0000977 = _prefix "OBI_0000977"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000951"></see>
    /// </summary>
    let OBI_0000951 = _prefix "OBI_0000951"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000995"></see>
    /// </summary>
    let OBI_0000995 = _prefix "OBI_0000995"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000954"></see>
    /// </summary>
    let OBI_0000954 = _prefix "OBI_0000954"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002072"></see>
    /// </summary>
    let UBERON_0002072 = _prefix "UBERON_0002072"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000955"></see>
    /// </summary>
    let OBI_0000955 = _prefix "OBI_0000955"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000956"></see>
    /// </summary>
    let OBI_0000956 = _prefix "OBI_0000956"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000957"></see>
    /// </summary>
    let OBI_0000957 = _prefix "OBI_0000957"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000958"></see>
    /// </summary>
    let OBI_0000958 = _prefix "OBI_0000958"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002203"></see>
    /// </summary>
    let PATO_0002203 = _prefix "PATO_0002203"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000963"></see>
    /// </summary>
    let OBI_0000963 = _prefix "OBI_0000963"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000959"></see>
    /// </summary>
    let OBI_0000959 = _prefix "OBI_0000959"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000960"></see>
    /// </summary>
    let OBI_0000960 = _prefix "OBI_0000960"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000961"></see>
    /// </summary>
    let OBI_0000961 = _prefix "OBI_0000961"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000964"></see>
    /// </summary>
    let OBI_0000964 = _prefix "OBI_0000964"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000966"></see>
    /// </summary>
    let OBI_0000966 = _prefix "OBI_0000966"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000969"></see>
    /// </summary>
    let OBI_0000969 = _prefix "OBI_0000969"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000970"></see>
    /// </summary>
    let OBI_0000970 = _prefix "OBI_0000970"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000972"></see>
    /// </summary>
    let OBI_0000972 = _prefix "OBI_0000972"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000974"></see>
    /// </summary>
    let OBI_0000974 = _prefix "OBI_0000974"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000975"></see>
    /// </summary>
    let OBI_0000975 = _prefix "OBI_0000975"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000976"></see>
    /// </summary>
    let OBI_0000976 = _prefix "OBI_0000976"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000979"></see>
    /// </summary>
    let OBI_0000979 = _prefix "OBI_0000979"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000998"></see>
    /// </summary>
    let OBI_0000998 = _prefix "OBI_0000998"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000999"></see>
    /// </summary>
    let OBI_0000999 = _prefix "OBI_0000999"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000978"></see>
    /// </summary>
    let OBI_0000978 = _prefix "OBI_0000978"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002204"></see>
    /// </summary>
    let PATO_0002204 = _prefix "PATO_0002204"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000980"></see>
    /// </summary>
    let OBI_0000980 = _prefix "OBI_0000980"
    /// <summary>
    /// need to specify that agar is one of input for this process
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001003"></see></summary>
    let OBI_0001003 = _prefix "OBI_0001003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000982"></see>
    /// </summary>
    let OBI_0000982 = _prefix "OBI_0000982"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000983"></see>
    /// </summary>
    let OBI_0000983 = _prefix "OBI_0000983"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0005022"></see>
    /// </summary>
    let UBERON_0005022 = _prefix "UBERON_0005022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000984"></see>
    /// </summary>
    let OBI_0000984 = _prefix "OBI_0000984"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000985"></see>
    /// </summary>
    let OBI_0000985 = _prefix "OBI_0000985"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000997"></see>
    /// </summary>
    let OBI_0000997 = _prefix "OBI_0000997"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000986"></see>
    /// </summary>
    let OBI_0000986 = _prefix "OBI_0000986"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000987"></see>
    /// </summary>
    let OBI_0000987 = _prefix "OBI_0000987"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000988"></see>
    /// </summary>
    let OBI_0000988 = _prefix "OBI_0000988"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000989"></see>
    /// </summary>
    let OBI_0000989 = _prefix "OBI_0000989"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400116"></see>
    /// </summary>
    let OBI_0400116 = _prefix "OBI_0400116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000990"></see>
    /// </summary>
    let OBI_0000990 = _prefix "OBI_0000990"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000991"></see>
    /// </summary>
    let OBI_0000991 = _prefix "OBI_0000991"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000992"></see>
    /// </summary>
    let OBI_0000992 = _prefix "OBI_0000992"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001904"></see>
    /// </summary>
    let OBI_0001904 = _prefix "OBI_0001904"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000993"></see>
    /// </summary>
    let OBI_0000993 = _prefix "OBI_0000993"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000994"></see>
    /// </summary>
    let OBI_0000994 = _prefix "OBI_0000994"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001638"></see>
    /// </summary>
    let UBERON_0001638 = _prefix "UBERON_0001638"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0000996"></see>
    /// </summary>
    let OBI_0000996 = _prefix "OBI_0000996"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002202"></see>
    /// </summary>
    let PATO_0002202 = _prefix "PATO_0002202"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001000"></see>
    /// </summary>
    let OBI_0001000 = _prefix "OBI_0001000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001001"></see>
    /// </summary>
    let OBI_0001001 = _prefix "OBI_0001001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001004"></see>
    /// </summary>
    let OBI_0001004 = _prefix "OBI_0001004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001002"></see>
    /// </summary>
    let OBI_0001002 = _prefix "OBI_0001002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001005"></see>
    /// </summary>
    let OBI_0001005 = _prefix "OBI_0001005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001014"></see>
    /// </summary>
    let OBI_0001014 = _prefix "OBI_0001014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000025478"></see>
    /// </summary>
    let PR_000025478 = _prefix "PR_000025478"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001006"></see>
    /// </summary>
    let OBI_0001006 = _prefix "OBI_0001006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001008"></see>
    /// </summary>
    let OBI_0001008 = _prefix "OBI_0001008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001009"></see>
    /// </summary>
    let OBI_0001009 = _prefix "OBI_0001009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001011"></see>
    /// </summary>
    let OBI_0001011 = _prefix "OBI_0001011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001012"></see>
    /// </summary>
    let OBI_0001012 = _prefix "OBI_0001012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000025477"></see>
    /// </summary>
    let PR_000025477 = _prefix "PR_000025477"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001013"></see>
    /// </summary>
    let OBI_0001013 = _prefix "OBI_0001013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001015"></see>
    /// </summary>
    let OBI_0001015 = _prefix "OBI_0001015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001016"></see>
    /// </summary>
    let OBI_0001016 = _prefix "OBI_0001016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000006592"></see>
    /// </summary>
    let PR_000006592 = _prefix "PR_000006592"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001018"></see>
    /// </summary>
    let OBI_0001018 = _prefix "OBI_0001018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001019"></see>
    /// </summary>
    let OBI_0001019 = _prefix "OBI_0001019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000003745"></see>
    /// </summary>
    let PR_000003745 = _prefix "PR_000003745"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001020"></see>
    /// </summary>
    let OBI_0001020 = _prefix "OBI_0001020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001021"></see>
    /// </summary>
    let OBI_0001021 = _prefix "OBI_0001021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000014060"></see>
    /// </summary>
    let PR_000014060 = _prefix "PR_000014060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001022"></see>
    /// </summary>
    let OBI_0001022 = _prefix "OBI_0001022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001023"></see>
    /// </summary>
    let OBI_0001023 = _prefix "OBI_0001023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001024"></see>
    /// </summary>
    let OBI_0001024 = _prefix "OBI_0001024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000025475"></see>
    /// </summary>
    let PR_000025475 = _prefix "PR_000025475"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001025"></see>
    /// </summary>
    let OBI_0001025 = _prefix "OBI_0001025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001144"></see>
    /// </summary>
    let OBI_0001144 = _prefix "OBI_0001144"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001026"></see>
    /// </summary>
    let OBI_0001026 = _prefix "OBI_0001026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001027"></see>
    /// </summary>
    let OBI_0001027 = _prefix "OBI_0001027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001028"></see>
    /// </summary>
    let OBI_0001028 = _prefix "OBI_0001028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200005"></see>
    /// </summary>
    let OBI_0200005 = _prefix "OBI_0200005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001029"></see>
    /// </summary>
    let OBI_0001029 = _prefix "OBI_0001029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001030"></see>
    /// </summary>
    let OBI_0001030 = _prefix "OBI_0001030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000025467"></see>
    /// </summary>
    let PR_000025467 = _prefix "PR_000025467"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001031"></see>
    /// </summary>
    let OBI_0001031 = _prefix "OBI_0001031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001032"></see>
    /// </summary>
    let OBI_0001032 = _prefix "OBI_0001032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001033"></see>
    /// </summary>
    let OBI_0001033 = _prefix "OBI_0001033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001034"></see>
    /// </summary>
    let OBI_0001034 = _prefix "OBI_0001034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001035"></see>
    /// </summary>
    let OBI_0001035 = _prefix "OBI_0001035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000025471"></see>
    /// </summary>
    let PR_000025471 = _prefix "PR_000025471"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001036"></see>
    /// </summary>
    let OBI_0001036 = _prefix "OBI_0001036"
    /// <summary>
    /// duplicate term
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001037"></see></summary>
    let OBI_0001037 = _prefix "OBI_0001037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001038"></see>
    /// </summary>
    let OBI_0001038 = _prefix "OBI_0001038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001039"></see>
    /// </summary>
    let OBI_0001039 = _prefix "OBI_0001039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001040"></see>
    /// </summary>
    let OBI_0001040 = _prefix "OBI_0001040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001041"></see>
    /// </summary>
    let OBI_0001041 = _prefix "OBI_0001041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001042"></see>
    /// </summary>
    let OBI_0001042 = _prefix "OBI_0001042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001043"></see>
    /// </summary>
    let OBI_0001043 = _prefix "OBI_0001043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001044"></see>
    /// </summary>
    let OBI_0001044 = _prefix "OBI_0001044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001045"></see>
    /// </summary>
    let OBI_0001045 = _prefix "OBI_0001045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001046"></see>
    /// </summary>
    let OBI_0001046 = _prefix "OBI_0001046"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001047"></see>
    /// </summary>
    let OBI_0001047 = _prefix "OBI_0001047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001048"></see>
    /// </summary>
    let OBI_0001048 = _prefix "OBI_0001048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001049"></see>
    /// </summary>
    let OBI_0001049 = _prefix "OBI_0001049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001050"></see>
    /// </summary>
    let OBI_0001050 = _prefix "OBI_0001050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001114"></see>
    /// </summary>
    let OBI_0001114 = _prefix "OBI_0001114"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001052"></see>
    /// </summary>
    let OBI_0001052 = _prefix "OBI_0001052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400065"></see>
    /// </summary>
    let OBI_0400065 = _prefix "OBI_0400065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001053"></see>
    /// </summary>
    let OBI_0001053 = _prefix "OBI_0001053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001054"></see>
    /// </summary>
    let OBI_0001054 = _prefix "OBI_0001054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001055"></see>
    /// </summary>
    let OBI_0001055 = _prefix "OBI_0001055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001079"></see>
    /// </summary>
    let OBI_0001079 = _prefix "OBI_0001079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001056"></see>
    /// </summary>
    let OBI_0001056 = _prefix "OBI_0001056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400113"></see>
    /// </summary>
    let OBI_0400113 = _prefix "OBI_0400113"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001057"></see>
    /// </summary>
    let OBI_0001057 = _prefix "OBI_0001057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001139"></see>
    /// </summary>
    let OBI_0001139 = _prefix "OBI_0001139"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001058"></see>
    /// </summary>
    let OBI_0001058 = _prefix "OBI_0001058"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001059"></see>
    /// </summary>
    let OBI_0001059 = _prefix "OBI_0001059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001060"></see>
    /// </summary>
    let OBI_0001060 = _prefix "OBI_0001060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001061"></see>
    /// </summary>
    let OBI_0001061 = _prefix "OBI_0001061"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001062"></see>
    /// </summary>
    let OBI_0001062 = _prefix "OBI_0001062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001063"></see>
    /// </summary>
    let OBI_0001063 = _prefix "OBI_0001063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001064"></see>
    /// </summary>
    let OBI_0001064 = _prefix "OBI_0001064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001065"></see>
    /// </summary>
    let OBI_0001065 = _prefix "OBI_0001065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001066"></see>
    /// </summary>
    let OBI_0001066 = _prefix "OBI_0001066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001135"></see>
    /// </summary>
    let OBI_0001135 = _prefix "OBI_0001135"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001067"></see>
    /// </summary>
    let OBI_0001067 = _prefix "OBI_0001067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001068"></see>
    /// </summary>
    let OBI_0001068 = _prefix "OBI_0001068"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001069"></see>
    /// </summary>
    let OBI_0001069 = _prefix "OBI_0001069"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001070"></see>
    /// </summary>
    let OBI_0001070 = _prefix "OBI_0001070"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001071"></see>
    /// </summary>
    let OBI_0001071 = _prefix "OBI_0001071"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001072"></see>
    /// </summary>
    let OBI_0001072 = _prefix "OBI_0001072"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001073"></see>
    /// </summary>
    let OBI_0001073 = _prefix "OBI_0001073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001074"></see>
    /// </summary>
    let OBI_0001074 = _prefix "OBI_0001074"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001075"></see>
    /// </summary>
    let OBI_0001075 = _prefix "OBI_0001075"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001076"></see>
    /// </summary>
    let OBI_0001076 = _prefix "OBI_0001076"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001077"></see>
    /// </summary>
    let OBI_0001077 = _prefix "OBI_0001077"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001078"></see>
    /// </summary>
    let OBI_0001078 = _prefix "OBI_0001078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001080"></see>
    /// </summary>
    let OBI_0001080 = _prefix "OBI_0001080"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001081"></see>
    /// </summary>
    let OBI_0001081 = _prefix "OBI_0001081"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001082"></see>
    /// </summary>
    let OBI_0001082 = _prefix "OBI_0001082"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001083"></see>
    /// </summary>
    let OBI_0001083 = _prefix "OBI_0001083"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001118"></see>
    /// </summary>
    let OBI_0001118 = _prefix "OBI_0001118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001084"></see>
    /// </summary>
    let OBI_0001084 = _prefix "OBI_0001084"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001085"></see>
    /// </summary>
    let OBI_0001085 = _prefix "OBI_0001085"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001086"></see>
    /// </summary>
    let OBI_0001086 = _prefix "OBI_0001086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001087"></see>
    /// </summary>
    let OBI_0001087 = _prefix "OBI_0001087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001088"></see>
    /// </summary>
    let OBI_0001088 = _prefix "OBI_0001088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001089"></see>
    /// </summary>
    let OBI_0001089 = _prefix "OBI_0001089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001090"></see>
    /// </summary>
    let OBI_0001090 = _prefix "OBI_0001090"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001091"></see>
    /// </summary>
    let OBI_0001091 = _prefix "OBI_0001091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001092"></see>
    /// </summary>
    let OBI_0001092 = _prefix "OBI_0001092"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001093"></see>
    /// </summary>
    let OBI_0001093 = _prefix "OBI_0001093"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001094"></see>
    /// </summary>
    let OBI_0001094 = _prefix "OBI_0001094"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001095"></see>
    /// </summary>
    let OBI_0001095 = _prefix "OBI_0001095"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001096"></see>
    /// </summary>
    let OBI_0001096 = _prefix "OBI_0001096"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001097"></see>
    /// </summary>
    let OBI_0001097 = _prefix "OBI_0001097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400112"></see>
    /// </summary>
    let OBI_0400112 = _prefix "OBI_0400112"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001098"></see>
    /// </summary>
    let OBI_0001098 = _prefix "OBI_0001098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001099"></see>
    /// </summary>
    let OBI_0001099 = _prefix "OBI_0001099"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001100"></see>
    /// </summary>
    let OBI_0001100 = _prefix "OBI_0001100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400106"></see>
    /// </summary>
    let OBI_0400106 = _prefix "OBI_0400106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001101"></see>
    /// </summary>
    let OBI_0001101 = _prefix "OBI_0001101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001128"></see>
    /// </summary>
    let OBI_0001128 = _prefix "OBI_0001128"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001102"></see>
    /// </summary>
    let OBI_0001102 = _prefix "OBI_0001102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400115"></see>
    /// </summary>
    let OBI_0400115 = _prefix "OBI_0400115"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001103"></see>
    /// </summary>
    let OBI_0001103 = _prefix "OBI_0001103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001104"></see>
    /// </summary>
    let OBI_0001104 = _prefix "OBI_0001104"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001105"></see>
    /// </summary>
    let OBI_0001105 = _prefix "OBI_0001105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001106"></see>
    /// </summary>
    let OBI_0001106 = _prefix "OBI_0001106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001121"></see>
    /// </summary>
    let OBI_0001121 = _prefix "OBI_0001121"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001107"></see>
    /// </summary>
    let OBI_0001107 = _prefix "OBI_0001107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001108"></see>
    /// </summary>
    let OBI_0001108 = _prefix "OBI_0001108"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001109"></see>
    /// </summary>
    let OBI_0001109 = _prefix "OBI_0001109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001110"></see>
    /// </summary>
    let OBI_0001110 = _prefix "OBI_0001110"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001111"></see>
    /// </summary>
    let OBI_0001111 = _prefix "OBI_0001111"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001112"></see>
    /// </summary>
    let OBI_0001112 = _prefix "OBI_0001112"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001113"></see>
    /// </summary>
    let OBI_0001113 = _prefix "OBI_0001113"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001115"></see>
    /// </summary>
    let OBI_0001115 = _prefix "OBI_0001115"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001116"></see>
    /// </summary>
    let OBI_0001116 = _prefix "OBI_0001116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001117"></see>
    /// </summary>
    let OBI_0001117 = _prefix "OBI_0001117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001119"></see>
    /// </summary>
    let OBI_0001119 = _prefix "OBI_0001119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001120"></see>
    /// </summary>
    let OBI_0001120 = _prefix "OBI_0001120"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400143"></see>
    /// </summary>
    let OBI_0400143 = _prefix "OBI_0400143"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001122"></see>
    /// </summary>
    let OBI_0001122 = _prefix "OBI_0001122"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001123"></see>
    /// </summary>
    let OBI_0001123 = _prefix "OBI_0001123"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001124"></see>
    /// </summary>
    let OBI_0001124 = _prefix "OBI_0001124"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001125"></see>
    /// </summary>
    let OBI_0001125 = _prefix "OBI_0001125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001126"></see>
    /// </summary>
    let OBI_0001126 = _prefix "OBI_0001126"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001127"></see>
    /// </summary>
    let OBI_0001127 = _prefix "OBI_0001127"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001129"></see>
    /// </summary>
    let OBI_0001129 = _prefix "OBI_0001129"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001130"></see>
    /// </summary>
    let OBI_0001130 = _prefix "OBI_0001130"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001131"></see>
    /// </summary>
    let OBI_0001131 = _prefix "OBI_0001131"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001132"></see>
    /// </summary>
    let OBI_0001132 = _prefix "OBI_0001132"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001133"></see>
    /// </summary>
    let OBI_0001133 = _prefix "OBI_0001133"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001134"></see>
    /// </summary>
    let OBI_0001134 = _prefix "OBI_0001134"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001137"></see>
    /// </summary>
    let OBI_0001137 = _prefix "OBI_0001137"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001140"></see>
    /// </summary>
    let OBI_0001140 = _prefix "OBI_0001140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001141"></see>
    /// </summary>
    let OBI_0001141 = _prefix "OBI_0001141"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001142"></see>
    /// </summary>
    let OBI_0001142 = _prefix "OBI_0001142"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001181"></see>
    /// </summary>
    let OBI_0001181 = _prefix "OBI_0001181"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001536"></see>
    /// </summary>
    let OBI_0001536 = _prefix "OBI_0001536"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001548"></see>
    /// </summary>
    let OBI_0001548 = _prefix "OBI_0001548"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001571"></see>
    /// </summary>
    let OBI_0001571 = _prefix "OBI_0001571"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001581"></see>
    /// </summary>
    let OBI_0001581 = _prefix "OBI_0001581"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001583"></see>
    /// </summary>
    let OBI_0001583 = _prefix "OBI_0001583"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001603"></see>
    /// </summary>
    let OBI_0001603 = _prefix "OBI_0001603"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001605"></see>
    /// </summary>
    let OBI_0001605 = _prefix "OBI_0001605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001145"></see>
    /// </summary>
    let OBI_0001145 = _prefix "OBI_0001145"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001147"></see>
    /// </summary>
    let OBI_0001147 = _prefix "OBI_0001147"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001148"></see>
    /// </summary>
    let OBI_0001148 = _prefix "OBI_0001148"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600043"></see>
    /// </summary>
    let OBI_0600043 = _prefix "OBI_0600043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001149"></see>
    /// </summary>
    let OBI_0001149 = _prefix "OBI_0001149"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001150"></see>
    /// </summary>
    let OBI_0001150 = _prefix "OBI_0001150"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001151"></see>
    /// </summary>
    let OBI_0001151 = _prefix "OBI_0001151"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302859"></see>
    /// </summary>
    let OBI_0302859 = _prefix "OBI_0302859"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001152"></see>
    /// </summary>
    let OBI_0001152 = _prefix "OBI_0001152"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600033"></see>
    /// </summary>
    let OBI_0600033 = _prefix "OBI_0600033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001153"></see>
    /// </summary>
    let OBI_0001153 = _prefix "OBI_0001153"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001154"></see>
    /// </summary>
    let OBI_0001154 = _prefix "OBI_0001154"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001156"></see>
    /// </summary>
    let OBI_0001156 = _prefix "OBI_0001156"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001167"></see>
    /// </summary>
    let OBI_0001167 = _prefix "OBI_0001167"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001157"></see>
    /// </summary>
    let OBI_0001157 = _prefix "OBI_0001157"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001158"></see>
    /// </summary>
    let OBI_0001158 = _prefix "OBI_0001158"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001159"></see>
    /// </summary>
    let OBI_0001159 = _prefix "OBI_0001159"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001160"></see>
    /// </summary>
    let OBI_0001160 = _prefix "OBI_0001160"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001161"></see>
    /// </summary>
    let OBI_0001161 = _prefix "OBI_0001161"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001162"></see>
    /// </summary>
    let OBI_0001162 = _prefix "OBI_0001162"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001163"></see>
    /// </summary>
    let OBI_0001163 = _prefix "OBI_0001163"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001164"></see>
    /// </summary>
    let OBI_0001164 = _prefix "OBI_0001164"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001165"></see>
    /// </summary>
    let OBI_0001165 = _prefix "OBI_0001165"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001166"></see>
    /// </summary>
    let OBI_0001166 = _prefix "OBI_0001166"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000011"></see>
    /// </summary>
    let PATO_0000011 = _prefix "PATO_0000011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001168"></see>
    /// </summary>
    let OBI_0001168 = _prefix "OBI_0001168"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001169"></see>
    /// </summary>
    let OBI_0001169 = _prefix "OBI_0001169"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001170"></see>
    /// </summary>
    let OBI_0001170 = _prefix "OBI_0001170"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001171"></see>
    /// </summary>
    let OBI_0001171 = _prefix "OBI_0001171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001172"></see>
    /// </summary>
    let OBI_0001172 = _prefix "OBI_0001172"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001174"></see>
    /// </summary>
    let OBI_0001174 = _prefix "OBI_0001174"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001175"></see>
    /// </summary>
    let OBI_0001175 = _prefix "OBI_0001175"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001176"></see>
    /// </summary>
    let OBI_0001176 = _prefix "OBI_0001176"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110015"></see>
    /// </summary>
    let OBI_1110015 = _prefix "OBI_1110015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001177"></see>
    /// </summary>
    let OBI_0001177 = _prefix "OBI_0001177"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001178"></see>
    /// </summary>
    let OBI_0001178 = _prefix "OBI_0001178"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001192"></see>
    /// </summary>
    let OBI_0001192 = _prefix "OBI_0001192"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110001"></see>
    /// </summary>
    let OBI_1110001 = _prefix "OBI_1110001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001179"></see>
    /// </summary>
    let OBI_0001179 = _prefix "OBI_0001179"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001184"></see>
    /// </summary>
    let OBI_0001184 = _prefix "OBI_0001184"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001180"></see>
    /// </summary>
    let OBI_0001180 = _prefix "OBI_0001180"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000051"></see>
    /// </summary>
    let UO_0000051 = _prefix "UO_0000051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001182"></see>
    /// </summary>
    let OBI_0001182 = _prefix "OBI_0001182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001183"></see>
    /// </summary>
    let OBI_0001183 = _prefix "OBI_0001183"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001185"></see>
    /// </summary>
    let OBI_0001185 = _prefix "OBI_0001185"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001186"></see>
    /// </summary>
    let OBI_0001186 = _prefix "OBI_0001186"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001187"></see>
    /// </summary>
    let OBI_0001187 = _prefix "OBI_0001187"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001188"></see>
    /// </summary>
    let OBI_0001188 = _prefix "OBI_0001188"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001189"></see>
    /// </summary>
    let OBI_0001189 = _prefix "OBI_0001189"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001190"></see>
    /// </summary>
    let OBI_0001190 = _prefix "OBI_0001190"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001191"></see>
    /// </summary>
    let OBI_0001191 = _prefix "OBI_0001191"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001193"></see>
    /// </summary>
    let OBI_0001193 = _prefix "OBI_0001193"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110057"></see>
    /// </summary>
    let OBI_1110057 = _prefix "OBI_1110057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110060"></see>
    /// </summary>
    let OBI_1110060 = _prefix "OBI_1110060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001194"></see>
    /// </summary>
    let OBI_0001194 = _prefix "OBI_0001194"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001264"></see>
    /// </summary>
    let OBI_0001264 = _prefix "OBI_0001264"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600031"></see>
    /// </summary>
    let OBI_0600031 = _prefix "OBI_0600031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001195"></see>
    /// </summary>
    let OBI_0001195 = _prefix "OBI_0001195"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001196"></see>
    /// </summary>
    let OBI_0001196 = _prefix "OBI_0001196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001308"></see>
    /// </summary>
    let OBI_0001308 = _prefix "OBI_0001308"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001197"></see>
    /// </summary>
    let OBI_0001197 = _prefix "OBI_0001197"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001198"></see>
    /// </summary>
    let OBI_0001198 = _prefix "OBI_0001198"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110129"></see>
    /// </summary>
    let OBI_1110129 = _prefix "OBI_1110129"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001199"></see>
    /// </summary>
    let OBI_0001199 = _prefix "OBI_0001199"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001200"></see>
    /// </summary>
    let OBI_0001200 = _prefix "OBI_0001200"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001444"></see>
    /// </summary>
    let OBI_0001444 = _prefix "OBI_0001444"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001201"></see>
    /// </summary>
    let OBI_0001201 = _prefix "OBI_0001201"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001202"></see>
    /// </summary>
    let OBI_0001202 = _prefix "OBI_0001202"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001203"></see>
    /// </summary>
    let OBI_0001203 = _prefix "OBI_0001203"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001204"></see>
    /// </summary>
    let OBI_0001204 = _prefix "OBI_0001204"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400148"></see>
    /// </summary>
    let OBI_0400148 = _prefix "OBI_0400148"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001205"></see>
    /// </summary>
    let OBI_0001205 = _prefix "OBI_0001205"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001206"></see>
    /// </summary>
    let OBI_0001206 = _prefix "OBI_0001206"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001233"></see>
    /// </summary>
    let OBI_0001233 = _prefix "OBI_0001233"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001207"></see>
    /// </summary>
    let OBI_0001207 = _prefix "OBI_0001207"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001208"></see>
    /// </summary>
    let OBI_0001208 = _prefix "OBI_0001208"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001209"></see>
    /// </summary>
    let OBI_0001209 = _prefix "OBI_0001209"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001210"></see>
    /// </summary>
    let OBI_0001210 = _prefix "OBI_0001210"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001211"></see>
    /// </summary>
    let OBI_0001211 = _prefix "OBI_0001211"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001212"></see>
    /// </summary>
    let OBI_0001212 = _prefix "OBI_0001212"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001213"></see>
    /// </summary>
    let OBI_0001213 = _prefix "OBI_0001213"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001214"></see>
    /// </summary>
    let OBI_0001214 = _prefix "OBI_0001214"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001215"></see>
    /// </summary>
    let OBI_0001215 = _prefix "OBI_0001215"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001497"></see>
    /// </summary>
    let OBI_0001497 = _prefix "OBI_0001497"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001216"></see>
    /// </summary>
    let OBI_0001216 = _prefix "OBI_0001216"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001445"></see>
    /// </summary>
    let OBI_0001445 = _prefix "OBI_0001445"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001217"></see>
    /// </summary>
    let OBI_0001217 = _prefix "OBI_0001217"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001218"></see>
    /// </summary>
    let OBI_0001218 = _prefix "OBI_0001218"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001219"></see>
    /// </summary>
    let OBI_0001219 = _prefix "OBI_0001219"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001220"></see>
    /// </summary>
    let OBI_0001220 = _prefix "OBI_0001220"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001221"></see>
    /// </summary>
    let OBI_0001221 = _prefix "OBI_0001221"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001248"></see>
    /// </summary>
    let OBI_0001248 = _prefix "OBI_0001248"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001222"></see>
    /// </summary>
    let OBI_0001222 = _prefix "OBI_0001222"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001232"></see>
    /// </summary>
    let OBI_0001232 = _prefix "OBI_0001232"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001223"></see>
    /// </summary>
    let OBI_0001223 = _prefix "OBI_0001223"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001449"></see>
    /// </summary>
    let OBI_0001449 = _prefix "OBI_0001449"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001224"></see>
    /// </summary>
    let OBI_0001224 = _prefix "OBI_0001224"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001225"></see>
    /// </summary>
    let OBI_0001225 = _prefix "OBI_0001225"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001226"></see>
    /// </summary>
    let OBI_0001226 = _prefix "OBI_0001226"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001227"></see>
    /// </summary>
    let OBI_0001227 = _prefix "OBI_0001227"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001451"></see>
    /// </summary>
    let OBI_0001451 = _prefix "OBI_0001451"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001228"></see>
    /// </summary>
    let OBI_0001228 = _prefix "OBI_0001228"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001495"></see>
    /// </summary>
    let OBI_0001495 = _prefix "OBI_0001495"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001229"></see>
    /// </summary>
    let OBI_0001229 = _prefix "OBI_0001229"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002097"></see>
    /// </summary>
    let OBI_0002097 = _prefix "OBI_0002097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000065"></see>
    /// </summary>
    let UO_0000065 = _prefix "UO_0000065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001230"></see>
    /// </summary>
    let OBI_0001230 = _prefix "OBI_0001230"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001231"></see>
    /// </summary>
    let OBI_0001231 = _prefix "OBI_0001231"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001235"></see>
    /// </summary>
    let OBI_0001235 = _prefix "OBI_0001235"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001307"></see>
    /// </summary>
    let OBI_0001307 = _prefix "OBI_0001307"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001463"></see>
    /// </summary>
    let OBI_0001463 = _prefix "OBI_0001463"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001236"></see>
    /// </summary>
    let OBI_0001236 = _prefix "OBI_0001236"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001237"></see>
    /// </summary>
    let OBI_0001237 = _prefix "OBI_0001237"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001238"></see>
    /// </summary>
    let OBI_0001238 = _prefix "OBI_0001238"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001253"></see>
    /// </summary>
    let OBI_0001253 = _prefix "OBI_0001253"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001239"></see>
    /// </summary>
    let OBI_0001239 = _prefix "OBI_0001239"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001240"></see>
    /// </summary>
    let OBI_0001240 = _prefix "OBI_0001240"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001241"></see>
    /// </summary>
    let OBI_0001241 = _prefix "OBI_0001241"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001450"></see>
    /// </summary>
    let OBI_0001450 = _prefix "OBI_0001450"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001242"></see>
    /// </summary>
    let OBI_0001242 = _prefix "OBI_0001242"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001416"></see>
    /// </summary>
    let OBI_0001416 = _prefix "OBI_0001416"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001788"></see>
    /// </summary>
    let OBI_0001788 = _prefix "OBI_0001788"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001243"></see>
    /// </summary>
    let OBI_0001243 = _prefix "OBI_0001243"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001465"></see>
    /// </summary>
    let OBI_0001465 = _prefix "OBI_0001465"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001244"></see>
    /// </summary>
    let OBI_0001244 = _prefix "OBI_0001244"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001363"></see>
    /// </summary>
    let OBI_0001363 = _prefix "OBI_0001363"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001245"></see>
    /// </summary>
    let OBI_0001245 = _prefix "OBI_0001245"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001246"></see>
    /// </summary>
    let OBI_0001246 = _prefix "OBI_0001246"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001400"></see>
    /// </summary>
    let OBI_0001400 = _prefix "OBI_0001400"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001247"></see>
    /// </summary>
    let OBI_0001247 = _prefix "OBI_0001247"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001985"></see>
    /// </summary>
    let OBI_0001985 = _prefix "OBI_0001985"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001249"></see>
    /// </summary>
    let OBI_0001249 = _prefix "OBI_0001249"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001250"></see>
    /// </summary>
    let OBI_0001250 = _prefix "OBI_0001250"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001251"></see>
    /// </summary>
    let OBI_0001251 = _prefix "OBI_0001251"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001252"></see>
    /// </summary>
    let OBI_0001252 = _prefix "OBI_0001252"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001254"></see>
    /// </summary>
    let OBI_0001254 = _prefix "OBI_0001254"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001255"></see>
    /// </summary>
    let OBI_0001255 = _prefix "OBI_0001255"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001256"></see>
    /// </summary>
    let OBI_0001256 = _prefix "OBI_0001256"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001351"></see>
    /// </summary>
    let OBI_0001351 = _prefix "OBI_0001351"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001257"></see>
    /// </summary>
    let OBI_0001257 = _prefix "OBI_0001257"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001258"></see>
    /// </summary>
    let OBI_0001258 = _prefix "OBI_0001258"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001398"></see>
    /// </summary>
    let OBI_0001398 = _prefix "OBI_0001398"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001425"></see>
    /// </summary>
    let OBI_0001425 = _prefix "OBI_0001425"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001259"></see>
    /// </summary>
    let OBI_0001259 = _prefix "OBI_0001259"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001260"></see>
    /// </summary>
    let OBI_0001260 = _prefix "OBI_0001260"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001406"></see>
    /// </summary>
    let OBI_0001406 = _prefix "OBI_0001406"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001261"></see>
    /// </summary>
    let OBI_0001261 = _prefix "OBI_0001261"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001388"></see>
    /// </summary>
    let OBI_0001388 = _prefix "OBI_0001388"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001262"></see>
    /// </summary>
    let OBI_0001262 = _prefix "OBI_0001262"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001263"></see>
    /// </summary>
    let OBI_0001263 = _prefix "OBI_0001263"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001265"></see>
    /// </summary>
    let OBI_0001265 = _prefix "OBI_0001265"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001266"></see>
    /// </summary>
    let OBI_0001266 = _prefix "OBI_0001266"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001267"></see>
    /// </summary>
    let OBI_0001267 = _prefix "OBI_0001267"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001268"></see>
    /// </summary>
    let OBI_0001268 = _prefix "OBI_0001268"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001391"></see>
    /// </summary>
    let OBI_0001391 = _prefix "OBI_0001391"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001269"></see>
    /// </summary>
    let OBI_0001269 = _prefix "OBI_0001269"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002055"></see>
    /// </summary>
    let OBI_0002055 = _prefix "OBI_0002055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001270"></see>
    /// </summary>
    let OBI_0001270 = _prefix "OBI_0001270"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001271"></see>
    /// </summary>
    let OBI_0001271 = _prefix "OBI_0001271"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001272"></see>
    /// </summary>
    let OBI_0001272 = _prefix "OBI_0001272"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001273"></see>
    /// </summary>
    let OBI_0001273 = _prefix "OBI_0001273"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001274"></see>
    /// </summary>
    let OBI_0001274 = _prefix "OBI_0001274"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001275"></see>
    /// </summary>
    let OBI_0001275 = _prefix "OBI_0001275"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001276"></see>
    /// </summary>
    let OBI_0001276 = _prefix "OBI_0001276"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001277"></see>
    /// </summary>
    let OBI_0001277 = _prefix "OBI_0001277"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001278"></see>
    /// </summary>
    let OBI_0001278 = _prefix "OBI_0001278"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001279"></see>
    /// </summary>
    let OBI_0001279 = _prefix "OBI_0001279"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001280"></see>
    /// </summary>
    let OBI_0001280 = _prefix "OBI_0001280"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001281"></see>
    /// </summary>
    let OBI_0001281 = _prefix "OBI_0001281"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001282"></see>
    /// </summary>
    let OBI_0001282 = _prefix "OBI_0001282"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001283"></see>
    /// </summary>
    let OBI_0001283 = _prefix "OBI_0001283"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001292"></see>
    /// </summary>
    let OBI_0001292 = _prefix "OBI_0001292"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001284"></see>
    /// </summary>
    let OBI_0001284 = _prefix "OBI_0001284"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001285"></see>
    /// </summary>
    let OBI_0001285 = _prefix "OBI_0001285"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001286"></see>
    /// </summary>
    let OBI_0001286 = _prefix "OBI_0001286"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001287"></see>
    /// </summary>
    let OBI_0001287 = _prefix "OBI_0001287"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001288"></see>
    /// </summary>
    let OBI_0001288 = _prefix "OBI_0001288"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001327"></see>
    /// </summary>
    let OBI_0001327 = _prefix "OBI_0001327"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001289"></see>
    /// </summary>
    let OBI_0001289 = _prefix "OBI_0001289"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001290"></see>
    /// </summary>
    let OBI_0001290 = _prefix "OBI_0001290"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001291"></see>
    /// </summary>
    let OBI_0001291 = _prefix "OBI_0001291"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001295"></see>
    /// </summary>
    let OBI_0001295 = _prefix "OBI_0001295"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001293"></see>
    /// </summary>
    let OBI_0001293 = _prefix "OBI_0001293"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OGMS_0000031"></see>
    /// </summary>
    let OGMS_0000031 = _prefix "OGMS_0000031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001294"></see>
    /// </summary>
    let OBI_0001294 = _prefix "OBI_0001294"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001296"></see>
    /// </summary>
    let OBI_0001296 = _prefix "OBI_0001296"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001297"></see>
    /// </summary>
    let OBI_0001297 = _prefix "OBI_0001297"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001298"></see>
    /// </summary>
    let OBI_0001298 = _prefix "OBI_0001298"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001299"></see>
    /// </summary>
    let OBI_0001299 = _prefix "OBI_0001299"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001300"></see>
    /// </summary>
    let OBI_0001300 = _prefix "OBI_0001300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001301"></see>
    /// </summary>
    let OBI_0001301 = _prefix "OBI_0001301"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001302"></see>
    /// </summary>
    let OBI_0001302 = _prefix "OBI_0001302"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001333"></see>
    /// </summary>
    let OBI_0001333 = _prefix "OBI_0001333"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001303"></see>
    /// </summary>
    let OBI_0001303 = _prefix "OBI_0001303"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001304"></see>
    /// </summary>
    let OBI_0001304 = _prefix "OBI_0001304"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001364"></see>
    /// </summary>
    let OBI_0001364 = _prefix "OBI_0001364"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001306"></see>
    /// </summary>
    let OBI_0001306 = _prefix "OBI_0001306"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001309"></see>
    /// </summary>
    let OBI_0001309 = _prefix "OBI_0001309"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001310"></see>
    /// </summary>
    let OBI_0001310 = _prefix "OBI_0001310"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001311"></see>
    /// </summary>
    let OBI_0001311 = _prefix "OBI_0001311"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001999"></see>
    /// </summary>
    let OBI_0001999 = _prefix "OBI_0001999"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000019"></see>
    /// </summary>
    let UO_0000019 = _prefix "UO_0000019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001312"></see>
    /// </summary>
    let OBI_0001312 = _prefix "OBI_0001312"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001313"></see>
    /// </summary>
    let OBI_0001313 = _prefix "OBI_0001313"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001314"></see>
    /// </summary>
    let OBI_0001314 = _prefix "OBI_0001314"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001315"></see>
    /// </summary>
    let OBI_0001315 = _prefix "OBI_0001315"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001316"></see>
    /// </summary>
    let OBI_0001316 = _prefix "OBI_0001316"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001317"></see>
    /// </summary>
    let OBI_0001317 = _prefix "OBI_0001317"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110124"></see>
    /// </summary>
    let OBI_1110124 = _prefix "OBI_1110124"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001318"></see>
    /// </summary>
    let OBI_0001318 = _prefix "OBI_0001318"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400149"></see>
    /// </summary>
    let OBI_0400149 = _prefix "OBI_0400149"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001319"></see>
    /// </summary>
    let OBI_0001319 = _prefix "OBI_0001319"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001414"></see>
    /// </summary>
    let OBI_0001414 = _prefix "OBI_0001414"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001320"></see>
    /// </summary>
    let OBI_0001320 = _prefix "OBI_0001320"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001321"></see>
    /// </summary>
    let OBI_0001321 = _prefix "OBI_0001321"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001322"></see>
    /// </summary>
    let OBI_0001322 = _prefix "OBI_0001322"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001436"></see>
    /// </summary>
    let OBI_0001436 = _prefix "OBI_0001436"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001323"></see>
    /// </summary>
    let OBI_0001323 = _prefix "OBI_0001323"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001324"></see>
    /// </summary>
    let OBI_0001324 = _prefix "OBI_0001324"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001484"></see>
    /// </summary>
    let OBI_0001484 = _prefix "OBI_0001484"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001983"></see>
    /// </summary>
    let OBI_0001983 = _prefix "OBI_0001983"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001325"></see>
    /// </summary>
    let OBI_0001325 = _prefix "OBI_0001325"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001326"></see>
    /// </summary>
    let OBI_0001326 = _prefix "OBI_0001326"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001328"></see>
    /// </summary>
    let OBI_0001328 = _prefix "OBI_0001328"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000105"></see>
    /// </summary>
    let UBERON_0000105 = _prefix "UBERON_0000105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001329"></see>
    /// </summary>
    let OBI_0001329 = _prefix "OBI_0001329"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001330"></see>
    /// </summary>
    let OBI_0001330 = _prefix "OBI_0001330"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001459"></see>
    /// </summary>
    let OBI_0001459 = _prefix "OBI_0001459"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001332"></see>
    /// </summary>
    let OBI_0001332 = _prefix "OBI_0001332"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001334"></see>
    /// </summary>
    let OBI_0001334 = _prefix "OBI_0001334"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001335"></see>
    /// </summary>
    let OBI_0001335 = _prefix "OBI_0001335"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000276"></see>
    /// </summary>
    let SO_0000276 = _prefix "SO_0000276"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001926"></see>
    /// </summary>
    let OBI_0001926 = _prefix "OBI_0001926"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001336"></see>
    /// </summary>
    let OBI_0001336 = _prefix "OBI_0001336"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001337"></see>
    /// </summary>
    let OBI_0001337 = _prefix "OBI_0001337"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OGMS_0000015"></see>
    /// </summary>
    let OGMS_0000015 = _prefix "OGMS_0000015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001338"></see>
    /// </summary>
    let OBI_0001338 = _prefix "OBI_0001338"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001339"></see>
    /// </summary>
    let OBI_0001339 = _prefix "OBI_0001339"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001340"></see>
    /// </summary>
    let OBI_0001340 = _prefix "OBI_0001340"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001341"></see>
    /// </summary>
    let OBI_0001341 = _prefix "OBI_0001341"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001342"></see>
    /// </summary>
    let OBI_0001342 = _prefix "OBI_0001342"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001343"></see>
    /// </summary>
    let OBI_0001343 = _prefix "OBI_0001343"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001344"></see>
    /// </summary>
    let OBI_0001344 = _prefix "OBI_0001344"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001345"></see>
    /// </summary>
    let OBI_0001345 = _prefix "OBI_0001345"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001346"></see>
    /// </summary>
    let OBI_0001346 = _prefix "OBI_0001346"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001347"></see>
    /// </summary>
    let OBI_0001347 = _prefix "OBI_0001347"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001348"></see>
    /// </summary>
    let OBI_0001348 = _prefix "OBI_0001348"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001349"></see>
    /// </summary>
    let OBI_0001349 = _prefix "OBI_0001349"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001350"></see>
    /// </summary>
    let OBI_0001350 = _prefix "OBI_0001350"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001352"></see>
    /// </summary>
    let OBI_0001352 = _prefix "OBI_0001352"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001353"></see>
    /// </summary>
    let OBI_0001353 = _prefix "OBI_0001353"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001368"></see>
    /// </summary>
    let OBI_0001368 = _prefix "OBI_0001368"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001354"></see>
    /// </summary>
    let OBI_0001354 = _prefix "OBI_0001354"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001355"></see>
    /// </summary>
    let OBI_0001355 = _prefix "OBI_0001355"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001356"></see>
    /// </summary>
    let OBI_0001356 = _prefix "OBI_0001356"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001390"></see>
    /// </summary>
    let OBI_0001390 = _prefix "OBI_0001390"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001357"></see>
    /// </summary>
    let OBI_0001357 = _prefix "OBI_0001357"
    /// <summary>
    /// post transcription modification design?
    /// or more clear RNAi design / antibody targeting design?
    /// need to check the use cases
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001358"></see></summary>
    let OBI_0001358 = _prefix "OBI_0001358"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001359"></see>
    /// </summary>
    let OBI_0001359 = _prefix "OBI_0001359"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001360"></see>
    /// </summary>
    let OBI_0001360 = _prefix "OBI_0001360"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001361"></see>
    /// </summary>
    let OBI_0001361 = _prefix "OBI_0001361"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001362"></see>
    /// </summary>
    let OBI_0001362 = _prefix "OBI_0001362"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001365"></see>
    /// </summary>
    let OBI_0001365 = _prefix "OBI_0001365"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001366"></see>
    /// </summary>
    let OBI_0001366 = _prefix "OBI_0001366"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001367"></see>
    /// </summary>
    let OBI_0001367 = _prefix "OBI_0001367"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001369"></see>
    /// </summary>
    let OBI_0001369 = _prefix "OBI_0001369"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001370"></see>
    /// </summary>
    let OBI_0001370 = _prefix "OBI_0001370"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001371"></see>
    /// </summary>
    let OBI_0001371 = _prefix "OBI_0001371"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001372"></see>
    /// </summary>
    let OBI_0001372 = _prefix "OBI_0001372"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001373"></see>
    /// </summary>
    let OBI_0001373 = _prefix "OBI_0001373"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001374"></see>
    /// </summary>
    let OBI_0001374 = _prefix "OBI_0001374"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001375"></see>
    /// </summary>
    let OBI_0001375 = _prefix "OBI_0001375"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001376"></see>
    /// </summary>
    let OBI_0001376 = _prefix "OBI_0001376"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001377"></see>
    /// </summary>
    let OBI_0001377 = _prefix "OBI_0001377"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001378"></see>
    /// </summary>
    let OBI_0001378 = _prefix "OBI_0001378"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001379"></see>
    /// </summary>
    let OBI_0001379 = _prefix "OBI_0001379"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001380"></see>
    /// </summary>
    let OBI_0001380 = _prefix "OBI_0001380"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001381"></see>
    /// </summary>
    let OBI_0001381 = _prefix "OBI_0001381"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001382"></see>
    /// </summary>
    let OBI_0001382 = _prefix "OBI_0001382"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001383"></see>
    /// </summary>
    let OBI_0001383 = _prefix "OBI_0001383"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001384"></see>
    /// </summary>
    let OBI_0001384 = _prefix "OBI_0001384"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001385"></see>
    /// </summary>
    let OBI_0001385 = _prefix "OBI_0001385"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001386"></see>
    /// </summary>
    let OBI_0001386 = _prefix "OBI_0001386"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001387"></see>
    /// </summary>
    let OBI_0001387 = _prefix "OBI_0001387"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001389"></see>
    /// </summary>
    let OBI_0001389 = _prefix "OBI_0001389"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001392"></see>
    /// </summary>
    let OBI_0001392 = _prefix "OBI_0001392"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110130"></see>
    /// </summary>
    let OBI_1110130 = _prefix "OBI_1110130"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001393"></see>
    /// </summary>
    let OBI_0001393 = _prefix "OBI_0001393"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001394"></see>
    /// </summary>
    let OBI_0001394 = _prefix "OBI_0001394"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001395"></see>
    /// </summary>
    let OBI_0001395 = _prefix "OBI_0001395"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001396"></see>
    /// </summary>
    let OBI_0001396 = _prefix "OBI_0001396"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001397"></see>
    /// </summary>
    let OBI_0001397 = _prefix "OBI_0001397"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001600"></see>
    /// </summary>
    let OBI_0001600 = _prefix "OBI_0001600"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001399"></see>
    /// </summary>
    let OBI_0001399 = _prefix "OBI_0001399"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001401"></see>
    /// </summary>
    let OBI_0001401 = _prefix "OBI_0001401"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001402"></see>
    /// </summary>
    let OBI_0001402 = _prefix "OBI_0001402"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001403"></see>
    /// </summary>
    let OBI_0001403 = _prefix "OBI_0001403"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001405"></see>
    /// </summary>
    let OBI_0001405 = _prefix "OBI_0001405"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001407"></see>
    /// </summary>
    let OBI_0001407 = _prefix "OBI_0001407"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001408"></see>
    /// </summary>
    let OBI_0001408 = _prefix "OBI_0001408"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001409"></see>
    /// </summary>
    let OBI_0001409 = _prefix "OBI_0001409"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001410"></see>
    /// </summary>
    let OBI_0001410 = _prefix "OBI_0001410"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001411"></see>
    /// </summary>
    let OBI_0001411 = _prefix "OBI_0001411"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001412"></see>
    /// </summary>
    let OBI_0001412 = _prefix "OBI_0001412"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001413"></see>
    /// </summary>
    let OBI_0001413 = _prefix "OBI_0001413"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001415"></see>
    /// </summary>
    let OBI_0001415 = _prefix "OBI_0001415"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001417"></see>
    /// </summary>
    let OBI_0001417 = _prefix "OBI_0001417"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001418"></see>
    /// </summary>
    let OBI_0001418 = _prefix "OBI_0001418"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001419"></see>
    /// </summary>
    let OBI_0001419 = _prefix "OBI_0001419"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001420"></see>
    /// </summary>
    let OBI_0001420 = _prefix "OBI_0001420"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001421"></see>
    /// </summary>
    let OBI_0001421 = _prefix "OBI_0001421"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001422"></see>
    /// </summary>
    let OBI_0001422 = _prefix "OBI_0001422"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001423"></see>
    /// </summary>
    let OBI_0001423 = _prefix "OBI_0001423"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001424"></see>
    /// </summary>
    let OBI_0001424 = _prefix "OBI_0001424"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001426"></see>
    /// </summary>
    let OBI_0001426 = _prefix "OBI_0001426"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001427"></see>
    /// </summary>
    let OBI_0001427 = _prefix "OBI_0001427"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001428"></see>
    /// </summary>
    let OBI_0001428 = _prefix "OBI_0001428"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001429"></see>
    /// </summary>
    let OBI_0001429 = _prefix "OBI_0001429"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001430"></see>
    /// </summary>
    let OBI_0001430 = _prefix "OBI_0001430"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001431"></see>
    /// </summary>
    let OBI_0001431 = _prefix "OBI_0001431"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001432"></see>
    /// </summary>
    let OBI_0001432 = _prefix "OBI_0001432"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001433"></see>
    /// </summary>
    let OBI_0001433 = _prefix "OBI_0001433"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001434"></see>
    /// </summary>
    let OBI_0001434 = _prefix "OBI_0001434"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001435"></see>
    /// </summary>
    let OBI_0001435 = _prefix "OBI_0001435"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001437"></see>
    /// </summary>
    let OBI_0001437 = _prefix "OBI_0001437"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001438"></see>
    /// </summary>
    let OBI_0001438 = _prefix "OBI_0001438"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001456"></see>
    /// </summary>
    let OBI_0001456 = _prefix "OBI_0001456"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001439"></see>
    /// </summary>
    let OBI_0001439 = _prefix "OBI_0001439"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001440"></see>
    /// </summary>
    let OBI_0001440 = _prefix "OBI_0001440"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001441"></see>
    /// </summary>
    let OBI_0001441 = _prefix "OBI_0001441"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001442"></see>
    /// </summary>
    let OBI_0001442 = _prefix "OBI_0001442"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001443"></see>
    /// </summary>
    let OBI_0001443 = _prefix "OBI_0001443"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001446"></see>
    /// </summary>
    let OBI_0001446 = _prefix "OBI_0001446"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001447"></see>
    /// </summary>
    let OBI_0001447 = _prefix "OBI_0001447"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001448"></see>
    /// </summary>
    let OBI_0001448 = _prefix "OBI_0001448"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001452"></see>
    /// </summary>
    let OBI_0001452 = _prefix "OBI_0001452"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001453"></see>
    /// </summary>
    let OBI_0001453 = _prefix "OBI_0001453"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001454"></see>
    /// </summary>
    let OBI_0001454 = _prefix "OBI_0001454"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001455"></see>
    /// </summary>
    let OBI_0001455 = _prefix "OBI_0001455"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001457"></see>
    /// </summary>
    let OBI_0001457 = _prefix "OBI_0001457"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001458"></see>
    /// </summary>
    let OBI_0001458 = _prefix "OBI_0001458"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001460"></see>
    /// </summary>
    let OBI_0001460 = _prefix "OBI_0001460"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001461"></see>
    /// </summary>
    let OBI_0001461 = _prefix "OBI_0001461"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001462"></see>
    /// </summary>
    let OBI_0001462 = _prefix "OBI_0001462"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001464"></see>
    /// </summary>
    let OBI_0001464 = _prefix "OBI_0001464"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001466"></see>
    /// </summary>
    let OBI_0001466 = _prefix "OBI_0001466"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001467"></see>
    /// </summary>
    let OBI_0001467 = _prefix "OBI_0001467"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001981"></see>
    /// </summary>
    let OBI_0001981 = _prefix "OBI_0001981"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001468"></see>
    /// </summary>
    let OBI_0001468 = _prefix "OBI_0001468"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001469"></see>
    /// </summary>
    let OBI_0001469 = _prefix "OBI_0001469"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110037"></see>
    /// </summary>
    let OBI_1110037 = _prefix "OBI_1110037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110125"></see>
    /// </summary>
    let OBI_1110125 = _prefix "OBI_1110125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001470"></see>
    /// </summary>
    let OBI_0001470 = _prefix "OBI_0001470"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110193"></see>
    /// </summary>
    let OBI_1110193 = _prefix "OBI_1110193"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001471"></see>
    /// </summary>
    let OBI_0001471 = _prefix "OBI_0001471"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001473"></see>
    /// </summary>
    let OBI_0001473 = _prefix "OBI_0001473"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002073"></see>
    /// </summary>
    let OBI_0002073 = _prefix "OBI_0002073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001982"></see>
    /// </summary>
    let OBI_0001982 = _prefix "OBI_0001982"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001474"></see>
    /// </summary>
    let OBI_0001474 = _prefix "OBI_0001474"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001477"></see>
    /// </summary>
    let OBI_0001477 = _prefix "OBI_0001477"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001475"></see>
    /// </summary>
    let OBI_0001475 = _prefix "OBI_0001475"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001476"></see>
    /// </summary>
    let OBI_0001476 = _prefix "OBI_0001476"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001480"></see>
    /// </summary>
    let OBI_0001480 = _prefix "OBI_0001480"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200167"></see>
    /// </summary>
    let OBI_0200167 = _prefix "OBI_0200167"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001478"></see>
    /// </summary>
    let OBI_0001478 = _prefix "OBI_0001478"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000477"></see>
    /// </summary>
    let UBERON_0000477 = _prefix "UBERON_0000477"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001481"></see>
    /// </summary>
    let OBI_0001481 = _prefix "OBI_0001481"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001482"></see>
    /// </summary>
    let OBI_0001482 = _prefix "OBI_0001482"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001483"></see>
    /// </summary>
    let OBI_0001483 = _prefix "OBI_0001483"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001980"></see>
    /// </summary>
    let OBI_0001980 = _prefix "OBI_0001980"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001485"></see>
    /// </summary>
    let OBI_0001485 = _prefix "OBI_0001485"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001633"></see>
    /// </summary>
    let OBI_0001633 = _prefix "OBI_0001633"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001505"></see>
    /// </summary>
    let OBI_0001505 = _prefix "OBI_0001505"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001486"></see>
    /// </summary>
    let OBI_0001486 = _prefix "OBI_0001486"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001503"></see>
    /// </summary>
    let OBI_0001503 = _prefix "OBI_0001503"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001487"></see>
    /// </summary>
    let OBI_0001487 = _prefix "OBI_0001487"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001488"></see>
    /// </summary>
    let OBI_0001488 = _prefix "OBI_0001488"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001489"></see>
    /// </summary>
    let OBI_0001489 = _prefix "OBI_0001489"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001490"></see>
    /// </summary>
    let OBI_0001490 = _prefix "OBI_0001490"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001491"></see>
    /// </summary>
    let OBI_0001491 = _prefix "OBI_0001491"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001492"></see>
    /// </summary>
    let OBI_0001492 = _prefix "OBI_0001492"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001493"></see>
    /// </summary>
    let OBI_0001493 = _prefix "OBI_0001493"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001955"></see>
    /// </summary>
    let OBI_0001955 = _prefix "OBI_0001955"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001550"></see>
    /// </summary>
    let OBI_0001550 = _prefix "OBI_0001550"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001494"></see>
    /// </summary>
    let OBI_0001494 = _prefix "OBI_0001494"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001496"></see>
    /// </summary>
    let OBI_0001496 = _prefix "OBI_0001496"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001498"></see>
    /// </summary>
    let OBI_0001498 = _prefix "OBI_0001498"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001499"></see>
    /// </summary>
    let OBI_0001499 = _prefix "OBI_0001499"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001500"></see>
    /// </summary>
    let OBI_0001500 = _prefix "OBI_0001500"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001502"></see>
    /// </summary>
    let OBI_0001502 = _prefix "OBI_0001502"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110119"></see>
    /// </summary>
    let OBI_1110119 = _prefix "OBI_1110119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001504"></see>
    /// </summary>
    let OBI_0001504 = _prefix "OBI_0001504"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001507"></see>
    /// </summary>
    let OBI_0001507 = _prefix "OBI_0001507"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001984"></see>
    /// </summary>
    let OBI_0001984 = _prefix "OBI_0001984"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001508"></see>
    /// </summary>
    let OBI_0001508 = _prefix "OBI_0001508"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001509"></see>
    /// </summary>
    let OBI_0001509 = _prefix "OBI_0001509"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001510"></see>
    /// </summary>
    let OBI_0001510 = _prefix "OBI_0001510"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001511"></see>
    /// </summary>
    let OBI_0001511 = _prefix "OBI_0001511"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001512"></see>
    /// </summary>
    let OBI_0001512 = _prefix "OBI_0001512"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001773"></see>
    /// </summary>
    let OBI_0001773 = _prefix "OBI_0001773"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001513"></see>
    /// </summary>
    let OBI_0001513 = _prefix "OBI_0001513"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001555"></see>
    /// </summary>
    let OBI_0001555 = _prefix "OBI_0001555"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001514"></see>
    /// </summary>
    let OBI_0001514 = _prefix "OBI_0001514"
    /// <summary>
    /// Here we need to go back to the defintoin of storage process. It has object specification which is material maintenance. Not necessareley a material maintenance is needed in a storage process.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001515"></see></summary>
    let OBI_0001515 = _prefix "OBI_0001515"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001528"></see>
    /// </summary>
    let OBI_0001528 = _prefix "OBI_0001528"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001516"></see>
    /// </summary>
    let OBI_0001516 = _prefix "OBI_0001516"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001991"></see>
    /// </summary>
    let OBI_0001991 = _prefix "OBI_0001991"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000036"></see>
    /// </summary>
    let OBI_1000036 = _prefix "OBI_1000036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001517"></see>
    /// </summary>
    let OBI_0001517 = _prefix "OBI_0001517"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001992"></see>
    /// </summary>
    let OBI_0001992 = _prefix "OBI_0001992"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001518"></see>
    /// </summary>
    let OBI_0001518 = _prefix "OBI_0001518"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001519"></see>
    /// </summary>
    let OBI_0001519 = _prefix "OBI_0001519"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001579"></see>
    /// </summary>
    let OBI_0001579 = _prefix "OBI_0001579"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001520"></see>
    /// </summary>
    let OBI_0001520 = _prefix "OBI_0001520"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001521"></see>
    /// </summary>
    let OBI_0001521 = _prefix "OBI_0001521"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001522"></see>
    /// </summary>
    let OBI_0001522 = _prefix "OBI_0001522"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001886"></see>
    /// </summary>
    let OBI_0001886 = _prefix "OBI_0001886"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001523"></see>
    /// </summary>
    let OBI_0001523 = _prefix "OBI_0001523"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001772"></see>
    /// </summary>
    let OBI_0001772 = _prefix "OBI_0001772"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001524"></see>
    /// </summary>
    let OBI_0001524 = _prefix "OBI_0001524"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001987"></see>
    /// </summary>
    let OBI_0001987 = _prefix "OBI_0001987"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000285"></see>
    /// </summary>
    let UO_0000285 = _prefix "UO_0000285"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001525"></see>
    /// </summary>
    let OBI_0001525 = _prefix "OBI_0001525"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001526"></see>
    /// </summary>
    let OBI_0001526 = _prefix "OBI_0001526"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001527"></see>
    /// </summary>
    let OBI_0001527 = _prefix "OBI_0001527"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001529"></see>
    /// </summary>
    let OBI_0001529 = _prefix "OBI_0001529"
    /// <summary>
    /// Information content entity was used as specified input and output since it was more appropriate then data item or dataset.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001530"></see></summary>
    let OBI_0001530 = _prefix "OBI_0001530"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001531"></see>
    /// </summary>
    let OBI_0001531 = _prefix "OBI_0001531"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001990"></see>
    /// </summary>
    let OBI_0001990 = _prefix "OBI_0001990"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000031"></see>
    /// </summary>
    let UO_0000031 = _prefix "UO_0000031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001532"></see>
    /// </summary>
    let OBI_0001532 = _prefix "OBI_0001532"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001533"></see>
    /// </summary>
    let OBI_0001533 = _prefix "OBI_0001533"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001534"></see>
    /// </summary>
    let OBI_0001534 = _prefix "OBI_0001534"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001535"></see>
    /// </summary>
    let OBI_0001535 = _prefix "OBI_0001535"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001537"></see>
    /// </summary>
    let OBI_0001537 = _prefix "OBI_0001537"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001988"></see>
    /// </summary>
    let OBI_0001988 = _prefix "OBI_0001988"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001538"></see>
    /// </summary>
    let OBI_0001538 = _prefix "OBI_0001538"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001539"></see>
    /// </summary>
    let OBI_0001539 = _prefix "OBI_0001539"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001540"></see>
    /// </summary>
    let OBI_0001540 = _prefix "OBI_0001540"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001541"></see>
    /// </summary>
    let OBI_0001541 = _prefix "OBI_0001541"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001994"></see>
    /// </summary>
    let OBI_0001994 = _prefix "OBI_0001994"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000281"></see>
    /// </summary>
    let UO_0000281 = _prefix "UO_0000281"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001542"></see>
    /// </summary>
    let OBI_0001542 = _prefix "OBI_0001542"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001543"></see>
    /// </summary>
    let OBI_0001543 = _prefix "OBI_0001543"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001544"></see>
    /// </summary>
    let OBI_0001544 = _prefix "OBI_0001544"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001545"></see>
    /// </summary>
    let OBI_0001545 = _prefix "OBI_0001545"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001546"></see>
    /// </summary>
    let OBI_0001546 = _prefix "OBI_0001546"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001834"></see>
    /// </summary>
    let OBI_0001834 = _prefix "OBI_0001834"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001547"></see>
    /// </summary>
    let OBI_0001547 = _prefix "OBI_0001547"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001549"></see>
    /// </summary>
    let OBI_0001549 = _prefix "OBI_0001549"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002072"></see>
    /// </summary>
    let OBI_0002072 = _prefix "OBI_0002072"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001551"></see>
    /// </summary>
    let OBI_0001551 = _prefix "OBI_0001551"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001552"></see>
    /// </summary>
    let OBI_0001552 = _prefix "OBI_0001552"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001607"></see>
    /// </summary>
    let OBI_0001607 = _prefix "OBI_0001607"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001553"></see>
    /// </summary>
    let OBI_0001553 = _prefix "OBI_0001553"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110126"></see>
    /// </summary>
    let OBI_1110126 = _prefix "OBI_1110126"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001554"></see>
    /// </summary>
    let OBI_0001554 = _prefix "OBI_0001554"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001556"></see>
    /// </summary>
    let OBI_0001556 = _prefix "OBI_0001556"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001557"></see>
    /// </summary>
    let OBI_0001557 = _prefix "OBI_0001557"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001558"></see>
    /// </summary>
    let OBI_0001558 = _prefix "OBI_0001558"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001559"></see>
    /// </summary>
    let OBI_0001559 = _prefix "OBI_0001559"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001560"></see>
    /// </summary>
    let OBI_0001560 = _prefix "OBI_0001560"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001561"></see>
    /// </summary>
    let OBI_0001561 = _prefix "OBI_0001561"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001562"></see>
    /// </summary>
    let OBI_0001562 = _prefix "OBI_0001562"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110178"></see>
    /// </summary>
    let OBI_1110178 = _prefix "OBI_1110178"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001563"></see>
    /// </summary>
    let OBI_0001563 = _prefix "OBI_0001563"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001564"></see>
    /// </summary>
    let OBI_0001564 = _prefix "OBI_0001564"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001989"></see>
    /// </summary>
    let OBI_0001989 = _prefix "OBI_0001989"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001565"></see>
    /// </summary>
    let OBI_0001565 = _prefix "OBI_0001565"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001566"></see>
    /// </summary>
    let OBI_0001566 = _prefix "OBI_0001566"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000005"></see>
    /// </summary>
    let UO_0000005 = _prefix "UO_0000005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001567"></see>
    /// </summary>
    let OBI_0001567 = _prefix "OBI_0001567"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001993"></see>
    /// </summary>
    let OBI_0001993 = _prefix "OBI_0001993"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000106"></see>
    /// </summary>
    let UO_0000106 = _prefix "UO_0000106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001568"></see>
    /// </summary>
    let OBI_0001568 = _prefix "OBI_0001568"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001569"></see>
    /// </summary>
    let OBI_0001569 = _prefix "OBI_0001569"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001570"></see>
    /// </summary>
    let OBI_0001570 = _prefix "OBI_0001570"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001572"></see>
    /// </summary>
    let OBI_0001572 = _prefix "OBI_0001572"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001574"></see>
    /// </summary>
    let OBI_0001574 = _prefix "OBI_0001574"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001575"></see>
    /// </summary>
    let OBI_0001575 = _prefix "OBI_0001575"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001576"></see>
    /// </summary>
    let OBI_0001576 = _prefix "OBI_0001576"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001577"></see>
    /// </summary>
    let OBI_0001577 = _prefix "OBI_0001577"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001578"></see>
    /// </summary>
    let OBI_0001578 = _prefix "OBI_0001578"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001580"></see>
    /// </summary>
    let OBI_0001580 = _prefix "OBI_0001580"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001582"></see>
    /// </summary>
    let OBI_0001582 = _prefix "OBI_0001582"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001584"></see>
    /// </summary>
    let OBI_0001584 = _prefix "OBI_0001584"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001585"></see>
    /// </summary>
    let OBI_0001585 = _prefix "OBI_0001585"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001587"></see>
    /// </summary>
    let OBI_0001587 = _prefix "OBI_0001587"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001586"></see>
    /// </summary>
    let OBI_0001586 = _prefix "OBI_0001586"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001589"></see>
    /// </summary>
    let OBI_0001589 = _prefix "OBI_0001589"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001590"></see>
    /// </summary>
    let OBI_0001590 = _prefix "OBI_0001590"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001591"></see>
    /// </summary>
    let OBI_0001591 = _prefix "OBI_0001591"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001592"></see>
    /// </summary>
    let OBI_0001592 = _prefix "OBI_0001592"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001593"></see>
    /// </summary>
    let OBI_0001593 = _prefix "OBI_0001593"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001594"></see>
    /// </summary>
    let OBI_0001594 = _prefix "OBI_0001594"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001595"></see>
    /// </summary>
    let OBI_0001595 = _prefix "OBI_0001595"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002050"></see>
    /// </summary>
    let OBI_0002050 = _prefix "OBI_0002050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001596"></see>
    /// </summary>
    let OBI_0001596 = _prefix "OBI_0001596"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001597"></see>
    /// </summary>
    let OBI_0001597 = _prefix "OBI_0001597"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001598"></see>
    /// </summary>
    let OBI_0001598 = _prefix "OBI_0001598"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001599"></see>
    /// </summary>
    let OBI_0001599 = _prefix "OBI_0001599"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001601"></see>
    /// </summary>
    let OBI_0001601 = _prefix "OBI_0001601"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001602"></see>
    /// </summary>
    let OBI_0001602 = _prefix "OBI_0001602"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001604"></see>
    /// </summary>
    let OBI_0001604 = _prefix "OBI_0001604"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000027"></see>
    /// </summary>
    let UO_0000027 = _prefix "UO_0000027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001606"></see>
    /// </summary>
    let OBI_0001606 = _prefix "OBI_0001606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001608"></see>
    /// </summary>
    let OBI_0001608 = _prefix "OBI_0001608"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001609"></see>
    /// </summary>
    let OBI_0001609 = _prefix "OBI_0001609"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001610"></see>
    /// </summary>
    let OBI_0001610 = _prefix "OBI_0001610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001611"></see>
    /// </summary>
    let OBI_0001611 = _prefix "OBI_0001611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001612"></see>
    /// </summary>
    let OBI_0001612 = _prefix "OBI_0001612"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001613"></see>
    /// </summary>
    let OBI_0001613 = _prefix "OBI_0001613"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001614"></see>
    /// </summary>
    let OBI_0001614 = _prefix "OBI_0001614"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001615"></see>
    /// </summary>
    let OBI_0001615 = _prefix "OBI_0001615"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001616"></see>
    /// </summary>
    let OBI_0001616 = _prefix "OBI_0001616"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001617"></see>
    /// </summary>
    let OBI_0001617 = _prefix "OBI_0001617"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001618"></see>
    /// </summary>
    let OBI_0001618 = _prefix "OBI_0001618"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001619"></see>
    /// </summary>
    let OBI_0001619 = _prefix "OBI_0001619"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002223"></see>
    /// </summary>
    let RO_0002223 = _prefix "RO_0002223"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001620"></see>
    /// </summary>
    let OBI_0001620 = _prefix "OBI_0001620"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001621"></see>
    /// </summary>
    let OBI_0001621 = _prefix "OBI_0001621"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001622"></see>
    /// </summary>
    let OBI_0001622 = _prefix "OBI_0001622"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001623"></see>
    /// </summary>
    let OBI_0001623 = _prefix "OBI_0001623"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001624"></see>
    /// </summary>
    let OBI_0001624 = _prefix "OBI_0001624"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001625"></see>
    /// </summary>
    let OBI_0001625 = _prefix "OBI_0001625"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001626"></see>
    /// </summary>
    let OBI_0001626 = _prefix "OBI_0001626"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001627"></see>
    /// </summary>
    let OBI_0001627 = _prefix "OBI_0001627"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001628"></see>
    /// </summary>
    let OBI_0001628 = _prefix "OBI_0001628"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001629"></see>
    /// </summary>
    let OBI_0001629 = _prefix "OBI_0001629"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001636"></see>
    /// </summary>
    let OBI_0001636 = _prefix "OBI_0001636"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001630"></see>
    /// </summary>
    let OBI_0001630 = _prefix "OBI_0001630"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001631"></see>
    /// </summary>
    let OBI_0001631 = _prefix "OBI_0001631"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001632"></see>
    /// </summary>
    let OBI_0001632 = _prefix "OBI_0001632"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600017"></see>
    /// </summary>
    let OBI_0600017 = _prefix "OBI_0600017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001634"></see>
    /// </summary>
    let OBI_0001634 = _prefix "OBI_0001634"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001635"></see>
    /// </summary>
    let OBI_0001635 = _prefix "OBI_0001635"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001979"></see>
    /// </summary>
    let OBI_0001979 = _prefix "OBI_0001979"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001637"></see>
    /// </summary>
    let OBI_0001637 = _prefix "OBI_0001637"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001638"></see>
    /// </summary>
    let OBI_0001638 = _prefix "OBI_0001638"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001708"></see>
    /// </summary>
    let OBI_0001708 = _prefix "OBI_0001708"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001639"></see>
    /// </summary>
    let OBI_0001639 = _prefix "OBI_0001639"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001704"></see>
    /// </summary>
    let OBI_0001704 = _prefix "OBI_0001704"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001702"></see>
    /// </summary>
    let OBI_0001702 = _prefix "OBI_0001702"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001640"></see>
    /// </summary>
    let OBI_0001640 = _prefix "OBI_0001640"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001706"></see>
    /// </summary>
    let OBI_0001706 = _prefix "OBI_0001706"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001641"></see>
    /// </summary>
    let OBI_0001641 = _prefix "OBI_0001641"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001642"></see>
    /// </summary>
    let OBI_0001642 = _prefix "OBI_0001642"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001643"></see>
    /// </summary>
    let OBI_0001643 = _prefix "OBI_0001643"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001644"></see>
    /// </summary>
    let OBI_0001644 = _prefix "OBI_0001644"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001645"></see>
    /// </summary>
    let OBI_0001645 = _prefix "OBI_0001645"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001703"></see>
    /// </summary>
    let OBI_0001703 = _prefix "OBI_0001703"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001646"></see>
    /// </summary>
    let OBI_0001646 = _prefix "OBI_0001646"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001721"></see>
    /// </summary>
    let OBI_0001721 = _prefix "OBI_0001721"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001647"></see>
    /// </summary>
    let OBI_0001647 = _prefix "OBI_0001647"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001648"></see>
    /// </summary>
    let OBI_0001648 = _prefix "OBI_0001648"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001699"></see>
    /// </summary>
    let OBI_0001699 = _prefix "OBI_0001699"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001649"></see>
    /// </summary>
    let OBI_0001649 = _prefix "OBI_0001649"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001650"></see>
    /// </summary>
    let OBI_0001650 = _prefix "OBI_0001650"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001651"></see>
    /// </summary>
    let OBI_0001651 = _prefix "OBI_0001651"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001652"></see>
    /// </summary>
    let OBI_0001652 = _prefix "OBI_0001652"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001653"></see>
    /// </summary>
    let OBI_0001653 = _prefix "OBI_0001653"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001700"></see>
    /// </summary>
    let OBI_0001700 = _prefix "OBI_0001700"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001654"></see>
    /// </summary>
    let OBI_0001654 = _prefix "OBI_0001654"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001655"></see>
    /// </summary>
    let OBI_0001655 = _prefix "OBI_0001655"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001656"></see>
    /// </summary>
    let OBI_0001656 = _prefix "OBI_0001656"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001657"></see>
    /// </summary>
    let OBI_0001657 = _prefix "OBI_0001657"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001658"></see>
    /// </summary>
    let OBI_0001658 = _prefix "OBI_0001658"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001659"></see>
    /// </summary>
    let OBI_0001659 = _prefix "OBI_0001659"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001660"></see>
    /// </summary>
    let OBI_0001660 = _prefix "OBI_0001660"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001809"></see>
    /// </summary>
    let OBI_0001809 = _prefix "OBI_0001809"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001661"></see>
    /// </summary>
    let OBI_0001661 = _prefix "OBI_0001661"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001662"></see>
    /// </summary>
    let OBI_0001662 = _prefix "OBI_0001662"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001663"></see>
    /// </summary>
    let OBI_0001663 = _prefix "OBI_0001663"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001810"></see>
    /// </summary>
    let OBI_0001810 = _prefix "OBI_0001810"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001664"></see>
    /// </summary>
    let OBI_0001664 = _prefix "OBI_0001664"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001665"></see>
    /// </summary>
    let OBI_0001665 = _prefix "OBI_0001665"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001666"></see>
    /// </summary>
    let OBI_0001666 = _prefix "OBI_0001666"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001667"></see>
    /// </summary>
    let OBI_0001667 = _prefix "OBI_0001667"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001668"></see>
    /// </summary>
    let OBI_0001668 = _prefix "OBI_0001668"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001669"></see>
    /// </summary>
    let OBI_0001669 = _prefix "OBI_0001669"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001670"></see>
    /// </summary>
    let OBI_0001670 = _prefix "OBI_0001670"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001671"></see>
    /// </summary>
    let OBI_0001671 = _prefix "OBI_0001671"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001672"></see>
    /// </summary>
    let OBI_0001672 = _prefix "OBI_0001672"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001673"></see>
    /// </summary>
    let OBI_0001673 = _prefix "OBI_0001673"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001674"></see>
    /// </summary>
    let OBI_0001674 = _prefix "OBI_0001674"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001675"></see>
    /// </summary>
    let OBI_0001675 = _prefix "OBI_0001675"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110162"></see>
    /// </summary>
    let OBI_1110162 = _prefix "OBI_1110162"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001676"></see>
    /// </summary>
    let OBI_0001676 = _prefix "OBI_0001676"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001677"></see>
    /// </summary>
    let OBI_0001677 = _prefix "OBI_0001677"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001678"></see>
    /// </summary>
    let OBI_0001678 = _prefix "OBI_0001678"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001679"></see>
    /// </summary>
    let OBI_0001679 = _prefix "OBI_0001679"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001680"></see>
    /// </summary>
    let OBI_0001680 = _prefix "OBI_0001680"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001681"></see>
    /// </summary>
    let OBI_0001681 = _prefix "OBI_0001681"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001682"></see>
    /// </summary>
    let OBI_0001682 = _prefix "OBI_0001682"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001683"></see>
    /// </summary>
    let OBI_0001683 = _prefix "OBI_0001683"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001686"></see>
    /// </summary>
    let OBI_0001686 = _prefix "OBI_0001686"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001684"></see>
    /// </summary>
    let OBI_0001684 = _prefix "OBI_0001684"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001685"></see>
    /// </summary>
    let OBI_0001685 = _prefix "OBI_0001685"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001687"></see>
    /// </summary>
    let OBI_0001687 = _prefix "OBI_0001687"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001689"></see>
    /// </summary>
    let OBI_0001689 = _prefix "OBI_0001689"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001690"></see>
    /// </summary>
    let OBI_0001690 = _prefix "OBI_0001690"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001691"></see>
    /// </summary>
    let OBI_0001691 = _prefix "OBI_0001691"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001692"></see>
    /// </summary>
    let OBI_0001692 = _prefix "OBI_0001692"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001698"></see>
    /// </summary>
    let OBI_0001698 = _prefix "OBI_0001698"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001693"></see>
    /// </summary>
    let OBI_0001693 = _prefix "OBI_0001693"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001694"></see>
    /// </summary>
    let OBI_0001694 = _prefix "OBI_0001694"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001695"></see>
    /// </summary>
    let OBI_0001695 = _prefix "OBI_0001695"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001696"></see>
    /// </summary>
    let OBI_0001696 = _prefix "OBI_0001696"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001710"></see>
    /// </summary>
    let OBI_0001710 = _prefix "OBI_0001710"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001697"></see>
    /// </summary>
    let OBI_0001697 = _prefix "OBI_0001697"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001701"></see>
    /// </summary>
    let OBI_0001701 = _prefix "OBI_0001701"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110014"></see>
    /// </summary>
    let OBI_1110014 = _prefix "OBI_1110014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110045"></see>
    /// </summary>
    let OBI_1110045 = _prefix "OBI_1110045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110127"></see>
    /// </summary>
    let OBI_1110127 = _prefix "OBI_1110127"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001705"></see>
    /// </summary>
    let OBI_0001705 = _prefix "OBI_0001705"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001707"></see>
    /// </summary>
    let OBI_0001707 = _prefix "OBI_0001707"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001709"></see>
    /// </summary>
    let OBI_0001709 = _prefix "OBI_0001709"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001711"></see>
    /// </summary>
    let OBI_0001711 = _prefix "OBI_0001711"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001712"></see>
    /// </summary>
    let OBI_0001712 = _prefix "OBI_0001712"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001713"></see>
    /// </summary>
    let OBI_0001713 = _prefix "OBI_0001713"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001714"></see>
    /// </summary>
    let OBI_0001714 = _prefix "OBI_0001714"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001715"></see>
    /// </summary>
    let OBI_0001715 = _prefix "OBI_0001715"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001716"></see>
    /// </summary>
    let OBI_0001716 = _prefix "OBI_0001716"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001717"></see>
    /// </summary>
    let OBI_0001717 = _prefix "OBI_0001717"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001718"></see>
    /// </summary>
    let OBI_0001718 = _prefix "OBI_0001718"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001719"></see>
    /// </summary>
    let OBI_0001719 = _prefix "OBI_0001719"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001720"></see>
    /// </summary>
    let OBI_0001720 = _prefix "OBI_0001720"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001722"></see>
    /// </summary>
    let OBI_0001722 = _prefix "OBI_0001722"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001723"></see>
    /// </summary>
    let OBI_0001723 = _prefix "OBI_0001723"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001724"></see>
    /// </summary>
    let OBI_0001724 = _prefix "OBI_0001724"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001725"></see>
    /// </summary>
    let OBI_0001725 = _prefix "OBI_0001725"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001726"></see>
    /// </summary>
    let OBI_0001726 = _prefix "OBI_0001726"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001727"></see>
    /// </summary>
    let OBI_0001727 = _prefix "OBI_0001727"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001728"></see>
    /// </summary>
    let OBI_0001728 = _prefix "OBI_0001728"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001729"></see>
    /// </summary>
    let OBI_0001729 = _prefix "OBI_0001729"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001730"></see>
    /// </summary>
    let OBI_0001730 = _prefix "OBI_0001730"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000284"></see>
    /// </summary>
    let UO_0000284 = _prefix "UO_0000284"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001731"></see>
    /// </summary>
    let OBI_0001731 = _prefix "OBI_0001731"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001732"></see>
    /// </summary>
    let OBI_0001732 = _prefix "OBI_0001732"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001733"></see>
    /// </summary>
    let OBI_0001733 = _prefix "OBI_0001733"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001734"></see>
    /// </summary>
    let OBI_0001734 = _prefix "OBI_0001734"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001735"></see>
    /// </summary>
    let OBI_0001735 = _prefix "OBI_0001735"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001736"></see>
    /// </summary>
    let OBI_0001736 = _prefix "OBI_0001736"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001737"></see>
    /// </summary>
    let OBI_0001737 = _prefix "OBI_0001737"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001738"></see>
    /// </summary>
    let OBI_0001738 = _prefix "OBI_0001738"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001739"></see>
    /// </summary>
    let OBI_0001739 = _prefix "OBI_0001739"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001740"></see>
    /// </summary>
    let OBI_0001740 = _prefix "OBI_0001740"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001741"></see>
    /// </summary>
    let OBI_0001741 = _prefix "OBI_0001741"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000282"></see>
    /// </summary>
    let UO_0000282 = _prefix "UO_0000282"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001742"></see>
    /// </summary>
    let OBI_0001742 = _prefix "OBI_0001742"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001743"></see>
    /// </summary>
    let OBI_0001743 = _prefix "OBI_0001743"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001744"></see>
    /// </summary>
    let OBI_0001744 = _prefix "OBI_0001744"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001745"></see>
    /// </summary>
    let OBI_0001745 = _prefix "OBI_0001745"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001746"></see>
    /// </summary>
    let OBI_0001746 = _prefix "OBI_0001746"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001747"></see>
    /// </summary>
    let OBI_0001747 = _prefix "OBI_0001747"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001748"></see>
    /// </summary>
    let OBI_0001748 = _prefix "OBI_0001748"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001749"></see>
    /// </summary>
    let OBI_0001749 = _prefix "OBI_0001749"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001750"></see>
    /// </summary>
    let OBI_0001750 = _prefix "OBI_0001750"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001751"></see>
    /// </summary>
    let OBI_0001751 = _prefix "OBI_0001751"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001752"></see>
    /// </summary>
    let OBI_0001752 = _prefix "OBI_0001752"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001753"></see>
    /// </summary>
    let OBI_0001753 = _prefix "OBI_0001753"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001754"></see>
    /// </summary>
    let OBI_0001754 = _prefix "OBI_0001754"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001755"></see>
    /// </summary>
    let OBI_0001755 = _prefix "OBI_0001755"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001756"></see>
    /// </summary>
    let OBI_0001756 = _prefix "OBI_0001756"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001757"></see>
    /// </summary>
    let OBI_0001757 = _prefix "OBI_0001757"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001758"></see>
    /// </summary>
    let OBI_0001758 = _prefix "OBI_0001758"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001759"></see>
    /// </summary>
    let OBI_0001759 = _prefix "OBI_0001759"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001776"></see>
    /// </summary>
    let OBI_0001776 = _prefix "OBI_0001776"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001760"></see>
    /// </summary>
    let OBI_0001760 = _prefix "OBI_0001760"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001779"></see>
    /// </summary>
    let OBI_0001779 = _prefix "OBI_0001779"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001761"></see>
    /// </summary>
    let OBI_0001761 = _prefix "OBI_0001761"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001778"></see>
    /// </summary>
    let OBI_0001778 = _prefix "OBI_0001778"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001762"></see>
    /// </summary>
    let OBI_0001762 = _prefix "OBI_0001762"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001774"></see>
    /// </summary>
    let OBI_0001774 = _prefix "OBI_0001774"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001763"></see>
    /// </summary>
    let OBI_0001763 = _prefix "OBI_0001763"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001777"></see>
    /// </summary>
    let OBI_0001777 = _prefix "OBI_0001777"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001764"></see>
    /// </summary>
    let OBI_0001764 = _prefix "OBI_0001764"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001765"></see>
    /// </summary>
    let OBI_0001765 = _prefix "OBI_0001765"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001766"></see>
    /// </summary>
    let OBI_0001766 = _prefix "OBI_0001766"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001767"></see>
    /// </summary>
    let OBI_0001767 = _prefix "OBI_0001767"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001775"></see>
    /// </summary>
    let OBI_0001775 = _prefix "OBI_0001775"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001768"></see>
    /// </summary>
    let OBI_0001768 = _prefix "OBI_0001768"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001769"></see>
    /// </summary>
    let OBI_0001769 = _prefix "OBI_0001769"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001770"></see>
    /// </summary>
    let OBI_0001770 = _prefix "OBI_0001770"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001771"></see>
    /// </summary>
    let OBI_0001771 = _prefix "OBI_0001771"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001780"></see>
    /// </summary>
    let OBI_0001780 = _prefix "OBI_0001780"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001781"></see>
    /// </summary>
    let OBI_0001781 = _prefix "OBI_0001781"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001782"></see>
    /// </summary>
    let OBI_0001782 = _prefix "OBI_0001782"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001783"></see>
    /// </summary>
    let OBI_0001783 = _prefix "OBI_0001783"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001784"></see>
    /// </summary>
    let OBI_0001784 = _prefix "OBI_0001784"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001785"></see>
    /// </summary>
    let OBI_0001785 = _prefix "OBI_0001785"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001786"></see>
    /// </summary>
    let OBI_0001786 = _prefix "OBI_0001786"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001787"></see>
    /// </summary>
    let OBI_0001787 = _prefix "OBI_0001787"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001789"></see>
    /// </summary>
    let OBI_0001789 = _prefix "OBI_0001789"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001790"></see>
    /// </summary>
    let OBI_0001790 = _prefix "OBI_0001790"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001791"></see>
    /// </summary>
    let OBI_0001791 = _prefix "OBI_0001791"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001792"></see>
    /// </summary>
    let OBI_0001792 = _prefix "OBI_0001792"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001793"></see>
    /// </summary>
    let OBI_0001793 = _prefix "OBI_0001793"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001794"></see>
    /// </summary>
    let OBI_0001794 = _prefix "OBI_0001794"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001795"></see>
    /// </summary>
    let OBI_0001795 = _prefix "OBI_0001795"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001796"></see>
    /// </summary>
    let OBI_0001796 = _prefix "OBI_0001796"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001797"></see>
    /// </summary>
    let OBI_0001797 = _prefix "OBI_0001797"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001798"></see>
    /// </summary>
    let OBI_0001798 = _prefix "OBI_0001798"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001799"></see>
    /// </summary>
    let OBI_0001799 = _prefix "OBI_0001799"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001800"></see>
    /// </summary>
    let OBI_0001800 = _prefix "OBI_0001800"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001801"></see>
    /// </summary>
    let OBI_0001801 = _prefix "OBI_0001801"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001802"></see>
    /// </summary>
    let OBI_0001802 = _prefix "OBI_0001802"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001803"></see>
    /// </summary>
    let OBI_0001803 = _prefix "OBI_0001803"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001804"></see>
    /// </summary>
    let OBI_0001804 = _prefix "OBI_0001804"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001805"></see>
    /// </summary>
    let OBI_0001805 = _prefix "OBI_0001805"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001806"></see>
    /// </summary>
    let OBI_0001806 = _prefix "OBI_0001806"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001807"></see>
    /// </summary>
    let OBI_0001807 = _prefix "OBI_0001807"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001808"></see>
    /// </summary>
    let OBI_0001808 = _prefix "OBI_0001808"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001811"></see>
    /// </summary>
    let OBI_0001811 = _prefix "OBI_0001811"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001812"></see>
    /// </summary>
    let OBI_0001812 = _prefix "OBI_0001812"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001813"></see>
    /// </summary>
    let OBI_0001813 = _prefix "OBI_0001813"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001814"></see>
    /// </summary>
    let OBI_0001814 = _prefix "OBI_0001814"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001815"></see>
    /// </summary>
    let OBI_0001815 = _prefix "OBI_0001815"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001816"></see>
    /// </summary>
    let OBI_0001816 = _prefix "OBI_0001816"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001817"></see>
    /// </summary>
    let OBI_0001817 = _prefix "OBI_0001817"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001818"></see>
    /// </summary>
    let OBI_0001818 = _prefix "OBI_0001818"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001819"></see>
    /// </summary>
    let OBI_0001819 = _prefix "OBI_0001819"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001820"></see>
    /// </summary>
    let OBI_0001820 = _prefix "OBI_0001820"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001821"></see>
    /// </summary>
    let OBI_0001821 = _prefix "OBI_0001821"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001822"></see>
    /// </summary>
    let OBI_0001822 = _prefix "OBI_0001822"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001823"></see>
    /// </summary>
    let OBI_0001823 = _prefix "OBI_0001823"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001824"></see>
    /// </summary>
    let OBI_0001824 = _prefix "OBI_0001824"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001825"></see>
    /// </summary>
    let OBI_0001825 = _prefix "OBI_0001825"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001826"></see>
    /// </summary>
    let OBI_0001826 = _prefix "OBI_0001826"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001827"></see>
    /// </summary>
    let OBI_0001827 = _prefix "OBI_0001827"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001828"></see>
    /// </summary>
    let OBI_0001828 = _prefix "OBI_0001828"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001829"></see>
    /// </summary>
    let OBI_0001829 = _prefix "OBI_0001829"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001830"></see>
    /// </summary>
    let OBI_0001830 = _prefix "OBI_0001830"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001831"></see>
    /// </summary>
    let OBI_0001831 = _prefix "OBI_0001831"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001832"></see>
    /// </summary>
    let OBI_0001832 = _prefix "OBI_0001832"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001833"></see>
    /// </summary>
    let OBI_0001833 = _prefix "OBI_0001833"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001835"></see>
    /// </summary>
    let OBI_0001835 = _prefix "OBI_0001835"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001836"></see>
    /// </summary>
    let OBI_0001836 = _prefix "OBI_0001836"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001837"></see>
    /// </summary>
    let OBI_0001837 = _prefix "OBI_0001837"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001838"></see>
    /// </summary>
    let OBI_0001838 = _prefix "OBI_0001838"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001839"></see>
    /// </summary>
    let OBI_0001839 = _prefix "OBI_0001839"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001840"></see>
    /// </summary>
    let OBI_0001840 = _prefix "OBI_0001840"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001841"></see>
    /// </summary>
    let OBI_0001841 = _prefix "OBI_0001841"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001842"></see>
    /// </summary>
    let OBI_0001842 = _prefix "OBI_0001842"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001843"></see>
    /// </summary>
    let OBI_0001843 = _prefix "OBI_0001843"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001844"></see>
    /// </summary>
    let OBI_0001844 = _prefix "OBI_0001844"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001845"></see>
    /// </summary>
    let OBI_0001845 = _prefix "OBI_0001845"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001846"></see>
    /// </summary>
    let OBI_0001846 = _prefix "OBI_0001846"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001848"></see>
    /// </summary>
    let OBI_0001848 = _prefix "OBI_0001848"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002438"></see>
    /// </summary>
    let OBI_0002438 = _prefix "OBI_0002438"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002439"></see>
    /// </summary>
    let OBI_0002439 = _prefix "OBI_0002439"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001917"></see>
    /// </summary>
    let OBI_0001917 = _prefix "OBI_0001917"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001849"></see>
    /// </summary>
    let OBI_0001849 = _prefix "OBI_0001849"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001850"></see>
    /// </summary>
    let OBI_0001850 = _prefix "OBI_0001850"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001852"></see>
    /// </summary>
    let OBI_0001852 = _prefix "OBI_0001852"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001851"></see>
    /// </summary>
    let OBI_0001851 = _prefix "OBI_0001851"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001853"></see>
    /// </summary>
    let OBI_0001853 = _prefix "OBI_0001853"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600023"></see>
    /// </summary>
    let OBI_0600023 = _prefix "OBI_0600023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001854"></see>
    /// </summary>
    let OBI_0001854 = _prefix "OBI_0001854"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001855"></see>
    /// </summary>
    let OBI_0001855 = _prefix "OBI_0001855"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001856"></see>
    /// </summary>
    let OBI_0001856 = _prefix "OBI_0001856"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001857"></see>
    /// </summary>
    let OBI_0001857 = _prefix "OBI_0001857"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400114"></see>
    /// </summary>
    let OBI_0400114 = _prefix "OBI_0400114"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001858"></see>
    /// </summary>
    let OBI_0001858 = _prefix "OBI_0001858"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001859"></see>
    /// </summary>
    let OBI_0001859 = _prefix "OBI_0001859"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001860"></see>
    /// </summary>
    let OBI_0001860 = _prefix "OBI_0001860"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001861"></see>
    /// </summary>
    let OBI_0001861 = _prefix "OBI_0001861"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001862"></see>
    /// </summary>
    let OBI_0001862 = _prefix "OBI_0001862"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001863"></see>
    /// </summary>
    let OBI_0001863 = _prefix "OBI_0001863"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001864"></see>
    /// </summary>
    let OBI_0001864 = _prefix "OBI_0001864"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001865"></see>
    /// </summary>
    let OBI_0001865 = _prefix "OBI_0001865"
    /// <summary>
    /// Naturally occurring or experimentally incorporated nucleic acids that meet these criteria can qualify as genetic/genomic material.
    ///
    /// Qualifying examples include: (1) inherited chromosomal DNA in germ cells, stem cells, fully differentiated cells, or cell line cells, or the DNA/RNA content of a virion; (2) natural replicons exchanged through horizontal gene transfer mechanisms such as bacterial conjugation, which are capable of replication and inheritance by progeny; (3) a chromosomally integrated  gene targeting DNA construct transfected into a cell; or (4) a stable extra-chromosomal replicon delivered into cells, such as a plasmid in bacterial host with ori allowing indefinite propagation.
    ///
    /// Non-qualifying examples include a transiently transfected plasmid or siRNA oligo (as these are not able to be replicated and inherited by progeny cells).
    ///
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001868"></see></summary>
    let OBI_0001868 = _prefix "OBI_0001868"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001869"></see>
    /// </summary>
    let OBI_0001869 = _prefix "OBI_0001869"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001870"></see>
    /// </summary>
    let OBI_0001870 = _prefix "OBI_0001870"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001871"></see>
    /// </summary>
    let OBI_0001871 = _prefix "OBI_0001871"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400008"></see>
    /// </summary>
    let OBI_0400008 = _prefix "OBI_0400008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001872"></see>
    /// </summary>
    let OBI_0001872 = _prefix "OBI_0001872"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001939"></see>
    /// </summary>
    let OBI_0001939 = _prefix "OBI_0001939"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001940"></see>
    /// </summary>
    let OBI_0001940 = _prefix "OBI_0001940"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001873"></see>
    /// </summary>
    let OBI_0001873 = _prefix "OBI_0001873"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001937"></see>
    /// </summary>
    let OBI_0001937 = _prefix "OBI_0001937"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001874"></see>
    /// </summary>
    let OBI_0001874 = _prefix "OBI_0001874"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001877"></see>
    /// </summary>
    let OBI_0001877 = _prefix "OBI_0001877"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001875"></see>
    /// </summary>
    let OBI_0001875 = _prefix "OBI_0001875"
    /// <summary>
    /// A cell culture includes the cells in culture, as well as the media and all additives in which the cells are being grown or in which they are stored.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001876"></see></summary>
    let OBI_0001876 = _prefix "OBI_0001876"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001912"></see>
    /// </summary>
    let OBI_0001912 = _prefix "OBI_0001912"
    /// <summary>
    /// Cells are originally plated at a certain concentration referred to as seeding density. Upon a first passage this primary culture becomes a secondary cell culture that can be propagated to become a stable and homogneous cell line. This class covers establishment of primary cultures from any native cell - 'in vivo' cells isolated from some multicellular organism, or 'in environment' unicellular organisms isolated from some natural environment.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001878"></see></summary>
    let OBI_0001878 = _prefix "OBI_0001878"
    /// <summary>
    /// (copied from ReO)
    /// Reagents are distinguished from devices/instruments that also serve as facilitators in scientific techniques by the fact that reagents are chemical or biological in nature and necessarily participate in or have parts that participate in some chemical interaction or reaction during their intended participation in some technique.  By contrast, devices do not participate in a chemical reaction/interaction during the technique.
    ///
    /// Reagents are distinguished from study subjects/evaluants in that study subjects and evaluants are that about which conclusions are drawn and knowledge is sought in an investigation - while reagents, by definition, are not.  It should be noted, however, that reagent and study subject/evaluant roles can be borne by instances of the same type of material entity - but a given instance can only realize one of these roles in the execution of a given  assay. For example, taq polymerase can bear a reagent role or an evaluant role.  In a DNA sequencing assay aimed at generating sequence data about some plasmid, the reagent role of the taq polymerase is realized. In an assay to evaluate the quality of the taq polymerase itself, the evaluant/study subject role of the taq is realized, but not the reagent role since the taq is the subject about which data is generated.
    ///
    /// In regard to the statement that reagents are 'distinct' from the specified outputs of a technique:  note that a reagent may be incorporated into a material output of a technique, as long as the IDENTITY of this output is distinct from that of the bearer of the reagent role.  For example, dNTPs input into a PCR are reagents that become part of the material output of this technique, but this output has a new identity (ie that of a 'nucleic acid molecule') that is distinct from the identity of the dNTPs that comprise it.  Similarly, a biotin molecule input into a cell labeling technique are reagents that become part of the specified output, but the identity of the output is that of some modified cell specimen which shares identity with the input unmodified cell specimen, and not with the biotin label. Thus, we see that an important criteria of 'reagent-ness' is that it is a facilitator, and not the primary focus of an investigation or material processing technique (ie not the specified subject/evaluant about which knowledge is sought, or the specified output material of the technique).
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001879"></see></summary>
    let OBI_0001879 = _prefix "OBI_0001879"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001880"></see>
    /// </summary>
    let OBI_0001880 = _prefix "OBI_0001880"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001889"></see>
    /// </summary>
    let OBI_0001889 = _prefix "OBI_0001889"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001881"></see>
    /// </summary>
    let OBI_0001881 = _prefix "OBI_0001881"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001883"></see>
    /// </summary>
    let OBI_0001883 = _prefix "OBI_0001883"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001882"></see>
    /// </summary>
    let OBI_0001882 = _prefix "OBI_0001882"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001884"></see>
    /// </summary>
    let OBI_0001884 = _prefix "OBI_0001884"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001885"></see>
    /// </summary>
    let OBI_0001885 = _prefix "OBI_0001885"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001887"></see>
    /// </summary>
    let OBI_0001887 = _prefix "OBI_0001887"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001888"></see>
    /// </summary>
    let OBI_0001888 = _prefix "OBI_0001888"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001891"></see>
    /// </summary>
    let OBI_0001891 = _prefix "OBI_0001891"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001890"></see>
    /// </summary>
    let OBI_0001890 = _prefix "OBI_0001890"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001895"></see>
    /// </summary>
    let OBI_0001895 = _prefix "OBI_0001895"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002198"></see>
    /// </summary>
    let OBI_0002198 = _prefix "OBI_0002198"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001892"></see>
    /// </summary>
    let OBI_0001892 = _prefix "OBI_0001892"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001893"></see>
    /// </summary>
    let OBI_0001893 = _prefix "OBI_0001893"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001894"></see>
    /// </summary>
    let OBI_0001894 = _prefix "OBI_0001894"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001896"></see>
    /// </summary>
    let OBI_0001896 = _prefix "OBI_0001896"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001897"></see>
    /// </summary>
    let OBI_0001897 = _prefix "OBI_0001897"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001898"></see>
    /// </summary>
    let OBI_0001898 = _prefix "OBI_0001898"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001899"></see>
    /// </summary>
    let OBI_0001899 = _prefix "OBI_0001899"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001900"></see>
    /// </summary>
    let OBI_0001900 = _prefix "OBI_0001900"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001901"></see>
    /// </summary>
    let OBI_0001901 = _prefix "OBI_0001901"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001902"></see>
    /// </summary>
    let OBI_0001902 = _prefix "OBI_0001902"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001903"></see>
    /// </summary>
    let OBI_0001903 = _prefix "OBI_0001903"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001908"></see>
    /// </summary>
    let OBI_0001908 = _prefix "OBI_0001908"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001910"></see>
    /// </summary>
    let OBI_0001910 = _prefix "OBI_0001910"
    /// <summary>
    /// A cell line culture includes the cells in culture, as well as the media and all additives/reagents in which the cells are being grown or in which they are stored.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0001911"></see></summary>
    let OBI_0001911 = _prefix "OBI_0001911"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001913"></see>
    /// </summary>
    let OBI_0001913 = _prefix "OBI_0001913"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001914"></see>
    /// </summary>
    let OBI_0001914 = _prefix "OBI_0001914"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001915"></see>
    /// </summary>
    let OBI_0001915 = _prefix "OBI_0001915"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400099"></see>
    /// </summary>
    let OBI_0400099 = _prefix "OBI_0400099"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001916"></see>
    /// </summary>
    let OBI_0001916 = _prefix "OBI_0001916"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001918"></see>
    /// </summary>
    let OBI_0001918 = _prefix "OBI_0001918"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001919"></see>
    /// </summary>
    let OBI_0001919 = _prefix "OBI_0001919"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001920"></see>
    /// </summary>
    let OBI_0001920 = _prefix "OBI_0001920"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001921"></see>
    /// </summary>
    let OBI_0001921 = _prefix "OBI_0001921"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001922"></see>
    /// </summary>
    let OBI_0001922 = _prefix "OBI_0001922"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001923"></see>
    /// </summary>
    let OBI_0001923 = _prefix "OBI_0001923"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600056"></see>
    /// </summary>
    let OBI_0600056 = _prefix "OBI_0600056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001924"></see>
    /// </summary>
    let OBI_0001924 = _prefix "OBI_0001924"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001925"></see>
    /// </summary>
    let OBI_0001925 = _prefix "OBI_0001925"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001927"></see>
    /// </summary>
    let OBI_0001927 = _prefix "OBI_0001927"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001928"></see>
    /// </summary>
    let OBI_0001928 = _prefix "OBI_0001928"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001929"></see>
    /// </summary>
    let OBI_0001929 = _prefix "OBI_0001929"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001932"></see>
    /// </summary>
    let OBI_0001932 = _prefix "OBI_0001932"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001934"></see>
    /// </summary>
    let OBI_0001934 = _prefix "OBI_0001934"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001935"></see>
    /// </summary>
    let OBI_0001935 = _prefix "OBI_0001935"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002135"></see>
    /// </summary>
    let OBI_0002135 = _prefix "OBI_0002135"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0001248"></see>
    /// </summary>
    let SO_0001248 = _prefix "SO_0001248"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001941"></see>
    /// </summary>
    let OBI_0001941 = _prefix "OBI_0001941"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000149"></see>
    /// </summary>
    let SO_0000149 = _prefix "SO_0000149"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001942"></see>
    /// </summary>
    let OBI_0001942 = _prefix "OBI_0001942"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001943"></see>
    /// </summary>
    let OBI_0001943 = _prefix "OBI_0001943"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001944"></see>
    /// </summary>
    let OBI_0001944 = _prefix "OBI_0001944"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001945"></see>
    /// </summary>
    let OBI_0001945 = _prefix "OBI_0001945"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000148"></see>
    /// </summary>
    let SO_0000148 = _prefix "SO_0000148"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001946"></see>
    /// </summary>
    let OBI_0001946 = _prefix "OBI_0001946"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001947"></see>
    /// </summary>
    let OBI_0001947 = _prefix "OBI_0001947"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001949"></see>
    /// </summary>
    let OBI_0001949 = _prefix "OBI_0001949"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001948"></see>
    /// </summary>
    let OBI_0001948 = _prefix "OBI_0001948"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0000353"></see>
    /// </summary>
    let SO_0000353 = _prefix "SO_0000353"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001950"></see>
    /// </summary>
    let OBI_0001950 = _prefix "OBI_0001950"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001951"></see>
    /// </summary>
    let OBI_0001951 = _prefix "OBI_0001951"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001952"></see>
    /// </summary>
    let OBI_0001952 = _prefix "OBI_0001952"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001953"></see>
    /// </summary>
    let OBI_0001953 = _prefix "OBI_0001953"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001956"></see>
    /// </summary>
    let OBI_0001956 = _prefix "OBI_0001956"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001957"></see>
    /// </summary>
    let OBI_0001957 = _prefix "OBI_0001957"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001958"></see>
    /// </summary>
    let OBI_0001958 = _prefix "OBI_0001958"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001959"></see>
    /// </summary>
    let OBI_0001959 = _prefix "OBI_0001959"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002602"></see>
    /// </summary>
    let OBI_0002602 = _prefix "OBI_0002602"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001970"></see>
    /// </summary>
    let OBI_0001970 = _prefix "OBI_0001970"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001960"></see>
    /// </summary>
    let OBI_0001960 = _prefix "OBI_0001960"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001969"></see>
    /// </summary>
    let OBI_0001969 = _prefix "OBI_0001969"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001961"></see>
    /// </summary>
    let OBI_0001961 = _prefix "OBI_0001961"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001962"></see>
    /// </summary>
    let OBI_0001962 = _prefix "OBI_0001962"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001963"></see>
    /// </summary>
    let OBI_0001963 = _prefix "OBI_0001963"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001964"></see>
    /// </summary>
    let OBI_0001964 = _prefix "OBI_0001964"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001965"></see>
    /// </summary>
    let OBI_0001965 = _prefix "OBI_0001965"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001966"></see>
    /// </summary>
    let OBI_0001966 = _prefix "OBI_0001966"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200081"></see>
    /// </summary>
    let OBI_0200081 = _prefix "OBI_0200081"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200187"></see>
    /// </summary>
    let OBI_0200187 = _prefix "OBI_0200187"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001967"></see>
    /// </summary>
    let OBI_0001967 = _prefix "OBI_0001967"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001968"></see>
    /// </summary>
    let OBI_0001968 = _prefix "OBI_0001968"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001971"></see>
    /// </summary>
    let OBI_0001971 = _prefix "OBI_0001971"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001973"></see>
    /// </summary>
    let OBI_0001973 = _prefix "OBI_0001973"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001972"></see>
    /// </summary>
    let OBI_0001972 = _prefix "OBI_0001972"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001974"></see>
    /// </summary>
    let OBI_0001974 = _prefix "OBI_0001974"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001976"></see>
    /// </summary>
    let OBI_0001976 = _prefix "OBI_0001976"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002162"></see>
    /// </summary>
    let OBI_0002162 = _prefix "OBI_0002162"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600053"></see>
    /// </summary>
    let OBI_0600053 = _prefix "OBI_0600053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001986"></see>
    /// </summary>
    let OBI_0001986 = _prefix "OBI_0001986"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001995"></see>
    /// </summary>
    let OBI_0001995 = _prefix "OBI_0001995"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001996"></see>
    /// </summary>
    let OBI_0001996 = _prefix "OBI_0001996"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001997"></see>
    /// </summary>
    let OBI_0001997 = _prefix "OBI_0001997"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002449"></see>
    /// </summary>
    let OBI_0002449 = _prefix "OBI_0002449"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0001998"></see>
    /// </summary>
    let OBI_0001998 = _prefix "OBI_0001998"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002000"></see>
    /// </summary>
    let OBI_0002000 = _prefix "OBI_0002000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002001"></see>
    /// </summary>
    let OBI_0002001 = _prefix "OBI_0002001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002002"></see>
    /// </summary>
    let OBI_0002002 = _prefix "OBI_0002002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002003"></see>
    /// </summary>
    let OBI_0002003 = _prefix "OBI_0002003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002004"></see>
    /// </summary>
    let OBI_0002004 = _prefix "OBI_0002004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002005"></see>
    /// </summary>
    let OBI_0002005 = _prefix "OBI_0002005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002006"></see>
    /// </summary>
    let OBI_0002006 = _prefix "OBI_0002006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002007"></see>
    /// </summary>
    let OBI_0002007 = _prefix "OBI_0002007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002008"></see>
    /// </summary>
    let OBI_0002008 = _prefix "OBI_0002008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002009"></see>
    /// </summary>
    let OBI_0002009 = _prefix "OBI_0002009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002010"></see>
    /// </summary>
    let OBI_0002010 = _prefix "OBI_0002010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002011"></see>
    /// </summary>
    let OBI_0002011 = _prefix "OBI_0002011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002012"></see>
    /// </summary>
    let OBI_0002012 = _prefix "OBI_0002012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002013"></see>
    /// </summary>
    let OBI_0002013 = _prefix "OBI_0002013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002014"></see>
    /// </summary>
    let OBI_0002014 = _prefix "OBI_0002014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002015"></see>
    /// </summary>
    let OBI_0002015 = _prefix "OBI_0002015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002016"></see>
    /// </summary>
    let OBI_0002016 = _prefix "OBI_0002016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002017"></see>
    /// </summary>
    let OBI_0002017 = _prefix "OBI_0002017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002018"></see>
    /// </summary>
    let OBI_0002018 = _prefix "OBI_0002018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002019"></see>
    /// </summary>
    let OBI_0002019 = _prefix "OBI_0002019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002021"></see>
    /// </summary>
    let OBI_0002021 = _prefix "OBI_0002021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002022"></see>
    /// </summary>
    let OBI_0002022 = _prefix "OBI_0002022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002023"></see>
    /// </summary>
    let OBI_0002023 = _prefix "OBI_0002023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002024"></see>
    /// </summary>
    let OBI_0002024 = _prefix "OBI_0002024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002025"></see>
    /// </summary>
    let OBI_0002025 = _prefix "OBI_0002025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002026"></see>
    /// </summary>
    let OBI_0002026 = _prefix "OBI_0002026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002027"></see>
    /// </summary>
    let OBI_0002027 = _prefix "OBI_0002027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002028"></see>
    /// </summary>
    let OBI_0002028 = _prefix "OBI_0002028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002029"></see>
    /// </summary>
    let OBI_0002029 = _prefix "OBI_0002029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002030"></see>
    /// </summary>
    let OBI_0002030 = _prefix "OBI_0002030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002031"></see>
    /// </summary>
    let OBI_0002031 = _prefix "OBI_0002031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002032"></see>
    /// </summary>
    let OBI_0002032 = _prefix "OBI_0002032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002033"></see>
    /// </summary>
    let OBI_0002033 = _prefix "OBI_0002033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002034"></see>
    /// </summary>
    let OBI_0002034 = _prefix "OBI_0002034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002035"></see>
    /// </summary>
    let OBI_0002035 = _prefix "OBI_0002035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002036"></see>
    /// </summary>
    let OBI_0002036 = _prefix "OBI_0002036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002037"></see>
    /// </summary>
    let OBI_0002037 = _prefix "OBI_0002037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002038"></see>
    /// </summary>
    let OBI_0002038 = _prefix "OBI_0002038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002039"></see>
    /// </summary>
    let OBI_0002039 = _prefix "OBI_0002039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002040"></see>
    /// </summary>
    let OBI_0002040 = _prefix "OBI_0002040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002041"></see>
    /// </summary>
    let OBI_0002041 = _prefix "OBI_0002041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002042"></see>
    /// </summary>
    let OBI_0002042 = _prefix "OBI_0002042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002043"></see>
    /// </summary>
    let OBI_0002043 = _prefix "OBI_0002043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002044"></see>
    /// </summary>
    let OBI_0002044 = _prefix "OBI_0002044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002045"></see>
    /// </summary>
    let OBI_0002045 = _prefix "OBI_0002045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002046"></see>
    /// </summary>
    let OBI_0002046 = _prefix "OBI_0002046"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002047"></see>
    /// </summary>
    let OBI_0002047 = _prefix "OBI_0002047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002048"></see>
    /// </summary>
    let OBI_0002048 = _prefix "OBI_0002048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002049"></see>
    /// </summary>
    let OBI_0002049 = _prefix "OBI_0002049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002051"></see>
    /// </summary>
    let OBI_0002051 = _prefix "OBI_0002051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002052"></see>
    /// </summary>
    let OBI_0002052 = _prefix "OBI_0002052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002053"></see>
    /// </summary>
    let OBI_0002053 = _prefix "OBI_0002053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002054"></see>
    /// </summary>
    let OBI_0002054 = _prefix "OBI_0002054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002056"></see>
    /// </summary>
    let OBI_0002056 = _prefix "OBI_0002056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002057"></see>
    /// </summary>
    let OBI_0002057 = _prefix "OBI_0002057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002058"></see>
    /// </summary>
    let OBI_0002058 = _prefix "OBI_0002058"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002059"></see>
    /// </summary>
    let OBI_0002059 = _prefix "OBI_0002059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002060"></see>
    /// </summary>
    let OBI_0002060 = _prefix "OBI_0002060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002061"></see>
    /// </summary>
    let OBI_0002061 = _prefix "OBI_0002061"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002062"></see>
    /// </summary>
    let OBI_0002062 = _prefix "OBI_0002062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002063"></see>
    /// </summary>
    let OBI_0002063 = _prefix "OBI_0002063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002064"></see>
    /// </summary>
    let OBI_0002064 = _prefix "OBI_0002064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002065"></see>
    /// </summary>
    let OBI_0002065 = _prefix "OBI_0002065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002066"></see>
    /// </summary>
    let OBI_0002066 = _prefix "OBI_0002066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002067"></see>
    /// </summary>
    let OBI_0002067 = _prefix "OBI_0002067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002068"></see>
    /// </summary>
    let OBI_0002068 = _prefix "OBI_0002068"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002069"></see>
    /// </summary>
    let OBI_0002069 = _prefix "OBI_0002069"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002070"></see>
    /// </summary>
    let OBI_0002070 = _prefix "OBI_0002070"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110131"></see>
    /// </summary>
    let OBI_1110131 = _prefix "OBI_1110131"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002071"></see>
    /// </summary>
    let OBI_0002071 = _prefix "OBI_0002071"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002074"></see>
    /// </summary>
    let OBI_0002074 = _prefix "OBI_0002074"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002075"></see>
    /// </summary>
    let OBI_0002075 = _prefix "OBI_0002075"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110128"></see>
    /// </summary>
    let OBI_1110128 = _prefix "OBI_1110128"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002076"></see>
    /// </summary>
    let OBI_0002076 = _prefix "OBI_0002076"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002351"></see>
    /// </summary>
    let RO_0002351 = _prefix "RO_0002351"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002077"></see>
    /// </summary>
    let OBI_0002077 = _prefix "OBI_0002077"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002078"></see>
    /// </summary>
    let OBI_0002078 = _prefix "OBI_0002078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002079"></see>
    /// </summary>
    let OBI_0002079 = _prefix "OBI_0002079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002080"></see>
    /// </summary>
    let OBI_0002080 = _prefix "OBI_0002080"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002081"></see>
    /// </summary>
    let OBI_0002081 = _prefix "OBI_0002081"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002082"></see>
    /// </summary>
    let OBI_0002082 = _prefix "OBI_0002082"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002083"></see>
    /// </summary>
    let OBI_0002083 = _prefix "OBI_0002083"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002084"></see>
    /// </summary>
    let OBI_0002084 = _prefix "OBI_0002084"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002085"></see>
    /// </summary>
    let OBI_0002085 = _prefix "OBI_0002085"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002086"></see>
    /// </summary>
    let OBI_0002086 = _prefix "OBI_0002086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002087"></see>
    /// </summary>
    let OBI_0002087 = _prefix "OBI_0002087"
    /// <summary>
    /// Specimen containers are typically constructed or treated in a particular manner in order to perform their containing a specimen function. This will be a defined class so that any container (e.g., cryotube, vacutainer, conical test tube) with the function of containing a specimen will be inferred to be a specimen container.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0002088"></see></summary>
    let OBI_0002088 = _prefix "OBI_0002088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002090"></see>
    /// </summary>
    let OBI_0002090 = _prefix "OBI_0002090"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002091"></see>
    /// </summary>
    let OBI_0002091 = _prefix "OBI_0002091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002092"></see>
    /// </summary>
    let OBI_0002092 = _prefix "OBI_0002092"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002093"></see>
    /// </summary>
    let OBI_0002093 = _prefix "OBI_0002093"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002094"></see>
    /// </summary>
    let OBI_0002094 = _prefix "OBI_0002094"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002095"></see>
    /// </summary>
    let OBI_0002095 = _prefix "OBI_0002095"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002096"></see>
    /// </summary>
    let OBI_0002096 = _prefix "OBI_0002096"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002106"></see>
    /// </summary>
    let OBI_0002106 = _prefix "OBI_0002106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002098"></see>
    /// </summary>
    let OBI_0002098 = _prefix "OBI_0002098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002099"></see>
    /// </summary>
    let OBI_0002099 = _prefix "OBI_0002099"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002100"></see>
    /// </summary>
    let OBI_0002100 = _prefix "OBI_0002100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002101"></see>
    /// </summary>
    let OBI_0002101 = _prefix "OBI_0002101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002108"></see>
    /// </summary>
    let OBI_0002108 = _prefix "OBI_0002108"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002102"></see>
    /// </summary>
    let OBI_0002102 = _prefix "OBI_0002102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002107"></see>
    /// </summary>
    let OBI_0002107 = _prefix "OBI_0002107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002103"></see>
    /// </summary>
    let OBI_0002103 = _prefix "OBI_0002103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002104"></see>
    /// </summary>
    let OBI_0002104 = _prefix "OBI_0002104"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002105"></see>
    /// </summary>
    let OBI_0002105 = _prefix "OBI_0002105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002109"></see>
    /// </summary>
    let OBI_0002109 = _prefix "OBI_0002109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002110"></see>
    /// </summary>
    let OBI_0002110 = _prefix "OBI_0002110"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002111"></see>
    /// </summary>
    let OBI_0002111 = _prefix "OBI_0002111"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002112"></see>
    /// </summary>
    let OBI_0002112 = _prefix "OBI_0002112"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002113"></see>
    /// </summary>
    let OBI_0002113 = _prefix "OBI_0002113"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002114"></see>
    /// </summary>
    let OBI_0002114 = _prefix "OBI_0002114"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002115"></see>
    /// </summary>
    let OBI_0002115 = _prefix "OBI_0002115"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002116"></see>
    /// </summary>
    let OBI_0002116 = _prefix "OBI_0002116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002117"></see>
    /// </summary>
    let OBI_0002117 = _prefix "OBI_0002117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002118"></see>
    /// </summary>
    let OBI_0002118 = _prefix "OBI_0002118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002120"></see>
    /// </summary>
    let OBI_0002120 = _prefix "OBI_0002120"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002121"></see>
    /// </summary>
    let OBI_0002121 = _prefix "OBI_0002121"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002122"></see>
    /// </summary>
    let OBI_0002122 = _prefix "OBI_0002122"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002123"></see>
    /// </summary>
    let OBI_0002123 = _prefix "OBI_0002123"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302887"></see>
    /// </summary>
    let OBI_0302887 = _prefix "OBI_0302887"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OMIABIS_0000052"></see>
    /// </summary>
    let OMIABIS_0000052 = _prefix "OMIABIS_0000052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002124"></see>
    /// </summary>
    let OBI_0002124 = _prefix "OBI_0002124"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002125"></see>
    /// </summary>
    let OBI_0002125 = _prefix "OBI_0002125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002126"></see>
    /// </summary>
    let OBI_0002126 = _prefix "OBI_0002126"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002127"></see>
    /// </summary>
    let OBI_0002127 = _prefix "OBI_0002127"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002128"></see>
    /// </summary>
    let OBI_0002128 = _prefix "OBI_0002128"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002129"></see>
    /// </summary>
    let OBI_0002129 = _prefix "OBI_0002129"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002130"></see>
    /// </summary>
    let OBI_0002130 = _prefix "OBI_0002130"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002131"></see>
    /// </summary>
    let OBI_0002131 = _prefix "OBI_0002131"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002132"></see>
    /// </summary>
    let OBI_0002132 = _prefix "OBI_0002132"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002133"></see>
    /// </summary>
    let OBI_0002133 = _prefix "OBI_0002133"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002134"></see>
    /// </summary>
    let OBI_0002134 = _prefix "OBI_0002134"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002136"></see>
    /// </summary>
    let OBI_0002136 = _prefix "OBI_0002136"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002137"></see>
    /// </summary>
    let OBI_0002137 = _prefix "OBI_0002137"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002138"></see>
    /// </summary>
    let OBI_0002138 = _prefix "OBI_0002138"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000146"></see>
    /// </summary>
    let PATO_0000146 = _prefix "PATO_0000146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002139"></see>
    /// </summary>
    let OBI_0002139 = _prefix "OBI_0002139"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000918"></see>
    /// </summary>
    let PATO_0000918 = _prefix "PATO_0000918"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000095"></see>
    /// </summary>
    let UO_0000095 = _prefix "UO_0000095"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002140"></see>
    /// </summary>
    let OBI_0002140 = _prefix "OBI_0002140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002141"></see>
    /// </summary>
    let OBI_0002141 = _prefix "OBI_0002141"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002142"></see>
    /// </summary>
    let OBI_0002142 = _prefix "OBI_0002142"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002143"></see>
    /// </summary>
    let OBI_0002143 = _prefix "OBI_0002143"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002144"></see>
    /// </summary>
    let OBI_0002144 = _prefix "OBI_0002144"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002145"></see>
    /// </summary>
    let OBI_0002145 = _prefix "OBI_0002145"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002146"></see>
    /// </summary>
    let OBI_0002146 = _prefix "OBI_0002146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002147"></see>
    /// </summary>
    let OBI_0002147 = _prefix "OBI_0002147"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002148"></see>
    /// </summary>
    let OBI_0002148 = _prefix "OBI_0002148"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002149"></see>
    /// </summary>
    let OBI_0002149 = _prefix "OBI_0002149"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002150"></see>
    /// </summary>
    let OBI_0002150 = _prefix "OBI_0002150"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002151"></see>
    /// </summary>
    let OBI_0002151 = _prefix "OBI_0002151"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002152"></see>
    /// </summary>
    let OBI_0002152 = _prefix "OBI_0002152"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002153"></see>
    /// </summary>
    let OBI_0002153 = _prefix "OBI_0002153"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002154"></see>
    /// </summary>
    let OBI_0002154 = _prefix "OBI_0002154"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002155"></see>
    /// </summary>
    let OBI_0002155 = _prefix "OBI_0002155"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002156"></see>
    /// </summary>
    let OBI_0002156 = _prefix "OBI_0002156"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002157"></see>
    /// </summary>
    let OBI_0002157 = _prefix "OBI_0002157"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002158"></see>
    /// </summary>
    let OBI_0002158 = _prefix "OBI_0002158"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002159"></see>
    /// </summary>
    let OBI_0002159 = _prefix "OBI_0002159"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002160"></see>
    /// </summary>
    let OBI_0002160 = _prefix "OBI_0002160"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002161"></see>
    /// </summary>
    let OBI_0002161 = _prefix "OBI_0002161"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002163"></see>
    /// </summary>
    let OBI_0002163 = _prefix "OBI_0002163"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002164"></see>
    /// </summary>
    let OBI_0002164 = _prefix "OBI_0002164"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002165"></see>
    /// </summary>
    let OBI_0002165 = _prefix "OBI_0002165"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002166"></see>
    /// </summary>
    let OBI_0002166 = _prefix "OBI_0002166"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002167"></see>
    /// </summary>
    let OBI_0002167 = _prefix "OBI_0002167"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002168"></see>
    /// </summary>
    let OBI_0002168 = _prefix "OBI_0002168"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002169"></see>
    /// </summary>
    let OBI_0002169 = _prefix "OBI_0002169"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002170"></see>
    /// </summary>
    let OBI_0002170 = _prefix "OBI_0002170"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002171"></see>
    /// </summary>
    let OBI_0002171 = _prefix "OBI_0002171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002172"></see>
    /// </summary>
    let OBI_0002172 = _prefix "OBI_0002172"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002173"></see>
    /// </summary>
    let OBI_0002173 = _prefix "OBI_0002173"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002174"></see>
    /// </summary>
    let OBI_0002174 = _prefix "OBI_0002174"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002175"></see>
    /// </summary>
    let OBI_0002175 = _prefix "OBI_0002175"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002176"></see>
    /// </summary>
    let OBI_0002176 = _prefix "OBI_0002176"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002177"></see>
    /// </summary>
    let OBI_0002177 = _prefix "OBI_0002177"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002178"></see>
    /// </summary>
    let OBI_0002178 = _prefix "OBI_0002178"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002179"></see>
    /// </summary>
    let OBI_0002179 = _prefix "OBI_0002179"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002180"></see>
    /// </summary>
    let OBI_0002180 = _prefix "OBI_0002180"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002181"></see>
    /// </summary>
    let OBI_0002181 = _prefix "OBI_0002181"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002182"></see>
    /// </summary>
    let OBI_0002182 = _prefix "OBI_0002182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002183"></see>
    /// </summary>
    let OBI_0002183 = _prefix "OBI_0002183"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002184"></see>
    /// </summary>
    let OBI_0002184 = _prefix "OBI_0002184"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002185"></see>
    /// </summary>
    let OBI_0002185 = _prefix "OBI_0002185"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002186"></see>
    /// </summary>
    let OBI_0002186 = _prefix "OBI_0002186"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002187"></see>
    /// </summary>
    let OBI_0002187 = _prefix "OBI_0002187"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002188"></see>
    /// </summary>
    let OBI_0002188 = _prefix "OBI_0002188"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002189"></see>
    /// </summary>
    let OBI_0002189 = _prefix "OBI_0002189"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000479"></see>
    /// </summary>
    let UBERON_0000479 = _prefix "UBERON_0000479"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000955"></see>
    /// </summary>
    let UBERON_0000955 = _prefix "UBERON_0000955"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002190"></see>
    /// </summary>
    let OBI_0002190 = _prefix "OBI_0002190"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002191"></see>
    /// </summary>
    let OBI_0002191 = _prefix "OBI_0002191"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002192"></see>
    /// </summary>
    let OBI_0002192 = _prefix "OBI_0002192"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002193"></see>
    /// </summary>
    let OBI_0002193 = _prefix "OBI_0002193"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002194"></see>
    /// </summary>
    let OBI_0002194 = _prefix "OBI_0002194"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002195"></see>
    /// </summary>
    let OBI_0002195 = _prefix "OBI_0002195"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002196"></see>
    /// </summary>
    let OBI_0002196 = _prefix "OBI_0002196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002197"></see>
    /// </summary>
    let OBI_0002197 = _prefix "OBI_0002197"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002199"></see>
    /// </summary>
    let OBI_0002199 = _prefix "OBI_0002199"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002200"></see>
    /// </summary>
    let OBI_0002200 = _prefix "OBI_0002200"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002201"></see>
    /// </summary>
    let OBI_0002201 = _prefix "OBI_0002201"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002202"></see>
    /// </summary>
    let OBI_0002202 = _prefix "OBI_0002202"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002203"></see>
    /// </summary>
    let OBI_0002203 = _prefix "OBI_0002203"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002204"></see>
    /// </summary>
    let OBI_0002204 = _prefix "OBI_0002204"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002205"></see>
    /// </summary>
    let OBI_0002205 = _prefix "OBI_0002205"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002206"></see>
    /// </summary>
    let OBI_0002206 = _prefix "OBI_0002206"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002207"></see>
    /// </summary>
    let OBI_0002207 = _prefix "OBI_0002207"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002208"></see>
    /// </summary>
    let OBI_0002208 = _prefix "OBI_0002208"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002209"></see>
    /// </summary>
    let OBI_0002209 = _prefix "OBI_0002209"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002210"></see>
    /// </summary>
    let OBI_0002210 = _prefix "OBI_0002210"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002211"></see>
    /// </summary>
    let OBI_0002211 = _prefix "OBI_0002211"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002212"></see>
    /// </summary>
    let OBI_0002212 = _prefix "OBI_0002212"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002213"></see>
    /// </summary>
    let OBI_0002213 = _prefix "OBI_0002213"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002214"></see>
    /// </summary>
    let OBI_0002214 = _prefix "OBI_0002214"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002215"></see>
    /// </summary>
    let OBI_0002215 = _prefix "OBI_0002215"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002216"></see>
    /// </summary>
    let OBI_0002216 = _prefix "OBI_0002216"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002217"></see>
    /// </summary>
    let OBI_0002217 = _prefix "OBI_0002217"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002218"></see>
    /// </summary>
    let OBI_0002218 = _prefix "OBI_0002218"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002219"></see>
    /// </summary>
    let OBI_0002219 = _prefix "OBI_0002219"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002220"></see>
    /// </summary>
    let OBI_0002220 = _prefix "OBI_0002220"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002221"></see>
    /// </summary>
    let OBI_0002221 = _prefix "OBI_0002221"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002222"></see>
    /// </summary>
    let OBI_0002222 = _prefix "OBI_0002222"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002223"></see>
    /// </summary>
    let OBI_0002223 = _prefix "OBI_0002223"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002224"></see>
    /// </summary>
    let OBI_0002224 = _prefix "OBI_0002224"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002225"></see>
    /// </summary>
    let OBI_0002225 = _prefix "OBI_0002225"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002226"></see>
    /// </summary>
    let OBI_0002226 = _prefix "OBI_0002226"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002227"></see>
    /// </summary>
    let OBI_0002227 = _prefix "OBI_0002227"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002228"></see>
    /// </summary>
    let OBI_0002228 = _prefix "OBI_0002228"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002229"></see>
    /// </summary>
    let OBI_0002229 = _prefix "OBI_0002229"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002230"></see>
    /// </summary>
    let OBI_0002230 = _prefix "OBI_0002230"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002231"></see>
    /// </summary>
    let OBI_0002231 = _prefix "OBI_0002231"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002232"></see>
    /// </summary>
    let OBI_0002232 = _prefix "OBI_0002232"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002233"></see>
    /// </summary>
    let OBI_0002233 = _prefix "OBI_0002233"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002234"></see>
    /// </summary>
    let OBI_0002234 = _prefix "OBI_0002234"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002235"></see>
    /// </summary>
    let OBI_0002235 = _prefix "OBI_0002235"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002236"></see>
    /// </summary>
    let OBI_0002236 = _prefix "OBI_0002236"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002237"></see>
    /// </summary>
    let OBI_0002237 = _prefix "OBI_0002237"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002238"></see>
    /// </summary>
    let OBI_0002238 = _prefix "OBI_0002238"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002239"></see>
    /// </summary>
    let OBI_0002239 = _prefix "OBI_0002239"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002240"></see>
    /// </summary>
    let OBI_0002240 = _prefix "OBI_0002240"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002241"></see>
    /// </summary>
    let OBI_0002241 = _prefix "OBI_0002241"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002242"></see>
    /// </summary>
    let OBI_0002242 = _prefix "OBI_0002242"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002243"></see>
    /// </summary>
    let OBI_0002243 = _prefix "OBI_0002243"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002244"></see>
    /// </summary>
    let OBI_0002244 = _prefix "OBI_0002244"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002245"></see>
    /// </summary>
    let OBI_0002245 = _prefix "OBI_0002245"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002246"></see>
    /// </summary>
    let OBI_0002246 = _prefix "OBI_0002246"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002247"></see>
    /// </summary>
    let OBI_0002247 = _prefix "OBI_0002247"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002248"></see>
    /// </summary>
    let OBI_0002248 = _prefix "OBI_0002248"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002249"></see>
    /// </summary>
    let OBI_0002249 = _prefix "OBI_0002249"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002250"></see>
    /// </summary>
    let OBI_0002250 = _prefix "OBI_0002250"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002251"></see>
    /// </summary>
    let OBI_0002251 = _prefix "OBI_0002251"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002252"></see>
    /// </summary>
    let OBI_0002252 = _prefix "OBI_0002252"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002253"></see>
    /// </summary>
    let OBI_0002253 = _prefix "OBI_0002253"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002254"></see>
    /// </summary>
    let OBI_0002254 = _prefix "OBI_0002254"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002255"></see>
    /// </summary>
    let OBI_0002255 = _prefix "OBI_0002255"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002256"></see>
    /// </summary>
    let OBI_0002256 = _prefix "OBI_0002256"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002257"></see>
    /// </summary>
    let OBI_0002257 = _prefix "OBI_0002257"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002258"></see>
    /// </summary>
    let OBI_0002258 = _prefix "OBI_0002258"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002259"></see>
    /// </summary>
    let OBI_0002259 = _prefix "OBI_0002259"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002260"></see>
    /// </summary>
    let OBI_0002260 = _prefix "OBI_0002260"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002261"></see>
    /// </summary>
    let OBI_0002261 = _prefix "OBI_0002261"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002262"></see>
    /// </summary>
    let OBI_0002262 = _prefix "OBI_0002262"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002263"></see>
    /// </summary>
    let OBI_0002263 = _prefix "OBI_0002263"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002264"></see>
    /// </summary>
    let OBI_0002264 = _prefix "OBI_0002264"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002265"></see>
    /// </summary>
    let OBI_0002265 = _prefix "OBI_0002265"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002266"></see>
    /// </summary>
    let OBI_0002266 = _prefix "OBI_0002266"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002267"></see>
    /// </summary>
    let OBI_0002267 = _prefix "OBI_0002267"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002268"></see>
    /// </summary>
    let OBI_0002268 = _prefix "OBI_0002268"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002269"></see>
    /// </summary>
    let OBI_0002269 = _prefix "OBI_0002269"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002270"></see>
    /// </summary>
    let OBI_0002270 = _prefix "OBI_0002270"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002271"></see>
    /// </summary>
    let OBI_0002271 = _prefix "OBI_0002271"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002272"></see>
    /// </summary>
    let OBI_0002272 = _prefix "OBI_0002272"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002273"></see>
    /// </summary>
    let OBI_0002273 = _prefix "OBI_0002273"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002274"></see>
    /// </summary>
    let OBI_0002274 = _prefix "OBI_0002274"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002275"></see>
    /// </summary>
    let OBI_0002275 = _prefix "OBI_0002275"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002276"></see>
    /// </summary>
    let OBI_0002276 = _prefix "OBI_0002276"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002277"></see>
    /// </summary>
    let OBI_0002277 = _prefix "OBI_0002277"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002278"></see>
    /// </summary>
    let OBI_0002278 = _prefix "OBI_0002278"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002279"></see>
    /// </summary>
    let OBI_0002279 = _prefix "OBI_0002279"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002280"></see>
    /// </summary>
    let OBI_0002280 = _prefix "OBI_0002280"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002281"></see>
    /// </summary>
    let OBI_0002281 = _prefix "OBI_0002281"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002282"></see>
    /// </summary>
    let OBI_0002282 = _prefix "OBI_0002282"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002283"></see>
    /// </summary>
    let OBI_0002283 = _prefix "OBI_0002283"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002284"></see>
    /// </summary>
    let OBI_0002284 = _prefix "OBI_0002284"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002285"></see>
    /// </summary>
    let OBI_0002285 = _prefix "OBI_0002285"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002286"></see>
    /// </summary>
    let OBI_0002286 = _prefix "OBI_0002286"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002287"></see>
    /// </summary>
    let OBI_0002287 = _prefix "OBI_0002287"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002288"></see>
    /// </summary>
    let OBI_0002288 = _prefix "OBI_0002288"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002289"></see>
    /// </summary>
    let OBI_0002289 = _prefix "OBI_0002289"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002290"></see>
    /// </summary>
    let OBI_0002290 = _prefix "OBI_0002290"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002291"></see>
    /// </summary>
    let OBI_0002291 = _prefix "OBI_0002291"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002292"></see>
    /// </summary>
    let OBI_0002292 = _prefix "OBI_0002292"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002293"></see>
    /// </summary>
    let OBI_0002293 = _prefix "OBI_0002293"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002294"></see>
    /// </summary>
    let OBI_0002294 = _prefix "OBI_0002294"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002295"></see>
    /// </summary>
    let OBI_0002295 = _prefix "OBI_0002295"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002296"></see>
    /// </summary>
    let OBI_0002296 = _prefix "OBI_0002296"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002297"></see>
    /// </summary>
    let OBI_0002297 = _prefix "OBI_0002297"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002298"></see>
    /// </summary>
    let OBI_0002298 = _prefix "OBI_0002298"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002299"></see>
    /// </summary>
    let OBI_0002299 = _prefix "OBI_0002299"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002300"></see>
    /// </summary>
    let OBI_0002300 = _prefix "OBI_0002300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002301"></see>
    /// </summary>
    let OBI_0002301 = _prefix "OBI_0002301"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002302"></see>
    /// </summary>
    let OBI_0002302 = _prefix "OBI_0002302"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002303"></see>
    /// </summary>
    let OBI_0002303 = _prefix "OBI_0002303"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002304"></see>
    /// </summary>
    let OBI_0002304 = _prefix "OBI_0002304"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002305"></see>
    /// </summary>
    let OBI_0002305 = _prefix "OBI_0002305"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002306"></see>
    /// </summary>
    let OBI_0002306 = _prefix "OBI_0002306"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002307"></see>
    /// </summary>
    let OBI_0002307 = _prefix "OBI_0002307"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002308"></see>
    /// </summary>
    let OBI_0002308 = _prefix "OBI_0002308"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002309"></see>
    /// </summary>
    let OBI_0002309 = _prefix "OBI_0002309"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002310"></see>
    /// </summary>
    let OBI_0002310 = _prefix "OBI_0002310"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002311"></see>
    /// </summary>
    let OBI_0002311 = _prefix "OBI_0002311"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002312"></see>
    /// </summary>
    let OBI_0002312 = _prefix "OBI_0002312"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002313"></see>
    /// </summary>
    let OBI_0002313 = _prefix "OBI_0002313"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002314"></see>
    /// </summary>
    let OBI_0002314 = _prefix "OBI_0002314"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002315"></see>
    /// </summary>
    let OBI_0002315 = _prefix "OBI_0002315"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002316"></see>
    /// </summary>
    let OBI_0002316 = _prefix "OBI_0002316"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002317"></see>
    /// </summary>
    let OBI_0002317 = _prefix "OBI_0002317"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002318"></see>
    /// </summary>
    let OBI_0002318 = _prefix "OBI_0002318"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002319"></see>
    /// </summary>
    let OBI_0002319 = _prefix "OBI_0002319"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002320"></see>
    /// </summary>
    let OBI_0002320 = _prefix "OBI_0002320"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002321"></see>
    /// </summary>
    let OBI_0002321 = _prefix "OBI_0002321"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002322"></see>
    /// </summary>
    let OBI_0002322 = _prefix "OBI_0002322"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002323"></see>
    /// </summary>
    let OBI_0002323 = _prefix "OBI_0002323"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002324"></see>
    /// </summary>
    let OBI_0002324 = _prefix "OBI_0002324"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002325"></see>
    /// </summary>
    let OBI_0002325 = _prefix "OBI_0002325"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002326"></see>
    /// </summary>
    let OBI_0002326 = _prefix "OBI_0002326"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002327"></see>
    /// </summary>
    let OBI_0002327 = _prefix "OBI_0002327"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002328"></see>
    /// </summary>
    let OBI_0002328 = _prefix "OBI_0002328"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002329"></see>
    /// </summary>
    let OBI_0002329 = _prefix "OBI_0002329"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002330"></see>
    /// </summary>
    let OBI_0002330 = _prefix "OBI_0002330"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002331"></see>
    /// </summary>
    let OBI_0002331 = _prefix "OBI_0002331"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002332"></see>
    /// </summary>
    let OBI_0002332 = _prefix "OBI_0002332"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002333"></see>
    /// </summary>
    let OBI_0002333 = _prefix "OBI_0002333"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002334"></see>
    /// </summary>
    let OBI_0002334 = _prefix "OBI_0002334"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002335"></see>
    /// </summary>
    let OBI_0002335 = _prefix "OBI_0002335"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002336"></see>
    /// </summary>
    let OBI_0002336 = _prefix "OBI_0002336"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002337"></see>
    /// </summary>
    let OBI_0002337 = _prefix "OBI_0002337"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002338"></see>
    /// </summary>
    let OBI_0002338 = _prefix "OBI_0002338"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002339"></see>
    /// </summary>
    let OBI_0002339 = _prefix "OBI_0002339"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002340"></see>
    /// </summary>
    let OBI_0002340 = _prefix "OBI_0002340"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002341"></see>
    /// </summary>
    let OBI_0002341 = _prefix "OBI_0002341"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002342"></see>
    /// </summary>
    let OBI_0002342 = _prefix "OBI_0002342"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002343"></see>
    /// </summary>
    let OBI_0002343 = _prefix "OBI_0002343"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002344"></see>
    /// </summary>
    let OBI_0002344 = _prefix "OBI_0002344"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002345"></see>
    /// </summary>
    let OBI_0002345 = _prefix "OBI_0002345"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002346"></see>
    /// </summary>
    let OBI_0002346 = _prefix "OBI_0002346"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002347"></see>
    /// </summary>
    let OBI_0002347 = _prefix "OBI_0002347"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002348"></see>
    /// </summary>
    let OBI_0002348 = _prefix "OBI_0002348"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002349"></see>
    /// </summary>
    let OBI_0002349 = _prefix "OBI_0002349"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002350"></see>
    /// </summary>
    let OBI_0002350 = _prefix "OBI_0002350"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002351"></see>
    /// </summary>
    let OBI_0002351 = _prefix "OBI_0002351"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002352"></see>
    /// </summary>
    let OBI_0002352 = _prefix "OBI_0002352"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002353"></see>
    /// </summary>
    let OBI_0002353 = _prefix "OBI_0002353"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002354"></see>
    /// </summary>
    let OBI_0002354 = _prefix "OBI_0002354"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002355"></see>
    /// </summary>
    let OBI_0002355 = _prefix "OBI_0002355"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002356"></see>
    /// </summary>
    let OBI_0002356 = _prefix "OBI_0002356"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002357"></see>
    /// </summary>
    let OBI_0002357 = _prefix "OBI_0002357"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002358"></see>
    /// </summary>
    let OBI_0002358 = _prefix "OBI_0002358"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002359"></see>
    /// </summary>
    let OBI_0002359 = _prefix "OBI_0002359"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002360"></see>
    /// </summary>
    let OBI_0002360 = _prefix "OBI_0002360"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002361"></see>
    /// </summary>
    let OBI_0002361 = _prefix "OBI_0002361"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002362"></see>
    /// </summary>
    let OBI_0002362 = _prefix "OBI_0002362"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002363"></see>
    /// </summary>
    let OBI_0002363 = _prefix "OBI_0002363"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002364"></see>
    /// </summary>
    let OBI_0002364 = _prefix "OBI_0002364"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002365"></see>
    /// </summary>
    let OBI_0002365 = _prefix "OBI_0002365"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002366"></see>
    /// </summary>
    let OBI_0002366 = _prefix "OBI_0002366"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002367"></see>
    /// </summary>
    let OBI_0002367 = _prefix "OBI_0002367"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002368"></see>
    /// </summary>
    let OBI_0002368 = _prefix "OBI_0002368"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002369"></see>
    /// </summary>
    let OBI_0002369 = _prefix "OBI_0002369"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002370"></see>
    /// </summary>
    let OBI_0002370 = _prefix "OBI_0002370"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002371"></see>
    /// </summary>
    let OBI_0002371 = _prefix "OBI_0002371"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OGMS_0000073"></see>
    /// </summary>
    let OGMS_0000073 = _prefix "OGMS_0000073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002372"></see>
    /// </summary>
    let OBI_0002372 = _prefix "OBI_0002372"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002373"></see>
    /// </summary>
    let OBI_0002373 = _prefix "OBI_0002373"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002374"></see>
    /// </summary>
    let OBI_0002374 = _prefix "OBI_0002374"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002375"></see>
    /// </summary>
    let OBI_0002375 = _prefix "OBI_0002375"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002376"></see>
    /// </summary>
    let OBI_0002376 = _prefix "OBI_0002376"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002377"></see>
    /// </summary>
    let OBI_0002377 = _prefix "OBI_0002377"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002378"></see>
    /// </summary>
    let OBI_0002378 = _prefix "OBI_0002378"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002379"></see>
    /// </summary>
    let OBI_0002379 = _prefix "OBI_0002379"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002380"></see>
    /// </summary>
    let OBI_0002380 = _prefix "OBI_0002380"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002381"></see>
    /// </summary>
    let OBI_0002381 = _prefix "OBI_0002381"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002382"></see>
    /// </summary>
    let OBI_0002382 = _prefix "OBI_0002382"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002383"></see>
    /// </summary>
    let OBI_0002383 = _prefix "OBI_0002383"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002384"></see>
    /// </summary>
    let OBI_0002384 = _prefix "OBI_0002384"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002385"></see>
    /// </summary>
    let OBI_0002385 = _prefix "OBI_0002385"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002386"></see>
    /// </summary>
    let OBI_0002386 = _prefix "OBI_0002386"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002387"></see>
    /// </summary>
    let OBI_0002387 = _prefix "OBI_0002387"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002388"></see>
    /// </summary>
    let OBI_0002388 = _prefix "OBI_0002388"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002389"></see>
    /// </summary>
    let OBI_0002389 = _prefix "OBI_0002389"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002390"></see>
    /// </summary>
    let OBI_0002390 = _prefix "OBI_0002390"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002391"></see>
    /// </summary>
    let OBI_0002391 = _prefix "OBI_0002391"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002392"></see>
    /// </summary>
    let OBI_0002392 = _prefix "OBI_0002392"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002393"></see>
    /// </summary>
    let OBI_0002393 = _prefix "OBI_0002393"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002394"></see>
    /// </summary>
    let OBI_0002394 = _prefix "OBI_0002394"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002395"></see>
    /// </summary>
    let OBI_0002395 = _prefix "OBI_0002395"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002396"></see>
    /// </summary>
    let OBI_0002396 = _prefix "OBI_0002396"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002397"></see>
    /// </summary>
    let OBI_0002397 = _prefix "OBI_0002397"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002398"></see>
    /// </summary>
    let OBI_0002398 = _prefix "OBI_0002398"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002399"></see>
    /// </summary>
    let OBI_0002399 = _prefix "OBI_0002399"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002400"></see>
    /// </summary>
    let OBI_0002400 = _prefix "OBI_0002400"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002401"></see>
    /// </summary>
    let OBI_0002401 = _prefix "OBI_0002401"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002402"></see>
    /// </summary>
    let OBI_0002402 = _prefix "OBI_0002402"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002403"></see>
    /// </summary>
    let OBI_0002403 = _prefix "OBI_0002403"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002404"></see>
    /// </summary>
    let OBI_0002404 = _prefix "OBI_0002404"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002405"></see>
    /// </summary>
    let OBI_0002405 = _prefix "OBI_0002405"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002406"></see>
    /// </summary>
    let OBI_0002406 = _prefix "OBI_0002406"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002407"></see>
    /// </summary>
    let OBI_0002407 = _prefix "OBI_0002407"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002408"></see>
    /// </summary>
    let OBI_0002408 = _prefix "OBI_0002408"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002409"></see>
    /// </summary>
    let OBI_0002409 = _prefix "OBI_0002409"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002410"></see>
    /// </summary>
    let OBI_0002410 = _prefix "OBI_0002410"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002411"></see>
    /// </summary>
    let OBI_0002411 = _prefix "OBI_0002411"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002412"></see>
    /// </summary>
    let OBI_0002412 = _prefix "OBI_0002412"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002413"></see>
    /// </summary>
    let OBI_0002413 = _prefix "OBI_0002413"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002414"></see>
    /// </summary>
    let OBI_0002414 = _prefix "OBI_0002414"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002415"></see>
    /// </summary>
    let OBI_0002415 = _prefix "OBI_0002415"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002416"></see>
    /// </summary>
    let OBI_0002416 = _prefix "OBI_0002416"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002417"></see>
    /// </summary>
    let OBI_0002417 = _prefix "OBI_0002417"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002418"></see>
    /// </summary>
    let OBI_0002418 = _prefix "OBI_0002418"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002419"></see>
    /// </summary>
    let OBI_0002419 = _prefix "OBI_0002419"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002420"></see>
    /// </summary>
    let OBI_0002420 = _prefix "OBI_0002420"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002421"></see>
    /// </summary>
    let OBI_0002421 = _prefix "OBI_0002421"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002422"></see>
    /// </summary>
    let OBI_0002422 = _prefix "OBI_0002422"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002423"></see>
    /// </summary>
    let OBI_0002423 = _prefix "OBI_0002423"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500027"></see>
    /// </summary>
    let OBI_0500027 = _prefix "OBI_0500027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002424"></see>
    /// </summary>
    let OBI_0002424 = _prefix "OBI_0002424"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500028"></see>
    /// </summary>
    let OBI_0500028 = _prefix "OBI_0500028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002425"></see>
    /// </summary>
    let OBI_0002425 = _prefix "OBI_0002425"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002426"></see>
    /// </summary>
    let OBI_0002426 = _prefix "OBI_0002426"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002427"></see>
    /// </summary>
    let OBI_0002427 = _prefix "OBI_0002427"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002428"></see>
    /// </summary>
    let OBI_0002428 = _prefix "OBI_0002428"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002429"></see>
    /// </summary>
    let OBI_0002429 = _prefix "OBI_0002429"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002430"></see>
    /// </summary>
    let OBI_0002430 = _prefix "OBI_0002430"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002431"></see>
    /// </summary>
    let OBI_0002431 = _prefix "OBI_0002431"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002432"></see>
    /// </summary>
    let OBI_0002432 = _prefix "OBI_0002432"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002433"></see>
    /// </summary>
    let OBI_0002433 = _prefix "OBI_0002433"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002434"></see>
    /// </summary>
    let OBI_0002434 = _prefix "OBI_0002434"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002435"></see>
    /// </summary>
    let OBI_0002435 = _prefix "OBI_0002435"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002436"></see>
    /// </summary>
    let OBI_0002436 = _prefix "OBI_0002436"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002437"></see>
    /// </summary>
    let OBI_0002437 = _prefix "OBI_0002437"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002440"></see>
    /// </summary>
    let OBI_0002440 = _prefix "OBI_0002440"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002441"></see>
    /// </summary>
    let OBI_0002441 = _prefix "OBI_0002441"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002442"></see>
    /// </summary>
    let OBI_0002442 = _prefix "OBI_0002442"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002443"></see>
    /// </summary>
    let OBI_0002443 = _prefix "OBI_0002443"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002445"></see>
    /// </summary>
    let OBI_0002445 = _prefix "OBI_0002445"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002446"></see>
    /// </summary>
    let OBI_0002446 = _prefix "OBI_0002446"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002447"></see>
    /// </summary>
    let OBI_0002447 = _prefix "OBI_0002447"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002448"></see>
    /// </summary>
    let OBI_0002448 = _prefix "OBI_0002448"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002450"></see>
    /// </summary>
    let OBI_0002450 = _prefix "OBI_0002450"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002451"></see>
    /// </summary>
    let OBI_0002451 = _prefix "OBI_0002451"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002452"></see>
    /// </summary>
    let OBI_0002452 = _prefix "OBI_0002452"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002453"></see>
    /// </summary>
    let OBI_0002453 = _prefix "OBI_0002453"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002454"></see>
    /// </summary>
    let OBI_0002454 = _prefix "OBI_0002454"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002455"></see>
    /// </summary>
    let OBI_0002455 = _prefix "OBI_0002455"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002456"></see>
    /// </summary>
    let OBI_0002456 = _prefix "OBI_0002456"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002457"></see>
    /// </summary>
    let OBI_0002457 = _prefix "OBI_0002457"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002458"></see>
    /// </summary>
    let OBI_0002458 = _prefix "OBI_0002458"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002598"></see>
    /// </summary>
    let OBI_0002598 = _prefix "OBI_0002598"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002459"></see>
    /// </summary>
    let OBI_0002459 = _prefix "OBI_0002459"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002460"></see>
    /// </summary>
    let OBI_0002460 = _prefix "OBI_0002460"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002461"></see>
    /// </summary>
    let OBI_0002461 = _prefix "OBI_0002461"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002462"></see>
    /// </summary>
    let OBI_0002462 = _prefix "OBI_0002462"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002463"></see>
    /// </summary>
    let OBI_0002463 = _prefix "OBI_0002463"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002464"></see>
    /// </summary>
    let OBI_0002464 = _prefix "OBI_0002464"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002465"></see>
    /// </summary>
    let OBI_0002465 = _prefix "OBI_0002465"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002466"></see>
    /// </summary>
    let OBI_0002466 = _prefix "OBI_0002466"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002467"></see>
    /// </summary>
    let OBI_0002467 = _prefix "OBI_0002467"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002468"></see>
    /// </summary>
    let OBI_0002468 = _prefix "OBI_0002468"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002469"></see>
    /// </summary>
    let OBI_0002469 = _prefix "OBI_0002469"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002470"></see>
    /// </summary>
    let OBI_0002470 = _prefix "OBI_0002470"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002471"></see>
    /// </summary>
    let OBI_0002471 = _prefix "OBI_0002471"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002472"></see>
    /// </summary>
    let OBI_0002472 = _prefix "OBI_0002472"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002473"></see>
    /// </summary>
    let OBI_0002473 = _prefix "OBI_0002473"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002474"></see>
    /// </summary>
    let OBI_0002474 = _prefix "OBI_0002474"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002475"></see>
    /// </summary>
    let OBI_0002475 = _prefix "OBI_0002475"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002476"></see>
    /// </summary>
    let OBI_0002476 = _prefix "OBI_0002476"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002477"></see>
    /// </summary>
    let OBI_0002477 = _prefix "OBI_0002477"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002478"></see>
    /// </summary>
    let OBI_0002478 = _prefix "OBI_0002478"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002479"></see>
    /// </summary>
    let OBI_0002479 = _prefix "OBI_0002479"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002480"></see>
    /// </summary>
    let OBI_0002480 = _prefix "OBI_0002480"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002481"></see>
    /// </summary>
    let OBI_0002481 = _prefix "OBI_0002481"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002482"></see>
    /// </summary>
    let OBI_0002482 = _prefix "OBI_0002482"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002483"></see>
    /// </summary>
    let OBI_0002483 = _prefix "OBI_0002483"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002484"></see>
    /// </summary>
    let OBI_0002484 = _prefix "OBI_0002484"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002485"></see>
    /// </summary>
    let OBI_0002485 = _prefix "OBI_0002485"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002486"></see>
    /// </summary>
    let OBI_0002486 = _prefix "OBI_0002486"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002487"></see>
    /// </summary>
    let OBI_0002487 = _prefix "OBI_0002487"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002488"></see>
    /// </summary>
    let OBI_0002488 = _prefix "OBI_0002488"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002489"></see>
    /// </summary>
    let OBI_0002489 = _prefix "OBI_0002489"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002500"></see>
    /// </summary>
    let OBI_0002500 = _prefix "OBI_0002500"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000173"></see>
    /// </summary>
    let UBERON_0000173 = _prefix "UBERON_0000173"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002501"></see>
    /// </summary>
    let OBI_0002501 = _prefix "OBI_0002501"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001970"></see>
    /// </summary>
    let UBERON_0001970 = _prefix "UBERON_0001970"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002502"></see>
    /// </summary>
    let OBI_0002502 = _prefix "OBI_0002502"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001359"></see>
    /// </summary>
    let UBERON_0001359 = _prefix "UBERON_0001359"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002503"></see>
    /// </summary>
    let OBI_0002503 = _prefix "OBI_0002503"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001988"></see>
    /// </summary>
    let UBERON_0001988 = _prefix "UBERON_0001988"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002504"></see>
    /// </summary>
    let OBI_0002504 = _prefix "OBI_0002504"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0006911"></see>
    /// </summary>
    let UBERON_0006911 = _prefix "UBERON_0006911"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002505"></see>
    /// </summary>
    let OBI_0002505 = _prefix "OBI_0002505"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001913"></see>
    /// </summary>
    let UBERON_0001913 = _prefix "UBERON_0001913"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002506"></see>
    /// </summary>
    let OBI_0002506 = _prefix "OBI_0002506"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002409"></see>
    /// </summary>
    let UBERON_0002409 = _prefix "UBERON_0002409"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002507"></see>
    /// </summary>
    let OBI_0002507 = _prefix "OBI_0002507"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001836"></see>
    /// </summary>
    let UBERON_0001836 = _prefix "UBERON_0001836"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002508"></see>
    /// </summary>
    let OBI_0002508 = _prefix "OBI_0002508"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0007311"></see>
    /// </summary>
    let UBERON_0007311 = _prefix "UBERON_0007311"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002509"></see>
    /// </summary>
    let OBI_0002509 = _prefix "OBI_0002509"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001089"></see>
    /// </summary>
    let UBERON_0001089 = _prefix "UBERON_0001089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002510"></see>
    /// </summary>
    let OBI_0002510 = _prefix "OBI_0002510"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001090"></see>
    /// </summary>
    let UBERON_0001090 = _prefix "UBERON_0001090"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002511"></see>
    /// </summary>
    let OBI_0002511 = _prefix "OBI_0002511"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001797"></see>
    /// </summary>
    let UBERON_0001797 = _prefix "UBERON_0001797"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002512"></see>
    /// </summary>
    let OBI_0002512 = _prefix "OBI_0002512"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002371"></see>
    /// </summary>
    let UBERON_0002371 = _prefix "UBERON_0002371"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002513"></see>
    /// </summary>
    let OBI_0002513 = _prefix "OBI_0002513"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001987"></see>
    /// </summary>
    let UBERON_0001987 = _prefix "UBERON_0001987"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002514"></see>
    /// </summary>
    let OBI_0002514 = _prefix "OBI_0002514"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001268"></see>
    /// </summary>
    let UBERON_0001268 = _prefix "UBERON_0001268"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002515"></see>
    /// </summary>
    let OBI_0002515 = _prefix "OBI_0002515"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001087"></see>
    /// </summary>
    let UBERON_0001087 = _prefix "UBERON_0001087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002516"></see>
    /// </summary>
    let OBI_0002516 = _prefix "OBI_0002516"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002517"></see>
    /// </summary>
    let OBI_0002517 = _prefix "OBI_0002517"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001037"></see>
    /// </summary>
    let UBERON_0001037 = _prefix "UBERON_0001037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002518"></see>
    /// </summary>
    let OBI_0002518 = _prefix "OBI_0002518"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002367"></see>
    /// </summary>
    let UBERON_0002367 = _prefix "UBERON_0002367"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002519"></see>
    /// </summary>
    let OBI_0002519 = _prefix "OBI_0002519"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002520"></see>
    /// </summary>
    let OBI_0002520 = _prefix "OBI_0002520"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000948"></see>
    /// </summary>
    let UBERON_0000948 = _prefix "UBERON_0000948"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002521"></see>
    /// </summary>
    let OBI_0002521 = _prefix "OBI_0002521"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000362"></see>
    /// </summary>
    let UBERON_0000362 = _prefix "UBERON_0000362"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002522"></see>
    /// </summary>
    let OBI_0002522 = _prefix "OBI_0002522"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002369"></see>
    /// </summary>
    let UBERON_0002369 = _prefix "UBERON_0002369"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002523"></see>
    /// </summary>
    let OBI_0002523 = _prefix "OBI_0002523"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000310"></see>
    /// </summary>
    let UBERON_0000310 = _prefix "UBERON_0000310"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002524"></see>
    /// </summary>
    let OBI_0002524 = _prefix "OBI_0002524"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001255"></see>
    /// </summary>
    let UBERON_0001255 = _prefix "UBERON_0001255"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002525"></see>
    /// </summary>
    let OBI_0002525 = _prefix "OBI_0002525"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0007610"></see>
    /// </summary>
    let UBERON_0007610 = _prefix "UBERON_0007610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002526"></see>
    /// </summary>
    let OBI_0002526 = _prefix "OBI_0002526"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002097"></see>
    /// </summary>
    let UBERON_0002097 = _prefix "UBERON_0002097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002527"></see>
    /// </summary>
    let OBI_0002527 = _prefix "OBI_0002527"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001264"></see>
    /// </summary>
    let UBERON_0001264 = _prefix "UBERON_0001264"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002528"></see>
    /// </summary>
    let OBI_0002528 = _prefix "OBI_0002528"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000945"></see>
    /// </summary>
    let UBERON_0000945 = _prefix "UBERON_0000945"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002529"></see>
    /// </summary>
    let OBI_0002529 = _prefix "OBI_0002529"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000007"></see>
    /// </summary>
    let UBERON_0000007 = _prefix "UBERON_0000007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002530"></see>
    /// </summary>
    let OBI_0002530 = _prefix "OBI_0002530"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001013"></see>
    /// </summary>
    let UBERON_0001013 = _prefix "UBERON_0001013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002531"></see>
    /// </summary>
    let OBI_0002531 = _prefix "OBI_0002531"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001225"></see>
    /// </summary>
    let UBERON_0001225 = _prefix "UBERON_0001225"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002532"></see>
    /// </summary>
    let OBI_0002532 = _prefix "OBI_0002532"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002469"></see>
    /// </summary>
    let UBERON_0002469 = _prefix "UBERON_0002469"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002533"></see>
    /// </summary>
    let OBI_0002533 = _prefix "OBI_0002533"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001155"></see>
    /// </summary>
    let UBERON_0001155 = _prefix "UBERON_0001155"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002534"></see>
    /// </summary>
    let OBI_0002534 = _prefix "OBI_0002534"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002048"></see>
    /// </summary>
    let UBERON_0002048 = _prefix "UBERON_0002048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002535"></see>
    /// </summary>
    let OBI_0002535 = _prefix "OBI_0002535"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0004648"></see>
    /// </summary>
    let UBERON_0004648 = _prefix "UBERON_0004648"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002536"></see>
    /// </summary>
    let OBI_0002536 = _prefix "OBI_0002536"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000956"></see>
    /// </summary>
    let UBERON_0000956 = _prefix "UBERON_0000956"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002537"></see>
    /// </summary>
    let OBI_0002537 = _prefix "OBI_0002537"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002046"></see>
    /// </summary>
    let UBERON_0002046 = _prefix "UBERON_0002046"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002538"></see>
    /// </summary>
    let OBI_0002538 = _prefix "OBI_0002538"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002037"></see>
    /// </summary>
    let UBERON_0002037 = _prefix "UBERON_0002037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002539"></see>
    /// </summary>
    let OBI_0002539 = _prefix "OBI_0002539"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001323"></see>
    /// </summary>
    let UBERON_0001323 = _prefix "UBERON_0001323"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002540"></see>
    /// </summary>
    let OBI_0002540 = _prefix "OBI_0002540"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001621"></see>
    /// </summary>
    let UBERON_0001621 = _prefix "UBERON_0001621"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002541"></see>
    /// </summary>
    let OBI_0002541 = _prefix "OBI_0002541"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002106"></see>
    /// </summary>
    let UBERON_0002106 = _prefix "UBERON_0002106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002542"></see>
    /// </summary>
    let OBI_0002542 = _prefix "OBI_0002542"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000947"></see>
    /// </summary>
    let UBERON_0000947 = _prefix "UBERON_0000947"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002543"></see>
    /// </summary>
    let OBI_0002543 = _prefix "OBI_0002543"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0006618"></see>
    /// </summary>
    let UBERON_0006618 = _prefix "UBERON_0006618"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002544"></see>
    /// </summary>
    let OBI_0002544 = _prefix "OBI_0002544"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0007650"></see>
    /// </summary>
    let UBERON_0007650 = _prefix "UBERON_0007650"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002545"></see>
    /// </summary>
    let OBI_0002545 = _prefix "OBI_0002545"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002116"></see>
    /// </summary>
    let UBERON_0002116 = _prefix "UBERON_0002116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002546"></see>
    /// </summary>
    let OBI_0002546 = _prefix "OBI_0002546"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002107"></see>
    /// </summary>
    let UBERON_0002107 = _prefix "UBERON_0002107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002547"></see>
    /// </summary>
    let OBI_0002547 = _prefix "OBI_0002547"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001830"></see>
    /// </summary>
    let UBERON_0001830 = _prefix "UBERON_0001830"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002548"></see>
    /// </summary>
    let OBI_0002548 = _prefix "OBI_0002548"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0003688"></see>
    /// </summary>
    let UBERON_0003688 = _prefix "UBERON_0003688"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002549"></see>
    /// </summary>
    let OBI_0002549 = _prefix "OBI_0002549"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000992"></see>
    /// </summary>
    let UBERON_0000992 = _prefix "UBERON_0000992"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002550"></see>
    /// </summary>
    let OBI_0002550 = _prefix "OBI_0002550"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001159"></see>
    /// </summary>
    let UBERON_0001159 = _prefix "UBERON_0001159"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002551"></see>
    /// </summary>
    let OBI_0002551 = _prefix "OBI_0002551"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0036149"></see>
    /// </summary>
    let UBERON_0036149 = _prefix "UBERON_0036149"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002552"></see>
    /// </summary>
    let OBI_0002552 = _prefix "OBI_0002552"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000473"></see>
    /// </summary>
    let UBERON_0000473 = _prefix "UBERON_0000473"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002553"></see>
    /// </summary>
    let OBI_0002553 = _prefix "OBI_0002553"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000995"></see>
    /// </summary>
    let UBERON_0000995 = _prefix "UBERON_0000995"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002554"></see>
    /// </summary>
    let OBI_0002554 = _prefix "OBI_0002554"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000996"></see>
    /// </summary>
    let UBERON_0000996 = _prefix "UBERON_0000996"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002555"></see>
    /// </summary>
    let OBI_0002555 = _prefix "OBI_0002555"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002556"></see>
    /// </summary>
    let OBI_0002556 = _prefix "OBI_0002556"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002557"></see>
    /// </summary>
    let OBI_0002557 = _prefix "OBI_0002557"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002558"></see>
    /// </summary>
    let OBI_0002558 = _prefix "OBI_0002558"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002559"></see>
    /// </summary>
    let OBI_0002559 = _prefix "OBI_0002559"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002560"></see>
    /// </summary>
    let OBI_0002560 = _prefix "OBI_0002560"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002561"></see>
    /// </summary>
    let OBI_0002561 = _prefix "OBI_0002561"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002562"></see>
    /// </summary>
    let OBI_0002562 = _prefix "OBI_0002562"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002563"></see>
    /// </summary>
    let OBI_0002563 = _prefix "OBI_0002563"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002564"></see>
    /// </summary>
    let OBI_0002564 = _prefix "OBI_0002564"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600020"></see>
    /// </summary>
    let OBI_0600020 = _prefix "OBI_0600020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002565"></see>
    /// </summary>
    let OBI_0002565 = _prefix "OBI_0002565"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002579"></see>
    /// </summary>
    let OBI_0002579 = _prefix "OBI_0002579"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002585"></see>
    /// </summary>
    let OBI_0002585 = _prefix "OBI_0002585"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002578"></see>
    /// </summary>
    let OBI_0002578 = _prefix "OBI_0002578"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002566"></see>
    /// </summary>
    let OBI_0002566 = _prefix "OBI_0002566"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002567"></see>
    /// </summary>
    let OBI_0002567 = _prefix "OBI_0002567"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002580"></see>
    /// </summary>
    let OBI_0002580 = _prefix "OBI_0002580"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002568"></see>
    /// </summary>
    let OBI_0002568 = _prefix "OBI_0002568"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002582"></see>
    /// </summary>
    let OBI_0002582 = _prefix "OBI_0002582"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002569"></see>
    /// </summary>
    let OBI_0002569 = _prefix "OBI_0002569"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002570"></see>
    /// </summary>
    let OBI_0002570 = _prefix "OBI_0002570"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002571"></see>
    /// </summary>
    let OBI_0002571 = _prefix "OBI_0002571"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002572"></see>
    /// </summary>
    let OBI_0002572 = _prefix "OBI_0002572"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002573"></see>
    /// </summary>
    let OBI_0002573 = _prefix "OBI_0002573"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002574"></see>
    /// </summary>
    let OBI_0002574 = _prefix "OBI_0002574"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002575"></see>
    /// </summary>
    let OBI_0002575 = _prefix "OBI_0002575"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002581"></see>
    /// </summary>
    let OBI_0002581 = _prefix "OBI_0002581"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002583"></see>
    /// </summary>
    let OBI_0002583 = _prefix "OBI_0002583"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002584"></see>
    /// </summary>
    let OBI_0002584 = _prefix "OBI_0002584"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002586"></see>
    /// </summary>
    let OBI_0002586 = _prefix "OBI_0002586"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002587"></see>
    /// </summary>
    let OBI_0002587 = _prefix "OBI_0002587"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002588"></see>
    /// </summary>
    let OBI_0002588 = _prefix "OBI_0002588"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002589"></see>
    /// </summary>
    let OBI_0002589 = _prefix "OBI_0002589"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002590"></see>
    /// </summary>
    let OBI_0002590 = _prefix "OBI_0002590"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002591"></see>
    /// </summary>
    let OBI_0002591 = _prefix "OBI_0002591"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002592"></see>
    /// </summary>
    let OBI_0002592 = _prefix "OBI_0002592"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002593"></see>
    /// </summary>
    let OBI_0002593 = _prefix "OBI_0002593"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002594"></see>
    /// </summary>
    let OBI_0002594 = _prefix "OBI_0002594"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002595"></see>
    /// </summary>
    let OBI_0002595 = _prefix "OBI_0002595"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002596"></see>
    /// </summary>
    let OBI_0002596 = _prefix "OBI_0002596"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002597"></see>
    /// </summary>
    let OBI_0002597 = _prefix "OBI_0002597"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002601"></see>
    /// </summary>
    let OBI_0002601 = _prefix "OBI_0002601"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002603"></see>
    /// </summary>
    let OBI_0002603 = _prefix "OBI_0002603"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002032"></see>
    /// </summary>
    let UBERON_0002032 = _prefix "UBERON_0002032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002604"></see>
    /// </summary>
    let OBI_0002604 = _prefix "OBI_0002604"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002605"></see>
    /// </summary>
    let OBI_0002605 = _prefix "OBI_0002605"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001567"></see>
    /// </summary>
    let UBERON_0001567 = _prefix "UBERON_0001567"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002606"></see>
    /// </summary>
    let OBI_0002606 = _prefix "OBI_0002606"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001728"></see>
    /// </summary>
    let UBERON_0001728 = _prefix "UBERON_0001728"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002607"></see>
    /// </summary>
    let OBI_0002607 = _prefix "OBI_0002607"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002608"></see>
    /// </summary>
    let OBI_0002608 = _prefix "OBI_0002608"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001729"></see>
    /// </summary>
    let UBERON_0001729 = _prefix "UBERON_0001729"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002609"></see>
    /// </summary>
    let OBI_0002609 = _prefix "OBI_0002609"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001052"></see>
    /// </summary>
    let UBERON_0001052 = _prefix "UBERON_0001052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002610"></see>
    /// </summary>
    let OBI_0002610 = _prefix "OBI_0002610"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001723"></see>
    /// </summary>
    let UBERON_0001723 = _prefix "UBERON_0001723"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002611"></see>
    /// </summary>
    let OBI_0002611 = _prefix "OBI_0002611"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002612"></see>
    /// </summary>
    let OBI_0002612 = _prefix "OBI_0002612"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002613"></see>
    /// </summary>
    let OBI_0002613 = _prefix "OBI_0002613"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002614"></see>
    /// </summary>
    let OBI_0002614 = _prefix "OBI_0002614"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002615"></see>
    /// </summary>
    let OBI_0002615 = _prefix "OBI_0002615"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002616"></see>
    /// </summary>
    let OBI_0002616 = _prefix "OBI_0002616"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002617"></see>
    /// </summary>
    let OBI_0002617 = _prefix "OBI_0002617"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002618"></see>
    /// </summary>
    let OBI_0002618 = _prefix "OBI_0002618"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0002815"></see>
    /// </summary>
    let OBI_0002815 = _prefix "OBI_0002815"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0005246"></see>
    /// </summary>
    let OBI_0005246 = _prefix "OBI_0005246"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100010"></see>
    /// </summary>
    let OBI_0100010 = _prefix "OBI_0100010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100014"></see>
    /// </summary>
    let OBI_0100014 = _prefix "OBI_0100014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100015"></see>
    /// </summary>
    let OBI_0100015 = _prefix "OBI_0100015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302885"></see>
    /// </summary>
    let OBI_0302885 = _prefix "OBI_0302885"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600052"></see>
    /// </summary>
    let OBI_0600052 = _prefix "OBI_0600052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100035"></see>
    /// </summary>
    let OBI_0100035 = _prefix "OBI_0100035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0000002"></see>
    /// </summary>
    let CL_0000002 = _prefix "CL_0000002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100039"></see>
    /// </summary>
    let OBI_0100039 = _prefix "OBI_0100039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100046"></see>
    /// </summary>
    let OBI_0100046 = _prefix "OBI_0100046"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302731"></see>
    /// </summary>
    let OBI_0302731 = _prefix "OBI_0302731"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100055"></see>
    /// </summary>
    let OBI_0100055 = _prefix "OBI_0100055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/CL_0007014"></see>
    /// </summary>
    let CL_0007014 = _prefix "CL_0007014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100056"></see>
    /// </summary>
    let OBI_0100056 = _prefix "OBI_0100056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100058"></see>
    /// </summary>
    let OBI_0100058 = _prefix "OBI_0100058"
    /// <summary>
    /// 1. The term 'line' is used when a culture has undergone an intentional experimental process to establish a more uniform and stable population of cells (see 'establishing cell line'). This will require one or more passages, but may involve additional selection processes. Through such passaging and/or selection processes, the resulting 'line' attains some level of genetic stability and compositional homogeneity which is typically absent in primary cultures. Because of their relative homogeneity, 'lines' are capable of being characterized and stably propagated over a period of time. A *new* cell line can be "established" not only through the passaging/selection of a primary culture, but also through experimental modifications of existing lines (e.g. immortalization, stable genetic modifications, drug selection for a resistant subset, etc.).  As defined here,  'cell line' can refer to a population of cells in active culture, applied experimentally, or stored in a quescent state for future use.
    ///
    /// 2. The definitional criteria provided here for the 'cell line' class demarcates populations that represent what researchers actually use in the practice of science - e.g. as inputs to culturing, experimentation, and sharing. The definition is such that cell lines will exhibit important attributes. For example, they will have a relatively homogenous cell type composition as they have experienced similar selective pressures due to their continuous co-propagation. In addition, these populations can also be characterized by a passage number, again owing to their common passaging history.?
    ///
    /// 3. Definitinal criteria are intended to be sufficiently clear to specify what are and what are not instances of 'cell lines' in the real world. A 'HeLa cell line' would be a subset of all HeLa cells in the world - specifically any subset that has been derived through a shared continuous lineage wherein the cells have always been passaged together and thereby evolved together through the selective pressures imposed by this common history. Accordingly, 'HeLa cell line' would not be used to refer to the collection of all HeLa cells in a given lab, or all HeLa cells in the ATCC repository, as cells in these collections will likely not all share a common culture history. Rather, 'HeLa cell line' could refer to the collection of cells I am culturing at a given moment, or that I apply in an experiment (as such collections typically meet the criteria of having a shared propagation history).  As noted above, it is such collections that are typically referred to in scientific discourse and publications.
    ///
    /// 4. Notably, the term 'line' has been alternately used by other terminologies and communities to refer to cultures that have been immortalized - ie has attained the capacity for indefinite propagation in vitro.  In this ontology, we refer to such cell lines as 'immortal cell lines', and use the term 'cell line' to indicate any culture that has been passaged.
    /// <see href="http://purl.obolibrary.org/obo/OBI_0100062"></see></summary>
    let OBI_0100062 = _prefix "OBI_0100062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100063"></see>
    /// </summary>
    let OBI_0100063 = _prefix "OBI_0100063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100064"></see>
    /// </summary>
    let OBI_0100064 = _prefix "OBI_0100064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100065"></see>
    /// </summary>
    let OBI_0100065 = _prefix "OBI_0100065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600040"></see>
    /// </summary>
    let OBI_0600040 = _prefix "OBI_0600040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100067"></see>
    /// </summary>
    let OBI_0100067 = _prefix "OBI_0100067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600044"></see>
    /// </summary>
    let OBI_0600044 = _prefix "OBI_0600044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100069"></see>
    /// </summary>
    let OBI_0100069 = _prefix "OBI_0100069"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0100086"></see>
    /// </summary>
    let OBI_0100086 = _prefix "OBI_0100086"
    /// <summary>
    /// A geometric mean calculation is a descriptive statistics calculation in which the mean is calculated by taking the nth root of the product of all of the observations in a data (n being the number of all observations).
    /// <see href="http://purl.obolibrary.org/obo/OBI_0200001"></see></summary>
    let OBI_0200001 = _prefix "OBI_0200001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200078"></see>
    /// </summary>
    let OBI_0200078 = _prefix "OBI_0200078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200177"></see>
    /// </summary>
    let OBI_0200177 = _prefix "OBI_0200177"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200002"></see>
    /// </summary>
    let OBI_0200002 = _prefix "OBI_0200002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200174"></see>
    /// </summary>
    let OBI_0200174 = _prefix "OBI_0200174"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200003"></see>
    /// </summary>
    let OBI_0200003 = _prefix "OBI_0200003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200004"></see>
    /// </summary>
    let OBI_0200004 = _prefix "OBI_0200004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200006"></see>
    /// </summary>
    let OBI_0200006 = _prefix "OBI_0200006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200007"></see>
    /// </summary>
    let OBI_0200007 = _prefix "OBI_0200007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200008"></see>
    /// </summary>
    let OBI_0200008 = _prefix "OBI_0200008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200010"></see>
    /// </summary>
    let OBI_0200010 = _prefix "OBI_0200010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200025"></see>
    /// </summary>
    let OBI_0200025 = _prefix "OBI_0200025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200011"></see>
    /// </summary>
    let OBI_0200011 = _prefix "OBI_0200011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200012"></see>
    /// </summary>
    let OBI_0200012 = _prefix "OBI_0200012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200013"></see>
    /// </summary>
    let OBI_0200013 = _prefix "OBI_0200013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200023"></see>
    /// </summary>
    let OBI_0200023 = _prefix "OBI_0200023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200014"></see>
    /// </summary>
    let OBI_0200014 = _prefix "OBI_0200014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200015"></see>
    /// </summary>
    let OBI_0200015 = _prefix "OBI_0200015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200016"></see>
    /// </summary>
    let OBI_0200016 = _prefix "OBI_0200016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200017"></see>
    /// </summary>
    let OBI_0200017 = _prefix "OBI_0200017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200018"></see>
    /// </summary>
    let OBI_0200018 = _prefix "OBI_0200018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200024"></see>
    /// </summary>
    let OBI_0200024 = _prefix "OBI_0200024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200019"></see>
    /// </summary>
    let OBI_0200019 = _prefix "OBI_0200019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200020"></see>
    /// </summary>
    let OBI_0200020 = _prefix "OBI_0200020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200093"></see>
    /// </summary>
    let OBI_0200093 = _prefix "OBI_0200093"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200021"></see>
    /// </summary>
    let OBI_0200021 = _prefix "OBI_0200021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200022"></see>
    /// </summary>
    let OBI_0200022 = _prefix "OBI_0200022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200071"></see>
    /// </summary>
    let OBI_0200071 = _prefix "OBI_0200071"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200183"></see>
    /// </summary>
    let OBI_0200183 = _prefix "OBI_0200183"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200185"></see>
    /// </summary>
    let OBI_0200185 = _prefix "OBI_0200185"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200026"></see>
    /// </summary>
    let OBI_0200026 = _prefix "OBI_0200026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200027"></see>
    /// </summary>
    let OBI_0200027 = _prefix "OBI_0200027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200028"></see>
    /// </summary>
    let OBI_0200028 = _prefix "OBI_0200028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200029"></see>
    /// </summary>
    let OBI_0200029 = _prefix "OBI_0200029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200030"></see>
    /// </summary>
    let OBI_0200030 = _prefix "OBI_0200030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200032"></see>
    /// </summary>
    let OBI_0200032 = _prefix "OBI_0200032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200034"></see>
    /// </summary>
    let OBI_0200034 = _prefix "OBI_0200034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200035"></see>
    /// </summary>
    let OBI_0200035 = _prefix "OBI_0200035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200036"></see>
    /// </summary>
    let OBI_0200036 = _prefix "OBI_0200036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200163"></see>
    /// </summary>
    let OBI_0200163 = _prefix "OBI_0200163"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200037"></see>
    /// </summary>
    let OBI_0200037 = _prefix "OBI_0200037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200040"></see>
    /// </summary>
    let OBI_0200040 = _prefix "OBI_0200040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200080"></see>
    /// </summary>
    let OBI_0200080 = _prefix "OBI_0200080"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200043"></see>
    /// </summary>
    let OBI_0200043 = _prefix "OBI_0200043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200154"></see>
    /// </summary>
    let OBI_0200154 = _prefix "OBI_0200154"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200044"></see>
    /// </summary>
    let OBI_0200044 = _prefix "OBI_0200044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200045"></see>
    /// </summary>
    let OBI_0200045 = _prefix "OBI_0200045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200049"></see>
    /// </summary>
    let OBI_0200049 = _prefix "OBI_0200049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200050"></see>
    /// </summary>
    let OBI_0200050 = _prefix "OBI_0200050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200052"></see>
    /// </summary>
    let OBI_0200052 = _prefix "OBI_0200052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200053"></see>
    /// </summary>
    let OBI_0200053 = _prefix "OBI_0200053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200054"></see>
    /// </summary>
    let OBI_0200054 = _prefix "OBI_0200054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200147"></see>
    /// </summary>
    let OBI_0200147 = _prefix "OBI_0200147"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200055"></see>
    /// </summary>
    let OBI_0200055 = _prefix "OBI_0200055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200057"></see>
    /// </summary>
    let OBI_0200057 = _prefix "OBI_0200057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200056"></see>
    /// </summary>
    let OBI_0200056 = _prefix "OBI_0200056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200058"></see>
    /// </summary>
    let OBI_0200058 = _prefix "OBI_0200058"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200059"></see>
    /// </summary>
    let OBI_0200059 = _prefix "OBI_0200059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200060"></see>
    /// </summary>
    let OBI_0200060 = _prefix "OBI_0200060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200061"></see>
    /// </summary>
    let OBI_0200061 = _prefix "OBI_0200061"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200062"></see>
    /// </summary>
    let OBI_0200062 = _prefix "OBI_0200062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200197"></see>
    /// </summary>
    let OBI_0200197 = _prefix "OBI_0200197"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200085"></see>
    /// </summary>
    let OBI_0200085 = _prefix "OBI_0200085"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200063"></see>
    /// </summary>
    let OBI_0200063 = _prefix "OBI_0200063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200064"></see>
    /// </summary>
    let OBI_0200064 = _prefix "OBI_0200064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200066"></see>
    /// </summary>
    let OBI_0200066 = _prefix "OBI_0200066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200073"></see>
    /// </summary>
    let OBI_0200073 = _prefix "OBI_0200073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200070"></see>
    /// </summary>
    let OBI_0200070 = _prefix "OBI_0200070"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200089"></see>
    /// </summary>
    let OBI_0200089 = _prefix "OBI_0200089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200074"></see>
    /// </summary>
    let OBI_0200074 = _prefix "OBI_0200074"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200075"></see>
    /// </summary>
    let OBI_0200075 = _prefix "OBI_0200075"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200076"></see>
    /// </summary>
    let OBI_0200076 = _prefix "OBI_0200076"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200077"></see>
    /// </summary>
    let OBI_0200077 = _prefix "OBI_0200077"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200157"></see>
    /// </summary>
    let OBI_0200157 = _prefix "OBI_0200157"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200079"></see>
    /// </summary>
    let OBI_0200079 = _prefix "OBI_0200079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200082"></see>
    /// </summary>
    let OBI_0200082 = _prefix "OBI_0200082"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200196"></see>
    /// </summary>
    let OBI_0200196 = _prefix "OBI_0200196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200083"></see>
    /// </summary>
    let OBI_0200083 = _prefix "OBI_0200083"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200086"></see>
    /// </summary>
    let OBI_0200086 = _prefix "OBI_0200086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200180"></see>
    /// </summary>
    let OBI_0200180 = _prefix "OBI_0200180"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200088"></see>
    /// </summary>
    let OBI_0200088 = _prefix "OBI_0200088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200194"></see>
    /// </summary>
    let OBI_0200194 = _prefix "OBI_0200194"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200091"></see>
    /// </summary>
    let OBI_0200091 = _prefix "OBI_0200091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200092"></see>
    /// </summary>
    let OBI_0200092 = _prefix "OBI_0200092"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200094"></see>
    /// </summary>
    let OBI_0200094 = _prefix "OBI_0200094"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200095"></see>
    /// </summary>
    let OBI_0200095 = _prefix "OBI_0200095"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200097"></see>
    /// </summary>
    let OBI_0200097 = _prefix "OBI_0200097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200098"></see>
    /// </summary>
    let OBI_0200098 = _prefix "OBI_0200098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200099"></see>
    /// </summary>
    let OBI_0200099 = _prefix "OBI_0200099"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200106"></see>
    /// </summary>
    let OBI_0200106 = _prefix "OBI_0200106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200100"></see>
    /// </summary>
    let OBI_0200100 = _prefix "OBI_0200100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200101"></see>
    /// </summary>
    let OBI_0200101 = _prefix "OBI_0200101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200102"></see>
    /// </summary>
    let OBI_0200102 = _prefix "OBI_0200102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200103"></see>
    /// </summary>
    let OBI_0200103 = _prefix "OBI_0200103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200104"></see>
    /// </summary>
    let OBI_0200104 = _prefix "OBI_0200104"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200105"></see>
    /// </summary>
    let OBI_0200105 = _prefix "OBI_0200105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200107"></see>
    /// </summary>
    let OBI_0200107 = _prefix "OBI_0200107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200108"></see>
    /// </summary>
    let OBI_0200108 = _prefix "OBI_0200108"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200109"></see>
    /// </summary>
    let OBI_0200109 = _prefix "OBI_0200109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200110"></see>
    /// </summary>
    let OBI_0200110 = _prefix "OBI_0200110"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200111"></see>
    /// </summary>
    let OBI_0200111 = _prefix "OBI_0200111"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200113"></see>
    /// </summary>
    let OBI_0200113 = _prefix "OBI_0200113"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200114"></see>
    /// </summary>
    let OBI_0200114 = _prefix "OBI_0200114"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200115"></see>
    /// </summary>
    let OBI_0200115 = _prefix "OBI_0200115"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200116"></see>
    /// </summary>
    let OBI_0200116 = _prefix "OBI_0200116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200117"></see>
    /// </summary>
    let OBI_0200117 = _prefix "OBI_0200117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200118"></see>
    /// </summary>
    let OBI_0200118 = _prefix "OBI_0200118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200119"></see>
    /// </summary>
    let OBI_0200119 = _prefix "OBI_0200119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200120"></see>
    /// </summary>
    let OBI_0200120 = _prefix "OBI_0200120"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200121"></see>
    /// </summary>
    let OBI_0200121 = _prefix "OBI_0200121"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200122"></see>
    /// </summary>
    let OBI_0200122 = _prefix "OBI_0200122"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200123"></see>
    /// </summary>
    let OBI_0200123 = _prefix "OBI_0200123"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200124"></see>
    /// </summary>
    let OBI_0200124 = _prefix "OBI_0200124"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200125"></see>
    /// </summary>
    let OBI_0200125 = _prefix "OBI_0200125"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200189"></see>
    /// </summary>
    let OBI_0200189 = _prefix "OBI_0200189"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200126"></see>
    /// </summary>
    let OBI_0200126 = _prefix "OBI_0200126"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200127"></see>
    /// </summary>
    let OBI_0200127 = _prefix "OBI_0200127"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200128"></see>
    /// </summary>
    let OBI_0200128 = _prefix "OBI_0200128"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200129"></see>
    /// </summary>
    let OBI_0200129 = _prefix "OBI_0200129"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200130"></see>
    /// </summary>
    let OBI_0200130 = _prefix "OBI_0200130"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200131"></see>
    /// </summary>
    let OBI_0200131 = _prefix "OBI_0200131"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200132"></see>
    /// </summary>
    let OBI_0200132 = _prefix "OBI_0200132"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200133"></see>
    /// </summary>
    let OBI_0200133 = _prefix "OBI_0200133"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200134"></see>
    /// </summary>
    let OBI_0200134 = _prefix "OBI_0200134"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200135"></see>
    /// </summary>
    let OBI_0200135 = _prefix "OBI_0200135"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200136"></see>
    /// </summary>
    let OBI_0200136 = _prefix "OBI_0200136"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200137"></see>
    /// </summary>
    let OBI_0200137 = _prefix "OBI_0200137"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200138"></see>
    /// </summary>
    let OBI_0200138 = _prefix "OBI_0200138"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200139"></see>
    /// </summary>
    let OBI_0200139 = _prefix "OBI_0200139"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200141"></see>
    /// </summary>
    let OBI_0200141 = _prefix "OBI_0200141"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200143"></see>
    /// </summary>
    let OBI_0200143 = _prefix "OBI_0200143"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200144"></see>
    /// </summary>
    let OBI_0200144 = _prefix "OBI_0200144"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200145"></see>
    /// </summary>
    let OBI_0200145 = _prefix "OBI_0200145"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200146"></see>
    /// </summary>
    let OBI_0200146 = _prefix "OBI_0200146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200149"></see>
    /// </summary>
    let OBI_0200149 = _prefix "OBI_0200149"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200150"></see>
    /// </summary>
    let OBI_0200150 = _prefix "OBI_0200150"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200151"></see>
    /// </summary>
    let OBI_0200151 = _prefix "OBI_0200151"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200152"></see>
    /// </summary>
    let OBI_0200152 = _prefix "OBI_0200152"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200153"></see>
    /// </summary>
    let OBI_0200153 = _prefix "OBI_0200153"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200155"></see>
    /// </summary>
    let OBI_0200155 = _prefix "OBI_0200155"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200156"></see>
    /// </summary>
    let OBI_0200156 = _prefix "OBI_0200156"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200160"></see>
    /// </summary>
    let OBI_0200160 = _prefix "OBI_0200160"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200161"></see>
    /// </summary>
    let OBI_0200161 = _prefix "OBI_0200161"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200162"></see>
    /// </summary>
    let OBI_0200162 = _prefix "OBI_0200162"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200164"></see>
    /// </summary>
    let OBI_0200164 = _prefix "OBI_0200164"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200165"></see>
    /// </summary>
    let OBI_0200165 = _prefix "OBI_0200165"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200168"></see>
    /// </summary>
    let OBI_0200168 = _prefix "OBI_0200168"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200176"></see>
    /// </summary>
    let OBI_0200176 = _prefix "OBI_0200176"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200191"></see>
    /// </summary>
    let OBI_0200191 = _prefix "OBI_0200191"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200192"></see>
    /// </summary>
    let OBI_0200192 = _prefix "OBI_0200192"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200193"></see>
    /// </summary>
    let OBI_0200193 = _prefix "OBI_0200193"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200195"></see>
    /// </summary>
    let OBI_0200195 = _prefix "OBI_0200195"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200199"></see>
    /// </summary>
    let OBI_0200199 = _prefix "OBI_0200199"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200200"></see>
    /// </summary>
    let OBI_0200200 = _prefix "OBI_0200200"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0200201"></see>
    /// </summary>
    let OBI_0200201 = _prefix "OBI_0200201"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0300310"></see>
    /// </summary>
    let OBI_0300310 = _prefix "OBI_0300310"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0300311"></see>
    /// </summary>
    let OBI_0300311 = _prefix "OBI_0300311"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302714"></see>
    /// </summary>
    let OBI_0302714 = _prefix "OBI_0302714"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302716"></see>
    /// </summary>
    let OBI_0302716 = _prefix "OBI_0302716"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302733"></see>
    /// </summary>
    let OBI_0302733 = _prefix "OBI_0302733"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302736"></see>
    /// </summary>
    let OBI_0302736 = _prefix "OBI_0302736"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302737"></see>
    /// </summary>
    let OBI_0302737 = _prefix "OBI_0302737"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302743"></see>
    /// </summary>
    let OBI_0302743 = _prefix "OBI_0302743"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302745"></see>
    /// </summary>
    let OBI_0302745 = _prefix "OBI_0302745"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302835"></see>
    /// </summary>
    let OBI_0302835 = _prefix "OBI_0302835"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302837"></see>
    /// </summary>
    let OBI_0302837 = _prefix "OBI_0302837"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302899"></see>
    /// </summary>
    let OBI_0302899 = _prefix "OBI_0302899"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302838"></see>
    /// </summary>
    let OBI_0302838 = _prefix "OBI_0302838"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302911"></see>
    /// </summary>
    let OBI_0302911 = _prefix "OBI_0302911"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302840"></see>
    /// </summary>
    let OBI_0302840 = _prefix "OBI_0302840"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302914"></see>
    /// </summary>
    let OBI_0302914 = _prefix "OBI_0302914"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302846"></see>
    /// </summary>
    let OBI_0302846 = _prefix "OBI_0302846"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302900"></see>
    /// </summary>
    let OBI_0302900 = _prefix "OBI_0302900"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302847"></see>
    /// </summary>
    let OBI_0302847 = _prefix "OBI_0302847"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600039"></see>
    /// </summary>
    let OBI_0600039 = _prefix "OBI_0600039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302867"></see>
    /// </summary>
    let OBI_0302867 = _prefix "OBI_0302867"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302910"></see>
    /// </summary>
    let OBI_0302910 = _prefix "OBI_0302910"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302868"></see>
    /// </summary>
    let OBI_0302868 = _prefix "OBI_0302868"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302874"></see>
    /// </summary>
    let OBI_0302874 = _prefix "OBI_0302874"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302908"></see>
    /// </summary>
    let OBI_0302908 = _prefix "OBI_0302908"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302876"></see>
    /// </summary>
    let OBI_0302876 = _prefix "OBI_0302876"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302888"></see>
    /// </summary>
    let OBI_0302888 = _prefix "OBI_0302888"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302889"></see>
    /// </summary>
    let OBI_0302889 = _prefix "OBI_0302889"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302891"></see>
    /// </summary>
    let OBI_0302891 = _prefix "OBI_0302891"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302894"></see>
    /// </summary>
    let OBI_0302894 = _prefix "OBI_0302894"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302895"></see>
    /// </summary>
    let OBI_0302895 = _prefix "OBI_0302895"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400142"></see>
    /// </summary>
    let OBI_0400142 = _prefix "OBI_0400142"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302896"></see>
    /// </summary>
    let OBI_0302896 = _prefix "OBI_0302896"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302897"></see>
    /// </summary>
    let OBI_0302897 = _prefix "OBI_0302897"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302898"></see>
    /// </summary>
    let OBI_0302898 = _prefix "OBI_0302898"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600015"></see>
    /// </summary>
    let OBI_0600015 = _prefix "OBI_0600015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302901"></see>
    /// </summary>
    let OBI_0302901 = _prefix "OBI_0302901"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302902"></see>
    /// </summary>
    let OBI_0302902 = _prefix "OBI_0302902"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400110"></see>
    /// </summary>
    let OBI_0400110 = _prefix "OBI_0400110"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302906"></see>
    /// </summary>
    let OBI_0302906 = _prefix "OBI_0302906"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0302912"></see>
    /// </summary>
    let OBI_0302912 = _prefix "OBI_0302912"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400005"></see>
    /// </summary>
    let OBI_0400005 = _prefix "OBI_0400005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400006"></see>
    /// </summary>
    let OBI_0400006 = _prefix "OBI_0400006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400007"></see>
    /// </summary>
    let OBI_0400007 = _prefix "OBI_0400007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400082"></see>
    /// </summary>
    let OBI_0400082 = _prefix "OBI_0400082"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400043"></see>
    /// </summary>
    let OBI_0400043 = _prefix "OBI_0400043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400079"></see>
    /// </summary>
    let OBI_0400079 = _prefix "OBI_0400079"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400009"></see>
    /// </summary>
    let OBI_0400009 = _prefix "OBI_0400009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400010"></see>
    /// </summary>
    let OBI_0400010 = _prefix "OBI_0400010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400060"></see>
    /// </summary>
    let OBI_0400060 = _prefix "OBI_0400060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400011"></see>
    /// </summary>
    let OBI_0400011 = _prefix "OBI_0400011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400083"></see>
    /// </summary>
    let OBI_0400083 = _prefix "OBI_0400083"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400012"></see>
    /// </summary>
    let OBI_0400012 = _prefix "OBI_0400012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400013"></see>
    /// </summary>
    let OBI_0400013 = _prefix "OBI_0400013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400014"></see>
    /// </summary>
    let OBI_0400014 = _prefix "OBI_0400014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400015"></see>
    /// </summary>
    let OBI_0400015 = _prefix "OBI_0400015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400016"></see>
    /// </summary>
    let OBI_0400016 = _prefix "OBI_0400016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400017"></see>
    /// </summary>
    let OBI_0400017 = _prefix "OBI_0400017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400018"></see>
    /// </summary>
    let OBI_0400018 = _prefix "OBI_0400018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400019"></see>
    /// </summary>
    let OBI_0400019 = _prefix "OBI_0400019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400020"></see>
    /// </summary>
    let OBI_0400020 = _prefix "OBI_0400020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400022"></see>
    /// </summary>
    let OBI_0400022 = _prefix "OBI_0400022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400023"></see>
    /// </summary>
    let OBI_0400023 = _prefix "OBI_0400023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400024"></see>
    /// </summary>
    let OBI_0400024 = _prefix "OBI_0400024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400025"></see>
    /// </summary>
    let OBI_0400025 = _prefix "OBI_0400025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400026"></see>
    /// </summary>
    let OBI_0400026 = _prefix "OBI_0400026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400027"></see>
    /// </summary>
    let OBI_0400027 = _prefix "OBI_0400027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400028"></see>
    /// </summary>
    let OBI_0400028 = _prefix "OBI_0400028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400029"></see>
    /// </summary>
    let OBI_0400029 = _prefix "OBI_0400029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400030"></see>
    /// </summary>
    let OBI_0400030 = _prefix "OBI_0400030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400031"></see>
    /// </summary>
    let OBI_0400031 = _prefix "OBI_0400031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400032"></see>
    /// </summary>
    let OBI_0400032 = _prefix "OBI_0400032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400033"></see>
    /// </summary>
    let OBI_0400033 = _prefix "OBI_0400033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400064"></see>
    /// </summary>
    let OBI_0400064 = _prefix "OBI_0400064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400034"></see>
    /// </summary>
    let OBI_0400034 = _prefix "OBI_0400034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400036"></see>
    /// </summary>
    let OBI_0400036 = _prefix "OBI_0400036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400037"></see>
    /// </summary>
    let OBI_0400037 = _prefix "OBI_0400037"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400038"></see>
    /// </summary>
    let OBI_0400038 = _prefix "OBI_0400038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400039"></see>
    /// </summary>
    let OBI_0400039 = _prefix "OBI_0400039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400040"></see>
    /// </summary>
    let OBI_0400040 = _prefix "OBI_0400040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400041"></see>
    /// </summary>
    let OBI_0400041 = _prefix "OBI_0400041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400042"></see>
    /// </summary>
    let OBI_0400042 = _prefix "OBI_0400042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400078"></see>
    /// </summary>
    let OBI_0400078 = _prefix "OBI_0400078"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400153"></see>
    /// </summary>
    let OBI_0400153 = _prefix "OBI_0400153"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400137"></see>
    /// </summary>
    let OBI_0400137 = _prefix "OBI_0400137"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400045"></see>
    /// </summary>
    let OBI_0400045 = _prefix "OBI_0400045"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400047"></see>
    /// </summary>
    let OBI_0400047 = _prefix "OBI_0400047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400048"></see>
    /// </summary>
    let OBI_0400048 = _prefix "OBI_0400048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400049"></see>
    /// </summary>
    let OBI_0400049 = _prefix "OBI_0400049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400050"></see>
    /// </summary>
    let OBI_0400050 = _prefix "OBI_0400050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400051"></see>
    /// </summary>
    let OBI_0400051 = _prefix "OBI_0400051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400052"></see>
    /// </summary>
    let OBI_0400052 = _prefix "OBI_0400052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400073"></see>
    /// </summary>
    let OBI_0400073 = _prefix "OBI_0400073"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400053"></see>
    /// </summary>
    let OBI_0400053 = _prefix "OBI_0400053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400054"></see>
    /// </summary>
    let OBI_0400054 = _prefix "OBI_0400054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400146"></see>
    /// </summary>
    let OBI_0400146 = _prefix "OBI_0400146"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400135"></see>
    /// </summary>
    let OBI_0400135 = _prefix "OBI_0400135"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400055"></see>
    /// </summary>
    let OBI_0400055 = _prefix "OBI_0400055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400056"></see>
    /// </summary>
    let OBI_0400056 = _prefix "OBI_0400056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400059"></see>
    /// </summary>
    let OBI_0400059 = _prefix "OBI_0400059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400061"></see>
    /// </summary>
    let OBI_0400061 = _prefix "OBI_0400061"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400062"></see>
    /// </summary>
    let OBI_0400062 = _prefix "OBI_0400062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400063"></see>
    /// </summary>
    let OBI_0400063 = _prefix "OBI_0400063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400066"></see>
    /// </summary>
    let OBI_0400066 = _prefix "OBI_0400066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400101"></see>
    /// </summary>
    let OBI_0400101 = _prefix "OBI_0400101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400067"></see>
    /// </summary>
    let OBI_0400067 = _prefix "OBI_0400067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400068"></see>
    /// </summary>
    let OBI_0400068 = _prefix "OBI_0400068"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400069"></see>
    /// </summary>
    let OBI_0400069 = _prefix "OBI_0400069"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400070"></see>
    /// </summary>
    let OBI_0400070 = _prefix "OBI_0400070"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400071"></see>
    /// </summary>
    let OBI_0400071 = _prefix "OBI_0400071"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400074"></see>
    /// </summary>
    let OBI_0400074 = _prefix "OBI_0400074"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400075"></see>
    /// </summary>
    let OBI_0400075 = _prefix "OBI_0400075"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400081"></see>
    /// </summary>
    let OBI_0400081 = _prefix "OBI_0400081"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400077"></see>
    /// </summary>
    let OBI_0400077 = _prefix "OBI_0400077"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400096"></see>
    /// </summary>
    let OBI_0400096 = _prefix "OBI_0400096"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400080"></see>
    /// </summary>
    let OBI_0400080 = _prefix "OBI_0400080"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400084"></see>
    /// </summary>
    let OBI_0400084 = _prefix "OBI_0400084"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400085"></see>
    /// </summary>
    let OBI_0400085 = _prefix "OBI_0400085"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400086"></see>
    /// </summary>
    let OBI_0400086 = _prefix "OBI_0400086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400087"></see>
    /// </summary>
    let OBI_0400087 = _prefix "OBI_0400087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400088"></see>
    /// </summary>
    let OBI_0400088 = _prefix "OBI_0400088"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400089"></see>
    /// </summary>
    let OBI_0400089 = _prefix "OBI_0400089"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400091"></see>
    /// </summary>
    let OBI_0400091 = _prefix "OBI_0400091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400094"></see>
    /// </summary>
    let OBI_0400094 = _prefix "OBI_0400094"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400095"></see>
    /// </summary>
    let OBI_0400095 = _prefix "OBI_0400095"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400097"></see>
    /// </summary>
    let OBI_0400097 = _prefix "OBI_0400097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400098"></see>
    /// </summary>
    let OBI_0400098 = _prefix "OBI_0400098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400100"></see>
    /// </summary>
    let OBI_0400100 = _prefix "OBI_0400100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400102"></see>
    /// </summary>
    let OBI_0400102 = _prefix "OBI_0400102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400104"></see>
    /// </summary>
    let OBI_0400104 = _prefix "OBI_0400104"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400105"></see>
    /// </summary>
    let OBI_0400105 = _prefix "OBI_0400105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400108"></see>
    /// </summary>
    let OBI_0400108 = _prefix "OBI_0400108"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400109"></see>
    /// </summary>
    let OBI_0400109 = _prefix "OBI_0400109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400111"></see>
    /// </summary>
    let OBI_0400111 = _prefix "OBI_0400111"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400117"></see>
    /// </summary>
    let OBI_0400117 = _prefix "OBI_0400117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400118"></see>
    /// </summary>
    let OBI_0400118 = _prefix "OBI_0400118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400119"></see>
    /// </summary>
    let OBI_0400119 = _prefix "OBI_0400119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400120"></see>
    /// </summary>
    let OBI_0400120 = _prefix "OBI_0400120"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400121"></see>
    /// </summary>
    let OBI_0400121 = _prefix "OBI_0400121"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400140"></see>
    /// </summary>
    let OBI_0400140 = _prefix "OBI_0400140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400155"></see>
    /// </summary>
    let OBI_0400155 = _prefix "OBI_0400155"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400157"></see>
    /// </summary>
    let OBI_0400157 = _prefix "OBI_0400157"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400158"></see>
    /// </summary>
    let OBI_0400158 = _prefix "OBI_0400158"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0400170"></see>
    /// </summary>
    let OBI_0400170 = _prefix "OBI_0400170"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500002"></see>
    /// </summary>
    let OBI_0500002 = _prefix "OBI_0500002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500003"></see>
    /// </summary>
    let OBI_0500003 = _prefix "OBI_0500003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500004"></see>
    /// </summary>
    let OBI_0500004 = _prefix "OBI_0500004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500005"></see>
    /// </summary>
    let OBI_0500005 = _prefix "OBI_0500005"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500006"></see>
    /// </summary>
    let OBI_0500006 = _prefix "OBI_0500006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500007"></see>
    /// </summary>
    let OBI_0500007 = _prefix "OBI_0500007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500008"></see>
    /// </summary>
    let OBI_0500008 = _prefix "OBI_0500008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500014"></see>
    /// </summary>
    let OBI_0500014 = _prefix "OBI_0500014"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500009"></see>
    /// </summary>
    let OBI_0500009 = _prefix "OBI_0500009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500010"></see>
    /// </summary>
    let OBI_0500010 = _prefix "OBI_0500010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500011"></see>
    /// </summary>
    let OBI_0500011 = _prefix "OBI_0500011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500012"></see>
    /// </summary>
    let OBI_0500012 = _prefix "OBI_0500012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500013"></see>
    /// </summary>
    let OBI_0500013 = _prefix "OBI_0500013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500015"></see>
    /// </summary>
    let OBI_0500015 = _prefix "OBI_0500015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500016"></see>
    /// </summary>
    let OBI_0500016 = _prefix "OBI_0500016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500017"></see>
    /// </summary>
    let OBI_0500017 = _prefix "OBI_0500017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500018"></see>
    /// </summary>
    let OBI_0500018 = _prefix "OBI_0500018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500019"></see>
    /// </summary>
    let OBI_0500019 = _prefix "OBI_0500019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500020"></see>
    /// </summary>
    let OBI_0500020 = _prefix "OBI_0500020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500022"></see>
    /// </summary>
    let OBI_0500022 = _prefix "OBI_0500022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500023"></see>
    /// </summary>
    let OBI_0500023 = _prefix "OBI_0500023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500024"></see>
    /// </summary>
    let OBI_0500024 = _prefix "OBI_0500024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500025"></see>
    /// </summary>
    let OBI_0500025 = _prefix "OBI_0500025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0500026"></see>
    /// </summary>
    let OBI_0500026 = _prefix "OBI_0500026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600000"></see>
    /// </summary>
    let OBI_0600000 = _prefix "OBI_0600000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600002"></see>
    /// </summary>
    let OBI_0600002 = _prefix "OBI_0600002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600003"></see>
    /// </summary>
    let OBI_0600003 = _prefix "OBI_0600003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600004"></see>
    /// </summary>
    let OBI_0600004 = _prefix "OBI_0600004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600008"></see>
    /// </summary>
    let OBI_0600008 = _prefix "OBI_0600008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600011"></see>
    /// </summary>
    let OBI_0600011 = _prefix "OBI_0600011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600012"></see>
    /// </summary>
    let OBI_0600012 = _prefix "OBI_0600012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600016"></see>
    /// </summary>
    let OBI_0600016 = _prefix "OBI_0600016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600018"></see>
    /// </summary>
    let OBI_0600018 = _prefix "OBI_0600018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600019"></see>
    /// </summary>
    let OBI_0600019 = _prefix "OBI_0600019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600021"></see>
    /// </summary>
    let OBI_0600021 = _prefix "OBI_0600021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600022"></see>
    /// </summary>
    let OBI_0600022 = _prefix "OBI_0600022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600025"></see>
    /// </summary>
    let OBI_0600025 = _prefix "OBI_0600025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600026"></see>
    /// </summary>
    let OBI_0600026 = _prefix "OBI_0600026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600027"></see>
    /// </summary>
    let OBI_0600027 = _prefix "OBI_0600027"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600029"></see>
    /// </summary>
    let OBI_0600029 = _prefix "OBI_0600029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600030"></see>
    /// </summary>
    let OBI_0600030 = _prefix "OBI_0600030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600032"></see>
    /// </summary>
    let OBI_0600032 = _prefix "OBI_0600032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110109"></see>
    /// </summary>
    let OBI_1110109 = _prefix "OBI_1110109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600041"></see>
    /// </summary>
    let OBI_0600041 = _prefix "OBI_0600041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600042"></see>
    /// </summary>
    let OBI_0600042 = _prefix "OBI_0600042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600048"></see>
    /// </summary>
    let OBI_0600048 = _prefix "OBI_0600048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600049"></see>
    /// </summary>
    let OBI_0600049 = _prefix "OBI_0600049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600051"></see>
    /// </summary>
    let OBI_0600051 = _prefix "OBI_0600051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600054"></see>
    /// </summary>
    let OBI_0600054 = _prefix "OBI_0600054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600055"></see>
    /// </summary>
    let OBI_0600055 = _prefix "OBI_0600055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600057"></see>
    /// </summary>
    let OBI_0600057 = _prefix "OBI_0600057"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600059"></see>
    /// </summary>
    let OBI_0600059 = _prefix "OBI_0600059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600060"></see>
    /// </summary>
    let OBI_0600060 = _prefix "OBI_0600060"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600063"></see>
    /// </summary>
    let OBI_0600063 = _prefix "OBI_0600063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600065"></see>
    /// </summary>
    let OBI_0600065 = _prefix "OBI_0600065"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_0600067"></see>
    /// </summary>
    let OBI_0600067 = _prefix "OBI_0600067"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000023"></see>
    /// </summary>
    let OBI_1000023 = _prefix "OBI_1000023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000024"></see>
    /// </summary>
    let OBI_1000024 = _prefix "OBI_1000024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000042"></see>
    /// </summary>
    let OBI_1000042 = _prefix "OBI_1000042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000048"></see>
    /// </summary>
    let OBI_1000048 = _prefix "OBI_1000048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1000049"></see>
    /// </summary>
    let OBI_1000049 = _prefix "OBI_1000049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110002"></see>
    /// </summary>
    let OBI_1110002 = _prefix "OBI_1110002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110003"></see>
    /// </summary>
    let OBI_1110003 = _prefix "OBI_1110003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110026"></see>
    /// </summary>
    let OBI_1110026 = _prefix "OBI_1110026"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002220"></see>
    /// </summary>
    let RO_0002220 = _prefix "RO_0002220"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110007"></see>
    /// </summary>
    let OBI_1110007 = _prefix "OBI_1110007"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110008"></see>
    /// </summary>
    let OBI_1110008 = _prefix "OBI_1110008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110021"></see>
    /// </summary>
    let OBI_1110021 = _prefix "OBI_1110021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110040"></see>
    /// </summary>
    let OBI_1110040 = _prefix "OBI_1110040"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110010"></see>
    /// </summary>
    let OBI_1110010 = _prefix "OBI_1110010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110011"></see>
    /// </summary>
    let OBI_1110011 = _prefix "OBI_1110011"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110122"></see>
    /// </summary>
    let OBI_1110122 = _prefix "OBI_1110122"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110012"></see>
    /// </summary>
    let OBI_1110012 = _prefix "OBI_1110012"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110049"></see>
    /// </summary>
    let OBI_1110049 = _prefix "OBI_1110049"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110013"></see>
    /// </summary>
    let OBI_1110013 = _prefix "OBI_1110013"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110094"></see>
    /// </summary>
    let OBI_1110094 = _prefix "OBI_1110094"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110016"></see>
    /// </summary>
    let OBI_1110016 = _prefix "OBI_1110016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110017"></see>
    /// </summary>
    let OBI_1110017 = _prefix "OBI_1110017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110111"></see>
    /// </summary>
    let OBI_1110111 = _prefix "OBI_1110111"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110018"></see>
    /// </summary>
    let OBI_1110018 = _prefix "OBI_1110018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110019"></see>
    /// </summary>
    let OBI_1110019 = _prefix "OBI_1110019"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110020"></see>
    /// </summary>
    let OBI_1110020 = _prefix "OBI_1110020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110023"></see>
    /// </summary>
    let OBI_1110023 = _prefix "OBI_1110023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110082"></see>
    /// </summary>
    let OBI_1110082 = _prefix "OBI_1110082"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110024"></see>
    /// </summary>
    let OBI_1110024 = _prefix "OBI_1110024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110083"></see>
    /// </summary>
    let OBI_1110083 = _prefix "OBI_1110083"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110028"></see>
    /// </summary>
    let OBI_1110028 = _prefix "OBI_1110028"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110029"></see>
    /// </summary>
    let OBI_1110029 = _prefix "OBI_1110029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110030"></see>
    /// </summary>
    let OBI_1110030 = _prefix "OBI_1110030"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110031"></see>
    /// </summary>
    let OBI_1110031 = _prefix "OBI_1110031"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110032"></see>
    /// </summary>
    let OBI_1110032 = _prefix "OBI_1110032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110033"></see>
    /// </summary>
    let OBI_1110033 = _prefix "OBI_1110033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110034"></see>
    /// </summary>
    let OBI_1110034 = _prefix "OBI_1110034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110120"></see>
    /// </summary>
    let OBI_1110120 = _prefix "OBI_1110120"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110035"></see>
    /// </summary>
    let OBI_1110035 = _prefix "OBI_1110035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110036"></see>
    /// </summary>
    let OBI_1110036 = _prefix "OBI_1110036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110038"></see>
    /// </summary>
    let OBI_1110038 = _prefix "OBI_1110038"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110039"></see>
    /// </summary>
    let OBI_1110039 = _prefix "OBI_1110039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110041"></see>
    /// </summary>
    let OBI_1110041 = _prefix "OBI_1110041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110046"></see>
    /// </summary>
    let OBI_1110046 = _prefix "OBI_1110046"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000029"></see>
    /// </summary>
    let UBERON_0000029 = _prefix "UBERON_0000029"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110043"></see>
    /// </summary>
    let OBI_1110043 = _prefix "OBI_1110043"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110044"></see>
    /// </summary>
    let OBI_1110044 = _prefix "OBI_1110044"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110047"></see>
    /// </summary>
    let OBI_1110047 = _prefix "OBI_1110047"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000001018"></see>
    /// </summary>
    let PR_000001018 = _prefix "PR_000001018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110048"></see>
    /// </summary>
    let OBI_1110048 = _prefix "OBI_1110048"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110050"></see>
    /// </summary>
    let OBI_1110050 = _prefix "OBI_1110050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000001004"></see>
    /// </summary>
    let PR_000001004 = _prefix "PR_000001004"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110051"></see>
    /// </summary>
    let OBI_1110051 = _prefix "OBI_1110051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110132"></see>
    /// </summary>
    let OBI_1110132 = _prefix "OBI_1110132"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110052"></see>
    /// </summary>
    let OBI_1110052 = _prefix "OBI_1110052"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110053"></see>
    /// </summary>
    let OBI_1110053 = _prefix "OBI_1110053"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110054"></see>
    /// </summary>
    let OBI_1110054 = _prefix "OBI_1110054"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110055"></see>
    /// </summary>
    let OBI_1110055 = _prefix "OBI_1110055"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110056"></see>
    /// </summary>
    let OBI_1110056 = _prefix "OBI_1110056"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110086"></see>
    /// </summary>
    let OBI_1110086 = _prefix "OBI_1110086"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110059"></see>
    /// </summary>
    let OBI_1110059 = _prefix "OBI_1110059"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110061"></see>
    /// </summary>
    let OBI_1110061 = _prefix "OBI_1110061"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110084"></see>
    /// </summary>
    let OBI_1110084 = _prefix "OBI_1110084"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110085"></see>
    /// </summary>
    let OBI_1110085 = _prefix "OBI_1110085"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110087"></see>
    /// </summary>
    let OBI_1110087 = _prefix "OBI_1110087"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110091"></see>
    /// </summary>
    let OBI_1110091 = _prefix "OBI_1110091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110095"></see>
    /// </summary>
    let OBI_1110095 = _prefix "OBI_1110095"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110099"></see>
    /// </summary>
    let OBI_1110099 = _prefix "OBI_1110099"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110106"></see>
    /// </summary>
    let OBI_1110106 = _prefix "OBI_1110106"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110107"></see>
    /// </summary>
    let OBI_1110107 = _prefix "OBI_1110107"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110112"></see>
    /// </summary>
    let OBI_1110112 = _prefix "OBI_1110112"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110114"></see>
    /// </summary>
    let OBI_1110114 = _prefix "OBI_1110114"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110116"></see>
    /// </summary>
    let OBI_1110116 = _prefix "OBI_1110116"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110118"></see>
    /// </summary>
    let OBI_1110118 = _prefix "OBI_1110118"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110150"></see>
    /// </summary>
    let OBI_1110150 = _prefix "OBI_1110150"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_9999994"></see>
    /// </summary>
    let OBI_9999994 = _prefix "OBI_9999994"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110151"></see>
    /// </summary>
    let OBI_1110151 = _prefix "OBI_1110151"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110152"></see>
    /// </summary>
    let OBI_1110152 = _prefix "OBI_1110152"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110153"></see>
    /// </summary>
    let OBI_1110153 = _prefix "OBI_1110153"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110154"></see>
    /// </summary>
    let OBI_1110154 = _prefix "OBI_1110154"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110155"></see>
    /// </summary>
    let OBI_1110155 = _prefix "OBI_1110155"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110156"></see>
    /// </summary>
    let OBI_1110156 = _prefix "OBI_1110156"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110157"></see>
    /// </summary>
    let OBI_1110157 = _prefix "OBI_1110157"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110158"></see>
    /// </summary>
    let OBI_1110158 = _prefix "OBI_1110158"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110159"></see>
    /// </summary>
    let OBI_1110159 = _prefix "OBI_1110159"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110160"></see>
    /// </summary>
    let OBI_1110160 = _prefix "OBI_1110160"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110161"></see>
    /// </summary>
    let OBI_1110161 = _prefix "OBI_1110161"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110163"></see>
    /// </summary>
    let OBI_1110163 = _prefix "OBI_1110163"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110167"></see>
    /// </summary>
    let OBI_1110167 = _prefix "OBI_1110167"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110168"></see>
    /// </summary>
    let OBI_1110168 = _prefix "OBI_1110168"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110170"></see>
    /// </summary>
    let OBI_1110170 = _prefix "OBI_1110170"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110171"></see>
    /// </summary>
    let OBI_1110171 = _prefix "OBI_1110171"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110172"></see>
    /// </summary>
    let OBI_1110172 = _prefix "OBI_1110172"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110173"></see>
    /// </summary>
    let OBI_1110173 = _prefix "OBI_1110173"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110174"></see>
    /// </summary>
    let OBI_1110174 = _prefix "OBI_1110174"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110175"></see>
    /// </summary>
    let OBI_1110175 = _prefix "OBI_1110175"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110177"></see>
    /// </summary>
    let OBI_1110177 = _prefix "OBI_1110177"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110180"></see>
    /// </summary>
    let OBI_1110180 = _prefix "OBI_1110180"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110181"></see>
    /// </summary>
    let OBI_1110181 = _prefix "OBI_1110181"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110182"></see>
    /// </summary>
    let OBI_1110182 = _prefix "OBI_1110182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110184"></see>
    /// </summary>
    let OBI_1110184 = _prefix "OBI_1110184"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110185"></see>
    /// </summary>
    let OBI_1110185 = _prefix "OBI_1110185"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110187"></see>
    /// </summary>
    let OBI_1110187 = _prefix "OBI_1110187"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110190"></see>
    /// </summary>
    let OBI_1110190 = _prefix "OBI_1110190"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110191"></see>
    /// </summary>
    let OBI_1110191 = _prefix "OBI_1110191"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110195"></see>
    /// </summary>
    let OBI_1110195 = _prefix "OBI_1110195"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110196"></see>
    /// </summary>
    let OBI_1110196 = _prefix "OBI_1110196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110199"></see>
    /// </summary>
    let OBI_1110199 = _prefix "OBI_1110199"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110201"></see>
    /// </summary>
    let OBI_1110201 = _prefix "OBI_1110201"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110202"></see>
    /// </summary>
    let OBI_1110202 = _prefix "OBI_1110202"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110203"></see>
    /// </summary>
    let OBI_1110203 = _prefix "OBI_1110203"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110204"></see>
    /// </summary>
    let OBI_1110204 = _prefix "OBI_1110204"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110206"></see>
    /// </summary>
    let OBI_1110206 = _prefix "OBI_1110206"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110207"></see>
    /// </summary>
    let OBI_1110207 = _prefix "OBI_1110207"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1110300"></see>
    /// </summary>
    let OBI_1110300 = _prefix "OBI_1110300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_1200000"></see>
    /// </summary>
    let OBI_1200000 = _prefix "OBI_1200000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OBI_9991119"></see>
    /// </summary>
    let OBI_9991119 = _prefix "OBI_9991119"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ogms.owl"></see>
    /// </summary>
    let ``ogms.owl`` = _prefix "ogms.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OGMS_0000023"></see>
    /// </summary>
    let OGMS_0000023 = _prefix "OGMS_0000023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OGMS_0000090"></see>
    /// </summary>
    let OGMS_0000090 = _prefix "OGMS_0000090"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/OMIABIS_0000050"></see>
    /// </summary>
    let OMIABIS_0000050 = _prefix "OMIABIS_0000050"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/omiabis.owl"></see>
    /// </summary>
    let ``omiabis.owl`` = _prefix "omiabis.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/pato.owl"></see>
    /// </summary>
    let ``pato.owl`` = _prefix "pato.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000165"></see>
    /// </summary>
    let PATO_0000165 = _prefix "PATO_0000165"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001296"></see>
    /// </summary>
    let PATO_0001296 = _prefix "PATO_0001296"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000025"></see>
    /// </summary>
    let PATO_0000025 = _prefix "PATO_0000025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000141"></see>
    /// </summary>
    let PATO_0000141 = _prefix "PATO_0000141"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000033"></see>
    /// </summary>
    let PATO_0000033 = _prefix "PATO_0000033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002182"></see>
    /// </summary>
    let PATO_0002182 = _prefix "PATO_0002182"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001995"></see>
    /// </summary>
    let PATO_0001995 = _prefix "PATO_0001995"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000051"></see>
    /// </summary>
    let PATO_0000051 = _prefix "PATO_0000051"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000117"></see>
    /// </summary>
    let PATO_0000117 = _prefix "PATO_0000117"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000140"></see>
    /// </summary>
    let PATO_0000140 = _prefix "PATO_0000140"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001018"></see>
    /// </summary>
    let PATO_0001018 = _prefix "PATO_0001018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000169"></see>
    /// </summary>
    let PATO_0000169 = _prefix "PATO_0000169"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000186"></see>
    /// </summary>
    let PATO_0000186 = _prefix "PATO_0000186"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000383"></see>
    /// </summary>
    let PATO_0000383 = _prefix "PATO_0000383"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001894"></see>
    /// </summary>
    let PATO_0001894 = _prefix "PATO_0001894"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0000384"></see>
    /// </summary>
    let PATO_0000384 = _prefix "PATO_0000384"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001710"></see>
    /// </summary>
    let PATO_0001710 = _prefix "PATO_0001710"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001020"></see>
    /// </summary>
    let PATO_0001020 = _prefix "PATO_0001020"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001025"></see>
    /// </summary>
    let PATO_0001025 = _prefix "PATO_0001025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001161"></see>
    /// </summary>
    let PATO_0001161 = _prefix "PATO_0001161"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001167"></see>
    /// </summary>
    let PATO_0001167 = _prefix "PATO_0001167"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001193"></see>
    /// </summary>
    let PATO_0001193 = _prefix "PATO_0001193"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001196"></see>
    /// </summary>
    let PATO_0001196 = _prefix "PATO_0001196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001233"></see>
    /// </summary>
    let PATO_0001233 = _prefix "PATO_0001233"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001291"></see>
    /// </summary>
    let PATO_0001291 = _prefix "PATO_0001291"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001739"></see>
    /// </summary>
    let PATO_0001739 = _prefix "PATO_0001739"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001300"></see>
    /// </summary>
    let PATO_0001300 = _prefix "PATO_0001300"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001335"></see>
    /// </summary>
    let PATO_0001335 = _prefix "PATO_0001335"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001895"></see>
    /// </summary>
    let PATO_0001895 = _prefix "PATO_0001895"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001337"></see>
    /// </summary>
    let PATO_0001337 = _prefix "PATO_0001337"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001338"></see>
    /// </summary>
    let PATO_0001338 = _prefix "PATO_0001338"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002003"></see>
    /// </summary>
    let PATO_0002003 = _prefix "PATO_0002003"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001339"></see>
    /// </summary>
    let PATO_0001339 = _prefix "PATO_0001339"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001340"></see>
    /// </summary>
    let PATO_0001340 = _prefix "PATO_0001340"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001341"></see>
    /// </summary>
    let PATO_0001341 = _prefix "PATO_0001341"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001342"></see>
    /// </summary>
    let PATO_0001342 = _prefix "PATO_0001342"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001343"></see>
    /// </summary>
    let PATO_0001343 = _prefix "PATO_0001343"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001344"></see>
    /// </summary>
    let PATO_0001344 = _prefix "PATO_0001344"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001345"></see>
    /// </summary>
    let PATO_0001345 = _prefix "PATO_0001345"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001346"></see>
    /// </summary>
    let PATO_0001346 = _prefix "PATO_0001346"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001347"></see>
    /// </summary>
    let PATO_0001347 = _prefix "PATO_0001347"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001348"></see>
    /// </summary>
    let PATO_0001348 = _prefix "PATO_0001348"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001374"></see>
    /// </summary>
    let PATO_0001374 = _prefix "PATO_0001374"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001396"></see>
    /// </summary>
    let PATO_0001396 = _prefix "PATO_0001396"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001375"></see>
    /// </summary>
    let PATO_0001375 = _prefix "PATO_0001375"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001393"></see>
    /// </summary>
    let PATO_0001393 = _prefix "PATO_0001393"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001377"></see>
    /// </summary>
    let PATO_0001377 = _prefix "PATO_0001377"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001385"></see>
    /// </summary>
    let PATO_0001385 = _prefix "PATO_0001385"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001394"></see>
    /// </summary>
    let PATO_0001394 = _prefix "PATO_0001394"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001546"></see>
    /// </summary>
    let PATO_0001546 = _prefix "PATO_0001546"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002198"></see>
    /// </summary>
    let PATO_0002198 = _prefix "PATO_0002198"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001547"></see>
    /// </summary>
    let PATO_0001547 = _prefix "PATO_0001547"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001548"></see>
    /// </summary>
    let PATO_0001548 = _prefix "PATO_0001548"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001574"></see>
    /// </summary>
    let PATO_0001574 = _prefix "PATO_0001574"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001906"></see>
    /// </summary>
    let PATO_0001906 = _prefix "PATO_0001906"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001632"></see>
    /// </summary>
    let PATO_0001632 = _prefix "PATO_0001632"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001740"></see>
    /// </summary>
    let PATO_0001740 = _prefix "PATO_0001740"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001792"></see>
    /// </summary>
    let PATO_0001792 = _prefix "PATO_0001792"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0001793"></see>
    /// </summary>
    let PATO_0001793 = _prefix "PATO_0001793"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PATO_0002243"></see>
    /// </summary>
    let PATO_0002243 = _prefix "PATO_0002243"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/pr.owl"></see>
    /// </summary>
    let ``pr.owl`` = _prefix "pr.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000007928"></see>
    /// </summary>
    let PR_000007928 = _prefix "PR_000007928"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/PR_000025402"></see>
    /// </summary>
    let PR_000025402 = _prefix "PR_000025402"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/reo.owl"></see>
    /// </summary>
    let ``reo.owl`` = _prefix "reo.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000080"></see>
    /// </summary>
    let RO_0000080 = _prefix "RO_0000080"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000091"></see>
    /// </summary>
    let RO_0000091 = _prefix "RO_0000091"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0000092"></see>
    /// </summary>
    let RO_0000092 = _prefix "RO_0000092"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/ro.owl"></see>
    /// </summary>
    let ``ro.owl`` = _prefix "ro.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001001"></see>
    /// </summary>
    let RO_0001001 = _prefix "RO_0001001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001015"></see>
    /// </summary>
    let RO_0001015 = _prefix "RO_0001015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0001902"></see>
    /// </summary>
    let RO_0001902 = _prefix "RO_0001902"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002000"></see>
    /// </summary>
    let RO_0002000 = _prefix "RO_0002000"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002002"></see>
    /// </summary>
    let RO_0002002 = _prefix "RO_0002002"
    /// <summary>
    /// X immediately_precedes_Y iff: end(X) simultaneous_with start(Y)
    /// <see href="http://purl.obolibrary.org/obo/RO_0002090"></see></summary>
    let RO_0002090 = _prefix "RO_0002090"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/RO_0002350"></see>
    /// </summary>
    let RO_0002350 = _prefix "RO_0002350"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/so.owl"></see>
    /// </summary>
    let ``so.owl`` = _prefix "so.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/SO_0001410"></see>
    /// </summary>
    let SO_0001410 = _prefix "SO_0001410"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000463"></see>
    /// </summary>
    let UBERON_0000463 = _prefix "UBERON_0000463"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000481"></see>
    /// </summary>
    let UBERON_0000481 = _prefix "UBERON_0000481"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0000483"></see>
    /// </summary>
    let UBERON_0000483 = _prefix "UBERON_0000483"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001873"></see>
    /// </summary>
    let UBERON_0001873 = _prefix "UBERON_0001873"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0001874"></see>
    /// </summary>
    let UBERON_0001874 = _prefix "UBERON_0001874"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002812"></see>
    /// </summary>
    let UBERON_0002812 = _prefix "UBERON_0002812"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0002813"></see>
    /// </summary>
    let UBERON_0002813 = _prefix "UBERON_0002813"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UBERON_0005023"></see>
    /// </summary>
    let UBERON_0005023 = _prefix "UBERON_0005023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/uo.owl"></see>
    /// </summary>
    let ``uo.owl`` = _prefix "uo.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000006"></see>
    /// </summary>
    let UO_0000006 = _prefix "UO_0000006"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000008"></see>
    /// </summary>
    let UO_0000008 = _prefix "UO_0000008"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000009"></see>
    /// </summary>
    let UO_0000009 = _prefix "UO_0000009"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000010"></see>
    /// </summary>
    let UO_0000010 = _prefix "UO_0000010"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000015"></see>
    /// </summary>
    let UO_0000015 = _prefix "UO_0000015"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000016"></see>
    /// </summary>
    let UO_0000016 = _prefix "UO_0000016"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000017"></see>
    /// </summary>
    let UO_0000017 = _prefix "UO_0000017"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000018"></see>
    /// </summary>
    let UO_0000018 = _prefix "UO_0000018"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000021"></see>
    /// </summary>
    let UO_0000021 = _prefix "UO_0000021"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000022"></see>
    /// </summary>
    let UO_0000022 = _prefix "UO_0000022"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000023"></see>
    /// </summary>
    let UO_0000023 = _prefix "UO_0000023"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000024"></see>
    /// </summary>
    let UO_0000024 = _prefix "UO_0000024"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000025"></see>
    /// </summary>
    let UO_0000025 = _prefix "UO_0000025"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000032"></see>
    /// </summary>
    let UO_0000032 = _prefix "UO_0000032"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000033"></see>
    /// </summary>
    let UO_0000033 = _prefix "UO_0000033"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000034"></see>
    /// </summary>
    let UO_0000034 = _prefix "UO_0000034"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000035"></see>
    /// </summary>
    let UO_0000035 = _prefix "UO_0000035"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000036"></see>
    /// </summary>
    let UO_0000036 = _prefix "UO_0000036"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000039"></see>
    /// </summary>
    let UO_0000039 = _prefix "UO_0000039"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000041"></see>
    /// </summary>
    let UO_0000041 = _prefix "UO_0000041"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000042"></see>
    /// </summary>
    let UO_0000042 = _prefix "UO_0000042"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000062"></see>
    /// </summary>
    let UO_0000062 = _prefix "UO_0000062"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000063"></see>
    /// </summary>
    let UO_0000063 = _prefix "UO_0000063"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000064"></see>
    /// </summary>
    let UO_0000064 = _prefix "UO_0000064"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000066"></see>
    /// </summary>
    let UO_0000066 = _prefix "UO_0000066"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000097"></see>
    /// </summary>
    let UO_0000097 = _prefix "UO_0000097"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000098"></see>
    /// </summary>
    let UO_0000098 = _prefix "UO_0000098"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000099"></see>
    /// </summary>
    let UO_0000099 = _prefix "UO_0000099"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000100"></see>
    /// </summary>
    let UO_0000100 = _prefix "UO_0000100"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000101"></see>
    /// </summary>
    let UO_0000101 = _prefix "UO_0000101"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000102"></see>
    /// </summary>
    let UO_0000102 = _prefix "UO_0000102"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000103"></see>
    /// </summary>
    let UO_0000103 = _prefix "UO_0000103"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000105"></see>
    /// </summary>
    let UO_0000105 = _prefix "UO_0000105"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000109"></see>
    /// </summary>
    let UO_0000109 = _prefix "UO_0000109"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000163"></see>
    /// </summary>
    let UO_0000163 = _prefix "UO_0000163"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000164"></see>
    /// </summary>
    let UO_0000164 = _prefix "UO_0000164"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000165"></see>
    /// </summary>
    let UO_0000165 = _prefix "UO_0000165"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000175"></see>
    /// </summary>
    let UO_0000175 = _prefix "UO_0000175"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000176"></see>
    /// </summary>
    let UO_0000176 = _prefix "UO_0000176"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000195"></see>
    /// </summary>
    let UO_0000195 = _prefix "UO_0000195"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000196"></see>
    /// </summary>
    let UO_0000196 = _prefix "UO_0000196"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000207"></see>
    /// </summary>
    let UO_0000207 = _prefix "UO_0000207"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000208"></see>
    /// </summary>
    let UO_0000208 = _prefix "UO_0000208"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000212"></see>
    /// </summary>
    let UO_0000212 = _prefix "UO_0000212"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000270"></see>
    /// </summary>
    let UO_0000270 = _prefix "UO_0000270"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000271"></see>
    /// </summary>
    let UO_0000271 = _prefix "UO_0000271"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000280"></see>
    /// </summary>
    let UO_0000280 = _prefix "UO_0000280"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/UO_0000301"></see>
    /// </summary>
    let UO_0000301 = _prefix "UO_0000301"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/VO_0000001"></see>
    /// </summary>
    let VO_0000001 = _prefix "VO_0000001"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/vo.owl"></see>
    /// </summary>
    let ``vo.owl`` = _prefix "vo.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/VO_0000002"></see>
    /// </summary>
    let VO_0000002 = _prefix "VO_0000002"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/iao/d-acts.owl"></see>
    /// </summary>
    let ``iao/d-acts.owl`` = _prefix "iao/d-acts.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/iao/pno.owl"></see>
    /// </summary>
    let ``iao/pno.owl`` = _prefix "iao/pno.owl"
    /// <summary>
    ///   <see href="http://purl.obolibrary.org/obo/obi/2019-08-06/obi.owl"></see>
    /// </summary>
    let ``obi/2019-08-06/obi.owl`` = _prefix "obi/2019-08-06/obi.owl"
