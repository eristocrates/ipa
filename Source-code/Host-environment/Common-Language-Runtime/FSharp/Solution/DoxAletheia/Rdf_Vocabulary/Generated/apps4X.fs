namespace http.semweb.mmlab.be.ns.apps4X.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module apps4X =
    let _namespace_iri = Namespace_Iri apps4X |> NamespaceIRI
    /// <summary>
    ///   <para>apps4X:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdfs:Property</para>
    ///   <para> the event's sponsor </para>
    /// labels<para>sponsor</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#sponsor">http://semweb.mmlab.be/ns/apps4X#sponsor</seealso>
    let sponsor = Prefixed_Name(apps4X, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:Jury</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A jury evaluating the submissions to a co-creation event.</para>
    /// labels<para>Jury</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#Jury">http://semweb.mmlab.be/ns/apps4X#Jury</seealso>
    let Jury = Prefixed_Name(apps4X, "Jury") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:Submission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An App Concept idea as it was submitted to a certain competition.</para>
    /// labels<para>Submission</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#Submission">http://semweb.mmlab.be/ns/apps4X#Submission</seealso>
    let Submission = Prefixed_Name(apps4X, "Submission") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>one or more awards offered at this co-creation event</para>
    /// labels<para>award offered</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#award">http://semweb.mmlab.be/ns/apps4X#award</seealso>
    let award = Prefixed_Name(apps4X, "award") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:CocreationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A co-creation event is a competition, a contest, a challenge etc. It's a subproperty as it is an event but with a certain scope</para>
    /// labels<para>Co-creation event</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#CocreationEvent">http://semweb.mmlab.be/ns/apps4X#CocreationEvent</seealso>
    let CocreationEvent = Prefixed_Name(apps4X, "CocreationEvent") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:awardCeremony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The award ceremony</para>
    /// labels<para>award's ceremnoy</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#awardCeremony">http://semweb.mmlab.be/ns/apps4X#awardCeremony</seealso>
    let awardCeremony = Prefixed_Name(apps4X, "awardCeremony") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:juryMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A jury consists of </para>
    /// labels<para>Jury Member</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#juryMember">http://semweb.mmlab.be/ns/apps4X#juryMember</seealso>
    let juryMember = Prefixed_Name(apps4X, "juryMember") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A submission consists of </para>
    /// labels<para>consists of</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#consistsOf">http://semweb.mmlab.be/ns/apps4X#consistsOf</seealso>
    let consistsOf = Prefixed_Name(apps4X, "consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:juryRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The rate given by the jury</para>
    /// labels<para>Jury's rate</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#juryRate">http://semweb.mmlab.be/ns/apps4X#juryRate</seealso>
    let juryRate = Prefixed_Name(apps4X, "juryRate") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the event's organizer</para>
    /// labels<para>organizer</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#organizer">http://semweb.mmlab.be/ns/apps4X#organizer</seealso>
    let organizer = Prefixed_Name(apps4X, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Propert</para>
    ///   <para>a link to the registration for the event</para>
    /// labels<para>url to the registration</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#registration">http://semweb.mmlab.be/ns/apps4X#registration</seealso>
    let registration = Prefixed_Name(apps4X, "registration") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>the event's short title and/or its abbreviation</para>
    /// labels<para>short title</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#shortTitle">http://semweb.mmlab.be/ns/apps4X#shortTitle</seealso>
    let shortTitle = Prefixed_Name(apps4X, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The App Concept can be within a certain theme.</para>
    /// labels<para>theme</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#theme">http://semweb.mmlab.be/ns/apps4X#theme</seealso>
    let theme = Prefixed_Name(apps4X, "theme") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:usersRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The rate given by the users</para>
    /// labels<para>Users' rate</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#usersRate">http://semweb.mmlab.be/ns/apps4X#usersRate</seealso>
    let usersRate = Prefixed_Name(apps4X, "usersRate") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:wonAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>links to the award that this App Concept won</para>
    /// labels<para>won award</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#wonAward">http://semweb.mmlab.be/ns/apps4X#wonAward</seealso>
    let wonAward = Prefixed_Name(apps4X, "wonAward") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The event's size in regard to its thematic area and/or locality. </para>
    /// labels<para>the size of the event</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#size">http://semweb.mmlab.be/ns/apps4X#size</seealso>
    let size = Prefixed_Name(apps4X, "size") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>the award offered by the jury to a certain App Concept</para>
    /// labels<para>Award</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#Award">http://semweb.mmlab.be/ns/apps4X#Award</seealso>
    let Award = Prefixed_Name(apps4X, "Award") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Datatype</para>
    ///   <para>The event edition. </para>
    /// labels<para>edition</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#edition">http://semweb.mmlab.be/ns/apps4X#edition</seealso>
    let edition = Prefixed_Name(apps4X, "edition") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:nominated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An App Concept is nominated for the award.</para>
    /// labels<para>nominated for</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#nominated">http://semweb.mmlab.be/ns/apps4X#nominated</seealso>
    let nominated = Prefixed_Name(apps4X, "nominated") |> PrefixedName
    /// <summary>
    ///   <para>apps4X:prize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The actual prize offered.</para>
    /// labels<para>prize</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/apps4X#prize">http://semweb.mmlab.be/ns/apps4X#prize</seealso>
    let prize = Prefixed_Name(apps4X, "prize") |> PrefixedName
