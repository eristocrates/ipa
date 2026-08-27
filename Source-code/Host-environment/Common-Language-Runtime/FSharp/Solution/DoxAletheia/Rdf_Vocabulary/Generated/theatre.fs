namespace http.purl.org.theatre.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module theatre =
    let _namespace_iri = Namespace_Iri theatre |> NamespaceIRI
    /// <summary>
    ///   <para>theatre:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A vocabulary for theatrical data.  It defines concepts such as shows, productions, seasons etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/theatre#">http://purl.org/theatre#</seealso>
    let _prefix_iri = Prefixed_Name(theatre, "") |> PrefixedName

    /// <summary>
    ///   <para>theatre:AccessibilityProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Provision which makes an ev:Event more accessible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AccessibilityProvision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#AccessibilityProvision">http://purl.org/theatre#AccessibilityProvision</seealso>
    let AccessibilityProvision =
        Prefixed_Name(theatre, "AccessibilityProvision") |> PrefixedName

    /// <summary>
    ///   <para>theatre:Event</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/theatre#Event">http://purl.org/theatre#Event</seealso>
    let Event = Prefixed_Name(theatre, "Event") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event which involves discussion/planning, often with a formal tone."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meeting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Meeting">http://purl.org/theatre#Meeting</seealso>
    let Meeting = Prefixed_Name(theatre, "Meeting") |> PrefixedName

    /// <summary>
    ///   <para>theatre:PerformableProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Project which intends to evoke a response from an Audience."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PerformableProject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#PerformableProject">http://purl.org/theatre#PerformableProject</seealso>
    let PerformableProject =
        Prefixed_Name(theatre, "PerformableProject") |> PrefixedName

    /// <summary>
    ///   <para>theatre:Performableproject</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/theatre#Performableproject">http://purl.org/theatre#Performableproject</seealso>
    let Performableproject =
        Prefixed_Name(theatre, "Performableproject") |> PrefixedName

    /// <summary>
    ///   <para>theatre:Performance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/theatre#Performance">http://purl.org/theatre#Performance</seealso>
    let Performance = Prefixed_Name(theatre, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Portrayal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Position which involes portraying a Character."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Portrayal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Portrayal">http://purl.org/theatre#Portrayal</seealso>
    let Portrayal = Prefixed_Name(theatre, "Portrayal") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of responibilities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Position">http://purl.org/theatre#Position</seealso>
    let Position = Prefixed_Name(theatre, "Position") |> PrefixedName
    /// <summary>
    ///   <para>theatre:PressNight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A performance which reviewers are encouraged to attend."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PressNight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#PressNight">http://purl.org/theatre#PressNight</seealso>
    let PressNight = Prefixed_Name(theatre, "PressNight") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The realisation of a theatrical work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Production">http://purl.org/theatre#Production</seealso>
    let Production = Prefixed_Name(theatre, "Production") |> PrefixedName
    /// <summary>
    ///   <para>theatre:ProductionCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Organisation which puts on Productions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ProductionCompany"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#ProductionCompany">http://purl.org/theatre#ProductionCompany</seealso>
    let ProductionCompany = Prefixed_Name(theatre, "ProductionCompany") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Rehearsal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event which involves preparatory work for a Performance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rehearsal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Rehearsal">http://purl.org/theatre#Rehearsal</seealso>
    let Rehearsal = Prefixed_Name(theatre, "Rehearsal") |> PrefixedName
    /// <summary>
    ///   <para>theatre:RehearsalReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An unpolished performance in which the cast read from scripts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RehearsalReading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#RehearsalReading">http://purl.org/theatre#RehearsalReading</seealso>
    let RehearsalReading = Prefixed_Name(theatre, "RehearsalReading") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Rehersal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event which involves preparatory work for a Performance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rehersal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Rehersal">http://purl.org/theatre#Rehersal</seealso>
    let Rehersal = Prefixed_Name(theatre, "Rehersal") |> PrefixedName
    /// <summary>
    ///   <para>theatre:RehersalReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An unpolished performance in which the cast read from scripts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RehersalReading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#RehersalReading">http://purl.org/theatre#RehersalReading</seealso>
    let RehersalReading = Prefixed_Name(theatre, "RehersalReading") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of Productions and/or Performances"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Season"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Season">http://purl.org/theatre#Season</seealso>
    let Season = Prefixed_Name(theatre, "Season") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Show</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The writing/devising which may enable a Production."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Show"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Show">http://purl.org/theatre#Show</seealso>
    let Show = Prefixed_Name(theatre, "Show") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Nestable Spatial Thing used for Theatrical Events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Venue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Venue">http://purl.org/theatre#Venue</seealso>
    let Venue = Prefixed_Name(theatre, "Venue") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The voice classification for a Singer or singing part."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Voice">http://purl.org/theatre#Voice</seealso>
    let Voice = Prefixed_Name(theatre, "Voice") |> PrefixedName
    /// <summary>
    ///   <para>theatre:Workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event which involves participation, mainly with an educational focus."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Workshop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#Workshop">http://purl.org/theatre#Workshop</seealso>
    let Workshop = Prefixed_Name(theatre, "Workshop") |> PrefixedName

    /// <summary>
    ///   <para>theatre:accessibility_provision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates an Accessibility Provision with an Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"accessibility_provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#accessibility_provision">http://purl.org/theatre#accessibility_provision</seealso>
    let accessibility_provision =
        Prefixed_Name(theatre, "accessibility_provision") |> PrefixedName

    /// <summary>
    ///   <para>theatre:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Role with an Agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#agent">http://purl.org/theatre#agent</seealso>
    let agent = Prefixed_Name(theatre, "agent") |> PrefixedName

    /// <summary>
    ///   <para>theatre:audience_restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A restriction on who can attend a particular performance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"audience_restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#audience_restriction">http://purl.org/theatre#audience_restriction</seealso>
    let audience_restriction =
        Prefixed_Name(theatre, "audience_restriction") |> PrefixedName

    /// <summary>
    ///   <para>theatre:based_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a Work that another Work was based on ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"based_on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#based_on">http://purl.org/theatre#based_on</seealso>
    let based_on = Prefixed_Name(theatre, "based_on") |> PrefixedName
    /// <summary>
    ///   <para>theatre:credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:domain</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Project with a Role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"credit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#credit">http://purl.org/theatre#credit</seealso>
    let credit = Prefixed_Name(theatre, "credit") |> PrefixedName
    /// <summary>
    ///   <para>theatre:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Project with an Event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#event">http://purl.org/theatre#event</seealso>
    let event_ = Prefixed_Name(theatre, "event") |> PrefixedName
    /// <summary>
    ///   <para>theatre:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Genre with a Work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#genre">http://purl.org/theatre#genre</seealso>
    let genre = Prefixed_Name(theatre, "genre") |> PrefixedName
    /// <summary>
    ///   <para>theatre:manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Performableproject with a Production."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"manifestation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#manifestation">http://purl.org/theatre#manifestation</seealso>
    let manifestation = Prefixed_Name(theatre, "manifestation") |> PrefixedName
    /// <summary>
    ///   <para>theatre:parent_season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a season with its commissioning season."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"parent_season"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#parent_season">http://purl.org/theatre#parent_season</seealso>
    let parent_season = Prefixed_Name(theatre, "parent_season") |> PrefixedName
    /// <summary>
    ///   <para>theatre:parent_venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Venue with its containing Venue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"parent_venue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#parent_venue">http://purl.org/theatre#parent_venue</seealso>
    let parent_venue = Prefixed_Name(theatre, "parent_venue") |> PrefixedName
    /// <summary>
    ///   <para>theatre:part_of_season</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:domain</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Indicates that something is part of a season"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"part_of_season"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#part_of_season">http://purl.org/theatre#part_of_season</seealso>
    let part_of_season = Prefixed_Name(theatre, "part_of_season") |> PrefixedName
    /// <summary>
    ///   <para>theatre:performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Production with a Performance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"performance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#performance">http://purl.org/theatre#performance</seealso>
    let performance = Prefixed_Name(theatre, "performance") |> PrefixedName
    /// <summary>
    ///   <para>theatre:performance_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Production with a Performance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"performance_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#performance_of">http://purl.org/theatre#performance_of</seealso>
    let performance_of = Prefixed_Name(theatre, "performance_of") |> PrefixedName
    /// <summary>
    ///   <para>theatre:portrays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Portrayal with a Character."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"portrays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#portrays">http://purl.org/theatre#portrays</seealso>
    let portrays = Prefixed_Name(theatre, "portrays") |> PrefixedName
    /// <summary>
    ///   <para>theatre:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Role with a Position."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#position">http://purl.org/theatre#position</seealso>
    let position = Prefixed_Name(theatre, "position") |> PrefixedName
    /// <summary>
    ///   <para>theatre:premiere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdfs:domain</para>
    ///   <para>"Indicates the first performance of a Show or Production in a particular area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"premiere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#premiere">http://purl.org/theatre#premiere</seealso>
    let premiere = Prefixed_Name(theatre, "premiere") |> PrefixedName
    /// <summary>
    ///   <para>theatre:primary_season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a production with its commissioning season."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primary_season"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#primary_season">http://purl.org/theatre#primary_season</seealso>
    let primary_season = Prefixed_Name(theatre, "primary_season") |> PrefixedName
    /// <summary>
    ///   <para>theatre:production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Season with a Production."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#production">http://purl.org/theatre#production</seealso>
    let production = Prefixed_Name(theatre, "production") |> PrefixedName
    /// <summary>
    ///   <para>theatre:production_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:range</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a Production is an expression of a given work or production."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"production_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#production_of">http://purl.org/theatre#production_of</seealso>
    let production_of = Prefixed_Name(theatre, "production_of") |> PrefixedName
    /// <summary>
    ///   <para>theatre:project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:range</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Role with a Project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#project">http://purl.org/theatre#project</seealso>
    let project = Prefixed_Name(theatre, "project") |> PrefixedName
    /// <summary>
    ///   <para>theatre:put_on_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Company which puts on a Production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"put_on_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#put_on_by">http://purl.org/theatre#put_on_by</seealso>
    let put_on_by = Prefixed_Name(theatre, "put_on_by") |> PrefixedName
    /// <summary>
    ///   <para>theatre:recorded_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A performance recorded for either Simulcast or later broadcast."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"recorded_for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#recorded_for">http://purl.org/theatre#recorded_for</seealso>
    let recorded_for = Prefixed_Name(theatre, "recorded_for") |> PrefixedName
    /// <summary>
    ///   <para>theatre:scored_voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the voice classification that a particular Operatic character has been written for."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"scored_voice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#scored_voice">http://purl.org/theatre#scored_voice</seealso>
    let scored_voice = Prefixed_Name(theatre, "scored_voice") |> PrefixedName
    /// <summary>
    ///   <para>theatre:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdfs:domain</para>
    ///   <para>"The Person or Organisation who sponsors a given production or performance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sponsor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#sponsor">http://purl.org/theatre#sponsor</seealso>
    let sponsor = Prefixed_Name(theatre, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>theatre:time_of_day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A human readable indication of when in the day a performance occurs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"time_of_day"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#time_of_day">http://purl.org/theatre#time_of_day</seealso>
    let time_of_day = Prefixed_Name(theatre, "time_of_day") |> PrefixedName
    /// <summary>
    ///   <para>theatre:venue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates an Event with the Venue it is held in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"venue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#venue">http://purl.org/theatre#venue</seealso>
    let venue = Prefixed_Name(theatre, "venue") |> PrefixedName
    /// <summary>
    ///   <para>theatre:worldPremiere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:domain</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the first performance of a Show or Production on a particular planet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"worldPremiere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/theatre#worldPremiere">http://purl.org/theatre#worldPremiere</seealso>
    let worldPremiere = Prefixed_Name(theatre, "worldPremiere") |> PrefixedName
