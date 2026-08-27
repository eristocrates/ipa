namespace http.ecoinformatics.org.oboe.oboe._1._0.oboe_core.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oboe =
    let _namespace_iri = Namespace_Iri oboe |> NamespaceIRI
    /// <summary>
    ///   <para>oboe:Characteristic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ecoinformatics.org/oboe/oboe.1.0/oboe-core.owl#Characteristic">http://ecoinformatics.org/oboe/oboe.1.0/oboe-core.owl#Characteristic</seealso>
    let Characteristic = Prefixed_Name(oboe, "Characteristic") |> PrefixedName
    /// <summary>
    ///   <para>oboe:Entity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ecoinformatics.org/oboe/oboe.1.0/oboe-core.owl#Entity">http://ecoinformatics.org/oboe/oboe.1.0/oboe-core.owl#Entity</seealso>
    let Entity = Prefixed_Name(oboe, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>oboe:Unit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ecoinformatics.org/oboe/oboe.1.0/oboe-core.owl#Unit">http://ecoinformatics.org/oboe/oboe.1.0/oboe-core.owl#Unit</seealso>
    let Unit = Prefixed_Name(oboe, "Unit") |> PrefixedName
