#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sor =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/soron/" "sor"
    let ``_0.1`` = _prefixId.prefix "0.1"
    /// <summary>
    ///   <para>rdfs:label : Felt negatively by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is perceived negatively by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/FeltNegativelyBy">sor:FeltNegativelyBy</a>
    /// </summary>
    let FeltNegativelyBy = _prefixId.prefix "FeltNegativelyBy"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a person that knows another but there is no strong personal relationship between them.^^xsd:string</para>
    ///   <para>rdfs:label : Is acquaintance of^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/acquaintanceOf">sor:acquaintanceOf</a>
    /// </summary>
    let acquaintanceOf = _prefixId.prefix "acquaintanceOf"
    /// <summary>
    ///   <para>rdfs:label : Admired by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is admired by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/admiredBy">sor:admiredBy</a>
    /// </summary>
    let admiredBy = _prefixId.prefix "admiredBy"
    /// <summary>
    ///   <para>rdfs:label : Admires^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual feels admiration for another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/admires">sor:admires</a>
    /// </summary>
    let admires = _prefixId.prefix "admires"
    /// <summary>
    ///   <para>rdfs:label : Is ambivalent of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is ambivalent of another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/ambivalentOf">sor:ambivalentOf</a>
    /// </summary>
    let ambivalentOf = _prefixId.prefix "ambivalentOf"
    /// <summary>
    ///   <para>rdfs:label : Is antagonist of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person perceives another as antagonist.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/antagonistOf">sor:antagonistOf</a>
    /// </summary>
    let antagonistOf = _prefixId.prefix "antagonistOf"
    /// <summary>
    ///   <para>rdfs:label : Appreciated by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is appreciated by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/appreciatedBy">sor:appreciatedBy</a>
    /// </summary>
    let appreciatedBy = _prefixId.prefix "appreciatedBy"
    /// <summary>
    ///   <para>rdfs:label : Appreciates^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual appreciates another person.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/appreciates">sor:appreciates</a>
    /// </summary>
    let appreciates = _prefixId.prefix "appreciates"
    /// <summary>
    ///   <para>rdfs:label : Apprentice is^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between an apprentice and their master (in any kind of profession).^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/apprenticeIs">sor:apprenticeIs</a>
    /// </summary>
    let apprenticeIs = _prefixId.prefix "apprenticeIs"
    /// <summary>
    ///   <para>rdfs:label : Is apprentice to^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between an individual and their apprentice (in any kind of profession).^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/apprenticeTo">sor:apprenticeTo</a>
    /// </summary>
    let apprenticeTo = _prefixId.prefix "apprenticeTo"
    /// <summary>
    ///   <para>rdfs:comment : Describes that a person works as assistant for someone else.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:label : Is assistant for^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/assistantFor">sor:assistantFor</a>
    /// </summary>
    let assistantFor = _prefixId.prefix "assistantFor"
    /// <summary>
    ///   <para>rdfs:label : Assisted by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has someone working for them as assistant.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/assistedBy">sor:assistedBy</a>
    /// </summary>
    let assistedBy = _prefixId.prefix "assistedBy"
    /// <summary>
    ///   <para>rdfs:comment : Describes that a person is associate of another.^^xsd:string</para>
    ///   <para>rdfs:label : Is associate of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/associateOf">sor:associateOf</a>
    /// </summary>
    let associateOf = _prefixId.prefix "associateOf"
    /// <summary>
    ///   <para>rdfs:label : Cited by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual's words/ideas/works have been cited by someone  else. It does not imply that the cited individual has any knowledge of the citing individual or the fact that they had been cited.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/citedBy">sor:citedBy</a>
    /// </summary>
    let citedBy = _prefixId.prefix "citedBy"
    /// <summary>
    ///   <para>rdfs:label : Cites^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes an individual's knowledge of someone else and their work by citing their words/ideas/works. It does not imply physical/real knowledge of the cited individual.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/cites">sor:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:label : Coauthors with^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person coauthors a work with someone else.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/coauthorsWith">sor:coauthorsWith</a>
    /// </summary>
    let coauthorsWith = _prefixId.prefix "coauthorsWith"
    /// <summary>
    ///   <para>rdfs:label : Collaborates with^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person collaborates with another in a particular task/project/work.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/collaboratesWith">sor:collaboratesWith</a>
    /// </summary>
    let collaboratesWith = _prefixId.prefix "collaboratesWith"
    /// <summary>
    ///   <para>rdfs:label : Is colleague of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is colleague of someone else (work related).^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/colleagueOf">sor:colleagueOf</a>
    /// </summary>
    let colleagueOf = _prefixId.prefix "colleagueOf"
    /// <summary>
    ///   <para>rdfs:label : Critizised by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is critizised by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/critizisedBy">sor:critizisedBy</a>
    /// </summary>
    let critizisedBy = _prefixId.prefix "critizisedBy"
    /// <summary>
    ///   <para>rdfs:label : Critizises^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person critizises another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/critizises">sor:critizises</a>
    /// </summary>
    let critizises = _prefixId.prefix "critizises"
    /// <summary>
    ///   <para>rdfs:label : Disagreed by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is disagreed by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/disagreedBy">sor:disagreedBy</a>
    /// </summary>
    let disagreedBy = _prefixId.prefix "disagreedBy"
    /// <summary>
    ///   <para>rdfs:label : Disagrees with^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person disagrees with another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/disagreesWith">sor:disagreesWith</a>
    /// </summary>
    let disagreesWith = _prefixId.prefix "disagreesWith"
    /// <summary>
    ///   <para>rdfs:label : Disliked by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is disliked by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/dislikedBy">sor:dislikedBy</a>
    /// </summary>
    let dislikedBy = _prefixId.prefix "dislikedBy"
    /// <summary>
    ///   <para>rdfs:label : Dislikes^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person dislikes another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/dislikes">sor:dislikes</a>
    /// </summary>
    let dislikes = _prefixId.prefix "dislikes"
    /// <summary>
    ///   <para>rdfs:label : Employs^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between the person that hires and the hired person.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/employs">sor:employs</a>
    /// </summary>
    let employs = _prefixId.prefix "employs"
    /// <summary>
    ///   <para>rdfs:label : Is enemy of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is the enemy of another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/enemyOf">sor:enemyOf</a>
    /// </summary>
    let enemyOf = _prefixId.prefix "enemyOf"
    /// <summary>
    ///   <para>rdfs:label : Is fellow student of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person studies with someone else.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/fellowStudentOf">sor:fellowStudentOf</a>
    /// </summary>
    let fellowStudentOf = _prefixId.prefix "fellowStudentOf"
    /// <summary>
    ///   <para>rdfs:label : Felt ambivalent by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is felt ambivalently by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/feltAmbivalentBy">sor:feltAmbivalentBy</a>
    /// </summary>
    let feltAmbivalentBy = _prefixId.prefix "feltAmbivalentBy"
    /// <summary>
    ///   <para>rdfs:label : Felt as antagonist by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is perceived as antagonist by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/feltAntagonistBy">sor:feltAntagonistBy</a>
    /// </summary>
    let feltAntagonistBy = _prefixId.prefix "feltAntagonistBy"
    /// <summary>
    ///   <para>rdfs:label : Felt as enemy by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is perceived as enemy by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/feltEnemyBy">sor:feltEnemyBy</a>
    /// </summary>
    let feltEnemyBy = _prefixId.prefix "feltEnemyBy"
    /// <summary>
    ///   <para>rdfs:label : Felt neutrally by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is being perceived neutrally (mixed feelings) by  another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/feltNeutrallyBy">sor:feltNeutrallyBy</a>
    /// </summary>
    let feltNeutrallyBy = _prefixId.prefix "feltNeutrallyBy"
    /// <summary>
    ///   <para>rdfs:label : Felt positively by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is being perceived positively by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/feltPositivelyBy">sor:feltPositivelyBy</a>
    /// </summary>
    let feltPositivelyBy = _prefixId.prefix "feltPositivelyBy"
    /// <summary>
    ///   <para>rdfs:label : Is friend of^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has a strong personal relationship with another.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/friendOf">sor:friendOf</a>
    /// </summary>
    let friendOf = _prefixId.prefix "friendOf"
    /// <summary>
    ///   <para>rdfs:label : Has heard of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has heard of another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasHeardOf">sor:hasHeardOf</a>
    /// </summary>
    let hasHeardOf = _prefixId.prefix "hasHeardOf"
    /// <summary>
    ///   <para>rdfs:comment : Describes that a person has met another. It usually implies some kind of physical interaction, but it may also happen virtually.^^xsd:string</para>
    ///   <para>rdfs:label : Has met^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasMet">sor:hasMet</a>
    /// </summary>
    let hasMet = _prefixId.prefix "hasMet"
    /// <summary>
    ///   <para>rdfs:label : Has negative feelings for^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has negative feelings for another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasNegativeFeelingsFor">sor:hasNegativeFeelingsFor</a>
    /// </summary>
    let hasNegativeFeelingsFor = _prefixId.prefix "hasNegativeFeelingsFor"
    /// <summary>
    ///   <para>rdfs:label : Has neutral feelings for^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has neutral (mixed) feelings for another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasNeutralFeelingsFor">sor:hasNeutralFeelingsFor</a>
    /// </summary>
    let hasNeutralFeelingsFor = _prefixId.prefix "hasNeutralFeelingsFor"
    /// <summary>
    ///   <para>rdfs:label : Has personal relationship with^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has a personal, close relationship (not family related) with another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasPersonalRelationshipWith">sor:hasPersonalRelationshipWith</a>
    /// </summary>
    let hasPersonalRelationshipWith = _prefixId.prefix "hasPersonalRelationshipWith"
    /// <summary>
    ///   <para>rdfs:label : Has positive feelings for^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person has positive feelings about another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasPositiveFeelingsFor">sor:hasPositiveFeelingsFor</a>
    /// </summary>
    let hasPositiveFeelingsFor = _prefixId.prefix "hasPositiveFeelingsFor"
    /// <summary>
    ///   <para>rdfs:label : Has social relationship^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes any kind of social relationship that may appear in society.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hasSocialRelationship">sor:hasSocialRelationship</a>
    /// </summary>
    let hasSocialRelationship = _prefixId.prefix "hasSocialRelationship"
    /// <summary>
    ///   <para>rdfs:label : Hated by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is hated by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hatedBy">sor:hatedBy</a>
    /// </summary>
    let hatedBy = _prefixId.prefix "hatedBy"
    /// <summary>
    ///   <para>rdfs:label : Hates^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person hates another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hates">sor:hates</a>
    /// </summary>
    let hates = _prefixId.prefix "hates"
    /// <summary>
    ///   <para>rdfs:label : Hired by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual is paid by another to do some kind of work.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hiredBy">sor:hiredBy</a>
    /// </summary>
    let hiredBy = _prefixId.prefix "hiredBy"
    /// <summary>
    ///   <para>rdfs:label : Hires^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual pays someone else to do some kind of work.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/hires">sor:hires</a>
    /// </summary>
    let hires = _prefixId.prefix "hires"
    /// <summary>
    ///   <para>rdfs:label : In cahoots with^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is in cahoots with someone else.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/inCahootsWith">sor:inCahootsWith</a>
    /// </summary>
    let inCahootsWith = _prefixId.prefix "inCahootsWith"
    /// <summary>
    ///   <para>rdfs:label : Is influenced by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a particular person has been influenced by another individual (writer, artist, etc.).^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/influencedBy">sor:influencedBy</a>
    /// </summary>
    let influencedBy = _prefixId.prefix "influencedBy"
    /// <summary>
    ///   <para>rdfs:label : Influences^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a particular person has had some kind of influence on another individual. It does not imply that the person that has that influence on the other is aware of that influence at all.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/influences">sor:influences</a>
    /// </summary>
    let influences = _prefixId.prefix "influences"
    /// <summary>
    ///   <para>rdfs:label : Known by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is known by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/knownBy">sor:knownBy</a>
    /// </summary>
    let knownBy = _prefixId.prefix "knownBy"
    /// <summary>
    ///   <para>rdfs:label : Knows^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between two individuals that know each other.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/knows">sor:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:label : Liked by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is liked by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/likedBy">sor:likedBy</a>
    /// </summary>
    let likedBy = _prefixId.prefix "likedBy"
    /// <summary>
    ///   <para>rdfs:label : Likes^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual likes another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/likes">sor:likes</a>
    /// </summary>
    let likes = _prefixId.prefix "likes"
    /// <summary>
    ///   <para>rdfs:label : Loved by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is loved by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/lovedBy">sor:lovedBy</a>
    /// </summary>
    let lovedBy = _prefixId.prefix "lovedBy"
    /// <summary>
    ///   <para>rdfs:label : Is lover of^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a peson is the lover of someone else.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/loverOf">sor:loverOf</a>
    /// </summary>
    let loverOf = _prefixId.prefix "loverOf"
    /// <summary>
    ///   <para>rdfs:label : Loves^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual loves another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/loves">sor:loves</a>
    /// </summary>
    let loves = _prefixId.prefix "loves"
    /// <summary>
    ///   <para>rdfs:label : Master is^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between an individual and their master (particularly used in art, craftmanship, etc.). Example: Anthony Van Dick masterIs Rubens (it implies that Van Dick worked for Rubens' studio).^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/masterIs">sor:masterIs</a>
    /// </summary>
    let masterIs = _prefixId.prefix "masterIs"
    /// <summary>
    ///   <para>rdfs:label : Is master of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between an expert/master and their apprentice (particularly used in art, craftmanship, etc.). Example: Rubens masterOf Anthony Van Dick   (it implies that Rubens hired Van Dick as apprentice in his studio).^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/masterOf">sor:masterOf</a>
    /// </summary>
    let masterOf = _prefixId.prefix "masterOf"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:label : Is mentee of^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between a mentee (in an academic setting, the student) and a mentor. It implies that it is an unpaid relationship.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/menteeOf">sor:menteeOf</a>
    /// </summary>
    let menteeOf = _prefixId.prefix "menteeOf"
    /// <summary>
    ///   <para>rdfs:label : Is mentioned by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that an individual has been mentioned/referred to by another. It does not imply that the person that is being mentioned knows the person that mentions him/her.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/mentionedBy">sor:mentionedBy</a>
    /// </summary>
    let mentionedBy = _prefixId.prefix "mentionedBy"
    /// <summary>
    ///   <para>rdfs:label : Mentions^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that the name of an individual has been mentioned by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/mentions">sor:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
    /// <summary>
    ///   <para>rdfs:comment : Describes the relationship between a mentor and a mentee (for instance a supervisor in an academic setting). It implies that it is an unpaid relationship.^^xsd:string</para>
    ///   <para>rdfs:label : Is mentor of^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/mentorOf">sor:mentorOf</a>
    /// </summary>
    let mentorOf = _prefixId.prefix "mentorOf"
    /// <summary>
    ///   <para>rdfs:comment : Describes that a person (usually an artist or intellectual) is sponsored by another.^^xsd:string</para>
    ///   <para>rdfs:label : Patron is^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/patronIs">sor:patronIs</a>
    /// </summary>
    let patronIs = _prefixId.prefix "patronIs"
    /// <summary>
    ///   <para>rdfs:label : Is patron of^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person sponsors the work of another (usually an artist or intellectual).^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/patronOf">sor:patronOf</a>
    /// </summary>
    let patronOf = _prefixId.prefix "patronOf"
    /// <summary>
    ///   <para>rdfs:comment : Describes that an artist (musicians, artists, etc.) performs with another.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:label : Performs with^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/performsWith">sor:performsWith</a>
    /// </summary>
    let performsWith = _prefixId.prefix "performsWith"
    /// <summary>
    ///   <para>rdfs:label : Rejected by^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person is rejected by another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/rejectedBy">sor:rejectedBy</a>
    /// </summary>
    let rejectedBy = _prefixId.prefix "rejectedBy"
    /// <summary>
    ///   <para>rdfs:label : Rejects^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that a person rejects another.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/rejects">sor:rejects</a>
    /// </summary>
    let rejects = _prefixId.prefix "rejects"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes that someone is work partner of someone else.^^xsd:string</para>
    ///   <para>rdfs:label : Is work partner of^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/workPartnerOf">sor:workPartnerOf</a>
    /// </summary>
    let workPartnerOf = _prefixId.prefix "workPartnerOf"
    /// <summary>
    ///   <para>rdfs:label : Works for^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between a particular individual and the person that hires them.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/worksFor">sor:worksFor</a>
    /// </summary>
    let worksFor = _prefixId.prefix "worksFor"
    /// <summary>
    ///   <para>rdfs:label : Works with^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/net/soron^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between two individuals working together in paid or unpaid tasks in any kind of context/organization.^^xsd:string</para>
    ///   <a href="http://purl.org/net/soron/worksWith">sor:worksWith</a>
    /// </summary>
    let worksWith = _prefixId.prefix "worksWith"
