namespace http.w3id.org.CEON.ontology.material.slash

open DoxAletheia

module ceon_material =
    let _namespace_name = "http://w3id.org/CEON/ontology/material/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/material/0.4/"></see>
    /// </summary>
    let ``_0.4/`` = _prefix "0.4/"
    /// <summary>
    /// Aluminum is a chemical element with the symbol Al and atomic number 13.
    /// <see href="http://w3id.org/CEON/ontology/material/Aluminum"></see></summary>
    let Aluminum = _prefix "Aluminum"
    /// <summary>
    /// A chemical element is a chemical substance whose atoms all have the same number of protons.
    /// <see href="http://w3id.org/CEON/ontology/material/ChemicalElement"></see></summary>
    let ChemicalElement = _prefix "ChemicalElement"
    /// <summary>
    /// Boron is a chemical element with the symbol B and atomic number 5.
    /// <see href="http://w3id.org/CEON/ontology/material/Boron"></see></summary>
    let Boron = _prefix "Boron"
    /// <summary>
    /// Cellulose is an organic compound with chemical formula (C6H10O5)n.
    /// <see href="http://w3id.org/CEON/ontology/material/Cellulose"></see></summary>
    let Cellulose = _prefix "Cellulose"
    /// <summary>
    /// Material as a sub-concept of Matter, can be a substance or a collection of substance which a physical object is composed of.
    /// <see href="http://w3id.org/CEON/ontology/material/Material"></see></summary>
    let Material = _prefix "Material"
    /// <summary>
    /// Cerium is a chemical element with the symbol Ce and atomic number 58.
    /// <see href="http://w3id.org/CEON/ontology/material/Cerium"></see></summary>
    let Cerium = _prefix "Cerium"
    /// <summary>
    /// Rare earth elements is a set of 17 nearly indistinguishable lustrous silvery-white soft heavy metals.
    /// <see href="http://w3id.org/CEON/ontology/material/RareEarthElement"></see></summary>
    let RareEarthElement = _prefix "RareEarthElement"
    /// <summary>
    /// A chemical substance is made up of a collection of molecular entities.
    /// <see href="http://w3id.org/CEON/ontology/material/ChemicalSubstance"></see></summary>
    let ChemicalSubstance = _prefix "ChemicalSubstance"
    /// <summary>
    /// A chemical entity is an abstraction of entities that can compose matter. For instance, a chemical entity can be a molecular entity or a chemical substance.
    /// <see href="http://w3id.org/CEON/ontology/material/ChemicalEntity"></see></summary>
    let ChemicalEntity = _prefix "ChemicalEntity"
    /// <summary>
    /// Chromium is a chemical element with the symbol Cr and atomic number 24.
    /// <see href="http://w3id.org/CEON/ontology/material/Chromium"></see></summary>
    let Chromium = _prefix "Chromium"
    /// <summary>
    /// Copper is a chemical element with the symbol Cu and atomic number 29.
    /// <see href="http://w3id.org/CEON/ontology/material/Copper"></see></summary>
    let Copper = _prefix "Copper"
    /// <summary>
    /// Dysprosium is a chemical element with the symbol Dy and atomic number 66.
    /// <see href="http://w3id.org/CEON/ontology/material/Dysprosium"></see></summary>
    let Dysprosium = _prefix "Dysprosium"
    /// <summary>
    /// Erbium is a chemical element with the symbol Er and atomic number 68.
    /// <see href="http://w3id.org/CEON/ontology/material/Erbium"></see></summary>
    let Erbium = _prefix "Erbium"
    /// <summary>
    /// Europium is a chemical element with the symbol Eu and atomic number 63.
    /// <see href="http://w3id.org/CEON/ontology/material/Europium"></see></summary>
    let Europium = _prefix "Europium"
    /// <summary>
    /// Gadolinium is a chemical element with the symbol Gd and atomic number 64.
    /// <see href="http://w3id.org/CEON/ontology/material/Gadolinium"></see></summary>
    let Gadolinium = _prefix "Gadolinium"
    /// <summary>
    /// Holmium is a chemical element with the symbol Ho and atomic number 67.
    /// <see href="http://w3id.org/CEON/ontology/material/Holmium"></see></summary>
    let Holmium = _prefix "Holmium"
    /// <summary>
    /// Iron is a chemical element with the symbol Fe and atomic number 26.
    /// <see href="http://w3id.org/CEON/ontology/material/Iron"></see></summary>
    let Iron = _prefix "Iron"
    /// <summary>
    /// Lanthanum is a chemical element with the symbol Lal and atomic number 57.
    /// <see href="http://w3id.org/CEON/ontology/material/Lanthanum"></see></summary>
    let Lanthanum = _prefix "Lanthanum"
    /// <summary>
    /// Lutetium is a chemical element with the symbol Lu and atomic number 71.
    /// <see href="http://w3id.org/CEON/ontology/material/Lutetium"></see></summary>
    let Lutetium = _prefix "Lutetium"
    /// <summary>
    /// Magnesium is a chemical element with the symbol Mg and atomic number 12.
    /// <see href="http://w3id.org/CEON/ontology/material/Magnesium"></see></summary>
    let Magnesium = _prefix "Magnesium"
    /// <summary>
    /// Manganese is a chemical element with the symbol Mn and atomic number 25.
    /// <see href="http://w3id.org/CEON/ontology/material/Manganese"></see></summary>
    let Manganese = _prefix "Manganese"
    /// <summary>
    /// hasChemicalEntity intends to represent that a material can have a collection of chemical entities.
    /// <see href="http://w3id.org/CEON/ontology/material/hasChemicalEntity"></see></summary>
    let hasChemicalEntity = _prefix "hasChemicalEntity"
    /// <summary>
    /// A material component is a part of a material.
    /// <see href="http://w3id.org/CEON/ontology/material/MaterialComponent"></see></summary>
    let MaterialComponent = _prefix "MaterialComponent"
    /// <summary>
    /// A molecular entity means a singular/distinguishable entity. It can be for instance, atom, ion.
    /// <see href="http://w3id.org/CEON/ontology/material/MolecularEntity"></see></summary>
    let MolecularEntity = _prefix "MolecularEntity"
    /// <summary>
    /// Neodymium is a chemical element with the symbol Nd and atomic number 60.
    /// <see href="http://w3id.org/CEON/ontology/material/Neodymium"></see></summary>
    let Neodymium = _prefix "Neodymium"
    /// <summary>
    /// Nickel is a chemical element with the symbol Ni and atomic number 28.
    /// <see href="http://w3id.org/CEON/ontology/material/Nickel"></see></summary>
    let Nickel = _prefix "Nickel"
    /// <summary>
    /// Niobium is a chemical element with the symbol Nb and atomic number 41.
    /// <see href="http://w3id.org/CEON/ontology/material/Niobium"></see></summary>
    let Niobium = _prefix "Niobium"
    /// <summary>
    /// Praseodymium is a chemical element with the symbol Pr and atomic number 59.
    /// <see href="http://w3id.org/CEON/ontology/material/Praseodymium"></see></summary>
    let Praseodymium = _prefix "Praseodymium"
    /// <summary>
    /// Promethium is a chemical element with the symbol Pm and atomic number 61.
    /// <see href="http://w3id.org/CEON/ontology/material/Promethium"></see></summary>
    let Promethium = _prefix "Promethium"
    /// <summary>
    /// Samarium is a chemical element with the symbol Sm and atomic number 62.
    /// <see href="http://w3id.org/CEON/ontology/material/Samarium"></see></summary>
    let Samarium = _prefix "Samarium"
    /// <summary>
    /// Scandium is a chemical element with the symbol Sc and atomic number 21.
    /// <see href="http://w3id.org/CEON/ontology/material/Scandium"></see></summary>
    let Scandium = _prefix "Scandium"
    /// <summary>
    /// Silicon is a chemical element with the symbol Si and atomic number 14.
    /// <see href="http://w3id.org/CEON/ontology/material/Silicon"></see></summary>
    let Silicon = _prefix "Silicon"
    /// <summary>
    /// Tantalum is a chemical element with the symbol Ta and atomic number 73.
    /// <see href="http://w3id.org/CEON/ontology/material/Tantalum"></see></summary>
    let Tantalum = _prefix "Tantalum"
    /// <summary>
    /// Terbium is a chemical element with the symbol Tb and atomic number 65.
    /// <see href="http://w3id.org/CEON/ontology/material/Terbium"></see></summary>
    let Terbium = _prefix "Terbium"
    /// <summary>
    /// Thulium is a chemical element with the symbol Tm and atomic number 69.
    /// <see href="http://w3id.org/CEON/ontology/material/Thulium"></see></summary>
    let Thulium = _prefix "Thulium"
    /// <summary>
    /// Titanium is a chemical element with the symbol Ti and atomic number 22.
    /// <see href="http://w3id.org/CEON/ontology/material/Titanium"></see></summary>
    let Titanium = _prefix "Titanium"
    /// <summary>
    /// Yteerbium is a chemical element with the symbol Yb and atomic number 70.
    /// <see href="http://w3id.org/CEON/ontology/material/Ytterbium"></see></summary>
    let Ytterbium = _prefix "Ytterbium"
    /// <summary>
    /// Yttrium is a chemical element with the symbol Y and atomic number 39.
    /// <see href="http://w3id.org/CEON/ontology/material/Yttrium"></see></summary>
    let Yttrium = _prefix "Yttrium"
    /// <summary>
    /// Zinc is a chemical element with the symbol Zn and atomic number 30.
    /// <see href="http://w3id.org/CEON/ontology/material/Zinc"></see></summary>
    let Zinc = _prefix "Zinc"
    /// <summary>
    /// anonymousFormula represents that a molecular entity has the anonymous formula in a string.
    /// <see href="http://w3id.org/CEON/ontology/material/anonymousFormula"></see></summary>
    let anonymousFormula = _prefix "anonymousFormula"
    /// <summary>
    /// descriptiveFormula represents that a molecular entity has the descriptive formula in a string.
    /// <see href="http://w3id.org/CEON/ontology/material/descriptiveFormula"></see></summary>
    let descriptiveFormula = _prefix "descriptiveFormula"
    /// <summary>
    /// hasMaterialComponent intends to represent that a material can have a collection of components.
    /// <see href="http://w3id.org/CEON/ontology/material/hasMaterialComponent"></see></summary>
    let hasMaterialComponent = _prefix "hasMaterialComponent"
    /// <summary>
    /// hillFormula represents that a composition has the hill formula in a string.
    /// <see href="http://w3id.org/CEON/ontology/material/hillFormula"></see></summary>
    let hillFormula = _prefix "hillFormula"
    /// <summary>
    /// reducedChemicalFormula represents that a molecular entity has the reduced chemical formula in a string.
    /// <see href="http://w3id.org/CEON/ontology/material/reducedChemicalFormula"></see></summary>
    let reducedChemicalFormula = _prefix "reducedChemicalFormula"
