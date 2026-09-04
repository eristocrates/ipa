#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``tribont-sample`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/tribont/sample#" "tribont-sample"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CoatedSample^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Sample body which has a coating moterial.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#CoatedSample">tribont-sample:CoatedSample</a>
    /// </summary>
    let CoatedSample = _prefixId.prefix "CoatedSample"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Coating^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : A thin layer covering of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#Coating">tribont-sample:Coating</a>
    /// </summary>
    let Coating = _prefixId.prefix "Coating"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CoatingProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of a coating.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#CoatingProperty">tribont-sample:CoatingProperty</a>
    /// </summary>
    let CoatingProperty = _prefixId.prefix "CoatingProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CoatingThickness^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Thickness of a coating.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#CoatingThickness">tribont-sample:CoatingThickness</a>
    /// </summary>
    let CoatingThickness = _prefixId.prefix "CoatingThickness"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CoatingType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Type of coating.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#CoatingType">tribont-sample:CoatingType</a>
    /// </summary>
    let CoatingType = _prefixId.prefix "CoatingType"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LubricatedSampleSystem^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Sample system that includes a lubricant as part of it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#LubricatedSampleSystem">tribont-sample:LubricatedSampleSystem</a>
    /// </summary>
    let LubricatedSampleSystem = _prefixId.prefix "LubricatedSampleSystem"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LubricationSample^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Portion of lubricant material selected from a larger quantity of lubricant material for Testing purposes. Lubricant material can be fluid or solid lubricants ^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#LubricationSample">tribont-sample:LubricationSample</a>
    /// </summary>
    let LubricationSample = _prefixId.prefix "LubricationSample"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Portion of material which can be transformed or not for Testing purposes. For example the moving and static samples in a tribological tests are transformed following a specific manufacturing process to achieve the required body characteristics, while lubricants acting as lubrication body are not transformed.^^xsd:string</para>
    ///   <para>rdfs:label : Sample^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#Sample">tribont-sample:Sample</a>
    /// </summary>
    let Sample = _prefixId.prefix "Sample"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:comment : An aggrupation of samples which have been transformed at the same time using a same material and share a set of common atributes of characteristics.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:label : SampleBatch^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#SampleBatch">tribont-sample:SampleBatch</a>
    /// </summary>
    let SampleBatch = _prefixId.prefix "SampleBatch"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SampleRole^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : The position or purpose that a sample has in a situation.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#SampleRole">tribont-sample:SampleRole</a>
    /// </summary>
    let SampleRole = _prefixId.prefix "SampleRole"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SampleSystem^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Object aggregate that has two or more elements that interact with each other, and it is used for Testing purposes. For example, a tribological sample system aggregates at least a static and a moving sample body and can include or not a lubrication sample body.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#SampleSystem">tribont-sample:SampleSystem</a>
    /// </summary>
    let SampleSystem = _prefixId.prefix "SampleSystem"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : executionDate^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Data when something has been executed.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#executionDate">tribont-sample:executionDate</a>
    /// </summary>
    let executionDate = _prefixId.prefix "executionDate"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasBody^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something  and its body configuration..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasBody">tribont-sample:hasBody</a>
    /// </summary>
    let hasBody = _prefixId.prefix "hasBody"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasCoating^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample  and its coating.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasCoating">tribont-sample:hasCoating</a>
    /// </summary>
    let hasCoating = _prefixId.prefix "hasCoating"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasCoreMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and the material of which it is made^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasCoreMaterial">tribont-sample:hasCoreMaterial</a>
    /// </summary>
    let hasCoreMaterial = _prefixId.prefix "hasCoreMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasLubricationSample^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample system and a lubricant material that is part of it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasLubricationSample">tribont-sample:hasLubricationSample</a>
    /// </summary>
    let hasLubricationSample = _prefixId.prefix "hasLubricationSample"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasMovingSample^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample system and a moving sample body that is part of it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasMovingSample">tribont-sample:hasMovingSample</a>
    /// </summary>
    let hasMovingSample = _prefixId.prefix "hasMovingSample"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasSampleRole^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample and its role.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasSampleRole">tribont-sample:hasSampleRole</a>
    /// </summary>
    let hasSampleRole = _prefixId.prefix "hasSampleRole"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasStaticSample^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample system and a static sample body that is part of it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#hasStaticSample">tribont-sample:hasStaticSample</a>
    /// </summary>
    let hasStaticSample = _prefixId.prefix "hasStaticSample"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : interactsWith^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Releation between sveral samples interacting one with each other.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#interactsWith">tribont-sample:interactsWith</a>
    /// </summary>
    let interactsWith = _prefixId.prefix "interactsWith"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCoatingFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a coating  and the sample  of which it is a part.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#isCoatingFor">tribont-sample:isCoatingFor</a>
    /// </summary>
    let isCoatingFor = _prefixId.prefix "isCoatingFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCoreMaterialFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between  the material it is made of and something^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#isCoreMaterialFor">tribont-sample:isCoreMaterialFor</a>
    /// </summary>
    let isCoreMaterialFor = _prefixId.prefix "isCoreMaterialFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isLubricationSampleFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a lubrication sample  and the sample system of which it is a part.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#isLubricationSampleFor">tribont-sample:isLubricationSampleFor</a>
    /// </summary>
    let isLubricationSampleFor = _prefixId.prefix "isLubricationSampleFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isMovingSampleFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a moving sample  and the sample system of which it is a part.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#isMovingSampleFor">tribont-sample:isMovingSampleFor</a>
    /// </summary>
    let isMovingSampleFor = _prefixId.prefix "isMovingSampleFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isSampleRoleFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a role and the sample to which it applies,^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#isSampleRoleFor">tribont-sample:isSampleRoleFor</a>
    /// </summary>
    let isSampleRoleFor = _prefixId.prefix "isSampleRoleFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isStaticSampleFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a static sample  and the sample system of which it is a part.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#isStaticSampleFor">tribont-sample:isStaticSampleFor</a>
    /// </summary>
    let isStaticSampleFor = _prefixId.prefix "isStaticSampleFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : preparationDate^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/sample^^xsd:string</para>
    ///   <para>rdfs:comment : Data when something has been prepared.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/sample#preparationDate">tribont-sample:preparationDate</a>
    /// </summary>
    let preparationDate = _prefixId.prefix "preparationDate"
    let reference = _prefixId.prefix "reference"
    let target = _prefixId.prefix "target"
