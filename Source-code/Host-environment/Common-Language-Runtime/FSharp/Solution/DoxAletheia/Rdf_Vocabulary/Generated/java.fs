namespace http.www.w3.org._2007.uwa.context.java.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module java =
    let _namespace_iri = Namespace_Iri java |> NamespaceIRI
    /// <summary>
    ///   <para>java:AllSibling_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#AllSibling_Disjoint">http://www.w3.org/2007/uwa/context/java.owl#AllSibling_Disjoint</seealso>
    let AllSibling_Disjoint = Prefixed_Name(java, "AllSibling_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>java:CLCD10</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meConfiguration</para>
    ///   <para>"J2ME Connected, Limited Device Configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CLDC 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#CLCD10">http://www.w3.org/2007/uwa/context/java.owl#CLCD10</seealso>
    let CLCD10 = Prefixed_Name(java, "CLCD10") |> PrefixedName
    /// <summary>
    ///   <para>java:CLDC11</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meConfiguration</para>
    ///   <para>"Connected Limited Device Configuration 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CLDC 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#CLDC11">http://www.w3.org/2007/uwa/context/java.owl#CLDC11</seealso>
    let CLDC11 = Prefixed_Name(java, "CLDC11") |> PrefixedName
    /// <summary>
    ///   <para>java:Context_JavaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class subsumes all the classes that are related to the Java characteristics of a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Java Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#Context_JavaEntity">http://www.w3.org/2007/uwa/context/java.owl#Context_JavaEntity</seealso>
    let Context_JavaEntity = Prefixed_Name(java, "Context_JavaEntity") |> PrefixedName
    /// <summary>
    ///   <para>java:J2meConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents J2ME configurations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J2ME Configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#J2meConfiguration">http://www.w3.org/2007/uwa/context/java.owl#J2meConfiguration</seealso>
    let J2meConfiguration = Prefixed_Name(java, "J2meConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>java:J2meOptionalPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents standard optional packages that can run ina J2ME runtime environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J2ME Standard Optional Package"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#J2meOptionalPackage">http://www.w3.org/2007/uwa/context/java.owl#J2meOptionalPackage</seealso>
    let J2meOptionalPackage = Prefixed_Name(java, "J2meOptionalPackage") |> PrefixedName
    /// <summary>
    ///   <para>java:J2meProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents J2ME Profiles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J2ME Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#J2meProfile">http://www.w3.org/2007/uwa/context/java.owl#J2meProfile</seealso>
    let J2meProfile = Prefixed_Name(java, "J2meProfile") |> PrefixedName

    /// <summary>
    ///   <para>java:J2meRuntimeEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a J2ME runtime environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J2ME Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#J2meRuntimeEnvironment">http://www.w3.org/2007/uwa/context/java.owl#J2meRuntimeEnvironment</seealso>
    let J2meRuntimeEnvironment =
        Prefixed_Name(java, "J2meRuntimeEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>java:JSR120</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meOptionalPackage</para>
    ///   <para>"Wireless Messaging API"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JSR 120"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JSR120">http://www.w3.org/2007/uwa/context/java.owl#JSR120</seealso>
    let JSR120 = Prefixed_Name(java, "JSR120") |> PrefixedName
    /// <summary>
    ///   <para>java:JSR135</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meOptionalPackage</para>
    ///   <para>"JSR-135"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JSR135">http://www.w3.org/2007/uwa/context/java.owl#JSR135</seealso>
    let JSR135 = Prefixed_Name(java, "JSR135") |> PrefixedName
    /// <summary>
    ///   <para>java:JSR179</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meOptionalPackage</para>
    ///   <para>"JSR-179"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JSR179">http://www.w3.org/2007/uwa/context/java.owl#JSR179</seealso>
    let JSR179 = Prefixed_Name(java, "JSR179") |> PrefixedName
    /// <summary>
    ///   <para>java:JSR82</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meOptionalPackage</para>
    ///   <para>"JSR-82"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JSR82">http://www.w3.org/2007/uwa/context/java.owl#JSR82</seealso>
    let JSR82 = Prefixed_Name(java, "JSR82") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents Java Platforms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Java Platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform</seealso>
    let JavaPlatform = Prefixed_Name(java, "JavaPlatform") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:JavaPlatform</para>
    ///   <para>"J2SE 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_2">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_2</seealso>
    let JavaPlatform_2 = Prefixed_Name(java, "JavaPlatform_2") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:JavaPlatform</para>
    ///   <para>"J2SE 1.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_3">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_3</seealso>
    let JavaPlatform_3 = Prefixed_Name(java, "JavaPlatform_3") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:JavaPlatform</para>
    ///   <para>"J2SE 1.3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_4">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_4</seealso>
    let JavaPlatform_4 = Prefixed_Name(java, "JavaPlatform_4") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:JavaPlatform</para>
    ///   <para>"J2SE 1.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_5">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_5</seealso>
    let JavaPlatform_5 = Prefixed_Name(java, "JavaPlatform_5") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform_7</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:JavaPlatform</para>
    ///   <para>"J2EE 1.4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_7">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_7</seealso>
    let JavaPlatform_7 = Prefixed_Name(java, "JavaPlatform_7") |> PrefixedName
    /// <summary>
    ///   <para>java:JavaPlatform_J2ME</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:JavaPlatform</para>
    ///   <para>"Java Platform, Micro Edition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Java ME"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_J2ME">http://www.w3.org/2007/uwa/context/java.owl#JavaPlatform_J2ME</seealso>
    let JavaPlatform_J2ME = Prefixed_Name(java, "JavaPlatform_J2ME") |> PrefixedName

    /// <summary>
    ///   <para>java:JavaRuntimeEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents Java Runtime Environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Java Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#JavaRuntimeEnvironment">http://www.w3.org/2007/uwa/context/java.owl#JavaRuntimeEnvironment</seealso>
    let JavaRuntimeEnvironment =
        Prefixed_Name(java, "JavaRuntimeEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>java:MIDP10</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meProfile</para>
    ///   <para>"Mobile Information Device Profile (MIDP)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MIDP 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#MIDP10">http://www.w3.org/2007/uwa/context/java.owl#MIDP10</seealso>
    let MIDP10 = Prefixed_Name(java, "MIDP10") |> PrefixedName
    /// <summary>
    ///   <para>java:MIDP20</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meProfile</para>
    ///   <para>"Mobile Information Device Profile 2.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MIDP 2.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#MIDP20">http://www.w3.org/2007/uwa/context/java.owl#MIDP20</seealso>
    let MIDP20 = Prefixed_Name(java, "MIDP20") |> PrefixedName
    /// <summary>
    ///   <para>java:Sibling_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    ///
    /// labels<para>"Java Disjoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#Sibling_Disjoint">http://www.w3.org/2007/uwa/context/java.owl#Sibling_Disjoint</seealso>
    let Sibling_Disjoint = Prefixed_Name(java, "Sibling_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>java:Sibling_Disjoint2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#Sibling_Disjoint2">http://www.w3.org/2007/uwa/context/java.owl#Sibling_Disjoint2</seealso>
    let Sibling_Disjoint2 = Prefixed_Name(java, "Sibling_Disjoint2") |> PrefixedName
    /// <summary>
    ///   <para>java:TermGroup_Java</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>"These terms model a minimal set of properties and classes that allow to represent the features of a Delivery Context related to the support of Java technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Java"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#TermGroup_Java">http://www.w3.org/2007/uwa/context/java.owl#TermGroup_Java</seealso>
    let TermGroup_Java = Prefixed_Name(java, "TermGroup_Java") |> PrefixedName
    /// <summary>
    ///   <para>java:availableJREs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The available Java Runtime Environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Available Java Runtime Environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#availableJREs">http://www.w3.org/2007/uwa/context/java.owl#availableJREs</seealso>
    let availableJREs = Prefixed_Name(java, "availableJREs") |> PrefixedName
    /// <summary>
    ///   <para>java:defaultJRE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The default Java Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Java Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#defaultJRE">http://www.w3.org/2007/uwa/context/java.owl#defaultJRE</seealso>
    let defaultJRE = Prefixed_Name(java, "defaultJRE") |> PrefixedName
    /// <summary>
    ///   <para>java:j2meConfigurations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The supported J2ME configurations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported J2ME Configurations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#j2meConfigurations">http://www.w3.org/2007/uwa/context/java.owl#j2meConfigurations</seealso>
    let j2meConfigurations = Prefixed_Name(java, "j2meConfigurations") |> PrefixedName

    /// <summary>
    ///   <para>java:j2meOptionalPackages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The optional packages that makes available a J2ME runtime environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"J2ME Optional Packages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#j2meOptionalPackages">http://www.w3.org/2007/uwa/context/java.owl#j2meOptionalPackages</seealso>
    let j2meOptionalPackages =
        Prefixed_Name(java, "j2meOptionalPackages") |> PrefixedName

    /// <summary>
    ///   <para>java:j2meProfiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The supported J2ME profiles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported J2ME Profiles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#j2meProfiles">http://www.w3.org/2007/uwa/context/java.owl#j2meProfiles</seealso>
    let j2meProfiles = Prefixed_Name(java, "j2meProfiles") |> PrefixedName
    /// <summary>
    ///   <para>java:javaPlatforms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Java  Platforms supported by a Java Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Java Platforms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#javaPlatforms">http://www.w3.org/2007/uwa/context/java.owl#javaPlatforms</seealso>
    let javaPlatforms = Prefixed_Name(java, "javaPlatforms") |> PrefixedName
    /// <summary>
    ///   <para>java:jsr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The JSR specification id that corresponds to a Java Technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JSR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#jsr">http://www.w3.org/2007/uwa/context/java.owl#jsr</seealso>
    let jsr = Prefixed_Name(java, "jsr") |> PrefixedName
    /// <summary>
    ///   <para>java:maxHeapSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The maximum heap size in bytes supported by a Java Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Heap Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#maxHeapSize">http://www.w3.org/2007/uwa/context/java.owl#maxHeapSize</seealso>
    let maxHeapSize = Prefixed_Name(java, "maxHeapSize") |> PrefixedName
    /// <summary>
    ///   <para>java:maxJarSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum JAR size for a Java Application supported by a Java Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum JAR size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#maxJarSize">http://www.w3.org/2007/uwa/context/java.owl#maxJarSize</seealso>
    let maxJarSize = Prefixed_Name(java, "maxJarSize") |> PrefixedName

    /// <summary>
    ///   <para>java:totalMemoryForJavaApps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicates the device's maximum size in bytes for storing Java applications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JavaMaxMemorySize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/java.owl#totalMemoryForJavaApps">http://www.w3.org/2007/uwa/context/java.owl#totalMemoryForJavaApps</seealso>
    let totalMemoryForJavaApps =
        Prefixed_Name(java, "totalMemoryForJavaApps") |> PrefixedName
