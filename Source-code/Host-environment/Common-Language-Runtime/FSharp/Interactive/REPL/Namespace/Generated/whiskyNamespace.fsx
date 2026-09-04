#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module whisky =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://vocab.org/whisky/terms/" "whisky"

    /// <summary>
    ///   <para>rdfs:label : brand^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/Brand">whisky:Brand</a>
    /// </summary>
    let Brand = _prefixId.prefix "Brand"
    /// <summary>
    ///   <para>rdfs:label : cask^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/Cask">whisky:Cask</a>
    /// </summary>
    let Cask = _prefixId.prefix "Cask"
    /// <summary>
    ///   <para>rdfs:label : distillery^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/Distillery">whisky:Distillery</a>
    /// </summary>
    let Distillery = _prefixId.prefix "Distillery"
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : water source^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/WaterSource">whisky:WaterSource</a>
    /// </summary>
    let WaterSource = _prefixId.prefix "WaterSource"
    /// <summary>
    ///   <para>rdfs:label : Whisky^^xsd:stringrdfs:label : Whiskey^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/Whisky">whisky:Whisky</a>
    /// </summary>
    let Whisky = _prefixId.prefix "Whisky"
    /// <summary>
    ///   <para>rdfs:label : Whisky Review^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/WhiskyReview">whisky:WhiskyReview</a>
    /// </summary>
    let WhiskyReview = _prefixId.prefix "WhiskyReview"
    /// <summary>
    ///   <para>rdfs:label : alcohol by volume^^xsd:string</para>
    ///   <para>rdfs:comment : a standard measure of how much alcohol is contained in the drink^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/abv">whisky:abv</a>
    /// </summary>
    let abv = _prefixId.prefix "abv"
    /// <summary>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/age">whisky:age</a>
    /// </summary>
    let age = _prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:label : aging cask^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/agingCask">whisky:agingCask</a>
    /// </summary>
    let agingCask = _prefixId.prefix "agingCask"
    /// <summary>
    ///   <para>rdfs:label : body^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/body">whisky:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    /// <summary>
    ///   <para>rdfs:label : brand^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/brand">whisky:brand</a>
    /// </summary>
    let brand = _prefixId.prefix "brand"
    /// <summary>
    ///   <para>rdfs:label : character^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/character">whisky:character</a>
    /// </summary>
    let character = _prefixId.prefix "character"
    /// <summary>
    ///   <para>rdfs:label : colour^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/colour">whisky:colour</a>
    /// </summary>
    let colour = _prefixId.prefix "colour"
    /// <summary>
    ///   <para>rdfs:label : colour description^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/colourDescription">whisky:colourDescription</a>
    /// </summary>
    let colourDescription = _prefixId.prefix "colourDescription"
    /// <summary>
    ///   <para>rdfs:label : distillery^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/distillery">whisky:distillery</a>
    /// </summary>
    let distillery = _prefixId.prefix "distillery"
    /// <summary>
    ///   <para>rdfs:label : expression label^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/expressionLabel">whisky:expressionLabel</a>
    /// </summary>
    let expressionLabel = _prefixId.prefix "expressionLabel"
    /// <summary>
    ///   <para>rdfs:label : finish^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/finish">whisky:finish</a>
    /// </summary>
    let finish = _prefixId.prefix "finish"
    /// <summary>
    ///   <para>rdfs:label : finishing cask^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/finishingCask">whisky:finishingCask</a>
    /// </summary>
    let finishingCask = _prefixId.prefix "finishingCask"
    /// <summary>
    ///   <para>rdfs:label : grain^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/grain">whisky:grain</a>
    /// </summary>
    let grain = _prefixId.prefix "grain"
    /// <summary>
    ///   <para>rdfs:label : material^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/material">whisky:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>rdfs:label : nose^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/nose">whisky:nose</a>
    /// </summary>
    let nose = _prefixId.prefix "nose"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/owner">whisky:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : palate^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/palate">whisky:palate</a>
    /// </summary>
    let palate = _prefixId.prefix "palate"
    /// <summary>
    ///   <para>rdfs:label : previous contents^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/previousContents">whisky:previousContents</a>
    /// </summary>
    let previousContents = _prefixId.prefix "previousContents"
    /// <summary>
    ///   <para>rdfs:label : region^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/region">whisky:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : water source^^xsd:string</para>
    ///   <a href="http://vocab.org/whisky/terms/waterSource">whisky:waterSource</a>
    /// </summary>
    let waterSource = _prefixId.prefix "waterSource"
