namespace http.purl.org.net.soron.slash

open DoxAletheia.Rdf_Vocabulary

module sor =
    let _namespace_name = "http://purl.org/net/soron/"
    /// <summary>
    ///   <see href="http://purl.org/net/soron/0.1"></see>
    /// </summary>
    let ``_0.1`` = Namespaced_IRI.parse _namespace_name "0.1" |> NamespacedName

    /// <summary>
    /// Describes that a person is perceived negatively by another.
    /// <see href="http://purl.org/net/soron/FeltNegativelyBy"></see></summary>
    let FeltNegativelyBy =
        Namespaced_IRI.parse _namespace_name "FeltNegativelyBy" |> NamespacedName

    /// <summary>
    /// Describes any kind of social relationship that may appear in society.
    /// <see href="http://purl.org/net/soron/hasSocialRelationship"></see></summary>
    let hasSocialRelationship =
        Namespaced_IRI.parse _namespace_name "hasSocialRelationship" |> NamespacedName

    /// <summary>
    /// Describes a person that knows another but there is no strong personal relationship between them.
    /// <see href="http://purl.org/net/soron/acquaintanceOf"></see></summary>
    let acquaintanceOf =
        Namespaced_IRI.parse _namespace_name "acquaintanceOf" |> NamespacedName

    /// <summary>
    /// Describes that a person has a personal, close relationship (not family related) with another.
    /// <see href="http://purl.org/net/soron/hasPersonalRelationshipWith"></see></summary>
    let hasPersonalRelationshipWith =
        Namespaced_IRI.parse _namespace_name "hasPersonalRelationshipWith" |> NamespacedName

    /// <summary>
    /// Describes that a person is admired by another.
    /// <see href="http://purl.org/net/soron/admiredBy"></see></summary>
    let admiredBy = Namespaced_IRI.parse _namespace_name "admiredBy" |> NamespacedName

    /// <summary>
    /// Describes that a person is being perceived positively by another.
    /// <see href="http://purl.org/net/soron/feltPositivelyBy"></see></summary>
    let feltPositivelyBy =
        Namespaced_IRI.parse _namespace_name "feltPositivelyBy" |> NamespacedName

    /// <summary>
    /// Describes that an individual feels admiration for another.
    /// <see href="http://purl.org/net/soron/admires"></see></summary>
    let admires = Namespaced_IRI.parse _namespace_name "admires" |> NamespacedName

    /// <summary>
    /// Describes that a person has positive feelings about another.
    /// <see href="http://purl.org/net/soron/hasPositiveFeelingsFor"></see></summary>
    let hasPositiveFeelingsFor =
        Namespaced_IRI.parse _namespace_name "hasPositiveFeelingsFor" |> NamespacedName

    /// <summary>
    /// Describes that a person is ambivalent of another.
    /// <see href="http://purl.org/net/soron/ambivalentOf"></see></summary>
    let ambivalentOf =
        Namespaced_IRI.parse _namespace_name "ambivalentOf" |> NamespacedName

    /// <summary>
    /// Describes that a person has neutral (mixed) feelings for another.
    /// <see href="http://purl.org/net/soron/hasNeutralFeelingsFor"></see></summary>
    let hasNeutralFeelingsFor =
        Namespaced_IRI.parse _namespace_name "hasNeutralFeelingsFor" |> NamespacedName

    /// <summary>
    /// Describes that a person perceives another as antagonist.
    /// <see href="http://purl.org/net/soron/antagonistOf"></see></summary>
    let antagonistOf =
        Namespaced_IRI.parse _namespace_name "antagonistOf" |> NamespacedName

    /// <summary>
    /// Describes that a person has negative feelings for another.
    /// <see href="http://purl.org/net/soron/hasNegativeFeelingsFor"></see></summary>
    let hasNegativeFeelingsFor =
        Namespaced_IRI.parse _namespace_name "hasNegativeFeelingsFor" |> NamespacedName

    /// <summary>
    /// Describes that a person is appreciated by another.
    /// <see href="http://purl.org/net/soron/appreciatedBy"></see></summary>
    let appreciatedBy =
        Namespaced_IRI.parse _namespace_name "appreciatedBy" |> NamespacedName

    /// <summary>
    /// Describes that an individual appreciates another person.
    /// <see href="http://purl.org/net/soron/appreciates"></see></summary>
    let appreciates =
        Namespaced_IRI.parse _namespace_name "appreciates" |> NamespacedName

    /// <summary>
    /// Describes the relationship between an apprentice and their master (in any kind of profession).
    /// <see href="http://purl.org/net/soron/apprenticeIs"></see></summary>
    let apprenticeIs =
        Namespaced_IRI.parse _namespace_name "apprenticeIs" |> NamespacedName

    /// <summary>
    /// Describes the relationship between the person that hires and the hired person.
    /// <see href="http://purl.org/net/soron/employs"></see></summary>
    let employs = Namespaced_IRI.parse _namespace_name "employs" |> NamespacedName

    /// <summary>
    /// Describes the relationship between an individual and their apprentice (in any kind of profession).
    /// <see href="http://purl.org/net/soron/apprenticeTo"></see></summary>
    let apprenticeTo =
        Namespaced_IRI.parse _namespace_name "apprenticeTo" |> NamespacedName

    /// <summary>
    /// Describes the relationship between a particular individual and the person that hires them.
    /// <see href="http://purl.org/net/soron/worksFor"></see></summary>
    let worksFor = Namespaced_IRI.parse _namespace_name "worksFor" |> NamespacedName

    /// <summary>
    /// Describes that a person works as assistant for someone else.
    /// <see href="http://purl.org/net/soron/assistantFor"></see></summary>
    let assistantFor =
        Namespaced_IRI.parse _namespace_name "assistantFor" |> NamespacedName

    /// <summary>
    /// Describes that a person has someone working for them as assistant.
    /// <see href="http://purl.org/net/soron/assistedBy"></see></summary>
    let assistedBy = Namespaced_IRI.parse _namespace_name "assistedBy" |> NamespacedName

    /// <summary>
    /// Describes that a person is associate of another.
    /// <see href="http://purl.org/net/soron/associateOf"></see></summary>
    let associateOf =
        Namespaced_IRI.parse _namespace_name "associateOf" |> NamespacedName

    /// <summary>
    /// Describes the relationship between two individuals working together in paid or unpaid tasks in any kind of context/organization.
    /// <see href="http://purl.org/net/soron/worksWith"></see></summary>
    let worksWith = Namespaced_IRI.parse _namespace_name "worksWith" |> NamespacedName
    /// <summary>
    /// Describes that an individual's words/ideas/works have been cited by someone  else. It does not imply that the cited individual has any knowledge of the citing individual or the fact that they had been cited.
    /// <see href="http://purl.org/net/soron/citedBy"></see></summary>
    let citedBy = Namespaced_IRI.parse _namespace_name "citedBy" |> NamespacedName
    /// <summary>
    /// Describes that a person is known by another.
    /// <see href="http://purl.org/net/soron/knownBy"></see></summary>
    let knownBy = Namespaced_IRI.parse _namespace_name "knownBy" |> NamespacedName
    /// <summary>
    /// Describes an individual's knowledge of someone else and their work by citing their words/ideas/works. It does not imply physical/real knowledge of the cited individual.
    /// <see href="http://purl.org/net/soron/cites"></see></summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName
    /// <summary>
    /// Describes the relationship between two individuals that know each other.
    /// <see href="http://purl.org/net/soron/knows"></see></summary>
    let knows = Namespaced_IRI.parse _namespace_name "knows" |> NamespacedName

    /// <summary>
    /// Describes that a person coauthors a work with someone else.
    /// <see href="http://purl.org/net/soron/coauthorsWith"></see></summary>
    let coauthorsWith =
        Namespaced_IRI.parse _namespace_name "coauthorsWith" |> NamespacedName

    /// <summary>
    /// Describes that a person collaborates with another in a particular task/project/work.
    /// <see href="http://purl.org/net/soron/collaboratesWith"></see></summary>
    let collaboratesWith =
        Namespaced_IRI.parse _namespace_name "collaboratesWith" |> NamespacedName

    /// <summary>
    /// Describes that a person is colleague of someone else (work related).
    /// <see href="http://purl.org/net/soron/colleagueOf"></see></summary>
    let colleagueOf =
        Namespaced_IRI.parse _namespace_name "colleagueOf" |> NamespacedName

    /// <summary>
    /// Describes that a person is critizised by another.
    /// <see href="http://purl.org/net/soron/critizisedBy"></see></summary>
    let critizisedBy =
        Namespaced_IRI.parse _namespace_name "critizisedBy" |> NamespacedName

    /// <summary>
    /// Describes that a person critizises another.
    /// <see href="http://purl.org/net/soron/critizises"></see></summary>
    let critizises = Namespaced_IRI.parse _namespace_name "critizises" |> NamespacedName

    /// <summary>
    /// Describes that a person is disagreed by another.
    /// <see href="http://purl.org/net/soron/disagreedBy"></see></summary>
    let disagreedBy =
        Namespaced_IRI.parse _namespace_name "disagreedBy" |> NamespacedName

    /// <summary>
    /// Describes that a person disagrees with another.
    /// <see href="http://purl.org/net/soron/disagreesWith"></see></summary>
    let disagreesWith =
        Namespaced_IRI.parse _namespace_name "disagreesWith" |> NamespacedName

    /// <summary>
    /// Describes that a person is disliked by another.
    /// <see href="http://purl.org/net/soron/dislikedBy"></see></summary>
    let dislikedBy = Namespaced_IRI.parse _namespace_name "dislikedBy" |> NamespacedName
    /// <summary>
    /// Describes that a person dislikes another.
    /// <see href="http://purl.org/net/soron/dislikes"></see></summary>
    let dislikes = Namespaced_IRI.parse _namespace_name "dislikes" |> NamespacedName
    /// <summary>
    /// Describes that a person is the enemy of another.
    /// <see href="http://purl.org/net/soron/enemyOf"></see></summary>
    let enemyOf = Namespaced_IRI.parse _namespace_name "enemyOf" |> NamespacedName

    /// <summary>
    /// Describes that a person studies with someone else.
    /// <see href="http://purl.org/net/soron/fellowStudentOf"></see></summary>
    let fellowStudentOf =
        Namespaced_IRI.parse _namespace_name "fellowStudentOf" |> NamespacedName

    /// <summary>
    /// Describes that a person is felt ambivalently by another.
    /// <see href="http://purl.org/net/soron/feltAmbivalentBy"></see></summary>
    let feltAmbivalentBy =
        Namespaced_IRI.parse _namespace_name "feltAmbivalentBy" |> NamespacedName

    /// <summary>
    /// Describes that a person is being perceived neutrally (mixed feelings) by  another.
    /// <see href="http://purl.org/net/soron/feltNeutrallyBy"></see></summary>
    let feltNeutrallyBy =
        Namespaced_IRI.parse _namespace_name "feltNeutrallyBy" |> NamespacedName

    /// <summary>
    /// Describes that a person is perceived as antagonist by another.
    /// <see href="http://purl.org/net/soron/feltAntagonistBy"></see></summary>
    let feltAntagonistBy =
        Namespaced_IRI.parse _namespace_name "feltAntagonistBy" |> NamespacedName

    /// <summary>
    /// Describes that a person is perceived as enemy by another.
    /// <see href="http://purl.org/net/soron/feltEnemyBy"></see></summary>
    let feltEnemyBy =
        Namespaced_IRI.parse _namespace_name "feltEnemyBy" |> NamespacedName

    /// <summary>
    /// Describes that a person has a strong personal relationship with another.
    /// <see href="http://purl.org/net/soron/friendOf"></see></summary>
    let friendOf = Namespaced_IRI.parse _namespace_name "friendOf" |> NamespacedName
    /// <summary>
    /// Describes that a person has heard of another.
    /// <see href="http://purl.org/net/soron/hasHeardOf"></see></summary>
    let hasHeardOf = Namespaced_IRI.parse _namespace_name "hasHeardOf" |> NamespacedName
    /// <summary>
    /// Describes that a person has met another. It usually implies some kind of physical interaction, but it may also happen virtually.
    /// <see href="http://purl.org/net/soron/hasMet"></see></summary>
    let hasMet = Namespaced_IRI.parse _namespace_name "hasMet" |> NamespacedName
    /// <summary>
    /// Describes that a person is hated by another.
    /// <see href="http://purl.org/net/soron/hatedBy"></see></summary>
    let hatedBy = Namespaced_IRI.parse _namespace_name "hatedBy" |> NamespacedName
    /// <summary>
    /// Describes that a person hates another.
    /// <see href="http://purl.org/net/soron/hates"></see></summary>
    let hates = Namespaced_IRI.parse _namespace_name "hates" |> NamespacedName
    /// <summary>
    /// Describes that an individual is paid by another to do some kind of work.
    /// <see href="http://purl.org/net/soron/hiredBy"></see></summary>
    let hiredBy = Namespaced_IRI.parse _namespace_name "hiredBy" |> NamespacedName
    /// <summary>
    /// Describes that an individual pays someone else to do some kind of work.
    /// <see href="http://purl.org/net/soron/hires"></see></summary>
    let hires = Namespaced_IRI.parse _namespace_name "hires" |> NamespacedName

    /// <summary>
    /// Describes that a person is in cahoots with someone else.
    /// <see href="http://purl.org/net/soron/inCahootsWith"></see></summary>
    let inCahootsWith =
        Namespaced_IRI.parse _namespace_name "inCahootsWith" |> NamespacedName

    /// <summary>
    /// Describes that a particular person has been influenced by another individual (writer, artist, etc.).
    /// <see href="http://purl.org/net/soron/influencedBy"></see></summary>
    let influencedBy =
        Namespaced_IRI.parse _namespace_name "influencedBy" |> NamespacedName

    /// <summary>
    /// Describes that a particular person has had some kind of influence on another individual. It does not imply that the person that has that influence on the other is aware of that influence at all.
    /// <see href="http://purl.org/net/soron/influences"></see></summary>
    let influences = Namespaced_IRI.parse _namespace_name "influences" |> NamespacedName
    /// <summary>
    /// Describes that a person is liked by another.
    /// <see href="http://purl.org/net/soron/likedBy"></see></summary>
    let likedBy = Namespaced_IRI.parse _namespace_name "likedBy" |> NamespacedName
    /// <summary>
    /// Describes that an individual likes another.
    /// <see href="http://purl.org/net/soron/likes"></see></summary>
    let likes = Namespaced_IRI.parse _namespace_name "likes" |> NamespacedName
    /// <summary>
    /// Describes that a person is loved by another.
    /// <see href="http://purl.org/net/soron/lovedBy"></see></summary>
    let lovedBy = Namespaced_IRI.parse _namespace_name "lovedBy" |> NamespacedName
    /// <summary>
    /// Describes that a peson is the lover of someone else.
    /// <see href="http://purl.org/net/soron/loverOf"></see></summary>
    let loverOf = Namespaced_IRI.parse _namespace_name "loverOf" |> NamespacedName
    /// <summary>
    /// Describes that an individual loves another.
    /// <see href="http://purl.org/net/soron/loves"></see></summary>
    let loves = Namespaced_IRI.parse _namespace_name "loves" |> NamespacedName
    /// <summary>
    /// Describes the relationship between an individual and their master (particularly used in art, craftmanship, etc.). Example: Anthony Van Dick masterIs Rubens (it implies that Van Dick worked for Rubens' studio).
    /// <see href="http://purl.org/net/soron/masterIs"></see></summary>
    let masterIs = Namespaced_IRI.parse _namespace_name "masterIs" |> NamespacedName
    /// <summary>
    /// Describes the relationship between an expert/master and their apprentice (particularly used in art, craftmanship, etc.). Example: Rubens masterOf Anthony Van Dick   (it implies that Rubens hired Van Dick as apprentice in his studio).
    /// <see href="http://purl.org/net/soron/masterOf"></see></summary>
    let masterOf = Namespaced_IRI.parse _namespace_name "masterOf" |> NamespacedName
    /// <summary>
    /// Describes the relationship between a mentee (in an academic setting, the student) and a mentor. It implies that it is an unpaid relationship.
    /// <see href="http://purl.org/net/soron/menteeOf"></see></summary>
    let menteeOf = Namespaced_IRI.parse _namespace_name "menteeOf" |> NamespacedName
    /// <summary>
    /// Describes the relationship between a mentor and a mentee (for instance a supervisor in an academic setting). It implies that it is an unpaid relationship.
    /// <see href="http://purl.org/net/soron/mentorOf"></see></summary>
    let mentorOf = Namespaced_IRI.parse _namespace_name "mentorOf" |> NamespacedName

    /// <summary>
    /// Describes that an individual has been mentioned/referred to by another. It does not imply that the person that is being mentioned knows the person that mentions him/her.
    /// <see href="http://purl.org/net/soron/mentionedBy"></see></summary>
    let mentionedBy =
        Namespaced_IRI.parse _namespace_name "mentionedBy" |> NamespacedName

    /// <summary>
    /// Describes that the name of an individual has been mentioned by another.
    /// <see href="http://purl.org/net/soron/mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName
    /// <summary>
    /// Describes that a person (usually an artist or intellectual) is sponsored by another.
    /// <see href="http://purl.org/net/soron/patronIs"></see></summary>
    let patronIs = Namespaced_IRI.parse _namespace_name "patronIs" |> NamespacedName
    /// <summary>
    /// Describes that a person sponsors the work of another (usually an artist or intellectual).
    /// <see href="http://purl.org/net/soron/patronOf"></see></summary>
    let patronOf = Namespaced_IRI.parse _namespace_name "patronOf" |> NamespacedName

    /// <summary>
    /// Describes that an artist (musicians, artists, etc.) performs with another.
    /// <see href="http://purl.org/net/soron/performsWith"></see></summary>
    let performsWith =
        Namespaced_IRI.parse _namespace_name "performsWith" |> NamespacedName

    /// <summary>
    /// Describes that a person is rejected by another.
    /// <see href="http://purl.org/net/soron/rejectedBy"></see></summary>
    let rejectedBy = Namespaced_IRI.parse _namespace_name "rejectedBy" |> NamespacedName
    /// <summary>
    /// Describes that a person rejects another.
    /// <see href="http://purl.org/net/soron/rejects"></see></summary>
    let rejects = Namespaced_IRI.parse _namespace_name "rejects" |> NamespacedName

    /// <summary>
    /// Describes that someone is work partner of someone else.
    /// <see href="http://purl.org/net/soron/workPartnerOf"></see></summary>
    let workPartnerOf =
        Namespaced_IRI.parse _namespace_name "workPartnerOf" |> NamespacedName
