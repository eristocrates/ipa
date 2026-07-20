namespace http.www.kanzaki.com.ns.whois.hash

open DoxAletheia

module whois =
    let _namespace_name = "http://www.kanzaki.com/ns/whois#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A period of education in one's academic career, as a stage of life. NOT an activity of learning.
    /// <see href="http://www.kanzaki.com/ns/whois#Education"></see></summary>
    let Education = _prefix "Education"
    /// <summary>
    /// A stage of life. A distinct time period in a sequence of one's life cycle.
    /// <see href="http://www.kanzaki.com/ns/whois#Stage"></see></summary>
    let Stage = _prefix "Stage"
    /// <summary>
    /// A period of job in one's professional career, as a stage of life. NOT an activity of working.
    /// <see href="http://www.kanzaki.com/ns/whois#Job"></see></summary>
    let Job = _prefix "Job"
    /// <summary>
    /// A place -- this can be the domain of both contact: vocab and geo: vocab.
    /// <see href="http://www.kanzaki.com/ns/whois#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// an educational career in one's personal history.
    /// <see href="http://www.kanzaki.com/ns/whois#academicCareer"></see></summary>
    let academicCareer = _prefix "academicCareer"
    /// <summary>
    /// A job, education or any achievement in one's life, which can be specific to a stage of life (object = #Stage) or in general (object = any).
    /// <see href="http://www.kanzaki.com/ns/whois#career"></see></summary>
    let career = _prefix "career"
    /// <summary>
    /// a one's achievement in general. Note you can use foaf:pastProject for a specific achievement.
    /// <see href="http://www.kanzaki.com/ns/whois#achievement"></see></summary>
    let achievement = _prefix "achievement"
    /// <summary>
    /// One's birthday. This can be used in place of 'whois:since' where the 'whois:Stage' is one's first stage.
    /// <see href="http://www.kanzaki.com/ns/whois#born"></see></summary>
    let born = _prefix "born"
    /// <summary>
    /// date when a stage of life started.
    /// <see href="http://www.kanzaki.com/ns/whois#since"></see></summary>
    let since = _prefix "since"
    /// <summary>
    /// General description of a person's activities. Use to describe something that does not fit into a Stage.
    /// <see href="http://www.kanzaki.com/ns/whois#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// an honor that one has been rewarded.
    /// <see href="http://www.kanzaki.com/ns/whois#honor"></see></summary>
    let honor = _prefix "honor"
    /// <summary>
    /// Place which relates to a stage of life. Literal version of 'where'. ":x whois:place 'y'." implies ":x whois:where [rdfs:label 'y'].".
    /// <see href="http://www.kanzaki.com/ns/whois#place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    /// General description of a person's future activities. Note past activity can be described with #career.
    /// <see href="http://www.kanzaki.com/ns/whois#plan"></see></summary>
    let plan = _prefix "plan"
    /// <summary>
    /// a professional or business career in one's personal history.
    /// <see href="http://www.kanzaki.com/ns/whois#professionalCareer"></see></summary>
    let professionalCareer = _prefix "professionalCareer"
    /// <summary>
    /// a one's publication in general. Note foaf:publications describes publication list page.
    /// <see href="http://www.kanzaki.com/ns/whois#publication"></see></summary>
    let publication = _prefix "publication"
    /// <summary>
    /// date/time which is related to a stage of life. Super property of since and until. W3C-DTF format value is assumed (i.e. can be yyyy, yyyy-mm, yyyy-mm-dd etc).
    /// <see href="http://www.kanzaki.com/ns/whois#when"></see></summary>
    let when_ = _prefix "when"
    /// <summary>
    /// Describes an aspect of one's personal history.
    /// <see href="http://www.kanzaki.com/ns/whois#stage"></see></summary>
    let stage = _prefix "stage"
    /// <summary>
    /// date when a stage of life ended.
    /// <see href="http://www.kanzaki.com/ns/whois#until"></see></summary>
    let until = _prefix "until"
    /// <summary>
    /// Specifies a topic in a stage of life. The range is owl:Thing to have structured description. Use dc:description for literal description, or dc:subject for keywords.
    /// <see href="http://www.kanzaki.com/ns/whois#what"></see></summary>
    let what = _prefix "what"
    /// <summary>
    /// Place which relates to a stage of life. The range is whois:Place to have structured description. Use bio:place for literal value
    /// <see href="http://www.kanzaki.com/ns/whois#where"></see></summary>
    let where = _prefix "where"
