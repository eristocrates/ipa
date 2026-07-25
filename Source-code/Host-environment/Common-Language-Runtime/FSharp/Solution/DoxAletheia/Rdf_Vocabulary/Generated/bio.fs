namespace http.purl.org.vocab.bio._0._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bio =
    let _namespace_iri = Namespace_Iri bio |> NamespaceIRI
    /// <summary>
    ///   <para>bio:termgroup3</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///
    /// labels<para>Properties of an event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/termgroup3">http://purl.org/vocab/bio/0.1/termgroup3</seealso>
    let termgroup3 = Prefixed_Name(bio, "termgroup3") |> PrefixedName
    /// <summary>
    ///   <para>bio:principal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person that takes the primary and most important role in an event. For example the principal in a Birth event would be the child being born and the principal in a Burial event would be the deceased person.</para>
    /// labels<para>Principal</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/principal">http://purl.org/vocab/bio/0.1/principal</seealso>
    let principal = Prefixed_Name(bio, "principal") |> PrefixedName
    /// <summary>
    ///   <para>bio:Investiture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event of a person taking a public office or honour.</para>
    /// labels<para>Investiture</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Investiture">http://purl.org/vocab/bio/0.1/Investiture</seealso>
    let Investiture = Prefixed_Name(bio, "Investiture") |> PrefixedName
    /// <summary>
    ///   <para>bio:Marriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of creating uniting the participants into a new family unit, sometimes accompanied by a formal wedding ceremony. This is intended to cover a broad range of marriages including those given formal legal standing, common-law, or by convention. It is not restricted to marriages of two people of the opposite gender, but also includes polygamous and same-sex unions.</para>
    /// labels<para>Marriage</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Marriage">http://purl.org/vocab/bio/0.1/Marriage</seealso>
    let Marriage = Prefixed_Name(bio, "Marriage") |> PrefixedName
    /// <summary>
    ///   <para>bio:NameChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person changing their name.</para>
    /// labels<para>Change of Name</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/NameChange">http://purl.org/vocab/bio/0.1/NameChange</seealso>
    let NameChange = Prefixed_Name(bio, "NameChange") |> PrefixedName
    /// <summary>
    ///   <para>bio:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/">http://purl.org/vocab/bio/0.1/</seealso>
    let _prefix_iri = Prefixed_Name(bio, "") |> PrefixedName
    /// <summary>
    ///   <para>bio:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An event associated with a person, group or organization.</para>
    /// labels<para>Life Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/event">http://purl.org/vocab/bio/0.1/event</seealso>
    let event_ = Prefixed_Name(bio, "event") |> PrefixedName
    /// <summary>
    ///   <para>bio:GroupEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of event that is principally about one or more agents and their partnership. Other agents may be involved but the event is most significant for the partner agent.</para>
    /// labels<para>Group Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/GroupEvent">http://purl.org/vocab/bio/0.1/GroupEvent</seealso>
    let GroupEvent = Prefixed_Name(bio, "GroupEvent") |> PrefixedName
    /// <summary>
    ///   <para>bio:Emigration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person leaving their homeland with the intent of residing elsewhere.</para>
    /// labels<para>Emigration</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Emigration">http://purl.org/vocab/bio/0.1/Emigration</seealso>
    let Emigration = Prefixed_Name(bio, "Emigration") |> PrefixedName
    /// <summary>
    ///   <para>bio:Employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person entering an occupational relationship with an employer.</para>
    /// labels<para>Employment</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Employment">http://purl.org/vocab/bio/0.1/Employment</seealso>
    let Employment = Prefixed_Name(bio, "Employment") |> PrefixedName
    /// <summary>
    ///   <para>bio:Execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person being deliberately killed as punishment.</para>
    /// labels<para>Execution</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Execution">http://purl.org/vocab/bio/0.1/Execution</seealso>
    let Execution = Prefixed_Name(bio, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>bio:Formation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a group or organization coming into being.</para>
    /// labels<para>Formation</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Formation">http://purl.org/vocab/bio/0.1/Formation</seealso>
    let Formation = Prefixed_Name(bio, "Formation") |> PrefixedName
    /// <summary>
    ///   <para>bio:Graduation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person being awarded educational diplomas or degrees.</para>
    /// labels<para>Graduation</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Graduation">http://purl.org/vocab/bio/0.1/Graduation</seealso>
    let Graduation = Prefixed_Name(bio, "Graduation") |> PrefixedName
    /// <summary>
    ///   <para>bio:partner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person that is involved in a event as a partner in a relationship.</para>
    /// labels<para>Partner</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/partner">http://purl.org/vocab/bio/0.1/partner</seealso>
    let partner = Prefixed_Name(bio, "partner") |> PrefixedName
    /// <summary>
    ///   <para>bio:Imprisonment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person being detained in a jail or prison.</para>
    /// labels<para>Imprisonment</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Imprisonment">http://purl.org/vocab/bio/0.1/Imprisonment</seealso>
    let Imprisonment = Prefixed_Name(bio, "Imprisonment") |> PrefixedName
    /// <summary>
    ///   <para>bio:Inauguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event marking the beginning of a person's term of office as a leader.</para>
    /// labels<para>Inauguration</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Inauguration">http://purl.org/vocab/bio/0.1/Inauguration</seealso>
    let Inauguration = Prefixed_Name(bio, "Inauguration") |> PrefixedName
    /// <summary>
    ///   <para>bio:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A extended interval of time related to a particular state of affairs, such as the lifespan of a person or a period of employment.</para>
    /// labels<para>Interval</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Interval">http://purl.org/vocab/bio/0.1/Interval</seealso>
    let Interval = Prefixed_Name(bio, "Interval") |> PrefixedName
    /// <summary>
    ///   <para>bio:Funeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of marking a person's death with a ceremony.</para>
    /// labels<para>Funeral</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Funeral">http://purl.org/vocab/bio/0.1/Funeral</seealso>
    let Funeral = Prefixed_Name(bio, "Funeral") |> PrefixedName
    /// <summary>
    ///   <para>bio:Accession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person succeeding to the right to hold regal power. This event is often automatic on the death of the previous monarch and is usually followed by a coronation event.</para>
    /// labels<para>Accession</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Accession">http://purl.org/vocab/bio/0.1/Accession</seealso>
    let Accession = Prefixed_Name(bio, "Accession") |> PrefixedName
    /// <summary>
    ///   <para>bio:IndividualEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of event that is principally about a single person, group or organization. Other agents may be involved but the event is most significant for the principal agent.</para>
    /// labels<para>Individual Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/IndividualEvent">http://purl.org/vocab/bio/0.1/IndividualEvent</seealso>
    let IndividualEvent = Prefixed_Name(bio, "IndividualEvent") |> PrefixedName
    /// <summary>
    ///   <para>bio:Adoption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of creating of a legal parent/child relationship that does not exist biologically.</para>
    /// labels<para>Adoption</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Adoption">http://purl.org/vocab/bio/0.1/Adoption</seealso>
    let Adoption = Prefixed_Name(bio, "Adoption") |> PrefixedName
    /// <summary>
    ///   <para>bio:Annulment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of declaring a marriage void from the beginning as though it never existed.</para>
    /// labels<para>Annulment</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Annulment">http://purl.org/vocab/bio/0.1/Annulment</seealso>
    let Annulment = Prefixed_Name(bio, "Annulment") |> PrefixedName
    /// <summary>
    ///   <para>bio:Assassination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person being deliberately targeted and killed.</para>
    /// labels<para>Assassination</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Assassination">http://purl.org/vocab/bio/0.1/Assassination</seealso>
    let Assassination = Prefixed_Name(bio, "Assassination") |> PrefixedName
    /// <summary>
    ///   <para>bio:Baptism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event held to admit a person to membership of a Christian church.</para>
    /// labels<para>Baptism</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Baptism">http://purl.org/vocab/bio/0.1/Baptism</seealso>
    let Baptism = Prefixed_Name(bio, "Baptism") |> PrefixedName
    /// <summary>
    ///   <para>bio:BasMitzvah</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event held when a Jewish girl reaching age 13, also known as "Bat Mitzvah."</para>
    /// labels<para>BasMitzvah</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/BasMitzvah">http://purl.org/vocab/bio/0.1/BasMitzvah</seealso>
    let BasMitzvah = Prefixed_Name(bio, "BasMitzvah") |> PrefixedName
    /// <summary>
    ///   <para>bio:Birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person entering into life.</para>
    /// labels<para>Birth</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Birth">http://purl.org/vocab/bio/0.1/Birth</seealso>
    let Birth = Prefixed_Name(bio, "Birth") |> PrefixedName
    /// <summary>
    ///   <para>bio:Burial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of interring the remains of a person's body into the ground.</para>
    /// labels<para>Burial</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Burial">http://purl.org/vocab/bio/0.1/Burial</seealso>
    let Burial = Prefixed_Name(bio, "Burial") |> PrefixedName
    /// <summary>
    ///   <para>bio:Naturalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person obtaining citizenship. Note that the place the naturalization event occurs at may be different from the state the person is obtaining citizenship of. </para>
    /// labels<para>Naturalization</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Naturalization">http://purl.org/vocab/bio/0.1/Naturalization</seealso>
    let Naturalization = Prefixed_Name(bio, "Naturalization") |> PrefixedName
    /// <summary>
    ///   <para>bio:Ordination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event held when a person receives authority to act in religious matters.</para>
    /// labels<para>Ordination</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Ordination">http://purl.org/vocab/bio/0.1/Ordination</seealso>
    let Ordination = Prefixed_Name(bio, "Ordination") |> PrefixedName
    /// <summary>
    ///   <para>bio:biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An extended description or account of someone's life.</para>
    /// labels<para>Biography</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/biography">http://purl.org/vocab/bio/0.1/biography</seealso>
    let biography = Prefixed_Name(bio, "biography") |> PrefixedName
    /// <summary>
    ///   <para>bio:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A biological child of a person. </para>
    /// labels<para>Child</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/child">http://purl.org/vocab/bio/0.1/child</seealso>
    let child = Prefixed_Name(bio, "child") |> PrefixedName
    /// <summary>
    ///   <para>bio:concludingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An event that marks the end of an interval and/or relationship. The event changes of the state of affairs that held during the interval. For example a period of study may be concluded by a Graduation event.</para>
    /// labels<para>Concluding Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/concludingEvent">http://purl.org/vocab/bio/0.1/concludingEvent</seealso>
    let concludingEvent = Prefixed_Name(bio, "concludingEvent") |> PrefixedName

    /// <summary>
    ///   <para>bio:immediatelyFollowingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An event that starts immediately after this event.</para>
    /// labels<para>Immediately Following Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/immediatelyFollowingEvent">http://purl.org/vocab/bio/0.1/immediatelyFollowingEvent</seealso>
    let immediatelyFollowingEvent =
        Prefixed_Name(bio, "immediatelyFollowingEvent") |> PrefixedName

    /// <summary>
    ///   <para>bio:Murder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person being killed unlawfully with intent by the killer.</para>
    /// labels<para>Murder</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Murder">http://purl.org/vocab/bio/0.1/Murder</seealso>
    let Murder = Prefixed_Name(bio, "Murder") |> PrefixedName
    /// <summary>
    ///   <para>bio:BarMitzvah</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event held when a Jewish boy reaches age 13.</para>
    /// labels<para>BarMitzvah</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/BarMitzvah">http://purl.org/vocab/bio/0.1/BarMitzvah</seealso>
    let BarMitzvah = Prefixed_Name(bio, "BarMitzvah") |> PrefixedName
    /// <summary>
    ///   <para>bio:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The place at which an event occurred.</para>
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/place">http://purl.org/vocab/bio/0.1/place</seealso>
    let place = Prefixed_Name(bio, "place") |> PrefixedName
    /// <summary>
    ///   <para>bio:Coronation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ceremonial event of a person being invested with regal power to become a monarch.</para>
    /// labels<para>Coronation</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Coronation">http://purl.org/vocab/bio/0.1/Coronation</seealso>
    let Coronation = Prefixed_Name(bio, "Coronation") |> PrefixedName
    /// <summary>
    ///   <para>bio:Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person's life ending.</para>
    /// labels<para>Death</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Death">http://purl.org/vocab/bio/0.1/Death</seealso>
    let Death = Prefixed_Name(bio, "Death") |> PrefixedName
    /// <summary>
    ///   <para>bio:Cremation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of disposing of the remains of a person's body by fire.</para>
    /// labels<para>Cremation</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Cremation">http://purl.org/vocab/bio/0.1/Cremation</seealso>
    let Cremation = Prefixed_Name(bio, "Cremation") |> PrefixedName
    /// <summary>
    ///   <para>bio:PositionChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person changing the position they hold with an employer.</para>
    /// labels<para>Change of Position</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/PositionChange">http://purl.org/vocab/bio/0.1/PositionChange</seealso>
    let PositionChange = Prefixed_Name(bio, "PositionChange") |> PrefixedName
    /// <summary>
    ///   <para>bio:Dismissal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person involuntarily giving up their office or position. Dismissal is often perceived to be the employee's fault and may be considered disgraceful.</para>
    /// labels<para>Dismissal</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Dismissal">http://purl.org/vocab/bio/0.1/Dismissal</seealso>
    let Dismissal = Prefixed_Name(bio, "Dismissal") |> PrefixedName
    /// <summary>
    ///   <para>bio:Divorce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of legally dissolving a marriage.</para>
    /// labels<para>Divorce</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Divorce">http://purl.org/vocab/bio/0.1/Divorce</seealso>
    let Divorce = Prefixed_Name(bio, "Divorce") |> PrefixedName
    /// <summary>
    ///   <para>bio:Enrolment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person initiating attendence to a school or other place of learning.</para>
    /// labels<para>Enrolment</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Enrolment">http://purl.org/vocab/bio/0.1/Enrolment</seealso>
    let Enrolment = Prefixed_Name(bio, "Enrolment") |> PrefixedName
    /// <summary>
    ///   <para>bio:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event is an occurrence that brings about a change in the state of affairs for one or more people and/or other agents. Events are assumed to occur over a period of time and may not have precise start and end points.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Event">http://purl.org/vocab/bio/0.1/Event</seealso>
    let Event = Prefixed_Name(bio, "Event") |> PrefixedName
    /// <summary>
    ///   <para>bio:Demotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person changing the position they hold with an employer to one with less importance or responsibility.</para>
    /// labels<para>Demotion</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Demotion">http://purl.org/vocab/bio/0.1/Demotion</seealso>
    let Demotion = Prefixed_Name(bio, "Demotion") |> PrefixedName
    /// <summary>
    ///   <para>bio:Disbanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a group or organization being disbanded.</para>
    /// labels<para>Disbanding</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Disbanding">http://purl.org/vocab/bio/0.1/Disbanding</seealso>
    let Disbanding = Prefixed_Name(bio, "Disbanding") |> PrefixedName
    /// <summary>
    ///   <para>bio:termgroup2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///
    /// labels<para>Types of event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/termgroup2">http://purl.org/vocab/bio/0.1/termgroup2</seealso>
    let termgroup2 = Prefixed_Name(bio, "termgroup2") |> PrefixedName
    /// <summary>
    ///   <para>bio:termgroup5</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///
    /// labels<para>Properties that relate an event to another event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/termgroup5">http://purl.org/vocab/bio/0.1/termgroup5</seealso>
    let termgroup5 = Prefixed_Name(bio, "termgroup5") |> PrefixedName
    /// <summary>
    ///   <para>bio:termgroup4</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///
    /// labels<para>Properties that relate an event to an agent</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/termgroup4">http://purl.org/vocab/bio/0.1/termgroup4</seealso>
    let termgroup4 = Prefixed_Name(bio, "termgroup4") |> PrefixedName
    /// <summary>
    ///   <para>bio:termgroup1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///
    /// labels<para>Properties of a person</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/termgroup1">http://purl.org/vocab/bio/0.1/termgroup1</seealso>
    let termgroup1 = Prefixed_Name(bio, "termgroup1") |> PrefixedName
    /// <summary>
    ///   <para>bio:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of an individual or a group of performers performing. Examples include concerts, plays, recitals, recordings, busking etc.</para>
    /// labels<para>Performance</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Performance">http://purl.org/vocab/bio/0.1/Performance</seealso>
    let Performance = Prefixed_Name(bio, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>bio:Promotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person changing the position they hold with an employer to one with more importance or responsibility.</para>
    /// labels<para>Promotion</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Promotion">http://purl.org/vocab/bio/0.1/Promotion</seealso>
    let Promotion = Prefixed_Name(bio, "Promotion") |> PrefixedName
    /// <summary>
    ///   <para>bio:Redundancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person involuntarily giving up an office or position that is no longer needed. Redundancy is usually perceived to be the employer's fault and is usually due to conditions outside of the employee's control.</para>
    /// labels<para>Redundancy</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Redundancy">http://purl.org/vocab/bio/0.1/Redundancy</seealso>
    let Redundancy = Prefixed_Name(bio, "Redundancy") |> PrefixedName
    /// <summary>
    ///   <para>bio:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A particular type of connection existing between people, groups or organizations related to or having dealings with each other.</para>
    /// labels<para>Agent Relationship</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Relationship">http://purl.org/vocab/bio/0.1/Relationship</seealso>
    let Relationship = Prefixed_Name(bio, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>bio:Resignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person voluntarily giving up or quitting their office or position.</para>
    /// labels<para>Resignation</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Resignation">http://purl.org/vocab/bio/0.1/Resignation</seealso>
    let Resignation = Prefixed_Name(bio, "Resignation") |> PrefixedName
    /// <summary>
    ///   <para>bio:Retirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The event of a person exiting an occupational relationship with an employer after a qualifying time period. In many cultures retirement is expected and even required once the person reaches a particular age.</para>
    /// labels<para>Retirement</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/Retirement">http://purl.org/vocab/bio/0.1/Retirement</seealso>
    let Retirement = Prefixed_Name(bio, "Retirement") |> PrefixedName
    /// <summary>
    ///   <para>bio:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, organization or group that plays a role in an event.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/agent">http://purl.org/vocab/bio/0.1/agent</seealso>
    let agent = Prefixed_Name(bio, "agent") |> PrefixedName
    /// <summary>
    ///   <para>bio:birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An birth event associated with a person, group or organization.</para>
    /// labels<para>Birth Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/birth">http://purl.org/vocab/bio/0.1/birth</seealso>
    let birth = Prefixed_Name(bio, "birth") |> PrefixedName
    /// <summary>
    ///   <para>bio:concurrentEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An event that occurs while this event is occurring. The events need not start or conclude at the same times.</para>
    /// labels<para>Concurrent Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/concurrentEvent">http://purl.org/vocab/bio/0.1/concurrentEvent</seealso>
    let concurrentEvent = Prefixed_Name(bio, "concurrentEvent") |> PrefixedName
    /// <summary>
    ///   <para>bio:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date at which an event occurred.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/date">http://purl.org/vocab/bio/0.1/date</seealso>
    let date = Prefixed_Name(bio, "date") |> PrefixedName
    /// <summary>
    ///   <para>bio:death</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An death event associated with a person, group or organization.</para>
    /// labels<para>Death Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/death">http://purl.org/vocab/bio/0.1/death</seealso>
    let death = Prefixed_Name(bio, "death") |> PrefixedName
    /// <summary>
    ///   <para>bio:employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An agent that is involved in an event as an employer.</para>
    /// labels<para>Employer</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/employer">http://purl.org/vocab/bio/0.1/employer</seealso>
    let employer = Prefixed_Name(bio, "employer") |> PrefixedName
    /// <summary>
    ///   <para>bio:eventInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The interval during which the event occurs. This interval represents the exact interval of occurence for an event, it starts at the moment the event commences and finishes when the event concludes. In other words both the event and the interval start at the same instant of time and extend for the same duration.</para>
    /// labels<para>Event Interval</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/eventInterval">http://purl.org/vocab/bio/0.1/eventInterval</seealso>
    let eventInterval = Prefixed_Name(bio, "eventInterval") |> PrefixedName
    /// <summary>
    ///   <para>bio:father</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The biological father of a person, also known as the genitor.</para>
    /// labels<para>Father</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/father">http://purl.org/vocab/bio/0.1/father</seealso>
    let father = Prefixed_Name(bio, "father") |> PrefixedName
    /// <summary>
    ///   <para>bio:followingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An event that starts at some time after this event.</para>
    /// labels<para>Following Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/followingEvent">http://purl.org/vocab/bio/0.1/followingEvent</seealso>
    let followingEvent = Prefixed_Name(bio, "followingEvent") |> PrefixedName

    /// <summary>
    ///   <para>bio:immediatelyPrecedingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An event that occurs and concludes immediately before this event.</para>
    /// labels<para>Immediately Preceding Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/immediatelyPrecedingEvent">http://purl.org/vocab/bio/0.1/immediatelyPrecedingEvent</seealso>
    let immediatelyPrecedingEvent =
        Prefixed_Name(bio, "immediatelyPrecedingEvent") |> PrefixedName

    /// <summary>
    ///   <para>bio:precedingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>An event that occurs and concludes at some time before this event.</para>
    /// labels<para>Preceding Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/precedingEvent">http://purl.org/vocab/bio/0.1/precedingEvent</seealso>
    let precedingEvent = Prefixed_Name(bio, "precedingEvent") |> PrefixedName
    /// <summary>
    ///   <para>bio:initiatingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An event that marks the start of an interval and/or relationship. The event contributes to and/or causes of the state of affairs that hold during the interval. For example a period of study may be initiated by an Enrolment event.</para>
    /// labels<para>Initiating Event</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/initiatingEvent">http://purl.org/vocab/bio/0.1/initiatingEvent</seealso>
    let initiatingEvent = Prefixed_Name(bio, "initiatingEvent") |> PrefixedName
    /// <summary>
    ///   <para>bio:interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The interval during which the relationship persists.</para>
    /// labels<para>Relationship Interval</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/interval">http://purl.org/vocab/bio/0.1/interval</seealso>
    let interval = Prefixed_Name(bio, "interval") |> PrefixedName
    /// <summary>
    ///   <para>bio:keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A comma delimited list of key words that describe a person.</para>
    /// labels<para>Key Words</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/keywords">http://purl.org/vocab/bio/0.1/keywords</seealso>
    let keywords = Prefixed_Name(bio, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>bio:mother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The biological mother of a person, also known as the genetrix.</para>
    /// labels<para>Mother</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/mother">http://purl.org/vocab/bio/0.1/mother</seealso>
    let mother = Prefixed_Name(bio, "mother") |> PrefixedName
    /// <summary>
    ///   <para>bio:officiator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person that officiates at a ceremonial event.</para>
    /// labels<para>Officiator</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/officiator">http://purl.org/vocab/bio/0.1/officiator</seealso>
    let officiator = Prefixed_Name(bio, "officiator") |> PrefixedName
    /// <summary>
    ///   <para>bio:olb</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A one-line biography of the person.</para>
    /// labels<para>One-line bio</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/olb">http://purl.org/vocab/bio/0.1/olb</seealso>
    let olb = Prefixed_Name(bio, "olb") |> PrefixedName
    /// <summary>
    ///   <para>bio:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An organization that plays a role in an event.</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/organization">http://purl.org/vocab/bio/0.1/organization</seealso>
    let organization = Prefixed_Name(bio, "organization") |> PrefixedName
    /// <summary>
    ///   <para>bio:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person that takes the parent role in an event.</para>
    /// labels<para>Parent</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/parent">http://purl.org/vocab/bio/0.1/parent</seealso>
    let parent = Prefixed_Name(bio, "parent") |> PrefixedName
    /// <summary>
    ///   <para>bio:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, group or organization that participates in a relationship for some time.</para>
    /// labels<para>Participant</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/participant">http://purl.org/vocab/bio/0.1/participant</seealso>
    let participant = Prefixed_Name(bio, "participant") |> PrefixedName
    /// <summary>
    ///   <para>bio:relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship that a person, group or organization participates in for some time.</para>
    /// labels<para>Relationship</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/relationship">http://purl.org/vocab/bio/0.1/relationship</seealso>
    let relationship = Prefixed_Name(bio, "relationship") |> PrefixedName
    /// <summary>
    ///   <para>bio:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The employment position or public office involved in an event.</para>
    /// labels<para>Position</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/position">http://purl.org/vocab/bio/0.1/position</seealso>
    let position = Prefixed_Name(bio, "position") |> PrefixedName
    /// <summary>
    ///   <para>bio:spectator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person that is present at and observes the occurrence of at least part of an event.</para>
    /// labels<para>Spectator</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/spectator">http://purl.org/vocab/bio/0.1/spectator</seealso>
    let spectator = Prefixed_Name(bio, "spectator") |> PrefixedName
    /// <summary>
    ///   <para>bio:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A country or independent territory that is involved in an event.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/state">http://purl.org/vocab/bio/0.1/state</seealso>
    let state = Prefixed_Name(bio, "state") |> PrefixedName
    /// <summary>
    ///   <para>bio:witness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person that witnesses and can bear testimony to the occurrence of an event.</para>
    /// labels<para>Witness</para></remarks>
    /// <seealso href="http://purl.org/vocab/bio/0.1/witness">http://purl.org/vocab/bio/0.1/witness</seealso>
    let witness = Prefixed_Name(bio, "witness") |> PrefixedName
