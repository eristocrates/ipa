namespace http.www.bbc.co.uk.ontologies.sport.slash

open DoxAletheia.Rdf_Vocabulary

module sport =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/sport/"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/sport/3.1"></see>
    /// </summary>
    let ``_3.1`` = Namespaced_IRI.parse _namespace_name "3.1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/sport/3.2"></see>
    /// </summary>
    let ``_3.2`` = Namespaced_IRI.parse _namespace_name "3.2" |> NamespacedName

    /// <summary>
    /// Legacy class, used for associating an athlete with the national team they competed for during the Summer Olympics. Deprecated due to improper naming.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/CompetesForRole"></see></summary>
    let CompetesForRole =
        Namespaced_IRI.parse _namespace_name "CompetesForRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/sport/2.0"></see>
    /// </summary>
    let ``_2.0`` = Namespaced_IRI.parse _namespace_name "2.0" |> NamespacedName

    /// <summary>
    /// A competitive sporting event that usually appears as an occurrence of a recurring competition, for example the recurring English Football Premier League has a seasonal competition occurrence during 2012/13
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Competition"></see></summary>
    let Competition =
        Namespaced_IRI.parse _namespace_name "Competition" |> NamespacedName

    /// <summary>
    /// Enumerated competition types, for example: domestic, international.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/CompetitionType"></see></summary>
    let CompetitionType =
        Namespaced_IRI.parse _namespace_name "CompetitionType" |> NamespacedName

    /// <summary>
    /// The group of people that are available to compete in a particular competition. Two groups with the same members are not necessarily the same group.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingGroup"></see></summary>
    let CompetitiveSportingGroup =
        Namespaced_IRI.parse _namespace_name "CompetitiveSportingGroup" |> NamespacedName

    /// <summary>
    /// A sporting organisation that participates in competitive sporting events. For example Manchester United or Team GB at the Olympics.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingOrganisation"></see></summary>
    let CompetitiveSportingOrganisation =
        Namespaced_IRI.parse _namespace_name "CompetitiveSportingOrganisation" |> NamespacedName

    /// <summary>
    /// An organisation involved in Sport, for example a Football team or the UK Government Department for Culture, Media and Sport.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/SportingOrganisation"></see></summary>
    let SportingOrganisation =
        Namespaced_IRI.parse _namespace_name "SportingOrganisation" |> NamespacedName

    /// <summary>
    /// General description of the participation of players, drivers, riders etc, in groups and organisations.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingRole"></see></summary>
    let CompetitiveSportingRole =
        Namespaced_IRI.parse _namespace_name "CompetitiveSportingRole" |> NamespacedName

    /// <summary>
    /// A Divisional Competition is a competition that is divided into a number of competitions. London 2012 is an example of a Divisional Competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/DivisionalCompetition"></see></summary>
    let DivisionalCompetition =
        Namespaced_IRI.parse _namespace_name "DivisionalCompetition" |> NamespacedName

    /// <summary>
    /// Enumerated type, typically Male, Female or Mixed.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/EventGender"></see></summary>
    let EventGender =
        Namespaced_IRI.parse _namespace_name "EventGender" |> NamespacedName

    /// <summary>
    /// The Governing Body for a sport, such as The Football Association.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/GoverningBody"></see></summary>
    let GoverningBody =
        Namespaced_IRI.parse _namespace_name "GoverningBody" |> NamespacedName

    /// <summary>
    /// An organisation as a collection of leagues used to select the top N competitors from each league.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/GroupCompetition"></see></summary>
    let GroupCompetition =
        Namespaced_IRI.parse _namespace_name "GroupCompetition" |> NamespacedName

    /// <summary>
    /// A Competition organised as a sequence of rounds, for example the Premier League or group stage of the World Cup.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/MultiRoundCompetition"></see></summary>
    let MultiRoundCompetition =
        Namespaced_IRI.parse _namespace_name "MultiRoundCompetition" |> NamespacedName

    /// <summary>
    /// The home ground, stadium or location of a Competitive Sporting Organisation.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Home"></see></summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName

    /// <summary>
    /// A competition or stage of competition that progresses through rounds of individual fixtures whereby one team is eliminated as a result of each fixture.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/KnockoutCompetition"></see></summary>
    let KnockoutCompetition =
        Namespaced_IRI.parse _namespace_name "KnockoutCompetition" |> NamespacedName

    /// <summary>
    /// A League Competition is a hierarchy of competitions or competition within such a hierarchy.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/LeagueCompetition"></see></summary>
    let LeagueCompetition =
        Namespaced_IRI.parse _namespace_name "LeagueCompetition" |> NamespacedName

    /// <summary>
    /// The smallest unit of sporting competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Match"></see></summary>
    let Match = Namespaced_IRI.parse _namespace_name "Match" |> NamespacedName

    /// <summary>
    /// A unit competition is the unit of competition defined by a competition discipline rules. Examples include a 100m race or Football match.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/UnitCompetition"></see></summary>
    let UnitCompetition =
        Namespaced_IRI.parse _namespace_name "UnitCompetition" |> NamespacedName

    /// <summary>
    /// A competition that results in the awarding of a medal to the winner or runner up in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/MedalCompetition"></see></summary>
    let MedalCompetition =
        Namespaced_IRI.parse _namespace_name "MedalCompetition" |> NamespacedName

    /// <summary>
    /// A competition that incorporates a number of different sports, such as the Olympics.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/MultiDisciplineCompetition"></see></summary>
    let MultiDisciplineCompetition =
        Namespaced_IRI.parse _namespace_name "MultiDisciplineCompetition" |> NamespacedName

    /// <summary>
    /// A recurring sports competition the covers many sports, such as the Summer Olympics.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/MultiDisciplineRecurringCompetition"></see></summary>
    let MultiDisciplineRecurringCompetition =
        Namespaced_IRI.parse _namespace_name "MultiDisciplineRecurringCompetition" |> NamespacedName

    /// <summary>
    /// A Multi-stage Competition is a competition that is organised as a set of stages. An example is the Football World Cup.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/MultiStageCompetition"></see></summary>
    let MultiStageCompetition =
        Namespaced_IRI.parse _namespace_name "MultiStageCompetition" |> NamespacedName

    /// <summary>
    /// An athlete or other person with typically a participating role in a CompetitiveSportingOrganisation.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// A recurring sports competition such as the Rugby Super League.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/RecurringCompetition"></see></summary>
    let RecurringCompetition =
        Namespaced_IRI.parse _namespace_name "RecurringCompetition" |> NamespacedName

    /// <summary>
    /// A round is one or more competitions that is part of a Multi-Round Competition. Examples include the first round of Wimbledon and the final round of the FA Cup.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Round"></see></summary>
    let Round = Namespaced_IRI.parse _namespace_name "Round" |> NamespacedName
    /// <summary>
    /// Enumerated round types, for example: preliminary, qualifying or final.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/RoundType"></see></summary>
    let RoundType = Namespaced_IRI.parse _namespace_name "RoundType" |> NamespacedName
    /// <summary>
    /// A sub-division of a competition, that must be broken up due to the duration of that competition, occurring for example in snooker or cricket.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Session"></see></summary>
    let Session = Namespaced_IRI.parse _namespace_name "Session" |> NamespacedName

    /// <summary>
    /// The type of discipline a sporting event involves.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/SportsDiscipline"></see></summary>
    let SportsDiscipline =
        Namespaced_IRI.parse _namespace_name "SportsDiscipline" |> NamespacedName

    /// <summary>
    /// The location of a sporting event. May be a stadium, track, lake etc.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/Venue"></see></summary>
    let Venue = Namespaced_IRI.parse _namespace_name "Venue" |> NamespacedName

    /// <summary>
    /// Relates a match to one competitor, by definition or designation not the home competitor.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/awayCompetitor"></see></summary>
    let awayCompetitor =
        Namespaced_IRI.parse _namespace_name "awayCompetitor" |> NamespacedName

    /// <summary>
    /// Relates a competitor, team or other agent to a competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/competesIn"></see></summary>
    let competesIn = Namespaced_IRI.parse _namespace_name "competesIn" |> NamespacedName

    /// <summary>
    /// Relates something, typically a competition, to an enumerated competition type.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/competitionType"></see></summary>
    let competitionType =
        Namespaced_IRI.parse _namespace_name "competitionType" |> NamespacedName

    /// <summary>
    /// Implemented because foaf has no notion of date of birth. Deprecated in favour of core:dateOfBirth.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/dateOfBirth"></see></summary>
    let dateOfBirth =
        Namespaced_IRI.parse _namespace_name "dateOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/sport/2.11"></see>
    /// </summary>
    let ``_2.11`` = Namespaced_IRI.parse _namespace_name "2.11" |> NamespacedName
    /// <summary>
    /// Relates something to a sporting discipline, for example a person to athletics.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/discipline"></see></summary>
    let discipline = Namespaced_IRI.parse _namespace_name "discipline" |> NamespacedName
    /// <summary>
    /// Division relates a DivisionalCompetition to a competition which is a division of that DivisionalCompetition. Used for the olympics
    /// <see href="http://www.bbc.co.uk/ontologies/sport/division"></see></summary>
    let division = Namespaced_IRI.parse _namespace_name "division" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/sport/hasDivisionList"></see>
    /// </summary>
    let hasDivisionList =
        Namespaced_IRI.parse _namespace_name "hasDivisionList" |> NamespacedName

    /// <summary>
    /// Relates a competition to a gender class instance.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/eventGender"></see></summary>
    let eventGender =
        Namespaced_IRI.parse _namespace_name "eventGender" |> NamespacedName

    /// <summary>
    /// Relates a multi-round competition to the first round in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/firstRound"></see></summary>
    let firstRound = Namespaced_IRI.parse _namespace_name "firstRound" |> NamespacedName
    /// <summary>
    /// Relates a multi-round competition to a round in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasRound"></see></summary>
    let hasRound = Namespaced_IRI.parse _namespace_name "hasRound" |> NamespacedName

    /// <summary>
    /// Relates a competition to the first session of a series of sessions.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/firstSession"></see></summary>
    let firstSession =
        Namespaced_IRI.parse _namespace_name "firstSession" |> NamespacedName

    /// <summary>
    /// Relates a competition to a session within that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasSession"></see></summary>
    let hasSession = Namespaced_IRI.parse _namespace_name "hasSession" |> NamespacedName
    /// <summary>
    /// Relates a multi-stage competition to its first stage in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/firstStage"></see></summary>
    let firstStage = Namespaced_IRI.parse _namespace_name "firstStage" |> NamespacedName
    /// <summary>
    /// Relates a multi-stage competition to a stage that it contains.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasStage"></see></summary>
    let hasStage = Namespaced_IRI.parse _namespace_name "hasStage" |> NamespacedName

    /// <summary>
    /// Relates a competition to its first unit competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/firstUnitCompetition"></see></summary>
    let firstUnitCompetition =
        Namespaced_IRI.parse _namespace_name "firstUnitCompetition" |> NamespacedName

    /// <summary>
    /// Relates a round to a unit competition in that round.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasUnitCompetition"></see></summary>
    let hasUnitCompetition =
        Namespaced_IRI.parse _namespace_name "hasUnitCompetition" |> NamespacedName

    /// <summary>
    /// Legacy property used to associate a team with the country flag it represented during the olympics
    /// <see href="http://www.bbc.co.uk/ontologies/sport/flagImage"></see></summary>
    let flagImage = Namespaced_IRI.parse _namespace_name "flagImage" |> NamespacedName

    /// <summary>
    /// Associates an agent with sporting organisations non-temporally.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasCompetedFor"></see></summary>
    let hasCompetedFor =
        Namespaced_IRI.parse _namespace_name "hasCompetedFor" |> NamespacedName

    /// <summary>
    /// Relates a competition to a competitor in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasCompetitor"></see></summary>
    let hasCompetitor =
        Namespaced_IRI.parse _namespace_name "hasCompetitor" |> NamespacedName

    /// <summary>
    /// Relates a divisional competition to a division in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasDivision"></see></summary>
    let hasDivision =
        Namespaced_IRI.parse _namespace_name "hasDivision" |> NamespacedName

    /// <summary>
    /// Relates a league competition to a corresponding group competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasGroup"></see></summary>
    let hasGroup = Namespaced_IRI.parse _namespace_name "hasGroup" |> NamespacedName
    /// <summary>
    /// Relates a group competition to its corresponding League competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/isGroupOf"></see></summary>
    let isGroupOf = Namespaced_IRI.parse _namespace_name "isGroupOf" |> NamespacedName
    /// <summary>
    /// Relates a Competitive Sporting Organisation to its home ground, stadium or location.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasHome"></see></summary>
    let hasHome = Namespaced_IRI.parse _namespace_name "hasHome" |> NamespacedName
    /// <summary>
    /// Relates a round to a match.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/hasMatch"></see></summary>
    let hasMatch = Namespaced_IRI.parse _namespace_name "hasMatch" |> NamespacedName

    /// <summary>
    /// Relates a match to one competitor, by definition or designation not the away competitor.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/homeCompetitor"></see></summary>
    let homeCompetitor =
        Namespaced_IRI.parse _namespace_name "homeCompetitor" |> NamespacedName

    /// <summary>
    /// Relates a competitive sporting group to a competitive sporting organisation.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/isCompetitiveSportingOrganisationOf"></see></summary>
    let isCompetitiveSportingOrganisationOf =
        Namespaced_IRI.parse _namespace_name "isCompetitiveSportingOrganisationOf" |> NamespacedName

    /// <summary>
    /// Relates a match to a round.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/isMatchOf"></see></summary>
    let isMatchOf = Namespaced_IRI.parse _namespace_name "isMatchOf" |> NamespacedName
    /// <summary>
    /// Relates a round to its corresponding multi-round competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/isRoundOf"></see></summary>
    let isRoundOf = Namespaced_IRI.parse _namespace_name "isRoundOf" |> NamespacedName

    /// <summary>
    /// Relates a session to a competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/isSessionOf"></see></summary>
    let isSessionOf =
        Namespaced_IRI.parse _namespace_name "isSessionOf" |> NamespacedName

    /// <summary>
    /// Relates a stage to a multi-stage competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/isStageOf"></see></summary>
    let isStageOf = Namespaced_IRI.parse _namespace_name "isStageOf" |> NamespacedName
    /// <summary>
    /// Relates a multi-round competition to the last round in that competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/lastRound"></see></summary>
    let lastRound = Namespaced_IRI.parse _namespace_name "lastRound" |> NamespacedName

    /// <summary>
    /// Relates a competition to the last session of a series of sessions.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/lastSession"></see></summary>
    let lastSession =
        Namespaced_IRI.parse _namespace_name "lastSession" |> NamespacedName

    /// <summary>
    /// Relates a stage in a multi-stage competition to its last stage.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/lastStage"></see></summary>
    let lastStage = Namespaced_IRI.parse _namespace_name "lastStage" |> NamespacedName

    /// <summary>
    /// Relates a competition to its last unit competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/lastUnitCompetition"></see></summary>
    let lastUnitCompetition =
        Namespaced_IRI.parse _namespace_name "lastUnitCompetition" |> NamespacedName

    /// <summary>
    /// Relates a round in a multi-round competition to its next round.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/nextRound"></see></summary>
    let nextRound = Namespaced_IRI.parse _namespace_name "nextRound" |> NamespacedName

    /// <summary>
    /// Relates a session to its next session.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/nextSession"></see></summary>
    let nextSession =
        Namespaced_IRI.parse _namespace_name "nextSession" |> NamespacedName

    /// <summary>
    /// Relates a stage in a multi-stage competition to its next stage.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/nextStage"></see></summary>
    let nextStage = Namespaced_IRI.parse _namespace_name "nextStage" |> NamespacedName

    /// <summary>
    /// Relates a unit competition to its next unit competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/nextUnitCompetition"></see></summary>
    let nextUnitCompetition =
        Namespaced_IRI.parse _namespace_name "nextUnitCompetition" |> NamespacedName

    /// <summary>
    /// Relates a round in a multi-round competition to its previous round.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/prevRound"></see></summary>
    let prevRound = Namespaced_IRI.parse _namespace_name "prevRound" |> NamespacedName

    /// <summary>
    /// Relates a session to its previous session.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/prevSession"></see></summary>
    let prevSession =
        Namespaced_IRI.parse _namespace_name "prevSession" |> NamespacedName

    /// <summary>
    /// Relates a stage in a multi-stage competition to its previous stage.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/prevStage"></see></summary>
    let prevStage = Namespaced_IRI.parse _namespace_name "prevStage" |> NamespacedName

    /// <summary>
    /// Relates a multi-round competition to its previous unit competition.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/prevUnitCompetition"></see></summary>
    let prevUnitCompetition =
        Namespaced_IRI.parse _namespace_name "prevUnitCompetition" |> NamespacedName

    /// <summary>
    /// Relates a competition to the next competition in a heirarchy that teams are promoted to. For example the nPower Championship promotes to the Premier League.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/promotesTo"></see></summary>
    let promotesTo = Namespaced_IRI.parse _namespace_name "promotesTo" |> NamespacedName

    /// <summary>
    /// Relates a competition to the previous competition in a heirarchy that teams are relegated to. For example the  Premier League relegates to the nPower Championship.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/relegatesTo"></see></summary>
    let relegatesTo =
        Namespaced_IRI.parse _namespace_name "relegatesTo" |> NamespacedName

    /// <summary>
    /// Relates a competition to the recurring instance of that competition, for example the 2012/13 Premier League to the Premier League.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/recurringCompetition"></see></summary>
    let recurringCompetition =
        Namespaced_IRI.parse _namespace_name "recurringCompetition" |> NamespacedName

    /// <summary>
    /// Indicates the sequential number of a round.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/roundNumber"></see></summary>
    let roundNumber =
        Namespaced_IRI.parse _namespace_name "roundNumber" |> NamespacedName

    /// <summary>
    /// Relates a round to an enumerated round type.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/roundType"></see></summary>
    let roundType = Namespaced_IRI.parse _namespace_name "roundType" |> NamespacedName

    /// <summary>
    /// Relates a discipline with a child discipline, for example gymnastics with rhythmic gymnastics.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/subDiscipline"></see></summary>
    let subDiscipline =
        Namespaced_IRI.parse _namespace_name "subDiscipline" |> NamespacedName

    /// <summary>
    /// Relates a discipline with a parent discipline, for example rhythmic gymnastics with gymnastics.
    /// <see href="http://www.bbc.co.uk/ontologies/sport/subDisciplineOf"></see></summary>
    let subDisciplineOf =
        Namespaced_IRI.parse _namespace_name "subDisciplineOf" |> NamespacedName
