namespace http.contextus.net.ontology.ontomedia.core.space.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osr =
    let _namespace_iri = Namespace_Iri osr |> NamespaceIRI
    /// <summary>
    ///   <para>osr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"OntoMedia Space Representation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#">http://contextus.net/ontology/ontomedia/core/space#</seealso>
    let _prefix_iri = Prefixed_Name(osr, "") |> PrefixedName
    /// <summary>
    ///   <para>osr:Aquatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe an aquatic region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aquatic Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Aquatic">http://contextus.net/ontology/ontomedia/core/space#Aquatic</seealso>
    let Aquatic = Prefixed_Name(osr, "Aquatic") |> PrefixedName
    /// <summary>
    ///   <para>osr:Arable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe an arable region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Arable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Arable">http://contextus.net/ontology/ontomedia/core/space#Arable</seealso>
    let Arable = Prefixed_Name(osr, "Arable") |> PrefixedName
    /// <summary>
    ///   <para>osr:Arboreal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe an arboreal region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Arboreal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Arboreal">http://contextus.net/ontology/ontomedia/core/space#Arboreal</seealso>
    let Arboreal = Prefixed_Name(osr, "Arboreal") |> PrefixedName
    /// <summary>
    ///   <para>osr:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a specific area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Area">http://contextus.net/ontology/ontomedia/core/space#Area</seealso>
    let Area = Prefixed_Name(osr, "Area") |> PrefixedName
    /// <summary>
    ///   <para>osr:Bay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a bay region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Bay">http://contextus.net/ontology/ontomedia/core/space#Bay</seealso>
    let Bay = Prefixed_Name(osr, "Bay") |> PrefixedName

    /// <summary>
    ///   <para>osr:Biological-Surface-Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe the surface of a biological object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biological Surface Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space">http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space</seealso>
    let Biological_Surface_Space =
        Prefixed_Name(osr, "Biological-Surface-Space") |> PrefixedName

    /// <summary>
    ///   <para>osr:Bog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a boggy region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Bog">http://contextus.net/ontology/ontomedia/core/space#Bog</seealso>
    let Bog = Prefixed_Name(osr, "Bog") |> PrefixedName
    /// <summary>
    ///   <para>osr:Bounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a region that marks the boundary between other regions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bounding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Bounding">http://contextus.net/ontology/ontomedia/core/space#Bounding</seealso>
    let Bounding = Prefixed_Name(osr, "Bounding") |> PrefixedName
    /// <summary>
    ///   <para>osr:Capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a Capital city"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Capital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Capital">http://contextus.net/ontology/ontomedia/core/space#Capital</seealso>
    let Capital = Prefixed_Name(osr, "Capital") |> PrefixedName
    /// <summary>
    ///   <para>osr:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a city space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"City"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#City">http://contextus.net/ontology/ontomedia/core/space#City</seealso>
    let City = Prefixed_Name(osr, "City") |> PrefixedName
    /// <summary>
    ///   <para>osr:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Container">http://contextus.net/ontology/ontomedia/core/space#Container</seealso>
    let Container = Prefixed_Name(osr, "Container") |> PrefixedName
    /// <summary>
    ///   <para>osr:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a continent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Continent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Continent">http://contextus.net/ontology/ontomedia/core/space#Continent</seealso>
    let Continent = Prefixed_Name(osr, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>osr:Copse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a copse region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Copse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Copse">http://contextus.net/ontology/ontomedia/core/space#Copse</seealso>
    let Copse = Prefixed_Name(osr, "Copse") |> PrefixedName
    /// <summary>
    ///   <para>osr:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Country">http://contextus.net/ontology/ontomedia/core/space#Country</seealso>
    let Country = Prefixed_Name(osr, "Country") |> PrefixedName
    /// <summary>
    ///   <para>osr:Estuary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe an estuary region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Estuary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Estuary">http://contextus.net/ontology/ontomedia/core/space#Estuary</seealso>
    let Estuary = Prefixed_Name(osr, "Estuary") |> PrefixedName
    /// <summary>
    ///   <para>osr:Field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Field">http://contextus.net/ontology/ontomedia/core/space#Field</seealso>
    let Field = Prefixed_Name(osr, "Field") |> PrefixedName
    /// <summary>
    ///   <para>osr:Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a forested region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Forest">http://contextus.net/ontology/ontomedia/core/space#Forest</seealso>
    let Forest = Prefixed_Name(osr, "Forest") |> PrefixedName
    /// <summary>
    ///   <para>osr:Galaxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a galaxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Galaxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Galaxy">http://contextus.net/ontology/ontomedia/core/space#Galaxy</seealso>
    let Galaxy = Prefixed_Name(osr, "Galaxy") |> PrefixedName
    /// <summary>
    ///   <para>osr:Gaseous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a gaseous region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gaseous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Gaseous">http://contextus.net/ontology/ontomedia/core/space#Gaseous</seealso>
    let Gaseous = Prefixed_Name(osr, "Gaseous") |> PrefixedName
    /// <summary>
    ///   <para>osr:Hydrated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a very damp region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hydrated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Hydrated">http://contextus.net/ontology/ontomedia/core/space#Hydrated</seealso>
    let Hydrated = Prefixed_Name(osr, "Hydrated") |> PrefixedName
    /// <summary>
    ///   <para>osr:Lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a lake region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lake"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Lake">http://contextus.net/ontology/ontomedia/core/space#Lake</seealso>
    let Lake = Prefixed_Name(osr, "Lake") |> PrefixedName
    /// <summary>
    ///   <para>osr:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a region that forms a layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Layer">http://contextus.net/ontology/ontomedia/core/space#Layer</seealso>
    let Layer = Prefixed_Name(osr, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>osr:Ledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a ledge i.e on the mountain wall"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ledge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Ledge">http://contextus.net/ontology/ontomedia/core/space#Ledge</seealso>
    let Ledge = Prefixed_Name(osr, "Ledge") |> PrefixedName

    /// <summary>
    ///   <para>osr:Level-Traversing-Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is used to represent a space which traverses levels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Level Traversing Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space">http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space</seealso>
    let Level_Traversing_Space =
        Prefixed_Name(osr, "Level-Traversing-Space") |> PrefixedName

    /// <summary>
    ///   <para>osr:Lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a lot of land"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Lot">http://contextus.net/ontology/ontomedia/core/space#Lot</seealso>
    let Lot = Prefixed_Name(osr, "Lot") |> PrefixedName
    /// <summary>
    ///   <para>osr:Marsh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a marshy region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Marsh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Marsh">http://contextus.net/ontology/ontomedia/core/space#Marsh</seealso>
    let Marsh = Prefixed_Name(osr, "Marsh") |> PrefixedName
    /// <summary>
    ///   <para>osr:Metropolis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a metropolis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metropolis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Metropolis">http://contextus.net/ontology/ontomedia/core/space#Metropolis</seealso>
    let Metropolis = Prefixed_Name(osr, "Metropolis") |> PrefixedName
    /// <summary>
    ///   <para>osr:Mountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a mountain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mountain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Mountain">http://contextus.net/ontology/ontomedia/core/space#Mountain</seealso>
    let Mountain = Prefixed_Name(osr, "Mountain") |> PrefixedName
    /// <summary>
    ///   <para>osr:Mountain-Range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a continious mountainous region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mountain Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Mountain-Range">http://contextus.net/ontology/ontomedia/core/space#Mountain-Range</seealso>
    let Mountain_Range = Prefixed_Name(osr, "Mountain-Range") |> PrefixedName
    /// <summary>
    ///   <para>osr:Necropolis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a necropolis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Necropolis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Necropolis">http://contextus.net/ontology/ontomedia/core/space#Necropolis</seealso>
    let Necropolis = Prefixed_Name(osr, "Necropolis") |> PrefixedName
    /// <summary>
    ///   <para>osr:Ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe an ocean region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ocean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Ocean">http://contextus.net/ontology/ontomedia/core/space#Ocean</seealso>
    let Ocean = Prefixed_Name(osr, "Ocean") |> PrefixedName
    /// <summary>
    ///   <para>osr:Orbit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe the path of an orbiting object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orbit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Orbit">http://contextus.net/ontology/ontomedia/core/space#Orbit</seealso>
    let Orbit = Prefixed_Name(osr, "Orbit") |> PrefixedName
    /// <summary>
    ///   <para>osr:Orchard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a cultivated orchard region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orchard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Orchard">http://contextus.net/ontology/ontomedia/core/space#Orchard</seealso>
    let Orchard = Prefixed_Name(osr, "Orchard") |> PrefixedName
    /// <summary>
    ///   <para>osr:Plains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe plains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Plains">http://contextus.net/ontology/ontomedia/core/space#Plains</seealso>
    let Plains = Prefixed_Name(osr, "Plains") |> PrefixedName
    /// <summary>
    ///   <para>osr:Pond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a man-made pond region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Pond">http://contextus.net/ontology/ontomedia/core/space#Pond</seealso>
    let Pond = Prefixed_Name(osr, "Pond") |> PrefixedName
    /// <summary>
    ///   <para>osr:Pool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a pool region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Pool">http://contextus.net/ontology/ontomedia/core/space#Pool</seealso>
    let Pool = Prefixed_Name(osr, "Pool") |> PrefixedName
    /// <summary>
    ///   <para>osr:Port</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a port city"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Port"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Port">http://contextus.net/ontology/ontomedia/core/space#Port</seealso>
    let Port = Prefixed_Name(osr, "Port") |> PrefixedName
    /// <summary>
    ///   <para>osr:Portal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a portal i.e doorway, stargate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Portal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Portal">http://contextus.net/ontology/ontomedia/core/space#Portal</seealso>
    let Portal = Prefixed_Name(osr, "Portal") |> PrefixedName
    /// <summary>
    ///   <para>osr:Puddle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a puddle region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Puddle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Puddle">http://contextus.net/ontology/ontomedia/core/space#Puddle</seealso>
    let Puddle = Prefixed_Name(osr, "Puddle") |> PrefixedName
    /// <summary>
    ///   <para>osr:Quay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a quay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Quay">http://contextus.net/ontology/ontomedia/core/space#Quay</seealso>
    let Quay = Prefixed_Name(osr, "Quay") |> PrefixedName
    /// <summary>
    ///   <para>osr:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Region">http://contextus.net/ontology/ontomedia/core/space#Region</seealso>
    let Region = Prefixed_Name(osr, "Region") |> PrefixedName
    /// <summary>
    ///   <para>osr:River</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a river region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"River"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#River">http://contextus.net/ontology/ontomedia/core/space#River</seealso>
    let River = Prefixed_Name(osr, "River") |> PrefixedName
    /// <summary>
    ///   <para>osr:Riverbank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a riverbank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Riverbank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Riverbank">http://contextus.net/ontology/ontomedia/core/space#Riverbank</seealso>
    let Riverbank = Prefixed_Name(osr, "Riverbank") |> PrefixedName
    /// <summary>
    ///   <para>osr:Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a sea region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Sea">http://contextus.net/ontology/ontomedia/core/space#Sea</seealso>
    let Sea = Prefixed_Name(osr, "Sea") |> PrefixedName
    /// <summary>
    ///   <para>osr:Seashore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a sea shore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seashore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Seashore">http://contextus.net/ontology/ontomedia/core/space#Seashore</seealso>
    let Seashore = Prefixed_Name(osr, "Seashore") |> PrefixedName
    /// <summary>
    ///   <para>osr:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Space">http://contextus.net/ontology/ontomedia/core/space#Space</seealso>
    let Space = Prefixed_Name(osr, "Space") |> PrefixedName
    /// <summary>
    ///   <para>osr:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a stream region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stream"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Stream">http://contextus.net/ontology/ontomedia/core/space#Stream</seealso>
    let Stream = Prefixed_Name(osr, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>osr:Surface-Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe the surface of a object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Surface Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Surface-Space">http://contextus.net/ontology/ontomedia/core/space#Surface-Space</seealso>
    let Surface_Space = Prefixed_Name(osr, "Surface-Space") |> PrefixedName
    /// <summary>
    ///   <para>osr:Swamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a swampy region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Swamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Swamp">http://contextus.net/ontology/ontomedia/core/space#Swamp</seealso>
    let Swamp = Prefixed_Name(osr, "Swamp") |> PrefixedName
    /// <summary>
    ///   <para>osr:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a town"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Town"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Town">http://contextus.net/ontology/ontomedia/core/space#Town</seealso>
    let Town = Prefixed_Name(osr, "Town") |> PrefixedName
    /// <summary>
    ///   <para>osr:Universe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a universe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Universe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Universe">http://contextus.net/ontology/ontomedia/core/space#Universe</seealso>
    let Universe = Prefixed_Name(osr, "Universe") |> PrefixedName
    /// <summary>
    ///   <para>osr:Urban-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe an urban area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Urban Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Urban-Area">http://contextus.net/ontology/ontomedia/core/space#Urban-Area</seealso>
    let Urban_Area = Prefixed_Name(osr, "Urban-Area") |> PrefixedName
    /// <summary>
    ///   <para>osr:Vessel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a vessel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vessel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Vessel">http://contextus.net/ontology/ontomedia/core/space#Vessel</seealso>
    let Vessel = Prefixed_Name(osr, "Vessel") |> PrefixedName
    /// <summary>
    ///   <para>osr:Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a village space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Village"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Village">http://contextus.net/ontology/ontomedia/core/space#Village</seealso>
    let Village = Prefixed_Name(osr, "Village") |> PrefixedName
    /// <summary>
    ///   <para>osr:Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a volcano"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volcano"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Volcano">http://contextus.net/ontology/ontomedia/core/space#Volcano</seealso>
    let Volcano = Prefixed_Name(osr, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>osr:Wood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a wooded region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Wood">http://contextus.net/ontology/ontomedia/core/space#Wood</seealso>
    let Wood = Prefixed_Name(osr, "Wood") |> PrefixedName
    /// <summary>
    ///   <para>osr:World</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property is to be used to describe a world, planet, moon or other similar body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"World"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#World">http://contextus.net/ontology/ontomedia/core/space#World</seealso>
    let World = Prefixed_Name(osr, "World") |> PrefixedName
    /// <summary>
    ///   <para>osr:adjacent-above</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is to be used to describe an adjacent Space which is above the other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Adjacent Above"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#adjacent-above">http://contextus.net/ontology/ontomedia/core/space#adjacent-above</seealso>
    let adjacent_above = Prefixed_Name(osr, "adjacent-above") |> PrefixedName
    /// <summary>
    ///   <para>osr:adjacent-below</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is to be used to describe an adjacent Space which is below the other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Adjacent Below"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#adjacent-below">http://contextus.net/ontology/ontomedia/core/space#adjacent-below</seealso>
    let adjacent_below = Prefixed_Name(osr, "adjacent-below") |> PrefixedName
    /// <summary>
    ///   <para>osr:adjacent-to</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#adjacent-to">http://contextus.net/ontology/ontomedia/core/space#adjacent-to</seealso>
    let adjacent_to = Prefixed_Name(osr, "adjacent-to") |> PrefixedName
    /// <summary>
    ///   <para>osr:has-boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is to be used to describe an Space which is the boundary of the Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#has-boundary">http://contextus.net/ontology/ontomedia/core/space#has-boundary</seealso>
    let has_boundary = Prefixed_Name(osr, "has-boundary") |> PrefixedName
    /// <summary>
    ///   <para>osr:has-dividing-item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is to be used to describe an item used to divide a portal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Dividing Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#has-dividing-item">http://contextus.net/ontology/ontomedia/core/space#has-dividing-item</seealso>
    let has_dividing_item = Prefixed_Name(osr, "has-dividing-item") |> PrefixedName
    /// <summary>
    ///   <para>osr:is-boundary-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is to be used to describe an Space of which the region is the boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Boundary Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#is-boundary-of">http://contextus.net/ontology/ontomedia/core/space#is-boundary-of</seealso>
    let is_boundary_of = Prefixed_Name(osr, "is-boundary-of") |> PrefixedName
    /// <summary>
    ///   <para>osr:orbit-around</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is to be used to describe an adjacent Space which describes an orbit around the other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orbit Around"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#orbit-around">http://contextus.net/ontology/ontomedia/core/space#orbit-around</seealso>
    let orbit_around = Prefixed_Name(osr, "orbit-around") |> PrefixedName
