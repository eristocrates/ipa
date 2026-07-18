namespace http.vocab.org.whisky.terms.slash

open DoxAletheia.Rdf_Vocabulary

module whisky =
    let _namespace_name = "http://vocab.org/whisky/terms/"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Brand"></see>
    /// </summary>
    let Brand = Namespaced_IRI.parse _namespace_name "Brand" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Cask"></see>
    /// </summary>
    let Cask = Namespaced_IRI.parse _namespace_name "Cask" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Distillery"></see>
    /// </summary>
    let Distillery = Namespaced_IRI.parse _namespace_name "Distillery" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/WaterSource"></see>
    /// </summary>
    let WaterSource =
        Namespaced_IRI.parse _namespace_name "WaterSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Whisky"></see>
    /// </summary>
    let Whisky = Namespaced_IRI.parse _namespace_name "Whisky" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/WhiskyReview"></see>
    /// </summary>
    let WhiskyReview =
        Namespaced_IRI.parse _namespace_name "WhiskyReview" |> NamespacedName

    /// <summary>
    /// a standard measure of how much alcohol is contained in the drink
    /// <see href="http://vocab.org/whisky/terms/abv"></see></summary>
    let abv = Namespaced_IRI.parse _namespace_name "abv" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/age"></see>
    /// </summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/agingCask"></see>
    /// </summary>
    let agingCask = Namespaced_IRI.parse _namespace_name "agingCask" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/body"></see>
    /// </summary>
    let body = Namespaced_IRI.parse _namespace_name "body" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/brand"></see>
    /// </summary>
    let brand = Namespaced_IRI.parse _namespace_name "brand" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/character"></see>
    /// </summary>
    let character = Namespaced_IRI.parse _namespace_name "character" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/colour"></see>
    /// </summary>
    let colour = Namespaced_IRI.parse _namespace_name "colour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/colourDescription"></see>
    /// </summary>
    let colourDescription =
        Namespaced_IRI.parse _namespace_name "colourDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/distillery"></see>
    /// </summary>
    let distillery = Namespaced_IRI.parse _namespace_name "distillery" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/expressionLabel"></see>
    /// </summary>
    let expressionLabel =
        Namespaced_IRI.parse _namespace_name "expressionLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/finish"></see>
    /// </summary>
    let finish = Namespaced_IRI.parse _namespace_name "finish" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/finishingCask"></see>
    /// </summary>
    let finishingCask =
        Namespaced_IRI.parse _namespace_name "finishingCask" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/grain"></see>
    /// </summary>
    let grain = Namespaced_IRI.parse _namespace_name "grain" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/material"></see>
    /// </summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/nose"></see>
    /// </summary>
    let nose = Namespaced_IRI.parse _namespace_name "nose" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/palate"></see>
    /// </summary>
    let palate = Namespaced_IRI.parse _namespace_name "palate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/previousContents"></see>
    /// </summary>
    let previousContents =
        Namespaced_IRI.parse _namespace_name "previousContents" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/region"></see>
    /// </summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/waterSource"></see>
    /// </summary>
    let waterSource =
        Namespaced_IRI.parse _namespace_name "waterSource" |> NamespacedName
