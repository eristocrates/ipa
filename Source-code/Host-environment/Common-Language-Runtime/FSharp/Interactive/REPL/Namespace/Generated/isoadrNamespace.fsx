#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module isoadr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.au/def/ont/iso19160-1-address#" "isoadr"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#constraint : For Provenance conformance, provenance shall be mandatory</para>
    ///   <para>skos:definition : Structured information that allows the unambiguous determination of an object for purposes of identification and location.</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>rdfs:label : Address</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address">isoadr:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : comprises^^xsd:string</para>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#aggregationType : partOfSharedAggregation^^xsd:string</para>
    ///   <para>rdfs:label : address component</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.addressComponent">isoadr:Address.addressComponent</a>
    /// </summary>
    let ``Address.addressComponent`` = _prefixId.prefix "Address.addressComponent"
    /// <summary>
    ///   <para>rdfs:label : business</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_branch">isoadr:Address.business_branch</a>
    /// </summary>
    let ``Address.business_branch`` = _prefixId.prefix "Address.business_branch"
    /// <summary>
    ///   <para>rdfs:label : business</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_headOffice">isoadr:Address.business_headOffice</a>
    /// </summary>
    let ``Address.business_headOffice`` = _prefixId.prefix "Address.business_headOffice"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : parent^^xsd:string</para>
    ///   <para>rdfs:label : child address</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.childAddress">isoadr:Address.childAddress</a>
    /// </summary>
    let ``Address.childAddress`` = _prefixId.prefix "Address.childAddress"
    /// <summary>
    ///   <para>skos:definition : Code that specifies the address class to which the address belongs.</para>
    ///   <para>rdfs:label : class</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.class">isoadr:Address.class</a>
    /// </summary>
    let ``Address.class`` = _prefixId.prefix "Address.class"
    /// <summary>
    ///   <para>rdfs:label : client</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.client">isoadr:Address.client</a>
    /// </summary>
    let ``Address.client`` = _prefixId.prefix "Address.client"
    /// <summary>
    ///   <para>rdfs:label : employee</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.employee">isoadr:Address.employee</a>
    /// </summary>
    let ``Address.employee`` = _prefixId.prefix "Address.employee"
    /// <summary>
    ///   <para>skos:definition : Unique character string that identifies the address.</para>
    ///   <para>rdfs:label : id</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.id">isoadr:Address.id</a>
    /// </summary>
    let ``Address.id`` = _prefixId.prefix "Address.id"
    /// <summary>
    ///   <para>skos:definition : Code that specifies the phase an address has reached in its lifecycle.</para>
    ///   <para>rdfs:label : lifecycle stage</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifecycleStage">isoadr:Address.lifecycleStage</a>
    /// </summary>
    let ``Address.lifecycleStage`` = _prefixId.prefix "Address.lifecycleStage"
    /// <summary>
    ///   <para>skos:definition : Information about the period over which an address exists</para>
    ///   <para>rdfs:label : lifespan</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifespan">isoadr:Address.lifespan</a>
    /// </summary>
    let ``Address.lifespan`` = _prefixId.prefix "Address.lifespan"
    /// <summary>
    ///   <para>skos:definition : A set or parameters that specify the cultural and linguistic environment.</para>
    ///   <para>rdfs:label : locale</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.locale">isoadr:Address.locale</a>
    /// </summary>
    let ``Address.locale`` = _prefixId.prefix "Address.locale"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : parent^^xsd:string</para>
    ///   <para>rdfs:label : parent address</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.parentAddress">isoadr:Address.parentAddress</a>
    /// </summary>
    let ``Address.parentAddress`` = _prefixId.prefix "Address.parentAddress"
    /// <summary>
    ///   <para>skos:definition : Geometry (coordinates) that represents the address location.</para>
    ///   <para>rdfs:label : position</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.position">isoadr:Address.position</a>
    /// </summary>
    let ``Address.position`` = _prefixId.prefix "Address.position"
    /// <summary>
    ///   <para>skos:definition : Indicates the ranking of the address in a set of address aliases. 1 indicates highest ranking.
    ///
    /// EXAMPLE 1 A building on a street corner could be referenced by two addresses. One of them could have its preferenceLevel set to 1.
    ///
    /// EXAMPLE 2 In Switzerland, addresses containing German and French names, e.g. Biel (German) and Bienne (French), are different addresses with the same preference level.</para>
    ///   <para>rdfs:label : preference level</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.preferenceLevel">isoadr:Address.preferenceLevel</a>
    /// </summary>
    let ``Address.preferenceLevel`` = _prefixId.prefix "Address.preferenceLevel"
    /// <summary>
    ///   <para>skos:definition : Information about the source or origin of the address, such as the authority who assigned the address, the owner of the address data instance, and lineage of the address.</para>
    ///   <para>rdfs:label : provenance</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.provenance">isoadr:Address.provenance</a>
    /// </summary>
    let ``Address.provenance`` = _prefixId.prefix "Address.provenance"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : specifies^^xsd:string</para>
    ///   <para>rdfs:label : specification</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.specification">isoadr:Address.specification</a>
    /// </summary>
    let ``Address.specification`` = _prefixId.prefix "Address.specification"
    /// <summary>
    ///   <para>skos:definition : Code that specifies the nature of the address assignment.</para>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.status">isoadr:Address.status</a>
    /// </summary>
    let ``Address.status`` = _prefixId.prefix "Address.status"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : alias^^xsd:string</para>
    ///   <para>rdfs:label : the address alias</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressAlias">isoadr:Address.theAddressAlias</a>
    /// </summary>
    let ``Address.theAddressAlias`` = _prefixId.prefix "Address.theAddressAlias"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : allows unambiguous determination^^xsd:string</para>
    ///   <para>rdfs:label : the addressed period</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressedPeriod">isoadr:Address.theAddressedPeriod</a>
    /// </summary>
    let ``Address.theAddressedPeriod`` = _prefixId.prefix "Address.theAddressedPeriod"
    /// <summary>
    ///   <para>rdfs:label : Address Alias</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>skos:definition : Information about an address alias.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias">isoadr:AddressAlias</a>
    /// </summary>
    let AddressAlias = _prefixId.prefix "AddressAlias"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : alias^^xsd:string</para>
    ///   <para>rdfs:label : address</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.address">isoadr:AddressAlias.address</a>
    /// </summary>
    let ``AddressAlias.address`` = _prefixId.prefix "AddressAlias.address"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : alias^^xsd:string</para>
    ///   <para>rdfs:label : alias address</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.aliasAddress">isoadr:AddressAlias.aliasAddress</a>
    /// </summary>
    let ``AddressAlias.aliasAddress`` = _prefixId.prefix "AddressAlias.aliasAddress"
    /// <summary>
    ///   <para>skos:definition : Code that specifies which justification for an alias applies to the address at the destination end of the association. The default value is unspecifiedAlias.</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.type">isoadr:AddressAlias.type</a>
    /// </summary>
    let ``AddressAlias.type`` = _prefixId.prefix "AddressAlias.type"
    /// <summary>
    ///   <para>rdfs:label : Address Alias Type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAliasType">isoadr:AddressAliasType</a>
    /// </summary>
    let AddressAliasType = _prefixId.prefix "AddressAliasType"
    /// <summary>
    ///   <para>rdfs:label : Address Class</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClass">isoadr:AddressClass</a>
    /// </summary>
    let AddressClass = _prefixId.prefix "AddressClass"
    /// <summary>
    ///   <para>rdfs:label : Address Class Specification</para>
    ///   <para>skos:definition : Information about the address class.</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification">isoadr:AddressClassSpecification</a>
    /// </summary>
    let AddressClassSpecification = _prefixId.prefix "AddressClassSpecification"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the address class to which the address belongs.</para>
    ///   <para>rdfs:label : class</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.class">isoadr:AddressClassSpecification.class</a>
    /// </summary>
    let ``AddressClassSpecification.class`` =
        _prefixId.prefix "AddressClassSpecification.class"

    /// <summary>
    ///   <para>skos:definition : The set of one or more address component types that may be considered together in various combinations to constitute an address of this class.</para>
    ///   <para>rdfs:label : component</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.component">isoadr:AddressClassSpecification.component</a>
    /// </summary>
    let ``AddressClassSpecification.component`` =
        _prefixId.prefix "AddressClassSpecification.component"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the type of address class.</para>
    ///   <para>rdfs:label : typology</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.typology">isoadr:AddressClassSpecification.typology</a>
    /// </summary>
    let ``AddressClassSpecification.typology`` =
        _prefixId.prefix "AddressClassSpecification.typology"

    /// <summary>
    ///   <para>rdfs:label : Address Component</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>skos:definition : Constituent part of an address.</para>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#constraint : For Provenance conformance, provenance shall be mandatory</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent">isoadr:AddressComponent</a>
    /// </summary>
    let AddressComponent = _prefixId.prefix "AddressComponent"
    /// <summary>
    ///   <para>skos:definition : Unique character string that identifies the address component.</para>
    ///   <para>rdfs:label : id</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.id">isoadr:AddressComponent.id</a>
    /// </summary>
    let ``AddressComponent.id`` = _prefixId.prefix "AddressComponent.id"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the phase an address component has reached in its lifecycle.</para>
    ///   <para>rdfs:label : lifecycle stage</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifecycleStage">isoadr:AddressComponent.lifecycleStage</a>
    /// </summary>
    let ``AddressComponent.lifecycleStage`` =
        _prefixId.prefix "AddressComponent.lifecycleStage"

    /// <summary>
    ///   <para>skos:definition : Information about the period over which an address component exists.
    ///
    /// NOTE See Annex D for lifecycle examples of an address component.</para>
    ///   <para>rdfs:label : lifespan</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifespan">isoadr:AddressComponent.lifespan</a>
    /// </summary>
    let ``AddressComponent.lifespan`` = _prefixId.prefix "AddressComponent.lifespan"
    /// <summary>
    ///   <para>skos:definition : A set of parameters that specify the cultural and linguistic environment.</para>
    ///   <para>rdfs:label : locale</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.locale">isoadr:AddressComponent.locale</a>
    /// </summary>
    let ``AddressComponent.locale`` = _prefixId.prefix "AddressComponent.locale"
    /// <summary>
    ///   <para>skos:definition : Information about the source or origin of the address component, such as the authority who assigned the address component value, the owner of the address component data instance, and the lineage of the address component.</para>
    ///   <para>rdfs:label : provenance</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.provenance">isoadr:AddressComponent.provenance</a>
    /// </summary>
    let ``AddressComponent.provenance`` = _prefixId.prefix "AddressComponent.provenance"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : references^^xsd:string</para>
    ///   <para>rdfs:label : reference object</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.referenceObject">isoadr:AddressComponent.referenceObject</a>
    /// </summary>
    let ``AddressComponent.referenceObject`` =
        _prefixId.prefix "AddressComponent.referenceObject"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : withinScopeOf^^xsd:string</para>
    ///   <para>rdfs:label : scope component</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.scopeComponent">isoadr:AddressComponent.scopeComponent</a>
    /// </summary>
    let ``AddressComponent.scopeComponent`` =
        _prefixId.prefix "AddressComponent.scopeComponent"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the kind of address component.</para>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#constraint : type is mandatory if there are no subclasses of AddressableObject^^xsd:string</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.type">isoadr:AddressComponent.type</a>
    /// </summary>
    let ``AddressComponent.type`` = _prefixId.prefix "AddressComponent.type"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : withinScopeOf^^xsd:string</para>
    ///   <para>rdfs:label : value component</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueComponent">isoadr:AddressComponent.valueComponent</a>
    /// </summary>
    let ``AddressComponent.valueComponent`` =
        _prefixId.prefix "AddressComponent.valueComponent"

    /// <summary>
    ///   <para>skos:definition : Value of and information about one or more address component values.</para>
    ///   <para>rdfs:label : value information</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueInformation">isoadr:AddressComponent.valueInformation</a>
    /// </summary>
    let ``AddressComponent.valueInformation`` =
        _prefixId.prefix "AddressComponent.valueInformation"

    /// <summary>
    ///   <para>rdfs:label : Address Component Type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentType">isoadr:AddressComponentType</a>
    /// </summary>
    let AddressComponentType = _prefixId.prefix "AddressComponentType"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>rdfs:label : Address Component Value</para>
    ///   <para>skos:definition : Information about the value of an address component.</para>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#constraint : For Locale conformance, locale shall be mandatory</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue">isoadr:AddressComponentValue</a>
    /// </summary>
    let AddressComponentValue = _prefixId.prefix "AddressComponentValue"

    /// <summary>
    ///   <para>skos:definition : A set of parameters that specify the cultural and linguistic environment.</para>
    ///   <para>rdfs:label : locale</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.locale">isoadr:AddressComponentValue.locale</a>
    /// </summary>
    let ``AddressComponentValue.locale`` =
        _prefixId.prefix "AddressComponentValue.locale"

    /// <summary>
    ///   <para>skos:definition : Indicates the ranking of the address component in a set of alternatives. 1 indicates highest ranking.
    ///
    /// EXAMPLE 1 A building on a street corner could be referenced by two addresses, each with a different component value for the thoroughfare name address component. For one of them the preferenceLevel could be set to 1.
    ///
    /// EXAMPLE 2 In Switzerland, Biel (German) and Bienne (French) are different address components with the same preference level.</para>
    ///   <para>rdfs:label : preference level</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.preferenceLevel">isoadr:AddressComponentValue.preferenceLevel</a>
    /// </summary>
    let ``AddressComponentValue.preferenceLevel`` =
        _prefixId.prefix "AddressComponentValue.preferenceLevel"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the kind of value, i.e. whether it is a variation of the default address component value, and if so, what the variation is.</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.type">isoadr:AddressComponentValue.type</a>
    /// </summary>
    let ``AddressComponentValue.type`` = _prefixId.prefix "AddressComponentValue.type"
    /// <summary>
    ///   <para>skos:definition : One or more instances of the value of the address component.</para>
    ///   <para>rdfs:label : value</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.value">isoadr:AddressComponentValue.value</a>
    /// </summary>
    let ``AddressComponentValue.value`` = _prefixId.prefix "AddressComponentValue.value"
    /// <summary>
    ///   <para>rdfs:label : Address Component Value Type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValueType">isoadr:AddressComponentValueType</a>
    /// </summary>
    let AddressComponentValueType = _prefixId.prefix "AddressComponentValueType"
    /// <summary>
    ///   <para>rdfs:label : Address Lifecycle Stage</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressLifecycleStage">isoadr:AddressLifecycleStage</a>
    /// </summary>
    let AddressLifecycleStage = _prefixId.prefix "AddressLifecycleStage"
    /// <summary>
    ///   <para>skos:definition : Information about the representative position of an address.</para>
    ///   <para>rdfs:label : Address Position</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition">isoadr:AddressPosition</a>
    /// </summary>
    let AddressPosition = _prefixId.prefix "AddressPosition"
    /// <summary>
    ///   <para>skos:definition : Geometry (coordinates) representing the address position.</para>
    ///   <para>rdfs:label : geometry</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.geometry">isoadr:AddressPosition.geometry</a>
    /// </summary>
    let ``AddressPosition.geometry`` = _prefixId.prefix "AddressPosition.geometry"
    /// <summary>
    ///   <para>skos:definition : Code that specifies how the geometry shall be interpreted.
    ///
    /// EXAMPLES centroid, streetFront, approximated</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.type">isoadr:AddressPosition.type</a>
    /// </summary>
    let ``AddressPosition.type`` = _prefixId.prefix "AddressPosition.type"
    /// <summary>
    ///   <para>rdfs:label : Address Position Type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPositionType">isoadr:AddressPositionType</a>
    /// </summary>
    let AddressPositionType = _prefixId.prefix "AddressPositionType"
    /// <summary>
    ///   <para>skos:definition : Provenance information, e.g. the source or origin of the record, changes to the record, and organisations or individuals that have had custody of the record since its creation.</para>
    ///   <para>rdfs:label : Address Provenance</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance">isoadr:AddressProvenance</a>
    /// </summary>
    let AddressProvenance = _prefixId.prefix "AddressProvenance"
    /// <summary>
    ///   <para>skos:definition : The body that assigns the address or address component value.</para>
    ///   <para>rdfs:label : authority</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.authority">isoadr:AddressProvenance.authority</a>
    /// </summary>
    let ``AddressProvenance.authority`` = _prefixId.prefix "AddressProvenance.authority"
    /// <summary>
    ///   <para>skos:definition : Provenance, source(s) and production process(es) used in producing an address or address component.</para>
    ///   <para>rdfs:label : lineage</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.lineage">isoadr:AddressProvenance.lineage</a>
    /// </summary>
    let ``AddressProvenance.lineage`` = _prefixId.prefix "AddressProvenance.lineage"
    /// <summary>
    ///   <para>skos:definition : Organization that maintains the data.</para>
    ///   <para>rdfs:label : owner</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.owner">isoadr:AddressProvenance.owner</a>
    /// </summary>
    let ``AddressProvenance.owner`` = _prefixId.prefix "AddressProvenance.owner"
    /// <summary>
    ///   <para>skos:definition : A reference to a specification and description of a set of address class specifications, which  specify the typology and the set of valid component types for the class.</para>
    ///   <para>rdfs:label : Address Specification</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification">isoadr:AddressSpecification</a>
    /// </summary>
    let AddressSpecification = _prefixId.prefix "AddressSpecification"

    /// <summary>
    ///   <para>skos:definition : Reference to a specification or document that contains a definition of the address classes.</para>
    ///   <para>rdfs:label : address specification citation</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.addressSpecificationCitation">isoadr:AddressSpecification.addressSpecificationCitation</a>
    /// </summary>
    let ``AddressSpecification.addressSpecificationCitation`` =
        _prefixId.prefix "AddressSpecification.addressSpecificationCitation"

    /// <summary>
    ///   <para>skos:definition : Information about one or more address classes, such as typology and valid component types.^^xsd:string</para>
    ///   <para>rdfs:label : class specification</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.classSpecification">isoadr:AddressSpecification.classSpecification</a>
    /// </summary>
    let ``AddressSpecification.classSpecification`` =
        _prefixId.prefix "AddressSpecification.classSpecification"

    /// <summary>
    ///   <para>rdfs:label : Address Status</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressStatus">isoadr:AddressStatus</a>
    /// </summary>
    let AddressStatus = _prefixId.prefix "AddressStatus"
    /// <summary>
    ///   <para>rdfs:label : Address Typology</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressTypology">isoadr:AddressTypology</a>
    /// </summary>
    let AddressTypology = _prefixId.prefix "AddressTypology"
    /// <summary>
    ///   <para>rdfs:label : Addressable Object</para>
    ///   <para>skos:definition : An object that may be assigned an address.</para>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#constraint : If no AddressableObject subclasses, then type is mandatory</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject">isoadr:AddressableObject</a>
    /// </summary>
    let AddressableObject = _prefixId.prefix "AddressableObject"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : parent^^xsd:string</para>
    ///   <para>rdfs:label : child addressable object</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.childAddressableObject">isoadr:AddressableObject.childAddressableObject</a>
    /// </summary>
    let ``AddressableObject.childAddressableObject`` =
        _prefixId.prefix "AddressableObject.childAddressableObject"

    /// <summary>
    ///   <para>skos:definition : Unique character string that identifies the addressable object.</para>
    ///   <para>rdfs:label : id</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.id">isoadr:AddressableObject.id</a>
    /// </summary>
    let ``AddressableObject.id`` = _prefixId.prefix "AddressableObject.id"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the phase an addressable object has reached in its lifecycle.</para>
    ///   <para>rdfs:label : lifecycle stage</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifecycleStage">isoadr:AddressableObject.lifecycleStage</a>
    /// </summary>
    let ``AddressableObject.lifecycleStage`` =
        _prefixId.prefix "AddressableObject.lifecycleStage"

    /// <summary>
    ///   <para>skos:definition : Information about the period over which an addressable object exists.</para>
    ///   <para>rdfs:label : lifespan</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifespan">isoadr:AddressableObject.lifespan</a>
    /// </summary>
    let ``AddressableObject.lifespan`` = _prefixId.prefix "AddressableObject.lifespan"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : parent^^xsd:string</para>
    ///   <para>rdfs:label : parent addressable object</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.parentAddressableObject">isoadr:AddressableObject.parentAddressableObject</a>
    /// </summary>
    let ``AddressableObject.parentAddressableObject`` =
        _prefixId.prefix "AddressableObject.parentAddressableObject"

    /// <summary>
    ///   <para>skos:definition : Geometry (coordinates) representing the addressable object.</para>
    ///   <para>rdfs:label : position</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.position">isoadr:AddressableObject.position</a>
    /// </summary>
    let ``AddressableObject.position`` = _prefixId.prefix "AddressableObject.position"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : allows unambiguous determination^^xsd:string</para>
    ///   <para>rdfs:label : the addressed period</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.theAddressedPeriod">isoadr:AddressableObject.theAddressedPeriod</a>
    /// </summary>
    let ``AddressableObject.theAddressedPeriod`` =
        _prefixId.prefix "AddressableObject.theAddressedPeriod"

    /// <summary>
    ///   <para>skos:definition : Code that specifies the kind of object to which an address may be assigned.</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.type">isoadr:AddressableObject.type</a>
    /// </summary>
    let ``AddressableObject.type`` = _prefixId.prefix "AddressableObject.type"

    /// <summary>
    ///   <para>rdfs:label : Addressable Object Lifecycle Stage</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectLifecycleStage">isoadr:AddressableObjectLifecycleStage</a>
    /// </summary>
    let AddressableObjectLifecycleStage =
        _prefixId.prefix "AddressableObjectLifecycleStage"

    /// <summary>
    ///   <para>rdfs:label : Addressable Object Type^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectType">isoadr:AddressableObjectType</a>
    /// </summary>
    let AddressableObjectType = _prefixId.prefix "AddressableObjectType"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>rdfs:label : Addressed Period</para>
    ///   <para>skos:definition : The period during which the address as associated with the addressed object.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod">isoadr:AddressedPeriod</a>
    /// </summary>
    let AddressedPeriod = _prefixId.prefix "AddressedPeriod"
    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : allows unambiguous determination^^xsd:string</para>
    ///   <para>rdfs:label : address</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.address">isoadr:AddressedPeriod.address</a>
    /// </summary>
    let ``AddressedPeriod.address`` = _prefixId.prefix "AddressedPeriod.address"

    /// <summary>
    ///   <para>skos:definition : Date and time from which the addressed object is unambiguously determined by the address.</para>
    ///   <para>rdfs:label : addressed from</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedFrom">isoadr:AddressedPeriod.addressedFrom</a>
    /// </summary>
    let ``AddressedPeriod.addressedFrom`` =
        _prefixId.prefix "AddressedPeriod.addressedFrom"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : allows unambiguous determination^^xsd:string</para>
    ///   <para>rdfs:label : addressed object</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedObject">isoadr:AddressedPeriod.addressedObject</a>
    /// </summary>
    let ``AddressedPeriod.addressedObject`` =
        _prefixId.prefix "AddressedPeriod.addressedObject"

    /// <summary>
    ///   <para>skos:definition : Date and time when the addressed object ceased to be unambiguously determined by the address.</para>
    ///   <para>rdfs:label : addressed to</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedTo">isoadr:AddressedPeriod.addressedTo</a>
    /// </summary>
    let ``AddressedPeriod.addressedTo`` = _prefixId.prefix "AddressedPeriod.addressedTo"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>skos:definition : Information to describe the lifespan of an address, adress component or addressable object.</para>
    ///   <para>rdfs:label : Lifespan^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan">isoadr:Lifespan</a>
    /// </summary>
    let Lifespan = _prefixId.prefix "Lifespan"
    /// <summary>
    ///   <para>skos:definition : Specifies the date and time at which this version of the data object was superseded by another version or retired in the dataset.</para>
    ///   <para>rdfs:label : close record</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.closeRecord">isoadr:Lifespan.closeRecord</a>
    /// </summary>
    let ``Lifespan.closeRecord`` = _prefixId.prefix "Lifespan.closeRecord"
    /// <summary>
    ///   <para>skos:definition : Specifies the date and time at which this version of the data object was inserted into the dataset.</para>
    ///   <para>rdfs:label : open record</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.openRecord">isoadr:Lifespan.openRecord</a>
    /// </summary>
    let ``Lifespan.openRecord`` = _prefixId.prefix "Lifespan.openRecord"
    /// <summary>
    ///   <para>skos:definition : Date and time from which the object is valid in the physical world.</para>
    ///   <para>rdfs:label : valid from</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validFrom">isoadr:Lifespan.validFrom</a>
    /// </summary>
    let ``Lifespan.validFrom`` = _prefixId.prefix "Lifespan.validFrom"
    /// <summary>
    ///   <para>skos:definition : Date and time when this object ceased to be valid in the physical world.</para>
    ///   <para>rdfs:label : valid to</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validTo">isoadr:Lifespan.validTo</a>
    /// </summary>
    let ``Lifespan.validTo`` = _prefixId.prefix "Lifespan.validTo"
    /// <summary>
    ///   <para>skos:definition : Unique identifier of this variant of the address record.
    ///
    /// NOTE The version is incremented with any change to the data object.</para>
    ///   <para>rdfs:label : version</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.version">isoadr:Lifespan.version</a>
    /// </summary>
    let ``Lifespan.version`` = _prefixId.prefix "Lifespan.version"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <para>skos:definition : The object to which the address component value may refer.</para>
    ///   <para>rdfs:label : Reference Object^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject">isoadr:ReferenceObject</a>
    /// </summary>
    let ReferenceObject = _prefixId.prefix "ReferenceObject"

    /// <summary>
    ///   <para>http://def.isotc211.org/iso19150/-2/2012/base#associationName : references^^xsd:string</para>
    ///   <para>rdfs:label : address component</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.addressComponent">isoadr:ReferenceObject.addressComponent</a>
    /// </summary>
    let ``ReferenceObject.addressComponent`` =
        _prefixId.prefix "ReferenceObject.addressComponent"

    /// <summary>
    ///   <para>skos:definition : Geometry (coordinates) representing the reference object.</para>
    ///   <para>rdfs:label : geometry</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.geometry">isoadr:ReferenceObject.geometry</a>
    /// </summary>
    let ``ReferenceObject.geometry`` = _prefixId.prefix "ReferenceObject.geometry"
    /// <summary>
    ///   <para>skos:definition : Unique character string that identifies the reference object.</para>
    ///   <para>rdfs:label : id</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.id">isoadr:ReferenceObject.id</a>
    /// </summary>
    let ``ReferenceObject.id`` = _prefixId.prefix "ReferenceObject.id"
    /// <summary>
    ///   <para>skos:definition : Code that specifies the kind of reference object.</para>
    ///   <para>rdfs:label : type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.type">isoadr:ReferenceObject.type</a>
    /// </summary>
    let ``ReferenceObject.type`` = _prefixId.prefix "ReferenceObject.type"
    /// <summary>
    ///   <para>rdfs:label : Reference Object Type</para>
    ///   <para>rdfs:isDefinedBy : http://standards.iso.org/iso/19160/-1/ed-1/en/^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObjectType">isoadr:ReferenceObjectType</a>
    /// </summary>
    let ReferenceObjectType = _prefixId.prefix "ReferenceObjectType"
