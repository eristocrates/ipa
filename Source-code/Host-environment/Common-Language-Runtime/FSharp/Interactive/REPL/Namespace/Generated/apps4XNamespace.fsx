#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module apps4X =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/apps4X#" "apps4X"

    /// <summary>
    ///   <para>rdfs:comment : the award offered by the jury to a certain App Concept</para>
    ///   <para>rdfs:label : Award</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#Award">apps4X:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>rdfs:comment : A co-creation event is a competition, a contest, a challenge etc. It's a subproperty as it is an event but with a certain scope</para>
    ///   <para>rdfs:label : Co-creation event</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#CocreationEvent">apps4X:CocreationEvent</a>
    /// </summary>
    let CocreationEvent = _prefixId.prefix "CocreationEvent"
    /// <summary>
    ///   <para>rdfs:comment : A jury evaluating the submissions to a co-creation event.</para>
    ///   <para>rdfs:label : Jury</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#Jury">apps4X:Jury</a>
    /// </summary>
    let Jury = _prefixId.prefix "Jury"
    /// <summary>
    ///   <para>rdfs:comment : An App Concept idea as it was submitted to a certain competition.</para>
    ///   <para>rdfs:label : Submission</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#Submission">apps4X:Submission</a>
    /// </summary>
    let Submission = _prefixId.prefix "Submission"
    /// <summary>
    ///   <para>rdfs:comment : one or more awards offered at this co-creation event</para>
    ///   <para>rdfs:label : award offered</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#award">apps4X:award</a>
    /// </summary>
    let award = _prefixId.prefix "award"
    /// <summary>
    ///   <para>rdfs:comment : The award ceremony</para>
    ///   <para>rdfs:label : award's ceremnoy</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#awardCeremony">apps4X:awardCeremony</a>
    /// </summary>
    let awardCeremony = _prefixId.prefix "awardCeremony"
    /// <summary>
    ///   <para>rdfs:comment : A submission consists of </para>
    ///   <para>rdfs:label : consists of</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#consistsOf">apps4X:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>rdfs:comment : The event edition. </para>
    ///   <para>rdfs:label : edition</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#edition">apps4X:edition</a>
    /// </summary>
    let edition = _prefixId.prefix "edition"
    /// <summary>
    ///   <para>rdfs:comment : A jury consists of </para>
    ///   <para>rdfs:label : Jury Member</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#juryMember">apps4X:juryMember</a>
    /// </summary>
    let juryMember = _prefixId.prefix "juryMember"
    /// <summary>
    ///   <para>rdfs:comment : The rate given by the jury</para>
    ///   <para>rdfs:label : Jury's rate</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#juryRate">apps4X:juryRate</a>
    /// </summary>
    let juryRate = _prefixId.prefix "juryRate"
    /// <summary>
    ///   <para>rdfs:comment : An App Concept is nominated for the award.</para>
    ///   <para>rdfs:label : nominated for</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#nominated">apps4X:nominated</a>
    /// </summary>
    let nominated = _prefixId.prefix "nominated"
    /// <summary>
    ///   <para>rdfs:comment : the event's organizer</para>
    ///   <para>rdfs:label : organizer</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#organizer">apps4X:organizer</a>
    /// </summary>
    let organizer = _prefixId.prefix "organizer"
    /// <summary>
    ///   <para>rdfs:comment : The actual prize offered.</para>
    ///   <para>rdfs:label : prize</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#prize">apps4X:prize</a>
    /// </summary>
    let prize = _prefixId.prefix "prize"
    /// <summary>
    ///   <para>rdfs:comment : a link to the registration for the event</para>
    ///   <para>rdfs:label : url to the registration</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#registration">apps4X:registration</a>
    /// </summary>
    let registration = _prefixId.prefix "registration"
    /// <summary>
    ///   <para>rdfs:comment : the event's short title and/or its abbreviation</para>
    ///   <para>rdfs:label : short title</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#shortTitle">apps4X:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    /// <summary>
    ///   <para>rdfs:comment : The event's size in regard to its thematic area and/or locality. </para>
    ///   <para>rdfs:label : the size of the event</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#size">apps4X:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:comment :  the event's sponsor </para>
    ///   <para>rdfs:label : sponsor</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#sponsor">apps4X:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>rdfs:comment : The App Concept can be within a certain theme.</para>
    ///   <para>rdfs:label : theme</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#theme">apps4X:theme</a>
    /// </summary>
    let theme = _prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:comment : The rate given by the users</para>
    ///   <para>rdfs:label : Users' rate</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#usersRate">apps4X:usersRate</a>
    /// </summary>
    let usersRate = _prefixId.prefix "usersRate"
    /// <summary>
    ///   <para>rdfs:comment : links to the award that this App Concept won</para>
    ///   <para>rdfs:label : won award</para>
    ///   <a href="http://semweb.mmlab.be/ns/apps4X#wonAward">apps4X:wonAward</a>
    /// </summary>
    let wonAward = _prefixId.prefix "wonAward"
