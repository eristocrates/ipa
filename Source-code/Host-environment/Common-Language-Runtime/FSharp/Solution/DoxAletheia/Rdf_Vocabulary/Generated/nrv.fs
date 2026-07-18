namespace http.ns.inria.fr.nrv.hash

open DoxAletheia.Rdf_Vocabulary

module nrv =
    let _namespace_name = "http://ns.inria.fr/nrv#"

    /// <summary>
    /// a requirement that can be violated.
    /// <see href="http://ns.inria.fr/nrv#ViolableRequirement"></see></summary>
    let ViolableRequirement =
        Namespaced_IRI.parse _namespace_name "ViolableRequirement" |> NamespacedName

    /// <summary>
    /// a requirement that can be compensated.
    /// <see href="http://ns.inria.fr/nrv#CompensableRequirement"></see></summary>
    let CompensableRequirement =
        Namespaced_IRI.parse _namespace_name "CompensableRequirement" |> NamespacedName

    /// <summary>
    /// an obligation for which achieving the content at least once is enough to fulfil it.
    /// <see href="http://ns.inria.fr/nrv#Achievement"></see></summary>
    let Achievement =
        Namespaced_IRI.parse _namespace_name "Achievement" |> NamespacedName

    /// <summary>
    /// an obligation that needs to be obeyed for the whole duration within the interval in which it is in force.
    /// <see href="http://ns.inria.fr/nrv#Maintenance"></see></summary>
    let Maintenance =
        Namespaced_IRI.parse _namespace_name "Maintenance" |> NamespacedName

    /// <summary>
    /// a requirement that cannot be violated.
    /// <see href="http://ns.inria.fr/nrv#NonViolableRequirement"></see></summary>
    let NonViolableRequirement =
        Namespaced_IRI.parse _namespace_name "NonViolableRequirement" |> NamespacedName

    /// <summary>
    /// a requirement that cannot be compensated.
    /// <see href="http://ns.inria.fr/nrv#NonCompensableRequirement"></see></summary>
    let NonCompensableRequirement =
        Namespaced_IRI.parse _namespace_name "NonCompensableRequirement" |> NamespacedName

    /// <summary>
    /// an achievement requirement that can be fulfilled even before it is actually in force.
    /// <see href="http://ns.inria.fr/nrv#PreemptiveAchievement"></see></summary>
    let PreemptiveAchievement =
        Namespaced_IRI.parse _namespace_name "PreemptiveAchievement" |> NamespacedName

    /// <summary>
    /// an achievement requirement that cannot be fulfilled even before it is actually in force.
    /// <see href="http://ns.inria.fr/nrv#NonPreemptiveAchievement"></see></summary>
    let NonPreemptiveAchievement =
        Namespaced_IRI.parse _namespace_name "NonPreemptiveAchievement" |> NamespacedName

    /// <summary>
    /// achievement requirement that persists after being violated.
    /// <see href="http://ns.inria.fr/nrv#PerdurantAchievement"></see></summary>
    let PerdurantAchievement =
        Namespaced_IRI.parse _namespace_name "PerdurantAchievement" |> NamespacedName

    /// <summary>
    /// achievement requirement that does not persist after being violated.
    /// <see href="http://ns.inria.fr/nrv#NonPerdurantAchievement"></see></summary>
    let NonPerdurantAchievement =
        Namespaced_IRI.parse _namespace_name "NonPerdurantAchievement" |> NamespacedName

    /// <summary>
    /// TODO.
    /// <see href="http://ns.inria.fr/nrv#CoOccurantPunctual"></see></summary>
    let CoOccurantPunctual =
        Namespaced_IRI.parse _namespace_name "CoOccurantPunctual" |> NamespacedName

    /// <summary>
    /// an obligation for which the contents must be immediately achieved.
    /// <see href="http://ns.inria.fr/nrv#Punctual"></see></summary>
    let Punctual = Namespaced_IRI.parse _namespace_name "Punctual" |> NamespacedName

    /// <summary>
    /// TODO.
    /// <see href="http://ns.inria.fr/nrv#NonCoOccurantPunctual"></see></summary>
    let NonCoOccurantPunctual =
        Namespaced_IRI.parse _namespace_name "NonCoOccurantPunctual" |> NamespacedName

    /// <summary>
    /// a requirement implying, creating, or prescribing a norm.
    /// <see href="http://ns.inria.fr/nrv#NormativeRequirement"></see></summary>
    let NormativeRequirement =
        Namespaced_IRI.parse _namespace_name "NormativeRequirement" |> NamespacedName

    /// <summary>
    /// a requirement violated in a state of affairs and compensated in that same state of affairs.
    /// <see href="http://ns.inria.fr/nrv#CompensatedRequirement"></see></summary>
    let CompensatedRequirement =
        Namespaced_IRI.parse _namespace_name "CompensatedRequirement" |> NamespacedName

    /// <summary>
    /// a set of penalties or sanctions imposed on the violator ; fulfilling them makes amends for the violation.
    /// <see href="http://ns.inria.fr/nrv#Compensation"></see></summary>
    let Compensation =
        Namespaced_IRI.parse _namespace_name "Compensation" |> NamespacedName

    /// <summary>
    /// a requirement being compliant with a state of affairs.
    /// <see href="http://ns.inria.fr/nrv#CompliantRequirement"></see></summary>
    let CompliantRequirement =
        Namespaced_IRI.parse _namespace_name "CompliantRequirement" |> NamespacedName

    /// <summary>
    /// a requirement that is in force at a particular time point only or for the instance it is in force.
    /// <see href="http://ns.inria.fr/nrv#NonPersistentRequirement"></see></summary>
    let NonPersistentRequirement =
        Namespaced_IRI.parse _namespace_name "NonPersistentRequirement" |> NamespacedName

    /// <summary>
    /// a requirement that needs to be obeyed for the whole duration within the interval in which it is in force.
    /// <see href="http://ns.inria.fr/nrv#PersistentRequirement"></see></summary>
    let PersistentRequirement =
        Namespaced_IRI.parse _namespace_name "PersistentRequirement" |> NamespacedName

    /// <summary>
    /// a requirement violated by a state of affairs.
    /// <see href="http://ns.inria.fr/nrv#ViolatedRequirement"></see></summary>
    let ViolatedRequirement =
        Namespaced_IRI.parse _namespace_name "ViolatedRequirement" |> NamespacedName

    /// <summary>
    /// links a compensable requirement to a compensation.
    /// <see href="http://ns.inria.fr/nrv#hasCompensation"></see></summary>
    let hasCompensation =
        Namespaced_IRI.parse _namespace_name "hasCompensation" |> NamespacedName

    /// <summary>
    /// links a violable requirement to compliance.
    /// <see href="http://ns.inria.fr/nrv#hasCompliance"></see></summary>
    let hasCompliance =
        Namespaced_IRI.parse _namespace_name "hasCompliance" |> NamespacedName

    /// <summary>
    /// links a violable requirement to a violation.
    /// <see href="http://ns.inria.fr/nrv#hasViolation"></see></summary>
    let hasViolation =
        Namespaced_IRI.parse _namespace_name "hasViolation" |> NamespacedName
