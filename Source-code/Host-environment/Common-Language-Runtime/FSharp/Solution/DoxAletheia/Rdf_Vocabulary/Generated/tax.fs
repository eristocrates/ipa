namespace https.w3id.org.EUTaxO.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tax =
    let _namespace_iri = Namespace_Iri tax |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:EUTaxO#2.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#2.0.0">https://w3id.org/EUTaxO#2.0.0</seealso>
    let ``_2.0.0`` = Prefixed_Name(tax, "2.0.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#Animalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Animalia kingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Animalia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#Animalia">https://w3id.org/EUTaxO#Animalia</seealso>
    let Animalia = Prefixed_Name(tax, "Animalia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Base taxon class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Taxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#Taxon">https://w3id.org/EUTaxO#Taxon</seealso>
    let Taxon = Prefixed_Name(tax, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Defines a hierarchy from more generic taxa, to more specific ones"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"belongs to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#belongsTo">https://w3id.org/EUTaxO#belongsTo</seealso>
    let belongsTo = Prefixed_Name(tax, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#brackets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether to use brackets for the correct nomenclature of a taxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"brackets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#brackets">https://w3id.org/EUTaxO#brackets</seealso>
    let brackets = Prefixed_Name(tax, "brackets") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"id from the EUdaphobase database"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#id">https://w3id.org/EUTaxO#id</seealso>
    let id = Prefixed_Name(tax, "id") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The kingdom of a specific taxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#kingdom">https://w3id.org/EUTaxO#kingdom</seealso>
    let kingdom = Prefixed_Name(tax, "kingdom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The phylum of a specific taxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phylum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#phylum">https://w3id.org/EUTaxO#phylum</seealso>
    let phylum = Prefixed_Name(tax, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relates if two taxon are synonyms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"synonym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#synonym">https://w3id.org/EUTaxO#synonym</seealso>
    let synonym = Prefixed_Name(tax, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>w3id:EUTaxO#synonyms_exist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether or not synonyms exists for a given taxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"synonyms exist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/EUTaxO#synonyms_exist">https://w3id.org/EUTaxO#synonyms_exist</seealso>
    let synonyms_exist = Prefixed_Name(tax, "synonyms_exist") |> PrefixedName
