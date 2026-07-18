namespace http.www.w3.org._2000._10.swap.pim.doc.hash

open DoxAletheia.Rdf_Vocabulary

module doc =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/doc#"
    /// <summary>
    /// The person (not string) who created this.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// Terms and intellectual property rights licensing conditions.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#ipr"></see></summary>
    let ipr = Namespaced_IRI.parse _namespace_name "ipr" |> NamespacedName
    /// <summary>
    /// This generic work has a specific version in the
    /// 	follwing specific document
    /// This version of this document (eg number, date, etc). A string
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    /// Class of licenses which can be called Open Soutrce
    ///                 according to opensource.org
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#OpenSourceLicense"></see></summary>
    let OpenSourceLicense =
        Namespaced_IRI.parse _namespace_name "OpenSourceLicense" |> NamespacedName

    /// <summary>
    /// An abstract information thing of value, typically intellectual property
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    /// A web page allowing a human user to administer this work,
    ///             for example changing access control, version control information etc.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#adminPage"></see></summary>
    let adminPage = Namespaced_IRI.parse _namespace_name "adminPage" |> NamespacedName
    /// <summary>
    /// The meaning or value of this work depends on that of that work.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#dependsOn"></see></summary>
    let dependsOn = Namespaced_IRI.parse _namespace_name "dependsOn" |> NamespacedName

    /// <summary>
    /// A work wholey or partly used in the creation of this one.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#derivativeWork"></see></summary>
    let derivativeWork =
        Namespaced_IRI.parse _namespace_name "derivativeWork" |> NamespacedName

    /// <summary>
    /// A work wholey or partly used in the creation of this one.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#derivedFrom"></see></summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    /// This may change that access control for that
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#mayControl"></see></summary>
    let mayControl = Namespaced_IRI.parse _namespace_name "mayControl" |> NamespacedName
    /// <summary>
    /// This may access that for read -- compare 'r' unix
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#mayRead"></see></summary>
    let mayRead = Namespaced_IRI.parse _namespace_name "mayRead" |> NamespacedName
    /// <summary>
    /// This may access that to modify it -- compare 'w' unix
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#mayWrite"></see></summary>
    let mayWrite = Namespaced_IRI.parse _namespace_name "mayWrite" |> NamespacedName
    /// <summary>
    /// This work is more upto date than that and makes it obsolete.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#obsoletes"></see></summary>
    let obsoletes = Namespaced_IRI.parse _namespace_name "obsoletes" |> NamespacedName

    /// <summary>
    /// Publishers policy regarding the peristence of the mapping
    ///                 between URI and its meaning and/or representation in bits.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#persistencePolicy"></see></summary>
    let persistencePolicy =
        Namespaced_IRI.parse _namespace_name "persistencePolicy" |> NamespacedName

    /// <summary>
    ///
    /// 	The subject is a namespace document; the object is a document
    /// 	containing rules. The rules are valid information about the terms
    /// 	defined in the namespace document.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#rules"></see></summary>
    let rules = Namespaced_IRI.parse _namespace_name "rules" |> NamespacedName
    /// <summary>
    /// For any license, a sublicense is a licensing offering a subset of the rights.
    /// If A doc:sublicense B then anything under license A can be released under
    /// licence B.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#subLicense"></see></summary>
    let subLicense = Namespaced_IRI.parse _namespace_name "subLicense" |> NamespacedName
    /// <summary>
    /// This work is a a specific version of the follwing generic document.
    /// 		OBSOLETE - use its inverse, version.
    /// <see href="http://www.w3.org/2000/10/swap/pim/doc#versionOf"></see></summary>
    let versionOf = Namespaced_IRI.parse _namespace_name "versionOf" |> NamespacedName
