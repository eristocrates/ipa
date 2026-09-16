#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module acm =
    let _prefixId = PrefixId.fromNamespaceLabel "http://acm.rkbexplorer.com/ontologies/acm#" "acm"

    /// <summary>
    ///   <para>rdfs:label : A. General Literature^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A">acm:A</a>
    /// </summary>
    let A = _prefixId.prefix "A"
    /// <summary>
    ///   <para>rdfs:label : A.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.0">acm:A.0</a>
    /// </summary>
    let A'_period_'0 = _prefixId.prefix "A.0"
    /// <summary>
    ///   <para>rdfs:label : A.0.0. Biographies/autobiographies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.0.0">acm:A.0.0</a>
    /// </summary>
    let A'_period_'0'_period_'0 = _prefixId.prefix "A.0.0"
    /// <summary>
    ///   <para>rdfs:label : A.0.1. Conference proceedings^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.0.1">acm:A.0.1</a>
    /// </summary>
    let A'_period_'0'_period_'1 = _prefixId.prefix "A.0.1"
    /// <summary>
    ///   <para>rdfs:label : A.0.2. General literary works^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.0.2">acm:A.0.2</a>
    /// </summary>
    let A'_period_'0'_period_'2 = _prefixId.prefix "A.0.2"
    /// <summary>
    ///   <para>rdfs:label : A.1. INTRODUCTORY AND SURVEY^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.1">acm:A.1</a>
    /// </summary>
    let A'_period_'1 = _prefixId.prefix "A.1"
    /// <summary>
    ///   <para>rdfs:label : A.2. REFERENCE^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.2">acm:A.2</a>
    /// </summary>
    let A'_period_'2 = _prefixId.prefix "A.2"
    /// <summary>
    ///   <para>rdfs:label : A.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#A.m">acm:A.m</a>
    /// </summary>
    let A'_period_'m = _prefixId.prefix "A.m"
    /// <summary>
    ///   <para>rdfs:label : B. Hardware^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B">acm:B</a>
    /// </summary>
    let B = _prefixId.prefix "B"
    /// <summary>
    ///   <para>rdfs:label : B.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.0">acm:B.0</a>
    /// </summary>
    let B'_period_'0 = _prefixId.prefix "B.0"
    /// <summary>
    ///   <para>rdfs:label : B.1. CONTROL STRUCTURES AND MICROPROGRAMMING^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1">acm:B.1</a>
    /// </summary>
    let B'_period_'1 = _prefixId.prefix "B.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.0">acm:B.1.0</a>
    /// </summary>
    let B'_period_'1'_period_'0 = _prefixId.prefix "B.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.1.1. Control Design Styles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1">acm:B.1.1</a>
    /// </summary>
    let B'_period_'1'_period_'1 = _prefixId.prefix "B.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.1.0. Hardwired control^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.0">acm:B.1.1.0</a>
    /// </summary>
    let B'_period_'1'_period_'1'_period_'0 = _prefixId.prefix "B.1.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.1.1.1. Microprogrammed logic arrays^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.1">acm:B.1.1.1</a>
    /// </summary>
    let B'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "B.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.1.2. Writable control store^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.1.2">acm:B.1.1.2</a>
    /// </summary>
    let B'_period_'1'_period_'1'_period_'2 = _prefixId.prefix "B.1.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.1.2. Control Structure Performance Analysis and Design Aids^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2">acm:B.1.2</a>
    /// </summary>
    let B'_period_'1'_period_'2 = _prefixId.prefix "B.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.1.2.0. Automatic synthesis^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.0">acm:B.1.2.0</a>
    /// </summary>
    let B'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "B.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.1.2.1. Formal models^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.1">acm:B.1.2.1</a>
    /// </summary>
    let B'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "B.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.2.2. Simulation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.2.2">acm:B.1.2.2</a>
    /// </summary>
    let B'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "B.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.1.3. Control Structure Reliability, Testing, and Fault-Tolerance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3">acm:B.1.3</a>
    /// </summary>
    let B'_period_'1'_period_'3 = _prefixId.prefix "B.1.3"
    /// <summary>
    ///   <para>rdfs:label : B.1.3.0. Diagnostics^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.0">acm:B.1.3.0</a>
    /// </summary>
    let B'_period_'1'_period_'3'_period_'0 = _prefixId.prefix "B.1.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.1.3.1. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.1">acm:B.1.3.1</a>
    /// </summary>
    let B'_period_'1'_period_'3'_period_'1 = _prefixId.prefix "B.1.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.3.2. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.2">acm:B.1.3.2</a>
    /// </summary>
    let B'_period_'1'_period_'3'_period_'2 = _prefixId.prefix "B.1.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.1.3.3. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.3.3">acm:B.1.3.3</a>
    /// </summary>
    let B'_period_'1'_period_'3'_period_'3 = _prefixId.prefix "B.1.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.1.4. Microprogram Design Aids^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.2.2, #D.2.4, #D.3.2, #D.3.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4">acm:B.1.4</a>
    /// </summary>
    let B'_period_'1'_period_'4 = _prefixId.prefix "B.1.4"
    /// <summary>
    ///   <para>rdfs:label : B.1.4.0. Firmware engineering^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.0">acm:B.1.4.0</a>
    /// </summary>
    let B'_period_'1'_period_'4'_period_'0 = _prefixId.prefix "B.1.4.0"
    /// <summary>
    ///   <para>rdfs:label : B.1.4.1. Languages and compilers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.1">acm:B.1.4.1</a>
    /// </summary>
    let B'_period_'1'_period_'4'_period_'1 = _prefixId.prefix "B.1.4.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.4.2. Machine-independent microcode generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.2">acm:B.1.4.2</a>
    /// </summary>
    let B'_period_'1'_period_'4'_period_'2 = _prefixId.prefix "B.1.4.2"
    /// <summary>
    ///   <para>rdfs:label : B.1.4.3. Optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.3">acm:B.1.4.3</a>
    /// </summary>
    let B'_period_'1'_period_'4'_period_'3 = _prefixId.prefix "B.1.4.3"
    /// <summary>
    ///   <para>rdfs:label : B.1.4.4. Verification^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.4.4">acm:B.1.4.4</a>
    /// </summary>
    let B'_period_'1'_period_'4'_period_'4 = _prefixId.prefix "B.1.4.4"
    /// <summary>
    ///   <para>rdfs:label : B.1.5. Microcode Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5">acm:B.1.5</a>
    /// </summary>
    let B'_period_'1'_period_'5 = _prefixId.prefix "B.1.5"
    /// <summary>
    ///   <para>rdfs:label : B.1.5.0. Direct data manipulation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.0">acm:B.1.5.0</a>
    /// </summary>
    let B'_period_'1'_period_'5'_period_'0 = _prefixId.prefix "B.1.5.0"
    /// <summary>
    ///   <para>rdfs:label : B.1.5.1. Firmware support of operating systems/instruction sets^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.1">acm:B.1.5.1</a>
    /// </summary>
    let B'_period_'1'_period_'5'_period_'1 = _prefixId.prefix "B.1.5.1"
    /// <summary>
    ///   <para>rdfs:label : B.1.5.2. Instruction set interpretation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.2">acm:B.1.5.2</a>
    /// </summary>
    let B'_period_'1'_period_'5'_period_'2 = _prefixId.prefix "B.1.5.2"
    /// <summary>
    ///   <para>rdfs:label : B.1.5.3. Peripheral control^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.3">acm:B.1.5.3</a>
    /// </summary>
    let B'_period_'1'_period_'5'_period_'3 = _prefixId.prefix "B.1.5.3"
    /// <summary>
    ///   <para>rdfs:label : B.1.5.4. Special-purpose^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.5.4">acm:B.1.5.4</a>
    /// </summary>
    let B'_period_'1'_period_'5'_period_'4 = _prefixId.prefix "B.1.5.4"
    /// <summary>
    ///   <para>rdfs:label : B.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.1.m">acm:B.1.m</a>
    /// </summary>
    let B'_period_'1'_period_'m = _prefixId.prefix "B.1.m"
    /// <summary>
    ///   <para>rdfs:label : B.2. ARITHMETIC AND LOGIC STRUCTURES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2">acm:B.2</a>
    /// </summary>
    let B'_period_'2 = _prefixId.prefix "B.2"
    /// <summary>
    ///   <para>rdfs:label : B.2.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.0">acm:B.2.0</a>
    /// </summary>
    let B'_period_'2'_period_'0 = _prefixId.prefix "B.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.2.1. Design Styles^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.1.1, #C.1.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1">acm:B.2.1</a>
    /// </summary>
    let B'_period_'2'_period_'1 = _prefixId.prefix "B.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.2.1.0. Calculator^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.0">acm:B.2.1.0</a>
    /// </summary>
    let B'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "B.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.2.1.1. Parallel^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.1">acm:B.2.1.1</a>
    /// </summary>
    let B'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "B.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.2.1.2. Pipeline^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.1.2">acm:B.2.1.2</a>
    /// </summary>
    let B'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "B.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.2.2. Performance Analysis and Design Aids^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2">acm:B.2.2</a>
    /// </summary>
    let B'_period_'2'_period_'2 = _prefixId.prefix "B.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.2.2.0. Simulation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.0">acm:B.2.2.0</a>
    /// </summary>
    let B'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "B.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.2.2.1. Verification^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.1">acm:B.2.2.1</a>
    /// </summary>
    let B'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "B.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.2.2.2. Worst-case analysis^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.2.2">acm:B.2.2.2</a>
    /// </summary>
    let B'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "B.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.2.3. Reliability, Testing, and Fault-Tolerance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3">acm:B.2.3</a>
    /// </summary>
    let B'_period_'2'_period_'3 = _prefixId.prefix "B.2.3"
    /// <summary>
    ///   <para>rdfs:label : B.2.3.0. Diagnostics^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.0">acm:B.2.3.0</a>
    /// </summary>
    let B'_period_'2'_period_'3'_period_'0 = _prefixId.prefix "B.2.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.2.3.1. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.1">acm:B.2.3.1</a>
    /// </summary>
    let B'_period_'2'_period_'3'_period_'1 = _prefixId.prefix "B.2.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.2.3.2. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.2">acm:B.2.3.2</a>
    /// </summary>
    let B'_period_'2'_period_'3'_period_'2 = _prefixId.prefix "B.2.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.2.3.3. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.3.3">acm:B.2.3.3</a>
    /// </summary>
    let B'_period_'2'_period_'3'_period_'3 = _prefixId.prefix "B.2.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.2.4. High-Speed Arithmetic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4">acm:B.2.4</a>
    /// </summary>
    let B'_period_'2'_period_'4 = _prefixId.prefix "B.2.4"
    /// <summary>
    ///   <para>rdfs:label : B.2.4.0. Algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.0">acm:B.2.4.0</a>
    /// </summary>
    let B'_period_'2'_period_'4'_period_'0 = _prefixId.prefix "B.2.4.0"
    /// <summary>
    ///   <para>rdfs:label : B.2.4.1. Cost/performance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.4.1">acm:B.2.4.1</a>
    /// </summary>
    let B'_period_'2'_period_'4'_period_'1 = _prefixId.prefix "B.2.4.1"
    /// <summary>
    ///   <para>rdfs:label : B.2.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.2.m">acm:B.2.m</a>
    /// </summary>
    let B'_period_'2'_period_'m = _prefixId.prefix "B.2.m"
    /// <summary>
    ///   <para>rdfs:label : B.3. MEMORY STRUCTURES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3">acm:B.3</a>
    /// </summary>
    let B'_period_'3 = _prefixId.prefix "B.3"
    /// <summary>
    ///   <para>rdfs:label : B.3.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.0">acm:B.3.0</a>
    /// </summary>
    let B'_period_'3'_period_'0 = _prefixId.prefix "B.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.3.1. Semiconductor Memories^^xsd:string</para>
    ///   <para>rdfs:comment : See also #B.7.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1">acm:B.3.1</a>
    /// </summary>
    let B'_period_'3'_period_'1 = _prefixId.prefix "B.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.3.1.0. Dynamic memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.0">acm:B.3.1.0</a>
    /// </summary>
    let B'_period_'3'_period_'1'_period_'0 = _prefixId.prefix "B.3.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.3.1.1. Read-only memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.1">acm:B.3.1.1</a>
    /// </summary>
    let B'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "B.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.3.1.2. Static memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.1.2">acm:B.3.1.2</a>
    /// </summary>
    let B'_period_'3'_period_'1'_period_'2 = _prefixId.prefix "B.3.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.3.2. Design Styles^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.4.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2">acm:B.3.2</a>
    /// </summary>
    let B'_period_'3'_period_'2 = _prefixId.prefix "B.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.0. Associative memories^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.0">acm:B.3.2.0</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'0 = _prefixId.prefix "B.3.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.1. Cache memories^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.1">acm:B.3.2.1</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "B.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.2. Interleaved memories^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.2">acm:B.3.2.2</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'2 = _prefixId.prefix "B.3.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.3. Mass storage^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.3">acm:B.3.2.3</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'3 = _prefixId.prefix "B.3.2.3"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.4. Primary memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.4">acm:B.3.2.4</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'4 = _prefixId.prefix "B.3.2.4"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.5. Sequential-access memory^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.5">acm:B.3.2.5</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'5 = _prefixId.prefix "B.3.2.5"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.6. Shared memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.6">acm:B.3.2.6</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'6 = _prefixId.prefix "B.3.2.6"
    /// <summary>
    ///   <para>rdfs:label : B.3.2.7. Virtual memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.2.7">acm:B.3.2.7</a>
    /// </summary>
    let B'_period_'3'_period_'2'_period_'7 = _prefixId.prefix "B.3.2.7"
    /// <summary>
    ///   <para>rdfs:label : B.3.3. Performance Analysis and Design Aids^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8, #C.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3">acm:B.3.3</a>
    /// </summary>
    let B'_period_'3'_period_'3 = _prefixId.prefix "B.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.3.3.0. Formal models^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.0">acm:B.3.3.0</a>
    /// </summary>
    let B'_period_'3'_period_'3'_period_'0 = _prefixId.prefix "B.3.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.3.3.1. Simulation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.1">acm:B.3.3.1</a>
    /// </summary>
    let B'_period_'3'_period_'3'_period_'1 = _prefixId.prefix "B.3.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.3.3.2. Worst-case analysis^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.3.2">acm:B.3.3.2</a>
    /// </summary>
    let B'_period_'3'_period_'3'_period_'2 = _prefixId.prefix "B.3.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.3.4. Reliability, Testing, and Fault-Tolerance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4">acm:B.3.4</a>
    /// </summary>
    let B'_period_'3'_period_'4 = _prefixId.prefix "B.3.4"
    /// <summary>
    ///   <para>rdfs:label : B.3.4.0. Diagnostics^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.0">acm:B.3.4.0</a>
    /// </summary>
    let B'_period_'3'_period_'4'_period_'0 = _prefixId.prefix "B.3.4.0"
    /// <summary>
    ///   <para>rdfs:label : B.3.4.1. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.1">acm:B.3.4.1</a>
    /// </summary>
    let B'_period_'3'_period_'4'_period_'1 = _prefixId.prefix "B.3.4.1"
    /// <summary>
    ///   <para>rdfs:label : B.3.4.2. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.2">acm:B.3.4.2</a>
    /// </summary>
    let B'_period_'3'_period_'4'_period_'2 = _prefixId.prefix "B.3.4.2"
    /// <summary>
    ///   <para>rdfs:label : B.3.4.3. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.4.3">acm:B.3.4.3</a>
    /// </summary>
    let B'_period_'3'_period_'4'_period_'3 = _prefixId.prefix "B.3.4.3"
    /// <summary>
    ///   <para>rdfs:label : B.3.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.3.m">acm:B.3.m</a>
    /// </summary>
    let B'_period_'3'_period_'m = _prefixId.prefix "B.3.m"
    /// <summary>
    ///   <para>rdfs:label : B.4. INPUT/OUTPUT AND DATA COMMUNICATIONS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4">acm:B.4</a>
    /// </summary>
    let B'_period_'4 = _prefixId.prefix "B.4"
    /// <summary>
    ///   <para>rdfs:label : B.4.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.0">acm:B.4.0</a>
    /// </summary>
    let B'_period_'4'_period_'0 = _prefixId.prefix "B.4.0"
    /// <summary>
    ///   <para>rdfs:label : B.4.1. Data Communications Devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1">acm:B.4.1</a>
    /// </summary>
    let B'_period_'4'_period_'1 = _prefixId.prefix "B.4.1"
    /// <summary>
    ///   <para>rdfs:label : B.4.1.0. Processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.0">acm:B.4.1.0</a>
    /// </summary>
    let B'_period_'4'_period_'1'_period_'0 = _prefixId.prefix "B.4.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.4.1.1. Receivers^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.1">acm:B.4.1.1</a>
    /// </summary>
    let B'_period_'4'_period_'1'_period_'1 = _prefixId.prefix "B.4.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.4.1.2. Transmitters^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.1.2">acm:B.4.1.2</a>
    /// </summary>
    let B'_period_'4'_period_'1'_period_'2 = _prefixId.prefix "B.4.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.4.2. Input/Output Devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2">acm:B.4.2</a>
    /// </summary>
    let B'_period_'4'_period_'2 = _prefixId.prefix "B.4.2"
    /// <summary>
    ///   <para>rdfs:label : B.4.2.0. Channels and controllers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.0">acm:B.4.2.0</a>
    /// </summary>
    let B'_period_'4'_period_'2'_period_'0 = _prefixId.prefix "B.4.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.4.2.1. Data terminals and printers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.1">acm:B.4.2.1</a>
    /// </summary>
    let B'_period_'4'_period_'2'_period_'1 = _prefixId.prefix "B.4.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.4.2.2. Image display^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.2">acm:B.4.2.2</a>
    /// </summary>
    let B'_period_'4'_period_'2'_period_'2 = _prefixId.prefix "B.4.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.4.2.3. Voice^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.2.3">acm:B.4.2.3</a>
    /// </summary>
    let B'_period_'4'_period_'2'_period_'3 = _prefixId.prefix "B.4.2.3"
    /// <summary>
    ///   <para>rdfs:label : B.4.3. Interconnections^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3">acm:B.4.3</a>
    /// </summary>
    let B'_period_'4'_period_'3 = _prefixId.prefix "B.4.3"
    /// <summary>
    ///   <para>rdfs:label : B.4.3.0. Asynchronous/synchronous operation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.0">acm:B.4.3.0</a>
    /// </summary>
    let B'_period_'4'_period_'3'_period_'0 = _prefixId.prefix "B.4.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.4.3.1. Fiber optics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.1">acm:B.4.3.1</a>
    /// </summary>
    let B'_period_'4'_period_'3'_period_'1 = _prefixId.prefix "B.4.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.4.3.2. Interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.2">acm:B.4.3.2</a>
    /// </summary>
    let B'_period_'4'_period_'3'_period_'2 = _prefixId.prefix "B.4.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.4.3.3. Parallel I/O^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.3">acm:B.4.3.3</a>
    /// </summary>
    let B'_period_'4'_period_'3'_period_'3 = _prefixId.prefix "B.4.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.4.3.4. Physical structures^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.4">acm:B.4.3.4</a>
    /// </summary>
    let B'_period_'4'_period_'3'_period_'4 = _prefixId.prefix "B.4.3.4"
    /// <summary>
    ///   <para>rdfs:label : B.4.3.5. Topology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.3.5">acm:B.4.3.5</a>
    /// </summary>
    let B'_period_'4'_period_'3'_period_'5 = _prefixId.prefix "B.4.3.5"
    /// <summary>
    ///   <para>rdfs:label : B.4.4. Performance Analysis and Design Aids^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4">acm:B.4.4</a>
    /// </summary>
    let B'_period_'4'_period_'4 = _prefixId.prefix "B.4.4"
    /// <summary>
    ///   <para>rdfs:label : B.4.4.0. Formal models^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.0">acm:B.4.4.0</a>
    /// </summary>
    let B'_period_'4'_period_'4'_period_'0 = _prefixId.prefix "B.4.4.0"
    /// <summary>
    ///   <para>rdfs:label : B.4.4.1. Simulation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.1">acm:B.4.4.1</a>
    /// </summary>
    let B'_period_'4'_period_'4'_period_'1 = _prefixId.prefix "B.4.4.1"
    /// <summary>
    ///   <para>rdfs:label : B.4.4.2. Verification^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.2">acm:B.4.4.2</a>
    /// </summary>
    let B'_period_'4'_period_'4'_period_'2 = _prefixId.prefix "B.4.4.2"
    /// <summary>
    ///   <para>rdfs:label : B.4.4.3. Worst-case analysis^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.4.3">acm:B.4.4.3</a>
    /// </summary>
    let B'_period_'4'_period_'4'_period_'3 = _prefixId.prefix "B.4.4.3"
    /// <summary>
    ///   <para>rdfs:label : B.4.5. Reliability, Testing, and Fault-Tolerance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5">acm:B.4.5</a>
    /// </summary>
    let B'_period_'4'_period_'5 = _prefixId.prefix "B.4.5"
    /// <summary>
    ///   <para>rdfs:label : B.4.5.0. Built-in tests^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.0">acm:B.4.5.0</a>
    /// </summary>
    let B'_period_'4'_period_'5'_period_'0 = _prefixId.prefix "B.4.5.0"
    /// <summary>
    ///   <para>rdfs:label : B.4.5.1. Diagnostics^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.1">acm:B.4.5.1</a>
    /// </summary>
    let B'_period_'4'_period_'5'_period_'1 = _prefixId.prefix "B.4.5.1"
    /// <summary>
    ///   <para>rdfs:label : B.4.5.2. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.2">acm:B.4.5.2</a>
    /// </summary>
    let B'_period_'4'_period_'5'_period_'2 = _prefixId.prefix "B.4.5.2"
    /// <summary>
    ///   <para>rdfs:label : B.4.5.3. Hardware reliability^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.3">acm:B.4.5.3</a>
    /// </summary>
    let B'_period_'4'_period_'5'_period_'3 = _prefixId.prefix "B.4.5.3"
    /// <summary>
    ///   <para>rdfs:label : B.4.5.4. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.4">acm:B.4.5.4</a>
    /// </summary>
    let B'_period_'4'_period_'5'_period_'4 = _prefixId.prefix "B.4.5.4"
    /// <summary>
    ///   <para>rdfs:label : B.4.5.5. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.5.5">acm:B.4.5.5</a>
    /// </summary>
    let B'_period_'4'_period_'5'_period_'5 = _prefixId.prefix "B.4.5.5"
    /// <summary>
    ///   <para>rdfs:label : B.4.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.4.m">acm:B.4.m</a>
    /// </summary>
    let B'_period_'4'_period_'m = _prefixId.prefix "B.4.m"
    /// <summary>
    ///   <para>rdfs:label : B.5. REGISTER-TRANSFER-LEVEL IMPLEMENTATION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5">acm:B.5</a>
    /// </summary>
    let B'_period_'5 = _prefixId.prefix "B.5"
    /// <summary>
    ///   <para>rdfs:label : B.5.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.0">acm:B.5.0</a>
    /// </summary>
    let B'_period_'5'_period_'0 = _prefixId.prefix "B.5.0"
    /// <summary>
    ///   <para>rdfs:label : B.5.1. Design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1">acm:B.5.1</a>
    /// </summary>
    let B'_period_'5'_period_'1 = _prefixId.prefix "B.5.1"
    /// <summary>
    ///   <para>rdfs:label : B.5.1.0. Arithmetic and logic units^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.0">acm:B.5.1.0</a>
    /// </summary>
    let B'_period_'5'_period_'1'_period_'0 = _prefixId.prefix "B.5.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.5.1.1. Control design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.1">acm:B.5.1.1</a>
    /// </summary>
    let B'_period_'5'_period_'1'_period_'1 = _prefixId.prefix "B.5.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.5.1.2. Data-path design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.2">acm:B.5.1.2</a>
    /// </summary>
    let B'_period_'5'_period_'1'_period_'2 = _prefixId.prefix "B.5.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.5.1.3. Memory design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.3">acm:B.5.1.3</a>
    /// </summary>
    let B'_period_'5'_period_'1'_period_'3 = _prefixId.prefix "B.5.1.3"
    /// <summary>
    ///   <para>rdfs:label : B.5.1.4. Styles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.1.4">acm:B.5.1.4</a>
    /// </summary>
    let B'_period_'5'_period_'1'_period_'4 = _prefixId.prefix "B.5.1.4"
    /// <summary>
    ///   <para>rdfs:label : B.5.2. Design Aids^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2">acm:B.5.2</a>
    /// </summary>
    let B'_period_'5'_period_'2 = _prefixId.prefix "B.5.2"
    /// <summary>
    ///   <para>rdfs:label : B.5.2.0. Automatic synthesis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.0">acm:B.5.2.0</a>
    /// </summary>
    let B'_period_'5'_period_'2'_period_'0 = _prefixId.prefix "B.5.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.5.2.1. Hardware description languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.1">acm:B.5.2.1</a>
    /// </summary>
    let B'_period_'5'_period_'2'_period_'1 = _prefixId.prefix "B.5.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.5.2.2. Optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.2">acm:B.5.2.2</a>
    /// </summary>
    let B'_period_'5'_period_'2'_period_'2 = _prefixId.prefix "B.5.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.5.2.3. Simulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.3">acm:B.5.2.3</a>
    /// </summary>
    let B'_period_'5'_period_'2'_period_'3 = _prefixId.prefix "B.5.2.3"
    /// <summary>
    ///   <para>rdfs:label : B.5.2.4. Verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.2.4">acm:B.5.2.4</a>
    /// </summary>
    let B'_period_'5'_period_'2'_period_'4 = _prefixId.prefix "B.5.2.4"
    /// <summary>
    ///   <para>rdfs:label : B.5.3. Reliability and Testing^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3">acm:B.5.3</a>
    /// </summary>
    let B'_period_'5'_period_'3 = _prefixId.prefix "B.5.3"
    /// <summary>
    ///   <para>rdfs:label : B.5.3.0. Built-in tests^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.0">acm:B.5.3.0</a>
    /// </summary>
    let B'_period_'5'_period_'3'_period_'0 = _prefixId.prefix "B.5.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.5.3.1. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.1">acm:B.5.3.1</a>
    /// </summary>
    let B'_period_'5'_period_'3'_period_'1 = _prefixId.prefix "B.5.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.5.3.2. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.2">acm:B.5.3.2</a>
    /// </summary>
    let B'_period_'5'_period_'3'_period_'2 = _prefixId.prefix "B.5.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.5.3.3. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.3">acm:B.5.3.3</a>
    /// </summary>
    let B'_period_'5'_period_'3'_period_'3 = _prefixId.prefix "B.5.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.5.3.4. Testability^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.3.4">acm:B.5.3.4</a>
    /// </summary>
    let B'_period_'5'_period_'3'_period_'4 = _prefixId.prefix "B.5.3.4"
    /// <summary>
    ///   <para>rdfs:label : B.5.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.5.m">acm:B.5.m</a>
    /// </summary>
    let B'_period_'5'_period_'m = _prefixId.prefix "B.5.m"
    /// <summary>
    ///   <para>rdfs:label : B.6. LOGIC DESIGN^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6">acm:B.6</a>
    /// </summary>
    let B'_period_'6 = _prefixId.prefix "B.6"
    /// <summary>
    ///   <para>rdfs:label : B.6.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.0">acm:B.6.0</a>
    /// </summary>
    let B'_period_'6'_period_'0 = _prefixId.prefix "B.6.0"
    /// <summary>
    ///   <para>rdfs:label : B.6.1. Design Styles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1">acm:B.6.1</a>
    /// </summary>
    let B'_period_'6'_period_'1 = _prefixId.prefix "B.6.1"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.0. Cellular arrays and automata^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.0">acm:B.6.1.0</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'0 = _prefixId.prefix "B.6.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.1. Combinational logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.1">acm:B.6.1.1</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'1 = _prefixId.prefix "B.6.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.2. Logic arrays^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.2">acm:B.6.1.2</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'2 = _prefixId.prefix "B.6.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.3. Memory control and access^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.3">acm:B.6.1.3</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'3 = _prefixId.prefix "B.6.1.3"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.4. Memory used as logic^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.4">acm:B.6.1.4</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'4 = _prefixId.prefix "B.6.1.4"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.5. Parallel circuits^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.5">acm:B.6.1.5</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'5 = _prefixId.prefix "B.6.1.5"
    /// <summary>
    ///   <para>rdfs:label : B.6.1.6. Sequential circuits^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.1.6">acm:B.6.1.6</a>
    /// </summary>
    let B'_period_'6'_period_'1'_period_'6 = _prefixId.prefix "B.6.1.6"
    /// <summary>
    ///   <para>rdfs:label : B.6.2. Reliability and Testing^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2">acm:B.6.2</a>
    /// </summary>
    let B'_period_'6'_period_'2 = _prefixId.prefix "B.6.2"
    /// <summary>
    ///   <para>rdfs:label : B.6.2.0. Built-in tests^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.0">acm:B.6.2.0</a>
    /// </summary>
    let B'_period_'6'_period_'2'_period_'0 = _prefixId.prefix "B.6.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.6.2.1. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.1">acm:B.6.2.1</a>
    /// </summary>
    let B'_period_'6'_period_'2'_period_'1 = _prefixId.prefix "B.6.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.6.2.2. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.2">acm:B.6.2.2</a>
    /// </summary>
    let B'_period_'6'_period_'2'_period_'2 = _prefixId.prefix "B.6.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.6.2.3. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.3">acm:B.6.2.3</a>
    /// </summary>
    let B'_period_'6'_period_'2'_period_'3 = _prefixId.prefix "B.6.2.3"
    /// <summary>
    ///   <para>rdfs:label : B.6.2.4. Testability^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.2.4">acm:B.6.2.4</a>
    /// </summary>
    let B'_period_'6'_period_'2'_period_'4 = _prefixId.prefix "B.6.2.4"
    /// <summary>
    ///   <para>rdfs:label : B.6.3. Design Aids^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3">acm:B.6.3</a>
    /// </summary>
    let B'_period_'6'_period_'3 = _prefixId.prefix "B.6.3"
    /// <summary>
    ///   <para>rdfs:label : B.6.3.0. Automatic synthesis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.0">acm:B.6.3.0</a>
    /// </summary>
    let B'_period_'6'_period_'3'_period_'0 = _prefixId.prefix "B.6.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.6.3.1. Hardware description languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.1">acm:B.6.3.1</a>
    /// </summary>
    let B'_period_'6'_period_'3'_period_'1 = _prefixId.prefix "B.6.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.6.3.2. Optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.2">acm:B.6.3.2</a>
    /// </summary>
    let B'_period_'6'_period_'3'_period_'2 = _prefixId.prefix "B.6.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.6.3.3. Simulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.3">acm:B.6.3.3</a>
    /// </summary>
    let B'_period_'6'_period_'3'_period_'3 = _prefixId.prefix "B.6.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.6.3.4. Switching theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.4">acm:B.6.3.4</a>
    /// </summary>
    let B'_period_'6'_period_'3'_period_'4 = _prefixId.prefix "B.6.3.4"
    /// <summary>
    ///   <para>rdfs:label : B.6.3.5. Verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.3.5">acm:B.6.3.5</a>
    /// </summary>
    let B'_period_'6'_period_'3'_period_'5 = _prefixId.prefix "B.6.3.5"
    /// <summary>
    ///   <para>rdfs:label : B.6.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.6.m">acm:B.6.m</a>
    /// </summary>
    let B'_period_'6'_period_'m = _prefixId.prefix "B.6.m"
    /// <summary>
    ///   <para>rdfs:label : B.7. INTEGRATED CIRCUITS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7">acm:B.7</a>
    /// </summary>
    let B'_period_'7 = _prefixId.prefix "B.7"
    /// <summary>
    ///   <para>rdfs:label : B.7.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.0">acm:B.7.0</a>
    /// </summary>
    let B'_period_'7'_period_'0 = _prefixId.prefix "B.7.0"
    /// <summary>
    ///   <para>rdfs:label : B.7.1. Types and Design Styles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1">acm:B.7.1</a>
    /// </summary>
    let B'_period_'7'_period_'1 = _prefixId.prefix "B.7.1"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.0. Advanced technologies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.0">acm:B.7.1.0</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'0 = _prefixId.prefix "B.7.1.0"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.1. Algorithms implemented in hardware^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.1">acm:B.7.1.1</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'1 = _prefixId.prefix "B.7.1.1"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.2. Gate arrays^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.2">acm:B.7.1.2</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'2 = _prefixId.prefix "B.7.1.2"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.3. Input/output circuits^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.3">acm:B.7.1.3</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'3 = _prefixId.prefix "B.7.1.3"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.4. Memory technologies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.4">acm:B.7.1.4</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'4 = _prefixId.prefix "B.7.1.4"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.5. Microprocessors and microcomputers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.5">acm:B.7.1.5</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'5 = _prefixId.prefix "B.7.1.5"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.6. Standard cells^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.6">acm:B.7.1.6</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'6 = _prefixId.prefix "B.7.1.6"
    /// <summary>
    ///   <para>rdfs:label : B.7.1.7. VLSI^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.1.7">acm:B.7.1.7</a>
    /// </summary>
    let B'_period_'7'_period_'1'_period_'7 = _prefixId.prefix "B.7.1.7"
    /// <summary>
    ///   <para>rdfs:label : B.7.2. Design Aids^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2">acm:B.7.2</a>
    /// </summary>
    let B'_period_'7'_period_'2 = _prefixId.prefix "B.7.2"
    /// <summary>
    ///   <para>rdfs:label : B.7.2.0. Graphics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.0">acm:B.7.2.0</a>
    /// </summary>
    let B'_period_'7'_period_'2'_period_'0 = _prefixId.prefix "B.7.2.0"
    /// <summary>
    ///   <para>rdfs:label : B.7.2.1. Layout^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.1">acm:B.7.2.1</a>
    /// </summary>
    let B'_period_'7'_period_'2'_period_'1 = _prefixId.prefix "B.7.2.1"
    /// <summary>
    ///   <para>rdfs:label : B.7.2.2. Placement and routing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.2">acm:B.7.2.2</a>
    /// </summary>
    let B'_period_'7'_period_'2'_period_'2 = _prefixId.prefix "B.7.2.2"
    /// <summary>
    ///   <para>rdfs:label : B.7.2.3. Simulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.3">acm:B.7.2.3</a>
    /// </summary>
    let B'_period_'7'_period_'2'_period_'3 = _prefixId.prefix "B.7.2.3"
    /// <summary>
    ///   <para>rdfs:label : B.7.2.4. Verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.2.4">acm:B.7.2.4</a>
    /// </summary>
    let B'_period_'7'_period_'2'_period_'4 = _prefixId.prefix "B.7.2.4"
    /// <summary>
    ///   <para>rdfs:label : B.7.3. Reliability and Testing^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #B.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3">acm:B.7.3</a>
    /// </summary>
    let B'_period_'7'_period_'3 = _prefixId.prefix "B.7.3"
    /// <summary>
    ///   <para>rdfs:label : B.7.3.0. Built-in tests^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.0">acm:B.7.3.0</a>
    /// </summary>
    let B'_period_'7'_period_'3'_period_'0 = _prefixId.prefix "B.7.3.0"
    /// <summary>
    ///   <para>rdfs:label : B.7.3.1. Error-checking^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.1">acm:B.7.3.1</a>
    /// </summary>
    let B'_period_'7'_period_'3'_period_'1 = _prefixId.prefix "B.7.3.1"
    /// <summary>
    ///   <para>rdfs:label : B.7.3.2. Redundant design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.2">acm:B.7.3.2</a>
    /// </summary>
    let B'_period_'7'_period_'3'_period_'2 = _prefixId.prefix "B.7.3.2"
    /// <summary>
    ///   <para>rdfs:label : B.7.3.3. Test generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.3">acm:B.7.3.3</a>
    /// </summary>
    let B'_period_'7'_period_'3'_period_'3 = _prefixId.prefix "B.7.3.3"
    /// <summary>
    ///   <para>rdfs:label : B.7.3.4. Testability^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.3.4">acm:B.7.3.4</a>
    /// </summary>
    let B'_period_'7'_period_'3'_period_'4 = _prefixId.prefix "B.7.3.4"
    /// <summary>
    ///   <para>rdfs:label : B.7.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.7.m">acm:B.7.m</a>
    /// </summary>
    let B'_period_'7'_period_'m = _prefixId.prefix "B.7.m"
    /// <summary>
    ///   <para>rdfs:label : B.8. PERFORMANCE AND RELIABILITY^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.8">acm:B.8</a>
    /// </summary>
    let B'_period_'8 = _prefixId.prefix "B.8"
    /// <summary>
    ///   <para>rdfs:label : B.8.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.8.0">acm:B.8.0</a>
    /// </summary>
    let B'_period_'8'_period_'0 = _prefixId.prefix "B.8.0"
    /// <summary>
    ///   <para>rdfs:label : B.8.1. Reliability, Testing, and Fault-Tolerance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.8.1">acm:B.8.1</a>
    /// </summary>
    let B'_period_'8'_period_'1 = _prefixId.prefix "B.8.1"
    /// <summary>
    ///   <para>rdfs:label : B.8.2. Performance Analysis and Design Aids^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.8.2">acm:B.8.2</a>
    /// </summary>
    let B'_period_'8'_period_'2 = _prefixId.prefix "B.8.2"
    /// <summary>
    ///   <para>rdfs:label : B.8.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.8.m">acm:B.8.m</a>
    /// </summary>
    let B'_period_'8'_period_'m = _prefixId.prefix "B.8.m"
    /// <summary>
    ///   <para>rdfs:label : B.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.m">acm:B.m</a>
    /// </summary>
    let B'_period_'m = _prefixId.prefix "B.m"
    /// <summary>
    ///   <para>rdfs:label : B.m.0. Design management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#B.m.0">acm:B.m.0</a>
    /// </summary>
    let B'_period_'m'_period_'0 = _prefixId.prefix "B.m.0"
    /// <summary>
    ///   <para>rdfs:label : C. Computer Systems Organization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C">acm:C</a>
    /// </summary>
    let C = _prefixId.prefix "C"
    /// <summary>
    ///   <para>rdfs:label : C.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.0">acm:C.0</a>
    /// </summary>
    let C'_period_'0 = _prefixId.prefix "C.0"
    /// <summary>
    ///   <para>rdfs:label : C.0.0. Hardware/software interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.0.0">acm:C.0.0</a>
    /// </summary>
    let C'_period_'0'_period_'0 = _prefixId.prefix "C.0.0"
    /// <summary>
    ///   <para>rdfs:label : C.0.1. Instruction set design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.0.1">acm:C.0.1</a>
    /// </summary>
    let C'_period_'0'_period_'1 = _prefixId.prefix "C.0.1"
    /// <summary>
    ///   <para>rdfs:label : C.0.2. Modeling of computer architecture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.0.2">acm:C.0.2</a>
    /// </summary>
    let C'_period_'0'_period_'2 = _prefixId.prefix "C.0.2"
    /// <summary>
    ///   <para>rdfs:label : C.0.3. System architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.0.3">acm:C.0.3</a>
    /// </summary>
    let C'_period_'0'_period_'3 = _prefixId.prefix "C.0.3"
    /// <summary>
    ///   <para>rdfs:label : C.0.4. Systems specification methodology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.0.4">acm:C.0.4</a>
    /// </summary>
    let C'_period_'0'_period_'4 = _prefixId.prefix "C.0.4"
    /// <summary>
    ///   <para>rdfs:label : C.1. PROCESSOR ARCHITECTURES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1">acm:C.1</a>
    /// </summary>
    let C'_period_'1 = _prefixId.prefix "C.1"
    /// <summary>
    ///   <para>rdfs:label : C.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.0">acm:C.1.0</a>
    /// </summary>
    let C'_period_'1'_period_'0 = _prefixId.prefix "C.1.0"
    /// <summary>
    ///   <para>rdfs:label : C.1.1. Single Data Stream Architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1">acm:C.1.1</a>
    /// </summary>
    let C'_period_'1'_period_'1 = _prefixId.prefix "C.1.1"
    /// <summary>
    ///   <para>rdfs:label : C.1.1.0. Multiple-instruction-stream, single-data-stream processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.0">acm:C.1.1.0</a>
    /// </summary>
    let C'_period_'1'_period_'1'_period_'0 = _prefixId.prefix "C.1.1.0"
    /// <summary>
    ///   <para>rdfs:label : C.1.1.1. Pipeline processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.1">acm:C.1.1.1</a>
    /// </summary>
    let C'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "C.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : C.1.1.2. RISC/CISC, VLIW architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.2">acm:C.1.1.2</a>
    /// </summary>
    let C'_period_'1'_period_'1'_period_'2 = _prefixId.prefix "C.1.1.2"
    /// <summary>
    ///   <para>rdfs:label : C.1.1.3. Single-instruction-stream, single-data-stream processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.3">acm:C.1.1.3</a>
    /// </summary>
    let C'_period_'1'_period_'1'_period_'3 = _prefixId.prefix "C.1.1.3"
    /// <summary>
    ///   <para>rdfs:label : C.1.1.4. Von Neumann architectures^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.1.4">acm:C.1.1.4</a>
    /// </summary>
    let C'_period_'1'_period_'1'_period_'4 = _prefixId.prefix "C.1.1.4"
    /// <summary>
    ///   <para>rdfs:label : C.1.2. Multiple Data Stream Architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2">acm:C.1.2</a>
    /// </summary>
    let C'_period_'1'_period_'2 = _prefixId.prefix "C.1.2"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.0. Array and vector processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.0">acm:C.1.2.0</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "C.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.1. Associative processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.1">acm:C.1.2.1</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "C.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.2. Connection machines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.2">acm:C.1.2.2</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "C.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.3. Interconnection architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.3">acm:C.1.2.3</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'3 = _prefixId.prefix "C.1.2.3"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.4. Multiple-instruction-stream, multiple-data-stream processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.4">acm:C.1.2.4</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'4 = _prefixId.prefix "C.1.2.4"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.5. Parallel processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.5">acm:C.1.2.5</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'5 = _prefixId.prefix "C.1.2.5"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.6. Pipeline processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.6">acm:C.1.2.6</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'6 = _prefixId.prefix "C.1.2.6"
    /// <summary>
    ///   <para>rdfs:label : C.1.2.7. Single-instruction-stream, multiple-data-stream processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.2.7">acm:C.1.2.7</a>
    /// </summary>
    let C'_period_'1'_period_'2'_period_'7 = _prefixId.prefix "C.1.2.7"
    /// <summary>
    ///   <para>rdfs:label : C.1.3. Other Architecture Styles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3">acm:C.1.3</a>
    /// </summary>
    let C'_period_'1'_period_'3 = _prefixId.prefix "C.1.3"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.0. Adaptable architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.0">acm:C.1.3.0</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'0 = _prefixId.prefix "C.1.3.0"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.1. Analog computers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.1">acm:C.1.3.1</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'1 = _prefixId.prefix "C.1.3.1"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.2. Capability architectures^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.2">acm:C.1.3.2</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'2 = _prefixId.prefix "C.1.3.2"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.3. Cellular architecture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.3">acm:C.1.3.3</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'3 = _prefixId.prefix "C.1.3.3"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.4. Data-flow architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.4">acm:C.1.3.4</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'4 = _prefixId.prefix "C.1.3.4"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.5. Heterogeneous systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.5">acm:C.1.3.5</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'5 = _prefixId.prefix "C.1.3.5"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.6. High-level language architectures^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.6">acm:C.1.3.6</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'6 = _prefixId.prefix "C.1.3.6"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.7. Neural nets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.7">acm:C.1.3.7</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'7 = _prefixId.prefix "C.1.3.7"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.8. Pipeline processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.8">acm:C.1.3.8</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'8 = _prefixId.prefix "C.1.3.8"
    /// <summary>
    ///   <para>rdfs:label : C.1.3.9. Stack-oriented processors^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.3.9">acm:C.1.3.9</a>
    /// </summary>
    let C'_period_'1'_period_'3'_period_'9 = _prefixId.prefix "C.1.3.9"
    /// <summary>
    ///   <para>rdfs:label : C.1.4. Parallel Architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4">acm:C.1.4</a>
    /// </summary>
    let C'_period_'1'_period_'4 = _prefixId.prefix "C.1.4"
    /// <summary>
    ///   <para>rdfs:label : C.1.4.0. Distributed architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.0">acm:C.1.4.0</a>
    /// </summary>
    let C'_period_'1'_period_'4'_period_'0 = _prefixId.prefix "C.1.4.0"
    /// <summary>
    ///   <para>rdfs:label : C.1.4.1. Mobile processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.4.1">acm:C.1.4.1</a>
    /// </summary>
    let C'_period_'1'_period_'4'_period_'1 = _prefixId.prefix "C.1.4.1"
    /// <summary>
    ///   <para>rdfs:label : C.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m">acm:C.1.m</a>
    /// </summary>
    let C'_period_'1'_period_'m = _prefixId.prefix "C.1.m"
    /// <summary>
    ///   <para>rdfs:label : C.1.m.0. Analog computers^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.0">acm:C.1.m.0</a>
    /// </summary>
    let C'_period_'1'_period_'m'_period_'0 = _prefixId.prefix "C.1.m.0"
    /// <summary>
    ///   <para>rdfs:label : C.1.m.1. Hybrid systems^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.1.m.1">acm:C.1.m.1</a>
    /// </summary>
    let C'_period_'1'_period_'m'_period_'1 = _prefixId.prefix "C.1.m.1"
    /// <summary>
    ///   <para>rdfs:label : C.2. COMPUTER-COMMUNICATION NETWORKS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2">acm:C.2</a>
    /// </summary>
    let C'_period_'2 = _prefixId.prefix "C.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0">acm:C.2.0</a>
    /// </summary>
    let C'_period_'2'_period_'0 = _prefixId.prefix "C.2.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.0.0. Data communications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.0">acm:C.2.0.0</a>
    /// </summary>
    let C'_period_'2'_period_'0'_period_'0 = _prefixId.prefix "C.2.0.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.0.1. Open Systems Interconnection reference model^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.1">acm:C.2.0.1</a>
    /// </summary>
    let C'_period_'2'_period_'0'_period_'1 = _prefixId.prefix "C.2.0.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.0.2. Security and protection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.0.2">acm:C.2.0.2</a>
    /// </summary>
    let C'_period_'2'_period_'0'_period_'2 = _prefixId.prefix "C.2.0.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.1. Network Architecture and Design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1">acm:C.2.1</a>
    /// </summary>
    let C'_period_'2'_period_'1 = _prefixId.prefix "C.2.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.0. Asynchronous Transfer Mode^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.0">acm:C.2.1.0</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "C.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.1. Centralized networks^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.1">acm:C.2.1.1</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "C.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.10. Wireless communication^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.10">acm:C.2.1.10</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'10 = _prefixId.prefix "C.2.1.10"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.2. Circuit-switching networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.2">acm:C.2.1.2</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "C.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.3. Distributed networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.3">acm:C.2.1.3</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'3 = _prefixId.prefix "C.2.1.3"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.4. Frame relay networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.4">acm:C.2.1.4</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'4 = _prefixId.prefix "C.2.1.4"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.5. ISDN^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.5">acm:C.2.1.5</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'5 = _prefixId.prefix "C.2.1.5"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.6. Network communications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.6">acm:C.2.1.6</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'6 = _prefixId.prefix "C.2.1.6"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.7. Network topology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.7">acm:C.2.1.7</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'7 = _prefixId.prefix "C.2.1.7"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.8. Packet-switching networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.8">acm:C.2.1.8</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'8 = _prefixId.prefix "C.2.1.8"
    /// <summary>
    ///   <para>rdfs:label : C.2.1.9. Store and forward networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.1.9">acm:C.2.1.9</a>
    /// </summary>
    let C'_period_'2'_period_'1'_period_'9 = _prefixId.prefix "C.2.1.9"
    /// <summary>
    ///   <para>rdfs:label : C.2.2. Network Protocols^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2">acm:C.2.2</a>
    /// </summary>
    let C'_period_'2'_period_'2 = _prefixId.prefix "C.2.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.2.0. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.0">acm:C.2.2.0</a>
    /// </summary>
    let C'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "C.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.2.1. Protocol architecture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.1">acm:C.2.2.1</a>
    /// </summary>
    let C'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "C.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.2.2. Protocol verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.2">acm:C.2.2.2</a>
    /// </summary>
    let C'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "C.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.2.3. Routing protocols^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.2.3">acm:C.2.2.3</a>
    /// </summary>
    let C'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "C.2.2.3"
    /// <summary>
    ///   <para>rdfs:label : C.2.3. Network Operations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3">acm:C.2.3</a>
    /// </summary>
    let C'_period_'2'_period_'3 = _prefixId.prefix "C.2.3"
    /// <summary>
    ///   <para>rdfs:label : C.2.3.0. Network management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.0">acm:C.2.3.0</a>
    /// </summary>
    let C'_period_'2'_period_'3'_period_'0 = _prefixId.prefix "C.2.3.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.3.1. Network monitoring^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.1">acm:C.2.3.1</a>
    /// </summary>
    let C'_period_'2'_period_'3'_period_'1 = _prefixId.prefix "C.2.3.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.3.2. Public networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.3.2">acm:C.2.3.2</a>
    /// </summary>
    let C'_period_'2'_period_'3'_period_'2 = _prefixId.prefix "C.2.3.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.4. Distributed Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4">acm:C.2.4</a>
    /// </summary>
    let C'_period_'2'_period_'4 = _prefixId.prefix "C.2.4"
    /// <summary>
    ///   <para>rdfs:label : C.2.4.0. Client/server^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.0">acm:C.2.4.0</a>
    /// </summary>
    let C'_period_'2'_period_'4'_period_'0 = _prefixId.prefix "C.2.4.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.4.1. Distributed applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.1">acm:C.2.4.1</a>
    /// </summary>
    let C'_period_'2'_period_'4'_period_'1 = _prefixId.prefix "C.2.4.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.4.2. Distributed databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.2">acm:C.2.4.2</a>
    /// </summary>
    let C'_period_'2'_period_'4'_period_'2 = _prefixId.prefix "C.2.4.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.4.3. Network operating systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.4.3">acm:C.2.4.3</a>
    /// </summary>
    let C'_period_'2'_period_'4'_period_'3 = _prefixId.prefix "C.2.4.3"
    /// <summary>
    ///   <para>rdfs:label : C.2.5. Local and Wide-Area Networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5">acm:C.2.5</a>
    /// </summary>
    let C'_period_'2'_period_'5 = _prefixId.prefix "C.2.5"
    /// <summary>
    ///   <para>rdfs:label : C.2.5.0. Access schemes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.0">acm:C.2.5.0</a>
    /// </summary>
    let C'_period_'2'_period_'5'_period_'0 = _prefixId.prefix "C.2.5.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.5.1. Buses^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.1">acm:C.2.5.1</a>
    /// </summary>
    let C'_period_'2'_period_'5'_period_'1 = _prefixId.prefix "C.2.5.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.5.2. Ethernet^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.2">acm:C.2.5.2</a>
    /// </summary>
    let C'_period_'2'_period_'5'_period_'2 = _prefixId.prefix "C.2.5.2"
    /// <summary>
    ///   <para>rdfs:label : C.2.5.3. High-speed^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.3">acm:C.2.5.3</a>
    /// </summary>
    let C'_period_'2'_period_'5'_period_'3 = _prefixId.prefix "C.2.5.3"
    /// <summary>
    ///   <para>rdfs:label : C.2.5.4. Internet^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.4">acm:C.2.5.4</a>
    /// </summary>
    let C'_period_'2'_period_'5'_period_'4 = _prefixId.prefix "C.2.5.4"
    /// <summary>
    ///   <para>rdfs:label : C.2.5.5. Token rings^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.5.5">acm:C.2.5.5</a>
    /// </summary>
    let C'_period_'2'_period_'5'_period_'5 = _prefixId.prefix "C.2.5.5"
    /// <summary>
    ///   <para>rdfs:label : C.2.6. Internetworking^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6">acm:C.2.6</a>
    /// </summary>
    let C'_period_'2'_period_'6 = _prefixId.prefix "C.2.6"
    /// <summary>
    ///   <para>rdfs:label : C.2.6.0. Routers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.0">acm:C.2.6.0</a>
    /// </summary>
    let C'_period_'2'_period_'6'_period_'0 = _prefixId.prefix "C.2.6.0"
    /// <summary>
    ///   <para>rdfs:label : C.2.6.1. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.6.1">acm:C.2.6.1</a>
    /// </summary>
    let C'_period_'2'_period_'6'_period_'1 = _prefixId.prefix "C.2.6.1"
    /// <summary>
    ///   <para>rdfs:label : C.2.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.2.m">acm:C.2.m</a>
    /// </summary>
    let C'_period_'2'_period_'m = _prefixId.prefix "C.2.m"
    /// <summary>
    ///   <para>rdfs:label : C.3. SPECIAL-PURPOSE AND APPLICATION-BASED SYSTEMS^^xsd:string</para>
    ///   <para>rdfs:comment : See also #J.7.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.3">acm:C.3</a>
    /// </summary>
    let C'_period_'3 = _prefixId.prefix "C.3"
    /// <summary>
    ///   <para>rdfs:label : C.3.0. Microprocessor/microcomputer applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.3.0">acm:C.3.0</a>
    /// </summary>
    let C'_period_'3'_period_'0 = _prefixId.prefix "C.3.0"
    /// <summary>
    ///   <para>rdfs:label : C.3.1. Process control systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.3.1">acm:C.3.1</a>
    /// </summary>
    let C'_period_'3'_period_'1 = _prefixId.prefix "C.3.1"
    /// <summary>
    ///   <para>rdfs:label : C.3.2. Real-time and embedded systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.3.2">acm:C.3.2</a>
    /// </summary>
    let C'_period_'3'_period_'2 = _prefixId.prefix "C.3.2"
    /// <summary>
    ///   <para>rdfs:label : C.3.3. Signal processing systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.3.3">acm:C.3.3</a>
    /// </summary>
    let C'_period_'3'_period_'3 = _prefixId.prefix "C.3.3"
    /// <summary>
    ///   <para>rdfs:label : C.3.4. Smartcards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.3.4">acm:C.3.4</a>
    /// </summary>
    let C'_period_'3'_period_'4 = _prefixId.prefix "C.3.4"
    /// <summary>
    ///   <para>rdfs:label : C.4. PERFORMANCE OF SYSTEMS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4">acm:C.4</a>
    /// </summary>
    let C'_period_'4 = _prefixId.prefix "C.4"
    /// <summary>
    ///   <para>rdfs:label : C.4.0. Design studies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4.0">acm:C.4.0</a>
    /// </summary>
    let C'_period_'4'_period_'0 = _prefixId.prefix "C.4.0"
    /// <summary>
    ///   <para>rdfs:label : C.4.1. Fault tolerance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4.1">acm:C.4.1</a>
    /// </summary>
    let C'_period_'4'_period_'1 = _prefixId.prefix "C.4.1"
    /// <summary>
    ///   <para>rdfs:label : C.4.2. Measurement techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4.2">acm:C.4.2</a>
    /// </summary>
    let C'_period_'4'_period_'2 = _prefixId.prefix "C.4.2"
    /// <summary>
    ///   <para>rdfs:label : C.4.3. Modeling techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4.3">acm:C.4.3</a>
    /// </summary>
    let C'_period_'4'_period_'3 = _prefixId.prefix "C.4.3"
    /// <summary>
    ///   <para>rdfs:label : C.4.4. Performance attributes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4.4">acm:C.4.4</a>
    /// </summary>
    let C'_period_'4'_period_'4 = _prefixId.prefix "C.4.4"
    /// <summary>
    ///   <para>rdfs:label : C.4.5. Reliability, availability, and serviceability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.4.5">acm:C.4.5</a>
    /// </summary>
    let C'_period_'4'_period_'5 = _prefixId.prefix "C.4.5"
    /// <summary>
    ///   <para>rdfs:label : C.5. COMPUTER SYSTEM IMPLEMENTATION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5">acm:C.5</a>
    /// </summary>
    let C'_period_'5 = _prefixId.prefix "C.5"
    /// <summary>
    ///   <para>rdfs:label : C.5.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.0">acm:C.5.0</a>
    /// </summary>
    let C'_period_'5'_period_'0 = _prefixId.prefix "C.5.0"
    /// <summary>
    ///   <para>rdfs:label : C.5.1. Large and Medium Computers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1">acm:C.5.1</a>
    /// </summary>
    let C'_period_'5'_period_'1 = _prefixId.prefix "C.5.1"
    /// <summary>
    ///   <para>rdfs:label : C.5.1.0. Super computers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.1.0">acm:C.5.1.0</a>
    /// </summary>
    let C'_period_'5'_period_'1'_period_'0 = _prefixId.prefix "C.5.1.0"
    /// <summary>
    ///   <para>rdfs:label : C.5.2. Minicomputers^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.2">acm:C.5.2</a>
    /// </summary>
    let C'_period_'5'_period_'2 = _prefixId.prefix "C.5.2"
    /// <summary>
    ///   <para>rdfs:label : C.5.3. Microcomputers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3">acm:C.5.3</a>
    /// </summary>
    let C'_period_'5'_period_'3 = _prefixId.prefix "C.5.3"
    /// <summary>
    ///   <para>rdfs:label : C.5.3.0. Microprocessors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.0">acm:C.5.3.0</a>
    /// </summary>
    let C'_period_'5'_period_'3'_period_'0 = _prefixId.prefix "C.5.3.0"
    /// <summary>
    ///   <para>rdfs:label : C.5.3.1. Personal computers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.1">acm:C.5.3.1</a>
    /// </summary>
    let C'_period_'5'_period_'3'_period_'1 = _prefixId.prefix "C.5.3.1"
    /// <summary>
    ///   <para>rdfs:label : C.5.3.2. Portable devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.2">acm:C.5.3.2</a>
    /// </summary>
    let C'_period_'5'_period_'3'_period_'2 = _prefixId.prefix "C.5.3.2"
    /// <summary>
    ///   <para>rdfs:label : C.5.3.3. Workstations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.3.3">acm:C.5.3.3</a>
    /// </summary>
    let C'_period_'5'_period_'3'_period_'3 = _prefixId.prefix "C.5.3.3"
    /// <summary>
    ///   <para>rdfs:label : C.5.4. VLSI Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.4">acm:C.5.4</a>
    /// </summary>
    let C'_period_'5'_period_'4 = _prefixId.prefix "C.5.4"
    /// <summary>
    ///   <para>rdfs:label : C.5.5. Servers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.5">acm:C.5.5</a>
    /// </summary>
    let C'_period_'5'_period_'5 = _prefixId.prefix "C.5.5"
    /// <summary>
    ///   <para>rdfs:label : C.5.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.5.m">acm:C.5.m</a>
    /// </summary>
    let C'_period_'5'_period_'m = _prefixId.prefix "C.5.m"
    /// <summary>
    ///   <para>rdfs:label : C.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#C.m">acm:C.m</a>
    /// </summary>
    let C'_period_'m = _prefixId.prefix "C.m"
    /// <summary>
    ///   <para>rdfs:label : D. Software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D">acm:D</a>
    /// </summary>
    let D = _prefixId.prefix "D"
    /// <summary>
    ///   <para>rdfs:label : D.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.0">acm:D.0</a>
    /// </summary>
    let D'_period_'0 = _prefixId.prefix "D.0"
    /// <summary>
    ///   <para>rdfs:label : D.1. PROGRAMMING TECHNIQUES^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1">acm:D.1</a>
    /// </summary>
    let D'_period_'1 = _prefixId.prefix "D.1"
    /// <summary>
    ///   <para>rdfs:label : D.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.0">acm:D.1.0</a>
    /// </summary>
    let D'_period_'1'_period_'0 = _prefixId.prefix "D.1.0"
    /// <summary>
    ///   <para>rdfs:label : D.1.1. Applicative Programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.1">acm:D.1.1</a>
    /// </summary>
    let D'_period_'1'_period_'1 = _prefixId.prefix "D.1.1"
    /// <summary>
    ///   <para>rdfs:label : D.1.2. Automatic Programming^^xsd:string</para>
    ///   <para>rdfs:comment : See also #I.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2">acm:D.1.2</a>
    /// </summary>
    let D'_period_'1'_period_'2 = _prefixId.prefix "D.1.2"
    /// <summary>
    ///   <para>rdfs:label : D.1.2.0. Distributed programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.0">acm:D.1.2.0</a>
    /// </summary>
    let D'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "D.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : D.1.2.1. Parallel programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.2.1">acm:D.1.2.1</a>
    /// </summary>
    let D'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "D.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : D.1.4. Sequential Programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.4">acm:D.1.4</a>
    /// </summary>
    let D'_period_'1'_period_'4 = _prefixId.prefix "D.1.4"
    /// <summary>
    ///   <para>rdfs:label : D.1.5. Object-oriented Programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.5">acm:D.1.5</a>
    /// </summary>
    let D'_period_'1'_period_'5 = _prefixId.prefix "D.1.5"
    /// <summary>
    ///   <para>rdfs:label : D.1.6. Logic Programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.6">acm:D.1.6</a>
    /// </summary>
    let D'_period_'1'_period_'6 = _prefixId.prefix "D.1.6"
    /// <summary>
    ///   <para>rdfs:label : D.1.7. Visual Programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.7">acm:D.1.7</a>
    /// </summary>
    let D'_period_'1'_period_'7 = _prefixId.prefix "D.1.7"
    /// <summary>
    ///   <para>rdfs:label : D.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.1.m">acm:D.1.m</a>
    /// </summary>
    let D'_period_'1'_period_'m = _prefixId.prefix "D.1.m"
    /// <summary>
    ///   <para>rdfs:label : D.2. SOFTWARE ENGINEERING^^xsd:string</para>
    ///   <para>rdfs:comment : See also #K.6.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2">acm:D.2</a>
    /// </summary>
    let D'_period_'2 = _prefixId.prefix "D.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.0. General^^xsd:string</para>
    ///   <para>rdfs:comment : See also #K.5.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0">acm:D.2.0</a>
    /// </summary>
    let D'_period_'2'_period_'0 = _prefixId.prefix "D.2.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.0.0. Protection mechanisms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.0">acm:D.2.0.0</a>
    /// </summary>
    let D'_period_'2'_period_'0'_period_'0 = _prefixId.prefix "D.2.0.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.0.1. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.0.1">acm:D.2.0.1</a>
    /// </summary>
    let D'_period_'2'_period_'0'_period_'1 = _prefixId.prefix "D.2.0.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.1. Requirements/Specifications^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1">acm:D.2.1</a>
    /// </summary>
    let D'_period_'2'_period_'1 = _prefixId.prefix "D.2.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.1.0. Elicitation methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.0">acm:D.2.1.0</a>
    /// </summary>
    let D'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "D.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.1.1. Languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.1">acm:D.2.1.1</a>
    /// </summary>
    let D'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "D.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.1.2. Methodologies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.2">acm:D.2.1.2</a>
    /// </summary>
    let D'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "D.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.1.3. Tools^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.1.3">acm:D.2.1.3</a>
    /// </summary>
    let D'_period_'2'_period_'1'_period_'3 = _prefixId.prefix "D.2.1.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.10. Design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998. See also #D.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10">acm:D.2.10</a>
    /// </summary>
    let D'_period_'2'_period_'10 = _prefixId.prefix "D.2.10"
    /// <summary>
    ///   <para>rdfs:label : D.2.10.0. Methodologies^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.0">acm:D.2.10.0</a>
    /// </summary>
    let D'_period_'2'_period_'10'_period_'0 = _prefixId.prefix "D.2.10.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.10.1. Representation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.10.1">acm:D.2.10.1</a>
    /// </summary>
    let D'_period_'2'_period_'10'_period_'1 = _prefixId.prefix "D.2.10.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.11. Software Architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11">acm:D.2.11</a>
    /// </summary>
    let D'_period_'2'_period_'11 = _prefixId.prefix "D.2.11"
    /// <summary>
    ///   <para>rdfs:label : D.2.11.0. Data abstraction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.0">acm:D.2.11.0</a>
    /// </summary>
    let D'_period_'2'_period_'11'_period_'0 = _prefixId.prefix "D.2.11.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.11.1. Domain-specific architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.1">acm:D.2.11.1</a>
    /// </summary>
    let D'_period_'2'_period_'11'_period_'1 = _prefixId.prefix "D.2.11.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.11.2. Information hiding^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.2">acm:D.2.11.2</a>
    /// </summary>
    let D'_period_'2'_period_'11'_period_'2 = _prefixId.prefix "D.2.11.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.11.3. Languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.3">acm:D.2.11.3</a>
    /// </summary>
    let D'_period_'2'_period_'11'_period_'3 = _prefixId.prefix "D.2.11.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.11.4. Patterns^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.11.4">acm:D.2.11.4</a>
    /// </summary>
    let D'_period_'2'_period_'11'_period_'4 = _prefixId.prefix "D.2.11.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.12. Interoperability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12">acm:D.2.12</a>
    /// </summary>
    let D'_period_'2'_period_'12 = _prefixId.prefix "D.2.12"
    /// <summary>
    ///   <para>rdfs:label : D.2.12.0. Data mapping^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.0">acm:D.2.12.0</a>
    /// </summary>
    let D'_period_'2'_period_'12'_period_'0 = _prefixId.prefix "D.2.12.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.12.1. Distributed objects^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.1">acm:D.2.12.1</a>
    /// </summary>
    let D'_period_'2'_period_'12'_period_'1 = _prefixId.prefix "D.2.12.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.12.2. Interface definition languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.12.2">acm:D.2.12.2</a>
    /// </summary>
    let D'_period_'2'_period_'12'_period_'2 = _prefixId.prefix "D.2.12.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.13. Reusable Software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13">acm:D.2.13</a>
    /// </summary>
    let D'_period_'2'_period_'13 = _prefixId.prefix "D.2.13"
    /// <summary>
    ///   <para>rdfs:label : D.2.13.0. Domain engineering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.0">acm:D.2.13.0</a>
    /// </summary>
    let D'_period_'2'_period_'13'_period_'0 = _prefixId.prefix "D.2.13.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.13.1. Reusable libraries^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.1">acm:D.2.13.1</a>
    /// </summary>
    let D'_period_'2'_period_'13'_period_'1 = _prefixId.prefix "D.2.13.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.13.2. Reuse models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.13.2">acm:D.2.13.2</a>
    /// </summary>
    let D'_period_'2'_period_'13'_period_'2 = _prefixId.prefix "D.2.13.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.2. Design Tools and Techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2">acm:D.2.2</a>
    /// </summary>
    let D'_period_'2'_period_'2 = _prefixId.prefix "D.2.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.0. Computer-aided software engineering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.0">acm:D.2.2.0</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "D.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.1. Decision tables^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.1">acm:D.2.2.1</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "D.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.10. Structured programming^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.10">acm:D.2.2.10</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'10 = _prefixId.prefix "D.2.2.10"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.11. Top-down programming^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.11">acm:D.2.2.11</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'11 = _prefixId.prefix "D.2.2.11"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.12. User interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.12">acm:D.2.2.12</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'12 = _prefixId.prefix "D.2.2.12"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.2. Evolutionary prototyping^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.2">acm:D.2.2.2</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "D.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.3. Flow charts^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.3">acm:D.2.2.3</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "D.2.2.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.4. Modules and interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.4">acm:D.2.2.4</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'4 = _prefixId.prefix "D.2.2.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.5. Object-oriented design methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.5">acm:D.2.2.5</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'5 = _prefixId.prefix "D.2.2.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.6. Petri nets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.6">acm:D.2.2.6</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'6 = _prefixId.prefix "D.2.2.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.7. Programmer workbench^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.7">acm:D.2.2.7</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'7 = _prefixId.prefix "D.2.2.7"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.8. Software libraries^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.8">acm:D.2.2.8</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'8 = _prefixId.prefix "D.2.2.8"
    /// <summary>
    ///   <para>rdfs:label : D.2.2.9. State diagrams^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.2.9">acm:D.2.2.9</a>
    /// </summary>
    let D'_period_'2'_period_'2'_period_'9 = _prefixId.prefix "D.2.2.9"
    /// <summary>
    ///   <para>rdfs:label : D.2.3. Coding Tools and Techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3">acm:D.2.3</a>
    /// </summary>
    let D'_period_'2'_period_'3 = _prefixId.prefix "D.2.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.0. Object-oriented programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.0">acm:D.2.3.0</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'0 = _prefixId.prefix "D.2.3.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.1. Pretty printers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.1">acm:D.2.3.1</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'1 = _prefixId.prefix "D.2.3.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.2. Program editors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.2">acm:D.2.3.2</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'2 = _prefixId.prefix "D.2.3.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.3. Reentrant code^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.3">acm:D.2.3.3</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'3 = _prefixId.prefix "D.2.3.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.4. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.4">acm:D.2.3.4</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'4 = _prefixId.prefix "D.2.3.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.5. Structured programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.5">acm:D.2.3.5</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'5 = _prefixId.prefix "D.2.3.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.3.6. Top-down programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.3.6">acm:D.2.3.6</a>
    /// </summary>
    let D'_period_'2'_period_'3'_period_'6 = _prefixId.prefix "D.2.3.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.4. Software/Program Verification^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.3.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4">acm:D.2.4</a>
    /// </summary>
    let D'_period_'2'_period_'4 = _prefixId.prefix "D.2.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.0. Assertion checkers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.0">acm:D.2.4.0</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'0 = _prefixId.prefix "D.2.4.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.1. Class invariants^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.1">acm:D.2.4.1</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'1 = _prefixId.prefix "D.2.4.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.2. Correctness proofs^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.2">acm:D.2.4.2</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'2 = _prefixId.prefix "D.2.4.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.3. Formal methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.3">acm:D.2.4.3</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'3 = _prefixId.prefix "D.2.4.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.4. Model checking^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.4">acm:D.2.4.4</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'4 = _prefixId.prefix "D.2.4.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.5. Programming by contract^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.5">acm:D.2.4.5</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'5 = _prefixId.prefix "D.2.4.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.6. Reliability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.6">acm:D.2.4.6</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'6 = _prefixId.prefix "D.2.4.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.7. Statistical methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.7">acm:D.2.4.7</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'7 = _prefixId.prefix "D.2.4.7"
    /// <summary>
    ///   <para>rdfs:label : D.2.4.8. Validation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.4.8">acm:D.2.4.8</a>
    /// </summary>
    let D'_period_'2'_period_'4'_period_'8 = _prefixId.prefix "D.2.4.8"
    /// <summary>
    ///   <para>rdfs:label : D.2.5. Testing and Debugging^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5">acm:D.2.5</a>
    /// </summary>
    let D'_period_'2'_period_'5 = _prefixId.prefix "D.2.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.0. Code inspections and walk-throughs^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.0">acm:D.2.5.0</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'0 = _prefixId.prefix "D.2.5.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.1. Debugging aids^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.1">acm:D.2.5.1</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'1 = _prefixId.prefix "D.2.5.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.2. Diagnostics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.2">acm:D.2.5.2</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'2 = _prefixId.prefix "D.2.5.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.3. Distributed debugging^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.3">acm:D.2.5.3</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'3 = _prefixId.prefix "D.2.5.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.4. Dumps^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.4">acm:D.2.5.4</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'4 = _prefixId.prefix "D.2.5.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.5. Error handling and recovery^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.5">acm:D.2.5.5</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'5 = _prefixId.prefix "D.2.5.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.6. Monitors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.6">acm:D.2.5.6</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'6 = _prefixId.prefix "D.2.5.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.7. Symbolic execution^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.7">acm:D.2.5.7</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'7 = _prefixId.prefix "D.2.5.7"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.8. Testing tools^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.8">acm:D.2.5.8</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'8 = _prefixId.prefix "D.2.5.8"
    /// <summary>
    ///   <para>rdfs:label : D.2.5.9. Tracing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.5.9">acm:D.2.5.9</a>
    /// </summary>
    let D'_period_'2'_period_'5'_period_'9 = _prefixId.prefix "D.2.5.9"
    /// <summary>
    ///   <para>rdfs:label : D.2.6. Programming Environments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6">acm:D.2.6</a>
    /// </summary>
    let D'_period_'2'_period_'6 = _prefixId.prefix "D.2.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.6.0. Graphical environments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.0">acm:D.2.6.0</a>
    /// </summary>
    let D'_period_'2'_period_'6'_period_'0 = _prefixId.prefix "D.2.6.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.6.1. Integrated environments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.1">acm:D.2.6.1</a>
    /// </summary>
    let D'_period_'2'_period_'6'_period_'1 = _prefixId.prefix "D.2.6.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.6.2. Interactive environments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.2">acm:D.2.6.2</a>
    /// </summary>
    let D'_period_'2'_period_'6'_period_'2 = _prefixId.prefix "D.2.6.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.6.3. Programmer workbench^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.6.3">acm:D.2.6.3</a>
    /// </summary>
    let D'_period_'2'_period_'6'_period_'3 = _prefixId.prefix "D.2.6.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.7. Distribution, Maintenance, and Enhancement^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7">acm:D.2.7</a>
    /// </summary>
    let D'_period_'2'_period_'7 = _prefixId.prefix "D.2.7"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.0. Corrections^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.0">acm:D.2.7.0</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'0 = _prefixId.prefix "D.2.7.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.1. Documentation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.1">acm:D.2.7.1</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'1 = _prefixId.prefix "D.2.7.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.2. Enhancement^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.2">acm:D.2.7.2</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'2 = _prefixId.prefix "D.2.7.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.3. Extensibility^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.3">acm:D.2.7.3</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'3 = _prefixId.prefix "D.2.7.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.4. Portability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.4">acm:D.2.7.4</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'4 = _prefixId.prefix "D.2.7.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.5. Restructuring, reverse engineering, and reengineering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.5">acm:D.2.7.5</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'5 = _prefixId.prefix "D.2.7.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.7.6. Version control^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.7.6">acm:D.2.7.6</a>
    /// </summary>
    let D'_period_'2'_period_'7'_period_'6 = _prefixId.prefix "D.2.7.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.8. Metrics^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.4.8.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8">acm:D.2.8</a>
    /// </summary>
    let D'_period_'2'_period_'8 = _prefixId.prefix "D.2.8"
    /// <summary>
    ///   <para>rdfs:label : D.2.8.0. Complexity measures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.0">acm:D.2.8.0</a>
    /// </summary>
    let D'_period_'2'_period_'8'_period_'0 = _prefixId.prefix "D.2.8.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.8.1. Performance measures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.1">acm:D.2.8.1</a>
    /// </summary>
    let D'_period_'2'_period_'8'_period_'1 = _prefixId.prefix "D.2.8.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.8.2. Process metrics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.2">acm:D.2.8.2</a>
    /// </summary>
    let D'_period_'2'_period_'8'_period_'2 = _prefixId.prefix "D.2.8.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.8.3. Product metrics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.3">acm:D.2.8.3</a>
    /// </summary>
    let D'_period_'2'_period_'8'_period_'3 = _prefixId.prefix "D.2.8.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.8.4. Software science^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.8.4">acm:D.2.8.4</a>
    /// </summary>
    let D'_period_'2'_period_'8'_period_'4 = _prefixId.prefix "D.2.8.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.9. Management^^xsd:string</para>
    ///   <para>rdfs:comment : See also #K.6.3, #K.6.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9">acm:D.2.9</a>
    /// </summary>
    let D'_period_'2'_period_'9 = _prefixId.prefix "D.2.9"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.0. Copyrights^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.0">acm:D.2.9.0</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'0 = _prefixId.prefix "D.2.9.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.1. Cost estimation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.1">acm:D.2.9.1</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'1 = _prefixId.prefix "D.2.9.1"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.2. Life cycle^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.2">acm:D.2.9.2</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'2 = _prefixId.prefix "D.2.9.2"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.3. Productivity^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.3">acm:D.2.9.3</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'3 = _prefixId.prefix "D.2.9.3"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.4. Programming teams^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.4">acm:D.2.9.4</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'4 = _prefixId.prefix "D.2.9.4"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.5. Software configuration management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.5">acm:D.2.9.5</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'5 = _prefixId.prefix "D.2.9.5"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.6. Software process models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.6">acm:D.2.9.6</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'6 = _prefixId.prefix "D.2.9.6"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.7. Software quality assurance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.7">acm:D.2.9.7</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'7 = _prefixId.prefix "D.2.9.7"
    /// <summary>
    ///   <para>rdfs:label : D.2.9.8. Time estimation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.9.8">acm:D.2.9.8</a>
    /// </summary>
    let D'_period_'2'_period_'9'_period_'8 = _prefixId.prefix "D.2.9.8"
    /// <summary>
    ///   <para>rdfs:label : D.2.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m">acm:D.2.m</a>
    /// </summary>
    let D'_period_'2'_period_'m = _prefixId.prefix "D.2.m"
    /// <summary>
    ///   <para>rdfs:label : D.2.m.0. Rapid prototyping^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.0">acm:D.2.m.0</a>
    /// </summary>
    let D'_period_'2'_period_'m'_period_'0 = _prefixId.prefix "D.2.m.0"
    /// <summary>
    ///   <para>rdfs:label : D.2.m.1. Reusable software^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.2.m.1">acm:D.2.m.1</a>
    /// </summary>
    let D'_period_'2'_period_'m'_period_'1 = _prefixId.prefix "D.2.m.1"
    /// <summary>
    ///   <para>rdfs:label : D.3. PROGRAMMING LANGUAGES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3">acm:D.3</a>
    /// </summary>
    let D'_period_'3 = _prefixId.prefix "D.3"
    /// <summary>
    ///   <para>rdfs:label : D.3.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0">acm:D.3.0</a>
    /// </summary>
    let D'_period_'3'_period_'0 = _prefixId.prefix "D.3.0"
    /// <summary>
    ///   <para>rdfs:label : D.3.0.0. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.0.0">acm:D.3.0.0</a>
    /// </summary>
    let D'_period_'3'_period_'0'_period_'0 = _prefixId.prefix "D.3.0.0"
    /// <summary>
    ///   <para>rdfs:label : D.3.1. Formal Definitions and Theory^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.2.1, #F.3.1, #F.3.2, #F.4.2, #F.4.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1">acm:D.3.1</a>
    /// </summary>
    let D'_period_'3'_period_'1 = _prefixId.prefix "D.3.1"
    /// <summary>
    ///   <para>rdfs:label : D.3.1.0. Semantics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.0">acm:D.3.1.0</a>
    /// </summary>
    let D'_period_'3'_period_'1'_period_'0 = _prefixId.prefix "D.3.1.0"
    /// <summary>
    ///   <para>rdfs:label : D.3.1.1. Syntax^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.1.1">acm:D.3.1.1</a>
    /// </summary>
    let D'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "D.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : D.3.2. Language Classifications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2">acm:D.3.2</a>
    /// </summary>
    let D'_period_'3'_period_'2 = _prefixId.prefix "D.3.2"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.0. Applicative languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.0">acm:D.3.2.0</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'0 = _prefixId.prefix "D.3.2.0"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.1. Concurrent, distributed, and parallel languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.1">acm:D.3.2.1</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "D.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.10. Nonprocedural languages^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.10">acm:D.3.2.10</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'10 = _prefixId.prefix "D.3.2.10"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.11. Object-oriented languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.11">acm:D.3.2.11</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'11 = _prefixId.prefix "D.3.2.11"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.12. Specialized application languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.12">acm:D.3.2.12</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'12 = _prefixId.prefix "D.3.2.12"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.13. Very high-level languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.13">acm:D.3.2.13</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'13 = _prefixId.prefix "D.3.2.13"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.2. Constraint and logic languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.2">acm:D.3.2.2</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'2 = _prefixId.prefix "D.3.2.2"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.3. Data-flow languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.3">acm:D.3.2.3</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'3 = _prefixId.prefix "D.3.2.3"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.4. Design languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.4">acm:D.3.2.4</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'4 = _prefixId.prefix "D.3.2.4"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.5. Extensible languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.5">acm:D.3.2.5</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'5 = _prefixId.prefix "D.3.2.5"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.6. Macro and assembly languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.6">acm:D.3.2.6</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'6 = _prefixId.prefix "D.3.2.6"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.7. Microprogramming languages^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.7">acm:D.3.2.7</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'7 = _prefixId.prefix "D.3.2.7"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.8. Multiparadigm languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.8">acm:D.3.2.8</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'8 = _prefixId.prefix "D.3.2.8"
    /// <summary>
    ///   <para>rdfs:label : D.3.2.9. Nondeterministic languages^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.2.9">acm:D.3.2.9</a>
    /// </summary>
    let D'_period_'3'_period_'2'_period_'9 = _prefixId.prefix "D.3.2.9"
    /// <summary>
    ///   <para>rdfs:label : D.3.3. Language Constructs and Features^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3">acm:D.3.3</a>
    /// </summary>
    let D'_period_'3'_period_'3 = _prefixId.prefix "D.3.3"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.0. Abstract data types^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.0">acm:D.3.3.0</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'0 = _prefixId.prefix "D.3.3.0"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.1. Classes and objects^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.1">acm:D.3.3.1</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'1 = _prefixId.prefix "D.3.3.1"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.10. Input/output^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.10">acm:D.3.3.10</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'10 = _prefixId.prefix "D.3.3.10"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.11. Modules, packages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.11">acm:D.3.3.11</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'11 = _prefixId.prefix "D.3.3.11"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.12. Patterns^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.12">acm:D.3.3.12</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'12 = _prefixId.prefix "D.3.3.12"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.13. Polymorphism^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.13">acm:D.3.3.13</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'13 = _prefixId.prefix "D.3.3.13"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.14. Procedures, functions, and subroutines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.14">acm:D.3.3.14</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'14 = _prefixId.prefix "D.3.3.14"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.15. Recursion^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.15">acm:D.3.3.15</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'15 = _prefixId.prefix "D.3.3.15"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.2. Concurrent programming structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.2">acm:D.3.3.2</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'2 = _prefixId.prefix "D.3.3.2"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.3. Constraints^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.3">acm:D.3.3.3</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'3 = _prefixId.prefix "D.3.3.3"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.4. Control structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.4">acm:D.3.3.4</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'4 = _prefixId.prefix "D.3.3.4"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.5. Coroutines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.5">acm:D.3.3.5</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'5 = _prefixId.prefix "D.3.3.5"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.6. Data types and structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.6">acm:D.3.3.6</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'6 = _prefixId.prefix "D.3.3.6"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.7. Dynamic storage management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.7">acm:D.3.3.7</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'7 = _prefixId.prefix "D.3.3.7"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.8. Frameworks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.8">acm:D.3.3.8</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'8 = _prefixId.prefix "D.3.3.8"
    /// <summary>
    ///   <para>rdfs:label : D.3.3.9. Inheritance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.3.9">acm:D.3.3.9</a>
    /// </summary>
    let D'_period_'3'_period_'3'_period_'9 = _prefixId.prefix "D.3.3.9"
    /// <summary>
    ///   <para>rdfs:label : D.3.4. Processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4">acm:D.3.4</a>
    /// </summary>
    let D'_period_'3'_period_'4 = _prefixId.prefix "D.3.4"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.0. Code generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.0">acm:D.3.4.0</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'0 = _prefixId.prefix "D.3.4.0"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.1. Compilers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.1">acm:D.3.4.1</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'1 = _prefixId.prefix "D.3.4.1"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.10. Run-time environments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.10">acm:D.3.4.10</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'10 = _prefixId.prefix "D.3.4.10"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.11. Translator writing systems and compiler generators^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.11">acm:D.3.4.11</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'11 = _prefixId.prefix "D.3.4.11"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.2. Debuggers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.2">acm:D.3.4.2</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'2 = _prefixId.prefix "D.3.4.2"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.3. Incremental compilers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.3">acm:D.3.4.3</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'3 = _prefixId.prefix "D.3.4.3"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.4. Interpreters^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.4">acm:D.3.4.4</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'4 = _prefixId.prefix "D.3.4.4"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.5. Memory management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.5">acm:D.3.4.5</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'5 = _prefixId.prefix "D.3.4.5"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.6. Optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.6">acm:D.3.4.6</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'6 = _prefixId.prefix "D.3.4.6"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.7. Parsing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.7">acm:D.3.4.7</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'7 = _prefixId.prefix "D.3.4.7"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.8. Preprocessors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.8">acm:D.3.4.8</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'8 = _prefixId.prefix "D.3.4.8"
    /// <summary>
    ///   <para>rdfs:label : D.3.4.9. Retargetable compilers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.4.9">acm:D.3.4.9</a>
    /// </summary>
    let D'_period_'3'_period_'4'_period_'9 = _prefixId.prefix "D.3.4.9"
    /// <summary>
    ///   <para>rdfs:label : D.3.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.3.m">acm:D.3.m</a>
    /// </summary>
    let D'_period_'3'_period_'m = _prefixId.prefix "D.3.m"
    /// <summary>
    ///   <para>rdfs:label : D.4. OPERATING SYSTEMS^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4">acm:D.4</a>
    /// </summary>
    let D'_period_'4 = _prefixId.prefix "D.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.0">acm:D.4.0</a>
    /// </summary>
    let D'_period_'4'_period_'0 = _prefixId.prefix "D.4.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.1. Process Management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1">acm:D.4.1</a>
    /// </summary>
    let D'_period_'4'_period_'1 = _prefixId.prefix "D.4.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.0. Concurrency^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.0">acm:D.4.1.0</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'0 = _prefixId.prefix "D.4.1.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.1. Deadlocks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.1">acm:D.4.1.1</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'1 = _prefixId.prefix "D.4.1.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.2. Multiprocessing/multiprogramming/multitasking^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.2">acm:D.4.1.2</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'2 = _prefixId.prefix "D.4.1.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.3. Mutual exclusion^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.3">acm:D.4.1.3</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'3 = _prefixId.prefix "D.4.1.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.4. Scheduling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.4">acm:D.4.1.4</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'4 = _prefixId.prefix "D.4.1.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.5. Synchronization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.5">acm:D.4.1.5</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'5 = _prefixId.prefix "D.4.1.5"
    /// <summary>
    ///   <para>rdfs:label : D.4.1.6. Threads^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.1.6">acm:D.4.1.6</a>
    /// </summary>
    let D'_period_'4'_period_'1'_period_'6 = _prefixId.prefix "D.4.1.6"
    /// <summary>
    ///   <para>rdfs:label : D.4.2. Storage Management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2">acm:D.4.2</a>
    /// </summary>
    let D'_period_'4'_period_'2 = _prefixId.prefix "D.4.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.0. Allocation/deallocation strategies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.0">acm:D.4.2.0</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'0 = _prefixId.prefix "D.4.2.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.1. Distributed memories^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.1">acm:D.4.2.1</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'1 = _prefixId.prefix "D.4.2.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.2. Garbage collection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.2">acm:D.4.2.2</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'2 = _prefixId.prefix "D.4.2.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.3. Main memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.3">acm:D.4.2.3</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'3 = _prefixId.prefix "D.4.2.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.4. Secondary storage^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.4">acm:D.4.2.4</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'4 = _prefixId.prefix "D.4.2.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.5. Segmentation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.5">acm:D.4.2.5</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'5 = _prefixId.prefix "D.4.2.5"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.6. Storage hierarchies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.6">acm:D.4.2.6</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'6 = _prefixId.prefix "D.4.2.6"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.7. Swapping^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.7">acm:D.4.2.7</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'7 = _prefixId.prefix "D.4.2.7"
    /// <summary>
    ///   <para>rdfs:label : D.4.2.8. Virtual memory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.2.8">acm:D.4.2.8</a>
    /// </summary>
    let D'_period_'4'_period_'2'_period_'8 = _prefixId.prefix "D.4.2.8"
    /// <summary>
    ///   <para>rdfs:label : D.4.3. File Systems Management^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.5.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3">acm:D.4.3</a>
    /// </summary>
    let D'_period_'4'_period_'3 = _prefixId.prefix "D.4.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.3.0. Access methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.0">acm:D.4.3.0</a>
    /// </summary>
    let D'_period_'4'_period_'3'_period_'0 = _prefixId.prefix "D.4.3.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.3.1. Directory structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.1">acm:D.4.3.1</a>
    /// </summary>
    let D'_period_'4'_period_'3'_period_'1 = _prefixId.prefix "D.4.3.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.3.2. Distributed file systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.2">acm:D.4.3.2</a>
    /// </summary>
    let D'_period_'4'_period_'3'_period_'2 = _prefixId.prefix "D.4.3.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.3.3. File organization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.3">acm:D.4.3.3</a>
    /// </summary>
    let D'_period_'4'_period_'3'_period_'3 = _prefixId.prefix "D.4.3.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.3.4. Maintenance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.3.4">acm:D.4.3.4</a>
    /// </summary>
    let D'_period_'4'_period_'3'_period_'4 = _prefixId.prefix "D.4.3.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.4. Communications Management^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4">acm:D.4.4</a>
    /// </summary>
    let D'_period_'4'_period_'4 = _prefixId.prefix "D.4.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.4.0. Buffering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.0">acm:D.4.4.0</a>
    /// </summary>
    let D'_period_'4'_period_'4'_period_'0 = _prefixId.prefix "D.4.4.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.4.1. Input/output^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.1">acm:D.4.4.1</a>
    /// </summary>
    let D'_period_'4'_period_'4'_period_'1 = _prefixId.prefix "D.4.4.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.4.2. Message sending^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.2">acm:D.4.4.2</a>
    /// </summary>
    let D'_period_'4'_period_'4'_period_'2 = _prefixId.prefix "D.4.4.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.4.3. Network communication^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.3">acm:D.4.4.3</a>
    /// </summary>
    let D'_period_'4'_period_'4'_period_'3 = _prefixId.prefix "D.4.4.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.4.4. Terminal management^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.4.4">acm:D.4.4.4</a>
    /// </summary>
    let D'_period_'4'_period_'4'_period_'4 = _prefixId.prefix "D.4.4.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.5. Reliability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5">acm:D.4.5</a>
    /// </summary>
    let D'_period_'4'_period_'5 = _prefixId.prefix "D.4.5"
    /// <summary>
    ///   <para>rdfs:label : D.4.5.0. Backup procedures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.0">acm:D.4.5.0</a>
    /// </summary>
    let D'_period_'4'_period_'5'_period_'0 = _prefixId.prefix "D.4.5.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.5.1. Checkpoint/restart^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.1">acm:D.4.5.1</a>
    /// </summary>
    let D'_period_'4'_period_'5'_period_'1 = _prefixId.prefix "D.4.5.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.5.2. Fault-tolerance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.2">acm:D.4.5.2</a>
    /// </summary>
    let D'_period_'4'_period_'5'_period_'2 = _prefixId.prefix "D.4.5.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.5.3. Verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.5.3">acm:D.4.5.3</a>
    /// </summary>
    let D'_period_'4'_period_'5'_period_'3 = _prefixId.prefix "D.4.5.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.6. Security and Protection^^xsd:string</para>
    ///   <para>rdfs:comment : See also #K.6.5.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6">acm:D.4.6</a>
    /// </summary>
    let D'_period_'4'_period_'6 = _prefixId.prefix "D.4.6"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.0. Access controls^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.0">acm:D.4.6.0</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'0 = _prefixId.prefix "D.4.6.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.1. Authentication^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.1">acm:D.4.6.1</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'1 = _prefixId.prefix "D.4.6.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.2. Cryptographic controls^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.2">acm:D.4.6.2</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'2 = _prefixId.prefix "D.4.6.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.3. Information flow controls^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.3">acm:D.4.6.3</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'3 = _prefixId.prefix "D.4.6.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.4. Invasive software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.4">acm:D.4.6.4</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'4 = _prefixId.prefix "D.4.6.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.5. Security kernels^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.5">acm:D.4.6.5</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'5 = _prefixId.prefix "D.4.6.5"
    /// <summary>
    ///   <para>rdfs:label : D.4.6.6. Verification^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.6.6">acm:D.4.6.6</a>
    /// </summary>
    let D'_period_'4'_period_'6'_period_'6 = _prefixId.prefix "D.4.6.6"
    /// <summary>
    ///   <para>rdfs:label : D.4.7. Organization and Design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7">acm:D.4.7</a>
    /// </summary>
    let D'_period_'4'_period_'7 = _prefixId.prefix "D.4.7"
    /// <summary>
    ///   <para>rdfs:label : D.4.7.0. Batch processing systems^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.0">acm:D.4.7.0</a>
    /// </summary>
    let D'_period_'4'_period_'7'_period_'0 = _prefixId.prefix "D.4.7.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.7.1. Distributed systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.1">acm:D.4.7.1</a>
    /// </summary>
    let D'_period_'4'_period_'7'_period_'1 = _prefixId.prefix "D.4.7.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.7.2. Hierarchical design^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.2">acm:D.4.7.2</a>
    /// </summary>
    let D'_period_'4'_period_'7'_period_'2 = _prefixId.prefix "D.4.7.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.7.3. Interactive systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.3">acm:D.4.7.3</a>
    /// </summary>
    let D'_period_'4'_period_'7'_period_'3 = _prefixId.prefix "D.4.7.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.7.4. Real-time systems and embedded systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.7.4">acm:D.4.7.4</a>
    /// </summary>
    let D'_period_'4'_period_'7'_period_'4 = _prefixId.prefix "D.4.7.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.8. Performance^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.4, #D.2.8, #I.6.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8">acm:D.4.8</a>
    /// </summary>
    let D'_period_'4'_period_'8 = _prefixId.prefix "D.4.8"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.0. Measurements^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.0">acm:D.4.8.0</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'0 = _prefixId.prefix "D.4.8.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.1. Modeling and prediction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.1">acm:D.4.8.1</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'1 = _prefixId.prefix "D.4.8.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.2. Monitors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.2">acm:D.4.8.2</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'2 = _prefixId.prefix "D.4.8.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.3. Operational analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.3">acm:D.4.8.3</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'3 = _prefixId.prefix "D.4.8.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.4. Queueing theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.4">acm:D.4.8.4</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'4 = _prefixId.prefix "D.4.8.4"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.5. Simulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.5">acm:D.4.8.5</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'5 = _prefixId.prefix "D.4.8.5"
    /// <summary>
    ///   <para>rdfs:label : D.4.8.6. Stochastic analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.8.6">acm:D.4.8.6</a>
    /// </summary>
    let D'_period_'4'_period_'8'_period_'6 = _prefixId.prefix "D.4.8.6"
    /// <summary>
    ///   <para>rdfs:label : D.4.9. Systems Programs and Utilities^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9">acm:D.4.9</a>
    /// </summary>
    let D'_period_'4'_period_'9 = _prefixId.prefix "D.4.9"
    /// <summary>
    ///   <para>rdfs:label : D.4.9.0. Command and control languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.0">acm:D.4.9.0</a>
    /// </summary>
    let D'_period_'4'_period_'9'_period_'0 = _prefixId.prefix "D.4.9.0"
    /// <summary>
    ///   <para>rdfs:label : D.4.9.1. Linkers^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.1">acm:D.4.9.1</a>
    /// </summary>
    let D'_period_'4'_period_'9'_period_'1 = _prefixId.prefix "D.4.9.1"
    /// <summary>
    ///   <para>rdfs:label : D.4.9.2. Loaders^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.2">acm:D.4.9.2</a>
    /// </summary>
    let D'_period_'4'_period_'9'_period_'2 = _prefixId.prefix "D.4.9.2"
    /// <summary>
    ///   <para>rdfs:label : D.4.9.3. Window managers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.9.3">acm:D.4.9.3</a>
    /// </summary>
    let D'_period_'4'_period_'9'_period_'3 = _prefixId.prefix "D.4.9.3"
    /// <summary>
    ///   <para>rdfs:label : D.4.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.4.m">acm:D.4.m</a>
    /// </summary>
    let D'_period_'4'_period_'m = _prefixId.prefix "D.4.m"
    /// <summary>
    ///   <para>rdfs:label : D.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.m">acm:D.m</a>
    /// </summary>
    let D'_period_'m = _prefixId.prefix "D.m"
    /// <summary>
    ///   <para>rdfs:label : D.m.0. Software psychology^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#D.m.0">acm:D.m.0</a>
    /// </summary>
    let D'_period_'m'_period_'0 = _prefixId.prefix "D.m.0"
    /// <summary>
    ///   <para>rdfs:label : E. Data^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E">acm:E</a>
    /// </summary>
    let E = _prefixId.prefix "E"
    /// <summary>
    ///   <para>rdfs:label : E.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.0">acm:E.0</a>
    /// </summary>
    let E'_period_'0 = _prefixId.prefix "E.0"
    /// <summary>
    ///   <para>rdfs:label : E.1. DATA STRUCTURES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1">acm:E.1</a>
    /// </summary>
    let E'_period_'1 = _prefixId.prefix "E.1"
    /// <summary>
    ///   <para>rdfs:label : E.1.0. Arrays^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.0">acm:E.1.0</a>
    /// </summary>
    let E'_period_'1'_period_'0 = _prefixId.prefix "E.1.0"
    /// <summary>
    ///   <para>rdfs:label : E.1.1. Distributed data structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.1">acm:E.1.1</a>
    /// </summary>
    let E'_period_'1'_period_'1 = _prefixId.prefix "E.1.1"
    /// <summary>
    ///   <para>rdfs:label : E.1.2. Graphs and networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.2">acm:E.1.2</a>
    /// </summary>
    let E'_period_'1'_period_'2 = _prefixId.prefix "E.1.2"
    /// <summary>
    ///   <para>rdfs:label : E.1.3. Lists, stacks, and queues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.3">acm:E.1.3</a>
    /// </summary>
    let E'_period_'1'_period_'3 = _prefixId.prefix "E.1.3"
    /// <summary>
    ///   <para>rdfs:label : E.1.4. Records^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.4">acm:E.1.4</a>
    /// </summary>
    let E'_period_'1'_period_'4 = _prefixId.prefix "E.1.4"
    /// <summary>
    ///   <para>rdfs:label : E.1.5. Tables^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.5">acm:E.1.5</a>
    /// </summary>
    let E'_period_'1'_period_'5 = _prefixId.prefix "E.1.5"
    /// <summary>
    ///   <para>rdfs:label : E.1.6. Trees^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.1.6">acm:E.1.6</a>
    /// </summary>
    let E'_period_'1'_period_'6 = _prefixId.prefix "E.1.6"
    /// <summary>
    ///   <para>rdfs:label : E.2. DATA STORAGE REPRESENTATIONS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2">acm:E.2</a>
    /// </summary>
    let E'_period_'2 = _prefixId.prefix "E.2"
    /// <summary>
    ///   <para>rdfs:label : E.2.0. Composite structures^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2.0">acm:E.2.0</a>
    /// </summary>
    let E'_period_'2'_period_'0 = _prefixId.prefix "E.2.0"
    /// <summary>
    ///   <para>rdfs:label : E.2.1. Contiguous representations^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2.1">acm:E.2.1</a>
    /// </summary>
    let E'_period_'2'_period_'1 = _prefixId.prefix "E.2.1"
    /// <summary>
    ///   <para>rdfs:label : E.2.2. Hash-table representations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2.2">acm:E.2.2</a>
    /// </summary>
    let E'_period_'2'_period_'2 = _prefixId.prefix "E.2.2"
    /// <summary>
    ///   <para>rdfs:label : E.2.3. Linked representations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2.3">acm:E.2.3</a>
    /// </summary>
    let E'_period_'2'_period_'3 = _prefixId.prefix "E.2.3"
    /// <summary>
    ///   <para>rdfs:label : E.2.4. Object representation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2.4">acm:E.2.4</a>
    /// </summary>
    let E'_period_'2'_period_'4 = _prefixId.prefix "E.2.4"
    /// <summary>
    ///   <para>rdfs:label : E.2.5. Primitive data items^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.2.5">acm:E.2.5</a>
    /// </summary>
    let E'_period_'2'_period_'5 = _prefixId.prefix "E.2.5"
    /// <summary>
    ///   <para>rdfs:label : E.3. DATA ENCRYPTION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.3">acm:E.3</a>
    /// </summary>
    let E'_period_'3 = _prefixId.prefix "E.3"
    /// <summary>
    ///   <para>rdfs:label : E.3.0. Code breaking^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.3.0">acm:E.3.0</a>
    /// </summary>
    let E'_period_'3'_period_'0 = _prefixId.prefix "E.3.0"
    /// <summary>
    ///   <para>rdfs:label : E.3.1. Data encryption standard^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.3.1">acm:E.3.1</a>
    /// </summary>
    let E'_period_'3'_period_'1 = _prefixId.prefix "E.3.1"
    /// <summary>
    ///   <para>rdfs:label : E.3.2. Public key cryptosystems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.3.2">acm:E.3.2</a>
    /// </summary>
    let E'_period_'3'_period_'2 = _prefixId.prefix "E.3.2"
    /// <summary>
    ///   <para>rdfs:label : E.3.3. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.3.3">acm:E.3.3</a>
    /// </summary>
    let E'_period_'3'_period_'3 = _prefixId.prefix "E.3.3"
    /// <summary>
    ///   <para>rdfs:label : E.4. CODING AND INFORMATION THEORY^^xsd:string</para>
    ///   <para>rdfs:comment : See also #H.1.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.4">acm:E.4</a>
    /// </summary>
    let E'_period_'4 = _prefixId.prefix "E.4"
    /// <summary>
    ///   <para>rdfs:label : E.4.0. Data compaction and compression^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.4.0">acm:E.4.0</a>
    /// </summary>
    let E'_period_'4'_period_'0 = _prefixId.prefix "E.4.0"
    /// <summary>
    ///   <para>rdfs:label : E.4.1. Error control codes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.4.1">acm:E.4.1</a>
    /// </summary>
    let E'_period_'4'_period_'1 = _prefixId.prefix "E.4.1"
    /// <summary>
    ///   <para>rdfs:label : E.4.2. Formal models of communication^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.4.2">acm:E.4.2</a>
    /// </summary>
    let E'_period_'4'_period_'2 = _prefixId.prefix "E.4.2"
    /// <summary>
    ///   <para>rdfs:label : E.4.3. Nonsecret encoding schemes^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.4.3">acm:E.4.3</a>
    /// </summary>
    let E'_period_'4'_period_'3 = _prefixId.prefix "E.4.3"
    /// <summary>
    ///   <para>rdfs:label : E.5. FILES^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.4.3, #F.2.2, #H.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.5">acm:E.5</a>
    /// </summary>
    let E'_period_'5 = _prefixId.prefix "E.5"
    /// <summary>
    ///   <para>rdfs:label : E.5.0. Backup/recovery^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.5.0">acm:E.5.0</a>
    /// </summary>
    let E'_period_'5'_period_'0 = _prefixId.prefix "E.5.0"
    /// <summary>
    ///   <para>rdfs:label : E.5.1. Optimization^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.5.1">acm:E.5.1</a>
    /// </summary>
    let E'_period_'5'_period_'1 = _prefixId.prefix "E.5.1"
    /// <summary>
    ///   <para>rdfs:label : E.5.2. Organization/structure^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.5.2">acm:E.5.2</a>
    /// </summary>
    let E'_period_'5'_period_'2 = _prefixId.prefix "E.5.2"
    /// <summary>
    ///   <para>rdfs:label : E.5.3. Sorting/searching^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.5.3">acm:E.5.3</a>
    /// </summary>
    let E'_period_'5'_period_'3 = _prefixId.prefix "E.5.3"
    /// <summary>
    ///   <para>rdfs:label : E.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#E.m">acm:E.m</a>
    /// </summary>
    let E'_period_'m = _prefixId.prefix "E.m"
    /// <summary>
    ///   <para>rdfs:label : F. Theory of Computation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F">acm:F</a>
    /// </summary>
    let F = _prefixId.prefix "F"
    /// <summary>
    ///   <para>rdfs:label : F.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.0">acm:F.0</a>
    /// </summary>
    let F'_period_'0 = _prefixId.prefix "F.0"
    /// <summary>
    ///   <para>rdfs:label : F.1. COMPUTATION BY ABSTRACT DEVICES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1">acm:F.1</a>
    /// </summary>
    let F'_period_'1 = _prefixId.prefix "F.1"
    /// <summary>
    ///   <para>rdfs:label : F.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.0">acm:F.1.0</a>
    /// </summary>
    let F'_period_'1'_period_'0 = _prefixId.prefix "F.1.0"
    /// <summary>
    ///   <para>rdfs:label : F.1.1. Models of Computation^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.4.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1">acm:F.1.1</a>
    /// </summary>
    let F'_period_'1'_period_'1 = _prefixId.prefix "F.1.1"
    /// <summary>
    ///   <para>rdfs:label : F.1.1.0. Automata^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.0">acm:F.1.1.0</a>
    /// </summary>
    let F'_period_'1'_period_'1'_period_'0 = _prefixId.prefix "F.1.1.0"
    /// <summary>
    ///   <para>rdfs:label : F.1.1.1. Bounded-action devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.1">acm:F.1.1.1</a>
    /// </summary>
    let F'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "F.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : F.1.1.2. Computability theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.2">acm:F.1.1.2</a>
    /// </summary>
    let F'_period_'1'_period_'1'_period_'2 = _prefixId.prefix "F.1.1.2"
    /// <summary>
    ///   <para>rdfs:label : F.1.1.3. Relations between models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.3">acm:F.1.1.3</a>
    /// </summary>
    let F'_period_'1'_period_'1'_period_'3 = _prefixId.prefix "F.1.1.3"
    /// <summary>
    ///   <para>rdfs:label : F.1.1.4. Self-modifying machines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.4">acm:F.1.1.4</a>
    /// </summary>
    let F'_period_'1'_period_'1'_period_'4 = _prefixId.prefix "F.1.1.4"
    /// <summary>
    ///   <para>rdfs:label : F.1.1.5. Unbounded-action devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.1.5">acm:F.1.1.5</a>
    /// </summary>
    let F'_period_'1'_period_'1'_period_'5 = _prefixId.prefix "F.1.1.5"
    /// <summary>
    ///   <para>rdfs:label : F.1.2. Modes of Computation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2">acm:F.1.2</a>
    /// </summary>
    let F'_period_'1'_period_'2 = _prefixId.prefix "F.1.2"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.0. Alternation and nondeterminism^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.0">acm:F.1.2.0</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "F.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.1. Interactive and reactive computation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.1">acm:F.1.2.1</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "F.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.2. Online computation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.2">acm:F.1.2.2</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "F.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.3. Parallelism and concurrency^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.3">acm:F.1.2.3</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'3 = _prefixId.prefix "F.1.2.3"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.4. Probabilistic computation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.4">acm:F.1.2.4</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'4 = _prefixId.prefix "F.1.2.4"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.5. Relations among modes^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.5">acm:F.1.2.5</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'5 = _prefixId.prefix "F.1.2.5"
    /// <summary>
    ///   <para>rdfs:label : F.1.2.6. Relativized computation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.2.6">acm:F.1.2.6</a>
    /// </summary>
    let F'_period_'1'_period_'2'_period_'6 = _prefixId.prefix "F.1.2.6"
    /// <summary>
    ///   <para>rdfs:label : F.1.3. Complexity Measures and Classes^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3">acm:F.1.3</a>
    /// </summary>
    let F'_period_'1'_period_'3 = _prefixId.prefix "F.1.3"
    /// <summary>
    ///   <para>rdfs:label : F.1.3.0. Complexity hierarchies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.0">acm:F.1.3.0</a>
    /// </summary>
    let F'_period_'1'_period_'3'_period_'0 = _prefixId.prefix "F.1.3.0"
    /// <summary>
    ///   <para>rdfs:label : F.1.3.1. Machine-independent complexity^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.1">acm:F.1.3.1</a>
    /// </summary>
    let F'_period_'1'_period_'3'_period_'1 = _prefixId.prefix "F.1.3.1"
    /// <summary>
    ///   <para>rdfs:label : F.1.3.2. Reducibility and completeness^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.2">acm:F.1.3.2</a>
    /// </summary>
    let F'_period_'1'_period_'3'_period_'2 = _prefixId.prefix "F.1.3.2"
    /// <summary>
    ///   <para>rdfs:label : F.1.3.3. Relations among complexity classes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.3">acm:F.1.3.3</a>
    /// </summary>
    let F'_period_'1'_period_'3'_period_'3 = _prefixId.prefix "F.1.3.3"
    /// <summary>
    ///   <para>rdfs:label : F.1.3.4. Relations among complexity measures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.3.4">acm:F.1.3.4</a>
    /// </summary>
    let F'_period_'1'_period_'3'_period_'4 = _prefixId.prefix "F.1.3.4"
    /// <summary>
    ///   <para>rdfs:label : F.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.1.m">acm:F.1.m</a>
    /// </summary>
    let F'_period_'1'_period_'m = _prefixId.prefix "F.1.m"
    /// <summary>
    ///   <para>rdfs:label : F.2. ANALYSIS OF ALGORITHMS AND PROBLEM COMPLEXITY^^xsd:string</para>
    ///   <para>rdfs:comment : See also #B.6, #B.7, #F.1.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2">acm:F.2</a>
    /// </summary>
    let F'_period_'2 = _prefixId.prefix "F.2"
    /// <summary>
    ///   <para>rdfs:label : F.2.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.0">acm:F.2.0</a>
    /// </summary>
    let F'_period_'2'_period_'0 = _prefixId.prefix "F.2.0"
    /// <summary>
    ///   <para>rdfs:label : F.2.1. Numerical Algorithms and Problems^^xsd:string</para>
    ///   <para>rdfs:comment : See also #G.1, #G.4, #I.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1">acm:F.2.1</a>
    /// </summary>
    let F'_period_'2'_period_'1 = _prefixId.prefix "F.2.1"
    /// <summary>
    ///   <para>rdfs:label : F.2.1.0. Computation of transforms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.0">acm:F.2.1.0</a>
    /// </summary>
    let F'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "F.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : F.2.1.1. Computations in finite fields^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.1">acm:F.2.1.1</a>
    /// </summary>
    let F'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "F.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : F.2.1.2. Computations on matrices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.2">acm:F.2.1.2</a>
    /// </summary>
    let F'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "F.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : F.2.1.3. Computations on polynomials^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.3">acm:F.2.1.3</a>
    /// </summary>
    let F'_period_'2'_period_'1'_period_'3 = _prefixId.prefix "F.2.1.3"
    /// <summary>
    ///   <para>rdfs:label : F.2.1.4. Number-theoretic computations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.1.4">acm:F.2.1.4</a>
    /// </summary>
    let F'_period_'2'_period_'1'_period_'4 = _prefixId.prefix "F.2.1.4"
    /// <summary>
    ///   <para>rdfs:label : F.2.2. Nonnumerical Algorithms and Problems^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.2, #E.3, #E.4, #E.5, #G.2, #H.2, #H.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2">acm:F.2.2</a>
    /// </summary>
    let F'_period_'2'_period_'2 = _prefixId.prefix "F.2.2"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.0. Complexity of proof procedures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.0">acm:F.2.2.0</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "F.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.1. Computations on discrete structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.1">acm:F.2.2.1</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "F.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.2. Geometrical problems and computations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.2">acm:F.2.2.2</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "F.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.3. Pattern matching^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.3">acm:F.2.2.3</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "F.2.2.3"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.4. Routing and layout^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.4">acm:F.2.2.4</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'4 = _prefixId.prefix "F.2.2.4"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.5. Sequencing and scheduling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.5">acm:F.2.2.5</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'5 = _prefixId.prefix "F.2.2.5"
    /// <summary>
    ///   <para>rdfs:label : F.2.2.6. Sorting and searching^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.2.6">acm:F.2.2.6</a>
    /// </summary>
    let F'_period_'2'_period_'2'_period_'6 = _prefixId.prefix "F.2.2.6"
    /// <summary>
    ///   <para>rdfs:label : F.2.3. Tradeoffs between Complexity Measures^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.1.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.2.3">acm:F.2.3</a>
    /// </summary>
    let F'_period_'2'_period_'3 = _prefixId.prefix "F.2.3"
    /// <summary>
    ///   <para>rdfs:label : F.3. LOGICS AND MEANINGS OF PROGRAMS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3">acm:F.3</a>
    /// </summary>
    let F'_period_'3 = _prefixId.prefix "F.3"
    /// <summary>
    ///   <para>rdfs:label : F.3.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.0">acm:F.3.0</a>
    /// </summary>
    let F'_period_'3'_period_'0 = _prefixId.prefix "F.3.0"
    /// <summary>
    ///   <para>rdfs:label : F.3.1. Specifying and Verifying and Reasoning about Programs^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.2.1, #D.2.4, #D.3.1, #E.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1">acm:F.3.1</a>
    /// </summary>
    let F'_period_'3'_period_'1 = _prefixId.prefix "F.3.1"
    /// <summary>
    ///   <para>rdfs:label : F.3.1.0. Assertions^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.0">acm:F.3.1.0</a>
    /// </summary>
    let F'_period_'3'_period_'1'_period_'0 = _prefixId.prefix "F.3.1.0"
    /// <summary>
    ///   <para>rdfs:label : F.3.1.1. Invariants^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.1">acm:F.3.1.1</a>
    /// </summary>
    let F'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "F.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : F.3.1.2. Logics of programs^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.2">acm:F.3.1.2</a>
    /// </summary>
    let F'_period_'3'_period_'1'_period_'2 = _prefixId.prefix "F.3.1.2"
    /// <summary>
    ///   <para>rdfs:label : F.3.1.3. Mechanical verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.3">acm:F.3.1.3</a>
    /// </summary>
    let F'_period_'3'_period_'1'_period_'3 = _prefixId.prefix "F.3.1.3"
    /// <summary>
    ///   <para>rdfs:label : F.3.1.4. Pre- and post-conditions^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.4">acm:F.3.1.4</a>
    /// </summary>
    let F'_period_'3'_period_'1'_period_'4 = _prefixId.prefix "F.3.1.4"
    /// <summary>
    ///   <para>rdfs:label : F.3.1.5. Specification techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.1.5">acm:F.3.1.5</a>
    /// </summary>
    let F'_period_'3'_period_'1'_period_'5 = _prefixId.prefix "F.3.1.5"
    /// <summary>
    ///   <para>rdfs:label : F.3.2. Semantics of Programming Languages^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2">acm:F.3.2</a>
    /// </summary>
    let F'_period_'3'_period_'2 = _prefixId.prefix "F.3.2"
    /// <summary>
    ///   <para>rdfs:label : F.3.2.0. Algebraic approaches to semantics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.0">acm:F.3.2.0</a>
    /// </summary>
    let F'_period_'3'_period_'2'_period_'0 = _prefixId.prefix "F.3.2.0"
    /// <summary>
    ///   <para>rdfs:label : F.3.2.1. Denotational semantics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.1">acm:F.3.2.1</a>
    /// </summary>
    let F'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "F.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : F.3.2.2. Operational semantics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.2">acm:F.3.2.2</a>
    /// </summary>
    let F'_period_'3'_period_'2'_period_'2 = _prefixId.prefix "F.3.2.2"
    /// <summary>
    ///   <para>rdfs:label : F.3.2.3. Partial evaluation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.3">acm:F.3.2.3</a>
    /// </summary>
    let F'_period_'3'_period_'2'_period_'3 = _prefixId.prefix "F.3.2.3"
    /// <summary>
    ///   <para>rdfs:label : F.3.2.4. Process models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.4">acm:F.3.2.4</a>
    /// </summary>
    let F'_period_'3'_period_'2'_period_'4 = _prefixId.prefix "F.3.2.4"
    /// <summary>
    ///   <para>rdfs:label : F.3.2.5. Program analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.2.5">acm:F.3.2.5</a>
    /// </summary>
    let F'_period_'3'_period_'2'_period_'5 = _prefixId.prefix "F.3.2.5"
    /// <summary>
    ///   <para>rdfs:label : F.3.3. Studies of Program Constructs^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.2, #D.3.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3">acm:F.3.3</a>
    /// </summary>
    let F'_period_'3'_period_'3 = _prefixId.prefix "F.3.3"
    /// <summary>
    ///   <para>rdfs:label : F.3.3.0. Control primitives^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.0">acm:F.3.3.0</a>
    /// </summary>
    let F'_period_'3'_period_'3'_period_'0 = _prefixId.prefix "F.3.3.0"
    /// <summary>
    ///   <para>rdfs:label : F.3.3.1. Functional constructs^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.1">acm:F.3.3.1</a>
    /// </summary>
    let F'_period_'3'_period_'3'_period_'1 = _prefixId.prefix "F.3.3.1"
    /// <summary>
    ///   <para>rdfs:label : F.3.3.2. Object-oriented constructs^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.2">acm:F.3.3.2</a>
    /// </summary>
    let F'_period_'3'_period_'3'_period_'2 = _prefixId.prefix "F.3.3.2"
    /// <summary>
    ///   <para>rdfs:label : F.3.3.3. Program and recursion schemes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.3">acm:F.3.3.3</a>
    /// </summary>
    let F'_period_'3'_period_'3'_period_'3 = _prefixId.prefix "F.3.3.3"
    /// <summary>
    ///   <para>rdfs:label : F.3.3.4. Type structure^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.3.4">acm:F.3.3.4</a>
    /// </summary>
    let F'_period_'3'_period_'3'_period_'4 = _prefixId.prefix "F.3.3.4"
    /// <summary>
    ///   <para>rdfs:label : F.3.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.3.m">acm:F.3.m</a>
    /// </summary>
    let F'_period_'3'_period_'m = _prefixId.prefix "F.3.m"
    /// <summary>
    ///   <para>rdfs:label : F.4. MATHEMATICAL LOGIC AND FORMAL LANGUAGES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4">acm:F.4</a>
    /// </summary>
    let F'_period_'4 = _prefixId.prefix "F.4"
    /// <summary>
    ///   <para>rdfs:label : F.4.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.0">acm:F.4.0</a>
    /// </summary>
    let F'_period_'4'_period_'0 = _prefixId.prefix "F.4.0"
    /// <summary>
    ///   <para>rdfs:label : F.4.1. Mathematical Logic^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.1.1, #I.2.2, #I.2.3, #I.2.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1">acm:F.4.1</a>
    /// </summary>
    let F'_period_'4'_period_'1 = _prefixId.prefix "F.4.1"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.0. Computability theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.0">acm:F.4.1.0</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'0 = _prefixId.prefix "F.4.1.0"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.1. Computational logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.1">acm:F.4.1.1</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'1 = _prefixId.prefix "F.4.1.1"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.10. Temporal logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.10">acm:F.4.1.10</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'10 = _prefixId.prefix "F.4.1.10"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.2. Lambda calculus and related systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.2">acm:F.4.1.2</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'2 = _prefixId.prefix "F.4.1.2"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.3. Logic and constraint programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.3">acm:F.4.1.3</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'3 = _prefixId.prefix "F.4.1.3"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.4. Mechanical theorem proving^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.4">acm:F.4.1.4</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'4 = _prefixId.prefix "F.4.1.4"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.5. Modal logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.5">acm:F.4.1.5</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'5 = _prefixId.prefix "F.4.1.5"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.6. Model theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.6">acm:F.4.1.6</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'6 = _prefixId.prefix "F.4.1.6"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.7. Proof theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.7">acm:F.4.1.7</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'7 = _prefixId.prefix "F.4.1.7"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.8. Recursive function theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.8">acm:F.4.1.8</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'8 = _prefixId.prefix "F.4.1.8"
    /// <summary>
    ///   <para>rdfs:label : F.4.1.9. Set theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.1.9">acm:F.4.1.9</a>
    /// </summary>
    let F'_period_'4'_period_'1'_period_'9 = _prefixId.prefix "F.4.1.9"
    /// <summary>
    ///   <para>rdfs:label : F.4.2. Grammars and Other Rewriting Systems^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2">acm:F.4.2</a>
    /// </summary>
    let F'_period_'4'_period_'2 = _prefixId.prefix "F.4.2"
    /// <summary>
    ///   <para>rdfs:label : F.4.2.0. Decision problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.0">acm:F.4.2.0</a>
    /// </summary>
    let F'_period_'4'_period_'2'_period_'0 = _prefixId.prefix "F.4.2.0"
    /// <summary>
    ///   <para>rdfs:label : F.4.2.1. Grammar types^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.1">acm:F.4.2.1</a>
    /// </summary>
    let F'_period_'4'_period_'2'_period_'1 = _prefixId.prefix "F.4.2.1"
    /// <summary>
    ///   <para>rdfs:label : F.4.2.2. Parallel rewriting systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.2">acm:F.4.2.2</a>
    /// </summary>
    let F'_period_'4'_period_'2'_period_'2 = _prefixId.prefix "F.4.2.2"
    /// <summary>
    ///   <para>rdfs:label : F.4.2.3. Parsing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.3">acm:F.4.2.3</a>
    /// </summary>
    let F'_period_'4'_period_'2'_period_'3 = _prefixId.prefix "F.4.2.3"
    /// <summary>
    ///   <para>rdfs:label : F.4.2.4. Thue systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.2.4">acm:F.4.2.4</a>
    /// </summary>
    let F'_period_'4'_period_'2'_period_'4 = _prefixId.prefix "F.4.2.4"
    /// <summary>
    ///   <para>rdfs:label : F.4.3. Formal Languages^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3">acm:F.4.3</a>
    /// </summary>
    let F'_period_'4'_period_'3 = _prefixId.prefix "F.4.3"
    /// <summary>
    ///   <para>rdfs:label : F.4.3.0. Algebraic language theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.0">acm:F.4.3.0</a>
    /// </summary>
    let F'_period_'4'_period_'3'_period_'0 = _prefixId.prefix "F.4.3.0"
    /// <summary>
    ///   <para>rdfs:label : F.4.3.1. Classes defined by grammars or automata^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.1">acm:F.4.3.1</a>
    /// </summary>
    let F'_period_'4'_period_'3'_period_'1 = _prefixId.prefix "F.4.3.1"
    /// <summary>
    ///   <para>rdfs:label : F.4.3.2. Classes defined by resource-bounded automata^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.2">acm:F.4.3.2</a>
    /// </summary>
    let F'_period_'4'_period_'3'_period_'2 = _prefixId.prefix "F.4.3.2"
    /// <summary>
    ///   <para>rdfs:label : F.4.3.3. Decision problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.3">acm:F.4.3.3</a>
    /// </summary>
    let F'_period_'4'_period_'3'_period_'3 = _prefixId.prefix "F.4.3.3"
    /// <summary>
    ///   <para>rdfs:label : F.4.3.4. Operations on languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.3.4">acm:F.4.3.4</a>
    /// </summary>
    let F'_period_'4'_period_'3'_period_'4 = _prefixId.prefix "F.4.3.4"
    /// <summary>
    ///   <para>rdfs:label : F.4.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.4.m">acm:F.4.m</a>
    /// </summary>
    let F'_period_'4'_period_'m = _prefixId.prefix "F.4.m"
    /// <summary>
    ///   <para>rdfs:label : F.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#F.m">acm:F.m</a>
    /// </summary>
    let F'_period_'m = _prefixId.prefix "F.m"
    /// <summary>
    ///   <para>rdfs:label : G. Mathematics of Computing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G">acm:G</a>
    /// </summary>
    let G = _prefixId.prefix "G"
    /// <summary>
    ///   <para>rdfs:label : G.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.0">acm:G.0</a>
    /// </summary>
    let G'_period_'0 = _prefixId.prefix "G.0"
    /// <summary>
    ///   <para>rdfs:label : G.1. NUMERICAL ANALYSIS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1">acm:G.1</a>
    /// </summary>
    let G'_period_'1 = _prefixId.prefix "G.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0">acm:G.1.0</a>
    /// </summary>
    let G'_period_'1'_period_'0 = _prefixId.prefix "G.1.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.0. Computer arithmetic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.0">acm:G.1.0.0</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'0 = _prefixId.prefix "G.1.0.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.1. Conditioning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.1">acm:G.1.0.1</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'1 = _prefixId.prefix "G.1.0.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.2. Error analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.2">acm:G.1.0.2</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'2 = _prefixId.prefix "G.1.0.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.3. Interval arithmetic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.3">acm:G.1.0.3</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'3 = _prefixId.prefix "G.1.0.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.4. Multiple precision arithmetic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.4">acm:G.1.0.4</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'4 = _prefixId.prefix "G.1.0.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.5. Numerical algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.5">acm:G.1.0.5</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'5 = _prefixId.prefix "G.1.0.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.6. Parallel algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.6">acm:G.1.0.6</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'6 = _prefixId.prefix "G.1.0.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.0.7. Stability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.0.7">acm:G.1.0.7</a>
    /// </summary>
    let G'_period_'1'_period_'0'_period_'7 = _prefixId.prefix "G.1.0.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.1. Interpolation^^xsd:string</para>
    ///   <para>rdfs:comment : See also #I.3.5, #I.3.7.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1">acm:G.1.1</a>
    /// </summary>
    let G'_period_'1'_period_'1 = _prefixId.prefix "G.1.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.1.0. Difference formulas^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.0">acm:G.1.1.0</a>
    /// </summary>
    let G'_period_'1'_period_'1'_period_'0 = _prefixId.prefix "G.1.1.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.1.1. Extrapolation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.1">acm:G.1.1.1</a>
    /// </summary>
    let G'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "G.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.1.2. Interpolation formulas^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.2">acm:G.1.1.2</a>
    /// </summary>
    let G'_period_'1'_period_'1'_period_'2 = _prefixId.prefix "G.1.1.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.1.3. Smoothing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.3">acm:G.1.1.3</a>
    /// </summary>
    let G'_period_'1'_period_'1'_period_'3 = _prefixId.prefix "G.1.1.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.1.4. Spline and piecewise polynomial interpolation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.1.4">acm:G.1.1.4</a>
    /// </summary>
    let G'_period_'1'_period_'1'_period_'4 = _prefixId.prefix "G.1.1.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.10. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.10">acm:G.1.10</a>
    /// </summary>
    let G'_period_'1'_period_'10 = _prefixId.prefix "G.1.10"
    /// <summary>
    ///   <para>rdfs:label : G.1.2. Approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2">acm:G.1.2</a>
    /// </summary>
    let G'_period_'1'_period_'2 = _prefixId.prefix "G.1.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.0. Approximation of surfaces and contours^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.0">acm:G.1.2.0</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "G.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.1. Chebyshev approximation and theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.1">acm:G.1.2.1</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "G.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.10. Spline and piecewise polynomial approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.10">acm:G.1.2.10</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'10 = _prefixId.prefix "G.1.2.10"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.11. Wavelets and fractals^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.11">acm:G.1.2.11</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'11 = _prefixId.prefix "G.1.2.11"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.2. Elementary function approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.2">acm:G.1.2.2</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "G.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.3. Fast Fourier transforms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.3">acm:G.1.2.3</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'3 = _prefixId.prefix "G.1.2.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.4. Least squares approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.4">acm:G.1.2.4</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'4 = _prefixId.prefix "G.1.2.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.5. Linear approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.5">acm:G.1.2.5</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'5 = _prefixId.prefix "G.1.2.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.6. Minimax approximation and algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.6">acm:G.1.2.6</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'6 = _prefixId.prefix "G.1.2.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.7. Nonlinear approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.7">acm:G.1.2.7</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'7 = _prefixId.prefix "G.1.2.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.8. Rational approximation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.8">acm:G.1.2.8</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'8 = _prefixId.prefix "G.1.2.8"
    /// <summary>
    ///   <para>rdfs:label : G.1.2.9. Special function approximations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.2.9">acm:G.1.2.9</a>
    /// </summary>
    let G'_period_'1'_period_'2'_period_'9 = _prefixId.prefix "G.1.2.9"
    /// <summary>
    ///   <para>rdfs:label : G.1.3. Numerical Linear Algebra^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3">acm:G.1.3</a>
    /// </summary>
    let G'_period_'1'_period_'3 = _prefixId.prefix "G.1.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.0. Conditioning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.0">acm:G.1.3.0</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'0 = _prefixId.prefix "G.1.3.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.1. Determinants^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.1">acm:G.1.3.1</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'1 = _prefixId.prefix "G.1.3.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.2. Eigenvalues and eigenvectors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.2">acm:G.1.3.2</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'2 = _prefixId.prefix "G.1.3.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.3. Error analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.3">acm:G.1.3.3</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'3 = _prefixId.prefix "G.1.3.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.4. Linear systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.4">acm:G.1.3.4</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'4 = _prefixId.prefix "G.1.3.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.5. Matrix inversion^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.5">acm:G.1.3.5</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'5 = _prefixId.prefix "G.1.3.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.6. Pseudoinverses^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.6">acm:G.1.3.6</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'6 = _prefixId.prefix "G.1.3.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.7. Singular value decomposition^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.7">acm:G.1.3.7</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'7 = _prefixId.prefix "G.1.3.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.3.8. Sparse, structured, and very large systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.3.8">acm:G.1.3.8</a>
    /// </summary>
    let G'_period_'1'_period_'3'_period_'8 = _prefixId.prefix "G.1.3.8"
    /// <summary>
    ///   <para>rdfs:label : G.1.4. Quadrature and Numerical Differentiation^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.2.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4">acm:G.1.4</a>
    /// </summary>
    let G'_period_'1'_period_'4 = _prefixId.prefix "G.1.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.0. Adaptive and iterative quadrature^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.0">acm:G.1.4.0</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'0 = _prefixId.prefix "G.1.4.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.1. Automatic differentiation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.1">acm:G.1.4.1</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'1 = _prefixId.prefix "G.1.4.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.2. Equal interval integration^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.2">acm:G.1.4.2</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'2 = _prefixId.prefix "G.1.4.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.3. Error analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.3">acm:G.1.4.3</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'3 = _prefixId.prefix "G.1.4.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.4. Finite difference methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.4">acm:G.1.4.4</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'4 = _prefixId.prefix "G.1.4.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.5. Gaussian quadrature^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.5">acm:G.1.4.5</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'5 = _prefixId.prefix "G.1.4.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.6. Iterative methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.6">acm:G.1.4.6</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'6 = _prefixId.prefix "G.1.4.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.4.7. Multidimensional quadrature^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.4.7">acm:G.1.4.7</a>
    /// </summary>
    let G'_period_'1'_period_'4'_period_'7 = _prefixId.prefix "G.1.4.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.5. Roots of Nonlinear Equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5">acm:G.1.5</a>
    /// </summary>
    let G'_period_'1'_period_'5 = _prefixId.prefix "G.1.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.5.0. Continuation methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.0">acm:G.1.5.0</a>
    /// </summary>
    let G'_period_'1'_period_'5'_period_'0 = _prefixId.prefix "G.1.5.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.5.1. Convergence^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.1">acm:G.1.5.1</a>
    /// </summary>
    let G'_period_'1'_period_'5'_period_'1 = _prefixId.prefix "G.1.5.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.5.2. Error analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.2">acm:G.1.5.2</a>
    /// </summary>
    let G'_period_'1'_period_'5'_period_'2 = _prefixId.prefix "G.1.5.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.5.3. Iterative methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.3">acm:G.1.5.3</a>
    /// </summary>
    let G'_period_'1'_period_'5'_period_'3 = _prefixId.prefix "G.1.5.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.5.4. Polynomials, methods for^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.4">acm:G.1.5.4</a>
    /// </summary>
    let G'_period_'1'_period_'5'_period_'4 = _prefixId.prefix "G.1.5.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.5.5. Systems of equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.5.5">acm:G.1.5.5</a>
    /// </summary>
    let G'_period_'1'_period_'5'_period_'5 = _prefixId.prefix "G.1.5.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.6. Optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6">acm:G.1.6</a>
    /// </summary>
    let G'_period_'1'_period_'6 = _prefixId.prefix "G.1.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.0. Constrained optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.0">acm:G.1.6.0</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'0 = _prefixId.prefix "G.1.6.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.1. Convex programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.1">acm:G.1.6.1</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'1 = _prefixId.prefix "G.1.6.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.10. Stochastic programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.10">acm:G.1.6.10</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'10 = _prefixId.prefix "G.1.6.10"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.11. Unconstrained optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.11">acm:G.1.6.11</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'11 = _prefixId.prefix "G.1.6.11"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.2. Global optimization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.2">acm:G.1.6.2</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'2 = _prefixId.prefix "G.1.6.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.3. Gradient methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.3">acm:G.1.6.3</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'3 = _prefixId.prefix "G.1.6.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.4. Integer programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.4">acm:G.1.6.4</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'4 = _prefixId.prefix "G.1.6.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.5. Least squares methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.5">acm:G.1.6.5</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'5 = _prefixId.prefix "G.1.6.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.6. Linear programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.6">acm:G.1.6.6</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'6 = _prefixId.prefix "G.1.6.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.7. Nonlinear programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.7">acm:G.1.6.7</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'7 = _prefixId.prefix "G.1.6.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.8. Quadratic programming methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.8">acm:G.1.6.8</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'8 = _prefixId.prefix "G.1.6.8"
    /// <summary>
    ///   <para>rdfs:label : G.1.6.9. Simulated annealing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.6.9">acm:G.1.6.9</a>
    /// </summary>
    let G'_period_'1'_period_'6'_period_'9 = _prefixId.prefix "G.1.6.9"
    /// <summary>
    ///   <para>rdfs:label : G.1.7. Ordinary Differential Equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7">acm:G.1.7</a>
    /// </summary>
    let G'_period_'1'_period_'7 = _prefixId.prefix "G.1.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.0. Boundary value problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.0">acm:G.1.7.0</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'0 = _prefixId.prefix "G.1.7.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.1. Chaotic systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.1">acm:G.1.7.1</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'1 = _prefixId.prefix "G.1.7.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.2. Convergence and stability^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.2">acm:G.1.7.2</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'2 = _prefixId.prefix "G.1.7.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.3. Differential-algebraic equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.3">acm:G.1.7.3</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'3 = _prefixId.prefix "G.1.7.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.4. Error analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.4">acm:G.1.7.4</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'4 = _prefixId.prefix "G.1.7.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.5. Finite difference methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.5">acm:G.1.7.5</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'5 = _prefixId.prefix "G.1.7.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.6. Initial value problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.6">acm:G.1.7.6</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'6 = _prefixId.prefix "G.1.7.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.7. Multistep and multivalue methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.7">acm:G.1.7.7</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'7 = _prefixId.prefix "G.1.7.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.8. One-step methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.8">acm:G.1.7.8</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'8 = _prefixId.prefix "G.1.7.8"
    /// <summary>
    ///   <para>rdfs:label : G.1.7.9. Stiff equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.7.9">acm:G.1.7.9</a>
    /// </summary>
    let G'_period_'1'_period_'7'_period_'9 = _prefixId.prefix "G.1.7.9"
    /// <summary>
    ///   <para>rdfs:label : G.1.8. Partial Differential Equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8">acm:G.1.8</a>
    /// </summary>
    let G'_period_'1'_period_'8 = _prefixId.prefix "G.1.8"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.0. Domain decomposition methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.0">acm:G.1.8.0</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'0 = _prefixId.prefix "G.1.8.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.1. Elliptic equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.1">acm:G.1.8.1</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'1 = _prefixId.prefix "G.1.8.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.10. Parabolic equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.10">acm:G.1.8.10</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'10 = _prefixId.prefix "G.1.8.10"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.11. Spectral methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.11">acm:G.1.8.11</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'11 = _prefixId.prefix "G.1.8.11"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.2. Finite difference methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.2">acm:G.1.8.2</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'2 = _prefixId.prefix "G.1.8.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.3. Finite element methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.3">acm:G.1.8.3</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'3 = _prefixId.prefix "G.1.8.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.4. Finite volume methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.4">acm:G.1.8.4</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'4 = _prefixId.prefix "G.1.8.4"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.5. Hyperbolic equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.5">acm:G.1.8.5</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'5 = _prefixId.prefix "G.1.8.5"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.6. Inverse problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.6">acm:G.1.8.6</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'6 = _prefixId.prefix "G.1.8.6"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.7. Iterative solution techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.7">acm:G.1.8.7</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'7 = _prefixId.prefix "G.1.8.7"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.8. Method of lines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.8">acm:G.1.8.8</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'8 = _prefixId.prefix "G.1.8.8"
    /// <summary>
    ///   <para>rdfs:label : G.1.8.9. Multigrid and multilevel methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.8.9">acm:G.1.8.9</a>
    /// </summary>
    let G'_period_'1'_period_'8'_period_'9 = _prefixId.prefix "G.1.8.9"
    /// <summary>
    ///   <para>rdfs:label : G.1.9. Integral Equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9">acm:G.1.9</a>
    /// </summary>
    let G'_period_'1'_period_'9 = _prefixId.prefix "G.1.9"
    /// <summary>
    ///   <para>rdfs:label : G.1.9.0. Delay equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.0">acm:G.1.9.0</a>
    /// </summary>
    let G'_period_'1'_period_'9'_period_'0 = _prefixId.prefix "G.1.9.0"
    /// <summary>
    ///   <para>rdfs:label : G.1.9.1. Fredholm equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.1">acm:G.1.9.1</a>
    /// </summary>
    let G'_period_'1'_period_'9'_period_'1 = _prefixId.prefix "G.1.9.1"
    /// <summary>
    ///   <para>rdfs:label : G.1.9.2. Integro-differential equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.2">acm:G.1.9.2</a>
    /// </summary>
    let G'_period_'1'_period_'9'_period_'2 = _prefixId.prefix "G.1.9.2"
    /// <summary>
    ///   <para>rdfs:label : G.1.9.3. Volterra equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.9.3">acm:G.1.9.3</a>
    /// </summary>
    let G'_period_'1'_period_'9'_period_'3 = _prefixId.prefix "G.1.9.3"
    /// <summary>
    ///   <para>rdfs:label : G.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.1.m">acm:G.1.m</a>
    /// </summary>
    let G'_period_'1'_period_'m = _prefixId.prefix "G.1.m"
    /// <summary>
    ///   <para>rdfs:label : G.2. DISCRETE MATHEMATICS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2">acm:G.2</a>
    /// </summary>
    let G'_period_'2 = _prefixId.prefix "G.2"
    /// <summary>
    ///   <para>rdfs:label : G.2.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.0">acm:G.2.0</a>
    /// </summary>
    let G'_period_'2'_period_'0 = _prefixId.prefix "G.2.0"
    /// <summary>
    ///   <para>rdfs:label : G.2.1. Combinatorics^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1">acm:G.2.1</a>
    /// </summary>
    let G'_period_'2'_period_'1 = _prefixId.prefix "G.2.1"
    /// <summary>
    ///   <para>rdfs:label : G.2.1.0. Combinatorial algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.0">acm:G.2.1.0</a>
    /// </summary>
    let G'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "G.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : G.2.1.1. Counting problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.1">acm:G.2.1.1</a>
    /// </summary>
    let G'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "G.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : G.2.1.2. Generating functions^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.2">acm:G.2.1.2</a>
    /// </summary>
    let G'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "G.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : G.2.1.3. Permutations and combinations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.3">acm:G.2.1.3</a>
    /// </summary>
    let G'_period_'2'_period_'1'_period_'3 = _prefixId.prefix "G.2.1.3"
    /// <summary>
    ///   <para>rdfs:label : G.2.1.4. Recurrences and difference equations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.1.4">acm:G.2.1.4</a>
    /// </summary>
    let G'_period_'2'_period_'1'_period_'4 = _prefixId.prefix "G.2.1.4"
    /// <summary>
    ///   <para>rdfs:label : G.2.2. Graph Theory^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2">acm:G.2.2</a>
    /// </summary>
    let G'_period_'2'_period_'2 = _prefixId.prefix "G.2.2"
    /// <summary>
    ///   <para>rdfs:label : G.2.2.0. Graph algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.0">acm:G.2.2.0</a>
    /// </summary>
    let G'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "G.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : G.2.2.1. Graph labeling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.1">acm:G.2.2.1</a>
    /// </summary>
    let G'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "G.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : G.2.2.2. Hypergraphs^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.2">acm:G.2.2.2</a>
    /// </summary>
    let G'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "G.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : G.2.2.3. Network problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.3">acm:G.2.2.3</a>
    /// </summary>
    let G'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "G.2.2.3"
    /// <summary>
    ///   <para>rdfs:label : G.2.2.4. Path and circuit problems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.4">acm:G.2.2.4</a>
    /// </summary>
    let G'_period_'2'_period_'2'_period_'4 = _prefixId.prefix "G.2.2.4"
    /// <summary>
    ///   <para>rdfs:label : G.2.2.5. Trees^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.2.5">acm:G.2.2.5</a>
    /// </summary>
    let G'_period_'2'_period_'2'_period_'5 = _prefixId.prefix "G.2.2.5"
    /// <summary>
    ///   <para>rdfs:label : G.2.3. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.3">acm:G.2.3</a>
    /// </summary>
    let G'_period_'2'_period_'3 = _prefixId.prefix "G.2.3"
    /// <summary>
    ///   <para>rdfs:label : G.2.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.2.m">acm:G.2.m</a>
    /// </summary>
    let G'_period_'2'_period_'m = _prefixId.prefix "G.2.m"
    /// <summary>
    ///   <para>rdfs:label : G.3. PROBABILITY AND STATISTICS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3">acm:G.3</a>
    /// </summary>
    let G'_period_'3 = _prefixId.prefix "G.3"
    /// <summary>
    ///   <para>rdfs:label : G.3.0. Contingency table analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.0">acm:G.3.0</a>
    /// </summary>
    let G'_period_'3'_period_'0 = _prefixId.prefix "G.3.0"
    /// <summary>
    ///   <para>rdfs:label : G.3.1. Correlation and regression analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.1">acm:G.3.1</a>
    /// </summary>
    let G'_period_'3'_period_'1 = _prefixId.prefix "G.3.1"
    /// <summary>
    ///   <para>rdfs:label : G.3.10. Reliability and life testing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.10">acm:G.3.10</a>
    /// </summary>
    let G'_period_'3'_period_'10 = _prefixId.prefix "G.3.10"
    /// <summary>
    ///   <para>rdfs:label : G.3.11. Renewal theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.11">acm:G.3.11</a>
    /// </summary>
    let G'_period_'3'_period_'11 = _prefixId.prefix "G.3.11"
    /// <summary>
    ///   <para>rdfs:label : G.3.12. Robust regression^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.12">acm:G.3.12</a>
    /// </summary>
    let G'_period_'3'_period_'12 = _prefixId.prefix "G.3.12"
    /// <summary>
    ///   <para>rdfs:label : G.3.13. Statistical computing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.13">acm:G.3.13</a>
    /// </summary>
    let G'_period_'3'_period_'13 = _prefixId.prefix "G.3.13"
    /// <summary>
    ///   <para>rdfs:label : G.3.14. Statistical software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.14">acm:G.3.14</a>
    /// </summary>
    let G'_period_'3'_period_'14 = _prefixId.prefix "G.3.14"
    /// <summary>
    ///   <para>rdfs:label : G.3.15. Stochastic processes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.15">acm:G.3.15</a>
    /// </summary>
    let G'_period_'3'_period_'15 = _prefixId.prefix "G.3.15"
    /// <summary>
    ///   <para>rdfs:label : G.3.16. Survival analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.16">acm:G.3.16</a>
    /// </summary>
    let G'_period_'3'_period_'16 = _prefixId.prefix "G.3.16"
    /// <summary>
    ///   <para>rdfs:label : G.3.17. Time series analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.17">acm:G.3.17</a>
    /// </summary>
    let G'_period_'3'_period_'17 = _prefixId.prefix "G.3.17"
    /// <summary>
    ///   <para>rdfs:label : G.3.2. Distribution functions^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.2">acm:G.3.2</a>
    /// </summary>
    let G'_period_'3'_period_'2 = _prefixId.prefix "G.3.2"
    /// <summary>
    ///   <para>rdfs:label : G.3.3. Experimental design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.3">acm:G.3.3</a>
    /// </summary>
    let G'_period_'3'_period_'3 = _prefixId.prefix "G.3.3"
    /// <summary>
    ///   <para>rdfs:label : G.3.4. Markov processes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.4">acm:G.3.4</a>
    /// </summary>
    let G'_period_'3'_period_'4 = _prefixId.prefix "G.3.4"
    /// <summary>
    ///   <para>rdfs:label : G.3.5. Multivariate statistics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.5">acm:G.3.5</a>
    /// </summary>
    let G'_period_'3'_period_'5 = _prefixId.prefix "G.3.5"
    /// <summary>
    ///   <para>rdfs:label : G.3.6. Nonparametric statistics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.6">acm:G.3.6</a>
    /// </summary>
    let G'_period_'3'_period_'6 = _prefixId.prefix "G.3.6"
    /// <summary>
    ///   <para>rdfs:label : G.3.7. Probabilistic algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.7">acm:G.3.7</a>
    /// </summary>
    let G'_period_'3'_period_'7 = _prefixId.prefix "G.3.7"
    /// <summary>
    ///   <para>rdfs:label : G.3.8. Queueing theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.8">acm:G.3.8</a>
    /// </summary>
    let G'_period_'3'_period_'8 = _prefixId.prefix "G.3.8"
    /// <summary>
    ///   <para>rdfs:label : G.3.9. Random number generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.3.9">acm:G.3.9</a>
    /// </summary>
    let G'_period_'3'_period_'9 = _prefixId.prefix "G.3.9"
    /// <summary>
    ///   <para>rdfs:label : G.4. MATHEMATICAL SOFTWARE^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4">acm:G.4</a>
    /// </summary>
    let G'_period_'4 = _prefixId.prefix "G.4"
    /// <summary>
    ///   <para>rdfs:label : G.4.0. Algorithm design and analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.0">acm:G.4.0</a>
    /// </summary>
    let G'_period_'4'_period_'0 = _prefixId.prefix "G.4.0"
    /// <summary>
    ///   <para>rdfs:label : G.4.1. Certification and testing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.1">acm:G.4.1</a>
    /// </summary>
    let G'_period_'4'_period_'1 = _prefixId.prefix "G.4.1"
    /// <summary>
    ///   <para>rdfs:label : G.4.2. Documentation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.2">acm:G.4.2</a>
    /// </summary>
    let G'_period_'4'_period_'2 = _prefixId.prefix "G.4.2"
    /// <summary>
    ///   <para>rdfs:label : G.4.3. Efficiency^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.3">acm:G.4.3</a>
    /// </summary>
    let G'_period_'4'_period_'3 = _prefixId.prefix "G.4.3"
    /// <summary>
    ///   <para>rdfs:label : G.4.4. Parallel and vector implementations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.4">acm:G.4.4</a>
    /// </summary>
    let G'_period_'4'_period_'4 = _prefixId.prefix "G.4.4"
    /// <summary>
    ///   <para>rdfs:label : G.4.5. Portability^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.5">acm:G.4.5</a>
    /// </summary>
    let G'_period_'4'_period_'5 = _prefixId.prefix "G.4.5"
    /// <summary>
    ///   <para>rdfs:label : G.4.6. Reliability and robustness^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.6">acm:G.4.6</a>
    /// </summary>
    let G'_period_'4'_period_'6 = _prefixId.prefix "G.4.6"
    /// <summary>
    ///   <para>rdfs:label : G.4.7. User interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.7">acm:G.4.7</a>
    /// </summary>
    let G'_period_'4'_period_'7 = _prefixId.prefix "G.4.7"
    /// <summary>
    ///   <para>rdfs:label : G.4.8. Verification^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.4.8">acm:G.4.8</a>
    /// </summary>
    let G'_period_'4'_period_'8 = _prefixId.prefix "G.4.8"
    /// <summary>
    ///   <para>rdfs:label : G.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.m">acm:G.m</a>
    /// </summary>
    let G'_period_'m = _prefixId.prefix "G.m"
    /// <summary>
    ///   <para>rdfs:label : G.m.0. Queueing theory^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#G.m.0">acm:G.m.0</a>
    /// </summary>
    let G'_period_'m'_period_'0 = _prefixId.prefix "G.m.0"
    /// <summary>
    ///   <para>rdfs:label : H. Information Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H">acm:H</a>
    /// </summary>
    let H = _prefixId.prefix "H"
    /// <summary>
    ///   <para>rdfs:label : H.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.0">acm:H.0</a>
    /// </summary>
    let H'_period_'0 = _prefixId.prefix "H.0"
    /// <summary>
    ///   <para>rdfs:label : H.1. MODELS AND PRINCIPLES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1">acm:H.1</a>
    /// </summary>
    let H'_period_'1 = _prefixId.prefix "H.1"
    /// <summary>
    ///   <para>rdfs:label : H.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.0">acm:H.1.0</a>
    /// </summary>
    let H'_period_'1'_period_'0 = _prefixId.prefix "H.1.0"
    /// <summary>
    ///   <para>rdfs:label : H.1.1. Systems and Information Theory^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1">acm:H.1.1</a>
    /// </summary>
    let H'_period_'1'_period_'1 = _prefixId.prefix "H.1.1"
    /// <summary>
    ///   <para>rdfs:label : H.1.1.0. General systems theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.0">acm:H.1.1.0</a>
    /// </summary>
    let H'_period_'1'_period_'1'_period_'0 = _prefixId.prefix "H.1.1.0"
    /// <summary>
    ///   <para>rdfs:label : H.1.1.1. Information theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.1">acm:H.1.1.1</a>
    /// </summary>
    let H'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "H.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : H.1.1.2. Value of information^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.1.2">acm:H.1.1.2</a>
    /// </summary>
    let H'_period_'1'_period_'1'_period_'2 = _prefixId.prefix "H.1.1.2"
    /// <summary>
    ///   <para>rdfs:label : H.1.2. User/Machine Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2">acm:H.1.2</a>
    /// </summary>
    let H'_period_'1'_period_'2 = _prefixId.prefix "H.1.2"
    /// <summary>
    ///   <para>rdfs:label : H.1.2.0. Human factors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.0">acm:H.1.2.0</a>
    /// </summary>
    let H'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "H.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : H.1.2.1. Human information processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.1">acm:H.1.2.1</a>
    /// </summary>
    let H'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "H.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : H.1.2.2. Software psychology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.2.2">acm:H.1.2.2</a>
    /// </summary>
    let H'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "H.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : H.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.1.m">acm:H.1.m</a>
    /// </summary>
    let H'_period_'1'_period_'m = _prefixId.prefix "H.1.m"
    /// <summary>
    ///   <para>rdfs:label : H.2. DATABASE MANAGEMENT^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.5.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2">acm:H.2</a>
    /// </summary>
    let H'_period_'2 = _prefixId.prefix "H.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0">acm:H.2.0</a>
    /// </summary>
    let H'_period_'2'_period_'0 = _prefixId.prefix "H.2.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.0.0. Security, integrity, and protection^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.0.0">acm:H.2.0.0</a>
    /// </summary>
    let H'_period_'2'_period_'0'_period_'0 = _prefixId.prefix "H.2.0.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.1. Logical Design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1">acm:H.2.1</a>
    /// </summary>
    let H'_period_'2'_period_'1 = _prefixId.prefix "H.2.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.1.0. Data models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.0">acm:H.2.1.0</a>
    /// </summary>
    let H'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "H.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.1.1. Normal forms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.1">acm:H.2.1.1</a>
    /// </summary>
    let H'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "H.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.1.2. Schema and subschema^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.1.2">acm:H.2.1.2</a>
    /// </summary>
    let H'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "H.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.2. Physical Design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2">acm:H.2.2</a>
    /// </summary>
    let H'_period_'2'_period_'2 = _prefixId.prefix "H.2.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.2.0. Access methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.0">acm:H.2.2.0</a>
    /// </summary>
    let H'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "H.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.2.1. Deadlock avoidance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.1">acm:H.2.2.1</a>
    /// </summary>
    let H'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "H.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.2.2. Recovery and restart^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.2.2">acm:H.2.2.2</a>
    /// </summary>
    let H'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "H.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.3. Languages^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3">acm:H.2.3</a>
    /// </summary>
    let H'_period_'2'_period_'3 = _prefixId.prefix "H.2.3"
    /// <summary>
    ///   <para>rdfs:label : H.2.3.0. Data description languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.0">acm:H.2.3.0</a>
    /// </summary>
    let H'_period_'2'_period_'3'_period_'0 = _prefixId.prefix "H.2.3.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.3.1. Data manipulation languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.1">acm:H.2.3.1</a>
    /// </summary>
    let H'_period_'2'_period_'3'_period_'1 = _prefixId.prefix "H.2.3.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.3.2. Database programming languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.2">acm:H.2.3.2</a>
    /// </summary>
    let H'_period_'2'_period_'3'_period_'2 = _prefixId.prefix "H.2.3.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.3.3. Query languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.3">acm:H.2.3.3</a>
    /// </summary>
    let H'_period_'2'_period_'3'_period_'3 = _prefixId.prefix "H.2.3.3"
    /// <summary>
    ///   <para>rdfs:label : H.2.3.4. Report writers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.3.4">acm:H.2.3.4</a>
    /// </summary>
    let H'_period_'2'_period_'3'_period_'4 = _prefixId.prefix "H.2.3.4"
    /// <summary>
    ///   <para>rdfs:label : H.2.4. Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4">acm:H.2.4</a>
    /// </summary>
    let H'_period_'2'_period_'4 = _prefixId.prefix "H.2.4"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.0. Concurrency^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.0">acm:H.2.4.0</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'0 = _prefixId.prefix "H.2.4.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.1. Distributed databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.1">acm:H.2.4.1</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'1 = _prefixId.prefix "H.2.4.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.2. Multimedia databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.2">acm:H.2.4.2</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'2 = _prefixId.prefix "H.2.4.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.3. Object-oriented databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.3">acm:H.2.4.3</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'3 = _prefixId.prefix "H.2.4.3"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.4. Parallel databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.4">acm:H.2.4.4</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'4 = _prefixId.prefix "H.2.4.4"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.5. Query processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.5">acm:H.2.4.5</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'5 = _prefixId.prefix "H.2.4.5"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.6. Relational databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.6">acm:H.2.4.6</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'6 = _prefixId.prefix "H.2.4.6"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.7. Rule-based databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.7">acm:H.2.4.7</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'7 = _prefixId.prefix "H.2.4.7"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.8. Textual databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.8">acm:H.2.4.8</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'8 = _prefixId.prefix "H.2.4.8"
    /// <summary>
    ///   <para>rdfs:label : H.2.4.9. Transaction processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.4.9">acm:H.2.4.9</a>
    /// </summary>
    let H'_period_'2'_period_'4'_period_'9 = _prefixId.prefix "H.2.4.9"
    /// <summary>
    ///   <para>rdfs:label : H.2.5. Heterogeneous Databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5">acm:H.2.5</a>
    /// </summary>
    let H'_period_'2'_period_'5 = _prefixId.prefix "H.2.5"
    /// <summary>
    ///   <para>rdfs:label : H.2.5.0. Data translation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.0">acm:H.2.5.0</a>
    /// </summary>
    let H'_period_'2'_period_'5'_period_'0 = _prefixId.prefix "H.2.5.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.5.1. Program translation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.5.1">acm:H.2.5.1</a>
    /// </summary>
    let H'_period_'2'_period_'5'_period_'1 = _prefixId.prefix "H.2.5.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.6. Database Machines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.6">acm:H.2.6</a>
    /// </summary>
    let H'_period_'2'_period_'6 = _prefixId.prefix "H.2.6"
    /// <summary>
    ///   <para>rdfs:label : H.2.7. Database Administration^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7">acm:H.2.7</a>
    /// </summary>
    let H'_period_'2'_period_'7 = _prefixId.prefix "H.2.7"
    /// <summary>
    ///   <para>rdfs:label : H.2.7.0. Data dictionary/directory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.0">acm:H.2.7.0</a>
    /// </summary>
    let H'_period_'2'_period_'7'_period_'0 = _prefixId.prefix "H.2.7.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.7.1. Data warehouse and repository^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.1">acm:H.2.7.1</a>
    /// </summary>
    let H'_period_'2'_period_'7'_period_'1 = _prefixId.prefix "H.2.7.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.7.2. Logging and recovery^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.2">acm:H.2.7.2</a>
    /// </summary>
    let H'_period_'2'_period_'7'_period_'2 = _prefixId.prefix "H.2.7.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.7.3. Security, integrity, and protection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.7.3">acm:H.2.7.3</a>
    /// </summary>
    let H'_period_'2'_period_'7'_period_'3 = _prefixId.prefix "H.2.7.3"
    /// <summary>
    ///   <para>rdfs:label : H.2.8. Database Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8">acm:H.2.8</a>
    /// </summary>
    let H'_period_'2'_period_'8 = _prefixId.prefix "H.2.8"
    /// <summary>
    ///   <para>rdfs:label : H.2.8.0. Data mining^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.0">acm:H.2.8.0</a>
    /// </summary>
    let H'_period_'2'_period_'8'_period_'0 = _prefixId.prefix "H.2.8.0"
    /// <summary>
    ///   <para>rdfs:label : H.2.8.1. Image databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.1">acm:H.2.8.1</a>
    /// </summary>
    let H'_period_'2'_period_'8'_period_'1 = _prefixId.prefix "H.2.8.1"
    /// <summary>
    ///   <para>rdfs:label : H.2.8.2. Scientific databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.2">acm:H.2.8.2</a>
    /// </summary>
    let H'_period_'2'_period_'8'_period_'2 = _prefixId.prefix "H.2.8.2"
    /// <summary>
    ///   <para>rdfs:label : H.2.8.3. Spatial databases and GIS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.3">acm:H.2.8.3</a>
    /// </summary>
    let H'_period_'2'_period_'8'_period_'3 = _prefixId.prefix "H.2.8.3"
    /// <summary>
    ///   <para>rdfs:label : H.2.8.4. Statistical databases^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.8.4">acm:H.2.8.4</a>
    /// </summary>
    let H'_period_'2'_period_'8'_period_'4 = _prefixId.prefix "H.2.8.4"
    /// <summary>
    ///   <para>rdfs:label : H.2.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.2.m">acm:H.2.m</a>
    /// </summary>
    let H'_period_'2'_period_'m = _prefixId.prefix "H.2.m"
    /// <summary>
    ///   <para>rdfs:label : H.3. INFORMATION STORAGE AND RETRIEVAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3">acm:H.3</a>
    /// </summary>
    let H'_period_'3 = _prefixId.prefix "H.3"
    /// <summary>
    ///   <para>rdfs:label : H.3.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.0">acm:H.3.0</a>
    /// </summary>
    let H'_period_'3'_period_'0 = _prefixId.prefix "H.3.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.1. Content Analysis and Indexing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1">acm:H.3.1</a>
    /// </summary>
    let H'_period_'3'_period_'1 = _prefixId.prefix "H.3.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.1.0. Abstracting methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.0">acm:H.3.1.0</a>
    /// </summary>
    let H'_period_'3'_period_'1'_period_'0 = _prefixId.prefix "H.3.1.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.1.1. Dictionaries^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.1">acm:H.3.1.1</a>
    /// </summary>
    let H'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "H.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.1.2. Indexing methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.2">acm:H.3.1.2</a>
    /// </summary>
    let H'_period_'3'_period_'1'_period_'2 = _prefixId.prefix "H.3.1.2"
    /// <summary>
    ///   <para>rdfs:label : H.3.1.3. Linguistic processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.3">acm:H.3.1.3</a>
    /// </summary>
    let H'_period_'3'_period_'1'_period_'3 = _prefixId.prefix "H.3.1.3"
    /// <summary>
    ///   <para>rdfs:label : H.3.1.4. Thesauruses^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.1.4">acm:H.3.1.4</a>
    /// </summary>
    let H'_period_'3'_period_'1'_period_'4 = _prefixId.prefix "H.3.1.4"
    /// <summary>
    ///   <para>rdfs:label : H.3.2. Information Storage^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2">acm:H.3.2</a>
    /// </summary>
    let H'_period_'3'_period_'2 = _prefixId.prefix "H.3.2"
    /// <summary>
    ///   <para>rdfs:label : H.3.2.0. File organization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.0">acm:H.3.2.0</a>
    /// </summary>
    let H'_period_'3'_period_'2'_period_'0 = _prefixId.prefix "H.3.2.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.2.1. Record classification^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.2.1">acm:H.3.2.1</a>
    /// </summary>
    let H'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "H.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.3. Information Search and Retrieval^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3">acm:H.3.3</a>
    /// </summary>
    let H'_period_'3'_period_'3 = _prefixId.prefix "H.3.3"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.0. Clustering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.0">acm:H.3.3.0</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'0 = _prefixId.prefix "H.3.3.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.1. Information filtering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.1">acm:H.3.3.1</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'1 = _prefixId.prefix "H.3.3.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.2. Query formulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.2">acm:H.3.3.2</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'2 = _prefixId.prefix "H.3.3.2"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.3. Relevance feedback^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.3">acm:H.3.3.3</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'3 = _prefixId.prefix "H.3.3.3"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.4. Retrieval models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.4">acm:H.3.3.4</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'4 = _prefixId.prefix "H.3.3.4"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.5. Search process^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.5">acm:H.3.3.5</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'5 = _prefixId.prefix "H.3.3.5"
    /// <summary>
    ///   <para>rdfs:label : H.3.3.6. Selection process^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.3.6">acm:H.3.3.6</a>
    /// </summary>
    let H'_period_'3'_period_'3'_period_'6 = _prefixId.prefix "H.3.3.6"
    /// <summary>
    ///   <para>rdfs:label : H.3.4. Systems and Software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4">acm:H.3.4</a>
    /// </summary>
    let H'_period_'3'_period_'4 = _prefixId.prefix "H.3.4"
    /// <summary>
    ///   <para>rdfs:label : H.3.4.0. Current awareness systems^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.0">acm:H.3.4.0</a>
    /// </summary>
    let H'_period_'3'_period_'4'_period_'0 = _prefixId.prefix "H.3.4.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.4.1. Distributed systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.1">acm:H.3.4.1</a>
    /// </summary>
    let H'_period_'3'_period_'4'_period_'1 = _prefixId.prefix "H.3.4.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.4.2. Information networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.2">acm:H.3.4.2</a>
    /// </summary>
    let H'_period_'3'_period_'4'_period_'2 = _prefixId.prefix "H.3.4.2"
    /// <summary>
    ///   <para>rdfs:label : H.3.4.3. Performance evaluation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.3">acm:H.3.4.3</a>
    /// </summary>
    let H'_period_'3'_period_'4'_period_'3 = _prefixId.prefix "H.3.4.3"
    /// <summary>
    ///   <para>rdfs:label : H.3.4.4. Question-answering systems^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.4">acm:H.3.4.4</a>
    /// </summary>
    let H'_period_'3'_period_'4'_period_'4 = _prefixId.prefix "H.3.4.4"
    /// <summary>
    ///   <para>rdfs:label : H.3.4.5. User profiles and alert services^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.4.5">acm:H.3.4.5</a>
    /// </summary>
    let H'_period_'3'_period_'4'_period_'5 = _prefixId.prefix "H.3.4.5"
    /// <summary>
    ///   <para>rdfs:label : H.3.5. Online Information Services^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5">acm:H.3.5</a>
    /// </summary>
    let H'_period_'3'_period_'5 = _prefixId.prefix "H.3.5"
    /// <summary>
    ///   <para>rdfs:label : H.3.5.0. Commercial services^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.0">acm:H.3.5.0</a>
    /// </summary>
    let H'_period_'3'_period_'5'_period_'0 = _prefixId.prefix "H.3.5.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.5.1. Data sharing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.1">acm:H.3.5.1</a>
    /// </summary>
    let H'_period_'3'_period_'5'_period_'1 = _prefixId.prefix "H.3.5.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.5.2. Web-based services^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.5.2">acm:H.3.5.2</a>
    /// </summary>
    let H'_period_'3'_period_'5'_period_'2 = _prefixId.prefix "H.3.5.2"
    /// <summary>
    ///   <para>rdfs:label : H.3.6. Library Automation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6">acm:H.3.6</a>
    /// </summary>
    let H'_period_'3'_period_'6 = _prefixId.prefix "H.3.6"
    /// <summary>
    ///   <para>rdfs:label : H.3.6.0. Large text archives^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.6.0">acm:H.3.6.0</a>
    /// </summary>
    let H'_period_'3'_period_'6'_period_'0 = _prefixId.prefix "H.3.6.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.7. Digital Libraries^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7">acm:H.3.7</a>
    /// </summary>
    let H'_period_'3'_period_'7 = _prefixId.prefix "H.3.7"
    /// <summary>
    ///   <para>rdfs:label : H.3.7.0. Collection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.0">acm:H.3.7.0</a>
    /// </summary>
    let H'_period_'3'_period_'7'_period_'0 = _prefixId.prefix "H.3.7.0"
    /// <summary>
    ///   <para>rdfs:label : H.3.7.1. Dissemination^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.1">acm:H.3.7.1</a>
    /// </summary>
    let H'_period_'3'_period_'7'_period_'1 = _prefixId.prefix "H.3.7.1"
    /// <summary>
    ///   <para>rdfs:label : H.3.7.2. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.2">acm:H.3.7.2</a>
    /// </summary>
    let H'_period_'3'_period_'7'_period_'2 = _prefixId.prefix "H.3.7.2"
    /// <summary>
    ///   <para>rdfs:label : H.3.7.3. Systems issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.3">acm:H.3.7.3</a>
    /// </summary>
    let H'_period_'3'_period_'7'_period_'3 = _prefixId.prefix "H.3.7.3"
    /// <summary>
    ///   <para>rdfs:label : H.3.7.4. User issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.7.4">acm:H.3.7.4</a>
    /// </summary>
    let H'_period_'3'_period_'7'_period_'4 = _prefixId.prefix "H.3.7.4"
    /// <summary>
    ///   <para>rdfs:label : H.3.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.3.m">acm:H.3.m</a>
    /// </summary>
    let H'_period_'3'_period_'m = _prefixId.prefix "H.3.m"
    /// <summary>
    ///   <para>rdfs:label : H.4. INFORMATION SYSTEMS APPLICATIONS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4">acm:H.4</a>
    /// </summary>
    let H'_period_'4 = _prefixId.prefix "H.4"
    /// <summary>
    ///   <para>rdfs:label : H.4.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.0">acm:H.4.0</a>
    /// </summary>
    let H'_period_'4'_period_'0 = _prefixId.prefix "H.4.0"
    /// <summary>
    ///   <para>rdfs:label : H.4.1. Office Automation^^xsd:string</para>
    ///   <para>rdfs:comment : See also #I.7.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1">acm:H.4.1</a>
    /// </summary>
    let H'_period_'4'_period_'1 = _prefixId.prefix "H.4.1"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.0. Desktop publishing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.0">acm:H.4.1.0</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'0 = _prefixId.prefix "H.4.1.0"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.1. Equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.1">acm:H.4.1.1</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'1 = _prefixId.prefix "H.4.1.1"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.2. Groupware^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.2">acm:H.4.1.2</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'2 = _prefixId.prefix "H.4.1.2"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.3. Spreadsheets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.3">acm:H.4.1.3</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'3 = _prefixId.prefix "H.4.1.3"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.4. Time management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.4">acm:H.4.1.4</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'4 = _prefixId.prefix "H.4.1.4"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.5. Word processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.5">acm:H.4.1.5</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'5 = _prefixId.prefix "H.4.1.5"
    /// <summary>
    ///   <para>rdfs:label : H.4.1.6. Workflow management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.1.6">acm:H.4.1.6</a>
    /// </summary>
    let H'_period_'4'_period_'1'_period_'6 = _prefixId.prefix "H.4.1.6"
    /// <summary>
    ///   <para>rdfs:label : H.4.2. Types of Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2">acm:H.4.2</a>
    /// </summary>
    let H'_period_'4'_period_'2 = _prefixId.prefix "H.4.2"
    /// <summary>
    ///   <para>rdfs:label : H.4.2.0. Decision support^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.0">acm:H.4.2.0</a>
    /// </summary>
    let H'_period_'4'_period_'2'_period_'0 = _prefixId.prefix "H.4.2.0"
    /// <summary>
    ///   <para>rdfs:label : H.4.2.1. Logistics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.2.1">acm:H.4.2.1</a>
    /// </summary>
    let H'_period_'4'_period_'2'_period_'1 = _prefixId.prefix "H.4.2.1"
    /// <summary>
    ///   <para>rdfs:label : H.4.3. Communications Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3">acm:H.4.3</a>
    /// </summary>
    let H'_period_'4'_period_'3 = _prefixId.prefix "H.4.3"
    /// <summary>
    ///   <para>rdfs:label : H.4.3.0. Bulletin boards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.0">acm:H.4.3.0</a>
    /// </summary>
    let H'_period_'4'_period_'3'_period_'0 = _prefixId.prefix "H.4.3.0"
    /// <summary>
    ///   <para>rdfs:label : H.4.3.1. Computer conferencing, teleconferencing, and videoconferencing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.1">acm:H.4.3.1</a>
    /// </summary>
    let H'_period_'4'_period_'3'_period_'1 = _prefixId.prefix "H.4.3.1"
    /// <summary>
    ///   <para>rdfs:label : H.4.3.2. Electronic mail^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.2">acm:H.4.3.2</a>
    /// </summary>
    let H'_period_'4'_period_'3'_period_'2 = _prefixId.prefix "H.4.3.2"
    /// <summary>
    ///   <para>rdfs:label : H.4.3.3. Information browsers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.3">acm:H.4.3.3</a>
    /// </summary>
    let H'_period_'4'_period_'3'_period_'3 = _prefixId.prefix "H.4.3.3"
    /// <summary>
    ///   <para>rdfs:label : H.4.3.4. Videotex^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.3.4">acm:H.4.3.4</a>
    /// </summary>
    let H'_period_'4'_period_'3'_period_'4 = _prefixId.prefix "H.4.3.4"
    /// <summary>
    ///   <para>rdfs:label : H.4.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.4.m">acm:H.4.m</a>
    /// </summary>
    let H'_period_'4'_period_'m = _prefixId.prefix "H.4.m"
    /// <summary>
    ///   <para>rdfs:label : H.5. INFORMATION INTERFACES AND PRESENTATION^^xsd:string</para>
    ///   <para>rdfs:comment : See also #I.7.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5">acm:H.5</a>
    /// </summary>
    let H'_period_'5 = _prefixId.prefix "H.5"
    /// <summary>
    ///   <para>rdfs:label : H.5.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.0">acm:H.5.0</a>
    /// </summary>
    let H'_period_'5'_period_'0 = _prefixId.prefix "H.5.0"
    /// <summary>
    ///   <para>rdfs:label : H.5.1. Multimedia Information Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1">acm:H.5.1</a>
    /// </summary>
    let H'_period_'5'_period_'1 = _prefixId.prefix "H.5.1"
    /// <summary>
    ///   <para>rdfs:label : H.5.1.0. Animations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.0">acm:H.5.1.0</a>
    /// </summary>
    let H'_period_'5'_period_'1'_period_'0 = _prefixId.prefix "H.5.1.0"
    /// <summary>
    ///   <para>rdfs:label : H.5.1.1. Artificial, augmented, and virtual realities^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.1">acm:H.5.1.1</a>
    /// </summary>
    let H'_period_'5'_period_'1'_period_'1 = _prefixId.prefix "H.5.1.1"
    /// <summary>
    ///   <para>rdfs:label : H.5.1.2. Audio input/output^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.2">acm:H.5.1.2</a>
    /// </summary>
    let H'_period_'5'_period_'1'_period_'2 = _prefixId.prefix "H.5.1.2"
    /// <summary>
    ///   <para>rdfs:label : H.5.1.3. Evaluation/methodology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.3">acm:H.5.1.3</a>
    /// </summary>
    let H'_period_'5'_period_'1'_period_'3 = _prefixId.prefix "H.5.1.3"
    /// <summary>
    ///   <para>rdfs:label : H.5.1.4. Hypertext navigation and maps^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.4">acm:H.5.1.4</a>
    /// </summary>
    let H'_period_'5'_period_'1'_period_'4 = _prefixId.prefix "H.5.1.4"
    /// <summary>
    ///   <para>rdfs:label : H.5.1.5. Video^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.1.5">acm:H.5.1.5</a>
    /// </summary>
    let H'_period_'5'_period_'1'_period_'5 = _prefixId.prefix "H.5.1.5"
    /// <summary>
    ///   <para>rdfs:label : H.5.2. User Interfaces^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.2.2, #H.1.2, #I.3.6.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2">acm:H.5.2</a>
    /// </summary>
    let H'_period_'5'_period_'2 = _prefixId.prefix "H.5.2"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.0. Auditory feedback^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.0">acm:H.5.2.0</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'0 = _prefixId.prefix "H.5.2.0"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.1. Benchmarking^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.1">acm:H.5.2.1</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'1 = _prefixId.prefix "H.5.2.1"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.10. Screen design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.10">acm:H.5.2.10</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'10 = _prefixId.prefix "H.5.2.10"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.11. Standardization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.11">acm:H.5.2.11</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'11 = _prefixId.prefix "H.5.2.11"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.12. Style guides^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.12">acm:H.5.2.12</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'12 = _prefixId.prefix "H.5.2.12"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.13. Theory and methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.13">acm:H.5.2.13</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'13 = _prefixId.prefix "H.5.2.13"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.14. Training, help, and documentation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.14">acm:H.5.2.14</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'14 = _prefixId.prefix "H.5.2.14"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.15. User-centered design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.15">acm:H.5.2.15</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'15 = _prefixId.prefix "H.5.2.15"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.16. User interface management systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.16">acm:H.5.2.16</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'16 = _prefixId.prefix "H.5.2.16"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.17. Voice I/O^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.17">acm:H.5.2.17</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'17 = _prefixId.prefix "H.5.2.17"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.18. Windowing systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.18">acm:H.5.2.18</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'18 = _prefixId.prefix "H.5.2.18"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.2. Ergonomics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.2">acm:H.5.2.2</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'2 = _prefixId.prefix "H.5.2.2"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.3. Evaluation/methodology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.3">acm:H.5.2.3</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'3 = _prefixId.prefix "H.5.2.3"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.4. Graphical user interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.4">acm:H.5.2.4</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'4 = _prefixId.prefix "H.5.2.4"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.5. Haptic I/O^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.5">acm:H.5.2.5</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'5 = _prefixId.prefix "H.5.2.5"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.6. Input devices and strategies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.6">acm:H.5.2.6</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'6 = _prefixId.prefix "H.5.2.6"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.7. Interaction styles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.7">acm:H.5.2.7</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'7 = _prefixId.prefix "H.5.2.7"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.8. Natural language^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.8">acm:H.5.2.8</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'8 = _prefixId.prefix "H.5.2.8"
    /// <summary>
    ///   <para>rdfs:label : H.5.2.9. Prototyping^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.2.9">acm:H.5.2.9</a>
    /// </summary>
    let H'_period_'5'_period_'2'_period_'9 = _prefixId.prefix "H.5.2.9"
    /// <summary>
    ///   <para>rdfs:label : H.5.3. Group and Organization Interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3">acm:H.5.3</a>
    /// </summary>
    let H'_period_'5'_period_'3 = _prefixId.prefix "H.5.3"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.0. Asynchronous interaction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.0">acm:H.5.3.0</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'0 = _prefixId.prefix "H.5.3.0"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.1. Collaborative computing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.1">acm:H.5.3.1</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'1 = _prefixId.prefix "H.5.3.1"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.2. Computer-supported cooperative work^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.2">acm:H.5.3.2</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'2 = _prefixId.prefix "H.5.3.2"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.3. Evaluation/methodology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.3">acm:H.5.3.3</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'3 = _prefixId.prefix "H.5.3.3"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.4. Organizational design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.4">acm:H.5.3.4</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'4 = _prefixId.prefix "H.5.3.4"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.5. Synchronous interaction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.5">acm:H.5.3.5</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'5 = _prefixId.prefix "H.5.3.5"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.6. Theory and models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.6">acm:H.5.3.6</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'6 = _prefixId.prefix "H.5.3.6"
    /// <summary>
    ///   <para>rdfs:label : H.5.3.7. Web-based interaction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.3.7">acm:H.5.3.7</a>
    /// </summary>
    let H'_period_'5'_period_'3'_period_'7 = _prefixId.prefix "H.5.3.7"
    /// <summary>
    ///   <para>rdfs:label : H.5.4. Hypertext/Hypermedia^^xsd:string</para>
    ///   <para>rdfs:comment : See also #I.7, #J.7.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4">acm:H.5.4</a>
    /// </summary>
    let H'_period_'5'_period_'4 = _prefixId.prefix "H.5.4"
    /// <summary>
    ///   <para>rdfs:label : H.5.4.0. Architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.0">acm:H.5.4.0</a>
    /// </summary>
    let H'_period_'5'_period_'4'_period_'0 = _prefixId.prefix "H.5.4.0"
    /// <summary>
    ///   <para>rdfs:label : H.5.4.1. Navigation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.1">acm:H.5.4.1</a>
    /// </summary>
    let H'_period_'5'_period_'4'_period_'1 = _prefixId.prefix "H.5.4.1"
    /// <summary>
    ///   <para>rdfs:label : H.5.4.2. Theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.2">acm:H.5.4.2</a>
    /// </summary>
    let H'_period_'5'_period_'4'_period_'2 = _prefixId.prefix "H.5.4.2"
    /// <summary>
    ///   <para>rdfs:label : H.5.4.3. User issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.4.3">acm:H.5.4.3</a>
    /// </summary>
    let H'_period_'5'_period_'4'_period_'3 = _prefixId.prefix "H.5.4.3"
    /// <summary>
    ///   <para>rdfs:label : H.5.5. Sound and Music Computing^^xsd:string</para>
    ///   <para>rdfs:comment : See also #J.5.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5">acm:H.5.5</a>
    /// </summary>
    let H'_period_'5'_period_'5 = _prefixId.prefix "H.5.5"
    /// <summary>
    ///   <para>rdfs:label : H.5.5.0. Methodologies and techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.0">acm:H.5.5.0</a>
    /// </summary>
    let H'_period_'5'_period_'5'_period_'0 = _prefixId.prefix "H.5.5.0"
    /// <summary>
    ///   <para>rdfs:label : H.5.5.1. Modeling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.1">acm:H.5.5.1</a>
    /// </summary>
    let H'_period_'5'_period_'5'_period_'1 = _prefixId.prefix "H.5.5.1"
    /// <summary>
    ///   <para>rdfs:label : H.5.5.2. Signal analysis, synthesis, and processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.2">acm:H.5.5.2</a>
    /// </summary>
    let H'_period_'5'_period_'5'_period_'2 = _prefixId.prefix "H.5.5.2"
    /// <summary>
    ///   <para>rdfs:label : H.5.5.3. Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.5.3">acm:H.5.5.3</a>
    /// </summary>
    let H'_period_'5'_period_'5'_period_'3 = _prefixId.prefix "H.5.5.3"
    /// <summary>
    ///   <para>rdfs:label : H.5.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.5.m">acm:H.5.m</a>
    /// </summary>
    let H'_period_'5'_period_'m = _prefixId.prefix "H.5.m"
    /// <summary>
    ///   <para>rdfs:label : H.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#H.m">acm:H.m</a>
    /// </summary>
    let H'_period_'m = _prefixId.prefix "H.m"
    /// <summary>
    ///   <para>rdfs:label : I. Computing Methodologies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I">acm:I</a>
    /// </summary>
    let I = _prefixId.prefix "I"
    /// <summary>
    ///   <para>rdfs:label : I.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.0">acm:I.0</a>
    /// </summary>
    let I'_period_'0 = _prefixId.prefix "I.0"
    /// <summary>
    ///   <para>rdfs:label : I.1. SYMBOLIC AND ALGEBRAIC MANIPULATION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1">acm:I.1</a>
    /// </summary>
    let I'_period_'1 = _prefixId.prefix "I.1"
    /// <summary>
    ///   <para>rdfs:label : I.1.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.0">acm:I.1.0</a>
    /// </summary>
    let I'_period_'1'_period_'0 = _prefixId.prefix "I.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.1.1. Expressions and Their Representation^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.1, #E.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1">acm:I.1.1</a>
    /// </summary>
    let I'_period_'1'_period_'1 = _prefixId.prefix "I.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.1.1.0. Representations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.0">acm:I.1.1.0</a>
    /// </summary>
    let I'_period_'1'_period_'1'_period_'0 = _prefixId.prefix "I.1.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.1.1.1. Simplification of expressions^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.1.1">acm:I.1.1.1</a>
    /// </summary>
    let I'_period_'1'_period_'1'_period_'1 = _prefixId.prefix "I.1.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.1.2. Algorithms^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.2.1, #F.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2">acm:I.1.2</a>
    /// </summary>
    let I'_period_'1'_period_'2 = _prefixId.prefix "I.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.1.2.0. Algebraic algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.0">acm:I.1.2.0</a>
    /// </summary>
    let I'_period_'1'_period_'2'_period_'0 = _prefixId.prefix "I.1.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.1.2.1. Analysis of algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.1">acm:I.1.2.1</a>
    /// </summary>
    let I'_period_'1'_period_'2'_period_'1 = _prefixId.prefix "I.1.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.1.2.2. Nonalgebraic algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.2.2">acm:I.1.2.2</a>
    /// </summary>
    let I'_period_'1'_period_'2'_period_'2 = _prefixId.prefix "I.1.2.2"
    /// <summary>
    ///   <para>rdfs:label : I.1.3. Languages and Systems^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.2, #D.3.3, #F.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3">acm:I.1.3</a>
    /// </summary>
    let I'_period_'1'_period_'3 = _prefixId.prefix "I.1.3"
    /// <summary>
    ///   <para>rdfs:label : I.1.3.0. Evaluation strategies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.0">acm:I.1.3.0</a>
    /// </summary>
    let I'_period_'1'_period_'3'_period_'0 = _prefixId.prefix "I.1.3.0"
    /// <summary>
    ///   <para>rdfs:label : I.1.3.1. Nonprocedural languages^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.1">acm:I.1.3.1</a>
    /// </summary>
    let I'_period_'1'_period_'3'_period_'1 = _prefixId.prefix "I.1.3.1"
    /// <summary>
    ///   <para>rdfs:label : I.1.3.2. Special-purpose algebraic systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.2">acm:I.1.3.2</a>
    /// </summary>
    let I'_period_'1'_period_'3'_period_'2 = _prefixId.prefix "I.1.3.2"
    /// <summary>
    ///   <para>rdfs:label : I.1.3.3. Special-purpose hardware^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.3">acm:I.1.3.3</a>
    /// </summary>
    let I'_period_'1'_period_'3'_period_'3 = _prefixId.prefix "I.1.3.3"
    /// <summary>
    ///   <para>rdfs:label : I.1.3.4. Substitution mechanisms^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.3.4">acm:I.1.3.4</a>
    /// </summary>
    let I'_period_'1'_period_'3'_period_'4 = _prefixId.prefix "I.1.3.4"
    /// <summary>
    ///   <para>rdfs:label : I.1.4. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.4">acm:I.1.4</a>
    /// </summary>
    let I'_period_'1'_period_'4 = _prefixId.prefix "I.1.4"
    /// <summary>
    ///   <para>rdfs:label : I.1.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.1.m">acm:I.1.m</a>
    /// </summary>
    let I'_period_'1'_period_'m = _prefixId.prefix "I.1.m"
    /// <summary>
    ///   <para>rdfs:label : I.2. ARTIFICIAL INTELLIGENCE^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2">acm:I.2</a>
    /// </summary>
    let I'_period_'2 = _prefixId.prefix "I.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0">acm:I.2.0</a>
    /// </summary>
    let I'_period_'2'_period_'0 = _prefixId.prefix "I.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.0.0. Cognitive simulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.0">acm:I.2.0.0</a>
    /// </summary>
    let I'_period_'2'_period_'0'_period_'0 = _prefixId.prefix "I.2.0.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.0.1. Philosophical foundations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.0.1">acm:I.2.0.1</a>
    /// </summary>
    let I'_period_'2'_period_'0'_period_'1 = _prefixId.prefix "I.2.0.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.1. Applications and Expert Systems^^xsd:string</para>
    ///   <para>rdfs:comment : See also #H.4, #J.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1">acm:I.2.1</a>
    /// </summary>
    let I'_period_'2'_period_'1 = _prefixId.prefix "I.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.0. Cartography^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.0">acm:I.2.1.0</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'0 = _prefixId.prefix "I.2.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.1. Games^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.1">acm:I.2.1.1</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'1 = _prefixId.prefix "I.2.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.2. Industrial automation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.2">acm:I.2.1.2</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'2 = _prefixId.prefix "I.2.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.3. Law^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.3">acm:I.2.1.3</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'3 = _prefixId.prefix "I.2.1.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.4. Medicine and science^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.4">acm:I.2.1.4</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'4 = _prefixId.prefix "I.2.1.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.5. Natural language interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.5">acm:I.2.1.5</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'5 = _prefixId.prefix "I.2.1.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.1.6. Office automation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.1.6">acm:I.2.1.6</a>
    /// </summary>
    let I'_period_'2'_period_'1'_period_'6 = _prefixId.prefix "I.2.1.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.10. Vision and Scene Understanding^^xsd:string</para>
    ///   <para>rdfs:comment : See also #I.4.8, #I.5.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10">acm:I.2.10</a>
    /// </summary>
    let I'_period_'2'_period_'10 = _prefixId.prefix "I.2.10"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.0. 3D/stereo scene analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.0">acm:I.2.10.0</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'0 = _prefixId.prefix "I.2.10.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.1. Architecture and control structures^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.1">acm:I.2.10.1</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'1 = _prefixId.prefix "I.2.10.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.2. Intensity, color, photometry, and thresholding^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.2">acm:I.2.10.2</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'2 = _prefixId.prefix "I.2.10.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.3. Modeling and recovery of physical attributes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.3">acm:I.2.10.3</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'3 = _prefixId.prefix "I.2.10.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.4. Motion^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.4">acm:I.2.10.4</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'4 = _prefixId.prefix "I.2.10.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.5. Perceptual reasoning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.5">acm:I.2.10.5</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'5 = _prefixId.prefix "I.2.10.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.6. Representations, data structures, and transforms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.6">acm:I.2.10.6</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'6 = _prefixId.prefix "I.2.10.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.7. Shape^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.7">acm:I.2.10.7</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'7 = _prefixId.prefix "I.2.10.7"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.8. Texture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.8">acm:I.2.10.8</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'8 = _prefixId.prefix "I.2.10.8"
    /// <summary>
    ///   <para>rdfs:label : I.2.10.9. Video analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.10.9">acm:I.2.10.9</a>
    /// </summary>
    let I'_period_'2'_period_'10'_period_'9 = _prefixId.prefix "I.2.10.9"
    /// <summary>
    ///   <para>rdfs:label : I.2.11. Distributed Artificial Intelligence^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11">acm:I.2.11</a>
    /// </summary>
    let I'_period_'2'_period_'11 = _prefixId.prefix "I.2.11"
    /// <summary>
    ///   <para>rdfs:label : I.2.11.0. Coherence and coordination^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.0">acm:I.2.11.0</a>
    /// </summary>
    let I'_period_'2'_period_'11'_period_'0 = _prefixId.prefix "I.2.11.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.11.1. Intelligent agents^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.1">acm:I.2.11.1</a>
    /// </summary>
    let I'_period_'2'_period_'11'_period_'1 = _prefixId.prefix "I.2.11.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.11.2. Languages and structures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.2">acm:I.2.11.2</a>
    /// </summary>
    let I'_period_'2'_period_'11'_period_'2 = _prefixId.prefix "I.2.11.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.11.3. Multiagent systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.11.3">acm:I.2.11.3</a>
    /// </summary>
    let I'_period_'2'_period_'11'_period_'3 = _prefixId.prefix "I.2.11.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.2. Automatic Programming^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.1.2, #F.3.1, #F.4.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2">acm:I.2.2</a>
    /// </summary>
    let I'_period_'2'_period_'2 = _prefixId.prefix "I.2.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.2.0. Automatic analysis of algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.0">acm:I.2.2.0</a>
    /// </summary>
    let I'_period_'2'_period_'2'_period_'0 = _prefixId.prefix "I.2.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.2.1. Program modification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.1">acm:I.2.2.1</a>
    /// </summary>
    let I'_period_'2'_period_'2'_period_'1 = _prefixId.prefix "I.2.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.2.2. Program synthesis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.2">acm:I.2.2.2</a>
    /// </summary>
    let I'_period_'2'_period_'2'_period_'2 = _prefixId.prefix "I.2.2.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.2.3. Program transformation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.3">acm:I.2.2.3</a>
    /// </summary>
    let I'_period_'2'_period_'2'_period_'3 = _prefixId.prefix "I.2.2.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.2.4. Program verification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.2.4">acm:I.2.2.4</a>
    /// </summary>
    let I'_period_'2'_period_'2'_period_'4 = _prefixId.prefix "I.2.2.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.3. Deduction and Theorem Proving^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.4.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3">acm:I.2.3</a>
    /// </summary>
    let I'_period_'2'_period_'3 = _prefixId.prefix "I.2.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.0. Answer/reason extraction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.0">acm:I.2.3.0</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'0 = _prefixId.prefix "I.2.3.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.1. Deduction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.1">acm:I.2.3.1</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'1 = _prefixId.prefix "I.2.3.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.2. Inference engines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.2">acm:I.2.3.2</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'2 = _prefixId.prefix "I.2.3.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.3. Logic programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.3">acm:I.2.3.3</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'3 = _prefixId.prefix "I.2.3.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.4. Mathematical induction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.4">acm:I.2.3.4</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'4 = _prefixId.prefix "I.2.3.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.5. Metatheory^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.5">acm:I.2.3.5</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'5 = _prefixId.prefix "I.2.3.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.6. Nonmonotonic reasoning and belief revision^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.6">acm:I.2.3.6</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'6 = _prefixId.prefix "I.2.3.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.7. Resolution^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.7">acm:I.2.3.7</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'7 = _prefixId.prefix "I.2.3.7"
    /// <summary>
    ///   <para>rdfs:label : I.2.3.8. Uncertainty, ``fuzzy,'' and probabilistic reasoning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.3.8">acm:I.2.3.8</a>
    /// </summary>
    let I'_period_'2'_period_'3'_period_'8 = _prefixId.prefix "I.2.3.8"
    /// <summary>
    ///   <para>rdfs:label : I.2.4. Knowledge Representation Formalisms and Methods^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.4.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4">acm:I.2.4</a>
    /// </summary>
    let I'_period_'2'_period_'4 = _prefixId.prefix "I.2.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.0. Frames and scripts^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.0">acm:I.2.4.0</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'0 = _prefixId.prefix "I.2.4.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.1. Modal logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.1">acm:I.2.4.1</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'1 = _prefixId.prefix "I.2.4.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.2. Predicate logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.2">acm:I.2.4.2</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'2 = _prefixId.prefix "I.2.4.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.3. Relation systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.3">acm:I.2.4.3</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'3 = _prefixId.prefix "I.2.4.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.4. Representation languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.4">acm:I.2.4.4</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'4 = _prefixId.prefix "I.2.4.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.5. Representations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.5">acm:I.2.4.5</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'5 = _prefixId.prefix "I.2.4.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.6. Semantic networks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.6">acm:I.2.4.6</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'6 = _prefixId.prefix "I.2.4.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.4.7. Temporal logic^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.4.7">acm:I.2.4.7</a>
    /// </summary>
    let I'_period_'2'_period_'4'_period_'7 = _prefixId.prefix "I.2.4.7"
    /// <summary>
    ///   <para>rdfs:label : I.2.5. Programming Languages and Software^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.3.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5">acm:I.2.5</a>
    /// </summary>
    let I'_period_'2'_period_'5 = _prefixId.prefix "I.2.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.5.0. Expert system tools and techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.5.0">acm:I.2.5.0</a>
    /// </summary>
    let I'_period_'2'_period_'5'_period_'0 = _prefixId.prefix "I.2.5.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.6. Learning^^xsd:string</para>
    ///   <para>rdfs:comment : See also #K.3.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6">acm:I.2.6</a>
    /// </summary>
    let I'_period_'2'_period_'6 = _prefixId.prefix "I.2.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.0. Analogies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.0">acm:I.2.6.0</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'0 = _prefixId.prefix "I.2.6.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.1. Concept learning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.1">acm:I.2.6.1</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'1 = _prefixId.prefix "I.2.6.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.2. Connectionism and neural nets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.2">acm:I.2.6.2</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'2 = _prefixId.prefix "I.2.6.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.3. Induction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.3">acm:I.2.6.3</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'3 = _prefixId.prefix "I.2.6.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.4. Knowledge acquisition^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.4">acm:I.2.6.4</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'4 = _prefixId.prefix "I.2.6.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.5. Language acquisition^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.5">acm:I.2.6.5</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'5 = _prefixId.prefix "I.2.6.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.6.6. Parameter learning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.6.6">acm:I.2.6.6</a>
    /// </summary>
    let I'_period_'2'_period_'6'_period_'6 = _prefixId.prefix "I.2.6.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.7. Natural Language Processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7">acm:I.2.7</a>
    /// </summary>
    let I'_period_'2'_period_'7 = _prefixId.prefix "I.2.7"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.0. Discourse^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.0">acm:I.2.7.0</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'0 = _prefixId.prefix "I.2.7.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.1. Language generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.1">acm:I.2.7.1</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'1 = _prefixId.prefix "I.2.7.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.2. Language models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.2">acm:I.2.7.2</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'2 = _prefixId.prefix "I.2.7.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.3. Language parsing and understanding^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.3">acm:I.2.7.3</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'3 = _prefixId.prefix "I.2.7.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.4. Machine translation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.4">acm:I.2.7.4</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'4 = _prefixId.prefix "I.2.7.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.5. Speech recognition and synthesis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.5">acm:I.2.7.5</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'5 = _prefixId.prefix "I.2.7.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.7.6. Text analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.7.6">acm:I.2.7.6</a>
    /// </summary>
    let I'_period_'2'_period_'7'_period_'6 = _prefixId.prefix "I.2.7.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.8. Problem Solving, Control Methods, and Search^^xsd:string</para>
    ///   <para>rdfs:comment : See also #F.2.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8">acm:I.2.8</a>
    /// </summary>
    let I'_period_'2'_period_'8 = _prefixId.prefix "I.2.8"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.0. Backtracking^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.0">acm:I.2.8.0</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'0 = _prefixId.prefix "I.2.8.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.1. Control theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.1">acm:I.2.8.1</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'1 = _prefixId.prefix "I.2.8.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.2. Dynamic programming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.2">acm:I.2.8.2</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'2 = _prefixId.prefix "I.2.8.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.3. Graph and tree search strategies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.3">acm:I.2.8.3</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'3 = _prefixId.prefix "I.2.8.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.4. Heuristic methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.4">acm:I.2.8.4</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'4 = _prefixId.prefix "I.2.8.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.5. Plan execution, formation, and generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.5">acm:I.2.8.5</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'5 = _prefixId.prefix "I.2.8.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.8.6. Scheduling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.8.6">acm:I.2.8.6</a>
    /// </summary>
    let I'_period_'2'_period_'8'_period_'6 = _prefixId.prefix "I.2.8.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.9. Robotics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9">acm:I.2.9</a>
    /// </summary>
    let I'_period_'2'_period_'9 = _prefixId.prefix "I.2.9"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.0. Autonomous vehicles^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.0">acm:I.2.9.0</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'0 = _prefixId.prefix "I.2.9.0"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.1. Commercial robots and applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.1">acm:I.2.9.1</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'1 = _prefixId.prefix "I.2.9.1"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.2. Kinematics and dynamics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.2">acm:I.2.9.2</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'2 = _prefixId.prefix "I.2.9.2"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.3. Manipulators^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.3">acm:I.2.9.3</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'3 = _prefixId.prefix "I.2.9.3"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.4. Operator interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.4">acm:I.2.9.4</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'4 = _prefixId.prefix "I.2.9.4"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.5. Propelling mechanisms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.5">acm:I.2.9.5</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'5 = _prefixId.prefix "I.2.9.5"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.6. Sensors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.6">acm:I.2.9.6</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'6 = _prefixId.prefix "I.2.9.6"
    /// <summary>
    ///   <para>rdfs:label : I.2.9.7. Workcell organization and planning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.9.7">acm:I.2.9.7</a>
    /// </summary>
    let I'_period_'2'_period_'9'_period_'7 = _prefixId.prefix "I.2.9.7"
    /// <summary>
    ///   <para>rdfs:label : I.2.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.2.m">acm:I.2.m</a>
    /// </summary>
    let I'_period_'2'_period_'m = _prefixId.prefix "I.2.m"
    /// <summary>
    ///   <para>rdfs:label : I.3. COMPUTER GRAPHICS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3">acm:I.3</a>
    /// </summary>
    let I'_period_'3 = _prefixId.prefix "I.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.0">acm:I.3.0</a>
    /// </summary>
    let I'_period_'3'_period_'0 = _prefixId.prefix "I.3.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.1. Hardware Architecture^^xsd:string</para>
    ///   <para>rdfs:comment : See also #B.4.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1">acm:I.3.1</a>
    /// </summary>
    let I'_period_'3'_period_'1 = _prefixId.prefix "I.3.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.0. Graphics processors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.0">acm:I.3.1.0</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'0 = _prefixId.prefix "I.3.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.1. Hardcopy devices^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.1">acm:I.3.1.1</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "I.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.2. Input devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.2">acm:I.3.1.2</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'2 = _prefixId.prefix "I.3.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.3. Parallel processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.3">acm:I.3.1.3</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'3 = _prefixId.prefix "I.3.1.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.4. Raster display devices^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.4">acm:I.3.1.4</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'4 = _prefixId.prefix "I.3.1.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.5. Storage devices^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.5">acm:I.3.1.5</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'5 = _prefixId.prefix "I.3.1.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.6. Three-dimensional displays^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.6">acm:I.3.1.6</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'6 = _prefixId.prefix "I.3.1.6"
    /// <summary>
    ///   <para>rdfs:label : I.3.1.7. Vector display devices^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.1.7">acm:I.3.1.7</a>
    /// </summary>
    let I'_period_'3'_period_'1'_period_'7 = _prefixId.prefix "I.3.1.7"
    /// <summary>
    ///   <para>rdfs:label : I.3.2. Graphics Systems^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.2.1, #C.2.4, #C.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2">acm:I.3.2</a>
    /// </summary>
    let I'_period_'3'_period_'2 = _prefixId.prefix "I.3.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.2.0. Distributed/network graphics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.0">acm:I.3.2.0</a>
    /// </summary>
    let I'_period_'3'_period_'2'_period_'0 = _prefixId.prefix "I.3.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.2.1. Remote systems^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.1">acm:I.3.2.1</a>
    /// </summary>
    let I'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "I.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.2.2. Stand-alone systems^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.2.2">acm:I.3.2.2</a>
    /// </summary>
    let I'_period_'3'_period_'2'_period_'2 = _prefixId.prefix "I.3.2.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.3. Picture/Image Generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3">acm:I.3.3</a>
    /// </summary>
    let I'_period_'3'_period_'3 = _prefixId.prefix "I.3.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.3.0. Antialiasing^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.0">acm:I.3.3.0</a>
    /// </summary>
    let I'_period_'3'_period_'3'_period_'0 = _prefixId.prefix "I.3.3.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.3.1. Bitmap and framebuffer operations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.1">acm:I.3.3.1</a>
    /// </summary>
    let I'_period_'3'_period_'3'_period_'1 = _prefixId.prefix "I.3.3.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.3.2. Digitizing and scanning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.2">acm:I.3.3.2</a>
    /// </summary>
    let I'_period_'3'_period_'3'_period_'2 = _prefixId.prefix "I.3.3.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.3.3. Display algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.3">acm:I.3.3.3</a>
    /// </summary>
    let I'_period_'3'_period_'3'_period_'3 = _prefixId.prefix "I.3.3.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.3.4. Line and curve generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.4">acm:I.3.3.4</a>
    /// </summary>
    let I'_period_'3'_period_'3'_period_'4 = _prefixId.prefix "I.3.3.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.3.5. Viewing algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.3.5">acm:I.3.3.5</a>
    /// </summary>
    let I'_period_'3'_period_'3'_period_'5 = _prefixId.prefix "I.3.3.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.4. Graphics Utilities^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4">acm:I.3.4</a>
    /// </summary>
    let I'_period_'3'_period_'4 = _prefixId.prefix "I.3.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.0. Application packages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.0">acm:I.3.4.0</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'0 = _prefixId.prefix "I.3.4.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.1. Device drivers^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.1">acm:I.3.4.1</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'1 = _prefixId.prefix "I.3.4.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.2. Graphics editors^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.2">acm:I.3.4.2</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'2 = _prefixId.prefix "I.3.4.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.3. Graphics packages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.3">acm:I.3.4.3</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'3 = _prefixId.prefix "I.3.4.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.4. Meta files^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.4">acm:I.3.4.4</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'4 = _prefixId.prefix "I.3.4.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.5. Paint systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.5">acm:I.3.4.5</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'5 = _prefixId.prefix "I.3.4.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.6. Picture description languages^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.6">acm:I.3.4.6</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'6 = _prefixId.prefix "I.3.4.6"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.7. Software support^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.7">acm:I.3.4.7</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'7 = _prefixId.prefix "I.3.4.7"
    /// <summary>
    ///   <para>rdfs:label : I.3.4.8. Virtual device interfaces^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.4.8">acm:I.3.4.8</a>
    /// </summary>
    let I'_period_'3'_period_'4'_period_'8 = _prefixId.prefix "I.3.4.8"
    /// <summary>
    ///   <para>rdfs:label : I.3.5. Computational Geometry and Object Modeling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5">acm:I.3.5</a>
    /// </summary>
    let I'_period_'3'_period_'5 = _prefixId.prefix "I.3.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.0. Boundary representations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.0">acm:I.3.5.0</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'0 = _prefixId.prefix "I.3.5.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.1. Constructive solid geometry^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.1">acm:I.3.5.1</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'1 = _prefixId.prefix "I.3.5.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.2. Curve, surface, solid, and object representations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.2">acm:I.3.5.2</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'2 = _prefixId.prefix "I.3.5.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.3. Geometric algorithms, languages, and systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.3">acm:I.3.5.3</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'3 = _prefixId.prefix "I.3.5.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.4. Hierarchy and geometric transformations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.4">acm:I.3.5.4</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'4 = _prefixId.prefix "I.3.5.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.5. Modeling packages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.5">acm:I.3.5.5</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'5 = _prefixId.prefix "I.3.5.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.6. Object hierarchies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.6">acm:I.3.5.6</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'6 = _prefixId.prefix "I.3.5.6"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.7. Physically based modeling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.7">acm:I.3.5.7</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'7 = _prefixId.prefix "I.3.5.7"
    /// <summary>
    ///   <para>rdfs:label : I.3.5.8. Splines^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.5.8">acm:I.3.5.8</a>
    /// </summary>
    let I'_period_'3'_period_'5'_period_'8 = _prefixId.prefix "I.3.5.8"
    /// <summary>
    ///   <para>rdfs:label : I.3.6. Methodology and Techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6">acm:I.3.6</a>
    /// </summary>
    let I'_period_'3'_period_'6 = _prefixId.prefix "I.3.6"
    /// <summary>
    ///   <para>rdfs:label : I.3.6.0. Device independence^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.0">acm:I.3.6.0</a>
    /// </summary>
    let I'_period_'3'_period_'6'_period_'0 = _prefixId.prefix "I.3.6.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.6.1. Ergonomics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.1">acm:I.3.6.1</a>
    /// </summary>
    let I'_period_'3'_period_'6'_period_'1 = _prefixId.prefix "I.3.6.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.6.2. Graphics data structures and data types^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.2">acm:I.3.6.2</a>
    /// </summary>
    let I'_period_'3'_period_'6'_period_'2 = _prefixId.prefix "I.3.6.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.6.3. Interaction techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.3">acm:I.3.6.3</a>
    /// </summary>
    let I'_period_'3'_period_'6'_period_'3 = _prefixId.prefix "I.3.6.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.6.4. Languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.4">acm:I.3.6.4</a>
    /// </summary>
    let I'_period_'3'_period_'6'_period_'4 = _prefixId.prefix "I.3.6.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.6.5. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.6.5">acm:I.3.6.5</a>
    /// </summary>
    let I'_period_'3'_period_'6'_period_'5 = _prefixId.prefix "I.3.6.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.7. Three-Dimensional Graphics and Realism^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7">acm:I.3.7</a>
    /// </summary>
    let I'_period_'3'_period_'7 = _prefixId.prefix "I.3.7"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.0. Animation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.0">acm:I.3.7.0</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'0 = _prefixId.prefix "I.3.7.0"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.1. Color, shading, shadowing, and texture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.1">acm:I.3.7.1</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'1 = _prefixId.prefix "I.3.7.1"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.2. Fractals^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.2">acm:I.3.7.2</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'2 = _prefixId.prefix "I.3.7.2"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.3. Hidden line/surface removal^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.3">acm:I.3.7.3</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'3 = _prefixId.prefix "I.3.7.3"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.4. Radiosity^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.4">acm:I.3.7.4</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'4 = _prefixId.prefix "I.3.7.4"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.5. Raytracing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.5">acm:I.3.7.5</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'5 = _prefixId.prefix "I.3.7.5"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.6. Virtual reality^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.6">acm:I.3.7.6</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'6 = _prefixId.prefix "I.3.7.6"
    /// <summary>
    ///   <para>rdfs:label : I.3.7.7. Visible line/surface algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.7.7">acm:I.3.7.7</a>
    /// </summary>
    let I'_period_'3'_period_'7'_period_'7 = _prefixId.prefix "I.3.7.7"
    /// <summary>
    ///   <para>rdfs:label : I.3.8. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.8">acm:I.3.8</a>
    /// </summary>
    let I'_period_'3'_period_'8 = _prefixId.prefix "I.3.8"
    /// <summary>
    ///   <para>rdfs:label : I.3.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.3.m">acm:I.3.m</a>
    /// </summary>
    let I'_period_'3'_period_'m = _prefixId.prefix "I.3.m"
    /// <summary>
    ///   <para>rdfs:label : I.4. IMAGE PROCESSING AND COMPUTER VISION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4">acm:I.4</a>
    /// </summary>
    let I'_period_'4 = _prefixId.prefix "I.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0">acm:I.4.0</a>
    /// </summary>
    let I'_period_'4'_period_'0 = _prefixId.prefix "I.4.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.0.0. Image displays^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.0">acm:I.4.0.0</a>
    /// </summary>
    let I'_period_'4'_period_'0'_period_'0 = _prefixId.prefix "I.4.0.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.0.1. Image processing software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.0.1">acm:I.4.0.1</a>
    /// </summary>
    let I'_period_'4'_period_'0'_period_'1 = _prefixId.prefix "I.4.0.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.1. Digitization and Image Capture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1">acm:I.4.1</a>
    /// </summary>
    let I'_period_'4'_period_'1 = _prefixId.prefix "I.4.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.0. Camera calibration^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.0">acm:I.4.1.0</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'0 = _prefixId.prefix "I.4.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.1. Imaging geometry^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.1">acm:I.4.1.1</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'1 = _prefixId.prefix "I.4.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.2. Quantization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.2">acm:I.4.1.2</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'2 = _prefixId.prefix "I.4.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.3. Radiometry^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.3">acm:I.4.1.3</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'3 = _prefixId.prefix "I.4.1.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.4. Reflectance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.4">acm:I.4.1.4</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'4 = _prefixId.prefix "I.4.1.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.5. Sampling^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.5">acm:I.4.1.5</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'5 = _prefixId.prefix "I.4.1.5"
    /// <summary>
    ///   <para>rdfs:label : I.4.1.6. Scanning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.1.6">acm:I.4.1.6</a>
    /// </summary>
    let I'_period_'4'_period_'1'_period_'6 = _prefixId.prefix "I.4.1.6"
    /// <summary>
    ///   <para>rdfs:label : I.4.10. Image Representation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10">acm:I.4.10</a>
    /// </summary>
    let I'_period_'4'_period_'10 = _prefixId.prefix "I.4.10"
    /// <summary>
    ///   <para>rdfs:label : I.4.10.0. Hierarchical^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.0">acm:I.4.10.0</a>
    /// </summary>
    let I'_period_'4'_period_'10'_period_'0 = _prefixId.prefix "I.4.10.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.10.1. Morphological^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.1">acm:I.4.10.1</a>
    /// </summary>
    let I'_period_'4'_period_'10'_period_'1 = _prefixId.prefix "I.4.10.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.10.2. Multidimensional^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.2">acm:I.4.10.2</a>
    /// </summary>
    let I'_period_'4'_period_'10'_period_'2 = _prefixId.prefix "I.4.10.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.10.3. Statistical^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.3">acm:I.4.10.3</a>
    /// </summary>
    let I'_period_'4'_period_'10'_period_'3 = _prefixId.prefix "I.4.10.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.10.4. Volumetric^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.10.4">acm:I.4.10.4</a>
    /// </summary>
    let I'_period_'4'_period_'10'_period_'4 = _prefixId.prefix "I.4.10.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.2. Compression^^xsd:string</para>
    ///   <para>rdfs:comment : See also #E.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2">acm:I.4.2</a>
    /// </summary>
    let I'_period_'4'_period_'2 = _prefixId.prefix "I.4.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.2.0. Approximate methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.0">acm:I.4.2.0</a>
    /// </summary>
    let I'_period_'4'_period_'2'_period_'0 = _prefixId.prefix "I.4.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.2.1. Exact coding^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.2.1">acm:I.4.2.1</a>
    /// </summary>
    let I'_period_'4'_period_'2'_period_'1 = _prefixId.prefix "I.4.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.3. Enhancement^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3">acm:I.4.3</a>
    /// </summary>
    let I'_period_'4'_period_'3 = _prefixId.prefix "I.4.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.3.0. Filtering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.0">acm:I.4.3.0</a>
    /// </summary>
    let I'_period_'4'_period_'3'_period_'0 = _prefixId.prefix "I.4.3.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.3.1. Geometric correction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.1">acm:I.4.3.1</a>
    /// </summary>
    let I'_period_'4'_period_'3'_period_'1 = _prefixId.prefix "I.4.3.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.3.2. Grayscale manipulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.2">acm:I.4.3.2</a>
    /// </summary>
    let I'_period_'4'_period_'3'_period_'2 = _prefixId.prefix "I.4.3.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.3.3. Registration^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.3">acm:I.4.3.3</a>
    /// </summary>
    let I'_period_'4'_period_'3'_period_'3 = _prefixId.prefix "I.4.3.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.3.4. Sharpening and deblurring^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.4">acm:I.4.3.4</a>
    /// </summary>
    let I'_period_'4'_period_'3'_period_'4 = _prefixId.prefix "I.4.3.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.3.5. Smoothing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.3.5">acm:I.4.3.5</a>
    /// </summary>
    let I'_period_'4'_period_'3'_period_'5 = _prefixId.prefix "I.4.3.5"
    /// <summary>
    ///   <para>rdfs:label : I.4.4. Restoration^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4">acm:I.4.4</a>
    /// </summary>
    let I'_period_'4'_period_'4 = _prefixId.prefix "I.4.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.4.0. Inverse filtering^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.0">acm:I.4.4.0</a>
    /// </summary>
    let I'_period_'4'_period_'4'_period_'0 = _prefixId.prefix "I.4.4.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.4.1. Kalman filtering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.1">acm:I.4.4.1</a>
    /// </summary>
    let I'_period_'4'_period_'4'_period_'1 = _prefixId.prefix "I.4.4.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.4.2. Pseudoinverse restoration^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.2">acm:I.4.4.2</a>
    /// </summary>
    let I'_period_'4'_period_'4'_period_'2 = _prefixId.prefix "I.4.4.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.4.3. Wiener filtering^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.4.3">acm:I.4.4.3</a>
    /// </summary>
    let I'_period_'4'_period_'4'_period_'3 = _prefixId.prefix "I.4.4.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.5. Reconstruction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5">acm:I.4.5</a>
    /// </summary>
    let I'_period_'4'_period_'5 = _prefixId.prefix "I.4.5"
    /// <summary>
    ///   <para>rdfs:label : I.4.5.0. Series expansion methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.0">acm:I.4.5.0</a>
    /// </summary>
    let I'_period_'4'_period_'5'_period_'0 = _prefixId.prefix "I.4.5.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.5.1. Summation methods^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.1">acm:I.4.5.1</a>
    /// </summary>
    let I'_period_'4'_period_'5'_period_'1 = _prefixId.prefix "I.4.5.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.5.2. Transform methods^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.5.2">acm:I.4.5.2</a>
    /// </summary>
    let I'_period_'4'_period_'5'_period_'2 = _prefixId.prefix "I.4.5.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.6. Segmentation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6">acm:I.4.6</a>
    /// </summary>
    let I'_period_'4'_period_'6 = _prefixId.prefix "I.4.6"
    /// <summary>
    ///   <para>rdfs:label : I.4.6.0. Edge and feature detection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.0">acm:I.4.6.0</a>
    /// </summary>
    let I'_period_'4'_period_'6'_period_'0 = _prefixId.prefix "I.4.6.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.6.1. Pixel classification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.1">acm:I.4.6.1</a>
    /// </summary>
    let I'_period_'4'_period_'6'_period_'1 = _prefixId.prefix "I.4.6.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.6.2. Region growing, partitioning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.2">acm:I.4.6.2</a>
    /// </summary>
    let I'_period_'4'_period_'6'_period_'2 = _prefixId.prefix "I.4.6.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.6.3. Relaxation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.6.3">acm:I.4.6.3</a>
    /// </summary>
    let I'_period_'4'_period_'6'_period_'3 = _prefixId.prefix "I.4.6.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.7. Feature Measurement^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7">acm:I.4.7</a>
    /// </summary>
    let I'_period_'4'_period_'7 = _prefixId.prefix "I.4.7"
    /// <summary>
    ///   <para>rdfs:label : I.4.7.0. Feature representation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.0">acm:I.4.7.0</a>
    /// </summary>
    let I'_period_'4'_period_'7'_period_'0 = _prefixId.prefix "I.4.7.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.7.1. Invariants^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.1">acm:I.4.7.1</a>
    /// </summary>
    let I'_period_'4'_period_'7'_period_'1 = _prefixId.prefix "I.4.7.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.7.2. Moments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.2">acm:I.4.7.2</a>
    /// </summary>
    let I'_period_'4'_period_'7'_period_'2 = _prefixId.prefix "I.4.7.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.7.3. Projections^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.3">acm:I.4.7.3</a>
    /// </summary>
    let I'_period_'4'_period_'7'_period_'3 = _prefixId.prefix "I.4.7.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.7.4. Size and shape^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.4">acm:I.4.7.4</a>
    /// </summary>
    let I'_period_'4'_period_'7'_period_'4 = _prefixId.prefix "I.4.7.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.7.5. Texture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.7.5">acm:I.4.7.5</a>
    /// </summary>
    let I'_period_'4'_period_'7'_period_'5 = _prefixId.prefix "I.4.7.5"
    /// <summary>
    ///   <para>rdfs:label : I.4.8. Scene Analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8">acm:I.4.8</a>
    /// </summary>
    let I'_period_'4'_period_'8 = _prefixId.prefix "I.4.8"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.0. Color^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.0">acm:I.4.8.0</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'0 = _prefixId.prefix "I.4.8.0"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.1. Depth cues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.1">acm:I.4.8.1</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'1 = _prefixId.prefix "I.4.8.1"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.10. Surface fitting^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.10">acm:I.4.8.10</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'10 = _prefixId.prefix "I.4.8.10"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.11. Time-varying imagery^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.11">acm:I.4.8.11</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'11 = _prefixId.prefix "I.4.8.11"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.12. Tracking^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.12">acm:I.4.8.12</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'12 = _prefixId.prefix "I.4.8.12"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.2. Motion^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.2">acm:I.4.8.2</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'2 = _prefixId.prefix "I.4.8.2"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.3. Object recognition^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.3">acm:I.4.8.3</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'3 = _prefixId.prefix "I.4.8.3"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.4. Photometry^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.4">acm:I.4.8.4</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'4 = _prefixId.prefix "I.4.8.4"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.5. Range data^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.5">acm:I.4.8.5</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'5 = _prefixId.prefix "I.4.8.5"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.6. Sensor fusion^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.6">acm:I.4.8.6</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'6 = _prefixId.prefix "I.4.8.6"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.7. Shading^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.7">acm:I.4.8.7</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'7 = _prefixId.prefix "I.4.8.7"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.8. Shape^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.8">acm:I.4.8.8</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'8 = _prefixId.prefix "I.4.8.8"
    /// <summary>
    ///   <para>rdfs:label : I.4.8.9. Stereo^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.8.9">acm:I.4.8.9</a>
    /// </summary>
    let I'_period_'4'_period_'8'_period_'9 = _prefixId.prefix "I.4.8.9"
    /// <summary>
    ///   <para>rdfs:label : I.4.9. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.9">acm:I.4.9</a>
    /// </summary>
    let I'_period_'4'_period_'9 = _prefixId.prefix "I.4.9"
    /// <summary>
    ///   <para>rdfs:label : I.4.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.4.m">acm:I.4.m</a>
    /// </summary>
    let I'_period_'4'_period_'m = _prefixId.prefix "I.4.m"
    /// <summary>
    ///   <para>rdfs:label : I.5. PATTERN RECOGNITION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5">acm:I.5</a>
    /// </summary>
    let I'_period_'5 = _prefixId.prefix "I.5"
    /// <summary>
    ///   <para>rdfs:label : I.5.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.0">acm:I.5.0</a>
    /// </summary>
    let I'_period_'5'_period_'0 = _prefixId.prefix "I.5.0"
    /// <summary>
    ///   <para>rdfs:label : I.5.1. Models^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1">acm:I.5.1</a>
    /// </summary>
    let I'_period_'5'_period_'1 = _prefixId.prefix "I.5.1"
    /// <summary>
    ///   <para>rdfs:label : I.5.1.0. Deterministic^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.0">acm:I.5.1.0</a>
    /// </summary>
    let I'_period_'5'_period_'1'_period_'0 = _prefixId.prefix "I.5.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.5.1.1. Fuzzy set^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.1">acm:I.5.1.1</a>
    /// </summary>
    let I'_period_'5'_period_'1'_period_'1 = _prefixId.prefix "I.5.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.5.1.2. Geometric^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.2">acm:I.5.1.2</a>
    /// </summary>
    let I'_period_'5'_period_'1'_period_'2 = _prefixId.prefix "I.5.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.5.1.3. Neural nets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.3">acm:I.5.1.3</a>
    /// </summary>
    let I'_period_'5'_period_'1'_period_'3 = _prefixId.prefix "I.5.1.3"
    /// <summary>
    ///   <para>rdfs:label : I.5.1.4. Statistical^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.4">acm:I.5.1.4</a>
    /// </summary>
    let I'_period_'5'_period_'1'_period_'4 = _prefixId.prefix "I.5.1.4"
    /// <summary>
    ///   <para>rdfs:label : I.5.1.5. Structural^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.1.5">acm:I.5.1.5</a>
    /// </summary>
    let I'_period_'5'_period_'1'_period_'5 = _prefixId.prefix "I.5.1.5"
    /// <summary>
    ///   <para>rdfs:label : I.5.2. Design Methodology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2">acm:I.5.2</a>
    /// </summary>
    let I'_period_'5'_period_'2 = _prefixId.prefix "I.5.2"
    /// <summary>
    ///   <para>rdfs:label : I.5.2.0. Classifier design and evaluation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.0">acm:I.5.2.0</a>
    /// </summary>
    let I'_period_'5'_period_'2'_period_'0 = _prefixId.prefix "I.5.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.5.2.1. Feature evaluation and selection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.1">acm:I.5.2.1</a>
    /// </summary>
    let I'_period_'5'_period_'2'_period_'1 = _prefixId.prefix "I.5.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.5.2.2. Pattern analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.2.2">acm:I.5.2.2</a>
    /// </summary>
    let I'_period_'5'_period_'2'_period_'2 = _prefixId.prefix "I.5.2.2"
    /// <summary>
    ///   <para>rdfs:label : I.5.3. Clustering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3">acm:I.5.3</a>
    /// </summary>
    let I'_period_'5'_period_'3 = _prefixId.prefix "I.5.3"
    /// <summary>
    ///   <para>rdfs:label : I.5.3.0. Algorithms^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.0">acm:I.5.3.0</a>
    /// </summary>
    let I'_period_'5'_period_'3'_period_'0 = _prefixId.prefix "I.5.3.0"
    /// <summary>
    ///   <para>rdfs:label : I.5.3.1. Similarity measures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.3.1">acm:I.5.3.1</a>
    /// </summary>
    let I'_period_'5'_period_'3'_period_'1 = _prefixId.prefix "I.5.3.1"
    /// <summary>
    ///   <para>rdfs:label : I.5.4. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4">acm:I.5.4</a>
    /// </summary>
    let I'_period_'5'_period_'4 = _prefixId.prefix "I.5.4"
    /// <summary>
    ///   <para>rdfs:label : I.5.4.0. Computer vision^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.0">acm:I.5.4.0</a>
    /// </summary>
    let I'_period_'5'_period_'4'_period_'0 = _prefixId.prefix "I.5.4.0"
    /// <summary>
    ///   <para>rdfs:label : I.5.4.1. Signal processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.1">acm:I.5.4.1</a>
    /// </summary>
    let I'_period_'5'_period_'4'_period_'1 = _prefixId.prefix "I.5.4.1"
    /// <summary>
    ///   <para>rdfs:label : I.5.4.2. Text processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.2">acm:I.5.4.2</a>
    /// </summary>
    let I'_period_'5'_period_'4'_period_'2 = _prefixId.prefix "I.5.4.2"
    /// <summary>
    ///   <para>rdfs:label : I.5.4.3. Waveform analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.4.3">acm:I.5.4.3</a>
    /// </summary>
    let I'_period_'5'_period_'4'_period_'3 = _prefixId.prefix "I.5.4.3"
    /// <summary>
    ///   <para>rdfs:label : I.5.5. Implementation^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5">acm:I.5.5</a>
    /// </summary>
    let I'_period_'5'_period_'5 = _prefixId.prefix "I.5.5"
    /// <summary>
    ///   <para>rdfs:label : I.5.5.0. Interactive systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.0">acm:I.5.5.0</a>
    /// </summary>
    let I'_period_'5'_period_'5'_period_'0 = _prefixId.prefix "I.5.5.0"
    /// <summary>
    ///   <para>rdfs:label : I.5.5.1. Special architectures^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.5.1">acm:I.5.5.1</a>
    /// </summary>
    let I'_period_'5'_period_'5'_period_'1 = _prefixId.prefix "I.5.5.1"
    /// <summary>
    ///   <para>rdfs:label : I.5.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.5.m">acm:I.5.m</a>
    /// </summary>
    let I'_period_'5'_period_'m = _prefixId.prefix "I.5.m"
    /// <summary>
    ///   <para>rdfs:label : I.6. SIMULATION AND MODELING^^xsd:string</para>
    ///   <para>rdfs:comment : See also #G.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6">acm:I.6</a>
    /// </summary>
    let I'_period_'6 = _prefixId.prefix "I.6"
    /// <summary>
    ///   <para>rdfs:label : I.6.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.0">acm:I.6.0</a>
    /// </summary>
    let I'_period_'6'_period_'0 = _prefixId.prefix "I.6.0"
    /// <summary>
    ///   <para>rdfs:label : I.6.1. Simulation Theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1">acm:I.6.1</a>
    /// </summary>
    let I'_period_'6'_period_'1 = _prefixId.prefix "I.6.1"
    /// <summary>
    ///   <para>rdfs:label : I.6.1.0. Model classification^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.0">acm:I.6.1.0</a>
    /// </summary>
    let I'_period_'6'_period_'1'_period_'0 = _prefixId.prefix "I.6.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.6.1.1. Systems theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.1">acm:I.6.1.1</a>
    /// </summary>
    let I'_period_'6'_period_'1'_period_'1 = _prefixId.prefix "I.6.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.6.1.2. Types of simulation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1991.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.1.2">acm:I.6.1.2</a>
    /// </summary>
    let I'_period_'6'_period_'1'_period_'2 = _prefixId.prefix "I.6.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.6.2. Simulation Languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.2">acm:I.6.2</a>
    /// </summary>
    let I'_period_'6'_period_'2 = _prefixId.prefix "I.6.2"
    /// <summary>
    ///   <para>rdfs:label : I.6.3. Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.3">acm:I.6.3</a>
    /// </summary>
    let I'_period_'6'_period_'3 = _prefixId.prefix "I.6.3"
    /// <summary>
    ///   <para>rdfs:label : I.6.4. Model Validation and Analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.4">acm:I.6.4</a>
    /// </summary>
    let I'_period_'6'_period_'4 = _prefixId.prefix "I.6.4"
    /// <summary>
    ///   <para>rdfs:label : I.6.5. Model Development^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5">acm:I.6.5</a>
    /// </summary>
    let I'_period_'6'_period_'5 = _prefixId.prefix "I.6.5"
    /// <summary>
    ///   <para>rdfs:label : I.6.5.0. Modeling methodologies^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.5.0">acm:I.6.5.0</a>
    /// </summary>
    let I'_period_'6'_period_'5'_period_'0 = _prefixId.prefix "I.6.5.0"
    /// <summary>
    ///   <para>rdfs:label : I.6.6. Simulation Output Analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.6">acm:I.6.6</a>
    /// </summary>
    let I'_period_'6'_period_'6 = _prefixId.prefix "I.6.6"
    /// <summary>
    ///   <para>rdfs:label : I.6.7. Simulation Support Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7">acm:I.6.7</a>
    /// </summary>
    let I'_period_'6'_period_'7 = _prefixId.prefix "I.6.7"
    /// <summary>
    ///   <para>rdfs:label : I.6.7.0. Environments^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.7.0">acm:I.6.7.0</a>
    /// </summary>
    let I'_period_'6'_period_'7'_period_'0 = _prefixId.prefix "I.6.7.0"
    /// <summary>
    ///   <para>rdfs:label : I.6.8. Types of Simulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8">acm:I.6.8</a>
    /// </summary>
    let I'_period_'6'_period_'8 = _prefixId.prefix "I.6.8"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.0. Animation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.0">acm:I.6.8.0</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'0 = _prefixId.prefix "I.6.8.0"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.1. Combined^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.1">acm:I.6.8.1</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'1 = _prefixId.prefix "I.6.8.1"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.2. Continuous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.2">acm:I.6.8.2</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'2 = _prefixId.prefix "I.6.8.2"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.3. Discrete event^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.3">acm:I.6.8.3</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'3 = _prefixId.prefix "I.6.8.3"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.4. Distributed^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.4">acm:I.6.8.4</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'4 = _prefixId.prefix "I.6.8.4"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.5. Gaming^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.5">acm:I.6.8.5</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'5 = _prefixId.prefix "I.6.8.5"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.6. Monte Carlo^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.6">acm:I.6.8.6</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'6 = _prefixId.prefix "I.6.8.6"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.7. Parallel^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.7">acm:I.6.8.7</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'7 = _prefixId.prefix "I.6.8.7"
    /// <summary>
    ///   <para>rdfs:label : I.6.8.8. Visual^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.8.8">acm:I.6.8.8</a>
    /// </summary>
    let I'_period_'6'_period_'8'_period_'8 = _prefixId.prefix "I.6.8.8"
    /// <summary>
    ///   <para>rdfs:label : I.6.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.6.m">acm:I.6.m</a>
    /// </summary>
    let I'_period_'6'_period_'m = _prefixId.prefix "I.6.m"
    /// <summary>
    ///   <para>rdfs:label : I.7. DOCUMENT AND TEXT PROCESSING^^xsd:string</para>
    ///   <para>rdfs:comment : See also #H.4, #H.5.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7">acm:I.7</a>
    /// </summary>
    let I'_period_'7 = _prefixId.prefix "I.7"
    /// <summary>
    ///   <para>rdfs:label : I.7.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.0">acm:I.7.0</a>
    /// </summary>
    let I'_period_'7'_period_'0 = _prefixId.prefix "I.7.0"
    /// <summary>
    ///   <para>rdfs:label : I.7.1. Document and Text Editing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1">acm:I.7.1</a>
    /// </summary>
    let I'_period_'7'_period_'1 = _prefixId.prefix "I.7.1"
    /// <summary>
    ///   <para>rdfs:label : I.7.1.0. Document management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.0">acm:I.7.1.0</a>
    /// </summary>
    let I'_period_'7'_period_'1'_period_'0 = _prefixId.prefix "I.7.1.0"
    /// <summary>
    ///   <para>rdfs:label : I.7.1.1. Languages^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.1">acm:I.7.1.1</a>
    /// </summary>
    let I'_period_'7'_period_'1'_period_'1 = _prefixId.prefix "I.7.1.1"
    /// <summary>
    ///   <para>rdfs:label : I.7.1.2. Spelling^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.2">acm:I.7.1.2</a>
    /// </summary>
    let I'_period_'7'_period_'1'_period_'2 = _prefixId.prefix "I.7.1.2"
    /// <summary>
    ///   <para>rdfs:label : I.7.1.3. Version control^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.1.3">acm:I.7.1.3</a>
    /// </summary>
    let I'_period_'7'_period_'1'_period_'3 = _prefixId.prefix "I.7.1.3"
    /// <summary>
    ///   <para>rdfs:label : I.7.2. Document Preparation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2">acm:I.7.2</a>
    /// </summary>
    let I'_period_'7'_period_'2 = _prefixId.prefix "I.7.2"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.0. Desktop publishing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.0">acm:I.7.2.0</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'0 = _prefixId.prefix "I.7.2.0"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.1. Format and notation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.1">acm:I.7.2.1</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'1 = _prefixId.prefix "I.7.2.1"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.2. Hypertext/hypermedia^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.2">acm:I.7.2.2</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'2 = _prefixId.prefix "I.7.2.2"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.3. Index generation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.3">acm:I.7.2.3</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'3 = _prefixId.prefix "I.7.2.3"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.4. Languages and systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.4">acm:I.7.2.4</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'4 = _prefixId.prefix "I.7.2.4"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.5. Markup languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.5">acm:I.7.2.5</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'5 = _prefixId.prefix "I.7.2.5"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.6. Multi/mixed media^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.6">acm:I.7.2.6</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'6 = _prefixId.prefix "I.7.2.6"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.7. Photocomposition/typesetting^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.7">acm:I.7.2.7</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'7 = _prefixId.prefix "I.7.2.7"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.8. Scripting languages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.8">acm:I.7.2.8</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'8 = _prefixId.prefix "I.7.2.8"
    /// <summary>
    ///   <para>rdfs:label : I.7.2.9. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.2.9">acm:I.7.2.9</a>
    /// </summary>
    let I'_period_'7'_period_'2'_period_'9 = _prefixId.prefix "I.7.2.9"
    /// <summary>
    ///   <para>rdfs:label : I.7.3. Index Generation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.3">acm:I.7.3</a>
    /// </summary>
    let I'_period_'7'_period_'3 = _prefixId.prefix "I.7.3"
    /// <summary>
    ///   <para>rdfs:label : I.7.4. Electronic Publishing^^xsd:string</para>
    ///   <para>rdfs:comment : See also #H.5.4, #J.7, #I.4.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4">acm:I.7.4</a>
    /// </summary>
    let I'_period_'7'_period_'4 = _prefixId.prefix "I.7.4"
    /// <summary>
    ///   <para>rdfs:label : I.7.4.0. Document analysis^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.0">acm:I.7.4.0</a>
    /// </summary>
    let I'_period_'7'_period_'4'_period_'0 = _prefixId.prefix "I.7.4.0"
    /// <summary>
    ///   <para>rdfs:label : I.7.4.1. Graphics recognition and interpretation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.1">acm:I.7.4.1</a>
    /// </summary>
    let I'_period_'7'_period_'4'_period_'1 = _prefixId.prefix "I.7.4.1"
    /// <summary>
    ///   <para>rdfs:label : I.7.4.2. Optical character recognition^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.2">acm:I.7.4.2</a>
    /// </summary>
    let I'_period_'7'_period_'4'_period_'2 = _prefixId.prefix "I.7.4.2"
    /// <summary>
    ///   <para>rdfs:label : I.7.4.3. Scanning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.4.3">acm:I.7.4.3</a>
    /// </summary>
    let I'_period_'7'_period_'4'_period_'3 = _prefixId.prefix "I.7.4.3"
    /// <summary>
    ///   <para>rdfs:label : I.7.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.7.m">acm:I.7.m</a>
    /// </summary>
    let I'_period_'7'_period_'m = _prefixId.prefix "I.7.m"
    /// <summary>
    ///   <para>rdfs:label : I.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#I.m">acm:I.m</a>
    /// </summary>
    let I'_period_'m = _prefixId.prefix "I.m"
    /// <summary>
    ///   <para>rdfs:label : J. Computer Applications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J">acm:J</a>
    /// </summary>
    let J = _prefixId.prefix "J"
    /// <summary>
    ///   <para>rdfs:label : J.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.0">acm:J.0</a>
    /// </summary>
    let J'_period_'0 = _prefixId.prefix "J.0"
    /// <summary>
    ///   <para>rdfs:label : J.1. ADMINISTRATIVE DATA PROCESSING^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1">acm:J.1</a>
    /// </summary>
    let J'_period_'1 = _prefixId.prefix "J.1"
    /// <summary>
    ///   <para>rdfs:label : J.1.0. Business^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.0">acm:J.1.0</a>
    /// </summary>
    let J'_period_'1'_period_'0 = _prefixId.prefix "J.1.0"
    /// <summary>
    ///   <para>rdfs:label : J.1.1. Education^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.1">acm:J.1.1</a>
    /// </summary>
    let J'_period_'1'_period_'1 = _prefixId.prefix "J.1.1"
    /// <summary>
    ///   <para>rdfs:label : J.1.2. Financial^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.2">acm:J.1.2</a>
    /// </summary>
    let J'_period_'1'_period_'2 = _prefixId.prefix "J.1.2"
    /// <summary>
    ///   <para>rdfs:label : J.1.3. Government^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.3">acm:J.1.3</a>
    /// </summary>
    let J'_period_'1'_period_'3 = _prefixId.prefix "J.1.3"
    /// <summary>
    ///   <para>rdfs:label : J.1.4. Law^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.4">acm:J.1.4</a>
    /// </summary>
    let J'_period_'1'_period_'4 = _prefixId.prefix "J.1.4"
    /// <summary>
    ///   <para>rdfs:label : J.1.5. Manufacturing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.5">acm:J.1.5</a>
    /// </summary>
    let J'_period_'1'_period_'5 = _prefixId.prefix "J.1.5"
    /// <summary>
    ///   <para>rdfs:label : J.1.6. Marketing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.6">acm:J.1.6</a>
    /// </summary>
    let J'_period_'1'_period_'6 = _prefixId.prefix "J.1.6"
    /// <summary>
    ///   <para>rdfs:label : J.1.7. Military^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.1.7">acm:J.1.7</a>
    /// </summary>
    let J'_period_'1'_period_'7 = _prefixId.prefix "J.1.7"
    /// <summary>
    ///   <para>rdfs:label : J.2. PHYSICAL SCIENCES AND ENGINEERING^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2">acm:J.2</a>
    /// </summary>
    let J'_period_'2 = _prefixId.prefix "J.2"
    /// <summary>
    ///   <para>rdfs:label : J.2.0. Aerospace^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.0">acm:J.2.0</a>
    /// </summary>
    let J'_period_'2'_period_'0 = _prefixId.prefix "J.2.0"
    /// <summary>
    ///   <para>rdfs:label : J.2.1. Archaeology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.1">acm:J.2.1</a>
    /// </summary>
    let J'_period_'2'_period_'1 = _prefixId.prefix "J.2.1"
    /// <summary>
    ///   <para>rdfs:label : J.2.2. Astronomy^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.2">acm:J.2.2</a>
    /// </summary>
    let J'_period_'2'_period_'2 = _prefixId.prefix "J.2.2"
    /// <summary>
    ///   <para>rdfs:label : J.2.3. Chemistry^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.3">acm:J.2.3</a>
    /// </summary>
    let J'_period_'2'_period_'3 = _prefixId.prefix "J.2.3"
    /// <summary>
    ///   <para>rdfs:label : J.2.4. Earth and atmospheric sciences^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.4">acm:J.2.4</a>
    /// </summary>
    let J'_period_'2'_period_'4 = _prefixId.prefix "J.2.4"
    /// <summary>
    ///   <para>rdfs:label : J.2.5. Electronics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.5">acm:J.2.5</a>
    /// </summary>
    let J'_period_'2'_period_'5 = _prefixId.prefix "J.2.5"
    /// <summary>
    ///   <para>rdfs:label : J.2.6. Engineering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.6">acm:J.2.6</a>
    /// </summary>
    let J'_period_'2'_period_'6 = _prefixId.prefix "J.2.6"
    /// <summary>
    ///   <para>rdfs:label : J.2.7. Mathematics and statistics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.7">acm:J.2.7</a>
    /// </summary>
    let J'_period_'2'_period_'7 = _prefixId.prefix "J.2.7"
    /// <summary>
    ///   <para>rdfs:label : J.2.8. Physics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.2.8">acm:J.2.8</a>
    /// </summary>
    let J'_period_'2'_period_'8 = _prefixId.prefix "J.2.8"
    /// <summary>
    ///   <para>rdfs:label : J.3. LIFE AND MEDICAL SCIENCES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.3">acm:J.3</a>
    /// </summary>
    let J'_period_'3 = _prefixId.prefix "J.3"
    /// <summary>
    ///   <para>rdfs:label : J.3.0. Biology and genetics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.3.0">acm:J.3.0</a>
    /// </summary>
    let J'_period_'3'_period_'0 = _prefixId.prefix "J.3.0"
    /// <summary>
    ///   <para>rdfs:label : J.3.1. Health^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.3.1">acm:J.3.1</a>
    /// </summary>
    let J'_period_'3'_period_'1 = _prefixId.prefix "J.3.1"
    /// <summary>
    ///   <para>rdfs:label : J.3.2. Medical information systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.3.2">acm:J.3.2</a>
    /// </summary>
    let J'_period_'3'_period_'2 = _prefixId.prefix "J.3.2"
    /// <summary>
    ///   <para>rdfs:label : J.4. SOCIAL AND BEHAVIORAL SCIENCES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.4">acm:J.4</a>
    /// </summary>
    let J'_period_'4 = _prefixId.prefix "J.4"
    /// <summary>
    ///   <para>rdfs:label : J.4.0. Economics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.4.0">acm:J.4.0</a>
    /// </summary>
    let J'_period_'4'_period_'0 = _prefixId.prefix "J.4.0"
    /// <summary>
    ///   <para>rdfs:label : J.4.1. Psychology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.4.1">acm:J.4.1</a>
    /// </summary>
    let J'_period_'4'_period_'1 = _prefixId.prefix "J.4.1"
    /// <summary>
    ///   <para>rdfs:label : J.4.2. Sociology^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.4.2">acm:J.4.2</a>
    /// </summary>
    let J'_period_'4'_period_'2 = _prefixId.prefix "J.4.2"
    /// <summary>
    ///   <para>rdfs:label : J.5. ARTS AND HUMANITIES^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5">acm:J.5</a>
    /// </summary>
    let J'_period_'5 = _prefixId.prefix "J.5"
    /// <summary>
    ///   <para>rdfs:label : J.5.0. Architecture^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.0">acm:J.5.0</a>
    /// </summary>
    let J'_period_'5'_period_'0 = _prefixId.prefix "J.5.0"
    /// <summary>
    ///   <para>rdfs:label : J.5.1. Arts, fine and performing^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.1">acm:J.5.1</a>
    /// </summary>
    let J'_period_'5'_period_'1 = _prefixId.prefix "J.5.1"
    /// <summary>
    ///   <para>rdfs:label : J.5.2. Fine arts^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.2">acm:J.5.2</a>
    /// </summary>
    let J'_period_'5'_period_'2 = _prefixId.prefix "J.5.2"
    /// <summary>
    ///   <para>rdfs:label : J.5.3. Language translation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.3">acm:J.5.3</a>
    /// </summary>
    let J'_period_'5'_period_'3 = _prefixId.prefix "J.5.3"
    /// <summary>
    ///   <para>rdfs:label : J.5.4. Linguistics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.4">acm:J.5.4</a>
    /// </summary>
    let J'_period_'5'_period_'4 = _prefixId.prefix "J.5.4"
    /// <summary>
    ///   <para>rdfs:label : J.5.5. Literature^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.5">acm:J.5.5</a>
    /// </summary>
    let J'_period_'5'_period_'5 = _prefixId.prefix "J.5.5"
    /// <summary>
    ///   <para>rdfs:label : J.5.6. Music^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.6">acm:J.5.6</a>
    /// </summary>
    let J'_period_'5'_period_'6 = _prefixId.prefix "J.5.6"
    /// <summary>
    ///   <para>rdfs:label : J.5.7. Performing arts^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.5.7">acm:J.5.7</a>
    /// </summary>
    let J'_period_'5'_period_'7 = _prefixId.prefix "J.5.7"
    /// <summary>
    ///   <para>rdfs:label : J.6. COMPUTER-AIDED ENGINEERING^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.6">acm:J.6</a>
    /// </summary>
    let J'_period_'6 = _prefixId.prefix "J.6"
    /// <summary>
    ///   <para>rdfs:label : J.6.0. Computer-aided design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.6.0">acm:J.6.0</a>
    /// </summary>
    let J'_period_'6'_period_'0 = _prefixId.prefix "J.6.0"
    /// <summary>
    ///   <para>rdfs:label : J.6.1. Computer-aided manufacturing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.6.1">acm:J.6.1</a>
    /// </summary>
    let J'_period_'6'_period_'1 = _prefixId.prefix "J.6.1"
    /// <summary>
    ///   <para>rdfs:label : J.7. COMPUTERS IN OTHER SYSTEMS^^xsd:string</para>
    ///   <para>rdfs:comment : See also #C.3.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7">acm:J.7</a>
    /// </summary>
    let J'_period_'7 = _prefixId.prefix "J.7"
    /// <summary>
    ///   <para>rdfs:label : J.7.0. Command and control^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.0">acm:J.7.0</a>
    /// </summary>
    let J'_period_'7'_period_'0 = _prefixId.prefix "J.7.0"
    /// <summary>
    ///   <para>rdfs:label : J.7.1. Consumer products^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.1">acm:J.7.1</a>
    /// </summary>
    let J'_period_'7'_period_'1 = _prefixId.prefix "J.7.1"
    /// <summary>
    ///   <para>rdfs:label : J.7.2. Industrial control^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.2">acm:J.7.2</a>
    /// </summary>
    let J'_period_'7'_period_'2 = _prefixId.prefix "J.7.2"
    /// <summary>
    ///   <para>rdfs:label : J.7.3. Military^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.3">acm:J.7.3</a>
    /// </summary>
    let J'_period_'7'_period_'3 = _prefixId.prefix "J.7.3"
    /// <summary>
    ///   <para>rdfs:label : J.7.4. Process control^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.4">acm:J.7.4</a>
    /// </summary>
    let J'_period_'7'_period_'4 = _prefixId.prefix "J.7.4"
    /// <summary>
    ///   <para>rdfs:label : J.7.5. Publishing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.5">acm:J.7.5</a>
    /// </summary>
    let J'_period_'7'_period_'5 = _prefixId.prefix "J.7.5"
    /// <summary>
    ///   <para>rdfs:label : J.7.6. Real time^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.7.6">acm:J.7.6</a>
    /// </summary>
    let J'_period_'7'_period_'6 = _prefixId.prefix "J.7.6"
    /// <summary>
    ///   <para>rdfs:label : J.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#J.m">acm:J.m</a>
    /// </summary>
    let J'_period_'m = _prefixId.prefix "J.m"
    /// <summary>
    ///   <para>rdfs:label : K. Computing Milieux^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K">acm:K</a>
    /// </summary>
    let K = _prefixId.prefix "K"
    /// <summary>
    ///   <para>rdfs:label : K.0. GENERAL^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.0">acm:K.0</a>
    /// </summary>
    let K'_period_'0 = _prefixId.prefix "K.0"
    /// <summary>
    ///   <para>rdfs:label : K.1. THE COMPUTER INDUSTRY^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.1">acm:K.1</a>
    /// </summary>
    let K'_period_'1 = _prefixId.prefix "K.1"
    /// <summary>
    ///   <para>rdfs:label : K.1.0. Markets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.1.0">acm:K.1.0</a>
    /// </summary>
    let K'_period_'1'_period_'0 = _prefixId.prefix "K.1.0"
    /// <summary>
    ///   <para>rdfs:label : K.1.1. Standards^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.1.1">acm:K.1.1</a>
    /// </summary>
    let K'_period_'1'_period_'1 = _prefixId.prefix "K.1.1"
    /// <summary>
    ///   <para>rdfs:label : K.1.2. Statistics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.1.2">acm:K.1.2</a>
    /// </summary>
    let K'_period_'1'_period_'2 = _prefixId.prefix "K.1.2"
    /// <summary>
    ///   <para>rdfs:label : K.1.3. Suppliers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.1.3">acm:K.1.3</a>
    /// </summary>
    let K'_period_'1'_period_'3 = _prefixId.prefix "K.1.3"
    /// <summary>
    ///   <para>rdfs:label : K.2. HISTORY OF COMPUTING^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.2">acm:K.2</a>
    /// </summary>
    let K'_period_'2 = _prefixId.prefix "K.2"
    /// <summary>
    ///   <para>rdfs:label : K.2.0. Hardware^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.2.0">acm:K.2.0</a>
    /// </summary>
    let K'_period_'2'_period_'0 = _prefixId.prefix "K.2.0"
    /// <summary>
    ///   <para>rdfs:label : K.2.1. People^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.2.1">acm:K.2.1</a>
    /// </summary>
    let K'_period_'2'_period_'1 = _prefixId.prefix "K.2.1"
    /// <summary>
    ///   <para>rdfs:label : K.2.2. Software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.2.2">acm:K.2.2</a>
    /// </summary>
    let K'_period_'2'_period_'2 = _prefixId.prefix "K.2.2"
    /// <summary>
    ///   <para>rdfs:label : K.2.3. Systems^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.2.3">acm:K.2.3</a>
    /// </summary>
    let K'_period_'2'_period_'3 = _prefixId.prefix "K.2.3"
    /// <summary>
    ///   <para>rdfs:label : K.2.4. Theory^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.2.4">acm:K.2.4</a>
    /// </summary>
    let K'_period_'2'_period_'4 = _prefixId.prefix "K.2.4"
    /// <summary>
    ///   <para>rdfs:label : K.3. COMPUTERS AND EDUCATION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3">acm:K.3</a>
    /// </summary>
    let K'_period_'3 = _prefixId.prefix "K.3"
    /// <summary>
    ///   <para>rdfs:label : K.3.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.0">acm:K.3.0</a>
    /// </summary>
    let K'_period_'3'_period_'0 = _prefixId.prefix "K.3.0"
    /// <summary>
    ///   <para>rdfs:label : K.3.1. Computer Uses in Education^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1">acm:K.3.1</a>
    /// </summary>
    let K'_period_'3'_period_'1 = _prefixId.prefix "K.3.1"
    /// <summary>
    ///   <para>rdfs:label : K.3.1.0. Collaborative learning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.0">acm:K.3.1.0</a>
    /// </summary>
    let K'_period_'3'_period_'1'_period_'0 = _prefixId.prefix "K.3.1.0"
    /// <summary>
    ///   <para>rdfs:label : K.3.1.1. Computer-assisted instruction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.1">acm:K.3.1.1</a>
    /// </summary>
    let K'_period_'3'_period_'1'_period_'1 = _prefixId.prefix "K.3.1.1"
    /// <summary>
    ///   <para>rdfs:label : K.3.1.2. Computer-managed instruction^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.2">acm:K.3.1.2</a>
    /// </summary>
    let K'_period_'3'_period_'1'_period_'2 = _prefixId.prefix "K.3.1.2"
    /// <summary>
    ///   <para>rdfs:label : K.3.1.3. Distance learning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.1.3">acm:K.3.1.3</a>
    /// </summary>
    let K'_period_'3'_period_'1'_period_'3 = _prefixId.prefix "K.3.1.3"
    /// <summary>
    ///   <para>rdfs:label : K.3.2. Computer and Information Science Education^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2">acm:K.3.2</a>
    /// </summary>
    let K'_period_'3'_period_'2 = _prefixId.prefix "K.3.2"
    /// <summary>
    ///   <para>rdfs:label : K.3.2.0. Accreditation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.0">acm:K.3.2.0</a>
    /// </summary>
    let K'_period_'3'_period_'2'_period_'0 = _prefixId.prefix "K.3.2.0"
    /// <summary>
    ///   <para>rdfs:label : K.3.2.1. Computer science education^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.1">acm:K.3.2.1</a>
    /// </summary>
    let K'_period_'3'_period_'2'_period_'1 = _prefixId.prefix "K.3.2.1"
    /// <summary>
    ///   <para>rdfs:label : K.3.2.2. Curriculum^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.2">acm:K.3.2.2</a>
    /// </summary>
    let K'_period_'3'_period_'2'_period_'2 = _prefixId.prefix "K.3.2.2"
    /// <summary>
    ///   <para>rdfs:label : K.3.2.3. Information systems education^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.3">acm:K.3.2.3</a>
    /// </summary>
    let K'_period_'3'_period_'2'_period_'3 = _prefixId.prefix "K.3.2.3"
    /// <summary>
    ///   <para>rdfs:label : K.3.2.4. Literacy^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.4">acm:K.3.2.4</a>
    /// </summary>
    let K'_period_'3'_period_'2'_period_'4 = _prefixId.prefix "K.3.2.4"
    /// <summary>
    ///   <para>rdfs:label : K.3.2.5. Self-assessment^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.2.5">acm:K.3.2.5</a>
    /// </summary>
    let K'_period_'3'_period_'2'_period_'5 = _prefixId.prefix "K.3.2.5"
    /// <summary>
    ///   <para>rdfs:label : K.3.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m">acm:K.3.m</a>
    /// </summary>
    let K'_period_'3'_period_'m = _prefixId.prefix "K.3.m"
    /// <summary>
    ///   <para>rdfs:label : K.3.m.0. Accreditation^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.0">acm:K.3.m.0</a>
    /// </summary>
    let K'_period_'3'_period_'m'_period_'0 = _prefixId.prefix "K.3.m.0"
    /// <summary>
    ///   <para>rdfs:label : K.3.m.1. Computer literacy^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.3.m.1">acm:K.3.m.1</a>
    /// </summary>
    let K'_period_'3'_period_'m'_period_'1 = _prefixId.prefix "K.3.m.1"
    /// <summary>
    ///   <para>rdfs:label : K.4. COMPUTERS AND SOCIETY^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4">acm:K.4</a>
    /// </summary>
    let K'_period_'4 = _prefixId.prefix "K.4"
    /// <summary>
    ///   <para>rdfs:label : K.4.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.0">acm:K.4.0</a>
    /// </summary>
    let K'_period_'4'_period_'0 = _prefixId.prefix "K.4.0"
    /// <summary>
    ///   <para>rdfs:label : K.4.1. Public Policy Issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1">acm:K.4.1</a>
    /// </summary>
    let K'_period_'4'_period_'1 = _prefixId.prefix "K.4.1"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.0. Abuse and crime involving computers^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.0">acm:K.4.1.0</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'0 = _prefixId.prefix "K.4.1.0"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.1. Computer-related health issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.1">acm:K.4.1.1</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'1 = _prefixId.prefix "K.4.1.1"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.2. Ethics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.2">acm:K.4.1.2</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'2 = _prefixId.prefix "K.4.1.2"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.3. Human safety^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.3">acm:K.4.1.3</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'3 = _prefixId.prefix "K.4.1.3"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.4. Intellectual property rights^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.4">acm:K.4.1.4</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'4 = _prefixId.prefix "K.4.1.4"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.5. Privacy^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.5">acm:K.4.1.5</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'5 = _prefixId.prefix "K.4.1.5"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.6. Regulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.6">acm:K.4.1.6</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'6 = _prefixId.prefix "K.4.1.6"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.7. Transborder data flow^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.7">acm:K.4.1.7</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'7 = _prefixId.prefix "K.4.1.7"
    /// <summary>
    ///   <para>rdfs:label : K.4.1.8. Use/abuse of power^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.1.8">acm:K.4.1.8</a>
    /// </summary>
    let K'_period_'4'_period_'1'_period_'8 = _prefixId.prefix "K.4.1.8"
    /// <summary>
    ///   <para>rdfs:label : K.4.2. Social Issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2">acm:K.4.2</a>
    /// </summary>
    let K'_period_'4'_period_'2 = _prefixId.prefix "K.4.2"
    /// <summary>
    ///   <para>rdfs:label : K.4.2.0. Abuse and crime involving computers^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.0">acm:K.4.2.0</a>
    /// </summary>
    let K'_period_'4'_period_'2'_period_'0 = _prefixId.prefix "K.4.2.0"
    /// <summary>
    ///   <para>rdfs:label : K.4.2.1. Assistive technologies for persons with disabilities^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.1">acm:K.4.2.1</a>
    /// </summary>
    let K'_period_'4'_period_'2'_period_'1 = _prefixId.prefix "K.4.2.1"
    /// <summary>
    ///   <para>rdfs:label : K.4.2.2. Employment^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.2">acm:K.4.2.2</a>
    /// </summary>
    let K'_period_'4'_period_'2'_period_'2 = _prefixId.prefix "K.4.2.2"
    /// <summary>
    ///   <para>rdfs:label : K.4.2.3. Handicapped persons/special needs^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.2.3">acm:K.4.2.3</a>
    /// </summary>
    let K'_period_'4'_period_'2'_period_'3 = _prefixId.prefix "K.4.2.3"
    /// <summary>
    ///   <para>rdfs:label : K.4.3. Organizational Impacts^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3">acm:K.4.3</a>
    /// </summary>
    let K'_period_'4'_period_'3 = _prefixId.prefix "K.4.3"
    /// <summary>
    ///   <para>rdfs:label : K.4.3.0. Automation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.0">acm:K.4.3.0</a>
    /// </summary>
    let K'_period_'4'_period_'3'_period_'0 = _prefixId.prefix "K.4.3.0"
    /// <summary>
    ///   <para>rdfs:label : K.4.3.1. Computer-supported collaborative work^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.1">acm:K.4.3.1</a>
    /// </summary>
    let K'_period_'4'_period_'3'_period_'1 = _prefixId.prefix "K.4.3.1"
    /// <summary>
    ///   <para>rdfs:label : K.4.3.2. Employment^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.2">acm:K.4.3.2</a>
    /// </summary>
    let K'_period_'4'_period_'3'_period_'2 = _prefixId.prefix "K.4.3.2"
    /// <summary>
    ///   <para>rdfs:label : K.4.3.3. Reengineering^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.3.3">acm:K.4.3.3</a>
    /// </summary>
    let K'_period_'4'_period_'3'_period_'3 = _prefixId.prefix "K.4.3.3"
    /// <summary>
    ///   <para>rdfs:label : K.4.4. Electronic Commerce^^xsd:string</para>
    ///   <para>rdfs:comment : See also #J.1.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4">acm:K.4.4</a>
    /// </summary>
    let K'_period_'4'_period_'4 = _prefixId.prefix "K.4.4"
    /// <summary>
    ///   <para>rdfs:label : K.4.4.0. Cybercash, digital cash^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.0">acm:K.4.4.0</a>
    /// </summary>
    let K'_period_'4'_period_'4'_period_'0 = _prefixId.prefix "K.4.4.0"
    /// <summary>
    ///   <para>rdfs:label : K.4.4.1. Distributed commercial transactions^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.1">acm:K.4.4.1</a>
    /// </summary>
    let K'_period_'4'_period_'4'_period_'1 = _prefixId.prefix "K.4.4.1"
    /// <summary>
    ///   <para>rdfs:label : K.4.4.2. Electronic data interchange^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.2">acm:K.4.4.2</a>
    /// </summary>
    let K'_period_'4'_period_'4'_period_'2 = _prefixId.prefix "K.4.4.2"
    /// <summary>
    ///   <para>rdfs:label : K.4.4.3. Intellectual property^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.3">acm:K.4.4.3</a>
    /// </summary>
    let K'_period_'4'_period_'4'_period_'3 = _prefixId.prefix "K.4.4.3"
    /// <summary>
    ///   <para>rdfs:label : K.4.4.4. Payment schemes^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.4">acm:K.4.4.4</a>
    /// </summary>
    let K'_period_'4'_period_'4'_period_'4 = _prefixId.prefix "K.4.4.4"
    /// <summary>
    ///   <para>rdfs:label : K.4.4.5. Security^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.4.5">acm:K.4.4.5</a>
    /// </summary>
    let K'_period_'4'_period_'4'_period_'5 = _prefixId.prefix "K.4.4.5"
    /// <summary>
    ///   <para>rdfs:label : K.4.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.4.m">acm:K.4.m</a>
    /// </summary>
    let K'_period_'4'_period_'m = _prefixId.prefix "K.4.m"
    /// <summary>
    ///   <para>rdfs:label : K.5. LEGAL ASPECTS OF COMPUTING^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5">acm:K.5</a>
    /// </summary>
    let K'_period_'5 = _prefixId.prefix "K.5"
    /// <summary>
    ///   <para>rdfs:label : K.5.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.0">acm:K.5.0</a>
    /// </summary>
    let K'_period_'5'_period_'0 = _prefixId.prefix "K.5.0"
    /// <summary>
    ///   <para>rdfs:label : K.5.1. Hardware/Software Protection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1">acm:K.5.1</a>
    /// </summary>
    let K'_period_'5'_period_'1 = _prefixId.prefix "K.5.1"
    /// <summary>
    ///   <para>rdfs:label : K.5.1.0. Copyrights^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.0">acm:K.5.1.0</a>
    /// </summary>
    let K'_period_'5'_period_'1'_period_'0 = _prefixId.prefix "K.5.1.0"
    /// <summary>
    ///   <para>rdfs:label : K.5.1.1. Licensing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.1">acm:K.5.1.1</a>
    /// </summary>
    let K'_period_'5'_period_'1'_period_'1 = _prefixId.prefix "K.5.1.1"
    /// <summary>
    ///   <para>rdfs:label : K.5.1.2. Patents^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.2">acm:K.5.1.2</a>
    /// </summary>
    let K'_period_'5'_period_'1'_period_'2 = _prefixId.prefix "K.5.1.2"
    /// <summary>
    ///   <para>rdfs:label : K.5.1.3. Proprietary rights^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.3">acm:K.5.1.3</a>
    /// </summary>
    let K'_period_'5'_period_'1'_period_'3 = _prefixId.prefix "K.5.1.3"
    /// <summary>
    ///   <para>rdfs:label : K.5.1.4. Trade secrets^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.1.4">acm:K.5.1.4</a>
    /// </summary>
    let K'_period_'5'_period_'1'_period_'4 = _prefixId.prefix "K.5.1.4"
    /// <summary>
    ///   <para>rdfs:label : K.5.2. Governmental Issues^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2">acm:K.5.2</a>
    /// </summary>
    let K'_period_'5'_period_'2 = _prefixId.prefix "K.5.2"
    /// <summary>
    ///   <para>rdfs:label : K.5.2.0. Censorship^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.0">acm:K.5.2.0</a>
    /// </summary>
    let K'_period_'5'_period_'2'_period_'0 = _prefixId.prefix "K.5.2.0"
    /// <summary>
    ///   <para>rdfs:label : K.5.2.1. Regulation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.1">acm:K.5.2.1</a>
    /// </summary>
    let K'_period_'5'_period_'2'_period_'1 = _prefixId.prefix "K.5.2.1"
    /// <summary>
    ///   <para>rdfs:label : K.5.2.2. Taxation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.2.2">acm:K.5.2.2</a>
    /// </summary>
    let K'_period_'5'_period_'2'_period_'2 = _prefixId.prefix "K.5.2.2"
    /// <summary>
    ///   <para>rdfs:label : K.5.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m">acm:K.5.m</a>
    /// </summary>
    let K'_period_'5'_period_'m = _prefixId.prefix "K.5.m"
    /// <summary>
    ///   <para>rdfs:label : K.5.m.0. Contracts^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.0">acm:K.5.m.0</a>
    /// </summary>
    let K'_period_'5'_period_'m'_period_'0 = _prefixId.prefix "K.5.m.0"
    /// <summary>
    ///   <para>rdfs:label : K.5.m.1. Hardware patents^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.5.m.1">acm:K.5.m.1</a>
    /// </summary>
    let K'_period_'5'_period_'m'_period_'1 = _prefixId.prefix "K.5.m.1"
    /// <summary>
    ///   <para>rdfs:label : K.6. MANAGEMENT OF COMPUTING AND INFORMATION SYSTEMS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6">acm:K.6</a>
    /// </summary>
    let K'_period_'6 = _prefixId.prefix "K.6"
    /// <summary>
    ///   <para>rdfs:label : K.6.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0">acm:K.6.0</a>
    /// </summary>
    let K'_period_'6'_period_'0 = _prefixId.prefix "K.6.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.0.0. Economics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.0.0">acm:K.6.0.0</a>
    /// </summary>
    let K'_period_'6'_period_'0'_period_'0 = _prefixId.prefix "K.6.0.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.1. Project and People Management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1">acm:K.6.1</a>
    /// </summary>
    let K'_period_'6'_period_'1 = _prefixId.prefix "K.6.1"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.0. Life cycle^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.0">acm:K.6.1.0</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'0 = _prefixId.prefix "K.6.1.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.1. Management techniques^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.1">acm:K.6.1.1</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'1 = _prefixId.prefix "K.6.1.1"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.2. Staffing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.2">acm:K.6.1.2</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'2 = _prefixId.prefix "K.6.1.2"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.3. Strategic information systems planning^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.3">acm:K.6.1.3</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'3 = _prefixId.prefix "K.6.1.3"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.4. Systems analysis and design^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.4">acm:K.6.1.4</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'4 = _prefixId.prefix "K.6.1.4"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.5. Systems development^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.5">acm:K.6.1.5</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'5 = _prefixId.prefix "K.6.1.5"
    /// <summary>
    ///   <para>rdfs:label : K.6.1.6. Training^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.1.6">acm:K.6.1.6</a>
    /// </summary>
    let K'_period_'6'_period_'1'_period_'6 = _prefixId.prefix "K.6.1.6"
    /// <summary>
    ///   <para>rdfs:label : K.6.2. Installation Management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2">acm:K.6.2</a>
    /// </summary>
    let K'_period_'6'_period_'2 = _prefixId.prefix "K.6.2"
    /// <summary>
    ///   <para>rdfs:label : K.6.2.0. Benchmarks^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.0">acm:K.6.2.0</a>
    /// </summary>
    let K'_period_'6'_period_'2'_period_'0 = _prefixId.prefix "K.6.2.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.2.1. Computer selection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.1">acm:K.6.2.1</a>
    /// </summary>
    let K'_period_'6'_period_'2'_period_'1 = _prefixId.prefix "K.6.2.1"
    /// <summary>
    ///   <para>rdfs:label : K.6.2.2. Computing equipment management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.2">acm:K.6.2.2</a>
    /// </summary>
    let K'_period_'6'_period_'2'_period_'2 = _prefixId.prefix "K.6.2.2"
    /// <summary>
    ///   <para>rdfs:label : K.6.2.3. Performance and usage measurement^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.3">acm:K.6.2.3</a>
    /// </summary>
    let K'_period_'6'_period_'2'_period_'3 = _prefixId.prefix "K.6.2.3"
    /// <summary>
    ///   <para>rdfs:label : K.6.2.4. Pricing and resource allocation^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.2.4">acm:K.6.2.4</a>
    /// </summary>
    let K'_period_'6'_period_'2'_period_'4 = _prefixId.prefix "K.6.2.4"
    /// <summary>
    ///   <para>rdfs:label : K.6.3. Software Management^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.2.9.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3">acm:K.6.3</a>
    /// </summary>
    let K'_period_'6'_period_'3 = _prefixId.prefix "K.6.3"
    /// <summary>
    ///   <para>rdfs:label : K.6.3.0. Software development^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.0">acm:K.6.3.0</a>
    /// </summary>
    let K'_period_'6'_period_'3'_period_'0 = _prefixId.prefix "K.6.3.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.3.1. Software maintenance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.1">acm:K.6.3.1</a>
    /// </summary>
    let K'_period_'6'_period_'3'_period_'1 = _prefixId.prefix "K.6.3.1"
    /// <summary>
    ///   <para>rdfs:label : K.6.3.2. Software process^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.2">acm:K.6.3.2</a>
    /// </summary>
    let K'_period_'6'_period_'3'_period_'2 = _prefixId.prefix "K.6.3.2"
    /// <summary>
    ///   <para>rdfs:label : K.6.3.3. Software selection^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.3.3">acm:K.6.3.3</a>
    /// </summary>
    let K'_period_'6'_period_'3'_period_'3 = _prefixId.prefix "K.6.3.3"
    /// <summary>
    ///   <para>rdfs:label : K.6.4. System Management^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4">acm:K.6.4</a>
    /// </summary>
    let K'_period_'6'_period_'4 = _prefixId.prefix "K.6.4"
    /// <summary>
    ///   <para>rdfs:label : K.6.4.0. Centralization/decentralization^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.0">acm:K.6.4.0</a>
    /// </summary>
    let K'_period_'6'_period_'4'_period_'0 = _prefixId.prefix "K.6.4.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.4.1. Management audit^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.1">acm:K.6.4.1</a>
    /// </summary>
    let K'_period_'6'_period_'4'_period_'1 = _prefixId.prefix "K.6.4.1"
    /// <summary>
    ///   <para>rdfs:label : K.6.4.2. Quality assurance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.4.2">acm:K.6.4.2</a>
    /// </summary>
    let K'_period_'6'_period_'4'_period_'2 = _prefixId.prefix "K.6.4.2"
    /// <summary>
    ///   <para>rdfs:label : K.6.5. Security and Protection^^xsd:string</para>
    ///   <para>rdfs:comment : See also #D.4.6, #K.4.2.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5">acm:K.6.5</a>
    /// </summary>
    let K'_period_'6'_period_'5 = _prefixId.prefix "K.6.5"
    /// <summary>
    ///   <para>rdfs:label : K.6.5.0. Authentication^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.0">acm:K.6.5.0</a>
    /// </summary>
    let K'_period_'6'_period_'5'_period_'0 = _prefixId.prefix "K.6.5.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.5.1. Insurance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1991.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.1">acm:K.6.5.1</a>
    /// </summary>
    let K'_period_'6'_period_'5'_period_'1 = _prefixId.prefix "K.6.5.1"
    /// <summary>
    ///   <para>rdfs:label : K.6.5.2. Invasive software^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.2">acm:K.6.5.2</a>
    /// </summary>
    let K'_period_'6'_period_'5'_period_'2 = _prefixId.prefix "K.6.5.2"
    /// <summary>
    ///   <para>rdfs:label : K.6.5.3. Physical security^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.3">acm:K.6.5.3</a>
    /// </summary>
    let K'_period_'6'_period_'5'_period_'3 = _prefixId.prefix "K.6.5.3"
    /// <summary>
    ///   <para>rdfs:label : K.6.5.4. Unauthorized access^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.5.4">acm:K.6.5.4</a>
    /// </summary>
    let K'_period_'6'_period_'5'_period_'4 = _prefixId.prefix "K.6.5.4"
    /// <summary>
    ///   <para>rdfs:label : K.6.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m">acm:K.6.m</a>
    /// </summary>
    let K'_period_'6'_period_'m = _prefixId.prefix "K.6.m"
    /// <summary>
    ///   <para>rdfs:label : K.6.m.0. Insurance^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1991.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.0">acm:K.6.m.0</a>
    /// </summary>
    let K'_period_'6'_period_'m'_period_'0 = _prefixId.prefix "K.6.m.0"
    /// <summary>
    ///   <para>rdfs:label : K.6.m.1. Security^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1991.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.6.m.1">acm:K.6.m.1</a>
    /// </summary>
    let K'_period_'6'_period_'m'_period_'1 = _prefixId.prefix "K.6.m.1"
    /// <summary>
    ///   <para>rdfs:label : K.7. THE COMPUTING PROFESSION^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7">acm:K.7</a>
    /// </summary>
    let K'_period_'7 = _prefixId.prefix "K.7"
    /// <summary>
    ///   <para>rdfs:label : K.7.0. General^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.0">acm:K.7.0</a>
    /// </summary>
    let K'_period_'7'_period_'0 = _prefixId.prefix "K.7.0"
    /// <summary>
    ///   <para>rdfs:label : K.7.1. Occupations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.1">acm:K.7.1</a>
    /// </summary>
    let K'_period_'7'_period_'1 = _prefixId.prefix "K.7.1"
    /// <summary>
    ///   <para>rdfs:label : K.7.2. Organizations^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.2">acm:K.7.2</a>
    /// </summary>
    let K'_period_'7'_period_'2 = _prefixId.prefix "K.7.2"
    /// <summary>
    ///   <para>rdfs:label : K.7.3. Testing, Certification, and Licensing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.3">acm:K.7.3</a>
    /// </summary>
    let K'_period_'7'_period_'3 = _prefixId.prefix "K.7.3"
    /// <summary>
    ///   <para>rdfs:label : K.7.4. Professional Ethics^^xsd:string</para>
    ///   <para>rdfs:comment : See also #K.4.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4">acm:K.7.4</a>
    /// </summary>
    let K'_period_'7'_period_'4 = _prefixId.prefix "K.7.4"
    /// <summary>
    ///   <para>rdfs:label : K.7.4.0. Codes of ethics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.0">acm:K.7.4.0</a>
    /// </summary>
    let K'_period_'7'_period_'4'_period_'0 = _prefixId.prefix "K.7.4.0"
    /// <summary>
    ///   <para>rdfs:label : K.7.4.1. Codes of good practice^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.1">acm:K.7.4.1</a>
    /// </summary>
    let K'_period_'7'_period_'4'_period_'1 = _prefixId.prefix "K.7.4.1"
    /// <summary>
    ///   <para>rdfs:label : K.7.4.2. Ethical dilemmas^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.4.2">acm:K.7.4.2</a>
    /// </summary>
    let K'_period_'7'_period_'4'_period_'2 = _prefixId.prefix "K.7.4.2"
    /// <summary>
    ///   <para>rdfs:label : K.7.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m">acm:K.7.m</a>
    /// </summary>
    let K'_period_'7'_period_'m = _prefixId.prefix "K.7.m"
    /// <summary>
    ///   <para>rdfs:label : K.7.m.0. Codes of good practice^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.0">acm:K.7.m.0</a>
    /// </summary>
    let K'_period_'7'_period_'m'_period_'0 = _prefixId.prefix "K.7.m.0"
    /// <summary>
    ///   <para>rdfs:label : K.7.m.1. Ethics^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1998.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.7.m.1">acm:K.7.m.1</a>
    /// </summary>
    let K'_period_'7'_period_'m'_period_'1 = _prefixId.prefix "K.7.m.1"
    /// <summary>
    ///   <para>rdfs:label : K.8. PERSONAL COMPUTING^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8">acm:K.8</a>
    /// </summary>
    let K'_period_'8 = _prefixId.prefix "K.8"
    /// <summary>
    ///   <para>rdfs:label : K.8.0. Games^^xsd:stringrdfs:label : K.8.0. General^^xsd:string</para>
    ///   <para>rdfs:comment : Depricated, no longer used as of January 1991.^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0">acm:K.8.0</a>
    /// </summary>
    let K'_period_'8'_period_'0 = _prefixId.prefix "K.8.0"
    /// <summary>
    ///   <para>rdfs:label : K.8.0.0. Games^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.0.0">acm:K.8.0.0</a>
    /// </summary>
    let K'_period_'8'_period_'0'_period_'0 = _prefixId.prefix "K.8.0.0"
    /// <summary>
    ///   <para>rdfs:label : K.8.1. Application Packages^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1">acm:K.8.1</a>
    /// </summary>
    let K'_period_'8'_period_'1 = _prefixId.prefix "K.8.1"
    /// <summary>
    ///   <para>rdfs:label : K.8.1.0. Data communications^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.0">acm:K.8.1.0</a>
    /// </summary>
    let K'_period_'8'_period_'1'_period_'0 = _prefixId.prefix "K.8.1.0"
    /// <summary>
    ///   <para>rdfs:label : K.8.1.1. Database processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.1">acm:K.8.1.1</a>
    /// </summary>
    let K'_period_'8'_period_'1'_period_'1 = _prefixId.prefix "K.8.1.1"
    /// <summary>
    ///   <para>rdfs:label : K.8.1.2. Freeware/shareware^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.2">acm:K.8.1.2</a>
    /// </summary>
    let K'_period_'8'_period_'1'_period_'2 = _prefixId.prefix "K.8.1.2"
    /// <summary>
    ///   <para>rdfs:label : K.8.1.3. Graphics^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.3">acm:K.8.1.3</a>
    /// </summary>
    let K'_period_'8'_period_'1'_period_'3 = _prefixId.prefix "K.8.1.3"
    /// <summary>
    ///   <para>rdfs:label : K.8.1.4. Spreadsheets^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.4">acm:K.8.1.4</a>
    /// </summary>
    let K'_period_'8'_period_'1'_period_'4 = _prefixId.prefix "K.8.1.4"
    /// <summary>
    ///   <para>rdfs:label : K.8.1.5. Word processing^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.1.5">acm:K.8.1.5</a>
    /// </summary>
    let K'_period_'8'_period_'1'_period_'5 = _prefixId.prefix "K.8.1.5"
    /// <summary>
    ///   <para>rdfs:label : K.8.2. Hardware^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.2">acm:K.8.2</a>
    /// </summary>
    let K'_period_'8'_period_'2 = _prefixId.prefix "K.8.2"
    /// <summary>
    ///   <para>rdfs:label : K.8.3. Management/Maintenance^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.3">acm:K.8.3</a>
    /// </summary>
    let K'_period_'8'_period_'3 = _prefixId.prefix "K.8.3"
    /// <summary>
    ///   <para>rdfs:label : K.8.m. Miscellaneous^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.8.m">acm:K.8.m</a>
    /// </summary>
    let K'_period_'8'_period_'m = _prefixId.prefix "K.8.m"
    /// <summary>
    ///   <para>rdfs:label : K.m. MISCELLANEOUS^^xsd:string</para>
    ///   <a href="http://acm.rkbexplorer.com/ontologies/acm#K.m">acm:K.m</a>
    /// </summary>
    let K'_period_'m = _prefixId.prefix "K.m"
