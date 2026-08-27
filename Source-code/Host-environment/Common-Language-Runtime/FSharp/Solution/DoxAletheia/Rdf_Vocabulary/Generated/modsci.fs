namespace https.w3id.org.skgo.modsci.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module modsci =
    let _namespace_iri = Namespace_Iri modsci |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:skgo/modsci#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#">https://w3id.org/skgo/modsci#</seealso>
    let _prefix_iri = Prefixed_Name(modsci, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ADInstruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ADInstruments">https://w3id.org/skgo/modsci#ADInstruments</seealso>
    let ADInstruments = Prefixed_Name(modsci, "ADInstruments") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Accelerometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Accelerometer">https://w3id.org/skgo/modsci#Accelerometer</seealso>
    let Accelerometer = Prefixed_Name(modsci, "Accelerometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Accumulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Accumulator">https://w3id.org/skgo/modsci#Accumulator</seealso>
    let Accumulator = Prefixed_Name(modsci, "Accumulator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AcidbaseChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For chemicals that can behave as acids or bases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acid–base Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AcidbaseChemistry">https://w3id.org/skgo/modsci#AcidbaseChemistry</seealso>
    let AcidbaseChemistry = Prefixed_Name(modsci, "AcidbaseChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Acoustics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Acoustics is a branch of continuum mechanics and is the study of sound, mechanical waves in gases, liquids, and solids."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acoustics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Acoustics">https://w3id.org/skgo/modsci#Acoustics</seealso>
    let Acoustics = Prefixed_Name(modsci, "Acoustics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AgilentTechnologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AgilentTechnologies">https://w3id.org/skgo/modsci#AgilentTechnologies</seealso>
    let AgilentTechnologies =
        Prefixed_Name(modsci, "AgilentTechnologies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Agriculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agriculture, also known as farming, is the process of producing food, feed, fiber and other desired products by cultivation of certain plants and the raising of domesticated animals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Agriculture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Agriculture">https://w3id.org/skgo/modsci#Agriculture</seealso>
    let Agriculture = Prefixed_Name(modsci, "Agriculture") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Agronomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Agronomy">https://w3id.org/skgo/modsci#Agronomy</seealso>
    let Agronomy = Prefixed_Name(modsci, "Agronomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Algebra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Algebra">https://w3id.org/skgo/modsci#Algebra</seealso>
    let Algebra = Prefixed_Name(modsci, "Algebra") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Algorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Algorithms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Algorithms">https://w3id.org/skgo/modsci#Algorithms</seealso>
    let Algorithms = Prefixed_Name(modsci, "Algorithms") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ammeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ammeter">https://w3id.org/skgo/modsci#Ammeter</seealso>
    let Ammeter = Prefixed_Name(modsci, "Ammeter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AnalyticalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Analytical chemistry is the analysis of material samples to gain an understanding of their chemical composition and structure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Analytical Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AnalyticalChemistry">https://w3id.org/skgo/modsci#AnalyticalChemistry</seealso>
    let AnalyticalChemistry =
        Prefixed_Name(modsci, "AnalyticalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AnalyticalSpectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AnalyticalSpectrometry">https://w3id.org/skgo/modsci#AnalyticalSpectrometry</seealso>
    let AnalyticalSpectrometry =
        Prefixed_Name(modsci, "AnalyticalSpectrometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Anatomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Anatomy is the study of the structure and organization of living things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anatomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Anatomy">https://w3id.org/skgo/modsci#Anatomy</seealso>
    let Anatomy = Prefixed_Name(modsci, "Anatomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Anemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Anemometer">https://w3id.org/skgo/modsci#Anemometer</seealso>
    let Anemometer = Prefixed_Name(modsci, "Anemometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AnimalProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AnimalProduction">https://w3id.org/skgo/modsci#AnimalProduction</seealso>
    let AnimalProduction = Prefixed_Name(modsci, "AnimalProduction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Anthropology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Anthropology is the scientific study of humans, human behavior and societies in the past and present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Anthropology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Anthropology">https://w3id.org/skgo/modsci#Anthropology</seealso>
    let Anthropology = Prefixed_Name(modsci, "Anthropology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AntonPaar</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AntonPaar">https://w3id.org/skgo/modsci#AntonPaar</seealso>
    let AntonPaar = Prefixed_Name(modsci, "AntonPaar") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ApplicationOfScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An application of science is any use of scientific knowledge for a specific purpose, whether to do more science; to design a product, process, or medical treatment; to develop a new technology; or to predict the impacts of human actions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application of science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ApplicationOfScience">https://w3id.org/skgo/modsci#ApplicationOfScience</seealso>
    let ApplicationOfScience =
        Prefixed_Name(modsci, "ApplicationOfScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AppliedMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Applied mathematics is a branch of mathematics that concerns itself with the application of mathematical knowledge to other domains."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Applied Mathematics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AppliedMathematics">https://w3id.org/skgo/modsci#AppliedMathematics</seealso>
    let AppliedMathematics = Prefixed_Name(modsci, "AppliedMathematics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AppliedMechanics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AppliedMechanics">https://w3id.org/skgo/modsci#AppliedMechanics</seealso>
    let AppliedMechanics = Prefixed_Name(modsci, "AppliedMechanics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AppliedPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Applied physics is intended for a particular technological or practical use."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Applied and Interdisciplinary Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AppliedPhysics">https://w3id.org/skgo/modsci#AppliedPhysics</seealso>
    let AppliedPhysics = Prefixed_Name(modsci, "AppliedPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AppliedSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Applied science is the use or the study of the use of scientific knowledge to develop technology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Applied Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AppliedSciences">https://w3id.org/skgo/modsci#AppliedSciences</seealso>
    let AppliedSciences = Prefixed_Name(modsci, "AppliedSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ApproximationTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ApproximationTheory">https://w3id.org/skgo/modsci#ApproximationTheory</seealso>
    let ApproximationTheory =
        Prefixed_Name(modsci, "ApproximationTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Archaeology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Archaeology, or archeology, is the study of human activity through the recovery and analysis of material culture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Archaeology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Archaeology">https://w3id.org/skgo/modsci#Archaeology</seealso>
    let Archaeology = Prefixed_Name(modsci, "Archaeology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Architecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Architecture is the art and science of designing buildings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Architecture">https://w3id.org/skgo/modsci#Architecture</seealso>
    let Architecture = Prefixed_Name(modsci, "Architecture") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ArtificialIntelligence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In computer science, artificial intelligence (AI), sometimes called machine intelligence, is intelligence demonstrated by machines, in contrast to the natural intelligence displayed by humans. Colloquially, the term "artificial intelligence" is often used to describe machines (or computers) that mimic "cognitive" functions that humans associate with the human mind, such as "learning" and "problem solving"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Artificial Intelligence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ArtificialIntelligence">https://w3id.org/skgo/modsci#ArtificialIntelligence</seealso>
    let ArtificialIntelligence =
        Prefixed_Name(modsci, "ArtificialIntelligence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Astrobiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Astrobiology, formerly known as exobiology, is an interdisciplinary scientific field concerned with the origins, early evolution, distribution, and future of life in the universe."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Astrobiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Astrobiology">https://w3id.org/skgo/modsci#Astrobiology</seealso>
    let Astrobiology = Prefixed_Name(modsci, "Astrobiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Astrochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Astrochemistry is the study of the abundance and reactions of molecules in the Universe, and their interaction with radiation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Astrochemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Astrochemistry">https://w3id.org/skgo/modsci#Astrochemistry</seealso>
    let Astrochemistry = Prefixed_Name(modsci, "Astrochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Astrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Astrometry is the study of the positions, distances between, and motions of astronomical objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Astrometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Astrometry">https://w3id.org/skgo/modsci#Astrometry</seealso>
    let Astrometry = Prefixed_Name(modsci, "Astrometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AstronomicalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Astronomical Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AstronomicalPhenomena">https://w3id.org/skgo/modsci#AstronomicalPhenomena</seealso>
    let AstronomicalPhenomena =
        Prefixed_Name(modsci, "AstronomicalPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Astronomical_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Astronomy</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Astronomical_Studies">https://w3id.org/skgo/modsci#Astronomical_Studies</seealso>
    let Astronomical_Studies =
        Prefixed_Name(modsci, "Astronomical_Studies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Astronomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"is a science involving the observation and explanation of events occurring outside Earth and its atmosphere."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Astronomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Astronomy">https://w3id.org/skgo/modsci#Astronomy</seealso>
    let Astronomy = Prefixed_Name(modsci, "Astronomy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AtmosphericPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Atmospheric Optical Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AtmosphericPhenomena">https://w3id.org/skgo/modsci#AtmosphericPhenomena</seealso>
    let AtmosphericPhenomena =
        Prefixed_Name(modsci, "AtmosphericPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AtmosphericSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Atmospheric science is an umbrella term for the study of the atmosphere and its processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atmospheric Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AtmosphericSciences">https://w3id.org/skgo/modsci#AtmosphericSciences</seealso>
    let AtmosphericSciences =
        Prefixed_Name(modsci, "AtmosphericSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#AtomicPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Atomic, molecular, and optical physics (AMO) is the study of matter-matter and light-matter interactions; at the scale of one or a few atoms and energy scales around several electron volts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atomic, Molecular, and Optical Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AtomicPhysics">https://w3id.org/skgo/modsci#AtomicPhysics</seealso>
    let AtomicPhysics = Prefixed_Name(modsci, "AtomicPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Aurora</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#AtmosphericPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Aurora">https://w3id.org/skgo/modsci#Aurora</seealso>
    let Aurora = Prefixed_Name(modsci, "Aurora") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AutomataTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Automata theory is the study of abstract machines and automata, as well as the computational problems that can be solved using them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Automata Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AutomataTheory">https://w3id.org/skgo/modsci#AutomataTheory</seealso>
    let AutomataTheory = Prefixed_Name(modsci, "AutomataTheory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#AutomatedReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Automated reasoning is an area of computer science, cognitive science, and mathematical logic dedicated to understanding different aspects of reasoning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Automated Reasoning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#AutomatedReasoning">https://w3id.org/skgo/modsci#AutomatedReasoning</seealso>
    let AutomatedReasoning = Prefixed_Name(modsci, "AutomatedReasoning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Barometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Barometer">https://w3id.org/skgo/modsci#Barometer</seealso>
    let Barometer = Prefixed_Name(modsci, "Barometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#BasinAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BasinAnalysis">https://w3id.org/skgo/modsci#BasinAnalysis</seealso>
    let BasinAnalysis = Prefixed_Name(modsci, "BasinAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BehaviouralSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Behavioural sciences explore the cognitive processes within organisms and the behavioural interactions between organisms in the natural world."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Behavioural Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BehaviouralSciences">https://w3id.org/skgo/modsci#BehaviouralSciences</seealso>
    let BehaviouralSciences =
        Prefixed_Name(modsci, "BehaviouralSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Biochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biochemistry is the chemistry of life."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biochemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biochemistry">https://w3id.org/skgo/modsci#Biochemistry</seealso>
    let Biochemistry = Prefixed_Name(modsci, "Biochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biochip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ApplicationOfScience</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biochip">https://w3id.org/skgo/modsci#Biochip</seealso>
    let Biochip = Prefixed_Name(modsci, "Biochip") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Bioengineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biological engineering, or bioengineering/bio-engineering, is the application of principles of biology and the tools of engineering to create usable, tangible, economically viable products."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biological Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Bioengineering">https://w3id.org/skgo/modsci#Bioengineering</seealso>
    let Bioengineering = Prefixed_Name(modsci, "Bioengineering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Bioethics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bioethics is the study of the ethical issues emerging from advances in biology and medicine."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bioethics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Bioethics">https://w3id.org/skgo/modsci#Bioethics</seealso>
    let Bioethics = Prefixed_Name(modsci, "Bioethics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biogeography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biogeography is the study of the distribution of species and ecosystems in geographic space and through geological time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biogeography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biogeography">https://w3id.org/skgo/modsci#Biogeography</seealso>
    let Biogeography = Prefixed_Name(modsci, "Biogeography") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Bioinformatics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bioinformatics and Computational biology are interdisciplinary fields of research, development and application of algorithms, computational and statistical methods for management and analysis of biological data, and for solving basic biological problems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bioinformatics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Bioinformatics">https://w3id.org/skgo/modsci#Bioinformatics</seealso>
    let Bioinformatics = Prefixed_Name(modsci, "Bioinformatics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BioinformaticsSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BioinformaticsSoftware">https://w3id.org/skgo/modsci#BioinformaticsSoftware</seealso>
    let BioinformaticsSoftware =
        Prefixed_Name(modsci, "BioinformaticsSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BioinorganicChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BioinorganicChemistry">https://w3id.org/skgo/modsci#BioinorganicChemistry</seealso>
    let BioinorganicChemistry =
        Prefixed_Name(modsci, "BioinorganicChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BiologicalMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BiologicalMathematics">https://w3id.org/skgo/modsci#BiologicalMathematics</seealso>
    let BiologicalMathematics =
        Prefixed_Name(modsci, "BiologicalMathematics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BiologicalOceanography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BiologicalOceanography">https://w3id.org/skgo/modsci#BiologicalOceanography</seealso>
    let BiologicalOceanography =
        Prefixed_Name(modsci, "BiologicalOceanography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BiologicalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BiologicalPhenomena">https://w3id.org/skgo/modsci#BiologicalPhenomena</seealso>
    let BiologicalPhenomena =
        Prefixed_Name(modsci, "BiologicalPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Biological_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Biology</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biological_Studies">https://w3id.org/skgo/modsci#Biological_Studies</seealso>
    let Biological_Studies = Prefixed_Name(modsci, "Biological_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biology is the science of life. It is concerned with the characteristics and behaviors of organisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biology">https://w3id.org/skgo/modsci#Biology</seealso>
    let Biology = Prefixed_Name(modsci, "Biology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#BiomedicalEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biomedical engineering (BME) or medical engineering is the application of engineering principles and design concepts to medicine and biology for healthcare purposes (e.g. diagnostic or therapeutic)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biomedical Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#BiomedicalEngineering">https://w3id.org/skgo/modsci#BiomedicalEngineering</seealso>
    let BiomedicalEngineering =
        Prefixed_Name(modsci, "BiomedicalEngineering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Biomedical_Signals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificDiscovery</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biomedical_Signals">https://w3id.org/skgo/modsci#Biomedical_Signals</seealso>
    let Biomedical_Signals = Prefixed_Name(modsci, "Biomedical_Signals") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biophysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biophysics is an interdisciplinary science that applies approaches and methods traditionally used in physics to study biological phenomena."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biophysics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biophysics">https://w3id.org/skgo/modsci#Biophysics</seealso>
    let Biophysics = Prefixed_Name(modsci, "Biophysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biopsychology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biological psychology,is the application of the principles of biology to the study of physiological and developmental mechanisms of behavior in humans and other animals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biopsychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biopsychology">https://w3id.org/skgo/modsci#Biopsychology</seealso>
    let Biopsychology = Prefixed_Name(modsci, "Biopsychology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biosensors</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ApplicationOfScience</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biosensors">https://w3id.org/skgo/modsci#Biosensors</seealso>
    let Biosensors = Prefixed_Name(modsci, "Biosensors") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biostatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biostatistics are the development and application of statistical methods to a wide range of topics in biology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biostatistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biostatistics">https://w3id.org/skgo/modsci#Biostatistics</seealso>
    let Biostatistics = Prefixed_Name(modsci, "Biostatistics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Biotechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Biotechnology is a technology based on biology, especially when used in agriculture, food science, medicine, and genetic engineering."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biotechnology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Biotechnology">https://w3id.org/skgo/modsci#Biotechnology</seealso>
    let Biotechnology = Prefixed_Name(modsci, "Biotechnology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Boiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Boiling">https://w3id.org/skgo/modsci#Boiling</seealso>
    let Boiling = Prefixed_Name(modsci, "Boiling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Botany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Botany also called plant science(s), plant biology or phytology, is the science of plant life and a branch of biology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Botany"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Botany">https://w3id.org/skgo/modsci#Botany</seealso>
    let Botany = Prefixed_Name(modsci, "Botany") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Breaking_waves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#OceanographicPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Breaking_waves">https://w3id.org/skgo/modsci#Breaking_waves</seealso>
    let Breaking_waves = Prefixed_Name(modsci, "Breaking_waves") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Bruker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Bruker">https://w3id.org/skgo/modsci#Bruker</seealso>
    let Bruker = Prefixed_Name(modsci, "Bruker") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CalculusOfVariations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CalculusOfVariations">https://w3id.org/skgo/modsci#CalculusOfVariations</seealso>
    let CalculusOfVariations =
        Prefixed_Name(modsci, "CalculusOfVariations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Caliper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Caliper">https://w3id.org/skgo/modsci#Caliper</seealso>
    let Caliper = Prefixed_Name(modsci, "Caliper") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Calorimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Calorimeter">https://w3id.org/skgo/modsci#Calorimeter</seealso>
    let Calorimeter = Prefixed_Name(modsci, "Calorimeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Catalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Catalysis">https://w3id.org/skgo/modsci#Catalysis</seealso>
    let Catalysis = Prefixed_Name(modsci, "Catalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#CellBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cell biology is a branch of biology that studies the structure and function of the cell, which is the basic unit of life."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cell Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CellBiology">https://w3id.org/skgo/modsci#CellBiology</seealso>
    let CellBiology = Prefixed_Name(modsci, "CellBiology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ChemicalCharacterisationOfMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ChemicalCharacterisationOfMaterials">https://w3id.org/skgo/modsci#ChemicalCharacterisationOfMaterials</seealso>
    let ChemicalCharacterisationOfMaterials =
        Prefixed_Name(modsci, "ChemicalCharacterisationOfMaterials") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ChemicalEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chemical engineering is the application of science, in particular chemistry, fluid physics, and biology, along with mathematics and economics to the human endeavor of converting raw materials or chemicals into more useful or valuable forms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemical Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ChemicalEngineering">https://w3id.org/skgo/modsci#ChemicalEngineering</seealso>
    let ChemicalEngineering =
        Prefixed_Name(modsci, "ChemicalEngineering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ChemicalOceanography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ChemicalOceanography">https://w3id.org/skgo/modsci#ChemicalOceanography</seealso>
    let ChemicalOceanography =
        Prefixed_Name(modsci, "ChemicalOceanography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ChemicalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ChemicalPhenomena">https://w3id.org/skgo/modsci#ChemicalPhenomena</seealso>
    let ChemicalPhenomena = Prefixed_Name(modsci, "ChemicalPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ChemicalThermodynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ChemicalThermodynamics">https://w3id.org/skgo/modsci#ChemicalThermodynamics</seealso>
    let ChemicalThermodynamics =
        Prefixed_Name(modsci, "ChemicalThermodynamics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Chemical_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Chemistry</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Chemical_Studies">https://w3id.org/skgo/modsci#Chemical_Studies</seealso>
    let Chemical_Studies = Prefixed_Name(modsci, "Chemical_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Chemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chemistry is defined as the science of matter, different from physics, in terms of matter's chemical structure, reactivity, properties and reactions or transformations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Chemistry">https://w3id.org/skgo/modsci#Chemistry</seealso>
    let Chemistry = Prefixed_Name(modsci, "Chemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ClassicalPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ClassicalPhysics">https://w3id.org/skgo/modsci#ClassicalPhysics</seealso>
    let ClassicalPhysics = Prefixed_Name(modsci, "ClassicalPhysics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ClassificationAlgorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ClassificationAlgorithms">https://w3id.org/skgo/modsci#ClassificationAlgorithms</seealso>
    let ClassificationAlgorithms =
        Prefixed_Name(modsci, "ClassificationAlgorithms") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CoalGeology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CoalGeology">https://w3id.org/skgo/modsci#CoalGeology</seealso>
    let CoalGeology = Prefixed_Name(modsci, "CoalGeology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CodingAndInformationTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CodingAndInformationTheory">https://w3id.org/skgo/modsci#CodingAndInformationTheory</seealso>
    let CodingAndInformationTheory =
        Prefixed_Name(modsci, "CodingAndInformationTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CognitiveScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cognitive science is the interdisciplinary, scientific study of the mind and its processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cognitive Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CognitiveScience">https://w3id.org/skgo/modsci#CognitiveScience</seealso>
    let CognitiveScience = Prefixed_Name(modsci, "CognitiveScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Colloid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Colloid">https://w3id.org/skgo/modsci#Colloid</seealso>
    let Colloid = Prefixed_Name(modsci, "Colloid") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ColloidalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Interface and colloid science is an interdisciplinary intersection of branches of chemistry, physics, nanoscience and other fields dealing with colloids, heterogeneous systems consisting of a mechanical mixture of particles between 1 nm and 1000 nm dispersed in a continuous medium."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Colloidal Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ColloidalChemistry">https://w3id.org/skgo/modsci#ColloidalChemistry</seealso>
    let ColloidalChemistry = Prefixed_Name(modsci, "ColloidalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CommunicationAndSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Communications security is the discipline of preventing unauthorized interceptors from accessing telecommunications in an intelligible form, while still delivering content to the intended recipients."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Communication and Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CommunicationAndSecurity">https://w3id.org/skgo/modsci#CommunicationAndSecurity</seealso>
    let CommunicationAndSecurity =
        Prefixed_Name(modsci, "CommunicationAndSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CommunicationStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Communication is the act of conveying meanings from one entity or group to another through the use of mutually understood signs, symbols, and semiotic rules."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CommunicationStudies">https://w3id.org/skgo/modsci#CommunicationStudies</seealso>
    let CommunicationStudies =
        Prefixed_Name(modsci, "CommunicationStudies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Community_of_European_Solar_Radio_Astronomers</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Community_of_European_Solar_Radio_Astronomers">https://w3id.org/skgo/modsci#Community_of_European_Solar_Radio_Astronomers</seealso>
    let Community_of_European_Solar_Radio_Astronomers =
        Prefixed_Name(modsci, "Community_of_European_Solar_Radio_Astronomers") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CompilerTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A compiler implements a formal transformation from a high-level source program to a low-level target program."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compiler Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CompilerTheory">https://w3id.org/skgo/modsci#CompilerTheory</seealso>
    let CompilerTheory = Prefixed_Name(modsci, "CompilerTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputabilityTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computability theory, also known as recursion theory, is a branch of mathematical logic, of computer science, and of the theory of computation that originated in the 1930s with the study of computable functions and Turing degrees."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computability Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputabilityTheory">https://w3id.org/skgo/modsci#ComputabilityTheory</seealso>
    let ComputabilityTheory =
        Prefixed_Name(modsci, "ComputabilityTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputationalComplexityTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computational complexity theory focuses on classifying computational problems according to their inherent difficulty, and relating these classes to each other. A computational problem is a task solved by a computer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computational Complexity Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputationalComplexityTheory">https://w3id.org/skgo/modsci#ComputationalComplexityTheory</seealso>
    let ComputationalComplexityTheory =
        Prefixed_Name(modsci, "ComputationalComplexityTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputationalLinguistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computational linguistics is an interdisciplinary field concerned with the statistical or rule-based modeling of natural language from a computational perspective, as well as the study of appropriate computational approaches to linguistic questions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computational Linguistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputationalLinguistics">https://w3id.org/skgo/modsci#ComputationalLinguistics</seealso>
    let ComputationalLinguistics =
        Prefixed_Name(modsci, "ComputationalLinguistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputationalMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputationalMathematics">https://w3id.org/skgo/modsci#ComputationalMathematics</seealso>
    let ComputationalMathematics =
        Prefixed_Name(modsci, "ComputationalMathematics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputationalPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computational physics is the study and implementation of numerical algorithms in order to solve problems in physics for which a quantitative theory already exists."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computational Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputationalPhysics">https://w3id.org/skgo/modsci#ComputationalPhysics</seealso>
    let ComputationalPhysics =
        Prefixed_Name(modsci, "ComputationalPhysics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Computer-HumanInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Computer-HumanInteraction">https://w3id.org/skgo/modsci#Computer-HumanInteraction</seealso>
    let Computer_HumanInteraction =
        Prefixed_Name(modsci, "Computer-HumanInteraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerApplications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerApplications">https://w3id.org/skgo/modsci#ComputerApplications</seealso>
    let ComputerApplications =
        Prefixed_Name(modsci, "ComputerApplications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerConcurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In computer science, concurrency is the ability of different parts or units of a program, algorithm, or problem to be executed out-of-order or in partial order, without affecting the final outcome. This allows for parallel execution of the concurrent units, which can significantly improve overall speed of the execution in multi-processor and multi-core systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Concurrency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerConcurrency">https://w3id.org/skgo/modsci#ComputerConcurrency</seealso>
    let ComputerConcurrency =
        Prefixed_Name(modsci, "ComputerConcurrency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerGraphics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computer graphics are pictures and films created using computers. Usually, the term refers to computer-generated image data created with the help of specialized graphical hardware and software."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Computer graphics is the study of digital visual contents and involves the synthesis and manipulation of image data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Graphics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Computer Graphics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerGraphics">https://w3id.org/skgo/modsci#ComputerGraphics</seealso>
    let ComputerGraphics = Prefixed_Name(modsci, "ComputerGraphics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computer science is the study of processes that interact with data and that can be represented as data in the form of programs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerScience">https://w3id.org/skgo/modsci#ComputerScience</seealso>
    let ComputerScience = Prefixed_Name(modsci, "ComputerScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computer security, cybersecurity or information technology security (IT security) is the protection of computer systems from the theft of or damage to their hardware, software, or electronic data, as well as from the disruption or misdirection of the services they provide."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerSecurity">https://w3id.org/skgo/modsci#ComputerSecurity</seealso>
    let ComputerSecurity = Prefixed_Name(modsci, "ComputerSecurity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerSoftware">https://w3id.org/skgo/modsci#ComputerSoftware</seealso>
    let ComputerSoftware = Prefixed_Name(modsci, "ComputerSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerSystemArchitecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In computer engineering, computer architecture is a set of rules and methods that describe the functionality, organization, and implementation of computer systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Architecture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerSystemArchitecture">https://w3id.org/skgo/modsci#ComputerSystemArchitecture</seealso>
    let ComputerSystemArchitecture =
        Prefixed_Name(modsci, "ComputerSystemArchitecture") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ComputerVision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computer vision is an interdisciplinary scientific field that deals with how computers can be made to gain high-level understanding from digital images or videos."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Vision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ComputerVision">https://w3id.org/skgo/modsci#ComputerVision</seealso>
    let ComputerVision = Prefixed_Name(modsci, "ComputerVision") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ConceptualModelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ConceptualModelling">https://w3id.org/skgo/modsci#ConceptualModelling</seealso>
    let ConceptualModelling =
        Prefixed_Name(modsci, "ConceptualModelling") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#CondensedMatterPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Condensed matter physics is the field of physics that deals with the macroscopic physical properties of matter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Condensed Matter Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CondensedMatterPhysics">https://w3id.org/skgo/modsci#CondensedMatterPhysics</seealso>
    let CondensedMatterPhysics =
        Prefixed_Name(modsci, "CondensedMatterPhysics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Conservation_of_energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Conservation_of_energy">https://w3id.org/skgo/modsci#Conservation_of_energy</seealso>
    let Conservation_of_energy =
        Prefixed_Name(modsci, "Conservation_of_energy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Cosmology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical cosmology is the study of the largest-scale structures and dynamics of the Universe and is concerned with fundamental questions about its origin, structure, evolution, and ultimate fate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical Cosmology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Cosmology">https://w3id.org/skgo/modsci#Cosmology</seealso>
    let Cosmology = Prefixed_Name(modsci, "Cosmology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#CropProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CropProduction">https://w3id.org/skgo/modsci#CropProduction</seealso>
    let CropProduction = Prefixed_Name(modsci, "CropProduction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Cryobiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cryobiology is the study of living organisms, organs, biological tissues or biological cells at low temperatures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cryobiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Cryobiology">https://w3id.org/skgo/modsci#Cryobiology</seealso>
    let Cryobiology = Prefixed_Name(modsci, "Cryobiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Cryptography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cryptography or cryptology is the practice and study of techniques for secure communication in the presence of third parties called adversaries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cryptography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Cryptography">https://w3id.org/skgo/modsci#Cryptography</seealso>
    let Cryptography = Prefixed_Name(modsci, "Cryptography") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Crystal_growth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Crystal_growth">https://w3id.org/skgo/modsci#Crystal_growth</seealso>
    let Crystal_growth = Prefixed_Name(modsci, "Crystal_growth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Crystallography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Crystallography is the scientific study of crystals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Crystallography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Crystallography">https://w3id.org/skgo/modsci#Crystallography</seealso>
    let Crystallography = Prefixed_Name(modsci, "Crystallography") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#CulturalStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cultural studies is a field of theoretically, politically, and empirically engaged cultural analysis that concentrates upon the political dynamics of contemporary culture, its historical foundations, defining traits, conflicts, and contingencies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cultural Studies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#CulturalStudies">https://w3id.org/skgo/modsci#CulturalStudies</seealso>
    let CulturalStudies = Prefixed_Name(modsci, "CulturalStudies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Cybernetics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cybernetics is a transdisciplinary approach for exploring regulatory systems with feedback, their structures, constraints, and possibilities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cybernetics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Cybernetics">https://w3id.org/skgo/modsci#Cybernetics</seealso>
    let Cybernetics = Prefixed_Name(modsci, "Cybernetics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#DNA_Sequencer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DNA_Sequencer">https://w3id.org/skgo/modsci#DNA_Sequencer</seealso>
    let DNA_Sequencer = Prefixed_Name(modsci, "DNA_Sequencer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#DataEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DataEncryption">https://w3id.org/skgo/modsci#DataEncryption</seealso>
    let DataEncryption = Prefixed_Name(modsci, "DataEncryption") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#DataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DataFormat">https://w3id.org/skgo/modsci#DataFormat</seealso>
    let DataFormat = Prefixed_Name(modsci, "DataFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#DataMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data mining is the process of discovering patterns in large data sets involving methods at the intersection of machine learning, statistics, and database systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Mining"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DataMining">https://w3id.org/skgo/modsci#DataMining</seealso>
    let DataMining = Prefixed_Name(modsci, "DataMining") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#DataStructures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DataStructures">https://w3id.org/skgo/modsci#DataStructures</seealso>
    let DataStructures = Prefixed_Name(modsci, "DataStructures") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#DatabaseManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Digital databases are managed using database management systems to store, create, maintain, and search data, through database models and query languages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DatabaseManagement">https://w3id.org/skgo/modsci#DatabaseManagement</seealso>
    let DatabaseManagement = Prefixed_Name(modsci, "DatabaseManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DecisionSupportSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DecisionSupportSystems">https://w3id.org/skgo/modsci#DecisionSupportSystems</seealso>
    let DecisionSupportSystems =
        Prefixed_Name(modsci, "DecisionSupportSystems") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Decision_Trees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ClassificationAlgorithms</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Decision_Trees">https://w3id.org/skgo/modsci#Decision_Trees</seealso>
    let Decision_Trees = Prefixed_Name(modsci, "Decision_Trees") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Decomposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#BiologicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Decomposition">https://w3id.org/skgo/modsci#Decomposition</seealso>
    let Decomposition = Prefixed_Name(modsci, "Decomposition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Deep_Learning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificMethod</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Deep_Learning">https://w3id.org/skgo/modsci#Deep_Learning</seealso>
    let Deep_Learning = Prefixed_Name(modsci, "Deep_Learning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Dentistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dentistry, also known as Dental and Oral Medicine, is a branch of medicine that consists of the study, diagnosis, prevention, and treatment of diseases, disorders, and conditions of the oral cavity, commonly in the dentition but also the oral mucosa, and of adjacent and related structures and tissues, particularly in the maxillofacial (jaw and facial) area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dentistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Dentistry">https://w3id.org/skgo/modsci#Dentistry</seealso>
    let Dentistry = Prefixed_Name(modsci, "Dentistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DevelopmentalBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Developmental biology is the study of the process by which animals and plants grow and develop."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Developmental Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DevelopmentalBiology">https://w3id.org/skgo/modsci#DevelopmentalBiology</seealso>
    let DevelopmentalBiology =
        Prefixed_Name(modsci, "DevelopmentalBiology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DifferentialEquations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DifferentialEquations">https://w3id.org/skgo/modsci#DifferentialEquations</seealso>
    let DifferentialEquations =
        Prefixed_Name(modsci, "DifferentialEquations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DiscoveryOfMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DiscoveryOfMethods">https://w3id.org/skgo/modsci#DiscoveryOfMethods</seealso>
    let DiscoveryOfMethods = Prefixed_Name(modsci, "DiscoveryOfMethods") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DiscoveryOfPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DiscoveryOfPhenomenon">https://w3id.org/skgo/modsci#DiscoveryOfPhenomenon</seealso>
    let DiscoveryOfPhenomenon =
        Prefixed_Name(modsci, "DiscoveryOfPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DiscreteMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DiscreteMathematics">https://w3id.org/skgo/modsci#DiscreteMathematics</seealso>
    let DiscreteMathematics =
        Prefixed_Name(modsci, "DiscreteMathematics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DistributedComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Distributed computing is a field of computer science that studies distributed systems. A distributed system is a system whose components are located on different networked computers, which communicate and coordinate their actions by passing messages to one another."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Distributed Computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DistributedComputing">https://w3id.org/skgo/modsci#DistributedComputing</seealso>
    let DistributedComputing =
        Prefixed_Name(modsci, "DistributedComputing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#DistributedSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Systems in which several computations are executing simultaneously, and potentially interacting with each other."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concurrent, Parallel, and Distributed systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#DistributedSystems">https://w3id.org/skgo/modsci#DistributedSystems</seealso>
    let DistributedSystems = Prefixed_Name(modsci, "DistributedSystems") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Dynamo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Dynamo">https://w3id.org/skgo/modsci#Dynamo</seealso>
    let Dynamo = Prefixed_Name(modsci, "Dynamo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Dynamometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Dynamometer">https://w3id.org/skgo/modsci#Dynamometer</seealso>
    let Dynamometer = Prefixed_Name(modsci, "Dynamometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#E3G</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#E3G">https://w3id.org/skgo/modsci#E3G</seealso>
    let E3G = Prefixed_Name(modsci, "E3G") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#EACSL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EACSL">https://w3id.org/skgo/modsci#EACSL</seealso>
    let EACSL = Prefixed_Name(modsci, "EACSL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#EarthScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Earth science (also known as geoscience, the geosciences, or the Earth sciences) includes all the sciences related to the planet Earth."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Earth Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EarthScience">https://w3id.org/skgo/modsci#EarthScience</seealso>
    let EarthScience = Prefixed_Name(modsci, "EarthScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Earthquake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#GeologicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Earthquake">https://w3id.org/skgo/modsci#Earthquake</seealso>
    let Earthquake = Prefixed_Name(modsci, "Earthquake") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#EcologicalApplications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EcologicalApplications">https://w3id.org/skgo/modsci#EcologicalApplications</seealso>
    let EcologicalApplications =
        Prefixed_Name(modsci, "EcologicalApplications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Ecology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ecology is the branch of science that studies the distribution and interactions between living things and the physical environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ecology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ecology">https://w3id.org/skgo/modsci#Ecology</seealso>
    let Ecology = Prefixed_Name(modsci, "Ecology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Economic_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Economics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Economic_Studies">https://w3id.org/skgo/modsci#Economic_Studies</seealso>
    let Economic_Studies = Prefixed_Name(modsci, "Economic_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Economics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Economics is the social science that studies the production, distribution, and consumption of goods and services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Economics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Economics">https://w3id.org/skgo/modsci#Economics</seealso>
    let Economics = Prefixed_Name(modsci, "Economics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Education is the teaching or learning of knowledge, especially to develop the reasoning, judgement and skill required in adult life and professional occupations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Education"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Education">https://w3id.org/skgo/modsci#Education</seealso>
    let Education = Prefixed_Name(modsci, "Education") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ElectroanalyticalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ElectroanalyticalChemistry">https://w3id.org/skgo/modsci#ElectroanalyticalChemistry</seealso>
    let ElectroanalyticalChemistry =
        Prefixed_Name(modsci, "ElectroanalyticalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Electrochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Electrochemistry">https://w3id.org/skgo/modsci#Electrochemistry</seealso>
    let Electrochemistry = Prefixed_Name(modsci, "Electrochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Electrodynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Electrodynamics">https://w3id.org/skgo/modsci#Electrodynamics</seealso>
    let Electrodynamics = Prefixed_Name(modsci, "Electrodynamics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Electrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Electrometer">https://w3id.org/skgo/modsci#Electrometer</seealso>
    let Electrometer = Prefixed_Name(modsci, "Electrometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Electroscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Electroscope">https://w3id.org/skgo/modsci#Electroscope</seealso>
    let Electroscope = Prefixed_Name(modsci, "Electroscope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Electrostatics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Electrostatics">https://w3id.org/skgo/modsci#Electrostatics</seealso>
    let Electrostatics = Prefixed_Name(modsci, "Electrostatics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Elementar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Elementar">https://w3id.org/skgo/modsci#Elementar</seealso>
    let Elementar = Prefixed_Name(modsci, "Elementar") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ellipsometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ellipsometer">https://w3id.org/skgo/modsci#Ellipsometer</seealso>
    let Ellipsometer = Prefixed_Name(modsci, "Ellipsometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Engineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Engineering is the practical application of science. This is accomplished through knowledge, mathematics, and practical experience applied to the design of useful objects or processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Engineering">https://w3id.org/skgo/modsci#Engineering</seealso>
    let Engineering = Prefixed_Name(modsci, "Engineering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Engineering_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Engineering</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Engineering_Studies">https://w3id.org/skgo/modsci#Engineering_Studies</seealso>
    let Engineering_Studies =
        Prefixed_Name(modsci, "Engineering_Studies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#EnvironmentalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Environmental chemistry is the scientific study of the physical, chemical and biochemical properties and processes of polluting substances in the environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environmental Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EnvironmentalChemistry">https://w3id.org/skgo/modsci#EnvironmentalChemistry</seealso>
    let EnvironmentalChemistry =
        Prefixed_Name(modsci, "EnvironmentalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#EnvironmentalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Environmental science is the science of the interactions between the physical, chemical, and biological components of the environment, but with particular attention to the effects of humans on the natural environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environmental Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EnvironmentalScience">https://w3id.org/skgo/modsci#EnvironmentalScience</seealso>
    let EnvironmentalScience =
        Prefixed_Name(modsci, "EnvironmentalScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Epidemiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Epidemiology is the study and analysis of the distribution (who, when, and where), patterns and determinants of health and disease conditions in defined populations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Epidemiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Epidemiology">https://w3id.org/skgo/modsci#Epidemiology</seealso>
    let Epidemiology = Prefixed_Name(modsci, "Epidemiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ergonomics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Human factors and ergonomics is the application of psychological and physiological principles to the (engineering and) design of products, processes, and systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ergonomics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ergonomics">https://w3id.org/skgo/modsci#Ergonomics</seealso>
    let Ergonomics = Prefixed_Name(modsci, "Ergonomics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Erosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#GeologicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Erosion">https://w3id.org/skgo/modsci#Erosion</seealso>
    let Erosion = Prefixed_Name(modsci, "Erosion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#EthnicStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ethnic studies, in the United States, is the interdisciplinary study of difference—chiefly race, ethnicity, and nation, but also sexuality, gender, and other such markings—and power, as expressed by the state, by civil society, and by individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ethnic Studies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EthnicStudies">https://w3id.org/skgo/modsci#EthnicStudies</seealso>
    let EthnicStudies = Prefixed_Name(modsci, "EthnicStudies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ethnobiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ethnobiology is the scientific study of the way living things are treated or used by different human cultures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ethnobiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ethnobiology">https://w3id.org/skgo/modsci#Ethnobiology</seealso>
    let Ethnobiology = Prefixed_Name(modsci, "Ethnobiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ethnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ethnology is the science that analyzes human cultures and compares them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ethnology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ethnology">https://w3id.org/skgo/modsci#Ethnology</seealso>
    let Ethnology = Prefixed_Name(modsci, "Ethnology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ethology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ethology is the scientific and objective study of animal behaviour, usually with a focus on behaviour under natural conditions, and viewing behaviour as an evolutionarily adaptive trait."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ethology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ethology">https://w3id.org/skgo/modsci#Ethology</seealso>
    let Ethology = Prefixed_Name(modsci, "Ethology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Eudiometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Eudiometer">https://w3id.org/skgo/modsci#Eudiometer</seealso>
    let Eudiometer = Prefixed_Name(modsci, "Eudiometer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Evangelista_Torricelli</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Evangelista_Torricelli">https://w3id.org/skgo/modsci#Evangelista_Torricelli</seealso>
    let Evangelista_Torricelli =
        Prefixed_Name(modsci, "Evangelista_Torricelli") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#EvolutionaryBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evolutionary biology is a sub-field of biology concerned with the study of the evolutionary processes that produced the diversity of life on Earth."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evolutionary Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EvolutionaryBiology">https://w3id.org/skgo/modsci#EvolutionaryBiology</seealso>
    let EvolutionaryBiology =
        Prefixed_Name(modsci, "EvolutionaryBiology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#EvolutionaryComputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In computer science, evolutionary computation is a family of algorithms for global optimization inspired by biological evolution, and the subfield of artificial intelligence and soft computing studying these algorithms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evolutionary Computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EvolutionaryComputation">https://w3id.org/skgo/modsci#EvolutionaryComputation</seealso>
    let EvolutionaryComputation =
        Prefixed_Name(modsci, "EvolutionaryComputation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#EvolutionaryPsychology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evolutionary psychology is a theoretical approach in the social and natural sciences that examines psychological structure from a modern evolutionary perspective."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Evolutionary Psychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#EvolutionaryPsychology">https://w3id.org/skgo/modsci#EvolutionaryPsychology</seealso>
    let EvolutionaryPsychology =
        Prefixed_Name(modsci, "EvolutionaryPsychology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ExperimentalPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Experimental physics is the category of disciplines and sub-disciplines in the field of physics that are concerned with the observation of physical phenomena and experiments."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Experimental Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ExperimentalPhysics">https://w3id.org/skgo/modsci#ExperimentalPhysics</seealso>
    let ExperimentalPhysics =
        Prefixed_Name(modsci, "ExperimentalPhysics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ExtragalacticAstronomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the study of all astronomical objects which are not covered by galactic astronomy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Extragalactic Astronomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ExtragalacticAstronomy">https://w3id.org/skgo/modsci#ExtragalacticAstronomy</seealso>
    let ExtragalacticAstronomy =
        Prefixed_Name(modsci, "ExtragalacticAstronomy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ExtraterrestrialGeology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ExtraterrestrialGeology">https://w3id.org/skgo/modsci#ExtraterrestrialGeology</seealso>
    let ExtraterrestrialGeology =
        Prefixed_Name(modsci, "ExtraterrestrialGeology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#FinancialMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FinancialMathematics">https://w3id.org/skgo/modsci#FinancialMathematics</seealso>
    let FinancialMathematics =
        Prefixed_Name(modsci, "FinancialMathematics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Fire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ChemicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Fire">https://w3id.org/skgo/modsci#Fire</seealso>
    let Fire = Prefixed_Name(modsci, "Fire") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#FisheriesSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FisheriesSciences">https://w3id.org/skgo/modsci#FisheriesSciences</seealso>
    let FisheriesSciences = Prefixed_Name(modsci, "FisheriesSciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#FlowAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FlowAnalysis">https://w3id.org/skgo/modsci#FlowAnalysis</seealso>
    let FlowAnalysis = Prefixed_Name(modsci, "FlowAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#FluidPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FluidPhysics">https://w3id.org/skgo/modsci#FluidPhysics</seealso>
    let FluidPhysics = Prefixed_Name(modsci, "FluidPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#FoodChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Food chemistry is the study of chemical processes and interactions of all biological and non-biological components of foods."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Food Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FoodChemistry">https://w3id.org/skgo/modsci#FoodChemistry</seealso>
    let FoodChemistry = Prefixed_Name(modsci, "FoodChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Forensics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Forensic science, also known as criminalistics, is the application of science to criminal and civil laws, mainly—on the criminal side—during criminal investigation, as governed by the legal standards of admissible evidence and criminal procedure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Forensics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Forensics">https://w3id.org/skgo/modsci#Forensics</seealso>
    let Forensics = Prefixed_Name(modsci, "Forensics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Forestry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Forestry is the art, science, and practice of studying and managing forests and related natural resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Forestry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Forestry">https://w3id.org/skgo/modsci#Forestry</seealso>
    let Forestry = Prefixed_Name(modsci, "Forestry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ForestrySciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ForestrySciences">https://w3id.org/skgo/modsci#ForestrySciences</seealso>
    let ForestrySciences = Prefixed_Name(modsci, "ForestrySciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#FormalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formal sciences are a branch of science studying formal language disciplines concerned with formal systems, such as logic, mathematics, statistics, theoretical computer science, artificial intelligence, information theory, game theory, systems theory, decision theory, and theoretical linguistics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Formal Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FormalScience">https://w3id.org/skgo/modsci#FormalScience</seealso>
    let FormalScience = Prefixed_Name(modsci, "FormalScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Fraunhofer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Fraunhofer">https://w3id.org/skgo/modsci#Fraunhofer</seealso>
    let Fraunhofer = Prefixed_Name(modsci, "Fraunhofer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#FreeRadicalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FreeRadicalChemistry">https://w3id.org/skgo/modsci#FreeRadicalChemistry</seealso>
    let FreeRadicalChemistry =
        Prefixed_Name(modsci, "FreeRadicalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Freezing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Freezing">https://w3id.org/skgo/modsci#Freezing</seealso>
    let Freezing = Prefixed_Name(modsci, "Freezing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Friedrich_Drexler</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Friedrich_Drexler">https://w3id.org/skgo/modsci#Friedrich_Drexler</seealso>
    let Friedrich_Drexler = Prefixed_Name(modsci, "Friedrich_Drexler") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#FunctionalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#FunctionalAnalysis">https://w3id.org/skgo/modsci#FunctionalAnalysis</seealso>
    let FunctionalAnalysis = Prefixed_Name(modsci, "FunctionalAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#GalacticAstronomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The study of everything outside our galaxy, including all other galaxies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Galactic Astronomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#GalacticAstronomy">https://w3id.org/skgo/modsci#GalacticAstronomy</seealso>
    let GalacticAstronomy = Prefixed_Name(modsci, "GalacticAstronomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Galileo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Galileo">https://w3id.org/skgo/modsci#Galileo</seealso>
    let Galileo = Prefixed_Name(modsci, "Galileo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Galvanometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Galvanometer">https://w3id.org/skgo/modsci#Galvanometer</seealso>
    let Galvanometer = Prefixed_Name(modsci, "Galvanometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Genetic_algorithms</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificMethod</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Genetic_algorithms">https://w3id.org/skgo/modsci#Genetic_algorithms</seealso>
    let Genetic_algorithms = Prefixed_Name(modsci, "Genetic_algorithms") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Genetics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Genetics is the study of genes, heredity, and the variation of organisms, as well as the medical practice of diagnosing, treating, and counseling patients with genetic disorders."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Genetics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Genetics">https://w3id.org/skgo/modsci#Genetics</seealso>
    let Genetics = Prefixed_Name(modsci, "Genetics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geochemistry is the science that uses the tools and principles of chemistry to explain the mechanisms behind major geological systems such as the Earth's crust and its oceans."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geochemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geochemistry">https://w3id.org/skgo/modsci#Geochemistry</seealso>
    let Geochemistry = Prefixed_Name(modsci, "Geochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geochronology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geochronology">https://w3id.org/skgo/modsci#Geochronology</seealso>
    let Geochronology = Prefixed_Name(modsci, "Geochronology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geodesy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geodesy is the Earth science of accurately measuring and understanding Earth's geometric shape, orientation in space and gravitational field."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geodesy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geodesy">https://w3id.org/skgo/modsci#Geodesy</seealso>
    let Geodesy = Prefixed_Name(modsci, "Geodesy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geodynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geodynamics">https://w3id.org/skgo/modsci#Geodynamics</seealso>
    let Geodynamics = Prefixed_Name(modsci, "Geodynamics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geography is a field of science devoted to the study of the lands, features, inhabitants, and phenomena of the Earth and planets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geography">https://w3id.org/skgo/modsci#Geography</seealso>
    let Geography = Prefixed_Name(modsci, "Geography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#GeologicalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A geological phenomenon is a phenomenon which is explained by or sheds light on the science of geology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geological Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#GeologicalPhenomena">https://w3id.org/skgo/modsci#GeologicalPhenomena</seealso>
    let GeologicalPhenomena =
        Prefixed_Name(modsci, "GeologicalPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#GeologicalSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Geological Sciences examine the physical and chemical processes within Earth and on its surface, including the study of natural resources and risks to habitable areas."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geological Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#GeologicalSciences">https://w3id.org/skgo/modsci#GeologicalSciences</seealso>
    let GeologicalSciences = Prefixed_Name(modsci, "GeologicalSciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geological_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Geology</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geological_Studies">https://w3id.org/skgo/modsci#Geological_Studies</seealso>
    let Geological_Studies = Prefixed_Name(modsci, "Geological_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geology is an earth science concerned with the solid Earth, the rocks of which it is composed, and the processes by which they change over time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geology">https://w3id.org/skgo/modsci#Geology</seealso>
    let Geology = Prefixed_Name(modsci, "Geology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geomorphology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geomorphology is the science of surface features and landforms including the forces and processes that create them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geomorphology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geomorphology">https://w3id.org/skgo/modsci#Geomorphology</seealso>
    let Geomorphology = Prefixed_Name(modsci, "Geomorphology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#GeophysicalFluidDynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#GeophysicalFluidDynamics">https://w3id.org/skgo/modsci#GeophysicalFluidDynamics</seealso>
    let GeophysicalFluidDynamics =
        Prefixed_Name(modsci, "GeophysicalFluidDynamics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Geophysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geophysics the physics of the Earth and its environment in space, and study of earth sciences using quantitative physics methods."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geophysics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geophysics">https://w3id.org/skgo/modsci#Geophysics</seealso>
    let Geophysics = Prefixed_Name(modsci, "Geophysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Geothermics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Geothermics">https://w3id.org/skgo/modsci#Geothermics</seealso>
    let Geothermics = Prefixed_Name(modsci, "Geothermics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Gerontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gerontology is the study of the social, cultural, psychological, cognitive, and biological aspects of ageing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gerontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Gerontology">https://w3id.org/skgo/modsci#Gerontology</seealso>
    let Gerontology = Prefixed_Name(modsci, "Gerontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Glaciology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Glaciology is the scientific study of glaciers, or more generally ice and natural phenomena that involve ice."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glaciology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Glaciology">https://w3id.org/skgo/modsci#Glaciology</seealso>
    let Glaciology = Prefixed_Name(modsci, "Glaciology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#GlobalInformationSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#GlobalInformationSystems">https://w3id.org/skgo/modsci#GlobalInformationSystems</seealso>
    let GlobalInformationSystems =
        Prefixed_Name(modsci, "GlobalInformationSystems") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Gravimetrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Gravimetrics">https://w3id.org/skgo/modsci#Gravimetrics</seealso>
    let Gravimetrics = Prefixed_Name(modsci, "Gravimetrics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Gravitometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Gravitometer">https://w3id.org/skgo/modsci#Gravitometer</seealso>
    let Gravitometer = Prefixed_Name(modsci, "Gravitometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Gravity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Gravity">https://w3id.org/skgo/modsci#Gravity</seealso>
    let Gravity = Prefixed_Name(modsci, "Gravity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#GreenChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Green chemistry is the use of chemistry for pollutant source reduction; the definition encompasses therefore all aspects of chemical processes that reduce impact on human health and on the environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Green Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#GreenChemistry">https://w3id.org/skgo/modsci#GreenChemistry</seealso>
    let GreenChemistry = Prefixed_Name(modsci, "GreenChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Growth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#BiologicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Growth">https://w3id.org/skgo/modsci#Growth</seealso>
    let Growth = Prefixed_Name(modsci, "Growth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Guglielmo_Marconi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Guglielmo_Marconi">https://w3id.org/skgo/modsci#Guglielmo_Marconi</seealso>
    let Guglielmo_Marconi = Prefixed_Name(modsci, "Guglielmo_Marconi") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Haze</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#AtmosphericPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Haze">https://w3id.org/skgo/modsci#Haze</seealso>
    let Haze = Prefixed_Name(modsci, "Haze") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Health</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Health is a state of physical, mental and social well-being in which disease and infirmity are absent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Health"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Health">https://w3id.org/skgo/modsci#Health</seealso>
    let Health = Prefixed_Name(modsci, "Health") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#HealthSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Health sciences are those sciences which focus on health, or health care, as core parts of their subject matter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Health Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#HealthSciences">https://w3id.org/skgo/modsci#HealthSciences</seealso>
    let HealthSciences = Prefixed_Name(modsci, "HealthSciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Healthcare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Healthcare is the maintenance or improvement of health via the prevention, diagnosis, and treatment of disease, illness, injury, and other physical and mental impairments in people."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Healthcare"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Healthcare">https://w3id.org/skgo/modsci#Healthcare</seealso>
    let Healthcare = Prefixed_Name(modsci, "Healthcare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Historical_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#History</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Historical_Studies">https://w3id.org/skgo/modsci#Historical_Studies</seealso>
    let Historical_Studies = Prefixed_Name(modsci, "Historical_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#History</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The history of science is the study of the development of science and scientific knowledge, including both the natural and social sciences (the history of the arts and humanities is termed history of scholarship)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"History of Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#History">https://w3id.org/skgo/modsci#History</seealso>
    let History = Prefixed_Name(modsci, "History") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#HomologicalAlgebra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#HomologicalAlgebra">https://w3id.org/skgo/modsci#HomologicalAlgebra</seealso>
    let HomologicalAlgebra = Prefixed_Name(modsci, "HomologicalAlgebra") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Horiba</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Horiba">https://w3id.org/skgo/modsci#Horiba</seealso>
    let Horiba = Prefixed_Name(modsci, "Horiba") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#HorticulturalProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#HorticulturalProduction">https://w3id.org/skgo/modsci#HorticulturalProduction</seealso>
    let HorticulturalProduction =
        Prefixed_Name(modsci, "HorticulturalProduction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#HumanComputerInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Human–computer interaction (HCI) researches the design and use of computer technology, focused on the interfaces between people (users) and computers. Researchers in the field of HCI observe the ways in which humans interact with computers and design technologies that let humans interact with computers in novel ways."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Human Computer Interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#HumanComputerInteraction">https://w3id.org/skgo/modsci#HumanComputerInteraction</seealso>
    let HumanComputerInteraction =
        Prefixed_Name(modsci, "HumanComputerInteraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#HumanSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Human science is a term applied to the investigation of human life and activities by a rational, systematic and verifiable methodology that acknowledges the validity of both data derived by impartial observation of sensory experience (objective phenomena) and data derived by means of impartial observation of psychological experience (subjective phenomena)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Human Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#HumanSciences">https://w3id.org/skgo/modsci#HumanSciences</seealso>
    let HumanSciences = Prefixed_Name(modsci, "HumanSciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Hydrology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Hydrology is the scientific study of the movement, distribution, and quality of water on Earth and other planets, including the water cycle, water resources and environmental watershed sustainability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hydrology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Hydrology">https://w3id.org/skgo/modsci#Hydrology</seealso>
    let Hydrology = Prefixed_Name(modsci, "Hydrology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Hydrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Hydrometer">https://w3id.org/skgo/modsci#Hydrometer</seealso>
    let Hydrometer = Prefixed_Name(modsci, "Hydrometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ImageProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In computer science, digital image processing is the use of computer algorithms to perform image processing on digital images."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ImageProcessing">https://w3id.org/skgo/modsci#ImageProcessing</seealso>
    let ImageProcessing = Prefixed_Name(modsci, "ImageProcessing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Immunology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Immunology is the study of the immune system and its reaction to pathogens, as well as its malfunctions (autoimmune diseases, allergies, rejection of organ transplants, immune deficiency)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Immunology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Immunology">https://w3id.org/skgo/modsci#Immunology</seealso>
    let Immunology = Prefixed_Name(modsci, "Immunology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Inclinometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Inclinometer">https://w3id.org/skgo/modsci#Inclinometer</seealso>
    let Inclinometer = Prefixed_Name(modsci, "Inclinometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#IndustrialScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An industrial process alters materials or substances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Industrial Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#IndustrialScience">https://w3id.org/skgo/modsci#IndustrialScience</seealso>
    let IndustrialScience = Prefixed_Name(modsci, "IndustrialScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Industry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An industry is a sector that produces goods or related services within an economy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Industry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Industry">https://w3id.org/skgo/modsci#Industry</seealso>
    let Industry = Prefixed_Name(modsci, "Industry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InformationRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InformationRetrieval">https://w3id.org/skgo/modsci#InformationRetrieval</seealso>
    let InformationRetrieval =
        Prefixed_Name(modsci, "InformationRetrieval") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InformationScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information science is a field primarily concerned with the analysis, collection, classification, manipulation, storage, retrieval, movement, dissemination, and protection of information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InformationScience">https://w3id.org/skgo/modsci#InformationScience</seealso>
    let InformationScience = Prefixed_Name(modsci, "InformationScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#InformationSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InformationSystems">https://w3id.org/skgo/modsci#InformationSystems</seealso>
    let InformationSystems = Prefixed_Name(modsci, "InformationSystems") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InformationSystemsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InformationSystemsManagement">https://w3id.org/skgo/modsci#InformationSystemsManagement</seealso>
    let InformationSystemsManagement =
        Prefixed_Name(modsci, "InformationSystemsManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InformationSystemsTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InformationSystemsTheory">https://w3id.org/skgo/modsci#InformationSystemsTheory</seealso>
    let InformationSystemsTheory =
        Prefixed_Name(modsci, "InformationSystemsTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InformationVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information visualization or information visualisation is the study of (interactive) visual representations of abstract data to reinforce human cognition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information Visualization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InformationVisualization">https://w3id.org/skgo/modsci#InformationVisualization</seealso>
    let InformationVisualization =
        Prefixed_Name(modsci, "InformationVisualization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Informetrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Informetrics">https://w3id.org/skgo/modsci#Informetrics</seealso>
    let Informetrics = Prefixed_Name(modsci, "Informetrics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#InorganicChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Inorganic chemistry is a catch-all discipline that covers everything in chemistry that is not organic chemistry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inorganic Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InorganicChemistry">https://w3id.org/skgo/modsci#InorganicChemistry</seealso>
    let InorganicChemistry = Prefixed_Name(modsci, "InorganicChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InorganicGreenChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InorganicGreenChemistry">https://w3id.org/skgo/modsci#InorganicGreenChemistry</seealso>
    let InorganicGreenChemistry =
        Prefixed_Name(modsci, "InorganicGreenChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tool or implement, especially one for precision work."</para>
    /// labels<para>"Instrument"</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Instrument">https://w3id.org/skgo/modsci#Instrument</seealso>
    let Instrument = Prefixed_Name(modsci, "Instrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InstrumentFunctionDesription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InstrumentFunctionDesription">https://w3id.org/skgo/modsci#InstrumentFunctionDesription</seealso>
    let InstrumentFunctionDesription =
        Prefixed_Name(modsci, "InstrumentFunctionDesription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#IntegralEquations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#IntegralEquations">https://w3id.org/skgo/modsci#IntegralEquations</seealso>
    let IntegralEquations = Prefixed_Name(modsci, "IntegralEquations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InterdisciplinaryStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Interdisciplinarity or interdisciplinary studies involves the combining of two or more academic disciplines into one activity (e.g., a research project)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interdisciplinary Studies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InterdisciplinaryStudies">https://w3id.org/skgo/modsci#InterdisciplinaryStudies</seealso>
    let InterdisciplinaryStudies =
        Prefixed_Name(modsci, "InterdisciplinaryStudies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Interferometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Interferometer">https://w3id.org/skgo/modsci#Interferometer</seealso>
    let Interferometer = Prefixed_Name(modsci, "Interferometer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#InterorganisationalInformationSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#InterorganisationalInformationSystems">https://w3id.org/skgo/modsci#InterorganisationalInformationSystems</seealso>
    let InterorganisationalInformationSystems =
        Prefixed_Name(modsci, "InterorganisationalInformationSystems") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Isaac_Newton</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Isaac_Newton">https://w3id.org/skgo/modsci#Isaac_Newton</seealso>
    let Isaac_Newton = Prefixed_Name(modsci, "Isaac_Newton") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Johann_Schweigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Johann_Schweigger">https://w3id.org/skgo/modsci#Johann_Schweigger</seealso>
    let Johann_Schweigger = Prefixed_Name(modsci, "Johann_Schweigger") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Julius_von_Mayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Julius_von_Mayer">https://w3id.org/skgo/modsci#Julius_von_Mayer</seealso>
    let Julius_von_Mayer = Prefixed_Name(modsci, "Julius_von_Mayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#KNN_Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ClassificationAlgorithms</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#KNN_Algorithm">https://w3id.org/skgo/modsci#KNN_Algorithm</seealso>
    let KNN_Algorithm = Prefixed_Name(modsci, "KNN_Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#KnowledgeSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#KnowledgeSystems">https://w3id.org/skgo/modsci#KnowledgeSystems</seealso>
    let KnowledgeSystems = Prefixed_Name(modsci, "KnowledgeSystems") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#LECO_Corporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#LECO_Corporation">https://w3id.org/skgo/modsci#LECO_Corporation</seealso>
    let LECO_Corporation = Prefixed_Name(modsci, "LECO_Corporation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#LaboratoryInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instrument needed for operations in various laboratories, synthesis and analysis."</para>
    /// labels<para>"Laboratory Instrument"</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#LaboratoryInstrument">https://w3id.org/skgo/modsci#LaboratoryInstrument</seealso>
    let LaboratoryInstrument =
        Prefixed_Name(modsci, "LaboratoryInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Lasers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Lasers">https://w3id.org/skgo/modsci#Lasers</seealso>
    let Lasers = Prefixed_Name(modsci, "Lasers") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#LibraryScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Library science is an interdisciplinary or multidisciplinary field that applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries; the collection, organization, preservation, and dissemination of information resources; and the political economy of information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Library Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#LibraryScience">https://w3id.org/skgo/modsci#LibraryScience</seealso>
    let LibraryScience = Prefixed_Name(modsci, "LibraryScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Light_Bulb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificDiscovery</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Light_Bulb">https://w3id.org/skgo/modsci#Light_Bulb</seealso>
    let Light_Bulb = Prefixed_Name(modsci, "Light_Bulb") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Light_magnification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Astronomy</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Light_magnification">https://w3id.org/skgo/modsci#Light_magnification</seealso>
    let Light_magnification =
        Prefixed_Name(modsci, "Light_magnification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Light_pillar</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#AtmosphericPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Light_pillar">https://w3id.org/skgo/modsci#Light_pillar</seealso>
    let Light_pillar = Prefixed_Name(modsci, "Light_pillar") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Limnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Limnology is a discipline that concerns the study of fresh waters, specifically natural and constructed lakes, ponds, streams, and rivers,"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limnology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Limnology">https://w3id.org/skgo/modsci#Limnology</seealso>
    let Limnology = Prefixed_Name(modsci, "Limnology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Linear_Regression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Linear_Regression">https://w3id.org/skgo/modsci#Linear_Regression</seealso>
    let Linear_Regression = Prefixed_Name(modsci, "Linear_Regression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Linguistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Linguistics is the scientific study of language."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linguistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Linguistics">https://w3id.org/skgo/modsci#Linguistics</seealso>
    let Linguistics = Prefixed_Name(modsci, "Linguistics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Logic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Logic is the study of reasoning, or the study of the principles and criteria of valid inference and demonstration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Logic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Logic">https://w3id.org/skgo/modsci#Logic</seealso>
    let Logic = Prefixed_Name(modsci, "Logic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MachineLearning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Machine learning (ML) is the scientific study of algorithms and statistical models that computer systems use to perform a specific task without using explicit instructions, relying on patterns and inference instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Machine Learning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MachineLearning">https://w3id.org/skgo/modsci#MachineLearning</seealso>
    let MachineLearning = Prefixed_Name(modsci, "MachineLearning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Magnetism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Magnetism">https://w3id.org/skgo/modsci#Magnetism</seealso>
    let Magnetism = Prefixed_Name(modsci, "Magnetism") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Magnetograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Magnetograph">https://w3id.org/skgo/modsci#Magnetograph</seealso>
    let Magnetograph = Prefixed_Name(modsci, "Magnetograph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Magnetometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Magnetometer">https://w3id.org/skgo/modsci#Magnetometer</seealso>
    let Magnetometer = Prefixed_Name(modsci, "Magnetometer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MainGroupMetalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MainGroupMetalChemistry">https://w3id.org/skgo/modsci#MainGroupMetalChemistry</seealso>
    let MainGroupMetalChemistry =
        Prefixed_Name(modsci, "MainGroupMetalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MalvernInstruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MalvernInstruments">https://w3id.org/skgo/modsci#MalvernInstruments</seealso>
    let MalvernInstruments = Prefixed_Name(modsci, "MalvernInstruments") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Manometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Manometer">https://w3id.org/skgo/modsci#Manometer</seealso>
    let Manometer = Prefixed_Name(modsci, "Manometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MarineBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Marine biology is the scientific study of organisms that live in the ocean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Marine Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MarineBiology">https://w3id.org/skgo/modsci#MarineBiology</seealso>
    let MarineBiology = Prefixed_Name(modsci, "MarineBiology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MarkesInternational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MarkesInternational">https://w3id.org/skgo/modsci#MarkesInternational</seealso>
    let MarkesInternational =
        Prefixed_Name(modsci, "MarkesInternational") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MarkupLanguages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MarkupLanguages">https://w3id.org/skgo/modsci#MarkupLanguages</seealso>
    let MarkupLanguages = Prefixed_Name(modsci, "MarkupLanguages") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MaterialsChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The interdisciplinary field of materials science is the design and discovery of new materials, particularly solids."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Materials Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MaterialsChemistry">https://w3id.org/skgo/modsci#MaterialsChemistry</seealso>
    let MaterialsChemistry = Prefixed_Name(modsci, "MaterialsChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MathematicalAndTheoreticalBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mathematical and theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mathematical and Theoretical Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MathematicalAndTheoreticalBiology">https://w3id.org/skgo/modsci#MathematicalAndTheoreticalBiology</seealso>
    let MathematicalAndTheoreticalBiology =
        Prefixed_Name(modsci, "MathematicalAndTheoreticalBiology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MathematicalLogic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MathematicalLogic">https://w3id.org/skgo/modsci#MathematicalLogic</seealso>
    let MathematicalLogic = Prefixed_Name(modsci, "MathematicalLogic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MathematicalPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mathematical physics refers to the development of mathematical methods for application to problems in physics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mathematical Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MathematicalPhysics">https://w3id.org/skgo/modsci#MathematicalPhysics</seealso>
    let MathematicalPhysics =
        Prefixed_Name(modsci, "MathematicalPhysics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Mathematical_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Mathematics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Mathematical_Studies">https://w3id.org/skgo/modsci#Mathematical_Studies</seealso>
    let Mathematical_Studies =
        Prefixed_Name(modsci, "Mathematical_Studies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Mathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mathematics (colloquially, maths, or math), is the body of knowledge centered on concepts such as quantity, structure, space, and change, and also the academic discipline that studies them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mathematics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Mathematics">https://w3id.org/skgo/modsci#Mathematics</seealso>
    let Mathematics = Prefixed_Name(modsci, "Mathematics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#McPhersonInc</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#McPhersonInc">https://w3id.org/skgo/modsci#McPhersonInc</seealso>
    let McPhersonInc = Prefixed_Name(modsci, "McPhersonInc") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measurement is the assignment of a number to a characteristic of an object or event, which can be compared with other objects or events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Measurement">https://w3id.org/skgo/modsci#Measurement</seealso>
    let Measurement = Prefixed_Name(modsci, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Mechanics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mechanics is the branch of science concerned with the behavior of physical bodies when subjected to forces or displacements, and the subsequent effects of the bodies on their environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mechanics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Mechanics">https://w3id.org/skgo/modsci#Mechanics</seealso>
    let Mechanics = Prefixed_Name(modsci, "Mechanics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MechanismsOfReactions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MechanismsOfReactions">https://w3id.org/skgo/modsci#MechanismsOfReactions</seealso>
    let MechanismsOfReactions =
        Prefixed_Name(modsci, "MechanismsOfReactions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MedicinalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Medicinal chemistry and pharmaceutical chemistry are disciplines at the intersection of chemistry, especially synthetic organic chemistry, and pharmacology and various other biological specialties, where they are involved with design, chemical synthesis and development for market of pharmaceutical agents, or bio-active molecules (drugs)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Medicinal Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MedicinalChemistry">https://w3id.org/skgo/modsci#MedicinalChemistry</seealso>
    let MedicinalChemistry = Prefixed_Name(modsci, "MedicinalChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Medicine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Medicine is a branch of health science concerned with maintaining human health and restoring it by treating disease and injury; it is both an area of knowledge, a science of body systems and diseases and their treatment, and the applied practice of that knowledge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Medicine">https://w3id.org/skgo/modsci#Medicine</seealso>
    let Medicine = Prefixed_Name(modsci, "Medicine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Metabolism</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#BiologicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Metabolism is the set of life-sustaining chemical reactions in organisms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metabolism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Metabolism">https://w3id.org/skgo/modsci#Metabolism</seealso>
    let Metabolism = Prefixed_Name(modsci, "Metabolism") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Metallurgy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metallurgy is a domain of materials science and engineering that studies the physical and chemical behavior of metallic elements, their inter-metallic compounds, and their mixtures, which are called alloys."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metallurgy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Metallurgy">https://w3id.org/skgo/modsci#Metallurgy</seealso>
    let Metallurgy = Prefixed_Name(modsci, "Metallurgy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MetamorphicPetrology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MetamorphicPetrology">https://w3id.org/skgo/modsci#MetamorphicPetrology</seealso>
    let MetamorphicPetrology =
        Prefixed_Name(modsci, "MetamorphicPetrology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MeteorologicalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Meteorological Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MeteorologicalPhenomena">https://w3id.org/skgo/modsci#MeteorologicalPhenomena</seealso>
    let MeteorologicalPhenomena =
        Prefixed_Name(modsci, "MeteorologicalPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MetrologicalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MetrologicalChemistry">https://w3id.org/skgo/modsci#MetrologicalChemistry</seealso>
    let MetrologicalChemistry =
        Prefixed_Name(modsci, "MetrologicalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Metrology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metrology is the science of measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metrology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Metrology">https://w3id.org/skgo/modsci#Metrology</seealso>
    let Metrology = Prefixed_Name(modsci, "Metrology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Michael_Faraday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Michael_Faraday">https://w3id.org/skgo/modsci#Michael_Faraday</seealso>
    let Michael_Faraday = Prefixed_Name(modsci, "Michael_Faraday") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Micrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Micrometer">https://w3id.org/skgo/modsci#Micrometer</seealso>
    let Micrometer = Prefixed_Name(modsci, "Micrometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Microscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Microscope">https://w3id.org/skgo/modsci#Microscope</seealso>
    let Microscope = Prefixed_Name(modsci, "Microscope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MilitaryScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Military science is the study of military processes, dentsciitutions, and behavior, along with the study of warfare, and the theory and application of organized coercive force."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Military Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MilitaryScience">https://w3id.org/skgo/modsci#MilitaryScience</seealso>
    let MilitaryScience = Prefixed_Name(modsci, "MilitaryScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Mineralogy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Mineralogy">https://w3id.org/skgo/modsci#Mineralogy</seealso>
    let Mineralogy = Prefixed_Name(modsci, "Mineralogy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MobileTechnologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MobileTechnologies">https://w3id.org/skgo/modsci#MobileTechnologies</seealso>
    let MobileTechnologies = Prefixed_Name(modsci, "MobileTechnologies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ModernScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Science is a systematic enterprise that builds and organizes knowledge in the form of testable explanations and predictions about the universe."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ModernScience">https://w3id.org/skgo/modsci#ModernScience</seealso>
    let ModernScience = Prefixed_Name(modsci, "ModernScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MolecularBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Molecular biology is the study of biology at a molecular level."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molecular Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MolecularBiology">https://w3id.org/skgo/modsci#MolecularBiology</seealso>
    let MolecularBiology = Prefixed_Name(modsci, "MolecularBiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#MolecularPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Molecular physics deals with the physics and chemistry of molecules."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Molecular Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MolecularPhysics">https://w3id.org/skgo/modsci#MolecularPhysics</seealso>
    let MolecularPhysics = Prefixed_Name(modsci, "MolecularPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Movie_camera</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificDiscovery</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Movie_camera">https://w3id.org/skgo/modsci#Movie_camera</seealso>
    let Movie_camera = Prefixed_Name(modsci, "Movie_camera") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#MultimediaProgramming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#MultimediaProgramming">https://w3id.org/skgo/modsci#MultimediaProgramming</seealso>
    let MultimediaProgramming =
        Prefixed_Name(modsci, "MultimediaProgramming") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Museology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Museology or museum studies is the study of museums. It explores the history of museums and their role in society, as well as the activities they engage in, including curating, preservation, public programming, and education."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Museology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Museology">https://w3id.org/skgo/modsci#Museology</seealso>
    let Museology = Prefixed_Name(modsci, "Museology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#NASA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NASA">https://w3id.org/skgo/modsci#NASA</seealso>
    let NASA = Prefixed_Name(modsci, "NASA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Nanochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Nanochemistry">https://w3id.org/skgo/modsci#Nanochemistry</seealso>
    let Nanochemistry = Prefixed_Name(modsci, "Nanochemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#NaturalLanguageProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Natural language processing (NLP) is a subfield of linguistics, computer science, information engineering, and artificial intelligence concerned with the interactions between computers and human (natural) languages, in particular how to program computers to process and analyze large amounts of natural language data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Natural language processing (NLP)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NaturalLanguageProcessing">https://w3id.org/skgo/modsci#NaturalLanguageProcessing</seealso>
    let NaturalLanguageProcessing =
        Prefixed_Name(modsci, "NaturalLanguageProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#NaturalPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Natural phenomena include gravity, tides, biological processes and oscillation."</para>
    /// labels<para>"Natural Phenomenon"</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NaturalPhenomenon">https://w3id.org/skgo/modsci#NaturalPhenomenon</seealso>
    let NaturalPhenomenon = Prefixed_Name(modsci, "NaturalPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#NaturalProductsChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NaturalProductsChemistry">https://w3id.org/skgo/modsci#NaturalProductsChemistry</seealso>
    let NaturalProductsChemistry =
        Prefixed_Name(modsci, "NaturalProductsChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#NaturalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The natural sciences are those branches of empirical science that produce a comprehension of the natural world through the use of data collected from it by observation and measurement to construct deterministic and/or stochastic quantitative models of its phenomena."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Natural Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NaturalScience">https://w3id.org/skgo/modsci#NaturalScience</seealso>
    let NaturalScience = Prefixed_Name(modsci, "NaturalScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Networking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A computer network is a digital telecommunications network which allows nodes to share resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Networking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Networking">https://w3id.org/skgo/modsci#Networking</seealso>
    let Networking = Prefixed_Name(modsci, "Networking") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#NeuralEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Neural engineering is a discipline within biomedical engineering that uses engineering techniques to understand, repair, replace, or enhance neural systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neural Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NeuralEngineering">https://w3id.org/skgo/modsci#NeuralEngineering</seealso>
    let NeuralEngineering = Prefixed_Name(modsci, "NeuralEngineering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Neuroscience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Neuroscience is a field of study which deals with the structure, development, genetics, biochemistry, physiology, pharmacology and pathology of the nervous system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neuroscience"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Neuroscience">https://w3id.org/skgo/modsci#Neuroscience</seealso>
    let Neuroscience = Prefixed_Name(modsci, "Neuroscience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Non-equilibriumProcesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Non-equilibriumProcesses">https://w3id.org/skgo/modsci#Non-equilibriumProcesses</seealso>
    let Non_equilibriumProcesses =
        Prefixed_Name(modsci, "Non-equilibriumProcesses") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Non-metalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Non-metalChemistry">https://w3id.org/skgo/modsci#Non-metalChemistry</seealso>
    let Non_metalChemistry = Prefixed_Name(modsci, "Non-metalChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#NonlinearOptics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NonlinearOptics">https://w3id.org/skgo/modsci#NonlinearOptics</seealso>
    let NonlinearOptics = Prefixed_Name(modsci, "NonlinearOptics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#NovacamTechnologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NovacamTechnologies">https://w3id.org/skgo/modsci#NovacamTechnologies</seealso>
    let NovacamTechnologies =
        Prefixed_Name(modsci, "NovacamTechnologies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#NuclearChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Nuclear chemistry is the subfield of chemistry dealing with radioactivity, nuclear processes, and transformations in the nuclei of atoms, such as nuclear transmutation and nuclear properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nuclear Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NuclearChemistry">https://w3id.org/skgo/modsci#NuclearChemistry</seealso>
    let NuclearChemistry = Prefixed_Name(modsci, "NuclearChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#NuclearPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NuclearPhysics">https://w3id.org/skgo/modsci#NuclearPhysics</seealso>
    let NuclearPhysics = Prefixed_Name(modsci, "NuclearPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#NumberTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NumberTheory">https://w3id.org/skgo/modsci#NumberTheory</seealso>
    let NumberTheory = Prefixed_Name(modsci, "NumberTheory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#NumericalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#NumericalAnalysis">https://w3id.org/skgo/modsci#NumericalAnalysis</seealso>
    let NumericalAnalysis = Prefixed_Name(modsci, "NumericalAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Nursing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Nursing is a profession within the health care sector focused on the care of individuals, families, and communities so they may attain, maintain, or recover optimal health and quality of life."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nursing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Nursing">https://w3id.org/skgo/modsci#Nursing</seealso>
    let Nursing = Prefixed_Name(modsci, "Nursing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ocean_currents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#OceanographicPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ocean_currents">https://w3id.org/skgo/modsci#Ocean_currents</seealso>
    let Ocean_currents = Prefixed_Name(modsci, "Ocean_currents") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OceanographicPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Oceanographic Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OceanographicPhenomena">https://w3id.org/skgo/modsci#OceanographicPhenomena</seealso>
    let OceanographicPhenomena =
        Prefixed_Name(modsci, "OceanographicPhenomena") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Oceanography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Oceanography also known as oceanology, is the study of the physical and biological aspects of the ocean."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oceanography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Oceanography">https://w3id.org/skgo/modsci#Oceanography</seealso>
    let Oceanography = Prefixed_Name(modsci, "Oceanography") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Ohmmeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Ohmmeter">https://w3id.org/skgo/modsci#Ohmmeter</seealso>
    let Ohmmeter = Prefixed_Name(modsci, "Ohmmeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Olaus_Roemer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Olaus_Roemer">https://w3id.org/skgo/modsci#Olaus_Roemer</seealso>
    let Olaus_Roemer = Prefixed_Name(modsci, "Olaus_Roemer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#OpenAI_Inc</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OpenAI_Inc">https://w3id.org/skgo/modsci#OpenAI_Inc</seealso>
    let OpenAI_Inc = Prefixed_Name(modsci, "OpenAI_Inc") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#OperatingSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An operating system (OS) is system software that manages computer hardware, software resources, and provides common services for computer programs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OperatingSystems">https://w3id.org/skgo/modsci#OperatingSystems</seealso>
    let OperatingSystems = Prefixed_Name(modsci, "OperatingSystems") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#OperationsResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OperationsResearch">https://w3id.org/skgo/modsci#OperationsResearch</seealso>
    let OperationsResearch = Prefixed_Name(modsci, "OperationsResearch") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OpticalCommunications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OpticalCommunications">https://w3id.org/skgo/modsci#OpticalCommunications</seealso>
    let OpticalCommunications =
        Prefixed_Name(modsci, "OpticalCommunications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OpticalPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OpticalPhysics">https://w3id.org/skgo/modsci#OpticalPhysics</seealso>
    let OpticalPhysics = Prefixed_Name(modsci, "OpticalPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Optics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Optics is the branch of physics that studies the behaviour and properties of light, including its interactions with matter and the construction of instruments that use or detect it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Optics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Optics">https://w3id.org/skgo/modsci#Optics</seealso>
    let Optics = Prefixed_Name(modsci, "Optics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Optimisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Optimisation">https://w3id.org/skgo/modsci#Optimisation</seealso>
    let Optimisation = Prefixed_Name(modsci, "Optimisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Optoelectronics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Optoelectronics">https://w3id.org/skgo/modsci#Optoelectronics</seealso>
    let Optoelectronics = Prefixed_Name(modsci, "Optoelectronics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OrdinaryDifferentialEquations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OrdinaryDifferentialEquations">https://w3id.org/skgo/modsci#OrdinaryDifferentialEquations</seealso>
    let OrdinaryDifferentialEquations =
        Prefixed_Name(modsci, "OrdinaryDifferentialEquations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OreDepositPetrology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OreDepositPetrology">https://w3id.org/skgo/modsci#OreDepositPetrology</seealso>
    let OreDepositPetrology =
        Prefixed_Name(modsci, "OreDepositPetrology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OrganicChemicalSynthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OrganicChemicalSynthesis">https://w3id.org/skgo/modsci#OrganicChemicalSynthesis</seealso>
    let OrganicChemicalSynthesis =
        Prefixed_Name(modsci, "OrganicChemicalSynthesis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OrganicChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organic chemistry is the study of organic, or carbon based, molecules."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organic Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OrganicChemistry">https://w3id.org/skgo/modsci#OrganicChemistry</seealso>
    let OrganicChemistry = Prefixed_Name(modsci, "OrganicChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OrganicGreenChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OrganicGreenChemistry">https://w3id.org/skgo/modsci#OrganicGreenChemistry</seealso>
    let OrganicGreenChemistry =
        Prefixed_Name(modsci, "OrganicGreenChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#OrganometallicChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organometallic chemistry is the study of chemical compounds containing bonds between carbon and a metal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organometallic Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OrganometallicChemistry">https://w3id.org/skgo/modsci#OrganometallicChemistry</seealso>
    let OrganometallicChemistry =
        Prefixed_Name(modsci, "OrganometallicChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Oscilloscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Oscilloscope">https://w3id.org/skgo/modsci#Oscilloscope</seealso>
    let Oscilloscope = Prefixed_Name(modsci, "Oscilloscope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Overpopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#BiologicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Overpopulation">https://w3id.org/skgo/modsci#Overpopulation</seealso>
    let Overpopulation = Prefixed_Name(modsci, "Overpopulation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#OxfordInstruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#OxfordInstruments">https://w3id.org/skgo/modsci#OxfordInstruments</seealso>
    let OxfordInstruments = Prefixed_Name(modsci, "OxfordInstruments") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Palaeomagnetism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Palaeomagnetism">https://w3id.org/skgo/modsci#Palaeomagnetism</seealso>
    let Palaeomagnetism = Prefixed_Name(modsci, "Palaeomagnetism") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Palaeontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Palaeontology">https://w3id.org/skgo/modsci#Palaeontology</seealso>
    let Palaeontology = Prefixed_Name(modsci, "Palaeontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Paleoclimatology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Paleoclimatology is the study of climates for which systematic measurements were not taken."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paleoclimatology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Paleoclimatology">https://w3id.org/skgo/modsci#Paleoclimatology</seealso>
    let Paleoclimatology = Prefixed_Name(modsci, "Paleoclimatology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Paleontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Paleontology is the study of the developing history of life on earth, of ancient plants and animals based on the fossil record, evidence of their existence preserved in rocks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paleontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Paleontology">https://w3id.org/skgo/modsci#Paleontology</seealso>
    let Paleontology = Prefixed_Name(modsci, "Paleontology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PallCorp</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PallCorp">https://w3id.org/skgo/modsci#PallCorp</seealso>
    let PallCorp = Prefixed_Name(modsci, "PallCorp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Palynology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Palynology is literally the "study of dust" or of "particles that are strewn"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Palynology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Palynology">https://w3id.org/skgo/modsci#Palynology</seealso>
    let Palynology = Prefixed_Name(modsci, "Palynology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ParallelComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parallel computing is a type of computation in which many calculations or the execution of processes are carried out simultaneously."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parallel Computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ParallelComputing">https://w3id.org/skgo/modsci#ParallelComputing</seealso>
    let ParallelComputing = Prefixed_Name(modsci, "ParallelComputing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Parasitology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parasitology is the study of parasites in host organisms, including humans (medical parasitology)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parasitology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Parasitology">https://w3id.org/skgo/modsci#Parasitology</seealso>
    let Parasitology = Prefixed_Name(modsci, "Parasitology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#PartialDifferentialEquations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PartialDifferentialEquations">https://w3id.org/skgo/modsci#PartialDifferentialEquations</seealso>
    let PartialDifferentialEquations =
        Prefixed_Name(modsci, "PartialDifferentialEquations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ParticlePhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Particle physics is a branch of physics that studies the elementary constituents of matter and radiation, and the interactions between them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Particle Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ParticlePhysics">https://w3id.org/skgo/modsci#ParticlePhysics</seealso>
    let ParticlePhysics = Prefixed_Name(modsci, "ParticlePhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PastureProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PastureProduction">https://w3id.org/skgo/modsci#PastureProduction</seealso>
    let PastureProduction = Prefixed_Name(modsci, "PastureProduction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PatternRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PatternRecognition">https://w3id.org/skgo/modsci#PatternRecognition</seealso>
    let PatternRecognition = Prefixed_Name(modsci, "PatternRecognition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PetroleumGeology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PetroleumGeology">https://w3id.org/skgo/modsci#PetroleumGeology</seealso>
    let PetroleumGeology = Prefixed_Name(modsci, "PetroleumGeology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Pharmacology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pharmacology is the study of how chemical substances interact with living systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pharmacology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Pharmacology">https://w3id.org/skgo/modsci#Pharmacology</seealso>
    let Pharmacology = Prefixed_Name(modsci, "Pharmacology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Pharmacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pharmacy is the science and technique of preparing, dispensing, and reviewing drugs and providing additional clinical services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pharmacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Pharmacy">https://w3id.org/skgo/modsci#Pharmacy</seealso>
    let Pharmacy = Prefixed_Name(modsci, "Pharmacy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Philosophy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Philosophy of science is a branch of philosophy concerned with the foundations, methods, and implications of science."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Philosophy of Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Philosophy">https://w3id.org/skgo/modsci#Philosophy</seealso>
    let Philosophy = Prefixed_Name(modsci, "Philosophy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Phonograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Phonograph">https://w3id.org/skgo/modsci#Phonograph</seealso>
    let Phonograph = Prefixed_Name(modsci, "Phonograph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Photochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Photochemistry, a sub-discipline of chemistry, is the study of the interactions between atoms, small molecules, and light (or electromagnetic radiation)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photochemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Photochemistry">https://w3id.org/skgo/modsci#Photochemistry</seealso>
    let Photochemistry = Prefixed_Name(modsci, "Photochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Photonics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Photonics">https://w3id.org/skgo/modsci#Photonics</seealso>
    let Photonics = Prefixed_Name(modsci, "Photonics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Phylogeny</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Phylogenetics is the study of the evolutionary history and relationships among individuals or groups of organisms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phylogeny"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Phylogeny">https://w3id.org/skgo/modsci#Phylogeny</seealso>
    let Phylogeny = Prefixed_Name(modsci, "Phylogeny") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PhysicalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical chemistry is the study of macroscopic, atomic, subatomic, and particulate phenomena in chemical systems in terms of the principles, practices, and concepts of physics such as motion, energy, force, time, thermodynamics, quantum chemistry, statistical mechanics, analytical dynamics and chemical equilibrium."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PhysicalChemistry">https://w3id.org/skgo/modsci#PhysicalChemistry</seealso>
    let PhysicalChemistry = Prefixed_Name(modsci, "PhysicalChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PhysicalGeography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical geography is a subfield of geography, closely related to geology, that focuses on the spatial characteristics of natural processes, within the hydrosphere, biosphere, atmosphere and lithosphere."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical Geography"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PhysicalGeography">https://w3id.org/skgo/modsci#PhysicalGeography</seealso>
    let PhysicalGeography = Prefixed_Name(modsci, "PhysicalGeography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#PhysicalOceanography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PhysicalOceanography">https://w3id.org/skgo/modsci#PhysicalOceanography</seealso>
    let PhysicalOceanography =
        Prefixed_Name(modsci, "PhysicalOceanography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#PhysicalOrganicChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PhysicalOrganicChemistry">https://w3id.org/skgo/modsci#PhysicalOrganicChemistry</seealso>
    let PhysicalOrganicChemistry =
        Prefixed_Name(modsci, "PhysicalOrganicChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physical Phenomena"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PhysicalPhenomena">https://w3id.org/skgo/modsci#PhysicalPhenomena</seealso>
    let PhysicalPhenomena = Prefixed_Name(modsci, "PhysicalPhenomena") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Physical_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Physics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Physical_Studies">https://w3id.org/skgo/modsci#Physical_Studies</seealso>
    let Physical_Studies = Prefixed_Name(modsci, "Physical_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Physics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physics is the science of the natural world. It deals with matter, energy, and the fundamental forces that govern the interactions between particles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Physics">https://w3id.org/skgo/modsci#Physics</seealso>
    let Physics = Prefixed_Name(modsci, "Physics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Physiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physiology is the branch of science that describes the mechanisms of cell, tissue and organ function in organisms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Physiology">https://w3id.org/skgo/modsci#Physiology</seealso>
    let Physiology = Prefixed_Name(modsci, "Physiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PlanetaryScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Planetary science is a broad field of science that studies all planets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Planetary Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PlanetaryScience">https://w3id.org/skgo/modsci#PlanetaryScience</seealso>
    let PlanetaryScience = Prefixed_Name(modsci, "PlanetaryScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PlasmaPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plasma physics is the study of ionized gases."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plasma Physics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PlasmaPhysics">https://w3id.org/skgo/modsci#PlasmaPhysics</seealso>
    let PlasmaPhysics = Prefixed_Name(modsci, "PlasmaPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PoliticalEconomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Political economy is the study of production and trade and their relations with law, custom and government; and with the distribution of national income and wealth."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Political Economy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PoliticalEconomy">https://w3id.org/skgo/modsci#PoliticalEconomy</seealso>
    let PoliticalEconomy = Prefixed_Name(modsci, "PoliticalEconomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PoliticalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Political science is a social science which deals with systems of governance, and the analysis of political activities, political thoughts, and political behavior."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Political Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PoliticalScience">https://w3id.org/skgo/modsci#PoliticalScience</seealso>
    let PoliticalScience = Prefixed_Name(modsci, "PoliticalScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PolymerChar</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PolymerChar">https://w3id.org/skgo/modsci#PolymerChar</seealso>
    let PolymerChar = Prefixed_Name(modsci, "PolymerChar") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#PolymerisationMechanisms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PolymerisationMechanisms">https://w3id.org/skgo/modsci#PolymerisationMechanisms</seealso>
    let PolymerisationMechanisms =
        Prefixed_Name(modsci, "PolymerisationMechanisms") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Population_decrease</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#BiologicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Population_decrease">https://w3id.org/skgo/modsci#Population_decrease</seealso>
    let Population_decrease =
        Prefixed_Name(modsci, "Population_decrease") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ProgrammingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A programming language is a formal language, which comprises a set of instructions that produce various kinds of output. Programming languages are used in computer programming to implement algorithms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Programming Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ProgrammingLanguage">https://w3id.org/skgo/modsci#ProgrammingLanguage</seealso>
    let ProgrammingLanguage =
        Prefixed_Name(modsci, "ProgrammingLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ProgrammingLanguageTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Programming language theory (PLT) is a branch of computer science that deals with the design, implementation, analysis, characterization, and classification of programming languages and their individual features."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Programming Language Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ProgrammingLanguageTheory">https://w3id.org/skgo/modsci#ProgrammingLanguageTheory</seealso>
    let ProgrammingLanguageTheory =
        Prefixed_Name(modsci, "ProgrammingLanguageTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ProgrammingLanguages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Programming languages can be used to accomplish different tasks in different ways."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Programming Languages and Compilers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ProgrammingLanguages">https://w3id.org/skgo/modsci#ProgrammingLanguages</seealso>
    let ProgrammingLanguages =
        Prefixed_Name(modsci, "ProgrammingLanguages") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#PsychiatricDrugs</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ApplicationOfScience</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PsychiatricDrugs">https://w3id.org/skgo/modsci#PsychiatricDrugs</seealso>
    let PsychiatricDrugs = Prefixed_Name(modsci, "PsychiatricDrugs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Psychological_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Psychology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Psychological_Studies">https://w3id.org/skgo/modsci#Psychological_Studies</seealso>
    let Psychological_Studies =
        Prefixed_Name(modsci, "Psychological_Studies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Psychology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Psychology is a collection of academic, clinical and industrial disciplines concerned with the explanation and prediction of behavior, thinking, emotions, motivations, relationships, potentials and pathologies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Psychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Psychology">https://w3id.org/skgo/modsci#Psychology</seealso>
    let Psychology = Prefixed_Name(modsci, "Psychology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#PureMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#PureMathematics">https://w3id.org/skgo/modsci#PureMathematics</seealso>
    let PureMathematics = Prefixed_Name(modsci, "PureMathematics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#QuantumComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Quantum computing is the use of quantum-mechanical phenomena such as superposition and entanglement to perform computation. A quantum computer is used to perform such computation, which can be implemented theoretically or physically."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quantum Computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#QuantumComputing">https://w3id.org/skgo/modsci#QuantumComputing</seealso>
    let QuantumComputing = Prefixed_Name(modsci, "QuantumComputing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#QuantumMechanics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Quantum mechanics (also called quantum physics or quantum theory) is a physical theory that is believed to be the formalism underlying the description of all physical systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quantum Mechanics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#QuantumMechanics">https://w3id.org/skgo/modsci#QuantumMechanics</seealso>
    let QuantumMechanics = Prefixed_Name(modsci, "QuantumMechanics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#QuantumOptics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#QuantumOptics">https://w3id.org/skgo/modsci#QuantumOptics</seealso>
    let QuantumOptics = Prefixed_Name(modsci, "QuantumOptics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#QuantumPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#QuantumPhysics">https://w3id.org/skgo/modsci#QuantumPhysics</seealso>
    let QuantumPhysics = Prefixed_Name(modsci, "QuantumPhysics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Racism</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#SocialPhenomenon</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Racism">https://w3id.org/skgo/modsci#Racism</seealso>
    let Racism = Prefixed_Name(modsci, "Racism") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Radio_Signals</para>
    /// </summary>
    /// <remarks>
    ///   <para>sweet:phen/Phenomenon</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Radio_Signals">https://w3id.org/skgo/modsci#Radio_Signals</seealso>
    let Radio_Signals = Prefixed_Name(modsci, "Radio_Signals") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Radiobiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Radiobiology is a field of clinical and basic medical sciences that involves the study of the action of ionizing radiation on living things, especially health effects of radiation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiation Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Radiobiology">https://w3id.org/skgo/modsci#Radiobiology</seealso>
    let Radiobiology = Prefixed_Name(modsci, "Radiobiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Radiochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Radiochemistry is the chemistry of radioactive materials, where radioactive isotopes of elements are used to study the properties and chemical reactions of non-radioactive isotopes (often within radiochemistry the absence of radioactivity leads to a substance being described as being inactive as the isotopes are stable)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radiochemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Radiochemistry">https://w3id.org/skgo/modsci#Radiochemistry</seealso>
    let Radiochemistry = Prefixed_Name(modsci, "Radiochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Radiometrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Radiometrics">https://w3id.org/skgo/modsci#Radiometrics</seealso>
    let Radiometrics = Prefixed_Name(modsci, "Radiometrics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Rainbow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#AtmosphericPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Rainbow">https://w3id.org/skgo/modsci#Rainbow</seealso>
    let Rainbow = Prefixed_Name(modsci, "Rainbow") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#RelationalDatabases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relational database is a digital database based on the relational model of data, as proposed by E. F. Codd in 1970."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relational Databases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#RelationalDatabases">https://w3id.org/skgo/modsci#RelationalDatabases</seealso>
    let RelationalDatabases =
        Prefixed_Name(modsci, "RelationalDatabases") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Resampling_Methods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Resampling_Methods">https://w3id.org/skgo/modsci#Resampling_Methods</seealso>
    let Resampling_Methods = Prefixed_Name(modsci, "Resampling_Methods") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ReverseEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reverse engineering, also called back engineering, is the process by which a man-made object is deconstructed to reveal its designs, architecture, or to extract knowledge from the object; similar to scientific research, the only difference being that scientific research is about a natural phenomenon."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reverse Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ReverseEngineering">https://w3id.org/skgo/modsci#ReverseEngineering</seealso>
    let ReverseEngineering = Prefixed_Name(modsci, "ReverseEngineering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Robotics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Robotics is an interdisciplinary branch of engineering and science that includes mechanical engineering, electronic engineering, information engineering, computer science, and others. Robotics deals with the design, construction, operation, and use of robots, as well as computer systems for their control, sensory feedback, and information processing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Robotics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Robotics">https://w3id.org/skgo/modsci#Robotics</seealso>
    let Robotics = Prefixed_Name(modsci, "Robotics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Rusting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ChemicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Rusting">https://w3id.org/skgo/modsci#Rusting</seealso>
    let Rusting = Prefixed_Name(modsci, "Rusting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScienceAndTechnologyStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Science and technology studies is the study of how society, politics, and culture affect scientific research and technological innovation, and how these, in turn, affect society, politics and culture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Science and Technology Studies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScienceAndTechnologyStudies">https://w3id.org/skgo/modsci#ScienceAndTechnologyStudies</seealso>
    let ScienceAndTechnologyStudies =
        Prefixed_Name(modsci, "ScienceAndTechnologyStudies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScienceStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Science studies is an interdisciplinary research area that seeks to situate scientific expertise in broad social, historical, and philosophical contexts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Science Studies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScienceStudies">https://w3id.org/skgo/modsci#ScienceStudies</seealso>
    let ScienceStudies = Prefixed_Name(modsci, "ScienceStudies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScientificDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scientific Discovery is the process or product of successful scientific inquiry. Objects of discovery can be things, events, processes, causes, and properties as well as theories and hypotheses and their features (their explanatory power, for example)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scientific Discovery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScientificDiscovery">https://w3id.org/skgo/modsci#ScientificDiscovery</seealso>
    let ScientificDiscovery =
        Prefixed_Name(modsci, "ScientificDiscovery") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scientific instrument is, broadly speaking, a device or tool used for scientific purposes, including the study of both natural phenomena and theoretical research."</para>
    /// labels<para>"Scientific Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScientificInstrument">https://w3id.org/skgo/modsci#ScientificInstrument</seealso>
    let ScientificInstrument =
        Prefixed_Name(modsci, "ScientificInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Companies manufacturing equipment for scientific sstudies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scientific Instrument Manufacturer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScientificInstrumentManufacturer">https://w3id.org/skgo/modsci#ScientificInstrumentManufacturer</seealso>
    let ScientificInstrumentManufacturer =
        Prefixed_Name(modsci, "ScientificInstrumentManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScientificMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scientific method is a sequence or collection of processes that are considered characteristic of scientific investigation and the acquisition of new scientific knowledge based upon physical evidence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scientific Method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScientificMethod">https://w3id.org/skgo/modsci#ScientificMethod</seealso>
    let ScientificMethod = Prefixed_Name(modsci, "ScientificMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ScientificModeling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scientific modelling is a scientific activity, the aim of which is to make a particular part or feature of the world easier to understand, define, quantify, visualize, or simulate by referencing it to existing and usually commonly accepted knowledge."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scientific Modelling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScientificModeling">https://w3id.org/skgo/modsci#ScientificModeling</seealso>
    let ScientificModeling = Prefixed_Name(modsci, "ScientificModeling") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization which is created for the purpose of scientific research and development."</para>
    /// labels<para>"Scientific Organization"</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ScientificOrganization">https://w3id.org/skgo/modsci#ScientificOrganization</seealso>
    let ScientificOrganization =
        Prefixed_Name(modsci, "ScientificOrganization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scientist is someone who conducts scientific research to advance knowledge in an area of interest."</para>
    /// labels<para>"Scientist"</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Scientist">https://w3id.org/skgo/modsci#Scientist</seealso>
    let Scientist = Prefixed_Name(modsci, "Scientist") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Sedimentology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Sedimentology">https://w3id.org/skgo/modsci#Sedimentology</seealso>
    let Sedimentology = Prefixed_Name(modsci, "Sedimentology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SeismicExploration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SeismicExploration">https://w3id.org/skgo/modsci#SeismicExploration</seealso>
    let SeismicExploration = Prefixed_Name(modsci, "SeismicExploration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Seismology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Seismology">https://w3id.org/skgo/modsci#Seismology</seealso>
    let Seismology = Prefixed_Name(modsci, "Seismology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Seismometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Seismometer">https://w3id.org/skgo/modsci#Seismometer</seealso>
    let Seismometer = Prefixed_Name(modsci, "Seismometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Semantics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In programming language theory, semantics is the field concerned with the rigorous mathematical study of the meaning of programming languages. It does so by evaluating the meaning of syntactically valid strings defined by a specific programming language, showing the computation involved."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semantics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Semantics">https://w3id.org/skgo/modsci#Semantics</seealso>
    let Semantics = Prefixed_Name(modsci, "Semantics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Semiotics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Semiotics is the study of signs (symbols) and signification systems, or rather semiotics are general theories of signs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semiotics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Semiotics">https://w3id.org/skgo/modsci#Semiotics</seealso>
    let Semiotics = Prefixed_Name(modsci, "Semiotics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SeparationScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SeparationScience">https://w3id.org/skgo/modsci#SeparationScience</seealso>
    let SeparationScience = Prefixed_Name(modsci, "SeparationScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#ShimadzuCorp</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#ShimadzuCorp">https://w3id.org/skgo/modsci#ShimadzuCorp</seealso>
    let ShimadzuCorp = Prefixed_Name(modsci, "ShimadzuCorp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Shrinkage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Shrinkage">https://w3id.org/skgo/modsci#Shrinkage</seealso>
    let Shrinkage = Prefixed_Name(modsci, "Shrinkage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SocialPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Social phenomena are those that occur or exist through the actions of groups of humans."</para>
    /// labels<para>"Social Phenomenon"</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SocialPhenomenon">https://w3id.org/skgo/modsci#SocialPhenomenon</seealso>
    let SocialPhenomenon = Prefixed_Name(modsci, "SocialPhenomenon") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SocialPsychology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Social psychology is the scientific study of how people's thoughts, feelings, and behaviors are influenced by the actual, imagined or implied presence of others."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social Psychology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SocialPsychology">https://w3id.org/skgo/modsci#SocialPsychology</seealso>
    let SocialPsychology = Prefixed_Name(modsci, "SocialPsychology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SocialSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The social sciences are academic disciplines concerned with the study of the social life of human groups and individuals including anthropology, economics, geography, history, political science, psychology, social studies, and sociology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social Sciences"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SocialSciences">https://w3id.org/skgo/modsci#SocialSciences</seealso>
    let SocialSciences = Prefixed_Name(modsci, "SocialSciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SocialWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Social work is an academic discipline and profession that concerns itself with individuals, families, groups and communities in an effort to enhance social functioning and overall well-being."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social Work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SocialWork">https://w3id.org/skgo/modsci#SocialWork</seealso>
    let SocialWork = Prefixed_Name(modsci, "SocialWork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Sociobiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sociobiology is a field of biology that aims to examine and explain social behavior in terms of evolution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sociobiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Sociobiology">https://w3id.org/skgo/modsci#Sociobiology</seealso>
    let Sociobiology = Prefixed_Name(modsci, "Sociobiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Sociology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sociology is the study of social behaviour or society, including its origins, development, organization, networks, and institutions. and critical analysis to develop a body of knowledge about social order, disorder, and change."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sociology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Sociology">https://w3id.org/skgo/modsci#Sociology</seealso>
    let Sociology = Prefixed_Name(modsci, "Sociology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SoftComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soft computing, as opposed to traditional computing, deals with approximate models and gives solutions to complex real-life problems. Unlike hard computing, soft computing is tolerant of imprecision, uncertainty, partial truth, and approximations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soft Computing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SoftComputing">https://w3id.org/skgo/modsci#SoftComputing</seealso>
    let SoftComputing = Prefixed_Name(modsci, "SoftComputing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SoftwareEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Software engineering is the application of engineering to the development of software in a systematic method."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software Engineering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SoftwareEngineering">https://w3id.org/skgo/modsci#SoftwareEngineering</seealso>
    let SoftwareEngineering =
        Prefixed_Name(modsci, "SoftwareEngineering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SoilBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soil biology is the study of microbial and faunal activity and ecology in soil."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soil Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SoilBiology">https://w3id.org/skgo/modsci#SoilBiology</seealso>
    let SoilBiology = Prefixed_Name(modsci, "SoilBiology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SoilScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soil science is the study of soil as a natural resource on the surface of the Earth including soil formation, classification and mapping; physical, chemical, biological, and fertility properties of soils; and these properties in relation to the use and management of soils."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Soil Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SoilScience">https://w3id.org/skgo/modsci#SoilScience</seealso>
    let SoilScience = Prefixed_Name(modsci, "SoilScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SoilSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SoilSciences">https://w3id.org/skgo/modsci#SoilSciences</seealso>
    let SoilSciences = Prefixed_Name(modsci, "SoilSciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SolidMechanics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solid mechanics is a mathematical discipline within continuum mechanics, dealing with the mechanical behavior of solid materials."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Solid Mechanics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SolidMechanics">https://w3id.org/skgo/modsci#SolidMechanics</seealso>
    let SolidMechanics = Prefixed_Name(modsci, "SolidMechanics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SolidStateChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solid-state chemistry, also sometimes referred as materials chemistry, is the study of the synthesis, structure, and properties of solid phase materials, particularly, but not necessarily exclusively of, non-molecular solids."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Solid-State Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SolidStateChemistry">https://w3id.org/skgo/modsci#SolidStateChemistry</seealso>
    let SolidStateChemistry =
        Prefixed_Name(modsci, "SolidStateChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SolutionChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SolutionChemistry">https://w3id.org/skgo/modsci#SolutionChemistry</seealso>
    let SolutionChemistry = Prefixed_Name(modsci, "SolutionChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SpaceScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Space science encompasses all of the scientific disciplines that involve space exploration and study natural phenomena and physical bodies occurring in outer space, such as space medicine and astrobiology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Space Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SpaceScience">https://w3id.org/skgo/modsci#SpaceScience</seealso>
    let SpaceScience = Prefixed_Name(modsci, "SpaceScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Spectrogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Spectrogram">https://w3id.org/skgo/modsci#Spectrogram</seealso>
    let Spectrogram = Prefixed_Name(modsci, "Spectrogram") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Spectrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Spectrometer">https://w3id.org/skgo/modsci#Spectrometer</seealso>
    let Spectrometer = Prefixed_Name(modsci, "Spectrometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Spectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Spectroscopy">https://w3id.org/skgo/modsci#Spectroscopy</seealso>
    let Spectroscopy = Prefixed_Name(modsci, "Spectroscopy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Speed_of_light</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificDiscovery</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Speed_of_light">https://w3id.org/skgo/modsci#Speed_of_light</seealso>
    let Speed_of_light = Prefixed_Name(modsci, "Speed_of_light") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#SportsScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sports science is a discipline that studies how the healthy human body works during exercise, and how sport and physical activity promote health and performance from cellular to whole body perspectives."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sports Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SportsScience">https://w3id.org/skgo/modsci#SportsScience</seealso>
    let SportsScience = Prefixed_Name(modsci, "SportsScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Statistics is the discipline that concerns the collection, organization, displaying, analysis, interpretation and presentation of data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Statistics">https://w3id.org/skgo/modsci#Statistics</seealso>
    let Statistics = Prefixed_Name(modsci, "Statistics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Statistics_Studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Statistics_Studies">https://w3id.org/skgo/modsci#Statistics_Studies</seealso>
    let Statistics_Studies = Prefixed_Name(modsci, "Statistics_Studies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#StellarAstronomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The study of stars and stellar evolution is fundamental to our understanding of the Universe."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stellar Astronomy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#StellarAstronomy">https://w3id.org/skgo/modsci#StellarAstronomy</seealso>
    let StellarAstronomy = Prefixed_Name(modsci, "StellarAstronomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Stereochemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Stereochemistry, a subdiscipline of chemistry, involves the study of the relative spatial arrangement of atoms that form the structure of molecules and their manipulation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stereochemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Stereochemistry">https://w3id.org/skgo/modsci#Stereochemistry</seealso>
    let Stereochemistry = Prefixed_Name(modsci, "Stereochemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Storm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#MeteorologicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Storm">https://w3id.org/skgo/modsci#Storm</seealso>
    let Storm = Prefixed_Name(modsci, "Storm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Stratigraphy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Stratigraphy">https://w3id.org/skgo/modsci#Stratigraphy</seealso>
    let Stratigraphy = Prefixed_Name(modsci, "Stratigraphy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#StructuralChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#StructuralChemistry">https://w3id.org/skgo/modsci#StructuralChemistry</seealso>
    let StructuralChemistry =
        Prefixed_Name(modsci, "StructuralChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#StructuralGeology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#StructuralGeology">https://w3id.org/skgo/modsci#StructuralGeology</seealso>
    let StructuralGeology = Prefixed_Name(modsci, "StructuralGeology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#StructuredStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Structured storage is computer storage for structured data, often in the form of a distributed database."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Structured Storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#StructuredStorage">https://w3id.org/skgo/modsci#StructuredStorage</seealso>
    let StructuredStorage = Prefixed_Name(modsci, "StructuredStorage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Studying_biochemical_reactions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#MolecularBiology</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Studying_biochemical_reactions">https://w3id.org/skgo/modsci#Studying_biochemical_reactions</seealso>
    let Studying_biochemical_reactions =
        Prefixed_Name(modsci, "Studying_biochemical_reactions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Subset_Selection</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Subset_Selection">https://w3id.org/skgo/modsci#Subset_Selection</seealso>
    let Subset_Selection = Prefixed_Name(modsci, "Subset_Selection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Subsun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#AtmosphericPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Subsun">https://w3id.org/skgo/modsci#Subsun</seealso>
    let Subsun = Prefixed_Name(modsci, "Subsun") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Supernova</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#AstronomicalPhenomena</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Supernova">https://w3id.org/skgo/modsci#Supernova</seealso>
    let Supernova = Prefixed_Name(modsci, "Supernova") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Support_Vector_Machines</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ClassificationAlgorithms</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Support_Vector_Machines">https://w3id.org/skgo/modsci#Support_Vector_Machines</seealso>
    let Support_Vector_Machines =
        Prefixed_Name(modsci, "Support_Vector_Machines") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SupramolecularChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Supramolecular chemistry is a branch of chemistry that describes self-organization or self-assembly of systems to well-defined molecular architectures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supramolecular Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SupramolecularChemistry">https://w3id.org/skgo/modsci#SupramolecularChemistry</seealso>
    let SupramolecularChemistry =
        Prefixed_Name(modsci, "SupramolecularChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SurfaceChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Surface chemistry is the study of chemical phenomena that occur at the interface of two phases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Surface Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SurfaceChemistry">https://w3id.org/skgo/modsci#SurfaceChemistry</seealso>
    let SurfaceChemistry = Prefixed_Name(modsci, "SurfaceChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SynthesisOfMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SynthesisOfMaterials">https://w3id.org/skgo/modsci#SynthesisOfMaterials</seealso>
    let SynthesisOfMaterials =
        Prefixed_Name(modsci, "SynthesisOfMaterials") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#SystemsScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Systems science is the field of science surrounding systems theory, cybernetics, the science of complex systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Systems Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#SystemsScience">https://w3id.org/skgo/modsci#SystemsScience</seealso>
    let SystemsScience = Prefixed_Name(modsci, "SystemsScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Technology is the collection of techniques, skills, methods, and processes used in the production of goods or services or in the accomplishment of objectives, such as scientific investigation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Technology">https://w3id.org/skgo/modsci#Technology</seealso>
    let Technology = Prefixed_Name(modsci, "Technology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Techtron</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Techtron">https://w3id.org/skgo/modsci#Techtron</seealso>
    let Techtron = Prefixed_Name(modsci, "Techtron") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Tectonics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Tectonics">https://w3id.org/skgo/modsci#Tectonics</seealso>
    let Tectonics = Prefixed_Name(modsci, "Tectonics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Telescope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Telescope">https://w3id.org/skgo/modsci#Telescope</seealso>
    let Telescope = Prefixed_Name(modsci, "Telescope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#The_Bridges_Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#The_Bridges_Organization">https://w3id.org/skgo/modsci#The_Bridges_Organization</seealso>
    let The_Bridges_Organization =
        Prefixed_Name(modsci, "The_Bridges_Organization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#The_Fibonacci_Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificOrganization</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#The_Fibonacci_Association">https://w3id.org/skgo/modsci#The_Fibonacci_Association</seealso>
    let The_Fibonacci_Association =
        Prefixed_Name(modsci, "The_Fibonacci_Association") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Theodolite</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Theodolite">https://w3id.org/skgo/modsci#Theodolite</seealso>
    let Theodolite = Prefixed_Name(modsci, "Theodolite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#TheoreticalBiology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Theoretical Biology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TheoreticalBiology">https://w3id.org/skgo/modsci#TheoreticalBiology</seealso>
    let TheoreticalBiology = Prefixed_Name(modsci, "TheoreticalBiology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#TheoreticalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Theoretical chemistry is the application of theoretical reasoning to chemistry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Theoretical Chemistry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TheoreticalChemistry">https://w3id.org/skgo/modsci#TheoreticalChemistry</seealso>
    let TheoreticalChemistry =
        Prefixed_Name(modsci, "TheoreticalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#TheoreticalComputerScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TheoreticalComputerScience">https://w3id.org/skgo/modsci#TheoreticalComputerScience</seealso>
    let TheoreticalComputerScience =
        Prefixed_Name(modsci, "TheoreticalComputerScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#TheoreticalLinguistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Theoretical linguistics, or general linguistics, is the branch of linguistics which inquires into the nature of language itself and seeks to answer fundamental questions as to what language is; how it works; how universal grammar (UG) as a domain-specific mental organ operates, if it exists at all; what are its unique properties; how does language relate to other cognitive processes, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Theoretical Linguistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TheoreticalLinguistics">https://w3id.org/skgo/modsci#TheoreticalLinguistics</seealso>
    let TheoreticalLinguistics =
        Prefixed_Name(modsci, "TheoreticalLinguistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#TheoryAndDesignOfMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TheoryAndDesignOfMaterials">https://w3id.org/skgo/modsci#TheoryAndDesignOfMaterials</seealso>
    let TheoryAndDesignOfMaterials =
        Prefixed_Name(modsci, "TheoryAndDesignOfMaterials") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#TheoryOfComputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Theory of computation is focused on answering fundamental questions about what can be computed and what amount of resources are required to perform those computations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Theory of Computation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TheoryOfComputation">https://w3id.org/skgo/modsci#TheoryOfComputation</seealso>
    let TheoryOfComputation =
        Prefixed_Name(modsci, "TheoryOfComputation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Thermocouple</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Thermocouple">https://w3id.org/skgo/modsci#Thermocouple</seealso>
    let Thermocouple = Prefixed_Name(modsci, "Thermocouple") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Thermodynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Thermodynamics concerns the physics of heat, work, temperature, energy, and entropy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermodynamics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Thermodynamics">https://w3id.org/skgo/modsci#Thermodynamics</seealso>
    let Thermodynamics = Prefixed_Name(modsci, "Thermodynamics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Thermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Thermometer">https://w3id.org/skgo/modsci#Thermometer</seealso>
    let Thermometer = Prefixed_Name(modsci, "Thermometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Thomas_Edison</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Thomas_Edison">https://w3id.org/skgo/modsci#Thomas_Edison</seealso>
    let Thomas_Edison = Prefixed_Name(modsci, "Thomas_Edison") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Time_Series_Analysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#Statistics</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Time_Series_Analysis">https://w3id.org/skgo/modsci#Time_Series_Analysis</seealso>
    let Time_Series_Analysis =
        Prefixed_Name(modsci, "Time_Series_Analysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Topology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Topology">https://w3id.org/skgo/modsci#Topology</seealso>
    let Topology = Prefixed_Name(modsci, "Topology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Toxicology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Toxicology is a scientific discipline, overlapping with biology, chemistry, pharmacology, and medicine, that involves the study of the adverse effects of chemical substances on living organisms and the practice of diagnosing and treating exposures to toxins and toxicants."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Toxicology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Toxicology">https://w3id.org/skgo/modsci#Toxicology</seealso>
    let Toxicology = Prefixed_Name(modsci, "Toxicology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Transdisciplinarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Transdisciplinarity connotes a research strategy that crosses many disciplinary boundaries to create a holistic approach."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transdisciplinarity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Transdisciplinarity">https://w3id.org/skgo/modsci#Transdisciplinarity</seealso>
    let Transdisciplinarity =
        Prefixed_Name(modsci, "Transdisciplinarity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#TransitionMetalChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TransitionMetalChemistry">https://w3id.org/skgo/modsci#TransitionMetalChemistry</seealso>
    let TransitionMetalChemistry =
        Prefixed_Name(modsci, "TransitionMetalChemistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#Tsunamis</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#OceanographicPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Tsunamis">https://w3id.org/skgo/modsci#Tsunamis</seealso>
    let Tsunamis = Prefixed_Name(modsci, "Tsunamis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#TypeTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In mathematics, logic, and computer science, a type theory is any of a class of formal systems, some of which can serve as alternatives to set theory as a foundation for all mathematics. In type theory, every "term" has a "type" and operations are restricted to terms of a certain type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Type Theory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#TypeTheory">https://w3id.org/skgo/modsci#TypeTheory</seealso>
    let TypeTheory = Prefixed_Name(modsci, "TypeTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#UbiquitousComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#UbiquitousComputing">https://w3id.org/skgo/modsci#UbiquitousComputing</seealso>
    let UbiquitousComputing =
        Prefixed_Name(modsci, "UbiquitousComputing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#UniversalAlgebra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#UniversalAlgebra">https://w3id.org/skgo/modsci#UniversalAlgebra</seealso>
    let UniversalAlgebra = Prefixed_Name(modsci, "UniversalAlgebra") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#UrbanPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Urban planning is a technical and political process concerned with the development and design of land use and the built environment, including air, water, and the infrastructure passing into and out of urban areas, such as transportation, communications, and distribution networks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Urban Planning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#UrbanPlanning">https://w3id.org/skgo/modsci#UrbanPlanning</seealso>
    let UrbanPlanning = Prefixed_Name(modsci, "UrbanPlanning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#VeterinaryMedicine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Veterinary medicine is the branch of medicine that deals with the prevention, diagnosis and treatment of disease, disorder and injury in animals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Veterinary Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#VeterinaryMedicine">https://w3id.org/skgo/modsci#VeterinaryMedicine</seealso>
    let VeterinaryMedicine = Prefixed_Name(modsci, "VeterinaryMedicine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#VeterinarySciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#VeterinarySciences">https://w3id.org/skgo/modsci#VeterinarySciences</seealso>
    let VeterinarySciences = Prefixed_Name(modsci, "VeterinarySciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#VirtualReality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#VirtualReality">https://w3id.org/skgo/modsci#VirtualReality</seealso>
    let VirtualReality = Prefixed_Name(modsci, "VirtualReality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#GeologicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Volcano">https://w3id.org/skgo/modsci#Volcano</seealso>
    let Volcano = Prefixed_Name(modsci, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Volcanology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Volcanology is a branch of geology that deals with the study of volcanoes, lava, magma, and related geological phenomena."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volcanology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Volcanology">https://w3id.org/skgo/modsci#Volcanology</seealso>
    let Volcanology = Prefixed_Name(modsci, "Volcanology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Voltmeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Voltmeter">https://w3id.org/skgo/modsci#Voltmeter</seealso>
    let Voltmeter = Prefixed_Name(modsci, "Voltmeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Waldemar_Jungner</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Scientist</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Waldemar_Jungner">https://w3id.org/skgo/modsci#Waldemar_Jungner</seealso>
    let Waldemar_Jungner = Prefixed_Name(modsci, "Waldemar_Jungner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#WatersCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#ScientificInstrumentManufacturer</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#WatersCorporation">https://w3id.org/skgo/modsci#WatersCorporation</seealso>
    let WatersCorporation = Prefixed_Name(modsci, "WatersCorporation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Waves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Waves">https://w3id.org/skgo/modsci#Waves</seealso>
    let Waves = Prefixed_Name(modsci, "Waves") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#WebSearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#WebSearch">https://w3id.org/skgo/modsci#WebSearch</seealso>
    let WebSearch = Prefixed_Name(modsci, "WebSearch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#WebServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#WebServices">https://w3id.org/skgo/modsci#WebServices</seealso>
    let WebServices = Prefixed_Name(modsci, "WebServices") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#WebTechnologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#WebTechnologies">https://w3id.org/skgo/modsci#WebTechnologies</seealso>
    let WebTechnologies = Prefixed_Name(modsci, "WebTechnologies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Weddings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:skgo/modsci#SocialPhenomenon</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Weddings">https://w3id.org/skgo/modsci#Weddings</seealso>
    let Weddings = Prefixed_Name(modsci, "Weddings") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#Zoology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zoology is the study of the biology of animals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zoology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#Zoology">https://w3id.org/skgo/modsci#Zoology</seealso>
    let Zoology = Prefixed_Name(modsci, "Zoology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#appliesLawsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#appliesLawsFrom">https://w3id.org/skgo/modsci#appliesLawsFrom</seealso>
    let appliesLawsFrom = Prefixed_Name(modsci, "appliesLawsFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#appliesLawsFromMathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#appliesLawsFromMathematics">https://w3id.org/skgo/modsci#appliesLawsFromMathematics</seealso>
    let appliesLawsFromMathematics =
        Prefixed_Name(modsci, "appliesLawsFromMathematics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#appliesLawsFromPhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#appliesLawsFromPhysics">https://w3id.org/skgo/modsci#appliesLawsFromPhysics</seealso>
    let appliesLawsFromPhysics =
        Prefixed_Name(modsci, "appliesLawsFromPhysics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#appliesLawsFromStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#appliesLawsFromStatistics">https://w3id.org/skgo/modsci#appliesLawsFromStatistics</seealso>
    let appliesLawsFromStatistics =
        Prefixed_Name(modsci, "appliesLawsFromStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#appliesLawsFromThermodynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#appliesLawsFromThermodynamics">https://w3id.org/skgo/modsci#appliesLawsFromThermodynamics</seealso>
    let appliesLawsFromThermodynamics =
        Prefixed_Name(modsci, "appliesLawsFromThermodynamics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByAppliedSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByAppliedSciences">https://w3id.org/skgo/modsci#discoveredByAppliedSciences</seealso>
    let discoveredByAppliedSciences =
        Prefixed_Name(modsci, "discoveredByAppliedSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByBehaviouralSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByBehaviouralSciences">https://w3id.org/skgo/modsci#discoveredByBehaviouralSciences</seealso>
    let discoveredByBehaviouralSciences =
        Prefixed_Name(modsci, "discoveredByBehaviouralSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByFormalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByFormalScience">https://w3id.org/skgo/modsci#discoveredByFormalScience</seealso>
    let discoveredByFormalScience =
        Prefixed_Name(modsci, "discoveredByFormalScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByHealthSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByHealthSciences">https://w3id.org/skgo/modsci#discoveredByHealthSciences</seealso>
    let discoveredByHealthSciences =
        Prefixed_Name(modsci, "discoveredByHealthSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByInterdisciplinaryStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByInterdisciplinaryStudies">https://w3id.org/skgo/modsci#discoveredByInterdisciplinaryStudies</seealso>
    let discoveredByInterdisciplinaryStudies =
        Prefixed_Name(modsci, "discoveredByInterdisciplinaryStudies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByMachine">https://w3id.org/skgo/modsci#discoveredByMachine</seealso>
    let discoveredByMachine =
        Prefixed_Name(modsci, "discoveredByMachine") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByNaturalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByNaturalScience">https://w3id.org/skgo/modsci#discoveredByNaturalScience</seealso>
    let discoveredByNaturalScience =
        Prefixed_Name(modsci, "discoveredByNaturalScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByScience">https://w3id.org/skgo/modsci#discoveredByScience</seealso>
    let discoveredByScience =
        Prefixed_Name(modsci, "discoveredByScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredByScientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredByScientist">https://w3id.org/skgo/modsci#discoveredByScientist</seealso>
    let discoveredByScientist =
        Prefixed_Name(modsci, "discoveredByScientist") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#discoveredBySocialSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#discoveredBySocialSciences">https://w3id.org/skgo/modsci#discoveredBySocialSciences</seealso>
    let discoveredBySocialSciences =
        Prefixed_Name(modsci, "discoveredBySocialSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#f-BlockChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#f-BlockChemistry">https://w3id.org/skgo/modsci#f-BlockChemistry</seealso>
    let f_BlockChemistry = Prefixed_Name(modsci, "f-BlockChemistry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#followsMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#followsMethod">https://w3id.org/skgo/modsci#followsMethod</seealso>
    let followsMethod = Prefixed_Name(modsci, "followsMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#hasApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#hasApplication">https://w3id.org/skgo/modsci#hasApplication</seealso>
    let hasApplication = Prefixed_Name(modsci, "hasApplication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#hasCloseRelationshipTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#hasCloseRelationshipTo">https://w3id.org/skgo/modsci#hasCloseRelationshipTo</seealso>
    let hasCloseRelationshipTo =
        Prefixed_Name(modsci, "hasCloseRelationshipTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#hasCollaborationWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#hasCollaborationWith">https://w3id.org/skgo/modsci#hasCollaborationWith</seealso>
    let hasCollaborationWith =
        Prefixed_Name(modsci, "hasCollaborationWith") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#hasManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#hasManufacturer">https://w3id.org/skgo/modsci#hasManufacturer</seealso>
    let hasManufacturer = Prefixed_Name(modsci, "hasManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#hasMethodsInspiredFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#hasMethodsInspiredFrom">https://w3id.org/skgo/modsci#hasMethodsInspiredFrom</seealso>
    let hasMethodsInspiredFrom =
        Prefixed_Name(modsci, "hasMethodsInspiredFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#hasScientificInstrumentManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#hasScientificInstrumentManufacturer">https://w3id.org/skgo/modsci#hasScientificInstrumentManufacturer</seealso>
    let hasScientificInstrumentManufacturer =
        Prefixed_Name(modsci, "hasScientificInstrumentManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#inspiredFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#inspiredFrom">https://w3id.org/skgo/modsci#inspiredFrom</seealso>
    let inspiredFrom = Prefixed_Name(modsci, "inspiredFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#inspiredFromPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#inspiredFromPhenomenon">https://w3id.org/skgo/modsci#inspiredFromPhenomenon</seealso>
    let inspiredFromPhenomenon =
        Prefixed_Name(modsci, "inspiredFromPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#inspiredFromScientificDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#inspiredFromScientificDiscovery">https://w3id.org/skgo/modsci#inspiredFromScientificDiscovery</seealso>
    let inspiredFromScientificDiscovery =
        Prefixed_Name(modsci, "inspiredFromScientificDiscovery") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#instrumentInventedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#instrumentInventedBy">https://w3id.org/skgo/modsci#instrumentInventedBy</seealso>
    let instrumentInventedBy =
        Prefixed_Name(modsci, "instrumentInventedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#instrumentUsedInScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"instrument used in Science"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#instrumentUsedInScience">https://w3id.org/skgo/modsci#instrumentUsedInScience</seealso>
    let instrumentUsedInScience =
        Prefixed_Name(modsci, "instrumentUsedInScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#interestedInPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#interestedInPhenomenon">https://w3id.org/skgo/modsci#interestedInPhenomenon</seealso>
    let interestedInPhenomenon =
        Prefixed_Name(modsci, "interestedInPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfAppliedScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfAppliedScience">https://w3id.org/skgo/modsci#isApplicationOfAppliedScience</seealso>
    let isApplicationOfAppliedScience =
        Prefixed_Name(modsci, "isApplicationOfAppliedScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfBehaviouralSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfBehaviouralSciences">https://w3id.org/skgo/modsci#isApplicationOfBehaviouralSciences</seealso>
    let isApplicationOfBehaviouralSciences =
        Prefixed_Name(modsci, "isApplicationOfBehaviouralSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfFormalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfFormalScience">https://w3id.org/skgo/modsci#isApplicationOfFormalScience</seealso>
    let isApplicationOfFormalScience =
        Prefixed_Name(modsci, "isApplicationOfFormalScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfHealthSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfHealthSciences">https://w3id.org/skgo/modsci#isApplicationOfHealthSciences</seealso>
    let isApplicationOfHealthSciences =
        Prefixed_Name(modsci, "isApplicationOfHealthSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfInterdisciplinaryStudies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfInterdisciplinaryStudies">https://w3id.org/skgo/modsci#isApplicationOfInterdisciplinaryStudies</seealso>
    let isApplicationOfInterdisciplinaryStudies =
        Prefixed_Name(modsci, "isApplicationOfInterdisciplinaryStudies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfNaturalScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfNaturalScience">https://w3id.org/skgo/modsci#isApplicationOfNaturalScience</seealso>
    let isApplicationOfNaturalScience =
        Prefixed_Name(modsci, "isApplicationOfNaturalScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfScience">https://w3id.org/skgo/modsci#isApplicationOfScience</seealso>
    let isApplicationOfScience =
        Prefixed_Name(modsci, "isApplicationOfScience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isApplicationOfSocialSciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isApplicationOfSocialSciences">https://w3id.org/skgo/modsci#isApplicationOfSocialSciences</seealso>
    let isApplicationOfSocialSciences =
        Prefixed_Name(modsci, "isApplicationOfSocialSciences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isDiscoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isDiscoveredBy">https://w3id.org/skgo/modsci#isDiscoveredBy</seealso>
    let isDiscoveredBy = Prefixed_Name(modsci, "isDiscoveredBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isDiscoveredByOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isDiscoveredByOrganization">https://w3id.org/skgo/modsci#isDiscoveredByOrganization</seealso>
    let isDiscoveredByOrganization =
        Prefixed_Name(modsci, "isDiscoveredByOrganization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isDiscoveredByScientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isDiscoveredByScientist">https://w3id.org/skgo/modsci#isDiscoveredByScientist</seealso>
    let isDiscoveredByScientist =
        Prefixed_Name(modsci, "isDiscoveredByScientist") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#isManufacturerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isManufacturerOf">https://w3id.org/skgo/modsci#isManufacturerOf</seealso>
    let isManufacturerOf = Prefixed_Name(modsci, "isManufacturerOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#isStudentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#isStudentOf">https://w3id.org/skgo/modsci#isStudentOf</seealso>
    let isStudentOf = Prefixed_Name(modsci, "isStudentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#requiresKnowledgeFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#requiresKnowledgeFrom">https://w3id.org/skgo/modsci#requiresKnowledgeFrom</seealso>
    let requiresKnowledgeFrom =
        Prefixed_Name(modsci, "requiresKnowledgeFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#scientistBelongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#scientistBelongsTo">https://w3id.org/skgo/modsci#scientistBelongsTo</seealso>
    let scientistBelongsTo = Prefixed_Name(modsci, "scientistBelongsTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#study_of_wetlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#Ecology</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#study_of_wetlands">https://w3id.org/skgo/modsci#study_of_wetlands</seealso>
    let study_of_wetlands = Prefixed_Name(modsci, "study_of_wetlands") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#suppliesSubstancesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#suppliesSubstancesTo">https://w3id.org/skgo/modsci#suppliesSubstancesTo</seealso>
    let suppliesSubstancesTo =
        Prefixed_Name(modsci, "suppliesSubstancesTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#takeSunstancesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#takeSunstancesFrom">https://w3id.org/skgo/modsci#takeSunstancesFrom</seealso>
    let takeSunstancesFrom = Prefixed_Name(modsci, "takeSunstancesFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#temperature_gradient</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:skgo/modsci#PhysicalPhenomena</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#temperature_gradient">https://w3id.org/skgo/modsci#temperature_gradient</seealso>
    let temperature_gradient =
        Prefixed_Name(modsci, "temperature_gradient") |> PrefixedName

    /// <summary>
    ///   <para>w3id:skgo/modsci#undertakesResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#undertakesResearch">https://w3id.org/skgo/modsci#undertakesResearch</seealso>
    let undertakesResearch = Prefixed_Name(modsci, "undertakesResearch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#usesMethodsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#usesMethodsFrom">https://w3id.org/skgo/modsci#usesMethodsFrom</seealso>
    let usesMethodsFrom = Prefixed_Name(modsci, "usesMethodsFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#usesTechniquesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#usesTechniquesFrom">https://w3id.org/skgo/modsci#usesTechniquesFrom</seealso>
    let usesTechniquesFrom = Prefixed_Name(modsci, "usesTechniquesFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#x</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#x">https://w3id.org/skgo/modsci#x</seealso>
    let x = Prefixed_Name(modsci, "x") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#y</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#y">https://w3id.org/skgo/modsci#y</seealso>
    let y = Prefixed_Name(modsci, "y") |> PrefixedName
    /// <summary>
    ///   <para>w3id:skgo/modsci#z</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/skgo/modsci#z">https://w3id.org/skgo/modsci#z</seealso>
    let z = Prefixed_Name(modsci, "z") |> PrefixedName
