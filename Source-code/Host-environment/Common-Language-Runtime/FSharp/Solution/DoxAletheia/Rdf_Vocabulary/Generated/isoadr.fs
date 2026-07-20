namespace http.reference.data.gov.au.def.ont.iso19160_1_address.hash

open DoxAletheia

module isoadr =
    let _namespace_name = "http://reference.data.gov.au/def/ont/iso19160-1-address#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.preferenceLevel"></see>
    /// </summary>
    let ``Address.preferenceLevel`` = _prefix "Address.preferenceLevel"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.position"></see>
    /// </summary>
    let ``Address.position`` = _prefix "Address.position"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition"></see>
    /// </summary>
    let AddressPosition = _prefix "AddressPosition"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.status"></see>
    /// </summary>
    let ``Address.status`` = _prefix "Address.status"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressStatus"></see>
    /// </summary>
    let AddressStatus = _prefix "AddressStatus"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifespan"></see>
    /// </summary>
    let ``Address.lifespan`` = _prefix "Address.lifespan"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.addressComponent"></see>
    /// </summary>
    let ``Address.addressComponent`` = _prefix "Address.addressComponent"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_branch"></see>
    /// </summary>
    let ``Address.business_branch`` = _prefix "Address.business_branch"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan"></see>
    /// </summary>
    let Lifespan = _prefix "Lifespan"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.employee"></see>
    /// </summary>
    let ``Address.employee`` = _prefix "Address.employee"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.locale"></see>
    /// </summary>
    let ``Address.locale`` = _prefix "Address.locale"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifecycleStage"></see>
    /// </summary>
    let ``Address.lifecycleStage`` = _prefix "Address.lifecycleStage"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.specification"></see>
    /// </summary>
    let ``Address.specification`` = _prefix "Address.specification"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification"></see>
    /// </summary>
    let AddressSpecification = _prefix "AddressSpecification"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressAlias"></see>
    /// </summary>
    let ``Address.theAddressAlias`` = _prefix "Address.theAddressAlias"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias"></see>
    /// </summary>
    let AddressAlias = _prefix "AddressAlias"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.id"></see>
    /// </summary>
    let ``Address.id`` = _prefix "Address.id"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.childAddress"></see>
    /// </summary>
    let ``Address.childAddress`` = _prefix "Address.childAddress"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_headOffice"></see>
    /// </summary>
    let ``Address.business_headOffice`` = _prefix "Address.business_headOffice"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent"></see>
    /// </summary>
    let AddressComponent = _prefix "AddressComponent"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressedPeriod"></see>
    /// </summary>
    let ``Address.theAddressedPeriod`` = _prefix "Address.theAddressedPeriod"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod"></see>
    /// </summary>
    let AddressedPeriod = _prefix "AddressedPeriod"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.class"></see>
    /// </summary>
    let ``Address.class`` = _prefix "Address.class"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClass"></see>
    /// </summary>
    let AddressClass = _prefix "AddressClass"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.parentAddress"></see>
    /// </summary>
    let ``Address.parentAddress`` = _prefix "Address.parentAddress"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.provenance"></see>
    /// </summary>
    let ``Address.provenance`` = _prefix "Address.provenance"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance"></see>
    /// </summary>
    let AddressProvenance = _prefix "AddressProvenance"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressLifecycleStage"></see>
    /// </summary>
    let AddressLifecycleStage = _prefix "AddressLifecycleStage"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.client"></see>
    /// </summary>
    let ``Address.client`` = _prefix "Address.client"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.address"></see>
    /// </summary>
    let ``AddressAlias.address`` = _prefix "AddressAlias.address"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.aliasAddress"></see>
    /// </summary>
    let ``AddressAlias.aliasAddress`` = _prefix "AddressAlias.aliasAddress"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.address"></see>
    /// </summary>
    let ``AddressedPeriod.address`` = _prefix "AddressedPeriod.address"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.type"></see>
    /// </summary>
    let ``AddressAlias.type`` = _prefix "AddressAlias.type"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAliasType"></see>
    /// </summary>
    let AddressAliasType = _prefix "AddressAliasType"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification"></see>
    /// </summary>
    let AddressClassSpecification = _prefix "AddressClassSpecification"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.component"></see>
    /// </summary>
    let ``AddressClassSpecification.component`` =
        _prefix "AddressClassSpecification.component"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.typology"></see>
    /// </summary>
    let ``AddressClassSpecification.typology`` =
        _prefix "AddressClassSpecification.typology"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressTypology"></see>
    /// </summary>
    let AddressTypology = _prefix "AddressTypology"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.class"></see>
    /// </summary>
    let ``AddressClassSpecification.class`` = _prefix "AddressClassSpecification.class"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentType"></see>
    /// </summary>
    let AddressComponentType = _prefix "AddressComponentType"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.type"></see>
    /// </summary>
    let ``AddressComponent.type`` = _prefix "AddressComponent.type"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.scopeComponent"></see>
    /// </summary>
    let ``AddressComponent.scopeComponent`` = _prefix "AddressComponent.scopeComponent"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.provenance"></see>
    /// </summary>
    let ``AddressComponent.provenance`` = _prefix "AddressComponent.provenance"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifespan"></see>
    /// </summary>
    let ``AddressComponent.lifespan`` = _prefix "AddressComponent.lifespan"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.locale"></see>
    /// </summary>
    let ``AddressComponent.locale`` = _prefix "AddressComponent.locale"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueComponent"></see>
    /// </summary>
    let ``AddressComponent.valueComponent`` = _prefix "AddressComponent.valueComponent"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.id"></see>
    /// </summary>
    let ``AddressComponent.id`` = _prefix "AddressComponent.id"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifecycleStage"></see>
    /// </summary>
    let ``AddressComponent.lifecycleStage`` = _prefix "AddressComponent.lifecycleStage"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueInformation"></see>
    /// </summary>
    let ``AddressComponent.valueInformation`` =
        _prefix "AddressComponent.valueInformation"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue"></see>
    /// </summary>
    let AddressComponentValue = _prefix "AddressComponentValue"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.referenceObject"></see>
    /// </summary>
    let ``AddressComponent.referenceObject`` =
        _prefix "AddressComponent.referenceObject"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject"></see>
    /// </summary>
    let ReferenceObject = _prefix "ReferenceObject"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.addressComponent"></see>
    /// </summary>
    let ``ReferenceObject.addressComponent`` =
        _prefix "ReferenceObject.addressComponent"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.preferenceLevel"></see>
    /// </summary>
    let ``AddressComponentValue.preferenceLevel`` =
        _prefix "AddressComponentValue.preferenceLevel"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.type"></see>
    /// </summary>
    let ``AddressComponentValue.type`` = _prefix "AddressComponentValue.type"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValueType"></see>
    /// </summary>
    let AddressComponentValueType = _prefix "AddressComponentValueType"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.locale"></see>
    /// </summary>
    let ``AddressComponentValue.locale`` = _prefix "AddressComponentValue.locale"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.value"></see>
    /// </summary>
    let ``AddressComponentValue.value`` = _prefix "AddressComponentValue.value"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.geometry"></see>
    /// </summary>
    let ``AddressPosition.geometry`` = _prefix "AddressPosition.geometry"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.type"></see>
    /// </summary>
    let ``AddressPosition.type`` = _prefix "AddressPosition.type"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPositionType"></see>
    /// </summary>
    let AddressPositionType = _prefix "AddressPositionType"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.authority"></see>
    /// </summary>
    let ``AddressProvenance.authority`` = _prefix "AddressProvenance.authority"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.lineage"></see>
    /// </summary>
    let ``AddressProvenance.lineage`` = _prefix "AddressProvenance.lineage"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.owner"></see>
    /// </summary>
    let ``AddressProvenance.owner`` = _prefix "AddressProvenance.owner"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.addressSpecificationCitation"></see>
    /// </summary>
    let ``AddressSpecification.addressSpecificationCitation`` =
        _prefix "AddressSpecification.addressSpecificationCitation"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.classSpecification"></see>
    /// </summary>
    let ``AddressSpecification.classSpecification`` =
        _prefix "AddressSpecification.classSpecification"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject"></see>
    /// </summary>
    let AddressableObject = _prefix "AddressableObject"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.type"></see>
    /// </summary>
    let ``AddressableObject.type`` = _prefix "AddressableObject.type"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.position"></see>
    /// </summary>
    let ``AddressableObject.position`` = _prefix "AddressableObject.position"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifespan"></see>
    /// </summary>
    let ``AddressableObject.lifespan`` = _prefix "AddressableObject.lifespan"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.id"></see>
    /// </summary>
    let ``AddressableObject.id`` = _prefix "AddressableObject.id"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifecycleStage"></see>
    /// </summary>
    let ``AddressableObject.lifecycleStage`` =
        _prefix "AddressableObject.lifecycleStage"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectLifecycleStage"></see>
    /// </summary>
    let AddressableObjectLifecycleStage = _prefix "AddressableObjectLifecycleStage"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.parentAddressableObject"></see>
    /// </summary>
    let ``AddressableObject.parentAddressableObject`` =
        _prefix "AddressableObject.parentAddressableObject"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectType"></see>
    /// </summary>
    let AddressableObjectType = _prefix "AddressableObjectType"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.theAddressedPeriod"></see>
    /// </summary>
    let ``AddressableObject.theAddressedPeriod`` =
        _prefix "AddressableObject.theAddressedPeriod"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.childAddressableObject"></see>
    /// </summary>
    let ``AddressableObject.childAddressableObject`` =
        _prefix "AddressableObject.childAddressableObject"

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedObject"></see>
    /// </summary>
    let ``AddressedPeriod.addressedObject`` = _prefix "AddressedPeriod.addressedObject"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedFrom"></see>
    /// </summary>
    let ``AddressedPeriod.addressedFrom`` = _prefix "AddressedPeriod.addressedFrom"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedTo"></see>
    /// </summary>
    let ``AddressedPeriod.addressedTo`` = _prefix "AddressedPeriod.addressedTo"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validFrom"></see>
    /// </summary>
    let ``Lifespan.validFrom`` = _prefix "Lifespan.validFrom"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.openRecord"></see>
    /// </summary>
    let ``Lifespan.openRecord`` = _prefix "Lifespan.openRecord"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.closeRecord"></see>
    /// </summary>
    let ``Lifespan.closeRecord`` = _prefix "Lifespan.closeRecord"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.version"></see>
    /// </summary>
    let ``Lifespan.version`` = _prefix "Lifespan.version"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validTo"></see>
    /// </summary>
    let ``Lifespan.validTo`` = _prefix "Lifespan.validTo"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.geometry"></see>
    /// </summary>
    let ``ReferenceObject.geometry`` = _prefix "ReferenceObject.geometry"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.id"></see>
    /// </summary>
    let ``ReferenceObject.id`` = _prefix "ReferenceObject.id"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.type"></see>
    /// </summary>
    let ``ReferenceObject.type`` = _prefix "ReferenceObject.type"
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObjectType"></see>
    /// </summary>
    let ReferenceObjectType = _prefix "ReferenceObjectType"
