namespace http.creativecommons.org.ns.hash

open DoxAletheia

module ccrel =
    let _namespace_name = "http://creativecommons.org/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// credit be given to
    /// 		    copyright holder and/or author
    /// <see href="http://creativecommons.org/ns#Attribution"></see></summary>
    let Attribution = _prefix "Attribution"
    /// <summary>
    /// an action that may or
    /// 		    may not be requested of you
    /// <see href="http://creativecommons.org/ns#Requirement"></see></summary>
    let Requirement = _prefix "Requirement"
    /// <summary>
    /// exercising rights for
    /// 		    commercial purposes
    /// <see href="http://creativecommons.org/ns#CommercialUse"></see></summary>
    let CommercialUse = _prefix "CommercialUse"
    /// <summary>
    /// something you may be
    /// 		    asked not to do
    /// <see href="http://creativecommons.org/ns#Prohibition"></see></summary>
    let Prohibition = _prefix "Prohibition"
    /// <summary>
    /// derivative and
    /// 		    combined works must be licensed under specified
    /// 		    terms, similar to those on the original
    /// 		    work
    /// <see href="http://creativecommons.org/ns#Copyleft"></see></summary>
    let Copyleft = _prefix "Copyleft"
    /// <summary>
    /// distribution of
    /// 		    derivative works
    /// <see href="http://creativecommons.org/ns#DerivativeWorks"></see></summary>
    let DerivativeWorks = _prefix "DerivativeWorks"
    /// <summary>
    /// an action that may or
    /// 		    may not be allowed or desired
    /// <see href="http://creativecommons.org/ns#Permission"></see></summary>
    let Permission = _prefix "Permission"
    /// <summary>
    /// distribution, public
    /// 		    display, and publicly performance
    /// <see href="http://creativecommons.org/ns#Distribution"></see></summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    /// use in a
    /// 		    non-developing country
    /// <see href="http://creativecommons.org/ns#HighIncomeNationUse"></see></summary>
    let HighIncomeNationUse = _prefix "HighIncomeNationUse"
    /// <summary>
    /// the legal jurisdiction
    /// 		    of a license
    /// <see href="http://creativecommons.org/ns#Jurisdiction"></see></summary>
    let Jurisdiction = _prefix "Jurisdiction"
    /// <summary>
    /// derivative works must
    /// 		    be licensed under specified terms, with at least
    /// 		    the same conditions as the original work;
    /// 		    combinations with the work may be licensed under
    /// 		    different terms
    /// <see href="http://creativecommons.org/ns#LesserCopyleft"></see></summary>
    let LesserCopyleft = _prefix "LesserCopyleft"
    /// <summary>
    /// a set of
    /// 		    requests/permissions to users of a Work, e.g. a
    /// 		    copyright license, the public domain, information
    /// 		    for distributors
    /// <see href="http://creativecommons.org/ns#License"></see></summary>
    let License = _prefix "License"
    /// <summary>
    /// copyright and license
    /// 		    notices be kept intact
    /// <see href="http://creativecommons.org/ns#Notice"></see></summary>
    let Notice = _prefix "Notice"
    /// <summary>
    /// making multiple
    /// 		    copies
    /// <see href="http://creativecommons.org/ns#Reproduction"></see></summary>
    let Reproduction = _prefix "Reproduction"
    /// <summary>
    /// derivative works be
    /// 		    licensed under the same terms or compatible terms
    /// 		    as the original work
    /// <see href="http://creativecommons.org/ns#ShareAlike"></see></summary>
    let ShareAlike = _prefix "ShareAlike"
    /// <summary>
    /// permits commercial
    /// 		    derivatives, but only non-commercial
    /// 		    distribution
    /// <see href="http://creativecommons.org/ns#Sharing"></see></summary>
    let Sharing = _prefix "Sharing"
    /// <summary>
    /// source code (the
    /// 		    preferred form for making modifications) must be
    /// 		    provided when exercising some rights granted by
    /// 		    the license.
    /// <see href="http://creativecommons.org/ns#SourceCode"></see></summary>
    let SourceCode = _prefix "SourceCode"
    /// <summary>
    /// a potentially
    /// 		    copyrightable work
    /// <see href="http://creativecommons.org/ns#Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#attributionName"></see>
    /// </summary>
    let attributionName = _prefix "attributionName"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#attributionURL"></see>
    /// </summary>
    let attributionURL = _prefix "attributionURL"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#deprecatedOn"></see>
    /// </summary>
    let deprecatedOn = _prefix "deprecatedOn"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#jurisdiction"></see>
    /// </summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#legalcode"></see>
    /// </summary>
    let legalcode = _prefix "legalcode"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#license"></see>
    /// </summary>
    let license = _prefix "license"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#morePermissions"></see>
    /// </summary>
    let morePermissions = _prefix "morePermissions"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#permits"></see>
    /// </summary>
    let permits = _prefix "permits"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#prohibits"></see>
    /// </summary>
    let prohibits = _prefix "prohibits"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#requires"></see>
    /// </summary>
    let requires = _prefix "requires"
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#useGuidelines"></see>
    /// </summary>
    let useGuidelines = _prefix "useGuidelines"
