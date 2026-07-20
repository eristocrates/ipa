namespace http.vocab.org.whisky.terms.slash

open DoxAletheia

module whisky =
    let _namespace_name = "http://vocab.org/whisky/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Brand"></see>
    /// </summary>
    let Brand = _prefix "Brand"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Cask"></see>
    /// </summary>
    let Cask = _prefix "Cask"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Distillery"></see>
    /// </summary>
    let Distillery = _prefix "Distillery"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/WaterSource"></see>
    /// </summary>
    let WaterSource = _prefix "WaterSource"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Whisky"></see>
    /// </summary>
    let Whisky = _prefix "Whisky"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/WhiskyReview"></see>
    /// </summary>
    let WhiskyReview = _prefix "WhiskyReview"
    /// <summary>
    /// a standard measure of how much alcohol is contained in the drink
    /// <see href="http://vocab.org/whisky/terms/abv"></see></summary>
    let abv = _prefix "abv"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/age"></see>
    /// </summary>
    let age = _prefix "age"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/agingCask"></see>
    /// </summary>
    let agingCask = _prefix "agingCask"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/body"></see>
    /// </summary>
    let body = _prefix "body"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/brand"></see>
    /// </summary>
    let brand = _prefix "brand"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/character"></see>
    /// </summary>
    let character = _prefix "character"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/colour"></see>
    /// </summary>
    let colour = _prefix "colour"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/colourDescription"></see>
    /// </summary>
    let colourDescription = _prefix "colourDescription"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/distillery"></see>
    /// </summary>
    let distillery = _prefix "distillery"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/expressionLabel"></see>
    /// </summary>
    let expressionLabel = _prefix "expressionLabel"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/finish"></see>
    /// </summary>
    let finish = _prefix "finish"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/finishingCask"></see>
    /// </summary>
    let finishingCask = _prefix "finishingCask"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/grain"></see>
    /// </summary>
    let grain = _prefix "grain"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/material"></see>
    /// </summary>
    let material = _prefix "material"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/nose"></see>
    /// </summary>
    let nose = _prefix "nose"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/palate"></see>
    /// </summary>
    let palate = _prefix "palate"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/previousContents"></see>
    /// </summary>
    let previousContents = _prefix "previousContents"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/region"></see>
    /// </summary>
    let region = _prefix "region"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="http://vocab.org/whisky/terms/waterSource"></see>
    /// </summary>
    let waterSource = _prefix "waterSource"
