namespace http.w3id.org.sepses.vocab.ref.attack.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module attack =
    let _namespace_iri = Namespace_Iri attack |> NamespaceIRI
    /// <summary>
    ///   <para>attack:Campaign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Campaign</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Campaign">http://w3id.org/sepses/vocab/ref/attack#Campaign</seealso>
    let Campaign = Prefixed_Name(attack, "Campaign") |> PrefixedName
    /// <summary>
    ///   <para>attack:Malware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Malware</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Malware">http://w3id.org/sepses/vocab/ref/attack#Malware</seealso>
    let Malware = Prefixed_Name(attack, "Malware") |> PrefixedName
    /// <summary>
    ///   <para>attack:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Software</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Software">http://w3id.org/sepses/vocab/ref/attack#Software</seealso>
    let Software = Prefixed_Name(attack, "Software") |> PrefixedName
    /// <summary>
    ///   <para>attack:Mitigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mitigation</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Mitigation">http://w3id.org/sepses/vocab/ref/attack#Mitigation</seealso>
    let Mitigation = Prefixed_Name(attack, "Mitigation") |> PrefixedName
    /// <summary>
    ///   <para>attack:Tactic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tactic</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Tactic">http://w3id.org/sepses/vocab/ref/attack#Tactic</seealso>
    let Tactic = Prefixed_Name(attack, "Tactic") |> PrefixedName
    /// <summary>
    ///   <para>attack:accomplishesTactic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>accomplishesTactic</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#accomplishesTactic">http://w3id.org/sepses/vocab/ref/attack#accomplishesTactic</seealso>
    let accomplishesTactic = Prefixed_Name(attack, "accomplishesTactic") |> PrefixedName
    /// <summary>
    ///   <para>attack:associatedGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>associatedGroup</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#associatedGroup">http://w3id.org/sepses/vocab/ref/attack#associatedGroup</seealso>
    let associatedGroup = Prefixed_Name(attack, "associatedGroup") |> PrefixedName
    /// <summary>
    ///   <para>attack:hasCAPEC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasCAPEC</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#hasCAPEC">http://w3id.org/sepses/vocab/ref/attack#hasCAPEC</seealso>
    let hasCAPEC = Prefixed_Name(attack, "hasCAPEC") |> PrefixedName
    /// <summary>
    ///   <para>attack:AdversaryGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>AdversaryGroup</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#AdversaryGroup">http://w3id.org/sepses/vocab/ref/attack#AdversaryGroup</seealso>
    let AdversaryGroup = Prefixed_Name(attack, "AdversaryGroup") |> PrefixedName
    /// <summary>
    ///   <para>attack:DataComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DataComponent</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#DataComponent">http://w3id.org/sepses/vocab/ref/attack#DataComponent</seealso>
    let DataComponent = Prefixed_Name(attack, "DataComponent") |> PrefixedName
    /// <summary>
    ///   <para>attack:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reference</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Reference">http://w3id.org/sepses/vocab/ref/attack#Reference</seealso>
    let Reference = Prefixed_Name(attack, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>attack:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Asset</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Asset">http://w3id.org/sepses/vocab/ref/attack#Asset</seealso>
    let Asset = Prefixed_Name(attack, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>attack:DataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DataSource</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#DataSource">http://w3id.org/sepses/vocab/ref/attack#DataSource</seealso>
    let DataSource = Prefixed_Name(attack, "DataSource") |> PrefixedName
    /// <summary>
    ///   <para>attack:SubTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SubTechnique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#SubTechnique">http://w3id.org/sepses/vocab/ref/attack#SubTechnique</seealso>
    let SubTechnique = Prefixed_Name(attack, "SubTechnique") |> PrefixedName
    /// <summary>
    ///   <para>attack:aliases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>aliases</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#aliases">http://w3id.org/sepses/vocab/ref/attack#aliases</seealso>
    let aliases = Prefixed_Name(attack, "aliases") |> PrefixedName
    /// <summary>
    ///   <para>attack:detection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>detection</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#detection">http://w3id.org/sepses/vocab/ref/attack#detection</seealso>
    let detection = Prefixed_Name(attack, "detection") |> PrefixedName
    /// <summary>
    ///   <para>attack:hasMitigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasMitigation</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#hasMitigation">http://w3id.org/sepses/vocab/ref/attack#hasMitigation</seealso>
    let hasMitigation = Prefixed_Name(attack, "hasMitigation") |> PrefixedName
    /// <summary>
    ///   <para>attack:permissionRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>permissionRequired</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#permissionRequired">http://w3id.org/sepses/vocab/ref/attack#permissionRequired</seealso>
    let permissionRequired = Prefixed_Name(attack, "permissionRequired") |> PrefixedName
    /// <summary>
    ///   <para>attack:hasAdversaryGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasAdversaryGroup</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#hasAdversaryGroup">http://w3id.org/sepses/vocab/ref/attack#hasAdversaryGroup</seealso>
    let hasAdversaryGroup = Prefixed_Name(attack, "hasAdversaryGroup") |> PrefixedName
    /// <summary>
    ///   <para>attack:dataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dataSource</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#dataSource">http://w3id.org/sepses/vocab/ref/attack#dataSource</seealso>
    let dataSource = Prefixed_Name(attack, "dataSource") |> PrefixedName
    /// <summary>
    ///   <para>attack:hasReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasReference</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#hasReference">http://w3id.org/sepses/vocab/ref/attack#hasReference</seealso>
    let hasReference = Prefixed_Name(attack, "hasReference") |> PrefixedName
    /// <summary>
    ///   <para>attack:hasSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasSoftware</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#hasSoftware">http://w3id.org/sepses/vocab/ref/attack#hasSoftware</seealso>
    let hasSoftware = Prefixed_Name(attack, "hasSoftware") |> PrefixedName
    /// <summary>
    ///   <para>attack:isSubtechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>isSubtechnique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#isSubtechnique">http://w3id.org/sepses/vocab/ref/attack#isSubtechnique</seealso>
    let isSubtechnique = Prefixed_Name(attack, "isSubtechnique") |> PrefixedName

    /// <summary>
    ///   <para>attack:referenceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>referenceDescription</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#referenceDescription">http://w3id.org/sepses/vocab/ref/attack#referenceDescription</seealso>
    let referenceDescription =
        Prefixed_Name(attack, "referenceDescription") |> PrefixedName

    /// <summary>
    ///   <para>attack:referenceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>referenceName</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#referenceName">http://w3id.org/sepses/vocab/ref/attack#referenceName</seealso>
    let referenceName = Prefixed_Name(attack, "referenceName") |> PrefixedName
    /// <summary>
    ///   <para>attack:usesMalware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>usesMalware</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#usesMalware">http://w3id.org/sepses/vocab/ref/attack#usesMalware</seealso>
    let usesMalware = Prefixed_Name(attack, "usesMalware") |> PrefixedName
    /// <summary>
    ///   <para>attack:usesTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>usesTechnique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#usesTechnique">http://w3id.org/sepses/vocab/ref/attack#usesTechnique</seealso>
    let usesTechnique = Prefixed_Name(attack, "usesTechnique") |> PrefixedName
    /// <summary>
    ///   <para>attack:hasTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasTechnique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#hasTechnique">http://w3id.org/sepses/vocab/ref/attack#hasTechnique</seealso>
    let hasTechnique = Prefixed_Name(attack, "hasTechnique") |> PrefixedName
    /// <summary>
    ///   <para>attack:isSubTechniqueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isSubTechniqueOf</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#isSubTechniqueOf">http://w3id.org/sepses/vocab/ref/attack#isSubTechniqueOf</seealso>
    let isSubTechniqueOf = Prefixed_Name(attack, "isSubTechniqueOf") |> PrefixedName
    /// <summary>
    ///   <para>attack:platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>platform</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#platform">http://w3id.org/sepses/vocab/ref/attack#platform</seealso>
    let platform = Prefixed_Name(attack, "platform") |> PrefixedName

    /// <summary>
    ///   <para>attack:implementsTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>implementsTechnique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#implementsTechnique">http://w3id.org/sepses/vocab/ref/attack#implementsTechnique</seealso>
    let implementsTechnique =
        Prefixed_Name(attack, "implementsTechnique") |> PrefixedName

    /// <summary>
    ///   <para>attack:preventsTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>preventsTechnique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#preventsTechnique">http://w3id.org/sepses/vocab/ref/attack#preventsTechnique</seealso>
    let preventsTechnique = Prefixed_Name(attack, "preventsTechnique") |> PrefixedName
    /// <summary>
    ///   <para>attack:referenceId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>referenceId</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#referenceId">http://w3id.org/sepses/vocab/ref/attack#referenceId</seealso>
    let referenceId = Prefixed_Name(attack, "referenceId") |> PrefixedName
    /// <summary>
    ///   <para>attack:targetsAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>targetsAsset</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#targetsAsset">http://w3id.org/sepses/vocab/ref/attack#targetsAsset</seealso>
    let targetsAsset = Prefixed_Name(attack, "targetsAsset") |> PrefixedName
    /// <summary>
    ///   <para>attack:referenceUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>referenceUrl</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#referenceUrl">http://w3id.org/sepses/vocab/ref/attack#referenceUrl</seealso>
    let referenceUrl = Prefixed_Name(attack, "referenceUrl") |> PrefixedName
    /// <summary>
    ///   <para>attack:usesSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>usesSoftware</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#usesSoftware">http://w3id.org/sepses/vocab/ref/attack#usesSoftware</seealso>
    let usesSoftware = Prefixed_Name(attack, "usesSoftware") |> PrefixedName
    /// <summary>
    ///   <para>attack:Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Technique</para></remarks>
    /// <seealso href="http://w3id.org/sepses/vocab/ref/attack#Technique">http://w3id.org/sepses/vocab/ref/attack#Technique</seealso>
    let Technique = Prefixed_Name(attack, "Technique") |> PrefixedName
