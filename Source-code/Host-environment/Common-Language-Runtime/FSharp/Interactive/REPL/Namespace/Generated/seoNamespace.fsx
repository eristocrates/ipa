#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module seo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/seo#" "seo"
    let _namespaceIri = _prefixId.prefix ""
    let ArtificialIntelligence = _prefixId.prefix "ArtificialIntelligence"
    /// <summary>
    ///   <para>rdfs:label : Author</para>
    ///   <para>rdfs:comment : The one who write the article.</para>
    ///   <a href="https://w3id.org/seo#Author">seo:Author</a>
    /// </summary>
    let Author = _prefixId.prefix "Author"
    /// <summary>
    ///   <para>rdfs:label : Author registration</para>
    ///   <para>rdfs:comment : At least one of the authors must register at the full rate in order for the paper to be published in the Proceedings.</para>
    ///   <a href="https://w3id.org/seo#AuthorRegistration">seo:AuthorRegistration</a>
    /// </summary>
    let AuthorRegistration = _prefixId.prefix "AuthorRegistration"
    /// <summary>
    ///   <para>rdfs:label : Award</para>
    ///   <para>rdfs:comment : A price for the highest quality research.</para>
    ///   <a href="https://w3id.org/seo#Award">seo:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>rdfs:label : Best applications paper award</para>
    ///   <para>rdfs:comment : This award for the best application paper presented. </para>
    ///   <a href="https://w3id.org/seo#BestApplicationsPaperAward">seo:BestApplicationsPaperAward</a>
    /// </summary>
    let BestApplicationsPaperAward = _prefixId.prefix "BestApplicationsPaperAward"
    /// <summary>
    ///   <para>rdfs:label : Best paper award</para>
    ///   <para>rdfs:comment : This award recognizes the best paper presented.</para>
    ///   <a href="https://w3id.org/seo#BestPaperAward">seo:BestPaperAward</a>
    /// </summary>
    let BestPaperAward = _prefixId.prefix "BestPaperAward"
    /// <summary>
    ///   <para>rdfs:label : Best poster award</para>
    ///   <para>rdfs:comment : This award highlight good quality posters presented.</para>
    ///   <a href="https://w3id.org/seo#BestPosterAward">seo:BestPosterAward</a>
    /// </summary>
    let BestPosterAward = _prefixId.prefix "BestPosterAward"
    /// <summary>
    ///   <para>rdfs:label : Best student paper award</para>
    ///   <para>rdfs:comment : This award recognizes the best paper authored primarily by a student and presented by the student.</para>
    ///   <a href="https://w3id.org/seo#BestStudentPaperAward">seo:BestStudentPaperAward</a>
    /// </summary>
    let BestStudentPaperAward = _prefixId.prefix "BestStudentPaperAward"
    /// <summary>
    ///   <para>rdfs:label : Bronze sponsorship</para>
    ///   <para>rdfs:comment : A Sponsorship Package.</para>
    ///   <a href="https://w3id.org/seo#BronzeSponsorship">seo:BronzeSponsorship</a>
    /// </summary>
    let BronzeSponsorship = _prefixId.prefix "BronzeSponsorship"
    /// <summary>
    ///   <para>rdfs:label : Chair</para>
    ///   <para>rdfs:comment : The Chair person must ensure that the Management Committee functions properly, that there is full participation during meetings, that all relevant matters are discussed and that effective decisions are made and carried out.</para>
    ///   <a href="https://w3id.org/seo#Chair">seo:Chair</a>
    /// </summary>
    let Chair = _prefixId.prefix "Chair"
    /// <summary>
    ///   <para>rdfs:label : Challenge track</para>
    ///   <para>rdfs:comment : The idea of the challenge track is to provide participants with a set of case studies and challenge the state of the art.</para>
    ///   <a href="https://w3id.org/seo#ChallengeTrack">seo:ChallengeTrack</a>
    /// </summary>
    let ChallengeTrack = _prefixId.prefix "ChallengeTrack"
    let ComputerSystemsOrganization = _prefixId.prefix "ComputerSystemsOrganization"
    /// <summary>
    ///   <para>rdfs:label : Demo chair</para>
    ///   <para>rdfs:comment : A person responsible for assembling the system demonstration papers to be presented in the main conference program. </para>
    ///   <a href="https://w3id.org/seo#DemoChair">seo:DemoChair</a>
    /// </summary>
    let DemoChair = _prefixId.prefix "DemoChair"
    /// <summary>
    ///   <para>rdfs:label : Demos track</para>
    ///   <para>rdfs:comment : Offer an opportunity for presenting late-breaking research results, on-going research projects, and speculative or innovative work in progress.</para>
    ///   <a href="https://w3id.org/seo#DemosTrack">seo:DemosTrack</a>
    /// </summary>
    let DemosTrack = _prefixId.prefix "DemosTrack"
    /// <summary>
    ///   <para>rdfs:label : Doctoral consortium</para>
    ///   <para>rdfs:comment : Provide PhD students an opportunity to share and develop their research ideas in a critical but supportive environment.</para>
    ///   <a href="https://w3id.org/seo#DoctoralConsortium">seo:DoctoralConsortium</a>
    /// </summary>
    let DoctoralConsortium = _prefixId.prefix "DoctoralConsortium"
    /// <summary>
    ///   <para>rdfs:label : Doctoral consortium chair</para>
    ///   <para>rdfs:comment : The event member who leads the doctoral consortium.</para>
    ///   <a href="https://w3id.org/seo#DoctoralConsortiumChair">seo:DoctoralConsortiumChair</a>
    /// </summary>
    let DoctoralConsortiumChair = _prefixId.prefix "DoctoralConsortiumChair"
    /// <summary>
    ///   <para>rdfs:label : Early bird registration</para>
    ///   <para>rdfs:comment : Registration before a specific date.</para>
    ///   <a href="https://w3id.org/seo#EarlyBirdRegistration">seo:EarlyBirdRegistration</a>
    /// </summary>
    let EarlyBirdRegistration = _prefixId.prefix "EarlyBirdRegistration"
    /// <summary>
    ///   <para>rdfs:label : Event reception</para>
    ///   <para>rdfs:comment : The reception event within a scientific event .</para>
    ///   <a href="https://w3id.org/seo#EventReception">seo:EventReception</a>
    /// </summary>
    let EventReception = _prefixId.prefix "EventReception"
    /// <summary>
    ///   <para>rdfs:label : Flyer</para>
    ///   <para>rdfs:comment : An announcement or advertisement that is printed on a sheet of paper and given to people.</para>
    ///   <a href="https://w3id.org/seo#Flyer">seo:Flyer</a>
    /// </summary>
    let Flyer = _prefixId.prefix "Flyer"
    /// <summary>
    ///   <para>rdfs:label : General chair</para>
    ///   <para>rdfs:comment : A person responsible for overseeing and coordinating the whole conference. .</para>
    ///   <a href="https://w3id.org/seo#GeneralChair">seo:GeneralChair</a>
    /// </summary>
    let GeneralChair = _prefixId.prefix "GeneralChair"
    /// <summary>
    ///   <para>rdfs:label : Get together event</para>
    ///   <para>rdfs:comment : Socially gather two or more people in one event .</para>
    ///   <a href="https://w3id.org/seo#GetTogetherEvent">seo:GetTogetherEvent</a>
    /// </summary>
    let GetTogetherEvent = _prefixId.prefix "GetTogetherEvent"
    /// <summary>
    ///   <para>rdfs:label : Gold sponsorship</para>
    ///   <para>rdfs:comment : Sponsorship Package.</para>
    ///   <a href="https://w3id.org/seo#GoldSponsorship">seo:GoldSponsorship</a>
    /// </summary>
    let GoldSponsorship = _prefixId.prefix "GoldSponsorship"
    /// <summary>
    ///   <para>rdfs:label : Honor chair</para>
    ///   <para>rdfs:comment : Chair of the conference .</para>
    ///   <a href="https://w3id.org/seo#HonorChair">seo:HonorChair</a>
    /// </summary>
    let HonorChair = _prefixId.prefix "HonorChair"
    let HumanCenteredComputing = _prefixId.prefix "HumanCenteredComputing"
    /// <summary>
    ///   <para>rdfs:label : Important dates</para>
    ///   <para>rdfs:comment : Important dates to be noticed such as, abstract deadline, submission deadline, ...etc .</para>
    ///   <a href="https://w3id.org/seo#ImportantDates">seo:ImportantDates</a>
    /// </summary>
    let ImportantDates = _prefixId.prefix "ImportantDates"
    /// <summary>
    ///   <para>rdfs:label : In-use track</para>
    ///   <para>rdfs:comment : In-Use track provides researchers to discuss novel research taken to the market.</para>
    ///   <a href="https://w3id.org/seo#In-useTrack">seo:In-useTrack</a>
    /// </summary>
    let In_useTrack = _prefixId.prefix "In-useTrack"
    /// <summary>
    ///   <para>rdfs:label : Industrial conference</para>
    ///   <para>rdfs:comment : A business conference is held for people working in the same company or industry.</para>
    ///   <a href="https://w3id.org/seo#IndustrialConference">seo:IndustrialConference</a>
    /// </summary>
    let IndustrialConference = _prefixId.prefix "IndustrialConference"
    /// <summary>
    ///   <para>rdfs:label : Industry track</para>
    ///   <para>rdfs:comment : The industry track seeks to present research contributions in industrial settings.</para>
    ///   <a href="https://w3id.org/seo#IndustryTrack">seo:IndustryTrack</a>
    /// </summary>
    let IndustryTrack = _prefixId.prefix "IndustryTrack"
    let InformationSystems = _prefixId.prefix "InformationSystems"
    /// <summary>
    ///   <para>rdfs:label : Invited speakers</para>
    ///   <para>rdfs:comment : Invited person to give a speech in an event.</para>
    ///   <a href="https://w3id.org/seo#InvitedSpeakers">seo:InvitedSpeakers</a>
    /// </summary>
    let InvitedSpeakers = _prefixId.prefix "InvitedSpeakers"
    /// <summary>
    ///   <para>rdfs:label : Keynote speech^^xsd:string</para>
    ///   <para>rdfs:comment : A talk that establishes a main underlying the theme of the event.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#Keynote">seo:Keynote</a>
    /// </summary>
    let Keynote = _prefixId.prefix "Keynote"
    /// <summary>
    ///   <para>rdfs:label : Keynote speaker</para>
    ///   <para>rdfs:comment : Someone who gives the main address at a formal gathering such as a conference .</para>
    ///   <a href="https://w3id.org/seo#KeynoteSpeaker">seo:KeynoteSpeaker</a>
    /// </summary>
    let KeynoteSpeaker = _prefixId.prefix "KeynoteSpeaker"
    /// <summary>
    ///   <para>rdfs:label : Late registration</para>
    ///   <para>rdfs:comment : Registration after a specific deadline .</para>
    ///   <a href="https://w3id.org/seo#LateRegistration">seo:LateRegistration</a>
    /// </summary>
    let LateRegistration = _prefixId.prefix "LateRegistration"
    /// <summary>
    ///   <para>rdfs:label : Local organisation chair</para>
    ///   <para>rdfs:comment : The chair of the local organizers of the event. </para>
    ///   <a href="https://w3id.org/seo#LocalOrganisationChair">seo:LocalOrganisationChair</a>
    /// </summary>
    let LocalOrganisationChair = _prefixId.prefix "LocalOrganisationChair"
    /// <summary>
    ///   <para>rdfs:label : On site registration</para>
    ///   <para>rdfs:comment : Process of signing up for an event on the day of, or at the site of, the event.</para>
    ///   <a href="https://w3id.org/seo#OnSiteRegistration">seo:OnSiteRegistration</a>
    /// </summary>
    let OnSiteRegistration = _prefixId.prefix "OnSiteRegistration"
    /// <summary>
    ///   <para>rdfs:label : Organizer</para>
    ///   <para>rdfs:comment : A person who arranges an event or activity. .</para>
    ///   <a href="https://w3id.org/seo#Organizer">seo:Organizer</a>
    /// </summary>
    let Organizer = _prefixId.prefix "Organizer"
    /// <summary>
    ///   <para>rdfs:label : PHD symposium</para>
    ///   <para>rdfs:comment : Event for PHD student to present and receive feedback on their ongoing work.</para>
    ///   <a href="https://w3id.org/seo#PHDSymposium">seo:PHDSymposium</a>
    /// </summary>
    let PHDSymposium = _prefixId.prefix "PHDSymposium"
    /// <summary>
    ///   <para>rdfs:label : Past events</para>
    ///   <para>rdfs:comment : Events happened or existed before the present time. </para>
    ///   <a href="https://w3id.org/seo#PastEvents">seo:PastEvents</a>
    /// </summary>
    let PastEvents = _prefixId.prefix "PastEvents"
    /// <summary>
    ///   <para>rdfs:label : Platinum sponsorship</para>
    ///   <para>rdfs:comment : Sponsorship Package.</para>
    ///   <a href="https://w3id.org/seo#PlatinumSponsorship">seo:PlatinumSponsorship</a>
    /// </summary>
    let PlatinumSponsorship = _prefixId.prefix "PlatinumSponsorship"
    /// <summary>
    ///   <para>rdfs:label : Poster chair</para>
    ///   <para>rdfs:comment : The poster chair is responsible for recruiting and selecting poster fair organizers for the fairs that fall under the shared interest category.</para>
    ///   <a href="https://w3id.org/seo#PosterChair">seo:PosterChair</a>
    /// </summary>
    let PosterChair = _prefixId.prefix "PosterChair"
    /// <summary>
    ///   <para>rdfs:label : Posters track</para>
    ///   <para>rdfs:comment : Present research contributions as posters.</para>
    ///   <a href="https://w3id.org/seo#PostersTrack">seo:PostersTrack</a>
    /// </summary>
    let PostersTrack = _prefixId.prefix "PostersTrack"
    /// <summary>
    ///   <para>rdfs:label : Program chair</para>
    ///   <para>rdfs:comment : The Program Chair is responsible for working to develop the annual program budget, manage chapter-programming delivery, monitor program quality, manage member satisfaction with programs, and manage all speaker communications. </para>
    ///   <a href="https://w3id.org/seo#ProgramChair">seo:ProgramChair</a>
    /// </summary>
    let ProgramChair = _prefixId.prefix "ProgramChair"
    /// <summary>
    ///   <para>rdfs:label : Program committee member</para>
    ///   <para>rdfs:comment : The program committee is responsible for objectively and thoroughly reviewing all submissions, for submitting timely, informative reviews that provide authors with feedback about their submissions, and for attending the program committee meetings.</para>
    ///   <a href="https://w3id.org/seo#ProgramCommitteeMember">seo:ProgramCommitteeMember</a>
    /// </summary>
    let ProgramCommitteeMember = _prefixId.prefix "ProgramCommitteeMember"
    /// <summary>
    ///   <para>rdfs:label : Program schedule</para>
    ///   <para>rdfs:comment : A plan for carrying out a process or procedure, giving lists of intended events and times.</para>
    ///   <a href="https://w3id.org/seo#ProgramSchedule">seo:ProgramSchedule</a>
    /// </summary>
    let ProgramSchedule = _prefixId.prefix "ProgramSchedule"
    /// <summary>
    ///   <para>rdfs:label : Publisher</para>
    ///   <para>rdfs:comment : The publisher of the event proceedings.</para>
    ///   <a href="https://w3id.org/seo#Publisher">seo:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"
    /// <summary>
    ///   <para>rdfs:label : Registration</para>
    ///   <para>rdfs:comment : The action or process of registering or of being registered.</para>
    ///   <a href="https://w3id.org/seo#Registration">seo:Registration</a>
    /// </summary>
    let Registration = _prefixId.prefix "Registration"
    /// <summary>
    ///   <para>rdfs:label : Regular registration</para>
    ///   <para>rdfs:comment : Normal registration</para>
    ///   <a href="https://w3id.org/seo#RegularRegistration">seo:RegularRegistration</a>
    /// </summary>
    let RegularRegistration = _prefixId.prefix "RegularRegistration"
    /// <summary>
    ///   <para>rdfs:label : Research field</para>
    ///   <para>rdfs:comment : Area of interest.</para>
    ///   <a href="https://w3id.org/seo#ResearchField">seo:ResearchField</a>
    /// </summary>
    let ResearchField = _prefixId.prefix "ResearchField"
    /// <summary>
    ///   <para>rdfs:label : Research track</para>
    ///   <para>rdfs:comment : The track for fundamental research, innovative technology, and applications concerning the research topic of the event.</para>
    ///   <a href="https://w3id.org/seo#ResearchTrack">seo:ResearchTrack</a>
    /// </summary>
    let ResearchTrack = _prefixId.prefix "ResearchTrack"
    /// <summary>
    ///   <para>rdfs:label : Resource track</para>
    ///   <para>rdfs:comment : The Resources Track aims to promote the sharing of resources including: datasets, ontologies, vocabularies, ... etc</para>
    ///   <a href="https://w3id.org/seo#ResourceTrack">seo:ResourceTrack</a>
    /// </summary>
    let ResourceTrack = _prefixId.prefix "ResourceTrack"
    /// <summary>
    ///   <para>rdfs:label : Reviewer</para>
    ///   <para>rdfs:comment : A person who reviews the submissions and give feedback about the submitted articles.</para>
    ///   <a href="https://w3id.org/seo#Reviewer">seo:Reviewer</a>
    /// </summary>
    let Reviewer = _prefixId.prefix "Reviewer"
    let SecurityAndPrivacy = _prefixId.prefix "SecurityAndPrivacy"
    /// <summary>
    ///   <para>rdfs:label : Silver sponsorship</para>
    ///   <para>rdfs:comment : Sponsorship Package.</para>
    ///   <a href="https://w3id.org/seo#SilverSponsorship">seo:SilverSponsorship</a>
    /// </summary>
    let SilverSponsorship = _prefixId.prefix "SilverSponsorship"
    let SoftwareEngineering = _prefixId.prefix "SoftwareEngineering"
    /// <summary>
    ///   <para>rdfs:label : Sponsor</para>
    ///   <para>rdfs:comment : The Sponsor of the event (i.e. company, university ... etc.).</para>
    ///   <a href="https://w3id.org/seo#Sponsor">seo:Sponsor</a>
    /// </summary>
    let Sponsor = _prefixId.prefix "Sponsor"
    /// <summary>
    ///   <para>rdfs:label : Sponsorship</para>
    ///   <para>rdfs:comment : Refer to a person or organization with some sort of responsibility for another person or organisation.</para>
    ///   <a href="https://w3id.org/seo#Sponsorship">seo:Sponsorship</a>
    /// </summary>
    let Sponsorship = _prefixId.prefix "Sponsorship"
    /// <summary>
    ///   <para>rdfs:label : Sponsorship chair</para>
    ///   <para>rdfs:comment : A person responsible for collecting funding from two kinds of sources: granting institutions and corporations. </para>
    ///   <a href="https://w3id.org/seo#SponsorshipChair">seo:SponsorshipChair</a>
    /// </summary>
    let SponsorshipChair = _prefixId.prefix "SponsorshipChair"
    /// <summary>
    ///   <para>rdfs:label : Student</para>
    ///   <para>rdfs:comment : A person enrolled in a school or other educational institution.</para>
    ///   <a href="https://w3id.org/seo#Student">seo:Student</a>
    /// </summary>
    let Student = _prefixId.prefix "Student"
    /// <summary>
    ///   <para>rdfs:label : Student registration</para>
    ///   <para>rdfs:comment : Students full-time enrolled in a college or university can register as a student for the reduced early career rate.</para>
    ///   <a href="https://w3id.org/seo#StudentRegistration">seo:StudentRegistration</a>
    /// </summary>
    let StudentRegistration = _prefixId.prefix "StudentRegistration"
    /// <summary>
    ///   <para>rdfs:label : Submission guidelines</para>
    ///   <para>rdfs:comment : Instructions for the submission process .</para>
    ///   <a href="https://w3id.org/seo#SubmissionGuidelines">seo:SubmissionGuidelines</a>
    /// </summary>
    let SubmissionGuidelines = _prefixId.prefix "SubmissionGuidelines"
    /// <summary>
    ///   <para>rdfs:label : Symposium</para>
    ///   <para>rdfs:comment : A conference or meeting to discuss a particular subject.</para>
    ///   <a href="https://w3id.org/seo#Symposium">seo:Symposium</a>
    /// </summary>
    let Symposium = _prefixId.prefix "Symposium"
    /// <summary>
    ///   <para>rdfs:label : Symposiums series</para>
    ///   <para>rdfs:comment : A series of symposiums.</para>
    ///   <a href="https://w3id.org/seo#SymposiumSeries">seo:SymposiumSeries</a>
    /// </summary>
    let SymposiumSeries = _prefixId.prefix "SymposiumSeries"
    let TheoryOfComputations = _prefixId.prefix "TheoryOfComputations"
    /// <summary>
    ///   <para>rdfs:label : Travel information</para>
    ///   <para>rdfs:comment : The information about the travel: date, place, ...etc .</para>
    ///   <a href="https://w3id.org/seo#TravelInformation">seo:TravelInformation</a>
    /// </summary>
    let TravelInformation = _prefixId.prefix "TravelInformation"
    /// <summary>
    ///   <para>rdfs:label : Tutorial chair</para>
    ///   <para>rdfs:comment : A person responsible for requesting tutorial proposals and making final selections.</para>
    ///   <a href="https://w3id.org/seo#TutorialChair">seo:TutorialChair</a>
    /// </summary>
    let TutorialChair = _prefixId.prefix "TutorialChair"
    /// <summary>
    ///   <para>rdfs:label : Workshop chair</para>
    ///   <para>rdfs:comment : The one responsible for collaborating with the workshop chairs for other ACL-affiliated conferences in the given year, in preparing and circulating the Call for Proposals, and in reviewing submissions.</para>
    ///   <a href="https://w3id.org/seo#WorkshopChair">seo:WorkshopChair</a>
    /// </summary>
    let WorkshopChair = _prefixId.prefix "WorkshopChair"
    let WorldWideWeb = _prefixId.prefix "WorldWideWeb"
    /// <summary>
    ///   <para>rdfs:comment : The deadline of abstract submission.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#abstractDeadline">seo:abstractDeadline</a>
    /// </summary>
    let abstractDeadline = _prefixId.prefix "abstractDeadline"
    /// <summary>
    ///   <para>rdfs:comment : The acceptance rate of the event in a particular year.</para>
    ///   <a href="https://w3id.org/seo#acceptanceRate">seo:acceptanceRate</a>
    /// </summary>
    let acceptanceRate = _prefixId.prefix "acceptanceRate"
    /// <summary>
    ///   <para>rdfs:comment : The number of accepted papers in the event.</para>
    ///   <a href="https://w3id.org/seo#acceptedPapers">seo:acceptedPapers</a>
    /// </summary>
    let acceptedPapers = _prefixId.prefix "acceptedPapers"
    /// <summary>
    ///   <para>rdfs:label : belongsToSeries</para>
    ///   <para>rdfs:comment : This property shows the series which an event belongs to.</para>
    ///   <a href="https://w3id.org/seo#belongsToSeries">seo:belongsToSeries</a>
    /// </summary>
    let belongsToSeries = _prefixId.prefix "belongsToSeries"
    /// <summary>
    ///   <para>rdfs:comment : This property links an event to another one which is co-located with.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#colocatedWith">seo:colocatedWith</a>
    /// </summary>
    let colocatedWith = _prefixId.prefix "colocatedWith"
    /// <summary>
    ///   <para>rdfs:comment : The webpage of the event.</para>
    ///   <a href="https://w3id.org/seo#eventWebsite">seo:eventWebsite</a>
    /// </summary>
    let eventWebsite = _prefixId.prefix "eventWebsite"
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    let hasChair = _prefixId.prefix "hasChair"
    /// <summary>
    ///   <para>rdfs:comment : an event series has an event edition^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#hasEvent">seo:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    let hasFlyer = _prefixId.prefix "hasFlyer"
    let hasImportantDates = _prefixId.prefix "hasImportantDates"
    let hasKeynote = _prefixId.prefix "hasKeynote"
    let hasProgramCommitteeMember = _prefixId.prefix "hasProgramCommitteeMember"
    let hasProgramSchedual = _prefixId.prefix "hasProgramSchedual"
    /// <summary>
    ///   <para>rdfs:comment : This propoerty shows the publisher of a proceedings.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#hasPublisher">seo:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    let hasRegistration = _prefixId.prefix "hasRegistration"
    let hasRegistrationType = _prefixId.prefix "hasRegistrationType"
    let hasSocialEvent = _prefixId.prefix "hasSocialEvent"
    /// <summary>
    ///   <para>rdfs:comment : This propoerty shows the sponsor of an event.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#hasSponsor">seo:hasSponsor</a>
    /// </summary>
    let hasSponsor = _prefixId.prefix "hasSponsor"
    let hasSubmissionGuidelines = _prefixId.prefix "hasSubmissionGuidelines"
    /// <summary>
    ///   <para>rdfs:comment : This propoerty shows the available tracks of an event.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#hasTrack">seo:hasTrack</a>
    /// </summary>
    let hasTrack = _prefixId.prefix "hasTrack"
    /// <summary>
    ///   <para>rdfs:comment : The twitter account of the event.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#hasTwitter">seo:hasTwitter</a>
    /// </summary>
    let hasTwitter = _prefixId.prefix "hasTwitter"
    let heldInCity = _prefixId.prefix "heldInCity"
    let heldInCountry = _prefixId.prefix "heldInCountry"
    let isPublisherOf = _prefixId.prefix "isPublisherOf"
    let isSponsorOf = _prefixId.prefix "isSponsorOf"
    let isTrackOf = _prefixId.prefix "isTrackOf"
    let keynoteIn = _prefixId.prefix "keynoteIn"
    /// <summary>
    ///   <para>rdfs:label : Paper Acceptance Notification^^xsd:string</para>
    ///   <para>rdfs:comment : The date of the paper acceptance notification.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#notificationDate">seo:notificationDate</a>
    /// </summary>
    let notificationDate = _prefixId.prefix "notificationDate"
    let offersAward = _prefixId.prefix "offersAward"
    let offersBestPaperAward = _prefixId.prefix "offersBestPaperAward"
    let participatesAs = _prefixId.prefix "participatesAs"
    let participatesIn = _prefixId.prefix "participatesIn"
    let providesTravelInformation = _prefixId.prefix "providesTravelInformation"
    let registeredAs = _prefixId.prefix "registeredAs"
    let sponsorshipType = _prefixId.prefix "sponsorshipType"
    /// <summary>
    ///   <para>rdfs:comment : The deadline of paper submission.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#submissionDeadline">seo:submissionDeadline</a>
    /// </summary>
    let submissionDeadline = _prefixId.prefix "submissionDeadline"
    /// <summary>
    ///   <para>rdfs:comment : The webpage of the submission to event.^^xsd:string</para>
    ///   <a href="https://w3id.org/seo#submissionWebPage">seo:submissionWebPage</a>
    /// </summary>
    let submissionWebPage = _prefixId.prefix "submissionWebPage"
    /// <summary>
    ///   <para>rdfs:comment : The number of submitted papers to the event.</para>
    ///   <a href="https://w3id.org/seo#submittedPapers">seo:submittedPapers</a>
    /// </summary>
    let submittedPapers = _prefixId.prefix "submittedPapers"
    let takesAward = _prefixId.prefix "takesAward"
