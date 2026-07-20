namespace http.ns.inria.fr.nrv.hash

open DoxAletheia

module nrv =
    let _namespace_name = "http://ns.inria.fr/nrv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// a requirement that can be violated.
    /// <see href="http://ns.inria.fr/nrv#ViolableRequirement"></see></summary>
    let ViolableRequirement = _prefix "ViolableRequirement"
    /// <summary>
    /// a requirement that can be compensated.
    /// <see href="http://ns.inria.fr/nrv#CompensableRequirement"></see></summary>
    let CompensableRequirement = _prefix "CompensableRequirement"
    /// <summary>
    /// an obligation for which achieving the content at least once is enough to fulfil it.
    /// <see href="http://ns.inria.fr/nrv#Achievement"></see></summary>
    let Achievement = _prefix "Achievement"
    /// <summary>
    /// an obligation that needs to be obeyed for the whole duration within the interval in which it is in force.
    /// <see href="http://ns.inria.fr/nrv#Maintenance"></see></summary>
    let Maintenance = _prefix "Maintenance"
    /// <summary>
    /// a requirement that cannot be violated.
    /// <see href="http://ns.inria.fr/nrv#NonViolableRequirement"></see></summary>
    let NonViolableRequirement = _prefix "NonViolableRequirement"
    /// <summary>
    /// a requirement that cannot be compensated.
    /// <see href="http://ns.inria.fr/nrv#NonCompensableRequirement"></see></summary>
    let NonCompensableRequirement = _prefix "NonCompensableRequirement"
    /// <summary>
    /// an achievement requirement that can be fulfilled even before it is actually in force.
    /// <see href="http://ns.inria.fr/nrv#PreemptiveAchievement"></see></summary>
    let PreemptiveAchievement = _prefix "PreemptiveAchievement"
    /// <summary>
    /// an achievement requirement that cannot be fulfilled even before it is actually in force.
    /// <see href="http://ns.inria.fr/nrv#NonPreemptiveAchievement"></see></summary>
    let NonPreemptiveAchievement = _prefix "NonPreemptiveAchievement"
    /// <summary>
    /// achievement requirement that persists after being violated.
    /// <see href="http://ns.inria.fr/nrv#PerdurantAchievement"></see></summary>
    let PerdurantAchievement = _prefix "PerdurantAchievement"
    /// <summary>
    /// achievement requirement that does not persist after being violated.
    /// <see href="http://ns.inria.fr/nrv#NonPerdurantAchievement"></see></summary>
    let NonPerdurantAchievement = _prefix "NonPerdurantAchievement"
    /// <summary>
    /// TODO.
    /// <see href="http://ns.inria.fr/nrv#CoOccurantPunctual"></see></summary>
    let CoOccurantPunctual = _prefix "CoOccurantPunctual"
    /// <summary>
    /// an obligation for which the contents must be immediately achieved.
    /// <see href="http://ns.inria.fr/nrv#Punctual"></see></summary>
    let Punctual = _prefix "Punctual"
    /// <summary>
    /// TODO.
    /// <see href="http://ns.inria.fr/nrv#NonCoOccurantPunctual"></see></summary>
    let NonCoOccurantPunctual = _prefix "NonCoOccurantPunctual"
    /// <summary>
    /// a requirement implying, creating, or prescribing a norm.
    /// <see href="http://ns.inria.fr/nrv#NormativeRequirement"></see></summary>
    let NormativeRequirement = _prefix "NormativeRequirement"
    /// <summary>
    /// a requirement violated in a state of affairs and compensated in that same state of affairs.
    /// <see href="http://ns.inria.fr/nrv#CompensatedRequirement"></see></summary>
    let CompensatedRequirement = _prefix "CompensatedRequirement"
    /// <summary>
    /// a set of penalties or sanctions imposed on the violator ; fulfilling them makes amends for the violation.
    /// <see href="http://ns.inria.fr/nrv#Compensation"></see></summary>
    let Compensation = _prefix "Compensation"
    /// <summary>
    /// a requirement being compliant with a state of affairs.
    /// <see href="http://ns.inria.fr/nrv#CompliantRequirement"></see></summary>
    let CompliantRequirement = _prefix "CompliantRequirement"
    /// <summary>
    /// a requirement that is in force at a particular time point only or for the instance it is in force.
    /// <see href="http://ns.inria.fr/nrv#NonPersistentRequirement"></see></summary>
    let NonPersistentRequirement = _prefix "NonPersistentRequirement"
    /// <summary>
    /// a requirement that needs to be obeyed for the whole duration within the interval in which it is in force.
    /// <see href="http://ns.inria.fr/nrv#PersistentRequirement"></see></summary>
    let PersistentRequirement = _prefix "PersistentRequirement"
    /// <summary>
    /// a requirement violated by a state of affairs.
    /// <see href="http://ns.inria.fr/nrv#ViolatedRequirement"></see></summary>
    let ViolatedRequirement = _prefix "ViolatedRequirement"
    /// <summary>
    /// links a compensable requirement to a compensation.
    /// <see href="http://ns.inria.fr/nrv#hasCompensation"></see></summary>
    let hasCompensation = _prefix "hasCompensation"
    /// <summary>
    /// links a violable requirement to compliance.
    /// <see href="http://ns.inria.fr/nrv#hasCompliance"></see></summary>
    let hasCompliance = _prefix "hasCompliance"
    /// <summary>
    /// links a violable requirement to a violation.
    /// <see href="http://ns.inria.fr/nrv#hasViolation"></see></summary>
    let hasViolation = _prefix "hasViolation"
