namespace http.purl.org.net.soron.slash

open DoxAletheia

module sor =
    let _namespace_name = "http://purl.org/net/soron/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/soron/0.1"></see>
    /// </summary>
    let ``_0.1`` = _prefix "0.1"
    /// <summary>
    /// Describes that a person is perceived negatively by another.
    /// <see href="http://purl.org/net/soron/FeltNegativelyBy"></see></summary>
    let FeltNegativelyBy = _prefix "FeltNegativelyBy"
    /// <summary>
    /// Describes any kind of social relationship that may appear in society.
    /// <see href="http://purl.org/net/soron/hasSocialRelationship"></see></summary>
    let hasSocialRelationship = _prefix "hasSocialRelationship"
    /// <summary>
    /// Describes a person that knows another but there is no strong personal relationship between them.
    /// <see href="http://purl.org/net/soron/acquaintanceOf"></see></summary>
    let acquaintanceOf = _prefix "acquaintanceOf"
    /// <summary>
    /// Describes that a person has a personal, close relationship (not family related) with another.
    /// <see href="http://purl.org/net/soron/hasPersonalRelationshipWith"></see></summary>
    let hasPersonalRelationshipWith = _prefix "hasPersonalRelationshipWith"
    /// <summary>
    /// Describes that a person is admired by another.
    /// <see href="http://purl.org/net/soron/admiredBy"></see></summary>
    let admiredBy = _prefix "admiredBy"
    /// <summary>
    /// Describes that a person is being perceived positively by another.
    /// <see href="http://purl.org/net/soron/feltPositivelyBy"></see></summary>
    let feltPositivelyBy = _prefix "feltPositivelyBy"
    /// <summary>
    /// Describes that an individual feels admiration for another.
    /// <see href="http://purl.org/net/soron/admires"></see></summary>
    let admires = _prefix "admires"
    /// <summary>
    /// Describes that a person has positive feelings about another.
    /// <see href="http://purl.org/net/soron/hasPositiveFeelingsFor"></see></summary>
    let hasPositiveFeelingsFor = _prefix "hasPositiveFeelingsFor"
    /// <summary>
    /// Describes that a person is ambivalent of another.
    /// <see href="http://purl.org/net/soron/ambivalentOf"></see></summary>
    let ambivalentOf = _prefix "ambivalentOf"
    /// <summary>
    /// Describes that a person has neutral (mixed) feelings for another.
    /// <see href="http://purl.org/net/soron/hasNeutralFeelingsFor"></see></summary>
    let hasNeutralFeelingsFor = _prefix "hasNeutralFeelingsFor"
    /// <summary>
    /// Describes that a person perceives another as antagonist.
    /// <see href="http://purl.org/net/soron/antagonistOf"></see></summary>
    let antagonistOf = _prefix "antagonistOf"
    /// <summary>
    /// Describes that a person has negative feelings for another.
    /// <see href="http://purl.org/net/soron/hasNegativeFeelingsFor"></see></summary>
    let hasNegativeFeelingsFor = _prefix "hasNegativeFeelingsFor"
    /// <summary>
    /// Describes that a person is appreciated by another.
    /// <see href="http://purl.org/net/soron/appreciatedBy"></see></summary>
    let appreciatedBy = _prefix "appreciatedBy"
    /// <summary>
    /// Describes that an individual appreciates another person.
    /// <see href="http://purl.org/net/soron/appreciates"></see></summary>
    let appreciates = _prefix "appreciates"
    /// <summary>
    /// Describes the relationship between an apprentice and their master (in any kind of profession).
    /// <see href="http://purl.org/net/soron/apprenticeIs"></see></summary>
    let apprenticeIs = _prefix "apprenticeIs"
    /// <summary>
    /// Describes the relationship between the person that hires and the hired person.
    /// <see href="http://purl.org/net/soron/employs"></see></summary>
    let employs = _prefix "employs"
    /// <summary>
    /// Describes the relationship between an individual and their apprentice (in any kind of profession).
    /// <see href="http://purl.org/net/soron/apprenticeTo"></see></summary>
    let apprenticeTo = _prefix "apprenticeTo"
    /// <summary>
    /// Describes the relationship between a particular individual and the person that hires them.
    /// <see href="http://purl.org/net/soron/worksFor"></see></summary>
    let worksFor = _prefix "worksFor"
    /// <summary>
    /// Describes that a person works as assistant for someone else.
    /// <see href="http://purl.org/net/soron/assistantFor"></see></summary>
    let assistantFor = _prefix "assistantFor"
    /// <summary>
    /// Describes that a person has someone working for them as assistant.
    /// <see href="http://purl.org/net/soron/assistedBy"></see></summary>
    let assistedBy = _prefix "assistedBy"
    /// <summary>
    /// Describes that a person is associate of another.
    /// <see href="http://purl.org/net/soron/associateOf"></see></summary>
    let associateOf = _prefix "associateOf"
    /// <summary>
    /// Describes the relationship between two individuals working together in paid or unpaid tasks in any kind of context/organization.
    /// <see href="http://purl.org/net/soron/worksWith"></see></summary>
    let worksWith = _prefix "worksWith"
    /// <summary>
    /// Describes that an individual's words/ideas/works have been cited by someone  else. It does not imply that the cited individual has any knowledge of the citing individual or the fact that they had been cited.
    /// <see href="http://purl.org/net/soron/citedBy"></see></summary>
    let citedBy = _prefix "citedBy"
    /// <summary>
    /// Describes that a person is known by another.
    /// <see href="http://purl.org/net/soron/knownBy"></see></summary>
    let knownBy = _prefix "knownBy"
    /// <summary>
    /// Describes an individual's knowledge of someone else and their work by citing their words/ideas/works. It does not imply physical/real knowledge of the cited individual.
    /// <see href="http://purl.org/net/soron/cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    /// Describes the relationship between two individuals that know each other.
    /// <see href="http://purl.org/net/soron/knows"></see></summary>
    let knows = _prefix "knows"
    /// <summary>
    /// Describes that a person coauthors a work with someone else.
    /// <see href="http://purl.org/net/soron/coauthorsWith"></see></summary>
    let coauthorsWith = _prefix "coauthorsWith"
    /// <summary>
    /// Describes that a person collaborates with another in a particular task/project/work.
    /// <see href="http://purl.org/net/soron/collaboratesWith"></see></summary>
    let collaboratesWith = _prefix "collaboratesWith"
    /// <summary>
    /// Describes that a person is colleague of someone else (work related).
    /// <see href="http://purl.org/net/soron/colleagueOf"></see></summary>
    let colleagueOf = _prefix "colleagueOf"
    /// <summary>
    /// Describes that a person is critizised by another.
    /// <see href="http://purl.org/net/soron/critizisedBy"></see></summary>
    let critizisedBy = _prefix "critizisedBy"
    /// <summary>
    /// Describes that a person critizises another.
    /// <see href="http://purl.org/net/soron/critizises"></see></summary>
    let critizises = _prefix "critizises"
    /// <summary>
    /// Describes that a person is disagreed by another.
    /// <see href="http://purl.org/net/soron/disagreedBy"></see></summary>
    let disagreedBy = _prefix "disagreedBy"
    /// <summary>
    /// Describes that a person disagrees with another.
    /// <see href="http://purl.org/net/soron/disagreesWith"></see></summary>
    let disagreesWith = _prefix "disagreesWith"
    /// <summary>
    /// Describes that a person is disliked by another.
    /// <see href="http://purl.org/net/soron/dislikedBy"></see></summary>
    let dislikedBy = _prefix "dislikedBy"
    /// <summary>
    /// Describes that a person dislikes another.
    /// <see href="http://purl.org/net/soron/dislikes"></see></summary>
    let dislikes = _prefix "dislikes"
    /// <summary>
    /// Describes that a person is the enemy of another.
    /// <see href="http://purl.org/net/soron/enemyOf"></see></summary>
    let enemyOf = _prefix "enemyOf"
    /// <summary>
    /// Describes that a person studies with someone else.
    /// <see href="http://purl.org/net/soron/fellowStudentOf"></see></summary>
    let fellowStudentOf = _prefix "fellowStudentOf"
    /// <summary>
    /// Describes that a person is felt ambivalently by another.
    /// <see href="http://purl.org/net/soron/feltAmbivalentBy"></see></summary>
    let feltAmbivalentBy = _prefix "feltAmbivalentBy"
    /// <summary>
    /// Describes that a person is being perceived neutrally (mixed feelings) by  another.
    /// <see href="http://purl.org/net/soron/feltNeutrallyBy"></see></summary>
    let feltNeutrallyBy = _prefix "feltNeutrallyBy"
    /// <summary>
    /// Describes that a person is perceived as antagonist by another.
    /// <see href="http://purl.org/net/soron/feltAntagonistBy"></see></summary>
    let feltAntagonistBy = _prefix "feltAntagonistBy"
    /// <summary>
    /// Describes that a person is perceived as enemy by another.
    /// <see href="http://purl.org/net/soron/feltEnemyBy"></see></summary>
    let feltEnemyBy = _prefix "feltEnemyBy"
    /// <summary>
    /// Describes that a person has a strong personal relationship with another.
    /// <see href="http://purl.org/net/soron/friendOf"></see></summary>
    let friendOf = _prefix "friendOf"
    /// <summary>
    /// Describes that a person has heard of another.
    /// <see href="http://purl.org/net/soron/hasHeardOf"></see></summary>
    let hasHeardOf = _prefix "hasHeardOf"
    /// <summary>
    /// Describes that a person has met another. It usually implies some kind of physical interaction, but it may also happen virtually.
    /// <see href="http://purl.org/net/soron/hasMet"></see></summary>
    let hasMet = _prefix "hasMet"
    /// <summary>
    /// Describes that a person is hated by another.
    /// <see href="http://purl.org/net/soron/hatedBy"></see></summary>
    let hatedBy = _prefix "hatedBy"
    /// <summary>
    /// Describes that a person hates another.
    /// <see href="http://purl.org/net/soron/hates"></see></summary>
    let hates = _prefix "hates"
    /// <summary>
    /// Describes that an individual is paid by another to do some kind of work.
    /// <see href="http://purl.org/net/soron/hiredBy"></see></summary>
    let hiredBy = _prefix "hiredBy"
    /// <summary>
    /// Describes that an individual pays someone else to do some kind of work.
    /// <see href="http://purl.org/net/soron/hires"></see></summary>
    let hires = _prefix "hires"
    /// <summary>
    /// Describes that a person is in cahoots with someone else.
    /// <see href="http://purl.org/net/soron/inCahootsWith"></see></summary>
    let inCahootsWith = _prefix "inCahootsWith"
    /// <summary>
    /// Describes that a particular person has been influenced by another individual (writer, artist, etc.).
    /// <see href="http://purl.org/net/soron/influencedBy"></see></summary>
    let influencedBy = _prefix "influencedBy"
    /// <summary>
    /// Describes that a particular person has had some kind of influence on another individual. It does not imply that the person that has that influence on the other is aware of that influence at all.
    /// <see href="http://purl.org/net/soron/influences"></see></summary>
    let influences = _prefix "influences"
    /// <summary>
    /// Describes that a person is liked by another.
    /// <see href="http://purl.org/net/soron/likedBy"></see></summary>
    let likedBy = _prefix "likedBy"
    /// <summary>
    /// Describes that an individual likes another.
    /// <see href="http://purl.org/net/soron/likes"></see></summary>
    let likes = _prefix "likes"
    /// <summary>
    /// Describes that a person is loved by another.
    /// <see href="http://purl.org/net/soron/lovedBy"></see></summary>
    let lovedBy = _prefix "lovedBy"
    /// <summary>
    /// Describes that a peson is the lover of someone else.
    /// <see href="http://purl.org/net/soron/loverOf"></see></summary>
    let loverOf = _prefix "loverOf"
    /// <summary>
    /// Describes that an individual loves another.
    /// <see href="http://purl.org/net/soron/loves"></see></summary>
    let loves = _prefix "loves"
    /// <summary>
    /// Describes the relationship between an individual and their master (particularly used in art, craftmanship, etc.). Example: Anthony Van Dick masterIs Rubens (it implies that Van Dick worked for Rubens' studio).
    /// <see href="http://purl.org/net/soron/masterIs"></see></summary>
    let masterIs = _prefix "masterIs"
    /// <summary>
    /// Describes the relationship between an expert/master and their apprentice (particularly used in art, craftmanship, etc.). Example: Rubens masterOf Anthony Van Dick   (it implies that Rubens hired Van Dick as apprentice in his studio).
    /// <see href="http://purl.org/net/soron/masterOf"></see></summary>
    let masterOf = _prefix "masterOf"
    /// <summary>
    /// Describes the relationship between a mentee (in an academic setting, the student) and a mentor. It implies that it is an unpaid relationship.
    /// <see href="http://purl.org/net/soron/menteeOf"></see></summary>
    let menteeOf = _prefix "menteeOf"
    /// <summary>
    /// Describes the relationship between a mentor and a mentee (for instance a supervisor in an academic setting). It implies that it is an unpaid relationship.
    /// <see href="http://purl.org/net/soron/mentorOf"></see></summary>
    let mentorOf = _prefix "mentorOf"
    /// <summary>
    /// Describes that an individual has been mentioned/referred to by another. It does not imply that the person that is being mentioned knows the person that mentions him/her.
    /// <see href="http://purl.org/net/soron/mentionedBy"></see></summary>
    let mentionedBy = _prefix "mentionedBy"
    /// <summary>
    /// Describes that the name of an individual has been mentioned by another.
    /// <see href="http://purl.org/net/soron/mentions"></see></summary>
    let mentions = _prefix "mentions"
    /// <summary>
    /// Describes that a person (usually an artist or intellectual) is sponsored by another.
    /// <see href="http://purl.org/net/soron/patronIs"></see></summary>
    let patronIs = _prefix "patronIs"
    /// <summary>
    /// Describes that a person sponsors the work of another (usually an artist or intellectual).
    /// <see href="http://purl.org/net/soron/patronOf"></see></summary>
    let patronOf = _prefix "patronOf"
    /// <summary>
    /// Describes that an artist (musicians, artists, etc.) performs with another.
    /// <see href="http://purl.org/net/soron/performsWith"></see></summary>
    let performsWith = _prefix "performsWith"
    /// <summary>
    /// Describes that a person is rejected by another.
    /// <see href="http://purl.org/net/soron/rejectedBy"></see></summary>
    let rejectedBy = _prefix "rejectedBy"
    /// <summary>
    /// Describes that a person rejects another.
    /// <see href="http://purl.org/net/soron/rejects"></see></summary>
    let rejects = _prefix "rejects"
    /// <summary>
    /// Describes that someone is work partner of someone else.
    /// <see href="http://purl.org/net/soron/workPartnerOf"></see></summary>
    let workPartnerOf = _prefix "workPartnerOf"
