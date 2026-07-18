namespace https.w3id.org.tribont.sample.hash

open DoxAletheia.Rdf_Vocabulary

module tribont_sample =
    let _namespace_name = "https://w3id.org/tribont/sample#"

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of a coating.
    /// <see href="https://w3id.org/tribont/sample#CoatingProperty"></see></summary>
    let CoatingProperty =
        Namespaced_IRI.parse _namespace_name "CoatingProperty" |> NamespacedName

    /// <summary>
    /// Portion of material which can be transformed or not for Testing purposes. For example the moving and static samples in a tribological tests are transformed following a specific manufacturing process to achieve the required body characteristics, while lubricants acting as lubrication body are not transformed.
    /// <see href="https://w3id.org/tribont/sample#Sample"></see></summary>
    let Sample = Namespaced_IRI.parse _namespace_name "Sample" |> NamespacedName

    /// <summary>
    /// Relationship between something and the material of which it is made
    /// <see href="https://w3id.org/tribont/sample#hasCoreMaterial"></see></summary>
    let hasCoreMaterial =
        Namespaced_IRI.parse _namespace_name "hasCoreMaterial" |> NamespacedName

    /// <summary>
    /// Data when something has been prepared.
    /// <see href="https://w3id.org/tribont/sample#preparationDate"></see></summary>
    let preparationDate =
        Namespaced_IRI.parse _namespace_name "preparationDate" |> NamespacedName

    /// <summary>
    /// Object aggregate that has two or more elements that interact with each other, and it is used for Testing purposes. For example, a tribological sample system aggregates at least a static and a moving sample body and can include or not a lubrication sample body.
    /// <see href="https://w3id.org/tribont/sample#SampleSystem"></see></summary>
    let SampleSystem =
        Namespaced_IRI.parse _namespace_name "SampleSystem" |> NamespacedName

    /// <summary>
    /// Relationship between a sample system and a moving sample body that is part of it.
    /// <see href="https://w3id.org/tribont/sample#hasMovingSample"></see></summary>
    let hasMovingSample =
        Namespaced_IRI.parse _namespace_name "hasMovingSample" |> NamespacedName

    /// <summary>
    /// Relationship between a sample system and a static sample body that is part of it.
    /// <see href="https://w3id.org/tribont/sample#hasStaticSample"></see></summary>
    let hasStaticSample =
        Namespaced_IRI.parse _namespace_name "hasStaticSample" |> NamespacedName

    /// <summary>
    /// Releation between sveral samples interacting one with each other.
    /// <see href="https://w3id.org/tribont/sample#interactsWith"></see></summary>
    let interactsWith =
        Namespaced_IRI.parse _namespace_name "interactsWith" |> NamespacedName

    /// <summary>
    /// Relationship between a sample  and its coating.
    /// <see href="https://w3id.org/tribont/sample#hasCoating"></see></summary>
    let hasCoating = Namespaced_IRI.parse _namespace_name "hasCoating" |> NamespacedName
    /// <summary>
    /// Relationship between something  and its body configuration..
    /// <see href="https://w3id.org/tribont/sample#hasBody"></see></summary>
    let hasBody = Namespaced_IRI.parse _namespace_name "hasBody" |> NamespacedName
    /// <summary>
    /// A thin layer covering of something.
    /// <see href="https://w3id.org/tribont/sample#Coating"></see></summary>
    let Coating = Namespaced_IRI.parse _namespace_name "Coating" |> NamespacedName

    /// <summary>
    /// An aggrupation of samples which have been transformed at the same time using a same material and share a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/sample#SampleBatch"></see></summary>
    let SampleBatch =
        Namespaced_IRI.parse _namespace_name "SampleBatch" |> NamespacedName

    /// <summary>
    /// The position or purpose that a sample has in a situation.
    /// <see href="https://w3id.org/tribont/sample#SampleRole"></see></summary>
    let SampleRole = Namespaced_IRI.parse _namespace_name "SampleRole" |> NamespacedName

    /// <summary>
    /// Sample body which has a coating moterial.
    /// <see href="https://w3id.org/tribont/sample#CoatedSample"></see></summary>
    let CoatedSample =
        Namespaced_IRI.parse _namespace_name "CoatedSample" |> NamespacedName

    /// <summary>
    /// Thickness of a coating.
    /// <see href="https://w3id.org/tribont/sample#CoatingThickness"></see></summary>
    let CoatingThickness =
        Namespaced_IRI.parse _namespace_name "CoatingThickness" |> NamespacedName

    /// <summary>
    /// Type of coating.
    /// <see href="https://w3id.org/tribont/sample#CoatingType"></see></summary>
    let CoatingType =
        Namespaced_IRI.parse _namespace_name "CoatingType" |> NamespacedName

    /// <summary>
    /// Sample system that includes a lubricant as part of it.
    /// <see href="https://w3id.org/tribont/sample#LubricatedSampleSystem"></see></summary>
    let LubricatedSampleSystem =
        Namespaced_IRI.parse _namespace_name "LubricatedSampleSystem" |> NamespacedName

    /// <summary>
    /// Portion of lubricant material selected from a larger quantity of lubricant material for Testing purposes. Lubricant material can be fluid or solid lubricants
    /// <see href="https://w3id.org/tribont/sample#LubricationSample"></see></summary>
    let LubricationSample =
        Namespaced_IRI.parse _namespace_name "LubricationSample" |> NamespacedName

    /// <summary>
    /// Relationship between a sample system and a lubricant material that is part of it.
    /// <see href="https://w3id.org/tribont/sample#hasLubricationSample"></see></summary>
    let hasLubricationSample =
        Namespaced_IRI.parse _namespace_name "hasLubricationSample" |> NamespacedName

    /// <summary>
    /// Relationship between a sample and its role.
    /// <see href="https://w3id.org/tribont/sample#hasSampleRole"></see></summary>
    let hasSampleRole =
        Namespaced_IRI.parse _namespace_name "hasSampleRole" |> NamespacedName

    /// <summary>
    /// Data when something has been executed.
    /// <see href="https://w3id.org/tribont/sample#executionDate"></see></summary>
    let executionDate =
        Namespaced_IRI.parse _namespace_name "executionDate" |> NamespacedName

    /// <summary>
    /// Relationship between a coating  and the sample  of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isCoatingFor"></see></summary>
    let isCoatingFor =
        Namespaced_IRI.parse _namespace_name "isCoatingFor" |> NamespacedName

    /// <summary>
    /// Relationship between  the material it is made of and something
    /// <see href="https://w3id.org/tribont/sample#isCoreMaterialFor"></see></summary>
    let isCoreMaterialFor =
        Namespaced_IRI.parse _namespace_name "isCoreMaterialFor" |> NamespacedName

    /// <summary>
    /// Relationship between a lubrication sample  and the sample system of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isLubricationSampleFor"></see></summary>
    let isLubricationSampleFor =
        Namespaced_IRI.parse _namespace_name "isLubricationSampleFor" |> NamespacedName

    /// <summary>
    /// Relationship between a moving sample  and the sample system of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isMovingSampleFor"></see></summary>
    let isMovingSampleFor =
        Namespaced_IRI.parse _namespace_name "isMovingSampleFor" |> NamespacedName

    /// <summary>
    /// Relationship between a role and the sample to which it applies,
    /// <see href="https://w3id.org/tribont/sample#isSampleRoleFor"></see></summary>
    let isSampleRoleFor =
        Namespaced_IRI.parse _namespace_name "isSampleRoleFor" |> NamespacedName

    /// <summary>
    /// Relationship between a static sample  and the sample system of which it is a part.
    /// <see href="https://w3id.org/tribont/sample#isStaticSampleFor"></see></summary>
    let isStaticSampleFor =
        Namespaced_IRI.parse _namespace_name "isStaticSampleFor" |> NamespacedName

    /// <summary>
    /// A reference against which the sample is tested.
    /// <see href="https://w3id.org/tribont/sample#reference"></see></summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName
    /// <summary>
    /// Target sample for the  testing  activity.
    /// <see href="https://w3id.org/tribont/sample#target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName
