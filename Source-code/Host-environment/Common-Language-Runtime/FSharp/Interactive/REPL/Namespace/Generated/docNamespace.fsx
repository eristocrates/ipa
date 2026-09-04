#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module doc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2000/10/swap/pim/doc#" "doc"

    let OpenSourceLicense = _prefixId.prefix "OpenSourceLicense"
    /// <summary>
    ///   <para>rdfs:label : work^^xsd:string</para>
    ///   <para>rdfs:comment : An abstract information thing of value, typically intellectual property^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#Work">doc:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : administrative page^^xsd:string</para>
    ///   <para>rdfs:comment : A web page allowing a human user to administer this work,
    ///             for example changing access control, version control information etc.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#adminPage">doc:adminPage</a>
    /// </summary>
    let adminPage = _prefixId.prefix "adminPage"
    /// <summary>
    ///   <para>rdfs:label : creator^^xsd:string</para>
    ///   <para>rdfs:comment : The person (not string) who created this.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#creator">doc:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : depends on^^xsd:string</para>
    ///   <para>rdfs:comment : The meaning or value of this work depends on that of that work.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#dependsOn">doc:dependsOn</a>
    /// </summary>
    let dependsOn = _prefixId.prefix "dependsOn"
    /// <summary>
    ///   <para>rdfs:label : derivative work^^xsd:string</para>
    ///   <para>rdfs:comment : A work wholey or partly used in the creation of this one.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#derivativeWork">doc:derivativeWork</a>
    /// </summary>
    let derivativeWork = _prefixId.prefix "derivativeWork"
    /// <summary>
    ///   <para>rdfs:label : derived from^^xsd:string</para>
    ///   <para>rdfs:comment : A work wholey or partly used in the creation of this one.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#derivedFrom">doc:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    /// <summary>
    ///   <para>rdfs:label : rights^^xsd:string</para>
    ///   <para>rdfs:comment : Terms and intellectual property rights licensing conditions.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#ipr">doc:ipr</a>
    /// </summary>
    let ipr = _prefixId.prefix "ipr"
    /// <summary>
    ///   <para>rdfs:label : may control^^xsd:string</para>
    ///   <para>rdfs:comment : This may change that access control for that^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#mayControl">doc:mayControl</a>
    /// </summary>
    let mayControl = _prefixId.prefix "mayControl"
    /// <summary>
    ///   <para>rdfs:label : may read^^xsd:string</para>
    ///   <para>rdfs:comment : This may access that for read -- compare 'r' unix^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#mayRead">doc:mayRead</a>
    /// </summary>
    let mayRead = _prefixId.prefix "mayRead"
    /// <summary>
    ///   <para>rdfs:label : may write^^xsd:string</para>
    ///   <para>rdfs:comment : This may access that to modify it -- compare 'w' unix^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#mayWrite">doc:mayWrite</a>
    /// </summary>
    let mayWrite = _prefixId.prefix "mayWrite"
    /// <summary>
    ///   <para>rdfs:label : obsoletes^^xsd:string</para>
    ///   <para>rdfs:comment : This work is more upto date than that and makes it obsolete.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#obsoletes">doc:obsoletes</a>
    /// </summary>
    let obsoletes = _prefixId.prefix "obsoletes"
    /// <summary>
    ///   <para>rdfs:label : persistence policy^^xsd:string</para>
    ///   <para>rdfs:comment : Publishers policy regarding the peristence of the mapping
    ///                 between URI and its meaning and/or representation in bits.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#persistencePolicy">doc:persistencePolicy</a>
    /// </summary>
    let persistencePolicy = _prefixId.prefix "persistencePolicy"
    /// <summary>
    ///   <para>rdfs:label : rules^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 	The subject is a namespace document; the object is a document
    /// 	containing rules. The rules are valid information about the terms
    /// 	defined in the namespace document.
    /// 	^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#rules">doc:rules</a>
    /// </summary>
    let rules = _prefixId.prefix "rules"
    /// <summary>
    ///   <para>rdfs:label : sub-license^^xsd:string</para>
    ///   <para>rdfs:comment : For any license, a sublicense is a licensing offering a subset of the rights.
    /// If A doc:sublicense B then anything under license A can be released under
    /// licence B.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#subLicense">doc:subLicense</a>
    /// </summary>
    let subLicense = _prefixId.prefix "subLicense"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : This generic work has a specific version in the
    /// 	follwing specific document^^xsd:stringrdfs:comment : This version of this document (eg number, date, etc). A string^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#version">doc:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:comment : This work is a a specific version of the follwing generic document.
    /// 		OBSOLETE - use its inverse, version.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/pim/doc#versionOf">doc:versionOf</a>
    /// </summary>
    let versionOf = _prefixId.prefix "versionOf"
