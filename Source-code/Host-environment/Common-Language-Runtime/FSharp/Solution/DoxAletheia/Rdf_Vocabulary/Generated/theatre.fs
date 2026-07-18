namespace http.purl.org.theatre.hash

open DoxAletheia.Rdf_Vocabulary

module theatre =
    let _namespace_name = "http://purl.org/theatre#"

    /// <summary>
    /// A Provision which makes an ev:Event more accessible
    /// <see href="http://purl.org/theatre#AccessibilityProvision"></see></summary>
    let AccessibilityProvision =
        Namespaced_IRI.parse _namespace_name "AccessibilityProvision" |> NamespacedName

    /// <summary>
    /// An event which involves discussion/planning, often with a formal tone.
    /// <see href="http://purl.org/theatre#Meeting"></see></summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName

    /// <summary>
    /// A Project which intends to evoke a response from an Audience.
    /// <see href="http://purl.org/theatre#PerformableProject"></see></summary>
    let PerformableProject =
        Namespaced_IRI.parse _namespace_name "PerformableProject" |> NamespacedName

    /// <summary>
    /// A Position which involes portraying a Character.
    /// <see href="http://purl.org/theatre#Portrayal"></see></summary>
    let Portrayal = Namespaced_IRI.parse _namespace_name "Portrayal" |> NamespacedName
    /// <summary>
    /// A set of responibilities.
    /// <see href="http://purl.org/theatre#Position"></see></summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName
    /// <summary>
    /// A performance which reviewers are encouraged to attend.
    /// <see href="http://purl.org/theatre#PressNight"></see></summary>
    let PressNight = Namespaced_IRI.parse _namespace_name "PressNight" |> NamespacedName
    /// <summary>
    /// The realisation of a theatrical work.
    /// <see href="http://purl.org/theatre#Production"></see></summary>
    let Production = Namespaced_IRI.parse _namespace_name "Production" |> NamespacedName

    /// <summary>
    /// An Organisation which puts on Productions.
    /// <see href="http://purl.org/theatre#ProductionCompany"></see></summary>
    let ProductionCompany =
        Namespaced_IRI.parse _namespace_name "ProductionCompany" |> NamespacedName

    /// <summary>
    /// An event which involves preparatory work for a Performance.
    /// <see href="http://purl.org/theatre#Rehearsal"></see></summary>
    let Rehearsal = Namespaced_IRI.parse _namespace_name "Rehearsal" |> NamespacedName

    /// <summary>
    /// An unpolished performance in which the cast read from scripts.
    /// <see href="http://purl.org/theatre#RehearsalReading"></see></summary>
    let RehearsalReading =
        Namespaced_IRI.parse _namespace_name "RehearsalReading" |> NamespacedName

    /// <summary>
    /// An event which involves preparatory work for a Performance.
    /// <see href="http://purl.org/theatre#Rehersal"></see></summary>
    let Rehersal = Namespaced_IRI.parse _namespace_name "Rehersal" |> NamespacedName

    /// <summary>
    /// An unpolished performance in which the cast read from scripts.
    /// <see href="http://purl.org/theatre#RehersalReading"></see></summary>
    let RehersalReading =
        Namespaced_IRI.parse _namespace_name "RehersalReading" |> NamespacedName

    /// <summary>
    /// A collection of Productions and/or Performances
    /// <see href="http://purl.org/theatre#Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    /// The writing/devising which may enable a Production.
    /// <see href="http://purl.org/theatre#Show"></see></summary>
    let Show = Namespaced_IRI.parse _namespace_name "Show" |> NamespacedName
    /// <summary>
    /// A Nestable Spatial Thing used for Theatrical Events.
    /// <see href="http://purl.org/theatre#Venue"></see></summary>
    let Venue = Namespaced_IRI.parse _namespace_name "Venue" |> NamespacedName
    /// <summary>
    /// The voice classification for a Singer or singing part.
    /// <see href="http://purl.org/theatre#Voice"></see></summary>
    let Voice = Namespaced_IRI.parse _namespace_name "Voice" |> NamespacedName
    /// <summary>
    /// An event which involves participation, mainly with an educational focus.
    /// <see href="http://purl.org/theatre#Workshop"></see></summary>
    let Workshop = Namespaced_IRI.parse _namespace_name "Workshop" |> NamespacedName

    /// <summary>
    /// Associates an Accessibility Provision with an Event
    /// <see href="http://purl.org/theatre#accessibility_provision"></see></summary>
    let accessibility_provision =
        Namespaced_IRI.parse _namespace_name "accessibility_provision" |> NamespacedName

    /// <summary>
    /// Associates a Role with an Agent.
    /// <see href="http://purl.org/theatre#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName

    /// <summary>
    /// A restriction on who can attend a particular performance
    /// <see href="http://purl.org/theatre#audience_restriction"></see></summary>
    let audience_restriction =
        Namespaced_IRI.parse _namespace_name "audience_restriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/theatre#Performance"></see>
    /// </summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    /// Indicates a Work that another Work was based on .
    /// <see href="http://purl.org/theatre#based_on"></see></summary>
    let based_on = Namespaced_IRI.parse _namespace_name "based_on" |> NamespacedName
    /// <summary>
    /// Associates a Project with a Role.
    /// <see href="http://purl.org/theatre#credit"></see></summary>
    let credit = Namespaced_IRI.parse _namespace_name "credit" |> NamespacedName
    /// <summary>
    /// Associates a Role with a Project.
    /// <see href="http://purl.org/theatre#project"></see></summary>
    let project = Namespaced_IRI.parse _namespace_name "project" |> NamespacedName
    /// <summary>
    /// Associates a Project with an Event.
    /// <see href="http://purl.org/theatre#event"></see></summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName
    /// <summary>
    /// Associates a Genre with a Work.
    /// <see href="http://purl.org/theatre#genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName

    /// <summary>
    /// Associates a Performableproject with a Production.
    /// <see href="http://purl.org/theatre#manifestation"></see></summary>
    let manifestation =
        Namespaced_IRI.parse _namespace_name "manifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/theatre#Performableproject"></see>
    /// </summary>
    let Performableproject =
        Namespaced_IRI.parse _namespace_name "Performableproject" |> NamespacedName

    /// <summary>
    /// Associates a season with its commissioning season.
    /// <see href="http://purl.org/theatre#parent_season"></see></summary>
    let parent_season =
        Namespaced_IRI.parse _namespace_name "parent_season" |> NamespacedName

    /// <summary>
    /// Associates a Venue with its containing Venue.
    /// <see href="http://purl.org/theatre#parent_venue"></see></summary>
    let parent_venue =
        Namespaced_IRI.parse _namespace_name "parent_venue" |> NamespacedName

    /// <summary>
    /// Indicates that something is part of a season
    /// <see href="http://purl.org/theatre#part_of_season"></see></summary>
    let part_of_season =
        Namespaced_IRI.parse _namespace_name "part_of_season" |> NamespacedName

    /// <summary>
    /// Associates a Production with a Performance.
    /// <see href="http://purl.org/theatre#performance"></see></summary>
    let performance =
        Namespaced_IRI.parse _namespace_name "performance" |> NamespacedName

    /// <summary>
    /// Associates a Production with a Performance.
    /// <see href="http://purl.org/theatre#performance_of"></see></summary>
    let performance_of =
        Namespaced_IRI.parse _namespace_name "performance_of" |> NamespacedName

    /// <summary>
    /// Associates a Portrayal with a Character.
    /// <see href="http://purl.org/theatre#portrays"></see></summary>
    let portrays = Namespaced_IRI.parse _namespace_name "portrays" |> NamespacedName
    /// <summary>
    /// Associates a Role with a Position.
    /// <see href="http://purl.org/theatre#position"></see></summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    /// Indicates the first performance of a Show or Production in a particular area.
    /// <see href="http://purl.org/theatre#premiere"></see></summary>
    let premiere = Namespaced_IRI.parse _namespace_name "premiere" |> NamespacedName

    /// <summary>
    /// Associates a production with its commissioning season.
    /// <see href="http://purl.org/theatre#primary_season"></see></summary>
    let primary_season =
        Namespaced_IRI.parse _namespace_name "primary_season" |> NamespacedName

    /// <summary>
    /// Associates a Season with a Production.
    /// <see href="http://purl.org/theatre#production"></see></summary>
    let production = Namespaced_IRI.parse _namespace_name "production" |> NamespacedName

    /// <summary>
    /// Indicates that a Production is an expression of a given work or production.
    /// <see href="http://purl.org/theatre#production_of"></see></summary>
    let production_of =
        Namespaced_IRI.parse _namespace_name "production_of" |> NamespacedName

    /// <summary>
    /// The Company which puts on a Production
    /// <see href="http://purl.org/theatre#put_on_by"></see></summary>
    let put_on_by = Namespaced_IRI.parse _namespace_name "put_on_by" |> NamespacedName

    /// <summary>
    /// A performance recorded for either Simulcast or later broadcast.
    /// <see href="http://purl.org/theatre#recorded_for"></see></summary>
    let recorded_for =
        Namespaced_IRI.parse _namespace_name "recorded_for" |> NamespacedName

    /// <summary>
    /// Indicates the voice classification that a particular Operatic character has been written for.
    /// <see href="http://purl.org/theatre#scored_voice"></see></summary>
    let scored_voice =
        Namespaced_IRI.parse _namespace_name "scored_voice" |> NamespacedName

    /// <summary>
    /// The Person or Organisation who sponsors a given production or performance
    /// <see href="http://purl.org/theatre#sponsor"></see></summary>
    let sponsor = Namespaced_IRI.parse _namespace_name "sponsor" |> NamespacedName

    /// <summary>
    /// A human readable indication of when in the day a performance occurs
    /// <see href="http://purl.org/theatre#time_of_day"></see></summary>
    let time_of_day =
        Namespaced_IRI.parse _namespace_name "time_of_day" |> NamespacedName

    /// <summary>
    /// Associates an Event with the Venue it is held in.
    /// <see href="http://purl.org/theatre#venue"></see></summary>
    let venue = Namespaced_IRI.parse _namespace_name "venue" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/theatre#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// Indicates the first performance of a Show or Production on a particular planet.
    /// <see href="http://purl.org/theatre#worldPremiere"></see></summary>
    let worldPremiere =
        Namespaced_IRI.parse _namespace_name "worldPremiere" |> NamespacedName
