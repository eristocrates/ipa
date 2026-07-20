namespace https.w3id.org.seo.hash

open DoxAletheia

module seo =
    let _namespace_name = "https://w3id.org/seo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This property links an event to another one which is co-located with.
    /// <see href="https://w3id.org/seo#colocatedWith"></see></summary>
    let colocatedWith = _prefix "colocatedWith"
    /// <summary>
    ///   <see href="https://w3id.org/seo#participatesIn"></see>
    /// </summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    ///   <see href="https://w3id.org/seo#/"></see>
    /// </summary>
    let ``_/`` = _prefix "/"
    /// <summary>
    ///   <see href="https://w3id.org/seo#ArtificialIntelligence"></see>
    /// </summary>
    let ArtificialIntelligence = _prefix "ArtificialIntelligence"
    /// <summary>
    /// Area of interest.
    /// <see href="https://w3id.org/seo#ResearchField"></see></summary>
    let ResearchField = _prefix "ResearchField"
    /// <summary>
    /// The one who write the article.
    /// <see href="https://w3id.org/seo#Author"></see></summary>
    let Author = _prefix "Author"
    /// <summary>
    /// At least one of the authors must register at the full rate in order for the paper to be published in the Proceedings.
    /// <see href="https://w3id.org/seo#AuthorRegistration"></see></summary>
    let AuthorRegistration = _prefix "AuthorRegistration"
    /// <summary>
    /// A price for the highest quality research.
    /// <see href="https://w3id.org/seo#Award"></see></summary>
    let Award = _prefix "Award"
    /// <summary>
    /// This award for the best application paper presented.
    /// <see href="https://w3id.org/seo#BestApplicationsPaperAward"></see></summary>
    let BestApplicationsPaperAward = _prefix "BestApplicationsPaperAward"
    /// <summary>
    /// This award recognizes the best paper presented.
    /// <see href="https://w3id.org/seo#BestPaperAward"></see></summary>
    let BestPaperAward = _prefix "BestPaperAward"
    /// <summary>
    /// This award highlight good quality posters presented.
    /// <see href="https://w3id.org/seo#BestPosterAward"></see></summary>
    let BestPosterAward = _prefix "BestPosterAward"
    /// <summary>
    /// This award recognizes the best paper authored primarily by a student and presented by the student.
    /// <see href="https://w3id.org/seo#BestStudentPaperAward"></see></summary>
    let BestStudentPaperAward = _prefix "BestStudentPaperAward"
    /// <summary>
    /// A Sponsorship Package.
    /// <see href="https://w3id.org/seo#BronzeSponsorship"></see></summary>
    let BronzeSponsorship = _prefix "BronzeSponsorship"
    /// <summary>
    /// Refer to a person or organization with some sort of responsibility for another person or organisation.
    /// <see href="https://w3id.org/seo#Sponsorship"></see></summary>
    let Sponsorship = _prefix "Sponsorship"
    /// <summary>
    /// The Chair person must ensure that the Management Committee functions properly, that there is full participation during meetings, that all relevant matters are discussed and that effective decisions are made and carried out.
    /// <see href="https://w3id.org/seo#Chair"></see></summary>
    let Chair = _prefix "Chair"
    /// <summary>
    /// The idea of the challenge track is to provide participants with a set of case studies and challenge the state of the art.
    /// <see href="https://w3id.org/seo#ChallengeTrack"></see></summary>
    let ChallengeTrack = _prefix "ChallengeTrack"
    /// <summary>
    ///   <see href="https://w3id.org/seo#ComputerSystemsOrganization"></see>
    /// </summary>
    let ComputerSystemsOrganization = _prefix "ComputerSystemsOrganization"
    /// <summary>
    /// A person responsible for assembling the system demonstration papers to be presented in the main conference program.
    /// <see href="https://w3id.org/seo#DemoChair"></see></summary>
    let DemoChair = _prefix "DemoChair"
    /// <summary>
    /// Offer an opportunity for presenting late-breaking research results, on-going research projects, and speculative or innovative work in progress.
    /// <see href="https://w3id.org/seo#DemosTrack"></see></summary>
    let DemosTrack = _prefix "DemosTrack"
    /// <summary>
    /// Provide PhD students an opportunity to share and develop their research ideas in a critical but supportive environment.
    /// <see href="https://w3id.org/seo#DoctoralConsortium"></see></summary>
    let DoctoralConsortium = _prefix "DoctoralConsortium"
    /// <summary>
    /// The event member who leads the doctoral consortium.
    /// <see href="https://w3id.org/seo#DoctoralConsortiumChair"></see></summary>
    let DoctoralConsortiumChair = _prefix "DoctoralConsortiumChair"
    /// <summary>
    /// Registration before a specific date.
    /// <see href="https://w3id.org/seo#EarlyBirdRegistration"></see></summary>
    let EarlyBirdRegistration = _prefix "EarlyBirdRegistration"
    /// <summary>
    /// The action or process of registering or of being registered.
    /// <see href="https://w3id.org/seo#Registration"></see></summary>
    let Registration = _prefix "Registration"
    /// <summary>
    /// Registration after a specific deadline .
    /// <see href="https://w3id.org/seo#LateRegistration"></see></summary>
    let LateRegistration = _prefix "LateRegistration"
    /// <summary>
    /// The reception event within a scientific event .
    /// <see href="https://w3id.org/seo#EventReception"></see></summary>
    let EventReception = _prefix "EventReception"
    /// <summary>
    /// An announcement or advertisement that is printed on a sheet of paper and given to people.
    /// <see href="https://w3id.org/seo#Flyer"></see></summary>
    let Flyer = _prefix "Flyer"
    /// <summary>
    /// A person responsible for overseeing and coordinating the whole conference. .
    /// <see href="https://w3id.org/seo#GeneralChair"></see></summary>
    let GeneralChair = _prefix "GeneralChair"
    /// <summary>
    /// Socially gather two or more people in one event .
    /// <see href="https://w3id.org/seo#GetTogetherEvent"></see></summary>
    let GetTogetherEvent = _prefix "GetTogetherEvent"
    /// <summary>
    /// Sponsorship Package.
    /// <see href="https://w3id.org/seo#GoldSponsorship"></see></summary>
    let GoldSponsorship = _prefix "GoldSponsorship"
    /// <summary>
    /// Chair of the conference .
    /// <see href="https://w3id.org/seo#HonorChair"></see></summary>
    let HonorChair = _prefix "HonorChair"
    /// <summary>
    ///   <see href="https://w3id.org/seo#HumanCenteredComputing"></see>
    /// </summary>
    let HumanCenteredComputing = _prefix "HumanCenteredComputing"
    /// <summary>
    /// Important dates to be noticed such as, abstract deadline, submission deadline, ...etc .
    /// <see href="https://w3id.org/seo#ImportantDates"></see></summary>
    let ImportantDates = _prefix "ImportantDates"
    /// <summary>
    /// In-Use track provides researchers to discuss novel research taken to the market.
    /// <see href="https://w3id.org/seo#In-useTrack"></see></summary>
    let ``In-useTrack`` = _prefix "In-useTrack"
    /// <summary>
    /// A business conference is held for people working in the same company or industry.
    /// <see href="https://w3id.org/seo#IndustrialConference"></see></summary>
    let IndustrialConference = _prefix "IndustrialConference"
    /// <summary>
    /// The industry track seeks to present research contributions in industrial settings.
    /// <see href="https://w3id.org/seo#IndustryTrack"></see></summary>
    let IndustryTrack = _prefix "IndustryTrack"
    /// <summary>
    ///   <see href="https://w3id.org/seo#InformationSystems"></see>
    /// </summary>
    let InformationSystems = _prefix "InformationSystems"
    /// <summary>
    /// Invited person to give a speech in an event.
    /// <see href="https://w3id.org/seo#InvitedSpeakers"></see></summary>
    let InvitedSpeakers = _prefix "InvitedSpeakers"
    /// <summary>
    /// A talk that establishes a main underlying the theme of the event.
    /// <see href="https://w3id.org/seo#Keynote"></see></summary>
    let Keynote = _prefix "Keynote"
    /// <summary>
    /// Someone who gives the main address at a formal gathering such as a conference .
    /// <see href="https://w3id.org/seo#KeynoteSpeaker"></see></summary>
    let KeynoteSpeaker = _prefix "KeynoteSpeaker"
    /// <summary>
    /// The chair of the local organizers of the event.
    /// <see href="https://w3id.org/seo#LocalOrganisationChair"></see></summary>
    let LocalOrganisationChair = _prefix "LocalOrganisationChair"
    /// <summary>
    /// Process of signing up for an event on the day of, or at the site of, the event.
    /// <see href="https://w3id.org/seo#OnSiteRegistration"></see></summary>
    let OnSiteRegistration = _prefix "OnSiteRegistration"
    /// <summary>
    /// A person who arranges an event or activity. .
    /// <see href="https://w3id.org/seo#Organizer"></see></summary>
    let Organizer = _prefix "Organizer"
    /// <summary>
    /// Event for PHD student to present and receive feedback on their ongoing work.
    /// <see href="https://w3id.org/seo#PHDSymposium"></see></summary>
    let PHDSymposium = _prefix "PHDSymposium"
    /// <summary>
    /// A conference or meeting to discuss a particular subject.
    /// <see href="https://w3id.org/seo#Symposium"></see></summary>
    let Symposium = _prefix "Symposium"
    /// <summary>
    /// Events happened or existed before the present time.
    /// <see href="https://w3id.org/seo#PastEvents"></see></summary>
    let PastEvents = _prefix "PastEvents"
    /// <summary>
    /// Sponsorship Package.
    /// <see href="https://w3id.org/seo#PlatinumSponsorship"></see></summary>
    let PlatinumSponsorship = _prefix "PlatinumSponsorship"
    /// <summary>
    /// The poster chair is responsible for recruiting and selecting poster fair organizers for the fairs that fall under the shared interest category.
    /// <see href="https://w3id.org/seo#PosterChair"></see></summary>
    let PosterChair = _prefix "PosterChair"
    /// <summary>
    /// Present research contributions as posters.
    /// <see href="https://w3id.org/seo#PostersTrack"></see></summary>
    let PostersTrack = _prefix "PostersTrack"
    /// <summary>
    /// The Program Chair is responsible for working to develop the annual program budget, manage chapter-programming delivery, monitor program quality, manage member satisfaction with programs, and manage all speaker communications.
    /// <see href="https://w3id.org/seo#ProgramChair"></see></summary>
    let ProgramChair = _prefix "ProgramChair"
    /// <summary>
    /// The program committee is responsible for objectively and thoroughly reviewing all submissions, for submitting timely, informative reviews that provide authors with feedback about their submissions, and for attending the program committee meetings.
    /// <see href="https://w3id.org/seo#ProgramCommitteeMember"></see></summary>
    let ProgramCommitteeMember = _prefix "ProgramCommitteeMember"
    /// <summary>
    /// A plan for carrying out a process or procedure, giving lists of intended events and times.
    /// <see href="https://w3id.org/seo#ProgramSchedule"></see></summary>
    let ProgramSchedule = _prefix "ProgramSchedule"
    /// <summary>
    /// The publisher of the event proceedings.
    /// <see href="https://w3id.org/seo#Publisher"></see></summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    /// Normal registration
    /// <see href="https://w3id.org/seo#RegularRegistration"></see></summary>
    let RegularRegistration = _prefix "RegularRegistration"
    /// <summary>
    /// Students full-time enrolled in a college or university can register as a student for the reduced early career rate.
    /// <see href="https://w3id.org/seo#StudentRegistration"></see></summary>
    let StudentRegistration = _prefix "StudentRegistration"
    /// <summary>
    /// The track for fundamental research, innovative technology, and applications concerning the research topic of the event.
    /// <see href="https://w3id.org/seo#ResearchTrack"></see></summary>
    let ResearchTrack = _prefix "ResearchTrack"
    /// <summary>
    /// The Resources Track aims to promote the sharing of resources including: datasets, ontologies, vocabularies, ... etc
    /// <see href="https://w3id.org/seo#ResourceTrack"></see></summary>
    let ResourceTrack = _prefix "ResourceTrack"
    /// <summary>
    /// A person who reviews the submissions and give feedback about the submitted articles.
    /// <see href="https://w3id.org/seo#Reviewer"></see></summary>
    let Reviewer = _prefix "Reviewer"
    /// <summary>
    ///   <see href="https://w3id.org/seo#SecurityAndPrivacy"></see>
    /// </summary>
    let SecurityAndPrivacy = _prefix "SecurityAndPrivacy"
    /// <summary>
    /// Sponsorship Package.
    /// <see href="https://w3id.org/seo#SilverSponsorship"></see></summary>
    let SilverSponsorship = _prefix "SilverSponsorship"
    /// <summary>
    ///   <see href="https://w3id.org/seo#SoftwareEngineering"></see>
    /// </summary>
    let SoftwareEngineering = _prefix "SoftwareEngineering"
    /// <summary>
    /// The Sponsor of the event (i.e. company, university ... etc.).
    /// <see href="https://w3id.org/seo#Sponsor"></see></summary>
    let Sponsor = _prefix "Sponsor"
    /// <summary>
    /// A person responsible for collecting funding from two kinds of sources: granting institutions and corporations.
    /// <see href="https://w3id.org/seo#SponsorshipChair"></see></summary>
    let SponsorshipChair = _prefix "SponsorshipChair"
    /// <summary>
    /// A person enrolled in a school or other educational institution.
    /// <see href="https://w3id.org/seo#Student"></see></summary>
    let Student = _prefix "Student"
    /// <summary>
    /// Instructions for the submission process .
    /// <see href="https://w3id.org/seo#SubmissionGuidelines"></see></summary>
    let SubmissionGuidelines = _prefix "SubmissionGuidelines"
    /// <summary>
    /// A series of symposiums.
    /// <see href="https://w3id.org/seo#SymposiumSeries"></see></summary>
    let SymposiumSeries = _prefix "SymposiumSeries"
    /// <summary>
    ///   <see href="https://w3id.org/seo#TheoryOfComputations"></see>
    /// </summary>
    let TheoryOfComputations = _prefix "TheoryOfComputations"
    /// <summary>
    /// The information about the travel: date, place, ...etc .
    /// <see href="https://w3id.org/seo#TravelInformation"></see></summary>
    let TravelInformation = _prefix "TravelInformation"
    /// <summary>
    /// A person responsible for requesting tutorial proposals and making final selections.
    /// <see href="https://w3id.org/seo#TutorialChair"></see></summary>
    let TutorialChair = _prefix "TutorialChair"
    /// <summary>
    /// The one responsible for collaborating with the workshop chairs for other ACL-affiliated conferences in the given year, in preparing and circulating the Call for Proposals, and in reviewing submissions.
    /// <see href="https://w3id.org/seo#WorkshopChair"></see></summary>
    let WorkshopChair = _prefix "WorkshopChair"
    /// <summary>
    ///   <see href="https://w3id.org/seo#WorldWideWeb"></see>
    /// </summary>
    let WorldWideWeb = _prefix "WorldWideWeb"
    /// <summary>
    /// The deadline of abstract submission.
    /// <see href="https://w3id.org/seo#abstractDeadline"></see></summary>
    let abstractDeadline = _prefix "abstractDeadline"
    /// <summary>
    /// The acceptance rate of the event in a particular year.
    /// <see href="https://w3id.org/seo#acceptanceRate"></see></summary>
    let acceptanceRate = _prefix "acceptanceRate"
    /// <summary>
    /// The number of accepted papers in the event.
    /// <see href="https://w3id.org/seo#acceptedPapers"></see></summary>
    let acceptedPapers = _prefix "acceptedPapers"
    /// <summary>
    /// This property shows the series which an event belongs to.
    /// <see href="https://w3id.org/seo#belongsToSeries"></see></summary>
    let belongsToSeries = _prefix "belongsToSeries"
    /// <summary>
    /// an event series has an event edition
    /// <see href="https://w3id.org/seo#hasEvent"></see></summary>
    let hasEvent = _prefix "hasEvent"
    /// <summary>
    /// The webpage of the event.
    /// <see href="https://w3id.org/seo#eventWebsite"></see></summary>
    let eventWebsite = _prefix "eventWebsite"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasAffiliation"></see>
    /// </summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasChair"></see>
    /// </summary>
    let hasChair = _prefix "hasChair"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasFlyer"></see>
    /// </summary>
    let hasFlyer = _prefix "hasFlyer"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasImportantDates"></see>
    /// </summary>
    let hasImportantDates = _prefix "hasImportantDates"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasKeynote"></see>
    /// </summary>
    let hasKeynote = _prefix "hasKeynote"
    /// <summary>
    ///   <see href="https://w3id.org/seo#keynoteIn"></see>
    /// </summary>
    let keynoteIn = _prefix "keynoteIn"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasProgramCommitteeMember"></see>
    /// </summary>
    let hasProgramCommitteeMember = _prefix "hasProgramCommitteeMember"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasProgramSchedual"></see>
    /// </summary>
    let hasProgramSchedual = _prefix "hasProgramSchedual"
    /// <summary>
    /// This propoerty shows the publisher of a proceedings.
    /// <see href="https://w3id.org/seo#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    ///   <see href="https://w3id.org/seo#isPublisherOf"></see>
    /// </summary>
    let isPublisherOf = _prefix "isPublisherOf"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasRegistration"></see>
    /// </summary>
    let hasRegistration = _prefix "hasRegistration"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasRegistrationType"></see>
    /// </summary>
    let hasRegistrationType = _prefix "hasRegistrationType"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasSocialEvent"></see>
    /// </summary>
    let hasSocialEvent = _prefix "hasSocialEvent"
    /// <summary>
    /// This propoerty shows the sponsor of an event.
    /// <see href="https://w3id.org/seo#hasSponsor"></see></summary>
    let hasSponsor = _prefix "hasSponsor"
    /// <summary>
    ///   <see href="https://w3id.org/seo#isSponsorOf"></see>
    /// </summary>
    let isSponsorOf = _prefix "isSponsorOf"
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasSubmissionGuidelines"></see>
    /// </summary>
    let hasSubmissionGuidelines = _prefix "hasSubmissionGuidelines"
    /// <summary>
    /// This propoerty shows the available tracks of an event.
    /// <see href="https://w3id.org/seo#hasTrack"></see></summary>
    let hasTrack = _prefix "hasTrack"
    /// <summary>
    ///   <see href="https://w3id.org/seo#isTrackOf"></see>
    /// </summary>
    let isTrackOf = _prefix "isTrackOf"
    /// <summary>
    /// The twitter account of the event.
    /// <see href="https://w3id.org/seo#hasTwitter"></see></summary>
    let hasTwitter = _prefix "hasTwitter"
    /// <summary>
    ///   <see href="https://w3id.org/seo#heldInCity"></see>
    /// </summary>
    let heldInCity = _prefix "heldInCity"
    /// <summary>
    ///   <see href="https://w3id.org/seo#heldInCountry"></see>
    /// </summary>
    let heldInCountry = _prefix "heldInCountry"
    /// <summary>
    /// The date of the paper acceptance notification.
    /// <see href="https://w3id.org/seo#notificationDate"></see></summary>
    let notificationDate = _prefix "notificationDate"
    /// <summary>
    ///   <see href="https://w3id.org/seo#offersAward"></see>
    /// </summary>
    let offersAward = _prefix "offersAward"
    /// <summary>
    ///   <see href="https://w3id.org/seo#offersBestPaperAward"></see>
    /// </summary>
    let offersBestPaperAward = _prefix "offersBestPaperAward"
    /// <summary>
    ///   <see href="https://w3id.org/seo#participatesAs"></see>
    /// </summary>
    let participatesAs = _prefix "participatesAs"
    /// <summary>
    ///   <see href="https://w3id.org/seo#providesTravelInformation"></see>
    /// </summary>
    let providesTravelInformation = _prefix "providesTravelInformation"
    /// <summary>
    ///   <see href="https://w3id.org/seo#registeredAs"></see>
    /// </summary>
    let registeredAs = _prefix "registeredAs"
    /// <summary>
    ///   <see href="https://w3id.org/seo#sponsorshipType"></see>
    /// </summary>
    let sponsorshipType = _prefix "sponsorshipType"
    /// <summary>
    /// The deadline of paper submission.
    /// <see href="https://w3id.org/seo#submissionDeadline"></see></summary>
    let submissionDeadline = _prefix "submissionDeadline"
    /// <summary>
    /// The webpage of the submission to event.
    /// <see href="https://w3id.org/seo#submissionWebPage"></see></summary>
    let submissionWebPage = _prefix "submissionWebPage"
    /// <summary>
    /// The number of submitted papers to the event.
    /// <see href="https://w3id.org/seo#submittedPapers"></see></summary>
    let submittedPapers = _prefix "submittedPapers"
    /// <summary>
    ///   <see href="https://w3id.org/seo#takesAward"></see>
    /// </summary>
    let takesAward = _prefix "takesAward"
