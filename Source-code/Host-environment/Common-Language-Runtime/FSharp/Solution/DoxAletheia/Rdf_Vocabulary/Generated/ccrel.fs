namespace http.creativecommons.org.ns.hash

open DoxAletheia.Rdf_Vocabulary

module ccrel =
    let _namespace_name = "http://creativecommons.org/ns#"

    /// <summary>
    /// credit be given to
    /// 		    copyright holder and/or author
    /// <see href="http://creativecommons.org/ns#Attribution"></see></summary>
    let Attribution =
        Namespaced_IRI.parse _namespace_name "Attribution" |> NamespacedName

    /// <summary>
    /// an action that may or
    /// 		    may not be requested of you
    /// <see href="http://creativecommons.org/ns#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    /// exercising rights for
    /// 		    commercial purposes
    /// <see href="http://creativecommons.org/ns#CommercialUse"></see></summary>
    let CommercialUse =
        Namespaced_IRI.parse _namespace_name "CommercialUse" |> NamespacedName

    /// <summary>
    /// something you may be
    /// 		    asked not to do
    /// <see href="http://creativecommons.org/ns#Prohibition"></see></summary>
    let Prohibition =
        Namespaced_IRI.parse _namespace_name "Prohibition" |> NamespacedName

    /// <summary>
    /// derivative and
    /// 		    combined works must be licensed under specified
    /// 		    terms, similar to those on the original
    /// 		    work
    /// <see href="http://creativecommons.org/ns#Copyleft"></see></summary>
    let Copyleft = Namespaced_IRI.parse _namespace_name "Copyleft" |> NamespacedName

    /// <summary>
    /// distribution of
    /// 		    derivative works
    /// <see href="http://creativecommons.org/ns#DerivativeWorks"></see></summary>
    let DerivativeWorks =
        Namespaced_IRI.parse _namespace_name "DerivativeWorks" |> NamespacedName

    /// <summary>
    /// an action that may or
    /// 		    may not be allowed or desired
    /// <see href="http://creativecommons.org/ns#Permission"></see></summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName

    /// <summary>
    /// distribution, public
    /// 		    display, and publicly performance
    /// <see href="http://creativecommons.org/ns#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    /// use in a
    /// 		    non-developing country
    /// <see href="http://creativecommons.org/ns#HighIncomeNationUse"></see></summary>
    let HighIncomeNationUse =
        Namespaced_IRI.parse _namespace_name "HighIncomeNationUse" |> NamespacedName

    /// <summary>
    /// the legal jurisdiction
    /// 		    of a license
    /// <see href="http://creativecommons.org/ns#Jurisdiction"></see></summary>
    let Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Jurisdiction" |> NamespacedName

    /// <summary>
    /// derivative works must
    /// 		    be licensed under specified terms, with at least
    /// 		    the same conditions as the original work;
    /// 		    combinations with the work may be licensed under
    /// 		    different terms
    /// <see href="http://creativecommons.org/ns#LesserCopyleft"></see></summary>
    let LesserCopyleft =
        Namespaced_IRI.parse _namespace_name "LesserCopyleft" |> NamespacedName

    /// <summary>
    /// a set of
    /// 		    requests/permissions to users of a Work, e.g. a
    /// 		    copyright license, the public domain, information
    /// 		    for distributors
    /// <see href="http://creativecommons.org/ns#License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    /// copyright and license
    /// 		    notices be kept intact
    /// <see href="http://creativecommons.org/ns#Notice"></see></summary>
    let Notice = Namespaced_IRI.parse _namespace_name "Notice" |> NamespacedName

    /// <summary>
    /// making multiple
    /// 		    copies
    /// <see href="http://creativecommons.org/ns#Reproduction"></see></summary>
    let Reproduction =
        Namespaced_IRI.parse _namespace_name "Reproduction" |> NamespacedName

    /// <summary>
    /// derivative works be
    /// 		    licensed under the same terms or compatible terms
    /// 		    as the original work
    /// <see href="http://creativecommons.org/ns#ShareAlike"></see></summary>
    let ShareAlike = Namespaced_IRI.parse _namespace_name "ShareAlike" |> NamespacedName
    /// <summary>
    /// permits commercial
    /// 		    derivatives, but only non-commercial
    /// 		    distribution
    /// <see href="http://creativecommons.org/ns#Sharing"></see></summary>
    let Sharing = Namespaced_IRI.parse _namespace_name "Sharing" |> NamespacedName
    /// <summary>
    /// source code (the
    /// 		    preferred form for making modifications) must be
    /// 		    provided when exercising some rights granted by
    /// 		    the license.
    /// <see href="http://creativecommons.org/ns#SourceCode"></see></summary>
    let SourceCode = Namespaced_IRI.parse _namespace_name "SourceCode" |> NamespacedName
    /// <summary>
    /// a potentially
    /// 		    copyrightable work
    /// <see href="http://creativecommons.org/ns#Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#attributionName"></see>
    /// </summary>
    let attributionName =
        Namespaced_IRI.parse _namespace_name "attributionName" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#attributionURL"></see>
    /// </summary>
    let attributionURL =
        Namespaced_IRI.parse _namespace_name "attributionURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#deprecatedOn"></see>
    /// </summary>
    let deprecatedOn =
        Namespaced_IRI.parse _namespace_name "deprecatedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#jurisdiction"></see>
    /// </summary>
    let jurisdiction =
        Namespaced_IRI.parse _namespace_name "jurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#legalcode"></see>
    /// </summary>
    let legalcode = Namespaced_IRI.parse _namespace_name "legalcode" |> NamespacedName
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#license"></see>
    /// </summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#morePermissions"></see>
    /// </summary>
    let morePermissions =
        Namespaced_IRI.parse _namespace_name "morePermissions" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#permits"></see>
    /// </summary>
    let permits = Namespaced_IRI.parse _namespace_name "permits" |> NamespacedName
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#prohibits"></see>
    /// </summary>
    let prohibits = Namespaced_IRI.parse _namespace_name "prohibits" |> NamespacedName
    /// <summary>
    ///   <see href="http://creativecommons.org/ns#requires"></see>
    /// </summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    ///   <see href="http://creativecommons.org/ns#useGuidelines"></see>
    /// </summary>
    let useGuidelines =
        Namespaced_IRI.parse _namespace_name "useGuidelines" |> NamespacedName
