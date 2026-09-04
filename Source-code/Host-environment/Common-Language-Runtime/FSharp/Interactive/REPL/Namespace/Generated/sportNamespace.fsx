#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sport =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/sport/" "sport"

    let ``_2.0`` = _prefixId.prefix "2.0"
    let ``_2.11`` = _prefixId.prefix "2.11"
    let ``_3.1`` = _prefixId.prefix "3.1"
    let ``_3.2`` = _prefixId.prefix "3.2"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : CompetesForRole^^xsd:string</para>
    ///   <para>rdfs:comment : Legacy class, used for associating an athlete with the national team they competed for during the Summer Olympics. Deprecated due to improper naming.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/CompetesForRole">sport:CompetesForRole</a>
    /// </summary>
    let CompetesForRole = _prefixId.prefix "CompetesForRole"
    /// <summary>
    ///   <para>rdfs:label : Competition</para>
    ///   <para>rdfs:comment : A competitive sporting event that usually appears as an occurrence of a recurring competition, for example the recurring English Football Premier League has a seasonal competition occurrence during 2012/13</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Competition">sport:Competition</a>
    /// </summary>
    let Competition = _prefixId.prefix "Competition"
    /// <summary>
    ///   <para>rdfs:label : CompetitionType</para>
    ///   <para>rdfs:comment : Enumerated competition types, for example: domestic, international.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/CompetitionType">sport:CompetitionType</a>
    /// </summary>
    let CompetitionType = _prefixId.prefix "CompetitionType"
    /// <summary>
    ///   <para>rdfs:label : CompetitiveSportingGroup</para>
    ///   <para>rdfs:comment : The group of people that are available to compete in a particular competition. Two groups with the same members are not necessarily the same group.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingGroup">sport:CompetitiveSportingGroup</a>
    /// </summary>
    let CompetitiveSportingGroup = _prefixId.prefix "CompetitiveSportingGroup"

    /// <summary>
    ///   <para>rdfs:label : CompetitiveSportingOrganisation</para>
    ///   <para>rdfs:comment : A sporting organisation that participates in competitive sporting events. For example Manchester United or Team GB at the Olympics.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingOrganisation">sport:CompetitiveSportingOrganisation</a>
    /// </summary>
    let CompetitiveSportingOrganisation =
        _prefixId.prefix "CompetitiveSportingOrganisation"

    /// <summary>
    ///   <para>rdfs:label : CompetitiveSportingRole</para>
    ///   <para>rdfs:comment : General description of the participation of players, drivers, riders etc, in groups and organisations.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingRole">sport:CompetitiveSportingRole</a>
    /// </summary>
    let CompetitiveSportingRole = _prefixId.prefix "CompetitiveSportingRole"
    /// <summary>
    ///   <para>rdfs:label : DivisionalCompetition</para>
    ///   <para>rdfs:comment : A Divisional Competition is a competition that is divided into a number of competitions. London 2012 is an example of a Divisional Competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/DivisionalCompetition">sport:DivisionalCompetition</a>
    /// </summary>
    let DivisionalCompetition = _prefixId.prefix "DivisionalCompetition"
    /// <summary>
    ///   <para>rdfs:label : EventGender</para>
    ///   <para>rdfs:comment : Enumerated type, typically Male, Female or Mixed.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/EventGender">sport:EventGender</a>
    /// </summary>
    let EventGender = _prefixId.prefix "EventGender"
    /// <summary>
    ///   <para>rdfs:label : GoverningBody</para>
    ///   <para>rdfs:comment : The Governing Body for a sport, such as The Football Association.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/GoverningBody">sport:GoverningBody</a>
    /// </summary>
    let GoverningBody = _prefixId.prefix "GoverningBody"
    /// <summary>
    ///   <para>rdfs:label : GroupCompetition</para>
    ///   <para>rdfs:comment : An organisation as a collection of leagues used to select the top N competitors from each league.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/GroupCompetition">sport:GroupCompetition</a>
    /// </summary>
    let GroupCompetition = _prefixId.prefix "GroupCompetition"
    /// <summary>
    ///   <para>rdfs:label : Home</para>
    ///   <para>rdfs:comment : The home ground, stadium or location of a Competitive Sporting Organisation.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Home">sport:Home</a>
    /// </summary>
    let Home = _prefixId.prefix "Home"
    /// <summary>
    ///   <para>rdfs:label : KnockoutCompetition</para>
    ///   <para>rdfs:comment : A competition or stage of competition that progresses through rounds of individual fixtures whereby one team is eliminated as a result of each fixture.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/KnockoutCompetition">sport:KnockoutCompetition</a>
    /// </summary>
    let KnockoutCompetition = _prefixId.prefix "KnockoutCompetition"
    /// <summary>
    ///   <para>rdfs:label : LeagueCompetition</para>
    ///   <para>rdfs:comment : A League Competition is a hierarchy of competitions or competition within such a hierarchy.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/LeagueCompetition">sport:LeagueCompetition</a>
    /// </summary>
    let LeagueCompetition = _prefixId.prefix "LeagueCompetition"
    /// <summary>
    ///   <para>rdfs:label : Match</para>
    ///   <para>rdfs:comment : The smallest unit of sporting competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Match">sport:Match</a>
    /// </summary>
    let Match = _prefixId.prefix "Match"
    /// <summary>
    ///   <para>rdfs:label : MedalCompetition</para>
    ///   <para>rdfs:comment : A competition that results in the awarding of a medal to the winner or runner up in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/MedalCompetition">sport:MedalCompetition</a>
    /// </summary>
    let MedalCompetition = _prefixId.prefix "MedalCompetition"
    /// <summary>
    ///   <para>rdfs:label : MultiDisciplineCompetition</para>
    ///   <para>rdfs:comment : A competition that incorporates a number of different sports, such as the Olympics.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/MultiDisciplineCompetition">sport:MultiDisciplineCompetition</a>
    /// </summary>
    let MultiDisciplineCompetition = _prefixId.prefix "MultiDisciplineCompetition"

    /// <summary>
    ///   <para>rdfs:label : MultiDisciplineRecurringCompetition</para>
    ///   <para>rdfs:comment : A recurring sports competition the covers many sports, such as the Summer Olympics.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/MultiDisciplineRecurringCompetition">sport:MultiDisciplineRecurringCompetition</a>
    /// </summary>
    let MultiDisciplineRecurringCompetition =
        _prefixId.prefix "MultiDisciplineRecurringCompetition"

    /// <summary>
    ///   <para>rdfs:label : MultiRoundCompetition</para>
    ///   <para>rdfs:comment : A Competition organised as a sequence of rounds, for example the Premier League or group stage of the World Cup.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/MultiRoundCompetition">sport:MultiRoundCompetition</a>
    /// </summary>
    let MultiRoundCompetition = _prefixId.prefix "MultiRoundCompetition"
    /// <summary>
    ///   <para>rdfs:label : MultiStageCompetition</para>
    ///   <para>rdfs:comment : A Multi-stage Competition is a competition that is organised as a set of stages. An example is the Football World Cup.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/MultiStageCompetition">sport:MultiStageCompetition</a>
    /// </summary>
    let MultiStageCompetition = _prefixId.prefix "MultiStageCompetition"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : An athlete or other person with typically a participating role in a CompetitiveSportingOrganisation.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Person">sport:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : RecurringCompetition</para>
    ///   <para>rdfs:comment : A recurring sports competition such as the Rugby Super League.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/RecurringCompetition">sport:RecurringCompetition</a>
    /// </summary>
    let RecurringCompetition = _prefixId.prefix "RecurringCompetition"
    /// <summary>
    ///   <para>rdfs:label : Round</para>
    ///   <para>rdfs:comment : A round is one or more competitions that is part of a Multi-Round Competition. Examples include the first round of Wimbledon and the final round of the FA Cup.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Round">sport:Round</a>
    /// </summary>
    let Round = _prefixId.prefix "Round"
    /// <summary>
    ///   <para>rdfs:label : RoundType</para>
    ///   <para>rdfs:comment : Enumerated round types, for example: preliminary, qualifying or final.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/RoundType">sport:RoundType</a>
    /// </summary>
    let RoundType = _prefixId.prefix "RoundType"
    /// <summary>
    ///   <para>rdfs:label : Session</para>
    ///   <para>rdfs:comment : A sub-division of a competition, that must be broken up due to the duration of that competition, occurring for example in snooker or cricket.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Session">sport:Session</a>
    /// </summary>
    let Session = _prefixId.prefix "Session"
    /// <summary>
    ///   <para>rdfs:label : SportingOrganisation</para>
    ///   <para>rdfs:comment : An organisation involved in Sport, for example a Football team or the UK Government Department for Culture, Media and Sport.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/SportingOrganisation">sport:SportingOrganisation</a>
    /// </summary>
    let SportingOrganisation = _prefixId.prefix "SportingOrganisation"
    /// <summary>
    ///   <para>rdfs:label : SportsDiscipline</para>
    ///   <para>rdfs:comment : The type of discipline a sporting event involves.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/SportsDiscipline">sport:SportsDiscipline</a>
    /// </summary>
    let SportsDiscipline = _prefixId.prefix "SportsDiscipline"
    /// <summary>
    ///   <para>rdfs:label : UnitCompetition</para>
    ///   <para>rdfs:comment : A unit competition is the unit of competition defined by a competition discipline rules. Examples include a 100m race or Football match.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/UnitCompetition">sport:UnitCompetition</a>
    /// </summary>
    let UnitCompetition = _prefixId.prefix "UnitCompetition"
    /// <summary>
    ///   <para>rdfs:label : Venue</para>
    ///   <para>rdfs:comment : The location of a sporting event. May be a stadium, track, lake etc.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/Venue">sport:Venue</a>
    /// </summary>
    let Venue = _prefixId.prefix "Venue"
    /// <summary>
    ///   <para>rdfs:label : awayCompetitor</para>
    ///   <para>rdfs:comment : Relates a match to one competitor, by definition or designation not the home competitor.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/awayCompetitor">sport:awayCompetitor</a>
    /// </summary>
    let awayCompetitor = _prefixId.prefix "awayCompetitor"
    /// <summary>
    ///   <para>rdfs:label : competesIn</para>
    ///   <para>rdfs:comment : Relates a competitor, team or other agent to a competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/competesIn">sport:competesIn</a>
    /// </summary>
    let competesIn = _prefixId.prefix "competesIn"
    /// <summary>
    ///   <para>rdfs:label : competitionType</para>
    ///   <para>rdfs:comment : Relates something, typically a competition, to an enumerated competition type.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/competitionType">sport:competitionType</a>
    /// </summary>
    let competitionType = _prefixId.prefix "competitionType"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : dateOfBirth</para>
    ///   <para>rdfs:comment : Implemented because foaf has no notion of date of birth. Deprecated in favour of core:dateOfBirth.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/dateOfBirth">sport:dateOfBirth</a>
    /// </summary>
    let dateOfBirth = _prefixId.prefix "dateOfBirth"
    /// <summary>
    ///   <para>rdfs:label : discipline</para>
    ///   <para>rdfs:comment : Relates something to a sporting discipline, for example a person to athletics.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/discipline">sport:discipline</a>
    /// </summary>
    let discipline = _prefixId.prefix "discipline"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Division relates a DivisionalCompetition to a competition which is a division of that DivisionalCompetition. Used for the olympics^^xsd:string</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/division">sport:division</a>
    /// </summary>
    let division = _prefixId.prefix "division"
    /// <summary>
    ///   <para>rdfs:label : eventGender</para>
    ///   <para>rdfs:comment : Relates a competition to a gender class instance.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/eventGender">sport:eventGender</a>
    /// </summary>
    let eventGender = _prefixId.prefix "eventGender"
    /// <summary>
    ///   <para>rdfs:label : firstRound</para>
    ///   <para>rdfs:comment : Relates a multi-round competition to the first round in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/firstRound">sport:firstRound</a>
    /// </summary>
    let firstRound = _prefixId.prefix "firstRound"
    /// <summary>
    ///   <para>rdfs:label : firstSession</para>
    ///   <para>rdfs:comment : Relates a competition to the first session of a series of sessions.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/firstSession">sport:firstSession</a>
    /// </summary>
    let firstSession = _prefixId.prefix "firstSession"
    /// <summary>
    ///   <para>rdfs:label : firstStage</para>
    ///   <para>rdfs:comment : Relates a multi-stage competition to its first stage in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/firstStage">sport:firstStage</a>
    /// </summary>
    let firstStage = _prefixId.prefix "firstStage"
    /// <summary>
    ///   <para>rdfs:label : firstUnitCompetition</para>
    ///   <para>rdfs:comment : Relates a competition to its first unit competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/firstUnitCompetition">sport:firstUnitCompetition</a>
    /// </summary>
    let firstUnitCompetition = _prefixId.prefix "firstUnitCompetition"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Legacy property used to associate a team with the country flag it represented during the olympics^^xsd:string</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/flagImage">sport:flagImage</a>
    /// </summary>
    let flagImage = _prefixId.prefix "flagImage"
    /// <summary>
    ///   <para>rdfs:label : hasCompetedFor</para>
    ///   <para>rdfs:comment : Associates an agent with sporting organisations non-temporally.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasCompetedFor">sport:hasCompetedFor</a>
    /// </summary>
    let hasCompetedFor = _prefixId.prefix "hasCompetedFor"
    /// <summary>
    ///   <para>rdfs:label : hasCompetitor</para>
    ///   <para>rdfs:comment : Relates a competition to a competitor in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasCompetitor">sport:hasCompetitor</a>
    /// </summary>
    let hasCompetitor = _prefixId.prefix "hasCompetitor"
    /// <summary>
    ///   <para>rdfs:label : hasDivision</para>
    ///   <para>rdfs:comment : Relates a divisional competition to a division in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasDivision">sport:hasDivision</a>
    /// </summary>
    let hasDivision = _prefixId.prefix "hasDivision"
    let hasDivisionList = _prefixId.prefix "hasDivisionList"
    /// <summary>
    ///   <para>rdfs:label : hasGroup</para>
    ///   <para>rdfs:comment : Relates a league competition to a corresponding group competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasGroup">sport:hasGroup</a>
    /// </summary>
    let hasGroup = _prefixId.prefix "hasGroup"
    /// <summary>
    ///   <para>rdfs:label : hasHome</para>
    ///   <para>rdfs:comment : Relates a Competitive Sporting Organisation to its home ground, stadium or location.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasHome">sport:hasHome</a>
    /// </summary>
    let hasHome = _prefixId.prefix "hasHome"
    /// <summary>
    ///   <para>rdfs:label : hasMatch</para>
    ///   <para>rdfs:comment : Relates a round to a match.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasMatch">sport:hasMatch</a>
    /// </summary>
    let hasMatch = _prefixId.prefix "hasMatch"
    /// <summary>
    ///   <para>rdfs:label : hasRound</para>
    ///   <para>rdfs:comment : Relates a multi-round competition to a round in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasRound">sport:hasRound</a>
    /// </summary>
    let hasRound = _prefixId.prefix "hasRound"
    /// <summary>
    ///   <para>rdfs:label : hasSession</para>
    ///   <para>rdfs:comment : Relates a competition to a session within that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasSession">sport:hasSession</a>
    /// </summary>
    let hasSession = _prefixId.prefix "hasSession"
    /// <summary>
    ///   <para>rdfs:label : hasStage</para>
    ///   <para>rdfs:comment : Relates a multi-stage competition to a stage that it contains.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasStage">sport:hasStage</a>
    /// </summary>
    let hasStage = _prefixId.prefix "hasStage"
    /// <summary>
    ///   <para>rdfs:label : hasUnitCompetition</para>
    ///   <para>rdfs:comment : Relates a round to a unit competition in that round.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/hasUnitCompetition">sport:hasUnitCompetition</a>
    /// </summary>
    let hasUnitCompetition = _prefixId.prefix "hasUnitCompetition"
    /// <summary>
    ///   <para>rdfs:label : homeCompetitor</para>
    ///   <para>rdfs:comment : Relates a match to one competitor, by definition or designation not the away competitor.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/homeCompetitor">sport:homeCompetitor</a>
    /// </summary>
    let homeCompetitor = _prefixId.prefix "homeCompetitor"

    /// <summary>
    ///   <para>rdfs:label : isCompetitiveSportingOrganisationOf</para>
    ///   <para>rdfs:comment : Relates a competitive sporting group to a competitive sporting organisation.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/isCompetitiveSportingOrganisationOf">sport:isCompetitiveSportingOrganisationOf</a>
    /// </summary>
    let isCompetitiveSportingOrganisationOf =
        _prefixId.prefix "isCompetitiveSportingOrganisationOf"

    /// <summary>
    ///   <para>rdfs:label : isGroupOf</para>
    ///   <para>rdfs:comment : Relates a group competition to its corresponding League competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/isGroupOf">sport:isGroupOf</a>
    /// </summary>
    let isGroupOf = _prefixId.prefix "isGroupOf"
    /// <summary>
    ///   <para>rdfs:label : isMatchOf</para>
    ///   <para>rdfs:comment : Relates a match to a round.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/isMatchOf">sport:isMatchOf</a>
    /// </summary>
    let isMatchOf = _prefixId.prefix "isMatchOf"
    /// <summary>
    ///   <para>rdfs:label : isRoundOf</para>
    ///   <para>rdfs:comment : Relates a round to its corresponding multi-round competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/isRoundOf">sport:isRoundOf</a>
    /// </summary>
    let isRoundOf = _prefixId.prefix "isRoundOf"
    /// <summary>
    ///   <para>rdfs:label : isSessionOf</para>
    ///   <para>rdfs:comment : Relates a session to a competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/isSessionOf">sport:isSessionOf</a>
    /// </summary>
    let isSessionOf = _prefixId.prefix "isSessionOf"
    /// <summary>
    ///   <para>rdfs:label : isStageOf</para>
    ///   <para>rdfs:comment : Relates a stage to a multi-stage competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/isStageOf">sport:isStageOf</a>
    /// </summary>
    let isStageOf = _prefixId.prefix "isStageOf"
    /// <summary>
    ///   <para>rdfs:label : lastRound</para>
    ///   <para>rdfs:comment : Relates a multi-round competition to the last round in that competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/lastRound">sport:lastRound</a>
    /// </summary>
    let lastRound = _prefixId.prefix "lastRound"
    /// <summary>
    ///   <para>rdfs:label : lastSession</para>
    ///   <para>rdfs:comment : Relates a competition to the last session of a series of sessions.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/lastSession">sport:lastSession</a>
    /// </summary>
    let lastSession = _prefixId.prefix "lastSession"
    /// <summary>
    ///   <para>rdfs:label : lastStage</para>
    ///   <para>rdfs:comment : Relates a stage in a multi-stage competition to its last stage.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/lastStage">sport:lastStage</a>
    /// </summary>
    let lastStage = _prefixId.prefix "lastStage"
    /// <summary>
    ///   <para>rdfs:label : lastUnitCompetition</para>
    ///   <para>rdfs:comment : Relates a competition to its last unit competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/lastUnitCompetition">sport:lastUnitCompetition</a>
    /// </summary>
    let lastUnitCompetition = _prefixId.prefix "lastUnitCompetition"
    /// <summary>
    ///   <para>rdfs:label : nextRound</para>
    ///   <para>rdfs:comment : Relates a round in a multi-round competition to its next round.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/nextRound">sport:nextRound</a>
    /// </summary>
    let nextRound = _prefixId.prefix "nextRound"
    /// <summary>
    ///   <para>rdfs:label : nextSession</para>
    ///   <para>rdfs:comment : Relates a session to its next session.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/nextSession">sport:nextSession</a>
    /// </summary>
    let nextSession = _prefixId.prefix "nextSession"
    /// <summary>
    ///   <para>rdfs:label : nextStage</para>
    ///   <para>rdfs:comment : Relates a stage in a multi-stage competition to its next stage.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/nextStage">sport:nextStage</a>
    /// </summary>
    let nextStage = _prefixId.prefix "nextStage"
    /// <summary>
    ///   <para>rdfs:label : nextUnitCompetition</para>
    ///   <para>rdfs:comment : Relates a unit competition to its next unit competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/nextUnitCompetition">sport:nextUnitCompetition</a>
    /// </summary>
    let nextUnitCompetition = _prefixId.prefix "nextUnitCompetition"
    /// <summary>
    ///   <para>rdfs:label : prevRound</para>
    ///   <para>rdfs:comment : Relates a round in a multi-round competition to its previous round.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/prevRound">sport:prevRound</a>
    /// </summary>
    let prevRound = _prefixId.prefix "prevRound"
    /// <summary>
    ///   <para>rdfs:label : prevSession</para>
    ///   <para>rdfs:comment : Relates a session to its previous session.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/prevSession">sport:prevSession</a>
    /// </summary>
    let prevSession = _prefixId.prefix "prevSession"
    /// <summary>
    ///   <para>rdfs:label : prevStage</para>
    ///   <para>rdfs:comment : Relates a stage in a multi-stage competition to its previous stage.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/prevStage">sport:prevStage</a>
    /// </summary>
    let prevStage = _prefixId.prefix "prevStage"
    /// <summary>
    ///   <para>rdfs:label : prevUnitCompetition</para>
    ///   <para>rdfs:comment : Relates a multi-round competition to its previous unit competition.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/prevUnitCompetition">sport:prevUnitCompetition</a>
    /// </summary>
    let prevUnitCompetition = _prefixId.prefix "prevUnitCompetition"
    /// <summary>
    ///   <para>rdfs:label : promotesTo</para>
    ///   <para>rdfs:comment : Relates a competition to the next competition in a heirarchy that teams are promoted to. For example the nPower Championship promotes to the Premier League.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/promotesTo">sport:promotesTo</a>
    /// </summary>
    let promotesTo = _prefixId.prefix "promotesTo"
    /// <summary>
    ///   <para>rdfs:label : recurringCompetition</para>
    ///   <para>rdfs:comment : Relates a competition to the recurring instance of that competition, for example the 2012/13 Premier League to the Premier League.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/recurringCompetition">sport:recurringCompetition</a>
    /// </summary>
    let recurringCompetition = _prefixId.prefix "recurringCompetition"
    /// <summary>
    ///   <para>rdfs:label : relegatesTo</para>
    ///   <para>rdfs:comment : Relates a competition to the previous competition in a heirarchy that teams are relegated to. For example the  Premier League relegates to the nPower Championship.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/relegatesTo">sport:relegatesTo</a>
    /// </summary>
    let relegatesTo = _prefixId.prefix "relegatesTo"
    /// <summary>
    ///   <para>rdfs:label : roundNumber</para>
    ///   <para>rdfs:comment : Indicates the sequential number of a round.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/roundNumber">sport:roundNumber</a>
    /// </summary>
    let roundNumber = _prefixId.prefix "roundNumber"
    /// <summary>
    ///   <para>rdfs:label : roundType</para>
    ///   <para>rdfs:comment : Relates a round to an enumerated round type.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/roundType">sport:roundType</a>
    /// </summary>
    let roundType = _prefixId.prefix "roundType"
    /// <summary>
    ///   <para>rdfs:label : subDiscipline</para>
    ///   <para>rdfs:comment : Relates a discipline with a child discipline, for example gymnastics with rhythmic gymnastics.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/subDiscipline">sport:subDiscipline</a>
    /// </summary>
    let subDiscipline = _prefixId.prefix "subDiscipline"
    /// <summary>
    ///   <para>rdfs:label : subDisciplineOf</para>
    ///   <para>rdfs:comment : Relates a discipline with a parent discipline, for example rhythmic gymnastics with gymnastics.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/sport/subDisciplineOf">sport:subDisciplineOf</a>
    /// </summary>
    let subDisciplineOf = _prefixId.prefix "subDisciplineOf"
