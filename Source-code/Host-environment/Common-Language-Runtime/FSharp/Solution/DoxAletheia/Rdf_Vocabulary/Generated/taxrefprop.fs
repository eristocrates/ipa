namespace http.taxref.mnhn.fr.lod.property.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module taxrefprop =
    let _namespace_iri = Namespace_Iri taxrefprop |> NamespaceIRI
    /// <summary>
    ///   <para>taxref-ld:property/hasSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sex"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasSex">http://taxref.mnhn.fr/lod/property/hasSex</seealso>
    let hasSex = Prefixed_Name(taxrefprop, "hasSex") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/hasSpecificity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has a specificity"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasSpecificity">http://taxref.mnhn.fr/lod/property/hasSpecificity</seealso>
    let hasSpecificity = Prefixed_Name(taxrefprop, "hasSpecificity") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has status"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasStatus">http://taxref.mnhn.fr/lod/property/hasStatus</seealso>
    let hasStatus = Prefixed_Name(taxrefprop, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/hasSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"DwC's scientificName property is recommended to be used with a literal object, and does not distinguish between reference vs. synonym names. Hence, in TAXREF-LD, we extend it with rdfs:subPropertyOf instead of asserting an equivalence."</para>
    /// labels<para>"has synonym"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasSynonym">http://taxref.mnhn.fr/lod/property/hasSynonym</seealso>
    let hasSynonym = Prefixed_Name(taxrefprop, "hasSynonym") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/hasTrophicLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has trophic level"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasTrophicLevel">http://taxref.mnhn.fr/lod/property/hasTrophicLevel</seealso>
    let hasTrophicLevel = Prefixed_Name(taxrefprop, "hasTrophicLevel") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:property/isReferenceNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is the reference name of"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/isReferenceNameOf">http://taxref.mnhn.fr/lod/property/isReferenceNameOf</seealso>
    let isReferenceNameOf =
        Prefixed_Name(taxrefprop, "isReferenceNameOf") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:property/isSynonymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is a synonym of"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/isSynonymOf">http://taxref.mnhn.fr/lod/property/isSynonymOf</seealso>
    let isSynonymOf = Prefixed_Name(taxrefprop, "isSynonymOf") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/statusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"status type"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/statusType">http://taxref.mnhn.fr/lod/property/statusType</seealso>
    let statusType = Prefixed_Name(taxrefprop, "statusType") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/statusValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"status value"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/statusValue">http://taxref.mnhn.fr/lod/property/statusValue</seealso>
    let statusValue = Prefixed_Name(taxrefprop, "statusValue") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/vernacularName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has vernacular name"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/vernacularName">http://taxref.mnhn.fr/lod/property/vernacularName</seealso>
    let vernacularName = Prefixed_Name(taxrefprop, "vernacularName") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/vernacularNameXL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property was initially defined as a subPropertyOf skosxl:altLabel. However skosxl:altLabel is an owl:ObjectProperty and thus cannot apply to a class. Therefore, we instead define it a an owl:AnnotationProperty whose range is a skosxl:Label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has extended vernacular name"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/vernacularNameXL">http://taxref.mnhn.fr/lod/property/vernacularNameXL</seealso>
    let vernacularNameXL = Prefixed_Name(taxrefprop, "vernacularNameXL") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/bioGeoStatusIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has biogeograpical status"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/bioGeoStatusIn">http://taxref.mnhn.fr/lod/property/bioGeoStatusIn</seealso>
    let bioGeoStatusIn = Prefixed_Name(taxrefprop, "bioGeoStatusIn") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has habitat"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/habitat">http://taxref.mnhn.fr/lod/property/habitat</seealso>
    let habitat = Prefixed_Name(taxrefprop, "habitat") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/hasAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"TDWG ontology's property http://rs.tdwg.org/ontology/voc/TaxonName#authorship is preferably associated with a scientific name (http://rs.tdwg.org/ontology/voc/TaxonName#TaxonName), which is in line with TAXREF-LD's modelling. By contrast, DwC's scientificNameAuthorship property is associated with a taxon (dwc:Taxon), and its object shoud be a literal (DwC does not have a class for taxon names). Therefore, TAXREF-LD's hasAuthority property is not equivalent to the latter."</para>
    /// labels<para>"has scientific name authority"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasAuthority">http://taxref.mnhn.fr/lod/property/hasAuthority</seealso>
    let hasAuthority = Prefixed_Name(taxrefprop, "hasAuthority") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:property/hasBiologicalStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has biological stage"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasBiologicalStage">http://taxref.mnhn.fr/lod/property/hasBiologicalStage</seealso>
    let hasBiologicalStage =
        Prefixed_Name(taxrefprop, "hasBiologicalStage") |> PrefixedName

    /// <summary>
    ///   <para>taxref-ld:property/hasRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property is not equivalent to http://rs.tdwg.org/ontology/voc/TaxonConcept#rank nor http://rs.tdwg.org/ontology/voc/TaxonName#rank whose domains are http://rs.tdwg.org/ontology/voc/TaxonConcept#TaxonConcept and http://rs.tdwg.org/ontology/voc/TaxonName#TaxonName respectively, whereas we want to use taxrefprop:hasRank with taxa implemented as owl:Class's as well as scientific names implemented as instances of skos:Concept. "</para>
    ///   <para>"This property is not equivalent to dwc:taxonRank which is expected to be used only with literal values (see http://rs.tdwg.org/dwc/terms/guides/rdf/index.htm, section 3.5)"</para>
    /// labels<para>"has taxonomic rank"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasRank">http://taxref.mnhn.fr/lod/property/hasRank</seealso>
    let hasRank = Prefixed_Name(taxrefprop, "hasRank") |> PrefixedName
    /// <summary>
    ///   <para>taxref-ld:property/hasReferenceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"DwC's scientificName property is recommended to be used with a literal object, and does not distinguish between reference vs. synonym names. Hence, TAXREF-LD extends it (rdfs:subPropertyOf) instead of asserting an equivalence."</para>
    /// labels<para>"has reference name"</para></remarks>
    /// <seealso href="http://taxref.mnhn.fr/lod/property/hasReferenceName">http://taxref.mnhn.fr/lod/property/hasReferenceName</seealso>
    let hasReferenceName = Prefixed_Name(taxrefprop, "hasReferenceName") |> PrefixedName
