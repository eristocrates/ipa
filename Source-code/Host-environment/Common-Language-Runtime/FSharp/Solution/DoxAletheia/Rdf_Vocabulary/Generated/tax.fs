namespace https.w3id.org.EUTaxO.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tax =
    let _namespace_iri = Namespace_Iri tax |> NamespaceIRI
    /// <summary>
    ///   <para>tax:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base taxon class</para>
    /// labels<para>Taxon</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#Taxon">https://w3id.org/EUTaxO#Taxon</seealso>
    let Taxon = Prefixed_Name(tax, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>tax:2.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#2.0.0">https://w3id.org/EUTaxO#2.0.0</seealso>
    let ``_2.0.0`` = Prefixed_Name(tax, "2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>tax:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Defines a hierarchy from more generic taxa, to more specific ones</para>
    /// labels<para>belongs to</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#belongsTo">https://w3id.org/EUTaxO#belongsTo</seealso>
    let belongsTo = Prefixed_Name(tax, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>tax:brackets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether to use brackets for the correct nomenclature of a taxon</para>
    /// labels<para>brackets</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#brackets">https://w3id.org/EUTaxO#brackets</seealso>
    let brackets = Prefixed_Name(tax, "brackets") |> PrefixedName
    /// <summary>
    ///   <para>tax:phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The phylum of a specific taxon</para>
    /// labels<para>phylum</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#phylum">https://w3id.org/EUTaxO#phylum</seealso>
    let phylum = Prefixed_Name(tax, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>tax:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Relates if two taxon are synonyms</para>
    /// labels<para>synonym</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#synonym">https://w3id.org/EUTaxO#synonym</seealso>
    let synonym = Prefixed_Name(tax, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>tax:synonyms_exist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether or not synonyms exists for a given taxon</para>
    /// labels<para>synonyms exist</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#synonyms_exist">https://w3id.org/EUTaxO#synonyms_exist</seealso>
    let synonyms_exist = Prefixed_Name(tax, "synonyms_exist") |> PrefixedName
    /// <summary>
    ///   <para>tax:Animalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Animalia kingdom</para>
    /// labels<para>Animalia</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#Animalia">https://w3id.org/EUTaxO#Animalia</seealso>
    let Animalia = Prefixed_Name(tax, "Animalia") |> PrefixedName
    /// <summary>
    ///   <para>tax:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>id from the EUdaphobase database</para>
    /// labels<para>id</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#id">https://w3id.org/EUTaxO#id</seealso>
    let id = Prefixed_Name(tax, "id") |> PrefixedName
    /// <summary>
    ///   <para>tax:kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The kingdom of a specific taxon</para>
    /// labels<para>kingdom</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#kingdom">https://w3id.org/EUTaxO#kingdom</seealso>
    let kingdom = Prefixed_Name(tax, "kingdom") |> PrefixedName
