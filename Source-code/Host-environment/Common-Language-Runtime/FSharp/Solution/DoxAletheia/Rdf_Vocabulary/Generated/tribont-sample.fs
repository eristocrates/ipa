namespace https.w3id.org.tribont.sample.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont_sample =
    let _namespace_iri = Namespace_Iri tribont_sample |> NamespaceIRI
    /// <summary>
    ///   <para>tribont-sample:hasBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something  and its body configuration..</para>
    /// labels<para>hasBody</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasBody">https://w3id.org/tribont/sample#hasBody</seealso>
    let hasBody = Prefixed_Name(tribont_sample, "hasBody") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:SampleBatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggrupation of samples which have been transformed at the same time using a same material and share a set of common atributes of characteristics.</para>
    /// labels<para>SampleBatch</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#SampleBatch">https://w3id.org/tribont/sample#SampleBatch</seealso>
    let SampleBatch = Prefixed_Name(tribont_sample, "SampleBatch") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:CoatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of a coating.</para>
    /// labels<para>CoatingProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#CoatingProperty">https://w3id.org/tribont/sample#CoatingProperty</seealso>
    let CoatingProperty =
        Prefixed_Name(tribont_sample, "CoatingProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:hasCoreMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and the material of which it is made</para>
    /// labels<para>hasCoreMaterial</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasCoreMaterial">https://w3id.org/tribont/sample#hasCoreMaterial</seealso>
    let hasCoreMaterial =
        Prefixed_Name(tribont_sample, "hasCoreMaterial") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:isCoreMaterialFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between  the material it is made of and something</para>
    /// labels<para>isCoreMaterialFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#isCoreMaterialFor">https://w3id.org/tribont/sample#isCoreMaterialFor</seealso>
    let isCoreMaterialFor =
        Prefixed_Name(tribont_sample, "isCoreMaterialFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:isStaticSampleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a static sample  and the sample system of which it is a part.</para>
    /// labels<para>isStaticSampleFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#isStaticSampleFor">https://w3id.org/tribont/sample#isStaticSampleFor</seealso>
    let isStaticSampleFor =
        Prefixed_Name(tribont_sample, "isStaticSampleFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:preparationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data when something has been prepared.</para>
    /// labels<para>preparationDate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#preparationDate">https://w3id.org/tribont/sample#preparationDate</seealso>
    let preparationDate =
        Prefixed_Name(tribont_sample, "preparationDate") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:hasStaticSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample system and a static sample body that is part of it.</para>
    /// labels<para>hasStaticSample</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasStaticSample">https://w3id.org/tribont/sample#hasStaticSample</seealso>
    let hasStaticSample =
        Prefixed_Name(tribont_sample, "hasStaticSample") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:hasLubricationSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample system and a lubricant material that is part of it.</para>
    /// labels<para>hasLubricationSample</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasLubricationSample">https://w3id.org/tribont/sample#hasLubricationSample</seealso>
    let hasLubricationSample =
        Prefixed_Name(tribont_sample, "hasLubricationSample") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:hasSampleRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample and its role.</para>
    /// labels<para>hasSampleRole</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasSampleRole">https://w3id.org/tribont/sample#hasSampleRole</seealso>
    let hasSampleRole = Prefixed_Name(tribont_sample, "hasSampleRole") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:executionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data when something has been executed.</para>
    /// labels<para>executionDate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#executionDate">https://w3id.org/tribont/sample#executionDate</seealso>
    let executionDate = Prefixed_Name(tribont_sample, "executionDate") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:isCoatingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a coating  and the sample  of which it is a part.</para>
    /// labels<para>isCoatingFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#isCoatingFor">https://w3id.org/tribont/sample#isCoatingFor</seealso>
    let isCoatingFor = Prefixed_Name(tribont_sample, "isCoatingFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:isLubricationSampleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a lubrication sample  and the sample system of which it is a part.</para>
    /// labels<para>isLubricationSampleFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#isLubricationSampleFor">https://w3id.org/tribont/sample#isLubricationSampleFor</seealso>
    let isLubricationSampleFor =
        Prefixed_Name(tribont_sample, "isLubricationSampleFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:isMovingSampleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a moving sample  and the sample system of which it is a part.</para>
    /// labels<para>isMovingSampleFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#isMovingSampleFor">https://w3id.org/tribont/sample#isMovingSampleFor</seealso>
    let isMovingSampleFor =
        Prefixed_Name(tribont_sample, "isMovingSampleFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:isSampleRoleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a role and the sample to which it applies,</para>
    /// labels<para>isSampleRoleFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#isSampleRoleFor">https://w3id.org/tribont/sample#isSampleRoleFor</seealso>
    let isSampleRoleFor =
        Prefixed_Name(tribont_sample, "isSampleRoleFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/sample#SampleRole</para>
    ///   <para>A reference against which the sample is tested.</para>
    /// labels<para>reference</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#reference">https://w3id.org/tribont/sample#reference</seealso>
    let reference = Prefixed_Name(tribont_sample, "reference") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/sample#SampleRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Target sample for the  testing  activity.</para>
    /// labels<para>target</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#target">https://w3id.org/tribont/sample#target</seealso>
    let target = Prefixed_Name(tribont_sample, "target") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:SampleSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Object aggregate that has two or more elements that interact with each other, and it is used for Testing purposes. For example, a tribological sample system aggregates at least a static and a moving sample body and can include or not a lubrication sample body.</para>
    /// labels<para>SampleSystem</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#SampleSystem">https://w3id.org/tribont/sample#SampleSystem</seealso>
    let SampleSystem = Prefixed_Name(tribont_sample, "SampleSystem") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:interactsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Releation between sveral samples interacting one with each other.</para>
    /// labels<para>interactsWith</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#interactsWith">https://w3id.org/tribont/sample#interactsWith</seealso>
    let interactsWith = Prefixed_Name(tribont_sample, "interactsWith") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:hasMovingSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample system and a moving sample body that is part of it.</para>
    /// labels<para>hasMovingSample</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasMovingSample">https://w3id.org/tribont/sample#hasMovingSample</seealso>
    let hasMovingSample =
        Prefixed_Name(tribont_sample, "hasMovingSample") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:hasCoating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample  and its coating.</para>
    /// labels<para>hasCoating</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#hasCoating">https://w3id.org/tribont/sample#hasCoating</seealso>
    let hasCoating = Prefixed_Name(tribont_sample, "hasCoating") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:Coating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A thin layer covering of something.</para>
    /// labels<para>Coating</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#Coating">https://w3id.org/tribont/sample#Coating</seealso>
    let Coating = Prefixed_Name(tribont_sample, "Coating") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:SampleRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The position or purpose that a sample has in a situation.</para>
    /// labels<para>SampleRole</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#SampleRole">https://w3id.org/tribont/sample#SampleRole</seealso>
    let SampleRole = Prefixed_Name(tribont_sample, "SampleRole") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:CoatingThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thickness of a coating.</para>
    /// labels<para>CoatingThickness</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#CoatingThickness">https://w3id.org/tribont/sample#CoatingThickness</seealso>
    let CoatingThickness =
        Prefixed_Name(tribont_sample, "CoatingThickness") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:CoatingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of coating.</para>
    /// labels<para>CoatingType</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#CoatingType">https://w3id.org/tribont/sample#CoatingType</seealso>
    let CoatingType = Prefixed_Name(tribont_sample, "CoatingType") |> PrefixedName
    /// <summary>
    ///   <para>tribont-sample:CoatedSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sample body which has a coating moterial.</para>
    /// labels<para>CoatedSample</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#CoatedSample">https://w3id.org/tribont/sample#CoatedSample</seealso>
    let CoatedSample = Prefixed_Name(tribont_sample, "CoatedSample") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:LubricatedSampleSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sample system that includes a lubricant as part of it.</para>
    /// labels<para>LubricatedSampleSystem</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#LubricatedSampleSystem">https://w3id.org/tribont/sample#LubricatedSampleSystem</seealso>
    let LubricatedSampleSystem =
        Prefixed_Name(tribont_sample, "LubricatedSampleSystem") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:LubricationSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Portion of lubricant material selected from a larger quantity of lubricant material for Testing purposes. Lubricant material can be fluid or solid lubricants </para>
    /// labels<para>LubricationSample</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#LubricationSample">https://w3id.org/tribont/sample#LubricationSample</seealso>
    let LubricationSample =
        Prefixed_Name(tribont_sample, "LubricationSample") |> PrefixedName

    /// <summary>
    ///   <para>tribont-sample:Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Portion of material which can be transformed or not for Testing purposes. For example the moving and static samples in a tribological tests are transformed following a specific manufacturing process to achieve the required body characteristics, while lubricants acting as lubrication body are not transformed.</para>
    /// labels<para>Sample</para></remarks>
    /// <seealso href="https://w3id.org/tribont/sample#Sample">https://w3id.org/tribont/sample#Sample</seealso>
    let Sample = Prefixed_Name(tribont_sample, "Sample") |> PrefixedName
