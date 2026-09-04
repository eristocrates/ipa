#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tro =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/TRO#" "tro"
    /// <summary>
    ///   <para>dce:date : 2023-03-08T21:12:46Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Associate</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A person who is connected to another organization in a relationship that is less close or committed than a partnership</para>
    ///   <a href="https://w3id.org/TRO#Associate">tro:Associate</a>
    /// </summary>
    let Associate = _prefixId.prefix "Associate"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T08:50:19Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Director</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The director of an organization</para>
    ///   <a href="https://w3id.org/TRO#Director">tro:Director</a>
    /// </summary>
    let Director = _prefixId.prefix "Director"
    /// <summary>
    ///   <para>dce:date : 2023-03-08T21:13:05Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Employee</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A person hired by an organization</para>
    ///   <a href="https://w3id.org/TRO#Employee">tro:Employee</a>
    /// </summary>
    let Employee = _prefixId.prefix "Employee"
    /// <summary>
    ///   <para>dce:date : 2022-02-15T11:19:58Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Evidence</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The evidence of a relation. Normally an evidence will be a source of news. This is not legal evidence</para>
    ///   <a href="https://w3id.org/TRO#Evidence">tro:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T10:33:21Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Manager</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A person within an organization who is responsible for planning, coordinating, and overseeing various activities and resources to achieve specific goals and objectives</para>
    ///   <a href="https://w3id.org/TRO#Manager">tro:Manager</a>
    /// </summary>
    let Manager = _prefixId.prefix "Manager"
    /// <summary>
    ///   <para>dce:date : 2023-03-27T15:32:50Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Member</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A person is a member of an organization</para>
    ///   <a href="https://w3id.org/TRO#Member">tro:Member</a>
    /// </summary>
    let Member = _prefixId.prefix "Member"
    /// <summary>
    ///   <para>rdfs:label : Contrato menorrdfs:label : Minor contractrdfs:label : Kontratu txikia</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>dce:date : 2023-05-19T08:10:50Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : In some administrations minor contracts do not have to be justified</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:seeAlso : http://contsem.unizar.es/def/sector-publico/pproc#Minor^^xsd:stringrdfs:seeAlso : https://www.boe.es/boe/dias/2019/03/07/pdfs/BOE-A-2019-3281.pdf^^xsd:string</para>
    ///   <a href="https://w3id.org/TRO#Minor_contract">tro:Minor_contract</a>
    /// </summary>
    let Minor_contract = _prefixId.prefix "Minor_contract"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T08:51:05Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Officer</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An officer usually belongs to a publica organization</para>
    ///   <a href="https://w3id.org/TRO#Officer">tro:Officer</a>
    /// </summary>
    let Officer = _prefixId.prefix "Officer"
    /// <summary>
    ///   <para>dce:date : 2023-03-27T15:36:32Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Open data</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Data available at an Open Data portal, usually developed by a public administration</para>
    ///   <a href="https://w3id.org/TRO#OpenData">tro:OpenData</a>
    /// </summary>
    let OpenData = _prefixId.prefix "OpenData"
    /// <summary>
    ///   <para>dce:date : 2023-03-08T21:12:53Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Owner</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The owner of a company</para>
    ///   <a href="https://w3id.org/TRO#Owner">tro:Owner</a>
    /// </summary>
    let Owner = _prefixId.prefix "Owner"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T08:50:34Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : President</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The president of an organization</para>
    ///   <a href="https://w3id.org/TRO#President">tro:President</a>
    /// </summary>
    let President = _prefixId.prefix "President"
    /// <summary>
    ///   <para>dce:date : 2023-03-10T19:19:00Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Public Profile</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A public profile in the web (e.g. LinkedIn)</para>
    ///   <a href="https://w3id.org/TRO#PublicProfile">tro:PublicProfile</a>
    /// </summary>
    let PublicProfile = _prefixId.prefix "PublicProfile"
    /// <summary>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Role</para>
    ///   <para>dce:date : 2023-03-08T21:06:06Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : The role of a person in a en entity during a given time period, provided in months or years</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/TRO^^xsd:anyURI</para>
    ///   <a href="https://w3id.org/TRO#Role">tro:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>dce:date : 2023-05-19T07:51:57Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://single-market-economy.ec.europa.eu/single-market/public-procurement/digital-procurement/common-procurement-vocabulary_en^^xsd:string</para>
    ///   <para>rdfs:label : CPV code</para>
    ///   <a href="https://w3id.org/TRO#cpv_code">tro:cpv_code</a>
    /// </summary>
    let cpv_code = _prefixId.prefix "cpv_code"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T09:02:35Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : End date</para>
    ///   <a href="https://w3id.org/TRO#end_date">tro:end_date</a>
    /// </summary>
    let end_date = _prefixId.prefix "end_date"
    /// <summary>
    ///   <para>dce:date : 2022-02-21T14:25:46Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>dce:contributor : Jaime Gómez-Obregón (https://ladonacion.es/)</para>
    ///   <para>rdfs:label : Has bank account in</para>
    ///   <a href="https://w3id.org/TRO#has_bank_account_in">tro:has_bank_account_in</a>
    /// </summary>
    let has_bank_account_in = _prefixId.prefix "has_bank_account_in"
    /// <summary>
    ///   <para>dce:date : 2023-03-08T21:10:19Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Has role</para>
    ///   <a href="https://w3id.org/TRO#has_role">tro:has_role</a>
    /// </summary>
    let has_role = _prefixId.prefix "has_role"
    /// <summary>
    ///   <para>dce:date : 2023-03-08T21:13:36Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : In entity</para>
    ///   <a href="https://w3id.org/TRO#in_entity">tro:in_entity</a>
    /// </summary>
    let in_entity = _prefixId.prefix "in_entity"
    /// <summary>
    ///   <para>dce:date : 2022-02-21T14:24:12Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>dce:contributor : Jaime Gómez-Obregón (https://ladonacion.es/)</para>
    ///   <para>rdfs:label : Pays to</para>
    ///   <a href="https://w3id.org/TRO#pays_to">tro:pays_to</a>
    /// </summary>
    let pays_to = _prefixId.prefix "pays_to"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T09:04:41Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Profile URL</para>
    ///   <a href="https://w3id.org/TRO#profile_url">tro:profile_url</a>
    /// </summary>
    let profile_url = _prefixId.prefix "profile_url"
    /// <summary>
    ///   <para>dce:date : 2022-02-15T11:23:05Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Provider of</para>
    ///   <para>rdfs:comment : A company or and individual provides services or products to an institution</para>
    ///   <a href="https://w3id.org/TRO#provider_of">tro:provider_of</a>
    /// </summary>
    let provider_of = _prefixId.prefix "provider_of"
    /// <summary>
    ///   <para>dce:date : 2022-02-21T14:30:10Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>dce:contributor : Jaime Gómez-Obregón (https://ladonacion.es/)</para>
    ///   <para>rdfs:label : Registered in</para>
    ///   <a href="https://w3id.org/TRO#registered_in">tro:registered_in</a>
    /// </summary>
    let registered_in = _prefixId.prefix "registered_in"
    /// <summary>
    ///   <para>dce:date : 2022-02-21T14:21:32Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>dce:contributor : Jaime Gómez-Obregón (https://ladonacion.es/)</para>
    ///   <para>rdfs:label : Represents</para>
    ///   <a href="https://w3id.org/TRO#represents">tro:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>dce:date : 2023-03-27T15:34:21Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Sibling</para>
    ///   <a href="https://w3id.org/TRO#sibling">tro:sibling</a>
    /// </summary>
    let sibling = _prefixId.prefix "sibling"
    /// <summary>
    ///   <para>dce:date : 2023-03-09T09:02:16Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Start date</para>
    ///   <a href="https://w3id.org/TRO#start_date">tro:start_date</a>
    /// </summary>
    let start_date = _prefixId.prefix "start_date"
    /// <summary>
    ///   <para>dce:date : 2022-02-21T14:35:58Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : Takes place in</para>
    ///   <a href="https://w3id.org/TRO#takes_place_in">tro:takes_place_in</a>
    /// </summary>
    let takes_place_in = _prefixId.prefix "takes_place_in"
    /// <summary>
    ///   <para>dce:date : 2023-03-10T19:19:41Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : URL</para>
    ///   <a href="https://w3id.org/TRO#url">tro:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>dce:date : 2023-03-08T21:27:00Z^^xsd:dateTime</para>
    ///   <para>dce:creator : Mikel Egaña Aranguren (https://orcid.org/0000-0001-8081-1839)^^xsd:string</para>
    ///   <para>rdfs:label : With evidence</para>
    ///   <a href="https://w3id.org/TRO#with_evidence">tro:with_evidence</a>
    /// </summary>
    let with_evidence = _prefixId.prefix "with_evidence"
