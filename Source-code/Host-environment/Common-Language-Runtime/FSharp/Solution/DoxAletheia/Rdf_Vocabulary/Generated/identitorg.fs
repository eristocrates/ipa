namespace http.www.identity.org.ontologies.identity.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module identitorg =
    let _namespace_iri = Namespace_Iri identitorg |> NamespaceIRI
    /// <summary>
    ///   <para>identitorg:ymdDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ymdDay</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ymdDay">http://www.identity.org/ontologies/identity.owl#ymdDay</seealso>
    let ymdDay = Prefixed_Name(identitorg, "ymdDay") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:IrisRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>IrisRecognition</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#IrisRecognition">http://www.identity.org/ontologies/identity.owl#IrisRecognition</seealso>
    let IrisRecognition = Prefixed_Name(identitorg, "IrisRecognition") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:VoiceRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>VoiceRecognition</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#VoiceRecognition">http://www.identity.org/ontologies/identity.owl#VoiceRecognition</seealso>
    let VoiceRecognition = Prefixed_Name(identitorg, "VoiceRecognition") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ymdMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ymdMonth</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ymdMonth">http://www.identity.org/ontologies/identity.owl#ymdMonth</seealso>
    let ymdMonth = Prefixed_Name(identitorg, "ymdMonth") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:TelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The characteristics of a telephone number.</para>
    /// labels<para>TelephoneNumber</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#TelephoneNumber">http://www.identity.org/ontologies/identity.owl#TelephoneNumber</seealso>
    let TelephoneNumber = Prefixed_Name(identitorg, "TelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasTelephoneNumber</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasTelephoneNumber">http://www.identity.org/ontologies/identity.owl#hasTelephoneNumber</seealso>
    let hasTelephoneNumber =
        Prefixed_Name(identitorg, "hasTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:DateYmd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date: Year/Month/Day</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#DateYmd">http://www.identity.org/ontologies/identity.owl#DateYmd</seealso>
    let DateYmd = Prefixed_Name(identitorg, "DateYmd") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:CallLogProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#CallLogProvider">http://www.identity.org/ontologies/identity.owl#CallLogProvider</seealso>
    let CallLogProvider = Prefixed_Name(identitorg, "CallLogProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:MediaStoreProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#MediaStoreProvider">http://www.identity.org/ontologies/identity.owl#MediaStoreProvider</seealso>
    let MediaStoreProvider =
        Prefixed_Name(identitorg, "MediaStoreProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:SettingsProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#SettingsProvider">http://www.identity.org/ontologies/identity.owl#SettingsProvider</seealso>
    let SettingsProvider = Prefixed_Name(identitorg, "SettingsProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:UserDictionaryProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#UserDictionaryProvider">http://www.identity.org/ontologies/identity.owl#UserDictionaryProvider</seealso>
    let UserDictionaryProvider =
        Prefixed_Name(identitorg, "UserDictionaryProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:middleName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>middleName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#middleName">http://www.identity.org/ontologies/identity.owl#middleName</seealso>
    let middleName = Prefixed_Name(identitorg, "middleName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Online</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Online information about an agent.</para>
    ///   <para>Les adresses électroniques pour contacter un agent.</para>
    /// labels<para>Online</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Online">http://www.identity.org/ontologies/identity.owl#Online</seealso>
    let Online = Prefixed_Name(identitorg, "Online") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Pager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pager</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Pager">http://www.identity.org/ontologies/identity.owl#Pager</seealso>
    let Pager = Prefixed_Name(identitorg, "Pager") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Postal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Postal mailing address.</para>
    /// labels<para>Postal</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Postal">http://www.identity.org/ontologies/identity.owl#Postal</seealso>
    let Postal = Prefixed_Name(identitorg, "Postal") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:FingerprintRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FingerprintRecognition</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#FingerprintRecognition">http://www.identity.org/ontologies/identity.owl#FingerprintRecognition</seealso>
    let FingerprintRecognition =
        Prefixed_Name(identitorg, "FingerprintRecognition") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:ContactsContractProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ContactsContractProvider">http://www.identity.org/ontologies/identity.owl#ContactsContractProvider</seealso>
    let ContactsContractProvider =
        Prefixed_Name(identitorg, "ContactsContractProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:SyncStateContractProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#SyncStateContractProvider">http://www.identity.org/ontologies/identity.owl#SyncStateContractProvider</seealso>
    let SyncStateContractProvider =
        Prefixed_Name(identitorg, "SyncStateContractProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:city</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>city</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#city">http://www.identity.org/ontologies/identity.owl#city</seealso>
    let city = Prefixed_Name(identitorg, "city") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:KeystokeDynamicRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>KeystokeDynamicRecognition</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#KeystokeDynamicRecognition">http://www.identity.org/ontologies/identity.owl#KeystokeDynamicRecognition</seealso>
    let KeystokeDynamicRecognition =
        Prefixed_Name(identitorg, "KeystokeDynamicRecognition") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:DateHms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date: Hour/Minute/Second</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#DateHms">http://www.identity.org/ontologies/identity.owl#DateHms</seealso>
    let DateHms = Prefixed_Name(identitorg, "DateHms") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasCreator</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasCreator">http://www.identity.org/ontologies/identity.owl#hasCreator</seealso>
    let hasCreator = Prefixed_Name(identitorg, "hasCreator") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasHistoricTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasHistoricTarget</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasHistoricTarget">http://www.identity.org/ontologies/identity.owl#hasHistoricTarget</seealso>
    let hasHistoricTarget =
        Prefixed_Name(identitorg, "hasHistoricTarget") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasTarget</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasTarget">http://www.identity.org/ontologies/identity.owl#hasTarget</seealso>
    let hasTarget = Prefixed_Name(identitorg, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:telephoneNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>telephoneNum</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#telephoneNum">http://www.identity.org/ontologies/identity.owl#telephoneNum</seealso>
    let telephoneNum = Prefixed_Name(identitorg, "telephoneNum") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:liberal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>identitorg:Mode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>liberal</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#liberal">http://www.identity.org/ontologies/identity.owl#liberal</seealso>
    let liberal = Prefixed_Name(identitorg, "liberal") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:metaPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>identitorg:Policy</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>metaPolicy</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#metaPolicy">http://www.identity.org/ontologies/identity.owl#metaPolicy</seealso>
    let metaPolicy = Prefixed_Name(identitorg, "metaPolicy") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:permits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>permits</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#permits">http://www.identity.org/ontologies/identity.owl#permits</seealso>
    let permits = Prefixed_Name(identitorg, "permits") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The date structure specifies a date. Date information can be used in different ways, depending on the context.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Date">http://www.identity.org/ontologies/identity.owl#Date</seealso>
    let Date = Prefixed_Name(identitorg, "Date") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hmsSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hmsSecond</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hmsSecond">http://www.identity.org/ontologies/identity.owl#hmsSecond</seealso>
    let hmsSecond = Prefixed_Name(identitorg, "hmsSecond") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ymdMonthYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ymdMonthYear</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ymdMonthYear">http://www.identity.org/ontologies/identity.owl#ymdMonthYear</seealso>
    let ymdMonthYear = Prefixed_Name(identitorg, "ymdMonthYear") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ymdYearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ymdYearMonth</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ymdYearMonth">http://www.identity.org/ontologies/identity.owl#ymdYearMonth</seealso>
    let ymdYearMonth = Prefixed_Name(identitorg, "ymdYearMonth") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasName">http://www.identity.org/ontologies/identity.owl#hasName</seealso>
    let hasName = Prefixed_Name(identitorg, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasBirthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>User's Birthday</para>
    ///   <para>Demographic and Socieconomic Data</para>
    /// labels<para>hasBirthDate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasBirthDate">http://www.identity.org/ontologies/identity.owl#hasBirthDate</seealso>
    let hasBirthDate = Prefixed_Name(identitorg, "hasBirthDate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>employer</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#employer">http://www.identity.org/ontologies/identity.owl#employer</seealso>
    let employer = Prefixed_Name(identitorg, "employer") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:isIssuerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isIssuerOf</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#isIssuerOf">http://www.identity.org/ontologies/identity.owl#isIssuerOf</seealso>
    let isIssuerOf = Prefixed_Name(identitorg, "isIssuerOf") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:wifi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Les données de connexion Wifi.</para>
    /// labels<para>wifi</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#wifi">http://www.identity.org/ontologies/identity.owl#wifi</seealso>
    let wifi = Prefixed_Name(identitorg, "wifi") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>latitude</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#latitude">http://www.identity.org/ontologies/identity.owl#latitude</seealso>
    let latitude = Prefixed_Name(identitorg, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ymdYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ymdYear</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ymdYear">http://www.identity.org/ontologies/identity.owl#ymdYear</seealso>
    let ymdYear = Prefixed_Name(identitorg, "ymdYear") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:BrowserProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#BrowserProvider">http://www.identity.org/ontologies/identity.owl#BrowserProvider</seealso>
    let BrowserProvider = Prefixed_Name(identitorg, "BrowserProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:LiveFoldersProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#LiveFoldersProvider">http://www.identity.org/ontologies/identity.owl#LiveFoldersProvider</seealso>
    let LiveFoldersProvider =
        Prefixed_Name(identitorg, "LiveFoldersProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hmsHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hmsHour</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hmsHour">http://www.identity.org/ontologies/identity.owl#hmsHour</seealso>
    let hmsHour = Prefixed_Name(identitorg, "hmsHour") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hmsMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hmsMinute</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hmsMinute">http://www.identity.org/ontologies/identity.owl#hmsMinute</seealso>
    let hmsMinute = Prefixed_Name(identitorg, "hmsMinute") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>longitude</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#longitude">http://www.identity.org/ontologies/identity.owl#longitude</seealso>
    let longitude = Prefixed_Name(identitorg, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>uri</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#uri">http://www.identity.org/ontologies/identity.owl#uri</seealso>
    let uri = Prefixed_Name(identitorg, "uri") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Login ID</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#id">http://www.identity.org/ontologies/identity.owl#id</seealso>
    let id = Prefixed_Name(identitorg, "id") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>video</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#video">http://www.identity.org/ontologies/identity.owl#video</seealso>
    let video = Prefixed_Name(identitorg, "video") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>document</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#document">http://www.identity.org/ontologies/identity.owl#document</seealso>
    let document = Prefixed_Name(identitorg, "document") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:AlarmClockProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#AlarmClockProvider">http://www.identity.org/ontologies/identity.owl#AlarmClockProvider</seealso>
    let AlarmClockProvider =
        Prefixed_Name(identitorg, "AlarmClockProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:SearchRecentSuggestionsProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#SearchRecentSuggestionsProvider">http://www.identity.org/ontologies/identity.owl#SearchRecentSuggestionsProvider</seealso>
    let SearchRecentSuggestionsProvider =
        Prefixed_Name(identitorg, "SearchRecentSuggestionsProvider") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Action">http://www.identity.org/ontologies/identity.owl#Action</seealso>
    let Action = Prefixed_Name(identitorg, "Action") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Agent">http://www.identity.org/ontologies/identity.owl#Agent</seealso>
    let Agent = Prefixed_Name(identitorg, "Agent") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:IdentityInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Les informations relatives à une identité numérique d'une personne physique ou morale.</para>
    ///   <para>Identity information of a legal or natural entity.</para>
    /// labels<para>IdentityInformation</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#IdentityInformation">http://www.identity.org/ontologies/identity.owl#IdentityInformation</seealso>
    let IdentityInformation =
        Prefixed_Name(identitorg, "IdentityInformation") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasIdentity</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasIdentity">http://www.identity.org/ontologies/identity.owl#hasIdentity</seealso>
    let hasIdentity = Prefixed_Name(identitorg, "hasIdentity") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ContentProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ContentProvider">http://www.identity.org/ontologies/identity.owl#ContentProvider</seealso>
    let ContentProvider = Prefixed_Name(identitorg, "ContentProvider") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:BiometricData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>BiometricData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#BiometricData">http://www.identity.org/ontologies/identity.owl#BiometricData</seealso>
    let BiometricData = Prefixed_Name(identitorg, "BiometricData") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:BusinessInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identité associée uniquement à une personne morale.</para>
    /// labels<para>BusinessInformation</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#BusinessInformation">http://www.identity.org/ontologies/identity.owl#BusinessInformation</seealso>
    let BusinessInformation =
        Prefixed_Name(identitorg, "BusinessInformation") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:postalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>postalAddress</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#postalAddress">http://www.identity.org/ontologies/identity.owl#postalAddress</seealso>
    let postalAddress = Prefixed_Name(identitorg, "postalAddress") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:conservative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>identitorg:Mode</para>
    ///
    /// labels<para>conservative</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#conservative">http://www.identity.org/ontologies/identity.owl#conservative</seealso>
    let conservative = Prefixed_Name(identitorg, "conservative") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:extendedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>extendedAddress</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#extendedAddress">http://www.identity.org/ontologies/identity.owl#extendedAddress</seealso>
    let extendedAddress = Prefixed_Name(identitorg, "extendedAddress") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:indivName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>indivName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#indivName">http://www.identity.org/ontologies/identity.owl#indivName</seealso>
    let indivName = Prefixed_Name(identitorg, "indivName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:forbids</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>forbids</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#forbids">http://www.identity.org/ontologies/identity.owl#forbids</seealso>
    let forbids = Prefixed_Name(identitorg, "forbids") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Data">http://www.identity.org/ontologies/identity.owl#Data</seealso>
    let Data = Prefixed_Name(identitorg, "Data") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Business</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un business est une entité morale comme une organisation, une entreprise, une association ou une agence...</para>
    ///   <para>A business is a legal entity which is permitted to enter into a contract with another entity.</para>
    /// labels<para>Business</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Business">http://www.identity.org/ontologies/identity.owl#Business</seealso>
    let Business = Prefixed_Name(identitorg, "Business") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasData">http://www.identity.org/ontologies/identity.owl#hasData</seealso>
    let hasData = Prefixed_Name(identitorg, "hasData") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:bimetricFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>bimetricFile</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#bimetricFile">http://www.identity.org/ontologies/identity.owl#bimetricFile</seealso>
    let bimetricFile = Prefixed_Name(identitorg, "bimetricFile") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:ContactInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Les informations nécessaires pour contacter un agent.</para>
    ///   <para>Required information to contact an agent.</para>
    /// labels<para>ContactInformation</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ContactInformation">http://www.identity.org/ontologies/identity.owl#ContactInformation</seealso>
    let ContactInformation =
        Prefixed_Name(identitorg, "ContactInformation") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:businessUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Department or Division of Organization and eventually where user is employed.</para>
    /// labels<para>businessUnit</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#businessUnit">http://www.identity.org/ontologies/identity.owl#businessUnit</seealso>
    let businessUnit = Prefixed_Name(identitorg, "businessUnit") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:imei</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>International Mobile Equipment Identity.</para>
    ///   <para>L'identité internationale d'équipement mobile est un numéro qui permet d'identifier de manière unique chacun des terminaux de téléphonie mobile.</para>
    /// labels<para>imei</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#imei">http://www.identity.org/ontologies/identity.owl#imei</seealso>
    let imei = Prefixed_Name(identitorg, "imei") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasAction">http://www.identity.org/ontologies/identity.owl#hasAction</seealso>
    let hasAction = Prefixed_Name(identitorg, "hasAction") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasActionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasActionDate">http://www.identity.org/ontologies/identity.owl#hasActionDate</seealso>
    let hasActionDate = Prefixed_Name(identitorg, "hasActionDate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasContext</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasContext">http://www.identity.org/ontologies/identity.owl#hasContext</seealso>
    let hasContext = Prefixed_Name(identitorg, "hasContext") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasDefaultPolicyMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasDefaultPolicyMode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasDefaultPolicyMode">http://www.identity.org/ontologies/identity.owl#hasDefaultPolicyMode</seealso>
    let hasDefaultPolicyMode =
        Prefixed_Name(identitorg, "hasDefaultPolicyMode") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasLocation</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasLocation">http://www.identity.org/ontologies/identity.owl#hasLocation</seealso>
    let hasLocation = Prefixed_Name(identitorg, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasWorkInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasWorkInfo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasWorkInfo">http://www.identity.org/ontologies/identity.owl#hasWorkInfo</seealso>
    let hasWorkInfo = Prefixed_Name(identitorg, "hasWorkInfo") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>uid</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#uid">http://www.identity.org/ontologies/identity.owl#uid</seealso>
    let uid = Prefixed_Name(identitorg, "uid") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:businessName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>businessName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#businessName">http://www.identity.org/ontologies/identity.owl#businessName</seealso>
    let businessName = Prefixed_Name(identitorg, "businessName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>logo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#logo">http://www.identity.org/ontologies/identity.owl#logo</seealso>
    let logo = Prefixed_Name(identitorg, "logo") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:CellPhoneData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Les données correspondant à l'appareil mobile.</para>
    /// labels<para>CellPhoneData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#CellPhoneData">http://www.identity.org/ontologies/identity.owl#CellPhoneData</seealso>
    let CellPhoneData = Prefixed_Name(identitorg, "CellPhoneData") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasContactInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Cette propriété associe un objet à une adresse, une adresse e-mail et à un numéro de téléphone.</para>
    /// labels<para>hasContactInfo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasContactInfo">http://www.identity.org/ontologies/identity.owl#hasContactInfo</seealso>
    let hasContactInfo = Prefixed_Name(identitorg, "hasContactInfo") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:cellID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>L'identifiant de l'appareil.</para>
    /// labels<para>cellID</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#cellID">http://www.identity.org/ontologies/identity.owl#cellID</seealso>
    let cellID = Prefixed_Name(identitorg, "cellID") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Il s'agit de l'élèment de l'identité qui permettera l'authentification de l'utilisateur, du fournisseur de service ainsi que l'émetteur de l'identité.</para>
    ///   <para>This structure is used to specify identity certificates.</para>
    /// labels<para>User or Organization Identity Certificate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Certificate">http://www.identity.org/ontologies/identity.owl#Certificate</seealso>
    let Certificate = Prefixed_Name(identitorg, "Certificate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Certificate Format</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#format">http://www.identity.org/ontologies/identity.owl#format</seealso>
    let format = Prefixed_Name(identitorg, "format") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:hasExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasExpirationDate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasExpirationDate">http://www.identity.org/ontologies/identity.owl#hasExpirationDate</seealso>
    let hasExpirationDate =
        Prefixed_Name(identitorg, "hasExpirationDate") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:OnlineAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Les comptes en ligne de l'utilisateur.</para>
    /// labels<para>OnlineAccount</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#OnlineAccount">http://www.identity.org/ontologies/identity.owl#OnlineAccount</seealso>
    let OnlineAccount = Prefixed_Name(identitorg, "OnlineAccount") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Context</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Context">http://www.identity.org/ontologies/identity.owl#Context</seealso>
    let Context = Prefixed_Name(identitorg, "Context") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:fractionSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>fractionSecond</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#fractionSecond">http://www.identity.org/ontologies/identity.owl#fractionSecond</seealso>
    let fractionSecond = Prefixed_Name(identitorg, "fractionSecond") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:controls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>controls</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#controls">http://www.identity.org/ontologies/identity.owl#controls</seealso>
    let controls = Prefixed_Name(identitorg, "controls") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:createdOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>createdOn</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#createdOn">http://www.identity.org/ontologies/identity.owl#createdOn</seealso>
    let createdOn = Prefixed_Name(identitorg, "createdOn") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:timeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Time date information is described in the time standard ISO8601.</para>
    /// labels<para>timeDate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#timeDate">http://www.identity.org/ontologies/identity.owl#timeDate</seealso>
    let timeDate = Prefixed_Name(identitorg, "timeDate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:languageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code du langage choisi par l'utilisateur.</para>
    /// labels<para>languageCode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#languageCode">http://www.identity.org/ontologies/identity.owl#languageCode</seealso>
    let languageCode = Prefixed_Name(identitorg, "languageCode") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Les clés secrètes et publiques associées à un certificat.</para>
    /// labels<para>Certificate Key</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#key">http://www.identity.org/ontologies/identity.owl#key</seealso>
    let key = Prefixed_Name(identitorg, "key") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasActor</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasActor">http://www.identity.org/ontologies/identity.owl#hasActor</seealso>
    let hasActor = Prefixed_Name(identitorg, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasDate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasDate">http://www.identity.org/ontologies/identity.owl#hasDate</seealso>
    let hasDate = Prefixed_Name(identitorg, "hasDate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ChatAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Compte de discussion en ligne.</para>
    /// labels<para>ChatAccount</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ChatAccount">http://www.identity.org/ontologies/identity.owl#ChatAccount</seealso>
    let ChatAccount = Prefixed_Name(identitorg, "ChatAccount") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Condition</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Condition">http://www.identity.org/ontologies/identity.owl#Condition</seealso>
    let Condition = Prefixed_Name(identitorg, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:postOfficeBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>postOfficeBox</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#postOfficeBox">http://www.identity.org/ontologies/identity.owl#postOfficeBox</seealso>
    let postOfficeBox = Prefixed_Name(identitorg, "postOfficeBox") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>requires</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#requires">http://www.identity.org/ontologies/identity.owl#requires</seealso>
    let requires = Prefixed_Name(identitorg, "requires") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:timeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para></para>
    /// labels<para>timeZone</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#timeZone">http://www.identity.org/ontologies/identity.owl#timeZone</seealso>
    let timeZone = Prefixed_Name(identitorg, "timeZone") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hmsDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hmsDate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hmsDate">http://www.identity.org/ontologies/identity.owl#hmsDate</seealso>
    let hmsDate = Prefixed_Name(identitorg, "hmsDate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:dateYmd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para></para>
    /// labels<para>dateYmd</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#dateYmd">http://www.identity.org/ontologies/identity.owl#dateYmd</seealso>
    let dateYmd = Prefixed_Name(identitorg, "dateYmd") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:EcommerceAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Compte d'achat en ligne. Il peut contenir des informations critiques comme les données bancaires.</para>
    /// labels<para>EcommerceAccount</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#EcommerceAccount">http://www.identity.org/ontologies/identity.owl#EcommerceAccount</seealso>
    let EcommerceAccount = Prefixed_Name(identitorg, "EcommerceAccount") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:algo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>algo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#algo">http://www.identity.org/ontologies/identity.owl#algo</seealso>
    let algo = Prefixed_Name(identitorg, "algo") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fax</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Fax">http://www.identity.org/ontologies/identity.owl#Fax</seealso>
    let Fax = Prefixed_Name(identitorg, "Fax") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:GamingAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Compte pour des jeux en ligne (gratuit ou payant).</para>
    /// labels<para>GamingAccount</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#GamingAccount">http://www.identity.org/ontologies/identity.owl#GamingAccount</seealso>
    let GamingAccount = Prefixed_Name(identitorg, "GamingAccount") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un groupe des personnes qui constituent la liste des contacts d'un individu.</para>
    ///   <para>A group of persons that figure in the contact list of an individual.</para>
    /// labels<para>Group</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Group">http://www.identity.org/ontologies/identity.owl#Group</seealso>
    let Group = Prefixed_Name(identitorg, "Group") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>L'ensemble des personnes physiques.</para>
    ///   <para>Indivuals or natural entities.</para>
    /// labels<para>Individual</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Individual">http://www.identity.org/ontologies/identity.owl#Individual</seealso>
    let Individual = Prefixed_Name(identitorg, "Individual") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:History</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>History</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#History">http://www.identity.org/ontologies/identity.owl#History</seealso>
    let History = Prefixed_Name(identitorg, "History") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:jobTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>jobTitle</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#jobTitle">http://www.identity.org/ontologies/identity.owl#jobTitle</seealso>
    let jobTitle = Prefixed_Name(identitorg, "jobTitle") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>gender</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#gender">http://www.identity.org/ontologies/identity.owl#gender</seealso>
    let gender = Prefixed_Name(identitorg, "gender") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasHomeInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasHomeInfo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasHomeInfo">http://www.identity.org/ontologies/identity.owl#hasHomeInfo</seealso>
    let hasHomeInfo = Prefixed_Name(identitorg, "hasHomeInfo") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>L'émetteur d'une identité numérique (opérateur téléphonique par exemple).</para>
    ///   <para>This legal entity is the issuer of an individual digital identity.</para>
    /// labels<para>Issuer</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Issuer">http://www.identity.org/ontologies/identity.owl#Issuer</seealso>
    let Issuer = Prefixed_Name(identitorg, "Issuer") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:LocationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Les données de locations permettant de localiser le porteur de l'identité.</para>
    /// labels<para>LocationData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#LocationData">http://www.identity.org/ontologies/identity.owl#LocationData</seealso>
    let LocationData = Prefixed_Name(identitorg, "LocationData") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:gps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Système de positionnement mondial.</para>
    ///   <para>Global Positioning System</para>
    /// labels<para>gps</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#gps">http://www.identity.org/ontologies/identity.owl#gps</seealso>
    let gps = Prefixed_Name(identitorg, "gps") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Adresse IP du mobile.</para>
    /// labels<para>ip</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ip">http://www.identity.org/ontologies/identity.owl#ip</seealso>
    let ip = Prefixed_Name(identitorg, "ip") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:LogData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>LogInformation</para><para>LogInfo</para><para>LogData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#LogData">http://www.identity.org/ontologies/identity.owl#LogData</seealso>
    let LogData = Prefixed_Name(identitorg, "LogData") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>timestamp</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#timestamp">http://www.identity.org/ontologies/identity.owl#timestamp</seealso>
    let timestamp = Prefixed_Name(identitorg, "timestamp") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:callLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>callLog</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#callLog">http://www.identity.org/ontologies/identity.owl#callLog</seealso>
    let callLog = Prefixed_Name(identitorg, "callLog") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:password</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Login password</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#password">http://www.identity.org/ontologies/identity.owl#password</seealso>
    let password = Prefixed_Name(identitorg, "password") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:MiscData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Photos, videos, sms, documents, notes, call logs, cookies...</para>
    /// labels<para>MiscData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#MiscData">http://www.identity.org/ontologies/identity.owl#MiscData</seealso>
    let MiscData = Prefixed_Name(identitorg, "MiscData") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:cookie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>cookie</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#cookie">http://www.identity.org/ontologies/identity.owl#cookie</seealso>
    let cookie = Prefixed_Name(identitorg, "cookie") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>photo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#photo">http://www.identity.org/ontologies/identity.owl#photo</seealso>
    let photo = Prefixed_Name(identitorg, "photo") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Mobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mobile</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Mobile">http://www.identity.org/ontologies/identity.owl#Mobile</seealso>
    let Mobile = Prefixed_Name(identitorg, "Mobile") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Mode">http://www.identity.org/ontologies/identity.owl#Mode</seealso>
    let Mode = Prefixed_Name(identitorg, "Mode") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:nickName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>nickName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#nickName">http://www.identity.org/ontologies/identity.owl#nickName</seealso>
    let nickName = Prefixed_Name(identitorg, "nickName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>familyName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#familyName">http://www.identity.org/ontologies/identity.owl#familyName</seealso>
    let familyName = Prefixed_Name(identitorg, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>givenName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#givenName">http://www.identity.org/ontologies/identity.owl#givenName</seealso>
    let givenName = Prefixed_Name(identitorg, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>title</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#title">http://www.identity.org/ontologies/identity.owl#title</seealso>
    let title = Prefixed_Name(identitorg, "title") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>email</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#email">http://www.identity.org/ontologies/identity.owl#email</seealso>
    let email = Prefixed_Name(identitorg, "email") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:PermittedAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>PermittedAction</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#PermittedAction">http://www.identity.org/ontologies/identity.owl#PermittedAction</seealso>
    let PermittedAction = Prefixed_Name(identitorg, "PermittedAction") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>knows</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#knows">http://www.identity.org/ontologies/identity.owl#knows</seealso>
    let knows = Prefixed_Name(identitorg, "knows") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Policy</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Policy">http://www.identity.org/ontologies/identity.owl#Policy</seealso>
    let Policy = Prefixed_Name(identitorg, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>number</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#number">http://www.identity.org/ontologies/identity.owl#number</seealso>
    let number = Prefixed_Name(identitorg, "number") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>postalCode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#postalCode">http://www.identity.org/ontologies/identity.owl#postalCode</seealso>
    let postalCode = Prefixed_Name(identitorg, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>country</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#country">http://www.identity.org/ontologies/identity.owl#country</seealso>
    let country = Prefixed_Name(identitorg, "country") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>region</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#region">http://www.identity.org/ontologies/identity.owl#region</seealso>
    let region = Prefixed_Name(identitorg, "region") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:departmentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>departmentName</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#departmentName">http://www.identity.org/ontologies/identity.owl#departmentName</seealso>
    let departmentName = Prefixed_Name(identitorg, "departmentName") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:street</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>street</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#street">http://www.identity.org/ontologies/identity.owl#street</seealso>
    let street = Prefixed_Name(identitorg, "street") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:departmentCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>departmentCode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#departmentCode">http://www.identity.org/ontologies/identity.owl#departmentCode</seealso>
    let departmentCode = Prefixed_Name(identitorg, "departmentCode") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:SecretData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SecretData</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#SecretData">http://www.identity.org/ontologies/identity.owl#SecretData</seealso>
    let SecretData = Prefixed_Name(identitorg, "SecretData") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:pin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code secret pour authentifier le porteur de l'identité.</para>
    ///   <para>A secret code to identify the identity holder.</para>
    /// labels<para>pin</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#pin">http://www.identity.org/ontologies/identity.owl#pin</seealso>
    let pin = Prefixed_Name(identitorg, "pin") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provider of mobile phone services.</para>
    ///   <para>Le fournisseur de services mobiles (application, jeu, site Web)</para>
    /// labels<para>ServiceProvider</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ServiceProvider">http://www.identity.org/ontologies/identity.owl#ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(identitorg, "ServiceProvider") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Telephone</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Telephone">http://www.identity.org/ontologies/identity.owl#Telephone</seealso>
    let Telephone = Prefixed_Name(identitorg, "Telephone") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>phoneNumber</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#phoneNumber">http://www.identity.org/ontologies/identity.owl#phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(identitorg, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:phoneExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>phoneExtension</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#phoneExtension">http://www.identity.org/ontologies/identity.owl#phoneExtension</seealso>
    let phoneExtension = Prefixed_Name(identitorg, "phoneExtension") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:localCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>localCode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#localCode">http://www.identity.org/ontologies/identity.owl#localCode</seealso>
    let localCode = Prefixed_Name(identitorg, "localCode") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:intCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code international, qui permet par exemple l'accès au service Roaming à l'étranger.</para>
    /// labels<para>intCode</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#intCode">http://www.identity.org/ontologies/identity.owl#intCode</seealso>
    let intCode = Prefixed_Name(identitorg, "intCode") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:UID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>L'identifiant unique d'une entité qui possède une identité (agent).</para>
    /// labels<para>UID</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#UID">http://www.identity.org/ontologies/identity.owl#UID</seealso>
    let UID = Prefixed_Name(identitorg, "UID") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:ValidCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ValidCertificate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ValidCertificate">http://www.identity.org/ontologies/identity.owl#ValidCertificate</seealso>
    let ValidCertificate = Prefixed_Name(identitorg, "ValidCertificate") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>age</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#age">http://www.identity.org/ontologies/identity.owl#age</seealso>
    let age = Prefixed_Name(identitorg, "age") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>data</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#data">http://www.identity.org/ontologies/identity.owl#data</seealso>
    let data = Prefixed_Name(identitorg, "data") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:EncryptAlgo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Algorithme de chiffrement.</para><para>EncryptAlgo</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#EncryptAlgo">http://www.identity.org/ontologies/identity.owl#EncryptAlgo</seealso>
    let EncryptAlgo = Prefixed_Name(identitorg, "EncryptAlgo") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:Telecommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Telecommunication information about an agnet.</para>
    /// labels<para>Telecommunication</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Telecommunication">http://www.identity.org/ontologies/identity.owl#Telecommunication</seealso>
    let Telecommunication =
        Prefixed_Name(identitorg, "Telecommunication") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:ForbiddenAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ForbiddenAction</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#ForbiddenAction">http://www.identity.org/ontologies/identity.owl#ForbiddenAction</seealso>
    let ForbiddenAction = Prefixed_Name(identitorg, "ForbiddenAction") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person is an individual who has a social identity and a technical one.</para>
    ///   <para>Une personne est un individu qui possède une identité numérique et qui cherche à protéger sa vie privée.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Person">http://www.identity.org/ontologies/identity.owl#Person</seealso>
    let Person = Prefixed_Name(identitorg, "Person") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasMember</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasMember">http://www.identity.org/ontologies/identity.owl#hasMember</seealso>
    let hasMember = Prefixed_Name(identitorg, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasCertificate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasCertificate">http://www.identity.org/ontologies/identity.owl#hasCertificate</seealso>
    let hasCertificate = Prefixed_Name(identitorg, "hasCertificate") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:IndividualInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identité associée uniquement à une personne physique.</para>
    /// labels<para>IndividualInformation</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#IndividualInformation">http://www.identity.org/ontologies/identity.owl#IndividualInformation</seealso>
    let IndividualInformation =
        Prefixed_Name(identitorg, "IndividualInformation") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The person name specifies information about the naming of a person.</para>
    /// labels<para>User's Name</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Name">http://www.identity.org/ontologies/identity.owl#Name</seealso>
    let Name = Prefixed_Name(identitorg, "Name") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:Login</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>IDs ans Passwords for web services which require authentification.</para>
    /// labels<para>User's Login Information</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#Login">http://www.identity.org/ontologies/identity.owl#Login</seealso>
    let Login = Prefixed_Name(identitorg, "Login") |> PrefixedName
    /// <summary>
    ///   <para>identitorg:hasLogin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasLogin</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#hasLogin">http://www.identity.org/ontologies/identity.owl#hasLogin</seealso>
    let hasLogin = Prefixed_Name(identitorg, "hasLogin") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:InvalidCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>InvalidCertificate</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#InvalidCertificate">http://www.identity.org/ontologies/identity.owl#InvalidCertificate</seealso>
    let InvalidCertificate =
        Prefixed_Name(identitorg, "InvalidCertificate") |> PrefixedName

    /// <summary>
    ///   <para>identitorg:FaceRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FaceRecognition</para></remarks>
    /// <seealso href="http://www.identity.org/ontologies/identity.owl#FaceRecognition">http://www.identity.org/ontologies/identity.owl#FaceRecognition</seealso>
    let FaceRecognition = Prefixed_Name(identitorg, "FaceRecognition") |> PrefixedName
