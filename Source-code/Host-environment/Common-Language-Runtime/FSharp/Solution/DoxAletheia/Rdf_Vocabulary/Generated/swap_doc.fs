namespace http.www.w3.org._2000._10.swap.pim.doc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swap_doc =
    let _namespace_iri = Namespace_Iri swap_doc |> NamespaceIRI
    /// <summary>
    ///   <para>swap_doc:OpenSourceLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Class of licenses which can be called Open Soutrce
    ///                 according to opensource.org"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Opem Source licence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#OpenSourceLicense">http://www.w3.org/2000/10/swap/pim/doc#OpenSourceLicense</seealso>
    let OpenSourceLicense = Prefixed_Name(swap_doc, "OpenSourceLicense") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract information thing of value, typically intellectual property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#Work">http://www.w3.org/2000/10/swap/pim/doc#Work</seealso>
    let Work = Prefixed_Name(swap_doc, "Work") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:adminPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A web page allowing a human user to administer this work,
    ///             for example changing access control, version control information etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"administrative page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#adminPage">http://www.w3.org/2000/10/swap/pim/doc#adminPage</seealso>
    let adminPage = Prefixed_Name(swap_doc, "adminPage") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The person (not string) who created this."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#creator">http://www.w3.org/2000/10/swap/pim/doc#creator</seealso>
    let creator = Prefixed_Name(swap_doc, "creator") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The meaning or value of this work depends on that of that work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"depends on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#dependsOn">http://www.w3.org/2000/10/swap/pim/doc#dependsOn</seealso>
    let dependsOn = Prefixed_Name(swap_doc, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:derivativeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A work wholey or partly used in the creation of this one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"derivative work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#derivativeWork">http://www.w3.org/2000/10/swap/pim/doc#derivativeWork</seealso>
    let derivativeWork = Prefixed_Name(swap_doc, "derivativeWork") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A work wholey or partly used in the creation of this one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"derived from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#derivedFrom">http://www.w3.org/2000/10/swap/pim/doc#derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(swap_doc, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:ipr</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Terms and intellectual property rights licensing conditions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#ipr">http://www.w3.org/2000/10/swap/pim/doc#ipr</seealso>
    let ipr = Prefixed_Name(swap_doc, "ipr") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:mayControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This may change that access control for that"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"may control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#mayControl">http://www.w3.org/2000/10/swap/pim/doc#mayControl</seealso>
    let mayControl = Prefixed_Name(swap_doc, "mayControl") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:mayRead</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This may access that for read -- compare 'r' unix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"may read"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#mayRead">http://www.w3.org/2000/10/swap/pim/doc#mayRead</seealso>
    let mayRead = Prefixed_Name(swap_doc, "mayRead") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:mayWrite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This may access that to modify it -- compare 'w' unix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"may write"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#mayWrite">http://www.w3.org/2000/10/swap/pim/doc#mayWrite</seealso>
    let mayWrite = Prefixed_Name(swap_doc, "mayWrite") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:obsoletes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This work is more upto date than that and makes it obsolete."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"obsoletes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#obsoletes">http://www.w3.org/2000/10/swap/pim/doc#obsoletes</seealso>
    let obsoletes = Prefixed_Name(swap_doc, "obsoletes") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:persistencePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Publishers policy regarding the peristence of the mapping
    ///                 between URI and its meaning and/or representation in bits."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"persistence policy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#persistencePolicy">http://www.w3.org/2000/10/swap/pim/doc#persistencePolicy</seealso>
    let persistencePolicy = Prefixed_Name(swap_doc, "persistencePolicy") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:rules</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"
    /// 	The subject is a namespace document; the object is a document
    /// 	containing rules. The rules are valid information about the terms
    /// 	defined in the namespace document.
    /// 	"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#rules">http://www.w3.org/2000/10/swap/pim/doc#rules</seealso>
    let rules = Prefixed_Name(swap_doc, "rules") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:subLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"For any license, a sublicense is a licensing offering a subset of the rights.
    /// If A doc:sublicense B then anything under license A can be released under
    /// licence B."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sub-license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#subLicense">http://www.w3.org/2000/10/swap/pim/doc#subLicense</seealso>
    let subLicense = Prefixed_Name(swap_doc, "subLicense") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This version of this document (eg number, date, etc). A string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This generic work has a specific version in the
    /// 	follwing specific document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#version">http://www.w3.org/2000/10/swap/pim/doc#version</seealso>
    let version = Prefixed_Name(swap_doc, "version") |> PrefixedName
    /// <summary>
    ///   <para>swap_doc:versionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This work is a a specific version of the follwing generic document.
    /// 		OBSOLETE - use its inverse, version."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/doc#versionOf">http://www.w3.org/2000/10/swap/pim/doc#versionOf</seealso>
    let versionOf = Prefixed_Name(swap_doc, "versionOf") |> PrefixedName
