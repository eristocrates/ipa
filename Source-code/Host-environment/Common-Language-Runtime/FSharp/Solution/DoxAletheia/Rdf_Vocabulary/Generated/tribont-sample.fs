namespace https.w3id.org.tribont.sample.hash

open DoxAletheia

module tribont_sample =
    let _namespace_name = "https://w3id.org/tribont/sample#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of a coating.
    /// <see href="https://w3id.org/tribont/sample#CoatingProperty"></see></summary>
    let CoatingProperty = _prefix "CoatingProperty"
    /// <summary>
    /// Portion of material which can be transformed or not for Testing purposes. For example the moving and static samples in a tribological tests are transformed following a specific manufacturing process to achieve the required body characteristics, while lubricants acting as lubrication body are not transformed.
    /// <see href="https://w3id.org/tribont/sample#Sample"></see></summary>
    let Sample = _prefix "Sample"
    /// <summary>
    /// Relationship between something and the material of which it is made
    /// <see href="https://w3id.org/tribont/sample#hasCoreMaterial"></see></summary>
    let hasCoreMaterial = _prefix "hasCoreMaterial"
    /// <summary>
    /// Data when something has been prepared.
    /// <see href="https://w3id.org/tribont/sample#preparationDate"></see></summary>
    let preparationDate = _prefix "preparationDate"
    /// <summary>
    /// Object aggregate that has two or more elements that interact with each other, and it is used for Testing purposes. For example, a tribological sample system aggregates at least a static and a moving sample body and can include or not a lubrication sample body.
    /// <see href="https://w3id.org/tribont/sample#SampleSystem"></see></summary>
    let SampleSystem = _prefix "SampleSystem"
    /// <summary>
    /// Relationship between a sample system and a moving sample body that is part of it.
    /// <see href="https://w3id.org/tribont/sample#hasMovingSample"></see></summary>
    let hasMovingSample = _prefix "hasMovingSample"
    /// <summary>
    /// Relationship between a sample system and a static sample body that is part of it.
    /// <see href="https://w3id.org/tribont/sample#hasStaticSample"></see></summary>
    let hasStaticSample = _prefix "hasStaticSample"
    /// <summary>
    /// Releation between sveral samples interacting one with each other.
    /// <see href="https://w3id.org/tribont/sample#interactsWith"></see></summary>
    let interactsWith = _prefix "interactsWith"
    /// <summary>
    /// Relationship between a sample  and its coating.
    /// <see href="https://w3id.org/tribont/sample#hasCoating"></see></summary>
    let hasCoating = _prefix "hasCoating"
    /// <summary>
    /// Relationship between something  and its body configuration..
    /// <see href="https://w3id.org/tribont/sample#hasBody"></see></summary>
    let hasBody = _prefix "hasBody"
    /// <summary>
    /// A thin layer covering of something.
    /// <see href="https://w3id.org/tribont/sample#Coating"></see></summary>
    let Coating = _prefix "Coating"
    /// <summary>
    /// An aggrupation of samples which have been transformed at the same time using a same material and share a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/sample#SampleBatch"></see></summary>
    let SampleBatch = _prefix "SampleBatch"
    /// <summary>
    /// The position or purpose that a sample has in a situation.
    /// <see href="https://w3id.org/tribont/sample#SampleRole"></see></summary>
    let SampleRole = _prefix "SampleRole"
    /// <summary>
    /// Sample body which has a coating moterial.
    /// <see href="https://w3id.org/tribont/sample#CoatedSample"></see></summary>
    let CoatedSample = _prefix "CoatedSample"
    /// <summary>
    /// Thickness of a coating.
    /// <see href="https://w3id.org/tribont/sample#CoatingThickness"></see></summary>
    let CoatingThickness = _prefix "CoatingThickness"
    /// <summary>
    /// Type of coating.
    /// <see href="https://w3id.org/tribont/sample#CoatingType"></see></summary>
    let CoatingType = _prefix "CoatingType"
    /// <summary>
    /// Sample system that includes a lubricant as part of it.
    /// <see href="https://w3id.org/tribont/sample#LubricatedSampleSystem"></see></summary>
    let LubricatedSampleSystem = _prefix "LubricatedSampleSystem"
    /// <summary>
    /// Portion of lubricant material selected from a larger quantity of lubricant material for Testing purposes. Lubricant material can be fluid or solid lubricants
    /// <see href="https://w3id.org/tribont/sample#LubricationSample"></see></summary>
    let LubricationSample = _prefix "LubricationSample"
    /// <summary>
    /// Relationship between a sample system and a lubricant material that is part of it.
    /// <see href="https://w3id.org/tribont/sample#hasLubricationSample"></see></summary>
    let hasLubricationSample = _prefix "hasLubricationSample"
    /// <summary>
    /// Relationship between a sample and its role.
    /// <see href="https://w3id.org/tribont/sample#hasSampleRole"></see></summary>
    let hasSampleRole = _prefix "hasSampleRole"
    /// <summary>
    /// Data when something has been executed.
    /// <see href="https://w3id.org/tribont/sample#executionDate"></see></summary>
    let executionDate = _prefix "executionDate"
    /// <summary>
    /// Relationship between a coating  and the sample  of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isCoatingFor"></see></summary>
    let isCoatingFor = _prefix "isCoatingFor"
    /// <summary>
    /// Relationship between  the material it is made of and something
    /// <see href="https://w3id.org/tribont/sample#isCoreMaterialFor"></see></summary>
    let isCoreMaterialFor = _prefix "isCoreMaterialFor"
    /// <summary>
    /// Relationship between a lubrication sample  and the sample system of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isLubricationSampleFor"></see></summary>
    let isLubricationSampleFor = _prefix "isLubricationSampleFor"
    /// <summary>
    /// Relationship between a moving sample  and the sample system of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isMovingSampleFor"></see></summary>
    let isMovingSampleFor = _prefix "isMovingSampleFor"
    /// <summary>
    /// Relationship between a role and the sample to which it applies,
    /// <see href="https://w3id.org/tribont/sample#isSampleRoleFor"></see></summary>
    let isSampleRoleFor = _prefix "isSampleRoleFor"
    /// <summary>
    /// Relationship between a static sample  and the sample system of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isStaticSampleFor"></see></summary>
    let isStaticSampleFor = _prefix "isStaticSampleFor"
    /// <summary>
    /// A reference against which the sample is tested.
    /// <see href="https://w3id.org/tribont/sample#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// Target sample for the  testing  activity.
    /// <see href="https://w3id.org/tribont/sample#target"></see></summary>
    let target = _prefix "target"
