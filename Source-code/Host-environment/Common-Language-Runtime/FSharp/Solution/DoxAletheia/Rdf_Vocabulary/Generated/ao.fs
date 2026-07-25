namespace http.purl.org.ontology.ao.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ao =
    let _namespace_iri = Namespace_Iri ao |> NamespaceIRI
    /// <summary>
    ///   <para>ao:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property to associate any environmental context to an individual, e.g. a location, a time or an activity. Hence, this property is intended that sub properties should be created from it.</para>
    /// labels<para>has context</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#context">http://purl.org/ontology/ao/core#context</seealso>
    let context = Prefixed_Name(ao, "context") |> PrefixedName
    /// <summary>
    ///   <para>ao:likeminded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates likeminded people to an association, which they like/ agree with.</para>
    /// labels<para>has likeminded</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#likeminded">http://purl.org/ontology/ao/core#likeminded</seealso>
    let likeminded = Prefixed_Name(ao, "likeminded") |> PrefixedName
    /// <summary>
    ///   <para>ao:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A location, which is associated to an individual, e.g. my house, my country, my current whereabouts.</para>
    /// labels<para>has location</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#location">http://purl.org/ontology/ao/core#location</seealso>
    let location = Prefixed_Name(ao, "location") |> PrefixedName
    /// <summary>
    ///   <para>ao:occasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An occasion for which something was created.</para>
    /// labels<para>has occassion</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#occasion">http://purl.org/ontology/ao/core#occasion</seealso>
    let occasion = Prefixed_Name(ao, "occasion") |> PrefixedName
    /// <summary>
    ///   <para>ao:used_application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An application that is related to an event, e.g. a iTunes to a play back event of a music track.</para>
    /// labels<para>has used application</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#used_application">http://purl.org/ontology/ao/core#used_application</seealso>
    let used_application = Prefixed_Name(ao, "used_application") |> PrefixedName
    /// <summary>
    ///   <para>ao:device</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A device, which is associated with an individual, e.g. a CD player with a CD it's currently playing back.</para>
    /// labels<para>has device</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#device">http://purl.org/ontology/ao/core#device</seealso>
    let device = Prefixed_Name(ao, "device") |> PrefixedName
    /// <summary>
    ///   <para>ao:included_association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property could be used to compose association statements or to reuse them, e.g. to make them likeable
    /// in a specific context.</para>
    /// labels<para>has included association</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#included_association">http://purl.org/ontology/ao/core#included_association</seealso>
    let included_association = Prefixed_Name(ao, "included_association") |> PrefixedName
    /// <summary>
    ///   <para>ao:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A time, which is associated to an individual, e.g. morning, afternoon, evening.</para>
    /// labels<para>has time</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#time">http://purl.org/ontology/ao/core#time</seealso>
    let time = Prefixed_Name(ao, "time") |> PrefixedName
    /// <summary>
    ///   <para>ao:used_device</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A device that is related to an event, e.g. a MP3 player to a play back event of a music track.</para>
    /// labels<para>has used device</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#used_device">http://purl.org/ontology/ao/core#used_device</seealso>
    let used_device = Prefixed_Name(ao, "used_device") |> PrefixedName
    /// <summary>
    ///   <para>ao:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#">http://purl.org/ontology/ao/core#</seealso>
    let _prefix_iri = Prefixed_Name(ao, "") |> PrefixedName
    /// <summary>
    ///   <para>ao:LikeableAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A likeable association. That means this association type is intended to be used for voting (ao:likeminded),
    /// feedbacking (rev:Feedback), reviewing (e.g. rev:rating) an association statement (related by ao:included_association) in the
    /// context of something.</para>
    /// labels<para>Likeable Association</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#LikeableAssociation">http://purl.org/ontology/ao/core#LikeableAssociation</seealso>
    let LikeableAssociation = Prefixed_Name(ao, "LikeableAssociation") |> PrefixedName
    /// <summary>
    ///   <para>ao:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An activity, which is associated to an individual, e.g. dancing, sleeping, driving.</para>
    /// labels<para>has activity</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#activity">http://purl.org/ontology/ao/core#activity</seealso>
    let activity = Prefixed_Name(ao, "activity") |> PrefixedName
    /// <summary>
    ///   <para>ao:application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An application, which is associated to an individual, e.g. a music player to a music track it's currently playing back.</para>
    /// labels<para>has application</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#application">http://purl.org/ontology/ao/core#application</seealso>
    let application = Prefixed_Name(ao, "application") |> PrefixedName
    /// <summary>
    ///   <para>ao:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An genre of something.</para>
    /// labels<para>has genre</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#genre">http://purl.org/ontology/ao/core#genre</seealso>
    let genre = Prefixed_Name(ao, "genre") |> PrefixedName
    /// <summary>
    ///   <para>ao:mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A mood that should be created by something.</para>
    /// labels<para>has mood</para></remarks>
    /// <seealso href="http://purl.org/ontology/ao/core#mood">http://purl.org/ontology/ao/core#mood</seealso>
    let mood = Prefixed_Name(ao, "mood") |> PrefixedName
