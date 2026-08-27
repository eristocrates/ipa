namespace https.w3id.org.tribont.material.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont_material =
    let _namespace_iri = Namespace_Iri tribont_material |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:tribont/material#AISI_52100</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"AISI_52100"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#AISI_52100">https://w3id.org/tribont/material#AISI_52100</seealso>
    let AISI_52100 = Prefixed_Name(tribont_material, "AISI_52100") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#ASTM_A295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    ///
    /// labels<para>"ASTM_A295"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ASTM_A295">https://w3id.org/tribont/material#ASTM_A295</seealso>
    let ASTM_A295 = Prefixed_Name(tribont_material, "ASTM_A295") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ag in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ag">https://w3id.org/tribont/material#Ag</seealso>
    let Ag = Prefixed_Name(tribont_material, "Ag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Al</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Al in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Al"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Al">https://w3id.org/tribont/material#Al</seealso>
    let Al = Prefixed_Name(tribont_material, "Al") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Al203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Al203 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Al203"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Al203">https://w3id.org/tribont/material#Al203</seealso>
    let Al203 = Prefixed_Name(tribont_material, "Al203") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#AlN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of AlN in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AlN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#AlN">https://w3id.org/tribont/material#AlN</seealso>
    let AlN = Prefixed_Name(tribont_material, "AlN") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Alluminium-Flake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Alluminium-Flake in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alluminium-Flake"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Alluminium-Flake">https://w3id.org/tribont/material#Alluminium-Flake</seealso>
    let Alluminium_Flake =
        Prefixed_Name(tribont_material, "Alluminium-Flake") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#AlluminiumAlloy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Alluminium alloy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AlluminiumAlloy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#AlluminiumAlloy">https://w3id.org/tribont/material#AlluminiumAlloy</seealso>
    let AlluminiumAlloy =
        Prefixed_Name(tribont_material, "AlluminiumAlloy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#AntifrictionLubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Anti-friction/wearLubricant in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anti-friction/wearLubricant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#AntifrictionLubricant">https://w3id.org/tribont/material#AntifrictionLubricant</seealso>
    let AntifrictionLubricant =
        Prefixed_Name(tribont_material, "AntifrictionLubricant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Antioxidant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Antioxidant content for something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Antioxidant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Antioxidant">https://w3id.org/tribont/material#Antioxidant</seealso>
    let Antioxidant = Prefixed_Name(tribont_material, "Antioxidant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Aramid-Fiber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Aramid-Fiber in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aramid-Fiber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Aramid-Fiber">https://w3id.org/tribont/material#Aramid-Fiber</seealso>
    let Aramid_Fiber = Prefixed_Name(tribont_material, "Aramid-Fiber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#ArsenicOxide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of ArsenicOxide in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ArsenicOxide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ArsenicOxide">https://w3id.org/tribont/material#ArsenicOxide</seealso>
    let ArsenicOxide = Prefixed_Name(tribont_material, "ArsenicOxide") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#As</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of As in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"As"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#As">https://w3id.org/tribont/material#As</seealso>
    let As = Prefixed_Name(tribont_material, "As") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Au</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Au in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Au"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Au">https://w3id.org/tribont/material#Au</seealso>
    let Au = Prefixed_Name(tribont_material, "Au") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#B</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of B in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#B">https://w3id.org/tribont/material#B</seealso>
    let B = Prefixed_Name(tribont_material, "B") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#B203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of B203 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B203"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#B203">https://w3id.org/tribont/material#B203</seealso>
    let B203 = Prefixed_Name(tribont_material, "B203") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#B4C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of B4C in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"B4C"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#B4C">https://w3id.org/tribont/material#B4C</seealso>
    let B4C = Prefixed_Name(tribont_material, "B4C") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#BN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of BN in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#BN">https://w3id.org/tribont/material#BN</seealso>
    let BN = Prefixed_Name(tribont_material, "BN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#BS_970</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    ///
    /// labels<para>"BS_970"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#BS_970">https://w3id.org/tribont/material#BS_970</seealso>
    let BS_970 = Prefixed_Name(tribont_material, "BS_970") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#BaO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of BaO in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BaO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#BaO">https://w3id.org/tribont/material#BaO</seealso>
    let BaO = Prefixed_Name(tribont_material, "BaO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#BaSO4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of BaSO4 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BaSO4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#BaSO4">https://w3id.org/tribont/material#BaSO4</seealso>
    let BaSO4 = Prefixed_Name(tribont_material, "BaSO4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Be</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Be in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Be"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Be">https://w3id.org/tribont/material#Be</seealso>
    let Be = Prefixed_Name(tribont_material, "Be") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#BeO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of BeO in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BeO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#BeO">https://w3id.org/tribont/material#BeO</seealso>
    let BeO = Prefixed_Name(tribont_material, "BeO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Bi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Biin a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Bi">https://w3id.org/tribont/material#Bi</seealso>
    let Bi = Prefixed_Name(tribont_material, "Bi") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of C in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"C"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#C">https://w3id.org/tribont/material#C</seealso>
    let C = Prefixed_Name(tribont_material, "C") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#CAS_Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    ///
    /// labels<para>"CAS_Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CAS_Number">https://w3id.org/tribont/material#CAS_Number</seealso>
    let CAS_Number = Prefixed_Name(tribont_material, "CAS_Number") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ca</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ca in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ca"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ca">https://w3id.org/tribont/material#Ca</seealso>
    let Ca = Prefixed_Name(tribont_material, "Ca") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#CaCO3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of CaCO3 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CaCO3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CaCO3">https://w3id.org/tribont/material#CaCO3</seealso>
    let CaCO3 = Prefixed_Name(tribont_material, "CaCO3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#CaO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of CaO in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CaO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CaO">https://w3id.org/tribont/material#CaO</seealso>
    let CaO = Prefixed_Name(tribont_material, "CaO") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#CalciumCarbonate-Powder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of CalciumCarbonate-Powder in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CalciumCarbonate-Powder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CalciumCarbonate-Powder">https://w3id.org/tribont/material#CalciumCarbonate-Powder</seealso>
    let CalciumCarbonate_Powder =
        Prefixed_Name(tribont_material, "CalciumCarbonate-Powder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Carbon-Fiber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Carbon-Fiber in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Carbon-Fiber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Carbon-Fiber">https://w3id.org/tribont/material#Carbon-Fiber</seealso>
    let Carbon_Fiber = Prefixed_Name(tribont_material, "Carbon-Fiber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Carbon-Powder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Carbon-Powder in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Carbon-Powder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Carbon-Powder">https://w3id.org/tribont/material#Carbon-Powder</seealso>
    let Carbon_Powder = Prefixed_Name(tribont_material, "Carbon-Powder") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Cd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Cd in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Cd">https://w3id.org/tribont/material#Cd</seealso>
    let Cd = Prefixed_Name(tribont_material, "Cd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#CdS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of CdS in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CdS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CdS">https://w3id.org/tribont/material#CdS</seealso>
    let CdS = Prefixed_Name(tribont_material, "CdS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ce in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ce"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ce">https://w3id.org/tribont/material#Ce</seealso>
    let Ce = Prefixed_Name(tribont_material, "Ce") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Cellulose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Cellulose in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cellulose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Cellulose">https://w3id.org/tribont/material#Cellulose</seealso>
    let Cellulose = Prefixed_Name(tribont_material, "Cellulose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#CeramicMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ceramic material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CeramicMaterial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CeramicMaterial">https://w3id.org/tribont/material#CeramicMaterial</seealso>
    let CeramicMaterial =
        Prefixed_Name(tribont_material, "CeramicMaterial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#ChemicalElementConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concentration of chemical element in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ChemicalElementConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ChemicalElementConcentration">https://w3id.org/tribont/material#ChemicalElementConcentration</seealso>
    let ChemicalElementConcentration =
        Prefixed_Name(tribont_material, "ChemicalElementConcentration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Co</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Co in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Co"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Co">https://w3id.org/tribont/material#Co</seealso>
    let Co = Prefixed_Name(tribont_material, "Co") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#CompositeMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Composite material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CompositeMaterial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#CompositeMaterial">https://w3id.org/tribont/material#CompositeMaterial</seealso>
    let CompositeMaterial =
        Prefixed_Name(tribont_material, "CompositeMaterial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Cr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Cr in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cr"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Cr">https://w3id.org/tribont/material#Cr</seealso>
    let Cr = Prefixed_Name(tribont_material, "Cr") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Cr203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Cr203 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cr203"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Cr203">https://w3id.org/tribont/material#Cr203</seealso>
    let Cr203 = Prefixed_Name(tribont_material, "Cr203") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Cu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Cu in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cu"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Cu">https://w3id.org/tribont/material#Cu</seealso>
    let Cu = Prefixed_Name(tribont_material, "Cu") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#DIN_17230</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DIN_17230"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#DIN_17230">https://w3id.org/tribont/material#DIN_17230</seealso>
    let DIN_17230 = Prefixed_Name(tribont_material, "DIN_17230") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Dy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Dy in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Dy">https://w3id.org/tribont/material#Dy</seealso>
    let Dy = Prefixed_Name(tribont_material, "Dy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#ElastomerThermoplastic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Elastomer thermoplastic material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElastomerThermoplastic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ElastomerThermoplastic">https://w3id.org/tribont/material#ElastomerThermoplastic</seealso>
    let ElastomerThermoplastic =
        Prefixed_Name(tribont_material, "ElastomerThermoplastic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#ElastomerThermoset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Elastomer thermoset material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElastomerThermoset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ElastomerThermoset">https://w3id.org/tribont/material#ElastomerThermoset</seealso>
    let ElastomerThermoset =
        Prefixed_Name(tribont_material, "ElastomerThermoset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#ElementConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concentration of an specific element in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElementConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ElementConcentration">https://w3id.org/tribont/material#ElementConcentration</seealso>
    let ElementConcentration =
        Prefixed_Name(tribont_material, "ElementConcentration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#ElementRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position or purpose that an element has in a situation or relationship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElementRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ElementRole">https://w3id.org/tribont/material#ElementRole</seealso>
    let ElementRole = Prefixed_Name(tribont_material, "ElementRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Er</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Er in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Er"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Er">https://w3id.org/tribont/material#Er</seealso>
    let Er = Prefixed_Name(tribont_material, "Er") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Eu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Eu in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Eu"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Eu">https://w3id.org/tribont/material#Eu</seealso>
    let Eu = Prefixed_Name(tribont_material, "Eu") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#F</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of F in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"F"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#F">https://w3id.org/tribont/material#F</seealso>
    let F = Prefixed_Name(tribont_material, "F") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Fe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Fe in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Fe">https://w3id.org/tribont/material#Fe</seealso>
    let Fe = Prefixed_Name(tribont_material, "Fe") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Fe203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Fe203 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fe203"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Fe203">https://w3id.org/tribont/material#Fe203</seealso>
    let Fe203 = Prefixed_Name(tribont_material, "Fe203") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#FlameRetardant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of FlameRetardant in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FlameRetardant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#FlameRetardant">https://w3id.org/tribont/material#FlameRetardant</seealso>
    let FlameRetardant =
        Prefixed_Name(tribont_material, "FlameRetardant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#FluidLubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fluid lubricant material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FluidLubricant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#FluidLubricant">https://w3id.org/tribont/material#FluidLubricant</seealso>
    let FluidLubricant =
        Prefixed_Name(tribont_material, "FluidLubricant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Gd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Gd in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Gd">https://w3id.org/tribont/material#Gd</seealso>
    let Gd = Prefixed_Name(tribont_material, "Gd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ge in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ge">https://w3id.org/tribont/material#Ge</seealso>
    let Ge = Prefixed_Name(tribont_material, "Ge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Glass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Glass material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Glass">https://w3id.org/tribont/material#Glass</seealso>
    let Glass = Prefixed_Name(tribont_material, "Glass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Glass-Fiber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Glass-Fiber in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glass-Fiber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Glass-Fiber">https://w3id.org/tribont/material#Glass-Fiber</seealso>
    let Glass_Fiber = Prefixed_Name(tribont_material, "Glass-Fiber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Glass-MatFabric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Glass-MatFabric in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glass-MatFabric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Glass-MatFabric">https://w3id.org/tribont/material#Glass-MatFabric</seealso>
    let Glass_MatFabric =
        Prefixed_Name(tribont_material, "Glass-MatFabric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Glycol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of glycol of something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glycol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Glycol">https://w3id.org/tribont/material#Glycol</seealso>
    let Glycol = Prefixed_Name(tribont_material, "Glycol") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Graphite-Powder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Graphite-Powder in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Graphite-Powder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Graphite-Powder">https://w3id.org/tribont/material#Graphite-Powder</seealso>
    let Graphite_Powder =
        Prefixed_Name(tribont_material, "Graphite-Powder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Grease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Grease material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Grease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Grease">https://w3id.org/tribont/material#Grease</seealso>
    let Grease = Prefixed_Name(tribont_material, "Grease") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#H</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of H in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#H">https://w3id.org/tribont/material#H</seealso>
    let H = Prefixed_Name(tribont_material, "H") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#H2O</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of H2O in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"H2O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#H2O">https://w3id.org/tribont/material#H2O</seealso>
    let H2O = Prefixed_Name(tribont_material, "H2O") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Hf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Hf in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Hf">https://w3id.org/tribont/material#Hf</seealso>
    let Hf = Prefixed_Name(tribont_material, "Hf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Hg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Hg in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Hg">https://w3id.org/tribont/material#Hg</seealso>
    let Hg = Prefixed_Name(tribont_material, "Hg") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#HighAlloySteel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"High alloy steel material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HighAlloySteel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#HighAlloySteel">https://w3id.org/tribont/material#HighAlloySteel</seealso>
    let HighAlloySteel =
        Prefixed_Name(tribont_material, "HighAlloySteel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Ho</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ho in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ho"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ho">https://w3id.org/tribont/material#Ho</seealso>
    let Ho = Prefixed_Name(tribont_material, "Ho") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#ImpactModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of ImpactModifier in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ImpactModifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ImpactModifier">https://w3id.org/tribont/material#ImpactModifier</seealso>
    let ImpactModifier =
        Prefixed_Name(tribont_material, "ImpactModifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#In</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of In in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#In">https://w3id.org/tribont/material#In</seealso>
    let In = Prefixed_Name(tribont_material, "In") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ir in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ir"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ir">https://w3id.org/tribont/material#Ir</seealso>
    let Ir = Prefixed_Name(tribont_material, "Ir") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#JIS_G4805</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    ///
    /// labels<para>"JIS_G4805"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#JIS_G4805">https://w3id.org/tribont/material#JIS_G4805</seealso>
    let JIS_G4805 = Prefixed_Name(tribont_material, "JIS_G4805") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#La</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of La in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"La"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#La">https://w3id.org/tribont/material#La</seealso>
    let La = Prefixed_Name(tribont_material, "La") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Li</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Li in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Li"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Li">https://w3id.org/tribont/material#Li</seealso>
    let Li = Prefixed_Name(tribont_material, "Li") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Li2O</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Li2O in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Li2O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Li2O">https://w3id.org/tribont/material#Li2O</seealso>
    let Li2O = Prefixed_Name(tribont_material, "Li2O") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#LiquidMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Liquid material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LiquidMaterial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#LiquidMaterial">https://w3id.org/tribont/material#LiquidMaterial</seealso>
    let LiquidMaterial =
        Prefixed_Name(tribont_material, "LiquidMaterial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#LowAlloySteel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Low alloy steel material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LowAlloySteel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#LowAlloySteel">https://w3id.org/tribont/material#LowAlloySteel</seealso>
    let LowAlloySteel = Prefixed_Name(tribont_material, "LowAlloySteel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Lu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Lu in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lu"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Lu">https://w3id.org/tribont/material#Lu</seealso>
    let Lu = Prefixed_Name(tribont_material, "Lu") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The basic material from which something is made."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Material">https://w3id.org/tribont/material#Material</seealso>
    let Material = Prefixed_Name(tribont_material, "Material") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#MaterialApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The possible uses of a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MaterialApplication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MaterialApplication">https://w3id.org/tribont/material#MaterialApplication</seealso>
    let MaterialApplication =
        Prefixed_Name(tribont_material, "MaterialApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#MaterialIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that identifies a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MaterialIdentification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MaterialIdentification">https://w3id.org/tribont/material#MaterialIdentification</seealso>
    let MaterialIdentification =
        Prefixed_Name(tribont_material, "MaterialIdentification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#MaterialNaming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unique name asssigned to a material independently of the manufacturer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MaterialNaming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MaterialNaming">https://w3id.org/tribont/material#MaterialNaming</seealso>
    let MaterialNaming =
        Prefixed_Name(tribont_material, "MaterialNaming") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#MaterialStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document approved by a recognized body that provides common to by fullfiled by a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MaterialStandard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MaterialStandard">https://w3id.org/tribont/material#MaterialStandard</seealso>
    let MaterialStandard =
        Prefixed_Name(tribont_material, "MaterialStandard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#MaterialTradename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Commercial name of a material defined by the manufactuer company."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MaterialTradename"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MaterialTradename">https://w3id.org/tribont/material#MaterialTradename</seealso>
    let MaterialTradename =
        Prefixed_Name(tribont_material, "MaterialTradename") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#MetallicMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metal and alloy material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MetallicMaterial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MetallicMaterial">https://w3id.org/tribont/material#MetallicMaterial</seealso>
    let MetallicMaterial =
        Prefixed_Name(tribont_material, "MetallicMaterial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Mg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Mg in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Mg">https://w3id.org/tribont/material#Mg</seealso>
    let Mg = Prefixed_Name(tribont_material, "Mg") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Mica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Mica in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mica"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Mica">https://w3id.org/tribont/material#Mica</seealso>
    let Mica = Prefixed_Name(tribont_material, "Mica") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Mineral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Mineral in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mineral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Mineral">https://w3id.org/tribont/material#Mineral</seealso>
    let Mineral = Prefixed_Name(tribont_material, "Mineral") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Mn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Mn in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Mn">https://w3id.org/tribont/material#Mn</seealso>
    let Mn = Prefixed_Name(tribont_material, "Mn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Mo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Mo in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Mo">https://w3id.org/tribont/material#Mo</seealso>
    let Mo = Prefixed_Name(tribont_material, "Mo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#MoS2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of MoS2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MoS2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#MoS2">https://w3id.org/tribont/material#MoS2</seealso>
    let MoS2 = Prefixed_Name(tribont_material, "MoS2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#N</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of N in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"N"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#N">https://w3id.org/tribont/material#N</seealso>
    let N = Prefixed_Name(tribont_material, "N") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Na2O</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Na2O in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Na2O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Na2O">https://w3id.org/tribont/material#Na2O</seealso>
    let Na2O = Prefixed_Name(tribont_material, "Na2O") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#NaCl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of NaCl in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NaCl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#NaCl">https://w3id.org/tribont/material#NaCl</seealso>
    let NaCl = Prefixed_Name(tribont_material, "NaCl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Nb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Nb in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Nb">https://w3id.org/tribont/material#Nb</seealso>
    let Nb = Prefixed_Name(tribont_material, "Nb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Nd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Nd in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Nd">https://w3id.org/tribont/material#Nd</seealso>
    let Nd = Prefixed_Name(tribont_material, "Nd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ni</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ni in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ni"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ni">https://w3id.org/tribont/material#Ni</seealso>
    let Ni = Prefixed_Name(tribont_material, "Ni") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#NonFerrousMetalInhibitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Non Ferrous Metal Inhibitors Content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NonFerrousMetalInhibitor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#NonFerrousMetalInhibitor">https://w3id.org/tribont/material#NonFerrousMetalInhibitor</seealso>
    let NonFerrousMetalInhibitor =
        Prefixed_Name(tribont_material, "NonFerrousMetalInhibitor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#O</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of O in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"O"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#O">https://w3id.org/tribont/material#O</seealso>
    let O = Prefixed_Name(tribont_material, "O") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#O2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of O2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"O2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#O2">https://w3id.org/tribont/material#O2</seealso>
    let O2 = Prefixed_Name(tribont_material, "O2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Oil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Oil material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Oil">https://w3id.org/tribont/material#Oil</seealso>
    let Oil = Prefixed_Name(tribont_material, "Oil") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Os</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Os in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Os"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Os">https://w3id.org/tribont/material#Os</seealso>
    let Os = Prefixed_Name(tribont_material, "Os") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#OtherElementConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concentration  of an additive element in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OtherElementConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#OtherElementConcentration">https://w3id.org/tribont/material#OtherElementConcentration</seealso>
    let OtherElementConcentration =
        Prefixed_Name(tribont_material, "OtherElementConcentration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#P</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of P in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"P"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#P">https://w3id.org/tribont/material#P</seealso>
    let P = Prefixed_Name(tribont_material, "P") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#PTFE-Lubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PTFE-Lubricant material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PTFE-Lubricant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PTFE-Lubricant">https://w3id.org/tribont/material#PTFE-Lubricant</seealso>
    let PTFE_Lubricant =
        Prefixed_Name(tribont_material, "PTFE-Lubricant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Pb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Pb in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Pb">https://w3id.org/tribont/material#Pb</seealso>
    let Pb = Prefixed_Name(tribont_material, "Pb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#PbO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of PbO in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PbO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PbO">https://w3id.org/tribont/material#PbO</seealso>
    let PbO = Prefixed_Name(tribont_material, "PbO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Pd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Pd in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Pd">https://w3id.org/tribont/material#Pd</seealso>
    let Pd = Prefixed_Name(tribont_material, "Pd") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#PlasticThermoplastic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plastic thermoplastic material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PlasticThermoplastic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PlasticThermoplastic">https://w3id.org/tribont/material#PlasticThermoplastic</seealso>
    let PlasticThermoplastic =
        Prefixed_Name(tribont_material, "PlasticThermoplastic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#PlasticThermoset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plastic Thermoset material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PlasticThermoset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PlasticThermoset">https://w3id.org/tribont/material#PlasticThermoset</seealso>
    let PlasticThermoset =
        Prefixed_Name(tribont_material, "PlasticThermoset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#PlasticizerOil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Plasticizer/Oil in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plasticizer/Oil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PlasticizerOil">https://w3id.org/tribont/material#PlasticizerOil</seealso>
    let PlasticizerOil =
        Prefixed_Name(tribont_material, "PlasticizerOil") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#PolymerElementConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concentration of polymer element in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PolymerElementConcentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PolymerElementConcentration">https://w3id.org/tribont/material#PolymerElementConcentration</seealso>
    let PolymerElementConcentration =
        Prefixed_Name(tribont_material, "PolymerElementConcentration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#PolymerMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any polymer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PolymerMaterial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#PolymerMaterial">https://w3id.org/tribont/material#PolymerMaterial</seealso>
    let PolymerMaterial =
        Prefixed_Name(tribont_material, "PolymerMaterial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Pr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Pr in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pr"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Pr">https://w3id.org/tribont/material#Pr</seealso>
    let Pr = Prefixed_Name(tribont_material, "Pr") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Pt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Pt in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Pt">https://w3id.org/tribont/material#Pt</seealso>
    let Pt = Prefixed_Name(tribont_material, "Pt") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Rag-Cotton-Fabric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Rag-Cotton-Fabric in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rag-Cotton-Fabric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Rag-Cotton-Fabric">https://w3id.org/tribont/material#Rag-Cotton-Fabric</seealso>
    let Rag_Cotton_Fabric =
        Prefixed_Name(tribont_material, "Rag-Cotton-Fabric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Re</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Re in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Re"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Re">https://w3id.org/tribont/material#Re</seealso>
    let Re = Prefixed_Name(tribont_material, "Re") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Rh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Rh in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Rh">https://w3id.org/tribont/material#Rh</seealso>
    let Rh = Prefixed_Name(tribont_material, "Rh") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ru</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ru in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ru"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ru">https://w3id.org/tribont/material#Ru</seealso>
    let Ru = Prefixed_Name(tribont_material, "Ru") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#S</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of S in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"S"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#S">https://w3id.org/tribont/material#S</seealso>
    let S = Prefixed_Name(tribont_material, "S") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Sb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Sb in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Sb">https://w3id.org/tribont/material#Sb</seealso>
    let Sb = Prefixed_Name(tribont_material, "Sb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Sc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Sc in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Sc">https://w3id.org/tribont/material#Sc</seealso>
    let Sc = Prefixed_Name(tribont_material, "Sc") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Se</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Se in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Se"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Se">https://w3id.org/tribont/material#Se</seealso>
    let Se = Prefixed_Name(tribont_material, "Se") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Si</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Si in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Si"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Si">https://w3id.org/tribont/material#Si</seealso>
    let Si = Prefixed_Name(tribont_material, "Si") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Si3N4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Si3N4 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Si3N4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Si3N4">https://w3id.org/tribont/material#Si3N4</seealso>
    let Si3N4 = Prefixed_Name(tribont_material, "Si3N4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#SiC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of SiC in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SiC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#SiC">https://w3id.org/tribont/material#SiC</seealso>
    let SiC = Prefixed_Name(tribont_material, "SiC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#SiO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of SiO2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SiO2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#SiO2">https://w3id.org/tribont/material#SiO2</seealso>
    let SiO2 = Prefixed_Name(tribont_material, "SiO2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Silica-Fumed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Silica-Fumed in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Silica-Fumed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Silica-Fumed">https://w3id.org/tribont/material#Silica-Fumed</seealso>
    let Silica_Fumed = Prefixed_Name(tribont_material, "Silica-Fumed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Silicone-Lubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Silicone-Lubricant material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Silicone-Lubricant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Silicone-Lubricant">https://w3id.org/tribont/material#Silicone-Lubricant</seealso>
    let Silicone_Lubricant =
        Prefixed_Name(tribont_material, "Silicone-Lubricant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Sm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Sm  in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Sm">https://w3id.org/tribont/material#Sm</seealso>
    let Sm = Prefixed_Name(tribont_material, "Sm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Sn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Sn in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Sn">https://w3id.org/tribont/material#Sn</seealso>
    let Sn = Prefixed_Name(tribont_material, "Sn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#SolidContaminants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solid contaminants."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SolidContaminants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#SolidContaminants">https://w3id.org/tribont/material#SolidContaminants</seealso>
    let SolidContaminants =
        Prefixed_Name(tribont_material, "SolidContaminants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#SolidLubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solid lubricant material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SolidLubricant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#SolidLubricant">https://w3id.org/tribont/material#SolidLubricant</seealso>
    let SolidLubricant =
        Prefixed_Name(tribont_material, "SolidLubricant") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#SolidMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solid material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SolidMaterial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#SolidMaterial">https://w3id.org/tribont/material#SolidMaterial</seealso>
    let SolidMaterial = Prefixed_Name(tribont_material, "SolidMaterial") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Sr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Sr in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sr"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Sr">https://w3id.org/tribont/material#Sr</seealso>
    let Sr = Prefixed_Name(tribont_material, "Sr") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#StainlessSteel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Stainless steel material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StainlessSteel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#StainlessSteel">https://w3id.org/tribont/material#StainlessSteel</seealso>
    let StainlessSteel =
        Prefixed_Name(tribont_material, "StainlessSteel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#StainlessSteel-Fiber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of StainlessSteel-Fiber in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StainlessSteel-Fiber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#StainlessSteel-Fiber">https://w3id.org/tribont/material#StainlessSteel-Fiber</seealso>
    let StainlessSteel_Fiber =
        Prefixed_Name(tribont_material, "StainlessSteel-Fiber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#Steel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Steel material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Steel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Steel">https://w3id.org/tribont/material#Steel</seealso>
    let Steel = Prefixed_Name(tribont_material, "Steel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#SulfateAsh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sulfate ash ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SulfateAsh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#SulfateAsh">https://w3id.org/tribont/material#SulfateAsh</seealso>
    let SulfateAsh = Prefixed_Name(tribont_material, "SulfateAsh") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ta in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ta">https://w3id.org/tribont/material#Ta</seealso>
    let Ta = Prefixed_Name(tribont_material, "Ta") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#TaC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of TaC in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TaC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#TaC">https://w3id.org/tribont/material#TaC</seealso>
    let TaC = Prefixed_Name(tribont_material, "TaC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Talc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Talc in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Talc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Talc">https://w3id.org/tribont/material#Talc</seealso>
    let Talc = Prefixed_Name(tribont_material, "Talc") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Tb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Tb in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Tb">https://w3id.org/tribont/material#Tb</seealso>
    let Tb = Prefixed_Name(tribont_material, "Tb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Te</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Te in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Te"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Te">https://w3id.org/tribont/material#Te</seealso>
    let Te = Prefixed_Name(tribont_material, "Te") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#ThO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of ThO2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ThO2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ThO2">https://w3id.org/tribont/material#ThO2</seealso>
    let ThO2 = Prefixed_Name(tribont_material, "ThO2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Ti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Ti in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ti"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Ti">https://w3id.org/tribont/material#Ti</seealso>
    let Ti = Prefixed_Name(tribont_material, "Ti") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#TiB2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of TiB2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TiB2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#TiB2">https://w3id.org/tribont/material#TiB2</seealso>
    let TiB2 = Prefixed_Name(tribont_material, "TiB2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#TiC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of TiC in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TiC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#TiC">https://w3id.org/tribont/material#TiC</seealso>
    let TiC = Prefixed_Name(tribont_material, "TiC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#TiO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of TiO2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TiO2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#TiO2">https://w3id.org/tribont/material#TiO2</seealso>
    let TiO2 = Prefixed_Name(tribont_material, "TiO2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#TitaniumAlloy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Titanium alloy material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TitaniumAlloy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#TitaniumAlloy">https://w3id.org/tribont/material#TitaniumAlloy</seealso>
    let TitaniumAlloy = Prefixed_Name(tribont_material, "TitaniumAlloy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Tl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Tl in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Tl">https://w3id.org/tribont/material#Tl</seealso>
    let Tl = Prefixed_Name(tribont_material, "Tl") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Tm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Tm in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Tm">https://w3id.org/tribont/material#Tm</seealso>
    let Tm = Prefixed_Name(tribont_material, "Tm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Tolyltriazole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tolyltriazole concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tolyltriazole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Tolyltriazole">https://w3id.org/tribont/material#Tolyltriazole</seealso>
    let Tolyltriazole = Prefixed_Name(tribont_material, "Tolyltriazole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#ToolSteel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Steel used for tooling."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ToolSteel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ToolSteel">https://w3id.org/tribont/material#ToolSteel</seealso>
    let ToolSteel = Prefixed_Name(tribont_material, "ToolSteel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#U</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of U in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"U"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#U">https://w3id.org/tribont/material#U</seealso>
    let U = Prefixed_Name(tribont_material, "U") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#UVStabilizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of UVStabilizer in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UVStabilizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#UVStabilizer">https://w3id.org/tribont/material#UVStabilizer</seealso>
    let UVStabilizer = Prefixed_Name(tribont_material, "UVStabilizer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#V</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of V in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"V"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#V">https://w3id.org/tribont/material#V</seealso>
    let V = Prefixed_Name(tribont_material, "V") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#W</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of W in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"W"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#W">https://w3id.org/tribont/material#W</seealso>
    let W = Prefixed_Name(tribont_material, "W") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#WC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of WC in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#WC">https://w3id.org/tribont/material#WC</seealso>
    let WC = Prefixed_Name(tribont_material, "WC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Water content of something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Water"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Water">https://w3id.org/tribont/material#Water</seealso>
    let Water = Prefixed_Name(tribont_material, "Water") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Y in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Y"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Y">https://w3id.org/tribont/material#Y</seealso>
    let Y = Prefixed_Name(tribont_material, "Y") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Y203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Y203 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Y203"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Y203">https://w3id.org/tribont/material#Y203</seealso>
    let Y203 = Prefixed_Name(tribont_material, "Y203") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Yb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Yb in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Yb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Yb">https://w3id.org/tribont/material#Yb</seealso>
    let Yb = Prefixed_Name(tribont_material, "Yb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Zn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Zn in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Zn">https://w3id.org/tribont/material#Zn</seealso>
    let Zn = Prefixed_Name(tribont_material, "Zn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#ZnO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of ZnO in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ZnO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ZnO">https://w3id.org/tribont/material#ZnO</seealso>
    let ZnO = Prefixed_Name(tribont_material, "ZnO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#Zr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of Zr in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zr"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#Zr">https://w3id.org/tribont/material#Zr</seealso>
    let Zr = Prefixed_Name(tribont_material, "Zr") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#ZrO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Content of ZrO2 in a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ZrO2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#ZrO2">https://w3id.org/tribont/material#ZrO2</seealso>
    let ZrO2 = Prefixed_Name(tribont_material, "ZrO2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#additive</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/material#ElementRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"additive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#additive">https://w3id.org/tribont/material#additive</seealso>
    let additive = Prefixed_Name(tribont_material, "additive") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#basic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/material#ElementRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"basic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#basic">https://w3id.org/tribont/material#basic</seealso>
    let basic = Prefixed_Name(tribont_material, "basic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#filler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/material#ElementRole</para>
    ///
    /// labels<para>"filler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#filler">https://w3id.org/tribont/material#filler</seealso>
    let filler = Prefixed_Name(tribont_material, "filler") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#hasElementRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an element and its role,"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasElementRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#hasElementRole">https://w3id.org/tribont/material#hasElementRole</seealso>
    let hasElementRole =
        Prefixed_Name(tribont_material, "hasElementRole") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#hasNaming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between something and the name identifying it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasNaming"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#hasNaming">https://w3id.org/tribont/material#hasNaming</seealso>
    let hasNaming = Prefixed_Name(tribont_material, "hasNaming") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#hasSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a company and what it supplies.."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSupplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#hasSupplier">https://w3id.org/tribont/material#hasSupplier</seealso>
    let hasSupplier = Prefixed_Name(tribont_material, "hasSupplier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#hasTypicalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between something and  its typical application."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTypicalUse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#hasTypicalUse">https://w3id.org/tribont/material#hasTypicalUse</seealso>
    let hasTypicalUse = Prefixed_Name(tribont_material, "hasTypicalUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#isElementRoleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a role and the  element to which it applies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isElementRoleFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#isElementRoleFor">https://w3id.org/tribont/material#isElementRoleFor</seealso>
    let isElementRoleFor =
        Prefixed_Name(tribont_material, "isElementRoleFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#isNamingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a name and what it identifies.."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isNamingFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#isNamingFor">https://w3id.org/tribont/material#isNamingFor</seealso>
    let isNamingFor = Prefixed_Name(tribont_material, "isNamingFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/material#isSuppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between something and the company supplying it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isSuppliedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#isSuppliedBy">https://w3id.org/tribont/material#isSuppliedBy</seealso>
    let isSuppliedBy = Prefixed_Name(tribont_material, "isSuppliedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#isTypicalUseFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an application and what it is usually applied to,"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isTypicalUseFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#isTypicalUseFor">https://w3id.org/tribont/material#isTypicalUseFor</seealso>
    let isTypicalUseFor =
        Prefixed_Name(tribont_material, "isTypicalUseFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/material#number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defined number for the unique designation of materials."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/material#number">https://w3id.org/tribont/material#number</seealso>
    let number = Prefixed_Name(tribont_material, "number") |> PrefixedName
