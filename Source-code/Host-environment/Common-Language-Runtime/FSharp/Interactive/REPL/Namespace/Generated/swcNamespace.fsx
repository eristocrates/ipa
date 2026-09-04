#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module swc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.semanticweb.org/ns/swc/ontology#" "swc"

    let _01_introduction = _prefixId.prefix "01_introduction"
    let _02_describing_papers = _prefixId.prefix "02_describing_papers"
    let _03_roles = _prefixId.prefix "03_roles"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;Academic events are e.g. conferences and conference-like events, and all the sub-events of those which are about the topic or theme of the conference, such as talks or panels.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Academic Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#AcademicEvent">swc:AcademicEvent</a>
    /// </summary>
    let AcademicEvent = _prefixId.prefix "AcademicEvent"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A hotel, hostel, BnB or similar.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Accommodation Place^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#AccommodationPlace">swc:AccommodationPlace</a>
    /// </summary>
    let AccommodationPlace = _prefixId.prefix "AccommodationPlace"
    let AdditionalReviewer = _prefixId.prefix "AdditionalReviewer"
    let Administrator = _prefixId.prefix "Administrator"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;An argumentative document is a document which uses analytical reasoning and evidence in order to argue for a point of view. Typical examples are scientific papers or political pamphlets. Negative examples are novels or plays (even though a novel might also try to sway the reader to a certain point of view).&lt;/p&gt;
    /// 			&lt;p&gt;According to &lt;a href="http://en.wikipedia.org/wiki/Text_types"&gt;Text Types&lt;/a&gt;, an argumentative document is based "on the evaluation and the subsequent subjective judgement in answer to a problem. It refers to the reasons advanced for or against a matter".&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Argumentative Document^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#ArgumentativeDocument">swc:ArgumentativeDocument</a>
    /// </summary>
    let ArgumentativeDocument = _prefixId.prefix "ArgumentativeDocument"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;&lt;emph&gt;Artefact&lt;/emph&gt; here means a document which can have a physical manifestation, like a paper or the proceedings of a conference.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Artefact^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Artefact">swc:Artefact</a>
    /// </summary>
    let Artefact = _prefixId.prefix "Artefact"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				Any kind of break at the super-event, such as a coffee break.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Break Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#BreakEvent">swc:BreakEvent</a>
    /// </summary>
    let BreakEvent = _prefixId.prefix "BreakEvent"
    let Call = _prefixId.prefix "Call"
    let CallForDemos = _prefixId.prefix "CallForDemos"
    let CallForPapers = _prefixId.prefix "CallForPapers"
    let CallForParticipation = _prefixId.prefix "CallForParticipation"
    let CallForPosters = _prefixId.prefix "CallForPosters"
    let CallForProposals = _prefixId.prefix "CallForProposals"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				A sub-class of Role for various kinds of chair functions. Examples are the main chair of a conference, the tutorials chair, the proceedings chair, etc. Instead of introducing a large amount of sub-classes of Chair, we suggest to model all the different chair functions as instances of Chair with appropriate labels.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Chair^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Chair">swc:Chair</a>
    /// </summary>
    let Chair = _prefixId.prefix "Chair"
    let CoffeeBreak = _prefixId.prefix "CoffeeBreak"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A location at the &lt;a href="#ConferenceVenuePlace"&gt;conference venue&lt;/a&gt; (or elsewhere), which is not a meeting room.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Communal Place^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#CommunalPlace">swc:CommunalPlace</a>
    /// </summary>
    let CommunalPlace = _prefixId.prefix "CommunalPlace"
    let ConferenceChair = _prefixId.prefix "ConferenceChair"
    let ConferenceClosingEvent = _prefixId.prefix "ConferenceClosingEvent"
    let ConferenceDinner = _prefixId.prefix "ConferenceDinner"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A scientific conference.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				TODO: Maybe this should be opened up - why only scientific conferences?
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Conference Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#ConferenceEvent">swc:ConferenceEvent</a>
    /// </summary>
    let ConferenceEvent = _prefixId.prefix "ConferenceEvent"
    let ConferenceOpeningEvent = _prefixId.prefix "ConferenceOpeningEvent"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				The location of a conference or conference-like event. Ideally, this would be more specific than just the city. Instead it should  be the hotel, convention centre, university or similar place where the event is held.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Conference Venue Place^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#ConferenceVenuePlace">swc:ConferenceVenuePlace</a>
    /// </summary>
    let ConferenceVenuePlace = _prefixId.prefix "ConferenceVenuePlace"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				A delegate is someone who attends a conference or conference-like event.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Delegate^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Delegate">swc:Delegate</a>
    /// </summary>
    let Delegate = _prefixId.prefix "Delegate"
    let DemoPresentation = _prefixId.prefix "DemoPresentation"
    let DemoSession = _prefixId.prefix "DemoSession"
    let DemosChair = _prefixId.prefix "DemosChair"
    let DogfoodTsar = _prefixId.prefix "DogfoodTsar"
    let DrinkingPlace = _prefixId.prefix "DrinkingPlace"
    let EatingPlace = _prefixId.prefix "EatingPlace"
    let Excursion = _prefixId.prefix "Excursion"
    let ExhibitionChair = _prefixId.prefix "ExhibitionChair"
    let FreeTimeBreak = _prefixId.prefix "FreeTimeBreak"
    let IndustrialTalk = _prefixId.prefix "IndustrialTalk"
    let IndustrialTrack = _prefixId.prefix "IndustrialTrack"
    let IndustryChair = _prefixId.prefix "IndustryChair"
    let InvitedPaper = _prefixId.prefix "InvitedPaper"
    let KeynoteTalk = _prefixId.prefix "KeynoteTalk"
    let LocalOrganiser = _prefixId.prefix "LocalOrganiser"
    let MealBreak = _prefixId.prefix "MealBreak"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A lunch, dinner or similar event at a conference or conference-like event.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Meal Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#MealEvent">swc:MealEvent</a>
    /// </summary>
    let MealEvent = _prefixId.prefix "MealEvent"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A particular room at the &lt;a href="#ConferenceVenuePlace"&gt;conference venue&lt;/a&gt; (or elsewhere). E.g., the room where a particular &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt; takes place.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Meeting Room Place^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#MeetingRoomPlace">swc:MeetingRoomPlace</a>
    /// </summary>
    let MeetingRoomPlace = _prefixId.prefix "MeetingRoomPlace"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				In the context of SWC, a non-academic event is any kind or &lt;a href="#OrganisedEvent"&gt;organised event&lt;/a&gt; which does not concern the topic or theme of the conference as such. Examples are breaks, dinners, parties, etc.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Non-academic Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#NonAcademicEvent">swc:NonAcademicEvent</a>
    /// </summary>
    let NonAcademicEvent = _prefixId.prefix "NonAcademicEvent"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;An event in time and space which is planned and organised, as opposed to something which 'just happens', such as a car accident or sunset.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Organised Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#OrganisedEvent">swc:OrganisedEvent</a>
    /// </summary>
    let OrganisedEvent = _prefixId.prefix "OrganisedEvent"
    let OrganisingCommitteeMember = _prefixId.prefix "OrganisingCommitteeMember"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;A panel discussion at a conference or conference-like event, usually involving several speakers.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Panel Event^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#PanelEvent">swc:PanelEvent</a>
    /// </summary>
    let PanelEvent = _prefixId.prefix "PanelEvent"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;A scientific/scholarly paper, e.g., an article in a scientific journal, or a paper at a conference or workshop. A paper could also be unpublished formally, as long as it has the form of a scientific paper (introduction, conclusion, related work, etc.).&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Paper^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Paper">swc:Paper</a>
    /// </summary>
    let Paper = _prefixId.prefix "Paper"
    let PaperPresentation = _prefixId.prefix "PaperPresentation"
    let PaperSession = _prefixId.prefix "PaperSession"
    let PhDSymposiumChair = _prefixId.prefix "PhDSymposiumChair"
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;A scientific poster at a conference or workshop.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Poster^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Poster">swc:Poster</a>
    /// </summary>
    let Poster = _prefixId.prefix "Poster"
    let PosterPresentation = _prefixId.prefix "PosterPresentation"
    let PosterSession = _prefixId.prefix "PosterSession"
    let PostersChair = _prefixId.prefix "PostersChair"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				A presenter is someone who presents matter in front of an audience. Examples of events to which this role applies are paper presentations, tutorials, or talks. A keynote speaker could also be modelled as an instance of this class.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Presenter^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Presenter">swc:Presenter</a>
    /// </summary>
    let Presenter = _prefixId.prefix "Presenter"
    let PrintedProceedingsChair = _prefixId.prefix "PrintedProceedingsChair"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;The proceedings of a conference or workshop, which contain the papers presented there.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Proceedings^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Proceedings">swc:Proceedings</a>
    /// </summary>
    let Proceedings = _prefixId.prefix "Proceedings"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;A document containing the programme of an event such as a conference or workshop. Typically, the programme would list the times and dates for the individual sub-events, e.g., talks, dinners, panel discussions, etc.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Programme^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Programme">swc:Programme</a>
    /// </summary>
    let Programme = _prefixId.prefix "Programme"
    let ProgrammeChair = _prefixId.prefix "ProgrammeChair"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				This role is played by the members of the programme committee of a conference or conference-like event. We found this role to be so significant that it justifies to be represented by its own class.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Programme Committee Member^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#ProgrammeCommitteeMember">swc:ProgrammeCommitteeMember</a>
    /// </summary>
    let ProgrammeCommitteeMember = _prefixId.prefix "ProgrammeCommitteeMember"
    let PublicityChair = _prefixId.prefix "PublicityChair"
    let Reception = _prefixId.prefix "Reception"
    let ResearchTrack = _prefixId.prefix "ResearchTrack"
    let Reviewer = _prefixId.prefix "Reviewer"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Role is the super-class of all the different roles performed at a conference or workshop. Examples are the various conference chairs, the delegates, presenters, PC members, etc. The intended use of this class is that an instance of Role will be related to the event at which it is performed, and to the person which performs it.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				Since the set of roles is slightly different for each event, and since it would therefore be impossible to provide sub-classes for all needs and circumstances, the SWC ontology only contains a very basic set of Role classes. Rather than diversifying the set of Role classes to cater for all needs, users should instead instantiate the small set of different Role classes and cover the roles at a specific event in this way. E.g., instead of sub-classing the Chair role with MainChair, WorkshopChair, TutorialChair, etc., the different kinds of chairs should simply be instances of the generic Chair class and be labelled appropriately.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#Role">swc:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    let SWChallengeChair = _prefixId.prefix "SWChallengeChair"
    let SessionChair = _prefixId.prefix "SessionChair"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A session dedicated to a specific topic at a conference. This could be a session with talks, or also a poster session, a demo session, or any other kind of session.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Session Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#SessionEvent">swc:SessionEvent</a>
    /// </summary>
    let SessionEvent = _prefixId.prefix "SessionEvent"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;A set of slides used for a presentation of e.g. a paper at a conference.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Slide Set^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#SlideSet">swc:SlideSet</a>
    /// </summary>
    let SlideSet = _prefixId.prefix "SlideSet"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				Examples for social events are parties or excursions.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Social Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#SocialEvent">swc:SocialEvent</a>
    /// </summary>
    let SocialEvent = _prefixId.prefix "SocialEvent"
    let Sponsorship = _prefixId.prefix "Sponsorship"
    let SponsorshipChair = _prefixId.prefix "SponsorshipChair"
    let SubmissionsChair = _prefixId.prefix "SubmissionsChair"
    let SystemDemonstration = _prefixId.prefix "SystemDemonstration"
    let SystemDescription = _prefixId.prefix "SystemDescription"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A speaker giving a talk. This could be the presentation of a paper, but also keynote speech or any other kind of talk.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Talk Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#TalkEvent">swc:TalkEvent</a>
    /// </summary>
    let TalkEvent = _prefixId.prefix "TalkEvent"
    let TrackChair = _prefixId.prefix "TrackChair"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A track groups all those sessions or events at a conference or workshop that belong to a common, overall theme. Depending on the conference, tracks can be quite generic, such as "Research" or "Industrial", but can also be more specific, such as "Semantic Web" or "Numismatics". SWC does not define any specific tracks, since conferences often differ so much with respect to how they structure their tracks, that it would be pointless to try and find a set of tracks that would suit all conferences.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;Sub-classes of TrackEvent which were defined in previous versions of the SWC ontology are now deprecated.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Track Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#TrackEvent">swc:TrackEvent</a>
    /// </summary>
    let TrackEvent = _prefixId.prefix "TrackEvent"
    let Treasurer = _prefixId.prefix "Treasurer"
    let Tutor = _prefixId.prefix "Tutor"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A tutorial is a special session at a conference or workshop, somewhat like a long lecture on a specific topic.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Tutorial Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#TutorialEvent">swc:TutorialEvent</a>
    /// </summary>
    let TutorialEvent = _prefixId.prefix "TutorialEvent"
    let TutorialPresenter = _prefixId.prefix "TutorialPresenter"
    let TutorialsChair = _prefixId.prefix "TutorialsChair"
    let Webmaster = _prefixId.prefix "Webmaster"
    let WelcomeTalk = _prefixId.prefix "WelcomeTalk"
    /// <summary>
    ///   <para>rdfs:comment :
    ///
    /// 			&lt;p&gt;
    /// 				A scientific workshop. Workshops are often co-located with &lt;a href="#ConferenceEvent"&gt;ConferenceEvent&lt;/a&gt;s.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Workshop Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#WorkshopEvent">swc:WorkshopEvent</a>
    /// </summary>
    let WorkshopEvent = _prefixId.prefix "WorkshopEvent"
    let WorkshopOrganiser = _prefixId.prefix "WorkshopOrganiser"
    let WorkshopsChair = _prefixId.prefix "WorkshopsChair"
    let affiliation = _prefixId.prefix "affiliation"
    let attendeeAt = _prefixId.prefix "attendeeAt"
    let biblioReference = _prefixId.prefix "biblioReference"
    let forEvent = _prefixId.prefix "forEvent"
    let hasAttendee = _prefixId.prefix "hasAttendee"
    let hasCall = _prefixId.prefix "hasCall"
    let hasCameraReadyDeadline = _prefixId.prefix "hasCameraReadyDeadline"
    let hasCostAmount = _prefixId.prefix "hasCostAmount"
    let hasCostCurrency = _prefixId.prefix "hasCostCurrency"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Relates an event such as a conference or any sub-event thereof to a location where it takes place.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : has location^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#hasLocation">swc:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    let hasMenu = _prefixId.prefix "hasMenu"
    let hasNotificationDeadline = _prefixId.prefix "hasNotificationDeadline"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				A generic property to model part-of relationships. In SWC this property is used to relate a &lt;a href="#Proceedings"&gt;proceedings document&lt;/a&gt; to the papers and articles contained in it.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : has part^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#hasPart">swc:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Relates an event such as a conference to its &lt;a href="#Programme"&gt;Programme&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : has programme^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#hasProgramme">swc:hasProgramme</a>
    /// </summary>
    let hasProgramme = _prefixId.prefix "hasProgramme"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Relates an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc. to a physical &lt;a href="#Artefact"&gt;artefact&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : has related artefact^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#hasRelatedArtefact">swc:hasRelatedArtefact</a>
    /// </summary>
    let hasRelatedArtefact = _prefixId.prefix "hasRelatedArtefact"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Relates an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc. to a &lt;a href="#ArgumentativeDocument"&gt;document&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has related document^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#hasRelatedDocument">swc:hasRelatedDocument</a>
    /// </summary>
    let hasRelatedDocument = _prefixId.prefix "hasRelatedDocument"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates an event (e.g. a conference) to a role at the event (e.g. a conference chair).
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : has role^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#hasRole">swc:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    let hasSponsorship = _prefixId.prefix "hasSponsorship"
    let hasSubmissionDeadline = _prefixId.prefix "hasSubmissionDeadline"
    let hasSubmissionInstructions = _prefixId.prefix "hasSubmissionInstructions"
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a role at an event (e.g. a conference chair) to the person who actually holds the role.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : held by^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#heldBy">swc:heldBy</a>
    /// </summary>
    let heldBy = _prefixId.prefix "heldBy"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a person to the role (e.g. a conference chair) it holds at an event.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : holds role^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#holdsRole">swc:holdsRole</a>
    /// </summary>
    let holdsRole = _prefixId.prefix "holdsRole"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Relates a location to a conference or sub-event thereof which takes place at it.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : is location of^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#isLocationFor">swc:isLocationFor</a>
    /// </summary>
    let isLocationFor = _prefixId.prefix "isLocationFor"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				A generic property to model part-of relationships. In SWC this property is used to relate papers or articles to the &lt;a href="#Proceedings"&gt;proceedings document&lt;/a&gt; in which they are contained.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : is part of^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#isPartOf">swc:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    let isProviderOf = _prefixId.prefix "isProviderOf"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a role at an event (e.g. a conference chair) to the event (e.g. a conference).
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : is role at^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#isRoleAt">swc:isRoleAt</a>
    /// </summary>
    let isRoleAt = _prefixId.prefix "isRoleAt"
    let isSubEventOf = _prefixId.prefix "isSubEventOf"
    let isSuperEventOf = _prefixId.prefix "isSuperEventOf"
    let isTopicOf = _prefixId.prefix "isTopicOf"
    let license_doc = _prefixId.prefix "license_doc"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;FOAF does not define an inverse of &lt;code&gt;foaf:member&lt;/code&gt;, so SWC does it.&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : member of^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#memberOf">swc:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				A person might plan to attend a talk or session at a conference or similar event. This property could be used to prepare a delegate's conference experience with respect to who they want to meet, etc.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : plans to attend^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#plansToAttend">swc:plansToAttend</a>
    /// </summary>
    let plansToAttend = _prefixId.prefix "plansToAttend"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			&lt;p&gt;
    /// 				Relates a &lt;a href="#ArgumentativeDocument"&gt;document&lt;/a&gt; to an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc.
    /// 			&lt;/p&gt;
    ///
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : related to event^^xsd:stringrdfs:label : related to Event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://data.semanticweb.org/ns/swc/ontology#relatedToEvent">swc:relatedToEvent</a>
    /// </summary>
    let relatedToEvent = _prefixId.prefix "relatedToEvent"
    let uuid = _prefixId.prefix "uuid"
