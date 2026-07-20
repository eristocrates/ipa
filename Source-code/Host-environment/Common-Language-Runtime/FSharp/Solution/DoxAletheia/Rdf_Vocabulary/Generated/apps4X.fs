namespace http.semweb.mmlab.be.ns.apps4X.hash

open DoxAletheia

module apps4X =
    let _namespace_name = "http://semweb.mmlab.be/ns/apps4X#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// the award offered by the jury to a certain App Concept
    /// <see href="http://semweb.mmlab.be/ns/apps4X#Award"></see></summary>
    let Award = _prefix "Award"
    /// <summary>
    /// A co-creation event is a competition, a contest, a challenge etc. It's a subproperty as it is an event but with a certain scope
    /// <see href="http://semweb.mmlab.be/ns/apps4X#CocreationEvent"></see></summary>
    let CocreationEvent = _prefix "CocreationEvent"
    /// <summary>
    /// A jury evaluating the submissions to a co-creation event.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#Jury"></see></summary>
    let Jury = _prefix "Jury"
    /// <summary>
    /// An App Concept idea as it was submitted to a certain competition.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#Submission"></see></summary>
    let Submission = _prefix "Submission"
    /// <summary>
    /// one or more awards offered at this co-creation event
    /// <see href="http://semweb.mmlab.be/ns/apps4X#award"></see></summary>
    let award = _prefix "award"
    /// <summary>
    /// The award ceremony
    /// <see href="http://semweb.mmlab.be/ns/apps4X#awardCeremony"></see></summary>
    let awardCeremony = _prefix "awardCeremony"
    /// <summary>
    /// A submission consists of
    /// <see href="http://semweb.mmlab.be/ns/apps4X#consistsOf"></see></summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    /// The event edition.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#edition"></see></summary>
    let edition = _prefix "edition"
    /// <summary>
    /// A jury consists of
    /// <see href="http://semweb.mmlab.be/ns/apps4X#juryMember"></see></summary>
    let juryMember = _prefix "juryMember"
    /// <summary>
    /// The rate given by the jury
    /// <see href="http://semweb.mmlab.be/ns/apps4X#juryRate"></see></summary>
    let juryRate = _prefix "juryRate"
    /// <summary>
    /// An App Concept is nominated for the award.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#nominated"></see></summary>
    let nominated = _prefix "nominated"
    /// <summary>
    /// the event's organizer
    /// <see href="http://semweb.mmlab.be/ns/apps4X#organizer"></see></summary>
    let organizer = _prefix "organizer"
    /// <summary>
    /// The actual prize offered.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#prize"></see></summary>
    let prize = _prefix "prize"
    /// <summary>
    /// a link to the registration for the event
    /// <see href="http://semweb.mmlab.be/ns/apps4X#registration"></see></summary>
    let registration = _prefix "registration"
    /// <summary>
    /// the event's short title and/or its abbreviation
    /// <see href="http://semweb.mmlab.be/ns/apps4X#shortTitle"></see></summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    /// The event's size in regard to its thematic area and/or locality.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#size"></see></summary>
    let size = _prefix "size"
    /// <summary>
    ///  the event's sponsor
    /// <see href="http://semweb.mmlab.be/ns/apps4X#sponsor"></see></summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    /// The App Concept can be within a certain theme.
    /// <see href="http://semweb.mmlab.be/ns/apps4X#theme"></see></summary>
    let theme = _prefix "theme"
    /// <summary>
    /// The rate given by the users
    /// <see href="http://semweb.mmlab.be/ns/apps4X#usersRate"></see></summary>
    let usersRate = _prefix "usersRate"
    /// <summary>
    /// links to the award that this App Concept won
    /// <see href="http://semweb.mmlab.be/ns/apps4X#wonAward"></see></summary>
    let wonAward = _prefix "wonAward"
