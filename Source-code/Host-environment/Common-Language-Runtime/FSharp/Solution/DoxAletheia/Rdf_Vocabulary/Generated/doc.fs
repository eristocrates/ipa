namespace http.www.w3.org._2000._10.swap.pim.doc.hash

open DoxAletheia

module doc =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/doc#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The person (not string) who created this.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// Terms and intellectual property rights licensing conditions.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#ipr"></see></summary>
    let ipr = _prefix "ipr"
    /// <summary>
    /// This generic work has a specific version in the
    /// 	follwing specific document
    /// This version of this document (eg number, date, etc). A string
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// Class of licenses which can be called Open Soutrce
    ///                 according to opensource.org
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#OpenSourceLicense"></see></summary>
    let OpenSourceLicense = _prefix "OpenSourceLicense"
    /// <summary>
    /// An abstract information thing of value, typically intellectual property
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    /// A web page allowing a human user to administer this work,
    ///             for example changing access control, version control information etc.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#adminPage"></see></summary>
    let adminPage = _prefix "adminPage"
    /// <summary>
    /// The meaning or value of this work depends on that of that work.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#dependsOn"></see></summary>
    let dependsOn = _prefix "dependsOn"
    /// <summary>
    /// A work wholey or partly used in the creation of this one.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#derivativeWork"></see></summary>
    let derivativeWork = _prefix "derivativeWork"
    /// <summary>
    /// A work wholey or partly used in the creation of this one.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#derivedFrom"></see></summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    /// This may change that access control for that
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#mayControl"></see></summary>
    let mayControl = _prefix "mayControl"
    /// <summary>
    /// This may access that for read -- compare 'r' unix
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#mayRead"></see></summary>
    let mayRead = _prefix "mayRead"
    /// <summary>
    /// This may access that to modify it -- compare 'w' unix
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#mayWrite"></see></summary>
    let mayWrite = _prefix "mayWrite"
    /// <summary>
    /// This work is more upto date than that and makes it obsolete.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#obsoletes"></see></summary>
    let obsoletes = _prefix "obsoletes"
    /// <summary>
    /// Publishers policy regarding the peristence of the mapping
    ///                 between URI and its meaning and/or representation in bits.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#persistencePolicy"></see></summary>
    let persistencePolicy = _prefix "persistencePolicy"
    /// <summary>
    ///
    /// 	The subject is a namespace document; the object is a document
    /// 	containing rules. The rules are valid information about the terms
    /// 	defined in the namespace document.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#rules"></see></summary>
    let rules = _prefix "rules"
    /// <summary>
    /// For any license, a sublicense is a licensing offering a subset of the rights.
    /// If A doc:sublicense B then anything under license A can be released under
    /// licence B.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#subLicense"></see></summary>
    let subLicense = _prefix "subLicense"
    /// <summary>
    /// This work is a a specific version of the follwing generic document.
    /// 		OBSOLETE - use its inverse, version.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#versionOf"></see></summary>
    let versionOf = _prefix "versionOf"
