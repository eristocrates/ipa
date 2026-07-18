namespace https.w3id.org.seo.hash

open DoxAletheia.Rdf_Vocabulary

module seo =
    let _namespace_name = "https://w3id.org/seo#"

    /// <summary>
    /// This property links an event to another one which is co-located with.
    /// <see href="https://w3id.org/seo#colocatedWith"></see></summary>
    let colocatedWith =
        Namespaced_IRI.parse _namespace_name "colocatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#participatesIn"></see>
    /// </summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#/"></see>
    /// </summary>
    let ``_/`` = Namespaced_IRI.parse _namespace_name "/" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#ArtificialIntelligence"></see>
    /// </summary>
    let ArtificialIntelligence =
        Namespaced_IRI.parse _namespace_name "ArtificialIntelligence" |> NamespacedName

    /// <summary>
    /// Area of interest.
    /// <see href="https://w3id.org/seo#ResearchField"></see></summary>
    let ResearchField =
        Namespaced_IRI.parse _namespace_name "ResearchField" |> NamespacedName

    /// <summary>
    /// The one who write the article.
    /// <see href="https://w3id.org/seo#Author"></see></summary>
    let Author = Namespaced_IRI.parse _namespace_name "Author" |> NamespacedName

    /// <summary>
    /// At least one of the authors must register at the full rate in order for the paper to be published in the Proceedings.
    /// <see href="https://w3id.org/seo#AuthorRegistration"></see></summary>
    let AuthorRegistration =
        Namespaced_IRI.parse _namespace_name "AuthorRegistration" |> NamespacedName

    /// <summary>
    /// A price for the highest quality research.
    /// <see href="https://w3id.org/seo#Award"></see></summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName

    /// <summary>
    /// This award for the best application paper presented.
    /// <see href="https://w3id.org/seo#BestApplicationsPaperAward"></see></summary>
    let BestApplicationsPaperAward =
        Namespaced_IRI.parse _namespace_name "BestApplicationsPaperAward" |> NamespacedName

    /// <summary>
    /// This award recognizes the best paper presented.
    /// <see href="https://w3id.org/seo#BestPaperAward"></see></summary>
    let BestPaperAward =
        Namespaced_IRI.parse _namespace_name "BestPaperAward" |> NamespacedName

    /// <summary>
    /// This award highlight good quality posters presented.
    /// <see href="https://w3id.org/seo#BestPosterAward"></see></summary>
    let BestPosterAward =
        Namespaced_IRI.parse _namespace_name "BestPosterAward" |> NamespacedName

    /// <summary>
    /// This award recognizes the best paper authored primarily by a student and presented by the student.
    /// <see href="https://w3id.org/seo#BestStudentPaperAward"></see></summary>
    let BestStudentPaperAward =
        Namespaced_IRI.parse _namespace_name "BestStudentPaperAward" |> NamespacedName

    /// <summary>
    /// A Sponsorship Package.
    /// <see href="https://w3id.org/seo#BronzeSponsorship"></see></summary>
    let BronzeSponsorship =
        Namespaced_IRI.parse _namespace_name "BronzeSponsorship" |> NamespacedName

    /// <summary>
    /// Refer to a person or organization with some sort of responsibility for another person or organisation.
    /// <see href="https://w3id.org/seo#Sponsorship"></see></summary>
    let Sponsorship =
        Namespaced_IRI.parse _namespace_name "Sponsorship" |> NamespacedName

    /// <summary>
    /// The Chair person must ensure that the Management Committee functions properly, that there is full participation during meetings, that all relevant matters are discussed and that effective decisions are made and carried out.
    /// <see href="https://w3id.org/seo#Chair"></see></summary>
    let Chair = Namespaced_IRI.parse _namespace_name "Chair" |> NamespacedName

    /// <summary>
    /// The idea of the challenge track is to provide participants with a set of case studies and challenge the state of the art.
    /// <see href="https://w3id.org/seo#ChallengeTrack"></see></summary>
    let ChallengeTrack =
        Namespaced_IRI.parse _namespace_name "ChallengeTrack" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#ComputerSystemsOrganization"></see>
    /// </summary>
    let ComputerSystemsOrganization =
        Namespaced_IRI.parse _namespace_name "ComputerSystemsOrganization" |> NamespacedName

    /// <summary>
    /// A person responsible for assembling the system demonstration papers to be presented in the main conference program.
    /// <see href="https://w3id.org/seo#DemoChair"></see></summary>
    let DemoChair = Namespaced_IRI.parse _namespace_name "DemoChair" |> NamespacedName
    /// <summary>
    /// Offer an opportunity for presenting late-breaking research results, on-going research projects, and speculative or innovative work in progress.
    /// <see href="https://w3id.org/seo#DemosTrack"></see></summary>
    let DemosTrack = Namespaced_IRI.parse _namespace_name "DemosTrack" |> NamespacedName

    /// <summary>
    /// Provide PhD students an opportunity to share and develop their research ideas in a critical but supportive environment.
    /// <see href="https://w3id.org/seo#DoctoralConsortium"></see></summary>
    let DoctoralConsortium =
        Namespaced_IRI.parse _namespace_name "DoctoralConsortium" |> NamespacedName

    /// <summary>
    /// The event member who leads the doctoral consortium.
    /// <see href="https://w3id.org/seo#DoctoralConsortiumChair"></see></summary>
    let DoctoralConsortiumChair =
        Namespaced_IRI.parse _namespace_name "DoctoralConsortiumChair" |> NamespacedName

    /// <summary>
    /// Registration before a specific date.
    /// <see href="https://w3id.org/seo#EarlyBirdRegistration"></see></summary>
    let EarlyBirdRegistration =
        Namespaced_IRI.parse _namespace_name "EarlyBirdRegistration" |> NamespacedName

    /// <summary>
    /// The action or process of registering or of being registered.
    /// <see href="https://w3id.org/seo#Registration"></see></summary>
    let Registration =
        Namespaced_IRI.parse _namespace_name "Registration" |> NamespacedName

    /// <summary>
    /// Registration after a specific deadline .
    /// <see href="https://w3id.org/seo#LateRegistration"></see></summary>
    let LateRegistration =
        Namespaced_IRI.parse _namespace_name "LateRegistration" |> NamespacedName

    /// <summary>
    /// The reception event within a scientific event .
    /// <see href="https://w3id.org/seo#EventReception"></see></summary>
    let EventReception =
        Namespaced_IRI.parse _namespace_name "EventReception" |> NamespacedName

    /// <summary>
    /// An announcement or advertisement that is printed on a sheet of paper and given to people.
    /// <see href="https://w3id.org/seo#Flyer"></see></summary>
    let Flyer = Namespaced_IRI.parse _namespace_name "Flyer" |> NamespacedName

    /// <summary>
    /// A person responsible for overseeing and coordinating the whole conference. .
    /// <see href="https://w3id.org/seo#GeneralChair"></see></summary>
    let GeneralChair =
        Namespaced_IRI.parse _namespace_name "GeneralChair" |> NamespacedName

    /// <summary>
    /// Socially gather two or more people in one event .
    /// <see href="https://w3id.org/seo#GetTogetherEvent"></see></summary>
    let GetTogetherEvent =
        Namespaced_IRI.parse _namespace_name "GetTogetherEvent" |> NamespacedName

    /// <summary>
    /// Sponsorship Package.
    /// <see href="https://w3id.org/seo#GoldSponsorship"></see></summary>
    let GoldSponsorship =
        Namespaced_IRI.parse _namespace_name "GoldSponsorship" |> NamespacedName

    /// <summary>
    /// Chair of the conference .
    /// <see href="https://w3id.org/seo#HonorChair"></see></summary>
    let HonorChair = Namespaced_IRI.parse _namespace_name "HonorChair" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#HumanCenteredComputing"></see>
    /// </summary>
    let HumanCenteredComputing =
        Namespaced_IRI.parse _namespace_name "HumanCenteredComputing" |> NamespacedName

    /// <summary>
    /// Important dates to be noticed such as, abstract deadline, submission deadline, ...etc .
    /// <see href="https://w3id.org/seo#ImportantDates"></see></summary>
    let ImportantDates =
        Namespaced_IRI.parse _namespace_name "ImportantDates" |> NamespacedName

    /// <summary>
    /// In-Use track provides researchers to discuss novel research taken to the market.
    /// <see href="https://w3id.org/seo#In-useTrack"></see></summary>
    let ``In-useTrack`` =
        Namespaced_IRI.parse _namespace_name "In-useTrack" |> NamespacedName

    /// <summary>
    /// A business conference is held for people working in the same company or industry.
    /// <see href="https://w3id.org/seo#IndustrialConference"></see></summary>
    let IndustrialConference =
        Namespaced_IRI.parse _namespace_name "IndustrialConference" |> NamespacedName

    /// <summary>
    /// The industry track seeks to present research contributions in industrial settings.
    /// <see href="https://w3id.org/seo#IndustryTrack"></see></summary>
    let IndustryTrack =
        Namespaced_IRI.parse _namespace_name "IndustryTrack" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#InformationSystems"></see>
    /// </summary>
    let InformationSystems =
        Namespaced_IRI.parse _namespace_name "InformationSystems" |> NamespacedName

    /// <summary>
    /// Invited person to give a speech in an event.
    /// <see href="https://w3id.org/seo#InvitedSpeakers"></see></summary>
    let InvitedSpeakers =
        Namespaced_IRI.parse _namespace_name "InvitedSpeakers" |> NamespacedName

    /// <summary>
    /// A talk that establishes a main underlying the theme of the event.
    /// <see href="https://w3id.org/seo#Keynote"></see></summary>
    let Keynote = Namespaced_IRI.parse _namespace_name "Keynote" |> NamespacedName

    /// <summary>
    /// Someone who gives the main address at a formal gathering such as a conference .
    /// <see href="https://w3id.org/seo#KeynoteSpeaker"></see></summary>
    let KeynoteSpeaker =
        Namespaced_IRI.parse _namespace_name "KeynoteSpeaker" |> NamespacedName

    /// <summary>
    /// The chair of the local organizers of the event.
    /// <see href="https://w3id.org/seo#LocalOrganisationChair"></see></summary>
    let LocalOrganisationChair =
        Namespaced_IRI.parse _namespace_name "LocalOrganisationChair" |> NamespacedName

    /// <summary>
    /// Process of signing up for an event on the day of, or at the site of, the event.
    /// <see href="https://w3id.org/seo#OnSiteRegistration"></see></summary>
    let OnSiteRegistration =
        Namespaced_IRI.parse _namespace_name "OnSiteRegistration" |> NamespacedName

    /// <summary>
    /// A person who arranges an event or activity. .
    /// <see href="https://w3id.org/seo#Organizer"></see></summary>
    let Organizer = Namespaced_IRI.parse _namespace_name "Organizer" |> NamespacedName

    /// <summary>
    /// Event for PHD student to present and receive feedback on their ongoing work.
    /// <see href="https://w3id.org/seo#PHDSymposium"></see></summary>
    let PHDSymposium =
        Namespaced_IRI.parse _namespace_name "PHDSymposium" |> NamespacedName

    /// <summary>
    /// A conference or meeting to discuss a particular subject.
    /// <see href="https://w3id.org/seo#Symposium"></see></summary>
    let Symposium = Namespaced_IRI.parse _namespace_name "Symposium" |> NamespacedName
    /// <summary>
    /// Events happened or existed before the present time.
    /// <see href="https://w3id.org/seo#PastEvents"></see></summary>
    let PastEvents = Namespaced_IRI.parse _namespace_name "PastEvents" |> NamespacedName

    /// <summary>
    /// Sponsorship Package.
    /// <see href="https://w3id.org/seo#PlatinumSponsorship"></see></summary>
    let PlatinumSponsorship =
        Namespaced_IRI.parse _namespace_name "PlatinumSponsorship" |> NamespacedName

    /// <summary>
    /// The poster chair is responsible for recruiting and selecting poster fair organizers for the fairs that fall under the shared interest category.
    /// <see href="https://w3id.org/seo#PosterChair"></see></summary>
    let PosterChair =
        Namespaced_IRI.parse _namespace_name "PosterChair" |> NamespacedName

    /// <summary>
    /// Present research contributions as posters.
    /// <see href="https://w3id.org/seo#PostersTrack"></see></summary>
    let PostersTrack =
        Namespaced_IRI.parse _namespace_name "PostersTrack" |> NamespacedName

    /// <summary>
    /// The Program Chair is responsible for working to develop the annual program budget, manage chapter-programming delivery, monitor program quality, manage member satisfaction with programs, and manage all speaker communications.
    /// <see href="https://w3id.org/seo#ProgramChair"></see></summary>
    let ProgramChair =
        Namespaced_IRI.parse _namespace_name "ProgramChair" |> NamespacedName

    /// <summary>
    /// The program committee is responsible for objectively and thoroughly reviewing all submissions, for submitting timely, informative reviews that provide authors with feedback about their submissions, and for attending the program committee meetings.
    /// <see href="https://w3id.org/seo#ProgramCommitteeMember"></see></summary>
    let ProgramCommitteeMember =
        Namespaced_IRI.parse _namespace_name "ProgramCommitteeMember" |> NamespacedName

    /// <summary>
    /// A plan for carrying out a process or procedure, giving lists of intended events and times.
    /// <see href="https://w3id.org/seo#ProgramSchedule"></see></summary>
    let ProgramSchedule =
        Namespaced_IRI.parse _namespace_name "ProgramSchedule" |> NamespacedName

    /// <summary>
    /// The publisher of the event proceedings.
    /// <see href="https://w3id.org/seo#Publisher"></see></summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName

    /// <summary>
    /// Normal registration
    /// <see href="https://w3id.org/seo#RegularRegistration"></see></summary>
    let RegularRegistration =
        Namespaced_IRI.parse _namespace_name "RegularRegistration" |> NamespacedName

    /// <summary>
    /// Students full-time enrolled in a college or university can register as a student for the reduced early career rate.
    /// <see href="https://w3id.org/seo#StudentRegistration"></see></summary>
    let StudentRegistration =
        Namespaced_IRI.parse _namespace_name "StudentRegistration" |> NamespacedName

    /// <summary>
    /// The track for fundamental research, innovative technology, and applications concerning the research topic of the event.
    /// <see href="https://w3id.org/seo#ResearchTrack"></see></summary>
    let ResearchTrack =
        Namespaced_IRI.parse _namespace_name "ResearchTrack" |> NamespacedName

    /// <summary>
    /// The Resources Track aims to promote the sharing of resources including: datasets, ontologies, vocabularies, ... etc
    /// <see href="https://w3id.org/seo#ResourceTrack"></see></summary>
    let ResourceTrack =
        Namespaced_IRI.parse _namespace_name "ResourceTrack" |> NamespacedName

    /// <summary>
    /// A person who reviews the submissions and give feedback about the submitted articles.
    /// <see href="https://w3id.org/seo#Reviewer"></see></summary>
    let Reviewer = Namespaced_IRI.parse _namespace_name "Reviewer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#SecurityAndPrivacy"></see>
    /// </summary>
    let SecurityAndPrivacy =
        Namespaced_IRI.parse _namespace_name "SecurityAndPrivacy" |> NamespacedName

    /// <summary>
    /// Sponsorship Package.
    /// <see href="https://w3id.org/seo#SilverSponsorship"></see></summary>
    let SilverSponsorship =
        Namespaced_IRI.parse _namespace_name "SilverSponsorship" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#SoftwareEngineering"></see>
    /// </summary>
    let SoftwareEngineering =
        Namespaced_IRI.parse _namespace_name "SoftwareEngineering" |> NamespacedName

    /// <summary>
    /// The Sponsor of the event (i.e. company, university ... etc.).
    /// <see href="https://w3id.org/seo#Sponsor"></see></summary>
    let Sponsor = Namespaced_IRI.parse _namespace_name "Sponsor" |> NamespacedName

    /// <summary>
    /// A person responsible for collecting funding from two kinds of sources: granting institutions and corporations.
    /// <see href="https://w3id.org/seo#SponsorshipChair"></see></summary>
    let SponsorshipChair =
        Namespaced_IRI.parse _namespace_name "SponsorshipChair" |> NamespacedName

    /// <summary>
    /// A person enrolled in a school or other educational institution.
    /// <see href="https://w3id.org/seo#Student"></see></summary>
    let Student = Namespaced_IRI.parse _namespace_name "Student" |> NamespacedName

    /// <summary>
    /// Instructions for the submission process .
    /// <see href="https://w3id.org/seo#SubmissionGuidelines"></see></summary>
    let SubmissionGuidelines =
        Namespaced_IRI.parse _namespace_name "SubmissionGuidelines" |> NamespacedName

    /// <summary>
    /// A series of symposiums.
    /// <see href="https://w3id.org/seo#SymposiumSeries"></see></summary>
    let SymposiumSeries =
        Namespaced_IRI.parse _namespace_name "SymposiumSeries" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#TheoryOfComputations"></see>
    /// </summary>
    let TheoryOfComputations =
        Namespaced_IRI.parse _namespace_name "TheoryOfComputations" |> NamespacedName

    /// <summary>
    /// The information about the travel: date, place, ...etc .
    /// <see href="https://w3id.org/seo#TravelInformation"></see></summary>
    let TravelInformation =
        Namespaced_IRI.parse _namespace_name "TravelInformation" |> NamespacedName

    /// <summary>
    /// A person responsible for requesting tutorial proposals and making final selections.
    /// <see href="https://w3id.org/seo#TutorialChair"></see></summary>
    let TutorialChair =
        Namespaced_IRI.parse _namespace_name "TutorialChair" |> NamespacedName

    /// <summary>
    /// The one responsible for collaborating with the workshop chairs for other ACL-affiliated conferences in the given year, in preparing and circulating the Call for Proposals, and in reviewing submissions.
    /// <see href="https://w3id.org/seo#WorkshopChair"></see></summary>
    let WorkshopChair =
        Namespaced_IRI.parse _namespace_name "WorkshopChair" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#WorldWideWeb"></see>
    /// </summary>
    let WorldWideWeb =
        Namespaced_IRI.parse _namespace_name "WorldWideWeb" |> NamespacedName

    /// <summary>
    /// The deadline of abstract submission.
    /// <see href="https://w3id.org/seo#abstractDeadline"></see></summary>
    let abstractDeadline =
        Namespaced_IRI.parse _namespace_name "abstractDeadline" |> NamespacedName

    /// <summary>
    /// The acceptance rate of the event in a particular year.
    /// <see href="https://w3id.org/seo#acceptanceRate"></see></summary>
    let acceptanceRate =
        Namespaced_IRI.parse _namespace_name "acceptanceRate" |> NamespacedName

    /// <summary>
    /// The number of accepted papers in the event.
    /// <see href="https://w3id.org/seo#acceptedPapers"></see></summary>
    let acceptedPapers =
        Namespaced_IRI.parse _namespace_name "acceptedPapers" |> NamespacedName

    /// <summary>
    /// This property shows the series which an event belongs to.
    /// <see href="https://w3id.org/seo#belongsToSeries"></see></summary>
    let belongsToSeries =
        Namespaced_IRI.parse _namespace_name "belongsToSeries" |> NamespacedName

    /// <summary>
    /// an event series has an event edition
    /// <see href="https://w3id.org/seo#hasEvent"></see></summary>
    let hasEvent = Namespaced_IRI.parse _namespace_name "hasEvent" |> NamespacedName

    /// <summary>
    /// The webpage of the event.
    /// <see href="https://w3id.org/seo#eventWebsite"></see></summary>
    let eventWebsite =
        Namespaced_IRI.parse _namespace_name "eventWebsite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasAffiliation"></see>
    /// </summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasChair"></see>
    /// </summary>
    let hasChair = Namespaced_IRI.parse _namespace_name "hasChair" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/seo#hasFlyer"></see>
    /// </summary>
    let hasFlyer = Namespaced_IRI.parse _namespace_name "hasFlyer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasImportantDates"></see>
    /// </summary>
    let hasImportantDates =
        Namespaced_IRI.parse _namespace_name "hasImportantDates" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasKeynote"></see>
    /// </summary>
    let hasKeynote = Namespaced_IRI.parse _namespace_name "hasKeynote" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/seo#keynoteIn"></see>
    /// </summary>
    let keynoteIn = Namespaced_IRI.parse _namespace_name "keynoteIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasProgramCommitteeMember"></see>
    /// </summary>
    let hasProgramCommitteeMember =
        Namespaced_IRI.parse _namespace_name "hasProgramCommitteeMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasProgramSchedual"></see>
    /// </summary>
    let hasProgramSchedual =
        Namespaced_IRI.parse _namespace_name "hasProgramSchedual" |> NamespacedName

    /// <summary>
    /// This propoerty shows the publisher of a proceedings.
    /// <see href="https://w3id.org/seo#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#isPublisherOf"></see>
    /// </summary>
    let isPublisherOf =
        Namespaced_IRI.parse _namespace_name "isPublisherOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasRegistration"></see>
    /// </summary>
    let hasRegistration =
        Namespaced_IRI.parse _namespace_name "hasRegistration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasRegistrationType"></see>
    /// </summary>
    let hasRegistrationType =
        Namespaced_IRI.parse _namespace_name "hasRegistrationType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasSocialEvent"></see>
    /// </summary>
    let hasSocialEvent =
        Namespaced_IRI.parse _namespace_name "hasSocialEvent" |> NamespacedName

    /// <summary>
    /// This propoerty shows the sponsor of an event.
    /// <see href="https://w3id.org/seo#hasSponsor"></see></summary>
    let hasSponsor = Namespaced_IRI.parse _namespace_name "hasSponsor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#isSponsorOf"></see>
    /// </summary>
    let isSponsorOf =
        Namespaced_IRI.parse _namespace_name "isSponsorOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#hasSubmissionGuidelines"></see>
    /// </summary>
    let hasSubmissionGuidelines =
        Namespaced_IRI.parse _namespace_name "hasSubmissionGuidelines" |> NamespacedName

    /// <summary>
    /// This propoerty shows the available tracks of an event.
    /// <see href="https://w3id.org/seo#hasTrack"></see></summary>
    let hasTrack = Namespaced_IRI.parse _namespace_name "hasTrack" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/seo#isTrackOf"></see>
    /// </summary>
    let isTrackOf = Namespaced_IRI.parse _namespace_name "isTrackOf" |> NamespacedName
    /// <summary>
    /// The twitter account of the event.
    /// <see href="https://w3id.org/seo#hasTwitter"></see></summary>
    let hasTwitter = Namespaced_IRI.parse _namespace_name "hasTwitter" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/seo#heldInCity"></see>
    /// </summary>
    let heldInCity = Namespaced_IRI.parse _namespace_name "heldInCity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#heldInCountry"></see>
    /// </summary>
    let heldInCountry =
        Namespaced_IRI.parse _namespace_name "heldInCountry" |> NamespacedName

    /// <summary>
    /// The date of the paper acceptance notification.
    /// <see href="https://w3id.org/seo#notificationDate"></see></summary>
    let notificationDate =
        Namespaced_IRI.parse _namespace_name "notificationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#offersAward"></see>
    /// </summary>
    let offersAward =
        Namespaced_IRI.parse _namespace_name "offersAward" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#offersBestPaperAward"></see>
    /// </summary>
    let offersBestPaperAward =
        Namespaced_IRI.parse _namespace_name "offersBestPaperAward" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#participatesAs"></see>
    /// </summary>
    let participatesAs =
        Namespaced_IRI.parse _namespace_name "participatesAs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#providesTravelInformation"></see>
    /// </summary>
    let providesTravelInformation =
        Namespaced_IRI.parse _namespace_name "providesTravelInformation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#registeredAs"></see>
    /// </summary>
    let registeredAs =
        Namespaced_IRI.parse _namespace_name "registeredAs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#sponsorshipType"></see>
    /// </summary>
    let sponsorshipType =
        Namespaced_IRI.parse _namespace_name "sponsorshipType" |> NamespacedName

    /// <summary>
    /// The deadline of paper submission.
    /// <see href="https://w3id.org/seo#submissionDeadline"></see></summary>
    let submissionDeadline =
        Namespaced_IRI.parse _namespace_name "submissionDeadline" |> NamespacedName

    /// <summary>
    /// The webpage of the submission to event.
    /// <see href="https://w3id.org/seo#submissionWebPage"></see></summary>
    let submissionWebPage =
        Namespaced_IRI.parse _namespace_name "submissionWebPage" |> NamespacedName

    /// <summary>
    /// The number of submitted papers to the event.
    /// <see href="https://w3id.org/seo#submittedPapers"></see></summary>
    let submittedPapers =
        Namespaced_IRI.parse _namespace_name "submittedPapers" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/seo#takesAward"></see>
    /// </summary>
    let takesAward = Namespaced_IRI.parse _namespace_name "takesAward" |> NamespacedName
