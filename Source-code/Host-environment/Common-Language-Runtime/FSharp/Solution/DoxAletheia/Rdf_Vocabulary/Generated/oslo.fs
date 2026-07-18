namespace http.purl.org.oslo.ns.localgov.hash

open DoxAletheia.Rdf_Vocabulary

module oslo =
    let _namespace_name = "http://purl.org/oslo/ns/localgov#"

    /// <summary>
    /// An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information
    /// <see href="http://purl.org/oslo/ns/localgov#BasicAddress"></see></summary>
    let BasicAddress =
        Namespaced_IRI.parse _namespace_name "BasicAddress" |> NamespacedName

    /// <summary>
    /// Information related to a Building
    /// <see href="http://purl.org/oslo/ns/localgov#Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    /// An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information
    /// <see href="http://purl.org/oslo/ns/localgov#ExtendedAddress"></see></summary>
    let ExtendedAddress =
        Namespaced_IRI.parse _namespace_name "ExtendedAddress" |> NamespacedName

    /// <summary>
    /// This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities.
    /// <see href="http://purl.org/oslo/ns/localgov#Membership"></see></summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName

    /// <summary>
    /// This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities.
    /// <see href="http://purl.org/oslo/ns/localgov#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A relation between two organizations
    /// <see href="http://purl.org/oslo/ns/localgov#OrganizationRelation"></see></summary>
    let OrganizationRelation =
        Namespaced_IRI.parse _namespace_name "OrganizationRelation" |> NamespacedName

    /// <summary>
    /// A relation between two agents
    /// <see href="http://purl.org/oslo/ns/localgov#Relation"></see></summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName
    /// <summary>
    /// Information related to a Parcel Address or Label
    /// <see href="http://purl.org/oslo/ns/localgov#Parcel"></see></summary>
    let Parcel = Namespaced_IRI.parse _namespace_name "Parcel" |> NamespacedName
    /// <summary>
    /// Denotes a the permission of a role. Should be linked with a formal rule.
    /// <see href="http://purl.org/oslo/ns/localgov#Permission"></see></summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName

    /// <summary>
    /// A relation between two persons
    /// <see href="http://purl.org/oslo/ns/localgov#PersonRelation"></see></summary>
    let PersonRelation =
        Namespaced_IRI.parse _namespace_name "PersonRelation" |> NamespacedName

    /// <summary>
    /// This is the key class for the OSLO Location Vocabulary and represents a
    ///       location that is linked with an address and/or a building with parcel(s).
    /// <see href="http://purl.org/oslo/ns/localgov#ResidenceObject"></see></summary>
    let ResidenceObject =
        Namespaced_IRI.parse _namespace_name "ResidenceObject" |> NamespacedName

    /// <summary>
    /// Denotes a role that a Person or other Agent can take in an public service. Instances of this class describe the abstract role; to denote a specific instance of a person playing that role in a specific public service use an instance of `Permission` that is linked with the formal rules `Rule`.
    /// <see href="http://purl.org/oslo/ns/localgov#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Status of Public Service
    /// <see href="http://purl.org/oslo/ns/localgov#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName
    /// <summary>
    /// Parcel linked to a building or a residence object.
    /// <see href="http://purl.org/oslo/ns/localgov#address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    /// The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of oslo:addressArea is oslo:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#addressArea"></see></summary>
    let addressArea =
        Namespaced_IRI.parse _namespace_name "addressArea" |> NamespacedName

    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:addressId is locn:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#addressId"></see></summary>
    let addressId = Namespaced_IRI.parse _namespace_name "addressId" |> NamespacedName
    /// <summary>
    /// Admin Unit linked to an address
    /// <see href="http://purl.org/oslo/ns/localgov#adminUnit"></see></summary>
    let adminUnit = Namespaced_IRI.parse _namespace_name "adminUnit" |> NamespacedName

    /// <summary>
    /// Points to a authentic location
    /// <see href="http://purl.org/oslo/ns/localgov#authenticLocation"></see></summary>
    let authenticLocation =
        Namespaced_IRI.parse _namespace_name "authenticLocation" |> NamespacedName

    /// <summary>
    /// Points to a residence
    /// <see href="http://purl.org/oslo/ns/localgov#availableAt"></see></summary>
    let availableAt =
        Namespaced_IRI.parse _namespace_name "availableAt" |> NamespacedName

    /// <summary>
    /// Building linked to a residence object.
    /// <see href="http://purl.org/oslo/ns/localgov#building"></see></summary>
    let building = Namespaced_IRI.parse _namespace_name "building" |> NamespacedName
    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of a building is a crucial part of the OSLO data spec. The domain of oslo:buildingId is oslo:Building.
    /// <see href="http://purl.org/oslo/ns/localgov#buildingId"></see></summary>
    let buildingId = Namespaced_IRI.parse _namespace_name "buildingId" |> NamespacedName
    /// <summary>
    /// The range of place of death is a code.
    /// <see href="http://purl.org/oslo/ns/localgov#civilClass"></see></summary>
    let civilClass = Namespaced_IRI.parse _namespace_name "civilClass" |> NamespacedName
    /// <summary>
    /// Depicts the contact information for a person, organizaton or membership
    /// <see href="http://purl.org/oslo/ns/localgov#contact"></see></summary>
    let contact = Namespaced_IRI.parse _namespace_name "contact" |> NamespacedName
    /// <summary>
    /// The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;.
    /// <see href="http://purl.org/oslo/ns/localgov#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    /// Points to a delivery location
    /// <see href="http://purl.org/oslo/ns/localgov#deliveryLocation"></see></summary>
    let deliveryLocation =
        Namespaced_IRI.parse _namespace_name "deliveryLocation" |> NamespacedName

    /// <summary>
    /// The range of domicile is ResidenceObject.
    /// <see href="http://purl.org/oslo/ns/localgov#domicile"></see></summary>
    let domicile = Namespaced_IRI.parse _namespace_name "domicile" |> NamespacedName

    /// <summary>
    /// Date of establishment of an organization
    /// <see href="http://purl.org/oslo/ns/localgov#establishmentDate"></see></summary>
    let establishmentDate =
        Namespaced_IRI.parse _namespace_name "establishmentDate" |> NamespacedName

    /// <summary>
    /// The oslo:extended_address property relationship associates an &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#oslo:ExtendedAddress"&gt;Extended Address&lt;/a&gt; with a &lt;a ="#locn:Address"&gt;Address&lt;/a&gt; Class
    /// <see href="http://purl.org/oslo/ns/localgov#extended_address"></see></summary>
    let extended_address =
        Namespaced_IRI.parse _namespace_name "extended_address" |> NamespacedName

    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:extended_addressId is oslo:ExtendedAddress.
    /// <see href="http://purl.org/oslo/ns/localgov#extended_addressId"></see></summary>
    let extended_addressId =
        Namespaced_IRI.parse _namespace_name "extended_addressId" |> NamespacedName

    /// <summary>
    /// from relation
    /// <see href="http://purl.org/oslo/ns/localgov#fromOrganization"></see></summary>
    let fromOrganization =
        Namespaced_IRI.parse _namespace_name "fromOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/oslo/ns/localgov#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// from relation
    /// <see href="http://purl.org/oslo/ns/localgov#fromPerson"></see></summary>
    let fromPerson = Namespaced_IRI.parse _namespace_name "fromPerson" |> NamespacedName

    /// <summary>
    /// The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#fullAddress"></see></summary>
    let fullAddress =
        Namespaced_IRI.parse _namespace_name "fullAddress" |> NamespacedName

    /// <summary>
    /// A KBO Funtion
    /// <see href="http://purl.org/oslo/ns/localgov#function"></see></summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName

    /// <summary>
    /// A KBO Funtionphase
    /// <see href="http://purl.org/oslo/ns/localgov#functionPhase"></see></summary>
    let functionPhase =
        Namespaced_IRI.parse _namespace_name "functionPhase" |> NamespacedName

    /// <summary>
    /// This very general property links an Public Service to a Role.
    /// <see href="http://purl.org/oslo/ns/localgov#hasActor"></see></summary>
    let hasActor = Namespaced_IRI.parse _namespace_name "hasActor" |> NamespacedName

    /// <summary>
    /// Permission belonging to a Role.
    /// <see href="http://purl.org/oslo/ns/localgov#hasPermission"></see></summary>
    let hasPermission =
        Namespaced_IRI.parse _namespace_name "hasPermission" |> NamespacedName

    /// <summary>
    /// Points to a invoice location
    /// <see href="http://purl.org/oslo/ns/localgov#invoiceLocation"></see></summary>
    let invoiceLocation =
        Namespaced_IRI.parse _namespace_name "invoiceLocation" |> NamespacedName

    /// <summary>
    /// Depicts if organization is branch of another organization
    /// <see href="http://purl.org/oslo/ns/localgov#isBranch"></see></summary>
    let isBranch = Namespaced_IRI.parse _namespace_name "isBranch" |> NamespacedName
    /// <summary>
    /// Kind of organization, natural person or legal person
    /// <see href="http://purl.org/oslo/ns/localgov#kind"></see></summary>
    let kind = Namespaced_IRI.parse _namespace_name "kind" |> NamespacedName

    /// <summary>
    /// Legal Cohabetitation
    /// <see href="http://purl.org/oslo/ns/localgov#legalCohabetation"></see></summary>
    let legalCohabetation =
        Namespaced_IRI.parse _namespace_name "legalCohabetation" |> NamespacedName

    /// <summary>
    /// A Legal Form Code
    /// <see href="http://purl.org/oslo/ns/localgov#legalFormCode"></see></summary>
    let legalFormCode =
        Namespaced_IRI.parse _namespace_name "legalFormCode" |> NamespacedName

    /// <summary>
    /// Legal Incompetence
    /// <see href="http://purl.org/oslo/ns/localgov#legalIncompetence"></see></summary>
    let legalIncompetence =
        Namespaced_IRI.parse _namespace_name "legalIncompetence" |> NamespacedName

    /// <summary>
    /// A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators. The domain of oslo:locatorDesignator is oslo:Address.
    /// <see href="http://purl.org/oslo/ns/localgov#locatorDesignator"></see></summary>
    let locatorDesignator =
        Namespaced_IRI.parse _namespace_name "locatorDesignator" |> NamespacedName

    /// <summary>
    /// Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building. The domain of oslo:locatorName is oslo:ExtendedAddress.
    /// <see href="http://purl.org/oslo/ns/localgov#locatorName"></see></summary>
    let locatorName =
        Namespaced_IRI.parse _namespace_name "locatorName" |> NamespacedName

    /// <summary>
    /// A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). This is typically an identification for the locator in the thoroughfare (most of the times a street or square).
    /// <see href="http://purl.org/oslo/ns/localgov#locatorNumber"></see></summary>
    let locatorNumber =
        Namespaced_IRI.parse _namespace_name "locatorNumber" |> NamespacedName

    /// <summary>
    /// Points to a mailing location
    /// <see href="http://purl.org/oslo/ns/localgov#mailingLocation"></see></summary>
    let mailingLocation =
        Namespaced_IRI.parse _namespace_name "mailingLocation" |> NamespacedName

    /// <summary>
    /// Function label of a membership
    /// <see href="http://purl.org/oslo/ns/localgov#membershipFunction"></see></summary>
    let membershipFunction =
        Namespaced_IRI.parse _namespace_name "membershipFunction" |> NamespacedName

    /// <summary>
    /// Type of a membership
    /// <see href="http://purl.org/oslo/ns/localgov#membershipType"></see></summary>
    let membershipType =
        Namespaced_IRI.parse _namespace_name "membershipType" |> NamespacedName

    /// <summary>
    /// Nobelity title of a person
    /// <see href="http://purl.org/oslo/ns/localgov#nobelityTitle"></see></summary>
    let nobelityTitle =
        Namespaced_IRI.parse _namespace_name "nobelityTitle" |> NamespacedName

    /// <summary>
    /// A KBO Organisation status
    /// <see href="http://purl.org/oslo/ns/localgov#orgStatus"></see></summary>
    let orgStatus = Namespaced_IRI.parse _namespace_name "orgStatus" |> NamespacedName
    /// <summary>
    /// Parcel linked to a building or a residence object.
    /// <see href="http://purl.org/oslo/ns/localgov#parcel"></see></summary>
    let parcel = Namespaced_IRI.parse _namespace_name "parcel" |> NamespacedName
    /// <summary>
    /// The concept of adding a globally unique identifier for each instance of a parcel is a crucial part of the OSLO data spec. The domain of oslo:parcelId is oslo:Parcel.
    /// <see href="http://purl.org/oslo/ns/localgov#parcelId"></see></summary>
    let parcelId = Namespaced_IRI.parse _namespace_name "parcelId" |> NamespacedName
    /// <summary>
    /// The Post Office Box number. The domain of oslo:poBox is oslo:ExtendedAddress.
    /// <see href="http://purl.org/oslo/ns/localgov#poBox"></see></summary>
    let poBox = Namespaced_IRI.parse _namespace_name "poBox" |> NamespacedName

    /// <summary>
    /// Type of a product
    /// <see href="http://purl.org/oslo/ns/localgov#productType"></see></summary>
    let productType =
        Namespaced_IRI.parse _namespace_name "productType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/oslo/ns/localgov#Product"></see>
    /// </summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName

    /// <summary>
    /// This very general property links an Public Service to a Role.
    /// <see href="http://purl.org/oslo/ns/localgov#providesRole"></see></summary>
    let providesRole =
        Namespaced_IRI.parse _namespace_name "providesRole" |> NamespacedName

    /// <summary>
    /// The province of the address. The domain of
    ///     oslo:province is oslo:ExtendedAddress and the range is a literal, conceptually
    ///   defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;.
    /// <see href="http://purl.org/oslo/ns/localgov#province"></see></summary>
    let province = Namespaced_IRI.parse _namespace_name "province" |> NamespacedName

    /// <summary>
    /// Reason for shutdown of an organization
    /// <see href="http://purl.org/oslo/ns/localgov#reasonShutDown"></see></summary>
    let reasonShutDown =
        Namespaced_IRI.parse _namespace_name "reasonShutDown" |> NamespacedName

    /// <summary>
    /// The range of residence is ResidenceObject.
    /// <see href="http://purl.org/oslo/ns/localgov#residence"></see></summary>
    let residence = Namespaced_IRI.parse _namespace_name "residence" |> NamespacedName
    /// <summary>
    /// Result of the public service process.
    /// <see href="http://purl.org/oslo/ns/localgov#result"></see></summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    /// Date of shutdown of an organization
    /// <see href="http://purl.org/oslo/ns/localgov#shutDownDate"></see></summary>
    let shutDownDate =
        Namespaced_IRI.parse _namespace_name "shutDownDate" |> NamespacedName

    /// <summary>
    /// Status of the public service process.
    /// <see href="http://purl.org/oslo/ns/localgov#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// Statuscode
    /// <see href="http://purl.org/oslo/ns/localgov#statusCode"></see></summary>
    let statusCode = Namespaced_IRI.parse _namespace_name "statusCode" |> NamespacedName
    /// <summary>
    /// Type of a status
    /// <see href="http://purl.org/oslo/ns/localgov#statusType"></see></summary>
    let statusType = Namespaced_IRI.parse _namespace_name "statusType" |> NamespacedName
    /// <summary>
    /// Targetdate for a public service to process its input and produce output
    /// <see href="http://purl.org/oslo/ns/localgov#targetDate"></see></summary>
    let targetDate = Namespaced_IRI.parse _namespace_name "targetDate" |> NamespacedName

    /// <summary>
    /// to relation
    /// <see href="http://purl.org/oslo/ns/localgov#toOrganization"></see></summary>
    let toOrganization =
        Namespaced_IRI.parse _namespace_name "toOrganization" |> NamespacedName

    /// <summary>
    /// to relation
    /// <see href="http://purl.org/oslo/ns/localgov#toPerson"></see></summary>
    let toPerson = Namespaced_IRI.parse _namespace_name "toPerson" |> NamespacedName

    /// <summary>
    /// Points to a time interval
    /// <see href="http://purl.org/oslo/ns/localgov#validityPeriod"></see></summary>
    let validityPeriod =
        Namespaced_IRI.parse _namespace_name "validityPeriod" |> NamespacedName
