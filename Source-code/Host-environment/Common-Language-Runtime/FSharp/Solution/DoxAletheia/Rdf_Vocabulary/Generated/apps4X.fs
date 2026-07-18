namespace http.semweb.mmlab.be.ns.apps4X.hash

open DoxAletheia.Rdf_Vocabulary

module apps4X =
    let _namespace_name = "http://semweb.mmlab.be/ns/apps4X#"
    /// <summary>
    /// the award offered by the jury to a certain App Concept
    /// <see href="http://semweb.mmlab.be/ns/apps4X#Award"></see></summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName

    /// <summary>
    /// A co-creation event is a competition, a contest, a challenge etc. It's a subproperty as it is an event but with a certain scope
    /// <see href="http://semweb.mmlab.be/ns/apps4X#CocreationEvent"></see></summary>
    let CocreationEvent =
        Namespaced_IRI.parse _namespace_name "CocreationEvent" |> NamespacedName

    /// <summary>
    /// A jury evaluating the submissions to a co-creation event.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#Jury"></see></summary>
    let Jury = Namespaced_IRI.parse _namespace_name "Jury" |> NamespacedName
    /// <summary>
    /// An App Concept idea as it was submitted to a certain competition.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#Submission"></see></summary>
    let Submission = Namespaced_IRI.parse _namespace_name "Submission" |> NamespacedName
    /// <summary>
    /// one or more awards offered at this co-creation event
    /// <see href="http://semweb.mmlab.be/ns/apps4X#award"></see></summary>
    let award = Namespaced_IRI.parse _namespace_name "award" |> NamespacedName

    /// <summary>
    /// The award ceremony
    /// <see href="http://semweb.mmlab.be/ns/apps4X#awardCeremony"></see></summary>
    let awardCeremony =
        Namespaced_IRI.parse _namespace_name "awardCeremony" |> NamespacedName

    /// <summary>
    /// A submission consists of
    /// <see href="http://semweb.mmlab.be/ns/apps4X#consistsOf"></see></summary>
    let consistsOf = Namespaced_IRI.parse _namespace_name "consistsOf" |> NamespacedName
    /// <summary>
    /// The event edition.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#edition"></see></summary>
    let edition = Namespaced_IRI.parse _namespace_name "edition" |> NamespacedName
    /// <summary>
    /// A jury consists of
    /// <see href="http://semweb.mmlab.be/ns/apps4X#juryMember"></see></summary>
    let juryMember = Namespaced_IRI.parse _namespace_name "juryMember" |> NamespacedName
    /// <summary>
    /// The rate given by the jury
    /// <see href="http://semweb.mmlab.be/ns/apps4X#juryRate"></see></summary>
    let juryRate = Namespaced_IRI.parse _namespace_name "juryRate" |> NamespacedName
    /// <summary>
    /// An App Concept is nominated for the award.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#nominated"></see></summary>
    let nominated = Namespaced_IRI.parse _namespace_name "nominated" |> NamespacedName
    /// <summary>
    /// the event's organizer
    /// <see href="http://semweb.mmlab.be/ns/apps4X#organizer"></see></summary>
    let organizer = Namespaced_IRI.parse _namespace_name "organizer" |> NamespacedName
    /// <summary>
    /// The actual prize offered.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#prize"></see></summary>
    let prize = Namespaced_IRI.parse _namespace_name "prize" |> NamespacedName

    /// <summary>
    /// a link to the registration for the event
    /// <see href="http://semweb.mmlab.be/ns/apps4X#registration"></see></summary>
    let registration =
        Namespaced_IRI.parse _namespace_name "registration" |> NamespacedName

    /// <summary>
    /// the event's short title and/or its abbreviation
    /// <see href="http://semweb.mmlab.be/ns/apps4X#shortTitle"></see></summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName
    /// <summary>
    /// The event's size in regard to its thematic area and/or locality.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#size"></see></summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    ///  the event's sponsor
    /// <see href="http://semweb.mmlab.be/ns/apps4X#sponsor"></see></summary>
    let sponsor = Namespaced_IRI.parse _namespace_name "sponsor" |> NamespacedName
    /// <summary>
    /// The App Concept can be within a certain theme.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#theme"></see></summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName
    /// <summary>
    /// The rate given by the users
    /// <see href="http://semweb.mmlab.be/ns/apps4X#usersRate"></see></summary>
    let usersRate = Namespaced_IRI.parse _namespace_name "usersRate" |> NamespacedName
    /// <summary>
    /// links to the award that this App Concept won
    /// <see href="http://semweb.mmlab.be/ns/apps4X#wonAward"></see></summary>
    let wonAward = Namespaced_IRI.parse _namespace_name "wonAward" |> NamespacedName
