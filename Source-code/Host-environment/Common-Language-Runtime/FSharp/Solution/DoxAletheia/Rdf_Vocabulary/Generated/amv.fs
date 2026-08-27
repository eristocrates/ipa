namespace https.w3id.org.amv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module amv =
    let _namespace_iri = Namespace_Iri amv |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:amv#1.0.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#1.0.0">https://w3id.org/amv#1.0.0</seealso>
    let ``_1.0.0`` = Prefixed_Name(amv, "1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#A*Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#A*Algorithm">https://w3id.org/amv#A*Algorithm</seealso>
    let ``A*Algorithm`` = Prefixed_Name(amv, "A*Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#A*SpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#A*SpaceComplexity">https://w3id.org/amv#A*SpaceComplexity</seealso>
    let ``A*SpaceComplexity`` = Prefixed_Name(amv, "A*SpaceComplexity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#A*TimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#A*TimeComplexity">https://w3id.org/amv#A*TimeComplexity</seealso>
    let ``A*TimeComplexity`` = Prefixed_Name(amv, "A*TimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths">https://w3id.org/amv#AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths</seealso>
    let AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths =
        Prefixed_Name(amv, "AFormalBasisForTheHeuristicDeterminationOfMinimumCostPaths") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Ada</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Ada">https://w3id.org/amv#Ada</seealso>
    let Ada = Prefixed_Name(amv, "Ada") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a finite and unambiguous sequence of computer implementable instructions to perform a certain task. This can be a simple process, such as adding two numbers together, or a complex function, such as adding effects to an image. It can be expressed within a finite amount of space and time and in a well-defined formal language."</para>
    /// labels<para>"Algorithm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#Algorithm">https://w3id.org/amv#Algorithm</seealso>
    let Algorithm = Prefixed_Name(amv, "Algorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Algorithm232-HeapSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Algorithm232-HeapSort">https://w3id.org/amv#Algorithm232-HeapSort</seealso>
    let Algorithm232_HeapSort =
        Prefixed_Name(amv, "Algorithm232-HeapSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Algorithm64:Quicksort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Algorithm64:Quicksort">https://w3id.org/amv#Algorithm64:Quicksort</seealso>
    let ``Algorithm64:Quicksort`` =
        Prefixed_Name(amv, "Algorithm64:Quicksort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Time complexity corresponds to the amount of time required for an algorithm to run over the provided input in order to generate the required output. Analysis of this helps to predict the resources that an algorithm will take to finish execution."</para>
    /// labels<para>"AlgorithmAnalysisFunction"</para></remarks>
    /// <seealso href="https://w3id.org/amv#AlgorithmAnalysisFunction">https://w3id.org/amv#AlgorithmAnalysisFunction</seealso>
    let AlgorithmAnalysisFunction =
        Prefixed_Name(amv, "AlgorithmAnalysisFunction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#AlgorithmicType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The different type of algorithmic techniques that are used to solve the various existing problems in the most optimized manner.
    /// This classification is neither exhaustive nor disjoint."</para>
    /// labels<para>"Algorithmic Type"</para></remarks>
    /// <seealso href="https://w3id.org/amv#AlgorithmicType">https://w3id.org/amv#AlgorithmicType</seealso>
    let AlgorithmicType = Prefixed_Name(amv, "AlgorithmicType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Apache</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:LicenseDocument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Apache">https://w3id.org/amv#Apache</seealso>
    let Apache = Prefixed_Name(amv, "Apache") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#ApproximationAlgortihm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#AlgorithmicType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ApproximationAlgortihm">https://w3id.org/amv#ApproximationAlgortihm</seealso>
    let ApproximationAlgortihm =
        Prefixed_Name(amv, "ApproximationAlgortihm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#ArneKutzner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ArneKutzner">https://w3id.org/amv#ArneKutzner</seealso>
    let ArneKutzner = Prefixed_Name(amv, "ArneKutzner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Array</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Array">https://w3id.org/amv#Array</seealso>
    let Array = Prefixed_Name(amv, "Array") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#AssignmentProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#PolynomialTimeProblem</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#AssignmentProblem">https://w3id.org/amv#AssignmentProblem</seealso>
    let AssignmentProblem = Prefixed_Name(amv, "AssignmentProblem") |> PrefixedName


    let ``At&TBellLaboratories`` =
        Prefixed_Name(amv, "At&TBellLaboratories") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BacktrackingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Backtracking algorithms are based on a depth-first recursive search."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BacktrackingAlgorithm">https://w3id.org/amv#BacktrackingAlgorithm</seealso>
    let BacktrackingAlgorithm =
        Prefixed_Name(amv, "BacktrackingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Basic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Basic">https://w3id.org/amv#Basic</seealso>
    let Basic = Prefixed_Name(amv, "Basic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#BeadSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSort">https://w3id.org/amv#BeadSort</seealso>
    let BeadSort = Prefixed_Name(amv, "BeadSort") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#BeadSort-L</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSort-L">https://w3id.org/amv#BeadSort-L</seealso>
    let BeadSort_L = Prefixed_Name(amv, "BeadSort-L") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#BeadSort-R</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSort-R">https://w3id.org/amv#BeadSort-R</seealso>
    let BeadSort_R = Prefixed_Name(amv, "BeadSort-R") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BeadSort:ANaturalSortingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSort:ANaturalSortingAlgorithm">https://w3id.org/amv#BeadSort:ANaturalSortingAlgorithm</seealso>
    let ``BeadSort:ANaturalSortingAlgorithm`` =
        Prefixed_Name(amv, "BeadSort:ANaturalSortingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BeadSortInPython</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSortInPython">https://w3id.org/amv#BeadSortInPython</seealso>
    let BeadSortInPython = Prefixed_Name(amv, "BeadSortInPython") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BeadSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSortSpaceComplexity">https://w3id.org/amv#BeadSortSpaceComplexity</seealso>
    let BeadSortSpaceComplexity =
        Prefixed_Name(amv, "BeadSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BeadSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BeadSortTimeComplexity">https://w3id.org/amv#BeadSortTimeComplexity</seealso>
    let BeadSortTimeComplexity =
        Prefixed_Name(amv, "BeadSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BellmanFordAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BellmanFordAlgorithm">https://w3id.org/amv#BellmanFordAlgorithm</seealso>
    let BellmanFordAlgorithm =
        Prefixed_Name(amv, "BellmanFordAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BellmanFordSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#SpaceComplexity</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BellmanFordSpaceComplexity">https://w3id.org/amv#BellmanFordSpaceComplexity</seealso>
    let BellmanFordSpaceComplexity =
        Prefixed_Name(amv, "BellmanFordSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BellmanFordTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#TimeComplexity</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BellmanFordTimeComplexity">https://w3id.org/amv#BellmanFordTimeComplexity</seealso>
    let BellmanFordTimeComplexity =
        Prefixed_Name(amv, "BellmanFordTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BellmanFormPerformanceMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#PerformanceMetric</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BellmanFormPerformanceMetric">https://w3id.org/amv#BellmanFormPerformanceMetric</seealso>
    let BellmanFormPerformanceMetric =
        Prefixed_Name(amv, "BellmanFormPerformanceMetric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BertramRaphael</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BertramRaphael">https://w3id.org/amv#BertramRaphael</seealso>
    let BertramRaphael = Prefixed_Name(amv, "BertramRaphael") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#BestBinFirst</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BestBinFirst">https://w3id.org/amv#BestBinFirst</seealso>
    let BestBinFirst = Prefixed_Name(amv, "BestBinFirst") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#BlockSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BlockSort">https://w3id.org/amv#BlockSort</seealso>
    let BlockSort = Prefixed_Name(amv, "BlockSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BlockSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BlockSortSpaceComplexity">https://w3id.org/amv#BlockSortSpaceComplexity</seealso>
    let BlockSortSpaceComplexity =
        Prefixed_Name(amv, "BlockSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BlockSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BlockSortTimeComplexity">https://w3id.org/amv#BlockSortTimeComplexity</seealso>
    let BlockSortTimeComplexity =
        Prefixed_Name(amv, "BlockSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BranchAndBoundAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Branch and bound algorithms are generally used for optimization problems.
    /// As the algorithm progresses, a tree of subproblems is formed.
    /// The original problem is considered the “root problem”. A method is used to construct an upper and lower bound for a given problem. At each node, apply the bounding methods."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BranchAndBoundAlgorithm">https://w3id.org/amv#BranchAndBoundAlgorithm</seealso>
    let BranchAndBoundAlgorithm =
        Prefixed_Name(amv, "BranchAndBoundAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BruteForceAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A brute force algorithm simply tries all possibilities until a satisfactory solution is found."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BruteForceAlgorithm">https://w3id.org/amv#BruteForceAlgorithm</seealso>
    let BruteForceAlgorithm = Prefixed_Name(amv, "BruteForceAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#BubbleSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BubbleSort">https://w3id.org/amv#BubbleSort</seealso>
    let BubbleSort = Prefixed_Name(amv, "BubbleSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BubbleSortPseudocodeImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BubbleSortPseudocodeImplementation">https://w3id.org/amv#BubbleSortPseudocodeImplementation</seealso>
    let BubbleSortPseudocodeImplementation =
        Prefixed_Name(amv, "BubbleSortPseudocodeImplementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BubbleSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BubbleSortSpaceComplexity">https://w3id.org/amv#BubbleSortSpaceComplexity</seealso>
    let BubbleSortSpaceComplexity =
        Prefixed_Name(amv, "BubbleSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#BubbleSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#BubbleSortTimeComplexity">https://w3id.org/amv#BubbleSortTimeComplexity</seealso>
    let BubbleSortTimeComplexity =
        Prefixed_Name(amv, "BubbleSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#C</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#C">https://w3id.org/amv#C</seealso>
    let C = Prefixed_Name(amv, "C") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#C++</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#C++">https://w3id.org/amv#C++</seealso>
    let ``C++`` = Prefixed_Name(amv, "C++") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#CARHoare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#CARHoare">https://w3id.org/amv#CARHoare</seealso>
    let CARHoare = Prefixed_Name(amv, "CARHoare") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#ChristofidesAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ChristofidesAlgorithm">https://w3id.org/amv#ChristofidesAlgorithm</seealso>
    let ChristofidesAlgorithm =
        Prefixed_Name(amv, "ChristofidesAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CodeForDijkstrasAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#CodeForDijkstrasAlgorithm">https://w3id.org/amv#CodeForDijkstrasAlgorithm</seealso>
    let CodeForDijkstrasAlgorithm =
        Prefixed_Name(amv, "CodeForDijkstrasAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CombinatorialOptimizationProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Combinatorial optimization problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#CombinatorialOptimizationProblem">https://w3id.org/amv#CombinatorialOptimizationProblem</seealso>
    let CombinatorialOptimizationProblem =
        Prefixed_Name(amv, "CombinatorialOptimizationProblem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CombinatorialProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Combinatorial algorithms are computational procedures which are designed to help solve combinatorial problems. Combinatorial problems are problems involving arrangements of elements from a finite set and selections from a finite set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Combinatorial Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#CombinatorialProblem">https://w3id.org/amv#CombinatorialProblem</seealso>
    let CombinatorialProblem =
        Prefixed_Name(amv, "CombinatorialProblem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#ComputationalGeometryProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Computational geometry is a branch of computer science devoted to the study of algorithms which can be stated in terms of geometry. Some purely geometrical problems arise out of the study of computational geometric algorithms, and such problems are also considered to be part of computational geometry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computational Geometry Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#ComputationalGeometryProblem">https://w3id.org/amv#ComputationalGeometryProblem</seealso>
    let ComputationalGeometryProblem =
        Prefixed_Name(amv, "ComputationalGeometryProblem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#ComputerProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#FormOfExpression</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ComputerProgram">https://w3id.org/amv#ComputerProgram</seealso>
    let ComputerProgram = Prefixed_Name(amv, "ComputerProgram") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#ComputerScience</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#pub_Discipline</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ComputerScience">https://w3id.org/amv#ComputerScience</seealso>
    let ComputerScience = Prefixed_Name(amv, "ComputerScience") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#ConstantFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ConstantFunctions">https://w3id.org/amv#ConstantFunctions</seealso>
    let ConstantFunctions = Prefixed_Name(amv, "ConstantFunctions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#ControlTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#FormOfExpression</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ControlTable">https://w3id.org/amv#ControlTable</seealso>
    let ControlTable = Prefixed_Name(amv, "ControlTable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Copyleft</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:LicenseDocument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Copyleft">https://w3id.org/amv#Copyleft</seealso>
    let Copyleft = Prefixed_Name(amv, "Copyleft") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CreativeCommonsAttribution3.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:LicenseDocument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#CreativeCommonsAttribution3.0">https://w3id.org/amv#CreativeCommonsAttribution3.0</seealso>
    let ``CreativeCommonsAttribution3.0`` =
        Prefixed_Name(amv, "CreativeCommonsAttribution3.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CreativeCommonsAttribution4.0</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:LicenseDocument</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#CreativeCommonsAttribution4.0">https://w3id.org/amv#CreativeCommonsAttribution4.0</seealso>
    let ``CreativeCommonsAttribution4.0`` =
        Prefixed_Name(amv, "CreativeCommonsAttribution4.0") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CristianSCalude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#CristianSCalude">https://w3id.org/amv#CristianSCalude</seealso>
    let CristianSCalude = Prefixed_Name(amv, "CristianSCalude") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#CubicFunctionsAndPolynomials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#CubicFunctionsAndPolynomials">https://w3id.org/amv#CubicFunctionsAndPolynomials</seealso>
    let CubicFunctionsAndPolynomials =
        Prefixed_Name(amv, "CubicFunctionsAndPolynomials") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DataExtractionFromSbr</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DataExtractionFromSbr">https://w3id.org/amv#DataExtractionFromSbr</seealso>
    let DataExtractionFromSbr =
        Prefixed_Name(amv, "DataExtractionFromSbr") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DataExtractionImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DataExtractionImplementation">https://w3id.org/amv#DataExtractionImplementation</seealso>
    let DataExtractionImplementation =
        Prefixed_Name(amv, "DataExtractionImplementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data structure is a named location that can be used to store and organize data."</para>
    /// labels<para>"Data Structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#DataStructure">https://w3id.org/amv#DataStructure</seealso>
    let DataStructure = Prefixed_Name(amv, "DataStructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DataStructuresProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solving problems related to data structure i.e  a particular way of organizing data in a computer so that it can be used effectively."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Structures Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#DataStructuresProblem">https://w3id.org/amv#DataStructuresProblem</seealso>
    let DataStructuresProblem =
        Prefixed_Name(amv, "DataStructuresProblem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DecodingRecurrentNeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DecodingRecurrentNeuralNetwork">https://w3id.org/amv#DecodingRecurrentNeuralNetwork</seealso>
    let DecodingRecurrentNeuralNetwork =
        Prefixed_Name(amv, "DecodingRecurrentNeuralNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DecodingTargetLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DecodingTargetLanguage">https://w3id.org/amv#DecodingTargetLanguage</seealso>
    let DecodingTargetLanguage =
        Prefixed_Name(amv, "DecodingTargetLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DelbertRayFulkerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DelbertRayFulkerson">https://w3id.org/amv#DelbertRayFulkerson</seealso>
    let DelbertRayFulkerson = Prefixed_Name(amv, "DelbertRayFulkerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#DerrickHenryLehmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DerrickHenryLehmer">https://w3id.org/amv#DerrickHenryLehmer</seealso>
    let DerrickHenryLehmer = Prefixed_Name(amv, "DerrickHenryLehmer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Dictionary">https://w3id.org/amv#Dictionary</seealso>
    let Dictionary = Prefixed_Name(amv, "Dictionary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DifferentialCalculus</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#MathematicalProperties</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DifferentialCalculus">https://w3id.org/amv#DifferentialCalculus</seealso>
    let DifferentialCalculus =
        Prefixed_Name(amv, "DifferentialCalculus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DijkastrasAlgorithmTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DijkastrasAlgorithmTimeComplexity">https://w3id.org/amv#DijkastrasAlgorithmTimeComplexity</seealso>
    let DijkastrasAlgorithmTimeComplexity =
        Prefixed_Name(amv, "DijkastrasAlgorithmTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DijkstrasAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DijkstrasAlgorithm">https://w3id.org/amv#DijkstrasAlgorithm</seealso>
    let DijkstrasAlgorithm = Prefixed_Name(amv, "DijkstrasAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DivideAndConquerAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>"A divide and conquer algorithm consists of two parts: (i) Divide the problem into smaller subproblems of the same type, and solve these subproblems recursively; (ii) Combine the solutions to the subproblems into a solution to the original proble."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DivideAndConquerAlgorithm">https://w3id.org/amv#DivideAndConquerAlgorithm</seealso>
    let DivideAndConquerAlgorithm =
        Prefixed_Name(amv, "DivideAndConquerAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DoWhile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#LoopConstruct</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DoWhile">https://w3id.org/amv#DoWhile</seealso>
    let DoWhile = Prefixed_Name(amv, "DoWhile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#DonaldKnuth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DonaldKnuth">https://w3id.org/amv#DonaldKnuth</seealso>
    let DonaldKnuth = Prefixed_Name(amv, "DonaldKnuth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Drakon-chart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#FormOfExpression</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Drakon-chart">https://w3id.org/amv#Drakon-chart</seealso>
    let Drakon_chart = Prefixed_Name(amv, "Drakon-chart") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#DynamicProgrammingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A dynamic programming algorithm remembers past results and uses them to find new results.
    /// Dynamic programming is generally used for optimization problems, where multiple solutions exist but need to find the “best” one."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#DynamicProgrammingAlgorithm">https://w3id.org/amv#DynamicProgrammingAlgorithm</seealso>
    let DynamicProgrammingAlgorithm =
        Prefixed_Name(amv, "DynamicProgrammingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#EdouardLucas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EdouardLucas">https://w3id.org/amv#EdouardLucas</seealso>
    let EdouardLucas = Prefixed_Name(amv, "EdouardLucas") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#EdsgerWDijkstra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EdsgerWDijkstra">https://w3id.org/amv#EdsgerWDijkstra</seealso>
    let EdsgerWDijkstra = Prefixed_Name(amv, "EdsgerWDijkstra") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#EdwardWForgy</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EdwardWForgy">https://w3id.org/amv#EdwardWForgy</seealso>
    let EdwardWForgy = Prefixed_Name(amv, "EdwardWForgy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#EncoRNNTimeCom1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#TimeComplexity</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EncoRNNTimeCom1">https://w3id.org/amv#EncoRNNTimeCom1</seealso>
    let EncoRNNTimeCom1 = Prefixed_Name(amv, "EncoRNNTimeCom1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#EncoderDecoder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EncoderDecoder">https://w3id.org/amv#EncoderDecoder</seealso>
    let EncoderDecoder = Prefixed_Name(amv, "EncoderDecoder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#EncoderDecoderTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EncoderDecoderTimeComplexity">https://w3id.org/amv#EncoderDecoderTimeComplexity</seealso>
    let EncoderDecoderTimeComplexity =
        Prefixed_Name(amv, "EncoderDecoderTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#EncodingRecurrentNeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EncodingRecurrentNeuralNetwork">https://w3id.org/amv#EncodingRecurrentNeuralNetwork</seealso>
    let EncodingRecurrentNeuralNetwork =
        Prefixed_Name(amv, "EncodingRecurrentNeuralNetwork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#EncodingSourceLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#EncodingSourceLanguage">https://w3id.org/amv#EncodingSourceLanguage</seealso>
    let EncodingSourceLanguage =
        Prefixed_Name(amv, "EncodingSourceLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#ExponentialFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#ExponentialFunctions">https://w3id.org/amv#ExponentialFunctions</seealso>
    let ExponentialFunctions =
        Prefixed_Name(amv, "ExponentialFunctions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#FastMultipoleMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#FastMultipoleMethod">https://w3id.org/amv#FastMultipoleMethod</seealso>
    let FastMultipoleMethod = Prefixed_Name(amv, "FastMultipoleMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#FindingAMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#FindingAMatch">https://w3id.org/amv#FindingAMatch</seealso>
    let FindingAMatch = Prefixed_Name(amv, "FindingAMatch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Flowchart</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#FormOfExpression</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Flowchart">https://w3id.org/amv#Flowchart</seealso>
    let Flowchart = Prefixed_Name(amv, "Flowchart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#For</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#LoopConstruct</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#For">https://w3id.org/amv#For</seealso>
    let For = Prefixed_Name(amv, "For") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#FormOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The available form of expression/ notation of an algorithm. For example, Flowcharts, pseudocode, control tables, etc. (source: https://en.wikipedia.org/wiki/Algorithm)"</para>
    /// labels<para>"Form of expression"</para></remarks>
    /// <seealso href="https://w3id.org/amv#FormOfExpression">https://w3id.org/amv#FormOfExpression</seealso>
    let FormOfExpression = Prefixed_Name(amv, "FormOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Fortran</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Fortran">https://w3id.org/amv#Fortran</seealso>
    let Fortran = Prefixed_Name(amv, "Fortran") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GNU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:LicenseDocument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GNU">https://w3id.org/amv#GNU</seealso>
    let GNU = Prefixed_Name(amv, "GNU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GPL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:LicenseDocument</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GPL">https://w3id.org/amv#GPL</seealso>
    let GPL = Prefixed_Name(amv, "GPL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GaussianElimination</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#MathematicalProperties</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GaussianElimination">https://w3id.org/amv#GaussianElimination</seealso>
    let GaussianElimination = Prefixed_Name(amv, "GaussianElimination") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GeorgeDantzig</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GeorgeDantzig">https://w3id.org/amv#GeorgeDantzig</seealso>
    let GeorgeDantzig = Prefixed_Name(amv, "GeorgeDantzig") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Graph"</para></remarks>
    /// <seealso href="https://w3id.org/amv#Graph">https://w3id.org/amv#Graph</seealso>
    let Graph = Prefixed_Name(amv, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GraphDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GraphDataStructure">https://w3id.org/amv#GraphDataStructure</seealso>
    let GraphDataStructure = Prefixed_Name(amv, "GraphDataStructure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GraphProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Graph is a non-linear data structure consisting of nodes and edges. The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Graph Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#GraphProblem">https://w3id.org/amv#GraphProblem</seealso>
    let GraphProblem = Prefixed_Name(amv, "GraphProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GraphTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#MathematicalProperties</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GraphTheory">https://w3id.org/amv#GraphTheory</seealso>
    let GraphTheory = Prefixed_Name(amv, "GraphTheory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#GreedyAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#GreedyAlgorithm">https://w3id.org/amv#GreedyAlgorithm</seealso>
    let GreedyAlgorithm = Prefixed_Name(amv, "GreedyAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#HardProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any graph problem, which is NP-hard in general graphs, becomes polynomial-time solvable when restricted to graphs in special
    /// classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hard Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#HardProblem">https://w3id.org/amv#HardProblem</seealso>
    let HardProblem = Prefixed_Name(amv, "HardProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#HashTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#HashTable">https://w3id.org/amv#HashTable</seealso>
    let HashTable = Prefixed_Name(amv, "HashTable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#HeapSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#HeapSort">https://w3id.org/amv#HeapSort</seealso>
    let HeapSort = Prefixed_Name(amv, "HeapSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#HeapSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#HeapSortSpaceComplexity">https://w3id.org/amv#HeapSortSpaceComplexity</seealso>
    let HeapSortSpaceComplexity =
        Prefixed_Name(amv, "HeapSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#HeapSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#HeapSortTimeComplexity">https://w3id.org/amv#HeapSortTimeComplexity</seealso>
    let HeapSortTimeComplexity =
        Prefixed_Name(amv, "HeapSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Hypergraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    ///
    /// labels<para>"Hypergraph"</para></remarks>
    /// <seealso href="https://w3id.org/amv#Hypergraph">https://w3id.org/amv#Hypergraph</seealso>
    let Hypergraph = Prefixed_Name(amv, "Hypergraph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#IlyaSutskever</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#IlyaSutskever">https://w3id.org/amv#IlyaSutskever</seealso>
    let IlyaSutskever = Prefixed_Name(amv, "IlyaSutskever") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manifestation of a technical specification or algorithm as a program, software component, or other computer system through computer programming and deployment (source: https://en.wikipedia.org/wiki/Implementation)."</para>
    /// labels<para>"Implementation"</para></remarks>
    /// <seealso href="https://w3id.org/amv#Implementation">https://w3id.org/amv#Implementation</seealso>
    let Implementation = Prefixed_Name(amv, "Implementation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#InsertionSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#InsertionSort">https://w3id.org/amv#InsertionSort</seealso>
    let InsertionSort = Prefixed_Name(amv, "InsertionSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#InsertionSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#InsertionSortSpaceComplexity">https://w3id.org/amv#InsertionSortSpaceComplexity</seealso>
    let InsertionSortSpaceComplexity =
        Prefixed_Name(amv, "InsertionSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#InsertionSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#InsertionSortTimeComplexity">https://w3id.org/amv#InsertionSortTimeComplexity</seealso>
    let InsertionSortTimeComplexity =
        Prefixed_Name(amv, "InsertionSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Internal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:RightsStatement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Internal">https://w3id.org/amv#Internal</seealso>
    let Internal = Prefixed_Name(amv, "Internal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JHHalton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JHHalton">https://w3id.org/amv#JHHalton</seealso>
    let JHHalton = Prefixed_Name(amv, "JHHalton") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JWJWilliams</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JWJWilliams">https://w3id.org/amv#JWJWilliams</seealso>
    let JWJWilliams = Prefixed_Name(amv, "JWJWilliams") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JamesHMorris</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JamesHMorris">https://w3id.org/amv#JamesHMorris</seealso>
    let JamesHMorris = Prefixed_Name(amv, "JamesHMorris") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JaromirDolecek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JaromirDolecek">https://w3id.org/amv#JaromirDolecek</seealso>
    let JaromirDolecek = Prefixed_Name(amv, "JaromirDolecek") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Java</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Java">https://w3id.org/amv#Java</seealso>
    let Java = Prefixed_Name(amv, "Java") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JillianBeardwood</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JillianBeardwood">https://w3id.org/amv#JillianBeardwood</seealso>
    let JillianBeardwood = Prefixed_Name(amv, "JillianBeardwood") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JohnHammersley</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JohnHammersley">https://w3id.org/amv#JohnHammersley</seealso>
    let JohnHammersley = Prefixed_Name(amv, "JohnHammersley") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JohnMauchly</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JohnMauchly">https://w3id.org/amv#JohnMauchly</seealso>
    let JohnMauchly = Prefixed_Name(amv, "JohnMauchly") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JohnVonNeumann</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JohnVonNeumann">https://w3id.org/amv#JohnVonNeumann</seealso>
    let JohnVonNeumann = Prefixed_Name(amv, "JohnVonNeumann") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#JoshuaJArulanandham</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#JoshuaJArulanandham">https://w3id.org/amv#JoshuaJArulanandham</seealso>
    let JoshuaJArulanandham = Prefixed_Name(amv, "JoshuaJArulanandham") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#KenThompson</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#KenThompson">https://w3id.org/amv#KenThompson</seealso>
    let KenThompson = Prefixed_Name(amv, "KenThompson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LRFord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#LRFord">https://w3id.org/amv#LRFord</seealso>
    let LRFord = Prefixed_Name(amv, "LRFord") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LinearAlgebra</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#pub_Discipline</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#MathematicalProperties</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#LinearAlgebra">https://w3id.org/amv#LinearAlgebra</seealso>
    let LinearAlgebra = Prefixed_Name(amv, "LinearAlgebra") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LinearFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#LinearFunctions">https://w3id.org/amv#LinearFunctions</seealso>
    let LinearFunctions = Prefixed_Name(amv, "LinearFunctions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LinkedList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#LinkedList">https://w3id.org/amv#LinkedList</seealso>
    let LinkedList = Prefixed_Name(amv, "LinkedList") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Lisp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Lisp">https://w3id.org/amv#Lisp</seealso>
    let Lisp = Prefixed_Name(amv, "Lisp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#List</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#DataStructure</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#List">https://w3id.org/amv#List</seealso>
    let List = Prefixed_Name(amv, "List") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LlewellynThomas</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#LlewellynThomas">https://w3id.org/amv#LlewellynThomas</seealso>
    let LlewellynThomas = Prefixed_Name(amv, "LlewellynThomas") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LogarithmicFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#LogarithmicFunction">https://w3id.org/amv#LogarithmicFunction</seealso>
    let LogarithmicFunction = Prefixed_Name(amv, "LogarithmicFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#LoopConstruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of loop best suited when an algorithm is implemented in any desired programming language. The loop types are for loop, while loop, do-while loop."</para>
    /// labels<para>"Loop construct"</para></remarks>
    /// <seealso href="https://w3id.org/amv#LoopConstruct">https://w3id.org/amv#LoopConstruct</seealso>
    let LoopConstruct = Prefixed_Name(amv, "LoopConstruct") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#MS-DOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>schemas:OperatingSystem</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MS-DOS">https://w3id.org/amv#MS-DOS</seealso>
    let MS_DOS = Prefixed_Name(amv, "MS-DOS") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#MatchFindingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MatchFindingAlgorithm">https://w3id.org/amv#MatchFindingAlgorithm</seealso>
    let MatchFindingAlgorithm =
        Prefixed_Name(amv, "MatchFindingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Mathematica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Mathematica">https://w3id.org/amv#Mathematica</seealso>
    let Mathematica = Prefixed_Name(amv, "Mathematica") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#MathematicalProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The mathematical concept used in the algorithm to tackle the problem. This includes set theoty, linear algebra, graph theory etc."</para>
    /// labels<para>"Mathematical property"</para></remarks>
    /// <seealso href="https://w3id.org/amv#MathematicalProperties">https://w3id.org/amv#MathematicalProperties</seealso>
    let MathematicalProperties =
        Prefixed_Name(amv, "MathematicalProperties") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Mathematics</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#pub_Discipline</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Mathematics">https://w3id.org/amv#Mathematics</seealso>
    let Mathematics = Prefixed_Name(amv, "Mathematics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Matlab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Matlab">https://w3id.org/amv#Matlab</seealso>
    let Matlab = Prefixed_Name(amv, "Matlab") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#MergeSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MergeSort">https://w3id.org/amv#MergeSort</seealso>
    let MergeSort = Prefixed_Name(amv, "MergeSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#MergeSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MergeSortSpaceComplexity">https://w3id.org/amv#MergeSortSpaceComplexity</seealso>
    let MergeSortSpaceComplexity =
        Prefixed_Name(amv, "MergeSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#MergeSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MergeSortTimeComplexity">https://w3id.org/amv#MergeSortTimeComplexity</seealso>
    let MergeSortTimeComplexity =
        Prefixed_Name(amv, "MergeSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#MessageComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The number of messages passed. This is an important measure, primarily applicable in case of distributed algorithms."</para>
    /// labels<para>"Message complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#MessageComplexity">https://w3id.org/amv#MessageComplexity</seealso>
    let MessageComplexity = Prefixed_Name(amv, "MessageComplexity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Metric"</para></remarks>
    /// <seealso href="https://w3id.org/amv#Metric">https://w3id.org/amv#Metric</seealso>
    let Metric = Prefixed_Name(amv, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#MichaelDinneen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MichaelDinneen">https://w3id.org/amv#MichaelDinneen</seealso>
    let MichaelDinneen = Prefixed_Name(amv, "MichaelDinneen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#MicrosoftWindows</para>
    /// </summary>
    /// <remarks>
    ///   <para>schemas:OperatingSystem</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#MicrosoftWindows">https://w3id.org/amv#MicrosoftWindows</seealso>
    let MicrosoftWindows = Prefixed_Name(amv, "MicrosoftWindows") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#NaturalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#FormOfExpression</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#NaturalLanguage">https://w3id.org/amv#NaturalLanguage</seealso>
    let NaturalLanguage = Prefixed_Name(amv, "NaturalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#NetworkFlowTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:AcademicArticle</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#NetworkFlowTheory">https://w3id.org/amv#NetworkFlowTheory</seealso>
    let NetworkFlowTheory = Prefixed_Name(amv, "NetworkFlowTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#NeuralMachineTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Problem</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#NeuralMachineTranslation">https://w3id.org/amv#NeuralMachineTranslation</seealso>
    let NeuralMachineTranslation =
        Prefixed_Name(amv, "NeuralMachineTranslation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#NilsNilson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#NilsNilson">https://w3id.org/amv#NilsNilson</seealso>
    let NilsNilson = Prefixed_Name(amv, "NilsNilson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#NumericalProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Numerical algorithms are behind designing shapes (e.g. shapes for cars, planes, fonts), computing intensities for displaying graphics, animating moving objects, studying the spread of diseases, modelling the orbit of planets and satellites, supporting search engines such as google, and many more practical problems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Numerical Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#NumericalProblem">https://w3id.org/amv#NumericalProblem</seealso>
    let NumericalProblem = Prefixed_Name(amv, "NumericalProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#OnARoutingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:AcademicArticle</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#OnARoutingProblem">https://w3id.org/amv#OnARoutingProblem</seealso>
    let OnARoutingProblem = Prefixed_Name(amv, "OnARoutingProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#OptimizationProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An optimization problem is the problem of finding the best solution from all feasible solutions."</para>
    /// labels<para>"Optimization problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#OptimizationProblem">https://w3id.org/amv#OptimizationProblem</seealso>
    let OptimizationProblem = Prefixed_Name(amv, "OptimizationProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#OriolVinyals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#OriolVinyals">https://w3id.org/amv#OriolVinyals</seealso>
    let OriolVinyals = Prefixed_Name(amv, "OriolVinyals") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#PHP</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#PHP">https://w3id.org/amv#PHP</seealso>
    let PHP = Prefixed_Name(amv, "PHP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Pascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Pascal">https://w3id.org/amv#Pascal</seealso>
    let Pascal = Prefixed_Name(amv, "Pascal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#PerAustrin</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#PerAustrin">https://w3id.org/amv#PerAustrin</seealso>
    let PerAustrin = Prefixed_Name(amv, "PerAustrin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#PerformanceMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Performance metrics (e.g., accuracy, precision, recall) are used to evaluate different algorithms."</para>
    /// labels<para>"Performance metric"</para></remarks>
    /// <seealso href="https://w3id.org/amv#PerformanceMetric">https://w3id.org/amv#PerformanceMetric</seealso>
    let PerformanceMetric = Prefixed_Name(amv, "PerformanceMetric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#PeterHart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#PeterHart">https://w3id.org/amv#PeterHart</seealso>
    let PeterHart = Prefixed_Name(amv, "PeterHart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#PeterMcIlroy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#PeterMcIlroy">https://w3id.org/amv#PeterMcIlroy</seealso>
    let PeterMcIlroy = Prefixed_Name(amv, "PeterMcIlroy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#PokSonKim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#PokSonKim">https://w3id.org/amv#PokSonKim</seealso>
    let PokSonKim = Prefixed_Name(amv, "PokSonKim") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#PolynomialTimeProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Polynomial time problem means that an algorithm exists for its solution such that the number of steps in the algorithm is bounded by a polynomial function of n, where n corresponds to the length of the input for the problem."</para>
    /// labels<para>"Polynomial Time Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#PolynomialTimeProblem">https://w3id.org/amv#PolynomialTimeProblem</seealso>
    let PolynomialTimeProblem =
        Prefixed_Name(amv, "PolynomialTimeProblem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#PriorityQueue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#PriorityQueue">https://w3id.org/amv#PriorityQueue</seealso>
    let PriorityQueue = Prefixed_Name(amv, "PriorityQueue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Problem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The various problems for which an algorithm is written."</para>
    /// labels<para>"Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#Problem">https://w3id.org/amv#Problem</seealso>
    let Problem = Prefixed_Name(amv, "Problem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Language designed to communicate instructions to a machine Programming languages are used in computer programming to implement algorithms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Programming language"</para></remarks>
    /// <seealso href="https://w3id.org/amv#ProgrammingLanguage">https://w3id.org/amv#ProgrammingLanguage</seealso>
    let ProgrammingLanguage = Prefixed_Name(amv, "ProgrammingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Pseudocode</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#FormOfExpression</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Pseudocode">https://w3id.org/amv#Pseudocode</seealso>
    let Pseudocode = Prefixed_Name(amv, "Pseudocode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Public</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:RightsStatement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Public">https://w3id.org/amv#Public</seealso>
    let Public = Prefixed_Name(amv, "Public") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Python</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Python">https://w3id.org/amv#Python</seealso>
    let Python = Prefixed_Name(amv, "Python") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#QuadriticFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmAnalysisFunction</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QuadriticFunction">https://w3id.org/amv#QuadriticFunction</seealso>
    let QuadriticFunction = Prefixed_Name(amv, "QuadriticFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#QuartApplMath.</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bibo:Journal</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QuartApplMath.">https://w3id.org/amv#QuartApplMath.</seealso>
    let ``QuartApplMath.`` = Prefixed_Name(amv, "QuartApplMath.") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#QueryProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QueryProcessing">https://w3id.org/amv#QueryProcessing</seealso>
    let QueryProcessing = Prefixed_Name(amv, "QueryProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#QueryProcessingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QueryProcessingAlgorithm">https://w3id.org/amv#QueryProcessingAlgorithm</seealso>
    let QueryProcessingAlgorithm =
        Prefixed_Name(amv, "QueryProcessingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Queue</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#DataStructure</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Queue">https://w3id.org/amv#Queue</seealso>
    let Queue = Prefixed_Name(amv, "Queue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#QuickSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QuickSort">https://w3id.org/amv#QuickSort</seealso>
    let QuickSort = Prefixed_Name(amv, "QuickSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#QuickSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QuickSortSpaceComplexity">https://w3id.org/amv#QuickSortSpaceComplexity</seealso>
    let QuickSortSpaceComplexity =
        Prefixed_Name(amv, "QuickSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#QuickSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QuickSortTimeComplexity">https://w3id.org/amv#QuickSortTimeComplexity</seealso>
    let QuickSortTimeComplexity =
        Prefixed_Name(amv, "QuickSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#QuocVLe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#QuocVLe">https://w3id.org/amv#QuocVLe</seealso>
    let QuocVLe = Prefixed_Name(amv, "QuocVLe") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#R</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#ProgrammingLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#R">https://w3id.org/amv#R</seealso>
    let R = Prefixed_Name(amv, "R") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#RandomizedAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A randomized algorithm uses a random number at least once during the computation to make a decision."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#RandomizedAlgorithm">https://w3id.org/amv#RandomizedAlgorithm</seealso>
    let RandomizedAlgorithm = Prefixed_Name(amv, "RandomizedAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#RatioBasedStableIn-placeMerging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#RatioBasedStableIn-placeMerging">https://w3id.org/amv#RatioBasedStableIn-placeMerging</seealso>
    let RatioBasedStableIn_placeMerging =
        Prefixed_Name(amv, "RatioBasedStableIn-placeMerging") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#RecursiveAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#AlgorithmicType</para>
    ///   <para>"A simple recursive algorithm: (i) Solves the base cases directly; (ii) Recurs with a simpler subproblem; (iii) Does some extra work to convert the solution to the simpler subproblem into a solution to the given problem.
    /// It is called “simple” because several of the other algorithm types are inherently recursive. (source: https://www.cis.upenn.edu/~matuszek/cit594-2003/Lectures/35-algorithm-types.ppt)"</para>
    /// labels<para>"Recursive algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/amv#RecursiveAlgorithm">https://w3id.org/amv#RecursiveAlgorithm</seealso>
    let RecursiveAlgorithm = Prefixed_Name(amv, "RecursiveAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#RedHatLinux</para>
    /// </summary>
    /// <remarks>
    ///   <para>schemas:OperatingSystem</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#RedHatLinux">https://w3id.org/amv#RedHatLinux</seealso>
    let RedHatLinux = Prefixed_Name(amv, "RedHatLinux") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#RichardEBellman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#RichardEBellman">https://w3id.org/amv#RichardEBellman</seealso>
    let RichardEBellman = Prefixed_Name(amv, "RichardEBellman") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#SelectionSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SelectionSort">https://w3id.org/amv#SelectionSort</seealso>
    let SelectionSort = Prefixed_Name(amv, "SelectionSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SelectionSortImplementationInC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SelectionSortImplementationInC">https://w3id.org/amv#SelectionSortImplementationInC</seealso>
    let SelectionSortImplementationInC =
        Prefixed_Name(amv, "SelectionSortImplementationInC") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SelectionSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SelectionSortSpaceComplexity">https://w3id.org/amv#SelectionSortSpaceComplexity</seealso>
    let SelectionSortSpaceComplexity =
        Prefixed_Name(amv, "SelectionSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SelectionSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SelectionSortTimeComplexity">https://w3id.org/amv#SelectionSortTimeComplexity</seealso>
    let SelectionSortTimeComplexity =
        Prefixed_Name(amv, "SelectionSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SelmerMJohnson</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SelmerMJohnson">https://w3id.org/amv#SelmerMJohnson</seealso>
    let SelmerMJohnson = Prefixed_Name(amv, "SelmerMJohnson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SequenceToSequenceLearningWithNeuralNetworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SequenceToSequenceLearningWithNeuralNetworks">https://w3id.org/amv#SequenceToSequenceLearningWithNeuralNetworks</seealso>
    let SequenceToSequenceLearningWithNeuralNetworks =
        Prefixed_Name(amv, "SequenceToSequenceLearningWithNeuralNetworks") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SetProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sets are collections of symbols whose order is assumed to carry no significance."</para>
    /// labels<para>"Set Problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#SetProblem">https://w3id.org/amv#SetProblem</seealso>
    let SetProblem = Prefixed_Name(amv, "SetProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#ShortestPathProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#PolynomialTimeProblem</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Shortest path problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#ShortestPathProblem">https://w3id.org/amv#ShortestPathProblem</seealso>
    let ShortestPathProblem = Prefixed_Name(amv, "ShortestPathProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#SmoothSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SmoothSort">https://w3id.org/amv#SmoothSort</seealso>
    let SmoothSort = Prefixed_Name(amv, "SmoothSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SmoothSortAlternativeForSortingInSitu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SmoothSortAlternativeForSortingInSitu">https://w3id.org/amv#SmoothSortAlternativeForSortingInSitu</seealso>
    let SmoothSortAlternativeForSortingInSitu =
        Prefixed_Name(amv, "SmoothSortAlternativeForSortingInSitu") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SmoothSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SmoothSortSpaceComplexity">https://w3id.org/amv#SmoothSortSpaceComplexity</seealso>
    let SmoothSortSpaceComplexity =
        Prefixed_Name(amv, "SmoothSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#SmoothSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#SmoothSortTimeComplexity">https://w3id.org/amv#SmoothSortTimeComplexity</seealso>
    let SmoothSortTimeComplexity =
        Prefixed_Name(amv, "SmoothSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#Sorting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#CombinatorialProblem</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Sorting">https://w3id.org/amv#Sorting</seealso>
    let Sorting = Prefixed_Name(amv, "Sorting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#SpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Space complexity of an algorithm quantifies the amount of space or memory taken by an algorithm to run as a function of the length of the input."</para>
    /// labels<para>"Space complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#SpaceComplexity">https://w3id.org/amv#SpaceComplexity</seealso>
    let SpaceComplexity = Prefixed_Name(amv, "SpaceComplexity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Statistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#pub_Discipline</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Statistics">https://w3id.org/amv#Statistics</seealso>
    let Statistics = Prefixed_Name(amv, "Statistics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#StringProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Strings are defined by the sequence or arrangement of symbols"</para>
    /// labels<para>"String problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#StringProblem">https://w3id.org/amv#StringProblem</seealso>
    let StringProblem = Prefixed_Name(amv, "StringProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#StuartLloyd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#StuartLloyd">https://w3id.org/amv#StuartLloyd</seealso>
    let StuartLloyd = Prefixed_Name(amv, "StuartLloyd") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#TheoryOfSets</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#MathematicalProperties</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TheoryOfSets">https://w3id.org/amv#TheoryOfSets</seealso>
    let TheoryOfSets = Prefixed_Name(amv, "TheoryOfSets") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#TheoryOfStatisticsAndProbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#MathematicalProperties</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TheoryOfStatisticsAndProbability">https://w3id.org/amv#TheoryOfStatisticsAndProbability</seealso>
    let TheoryOfStatisticsAndProbability =
        Prefixed_Name(amv, "TheoryOfStatisticsAndProbability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#TimPeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TimPeters">https://w3id.org/amv#TimPeters</seealso>
    let TimPeters = Prefixed_Name(amv, "TimPeters") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#TimSort</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#Algorithm</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TimSort">https://w3id.org/amv#TimSort</seealso>
    let TimSort = Prefixed_Name(amv, "TimSort") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#TimSortImplementedInPython</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TimSortImplementedInPython">https://w3id.org/amv#TimSortImplementedInPython</seealso>
    let TimSortImplementedInPython =
        Prefixed_Name(amv, "TimSortImplementedInPython") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#TimSortSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TimSortSpaceComplexity">https://w3id.org/amv#TimSortSpaceComplexity</seealso>
    let TimSortSpaceComplexity =
        Prefixed_Name(amv, "TimSortSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#TimSortTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TimSortTimeComplexity">https://w3id.org/amv#TimSortTimeComplexity</seealso>
    let TimSortTimeComplexity =
        Prefixed_Name(amv, "TimSortTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#TimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents the number of times a statement is executed."</para>
    ///   <para>"Time complexity of an algorithm quantifies the amount of time taken by an algorithm to run as a function of the length of the input.
    ///
    /// It measures only the executing time of the algorithm in a way that depends only on the algorithm itself and its input."</para>
    /// labels<para>"Time complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#TimeComplexity">https://w3id.org/amv#TimeComplexity</seealso>
    let TimeComplexity = Prefixed_Name(amv, "TimeComplexity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#TobiasDantzig</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#TobiasDantzig">https://w3id.org/amv#TobiasDantzig</seealso>
    let TobiasDantzig = Prefixed_Name(amv, "TobiasDantzig") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#UndirectedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#UndirectedGraph">https://w3id.org/amv#UndirectedGraph</seealso>
    let UndirectedGraph = Prefixed_Name(amv, "UndirectedGraph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#Unix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schemas:OperatingSystem</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#Unix">https://w3id.org/amv#Unix</seealso>
    let Unix = Prefixed_Name(amv, "Unix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#UserQueryProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#PolynomialTimeProblem</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#UserQueryProcessing">https://w3id.org/amv#UserQueryProcessing</seealso>
    let UserQueryProcessing = Prefixed_Name(amv, "UserQueryProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#UserQueryProcessingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Algorithm</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#UserQueryProcessingAlgorithm">https://w3id.org/amv#UserQueryProcessingAlgorithm</seealso>
    let UserQueryProcessingAlgorithm =
        Prefixed_Name(amv, "UserQueryProcessingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#VaughanPratt</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#VaughanPratt">https://w3id.org/amv#VaughanPratt</seealso>
    let VaughanPratt = Prefixed_Name(amv, "VaughanPratt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#While</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#LoopConstruct</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#While">https://w3id.org/amv#While</seealso>
    let While = Prefixed_Name(amv, "While") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#WilliamWesleyPeterson</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#WilliamWesleyPeterson">https://w3id.org/amv#WilliamWesleyPeterson</seealso>
    let WilliamWesleyPeterson =
        Prefixed_Name(amv, "WilliamWesleyPeterson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The information on access (i.e modify, read, download) to the algorithm."</para>
    /// labels<para>"accessibility"</para></remarks>
    /// <seealso href="https://w3id.org/amv#accessibility">https://w3id.org/amv#accessibility</seealso>
    let accessibility = Prefixed_Name(amv, "accessibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It is the measure of the degree of closeness of a measured or calculated value to its actual value."</para>
    ///   <para>"How close the output will be to a set point."</para>
    /// labels<para>"accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#accuracy">https://w3id.org/amv#accuracy</seealso>
    let accuracy = Prefixed_Name(amv, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"acronym"</para></remarks>
    /// <seealso href="https://w3id.org/amv#acronym">https://w3id.org/amv#acronym</seealso>
    let acronym = Prefixed_Name(amv, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#affiliationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"affiliation of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#affiliationOf">https://w3id.org/amv#affiliationOf</seealso>
    let affiliationOf = Prefixed_Name(amv, "affiliationOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#affliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An organization that the person is affiliated with. For example, a school/university."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"affliation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#affliation">https://w3id.org/amv#affliation</seealso>
    let affliation = Prefixed_Name(amv, "affliation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#algorithmTypeFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Is an algorithm type for an algorithm."</para>
    /// labels<para>"algorithm type for"</para></remarks>
    /// <seealso href="https://w3id.org/amv#algorithmTypeFor">https://w3id.org/amv#algorithmTypeFor</seealso>
    let algorithmTypeFor = Prefixed_Name(amv, "algorithmTypeFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#alternativeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An alternative title of a resource."</para>
    /// labels<para>"alternative title"</para></remarks>
    /// <seealso href="https://w3id.org/amv#alternativeTitle">https://w3id.org/amv#alternativeTitle</seealso>
    let alternativeTitle = Prefixed_Name(amv, "alternativeTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#analysisFunctionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The various function types for analysis of algorithms like logarithmic functions, exponential functions etc."</para>
    /// labels<para>"analysis function type"</para></remarks>
    /// <seealso href="https://w3id.org/amv#analysisFunctionType">https://w3id.org/amv#analysisFunctionType</seealso>
    let analysisFunctionType =
        Prefixed_Name(amv, "analysisFunctionType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#analysisFunctionTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"analysis function type of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#analysisFunctionTypeOf">https://w3id.org/amv#analysisFunctionTypeOf</seealso>
    let analysisFunctionTypeOf =
        Prefixed_Name(amv, "analysisFunctionTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#availableAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An algorithm for a given problem."</para>
    /// labels<para>"available algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/amv#availableAlgorithm">https://w3id.org/amv#availableAlgorithm</seealso>
    let availableAlgorithm = Prefixed_Name(amv, "availableAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#averageMessageComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"average message complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#averageMessageComplexity">https://w3id.org/amv#averageMessageComplexity</seealso>
    let averageMessageComplexity =
        Prefixed_Name(amv, "averageMessageComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#averageSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Space complexity of an algorithm on average.(https://www.wikidata.org/wiki/Property:P3757)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"average space complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#averageSpaceComplexity">https://w3id.org/amv#averageSpaceComplexity</seealso>
    let averageSpaceComplexity =
        Prefixed_Name(amv, "averageSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#averageTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time complexity of an algorithm on average. (https://www.wikidata.org/wiki/Property:P3754)"</para>
    /// labels<para>"average time complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#averageTimeComplexity">https://w3id.org/amv#averageTimeComplexity</seealso>
    let averageTimeComplexity =
        Prefixed_Name(amv, "averageTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#bestCaseMessageComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"best case message complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#bestCaseMessageComplexity">https://w3id.org/amv#bestCaseMessageComplexity</seealso>
    let bestCaseMessageComplexity =
        Prefixed_Name(amv, "bestCaseMessageComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#bestCaseSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Space complexity of an algorithm at least.(https://www.wikidata.org/wiki/Property:P3756)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"best case space complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#bestCaseSpaceComplexity">https://w3id.org/amv#bestCaseSpaceComplexity</seealso>
    let bestCaseSpaceComplexity =
        Prefixed_Name(amv, "bestCaseSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#bestCaseTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time complexity of an algorithm at least. (https://www.wikidata.org/wiki/Property:P3753)"</para>
    /// labels<para>"best case time complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#bestCaseTimeComplexity">https://w3id.org/amv#bestCaseTimeComplexity</seealso>
    let bestCaseTimeComplexity =
        Prefixed_Name(amv, "bestCaseTimeComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#commentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"comment of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#commentOf">https://w3id.org/amv#commentOf</seealso>
    let commentOf = Prefixed_Name(amv, "commentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#computesSolutionTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of problem the algorithm solves."</para>
    ///   <para>"Problem that this algorithm or method solves.(https://www.wikidata.org/wiki/Property:P2159)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"computes solution to"</para></remarks>
    /// <seealso href="https://w3id.org/amv#computesSolutionTo">https://w3id.org/amv#computesSolutionTo</seealso>
    let computesSolutionTo = Prefixed_Name(amv, "computesSolutionTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Limitations that an algorithm posses."</para>
    /// labels<para>"constraint"</para></remarks>
    /// <seealso href="https://w3id.org/amv#constraint">https://w3id.org/amv#constraint</seealso>
    let constraint_ = Prefixed_Name(amv, "constraint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#cpuTimeLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time taken by CPU while executing the program.(In seconds)"</para>
    /// labels<para>"cpu time limit"</para></remarks>
    /// <seealso href="https://w3id.org/amv#cpuTimeLimit">https://w3id.org/amv#cpuTimeLimit</seealso>
    let cpuTimeLimit = Prefixed_Name(amv, "cpuTimeLimit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#dataStructureUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The data structure used in an algorithm."</para>
    /// labels<para>"data Structure Used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#dataStructureUsed">https://w3id.org/amv#dataStructureUsed</seealso>
    let dataStructureUsed = Prefixed_Name(amv, "dataStructureUsed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#dataStructureUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"data Structure Used In"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#dataStructureUsedIn">https://w3id.org/amv#dataStructureUsedIn</seealso>
    let dataStructureUsedIn = Prefixed_Name(amv, "dataStructureUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#definingFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The mathematical formula used for solving the problem.
    /// Mathematical formula representing a theorem or law."</para>
    /// labels<para>"defining formula"</para></remarks>
    /// <seealso href="https://w3id.org/amv#definingFormula">https://w3id.org/amv#definingFormula</seealso>
    let definingFormula = Prefixed_Name(amv, "definingFormula") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"definiton"</para></remarks>
    /// <seealso href="https://w3id.org/amv#definition">https://w3id.org/amv#definition</seealso>
    let definition = Prefixed_Name(amv, "definition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#edgeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Input values that require special handling in an algorithm. When using the algorithm at an extreme(maximum or minimum) operating parameters."</para>
    /// labels<para>"edge Case"</para></remarks>
    /// <seealso href="https://w3id.org/amv#edgeCase">https://w3id.org/amv#edgeCase</seealso>
    let edgeCase = Prefixed_Name(amv, "edgeCase") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#excerpt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An excerpt is a contiguous or discontiguous portion, or a passage selected from a larger work or document."</para>
    /// labels<para>"excerpt"</para></remarks>
    /// <seealso href="https://w3id.org/amv#excerpt">https://w3id.org/amv#excerpt</seealso>
    let excerpt = Prefixed_Name(amv, "excerpt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#firstWrittenRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"First time a subject was mentioned in writing.(https://www.wikidata.org/wiki/Property:P1249)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"time of earliest written record"</para></remarks>
    /// <seealso href="https://w3id.org/amv#firstWrittenRecord">https://w3id.org/amv#firstWrittenRecord</seealso>
    let firstWrittenRecord = Prefixed_Name(amv, "firstWrittenRecord") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#flexible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The algorithm written in such a way that it allows to add new features without changing the existing module."</para>
    /// labels<para>"flexible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#flexible">https://w3id.org/amv#flexible</seealso>
    let flexible = Prefixed_Name(amv, "flexible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#formOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The form of expression of an Algorithm."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"form of expression"</para></remarks>
    /// <seealso href="https://w3id.org/amv#formOfExpression">https://w3id.org/amv#formOfExpression</seealso>
    let formOfExpression = Prefixed_Name(amv, "formOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#formOfExpressionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The form of expression of an Algorithm."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"form Of expression of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#formOfExpressionOf">https://w3id.org/amv#formOfExpressionOf</seealso>
    let formOfExpressionOf = Prefixed_Name(amv, "formOfExpressionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#formalDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"formal definition"</para></remarks>
    /// <seealso href="https://w3id.org/amv#formalDefinition">https://w3id.org/amv#formalDefinition</seealso>
    let formalDefinition = Prefixed_Name(amv, "formalDefinition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#hasImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The various applications of the algorithm."</para>
    /// labels<para>"has implementation"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasImplementation">https://w3id.org/amv#hasImplementation</seealso>
    let hasImplementation = Prefixed_Name(amv, "hasImplementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#hasMessageComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has message complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasMessageComplexity">https://w3id.org/amv#hasMessageComplexity</seealso>
    let hasMessageComplexity =
        Prefixed_Name(amv, "hasMessageComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has metric"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasMetric">https://w3id.org/amv#hasMetric</seealso>
    let hasMetric = Prefixed_Name(amv, "hasMetric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#hasPerformanceMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has performance metric"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasPerformanceMetric">https://w3id.org/amv#hasPerformanceMetric</seealso>
    let hasPerformanceMetric =
        Prefixed_Name(amv, "hasPerformanceMetric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#hasSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has space complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasSpaceComplexity">https://w3id.org/amv#hasSpaceComplexity</seealso>
    let hasSpaceComplexity = Prefixed_Name(amv, "hasSpaceComplexity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#hasSubalgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has subalgorithm"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasSubalgorithm">https://w3id.org/amv#hasSubalgorithm</seealso>
    let hasSubalgorithm = Prefixed_Name(amv, "hasSubalgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#hasSubproblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a problem that is contingent on or forms a part of another more inclusive problem."</para>
    /// labels<para>"has subproblem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasSubproblem">https://w3id.org/amv#hasSubproblem</seealso>
    let hasSubproblem = Prefixed_Name(amv, "hasSubproblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#hasTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#hasTimeComplexity">https://w3id.org/amv#hasTimeComplexity</seealso>
    let hasTimeComplexity = Prefixed_Name(amv, "hasTimeComplexity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#implementationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The various applications of the algorithm."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implementation of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#implementationOf">https://w3id.org/amv#implementationOf</seealso>
    let implementationOf = Prefixed_Name(amv, "implementationOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Something that is operated on by any process or system. An algorithm can have zero or more inputs."</para>
    /// labels<para>"input"</para></remarks>
    /// <seealso href="https://w3id.org/amv#input">https://w3id.org/amv#input</seealso>
    let input = Prefixed_Name(amv, "input") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#inputDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Input description of an algorithm."</para>
    /// labels<para>"input description"</para></remarks>
    /// <seealso href="https://w3id.org/amv#inputDescription">https://w3id.org/amv#inputDescription</seealso>
    let inputDescription = Prefixed_Name(amv, "inputDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#inputImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"output image"</para></remarks>
    /// <seealso href="https://w3id.org/amv#inputImage">https://w3id.org/amv#inputImage</seealso>
    let inputImage = Prefixed_Name(amv, "inputImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#isATypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The different type of algorithmic techniques that are used to solve the various existing problems in the most optimized manner.This classification is neither exhaustive nor disjoint but highlights the various ways in which a problem can be addressed."</para>
    ///   <para>"The nature or genre of an algorithm."</para>
    /// labels<para>"is a type of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#isATypeOf">https://w3id.org/amv#isATypeOf</seealso>
    let isATypeOf = Prefixed_Name(amv, "isATypeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#isInputImageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is input image of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#isInputImageOf">https://w3id.org/amv#isInputImageOf</seealso>
    let isInputImageOf = Prefixed_Name(amv, "isInputImageOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#isOutputImageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is output image of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#isOutputImageOf">https://w3id.org/amv#isOutputImageOf</seealso>
    let isOutputImageOf = Prefixed_Name(amv, "isOutputImageOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#isSimilarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"A pointer to another, functionally similar thing (or multiple things), for example, an algorithm is similar to another algorithm or algorithms, a problem is similar to another problem or problems, etc."</para>
    /// labels<para>"is similar to"</para></remarks>
    /// <seealso href="https://w3id.org/amv#isSimilarTo">https://w3id.org/amv#isSimilarTo</seealso>
    let isSimilarTo = Prefixed_Name(amv, "isSimilarTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#libraryURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique identifier of the central place where the algorithm is stored."</para>
    /// labels<para>"library URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#libraryURI">https://w3id.org/amv#libraryURI</seealso>
    let libraryURI = Prefixed_Name(amv, "libraryURI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#loopConstruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The loop best suited for the algorithm."</para>
    /// labels<para>"loop construct"</para></remarks>
    /// <seealso href="https://w3id.org/amv#loopConstruct">https://w3id.org/amv#loopConstruct</seealso>
    let loopConstruct = Prefixed_Name(amv, "loopConstruct") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#loopConstructOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"loop construct of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#loopConstructOf">https://w3id.org/amv#loopConstructOf</seealso>
    let loopConstructOf = Prefixed_Name(amv, "loopConstructOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#mathematicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The mathematical concept used to solve the problem."</para>
    /// labels<para>"mathematical property"</para></remarks>
    /// <seealso href="https://w3id.org/amv#mathematicalProperty">https://w3id.org/amv#mathematicalProperty</seealso>
    let mathematicalProperty =
        Prefixed_Name(amv, "mathematicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#mathematicalPropertyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"mathematicalPropertyUsed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#mathematicalPropertyUsed">https://w3id.org/amv#mathematicalPropertyUsed</seealso>
    let mathematicalPropertyUsed =
        Prefixed_Name(amv, "mathematicalPropertyUsed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#messageComplexityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"message complexity of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#messageComplexityOf">https://w3id.org/amv#messageComplexityOf</seealso>
    let messageComplexityOf = Prefixed_Name(amv, "messageComplexityOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#metricOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"metric of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#metricOf">https://w3id.org/amv#metricOf</seealso>
    let metricOf = Prefixed_Name(amv, "metricOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#n-bodyProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#Problem</para>
    ///   <para>"The n-body problem is the problem of predicting the individual motions of a group of celestial objects interacting with each other gravitationally."</para>
    /// labels<para>"n-body problem"</para></remarks>
    /// <seealso href="https://w3id.org/amv#n-bodyProblem">https://w3id.org/amv#n-bodyProblem</seealso>
    let n_bodyProblem = Prefixed_Name(amv, "n-bodyProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#numberOfNestedLoops</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of nested loops in an algorithm."</para>
    /// labels<para>"number Of Nested Loops"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#numberOfNestedLoops">https://w3id.org/amv#numberOfNestedLoops</seealso>
    let numberOfNestedLoops = Prefixed_Name(amv, "numberOfNestedLoops") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#numberOfSteps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Total number of steps that the algorithm takes to solve a certain problem."</para>
    /// labels<para>"number Of Steps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#numberOfSteps">https://w3id.org/amv#numberOfSteps</seealso>
    let numberOfSteps = Prefixed_Name(amv, "numberOfSteps") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#offlineAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The complete dataset is required to start processing."</para>
    /// labels<para>"offline algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/amv#offlineAlgorithm">https://w3id.org/amv#offlineAlgorithm</seealso>
    let offlineAlgorithm = Prefixed_Name(amv, "offlineAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#onlineAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The data can be feed while processing."</para>
    /// labels<para>"online algorithm"</para></remarks>
    /// <seealso href="https://w3id.org/amv#onlineAlgorithm">https://w3id.org/amv#onlineAlgorithm</seealso>
    let onlineAlgorithm = Prefixed_Name(amv, "onlineAlgorithm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#operatingSystemFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"operatingSystemFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#operatingSystemFor">https://w3id.org/amv#operatingSystemFor</seealso>
    let operatingSystemFor = Prefixed_Name(amv, "operatingSystemFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#optimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An algorithm is optimal means the time complexity in the worst case is a lower bound of the function that describes the time complexity in the worst case of a problem that the algorithm in question solves."</para>
    /// labels<para>"optimal"</para></remarks>
    /// <seealso href="https://w3id.org/amv#optimal">https://w3id.org/amv#optimal</seealso>
    let optimal = Prefixed_Name(amv, "optimal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Output after processing the input."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"output"</para></remarks>
    /// <seealso href="https://w3id.org/amv#output">https://w3id.org/amv#output</seealso>
    let output = Prefixed_Name(amv, "output") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#outputImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"input image"</para></remarks>
    /// <seealso href="https://w3id.org/amv#outputImage">https://w3id.org/amv#outputImage</seealso>
    let outputImage = Prefixed_Name(amv, "outputImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#performanceMetricOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performance metric of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#performanceMetricOf">https://w3id.org/amv#performanceMetricOf</seealso>
    let performanceMetricOf = Prefixed_Name(amv, "performanceMetricOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It is a measure of quality, higher precision means algorithm returns more relevant results than irrelevant ones."</para>
    /// labels<para>"precision"</para></remarks>
    /// <seealso href="https://w3id.org/amv#precision">https://w3id.org/amv#precision</seealso>
    let precision = Prefixed_Name(amv, "precision") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#problemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A description providing the problem statement."</para>
    /// labels<para>"problem description"</para></remarks>
    /// <seealso href="https://w3id.org/amv#problemDescription">https://w3id.org/amv#problemDescription</seealso>
    let problemDescription = Prefixed_Name(amv, "problemDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#programmingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In which all language the implementation of the algorithm/ problem is available."</para>
    /// labels<para>"programming language"</para></remarks>
    /// <seealso href="https://w3id.org/amv#programmingLanguage">https://w3id.org/amv#programmingLanguage</seealso>
    let programmingLanguage = Prefixed_Name(amv, "programmingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_Discipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Academic field of study or profession."</para>
    ///   <para>"A branch of knowledge."</para>
    /// labels<para>"Academic discipline"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_Discipline">https://w3id.org/amv#pub_Discipline</seealso>
    let pub_Discipline = Prefixed_Name(amv, "pub_Discipline") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#pub_InformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An information resource."</para>
    /// labels<para>"Information Resource"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_InformationResource">https://w3id.org/amv#pub_InformationResource</seealso>
    let pub_InformationResource =
        Prefixed_Name(amv, "pub_InformationResource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#pub_Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small reference book, especially one giving instructions."</para>
    /// labels<para>"Manual"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_Manual">https://w3id.org/amv#pub_Manual</seealso>
    let pub_Manual = Prefixed_Name(amv, "pub_Manual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_accessRightsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"access rights of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_accessRightsOf">https://w3id.org/amv#pub_accessRightsOf</seealso>
    let pub_accessRightsOf = Prefixed_Name(amv, "pub_accessRightsOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_appearedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An algorithm appeared in a publication."</para>
    /// labels<para>"appeared In"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_appearedIn">https://w3id.org/amv#pub_appearedIn</seealso>
    let pub_appearedIn = Prefixed_Name(amv, "pub_appearedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_branchOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"branch Of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_branchOf">https://w3id.org/amv#pub_branchOf</seealso>
    let pub_branchOf = Prefixed_Name(amv, "pub_branchOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_contains">https://w3id.org/amv#pub_contains</seealso>
    let pub_contains = Prefixed_Name(amv, "pub_contains") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_contributorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contributor of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_contributorOf">https://w3id.org/amv#pub_contributorOf</seealso>
    let pub_contributorOf = Prefixed_Name(amv, "pub_contributorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_creatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"creator of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_creatorOf">https://w3id.org/amv#pub_creatorOf</seealso>
    let pub_creatorOf = Prefixed_Name(amv, "pub_creatorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_downloadLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"URL which can be used to download a work."</para>
    /// labels<para>"download link"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_downloadLink">https://w3id.org/amv#pub_downloadLink</seealso>
    let pub_downloadLink = Prefixed_Name(amv, "pub_downloadLink") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_hasArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasArticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_hasArticle">https://w3id.org/amv#pub_hasArticle</seealso>
    let pub_hasArticle = Prefixed_Name(amv, "pub_hasArticle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_hasBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Branch of the academic discipline."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has branch"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_hasBranch">https://w3id.org/amv#pub_hasBranch</seealso>
    let pub_hasBranch = Prefixed_Name(amv, "pub_hasBranch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_licenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"license of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_licenseOf">https://w3id.org/amv#pub_licenseOf</seealso>
    let pub_licenseOf = Prefixed_Name(amv, "pub_licenseOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_publishedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"published in"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_publishedIn">https://w3id.org/amv#pub_publishedIn</seealso>
    let pub_publishedIn = Prefixed_Name(amv, "pub_publishedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_publisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publisher of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_publisherOf">https://w3id.org/amv#pub_publisherOf</seealso>
    let pub_publisherOf = Prefixed_Name(amv, "pub_publisherOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Rating given on the basis of usefulness of a thing."</para>
    /// labels<para>"rating"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_rating">https://w3id.org/amv#pub_rating</seealso>
    let pub_rating = Prefixed_Name(amv, "pub_rating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_readme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provide a description or Link to algorithm, or similar resource "Readme page"."</para>
    /// labels<para>"read me"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_readme">https://w3id.org/amv#pub_readme</seealso>
    let pub_readme = Prefixed_Name(amv, "pub_readme") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_rightsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"rights of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_rightsOf">https://w3id.org/amv#pub_rightsOf</seealso>
    let pub_rightsOf = Prefixed_Name(amv, "pub_rightsOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#pub_subjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A topic of the resource for."</para>
    /// labels<para>"subject of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#pub_subjectOf">https://w3id.org/amv#pub_subjectOf</seealso>
    let pub_subjectOf = Prefixed_Name(amv, "pub_subjectOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#readable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Is the algorithm readable/understandable to the user."</para>
    /// labels<para>"readable"</para></remarks>
    /// <seealso href="https://w3id.org/amv#readable">https://w3id.org/amv#readable</seealso>
    let readable = Prefixed_Name(amv, "readable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#recall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"percentage of total relevent result correctly classified by the algorithm."</para>
    /// labels<para>"recall"</para></remarks>
    /// <seealso href="https://w3id.org/amv#recall">https://w3id.org/amv#recall</seealso>
    let recall = Prefixed_Name(amv, "recall") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#runsOnOperatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"runs on Operating System"</para></remarks>
    /// <seealso href="https://w3id.org/amv#runsOnOperatingSystem">https://w3id.org/amv#runsOnOperatingSystem</seealso>
    let runsOnOperatingSystem =
        Prefixed_Name(amv, "runsOnOperatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#spaceComplexityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"space complexity of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#spaceComplexityOf">https://w3id.org/amv#spaceComplexityOf</seealso>
    let spaceComplexityOf = Prefixed_Name(amv, "spaceComplexityOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#subalgorithmOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"subalgorithm of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#subalgorithmOf">https://w3id.org/amv#subalgorithmOf</seealso>
    let subalgorithmOf = Prefixed_Name(amv, "subalgorithmOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#subproblemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"subproblem of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#subproblemOf">https://w3id.org/amv#subproblemOf</seealso>
    let subproblemOf = Prefixed_Name(amv, "subproblemOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#timeComplexityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"time complexity of"</para></remarks>
    /// <seealso href="https://w3id.org/amv#timeComplexityOf">https://w3id.org/amv#timeComplexityOf</seealso>
    let timeComplexityOf = Prefixed_Name(amv, "timeComplexityOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#tree</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:amv#DataStructure</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#tree">https://w3id.org/amv#tree</seealso>
    let tree = Prefixed_Name(amv, "tree") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#tuple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:amv#DataStructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/amv#tuple">https://w3id.org/amv#tuple</seealso>
    let tuple = Prefixed_Name(amv, "tuple") |> PrefixedName
    /// <summary>
    ///   <para>w3id:amv#usedInIm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"programming language used in"</para></remarks>
    /// <seealso href="https://w3id.org/amv#usedInIm">https://w3id.org/amv#usedInIm</seealso>
    let usedInIm = Prefixed_Name(amv, "usedInIm") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#worstCaseMessageComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"worst case message complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#worstCaseMessageComplexity">https://w3id.org/amv#worstCaseMessageComplexity</seealso>
    let worstCaseMessageComplexity =
        Prefixed_Name(amv, "worstCaseMessageComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#worstCaseSpaceComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Space complexity of an algorithm at most.(https://www.wikidata.org/wiki/Property:P3755)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"worst case space complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#worstCaseSpaceComplexity">https://w3id.org/amv#worstCaseSpaceComplexity</seealso>
    let worstCaseSpaceComplexity =
        Prefixed_Name(amv, "worstCaseSpaceComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:amv#worstCaseTimeComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time complexity of an algorithm at most. (https://www.wikidata.org/wiki/Property:P3752)"</para>
    /// labels<para>"worst case time complexity"</para></remarks>
    /// <seealso href="https://w3id.org/amv#worstCaseTimeComplexity">https://w3id.org/amv#worstCaseTimeComplexity</seealso>
    let worstCaseTimeComplexity =
        Prefixed_Name(amv, "worstCaseTimeComplexity") |> PrefixedName
