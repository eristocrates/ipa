namespace http.vocab.org.whisky.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module whisky =
    let _namespace_iri = Namespace_Iri whisky |> NamespaceIRI
    /// <summary>
    ///   <para>whisky:Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>brand</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/Brand">http://vocab.org/whisky/terms/Brand</seealso>
    let Brand = Prefixed_Name(whisky, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>whisky:Distillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>distillery</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/Distillery">http://vocab.org/whisky/terms/Distillery</seealso>
    let Distillery = Prefixed_Name(whisky, "Distillery") |> PrefixedName
    /// <summary>
    ///   <para>whisky:Whisky</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Whiskey</para><para>Whisky</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/Whisky">http://vocab.org/whisky/terms/Whisky</seealso>
    let Whisky = Prefixed_Name(whisky, "Whisky") |> PrefixedName
    /// <summary>
    ///   <para>whisky:WhiskyReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Whisky Review</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/WhiskyReview">http://vocab.org/whisky/terms/WhiskyReview</seealso>
    let WhiskyReview = Prefixed_Name(whisky, "WhiskyReview") |> PrefixedName
    /// <summary>
    ///   <para>whisky:WaterSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>water source</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/WaterSource">http://vocab.org/whisky/terms/WaterSource</seealso>
    let WaterSource = Prefixed_Name(whisky, "WaterSource") |> PrefixedName
    /// <summary>
    ///   <para>whisky:character</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>character</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/character">http://vocab.org/whisky/terms/character</seealso>
    let character = Prefixed_Name(whisky, "character") |> PrefixedName
    /// <summary>
    ///   <para>whisky:distillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>distillery</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/distillery">http://vocab.org/whisky/terms/distillery</seealso>
    let distillery = Prefixed_Name(whisky, "distillery") |> PrefixedName
    /// <summary>
    ///   <para>whisky:finish</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>finish</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/finish">http://vocab.org/whisky/terms/finish</seealso>
    let finish = Prefixed_Name(whisky, "finish") |> PrefixedName
    /// <summary>
    ///   <para>whisky:Cask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>cask</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/Cask">http://vocab.org/whisky/terms/Cask</seealso>
    let Cask = Prefixed_Name(whisky, "Cask") |> PrefixedName
    /// <summary>
    ///   <para>whisky:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>age</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/age">http://vocab.org/whisky/terms/age</seealso>
    let age = Prefixed_Name(whisky, "age") |> PrefixedName
    /// <summary>
    ///   <para>whisky:body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>body</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/body">http://vocab.org/whisky/terms/body</seealso>
    let body = Prefixed_Name(whisky, "body") |> PrefixedName
    /// <summary>
    ///   <para>whisky:colour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>colour</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/colour">http://vocab.org/whisky/terms/colour</seealso>
    let colour = Prefixed_Name(whisky, "colour") |> PrefixedName
    /// <summary>
    ///   <para>whisky:abv</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>a standard measure of how much alcohol is contained in the drink</para>
    /// labels<para>alcohol by volume</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/abv">http://vocab.org/whisky/terms/abv</seealso>
    let abv = Prefixed_Name(whisky, "abv") |> PrefixedName
    /// <summary>
    ///   <para>whisky:brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>brand</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/brand">http://vocab.org/whisky/terms/brand</seealso>
    let brand = Prefixed_Name(whisky, "brand") |> PrefixedName
    /// <summary>
    ///   <para>whisky:colourDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>colour description</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/colourDescription">http://vocab.org/whisky/terms/colourDescription</seealso>
    let colourDescription = Prefixed_Name(whisky, "colourDescription") |> PrefixedName
    /// <summary>
    ///   <para>whisky:finishingCask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>finishing cask</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/finishingCask">http://vocab.org/whisky/terms/finishingCask</seealso>
    let finishingCask = Prefixed_Name(whisky, "finishingCask") |> PrefixedName
    /// <summary>
    ///   <para>whisky:agingCask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>aging cask</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/agingCask">http://vocab.org/whisky/terms/agingCask</seealso>
    let agingCask = Prefixed_Name(whisky, "agingCask") |> PrefixedName
    /// <summary>
    ///   <para>whisky:expressionLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>expression label</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/expressionLabel">http://vocab.org/whisky/terms/expressionLabel</seealso>
    let expressionLabel = Prefixed_Name(whisky, "expressionLabel") |> PrefixedName
    /// <summary>
    ///   <para>whisky:grain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>grain</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/grain">http://vocab.org/whisky/terms/grain</seealso>
    let grain = Prefixed_Name(whisky, "grain") |> PrefixedName
    /// <summary>
    ///   <para>whisky:nose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>nose</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/nose">http://vocab.org/whisky/terms/nose</seealso>
    let nose = Prefixed_Name(whisky, "nose") |> PrefixedName
    /// <summary>
    ///   <para>whisky:palate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>palate</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/palate">http://vocab.org/whisky/terms/palate</seealso>
    let palate = Prefixed_Name(whisky, "palate") |> PrefixedName
    /// <summary>
    ///   <para>whisky:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>region</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/region">http://vocab.org/whisky/terms/region</seealso>
    let region = Prefixed_Name(whisky, "region") |> PrefixedName
    /// <summary>
    ///   <para>whisky:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>material</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/material">http://vocab.org/whisky/terms/material</seealso>
    let material = Prefixed_Name(whisky, "material") |> PrefixedName
    /// <summary>
    ///   <para>whisky:previousContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>previous contents</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/previousContents">http://vocab.org/whisky/terms/previousContents</seealso>
    let previousContents = Prefixed_Name(whisky, "previousContents") |> PrefixedName
    /// <summary>
    ///   <para>whisky:waterSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>water source</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/waterSource">http://vocab.org/whisky/terms/waterSource</seealso>
    let waterSource = Prefixed_Name(whisky, "waterSource") |> PrefixedName
    /// <summary>
    ///   <para>whisky:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/owner">http://vocab.org/whisky/terms/owner</seealso>
    let owner = Prefixed_Name(whisky, "owner") |> PrefixedName
    /// <summary>
    ///   <para>whisky:Region</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.org/whisky/terms/Region">http://vocab.org/whisky/terms/Region</seealso>
    let Region = Prefixed_Name(whisky, "Region") |> PrefixedName
