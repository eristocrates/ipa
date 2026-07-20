namespace https.w3id.org.skgo.modsci.hash

open DoxAletheia

module modsci =
    let _namespace_name = "https://w3id.org/skgo/modsci#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#z"></see>
    /// </summary>
    let z = _prefix "z"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#y"></see>
    /// </summary>
    let y = _prefix "y"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#scientistBelongsTo"></see>
    /// </summary>
    let scientistBelongsTo = _prefix "scientistBelongsTo"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#x"></see>
    /// </summary>
    let x = _prefix "x"
    /// <summary>
    /// An organization which is created for the purpose of scientific research and development.
    /// <see href="https://w3id.org/skgo/modsci#ScientificOrganization"></see></summary>
    let ScientificOrganization = _prefix "ScientificOrganization"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isDiscoveredBy"></see>
    /// </summary>
    let isDiscoveredBy = _prefix "isDiscoveredBy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isDiscoveredByScientist"></see>
    /// </summary>
    let isDiscoveredByScientist = _prefix "isDiscoveredByScientist"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isDiscoveredByOrganization"></see>
    /// </summary>
    let isDiscoveredByOrganization = _prefix "isDiscoveredByOrganization"
    /// <summary>
    /// A scientist is someone who conducts scientific research to advance knowledge in an area of interest.
    /// <see href="https://w3id.org/skgo/modsci#Scientist"></see></summary>
    let Scientist = _prefix "Scientist"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByScientist"></see>
    /// </summary>
    let discoveredByScientist = _prefix "discoveredByScientist"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByScience"></see>
    /// </summary>
    let discoveredByScience = _prefix "discoveredByScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ADInstruments"></see>
    /// </summary>
    let ADInstruments = _prefix "ADInstruments"
    /// <summary>
    /// Companies manufacturing equipment for scientific sstudies.
    /// <see href="https://w3id.org/skgo/modsci#ScientificInstrumentManufacturer"></see></summary>
    let ScientificInstrumentManufacturer = _prefix "ScientificInstrumentManufacturer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Accelerometer"></see>
    /// </summary>
    let Accelerometer = _prefix "Accelerometer"
    /// <summary>
    /// A scientific instrument is, broadly speaking, a device or tool used for scientific purposes, including the study of both natural phenomena and theoretical research.
    /// <see href="https://w3id.org/skgo/modsci#ScientificInstrument"></see></summary>
    let ScientificInstrument = _prefix "ScientificInstrument"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Accumulator"></see>
    /// </summary>
    let Accumulator = _prefix "Accumulator"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InstrumentFunctionDesription"></see>
    /// </summary>
    let InstrumentFunctionDesription = _prefix "InstrumentFunctionDesription"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#instrumentInventedBy"></see>
    /// </summary>
    let instrumentInventedBy = _prefix "instrumentInventedBy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Waldemar_Jungner"></see>
    /// </summary>
    let Waldemar_Jungner = _prefix "Waldemar_Jungner"
    /// <summary>
    /// For chemicals that can behave as acids or bases
    /// <see href="https://w3id.org/skgo/modsci#AcidbaseChemistry"></see></summary>
    let AcidbaseChemistry = _prefix "AcidbaseChemistry"
    /// <summary>
    /// Chemistry is defined as the science of matter, different from physics, in terms of matter's chemical structure, reactivity, properties and reactions or transformations.
    /// <see href="https://w3id.org/skgo/modsci#Chemistry"></see></summary>
    let Chemistry = _prefix "Chemistry"
    /// <summary>
    /// Acoustics is a branch of continuum mechanics and is the study of sound, mechanical waves in gases, liquids, and solids.
    /// <see href="https://w3id.org/skgo/modsci#Acoustics"></see></summary>
    let Acoustics = _prefix "Acoustics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ClassicalPhysics"></see>
    /// </summary>
    let ClassicalPhysics = _prefix "ClassicalPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AgilentTechnologies"></see>
    /// </summary>
    let AgilentTechnologies = _prefix "AgilentTechnologies"
    /// <summary>
    /// Agriculture, also known as farming, is the process of producing food, feed, fiber and other desired products by cultivation of certain plants and the raising of domesticated animals.
    /// <see href="https://w3id.org/skgo/modsci#Agriculture"></see></summary>
    let Agriculture = _prefix "Agriculture"
    /// <summary>
    /// Applied science is the use or the study of the use of scientific knowledge to develop technology.
    /// <see href="https://w3id.org/skgo/modsci#AppliedSciences"></see></summary>
    let AppliedSciences = _prefix "AppliedSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Agronomy"></see>
    /// </summary>
    let Agronomy = _prefix "Agronomy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Algebra"></see>
    /// </summary>
    let Algebra = _prefix "Algebra"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PureMathematics"></see>
    /// </summary>
    let PureMathematics = _prefix "PureMathematics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Algorithms"></see>
    /// </summary>
    let Algorithms = _prefix "Algorithms"
    /// <summary>
    /// A scientific method is a sequence or collection of processes that are considered characteristic of scientific investigation and the acquisition of new scientific knowledge based upon physical evidence.
    /// <see href="https://w3id.org/skgo/modsci#ScientificMethod"></see></summary>
    let ScientificMethod = _prefix "ScientificMethod"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ammeter"></see>
    /// </summary>
    let Ammeter = _prefix "Ammeter"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Friedrich_Drexler"></see>
    /// </summary>
    let Friedrich_Drexler = _prefix "Friedrich_Drexler"
    /// <summary>
    /// Analytical chemistry is the analysis of material samples to gain an understanding of their chemical composition and structure.
    /// <see href="https://w3id.org/skgo/modsci#AnalyticalChemistry"></see></summary>
    let AnalyticalChemistry = _prefix "AnalyticalChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AnalyticalSpectrometry"></see>
    /// </summary>
    let AnalyticalSpectrometry = _prefix "AnalyticalSpectrometry"
    /// <summary>
    /// Anatomy is the study of the structure and organization of living things.
    /// <see href="https://w3id.org/skgo/modsci#Anatomy"></see></summary>
    let Anatomy = _prefix "Anatomy"
    /// <summary>
    /// Biology is the science of life. It is concerned with the characteristics and behaviors of organisms
    /// <see href="https://w3id.org/skgo/modsci#Biology"></see></summary>
    let Biology = _prefix "Biology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Anemometer"></see>
    /// </summary>
    let Anemometer = _prefix "Anemometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AnimalProduction"></see>
    /// </summary>
    let AnimalProduction = _prefix "AnimalProduction"
    /// <summary>
    /// Anthropology is the scientific study of humans, human behavior and societies in the past and present.
    /// <see href="https://w3id.org/skgo/modsci#Anthropology"></see></summary>
    let Anthropology = _prefix "Anthropology"
    /// <summary>
    /// The social sciences are academic disciplines concerned with the study of the social life of human groups and individuals including anthropology, economics, geography, history, political science, psychology, social studies, and sociology.
    /// <see href="https://w3id.org/skgo/modsci#SocialSciences"></see></summary>
    let SocialSciences = _prefix "SocialSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AntonPaar"></see>
    /// </summary>
    let AntonPaar = _prefix "AntonPaar"
    /// <summary>
    /// An application of science is any use of scientific knowledge for a specific purpose, whether to do more science; to design a product, process, or medical treatment; to develop a new technology; or to predict the impacts of human actions.
    /// <see href="https://w3id.org/skgo/modsci#ApplicationOfScience"></see></summary>
    let ApplicationOfScience = _prefix "ApplicationOfScience"
    /// <summary>
    /// Applied mathematics is a branch of mathematics that concerns itself with the application of mathematical knowledge to other domains.
    /// <see href="https://w3id.org/skgo/modsci#AppliedMathematics"></see></summary>
    let AppliedMathematics = _prefix "AppliedMathematics"
    /// <summary>
    /// Mathematics (colloquially, maths, or math), is the body of knowledge centered on concepts such as quantity, structure, space, and change, and also the academic discipline that studies them.
    /// <see href="https://w3id.org/skgo/modsci#Mathematics"></see></summary>
    let Mathematics = _prefix "Mathematics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AppliedMechanics"></see>
    /// </summary>
    let AppliedMechanics = _prefix "AppliedMechanics"
    /// <summary>
    /// Applied physics is intended for a particular technological or practical use.
    /// <see href="https://w3id.org/skgo/modsci#AppliedPhysics"></see></summary>
    let AppliedPhysics = _prefix "AppliedPhysics"
    /// <summary>
    /// Physics is the science of the natural world. It deals with matter, energy, and the fundamental forces that govern the interactions between particles.
    /// <see href="https://w3id.org/skgo/modsci#Physics"></see></summary>
    let Physics = _prefix "Physics"
    /// <summary>
    /// Interdisciplinarity or interdisciplinary studies involves the combining of two or more academic disciplines into one activity (e.g., a research project).
    /// <see href="https://w3id.org/skgo/modsci#InterdisciplinaryStudies"></see></summary>
    let InterdisciplinaryStudies = _prefix "InterdisciplinaryStudies"
    /// <summary>
    /// Science is a systematic enterprise that builds and organizes knowledge in the form of testable explanations and predictions about the universe.
    /// <see href="https://w3id.org/skgo/modsci#ModernScience"></see></summary>
    let ModernScience = _prefix "ModernScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ApproximationTheory"></see>
    /// </summary>
    let ApproximationTheory = _prefix "ApproximationTheory"
    /// <summary>
    /// Archaeology, or archeology, is the study of human activity through the recovery and analysis of material culture.
    /// <see href="https://w3id.org/skgo/modsci#Archaeology"></see></summary>
    let Archaeology = _prefix "Archaeology"
    /// <summary>
    /// Architecture is the art and science of designing buildings.
    /// <see href="https://w3id.org/skgo/modsci#Architecture"></see></summary>
    let Architecture = _prefix "Architecture"
    /// <summary>
    /// In computer science, artificial intelligence (AI), sometimes called machine intelligence, is intelligence demonstrated by machines, in contrast to the natural intelligence displayed by humans. Colloquially, the term "artificial intelligence" is often used to describe machines (or computers) that mimic "cognitive" functions that humans associate with the human mind, such as "learning" and "problem solving".
    /// <see href="https://w3id.org/skgo/modsci#ArtificialIntelligence"></see></summary>
    let ArtificialIntelligence = _prefix "ArtificialIntelligence"
    /// <summary>
    /// Computer science is the study of processes that interact with data and that can be represented as data in the form of programs.
    /// <see href="https://w3id.org/skgo/modsci#ComputerScience"></see></summary>
    let ComputerScience = _prefix "ComputerScience"
    /// <summary>
    /// Astrobiology, formerly known as exobiology, is an interdisciplinary scientific field concerned with the origins, early evolution, distribution, and future of life in the universe.
    /// <see href="https://w3id.org/skgo/modsci#Astrobiology"></see></summary>
    let Astrobiology = _prefix "Astrobiology"
    /// <summary>
    /// Astrochemistry is the study of the abundance and reactions of molecules in the Universe, and their interaction with radiation.
    /// <see href="https://w3id.org/skgo/modsci#Astrochemistry"></see></summary>
    let Astrochemistry = _prefix "Astrochemistry"
    /// <summary>
    /// Astrometry is the study of the positions, distances between, and motions of astronomical objects.
    /// <see href="https://w3id.org/skgo/modsci#Astrometry"></see></summary>
    let Astrometry = _prefix "Astrometry"
    /// <summary>
    /// is a science involving the observation and explanation of events occurring outside Earth and its atmosphere.
    /// <see href="https://w3id.org/skgo/modsci#Astronomy"></see></summary>
    let Astronomy = _prefix "Astronomy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AstronomicalPhenomena"></see>
    /// </summary>
    let AstronomicalPhenomena = _prefix "AstronomicalPhenomena"
    /// <summary>
    /// Natural phenomena include gravity, tides, biological processes and oscillation.
    /// <see href="https://w3id.org/skgo/modsci#NaturalPhenomenon"></see></summary>
    let NaturalPhenomenon = _prefix "NaturalPhenomenon"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Astronomical_Studies"></see>
    /// </summary>
    let Astronomical_Studies = _prefix "Astronomical_Studies"
    /// <summary>
    /// The natural sciences are those branches of empirical science that produce a comprehension of the natural world through the use of data collected from it by observation and measurement to construct deterministic and/or stochastic quantitative models of its phenomena.
    /// <see href="https://w3id.org/skgo/modsci#NaturalScience"></see></summary>
    let NaturalScience = _prefix "NaturalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#AtmosphericPhenomena"></see>
    /// </summary>
    let AtmosphericPhenomena = _prefix "AtmosphericPhenomena"
    /// <summary>
    /// Atmospheric science is an umbrella term for the study of the atmosphere and its processes.
    /// <see href="https://w3id.org/skgo/modsci#AtmosphericSciences"></see></summary>
    let AtmosphericSciences = _prefix "AtmosphericSciences"
    /// <summary>
    /// Earth science (also known as geoscience, the geosciences, or the Earth sciences) includes all the sciences related to the planet Earth.
    /// <see href="https://w3id.org/skgo/modsci#EarthScience"></see></summary>
    let EarthScience = _prefix "EarthScience"
    /// <summary>
    /// Atomic, molecular, and optical physics (AMO) is the study of matter-matter and light-matter interactions; at the scale of one or a few atoms and energy scales around several electron volts.
    /// <see href="https://w3id.org/skgo/modsci#AtomicPhysics"></see></summary>
    let AtomicPhysics = _prefix "AtomicPhysics"
    /// <summary>
    /// Molecular physics deals with the physics and chemistry of molecules.
    /// <see href="https://w3id.org/skgo/modsci#MolecularPhysics"></see></summary>
    let MolecularPhysics = _prefix "MolecularPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Aurora"></see>
    /// </summary>
    let Aurora = _prefix "Aurora"
    /// <summary>
    /// Automata theory is the study of abstract machines and automata, as well as the computational problems that can be solved using them.
    /// <see href="https://w3id.org/skgo/modsci#AutomataTheory"></see></summary>
    let AutomataTheory = _prefix "AutomataTheory"
    /// <summary>
    /// Theory of computation is focused on answering fundamental questions about what can be computed and what amount of resources are required to perform those computations.
    /// <see href="https://w3id.org/skgo/modsci#TheoryOfComputation"></see></summary>
    let TheoryOfComputation = _prefix "TheoryOfComputation"
    /// <summary>
    /// Automated reasoning is an area of computer science, cognitive science, and mathematical logic dedicated to understanding different aspects of reasoning.
    /// <see href="https://w3id.org/skgo/modsci#AutomatedReasoning"></see></summary>
    let AutomatedReasoning = _prefix "AutomatedReasoning"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Barometer"></see>
    /// </summary>
    let Barometer = _prefix "Barometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Evangelista_Torricelli"></see>
    /// </summary>
    let Evangelista_Torricelli = _prefix "Evangelista_Torricelli"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BasinAnalysis"></see>
    /// </summary>
    let BasinAnalysis = _prefix "BasinAnalysis"
    /// <summary>
    /// Geology is an earth science concerned with the solid Earth, the rocks of which it is composed, and the processes by which they change over time.
    /// <see href="https://w3id.org/skgo/modsci#Geology"></see></summary>
    let Geology = _prefix "Geology"
    /// <summary>
    /// Behavioural sciences explore the cognitive processes within organisms and the behavioural interactions between organisms in the natural world.
    /// <see href="https://w3id.org/skgo/modsci#BehaviouralSciences"></see></summary>
    let BehaviouralSciences = _prefix "BehaviouralSciences"
    /// <summary>
    /// Biochemistry is the chemistry of life.
    /// <see href="https://w3id.org/skgo/modsci#Biochemistry"></see></summary>
    let Biochemistry = _prefix "Biochemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biochip"></see>
    /// </summary>
    let Biochip = _prefix "Biochip"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfScience"></see>
    /// </summary>
    let isApplicationOfScience = _prefix "isApplicationOfScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Studying_biochemical_reactions"></see>
    /// </summary>
    let Studying_biochemical_reactions = _prefix "Studying_biochemical_reactions"
    /// <summary>
    /// Biological engineering, or bioengineering/bio-engineering, is the application of principles of biology and the tools of engineering to create usable, tangible, economically viable products.
    /// <see href="https://w3id.org/skgo/modsci#Bioengineering"></see></summary>
    let Bioengineering = _prefix "Bioengineering"
    /// <summary>
    /// Engineering is the practical application of science. This is accomplished through knowledge, mathematics, and practical experience applied to the design of useful objects or processes.
    /// <see href="https://w3id.org/skgo/modsci#Engineering"></see></summary>
    let Engineering = _prefix "Engineering"
    /// <summary>
    /// Bioethics is the study of the ethical issues emerging from advances in biology and medicine.
    /// <see href="https://w3id.org/skgo/modsci#Bioethics"></see></summary>
    let Bioethics = _prefix "Bioethics"
    /// <summary>
    /// Biogeography is the study of the distribution of species and ecosystems in geographic space and through geological time.
    /// <see href="https://w3id.org/skgo/modsci#Biogeography"></see></summary>
    let Biogeography = _prefix "Biogeography"
    /// <summary>
    /// Bioinformatics and Computational biology are interdisciplinary fields of research, development and application of algorithms, computational and statistical methods for management and analysis of biological data, and for solving basic biological problems.
    /// <see href="https://w3id.org/skgo/modsci#Bioinformatics"></see></summary>
    let Bioinformatics = _prefix "Bioinformatics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BioinformaticsSoftware"></see>
    /// </summary>
    let BioinformaticsSoftware = _prefix "BioinformaticsSoftware"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ComputerSoftware"></see>
    /// </summary>
    let ComputerSoftware = _prefix "ComputerSoftware"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BioinorganicChemistry"></see>
    /// </summary>
    let BioinorganicChemistry = _prefix "BioinorganicChemistry"
    /// <summary>
    /// Inorganic chemistry is a catch-all discipline that covers everything in chemistry that is not organic chemistry.
    /// <see href="https://w3id.org/skgo/modsci#InorganicChemistry"></see></summary>
    let InorganicChemistry = _prefix "InorganicChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BiologicalMathematics"></see>
    /// </summary>
    let BiologicalMathematics = _prefix "BiologicalMathematics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BiologicalOceanography"></see>
    /// </summary>
    let BiologicalOceanography = _prefix "BiologicalOceanography"
    /// <summary>
    /// Oceanography also known as oceanology, is the study of the physical and biological aspects of the ocean.
    /// <see href="https://w3id.org/skgo/modsci#Oceanography"></see></summary>
    let Oceanography = _prefix "Oceanography"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#BiologicalPhenomena"></see>
    /// </summary>
    let BiologicalPhenomena = _prefix "BiologicalPhenomena"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biological_Studies"></see>
    /// </summary>
    let Biological_Studies = _prefix "Biological_Studies"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFrom"></see>
    /// </summary>
    let appliesLawsFrom = _prefix "appliesLawsFrom"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Physical_Studies"></see>
    /// </summary>
    let Physical_Studies = _prefix "Physical_Studies"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#requiresKnowledgeFrom"></see>
    /// </summary>
    let requiresKnowledgeFrom = _prefix "requiresKnowledgeFrom"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Historical_Studies"></see>
    /// </summary>
    let Historical_Studies = _prefix "Historical_Studies"
    /// <summary>
    /// Biomedical engineering (BME) or medical engineering is the application of engineering principles and design concepts to medicine and biology for healthcare purposes (e.g. diagnostic or therapeutic).
    /// <see href="https://w3id.org/skgo/modsci#BiomedicalEngineering"></see></summary>
    let BiomedicalEngineering = _prefix "BiomedicalEngineering"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biomedical_Signals"></see>
    /// </summary>
    let Biomedical_Signals = _prefix "Biomedical_Signals"
    /// <summary>
    /// Scientific Discovery is the process or product of successful scientific inquiry. Objects of discovery can be things, events, processes, causes, and properties as well as theories and hypotheses and their features (their explanatory power, for example).
    /// <see href="https://w3id.org/skgo/modsci#ScientificDiscovery"></see></summary>
    let ScientificDiscovery = _prefix "ScientificDiscovery"
    /// <summary>
    /// Biophysics is an interdisciplinary science that applies approaches and methods traditionally used in physics to study biological phenomena.
    /// <see href="https://w3id.org/skgo/modsci#Biophysics"></see></summary>
    let Biophysics = _prefix "Biophysics"
    /// <summary>
    /// Biological psychology,is the application of the principles of biology to the study of physiological and developmental mechanisms of behavior in humans and other animals.
    /// <see href="https://w3id.org/skgo/modsci#Biopsychology"></see></summary>
    let Biopsychology = _prefix "Biopsychology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Biosensors"></see>
    /// </summary>
    let Biosensors = _prefix "Biosensors"
    /// <summary>
    /// Biostatistics are the development and application of statistical methods to a wide range of topics in biology.
    /// <see href="https://w3id.org/skgo/modsci#Biostatistics"></see></summary>
    let Biostatistics = _prefix "Biostatistics"
    /// <summary>
    /// Biotechnology is a technology based on biology, especially when used in agriculture, food science, medicine, and genetic engineering.
    /// <see href="https://w3id.org/skgo/modsci#Biotechnology"></see></summary>
    let Biotechnology = _prefix "Biotechnology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Boiling"></see>
    /// </summary>
    let Boiling = _prefix "Boiling"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PhysicalPhenomena"></see>
    /// </summary>
    let PhysicalPhenomena = _prefix "PhysicalPhenomena"
    /// <summary>
    /// Botany also called plant science(s), plant biology or phytology, is the science of plant life and a branch of biology.
    /// <see href="https://w3id.org/skgo/modsci#Botany"></see></summary>
    let Botany = _prefix "Botany"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Breaking_waves"></see>
    /// </summary>
    let Breaking_waves = _prefix "Breaking_waves"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OceanographicPhenomena"></see>
    /// </summary>
    let OceanographicPhenomena = _prefix "OceanographicPhenomena"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Bruker"></see>
    /// </summary>
    let Bruker = _prefix "Bruker"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CalculusOfVariations"></see>
    /// </summary>
    let CalculusOfVariations = _prefix "CalculusOfVariations"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Caliper"></see>
    /// </summary>
    let Caliper = _prefix "Caliper"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Calorimeter"></see>
    /// </summary>
    let Calorimeter = _prefix "Calorimeter"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Catalysis"></see>
    /// </summary>
    let Catalysis = _prefix "Catalysis"
    /// <summary>
    /// Physical chemistry is the study of macroscopic, atomic, subatomic, and particulate phenomena in chemical systems in terms of the principles, practices, and concepts of physics such as motion, energy, force, time, thermodynamics, quantum chemistry, statistical mechanics, analytical dynamics and chemical equilibrium.
    /// <see href="https://w3id.org/skgo/modsci#PhysicalChemistry"></see></summary>
    let PhysicalChemistry = _prefix "PhysicalChemistry"
    /// <summary>
    /// Cell biology is a branch of biology that studies the structure and function of the cell, which is the basic unit of life.
    /// <see href="https://w3id.org/skgo/modsci#CellBiology"></see></summary>
    let CellBiology = _prefix "CellBiology"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalCharacterisationOfMaterials"></see>
    /// </summary>
    let ChemicalCharacterisationOfMaterials =
        _prefix "ChemicalCharacterisationOfMaterials"

    /// <summary>
    /// The interdisciplinary field of materials science is the design and discovery of new materials, particularly solids.
    /// <see href="https://w3id.org/skgo/modsci#MaterialsChemistry"></see></summary>
    let MaterialsChemistry = _prefix "MaterialsChemistry"
    /// <summary>
    /// Chemical engineering is the application of science, in particular chemistry, fluid physics, and biology, along with mathematics and economics to the human endeavor of converting raw materials or chemicals into more useful or valuable forms.
    /// <see href="https://w3id.org/skgo/modsci#ChemicalEngineering"></see></summary>
    let ChemicalEngineering = _prefix "ChemicalEngineering"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalOceanography"></see>
    /// </summary>
    let ChemicalOceanography = _prefix "ChemicalOceanography"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalPhenomena"></see>
    /// </summary>
    let ChemicalPhenomena = _prefix "ChemicalPhenomena"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ChemicalThermodynamics"></see>
    /// </summary>
    let ChemicalThermodynamics = _prefix "ChemicalThermodynamics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Chemical_Studies"></see>
    /// </summary>
    let Chemical_Studies = _prefix "Chemical_Studies"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasCloseRelationshipTo"></see>
    /// </summary>
    let hasCloseRelationshipTo = _prefix "hasCloseRelationshipTo"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ClassificationAlgorithms"></see>
    /// </summary>
    let ClassificationAlgorithms = _prefix "ClassificationAlgorithms"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CoalGeology"></see>
    /// </summary>
    let CoalGeology = _prefix "CoalGeology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CodingAndInformationTheory"></see>
    /// </summary>
    let CodingAndInformationTheory = _prefix "CodingAndInformationTheory"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DataFormat"></see>
    /// </summary>
    let DataFormat = _prefix "DataFormat"
    /// <summary>
    /// Cognitive science is the interdisciplinary, scientific study of the mind and its processes.
    /// <see href="https://w3id.org/skgo/modsci#CognitiveScience"></see></summary>
    let CognitiveScience = _prefix "CognitiveScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Colloid"></see>
    /// </summary>
    let Colloid = _prefix "Colloid"
    /// <summary>
    /// Interface and colloid science is an interdisciplinary intersection of branches of chemistry, physics, nanoscience and other fields dealing with colloids, heterogeneous systems consisting of a mechanical mixture of particles between 1 nm and 1000 nm dispersed in a continuous medium.
    /// <see href="https://w3id.org/skgo/modsci#ColloidalChemistry"></see></summary>
    let ColloidalChemistry = _prefix "ColloidalChemistry"
    /// <summary>
    /// Communications security is the discipline of preventing unauthorized interceptors from accessing telecommunications in an intelligible form, while still delivering content to the intended recipients.
    /// <see href="https://w3id.org/skgo/modsci#CommunicationAndSecurity"></see></summary>
    let CommunicationAndSecurity = _prefix "CommunicationAndSecurity"
    /// <summary>
    /// Communication is the act of conveying meanings from one entity or group to another through the use of mutually understood signs, symbols, and semiotic rules.
    /// <see href="https://w3id.org/skgo/modsci#CommunicationStudies"></see></summary>
    let CommunicationStudies = _prefix "CommunicationStudies"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Community_of_European_Solar_Radio_Astronomers"></see>
    /// </summary>
    let Community_of_European_Solar_Radio_Astronomers =
        _prefix "Community_of_European_Solar_Radio_Astronomers"

    /// <summary>
    /// A compiler implements a formal transformation from a high-level source program to a low-level target program.
    /// <see href="https://w3id.org/skgo/modsci#CompilerTheory"></see></summary>
    let CompilerTheory = _prefix "CompilerTheory"
    /// <summary>
    /// Programming languages can be used to accomplish different tasks in different ways.
    /// <see href="https://w3id.org/skgo/modsci#ProgrammingLanguages"></see></summary>
    let ProgrammingLanguages = _prefix "ProgrammingLanguages"
    /// <summary>
    /// Computability theory, also known as recursion theory, is a branch of mathematical logic, of computer science, and of the theory of computation that originated in the 1930s with the study of computable functions and Turing degrees.
    /// <see href="https://w3id.org/skgo/modsci#ComputabilityTheory"></see></summary>
    let ComputabilityTheory = _prefix "ComputabilityTheory"
    /// <summary>
    /// Computational complexity theory focuses on classifying computational problems according to their inherent difficulty, and relating these classes to each other. A computational problem is a task solved by a computer.
    /// <see href="https://w3id.org/skgo/modsci#ComputationalComplexityTheory"></see></summary>
    let ComputationalComplexityTheory = _prefix "ComputationalComplexityTheory"
    /// <summary>
    /// Computational linguistics is an interdisciplinary field concerned with the statistical or rule-based modeling of natural language from a computational perspective, as well as the study of appropriate computational approaches to linguistic questions.
    /// <see href="https://w3id.org/skgo/modsci#ComputationalLinguistics"></see></summary>
    let ComputationalLinguistics = _prefix "ComputationalLinguistics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ComputationalMathematics"></see>
    /// </summary>
    let ComputationalMathematics = _prefix "ComputationalMathematics"
    /// <summary>
    /// Computational physics is the study and implementation of numerical algorithms in order to solve problems in physics for which a quantitative theory already exists.
    /// <see href="https://w3id.org/skgo/modsci#ComputationalPhysics"></see></summary>
    let ComputationalPhysics = _prefix "ComputationalPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Computer-HumanInteraction"></see>
    /// </summary>
    let ``Computer-HumanInteraction`` = _prefix "Computer-HumanInteraction"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationSystems"></see>
    /// </summary>
    let InformationSystems = _prefix "InformationSystems"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ComputerApplications"></see>
    /// </summary>
    let ComputerApplications = _prefix "ComputerApplications"
    /// <summary>
    /// In computer science, concurrency is the ability of different parts or units of a program, algorithm, or problem to be executed out-of-order or in partial order, without affecting the final outcome. This allows for parallel execution of the concurrent units, which can significantly improve overall speed of the execution in multi-processor and multi-core systems.
    /// <see href="https://w3id.org/skgo/modsci#ComputerConcurrency"></see></summary>
    let ComputerConcurrency = _prefix "ComputerConcurrency"
    /// <summary>
    /// Systems in which several computations are executing simultaneously, and potentially interacting with each other.
    /// <see href="https://w3id.org/skgo/modsci#DistributedSystems"></see></summary>
    let DistributedSystems = _prefix "DistributedSystems"
    /// <summary>
    /// Computer graphics is the study of digital visual contents and involves the synthesis and manipulation of image data.
    /// Computer graphics are pictures and films created using computers. Usually, the term refers to computer-generated image data created with the help of specialized graphical hardware and software.
    /// <see href="https://w3id.org/skgo/modsci#ComputerGraphics"></see></summary>
    let ComputerGraphics = _prefix "ComputerGraphics"
    /// <summary>
    /// In computer science, digital image processing is the use of computer algorithms to perform image processing on digital images.
    /// <see href="https://w3id.org/skgo/modsci#ImageProcessing"></see></summary>
    let ImageProcessing = _prefix "ImageProcessing"
    /// <summary>
    /// Computer security, cybersecurity or information technology security (IT security) is the protection of computer systems from the theft of or damage to their hardware, software, or electronic data, as well as from the disruption or misdirection of the services they provide.
    /// <see href="https://w3id.org/skgo/modsci#ComputerSecurity"></see></summary>
    let ComputerSecurity = _prefix "ComputerSecurity"
    /// <summary>
    /// In computer engineering, computer architecture is a set of rules and methods that describe the functionality, organization, and implementation of computer systems.
    /// <see href="https://w3id.org/skgo/modsci#ComputerSystemArchitecture"></see></summary>
    let ComputerSystemArchitecture = _prefix "ComputerSystemArchitecture"
    /// <summary>
    /// Computer vision is an interdisciplinary scientific field that deals with how computers can be made to gain high-level understanding from digital images or videos.
    /// <see href="https://w3id.org/skgo/modsci#ComputerVision"></see></summary>
    let ComputerVision = _prefix "ComputerVision"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ConceptualModelling"></see>
    /// </summary>
    let ConceptualModelling = _prefix "ConceptualModelling"
    /// <summary>
    /// Condensed matter physics is the field of physics that deals with the macroscopic physical properties of matter.
    /// <see href="https://w3id.org/skgo/modsci#CondensedMatterPhysics"></see></summary>
    let CondensedMatterPhysics = _prefix "CondensedMatterPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Conservation_of_energy"></see>
    /// </summary>
    let Conservation_of_energy = _prefix "Conservation_of_energy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Julius_von_Mayer"></see>
    /// </summary>
    let Julius_von_Mayer = _prefix "Julius_von_Mayer"
    /// <summary>
    /// Physical cosmology is the study of the largest-scale structures and dynamics of the Universe and is concerned with fundamental questions about its origin, structure, evolution, and ultimate fate.
    /// <see href="https://w3id.org/skgo/modsci#Cosmology"></see></summary>
    let Cosmology = _prefix "Cosmology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#CropProduction"></see>
    /// </summary>
    let CropProduction = _prefix "CropProduction"
    /// <summary>
    /// Cryobiology is the study of living organisms, organs, biological tissues or biological cells at low temperatures.
    /// <see href="https://w3id.org/skgo/modsci#Cryobiology"></see></summary>
    let Cryobiology = _prefix "Cryobiology"
    /// <summary>
    /// Cryptography or cryptology is the practice and study of techniques for secure communication in the presence of third parties called adversaries.
    /// <see href="https://w3id.org/skgo/modsci#Cryptography"></see></summary>
    let Cryptography = _prefix "Cryptography"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Crystal_growth"></see>
    /// </summary>
    let Crystal_growth = _prefix "Crystal_growth"
    /// <summary>
    /// Crystallography is the scientific study of crystals.
    /// <see href="https://w3id.org/skgo/modsci#Crystallography"></see></summary>
    let Crystallography = _prefix "Crystallography"
    /// <summary>
    /// Cultural studies is a field of theoretically, politically, and empirically engaged cultural analysis that concentrates upon the political dynamics of contemporary culture, its historical foundations, defining traits, conflicts, and contingencies.
    /// <see href="https://w3id.org/skgo/modsci#CulturalStudies"></see></summary>
    let CulturalStudies = _prefix "CulturalStudies"
    /// <summary>
    /// Cybernetics is a transdisciplinary approach for exploring regulatory systems with feedback, their structures, constraints, and possibilities.
    /// <see href="https://w3id.org/skgo/modsci#Cybernetics"></see></summary>
    let Cybernetics = _prefix "Cybernetics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DNA_Sequencer"></see>
    /// </summary>
    let DNA_Sequencer = _prefix "DNA_Sequencer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DataEncryption"></see>
    /// </summary>
    let DataEncryption = _prefix "DataEncryption"
    /// <summary>
    /// Data mining is the process of discovering patterns in large data sets involving methods at the intersection of machine learning, statistics, and database systems.
    /// <see href="https://w3id.org/skgo/modsci#DataMining"></see></summary>
    let DataMining = _prefix "DataMining"
    /// <summary>
    /// Digital databases are managed using database management systems to store, create, maintain, and search data, through database models and query languages.
    /// <see href="https://w3id.org/skgo/modsci#DatabaseManagement"></see></summary>
    let DatabaseManagement = _prefix "DatabaseManagement"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DataStructures"></see>
    /// </summary>
    let DataStructures = _prefix "DataStructures"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DecisionSupportSystems"></see>
    /// </summary>
    let DecisionSupportSystems = _prefix "DecisionSupportSystems"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Decision_Trees"></see>
    /// </summary>
    let Decision_Trees = _prefix "Decision_Trees"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Decomposition"></see>
    /// </summary>
    let Decomposition = _prefix "Decomposition"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Deep_Learning"></see>
    /// </summary>
    let Deep_Learning = _prefix "Deep_Learning"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#inspiredFrom"></see>
    /// </summary>
    let inspiredFrom = _prefix "inspiredFrom"
    /// <summary>
    /// Dentistry, also known as Dental and Oral Medicine, is a branch of medicine that consists of the study, diagnosis, prevention, and treatment of diseases, disorders, and conditions of the oral cavity, commonly in the dentition but also the oral mucosa, and of adjacent and related structures and tissues, particularly in the maxillofacial (jaw and facial) area.
    /// <see href="https://w3id.org/skgo/modsci#Dentistry"></see></summary>
    let Dentistry = _prefix "Dentistry"
    /// <summary>
    /// Health sciences are those sciences which focus on health, or health care, as core parts of their subject matter.
    /// <see href="https://w3id.org/skgo/modsci#HealthSciences"></see></summary>
    let HealthSciences = _prefix "HealthSciences"
    /// <summary>
    /// Developmental biology is the study of the process by which animals and plants grow and develop.
    /// <see href="https://w3id.org/skgo/modsci#DevelopmentalBiology"></see></summary>
    let DevelopmentalBiology = _prefix "DevelopmentalBiology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DifferentialEquations"></see>
    /// </summary>
    let DifferentialEquations = _prefix "DifferentialEquations"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DiscoveryOfMethods"></see>
    /// </summary>
    let DiscoveryOfMethods = _prefix "DiscoveryOfMethods"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DiscoveryOfPhenomenon"></see>
    /// </summary>
    let DiscoveryOfPhenomenon = _prefix "DiscoveryOfPhenomenon"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#DiscreteMathematics"></see>
    /// </summary>
    let DiscreteMathematics = _prefix "DiscreteMathematics"
    /// <summary>
    /// Distributed computing is a field of computer science that studies distributed systems. A distributed system is a system whose components are located on different networked computers, which communicate and coordinate their actions by passing messages to one another.
    /// <see href="https://w3id.org/skgo/modsci#DistributedComputing"></see></summary>
    let DistributedComputing = _prefix "DistributedComputing"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Dynamo"></see>
    /// </summary>
    let Dynamo = _prefix "Dynamo"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Michael_Faraday"></see>
    /// </summary>
    let Michael_Faraday = _prefix "Michael_Faraday"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Dynamometer"></see>
    /// </summary>
    let Dynamometer = _prefix "Dynamometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#E3G"></see>
    /// </summary>
    let E3G = _prefix "E3G"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#EACSL"></see>
    /// </summary>
    let EACSL = _prefix "EACSL"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Earthquake"></see>
    /// </summary>
    let Earthquake = _prefix "Earthquake"
    /// <summary>
    /// A geological phenomenon is a phenomenon which is explained by or sheds light on the science of geology.
    /// <see href="https://w3id.org/skgo/modsci#GeologicalPhenomena"></see></summary>
    let GeologicalPhenomena = _prefix "GeologicalPhenomena"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#EcologicalApplications"></see>
    /// </summary>
    let EcologicalApplications = _prefix "EcologicalApplications"
    /// <summary>
    /// Environmental science is the science of the interactions between the physical, chemical, and biological components of the environment, but with particular attention to the effects of humans on the natural environment.
    /// <see href="https://w3id.org/skgo/modsci#EnvironmentalScience"></see></summary>
    let EnvironmentalScience = _prefix "EnvironmentalScience"
    /// <summary>
    /// Ecology is the branch of science that studies the distribution and interactions between living things and the physical environment.
    /// <see href="https://w3id.org/skgo/modsci#Ecology"></see></summary>
    let Ecology = _prefix "Ecology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Economic_Studies"></see>
    /// </summary>
    let Economic_Studies = _prefix "Economic_Studies"
    /// <summary>
    /// Economics is the social science that studies the production, distribution, and consumption of goods and services.
    /// <see href="https://w3id.org/skgo/modsci#Economics"></see></summary>
    let Economics = _prefix "Economics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#usesMethodsFrom"></see>
    /// </summary>
    let usesMethodsFrom = _prefix "usesMethodsFrom"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Statistics_Studies"></see>
    /// </summary>
    let Statistics_Studies = _prefix "Statistics_Studies"
    /// <summary>
    /// Education is the teaching or learning of knowledge, especially to develop the reasoning, judgement and skill required in adult life and professional occupations.
    /// <see href="https://w3id.org/skgo/modsci#Education"></see></summary>
    let Education = _prefix "Education"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ElectroanalyticalChemistry"></see>
    /// </summary>
    let ElectroanalyticalChemistry = _prefix "ElectroanalyticalChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrochemistry"></see>
    /// </summary>
    let Electrochemistry = _prefix "Electrochemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrodynamics"></see>
    /// </summary>
    let Electrodynamics = _prefix "Electrodynamics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrometer"></see>
    /// </summary>
    let Electrometer = _prefix "Electrometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electroscope"></see>
    /// </summary>
    let Electroscope = _prefix "Electroscope"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Electrostatics"></see>
    /// </summary>
    let Electrostatics = _prefix "Electrostatics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Elementar"></see>
    /// </summary>
    let Elementar = _prefix "Elementar"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ellipsometer"></see>
    /// </summary>
    let Ellipsometer = _prefix "Ellipsometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Engineering_Studies"></see>
    /// </summary>
    let Engineering_Studies = _prefix "Engineering_Studies"
    /// <summary>
    /// Environmental chemistry is the scientific study of the physical, chemical and biochemical properties and processes of polluting substances in the environment.
    /// <see href="https://w3id.org/skgo/modsci#EnvironmentalChemistry"></see></summary>
    let EnvironmentalChemistry = _prefix "EnvironmentalChemistry"
    /// <summary>
    /// Epidemiology is the study and analysis of the distribution (who, when, and where), patterns and determinants of health and disease conditions in defined populations.
    /// <see href="https://w3id.org/skgo/modsci#Epidemiology"></see></summary>
    let Epidemiology = _prefix "Epidemiology"
    /// <summary>
    /// Human factors and ergonomics is the application of psychological and physiological principles to the (engineering and) design of products, processes, and systems.
    /// <see href="https://w3id.org/skgo/modsci#Ergonomics"></see></summary>
    let Ergonomics = _prefix "Ergonomics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Erosion"></see>
    /// </summary>
    let Erosion = _prefix "Erosion"
    /// <summary>
    /// Ethnic studies, in the United States, is the interdisciplinary study of difference—chiefly race, ethnicity, and nation, but also sexuality, gender, and other such markings—and power, as expressed by the state, by civil society, and by individuals.
    /// <see href="https://w3id.org/skgo/modsci#EthnicStudies"></see></summary>
    let EthnicStudies = _prefix "EthnicStudies"
    /// <summary>
    /// Ethnobiology is the scientific study of the way living things are treated or used by different human cultures.
    /// <see href="https://w3id.org/skgo/modsci#Ethnobiology"></see></summary>
    let Ethnobiology = _prefix "Ethnobiology"
    /// <summary>
    /// Ethnology is the science that analyzes human cultures and compares them.
    /// <see href="https://w3id.org/skgo/modsci#Ethnology"></see></summary>
    let Ethnology = _prefix "Ethnology"
    /// <summary>
    /// Ethology is the scientific and objective study of animal behaviour, usually with a focus on behaviour under natural conditions, and viewing behaviour as an evolutionarily adaptive trait.
    /// <see href="https://w3id.org/skgo/modsci#Ethology"></see></summary>
    let Ethology = _prefix "Ethology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Eudiometer"></see>
    /// </summary>
    let Eudiometer = _prefix "Eudiometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isStudentOf"></see>
    /// </summary>
    let isStudentOf = _prefix "isStudentOf"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Galileo"></see>
    /// </summary>
    let Galileo = _prefix "Galileo"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#undertakesResearch"></see>
    /// </summary>
    let undertakesResearch = _prefix "undertakesResearch"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Mathematical_Studies"></see>
    /// </summary>
    let Mathematical_Studies = _prefix "Mathematical_Studies"
    /// <summary>
    /// Evolutionary biology is a sub-field of biology concerned with the study of the evolutionary processes that produced the diversity of life on Earth.
    /// <see href="https://w3id.org/skgo/modsci#EvolutionaryBiology"></see></summary>
    let EvolutionaryBiology = _prefix "EvolutionaryBiology"
    /// <summary>
    /// In computer science, evolutionary computation is a family of algorithms for global optimization inspired by biological evolution, and the subfield of artificial intelligence and soft computing studying these algorithms.
    /// <see href="https://w3id.org/skgo/modsci#EvolutionaryComputation"></see></summary>
    let EvolutionaryComputation = _prefix "EvolutionaryComputation"
    /// <summary>
    /// Soft computing, as opposed to traditional computing, deals with approximate models and gives solutions to complex real-life problems. Unlike hard computing, soft computing is tolerant of imprecision, uncertainty, partial truth, and approximations.
    /// <see href="https://w3id.org/skgo/modsci#SoftComputing"></see></summary>
    let SoftComputing = _prefix "SoftComputing"
    /// <summary>
    /// Evolutionary psychology is a theoretical approach in the social and natural sciences that examines psychological structure from a modern evolutionary perspective.
    /// <see href="https://w3id.org/skgo/modsci#EvolutionaryPsychology"></see></summary>
    let EvolutionaryPsychology = _prefix "EvolutionaryPsychology"
    /// <summary>
    /// Experimental physics is the category of disciplines and sub-disciplines in the field of physics that are concerned with the observation of physical phenomena and experiments.
    /// <see href="https://w3id.org/skgo/modsci#ExperimentalPhysics"></see></summary>
    let ExperimentalPhysics = _prefix "ExperimentalPhysics"
    /// <summary>
    /// It is the study of all astronomical objects which are not covered by galactic astronomy.
    /// <see href="https://w3id.org/skgo/modsci#ExtragalacticAstronomy"></see></summary>
    let ExtragalacticAstronomy = _prefix "ExtragalacticAstronomy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ExtraterrestrialGeology"></see>
    /// </summary>
    let ExtraterrestrialGeology = _prefix "ExtraterrestrialGeology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FinancialMathematics"></see>
    /// </summary>
    let FinancialMathematics = _prefix "FinancialMathematics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Fire"></see>
    /// </summary>
    let Fire = _prefix "Fire"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FisheriesSciences"></see>
    /// </summary>
    let FisheriesSciences = _prefix "FisheriesSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FlowAnalysis"></see>
    /// </summary>
    let FlowAnalysis = _prefix "FlowAnalysis"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FluidPhysics"></see>
    /// </summary>
    let FluidPhysics = _prefix "FluidPhysics"
    /// <summary>
    /// Food chemistry is the study of chemical processes and interactions of all biological and non-biological components of foods.
    /// <see href="https://w3id.org/skgo/modsci#FoodChemistry"></see></summary>
    let FoodChemistry = _prefix "FoodChemistry"
    /// <summary>
    /// Forensic science, also known as criminalistics, is the application of science to criminal and civil laws, mainly—on the criminal side—during criminal investigation, as governed by the legal standards of admissible evidence and criminal procedure.
    /// <see href="https://w3id.org/skgo/modsci#Forensics"></see></summary>
    let Forensics = _prefix "Forensics"
    /// <summary>
    /// Forestry is the art, science, and practice of studying and managing forests and related natural resources.
    /// <see href="https://w3id.org/skgo/modsci#Forestry"></see></summary>
    let Forestry = _prefix "Forestry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ForestrySciences"></see>
    /// </summary>
    let ForestrySciences = _prefix "ForestrySciences"
    /// <summary>
    /// Formal sciences are a branch of science studying formal language disciplines concerned with formal systems, such as logic, mathematics, statistics, theoretical computer science, artificial intelligence, information theory, game theory, systems theory, decision theory, and theoretical linguistics.
    /// <see href="https://w3id.org/skgo/modsci#FormalScience"></see></summary>
    let FormalScience = _prefix "FormalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Fraunhofer"></see>
    /// </summary>
    let Fraunhofer = _prefix "Fraunhofer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FreeRadicalChemistry"></see>
    /// </summary>
    let FreeRadicalChemistry = _prefix "FreeRadicalChemistry"
    /// <summary>
    /// Organic chemistry is the study of organic, or carbon based, molecules.
    /// <see href="https://w3id.org/skgo/modsci#OrganicChemistry"></see></summary>
    let OrganicChemistry = _prefix "OrganicChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Freezing"></see>
    /// </summary>
    let Freezing = _prefix "Freezing"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#FunctionalAnalysis"></see>
    /// </summary>
    let FunctionalAnalysis = _prefix "FunctionalAnalysis"
    /// <summary>
    /// The study of everything outside our galaxy, including all other galaxies.
    /// <see href="https://w3id.org/skgo/modsci#GalacticAstronomy"></see></summary>
    let GalacticAstronomy = _prefix "GalacticAstronomy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Galvanometer"></see>
    /// </summary>
    let Galvanometer = _prefix "Galvanometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Johann_Schweigger"></see>
    /// </summary>
    let Johann_Schweigger = _prefix "Johann_Schweigger"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Genetic_algorithms"></see>
    /// </summary>
    let Genetic_algorithms = _prefix "Genetic_algorithms"
    /// <summary>
    /// Genetics is the study of genes, heredity, and the variation of organisms, as well as the medical practice of diagnosing, treating, and counseling patients with genetic disorders.
    /// <see href="https://w3id.org/skgo/modsci#Genetics"></see></summary>
    let Genetics = _prefix "Genetics"
    /// <summary>
    /// Geochemistry is the science that uses the tools and principles of chemistry to explain the mechanisms behind major geological systems such as the Earth's crust and its oceans.
    /// <see href="https://w3id.org/skgo/modsci#Geochemistry"></see></summary>
    let Geochemistry = _prefix "Geochemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geochronology"></see>
    /// </summary>
    let Geochronology = _prefix "Geochronology"
    /// <summary>
    /// Geodesy is the Earth science of accurately measuring and understanding Earth's geometric shape, orientation in space and gravitational field.
    /// <see href="https://w3id.org/skgo/modsci#Geodesy"></see></summary>
    let Geodesy = _prefix "Geodesy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geodynamics"></see>
    /// </summary>
    let Geodynamics = _prefix "Geodynamics"
    /// <summary>
    /// Geophysics the physics of the Earth and its environment in space, and study of earth sciences using quantitative physics methods.
    /// <see href="https://w3id.org/skgo/modsci#Geophysics"></see></summary>
    let Geophysics = _prefix "Geophysics"
    /// <summary>
    /// Geography is a field of science devoted to the study of the lands, features, inhabitants, and phenomena of the Earth and planets.
    /// <see href="https://w3id.org/skgo/modsci#Geography"></see></summary>
    let Geography = _prefix "Geography"
    /// <summary>
    /// The Geological Sciences examine the physical and chemical processes within Earth and on its surface, including the study of natural resources and risks to habitable areas.
    /// <see href="https://w3id.org/skgo/modsci#GeologicalSciences"></see></summary>
    let GeologicalSciences = _prefix "GeologicalSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geological_Studies"></see>
    /// </summary>
    let Geological_Studies = _prefix "Geological_Studies"
    /// <summary>
    /// Geomorphology is the science of surface features and landforms including the forces and processes that create them.
    /// <see href="https://w3id.org/skgo/modsci#Geomorphology"></see></summary>
    let Geomorphology = _prefix "Geomorphology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#GeophysicalFluidDynamics"></see>
    /// </summary>
    let GeophysicalFluidDynamics = _prefix "GeophysicalFluidDynamics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Geothermics"></see>
    /// </summary>
    let Geothermics = _prefix "Geothermics"
    /// <summary>
    /// Gerontology is the study of the social, cultural, psychological, cognitive, and biological aspects of ageing.
    /// <see href="https://w3id.org/skgo/modsci#Gerontology"></see></summary>
    let Gerontology = _prefix "Gerontology"
    /// <summary>
    /// Glaciology is the scientific study of glaciers, or more generally ice and natural phenomena that involve ice.
    /// <see href="https://w3id.org/skgo/modsci#Glaciology"></see></summary>
    let Glaciology = _prefix "Glaciology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#GlobalInformationSystems"></see>
    /// </summary>
    let GlobalInformationSystems = _prefix "GlobalInformationSystems"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Gravimetrics"></see>
    /// </summary>
    let Gravimetrics = _prefix "Gravimetrics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Gravitometer"></see>
    /// </summary>
    let Gravitometer = _prefix "Gravitometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Gravity"></see>
    /// </summary>
    let Gravity = _prefix "Gravity"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Isaac_Newton"></see>
    /// </summary>
    let Isaac_Newton = _prefix "Isaac_Newton"
    /// <summary>
    /// Green chemistry is the use of chemistry for pollutant source reduction; the definition encompasses therefore all aspects of chemical processes that reduce impact on human health and on the environment.
    /// <see href="https://w3id.org/skgo/modsci#GreenChemistry"></see></summary>
    let GreenChemistry = _prefix "GreenChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Growth"></see>
    /// </summary>
    let Growth = _prefix "Growth"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Guglielmo_Marconi"></see>
    /// </summary>
    let Guglielmo_Marconi = _prefix "Guglielmo_Marconi"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Haze"></see>
    /// </summary>
    let Haze = _prefix "Haze"
    /// <summary>
    /// Health is a state of physical, mental and social well-being in which disease and infirmity are absent.
    /// <see href="https://w3id.org/skgo/modsci#Health"></see></summary>
    let Health = _prefix "Health"
    /// <summary>
    /// Healthcare is the maintenance or improvement of health via the prevention, diagnosis, and treatment of disease, illness, injury, and other physical and mental impairments in people.
    /// <see href="https://w3id.org/skgo/modsci#Healthcare"></see></summary>
    let Healthcare = _prefix "Healthcare"
    /// <summary>
    /// The history of science is the study of the development of science and scientific knowledge, including both the natural and social sciences (the history of the arts and humanities is termed history of scholarship).
    /// <see href="https://w3id.org/skgo/modsci#History"></see></summary>
    let History = _prefix "History"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#HomologicalAlgebra"></see>
    /// </summary>
    let HomologicalAlgebra = _prefix "HomologicalAlgebra"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Horiba"></see>
    /// </summary>
    let Horiba = _prefix "Horiba"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#HorticulturalProduction"></see>
    /// </summary>
    let HorticulturalProduction = _prefix "HorticulturalProduction"
    /// <summary>
    /// Human–computer interaction (HCI) researches the design and use of computer technology, focused on the interfaces between people (users) and computers. Researchers in the field of HCI observe the ways in which humans interact with computers and design technologies that let humans interact with computers in novel ways.
    /// <see href="https://w3id.org/skgo/modsci#HumanComputerInteraction"></see></summary>
    let HumanComputerInteraction = _prefix "HumanComputerInteraction"
    /// <summary>
    /// Software engineering is the application of engineering to the development of software in a systematic method.
    /// <see href="https://w3id.org/skgo/modsci#SoftwareEngineering"></see></summary>
    let SoftwareEngineering = _prefix "SoftwareEngineering"
    /// <summary>
    /// Human science is a term applied to the investigation of human life and activities by a rational, systematic and verifiable methodology that acknowledges the validity of both data derived by impartial observation of sensory experience (objective phenomena) and data derived by means of impartial observation of psychological experience (subjective phenomena).
    /// <see href="https://w3id.org/skgo/modsci#HumanSciences"></see></summary>
    let HumanSciences = _prefix "HumanSciences"
    /// <summary>
    /// Hydrology is the scientific study of the movement, distribution, and quality of water on Earth and other planets, including the water cycle, water resources and environmental watershed sustainability.
    /// <see href="https://w3id.org/skgo/modsci#Hydrology"></see></summary>
    let Hydrology = _prefix "Hydrology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Hydrometer"></see>
    /// </summary>
    let Hydrometer = _prefix "Hydrometer"
    /// <summary>
    /// Immunology is the study of the immune system and its reaction to pathogens, as well as its malfunctions (autoimmune diseases, allergies, rejection of organ transplants, immune deficiency).
    /// <see href="https://w3id.org/skgo/modsci#Immunology"></see></summary>
    let Immunology = _prefix "Immunology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Inclinometer"></see>
    /// </summary>
    let Inclinometer = _prefix "Inclinometer"
    /// <summary>
    /// An industrial process alters materials or substances.
    /// <see href="https://w3id.org/skgo/modsci#IndustrialScience"></see></summary>
    let IndustrialScience = _prefix "IndustrialScience"
    /// <summary>
    /// An industry is a sector that produces goods or related services within an economy.
    /// <see href="https://w3id.org/skgo/modsci#Industry"></see></summary>
    let Industry = _prefix "Industry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationRetrieval"></see>
    /// </summary>
    let InformationRetrieval = _prefix "InformationRetrieval"
    /// <summary>
    /// Information science is a field primarily concerned with the analysis, collection, classification, manipulation, storage, retrieval, movement, dissemination, and protection of information.
    /// <see href="https://w3id.org/skgo/modsci#InformationScience"></see></summary>
    let InformationScience = _prefix "InformationScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationSystemsManagement"></see>
    /// </summary>
    let InformationSystemsManagement = _prefix "InformationSystemsManagement"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InformationSystemsTheory"></see>
    /// </summary>
    let InformationSystemsTheory = _prefix "InformationSystemsTheory"
    /// <summary>
    /// Information visualization or information visualisation is the study of (interactive) visual representations of abstract data to reinforce human cognition.
    /// <see href="https://w3id.org/skgo/modsci#InformationVisualization"></see></summary>
    let InformationVisualization = _prefix "InformationVisualization"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Informetrics"></see>
    /// </summary>
    let Informetrics = _prefix "Informetrics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InorganicGreenChemistry"></see>
    /// </summary>
    let InorganicGreenChemistry = _prefix "InorganicGreenChemistry"
    /// <summary>
    /// A tool or implement, especially one for precision work.
    /// <see href="https://w3id.org/skgo/modsci#Instrument"></see></summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#IntegralEquations"></see>
    /// </summary>
    let IntegralEquations = _prefix "IntegralEquations"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Interferometer"></see>
    /// </summary>
    let Interferometer = _prefix "Interferometer"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#InterorganisationalInformationSystems"></see>
    /// </summary>
    let InterorganisationalInformationSystems =
        _prefix "InterorganisationalInformationSystems"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#KNN_Algorithm"></see>
    /// </summary>
    let KNN_Algorithm = _prefix "KNN_Algorithm"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#KnowledgeSystems"></see>
    /// </summary>
    let KnowledgeSystems = _prefix "KnowledgeSystems"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#LECO_Corporation"></see>
    /// </summary>
    let LECO_Corporation = _prefix "LECO_Corporation"
    /// <summary>
    /// An instrument needed for operations in various laboratories, synthesis and analysis.
    /// <see href="https://w3id.org/skgo/modsci#LaboratoryInstrument"></see></summary>
    let LaboratoryInstrument = _prefix "LaboratoryInstrument"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Lasers"></see>
    /// </summary>
    let Lasers = _prefix "Lasers"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OpticalPhysics"></see>
    /// </summary>
    let OpticalPhysics = _prefix "OpticalPhysics"
    /// <summary>
    /// Library science is an interdisciplinary or multidisciplinary field that applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries; the collection, organization, preservation, and dissemination of information resources; and the political economy of information.
    /// <see href="https://w3id.org/skgo/modsci#LibraryScience"></see></summary>
    let LibraryScience = _prefix "LibraryScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Light_Bulb"></see>
    /// </summary>
    let Light_Bulb = _prefix "Light_Bulb"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Thomas_Edison"></see>
    /// </summary>
    let Thomas_Edison = _prefix "Thomas_Edison"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Light_magnification"></see>
    /// </summary>
    let Light_magnification = _prefix "Light_magnification"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Light_pillar"></see>
    /// </summary>
    let Light_pillar = _prefix "Light_pillar"
    /// <summary>
    /// Limnology is a discipline that concerns the study of fresh waters, specifically natural and constructed lakes, ponds, streams, and rivers,
    /// <see href="https://w3id.org/skgo/modsci#Limnology"></see></summary>
    let Limnology = _prefix "Limnology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Linear_Regression"></see>
    /// </summary>
    let Linear_Regression = _prefix "Linear_Regression"
    /// <summary>
    /// Statistics is the discipline that concerns the collection, organization, displaying, analysis, interpretation and presentation of data.
    /// <see href="https://w3id.org/skgo/modsci#Statistics"></see></summary>
    let Statistics = _prefix "Statistics"
    /// <summary>
    /// Linguistics is the scientific study of language.
    /// <see href="https://w3id.org/skgo/modsci#Linguistics"></see></summary>
    let Linguistics = _prefix "Linguistics"
    /// <summary>
    /// Logic is the study of reasoning, or the study of the principles and criteria of valid inference and demonstration.
    /// <see href="https://w3id.org/skgo/modsci#Logic"></see></summary>
    let Logic = _prefix "Logic"
    /// <summary>
    /// Machine learning (ML) is the scientific study of algorithms and statistical models that computer systems use to perform a specific task without using explicit instructions, relying on patterns and inference instead.
    /// <see href="https://w3id.org/skgo/modsci#MachineLearning"></see></summary>
    let MachineLearning = _prefix "MachineLearning"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Magnetism"></see>
    /// </summary>
    let Magnetism = _prefix "Magnetism"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Magnetograph"></see>
    /// </summary>
    let Magnetograph = _prefix "Magnetograph"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Magnetometer"></see>
    /// </summary>
    let Magnetometer = _prefix "Magnetometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MainGroupMetalChemistry"></see>
    /// </summary>
    let MainGroupMetalChemistry = _prefix "MainGroupMetalChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MalvernInstruments"></see>
    /// </summary>
    let MalvernInstruments = _prefix "MalvernInstruments"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Manometer"></see>
    /// </summary>
    let Manometer = _prefix "Manometer"
    /// <summary>
    /// Marine biology is the scientific study of organisms that live in the ocean
    /// <see href="https://w3id.org/skgo/modsci#MarineBiology"></see></summary>
    let MarineBiology = _prefix "MarineBiology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MarkesInternational"></see>
    /// </summary>
    let MarkesInternational = _prefix "MarkesInternational"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MarkupLanguages"></see>
    /// </summary>
    let MarkupLanguages = _prefix "MarkupLanguages"
    /// <summary>
    /// Mathematical and theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems
    /// <see href="https://w3id.org/skgo/modsci#MathematicalAndTheoreticalBiology"></see></summary>
    let MathematicalAndTheoreticalBiology = _prefix "MathematicalAndTheoreticalBiology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MathematicalLogic"></see>
    /// </summary>
    let MathematicalLogic = _prefix "MathematicalLogic"
    /// <summary>
    /// Mathematical physics refers to the development of mathematical methods for application to problems in physics.
    /// <see href="https://w3id.org/skgo/modsci#MathematicalPhysics"></see></summary>
    let MathematicalPhysics = _prefix "MathematicalPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#McPhersonInc"></see>
    /// </summary>
    let McPhersonInc = _prefix "McPhersonInc"
    /// <summary>
    /// Measurement is the assignment of a number to a characteristic of an object or event, which can be compared with other objects or events.
    /// <see href="https://w3id.org/skgo/modsci#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// Mechanics is the branch of science concerned with the behavior of physical bodies when subjected to forces or displacements, and the subsequent effects of the bodies on their environment.
    /// <see href="https://w3id.org/skgo/modsci#Mechanics"></see></summary>
    let Mechanics = _prefix "Mechanics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MechanismsOfReactions"></see>
    /// </summary>
    let MechanismsOfReactions = _prefix "MechanismsOfReactions"
    /// <summary>
    /// Medicinal chemistry and pharmaceutical chemistry are disciplines at the intersection of chemistry, especially synthetic organic chemistry, and pharmacology and various other biological specialties, where they are involved with design, chemical synthesis and development for market of pharmaceutical agents, or bio-active molecules (drugs).
    /// <see href="https://w3id.org/skgo/modsci#MedicinalChemistry"></see></summary>
    let MedicinalChemistry = _prefix "MedicinalChemistry"
    /// <summary>
    /// Medicine is a branch of health science concerned with maintaining human health and restoring it by treating disease and injury; it is both an area of knowledge, a science of body systems and diseases and their treatment, and the applied practice of that knowledge.
    /// <see href="https://w3id.org/skgo/modsci#Medicine"></see></summary>
    let Medicine = _prefix "Medicine"
    /// <summary>
    /// Metabolism is the set of life-sustaining chemical reactions in organisms.
    /// <see href="https://w3id.org/skgo/modsci#Metabolism"></see></summary>
    let Metabolism = _prefix "Metabolism"
    /// <summary>
    /// Metallurgy is a domain of materials science and engineering that studies the physical and chemical behavior of metallic elements, their inter-metallic compounds, and their mixtures, which are called alloys.
    /// <see href="https://w3id.org/skgo/modsci#Metallurgy"></see></summary>
    let Metallurgy = _prefix "Metallurgy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MetamorphicPetrology"></see>
    /// </summary>
    let MetamorphicPetrology = _prefix "MetamorphicPetrology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MeteorologicalPhenomena"></see>
    /// </summary>
    let MeteorologicalPhenomena = _prefix "MeteorologicalPhenomena"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MetrologicalChemistry"></see>
    /// </summary>
    let MetrologicalChemistry = _prefix "MetrologicalChemistry"
    /// <summary>
    /// Metrology is the science of measurement.
    /// <see href="https://w3id.org/skgo/modsci#Metrology"></see></summary>
    let Metrology = _prefix "Metrology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Micrometer"></see>
    /// </summary>
    let Micrometer = _prefix "Micrometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Microscope"></see>
    /// </summary>
    let Microscope = _prefix "Microscope"
    /// <summary>
    /// Military science is the study of military processes, dentsciitutions, and behavior, along with the study of warfare, and the theory and application of organized coercive force.
    /// <see href="https://w3id.org/skgo/modsci#MilitaryScience"></see></summary>
    let MilitaryScience = _prefix "MilitaryScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Mineralogy"></see>
    /// </summary>
    let Mineralogy = _prefix "Mineralogy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MobileTechnologies"></see>
    /// </summary>
    let MobileTechnologies = _prefix "MobileTechnologies"
    /// <summary>
    /// Molecular biology is the study of biology at a molecular level.
    /// <see href="https://w3id.org/skgo/modsci#MolecularBiology"></see></summary>
    let MolecularBiology = _prefix "MolecularBiology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Movie_camera"></see>
    /// </summary>
    let Movie_camera = _prefix "Movie_camera"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#MultimediaProgramming"></see>
    /// </summary>
    let MultimediaProgramming = _prefix "MultimediaProgramming"
    /// <summary>
    /// Museology or museum studies is the study of museums. It explores the history of museums and their role in society, as well as the activities they engage in, including curating, preservation, public programming, and education.
    /// <see href="https://w3id.org/skgo/modsci#Museology"></see></summary>
    let Museology = _prefix "Museology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NASA"></see>
    /// </summary>
    let NASA = _prefix "NASA"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Nanochemistry"></see>
    /// </summary>
    let Nanochemistry = _prefix "Nanochemistry"
    /// <summary>
    /// Natural language processing (NLP) is a subfield of linguistics, computer science, information engineering, and artificial intelligence concerned with the interactions between computers and human (natural) languages, in particular how to program computers to process and analyze large amounts of natural language data.
    /// <see href="https://w3id.org/skgo/modsci#NaturalLanguageProcessing"></see></summary>
    let NaturalLanguageProcessing = _prefix "NaturalLanguageProcessing"
    /// <summary>
    /// Social phenomena are those that occur or exist through the actions of groups of humans.
    /// <see href="https://w3id.org/skgo/modsci#SocialPhenomenon"></see></summary>
    let SocialPhenomenon = _prefix "SocialPhenomenon"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NaturalProductsChemistry"></see>
    /// </summary>
    let NaturalProductsChemistry = _prefix "NaturalProductsChemistry"
    /// <summary>
    /// A computer network is a digital telecommunications network which allows nodes to share resources.
    /// <see href="https://w3id.org/skgo/modsci#Networking"></see></summary>
    let Networking = _prefix "Networking"
    /// <summary>
    /// Neural engineering is a discipline within biomedical engineering that uses engineering techniques to understand, repair, replace, or enhance neural systems.
    /// <see href="https://w3id.org/skgo/modsci#NeuralEngineering"></see></summary>
    let NeuralEngineering = _prefix "NeuralEngineering"
    /// <summary>
    /// Neuroscience is a field of study which deals with the structure, development, genetics, biochemistry, physiology, pharmacology and pathology of the nervous system.
    /// <see href="https://w3id.org/skgo/modsci#Neuroscience"></see></summary>
    let Neuroscience = _prefix "Neuroscience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Non-equilibriumProcesses"></see>
    /// </summary>
    let ``Non-equilibriumProcesses`` = _prefix "Non-equilibriumProcesses"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Non-metalChemistry"></see>
    /// </summary>
    let ``Non-metalChemistry`` = _prefix "Non-metalChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NonlinearOptics"></see>
    /// </summary>
    let NonlinearOptics = _prefix "NonlinearOptics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NovacamTechnologies"></see>
    /// </summary>
    let NovacamTechnologies = _prefix "NovacamTechnologies"
    /// <summary>
    /// Nuclear chemistry is the subfield of chemistry dealing with radioactivity, nuclear processes, and transformations in the nuclei of atoms, such as nuclear transmutation and nuclear properties.
    /// <see href="https://w3id.org/skgo/modsci#NuclearChemistry"></see></summary>
    let NuclearChemistry = _prefix "NuclearChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NuclearPhysics"></see>
    /// </summary>
    let NuclearPhysics = _prefix "NuclearPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NumberTheory"></see>
    /// </summary>
    let NumberTheory = _prefix "NumberTheory"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#NumericalAnalysis"></see>
    /// </summary>
    let NumericalAnalysis = _prefix "NumericalAnalysis"
    /// <summary>
    /// Nursing is a profession within the health care sector focused on the care of individuals, families, and communities so they may attain, maintain, or recover optimal health and quality of life.
    /// <see href="https://w3id.org/skgo/modsci#Nursing"></see></summary>
    let Nursing = _prefix "Nursing"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ocean_currents"></see>
    /// </summary>
    let Ocean_currents = _prefix "Ocean_currents"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Ohmmeter"></see>
    /// </summary>
    let Ohmmeter = _prefix "Ohmmeter"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Olaus_Roemer"></see>
    /// </summary>
    let Olaus_Roemer = _prefix "Olaus_Roemer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OpenAI_Inc"></see>
    /// </summary>
    let OpenAI_Inc = _prefix "OpenAI_Inc"
    /// <summary>
    /// An operating system (OS) is system software that manages computer hardware, software resources, and provides common services for computer programs.
    /// <see href="https://w3id.org/skgo/modsci#OperatingSystems"></see></summary>
    let OperatingSystems = _prefix "OperatingSystems"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OperationsResearch"></see>
    /// </summary>
    let OperationsResearch = _prefix "OperationsResearch"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OpticalCommunications"></see>
    /// </summary>
    let OpticalCommunications = _prefix "OpticalCommunications"
    /// <summary>
    /// Optics is the branch of physics that studies the behaviour and properties of light, including its interactions with matter and the construction of instruments that use or detect it.
    /// <see href="https://w3id.org/skgo/modsci#Optics"></see></summary>
    let Optics = _prefix "Optics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Optimisation"></see>
    /// </summary>
    let Optimisation = _prefix "Optimisation"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Optoelectronics"></see>
    /// </summary>
    let Optoelectronics = _prefix "Optoelectronics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OrdinaryDifferentialEquations"></see>
    /// </summary>
    let OrdinaryDifferentialEquations = _prefix "OrdinaryDifferentialEquations"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OreDepositPetrology"></see>
    /// </summary>
    let OreDepositPetrology = _prefix "OreDepositPetrology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OrganicChemicalSynthesis"></see>
    /// </summary>
    let OrganicChemicalSynthesis = _prefix "OrganicChemicalSynthesis"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OrganicGreenChemistry"></see>
    /// </summary>
    let OrganicGreenChemistry = _prefix "OrganicGreenChemistry"
    /// <summary>
    /// Organometallic chemistry is the study of chemical compounds containing bonds between carbon and a metal.
    /// <see href="https://w3id.org/skgo/modsci#OrganometallicChemistry"></see></summary>
    let OrganometallicChemistry = _prefix "OrganometallicChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Oscilloscope"></see>
    /// </summary>
    let Oscilloscope = _prefix "Oscilloscope"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Overpopulation"></see>
    /// </summary>
    let Overpopulation = _prefix "Overpopulation"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#OxfordInstruments"></see>
    /// </summary>
    let OxfordInstruments = _prefix "OxfordInstruments"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Palaeomagnetism"></see>
    /// </summary>
    let Palaeomagnetism = _prefix "Palaeomagnetism"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Palaeontology"></see>
    /// </summary>
    let Palaeontology = _prefix "Palaeontology"
    /// <summary>
    /// Paleoclimatology is the study of climates for which systematic measurements were not taken.
    /// <see href="https://w3id.org/skgo/modsci#Paleoclimatology"></see></summary>
    let Paleoclimatology = _prefix "Paleoclimatology"
    /// <summary>
    /// Paleontology is the study of the developing history of life on earth, of ancient plants and animals based on the fossil record, evidence of their existence preserved in rocks.
    /// <see href="https://w3id.org/skgo/modsci#Paleontology"></see></summary>
    let Paleontology = _prefix "Paleontology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PallCorp"></see>
    /// </summary>
    let PallCorp = _prefix "PallCorp"
    /// <summary>
    /// Palynology is literally the "study of dust" or of "particles that are strewn".
    /// <see href="https://w3id.org/skgo/modsci#Palynology"></see></summary>
    let Palynology = _prefix "Palynology"
    /// <summary>
    /// Parallel computing is a type of computation in which many calculations or the execution of processes are carried out simultaneously.
    /// <see href="https://w3id.org/skgo/modsci#ParallelComputing"></see></summary>
    let ParallelComputing = _prefix "ParallelComputing"
    /// <summary>
    /// Parasitology is the study of parasites in host organisms, including humans (medical parasitology).
    /// <see href="https://w3id.org/skgo/modsci#Parasitology"></see></summary>
    let Parasitology = _prefix "Parasitology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PartialDifferentialEquations"></see>
    /// </summary>
    let PartialDifferentialEquations = _prefix "PartialDifferentialEquations"
    /// <summary>
    /// Particle physics is a branch of physics that studies the elementary constituents of matter and radiation, and the interactions between them.
    /// <see href="https://w3id.org/skgo/modsci#ParticlePhysics"></see></summary>
    let ParticlePhysics = _prefix "ParticlePhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PastureProduction"></see>
    /// </summary>
    let PastureProduction = _prefix "PastureProduction"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PatternRecognition"></see>
    /// </summary>
    let PatternRecognition = _prefix "PatternRecognition"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PetroleumGeology"></see>
    /// </summary>
    let PetroleumGeology = _prefix "PetroleumGeology"
    /// <summary>
    /// Pharmacology is the study of how chemical substances interact with living systems.
    /// <see href="https://w3id.org/skgo/modsci#Pharmacology"></see></summary>
    let Pharmacology = _prefix "Pharmacology"
    /// <summary>
    /// Pharmacy is the science and technique of preparing, dispensing, and reviewing drugs and providing additional clinical services.
    /// <see href="https://w3id.org/skgo/modsci#Pharmacy"></see></summary>
    let Pharmacy = _prefix "Pharmacy"
    /// <summary>
    /// Philosophy of science is a branch of philosophy concerned with the foundations, methods, and implications of science.
    /// <see href="https://w3id.org/skgo/modsci#Philosophy"></see></summary>
    let Philosophy = _prefix "Philosophy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Phonograph"></see>
    /// </summary>
    let Phonograph = _prefix "Phonograph"
    /// <summary>
    /// Photochemistry, a sub-discipline of chemistry, is the study of the interactions between atoms, small molecules, and light (or electromagnetic radiation).
    /// <see href="https://w3id.org/skgo/modsci#Photochemistry"></see></summary>
    let Photochemistry = _prefix "Photochemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Photonics"></see>
    /// </summary>
    let Photonics = _prefix "Photonics"
    /// <summary>
    /// Phylogenetics is the study of the evolutionary history and relationships among individuals or groups of organisms.
    /// <see href="https://w3id.org/skgo/modsci#Phylogeny"></see></summary>
    let Phylogeny = _prefix "Phylogeny"
    /// <summary>
    /// Physical geography is a subfield of geography, closely related to geology, that focuses on the spatial characteristics of natural processes, within the hydrosphere, biosphere, atmosphere and lithosphere.
    /// <see href="https://w3id.org/skgo/modsci#PhysicalGeography"></see></summary>
    let PhysicalGeography = _prefix "PhysicalGeography"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PhysicalOceanography"></see>
    /// </summary>
    let PhysicalOceanography = _prefix "PhysicalOceanography"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PhysicalOrganicChemistry"></see>
    /// </summary>
    let PhysicalOrganicChemistry = _prefix "PhysicalOrganicChemistry"
    /// <summary>
    /// Physiology is the branch of science that describes the mechanisms of cell, tissue and organ function in organisms.
    /// <see href="https://w3id.org/skgo/modsci#Physiology"></see></summary>
    let Physiology = _prefix "Physiology"
    /// <summary>
    /// Planetary science is a broad field of science that studies all planets.
    /// <see href="https://w3id.org/skgo/modsci#PlanetaryScience"></see></summary>
    let PlanetaryScience = _prefix "PlanetaryScience"
    /// <summary>
    /// Plasma physics is the study of ionized gases.
    /// <see href="https://w3id.org/skgo/modsci#PlasmaPhysics"></see></summary>
    let PlasmaPhysics = _prefix "PlasmaPhysics"
    /// <summary>
    /// Political economy is the study of production and trade and their relations with law, custom and government; and with the distribution of national income and wealth.
    /// <see href="https://w3id.org/skgo/modsci#PoliticalEconomy"></see></summary>
    let PoliticalEconomy = _prefix "PoliticalEconomy"
    /// <summary>
    /// Political science is a social science which deals with systems of governance, and the analysis of political activities, political thoughts, and political behavior.
    /// <see href="https://w3id.org/skgo/modsci#PoliticalScience"></see></summary>
    let PoliticalScience = _prefix "PoliticalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PolymerChar"></see>
    /// </summary>
    let PolymerChar = _prefix "PolymerChar"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PolymerisationMechanisms"></see>
    /// </summary>
    let PolymerisationMechanisms = _prefix "PolymerisationMechanisms"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Population_decrease"></see>
    /// </summary>
    let Population_decrease = _prefix "Population_decrease"
    /// <summary>
    /// A programming language is a formal language, which comprises a set of instructions that produce various kinds of output. Programming languages are used in computer programming to implement algorithms.
    /// <see href="https://w3id.org/skgo/modsci#ProgrammingLanguage"></see></summary>
    let ProgrammingLanguage = _prefix "ProgrammingLanguage"
    /// <summary>
    /// Programming language theory (PLT) is a branch of computer science that deals with the design, implementation, analysis, characterization, and classification of programming languages and their individual features.
    /// <see href="https://w3id.org/skgo/modsci#ProgrammingLanguageTheory"></see></summary>
    let ProgrammingLanguageTheory = _prefix "ProgrammingLanguageTheory"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#PsychiatricDrugs"></see>
    /// </summary>
    let PsychiatricDrugs = _prefix "PsychiatricDrugs"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Psychological_Studies"></see>
    /// </summary>
    let Psychological_Studies = _prefix "Psychological_Studies"
    /// <summary>
    /// Psychology is a collection of academic, clinical and industrial disciplines concerned with the explanation and prediction of behavior, thinking, emotions, motivations, relationships, potentials and pathologies.
    /// <see href="https://w3id.org/skgo/modsci#Psychology"></see></summary>
    let Psychology = _prefix "Psychology"
    /// <summary>
    /// Quantum computing is the use of quantum-mechanical phenomena such as superposition and entanglement to perform computation. A quantum computer is used to perform such computation, which can be implemented theoretically or physically.
    /// <see href="https://w3id.org/skgo/modsci#QuantumComputing"></see></summary>
    let QuantumComputing = _prefix "QuantumComputing"
    /// <summary>
    /// Quantum mechanics (also called quantum physics or quantum theory) is a physical theory that is believed to be the formalism underlying the description of all physical systems.
    /// <see href="https://w3id.org/skgo/modsci#QuantumMechanics"></see></summary>
    let QuantumMechanics = _prefix "QuantumMechanics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#QuantumOptics"></see>
    /// </summary>
    let QuantumOptics = _prefix "QuantumOptics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#QuantumPhysics"></see>
    /// </summary>
    let QuantumPhysics = _prefix "QuantumPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Racism"></see>
    /// </summary>
    let Racism = _prefix "Racism"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Radio_Signals"></see>
    /// </summary>
    let Radio_Signals = _prefix "Radio_Signals"
    /// <summary>
    /// Radiobiology is a field of clinical and basic medical sciences that involves the study of the action of ionizing radiation on living things, especially health effects of radiation.
    /// <see href="https://w3id.org/skgo/modsci#Radiobiology"></see></summary>
    let Radiobiology = _prefix "Radiobiology"
    /// <summary>
    /// Radiochemistry is the chemistry of radioactive materials, where radioactive isotopes of elements are used to study the properties and chemical reactions of non-radioactive isotopes (often within radiochemistry the absence of radioactivity leads to a substance being described as being inactive as the isotopes are stable).
    /// <see href="https://w3id.org/skgo/modsci#Radiochemistry"></see></summary>
    let Radiochemistry = _prefix "Radiochemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Radiometrics"></see>
    /// </summary>
    let Radiometrics = _prefix "Radiometrics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Rainbow"></see>
    /// </summary>
    let Rainbow = _prefix "Rainbow"
    /// <summary>
    /// A relational database is a digital database based on the relational model of data, as proposed by E. F. Codd in 1970.
    /// <see href="https://w3id.org/skgo/modsci#RelationalDatabases"></see></summary>
    let RelationalDatabases = _prefix "RelationalDatabases"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Resampling_Methods"></see>
    /// </summary>
    let Resampling_Methods = _prefix "Resampling_Methods"
    /// <summary>
    /// Reverse engineering, also called back engineering, is the process by which a man-made object is deconstructed to reveal its designs, architecture, or to extract knowledge from the object; similar to scientific research, the only difference being that scientific research is about a natural phenomenon.
    /// <see href="https://w3id.org/skgo/modsci#ReverseEngineering"></see></summary>
    let ReverseEngineering = _prefix "ReverseEngineering"
    /// <summary>
    /// Robotics is an interdisciplinary branch of engineering and science that includes mechanical engineering, electronic engineering, information engineering, computer science, and others. Robotics deals with the design, construction, operation, and use of robots, as well as computer systems for their control, sensory feedback, and information processing.
    /// <see href="https://w3id.org/skgo/modsci#Robotics"></see></summary>
    let Robotics = _prefix "Robotics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Rusting"></see>
    /// </summary>
    let Rusting = _prefix "Rusting"
    /// <summary>
    /// Science and technology studies is the study of how society, politics, and culture affect scientific research and technological innovation, and how these, in turn, affect society, politics and culture.
    /// <see href="https://w3id.org/skgo/modsci#ScienceAndTechnologyStudies"></see></summary>
    let ScienceAndTechnologyStudies = _prefix "ScienceAndTechnologyStudies"
    /// <summary>
    /// Science studies is an interdisciplinary research area that seeks to situate scientific expertise in broad social, historical, and philosophical contexts.
    /// <see href="https://w3id.org/skgo/modsci#ScienceStudies"></see></summary>
    let ScienceStudies = _prefix "ScienceStudies"
    /// <summary>
    /// Scientific modelling is a scientific activity, the aim of which is to make a particular part or feature of the world easier to understand, define, quantify, visualize, or simulate by referencing it to existing and usually commonly accepted knowledge.
    /// <see href="https://w3id.org/skgo/modsci#ScientificModeling"></see></summary>
    let ScientificModeling = _prefix "ScientificModeling"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Sedimentology"></see>
    /// </summary>
    let Sedimentology = _prefix "Sedimentology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SeismicExploration"></see>
    /// </summary>
    let SeismicExploration = _prefix "SeismicExploration"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Seismology"></see>
    /// </summary>
    let Seismology = _prefix "Seismology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Seismometer"></see>
    /// </summary>
    let Seismometer = _prefix "Seismometer"
    /// <summary>
    /// In programming language theory, semantics is the field concerned with the rigorous mathematical study of the meaning of programming languages. It does so by evaluating the meaning of syntactically valid strings defined by a specific programming language, showing the computation involved.
    /// <see href="https://w3id.org/skgo/modsci#Semantics"></see></summary>
    let Semantics = _prefix "Semantics"
    /// <summary>
    /// Semiotics is the study of signs (symbols) and signification systems, or rather semiotics are general theories of signs.
    /// <see href="https://w3id.org/skgo/modsci#Semiotics"></see></summary>
    let Semiotics = _prefix "Semiotics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SeparationScience"></see>
    /// </summary>
    let SeparationScience = _prefix "SeparationScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#ShimadzuCorp"></see>
    /// </summary>
    let ShimadzuCorp = _prefix "ShimadzuCorp"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Shrinkage"></see>
    /// </summary>
    let Shrinkage = _prefix "Shrinkage"
    /// <summary>
    /// Social psychology is the scientific study of how people's thoughts, feelings, and behaviors are influenced by the actual, imagined or implied presence of others.
    /// <see href="https://w3id.org/skgo/modsci#SocialPsychology"></see></summary>
    let SocialPsychology = _prefix "SocialPsychology"
    /// <summary>
    /// Social work is an academic discipline and profession that concerns itself with individuals, families, groups and communities in an effort to enhance social functioning and overall well-being.
    /// <see href="https://w3id.org/skgo/modsci#SocialWork"></see></summary>
    let SocialWork = _prefix "SocialWork"
    /// <summary>
    /// Sociobiology is a field of biology that aims to examine and explain social behavior in terms of evolution.
    /// <see href="https://w3id.org/skgo/modsci#Sociobiology"></see></summary>
    let Sociobiology = _prefix "Sociobiology"
    /// <summary>
    /// Sociology is the study of social behaviour or society, including its origins, development, organization, networks, and institutions. and critical analysis to develop a body of knowledge about social order, disorder, and change.
    /// <see href="https://w3id.org/skgo/modsci#Sociology"></see></summary>
    let Sociology = _prefix "Sociology"
    /// <summary>
    /// Soil biology is the study of microbial and faunal activity and ecology in soil.
    /// <see href="https://w3id.org/skgo/modsci#SoilBiology"></see></summary>
    let SoilBiology = _prefix "SoilBiology"
    /// <summary>
    /// Soil science is the study of soil as a natural resource on the surface of the Earth including soil formation, classification and mapping; physical, chemical, biological, and fertility properties of soils; and these properties in relation to the use and management of soils.
    /// <see href="https://w3id.org/skgo/modsci#SoilScience"></see></summary>
    let SoilScience = _prefix "SoilScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SoilSciences"></see>
    /// </summary>
    let SoilSciences = _prefix "SoilSciences"
    /// <summary>
    /// Solid mechanics is a mathematical discipline within continuum mechanics, dealing with the mechanical behavior of solid materials.
    /// <see href="https://w3id.org/skgo/modsci#SolidMechanics"></see></summary>
    let SolidMechanics = _prefix "SolidMechanics"
    /// <summary>
    /// Solid-state chemistry, also sometimes referred as materials chemistry, is the study of the synthesis, structure, and properties of solid phase materials, particularly, but not necessarily exclusively of, non-molecular solids.
    /// <see href="https://w3id.org/skgo/modsci#SolidStateChemistry"></see></summary>
    let SolidStateChemistry = _prefix "SolidStateChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SolutionChemistry"></see>
    /// </summary>
    let SolutionChemistry = _prefix "SolutionChemistry"
    /// <summary>
    /// Space science encompasses all of the scientific disciplines that involve space exploration and study natural phenomena and physical bodies occurring in outer space, such as space medicine and astrobiology.
    /// <see href="https://w3id.org/skgo/modsci#SpaceScience"></see></summary>
    let SpaceScience = _prefix "SpaceScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Spectrogram"></see>
    /// </summary>
    let Spectrogram = _prefix "Spectrogram"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Spectrometer"></see>
    /// </summary>
    let Spectrometer = _prefix "Spectrometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Spectroscopy"></see>
    /// </summary>
    let Spectroscopy = _prefix "Spectroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Speed_of_light"></see>
    /// </summary>
    let Speed_of_light = _prefix "Speed_of_light"
    /// <summary>
    /// Sports science is a discipline that studies how the healthy human body works during exercise, and how sport and physical activity promote health and performance from cellular to whole body perspectives.
    /// <see href="https://w3id.org/skgo/modsci#SportsScience"></see></summary>
    let SportsScience = _prefix "SportsScience"
    /// <summary>
    /// The study of stars and stellar evolution is fundamental to our understanding of the Universe.
    /// <see href="https://w3id.org/skgo/modsci#StellarAstronomy"></see></summary>
    let StellarAstronomy = _prefix "StellarAstronomy"
    /// <summary>
    /// Stereochemistry, a subdiscipline of chemistry, involves the study of the relative spatial arrangement of atoms that form the structure of molecules and their manipulation.
    /// <see href="https://w3id.org/skgo/modsci#Stereochemistry"></see></summary>
    let Stereochemistry = _prefix "Stereochemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Storm"></see>
    /// </summary>
    let Storm = _prefix "Storm"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Stratigraphy"></see>
    /// </summary>
    let Stratigraphy = _prefix "Stratigraphy"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#StructuralChemistry"></see>
    /// </summary>
    let StructuralChemistry = _prefix "StructuralChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#StructuralGeology"></see>
    /// </summary>
    let StructuralGeology = _prefix "StructuralGeology"
    /// <summary>
    /// Structured storage is computer storage for structured data, often in the form of a distributed database.
    /// <see href="https://w3id.org/skgo/modsci#StructuredStorage"></see></summary>
    let StructuredStorage = _prefix "StructuredStorage"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Subset_Selection"></see>
    /// </summary>
    let Subset_Selection = _prefix "Subset_Selection"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Subsun"></see>
    /// </summary>
    let Subsun = _prefix "Subsun"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Supernova"></see>
    /// </summary>
    let Supernova = _prefix "Supernova"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Support_Vector_Machines"></see>
    /// </summary>
    let Support_Vector_Machines = _prefix "Support_Vector_Machines"
    /// <summary>
    /// Supramolecular chemistry is a branch of chemistry that describes self-organization or self-assembly of systems to well-defined molecular architectures.
    /// <see href="https://w3id.org/skgo/modsci#SupramolecularChemistry"></see></summary>
    let SupramolecularChemistry = _prefix "SupramolecularChemistry"
    /// <summary>
    /// Surface chemistry is the study of chemical phenomena that occur at the interface of two phases
    /// <see href="https://w3id.org/skgo/modsci#SurfaceChemistry"></see></summary>
    let SurfaceChemistry = _prefix "SurfaceChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#SynthesisOfMaterials"></see>
    /// </summary>
    let SynthesisOfMaterials = _prefix "SynthesisOfMaterials"
    /// <summary>
    /// Systems science is the field of science surrounding systems theory, cybernetics, the science of complex systems.
    /// <see href="https://w3id.org/skgo/modsci#SystemsScience"></see></summary>
    let SystemsScience = _prefix "SystemsScience"
    /// <summary>
    /// Technology is the collection of techniques, skills, methods, and processes used in the production of goods or services or in the accomplishment of objectives, such as scientific investigation.
    /// <see href="https://w3id.org/skgo/modsci#Technology"></see></summary>
    let Technology = _prefix "Technology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Techtron"></see>
    /// </summary>
    let Techtron = _prefix "Techtron"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Tectonics"></see>
    /// </summary>
    let Tectonics = _prefix "Tectonics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Telescope"></see>
    /// </summary>
    let Telescope = _prefix "Telescope"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#instrumentUsedInScience"></see>
    /// </summary>
    let instrumentUsedInScience = _prefix "instrumentUsedInScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#The_Bridges_Organization"></see>
    /// </summary>
    let The_Bridges_Organization = _prefix "The_Bridges_Organization"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#The_Fibonacci_Association"></see>
    /// </summary>
    let The_Fibonacci_Association = _prefix "The_Fibonacci_Association"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Theodolite"></see>
    /// </summary>
    let Theodolite = _prefix "Theodolite"
    /// <summary>
    /// Theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems
    /// <see href="https://w3id.org/skgo/modsci#TheoreticalBiology"></see></summary>
    let TheoreticalBiology = _prefix "TheoreticalBiology"
    /// <summary>
    /// Theoretical chemistry is the application of theoretical reasoning to chemistry.
    /// <see href="https://w3id.org/skgo/modsci#TheoreticalChemistry"></see></summary>
    let TheoreticalChemistry = _prefix "TheoreticalChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#TheoreticalComputerScience"></see>
    /// </summary>
    let TheoreticalComputerScience = _prefix "TheoreticalComputerScience"
    /// <summary>
    /// Theoretical linguistics, or general linguistics, is the branch of linguistics which inquires into the nature of language itself and seeks to answer fundamental questions as to what language is; how it works; how universal grammar (UG) as a domain-specific mental organ operates, if it exists at all; what are its unique properties; how does language relate to other cognitive processes, etc.
    /// <see href="https://w3id.org/skgo/modsci#TheoreticalLinguistics"></see></summary>
    let TheoreticalLinguistics = _prefix "TheoreticalLinguistics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#TheoryAndDesignOfMaterials"></see>
    /// </summary>
    let TheoryAndDesignOfMaterials = _prefix "TheoryAndDesignOfMaterials"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Thermocouple"></see>
    /// </summary>
    let Thermocouple = _prefix "Thermocouple"
    /// <summary>
    /// Thermodynamics concerns the physics of heat, work, temperature, energy, and entropy.
    /// <see href="https://w3id.org/skgo/modsci#Thermodynamics"></see></summary>
    let Thermodynamics = _prefix "Thermodynamics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Thermometer"></see>
    /// </summary>
    let Thermometer = _prefix "Thermometer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Time_Series_Analysis"></see>
    /// </summary>
    let Time_Series_Analysis = _prefix "Time_Series_Analysis"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Topology"></see>
    /// </summary>
    let Topology = _prefix "Topology"
    /// <summary>
    /// Toxicology is a scientific discipline, overlapping with biology, chemistry, pharmacology, and medicine, that involves the study of the adverse effects of chemical substances on living organisms and the practice of diagnosing and treating exposures to toxins and toxicants.
    /// <see href="https://w3id.org/skgo/modsci#Toxicology"></see></summary>
    let Toxicology = _prefix "Toxicology"
    /// <summary>
    /// Transdisciplinarity connotes a research strategy that crosses many disciplinary boundaries to create a holistic approach.
    /// <see href="https://w3id.org/skgo/modsci#Transdisciplinarity"></see></summary>
    let Transdisciplinarity = _prefix "Transdisciplinarity"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#TransitionMetalChemistry"></see>
    /// </summary>
    let TransitionMetalChemistry = _prefix "TransitionMetalChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Tsunamis"></see>
    /// </summary>
    let Tsunamis = _prefix "Tsunamis"
    /// <summary>
    /// In mathematics, logic, and computer science, a type theory is any of a class of formal systems, some of which can serve as alternatives to set theory as a foundation for all mathematics. In type theory, every "term" has a "type" and operations are restricted to terms of a certain type.
    /// <see href="https://w3id.org/skgo/modsci#TypeTheory"></see></summary>
    let TypeTheory = _prefix "TypeTheory"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#UbiquitousComputing"></see>
    /// </summary>
    let UbiquitousComputing = _prefix "UbiquitousComputing"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#UniversalAlgebra"></see>
    /// </summary>
    let UniversalAlgebra = _prefix "UniversalAlgebra"
    /// <summary>
    /// Urban planning is a technical and political process concerned with the development and design of land use and the built environment, including air, water, and the infrastructure passing into and out of urban areas, such as transportation, communications, and distribution networks.
    /// <see href="https://w3id.org/skgo/modsci#UrbanPlanning"></see></summary>
    let UrbanPlanning = _prefix "UrbanPlanning"
    /// <summary>
    /// Veterinary medicine is the branch of medicine that deals with the prevention, diagnosis and treatment of disease, disorder and injury in animals.
    /// <see href="https://w3id.org/skgo/modsci#VeterinaryMedicine"></see></summary>
    let VeterinaryMedicine = _prefix "VeterinaryMedicine"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#VeterinarySciences"></see>
    /// </summary>
    let VeterinarySciences = _prefix "VeterinarySciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#VirtualReality"></see>
    /// </summary>
    let VirtualReality = _prefix "VirtualReality"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Volcano"></see>
    /// </summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    /// Volcanology is a branch of geology that deals with the study of volcanoes, lava, magma, and related geological phenomena.
    /// <see href="https://w3id.org/skgo/modsci#Volcanology"></see></summary>
    let Volcanology = _prefix "Volcanology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Voltmeter"></see>
    /// </summary>
    let Voltmeter = _prefix "Voltmeter"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WatersCorporation"></see>
    /// </summary>
    let WatersCorporation = _prefix "WatersCorporation"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Waves"></see>
    /// </summary>
    let Waves = _prefix "Waves"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WebSearch"></see>
    /// </summary>
    let WebSearch = _prefix "WebSearch"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WebServices"></see>
    /// </summary>
    let WebServices = _prefix "WebServices"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#WebTechnologies"></see>
    /// </summary>
    let WebTechnologies = _prefix "WebTechnologies"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#Weddings"></see>
    /// </summary>
    let Weddings = _prefix "Weddings"
    /// <summary>
    /// Zoology is the study of the biology of animals.
    /// <see href="https://w3id.org/skgo/modsci#Zoology"></see></summary>
    let Zoology = _prefix "Zoology"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromMathematics"></see>
    /// </summary>
    let appliesLawsFromMathematics = _prefix "appliesLawsFromMathematics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromPhysics"></see>
    /// </summary>
    let appliesLawsFromPhysics = _prefix "appliesLawsFromPhysics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromStatistics"></see>
    /// </summary>
    let appliesLawsFromStatistics = _prefix "appliesLawsFromStatistics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#appliesLawsFromThermodynamics"></see>
    /// </summary>
    let appliesLawsFromThermodynamics = _prefix "appliesLawsFromThermodynamics"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByAppliedSciences"></see>
    /// </summary>
    let discoveredByAppliedSciences = _prefix "discoveredByAppliedSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByBehaviouralSciences"></see>
    /// </summary>
    let discoveredByBehaviouralSciences = _prefix "discoveredByBehaviouralSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByFormalScience"></see>
    /// </summary>
    let discoveredByFormalScience = _prefix "discoveredByFormalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByHealthSciences"></see>
    /// </summary>
    let discoveredByHealthSciences = _prefix "discoveredByHealthSciences"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByInterdisciplinaryStudies"></see>
    /// </summary>
    let discoveredByInterdisciplinaryStudies =
        _prefix "discoveredByInterdisciplinaryStudies"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByMachine"></see>
    /// </summary>
    let discoveredByMachine = _prefix "discoveredByMachine"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredByNaturalScience"></see>
    /// </summary>
    let discoveredByNaturalScience = _prefix "discoveredByNaturalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#discoveredBySocialSciences"></see>
    /// </summary>
    let discoveredBySocialSciences = _prefix "discoveredBySocialSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#f-BlockChemistry"></see>
    /// </summary>
    let ``f-BlockChemistry`` = _prefix "f-BlockChemistry"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#followsMethod"></see>
    /// </summary>
    let followsMethod = _prefix "followsMethod"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasApplication"></see>
    /// </summary>
    let hasApplication = _prefix "hasApplication"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasCollaborationWith"></see>
    /// </summary>
    let hasCollaborationWith = _prefix "hasCollaborationWith"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasManufacturer"></see>
    /// </summary>
    let hasManufacturer = _prefix "hasManufacturer"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isManufacturerOf"></see>
    /// </summary>
    let isManufacturerOf = _prefix "isManufacturerOf"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasMethodsInspiredFrom"></see>
    /// </summary>
    let hasMethodsInspiredFrom = _prefix "hasMethodsInspiredFrom"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#hasScientificInstrumentManufacturer"></see>
    /// </summary>
    let hasScientificInstrumentManufacturer =
        _prefix "hasScientificInstrumentManufacturer"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#inspiredFromPhenomenon"></see>
    /// </summary>
    let inspiredFromPhenomenon = _prefix "inspiredFromPhenomenon"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#inspiredFromScientificDiscovery"></see>
    /// </summary>
    let inspiredFromScientificDiscovery = _prefix "inspiredFromScientificDiscovery"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#interestedInPhenomenon"></see>
    /// </summary>
    let interestedInPhenomenon = _prefix "interestedInPhenomenon"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfAppliedScience"></see>
    /// </summary>
    let isApplicationOfAppliedScience = _prefix "isApplicationOfAppliedScience"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfBehaviouralSciences"></see>
    /// </summary>
    let isApplicationOfBehaviouralSciences =
        _prefix "isApplicationOfBehaviouralSciences"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfFormalScience"></see>
    /// </summary>
    let isApplicationOfFormalScience = _prefix "isApplicationOfFormalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfHealthSciences"></see>
    /// </summary>
    let isApplicationOfHealthSciences = _prefix "isApplicationOfHealthSciences"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfInterdisciplinaryStudies"></see>
    /// </summary>
    let isApplicationOfInterdisciplinaryStudies =
        _prefix "isApplicationOfInterdisciplinaryStudies"

    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfNaturalScience"></see>
    /// </summary>
    let isApplicationOfNaturalScience = _prefix "isApplicationOfNaturalScience"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#isApplicationOfSocialSciences"></see>
    /// </summary>
    let isApplicationOfSocialSciences = _prefix "isApplicationOfSocialSciences"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#study_of_wetlands"></see>
    /// </summary>
    let study_of_wetlands = _prefix "study_of_wetlands"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#suppliesSubstancesTo"></see>
    /// </summary>
    let suppliesSubstancesTo = _prefix "suppliesSubstancesTo"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#takeSunstancesFrom"></see>
    /// </summary>
    let takeSunstancesFrom = _prefix "takeSunstancesFrom"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#temperature_gradient"></see>
    /// </summary>
    let temperature_gradient = _prefix "temperature_gradient"
    /// <summary>
    ///   <see href="https://w3id.org/skgo/modsci#usesTechniquesFrom"></see>
    /// </summary>
    let usesTechniquesFrom = _prefix "usesTechniquesFrom"
