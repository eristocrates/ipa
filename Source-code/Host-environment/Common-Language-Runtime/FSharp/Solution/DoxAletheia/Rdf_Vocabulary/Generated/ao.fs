namespace http.purl.org.ontology.ao.core.hash

open DoxAletheia.Rdf_Vocabulary

module ao =
    let _namespace_name = "http://purl.org/ontology/ao/core#"

    /// <summary>
    /// A likeable association. That means this association type is intended to be used for voting (ao:likeminded),
    /// feedbacking (rev:Feedback), reviewing (e.g. rev:rating) an association statement (related by ao:included_association) in the
    /// context of something.
    /// <see href="http://purl.org/ontology/ao/core#LikeableAssociation"></see></summary>
    let LikeableAssociation =
        Namespaced_IRI.parse _namespace_name "LikeableAssociation" |> NamespacedName

    /// <summary>
    /// An activity, which is associated to an individual, e.g. dancing, sleeping, driving.
    /// <see href="http://purl.org/ontology/ao/core#activity"></see></summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName
    /// <summary>
    /// A property to associate any environmental context to an individual, e.g. a location, a time or an activity. Hence, this property is intended that sub properties should be created from it.
    /// <see href="http://purl.org/ontology/ao/core#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName

    /// <summary>
    /// An application, which is associated to an individual, e.g. a music player to a music track it's currently playing back.
    /// <see href="http://purl.org/ontology/ao/core#application"></see></summary>
    let application =
        Namespaced_IRI.parse _namespace_name "application" |> NamespacedName

    /// <summary>
    /// A device, which is associated with an individual, e.g. a CD player with a CD it's currently playing back.
    /// <see href="http://purl.org/ontology/ao/core#device"></see></summary>
    let device = Namespaced_IRI.parse _namespace_name "device" |> NamespacedName
    /// <summary>
    /// An genre of something.
    /// <see href="http://purl.org/ontology/ao/core#genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName

    /// <summary>
    /// This property could be used to compose association statements or to reuse them, e.g. to make them likeable
    /// in a specific context.
    /// <see href="http://purl.org/ontology/ao/core#included_association"></see></summary>
    let included_association =
        Namespaced_IRI.parse _namespace_name "included_association" |> NamespacedName

    /// <summary>
    /// Associates likeminded people to an association, which they like/ agree with.
    /// <see href="http://purl.org/ontology/ao/core#likeminded"></see></summary>
    let likeminded = Namespaced_IRI.parse _namespace_name "likeminded" |> NamespacedName
    /// <summary>
    /// A location, which is associated to an individual, e.g. my house, my country, my current whereabouts.
    /// <see href="http://purl.org/ontology/ao/core#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// A mood that should be created by something.
    /// <see href="http://purl.org/ontology/ao/core#mood"></see></summary>
    let mood = Namespaced_IRI.parse _namespace_name "mood" |> NamespacedName
    /// <summary>
    /// An occasion for which something was created.
    /// <see href="http://purl.org/ontology/ao/core#occasion"></see></summary>
    let occasion = Namespaced_IRI.parse _namespace_name "occasion" |> NamespacedName
    /// <summary>
    /// A time, which is associated to an individual, e.g. morning, afternoon, evening.
    /// <see href="http://purl.org/ontology/ao/core#time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName

    /// <summary>
    /// An application that is related to an event, e.g. a iTunes to a play back event of a music track.
    /// <see href="http://purl.org/ontology/ao/core#used_application"></see></summary>
    let used_application =
        Namespaced_IRI.parse _namespace_name "used_application" |> NamespacedName

    /// <summary>
    /// A device that is related to an event, e.g. a MP3 player to a play back event of a music track.
    /// <see href="http://purl.org/ontology/ao/core#used_device"></see></summary>
    let used_device =
        Namespaced_IRI.parse _namespace_name "used_device" |> NamespacedName
