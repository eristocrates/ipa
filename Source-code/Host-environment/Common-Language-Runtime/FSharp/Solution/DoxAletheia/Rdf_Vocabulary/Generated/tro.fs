namespace https.w3id.org.TRO.hash

open DoxAletheia.Rdf_Vocabulary

module tro =
    let _namespace_name = "https://w3id.org/TRO#"
    /// <summary>
    /// The evidence of a relation. Normally an evidence will be a source of news. This is not legal evidence
    /// <see href="https://w3id.org/TRO#Evidence"></see></summary>
    let Evidence = Namespaced_IRI.parse _namespace_name "Evidence" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/TRO#url"></see>
    /// </summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/TRO#cpv_code"></see>
    /// </summary>
    let cpv_code = Namespaced_IRI.parse _namespace_name "cpv_code" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/TRO#end_date"></see>
    /// </summary>
    let end_date = Namespaced_IRI.parse _namespace_name "end_date" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/TRO#start_date"></see>
    /// </summary>
    let start_date = Namespaced_IRI.parse _namespace_name "start_date" |> NamespacedName
    /// <summary>
    /// The role of a person in a en entity during a given time period, provided in months or years
    /// <see href="https://w3id.org/TRO#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/TRO#has_role"></see>
    /// </summary>
    let has_role = Namespaced_IRI.parse _namespace_name "has_role" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#profile_url"></see>
    /// </summary>
    let profile_url =
        Namespaced_IRI.parse _namespace_name "profile_url" |> NamespacedName

    /// <summary>
    /// A person who is connected to another organization in a relationship that is less close or committed than a partnership
    /// <see href="https://w3id.org/TRO#Associate"></see></summary>
    let Associate = Namespaced_IRI.parse _namespace_name "Associate" |> NamespacedName
    /// <summary>
    /// The director of an organization
    /// <see href="https://w3id.org/TRO#Director"></see></summary>
    let Director = Namespaced_IRI.parse _namespace_name "Director" |> NamespacedName
    /// <summary>
    /// A person hired by an organization
    /// <see href="https://w3id.org/TRO#Employee"></see></summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName
    /// <summary>
    /// A person within an organization who is responsible for planning, coordinating, and overseeing various activities and resources to achieve specific goals and objectives
    /// <see href="https://w3id.org/TRO#Manager"></see></summary>
    let Manager = Namespaced_IRI.parse _namespace_name "Manager" |> NamespacedName
    /// <summary>
    /// A person is a member of an organization
    /// <see href="https://w3id.org/TRO#Member"></see></summary>
    let Member = Namespaced_IRI.parse _namespace_name "Member" |> NamespacedName

    /// <summary>
    /// In some administrations minor contracts do not have to be justified
    /// <see href="https://w3id.org/TRO#Minor_contract"></see></summary>
    let Minor_contract =
        Namespaced_IRI.parse _namespace_name "Minor_contract" |> NamespacedName

    /// <summary>
    /// An officer usually belongs to a publica organization
    /// <see href="https://w3id.org/TRO#Officer"></see></summary>
    let Officer = Namespaced_IRI.parse _namespace_name "Officer" |> NamespacedName
    /// <summary>
    /// Data available at an Open Data portal, usually developed by a public administration
    /// <see href="https://w3id.org/TRO#OpenData"></see></summary>
    let OpenData = Namespaced_IRI.parse _namespace_name "OpenData" |> NamespacedName
    /// <summary>
    /// The owner of a company
    /// <see href="https://w3id.org/TRO#Owner"></see></summary>
    let Owner = Namespaced_IRI.parse _namespace_name "Owner" |> NamespacedName
    /// <summary>
    /// The president of an organization
    /// <see href="https://w3id.org/TRO#President"></see></summary>
    let President = Namespaced_IRI.parse _namespace_name "President" |> NamespacedName

    /// <summary>
    /// A public profile in the web (e.g. LinkedIn)
    /// <see href="https://w3id.org/TRO#PublicProfile"></see></summary>
    let PublicProfile =
        Namespaced_IRI.parse _namespace_name "PublicProfile" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#in_entity"></see>
    /// </summary>
    let in_entity = Namespaced_IRI.parse _namespace_name "in_entity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#has_bank_account_in"></see>
    /// </summary>
    let has_bank_account_in =
        Namespaced_IRI.parse _namespace_name "has_bank_account_in" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#pays_to"></see>
    /// </summary>
    let pays_to = Namespaced_IRI.parse _namespace_name "pays_to" |> NamespacedName

    /// <summary>
    /// A company or and individual provides services or products to an institution
    /// <see href="https://w3id.org/TRO#provider_of"></see></summary>
    let provider_of =
        Namespaced_IRI.parse _namespace_name "provider_of" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#registered_in"></see>
    /// </summary>
    let registered_in =
        Namespaced_IRI.parse _namespace_name "registered_in" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#represents"></see>
    /// </summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/TRO#sibling"></see>
    /// </summary>
    let sibling = Namespaced_IRI.parse _namespace_name "sibling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#takes_place_in"></see>
    /// </summary>
    let takes_place_in =
        Namespaced_IRI.parse _namespace_name "takes_place_in" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/TRO#with_evidence"></see>
    /// </summary>
    let with_evidence =
        Namespaced_IRI.parse _namespace_name "with_evidence" |> NamespacedName
