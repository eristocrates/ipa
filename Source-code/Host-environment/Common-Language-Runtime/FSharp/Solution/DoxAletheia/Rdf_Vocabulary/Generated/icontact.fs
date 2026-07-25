namespace http.ontology.eil.utoronto.ca.icontact.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module icontact =
    let _namespace_iri = Namespace_Iri icontact |> NamespaceIRI
    /// <summary>
    ///   <para>icontact:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Address">http://ontology.eil.utoronto.ca/icontact.owl#Address</seealso>
    let Address = Prefixed_Name(icontact, "Address") |> PrefixedName
    /// <summary>
    ///   <para>icontact:AddressType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Type</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#AddressType">http://ontology.eil.utoronto.ca/icontact.owl#AddressType</seealso>
    let AddressType = Prefixed_Name(icontact, "AddressType") |> PrefixedName
    /// <summary>
    ///   <para>icontact:DaysOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Days of the Week</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#DaysOfWeek">http://ontology.eil.utoronto.ca/icontact.owl#DaysOfWeek</seealso>
    let DaysOfWeek = Prefixed_Name(icontact, "DaysOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>icontact:PhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Phone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneNumber">http://ontology.eil.utoronto.ca/icontact.owl#PhoneNumber</seealso>
    let PhoneNumber = Prefixed_Name(icontact, "PhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:StreetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Street Type</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#StreetType">http://ontology.eil.utoronto.ca/icontact.owl#StreetType</seealso>
    let StreetType = Prefixed_Name(icontact, "StreetType") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasCitySection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has City Section</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasCitySection">http://ontology.eil.utoronto.ca/icontact.owl#hasCitySection</seealso>
    let hasCitySection = Prefixed_Name(icontact, "hasCitySection") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Country</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountry">http://ontology.eil.utoronto.ca/icontact.owl#hasCountry</seealso>
    let hasCountry = Prefixed_Name(icontact, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>icontact:iContactThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#iContactThing">http://ontology.eil.utoronto.ca/icontact.owl#iContactThing</seealso>
    let iContactThing = Prefixed_Name(icontact, "iContactThing") |> PrefixedName

    /// <summary>
    ///   <para>icontact:hasStreetDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Street Direction</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetDirection">http://ontology.eil.utoronto.ca/icontact.owl#hasStreetDirection</seealso>
    let hasStreetDirection =
        Prefixed_Name(icontact, "hasStreetDirection") |> PrefixedName

    /// <summary>
    ///   <para>icontact:hasPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Postal Code</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasPostalCode">http://ontology.eil.utoronto.ca/icontact.owl#hasPostalCode</seealso>
    let hasPostalCode = Prefixed_Name(icontact, "hasPostalCode") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>icontact:DaysOfWeek</para>
    ///
    /// labels<para>Sunday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Sunday">http://ontology.eil.utoronto.ca/icontact.owl#Sunday</seealso>
    let Sunday = Prefixed_Name(icontact, "Sunday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>icontact:DaysOfWeek</para>
    ///
    /// labels<para>Thursday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Thursday">http://ontology.eil.utoronto.ca/icontact.owl#Thursday</seealso>
    let Thursday = Prefixed_Name(icontact, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>icontact:DaysOfWeek</para>
    ///
    /// labels<para>Tuesday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Tuesday">http://ontology.eil.utoronto.ca/icontact.owl#Tuesday</seealso>
    let Tuesday = Prefixed_Name(icontact, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:WorkAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Work Address</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#WorkAddress">http://ontology.eil.utoronto.ca/icontact.owl#WorkAddress</seealso>
    let WorkAddress = Prefixed_Name(icontact, "WorkAddress") |> PrefixedName

    /// <summary>
    ///   <para>icontact:addressDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#addressDataProperty">http://ontology.eil.utoronto.ca/icontact.owl#addressDataProperty</seealso>
    let addressDataProperty =
        Prefixed_Name(icontact, "addressDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>icontact:hasContactDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasContactDataProperty">http://ontology.eil.utoronto.ca/icontact.owl#hasContactDataProperty</seealso>
    let hasContactDataProperty =
        Prefixed_Name(icontact, "hasContactDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>icontact:addressProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#addressProperty">http://ontology.eil.utoronto.ca/icontact.owl#addressProperty</seealso>
    let addressProperty = Prefixed_Name(icontact, "addressProperty") |> PrefixedName

    /// <summary>
    ///   <para>icontact:telephoneDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#telephoneDataProperty">http://ontology.eil.utoronto.ca/icontact.owl#telephoneDataProperty</seealso>
    let telephoneDataProperty =
        Prefixed_Name(icontact, "telephoneDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>icontact:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Date</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasDate">http://ontology.eil.utoronto.ca/icontact.owl#hasDate</seealso>
    let hasDate = Prefixed_Name(icontact, "hasDate") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Email</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasEmail">http://ontology.eil.utoronto.ca/icontact.owl#hasEmail</seealso>
    let hasEmail = Prefixed_Name(icontact, "hasEmail") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasGeoCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Geo Coordinates</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasGeoCoordinates">http://ontology.eil.utoronto.ca/icontact.owl#hasGeoCoordinates</seealso>
    let hasGeoCoordinates = Prefixed_Name(icontact, "hasGeoCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasOperatingHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Operating Hours</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasOperatingHours">http://ontology.eil.utoronto.ca/icontact.owl#hasOperatingHours</seealso>
    let hasOperatingHours = Prefixed_Name(icontact, "hasOperatingHours") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasPersonalEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Personal Email</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasPersonalEmail">http://ontology.eil.utoronto.ca/icontact.owl#hasPersonalEmail</seealso>
    let hasPersonalEmail = Prefixed_Name(icontact, "hasPersonalEmail") |> PrefixedName
    /// <summary>
    ///   <para>icontact:TollFreeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Toll  Free Telephone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreeNumber">http://ontology.eil.utoronto.ca/icontact.owl#TollFreeNumber</seealso>
    let TollFreeNumber = Prefixed_Name(icontact, "TollFreeNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>icontact:DaysOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Wednesday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Wednesday">http://ontology.eil.utoronto.ca/icontact.owl#Wednesday</seealso>
    let Wednesday = Prefixed_Name(icontact, "Wednesday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasCity">http://ontology.eil.utoronto.ca/icontact.owl#hasCity</seealso>
    let hasCity = Prefixed_Name(icontact, "hasCity") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasStreet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Street</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreet">http://ontology.eil.utoronto.ca/icontact.owl#hasStreet</seealso>
    let hasStreet = Prefixed_Name(icontact, "hasStreet") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasStreetNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Street Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetNumber">http://ontology.eil.utoronto.ca/icontact.owl#hasStreetNumber</seealso>
    let hasStreetNumber = Prefixed_Name(icontact, "hasStreetNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasStreetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Street Type</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasStreetType">http://ontology.eil.utoronto.ca/icontact.owl#hasStreetType</seealso>
    let hasStreetType = Prefixed_Name(icontact, "hasStreetType") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Home</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Home Address</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Home">http://ontology.eil.utoronto.ca/icontact.owl#Home</seealso>
    let Home = Prefixed_Name(icontact, "Home") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>WorkAddress</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Work">http://ontology.eil.utoronto.ca/icontact.owl#Work</seealso>
    let Work = Prefixed_Name(icontact, "Work") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Boulevard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Boulevard</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Boulevard">http://ontology.eil.utoronto.ca/icontact.owl#Boulevard</seealso>
    let Boulevard = Prefixed_Name(icontact, "Boulevard") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasPhoneType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Phone Type</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneType">http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneType</seealso>
    let hasPhoneType = Prefixed_Name(icontact, "hasPhoneType") |> PrefixedName
    /// <summary>
    ///   <para>icontact:CottageAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cottage Address</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#CottageAddress">http://ontology.eil.utoronto.ca/icontact.owl#CottageAddress</seealso>
    let CottageAddress = Prefixed_Name(icontact, "CottageAddress") |> PrefixedName
    /// <summary>
    ///   <para>icontact:HoursOfOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#HoursOfOperation">http://ontology.eil.utoronto.ca/icontact.owl#HoursOfOperation</seealso>
    let HoursOfOperation = Prefixed_Name(icontact, "HoursOfOperation") |> PrefixedName
    /// <summary>
    ///   <para>icontact:StreetDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Street Direction</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#StreetDirection">http://ontology.eil.utoronto.ca/icontact.owl#StreetDirection</seealso>
    let StreetDirection = Prefixed_Name(icontact, "StreetDirection") |> PrefixedName
    /// <summary>
    ///   <para>icontact:PhoneType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Phone Type</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#PhoneType">http://ontology.eil.utoronto.ca/icontact.owl#PhoneType</seealso>
    let PhoneType = Prefixed_Name(icontact, "PhoneType") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Building</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasBuilding">http://ontology.eil.utoronto.ca/icontact.owl#hasBuilding</seealso>
    let hasBuilding = Prefixed_Name(icontact, "hasBuilding") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasUnitNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Unit Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasUnitNumber">http://ontology.eil.utoronto.ca/icontact.owl#hasUnitNumber</seealso>
    let hasUnitNumber = Prefixed_Name(icontact, "hasUnitNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:FaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fax Telephone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#FaxNumber">http://ontology.eil.utoronto.ca/icontact.owl#FaxNumber</seealso>
    let FaxNumber = Prefixed_Name(icontact, "FaxNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasOpeningTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Opening Time</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasOpeningTime">http://ontology.eil.utoronto.ca/icontact.owl#hasOpeningTime</seealso>
    let hasOpeningTime = Prefixed_Name(icontact, "hasOpeningTime") |> PrefixedName
    /// <summary>
    ///   <para>icontact:OperatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#OperatingProperty">http://ontology.eil.utoronto.ca/icontact.owl#OperatingProperty</seealso>
    let OperatingProperty = Prefixed_Name(icontact, "OperatingProperty") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Country Code</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasCountryCode">http://ontology.eil.utoronto.ca/icontact.owl#hasCountryCode</seealso>
    let hasCountryCode = Prefixed_Name(icontact, "hasCountryCode") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has State</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasState">http://ontology.eil.utoronto.ca/icontact.owl#hasState</seealso>
    let hasState = Prefixed_Name(icontact, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasTelephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Telephone</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasTelephone">http://ontology.eil.utoronto.ca/icontact.owl#hasTelephone</seealso>
    let hasTelephone = Prefixed_Name(icontact, "hasTelephone") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasWebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Web Site</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasWebSite">http://ontology.eil.utoronto.ca/icontact.owl#hasWebSite</seealso>
    let hasWebSite = Prefixed_Name(icontact, "hasWebSite") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Cottage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Cottage Address</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Cottage">http://ontology.eil.utoronto.ca/icontact.owl#Cottage</seealso>
    let Cottage = Prefixed_Name(icontact, "Cottage") |> PrefixedName
    /// <summary>
    ///   <para>icontact:CellNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mobile Telephone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#CellNumber">http://ontology.eil.utoronto.ca/icontact.owl#CellNumber</seealso>
    let CellNumber = Prefixed_Name(icontact, "CellNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Circle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Circle</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Circle">http://ontology.eil.utoronto.ca/icontact.owl#Circle</seealso>
    let Circle = Prefixed_Name(icontact, "Circle") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasWorkEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Work Email</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasWorkEmail">http://ontology.eil.utoronto.ca/icontact.owl#hasWorkEmail</seealso>
    let hasWorkEmail = Prefixed_Name(icontact, "hasWorkEmail") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Avenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Avenue</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Avenue">http://ontology.eil.utoronto.ca/icontact.owl#Avenue</seealso>
    let Avenue = Prefixed_Name(icontact, "Avenue") |> PrefixedName
    /// <summary>
    ///   <para>icontact:CellPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Cell Phone</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#CellPhone">http://ontology.eil.utoronto.ca/icontact.owl#CellPhone</seealso>
    let CellPhone = Prefixed_Name(icontact, "CellPhone") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Crescent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Crescent</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Crescent">http://ontology.eil.utoronto.ca/icontact.owl#Crescent</seealso>
    let Crescent = Prefixed_Name(icontact, "Crescent") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>icontact:DaysOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Friday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Friday">http://ontology.eil.utoronto.ca/icontact.owl#Friday</seealso>
    let Friday = Prefixed_Name(icontact, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:HomeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Home Telephone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#HomeNumber">http://ontology.eil.utoronto.ca/icontact.owl#HomeNumber</seealso>
    let HomeNumber = Prefixed_Name(icontact, "HomeNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:dayofWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the day of the week, e.g., Monday, that the times apply to.  This is the default for that day and can be overidden by the "hasDate" property.</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#dayofWeek">http://ontology.eil.utoronto.ca/icontact.owl#dayofWeek</seealso>
    let dayofWeek = Prefixed_Name(icontact, "dayofWeek") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>icontact:DaysOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Monday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Monday">http://ontology.eil.utoronto.ca/icontact.owl#Monday</seealso>
    let Monday = Prefixed_Name(icontact, "Monday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasPhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Phone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneNumber">http://ontology.eil.utoronto.ca/icontact.owl#hasPhoneNumber</seealso>
    let hasPhoneNumber = Prefixed_Name(icontact, "hasPhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasAreaCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Area Code</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasAreaCode">http://ontology.eil.utoronto.ca/icontact.owl#hasAreaCode</seealso>
    let hasAreaCode = Prefixed_Name(icontact, "hasAreaCode") |> PrefixedName
    /// <summary>
    ///   <para>icontact:TollFreePhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Toll Free Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#TollFreePhone">http://ontology.eil.utoronto.ca/icontact.owl#TollFreePhone</seealso>
    let TollFreePhone = Prefixed_Name(icontact, "TollFreePhone") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>icontact:DaysOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Saturday</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Saturday">http://ontology.eil.utoronto.ca/icontact.owl#Saturday</seealso>
    let Saturday = Prefixed_Name(icontact, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>icontact:SchemaOrgThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#SchemaOrgThing">http://ontology.eil.utoronto.ca/icontact.owl#SchemaOrgThing</seealso>
    let SchemaOrgThing = Prefixed_Name(icontact, "SchemaOrgThing") |> PrefixedName
    /// <summary>
    ///   <para>icontact:South</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>South</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#South">http://ontology.eil.utoronto.ca/icontact.owl#South</seealso>
    let South = Prefixed_Name(icontact, "South") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasAddressType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Address Type</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddressType">http://ontology.eil.utoronto.ca/icontact.owl#hasAddressType</seealso>
    let hasAddressType = Prefixed_Name(icontact, "hasAddressType") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Drive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Drive</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Drive">http://ontology.eil.utoronto.ca/icontact.owl#Drive</seealso>
    let Drive = Prefixed_Name(icontact, "Drive") |> PrefixedName
    /// <summary>
    ///   <para>icontact:FaxPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Fax Line</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#FaxPhone">http://ontology.eil.utoronto.ca/icontact.owl#FaxPhone</seealso>
    let FaxPhone = Prefixed_Name(icontact, "FaxPhone") |> PrefixedName
    /// <summary>
    ///   <para>icontact:East</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>East</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#East">http://ontology.eil.utoronto.ca/icontact.owl#East</seealso>
    let East = Prefixed_Name(icontact, "East") |> PrefixedName
    /// <summary>
    ///   <para>icontact:HomeAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Home Address</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#HomeAddress">http://ontology.eil.utoronto.ca/icontact.owl#HomeAddress</seealso>
    let HomeAddress = Prefixed_Name(icontact, "HomeAddress") |> PrefixedName
    /// <summary>
    ///   <para>icontact:HomePhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Home Phone</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#HomePhone">http://ontology.eil.utoronto.ca/icontact.owl#HomePhone</seealso>
    let HomePhone = Prefixed_Name(icontact, "HomePhone") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasClosingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Closing Time</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasClosingTime">http://ontology.eil.utoronto.ca/icontact.owl#hasClosingTime</seealso>
    let hasClosingTime = Prefixed_Name(icontact, "hasClosingTime") |> PrefixedName
    /// <summary>
    ///   <para>icontact:North</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>North</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#North">http://ontology.eil.utoronto.ca/icontact.owl#North</seealso>
    let North = Prefixed_Name(icontact, "North") |> PrefixedName
    /// <summary>
    ///   <para>icontact:contactProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#contactProperty">http://ontology.eil.utoronto.ca/icontact.owl#contactProperty</seealso>
    let contactProperty = Prefixed_Name(icontact, "contactProperty") |> PrefixedName
    /// <summary>
    ///   <para>icontact:WorkPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Work Phone</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#WorkPhone">http://ontology.eil.utoronto.ca/icontact.owl#WorkPhone</seealso>
    let WorkPhone = Prefixed_Name(icontact, "WorkPhone") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Street</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Street</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Street">http://ontology.eil.utoronto.ca/icontact.owl#Street</seealso>
    let Street = Prefixed_Name(icontact, "Street") |> PrefixedName
    /// <summary>
    ///   <para>icontact:West</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>West</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#West">http://ontology.eil.utoronto.ca/icontact.owl#West</seealso>
    let West = Prefixed_Name(icontact, "West") |> PrefixedName
    /// <summary>
    ///   <para>icontact:Road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Road</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#Road">http://ontology.eil.utoronto.ca/icontact.owl#Road</seealso>
    let Road = Prefixed_Name(icontact, "Road") |> PrefixedName
    /// <summary>
    ///   <para>icontact:WorkNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Work Telephone Number</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#WorkNumber">http://ontology.eil.utoronto.ca/icontact.owl#WorkNumber</seealso>
    let WorkNumber = Prefixed_Name(icontact, "WorkNumber") |> PrefixedName
    /// <summary>
    ///   <para>icontact:emailDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#emailDataProperty">http://ontology.eil.utoronto.ca/icontact.owl#emailDataProperty</seealso>
    let emailDataProperty = Prefixed_Name(icontact, "emailDataProperty") |> PrefixedName
    /// <summary>
    ///   <para>icontact:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasAddress links any class to the Address class.</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasAddress">http://ontology.eil.utoronto.ca/icontact.owl#hasAddress</seealso>
    let hasAddress = Prefixed_Name(icontact, "hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>icontact:operatingDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#operatingDataProperty">http://ontology.eil.utoronto.ca/icontact.owl#operatingDataProperty</seealso>
    let operatingDataProperty =
        Prefixed_Name(icontact, "operatingDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>icontact:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has Location</para></remarks>
    /// <seealso href="http://ontology.eil.utoronto.ca/icontact.owl#hasLocation">http://ontology.eil.utoronto.ca/icontact.owl#hasLocation</seealso>
    let hasLocation = Prefixed_Name(icontact, "hasLocation") |> PrefixedName
