#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vocab/bio/0.1/" "bio"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Accession</para>
    ///   <para>rdfs:comment : The event of a person succeeding to the right to hold regal power. This event is often automatic on the death of the previous monarch and is usually followed by a coronation event.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Accession">bio:Accession</a>
    /// </summary>
    let Accession = _prefixId.prefix "Accession"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Adoption</para>
    ///   <para>rdfs:comment : The event of creating of a legal parent/child relationship that does not exist biologically.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Adoption">bio:Adoption</a>
    /// </summary>
    let Adoption = _prefixId.prefix "Adoption"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Annulment</para>
    ///   <para>rdfs:comment : The event of declaring a marriage void from the beginning as though it never existed.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Annulment">bio:Annulment</a>
    /// </summary>
    let Annulment = _prefixId.prefix "Annulment"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Assassination</para>
    ///   <para>rdfs:comment : The event of a person being deliberately targeted and killed.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Assassination">bio:Assassination</a>
    /// </summary>
    let Assassination = _prefixId.prefix "Assassination"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Baptism</para>
    ///   <para>rdfs:comment : The ceremonial event held to admit a person to membership of a Christian church.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Baptism">bio:Baptism</a>
    /// </summary>
    let Baptism = _prefixId.prefix "Baptism"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : BarMitzvah</para>
    ///   <para>rdfs:comment : The ceremonial event held when a Jewish boy reaches age 13.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/BarMitzvah">bio:BarMitzvah</a>
    /// </summary>
    let BarMitzvah = _prefixId.prefix "BarMitzvah"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : BasMitzvah</para>
    ///   <para>rdfs:comment : The ceremonial event held when a Jewish girl reaching age 13, also known as "Bat Mitzvah."</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/BasMitzvah">bio:BasMitzvah</a>
    /// </summary>
    let BasMitzvah = _prefixId.prefix "BasMitzvah"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Birth</para>
    ///   <para>rdfs:comment : The event of a person entering into life.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Birth">bio:Birth</a>
    /// </summary>
    let Birth = _prefixId.prefix "Birth"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Burial</para>
    ///   <para>rdfs:comment : The event of interring the remains of a person's body into the ground.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Burial">bio:Burial</a>
    /// </summary>
    let Burial = _prefixId.prefix "Burial"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Coronation</para>
    ///   <para>rdfs:comment : The ceremonial event of a person being invested with regal power to become a monarch.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Coronation">bio:Coronation</a>
    /// </summary>
    let Coronation = _prefixId.prefix "Coronation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Cremation</para>
    ///   <para>rdfs:comment : The event of disposing of the remains of a person's body by fire.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Cremation">bio:Cremation</a>
    /// </summary>
    let Cremation = _prefixId.prefix "Cremation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Death</para>
    ///   <para>rdfs:comment : The event of a person's life ending.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Death">bio:Death</a>
    /// </summary>
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Demotion</para>
    ///   <para>rdfs:comment : The event of a person changing the position they hold with an employer to one with less importance or responsibility.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Demotion">bio:Demotion</a>
    /// </summary>
    let Demotion = _prefixId.prefix "Demotion"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-06-10^^xsd:string</para>
    ///   <para>rdfs:label : Disbanding</para>
    ///   <para>rdfs:comment : The event of a group or organization being disbanded.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Disbanding">bio:Disbanding</a>
    /// </summary>
    let Disbanding = _prefixId.prefix "Disbanding"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Dismissal</para>
    ///   <para>rdfs:comment : The event of a person involuntarily giving up their office or position. Dismissal is often perceived to be the employee's fault and may be considered disgraceful.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Dismissal">bio:Dismissal</a>
    /// </summary>
    let Dismissal = _prefixId.prefix "Dismissal"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Divorce</para>
    ///   <para>rdfs:comment : The event of legally dissolving a marriage.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Divorce">bio:Divorce</a>
    /// </summary>
    let Divorce = _prefixId.prefix "Divorce"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Emigration</para>
    ///   <para>rdfs:comment : The event of a person leaving their homeland with the intent of residing elsewhere.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Emigration">bio:Emigration</a>
    /// </summary>
    let Emigration = _prefixId.prefix "Emigration"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Employment</para>
    ///   <para>rdfs:comment : The event of a person entering an occupational relationship with an employer.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Employment">bio:Employment</a>
    /// </summary>
    let Employment = _prefixId.prefix "Employment"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Enrolment</para>
    ///   <para>rdfs:comment : The event of a person initiating attendence to a school or other place of learning.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Enrolment">bio:Enrolment</a>
    /// </summary>
    let Enrolment = _prefixId.prefix "Enrolment"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : An event is an occurrence that brings about a change in the state of affairs for one or more people and/or other agents. Events are assumed to occur over a period of time and may not have precise start and end points.</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>vann:usageNote : This class is intended to describe biographical events, i.e. events in the life of a person.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Event">bio:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Execution</para>
    ///   <para>rdfs:comment : The event of a person being deliberately killed as punishment.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Execution">bio:Execution</a>
    /// </summary>
    let Execution = _prefixId.prefix "Execution"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-06-10^^xsd:string</para>
    ///   <para>rdfs:label : Formation</para>
    ///   <para>rdfs:comment : The event of a group or organization coming into being.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Formation">bio:Formation</a>
    /// </summary>
    let Formation = _prefixId.prefix "Formation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Funeral</para>
    ///   <para>rdfs:comment : The event of marking a person's death with a ceremony.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Funeral">bio:Funeral</a>
    /// </summary>
    let Funeral = _prefixId.prefix "Funeral"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Graduation</para>
    ///   <para>rdfs:comment : The event of a person being awarded educational diplomas or degrees.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Graduation">bio:Graduation</a>
    /// </summary>
    let Graduation = _prefixId.prefix "Graduation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Group Event</para>
    ///   <para>rdfs:comment : A type of event that is principally about one or more agents and their partnership. Other agents may be involved but the event is most significant for the partner agent.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/GroupEvent">bio:GroupEvent</a>
    /// </summary>
    let GroupEvent = _prefixId.prefix "GroupEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-04^^xsd:string</para>
    ///   <para>rdfs:label : Imprisonment</para>
    ///   <para>rdfs:comment : The event of a person being detained in a jail or prison.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Imprisonment">bio:Imprisonment</a>
    /// </summary>
    let Imprisonment = _prefixId.prefix "Imprisonment"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Inauguration</para>
    ///   <para>rdfs:comment : The ceremonial event marking the beginning of a person's term of office as a leader.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Inauguration">bio:Inauguration</a>
    /// </summary>
    let Inauguration = _prefixId.prefix "Inauguration"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Individual Event</para>
    ///   <para>rdfs:comment : A type of event that is principally about a single person, group or organization. Other agents may be involved but the event is most significant for the principal agent.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/IndividualEvent">bio:IndividualEvent</a>
    /// </summary>
    let IndividualEvent = _prefixId.prefix "IndividualEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Interval</para>
    ///   <para>rdfs:comment : A extended interval of time related to a particular state of affairs, such as the lifespan of a person or a period of employment.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Interval">bio:Interval</a>
    /// </summary>
    let Interval = _prefixId.prefix "Interval"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Investiture</para>
    ///   <para>rdfs:comment : The ceremonial event of a person taking a public office or honour.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Investiture">bio:Investiture</a>
    /// </summary>
    let Investiture = _prefixId.prefix "Investiture"
    /// <summary>
    ///   <para>rdfs:label : Marriage</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The event of creating uniting the participants into a new family unit, sometimes accompanied by a formal wedding ceremony. This is intended to cover a broad range of marriages including those given formal legal standing, common-law, or by convention. It is not restricted to marriages of two people of the opposite gender, but also includes polygamous and same-sex unions.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Marriage">bio:Marriage</a>
    /// </summary>
    let Marriage = _prefixId.prefix "Marriage"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Murder</para>
    ///   <para>rdfs:comment : The event of a person being killed unlawfully with intent by the killer.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Murder">bio:Murder</a>
    /// </summary>
    let Murder = _prefixId.prefix "Murder"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Change of Name</para>
    ///   <para>rdfs:comment : The event of a person changing their name.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/NameChange">bio:NameChange</a>
    /// </summary>
    let NameChange = _prefixId.prefix "NameChange"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Naturalization</para>
    ///   <para>rdfs:comment : The event of a person obtaining citizenship. Note that the place the naturalization event occurs at may be different from the state the person is obtaining citizenship of. </para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Naturalization">bio:Naturalization</a>
    /// </summary>
    let Naturalization = _prefixId.prefix "Naturalization"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Ordination</para>
    ///   <para>rdfs:comment : The ceremonial event held when a person receives authority to act in religious matters.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Ordination">bio:Ordination</a>
    /// </summary>
    let Ordination = _prefixId.prefix "Ordination"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-06-12^^xsd:string</para>
    ///   <para>rdfs:label : Performance</para>
    ///   <para>rdfs:comment : The event of an individual or a group of performers performing. Examples include concerts, plays, recitals, recordings, busking etc.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Performance">bio:Performance</a>
    /// </summary>
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Change of Position</para>
    ///   <para>rdfs:comment : The event of a person changing the position they hold with an employer.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/PositionChange">bio:PositionChange</a>
    /// </summary>
    let PositionChange = _prefixId.prefix "PositionChange"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Promotion</para>
    ///   <para>rdfs:comment : The event of a person changing the position they hold with an employer to one with more importance or responsibility.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Promotion">bio:Promotion</a>
    /// </summary>
    let Promotion = _prefixId.prefix "Promotion"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Redundancy</para>
    ///   <para>rdfs:comment : The event of a person involuntarily giving up an office or position that is no longer needed. Redundancy is usually perceived to be the employer's fault and is usually due to conditions outside of the employee's control.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Redundancy">bio:Redundancy</a>
    /// </summary>
    let Redundancy = _prefixId.prefix "Redundancy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2011-06-14^^xsd:string</para>
    ///   <para>rdfs:label : Agent Relationship</para>
    ///   <para>rdfs:comment : A particular type of connection existing between people, groups or organizations related to or having dealings with each other.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Relationship">bio:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Resignation</para>
    ///   <para>rdfs:comment : The event of a person voluntarily giving up or quitting their office or position.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Resignation">bio:Resignation</a>
    /// </summary>
    let Resignation = _prefixId.prefix "Resignation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Retirement</para>
    ///   <para>rdfs:comment : The event of a person exiting an occupational relationship with an employer after a qualifying time period. In many cultures retirement is expected and even required once the person reaches a particular age.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/Retirement">bio:Retirement</a>
    /// </summary>
    let Retirement = _prefixId.prefix "Retirement"
    /// <summary>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>label:plural : Agents</para>
    ///   <para>rdfs:comment : A person, organization or group that plays a role in an event.</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/agent">bio:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>vann:usageNote : &lt;p&gt;It is expected that the value of this property is either a literal formatted with HTML markup or a pointer to an HTML document.&lt;/p&gt;^^rdf:XMLLiteral</para>
    ///   <para>dcterms:issued : 2010-06-05^^xsd:string</para>
    ///   <para>rdfs:label : Biography</para>
    ///   <para>rdfs:comment : An extended description or account of someone's life.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/biography">bio:biography</a>
    /// </summary>
    let biography = _prefixId.prefix "biography"
    /// <summary>
    ///   <para>rdfs:comment : An birth event associated with a person, group or organization.</para>
    ///   <para>rdfs:label : Birth Event</para>
    ///   <para>label:plural : Birth Events</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/birth">bio:birth</a>
    /// </summary>
    let birth = _prefixId.prefix "birth"
    /// <summary>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:label : Child</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A biological child of a person. </para>
    ///   <para>vann:usageNote : Note that this is a strict definition of child that does not include adopted children, step-children or similar non-biological relationships. The &lt;a href="http://purl.org/vocab/relationship"&gt;Relationship&lt;/a&gt; vocabulary may be more suitable for broader types of parent/child relation.^^rdf:XMLLiteral</para>
    ///   <para>label:plural : Children</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/child">bio:child</a>
    /// </summary>
    let child = _prefixId.prefix "child"
    /// <summary>
    ///   <para>label:plural : Concluding Event</para>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>rdfs:label : Concluding Event</para>
    ///   <para>rdfs:comment : An event that marks the end of an interval and/or relationship. The event changes of the state of affairs that held during the interval. For example a period of study may be concluded by a Graduation event.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/concludingEvent">bio:concludingEvent</a>
    /// </summary>
    let concludingEvent = _prefixId.prefix "concludingEvent"
    /// <summary>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>label:plural : Concurrent Events</para>
    ///   <para>rdfs:comment : An event that occurs while this event is occurring. The events need not start or conclude at the same times.</para>
    ///   <para>rdfs:label : Concurrent Event</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/concurrentEvent">bio:concurrentEvent</a>
    /// </summary>
    let concurrentEvent = _prefixId.prefix "concurrentEvent"
    /// <summary>
    ///   <para>vann:usageNote : &lt;p&gt;The date should be formatted as specified in &lt;a href="http://www.w3.org/TR/NOTE-datetime"&gt;ISO8601&lt;/a&gt;.
    ///     For example: 2003-03-15 corresponds to the 15th March 2003, and 2003-03-15T13:21-05:00 corresponds to 15th March 2003, 8:21 am, US Eastern Standard Time.&lt;/p&gt;^^rdf:XMLLiteral</para>
    ///   <para>rdfs:comment : The date at which an event occurred.</para>
    ///   <para>rdfs:label : Date</para>
    ///   <para>label:plural : Dates</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/date">bio:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : An death event associated with a person, group or organization.</para>
    ///   <para>rdfs:label : Death Event</para>
    ///   <para>label:plural : Death Events</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/death">bio:death</a>
    /// </summary>
    let death = _prefixId.prefix "death"
    /// <summary>
    ///   <para>rdfs:comment : An agent that is involved in an event as an employer.</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Employer</para>
    ///   <para>label:plural : Employers</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/employer">bio:employer</a>
    /// </summary>
    let employer = _prefixId.prefix "employer"
    /// <summary>
    ///   <para>rdfs:label : Life Event</para>
    ///   <para>label:plural : Life Events</para>
    ///   <para>rdfs:comment : An event associated with a person, group or organization.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/event">bio:event</a>
    /// </summary>
    let event_ = _prefixId.prefix "event"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-06-05^^xsd:string</para>
    ///   <para>rdfs:label : Event Interval</para>
    ///   <para>rdfs:comment : The interval during which the event occurs. This interval represents the exact interval of occurence for an event, it starts at the moment the event commences and finishes when the event concludes. In other words both the event and the interval start at the same instant of time and extend for the same duration.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/eventInterval">bio:eventInterval</a>
    /// </summary>
    let eventInterval = _prefixId.prefix "eventInterval"
    /// <summary>
    ///   <para>vann:usageNote : Note that this is a strict definition of father that does not include non-biological relationships. The &lt;a href="http://purl.org/vocab/relationship"&gt;Relationship&lt;/a&gt; vocabulary may be more suitable for broader types of parent/child relation.^^rdf:XMLLiteral</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>rdfs:comment : The biological father of a person, also known as the genitor.</para>
    ///   <para>rdfs:label : Father</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/father">bio:father</a>
    /// </summary>
    let father = _prefixId.prefix "father"
    /// <summary>
    ///   <para>rdfs:comment : An event that starts at some time after this event.</para>
    ///   <para>label:plural : Following Events</para>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>rdfs:label : Following Event</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/followingEvent">bio:followingEvent</a>
    /// </summary>
    let followingEvent = _prefixId.prefix "followingEvent"
    /// <summary>
    ///   <para>rdfs:comment : An event that starts immediately after this event.</para>
    ///   <para>rdfs:label : Immediately Following Event</para>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>label:plural : Immediately Following Events</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/immediatelyFollowingEvent">bio:immediatelyFollowingEvent</a>
    /// </summary>
    let immediatelyFollowingEvent = _prefixId.prefix "immediatelyFollowingEvent"
    /// <summary>
    ///   <para>rdfs:comment : An event that occurs and concludes immediately before this event.</para>
    ///   <para>rdfs:label : Immediately Preceding Event</para>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>label:plural : Immediately Preceding Events</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/immediatelyPrecedingEvent">bio:immediatelyPrecedingEvent</a>
    /// </summary>
    let immediatelyPrecedingEvent = _prefixId.prefix "immediatelyPrecedingEvent"
    /// <summary>
    ///   <para>label:plural : Initiating Event</para>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>rdfs:label : Initiating Event</para>
    ///   <para>rdfs:comment : An event that marks the start of an interval and/or relationship. The event contributes to and/or causes of the state of affairs that hold during the interval. For example a period of study may be initiated by an Enrolment event.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/initiatingEvent">bio:initiatingEvent</a>
    /// </summary>
    let initiatingEvent = _prefixId.prefix "initiatingEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dcterms:issued : 2010-06-05^^xsd:string</para>
    ///   <para>rdfs:label : Relationship Interval</para>
    ///   <para>rdfs:comment : The interval during which the relationship persists.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/interval">bio:interval</a>
    /// </summary>
    let interval = _prefixId.prefix "interval"
    /// <summary>
    ///   <para>rdfs:comment : A comma delimited list of key words that describe a person.</para>
    ///   <para>dcterms:issued : 2003-07-28^^xsd:string</para>
    ///   <para>rdfs:label : Key Words</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/keywords">bio:keywords</a>
    /// </summary>
    let keywords = _prefixId.prefix "keywords"
    /// <summary>
    ///   <para>vann:usageNote : Note that this is a strict definition of mother that does not include non-biological relationships. The &lt;a href="http://purl.org/vocab/relationship"&gt;Relationship&lt;/a&gt; vocabulary may be more suitable for broader types of parent/child relation.^^rdf:XMLLiteral</para>
    ///   <para>rdfs:label : Mother</para>
    ///   <para>rdfs:comment : The biological mother of a person, also known as the genetrix.</para>
    ///   <para>dcterms:issued : 2010-05-03^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/mother">bio:mother</a>
    /// </summary>
    let mother = _prefixId.prefix "mother"
    /// <summary>
    ///   <para>rdfs:comment : A person that officiates at a ceremonial event.</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Officiator</para>
    ///   <para>label:plural : Officiators</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/officiator">bio:officiator</a>
    /// </summary>
    let officiator = _prefixId.prefix "officiator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A one-line biography of the person.</para>
    ///   <para>rdfs:label : One-line bio</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/olb">bio:olb</a>
    /// </summary>
    let olb = _prefixId.prefix "olb"
    /// <summary>
    ///   <para>rdfs:comment : An organization that plays a role in an event.</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>label:plural : Organizations</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/organization">bio:organization</a>
    /// </summary>
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : Parent</para>
    ///   <para>rdfs:comment : A person that takes the parent role in an event.</para>
    ///   <para>label:plural : Parents</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/parent">bio:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    /// <summary>
    ///   <para>rdfs:comment : A person, group or organization that participates in a relationship for some time.</para>
    ///   <para>dcterms:issued : 2011-06-14^^xsd:string</para>
    ///   <para>label:plural : Participants</para>
    ///   <para>rdfs:label : Participant</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/participant">bio:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:label : Partner</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>label:plural : Partners</para>
    ///   <para>rdfs:comment : A person that is involved in a event as a partner in a relationship.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/partner">bio:partner</a>
    /// </summary>
    let partner = _prefixId.prefix "partner"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>label:plural : Places</para>
    ///   <para>rdfs:label : Place</para>
    ///   <para>rdfs:comment : The place at which an event occurred.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/place">bio:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>label:plural : Positions</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Position</para>
    ///   <para>rdfs:comment : The employment position or public office involved in an event.</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/position">bio:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>label:plural : Preceding Events</para>
    ///   <para>rdfs:label : Preceding Event</para>
    ///   <para>dcterms:issued : 2010-05-06^^xsd:string</para>
    ///   <para>rdfs:comment : An event that occurs and concludes at some time before this event.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/precedingEvent">bio:precedingEvent</a>
    /// </summary>
    let precedingEvent = _prefixId.prefix "precedingEvent"
    /// <summary>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>label:plural : Principals</para>
    ///   <para>rdfs:label : Principal</para>
    ///   <para>rdfs:comment : A person that takes the primary and most important role in an event. For example the principal in a Birth event would be the child being born and the principal in a Burial event would be the deceased person.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/principal">bio:principal</a>
    /// </summary>
    let principal = _prefixId.prefix "principal"
    /// <summary>
    ///   <para>rdfs:comment : A relationship that a person, group or organization participates in for some time.</para>
    ///   <para>dcterms:issued : 2011-06-14^^xsd:string</para>
    ///   <para>label:plural : Relationships</para>
    ///   <para>rdfs:label : Relationship</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/relationship">bio:relationship</a>
    /// </summary>
    let relationship = _prefixId.prefix "relationship"
    /// <summary>
    ///   <para>rdfs:comment : A person that is present at and observes the occurrence of at least part of an event.</para>
    ///   <para>label:plural : Spectators</para>
    ///   <para>rdfs:label : Spectator</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/spectator">bio:spectator</a>
    /// </summary>
    let spectator = _prefixId.prefix "spectator"
    /// <summary>
    ///   <para>label:plural : States</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : A country or independent territory that is involved in an event.</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/state">bio:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    let termgroup1 = _prefixId.prefix "termgroup1"
    let termgroup2 = _prefixId.prefix "termgroup2"
    let termgroup3 = _prefixId.prefix "termgroup3"
    let termgroup4 = _prefixId.prefix "termgroup4"
    let termgroup5 = _prefixId.prefix "termgroup5"
    /// <summary>
    ///   <para>rdfs:label : Witness</para>
    ///   <para>dcterms:issued : 2010-05-05^^xsd:string</para>
    ///   <para>rdfs:comment : A person that witnesses and can bear testimony to the occurrence of an event.</para>
    ///   <para>label:plural : Witnesses</para>
    ///   <a href="http://purl.org/vocab/bio/0.1/witness">bio:witness</a>
    /// </summary>
    let witness = _prefixId.prefix "witness"
