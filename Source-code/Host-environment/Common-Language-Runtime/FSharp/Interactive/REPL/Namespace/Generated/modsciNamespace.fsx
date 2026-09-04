#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module modsci =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/skgo/modsci#" "modsci"
    let _namespaceIri = _prefixId.prefix ""
    let ADInstruments = _prefixId.prefix "ADInstruments"
    let Accelerometer = _prefixId.prefix "Accelerometer"
    let Accumulator = _prefixId.prefix "Accumulator"
    /// <summary>
    ///   <para>rdfs:label : Acid–base Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : For chemicals that can behave as acids or bases^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AcidbaseChemistry">modsci:AcidbaseChemistry</a>
    /// </summary>
    let AcidbaseChemistry = _prefixId.prefix "AcidbaseChemistry"
    /// <summary>
    ///   <para>rdfs:label : Acoustics^^xsd:string</para>
    ///   <para>rdfs:comment : Acoustics is a branch of continuum mechanics and is the study of sound, mechanical waves in gases, liquids, and solids.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Acoustics">modsci:Acoustics</a>
    /// </summary>
    let Acoustics = _prefixId.prefix "Acoustics"
    let AgilentTechnologies = _prefixId.prefix "AgilentTechnologies"
    /// <summary>
    ///   <para>rdfs:label : Agriculture^^xsd:string</para>
    ///   <para>rdfs:comment : Agriculture, also known as farming, is the process of producing food, feed, fiber and other desired products by cultivation of certain plants and the raising of domesticated animals.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Agriculture">modsci:Agriculture</a>
    /// </summary>
    let Agriculture = _prefixId.prefix "Agriculture"
    let Agronomy = _prefixId.prefix "Agronomy"
    let Algebra = _prefixId.prefix "Algebra"
    /// <summary>
    ///   <para>rdfs:label : Algorithms^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Algorithms">modsci:Algorithms</a>
    /// </summary>
    let Algorithms = _prefixId.prefix "Algorithms"
    let Ammeter = _prefixId.prefix "Ammeter"
    /// <summary>
    ///   <para>rdfs:label : Analytical Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Analytical chemistry is the analysis of material samples to gain an understanding of their chemical composition and structure.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AnalyticalChemistry">modsci:AnalyticalChemistry</a>
    /// </summary>
    let AnalyticalChemistry = _prefixId.prefix "AnalyticalChemistry"
    let AnalyticalSpectrometry = _prefixId.prefix "AnalyticalSpectrometry"
    /// <summary>
    ///   <para>rdfs:label : Anatomy^^xsd:string</para>
    ///   <para>rdfs:comment : Anatomy is the study of the structure and organization of living things.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Anatomy">modsci:Anatomy</a>
    /// </summary>
    let Anatomy = _prefixId.prefix "Anatomy"
    let Anemometer = _prefixId.prefix "Anemometer"
    let AnimalProduction = _prefixId.prefix "AnimalProduction"
    /// <summary>
    ///   <para>rdfs:label : Anthropology^^xsd:string</para>
    ///   <para>rdfs:comment : Anthropology is the scientific study of humans, human behavior and societies in the past and present.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Anthropology">modsci:Anthropology</a>
    /// </summary>
    let Anthropology = _prefixId.prefix "Anthropology"
    let AntonPaar = _prefixId.prefix "AntonPaar"
    /// <summary>
    ///   <para>rdfs:label : Application of science^^xsd:string</para>
    ///   <para>rdfs:comment : An application of science is any use of scientific knowledge for a specific purpose, whether to do more science; to design a product, process, or medical treatment; to develop a new technology; or to predict the impacts of human actions.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ApplicationOfScience">modsci:ApplicationOfScience</a>
    /// </summary>
    let ApplicationOfScience = _prefixId.prefix "ApplicationOfScience"
    /// <summary>
    ///   <para>rdfs:label : Applied Mathematics^^xsd:string</para>
    ///   <para>rdfs:comment : Applied mathematics is a branch of mathematics that concerns itself with the application of mathematical knowledge to other domains.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AppliedMathematics">modsci:AppliedMathematics</a>
    /// </summary>
    let AppliedMathematics = _prefixId.prefix "AppliedMathematics"
    let AppliedMechanics = _prefixId.prefix "AppliedMechanics"
    /// <summary>
    ///   <para>rdfs:label : Applied and Interdisciplinary Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Applied physics is intended for a particular technological or practical use.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AppliedPhysics">modsci:AppliedPhysics</a>
    /// </summary>
    let AppliedPhysics = _prefixId.prefix "AppliedPhysics"
    /// <summary>
    ///   <para>rdfs:label : Applied Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : Applied science is the use or the study of the use of scientific knowledge to develop technology.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AppliedSciences">modsci:AppliedSciences</a>
    /// </summary>
    let AppliedSciences = _prefixId.prefix "AppliedSciences"
    let ApproximationTheory = _prefixId.prefix "ApproximationTheory"
    /// <summary>
    ///   <para>rdfs:label : Archaeology^^xsd:string</para>
    ///   <para>rdfs:comment : Archaeology, or archeology, is the study of human activity through the recovery and analysis of material culture.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Archaeology">modsci:Archaeology</a>
    /// </summary>
    let Archaeology = _prefixId.prefix "Archaeology"
    /// <summary>
    ///   <para>rdfs:label : Architecture^^xsd:string</para>
    ///   <para>rdfs:comment : Architecture is the art and science of designing buildings.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Architecture">modsci:Architecture</a>
    /// </summary>
    let Architecture = _prefixId.prefix "Architecture"
    /// <summary>
    ///   <para>rdfs:label : Artificial Intelligence^^xsd:string</para>
    ///   <para>rdfs:comment : In computer science, artificial intelligence (AI), sometimes called machine intelligence, is intelligence demonstrated by machines, in contrast to the natural intelligence displayed by humans. Colloquially, the term "artificial intelligence" is often used to describe machines (or computers) that mimic "cognitive" functions that humans associate with the human mind, such as "learning" and "problem solving".^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ArtificialIntelligence">modsci:ArtificialIntelligence</a>
    /// </summary>
    let ArtificialIntelligence = _prefixId.prefix "ArtificialIntelligence"
    /// <summary>
    ///   <para>rdfs:label : Astrobiology^^xsd:string</para>
    ///   <para>rdfs:comment : Astrobiology, formerly known as exobiology, is an interdisciplinary scientific field concerned with the origins, early evolution, distribution, and future of life in the universe.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Astrobiology">modsci:Astrobiology</a>
    /// </summary>
    let Astrobiology = _prefixId.prefix "Astrobiology"
    /// <summary>
    ///   <para>rdfs:label : Astrochemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Astrochemistry is the study of the abundance and reactions of molecules in the Universe, and their interaction with radiation.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Astrochemistry">modsci:Astrochemistry</a>
    /// </summary>
    let Astrochemistry = _prefixId.prefix "Astrochemistry"
    /// <summary>
    ///   <para>rdfs:label : Astrometry^^xsd:string</para>
    ///   <para>rdfs:comment : Astrometry is the study of the positions, distances between, and motions of astronomical objects.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Astrometry">modsci:Astrometry</a>
    /// </summary>
    let Astrometry = _prefixId.prefix "Astrometry"
    /// <summary>
    ///   <para>rdfs:label : Astronomical Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AstronomicalPhenomena">modsci:AstronomicalPhenomena</a>
    /// </summary>
    let AstronomicalPhenomena = _prefixId.prefix "AstronomicalPhenomena"
    let Astronomical_Studies = _prefixId.prefix "Astronomical_Studies"
    /// <summary>
    ///   <para>rdfs:label : Astronomy^^xsd:string</para>
    ///   <para>rdfs:comment : is a science involving the observation and explanation of events occurring outside Earth and its atmosphere.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Astronomy">modsci:Astronomy</a>
    /// </summary>
    let Astronomy = _prefixId.prefix "Astronomy"
    /// <summary>
    ///   <para>rdfs:label : Atmospheric Optical Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AtmosphericPhenomena">modsci:AtmosphericPhenomena</a>
    /// </summary>
    let AtmosphericPhenomena = _prefixId.prefix "AtmosphericPhenomena"
    /// <summary>
    ///   <para>rdfs:label : Atmospheric Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : Atmospheric science is an umbrella term for the study of the atmosphere and its processes.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AtmosphericSciences">modsci:AtmosphericSciences</a>
    /// </summary>
    let AtmosphericSciences = _prefixId.prefix "AtmosphericSciences"
    /// <summary>
    ///   <para>rdfs:label : Atomic, Molecular, and Optical Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Atomic, molecular, and optical physics (AMO) is the study of matter-matter and light-matter interactions; at the scale of one or a few atoms and energy scales around several electron volts.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AtomicPhysics">modsci:AtomicPhysics</a>
    /// </summary>
    let AtomicPhysics = _prefixId.prefix "AtomicPhysics"
    let Aurora = _prefixId.prefix "Aurora"
    /// <summary>
    ///   <para>rdfs:label : Automata Theory^^xsd:string</para>
    ///   <para>rdfs:comment : Automata theory is the study of abstract machines and automata, as well as the computational problems that can be solved using them.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AutomataTheory">modsci:AutomataTheory</a>
    /// </summary>
    let AutomataTheory = _prefixId.prefix "AutomataTheory"
    /// <summary>
    ///   <para>rdfs:label : Automated Reasoning^^xsd:string</para>
    ///   <para>rdfs:comment : Automated reasoning is an area of computer science, cognitive science, and mathematical logic dedicated to understanding different aspects of reasoning.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#AutomatedReasoning">modsci:AutomatedReasoning</a>
    /// </summary>
    let AutomatedReasoning = _prefixId.prefix "AutomatedReasoning"
    let Barometer = _prefixId.prefix "Barometer"
    let BasinAnalysis = _prefixId.prefix "BasinAnalysis"
    /// <summary>
    ///   <para>rdfs:label : Behavioural Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : Behavioural sciences explore the cognitive processes within organisms and the behavioural interactions between organisms in the natural world.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#BehaviouralSciences">modsci:BehaviouralSciences</a>
    /// </summary>
    let BehaviouralSciences = _prefixId.prefix "BehaviouralSciences"
    /// <summary>
    ///   <para>rdfs:label : Biochemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Biochemistry is the chemistry of life.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biochemistry">modsci:Biochemistry</a>
    /// </summary>
    let Biochemistry = _prefixId.prefix "Biochemistry"
    let Biochip = _prefixId.prefix "Biochip"
    /// <summary>
    ///   <para>rdfs:label : Biological Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Biological engineering, or bioengineering/bio-engineering, is the application of principles of biology and the tools of engineering to create usable, tangible, economically viable products.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Bioengineering">modsci:Bioengineering</a>
    /// </summary>
    let Bioengineering = _prefixId.prefix "Bioengineering"
    /// <summary>
    ///   <para>rdfs:label : Bioethics^^xsd:string</para>
    ///   <para>rdfs:comment : Bioethics is the study of the ethical issues emerging from advances in biology and medicine.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Bioethics">modsci:Bioethics</a>
    /// </summary>
    let Bioethics = _prefixId.prefix "Bioethics"
    /// <summary>
    ///   <para>rdfs:label : Biogeography^^xsd:string</para>
    ///   <para>rdfs:comment : Biogeography is the study of the distribution of species and ecosystems in geographic space and through geological time.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biogeography">modsci:Biogeography</a>
    /// </summary>
    let Biogeography = _prefixId.prefix "Biogeography"
    /// <summary>
    ///   <para>rdfs:label : Bioinformatics^^xsd:string</para>
    ///   <para>rdfs:comment : Bioinformatics and Computational biology are interdisciplinary fields of research, development and application of algorithms, computational and statistical methods for management and analysis of biological data, and for solving basic biological problems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Bioinformatics">modsci:Bioinformatics</a>
    /// </summary>
    let Bioinformatics = _prefixId.prefix "Bioinformatics"
    let BioinformaticsSoftware = _prefixId.prefix "BioinformaticsSoftware"
    let BioinorganicChemistry = _prefixId.prefix "BioinorganicChemistry"
    let BiologicalMathematics = _prefixId.prefix "BiologicalMathematics"
    let BiologicalOceanography = _prefixId.prefix "BiologicalOceanography"
    /// <summary>
    ///   <para>rdfs:label : Biological Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#BiologicalPhenomena">modsci:BiologicalPhenomena</a>
    /// </summary>
    let BiologicalPhenomena = _prefixId.prefix "BiologicalPhenomena"
    let Biological_Studies = _prefixId.prefix "Biological_Studies"
    /// <summary>
    ///   <para>rdfs:label : Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Biology is the science of life. It is concerned with the characteristics and behaviors of organisms^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biology">modsci:Biology</a>
    /// </summary>
    let Biology = _prefixId.prefix "Biology"
    /// <summary>
    ///   <para>rdfs:label : Biomedical Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Biomedical engineering (BME) or medical engineering is the application of engineering principles and design concepts to medicine and biology for healthcare purposes (e.g. diagnostic or therapeutic).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#BiomedicalEngineering">modsci:BiomedicalEngineering</a>
    /// </summary>
    let BiomedicalEngineering = _prefixId.prefix "BiomedicalEngineering"
    let Biomedical_Signals = _prefixId.prefix "Biomedical_Signals"
    /// <summary>
    ///   <para>rdfs:label : Biophysics^^xsd:string</para>
    ///   <para>rdfs:comment : Biophysics is an interdisciplinary science that applies approaches and methods traditionally used in physics to study biological phenomena.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biophysics">modsci:Biophysics</a>
    /// </summary>
    let Biophysics = _prefixId.prefix "Biophysics"
    /// <summary>
    ///   <para>rdfs:label : Biopsychology^^xsd:string</para>
    ///   <para>rdfs:comment : Biological psychology,is the application of the principles of biology to the study of physiological and developmental mechanisms of behavior in humans and other animals.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biopsychology">modsci:Biopsychology</a>
    /// </summary>
    let Biopsychology = _prefixId.prefix "Biopsychology"
    let Biosensors = _prefixId.prefix "Biosensors"
    /// <summary>
    ///   <para>rdfs:label : Biostatistics^^xsd:string</para>
    ///   <para>rdfs:comment : Biostatistics are the development and application of statistical methods to a wide range of topics in biology.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biostatistics">modsci:Biostatistics</a>
    /// </summary>
    let Biostatistics = _prefixId.prefix "Biostatistics"
    /// <summary>
    ///   <para>rdfs:label : Biotechnology^^xsd:string</para>
    ///   <para>rdfs:comment : Biotechnology is a technology based on biology, especially when used in agriculture, food science, medicine, and genetic engineering.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Biotechnology">modsci:Biotechnology</a>
    /// </summary>
    let Biotechnology = _prefixId.prefix "Biotechnology"
    let Boiling = _prefixId.prefix "Boiling"
    /// <summary>
    ///   <para>rdfs:label : Botany^^xsd:string</para>
    ///   <para>rdfs:comment : Botany also called plant science(s), plant biology or phytology, is the science of plant life and a branch of biology.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Botany">modsci:Botany</a>
    /// </summary>
    let Botany = _prefixId.prefix "Botany"
    let Breaking_waves = _prefixId.prefix "Breaking_waves"
    let Bruker = _prefixId.prefix "Bruker"
    let CalculusOfVariations = _prefixId.prefix "CalculusOfVariations"
    let Caliper = _prefixId.prefix "Caliper"
    let Calorimeter = _prefixId.prefix "Calorimeter"
    let Catalysis = _prefixId.prefix "Catalysis"
    /// <summary>
    ///   <para>rdfs:label : Cell Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Cell biology is a branch of biology that studies the structure and function of the cell, which is the basic unit of life.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CellBiology">modsci:CellBiology</a>
    /// </summary>
    let CellBiology = _prefixId.prefix "CellBiology"

    let ChemicalCharacterisationOfMaterials =
        _prefixId.prefix "ChemicalCharacterisationOfMaterials"

    /// <summary>
    ///   <para>rdfs:label : Chemical Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Chemical engineering is the application of science, in particular chemistry, fluid physics, and biology, along with mathematics and economics to the human endeavor of converting raw materials or chemicals into more useful or valuable forms.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ChemicalEngineering">modsci:ChemicalEngineering</a>
    /// </summary>
    let ChemicalEngineering = _prefixId.prefix "ChemicalEngineering"
    let ChemicalOceanography = _prefixId.prefix "ChemicalOceanography"
    /// <summary>
    ///   <para>rdfs:label : Chemical Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ChemicalPhenomena">modsci:ChemicalPhenomena</a>
    /// </summary>
    let ChemicalPhenomena = _prefixId.prefix "ChemicalPhenomena"
    let ChemicalThermodynamics = _prefixId.prefix "ChemicalThermodynamics"
    let Chemical_Studies = _prefixId.prefix "Chemical_Studies"
    /// <summary>
    ///   <para>rdfs:label : Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Chemistry is defined as the science of matter, different from physics, in terms of matter's chemical structure, reactivity, properties and reactions or transformations.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Chemistry">modsci:Chemistry</a>
    /// </summary>
    let Chemistry = _prefixId.prefix "Chemistry"
    let ClassicalPhysics = _prefixId.prefix "ClassicalPhysics"
    let ClassificationAlgorithms = _prefixId.prefix "ClassificationAlgorithms"
    let CoalGeology = _prefixId.prefix "CoalGeology"
    let CodingAndInformationTheory = _prefixId.prefix "CodingAndInformationTheory"
    /// <summary>
    ///   <para>rdfs:label : Cognitive Science^^xsd:string</para>
    ///   <para>rdfs:comment : Cognitive science is the interdisciplinary, scientific study of the mind and its processes.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CognitiveScience">modsci:CognitiveScience</a>
    /// </summary>
    let CognitiveScience = _prefixId.prefix "CognitiveScience"
    let Colloid = _prefixId.prefix "Colloid"
    /// <summary>
    ///   <para>rdfs:label : Colloidal Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Interface and colloid science is an interdisciplinary intersection of branches of chemistry, physics, nanoscience and other fields dealing with colloids, heterogeneous systems consisting of a mechanical mixture of particles between 1 nm and 1000 nm dispersed in a continuous medium.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ColloidalChemistry">modsci:ColloidalChemistry</a>
    /// </summary>
    let ColloidalChemistry = _prefixId.prefix "ColloidalChemistry"
    /// <summary>
    ///   <para>rdfs:label : Communication and Security^^xsd:string</para>
    ///   <para>rdfs:comment : Communications security is the discipline of preventing unauthorized interceptors from accessing telecommunications in an intelligible form, while still delivering content to the intended recipients.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CommunicationAndSecurity">modsci:CommunicationAndSecurity</a>
    /// </summary>
    let CommunicationAndSecurity = _prefixId.prefix "CommunicationAndSecurity"
    /// <summary>
    ///   <para>rdfs:label : Communication^^xsd:string</para>
    ///   <para>rdfs:comment : Communication is the act of conveying meanings from one entity or group to another through the use of mutually understood signs, symbols, and semiotic rules.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CommunicationStudies">modsci:CommunicationStudies</a>
    /// </summary>
    let CommunicationStudies = _prefixId.prefix "CommunicationStudies"

    let Community_of_European_Solar_Radio_Astronomers =
        _prefixId.prefix "Community_of_European_Solar_Radio_Astronomers"

    /// <summary>
    ///   <para>rdfs:label : Compiler Theory^^xsd:string</para>
    ///   <para>rdfs:comment : A compiler implements a formal transformation from a high-level source program to a low-level target program.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CompilerTheory">modsci:CompilerTheory</a>
    /// </summary>
    let CompilerTheory = _prefixId.prefix "CompilerTheory"
    /// <summary>
    ///   <para>rdfs:label : Computability Theory^^xsd:string</para>
    ///   <para>rdfs:comment : Computability theory, also known as recursion theory, is a branch of mathematical logic, of computer science, and of the theory of computation that originated in the 1930s with the study of computable functions and Turing degrees.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputabilityTheory">modsci:ComputabilityTheory</a>
    /// </summary>
    let ComputabilityTheory = _prefixId.prefix "ComputabilityTheory"
    /// <summary>
    ///   <para>rdfs:label : Computational Complexity Theory^^xsd:string</para>
    ///   <para>rdfs:comment : Computational complexity theory focuses on classifying computational problems according to their inherent difficulty, and relating these classes to each other. A computational problem is a task solved by a computer.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputationalComplexityTheory">modsci:ComputationalComplexityTheory</a>
    /// </summary>
    let ComputationalComplexityTheory = _prefixId.prefix "ComputationalComplexityTheory"
    /// <summary>
    ///   <para>rdfs:label : Computational Linguistics^^xsd:string</para>
    ///   <para>rdfs:comment : Computational linguistics is an interdisciplinary field concerned with the statistical or rule-based modeling of natural language from a computational perspective, as well as the study of appropriate computational approaches to linguistic questions.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputationalLinguistics">modsci:ComputationalLinguistics</a>
    /// </summary>
    let ComputationalLinguistics = _prefixId.prefix "ComputationalLinguistics"
    let ComputationalMathematics = _prefixId.prefix "ComputationalMathematics"
    /// <summary>
    ///   <para>rdfs:label : Computational Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Computational physics is the study and implementation of numerical algorithms in order to solve problems in physics for which a quantitative theory already exists.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputationalPhysics">modsci:ComputationalPhysics</a>
    /// </summary>
    let ComputationalPhysics = _prefixId.prefix "ComputationalPhysics"
    let Computer_HumanInteraction = _prefixId.prefix "Computer-HumanInteraction"
    let ComputerApplications = _prefixId.prefix "ComputerApplications"
    /// <summary>
    ///   <para>rdfs:label : Computer Concurrency^^xsd:string</para>
    ///   <para>rdfs:comment : In computer science, concurrency is the ability of different parts or units of a program, algorithm, or problem to be executed out-of-order or in partial order, without affecting the final outcome. This allows for parallel execution of the concurrent units, which can significantly improve overall speed of the execution in multi-processor and multi-core systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputerConcurrency">modsci:ComputerConcurrency</a>
    /// </summary>
    let ComputerConcurrency = _prefixId.prefix "ComputerConcurrency"
    /// <summary>
    ///   <para>rdfs:label : Graphics^^xsd:stringrdfs:label : Computer Graphics^^xsd:string</para>
    ///   <para>rdfs:comment : Computer graphics is the study of digital visual contents and involves the synthesis and manipulation of image data.^^xsd:stringrdfs:comment : Computer graphics are pictures and films created using computers. Usually, the term refers to computer-generated image data created with the help of specialized graphical hardware and software.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputerGraphics">modsci:ComputerGraphics</a>
    /// </summary>
    let ComputerGraphics = _prefixId.prefix "ComputerGraphics"
    /// <summary>
    ///   <para>rdfs:label : Computer Science^^xsd:string</para>
    ///   <para>rdfs:comment : Computer science is the study of processes that interact with data and that can be represented as data in the form of programs.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputerScience">modsci:ComputerScience</a>
    /// </summary>
    let ComputerScience = _prefixId.prefix "ComputerScience"
    /// <summary>
    ///   <para>rdfs:label : Computer Security^^xsd:string</para>
    ///   <para>rdfs:comment : Computer security, cybersecurity or information technology security (IT security) is the protection of computer systems from the theft of or damage to their hardware, software, or electronic data, as well as from the disruption or misdirection of the services they provide.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputerSecurity">modsci:ComputerSecurity</a>
    /// </summary>
    let ComputerSecurity = _prefixId.prefix "ComputerSecurity"
    let ComputerSoftware = _prefixId.prefix "ComputerSoftware"
    /// <summary>
    ///   <para>rdfs:label : Computer Architecture^^xsd:string</para>
    ///   <para>rdfs:comment : In computer engineering, computer architecture is a set of rules and methods that describe the functionality, organization, and implementation of computer systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputerSystemArchitecture">modsci:ComputerSystemArchitecture</a>
    /// </summary>
    let ComputerSystemArchitecture = _prefixId.prefix "ComputerSystemArchitecture"
    /// <summary>
    ///   <para>rdfs:label : Computer Vision^^xsd:string</para>
    ///   <para>rdfs:comment : Computer vision is an interdisciplinary scientific field that deals with how computers can be made to gain high-level understanding from digital images or videos.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ComputerVision">modsci:ComputerVision</a>
    /// </summary>
    let ComputerVision = _prefixId.prefix "ComputerVision"
    let ConceptualModelling = _prefixId.prefix "ConceptualModelling"
    /// <summary>
    ///   <para>rdfs:label : Condensed Matter Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Condensed matter physics is the field of physics that deals with the macroscopic physical properties of matter.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CondensedMatterPhysics">modsci:CondensedMatterPhysics</a>
    /// </summary>
    let CondensedMatterPhysics = _prefixId.prefix "CondensedMatterPhysics"
    let Conservation_of_energy = _prefixId.prefix "Conservation_of_energy"
    /// <summary>
    ///   <para>rdfs:label : Physical Cosmology^^xsd:string</para>
    ///   <para>rdfs:comment : Physical cosmology is the study of the largest-scale structures and dynamics of the Universe and is concerned with fundamental questions about its origin, structure, evolution, and ultimate fate.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Cosmology">modsci:Cosmology</a>
    /// </summary>
    let Cosmology = _prefixId.prefix "Cosmology"
    let CropProduction = _prefixId.prefix "CropProduction"
    /// <summary>
    ///   <para>rdfs:label : Cryobiology^^xsd:string</para>
    ///   <para>rdfs:comment : Cryobiology is the study of living organisms, organs, biological tissues or biological cells at low temperatures.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Cryobiology">modsci:Cryobiology</a>
    /// </summary>
    let Cryobiology = _prefixId.prefix "Cryobiology"
    /// <summary>
    ///   <para>rdfs:label : Cryptography^^xsd:string</para>
    ///   <para>rdfs:comment : Cryptography or cryptology is the practice and study of techniques for secure communication in the presence of third parties called adversaries.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Cryptography">modsci:Cryptography</a>
    /// </summary>
    let Cryptography = _prefixId.prefix "Cryptography"
    let Crystal_growth = _prefixId.prefix "Crystal_growth"
    /// <summary>
    ///   <para>rdfs:label : Crystallography^^xsd:string</para>
    ///   <para>rdfs:comment : Crystallography is the scientific study of crystals.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Crystallography">modsci:Crystallography</a>
    /// </summary>
    let Crystallography = _prefixId.prefix "Crystallography"
    /// <summary>
    ///   <para>rdfs:label : Cultural Studies^^xsd:string</para>
    ///   <para>rdfs:comment : Cultural studies is a field of theoretically, politically, and empirically engaged cultural analysis that concentrates upon the political dynamics of contemporary culture, its historical foundations, defining traits, conflicts, and contingencies.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#CulturalStudies">modsci:CulturalStudies</a>
    /// </summary>
    let CulturalStudies = _prefixId.prefix "CulturalStudies"
    /// <summary>
    ///   <para>rdfs:label : Cybernetics^^xsd:string</para>
    ///   <para>rdfs:comment : Cybernetics is a transdisciplinary approach for exploring regulatory systems with feedback, their structures, constraints, and possibilities.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Cybernetics">modsci:Cybernetics</a>
    /// </summary>
    let Cybernetics = _prefixId.prefix "Cybernetics"
    let DNA_Sequencer = _prefixId.prefix "DNA_Sequencer"
    let DataEncryption = _prefixId.prefix "DataEncryption"
    let DataFormat = _prefixId.prefix "DataFormat"
    /// <summary>
    ///   <para>rdfs:label : Data Mining^^xsd:string</para>
    ///   <para>rdfs:comment : Data mining is the process of discovering patterns in large data sets involving methods at the intersection of machine learning, statistics, and database systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#DataMining">modsci:DataMining</a>
    /// </summary>
    let DataMining = _prefixId.prefix "DataMining"
    let DataStructures = _prefixId.prefix "DataStructures"
    /// <summary>
    ///   <para>rdfs:label : Databases^^xsd:string</para>
    ///   <para>rdfs:comment : Digital databases are managed using database management systems to store, create, maintain, and search data, through database models and query languages.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#DatabaseManagement">modsci:DatabaseManagement</a>
    /// </summary>
    let DatabaseManagement = _prefixId.prefix "DatabaseManagement"
    let DecisionSupportSystems = _prefixId.prefix "DecisionSupportSystems"
    let Decision_Trees = _prefixId.prefix "Decision_Trees"
    let Decomposition = _prefixId.prefix "Decomposition"
    let Deep_Learning = _prefixId.prefix "Deep_Learning"
    /// <summary>
    ///   <para>rdfs:label : Dentistry^^xsd:string</para>
    ///   <para>rdfs:comment : Dentistry, also known as Dental and Oral Medicine, is a branch of medicine that consists of the study, diagnosis, prevention, and treatment of diseases, disorders, and conditions of the oral cavity, commonly in the dentition but also the oral mucosa, and of adjacent and related structures and tissues, particularly in the maxillofacial (jaw and facial) area.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Dentistry">modsci:Dentistry</a>
    /// </summary>
    let Dentistry = _prefixId.prefix "Dentistry"
    /// <summary>
    ///   <para>rdfs:label : Developmental Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Developmental biology is the study of the process by which animals and plants grow and develop.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#DevelopmentalBiology">modsci:DevelopmentalBiology</a>
    /// </summary>
    let DevelopmentalBiology = _prefixId.prefix "DevelopmentalBiology"
    let DifferentialEquations = _prefixId.prefix "DifferentialEquations"
    let DiscoveryOfMethods = _prefixId.prefix "DiscoveryOfMethods"
    let DiscoveryOfPhenomenon = _prefixId.prefix "DiscoveryOfPhenomenon"
    let DiscreteMathematics = _prefixId.prefix "DiscreteMathematics"
    /// <summary>
    ///   <para>rdfs:label : Distributed Computing^^xsd:string</para>
    ///   <para>rdfs:comment : Distributed computing is a field of computer science that studies distributed systems. A distributed system is a system whose components are located on different networked computers, which communicate and coordinate their actions by passing messages to one another.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#DistributedComputing">modsci:DistributedComputing</a>
    /// </summary>
    let DistributedComputing = _prefixId.prefix "DistributedComputing"
    /// <summary>
    ///   <para>rdfs:label : Concurrent, Parallel, and Distributed systems^^xsd:string</para>
    ///   <para>rdfs:comment : Systems in which several computations are executing simultaneously, and potentially interacting with each other.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#DistributedSystems">modsci:DistributedSystems</a>
    /// </summary>
    let DistributedSystems = _prefixId.prefix "DistributedSystems"
    let Dynamo = _prefixId.prefix "Dynamo"
    let Dynamometer = _prefixId.prefix "Dynamometer"
    let E3G = _prefixId.prefix "E3G"
    let EACSL = _prefixId.prefix "EACSL"
    /// <summary>
    ///   <para>rdfs:label : Earth Science^^xsd:string</para>
    ///   <para>rdfs:comment : Earth science (also known as geoscience, the geosciences, or the Earth sciences) includes all the sciences related to the planet Earth.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EarthScience">modsci:EarthScience</a>
    /// </summary>
    let EarthScience = _prefixId.prefix "EarthScience"
    let Earthquake = _prefixId.prefix "Earthquake"
    let EcologicalApplications = _prefixId.prefix "EcologicalApplications"
    /// <summary>
    ///   <para>rdfs:label : Ecology^^xsd:string</para>
    ///   <para>rdfs:comment : Ecology is the branch of science that studies the distribution and interactions between living things and the physical environment.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Ecology">modsci:Ecology</a>
    /// </summary>
    let Ecology = _prefixId.prefix "Ecology"
    let Economic_Studies = _prefixId.prefix "Economic_Studies"
    /// <summary>
    ///   <para>rdfs:label : Economics^^xsd:string</para>
    ///   <para>rdfs:comment : Economics is the social science that studies the production, distribution, and consumption of goods and services.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Economics">modsci:Economics</a>
    /// </summary>
    let Economics = _prefixId.prefix "Economics"
    /// <summary>
    ///   <para>rdfs:label : Education^^xsd:string</para>
    ///   <para>rdfs:comment : Education is the teaching or learning of knowledge, especially to develop the reasoning, judgement and skill required in adult life and professional occupations.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Education">modsci:Education</a>
    /// </summary>
    let Education = _prefixId.prefix "Education"
    let ElectroanalyticalChemistry = _prefixId.prefix "ElectroanalyticalChemistry"
    let Electrochemistry = _prefixId.prefix "Electrochemistry"
    let Electrodynamics = _prefixId.prefix "Electrodynamics"
    let Electrometer = _prefixId.prefix "Electrometer"
    let Electroscope = _prefixId.prefix "Electroscope"
    let Electrostatics = _prefixId.prefix "Electrostatics"
    let Elementar = _prefixId.prefix "Elementar"
    let Ellipsometer = _prefixId.prefix "Ellipsometer"
    /// <summary>
    ///   <para>rdfs:label : Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Engineering is the practical application of science. This is accomplished through knowledge, mathematics, and practical experience applied to the design of useful objects or processes.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Engineering">modsci:Engineering</a>
    /// </summary>
    let Engineering = _prefixId.prefix "Engineering"
    let Engineering_Studies = _prefixId.prefix "Engineering_Studies"
    /// <summary>
    ///   <para>rdfs:label : Environmental Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Environmental chemistry is the scientific study of the physical, chemical and biochemical properties and processes of polluting substances in the environment.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EnvironmentalChemistry">modsci:EnvironmentalChemistry</a>
    /// </summary>
    let EnvironmentalChemistry = _prefixId.prefix "EnvironmentalChemistry"
    /// <summary>
    ///   <para>rdfs:label : Environmental Science^^xsd:string</para>
    ///   <para>rdfs:comment : Environmental science is the science of the interactions between the physical, chemical, and biological components of the environment, but with particular attention to the effects of humans on the natural environment.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EnvironmentalScience">modsci:EnvironmentalScience</a>
    /// </summary>
    let EnvironmentalScience = _prefixId.prefix "EnvironmentalScience"
    /// <summary>
    ///   <para>rdfs:label : Epidemiology^^xsd:string</para>
    ///   <para>rdfs:comment : Epidemiology is the study and analysis of the distribution (who, when, and where), patterns and determinants of health and disease conditions in defined populations.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Epidemiology">modsci:Epidemiology</a>
    /// </summary>
    let Epidemiology = _prefixId.prefix "Epidemiology"
    /// <summary>
    ///   <para>rdfs:label : Ergonomics^^xsd:string</para>
    ///   <para>rdfs:comment : Human factors and ergonomics is the application of psychological and physiological principles to the (engineering and) design of products, processes, and systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Ergonomics">modsci:Ergonomics</a>
    /// </summary>
    let Ergonomics = _prefixId.prefix "Ergonomics"
    let Erosion = _prefixId.prefix "Erosion"
    /// <summary>
    ///   <para>rdfs:label : Ethnic Studies^^xsd:string</para>
    ///   <para>rdfs:comment : Ethnic studies, in the United States, is the interdisciplinary study of difference—chiefly race, ethnicity, and nation, but also sexuality, gender, and other such markings—and power, as expressed by the state, by civil society, and by individuals.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EthnicStudies">modsci:EthnicStudies</a>
    /// </summary>
    let EthnicStudies = _prefixId.prefix "EthnicStudies"
    /// <summary>
    ///   <para>rdfs:label : Ethnobiology^^xsd:string</para>
    ///   <para>rdfs:comment : Ethnobiology is the scientific study of the way living things are treated or used by different human cultures.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Ethnobiology">modsci:Ethnobiology</a>
    /// </summary>
    let Ethnobiology = _prefixId.prefix "Ethnobiology"
    /// <summary>
    ///   <para>rdfs:label : Ethnology^^xsd:string</para>
    ///   <para>rdfs:comment : Ethnology is the science that analyzes human cultures and compares them.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Ethnology">modsci:Ethnology</a>
    /// </summary>
    let Ethnology = _prefixId.prefix "Ethnology"
    /// <summary>
    ///   <para>rdfs:label : Ethology^^xsd:string</para>
    ///   <para>rdfs:comment : Ethology is the scientific and objective study of animal behaviour, usually with a focus on behaviour under natural conditions, and viewing behaviour as an evolutionarily adaptive trait.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Ethology">modsci:Ethology</a>
    /// </summary>
    let Ethology = _prefixId.prefix "Ethology"
    let Eudiometer = _prefixId.prefix "Eudiometer"
    let Evangelista_Torricelli = _prefixId.prefix "Evangelista_Torricelli"
    /// <summary>
    ///   <para>rdfs:label : Evolutionary Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Evolutionary biology is a sub-field of biology concerned with the study of the evolutionary processes that produced the diversity of life on Earth.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EvolutionaryBiology">modsci:EvolutionaryBiology</a>
    /// </summary>
    let EvolutionaryBiology = _prefixId.prefix "EvolutionaryBiology"
    /// <summary>
    ///   <para>rdfs:label : Evolutionary Computation^^xsd:string</para>
    ///   <para>rdfs:comment : In computer science, evolutionary computation is a family of algorithms for global optimization inspired by biological evolution, and the subfield of artificial intelligence and soft computing studying these algorithms.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EvolutionaryComputation">modsci:EvolutionaryComputation</a>
    /// </summary>
    let EvolutionaryComputation = _prefixId.prefix "EvolutionaryComputation"
    /// <summary>
    ///   <para>rdfs:label : Evolutionary Psychology^^xsd:string</para>
    ///   <para>rdfs:comment : Evolutionary psychology is a theoretical approach in the social and natural sciences that examines psychological structure from a modern evolutionary perspective.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#EvolutionaryPsychology">modsci:EvolutionaryPsychology</a>
    /// </summary>
    let EvolutionaryPsychology = _prefixId.prefix "EvolutionaryPsychology"
    /// <summary>
    ///   <para>rdfs:label : Experimental Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Experimental physics is the category of disciplines and sub-disciplines in the field of physics that are concerned with the observation of physical phenomena and experiments.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ExperimentalPhysics">modsci:ExperimentalPhysics</a>
    /// </summary>
    let ExperimentalPhysics = _prefixId.prefix "ExperimentalPhysics"
    /// <summary>
    ///   <para>rdfs:label : Extragalactic Astronomy^^xsd:string</para>
    ///   <para>rdfs:comment : It is the study of all astronomical objects which are not covered by galactic astronomy.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ExtragalacticAstronomy">modsci:ExtragalacticAstronomy</a>
    /// </summary>
    let ExtragalacticAstronomy = _prefixId.prefix "ExtragalacticAstronomy"
    let ExtraterrestrialGeology = _prefixId.prefix "ExtraterrestrialGeology"
    let FinancialMathematics = _prefixId.prefix "FinancialMathematics"
    let Fire = _prefixId.prefix "Fire"
    let FisheriesSciences = _prefixId.prefix "FisheriesSciences"
    let FlowAnalysis = _prefixId.prefix "FlowAnalysis"
    let FluidPhysics = _prefixId.prefix "FluidPhysics"
    /// <summary>
    ///   <para>rdfs:label : Food Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Food chemistry is the study of chemical processes and interactions of all biological and non-biological components of foods.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#FoodChemistry">modsci:FoodChemistry</a>
    /// </summary>
    let FoodChemistry = _prefixId.prefix "FoodChemistry"
    /// <summary>
    ///   <para>rdfs:label : Forensics^^xsd:string</para>
    ///   <para>rdfs:comment : Forensic science, also known as criminalistics, is the application of science to criminal and civil laws, mainly—on the criminal side—during criminal investigation, as governed by the legal standards of admissible evidence and criminal procedure.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Forensics">modsci:Forensics</a>
    /// </summary>
    let Forensics = _prefixId.prefix "Forensics"
    /// <summary>
    ///   <para>rdfs:label : Forestry^^xsd:string</para>
    ///   <para>rdfs:comment : Forestry is the art, science, and practice of studying and managing forests and related natural resources.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Forestry">modsci:Forestry</a>
    /// </summary>
    let Forestry = _prefixId.prefix "Forestry"
    let ForestrySciences = _prefixId.prefix "ForestrySciences"
    /// <summary>
    ///   <para>rdfs:label : Formal Science^^xsd:string</para>
    ///   <para>rdfs:comment : Formal sciences are a branch of science studying formal language disciplines concerned with formal systems, such as logic, mathematics, statistics, theoretical computer science, artificial intelligence, information theory, game theory, systems theory, decision theory, and theoretical linguistics.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#FormalScience">modsci:FormalScience</a>
    /// </summary>
    let FormalScience = _prefixId.prefix "FormalScience"
    let Fraunhofer = _prefixId.prefix "Fraunhofer"
    let FreeRadicalChemistry = _prefixId.prefix "FreeRadicalChemistry"
    let Freezing = _prefixId.prefix "Freezing"
    let Friedrich_Drexler = _prefixId.prefix "Friedrich_Drexler"
    let FunctionalAnalysis = _prefixId.prefix "FunctionalAnalysis"
    /// <summary>
    ///   <para>rdfs:label : Galactic Astronomy^^xsd:string</para>
    ///   <para>rdfs:comment : The study of everything outside our galaxy, including all other galaxies.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#GalacticAstronomy">modsci:GalacticAstronomy</a>
    /// </summary>
    let GalacticAstronomy = _prefixId.prefix "GalacticAstronomy"
    let Galileo = _prefixId.prefix "Galileo"
    let Galvanometer = _prefixId.prefix "Galvanometer"
    let Genetic_algorithms = _prefixId.prefix "Genetic_algorithms"
    /// <summary>
    ///   <para>rdfs:label : Genetics^^xsd:string</para>
    ///   <para>rdfs:comment : Genetics is the study of genes, heredity, and the variation of organisms, as well as the medical practice of diagnosing, treating, and counseling patients with genetic disorders.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Genetics">modsci:Genetics</a>
    /// </summary>
    let Genetics = _prefixId.prefix "Genetics"
    /// <summary>
    ///   <para>rdfs:label : Geochemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Geochemistry is the science that uses the tools and principles of chemistry to explain the mechanisms behind major geological systems such as the Earth's crust and its oceans.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Geochemistry">modsci:Geochemistry</a>
    /// </summary>
    let Geochemistry = _prefixId.prefix "Geochemistry"
    let Geochronology = _prefixId.prefix "Geochronology"
    /// <summary>
    ///   <para>rdfs:label : Geodesy^^xsd:string</para>
    ///   <para>rdfs:comment : Geodesy is the Earth science of accurately measuring and understanding Earth's geometric shape, orientation in space and gravitational field.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Geodesy">modsci:Geodesy</a>
    /// </summary>
    let Geodesy = _prefixId.prefix "Geodesy"
    let Geodynamics = _prefixId.prefix "Geodynamics"
    /// <summary>
    ///   <para>rdfs:label : Geography^^xsd:string</para>
    ///   <para>rdfs:comment : Geography is a field of science devoted to the study of the lands, features, inhabitants, and phenomena of the Earth and planets.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Geography">modsci:Geography</a>
    /// </summary>
    let Geography = _prefixId.prefix "Geography"
    /// <summary>
    ///   <para>rdfs:label : Geological Phenomena^^xsd:string</para>
    ///   <para>rdfs:comment : A geological phenomenon is a phenomenon which is explained by or sheds light on the science of geology.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#GeologicalPhenomena">modsci:GeologicalPhenomena</a>
    /// </summary>
    let GeologicalPhenomena = _prefixId.prefix "GeologicalPhenomena"
    /// <summary>
    ///   <para>rdfs:label : Geological Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : The Geological Sciences examine the physical and chemical processes within Earth and on its surface, including the study of natural resources and risks to habitable areas.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#GeologicalSciences">modsci:GeologicalSciences</a>
    /// </summary>
    let GeologicalSciences = _prefixId.prefix "GeologicalSciences"
    let Geological_Studies = _prefixId.prefix "Geological_Studies"
    /// <summary>
    ///   <para>rdfs:label : Geology^^xsd:string</para>
    ///   <para>rdfs:comment : Geology is an earth science concerned with the solid Earth, the rocks of which it is composed, and the processes by which they change over time.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Geology">modsci:Geology</a>
    /// </summary>
    let Geology = _prefixId.prefix "Geology"
    /// <summary>
    ///   <para>rdfs:label : Geomorphology^^xsd:string</para>
    ///   <para>rdfs:comment : Geomorphology is the science of surface features and landforms including the forces and processes that create them.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Geomorphology">modsci:Geomorphology</a>
    /// </summary>
    let Geomorphology = _prefixId.prefix "Geomorphology"
    let GeophysicalFluidDynamics = _prefixId.prefix "GeophysicalFluidDynamics"
    /// <summary>
    ///   <para>rdfs:label : Geophysics^^xsd:string</para>
    ///   <para>rdfs:comment : Geophysics the physics of the Earth and its environment in space, and study of earth sciences using quantitative physics methods.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Geophysics">modsci:Geophysics</a>
    /// </summary>
    let Geophysics = _prefixId.prefix "Geophysics"
    let Geothermics = _prefixId.prefix "Geothermics"
    /// <summary>
    ///   <para>rdfs:label : Gerontology^^xsd:string</para>
    ///   <para>rdfs:comment : Gerontology is the study of the social, cultural, psychological, cognitive, and biological aspects of ageing.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Gerontology">modsci:Gerontology</a>
    /// </summary>
    let Gerontology = _prefixId.prefix "Gerontology"
    /// <summary>
    ///   <para>rdfs:label : Glaciology^^xsd:string</para>
    ///   <para>rdfs:comment : Glaciology is the scientific study of glaciers, or more generally ice and natural phenomena that involve ice.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Glaciology">modsci:Glaciology</a>
    /// </summary>
    let Glaciology = _prefixId.prefix "Glaciology"
    let GlobalInformationSystems = _prefixId.prefix "GlobalInformationSystems"
    let Gravimetrics = _prefixId.prefix "Gravimetrics"
    let Gravitometer = _prefixId.prefix "Gravitometer"
    let Gravity = _prefixId.prefix "Gravity"
    /// <summary>
    ///   <para>rdfs:label : Green Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Green chemistry is the use of chemistry for pollutant source reduction; the definition encompasses therefore all aspects of chemical processes that reduce impact on human health and on the environment.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#GreenChemistry">modsci:GreenChemistry</a>
    /// </summary>
    let GreenChemistry = _prefixId.prefix "GreenChemistry"
    let Growth = _prefixId.prefix "Growth"
    let Guglielmo_Marconi = _prefixId.prefix "Guglielmo_Marconi"
    let Haze = _prefixId.prefix "Haze"
    /// <summary>
    ///   <para>rdfs:label : Health^^xsd:string</para>
    ///   <para>rdfs:comment : Health is a state of physical, mental and social well-being in which disease and infirmity are absent.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Health">modsci:Health</a>
    /// </summary>
    let Health = _prefixId.prefix "Health"
    /// <summary>
    ///   <para>rdfs:label : Health Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : Health sciences are those sciences which focus on health, or health care, as core parts of their subject matter.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#HealthSciences">modsci:HealthSciences</a>
    /// </summary>
    let HealthSciences = _prefixId.prefix "HealthSciences"
    /// <summary>
    ///   <para>rdfs:label : Healthcare^^xsd:string</para>
    ///   <para>rdfs:comment : Healthcare is the maintenance or improvement of health via the prevention, diagnosis, and treatment of disease, illness, injury, and other physical and mental impairments in people.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Healthcare">modsci:Healthcare</a>
    /// </summary>
    let Healthcare = _prefixId.prefix "Healthcare"
    let Historical_Studies = _prefixId.prefix "Historical_Studies"
    /// <summary>
    ///   <para>rdfs:label : History of Science^^xsd:string</para>
    ///   <para>rdfs:comment : The history of science is the study of the development of science and scientific knowledge, including both the natural and social sciences (the history of the arts and humanities is termed history of scholarship).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#History">modsci:History</a>
    /// </summary>
    let History = _prefixId.prefix "History"
    let HomologicalAlgebra = _prefixId.prefix "HomologicalAlgebra"
    let Horiba = _prefixId.prefix "Horiba"
    let HorticulturalProduction = _prefixId.prefix "HorticulturalProduction"
    /// <summary>
    ///   <para>rdfs:label : Human Computer Interaction^^xsd:string</para>
    ///   <para>rdfs:comment : Human–computer interaction (HCI) researches the design and use of computer technology, focused on the interfaces between people (users) and computers. Researchers in the field of HCI observe the ways in which humans interact with computers and design technologies that let humans interact with computers in novel ways.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#HumanComputerInteraction">modsci:HumanComputerInteraction</a>
    /// </summary>
    let HumanComputerInteraction = _prefixId.prefix "HumanComputerInteraction"
    /// <summary>
    ///   <para>rdfs:label : Human Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : Human science is a term applied to the investigation of human life and activities by a rational, systematic and verifiable methodology that acknowledges the validity of both data derived by impartial observation of sensory experience (objective phenomena) and data derived by means of impartial observation of psychological experience (subjective phenomena).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#HumanSciences">modsci:HumanSciences</a>
    /// </summary>
    let HumanSciences = _prefixId.prefix "HumanSciences"
    /// <summary>
    ///   <para>rdfs:label : Hydrology^^xsd:string</para>
    ///   <para>rdfs:comment : Hydrology is the scientific study of the movement, distribution, and quality of water on Earth and other planets, including the water cycle, water resources and environmental watershed sustainability.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Hydrology">modsci:Hydrology</a>
    /// </summary>
    let Hydrology = _prefixId.prefix "Hydrology"
    let Hydrometer = _prefixId.prefix "Hydrometer"
    /// <summary>
    ///   <para>rdfs:label : Image Processing^^xsd:string</para>
    ///   <para>rdfs:comment : In computer science, digital image processing is the use of computer algorithms to perform image processing on digital images.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ImageProcessing">modsci:ImageProcessing</a>
    /// </summary>
    let ImageProcessing = _prefixId.prefix "ImageProcessing"
    /// <summary>
    ///   <para>rdfs:label : Immunology^^xsd:string</para>
    ///   <para>rdfs:comment : Immunology is the study of the immune system and its reaction to pathogens, as well as its malfunctions (autoimmune diseases, allergies, rejection of organ transplants, immune deficiency).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Immunology">modsci:Immunology</a>
    /// </summary>
    let Immunology = _prefixId.prefix "Immunology"
    let Inclinometer = _prefixId.prefix "Inclinometer"
    /// <summary>
    ///   <para>rdfs:label : Industrial Process^^xsd:string</para>
    ///   <para>rdfs:comment : An industrial process alters materials or substances.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#IndustrialScience">modsci:IndustrialScience</a>
    /// </summary>
    let IndustrialScience = _prefixId.prefix "IndustrialScience"
    /// <summary>
    ///   <para>rdfs:label : Industry^^xsd:string</para>
    ///   <para>rdfs:comment : An industry is a sector that produces goods or related services within an economy.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Industry">modsci:Industry</a>
    /// </summary>
    let Industry = _prefixId.prefix "Industry"
    let InformationRetrieval = _prefixId.prefix "InformationRetrieval"
    /// <summary>
    ///   <para>rdfs:label : Information Science^^xsd:string</para>
    ///   <para>rdfs:comment : Information science is a field primarily concerned with the analysis, collection, classification, manipulation, storage, retrieval, movement, dissemination, and protection of information.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#InformationScience">modsci:InformationScience</a>
    /// </summary>
    let InformationScience = _prefixId.prefix "InformationScience"
    let InformationSystems = _prefixId.prefix "InformationSystems"
    let InformationSystemsManagement = _prefixId.prefix "InformationSystemsManagement"
    let InformationSystemsTheory = _prefixId.prefix "InformationSystemsTheory"
    /// <summary>
    ///   <para>rdfs:label : Information Visualization^^xsd:string</para>
    ///   <para>rdfs:comment : Information visualization or information visualisation is the study of (interactive) visual representations of abstract data to reinforce human cognition.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#InformationVisualization">modsci:InformationVisualization</a>
    /// </summary>
    let InformationVisualization = _prefixId.prefix "InformationVisualization"
    let Informetrics = _prefixId.prefix "Informetrics"
    /// <summary>
    ///   <para>rdfs:label : Inorganic Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Inorganic chemistry is a catch-all discipline that covers everything in chemistry that is not organic chemistry.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#InorganicChemistry">modsci:InorganicChemistry</a>
    /// </summary>
    let InorganicChemistry = _prefixId.prefix "InorganicChemistry"
    let InorganicGreenChemistry = _prefixId.prefix "InorganicGreenChemistry"
    /// <summary>
    ///   <para>rdfs:label : Instrument</para>
    ///   <para>rdfs:comment : A tool or implement, especially one for precision work.</para>
    ///   <a href="https://w3id.org/skgo/modsci#Instrument">modsci:Instrument</a>
    /// </summary>
    let Instrument = _prefixId.prefix "Instrument"
    let InstrumentFunctionDesription = _prefixId.prefix "InstrumentFunctionDesription"
    let IntegralEquations = _prefixId.prefix "IntegralEquations"
    /// <summary>
    ///   <para>rdfs:label : Interdisciplinary Studies^^xsd:string</para>
    ///   <para>rdfs:comment : Interdisciplinarity or interdisciplinary studies involves the combining of two or more academic disciplines into one activity (e.g., a research project).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#InterdisciplinaryStudies">modsci:InterdisciplinaryStudies</a>
    /// </summary>
    let InterdisciplinaryStudies = _prefixId.prefix "InterdisciplinaryStudies"
    let Interferometer = _prefixId.prefix "Interferometer"

    let InterorganisationalInformationSystems =
        _prefixId.prefix "InterorganisationalInformationSystems"

    let Isaac_Newton = _prefixId.prefix "Isaac_Newton"
    let Johann_Schweigger = _prefixId.prefix "Johann_Schweigger"
    let Julius_von_Mayer = _prefixId.prefix "Julius_von_Mayer"
    let KNN_Algorithm = _prefixId.prefix "KNN_Algorithm"
    let KnowledgeSystems = _prefixId.prefix "KnowledgeSystems"
    let LECO_Corporation = _prefixId.prefix "LECO_Corporation"
    /// <summary>
    ///   <para>rdfs:label : Laboratory Instrument</para>
    ///   <para>rdfs:comment : An instrument needed for operations in various laboratories, synthesis and analysis.</para>
    ///   <a href="https://w3id.org/skgo/modsci#LaboratoryInstrument">modsci:LaboratoryInstrument</a>
    /// </summary>
    let LaboratoryInstrument = _prefixId.prefix "LaboratoryInstrument"
    let Lasers = _prefixId.prefix "Lasers"
    /// <summary>
    ///   <para>rdfs:label : Library Science^^xsd:string</para>
    ///   <para>rdfs:comment : Library science is an interdisciplinary or multidisciplinary field that applies the practices, perspectives, and tools of management, information technology, education, and other areas to libraries; the collection, organization, preservation, and dissemination of information resources; and the political economy of information.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#LibraryScience">modsci:LibraryScience</a>
    /// </summary>
    let LibraryScience = _prefixId.prefix "LibraryScience"
    let Light_Bulb = _prefixId.prefix "Light_Bulb"
    let Light_magnification = _prefixId.prefix "Light_magnification"
    let Light_pillar = _prefixId.prefix "Light_pillar"
    /// <summary>
    ///   <para>rdfs:label : Limnology^^xsd:string</para>
    ///   <para>rdfs:comment : Limnology is a discipline that concerns the study of fresh waters, specifically natural and constructed lakes, ponds, streams, and rivers,^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Limnology">modsci:Limnology</a>
    /// </summary>
    let Limnology = _prefixId.prefix "Limnology"
    let Linear_Regression = _prefixId.prefix "Linear_Regression"
    /// <summary>
    ///   <para>rdfs:label : Linguistics^^xsd:string</para>
    ///   <para>rdfs:comment : Linguistics is the scientific study of language.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Linguistics">modsci:Linguistics</a>
    /// </summary>
    let Linguistics = _prefixId.prefix "Linguistics"
    /// <summary>
    ///   <para>rdfs:label : Logic^^xsd:string</para>
    ///   <para>rdfs:comment : Logic is the study of reasoning, or the study of the principles and criteria of valid inference and demonstration.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Logic">modsci:Logic</a>
    /// </summary>
    let Logic = _prefixId.prefix "Logic"
    /// <summary>
    ///   <para>rdfs:label : Machine Learning^^xsd:string</para>
    ///   <para>rdfs:comment : Machine learning (ML) is the scientific study of algorithms and statistical models that computer systems use to perform a specific task without using explicit instructions, relying on patterns and inference instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MachineLearning">modsci:MachineLearning</a>
    /// </summary>
    let MachineLearning = _prefixId.prefix "MachineLearning"
    let Magnetism = _prefixId.prefix "Magnetism"
    let Magnetograph = _prefixId.prefix "Magnetograph"
    let Magnetometer = _prefixId.prefix "Magnetometer"
    let MainGroupMetalChemistry = _prefixId.prefix "MainGroupMetalChemistry"
    let MalvernInstruments = _prefixId.prefix "MalvernInstruments"
    let Manometer = _prefixId.prefix "Manometer"
    /// <summary>
    ///   <para>rdfs:label : Marine Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Marine biology is the scientific study of organisms that live in the ocean^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MarineBiology">modsci:MarineBiology</a>
    /// </summary>
    let MarineBiology = _prefixId.prefix "MarineBiology"
    let MarkesInternational = _prefixId.prefix "MarkesInternational"
    let MarkupLanguages = _prefixId.prefix "MarkupLanguages"
    /// <summary>
    ///   <para>rdfs:label : Materials Science^^xsd:string</para>
    ///   <para>rdfs:comment : The interdisciplinary field of materials science is the design and discovery of new materials, particularly solids.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MaterialsChemistry">modsci:MaterialsChemistry</a>
    /// </summary>
    let MaterialsChemistry = _prefixId.prefix "MaterialsChemistry"

    /// <summary>
    ///   <para>rdfs:label : Mathematical and Theoretical Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Mathematical and theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MathematicalAndTheoreticalBiology">modsci:MathematicalAndTheoreticalBiology</a>
    /// </summary>
    let MathematicalAndTheoreticalBiology =
        _prefixId.prefix "MathematicalAndTheoreticalBiology"

    let MathematicalLogic = _prefixId.prefix "MathematicalLogic"
    /// <summary>
    ///   <para>rdfs:label : Mathematical Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Mathematical physics refers to the development of mathematical methods for application to problems in physics.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MathematicalPhysics">modsci:MathematicalPhysics</a>
    /// </summary>
    let MathematicalPhysics = _prefixId.prefix "MathematicalPhysics"
    let Mathematical_Studies = _prefixId.prefix "Mathematical_Studies"
    /// <summary>
    ///   <para>rdfs:label : Mathematics^^xsd:string</para>
    ///   <para>rdfs:comment : Mathematics (colloquially, maths, or math), is the body of knowledge centered on concepts such as quantity, structure, space, and change, and also the academic discipline that studies them.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Mathematics">modsci:Mathematics</a>
    /// </summary>
    let Mathematics = _prefixId.prefix "Mathematics"
    let McPhersonInc = _prefixId.prefix "McPhersonInc"
    /// <summary>
    ///   <para>rdfs:label : Measurement^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement is the assignment of a number to a characteristic of an object or event, which can be compared with other objects or events.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Measurement">modsci:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Mechanics^^xsd:string</para>
    ///   <para>rdfs:comment : Mechanics is the branch of science concerned with the behavior of physical bodies when subjected to forces or displacements, and the subsequent effects of the bodies on their environment.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Mechanics">modsci:Mechanics</a>
    /// </summary>
    let Mechanics = _prefixId.prefix "Mechanics"
    let MechanismsOfReactions = _prefixId.prefix "MechanismsOfReactions"
    /// <summary>
    ///   <para>rdfs:label : Medicinal Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Medicinal chemistry and pharmaceutical chemistry are disciplines at the intersection of chemistry, especially synthetic organic chemistry, and pharmacology and various other biological specialties, where they are involved with design, chemical synthesis and development for market of pharmaceutical agents, or bio-active molecules (drugs).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MedicinalChemistry">modsci:MedicinalChemistry</a>
    /// </summary>
    let MedicinalChemistry = _prefixId.prefix "MedicinalChemistry"
    /// <summary>
    ///   <para>rdfs:label : Medicine^^xsd:string</para>
    ///   <para>rdfs:comment : Medicine is a branch of health science concerned with maintaining human health and restoring it by treating disease and injury; it is both an area of knowledge, a science of body systems and diseases and their treatment, and the applied practice of that knowledge.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Medicine">modsci:Medicine</a>
    /// </summary>
    let Medicine = _prefixId.prefix "Medicine"
    /// <summary>
    ///   <para>rdfs:comment : Metabolism is the set of life-sustaining chemical reactions in organisms.^^xsd:string</para>
    ///   <para>rdfs:label : Metabolism^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Metabolism">modsci:Metabolism</a>
    /// </summary>
    let Metabolism = _prefixId.prefix "Metabolism"
    /// <summary>
    ///   <para>rdfs:label : Metallurgy^^xsd:string</para>
    ///   <para>rdfs:comment : Metallurgy is a domain of materials science and engineering that studies the physical and chemical behavior of metallic elements, their inter-metallic compounds, and their mixtures, which are called alloys.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Metallurgy">modsci:Metallurgy</a>
    /// </summary>
    let Metallurgy = _prefixId.prefix "Metallurgy"
    let MetamorphicPetrology = _prefixId.prefix "MetamorphicPetrology"
    /// <summary>
    ///   <para>rdfs:label : Meteorological Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MeteorologicalPhenomena">modsci:MeteorologicalPhenomena</a>
    /// </summary>
    let MeteorologicalPhenomena = _prefixId.prefix "MeteorologicalPhenomena"
    let MetrologicalChemistry = _prefixId.prefix "MetrologicalChemistry"
    /// <summary>
    ///   <para>rdfs:label : Metrology^^xsd:string</para>
    ///   <para>rdfs:comment : Metrology is the science of measurement.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Metrology">modsci:Metrology</a>
    /// </summary>
    let Metrology = _prefixId.prefix "Metrology"
    let Michael_Faraday = _prefixId.prefix "Michael_Faraday"
    let Micrometer = _prefixId.prefix "Micrometer"
    let Microscope = _prefixId.prefix "Microscope"
    /// <summary>
    ///   <para>rdfs:label : Military Science^^xsd:string</para>
    ///   <para>rdfs:comment : Military science is the study of military processes, dentsciitutions, and behavior, along with the study of warfare, and the theory and application of organized coercive force.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MilitaryScience">modsci:MilitaryScience</a>
    /// </summary>
    let MilitaryScience = _prefixId.prefix "MilitaryScience"
    let Mineralogy = _prefixId.prefix "Mineralogy"
    let MobileTechnologies = _prefixId.prefix "MobileTechnologies"
    /// <summary>
    ///   <para>rdfs:label : Science^^xsd:string</para>
    ///   <para>rdfs:comment : Science is a systematic enterprise that builds and organizes knowledge in the form of testable explanations and predictions about the universe.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ModernScience">modsci:ModernScience</a>
    /// </summary>
    let ModernScience = _prefixId.prefix "ModernScience"
    /// <summary>
    ///   <para>rdfs:label : Molecular Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Molecular biology is the study of biology at a molecular level.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MolecularBiology">modsci:MolecularBiology</a>
    /// </summary>
    let MolecularBiology = _prefixId.prefix "MolecularBiology"
    /// <summary>
    ///   <para>rdfs:label : Molecular Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Molecular physics deals with the physics and chemistry of molecules.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#MolecularPhysics">modsci:MolecularPhysics</a>
    /// </summary>
    let MolecularPhysics = _prefixId.prefix "MolecularPhysics"
    let Movie_camera = _prefixId.prefix "Movie_camera"
    let MultimediaProgramming = _prefixId.prefix "MultimediaProgramming"
    /// <summary>
    ///   <para>rdfs:label : Museology^^xsd:string</para>
    ///   <para>rdfs:comment : Museology or museum studies is the study of museums. It explores the history of museums and their role in society, as well as the activities they engage in, including curating, preservation, public programming, and education.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Museology">modsci:Museology</a>
    /// </summary>
    let Museology = _prefixId.prefix "Museology"
    let NASA = _prefixId.prefix "NASA"
    let Nanochemistry = _prefixId.prefix "Nanochemistry"
    /// <summary>
    ///   <para>rdfs:label : Natural language processing (NLP)^^xsd:string</para>
    ///   <para>rdfs:comment : Natural language processing (NLP) is a subfield of linguistics, computer science, information engineering, and artificial intelligence concerned with the interactions between computers and human (natural) languages, in particular how to program computers to process and analyze large amounts of natural language data.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#NaturalLanguageProcessing">modsci:NaturalLanguageProcessing</a>
    /// </summary>
    let NaturalLanguageProcessing = _prefixId.prefix "NaturalLanguageProcessing"
    /// <summary>
    ///   <para>rdfs:label : Natural Phenomenon</para>
    ///   <para>rdfs:comment : Natural phenomena include gravity, tides, biological processes and oscillation.</para>
    ///   <a href="https://w3id.org/skgo/modsci#NaturalPhenomenon">modsci:NaturalPhenomenon</a>
    /// </summary>
    let NaturalPhenomenon = _prefixId.prefix "NaturalPhenomenon"
    let NaturalProductsChemistry = _prefixId.prefix "NaturalProductsChemistry"
    /// <summary>
    ///   <para>rdfs:label : Natural Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : The natural sciences are those branches of empirical science that produce a comprehension of the natural world through the use of data collected from it by observation and measurement to construct deterministic and/or stochastic quantitative models of its phenomena.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#NaturalScience">modsci:NaturalScience</a>
    /// </summary>
    let NaturalScience = _prefixId.prefix "NaturalScience"
    /// <summary>
    ///   <para>rdfs:label : Networking^^xsd:string</para>
    ///   <para>rdfs:comment : A computer network is a digital telecommunications network which allows nodes to share resources.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Networking">modsci:Networking</a>
    /// </summary>
    let Networking = _prefixId.prefix "Networking"
    /// <summary>
    ///   <para>rdfs:label : Neural Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Neural engineering is a discipline within biomedical engineering that uses engineering techniques to understand, repair, replace, or enhance neural systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#NeuralEngineering">modsci:NeuralEngineering</a>
    /// </summary>
    let NeuralEngineering = _prefixId.prefix "NeuralEngineering"
    /// <summary>
    ///   <para>rdfs:label : Neuroscience^^xsd:string</para>
    ///   <para>rdfs:comment : Neuroscience is a field of study which deals with the structure, development, genetics, biochemistry, physiology, pharmacology and pathology of the nervous system.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Neuroscience">modsci:Neuroscience</a>
    /// </summary>
    let Neuroscience = _prefixId.prefix "Neuroscience"
    let Non_equilibriumProcesses = _prefixId.prefix "Non-equilibriumProcesses"
    let Non_metalChemistry = _prefixId.prefix "Non-metalChemistry"
    let NonlinearOptics = _prefixId.prefix "NonlinearOptics"
    let NovacamTechnologies = _prefixId.prefix "NovacamTechnologies"
    /// <summary>
    ///   <para>rdfs:label : Nuclear Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Nuclear chemistry is the subfield of chemistry dealing with radioactivity, nuclear processes, and transformations in the nuclei of atoms, such as nuclear transmutation and nuclear properties.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#NuclearChemistry">modsci:NuclearChemistry</a>
    /// </summary>
    let NuclearChemistry = _prefixId.prefix "NuclearChemistry"
    let NuclearPhysics = _prefixId.prefix "NuclearPhysics"
    let NumberTheory = _prefixId.prefix "NumberTheory"
    let NumericalAnalysis = _prefixId.prefix "NumericalAnalysis"
    /// <summary>
    ///   <para>rdfs:label : Nursing^^xsd:string</para>
    ///   <para>rdfs:comment : Nursing is a profession within the health care sector focused on the care of individuals, families, and communities so they may attain, maintain, or recover optimal health and quality of life.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Nursing">modsci:Nursing</a>
    /// </summary>
    let Nursing = _prefixId.prefix "Nursing"
    let Ocean_currents = _prefixId.prefix "Ocean_currents"
    /// <summary>
    ///   <para>rdfs:label : Oceanographic Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#OceanographicPhenomena">modsci:OceanographicPhenomena</a>
    /// </summary>
    let OceanographicPhenomena = _prefixId.prefix "OceanographicPhenomena"
    /// <summary>
    ///   <para>rdfs:label : Oceanography^^xsd:string</para>
    ///   <para>rdfs:comment : Oceanography also known as oceanology, is the study of the physical and biological aspects of the ocean.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Oceanography">modsci:Oceanography</a>
    /// </summary>
    let Oceanography = _prefixId.prefix "Oceanography"
    let Ohmmeter = _prefixId.prefix "Ohmmeter"
    let Olaus_Roemer = _prefixId.prefix "Olaus_Roemer"
    let OpenAI_Inc = _prefixId.prefix "OpenAI_Inc"
    /// <summary>
    ///   <para>rdfs:label : Operating Systems^^xsd:string</para>
    ///   <para>rdfs:comment : An operating system (OS) is system software that manages computer hardware, software resources, and provides common services for computer programs.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#OperatingSystems">modsci:OperatingSystems</a>
    /// </summary>
    let OperatingSystems = _prefixId.prefix "OperatingSystems"
    let OperationsResearch = _prefixId.prefix "OperationsResearch"
    let OpticalCommunications = _prefixId.prefix "OpticalCommunications"
    let OpticalPhysics = _prefixId.prefix "OpticalPhysics"
    /// <summary>
    ///   <para>rdfs:label : Optics^^xsd:string</para>
    ///   <para>rdfs:comment : Optics is the branch of physics that studies the behaviour and properties of light, including its interactions with matter and the construction of instruments that use or detect it.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Optics">modsci:Optics</a>
    /// </summary>
    let Optics = _prefixId.prefix "Optics"
    let Optimisation = _prefixId.prefix "Optimisation"
    let Optoelectronics = _prefixId.prefix "Optoelectronics"
    let OrdinaryDifferentialEquations = _prefixId.prefix "OrdinaryDifferentialEquations"
    let OreDepositPetrology = _prefixId.prefix "OreDepositPetrology"
    let OrganicChemicalSynthesis = _prefixId.prefix "OrganicChemicalSynthesis"
    /// <summary>
    ///   <para>rdfs:label : Organic Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Organic chemistry is the study of organic, or carbon based, molecules.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#OrganicChemistry">modsci:OrganicChemistry</a>
    /// </summary>
    let OrganicChemistry = _prefixId.prefix "OrganicChemistry"
    let OrganicGreenChemistry = _prefixId.prefix "OrganicGreenChemistry"
    /// <summary>
    ///   <para>rdfs:label : Organometallic Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Organometallic chemistry is the study of chemical compounds containing bonds between carbon and a metal.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#OrganometallicChemistry">modsci:OrganometallicChemistry</a>
    /// </summary>
    let OrganometallicChemistry = _prefixId.prefix "OrganometallicChemistry"
    let Oscilloscope = _prefixId.prefix "Oscilloscope"
    let Overpopulation = _prefixId.prefix "Overpopulation"
    let OxfordInstruments = _prefixId.prefix "OxfordInstruments"
    let Palaeomagnetism = _prefixId.prefix "Palaeomagnetism"
    let Palaeontology = _prefixId.prefix "Palaeontology"
    /// <summary>
    ///   <para>rdfs:label : Paleoclimatology^^xsd:string</para>
    ///   <para>rdfs:comment : Paleoclimatology is the study of climates for which systematic measurements were not taken.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Paleoclimatology">modsci:Paleoclimatology</a>
    /// </summary>
    let Paleoclimatology = _prefixId.prefix "Paleoclimatology"
    /// <summary>
    ///   <para>rdfs:label : Paleontology^^xsd:string</para>
    ///   <para>rdfs:comment : Paleontology is the study of the developing history of life on earth, of ancient plants and animals based on the fossil record, evidence of their existence preserved in rocks.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Paleontology">modsci:Paleontology</a>
    /// </summary>
    let Paleontology = _prefixId.prefix "Paleontology"
    let PallCorp = _prefixId.prefix "PallCorp"
    /// <summary>
    ///   <para>rdfs:label : Palynology^^xsd:string</para>
    ///   <para>rdfs:comment : Palynology is literally the "study of dust" or of "particles that are strewn".^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Palynology">modsci:Palynology</a>
    /// </summary>
    let Palynology = _prefixId.prefix "Palynology"
    /// <summary>
    ///   <para>rdfs:label : Parallel Computing^^xsd:string</para>
    ///   <para>rdfs:comment : Parallel computing is a type of computation in which many calculations or the execution of processes are carried out simultaneously.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ParallelComputing">modsci:ParallelComputing</a>
    /// </summary>
    let ParallelComputing = _prefixId.prefix "ParallelComputing"
    /// <summary>
    ///   <para>rdfs:label : Parasitology^^xsd:string</para>
    ///   <para>rdfs:comment : Parasitology is the study of parasites in host organisms, including humans (medical parasitology).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Parasitology">modsci:Parasitology</a>
    /// </summary>
    let Parasitology = _prefixId.prefix "Parasitology"
    let PartialDifferentialEquations = _prefixId.prefix "PartialDifferentialEquations"
    /// <summary>
    ///   <para>rdfs:label : Particle Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Particle physics is a branch of physics that studies the elementary constituents of matter and radiation, and the interactions between them.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ParticlePhysics">modsci:ParticlePhysics</a>
    /// </summary>
    let ParticlePhysics = _prefixId.prefix "ParticlePhysics"
    let PastureProduction = _prefixId.prefix "PastureProduction"
    let PatternRecognition = _prefixId.prefix "PatternRecognition"
    let PetroleumGeology = _prefixId.prefix "PetroleumGeology"
    /// <summary>
    ///   <para>rdfs:label : Pharmacology^^xsd:string</para>
    ///   <para>rdfs:comment : Pharmacology is the study of how chemical substances interact with living systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Pharmacology">modsci:Pharmacology</a>
    /// </summary>
    let Pharmacology = _prefixId.prefix "Pharmacology"
    /// <summary>
    ///   <para>rdfs:label : Pharmacy^^xsd:string</para>
    ///   <para>rdfs:comment : Pharmacy is the science and technique of preparing, dispensing, and reviewing drugs and providing additional clinical services.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Pharmacy">modsci:Pharmacy</a>
    /// </summary>
    let Pharmacy = _prefixId.prefix "Pharmacy"
    /// <summary>
    ///   <para>rdfs:label : Philosophy of Science^^xsd:string</para>
    ///   <para>rdfs:comment : Philosophy of science is a branch of philosophy concerned with the foundations, methods, and implications of science.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Philosophy">modsci:Philosophy</a>
    /// </summary>
    let Philosophy = _prefixId.prefix "Philosophy"
    let Phonograph = _prefixId.prefix "Phonograph"
    /// <summary>
    ///   <para>rdfs:label : Photochemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Photochemistry, a sub-discipline of chemistry, is the study of the interactions between atoms, small molecules, and light (or electromagnetic radiation).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Photochemistry">modsci:Photochemistry</a>
    /// </summary>
    let Photochemistry = _prefixId.prefix "Photochemistry"
    let Photonics = _prefixId.prefix "Photonics"
    /// <summary>
    ///   <para>rdfs:label : Phylogeny^^xsd:string</para>
    ///   <para>rdfs:comment : Phylogenetics is the study of the evolutionary history and relationships among individuals or groups of organisms.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Phylogeny">modsci:Phylogeny</a>
    /// </summary>
    let Phylogeny = _prefixId.prefix "Phylogeny"
    /// <summary>
    ///   <para>rdfs:label : Physical Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Physical chemistry is the study of macroscopic, atomic, subatomic, and particulate phenomena in chemical systems in terms of the principles, practices, and concepts of physics such as motion, energy, force, time, thermodynamics, quantum chemistry, statistical mechanics, analytical dynamics and chemical equilibrium.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PhysicalChemistry">modsci:PhysicalChemistry</a>
    /// </summary>
    let PhysicalChemistry = _prefixId.prefix "PhysicalChemistry"
    /// <summary>
    ///   <para>rdfs:label : Physical Geography^^xsd:string</para>
    ///   <para>rdfs:comment : Physical geography is a subfield of geography, closely related to geology, that focuses on the spatial characteristics of natural processes, within the hydrosphere, biosphere, atmosphere and lithosphere.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PhysicalGeography">modsci:PhysicalGeography</a>
    /// </summary>
    let PhysicalGeography = _prefixId.prefix "PhysicalGeography"
    let PhysicalOceanography = _prefixId.prefix "PhysicalOceanography"
    let PhysicalOrganicChemistry = _prefixId.prefix "PhysicalOrganicChemistry"
    /// <summary>
    ///   <para>rdfs:label : Physical Phenomena^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PhysicalPhenomena">modsci:PhysicalPhenomena</a>
    /// </summary>
    let PhysicalPhenomena = _prefixId.prefix "PhysicalPhenomena"
    let Physical_Studies = _prefixId.prefix "Physical_Studies"
    /// <summary>
    ///   <para>rdfs:label : Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Physics is the science of the natural world. It deals with matter, energy, and the fundamental forces that govern the interactions between particles.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Physics">modsci:Physics</a>
    /// </summary>
    let Physics = _prefixId.prefix "Physics"
    /// <summary>
    ///   <para>rdfs:label : Physiology^^xsd:string</para>
    ///   <para>rdfs:comment : Physiology is the branch of science that describes the mechanisms of cell, tissue and organ function in organisms.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Physiology">modsci:Physiology</a>
    /// </summary>
    let Physiology = _prefixId.prefix "Physiology"
    /// <summary>
    ///   <para>rdfs:label : Planetary Science^^xsd:string</para>
    ///   <para>rdfs:comment : Planetary science is a broad field of science that studies all planets.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PlanetaryScience">modsci:PlanetaryScience</a>
    /// </summary>
    let PlanetaryScience = _prefixId.prefix "PlanetaryScience"
    /// <summary>
    ///   <para>rdfs:label : Plasma Physics^^xsd:string</para>
    ///   <para>rdfs:comment : Plasma physics is the study of ionized gases.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PlasmaPhysics">modsci:PlasmaPhysics</a>
    /// </summary>
    let PlasmaPhysics = _prefixId.prefix "PlasmaPhysics"
    /// <summary>
    ///   <para>rdfs:label : Political Economy^^xsd:string</para>
    ///   <para>rdfs:comment : Political economy is the study of production and trade and their relations with law, custom and government; and with the distribution of national income and wealth.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PoliticalEconomy">modsci:PoliticalEconomy</a>
    /// </summary>
    let PoliticalEconomy = _prefixId.prefix "PoliticalEconomy"
    /// <summary>
    ///   <para>rdfs:label : Political Science^^xsd:string</para>
    ///   <para>rdfs:comment : Political science is a social science which deals with systems of governance, and the analysis of political activities, political thoughts, and political behavior.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#PoliticalScience">modsci:PoliticalScience</a>
    /// </summary>
    let PoliticalScience = _prefixId.prefix "PoliticalScience"
    let PolymerChar = _prefixId.prefix "PolymerChar"
    let PolymerisationMechanisms = _prefixId.prefix "PolymerisationMechanisms"
    let Population_decrease = _prefixId.prefix "Population_decrease"
    /// <summary>
    ///   <para>rdfs:label : Programming Language^^xsd:string</para>
    ///   <para>rdfs:comment : A programming language is a formal language, which comprises a set of instructions that produce various kinds of output. Programming languages are used in computer programming to implement algorithms.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ProgrammingLanguage">modsci:ProgrammingLanguage</a>
    /// </summary>
    let ProgrammingLanguage = _prefixId.prefix "ProgrammingLanguage"
    /// <summary>
    ///   <para>rdfs:label : Programming Language Theory^^xsd:string</para>
    ///   <para>rdfs:comment : Programming language theory (PLT) is a branch of computer science that deals with the design, implementation, analysis, characterization, and classification of programming languages and their individual features.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ProgrammingLanguageTheory">modsci:ProgrammingLanguageTheory</a>
    /// </summary>
    let ProgrammingLanguageTheory = _prefixId.prefix "ProgrammingLanguageTheory"
    /// <summary>
    ///   <para>rdfs:label : Programming Languages and Compilers^^xsd:string</para>
    ///   <para>rdfs:comment : Programming languages can be used to accomplish different tasks in different ways.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ProgrammingLanguages">modsci:ProgrammingLanguages</a>
    /// </summary>
    let ProgrammingLanguages = _prefixId.prefix "ProgrammingLanguages"
    let PsychiatricDrugs = _prefixId.prefix "PsychiatricDrugs"
    let Psychological_Studies = _prefixId.prefix "Psychological_Studies"
    /// <summary>
    ///   <para>rdfs:label : Psychology^^xsd:string</para>
    ///   <para>rdfs:comment : Psychology is a collection of academic, clinical and industrial disciplines concerned with the explanation and prediction of behavior, thinking, emotions, motivations, relationships, potentials and pathologies.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Psychology">modsci:Psychology</a>
    /// </summary>
    let Psychology = _prefixId.prefix "Psychology"
    let PureMathematics = _prefixId.prefix "PureMathematics"
    /// <summary>
    ///   <para>rdfs:label : Quantum Computing^^xsd:string</para>
    ///   <para>rdfs:comment : Quantum computing is the use of quantum-mechanical phenomena such as superposition and entanglement to perform computation. A quantum computer is used to perform such computation, which can be implemented theoretically or physically.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#QuantumComputing">modsci:QuantumComputing</a>
    /// </summary>
    let QuantumComputing = _prefixId.prefix "QuantumComputing"
    /// <summary>
    ///   <para>rdfs:label : Quantum Mechanics^^xsd:string</para>
    ///   <para>rdfs:comment : Quantum mechanics (also called quantum physics or quantum theory) is a physical theory that is believed to be the formalism underlying the description of all physical systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#QuantumMechanics">modsci:QuantumMechanics</a>
    /// </summary>
    let QuantumMechanics = _prefixId.prefix "QuantumMechanics"
    let QuantumOptics = _prefixId.prefix "QuantumOptics"
    let QuantumPhysics = _prefixId.prefix "QuantumPhysics"
    let Racism = _prefixId.prefix "Racism"
    let Radio_Signals = _prefixId.prefix "Radio_Signals"
    /// <summary>
    ///   <para>rdfs:label : Radiation Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Radiobiology is a field of clinical and basic medical sciences that involves the study of the action of ionizing radiation on living things, especially health effects of radiation.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Radiobiology">modsci:Radiobiology</a>
    /// </summary>
    let Radiobiology = _prefixId.prefix "Radiobiology"
    /// <summary>
    ///   <para>rdfs:label : Radiochemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Radiochemistry is the chemistry of radioactive materials, where radioactive isotopes of elements are used to study the properties and chemical reactions of non-radioactive isotopes (often within radiochemistry the absence of radioactivity leads to a substance being described as being inactive as the isotopes are stable).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Radiochemistry">modsci:Radiochemistry</a>
    /// </summary>
    let Radiochemistry = _prefixId.prefix "Radiochemistry"
    let Radiometrics = _prefixId.prefix "Radiometrics"
    let Rainbow = _prefixId.prefix "Rainbow"
    /// <summary>
    ///   <para>rdfs:label : Relational Databases^^xsd:string</para>
    ///   <para>rdfs:comment : A relational database is a digital database based on the relational model of data, as proposed by E. F. Codd in 1970.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#RelationalDatabases">modsci:RelationalDatabases</a>
    /// </summary>
    let RelationalDatabases = _prefixId.prefix "RelationalDatabases"
    let Resampling_Methods = _prefixId.prefix "Resampling_Methods"
    /// <summary>
    ///   <para>rdfs:label : Reverse Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Reverse engineering, also called back engineering, is the process by which a man-made object is deconstructed to reveal its designs, architecture, or to extract knowledge from the object; similar to scientific research, the only difference being that scientific research is about a natural phenomenon.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ReverseEngineering">modsci:ReverseEngineering</a>
    /// </summary>
    let ReverseEngineering = _prefixId.prefix "ReverseEngineering"
    /// <summary>
    ///   <para>rdfs:label : Robotics^^xsd:string</para>
    ///   <para>rdfs:comment : Robotics is an interdisciplinary branch of engineering and science that includes mechanical engineering, electronic engineering, information engineering, computer science, and others. Robotics deals with the design, construction, operation, and use of robots, as well as computer systems for their control, sensory feedback, and information processing.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Robotics">modsci:Robotics</a>
    /// </summary>
    let Robotics = _prefixId.prefix "Robotics"
    let Rusting = _prefixId.prefix "Rusting"
    /// <summary>
    ///   <para>rdfs:label : Science and Technology Studies^^xsd:string</para>
    ///   <para>rdfs:comment : Science and technology studies is the study of how society, politics, and culture affect scientific research and technological innovation, and how these, in turn, affect society, politics and culture.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScienceAndTechnologyStudies">modsci:ScienceAndTechnologyStudies</a>
    /// </summary>
    let ScienceAndTechnologyStudies = _prefixId.prefix "ScienceAndTechnologyStudies"
    /// <summary>
    ///   <para>rdfs:label : Science Studies^^xsd:string</para>
    ///   <para>rdfs:comment : Science studies is an interdisciplinary research area that seeks to situate scientific expertise in broad social, historical, and philosophical contexts.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScienceStudies">modsci:ScienceStudies</a>
    /// </summary>
    let ScienceStudies = _prefixId.prefix "ScienceStudies"
    /// <summary>
    ///   <para>rdfs:label : Scientific Discovery^^xsd:string</para>
    ///   <para>rdfs:comment : Scientific Discovery is the process or product of successful scientific inquiry. Objects of discovery can be things, events, processes, causes, and properties as well as theories and hypotheses and their features (their explanatory power, for example).^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScientificDiscovery">modsci:ScientificDiscovery</a>
    /// </summary>
    let ScientificDiscovery = _prefixId.prefix "ScientificDiscovery"
    /// <summary>
    ///   <para>skos:prefLabel : Instrument</para>
    ///   <para>rdfs:label : Scientific Instrument^^xsd:string</para>
    ///   <para>rdfs:comment : A scientific instrument is, broadly speaking, a device or tool used for scientific purposes, including the study of both natural phenomena and theoretical research.</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScientificInstrument">modsci:ScientificInstrument</a>
    /// </summary>
    let ScientificInstrument = _prefixId.prefix "ScientificInstrument"

    /// <summary>
    ///   <para>rdfs:label : Scientific Instrument Manufacturer^^xsd:string</para>
    ///   <para>rdfs:comment : Companies manufacturing equipment for scientific sstudies.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScientificInstrumentManufacturer">modsci:ScientificInstrumentManufacturer</a>
    /// </summary>
    let ScientificInstrumentManufacturer =
        _prefixId.prefix "ScientificInstrumentManufacturer"

    /// <summary>
    ///   <para>rdfs:label : Scientific Method^^xsd:string</para>
    ///   <para>rdfs:comment : A scientific method is a sequence or collection of processes that are considered characteristic of scientific investigation and the acquisition of new scientific knowledge based upon physical evidence.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScientificMethod">modsci:ScientificMethod</a>
    /// </summary>
    let ScientificMethod = _prefixId.prefix "ScientificMethod"
    /// <summary>
    ///   <para>rdfs:label : Scientific Modelling^^xsd:string</para>
    ///   <para>rdfs:comment : Scientific modelling is a scientific activity, the aim of which is to make a particular part or feature of the world easier to understand, define, quantify, visualize, or simulate by referencing it to existing and usually commonly accepted knowledge.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScientificModeling">modsci:ScientificModeling</a>
    /// </summary>
    let ScientificModeling = _prefixId.prefix "ScientificModeling"
    /// <summary>
    ///   <para>rdfs:label : Scientific Organization</para>
    ///   <para>rdfs:comment : An organization which is created for the purpose of scientific research and development.</para>
    ///   <a href="https://w3id.org/skgo/modsci#ScientificOrganization">modsci:ScientificOrganization</a>
    /// </summary>
    let ScientificOrganization = _prefixId.prefix "ScientificOrganization"
    /// <summary>
    ///   <para>rdfs:label : Scientist</para>
    ///   <para>rdfs:comment : A scientist is someone who conducts scientific research to advance knowledge in an area of interest.</para>
    ///   <a href="https://w3id.org/skgo/modsci#Scientist">modsci:Scientist</a>
    /// </summary>
    let Scientist = _prefixId.prefix "Scientist"
    let Sedimentology = _prefixId.prefix "Sedimentology"
    let SeismicExploration = _prefixId.prefix "SeismicExploration"
    let Seismology = _prefixId.prefix "Seismology"
    let Seismometer = _prefixId.prefix "Seismometer"
    /// <summary>
    ///   <para>rdfs:label : Semantics^^xsd:string</para>
    ///   <para>rdfs:comment : In programming language theory, semantics is the field concerned with the rigorous mathematical study of the meaning of programming languages. It does so by evaluating the meaning of syntactically valid strings defined by a specific programming language, showing the computation involved.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Semantics">modsci:Semantics</a>
    /// </summary>
    let Semantics = _prefixId.prefix "Semantics"
    /// <summary>
    ///   <para>rdfs:label : Semiotics^^xsd:string</para>
    ///   <para>rdfs:comment : Semiotics is the study of signs (symbols) and signification systems, or rather semiotics are general theories of signs.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Semiotics">modsci:Semiotics</a>
    /// </summary>
    let Semiotics = _prefixId.prefix "Semiotics"
    let SeparationScience = _prefixId.prefix "SeparationScience"
    let ShimadzuCorp = _prefixId.prefix "ShimadzuCorp"
    let Shrinkage = _prefixId.prefix "Shrinkage"
    /// <summary>
    ///   <para>rdfs:label : Social Phenomenon</para>
    ///   <para>rdfs:comment : Social phenomena are those that occur or exist through the actions of groups of humans.</para>
    ///   <a href="https://w3id.org/skgo/modsci#SocialPhenomenon">modsci:SocialPhenomenon</a>
    /// </summary>
    let SocialPhenomenon = _prefixId.prefix "SocialPhenomenon"
    /// <summary>
    ///   <para>rdfs:label : Social Psychology^^xsd:string</para>
    ///   <para>rdfs:comment : Social psychology is the scientific study of how people's thoughts, feelings, and behaviors are influenced by the actual, imagined or implied presence of others.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SocialPsychology">modsci:SocialPsychology</a>
    /// </summary>
    let SocialPsychology = _prefixId.prefix "SocialPsychology"
    /// <summary>
    ///   <para>rdfs:label : Social Sciences^^xsd:string</para>
    ///   <para>rdfs:comment : The social sciences are academic disciplines concerned with the study of the social life of human groups and individuals including anthropology, economics, geography, history, political science, psychology, social studies, and sociology.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SocialSciences">modsci:SocialSciences</a>
    /// </summary>
    let SocialSciences = _prefixId.prefix "SocialSciences"
    /// <summary>
    ///   <para>rdfs:label : Social Work^^xsd:string</para>
    ///   <para>rdfs:comment : Social work is an academic discipline and profession that concerns itself with individuals, families, groups and communities in an effort to enhance social functioning and overall well-being.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SocialWork">modsci:SocialWork</a>
    /// </summary>
    let SocialWork = _prefixId.prefix "SocialWork"
    /// <summary>
    ///   <para>rdfs:label : Sociobiology^^xsd:string</para>
    ///   <para>rdfs:comment : Sociobiology is a field of biology that aims to examine and explain social behavior in terms of evolution.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Sociobiology">modsci:Sociobiology</a>
    /// </summary>
    let Sociobiology = _prefixId.prefix "Sociobiology"
    /// <summary>
    ///   <para>rdfs:label : Sociology^^xsd:string</para>
    ///   <para>rdfs:comment : Sociology is the study of social behaviour or society, including its origins, development, organization, networks, and institutions. and critical analysis to develop a body of knowledge about social order, disorder, and change.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Sociology">modsci:Sociology</a>
    /// </summary>
    let Sociology = _prefixId.prefix "Sociology"
    /// <summary>
    ///   <para>rdfs:label : Soft Computing^^xsd:string</para>
    ///   <para>rdfs:comment : Soft computing, as opposed to traditional computing, deals with approximate models and gives solutions to complex real-life problems. Unlike hard computing, soft computing is tolerant of imprecision, uncertainty, partial truth, and approximations.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SoftComputing">modsci:SoftComputing</a>
    /// </summary>
    let SoftComputing = _prefixId.prefix "SoftComputing"
    /// <summary>
    ///   <para>rdfs:label : Software Engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Software engineering is the application of engineering to the development of software in a systematic method.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SoftwareEngineering">modsci:SoftwareEngineering</a>
    /// </summary>
    let SoftwareEngineering = _prefixId.prefix "SoftwareEngineering"
    /// <summary>
    ///   <para>rdfs:label : Soil Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Soil biology is the study of microbial and faunal activity and ecology in soil.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SoilBiology">modsci:SoilBiology</a>
    /// </summary>
    let SoilBiology = _prefixId.prefix "SoilBiology"
    /// <summary>
    ///   <para>rdfs:label : Soil Science^^xsd:string</para>
    ///   <para>rdfs:comment : Soil science is the study of soil as a natural resource on the surface of the Earth including soil formation, classification and mapping; physical, chemical, biological, and fertility properties of soils; and these properties in relation to the use and management of soils.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SoilScience">modsci:SoilScience</a>
    /// </summary>
    let SoilScience = _prefixId.prefix "SoilScience"
    let SoilSciences = _prefixId.prefix "SoilSciences"
    /// <summary>
    ///   <para>rdfs:label : Solid Mechanics^^xsd:string</para>
    ///   <para>rdfs:comment : Solid mechanics is a mathematical discipline within continuum mechanics, dealing with the mechanical behavior of solid materials.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SolidMechanics">modsci:SolidMechanics</a>
    /// </summary>
    let SolidMechanics = _prefixId.prefix "SolidMechanics"
    /// <summary>
    ///   <para>rdfs:label : Solid-State Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Solid-state chemistry, also sometimes referred as materials chemistry, is the study of the synthesis, structure, and properties of solid phase materials, particularly, but not necessarily exclusively of, non-molecular solids.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SolidStateChemistry">modsci:SolidStateChemistry</a>
    /// </summary>
    let SolidStateChemistry = _prefixId.prefix "SolidStateChemistry"
    let SolutionChemistry = _prefixId.prefix "SolutionChemistry"
    /// <summary>
    ///   <para>rdfs:label : Space Science^^xsd:string</para>
    ///   <para>rdfs:comment : Space science encompasses all of the scientific disciplines that involve space exploration and study natural phenomena and physical bodies occurring in outer space, such as space medicine and astrobiology.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SpaceScience">modsci:SpaceScience</a>
    /// </summary>
    let SpaceScience = _prefixId.prefix "SpaceScience"
    let Spectrogram = _prefixId.prefix "Spectrogram"
    let Spectrometer = _prefixId.prefix "Spectrometer"
    let Spectroscopy = _prefixId.prefix "Spectroscopy"
    let Speed_of_light = _prefixId.prefix "Speed_of_light"
    /// <summary>
    ///   <para>rdfs:label : Sports Science^^xsd:string</para>
    ///   <para>rdfs:comment : Sports science is a discipline that studies how the healthy human body works during exercise, and how sport and physical activity promote health and performance from cellular to whole body perspectives.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SportsScience">modsci:SportsScience</a>
    /// </summary>
    let SportsScience = _prefixId.prefix "SportsScience"
    /// <summary>
    ///   <para>rdfs:label : Statistics^^xsd:string</para>
    ///   <para>rdfs:comment : Statistics is the discipline that concerns the collection, organization, displaying, analysis, interpretation and presentation of data.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Statistics">modsci:Statistics</a>
    /// </summary>
    let Statistics = _prefixId.prefix "Statistics"
    let Statistics_Studies = _prefixId.prefix "Statistics_Studies"
    /// <summary>
    ///   <para>rdfs:label : Stellar Astronomy^^xsd:string</para>
    ///   <para>rdfs:comment : The study of stars and stellar evolution is fundamental to our understanding of the Universe.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#StellarAstronomy">modsci:StellarAstronomy</a>
    /// </summary>
    let StellarAstronomy = _prefixId.prefix "StellarAstronomy"
    /// <summary>
    ///   <para>rdfs:label : Stereochemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Stereochemistry, a subdiscipline of chemistry, involves the study of the relative spatial arrangement of atoms that form the structure of molecules and their manipulation.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Stereochemistry">modsci:Stereochemistry</a>
    /// </summary>
    let Stereochemistry = _prefixId.prefix "Stereochemistry"
    let Storm = _prefixId.prefix "Storm"
    let Stratigraphy = _prefixId.prefix "Stratigraphy"
    let StructuralChemistry = _prefixId.prefix "StructuralChemistry"
    let StructuralGeology = _prefixId.prefix "StructuralGeology"
    /// <summary>
    ///   <para>rdfs:label : Structured Storage^^xsd:string</para>
    ///   <para>rdfs:comment : Structured storage is computer storage for structured data, often in the form of a distributed database.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#StructuredStorage">modsci:StructuredStorage</a>
    /// </summary>
    let StructuredStorage = _prefixId.prefix "StructuredStorage"

    let Studying_biochemical_reactions =
        _prefixId.prefix "Studying_biochemical_reactions"

    let Subset_Selection = _prefixId.prefix "Subset_Selection"
    let Subsun = _prefixId.prefix "Subsun"
    let Supernova = _prefixId.prefix "Supernova"
    let Support_Vector_Machines = _prefixId.prefix "Support_Vector_Machines"
    /// <summary>
    ///   <para>rdfs:label : Supramolecular Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Supramolecular chemistry is a branch of chemistry that describes self-organization or self-assembly of systems to well-defined molecular architectures.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SupramolecularChemistry">modsci:SupramolecularChemistry</a>
    /// </summary>
    let SupramolecularChemistry = _prefixId.prefix "SupramolecularChemistry"
    /// <summary>
    ///   <para>rdfs:label : Surface Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Surface chemistry is the study of chemical phenomena that occur at the interface of two phases^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SurfaceChemistry">modsci:SurfaceChemistry</a>
    /// </summary>
    let SurfaceChemistry = _prefixId.prefix "SurfaceChemistry"
    let SynthesisOfMaterials = _prefixId.prefix "SynthesisOfMaterials"
    /// <summary>
    ///   <para>rdfs:label : Systems Science^^xsd:string</para>
    ///   <para>rdfs:comment : Systems science is the field of science surrounding systems theory, cybernetics, the science of complex systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#SystemsScience">modsci:SystemsScience</a>
    /// </summary>
    let SystemsScience = _prefixId.prefix "SystemsScience"
    /// <summary>
    ///   <para>rdfs:label : Technology^^xsd:string</para>
    ///   <para>rdfs:comment : Technology is the collection of techniques, skills, methods, and processes used in the production of goods or services or in the accomplishment of objectives, such as scientific investigation.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Technology">modsci:Technology</a>
    /// </summary>
    let Technology = _prefixId.prefix "Technology"
    let Techtron = _prefixId.prefix "Techtron"
    let Tectonics = _prefixId.prefix "Tectonics"
    let Telescope = _prefixId.prefix "Telescope"
    let The_Bridges_Organization = _prefixId.prefix "The_Bridges_Organization"
    let The_Fibonacci_Association = _prefixId.prefix "The_Fibonacci_Association"
    let Theodolite = _prefixId.prefix "Theodolite"
    /// <summary>
    ///   <para>rdfs:label : Theoretical Biology^^xsd:string</para>
    ///   <para>rdfs:comment : Theoretical biology is a branch of biology which employs theoretical analysis, mathematical models and abstractions of the living organisms to investigate the principles that govern the structure, development and behavior of the systems^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#TheoreticalBiology">modsci:TheoreticalBiology</a>
    /// </summary>
    let TheoreticalBiology = _prefixId.prefix "TheoreticalBiology"
    /// <summary>
    ///   <para>rdfs:label : Theoretical Chemistry^^xsd:string</para>
    ///   <para>rdfs:comment : Theoretical chemistry is the application of theoretical reasoning to chemistry.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#TheoreticalChemistry">modsci:TheoreticalChemistry</a>
    /// </summary>
    let TheoreticalChemistry = _prefixId.prefix "TheoreticalChemistry"
    let TheoreticalComputerScience = _prefixId.prefix "TheoreticalComputerScience"
    /// <summary>
    ///   <para>rdfs:label : Theoretical Linguistics^^xsd:string</para>
    ///   <para>rdfs:comment : Theoretical linguistics, or general linguistics, is the branch of linguistics which inquires into the nature of language itself and seeks to answer fundamental questions as to what language is; how it works; how universal grammar (UG) as a domain-specific mental organ operates, if it exists at all; what are its unique properties; how does language relate to other cognitive processes, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#TheoreticalLinguistics">modsci:TheoreticalLinguistics</a>
    /// </summary>
    let TheoreticalLinguistics = _prefixId.prefix "TheoreticalLinguistics"
    let TheoryAndDesignOfMaterials = _prefixId.prefix "TheoryAndDesignOfMaterials"
    /// <summary>
    ///   <para>rdfs:label : Theory of Computation^^xsd:string</para>
    ///   <para>rdfs:comment : Theory of computation is focused on answering fundamental questions about what can be computed and what amount of resources are required to perform those computations.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#TheoryOfComputation">modsci:TheoryOfComputation</a>
    /// </summary>
    let TheoryOfComputation = _prefixId.prefix "TheoryOfComputation"
    let Thermocouple = _prefixId.prefix "Thermocouple"
    /// <summary>
    ///   <para>rdfs:label : Thermodynamics^^xsd:string</para>
    ///   <para>rdfs:comment : Thermodynamics concerns the physics of heat, work, temperature, energy, and entropy.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Thermodynamics">modsci:Thermodynamics</a>
    /// </summary>
    let Thermodynamics = _prefixId.prefix "Thermodynamics"
    let Thermometer = _prefixId.prefix "Thermometer"
    let Thomas_Edison = _prefixId.prefix "Thomas_Edison"
    let Time_Series_Analysis = _prefixId.prefix "Time_Series_Analysis"
    let Topology = _prefixId.prefix "Topology"
    /// <summary>
    ///   <para>rdfs:label : Toxicology^^xsd:string</para>
    ///   <para>rdfs:comment : Toxicology is a scientific discipline, overlapping with biology, chemistry, pharmacology, and medicine, that involves the study of the adverse effects of chemical substances on living organisms and the practice of diagnosing and treating exposures to toxins and toxicants.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Toxicology">modsci:Toxicology</a>
    /// </summary>
    let Toxicology = _prefixId.prefix "Toxicology"
    /// <summary>
    ///   <para>rdfs:label : Transdisciplinarity^^xsd:string</para>
    ///   <para>rdfs:comment : Transdisciplinarity connotes a research strategy that crosses many disciplinary boundaries to create a holistic approach.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Transdisciplinarity">modsci:Transdisciplinarity</a>
    /// </summary>
    let Transdisciplinarity = _prefixId.prefix "Transdisciplinarity"
    let TransitionMetalChemistry = _prefixId.prefix "TransitionMetalChemistry"
    let Tsunamis = _prefixId.prefix "Tsunamis"
    /// <summary>
    ///   <para>rdfs:label : Type Theory^^xsd:string</para>
    ///   <para>rdfs:comment : In mathematics, logic, and computer science, a type theory is any of a class of formal systems, some of which can serve as alternatives to set theory as a foundation for all mathematics. In type theory, every "term" has a "type" and operations are restricted to terms of a certain type.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#TypeTheory">modsci:TypeTheory</a>
    /// </summary>
    let TypeTheory = _prefixId.prefix "TypeTheory"
    let UbiquitousComputing = _prefixId.prefix "UbiquitousComputing"
    let UniversalAlgebra = _prefixId.prefix "UniversalAlgebra"
    /// <summary>
    ///   <para>rdfs:label : Urban Planning^^xsd:string</para>
    ///   <para>rdfs:comment : Urban planning is a technical and political process concerned with the development and design of land use and the built environment, including air, water, and the infrastructure passing into and out of urban areas, such as transportation, communications, and distribution networks.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#UrbanPlanning">modsci:UrbanPlanning</a>
    /// </summary>
    let UrbanPlanning = _prefixId.prefix "UrbanPlanning"
    /// <summary>
    ///   <para>rdfs:label : Veterinary Medicine^^xsd:string</para>
    ///   <para>rdfs:comment : Veterinary medicine is the branch of medicine that deals with the prevention, diagnosis and treatment of disease, disorder and injury in animals.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#VeterinaryMedicine">modsci:VeterinaryMedicine</a>
    /// </summary>
    let VeterinaryMedicine = _prefixId.prefix "VeterinaryMedicine"
    let VeterinarySciences = _prefixId.prefix "VeterinarySciences"
    let VirtualReality = _prefixId.prefix "VirtualReality"
    let Volcano = _prefixId.prefix "Volcano"
    /// <summary>
    ///   <para>rdfs:label : Volcanology^^xsd:string</para>
    ///   <para>rdfs:comment : Volcanology is a branch of geology that deals with the study of volcanoes, lava, magma, and related geological phenomena.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Volcanology">modsci:Volcanology</a>
    /// </summary>
    let Volcanology = _prefixId.prefix "Volcanology"
    let Voltmeter = _prefixId.prefix "Voltmeter"
    let Waldemar_Jungner = _prefixId.prefix "Waldemar_Jungner"
    let WatersCorporation = _prefixId.prefix "WatersCorporation"
    let Waves = _prefixId.prefix "Waves"
    let WebSearch = _prefixId.prefix "WebSearch"
    let WebServices = _prefixId.prefix "WebServices"
    let WebTechnologies = _prefixId.prefix "WebTechnologies"
    let Weddings = _prefixId.prefix "Weddings"
    /// <summary>
    ///   <para>rdfs:label : Zoology^^xsd:string</para>
    ///   <para>rdfs:comment : Zoology is the study of the biology of animals.^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#Zoology">modsci:Zoology</a>
    /// </summary>
    let Zoology = _prefixId.prefix "Zoology"
    let appliesLawsFrom = _prefixId.prefix "appliesLawsFrom"
    let appliesLawsFromMathematics = _prefixId.prefix "appliesLawsFromMathematics"
    let appliesLawsFromPhysics = _prefixId.prefix "appliesLawsFromPhysics"
    let appliesLawsFromStatistics = _prefixId.prefix "appliesLawsFromStatistics"
    let appliesLawsFromThermodynamics = _prefixId.prefix "appliesLawsFromThermodynamics"
    let discoveredByAppliedSciences = _prefixId.prefix "discoveredByAppliedSciences"

    let discoveredByBehaviouralSciences =
        _prefixId.prefix "discoveredByBehaviouralSciences"

    let discoveredByFormalScience = _prefixId.prefix "discoveredByFormalScience"
    let discoveredByHealthSciences = _prefixId.prefix "discoveredByHealthSciences"

    let discoveredByInterdisciplinaryStudies =
        _prefixId.prefix "discoveredByInterdisciplinaryStudies"

    let discoveredByMachine = _prefixId.prefix "discoveredByMachine"
    let discoveredByNaturalScience = _prefixId.prefix "discoveredByNaturalScience"
    let discoveredByScience = _prefixId.prefix "discoveredByScience"
    let discoveredByScientist = _prefixId.prefix "discoveredByScientist"
    let discoveredBySocialSciences = _prefixId.prefix "discoveredBySocialSciences"
    let f_BlockChemistry = _prefixId.prefix "f-BlockChemistry"
    let followsMethod = _prefixId.prefix "followsMethod"
    let hasApplication = _prefixId.prefix "hasApplication"
    let hasCloseRelationshipTo = _prefixId.prefix "hasCloseRelationshipTo"
    let hasCollaborationWith = _prefixId.prefix "hasCollaborationWith"
    let hasManufacturer = _prefixId.prefix "hasManufacturer"
    let hasMethodsInspiredFrom = _prefixId.prefix "hasMethodsInspiredFrom"

    let hasScientificInstrumentManufacturer =
        _prefixId.prefix "hasScientificInstrumentManufacturer"

    let inspiredFrom = _prefixId.prefix "inspiredFrom"
    let inspiredFromPhenomenon = _prefixId.prefix "inspiredFromPhenomenon"

    let inspiredFromScientificDiscovery =
        _prefixId.prefix "inspiredFromScientificDiscovery"

    let instrumentInventedBy = _prefixId.prefix "instrumentInventedBy"
    /// <summary>
    ///   <para>rdfs:label : instrument used in Science^^xsd:string</para>
    ///   <a href="https://w3id.org/skgo/modsci#instrumentUsedInScience">modsci:instrumentUsedInScience</a>
    /// </summary>
    let instrumentUsedInScience = _prefixId.prefix "instrumentUsedInScience"
    let interestedInPhenomenon = _prefixId.prefix "interestedInPhenomenon"
    let isApplicationOfAppliedScience = _prefixId.prefix "isApplicationOfAppliedScience"

    let isApplicationOfBehaviouralSciences =
        _prefixId.prefix "isApplicationOfBehaviouralSciences"

    let isApplicationOfFormalScience = _prefixId.prefix "isApplicationOfFormalScience"
    let isApplicationOfHealthSciences = _prefixId.prefix "isApplicationOfHealthSciences"

    let isApplicationOfInterdisciplinaryStudies =
        _prefixId.prefix "isApplicationOfInterdisciplinaryStudies"

    let isApplicationOfNaturalScience = _prefixId.prefix "isApplicationOfNaturalScience"
    let isApplicationOfScience = _prefixId.prefix "isApplicationOfScience"
    let isApplicationOfSocialSciences = _prefixId.prefix "isApplicationOfSocialSciences"
    let isDiscoveredBy = _prefixId.prefix "isDiscoveredBy"
    let isDiscoveredByOrganization = _prefixId.prefix "isDiscoveredByOrganization"
    let isDiscoveredByScientist = _prefixId.prefix "isDiscoveredByScientist"
    let isManufacturerOf = _prefixId.prefix "isManufacturerOf"
    let isStudentOf = _prefixId.prefix "isStudentOf"
    let requiresKnowledgeFrom = _prefixId.prefix "requiresKnowledgeFrom"
    let scientistBelongsTo = _prefixId.prefix "scientistBelongsTo"
    let study_of_wetlands = _prefixId.prefix "study_of_wetlands"
    let suppliesSubstancesTo = _prefixId.prefix "suppliesSubstancesTo"
    let takeSunstancesFrom = _prefixId.prefix "takeSunstancesFrom"
    let temperature_gradient = _prefixId.prefix "temperature_gradient"
    let undertakesResearch = _prefixId.prefix "undertakesResearch"
    let usesMethodsFrom = _prefixId.prefix "usesMethodsFrom"
    let usesTechniquesFrom = _prefixId.prefix "usesTechniquesFrom"
    let x = _prefixId.prefix "x"
    let y = _prefixId.prefix "y"
    let z = _prefixId.prefix "z"
