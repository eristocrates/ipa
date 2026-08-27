namespace http.purl.org.oslo.ns.localgov.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oslo =
    let _namespace_iri = Namespace_Iri oslo |> NamespaceIRI
    /// <summary>
    ///   <para>oslo:BasicAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BasicAddress"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#BasicAddress">http://purl.org/oslo/ns/localgov#BasicAddress</seealso>
    let BasicAddress = Prefixed_Name(oslo, "BasicAddress") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Information related to a Building"</para>
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Building">http://purl.org/oslo/ns/localgov#Building</seealso>
    let Building = Prefixed_Name(oslo, "Building") |> PrefixedName
    /// <summary>
    ///   <para>oslo:ExtendedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An "address representation" as defined in the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538"&gt;data specifications&lt;/a&gt; of the EU INSPIRE Directive. The &lt;a ="#locn:addressId"&gt;locn:addressId&lt;/a&gt; property may be used to link this Address to other representations. This address extends the address with additional information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExtendedAddress"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#ExtendedAddress">http://purl.org/oslo/ns/localgov#ExtendedAddress</seealso>
    let ExtendedAddress = Prefixed_Name(oslo, "ExtendedAddress") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities."</para>
    /// labels<para>"Membership"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Membership">http://purl.org/oslo/ns/localgov#Membership</seealso>
    let Membership = Prefixed_Name(oslo, "Membership") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"This is the key class for the Business Core Vocabulary and represents a
    ///     business that is legally registered. In many countries there is a single registry although in others,
    ///     such as Spain and Germany, multiple registries exist. A Legal Entity is able to trade, is
    ///     legally liable for its actions, accounts, tax affairs etc. It is a sub class of org:FormalOrganization
    ///     which covers a wider range of entities, such as charities."</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Organization">http://purl.org/oslo/ns/localgov#Organization</seealso>
    let Organization = Prefixed_Name(oslo, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>oslo:OrganizationRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A relation between two organizations"</para>
    /// labels<para>"OrganizationnRelation"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#OrganizationRelation">http://purl.org/oslo/ns/localgov#OrganizationRelation</seealso>
    let OrganizationRelation =
        Prefixed_Name(oslo, "OrganizationRelation") |> PrefixedName

    /// <summary>
    ///   <para>oslo:Parcel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Information related to a Parcel Address or Label"</para>
    /// labels<para>"Parcel"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Parcel">http://purl.org/oslo/ns/localgov#Parcel</seealso>
    let Parcel = Prefixed_Name(oslo, "Parcel") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a the permission of a role. Should be linked with a formal rule."</para>
    /// labels<para>"Permission"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Permission">http://purl.org/oslo/ns/localgov#Permission</seealso>
    let Permission = Prefixed_Name(oslo, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Person">http://purl.org/oslo/ns/localgov#Person</seealso>
    let Person = Prefixed_Name(oslo, "Person") |> PrefixedName
    /// <summary>
    ///   <para>oslo:PersonRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A relation between two persons"</para>
    /// labels<para>"PersonRelation"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#PersonRelation">http://purl.org/oslo/ns/localgov#PersonRelation</seealso>
    let PersonRelation = Prefixed_Name(oslo, "PersonRelation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Product</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Product">http://purl.org/oslo/ns/localgov#Product</seealso>
    let Product = Prefixed_Name(oslo, "Product") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A relation between two agents"</para>
    /// labels<para>"Relation"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Relation">http://purl.org/oslo/ns/localgov#Relation</seealso>
    let Relation = Prefixed_Name(oslo, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:ResidenceObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"This is the key class for the OSLO Location Vocabulary and represents a
    ///       location that is linked with an address and/or a building with parcel(s)."</para>
    /// labels<para>"Residence Object"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#ResidenceObject">http://purl.org/oslo/ns/localgov#ResidenceObject</seealso>
    let ResidenceObject = Prefixed_Name(oslo, "ResidenceObject") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a role that a Person or other Agent can take in an public service. Instances of this class describe the abstract role; to denote a specific instance of a person playing that role in a specific public service use an instance of `Permission` that is linked with the formal rules `Rule`."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Role">http://purl.org/oslo/ns/localgov#Role</seealso>
    let Role = Prefixed_Name(oslo, "Role") |> PrefixedName
    /// <summary>
    ///   <para>oslo:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Status of Public Service"</para>
    /// labels<para>"Status"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#Status">http://purl.org/oslo/ns/localgov#Status</seealso>
    let Status = Prefixed_Name(oslo, "Status") |> PrefixedName
    /// <summary>
    ///   <para>oslo:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Parcel linked to a building or a residence object."</para>
    /// labels<para>"addres "</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#address">http://purl.org/oslo/ns/localgov#address</seealso>
    let address = Prefixed_Name(oslo, "address") |> PrefixedName
    /// <summary>
    ///   <para>oslo:addressArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name or names of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This would typically be part of a city, a neighbourhood or village. The domain of oslo:addressArea is oslo:Address."</para>
    /// labels<para>"address area"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#addressArea">http://purl.org/oslo/ns/localgov#addressArea</seealso>
    let addressArea = Prefixed_Name(oslo, "addressArea") |> PrefixedName
    /// <summary>
    ///   <para>oslo:addressId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:addressId is locn:Address."</para>
    /// labels<para>"address ID"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#addressId">http://purl.org/oslo/ns/localgov#addressId</seealso>
    let addressId = Prefixed_Name(oslo, "addressId") |> PrefixedName
    /// <summary>
    ///   <para>oslo:adminUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Admin Unit linked to an address"</para>
    /// labels<para>"Administrative Unit"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#adminUnit">http://purl.org/oslo/ns/localgov#adminUnit</seealso>
    let adminUnit = Prefixed_Name(oslo, "adminUnit") |> PrefixedName
    /// <summary>
    ///   <para>oslo:authenticLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a authentic location"</para>
    /// labels<para>"authentic location"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#authenticLocation">http://purl.org/oslo/ns/localgov#authenticLocation</seealso>
    let authenticLocation = Prefixed_Name(oslo, "authenticLocation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:availableAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a residence"</para>
    /// labels<para>"availableAt"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#availableAt">http://purl.org/oslo/ns/localgov#availableAt</seealso>
    let availableAt = Prefixed_Name(oslo, "availableAt") |> PrefixedName
    /// <summary>
    ///   <para>oslo:building</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Building linked to a residence object."</para>
    /// labels<para>"building "</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#building">http://purl.org/oslo/ns/localgov#building</seealso>
    let building = Prefixed_Name(oslo, "building") |> PrefixedName
    /// <summary>
    ///   <para>oslo:buildingId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The concept of adding a globally unique identifier for each instance of a building is a crucial part of the OSLO data spec. The domain of oslo:buildingId is oslo:Building."</para>
    /// labels<para>"building ID"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#buildingId">http://purl.org/oslo/ns/localgov#buildingId</seealso>
    let buildingId = Prefixed_Name(oslo, "buildingId") |> PrefixedName
    /// <summary>
    ///   <para>oslo:civilClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The range of place of death is a code."</para>
    /// labels<para>"civil classs"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#civilClass">http://purl.org/oslo/ns/localgov#civilClass</seealso>
    let civilClass = Prefixed_Name(oslo, "civilClass") |> PrefixedName
    /// <summary>
    ///   <para>oslo:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Depicts the contact information for a person, organizaton or membership"</para>
    /// labels<para>"contact information"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#contact">http://purl.org/oslo/ns/localgov#contact</seealso>
    let contact = Prefixed_Name(oslo, "contact") |> PrefixedName
    /// <summary>
    ///   <para>oslo:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The uppermost administrative unit for the address, almost always a country. The domain of locn:adminUnitL1 is locn:Address and the range is a literal, conceptually defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"country"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#country">http://purl.org/oslo/ns/localgov#country</seealso>
    let country = Prefixed_Name(oslo, "country") |> PrefixedName
    /// <summary>
    ///   <para>oslo:deliveryLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a delivery location"</para>
    /// labels<para>"delivery location"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#deliveryLocation">http://purl.org/oslo/ns/localgov#deliveryLocation</seealso>
    let deliveryLocation = Prefixed_Name(oslo, "deliveryLocation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:domicile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The range of domicile is ResidenceObject."</para>
    /// labels<para>"domicile"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#domicile">http://purl.org/oslo/ns/localgov#domicile</seealso>
    let domicile = Prefixed_Name(oslo, "domicile") |> PrefixedName
    /// <summary>
    ///   <para>oslo:establishmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Date of establishment of an organization"</para>
    /// labels<para>"date of establishment"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#establishmentDate">http://purl.org/oslo/ns/localgov#establishmentDate</seealso>
    let establishmentDate = Prefixed_Name(oslo, "establishmentDate") |> PrefixedName
    /// <summary>
    ///   <para>oslo:extended_address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The oslo:extended_address property relationship associates an &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="#oslo:ExtendedAddress"&gt;Extended Address&lt;/a&gt; with a &lt;a ="#locn:Address"&gt;Address&lt;/a&gt; Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"extended address"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#extended_address">http://purl.org/oslo/ns/localgov#extended_address</seealso>
    let extended_address = Prefixed_Name(oslo, "extended_address") |> PrefixedName
    /// <summary>
    ///   <para>oslo:extended_addressId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The concept of adding a globally unique identifier for each instance of an address is a crucial part of the INSPIRE data spec. The domain of oslo:extended_addressId is oslo:ExtendedAddress."</para>
    /// labels<para>"extended address ID"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#extended_addressId">http://purl.org/oslo/ns/localgov#extended_addressId</seealso>
    let extended_addressId = Prefixed_Name(oslo, "extended_addressId") |> PrefixedName
    /// <summary>
    ///   <para>oslo:fromOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"from relation"</para>
    /// labels<para>"from"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#fromOrganization">http://purl.org/oslo/ns/localgov#fromOrganization</seealso>
    let fromOrganization = Prefixed_Name(oslo, "fromOrganization") |> PrefixedName
    /// <summary>
    ///   <para>oslo:fromPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"from relation"</para>
    /// labels<para>"from"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#fromPerson">http://purl.org/oslo/ns/localgov#fromPerson</seealso>
    let fromPerson = Prefixed_Name(oslo, "fromPerson") |> PrefixedName
    /// <summary>
    ///   <para>oslo:fullAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The complete address written as a string, with or without formatting. The domain of locn:fullAddress is locn:Address."</para>
    /// labels<para>"full address"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#fullAddress">http://purl.org/oslo/ns/localgov#fullAddress</seealso>
    let fullAddress = Prefixed_Name(oslo, "fullAddress") |> PrefixedName
    /// <summary>
    ///   <para>oslo:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A KBO Funtion"</para>
    /// labels<para>"KBO function"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#function">http://purl.org/oslo/ns/localgov#function</seealso>
    let function_ = Prefixed_Name(oslo, "function") |> PrefixedName
    /// <summary>
    ///   <para>oslo:functionPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A KBO Funtionphase"</para>
    /// labels<para>"KBO function phase"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#functionPhase">http://purl.org/oslo/ns/localgov#functionPhase</seealso>
    let functionPhase = Prefixed_Name(oslo, "functionPhase") |> PrefixedName
    /// <summary>
    ///   <para>oslo:hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This very general property links an Public Service to a Role."</para>
    /// labels<para>"provides role"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#hasActor">http://purl.org/oslo/ns/localgov#hasActor</seealso>
    let hasActor = Prefixed_Name(oslo, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>oslo:hasPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Permission belonging to a Role."</para>
    /// labels<para>"has permission"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#hasPermission">http://purl.org/oslo/ns/localgov#hasPermission</seealso>
    let hasPermission = Prefixed_Name(oslo, "hasPermission") |> PrefixedName
    /// <summary>
    ///   <para>oslo:invoiceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a invoice location"</para>
    /// labels<para>"invoice location"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#invoiceLocation">http://purl.org/oslo/ns/localgov#invoiceLocation</seealso>
    let invoiceLocation = Prefixed_Name(oslo, "invoiceLocation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:isBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Depicts if organization is branch of another organization"</para>
    /// labels<para>"organization is a branch or not"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#isBranch">http://purl.org/oslo/ns/localgov#isBranch</seealso>
    let isBranch = Prefixed_Name(oslo, "isBranch") |> PrefixedName
    /// <summary>
    ///   <para>oslo:kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Kind of organization, natural person or legal person"</para>
    /// labels<para>"kind"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#kind">http://purl.org/oslo/ns/localgov#kind</seealso>
    let kind = Prefixed_Name(oslo, "kind") |> PrefixedName
    /// <summary>
    ///   <para>oslo:legalCohabetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Legal Cohabetitation"</para>
    /// labels<para>"nobelity title"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#legalCohabetation">http://purl.org/oslo/ns/localgov#legalCohabetation</seealso>
    let legalCohabetation = Prefixed_Name(oslo, "legalCohabetation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:legalFormCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Legal Form Code"</para>
    /// labels<para>"legal form code"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#legalFormCode">http://purl.org/oslo/ns/localgov#legalFormCode</seealso>
    let legalFormCode = Prefixed_Name(oslo, "legalFormCode") |> PrefixedName
    /// <summary>
    ///   <para>oslo:legalIncompetence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Legal Incompetence"</para>
    /// labels<para>"legal incompetence"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#legalIncompetence">http://purl.org/oslo/ns/localgov#legalIncompetence</seealso>
    let legalIncompetence = Prefixed_Name(oslo, "legalIncompetence") |> PrefixedName
    /// <summary>
    ///   <para>oslo:locatorDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). The full identification of the locator could include one or more locator designators. The domain of oslo:locatorDesignator is oslo:Address."</para>
    /// labels<para>"locator designator"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#locatorDesignator">http://purl.org/oslo/ns/localgov#locatorDesignator</seealso>
    let locatorDesignator = Prefixed_Name(oslo, "locatorDesignator") |> PrefixedName
    /// <summary>
    ///   <para>oslo:locatorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Proper noun(s) applied to the real world entity identified by the locator. The locator name could be the name of the property or complex, of the building or part of the building, or it could be the name of a room inside a building. The domain of oslo:locatorName is oslo:ExtendedAddress."</para>
    /// labels<para>"locator name"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#locatorName">http://purl.org/oslo/ns/localgov#locatorName</seealso>
    let locatorName = Prefixed_Name(oslo, "locatorName") |> PrefixedName
    /// <summary>
    ///   <para>oslo:locatorNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A number or a sequence of characters that uniquely identifies the locator within the relevant scope(s). This is typically an identification for the locator in the thoroughfare (most of the times a street or square)."</para>
    /// labels<para>"locator number"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#locatorNumber">http://purl.org/oslo/ns/localgov#locatorNumber</seealso>
    let locatorNumber = Prefixed_Name(oslo, "locatorNumber") |> PrefixedName
    /// <summary>
    ///   <para>oslo:mailingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a mailing location"</para>
    /// labels<para>"mailing location"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#mailingLocation">http://purl.org/oslo/ns/localgov#mailingLocation</seealso>
    let mailingLocation = Prefixed_Name(oslo, "mailingLocation") |> PrefixedName
    /// <summary>
    ///   <para>oslo:membershipFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Function label of a membership"</para>
    /// labels<para>"membership function"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#membershipFunction">http://purl.org/oslo/ns/localgov#membershipFunction</seealso>
    let membershipFunction = Prefixed_Name(oslo, "membershipFunction") |> PrefixedName
    /// <summary>
    ///   <para>oslo:membershipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Type of a membership"</para>
    /// labels<para>"type of membership"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#membershipType">http://purl.org/oslo/ns/localgov#membershipType</seealso>
    let membershipType = Prefixed_Name(oslo, "membershipType") |> PrefixedName
    /// <summary>
    ///   <para>oslo:nobelityTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Nobelity title of a person"</para>
    /// labels<para>"nobelity title"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#nobelityTitle">http://purl.org/oslo/ns/localgov#nobelityTitle</seealso>
    let nobelityTitle = Prefixed_Name(oslo, "nobelityTitle") |> PrefixedName
    /// <summary>
    ///   <para>oslo:orgStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A KBO Organisation status"</para>
    /// labels<para>"KBO Organisation status"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#orgStatus">http://purl.org/oslo/ns/localgov#orgStatus</seealso>
    let orgStatus = Prefixed_Name(oslo, "orgStatus") |> PrefixedName
    /// <summary>
    ///   <para>oslo:parcel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Parcel linked to a building or a residence object."</para>
    /// labels<para>"parcel "</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#parcel">http://purl.org/oslo/ns/localgov#parcel</seealso>
    let parcel = Prefixed_Name(oslo, "parcel") |> PrefixedName
    /// <summary>
    ///   <para>oslo:parcelId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The concept of adding a globally unique identifier for each instance of a parcel is a crucial part of the OSLO data spec. The domain of oslo:parcelId is oslo:Parcel."</para>
    /// labels<para>"parcel ID"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#parcelId">http://purl.org/oslo/ns/localgov#parcelId</seealso>
    let parcelId = Prefixed_Name(oslo, "parcelId") |> PrefixedName
    /// <summary>
    ///   <para>oslo:poBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Post Office Box number. The domain of oslo:poBox is oslo:ExtendedAddress."</para>
    /// labels<para>"po box"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#poBox">http://purl.org/oslo/ns/localgov#poBox</seealso>
    let poBox = Prefixed_Name(oslo, "poBox") |> PrefixedName
    /// <summary>
    ///   <para>oslo:productType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Type of a product"</para>
    /// labels<para>"type of product"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#productType">http://purl.org/oslo/ns/localgov#productType</seealso>
    let productType = Prefixed_Name(oslo, "productType") |> PrefixedName
    /// <summary>
    ///   <para>oslo:providesRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This very general property links an Public Service to a Role."</para>
    /// labels<para>"provides role"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#providesRole">http://purl.org/oslo/ns/localgov#providesRole</seealso>
    let providesRole = Prefixed_Name(oslo, "providesRole") |> PrefixedName
    /// <summary>
    ///   <para>oslo:province</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The province of the address. The domain of
    ///     oslo:province is oslo:ExtendedAddress and the range is a literal, conceptually
    ///   defined by the &lt;a xmlns="http://purl.org/oslo/ns/localgov#" ="https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2612"&gt;INSPIRE Geographical Name data type&lt;/a&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"province"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#province">http://purl.org/oslo/ns/localgov#province</seealso>
    let province = Prefixed_Name(oslo, "province") |> PrefixedName
    /// <summary>
    ///   <para>oslo:reasonShutDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Reason for shutdown of an organization"</para>
    /// labels<para>"reason shutdown"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#reasonShutDown">http://purl.org/oslo/ns/localgov#reasonShutDown</seealso>
    let reasonShutDown = Prefixed_Name(oslo, "reasonShutDown") |> PrefixedName
    /// <summary>
    ///   <para>oslo:residence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The range of residence is ResidenceObject."</para>
    /// labels<para>"residence"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#residence">http://purl.org/oslo/ns/localgov#residence</seealso>
    let residence = Prefixed_Name(oslo, "residence") |> PrefixedName
    /// <summary>
    ///   <para>oslo:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Result of the public service process."</para>
    /// labels<para>"Public Service Result"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#result">http://purl.org/oslo/ns/localgov#result</seealso>
    let result = Prefixed_Name(oslo, "result") |> PrefixedName
    /// <summary>
    ///   <para>oslo:shutDownDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Date of shutdown of an organization"</para>
    /// labels<para>"date of shutdown"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#shutDownDate">http://purl.org/oslo/ns/localgov#shutDownDate</seealso>
    let shutDownDate = Prefixed_Name(oslo, "shutDownDate") |> PrefixedName
    /// <summary>
    ///   <para>oslo:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Status of the public service process."</para>
    /// labels<para>"Public Service Status"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#status">http://purl.org/oslo/ns/localgov#status</seealso>
    let status = Prefixed_Name(oslo, "status") |> PrefixedName
    /// <summary>
    ///   <para>oslo:statusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Statuscode"</para>
    /// labels<para>"Statuscode"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#statusCode">http://purl.org/oslo/ns/localgov#statusCode</seealso>
    let statusCode = Prefixed_Name(oslo, "statusCode") |> PrefixedName
    /// <summary>
    ///   <para>oslo:statusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Type of a status"</para>
    /// labels<para>"type of status"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#statusType">http://purl.org/oslo/ns/localgov#statusType</seealso>
    let statusType = Prefixed_Name(oslo, "statusType") |> PrefixedName
    /// <summary>
    ///   <para>oslo:targetDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Targetdate for a public service to process its input and produce output"</para>
    /// labels<para>"Target date"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#targetDate">http://purl.org/oslo/ns/localgov#targetDate</seealso>
    let targetDate = Prefixed_Name(oslo, "targetDate") |> PrefixedName
    /// <summary>
    ///   <para>oslo:toOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"to relation"</para>
    /// labels<para>"to"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#toOrganization">http://purl.org/oslo/ns/localgov#toOrganization</seealso>
    let toOrganization = Prefixed_Name(oslo, "toOrganization") |> PrefixedName
    /// <summary>
    ///   <para>oslo:toPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"to relation"</para>
    /// labels<para>"to"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#toPerson">http://purl.org/oslo/ns/localgov#toPerson</seealso>
    let toPerson = Prefixed_Name(oslo, "toPerson") |> PrefixedName
    /// <summary>
    ///   <para>oslo:validityPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Points to a time interval"</para>
    /// labels<para>"validity period"</para></remarks>
    /// <seealso href="http://purl.org/oslo/ns/localgov#validityPeriod">http://purl.org/oslo/ns/localgov#validityPeriod</seealso>
    let validityPeriod = Prefixed_Name(oslo, "validityPeriod") |> PrefixedName
