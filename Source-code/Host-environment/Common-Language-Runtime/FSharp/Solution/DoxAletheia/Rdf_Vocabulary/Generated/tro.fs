namespace https.w3id.org.TRO.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tro =
    let _namespace_iri = Namespace_Iri tro |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:TRO#Associate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is connected to another organization in a relationship that is less close or committed than a partnership"</para>
    /// labels<para>"Associate"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Associate">https://w3id.org/TRO#Associate</seealso>
    let Associate = Prefixed_Name(tro, "Associate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Director</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The director of an organization"</para>
    /// labels<para>"Director"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Director">https://w3id.org/TRO#Director</seealso>
    let Director = Prefixed_Name(tro, "Director") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person hired by an organization"</para>
    /// labels<para>"Employee"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Employee">https://w3id.org/TRO#Employee</seealso>
    let Employee = Prefixed_Name(tro, "Employee") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The evidence of a relation. Normally an evidence will be a source of news. This is not legal evidence"</para>
    /// labels<para>"Evidence"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Evidence">https://w3id.org/TRO#Evidence</seealso>
    let Evidence = Prefixed_Name(tro, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person within an organization who is responsible for planning, coordinating, and overseeing various activities and resources to achieve specific goals and objectives"</para>
    /// labels<para>"Manager"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Manager">https://w3id.org/TRO#Manager</seealso>
    let Manager = Prefixed_Name(tro, "Manager") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person is a member of an organization"</para>
    /// labels<para>"Member"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Member">https://w3id.org/TRO#Member</seealso>
    let Member = Prefixed_Name(tro, "Member") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Minor_contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In some administrations minor contracts do not have to be justified"</para>
    /// labels<para>"Contrato menor"</para><para>"Minor contract"</para><para>"Kontratu txikia"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Minor_contract">https://w3id.org/TRO#Minor_contract</seealso>
    let Minor_contract = Prefixed_Name(tro, "Minor_contract") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An officer usually belongs to a publica organization"</para>
    /// labels<para>"Officer"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Officer">https://w3id.org/TRO#Officer</seealso>
    let Officer = Prefixed_Name(tro, "Officer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#OpenData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data available at an Open Data portal, usually developed by a public administration"</para>
    /// labels<para>"Open data"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#OpenData">https://w3id.org/TRO#OpenData</seealso>
    let OpenData = Prefixed_Name(tro, "OpenData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The owner of a company"</para>
    /// labels<para>"Owner"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Owner">https://w3id.org/TRO#Owner</seealso>
    let Owner = Prefixed_Name(tro, "Owner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#President</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The president of an organization"</para>
    /// labels<para>"President"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#President">https://w3id.org/TRO#President</seealso>
    let President = Prefixed_Name(tro, "President") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#PublicProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A public profile in the web (e.g. LinkedIn)"</para>
    /// labels<para>"Public Profile"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#PublicProfile">https://w3id.org/TRO#PublicProfile</seealso>
    let PublicProfile = Prefixed_Name(tro, "PublicProfile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The role of a person in a en entity during a given time period, provided in months or years"</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#Role">https://w3id.org/TRO#Role</seealso>
    let Role = Prefixed_Name(tro, "Role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#cpv_code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"CPV code"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#cpv_code">https://w3id.org/TRO#cpv_code</seealso>
    let cpv_code = Prefixed_Name(tro, "cpv_code") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#end_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"End date"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#end_date">https://w3id.org/TRO#end_date</seealso>
    let end_date = Prefixed_Name(tro, "end_date") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#has_bank_account_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has bank account in"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#has_bank_account_in">https://w3id.org/TRO#has_bank_account_in</seealso>
    let has_bank_account_in = Prefixed_Name(tro, "has_bank_account_in") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#has_role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has role"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#has_role">https://w3id.org/TRO#has_role</seealso>
    let has_role = Prefixed_Name(tro, "has_role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#in_entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"In entity"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#in_entity">https://w3id.org/TRO#in_entity</seealso>
    let in_entity = Prefixed_Name(tro, "in_entity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#pays_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Pays to"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#pays_to">https://w3id.org/TRO#pays_to</seealso>
    let pays_to = Prefixed_Name(tro, "pays_to") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#profile_url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Profile URL"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#profile_url">https://w3id.org/TRO#profile_url</seealso>
    let profile_url = Prefixed_Name(tro, "profile_url") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#provider_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A company or and individual provides services or products to an institution"</para>
    /// labels<para>"Provider of"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#provider_of">https://w3id.org/TRO#provider_of</seealso>
    let provider_of = Prefixed_Name(tro, "provider_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#registered_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Registered in"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#registered_in">https://w3id.org/TRO#registered_in</seealso>
    let registered_in = Prefixed_Name(tro, "registered_in") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Represents"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#represents">https://w3id.org/TRO#represents</seealso>
    let represents = Prefixed_Name(tro, "represents") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#sibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Sibling"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#sibling">https://w3id.org/TRO#sibling</seealso>
    let sibling = Prefixed_Name(tro, "sibling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#start_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Start date"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#start_date">https://w3id.org/TRO#start_date</seealso>
    let start_date = Prefixed_Name(tro, "start_date") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#takes_place_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Takes place in"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#takes_place_in">https://w3id.org/TRO#takes_place_in</seealso>
    let takes_place_in = Prefixed_Name(tro, "takes_place_in") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"URL"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#url">https://w3id.org/TRO#url</seealso>
    let url = Prefixed_Name(tro, "url") |> PrefixedName
    /// <summary>
    ///   <para>w3id:TRO#with_evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"With evidence"</para></remarks>
    /// <seealso href="https://w3id.org/TRO#with_evidence">https://w3id.org/TRO#with_evidence</seealso>
    let with_evidence = Prefixed_Name(tro, "with_evidence") |> PrefixedName
