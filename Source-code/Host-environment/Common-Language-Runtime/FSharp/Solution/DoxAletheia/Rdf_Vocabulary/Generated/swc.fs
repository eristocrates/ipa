namespace http.data.semanticweb.org.ns.swc.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swc =
    let _namespace_iri = Namespace_Iri swc |> NamespaceIRI
    /// <summary>
    ///   <para>swc:01_introduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>
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
    /// 		</para>
    /// labels<para>Introduction</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#01_introduction">http://data.semanticweb.org/ns/swc/ontology#01_introduction</seealso>
    let _01_introduction = Prefixed_Name(swc, "01_introduction") |> PrefixedName

    /// <summary>
    ///   <para>swc:ConferenceVenuePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				The location of a conference or conference-like event. Ideally, this would be more specific than just the city. Instead it should  be the hotel, convention centre, university or similar place where the event is held.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Conference Venue Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ConferenceVenuePlace">http://data.semanticweb.org/ns/swc/ontology#ConferenceVenuePlace</seealso>
    let ConferenceVenuePlace =
        Prefixed_Name(swc, "ConferenceVenuePlace") |> PrefixedName

    /// <summary>
    ///   <para>swc:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///
    /// labels<para>affiliation</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#affiliation">http://data.semanticweb.org/ns/swc/ontology#affiliation</seealso>
    let affiliation = Prefixed_Name(swc, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasAttendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Instead of this property, use the &lt;a href="#Delegate"&gt;Delegate&lt;/a&gt; role.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has attendee</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasAttendee">http://data.semanticweb.org/ns/swc/ontology#hasAttendee</seealso>
    let hasAttendee = Prefixed_Name(swc, "hasAttendee") |> PrefixedName
    /// <summary>
    ///   <para>swc:biblioReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>bibliographic reference</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#biblioReference">http://data.semanticweb.org/ns/swc/ontology#biblioReference</seealso>
    let biblioReference = Prefixed_Name(swc, "biblioReference") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasCall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has call</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasCall">http://data.semanticweb.org/ns/swc/ontology#hasCall</seealso>
    let hasCall = Prefixed_Name(swc, "hasCall") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasCameraReadyDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has camera-ready deadline</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasCameraReadyDeadline">http://data.semanticweb.org/ns/swc/ontology#hasCameraReadyDeadline</seealso>
    let hasCameraReadyDeadline =
        Prefixed_Name(swc, "hasCameraReadyDeadline") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasCostAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has cost amount</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasCostAmount">http://data.semanticweb.org/ns/swc/ontology#hasCostAmount</seealso>
    let hasCostAmount = Prefixed_Name(swc, "hasCostAmount") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Relates an event such as a conference or any sub-event thereof to a location where it takes place.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has location</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasLocation">http://data.semanticweb.org/ns/swc/ontology#hasLocation</seealso>
    let hasLocation = Prefixed_Name(swc, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A generic property to model part-of relationships. In SWC this property is used to relate a &lt;a href="#Proceedings"&gt;proceedings document&lt;/a&gt; to the papers and articles contained in it.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasPart">http://data.semanticweb.org/ns/swc/ontology#hasPart</seealso>
    let hasPart = Prefixed_Name(swc, "hasPart") |> PrefixedName

    /// <summary>
    ///   <para>swc:ConferenceClosingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Closing Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ConferenceClosingEvent">http://data.semanticweb.org/ns/swc/ontology#ConferenceClosingEvent</seealso>
    let ConferenceClosingEvent =
        Prefixed_Name(swc, "ConferenceClosingEvent") |> PrefixedName

    /// <summary>
    ///   <para>swc:SocialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				Examples for social events are parties or excursions.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Social Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SocialEvent">http://data.semanticweb.org/ns/swc/ontology#SocialEvent</seealso>
    let SocialEvent = Prefixed_Name(swc, "SocialEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:Delegate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A delegate is someone who attends a conference or conference-like event.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Delegate</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Delegate">http://data.semanticweb.org/ns/swc/ontology#Delegate</seealso>
    let Delegate = Prefixed_Name(swc, "Delegate") |> PrefixedName
    /// <summary>
    ///   <para>swc:TalkEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A speaker giving a talk. This could be the presentation of a paper, but also keynote speech or any other kind of talk.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Talk Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#TalkEvent">http://data.semanticweb.org/ns/swc/ontology#TalkEvent</seealso>
    let TalkEvent = Prefixed_Name(swc, "TalkEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:attendeeAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Instead of this property, use the &lt;a href="#Delegate"&gt;Delegate&lt;/a&gt; role.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>attendee at</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#attendeeAt">http://data.semanticweb.org/ns/swc/ontology#attendeeAt</seealso>
    let attendeeAt = Prefixed_Name(swc, "attendeeAt") |> PrefixedName
    /// <summary>
    ///   <para>swc:forEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>for event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#forEvent">http://data.semanticweb.org/ns/swc/ontology#forEvent</seealso>
    let forEvent = Prefixed_Name(swc, "forEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:03_roles</para>
    /// </summary>
    /// <remarks>
    ///   <para>
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
    /// 		</para>
    /// labels<para>Roles</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#03_roles">http://data.semanticweb.org/ns/swc/ontology#03_roles</seealso>
    let _03_roles = Prefixed_Name(swc, "03_roles") |> PrefixedName
    /// <summary>
    ///   <para>swc:Presenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A presenter is someone who presents matter in front of an audience. Examples of events to which this role applies are paper presentations, tutorials, or talks. A keynote speaker could also be modelled as an instance of this class.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Presenter</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Presenter">http://data.semanticweb.org/ns/swc/ontology#Presenter</seealso>
    let Presenter = Prefixed_Name(swc, "Presenter") |> PrefixedName

    /// <summary>
    ///   <para>swc:02_describing_papers</para>
    /// </summary>
    /// <remarks>
    ///   <para>
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
    /// 		</para>
    /// labels<para>Describing Papers</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#02_describing_papers">http://data.semanticweb.org/ns/swc/ontology#02_describing_papers</seealso>
    let _02_describing_papers =
        Prefixed_Name(swc, "02_describing_papers") |> PrefixedName

    /// <summary>
    ///   <para>swc:AcademicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;Academic events are e.g. conferences and conference-like events, and all the sub-events of those which are about the topic or theme of the conference, such as talks or panels.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Academic Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#AcademicEvent">http://data.semanticweb.org/ns/swc/ontology#AcademicEvent</seealso>
    let AcademicEvent = Prefixed_Name(swc, "AcademicEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:OrganisedEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;An event in time and space which is planned and organised, as opposed to something which 'just happens', such as a car accident or sunset.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Organised Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#OrganisedEvent">http://data.semanticweb.org/ns/swc/ontology#OrganisedEvent</seealso>
    let OrganisedEvent = Prefixed_Name(swc, "OrganisedEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:Administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Administrator</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Administrator">http://data.semanticweb.org/ns/swc/ontology#Administrator</seealso>
    let Administrator = Prefixed_Name(swc, "Administrator") |> PrefixedName
    /// <summary>
    ///   <para>swc:BreakEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				Any kind of break at the super-event, such as a coffee break.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Break Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#BreakEvent">http://data.semanticweb.org/ns/swc/ontology#BreakEvent</seealso>
    let BreakEvent = Prefixed_Name(swc, "BreakEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:AccommodationPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A hotel, hostel, BnB or similar.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Accommodation Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#AccommodationPlace">http://data.semanticweb.org/ns/swc/ontology#AccommodationPlace</seealso>
    let AccommodationPlace = Prefixed_Name(swc, "AccommodationPlace") |> PrefixedName
    /// <summary>
    ///   <para>swc:SWChallengeChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Semantic Web Challenge Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SWChallengeChair">http://data.semanticweb.org/ns/swc/ontology#SWChallengeChair</seealso>
    let SWChallengeChair = Prefixed_Name(swc, "SWChallengeChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:AdditionalReviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Additional Reviewer</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#AdditionalReviewer">http://data.semanticweb.org/ns/swc/ontology#AdditionalReviewer</seealso>
    let AdditionalReviewer = Prefixed_Name(swc, "AdditionalReviewer") |> PrefixedName
    /// <summary>
    ///   <para>swc:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Role is the super-class of all the different roles performed at a conference or workshop. Examples are the various conference chairs, the delegates, presenters, PC members, etc. The intended use of this class is that an instance of Role will be related to the event at which it is performed, and to the person which performs it.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				Since the set of roles is slightly different for each event, and since it would therefore be impossible to provide sub-classes for all needs and circumstances, the SWC ontology only contains a very basic set of Role classes. Rather than diversifying the set of Role classes to cater for all needs, users should instead instantiate the small set of different Role classes and cover the roles at a specific event in this way. E.g., instead of sub-classing the Chair role with MainChair, WorkshopChair, TutorialChair, etc., the different kinds of chairs should simply be instances of the generic Chair class and be labelled appropriately.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Role">http://data.semanticweb.org/ns/swc/ontology#Role</seealso>
    let Role = Prefixed_Name(swc, "Role") |> PrefixedName
    /// <summary>
    ///   <para>swc:Call</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    /// 			&lt;p&gt;A &lt;emph&gt;call&lt;/emph&gt; is a public announcement, asking for contribution of some kind to events such as conferences or workshops, or to a publication such as a journal or book.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Call</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Call">http://data.semanticweb.org/ns/swc/ontology#Call</seealso>
    let Call = Prefixed_Name(swc, "Call") |> PrefixedName
    /// <summary>
    ///   <para>swc:CallForDemos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;A call for demonstrations of software at a conference or workshop. Submissions are usually in the form of extended abstracts (~2 page) discussing the research questions addressed by the software and outlining the content of the demonstration.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Call for Demos</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CallForDemos">http://data.semanticweb.org/ns/swc/ontology#CallForDemos</seealso>
    let CallForDemos = Prefixed_Name(swc, "CallForDemos") |> PrefixedName

    /// <summary>
    ///   <para>swc:CallForParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;This kind of call usually calls for potential delegates to attend an event such as a conference or a workshop.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Call for Participation</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CallForParticipation">http://data.semanticweb.org/ns/swc/ontology#CallForParticipation</seealso>
    let CallForParticipation =
        Prefixed_Name(swc, "CallForParticipation") |> PrefixedName

    /// <summary>
    ///   <para>swc:CallForProposals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;A call which asks for contributions in the form of e.g. workshop or tutorial proposals.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Call for Proposals</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CallForProposals">http://data.semanticweb.org/ns/swc/ontology#CallForProposals</seealso>
    let CallForProposals = Prefixed_Name(swc, "CallForProposals") |> PrefixedName
    /// <summary>
    ///   <para>swc:CoffeeBreak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#BreakEvent"&gt;BreakEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Coffee Break</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CoffeeBreak">http://data.semanticweb.org/ns/swc/ontology#CoffeeBreak</seealso>
    let CoffeeBreak = Prefixed_Name(swc, "CoffeeBreak") |> PrefixedName
    /// <summary>
    ///   <para>swc:ConferenceChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Conference Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ConferenceChair">http://data.semanticweb.org/ns/swc/ontology#ConferenceChair</seealso>
    let ConferenceChair = Prefixed_Name(swc, "ConferenceChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:ConferenceDinner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#SocialEvent"&gt;SocialEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Conference Dinner</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ConferenceDinner">http://data.semanticweb.org/ns/swc/ontology#ConferenceDinner</seealso>
    let ConferenceDinner = Prefixed_Name(swc, "ConferenceDinner") |> PrefixedName
    /// <summary>
    ///   <para>swc:MealEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A lunch, dinner or similar event at a conference or conference-like event.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Meal Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#MealEvent">http://data.semanticweb.org/ns/swc/ontology#MealEvent</seealso>
    let MealEvent = Prefixed_Name(swc, "MealEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:ConferenceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A scientific conference.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				TODO: Maybe this should be opened up - why only scientific conferences?
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Conference Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ConferenceEvent">http://data.semanticweb.org/ns/swc/ontology#ConferenceEvent</seealso>
    let ConferenceEvent = Prefixed_Name(swc, "ConferenceEvent") |> PrefixedName

    /// <summary>
    ///   <para>swc:ConferenceOpeningEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Opening Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ConferenceOpeningEvent">http://data.semanticweb.org/ns/swc/ontology#ConferenceOpeningEvent</seealso>
    let ConferenceOpeningEvent =
        Prefixed_Name(swc, "ConferenceOpeningEvent") |> PrefixedName

    /// <summary>
    ///   <para>swc:DemoPresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Demo Presentation</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#DemoPresentation">http://data.semanticweb.org/ns/swc/ontology#DemoPresentation</seealso>
    let DemoPresentation = Prefixed_Name(swc, "DemoPresentation") |> PrefixedName
    /// <summary>
    ///   <para>swc:DemoSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Demo Session</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#DemoSession">http://data.semanticweb.org/ns/swc/ontology#DemoSession</seealso>
    let DemoSession = Prefixed_Name(swc, "DemoSession") |> PrefixedName
    /// <summary>
    ///   <para>swc:SessionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A session dedicated to a specific topic at a conference. This could be a session with talks, or also a poster session, a demo session, or any other kind of session.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Session Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SessionEvent">http://data.semanticweb.org/ns/swc/ontology#SessionEvent</seealso>
    let SessionEvent = Prefixed_Name(swc, "SessionEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:DogfoodTsar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>A role that is only relevant in relation to the topic of the conference e.g. Semantic
    /// 			Web Technologies Coordinator at a Semantic Web Conference.
    /// 		</para>
    /// labels<para>Dogfood Tsar</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#DogfoodTsar">http://data.semanticweb.org/ns/swc/ontology#DogfoodTsar</seealso>
    let DogfoodTsar = Prefixed_Name(swc, "DogfoodTsar") |> PrefixedName
    /// <summary>
    ///   <para>swc:DrinkingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated to reduce inflation of terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Drinking Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#DrinkingPlace">http://data.semanticweb.org/ns/swc/ontology#DrinkingPlace</seealso>
    let DrinkingPlace = Prefixed_Name(swc, "DrinkingPlace") |> PrefixedName
    /// <summary>
    ///   <para>swc:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				Deprecated: no real need to have an internal super-class for locations, we can just use the &lt;a href="&amp;geo;SpatialThing"&gt;SpatialThing&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Place">http://data.semanticweb.org/ns/swc/ontology#Place</seealso>
    let Place = Prefixed_Name(swc, "Place") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasCostCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has cost currency</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasCostCurrency">http://data.semanticweb.org/ns/swc/ontology#hasCostCurrency</seealso>
    let hasCostCurrency = Prefixed_Name(swc, "hasCostCurrency") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasMenu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has menu</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasMenu">http://data.semanticweb.org/ns/swc/ontology#hasMenu</seealso>
    let hasMenu = Prefixed_Name(swc, "hasMenu") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasNotificationDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has notification deadline</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasNotificationDeadline">http://data.semanticweb.org/ns/swc/ontology#hasNotificationDeadline</seealso>
    let hasNotificationDeadline =
        Prefixed_Name(swc, "hasNotificationDeadline") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Relates an event such as a conference to its &lt;a href="#Programme"&gt;Programme&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has programme</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasProgramme">http://data.semanticweb.org/ns/swc/ontology#hasProgramme</seealso>
    let hasProgramme = Prefixed_Name(swc, "hasProgramme") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasRelatedArtefact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Relates an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc. to a physical &lt;a href="#Artefact"&gt;artefact&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has related artefact</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasRelatedArtefact">http://data.semanticweb.org/ns/swc/ontology#hasRelatedArtefact</seealso>
    let hasRelatedArtefact = Prefixed_Name(swc, "hasRelatedArtefact") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasRelatedDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Relates an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc. to a &lt;a href="#ArgumentativeDocument"&gt;document&lt;/a&gt;.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has related document</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasRelatedDocument">http://data.semanticweb.org/ns/swc/ontology#hasRelatedDocument</seealso>
    let hasRelatedDocument = Prefixed_Name(swc, "hasRelatedDocument") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates an event (e.g. a conference) to a role at the event (e.g. a conference chair).
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has role</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasRole">http://data.semanticweb.org/ns/swc/ontology#hasRole</seealso>
    let hasRole = Prefixed_Name(swc, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>swc:isRoleAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a role at an event (e.g. a conference chair) to the event (e.g. a conference).
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>is role at</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isRoleAt">http://data.semanticweb.org/ns/swc/ontology#isRoleAt</seealso>
    let isRoleAt = Prefixed_Name(swc, "isRoleAt") |> PrefixedName
    /// <summary>
    ///   <para>swc:hasSponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has sponsorship</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasSponsorship">http://data.semanticweb.org/ns/swc/ontology#hasSponsorship</seealso>
    let hasSponsorship = Prefixed_Name(swc, "hasSponsorship") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasSubmissionDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has submission deadline</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasSubmissionDeadline">http://data.semanticweb.org/ns/swc/ontology#hasSubmissionDeadline</seealso>
    let hasSubmissionDeadline =
        Prefixed_Name(swc, "hasSubmissionDeadline") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Instead of this property, use &lt;a href="http://xmlns.com/foaf/0.1/topic"&gt;foaf:topic&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has topic</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasTopic">http://data.semanticweb.org/ns/swc/ontology#hasTopic</seealso>
    let hasTopic = Prefixed_Name(swc, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>swc:heldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a role at an event (e.g. a conference chair) to the person who actually holds the role.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>held by</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#heldBy">http://data.semanticweb.org/ns/swc/ontology#heldBy</seealso>
    let heldBy = Prefixed_Name(swc, "heldBy") |> PrefixedName
    /// <summary>
    ///   <para>swc:holdsRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Part of the &lt;a href="#Role"&gt;role&lt;/a&gt; modelling machinery of SWC. This property relates a person to the role (e.g. a conference chair) it holds at an event.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>holds role</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#holdsRole">http://data.semanticweb.org/ns/swc/ontology#holdsRole</seealso>
    let holdsRole = Prefixed_Name(swc, "holdsRole") |> PrefixedName

    /// <summary>
    ///   <para>swc:ArgumentativeDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;An argumentative document is a document which uses analytical reasoning and evidence in order to argue for a point of view. Typical examples are scientific papers or political pamphlets. Negative examples are novels or plays (even though a novel might also try to sway the reader to a certain point of view).&lt;/p&gt;
    /// 			&lt;p&gt;According to &lt;a href="http://en.wikipedia.org/wiki/Text_types"&gt;Text Types&lt;/a&gt;, an argumentative document is based "on the evaluation and the subsequent subjective judgement in answer to a problem. It refers to the reasons advanced for or against a matter".&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Argumentative Document</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ArgumentativeDocument">http://data.semanticweb.org/ns/swc/ontology#ArgumentativeDocument</seealso>
    let ArgumentativeDocument =
        Prefixed_Name(swc, "ArgumentativeDocument") |> PrefixedName

    /// <summary>
    ///   <para>swc:Artefact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;&lt;emph&gt;Artefact&lt;/emph&gt; here means a document which can have a physical manifestation, like a paper or the proceedings of a conference.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Artefact</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Artefact">http://data.semanticweb.org/ns/swc/ontology#Artefact</seealso>
    let Artefact = Prefixed_Name(swc, "Artefact") |> PrefixedName
    /// <summary>
    ///   <para>swc:SubmissionsChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Submissions Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SubmissionsChair">http://data.semanticweb.org/ns/swc/ontology#SubmissionsChair</seealso>
    let SubmissionsChair = Prefixed_Name(swc, "SubmissionsChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:SystemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A type of paper which is mainly describes the properties, implementation or architecture of an system (such as a software system).
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;
    /// 				Deprecating this: it's too specific for, not generic enough to apply for most conferences.
    ///
    /// 		</para>
    /// labels<para>System Description</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SystemDescription">http://data.semanticweb.org/ns/swc/ontology#SystemDescription</seealso>
    let SystemDescription = Prefixed_Name(swc, "SystemDescription") |> PrefixedName
    /// <summary>
    ///   <para>swc:Tutor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Tutor</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Tutor">http://data.semanticweb.org/ns/swc/ontology#Tutor</seealso>
    let Tutor = Prefixed_Name(swc, "Tutor") |> PrefixedName
    /// <summary>
    ///   <para>swc:TutorialsChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Tutorials Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#TutorialsChair">http://data.semanticweb.org/ns/swc/ontology#TutorialsChair</seealso>
    let TutorialsChair = Prefixed_Name(swc, "TutorialsChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:NonAcademicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				In the context of SWC, a non-academic event is any kind or &lt;a href="#OrganisedEvent"&gt;organised event&lt;/a&gt; which does not concern the topic or theme of the conference as such. Examples are breaks, dinners, parties, etc.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Non-academic Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#NonAcademicEvent">http://data.semanticweb.org/ns/swc/ontology#NonAcademicEvent</seealso>
    let NonAcademicEvent = Prefixed_Name(swc, "NonAcademicEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:CallForPapers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;A &lt;emph&gt;call for papers&lt;/emph&gt; or &lt;emph&gt;CfP&lt;/emph&gt; encourages authors to submit papers for peer-review for a conference or workshop, or a journal or book.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Call for Papers</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CallForPapers">http://data.semanticweb.org/ns/swc/ontology#CallForPapers</seealso>
    let CallForPapers = Prefixed_Name(swc, "CallForPapers") |> PrefixedName
    /// <summary>
    ///   <para>swc:CallForPosters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;A call for scientific posters at a conference or workshop. Submissions are usually in the form of extended abstracts (~2 page) discussing the research presented on the poster.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Call for Posters</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CallForPosters">http://data.semanticweb.org/ns/swc/ontology#CallForPosters</seealso>
    let CallForPosters = Prefixed_Name(swc, "CallForPosters") |> PrefixedName
    /// <summary>
    ///   <para>swc:Chair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A sub-class of Role for various kinds of chair functions. Examples are the main chair of a conference, the tutorials chair, the proceedings chair, etc. Instead of introducing a large amount of sub-classes of Chair, we suggest to model all the different chair functions as instances of Chair with appropriate labels.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Chair">http://data.semanticweb.org/ns/swc/ontology#Chair</seealso>
    let Chair = Prefixed_Name(swc, "Chair") |> PrefixedName
    /// <summary>
    ///   <para>swc:CommunalPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A location at the &lt;a href="#ConferenceVenuePlace"&gt;conference venue&lt;/a&gt; (or elsewhere), which is not a meeting room.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Communal Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#CommunalPlace">http://data.semanticweb.org/ns/swc/ontology#CommunalPlace</seealso>
    let CommunalPlace = Prefixed_Name(swc, "CommunalPlace") |> PrefixedName
    /// <summary>
    ///   <para>swc:Webmaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Webmaster</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Webmaster">http://data.semanticweb.org/ns/swc/ontology#Webmaster</seealso>
    let Webmaster = Prefixed_Name(swc, "Webmaster") |> PrefixedName
    /// <summary>
    ///   <para>swc:WorkshopOrganiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Workshop Organiser</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#WorkshopOrganiser">http://data.semanticweb.org/ns/swc/ontology#WorkshopOrganiser</seealso>
    let WorkshopOrganiser = Prefixed_Name(swc, "WorkshopOrganiser") |> PrefixedName
    /// <summary>
    ///   <para>swc:WorkshopsChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Workshops Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#WorkshopsChair">http://data.semanticweb.org/ns/swc/ontology#WorkshopsChair</seealso>
    let WorkshopsChair = Prefixed_Name(swc, "WorkshopsChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:DemosChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Demos Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#DemosChair">http://data.semanticweb.org/ns/swc/ontology#DemosChair</seealso>
    let DemosChair = Prefixed_Name(swc, "DemosChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:EatingPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated to reduce inflation of terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Eating Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#EatingPlace">http://data.semanticweb.org/ns/swc/ontology#EatingPlace</seealso>
    let EatingPlace = Prefixed_Name(swc, "EatingPlace") |> PrefixedName
    /// <summary>
    ///   <para>swc:FreeTimeBreak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#BreakEvent"&gt;BreakEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Free Time Break</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#FreeTimeBreak">http://data.semanticweb.org/ns/swc/ontology#FreeTimeBreak</seealso>
    let FreeTimeBreak = Prefixed_Name(swc, "FreeTimeBreak") |> PrefixedName
    /// <summary>
    ///   <para>swc:IndustrialTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TrackEvent"&gt;TrackEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Industrial Track</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#IndustrialTrack">http://data.semanticweb.org/ns/swc/ontology#IndustrialTrack</seealso>
    let IndustrialTrack = Prefixed_Name(swc, "IndustrialTrack") |> PrefixedName
    /// <summary>
    ///   <para>swc:IndustryChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Industry Chair or In-Use Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#IndustryChair">http://data.semanticweb.org/ns/swc/ontology#IndustryChair</seealso>
    let IndustryChair = Prefixed_Name(swc, "IndustryChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;FOAF does not define an inverse of &lt;code&gt;foaf:member&lt;/code&gt;, so SWC does it.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>member of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#memberOf">http://data.semanticweb.org/ns/swc/ontology#memberOf</seealso>
    let memberOf = Prefixed_Name(swc, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>swc:uuid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///
    /// labels<para>uuid</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#uuid">http://data.semanticweb.org/ns/swc/ontology#uuid</seealso>
    let uuid = Prefixed_Name(swc, "uuid") |> PrefixedName
    /// <summary>
    ///   <para>swc:Excursion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#SocialEvent"&gt;SocialEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Excursion</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Excursion">http://data.semanticweb.org/ns/swc/ontology#Excursion</seealso>
    let Excursion = Prefixed_Name(swc, "Excursion") |> PrefixedName
    /// <summary>
    ///   <para>swc:IndustrialTalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Industrial Talk</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#IndustrialTalk">http://data.semanticweb.org/ns/swc/ontology#IndustrialTalk</seealso>
    let IndustrialTalk = Prefixed_Name(swc, "IndustrialTalk") |> PrefixedName

    /// <summary>
    ///   <para>swc:hasSubmissionInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;The call classes have been deprecated in SWC. Instead, we suggest to use the &lt;a href="http://sw.deri.org/2005/08/conf/cfp"&gt;CfP ontology&lt;/a&gt;.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>has submission instructions</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#hasSubmissionInstructions">http://data.semanticweb.org/ns/swc/ontology#hasSubmissionInstructions</seealso>
    let hasSubmissionInstructions =
        Prefixed_Name(swc, "hasSubmissionInstructions") |> PrefixedName

    /// <summary>
    ///   <para>swc:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A generic property to model part-of relationships. In SWC this property is used to relate papers or articles to the &lt;a href="#Proceedings"&gt;proceedings document&lt;/a&gt; in which they are contained.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>is part of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isPartOf">http://data.semanticweb.org/ns/swc/ontology#isPartOf</seealso>
    let isPartOf = Prefixed_Name(swc, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>swc:isProviderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>is provider of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isProviderOf">http://data.semanticweb.org/ns/swc/ontology#isProviderOf</seealso>
    let isProviderOf = Prefixed_Name(swc, "isProviderOf") |> PrefixedName
    /// <summary>
    ///   <para>swc:isSuperEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Events can be super-events of other events. E.g., a conference can be the super-event of a session, which in turn can be the super-event of a talk. The relation is transitive - the conference is also the super-event of the talk.</para>
    /// labels<para>is the super-event of</para><para>is super-event of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isSuperEventOf">http://data.semanticweb.org/ns/swc/ontology#isSuperEventOf</seealso>
    let isSuperEventOf = Prefixed_Name(swc, "isSuperEventOf") |> PrefixedName
    /// <summary>
    ///   <para>swc:ExhibitionChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Exhibition Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ExhibitionChair">http://data.semanticweb.org/ns/swc/ontology#ExhibitionChair</seealso>
    let ExhibitionChair = Prefixed_Name(swc, "ExhibitionChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:TrackEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A track groups all those sessions or events at a conference or workshop that belong to a common, overall theme. Depending on the conference, tracks can be quite generic, such as "Research" or "Industrial", but can also be more specific, such as "Semantic Web" or "Numismatics". SWC does not define any specific tracks, since conferences often differ so much with respect to how they structure their tracks, that it would be pointless to try and find a set of tracks that would suit all conferences.
    /// 			&lt;/p&gt;
    /// 			&lt;p&gt;Sub-classes of TrackEvent which were defined in previous versions of the SWC ontology are now deprecated.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Track Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#TrackEvent">http://data.semanticweb.org/ns/swc/ontology#TrackEvent</seealso>
    let TrackEvent = Prefixed_Name(swc, "TrackEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:KeynoteTalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Keynote Talk</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#KeynoteTalk">http://data.semanticweb.org/ns/swc/ontology#KeynoteTalk</seealso>
    let KeynoteTalk = Prefixed_Name(swc, "KeynoteTalk") |> PrefixedName
    /// <summary>
    ///   <para>swc:relatedToEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Relates a &lt;a href="#ArgumentativeDocument"&gt;document&lt;/a&gt; to an &lt;a href="#AcademicEvent"&gt;event&lt;/a&gt; such as a conference, workshop, etc.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>related to event</para><para>related to Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#relatedToEvent">http://data.semanticweb.org/ns/swc/ontology#relatedToEvent</seealso>
    let relatedToEvent = Prefixed_Name(swc, "relatedToEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:isLocationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Relates a location to a conference or sub-event thereof which takes place at it.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>is location of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isLocationFor">http://data.semanticweb.org/ns/swc/ontology#isLocationFor</seealso>
    let isLocationFor = Prefixed_Name(swc, "isLocationFor") |> PrefixedName
    /// <summary>
    ///   <para>swc:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>is provided by</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isProvidedBy">http://data.semanticweb.org/ns/swc/ontology#isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(swc, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>swc:isSubEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Events can be sub-events of other events. E.g., a talk can be a sub-event of a session, which in turn can be a sub-event of a conference. The relation is transitive - the talk is also a sub-event of the conference.</para>
    /// labels<para>is a sub-event of</para><para>is sub-event of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isSubEventOf">http://data.semanticweb.org/ns/swc/ontology#isSubEventOf</seealso>
    let isSubEventOf = Prefixed_Name(swc, "isSubEventOf") |> PrefixedName
    /// <summary>
    ///   <para>swc:isTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated, instead using terms from FOAF.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>is topic of</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#isTopicOf">http://data.semanticweb.org/ns/swc/ontology#isTopicOf</seealso>
    let isTopicOf = Prefixed_Name(swc, "isTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>swc:plansToAttend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				A person might plan to attend a talk or session at a conference or similar event. This property could be used to prepare a delegate's conference experience with respect to who they want to meet, etc.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>plans to attend</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#plansToAttend">http://data.semanticweb.org/ns/swc/ontology#plansToAttend</seealso>
    let plansToAttend = Prefixed_Name(swc, "plansToAttend") |> PrefixedName
    /// <summary>
    ///   <para>swc:InvitedPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;As opposed to a peer-reviewed paper. This class has been deprecated in order to reduce the inflation of classes.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Invited Paper</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#InvitedPaper">http://data.semanticweb.org/ns/swc/ontology#InvitedPaper</seealso>
    let InvitedPaper = Prefixed_Name(swc, "InvitedPaper") |> PrefixedName
    /// <summary>
    ///   <para>swc:MealBreak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#BreakEvent"&gt;BreakEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Meal Break</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#MealBreak">http://data.semanticweb.org/ns/swc/ontology#MealBreak</seealso>
    let MealBreak = Prefixed_Name(swc, "MealBreak") |> PrefixedName
    /// <summary>
    ///   <para>swc:MeetingRoomPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A particular room at the &lt;a href="#ConferenceVenuePlace"&gt;conference venue&lt;/a&gt; (or elsewhere). E.g., the room where a particular &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt; takes place.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Meeting Room Place</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#MeetingRoomPlace">http://data.semanticweb.org/ns/swc/ontology#MeetingRoomPlace</seealso>
    let MeetingRoomPlace = Prefixed_Name(swc, "MeetingRoomPlace") |> PrefixedName
    /// <summary>
    ///   <para>swc:LocalOrganiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Local Organiser</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#LocalOrganiser">http://data.semanticweb.org/ns/swc/ontology#LocalOrganiser</seealso>
    let LocalOrganiser = Prefixed_Name(swc, "LocalOrganiser") |> PrefixedName

    /// <summary>
    ///   <para>swc:OrganisingCommitteeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Organising Committee Member</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#OrganisingCommitteeMember">http://data.semanticweb.org/ns/swc/ontology#OrganisingCommitteeMember</seealso>
    let OrganisingCommitteeMember =
        Prefixed_Name(swc, "OrganisingCommitteeMember") |> PrefixedName

    /// <summary>
    ///   <para>swc:PanelEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;A panel discussion at a conference or conference-like event, usually involving several speakers.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Panel Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PanelEvent">http://data.semanticweb.org/ns/swc/ontology#PanelEvent</seealso>
    let PanelEvent = Prefixed_Name(swc, "PanelEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:PaperPresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Paper Presentation</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PaperPresentation">http://data.semanticweb.org/ns/swc/ontology#PaperPresentation</seealso>
    let PaperPresentation = Prefixed_Name(swc, "PaperPresentation") |> PrefixedName
    /// <summary>
    ///   <para>swc:Poster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;A scientific poster at a conference or workshop.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Poster</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Poster">http://data.semanticweb.org/ns/swc/ontology#Poster</seealso>
    let Poster = Prefixed_Name(swc, "Poster") |> PrefixedName
    /// <summary>
    ///   <para>swc:PosterPresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Poster Presentation</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PosterPresentation">http://data.semanticweb.org/ns/swc/ontology#PosterPresentation</seealso>
    let PosterPresentation = Prefixed_Name(swc, "PosterPresentation") |> PrefixedName
    /// <summary>
    ///   <para>swc:PostersChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Posters Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PostersChair">http://data.semanticweb.org/ns/swc/ontology#PostersChair</seealso>
    let PostersChair = Prefixed_Name(swc, "PostersChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:Paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;A scientific/scholarly paper, e.g., an article in a scientific journal, or a paper at a conference or workshop. A paper could also be unpublished formally, as long as it has the form of a scientific paper (introduction, conclusion, related work, etc.).&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Paper</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Paper">http://data.semanticweb.org/ns/swc/ontology#Paper</seealso>
    let Paper = Prefixed_Name(swc, "Paper") |> PrefixedName
    /// <summary>
    ///   <para>swc:PhDSymposiumChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#TrackChair"&gt;TrackChair&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>PhD Symposium or Doctoral Consortium Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PhDSymposiumChair">http://data.semanticweb.org/ns/swc/ontology#PhDSymposiumChair</seealso>
    let PhDSymposiumChair = Prefixed_Name(swc, "PhDSymposiumChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:PaperSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Paper Session</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PaperSession">http://data.semanticweb.org/ns/swc/ontology#PaperSession</seealso>
    let PaperSession = Prefixed_Name(swc, "PaperSession") |> PrefixedName
    /// <summary>
    ///   <para>swc:PosterSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#SessionEvent"&gt;SessionEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Poster Session</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PosterSession">http://data.semanticweb.org/ns/swc/ontology#PosterSession</seealso>
    let PosterSession = Prefixed_Name(swc, "PosterSession") |> PrefixedName

    /// <summary>
    ///   <para>swc:PrintedProceedingsChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>(Printed) Proceedings Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PrintedProceedingsChair">http://data.semanticweb.org/ns/swc/ontology#PrintedProceedingsChair</seealso>
    let PrintedProceedingsChair =
        Prefixed_Name(swc, "PrintedProceedingsChair") |> PrefixedName

    /// <summary>
    ///   <para>swc:Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;The proceedings of a conference or workshop, which contain the papers presented there.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Proceedings</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Proceedings">http://data.semanticweb.org/ns/swc/ontology#Proceedings</seealso>
    let Proceedings = Prefixed_Name(swc, "Proceedings") |> PrefixedName
    /// <summary>
    ///   <para>swc:ProgrammeChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Programme Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ProgrammeChair">http://data.semanticweb.org/ns/swc/ontology#ProgrammeChair</seealso>
    let ProgrammeChair = Prefixed_Name(swc, "ProgrammeChair") |> PrefixedName

    /// <summary>
    ///   <para>swc:ProgrammeCommitteeMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				This role is played by the members of the programme committee of a conference or conference-like event. We found this role to be so significant that it justifies to be represented by its own class.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Programme Committee Member</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ProgrammeCommitteeMember">http://data.semanticweb.org/ns/swc/ontology#ProgrammeCommitteeMember</seealso>
    let ProgrammeCommitteeMember =
        Prefixed_Name(swc, "ProgrammeCommitteeMember") |> PrefixedName

    /// <summary>
    ///   <para>swc:PublicityChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Publicity Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#PublicityChair">http://data.semanticweb.org/ns/swc/ontology#PublicityChair</seealso>
    let PublicityChair = Prefixed_Name(swc, "PublicityChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:Reception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just use &lt;a href="#SocialEvent"&gt;SocialEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Reception</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Reception">http://data.semanticweb.org/ns/swc/ontology#Reception</seealso>
    let Reception = Prefixed_Name(swc, "Reception") |> PrefixedName
    /// <summary>
    ///   <para>swc:Reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#ProgrammeCommitteeMember"&gt;ProgrammeCommitteeMember&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Reviewer</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Reviewer">http://data.semanticweb.org/ns/swc/ontology#Reviewer</seealso>
    let Reviewer = Prefixed_Name(swc, "Reviewer") |> PrefixedName
    /// <summary>
    ///   <para>swc:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;A document containing the programme of an event such as a conference or workshop. Typically, the programme would list the times and dates for the individual sub-events, e.g., talks, dinners, panel discussions, etc.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Programme</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Programme">http://data.semanticweb.org/ns/swc/ontology#Programme</seealso>
    let Programme = Prefixed_Name(swc, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>swc:ResearchTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TrackEvent"&gt;TrackEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Research Track</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#ResearchTrack">http://data.semanticweb.org/ns/swc/ontology#ResearchTrack</seealso>
    let ResearchTrack = Prefixed_Name(swc, "ResearchTrack") |> PrefixedName
    /// <summary>
    ///   <para>swc:SessionChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Session Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SessionChair">http://data.semanticweb.org/ns/swc/ontology#SessionChair</seealso>
    let SessionChair = Prefixed_Name(swc, "SessionChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:SlideSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			&lt;p&gt;A set of slides used for a presentation of e.g. a paper at a conference.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Slide Set</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SlideSet">http://data.semanticweb.org/ns/swc/ontology#SlideSet</seealso>
    let SlideSet = Prefixed_Name(swc, "SlideSet") |> PrefixedName
    /// <summary>
    ///   <para>swc:Sponsorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;Deprecated because it has never been used and in order to reduce the inflation of ontology terms.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Sponsorship</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Sponsorship">http://data.semanticweb.org/ns/swc/ontology#Sponsorship</seealso>
    let Sponsorship = Prefixed_Name(swc, "Sponsorship") |> PrefixedName
    /// <summary>
    ///   <para>swc:SponsorshipChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Sponsorship Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SponsorshipChair">http://data.semanticweb.org/ns/swc/ontology#SponsorshipChair</seealso>
    let SponsorshipChair = Prefixed_Name(swc, "SponsorshipChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:SystemDemonstration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;A type of paper which accompanies the demonstration of software, also known as an extended abstract or demo description. This class has been deprecated in order to reduce the inflation of classes; it is too specific for CS conferences.&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>System Demonstration</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#SystemDemonstration">http://data.semanticweb.org/ns/swc/ontology#SystemDemonstration</seealso>
    let SystemDemonstration = Prefixed_Name(swc, "SystemDemonstration") |> PrefixedName
    /// <summary>
    ///   <para>swc:TrackChair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				The chair of a particular track of a conference, responsible for all submissions and actions regarding this track.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Track Chair</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#TrackChair">http://data.semanticweb.org/ns/swc/ontology#TrackChair</seealso>
    let TrackChair = Prefixed_Name(swc, "TrackChair") |> PrefixedName
    /// <summary>
    ///   <para>swc:Treasurer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Treasurer</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#Treasurer">http://data.semanticweb.org/ns/swc/ontology#Treasurer</seealso>
    let Treasurer = Prefixed_Name(swc, "Treasurer") |> PrefixedName
    /// <summary>
    ///   <para>swc:TutorialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A tutorial is a special session at a conference or workshop, somewhat like a long lecture on a specific topic.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Tutorial Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#TutorialEvent">http://data.semanticweb.org/ns/swc/ontology#TutorialEvent</seealso>
    let TutorialEvent = Prefixed_Name(swc, "TutorialEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:TutorialPresenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    /// 			&lt;p&gt;
    /// 				Deprecating this, just use &lt;a href="#Presenter"&gt;Presenter&lt;/a&gt; instead.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Tutorial Presenter</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#TutorialPresenter">http://data.semanticweb.org/ns/swc/ontology#TutorialPresenter</seealso>
    let TutorialPresenter = Prefixed_Name(swc, "TutorialPresenter") |> PrefixedName
    /// <summary>
    ///   <para>swc:WelcomeTalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>
    ///
    /// 			Deprecating this - we can just as well use &lt;a href="#TalkEvent"&gt;TalkEvent&lt;/a&gt;.
    ///
    /// 		</para>
    /// labels<para>Welcome Talk</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#WelcomeTalk">http://data.semanticweb.org/ns/swc/ontology#WelcomeTalk</seealso>
    let WelcomeTalk = Prefixed_Name(swc, "WelcomeTalk") |> PrefixedName
    /// <summary>
    ///   <para>swc:WorkshopEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// 			&lt;p&gt;
    /// 				A scientific workshop. Workshops are often co-located with &lt;a href="#ConferenceEvent"&gt;ConferenceEvent&lt;/a&gt;s.
    /// 			&lt;/p&gt;
    ///
    /// 		</para>
    /// labels<para>Workshop Event</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#WorkshopEvent">http://data.semanticweb.org/ns/swc/ontology#WorkshopEvent</seealso>
    let WorkshopEvent = Prefixed_Name(swc, "WorkshopEvent") |> PrefixedName
    /// <summary>
    ///   <para>swc:license_doc</para>
    /// </summary>
    /// <remarks>
    ///   <para>
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
    /// 		</para>
    /// labels<para>License Statement</para></remarks>
    /// <seealso href="http://data.semanticweb.org/ns/swc/ontology#license_doc">http://data.semanticweb.org/ns/swc/ontology#license_doc</seealso>
    let license_doc = Prefixed_Name(swc, "license_doc") |> PrefixedName
