#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/oslo/ns/localgov#" "oslo"

    /// <summary>
    ///   <para>rdfs:label : BasicAddress</para>
    ///   <para>rdfs:comment : An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information^^xsd:string</para>
    ///   <para>dcterms:identifier : oslo:BasicAddress^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#BasicAddress">oslo:BasicAddress</a>
    /// </summary>
    let BasicAddress = _prefixId.prefix "BasicAddress"
    /// <summary>
    ///   <para>rdfs:label : Building</para>
    ///   <para>rdfs:comment : Information related to a Building</para>
    ///   <para>vann:usageNote : Use this class to represent information about a building.</para>
    ///   <para>dcterms:identifier : oslo:Building^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Building">oslo:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : ExtendedAddress</para>
    ///   <para>rdfs:comment : An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information^^xsd:string</para>
    ///   <para>dcterms:identifier : oslo:ExtendedAddress^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#ExtendedAddress">oslo:ExtendedAddress</a>
    /// </summary>
    let ExtendedAddress = _prefixId.prefix "ExtendedAddress"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:Membership^^xsd:string</para>
    ///   <para>rdfs:comment : This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities.</para>
    ///   <para>rdfs:label : Membership</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Membership">oslo:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:Organization^^xsd:string</para>
    ///   <para>rdfs:comment : This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities.</para>
    ///   <para>rdfs:label : Organization</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Organization">oslo:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:OrganizationRelation^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between two organizations</para>
    ///   <para>rdfs:label : OrganizationnRelation</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#OrganizationRelation">oslo:OrganizationRelation</a>
    /// </summary>
    let OrganizationRelation = _prefixId.prefix "OrganizationRelation"
    /// <summary>
    ///   <para>rdfs:label : Parcel</para>
    ///   <para>rdfs:comment : Information related to a Parcel Address or Label</para>
    ///   <para>vann:usageNote : Use this class to contain the parcels in.</para>
    ///   <para>dcterms:identifier : oslo:Parcel^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Parcel">oslo:Parcel</a>
    /// </summary>
    let Parcel = _prefixId.prefix "Parcel"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:Permission^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a the permission of a role. Should be linked with a formal rule.</para>
    ///   <para>rdfs:label : Permission</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Permission">oslo:Permission</a>
    /// </summary>
    let Permission = _prefixId.prefix "Permission"
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:PersonRelation^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between two persons</para>
    ///   <para>rdfs:label : PersonRelation</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#PersonRelation">oslo:PersonRelation</a>
    /// </summary>
    let PersonRelation = _prefixId.prefix "PersonRelation"
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:Relation^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between two agents</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Relation">oslo:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Residence Object</para>
    ///   <para>rdfs:comment : This is the key class for the OSLO Location Vocabulary and represents a
    ///       location that is linked with an address and/or a building with parcel(s).</para>
    ///   <para>vann:usageNote : This is the key class for the Location Core Vocabulary and represents any location that has an address, a building and a parcel.</para>
    ///   <para>dcterms:identifier : oslo:ResidenceObject^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#ResidenceObject">oslo:ResidenceObject</a>
    /// </summary>
    let ResidenceObject = _prefixId.prefix "ResidenceObject"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:Role^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a role that a Person or other Agent can take in an public service. Instances of this class describe the abstract role; to denote a specific instance of a person playing that role in a specific public service use an instance of `Permission` that is linked with the formal rules `Rule`.</para>
    ///   <para>rdfs:label : Role</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Role">oslo:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:Status^^xsd:string</para>
    ///   <para>rdfs:comment : Status of Public Service</para>
    ///   <para>rdfs:label : Status</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#Status">oslo:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:address^^xsd:string</para>
    ///   <para>rdfs:comment : Parcel linked to a building or a residence object.</para>
    ///   <para>rdfs:label : addres </para>
    ///   <a href="http://purl.org/oslo/ns/localgov#address">oslo:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:label : address area</para>
    ///   <para>rdfs:comment : The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of oslo:addressArea is oslo:Address.</para>
    ///   <para>dcterms:identifier : oslo:addressArea^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#addressArea">oslo:addressArea</a>
    /// </summary>
    let addressArea = _prefixId.prefix "addressArea"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:addressId^^xsd:string</para>
    ///   <para>rdfs:comment : The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:addressId is locn:Address.</para>
    ///   <para>rdfs:label : address ID</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#addressId">oslo:addressId</a>
    /// </summary>
    let addressId = _prefixId.prefix "addressId"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:adminUnit^^xsd:string</para>
    ///   <para>rdfs:comment : Admin Unit linked to an address</para>
    ///   <para>rdfs:label : Administrative Unit</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#adminUnit">oslo:adminUnit</a>
    /// </summary>
    let adminUnit = _prefixId.prefix "adminUnit"
    /// <summary>
    ///   <para>rdfs:label : authentic location</para>
    ///   <para>rdfs:comment : Points to a authentic location</para>
    ///   <para>dcterms:identifier : oslo:invoiceLocation^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#authenticLocation">oslo:authenticLocation</a>
    /// </summary>
    let authenticLocation = _prefixId.prefix "authenticLocation"
    /// <summary>
    ///   <para>rdfs:label : availableAt</para>
    ///   <para>rdfs:comment : Points to a residence</para>
    ///   <para>dcterms:identifier : oslo:availableAt^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#availableAt">oslo:availableAt</a>
    /// </summary>
    let availableAt = _prefixId.prefix "availableAt"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:building^^xsd:string</para>
    ///   <para>rdfs:comment : Building linked to a residence object.</para>
    ///   <para>rdfs:label : building </para>
    ///   <a href="http://purl.org/oslo/ns/localgov#building">oslo:building</a>
    /// </summary>
    let building = _prefixId.prefix "building"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:buldingId^^xsd:string</para>
    ///   <para>rdfs:comment : The concept of adding a globally unique identifier for each instance of a building is a crucial part of the OSLO data spec. The domain of oslo:buildingId is oslo:Building.</para>
    ///   <para>rdfs:label : building ID</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#buildingId">oslo:buildingId</a>
    /// </summary>
    let buildingId = _prefixId.prefix "buildingId"
    /// <summary>
    ///   <para>rdfs:label : civil classs</para>
    ///   <para>rdfs:comment : The range of place of death is a code.</para>
    ///   <para>dcterms:identifier : oslo:civilClass^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#civilClass">oslo:civilClass</a>
    /// </summary>
    let civilClass = _prefixId.prefix "civilClass"
    /// <summary>
    ///   <para>rdfs:comment : Depicts the contact information for a person, organizaton or membership</para>
    ///   <para>rdfs:label : contact information</para>
    ///   <para>dcterms:identifier : oslo:contact^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#contact">oslo:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>rdfs:label : country</para>
    ///   <para>rdfs:comment : The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;.^^xsd:string</para>
    ///   <para>vann:usageNote : Best practice is to use the ISO 3166-1 code but if this is inappropriate for the context, country names should be provided in a consistent manner to reduce ambiguity. For example, either write 'United Kingdom' or 'UK' consistently throughout the data set and avoid mixing the two.    </para>
    ///   <para>dcterms:identifier : oslo:country^^xsd:stringdcterms:identifier : urn:x-inspire:specification:gmlas:BaseTypes:3.2:adminUnit^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#country">oslo:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : delivery location</para>
    ///   <para>rdfs:comment : Points to a delivery location</para>
    ///   <para>dcterms:identifier : oslo:deliveryLocation^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#deliveryLocation">oslo:deliveryLocation</a>
    /// </summary>
    let deliveryLocation = _prefixId.prefix "deliveryLocation"
    /// <summary>
    ///   <para>rdfs:label : domicile</para>
    ///   <para>rdfs:comment : The range of domicile is ResidenceObject.</para>
    ///   <para>dcterms:identifier : oslo:domicile^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#domicile">oslo:domicile</a>
    /// </summary>
    let domicile = _prefixId.prefix "domicile"
    /// <summary>
    ///   <para>rdfs:label : date of establishment</para>
    ///   <para>rdfs:comment : Date of establishment of an organization</para>
    ///   <para>dcterms:identifier : oslo:establishmentDate^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#establishmentDate">oslo:establishmentDate</a>
    /// </summary>
    let establishmentDate = _prefixId.prefix "establishmentDate"
    /// <summary>
    ///   <para>dcterms:identifier : locn:address^^xsd:string</para>
    ///   <para>rdfs:label : extended address</para>
    ///   <para>rdfs:comment : The oslo:extended_address property relationship associates an &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#oslo:ExtendedAddress"&gt;Extended Address&lt;/a&gt; with a &lt;a ="#locn:Address"&gt;Address&lt;/a&gt; Class^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#extended_address">oslo:extended_address</a>
    /// </summary>
    let extended_address = _prefixId.prefix "extended_address"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:extended_addressId^^xsd:string</para>
    ///   <para>rdfs:comment : The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:extended_addressId is oslo:ExtendedAddress.</para>
    ///   <para>rdfs:label : extended address ID</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#extended_addressId">oslo:extended_addressId</a>
    /// </summary>
    let extended_addressId = _prefixId.prefix "extended_addressId"
    /// <summary>
    ///   <para>rdfs:comment : from relation</para>
    ///   <para>rdfs:label : from</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#fromOrganization">oslo:fromOrganization</a>
    /// </summary>
    let fromOrganization = _prefixId.prefix "fromOrganization"
    /// <summary>
    ///   <para>rdfs:comment : from relation</para>
    ///   <para>rdfs:label : from</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#fromPerson">oslo:fromPerson</a>
    /// </summary>
    let fromPerson = _prefixId.prefix "fromPerson"
    /// <summary>
    ///   <para>rdfs:label : full address</para>
    ///   <para>rdfs:comment : The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address.</para>
    ///   <para>dcterms:identifier : oslo:fullAddress^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#fullAddress">oslo:fullAddress</a>
    /// </summary>
    let fullAddress = _prefixId.prefix "fullAddress"
    /// <summary>
    ///   <para>rdfs:label : KBO function</para>
    ///   <para>rdfs:comment : A KBO Funtion</para>
    ///   <para>dcterms:identifier : oslo:function^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#function">oslo:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"
    /// <summary>
    ///   <para>rdfs:label : KBO function phase</para>
    ///   <para>rdfs:comment : A KBO Funtionphase</para>
    ///   <para>dcterms:identifier : oslo:functionPhase^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#functionPhase">oslo:functionPhase</a>
    /// </summary>
    let functionPhase = _prefixId.prefix "functionPhase"
    /// <summary>
    ///   <para>rdfs:comment : This very general property links an Public Service to a Role.</para>
    ///   <para>rdfs:label : provides role</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#hasActor">oslo:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:comment : Permission belonging to a Role.</para>
    ///   <para>rdfs:label : has permission</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#hasPermission">oslo:hasPermission</a>
    /// </summary>
    let hasPermission = _prefixId.prefix "hasPermission"
    /// <summary>
    ///   <para>rdfs:label : invoice location</para>
    ///   <para>rdfs:comment : Points to a invoice location</para>
    ///   <para>dcterms:identifier : oslo:invoiceLocation^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#invoiceLocation">oslo:invoiceLocation</a>
    /// </summary>
    let invoiceLocation = _prefixId.prefix "invoiceLocation"
    /// <summary>
    ///   <para>rdfs:label : organization is a branch or not</para>
    ///   <para>rdfs:comment : Depicts if organization is branch of another organization</para>
    ///   <para>dcterms:identifier : oslo:isBranch^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#isBranch">oslo:isBranch</a>
    /// </summary>
    let isBranch = _prefixId.prefix "isBranch"
    /// <summary>
    ///   <para>rdfs:label : kind</para>
    ///   <para>rdfs:comment : Kind of organization, natural person or legal person</para>
    ///   <para>dcterms:identifier : oslo:kind^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#kind">oslo:kind</a>
    /// </summary>
    let kind = _prefixId.prefix "kind"
    /// <summary>
    ///   <para>rdfs:label : nobelity title</para>
    ///   <para>rdfs:comment : Legal Cohabetitation</para>
    ///   <para>dcterms:identifier : oslo:legalCohabetation^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#legalCohabetation">oslo:legalCohabetation</a>
    /// </summary>
    let legalCohabetation = _prefixId.prefix "legalCohabetation"
    /// <summary>
    ///   <para>rdfs:label : legal form code</para>
    ///   <para>rdfs:comment : A Legal Form Code</para>
    ///   <para>dcterms:identifier : oslo:legalFormCode^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#legalFormCode">oslo:legalFormCode</a>
    /// </summary>
    let legalFormCode = _prefixId.prefix "legalFormCode"
    /// <summary>
    ///   <para>rdfs:label : legal incompetence</para>
    ///   <para>rdfs:comment : Legal Incompetence</para>
    ///   <para>dcterms:identifier : oslo:legalIncompetence^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#legalIncompetence">oslo:legalIncompetence</a>
    /// </summary>
    let legalIncompetence = _prefixId.prefix "legalIncompetence"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:locatorDesignator^^xsd:string</para>
    ///   <para>rdfs:comment : A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators. The domain of oslo:locatorDesignator is oslo:Address.</para>
    ///   <para>rdfs:label : locator designator</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#locatorDesignator">oslo:locatorDesignator</a>
    /// </summary>
    let locatorDesignator = _prefixId.prefix "locatorDesignator"
    /// <summary>
    ///   <para>rdfs:label : locator name</para>
    ///   <para>rdfs:comment : Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building. The domain of oslo:locatorName is oslo:ExtendedAddress.</para>
    ///   <para>dcterms:identifier : oslo:locatorName^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#locatorName">oslo:locatorName</a>
    /// </summary>
    let locatorName = _prefixId.prefix "locatorName"
    /// <summary>
    ///   <para>rdfs:label : locator number</para>
    ///   <para>rdfs:comment : A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). This is typically an identification for the locator in the thoroughfare (most of the times a street or square).</para>
    ///   <para>dcterms:identifier : oslo:locatorNumber^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#locatorNumber">oslo:locatorNumber</a>
    /// </summary>
    let locatorNumber = _prefixId.prefix "locatorNumber"
    /// <summary>
    ///   <para>rdfs:label : mailing location</para>
    ///   <para>rdfs:comment : Points to a mailing location</para>
    ///   <para>dcterms:identifier : oslo:mailingLocation^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#mailingLocation">oslo:mailingLocation</a>
    /// </summary>
    let mailingLocation = _prefixId.prefix "mailingLocation"
    /// <summary>
    ///   <para>rdfs:label : membership function</para>
    ///   <para>rdfs:comment : Function label of a membership</para>
    ///   <para>dcterms:identifier : oslo:membershipFunction^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#membershipFunction">oslo:membershipFunction</a>
    /// </summary>
    let membershipFunction = _prefixId.prefix "membershipFunction"
    /// <summary>
    ///   <para>rdfs:label : type of membership</para>
    ///   <para>rdfs:comment : Type of a membership</para>
    ///   <para>dcterms:identifier : oslo:membershipType^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#membershipType">oslo:membershipType</a>
    /// </summary>
    let membershipType = _prefixId.prefix "membershipType"
    /// <summary>
    ///   <para>rdfs:label : nobelity title</para>
    ///   <para>rdfs:comment : Nobelity title of a person</para>
    ///   <para>dcterms:identifier : oslo:nobelityTitle^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#nobelityTitle">oslo:nobelityTitle</a>
    /// </summary>
    let nobelityTitle = _prefixId.prefix "nobelityTitle"
    /// <summary>
    ///   <para>rdfs:label : KBO Organisation status</para>
    ///   <para>rdfs:comment : A KBO Organisation status</para>
    ///   <para>dcterms:identifier : oslo:orgStatus^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#orgStatus">oslo:orgStatus</a>
    /// </summary>
    let orgStatus = _prefixId.prefix "orgStatus"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:parcel^^xsd:string</para>
    ///   <para>rdfs:comment : Parcel linked to a building or a residence object.</para>
    ///   <para>rdfs:label : parcel </para>
    ///   <a href="http://purl.org/oslo/ns/localgov#parcel">oslo:parcel</a>
    /// </summary>
    let parcel = _prefixId.prefix "parcel"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:parcelId^^xsd:string</para>
    ///   <para>rdfs:comment : The concept of adding a globally unique identifier for each instance of a parcel is a crucial part of the OSLO data spec. The domain of oslo:parcelId is oslo:Parcel.</para>
    ///   <para>rdfs:label : parcel ID</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#parcelId">oslo:parcelId</a>
    /// </summary>
    let parcelId = _prefixId.prefix "parcelId"
    /// <summary>
    ///   <para>rdfs:label : po box</para>
    ///   <para>rdfs:comment : The Post Office Box number. The domain of oslo:poBox is oslo:ExtendedAddress.</para>
    ///   <para>dcterms:identifier : oslo:poBox^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#poBox">oslo:poBox</a>
    /// </summary>
    let poBox = _prefixId.prefix "poBox"
    /// <summary>
    ///   <para>rdfs:label : type of product</para>
    ///   <para>rdfs:comment : Type of a product</para>
    ///   <para>dcterms:identifier : oslo:productType^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#productType">oslo:productType</a>
    /// </summary>
    let productType = _prefixId.prefix "productType"
    /// <summary>
    ///   <para>rdfs:comment : This very general property links an Public Service to a Role.</para>
    ///   <para>rdfs:label : provides role</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#providesRole">oslo:providesRole</a>
    /// </summary>
    let providesRole = _prefixId.prefix "providesRole"
    /// <summary>
    ///   <para>dcterms:identifier : oslo:province^^xsd:string</para>
    ///   <para>rdfs:comment : The province of the address. The domain of
    ///     oslo:province is oslo:ExtendedAddress and the range is a literal, conceptually
    ///   defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : province</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#province">oslo:province</a>
    /// </summary>
    let province = _prefixId.prefix "province"
    /// <summary>
    ///   <para>rdfs:label : reason shutdown</para>
    ///   <para>rdfs:comment : Reason for shutdown of an organization</para>
    ///   <para>dcterms:identifier : oslo:reasonShutDown^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#reasonShutDown">oslo:reasonShutDown</a>
    /// </summary>
    let reasonShutDown = _prefixId.prefix "reasonShutDown"
    /// <summary>
    ///   <para>rdfs:label : residence</para>
    ///   <para>rdfs:comment : The range of residence is ResidenceObject.</para>
    ///   <para>dcterms:identifier : oslo:residence^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#residence">oslo:residence</a>
    /// </summary>
    let residence = _prefixId.prefix "residence"
    /// <summary>
    ///   <para>rdfs:label : Public Service Result</para>
    ///   <para>rdfs:comment : Result of the public service process.</para>
    ///   <para>dcterms:identifier : oslo:result^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#result">oslo:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>rdfs:label : date of shutdown</para>
    ///   <para>rdfs:comment : Date of shutdown of an organization</para>
    ///   <para>dcterms:identifier : oslo:shutDownDate^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#shutDownDate">oslo:shutDownDate</a>
    /// </summary>
    let shutDownDate = _prefixId.prefix "shutDownDate"
    /// <summary>
    ///   <para>rdfs:label : Public Service Status</para>
    ///   <para>rdfs:comment : Status of the public service process.</para>
    ///   <para>dcterms:identifier : oslo:result^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#status">oslo:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : Statuscode</para>
    ///   <para>rdfs:comment : Statuscode</para>
    ///   <para>dcterms:identifier : oslo:statusCode^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#statusCode">oslo:statusCode</a>
    /// </summary>
    let statusCode = _prefixId.prefix "statusCode"
    /// <summary>
    ///   <para>rdfs:label : type of status</para>
    ///   <para>rdfs:comment : Type of a status</para>
    ///   <para>dcterms:identifier : oslo:statusType^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#statusType">oslo:statusType</a>
    /// </summary>
    let statusType = _prefixId.prefix "statusType"
    /// <summary>
    ///   <para>rdfs:label : Target date</para>
    ///   <para>rdfs:comment : Targetdate for a public service to process its input and produce output</para>
    ///   <para>dcterms:identifier : oslo:targetDate^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#targetDate">oslo:targetDate</a>
    /// </summary>
    let targetDate = _prefixId.prefix "targetDate"
    /// <summary>
    ///   <para>rdfs:comment : to relation</para>
    ///   <para>rdfs:label : to</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#toOrganization">oslo:toOrganization</a>
    /// </summary>
    let toOrganization = _prefixId.prefix "toOrganization"
    /// <summary>
    ///   <para>rdfs:comment : to relation</para>
    ///   <para>rdfs:label : to</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#toPerson">oslo:toPerson</a>
    /// </summary>
    let toPerson = _prefixId.prefix "toPerson"
    /// <summary>
    ///   <para>rdfs:label : validity period</para>
    ///   <para>rdfs:comment : Points to a time interval</para>
    ///   <para>dcterms:identifier : oslo:validityPeriod^^xsd:string</para>
    ///   <a href="http://purl.org/oslo/ns/localgov#validityPeriod">oslo:validityPeriod</a>
    /// </summary>
    let validityPeriod = _prefixId.prefix "validityPeriod"
