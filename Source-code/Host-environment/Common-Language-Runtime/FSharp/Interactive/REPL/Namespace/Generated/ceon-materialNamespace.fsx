#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-material`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/material/" "ceon-material"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Aluminum^^xsd:string</para>
    ///   <para>rdfs:comment : Aluminum is a chemical element with the symbol Al and atomic number 13.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Aluminum">ceon-material:Aluminum</a>
    /// </summary>
    let Aluminum = _prefixId.prefix "Aluminum"
    /// <summary>
    ///   <para>rdfs:label : Boron^^xsd:string</para>
    ///   <para>rdfs:comment : Boron is a chemical element with the symbol B and atomic number 5.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Boron">ceon-material:Boron</a>
    /// </summary>
    let Boron = _prefixId.prefix "Boron"
    /// <summary>
    ///   <para>rdfs:label : Cellulose^^xsd:string</para>
    ///   <para>rdfs:comment : Cellulose is an organic compound with chemical formula (C6H10O5)n.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Cellulose">ceon-material:Cellulose</a>
    /// </summary>
    let Cellulose = _prefixId.prefix "Cellulose"
    /// <summary>
    ///   <para>rdfs:label : Cerium^^xsd:string</para>
    ///   <para>rdfs:comment : Cerium is a chemical element with the symbol Ce and atomic number 58.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Cerium">ceon-material:Cerium</a>
    /// </summary>
    let Cerium = _prefixId.prefix "Cerium"
    /// <summary>
    ///   <para>rdfs:label : Chemical Element^^xsd:string</para>
    ///   <para>rdfs:comment : A chemical element is a chemical substance whose atoms all have the same number of protons.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/ChemicalElement">ceon-material:ChemicalElement</a>
    /// </summary>
    let ChemicalElement = _prefixId.prefix "ChemicalElement"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://emmo.info/emmo#EMMO_47338839_6cca_4a8e_b565_3c4d5517e2c0^^xsd:stringrdfs:seeAlso : http://purl.obolibrary.org/obo/chebi#24431^^xsd:string</para>
    ///   <para>rdfs:label : Chemical Entity^^xsd:string</para>
    ///   <para>rdfs:comment : A chemical entity is an abstraction of entities that can compose matter. For instance, a chemical entity can be a molecular entity or a chemical substance.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/ChemicalEntity">ceon-material:ChemicalEntity</a>
    /// </summary>
    let ChemicalEntity = _prefixId.prefix "ChemicalEntity"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://emmo.info/emmo#EMMO_df96cbb6_b5ee_4222_8eab_b3675df24bea^^xsd:stringrdfs:seeAlso : http://purl.obolibrary.org/obo/chebi#59999^^xsd:string</para>
    ///   <para>rdfs:label : Chemical Substance^^xsd:string</para>
    ///   <para>rdfs:comment : A chemical substance is made up of a collection of molecular entities.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/ChemicalSubstance">ceon-material:ChemicalSubstance</a>
    /// </summary>
    let ChemicalSubstance = _prefixId.prefix "ChemicalSubstance"
    /// <summary>
    ///   <para>rdfs:label : Chromium^^xsd:string</para>
    ///   <para>rdfs:comment : Chromium is a chemical element with the symbol Cr and atomic number 24.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Chromium">ceon-material:Chromium</a>
    /// </summary>
    let Chromium = _prefixId.prefix "Chromium"
    /// <summary>
    ///   <para>rdfs:label : Copper^^xsd:string</para>
    ///   <para>rdfs:comment : Copper is a chemical element with the symbol Cu and atomic number 29.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Copper">ceon-material:Copper</a>
    /// </summary>
    let Copper = _prefixId.prefix "Copper"
    /// <summary>
    ///   <para>rdfs:label : Dysorisium^^xsd:string</para>
    ///   <para>rdfs:comment : Dysprosium is a chemical element with the symbol Dy and atomic number 66.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Dysprosium">ceon-material:Dysprosium</a>
    /// </summary>
    let Dysprosium = _prefixId.prefix "Dysprosium"
    /// <summary>
    ///   <para>rdfs:label : Erbium^^xsd:string</para>
    ///   <para>rdfs:comment : Erbium is a chemical element with the symbol Er and atomic number 68.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Erbium">ceon-material:Erbium</a>
    /// </summary>
    let Erbium = _prefixId.prefix "Erbium"
    /// <summary>
    ///   <para>rdfs:label : Europium^^xsd:string</para>
    ///   <para>rdfs:comment : Europium is a chemical element with the symbol Eu and atomic number 63.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Europium">ceon-material:Europium</a>
    /// </summary>
    let Europium = _prefixId.prefix "Europium"
    /// <summary>
    ///   <para>rdfs:label : Gadolinium^^xsd:string</para>
    ///   <para>rdfs:comment : Gadolinium is a chemical element with the symbol Gd and atomic number 64.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Gadolinium">ceon-material:Gadolinium</a>
    /// </summary>
    let Gadolinium = _prefixId.prefix "Gadolinium"
    /// <summary>
    ///   <para>rdfs:label : Holmium^^xsd:string</para>
    ///   <para>rdfs:comment : Holmium is a chemical element with the symbol Ho and atomic number 67.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Holmium">ceon-material:Holmium</a>
    /// </summary>
    let Holmium = _prefixId.prefix "Holmium"
    /// <summary>
    ///   <para>rdfs:label : Iron^^xsd:string</para>
    ///   <para>rdfs:comment : Iron is a chemical element with the symbol Fe and atomic number 26.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Iron">ceon-material:Iron</a>
    /// </summary>
    let Iron = _prefixId.prefix "Iron"
    /// <summary>
    ///   <para>rdfs:label : Lanthanum^^xsd:string</para>
    ///   <para>rdfs:comment : Lanthanum is a chemical element with the symbol Lal and atomic number 57.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Lanthanum">ceon-material:Lanthanum</a>
    /// </summary>
    let Lanthanum = _prefixId.prefix "Lanthanum"
    /// <summary>
    ///   <para>rdfs:label : Lutetium^^xsd:string</para>
    ///   <para>rdfs:comment : Lutetium is a chemical element with the symbol Lu and atomic number 71.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Lutetium">ceon-material:Lutetium</a>
    /// </summary>
    let Lutetium = _prefixId.prefix "Lutetium"
    /// <summary>
    ///   <para>rdfs:label : Magnesium^^xsd:string</para>
    ///   <para>rdfs:comment : Magnesium is a chemical element with the symbol Mg and atomic number 12.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Magnesium">ceon-material:Magnesium</a>
    /// </summary>
    let Magnesium = _prefixId.prefix "Magnesium"
    /// <summary>
    ///   <para>rdfs:label : Manganese^^xsd:string</para>
    ///   <para>rdfs:comment : Manganese is a chemical element with the symbol Mn and atomic number 25.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Manganese">ceon-material:Manganese</a>
    /// </summary>
    let Manganese = _prefixId.prefix "Manganese"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://emmo.info/emmo#EMMO_4207e895_8b83_4318_996a_72cfb32acd94^^xsd:stringrdfs:seeAlso : https://w3id.org/mdo/core/Material^^xsd:string</para>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <para>rdfs:comment : Material as a sub-concept of Matter, can be a substance or a collection of substance which a physical object is composed of.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Material">ceon-material:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:label : Material Component^^xsd:string</para>
    ///   <para>rdfs:comment : A material component is a part of a material.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/MaterialComponent">ceon-material:MaterialComponent</a>
    /// </summary>
    let MaterialComponent = _prefixId.prefix "MaterialComponent"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://emmo.info/emmo#EMMO_21205421_5783_4d3e_81e5_10c5d894a88a^^xsd:stringrdfs:seeAlso : http://purl.obolibrary.org/obo/chebi#23367^^xsd:string</para>
    ///   <para>rdfs:label : Molecular Entity^^xsd:string</para>
    ///   <para>rdfs:comment : A molecular entity means a singular/distinguishable entity. It can be for instance, atom, ion.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/MolecularEntity">ceon-material:MolecularEntity</a>
    /// </summary>
    let MolecularEntity = _prefixId.prefix "MolecularEntity"
    /// <summary>
    ///   <para>rdfs:label : Neodymium^^xsd:string</para>
    ///   <para>rdfs:comment : Neodymium is a chemical element with the symbol Nd and atomic number 60.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Neodymium">ceon-material:Neodymium</a>
    /// </summary>
    let Neodymium = _prefixId.prefix "Neodymium"
    /// <summary>
    ///   <para>rdfs:label : Nickel^^xsd:string</para>
    ///   <para>rdfs:comment : Nickel is a chemical element with the symbol Ni and atomic number 28.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Nickel">ceon-material:Nickel</a>
    /// </summary>
    let Nickel = _prefixId.prefix "Nickel"
    /// <summary>
    ///   <para>rdfs:label : Niobium^^xsd:string</para>
    ///   <para>rdfs:comment : Niobium is a chemical element with the symbol Nb and atomic number 41.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Niobium">ceon-material:Niobium</a>
    /// </summary>
    let Niobium = _prefixId.prefix "Niobium"
    /// <summary>
    ///   <para>rdfs:label : Praseodymium^^xsd:string</para>
    ///   <para>rdfs:comment : Praseodymium is a chemical element with the symbol Pr and atomic number 59.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Praseodymium">ceon-material:Praseodymium</a>
    /// </summary>
    let Praseodymium = _prefixId.prefix "Praseodymium"
    /// <summary>
    ///   <para>rdfs:label : Promethium^^xsd:string</para>
    ///   <para>rdfs:comment : Promethium is a chemical element with the symbol Pm and atomic number 61.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Promethium">ceon-material:Promethium</a>
    /// </summary>
    let Promethium = _prefixId.prefix "Promethium"
    /// <summary>
    ///   <para>rdfs:label : Rare Earth Element^^xsd:string</para>
    ///   <para>rdfs:comment : Rare earth elements is a set of 17 nearly indistinguishable lustrous silvery-white soft heavy metals.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/RareEarthElement">ceon-material:RareEarthElement</a>
    /// </summary>
    let RareEarthElement = _prefixId.prefix "RareEarthElement"
    /// <summary>
    ///   <para>rdfs:label : Samarium^^xsd:string</para>
    ///   <para>rdfs:comment : Samarium is a chemical element with the symbol Sm and atomic number 62.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Samarium">ceon-material:Samarium</a>
    /// </summary>
    let Samarium = _prefixId.prefix "Samarium"
    /// <summary>
    ///   <para>rdfs:label : Scandium^^xsd:string</para>
    ///   <para>rdfs:comment : Scandium is a chemical element with the symbol Sc and atomic number 21.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Scandium">ceon-material:Scandium</a>
    /// </summary>
    let Scandium = _prefixId.prefix "Scandium"
    /// <summary>
    ///   <para>rdfs:label : Silicon^^xsd:string</para>
    ///   <para>rdfs:comment : Silicon is a chemical element with the symbol Si and atomic number 14.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Silicon">ceon-material:Silicon</a>
    /// </summary>
    let Silicon = _prefixId.prefix "Silicon"
    /// <summary>
    ///   <para>rdfs:label : Tantalum^^xsd:string</para>
    ///   <para>rdfs:comment : Tantalum is a chemical element with the symbol Ta and atomic number 73.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Tantalum">ceon-material:Tantalum</a>
    /// </summary>
    let Tantalum = _prefixId.prefix "Tantalum"
    /// <summary>
    ///   <para>rdfs:label : Terbium^^xsd:string</para>
    ///   <para>rdfs:comment : Terbium is a chemical element with the symbol Tb and atomic number 65.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Terbium">ceon-material:Terbium</a>
    /// </summary>
    let Terbium = _prefixId.prefix "Terbium"
    /// <summary>
    ///   <para>rdfs:label : Thulium^^xsd:string</para>
    ///   <para>rdfs:comment : Thulium is a chemical element with the symbol Tm and atomic number 69.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Thulium">ceon-material:Thulium</a>
    /// </summary>
    let Thulium = _prefixId.prefix "Thulium"
    /// <summary>
    ///   <para>rdfs:label : Titanium^^xsd:string</para>
    ///   <para>rdfs:comment : Titanium is a chemical element with the symbol Ti and atomic number 22.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Titanium">ceon-material:Titanium</a>
    /// </summary>
    let Titanium = _prefixId.prefix "Titanium"
    /// <summary>
    ///   <para>rdfs:label : Ytterbium^^xsd:string</para>
    ///   <para>rdfs:comment : Yteerbium is a chemical element with the symbol Yb and atomic number 70.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Ytterbium">ceon-material:Ytterbium</a>
    /// </summary>
    let Ytterbium = _prefixId.prefix "Ytterbium"
    /// <summary>
    ///   <para>rdfs:label : Yttrium^^xsd:string</para>
    ///   <para>rdfs:comment : Yttrium is a chemical element with the symbol Y and atomic number 39.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Yttrium">ceon-material:Yttrium</a>
    /// </summary>
    let Yttrium = _prefixId.prefix "Yttrium"
    /// <summary>
    ///   <para>rdfs:label : Zinc^^xsd:string</para>
    ///   <para>rdfs:comment : Zinc is a chemical element with the symbol Zn and atomic number 30.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/Zinc">ceon-material:Zinc</a>
    /// </summary>
    let Zinc = _prefixId.prefix "Zinc"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/mdo/structure/AnonymousFormula^^xsd:string</para>
    ///   <para>rdfs:label : anonymous formula^^xsd:string</para>
    ///   <para>rdfs:comment : anonymousFormula represents that a molecular entity has the anonymous formula in a string.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/anonymousFormula">ceon-material:anonymousFormula</a>
    /// </summary>
    let anonymousFormula = _prefixId.prefix "anonymousFormula"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/mdo/structure/DescriptiveFormula^^xsd:string</para>
    ///   <para>rdfs:label : descriptive formula^^xsd:string</para>
    ///   <para>rdfs:comment : descriptiveFormula represents that a molecular entity has the descriptive formula in a string.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/descriptiveFormula">ceon-material:descriptiveFormula</a>
    /// </summary>
    let descriptiveFormula = _prefixId.prefix "descriptiveFormula"
    /// <summary>
    ///   <para>rdfs:label : has chemical entity^^xsd:string</para>
    ///   <para>rdfs:comment : hasChemicalEntity intends to represent that a material can have a collection of chemical entities.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/hasChemicalEntity">ceon-material:hasChemicalEntity</a>
    /// </summary>
    let hasChemicalEntity = _prefixId.prefix "hasChemicalEntity"
    /// <summary>
    ///   <para>rdfs:label : has material component^^xsd:string</para>
    ///   <para>rdfs:comment : hasMaterialComponent intends to represent that a material can have a collection of components.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/hasMaterialComponent">ceon-material:hasMaterialComponent</a>
    /// </summary>
    let hasMaterialComponent = _prefixId.prefix "hasMaterialComponent"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/mdo/structure/HillFormula^^xsd:string</para>
    ///   <para>rdfs:label : hill formula^^xsd:string</para>
    ///   <para>rdfs:comment : hillFormula represents that a composition has the hill formula in a string.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/hillFormula">ceon-material:hillFormula</a>
    /// </summary>
    let hillFormula = _prefixId.prefix "hillFormula"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/mdo/structure/ReducedFormula^^xsd:string</para>
    ///   <para>rdfs:label : reduced chemical formula^^xsd:string</para>
    ///   <para>rdfs:comment : reducedChemicalFormula represents that a molecular entity has the reduced chemical formula in a string.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/material/reducedChemicalFormula">ceon-material:reducedChemicalFormula</a>
    /// </summary>
    let reducedChemicalFormula = _prefixId.prefix "reducedChemicalFormula"
