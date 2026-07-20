namespace http.purl.org.ontology.ao.core.hash

open DoxAletheia

module ao =
    let _namespace_name = "http://purl.org/ontology/ao/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A likeable association. That means this association type is intended to be used for voting (ao:likeminded),
    /// feedbacking (rev:Feedback), reviewing (e.g. rev:rating) an association statement (related by ao:included_association) in the
    /// context of something.
    /// <see href="http://purl.org/ontology/ao/core#LikeableAssociation"></see></summary>
    let LikeableAssociation = _prefix "LikeableAssociation"
    /// <summary>
    /// An activity, which is associated to an individual, e.g. dancing, sleeping, driving.
    /// <see href="http://purl.org/ontology/ao/core#activity"></see></summary>
    let activity = _prefix "activity"
    /// <summary>
    /// A property to associate any environmental context to an individual, e.g. a location, a time or an activity. Hence, this property is intended that sub properties should be created from it.
    /// <see href="http://purl.org/ontology/ao/core#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    /// An application, which is associated to an individual, e.g. a music player to a music track it's currently playing back.
    /// <see href="http://purl.org/ontology/ao/core#application"></see></summary>
    let application = _prefix "application"
    /// <summary>
    /// A device, which is associated with an individual, e.g. a CD player with a CD it's currently playing back.
    /// <see href="http://purl.org/ontology/ao/core#device"></see></summary>
    let device = _prefix "device"
    /// <summary>
    /// An genre of something.
    /// <see href="http://purl.org/ontology/ao/core#genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// This property could be used to compose association statements or to reuse them, e.g. to make them likeable
    /// in a specific context.
    /// <see href="http://purl.org/ontology/ao/core#included_association"></see></summary>
    let included_association = _prefix "included_association"
    /// <summary>
    /// Associates likeminded people to an association, which they like/ agree with.
    /// <see href="http://purl.org/ontology/ao/core#likeminded"></see></summary>
    let likeminded = _prefix "likeminded"
    /// <summary>
    /// A location, which is associated to an individual, e.g. my house, my country, my current whereabouts.
    /// <see href="http://purl.org/ontology/ao/core#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// A mood that should be created by something.
    /// <see href="http://purl.org/ontology/ao/core#mood"></see></summary>
    let mood = _prefix "mood"
    /// <summary>
    /// An occasion for which something was created.
    /// <see href="http://purl.org/ontology/ao/core#occasion"></see></summary>
    let occasion = _prefix "occasion"
    /// <summary>
    /// A time, which is associated to an individual, e.g. morning, afternoon, evening.
    /// <see href="http://purl.org/ontology/ao/core#time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    /// An application that is related to an event, e.g. a iTunes to a play back event of a music track.
    /// <see href="http://purl.org/ontology/ao/core#used_application"></see></summary>
    let used_application = _prefix "used_application"
    /// <summary>
    /// A device that is related to an event, e.g. a MP3 player to a play back event of a music track.
    /// <see href="http://purl.org/ontology/ao/core#used_device"></see></summary>
    let used_device = _prefix "used_device"
