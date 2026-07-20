namespace http.data.semanticweb.org.ns.swc.ontology.hash

open DoxAletheia

module swc =
    let _namespace_name = "http://data.semanticweb.org/ns/swc/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// 			&lt;!-- Creative Commons License --&gt;
    /// 			&lt;p class="copyright"&gt;
    /// 				Copyright &amp;copy; 2007-2009 Knud Möller, Sean Bechhofer and Tom Heath.&lt;br/&gt;
    /// 				&lt;br/&gt;
    /// 				&lt;a href="http://creativecommons.org/licenses/by/3.0/"&gt;&lt;img alt="Creative Commons License" style="border: 0; float: right; padding: 10px;" src="somerights.gif" /&gt;&lt;/a&gt;
    /// 				This work is licensed under a &lt;a href="http://creativecommons.org/licenses/by/3.0/"&gt;Creative Commons Attribution License&lt;/a&gt;.
    /// 				This copyright applies to the &lt;em&gt;Semantic Web Conference Ontology (SWC) Specification&lt;/em&gt; and accompanying documentation in RDF.
    /// 				Regarding underlying technology, SWC uses W3C's &lt;a href="http://www.w3.org/RDF/"&gt;RDF&lt;/a&gt; technology, an
    /// 				open Web standard that can be freely used by anyone.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#license_doc"></see></summary>
    let license_doc = _prefix "license_doc"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				The Semantic Web Conference ontology (SWC) is an ontology for describing academic conferences.
    /// 				It was initially designed to support the European Semantic Web Conference,
    /// 				ESWC2007, and later extended for both the following conferences in the ESWC series,
    /// 				as well as in the ISWC series.
    /// 				Historically, the SWC ontology also draws heavily on ontologies developed for
    /// 				ESWC2006 and ISWC2006.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				SWC is mainly a convention of how to use classes and properties from other ontologies, most prominently
    /// 				&lt;a href="http://xmlns.com/foaf/0.1"&gt;FOAF&lt;/a&gt; (for people) and &lt;a href="http://ontoware.org/projects/swrc/"&gt;SWRC&lt;/a&gt;
    /// 				(their BibTeX elements, for the papers). We are also throwing in some &lt;a href="http://sioc-project.org/"&gt;SIOC&lt;/a&gt;,
    /// 				&lt;a href="http://dublincore.org/documents/dc-rdf/index.shtml"&gt;Dublin Core&lt;/a&gt; and
    /// 				&lt;a href="http://www.w3.org/TR/rdfcal/"&gt;iCal/RDF Calendar&lt;/a&gt;. Our own
    /// 				&lt;a href="http://data.semanticweb.org/ns/swc/ontology"&gt;swc namespace&lt;/a&gt; provides the glue for all this, as well as
    /// 				specialised classes for things that have to do with conferences.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				This version of SWC has been slimmed down significantly (hence the revision name). A total of 59 classes and 19 properties have been deprecated (deprecated terms can be found at the bottom of this document). This was mostly done with the intention to remove the countless sub-classes of generic classes such as &lt;a href="#Chair"&gt;Chair&lt;/a&gt; or &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;, which were deemed to be too specific for a general-purpose conference ontology such as SWC. Elsewhere, classes and properties which had never been used and seemed to fall under the heading of "over-engineering" were removed. Finally, all CfP related terms were removed. Instead, we suggest to use a dedicated ontology such as the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#01_introduction"></see></summary>
    let _01_introduction = _prefix "01_introduction"
    /// <summary>
    ///
    /// 			&lt;p&gt;For the basic use case of describing papers, the figure below shows how the main kinds of resources are connected: the paper itself, the authors and their affiliations, and the talk where the paper was presented.
    /// 			&lt;/p&gt;
    /// 			&lt;div align="center"&gt;
    /// 				&lt;a href="documentation/20070921-ISWC+ASWC2007PublicationGraph.pdf"&gt;&lt;img src="documentation/20070921-ISWC+ASWC2007PublicationGraph.png" /&gt;&lt;/a&gt;
    /// 			&lt;/div&gt;
    /// 			&lt;p&gt;
    /// 				The next figure shows in more detail the kinds of things that can be said about each of the four main entities surrounding a paper.
    /// 			&lt;/p&gt;
    /// 			&lt;div align="center"&gt;
    /// 				&lt;a href="documentation/20071002-Properties.pdf"&gt;&lt;img src="documentation/20071002-Properties.png" /&gt;&lt;/a&gt;
    /// 			&lt;/div&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#02_describing_papers"></see></summary>
    let _02_describing_papers = _prefix "02_describing_papers"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				One of the basic design choices in SWC is to use role modelling for describing the different functions at a conference, such as chairs, reviewers, etc. For any particular role at a given conference, the &lt;code&gt;swc:Role&lt;/code&gt; class or a sub-class will be instantiated. This role instance stands in relation to a person (who plays the role) and an event. The figure below gives an example showing how to model the role of the metadata chair (or "dog food tsar") at ISWC+ASWC2007, which was held by Knud Möller (together with Tom Heath, not shown in the figure).
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				Note that the metadata chair role is not modelled with its own dedicated class (although it could have been). Instead, an instance of the generic &lt;a href="#Chair"&gt;Chair&lt;/a&gt; class is used and labelled accordingly.
    /// 			&lt;/p&gt;
    /// 			&lt;div align="center"&gt;
    /// 				&lt;a href="documentation/20090510-Roles_new.pdf"&gt;&lt;img src="documentation/20090510-Roles_new.png" /&gt;&lt;/a&gt;
    /// 			&lt;/div&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#03_roles"></see></summary>
    let _03_roles = _prefix "03_roles"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;Academic events are e.g. conferences and conference-like events, and all the sub-events of those which are about the topic or theme of the conference, such as talks or panels.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#AcademicEvent"></see></summary>
    let AcademicEvent = _prefix "AcademicEvent"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;An event in time and space which is planned and organised, as opposed to something which 'just happens', such as a car accident or sunset.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#OrganisedEvent"></see></summary>
    let OrganisedEvent = _prefix "OrganisedEvent"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A hotel, hostel, BnB or similar.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#AccommodationPlace"></see></summary>
    let AccommodationPlace = _prefix "AccommodationPlace"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#AdditionalReviewer"></see>
    /// </summary>
    let AdditionalReviewer = _prefix "AdditionalReviewer"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Role is the super-class of all the different roles performed at a conference or workshop. Examples are the various conference chairs, the delegates, presenters, PC members, etc. The intended use of this class is that an instance of Role will be related to the event at which it is performed, and to the person which performs it.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				Since the set of roles is slightly different for each event, and since it would therefore be impossible to provide sub-classes for all needs and circumstances, the SWC ontology only contains a very basic set of Role classes. Rather than diversifying the set of Role classes to cater for all needs, users should instead instantiate the small set of different Role classes and cover the roles at a specific event in this way. E.g., instead of sub-classing the Chair role with MainChair, WorkshopChair, TutorialChair, etc., the different kinds of chairs should simply be instances of the generic Chair class and be labelled appropriately.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#Administrator"></see>
    /// </summary>
    let Administrator = _prefix "Administrator"
    /// <summary>
    ///
    /// 			&lt;p&gt;An argumentative document is a document which uses analytical reasoning and evidence in order to argue for a point of view. Typical examples are scientific papers or political pamphlets. Negative examples are novels or plays (even though a novel might also try to sway the reader to a certain point of view).&lt;/p&gt;
    /// 			&lt;p&gt;According to &lt;a href="http://en.wikipedia.org/wiki/Text_types"&gt;Text Types&lt;/a&gt;, an argumentative document is based "on the evaluation and the subsequent subjective judgement in answer to a problem. It refers to the reasons advanced for or against a matter".&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ArgumentativeDocument"></see></summary>
    let ArgumentativeDocument = _prefix "ArgumentativeDocument"
    /// <summary>
    ///
    /// 			&lt;p&gt;&lt;emph&gt;Artefact&lt;/emph&gt; here means a document which can have a physical manifestation, like a paper or the proceedings of a conference.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Artefact"></see></summary>
    let Artefact = _prefix "Artefact"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				Any kind of break at the super-event, such as a coffee break.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#BreakEvent"></see></summary>
    let BreakEvent = _prefix "BreakEvent"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				In the context of SWC, a non-academic event is any kind or &lt;a href="#OrganisedEvent"&gt;organised event&lt;/a&gt; which does not concern the topic or theme of the conference as such. Examples are breaks, dinners, parties, etc.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#NonAcademicEvent"></see></summary>
    let NonAcademicEvent = _prefix "NonAcademicEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    /// 			&lt;p&gt;A &lt;emph&gt;call&lt;/emph&gt; is a public announcement, asking for contribution of some kind to events such as conferences or workshops, or to a publication such as a journal or book.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Call"></see></summary>
    let Call = _prefix "Call"
    /// <summary>
    ///
    /// 			&lt;p&gt;A call for demonstrations of software at a conference or workshop. Submissions are usually in the form of extended abstracts (~2 page) discussing the research questions addressed by the software and outlining the content of the demonstration.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CallForDemos"></see></summary>
    let CallForDemos = _prefix "CallForDemos"
    /// <summary>
    ///
    /// 			&lt;p&gt;A &lt;emph&gt;call for papers&lt;/emph&gt; or &lt;emph&gt;CfP&lt;/emph&gt; encourages authors to submit papers for peer-review for a conference or workshop, or a journal or book.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CallForPapers"></see></summary>
    let CallForPapers = _prefix "CallForPapers"
    /// <summary>
    ///
    /// 			&lt;p&gt;This kind of call usually calls for potential delegates to attend an event such as a conference or a workshop.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CallForParticipation"></see></summary>
    let CallForParticipation = _prefix "CallForParticipation"
    /// <summary>
    ///
    /// 			&lt;p&gt;A call for scientific posters at a conference or workshop. Submissions are usually in the form of extended abstracts (~2 page) discussing the research presented on the poster.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CallForPosters"></see></summary>
    let CallForPosters = _prefix "CallForPosters"
    /// <summary>
    ///
    /// 			&lt;p&gt;A call which asks for contributions in the form of e.g. workshop or tutorial proposals.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CallForProposals"></see></summary>
    let CallForProposals = _prefix "CallForProposals"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A sub-class of Role for various kinds of chair functions. Examples are the main chair of a conference, the tutorials chair, the proceedings chair, etc. Instead of introducing a large amount of sub-classes of Chair, we suggest to model all the different chair functions as instances of Chair with appropriate labels.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Chair"></see></summary>
    let Chair = _prefix "Chair"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#BreakEvent"&gt;BreakEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CoffeeBreak"></see></summary>
    let CoffeeBreak = _prefix "CoffeeBreak"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A location at the &lt;a href="#ConferenceVenuePlace"&gt;conference venue&lt;/a&gt; (or elsewhere), which is not a meeting room.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#CommunalPlace"></see></summary>
    let CommunalPlace = _prefix "CommunalPlace"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#ConferenceChair"></see>
    /// </summary>
    let ConferenceChair = _prefix "ConferenceChair"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ConferenceClosingEvent"></see></summary>
    let ConferenceClosingEvent = _prefix "ConferenceClosingEvent"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#SocialEvent"&gt;SocialEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ConferenceDinner"></see></summary>
    let ConferenceDinner = _prefix "ConferenceDinner"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A lunch, dinner or similar event at a conference or conference-like event.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#MealEvent"></see></summary>
    let MealEvent = _prefix "MealEvent"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				Examples for social events are parties or excursions.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#SocialEvent"></see></summary>
    let SocialEvent = _prefix "SocialEvent"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A scientific conference.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				TODO: Maybe this should be opened up - why only scientific conferences?
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ConferenceEvent"></see></summary>
    let ConferenceEvent = _prefix "ConferenceEvent"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ConferenceOpeningEvent"></see></summary>
    let ConferenceOpeningEvent = _prefix "ConferenceOpeningEvent"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				The location of a conference or conference-like event. Ideally, this would be more specific than just the city. Instead it should  be the hotel, convention centre, university or similar place where the event is held.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ConferenceVenuePlace"></see></summary>
    let ConferenceVenuePlace = _prefix "ConferenceVenuePlace"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A delegate is someone who attends a conference or conference-like event.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Delegate"></see></summary>
    let Delegate = _prefix "Delegate"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#DemoPresentation"></see></summary>
    let DemoPresentation = _prefix "DemoPresentation"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A speaker giving a talk. This could be the presentation of a paper, but also keynote speech or any other kind of talk.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#TalkEvent"></see></summary>
    let TalkEvent = _prefix "TalkEvent"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#DemoSession"></see></summary>
    let DemoSession = _prefix "DemoSession"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A session dedicated to a specific topic at a conference. This could be a session with talks, or also a poster session, a demo session, or any other kind of session.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#SessionEvent"></see></summary>
    let SessionEvent = _prefix "SessionEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#DemosChair"></see></summary>
    let DemosChair = _prefix "DemosChair"
    /// <summary>
    /// A role that is only relevant in relation to the topic of the conference e.g. Semantic
    /// 			Web Technologies Coordinator at a Semantic Web Conference.
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#DogfoodTsar"></see></summary>
    let DogfoodTsar = _prefix "DogfoodTsar"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated to reduce inflation of terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#DrinkingPlace"></see></summary>
    let DrinkingPlace = _prefix "DrinkingPlace"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				Deprecated: no real need to have an internal super-class for locations, we can just use the &lt;a href="&amp;geo;SpatialThing"&gt;SpatialThing&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated to reduce inflation of terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#EatingPlace"></see></summary>
    let EatingPlace = _prefix "EatingPlace"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#SocialEvent"&gt;SocialEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Excursion"></see></summary>
    let Excursion = _prefix "Excursion"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ExhibitionChair"></see></summary>
    let ExhibitionChair = _prefix "ExhibitionChair"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#BreakEvent"&gt;BreakEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#FreeTimeBreak"></see></summary>
    let FreeTimeBreak = _prefix "FreeTimeBreak"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#IndustrialTalk"></see></summary>
    let IndustrialTalk = _prefix "IndustrialTalk"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TrackEvent"&gt;TrackEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#IndustrialTrack"></see></summary>
    let IndustrialTrack = _prefix "IndustrialTrack"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A track groups all those sessions or events at a conference or workshop that belong to a common, overall theme. Depending on the conference, tracks can be quite generic, such as "Research" or "Industrial", but can also be more specific, such as "Semantic Web" or "Numismatics". SWC does not define any specific tracks, since conferences often differ so much with respect to how they structure their tracks, that it would be pointless to try and find a set of tracks that would suit all conferences.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;Sub-classes of TrackEvent which were defined in previous versions of the SWC ontology are now deprecated.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#TrackEvent"></see></summary>
    let TrackEvent = _prefix "TrackEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#IndustryChair"></see></summary>
    let IndustryChair = _prefix "IndustryChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;As opposed to a peer-reviewed paper. This class has been deprecated in order to reduce the inflation of classes.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#InvitedPaper"></see></summary>
    let InvitedPaper = _prefix "InvitedPaper"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#KeynoteTalk"></see></summary>
    let KeynoteTalk = _prefix "KeynoteTalk"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#LocalOrganiser"></see>
    /// </summary>
    let LocalOrganiser = _prefix "LocalOrganiser"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#BreakEvent"&gt;BreakEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#MealBreak"></see></summary>
    let MealBreak = _prefix "MealBreak"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A particular room at the &lt;a href="#ConferenceVenuePlace"&gt;conference venue&lt;/a&gt; (or elsewhere). E.g., the room where a particular &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt; takes place.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#MeetingRoomPlace"></see></summary>
    let MeetingRoomPlace = _prefix "MeetingRoomPlace"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#OrganisingCommitteeMember"></see>
    /// </summary>
    let OrganisingCommitteeMember = _prefix "OrganisingCommitteeMember"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;A panel discussion at a conference or conference-like event, usually involving several speakers.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PanelEvent"></see></summary>
    let PanelEvent = _prefix "PanelEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;A scientific/scholarly paper, e.g., an article in a scientific journal, or a paper at a conference or workshop. A paper could also be unpublished formally, as long as it has the form of a scientific paper (introduction, conclusion, related work, etc.).&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Paper"></see></summary>
    let Paper = _prefix "Paper"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PaperPresentation"></see></summary>
    let PaperPresentation = _prefix "PaperPresentation"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PaperSession"></see></summary>
    let PaperSession = _prefix "PaperSession"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PhDSymposiumChair"></see></summary>
    let PhDSymposiumChair = _prefix "PhDSymposiumChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;A scientific poster at a conference or workshop.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Poster"></see></summary>
    let Poster = _prefix "Poster"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PosterPresentation"></see></summary>
    let PosterPresentation = _prefix "PosterPresentation"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PosterSession"></see></summary>
    let PosterSession = _prefix "PosterSession"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#PostersChair"></see></summary>
    let PostersChair = _prefix "PostersChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A presenter is someone who presents matter in front of an audience. Examples of events to which this role applies are paper presentations, tutorials, or talks. A keynote speaker could also be modelled as an instance of this class.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Presenter"></see></summary>
    let Presenter = _prefix "Presenter"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#PrintedProceedingsChair"></see>
    /// </summary>
    let PrintedProceedingsChair = _prefix "PrintedProceedingsChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;The proceedings of a conference or workshop, which contain the papers presented there.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Proceedings"></see></summary>
    let Proceedings = _prefix "Proceedings"
    /// <summary>
    ///
    /// 			&lt;p&gt;A document containing the programme of an event such as a conference or workshop. Typically, the programme would list the times and dates for the individual sub-events, e.g., talks, dinners, panel discussions, etc.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Programme"></see></summary>
    let Programme = _prefix "Programme"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#ProgrammeChair"></see>
    /// </summary>
    let ProgrammeChair = _prefix "ProgrammeChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				This role is played by the members of the programme committee of a conference or conference-like event. We found this role to be so significant that it justifies to be represented by its own class.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ProgrammeCommitteeMember"></see></summary>
    let ProgrammeCommitteeMember = _prefix "ProgrammeCommitteeMember"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#PublicityChair"></see>
    /// </summary>
    let PublicityChair = _prefix "PublicityChair"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just use &lt;a href="#SocialEvent"&gt;SocialEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Reception"></see></summary>
    let Reception = _prefix "Reception"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TrackEvent"&gt;TrackEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#ResearchTrack"></see></summary>
    let ResearchTrack = _prefix "ResearchTrack"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#ProgrammeCommitteeMember"&gt;ProgrammeCommitteeMember&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Reviewer"></see></summary>
    let Reviewer = _prefix "Reviewer"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#SWChallengeChair"></see></summary>
    let SWChallengeChair = _prefix "SWChallengeChair"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#SessionChair"></see>
    /// </summary>
    let SessionChair = _prefix "SessionChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;A set of slides used for a presentation of e.g. a paper at a conference.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#SlideSet"></see></summary>
    let SlideSet = _prefix "SlideSet"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#Sponsorship"></see></summary>
    let Sponsorship = _prefix "Sponsorship"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#SponsorshipChair"></see>
    /// </summary>
    let SponsorshipChair = _prefix "SponsorshipChair"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#SubmissionsChair"></see>
    /// </summary>
    let SubmissionsChair = _prefix "SubmissionsChair"
    /// <summary>
    ///
    /// 			&lt;p&gt;A type of paper which accompanies the demonstration of software, also known as an extended abstract or demo description. This class has been deprecated in order to reduce the inflation of classes; it is too specific for CS conferences.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#SystemDemonstration"></see></summary>
    let SystemDemonstration = _prefix "SystemDemonstration"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A type of paper which is mainly describes the properties, implementation or architecture of an system (such as a software system).
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				Deprecating this: it's too specific for, not generic enough to apply for most conferences.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#SystemDescription"></see></summary>
    let SystemDescription = _prefix "SystemDescription"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				The chair of a particular track of a conference, responsible for all submissions and actions regarding this track.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#TrackChair"></see></summary>
    let TrackChair = _prefix "TrackChair"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#Treasurer"></see>
    /// </summary>
    let Treasurer = _prefix "Treasurer"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#Tutor"></see>
    /// </summary>
    let Tutor = _prefix "Tutor"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A tutorial is a special session at a conference or workshop, somewhat like a long lecture on a specific topic.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#TutorialEvent"></see></summary>
    let TutorialEvent = _prefix "TutorialEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#Presenter"&gt;Presenter&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#TutorialPresenter"></see></summary>
    let TutorialPresenter = _prefix "TutorialPresenter"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#TutorialsChair"></see>
    /// </summary>
    let TutorialsChair = _prefix "TutorialsChair"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#Webmaster"></see>
    /// </summary>
    let Webmaster = _prefix "Webmaster"
    /// <summary>
    ///
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#WelcomeTalk"></see></summary>
    let WelcomeTalk = _prefix "WelcomeTalk"
    /// <summary>
    ///
    ///
    /// 			&lt;p&gt;
    /// 				A scientific workshop. Workshops are often co-located with &lt;a href="#ConferenceEvent"&gt;ConferenceEvent&lt;/a&gt;s.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#WorkshopEvent"></see></summary>
    let WorkshopEvent = _prefix "WorkshopEvent"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#WorkshopOrganiser"></see>
    /// </summary>
    let WorkshopOrganiser = _prefix "WorkshopOrganiser"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#WorkshopsChair"></see>
    /// </summary>
    let WorkshopsChair = _prefix "WorkshopsChair"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#affiliation"></see>
    /// </summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    ///
    /// 			&lt;p&gt;Instead of this property, use the &lt;a href="#Delegate"&gt;Delegate&lt;/a&gt; role.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#attendeeAt"></see></summary>
    let attendeeAt = _prefix "attendeeAt"
    /// <summary>
    ///
    /// 			&lt;p&gt;Instead of this property, use the &lt;a href="#Delegate"&gt;Delegate&lt;/a&gt; role.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasAttendee"></see></summary>
    let hasAttendee = _prefix "hasAttendee"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#biblioReference"></see></summary>
    let biblioReference = _prefix "biblioReference"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#forEvent"></see></summary>
    let forEvent = _prefix "forEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasCall"></see></summary>
    let hasCall = _prefix "hasCall"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasCameraReadyDeadline"></see></summary>
    let hasCameraReadyDeadline = _prefix "hasCameraReadyDeadline"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasCostAmount"></see></summary>
    let hasCostAmount = _prefix "hasCostAmount"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasCostCurrency"></see></summary>
    let hasCostCurrency = _prefix "hasCostCurrency"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Relates an event such as a conference or any sub-event thereof to a location where it takes place.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasMenu"></see></summary>
    let hasMenu = _prefix "hasMenu"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasNotificationDeadline"></see></summary>
    let hasNotificationDeadline = _prefix "hasNotificationDeadline"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A generic property to model part-of relationships. In SWC this property is used to relate a &lt;a href="#Proceedings"&gt;proceedings document&lt;/a&gt; to the papers and articles contained in it.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Relates an event such as a conference to its &lt;a href="#Programme"&gt;Programme&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasProgramme"></see></summary>
    let hasProgramme = _prefix "hasProgramme"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Relates an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc. to a physical &lt;a href="#Artefact"&gt;artefact&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasRelatedArtefact"></see></summary>
    let hasRelatedArtefact = _prefix "hasRelatedArtefact"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Relates an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc. to a &lt;a href="#ArgumentativeDocument"&gt;document&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasRelatedDocument"></see></summary>
    let hasRelatedDocument = _prefix "hasRelatedDocument"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Relates a &lt;a href="#ArgumentativeDocument"&gt;document&lt;/a&gt; to an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#relatedToEvent"></see></summary>
    let relatedToEvent = _prefix "relatedToEvent"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates an event (e.g. a conference) to a role at the event (e.g. a conference chair).
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a role at an event (e.g. a conference chair) to the event (e.g. a conference).
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isRoleAt"></see></summary>
    let isRoleAt = _prefix "isRoleAt"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasSponsorship"></see></summary>
    let hasSponsorship = _prefix "hasSponsorship"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasSubmissionDeadline"></see></summary>
    let hasSubmissionDeadline = _prefix "hasSubmissionDeadline"
    /// <summary>
    ///
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasSubmissionInstructions"></see></summary>
    let hasSubmissionInstructions = _prefix "hasSubmissionInstructions"
    /// <summary>
    ///
    /// 			&lt;p&gt;Instead of this property, use &lt;a href="http://xmlns.com/foaf/0.1/topic"&gt;foaf:topic&lt;/a&gt;.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#hasTopic"></see></summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a role at an event (e.g. a conference chair) to the person who actually holds the role.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#heldBy"></see></summary>
    let heldBy = _prefix "heldBy"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a person to the role (e.g. a conference chair) it holds at an event.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#holdsRole"></see></summary>
    let holdsRole = _prefix "holdsRole"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				Relates a location to a conference or sub-event thereof which takes place at it.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isLocationFor"></see></summary>
    let isLocationFor = _prefix "isLocationFor"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A generic property to model part-of relationships. In SWC this property is used to relate papers or articles to the &lt;a href="#Proceedings"&gt;proceedings document&lt;/a&gt; in which they are contained.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isProvidedBy"></see></summary>
    let isProvidedBy = _prefix "isProvidedBy"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isProviderOf"></see></summary>
    let isProviderOf = _prefix "isProviderOf"
    /// <summary>
    /// Events can be sub-events of other events. E.g., a talk can be a sub-event of a session, which in turn can be a sub-event of a conference. The relation is transitive - the talk is also a sub-event of the conference.
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isSubEventOf"></see></summary>
    let isSubEventOf = _prefix "isSubEventOf"
    /// <summary>
    /// Events can be super-events of other events. E.g., a conference can be the super-event of a session, which in turn can be the super-event of a talk. The relation is transitive - the conference is also the super-event of the talk.
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isSuperEventOf"></see></summary>
    let isSuperEventOf = _prefix "isSuperEventOf"
    /// <summary>
    ///
    /// 			&lt;p&gt;Deprecated, instead using terms from FOAF.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#isTopicOf"></see></summary>
    let isTopicOf = _prefix "isTopicOf"
    /// <summary>
    ///
    /// 			&lt;p&gt;FOAF does not define an inverse of &lt;code&gt;foaf:member&lt;/code&gt;, so SWC does it.&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    ///
    /// 			&lt;p&gt;
    /// 				A person might plan to attend a talk or session at a conference or similar event. This property could be used to prepare a delegate's conference experience with respect to who they want to meet, etc.
    /// 			&lt;/p&gt;
    ///
    ///
    /// <see href="http://data.semanticweb.org/ns/swc/ontology#plansToAttend"></see></summary>
    let plansToAttend = _prefix "plansToAttend"
    /// <summary>
    ///   <see href="http://data.semanticweb.org/ns/swc/ontology#uuid"></see>
    /// </summary>
    let uuid = _prefix "uuid"
