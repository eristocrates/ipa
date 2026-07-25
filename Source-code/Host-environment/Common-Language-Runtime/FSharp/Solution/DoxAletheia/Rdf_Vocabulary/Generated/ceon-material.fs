namespace http.w3id.org.CEON.ontology.material.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_material =
    let _namespace_iri = Namespace_Iri ceon_material |> NamespaceIRI
    /// <summary>
    ///   <para>ceon-material:Nickel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Nickel is a chemical element with the symbol Ni and atomic number 28.</para>
    /// labels<para>Nickel</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Nickel">http://w3id.org/CEON/ontology/material/Nickel</seealso>
    let Nickel = Prefixed_Name(ceon_material, "Nickel") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Scandium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scandium is a chemical element with the symbol Sc and atomic number 21.</para>
    /// labels<para>Scandium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Scandium">http://w3id.org/CEON/ontology/material/Scandium</seealso>
    let Scandium = Prefixed_Name(ceon_material, "Scandium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Titanium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Titanium is a chemical element with the symbol Ti and atomic number 22.</para>
    /// labels<para>Titanium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Titanium">http://w3id.org/CEON/ontology/material/Titanium</seealso>
    let Titanium = Prefixed_Name(ceon_material, "Titanium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Material as a sub-concept of Matter, can be a substance or a collection of substance which a physical object is composed of.</para>
    /// labels<para>Material</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Material">http://w3id.org/CEON/ontology/material/Material</seealso>
    let Material = Prefixed_Name(ceon_material, "Material") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Cerium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cerium is a chemical element with the symbol Ce and atomic number 58.</para>
    /// labels<para>Cerium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Cerium">http://w3id.org/CEON/ontology/material/Cerium</seealso>
    let Cerium = Prefixed_Name(ceon_material, "Cerium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Iron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Iron is a chemical element with the symbol Fe and atomic number 26.</para>
    /// labels<para>Iron</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Iron">http://w3id.org/CEON/ontology/material/Iron</seealso>
    let Iron = Prefixed_Name(ceon_material, "Iron") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Magnesium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Magnesium is a chemical element with the symbol Mg and atomic number 12.</para>
    /// labels<para>Magnesium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Magnesium">http://w3id.org/CEON/ontology/material/Magnesium</seealso>
    let Magnesium = Prefixed_Name(ceon_material, "Magnesium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Manganese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Manganese is a chemical element with the symbol Mn and atomic number 25.</para>
    /// labels<para>Manganese</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Manganese">http://w3id.org/CEON/ontology/material/Manganese</seealso>
    let Manganese = Prefixed_Name(ceon_material, "Manganese") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:hasChemicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasChemicalEntity intends to represent that a material can have a collection of chemical entities.</para>
    /// labels<para>has chemical entity</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/hasChemicalEntity">http://w3id.org/CEON/ontology/material/hasChemicalEntity</seealso>
    let hasChemicalEntity =
        Prefixed_Name(ceon_material, "hasChemicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:Neodymium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Neodymium is a chemical element with the symbol Nd and atomic number 60.</para>
    /// labels<para>Neodymium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Neodymium">http://w3id.org/CEON/ontology/material/Neodymium</seealso>
    let Neodymium = Prefixed_Name(ceon_material, "Neodymium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Niobium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Niobium is a chemical element with the symbol Nb and atomic number 41.</para>
    /// labels<para>Niobium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Niobium">http://w3id.org/CEON/ontology/material/Niobium</seealso>
    let Niobium = Prefixed_Name(ceon_material, "Niobium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Samarium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Samarium is a chemical element with the symbol Sm and atomic number 62.</para>
    /// labels<para>Samarium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Samarium">http://w3id.org/CEON/ontology/material/Samarium</seealso>
    let Samarium = Prefixed_Name(ceon_material, "Samarium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Thulium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thulium is a chemical element with the symbol Tm and atomic number 69.</para>
    /// labels<para>Thulium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Thulium">http://w3id.org/CEON/ontology/material/Thulium</seealso>
    let Thulium = Prefixed_Name(ceon_material, "Thulium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Ytterbium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Yteerbium is a chemical element with the symbol Yb and atomic number 70.</para>
    /// labels<para>Ytterbium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Ytterbium">http://w3id.org/CEON/ontology/material/Ytterbium</seealso>
    let Ytterbium = Prefixed_Name(ceon_material, "Ytterbium") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:hasMaterialComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>hasMaterialComponent intends to represent that a material can have a collection of components.</para>
    /// labels<para>has material component</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/hasMaterialComponent">http://w3id.org/CEON/ontology/material/hasMaterialComponent</seealso>
    let hasMaterialComponent =
        Prefixed_Name(ceon_material, "hasMaterialComponent") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/">http://w3id.org/CEON/ontology/material/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_material, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:0.4/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/0.4/">http://w3id.org/CEON/ontology/material/0.4/</seealso>
    let ``_0.4/`` = Prefixed_Name(ceon_material, "0.4/") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Aluminum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Aluminum is a chemical element with the symbol Al and atomic number 13.</para>
    /// labels<para>Aluminum</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Aluminum">http://w3id.org/CEON/ontology/material/Aluminum</seealso>
    let Aluminum = Prefixed_Name(ceon_material, "Aluminum") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:ChemicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A chemical element is a chemical substance whose atoms all have the same number of protons.</para>
    /// labels<para>Chemical Element</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/ChemicalElement">http://w3id.org/CEON/ontology/material/ChemicalElement</seealso>
    let ChemicalElement =
        Prefixed_Name(ceon_material, "ChemicalElement") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:Boron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Boron is a chemical element with the symbol B and atomic number 5.</para>
    /// labels<para>Boron</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Boron">http://w3id.org/CEON/ontology/material/Boron</seealso>
    let Boron = Prefixed_Name(ceon_material, "Boron") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Cellulose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cellulose is an organic compound with chemical formula (C6H10O5)n.</para>
    /// labels<para>Cellulose</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Cellulose">http://w3id.org/CEON/ontology/material/Cellulose</seealso>
    let Cellulose = Prefixed_Name(ceon_material, "Cellulose") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:RareEarthElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rare earth elements is a set of 17 nearly indistinguishable lustrous silvery-white soft heavy metals.</para>
    /// labels<para>Rare Earth Element</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/RareEarthElement">http://w3id.org/CEON/ontology/material/RareEarthElement</seealso>
    let RareEarthElement =
        Prefixed_Name(ceon_material, "RareEarthElement") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:ChemicalSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A chemical substance is made up of a collection of molecular entities.</para>
    /// labels<para>Chemical Substance</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/ChemicalSubstance">http://w3id.org/CEON/ontology/material/ChemicalSubstance</seealso>
    let ChemicalSubstance =
        Prefixed_Name(ceon_material, "ChemicalSubstance") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:ChemicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A chemical entity is an abstraction of entities that can compose matter. For instance, a chemical entity can be a molecular entity or a chemical substance.</para>
    /// labels<para>Chemical Entity</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/ChemicalEntity">http://w3id.org/CEON/ontology/material/ChemicalEntity</seealso>
    let ChemicalEntity = Prefixed_Name(ceon_material, "ChemicalEntity") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Chromium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Chromium is a chemical element with the symbol Cr and atomic number 24.</para>
    /// labels<para>Chromium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Chromium">http://w3id.org/CEON/ontology/material/Chromium</seealso>
    let Chromium = Prefixed_Name(ceon_material, "Chromium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Copper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Copper is a chemical element with the symbol Cu and atomic number 29.</para>
    /// labels<para>Copper</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Copper">http://w3id.org/CEON/ontology/material/Copper</seealso>
    let Copper = Prefixed_Name(ceon_material, "Copper") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Dysprosium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dysprosium is a chemical element with the symbol Dy and atomic number 66.</para>
    /// labels<para>Dysorisium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Dysprosium">http://w3id.org/CEON/ontology/material/Dysprosium</seealso>
    let Dysprosium = Prefixed_Name(ceon_material, "Dysprosium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Erbium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Erbium is a chemical element with the symbol Er and atomic number 68.</para>
    /// labels<para>Erbium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Erbium">http://w3id.org/CEON/ontology/material/Erbium</seealso>
    let Erbium = Prefixed_Name(ceon_material, "Erbium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Europium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Europium is a chemical element with the symbol Eu and atomic number 63.</para>
    /// labels<para>Europium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Europium">http://w3id.org/CEON/ontology/material/Europium</seealso>
    let Europium = Prefixed_Name(ceon_material, "Europium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Gadolinium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gadolinium is a chemical element with the symbol Gd and atomic number 64.</para>
    /// labels<para>Gadolinium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Gadolinium">http://w3id.org/CEON/ontology/material/Gadolinium</seealso>
    let Gadolinium = Prefixed_Name(ceon_material, "Gadolinium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Holmium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Holmium is a chemical element with the symbol Ho and atomic number 67.</para>
    /// labels<para>Holmium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Holmium">http://w3id.org/CEON/ontology/material/Holmium</seealso>
    let Holmium = Prefixed_Name(ceon_material, "Holmium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Lanthanum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lanthanum is a chemical element with the symbol Lal and atomic number 57.</para>
    /// labels<para>Lanthanum</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Lanthanum">http://w3id.org/CEON/ontology/material/Lanthanum</seealso>
    let Lanthanum = Prefixed_Name(ceon_material, "Lanthanum") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Lutetium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lutetium is a chemical element with the symbol Lu and atomic number 71.</para>
    /// labels<para>Lutetium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Lutetium">http://w3id.org/CEON/ontology/material/Lutetium</seealso>
    let Lutetium = Prefixed_Name(ceon_material, "Lutetium") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:MaterialComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A material component is a part of a material.</para>
    /// labels<para>Material Component</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/MaterialComponent">http://w3id.org/CEON/ontology/material/MaterialComponent</seealso>
    let MaterialComponent =
        Prefixed_Name(ceon_material, "MaterialComponent") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:MolecularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A molecular entity means a singular/distinguishable entity. It can be for instance, atom, ion.</para>
    /// labels<para>Molecular Entity</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/MolecularEntity">http://w3id.org/CEON/ontology/material/MolecularEntity</seealso>
    let MolecularEntity =
        Prefixed_Name(ceon_material, "MolecularEntity") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:Praseodymium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Praseodymium is a chemical element with the symbol Pr and atomic number 59.</para>
    /// labels<para>Praseodymium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Praseodymium">http://w3id.org/CEON/ontology/material/Praseodymium</seealso>
    let Praseodymium = Prefixed_Name(ceon_material, "Praseodymium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Promethium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Promethium is a chemical element with the symbol Pm and atomic number 61.</para>
    /// labels<para>Promethium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Promethium">http://w3id.org/CEON/ontology/material/Promethium</seealso>
    let Promethium = Prefixed_Name(ceon_material, "Promethium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Silicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Silicon is a chemical element with the symbol Si and atomic number 14.</para>
    /// labels<para>Silicon</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Silicon">http://w3id.org/CEON/ontology/material/Silicon</seealso>
    let Silicon = Prefixed_Name(ceon_material, "Silicon") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Tantalum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tantalum is a chemical element with the symbol Ta and atomic number 73.</para>
    /// labels<para>Tantalum</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Tantalum">http://w3id.org/CEON/ontology/material/Tantalum</seealso>
    let Tantalum = Prefixed_Name(ceon_material, "Tantalum") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Terbium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Terbium is a chemical element with the symbol Tb and atomic number 65.</para>
    /// labels<para>Terbium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Terbium">http://w3id.org/CEON/ontology/material/Terbium</seealso>
    let Terbium = Prefixed_Name(ceon_material, "Terbium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Yttrium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Yttrium is a chemical element with the symbol Y and atomic number 39.</para>
    /// labels<para>Yttrium</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Yttrium">http://w3id.org/CEON/ontology/material/Yttrium</seealso>
    let Yttrium = Prefixed_Name(ceon_material, "Yttrium") |> PrefixedName
    /// <summary>
    ///   <para>ceon-material:Zinc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zinc is a chemical element with the symbol Zn and atomic number 30.</para>
    /// labels<para>Zinc</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Zinc">http://w3id.org/CEON/ontology/material/Zinc</seealso>
    let Zinc = Prefixed_Name(ceon_material, "Zinc") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:anonymousFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>anonymousFormula represents that a molecular entity has the anonymous formula in a string.</para>
    /// labels<para>anonymous formula</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/anonymousFormula">http://w3id.org/CEON/ontology/material/anonymousFormula</seealso>
    let anonymousFormula =
        Prefixed_Name(ceon_material, "anonymousFormula") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:descriptiveFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>descriptiveFormula represents that a molecular entity has the descriptive formula in a string.</para>
    /// labels<para>descriptive formula</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/descriptiveFormula">http://w3id.org/CEON/ontology/material/descriptiveFormula</seealso>
    let descriptiveFormula =
        Prefixed_Name(ceon_material, "descriptiveFormula") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:hillFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>hillFormula represents that a composition has the hill formula in a string.</para>
    /// labels<para>hill formula</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/hillFormula">http://w3id.org/CEON/ontology/material/hillFormula</seealso>
    let hillFormula = Prefixed_Name(ceon_material, "hillFormula") |> PrefixedName

    /// <summary>
    ///   <para>ceon-material:reducedChemicalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>reducedChemicalFormula represents that a molecular entity has the reduced chemical formula in a string.</para>
    /// labels<para>reduced chemical formula</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/reducedChemicalFormula">http://w3id.org/CEON/ontology/material/reducedChemicalFormula</seealso>
    let reducedChemicalFormula =
        Prefixed_Name(ceon_material, "reducedChemicalFormula") |> PrefixedName
