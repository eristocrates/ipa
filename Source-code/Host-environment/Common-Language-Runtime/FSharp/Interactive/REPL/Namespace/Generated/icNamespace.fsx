#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ic =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.eil.utoronto.ca/icontact.owl#" "ic"

    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <para>dcterms:description : Address is the main concept for a contact.  It has been designed to represent any type of address in the world, including India and the UK.  For example, the property hasBuilding is important in many UK and Indian addresses to further identify the person or business location.
    ///
    /// Street information is divided into separate properties to fully indentify direction (hasStreetDirection), Type (hasStreetType), etc.  See the associated list of properties for more.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#Address">ic:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>dcterms:description : Different type for home, office, cottage, etc.</para>
    ///   <para>rdfs:label : Address Type</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#AddressType">ic:AddressType</a>
    /// </summary>
    let AddressType = _prefixId.prefix "AddressType"
    let Avenue = _prefixId.prefix "Avenue"
    let Boulevard = _prefixId.prefix "Boulevard"
    /// <summary>
    ///   <para>rdfs:label : Mobile Telephone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#CellNumber">ic:CellNumber</a>
    /// </summary>
    let CellNumber = _prefixId.prefix "CellNumber"
    let CellPhone = _prefixId.prefix "CellPhone"
    let Circle = _prefixId.prefix "Circle"
    let Cottage = _prefixId.prefix "Cottage"
    /// <summary>
    ///   <para>rdfs:label : Cottage Address</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#CottageAddress">ic:CottageAddress</a>
    /// </summary>
    let CottageAddress = _prefixId.prefix "CottageAddress"
    let Crescent = _prefixId.prefix "Crescent"
    /// <summary>
    ///   <para>rdfs:label : Days of the Week</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#DaysOfWeek">ic:DaysOfWeek</a>
    /// </summary>
    let DaysOfWeek = _prefixId.prefix "DaysOfWeek"
    let Drive = _prefixId.prefix "Drive"
    let East = _prefixId.prefix "East"
    /// <summary>
    ///   <para>rdfs:label : Fax Telephone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#FaxNumber">ic:FaxNumber</a>
    /// </summary>
    let FaxNumber = _prefixId.prefix "FaxNumber"
    let FaxPhone = _prefixId.prefix "FaxPhone"
    let Friday = _prefixId.prefix "Friday"
    let Home = _prefixId.prefix "Home"
    /// <summary>
    ///   <para>rdfs:label : Home Address</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#HomeAddress">ic:HomeAddress</a>
    /// </summary>
    let HomeAddress = _prefixId.prefix "HomeAddress"
    /// <summary>
    ///   <para>rdfs:label : Home Telephone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#HomeNumber">ic:HomeNumber</a>
    /// </summary>
    let HomeNumber = _prefixId.prefix "HomeNumber"
    let HomePhone = _prefixId.prefix "HomePhone"
    /// <summary>
    ///   <para>dcterms:description : HoursOfOperation class provides the ability to define when the contact "opens" and "closes". Used for businesses.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#HoursOfOperation">ic:HoursOfOperation</a>
    /// </summary>
    let HoursOfOperation = _prefixId.prefix "HoursOfOperation"
    let Monday = _prefixId.prefix "Monday"
    let North = _prefixId.prefix "North"
    /// <summary>
    ///   <para>dcterms:description : Properties that define the hours of operation of the contact.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#OperatingProperty">ic:OperatingProperty</a>
    /// </summary>
    let OperatingProperty = _prefixId.prefix "OperatingProperty"
    /// <summary>
    ///   <para>dcterms:description : PhoneNumber is another core class. It is divided into country code, and phone number.</para>
    ///   <para>rdfs:label : Phone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneNumber">ic:PhoneNumber</a>
    /// </summary>
    let PhoneNumber = _prefixId.prefix "PhoneNumber"
    /// <summary>
    ///   <para>dcterms:description : Types of phoned include home, cell, work, etc.</para>
    ///   <para>rdfs:label : Phone Type</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneType">ic:PhoneType</a>
    /// </summary>
    let PhoneType = _prefixId.prefix "PhoneType"
    let Road = _prefixId.prefix "Road"
    let Saturday = _prefixId.prefix "Saturday"
    let SchemaOrgThing = _prefixId.prefix "SchemaOrgThing"
    let South = _prefixId.prefix "South"
    let Street = _prefixId.prefix "Street"
    /// <summary>
    ///   <para>rdfs:label : Street Direction</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#StreetDirection">ic:StreetDirection</a>
    /// </summary>
    let StreetDirection = _prefixId.prefix "StreetDirection"
    /// <summary>
    ///   <para>rdfs:label : Street Type</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#StreetType">ic:StreetType</a>
    /// </summary>
    let StreetType = _prefixId.prefix "StreetType"
    let Sunday = _prefixId.prefix "Sunday"
    let Thursday = _prefixId.prefix "Thursday"
    /// <summary>
    ///   <para>rdfs:label : Toll  Free Telephone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreeNumber">ic:TollFreeNumber</a>
    /// </summary>
    let TollFreeNumber = _prefixId.prefix "TollFreeNumber"
    let TollFreePhone = _prefixId.prefix "TollFreePhone"
    let Tuesday = _prefixId.prefix "Tuesday"
    let Wednesday = _prefixId.prefix "Wednesday"
    let West = _prefixId.prefix "West"
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : Work Address</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#WorkAddress">ic:WorkAddress</a>
    /// </summary>
    let WorkAddress = _prefixId.prefix "WorkAddress"
    /// <summary>
    ///   <para>rdfs:label : Work Telephone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#WorkNumber">ic:WorkNumber</a>
    /// </summary>
    let WorkNumber = _prefixId.prefix "WorkNumber"
    let WorkPhone = _prefixId.prefix "WorkPhone"
    let addressDataProperty = _prefixId.prefix "addressDataProperty"
    let addressProperty = _prefixId.prefix "addressProperty"
    let contactProperty = _prefixId.prefix "contactProperty"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the day of the week, e.g., Monday, that the times apply to.  This is the default for that day and can be overidden by the "hasDate" property.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#dayofWeek">ic:dayofWeek</a>
    /// </summary>
    let dayofWeek = _prefixId.prefix "dayofWeek"
    let emailDataProperty = _prefixId.prefix "emailDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : hasAddress links any class to the Address class.</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddress">ic:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : has Address Type</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddressType">ic:hasAddressType</a>
    /// </summary>
    let hasAddressType = _prefixId.prefix "hasAddressType"
    /// <summary>
    ///   <para>rdfs:label : has Area Code</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasAreaCode">ic:hasAreaCode</a>
    /// </summary>
    let hasAreaCode = _prefixId.prefix "hasAreaCode"
    /// <summary>
    ///   <para>dcterms:description : The building where the address is located.  Often used in countries like England, India and Japan.</para>
    ///   <para>rdfs:label : has Building</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasBuilding">ic:hasBuilding</a>
    /// </summary>
    let hasBuilding = _prefixId.prefix "hasBuilding"
    /// <summary>
    ///   <para>dcterms:description : has City</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasCity">ic:hasCity</a>
    /// </summary>
    let hasCity = _prefixId.prefix "hasCity"
    /// <summary>
    ///   <para>dcterms:description : The section of the city where the address is located.  Often used in countries like England, India and Japan.</para>
    ///   <para>rdfs:label : has City Section</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasCitySection">ic:hasCitySection</a>
    /// </summary>
    let hasCitySection = _prefixId.prefix "hasCitySection"
    /// <summary>
    ///   <para>rdfs:label : has Closing Time</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasClosingTime">ic:hasClosingTime</a>
    /// </summary>
    let hasClosingTime = _prefixId.prefix "hasClosingTime"
    let hasContactDataProperty = _prefixId.prefix "hasContactDataProperty"
    /// <summary>
    ///   <para>rdfs:label : has Country</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountry">ic:hasCountry</a>
    /// </summary>
    let hasCountry = _prefixId.prefix "hasCountry"
    /// <summary>
    ///   <para>rdfs:label : has Country Code</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountryCode">ic:hasCountryCode</a>
    /// </summary>
    let hasCountryCode = _prefixId.prefix "hasCountryCode"
    /// <summary>
    ///   <para>dcterms:description : Specifies the opening and closing times for a specific date.  For example, used to provide times for a holiday which deviates from the norm.</para>
    ///   <para>rdfs:label : has Date</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasDate">ic:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>rdfs:label : has Email</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasEmail">ic:hasEmail</a>
    /// </summary>
    let hasEmail = _prefixId.prefix "hasEmail"
    /// <summary>
    ///   <para>rdfs:label : has Geo Coordinates</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasGeoCoordinates">ic:hasGeoCoordinates</a>
    /// </summary>
    let hasGeoCoordinates = _prefixId.prefix "hasGeoCoordinates"
    /// <summary>
    ///   <para>dcterms:description : Closet street intersection for the organization.</para>
    ///   <para>rdfs:label : has Location</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasLocation">ic:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has Opening Time</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasOpeningTime">ic:hasOpeningTime</a>
    /// </summary>
    let hasOpeningTime = _prefixId.prefix "hasOpeningTime"
    /// <summary>
    ///   <para>rdfs:label : has Operating Hours</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasOperatingHours">ic:hasOperatingHours</a>
    /// </summary>
    let hasOperatingHours = _prefixId.prefix "hasOperatingHours"
    /// <summary>
    ///   <para>rdfs:label : has Personal Email</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasPersonalEmail">ic:hasPersonalEmail</a>
    /// </summary>
    let hasPersonalEmail = _prefixId.prefix "hasPersonalEmail"
    /// <summary>
    ///   <para>rdfs:label : has Phone Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneNumber">ic:hasPhoneNumber</a>
    /// </summary>
    let hasPhoneNumber = _prefixId.prefix "hasPhoneNumber"
    /// <summary>
    ///   <para>rdfs:label : has Phone Type</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneType">ic:hasPhoneType</a>
    /// </summary>
    let hasPhoneType = _prefixId.prefix "hasPhoneType"
    /// <summary>
    ///   <para>rdfs:label : has Postal Code</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasPostalCode">ic:hasPostalCode</a>
    /// </summary>
    let hasPostalCode = _prefixId.prefix "hasPostalCode"
    /// <summary>
    ///   <para>rdfs:label : has State</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasState">ic:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>rdfs:label : has Street</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreet">ic:hasStreet</a>
    /// </summary>
    let hasStreet = _prefixId.prefix "hasStreet"
    /// <summary>
    ///   <para>rdfs:label : has Street Direction</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetDirection">ic:hasStreetDirection</a>
    /// </summary>
    let hasStreetDirection = _prefixId.prefix "hasStreetDirection"
    /// <summary>
    ///   <para>rdfs:label : has Street Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetNumber">ic:hasStreetNumber</a>
    /// </summary>
    let hasStreetNumber = _prefixId.prefix "hasStreetNumber"
    /// <summary>
    ///   <para>rdfs:label : has Street Type</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetType">ic:hasStreetType</a>
    /// </summary>
    let hasStreetType = _prefixId.prefix "hasStreetType"
    /// <summary>
    ///   <para>rdfs:label : has Telephone</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasTelephone">ic:hasTelephone</a>
    /// </summary>
    let hasTelephone = _prefixId.prefix "hasTelephone"
    /// <summary>
    ///   <para>rdfs:label : has Unit Number</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasUnitNumber">ic:hasUnitNumber</a>
    /// </summary>
    let hasUnitNumber = _prefixId.prefix "hasUnitNumber"
    /// <summary>
    ///   <para>rdfs:label : has Web Site</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasWebSite">ic:hasWebSite</a>
    /// </summary>
    let hasWebSite = _prefixId.prefix "hasWebSite"
    /// <summary>
    ///   <para>rdfs:label : has Work Email</para>
    ///   <a href="http://ontology.eil.utoronto.ca/icontact.owl#hasWorkEmail">ic:hasWorkEmail</a>
    /// </summary>
    let hasWorkEmail = _prefixId.prefix "hasWorkEmail"
    let iContactThing = _prefixId.prefix "iContactThing"
    let operatingDataProperty = _prefixId.prefix "operatingDataProperty"
    let telephoneDataProperty = _prefixId.prefix "telephoneDataProperty"
