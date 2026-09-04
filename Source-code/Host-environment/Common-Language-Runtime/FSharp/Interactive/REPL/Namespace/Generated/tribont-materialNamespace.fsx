#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``tribont-material`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/tribont/material#" "tribont-material"

    let AISI_52100 = _prefixId.prefix "AISI_52100"
    let ASTM_A295 = _prefixId.prefix "ASTM_A295"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ag^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ag in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ag">tribont-material:Ag</a>
    /// </summary>
    let Ag = _prefixId.prefix "Ag"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Al^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Al in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Al">tribont-material:Al</a>
    /// </summary>
    let Al = _prefixId.prefix "Al"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Al203^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Al203 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Al203">tribont-material:Al203</a>
    /// </summary>
    let Al203 = _prefixId.prefix "Al203"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AlN^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of AlN in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#AlN">tribont-material:AlN</a>
    /// </summary>
    let AlN = _prefixId.prefix "AlN"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Alluminium-Flake^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Alluminium-Flake in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Alluminium-Flake">tribont-material:Alluminium-Flake</a>
    /// </summary>
    let Alluminium_Flake = _prefixId.prefix "Alluminium-Flake"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AlluminiumAlloy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Alluminium alloy.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#AlluminiumAlloy">tribont-material:AlluminiumAlloy</a>
    /// </summary>
    let AlluminiumAlloy = _prefixId.prefix "AlluminiumAlloy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Anti-friction/wearLubricant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Anti-friction/wearLubricant in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#AntifrictionLubricant">tribont-material:AntifrictionLubricant</a>
    /// </summary>
    let AntifrictionLubricant = _prefixId.prefix "AntifrictionLubricant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Antioxidant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Antioxidant content for something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Antioxidant">tribont-material:Antioxidant</a>
    /// </summary>
    let Antioxidant = _prefixId.prefix "Antioxidant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Aramid-Fiber^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Aramid-Fiber in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Aramid-Fiber">tribont-material:Aramid-Fiber</a>
    /// </summary>
    let Aramid_Fiber = _prefixId.prefix "Aramid-Fiber"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ArsenicOxide^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of ArsenicOxide in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ArsenicOxide">tribont-material:ArsenicOxide</a>
    /// </summary>
    let ArsenicOxide = _prefixId.prefix "ArsenicOxide"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : As^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of As in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#As">tribont-material:As</a>
    /// </summary>
    let As = _prefixId.prefix "As"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Au^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Au in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Au">tribont-material:Au</a>
    /// </summary>
    let Au = _prefixId.prefix "Au"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : B^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of B in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#B">tribont-material:B</a>
    /// </summary>
    let B = _prefixId.prefix "B"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : B203^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of B203 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#B203">tribont-material:B203</a>
    /// </summary>
    let B203 = _prefixId.prefix "B203"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : B4C^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of B4C in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#B4C">tribont-material:B4C</a>
    /// </summary>
    let B4C = _prefixId.prefix "B4C"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : BN^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of BN in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#BN">tribont-material:BN</a>
    /// </summary>
    let BN = _prefixId.prefix "BN"
    let BS_970 = _prefixId.prefix "BS_970"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : BaO^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of BaO in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#BaO">tribont-material:BaO</a>
    /// </summary>
    let BaO = _prefixId.prefix "BaO"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : BaSO4^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of BaSO4 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#BaSO4">tribont-material:BaSO4</a>
    /// </summary>
    let BaSO4 = _prefixId.prefix "BaSO4"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Be^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Be in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Be">tribont-material:Be</a>
    /// </summary>
    let Be = _prefixId.prefix "Be"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : BeO^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of BeO in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#BeO">tribont-material:BeO</a>
    /// </summary>
    let BeO = _prefixId.prefix "BeO"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Bi^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Biin a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Bi">tribont-material:Bi</a>
    /// </summary>
    let Bi = _prefixId.prefix "Bi"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : C^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of C in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#C">tribont-material:C</a>
    /// </summary>
    let C = _prefixId.prefix "C"
    let CAS_Number = _prefixId.prefix "CAS_Number"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ca^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ca in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ca">tribont-material:Ca</a>
    /// </summary>
    let Ca = _prefixId.prefix "Ca"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CaCO3^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of CaCO3 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#CaCO3">tribont-material:CaCO3</a>
    /// </summary>
    let CaCO3 = _prefixId.prefix "CaCO3"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CaO^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of CaO in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#CaO">tribont-material:CaO</a>
    /// </summary>
    let CaO = _prefixId.prefix "CaO"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CalciumCarbonate-Powder^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of CalciumCarbonate-Powder in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#CalciumCarbonate-Powder">tribont-material:CalciumCarbonate-Powder</a>
    /// </summary>
    let CalciumCarbonate_Powder = _prefixId.prefix "CalciumCarbonate-Powder"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Carbon-Fiber^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Carbon-Fiber in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Carbon-Fiber">tribont-material:Carbon-Fiber</a>
    /// </summary>
    let Carbon_Fiber = _prefixId.prefix "Carbon-Fiber"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Carbon-Powder^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Carbon-Powder in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Carbon-Powder">tribont-material:Carbon-Powder</a>
    /// </summary>
    let Carbon_Powder = _prefixId.prefix "Carbon-Powder"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Cd^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Cd in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Cd">tribont-material:Cd</a>
    /// </summary>
    let Cd = _prefixId.prefix "Cd"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CdS^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of CdS in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#CdS">tribont-material:CdS</a>
    /// </summary>
    let CdS = _prefixId.prefix "CdS"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ce^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ce in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ce">tribont-material:Ce</a>
    /// </summary>
    let Ce = _prefixId.prefix "Ce"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Cellulose^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Cellulose in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Cellulose">tribont-material:Cellulose</a>
    /// </summary>
    let Cellulose = _prefixId.prefix "Cellulose"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CeramicMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Ceramic material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#CeramicMaterial">tribont-material:CeramicMaterial</a>
    /// </summary>
    let CeramicMaterial = _prefixId.prefix "CeramicMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ChemicalElementConcentration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Concentration of chemical element in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ChemicalElementConcentration">tribont-material:ChemicalElementConcentration</a>
    /// </summary>
    let ChemicalElementConcentration = _prefixId.prefix "ChemicalElementConcentration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Co^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Co in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Co">tribont-material:Co</a>
    /// </summary>
    let Co = _prefixId.prefix "Co"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CompositeMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Composite material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#CompositeMaterial">tribont-material:CompositeMaterial</a>
    /// </summary>
    let CompositeMaterial = _prefixId.prefix "CompositeMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Cr^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Cr in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Cr">tribont-material:Cr</a>
    /// </summary>
    let Cr = _prefixId.prefix "Cr"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Cr203^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Cr203 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Cr203">tribont-material:Cr203</a>
    /// </summary>
    let Cr203 = _prefixId.prefix "Cr203"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Cu^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Cu in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Cu">tribont-material:Cu</a>
    /// </summary>
    let Cu = _prefixId.prefix "Cu"
    let DIN_17230 = _prefixId.prefix "DIN_17230"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Dy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Dy in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Dy">tribont-material:Dy</a>
    /// </summary>
    let Dy = _prefixId.prefix "Dy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElastomerThermoplastic^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Elastomer thermoplastic material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ElastomerThermoplastic">tribont-material:ElastomerThermoplastic</a>
    /// </summary>
    let ElastomerThermoplastic = _prefixId.prefix "ElastomerThermoplastic"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElastomerThermoset^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Elastomer thermoset material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ElastomerThermoset">tribont-material:ElastomerThermoset</a>
    /// </summary>
    let ElastomerThermoset = _prefixId.prefix "ElastomerThermoset"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElementConcentration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Concentration of an specific element in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ElementConcentration">tribont-material:ElementConcentration</a>
    /// </summary>
    let ElementConcentration = _prefixId.prefix "ElementConcentration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElementRole^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : The position or purpose that an element has in a situation or relationship.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ElementRole">tribont-material:ElementRole</a>
    /// </summary>
    let ElementRole = _prefixId.prefix "ElementRole"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Er^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Er in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Er">tribont-material:Er</a>
    /// </summary>
    let Er = _prefixId.prefix "Er"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Eu^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Eu in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Eu">tribont-material:Eu</a>
    /// </summary>
    let Eu = _prefixId.prefix "Eu"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : F^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of F in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#F">tribont-material:F</a>
    /// </summary>
    let F = _prefixId.prefix "F"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Fe^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Fe in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Fe">tribont-material:Fe</a>
    /// </summary>
    let Fe = _prefixId.prefix "Fe"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Fe203^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Fe203 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Fe203">tribont-material:Fe203</a>
    /// </summary>
    let Fe203 = _prefixId.prefix "Fe203"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FlameRetardant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of FlameRetardant in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#FlameRetardant">tribont-material:FlameRetardant</a>
    /// </summary>
    let FlameRetardant = _prefixId.prefix "FlameRetardant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FluidLubricant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Fluid lubricant material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#FluidLubricant">tribont-material:FluidLubricant</a>
    /// </summary>
    let FluidLubricant = _prefixId.prefix "FluidLubricant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Gd^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Gd in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Gd">tribont-material:Gd</a>
    /// </summary>
    let Gd = _prefixId.prefix "Gd"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ge^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ge in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ge">tribont-material:Ge</a>
    /// </summary>
    let Ge = _prefixId.prefix "Ge"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Glass^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Glass material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Glass">tribont-material:Glass</a>
    /// </summary>
    let Glass = _prefixId.prefix "Glass"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Glass-Fiber^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Glass-Fiber in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Glass-Fiber">tribont-material:Glass-Fiber</a>
    /// </summary>
    let Glass_Fiber = _prefixId.prefix "Glass-Fiber"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Glass-MatFabric^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Glass-MatFabric in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Glass-MatFabric">tribont-material:Glass-MatFabric</a>
    /// </summary>
    let Glass_MatFabric = _prefixId.prefix "Glass-MatFabric"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Glycol^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of glycol of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Glycol">tribont-material:Glycol</a>
    /// </summary>
    let Glycol = _prefixId.prefix "Glycol"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Graphite-Powder^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Graphite-Powder in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Graphite-Powder">tribont-material:Graphite-Powder</a>
    /// </summary>
    let Graphite_Powder = _prefixId.prefix "Graphite-Powder"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Grease^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Grease material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Grease">tribont-material:Grease</a>
    /// </summary>
    let Grease = _prefixId.prefix "Grease"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : H^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of H in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#H">tribont-material:H</a>
    /// </summary>
    let H = _prefixId.prefix "H"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : H2O^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of H2O in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#H2O">tribont-material:H2O</a>
    /// </summary>
    let H2O = _prefixId.prefix "H2O"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Hf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Hf in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Hf">tribont-material:Hf</a>
    /// </summary>
    let Hf = _prefixId.prefix "Hf"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Hg^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Hg in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Hg">tribont-material:Hg</a>
    /// </summary>
    let Hg = _prefixId.prefix "Hg"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HighAlloySteel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : High alloy steel material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#HighAlloySteel">tribont-material:HighAlloySteel</a>
    /// </summary>
    let HighAlloySteel = _prefixId.prefix "HighAlloySteel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ho^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ho in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ho">tribont-material:Ho</a>
    /// </summary>
    let Ho = _prefixId.prefix "Ho"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ImpactModifier^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of ImpactModifier in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ImpactModifier">tribont-material:ImpactModifier</a>
    /// </summary>
    let ImpactModifier = _prefixId.prefix "ImpactModifier"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : In^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of In in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#In">tribont-material:In</a>
    /// </summary>
    let In = _prefixId.prefix "In"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ir^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ir in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ir">tribont-material:Ir</a>
    /// </summary>
    let Ir = _prefixId.prefix "Ir"
    let JIS_G4805 = _prefixId.prefix "JIS_G4805"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : La^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of La in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#La">tribont-material:La</a>
    /// </summary>
    let La = _prefixId.prefix "La"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Li^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Li in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Li">tribont-material:Li</a>
    /// </summary>
    let Li = _prefixId.prefix "Li"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Li2O^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Li2O in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Li2O">tribont-material:Li2O</a>
    /// </summary>
    let Li2O = _prefixId.prefix "Li2O"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LiquidMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Liquid material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#LiquidMaterial">tribont-material:LiquidMaterial</a>
    /// </summary>
    let LiquidMaterial = _prefixId.prefix "LiquidMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LowAlloySteel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Low alloy steel material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#LowAlloySteel">tribont-material:LowAlloySteel</a>
    /// </summary>
    let LowAlloySteel = _prefixId.prefix "LowAlloySteel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Lu^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Lu in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Lu">tribont-material:Lu</a>
    /// </summary>
    let Lu = _prefixId.prefix "Lu"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : The basic material from which something is made.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Material">tribont-material:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaterialApplication^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : The possible uses of a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MaterialApplication">tribont-material:MaterialApplication</a>
    /// </summary>
    let MaterialApplication = _prefixId.prefix "MaterialApplication"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaterialIdentification^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : MaterialIdentification^^xsd:string</para>
    ///   <para>rdfs:comment : Something that identifies a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MaterialIdentification">tribont-material:MaterialIdentification</a>
    /// </summary>
    let MaterialIdentification = _prefixId.prefix "MaterialIdentification"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaterialNaming^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : A unique name asssigned to a material independently of the manufacturer.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MaterialNaming">tribont-material:MaterialNaming</a>
    /// </summary>
    let MaterialNaming = _prefixId.prefix "MaterialNaming"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaterialStandard^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : A document approved by a recognized body that provides common to by fullfiled by a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MaterialStandard">tribont-material:MaterialStandard</a>
    /// </summary>
    let MaterialStandard = _prefixId.prefix "MaterialStandard"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaterialTradename^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Commercial name of a material defined by the manufactuer company.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MaterialTradename">tribont-material:MaterialTradename</a>
    /// </summary>
    let MaterialTradename = _prefixId.prefix "MaterialTradename"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MetallicMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Metal and alloy material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MetallicMaterial">tribont-material:MetallicMaterial</a>
    /// </summary>
    let MetallicMaterial = _prefixId.prefix "MetallicMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Mg^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Mg in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Mg">tribont-material:Mg</a>
    /// </summary>
    let Mg = _prefixId.prefix "Mg"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Mica^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Mica in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Mica">tribont-material:Mica</a>
    /// </summary>
    let Mica = _prefixId.prefix "Mica"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Mineral^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Mineral in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Mineral">tribont-material:Mineral</a>
    /// </summary>
    let Mineral = _prefixId.prefix "Mineral"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Mn^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Mn in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Mn">tribont-material:Mn</a>
    /// </summary>
    let Mn = _prefixId.prefix "Mn"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Mo^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Mo in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Mo">tribont-material:Mo</a>
    /// </summary>
    let Mo = _prefixId.prefix "Mo"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MoS2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of MoS2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#MoS2">tribont-material:MoS2</a>
    /// </summary>
    let MoS2 = _prefixId.prefix "MoS2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : N^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of N in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#N">tribont-material:N</a>
    /// </summary>
    let N = _prefixId.prefix "N"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Na2O^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Na2O in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Na2O">tribont-material:Na2O</a>
    /// </summary>
    let Na2O = _prefixId.prefix "Na2O"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : NaCl^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of NaCl in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#NaCl">tribont-material:NaCl</a>
    /// </summary>
    let NaCl = _prefixId.prefix "NaCl"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Nb^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Nb in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Nb">tribont-material:Nb</a>
    /// </summary>
    let Nb = _prefixId.prefix "Nb"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Nd^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Nd in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Nd">tribont-material:Nd</a>
    /// </summary>
    let Nd = _prefixId.prefix "Nd"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ni^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ni in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ni">tribont-material:Ni</a>
    /// </summary>
    let Ni = _prefixId.prefix "Ni"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : NonFerrousMetalInhibitor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Any Non Ferrous Metal Inhibitors Content.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#NonFerrousMetalInhibitor">tribont-material:NonFerrousMetalInhibitor</a>
    /// </summary>
    let NonFerrousMetalInhibitor = _prefixId.prefix "NonFerrousMetalInhibitor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : O^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of O in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#O">tribont-material:O</a>
    /// </summary>
    let O = _prefixId.prefix "O"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : O2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of O2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#O2">tribont-material:O2</a>
    /// </summary>
    let O2 = _prefixId.prefix "O2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Oil^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Oil material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Oil">tribont-material:Oil</a>
    /// </summary>
    let Oil = _prefixId.prefix "Oil"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Os^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Os in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Os">tribont-material:Os</a>
    /// </summary>
    let Os = _prefixId.prefix "Os"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OtherElementConcentration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Concentration  of an additive element in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#OtherElementConcentration">tribont-material:OtherElementConcentration</a>
    /// </summary>
    let OtherElementConcentration = _prefixId.prefix "OtherElementConcentration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : P^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of P in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#P">tribont-material:P</a>
    /// </summary>
    let P = _prefixId.prefix "P"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PTFE-Lubricant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : PTFE-Lubricant material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PTFE-Lubricant">tribont-material:PTFE-Lubricant</a>
    /// </summary>
    let PTFE_Lubricant = _prefixId.prefix "PTFE-Lubricant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Pb^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Pb in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Pb">tribont-material:Pb</a>
    /// </summary>
    let Pb = _prefixId.prefix "Pb"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PbO^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of PbO in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PbO">tribont-material:PbO</a>
    /// </summary>
    let PbO = _prefixId.prefix "PbO"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Pd^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Pd in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Pd">tribont-material:Pd</a>
    /// </summary>
    let Pd = _prefixId.prefix "Pd"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PlasticThermoplastic^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Plastic thermoplastic material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PlasticThermoplastic">tribont-material:PlasticThermoplastic</a>
    /// </summary>
    let PlasticThermoplastic = _prefixId.prefix "PlasticThermoplastic"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PlasticThermoset^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Plastic Thermoset material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PlasticThermoset">tribont-material:PlasticThermoset</a>
    /// </summary>
    let PlasticThermoset = _prefixId.prefix "PlasticThermoset"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Plasticizer/Oil^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Plasticizer/Oil in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PlasticizerOil">tribont-material:PlasticizerOil</a>
    /// </summary>
    let PlasticizerOil = _prefixId.prefix "PlasticizerOil"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PolymerElementConcentration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Concentration of polymer element in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PolymerElementConcentration">tribont-material:PolymerElementConcentration</a>
    /// </summary>
    let PolymerElementConcentration = _prefixId.prefix "PolymerElementConcentration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PolymerMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Any polymer^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#PolymerMaterial">tribont-material:PolymerMaterial</a>
    /// </summary>
    let PolymerMaterial = _prefixId.prefix "PolymerMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Pr^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Pr in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Pr">tribont-material:Pr</a>
    /// </summary>
    let Pr = _prefixId.prefix "Pr"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Pt^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Pt in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Pt">tribont-material:Pt</a>
    /// </summary>
    let Pt = _prefixId.prefix "Pt"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rag-Cotton-Fabric^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Rag-Cotton-Fabric in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Rag-Cotton-Fabric">tribont-material:Rag-Cotton-Fabric</a>
    /// </summary>
    let Rag_Cotton_Fabric = _prefixId.prefix "Rag-Cotton-Fabric"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Re^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Re in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Re">tribont-material:Re</a>
    /// </summary>
    let Re = _prefixId.prefix "Re"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rh^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Rh in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Rh">tribont-material:Rh</a>
    /// </summary>
    let Rh = _prefixId.prefix "Rh"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ru^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ru in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ru">tribont-material:Ru</a>
    /// </summary>
    let Ru = _prefixId.prefix "Ru"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : S^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of S in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#S">tribont-material:S</a>
    /// </summary>
    let S = _prefixId.prefix "S"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sb^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Sb in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Sb">tribont-material:Sb</a>
    /// </summary>
    let Sb = _prefixId.prefix "Sb"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sc^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Sc in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Sc">tribont-material:Sc</a>
    /// </summary>
    let Sc = _prefixId.prefix "Sc"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Se^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Se in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Se">tribont-material:Se</a>
    /// </summary>
    let Se = _prefixId.prefix "Se"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Si^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Si in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Si">tribont-material:Si</a>
    /// </summary>
    let Si = _prefixId.prefix "Si"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Si3N4^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Si3N4 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Si3N4">tribont-material:Si3N4</a>
    /// </summary>
    let Si3N4 = _prefixId.prefix "Si3N4"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SiC^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of SiC in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#SiC">tribont-material:SiC</a>
    /// </summary>
    let SiC = _prefixId.prefix "SiC"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SiO2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of SiO2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#SiO2">tribont-material:SiO2</a>
    /// </summary>
    let SiO2 = _prefixId.prefix "SiO2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Silica-Fumed^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Silica-Fumed in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Silica-Fumed">tribont-material:Silica-Fumed</a>
    /// </summary>
    let Silica_Fumed = _prefixId.prefix "Silica-Fumed"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Silicone-Lubricant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Silicone-Lubricant material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Silicone-Lubricant">tribont-material:Silicone-Lubricant</a>
    /// </summary>
    let Silicone_Lubricant = _prefixId.prefix "Silicone-Lubricant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Sm  in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Sm">tribont-material:Sm</a>
    /// </summary>
    let Sm = _prefixId.prefix "Sm"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sn^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Sn in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Sn">tribont-material:Sn</a>
    /// </summary>
    let Sn = _prefixId.prefix "Sn"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SolidContaminants^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Solid contaminants.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#SolidContaminants">tribont-material:SolidContaminants</a>
    /// </summary>
    let SolidContaminants = _prefixId.prefix "SolidContaminants"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SolidLubricant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Solid lubricant material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#SolidLubricant">tribont-material:SolidLubricant</a>
    /// </summary>
    let SolidLubricant = _prefixId.prefix "SolidLubricant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SolidMaterial^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Solid material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#SolidMaterial">tribont-material:SolidMaterial</a>
    /// </summary>
    let SolidMaterial = _prefixId.prefix "SolidMaterial"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sr^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Sr in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Sr">tribont-material:Sr</a>
    /// </summary>
    let Sr = _prefixId.prefix "Sr"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : StainlessSteel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Stainless steel material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#StainlessSteel">tribont-material:StainlessSteel</a>
    /// </summary>
    let StainlessSteel = _prefixId.prefix "StainlessSteel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : StainlessSteel-Fiber^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of StainlessSteel-Fiber in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#StainlessSteel-Fiber">tribont-material:StainlessSteel-Fiber</a>
    /// </summary>
    let StainlessSteel_Fiber = _prefixId.prefix "StainlessSteel-Fiber"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Steel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Steel material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Steel">tribont-material:Steel</a>
    /// </summary>
    let Steel = _prefixId.prefix "Steel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SulfateAsh^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Sulfate ash .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#SulfateAsh">tribont-material:SulfateAsh</a>
    /// </summary>
    let SulfateAsh = _prefixId.prefix "SulfateAsh"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ta^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ta in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ta">tribont-material:Ta</a>
    /// </summary>
    let Ta = _prefixId.prefix "Ta"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TaC^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of TaC in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#TaC">tribont-material:TaC</a>
    /// </summary>
    let TaC = _prefixId.prefix "TaC"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Talc^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Talc in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Talc">tribont-material:Talc</a>
    /// </summary>
    let Talc = _prefixId.prefix "Talc"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Tb^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Tb in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Tb">tribont-material:Tb</a>
    /// </summary>
    let Tb = _prefixId.prefix "Tb"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Te^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Te in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Te">tribont-material:Te</a>
    /// </summary>
    let Te = _prefixId.prefix "Te"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ThO2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of ThO2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ThO2">tribont-material:ThO2</a>
    /// </summary>
    let ThO2 = _prefixId.prefix "ThO2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ti^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Ti in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Ti">tribont-material:Ti</a>
    /// </summary>
    let Ti = _prefixId.prefix "Ti"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TiB2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of TiB2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#TiB2">tribont-material:TiB2</a>
    /// </summary>
    let TiB2 = _prefixId.prefix "TiB2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TiC^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of TiC in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#TiC">tribont-material:TiC</a>
    /// </summary>
    let TiC = _prefixId.prefix "TiC"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TiO2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of TiO2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#TiO2">tribont-material:TiO2</a>
    /// </summary>
    let TiO2 = _prefixId.prefix "TiO2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TitaniumAlloy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Titanium alloy material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#TitaniumAlloy">tribont-material:TitaniumAlloy</a>
    /// </summary>
    let TitaniumAlloy = _prefixId.prefix "TitaniumAlloy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Tl^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Tl in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Tl">tribont-material:Tl</a>
    /// </summary>
    let Tl = _prefixId.prefix "Tl"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Tm^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Tm in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Tm">tribont-material:Tm</a>
    /// </summary>
    let Tm = _prefixId.prefix "Tm"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Tolyltriazole^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Tolyltriazole concentration^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Tolyltriazole">tribont-material:Tolyltriazole</a>
    /// </summary>
    let Tolyltriazole = _prefixId.prefix "Tolyltriazole"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ToolSteel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Steel used for tooling.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ToolSteel">tribont-material:ToolSteel</a>
    /// </summary>
    let ToolSteel = _prefixId.prefix "ToolSteel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : U^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of U in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#U">tribont-material:U</a>
    /// </summary>
    let U = _prefixId.prefix "U"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : UVStabilizer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of UVStabilizer in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#UVStabilizer">tribont-material:UVStabilizer</a>
    /// </summary>
    let UVStabilizer = _prefixId.prefix "UVStabilizer"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : V^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of V in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#V">tribont-material:V</a>
    /// </summary>
    let V = _prefixId.prefix "V"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : W^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of W in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#W">tribont-material:W</a>
    /// </summary>
    let W = _prefixId.prefix "W"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WC^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of WC in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#WC">tribont-material:WC</a>
    /// </summary>
    let WC = _prefixId.prefix "WC"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Water^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Water content of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Water">tribont-material:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Y^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Y in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Y">tribont-material:Y</a>
    /// </summary>
    let Y = _prefixId.prefix "Y"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Y203^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Y203 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Y203">tribont-material:Y203</a>
    /// </summary>
    let Y203 = _prefixId.prefix "Y203"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Yb^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Yb in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Yb">tribont-material:Yb</a>
    /// </summary>
    let Yb = _prefixId.prefix "Yb"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Zn^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Zn in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Zn">tribont-material:Zn</a>
    /// </summary>
    let Zn = _prefixId.prefix "Zn"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ZnO^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of ZnO in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ZnO">tribont-material:ZnO</a>
    /// </summary>
    let ZnO = _prefixId.prefix "ZnO"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Zr^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of Zr in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#Zr">tribont-material:Zr</a>
    /// </summary>
    let Zr = _prefixId.prefix "Zr"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ZrO2^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Content of ZrO2 in a material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#ZrO2">tribont-material:ZrO2</a>
    /// </summary>
    let ZrO2 = _prefixId.prefix "ZrO2"
    let additive = _prefixId.prefix "additive"
    let basic = _prefixId.prefix "basic"
    let filler = _prefixId.prefix "filler"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasElementRole^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an element and its role,^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#hasElementRole">tribont-material:hasElementRole</a>
    /// </summary>
    let hasElementRole = _prefixId.prefix "hasElementRole"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasNaming^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and the name identifying it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#hasNaming">tribont-material:hasNaming</a>
    /// </summary>
    let hasNaming = _prefixId.prefix "hasNaming"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasSupplier^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a company and what it supplies..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#hasSupplier">tribont-material:hasSupplier</a>
    /// </summary>
    let hasSupplier = _prefixId.prefix "hasSupplier"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasTypicalUse^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and  its typical application.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#hasTypicalUse">tribont-material:hasTypicalUse</a>
    /// </summary>
    let hasTypicalUse = _prefixId.prefix "hasTypicalUse"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isElementRoleFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a role and the  element to which it applies.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#isElementRoleFor">tribont-material:isElementRoleFor</a>
    /// </summary>
    let isElementRoleFor = _prefixId.prefix "isElementRoleFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isNamingFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a name and what it identifies..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#isNamingFor">tribont-material:isNamingFor</a>
    /// </summary>
    let isNamingFor = _prefixId.prefix "isNamingFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isSuppliedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and the company supplying it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#isSuppliedBy">tribont-material:isSuppliedBy</a>
    /// </summary>
    let isSuppliedBy = _prefixId.prefix "isSuppliedBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isTypicalUseFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an application and what it is usually applied to,^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#isTypicalUseFor">tribont-material:isTypicalUseFor</a>
    /// </summary>
    let isTypicalUseFor = _prefixId.prefix "isTypicalUseFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : number^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/material^^xsd:string</para>
    ///   <para>rdfs:comment : Defined number for the unique designation of materials.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/material#number">tribont-material:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
