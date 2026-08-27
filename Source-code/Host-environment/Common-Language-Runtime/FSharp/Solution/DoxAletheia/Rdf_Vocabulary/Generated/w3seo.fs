namespace https.w3id.org.seo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3seo =
    let _namespace_iri = Namespace_Iri w3seo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:seo#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Scientific Events Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/seo#">https://w3id.org/seo#</seealso>
    let _prefix_iri = Prefixed_Name(w3seo, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#/">https://w3id.org/seo#/</seealso>
    let ``_/`` = Prefixed_Name(w3seo, "/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#ArtificialIntelligence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:seo#ResearchField</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#ArtificialIntelligence">https://w3id.org/seo#ArtificialIntelligence</seealso>
    let ArtificialIntelligence =
        Prefixed_Name(w3seo, "ArtificialIntelligence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#Author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The one who write the article."</para>
    /// labels<para>"Author"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Author">https://w3id.org/seo#Author</seealso>
    let Author = Prefixed_Name(w3seo, "Author") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#AuthorRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"At least one of the authors must register at the full rate in order for the paper to be published in the Proceedings."</para>
    /// labels<para>"Author registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#AuthorRegistration">https://w3id.org/seo#AuthorRegistration</seealso>
    let AuthorRegistration = Prefixed_Name(w3seo, "AuthorRegistration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A price for the highest quality research."</para>
    /// labels<para>"Award"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Award">https://w3id.org/seo#Award</seealso>
    let Award = Prefixed_Name(w3seo, "Award") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#BestApplicationsPaperAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This award for the best application paper presented. "</para>
    /// labels<para>"Best applications paper award"</para></remarks>
    /// <seealso href="https://w3id.org/seo#BestApplicationsPaperAward">https://w3id.org/seo#BestApplicationsPaperAward</seealso>
    let BestApplicationsPaperAward =
        Prefixed_Name(w3seo, "BestApplicationsPaperAward") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#BestPaperAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This award recognizes the best paper presented."</para>
    /// labels<para>"Best paper award"</para></remarks>
    /// <seealso href="https://w3id.org/seo#BestPaperAward">https://w3id.org/seo#BestPaperAward</seealso>
    let BestPaperAward = Prefixed_Name(w3seo, "BestPaperAward") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#BestPosterAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This award highlight good quality posters presented."</para>
    /// labels<para>"Best poster award"</para></remarks>
    /// <seealso href="https://w3id.org/seo#BestPosterAward">https://w3id.org/seo#BestPosterAward</seealso>
    let BestPosterAward = Prefixed_Name(w3seo, "BestPosterAward") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#BestStudentPaperAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This award recognizes the best paper authored primarily by a student and presented by the student."</para>
    /// labels<para>"Best student paper award"</para></remarks>
    /// <seealso href="https://w3id.org/seo#BestStudentPaperAward">https://w3id.org/seo#BestStudentPaperAward</seealso>
    let BestStudentPaperAward =
        Prefixed_Name(w3seo, "BestStudentPaperAward") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#BronzeSponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Sponsorship Package."</para>
    /// labels<para>"Bronze sponsorship"</para></remarks>
    /// <seealso href="https://w3id.org/seo#BronzeSponsorship">https://w3id.org/seo#BronzeSponsorship</seealso>
    let BronzeSponsorship = Prefixed_Name(w3seo, "BronzeSponsorship") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Chair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Chair person must ensure that the Management Committee functions properly, that there is full participation during meetings, that all relevant matters are discussed and that effective decisions are made and carried out."</para>
    /// labels<para>"Chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Chair">https://w3id.org/seo#Chair</seealso>
    let Chair = Prefixed_Name(w3seo, "Chair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#ChallengeTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The idea of the challenge track is to provide participants with a set of case studies and challenge the state of the art."</para>
    /// labels<para>"Challenge track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ChallengeTrack">https://w3id.org/seo#ChallengeTrack</seealso>
    let ChallengeTrack = Prefixed_Name(w3seo, "ChallengeTrack") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#ComputerSystemsOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:seo#ResearchField</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#ComputerSystemsOrganization">https://w3id.org/seo#ComputerSystemsOrganization</seealso>
    let ComputerSystemsOrganization =
        Prefixed_Name(w3seo, "ComputerSystemsOrganization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#DemoChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person responsible for assembling the system demonstration papers to be presented in the main conference program. "</para>
    /// labels<para>"Demo chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#DemoChair">https://w3id.org/seo#DemoChair</seealso>
    let DemoChair = Prefixed_Name(w3seo, "DemoChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#DemosTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Offer an opportunity for presenting late-breaking research results, on-going research projects, and speculative or innovative work in progress."</para>
    /// labels<para>"Demos track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#DemosTrack">https://w3id.org/seo#DemosTrack</seealso>
    let DemosTrack = Prefixed_Name(w3seo, "DemosTrack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#DoctoralConsortium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Provide PhD students an opportunity to share and develop their research ideas in a critical but supportive environment."</para>
    /// labels<para>"Doctoral consortium"</para></remarks>
    /// <seealso href="https://w3id.org/seo#DoctoralConsortium">https://w3id.org/seo#DoctoralConsortium</seealso>
    let DoctoralConsortium = Prefixed_Name(w3seo, "DoctoralConsortium") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#DoctoralConsortiumChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The event member who leads the doctoral consortium."</para>
    /// labels<para>"Doctoral consortium chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#DoctoralConsortiumChair">https://w3id.org/seo#DoctoralConsortiumChair</seealso>
    let DoctoralConsortiumChair =
        Prefixed_Name(w3seo, "DoctoralConsortiumChair") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#EarlyBirdRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Registration before a specific date."</para>
    /// labels<para>"Early bird registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#EarlyBirdRegistration">https://w3id.org/seo#EarlyBirdRegistration</seealso>
    let EarlyBirdRegistration =
        Prefixed_Name(w3seo, "EarlyBirdRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#EventReception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The reception event within a scientific event ."</para>
    /// labels<para>"Event reception"</para></remarks>
    /// <seealso href="https://w3id.org/seo#EventReception">https://w3id.org/seo#EventReception</seealso>
    let EventReception = Prefixed_Name(w3seo, "EventReception") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Flyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An announcement or advertisement that is printed on a sheet of paper and given to people."</para>
    /// labels<para>"Flyer"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Flyer">https://w3id.org/seo#Flyer</seealso>
    let Flyer = Prefixed_Name(w3seo, "Flyer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#GeneralChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person responsible for overseeing and coordinating the whole conference. ."</para>
    /// labels<para>"General chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#GeneralChair">https://w3id.org/seo#GeneralChair</seealso>
    let GeneralChair = Prefixed_Name(w3seo, "GeneralChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#GetTogetherEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Socially gather two or more people in one event ."</para>
    /// labels<para>"Get together event"</para></remarks>
    /// <seealso href="https://w3id.org/seo#GetTogetherEvent">https://w3id.org/seo#GetTogetherEvent</seealso>
    let GetTogetherEvent = Prefixed_Name(w3seo, "GetTogetherEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#GoldSponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sponsorship Package."</para>
    /// labels<para>"Gold sponsorship"</para></remarks>
    /// <seealso href="https://w3id.org/seo#GoldSponsorship">https://w3id.org/seo#GoldSponsorship</seealso>
    let GoldSponsorship = Prefixed_Name(w3seo, "GoldSponsorship") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#HonorChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chair of the conference ."</para>
    /// labels<para>"Honor chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#HonorChair">https://w3id.org/seo#HonorChair</seealso>
    let HonorChair = Prefixed_Name(w3seo, "HonorChair") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#HumanCenteredComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:seo#ResearchField</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#HumanCenteredComputing">https://w3id.org/seo#HumanCenteredComputing</seealso>
    let HumanCenteredComputing =
        Prefixed_Name(w3seo, "HumanCenteredComputing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#ImportantDates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Important dates to be noticed such as, abstract deadline, submission deadline, ...etc ."</para>
    /// labels<para>"Important dates"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ImportantDates">https://w3id.org/seo#ImportantDates</seealso>
    let ImportantDates = Prefixed_Name(w3seo, "ImportantDates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#In-useTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In-Use track provides researchers to discuss novel research taken to the market."</para>
    /// labels<para>"In-use track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#In-useTrack">https://w3id.org/seo#In-useTrack</seealso>
    let In_useTrack = Prefixed_Name(w3seo, "In-useTrack") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#IndustrialConference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A business conference is held for people working in the same company or industry."</para>
    /// labels<para>"Industrial conference"</para></remarks>
    /// <seealso href="https://w3id.org/seo#IndustrialConference">https://w3id.org/seo#IndustrialConference</seealso>
    let IndustrialConference =
        Prefixed_Name(w3seo, "IndustrialConference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#IndustryTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The industry track seeks to present research contributions in industrial settings."</para>
    /// labels<para>"Industry track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#IndustryTrack">https://w3id.org/seo#IndustryTrack</seealso>
    let IndustryTrack = Prefixed_Name(w3seo, "IndustryTrack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#InformationSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:seo#ResearchField</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#InformationSystems">https://w3id.org/seo#InformationSystems</seealso>
    let InformationSystems = Prefixed_Name(w3seo, "InformationSystems") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#InvitedSpeakers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Invited person to give a speech in an event."</para>
    /// labels<para>"Invited speakers"</para></remarks>
    /// <seealso href="https://w3id.org/seo#InvitedSpeakers">https://w3id.org/seo#InvitedSpeakers</seealso>
    let InvitedSpeakers = Prefixed_Name(w3seo, "InvitedSpeakers") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Keynote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A talk that establishes a main underlying the theme of the event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Keynote speech"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/seo#Keynote">https://w3id.org/seo#Keynote</seealso>
    let Keynote = Prefixed_Name(w3seo, "Keynote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#KeynoteSpeaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Someone who gives the main address at a formal gathering such as a conference ."</para>
    /// labels<para>"Keynote speaker"</para></remarks>
    /// <seealso href="https://w3id.org/seo#KeynoteSpeaker">https://w3id.org/seo#KeynoteSpeaker</seealso>
    let KeynoteSpeaker = Prefixed_Name(w3seo, "KeynoteSpeaker") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#LateRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Registration after a specific deadline ."</para>
    /// labels<para>"Late registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#LateRegistration">https://w3id.org/seo#LateRegistration</seealso>
    let LateRegistration = Prefixed_Name(w3seo, "LateRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#LocalOrganisationChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The chair of the local organizers of the event. "</para>
    /// labels<para>"Local organisation chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#LocalOrganisationChair">https://w3id.org/seo#LocalOrganisationChair</seealso>
    let LocalOrganisationChair =
        Prefixed_Name(w3seo, "LocalOrganisationChair") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#OnSiteRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Process of signing up for an event on the day of, or at the site of, the event."</para>
    /// labels<para>"On site registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#OnSiteRegistration">https://w3id.org/seo#OnSiteRegistration</seealso>
    let OnSiteRegistration = Prefixed_Name(w3seo, "OnSiteRegistration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who arranges an event or activity. ."</para>
    /// labels<para>"Organizer"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Organizer">https://w3id.org/seo#Organizer</seealso>
    let Organizer = Prefixed_Name(w3seo, "Organizer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#PHDSymposium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Event for PHD student to present and receive feedback on their ongoing work."</para>
    /// labels<para>"PHD symposium"</para></remarks>
    /// <seealso href="https://w3id.org/seo#PHDSymposium">https://w3id.org/seo#PHDSymposium</seealso>
    let PHDSymposium = Prefixed_Name(w3seo, "PHDSymposium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#PastEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Events happened or existed before the present time. "</para>
    /// labels<para>"Past events"</para></remarks>
    /// <seealso href="https://w3id.org/seo#PastEvents">https://w3id.org/seo#PastEvents</seealso>
    let PastEvents = Prefixed_Name(w3seo, "PastEvents") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#PlatinumSponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sponsorship Package."</para>
    /// labels<para>"Platinum sponsorship"</para></remarks>
    /// <seealso href="https://w3id.org/seo#PlatinumSponsorship">https://w3id.org/seo#PlatinumSponsorship</seealso>
    let PlatinumSponsorship =
        Prefixed_Name(w3seo, "PlatinumSponsorship") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#PosterChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The poster chair is responsible for recruiting and selecting poster fair organizers for the fairs that fall under the shared interest category."</para>
    /// labels<para>"Poster chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#PosterChair">https://w3id.org/seo#PosterChair</seealso>
    let PosterChair = Prefixed_Name(w3seo, "PosterChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#PostersTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Present research contributions as posters."</para>
    /// labels<para>"Posters track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#PostersTrack">https://w3id.org/seo#PostersTrack</seealso>
    let PostersTrack = Prefixed_Name(w3seo, "PostersTrack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#ProgramChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Program Chair is responsible for working to develop the annual program budget, manage chapter-programming delivery, monitor program quality, manage member satisfaction with programs, and manage all speaker communications. "</para>
    /// labels<para>"Program chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ProgramChair">https://w3id.org/seo#ProgramChair</seealso>
    let ProgramChair = Prefixed_Name(w3seo, "ProgramChair") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#ProgramCommitteeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The program committee is responsible for objectively and thoroughly reviewing all submissions, for submitting timely, informative reviews that provide authors with feedback about their submissions, and for attending the program committee meetings."</para>
    /// labels<para>"Program committee member"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ProgramCommitteeMember">https://w3id.org/seo#ProgramCommitteeMember</seealso>
    let ProgramCommitteeMember =
        Prefixed_Name(w3seo, "ProgramCommitteeMember") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#ProgramSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan for carrying out a process or procedure, giving lists of intended events and times."</para>
    /// labels<para>"Program schedule"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ProgramSchedule">https://w3id.org/seo#ProgramSchedule</seealso>
    let ProgramSchedule = Prefixed_Name(w3seo, "ProgramSchedule") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The publisher of the event proceedings."</para>
    /// labels<para>"Publisher"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Publisher">https://w3id.org/seo#Publisher</seealso>
    let Publisher = Prefixed_Name(w3seo, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The action or process of registering or of being registered."</para>
    /// labels<para>"Registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Registration">https://w3id.org/seo#Registration</seealso>
    let Registration = Prefixed_Name(w3seo, "Registration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#RegularRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Normal registration"</para>
    /// labels<para>"Regular registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#RegularRegistration">https://w3id.org/seo#RegularRegistration</seealso>
    let RegularRegistration =
        Prefixed_Name(w3seo, "RegularRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#ResearchField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Area of interest."</para>
    /// labels<para>"Research field"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ResearchField">https://w3id.org/seo#ResearchField</seealso>
    let ResearchField = Prefixed_Name(w3seo, "ResearchField") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#ResearchTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The track for fundamental research, innovative technology, and applications concerning the research topic of the event."</para>
    /// labels<para>"Research track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ResearchTrack">https://w3id.org/seo#ResearchTrack</seealso>
    let ResearchTrack = Prefixed_Name(w3seo, "ResearchTrack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#ResourceTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Resources Track aims to promote the sharing of resources including: datasets, ontologies, vocabularies, ... etc"</para>
    /// labels<para>"Resource track"</para></remarks>
    /// <seealso href="https://w3id.org/seo#ResourceTrack">https://w3id.org/seo#ResourceTrack</seealso>
    let ResourceTrack = Prefixed_Name(w3seo, "ResourceTrack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who reviews the submissions and give feedback about the submitted articles."</para>
    /// labels<para>"Reviewer"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Reviewer">https://w3id.org/seo#Reviewer</seealso>
    let Reviewer = Prefixed_Name(w3seo, "Reviewer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#SecurityAndPrivacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:seo#ResearchField</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#SecurityAndPrivacy">https://w3id.org/seo#SecurityAndPrivacy</seealso>
    let SecurityAndPrivacy = Prefixed_Name(w3seo, "SecurityAndPrivacy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#SilverSponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sponsorship Package."</para>
    /// labels<para>"Silver sponsorship"</para></remarks>
    /// <seealso href="https://w3id.org/seo#SilverSponsorship">https://w3id.org/seo#SilverSponsorship</seealso>
    let SilverSponsorship = Prefixed_Name(w3seo, "SilverSponsorship") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#SoftwareEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:seo#ResearchField</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#SoftwareEngineering">https://w3id.org/seo#SoftwareEngineering</seealso>
    let SoftwareEngineering =
        Prefixed_Name(w3seo, "SoftwareEngineering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#Sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Sponsor of the event (i.e. company, university ... etc.)."</para>
    /// labels<para>"Sponsor"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Sponsor">https://w3id.org/seo#Sponsor</seealso>
    let Sponsor = Prefixed_Name(w3seo, "Sponsor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Sponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refer to a person or organization with some sort of responsibility for another person or organisation."</para>
    /// labels<para>"Sponsorship"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Sponsorship">https://w3id.org/seo#Sponsorship</seealso>
    let Sponsorship = Prefixed_Name(w3seo, "Sponsorship") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#SponsorshipChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person responsible for collecting funding from two kinds of sources: granting institutions and corporations. "</para>
    /// labels<para>"Sponsorship chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#SponsorshipChair">https://w3id.org/seo#SponsorshipChair</seealso>
    let SponsorshipChair = Prefixed_Name(w3seo, "SponsorshipChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person enrolled in a school or other educational institution."</para>
    /// labels<para>"Student"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Student">https://w3id.org/seo#Student</seealso>
    let Student = Prefixed_Name(w3seo, "Student") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#StudentRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Students full-time enrolled in a college or university can register as a student for the reduced early career rate."</para>
    /// labels<para>"Student registration"</para></remarks>
    /// <seealso href="https://w3id.org/seo#StudentRegistration">https://w3id.org/seo#StudentRegistration</seealso>
    let StudentRegistration =
        Prefixed_Name(w3seo, "StudentRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#SubmissionGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Instructions for the submission process ."</para>
    /// labels<para>"Submission guidelines"</para></remarks>
    /// <seealso href="https://w3id.org/seo#SubmissionGuidelines">https://w3id.org/seo#SubmissionGuidelines</seealso>
    let SubmissionGuidelines =
        Prefixed_Name(w3seo, "SubmissionGuidelines") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#Symposium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A conference or meeting to discuss a particular subject."</para>
    /// labels<para>"Symposium"</para></remarks>
    /// <seealso href="https://w3id.org/seo#Symposium">https://w3id.org/seo#Symposium</seealso>
    let Symposium = Prefixed_Name(w3seo, "Symposium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#SymposiumSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A series of symposiums."</para>
    /// labels<para>"Symposiums series"</para></remarks>
    /// <seealso href="https://w3id.org/seo#SymposiumSeries">https://w3id.org/seo#SymposiumSeries</seealso>
    let SymposiumSeries = Prefixed_Name(w3seo, "SymposiumSeries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#TheoryOfComputations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:seo#ResearchField</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#TheoryOfComputations">https://w3id.org/seo#TheoryOfComputations</seealso>
    let TheoryOfComputations =
        Prefixed_Name(w3seo, "TheoryOfComputations") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#TravelInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The information about the travel: date, place, ...etc ."</para>
    /// labels<para>"Travel information"</para></remarks>
    /// <seealso href="https://w3id.org/seo#TravelInformation">https://w3id.org/seo#TravelInformation</seealso>
    let TravelInformation = Prefixed_Name(w3seo, "TravelInformation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#TutorialChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person responsible for requesting tutorial proposals and making final selections."</para>
    /// labels<para>"Tutorial chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#TutorialChair">https://w3id.org/seo#TutorialChair</seealso>
    let TutorialChair = Prefixed_Name(w3seo, "TutorialChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#WorkshopChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The one responsible for collaborating with the workshop chairs for other ACL-affiliated conferences in the given year, in preparing and circulating the Call for Proposals, and in reviewing submissions."</para>
    /// labels<para>"Workshop chair"</para></remarks>
    /// <seealso href="https://w3id.org/seo#WorkshopChair">https://w3id.org/seo#WorkshopChair</seealso>
    let WorkshopChair = Prefixed_Name(w3seo, "WorkshopChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#WorldWideWeb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:seo#ResearchField</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#WorldWideWeb">https://w3id.org/seo#WorldWideWeb</seealso>
    let WorldWideWeb = Prefixed_Name(w3seo, "WorldWideWeb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#abstractDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The deadline of abstract submission."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#abstractDeadline">https://w3id.org/seo#abstractDeadline</seealso>
    let abstractDeadline = Prefixed_Name(w3seo, "abstractDeadline") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#acceptanceRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The acceptance rate of the event in a particular year."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#acceptanceRate">https://w3id.org/seo#acceptanceRate</seealso>
    let acceptanceRate = Prefixed_Name(w3seo, "acceptanceRate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#acceptedPapers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of accepted papers in the event."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#acceptedPapers">https://w3id.org/seo#acceptedPapers</seealso>
    let acceptedPapers = Prefixed_Name(w3seo, "acceptedPapers") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#belongsToSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property shows the series which an event belongs to."</para>
    /// labels<para>"belongsToSeries"</para></remarks>
    /// <seealso href="https://w3id.org/seo#belongsToSeries">https://w3id.org/seo#belongsToSeries</seealso>
    let belongsToSeries = Prefixed_Name(w3seo, "belongsToSeries") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#colocatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links an event to another one which is co-located with."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#colocatedWith">https://w3id.org/seo#colocatedWith</seealso>
    let colocatedWith = Prefixed_Name(w3seo, "colocatedWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#eventWebsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The webpage of the event."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#eventWebsite">https://w3id.org/seo#eventWebsite</seealso>
    let eventWebsite = Prefixed_Name(w3seo, "eventWebsite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasAffiliation">https://w3id.org/seo#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(w3seo, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasChair">https://w3id.org/seo#hasChair</seealso>
    let hasChair = Prefixed_Name(w3seo, "hasChair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"an event series has an event edition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasEvent">https://w3id.org/seo#hasEvent</seealso>
    let hasEvent = Prefixed_Name(w3seo, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasFlyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasFlyer">https://w3id.org/seo#hasFlyer</seealso>
    let hasFlyer = Prefixed_Name(w3seo, "hasFlyer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasImportantDates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasImportantDates">https://w3id.org/seo#hasImportantDates</seealso>
    let hasImportantDates = Prefixed_Name(w3seo, "hasImportantDates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasKeynote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasKeynote">https://w3id.org/seo#hasKeynote</seealso>
    let hasKeynote = Prefixed_Name(w3seo, "hasKeynote") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#hasProgramCommitteeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasProgramCommitteeMember">https://w3id.org/seo#hasProgramCommitteeMember</seealso>
    let hasProgramCommitteeMember =
        Prefixed_Name(w3seo, "hasProgramCommitteeMember") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#hasProgramSchedual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasProgramSchedual">https://w3id.org/seo#hasProgramSchedual</seealso>
    let hasProgramSchedual = Prefixed_Name(w3seo, "hasProgramSchedual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This propoerty shows the publisher of a proceedings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasPublisher">https://w3id.org/seo#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(w3seo, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasRegistration">https://w3id.org/seo#hasRegistration</seealso>
    let hasRegistration = Prefixed_Name(w3seo, "hasRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#hasRegistrationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasRegistrationType">https://w3id.org/seo#hasRegistrationType</seealso>
    let hasRegistrationType =
        Prefixed_Name(w3seo, "hasRegistrationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#hasSocialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasSocialEvent">https://w3id.org/seo#hasSocialEvent</seealso>
    let hasSocialEvent = Prefixed_Name(w3seo, "hasSocialEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasSponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This propoerty shows the sponsor of an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasSponsor">https://w3id.org/seo#hasSponsor</seealso>
    let hasSponsor = Prefixed_Name(w3seo, "hasSponsor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#hasSubmissionGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasSubmissionGuidelines">https://w3id.org/seo#hasSubmissionGuidelines</seealso>
    let hasSubmissionGuidelines =
        Prefixed_Name(w3seo, "hasSubmissionGuidelines") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#hasTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This propoerty shows the available tracks of an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasTrack">https://w3id.org/seo#hasTrack</seealso>
    let hasTrack = Prefixed_Name(w3seo, "hasTrack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#hasTwitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The twitter account of the event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#hasTwitter">https://w3id.org/seo#hasTwitter</seealso>
    let hasTwitter = Prefixed_Name(w3seo, "hasTwitter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#heldInCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#heldInCity">https://w3id.org/seo#heldInCity</seealso>
    let heldInCity = Prefixed_Name(w3seo, "heldInCity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#heldInCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#heldInCountry">https://w3id.org/seo#heldInCountry</seealso>
    let heldInCountry = Prefixed_Name(w3seo, "heldInCountry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#isPublisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#isPublisherOf">https://w3id.org/seo#isPublisherOf</seealso>
    let isPublisherOf = Prefixed_Name(w3seo, "isPublisherOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#isSponsorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#isSponsorOf">https://w3id.org/seo#isSponsorOf</seealso>
    let isSponsorOf = Prefixed_Name(w3seo, "isSponsorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#isTrackOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#isTrackOf">https://w3id.org/seo#isTrackOf</seealso>
    let isTrackOf = Prefixed_Name(w3seo, "isTrackOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#keynoteIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#keynoteIn">https://w3id.org/seo#keynoteIn</seealso>
    let keynoteIn = Prefixed_Name(w3seo, "keynoteIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#notificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of the paper acceptance notification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paper Acceptance Notification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/seo#notificationDate">https://w3id.org/seo#notificationDate</seealso>
    let notificationDate = Prefixed_Name(w3seo, "notificationDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#offersAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#offersAward">https://w3id.org/seo#offersAward</seealso>
    let offersAward = Prefixed_Name(w3seo, "offersAward") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#offersBestPaperAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#offersBestPaperAward">https://w3id.org/seo#offersBestPaperAward</seealso>
    let offersBestPaperAward =
        Prefixed_Name(w3seo, "offersBestPaperAward") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#participatesAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#participatesAs">https://w3id.org/seo#participatesAs</seealso>
    let participatesAs = Prefixed_Name(w3seo, "participatesAs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#participatesIn">https://w3id.org/seo#participatesIn</seealso>
    let participatesIn = Prefixed_Name(w3seo, "participatesIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#providesTravelInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#providesTravelInformation">https://w3id.org/seo#providesTravelInformation</seealso>
    let providesTravelInformation =
        Prefixed_Name(w3seo, "providesTravelInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:seo#registeredAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#registeredAs">https://w3id.org/seo#registeredAs</seealso>
    let registeredAs = Prefixed_Name(w3seo, "registeredAs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#sponsorshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#sponsorshipType">https://w3id.org/seo#sponsorshipType</seealso>
    let sponsorshipType = Prefixed_Name(w3seo, "sponsorshipType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#submissionDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The deadline of paper submission."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#submissionDeadline">https://w3id.org/seo#submissionDeadline</seealso>
    let submissionDeadline = Prefixed_Name(w3seo, "submissionDeadline") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#submissionWebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The webpage of the submission to event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#submissionWebPage">https://w3id.org/seo#submissionWebPage</seealso>
    let submissionWebPage = Prefixed_Name(w3seo, "submissionWebPage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#submittedPapers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of submitted papers to the event."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#submittedPapers">https://w3id.org/seo#submittedPapers</seealso>
    let submittedPapers = Prefixed_Name(w3seo, "submittedPapers") |> PrefixedName
    /// <summary>
    ///   <para>w3id:seo#takesAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seo#takesAward">https://w3id.org/seo#takesAward</seealso>
    let takesAward = Prefixed_Name(w3seo, "takesAward") |> PrefixedName
