#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module theatre =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/theatre#" "theatre"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : AccessibilityProvision^^xsd:string</para>
    ///   <para>rdfs:comment : A Provision which makes an ev:Event more accessible^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#AccessibilityProvision">theatre:AccessibilityProvision</a>
    /// </summary>
    let AccessibilityProvision = _prefixId.prefix "AccessibilityProvision"
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Meeting^^xsd:string</para>
    ///   <para>rdfs:comment : An event which involves discussion/planning, often with a formal tone.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Meeting">theatre:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : PerformableProject^^xsd:string</para>
    ///   <para>rdfs:comment : A Project which intends to evoke a response from an Audience.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#PerformableProject">theatre:PerformableProject</a>
    /// </summary>
    let PerformableProject = _prefixId.prefix "PerformableProject"
    let Performableproject = _prefixId.prefix "Performableproject"
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>rdfs:label : Portrayal^^xsd:string</para>
    ///   <para>rdfs:comment : A Position which involes portraying a Character.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Portrayal">theatre:Portrayal</a>
    /// </summary>
    let Portrayal = _prefixId.prefix "Portrayal"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <para>rdfs:comment : A set of responibilities.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Position">theatre:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : PressNight^^xsd:string</para>
    ///   <para>rdfs:comment : A performance which reviewers are encouraged to attend.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#PressNight">theatre:PressNight</a>
    /// </summary>
    let PressNight = _prefixId.prefix "PressNight"
    /// <summary>
    ///   <para>rdfs:label : Production^^xsd:string</para>
    ///   <para>rdfs:comment : The realisation of a theatrical work.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Production">theatre:Production</a>
    /// </summary>
    let Production = _prefixId.prefix "Production"
    /// <summary>
    ///   <para>rdfs:label : ProductionCompany^^xsd:string</para>
    ///   <para>rdfs:comment : An Organisation which puts on Productions.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#ProductionCompany">theatre:ProductionCompany</a>
    /// </summary>
    let ProductionCompany = _prefixId.prefix "ProductionCompany"
    /// <summary>
    ///   <para>rdfs:label : Rehearsal^^xsd:string</para>
    ///   <para>rdfs:comment : An event which involves preparatory work for a Performance.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Rehearsal">theatre:Rehearsal</a>
    /// </summary>
    let Rehearsal = _prefixId.prefix "Rehearsal"
    /// <summary>
    ///   <para>rdfs:label : RehearsalReading^^xsd:string</para>
    ///   <para>rdfs:comment : An unpolished performance in which the cast read from scripts.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#RehearsalReading">theatre:RehearsalReading</a>
    /// </summary>
    let RehearsalReading = _prefixId.prefix "RehearsalReading"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : Rehersal^^xsd:string</para>
    ///   <para>rdfs:comment : An event which involves preparatory work for a Performance.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Rehersal">theatre:Rehersal</a>
    /// </summary>
    let Rehersal = _prefixId.prefix "Rehersal"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : RehersalReading^^xsd:string</para>
    ///   <para>rdfs:comment : An unpolished performance in which the cast read from scripts.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#RehersalReading">theatre:RehersalReading</a>
    /// </summary>
    let RehersalReading = _prefixId.prefix "RehersalReading"
    /// <summary>
    ///   <para>rdfs:label : Season^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of Productions and/or Performances^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Season">theatre:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : Show^^xsd:string</para>
    ///   <para>rdfs:comment : The writing/devising which may enable a Production.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Show">theatre:Show</a>
    /// </summary>
    let Show = _prefixId.prefix "Show"
    /// <summary>
    ///   <para>rdfs:label : Venue^^xsd:string</para>
    ///   <para>rdfs:comment : A Nestable Spatial Thing used for Theatrical Events.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Venue">theatre:Venue</a>
    /// </summary>
    let Venue = _prefixId.prefix "Venue"
    /// <summary>
    ///   <para>rdfs:label : Voice^^xsd:string</para>
    ///   <para>rdfs:comment : The voice classification for a Singer or singing part.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Voice">theatre:Voice</a>
    /// </summary>
    let Voice = _prefixId.prefix "Voice"
    /// <summary>
    ///   <para>rdfs:label : Workshop^^xsd:string</para>
    ///   <para>rdfs:comment : An event which involves participation, mainly with an educational focus.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#Workshop">theatre:Workshop</a>
    /// </summary>
    let Workshop = _prefixId.prefix "Workshop"
    /// <summary>
    ///   <para>rdfs:label : accessibility_provision^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an Accessibility Provision with an Event^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#accessibility_provision">theatre:accessibility_provision</a>
    /// </summary>
    let accessibility_provision = _prefixId.prefix "accessibility_provision"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Role with an Agent.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#agent">theatre:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>rdfs:label : audience_restriction^^xsd:string</para>
    ///   <para>rdfs:comment : A restriction on who can attend a particular performance^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#audience_restriction">theatre:audience_restriction</a>
    /// </summary>
    let audience_restriction = _prefixId.prefix "audience_restriction"
    /// <summary>
    ///   <para>rdfs:label : based_on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a Work that another Work was based on .^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#based_on">theatre:based_on</a>
    /// </summary>
    let based_on = _prefixId.prefix "based_on"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : credit^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Project with a Role.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#credit">theatre:credit</a>
    /// </summary>
    let credit = _prefixId.prefix "credit"
    /// <summary>
    ///   <para>rdfs:label : event^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Project with an Event.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#event">theatre:event</a>
    /// </summary>
    let event_ = _prefixId.prefix "event"
    /// <summary>
    ///   <para>rdfs:label : genre^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Genre with a Work.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#genre">theatre:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : manifestation^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Performableproject with a Production.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#manifestation">theatre:manifestation</a>
    /// </summary>
    let manifestation = _prefixId.prefix "manifestation"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : parent_season^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a season with its commissioning season.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#parent_season">theatre:parent_season</a>
    /// </summary>
    let parent_season = _prefixId.prefix "parent_season"
    /// <summary>
    ///   <para>rdfs:label : parent_venue^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Venue with its containing Venue.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#parent_venue">theatre:parent_venue</a>
    /// </summary>
    let parent_venue = _prefixId.prefix "parent_venue"
    let part_of_season = _prefixId.prefix "part_of_season"
    /// <summary>
    ///   <para>rdfs:label : performance^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Production with a Performance.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#performance">theatre:performance</a>
    /// </summary>
    let performance = _prefixId.prefix "performance"
    /// <summary>
    ///   <para>rdfs:label : performance_of^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Production with a Performance.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#performance_of">theatre:performance_of</a>
    /// </summary>
    let performance_of = _prefixId.prefix "performance_of"
    /// <summary>
    ///   <para>rdfs:label : portrays^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Portrayal with a Character.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#portrays">theatre:portrays</a>
    /// </summary>
    let portrays = _prefixId.prefix "portrays"
    /// <summary>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Role with a Position.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#position">theatre:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : premiere^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the first performance of a Show or Production in a particular area.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#premiere">theatre:premiere</a>
    /// </summary>
    let premiere = _prefixId.prefix "premiere"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : primary_season^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a production with its commissioning season.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#primary_season">theatre:primary_season</a>
    /// </summary>
    let primary_season = _prefixId.prefix "primary_season"
    /// <summary>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <para>rdfs:label : production^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Season with a Production.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#production">theatre:production</a>
    /// </summary>
    let production = _prefixId.prefix "production"
    /// <summary>
    ///   <para>rdfs:label : production_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a Production is an expression of a given work or production.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#production_of">theatre:production_of</a>
    /// </summary>
    let production_of = _prefixId.prefix "production_of"
    /// <summary>
    ///   <para>rdfs:label : project^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Role with a Project.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#project">theatre:project</a>
    /// </summary>
    let project = _prefixId.prefix "project"
    /// <summary>
    ///   <para>rdfs:label : put_on_by^^xsd:string</para>
    ///   <para>rdfs:comment : The Company which puts on a Production^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#put_on_by">theatre:put_on_by</a>
    /// </summary>
    let put_on_by = _prefixId.prefix "put_on_by"
    /// <summary>
    ///   <para>rdfs:label : recorded_for^^xsd:string</para>
    ///   <para>rdfs:comment : A performance recorded for either Simulcast or later broadcast.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#recorded_for">theatre:recorded_for</a>
    /// </summary>
    let recorded_for = _prefixId.prefix "recorded_for"
    /// <summary>
    ///   <para>rdfs:label : scored_voice^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the voice classification that a particular Operatic character has been written for.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#scored_voice">theatre:scored_voice</a>
    /// </summary>
    let scored_voice = _prefixId.prefix "scored_voice"
    /// <summary>
    ///   <para>rdfs:label : sponsor^^xsd:string</para>
    ///   <para>rdfs:comment : The Person or Organisation who sponsors a given production or performance^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#sponsor">theatre:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>rdfs:label : time_of_day^^xsd:string</para>
    ///   <para>rdfs:comment : A human readable indication of when in the day a performance occurs^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#time_of_day">theatre:time_of_day</a>
    /// </summary>
    let time_of_day = _prefixId.prefix "time_of_day"
    /// <summary>
    ///   <para>rdfs:label : venue^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an Event with the Venue it is held in.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#venue">theatre:venue</a>
    /// </summary>
    let venue = _prefixId.prefix "venue"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : worldPremiere^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the first performance of a Show or Production on a particular planet.^^xsd:string</para>
    ///   <a href="http://purl.org/theatre#worldPremiere">theatre:worldPremiere</a>
    /// </summary>
    let worldPremiere = _prefixId.prefix "worldPremiere"
