namespace http.reference.data.gov.au.def.ont.iso19160_1_address.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module isoadr =
    let _namespace_iri = Namespace_Iri isoadr |> NamespaceIRI
    /// <summary>
    ///   <para>isoadr:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address">http://reference.data.gov.au/def/ont/iso19160-1-address#Address</seealso>
    let Address = Prefixed_Name(isoadr, "Address") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:Address.lifespan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lifespan</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifespan">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifespan</seealso>
    let ``Address.lifespan`` = Prefixed_Name(isoadr, "Address.lifespan") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.business_branch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>business</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_branch">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_branch</seealso>
    let ``Address.business_branch`` =
        Prefixed_Name(isoadr, "Address.business_branch") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>employee</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.employee">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.employee</seealso>
    let ``Address.employee`` = Prefixed_Name(isoadr, "Address.employee") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specification</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.specification">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.specification</seealso>
    let ``Address.specification`` =
        Prefixed_Name(isoadr, "Address.specification") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.childAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>child address</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.childAddress">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.childAddress</seealso>
    let ``Address.childAddress`` =
        Prefixed_Name(isoadr, "Address.childAddress") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.preferenceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>preference level</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.preferenceLevel">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.preferenceLevel</seealso>
    let ``Address.preferenceLevel`` =
        Prefixed_Name(isoadr, "Address.preferenceLevel") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Status</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressStatus">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressStatus</seealso>
    let AddressStatus = Prefixed_Name(isoadr, "AddressStatus") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:Lifespan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lifespan</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan">http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan</seealso>
    let Lifespan = Prefixed_Name(isoadr, "Lifespan") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:Address.status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.status">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.status</seealso>
    let ``Address.status`` = Prefixed_Name(isoadr, "Address.status") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:ReferenceObject.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.type">http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.type</seealso>
    let ``ReferenceObject.type`` =
        Prefixed_Name(isoadr, "ReferenceObject.type") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>provenance</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.provenance">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.provenance</seealso>
    let ``AddressComponent.provenance`` =
        Prefixed_Name(isoadr, "AddressComponent.provenance") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.locale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>locale</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.locale">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.locale</seealso>
    let ``AddressComponent.locale`` =
        Prefixed_Name(isoadr, "AddressComponent.locale") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.lifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lifecycle stage</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifecycleStage">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifecycleStage</seealso>
    let ``AddressComponent.lifecycleStage`` =
        Prefixed_Name(isoadr, "AddressComponent.lifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Component Value</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue</seealso>
    let AddressComponentValue =
        Prefixed_Name(isoadr, "AddressComponentValue") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Specification</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification</seealso>
    let AddressSpecification =
        Prefixed_Name(isoadr, "AddressSpecification") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.valueInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>value information</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueInformation">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueInformation</seealso>
    let ``AddressComponent.valueInformation`` =
        Prefixed_Name(isoadr, "AddressComponent.valueInformation") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:ReferenceObject.addressComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>address component</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.addressComponent">http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.addressComponent</seealso>
    let ``ReferenceObject.addressComponent`` =
        Prefixed_Name(isoadr, "ReferenceObject.addressComponent") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentValue.preferenceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>preference level</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.preferenceLevel">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.preferenceLevel</seealso>
    let ``AddressComponentValue.preferenceLevel`` =
        Prefixed_Name(isoadr, "AddressComponentValue.preferenceLevel") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentValue.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.type">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.type</seealso>
    let ``AddressComponentValue.type`` =
        Prefixed_Name(isoadr, "AddressComponentValue.type") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentValue.locale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>locale</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.locale">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.locale</seealso>
    let ``AddressComponentValue.locale`` =
        Prefixed_Name(isoadr, "AddressComponentValue.locale") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>id</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.id">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.id</seealso>
    let ``Address.id`` = Prefixed_Name(isoadr, "Address.id") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:AddressComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Component</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent</seealso>
    let AddressComponent = Prefixed_Name(isoadr, "AddressComponent") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.theAddressedPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>the addressed period</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressedPeriod">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressedPeriod</seealso>
    let ``Address.theAddressedPeriod`` =
        Prefixed_Name(isoadr, "Address.theAddressedPeriod") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Provenance</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance</seealso>
    let AddressProvenance = Prefixed_Name(isoadr, "AddressProvenance") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentValue.value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>value</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.value">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValue.value</seealso>
    let ``AddressComponentValue.value`` =
        Prefixed_Name(isoadr, "AddressComponentValue.value") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Component Value Type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValueType">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentValueType</seealso>
    let AddressComponentValueType =
        Prefixed_Name(isoadr, "AddressComponentValueType") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressPosition.geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geometry</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.geometry">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.geometry</seealso>
    let ``AddressPosition.geometry`` =
        Prefixed_Name(isoadr, "AddressPosition.geometry") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.client</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>client</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.client">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.client</seealso>
    let ``Address.client`` = Prefixed_Name(isoadr, "Address.client") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:ReferenceObject.geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geometry</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.geometry">http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.geometry</seealso>
    let ``ReferenceObject.geometry`` =
        Prefixed_Name(isoadr, "ReferenceObject.geometry") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:ReferenceObject.id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>id</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.id">http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject.id</seealso>
    let ``ReferenceObject.id`` =
        Prefixed_Name(isoadr, "ReferenceObject.id") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:ReferenceObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reference Object Type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObjectType">http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObjectType</seealso>
    let ReferenceObjectType =
        Prefixed_Name(isoadr, "ReferenceObjectType") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressProvenance.authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>authority</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.authority">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.authority</seealso>
    let ``AddressProvenance.authority`` =
        Prefixed_Name(isoadr, "AddressProvenance.authority") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressSpecification.addressSpecificationCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>address specification citation</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.addressSpecificationCitation">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.addressSpecificationCitation</seealso>
    let ``AddressSpecification.addressSpecificationCitation`` =
        Prefixed_Name(isoadr, "AddressSpecification.addressSpecificationCitation") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Addressable Object</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject</seealso>
    let AddressableObject = Prefixed_Name(isoadr, "AddressableObject") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.type">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.type</seealso>
    let ``AddressableObject.type`` =
        Prefixed_Name(isoadr, "AddressableObject.type") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>position</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.position">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.position</seealso>
    let ``AddressableObject.position`` =
        Prefixed_Name(isoadr, "AddressableObject.position") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.lifespan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lifespan</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifespan">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifespan</seealso>
    let ``AddressableObject.lifespan`` =
        Prefixed_Name(isoadr, "AddressableObject.lifespan") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>id</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.id">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.id</seealso>
    let ``AddressableObject.id`` =
        Prefixed_Name(isoadr, "AddressableObject.id") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Addressable Object Type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectType">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectType</seealso>
    let AddressableObjectType =
        Prefixed_Name(isoadr, "AddressableObjectType") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.theAddressedPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>the addressed period</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.theAddressedPeriod">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.theAddressedPeriod</seealso>
    let ``AddressableObject.theAddressedPeriod`` =
        Prefixed_Name(isoadr, "AddressableObject.theAddressedPeriod") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Lifecycle Stage</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressLifecycleStage">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressLifecycleStage</seealso>
    let AddressLifecycleStage =
        Prefixed_Name(isoadr, "AddressLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressSpecification.classSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>class specification</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.classSpecification">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressSpecification.classSpecification</seealso>
    let ``AddressSpecification.classSpecification`` =
        Prefixed_Name(isoadr, "AddressSpecification.classSpecification") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.lifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lifecycle stage</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifecycleStage">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.lifecycleStage</seealso>
    let ``AddressableObject.lifecycleStage`` =
        Prefixed_Name(isoadr, "AddressableObject.lifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.parentAddressableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>parent addressable object</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.parentAddressableObject">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.parentAddressableObject</seealso>
    let ``AddressableObject.parentAddressableObject`` =
        Prefixed_Name(isoadr, "AddressableObject.parentAddressableObject") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressedPeriod.addressedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>addressed object</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedObject">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedObject</seealso>
    let ``AddressedPeriod.addressedObject`` =
        Prefixed_Name(isoadr, "AddressedPeriod.addressedObject") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressedPeriod.addressedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>addressed from</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedFrom">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedFrom</seealso>
    let ``AddressedPeriod.addressedFrom`` =
        Prefixed_Name(isoadr, "AddressedPeriod.addressedFrom") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressedPeriod.addressedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>addressed to</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedTo">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.addressedTo</seealso>
    let ``AddressedPeriod.addressedTo`` =
        Prefixed_Name(isoadr, "AddressedPeriod.addressedTo") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Lifespan.validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>valid from</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validFrom">http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validFrom</seealso>
    let ``Lifespan.validFrom`` =
        Prefixed_Name(isoadr, "Lifespan.validFrom") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Lifespan.openRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>open record</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.openRecord">http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.openRecord</seealso>
    let ``Lifespan.openRecord`` =
        Prefixed_Name(isoadr, "Lifespan.openRecord") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Lifespan.closeRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>close record</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.closeRecord">http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.closeRecord</seealso>
    let ``Lifespan.closeRecord`` =
        Prefixed_Name(isoadr, "Lifespan.closeRecord") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Lifespan.version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>version</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.version">http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.version</seealso>
    let ``Lifespan.version`` = Prefixed_Name(isoadr, "Lifespan.version") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:Lifespan.validTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>valid to</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validTo">http://reference.data.gov.au/def/ont/iso19160-1-address#Lifespan.validTo</seealso>
    let ``Lifespan.validTo`` = Prefixed_Name(isoadr, "Lifespan.validTo") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObjectLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Addressable Object Lifecycle Stage</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectLifecycleStage">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObjectLifecycleStage</seealso>
    let AddressableObjectLifecycleStage =
        Prefixed_Name(isoadr, "AddressableObjectLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressableObject.childAddressableObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>child addressable object</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.childAddressableObject">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressableObject.childAddressableObject</seealso>
    let ``AddressableObject.childAddressableObject`` =
        Prefixed_Name(isoadr, "AddressableObject.childAddressableObject") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressAlias.address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>address</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.address">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.address</seealso>
    let ``AddressAlias.address`` =
        Prefixed_Name(isoadr, "AddressAlias.address") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressedPeriod.address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>address</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.address">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod.address</seealso>
    let ``AddressedPeriod.address`` =
        Prefixed_Name(isoadr, "AddressedPeriod.address") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressAlias.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.type">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.type</seealso>
    let ``AddressAlias.type`` =
        Prefixed_Name(isoadr, "AddressAlias.type") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressAlias.aliasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>alias address</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.aliasAddress">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias.aliasAddress</seealso>
    let ``AddressAlias.aliasAddress`` =
        Prefixed_Name(isoadr, "AddressAlias.aliasAddress") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressAliasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Alias Type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAliasType">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAliasType</seealso>
    let AddressAliasType = Prefixed_Name(isoadr, "AddressAliasType") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressClassSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Class Specification</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification</seealso>
    let AddressClassSpecification =
        Prefixed_Name(isoadr, "AddressClassSpecification") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressClassSpecification.component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>component</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.component">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.component</seealso>
    let ``AddressClassSpecification.component`` =
        Prefixed_Name(isoadr, "AddressClassSpecification.component") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressClassSpecification.class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>class</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.class">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.class</seealso>
    let ``AddressClassSpecification.class`` =
        Prefixed_Name(isoadr, "AddressClassSpecification.class") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressClassSpecification.typology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>typology</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.typology">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClassSpecification.typology</seealso>
    let ``AddressClassSpecification.typology`` =
        Prefixed_Name(isoadr, "AddressClassSpecification.typology") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.type">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.type</seealso>
    let ``AddressComponent.type`` =
        Prefixed_Name(isoadr, "AddressComponent.type") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.scopeComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>scope component</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.scopeComponent">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.scopeComponent</seealso>
    let ``AddressComponent.scopeComponent`` =
        Prefixed_Name(isoadr, "AddressComponent.scopeComponent") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.lifespan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lifespan</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifespan">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.lifespan</seealso>
    let ``AddressComponent.lifespan`` =
        Prefixed_Name(isoadr, "AddressComponent.lifespan") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.valueComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>value component</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueComponent">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.valueComponent</seealso>
    let ``AddressComponent.valueComponent`` =
        Prefixed_Name(isoadr, "AddressComponent.valueComponent") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>id</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.id">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.id</seealso>
    let ``AddressComponent.id`` =
        Prefixed_Name(isoadr, "AddressComponent.id") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponent.referenceObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reference object</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.referenceObject">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponent.referenceObject</seealso>
    let ``AddressComponent.referenceObject`` =
        Prefixed_Name(isoadr, "AddressComponent.referenceObject") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:ReferenceObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reference Object</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject">http://reference.data.gov.au/def/ont/iso19160-1-address#ReferenceObject</seealso>
    let ReferenceObject = Prefixed_Name(isoadr, "ReferenceObject") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:AddressTypology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Typology</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressTypology">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressTypology</seealso>
    let AddressTypology = Prefixed_Name(isoadr, "AddressTypology") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressComponentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Component Type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentType">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressComponentType</seealso>
    let AddressComponentType =
        Prefixed_Name(isoadr, "AddressComponentType") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>position</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.position">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.position</seealso>
    let ``Address.position`` = Prefixed_Name(isoadr, "Address.position") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:AddressPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Position</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition</seealso>
    let AddressPosition = Prefixed_Name(isoadr, "AddressPosition") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.addressComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>address component</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.addressComponent">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.addressComponent</seealso>
    let ``Address.addressComponent`` =
        Prefixed_Name(isoadr, "Address.addressComponent") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.locale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>locale</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.locale">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.locale</seealso>
    let ``Address.locale`` = Prefixed_Name(isoadr, "Address.locale") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.lifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lifecycle stage</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifecycleStage">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.lifecycleStage</seealso>
    let ``Address.lifecycleStage`` =
        Prefixed_Name(isoadr, "Address.lifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.theAddressAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>the address alias</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressAlias">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.theAddressAlias</seealso>
    let ``Address.theAddressAlias`` =
        Prefixed_Name(isoadr, "Address.theAddressAlias") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Alias</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressAlias</seealso>
    let AddressAlias = Prefixed_Name(isoadr, "AddressAlias") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.business_headOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>business</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_headOffice">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.business_headOffice</seealso>
    let ``Address.business_headOffice`` =
        Prefixed_Name(isoadr, "Address.business_headOffice") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressedPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Addressed Period</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressedPeriod</seealso>
    let AddressedPeriod = Prefixed_Name(isoadr, "AddressedPeriod") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:Address.class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>class</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.class">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.class</seealso>
    let ``Address.class`` = Prefixed_Name(isoadr, "Address.class") |> PrefixedName
    /// <summary>
    ///   <para>isoadr:AddressClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Class</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClass">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressClass</seealso>
    let AddressClass = Prefixed_Name(isoadr, "AddressClass") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.parentAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>parent address</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.parentAddress">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.parentAddress</seealso>
    let ``Address.parentAddress`` =
        Prefixed_Name(isoadr, "Address.parentAddress") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:Address.provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>provenance</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#Address.provenance">http://reference.data.gov.au/def/ont/iso19160-1-address#Address.provenance</seealso>
    let ``Address.provenance`` =
        Prefixed_Name(isoadr, "Address.provenance") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressPosition.type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.type">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPosition.type</seealso>
    let ``AddressPosition.type`` =
        Prefixed_Name(isoadr, "AddressPosition.type") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressPositionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Address Position Type</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPositionType">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressPositionType</seealso>
    let AddressPositionType =
        Prefixed_Name(isoadr, "AddressPositionType") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressProvenance.lineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lineage</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.lineage">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.lineage</seealso>
    let ``AddressProvenance.lineage`` =
        Prefixed_Name(isoadr, "AddressProvenance.lineage") |> PrefixedName

    /// <summary>
    ///   <para>isoadr:AddressProvenance.owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.owner">http://reference.data.gov.au/def/ont/iso19160-1-address#AddressProvenance.owner</seealso>
    let ``AddressProvenance.owner`` =
        Prefixed_Name(isoadr, "AddressProvenance.owner") |> PrefixedName
