namespace http.ontology.eil.utoronto.ca.icontact.owl.hash

open DoxAletheia.Rdf_Vocabulary

module ic =
    let _namespace_name = "http://ontology.eil.utoronto.ca/icontact.owl#"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Address"></see>
    /// </summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#AddressType"></see>
    /// </summary>
    let AddressType =
        Namespaced_IRI.parse _namespace_name "AddressType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#DaysOfWeek"></see>
    /// </summary>
    let DaysOfWeek = Namespaced_IRI.parse _namespace_name "DaysOfWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HoursOfOperation"></see>
    /// </summary>
    let HoursOfOperation =
        Namespaced_IRI.parse _namespace_name "HoursOfOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneNumber"></see>
    /// </summary>
    let PhoneNumber =
        Namespaced_IRI.parse _namespace_name "PhoneNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneType"></see>
    /// </summary>
    let PhoneType = Namespaced_IRI.parse _namespace_name "PhoneType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#StreetDirection"></see>
    /// </summary>
    let StreetDirection =
        Namespaced_IRI.parse _namespace_name "StreetDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#StreetType"></see>
    /// </summary>
    let StreetType = Namespaced_IRI.parse _namespace_name "StreetType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasBuilding"></see>
    /// </summary>
    let hasBuilding =
        Namespaced_IRI.parse _namespace_name "hasBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasUnitNumber"></see>
    /// </summary>
    let hasUnitNumber =
        Namespaced_IRI.parse _namespace_name "hasUnitNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCitySection"></see>
    /// </summary>
    let hasCitySection =
        Namespaced_IRI.parse _namespace_name "hasCitySection" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountry"></see>
    /// </summary>
    let hasCountry = Namespaced_IRI.parse _namespace_name "hasCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#iContactThing"></see>
    /// </summary>
    let iContactThing =
        Namespaced_IRI.parse _namespace_name "iContactThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCity"></see>
    /// </summary>
    let hasCity = Namespaced_IRI.parse _namespace_name "hasCity" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetDirection"></see>
    /// </summary>
    let hasStreetDirection =
        Namespaced_IRI.parse _namespace_name "hasStreetDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPostalCode"></see>
    /// </summary>
    let hasPostalCode =
        Namespaced_IRI.parse _namespace_name "hasPostalCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasState"></see>
    /// </summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreet"></see>
    /// </summary>
    let hasStreet = Namespaced_IRI.parse _namespace_name "hasStreet" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetNumber"></see>
    /// </summary>
    let hasStreetNumber =
        Namespaced_IRI.parse _namespace_name "hasStreetNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetType"></see>
    /// </summary>
    let hasStreetType =
        Namespaced_IRI.parse _namespace_name "hasStreetType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Cottage"></see>
    /// </summary>
    let Cottage = Namespaced_IRI.parse _namespace_name "Cottage" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Home"></see>
    /// </summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Avenue"></see>
    /// </summary>
    let Avenue = Namespaced_IRI.parse _namespace_name "Avenue" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Boulevard"></see>
    /// </summary>
    let Boulevard = Namespaced_IRI.parse _namespace_name "Boulevard" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#CellNumber"></see>
    /// </summary>
    let CellNumber = Namespaced_IRI.parse _namespace_name "CellNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#CellPhone"></see>
    /// </summary>
    let CellPhone = Namespaced_IRI.parse _namespace_name "CellPhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneType"></see>
    /// </summary>
    let hasPhoneType =
        Namespaced_IRI.parse _namespace_name "hasPhoneType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Circle"></see>
    /// </summary>
    let Circle = Namespaced_IRI.parse _namespace_name "Circle" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#CottageAddress"></see>
    /// </summary>
    let CottageAddress =
        Namespaced_IRI.parse _namespace_name "CottageAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddressType"></see>
    /// </summary>
    let hasAddressType =
        Namespaced_IRI.parse _namespace_name "hasAddressType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Crescent"></see>
    /// </summary>
    let Crescent = Namespaced_IRI.parse _namespace_name "Crescent" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Drive"></see>
    /// </summary>
    let Drive = Namespaced_IRI.parse _namespace_name "Drive" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#East"></see>
    /// </summary>
    let East = Namespaced_IRI.parse _namespace_name "East" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#FaxNumber"></see>
    /// </summary>
    let FaxNumber = Namespaced_IRI.parse _namespace_name "FaxNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#FaxPhone"></see>
    /// </summary>
    let FaxPhone = Namespaced_IRI.parse _namespace_name "FaxPhone" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Friday"></see>
    /// </summary>
    let Friday = Namespaced_IRI.parse _namespace_name "Friday" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HomeAddress"></see>
    /// </summary>
    let HomeAddress =
        Namespaced_IRI.parse _namespace_name "HomeAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HomeNumber"></see>
    /// </summary>
    let HomeNumber = Namespaced_IRI.parse _namespace_name "HomeNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HomePhone"></see>
    /// </summary>
    let HomePhone = Namespaced_IRI.parse _namespace_name "HomePhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasClosingTime"></see>
    /// </summary>
    let hasClosingTime =
        Namespaced_IRI.parse _namespace_name "hasClosingTime" |> NamespacedName

    /// <summary>
    /// Specifies the day of the week, e.g., Monday, that the times apply to.  This is the default for that day and can be overidden by the "hasDate" property.
    /// <see href="http://ontology.eil.utoronto.ca/icontact.owl#dayofWeek"></see></summary>
    let dayofWeek = Namespaced_IRI.parse _namespace_name "dayofWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasOpeningTime"></see>
    /// </summary>
    let hasOpeningTime =
        Namespaced_IRI.parse _namespace_name "hasOpeningTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Monday"></see>
    /// </summary>
    let Monday = Namespaced_IRI.parse _namespace_name "Monday" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#North"></see>
    /// </summary>
    let North = Namespaced_IRI.parse _namespace_name "North" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#OperatingProperty"></see>
    /// </summary>
    let OperatingProperty =
        Namespaced_IRI.parse _namespace_name "OperatingProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#contactProperty"></see>
    /// </summary>
    let contactProperty =
        Namespaced_IRI.parse _namespace_name "contactProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneNumber"></see>
    /// </summary>
    let hasPhoneNumber =
        Namespaced_IRI.parse _namespace_name "hasPhoneNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountryCode"></see>
    /// </summary>
    let hasCountryCode =
        Namespaced_IRI.parse _namespace_name "hasCountryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasAreaCode"></see>
    /// </summary>
    let hasAreaCode =
        Namespaced_IRI.parse _namespace_name "hasAreaCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreePhone"></see>
    /// </summary>
    let TollFreePhone =
        Namespaced_IRI.parse _namespace_name "TollFreePhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#WorkPhone"></see>
    /// </summary>
    let WorkPhone = Namespaced_IRI.parse _namespace_name "WorkPhone" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Road"></see>
    /// </summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Saturday"></see>
    /// </summary>
    let Saturday = Namespaced_IRI.parse _namespace_name "Saturday" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#SchemaOrgThing"></see>
    /// </summary>
    let SchemaOrgThing =
        Namespaced_IRI.parse _namespace_name "SchemaOrgThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#South"></see>
    /// </summary>
    let South = Namespaced_IRI.parse _namespace_name "South" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Street"></see>
    /// </summary>
    let Street = Namespaced_IRI.parse _namespace_name "Street" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#West"></see>
    /// </summary>
    let West = Namespaced_IRI.parse _namespace_name "West" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Sunday"></see>
    /// </summary>
    let Sunday = Namespaced_IRI.parse _namespace_name "Sunday" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Thursday"></see>
    /// </summary>
    let Thursday = Namespaced_IRI.parse _namespace_name "Thursday" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreeNumber"></see>
    /// </summary>
    let TollFreeNumber =
        Namespaced_IRI.parse _namespace_name "TollFreeNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Tuesday"></see>
    /// </summary>
    let Tuesday = Namespaced_IRI.parse _namespace_name "Tuesday" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Wednesday"></see>
    /// </summary>
    let Wednesday = Namespaced_IRI.parse _namespace_name "Wednesday" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#WorkAddress"></see>
    /// </summary>
    let WorkAddress =
        Namespaced_IRI.parse _namespace_name "WorkAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#WorkNumber"></see>
    /// </summary>
    let WorkNumber = Namespaced_IRI.parse _namespace_name "WorkNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#addressDataProperty"></see>
    /// </summary>
    let addressDataProperty =
        Namespaced_IRI.parse _namespace_name "addressDataProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasContactDataProperty"></see>
    /// </summary>
    let hasContactDataProperty =
        Namespaced_IRI.parse _namespace_name "hasContactDataProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#addressProperty"></see>
    /// </summary>
    let addressProperty =
        Namespaced_IRI.parse _namespace_name "addressProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#emailDataProperty"></see>
    /// </summary>
    let emailDataProperty =
        Namespaced_IRI.parse _namespace_name "emailDataProperty" |> NamespacedName

    /// <summary>
    /// hasAddress links any class to the Address class.
    /// <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddress"></see></summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#telephoneDataProperty"></see>
    /// </summary>
    let telephoneDataProperty =
        Namespaced_IRI.parse _namespace_name "telephoneDataProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#operatingDataProperty"></see>
    /// </summary>
    let operatingDataProperty =
        Namespaced_IRI.parse _namespace_name "operatingDataProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasDate"></see>
    /// </summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasEmail"></see>
    /// </summary>
    let hasEmail = Namespaced_IRI.parse _namespace_name "hasEmail" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasGeoCoordinates"></see>
    /// </summary>
    let hasGeoCoordinates =
        Namespaced_IRI.parse _namespace_name "hasGeoCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasOperatingHours"></see>
    /// </summary>
    let hasOperatingHours =
        Namespaced_IRI.parse _namespace_name "hasOperatingHours" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPersonalEmail"></see>
    /// </summary>
    let hasPersonalEmail =
        Namespaced_IRI.parse _namespace_name "hasPersonalEmail" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasTelephone"></see>
    /// </summary>
    let hasTelephone =
        Namespaced_IRI.parse _namespace_name "hasTelephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasWebSite"></see>
    /// </summary>
    let hasWebSite = Namespaced_IRI.parse _namespace_name "hasWebSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasWorkEmail"></see>
    /// </summary>
    let hasWorkEmail =
        Namespaced_IRI.parse _namespace_name "hasWorkEmail" |> NamespacedName
