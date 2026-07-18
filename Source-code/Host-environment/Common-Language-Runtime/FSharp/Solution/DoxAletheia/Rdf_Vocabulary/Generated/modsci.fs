namespace https.w3id.org.skgo.modsci.hash

open DoxAletheia.Rdf_Vocabulary

module modsci =
    let _namespace_name = "https://w3id.org/skgo/modsci#"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#z"></see>
    /// </summary>
    let z = Namespaced_IRI.parse _namespace_name "z" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#y"></see>
    /// </summary>
    let y = Namespaced_IRI.parse _namespace_name "y" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#scientistBelongsTo"></see>
    /// </summary>
    let scientistBelongsTo =
        Namespaced_IRI.parse _namespace_name "scientistBelongsTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#x"></see>
    /// </summary>
    let x = Namespaced_IRI.parse _namespace_name "x" |> NamespacedName

    /// <summary>
    /// An organization which is created for the purpose of scientific research and development.
    /// <see href="https://w3id.org/skgo/modsci#ScientificOrganization"></see></summary>
    let ScientificOrganization =
        Namespaced_IRI.parse _namespace_name "ScientificOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isDiscoveredBy"></see>
    /// </summary>
    let isDiscoveredBy =
        Namespaced_IRI.parse _namespace_name "isDiscoveredBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isDiscoveredByScientist"></see>
    /// </summary>
    let isDiscoveredByScientist =
        Namespaced_IRI.parse _namespace_name "isDiscoveredByScientist" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isDiscoveredByOrganization"></see>
    /// </summary>
    let isDiscoveredByOrganization =
        Namespaced_IRI.parse _namespace_name "isDiscoveredByOrganization" |> NamespacedName

    /// <summary>
    /// A scientist is someone who conducts scientific research to advance knowledge in an area of interest.
    /// <see href="https://w3id.org/skgo/modsci#Scientist"></see></summary>
    let Scientist = Namespaced_IRI.parse _namespace_name "Scientist" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByScientist"></see>
    /// </summary>
    let discoveredByScientist =
        Namespaced_IRI.parse _namespace_name "discoveredByScientist" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByScience"></see>
    /// </summary>
    let discoveredByScience =
        Namespaced_IRI.parse _namespace_name "discoveredByScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ADInstruments"></see>
    /// </summary>
    let ADInstruments =
        Namespaced_IRI.parse _namespace_name "ADInstruments" |> NamespacedName

    /// <summary>
    /// Companies manufacturing equipment for scientific sstudies.
    /// <see href="https://w3id.org/skgo/modsci#ScientificInstrumentManufacturer"></see></summary>
    let ScientificInstrumentManufacturer =
        Namespaced_IRI.parse _namespace_name "ScientificInstrumentManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Accelerometer"></see>
    /// </summary>
    let Accelerometer =
        Namespaced_IRI.parse _namespace_name "Accelerometer" |> NamespacedName

    /// <summary>
    /// A scientific instrument is, broadly speaking, a device or tool used for scientific purposes, including the study of both natural phenomena and theoretical research.
    /// <see href="https://w3id.org/skgo/modsci#ScientificInstrument"></see></summary>
    let ScientificInstrument =
        Namespaced_IRI.parse _namespace_name "ScientificInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Accumulator"></see>
    /// </summary>
    let Accumulator =
        Namespaced_IRI.parse _namespace_name "Accumulator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InstrumentFunctionDesription"></see>
    /// </summary>
    let InstrumentFunctionDesription =
        Namespaced_IRI.parse _namespace_name "InstrumentFunctionDesription" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#instrumentInventedBy"></see>
    /// </summary>
    let instrumentInventedBy =
        Namespaced_IRI.parse _namespace_name "instrumentInventedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Waldemar_Jungner"></see>
    /// </summary>
    let Waldemar_Jungner =
        Namespaced_IRI.parse _namespace_name "Waldemar_Jungner" |> NamespacedName

    /// <summary>
    /// For chemicals that can behave as acids or bases
    /// <see href="https://w3id.org/skgo/modsci#AcidbaseChemistry"></see></summary>
    let AcidbaseChemistry =
        Namespaced_IRI.parse _namespace_name "AcidbaseChemistry" |> NamespacedName

    /// <summary>
    /// Chemistry is defined as the science of matter, different from physics, in terms of matter's chemical structure, reactivity, properties and reactions or transformations.
    /// <see href="https://w3id.org/skgo/modsci#Chemistry"></see></summary>
    let Chemistry = Namespaced_IRI.parse _namespace_name "Chemistry" |> NamespacedName
    /// <summary>
    /// Acoustics is a branch of continuum mechanics and is the study of sound, mechanical waves in gases, liquids, and solids.
    /// <see href="https://w3id.org/skgo/modsci#Acoustics"></see></summary>
    let Acoustics = Namespaced_IRI.parse _namespace_name "Acoustics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ClassicalPhysics"></see>
    /// </summary>
    let ClassicalPhysics =
        Namespaced_IRI.parse _namespace_name "ClassicalPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AgilentTechnologies"></see>
    /// </summary>
    let AgilentTechnologies =
        Namespaced_IRI.parse _namespace_name "AgilentTechnologies" |> NamespacedName

    /// <summary>
    /// Agriculture, also known as farming, is the process of producing food, feed, fiber and other desired products by cultivation of certain plants and the raising of domesticated animals.
    /// <see href="https://w3id.org/skgo/modsci#Agriculture"></see></summary>
    let Agriculture =
        Namespaced_IRI.parse _namespace_name "Agriculture" |> NamespacedName

    /// <summary>
    /// Applied science is the use or the study of the use of scientific knowledge to develop technology.
    /// <see href="https://w3id.org/skgo/modsci#AppliedSciences"></see></summary>
    let AppliedSciences =
        Namespaced_IRI.parse _namespace_name "AppliedSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Agronomy"></see>
    /// </summary>
    let Agronomy = Namespaced_IRI.parse _namespace_name "Agronomy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Algebra"></see>
    /// </summary>
    let Algebra = Namespaced_IRI.parse _namespace_name "Algebra" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PureMathematics"></see>
    /// </summary>
    let PureMathematics =
        Namespaced_IRI.parse _namespace_name "PureMathematics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Algorithms"></see>
    /// </summary>
    let Algorithms = Namespaced_IRI.parse _namespace_name "Algorithms" |> NamespacedName

    /// <summary>
    /// A scientific method is a sequence or collection of processes that are considered characteristic of scientific investigation and the acquisition of new scientific knowledge based upon physical evidence.
    /// <see href="https://w3id.org/skgo/modsci#ScientificMethod"></see></summary>
    let ScientificMethod =
        Namespaced_IRI.parse _namespace_name "ScientificMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ammeter"></see>
    /// </summary>
    let Ammeter = Namespaced_IRI.parse _namespace_name "Ammeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Friedrich_Drexler"></see>
    /// </summary>
    let Friedrich_Drexler =
        Namespaced_IRI.parse _namespace_name "Friedrich_Drexler" |> NamespacedName

    /// <summary>
    /// Analytical chemistry is the analysis of material samples to gain an understanding of their chemical composition and structure.
    /// <see href="https://w3id.org/skgo/modsci#AnalyticalChemistry"></see></summary>
    let AnalyticalChemistry =
        Namespaced_IRI.parse _namespace_name "AnalyticalChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AnalyticalSpectrometry"></see>
    /// </summary>
    let AnalyticalSpectrometry =
        Namespaced_IRI.parse _namespace_name "AnalyticalSpectrometry" |> NamespacedName

    /// <summary>
    /// Anatomy is the study of the structure and organization of living things.
    /// <see href="https://w3id.org/skgo/modsci#Anatomy"></see></summary>
    let Anatomy = Namespaced_IRI.parse _namespace_name "Anatomy" |> NamespacedName
    /// <summary>
    /// Biology is the science of life. It is concerned with the characteristics and behaviors of organisms
    /// <see href="https://w3id.org/skgo/modsci#Biology"></see></summary>
    let Biology = Namespaced_IRI.parse _namespace_name "Biology" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Anemometer"></see>
    /// </summary>
    let Anemometer = Namespaced_IRI.parse _namespace_name "Anemometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AnimalProduction"></see>
    /// </summary>
    let AnimalProduction =
        Namespaced_IRI.parse _namespace_name "AnimalProduction" |> NamespacedName

    /// <summary>
    /// Anthropology is the scientific study of humans, human behavior and societies in the past and present.
    /// <see href="https://w3id.org/skgo/modsci#Anthropology"></see></summary>
    let Anthropology =
        Namespaced_IRI.parse _namespace_name "Anthropology" |> NamespacedName

    /// <summary>
    /// The social sciences are academic disciplines concerned with the study of the social life of human groups and individuals including anthropology, economics, geography, history, political science, psychology, social studies, and sociology.
    /// <see href="https://w3id.org/skgo/modsci#SocialSciences"></see></summary>
    let SocialSciences =
        Namespaced_IRI.parse _namespace_name "SocialSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AntonPaar"></see>
    /// </summary>
    let AntonPaar = Namespaced_IRI.parse _namespace_name "AntonPaar" |> NamespacedName

    /// <summary>
    /// An application of science is any use of scientific knowledge for a specific purpose, whether to do more science; to design a product, process, or medical treatment; to develop a new technology; or to predict the impacts of human actions.
    /// <see href="https://w3id.org/skgo/modsci#ApplicationOfScience"></see></summary>
    let ApplicationOfScience =
        Namespaced_IRI.parse _namespace_name "ApplicationOfScience" |> NamespacedName

    /// <summary>
    /// Applied mathematics is a branch of mathematics that concerns itself with the application of mathematical knowledge to other domains.
    /// <see href="https://w3id.org/skgo/modsci#AppliedMathematics"></see></summary>
    let AppliedMathematics =
        Namespaced_IRI.parse _namespace_name "AppliedMathematics" |> NamespacedName

    /// <summary>
    /// Mathematics (colloquially, maths, or math), is the body of knowledge centered on concepts such as quantity, structure, space, and change, and also the academic discipline that studies them.
    /// <see href="https://w3id.org/skgo/modsci#Mathematics"></see></summary>
    let Mathematics =
        Namespaced_IRI.parse _namespace_name "Mathematics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AppliedMechanics"></see>
    /// </summary>
    let AppliedMechanics =
        Namespaced_IRI.parse _namespace_name "AppliedMechanics" |> NamespacedName

    /// <summary>
    /// Applied physics is intended for a particular technological or practical use.
    /// <see href="https://w3id.org/skgo/modsci#AppliedPhysics"></see></summary>
    let AppliedPhysics =
        Namespaced_IRI.parse _namespace_name "AppliedPhysics" |> NamespacedName

    /// <summary>
    /// Physics is the science of the natural world. It deals with matter, energy, and the fundamental forces that govern the interactions between particles.
    /// <see href="https://w3id.org/skgo/modsci#Physics"></see></summary>
    let Physics = Namespaced_IRI.parse _namespace_name "Physics" |> NamespacedName

    /// <summary>
    /// Interdisciplinarity or interdisciplinary studies involves the combining of two or more academic disciplines into one activity (e.g., a research project).
    /// <see href="https://w3id.org/skgo/modsci#InterdisciplinaryStudies"></see></summary>
    let InterdisciplinaryStudies =
        Namespaced_IRI.parse _namespace_name "InterdisciplinaryStudies" |> NamespacedName

    /// <summary>
    /// Science is a systematic enterprise that builds and organizes knowledge in the form of testable explanations and predictions about the universe.
    /// <see href="https://w3id.org/skgo/modsci#ModernScience"></see></summary>
    let ModernScience =
        Namespaced_IRI.parse _namespace_name "ModernScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ApproximationTheory"></see>
    /// </summary>
    let ApproximationTheory =
        Namespaced_IRI.parse _namespace_name "ApproximationTheory" |> NamespacedName

    /// <summary>
    /// Archaeology, or archeology, is the study of human activity through the recovery and analysis of material culture.
    /// <see href="https://w3id.org/skgo/modsci#Archaeology"></see></summary>
    let Archaeology =
        Namespaced_IRI.parse _namespace_name "Archaeology" |> NamespacedName

    /// <summary>
    /// Architecture is the art and science of designing buildings.
    /// <see href="https://w3id.org/skgo/modsci#Architecture"></see></summary>
    let Architecture =
        Namespaced_IRI.parse _namespace_name "Architecture" |> NamespacedName

    /// <summary>
    /// In computer science, artificial intelligence (AI), sometimes called machine intelligence, is intelligence demonstrated by machines, in contrast to the natural intelligence displayed by humans. Colloquially, the term "artificial intelligence" is often used to describe machines (or computers) that mimic "cognitive" functions that humans associate with the human mind, such as "learning" and "problem solving".
    /// <see href="https://w3id.org/skgo/modsci#ArtificialIntelligence"></see></summary>
    let ArtificialIntelligence =
        Namespaced_IRI.parse _namespace_name "ArtificialIntelligence" |> NamespacedName

    /// <summary>
    /// Computer science is the study of processes that interact with data and that can be represented as data in the form of programs.
    /// <see href="https://w3id.org/skgo/modsci#ComputerScience"></see></summary>
    let ComputerScience =
        Namespaced_IRI.parse _namespace_name "ComputerScience" |> NamespacedName

    /// <summary>
    /// Astrobiology, formerly known as exobiology, is an interdisciplinary scientific field concerned with the origins, early evolution, distribution, and future of life in the universe.
    /// <see href="https://w3id.org/skgo/modsci#Astrobiology"></see></summary>
    let Astrobiology =
        Namespaced_IRI.parse _namespace_name "Astrobiology" |> NamespacedName

    /// <summary>
    /// Astrochemistry is the study of the abundance and reactions of molecules in the Universe, and their interaction with radiation.
    /// <see href="https://w3id.org/skgo/modsci#Astrochemistry"></see></summary>
    let Astrochemistry =
        Namespaced_IRI.parse _namespace_name "Astrochemistry" |> NamespacedName

    /// <summary>
    /// Astrometry is the study of the positions, distances between, and motions of astronomical objects.
    /// <see href="https://w3id.org/skgo/modsci#Astrometry"></see></summary>
    let Astrometry = Namespaced_IRI.parse _namespace_name "Astrometry" |> NamespacedName
    /// <summary>
    /// is a science involving the observation and explanation of events occurring outside Earth and its atmosphere.
    /// <see href="https://w3id.org/skgo/modsci#Astronomy"></see></summary>
    let Astronomy = Namespaced_IRI.parse _namespace_name "Astronomy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AstronomicalPhenomena"></see>
    /// </summary>
    let AstronomicalPhenomena =
        Namespaced_IRI.parse _namespace_name "AstronomicalPhenomena" |> NamespacedName

    /// <summary>
    /// Natural phenomena include gravity, tides, biological processes and oscillation.
    /// <see href="https://w3id.org/skgo/modsci#NaturalPhenomenon"></see></summary>
    let NaturalPhenomenon =
        Namespaced_IRI.parse _namespace_name "NaturalPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Astronomical_Studies"></see>
    /// </summary>
    let Astronomical_Studies =
        Namespaced_IRI.parse _namespace_name "Astronomical_Studies" |> NamespacedName

    /// <summary>
    /// The natural sciences are those branches of empirical science that produce a comprehension of the natural world through the use of data collected from it by observation and measurement to construct deterministic and/or stochastic quantitative models of its phenomena.
    /// <see href="https://w3id.org/skgo/modsci#NaturalScience"></see></summary>
    let NaturalScience =
        Namespaced_IRI.parse _namespace_name "NaturalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AtmosphericPhenomena"></see>
    /// </summary>
    let AtmosphericPhenomena =
        Namespaced_IRI.parse _namespace_name "AtmosphericPhenomena" |> NamespacedName

    /// <summary>
    /// Atmospheric science is an umbrella term for the study of the atmosphere and its processes.
    /// <see href="https://w3id.org/skgo/modsci#AtmosphericSciences"></see></summary>
    let AtmosphericSciences =
        Namespaced_IRI.parse _namespace_name "AtmosphericSciences" |> NamespacedName

    /// <summary>
    /// Earth science (also known as geoscience, the geosciences, or the Earth sciences) includes all the sciences related to the planet Earth.
    /// <see href="https://w3id.org/skgo/modsci#EarthScience"></see></summary>
    let EarthScience =
        Namespaced_IRI.parse _namespace_name "EarthScience" |> NamespacedName

    /// <summary>
    /// Atomic, molecular, and optical physics (AMO) is the study of matter-matter and light-matter interactions; at the scale of one or a few atoms and energy scales around several electron volts.
    /// <see href="https://w3id.org/skgo/modsci#AtomicPhysics"></see></summary>
    let AtomicPhysics =
        Namespaced_IRI.parse _namespace_name "AtomicPhysics" |> NamespacedName

    /// <summary>
    /// Molecular physics deals with the physics and chemistry of molecules.
    /// <see href="https://w3id.org/skgo/modsci#MolecularPhysics"></see></summary>
    let MolecularPhysics =
        Namespaced_IRI.parse _namespace_name "MolecularPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Aurora"></see>
    /// </summary>
    let Aurora = Namespaced_IRI.parse _namespace_name "Aurora" |> NamespacedName

    /// <summary>
    /// Automata theory is the study of abstract machines and automata, as well as the computational problems that can be solved using them.
    /// <see href="https://w3id.org/skgo/modsci#AutomataTheory"></see></summary>
    let AutomataTheory =
        Namespaced_IRI.parse _namespace_name "AutomataTheory" |> NamespacedName

    /// <summary>
    /// Theory of computation is focused on answering fundamental questions about what can be computed and what amount of resources are required to perform those computations.
    /// <see href="https://w3id.org/skgo/modsci#TheoryOfComputation"></see></summary>
    let TheoryOfComputation =
        Namespaced_IRI.parse _namespace_name "TheoryOfComputation" |> NamespacedName

    /// <summary>
    /// Automated reasoning is an area of computer science, cognitive science, and mathematical logic dedicated to understanding different aspects of reasoning.
    /// <see href="https://w3id.org/skgo/modsci#AutomatedReasoning"></see></summary>
    let AutomatedReasoning =
        Namespaced_IRI.parse _namespace_name "AutomatedReasoning" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Barometer"></see>
    /// </summary>
    let Barometer = Namespaced_IRI.parse _namespace_name "Barometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Evangelista_Torricelli"></see>
    /// </summary>
    let Evangelista_Torricelli =
        Namespaced_IRI.parse _namespace_name "Evangelista_Torricelli" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BasinAnalysis"></see>
    /// </summary>
    let BasinAnalysis =
        Namespaced_IRI.parse _namespace_name "BasinAnalysis" |> NamespacedName

    /// <summary>
    /// Geology is an earth science concerned with the solid Earth, the rocks of which it is composed, and the processes by which they change over time.
    /// <see href="https://w3id.org/skgo/modsci#Geology"></see></summary>
    let Geology = Namespaced_IRI.parse _namespace_name "Geology" |> NamespacedName

    /// <summary>
    /// Behavioural sciences explore the cognitive processes within organisms and the behavioural interactions between organisms in the natural world.
    /// <see href="https://w3id.org/skgo/modsci#BehaviouralSciences"></see></summary>
    let BehaviouralSciences =
        Namespaced_IRI.parse _namespace_name "BehaviouralSciences" |> NamespacedName

    /// <summary>
    /// Biochemistry is the chemistry of life.
    /// <see href="https://w3id.org/skgo/modsci#Biochemistry"></see></summary>
    let Biochemistry =
        Namespaced_IRI.parse _namespace_name "Biochemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biochip"></see>
    /// </summary>
    let Biochip = Namespaced_IRI.parse _namespace_name "Biochip" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfScience"></see>
    /// </summary>
    let isApplicationOfScience =
        Namespaced_IRI.parse _namespace_name "isApplicationOfScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Studying_biochemical_reactions"></see>
    /// </summary>
    let Studying_biochemical_reactions =
        Namespaced_IRI.parse _namespace_name "Studying_biochemical_reactions" |> NamespacedName

    /// <summary>
    /// Biological engineering, or bioengineering/bio-engineering, is the application of principles of biology and the tools of engineering to create usable, tangible, economically viable products.
    /// <see href="https://w3id.org/skgo/modsci#Bioengineering"></see></summary>
    let Bioengineering =
        Namespaced_IRI.parse _namespace_name "Bioengineering" |> NamespacedName

    /// <summary>
    /// Engineering is the practical application of science. This is accomplished through knowledge, mathematics, and practical experience applied to the design of useful objects or processes.
    /// <see href="https://w3id.org/skgo/modsci#Engineering"></see></summary>
    let Engineering =
        Namespaced_IRI.parse _namespace_name "Engineering" |> NamespacedName

    /// <summary>
    /// Bioethics is the study of the ethical issues emerging from advances in biology and medicine.
    /// <see href="https://w3id.org/skgo/modsci#Bioethics"></see></summary>
    let Bioethics = Namespaced_IRI.parse _namespace_name "Bioethics" |> NamespacedName

    /// <summary>
    /// Biogeography is the study of the distribution of species and ecosystems in geographic space and through geological time.
    /// <see href="https://w3id.org/skgo/modsci#Biogeography"></see></summary>
    let Biogeography =
        Namespaced_IRI.parse _namespace_name "Biogeography" |> NamespacedName

    /// <summary>
    /// Bioinformatics and Computational biology are interdisciplinary fields of research, development and application of algorithms, computational and statistical methods for management and analysis of biological data, and for solving basic biological problems.
    /// <see href="https://w3id.org/skgo/modsci#Bioinformatics"></see></summary>
    let Bioinformatics =
        Namespaced_IRI.parse _namespace_name "Bioinformatics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BioinformaticsSoftware"></see>
    /// </summary>
    let BioinformaticsSoftware =
        Namespaced_IRI.parse _namespace_name "BioinformaticsSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ComputerSoftware"></see>
    /// </summary>
    let ComputerSoftware =
        Namespaced_IRI.parse _namespace_name "ComputerSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BioinorganicChemistry"></see>
    /// </summary>
    let BioinorganicChemistry =
        Namespaced_IRI.parse _namespace_name "BioinorganicChemistry" |> NamespacedName

    /// <summary>
    /// Inorganic chemistry is a catch-all discipline that covers everything in chemistry that is not organic chemistry.
    /// <see href="https://w3id.org/skgo/modsci#InorganicChemistry"></see></summary>
    let InorganicChemistry =
        Namespaced_IRI.parse _namespace_name "InorganicChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BiologicalMathematics"></see>
    /// </summary>
    let BiologicalMathematics =
        Namespaced_IRI.parse _namespace_name "BiologicalMathematics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BiologicalOceanography"></see>
    /// </summary>
    let BiologicalOceanography =
        Namespaced_IRI.parse _namespace_name "BiologicalOceanography" |> NamespacedName

    /// <summary>
    /// Oceanography also known as oceanology, is the study of the physical and biological aspects of the ocean.
    /// <see href="https://w3id.org/skgo/modsci#Oceanography"></see></summary>
    let Oceanography =
        Namespaced_IRI.parse _namespace_name "Oceanography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BiologicalPhenomena"></see>
    /// </summary>
    let BiologicalPhenomena =
        Namespaced_IRI.parse _namespace_name "BiologicalPhenomena" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biological_Studies"></see>
    /// </summary>
    let Biological_Studies =
        Namespaced_IRI.parse _namespace_name "Biological_Studies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFrom"></see>
    /// </summary>
    let appliesLawsFrom =
        Namespaced_IRI.parse _namespace_name "appliesLawsFrom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Physical_Studies"></see>
    /// </summary>
    let Physical_Studies =
        Namespaced_IRI.parse _namespace_name "Physical_Studies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#requiresKnowledgeFrom"></see>
    /// </summary>
    let requiresKnowledgeFrom =
        Namespaced_IRI.parse _namespace_name "requiresKnowledgeFrom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Historical_Studies"></see>
    /// </summary>
    let Historical_Studies =
        Namespaced_IRI.parse _namespace_name "Historical_Studies" |> NamespacedName

    /// <summary>
    /// Biomedical engineering (BME) or medical engineering is the application of engineering principles and design concepts to medicine and biology for healthcare purposes (e.g. diagnostic or therapeutic).
    /// <see href="https://w3id.org/skgo/modsci#BiomedicalEngineering"></see></summary>
    let BiomedicalEngineering =
        Namespaced_IRI.parse _namespace_name "BiomedicalEngineering" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biomedical_Signals"></see>
    /// </summary>
    let Biomedical_Signals =
        Namespaced_IRI.parse _namespace_name "Biomedical_Signals" |> NamespacedName

    /// <summary>
    /// Scientific Discovery is the process or product of successful scientific inquiry. Objects of discovery can be things, events, processes, causes, and properties as well as theories and hypotheses and their features (their explanatory power, for example).
    /// <see href="https://w3id.org/skgo/modsci#ScientificDiscovery"></see></summary>
    let ScientificDiscovery =
        Namespaced_IRI.parse _namespace_name "ScientificDiscovery" |> NamespacedName

    /// <summary>
    /// Biophysics is an interdisciplinary science that applies approaches and methods traditionally used in physics to study biological phenomena.
    /// <see href="https://w3id.org/skgo/modsci#Biophysics"></see></summary>
    let Biophysics = Namespaced_IRI.parse _namespace_name "Biophysics" |> NamespacedName

    /// <summary>
    /// Biological psychology,is the application of the principles of biology to the study of physiological and developmental mechanisms of behavior in humans and other animals.
    /// <see href="https://w3id.org/skgo/modsci#Biopsychology"></see></summary>
    let Biopsychology =
        Namespaced_IRI.parse _namespace_name "Biopsychology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biosensors"></see>
    /// </summary>
    let Biosensors = Namespaced_IRI.parse _namespace_name "Biosensors" |> NamespacedName

    /// <summary>
    /// Biostatistics are the development and application of statistical methods to a wide range of topics in biology.
    /// <see href="https://w3id.org/skgo/modsci#Biostatistics"></see></summary>
    let Biostatistics =
        Namespaced_IRI.parse _namespace_name "Biostatistics" |> NamespacedName

    /// <summary>
    /// Biotechnology is a technology based on biology, especially when used in agriculture, food science, medicine, and genetic engineering.
    /// <see href="https://w3id.org/skgo/modsci#Biotechnology"></see></summary>
    let Biotechnology =
        Namespaced_IRI.parse _namespace_name "Biotechnology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Boiling"></see>
    /// </summary>
    let Boiling = Namespaced_IRI.parse _namespace_name "Boiling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PhysicalPhenomena"></see>
    /// </summary>
    let PhysicalPhenomena =
        Namespaced_IRI.parse _namespace_name "PhysicalPhenomena" |> NamespacedName

    /// <summary>
    /// Botany also called plant science(s), plant biology or phytology, is the science of plant life and a branch of biology.
    /// <see href="https://w3id.org/skgo/modsci#Botany"></see></summary>
    let Botany = Namespaced_IRI.parse _namespace_name "Botany" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Breaking_waves"></see>
    /// </summary>
    let Breaking_waves =
        Namespaced_IRI.parse _namespace_name "Breaking_waves" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OceanographicPhenomena"></see>
    /// </summary>
    let OceanographicPhenomena =
        Namespaced_IRI.parse _namespace_name "OceanographicPhenomena" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Bruker"></see>
    /// </summary>
    let Bruker = Namespaced_IRI.parse _namespace_name "Bruker" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CalculusOfVariations"></see>
    /// </summary>
    let CalculusOfVariations =
        Namespaced_IRI.parse _namespace_name "CalculusOfVariations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Caliper"></see>
    /// </summary>
    let Caliper = Namespaced_IRI.parse _namespace_name "Caliper" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Calorimeter"></see>
    /// </summary>
    let Calorimeter =
        Namespaced_IRI.parse _namespace_name "Calorimeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Catalysis"></see>
    /// </summary>
    let Catalysis = Namespaced_IRI.parse _namespace_name "Catalysis" |> NamespacedName

    /// <summary>
    /// Physical chemistry is the study of macroscopic, atomic, subatomic, and particulate phenomena in chemical systems in terms of the principles, practices, and concepts of physics such as motion, energy, force, time, thermodynamics, quantum chemistry, statistical mechanics, analytical dynamics and chemical equilibrium.
    /// <see href="https://w3id.org/skgo/modsci#PhysicalChemistry"></see></summary>
    let PhysicalChemistry =
        Namespaced_IRI.parse _namespace_name "PhysicalChemistry" |> NamespacedName

    /// <summary>
    /// Cell biology is a branch of biology that studies the structure and function of the cell, which is the basic unit of life.
    /// <see href="https://w3id.org/skgo/modsci#CellBiology"></see></summary>
    let CellBiology =
        Namespaced_IRI.parse _namespace_name "CellBiology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalCharacterisationOfMaterials"></see>
    /// </summary>
    let ChemicalCharacterisationOfMaterials =
        Namespaced_IRI.parse _namespace_name "ChemicalCharacterisationOfMaterials" |> NamespacedName

    /// <summary>
    /// The interdisciplinary field of materials science is the design and discovery of new materials, particularly solids.
    /// <see href="https://w3id.org/skgo/modsci#MaterialsChemistry"></see></summary>
    let MaterialsChemistry =
        Namespaced_IRI.parse _namespace_name "MaterialsChemistry" |> NamespacedName

    /// <summary>
    /// Chemical engineering is the application of science, in particular chemistry, fluid physics, and biology, along with mathematics and economics to the human endeavor of converting raw materials or chemicals into more useful or valuable forms.
    /// <see href="https://w3id.org/skgo/modsci#ChemicalEngineering"></see></summary>
    let ChemicalEngineering =
        Namespaced_IRI.parse _namespace_name "ChemicalEngineering" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalOceanography"></see>
    /// </summary>
    let ChemicalOceanography =
        Namespaced_IRI.parse _namespace_name "ChemicalOceanography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalPhenomena"></see>
    /// </summary>
    let ChemicalPhenomena =
        Namespaced_IRI.parse _namespace_name "ChemicalPhenomena" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalThermodynamics"></see>
    /// </summary>
    let ChemicalThermodynamics =
        Namespaced_IRI.parse _namespace_name "ChemicalThermodynamics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Chemical_Studies"></see>
    /// </summary>
    let Chemical_Studies =
        Namespaced_IRI.parse _namespace_name "Chemical_Studies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasCloseRelationshipTo"></see>
    /// </summary>
    let hasCloseRelationshipTo =
        Namespaced_IRI.parse _namespace_name "hasCloseRelationshipTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ClassificationAlgorithms"></see>
    /// </summary>
    let ClassificationAlgorithms =
        Namespaced_IRI.parse _namespace_name "ClassificationAlgorithms" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CoalGeology"></see>
    /// </summary>
    let CoalGeology =
        Namespaced_IRI.parse _namespace_name "CoalGeology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CodingAndInformationTheory"></see>
    /// </summary>
    let CodingAndInformationTheory =
        Namespaced_IRI.parse _namespace_name "CodingAndInformationTheory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DataFormat"></see>
    /// </summary>
    let DataFormat = Namespaced_IRI.parse _namespace_name "DataFormat" |> NamespacedName

    /// <summary>
    /// Cognitive science is the interdisciplinary, scientific study of the mind and its processes.
    /// <see href="https://w3id.org/skgo/modsci#CognitiveScience"></see></summary>
    let CognitiveScience =
        Namespaced_IRI.parse _namespace_name "CognitiveScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Colloid"></see>
    /// </summary>
    let Colloid = Namespaced_IRI.parse _namespace_name "Colloid" |> NamespacedName

    /// <summary>
    /// Interface and colloid science is an interdisciplinary intersection of branches of chemistry, physics, nanoscience and other fields dealing with colloids, heterogeneous systems consisting of a mechanical mixture of particles between 1 nm and 1000 nm dispersed in a continuous medium.
    /// <see href="https://w3id.org/skgo/modsci#ColloidalChemistry"></see></summary>
    let ColloidalChemistry =
        Namespaced_IRI.parse _namespace_name "ColloidalChemistry" |> NamespacedName

    /// <summary>
    /// Communications security is the discipline of preventing unauthorized interceptors from accessing telecommunications in an intelligible form, while still delivering content to the intended recipients.
    /// <see href="https://w3id.org/skgo/modsci#CommunicationAndSecurity"></see></summary>
    let CommunicationAndSecurity =
        Namespaced_IRI.parse _namespace_name "CommunicationAndSecurity" |> NamespacedName

    /// <summary>
    /// Communication is the act of conveying meanings from one entity or group to another through the use of mutually understood signs, symbols, and semiotic rules.
    /// <see href="https://w3id.org/skgo/modsci#CommunicationStudies"></see></summary>
    let CommunicationStudies =
        Namespaced_IRI.parse _namespace_name "CommunicationStudies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Community_of_European_Solar_Radio_Astronomers"></see>
    /// </summary>
    let Community_of_European_Solar_Radio_Astronomers =
        Namespaced_IRI.parse _namespace_name "Community_of_European_Solar_Radio_Astronomers" |> NamespacedName

    /// <summary>
    /// A compiler implements a formal transformation from a high-level source program to a low-level target program.
    /// <see href="https://w3id.org/skgo/modsci#CompilerTheory"></see></summary>
    let CompilerTheory =
        Namespaced_IRI.parse _namespace_name "CompilerTheory" |> NamespacedName

    /// <summary>
    /// Programming languages can be used to accomplish different tasks in different ways.
    /// <see href="https://w3id.org/skgo/modsci#ProgrammingLanguages"></see></summary>
    let ProgrammingLanguages =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguages" |> NamespacedName

    /// <summary>
    /// Computability theory, also known as recursion theory, is a branch of mathematical logic, of computer science, and of the theory of computation that originated in the 1930s with the study of computable functions and Turing degrees.
    /// <see href="https://w3id.org/skgo/modsci#ComputabilityTheory"></see></summary>
    let ComputabilityTheory =
        Namespaced_IRI.parse _namespace_name "ComputabilityTheory" |> NamespacedName

    /// <summary>
    /// Computational complexity theory focuses on classifying computational problems according to their inherent difficulty, and relating these classes to each other. A computational problem is a task solved by a computer.
    /// <see href="https://w3id.org/skgo/modsci#ComputationalComplexityTheory"></see></summary>
    let ComputationalComplexityTheory =
        Namespaced_IRI.parse _namespace_name "ComputationalComplexityTheory" |> NamespacedName

    /// <summary>
    /// Computational linguistics is an interdisciplinary field concerned with the statistical or rule-based modeling of natural language from a computational perspective, as well as the study of appropriate computational approaches to linguistic questions.
    /// <see href="https://w3id.org/skgo/modsci#ComputationalLinguistics"></see></summary>
    let ComputationalLinguistics =
        Namespaced_IRI.parse _namespace_name "ComputationalLinguistics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ComputationalMathematics"></see>
    /// </summary>
    let ComputationalMathematics =
        Namespaced_IRI.parse _namespace_name "ComputationalMathematics" |> NamespacedName

    /// <summary>
    /// Computational physics is the study and implementation of numerical algorithms in order to solve problems in physics for which a quantitative theory already exists.
    /// <see href="https://w3id.org/skgo/modsci#ComputationalPhysics"></see></summary>
    let ComputationalPhysics =
        Namespaced_IRI.parse _namespace_name "ComputationalPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Computer-HumanInteraction"></see>
    /// </summary>
    let ``Computer-HumanInteraction`` =
        Namespaced_IRI.parse _namespace_name "Computer-HumanInteraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationSystems"></see>
    /// </summary>
    let InformationSystems =
        Namespaced_IRI.parse _namespace_name "InformationSystems" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ComputerApplications"></see>
    /// </summary>
    let ComputerApplications =
        Namespaced_IRI.parse _namespace_name "ComputerApplications" |> NamespacedName

    /// <summary>
    /// In computer science, concurrency is the ability of different parts or units of a program, algorithm, or problem to be executed out-of-order or in partial order, without affecting the final outcome. This allows for parallel execution of the concurrent units, which can significantly improve overall speed of the execution in multi-processor and multi-core systems.
    /// <see href="https://w3id.org/skgo/modsci#ComputerConcurrency"></see></summary>
    let ComputerConcurrency =
        Namespaced_IRI.parse _namespace_name "ComputerConcurrency" |> NamespacedName

    /// <summary>
    /// Systems in which several computations are executing simultaneously, and potentially interacting with each other.
    /// <see href="https://w3id.org/skgo/modsci#DistributedSystems"></see></summary>
    let DistributedSystems =
        Namespaced_IRI.parse _namespace_name "DistributedSystems" |> NamespacedName

    /// <summary>
    /// Computer graphics is the study of digital visual contents and involves the synthesis and manipulation of image data.
    /// Computer graphics are pictures and films created using computers. Usually, the term refers to computer-generated image data created with the help of specialized graphical hardware and software.
    /// <see href="https://w3id.org/skgo/modsci#ComputerGraphics"></see></summary>
    let ComputerGraphics =
        Namespaced_IRI.parse _namespace_name "ComputerGraphics" |> NamespacedName

    /// <summary>
    /// In computer science, digital image processing is the use of computer algorithms to perform image processing on digital images.
    /// <see href="https://w3id.org/skgo/modsci#ImageProcessing"></see></summary>
    let ImageProcessing =
        Namespaced_IRI.parse _namespace_name "ImageProcessing" |> NamespacedName

    /// <summary>
    /// Computer security, cybersecurity or information technology security (IT security) is the protection of computer systems from the theft of or damage to their hardware, software, or electronic data, as well as from the disruption or misdirection of the services they provide.
    /// <see href="https://w3id.org/skgo/modsci#ComputerSecurity"></see></summary>
    let ComputerSecurity =
        Namespaced_IRI.parse _namespace_name "ComputerSecurity" |> NamespacedName

    /// <summary>
    /// In computer engineering, computer architecture is a set of rules and methods that describe the functionality, organization, and implementation of computer systems.
    /// <see href="https://w3id.org/skgo/modsci#ComputerSystemArchitecture"></see></summary>
    let ComputerSystemArchitecture =
        Namespaced_IRI.parse _namespace_name "ComputerSystemArchitecture" |> NamespacedName

    /// <summary>
    /// Computer vision is an interdisciplinary scientific field that deals with how computers can be made to gain high-level understanding from digital images or videos.
    /// <see href="https://w3id.org/skgo/modsci#ComputerVision"></see></summary>
    let ComputerVision =
        Namespaced_IRI.parse _namespace_name "ComputerVision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ConceptualModelling"></see>
    /// </summary>
    let ConceptualModelling =
        Namespaced_IRI.parse _namespace_name "ConceptualModelling" |> NamespacedName

    /// <summary>
    /// Condensed matter physics is the field of physics that deals with the macroscopic physical properties of matter.
    /// <see href="https://w3id.org/skgo/modsci#CondensedMatterPhysics"></see></summary>
    let CondensedMatterPhysics =
        Namespaced_IRI.parse _namespace_name "CondensedMatterPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Conservation_of_energy"></see>
    /// </summary>
    let Conservation_of_energy =
        Namespaced_IRI.parse _namespace_name "Conservation_of_energy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Julius_von_Mayer"></see>
    /// </summary>
    let Julius_von_Mayer =
        Namespaced_IRI.parse _namespace_name "Julius_von_Mayer" |> NamespacedName

    /// <summary>
    /// Physical cosmology is the study of the largest-scale structures and dynamics of the Universe and is concerned with fundamental questions about its origin, structure, evolution, and ultimate fate.
    /// <see href="https://w3id.org/skgo/modsci#Cosmology"></see></summary>
    let Cosmology = Namespaced_IRI.parse _namespace_name "Cosmology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CropProduction"></see>
    /// </summary>
    let CropProduction =
        Namespaced_IRI.parse _namespace_name "CropProduction" |> NamespacedName

    /// <summary>
    /// Cryobiology is the study of living organisms, organs, biological tissues or biological cells at low temperatures.
    /// <see href="https://w3id.org/skgo/modsci#Cryobiology"></see></summary>
    let Cryobiology =
        Namespaced_IRI.parse _namespace_name "Cryobiology" |> NamespacedName

    /// <summary>
    /// Cryptography or cryptology is the practice and study of techniques for secure communication in the presence of third parties called adversaries.
    /// <see href="https://w3id.org/skgo/modsci#Cryptography"></see></summary>
    let Cryptography =
        Namespaced_IRI.parse _namespace_name "Cryptography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Crystal_growth"></see>
    /// </summary>
    let Crystal_growth =
        Namespaced_IRI.parse _namespace_name "Crystal_growth" |> NamespacedName

    /// <summary>
    /// Crystallography is the scientific study of crystals.
    /// <see href="https://w3id.org/skgo/modsci#Crystallography"></see></summary>
    let Crystallography =
        Namespaced_IRI.parse _namespace_name "Crystallography" |> NamespacedName

    /// <summary>
    /// Cultural studies is a field of theoretically, politically, and empirically engaged cultural analysis that concentrates upon the political dynamics of contemporary culture, its historical foundations, defining traits, conflicts, and contingencies.
    /// <see href="https://w3id.org/skgo/modsci#CulturalStudies"></see></summary>
    let CulturalStudies =
        Namespaced_IRI.parse _namespace_name "CulturalStudies" |> NamespacedName

    /// <summary>
    /// Cybernetics is a transdisciplinary approach for exploring regulatory systems with feedback, their structures, constraints, and possibilities.
    /// <see href="https://w3id.org/skgo/modsci#Cybernetics"></see></summary>
    let Cybernetics =
        Namespaced_IRI.parse _namespace_name "Cybernetics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DNA_Sequencer"></see>
    /// </summary>
    let DNA_Sequencer =
        Namespaced_IRI.parse _namespace_name "DNA_Sequencer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DataEncryption"></see>
    /// </summary>
    let DataEncryption =
        Namespaced_IRI.parse _namespace_name "DataEncryption" |> NamespacedName

    /// <summary>
    /// Data mining is the process of discovering patterns in large data sets involving methods at the intersection of machine learning, statistics, and database systems.
    /// <see href="https://w3id.org/skgo/modsci#DataMining"></see></summary>
    let DataMining = Namespaced_IRI.parse _namespace_name "DataMining" |> NamespacedName

    /// <summary>
    /// Digital databases are managed using database management systems to store, create, maintain, and search data, through database models and query languages.
    /// <see href="https://w3id.org/skgo/modsci#DatabaseManagement"></see></summary>
    let DatabaseManagement =
        Namespaced_IRI.parse _namespace_name "DatabaseManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DataStructures"></see>
    /// </summary>
    let DataStructures =
        Namespaced_IRI.parse _namespace_name "DataStructures" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DecisionSupportSystems"></see>
    /// </summary>
    let DecisionSupportSystems =
        Namespaced_IRI.parse _namespace_name "DecisionSupportSystems" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Decision_Trees"></see>
    /// </summary>
    let Decision_Trees =
        Namespaced_IRI.parse _namespace_name "Decision_Trees" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Decomposition"></see>
    /// </summary>
    let Decomposition =
        Namespaced_IRI.parse _namespace_name "Decomposition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Deep_Learning"></see>
    /// </summary>
    let Deep_Learning =
        Namespaced_IRI.parse _namespace_name "Deep_Learning" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#inspiredFrom"></see>
    /// </summary>
    let inspiredFrom =
        Namespaced_IRI.parse _namespace_name "inspiredFrom" |> NamespacedName

    /// <summary>
    /// Dentistry, also known as Dental and Oral Medicine, is a branch of medicine that consists of the study, diagnosis, prevention, and treatment of diseases, disorders, and conditions of the oral cavity, commonly in the dentition but also the oral mucosa, and of adjacent and related structures and tissues, particularly in the maxillofacial (jaw and facial) area.
    /// <see href="https://w3id.org/skgo/modsci#Dentistry"></see></summary>
    let Dentistry = Namespaced_IRI.parse _namespace_name "Dentistry" |> NamespacedName

    /// <summary>
    /// Health sciences are those sciences which focus on health, or health care, as core parts of their subject matter.
    /// <see href="https://w3id.org/skgo/modsci#HealthSciences"></see></summary>
    let HealthSciences =
        Namespaced_IRI.parse _namespace_name "HealthSciences" |> NamespacedName

    /// <summary>
    /// Developmental biology is the study of the process by which animals and plants grow and develop.
    /// <see href="https://w3id.org/skgo/modsci#DevelopmentalBiology"></see></summary>
    let DevelopmentalBiology =
        Namespaced_IRI.parse _namespace_name "DevelopmentalBiology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DifferentialEquations"></see>
    /// </summary>
    let DifferentialEquations =
        Namespaced_IRI.parse _namespace_name "DifferentialEquations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DiscoveryOfMethods"></see>
    /// </summary>
    let DiscoveryOfMethods =
        Namespaced_IRI.parse _namespace_name "DiscoveryOfMethods" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DiscoveryOfPhenomenon"></see>
    /// </summary>
    let DiscoveryOfPhenomenon =
        Namespaced_IRI.parse _namespace_name "DiscoveryOfPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DiscreteMathematics"></see>
    /// </summary>
    let DiscreteMathematics =
        Namespaced_IRI.parse _namespace_name "DiscreteMathematics" |> NamespacedName

    /// <summary>
    /// Distributed computing is a field of computer science that studies distributed systems. A distributed system is a system whose components are located on different networked computers, which communicate and coordinate their actions by passing messages to one another.
    /// <see href="https://w3id.org/skgo/modsci#DistributedComputing"></see></summary>
    let DistributedComputing =
        Namespaced_IRI.parse _namespace_name "DistributedComputing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Dynamo"></see>
    /// </summary>
    let Dynamo = Namespaced_IRI.parse _namespace_name "Dynamo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Michael_Faraday"></see>
    /// </summary>
    let Michael_Faraday =
        Namespaced_IRI.parse _namespace_name "Michael_Faraday" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Dynamometer"></see>
    /// </summary>
    let Dynamometer =
        Namespaced_IRI.parse _namespace_name "Dynamometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#E3G"></see>
    /// </summary>
    let E3G = Namespaced_IRI.parse _namespace_name "E3G" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#EACSL"></see>
    /// </summary>
    let EACSL = Namespaced_IRI.parse _namespace_name "EACSL" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Earthquake"></see>
    /// </summary>
    let Earthquake = Namespaced_IRI.parse _namespace_name "Earthquake" |> NamespacedName

    /// <summary>
    /// A geological phenomenon is a phenomenon which is explained by or sheds light on the science of geology.
    /// <see href="https://w3id.org/skgo/modsci#GeologicalPhenomena"></see></summary>
    let GeologicalPhenomena =
        Namespaced_IRI.parse _namespace_name "GeologicalPhenomena" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#EcologicalApplications"></see>
    /// </summary>
    let EcologicalApplications =
        Namespaced_IRI.parse _namespace_name "EcologicalApplications" |> NamespacedName

    /// <summary>
    /// Environmental science is the science of the interactions between the physical, chemical, and biological components of the environment, but with particular attention to the effects of humans on the natural environment.
    /// <see href="https://w3id.org/skgo/modsci#EnvironmentalScience"></see></summary>
    let EnvironmentalScience =
        Namespaced_IRI.parse _namespace_name "EnvironmentalScience" |> NamespacedName

    /// <summary>
    /// Ecology is the branch of science that studies the distribution and interactions between living things and the physical environment.
    /// <see href="https://w3id.org/skgo/modsci#Ecology"></see></summary>
    let Ecology = Namespaced_IRI.parse _namespace_name "Ecology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Economic_Studies"></see>
    /// </summary>
    let Economic_Studies =
        Namespaced_IRI.parse _namespace_name "Economic_Studies" |> NamespacedName

    /// <summary>
    /// Economics is the social science that studies the production, distribution, and consumption of goods and services.
    /// <see href="https://w3id.org/skgo/modsci#Economics"></see></summary>
    let Economics = Namespaced_IRI.parse _namespace_name "Economics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#usesMethodsFrom"></see>
    /// </summary>
    let usesMethodsFrom =
        Namespaced_IRI.parse _namespace_name "usesMethodsFrom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Statistics_Studies"></see>
    /// </summary>
    let Statistics_Studies =
        Namespaced_IRI.parse _namespace_name "Statistics_Studies" |> NamespacedName

    /// <summary>
    /// Education is the teaching or learning of knowledge, especially to develop the reasoning, judgement and skill required in adult life and professional occupations.
    /// <see href="https://w3id.org/skgo/modsci#Education"></see></summary>
    let Education = Namespaced_IRI.parse _namespace_name "Education" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ElectroanalyticalChemistry"></see>
    /// </summary>
    let ElectroanalyticalChemistry =
        Namespaced_IRI.parse _namespace_name "ElectroanalyticalChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrochemistry"></see>
    /// </summary>
    let Electrochemistry =
        Namespaced_IRI.parse _namespace_name "Electrochemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrodynamics"></see>
    /// </summary>
    let Electrodynamics =
        Namespaced_IRI.parse _namespace_name "Electrodynamics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrometer"></see>
    /// </summary>
    let Electrometer =
        Namespaced_IRI.parse _namespace_name "Electrometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electroscope"></see>
    /// </summary>
    let Electroscope =
        Namespaced_IRI.parse _namespace_name "Electroscope" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrostatics"></see>
    /// </summary>
    let Electrostatics =
        Namespaced_IRI.parse _namespace_name "Electrostatics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Elementar"></see>
    /// </summary>
    let Elementar = Namespaced_IRI.parse _namespace_name "Elementar" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ellipsometer"></see>
    /// </summary>
    let Ellipsometer =
        Namespaced_IRI.parse _namespace_name "Ellipsometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Engineering_Studies"></see>
    /// </summary>
    let Engineering_Studies =
        Namespaced_IRI.parse _namespace_name "Engineering_Studies" |> NamespacedName

    /// <summary>
    /// Environmental chemistry is the scientific study of the physical, chemical and biochemical properties and processes of polluting substances in the environment.
    /// <see href="https://w3id.org/skgo/modsci#EnvironmentalChemistry"></see></summary>
    let EnvironmentalChemistry =
        Namespaced_IRI.parse _namespace_name "EnvironmentalChemistry" |> NamespacedName

    /// <summary>
    /// Epidemiology is the study and analysis of the distribution (who, when, and where), patterns and determinants of health and disease conditions in defined populations.
    /// <see href="https://w3id.org/skgo/modsci#Epidemiology"></see></summary>
    let Epidemiology =
        Namespaced_IRI.parse _namespace_name "Epidemiology" |> NamespacedName

    /// <summary>
    /// Human factors and ergonomics is the application of psychological and physiological principles to the (engineering and) design of products, processes, and systems.
    /// <see href="https://w3id.org/skgo/modsci#Ergonomics"></see></summary>
    let Ergonomics = Namespaced_IRI.parse _namespace_name "Ergonomics" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Erosion"></see>
    /// </summary>
    let Erosion = Namespaced_IRI.parse _namespace_name "Erosion" |> NamespacedName

    /// <summary>
    /// Ethnic studies, in the United States, is the interdisciplinary study of difference—chiefly race, ethnicity, and nation, but also sexuality, gender, and other such markings—and power, as expressed by the state, by civil society, and by individuals.
    /// <see href="https://w3id.org/skgo/modsci#EthnicStudies"></see></summary>
    let EthnicStudies =
        Namespaced_IRI.parse _namespace_name "EthnicStudies" |> NamespacedName

    /// <summary>
    /// Ethnobiology is the scientific study of the way living things are treated or used by different human cultures.
    /// <see href="https://w3id.org/skgo/modsci#Ethnobiology"></see></summary>
    let Ethnobiology =
        Namespaced_IRI.parse _namespace_name "Ethnobiology" |> NamespacedName

    /// <summary>
    /// Ethnology is the science that analyzes human cultures and compares them.
    /// <see href="https://w3id.org/skgo/modsci#Ethnology"></see></summary>
    let Ethnology = Namespaced_IRI.parse _namespace_name "Ethnology" |> NamespacedName
    /// <summary>
    /// Ethology is the scientific and objective study of animal behaviour, usually with a focus on behaviour under natural conditions, and viewing behaviour as an evolutionarily adaptive trait.
    /// <see href="https://w3id.org/skgo/modsci#Ethology"></see></summary>
    let Ethology = Namespaced_IRI.parse _namespace_name "Ethology" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Eudiometer"></see>
    /// </summary>
    let Eudiometer = Namespaced_IRI.parse _namespace_name "Eudiometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isStudentOf"></see>
    /// </summary>
    let isStudentOf =
        Namespaced_IRI.parse _namespace_name "isStudentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Galileo"></see>
    /// </summary>
    let Galileo = Namespaced_IRI.parse _namespace_name "Galileo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#undertakesResearch"></see>
    /// </summary>
    let undertakesResearch =
        Namespaced_IRI.parse _namespace_name "undertakesResearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Mathematical_Studies"></see>
    /// </summary>
    let Mathematical_Studies =
        Namespaced_IRI.parse _namespace_name "Mathematical_Studies" |> NamespacedName

    /// <summary>
    /// Evolutionary biology is a sub-field of biology concerned with the study of the evolutionary processes that produced the diversity of life on Earth.
    /// <see href="https://w3id.org/skgo/modsci#EvolutionaryBiology"></see></summary>
    let EvolutionaryBiology =
        Namespaced_IRI.parse _namespace_name "EvolutionaryBiology" |> NamespacedName

    /// <summary>
    /// In computer science, evolutionary computation is a family of algorithms for global optimization inspired by biological evolution, and the subfield of artificial intelligence and soft computing studying these algorithms.
    /// <see href="https://w3id.org/skgo/modsci#EvolutionaryComputation"></see></summary>
    let EvolutionaryComputation =
        Namespaced_IRI.parse _namespace_name "EvolutionaryComputation" |> NamespacedName

    /// <summary>
    /// Soft computing, as opposed to traditional computing, deals with approximate models and gives solutions to complex real-life problems. Unlike hard computing, soft computing is tolerant of imprecision, uncertainty, partial truth, and approximations.
    /// <see href="https://w3id.org/skgo/modsci#SoftComputing"></see></summary>
    let SoftComputing =
        Namespaced_IRI.parse _namespace_name "SoftComputing" |> NamespacedName

    /// <summary>
    /// Evolutionary psychology is a theoretical approach in the social and natural sciences that examines psychological structure from a modern evolutionary perspective.
    /// <see href="https://w3id.org/skgo/modsci#EvolutionaryPsychology"></see></summary>
    let EvolutionaryPsychology =
        Namespaced_IRI.parse _namespace_name "EvolutionaryPsychology" |> NamespacedName

    /// <summary>
    /// Experimental physics is the category of disciplines and sub-disciplines in the field of physics that are concerned with the observation of physical phenomena and experiments.
    /// <see href="https://w3id.org/skgo/modsci#ExperimentalPhysics"></see></summary>
    let ExperimentalPhysics =
        Namespaced_IRI.parse _namespace_name "ExperimentalPhysics" |> NamespacedName

    /// <summary>
    /// It is the study of all astronomical objects which are not covered by galactic astronomy.
    /// <see href="https://w3id.org/skgo/modsci#ExtragalacticAstronomy"></see></summary>
    let ExtragalacticAstronomy =
        Namespaced_IRI.parse _namespace_name "ExtragalacticAstronomy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ExtraterrestrialGeology"></see>
    /// </summary>
    let ExtraterrestrialGeology =
        Namespaced_IRI.parse _namespace_name "ExtraterrestrialGeology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FinancialMathematics"></see>
    /// </summary>
    let FinancialMathematics =
        Namespaced_IRI.parse _namespace_name "FinancialMathematics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Fire"></see>
    /// </summary>
    let Fire = Namespaced_IRI.parse _namespace_name "Fire" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FisheriesSciences"></see>
    /// </summary>
    let FisheriesSciences =
        Namespaced_IRI.parse _namespace_name "FisheriesSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FlowAnalysis"></see>
    /// </summary>
    let FlowAnalysis =
        Namespaced_IRI.parse _namespace_name "FlowAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FluidPhysics"></see>
    /// </summary>
    let FluidPhysics =
        Namespaced_IRI.parse _namespace_name "FluidPhysics" |> NamespacedName

    /// <summary>
    /// Food chemistry is the study of chemical processes and interactions of all biological and non-biological components of foods.
    /// <see href="https://w3id.org/skgo/modsci#FoodChemistry"></see></summary>
    let FoodChemistry =
        Namespaced_IRI.parse _namespace_name "FoodChemistry" |> NamespacedName

    /// <summary>
    /// Forensic science, also known as criminalistics, is the application of science to criminal and civil laws, mainly—on the criminal side—during criminal investigation, as governed by the legal standards of admissible evidence and criminal procedure.
    /// <see href="https://w3id.org/skgo/modsci#Forensics"></see></summary>
    let Forensics = Namespaced_IRI.parse _namespace_name "Forensics" |> NamespacedName
    /// <summary>
    /// Forestry is the art, science, and practice of studying and managing forests and related natural resources.
    /// <see href="https://w3id.org/skgo/modsci#Forestry"></see></summary>
    let Forestry = Namespaced_IRI.parse _namespace_name "Forestry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ForestrySciences"></see>
    /// </summary>
    let ForestrySciences =
        Namespaced_IRI.parse _namespace_name "ForestrySciences" |> NamespacedName

    /// <summary>
    /// Formal sciences are a branch of science studying formal language disciplines concerned with formal systems, such as logic, mathematics, statistics, theoretical computer science, artificial intelligence, information theory, game theory, systems theory, decision theory, and theoretical linguistics.
    /// <see href="https://w3id.org/skgo/modsci#FormalScience"></see></summary>
    let FormalScience =
        Namespaced_IRI.parse _namespace_name "FormalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Fraunhofer"></see>
    /// </summary>
    let Fraunhofer = Namespaced_IRI.parse _namespace_name "Fraunhofer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FreeRadicalChemistry"></see>
    /// </summary>
    let FreeRadicalChemistry =
        Namespaced_IRI.parse _namespace_name "FreeRadicalChemistry" |> NamespacedName

    /// <summary>
    /// Organic chemistry is the study of organic, or carbon based, molecules.
    /// <see href="https://w3id.org/skgo/modsci#OrganicChemistry"></see></summary>
    let OrganicChemistry =
        Namespaced_IRI.parse _namespace_name "OrganicChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Freezing"></see>
    /// </summary>
    let Freezing = Namespaced_IRI.parse _namespace_name "Freezing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FunctionalAnalysis"></see>
    /// </summary>
    let FunctionalAnalysis =
        Namespaced_IRI.parse _namespace_name "FunctionalAnalysis" |> NamespacedName

    /// <summary>
    /// The study of everything outside our galaxy, including all other galaxies.
    /// <see href="https://w3id.org/skgo/modsci#GalacticAstronomy"></see></summary>
    let GalacticAstronomy =
        Namespaced_IRI.parse _namespace_name "GalacticAstronomy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Galvanometer"></see>
    /// </summary>
    let Galvanometer =
        Namespaced_IRI.parse _namespace_name "Galvanometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Johann_Schweigger"></see>
    /// </summary>
    let Johann_Schweigger =
        Namespaced_IRI.parse _namespace_name "Johann_Schweigger" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Genetic_algorithms"></see>
    /// </summary>
    let Genetic_algorithms =
        Namespaced_IRI.parse _namespace_name "Genetic_algorithms" |> NamespacedName

    /// <summary>
    /// Genetics is the study of genes, heredity, and the variation of organisms, as well as the medical practice of diagnosing, treating, and counseling patients with genetic disorders.
    /// <see href="https://w3id.org/skgo/modsci#Genetics"></see></summary>
    let Genetics = Namespaced_IRI.parse _namespace_name "Genetics" |> NamespacedName

    /// <summary>
    /// Geochemistry is the science that uses the tools and principles of chemistry to explain the mechanisms behind major geological systems such as the Earth's crust and its oceans.
    /// <see href="https://w3id.org/skgo/modsci#Geochemistry"></see></summary>
    let Geochemistry =
        Namespaced_IRI.parse _namespace_name "Geochemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geochronology"></see>
    /// </summary>
    let Geochronology =
        Namespaced_IRI.parse _namespace_name "Geochronology" |> NamespacedName

    /// <summary>
    /// Geodesy is the Earth science of accurately measuring and understanding Earth's geometric shape, orientation in space and gravitational field.
    /// <see href="https://w3id.org/skgo/modsci#Geodesy"></see></summary>
    let Geodesy = Namespaced_IRI.parse _namespace_name "Geodesy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geodynamics"></see>
    /// </summary>
    let Geodynamics =
        Namespaced_IRI.parse _namespace_name "Geodynamics" |> NamespacedName

    /// <summary>
    /// Geophysics the physics of the Earth and its environment in space, and study of earth sciences using quantitative physics methods.
    /// <see href="https://w3id.org/skgo/modsci#Geophysics"></see></summary>
    let Geophysics = Namespaced_IRI.parse _namespace_name "Geophysics" |> NamespacedName
    /// <summary>
    /// Geography is a field of science devoted to the study of the lands, features, inhabitants, and phenomena of the Earth and planets.
    /// <see href="https://w3id.org/skgo/modsci#Geography"></see></summary>
    let Geography = Namespaced_IRI.parse _namespace_name "Geography" |> NamespacedName

    /// <summary>
    /// The Geological Sciences examine the physical and chemical processes within Earth and on its surface, including the study of natural resources and risks to habitable areas.
    /// <see href="https://w3id.org/skgo/modsci#GeologicalSciences"></see></summary>
    let GeologicalSciences =
        Namespaced_IRI.parse _namespace_name "GeologicalSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geological_Studies"></see>
    /// </summary>
    let Geological_Studies =
        Namespaced_IRI.parse _namespace_name "Geological_Studies" |> NamespacedName

    /// <summary>
    /// Geomorphology is the science of surface features and landforms including the forces and processes that create them.
    /// <see href="https://w3id.org/skgo/modsci#Geomorphology"></see></summary>
    let Geomorphology =
        Namespaced_IRI.parse _namespace_name "Geomorphology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#GeophysicalFluidDynamics"></see>
    /// </summary>
    let GeophysicalFluidDynamics =
        Namespaced_IRI.parse _namespace_name "GeophysicalFluidDynamics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geothermics"></see>
    /// </summary>
    let Geothermics =
        Namespaced_IRI.parse _namespace_name "Geothermics" |> NamespacedName

    /// <summary>
    /// Gerontology is the study of the social, cultural, psychological, cognitive, and biological aspects of ageing.
    /// <see href="https://w3id.org/skgo/modsci#Gerontology"></see></summary>
    let Gerontology =
        Namespaced_IRI.parse _namespace_name "Gerontology" |> NamespacedName

    /// <summary>
    /// Glaciology is the scientific study of glaciers, or more generally ice and natural phenomena that involve ice.
    /// <see href="https://w3id.org/skgo/modsci#Glaciology"></see></summary>
    let Glaciology = Namespaced_IRI.parse _namespace_name "Glaciology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#GlobalInformationSystems"></see>
    /// </summary>
    let GlobalInformationSystems =
        Namespaced_IRI.parse _namespace_name "GlobalInformationSystems" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Gravimetrics"></see>
    /// </summary>
    let Gravimetrics =
        Namespaced_IRI.parse _namespace_name "Gravimetrics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Gravitometer"></see>
    /// </summary>
    let Gravitometer =
        Namespaced_IRI.parse _namespace_name "Gravitometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Gravity"></see>
    /// </summary>
    let Gravity = Namespaced_IRI.parse _namespace_name "Gravity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Isaac_Newton"></see>
    /// </summary>
    let Isaac_Newton =
        Namespaced_IRI.parse _namespace_name "Isaac_Newton" |> NamespacedName

    /// <summary>
    /// Green chemistry is the use of chemistry for pollutant source reduction; the definition encompasses therefore all aspects of chemical processes that reduce impact on human health and on the environment.
    /// <see href="https://w3id.org/skgo/modsci#GreenChemistry"></see></summary>
    let GreenChemistry =
        Namespaced_IRI.parse _namespace_name "GreenChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Growth"></see>
    /// </summary>
    let Growth = Namespaced_IRI.parse _namespace_name "Growth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Guglielmo_Marconi"></see>
    /// </summary>
    let Guglielmo_Marconi =
        Namespaced_IRI.parse _namespace_name "Guglielmo_Marconi" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Haze"></see>
    /// </summary>
    let Haze = Namespaced_IRI.parse _namespace_name "Haze" |> NamespacedName
    /// <summary>
    /// Health is a state of physical, mental and social well-being in which disease and infirmity are absent.
    /// <see href="https://w3id.org/skgo/modsci#Health"></see></summary>
    let Health = Namespaced_IRI.parse _namespace_name "Health" |> NamespacedName
    /// <summary>
    /// Healthcare is the maintenance or improvement of health via the prevention, diagnosis, and treatment of disease, illness, injury, and other physical and mental impairments in people.
    /// <see href="https://w3id.org/skgo/modsci#Healthcare"></see></summary>
    let Healthcare = Namespaced_IRI.parse _namespace_name "Healthcare" |> NamespacedName
    /// <summary>
    /// The history of science is the study of the development of science and scientific knowledge, including both the natural and social sciences (the history of the arts and humanities is termed history of scholarship).
    /// <see href="https://w3id.org/skgo/modsci#History"></see></summary>
    let History = Namespaced_IRI.parse _namespace_name "History" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#HomologicalAlgebra"></see>
    /// </summary>
    let HomologicalAlgebra =
        Namespaced_IRI.parse _namespace_name "HomologicalAlgebra" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Horiba"></see>
    /// </summary>
    let Horiba = Namespaced_IRI.parse _namespace_name "Horiba" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#HorticulturalProduction"></see>
    /// </summary>
    let HorticulturalProduction =
        Namespaced_IRI.parse _namespace_name "HorticulturalProduction" |> NamespacedName

    /// <summary>
    /// Human–computer interaction (HCI) researches the design and use of computer technology, focused on the interfaces between people (users) and computers. Researchers in the field of HCI observe the ways in which humans interact with computers and design technologies that let humans interact with computers in novel ways.
    /// <see href="https://w3id.org/skgo/modsci#HumanComputerInteraction"></see></summary>
    let HumanComputerInteraction =
        Namespaced_IRI.parse _namespace_name "HumanComputerInteraction" |> NamespacedName

    /// <summary>
    /// Software engineering is the application of engineering to the development of software in a systematic method.
    /// <see href="https://w3id.org/skgo/modsci#SoftwareEngineering"></see></summary>
    let SoftwareEngineering =
        Namespaced_IRI.parse _namespace_name "SoftwareEngineering" |> NamespacedName

    /// <summary>
    /// Human science is a term applied to the investigation of human life and activities by a rational, systematic and verifiable methodology that acknowledges the validity of both data derived by impartial observation of sensory experience (objective phenomena) and data derived by means of impartial observation of psychological experience (subjective phenomena).
    /// <see href="https://w3id.org/skgo/modsci#HumanSciences"></see></summary>
    let HumanSciences =
        Namespaced_IRI.parse _namespace_name "HumanSciences" |> NamespacedName

    /// <summary>
    /// Hydrology is the scientific study of the movement, distribution, and quality of water on Earth and other planets, including the water cycle, water resources and environmental watershed sustainability.
    /// <see href="https://w3id.org/skgo/modsci#Hydrology"></see></summary>
    let Hydrology = Namespaced_IRI.parse _namespace_name "Hydrology" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Hydrometer"></see>
    /// </summary>
    let Hydrometer = Namespaced_IRI.parse _namespace_name "Hydrometer" |> NamespacedName
    /// <summary>
    /// Immunology is the study of the immune system and its reaction to pathogens, as well as its malfunctions (autoimmune diseases, allergies, rejection of organ transplants, immune deficiency).
    /// <see href="https://w3id.org/skgo/modsci#Immunology"></see></summary>
    let Immunology = Namespaced_IRI.parse _namespace_name "Immunology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Inclinometer"></see>
    /// </summary>
    let Inclinometer =
        Namespaced_IRI.parse _namespace_name "Inclinometer" |> NamespacedName

    /// <summary>
    /// An industrial process alters materials or substances.
    /// <see href="https://w3id.org/skgo/modsci#IndustrialScience"></see></summary>
    let IndustrialScience =
        Namespaced_IRI.parse _namespace_name "IndustrialScience" |> NamespacedName

    /// <summary>
    /// An industry is a sector that produces goods or related services within an economy.
    /// <see href="https://w3id.org/skgo/modsci#Industry"></see></summary>
    let Industry = Namespaced_IRI.parse _namespace_name "Industry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationRetrieval"></see>
    /// </summary>
    let InformationRetrieval =
        Namespaced_IRI.parse _namespace_name "InformationRetrieval" |> NamespacedName

    /// <summary>
    /// Information science is a field primarily concerned with the analysis, collection, classification, manipulation, storage, retrieval, movement, dissemination, and protection of information.
    /// <see href="https://w3id.org/skgo/modsci#InformationScience"></see></summary>
    let InformationScience =
        Namespaced_IRI.parse _namespace_name "InformationScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationSystemsManagement"></see>
    /// </summary>
    let InformationSystemsManagement =
        Namespaced_IRI.parse _namespace_name "InformationSystemsManagement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationSystemsTheory"></see>
    /// </summary>
    let InformationSystemsTheory =
        Namespaced_IRI.parse _namespace_name "InformationSystemsTheory" |> NamespacedName

    /// <summary>
    /// Information visualization or information visualisation is the study of (interactive) visual representations of abstract data to reinforce human cognition.
    /// <see href="https://w3id.org/skgo/modsci#InformationVisualization"></see></summary>
    let InformationVisualization =
        Namespaced_IRI.parse _namespace_name "InformationVisualization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Informetrics"></see>
    /// </summary>
    let Informetrics =
        Namespaced_IRI.parse _namespace_name "Informetrics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InorganicGreenChemistry"></see>
    /// </summary>
    let InorganicGreenChemistry =
        Namespaced_IRI.parse _namespace_name "InorganicGreenChemistry" |> NamespacedName

    /// <summary>
    /// A tool or implement, especially one for precision work.
    /// <see href="https://w3id.org/skgo/modsci#Instrument"></see></summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#IntegralEquations"></see>
    /// </summary>
    let IntegralEquations =
        Namespaced_IRI.parse _namespace_name "IntegralEquations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Interferometer"></see>
    /// </summary>
    let Interferometer =
        Namespaced_IRI.parse _namespace_name "Interferometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InterorganisationalInformationSystems"></see>
    /// </summary>
    let InterorganisationalInformationSystems =
        Namespaced_IRI.parse _namespace_name "InterorganisationalInformationSystems" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#KNN_Algorithm"></see>
    /// </summary>
    let KNN_Algorithm =
        Namespaced_IRI.parse _namespace_name "KNN_Algorithm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#KnowledgeSystems"></see>
    /// </summary>
    let KnowledgeSystems =
        Namespaced_IRI.parse _namespace_name "KnowledgeSystems" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#LECO_Corporation"></see>
    /// </summary>
    let LECO_Corporation =
        Namespaced_IRI.parse _namespace_name "LECO_Corporation" |> NamespacedName

    /// <summary>
    /// An instrument needed for operations in various laboratories, synthesis and analysis.
    /// <see href="https://w3id.org/skgo/modsci#LaboratoryInstrument"></see></summary>
    let LaboratoryInstrument =
        Namespaced_IRI.parse _namespace_name "LaboratoryInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Lasers"></see>
    /// </summary>
    let Lasers = Namespaced_IRI.parse _namespace_name "Lasers" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OpticalPhysics"></see>
    /// </summary>
    let OpticalPhysics =
        Namespaced_IRI.parse _namespace_name "OpticalPhysics" |> NamespacedName

    /// <summary>
    /// Library science is an interdisciplinary or multidisciplinary field that applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries; the collection, organization, preservation, and dissemination of information resources; and the political economy of information.
    /// <see href="https://w3id.org/skgo/modsci#LibraryScience"></see></summary>
    let LibraryScience =
        Namespaced_IRI.parse _namespace_name "LibraryScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Light_Bulb"></see>
    /// </summary>
    let Light_Bulb = Namespaced_IRI.parse _namespace_name "Light_Bulb" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Thomas_Edison"></see>
    /// </summary>
    let Thomas_Edison =
        Namespaced_IRI.parse _namespace_name "Thomas_Edison" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Light_magnification"></see>
    /// </summary>
    let Light_magnification =
        Namespaced_IRI.parse _namespace_name "Light_magnification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Light_pillar"></see>
    /// </summary>
    let Light_pillar =
        Namespaced_IRI.parse _namespace_name "Light_pillar" |> NamespacedName

    /// <summary>
    /// Limnology is a discipline that concerns the study of fresh waters, specifically natural and constructed lakes, ponds, streams, and rivers,
    /// <see href="https://w3id.org/skgo/modsci#Limnology"></see></summary>
    let Limnology = Namespaced_IRI.parse _namespace_name "Limnology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Linear_Regression"></see>
    /// </summary>
    let Linear_Regression =
        Namespaced_IRI.parse _namespace_name "Linear_Regression" |> NamespacedName

    /// <summary>
    /// Statistics is the discipline that concerns the collection, organization, displaying, analysis, interpretation and presentation of data.
    /// <see href="https://w3id.org/skgo/modsci#Statistics"></see></summary>
    let Statistics = Namespaced_IRI.parse _namespace_name "Statistics" |> NamespacedName

    /// <summary>
    /// Linguistics is the scientific study of language.
    /// <see href="https://w3id.org/skgo/modsci#Linguistics"></see></summary>
    let Linguistics =
        Namespaced_IRI.parse _namespace_name "Linguistics" |> NamespacedName

    /// <summary>
    /// Logic is the study of reasoning, or the study of the principles and criteria of valid inference and demonstration.
    /// <see href="https://w3id.org/skgo/modsci#Logic"></see></summary>
    let Logic = Namespaced_IRI.parse _namespace_name "Logic" |> NamespacedName

    /// <summary>
    /// Machine learning (ML) is the scientific study of algorithms and statistical models that computer systems use to perform a specific task without using explicit instructions, relying on patterns and inference instead.
    /// <see href="https://w3id.org/skgo/modsci#MachineLearning"></see></summary>
    let MachineLearning =
        Namespaced_IRI.parse _namespace_name "MachineLearning" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Magnetism"></see>
    /// </summary>
    let Magnetism = Namespaced_IRI.parse _namespace_name "Magnetism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Magnetograph"></see>
    /// </summary>
    let Magnetograph =
        Namespaced_IRI.parse _namespace_name "Magnetograph" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Magnetometer"></see>
    /// </summary>
    let Magnetometer =
        Namespaced_IRI.parse _namespace_name "Magnetometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MainGroupMetalChemistry"></see>
    /// </summary>
    let MainGroupMetalChemistry =
        Namespaced_IRI.parse _namespace_name "MainGroupMetalChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MalvernInstruments"></see>
    /// </summary>
    let MalvernInstruments =
        Namespaced_IRI.parse _namespace_name "MalvernInstruments" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Manometer"></see>
    /// </summary>
    let Manometer = Namespaced_IRI.parse _namespace_name "Manometer" |> NamespacedName

    /// <summary>
    /// Marine biology is the scientific study of organisms that live in the ocean
    /// <see href="https://w3id.org/skgo/modsci#MarineBiology"></see></summary>
    let MarineBiology =
        Namespaced_IRI.parse _namespace_name "MarineBiology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MarkesInternational"></see>
    /// </summary>
    let MarkesInternational =
        Namespaced_IRI.parse _namespace_name "MarkesInternational" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MarkupLanguages"></see>
    /// </summary>
    let MarkupLanguages =
        Namespaced_IRI.parse _namespace_name "MarkupLanguages" |> NamespacedName

    /// <summary>
    /// Mathematical and theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems
    /// <see href="https://w3id.org/skgo/modsci#MathematicalAndTheoreticalBiology"></see></summary>
    let MathematicalAndTheoreticalBiology =
        Namespaced_IRI.parse _namespace_name "MathematicalAndTheoreticalBiology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MathematicalLogic"></see>
    /// </summary>
    let MathematicalLogic =
        Namespaced_IRI.parse _namespace_name "MathematicalLogic" |> NamespacedName

    /// <summary>
    /// Mathematical physics refers to the development of mathematical methods for application to problems in physics.
    /// <see href="https://w3id.org/skgo/modsci#MathematicalPhysics"></see></summary>
    let MathematicalPhysics =
        Namespaced_IRI.parse _namespace_name "MathematicalPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#McPhersonInc"></see>
    /// </summary>
    let McPhersonInc =
        Namespaced_IRI.parse _namespace_name "McPhersonInc" |> NamespacedName

    /// <summary>
    /// Measurement is the assignment of a number to a characteristic of an object or event, which can be compared with other objects or events.
    /// <see href="https://w3id.org/skgo/modsci#Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    /// Mechanics is the branch of science concerned with the behavior of physical bodies when subjected to forces or displacements, and the subsequent effects of the bodies on their environment.
    /// <see href="https://w3id.org/skgo/modsci#Mechanics"></see></summary>
    let Mechanics = Namespaced_IRI.parse _namespace_name "Mechanics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MechanismsOfReactions"></see>
    /// </summary>
    let MechanismsOfReactions =
        Namespaced_IRI.parse _namespace_name "MechanismsOfReactions" |> NamespacedName

    /// <summary>
    /// Medicinal chemistry and pharmaceutical chemistry are disciplines at the intersection of chemistry, especially synthetic organic chemistry, and pharmacology and various other biological specialties, where they are involved with design, chemical synthesis and development for market of pharmaceutical agents, or bio-active molecules (drugs).
    /// <see href="https://w3id.org/skgo/modsci#MedicinalChemistry"></see></summary>
    let MedicinalChemistry =
        Namespaced_IRI.parse _namespace_name "MedicinalChemistry" |> NamespacedName

    /// <summary>
    /// Medicine is a branch of health science concerned with maintaining human health and restoring it by treating disease and injury; it is both an area of knowledge, a science of body systems and diseases and their treatment, and the applied practice of that knowledge.
    /// <see href="https://w3id.org/skgo/modsci#Medicine"></see></summary>
    let Medicine = Namespaced_IRI.parse _namespace_name "Medicine" |> NamespacedName
    /// <summary>
    /// Metabolism is the set of life-sustaining chemical reactions in organisms.
    /// <see href="https://w3id.org/skgo/modsci#Metabolism"></see></summary>
    let Metabolism = Namespaced_IRI.parse _namespace_name "Metabolism" |> NamespacedName
    /// <summary>
    /// Metallurgy is a domain of materials science and engineering that studies the physical and chemical behavior of metallic elements, their inter-metallic compounds, and their mixtures, which are called alloys.
    /// <see href="https://w3id.org/skgo/modsci#Metallurgy"></see></summary>
    let Metallurgy = Namespaced_IRI.parse _namespace_name "Metallurgy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MetamorphicPetrology"></see>
    /// </summary>
    let MetamorphicPetrology =
        Namespaced_IRI.parse _namespace_name "MetamorphicPetrology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MeteorologicalPhenomena"></see>
    /// </summary>
    let MeteorologicalPhenomena =
        Namespaced_IRI.parse _namespace_name "MeteorologicalPhenomena" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MetrologicalChemistry"></see>
    /// </summary>
    let MetrologicalChemistry =
        Namespaced_IRI.parse _namespace_name "MetrologicalChemistry" |> NamespacedName

    /// <summary>
    /// Metrology is the science of measurement.
    /// <see href="https://w3id.org/skgo/modsci#Metrology"></see></summary>
    let Metrology = Namespaced_IRI.parse _namespace_name "Metrology" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Micrometer"></see>
    /// </summary>
    let Micrometer = Namespaced_IRI.parse _namespace_name "Micrometer" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Microscope"></see>
    /// </summary>
    let Microscope = Namespaced_IRI.parse _namespace_name "Microscope" |> NamespacedName

    /// <summary>
    /// Military science is the study of military processes, dentsciitutions, and behavior, along with the study of warfare, and the theory and application of organized coercive force.
    /// <see href="https://w3id.org/skgo/modsci#MilitaryScience"></see></summary>
    let MilitaryScience =
        Namespaced_IRI.parse _namespace_name "MilitaryScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Mineralogy"></see>
    /// </summary>
    let Mineralogy = Namespaced_IRI.parse _namespace_name "Mineralogy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MobileTechnologies"></see>
    /// </summary>
    let MobileTechnologies =
        Namespaced_IRI.parse _namespace_name "MobileTechnologies" |> NamespacedName

    /// <summary>
    /// Molecular biology is the study of biology at a molecular level.
    /// <see href="https://w3id.org/skgo/modsci#MolecularBiology"></see></summary>
    let MolecularBiology =
        Namespaced_IRI.parse _namespace_name "MolecularBiology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Movie_camera"></see>
    /// </summary>
    let Movie_camera =
        Namespaced_IRI.parse _namespace_name "Movie_camera" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MultimediaProgramming"></see>
    /// </summary>
    let MultimediaProgramming =
        Namespaced_IRI.parse _namespace_name "MultimediaProgramming" |> NamespacedName

    /// <summary>
    /// Museology or museum studies is the study of museums. It explores the history of museums and their role in society, as well as the activities they engage in, including curating, preservation, public programming, and education.
    /// <see href="https://w3id.org/skgo/modsci#Museology"></see></summary>
    let Museology = Namespaced_IRI.parse _namespace_name "Museology" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NASA"></see>
    /// </summary>
    let NASA = Namespaced_IRI.parse _namespace_name "NASA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Nanochemistry"></see>
    /// </summary>
    let Nanochemistry =
        Namespaced_IRI.parse _namespace_name "Nanochemistry" |> NamespacedName

    /// <summary>
    /// Natural language processing (NLP) is a subfield of linguistics, computer science, information engineering, and artificial intelligence concerned with the interactions between computers and human (natural) languages, in particular how to program computers to process and analyze large amounts of natural language data.
    /// <see href="https://w3id.org/skgo/modsci#NaturalLanguageProcessing"></see></summary>
    let NaturalLanguageProcessing =
        Namespaced_IRI.parse _namespace_name "NaturalLanguageProcessing" |> NamespacedName

    /// <summary>
    /// Social phenomena are those that occur or exist through the actions of groups of humans.
    /// <see href="https://w3id.org/skgo/modsci#SocialPhenomenon"></see></summary>
    let SocialPhenomenon =
        Namespaced_IRI.parse _namespace_name "SocialPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NaturalProductsChemistry"></see>
    /// </summary>
    let NaturalProductsChemistry =
        Namespaced_IRI.parse _namespace_name "NaturalProductsChemistry" |> NamespacedName

    /// <summary>
    /// A computer network is a digital telecommunications network which allows nodes to share resources.
    /// <see href="https://w3id.org/skgo/modsci#Networking"></see></summary>
    let Networking = Namespaced_IRI.parse _namespace_name "Networking" |> NamespacedName

    /// <summary>
    /// Neural engineering is a discipline within biomedical engineering that uses engineering techniques to understand, repair, replace, or enhance neural systems.
    /// <see href="https://w3id.org/skgo/modsci#NeuralEngineering"></see></summary>
    let NeuralEngineering =
        Namespaced_IRI.parse _namespace_name "NeuralEngineering" |> NamespacedName

    /// <summary>
    /// Neuroscience is a field of study which deals with the structure, development, genetics, biochemistry, physiology, pharmacology and pathology of the nervous system.
    /// <see href="https://w3id.org/skgo/modsci#Neuroscience"></see></summary>
    let Neuroscience =
        Namespaced_IRI.parse _namespace_name "Neuroscience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Non-equilibriumProcesses"></see>
    /// </summary>
    let ``Non-equilibriumProcesses`` =
        Namespaced_IRI.parse _namespace_name "Non-equilibriumProcesses" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Non-metalChemistry"></see>
    /// </summary>
    let ``Non-metalChemistry`` =
        Namespaced_IRI.parse _namespace_name "Non-metalChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NonlinearOptics"></see>
    /// </summary>
    let NonlinearOptics =
        Namespaced_IRI.parse _namespace_name "NonlinearOptics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NovacamTechnologies"></see>
    /// </summary>
    let NovacamTechnologies =
        Namespaced_IRI.parse _namespace_name "NovacamTechnologies" |> NamespacedName

    /// <summary>
    /// Nuclear chemistry is the subfield of chemistry dealing with radioactivity, nuclear processes, and transformations in the nuclei of atoms, such as nuclear transmutation and nuclear properties.
    /// <see href="https://w3id.org/skgo/modsci#NuclearChemistry"></see></summary>
    let NuclearChemistry =
        Namespaced_IRI.parse _namespace_name "NuclearChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NuclearPhysics"></see>
    /// </summary>
    let NuclearPhysics =
        Namespaced_IRI.parse _namespace_name "NuclearPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NumberTheory"></see>
    /// </summary>
    let NumberTheory =
        Namespaced_IRI.parse _namespace_name "NumberTheory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NumericalAnalysis"></see>
    /// </summary>
    let NumericalAnalysis =
        Namespaced_IRI.parse _namespace_name "NumericalAnalysis" |> NamespacedName

    /// <summary>
    /// Nursing is a profession within the health care sector focused on the care of individuals, families, and communities so they may attain, maintain, or recover optimal health and quality of life.
    /// <see href="https://w3id.org/skgo/modsci#Nursing"></see></summary>
    let Nursing = Namespaced_IRI.parse _namespace_name "Nursing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ocean_currents"></see>
    /// </summary>
    let Ocean_currents =
        Namespaced_IRI.parse _namespace_name "Ocean_currents" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ohmmeter"></see>
    /// </summary>
    let Ohmmeter = Namespaced_IRI.parse _namespace_name "Ohmmeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Olaus_Roemer"></see>
    /// </summary>
    let Olaus_Roemer =
        Namespaced_IRI.parse _namespace_name "Olaus_Roemer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OpenAI_Inc"></see>
    /// </summary>
    let OpenAI_Inc = Namespaced_IRI.parse _namespace_name "OpenAI_Inc" |> NamespacedName

    /// <summary>
    /// An operating system (OS) is system software that manages computer hardware, software resources, and provides common services for computer programs.
    /// <see href="https://w3id.org/skgo/modsci#OperatingSystems"></see></summary>
    let OperatingSystems =
        Namespaced_IRI.parse _namespace_name "OperatingSystems" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OperationsResearch"></see>
    /// </summary>
    let OperationsResearch =
        Namespaced_IRI.parse _namespace_name "OperationsResearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OpticalCommunications"></see>
    /// </summary>
    let OpticalCommunications =
        Namespaced_IRI.parse _namespace_name "OpticalCommunications" |> NamespacedName

    /// <summary>
    /// Optics is the branch of physics that studies the behaviour and properties of light, including its interactions with matter and the construction of instruments that use or detect it.
    /// <see href="https://w3id.org/skgo/modsci#Optics"></see></summary>
    let Optics = Namespaced_IRI.parse _namespace_name "Optics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Optimisation"></see>
    /// </summary>
    let Optimisation =
        Namespaced_IRI.parse _namespace_name "Optimisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Optoelectronics"></see>
    /// </summary>
    let Optoelectronics =
        Namespaced_IRI.parse _namespace_name "Optoelectronics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OrdinaryDifferentialEquations"></see>
    /// </summary>
    let OrdinaryDifferentialEquations =
        Namespaced_IRI.parse _namespace_name "OrdinaryDifferentialEquations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OreDepositPetrology"></see>
    /// </summary>
    let OreDepositPetrology =
        Namespaced_IRI.parse _namespace_name "OreDepositPetrology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OrganicChemicalSynthesis"></see>
    /// </summary>
    let OrganicChemicalSynthesis =
        Namespaced_IRI.parse _namespace_name "OrganicChemicalSynthesis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OrganicGreenChemistry"></see>
    /// </summary>
    let OrganicGreenChemistry =
        Namespaced_IRI.parse _namespace_name "OrganicGreenChemistry" |> NamespacedName

    /// <summary>
    /// Organometallic chemistry is the study of chemical compounds containing bonds between carbon and a metal.
    /// <see href="https://w3id.org/skgo/modsci#OrganometallicChemistry"></see></summary>
    let OrganometallicChemistry =
        Namespaced_IRI.parse _namespace_name "OrganometallicChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Oscilloscope"></see>
    /// </summary>
    let Oscilloscope =
        Namespaced_IRI.parse _namespace_name "Oscilloscope" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Overpopulation"></see>
    /// </summary>
    let Overpopulation =
        Namespaced_IRI.parse _namespace_name "Overpopulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OxfordInstruments"></see>
    /// </summary>
    let OxfordInstruments =
        Namespaced_IRI.parse _namespace_name "OxfordInstruments" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Palaeomagnetism"></see>
    /// </summary>
    let Palaeomagnetism =
        Namespaced_IRI.parse _namespace_name "Palaeomagnetism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Palaeontology"></see>
    /// </summary>
    let Palaeontology =
        Namespaced_IRI.parse _namespace_name "Palaeontology" |> NamespacedName

    /// <summary>
    /// Paleoclimatology is the study of climates for which systematic measurements were not taken.
    /// <see href="https://w3id.org/skgo/modsci#Paleoclimatology"></see></summary>
    let Paleoclimatology =
        Namespaced_IRI.parse _namespace_name "Paleoclimatology" |> NamespacedName

    /// <summary>
    /// Paleontology is the study of the developing history of life on earth, of ancient plants and animals based on the fossil record, evidence of their existence preserved in rocks.
    /// <see href="https://w3id.org/skgo/modsci#Paleontology"></see></summary>
    let Paleontology =
        Namespaced_IRI.parse _namespace_name "Paleontology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PallCorp"></see>
    /// </summary>
    let PallCorp = Namespaced_IRI.parse _namespace_name "PallCorp" |> NamespacedName
    /// <summary>
    /// Palynology is literally the "study of dust" or of "particles that are strewn".
    /// <see href="https://w3id.org/skgo/modsci#Palynology"></see></summary>
    let Palynology = Namespaced_IRI.parse _namespace_name "Palynology" |> NamespacedName

    /// <summary>
    /// Parallel computing is a type of computation in which many calculations or the execution of processes are carried out simultaneously.
    /// <see href="https://w3id.org/skgo/modsci#ParallelComputing"></see></summary>
    let ParallelComputing =
        Namespaced_IRI.parse _namespace_name "ParallelComputing" |> NamespacedName

    /// <summary>
    /// Parasitology is the study of parasites in host organisms, including humans (medical parasitology).
    /// <see href="https://w3id.org/skgo/modsci#Parasitology"></see></summary>
    let Parasitology =
        Namespaced_IRI.parse _namespace_name "Parasitology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PartialDifferentialEquations"></see>
    /// </summary>
    let PartialDifferentialEquations =
        Namespaced_IRI.parse _namespace_name "PartialDifferentialEquations" |> NamespacedName

    /// <summary>
    /// Particle physics is a branch of physics that studies the elementary constituents of matter and radiation, and the interactions between them.
    /// <see href="https://w3id.org/skgo/modsci#ParticlePhysics"></see></summary>
    let ParticlePhysics =
        Namespaced_IRI.parse _namespace_name "ParticlePhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PastureProduction"></see>
    /// </summary>
    let PastureProduction =
        Namespaced_IRI.parse _namespace_name "PastureProduction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PatternRecognition"></see>
    /// </summary>
    let PatternRecognition =
        Namespaced_IRI.parse _namespace_name "PatternRecognition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PetroleumGeology"></see>
    /// </summary>
    let PetroleumGeology =
        Namespaced_IRI.parse _namespace_name "PetroleumGeology" |> NamespacedName

    /// <summary>
    /// Pharmacology is the study of how chemical substances interact with living systems.
    /// <see href="https://w3id.org/skgo/modsci#Pharmacology"></see></summary>
    let Pharmacology =
        Namespaced_IRI.parse _namespace_name "Pharmacology" |> NamespacedName

    /// <summary>
    /// Pharmacy is the science and technique of preparing, dispensing, and reviewing drugs and providing additional clinical services.
    /// <see href="https://w3id.org/skgo/modsci#Pharmacy"></see></summary>
    let Pharmacy = Namespaced_IRI.parse _namespace_name "Pharmacy" |> NamespacedName
    /// <summary>
    /// Philosophy of science is a branch of philosophy concerned with the foundations, methods, and implications of science.
    /// <see href="https://w3id.org/skgo/modsci#Philosophy"></see></summary>
    let Philosophy = Namespaced_IRI.parse _namespace_name "Philosophy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Phonograph"></see>
    /// </summary>
    let Phonograph = Namespaced_IRI.parse _namespace_name "Phonograph" |> NamespacedName

    /// <summary>
    /// Photochemistry, a sub-discipline of chemistry, is the study of the interactions between atoms, small molecules, and light (or electromagnetic radiation).
    /// <see href="https://w3id.org/skgo/modsci#Photochemistry"></see></summary>
    let Photochemistry =
        Namespaced_IRI.parse _namespace_name "Photochemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Photonics"></see>
    /// </summary>
    let Photonics = Namespaced_IRI.parse _namespace_name "Photonics" |> NamespacedName
    /// <summary>
    /// Phylogenetics is the study of the evolutionary history and relationships among individuals or groups of organisms.
    /// <see href="https://w3id.org/skgo/modsci#Phylogeny"></see></summary>
    let Phylogeny = Namespaced_IRI.parse _namespace_name "Phylogeny" |> NamespacedName

    /// <summary>
    /// Physical geography is a subfield of geography, closely related to geology, that focuses on the spatial characteristics of natural processes, within the hydrosphere, biosphere, atmosphere and lithosphere.
    /// <see href="https://w3id.org/skgo/modsci#PhysicalGeography"></see></summary>
    let PhysicalGeography =
        Namespaced_IRI.parse _namespace_name "PhysicalGeography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PhysicalOceanography"></see>
    /// </summary>
    let PhysicalOceanography =
        Namespaced_IRI.parse _namespace_name "PhysicalOceanography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PhysicalOrganicChemistry"></see>
    /// </summary>
    let PhysicalOrganicChemistry =
        Namespaced_IRI.parse _namespace_name "PhysicalOrganicChemistry" |> NamespacedName

    /// <summary>
    /// Physiology is the branch of science that describes the mechanisms of cell, tissue and organ function in organisms.
    /// <see href="https://w3id.org/skgo/modsci#Physiology"></see></summary>
    let Physiology = Namespaced_IRI.parse _namespace_name "Physiology" |> NamespacedName

    /// <summary>
    /// Planetary science is a broad field of science that studies all planets.
    /// <see href="https://w3id.org/skgo/modsci#PlanetaryScience"></see></summary>
    let PlanetaryScience =
        Namespaced_IRI.parse _namespace_name "PlanetaryScience" |> NamespacedName

    /// <summary>
    /// Plasma physics is the study of ionized gases.
    /// <see href="https://w3id.org/skgo/modsci#PlasmaPhysics"></see></summary>
    let PlasmaPhysics =
        Namespaced_IRI.parse _namespace_name "PlasmaPhysics" |> NamespacedName

    /// <summary>
    /// Political economy is the study of production and trade and their relations with law, custom and government; and with the distribution of national income and wealth.
    /// <see href="https://w3id.org/skgo/modsci#PoliticalEconomy"></see></summary>
    let PoliticalEconomy =
        Namespaced_IRI.parse _namespace_name "PoliticalEconomy" |> NamespacedName

    /// <summary>
    /// Political science is a social science which deals with systems of governance, and the analysis of political activities, political thoughts, and political behavior.
    /// <see href="https://w3id.org/skgo/modsci#PoliticalScience"></see></summary>
    let PoliticalScience =
        Namespaced_IRI.parse _namespace_name "PoliticalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PolymerChar"></see>
    /// </summary>
    let PolymerChar =
        Namespaced_IRI.parse _namespace_name "PolymerChar" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PolymerisationMechanisms"></see>
    /// </summary>
    let PolymerisationMechanisms =
        Namespaced_IRI.parse _namespace_name "PolymerisationMechanisms" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Population_decrease"></see>
    /// </summary>
    let Population_decrease =
        Namespaced_IRI.parse _namespace_name "Population_decrease" |> NamespacedName

    /// <summary>
    /// A programming language is a formal language, which comprises a set of instructions that produce various kinds of output. Programming languages are used in computer programming to implement algorithms.
    /// <see href="https://w3id.org/skgo/modsci#ProgrammingLanguage"></see></summary>
    let ProgrammingLanguage =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguage" |> NamespacedName

    /// <summary>
    /// Programming language theory (PLT) is a branch of computer science that deals with the design, implementation, analysis, characterization, and classification of programming languages and their individual features.
    /// <see href="https://w3id.org/skgo/modsci#ProgrammingLanguageTheory"></see></summary>
    let ProgrammingLanguageTheory =
        Namespaced_IRI.parse _namespace_name "ProgrammingLanguageTheory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PsychiatricDrugs"></see>
    /// </summary>
    let PsychiatricDrugs =
        Namespaced_IRI.parse _namespace_name "PsychiatricDrugs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Psychological_Studies"></see>
    /// </summary>
    let Psychological_Studies =
        Namespaced_IRI.parse _namespace_name "Psychological_Studies" |> NamespacedName

    /// <summary>
    /// Psychology is a collection of academic, clinical and industrial disciplines concerned with the explanation and prediction of behavior, thinking, emotions, motivations, relationships, potentials and pathologies.
    /// <see href="https://w3id.org/skgo/modsci#Psychology"></see></summary>
    let Psychology = Namespaced_IRI.parse _namespace_name "Psychology" |> NamespacedName

    /// <summary>
    /// Quantum computing is the use of quantum-mechanical phenomena such as superposition and entanglement to perform computation. A quantum computer is used to perform such computation, which can be implemented theoretically or physically.
    /// <see href="https://w3id.org/skgo/modsci#QuantumComputing"></see></summary>
    let QuantumComputing =
        Namespaced_IRI.parse _namespace_name "QuantumComputing" |> NamespacedName

    /// <summary>
    /// Quantum mechanics (also called quantum physics or quantum theory) is a physical theory that is believed to be the formalism underlying the description of all physical systems.
    /// <see href="https://w3id.org/skgo/modsci#QuantumMechanics"></see></summary>
    let QuantumMechanics =
        Namespaced_IRI.parse _namespace_name "QuantumMechanics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#QuantumOptics"></see>
    /// </summary>
    let QuantumOptics =
        Namespaced_IRI.parse _namespace_name "QuantumOptics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#QuantumPhysics"></see>
    /// </summary>
    let QuantumPhysics =
        Namespaced_IRI.parse _namespace_name "QuantumPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Racism"></see>
    /// </summary>
    let Racism = Namespaced_IRI.parse _namespace_name "Racism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Radio_Signals"></see>
    /// </summary>
    let Radio_Signals =
        Namespaced_IRI.parse _namespace_name "Radio_Signals" |> NamespacedName

    /// <summary>
    /// Radiobiology is a field of clinical and basic medical sciences that involves the study of the action of ionizing radiation on living things, especially health effects of radiation.
    /// <see href="https://w3id.org/skgo/modsci#Radiobiology"></see></summary>
    let Radiobiology =
        Namespaced_IRI.parse _namespace_name "Radiobiology" |> NamespacedName

    /// <summary>
    /// Radiochemistry is the chemistry of radioactive materials, where radioactive isotopes of elements are used to study the properties and chemical reactions of non-radioactive isotopes (often within radiochemistry the absence of radioactivity leads to a substance being described as being inactive as the isotopes are stable).
    /// <see href="https://w3id.org/skgo/modsci#Radiochemistry"></see></summary>
    let Radiochemistry =
        Namespaced_IRI.parse _namespace_name "Radiochemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Radiometrics"></see>
    /// </summary>
    let Radiometrics =
        Namespaced_IRI.parse _namespace_name "Radiometrics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Rainbow"></see>
    /// </summary>
    let Rainbow = Namespaced_IRI.parse _namespace_name "Rainbow" |> NamespacedName

    /// <summary>
    /// A relational database is a digital database based on the relational model of data, as proposed by E. F. Codd in 1970.
    /// <see href="https://w3id.org/skgo/modsci#RelationalDatabases"></see></summary>
    let RelationalDatabases =
        Namespaced_IRI.parse _namespace_name "RelationalDatabases" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Resampling_Methods"></see>
    /// </summary>
    let Resampling_Methods =
        Namespaced_IRI.parse _namespace_name "Resampling_Methods" |> NamespacedName

    /// <summary>
    /// Reverse engineering, also called back engineering, is the process by which a man-made object is deconstructed to reveal its designs, architecture, or to extract knowledge from the object; similar to scientific research, the only difference being that scientific research is about a natural phenomenon.
    /// <see href="https://w3id.org/skgo/modsci#ReverseEngineering"></see></summary>
    let ReverseEngineering =
        Namespaced_IRI.parse _namespace_name "ReverseEngineering" |> NamespacedName

    /// <summary>
    /// Robotics is an interdisciplinary branch of engineering and science that includes mechanical engineering, electronic engineering, information engineering, computer science, and others. Robotics deals with the design, construction, operation, and use of robots, as well as computer systems for their control, sensory feedback, and information processing.
    /// <see href="https://w3id.org/skgo/modsci#Robotics"></see></summary>
    let Robotics = Namespaced_IRI.parse _namespace_name "Robotics" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Rusting"></see>
    /// </summary>
    let Rusting = Namespaced_IRI.parse _namespace_name "Rusting" |> NamespacedName

    /// <summary>
    /// Science and technology studies is the study of how society, politics, and culture affect scientific research and technological innovation, and how these, in turn, affect society, politics and culture.
    /// <see href="https://w3id.org/skgo/modsci#ScienceAndTechnologyStudies"></see></summary>
    let ScienceAndTechnologyStudies =
        Namespaced_IRI.parse _namespace_name "ScienceAndTechnologyStudies" |> NamespacedName

    /// <summary>
    /// Science studies is an interdisciplinary research area that seeks to situate scientific expertise in broad social, historical, and philosophical contexts.
    /// <see href="https://w3id.org/skgo/modsci#ScienceStudies"></see></summary>
    let ScienceStudies =
        Namespaced_IRI.parse _namespace_name "ScienceStudies" |> NamespacedName

    /// <summary>
    /// Scientific modelling is a scientific activity, the aim of which is to make a particular part or feature of the world easier to understand, define, quantify, visualize, or simulate by referencing it to existing and usually commonly accepted knowledge.
    /// <see href="https://w3id.org/skgo/modsci#ScientificModeling"></see></summary>
    let ScientificModeling =
        Namespaced_IRI.parse _namespace_name "ScientificModeling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Sedimentology"></see>
    /// </summary>
    let Sedimentology =
        Namespaced_IRI.parse _namespace_name "Sedimentology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SeismicExploration"></see>
    /// </summary>
    let SeismicExploration =
        Namespaced_IRI.parse _namespace_name "SeismicExploration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Seismology"></see>
    /// </summary>
    let Seismology = Namespaced_IRI.parse _namespace_name "Seismology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Seismometer"></see>
    /// </summary>
    let Seismometer =
        Namespaced_IRI.parse _namespace_name "Seismometer" |> NamespacedName

    /// <summary>
    /// In programming language theory, semantics is the field concerned with the rigorous mathematical study of the meaning of programming languages. It does so by evaluating the meaning of syntactically valid strings defined by a specific programming language, showing the computation involved.
    /// <see href="https://w3id.org/skgo/modsci#Semantics"></see></summary>
    let Semantics = Namespaced_IRI.parse _namespace_name "Semantics" |> NamespacedName
    /// <summary>
    /// Semiotics is the study of signs (symbols) and signification systems, or rather semiotics are general theories of signs.
    /// <see href="https://w3id.org/skgo/modsci#Semiotics"></see></summary>
    let Semiotics = Namespaced_IRI.parse _namespace_name "Semiotics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SeparationScience"></see>
    /// </summary>
    let SeparationScience =
        Namespaced_IRI.parse _namespace_name "SeparationScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ShimadzuCorp"></see>
    /// </summary>
    let ShimadzuCorp =
        Namespaced_IRI.parse _namespace_name "ShimadzuCorp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Shrinkage"></see>
    /// </summary>
    let Shrinkage = Namespaced_IRI.parse _namespace_name "Shrinkage" |> NamespacedName

    /// <summary>
    /// Social psychology is the scientific study of how people's thoughts, feelings, and behaviors are influenced by the actual, imagined or implied presence of others.
    /// <see href="https://w3id.org/skgo/modsci#SocialPsychology"></see></summary>
    let SocialPsychology =
        Namespaced_IRI.parse _namespace_name "SocialPsychology" |> NamespacedName

    /// <summary>
    /// Social work is an academic discipline and profession that concerns itself with individuals, families, groups and communities in an effort to enhance social functioning and overall well-being.
    /// <see href="https://w3id.org/skgo/modsci#SocialWork"></see></summary>
    let SocialWork = Namespaced_IRI.parse _namespace_name "SocialWork" |> NamespacedName

    /// <summary>
    /// Sociobiology is a field of biology that aims to examine and explain social behavior in terms of evolution.
    /// <see href="https://w3id.org/skgo/modsci#Sociobiology"></see></summary>
    let Sociobiology =
        Namespaced_IRI.parse _namespace_name "Sociobiology" |> NamespacedName

    /// <summary>
    /// Sociology is the study of social behaviour or society, including its origins, development, organization, networks, and institutions. and critical analysis to develop a body of knowledge about social order, disorder, and change.
    /// <see href="https://w3id.org/skgo/modsci#Sociology"></see></summary>
    let Sociology = Namespaced_IRI.parse _namespace_name "Sociology" |> NamespacedName

    /// <summary>
    /// Soil biology is the study of microbial and faunal activity and ecology in soil.
    /// <see href="https://w3id.org/skgo/modsci#SoilBiology"></see></summary>
    let SoilBiology =
        Namespaced_IRI.parse _namespace_name "SoilBiology" |> NamespacedName

    /// <summary>
    /// Soil science is the study of soil as a natural resource on the surface of the Earth including soil formation, classification and mapping; physical, chemical, biological, and fertility properties of soils; and these properties in relation to the use and management of soils.
    /// <see href="https://w3id.org/skgo/modsci#SoilScience"></see></summary>
    let SoilScience =
        Namespaced_IRI.parse _namespace_name "SoilScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SoilSciences"></see>
    /// </summary>
    let SoilSciences =
        Namespaced_IRI.parse _namespace_name "SoilSciences" |> NamespacedName

    /// <summary>
    /// Solid mechanics is a mathematical discipline within continuum mechanics, dealing with the mechanical behavior of solid materials.
    /// <see href="https://w3id.org/skgo/modsci#SolidMechanics"></see></summary>
    let SolidMechanics =
        Namespaced_IRI.parse _namespace_name "SolidMechanics" |> NamespacedName

    /// <summary>
    /// Solid-state chemistry, also sometimes referred as materials chemistry, is the study of the synthesis, structure, and properties of solid phase materials, particularly, but not necessarily exclusively of, non-molecular solids.
    /// <see href="https://w3id.org/skgo/modsci#SolidStateChemistry"></see></summary>
    let SolidStateChemistry =
        Namespaced_IRI.parse _namespace_name "SolidStateChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SolutionChemistry"></see>
    /// </summary>
    let SolutionChemistry =
        Namespaced_IRI.parse _namespace_name "SolutionChemistry" |> NamespacedName

    /// <summary>
    /// Space science encompasses all of the scientific disciplines that involve space exploration and study natural phenomena and physical bodies occurring in outer space, such as space medicine and astrobiology.
    /// <see href="https://w3id.org/skgo/modsci#SpaceScience"></see></summary>
    let SpaceScience =
        Namespaced_IRI.parse _namespace_name "SpaceScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Spectrogram"></see>
    /// </summary>
    let Spectrogram =
        Namespaced_IRI.parse _namespace_name "Spectrogram" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Spectrometer"></see>
    /// </summary>
    let Spectrometer =
        Namespaced_IRI.parse _namespace_name "Spectrometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Spectroscopy"></see>
    /// </summary>
    let Spectroscopy =
        Namespaced_IRI.parse _namespace_name "Spectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Speed_of_light"></see>
    /// </summary>
    let Speed_of_light =
        Namespaced_IRI.parse _namespace_name "Speed_of_light" |> NamespacedName

    /// <summary>
    /// Sports science is a discipline that studies how the healthy human body works during exercise, and how sport and physical activity promote health and performance from cellular to whole body perspectives.
    /// <see href="https://w3id.org/skgo/modsci#SportsScience"></see></summary>
    let SportsScience =
        Namespaced_IRI.parse _namespace_name "SportsScience" |> NamespacedName

    /// <summary>
    /// The study of stars and stellar evolution is fundamental to our understanding of the Universe.
    /// <see href="https://w3id.org/skgo/modsci#StellarAstronomy"></see></summary>
    let StellarAstronomy =
        Namespaced_IRI.parse _namespace_name "StellarAstronomy" |> NamespacedName

    /// <summary>
    /// Stereochemistry, a subdiscipline of chemistry, involves the study of the relative spatial arrangement of atoms that form the structure of molecules and their manipulation.
    /// <see href="https://w3id.org/skgo/modsci#Stereochemistry"></see></summary>
    let Stereochemistry =
        Namespaced_IRI.parse _namespace_name "Stereochemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Storm"></see>
    /// </summary>
    let Storm = Namespaced_IRI.parse _namespace_name "Storm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Stratigraphy"></see>
    /// </summary>
    let Stratigraphy =
        Namespaced_IRI.parse _namespace_name "Stratigraphy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#StructuralChemistry"></see>
    /// </summary>
    let StructuralChemistry =
        Namespaced_IRI.parse _namespace_name "StructuralChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#StructuralGeology"></see>
    /// </summary>
    let StructuralGeology =
        Namespaced_IRI.parse _namespace_name "StructuralGeology" |> NamespacedName

    /// <summary>
    /// Structured storage is computer storage for structured data, often in the form of a distributed database.
    /// <see href="https://w3id.org/skgo/modsci#StructuredStorage"></see></summary>
    let StructuredStorage =
        Namespaced_IRI.parse _namespace_name "StructuredStorage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Subset_Selection"></see>
    /// </summary>
    let Subset_Selection =
        Namespaced_IRI.parse _namespace_name "Subset_Selection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Subsun"></see>
    /// </summary>
    let Subsun = Namespaced_IRI.parse _namespace_name "Subsun" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Supernova"></see>
    /// </summary>
    let Supernova = Namespaced_IRI.parse _namespace_name "Supernova" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Support_Vector_Machines"></see>
    /// </summary>
    let Support_Vector_Machines =
        Namespaced_IRI.parse _namespace_name "Support_Vector_Machines" |> NamespacedName

    /// <summary>
    /// Supramolecular chemistry is a branch of chemistry that describes self-organization or self-assembly of systems to well-defined molecular architectures.
    /// <see href="https://w3id.org/skgo/modsci#SupramolecularChemistry"></see></summary>
    let SupramolecularChemistry =
        Namespaced_IRI.parse _namespace_name "SupramolecularChemistry" |> NamespacedName

    /// <summary>
    /// Surface chemistry is the study of chemical phenomena that occur at the interface of two phases
    /// <see href="https://w3id.org/skgo/modsci#SurfaceChemistry"></see></summary>
    let SurfaceChemistry =
        Namespaced_IRI.parse _namespace_name "SurfaceChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SynthesisOfMaterials"></see>
    /// </summary>
    let SynthesisOfMaterials =
        Namespaced_IRI.parse _namespace_name "SynthesisOfMaterials" |> NamespacedName

    /// <summary>
    /// Systems science is the field of science surrounding systems theory, cybernetics, the science of complex systems.
    /// <see href="https://w3id.org/skgo/modsci#SystemsScience"></see></summary>
    let SystemsScience =
        Namespaced_IRI.parse _namespace_name "SystemsScience" |> NamespacedName

    /// <summary>
    /// Technology is the collection of techniques, skills, methods, and processes used in the production of goods or services or in the accomplishment of objectives, such as scientific investigation.
    /// <see href="https://w3id.org/skgo/modsci#Technology"></see></summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Techtron"></see>
    /// </summary>
    let Techtron = Namespaced_IRI.parse _namespace_name "Techtron" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Tectonics"></see>
    /// </summary>
    let Tectonics = Namespaced_IRI.parse _namespace_name "Tectonics" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Telescope"></see>
    /// </summary>
    let Telescope = Namespaced_IRI.parse _namespace_name "Telescope" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#instrumentUsedInScience"></see>
    /// </summary>
    let instrumentUsedInScience =
        Namespaced_IRI.parse _namespace_name "instrumentUsedInScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#The_Bridges_Organization"></see>
    /// </summary>
    let The_Bridges_Organization =
        Namespaced_IRI.parse _namespace_name "The_Bridges_Organization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#The_Fibonacci_Association"></see>
    /// </summary>
    let The_Fibonacci_Association =
        Namespaced_IRI.parse _namespace_name "The_Fibonacci_Association" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Theodolite"></see>
    /// </summary>
    let Theodolite = Namespaced_IRI.parse _namespace_name "Theodolite" |> NamespacedName

    /// <summary>
    /// Theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems
    /// <see href="https://w3id.org/skgo/modsci#TheoreticalBiology"></see></summary>
    let TheoreticalBiology =
        Namespaced_IRI.parse _namespace_name "TheoreticalBiology" |> NamespacedName

    /// <summary>
    /// Theoretical chemistry is the application of theoretical reasoning to chemistry.
    /// <see href="https://w3id.org/skgo/modsci#TheoreticalChemistry"></see></summary>
    let TheoreticalChemistry =
        Namespaced_IRI.parse _namespace_name "TheoreticalChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#TheoreticalComputerScience"></see>
    /// </summary>
    let TheoreticalComputerScience =
        Namespaced_IRI.parse _namespace_name "TheoreticalComputerScience" |> NamespacedName

    /// <summary>
    /// Theoretical linguistics, or general linguistics, is the branch of linguistics which inquires into the nature of language itself and seeks to answer fundamental questions as to what language is; how it works; how universal grammar (UG) as a domain-specific mental organ operates, if it exists at all; what are its unique properties; how does language relate to other cognitive processes, etc.
    /// <see href="https://w3id.org/skgo/modsci#TheoreticalLinguistics"></see></summary>
    let TheoreticalLinguistics =
        Namespaced_IRI.parse _namespace_name "TheoreticalLinguistics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#TheoryAndDesignOfMaterials"></see>
    /// </summary>
    let TheoryAndDesignOfMaterials =
        Namespaced_IRI.parse _namespace_name "TheoryAndDesignOfMaterials" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Thermocouple"></see>
    /// </summary>
    let Thermocouple =
        Namespaced_IRI.parse _namespace_name "Thermocouple" |> NamespacedName

    /// <summary>
    /// Thermodynamics concerns the physics of heat, work, temperature, energy, and entropy.
    /// <see href="https://w3id.org/skgo/modsci#Thermodynamics"></see></summary>
    let Thermodynamics =
        Namespaced_IRI.parse _namespace_name "Thermodynamics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Thermometer"></see>
    /// </summary>
    let Thermometer =
        Namespaced_IRI.parse _namespace_name "Thermometer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Time_Series_Analysis"></see>
    /// </summary>
    let Time_Series_Analysis =
        Namespaced_IRI.parse _namespace_name "Time_Series_Analysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Topology"></see>
    /// </summary>
    let Topology = Namespaced_IRI.parse _namespace_name "Topology" |> NamespacedName
    /// <summary>
    /// Toxicology is a scientific discipline, overlapping with biology, chemistry, pharmacology, and medicine, that involves the study of the adverse effects of chemical substances on living organisms and the practice of diagnosing and treating exposures to toxins and toxicants.
    /// <see href="https://w3id.org/skgo/modsci#Toxicology"></see></summary>
    let Toxicology = Namespaced_IRI.parse _namespace_name "Toxicology" |> NamespacedName

    /// <summary>
    /// Transdisciplinarity connotes a research strategy that crosses many disciplinary boundaries to create a holistic approach.
    /// <see href="https://w3id.org/skgo/modsci#Transdisciplinarity"></see></summary>
    let Transdisciplinarity =
        Namespaced_IRI.parse _namespace_name "Transdisciplinarity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#TransitionMetalChemistry"></see>
    /// </summary>
    let TransitionMetalChemistry =
        Namespaced_IRI.parse _namespace_name "TransitionMetalChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Tsunamis"></see>
    /// </summary>
    let Tsunamis = Namespaced_IRI.parse _namespace_name "Tsunamis" |> NamespacedName
    /// <summary>
    /// In mathematics, logic, and computer science, a type theory is any of a class of formal systems, some of which can serve as alternatives to set theory as a foundation for all mathematics. In type theory, every "term" has a "type" and operations are restricted to terms of a certain type.
    /// <see href="https://w3id.org/skgo/modsci#TypeTheory"></see></summary>
    let TypeTheory = Namespaced_IRI.parse _namespace_name "TypeTheory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#UbiquitousComputing"></see>
    /// </summary>
    let UbiquitousComputing =
        Namespaced_IRI.parse _namespace_name "UbiquitousComputing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#UniversalAlgebra"></see>
    /// </summary>
    let UniversalAlgebra =
        Namespaced_IRI.parse _namespace_name "UniversalAlgebra" |> NamespacedName

    /// <summary>
    /// Urban planning is a technical and political process concerned with the development and design of land use and the built environment, including air, water, and the infrastructure passing into and out of urban areas, such as transportation, communications, and distribution networks.
    /// <see href="https://w3id.org/skgo/modsci#UrbanPlanning"></see></summary>
    let UrbanPlanning =
        Namespaced_IRI.parse _namespace_name "UrbanPlanning" |> NamespacedName

    /// <summary>
    /// Veterinary medicine is the branch of medicine that deals with the prevention, diagnosis and treatment of disease, disorder and injury in animals.
    /// <see href="https://w3id.org/skgo/modsci#VeterinaryMedicine"></see></summary>
    let VeterinaryMedicine =
        Namespaced_IRI.parse _namespace_name "VeterinaryMedicine" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#VeterinarySciences"></see>
    /// </summary>
    let VeterinarySciences =
        Namespaced_IRI.parse _namespace_name "VeterinarySciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#VirtualReality"></see>
    /// </summary>
    let VirtualReality =
        Namespaced_IRI.parse _namespace_name "VirtualReality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Volcano"></see>
    /// </summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName

    /// <summary>
    /// Volcanology is a branch of geology that deals with the study of volcanoes, lava, magma, and related geological phenomena.
    /// <see href="https://w3id.org/skgo/modsci#Volcanology"></see></summary>
    let Volcanology =
        Namespaced_IRI.parse _namespace_name "Volcanology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Voltmeter"></see>
    /// </summary>
    let Voltmeter = Namespaced_IRI.parse _namespace_name "Voltmeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WatersCorporation"></see>
    /// </summary>
    let WatersCorporation =
        Namespaced_IRI.parse _namespace_name "WatersCorporation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Waves"></see>
    /// </summary>
    let Waves = Namespaced_IRI.parse _namespace_name "Waves" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WebSearch"></see>
    /// </summary>
    let WebSearch = Namespaced_IRI.parse _namespace_name "WebSearch" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WebServices"></see>
    /// </summary>
    let WebServices =
        Namespaced_IRI.parse _namespace_name "WebServices" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WebTechnologies"></see>
    /// </summary>
    let WebTechnologies =
        Namespaced_IRI.parse _namespace_name "WebTechnologies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Weddings"></see>
    /// </summary>
    let Weddings = Namespaced_IRI.parse _namespace_name "Weddings" |> NamespacedName
    /// <summary>
    /// Zoology is the study of the biology of animals.
    /// <see href="https://w3id.org/skgo/modsci#Zoology"></see></summary>
    let Zoology = Namespaced_IRI.parse _namespace_name "Zoology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromMathematics"></see>
    /// </summary>
    let appliesLawsFromMathematics =
        Namespaced_IRI.parse _namespace_name "appliesLawsFromMathematics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromPhysics"></see>
    /// </summary>
    let appliesLawsFromPhysics =
        Namespaced_IRI.parse _namespace_name "appliesLawsFromPhysics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromStatistics"></see>
    /// </summary>
    let appliesLawsFromStatistics =
        Namespaced_IRI.parse _namespace_name "appliesLawsFromStatistics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromThermodynamics"></see>
    /// </summary>
    let appliesLawsFromThermodynamics =
        Namespaced_IRI.parse _namespace_name "appliesLawsFromThermodynamics" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByAppliedSciences"></see>
    /// </summary>
    let discoveredByAppliedSciences =
        Namespaced_IRI.parse _namespace_name "discoveredByAppliedSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByBehaviouralSciences"></see>
    /// </summary>
    let discoveredByBehaviouralSciences =
        Namespaced_IRI.parse _namespace_name "discoveredByBehaviouralSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByFormalScience"></see>
    /// </summary>
    let discoveredByFormalScience =
        Namespaced_IRI.parse _namespace_name "discoveredByFormalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByHealthSciences"></see>
    /// </summary>
    let discoveredByHealthSciences =
        Namespaced_IRI.parse _namespace_name "discoveredByHealthSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByInterdisciplinaryStudies"></see>
    /// </summary>
    let discoveredByInterdisciplinaryStudies =
        Namespaced_IRI.parse _namespace_name "discoveredByInterdisciplinaryStudies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByMachine"></see>
    /// </summary>
    let discoveredByMachine =
        Namespaced_IRI.parse _namespace_name "discoveredByMachine" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByNaturalScience"></see>
    /// </summary>
    let discoveredByNaturalScience =
        Namespaced_IRI.parse _namespace_name "discoveredByNaturalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredBySocialSciences"></see>
    /// </summary>
    let discoveredBySocialSciences =
        Namespaced_IRI.parse _namespace_name "discoveredBySocialSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#f-BlockChemistry"></see>
    /// </summary>
    let ``f-BlockChemistry`` =
        Namespaced_IRI.parse _namespace_name "f-BlockChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#followsMethod"></see>
    /// </summary>
    let followsMethod =
        Namespaced_IRI.parse _namespace_name "followsMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasApplication"></see>
    /// </summary>
    let hasApplication =
        Namespaced_IRI.parse _namespace_name "hasApplication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasCollaborationWith"></see>
    /// </summary>
    let hasCollaborationWith =
        Namespaced_IRI.parse _namespace_name "hasCollaborationWith" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasManufacturer"></see>
    /// </summary>
    let hasManufacturer =
        Namespaced_IRI.parse _namespace_name "hasManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isManufacturerOf"></see>
    /// </summary>
    let isManufacturerOf =
        Namespaced_IRI.parse _namespace_name "isManufacturerOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasMethodsInspiredFrom"></see>
    /// </summary>
    let hasMethodsInspiredFrom =
        Namespaced_IRI.parse _namespace_name "hasMethodsInspiredFrom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasScientificInstrumentManufacturer"></see>
    /// </summary>
    let hasScientificInstrumentManufacturer =
        Namespaced_IRI.parse _namespace_name "hasScientificInstrumentManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#inspiredFromPhenomenon"></see>
    /// </summary>
    let inspiredFromPhenomenon =
        Namespaced_IRI.parse _namespace_name "inspiredFromPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#inspiredFromScientificDiscovery"></see>
    /// </summary>
    let inspiredFromScientificDiscovery =
        Namespaced_IRI.parse _namespace_name "inspiredFromScientificDiscovery" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#interestedInPhenomenon"></see>
    /// </summary>
    let interestedInPhenomenon =
        Namespaced_IRI.parse _namespace_name "interestedInPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfAppliedScience"></see>
    /// </summary>
    let isApplicationOfAppliedScience =
        Namespaced_IRI.parse _namespace_name "isApplicationOfAppliedScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfBehaviouralSciences"></see>
    /// </summary>
    let isApplicationOfBehaviouralSciences =
        Namespaced_IRI.parse _namespace_name "isApplicationOfBehaviouralSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfFormalScience"></see>
    /// </summary>
    let isApplicationOfFormalScience =
        Namespaced_IRI.parse _namespace_name "isApplicationOfFormalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfHealthSciences"></see>
    /// </summary>
    let isApplicationOfHealthSciences =
        Namespaced_IRI.parse _namespace_name "isApplicationOfHealthSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfInterdisciplinaryStudies"></see>
    /// </summary>
    let isApplicationOfInterdisciplinaryStudies =
        Namespaced_IRI.parse _namespace_name "isApplicationOfInterdisciplinaryStudies" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfNaturalScience"></see>
    /// </summary>
    let isApplicationOfNaturalScience =
        Namespaced_IRI.parse _namespace_name "isApplicationOfNaturalScience" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfSocialSciences"></see>
    /// </summary>
    let isApplicationOfSocialSciences =
        Namespaced_IRI.parse _namespace_name "isApplicationOfSocialSciences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#study_of_wetlands"></see>
    /// </summary>
    let study_of_wetlands =
        Namespaced_IRI.parse _namespace_name "study_of_wetlands" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#suppliesSubstancesTo"></see>
    /// </summary>
    let suppliesSubstancesTo =
        Namespaced_IRI.parse _namespace_name "suppliesSubstancesTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#takeSunstancesFrom"></see>
    /// </summary>
    let takeSunstancesFrom =
        Namespaced_IRI.parse _namespace_name "takeSunstancesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#temperature_gradient"></see>
    /// </summary>
    let temperature_gradient =
        Namespaced_IRI.parse _namespace_name "temperature_gradient" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#usesTechniquesFrom"></see>
    /// </summary>
    let usesTechniquesFrom =
        Namespaced_IRI.parse _namespace_name "usesTechniquesFrom" |> NamespacedName
