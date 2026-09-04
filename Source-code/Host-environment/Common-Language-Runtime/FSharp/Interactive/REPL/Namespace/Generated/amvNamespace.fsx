#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module amv =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/amv#" "amv"
    let ``_1.0.0`` = _prefixId.prefix "1.0.0"
    let ``A*Algorithm`` = _prefixId.prefix "A*Algorithm"
    let ``A*SpaceComplexity`` = _prefixId.prefix "A*SpaceComplexity"
    let ``A*TimeComplexity`` = _prefixId.prefix "A*TimeComplexity"

    let AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths =
        _prefixId.prefix "AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths"

    let Ada = _prefixId.prefix "Ada"
    /// <summary>
    ///   <para>rdfs:comment : It is a finite and unambiguous sequence of computer implementable instructions to perform a certain task. This can be a simple process, such as adding two numbers together, or a complex function, such as adding effects to an image. It can be expressed within a finite amount of space and time and in a well-defined formal language.</para>
    ///   <para>rdfs:label : Algorithm^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#Algorithm">amv:Algorithm</a>
    /// </summary>
    let Algorithm = _prefixId.prefix "Algorithm"
    let Algorithm232_HeapSort = _prefixId.prefix "Algorithm232-HeapSort"
    let Algorithm64Quicksort = _prefixId.prefix "Algorithm64:Quicksort"
    /// <summary>
    ///   <para>rdfs:label : AlgorithmAnalysisFunction</para>
    ///   <para>rdfs:comment : Time complexity corresponds to the amount of time required for an algorithm to run over the provided input in order to generate the required output. Analysis of this helps to predict the resources that an algorithm will take to finish execution.</para>
    ///   <a href="https://w3id.org/amv#AlgorithmAnalysisFunction">amv:AlgorithmAnalysisFunction</a>
    /// </summary>
    let AlgorithmAnalysisFunction = _prefixId.prefix "AlgorithmAnalysisFunction"
    /// <summary>
    ///   <para>rdfs:label : Algorithmic Type</para>
    ///   <para>rdfs:comment : The different type of algorithmic techniques that are used to solve the various existing problems in the most optimized manner.
    /// This classification is neither exhaustive nor disjoint.</para>
    ///   <a href="https://w3id.org/amv#AlgorithmicType">amv:AlgorithmicType</a>
    /// </summary>
    let AlgorithmicType = _prefixId.prefix "AlgorithmicType"
    let Apache = _prefixId.prefix "Apache"
    let ApproximationAlgortihm = _prefixId.prefix "ApproximationAlgortihm"
    let ArneKutzner = _prefixId.prefix "ArneKutzner"
    let Array = _prefixId.prefix "Array"
    let AssignmentProblem = _prefixId.prefix "AssignmentProblem"
    let AtandTBellLaboratories = _prefixId.prefix "At&TBellLaboratories"
    let BacktrackingAlgorithm = _prefixId.prefix "BacktrackingAlgorithm"
    let Basic = _prefixId.prefix "Basic"
    let BeadSort = _prefixId.prefix "BeadSort"
    let BeadSort_L = _prefixId.prefix "BeadSort-L"
    let BeadSort_R = _prefixId.prefix "BeadSort-R"

    let BeadSortANaturalSortingAlgorithm =
        _prefixId.prefix "BeadSort:ANaturalSortingAlgorithm"

    let BeadSortInPython = _prefixId.prefix "BeadSortInPython"
    let BeadSortSpaceComplexity = _prefixId.prefix "BeadSortSpaceComplexity"
    let BeadSortTimeComplexity = _prefixId.prefix "BeadSortTimeComplexity"
    let BellmanFordAlgorithm = _prefixId.prefix "BellmanFordAlgorithm"
    let BellmanFordSpaceComplexity = _prefixId.prefix "BellmanFordSpaceComplexity"
    let BellmanFordTimeComplexity = _prefixId.prefix "BellmanFordTimeComplexity"
    let BellmanFormPerformanceMetric = _prefixId.prefix "BellmanFormPerformanceMetric"
    let BertramRaphael = _prefixId.prefix "BertramRaphael"
    let BestBinFirst = _prefixId.prefix "BestBinFirst"
    let BlockSort = _prefixId.prefix "BlockSort"
    let BlockSortSpaceComplexity = _prefixId.prefix "BlockSortSpaceComplexity"
    let BlockSortTimeComplexity = _prefixId.prefix "BlockSortTimeComplexity"
    let BranchAndBoundAlgorithm = _prefixId.prefix "BranchAndBoundAlgorithm"
    let BruteForceAlgorithm = _prefixId.prefix "BruteForceAlgorithm"
    let BubbleSort = _prefixId.prefix "BubbleSort"

    let BubbleSortPseudocodeImplementation =
        _prefixId.prefix "BubbleSortPseudocodeImplementation"

    let BubbleSortSpaceComplexity = _prefixId.prefix "BubbleSortSpaceComplexity"
    let BubbleSortTimeComplexity = _prefixId.prefix "BubbleSortTimeComplexity"
    let C = _prefixId.prefix "C"
    let ``C++`` = _prefixId.prefix "C++"
    let CARHoare = _prefixId.prefix "CARHoare"
    let ChristofidesAlgorithm = _prefixId.prefix "ChristofidesAlgorithm"
    let CodeForDijkstrasAlgorithm = _prefixId.prefix "CodeForDijkstrasAlgorithm"

    /// <summary>
    ///   <para>rdfs:label : Combinatorial optimization problem</para>
    ///   <a href="https://w3id.org/amv#CombinatorialOptimizationProblem">amv:CombinatorialOptimizationProblem</a>
    /// </summary>
    let CombinatorialOptimizationProblem =
        _prefixId.prefix "CombinatorialOptimizationProblem"

    /// <summary>
    ///   <para>rdfs:label : Combinatorial Problem^^xsd:string</para>
    ///   <para>rdfs:comment : Combinatorial algorithms are computational procedures which are designed to help solve combinatorial problems. Combinatorial problems are problems involving arrangements of elements from a finite set and selections from a finite set.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#CombinatorialProblem">amv:CombinatorialProblem</a>
    /// </summary>
    let CombinatorialProblem = _prefixId.prefix "CombinatorialProblem"
    /// <summary>
    ///   <para>rdfs:label : Computational Geometry Problem</para>
    ///   <para>rdfs:comment : Computational geometry is a branch of computer science devoted to the study of algorithms which can be stated in terms of geometry. Some purely geometrical problems arise out of the study of computational geometric algorithms, and such problems are also considered to be part of computational geometry.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#ComputationalGeometryProblem">amv:ComputationalGeometryProblem</a>
    /// </summary>
    let ComputationalGeometryProblem = _prefixId.prefix "ComputationalGeometryProblem"
    let ComputerProgram = _prefixId.prefix "ComputerProgram"
    let ComputerScience = _prefixId.prefix "ComputerScience"
    let ConstantFunctions = _prefixId.prefix "ConstantFunctions"
    let ControlTable = _prefixId.prefix "ControlTable"
    let Copyleft = _prefixId.prefix "Copyleft"

    let ``CreativeCommonsAttribution3.0`` =
        _prefixId.prefix "CreativeCommonsAttribution3.0"

    let ``CreativeCommonsAttribution4.0`` =
        _prefixId.prefix "CreativeCommonsAttribution4.0"

    let CristianSCalude = _prefixId.prefix "CristianSCalude"
    let CubicFunctionsAndPolynomials = _prefixId.prefix "CubicFunctionsAndPolynomials"
    let DataExtractionFromSbr = _prefixId.prefix "DataExtractionFromSbr"
    let DataExtractionImplementation = _prefixId.prefix "DataExtractionImplementation"
    /// <summary>
    ///   <para>rdfs:label : Data Structure^^xsd:string</para>
    ///   <para>rdfs:comment : A data structure is a named location that can be used to store and organize data.</para>
    ///   <a href="https://w3id.org/amv#DataStructure">amv:DataStructure</a>
    /// </summary>
    let DataStructure = _prefixId.prefix "DataStructure"
    /// <summary>
    ///   <para>rdfs:label : Data Structures Problem</para>
    ///   <para>rdfs:comment : Solving problems related to data structure i.e  a particular way of organizing data in a computer so that it can be used effectively.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#DataStructuresProblem">amv:DataStructuresProblem</a>
    /// </summary>
    let DataStructuresProblem = _prefixId.prefix "DataStructuresProblem"

    let DecodingRecurrentNeuralNetwork =
        _prefixId.prefix "DecodingRecurrentNeuralNetwork"

    let DecodingTargetLanguage = _prefixId.prefix "DecodingTargetLanguage"
    let DelbertRayFulkerson = _prefixId.prefix "DelbertRayFulkerson"
    let DerrickHenryLehmer = _prefixId.prefix "DerrickHenryLehmer"
    let Dictionary = _prefixId.prefix "Dictionary"
    let DifferentialCalculus = _prefixId.prefix "DifferentialCalculus"

    let DijkastrasAlgorithmTimeComplexity =
        _prefixId.prefix "DijkastrasAlgorithmTimeComplexity"

    let DijkstrasAlgorithm = _prefixId.prefix "DijkstrasAlgorithm"
    let DivideAndConquerAlgorithm = _prefixId.prefix "DivideAndConquerAlgorithm"
    let DoWhile = _prefixId.prefix "DoWhile"
    let DonaldKnuth = _prefixId.prefix "DonaldKnuth"
    let Drakon_chart = _prefixId.prefix "Drakon-chart"
    let DynamicProgrammingAlgorithm = _prefixId.prefix "DynamicProgrammingAlgorithm"
    let EdouardLucas = _prefixId.prefix "EdouardLucas"
    let EdsgerWDijkstra = _prefixId.prefix "EdsgerWDijkstra"
    let EdwardWForgy = _prefixId.prefix "EdwardWForgy"
    let EncoRNNTimeCom1 = _prefixId.prefix "EncoRNNTimeCom1"
    let EncoderDecoder = _prefixId.prefix "EncoderDecoder"
    let EncoderDecoderTimeComplexity = _prefixId.prefix "EncoderDecoderTimeComplexity"

    let EncodingRecurrentNeuralNetwork =
        _prefixId.prefix "EncodingRecurrentNeuralNetwork"

    let EncodingSourceLanguage = _prefixId.prefix "EncodingSourceLanguage"
    let ExponentialFunctions = _prefixId.prefix "ExponentialFunctions"
    let FastMultipoleMethod = _prefixId.prefix "FastMultipoleMethod"
    let FindingAMatch = _prefixId.prefix "FindingAMatch"
    let Flowchart = _prefixId.prefix "Flowchart"
    let For = _prefixId.prefix "For"
    /// <summary>
    ///   <para>rdfs:label : Form of expression</para>
    ///   <para>rdfs:comment : The available form of expression/ notation of an algorithm. For example, Flowcharts, pseudocode, control tables, etc. (source: https://en.wikipedia.org/wiki/Algorithm)</para>
    ///   <a href="https://w3id.org/amv#FormOfExpression">amv:FormOfExpression</a>
    /// </summary>
    let FormOfExpression = _prefixId.prefix "FormOfExpression"
    let Fortran = _prefixId.prefix "Fortran"
    let GNU = _prefixId.prefix "GNU"
    let GPL = _prefixId.prefix "GPL"
    let GaussianElimination = _prefixId.prefix "GaussianElimination"
    let GeorgeDantzig = _prefixId.prefix "GeorgeDantzig"
    let Graph = _prefixId.prefix "Graph"
    let GraphDataStructure = _prefixId.prefix "GraphDataStructure"
    /// <summary>
    ///   <para>rdfs:label : Graph Problem</para>
    ///   <para>rdfs:comment : A Graph is a non-linear data structure consisting of nodes and edges. The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#GraphProblem">amv:GraphProblem</a>
    /// </summary>
    let GraphProblem = _prefixId.prefix "GraphProblem"
    let GraphTheory = _prefixId.prefix "GraphTheory"
    let GreedyAlgorithm = _prefixId.prefix "GreedyAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : Hard Problem</para>
    ///   <para>rdfs:comment : Any graph problem, which is NP-hard in general graphs, becomes polynomial-time solvable when restricted to graphs in special
    /// classes.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#HardProblem">amv:HardProblem</a>
    /// </summary>
    let HardProblem = _prefixId.prefix "HardProblem"
    let HashTable = _prefixId.prefix "HashTable"
    let HeapSort = _prefixId.prefix "HeapSort"
    let HeapSortSpaceComplexity = _prefixId.prefix "HeapSortSpaceComplexity"
    let HeapSortTimeComplexity = _prefixId.prefix "HeapSortTimeComplexity"
    let Hypergraph = _prefixId.prefix "Hypergraph"
    let IlyaSutskever = _prefixId.prefix "IlyaSutskever"
    /// <summary>
    ///   <para>rdfs:label : Implementation</para>
    ///   <para>rdfs:comment : A manifestation of a technical specification or algorithm as a program, software component, or other computer system through computer programming and deployment (source: https://en.wikipedia.org/wiki/Implementation).</para>
    ///   <a href="https://w3id.org/amv#Implementation">amv:Implementation</a>
    /// </summary>
    let Implementation = _prefixId.prefix "Implementation"
    let InsertionSort = _prefixId.prefix "InsertionSort"
    let InsertionSortSpaceComplexity = _prefixId.prefix "InsertionSortSpaceComplexity"
    let InsertionSortTimeComplexity = _prefixId.prefix "InsertionSortTimeComplexity"
    let Internal = _prefixId.prefix "Internal"
    let JHHalton = _prefixId.prefix "JHHalton"
    let JWJWilliams = _prefixId.prefix "JWJWilliams"
    let JamesHMorris = _prefixId.prefix "JamesHMorris"
    let JaromirDolecek = _prefixId.prefix "JaromirDolecek"
    let Java = _prefixId.prefix "Java"
    let JillianBeardwood = _prefixId.prefix "JillianBeardwood"
    let JohnHammersley = _prefixId.prefix "JohnHammersley"
    let JohnMauchly = _prefixId.prefix "JohnMauchly"
    let JohnVonNeumann = _prefixId.prefix "JohnVonNeumann"
    let JoshuaJArulanandham = _prefixId.prefix "JoshuaJArulanandham"
    let KenThompson = _prefixId.prefix "KenThompson"
    let LRFord = _prefixId.prefix "LRFord"
    let LinearAlgebra = _prefixId.prefix "LinearAlgebra"
    let LinearFunctions = _prefixId.prefix "LinearFunctions"
    let LinkedList = _prefixId.prefix "LinkedList"
    let Lisp = _prefixId.prefix "Lisp"
    let List = _prefixId.prefix "List"
    let LlewellynThomas = _prefixId.prefix "LlewellynThomas"
    let LogarithmicFunction = _prefixId.prefix "LogarithmicFunction"
    /// <summary>
    ///   <para>rdfs:label : Loop construct</para>
    ///   <para>rdfs:comment : The type of loop best suited when an algorithm is implemented in any desired programming language. The loop types are for loop, while loop, do-while loop.</para>
    ///   <a href="https://w3id.org/amv#LoopConstruct">amv:LoopConstruct</a>
    /// </summary>
    let LoopConstruct = _prefixId.prefix "LoopConstruct"
    let MS_DOS = _prefixId.prefix "MS-DOS"
    let MatchFindingAlgorithm = _prefixId.prefix "MatchFindingAlgorithm"
    let Mathematica = _prefixId.prefix "Mathematica"
    /// <summary>
    ///   <para>rdfs:label : Mathematical property</para>
    ///   <para>rdfs:comment : The mathematical concept used in the algorithm to tackle the problem. This includes set theoty, linear algebra, graph theory etc.</para>
    ///   <a href="https://w3id.org/amv#MathematicalProperties">amv:MathematicalProperties</a>
    /// </summary>
    let MathematicalProperties = _prefixId.prefix "MathematicalProperties"
    let Mathematics = _prefixId.prefix "Mathematics"
    let Matlab = _prefixId.prefix "Matlab"
    let MergeSort = _prefixId.prefix "MergeSort"
    let MergeSortSpaceComplexity = _prefixId.prefix "MergeSortSpaceComplexity"
    let MergeSortTimeComplexity = _prefixId.prefix "MergeSortTimeComplexity"
    /// <summary>
    ///   <para>rdfs:label : Message complexity</para>
    ///   <para>rdfs:comment : The number of messages passed. This is an important measure, primarily applicable in case of distributed algorithms.</para>
    ///   <a href="https://w3id.org/amv#MessageComplexity">amv:MessageComplexity</a>
    /// </summary>
    let MessageComplexity = _prefixId.prefix "MessageComplexity"
    /// <summary>
    ///   <para>rdfs:label : Metric</para>
    ///   <a href="https://w3id.org/amv#Metric">amv:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    let MichaelDinneen = _prefixId.prefix "MichaelDinneen"
    let MicrosoftWindows = _prefixId.prefix "MicrosoftWindows"
    let NaturalLanguage = _prefixId.prefix "NaturalLanguage"
    let NetworkFlowTheory = _prefixId.prefix "NetworkFlowTheory"
    let NeuralMachineTranslation = _prefixId.prefix "NeuralMachineTranslation"
    let NilsNilson = _prefixId.prefix "NilsNilson"
    /// <summary>
    ///   <para>rdfs:label : Numerical Problem</para>
    ///   <para>rdfs:comment : Numerical algorithms are behind designing shapes (e.g. shapes for cars, planes, fonts), computing intensities for displaying graphics, animating moving objects, studying the spread of diseases, modelling the orbit of planets and satellites, supporting search engines such as google, and many more practical problems.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#NumericalProblem">amv:NumericalProblem</a>
    /// </summary>
    let NumericalProblem = _prefixId.prefix "NumericalProblem"
    let OnARoutingProblem = _prefixId.prefix "OnARoutingProblem"
    /// <summary>
    ///   <para>rdfs:label : Optimization problem</para>
    ///   <para>rdfs:comment : An optimization problem is the problem of finding the best solution from all feasible solutions.</para>
    ///   <a href="https://w3id.org/amv#OptimizationProblem">amv:OptimizationProblem</a>
    /// </summary>
    let OptimizationProblem = _prefixId.prefix "OptimizationProblem"
    let OriolVinyals = _prefixId.prefix "OriolVinyals"
    let PHP = _prefixId.prefix "PHP"
    let Pascal = _prefixId.prefix "Pascal"
    let PerAustrin = _prefixId.prefix "PerAustrin"
    /// <summary>
    ///   <para>rdfs:label : Performance metric</para>
    ///   <para>rdfs:comment : Performance metrics (e.g., accuracy, precision, recall) are used to evaluate different algorithms.</para>
    ///   <a href="https://w3id.org/amv#PerformanceMetric">amv:PerformanceMetric</a>
    /// </summary>
    let PerformanceMetric = _prefixId.prefix "PerformanceMetric"
    let PeterHart = _prefixId.prefix "PeterHart"
    let PeterMcIlroy = _prefixId.prefix "PeterMcIlroy"
    let PokSonKim = _prefixId.prefix "PokSonKim"
    /// <summary>
    ///   <para>rdfs:label : Polynomial Time Problem</para>
    ///   <para>rdfs:comment : Polynomial time problem means that an algorithm exists for its solution such that the number of steps in the algorithm is bounded by a polynomial function of n, where n corresponds to the length of the input for the problem.</para>
    ///   <a href="https://w3id.org/amv#PolynomialTimeProblem">amv:PolynomialTimeProblem</a>
    /// </summary>
    let PolynomialTimeProblem = _prefixId.prefix "PolynomialTimeProblem"
    let PriorityQueue = _prefixId.prefix "PriorityQueue"
    /// <summary>
    ///   <para>rdfs:label : Problem</para>
    ///   <para>rdfs:comment : The various problems for which an algorithm is written.</para>
    ///   <a href="https://w3id.org/amv#Problem">amv:Problem</a>
    /// </summary>
    let Problem = _prefixId.prefix "Problem"
    /// <summary>
    ///   <para>rdfs:label : Programming language</para>
    ///   <para>rdfs:comment : Language designed to communicate instructions to a machine Programming languages are used in computer programming to implement algorithms.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#ProgrammingLanguage">amv:ProgrammingLanguage</a>
    /// </summary>
    let ProgrammingLanguage = _prefixId.prefix "ProgrammingLanguage"
    let Pseudocode = _prefixId.prefix "Pseudocode"
    let Public = _prefixId.prefix "Public"
    let Python = _prefixId.prefix "Python"
    let QuadriticFunction = _prefixId.prefix "QuadriticFunction"
    let ``QuartApplMath.`` = _prefixId.prefix "QuartApplMath."
    let QueryProcessing = _prefixId.prefix "QueryProcessing"
    let QueryProcessingAlgorithm = _prefixId.prefix "QueryProcessingAlgorithm"
    let Queue = _prefixId.prefix "Queue"
    let QuickSort = _prefixId.prefix "QuickSort"
    let QuickSortSpaceComplexity = _prefixId.prefix "QuickSortSpaceComplexity"
    let QuickSortTimeComplexity = _prefixId.prefix "QuickSortTimeComplexity"
    let QuocVLe = _prefixId.prefix "QuocVLe"
    let R = _prefixId.prefix "R"
    let RandomizedAlgorithm = _prefixId.prefix "RandomizedAlgorithm"

    let RatioBasedStableIn_placeMerging =
        _prefixId.prefix "RatioBasedStableIn-placeMerging"

    let RecursiveAlgorithm = _prefixId.prefix "RecursiveAlgorithm"
    let RedHatLinux = _prefixId.prefix "RedHatLinux"
    let RichardEBellman = _prefixId.prefix "RichardEBellman"
    let SelectionSort = _prefixId.prefix "SelectionSort"

    let SelectionSortImplementationInC =
        _prefixId.prefix "SelectionSortImplementationInC"

    let SelectionSortSpaceComplexity = _prefixId.prefix "SelectionSortSpaceComplexity"
    let SelectionSortTimeComplexity = _prefixId.prefix "SelectionSortTimeComplexity"
    let SelmerMJohnson = _prefixId.prefix "SelmerMJohnson"

    let SequenceToSequenceLearningWithNeuralNetworks =
        _prefixId.prefix "SequenceToSequenceLearningWithNeuralNetworks"

    /// <summary>
    ///   <para>rdfs:label : Set Problem</para>
    ///   <para>rdfs:comment : Sets are collections of symbols whose order is assumed to carry no significance.</para>
    ///   <a href="https://w3id.org/amv#SetProblem">amv:SetProblem</a>
    /// </summary>
    let SetProblem = _prefixId.prefix "SetProblem"
    let ShortestPathProblem = _prefixId.prefix "ShortestPathProblem"
    let SmoothSort = _prefixId.prefix "SmoothSort"

    let SmoothSortAlternativeForSortingInSitu =
        _prefixId.prefix "SmoothSortAlternativeForSortingInSitu"

    let SmoothSortSpaceComplexity = _prefixId.prefix "SmoothSortSpaceComplexity"
    let SmoothSortTimeComplexity = _prefixId.prefix "SmoothSortTimeComplexity"
    let Sorting = _prefixId.prefix "Sorting"
    /// <summary>
    ///   <para>rdfs:label : Space complexity</para>
    ///   <para>rdfs:comment : Space complexity of an algorithm quantifies the amount of space or memory taken by an algorithm to run as a function of the length of the input.</para>
    ///   <a href="https://w3id.org/amv#SpaceComplexity">amv:SpaceComplexity</a>
    /// </summary>
    let SpaceComplexity = _prefixId.prefix "SpaceComplexity"
    let Statistics = _prefixId.prefix "Statistics"
    /// <summary>
    ///   <para>rdfs:label : String problem</para>
    ///   <para>rdfs:comment : Strings are defined by the sequence or arrangement of symbols</para>
    ///   <a href="https://w3id.org/amv#StringProblem">amv:StringProblem</a>
    /// </summary>
    let StringProblem = _prefixId.prefix "StringProblem"
    let StuartLloyd = _prefixId.prefix "StuartLloyd"
    let TheoryOfSets = _prefixId.prefix "TheoryOfSets"

    let TheoryOfStatisticsAndProbability =
        _prefixId.prefix "TheoryOfStatisticsAndProbability"

    let TimPeters = _prefixId.prefix "TimPeters"
    let TimSort = _prefixId.prefix "TimSort"
    let TimSortImplementedInPython = _prefixId.prefix "TimSortImplementedInPython"
    let TimSortSpaceComplexity = _prefixId.prefix "TimSortSpaceComplexity"
    let TimSortTimeComplexity = _prefixId.prefix "TimSortTimeComplexity"
    /// <summary>
    ///   <para>rdfs:label : Time complexity</para>
    ///   <para>rdfs:comment : Time complexity of an algorithm quantifies the amount of time taken by an algorithm to run as a function of the length of the input.
    ///
    /// It measures only the executing time of the algorithm in a way that depends only on the algorithm itself and its input.rdfs:comment : It represents the number of times a statement is executed.</para>
    ///   <a href="https://w3id.org/amv#TimeComplexity">amv:TimeComplexity</a>
    /// </summary>
    let TimeComplexity = _prefixId.prefix "TimeComplexity"
    let TobiasDantzig = _prefixId.prefix "TobiasDantzig"
    let UndirectedGraph = _prefixId.prefix "UndirectedGraph"
    let Unix = _prefixId.prefix "Unix"
    let UserQueryProcessing = _prefixId.prefix "UserQueryProcessing"
    let UserQueryProcessingAlgorithm = _prefixId.prefix "UserQueryProcessingAlgorithm"
    let VaughanPratt = _prefixId.prefix "VaughanPratt"
    let While = _prefixId.prefix "While"
    let WilliamWesleyPeterson = _prefixId.prefix "WilliamWesleyPeterson"
    /// <summary>
    ///   <para>rdfs:label : accessibility</para>
    ///   <para>rdfs:comment : The information on access (i.e modify, read, download) to the algorithm.</para>
    ///   <a href="https://w3id.org/amv#accessibility">amv:accessibility</a>
    /// </summary>
    let accessibility = _prefixId.prefix "accessibility"
    /// <summary>
    ///   <para>rdfs:label : accuracy^^xsd:string</para>
    ///   <para>rdfs:comment : It is the measure of the degree of closeness of a measured or calculated value to its actual value.rdfs:comment : How close the output will be to a set point.</para>
    ///   <a href="https://w3id.org/amv#accuracy">amv:accuracy</a>
    /// </summary>
    let accuracy = _prefixId.prefix "accuracy"
    /// <summary>
    ///   <para>rdfs:label : acronym</para>
    ///   <a href="https://w3id.org/amv#acronym">amv:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:label : affiliation of</para>
    ///   <a href="https://w3id.org/amv#affiliationOf">amv:affiliationOf</a>
    /// </summary>
    let affiliationOf = _prefixId.prefix "affiliationOf"
    /// <summary>
    ///   <para>rdfs:label : affliation^^xsd:string</para>
    ///   <para>rdfs:comment : An organization that the person is affiliated with. For example, a school/university.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#affliation">amv:affliation</a>
    /// </summary>
    let affliation = _prefixId.prefix "affliation"
    /// <summary>
    ///   <para>rdfs:label : algorithm type for</para>
    ///   <para>rdfs:comment : Is an algorithm type for an algorithm.</para>
    ///   <a href="https://w3id.org/amv#algorithmTypeFor">amv:algorithmTypeFor</a>
    /// </summary>
    let algorithmTypeFor = _prefixId.prefix "algorithmTypeFor"
    /// <summary>
    ///   <para>rdfs:label : alternative title</para>
    ///   <para>rdfs:comment : An alternative title of a resource.</para>
    ///   <a href="https://w3id.org/amv#alternativeTitle">amv:alternativeTitle</a>
    /// </summary>
    let alternativeTitle = _prefixId.prefix "alternativeTitle"
    /// <summary>
    ///   <para>rdfs:label : analysis function type</para>
    ///   <para>rdfs:comment : The various function types for analysis of algorithms like logarithmic functions, exponential functions etc.</para>
    ///   <a href="https://w3id.org/amv#analysisFunctionType">amv:analysisFunctionType</a>
    /// </summary>
    let analysisFunctionType = _prefixId.prefix "analysisFunctionType"
    /// <summary>
    ///   <para>rdfs:label : analysis function type of</para>
    ///   <a href="https://w3id.org/amv#analysisFunctionTypeOf">amv:analysisFunctionTypeOf</a>
    /// </summary>
    let analysisFunctionTypeOf = _prefixId.prefix "analysisFunctionTypeOf"
    /// <summary>
    ///   <para>rdfs:label : available algorithm</para>
    ///   <para>rdfs:comment : An algorithm for a given problem.</para>
    ///   <a href="https://w3id.org/amv#availableAlgorithm">amv:availableAlgorithm</a>
    /// </summary>
    let availableAlgorithm = _prefixId.prefix "availableAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : average message complexity</para>
    ///   <a href="https://w3id.org/amv#averageMessageComplexity">amv:averageMessageComplexity</a>
    /// </summary>
    let averageMessageComplexity = _prefixId.prefix "averageMessageComplexity"
    /// <summary>
    ///   <para>rdfs:label : average space complexity</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P3757</para>
    ///   <para>rdfs:comment : Space complexity of an algorithm on average.(https://www.wikidata.org/wiki/Property:P3757)^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#averageSpaceComplexity">amv:averageSpaceComplexity</a>
    /// </summary>
    let averageSpaceComplexity = _prefixId.prefix "averageSpaceComplexity"
    /// <summary>
    ///   <para>rdfs:label : average time complexity</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P3754</para>
    ///   <para>rdfs:comment : Time complexity of an algorithm on average. (https://www.wikidata.org/wiki/Property:P3754)</para>
    ///   <a href="https://w3id.org/amv#averageTimeComplexity">amv:averageTimeComplexity</a>
    /// </summary>
    let averageTimeComplexity = _prefixId.prefix "averageTimeComplexity"
    /// <summary>
    ///   <para>rdfs:label : best case message complexity</para>
    ///   <a href="https://w3id.org/amv#bestCaseMessageComplexity">amv:bestCaseMessageComplexity</a>
    /// </summary>
    let bestCaseMessageComplexity = _prefixId.prefix "bestCaseMessageComplexity"
    /// <summary>
    ///   <para>rdfs:label : best case space complexity</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P3756</para>
    ///   <para>rdfs:comment : Space complexity of an algorithm at least.(https://www.wikidata.org/wiki/Property:P3756)^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#bestCaseSpaceComplexity">amv:bestCaseSpaceComplexity</a>
    /// </summary>
    let bestCaseSpaceComplexity = _prefixId.prefix "bestCaseSpaceComplexity"
    /// <summary>
    ///   <para>rdfs:label : best case time complexity</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P3753</para>
    ///   <para>rdfs:comment : Time complexity of an algorithm at least. (https://www.wikidata.org/wiki/Property:P3753)</para>
    ///   <a href="https://w3id.org/amv#bestCaseTimeComplexity">amv:bestCaseTimeComplexity</a>
    /// </summary>
    let bestCaseTimeComplexity = _prefixId.prefix "bestCaseTimeComplexity"
    /// <summary>
    ///   <para>rdfs:label : comment of</para>
    ///   <a href="https://w3id.org/amv#commentOf">amv:commentOf</a>
    /// </summary>
    let commentOf = _prefixId.prefix "commentOf"
    /// <summary>
    ///   <para>rdfs:label : computes solution to</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P2159</para>
    ///   <para>rdfs:comment : The type of problem the algorithm solves.rdfs:comment : Problem that this algorithm or method solves.(https://www.wikidata.org/wiki/Property:P2159)^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#computesSolutionTo">amv:computesSolutionTo</a>
    /// </summary>
    let computesSolutionTo = _prefixId.prefix "computesSolutionTo"
    /// <summary>
    ///   <para>rdfs:label : constraint</para>
    ///   <para>rdfs:comment : Limitations that an algorithm posses.</para>
    ///   <a href="https://w3id.org/amv#constraint">amv:constraint</a>
    /// </summary>
    let constraint_ = _prefixId.prefix "constraint"
    /// <summary>
    ///   <para>rdfs:label : cpu time limit</para>
    ///   <para>rdfs:comment : Time taken by CPU while executing the program.(In seconds)</para>
    ///   <a href="https://w3id.org/amv#cpuTimeLimit">amv:cpuTimeLimit</a>
    /// </summary>
    let cpuTimeLimit = _prefixId.prefix "cpuTimeLimit"
    /// <summary>
    ///   <para>rdfs:label : data Structure Used^^xsd:string</para>
    ///   <para>rdfs:comment : The data structure used in an algorithm.</para>
    ///   <a href="https://w3id.org/amv#dataStructureUsed">amv:dataStructureUsed</a>
    /// </summary>
    let dataStructureUsed = _prefixId.prefix "dataStructureUsed"
    /// <summary>
    ///   <para>rdfs:label : data Structure Used In^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#dataStructureUsedIn">amv:dataStructureUsedIn</a>
    /// </summary>
    let dataStructureUsedIn = _prefixId.prefix "dataStructureUsedIn"
    /// <summary>
    ///   <para>rdfs:label : defining formula</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/p2534</para>
    ///   <para>rdfs:comment : The mathematical formula used for solving the problem.
    /// Mathematical formula representing a theorem or law.</para>
    ///   <a href="https://w3id.org/amv#definingFormula">amv:definingFormula</a>
    /// </summary>
    let definingFormula = _prefixId.prefix "definingFormula"
    /// <summary>
    ///   <para>rdfs:label : definiton</para>
    ///   <a href="https://w3id.org/amv#definition">amv:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>rdfs:label : edge Case</para>
    ///   <para>rdfs:comment : Input values that require special handling in an algorithm. When using the algorithm at an extreme(maximum or minimum) operating parameters.</para>
    ///   <a href="https://w3id.org/amv#edgeCase">amv:edgeCase</a>
    /// </summary>
    let edgeCase = _prefixId.prefix "edgeCase"
    /// <summary>
    ///   <para>rdfs:label : excerpt</para>
    ///   <para>rdfs:comment : An excerpt is a contiguous or discontiguous portion, or a passage selected from a larger work or document.</para>
    ///   <a href="https://w3id.org/amv#excerpt">amv:excerpt</a>
    /// </summary>
    let excerpt = _prefixId.prefix "excerpt"
    /// <summary>
    ///   <para>rdfs:label : time of earliest written record</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P1249</para>
    ///   <para>rdfs:comment : First time a subject was mentioned in writing.(https://www.wikidata.org/wiki/Property:P1249)^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#firstWrittenRecord">amv:firstWrittenRecord</a>
    /// </summary>
    let firstWrittenRecord = _prefixId.prefix "firstWrittenRecord"
    /// <summary>
    ///   <para>rdfs:label : flexible^^xsd:string</para>
    ///   <para>rdfs:comment : The algorithm written in such a way that it allows to add new features without changing the existing module.</para>
    ///   <a href="https://w3id.org/amv#flexible">amv:flexible</a>
    /// </summary>
    let flexible = _prefixId.prefix "flexible"
    /// <summary>
    ///   <para>rdfs:label : form of expression</para>
    ///   <para>rdfs:comment : The form of expression of an Algorithm.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#formOfExpression">amv:formOfExpression</a>
    /// </summary>
    let formOfExpression = _prefixId.prefix "formOfExpression"
    /// <summary>
    ///   <para>rdfs:label : form Of expression of</para>
    ///   <para>rdfs:comment : The form of expression of an Algorithm.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#formOfExpressionOf">amv:formOfExpressionOf</a>
    /// </summary>
    let formOfExpressionOf = _prefixId.prefix "formOfExpressionOf"
    /// <summary>
    ///   <para>rdfs:label : formal definition</para>
    ///   <a href="https://w3id.org/amv#formalDefinition">amv:formalDefinition</a>
    /// </summary>
    let formalDefinition = _prefixId.prefix "formalDefinition"
    /// <summary>
    ///   <para>rdfs:label : has implementation</para>
    ///   <para>rdfs:comment : The various applications of the algorithm.</para>
    ///   <a href="https://w3id.org/amv#hasImplementation">amv:hasImplementation</a>
    /// </summary>
    let hasImplementation = _prefixId.prefix "hasImplementation"
    /// <summary>
    ///   <para>rdfs:label : has message complexity</para>
    ///   <a href="https://w3id.org/amv#hasMessageComplexity">amv:hasMessageComplexity</a>
    /// </summary>
    let hasMessageComplexity = _prefixId.prefix "hasMessageComplexity"
    /// <summary>
    ///   <para>rdfs:label : has metric</para>
    ///   <a href="https://w3id.org/amv#hasMetric">amv:hasMetric</a>
    /// </summary>
    let hasMetric = _prefixId.prefix "hasMetric"
    /// <summary>
    ///   <para>rdfs:label : has performance metric</para>
    ///   <a href="https://w3id.org/amv#hasPerformanceMetric">amv:hasPerformanceMetric</a>
    /// </summary>
    let hasPerformanceMetric = _prefixId.prefix "hasPerformanceMetric"
    /// <summary>
    ///   <para>rdfs:label : has space complexity</para>
    ///   <a href="https://w3id.org/amv#hasSpaceComplexity">amv:hasSpaceComplexity</a>
    /// </summary>
    let hasSpaceComplexity = _prefixId.prefix "hasSpaceComplexity"
    /// <summary>
    ///   <para>rdfs:label : has subalgorithm</para>
    ///   <a href="https://w3id.org/amv#hasSubalgorithm">amv:hasSubalgorithm</a>
    /// </summary>
    let hasSubalgorithm = _prefixId.prefix "hasSubalgorithm"
    /// <summary>
    ///   <para>rdfs:label : has subproblem</para>
    ///   <para>rdfs:comment : a problem that is contingent on or forms a part of another more inclusive problem.</para>
    ///   <a href="https://w3id.org/amv#hasSubproblem">amv:hasSubproblem</a>
    /// </summary>
    let hasSubproblem = _prefixId.prefix "hasSubproblem"
    /// <summary>
    ///   <para>rdfs:label : has time complexity</para>
    ///   <a href="https://w3id.org/amv#hasTimeComplexity">amv:hasTimeComplexity</a>
    /// </summary>
    let hasTimeComplexity = _prefixId.prefix "hasTimeComplexity"
    /// <summary>
    ///   <para>rdfs:label : implementation of</para>
    ///   <para>rdfs:comment : The various applications of the algorithm.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#implementationOf">amv:implementationOf</a>
    /// </summary>
    let implementationOf = _prefixId.prefix "implementationOf"
    /// <summary>
    ///   <para>rdfs:label : input</para>
    ///   <para>rdfs:comment : Something that is operated on by any process or system. An algorithm can have zero or more inputs.</para>
    ///   <a href="https://w3id.org/amv#input">amv:input</a>
    /// </summary>
    let input = _prefixId.prefix "input"
    /// <summary>
    ///   <para>rdfs:label : input description</para>
    ///   <para>rdfs:comment : Input description of an algorithm.</para>
    ///   <a href="https://w3id.org/amv#inputDescription">amv:inputDescription</a>
    /// </summary>
    let inputDescription = _prefixId.prefix "inputDescription"
    /// <summary>
    ///   <para>rdfs:label : output image</para>
    ///   <a href="https://w3id.org/amv#inputImage">amv:inputImage</a>
    /// </summary>
    let inputImage = _prefixId.prefix "inputImage"
    /// <summary>
    ///   <para>rdfs:label : is a type of</para>
    ///   <para>rdfs:comment : The nature or genre of an algorithm.rdfs:comment : The different type of algorithmic techniques that are used to solve the various existing problems in the most optimized manner.This classification is neither exhaustive nor disjoint but highlights the various ways in which a problem can be addressed.</para>
    ///   <a href="https://w3id.org/amv#isATypeOf">amv:isATypeOf</a>
    /// </summary>
    let isATypeOf = _prefixId.prefix "isATypeOf"
    /// <summary>
    ///   <para>rdfs:label : is input image of</para>
    ///   <a href="https://w3id.org/amv#isInputImageOf">amv:isInputImageOf</a>
    /// </summary>
    let isInputImageOf = _prefixId.prefix "isInputImageOf"
    /// <summary>
    ///   <para>rdfs:label : is output image of</para>
    ///   <a href="https://w3id.org/amv#isOutputImageOf">amv:isOutputImageOf</a>
    /// </summary>
    let isOutputImageOf = _prefixId.prefix "isOutputImageOf"
    /// <summary>
    ///   <para>rdfs:label : is similar to</para>
    ///   <para>rdfs:comment : A pointer to another, functionally similar thing (or multiple things), for example, an algorithm is similar to another algorithm or algorithms, a problem is similar to another problem or problems, etc.</para>
    ///   <a href="https://w3id.org/amv#isSimilarTo">amv:isSimilarTo</a>
    /// </summary>
    let isSimilarTo = _prefixId.prefix "isSimilarTo"
    /// <summary>
    ///   <para>rdfs:label : library URI^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identifier of the central place where the algorithm is stored.</para>
    ///   <a href="https://w3id.org/amv#libraryURI">amv:libraryURI</a>
    /// </summary>
    let libraryURI = _prefixId.prefix "libraryURI"
    /// <summary>
    ///   <para>rdfs:label : loop construct</para>
    ///   <para>rdfs:comment : The loop best suited for the algorithm.</para>
    ///   <a href="https://w3id.org/amv#loopConstruct">amv:loopConstruct</a>
    /// </summary>
    let loopConstruct = _prefixId.prefix "loopConstruct"
    /// <summary>
    ///   <para>rdfs:label : loop construct of</para>
    ///   <a href="https://w3id.org/amv#loopConstructOf">amv:loopConstructOf</a>
    /// </summary>
    let loopConstructOf = _prefixId.prefix "loopConstructOf"
    /// <summary>
    ///   <para>rdfs:label : mathematical property</para>
    ///   <para>rdfs:comment : The mathematical concept used to solve the problem.</para>
    ///   <a href="https://w3id.org/amv#mathematicalProperty">amv:mathematicalProperty</a>
    /// </summary>
    let mathematicalProperty = _prefixId.prefix "mathematicalProperty"
    /// <summary>
    ///   <para>rdfs:label : mathematicalPropertyUsed^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#mathematicalPropertyUsed">amv:mathematicalPropertyUsed</a>
    /// </summary>
    let mathematicalPropertyUsed = _prefixId.prefix "mathematicalPropertyUsed"
    /// <summary>
    ///   <para>rdfs:label : message complexity of</para>
    ///   <a href="https://w3id.org/amv#messageComplexityOf">amv:messageComplexityOf</a>
    /// </summary>
    let messageComplexityOf = _prefixId.prefix "messageComplexityOf"
    /// <summary>
    ///   <para>rdfs:label : metric of</para>
    ///   <a href="https://w3id.org/amv#metricOf">amv:metricOf</a>
    /// </summary>
    let metricOf = _prefixId.prefix "metricOf"
    let n_bodyProblem = _prefixId.prefix "n-bodyProblem"
    /// <summary>
    ///   <para>rdfs:label : number Of Nested Loops^^xsd:string</para>
    ///   <para>rdfs:comment : The number of nested loops in an algorithm.</para>
    ///   <a href="https://w3id.org/amv#numberOfNestedLoops">amv:numberOfNestedLoops</a>
    /// </summary>
    let numberOfNestedLoops = _prefixId.prefix "numberOfNestedLoops"
    /// <summary>
    ///   <para>rdfs:label : number Of Steps^^xsd:string</para>
    ///   <para>rdfs:comment : Total number of steps that the algorithm takes to solve a certain problem.</para>
    ///   <a href="https://w3id.org/amv#numberOfSteps">amv:numberOfSteps</a>
    /// </summary>
    let numberOfSteps = _prefixId.prefix "numberOfSteps"
    /// <summary>
    ///   <para>rdfs:label : offline algorithm</para>
    ///   <para>rdfs:comment : The complete dataset is required to start processing.</para>
    ///   <a href="https://w3id.org/amv#offlineAlgorithm">amv:offlineAlgorithm</a>
    /// </summary>
    let offlineAlgorithm = _prefixId.prefix "offlineAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : online algorithm</para>
    ///   <para>rdfs:comment : The data can be feed while processing.</para>
    ///   <a href="https://w3id.org/amv#onlineAlgorithm">amv:onlineAlgorithm</a>
    /// </summary>
    let onlineAlgorithm = _prefixId.prefix "onlineAlgorithm"
    /// <summary>
    ///   <para>rdfs:label : operatingSystemFor^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#operatingSystemFor">amv:operatingSystemFor</a>
    /// </summary>
    let operatingSystemFor = _prefixId.prefix "operatingSystemFor"
    /// <summary>
    ///   <para>rdfs:label : optimal</para>
    ///   <para>rdfs:comment : An algorithm is optimal means the time complexity in the worst case is a lower bound of the function that describes the time complexity in the worst case of a problem that the algorithm in question solves.</para>
    ///   <a href="https://w3id.org/amv#optimal">amv:optimal</a>
    /// </summary>
    let optimal = _prefixId.prefix "optimal"
    /// <summary>
    ///   <para>rdfs:label : output</para>
    ///   <para>rdfs:comment : Output after processing the input.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#output">amv:output</a>
    /// </summary>
    let output = _prefixId.prefix "output"
    /// <summary>
    ///   <para>rdfs:label : input image</para>
    ///   <a href="https://w3id.org/amv#outputImage">amv:outputImage</a>
    /// </summary>
    let outputImage = _prefixId.prefix "outputImage"
    /// <summary>
    ///   <para>rdfs:label : performance metric of</para>
    ///   <a href="https://w3id.org/amv#performanceMetricOf">amv:performanceMetricOf</a>
    /// </summary>
    let performanceMetricOf = _prefixId.prefix "performanceMetricOf"
    /// <summary>
    ///   <para>rdfs:label : precision</para>
    ///   <para>rdfs:comment : It is a measure of quality, higher precision means algorithm returns more relevant results than irrelevant ones.</para>
    ///   <a href="https://w3id.org/amv#precision">amv:precision</a>
    /// </summary>
    let precision = _prefixId.prefix "precision"
    /// <summary>
    ///   <para>rdfs:label : problem description</para>
    ///   <para>rdfs:comment : A description providing the problem statement.</para>
    ///   <a href="https://w3id.org/amv#problemDescription">amv:problemDescription</a>
    /// </summary>
    let problemDescription = _prefixId.prefix "problemDescription"
    /// <summary>
    ///   <para>rdfs:label : programming language</para>
    ///   <para>rdfs:comment : In which all language the implementation of the algorithm/ problem is available.</para>
    ///   <a href="https://w3id.org/amv#programmingLanguage">amv:programmingLanguage</a>
    /// </summary>
    let programmingLanguage = _prefixId.prefix "programmingLanguage"
    /// <summary>
    ///   <para>skos:AltLabel : Subject areaskos:AltLabel : Academic field</para>
    ///   <para>rdfs:label : Academic discipline</para>
    ///   <para>rdfs:comment : Academic field of study or profession.rdfs:comment : A branch of knowledge.</para>
    ///   <a href="https://w3id.org/amv#pub_Discipline">amv:pub_Discipline</a>
    /// </summary>
    let pub_Discipline = _prefixId.prefix "pub_Discipline"
    /// <summary>
    ///   <para>rdfs:label : Information Resource</para>
    ///   <para>rdfs:comment : An information resource.</para>
    ///   <a href="https://w3id.org/amv#pub_InformationResource">amv:pub_InformationResource</a>
    /// </summary>
    let pub_InformationResource = _prefixId.prefix "pub_InformationResource"
    /// <summary>
    ///   <para>rdfs:label : Manual</para>
    ///   <para>rdfs:comment : A small reference book, especially one giving instructions.</para>
    ///   <a href="https://w3id.org/amv#pub_Manual">amv:pub_Manual</a>
    /// </summary>
    let pub_Manual = _prefixId.prefix "pub_Manual"
    /// <summary>
    ///   <para>rdfs:label : access rights of</para>
    ///   <a href="https://w3id.org/amv#pub_accessRightsOf">amv:pub_accessRightsOf</a>
    /// </summary>
    let pub_accessRightsOf = _prefixId.prefix "pub_accessRightsOf"
    /// <summary>
    ///   <para>rdfs:label : appeared In^^xsd:string</para>
    ///   <para>rdfs:comment : An algorithm appeared in a publication.</para>
    ///   <a href="https://w3id.org/amv#pub_appearedIn">amv:pub_appearedIn</a>
    /// </summary>
    let pub_appearedIn = _prefixId.prefix "pub_appearedIn"
    /// <summary>
    ///   <para>rdfs:label : branch Of</para>
    ///   <a href="https://w3id.org/amv#pub_branchOf">amv:pub_branchOf</a>
    /// </summary>
    let pub_branchOf = _prefixId.prefix "pub_branchOf"
    /// <summary>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#pub_contains">amv:pub_contains</a>
    /// </summary>
    let pub_contains = _prefixId.prefix "pub_contains"
    /// <summary>
    ///   <para>rdfs:label : contributor of</para>
    ///   <a href="https://w3id.org/amv#pub_contributorOf">amv:pub_contributorOf</a>
    /// </summary>
    let pub_contributorOf = _prefixId.prefix "pub_contributorOf"
    /// <summary>
    ///   <para>skos:AltLabel : author of</para>
    ///   <para>rdfs:label : creator of</para>
    ///   <a href="https://w3id.org/amv#pub_creatorOf">amv:pub_creatorOf</a>
    /// </summary>
    let pub_creatorOf = _prefixId.prefix "pub_creatorOf"
    /// <summary>
    ///   <para>rdfs:label : download link</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/p4945</para>
    ///   <para>rdfs:comment : URL which can be used to download a work.</para>
    ///   <a href="https://w3id.org/amv#pub_downloadLink">amv:pub_downloadLink</a>
    /// </summary>
    let pub_downloadLink = _prefixId.prefix "pub_downloadLink"
    /// <summary>
    ///   <para>rdfs:label : hasArticle^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#pub_hasArticle">amv:pub_hasArticle</a>
    /// </summary>
    let pub_hasArticle = _prefixId.prefix "pub_hasArticle"
    /// <summary>
    ///   <para>rdfs:label : has branch</para>
    ///   <para>rdfs:comment : Branch of the academic discipline.^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#pub_hasBranch">amv:pub_hasBranch</a>
    /// </summary>
    let pub_hasBranch = _prefixId.prefix "pub_hasBranch"
    /// <summary>
    ///   <para>rdfs:label : license of</para>
    ///   <a href="https://w3id.org/amv#pub_licenseOf">amv:pub_licenseOf</a>
    /// </summary>
    let pub_licenseOf = _prefixId.prefix "pub_licenseOf"
    /// <summary>
    ///   <para>rdfs:label : published in</para>
    ///   <a href="https://w3id.org/amv#pub_publishedIn">amv:pub_publishedIn</a>
    /// </summary>
    let pub_publishedIn = _prefixId.prefix "pub_publishedIn"
    /// <summary>
    ///   <para>rdfs:label : publisher of</para>
    ///   <a href="https://w3id.org/amv#pub_publisherOf">amv:pub_publisherOf</a>
    /// </summary>
    let pub_publisherOf = _prefixId.prefix "pub_publisherOf"
    /// <summary>
    ///   <para>rdfs:label : rating</para>
    ///   <para>rdfs:comment : Rating given on the basis of usefulness of a thing.</para>
    ///   <a href="https://w3id.org/amv#pub_rating">amv:pub_rating</a>
    /// </summary>
    let pub_rating = _prefixId.prefix "pub_rating"
    /// <summary>
    ///   <para>rdfs:label : read me</para>
    ///   <para>rdfs:comment : Provide a description or Link to algorithm, or similar resource "Readme page".</para>
    ///   <a href="https://w3id.org/amv#pub_readme">amv:pub_readme</a>
    /// </summary>
    let pub_readme = _prefixId.prefix "pub_readme"
    /// <summary>
    ///   <para>rdfs:label : rights of</para>
    ///   <a href="https://w3id.org/amv#pub_rightsOf">amv:pub_rightsOf</a>
    /// </summary>
    let pub_rightsOf = _prefixId.prefix "pub_rightsOf"
    /// <summary>
    ///   <para>rdfs:label : subject of</para>
    ///   <para>rdfs:comment : A topic of the resource for.</para>
    ///   <a href="https://w3id.org/amv#pub_subjectOf">amv:pub_subjectOf</a>
    /// </summary>
    let pub_subjectOf = _prefixId.prefix "pub_subjectOf"
    /// <summary>
    ///   <para>rdfs:label : readable</para>
    ///   <para>rdfs:comment : Is the algorithm readable/understandable to the user.</para>
    ///   <a href="https://w3id.org/amv#readable">amv:readable</a>
    /// </summary>
    let readable = _prefixId.prefix "readable"
    /// <summary>
    ///   <para>rdfs:label : recall</para>
    ///   <para>rdfs:comment : percentage of total relevent result correctly classified by the algorithm.</para>
    ///   <a href="https://w3id.org/amv#recall">amv:recall</a>
    /// </summary>
    let recall = _prefixId.prefix "recall"
    /// <summary>
    ///   <para>rdfs:label : runs on Operating System</para>
    ///   <a href="https://w3id.org/amv#runsOnOperatingSystem">amv:runsOnOperatingSystem</a>
    /// </summary>
    let runsOnOperatingSystem = _prefixId.prefix "runsOnOperatingSystem"
    /// <summary>
    ///   <para>rdfs:label : space complexity of</para>
    ///   <a href="https://w3id.org/amv#spaceComplexityOf">amv:spaceComplexityOf</a>
    /// </summary>
    let spaceComplexityOf = _prefixId.prefix "spaceComplexityOf"
    /// <summary>
    ///   <para>rdfs:label : subalgorithm of</para>
    ///   <a href="https://w3id.org/amv#subalgorithmOf">amv:subalgorithmOf</a>
    /// </summary>
    let subalgorithmOf = _prefixId.prefix "subalgorithmOf"
    /// <summary>
    ///   <para>rdfs:label : subproblem of</para>
    ///   <a href="https://w3id.org/amv#subproblemOf">amv:subproblemOf</a>
    /// </summary>
    let subproblemOf = _prefixId.prefix "subproblemOf"
    /// <summary>
    ///   <para>rdfs:label : time complexity of</para>
    ///   <a href="https://w3id.org/amv#timeComplexityOf">amv:timeComplexityOf</a>
    /// </summary>
    let timeComplexityOf = _prefixId.prefix "timeComplexityOf"
    let tree = _prefixId.prefix "tree"
    let tuple = _prefixId.prefix "tuple"
    /// <summary>
    ///   <para>rdfs:label : programming language used in</para>
    ///   <a href="https://w3id.org/amv#usedInIm">amv:usedInIm</a>
    /// </summary>
    let usedInIm = _prefixId.prefix "usedInIm"
    /// <summary>
    ///   <para>rdfs:label : worst case message complexity</para>
    ///   <a href="https://w3id.org/amv#worstCaseMessageComplexity">amv:worstCaseMessageComplexity</a>
    /// </summary>
    let worstCaseMessageComplexity = _prefixId.prefix "worstCaseMessageComplexity"
    /// <summary>
    ///   <para>rdfs:label : worst case space complexity</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P3755</para>
    ///   <para>rdfs:comment : Space complexity of an algorithm at most.(https://www.wikidata.org/wiki/Property:P3755)^^xsd:string</para>
    ///   <a href="https://w3id.org/amv#worstCaseSpaceComplexity">amv:worstCaseSpaceComplexity</a>
    /// </summary>
    let worstCaseSpaceComplexity = _prefixId.prefix "worstCaseSpaceComplexity"
    /// <summary>
    ///   <para>rdfs:label : worst case time complexity</para>
    ///   <para>rdfs:isDefinedBy : http://www.wikidata.org/prop/direct/P3752</para>
    ///   <para>rdfs:comment : Time complexity of an algorithm at most. (https://www.wikidata.org/wiki/Property:P3752)</para>
    ///   <a href="https://w3id.org/amv#worstCaseTimeComplexity">amv:worstCaseTimeComplexity</a>
    /// </summary>
    let worstCaseTimeComplexity = _prefixId.prefix "worstCaseTimeComplexity"
