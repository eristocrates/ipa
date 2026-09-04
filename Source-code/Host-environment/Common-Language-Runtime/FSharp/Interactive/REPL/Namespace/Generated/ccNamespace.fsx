#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://creativecommons.org/ns#" "cc"
    let Attribution = _prefixId.prefix "Attribution"
    let CommercialUse = _prefixId.prefix "CommercialUse"
    let Copyleft = _prefixId.prefix "Copyleft"
    let DerivativeWorks = _prefixId.prefix "DerivativeWorks"
    let Distribution = _prefixId.prefix "Distribution"
    let HighIncomeNationUse = _prefixId.prefix "HighIncomeNationUse"
    /// <summary>
    ///   <para>rdfs:comment : the legal jurisdiction
    /// 		    of a license</para>
    ///   <para>rdfs:label : Jurisdiction</para>
    ///   <a href="http://creativecommons.org/ns#Jurisdiction">cc:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = _prefixId.prefix "Jurisdiction"
    let LesserCopyleft = _prefixId.prefix "LesserCopyleft"
    /// <summary>
    ///   <para>rdfs:comment : a set of
    /// 		    requests/permissions to users of a Work, e.g. a
    /// 		    copyright license, the public domain, information
    /// 		    for distributors</para>
    ///   <para>rdfs:label : License</para>
    ///   <a href="http://creativecommons.org/ns#License">cc:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    let Notice = _prefixId.prefix "Notice"
    /// <summary>
    ///   <para>rdfs:comment : an action that may or
    /// 		    may not be allowed or desired</para>
    ///   <para>rdfs:label : Permission</para>
    ///   <a href="http://creativecommons.org/ns#Permission">cc:Permission</a>
    /// </summary>
    let Permission = _prefixId.prefix "Permission"
    /// <summary>
    ///   <para>rdfs:comment : something you may be
    /// 		    asked not to do</para>
    ///   <para>rdfs:label : Prohibition</para>
    ///   <a href="http://creativecommons.org/ns#Prohibition">cc:Prohibition</a>
    /// </summary>
    let Prohibition = _prefixId.prefix "Prohibition"
    let Reproduction = _prefixId.prefix "Reproduction"
    /// <summary>
    ///   <para>rdfs:comment : an action that may or
    /// 		    may not be requested of you</para>
    ///   <para>rdfs:label : Requirement</para>
    ///   <a href="http://creativecommons.org/ns#Requirement">cc:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    let ShareAlike = _prefixId.prefix "ShareAlike"
    let Sharing = _prefixId.prefix "Sharing"
    let SourceCode = _prefixId.prefix "SourceCode"
    /// <summary>
    ///   <para>rdfs:comment : a potentially
    /// 		    copyrightable work</para>
    ///   <para>rdfs:label : Work</para>
    ///   <a href="http://creativecommons.org/ns#Work">cc:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    let attributionName = _prefixId.prefix "attributionName"
    let attributionURL = _prefixId.prefix "attributionURL"
    /// <summary>
    ///   <para>rdfs:label : deprecated
    /// 		  on</para>
    ///   <a href="http://creativecommons.org/ns#deprecatedOn">cc:deprecatedOn</a>
    /// </summary>
    let deprecatedOn = _prefixId.prefix "deprecatedOn"
    /// <summary>
    ///   <para>rdfs:label : jurisdiction</para>
    ///   <a href="http://creativecommons.org/ns#jurisdiction">cc:jurisdiction</a>
    /// </summary>
    let jurisdiction = _prefixId.prefix "jurisdiction"
    let legalcode = _prefixId.prefix "legalcode"
    /// <summary>
    ///   <para>rdfs:label : has
    /// 		  license</para>
    ///   <a href="http://creativecommons.org/ns#license">cc:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    let morePermissions = _prefixId.prefix "morePermissions"
    /// <summary>
    ///   <para>rdfs:label : permits</para>
    ///   <a href="http://creativecommons.org/ns#permits">cc:permits</a>
    /// </summary>
    let permits = _prefixId.prefix "permits"
    /// <summary>
    ///   <para>rdfs:label : prohibits</para>
    ///   <a href="http://creativecommons.org/ns#prohibits">cc:prohibits</a>
    /// </summary>
    let prohibits = _prefixId.prefix "prohibits"
    /// <summary>
    ///   <para>rdfs:label : requires</para>
    ///   <a href="http://creativecommons.org/ns#requires">cc:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    let useGuidelines = _prefixId.prefix "useGuidelines"
