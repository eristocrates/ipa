namespace http.purl.org.net.soron.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sor =
    let _namespace_iri = Namespace_Iri sor |> NamespaceIRI
    /// <summary>
    ///   <para>sor:assistedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes that a person has someone working for them as assistant.</para>
    /// labels<para>Assisted by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/assistedBy">http://purl.org/net/soron/assistedBy</seealso>
    let assistedBy = Prefixed_Name(sor, "assistedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:worksWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between two individuals working together in paid or unpaid tasks in any kind of context/organization.</para>
    /// labels<para>Works with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/worksWith">http://purl.org/net/soron/worksWith</seealso>
    let worksWith = Prefixed_Name(sor, "worksWith") |> PrefixedName
    /// <summary>
    ///   <para>sor:workPartnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that someone is work partner of someone else.</para>
    /// labels<para>Is work partner of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/workPartnerOf">http://purl.org/net/soron/workPartnerOf</seealso>
    let workPartnerOf = Prefixed_Name(sor, "workPartnerOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:admires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual feels admiration for another.</para>
    /// labels<para>Admires</para></remarks>
    /// <seealso href="http://purl.org/net/soron/admires">http://purl.org/net/soron/admires</seealso>
    let admires = Prefixed_Name(sor, "admires") |> PrefixedName
    /// <summary>
    ///   <para>sor:hasHeardOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person has heard of another.</para>
    /// labels<para>Has heard of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasHeardOf">http://purl.org/net/soron/hasHeardOf</seealso>
    let hasHeardOf = Prefixed_Name(sor, "hasHeardOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:hasMet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person has met another. It usually implies some kind of physical interaction, but it may also happen virtually.</para>
    /// labels<para>Has met</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasMet">http://purl.org/net/soron/hasMet</seealso>
    let hasMet = Prefixed_Name(sor, "hasMet") |> PrefixedName
    /// <summary>
    ///   <para>sor:hatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is hated by another.</para>
    /// labels<para>Hated by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hatedBy">http://purl.org/net/soron/hatedBy</seealso>
    let hatedBy = Prefixed_Name(sor, "hatedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:FeltNegativelyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is perceived negatively by another.</para>
    /// labels<para>Felt negatively by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/FeltNegativelyBy">http://purl.org/net/soron/FeltNegativelyBy</seealso>
    let FeltNegativelyBy = Prefixed_Name(sor, "FeltNegativelyBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/net/soron/0.1">http://purl.org/net/soron/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(sor, "0.1") |> PrefixedName

    /// <summary>
    ///   <para>sor:hasSocialRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes any kind of social relationship that may appear in society.</para>
    /// labels<para>Has social relationship</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasSocialRelationship">http://purl.org/net/soron/hasSocialRelationship</seealso>
    let hasSocialRelationship =
        Prefixed_Name(sor, "hasSocialRelationship") |> PrefixedName

    /// <summary>
    ///   <para>sor:acquaintanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Describes a person that knows another but there is no strong personal relationship between them.</para>
    /// labels<para>Is acquaintance of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/acquaintanceOf">http://purl.org/net/soron/acquaintanceOf</seealso>
    let acquaintanceOf = Prefixed_Name(sor, "acquaintanceOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:admiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is admired by another.</para>
    /// labels<para>Admired by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/admiredBy">http://purl.org/net/soron/admiredBy</seealso>
    let admiredBy = Prefixed_Name(sor, "admiredBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:feltPositivelyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is being perceived positively by another.</para>
    /// labels<para>Felt positively by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/feltPositivelyBy">http://purl.org/net/soron/feltPositivelyBy</seealso>
    let feltPositivelyBy = Prefixed_Name(sor, "feltPositivelyBy") |> PrefixedName

    /// <summary>
    ///   <para>sor:hasPositiveFeelingsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person has positive feelings about another.</para>
    /// labels<para>Has positive feelings for</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasPositiveFeelingsFor">http://purl.org/net/soron/hasPositiveFeelingsFor</seealso>
    let hasPositiveFeelingsFor =
        Prefixed_Name(sor, "hasPositiveFeelingsFor") |> PrefixedName

    /// <summary>
    ///   <para>sor:ambivalentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is ambivalent of another.</para>
    /// labels<para>Is ambivalent of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/ambivalentOf">http://purl.org/net/soron/ambivalentOf</seealso>
    let ambivalentOf = Prefixed_Name(sor, "ambivalentOf") |> PrefixedName

    /// <summary>
    ///   <para>sor:hasNeutralFeelingsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person has neutral (mixed) feelings for another.</para>
    /// labels<para>Has neutral feelings for</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasNeutralFeelingsFor">http://purl.org/net/soron/hasNeutralFeelingsFor</seealso>
    let hasNeutralFeelingsFor =
        Prefixed_Name(sor, "hasNeutralFeelingsFor") |> PrefixedName

    /// <summary>
    ///   <para>sor:hasNegativeFeelingsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person has negative feelings for another.</para>
    /// labels<para>Has negative feelings for</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasNegativeFeelingsFor">http://purl.org/net/soron/hasNegativeFeelingsFor</seealso>
    let hasNegativeFeelingsFor =
        Prefixed_Name(sor, "hasNegativeFeelingsFor") |> PrefixedName

    /// <summary>
    ///   <para>sor:appreciates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual appreciates another person.</para>
    /// labels<para>Appreciates</para></remarks>
    /// <seealso href="http://purl.org/net/soron/appreciates">http://purl.org/net/soron/appreciates</seealso>
    let appreciates = Prefixed_Name(sor, "appreciates") |> PrefixedName
    /// <summary>
    ///   <para>sor:hates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person hates another.</para>
    /// labels<para>Hates</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hates">http://purl.org/net/soron/hates</seealso>
    let hates = Prefixed_Name(sor, "hates") |> PrefixedName
    /// <summary>
    ///   <para>sor:hiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes that an individual is paid by another to do some kind of work.</para>
    /// labels<para>Hired by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hiredBy">http://purl.org/net/soron/hiredBy</seealso>
    let hiredBy = Prefixed_Name(sor, "hiredBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:hires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual pays someone else to do some kind of work.</para>
    /// labels<para>Hires</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hires">http://purl.org/net/soron/hires</seealso>
    let hires = Prefixed_Name(sor, "hires") |> PrefixedName
    /// <summary>
    ///   <para>sor:influencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a particular person has been influenced by another individual (writer, artist, etc.).</para>
    /// labels<para>Is influenced by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/influencedBy">http://purl.org/net/soron/influencedBy</seealso>
    let influencedBy = Prefixed_Name(sor, "influencedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:influences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a particular person has had some kind of influence on another individual. It does not imply that the person that has that influence on the other is aware of that influence at all.</para>
    /// labels<para>Influences</para></remarks>
    /// <seealso href="http://purl.org/net/soron/influences">http://purl.org/net/soron/influences</seealso>
    let influences = Prefixed_Name(sor, "influences") |> PrefixedName
    /// <summary>
    ///   <para>sor:likedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is liked by another.</para>
    /// labels<para>Liked by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/likedBy">http://purl.org/net/soron/likedBy</seealso>
    let likedBy = Prefixed_Name(sor, "likedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:likes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual likes another.</para>
    /// labels<para>Likes</para></remarks>
    /// <seealso href="http://purl.org/net/soron/likes">http://purl.org/net/soron/likes</seealso>
    let likes = Prefixed_Name(sor, "likes") |> PrefixedName
    /// <summary>
    ///   <para>sor:loverOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Describes that a peson is the lover of someone else.</para>
    /// labels<para>Is lover of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/loverOf">http://purl.org/net/soron/loverOf</seealso>
    let loverOf = Prefixed_Name(sor, "loverOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:masterIs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between an individual and their master (particularly used in art, craftmanship, etc.). Example: Anthony Van Dick masterIs Rubens (it implies that Van Dick worked for Rubens' studio).</para>
    /// labels<para>Master is</para></remarks>
    /// <seealso href="http://purl.org/net/soron/masterIs">http://purl.org/net/soron/masterIs</seealso>
    let masterIs = Prefixed_Name(sor, "masterIs") |> PrefixedName
    /// <summary>
    ///   <para>sor:masterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between an expert/master and their apprentice (particularly used in art, craftmanship, etc.). Example: Rubens masterOf Anthony Van Dick   (it implies that Rubens hired Van Dick as apprentice in his studio).</para>
    /// labels<para>Is master of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/masterOf">http://purl.org/net/soron/masterOf</seealso>
    let masterOf = Prefixed_Name(sor, "masterOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:mentorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between a mentor and a mentee (for instance a supervisor in an academic setting). It implies that it is an unpaid relationship.</para>
    /// labels<para>Is mentor of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/mentorOf">http://purl.org/net/soron/mentorOf</seealso>
    let mentorOf = Prefixed_Name(sor, "mentorOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:mentionedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual has been mentioned/referred to by another. It does not imply that the person that is being mentioned knows the person that mentions him/her.</para>
    /// labels<para>Is mentioned by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/mentionedBy">http://purl.org/net/soron/mentionedBy</seealso>
    let mentionedBy = Prefixed_Name(sor, "mentionedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:patronIs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person (usually an artist or intellectual) is sponsored by another.</para>
    /// labels<para>Patron is</para></remarks>
    /// <seealso href="http://purl.org/net/soron/patronIs">http://purl.org/net/soron/patronIs</seealso>
    let patronIs = Prefixed_Name(sor, "patronIs") |> PrefixedName
    /// <summary>
    ///   <para>sor:patronOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes that a person sponsors the work of another (usually an artist or intellectual).</para>
    /// labels<para>Is patron of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/patronOf">http://purl.org/net/soron/patronOf</seealso>
    let patronOf = Prefixed_Name(sor, "patronOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:performsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Describes that an artist (musicians, artists, etc.) performs with another.</para>
    /// labels<para>Performs with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/performsWith">http://purl.org/net/soron/performsWith</seealso>
    let performsWith = Prefixed_Name(sor, "performsWith") |> PrefixedName
    /// <summary>
    ///   <para>sor:rejectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is rejected by another.</para>
    /// labels<para>Rejected by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/rejectedBy">http://purl.org/net/soron/rejectedBy</seealso>
    let rejectedBy = Prefixed_Name(sor, "rejectedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:rejects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person rejects another.</para>
    /// labels<para>Rejects</para></remarks>
    /// <seealso href="http://purl.org/net/soron/rejects">http://purl.org/net/soron/rejects</seealso>
    let rejects = Prefixed_Name(sor, "rejects") |> PrefixedName

    /// <summary>
    ///   <para>sor:hasPersonalRelationshipWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person has a personal, close relationship (not family related) with another.</para>
    /// labels<para>Has personal relationship with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/hasPersonalRelationshipWith">http://purl.org/net/soron/hasPersonalRelationshipWith</seealso>
    let hasPersonalRelationshipWith =
        Prefixed_Name(sor, "hasPersonalRelationshipWith") |> PrefixedName

    /// <summary>
    ///   <para>sor:antagonistOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person perceives another as antagonist.</para>
    /// labels<para>Is antagonist of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/antagonistOf">http://purl.org/net/soron/antagonistOf</seealso>
    let antagonistOf = Prefixed_Name(sor, "antagonistOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:lovedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is loved by another.</para>
    /// labels<para>Loved by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/lovedBy">http://purl.org/net/soron/lovedBy</seealso>
    let lovedBy = Prefixed_Name(sor, "lovedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:loves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual loves another.</para>
    /// labels<para>Loves</para></remarks>
    /// <seealso href="http://purl.org/net/soron/loves">http://purl.org/net/soron/loves</seealso>
    let loves = Prefixed_Name(sor, "loves") |> PrefixedName
    /// <summary>
    ///   <para>sor:appreciatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is appreciated by another.</para>
    /// labels<para>Appreciated by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/appreciatedBy">http://purl.org/net/soron/appreciatedBy</seealso>
    let appreciatedBy = Prefixed_Name(sor, "appreciatedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:employs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between the person that hires and the hired person.</para>
    /// labels<para>Employs</para></remarks>
    /// <seealso href="http://purl.org/net/soron/employs">http://purl.org/net/soron/employs</seealso>
    let employs = Prefixed_Name(sor, "employs") |> PrefixedName
    /// <summary>
    ///   <para>sor:apprenticeIs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes the relationship between an apprentice and their master (in any kind of profession).</para>
    /// labels<para>Apprentice is</para></remarks>
    /// <seealso href="http://purl.org/net/soron/apprenticeIs">http://purl.org/net/soron/apprenticeIs</seealso>
    let apprenticeIs = Prefixed_Name(sor, "apprenticeIs") |> PrefixedName
    /// <summary>
    ///   <para>sor:apprenticeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes the relationship between an individual and their apprentice (in any kind of profession).</para>
    /// labels<para>Is apprentice to</para></remarks>
    /// <seealso href="http://purl.org/net/soron/apprenticeTo">http://purl.org/net/soron/apprenticeTo</seealso>
    let apprenticeTo = Prefixed_Name(sor, "apprenticeTo") |> PrefixedName
    /// <summary>
    ///   <para>sor:inCahootsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is in cahoots with someone else.</para>
    /// labels<para>In cahoots with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/inCahootsWith">http://purl.org/net/soron/inCahootsWith</seealso>
    let inCahootsWith = Prefixed_Name(sor, "inCahootsWith") |> PrefixedName
    /// <summary>
    ///   <para>sor:worksFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between a particular individual and the person that hires them.</para>
    /// labels<para>Works for</para></remarks>
    /// <seealso href="http://purl.org/net/soron/worksFor">http://purl.org/net/soron/worksFor</seealso>
    let worksFor = Prefixed_Name(sor, "worksFor") |> PrefixedName
    /// <summary>
    ///   <para>sor:menteeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between a mentee (in an academic setting, the student) and a mentor. It implies that it is an unpaid relationship.</para>
    /// labels<para>Is mentee of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/menteeOf">http://purl.org/net/soron/menteeOf</seealso>
    let menteeOf = Prefixed_Name(sor, "menteeOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that the name of an individual has been mentioned by another.</para>
    /// labels<para>Mentions</para></remarks>
    /// <seealso href="http://purl.org/net/soron/mentions">http://purl.org/net/soron/mentions</seealso>
    let mentions = Prefixed_Name(sor, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>sor:assistantFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person works as assistant for someone else.</para>
    /// labels<para>Is assistant for</para></remarks>
    /// <seealso href="http://purl.org/net/soron/assistantFor">http://purl.org/net/soron/assistantFor</seealso>
    let assistantFor = Prefixed_Name(sor, "assistantFor") |> PrefixedName
    /// <summary>
    ///   <para>sor:associateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Describes that a person is associate of another.</para>
    /// labels<para>Is associate of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/associateOf">http://purl.org/net/soron/associateOf</seealso>
    let associateOf = Prefixed_Name(sor, "associateOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:citedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that an individual's words/ideas/works have been cited by someone  else. It does not imply that the cited individual has any knowledge of the citing individual or the fact that they had been cited.</para>
    /// labels<para>Cited by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/citedBy">http://purl.org/net/soron/citedBy</seealso>
    let citedBy = Prefixed_Name(sor, "citedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:knownBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Describes that a person is known by another.</para>
    /// labels<para>Known by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/knownBy">http://purl.org/net/soron/knownBy</seealso>
    let knownBy = Prefixed_Name(sor, "knownBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:coauthorsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person coauthors a work with someone else.</para>
    /// labels<para>Coauthors with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/coauthorsWith">http://purl.org/net/soron/coauthorsWith</seealso>
    let coauthorsWith = Prefixed_Name(sor, "coauthorsWith") |> PrefixedName
    /// <summary>
    ///   <para>sor:critizisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is critizised by another.</para>
    /// labels<para>Critizised by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/critizisedBy">http://purl.org/net/soron/critizisedBy</seealso>
    let critizisedBy = Prefixed_Name(sor, "critizisedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes an individual's knowledge of someone else and their work by citing their words/ideas/works. It does not imply physical/real knowledge of the cited individual.</para>
    /// labels<para>Cites</para></remarks>
    /// <seealso href="http://purl.org/net/soron/cites">http://purl.org/net/soron/cites</seealso>
    let cites = Prefixed_Name(sor, "cites") |> PrefixedName
    /// <summary>
    ///   <para>sor:collaboratesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person collaborates with another in a particular task/project/work.</para>
    /// labels<para>Collaborates with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/collaboratesWith">http://purl.org/net/soron/collaboratesWith</seealso>
    let collaboratesWith = Prefixed_Name(sor, "collaboratesWith") |> PrefixedName
    /// <summary>
    ///   <para>sor:colleagueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is colleague of someone else (work related).</para>
    /// labels<para>Is colleague of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/colleagueOf">http://purl.org/net/soron/colleagueOf</seealso>
    let colleagueOf = Prefixed_Name(sor, "colleagueOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between two individuals that know each other.</para>
    /// labels<para>Knows</para></remarks>
    /// <seealso href="http://purl.org/net/soron/knows">http://purl.org/net/soron/knows</seealso>
    let knows = Prefixed_Name(sor, "knows") |> PrefixedName
    /// <summary>
    ///   <para>sor:critizises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person critizises another.</para>
    /// labels<para>Critizises</para></remarks>
    /// <seealso href="http://purl.org/net/soron/critizises">http://purl.org/net/soron/critizises</seealso>
    let critizises = Prefixed_Name(sor, "critizises") |> PrefixedName
    /// <summary>
    ///   <para>sor:disagreesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person disagrees with another.</para>
    /// labels<para>Disagrees with</para></remarks>
    /// <seealso href="http://purl.org/net/soron/disagreesWith">http://purl.org/net/soron/disagreesWith</seealso>
    let disagreesWith = Prefixed_Name(sor, "disagreesWith") |> PrefixedName
    /// <summary>
    ///   <para>sor:disagreedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is disagreed by another.</para>
    /// labels<para>Disagreed by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/disagreedBy">http://purl.org/net/soron/disagreedBy</seealso>
    let disagreedBy = Prefixed_Name(sor, "disagreedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:dislikedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is disliked by another.</para>
    /// labels<para>Disliked by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/dislikedBy">http://purl.org/net/soron/dislikedBy</seealso>
    let dislikedBy = Prefixed_Name(sor, "dislikedBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:dislikes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person dislikes another.</para>
    /// labels<para>Dislikes</para></remarks>
    /// <seealso href="http://purl.org/net/soron/dislikes">http://purl.org/net/soron/dislikes</seealso>
    let dislikes = Prefixed_Name(sor, "dislikes") |> PrefixedName
    /// <summary>
    ///   <para>sor:enemyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is the enemy of another.</para>
    /// labels<para>Is enemy of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/enemyOf">http://purl.org/net/soron/enemyOf</seealso>
    let enemyOf = Prefixed_Name(sor, "enemyOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:fellowStudentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person studies with someone else.</para>
    /// labels<para>Is fellow student of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/fellowStudentOf">http://purl.org/net/soron/fellowStudentOf</seealso>
    let fellowStudentOf = Prefixed_Name(sor, "fellowStudentOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:feltAntagonistBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is perceived as antagonist by another.</para>
    /// labels<para>Felt as antagonist by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/feltAntagonistBy">http://purl.org/net/soron/feltAntagonistBy</seealso>
    let feltAntagonistBy = Prefixed_Name(sor, "feltAntagonistBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:feltEnemyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is perceived as enemy by another.</para>
    /// labels<para>Felt as enemy by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/feltEnemyBy">http://purl.org/net/soron/feltEnemyBy</seealso>
    let feltEnemyBy = Prefixed_Name(sor, "feltEnemyBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:friendOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Describes that a person has a strong personal relationship with another.</para>
    /// labels<para>Is friend of</para></remarks>
    /// <seealso href="http://purl.org/net/soron/friendOf">http://purl.org/net/soron/friendOf</seealso>
    let friendOf = Prefixed_Name(sor, "friendOf") |> PrefixedName
    /// <summary>
    ///   <para>sor:feltAmbivalentBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is felt ambivalently by another.</para>
    /// labels<para>Felt ambivalent by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/feltAmbivalentBy">http://purl.org/net/soron/feltAmbivalentBy</seealso>
    let feltAmbivalentBy = Prefixed_Name(sor, "feltAmbivalentBy") |> PrefixedName
    /// <summary>
    ///   <para>sor:feltNeutrallyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes that a person is being perceived neutrally (mixed feelings) by  another.</para>
    /// labels<para>Felt neutrally by</para></remarks>
    /// <seealso href="http://purl.org/net/soron/feltNeutrallyBy">http://purl.org/net/soron/feltNeutrallyBy</seealso>
    let feltNeutrallyBy = Prefixed_Name(sor, "feltNeutrallyBy") |> PrefixedName
