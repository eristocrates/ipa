namespace http.purl.org.oslo.ns.localgov.hash

open DoxAletheia

module oslo =
    let _namespace_name = "http://purl.org/oslo/ns/localgov#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information
    /// <see href="http://purl.org/oslo/ns/localgov#BasicAddress"></see></summary>
    let BasicAddress = _prefix "BasicAddress"
    /// <summary>
    /// Information related to a Building
    /// <see href="http://purl.org/oslo/ns/localgov#Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information
    /// <see href="http://purl.org/oslo/ns/localgov#ExtendedAddress"></see></summary>
    let ExtendedAddress = _prefix "ExtendedAddress"
    /// <summary>
    /// This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities.
    /// <see href="http://purl.org/oslo/ns/localgov#Membership"></see></summary>
    let Membership = _prefix "Membership"
    /// <summary>
    /// This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities.
    /// <see href="http://purl.org/oslo/ns/localgov#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// A relation between two organizations
    /// <see href="http://purl.org/oslo/ns/localgov#OrganizationRelation"></see></summary>
    let OrganizationRelation = _prefix "OrganizationRelation"
    /// <summary>
    /// A relation between two agents
    /// <see href="http://purl.org/oslo/ns/localgov#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    /// Information related to a Parcel Address or Label
    /// <see href="http://purl.org/oslo/ns/localgov#Parcel"></see></summary>
    let Parcel = _prefix "Parcel"
    /// <summary>
    /// Denotes a the permission of a role. Should be linked with a formal rule.
    /// <see href="http://purl.org/oslo/ns/localgov#Permission"></see></summary>
    let Permission = _prefix "Permission"
    /// <summary>
    /// A relation between two persons
    /// <see href="http://purl.org/oslo/ns/localgov#PersonRelation"></see></summary>
    let PersonRelation = _prefix "PersonRelation"
    /// <summary>
    /// This is the key class for the OSLO Location Vocabulary and represents a
    ///       location that is linked with an address and/or a building with parcel(s).
    /// <see href="http://purl.org/oslo/ns/localgov#ResidenceObject"></see></summary>
    let ResidenceObject = _prefix "ResidenceObject"
    /// <summary>
    /// Denotes a role that a Person or other Agent can take in an public service. Instances of this class describe the abstract role; to denote a specific instance of a person playing that role in a specific public service use an instance of `Permission` that is linked with the formal rules `Rule`.
    /// <see href="http://purl.org/oslo/ns/localgov#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Status of Public Service
    /// <see href="http://purl.org/oslo/ns/localgov#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Parcel linked to a building or a residence object.
    /// <see href="http://purl.org/oslo/ns/localgov#address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of oslo:addressArea is oslo:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#addressArea"></see></summary>
    let addressArea = _prefix "addressArea"
    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:addressId is locn:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#addressId"></see></summary>
    let addressId = _prefix "addressId"
    /// <summary>
    /// Admin Unit linked to an address
    /// <see href="http://purl.org/oslo/ns/localgov#adminUnit"></see></summary>
    let adminUnit = _prefix "adminUnit"
    /// <summary>
    /// Points to a authentic location
    /// <see href="http://purl.org/oslo/ns/localgov#authenticLocation"></see></summary>
    let authenticLocation = _prefix "authenticLocation"
    /// <summary>
    /// Points to a residence
    /// <see href="http://purl.org/oslo/ns/localgov#availableAt"></see></summary>
    let availableAt = _prefix "availableAt"
    /// <summary>
    /// Building linked to a residence object.
    /// <see href="http://purl.org/oslo/ns/localgov#building"></see></summary>
    let building = _prefix "building"
    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of a building is a crucial part of the OSLO data spec. The domain of oslo:buildingId is oslo:Building.
    /// <see href="http://purl.org/oslo/ns/localgov#buildingId"></see></summary>
    let buildingId = _prefix "buildingId"
    /// <summary>
    /// The range of place of death is a code.
    /// <see href="http://purl.org/oslo/ns/localgov#civilClass"></see></summary>
    let civilClass = _prefix "civilClass"
    /// <summary>
    /// Depicts the contact information for a person, organizaton or membership
    /// <see href="http://purl.org/oslo/ns/localgov#contact"></see></summary>
    let contact = _prefix "contact"
    /// <summary>
    /// The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;.
    /// <see href="http://purl.org/oslo/ns/localgov#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// Points to a delivery location
    /// <see href="http://purl.org/oslo/ns/localgov#deliveryLocation"></see></summary>
    let deliveryLocation = _prefix "deliveryLocation"
    /// <summary>
    /// The range of domicile is ResidenceObject.
    /// <see href="http://purl.org/oslo/ns/localgov#domicile"></see></summary>
    let domicile = _prefix "domicile"
    /// <summary>
    /// Date of establishment of an organization
    /// <see href="http://purl.org/oslo/ns/localgov#establishmentDate"></see></summary>
    let establishmentDate = _prefix "establishmentDate"
    /// <summary>
    /// The oslo:extended_address property relationship associates an &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#oslo:ExtendedAddress"&gt;Extended Address&lt;/a&gt; with a &lt;a ="#locn:Address"&gt;Address&lt;/a&gt; Class
    /// <see href="http://purl.org/oslo/ns/localgov#extended_address"></see></summary>
    let extended_address = _prefix "extended_address"
    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:extended_addressId is oslo:ExtendedAddress.
    /// <see href="http://purl.org/oslo/ns/localgov#extended_addressId"></see></summary>
    let extended_addressId = _prefix "extended_addressId"
    /// <summary>
    /// from relation
    /// <see href="http://purl.org/oslo/ns/localgov#fromOrganization"></see></summary>
    let fromOrganization = _prefix "fromOrganization"
    /// <summary>
    ///   <see href="http://purl.org/oslo/ns/localgov#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    /// from relation
    /// <see href="http://purl.org/oslo/ns/localgov#fromPerson"></see></summary>
    let fromPerson = _prefix "fromPerson"
    /// <summary>
    /// The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#fullAddress"></see></summary>
    let fullAddress = _prefix "fullAddress"
    /// <summary>
    /// A KBO Funtion
    /// <see href="http://purl.org/oslo/ns/localgov#function"></see></summary>
    let function_ = _prefix "function"
    /// <summary>
    /// A KBO Funtionphase
    /// <see href="http://purl.org/oslo/ns/localgov#functionPhase"></see></summary>
    let functionPhase = _prefix "functionPhase"
    /// <summary>
    /// This very general property links an Public Service to a Role.
    /// <see href="http://purl.org/oslo/ns/localgov#hasActor"></see></summary>
    let hasActor = _prefix "hasActor"
    /// <summary>
    /// Permission belonging to a Role.
    /// <see href="http://purl.org/oslo/ns/localgov#hasPermission"></see></summary>
    let hasPermission = _prefix "hasPermission"
    /// <summary>
    /// Points to a invoice location
    /// <see href="http://purl.org/oslo/ns/localgov#invoiceLocation"></see></summary>
    let invoiceLocation = _prefix "invoiceLocation"
    /// <summary>
    /// Depicts if organization is branch of another organization
    /// <see href="http://purl.org/oslo/ns/localgov#isBranch"></see></summary>
    let isBranch = _prefix "isBranch"
    /// <summary>
    /// Kind of organization, natural person or legal person
    /// <see href="http://purl.org/oslo/ns/localgov#kind"></see></summary>
    let kind = _prefix "kind"
    /// <summary>
    /// Legal Cohabetitation
    /// <see href="http://purl.org/oslo/ns/localgov#legalCohabetation"></see></summary>
    let legalCohabetation = _prefix "legalCohabetation"
    /// <summary>
    /// A Legal Form Code
    /// <see href="http://purl.org/oslo/ns/localgov#legalFormCode"></see></summary>
    let legalFormCode = _prefix "legalFormCode"
    /// <summary>
    /// Legal Incompetence
    /// <see href="http://purl.org/oslo/ns/localgov#legalIncompetence"></see></summary>
    let legalIncompetence = _prefix "legalIncompetence"
    /// <summary>
    /// A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators. The domain of oslo:locatorDesignator is oslo:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#locatorDesignator"></see></summary>
    let locatorDesignator = _prefix "locatorDesignator"
    /// <summary>
    /// Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building. The domain of oslo:locatorName is oslo:ExtendedAddress.
    /// <see href="http://purl.org/oslo/ns/localgov#locatorName"></see></summary>
    let locatorName = _prefix "locatorName"
    /// <summary>
    /// A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). This is typically an identification for the locator in the thoroughfare (most of the times a street or square).
    /// <see href="http://purl.org/oslo/ns/localgov#locatorNumber"></see></summary>
    let locatorNumber = _prefix "locatorNumber"
    /// <summary>
    /// Points to a mailing location
    /// <see href="http://purl.org/oslo/ns/localgov#mailingLocation"></see></summary>
    let mailingLocation = _prefix "mailingLocation"
    /// <summary>
    /// Function label of a membership
    /// <see href="http://purl.org/oslo/ns/localgov#membershipFunction"></see></summary>
    let membershipFunction = _prefix "membershipFunction"
    /// <summary>
    /// Type of a membership
    /// <see href="http://purl.org/oslo/ns/localgov#membershipType"></see></summary>
    let membershipType = _prefix "membershipType"
    /// <summary>
    /// Nobelity title of a person
    /// <see href="http://purl.org/oslo/ns/localgov#nobelityTitle"></see></summary>
    let nobelityTitle = _prefix "nobelityTitle"
    /// <summary>
    /// A KBO Organisation status
    /// <see href="http://purl.org/oslo/ns/localgov#orgStatus"></see></summary>
    let orgStatus = _prefix "orgStatus"
    /// <summary>
    /// Parcel linked to a building or a residence object.
    /// <see href="http://purl.org/oslo/ns/localgov#parcel"></see></summary>
    let parcel = _prefix "parcel"
    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of a parcel is a crucial part of the OSLO data spec. The domain of oslo:parcelId is oslo:Parcel.
    /// <see href="http://purl.org/oslo/ns/localgov#parcelId"></see></summary>
    let parcelId = _prefix "parcelId"
    /// <summary>
    /// The Post Office Box number. The domain of oslo:poBox is oslo:ExtendedAddress.
    /// <see href="http://purl.org/oslo/ns/localgov#poBox"></see></summary>
    let poBox = _prefix "poBox"
    /// <summary>
    /// Type of a product
    /// <see href="http://purl.org/oslo/ns/localgov#productType"></see></summary>
    let productType = _prefix "productType"
    /// <summary>
    ///   <see href="http://purl.org/oslo/ns/localgov#Product"></see>
    /// </summary>
    let Product = _prefix "Product"
    /// <summary>
    /// This very general property links an Public Service to a Role.
    /// <see href="http://purl.org/oslo/ns/localgov#providesRole"></see></summary>
    let providesRole = _prefix "providesRole"
    /// <summary>
    /// The province of the address. The domain of
    ///     oslo:province is oslo:ExtendedAddress and the range is a literal, conceptually
    ///   defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;.
    /// <see href="http://purl.org/oslo/ns/localgov#province"></see></summary>
    let province = _prefix "province"
    /// <summary>
    /// Reason for shutdown of an organization
    /// <see href="http://purl.org/oslo/ns/localgov#reasonShutDown"></see></summary>
    let reasonShutDown = _prefix "reasonShutDown"
    /// <summary>
    /// The range of residence is ResidenceObject.
    /// <see href="http://purl.org/oslo/ns/localgov#residence"></see></summary>
    let residence = _prefix "residence"
    /// <summary>
    /// Result of the public service process.
    /// <see href="http://purl.org/oslo/ns/localgov#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// Date of shutdown of an organization
    /// <see href="http://purl.org/oslo/ns/localgov#shutDownDate"></see></summary>
    let shutDownDate = _prefix "shutDownDate"
    /// <summary>
    /// Status of the public service process.
    /// <see href="http://purl.org/oslo/ns/localgov#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Statuscode
    /// <see href="http://purl.org/oslo/ns/localgov#statusCode"></see></summary>
    let statusCode = _prefix "statusCode"
    /// <summary>
    /// Type of a status
    /// <see href="http://purl.org/oslo/ns/localgov#statusType"></see></summary>
    let statusType = _prefix "statusType"
    /// <summary>
    /// Targetdate for a public service to process its input and produce output
    /// <see href="http://purl.org/oslo/ns/localgov#targetDate"></see></summary>
    let targetDate = _prefix "targetDate"
    /// <summary>
    /// to relation
    /// <see href="http://purl.org/oslo/ns/localgov#toOrganization"></see></summary>
    let toOrganization = _prefix "toOrganization"
    /// <summary>
    /// to relation
    /// <see href="http://purl.org/oslo/ns/localgov#toPerson"></see></summary>
    let toPerson = _prefix "toPerson"
    /// <summary>
    /// Points to a time interval
    /// <see href="http://purl.org/oslo/ns/localgov#validityPeriod"></see></summary>
    let validityPeriod = _prefix "validityPeriod"
