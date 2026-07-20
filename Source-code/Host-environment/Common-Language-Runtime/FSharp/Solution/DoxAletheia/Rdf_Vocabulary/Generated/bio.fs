namespace http.purl.org.vocab.bio._0._1.slash

open DoxAletheia

module bio =
    let _namespace_name = "http://purl.org/vocab/bio/0.1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/bio/0.1/termgroup2"></see>
    /// </summary>
    let termgroup2 = _prefix "termgroup2"
    /// <summary>
    ///   <see href="http://purl.org/vocab/bio/0.1/termgroup5"></see>
    /// </summary>
    let termgroup5 = _prefix "termgroup5"
    /// <summary>
    ///   <see href="http://purl.org/vocab/bio/0.1/termgroup4"></see>
    /// </summary>
    let termgroup4 = _prefix "termgroup4"
    /// <summary>
    ///   <see href="http://purl.org/vocab/bio/0.1/termgroup1"></see>
    /// </summary>
    let termgroup1 = _prefix "termgroup1"
    /// <summary>
    ///   <see href="http://purl.org/vocab/bio/0.1/termgroup3"></see>
    /// </summary>
    let termgroup3 = _prefix "termgroup3"
    /// <summary>
    /// The event of a person succeeding to the right to hold regal power. This event is often automatic on the death of the previous monarch and is usually followed by a coronation event.
    /// <see href="http://purl.org/vocab/bio/0.1/Accession"></see></summary>
    let Accession = _prefix "Accession"
    /// <summary>
    /// A type of event that is principally about a single person, group or organization. Other agents may be involved but the event is most significant for the principal agent.
    /// <see href="http://purl.org/vocab/bio/0.1/IndividualEvent"></see></summary>
    let IndividualEvent = _prefix "IndividualEvent"
    /// <summary>
    /// The event of creating of a legal parent/child relationship that does not exist biologically.
    /// <see href="http://purl.org/vocab/bio/0.1/Adoption"></see></summary>
    let Adoption = _prefix "Adoption"
    /// <summary>
    /// The event of declaring a marriage void from the beginning as though it never existed.
    /// <see href="http://purl.org/vocab/bio/0.1/Annulment"></see></summary>
    let Annulment = _prefix "Annulment"
    /// <summary>
    /// A type of event that is principally about one or more agents and their partnership. Other agents may be involved but the event is most significant for the partner agent.
    /// <see href="http://purl.org/vocab/bio/0.1/GroupEvent"></see></summary>
    let GroupEvent = _prefix "GroupEvent"
    /// <summary>
    /// The event of a person being deliberately targeted and killed.
    /// <see href="http://purl.org/vocab/bio/0.1/Assassination"></see></summary>
    let Assassination = _prefix "Assassination"
    /// <summary>
    /// The event of a person being killed unlawfully with intent by the killer.
    /// <see href="http://purl.org/vocab/bio/0.1/Murder"></see></summary>
    let Murder = _prefix "Murder"
    /// <summary>
    /// The ceremonial event held to admit a person to membership of a Christian church.
    /// <see href="http://purl.org/vocab/bio/0.1/Baptism"></see></summary>
    let Baptism = _prefix "Baptism"
    /// <summary>
    /// The ceremonial event held when a Jewish boy reaches age 13.
    /// <see href="http://purl.org/vocab/bio/0.1/BarMitzvah"></see></summary>
    let BarMitzvah = _prefix "BarMitzvah"
    /// <summary>
    /// The ceremonial event held when a Jewish girl reaching age 13, also known as "Bat Mitzvah."
    /// <see href="http://purl.org/vocab/bio/0.1/BasMitzvah"></see></summary>
    let BasMitzvah = _prefix "BasMitzvah"
    /// <summary>
    /// The event of a person entering into life.
    /// <see href="http://purl.org/vocab/bio/0.1/Birth"></see></summary>
    let Birth = _prefix "Birth"
    /// <summary>
    /// The event of interring the remains of a person's body into the ground.
    /// <see href="http://purl.org/vocab/bio/0.1/Burial"></see></summary>
    let Burial = _prefix "Burial"
    /// <summary>
    /// The ceremonial event of a person being invested with regal power to become a monarch.
    /// <see href="http://purl.org/vocab/bio/0.1/Coronation"></see></summary>
    let Coronation = _prefix "Coronation"
    /// <summary>
    /// The event of disposing of the remains of a person's body by fire.
    /// <see href="http://purl.org/vocab/bio/0.1/Cremation"></see></summary>
    let Cremation = _prefix "Cremation"
    /// <summary>
    /// The event of a person's life ending.
    /// <see href="http://purl.org/vocab/bio/0.1/Death"></see></summary>
    let Death = _prefix "Death"
    /// <summary>
    /// The event of a person changing the position they hold with an employer to one with less importance or responsibility.
    /// <see href="http://purl.org/vocab/bio/0.1/Demotion"></see></summary>
    let Demotion = _prefix "Demotion"
    /// <summary>
    /// The event of a person changing the position they hold with an employer.
    /// <see href="http://purl.org/vocab/bio/0.1/PositionChange"></see></summary>
    let PositionChange = _prefix "PositionChange"
    /// <summary>
    /// The event of a group or organization being disbanded.
    /// <see href="http://purl.org/vocab/bio/0.1/Disbanding"></see></summary>
    let Disbanding = _prefix "Disbanding"
    /// <summary>
    /// The event of a person involuntarily giving up their office or position. Dismissal is often perceived to be the employee's fault and may be considered disgraceful.
    /// <see href="http://purl.org/vocab/bio/0.1/Dismissal"></see></summary>
    let Dismissal = _prefix "Dismissal"
    /// <summary>
    /// The event of legally dissolving a marriage.
    /// <see href="http://purl.org/vocab/bio/0.1/Divorce"></see></summary>
    let Divorce = _prefix "Divorce"
    /// <summary>
    /// The event of a person leaving their homeland with the intent of residing elsewhere.
    /// <see href="http://purl.org/vocab/bio/0.1/Emigration"></see></summary>
    let Emigration = _prefix "Emigration"
    /// <summary>
    /// The event of a person entering an occupational relationship with an employer.
    /// <see href="http://purl.org/vocab/bio/0.1/Employment"></see></summary>
    let Employment = _prefix "Employment"
    /// <summary>
    /// The event of a person initiating attendence to a school or other place of learning.
    /// <see href="http://purl.org/vocab/bio/0.1/Enrolment"></see></summary>
    let Enrolment = _prefix "Enrolment"
    /// <summary>
    /// An event is an occurrence that brings about a change in the state of affairs for one or more people and/or other agents. Events are assumed to occur over a period of time and may not have precise start and end points.
    /// <see href="http://purl.org/vocab/bio/0.1/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The event of a person being deliberately killed as punishment.
    /// <see href="http://purl.org/vocab/bio/0.1/Execution"></see></summary>
    let Execution = _prefix "Execution"
    /// <summary>
    /// The event of a group or organization coming into being.
    /// <see href="http://purl.org/vocab/bio/0.1/Formation"></see></summary>
    let Formation = _prefix "Formation"
    /// <summary>
    /// The event of marking a person's death with a ceremony.
    /// <see href="http://purl.org/vocab/bio/0.1/Funeral"></see></summary>
    let Funeral = _prefix "Funeral"
    /// <summary>
    /// The event of a person being awarded educational diplomas or degrees.
    /// <see href="http://purl.org/vocab/bio/0.1/Graduation"></see></summary>
    let Graduation = _prefix "Graduation"
    /// <summary>
    /// A person that is involved in a event as a partner in a relationship.
    /// <see href="http://purl.org/vocab/bio/0.1/partner"></see></summary>
    let partner = _prefix "partner"
    /// <summary>
    /// The event of a person being detained in a jail or prison.
    /// <see href="http://purl.org/vocab/bio/0.1/Imprisonment"></see></summary>
    let Imprisonment = _prefix "Imprisonment"
    /// <summary>
    /// The ceremonial event marking the beginning of a person's term of office as a leader.
    /// <see href="http://purl.org/vocab/bio/0.1/Inauguration"></see></summary>
    let Inauguration = _prefix "Inauguration"
    /// <summary>
    /// A person that takes the primary and most important role in an event. For example the principal in a Birth event would be the child being born and the principal in a Burial event would be the deceased person.
    /// <see href="http://purl.org/vocab/bio/0.1/principal"></see></summary>
    let principal = _prefix "principal"
    /// <summary>
    /// A extended interval of time related to a particular state of affairs, such as the lifespan of a person or a period of employment.
    /// <see href="http://purl.org/vocab/bio/0.1/Interval"></see></summary>
    let Interval = _prefix "Interval"
    /// <summary>
    /// The ceremonial event of a person taking a public office or honour.
    /// <see href="http://purl.org/vocab/bio/0.1/Investiture"></see></summary>
    let Investiture = _prefix "Investiture"
    /// <summary>
    /// The event of creating uniting the participants into a new family unit, sometimes accompanied by a formal wedding ceremony. This is intended to cover a broad range of marriages including those given formal legal standing, common-law, or by convention. It is not restricted to marriages of two people of the opposite gender, but also includes polygamous and same-sex unions.
    /// <see href="http://purl.org/vocab/bio/0.1/Marriage"></see></summary>
    let Marriage = _prefix "Marriage"
    /// <summary>
    /// The event of a person changing their name.
    /// <see href="http://purl.org/vocab/bio/0.1/NameChange"></see></summary>
    let NameChange = _prefix "NameChange"
    /// <summary>
    /// The event of a person obtaining citizenship. Note that the place the naturalization event occurs at may be different from the state the person is obtaining citizenship of.
    /// <see href="http://purl.org/vocab/bio/0.1/Naturalization"></see></summary>
    let Naturalization = _prefix "Naturalization"
    /// <summary>
    /// The ceremonial event held when a person receives authority to act in religious matters.
    /// <see href="http://purl.org/vocab/bio/0.1/Ordination"></see></summary>
    let Ordination = _prefix "Ordination"
    /// <summary>
    /// The event of an individual or a group of performers performing. Examples include concerts, plays, recitals, recordings, busking etc.
    /// <see href="http://purl.org/vocab/bio/0.1/Performance"></see></summary>
    let Performance = _prefix "Performance"
    /// <summary>
    /// The event of a person changing the position they hold with an employer to one with more importance or responsibility.
    /// <see href="http://purl.org/vocab/bio/0.1/Promotion"></see></summary>
    let Promotion = _prefix "Promotion"
    /// <summary>
    /// The event of a person involuntarily giving up an office or position that is no longer needed. Redundancy is usually perceived to be the employer's fault and is usually due to conditions outside of the employee's control.
    /// <see href="http://purl.org/vocab/bio/0.1/Redundancy"></see></summary>
    let Redundancy = _prefix "Redundancy"
    /// <summary>
    /// A particular type of connection existing between people, groups or organizations related to or having dealings with each other.
    /// <see href="http://purl.org/vocab/bio/0.1/Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// The event of a person voluntarily giving up or quitting their office or position.
    /// <see href="http://purl.org/vocab/bio/0.1/Resignation"></see></summary>
    let Resignation = _prefix "Resignation"
    /// <summary>
    /// The event of a person exiting an occupational relationship with an employer after a qualifying time period. In many cultures retirement is expected and even required once the person reaches a particular age.
    /// <see href="http://purl.org/vocab/bio/0.1/Retirement"></see></summary>
    let Retirement = _prefix "Retirement"
    /// <summary>
    /// A person, organization or group that plays a role in an event.
    /// <see href="http://purl.org/vocab/bio/0.1/agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// An event associated with a person, group or organization.
    /// <see href="http://purl.org/vocab/bio/0.1/event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// An extended description or account of someone's life.
    /// <see href="http://purl.org/vocab/bio/0.1/biography"></see></summary>
    let biography = _prefix "biography"
    /// <summary>
    /// An birth event associated with a person, group or organization.
    /// <see href="http://purl.org/vocab/bio/0.1/birth"></see></summary>
    let birth = _prefix "birth"
    /// <summary>
    /// A biological child of a person.
    /// <see href="http://purl.org/vocab/bio/0.1/child"></see></summary>
    let child = _prefix "child"
    /// <summary>
    /// An event that marks the end of an interval and/or relationship. The event changes of the state of affairs that held during the interval. For example a period of study may be concluded by a Graduation event.
    /// <see href="http://purl.org/vocab/bio/0.1/concludingEvent"></see></summary>
    let concludingEvent = _prefix "concludingEvent"
    /// <summary>
    /// An event that occurs while this event is occurring. The events need not start or conclude at the same times.
    /// <see href="http://purl.org/vocab/bio/0.1/concurrentEvent"></see></summary>
    let concurrentEvent = _prefix "concurrentEvent"
    /// <summary>
    /// The date at which an event occurred.
    /// <see href="http://purl.org/vocab/bio/0.1/date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// An death event associated with a person, group or organization.
    /// <see href="http://purl.org/vocab/bio/0.1/death"></see></summary>
    let death = _prefix "death"
    /// <summary>
    /// An agent that is involved in an event as an employer.
    /// <see href="http://purl.org/vocab/bio/0.1/employer"></see></summary>
    let employer = _prefix "employer"
    /// <summary>
    /// The interval during which the event occurs. This interval represents the exact interval of occurence for an event, it starts at the moment the event commences and finishes when the event concludes. In other words both the event and the interval start at the same instant of time and extend for the same duration.
    /// <see href="http://purl.org/vocab/bio/0.1/eventInterval"></see></summary>
    let eventInterval = _prefix "eventInterval"
    /// <summary>
    /// The biological father of a person, also known as the genitor.
    /// <see href="http://purl.org/vocab/bio/0.1/father"></see></summary>
    let father = _prefix "father"
    /// <summary>
    /// An event that starts at some time after this event.
    /// <see href="http://purl.org/vocab/bio/0.1/followingEvent"></see></summary>
    let followingEvent = _prefix "followingEvent"
    /// <summary>
    /// An event that starts immediately after this event.
    /// <see href="http://purl.org/vocab/bio/0.1/immediatelyFollowingEvent"></see></summary>
    let immediatelyFollowingEvent = _prefix "immediatelyFollowingEvent"
    /// <summary>
    /// An event that occurs and concludes immediately before this event.
    /// <see href="http://purl.org/vocab/bio/0.1/immediatelyPrecedingEvent"></see></summary>
    let immediatelyPrecedingEvent = _prefix "immediatelyPrecedingEvent"
    /// <summary>
    /// An event that occurs and concludes at some time before this event.
    /// <see href="http://purl.org/vocab/bio/0.1/precedingEvent"></see></summary>
    let precedingEvent = _prefix "precedingEvent"
    /// <summary>
    /// An event that marks the start of an interval and/or relationship. The event contributes to and/or causes of the state of affairs that hold during the interval. For example a period of study may be initiated by an Enrolment event.
    /// <see href="http://purl.org/vocab/bio/0.1/initiatingEvent"></see></summary>
    let initiatingEvent = _prefix "initiatingEvent"
    /// <summary>
    /// The interval during which the relationship persists.
    /// <see href="http://purl.org/vocab/bio/0.1/interval"></see></summary>
    let interval = _prefix "interval"
    /// <summary>
    /// A comma delimited list of key words that describe a person.
    /// <see href="http://purl.org/vocab/bio/0.1/keywords"></see></summary>
    let keywords = _prefix "keywords"
    /// <summary>
    /// The biological mother of a person, also known as the genetrix.
    /// <see href="http://purl.org/vocab/bio/0.1/mother"></see></summary>
    let mother = _prefix "mother"
    /// <summary>
    /// A person that officiates at a ceremonial event.
    /// <see href="http://purl.org/vocab/bio/0.1/officiator"></see></summary>
    let officiator = _prefix "officiator"
    /// <summary>
    /// A one-line biography of the person.
    /// <see href="http://purl.org/vocab/bio/0.1/olb"></see></summary>
    let olb = _prefix "olb"
    /// <summary>
    /// An organization that plays a role in an event.
    /// <see href="http://purl.org/vocab/bio/0.1/organization"></see></summary>
    let organization = _prefix "organization"
    /// <summary>
    /// A person that takes the parent role in an event.
    /// <see href="http://purl.org/vocab/bio/0.1/parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// A person, group or organization that participates in a relationship for some time.
    /// <see href="http://purl.org/vocab/bio/0.1/participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// A relationship that a person, group or organization participates in for some time.
    /// <see href="http://purl.org/vocab/bio/0.1/relationship"></see></summary>
    let relationship = _prefix "relationship"
    /// <summary>
    /// The place at which an event occurred.
    /// <see href="http://purl.org/vocab/bio/0.1/place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    /// The employment position or public office involved in an event.
    /// <see href="http://purl.org/vocab/bio/0.1/position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// A person that is present at and observes the occurrence of at least part of an event.
    /// <see href="http://purl.org/vocab/bio/0.1/spectator"></see></summary>
    let spectator = _prefix "spectator"
    /// <summary>
    /// A country or independent territory that is involved in an event.
    /// <see href="http://purl.org/vocab/bio/0.1/state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// A person that witnesses and can bear testimony to the occurrence of an event.
    /// <see href="http://purl.org/vocab/bio/0.1/witness"></see></summary>
    let witness = _prefix "witness"
