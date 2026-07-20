namespace https.w3id.org.TRO.hash

open DoxAletheia

module tro =
    let _namespace_name = "https://w3id.org/TRO#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The evidence of a relation. Normally an evidence will be a source of news. This is not legal evidence
    /// <see href="https://w3id.org/TRO#Evidence"></see></summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#url"></see>
    /// </summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#cpv_code"></see>
    /// </summary>
    let cpv_code = _prefix "cpv_code"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#end_date"></see>
    /// </summary>
    let end_date = _prefix "end_date"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#start_date"></see>
    /// </summary>
    let start_date = _prefix "start_date"
    /// <summary>
    /// The role of a person in a en entity during a given time period, provided in months or years
    /// <see href="https://w3id.org/TRO#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#has_role"></see>
    /// </summary>
    let has_role = _prefix "has_role"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#profile_url"></see>
    /// </summary>
    let profile_url = _prefix "profile_url"
    /// <summary>
    /// A person who is connected to another organization in a relationship that is less close or committed than a partnership
    /// <see href="https://w3id.org/TRO#Associate"></see></summary>
    let Associate = _prefix "Associate"
    /// <summary>
    /// The director of an organization
    /// <see href="https://w3id.org/TRO#Director"></see></summary>
    let Director = _prefix "Director"
    /// <summary>
    /// A person hired by an organization
    /// <see href="https://w3id.org/TRO#Employee"></see></summary>
    let Employee = _prefix "Employee"
    /// <summary>
    /// A person within an organization who is responsible for planning, coordinating, and overseeing various activities and resources to achieve specific goals and objectives
    /// <see href="https://w3id.org/TRO#Manager"></see></summary>
    let Manager = _prefix "Manager"
    /// <summary>
    /// A person is a member of an organization
    /// <see href="https://w3id.org/TRO#Member"></see></summary>
    let Member = _prefix "Member"
    /// <summary>
    /// In some administrations minor contracts do not have to be justified
    /// <see href="https://w3id.org/TRO#Minor_contract"></see></summary>
    let Minor_contract = _prefix "Minor_contract"
    /// <summary>
    /// An officer usually belongs to a publica organization
    /// <see href="https://w3id.org/TRO#Officer"></see></summary>
    let Officer = _prefix "Officer"
    /// <summary>
    /// Data available at an Open Data portal, usually developed by a public administration
    /// <see href="https://w3id.org/TRO#OpenData"></see></summary>
    let OpenData = _prefix "OpenData"
    /// <summary>
    /// The owner of a company
    /// <see href="https://w3id.org/TRO#Owner"></see></summary>
    let Owner = _prefix "Owner"
    /// <summary>
    /// The president of an organization
    /// <see href="https://w3id.org/TRO#President"></see></summary>
    let President = _prefix "President"
    /// <summary>
    /// A public profile in the web (e.g. LinkedIn)
    /// <see href="https://w3id.org/TRO#PublicProfile"></see></summary>
    let PublicProfile = _prefix "PublicProfile"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#in_entity"></see>
    /// </summary>
    let in_entity = _prefix "in_entity"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#has_bank_account_in"></see>
    /// </summary>
    let has_bank_account_in = _prefix "has_bank_account_in"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#pays_to"></see>
    /// </summary>
    let pays_to = _prefix "pays_to"
    /// <summary>
    /// A company or and individual provides services or products to an institution
    /// <see href="https://w3id.org/TRO#provider_of"></see></summary>
    let provider_of = _prefix "provider_of"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#registered_in"></see>
    /// </summary>
    let registered_in = _prefix "registered_in"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#represents"></see>
    /// </summary>
    let represents = _prefix "represents"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#sibling"></see>
    /// </summary>
    let sibling = _prefix "sibling"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#takes_place_in"></see>
    /// </summary>
    let takes_place_in = _prefix "takes_place_in"
    /// <summary>
    ///   <see href="https://w3id.org/TRO#with_evidence"></see>
    /// </summary>
    let with_evidence = _prefix "with_evidence"
