namespace http.ontology.eil.utoronto.ca.icontact.owl.hash

open DoxAletheia

module ic =
    let _namespace_name = "http://ontology.eil.utoronto.ca/icontact.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#AddressType"></see>
    /// </summary>
    let AddressType = _prefix "AddressType"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#DaysOfWeek"></see>
    /// </summary>
    let DaysOfWeek = _prefix "DaysOfWeek"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HoursOfOperation"></see>
    /// </summary>
    let HoursOfOperation = _prefix "HoursOfOperation"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneNumber"></see>
    /// </summary>
    let PhoneNumber = _prefix "PhoneNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneType"></see>
    /// </summary>
    let PhoneType = _prefix "PhoneType"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#StreetDirection"></see>
    /// </summary>
    let StreetDirection = _prefix "StreetDirection"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#StreetType"></see>
    /// </summary>
    let StreetType = _prefix "StreetType"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasBuilding"></see>
    /// </summary>
    let hasBuilding = _prefix "hasBuilding"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasUnitNumber"></see>
    /// </summary>
    let hasUnitNumber = _prefix "hasUnitNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCitySection"></see>
    /// </summary>
    let hasCitySection = _prefix "hasCitySection"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountry"></see>
    /// </summary>
    let hasCountry = _prefix "hasCountry"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#iContactThing"></see>
    /// </summary>
    let iContactThing = _prefix "iContactThing"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCity"></see>
    /// </summary>
    let hasCity = _prefix "hasCity"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetDirection"></see>
    /// </summary>
    let hasStreetDirection = _prefix "hasStreetDirection"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPostalCode"></see>
    /// </summary>
    let hasPostalCode = _prefix "hasPostalCode"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasState"></see>
    /// </summary>
    let hasState = _prefix "hasState"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreet"></see>
    /// </summary>
    let hasStreet = _prefix "hasStreet"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetNumber"></see>
    /// </summary>
    let hasStreetNumber = _prefix "hasStreetNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetType"></see>
    /// </summary>
    let hasStreetType = _prefix "hasStreetType"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Cottage"></see>
    /// </summary>
    let Cottage = _prefix "Cottage"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Home"></see>
    /// </summary>
    let Home = _prefix "Home"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Work"></see>
    /// </summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Avenue"></see>
    /// </summary>
    let Avenue = _prefix "Avenue"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Boulevard"></see>
    /// </summary>
    let Boulevard = _prefix "Boulevard"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#CellNumber"></see>
    /// </summary>
    let CellNumber = _prefix "CellNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#CellPhone"></see>
    /// </summary>
    let CellPhone = _prefix "CellPhone"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneType"></see>
    /// </summary>
    let hasPhoneType = _prefix "hasPhoneType"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Circle"></see>
    /// </summary>
    let Circle = _prefix "Circle"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#CottageAddress"></see>
    /// </summary>
    let CottageAddress = _prefix "CottageAddress"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddressType"></see>
    /// </summary>
    let hasAddressType = _prefix "hasAddressType"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Crescent"></see>
    /// </summary>
    let Crescent = _prefix "Crescent"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Drive"></see>
    /// </summary>
    let Drive = _prefix "Drive"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#East"></see>
    /// </summary>
    let East = _prefix "East"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#FaxNumber"></see>
    /// </summary>
    let FaxNumber = _prefix "FaxNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#FaxPhone"></see>
    /// </summary>
    let FaxPhone = _prefix "FaxPhone"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Friday"></see>
    /// </summary>
    let Friday = _prefix "Friday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HomeAddress"></see>
    /// </summary>
    let HomeAddress = _prefix "HomeAddress"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HomeNumber"></see>
    /// </summary>
    let HomeNumber = _prefix "HomeNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#HomePhone"></see>
    /// </summary>
    let HomePhone = _prefix "HomePhone"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasClosingTime"></see>
    /// </summary>
    let hasClosingTime = _prefix "hasClosingTime"
    /// <summary>
    /// Specifies the day of the week, e.g., Monday, that the times apply to.  This is the default for that day and can be overidden by the "hasDate" property.
    /// <see href="http://ontology.eil.utoronto.ca/icontact.owl#dayofWeek"></see></summary>
    let dayofWeek = _prefix "dayofWeek"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasOpeningTime"></see>
    /// </summary>
    let hasOpeningTime = _prefix "hasOpeningTime"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Monday"></see>
    /// </summary>
    let Monday = _prefix "Monday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#North"></see>
    /// </summary>
    let North = _prefix "North"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#OperatingProperty"></see>
    /// </summary>
    let OperatingProperty = _prefix "OperatingProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#contactProperty"></see>
    /// </summary>
    let contactProperty = _prefix "contactProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneNumber"></see>
    /// </summary>
    let hasPhoneNumber = _prefix "hasPhoneNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountryCode"></see>
    /// </summary>
    let hasCountryCode = _prefix "hasCountryCode"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasAreaCode"></see>
    /// </summary>
    let hasAreaCode = _prefix "hasAreaCode"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreePhone"></see>
    /// </summary>
    let TollFreePhone = _prefix "TollFreePhone"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#WorkPhone"></see>
    /// </summary>
    let WorkPhone = _prefix "WorkPhone"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Road"></see>
    /// </summary>
    let Road = _prefix "Road"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Saturday"></see>
    /// </summary>
    let Saturday = _prefix "Saturday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#SchemaOrgThing"></see>
    /// </summary>
    let SchemaOrgThing = _prefix "SchemaOrgThing"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#South"></see>
    /// </summary>
    let South = _prefix "South"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Street"></see>
    /// </summary>
    let Street = _prefix "Street"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#West"></see>
    /// </summary>
    let West = _prefix "West"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Sunday"></see>
    /// </summary>
    let Sunday = _prefix "Sunday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Thursday"></see>
    /// </summary>
    let Thursday = _prefix "Thursday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreeNumber"></see>
    /// </summary>
    let TollFreeNumber = _prefix "TollFreeNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Tuesday"></see>
    /// </summary>
    let Tuesday = _prefix "Tuesday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#Wednesday"></see>
    /// </summary>
    let Wednesday = _prefix "Wednesday"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#WorkAddress"></see>
    /// </summary>
    let WorkAddress = _prefix "WorkAddress"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#WorkNumber"></see>
    /// </summary>
    let WorkNumber = _prefix "WorkNumber"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#addressDataProperty"></see>
    /// </summary>
    let addressDataProperty = _prefix "addressDataProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasContactDataProperty"></see>
    /// </summary>
    let hasContactDataProperty = _prefix "hasContactDataProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#addressProperty"></see>
    /// </summary>
    let addressProperty = _prefix "addressProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#emailDataProperty"></see>
    /// </summary>
    let emailDataProperty = _prefix "emailDataProperty"
    /// <summary>
    /// hasAddress links any class to the Address class.
    /// <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddress"></see></summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#telephoneDataProperty"></see>
    /// </summary>
    let telephoneDataProperty = _prefix "telephoneDataProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#operatingDataProperty"></see>
    /// </summary>
    let operatingDataProperty = _prefix "operatingDataProperty"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasDate"></see>
    /// </summary>
    let hasDate = _prefix "hasDate"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasEmail"></see>
    /// </summary>
    let hasEmail = _prefix "hasEmail"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasGeoCoordinates"></see>
    /// </summary>
    let hasGeoCoordinates = _prefix "hasGeoCoordinates"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasLocation"></see>
    /// </summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasOperatingHours"></see>
    /// </summary>
    let hasOperatingHours = _prefix "hasOperatingHours"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasPersonalEmail"></see>
    /// </summary>
    let hasPersonalEmail = _prefix "hasPersonalEmail"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasTelephone"></see>
    /// </summary>
    let hasTelephone = _prefix "hasTelephone"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasWebSite"></see>
    /// </summary>
    let hasWebSite = _prefix "hasWebSite"
    /// <summary>
    ///   <see href="http://ontology.eil.utoronto.ca/icontact.owl#hasWorkEmail"></see>
    /// </summary>
    let hasWorkEmail = _prefix "hasWorkEmail"
