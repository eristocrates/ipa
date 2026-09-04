#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ao =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/ao/core#" "ao"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Likeable Association</para>
    ///   <para>rdfs:comment : A likeable association. That means this association type is intended to be used for voting (ao:likeminded),
    /// feedbacking (rev:Feedback), reviewing (e.g. rev:rating) an association statement (related by ao:included_association) in the
    /// context of something.</para>
    ///   <a href="http://purl.org/ontology/ao/core#LikeableAssociation">ao:LikeableAssociation</a>
    /// </summary>
    let LikeableAssociation = _prefixId.prefix "LikeableAssociation"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has activity</para>
    ///   <para>rdfs:comment : An activity, which is associated to an individual, e.g. dancing, sleeping, driving.</para>
    ///   <a href="http://purl.org/ontology/ao/core#activity">ao:activity</a>
    /// </summary>
    let activity = _prefixId.prefix "activity"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has application</para>
    ///   <para>rdfs:comment : An application, which is associated to an individual, e.g. a music player to a music track it's currently playing back.</para>
    ///   <a href="http://purl.org/ontology/ao/core#application">ao:application</a>
    /// </summary>
    let application = _prefixId.prefix "application"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has context</para>
    ///   <para>rdfs:comment : A property to associate any environmental context to an individual, e.g. a location, a time or an activity. Hence, this property is intended that sub properties should be created from it.</para>
    ///   <a href="http://purl.org/ontology/ao/core#context">ao:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has device</para>
    ///   <para>rdfs:comment : A device, which is associated with an individual, e.g. a CD player with a CD it's currently playing back.</para>
    ///   <a href="http://purl.org/ontology/ao/core#device">ao:device</a>
    /// </summary>
    let device = _prefixId.prefix "device"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has genre</para>
    ///   <para>rdfs:comment : An genre of something.</para>
    ///   <a href="http://purl.org/ontology/ao/core#genre">ao:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has included association</para>
    ///   <para>rdfs:comment : This property could be used to compose association statements or to reuse them, e.g. to make them likeable
    /// in a specific context.</para>
    ///   <a href="http://purl.org/ontology/ao/core#included_association">ao:included_association</a>
    /// </summary>
    let included_association = _prefixId.prefix "included_association"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has likeminded^^xsd:string</para>
    ///   <para>rdfs:comment : Associates likeminded people to an association, which they like/ agree with.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/ao/core#likeminded">ao:likeminded</a>
    /// </summary>
    let likeminded = _prefixId.prefix "likeminded"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has location</para>
    ///   <para>rdfs:comment : A location, which is associated to an individual, e.g. my house, my country, my current whereabouts.</para>
    ///   <a href="http://purl.org/ontology/ao/core#location">ao:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has mood</para>
    ///   <para>rdfs:comment : A mood that should be created by something.</para>
    ///   <a href="http://purl.org/ontology/ao/core#mood">ao:mood</a>
    /// </summary>
    let mood = _prefixId.prefix "mood"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has occassion</para>
    ///   <para>rdfs:comment : An occasion for which something was created.</para>
    ///   <a href="http://purl.org/ontology/ao/core#occasion">ao:occasion</a>
    /// </summary>
    let occasion = _prefixId.prefix "occasion"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has time</para>
    ///   <para>rdfs:comment : A time, which is associated to an individual, e.g. morning, afternoon, evening.</para>
    ///   <a href="http://purl.org/ontology/ao/core#time">ao:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has used application</para>
    ///   <para>rdfs:comment : An application that is related to an event, e.g. a iTunes to a play back event of a music track.</para>
    ///   <a href="http://purl.org/ontology/ao/core#used_application">ao:used_application</a>
    /// </summary>
    let used_application = _prefixId.prefix "used_application"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has used device</para>
    ///   <para>rdfs:comment : A device that is related to an event, e.g. a MP3 player to a play back event of a music track.</para>
    ///   <a href="http://purl.org/ontology/ao/core#used_device">ao:used_device</a>
    /// </summary>
    let used_device = _prefixId.prefix "used_device"
