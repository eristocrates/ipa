namespace http.w3id.org.CEON.ontology.material.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_material =
    let _namespace_iri = Namespace_Iri ceon_material |> NamespaceIRI
    /// <summary>
    ///   <para>ceon:ontology/material/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/">http://w3id.org/CEON/ontology/material/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_material, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/0.4/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/0.4/">http://w3id.org/CEON/ontology/material/0.4/</seealso>
    let ``_0.4/`` = Prefixed_Name(ceon_material, "0.4/") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Aluminum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Aluminum is a chemical element with the symbol Al and atomic number 13."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aluminum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Aluminum">http://w3id.org/CEON/ontology/material/Aluminum</seealso>
    let Aluminum = Prefixed_Name(ceon_material, "Aluminum") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Boron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Boron is a chemical element with the symbol B and atomic number 5."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boron"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Boron">http://w3id.org/CEON/ontology/material/Boron</seealso>
    let Boron = Prefixed_Name(ceon_material, "Boron") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Cellulose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cellulose is an organic compound with chemical formula (C6H10O5)n."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cellulose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Cellulose">http://w3id.org/CEON/ontology/material/Cellulose</seealso>
    let Cellulose = Prefixed_Name(ceon_material, "Cellulose") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Cerium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cerium is a chemical element with the symbol Ce and atomic number 58."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cerium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Cerium">http://w3id.org/CEON/ontology/material/Cerium</seealso>
    let Cerium = Prefixed_Name(ceon_material, "Cerium") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/ChemicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chemical element is a chemical substance whose atoms all have the same number of protons."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemical Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/ChemicalElement">http://w3id.org/CEON/ontology/material/ChemicalElement</seealso>
    let ChemicalElement =
        Prefixed_Name(ceon_material, "ChemicalElement") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/ChemicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chemical entity is an abstraction of entities that can compose matter. For instance, a chemical entity can be a molecular entity or a chemical substance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemical Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/ChemicalEntity">http://w3id.org/CEON/ontology/material/ChemicalEntity</seealso>
    let ChemicalEntity = Prefixed_Name(ceon_material, "ChemicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/ChemicalSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chemical substance is made up of a collection of molecular entities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemical Substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/ChemicalSubstance">http://w3id.org/CEON/ontology/material/ChemicalSubstance</seealso>
    let ChemicalSubstance =
        Prefixed_Name(ceon_material, "ChemicalSubstance") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/Chromium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chromium is a chemical element with the symbol Cr and atomic number 24."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chromium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Chromium">http://w3id.org/CEON/ontology/material/Chromium</seealso>
    let Chromium = Prefixed_Name(ceon_material, "Chromium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Copper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Copper is a chemical element with the symbol Cu and atomic number 29."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Copper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Copper">http://w3id.org/CEON/ontology/material/Copper</seealso>
    let Copper = Prefixed_Name(ceon_material, "Copper") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Dysprosium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dysprosium is a chemical element with the symbol Dy and atomic number 66."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dysorisium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Dysprosium">http://w3id.org/CEON/ontology/material/Dysprosium</seealso>
    let Dysprosium = Prefixed_Name(ceon_material, "Dysprosium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Erbium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Erbium is a chemical element with the symbol Er and atomic number 68."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Erbium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Erbium">http://w3id.org/CEON/ontology/material/Erbium</seealso>
    let Erbium = Prefixed_Name(ceon_material, "Erbium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Europium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Europium is a chemical element with the symbol Eu and atomic number 63."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Europium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Europium">http://w3id.org/CEON/ontology/material/Europium</seealso>
    let Europium = Prefixed_Name(ceon_material, "Europium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Gadolinium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gadolinium is a chemical element with the symbol Gd and atomic number 64."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gadolinium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Gadolinium">http://w3id.org/CEON/ontology/material/Gadolinium</seealso>
    let Gadolinium = Prefixed_Name(ceon_material, "Gadolinium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Holmium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Holmium is a chemical element with the symbol Ho and atomic number 67."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Holmium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Holmium">http://w3id.org/CEON/ontology/material/Holmium</seealso>
    let Holmium = Prefixed_Name(ceon_material, "Holmium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Iron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Iron is a chemical element with the symbol Fe and atomic number 26."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Iron"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Iron">http://w3id.org/CEON/ontology/material/Iron</seealso>
    let Iron = Prefixed_Name(ceon_material, "Iron") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Lanthanum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lanthanum is a chemical element with the symbol Lal and atomic number 57."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lanthanum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Lanthanum">http://w3id.org/CEON/ontology/material/Lanthanum</seealso>
    let Lanthanum = Prefixed_Name(ceon_material, "Lanthanum") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Lutetium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lutetium is a chemical element with the symbol Lu and atomic number 71."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lutetium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Lutetium">http://w3id.org/CEON/ontology/material/Lutetium</seealso>
    let Lutetium = Prefixed_Name(ceon_material, "Lutetium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Magnesium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Magnesium is a chemical element with the symbol Mg and atomic number 12."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Magnesium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Magnesium">http://w3id.org/CEON/ontology/material/Magnesium</seealso>
    let Magnesium = Prefixed_Name(ceon_material, "Magnesium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Manganese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Manganese is a chemical element with the symbol Mn and atomic number 25."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Manganese"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Manganese">http://w3id.org/CEON/ontology/material/Manganese</seealso>
    let Manganese = Prefixed_Name(ceon_material, "Manganese") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Material as a sub-concept of Matter, can be a substance or a collection of substance which a physical object is composed of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Material">http://w3id.org/CEON/ontology/material/Material</seealso>
    let Material = Prefixed_Name(ceon_material, "Material") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/MaterialComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A material component is a part of a material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/MaterialComponent">http://w3id.org/CEON/ontology/material/MaterialComponent</seealso>
    let MaterialComponent =
        Prefixed_Name(ceon_material, "MaterialComponent") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/MolecularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A molecular entity means a singular/distinguishable entity. It can be for instance, atom, ion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molecular Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/MolecularEntity">http://w3id.org/CEON/ontology/material/MolecularEntity</seealso>
    let MolecularEntity =
        Prefixed_Name(ceon_material, "MolecularEntity") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/Neodymium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Neodymium is a chemical element with the symbol Nd and atomic number 60."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neodymium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Neodymium">http://w3id.org/CEON/ontology/material/Neodymium</seealso>
    let Neodymium = Prefixed_Name(ceon_material, "Neodymium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Nickel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Nickel is a chemical element with the symbol Ni and atomic number 28."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nickel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Nickel">http://w3id.org/CEON/ontology/material/Nickel</seealso>
    let Nickel = Prefixed_Name(ceon_material, "Nickel") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Niobium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Niobium is a chemical element with the symbol Nb and atomic number 41."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Niobium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Niobium">http://w3id.org/CEON/ontology/material/Niobium</seealso>
    let Niobium = Prefixed_Name(ceon_material, "Niobium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Praseodymium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Praseodymium is a chemical element with the symbol Pr and atomic number 59."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Praseodymium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Praseodymium">http://w3id.org/CEON/ontology/material/Praseodymium</seealso>
    let Praseodymium = Prefixed_Name(ceon_material, "Praseodymium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Promethium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Promethium is a chemical element with the symbol Pm and atomic number 61."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Promethium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Promethium">http://w3id.org/CEON/ontology/material/Promethium</seealso>
    let Promethium = Prefixed_Name(ceon_material, "Promethium") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/RareEarthElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Rare earth elements is a set of 17 nearly indistinguishable lustrous silvery-white soft heavy metals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rare Earth Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/RareEarthElement">http://w3id.org/CEON/ontology/material/RareEarthElement</seealso>
    let RareEarthElement =
        Prefixed_Name(ceon_material, "RareEarthElement") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/Samarium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Samarium is a chemical element with the symbol Sm and atomic number 62."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Samarium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Samarium">http://w3id.org/CEON/ontology/material/Samarium</seealso>
    let Samarium = Prefixed_Name(ceon_material, "Samarium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Scandium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scandium is a chemical element with the symbol Sc and atomic number 21."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scandium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Scandium">http://w3id.org/CEON/ontology/material/Scandium</seealso>
    let Scandium = Prefixed_Name(ceon_material, "Scandium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Silicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Silicon is a chemical element with the symbol Si and atomic number 14."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Silicon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Silicon">http://w3id.org/CEON/ontology/material/Silicon</seealso>
    let Silicon = Prefixed_Name(ceon_material, "Silicon") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Tantalum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tantalum is a chemical element with the symbol Ta and atomic number 73."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tantalum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Tantalum">http://w3id.org/CEON/ontology/material/Tantalum</seealso>
    let Tantalum = Prefixed_Name(ceon_material, "Tantalum") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Terbium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Terbium is a chemical element with the symbol Tb and atomic number 65."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Terbium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Terbium">http://w3id.org/CEON/ontology/material/Terbium</seealso>
    let Terbium = Prefixed_Name(ceon_material, "Terbium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Thulium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Thulium is a chemical element with the symbol Tm and atomic number 69."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thulium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Thulium">http://w3id.org/CEON/ontology/material/Thulium</seealso>
    let Thulium = Prefixed_Name(ceon_material, "Thulium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Titanium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Titanium is a chemical element with the symbol Ti and atomic number 22."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Titanium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Titanium">http://w3id.org/CEON/ontology/material/Titanium</seealso>
    let Titanium = Prefixed_Name(ceon_material, "Titanium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Ytterbium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Yteerbium is a chemical element with the symbol Yb and atomic number 70."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ytterbium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Ytterbium">http://w3id.org/CEON/ontology/material/Ytterbium</seealso>
    let Ytterbium = Prefixed_Name(ceon_material, "Ytterbium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Yttrium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Yttrium is a chemical element with the symbol Y and atomic number 39."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Yttrium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Yttrium">http://w3id.org/CEON/ontology/material/Yttrium</seealso>
    let Yttrium = Prefixed_Name(ceon_material, "Yttrium") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/material/Zinc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zinc is a chemical element with the symbol Zn and atomic number 30."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zinc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/Zinc">http://w3id.org/CEON/ontology/material/Zinc</seealso>
    let Zinc = Prefixed_Name(ceon_material, "Zinc") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/anonymousFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"anonymousFormula represents that a molecular entity has the anonymous formula in a string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"anonymous formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/anonymousFormula">http://w3id.org/CEON/ontology/material/anonymousFormula</seealso>
    let anonymousFormula =
        Prefixed_Name(ceon_material, "anonymousFormula") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/descriptiveFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"descriptiveFormula represents that a molecular entity has the descriptive formula in a string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"descriptive formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/descriptiveFormula">http://w3id.org/CEON/ontology/material/descriptiveFormula</seealso>
    let descriptiveFormula =
        Prefixed_Name(ceon_material, "descriptiveFormula") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/hasChemicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasChemicalEntity intends to represent that a material can have a collection of chemical entities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has chemical entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/hasChemicalEntity">http://w3id.org/CEON/ontology/material/hasChemicalEntity</seealso>
    let hasChemicalEntity =
        Prefixed_Name(ceon_material, "hasChemicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/hasMaterialComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasMaterialComponent intends to represent that a material can have a collection of components."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has material component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/hasMaterialComponent">http://w3id.org/CEON/ontology/material/hasMaterialComponent</seealso>
    let hasMaterialComponent =
        Prefixed_Name(ceon_material, "hasMaterialComponent") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/hillFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"hillFormula represents that a composition has the hill formula in a string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hill formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/hillFormula">http://w3id.org/CEON/ontology/material/hillFormula</seealso>
    let hillFormula = Prefixed_Name(ceon_material, "hillFormula") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/material/reducedChemicalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"reducedChemicalFormula represents that a molecular entity has the reduced chemical formula in a string."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reduced chemical formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/material/reducedChemicalFormula">http://w3id.org/CEON/ontology/material/reducedChemicalFormula</seealso>
    let reducedChemicalFormula =
        Prefixed_Name(ceon_material, "reducedChemicalFormula") |> PrefixedName
