namespace http.purl.org.theatre.hash

open DoxAletheia

module theatre =
    let _namespace_name = "http://purl.org/theatre#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Provision which makes an ev:Event more accessible
    /// <see href="http://purl.org/theatre#AccessibilityProvision"></see></summary>
    let AccessibilityProvision = _prefix "AccessibilityProvision"
    /// <summary>
    /// An event which involves discussion/planning, often with a formal tone.
    /// <see href="http://purl.org/theatre#Meeting"></see></summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    /// A Project which intends to evoke a response from an Audience.
    /// <see href="http://purl.org/theatre#PerformableProject"></see></summary>
    let PerformableProject = _prefix "PerformableProject"
    /// <summary>
    /// A Position which involes portraying a Character.
    /// <see href="http://purl.org/theatre#Portrayal"></see></summary>
    let Portrayal = _prefix "Portrayal"
    /// <summary>
    /// A set of responibilities.
    /// <see href="http://purl.org/theatre#Position"></see></summary>
    let Position = _prefix "Position"
    /// <summary>
    /// A performance which reviewers are encouraged to attend.
    /// <see href="http://purl.org/theatre#PressNight"></see></summary>
    let PressNight = _prefix "PressNight"
    /// <summary>
    /// The realisation of a theatrical work.
    /// <see href="http://purl.org/theatre#Production"></see></summary>
    let Production = _prefix "Production"
    /// <summary>
    /// An Organisation which puts on Productions.
    /// <see href="http://purl.org/theatre#ProductionCompany"></see></summary>
    let ProductionCompany = _prefix "ProductionCompany"
    /// <summary>
    /// An event which involves preparatory work for a Performance.
    /// <see href="http://purl.org/theatre#Rehearsal"></see></summary>
    let Rehearsal = _prefix "Rehearsal"
    /// <summary>
    /// An unpolished performance in which the cast read from scripts.
    /// <see href="http://purl.org/theatre#RehearsalReading"></see></summary>
    let RehearsalReading = _prefix "RehearsalReading"
    /// <summary>
    /// An event which involves preparatory work for a Performance.
    /// <see href="http://purl.org/theatre#Rehersal"></see></summary>
    let Rehersal = _prefix "Rehersal"
    /// <summary>
    /// An unpolished performance in which the cast read from scripts.
    /// <see href="http://purl.org/theatre#RehersalReading"></see></summary>
    let RehersalReading = _prefix "RehersalReading"
    /// <summary>
    /// A collection of Productions and/or Performances
    /// <see href="http://purl.org/theatre#Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    /// The writing/devising which may enable a Production.
    /// <see href="http://purl.org/theatre#Show"></see></summary>
    let Show = _prefix "Show"
    /// <summary>
    /// A Nestable Spatial Thing used for Theatrical Events.
    /// <see href="http://purl.org/theatre#Venue"></see></summary>
    let Venue = _prefix "Venue"
    /// <summary>
    /// The voice classification for a Singer or singing part.
    /// <see href="http://purl.org/theatre#Voice"></see></summary>
    let Voice = _prefix "Voice"
    /// <summary>
    /// An event which involves participation, mainly with an educational focus.
    /// <see href="http://purl.org/theatre#Workshop"></see></summary>
    let Workshop = _prefix "Workshop"
    /// <summary>
    /// Associates an Accessibility Provision with an Event
    /// <see href="http://purl.org/theatre#accessibility_provision"></see></summary>
    let accessibility_provision = _prefix "accessibility_provision"
    /// <summary>
    /// Associates a Role with an Agent.
    /// <see href="http://purl.org/theatre#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// A restriction on who can attend a particular performance
    /// <see href="http://purl.org/theatre#audience_restriction"></see></summary>
    let audience_restriction = _prefix "audience_restriction"
    /// <summary>
    ///   <see href="http://purl.org/theatre#Performance"></see>
    /// </summary>
    let Performance = _prefix "Performance"
    /// <summary>
    /// Indicates a Work that another Work was based on .
    /// <see href="http://purl.org/theatre#based_on"></see></summary>
    let based_on = _prefix "based_on"
    /// <summary>
    /// Associates a Project with a Role.
    /// <see href="http://purl.org/theatre#credit"></see></summary>
    let credit = _prefix "credit"
    /// <summary>
    /// Associates a Role with a Project.
    /// <see href="http://purl.org/theatre#project"></see></summary>
    let project = _prefix "project"
    /// <summary>
    /// Associates a Project with an Event.
    /// <see href="http://purl.org/theatre#event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// Associates a Genre with a Work.
    /// <see href="http://purl.org/theatre#genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// Associates a Performableproject with a Production.
    /// <see href="http://purl.org/theatre#manifestation"></see></summary>
    let manifestation = _prefix "manifestation"
    /// <summary>
    ///   <see href="http://purl.org/theatre#Performableproject"></see>
    /// </summary>
    let Performableproject = _prefix "Performableproject"
    /// <summary>
    /// Associates a season with its commissioning season.
    /// <see href="http://purl.org/theatre#parent_season"></see></summary>
    let parent_season = _prefix "parent_season"
    /// <summary>
    /// Associates a Venue with its containing Venue.
    /// <see href="http://purl.org/theatre#parent_venue"></see></summary>
    let parent_venue = _prefix "parent_venue"
    /// <summary>
    /// Indicates that something is part of a season
    /// <see href="http://purl.org/theatre#part_of_season"></see></summary>
    let part_of_season = _prefix "part_of_season"
    /// <summary>
    /// Associates a Production with a Performance.
    /// <see href="http://purl.org/theatre#performance"></see></summary>
    let performance = _prefix "performance"
    /// <summary>
    /// Associates a Production with a Performance.
    /// <see href="http://purl.org/theatre#performance_of"></see></summary>
    let performance_of = _prefix "performance_of"
    /// <summary>
    /// Associates a Portrayal with a Character.
    /// <see href="http://purl.org/theatre#portrays"></see></summary>
    let portrays = _prefix "portrays"
    /// <summary>
    /// Associates a Role with a Position.
    /// <see href="http://purl.org/theatre#position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// Indicates the first performance of a Show or Production in a particular area.
    /// <see href="http://purl.org/theatre#premiere"></see></summary>
    let premiere = _prefix "premiere"
    /// <summary>
    /// Associates a production with its commissioning season.
    /// <see href="http://purl.org/theatre#primary_season"></see></summary>
    let primary_season = _prefix "primary_season"
    /// <summary>
    /// Associates a Season with a Production.
    /// <see href="http://purl.org/theatre#production"></see></summary>
    let production = _prefix "production"
    /// <summary>
    /// Indicates that a Production is an expression of a given work or production.
    /// <see href="http://purl.org/theatre#production_of"></see></summary>
    let production_of = _prefix "production_of"
    /// <summary>
    /// The Company which puts on a Production
    /// <see href="http://purl.org/theatre#put_on_by"></see></summary>
    let put_on_by = _prefix "put_on_by"
    /// <summary>
    /// A performance recorded for either Simulcast or later broadcast.
    /// <see href="http://purl.org/theatre#recorded_for"></see></summary>
    let recorded_for = _prefix "recorded_for"
    /// <summary>
    /// Indicates the voice classification that a particular Operatic character has been written for.
    /// <see href="http://purl.org/theatre#scored_voice"></see></summary>
    let scored_voice = _prefix "scored_voice"
    /// <summary>
    /// The Person or Organisation who sponsors a given production or performance
    /// <see href="http://purl.org/theatre#sponsor"></see></summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    /// A human readable indication of when in the day a performance occurs
    /// <see href="http://purl.org/theatre#time_of_day"></see></summary>
    let time_of_day = _prefix "time_of_day"
    /// <summary>
    /// Associates an Event with the Venue it is held in.
    /// <see href="http://purl.org/theatre#venue"></see></summary>
    let venue = _prefix "venue"
    /// <summary>
    ///   <see href="http://purl.org/theatre#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Indicates the first performance of a Show or Production on a particular planet.
    /// <see href="http://purl.org/theatre#worldPremiere"></see></summary>
    let worldPremiere = _prefix "worldPremiere"
