namespace http.www.bbc.co.uk.ontologies.sport.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bbcsport =
    let _namespace_iri = Namespace_Iri bbcsport |> NamespaceIRI
    /// <summary>
    ///   <para>bbcsport:2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/2.0">http://www.bbc.co.uk/ontologies/sport/2.0</seealso>
    let ``_2.0`` = Prefixed_Name(bbcsport, "2.0") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:2.11</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/2.11">http://www.bbc.co.uk/ontologies/sport/2.11</seealso>
    let ``_2.11`` = Prefixed_Name(bbcsport, "2.11") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:3.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/3.1">http://www.bbc.co.uk/ontologies/sport/3.1</seealso>
    let ``_3.1`` = Prefixed_Name(bbcsport, "3.1") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:3.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/3.2">http://www.bbc.co.uk/ontologies/sport/3.2</seealso>
    let ``_3.2`` = Prefixed_Name(bbcsport, "3.2") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:CompetesForRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Legacy class, used for associating an athlete with the national team they competed for during the Summer Olympics. Deprecated due to improper naming."</para>
    /// labels<para>"CompetesForRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/CompetesForRole">http://www.bbc.co.uk/ontologies/sport/CompetesForRole</seealso>
    let CompetesForRole = Prefixed_Name(bbcsport, "CompetesForRole") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:Competition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A competitive sporting event that usually appears as an occurrence of a recurring competition, for example the recurring English Football Premier League has a seasonal competition occurrence during 2012/13"</para>
    /// labels<para>"Competition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Competition">http://www.bbc.co.uk/ontologies/sport/Competition</seealso>
    let Competition = Prefixed_Name(bbcsport, "Competition") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:CompetitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumerated competition types, for example: domestic, international."</para>
    /// labels<para>"CompetitionType"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/CompetitionType">http://www.bbc.co.uk/ontologies/sport/CompetitionType</seealso>
    let CompetitionType = Prefixed_Name(bbcsport, "CompetitionType") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:CompetitiveSportingGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The group of people that are available to compete in a particular competition. Two groups with the same members are not necessarily the same group."</para>
    /// labels<para>"CompetitiveSportingGroup"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingGroup">http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingGroup</seealso>
    let CompetitiveSportingGroup =
        Prefixed_Name(bbcsport, "CompetitiveSportingGroup") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:CompetitiveSportingOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sporting organisation that participates in competitive sporting events. For example Manchester United or Team GB at the Olympics."</para>
    /// labels<para>"CompetitiveSportingOrganisation"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingOrganisation">http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingOrganisation</seealso>
    let CompetitiveSportingOrganisation =
        Prefixed_Name(bbcsport, "CompetitiveSportingOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:CompetitiveSportingRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"General description of the participation of players, drivers, riders etc, in groups and organisations."</para>
    /// labels<para>"CompetitiveSportingRole"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingRole">http://www.bbc.co.uk/ontologies/sport/CompetitiveSportingRole</seealso>
    let CompetitiveSportingRole =
        Prefixed_Name(bbcsport, "CompetitiveSportingRole") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:DivisionalCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Divisional Competition is a competition that is divided into a number of competitions. London 2012 is an example of a Divisional Competition."</para>
    /// labels<para>"DivisionalCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/DivisionalCompetition">http://www.bbc.co.uk/ontologies/sport/DivisionalCompetition</seealso>
    let DivisionalCompetition =
        Prefixed_Name(bbcsport, "DivisionalCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:EventGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumerated type, typically Male, Female or Mixed."</para>
    /// labels<para>"EventGender"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/EventGender">http://www.bbc.co.uk/ontologies/sport/EventGender</seealso>
    let EventGender = Prefixed_Name(bbcsport, "EventGender") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:GoverningBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Governing Body for a sport, such as The Football Association."</para>
    /// labels<para>"GoverningBody"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/GoverningBody">http://www.bbc.co.uk/ontologies/sport/GoverningBody</seealso>
    let GoverningBody = Prefixed_Name(bbcsport, "GoverningBody") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:GroupCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organisation as a collection of leagues used to select the top N competitors from each league."</para>
    /// labels<para>"GroupCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/GroupCompetition">http://www.bbc.co.uk/ontologies/sport/GroupCompetition</seealso>
    let GroupCompetition = Prefixed_Name(bbcsport, "GroupCompetition") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:Home</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The home ground, stadium or location of a Competitive Sporting Organisation."</para>
    /// labels<para>"Home"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Home">http://www.bbc.co.uk/ontologies/sport/Home</seealso>
    let Home = Prefixed_Name(bbcsport, "Home") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:KnockoutCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A competition or stage of competition that progresses through rounds of individual fixtures whereby one team is eliminated as a result of each fixture."</para>
    /// labels<para>"KnockoutCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/KnockoutCompetition">http://www.bbc.co.uk/ontologies/sport/KnockoutCompetition</seealso>
    let KnockoutCompetition =
        Prefixed_Name(bbcsport, "KnockoutCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:LeagueCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A League Competition is a hierarchy of competitions or competition within such a hierarchy."</para>
    /// labels<para>"LeagueCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/LeagueCompetition">http://www.bbc.co.uk/ontologies/sport/LeagueCompetition</seealso>
    let LeagueCompetition = Prefixed_Name(bbcsport, "LeagueCompetition") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:Match</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The smallest unit of sporting competition."</para>
    /// labels<para>"Match"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Match">http://www.bbc.co.uk/ontologies/sport/Match</seealso>
    let Match = Prefixed_Name(bbcsport, "Match") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:MedalCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A competition that results in the awarding of a medal to the winner or runner up in that competition."</para>
    /// labels<para>"MedalCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/MedalCompetition">http://www.bbc.co.uk/ontologies/sport/MedalCompetition</seealso>
    let MedalCompetition = Prefixed_Name(bbcsport, "MedalCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:MultiDisciplineCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A competition that incorporates a number of different sports, such as the Olympics."</para>
    /// labels<para>"MultiDisciplineCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/MultiDisciplineCompetition">http://www.bbc.co.uk/ontologies/sport/MultiDisciplineCompetition</seealso>
    let MultiDisciplineCompetition =
        Prefixed_Name(bbcsport, "MultiDisciplineCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:MultiDisciplineRecurringCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A recurring sports competition the covers many sports, such as the Summer Olympics."</para>
    /// labels<para>"MultiDisciplineRecurringCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/MultiDisciplineRecurringCompetition">http://www.bbc.co.uk/ontologies/sport/MultiDisciplineRecurringCompetition</seealso>
    let MultiDisciplineRecurringCompetition =
        Prefixed_Name(bbcsport, "MultiDisciplineRecurringCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:MultiRoundCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Competition organised as a sequence of rounds, for example the Premier League or group stage of the World Cup."</para>
    /// labels<para>"MultiRoundCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/MultiRoundCompetition">http://www.bbc.co.uk/ontologies/sport/MultiRoundCompetition</seealso>
    let MultiRoundCompetition =
        Prefixed_Name(bbcsport, "MultiRoundCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:MultiStageCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Multi-stage Competition is a competition that is organised as a set of stages. An example is the Football World Cup."</para>
    /// labels<para>"MultiStageCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/MultiStageCompetition">http://www.bbc.co.uk/ontologies/sport/MultiStageCompetition</seealso>
    let MultiStageCompetition =
        Prefixed_Name(bbcsport, "MultiStageCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An athlete or other person with typically a participating role in a CompetitiveSportingOrganisation."</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Person">http://www.bbc.co.uk/ontologies/sport/Person</seealso>
    let Person = Prefixed_Name(bbcsport, "Person") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:RecurringCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A recurring sports competition such as the Rugby Super League."</para>
    /// labels<para>"RecurringCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/RecurringCompetition">http://www.bbc.co.uk/ontologies/sport/RecurringCompetition</seealso>
    let RecurringCompetition =
        Prefixed_Name(bbcsport, "RecurringCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:Round</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A round is one or more competitions that is part of a Multi-Round Competition. Examples include the first round of Wimbledon and the final round of the FA Cup."</para>
    /// labels<para>"Round"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Round">http://www.bbc.co.uk/ontologies/sport/Round</seealso>
    let Round = Prefixed_Name(bbcsport, "Round") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:RoundType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumerated round types, for example: preliminary, qualifying or final."</para>
    /// labels<para>"RoundType"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/RoundType">http://www.bbc.co.uk/ontologies/sport/RoundType</seealso>
    let RoundType = Prefixed_Name(bbcsport, "RoundType") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:Session</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sub-division of a competition, that must be broken up due to the duration of that competition, occurring for example in snooker or cricket."</para>
    /// labels<para>"Session"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Session">http://www.bbc.co.uk/ontologies/sport/Session</seealso>
    let Session = Prefixed_Name(bbcsport, "Session") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:SportingOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organisation involved in Sport, for example a Football team or the UK Government Department for Culture, Media and Sport."</para>
    /// labels<para>"SportingOrganisation"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/SportingOrganisation">http://www.bbc.co.uk/ontologies/sport/SportingOrganisation</seealso>
    let SportingOrganisation =
        Prefixed_Name(bbcsport, "SportingOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:SportsDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of discipline a sporting event involves."</para>
    /// labels<para>"SportsDiscipline"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/SportsDiscipline">http://www.bbc.co.uk/ontologies/sport/SportsDiscipline</seealso>
    let SportsDiscipline = Prefixed_Name(bbcsport, "SportsDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:UnitCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit competition is the unit of competition defined by a competition discipline rules. Examples include a 100m race or Football match."</para>
    /// labels<para>"UnitCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/UnitCompetition">http://www.bbc.co.uk/ontologies/sport/UnitCompetition</seealso>
    let UnitCompetition = Prefixed_Name(bbcsport, "UnitCompetition") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:Venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The location of a sporting event. May be a stadium, track, lake etc."</para>
    /// labels<para>"Venue"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/Venue">http://www.bbc.co.uk/ontologies/sport/Venue</seealso>
    let Venue = Prefixed_Name(bbcsport, "Venue") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:awayCompetitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a match to one competitor, by definition or designation not the home competitor."</para>
    /// labels<para>"awayCompetitor"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/awayCompetitor">http://www.bbc.co.uk/ontologies/sport/awayCompetitor</seealso>
    let awayCompetitor = Prefixed_Name(bbcsport, "awayCompetitor") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:competesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competitor, team or other agent to a competition."</para>
    /// labels<para>"competesIn"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/competesIn">http://www.bbc.co.uk/ontologies/sport/competesIn</seealso>
    let competesIn = Prefixed_Name(bbcsport, "competesIn") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:competitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates something, typically a competition, to an enumerated competition type."</para>
    /// labels<para>"competitionType"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/competitionType">http://www.bbc.co.uk/ontologies/sport/competitionType</seealso>
    let competitionType = Prefixed_Name(bbcsport, "competitionType") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:dateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Implemented because foaf has no notion of date of birth. Deprecated in favour of core:dateOfBirth."</para>
    /// labels<para>"dateOfBirth"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/dateOfBirth">http://www.bbc.co.uk/ontologies/sport/dateOfBirth</seealso>
    let dateOfBirth = Prefixed_Name(bbcsport, "dateOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:discipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates something to a sporting discipline, for example a person to athletics."</para>
    /// labels<para>"discipline"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/discipline">http://www.bbc.co.uk/ontologies/sport/discipline</seealso>
    let discipline = Prefixed_Name(bbcsport, "discipline") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:division</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Division relates a DivisionalCompetition to a competition which is a division of that DivisionalCompetition. Used for the olympics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/division">http://www.bbc.co.uk/ontologies/sport/division</seealso>
    let division = Prefixed_Name(bbcsport, "division") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:eventGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to a gender class instance."</para>
    /// labels<para>"eventGender"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/eventGender">http://www.bbc.co.uk/ontologies/sport/eventGender</seealso>
    let eventGender = Prefixed_Name(bbcsport, "eventGender") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:firstRound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a multi-round competition to the first round in that competition."</para>
    /// labels<para>"firstRound"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/firstRound">http://www.bbc.co.uk/ontologies/sport/firstRound</seealso>
    let firstRound = Prefixed_Name(bbcsport, "firstRound") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:firstSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to the first session of a series of sessions."</para>
    /// labels<para>"firstSession"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/firstSession">http://www.bbc.co.uk/ontologies/sport/firstSession</seealso>
    let firstSession = Prefixed_Name(bbcsport, "firstSession") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:firstStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a multi-stage competition to its first stage in that competition."</para>
    /// labels<para>"firstStage"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/firstStage">http://www.bbc.co.uk/ontologies/sport/firstStage</seealso>
    let firstStage = Prefixed_Name(bbcsport, "firstStage") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:firstUnitCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to its first unit competition."</para>
    /// labels<para>"firstUnitCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/firstUnitCompetition">http://www.bbc.co.uk/ontologies/sport/firstUnitCompetition</seealso>
    let firstUnitCompetition =
        Prefixed_Name(bbcsport, "firstUnitCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:flagImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Legacy property used to associate a team with the country flag it represented during the olympics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/flagImage">http://www.bbc.co.uk/ontologies/sport/flagImage</seealso>
    let flagImage = Prefixed_Name(bbcsport, "flagImage") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasCompetedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates an agent with sporting organisations non-temporally."</para>
    /// labels<para>"hasCompetedFor"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasCompetedFor">http://www.bbc.co.uk/ontologies/sport/hasCompetedFor</seealso>
    let hasCompetedFor = Prefixed_Name(bbcsport, "hasCompetedFor") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasCompetitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to a competitor in that competition."</para>
    /// labels<para>"hasCompetitor"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasCompetitor">http://www.bbc.co.uk/ontologies/sport/hasCompetitor</seealso>
    let hasCompetitor = Prefixed_Name(bbcsport, "hasCompetitor") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a divisional competition to a division in that competition."</para>
    /// labels<para>"hasDivision"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasDivision">http://www.bbc.co.uk/ontologies/sport/hasDivision</seealso>
    let hasDivision = Prefixed_Name(bbcsport, "hasDivision") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasDivisionList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasDivisionList">http://www.bbc.co.uk/ontologies/sport/hasDivisionList</seealso>
    let hasDivisionList = Prefixed_Name(bbcsport, "hasDivisionList") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a league competition to a corresponding group competition."</para>
    /// labels<para>"hasGroup"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasGroup">http://www.bbc.co.uk/ontologies/sport/hasGroup</seealso>
    let hasGroup = Prefixed_Name(bbcsport, "hasGroup") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasHome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Competitive Sporting Organisation to its home ground, stadium or location."</para>
    /// labels<para>"hasHome"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasHome">http://www.bbc.co.uk/ontologies/sport/hasHome</seealso>
    let hasHome = Prefixed_Name(bbcsport, "hasHome") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a round to a match."</para>
    /// labels<para>"hasMatch"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasMatch">http://www.bbc.co.uk/ontologies/sport/hasMatch</seealso>
    let hasMatch = Prefixed_Name(bbcsport, "hasMatch") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasRound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a multi-round competition to a round in that competition."</para>
    /// labels<para>"hasRound"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasRound">http://www.bbc.co.uk/ontologies/sport/hasRound</seealso>
    let hasRound = Prefixed_Name(bbcsport, "hasRound") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to a session within that competition."</para>
    /// labels<para>"hasSession"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasSession">http://www.bbc.co.uk/ontologies/sport/hasSession</seealso>
    let hasSession = Prefixed_Name(bbcsport, "hasSession") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:hasStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a multi-stage competition to a stage that it contains."</para>
    /// labels<para>"hasStage"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasStage">http://www.bbc.co.uk/ontologies/sport/hasStage</seealso>
    let hasStage = Prefixed_Name(bbcsport, "hasStage") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:hasUnitCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a round to a unit competition in that round."</para>
    /// labels<para>"hasUnitCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/hasUnitCompetition">http://www.bbc.co.uk/ontologies/sport/hasUnitCompetition</seealso>
    let hasUnitCompetition =
        Prefixed_Name(bbcsport, "hasUnitCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:homeCompetitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a match to one competitor, by definition or designation not the away competitor."</para>
    /// labels<para>"homeCompetitor"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/homeCompetitor">http://www.bbc.co.uk/ontologies/sport/homeCompetitor</seealso>
    let homeCompetitor = Prefixed_Name(bbcsport, "homeCompetitor") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:isCompetitiveSportingOrganisationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competitive sporting group to a competitive sporting organisation."</para>
    /// labels<para>"isCompetitiveSportingOrganisationOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/isCompetitiveSportingOrganisationOf">http://www.bbc.co.uk/ontologies/sport/isCompetitiveSportingOrganisationOf</seealso>
    let isCompetitiveSportingOrganisationOf =
        Prefixed_Name(bbcsport, "isCompetitiveSportingOrganisationOf") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:isGroupOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a group competition to its corresponding League competition."</para>
    /// labels<para>"isGroupOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/isGroupOf">http://www.bbc.co.uk/ontologies/sport/isGroupOf</seealso>
    let isGroupOf = Prefixed_Name(bbcsport, "isGroupOf") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:isMatchOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a match to a round."</para>
    /// labels<para>"isMatchOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/isMatchOf">http://www.bbc.co.uk/ontologies/sport/isMatchOf</seealso>
    let isMatchOf = Prefixed_Name(bbcsport, "isMatchOf") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:isRoundOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a round to its corresponding multi-round competition."</para>
    /// labels<para>"isRoundOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/isRoundOf">http://www.bbc.co.uk/ontologies/sport/isRoundOf</seealso>
    let isRoundOf = Prefixed_Name(bbcsport, "isRoundOf") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:isSessionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a session to a competition."</para>
    /// labels<para>"isSessionOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/isSessionOf">http://www.bbc.co.uk/ontologies/sport/isSessionOf</seealso>
    let isSessionOf = Prefixed_Name(bbcsport, "isSessionOf") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:isStageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a stage to a multi-stage competition."</para>
    /// labels<para>"isStageOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/isStageOf">http://www.bbc.co.uk/ontologies/sport/isStageOf</seealso>
    let isStageOf = Prefixed_Name(bbcsport, "isStageOf") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:lastRound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a multi-round competition to the last round in that competition."</para>
    /// labels<para>"lastRound"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/lastRound">http://www.bbc.co.uk/ontologies/sport/lastRound</seealso>
    let lastRound = Prefixed_Name(bbcsport, "lastRound") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:lastSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to the last session of a series of sessions."</para>
    /// labels<para>"lastSession"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/lastSession">http://www.bbc.co.uk/ontologies/sport/lastSession</seealso>
    let lastSession = Prefixed_Name(bbcsport, "lastSession") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:lastStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a stage in a multi-stage competition to its last stage."</para>
    /// labels<para>"lastStage"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/lastStage">http://www.bbc.co.uk/ontologies/sport/lastStage</seealso>
    let lastStage = Prefixed_Name(bbcsport, "lastStage") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:lastUnitCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to its last unit competition."</para>
    /// labels<para>"lastUnitCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/lastUnitCompetition">http://www.bbc.co.uk/ontologies/sport/lastUnitCompetition</seealso>
    let lastUnitCompetition =
        Prefixed_Name(bbcsport, "lastUnitCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:nextRound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a round in a multi-round competition to its next round."</para>
    /// labels<para>"nextRound"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/nextRound">http://www.bbc.co.uk/ontologies/sport/nextRound</seealso>
    let nextRound = Prefixed_Name(bbcsport, "nextRound") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:nextSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a session to its next session."</para>
    /// labels<para>"nextSession"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/nextSession">http://www.bbc.co.uk/ontologies/sport/nextSession</seealso>
    let nextSession = Prefixed_Name(bbcsport, "nextSession") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:nextStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a stage in a multi-stage competition to its next stage."</para>
    /// labels<para>"nextStage"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/nextStage">http://www.bbc.co.uk/ontologies/sport/nextStage</seealso>
    let nextStage = Prefixed_Name(bbcsport, "nextStage") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:nextUnitCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a unit competition to its next unit competition."</para>
    /// labels<para>"nextUnitCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/nextUnitCompetition">http://www.bbc.co.uk/ontologies/sport/nextUnitCompetition</seealso>
    let nextUnitCompetition =
        Prefixed_Name(bbcsport, "nextUnitCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:prevRound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a round in a multi-round competition to its previous round."</para>
    /// labels<para>"prevRound"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/prevRound">http://www.bbc.co.uk/ontologies/sport/prevRound</seealso>
    let prevRound = Prefixed_Name(bbcsport, "prevRound") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:prevSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a session to its previous session."</para>
    /// labels<para>"prevSession"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/prevSession">http://www.bbc.co.uk/ontologies/sport/prevSession</seealso>
    let prevSession = Prefixed_Name(bbcsport, "prevSession") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:prevStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a stage in a multi-stage competition to its previous stage."</para>
    /// labels<para>"prevStage"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/prevStage">http://www.bbc.co.uk/ontologies/sport/prevStage</seealso>
    let prevStage = Prefixed_Name(bbcsport, "prevStage") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:prevUnitCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a multi-round competition to its previous unit competition."</para>
    /// labels<para>"prevUnitCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/prevUnitCompetition">http://www.bbc.co.uk/ontologies/sport/prevUnitCompetition</seealso>
    let prevUnitCompetition =
        Prefixed_Name(bbcsport, "prevUnitCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:promotesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to the next competition in a heirarchy that teams are promoted to. For example the nPower Championship promotes to the Premier League."</para>
    /// labels<para>"promotesTo"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/promotesTo">http://www.bbc.co.uk/ontologies/sport/promotesTo</seealso>
    let promotesTo = Prefixed_Name(bbcsport, "promotesTo") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:recurringCompetition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to the recurring instance of that competition, for example the 2012/13 Premier League to the Premier League."</para>
    /// labels<para>"recurringCompetition"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/recurringCompetition">http://www.bbc.co.uk/ontologies/sport/recurringCompetition</seealso>
    let recurringCompetition =
        Prefixed_Name(bbcsport, "recurringCompetition") |> PrefixedName

    /// <summary>
    ///   <para>bbcsport:relegatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a competition to the previous competition in a heirarchy that teams are relegated to. For example the  Premier League relegates to the nPower Championship."</para>
    /// labels<para>"relegatesTo"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/relegatesTo">http://www.bbc.co.uk/ontologies/sport/relegatesTo</seealso>
    let relegatesTo = Prefixed_Name(bbcsport, "relegatesTo") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:roundNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the sequential number of a round."</para>
    /// labels<para>"roundNumber"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/roundNumber">http://www.bbc.co.uk/ontologies/sport/roundNumber</seealso>
    let roundNumber = Prefixed_Name(bbcsport, "roundNumber") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:roundType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a round to an enumerated round type."</para>
    /// labels<para>"roundType"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/roundType">http://www.bbc.co.uk/ontologies/sport/roundType</seealso>
    let roundType = Prefixed_Name(bbcsport, "roundType") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:subDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a discipline with a child discipline, for example gymnastics with rhythmic gymnastics."</para>
    /// labels<para>"subDiscipline"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/subDiscipline">http://www.bbc.co.uk/ontologies/sport/subDiscipline</seealso>
    let subDiscipline = Prefixed_Name(bbcsport, "subDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>bbcsport:subDisciplineOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a discipline with a parent discipline, for example rhythmic gymnastics with gymnastics."</para>
    /// labels<para>"subDisciplineOf"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/sport/subDisciplineOf">http://www.bbc.co.uk/ontologies/sport/subDisciplineOf</seealso>
    let subDisciplineOf = Prefixed_Name(bbcsport, "subDisciplineOf") |> PrefixedName
