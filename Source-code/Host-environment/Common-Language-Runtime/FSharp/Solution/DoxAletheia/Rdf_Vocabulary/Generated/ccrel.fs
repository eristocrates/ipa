namespace http.creativecommons.org.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ccrel =
    let _namespace_iri = Namespace_Iri ccrel |> NamespaceIRI
    /// <summary>
    ///   <para>ccrel:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>an action that may or
    /// 		    may not be requested of you</para>
    /// labels<para>Requirement</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Requirement">http://creativecommons.org/ns#Requirement</seealso>
    let Requirement = Prefixed_Name(ccrel, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Copyleft</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Requirement</para>
    ///   <para>derivative and
    /// 		    combined works must be licensed under specified
    /// 		    terms, similar to those on the original
    /// 		    work</para>
    /// labels<para>Copyleft</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Copyleft">http://creativecommons.org/ns#Copyleft</seealso>
    let Copyleft = Prefixed_Name(ccrel, "Copyleft") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:LesserCopyleft</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Requirement</para>
    ///   <para>derivative works must
    /// 		    be licensed under specified terms, with at least
    /// 		    the same conditions as the original work;
    /// 		    combinations with the work may be licensed under
    /// 		    different terms</para>
    /// labels<para>Lesser Copyleft</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#LesserCopyleft">http://creativecommons.org/ns#LesserCopyleft</seealso>
    let LesserCopyleft = Prefixed_Name(ccrel, "LesserCopyleft") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:deprecatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>deprecated
    /// 		  on</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#deprecatedOn">http://creativecommons.org/ns#deprecatedOn</seealso>
    let deprecatedOn = Prefixed_Name(ccrel, "deprecatedOn") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has
    /// 		  license</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#license">http://creativecommons.org/ns#license</seealso>
    let license = Prefixed_Name(ccrel, "license") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:permits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>permits</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#permits">http://creativecommons.org/ns#permits</seealso>
    let permits = Prefixed_Name(ccrel, "permits") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>requires</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#requires">http://creativecommons.org/ns#requires</seealso>
    let requires = Prefixed_Name(ccrel, "requires") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Prohibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>something you may be
    /// 		    asked not to do</para>
    /// labels<para>Prohibition</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Prohibition">http://creativecommons.org/ns#Prohibition</seealso>
    let Prohibition = Prefixed_Name(ccrel, "Prohibition") |> PrefixedName

    /// <summary>
    ///   <para>ccrel:HighIncomeNationUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Prohibition</para>
    ///   <para>use in a
    /// 		    non-developing country</para>
    /// labels<para>High Income Nation Use</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#HighIncomeNationUse">http://creativecommons.org/ns#HighIncomeNationUse</seealso>
    let HighIncomeNationUse =
        Prefixed_Name(ccrel, "HighIncomeNationUse") |> PrefixedName

    /// <summary>
    ///   <para>ccrel:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>a potentially
    /// 		    copyrightable work</para>
    /// labels<para>Work</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Work">http://creativecommons.org/ns#Work</seealso>
    let Work = Prefixed_Name(ccrel, "Work") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:attributionURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://creativecommons.org/ns#attributionURL">http://creativecommons.org/ns#attributionURL</seealso>
    let attributionURL = Prefixed_Name(ccrel, "attributionURL") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>an action that may or
    /// 		    may not be allowed or desired</para>
    /// labels<para>Permission</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Permission">http://creativecommons.org/ns#Permission</seealso>
    let Permission = Prefixed_Name(ccrel, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Permission</para>
    ///   <para>making multiple
    /// 		    copies</para>
    /// labels<para>Reproduction</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Reproduction">http://creativecommons.org/ns#Reproduction</seealso>
    let Reproduction = Prefixed_Name(ccrel, "Reproduction") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:ShareAlike</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Requirement</para>
    ///   <para>derivative works be
    /// 		    licensed under the same terms or compatible terms
    /// 		    as the original work</para>
    /// labels<para>Share Alike</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#ShareAlike">http://creativecommons.org/ns#ShareAlike</seealso>
    let ShareAlike = Prefixed_Name(ccrel, "ShareAlike") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Sharing</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Permission</para>
    ///   <para>permits commercial
    /// 		    derivatives, but only non-commercial
    /// 		    distribution</para>
    /// labels<para>Sharing</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Sharing">http://creativecommons.org/ns#Sharing</seealso>
    let Sharing = Prefixed_Name(ccrel, "Sharing") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:SourceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Requirement</para>
    ///   <para>source code (the
    /// 		    preferred form for making modifications) must be
    /// 		    provided when exercising some rights granted by
    /// 		    the license.</para>
    /// labels<para>Source Code</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#SourceCode">http://creativecommons.org/ns#SourceCode</seealso>
    let SourceCode = Prefixed_Name(ccrel, "SourceCode") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:attributionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://creativecommons.org/ns#attributionName">http://creativecommons.org/ns#attributionName</seealso>
    let attributionName = Prefixed_Name(ccrel, "attributionName") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>jurisdiction</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#jurisdiction">http://creativecommons.org/ns#jurisdiction</seealso>
    let jurisdiction = Prefixed_Name(ccrel, "jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:legalcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://creativecommons.org/ns#legalcode">http://creativecommons.org/ns#legalcode</seealso>
    let legalcode = Prefixed_Name(ccrel, "legalcode") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:morePermissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://creativecommons.org/ns#morePermissions">http://creativecommons.org/ns#morePermissions</seealso>
    let morePermissions = Prefixed_Name(ccrel, "morePermissions") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:prohibits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>prohibits</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#prohibits">http://creativecommons.org/ns#prohibits</seealso>
    let prohibits = Prefixed_Name(ccrel, "prohibits") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:useGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://creativecommons.org/ns#useGuidelines">http://creativecommons.org/ns#useGuidelines</seealso>
    let useGuidelines = Prefixed_Name(ccrel, "useGuidelines") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Requirement</para>
    ///   <para>credit be given to
    /// 		    copyright holder and/or author</para>
    /// labels<para>Attribution</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Attribution">http://creativecommons.org/ns#Attribution</seealso>
    let Attribution = Prefixed_Name(ccrel, "Attribution") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:CommercialUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Prohibition</para>
    ///   <para>exercising rights for
    /// 		    commercial purposes</para>
    /// labels<para>Commercial Use</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#CommercialUse">http://creativecommons.org/ns#CommercialUse</seealso>
    let CommercialUse = Prefixed_Name(ccrel, "CommercialUse") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:DerivativeWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Permission</para>
    ///   <para>distribution of
    /// 		    derivative works</para>
    /// labels<para>Derivative Works</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#DerivativeWorks">http://creativecommons.org/ns#DerivativeWorks</seealso>
    let DerivativeWorks = Prefixed_Name(ccrel, "DerivativeWorks") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Permission</para>
    ///   <para>distribution, public
    /// 		    display, and publicly performance</para>
    /// labels<para>Distribution</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Distribution">http://creativecommons.org/ns#Distribution</seealso>
    let Distribution = Prefixed_Name(ccrel, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>the legal jurisdiction
    /// 		    of a license</para>
    /// labels<para>Jurisdiction</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Jurisdiction">http://creativecommons.org/ns#Jurisdiction</seealso>
    let Jurisdiction = Prefixed_Name(ccrel, "Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>a set of
    /// 		    requests/permissions to users of a Work, e.g. a
    /// 		    copyright license, the public domain, information
    /// 		    for distributors</para>
    /// labels<para>License</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#License">http://creativecommons.org/ns#License</seealso>
    let License = Prefixed_Name(ccrel, "License") |> PrefixedName
    /// <summary>
    ///   <para>ccrel:Notice</para>
    /// </summary>
    /// <remarks>
    ///   <para>ccrel:Requirement</para>
    ///   <para>copyright and license
    /// 		    notices be kept intact</para>
    /// labels<para>Notice</para></remarks>
    /// <seealso href="http://creativecommons.org/ns#Notice">http://creativecommons.org/ns#Notice</seealso>
    let Notice = Prefixed_Name(ccrel, "Notice") |> PrefixedName
