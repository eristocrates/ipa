#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdau =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/u/" "rdau"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : Relates a candidate for a degree who defends or opposes a thesis provided by the praeses in an academic disputation to the resource.</para>
    ///   <para>rdfs:label : is respondent of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : respondentOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60001">rdau:P60001</a>
    /// </summary>
    let P60001 = _prefixId.prefix "P60001"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeGrantingInstitutionOf</para>
    ///   <para>rdfs:label : is degree granting institution of</para>
    ///   <para>skos:definition : Relates a corporate body granting an academic degree to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60002">rdau:P60002</a>
    /// </summary>
    let P60002 = _prefixId.prefix "P60002"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostInstitutionOf</para>
    ///   <para>skos:definition : Relates a corporate body hosting the event, exhibit, conference, etc., which gave rise to a resource, but having little or no responsibility for the content of the resource to the resource.</para>
    ///   <para>rdfs:label : is host institution of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60003">rdau:P60003</a>
    /// </summary>
    let P60003 = _prefixId.prefix "P60003"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body that is responsible for financial, technical, and organizational management of a production for stage, screen, sound recording, television, webcast, etc. to the resource.</para>
    ///   <para>rdfs:label : is production company of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionCompanyOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60004">rdau:P60004</a>
    /// </summary>
    let P60004 = _prefixId.prefix "P60004"
    /// <summary>
    ///   <para>skos:definition : Relates a court governed by court rules, regardless of their official nature (e.g., laws, administrative regulations) to the resource.</para>
    ///   <para>rdfs:label : is court governed of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtGovernedOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60005">rdau:P60005</a>
    /// </summary>
    let P60005 = _prefixId.prefix "P60005"
    /// <summary>
    ///   <para>skos:definition : Relates a curator who brings together resources from various sources that are then arranged, described, and cataloged as a collection to the resource.</para>
    ///   <para>rdfs:label : is collector of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60006">rdau:P60006</a>
    /// </summary>
    let P60006 = _prefixId.prefix "P60006"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectionRegistrarOf</para>
    ///   <para>rdfs:label : is collection registrar of</para>
    ///   <para>skos:definition : Relates a curator who lists or inventories the items in an aggregate resource such as a collection of items or resources to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60007">rdau:P60007</a>
    /// </summary>
    let P60007 = _prefixId.prefix "P60007"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : depositorOf</para>
    ///   <para>skos:definition : Relates a current owner of a resource who deposited the resource into the custody of another person, family, or corporate body, while still retaining ownership to the resource.</para>
    ///   <para>rdfs:label : is depositor of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60008">rdau:P60008</a>
    /// </summary>
    let P60008 = _prefixId.prefix "P60008"
    /// <summary>
    ///   <para>rdfs:label : is film director of</para>
    ///   <para>skos:definition : Relates a director responsible for the general management and supervision of a filmed performance to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDirectorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60009">rdau:P60009</a>
    /// </summary>
    let P60009 = _prefixId.prefix "P60009"
    /// <summary>
    ///   <para>rdfs:label : is radio director of</para>
    ///   <para>skos:definition : Relates a director responsible for the general management and supervision of a radio program to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioDirectorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60010">rdau:P60010</a>
    /// </summary>
    let P60010 = _prefixId.prefix "P60010"
    /// <summary>
    ///   <para>rdfs:label : is television director of</para>
    ///   <para>skos:definition : Relates a director responsible for the general management and supervision of a television program to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionDirectorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60011">rdau:P60011</a>
    /// </summary>
    let P60011 = _prefixId.prefix "P60011"
    /// <summary>
    ///   <para>skos:definition : Relates a former owner of a resource who donated that resource to another owner to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : donorOf</para>
    ///   <para>rdfs:label : is donor of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60012">rdau:P60012</a>
    /// </summary>
    let P60012 = _prefixId.prefix "P60012"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sellerOf</para>
    ///   <para>rdfs:label : is seller of</para>
    ///   <para>skos:definition : Relates a former owner of a resource who sold that resource to another owner to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60013">rdau:P60013</a>
    /// </summary>
    let P60013 = _prefixId.prefix "P60013"
    /// <summary>
    ///   <para>rdfs:label : is enacting jurisdiction of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : enactingJurisdictionOf</para>
    ///   <para>skos:definition : Relates a jurisdiction enacting a law, regulation, constitution, court rule, etc. to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60014">rdau:P60014</a>
    /// </summary>
    let P60014 = _prefixId.prefix "P60014"
    /// <summary>
    ///   <para>skos:definition : Relates a jurisdiction governed by a law, regulation, etc., that was enacted by another jurisdiction to the resource.</para>
    ///   <para>rdfs:label : is jurisdiction governed of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : jurisdictionGovernedOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60015">rdau:P60015</a>
    /// </summary>
    let P60015 = _prefixId.prefix "P60015"
    /// <summary>
    ///   <para>rdfs:label : is conductor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : conductorOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a musical resource by leading a performing group (orchestra, chorus, opera, etc.) in a musical or dramatic presentation, etc. to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60016">rdau:P60016</a>
    /// </summary>
    let P60016 = _prefixId.prefix "P60016"
    /// <summary>
    ///   <para>rdfs:label : is actor of</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by acting as a cast member or player in a musical or dramatic presentation, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : actorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60017">rdau:P60017</a>
    /// </summary>
    let P60017 = _prefixId.prefix "P60017"
    /// <summary>
    ///   <para>rdfs:label : is on-screen presenter of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenPresenterOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by appearing on screen to provide contextual or background information. an on-screen presenter may appear in nonfiction moving image materials or in introductions to fiction moving image materials to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60018">rdau:P60018</a>
    /// </summary>
    let P60018 = _prefixId.prefix "P60018"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dancerOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by dancing in a musical, dramatic, etc., presentation to the resource.</para>
    ///   <para>rdfs:label : is dancer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60019">rdau:P60019</a>
    /// </summary>
    let P60019 = _prefixId.prefix "P60019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : teacherOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by giving instruction or providing a demonstration to the resource.</para>
    ///   <para>rdfs:label : is teacher of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60020">rdau:P60020</a>
    /// </summary>
    let P60020 = _prefixId.prefix "P60020"
    /// <summary>
    ///   <para>rdfs:label : is host of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by leading a program (often broadcast) that includes other guests, performers, etc. (e.g., talk show host) to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60021">rdau:P60021</a>
    /// </summary>
    let P60021 = _prefixId.prefix "P60021"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : moderatorOf</para>
    ///   <para>rdfs:label : is moderator of</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by leading a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60022">rdau:P60022</a>
    /// </summary>
    let P60022 = _prefixId.prefix "P60022"
    /// <summary>
    ///   <para>rdfs:label : is puppeteer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : puppeteerOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by manipulating, controlling, or directing puppets or marionettes in a moving image production or a musical or dramatic presentation or entertainment to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60023">rdau:P60023</a>
    /// </summary>
    let P60023 = _prefixId.prefix "P60023"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to a resource by participating in a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : panelistOf</para>
    ///   <para>rdfs:label : is panelist of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60024">rdau:P60024</a>
    /// </summary>
    let P60024 = _prefixId.prefix "P60024"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalistOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by playing a musical instrument to the resource.</para>
    ///   <para>rdfs:label : is instrumentalist of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60025">rdau:P60025</a>
    /// </summary>
    let P60025 = _prefixId.prefix "P60025"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to a resource by providing interpretation, analysis, or a discussion of the subject matter on a recording, film, or other audiovisual medium to the resource.</para>
    ///   <para>rdfs:label : is commentator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60026">rdau:P60026</a>
    /// </summary>
    let P60026 = _prefixId.prefix "P60026"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to a resource by providing the voice for characters in radio and audio productions and for animated characters in moving image resources as well as by providing voice-overs in radio and television commercials, dubbed resources, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : voiceActorOf</para>
    ///   <para>rdfs:label : is voice actor of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60027">rdau:P60027</a>
    /// </summary>
    let P60027 = _prefixId.prefix "P60027"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to a resource by reading aloud or giving an account of an act, occurrence, course of events, etc. to the resource.</para>
    ///   <para>rdfs:label : is narrator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : narratorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60028">rdau:P60028</a>
    /// </summary>
    let P60028 = _prefixId.prefix "P60028"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : storytellerOf</para>
    ///   <para>rdfs:label : is storyteller of</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by relaying a creator's original story with dramatic or theatrical interpretation to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60029">rdau:P60029</a>
    /// </summary>
    let P60029 = _prefixId.prefix "P60029"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to a resource by speaking words, such as a lecture, speech, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : speakerOf</para>
    ///   <para>rdfs:label : is speaker of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60030">rdau:P60030</a>
    /// </summary>
    let P60030 = _prefixId.prefix "P60030"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : singerOf</para>
    ///   <para>skos:definition : Relates a performer contributing to a resource by using his/her/their voice, with or without instrumental accompaniment, to produce music. a singer's performance may or may not include actual words to the resource.</para>
    ///   <para>rdfs:label : is singer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60031">rdau:P60031</a>
    /// </summary>
    let P60031 = _prefixId.prefix "P60031"
    /// <summary>
    ///   <para>skos:definition : Relates a person held to be a channel of communication between the earthly world and a world of spirits to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOf</para>
    ///   <para>rdfs:label : is medium of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60032">rdau:P60032</a>
    /// </summary>
    let P60032 = _prefixId.prefix "P60032"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmProducerOf</para>
    ///   <para>skos:definition : Relates a producer responsible for most of the business aspects of a film to the resource.</para>
    ///   <para>rdfs:label : is film producer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60033">rdau:P60033</a>
    /// </summary>
    let P60033 = _prefixId.prefix "P60033"
    /// <summary>
    ///   <para>rdfs:label : is radio producer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProducerOf</para>
    ///   <para>skos:definition : Relates a producer responsible for most of the business aspects of a radio program to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60034">rdau:P60034</a>
    /// </summary>
    let P60034 = _prefixId.prefix "P60034"
    /// <summary>
    ///   <para>rdfs:label : is television producer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProducerOf</para>
    ///   <para>skos:definition : Relates a producer responsible for most of the business aspects of a television program to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60035">rdau:P60035</a>
    /// </summary>
    let P60035 = _prefixId.prefix "P60035"
    /// <summary>
    ///   <para>skos:definition : Relates a pseudonymous or other identity assumed by the agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternateIdentity</para>
    ///   <para>rdfs:label : has alternate identity</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60036">rdau:P60036</a>
    /// </summary>
    let P60036 = _prefixId.prefix "P60036"
    /// <summary>
    ///   <para>skos:definition : Relates a real agent who assumes the alternate identity to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : realIdentity</para>
    ///   <para>rdfs:label : has real identity</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60037">rdau:P60037</a>
    /// </summary>
    let P60037 = _prefixId.prefix "P60037"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : respondent</para>
    ///   <para>rdfs:label : has respondent</para>
    ///   <para>skos:definition : Relates a resource to a candidate for a degree who defends or opposes a thesis provided by the praeses in an academic disputation.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60045">rdau:P60045</a>
    /// </summary>
    let P60045 = _prefixId.prefix "P60045"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a categorization indicating that the core elements recorded are insufficient to differentiate between two or more agents with the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : undifferentiatedNameIndicator</para>
    ///   <para>rdfs:label : has undifferentiated name indicator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60046">rdau:P60046</a>
    /// </summary>
    let P60046 = _prefixId.prefix "P60046"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a categorization or generic descriptor for the type of agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfAgent</para>
    ///   <para>rdfs:label : has type of agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60047">rdau:P60047</a>
    /// </summary>
    let P60047 = _prefixId.prefix "P60047"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a categorization reflecting the format of the storage medium and housing of a carrier in combination with the type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : carrierType</para>
    ///   <para>rdfs:label : has carrier type</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60048">rdau:P60048</a>
    /// </summary>
    let P60048 = _prefixId.prefix "P60048"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a categorization reflecting the fundamental form of communication in which the content is expressed and the human sense through which it is intended to be perceived.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contentType</para>
    ///   <para>rdfs:label : has content type</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60049">rdau:P60049</a>
    /// </summary>
    let P60049 = _prefixId.prefix "P60049"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediaType</para>
    ///   <para>rdfs:label : has media type</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60050">rdau:P60050</a>
    /// </summary>
    let P60050 = _prefixId.prefix "P60050"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a categorization reflecting whether a resource is issued in one or more parts, the way it is updated, and its intended termination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modeOfIssuance</para>
    ///   <para>rdfs:label : has mode of issuance</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60051">rdau:P60051</a>
    /// </summary>
    let P60051 = _prefixId.prefix "P60051"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a character string associated with a resource that serves to differentiate that resource from other resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheResource</para>
    ///   <para>rdfs:label : has identifier for the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60052">rdau:P60052</a>
    /// </summary>
    let P60052 = _prefixId.prefix "P60052"
    /// <summary>
    ///   <para>rdfs:label : has identifier for the agent</para>
    ///   <para>skos:definition : Relates a resource to a character string uniquely associated with an agent, or with a surrogate for an agent (e.g., an authority record).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheAgent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60053">rdau:P60053</a>
    /// </summary>
    let P60053 = _prefixId.prefix "P60053"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a characteristic other than content type, language of resource, date of resource, form of resource, or place of origin of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDistinguishingCharacteristicOfTheResource</para>
    ///   <para>rdfs:label : has other distinguishing characteristic of the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60054">rdau:P60054</a>
    /// </summary>
    let P60054 = _prefixId.prefix "P60054"
    let P60055 = _prefixId.prefix "P60055"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information about additional characteristics that are specific to the resource being described and are assumed not to apply to other resources exemplifying the same resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnResourceSpecificCarrierCharacteristic</para>
    ///   <para>rdfs:label : has note on resource-specific carrier characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60056">rdau:P60056</a>
    /// </summary>
    let P60056 = _prefixId.prefix "P60056"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a citation for a resource in the form preferred by a creator, publisher, custodian, indexing or abstracting service, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredCitation</para>
    ///   <para>rdfs:label : has preferred citation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60057">rdau:P60057</a>
    /// </summary>
    let P60057 = _prefixId.prefix "P60057"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a class or genre to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfResource</para>
    ///   <para>rdfs:label : has form of resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60058">rdau:P60058</a>
    /// </summary>
    let P60058 = _prefixId.prefix "P60058"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a code identifying the region of the world for which a videodisc has been encoded and preventing the disc from being played on a player sold in a different region.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : regionalEncoding</para>
    ///   <para>rdfs:label : has regional encoding</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60059">rdau:P60059</a>
    /// </summary>
    let P60059 = _prefixId.prefix "P60059"
    /// <summary>
    ///   <para>rdfs:label : has degree granting institution</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeGrantingInstitution</para>
    ///   <para>skos:definition : Relates a resource to a corporate body granting an academic degree.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60060">rdau:P60060</a>
    /// </summary>
    let P60060 = _prefixId.prefix "P60060"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : host institution</para>
    ///   <para>rdfs:label : has host institution</para>
    ///   <para>skos:definition : Relates a resource to a corporate body hosting the event, exhibit, conference, etc., which gave rise to a resource, but having little or no responsibility for the content of the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60061">rdau:P60061</a>
    /// </summary>
    let P60061 = _prefixId.prefix "P60061"
    /// <summary>
    ///   <para>rdfs:label : has production company</para>
    ///   <para>skos:definition : Relates a resource to a corporate body that is responsible for financial, technical, and organizational management of a production for stage, screen, sound recording, television, webcast, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionCompany</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60062">rdau:P60062</a>
    /// </summary>
    let P60062 = _prefixId.prefix "P60062"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a country with which an agent is identified.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : countryAssociatedWithTheAgent</para>
    ///   <para>rdfs:label : has country associated with the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60063">rdau:P60063</a>
    /// </summary>
    let P60063 = _prefixId.prefix "P60063"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : locationOfHeadquarters</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60064">rdau:P60064</a>
    /// </summary>
    let P60064 = _prefixId.prefix "P60064"
    /// <summary>
    ///   <para>rdfs:label : has court governed</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtGoverned</para>
    ///   <para>skos:definition : Relates a resource to a court governed by court rules, regardless of their official nature (e.g., laws, administrative regulations).</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60065">rdau:P60065</a>
    /// </summary>
    let P60065 = _prefixId.prefix "P60065"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collector</para>
    ///   <para>rdfs:label : has collector</para>
    ///   <para>skos:definition : Relates a resource to a curator who brings together resources from various sources that are then arranged, described, and cataloged as a collection.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60066">rdau:P60066</a>
    /// </summary>
    let P60066 = _prefixId.prefix "P60066"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectionRegistrar</para>
    ///   <para>rdfs:label : has collection registrar</para>
    ///   <para>skos:definition : Relates a resource to a curator who lists or inventories the items in an aggregate resource such as a collection of items or resources.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60067">rdau:P60067</a>
    /// </summary>
    let P60067 = _prefixId.prefix "P60067"
    /// <summary>
    ///   <para>rdfs:label : has depositor</para>
    ///   <para>skos:definition : Relates a resource to a current owner of a resource who deposited the resource into the custody of another person, family, or corporate body, while still retaining ownership.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : depositor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60068">rdau:P60068</a>
    /// </summary>
    let P60068 = _prefixId.prefix "P60068"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a date associated with a claim of protection under copyright or a similar regime.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : copyrightDate</para>
    ///   <para>rdfs:label : has copyright date</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60069">rdau:P60069</a>
    /// </summary>
    let P60069 = _prefixId.prefix "P60069"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a date associated with the distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDistribution</para>
    ///   <para>rdfs:label : has date of distribution</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60070">rdau:P60070</a>
    /// </summary>
    let P60070 = _prefixId.prefix "P60070"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a date associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfProduction</para>
    ///   <para>rdfs:label : has date of production</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60071">rdau:P60071</a>
    /// </summary>
    let P60071 = _prefixId.prefix "P60071"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a date associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfManufacture</para>
    ///   <para>rdfs:label : has date of manufacture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60072">rdau:P60072</a>
    /// </summary>
    let P60072 = _prefixId.prefix "P60072"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a date associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfPublication</para>
    ///   <para>rdfs:label : has date of publication</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60073">rdau:P60073</a>
    /// </summary>
    let P60073 = _prefixId.prefix "P60073"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a date or range of dates associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfCapture</para>
    ///   <para>rdfs:label : has date of capture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60074">rdau:P60074</a>
    /// </summary>
    let P60074 = _prefixId.prefix "P60074"
    /// <summary>
    ///   <para>skos:definition : Relates a name to a date or range of dates associated with the use of the name chosen as the preferred name for an agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfUsage</para>
    ///   <para>rdfs:label : has date of usage</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60075">rdau:P60075</a>
    /// </summary>
    let P60075 = _prefixId.prefix "P60075"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : periodOfActivityOfTheAgent</para>
    ///   <para>rdfs:label : has period of activity of the agent</para>
    ///   <para>skos:definition : Relates a resource to a date or range of dates indicative of the period in which an agent was active in his or her primary field of endeavour.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60076">rdau:P60076</a>
    /// </summary>
    let P60076 = _prefixId.prefix "P60076"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a designation of a named revision of an edition in a language and/or script that differs from that recorded in the designation of a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : has parallel designation of a named revision of an edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60077">rdau:P60077</a>
    /// </summary>
    let P60077 = _prefixId.prefix "P60077"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a designation of edition in a language and/or script that differs from that recorded in the designation of edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfEdition</para>
    ///   <para>rdfs:label : has parallel designation of edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60078">rdau:P60078</a>
    /// </summary>
    let P60078 = _prefixId.prefix "P60078"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a designation of the sequencing of a conference, etc., within a series of conferences, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberOfAConferenceEtc</para>
    ///   <para>rdfs:label : has number of a conference, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60079">rdau:P60079</a>
    /// </summary>
    let P60079 = _prefixId.prefix "P60079"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a designation of the sequencing of a part or parts within a larger resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfPart</para>
    ///   <para>rdfs:label : has numbering of part</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60080">rdau:P60080</a>
    /// </summary>
    let P60080 = _prefixId.prefix "P60080"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a designation of the sequencing of a part or parts within a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSeries</para>
    ///   <para>rdfs:label : has numbering within series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60081">rdau:P60081</a>
    /// </summary>
    let P60081 = _prefixId.prefix "P60081"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a designation of the sequencing of a part or parts within a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSubseries</para>
    ///   <para>rdfs:label : has numbering within subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60082">rdau:P60082</a>
    /// </summary>
    let P60082 = _prefixId.prefix "P60082"
    /// <summary>
    ///   <para>rdfs:label : is electronic reproduction</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproduction</para>
    ///   <para>skos:definition : Relates a resource to a resource in a digital format that is the result of the transfer of a resource in an analog format.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60083">rdau:P60083</a>
    /// </summary>
    let P60083 = _prefixId.prefix "P60083"
    /// <summary>
    ///   <para>rdfs:label : has film director</para>
    ///   <para>skos:definition : Relates a resource to a director responsible for the general management and supervision of a filmed performance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDirector</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60084">rdau:P60084</a>
    /// </summary>
    let P60084 = _prefixId.prefix "P60084"
    /// <summary>
    ///   <para>rdfs:label : has radio director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioDirector</para>
    ///   <para>skos:definition : Relates a resource to a director responsible for the general management and supervision of a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60085">rdau:P60085</a>
    /// </summary>
    let P60085 = _prefixId.prefix "P60085"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a director responsible for the general management and supervision of a television program.</para>
    ///   <para>rdfs:label : has television director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionDirector</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60086">rdau:P60086</a>
    /// </summary>
    let P60086 = _prefixId.prefix "P60086"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a distributor's name in a language and/or script that differs from that recorded in the distributor's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDistributorsName</para>
    ///   <para>rdfs:label : has parallel distributor’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60087">rdau:P60087</a>
    /// </summary>
    let P60087 = _prefixId.prefix "P60087"
    /// <summary>
    ///   <para>rdfs:label : is dramatized as</para>
    ///   <para>skos:definition : Relates a resource to a dramatic resource adapted from the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60088">rdau:P60088</a>
    /// </summary>
    let P60088 = _prefixId.prefix "P60088"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a field of endeavour, area of expertise, competence, responsibility, jurisdiction etc., in which an agent is engaged or was engaged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fieldOfActivity</para>
    ///   <para>rdfs:label : has field of activity of the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60089">rdau:P60089</a>
    /// </summary>
    let P60089 = _prefixId.prefix "P60089"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a formal recognition of excellence, etc., given by an award- or prize-granting body, for the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : award</para>
    ///   <para>rdfs:label : has award</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60090">rdau:P60090</a>
    /// </summary>
    let P60090 = _prefixId.prefix "P60090"
    /// <summary>
    ///   <para>rdfs:label : has donor</para>
    ///   <para>skos:definition : Relates a resource to a former owner of a resource who donated that resource to another owner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : donor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60091">rdau:P60091</a>
    /// </summary>
    let P60091 = _prefixId.prefix "P60091"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a former owner of a resource who sold that resource to another owner.</para>
    ///   <para>rdfs:label : has seller</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seller</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60092">rdau:P60092</a>
    /// </summary>
    let P60092 = _prefixId.prefix "P60092"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileType</para>
    ///   <para>rdfs:label : has file type</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60093">rdau:P60093</a>
    /// </summary>
    let P60093 = _prefixId.prefix "P60093"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a group with which an agent is affiliated or has been affiliated through employment, membership, cultural identity, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : affiliation</para>
    ///   <para>rdfs:label : has affiliation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60095">rdau:P60095</a>
    /// </summary>
    let P60095 = _prefixId.prefix "P60095"
    /// <summary>
    ///   <para>rdfs:label : has enacting jurisdiction</para>
    ///   <para>skos:definition : Relates a resource to a jurisdiction enacting a law, regulation, constitution, court rule, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : enactingJurisdiction</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60096">rdau:P60096</a>
    /// </summary>
    let P60096 = _prefixId.prefix "P60096"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : jurisdictionGoverned</para>
    ///   <para>rdfs:label : has jurisdiction governed</para>
    ///   <para>skos:definition : Relates a resource to a jurisdiction governed by a law, regulation, etc., that was enacted by another jurisdiction.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60097">rdau:P60097</a>
    /// </summary>
    let P60097 = _prefixId.prefix "P60097"
    /// <summary>
    ///   <para>rdfs:label : has language of the agent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheAgent</para>
    ///   <para>skos:definition : Relates a resource to a language an agent uses in its communications, when writing for publication, broadcasting, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60098">rdau:P60098</a>
    /// </summary>
    let P60098 = _prefixId.prefix "P60098"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a language used to express the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheContent</para>
    ///   <para>rdfs:label : has language of the content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60099">rdau:P60099</a>
    /// </summary>
    let P60099 = _prefixId.prefix "P60099"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a larger resource of which a part is a discrete component that exactly reproduces another resource embodying the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileContainedIn</para>
    ///   <para>rdfs:label : is facsimile contained in</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60100">rdau:P60100</a>
    /// </summary>
    let P60100 = _prefixId.prefix "P60100"
    /// <summary>
    ///   <para>rdfs:label : is contained in</para>
    ///   <para>skos:definition : Relates a resource to a larger resource of which a part is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedIn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60101">rdau:P60101</a>
    /// </summary>
    let P60101 = _prefixId.prefix "P60101"
    /// <summary>
    ///   <para>rdfs:label : is sequel</para>
    ///   <para>skos:definition : Relates a resource to a later resource that continues the narrative of an earlier resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequel</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60102">rdau:P60102</a>
    /// </summary>
    let P60102 = _prefixId.prefix "P60102"
    /// <summary>
    ///   <para>rdfs:label : is replaced in part by</para>
    ///   <para>skos:definition : Relates a resource to a later resource used in part in place of an earlier resource, usually because the later resource contains updated or new information that makes part of the earlier resource obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacedInPartBy</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60103">rdau:P60103</a>
    /// </summary>
    let P60103 = _prefixId.prefix "P60103"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacedBy</para>
    ///   <para>rdfs:label : is replaced by</para>
    ///   <para>skos:definition : Relates a resource to a later resource used in place of an earlier resource, usually because the later resource contains updated or new information that makes the earlier resource obsolete.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60104">rdau:P60104</a>
    /// </summary>
    let P60104 = _prefixId.prefix "P60104"
    let P60105 = _prefixId.prefix "P60105"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedInVerseAs</para>
    ///   <para>skos:definition : Relates a resource to a literary composition in verse form adapted from the source resource.</para>
    ///   <para>rdfs:label : is adapted in verse as</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60106">rdau:P60106</a>
    /// </summary>
    let P60106 = _prefixId.prefix "P60106"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a local place in which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : locationOfConferenceEtc</para>
    ///   <para>rdfs:label : has location of conference, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60107">rdau:P60107</a>
    /// </summary>
    let P60107 = _prefixId.prefix "P60107"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a manufacturer's name in a language and/or script that differs from that recorded in the manufacturer's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelManufacturersName</para>
    ///   <para>rdfs:label : has parallel manufacturer’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60108">rdau:P60108</a>
    /// </summary>
    let P60108 = _prefixId.prefix "P60108"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a mathematical system for identifying the area covered by the cartographic content of a resource.</para>
    ///   <para>rdfs:label : has coordinates of cartographic content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coordinatesOfCartographicContent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60109">rdau:P60109</a>
    /// </summary>
    let P60109 = _prefixId.prefix "P60109"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a motion picture based on the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPicture</para>
    ///   <para>rdfs:label : is adapted as motion picture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60110">rdau:P60110</a>
    /// </summary>
    let P60110 = _prefixId.prefix "P60110"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dubbedVersionOf</para>
    ///   <para>rdfs:label : is dubbed version of</para>
    ///   <para>skos:definition : Relates a resource to a moving image resource in which the spoken dialogue has been translated into a language different from that of the original resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60111">rdau:P60111</a>
    /// </summary>
    let P60111 = _prefixId.prefix "P60111"
    /// <summary>
    ///   <para>rdfs:label : is dubbed version</para>
    ///   <para>skos:definition : Relates a resource to a moving image resource that translates the spoken dialogue of the original resource into a different language.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dubbedVersion</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60112">rdau:P60112</a>
    /// </summary>
    let P60112 = _prefixId.prefix "P60112"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource consisting of an ornamental passage for a soloist, added to a musical resource such as a concerto, either by the same or a different composer.</para>
    ///   <para>rdfs:label : is cadenza</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenza</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60113">rdau:P60113</a>
    /// </summary>
    let P60113 = _prefixId.prefix "P60113"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource from which melodic, thematic, or harmonic material is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variationsBasedOn</para>
    ///   <para>rdfs:label : is variations based on</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60114">rdau:P60114</a>
    /// </summary>
    let P60114 = _prefixId.prefix "P60114"
    /// <summary>
    ///   <para>rdfs:label : is modified by variation as</para>
    ///   <para>skos:definition : Relates a resource to a musical resource in which melodic, thematic, or harmonic material is taken from the source resource to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modifiedByVariationAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60115">rdau:P60115</a>
    /// </summary>
    let P60115 = _prefixId.prefix "P60115"
    /// <summary>
    ///   <para>rdfs:label : is cadenza composed for</para>
    ///   <para>skos:definition : Relates a resource to a musical resource such as a concerto for which an ornamental passage for a soloist has been composed, either by the same or a different composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaComposedFor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60116">rdau:P60116</a>
    /// </summary>
    let P60116 = _prefixId.prefix "P60116"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoFor</para>
    ///   <para>skos:definition : Relates a resource to a musical resource such as an opera or other resource for the musical stage, or an oratorio, that uses the text of the related resource as a libretto.</para>
    ///   <para>rdfs:label : is libretto for</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60117">rdau:P60117</a>
    /// </summary>
    let P60117 = _prefixId.prefix "P60117"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource that provides the incidental music for a play or other spoken work for the stage.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incidentalMusic</para>
    ///   <para>rdfs:label : is incidental music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60118">rdau:P60118</a>
    /// </summary>
    let P60118 = _prefixId.prefix "P60118"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheAgent</para>
    ///   <para>rdfs:label : has variant name for the agent</para>
    ///   <para>skos:definition : Relates a resource to a name or form of name by which an agent is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60119">rdau:P60119</a>
    /// </summary>
    let P60119 = _prefixId.prefix "P60119"
    /// <summary>
    ///   <para>rdfs:label : is remade as</para>
    ///   <para>skos:definition : Relates a resource to a new motion picture, radio program, television program, or video based on an earlier resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remadeAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60120">rdau:P60120</a>
    /// </summary>
    let P60120 = _prefixId.prefix "P60120"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a non-dramatic musical resource, other than an oratorio, that uses the text of the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : setToMusicAs</para>
    ///   <para>rdfs:label : is set to music as</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60121">rdau:P60121</a>
    /// </summary>
    let P60121 = _prefixId.prefix "P60121"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note identifying the issue or part of a multipart monograph or serial, or the iteration of an integrating resource that has been used as the basis for the identification of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource</para>
    ///   <para>rdfs:label : has note on issue, part, or iteration used as the basis for identification of the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60122">rdau:P60122</a>
    /// </summary>
    let P60122 = _prefixId.prefix "P60122"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note on changes in content characteristics that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnChangesInContentCharacteristics</para>
    ///   <para>rdfs:label : has note on changes in content characteristics</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60123">rdau:P60123</a>
    /// </summary>
    let P60123 = _prefixId.prefix "P60123"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note on changes in the characteristics of the carrier that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnChangesInCarrierCharacteristics</para>
    ///   <para>rdfs:label : has note on changes in carrier characteristics</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60124">rdau:P60124</a>
    /// </summary>
    let P60124 = _prefixId.prefix "P60124"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing details on place of distribution, distributor, or date of distribution, or information on changes in the place of distribution, distributor, or distributor’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDistributionStatement</para>
    ///   <para>rdfs:label : has note on distribution statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60125">rdau:P60125</a>
    /// </summary>
    let P60125 = _prefixId.prefix "P60125"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing details on place of manufacture, manufacturer, or date of manufacture, or information on changes in the place of manufacture, manufacturer, or manufacturer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnManufactureStatement</para>
    ///   <para>rdfs:label : has note on manufacture statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60126">rdau:P60126</a>
    /// </summary>
    let P60126 = _prefixId.prefix "P60126"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing details on place of production, producer, or date of production, or information on changes in the place of production, producer, or producer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnProductionStatement</para>
    ///   <para>rdfs:label : has note on production statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60127">rdau:P60127</a>
    /// </summary>
    let P60127 = _prefixId.prefix "P60127"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing details on place of publication, publisher, or date of publication, information on changes in the place of publication, publisher, or publisher’s name, or on suspension of publication.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnPublicationStatement</para>
    ///   <para>rdfs:label : has note on publication statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60128">rdau:P60128</a>
    /// </summary>
    let P60128 = _prefixId.prefix "P60128"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing details on the currency of the contents, on the frequency of release of issues or parts of a serial or the frequency of updates to an integrating resource, or on changes in frequency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnFrequency</para>
    ///   <para>rdfs:label : has note on frequency</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60129">rdau:P60129</a>
    /// </summary>
    let P60129 = _prefixId.prefix "P60129"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information on an agent not named in a statement of responsibility to whom responsibility for the intellectual or artistic content of the resource has been attributed, on variant forms of names appearing in the resource, on changes in statements of responsibility, or on other details relating to a statement of responsibility.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnStatementOfResponsibility</para>
    ///   <para>rdfs:label : has note on statement of responsibility</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60130">rdau:P60130</a>
    /// </summary>
    let P60130 = _prefixId.prefix "P60130"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information on complex series statements, incorrect numbering within series, or changes in series statements.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnSeriesStatement</para>
    ///   <para>rdfs:label : has note on series statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60131">rdau:P60131</a>
    /// </summary>
    let P60131 = _prefixId.prefix "P60131"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information on copyright dates not recorded as part of the copyright date element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnCopyrightDate</para>
    ///   <para>rdfs:label : has note on copyright date</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60132">rdau:P60132</a>
    /// </summary>
    let P60132 = _prefixId.prefix "P60132"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDimensionsOfResource</para>
    ///   <para>skos:definition : Relates a resource to a note providing information on the dimensions of a resource that is not recorded as part of the dimensions element.</para>
    ///   <para>rdfs:label : has note on dimensions of resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60133">rdau:P60133</a>
    /// </summary>
    let P60133 = _prefixId.prefix "P60133"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnExtentOfResource</para>
    ///   <para>rdfs:label : has note on extent of resource</para>
    ///   <para>skos:definition : Relates a resource to a note providing information on the extent of a resource that is not recorded as part of the extent element.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60134">rdau:P60134</a>
    /// </summary>
    let P60134 = _prefixId.prefix "P60134"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information on the numbering of the first and/or last issue or part, on complex or irregular numbering (including numbering errors), or on the period covered by a volume, issue, part, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnNumberingOfSerials</para>
    ///   <para>rdfs:label : has note on numbering of serials</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60135">rdau:P60135</a>
    /// </summary>
    let P60135 = _prefixId.prefix "P60135"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information on the source from which a title was taken, the date the title was viewed, variations in titles, inaccuracies, deletions, etc., or other information relating to a title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnTitle</para>
    ///   <para>rdfs:label : has note on title</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60136">rdau:P60136</a>
    /// </summary>
    let P60136 = _prefixId.prefix "P60136"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a note providing information on the source of an edition statement, on edition statements relating to issues, parts, etc., on changes in edition statements, or other information relating to an edition statement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnEditionStatement</para>
    ///   <para>rdfs:label : has note on edition statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60137">rdau:P60137</a>
    /// </summary>
    let P60137 = _prefixId.prefix "P60137"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a novel adapted from the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelization</para>
    ///   <para>rdfs:label : is adapted as novel</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60138">rdau:P60138</a>
    /// </summary>
    let P60138 = _prefixId.prefix "P60138"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a numbering designation assigned to a resource by a music publisher, appearing normally only on the title page, the cover, and/or the first page of music.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersNumberForMusic</para>
    ///   <para>rdfs:label : has publisher’s number for music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60139">rdau:P60139</a>
    /// </summary>
    let P60139 = _prefixId.prefix "P60139"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a numbering designation assigned to a resource by a music publisher.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plateNumberForMusic</para>
    ///   <para>rdfs:label : has plate number for music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60140">rdau:P60140</a>
    /// </summary>
    let P60140 = _prefixId.prefix "P60140"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a musical resource by leading a performing group (orchestra, chorus, opera, etc.) in a musical or dramatic presentation, etc.</para>
    ///   <para>rdfs:label : has conductor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : conductor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60141">rdau:P60141</a>
    /// </summary>
    let P60141 = _prefixId.prefix "P60141"
    /// <summary>
    ///   <para>rdfs:label : has actor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : actor</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by acting as a cast member or player in a musical or dramatic presentation, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60142">rdau:P60142</a>
    /// </summary>
    let P60142 = _prefixId.prefix "P60142"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenPresenter</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by appearing on screen to provide contextual or background information. an on-screen presenter may appear in nonfiction moving image materials or in introductions to fiction moving image materials.</para>
    ///   <para>rdfs:label : has on-screen presenter</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60143">rdau:P60143</a>
    /// </summary>
    let P60143 = _prefixId.prefix "P60143"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by dancing in a musical, dramatic, etc., presentation.</para>
    ///   <para>rdfs:label : has dancer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dancer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60144">rdau:P60144</a>
    /// </summary>
    let P60144 = _prefixId.prefix "P60144"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : teacher</para>
    ///   <para>rdfs:label : has teacher</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by giving instruction or providing a demonstration.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60145">rdau:P60145</a>
    /// </summary>
    let P60145 = _prefixId.prefix "P60145"
    /// <summary>
    ///   <para>rdfs:label : has host</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by leading a program (often broadcast) that includes other guests, performers, etc. (e.g., talk show host).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : host</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60146">rdau:P60146</a>
    /// </summary>
    let P60146 = _prefixId.prefix "P60146"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : moderator</para>
    ///   <para>rdfs:label : has moderator</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by leading a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60147">rdau:P60147</a>
    /// </summary>
    let P60147 = _prefixId.prefix "P60147"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : puppeteer</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by manipulating, controlling, or directing puppets or marionettes in a moving image production or a musical or dramatic presentation or entertainment.</para>
    ///   <para>rdfs:label : has puppeteer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60148">rdau:P60148</a>
    /// </summary>
    let P60148 = _prefixId.prefix "P60148"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : panelist</para>
    ///   <para>rdfs:label : has panelist</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by participating in a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60149">rdau:P60149</a>
    /// </summary>
    let P60149 = _prefixId.prefix "P60149"
    /// <summary>
    ///   <para>rdfs:label : has instrumentalist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalist</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by playing a musical instrument.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60150">rdau:P60150</a>
    /// </summary>
    let P60150 = _prefixId.prefix "P60150"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by providing interpretation, analysis, or a discussion of the subject matter on a recording, film, or other audiovisual medium.</para>
    ///   <para>rdfs:label : has commentator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60151">rdau:P60151</a>
    /// </summary>
    let P60151 = _prefixId.prefix "P60151"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : voiceActor</para>
    ///   <para>rdfs:label : has voice actor</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by providing the voice for characters in radio and audio productions and for animated characters in moving image resources as well as by providing voice-overs in radio and television commercials, dubbed resources, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60152">rdau:P60152</a>
    /// </summary>
    let P60152 = _prefixId.prefix "P60152"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by reading aloud or giving an account of an act, occurrence, course of events, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : narrator</para>
    ///   <para>rdfs:label : has narrator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60153">rdau:P60153</a>
    /// </summary>
    let P60153 = _prefixId.prefix "P60153"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : storyteller</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by relaying a creator's original story with dramatic or theatrical interpretation.</para>
    ///   <para>rdfs:label : has storyteller</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60154">rdau:P60154</a>
    /// </summary>
    let P60154 = _prefixId.prefix "P60154"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : speaker</para>
    ///   <para>rdfs:label : has speaker</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by speaking words, such as a lecture, speech, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60155">rdau:P60155</a>
    /// </summary>
    let P60155 = _prefixId.prefix "P60155"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : singer</para>
    ///   <para>skos:definition : Relates a resource to a performer contributing to a resource by using his/her/their voice, with or without instrumental accompaniment, to produce music. a singer’s performance may or may not include actual words.</para>
    ///   <para>rdfs:label : has singer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60156">rdau:P60156</a>
    /// </summary>
    let P60156 = _prefixId.prefix "P60156"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : medium</para>
    ///   <para>skos:definition : Relates a resource to a person held to be a channel of communication between the earthly world and a world of spirits.</para>
    ///   <para>rdfs:label : has medium</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60157">rdau:P60157</a>
    /// </summary>
    let P60157 = _prefixId.prefix "P60157"
    let P60158 = _prefixId.prefix "P60158"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a physical or chemical substance applied to a base material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appliedMaterial</para>
    ///   <para>rdfs:label : has applied material</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60159">rdau:P60159</a>
    /// </summary>
    let P60159 = _prefixId.prefix "P60159"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place associated with the distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDistribution</para>
    ///   <para>rdfs:label : has place of distribution</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60160">rdau:P60160</a>
    /// </summary>
    let P60160 = _prefixId.prefix "P60160"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfProduction</para>
    ///   <para>rdfs:label : has place of production</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60161">rdau:P60161</a>
    /// </summary>
    let P60161 = _prefixId.prefix "P60161"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfManufacture</para>
    ///   <para>rdfs:label : has place of manufacture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60162">rdau:P60162</a>
    /// </summary>
    let P60162 = _prefixId.prefix "P60162"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfPublication</para>
    ///   <para>rdfs:label : has place of publication</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60163">rdau:P60163</a>
    /// </summary>
    let P60163 = _prefixId.prefix "P60163"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place of distribution in a language and/or script that differs from that recorded in the place of distribution element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfDistribution</para>
    ///   <para>rdfs:label : has parallel place of distribution</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60164">rdau:P60164</a>
    /// </summary>
    let P60164 = _prefixId.prefix "P60164"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place of manufacture in a language and/or script that differs from that recorded in the place of manufacture element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfManufacture</para>
    ///   <para>rdfs:label : has parallel place of manufacture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60165">rdau:P60165</a>
    /// </summary>
    let P60165 = _prefixId.prefix "P60165"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place of production in a language and/or script that differs from that recorded in the place of production element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfProduction</para>
    ///   <para>rdfs:label : has parallel place of production</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60166">rdau:P60166</a>
    /// </summary>
    let P60166 = _prefixId.prefix "P60166"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a place of publication in a language and/or script that differs from that recorded in the place of publication element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfPublication</para>
    ///   <para>rdfs:label : has parallel place of publication</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60167">rdau:P60167</a>
    /// </summary>
    let P60167 = _prefixId.prefix "P60167"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintOf</para>
    ///   <para>rdfs:label : is reprint of</para>
    ///   <para>skos:definition : Relates a resource to a printed resource that is used as the basis for a reissue with the same content as the resource being described.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60168">rdau:P60168</a>
    /// </summary>
    let P60168 = _prefixId.prefix "P60168"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a producer responsible for most of the business aspects of a film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmProducer</para>
    ///   <para>rdfs:label : has film producer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60169">rdau:P60169</a>
    /// </summary>
    let P60169 = _prefixId.prefix "P60169"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProducer</para>
    ///   <para>rdfs:label : has radio producer</para>
    ///   <para>skos:definition : Relates a resource to a producer responsible for most of the business aspects of a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60170">rdau:P60170</a>
    /// </summary>
    let P60170 = _prefixId.prefix "P60170"
    /// <summary>
    ///   <para>rdfs:label : has television producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProducer</para>
    ///   <para>skos:definition : Relates a resource to a producer responsible for most of the business aspects of a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60171">rdau:P60171</a>
    /// </summary>
    let P60171 = _prefixId.prefix "P60171"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a producer's name in a language and/or script that differs from that recorded in the producer's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelProducersName</para>
    ///   <para>rdfs:label : has parallel producer’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60172">rdau:P60172</a>
    /// </summary>
    let P60172 = _prefixId.prefix "P60172"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a publisher's name in a language and/or script that differs from that recorded in the publisher's name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPublishersName</para>
    ///   <para>rdfs:label : has parallel publisher’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60173">rdau:P60173</a>
    /// </summary>
    let P60173 = _prefixId.prefix "P60173"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a radio program based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as radio program</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioProgram</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60174">rdau:P60174</a>
    /// </summary>
    let P60174 = _prefixId.prefix "P60174"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a rank conferred as a guarantee of academic proficiency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : academicDegree</para>
    ///   <para>rdfs:label : has academic degree</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60175">rdau:P60175</a>
    /// </summary>
    let P60175 = _prefixId.prefix "P60175"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a record of previous ownership or custodianship of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodialHistoryOfResource</para>
    ///   <para>rdfs:label : has custodial history of resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60176">rdau:P60176</a>
    /// </summary>
    let P60176 = _prefixId.prefix "P60176"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource (an abstracting and indexing service) that abstracts the contents of a source entity.</para>
    ///   <para>rdfs:label : is abstracted in</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedIn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60177">rdau:P60177</a>
    /// </summary>
    let P60177 = _prefixId.prefix "P60177"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexedIn</para>
    ///   <para>rdfs:label : is indexed in</para>
    ///   <para>skos:definition : Relates a resource to a resource (an abstracting and indexing service) that indexes the contents of the source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60178">rdau:P60178</a>
    /// </summary>
    let P60178 = _prefixId.prefix "P60178"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimile</para>
    ///   <para>rdfs:label : is preservation facsimile</para>
    ///   <para>skos:definition : Relates a resource to a resource that consists of an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60179">rdau:P60179</a>
    /// </summary>
    let P60179 = _prefixId.prefix "P60179"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsChoreography</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of movement (e.g., dance) based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as choreography</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60180">rdau:P60180</a>
    /// </summary>
    let P60180 = _prefixId.prefix "P60180"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errata</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of errors discovered after the publication of the predominant resource, with their corrections.</para>
    ///   <para>rdfs:label : is errata</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60181">rdau:P60181</a>
    /// </summary>
    let P60181 = _prefixId.prefix "P60181"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource consisting of pictorial content designed to explain or decorate the augmented resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrations</para>
    ///   <para>rdfs:label : is illustrations</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60182">rdau:P60182</a>
    /// </summary>
    let P60182 = _prefixId.prefix "P60182"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insert</para>
    ///   <para>rdfs:label : is insert</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of separately issued material that is not an integral part of the larger resource into which it has been inserted.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60183">rdau:P60183</a>
    /// </summary>
    let P60183 = _prefixId.prefix "P60183"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureScreenplay</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of the screenplay for a motion picture, based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as motion picture screenplay</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60184">rdau:P60184</a>
    /// </summary>
    let P60184 = _prefixId.prefix "P60184"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAScreenplay</para>
    ///   <para>rdfs:label : is adapted as a screenplay</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of the screenplay for a motion picture, television program, or video, based on the source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60185">rdau:P60185</a>
    /// </summary>
    let P60185 = _prefixId.prefix "P60185"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionScreenplay</para>
    ///   <para>rdfs:label : is adapted as television screenplay</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of the screenplay for a television program, based on the source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60186">rdau:P60186</a>
    /// </summary>
    let P60186 = _prefixId.prefix "P60186"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource consisting of the screenplay for a video, based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as video screenplay</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoScreenplay</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60187">rdau:P60187</a>
    /// </summary>
    let P60187 = _prefixId.prefix "P60187"
    /// <summary>
    ///   <para>rdfs:label : is adapted as radio script</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioScript</para>
    ///   <para>skos:definition : Relates a resource to a resource consisting of the script for a radio program, based on the source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60188">rdau:P60188</a>
    /// </summary>
    let P60188 = _prefixId.prefix "P60188"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freelyTranslatedAs</para>
    ///   <para>rdfs:label : is freely translated as</para>
    ///   <para>skos:definition : Relates a resource to a resource created by freely translating the source resource into another language, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60189">rdau:P60189</a>
    /// </summary>
    let P60189 = _prefixId.prefix "P60189"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource described by a describing entity.</para>
    ///   <para>rdfs:label : is description of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60190">rdau:P60190</a>
    /// </summary>
    let P60190 = _prefixId.prefix "P60190"
    /// <summary>
    ///   <para>rdfs:label : is equivalent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalent</para>
    ///   <para>skos:definition : Relates a resource to a resource that carries the same content as the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60191">rdau:P60191</a>
    /// </summary>
    let P60191 = _prefixId.prefix "P60191"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource in which the part consistently appears; the title of the larger resource appears on all issues or parts of the subseries.</para>
    ///   <para>rdfs:label : is subseries of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseriesOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60192">rdau:P60192</a>
    /// </summary>
    let P60192 = _prefixId.prefix "P60192"
    /// <summary>
    ///   <para>rdfs:label : is in series</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inSeries</para>
    ///   <para>skos:definition : Relates a resource to a resource in which the part has been issued; the title of the larger resource appears on the part.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60193">rdau:P60193</a>
    /// </summary>
    let P60193 = _prefixId.prefix "P60193"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insertedIn</para>
    ///   <para>rdfs:label : is inserted in</para>
    ///   <para>skos:definition : Relates a resource to a resource into which material has been inserted that is not an integral part of the publication.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60194">rdau:P60194</a>
    /// </summary>
    let P60194 = _prefixId.prefix "P60194"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alsoIssuedAs</para>
    ///   <para>rdfs:label : is also issued as</para>
    ///   <para>skos:definition : Relates a resource to a resource that carries the same content of a resource in a different format.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60195">rdau:P60195</a>
    /// </summary>
    let P60195 = _prefixId.prefix "P60195"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource issued with another resource, without any relationship to its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompaniedBy</para>
    ///   <para>rdfs:label : is accompanied by</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60196">rdau:P60196</a>
    /// </summary>
    let P60196 = _prefixId.prefix "P60196"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that is an exact copy of a website , used to reduce network traffic or improve the availability of the content of the original site.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mirrorSite</para>
    ///   <para>rdfs:label : is mirror site</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60197">rdau:P60197</a>
    /// </summary>
    let P60197 = _prefixId.prefix "P60197"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource paired with another resource without either resource being considered to predominate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementedBy</para>
    ///   <para>rdfs:label : is complemented by</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60198">rdau:P60198</a>
    /// </summary>
    let P60198 = _prefixId.prefix "P60198"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedInPartBy</para>
    ///   <para>rdfs:label : is continued in part by</para>
    ///   <para>skos:definition : Relates a resource to a resource part of whose content separated from an earlier resource to form a new resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60199">rdau:P60199</a>
    /// </summary>
    let P60199 = _prefixId.prefix "P60199"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource in a digital format that results from the transfer of a resource in another digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransfer</para>
    ///   <para>rdfs:label : is digital transfer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60200">rdau:P60200</a>
    /// </summary>
    let P60200 = _prefixId.prefix "P60200"
    /// <summary>
    ///   <para>rdfs:label : is screenplay for</para>
    ///   <para>skos:definition : Relates a resource to a resource such as a motion picture, television program, or video, that uses the text of the resource as a screenplay.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayFor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60201">rdau:P60201</a>
    /// </summary>
    let P60201 = _prefixId.prefix "P60201"
    /// <summary>
    ///   <para>rdfs:label : is incidental music for</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incidentalMusicFor</para>
    ///   <para>skos:definition : Relates a resource to a resource such as a play or other spoken work for the stage that uses the musical resource as incidental music.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60202">rdau:P60202</a>
    /// </summary>
    let P60202 = _prefixId.prefix "P60202"
    /// <summary>
    ///   <para>rdfs:label : is abstracted as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedAs</para>
    ///   <para>skos:definition : Relates a resource to a resource that abbreviates the source resource in a brief, objective manner.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60203">rdau:P60203</a>
    /// </summary>
    let P60203 = _prefixId.prefix "P60203"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentedBy</para>
    ///   <para>skos:definition : Relates a resource to a resource that adds to the content of a predominant resource.</para>
    ///   <para>rdfs:label : is augmented by</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60204">rdau:P60204</a>
    /// </summary>
    let P60204 = _prefixId.prefix "P60204"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summarizedAs</para>
    ///   <para>rdfs:label : is summarized as</para>
    ///   <para>skos:definition : Relates a resource to a resource that consists of a brief recapitulation of the content of the source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60205">rdau:P60205</a>
    /// </summary>
    let P60205 = _prefixId.prefix "P60205"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogue</para>
    ///   <para>skos:definition : Relates a resource to a resource that consists of a complete enumeration of resources arranged systematically.</para>
    ///   <para>rdfs:label : is catalogue</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60206">rdau:P60206</a>
    /// </summary>
    let P60206 = _prefixId.prefix "P60206"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssue</para>
    ///   <para>rdfs:label : is special issue</para>
    ///   <para>skos:definition : Relates a resource to a resource that consists of a single issue or a supplementary section of a serial or newspaper devoted to a special subject.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60207">rdau:P60207</a>
    /// </summary>
    let P60207 = _prefixId.prefix "P60207"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that consists of an index of all the words in the predominant resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordance</para>
    ///   <para>rdfs:label : is concordance</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60208">rdau:P60208</a>
    /// </summary>
    let P60208 = _prefixId.prefix "P60208"
    /// <summary>
    ///   <para>rdfs:label : is addenda</para>
    ///   <para>skos:definition : Relates a resource to a resource that consists of brief additional material, less extensive than a supplement, but essential to the completeness of the text of the predominant resource; it is usually added at the end of the content, but is sometimes issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addenda</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60209">rdau:P60209</a>
    /// </summary>
    let P60209 = _prefixId.prefix "P60209"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource consisting of the text of an opera or other resource for the musical stage, or an oratorio, based on the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsLibretto</para>
    ///   <para>rdfs:label : is adapted as libretto</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60210">rdau:P60210</a>
    /// </summary>
    let P60210 = _prefixId.prefix "P60210"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedIn</para>
    ///   <para>rdfs:label : is reviewed in</para>
    ///   <para>skos:definition : Relates a resource to a resource that contains a brief evaluation of the described resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60211">rdau:P60211</a>
    /// </summary>
    let P60211 = _prefixId.prefix "P60211"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedIn</para>
    ///   <para>skos:definition : Relates a resource to a resource that contains a critical evaluation of the described resource.</para>
    ///   <para>rdfs:label : is critiqued in</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60212">rdau:P60212</a>
    /// </summary>
    let P60212 = _prefixId.prefix "P60212"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryIn</para>
    ///   <para>rdfs:label : is commentary in</para>
    ///   <para>skos:definition : Relates a resource to a resource that contains a set of explanatory or critical notes on the described resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60213">rdau:P60213</a>
    /// </summary>
    let P60213 = _prefixId.prefix "P60213"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that copies the style or content of the source resource.</para>
    ///   <para>rdfs:label : is imitated as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitatedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60214">rdau:P60214</a>
    /// </summary>
    let P60214 = _prefixId.prefix "P60214"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that describes a described entity.</para>
    ///   <para>rdfs:label : is described in</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedIn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60215">rdau:P60215</a>
    /// </summary>
    let P60215 = _prefixId.prefix "P60215"
    /// <summary>
    ///   <para>rdfs:label : is expanded as</para>
    ///   <para>skos:definition : Relates a resource to a resource that enlarges upon the content of the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60216">rdau:P60216</a>
    /// </summary>
    let P60216 = _prefixId.prefix "P60216"
    /// <summary>
    ///   <para>rdfs:label : is facsimile</para>
    ///   <para>skos:definition : Relates a resource to a resource that exactly reproduces another resource embodying the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimile</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60217">rdau:P60217</a>
    /// </summary>
    let P60217 = _prefixId.prefix "P60217"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that examines or judges the described resource.</para>
    ///   <para>rdfs:label : is evaluated in</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedIn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60218">rdau:P60218</a>
    /// </summary>
    let P60218 = _prefixId.prefix "P60218"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedIn</para>
    ///   <para>skos:definition : Relates a resource to a resource that examines the source resource to identify its components and their relations.</para>
    ///   <para>rdfs:label : is analysed in</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60219">rdau:P60219</a>
    /// </summary>
    let P60219 = _prefixId.prefix "P60219"
    /// <summary>
    ///   <para>rdfs:label : is prequel</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequel</para>
    ///   <para>skos:definition : Relates a resource to a resource that extends the narrative of an earlier resource backwards in time.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60220">rdau:P60220</a>
    /// </summary>
    let P60220 = _prefixId.prefix "P60220"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that forms an augmenting part of another resource which is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; it can either be material which comes at the end of the content of the predominant resource, or be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendix</para>
    ///   <para>rdfs:label : is appendix</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60221">rdau:P60221</a>
    /// </summary>
    let P60221 = _prefixId.prefix "P60221"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guide</para>
    ///   <para>rdfs:label : is guide</para>
    ///   <para>skos:definition : Relates a resource to a resource that guides a user through the use of the predominant resource, using notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60222">rdau:P60222</a>
    /// </summary>
    let P60222 = _prefixId.prefix "P60222"
    /// <summary>
    ///   <para>rdfs:label : is abridgement of</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been abridged, i.e., shortened without changing the general meaning or manner of presentation of the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgementOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60223">rdau:P60223</a>
    /// </summary>
    let P60223 = _prefixId.prefix "P60223"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been abstracted, i.e., abbreviated in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractOf</para>
    ///   <para>rdfs:label : is abstract of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60224">rdau:P60224</a>
    /// </summary>
    let P60224 = _prefixId.prefix "P60224"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a drama.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizationOf</para>
    ///   <para>rdfs:label : is dramatization of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60225">rdau:P60225</a>
    /// </summary>
    let P60225 = _prefixId.prefix "P60225"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a literary composition in verse form.</para>
    ///   <para>rdfs:label : is verse adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60226">rdau:P60226</a>
    /// </summary>
    let P60226 = _prefixId.prefix "P60226"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a motion picture.</para>
    ///   <para>rdfs:label : is motion picture adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60227">rdau:P60227</a>
    /// </summary>
    let P60227 = _prefixId.prefix "P60227"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationOf</para>
    ///   <para>rdfs:label : is novelization of</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a novel.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60228">rdau:P60228</a>
    /// </summary>
    let P60228 = _prefixId.prefix "P60228"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a radio program.</para>
    ///   <para>rdfs:label : is radio adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60229">rdau:P60229</a>
    /// </summary>
    let P60229 = _prefixId.prefix "P60229"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a television program.</para>
    ///   <para>rdfs:label : is television adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60230">rdau:P60230</a>
    /// </summary>
    let P60230 = _prefixId.prefix "P60230"
    /// <summary>
    ///   <para>rdfs:label : is screenplay based on</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as the screenplay for a motion picture, television program, or video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayBasedOn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60231">rdau:P60231</a>
    /// </summary>
    let P60231 = _prefixId.prefix "P60231"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayBasedOn</para>
    ///   <para>rdfs:label : is motion picture screenplay based on</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as the screenplay for a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60232">rdau:P60232</a>
    /// </summary>
    let P60232 = _prefixId.prefix "P60232"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as the screenplay for a television program.</para>
    ///   <para>rdfs:label : is television screenplay based on</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayBasedOn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60233">rdau:P60233</a>
    /// </summary>
    let P60233 = _prefixId.prefix "P60233"
    /// <summary>
    ///   <para>rdfs:label : is video screenplay based on</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayBasedOn</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as the screenplay for a video.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60234">rdau:P60234</a>
    /// </summary>
    let P60234 = _prefixId.prefix "P60234"
    /// <summary>
    ///   <para>rdfs:label : is radio script based on</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as the script for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptBasedOn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60235">rdau:P60235</a>
    /// </summary>
    let P60235 = _prefixId.prefix "P60235"
    /// <summary>
    ///   <para>rdfs:label : is video adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoAdaptationOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted for video.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60236">rdau:P60236</a>
    /// </summary>
    let P60236 = _prefixId.prefix "P60236"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been bound within the same binding as the resource being described.</para>
    ///   <para>rdfs:label : is bound with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : boundWith</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60237">rdau:P60237</a>
    /// </summary>
    let P60237 = _prefixId.prefix "P60237"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been digested, i.e., systematically and comprehensively condensed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestOf</para>
    ///   <para>rdfs:label : is digest of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60238">rdau:P60238</a>
    /// </summary>
    let P60238 = _prefixId.prefix "P60238"
    /// <summary>
    ///   <para>rdfs:label : is analysis of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been examined to identify its components and their relations.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60239">rdau:P60239</a>
    /// </summary>
    let P60239 = _prefixId.prefix "P60239"
    /// <summary>
    ///   <para>rdfs:label : is series container of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesContainerOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been issued as part of a series.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60240">rdau:P60240</a>
    /// </summary>
    let P60240 = _prefixId.prefix "P60240"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been modified for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptationOf</para>
    ///   <para>rdfs:label : is adaptation of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60241">rdau:P60241</a>
    /// </summary>
    let P60241 = _prefixId.prefix "P60241"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource that has been rewritten for a medium of performance different from that for which the resource was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangementOf</para>
    ///   <para>rdfs:label : is arrangement of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60242">rdau:P60242</a>
    /// </summary>
    let P60242 = _prefixId.prefix "P60242"
    /// <summary>
    ///   <para>rdfs:label : is free translation of</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been translated freely, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freeTranslationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60243">rdau:P60243</a>
    /// </summary>
    let P60243 = _prefixId.prefix "P60243"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been translated, i.e., the text expressed in a language different from that of the original resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translationOf</para>
    ///   <para>rdfs:label : is translation of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60244">rdau:P60244</a>
    /// </summary>
    let P60244 = _prefixId.prefix "P60244"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been updated, corrected, or expanded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : revisedAs</para>
    ///   <para>rdfs:label : is revised as</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60245">rdau:P60245</a>
    /// </summary>
    let P60245 = _prefixId.prefix "P60245"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that imitates the style or content of the source resource for comic effect.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodiedAs</para>
    ///   <para>rdfs:label : is parodied as</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60246">rdau:P60246</a>
    /// </summary>
    let P60246 = _prefixId.prefix "P60246"
    /// <summary>
    ///   <para>rdfs:label : is absorbed by</para>
    ///   <para>skos:definition : Relates a resource to a resource that incorporates another resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedBy</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60247">rdau:P60247</a>
    /// </summary>
    let P60247 = _prefixId.prefix "P60247"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartBy</para>
    ///   <para>rdfs:label : is absorbed in part by</para>
    ///   <para>skos:definition : Relates a resource to a resource that incorporates part of the content of another resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60248">rdau:P60248</a>
    /// </summary>
    let P60248 = _prefixId.prefix "P60248"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that is a discrete component of a larger resource.</para>
    ///   <para>rdfs:label : is container of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60249">rdau:P60249</a>
    /// </summary>
    let P60249 = _prefixId.prefix "P60249"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivative</para>
    ///   <para>rdfs:label : is derivative</para>
    ///   <para>skos:definition : Relates a resource to a resource that is a modification of a source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60250">rdau:P60250</a>
    /// </summary>
    let P60250 = _prefixId.prefix "P60250"
    /// <summary>
    ///   <para>rdfs:label : is errata to</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataTo</para>
    ///   <para>skos:definition : Relates a resource to a resource that is augmented by a list of errors in the predominant resource, discovered after publication, with their corrections.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60251">rdau:P60251</a>
    /// </summary>
    let P60251 = _prefixId.prefix "P60251"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideTo</para>
    ///   <para>rdfs:label : is guide to</para>
    ///   <para>skos:definition : Relates a resource to a resource that is augmented by another resource consisting of material to help the user of the predominant resource, such as notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60252">rdau:P60252</a>
    /// </summary>
    let P60252 = _prefixId.prefix "P60252"
    /// <summary>
    ///   <para>rdfs:label : is appendix to</para>
    ///   <para>skos:definition : Relates a resource to a resource that is augmented by another resource that consists of material that is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; the augmenting resource can either come at the end of the content, or be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixTo</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60253">rdau:P60253</a>
    /// </summary>
    let P60253 = _prefixId.prefix "P60253"
    /// <summary>
    ///   <para>rdfs:label : is illustrations for</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsFor</para>
    ///   <para>skos:definition : Relates a resource to a resource that is augmented by pictorial content designed to explain or decorate it.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60254">rdau:P60254</a>
    /// </summary>
    let P60254 = _prefixId.prefix "P60254"
    /// <summary>
    ///   <para>rdfs:label : is evaluation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that is examined or judged.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60255">rdau:P60255</a>
    /// </summary>
    let P60255 = _prefixId.prefix "P60255"
    /// <summary>
    ///   <para>rdfs:label : is issued with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuedWith</para>
    ///   <para>skos:definition : Relates a resource to a resource that is issued on the same carrier as the resource being described.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60256">rdau:P60256</a>
    /// </summary>
    let P60256 = _prefixId.prefix "P60256"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onDiscWith</para>
    ///   <para>skos:definition : Relates a resource to a resource that is issued on the same disc with the resource being described.</para>
    ///   <para>rdfs:label : is on disc with</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60257">rdau:P60257</a>
    /// </summary>
    let P60257 = _prefixId.prefix "P60257"
    /// <summary>
    ///   <para>rdfs:label : is filmed with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmedWith</para>
    ///   <para>skos:definition : Relates a resource to a resource that is issued on the same microform with the resource being described.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60258">rdau:P60258</a>
    /// </summary>
    let P60258 = _prefixId.prefix "P60258"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementTo</para>
    ///   <para>rdfs:label : is supplement to</para>
    ///   <para>skos:definition : Relates a resource to a resource that is updated or otherwise complemented by the augmenting resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60259">rdau:P60259</a>
    /// </summary>
    let P60259 = _prefixId.prefix "P60259"
    /// <summary>
    ///   <para>rdfs:label : is adapted as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAs</para>
    ///   <para>skos:definition : Relates a resource to a resource that modifies the source resource for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60260">rdau:P60260</a>
    /// </summary>
    let P60260 = _prefixId.prefix "P60260"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that precedes (e.g., is earlier in time or before in a narrative) the succeeding resource.</para>
    ///   <para>rdfs:label : is preceded by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : precededBy</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60261">rdau:P60261</a>
    /// </summary>
    let P60261 = _prefixId.prefix "P60261"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that provides a guide to the organization, arrangement, and contents of an archival collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAid</para>
    ///   <para>rdfs:label : is finding aid</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60262">rdau:P60262</a>
    /// </summary>
    let P60262 = _prefixId.prefix "P60262"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : index</para>
    ///   <para>skos:definition : Relates a resource to a resource that provides a systematic, alphabetical guide to the contents of the predominant resource, usually keyed to page numbers or other reference codes.</para>
    ///   <para>rdfs:label : is index</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60263">rdau:P60263</a>
    /// </summary>
    let P60263 = _prefixId.prefix "P60263"
    /// <summary>
    ///   <para>rdfs:label : is screenplay</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplay</para>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text for a motion picture, television program or video.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60264">rdau:P60264</a>
    /// </summary>
    let P60264 = _prefixId.prefix "P60264"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text for a motion picture.</para>
    ///   <para>rdfs:label : is motion picture screenplay</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplay</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60265">rdau:P60265</a>
    /// </summary>
    let P60265 = _prefixId.prefix "P60265"
    /// <summary>
    ///   <para>rdfs:label : is musical setting of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text for a non-dramatic musical resource, other than an oratorio.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60266">rdau:P60266</a>
    /// </summary>
    let P60266 = _prefixId.prefix "P60266"
    /// <summary>
    ///   <para>rdfs:label : is radio script</para>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScript</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60267">rdau:P60267</a>
    /// </summary>
    let P60267 = _prefixId.prefix "P60267"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplay</para>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text for a television program.</para>
    ///   <para>rdfs:label : is television screenplay</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60268">rdau:P60268</a>
    /// </summary>
    let P60268 = _prefixId.prefix "P60268"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplay</para>
    ///   <para>rdfs:label : is video screenplay</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60269">rdau:P60269</a>
    /// </summary>
    let P60269 = _prefixId.prefix "P60269"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : libretto</para>
    ///   <para>skos:definition : Relates a resource to a resource that provides the text of an opera or other resource for the musical stage, or an oratorio.</para>
    ///   <para>rdfs:label : is libretto</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60270">rdau:P60270</a>
    /// </summary>
    let P60270 = _prefixId.prefix "P60270"
    /// <summary>
    ///   <para>rdfs:label : is reprinted as</para>
    ///   <para>skos:definition : Relates a resource to a resource that reissues the same expression of the resource as the printed resource being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60271">rdau:P60271</a>
    /// </summary>
    let P60271 = _prefixId.prefix "P60271"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that reproduces another resource.</para>
    ///   <para>rdfs:label : is reproduced as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproducedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60272">rdau:P60272</a>
    /// </summary>
    let P60272 = _prefixId.prefix "P60272"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphrasedAs</para>
    ///   <para>rdfs:label : is paraphrased as</para>
    ///   <para>skos:definition : Relates a resource to a resource that restates the content of the source resource in a different form.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60273">rdau:P60273</a>
    /// </summary>
    let P60273 = _prefixId.prefix "P60273"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource that rewrites the source resource for a medium of performance different from that for which the resource was originally intended.</para>
    ///   <para>rdfs:label : is arranged as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60274">rdau:P60274</a>
    /// </summary>
    let P60274 = _prefixId.prefix "P60274"
    /// <summary>
    ///   <para>rdfs:label : is abridged as</para>
    ///   <para>skos:definition : Relates a resource to a resource that shortens the source resource without changing the general meaning or manner of presentation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60275">rdau:P60275</a>
    /// </summary>
    let P60275 = _prefixId.prefix "P60275"
    /// <summary>
    ///   <para>rdfs:label : is continuation in part of</para>
    ///   <para>skos:definition : Relates a resource to a resource that split into two or more separate resources with new titles.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuationInPartOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60276">rdau:P60276</a>
    /// </summary>
    let P60276 = _prefixId.prefix "P60276"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that spun off a part of its content to form a new resource.</para>
    ///   <para>rdfs:label : is separated from</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : separatedFrom</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60277">rdau:P60277</a>
    /// </summary>
    let P60277 = _prefixId.prefix "P60277"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that succeeds (e.g., later in time or after in a narrative) the preceding resource.</para>
    ///   <para>rdfs:label : is succeeded by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : succeededBy</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60278">rdau:P60278</a>
    /// </summary>
    let P60278 = _prefixId.prefix "P60278"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that systematically and comprehensively condenses the source resource.</para>
    ///   <para>rdfs:label : is digested as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60279">rdau:P60279</a>
    /// </summary>
    let P60279 = _prefixId.prefix "P60279"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatedAs</para>
    ///   <para>rdfs:label : is translated as</para>
    ///   <para>skos:definition : Relates a resource to a resource that translates the text of the source entity into a language different from that of the original resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60280">rdau:P60280</a>
    /// </summary>
    let P60280 = _prefixId.prefix "P60280"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that updates or otherwise complements the predominant resource.</para>
    ///   <para>rdfs:label : is supplement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60281">rdau:P60281</a>
    /// </summary>
    let P60281 = _prefixId.prefix "P60281"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the text as a screenplay for a motion picture.</para>
    ///   <para>rdfs:label : is screenplay for motion picture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheMotionPicture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60282">rdau:P60282</a>
    /// </summary>
    let P60282 = _prefixId.prefix "P60282"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the text as a screenplay for a television program.</para>
    ///   <para>rdfs:label : is screenplay for television program</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheTelevisionProgram</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60283">rdau:P60283</a>
    /// </summary>
    let P60283 = _prefixId.prefix "P60283"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the text as a screenplay for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheVideo</para>
    ///   <para>rdfs:label : is screenplay for video</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60284">rdau:P60284</a>
    /// </summary>
    let P60284 = _prefixId.prefix "P60284"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the text of the source resource as the script for a radio program.</para>
    ///   <para>rdfs:label : is script for radio program</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptForTheRadioProgram</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60285">rdau:P60285</a>
    /// </summary>
    let P60285 = _prefixId.prefix "P60285"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaTo</para>
    ///   <para>rdfs:label : is addenda to</para>
    ///   <para>skos:definition : Relates a resource to a resource to which is added brief additional material, less extensive than a supplement, but essential to the completeness of the content of the resource; it is usually added at the end of the resource, but is sometimes issued separately.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60286">rdau:P60286</a>
    /// </summary>
    let P60286 = _prefixId.prefix "P60286"
    /// <summary>
    ///   <para>rdfs:label : is digital transfer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferOf</para>
    ///   <para>skos:definition : Relates a resource to a resource in a digital format that is transferred to another digital format.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60287">rdau:P60287</a>
    /// </summary>
    let P60287 = _prefixId.prefix "P60287"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a brief evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOf</para>
    ///   <para>rdfs:label : is review of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60288">rdau:P60288</a>
    /// </summary>
    let P60288 = _prefixId.prefix "P60288"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a brief recapitulation of its content.</para>
    ///   <para>rdfs:label : is summary of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60289">rdau:P60289</a>
    /// </summary>
    let P60289 = _prefixId.prefix "P60289"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a catalogue, i.e., a complete enumeration of resources arranged systematically.</para>
    ///   <para>rdfs:label : is catalogue of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60290">rdau:P60290</a>
    /// </summary>
    let P60290 = _prefixId.prefix "P60290"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a concordance, i.e. an index of all the words in the predominant resource.</para>
    ///   <para>rdfs:label : is concordance to</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceTo</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60291">rdau:P60291</a>
    /// </summary>
    let P60291 = _prefixId.prefix "P60291"
    /// <summary>
    ///   <para>rdfs:label : is critique of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOf</para>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a critical evaluation.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60292">rdau:P60292</a>
    /// </summary>
    let P60292 = _prefixId.prefix "P60292"
    /// <summary>
    ///   <para>rdfs:label : is choreographic adaptation of</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a resource consisting of movement (e.g., dance).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographicAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60293">rdau:P60293</a>
    /// </summary>
    let P60293 = _prefixId.prefix "P60293"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedVersionOf</para>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a derivative resource that enlarges upon the content of the source resource.</para>
    ///   <para>rdfs:label : is expanded version of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60294">rdau:P60294</a>
    /// </summary>
    let P60294 = _prefixId.prefix "P60294"
    /// <summary>
    ///   <para>rdfs:label : is remake of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remakeOf</para>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a new motion picture, radio program, television program, or video.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60295">rdau:P60295</a>
    /// </summary>
    let P60295 = _prefixId.prefix "P60295"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a paraphrase, i.e., a restating of the content of the source resource in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphraseOf</para>
    ///   <para>rdfs:label : is paraphrase of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60296">rdau:P60296</a>
    /// </summary>
    let P60296 = _prefixId.prefix "P60296"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that is used as the basis for a reproduction.</para>
    ///   <para>rdfs:label : is reproduction of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproductionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60297">rdau:P60297</a>
    /// </summary>
    let P60297 = _prefixId.prefix "P60297"
    /// <summary>
    ///   <para>rdfs:label : is commentary on</para>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOn</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60298">rdau:P60298</a>
    /// </summary>
    let P60298 = _prefixId.prefix "P60298"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that is used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileOf</para>
    ///   <para>rdfs:label : is preservation facsimile of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60299">rdau:P60299</a>
    /// </summary>
    let P60299 = _prefixId.prefix "P60299"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for an exact reproduction that is a discrete component of a larger entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileContainerOf</para>
    ///   <para>rdfs:label : is facsimile container of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60300">rdau:P60300</a>
    /// </summary>
    let P60300 = _prefixId.prefix "P60300"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that is used as the basis for an exact reproduction.</para>
    ///   <para>rdfs:label : is facsimile of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60301">rdau:P60301</a>
    /// </summary>
    let P60301 = _prefixId.prefix "P60301"
    /// <summary>
    ///   <para>rdfs:label : is index to</para>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for an index, i.e., a systematic, alphabetical guide to the contents of the predominant resource, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexTo</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60302">rdau:P60302</a>
    /// </summary>
    let P60302 = _prefixId.prefix "P60302"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource used as the basis for an updated, corrected, or expanded version.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : revisionOf</para>
    ///   <para>rdfs:label : is revision of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60303">rdau:P60303</a>
    /// </summary>
    let P60303 = _prefixId.prefix "P60303"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoBasedOn</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as the text of an opera or other resource for the musical stage, or an oratorio.</para>
    ///   <para>rdfs:label : is libretto based on</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60304">rdau:P60304</a>
    /// </summary>
    let P60304 = _prefixId.prefix "P60304"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basedOn</para>
    ///   <para>rdfs:label : is based on</para>
    ///   <para>skos:definition : Relates a resource to a resource used as the source for a derivative resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60305">rdau:P60305</a>
    /// </summary>
    let P60305 = _prefixId.prefix "P60305"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource whose content continues an earlier resource under a new title.</para>
    ///   <para>rdfs:label : is continued by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedBy</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60306">rdau:P60306</a>
    /// </summary>
    let P60306 = _prefixId.prefix "P60306"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentationOf</para>
    ///   <para>skos:definition : Relates a resource to a resource whose content is added to by another resource.</para>
    ///   <para>rdfs:label : is augmentation of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60307">rdau:P60307</a>
    /// </summary>
    let P60307 = _prefixId.prefix "P60307"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractsFor</para>
    ///   <para>skos:definition : Relates a resource to a resource whose contents have been abstracted by an abstracting and indexing service.</para>
    ///   <para>rdfs:label : is abstracts for</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60308">rdau:P60308</a>
    /// </summary>
    let P60308 = _prefixId.prefix "P60308"
    /// <summary>
    ///   <para>rdfs:label : is indexing for</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexingFor</para>
    ///   <para>skos:definition : Relates a resource to a resource whose contents have been indexed by an abstracting and indexing service.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60309">rdau:P60309</a>
    /// </summary>
    let P60309 = _prefixId.prefix "P60309"
    /// <summary>
    ///   <para>rdfs:label : is prequel to</para>
    ///   <para>skos:definition : Relates a resource to a resource whose narrative is extended backwards in time by the later resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequelTo</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60310">rdau:P60310</a>
    /// </summary>
    let P60310 = _prefixId.prefix "P60310"
    /// <summary>
    ///   <para>rdfs:label : is imitation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitationOf</para>
    ///   <para>skos:definition : Relates a resource to a resource whose style or content is copied in a derivative resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60311">rdau:P60311</a>
    /// </summary>
    let P60311 = _prefixId.prefix "P60311"
    /// <summary>
    ///   <para>rdfs:label : is parody of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodyOf</para>
    ///   <para>skos:definition : Relates a resource to a resource whose style or content is imitated for comic effect.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60312">rdau:P60312</a>
    /// </summary>
    let P60312 = _prefixId.prefix "P60312"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedResource</para>
    ///   <para>rdfs:label : has related resource</para>
    ///   <para>skos:definition : Relates a resource to a resource, represented by an identifier, an authorized access point, or a description, that is related to the resource being described.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60313">rdau:P60313</a>
    /// </summary>
    let P60313 = _prefixId.prefix "P60313"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : encodingFormat</para>
    ///   <para>rdfs:label : has encoding format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60314">rdau:P60314</a>
    /// </summary>
    let P60314 = _prefixId.prefix "P60314"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a serial number, opus number, or thematic index number assigned to a musical resource by a composer, publisher, or a musicologist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericDesignationOfAMusicalResource</para>
    ///   <para>rdfs:label : has numeric designation of a musical resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60315">rdau:P60315</a>
    /// </summary>
    let P60315 = _prefixId.prefix "P60315"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a serial or multipart resource that consistently appears in a larger resource; the title of the larger resource appears on all issues or parts of the subseries</para>
    ///   <para>rdfs:label : is subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60316">rdau:P60316</a>
    /// </summary>
    let P60316 = _prefixId.prefix "P60316"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssueOf</para>
    ///   <para>rdfs:label : is special issue of</para>
    ///   <para>skos:definition : Relates a resource to a serial or newspaper containing a single issue or a supplementary section devoted to a special subject, with or without serial numbering, such as an anniversary number of a periodical or newspaper.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60317">rdau:P60317</a>
    /// </summary>
    let P60317 = _prefixId.prefix "P60317"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a set of characters and/or symbols used to express the content of a resource in a form that can be perceived through touch.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfTactileNotation</para>
    ///   <para>rdfs:label : has form of tactile notation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60318">rdau:P60318</a>
    /// </summary>
    let P60318 = _prefixId.prefix "P60318"
    /// <summary>
    ///   <para>rdfs:label : has form of notation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotation</para>
    ///   <para>skos:definition : Relates a resource to a set of characters and/or symbols used to express the content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60319">rdau:P60319</a>
    /// </summary>
    let P60319 = _prefixId.prefix "P60319"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a set of characters and/or symbols used to express the movement content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotatedMovement</para>
    ///   <para>rdfs:label : has form of notated movement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60320">rdau:P60320</a>
    /// </summary>
    let P60320 = _prefixId.prefix "P60320"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a set of characters and/or symbols used to express the musical content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfMusicalNotation</para>
    ///   <para>rdfs:label : has form of musical notation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60321">rdau:P60321</a>
    /// </summary>
    let P60321 = _prefixId.prefix "P60321"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a set of characters and/or symbols used to express the written language content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : script</para>
    ///   <para>rdfs:label : has script</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60322">rdau:P60322</a>
    /// </summary>
    let P60322 = _prefixId.prefix "P60322"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a set of technical details relating to the encoding of geospatial information in a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalRepresentationOfCartographicContent</para>
    ///   <para>rdfs:label : has digital representation of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60323">rdau:P60323</a>
    /// </summary>
    let P60323 = _prefixId.prefix "P60323"
    /// <summary>
    ///   <para>rdfs:label : has date associated with the agent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithTheAgent</para>
    ///   <para>skos:definition : Relates a resource to a significant date associated with an agent (e.g., date of birth, date of death), or the date or range of dates on which a conference, etc., was held, or a date with which an agent is otherwise associated (e.g., date of founding).</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60324">rdau:P60324</a>
    /// </summary>
    let P60324 = _prefixId.prefix "P60324"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAssociatedWithTheAgent</para>
    ///   <para>skos:definition : Relates a resource to a significant location associated with an agent, or a place where an agent resides or has resided or has some connection.</para>
    ///   <para>rdfs:label : has place associated with the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60325">rdau:P60325</a>
    /// </summary>
    let P60325 = _prefixId.prefix "P60325"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoFormat</para>
    ///   <para>rdfs:label : has video format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60326">rdau:P60326</a>
    /// </summary>
    let P60326 = _prefixId.prefix "P60326"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement associated with the title proper of a resource that relates to the identification and/or function of any agents responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToTitleProper</para>
    ///   <para>rdfs:label : has statement of responsibility relating to title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60327">rdau:P60327</a>
    /// </summary>
    let P60327 = _prefixId.prefix "P60327"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying a series to which a resource belongs and the numbering of the resource within the series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesStatement</para>
    ///   <para>rdfs:label : has series statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60328">rdau:P60328</a>
    /// </summary>
    let P60328 = _prefixId.prefix "P60328"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editionStatement</para>
    ///   <para>rdfs:label : has edition statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60329">rdau:P60329</a>
    /// </summary>
    let P60329 = _prefixId.prefix "P60329"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying the place or places of distribution, distributor or distributors, and date or dates of distribution of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributionStatement</para>
    ///   <para>rdfs:label : has distribution statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60330">rdau:P60330</a>
    /// </summary>
    let P60330 = _prefixId.prefix "P60330"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying the place or places of manufacture, manufacturer or manufacturers, and date or dates of manufacture of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufactureStatement</para>
    ///   <para>rdfs:label : has manufacture statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60331">rdau:P60331</a>
    /// </summary>
    let P60331 = _prefixId.prefix "P60331"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying the place or places of production, producer or producers, and date or dates of production of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionStatement</para>
    ///   <para>rdfs:label : has production statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60332">rdau:P60332</a>
    /// </summary>
    let P60332 = _prefixId.prefix "P60332"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement identifying the place or places of publication, publisher or publishers, and date or dates of publication of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publicationStatement</para>
    ///   <para>rdfs:label : has publication statement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60333">rdau:P60333</a>
    /// </summary>
    let P60333 = _prefixId.prefix "P60333"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of responsibility relating to a named revision of an edition in a language and/or script that differs from that recorded in the statement of responsibility relating to a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to a named revision of an edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60334">rdau:P60334</a>
    /// </summary>
    let P60334 = _prefixId.prefix "P60334"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of responsibility relating to series in a language and/or script that differs from that recorded in the statement of responsibility relating to series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSeries</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60335">rdau:P60335</a>
    /// </summary>
    let P60335 = _prefixId.prefix "P60335"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of responsibility relating to subseries in a language and/or script that differs from that recorded in the statement of responsibility relating to subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSubseries</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60336">rdau:P60336</a>
    /// </summary>
    let P60336 = _prefixId.prefix "P60336"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of responsibility relating to the edition in a language and/or script that differs from that recorded in the statement of responsibility relating to the edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTheEdition</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to the edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60337">rdau:P60337</a>
    /// </summary>
    let P60337 = _prefixId.prefix "P60337"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement of responsibility relating to title proper in a language and/or script that differs from that recorded in the statement of responsibility relating to title proper element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTitleProper</para>
    ///   <para>rdfs:label : has parallel statement of responsibility relating to title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60338">rdau:P60338</a>
    /// </summary>
    let P60338 = _prefixId.prefix "P60338"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement relating to the identification and/or function of any agents responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of a resource.</para>
    ///   <para>rdfs:label : has statement of responsibility</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibility</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60339">rdau:P60339</a>
    /// </summary>
    let P60339 = _prefixId.prefix "P60339"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement relating to the identification of any agents responsible for a named revision of an edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : has statement of responsibility relating to a named revision of an edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60340">rdau:P60340</a>
    /// </summary>
    let P60340 = _prefixId.prefix "P60340"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement relating to the identification of any agents responsible for a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSeries</para>
    ///   <para>rdfs:label : has statement of responsibility relating to series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60341">rdau:P60341</a>
    /// </summary>
    let P60341 = _prefixId.prefix "P60341"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement relating to the identification of any agents responsible for a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSubseries</para>
    ///   <para>rdfs:label : has statement of responsibility relating to subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60342">rdau:P60342</a>
    /// </summary>
    let P60342 = _prefixId.prefix "P60342"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a statement relating to the identification of any agents responsible for the edition being described but not to all editions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToTheEdition</para>
    ///   <para>rdfs:label : has statement of responsibility relating to the edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60343">rdau:P60343</a>
    /// </summary>
    let P60343 = _prefixId.prefix "P60343"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : emulsionOnMicrofilmAndMicrofiche</para>
    ///   <para>rdfs:label : has emulsion on microfilm and microfiche</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60344">rdau:P60344</a>
    /// </summary>
    let P60344 = _prefixId.prefix "P60344"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a system for identifying the area covered by the cartographic content of a resource using longitude of the westernmost and easternmost boundaries and latitude of the northernmost and southernmost boundaries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : longitudeAndLatitude</para>
    ///   <para>rdfs:label : has longitude and latitude</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60345">rdau:P60345</a>
    /// </summary>
    let P60345 = _prefixId.prefix "P60345"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a system for identifying the location of a celestial object in the sky covered by the cartographic content of a resource using the angles of right ascension and declination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rightAscensionAndDeclination</para>
    ///   <para>rdfs:label : has right ascension and declination</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60346">rdau:P60346</a>
    /// </summary>
    let P60346 = _prefixId.prefix "P60346"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a system for identifying the precise area covered by the cartographic content of a resource using coordinates for each vertex of a polygon.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stringsOfCoordinatePairs</para>
    ///   <para>rdfs:label : has strings of coordinate pairs</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60347">rdau:P60347</a>
    /// </summary>
    let P60347 = _prefixId.prefix "P60347"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a system of arranging materials in an archival resource or a collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : systemOfOrganization</para>
    ///   <para>rdfs:label : has system of organization</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60348">rdau:P60348</a>
    /// </summary>
    let P60348 = _prefixId.prefix "P60348"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a system used to format a video resource for television broadcast.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcastStandard</para>
    ///   <para>rdfs:label : has broadcast standard</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60349">rdau:P60349</a>
    /// </summary>
    let P60349 = _prefixId.prefix "P60349"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalFileCharacteristic</para>
    ///   <para>skos:definition : Relates a resource to a technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>rdfs:label : has digital file characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60350">rdau:P60350</a>
    /// </summary>
    let P60350 = _prefixId.prefix "P60350"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a technical specification relating to the encoding of sound in a resource.</para>
    ///   <para>rdfs:label : has sound characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundCharacteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60351">rdau:P60351</a>
    /// </summary>
    let P60351 = _prefixId.prefix "P60351"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a technical specification relating to the encoding of video images in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoCharacteristic</para>
    ///   <para>rdfs:label : has video characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60352">rdau:P60352</a>
    /// </summary>
    let P60352 = _prefixId.prefix "P60352"
    /// <summary>
    ///   <para>rdfs:label : has projection characteristic of motion picture film</para>
    ///   <para>skos:definition : Relates a resource to a technical specification relating to the projection of a motion picture film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionCharacteristicOfMotionPictureFilm</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60353">rdau:P60353</a>
    /// </summary>
    let P60353 = _prefixId.prefix "P60353"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a television program based on the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionProgram</para>
    ///   <para>rdfs:label : is adapted as television program</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60354">rdau:P60354</a>
    /// </summary>
    let P60354 = _prefixId.prefix "P60354"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a title associated with a resource that differs from a title recorded as the preferred title, title proper, a parallel title proper, other title information, parallel other title information, earlier title proper, later title proper, key title, or abbreviated title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTitle</para>
    ///   <para>rdfs:label : has variant title</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60355">rdau:P60355</a>
    /// </summary>
    let P60355 = _prefixId.prefix "P60355"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a title of nobility, etc., associated with an agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hereditaryTitle</para>
    ///   <para>rdfs:label : has hereditary title</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60356">rdau:P60356</a>
    /// </summary>
    let P60356 = _prefixId.prefix "P60356"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a title proper appearing on a later issue or part of a multipart monograph or serial that differs from that on the first or earliest issue or part.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : laterTitleProper</para>
    ///   <para>rdfs:label : has later title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60357">rdau:P60357</a>
    /// </summary>
    let P60357 = _prefixId.prefix "P60357"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a title proper appearing on an earlier iteration of an integrating resource that differs from that on the current iteration.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : earlierTitleProper</para>
    ///   <para>rdfs:label : has earlier title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60358">rdau:P60358</a>
    /// </summary>
    let P60358 = _prefixId.prefix "P60358"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a title that has been abbreviated for purposes of indexing or identification.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abbreviatedTitle</para>
    ///   <para>rdfs:label : has abbreviated title</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60359">rdau:P60359</a>
    /// </summary>
    let P60359 = _prefixId.prefix "P60359"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a town, city, province, state, and/or country in which an agent resides or has resided, or another significant place associated with the agent other than place of birth, place of death, or residence (e.g., a place where an agent has worked or studied).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfResidenceEtc</para>
    ///   <para>rdfs:label : has place of residence, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60360">rdau:P60360</a>
    /// </summary>
    let P60360 = _prefixId.prefix "P60360"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a video based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as video</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideo</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60361">rdau:P60361</a>
    /// </summary>
    let P60361 = _prefixId.prefix "P60361"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a well-known individual who is a member of an agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prominentMemberOfTheFamily</para>
    ///   <para>rdfs:label : has prominent member of the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60362">rdau:P60362</a>
    /// </summary>
    let P60362 = _prefixId.prefix "P60362"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word or phrase indicative of royalty, nobility, or ecclesiastical rank or office, a term of address for an agent of religious vocation, or another term indicative of rank, honour, or office.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleOfTheAgent</para>
    ///   <para>rdfs:label : has title of the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60363">rdau:P60363</a>
    /// </summary>
    let P60363 = _prefixId.prefix "P60363"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word, character or group of words and/or characters, identifying a particular revision of a named edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : has designation of a named revision of an edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60364">rdau:P60364</a>
    /// </summary>
    let P60364 = _prefixId.prefix "P60364"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word, character or group of words and/or characters, identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfEdition</para>
    ///   <para>rdfs:label : has designation of edition</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60365">rdau:P60365</a>
    /// </summary>
    let P60365 = _prefixId.prefix "P60365"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word, character, or group of words and/or characters by which a place is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfThePlace</para>
    ///   <para>rdfs:label : has name of the place</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60366">rdau:P60366</a>
    /// </summary>
    let P60366 = _prefixId.prefix "P60366"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word, character, or group of words and/or characters by which a resource is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleOfTheResource</para>
    ///   <para>rdfs:label : has title of the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60367">rdau:P60367</a>
    /// </summary>
    let P60367 = _prefixId.prefix "P60367"
    /// <summary>
    ///   <para>rdfs:label : has name of the agent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheAgent</para>
    ///   <para>skos:definition : Relates a resource to a word, character, or group of words and/or characters by which an agent is known.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60368">rdau:P60368</a>
    /// </summary>
    let P60368 = _prefixId.prefix "P60368"
    /// <summary>
    ///   <para>rdfs:label : has title</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : title</para>
    ///   <para>skos:definition : Relates a resource to a word, character, or group of words and/or characters that names a resource or a resource contained in it.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60369">rdau:P60369</a>
    /// </summary>
    let P60369 = _prefixId.prefix "P60369"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a word, phrase, or abbreviation indicating incorporation or legal status of an agent, or any term serving to differentiate the body from other corporate bodies, persons, etc., or a term other than a title that is associated with an agent’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDesignationAssociatedWithTheAgent</para>
    ///   <para>rdfs:label : has other designation associated with the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60370">rdau:P60370</a>
    /// </summary>
    let P60370 = _prefixId.prefix "P60370"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedLyrics</para>
    ///   <para>rdfs:label : has writer of added lyrics</para>
    ///   <para>skos:definition : Relates a resource to a writer of words added to a musical resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60371">rdau:P60371</a>
    /// </summary>
    let P60371 = _prefixId.prefix "P60371"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an abstract, summary, synopsis, etc., of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summarizationOfTheContent</para>
    ///   <para>rdfs:label : has summarization of the content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60372">rdau:P60372</a>
    /// </summary>
    let P60372 = _prefixId.prefix "P60372"
    /// <summary>
    ///   <para>rdfs:label : has appellee</para>
    ///   <para>skos:definition : Relates a resource to an agent against whom an appeal is taken on the decision of a lower court recorded in a legal resource of a higher court.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellee</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60373">rdau:P60373</a>
    /// </summary>
    let P60373 = _prefixId.prefix "P60373"
    /// <summary>
    ///   <para>rdfs:label : has other agent associated with a resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherAgentAssociatedWithAResource</para>
    ///   <para>skos:scopeNote : Includes book designers, platemakers, etc. Includes persons, etc., to whom correspondence is addressed, persons, etc., honoured by a festschrift, directors, cinematographers, sponsoring bodies, production companies, institutions, etc., hosting an exhibition or event, etc. Includes curators, binders, restorationists, etc.</para>
    ///   <para>skos:definition : Relates a resource to an agent other than a creator, custodian, owner, producer, publisher, distributor or manufacturer associated with a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60374">rdau:P60374</a>
    /// </summary>
    let P60374 = _prefixId.prefix "P60374"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicator</para>
    ///   <para>rdfs:label : has dedicator</para>
    ///   <para>skos:definition : Relates a resource to an agent by whom a resource is dedicated.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60375">rdau:P60375</a>
    /// </summary>
    let P60375 = _prefixId.prefix "P60375"
    /// <summary>
    ///   <para>rdfs:label : has curator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : curator</para>
    ///   <para>skos:definition : Relates a resource to an agent conceiving, aggregating, and/or organizing an exhibition, collection, or other resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60376">rdau:P60376</a>
    /// </summary>
    let P60376 = _prefixId.prefix "P60376"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a cartographic resource by providing measurements or dimensional relationships for the geographic area represented.</para>
    ///   <para>rdfs:label : has surveyor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : surveyor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60377">rdau:P60377</a>
    /// </summary>
    let P60377 = _prefixId.prefix "P60377"
    /// <summary>
    ///   <para>rdfs:label : has animator</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a moving image resource or computer program by giving apparent movement to inanimate objects or drawings.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : animator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60378">rdau:P60378</a>
    /// </summary>
    let P60378 = _prefixId.prefix "P60378"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a musical resource by rewriting the composition for a medium of performance different from that for which the resource was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangerOfMusic</para>
    ///   <para>rdfs:label : has arranger of music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60379">rdau:P60379</a>
    /// </summary>
    let P60379 = _prefixId.prefix "P60379"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a primarily non-textual resource by providing text for the non-textual resource (e.g., writing captions for photographs, descriptions of maps).</para>
    ///   <para>rdfs:label : has writer of added text</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedText</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60380">rdau:P60380</a>
    /// </summary>
    let P60380 = _prefixId.prefix "P60380"
    /// <summary>
    ///   <para>rdfs:label : has draftsman</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : draftsman</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by an architect, inventor, etc., by making detailed plans or drawings for buildings, ships, aircraft, machines, objects, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60381">rdau:P60381</a>
    /// </summary>
    let P60381 = _prefixId.prefix "P60381"
    /// <summary>
    ///   <para>rdfs:label : has transcriber</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transcriber</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by writing down or notating unwritten or unnotated content, or by changing it from one system of notation to another.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60382">rdau:P60382</a>
    /// </summary>
    let P60382 = _prefixId.prefix "P60382"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalDirector</para>
    ///   <para>rdfs:label : has musical director</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by coordinating the activities of the composer, the sound editor, and sound mixers for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60383">rdau:P60383</a>
    /// </summary>
    let P60383 = _prefixId.prefix "P60383"
    /// <summary>
    ///   <para>rdfs:label : has costume designer</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by designing the costumes for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : costumeDesigner</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60384">rdau:P60384</a>
    /// </summary>
    let P60384 = _prefixId.prefix "P60384"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translator</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to an expression of a resource by expressing the linguistic content of the resource in a language different from that of previous expressions of the original resource.</para>
    ///   <para>rdfs:label : has translator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60385">rdau:P60385</a>
    /// </summary>
    let P60385 = _prefixId.prefix "P60385"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by overseeing the artists and craftspeople who build the sets for moving image productions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artDirector</para>
    ///   <para>rdfs:label : has art director</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60386">rdau:P60386</a>
    /// </summary>
    let P60386 = _prefixId.prefix "P60386"
    /// <summary>
    ///   <para>rdfs:label : has performer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performer</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by performing music, acting, dancing, speaking, etc., often in a musical or dramatic presentation, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60387">rdau:P60387</a>
    /// </summary>
    let P60387 = _prefixId.prefix "P60387"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtReporter</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by preparing a court's opinions for publication.</para>
    ///   <para>rdfs:label : has court reporter</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60388">rdau:P60388</a>
    /// </summary>
    let P60388 = _prefixId.prefix "P60388"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPreface</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing a preface to the original resource.</para>
    ///   <para>rdfs:label : has writer of preface</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60389">rdau:P60389</a>
    /// </summary>
    let P60389 = _prefixId.prefix "P60389"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedCommentary</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing an interpretation or critical explanation of the original resource.</para>
    ///   <para>rdfs:label : has writer of added commentary</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60390">rdau:P60390</a>
    /// </summary>
    let P60390 = _prefixId.prefix "P60390"
    /// <summary>
    ///   <para>rdfs:label : has writer of introduction</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing an introduction to the original resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfIntroduction</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60391">rdau:P60391</a>
    /// </summary>
    let P60391 = _prefixId.prefix "P60391"
    /// <summary>
    ///   <para>rdfs:label : has writer of supplementary textual content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfSupplementaryTextualContent</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing supplementary textual content (e.g., an appendix, an introduction, a preface) to the original resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60392">rdau:P60392</a>
    /// </summary>
    let P60392 = _prefixId.prefix "P60392"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editor</para>
    ///   <para>rdfs:label : has editor</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by revising or clarifying the content, e.g., adding an introduction, notes, or other critical matter.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60393">rdau:P60393</a>
    /// </summary>
    let P60393 = _prefixId.prefix "P60393"
    /// <summary>
    ///   <para>rdfs:label : has abridger</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridger</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by shortening or condensing the original resource but leaving the nature and content of the original resource substantially unchanged.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60394">rdau:P60394</a>
    /// </summary>
    let P60394 = _prefixId.prefix "P60394"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by supervising the technical aspects of a sound or video recording session.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingEngineer</para>
    ///   <para>rdfs:label : has recording engineer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60395">rdau:P60395</a>
    /// </summary>
    let P60395 = _prefixId.prefix "P60395"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by supplementing the primary content with drawings, diagrams, photographs, etc.</para>
    ///   <para>rdfs:label : has illustrator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60396">rdau:P60396</a>
    /// </summary>
    let P60396 = _prefixId.prefix "P60396"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordist</para>
    ///   <para>rdfs:label : has recordist</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by using a recording device to capture sound and/or video during a recording session, including field recordings of natural sounds, folkloric events, music, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60397">rdau:P60397</a>
    /// </summary>
    let P60397 = _prefixId.prefix "P60397"
    /// <summary>
    ///   <para>skos:scopeNote : Contributors include editors, translators, arrangers of music, performers, etc.</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contributor</para>
    ///   <para>rdfs:label : has contributor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60398">rdau:P60398</a>
    /// </summary>
    let P60398 = _prefixId.prefix "P60398"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a stage resource through the general management and supervision of a performance.</para>
    ///   <para>rdfs:label : has stage director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stageDirector</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60399">rdau:P60399</a>
    /// </summary>
    let P60399 = _prefixId.prefix "P60399"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent currently having legal possession of a resource.</para>
    ///   <para>rdfs:label : has current owner</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : currentOwner</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60400">rdau:P60400</a>
    /// </summary>
    let P60400 = _prefixId.prefix "P60400"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formerOwner</para>
    ///   <para>skos:definition : Relates a resource to an agent formerly having legal possession of a resource.</para>
    ///   <para>rdfs:label : has former owner</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60401">rdau:P60401</a>
    /// </summary>
    let P60401 = _prefixId.prefix "P60401"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent having legal custody of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodian</para>
    ///   <para>rdfs:label : has custodian</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60402">rdau:P60402</a>
    /// </summary>
    let P60402 = _prefixId.prefix "P60402"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : owner</para>
    ///   <para>rdfs:label : has owner</para>
    ///   <para>skos:definition : Relates a resource to an agent having legal possession of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60404">rdau:P60404</a>
    /// </summary>
    let P60404 = _prefixId.prefix "P60404"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent honoured by a resource (e.g., the honouree of a festschrift).</para>
    ///   <para>rdfs:label : has honouree</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honouree</para>
    ///   <para>skos:altLabel : has honoree</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60406">rdau:P60406</a>
    /// </summary>
    let P60406 = _prefixId.prefix "P60406"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcaster</para>
    ///   <para>rdfs:label : has broadcaster</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in broadcasting a resource to an audience via radio, television, webcast, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60407">rdau:P60407</a>
    /// </summary>
    let P60407 = _prefixId.prefix "P60407"
    /// <summary>
    ///   <para>rdfs:label : has film distributor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDistributor</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in distributing a moving image resource to theatres or other distribution channels.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60408">rdau:P60408</a>
    /// </summary>
    let P60408 = _prefixId.prefix "P60408"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookDesigner</para>
    ///   <para>rdfs:label : has book designer</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60409">rdau:P60409</a>
    /// </summary>
    let P60409 = _prefixId.prefix "P60409"
    /// <summary>
    ///   <para>rdfs:label : has engraver</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : engraver</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by cutting letters, figures, etc., on a surface such as a wooden or metal plate used for printing.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60410">rdau:P60410</a>
    /// </summary>
    let P60410 = _prefixId.prefix "P60410"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : brailleEmbosser</para>
    ///   <para>rdfs:label : has braille embosser</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by embossing braille cells using a stylus, special embossing printer, or other device.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60411">rdau:P60411</a>
    /// </summary>
    let P60411 = _prefixId.prefix "P60411"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by making a relief, intaglio, or planographic printing surface.</para>
    ///   <para>rdfs:label : has printmaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printmaker</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60412">rdau:P60412</a>
    /// </summary>
    let P60412 = _prefixId.prefix "P60412"
    /// <summary>
    ///   <para>rdfs:label : has caster</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by pouring a liquid or molten substance into a mold and leaving it to solidify to take the shape of the mold.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : caster</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60413">rdau:P60413</a>
    /// </summary>
    let P60413 = _prefixId.prefix "P60413"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lithographer</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by preparing a stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.</para>
    ///   <para>rdfs:label : has lithographer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60414">rdau:P60414</a>
    /// </summary>
    let P60414 = _prefixId.prefix "P60414"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by preparing plates used in the production of printed images and/or text.</para>
    ///   <para>rdfs:label : has platemaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : platemaker</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60415">rdau:P60415</a>
    /// </summary>
    let P60415 = _prefixId.prefix "P60415"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource by subjecting metal, glass, or some other surface used for printing, to acid or another corrosive substance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : etcher</para>
    ///   <para>rdfs:label : has etcher</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60416">rdau:P60416</a>
    /// </summary>
    let P60416 = _prefixId.prefix "P60416"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collotyper</para>
    ///   <para>rdfs:label : has collotyper</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource using a photomechanical process for making prints directly from a hardened film of gelatin or other colloid that has ink-receptive and ink-repellent surfaces.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60417">rdau:P60417</a>
    /// </summary>
    let P60417 = _prefixId.prefix "P60417"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printer</para>
    ///   <para>skos:definition : Relates a resource to an agent involved in manufacturing a resource of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc.</para>
    ///   <para>rdfs:label : has printer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60418">rdau:P60418</a>
    /// </summary>
    let P60418 = _prefixId.prefix "P60418"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent mentioned in an "X presents" credit for moving image materials and who is probably associated with production, finance, or distribution in some way.</para>
    ///   <para>rdfs:label : has presenter</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presenter</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60419">rdau:P60419</a>
    /// </summary>
    let P60419 = _prefixId.prefix "P60419"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeSupervisor</para>
    ///   <para>rdfs:label : has degree supervisor</para>
    ///   <para>skos:definition : Relates a resource to an agent, such as an advisor or supervisor of thesis or dissertation research, overseeing either an academic degree or thesis.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60420">rdau:P60420</a>
    /// </summary>
    let P60420 = _prefixId.prefix "P60420"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent providing decoration to a specific resource using precious metals or color, often with elaborate designs and motifs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illuminator</para>
    ///   <para>rdfs:label : has illuminator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60421">rdau:P60421</a>
    /// </summary>
    let P60421 = _prefixId.prefix "P60421"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfMovingImageResource</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for assembling, arranging, and trimming film, video, or other moving image formats, including both visual and audio aspects.</para>
    ///   <para>rdfs:label : has editor of moving image work</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60422">rdau:P60422</a>
    /// </summary>
    let P60422 = _prefixId.prefix "P60422"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a computer program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : programmer</para>
    ///   <para>rdfs:label : has programmer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60423">rdau:P60423</a>
    /// </summary>
    let P60423 = _prefixId.prefix "P60423"
    /// <summary>
    ///   <para>rdfs:label : has designer</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a design for an object.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60424">rdau:P60424</a>
    /// </summary>
    let P60424 = _prefixId.prefix "P60424"
    /// <summary>
    ///   <para>rdfs:label : has cartographer</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a map, atlas, globe, or other cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60425">rdau:P60425</a>
    /// </summary>
    let P60425 = _prefixId.prefix "P60425"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composer</para>
    ///   <para>rdfs:label : has composer</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a musical resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60426">rdau:P60426</a>
    /// </summary>
    let P60426 = _prefixId.prefix "P60426"
    /// <summary>
    ///   <para>rdfs:label : has inventor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inventor</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a new device or process.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60427">rdau:P60427</a>
    /// </summary>
    let P60427 = _prefixId.prefix "P60427"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a new resource (e.g., a bibliography, a directory) by selecting, arranging, aggregating, and editing data, information, etc.</para>
    ///   <para>rdfs:label : has compiler</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : compiler</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60428">rdau:P60428</a>
    /// </summary>
    let P60428 = _prefixId.prefix "P60428"
    /// <summary>
    ///   <para>rdfs:label : has photographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : photographer</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a photographic resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60429">rdau:P60429</a>
    /// </summary>
    let P60429 = _prefixId.prefix "P60429"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a resource by acting as an interviewer, reporter, pollster, or some other information gathering agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewer</para>
    ///   <para>rdfs:label : has interviewer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60430">rdau:P60430</a>
    /// </summary>
    let P60430 = _prefixId.prefix "P60430"
    /// <summary>
    ///   <para>rdfs:label : has artist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artist</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a resource by conceiving, and often implementing, an original graphic design, drawing, painting, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60431">rdau:P60431</a>
    /// </summary>
    let P60431 = _prefixId.prefix "P60431"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewee</para>
    ///   <para>rdfs:label : has interviewee</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a resource by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60432">rdau:P60432</a>
    /// </summary>
    let P60432 = _prefixId.prefix "P60432"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographer</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a resource of movement.</para>
    ///   <para>rdfs:label : has choreographer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60433">rdau:P60433</a>
    /// </summary>
    let P60433 = _prefixId.prefix "P60433"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : author</para>
    ///   <para>rdfs:label : has author</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating a resource that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs).</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60434">rdau:P60434</a>
    /// </summary>
    let P60434 = _prefixId.prefix "P60434"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating an architectural design, including a pictorial representation intended to show how a building, etc., will look when completed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : architect</para>
    ///   <para>rdfs:label : has architect</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60435">rdau:P60435</a>
    /// </summary>
    let P60435 = _prefixId.prefix "P60435"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmmaker</para>
    ///   <para>rdfs:label : has filmmaker</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for creating an independent or personal film.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60436">rdau:P60436</a>
    /// </summary>
    let P60436 = _prefixId.prefix "P60436"
    /// <summary>
    ///   <para>rdfs:label : has production designer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionDesigner</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for designing the overall visual appearance of a moving image production.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60437">rdau:P60437</a>
    /// </summary>
    let P60437 = _prefixId.prefix "P60437"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for distributing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributor</para>
    ///   <para>rdfs:label : has distributor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60438">rdau:P60438</a>
    /// </summary>
    let P60438 = _prefixId.prefix "P60438"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerOfAnUnpublishedResource</para>
    ///   <para>rdfs:label : has producer of an unpublished resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60440">rdau:P60440</a>
    /// </summary>
    let P60440 = _prefixId.prefix "P60440"
    /// <summary>
    ///   <para>rdfs:label : has producer</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for most of the business aspects of a production for screen, sound recording, television, webcast, etc. the producer is generally responsible for fund raising, managing the production, hiring key personnel, arranging for distributors, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60441">rdau:P60441</a>
    /// </summary>
    let P60441 = _prefixId.prefix "P60441"
    let P60442 = _prefixId.prefix "P60442"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturer</para>
    ///   <para>rdfs:label : has manufacturer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60443">rdau:P60443</a>
    /// </summary>
    let P60443 = _prefixId.prefix "P60443"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>rdfs:label : has publisher</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publisher</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60444">rdau:P60444</a>
    /// </summary>
    let P60444 = _prefixId.prefix "P60444"
    /// <summary>
    ///   <para>rdfs:label : has minute taker</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : minuteTaker</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for recording the minutes of a meeting.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60446">rdau:P60446</a>
    /// </summary>
    let P60446 = _prefixId.prefix "P60446"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : creator</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for the creation of a resource</para>
    ///   <para>rdfs:label : has creator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60447">rdau:P60447</a>
    /// </summary>
    let P60447 = _prefixId.prefix "P60447"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : director</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for the general management and supervision of a filmed performance, a radio or television program, etc.</para>
    ///   <para>rdfs:label : has director</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60449">rdau:P60449</a>
    /// </summary>
    let P60449 = _prefixId.prefix "P60449"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restorationist</para>
    ///   <para>rdfs:label : has restorationist</para>
    ///   <para>skos:definition : Relates a resource to an agent responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of a resource by bringing it back to a state as close as possible to its original condition.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60450">rdau:P60450</a>
    /// </summary>
    let P60450 = _prefixId.prefix "P60450"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringBody</para>
    ///   <para>skos:definition : Relates a resource to an agent sponsoring some aspect of a resource, e.g., funding research, sponsoring an event.</para>
    ///   <para>rdfs:label : has sponsoring body</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60451">rdau:P60451</a>
    /// </summary>
    let P60451 = _prefixId.prefix "P60451"
    /// <summary>
    ///   <para>rdfs:label : has director of photography</para>
    ///   <para>skos:definition : Relates a resource to an agent that captures images, either electronically or on film or video stock, and often selects and arranges the lighting. the director of photography for a movie is also called the chief cinematographer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOfPhotography</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60452">rdau:P60452</a>
    /// </summary>
    let P60452 = _prefixId.prefix "P60452"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedAgent</para>
    ///   <para>skos:definition : Relates an agent to an agent that is associated with the agent being identified.</para>
    ///   <para>rdfs:label : has related agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60454">rdau:P60454</a>
    /// </summary>
    let P60454 = _prefixId.prefix "P60454"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicatee</para>
    ///   <para>skos:definition : Relates a resource to an agent to whom a resource is dedicated.</para>
    ///   <para>rdfs:label : has dedicatee</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60455">rdau:P60455</a>
    /// </summary>
    let P60455 = _prefixId.prefix "P60455"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent to whom a resource or part of a resource is addressed.</para>
    ///   <para>rdfs:label : has addressee</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressee</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60456">rdau:P60456</a>
    /// </summary>
    let P60456 = _prefixId.prefix "P60456"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellant</para>
    ///   <para>skos:definition : Relates a resource to an agent who appeals the decision of a lower court recorded in a legal resource of a higher court.</para>
    ///   <para>rdfs:label : has appellant</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60457">rdau:P60457</a>
    /// </summary>
    let P60457 = _prefixId.prefix "P60457"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : binder</para>
    ///   <para>rdfs:label : has binder</para>
    ///   <para>skos:definition : Relates a resource to an agent who binds a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60458">rdau:P60458</a>
    /// </summary>
    let P60458 = _prefixId.prefix "P60458"
    /// <summary>
    ///   <para>rdfs:label : has plaintiff</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiff</para>
    ///   <para>skos:definition : Relates a resource to an agent who brings a suit in a civil proceeding.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60459">rdau:P60459</a>
    /// </summary>
    let P60459 = _prefixId.prefix "P60459"
    /// <summary>
    ///   <para>rdfs:label : has inscriber</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inscriber</para>
    ///   <para>skos:definition : Relates a resource to an agent who has written a statement of dedication or gift on a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60460">rdau:P60460</a>
    /// </summary>
    let P60460 = _prefixId.prefix "P60460"
    /// <summary>
    ///   <para>rdfs:label : has judge</para>
    ///   <para>skos:definition : Relates a resource to an agent who hears and decides on legal matters in court.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : judge</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60461">rdau:P60461</a>
    /// </summary>
    let P60461 = _prefixId.prefix "P60461"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendant</para>
    ///   <para>rdfs:label : has defendant</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60462">rdau:P60462</a>
    /// </summary>
    let P60462 = _prefixId.prefix "P60462"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent who is the faculty moderator of an academic disputation, normally proposing a thesis and participating in the ensuing disputation.</para>
    ///   <para>rdfs:label : has praeses</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : praeses</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60463">rdau:P60463</a>
    /// </summary>
    let P60463 = _prefixId.prefix "P60463"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : annotator</para>
    ///   <para>rdfs:label : has annotator</para>
    ///   <para>skos:definition : Relates a resource to an agent who makes manuscript annotations on a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60464">rdau:P60464</a>
    /// </summary>
    let P60464 = _prefixId.prefix "P60464"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent who provides consultation services, and often makes recommendations, for another person, family or corporate body that is represented as the creator of a resource.</para>
    ///   <para>rdfs:label : has consultant</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : consultant</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60465">rdau:P60465</a>
    /// </summary>
    let P60465 = _prefixId.prefix "P60465"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent whose manuscript signature appears on a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : autographer</para>
    ///   <para>rdfs:label : has autographer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60466">rdau:P60466</a>
    /// </summary>
    let P60466 = _prefixId.prefix "P60466"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent, family or corporate body issuing a resource, such as an official organ of the body.</para>
    ///   <para>rdfs:label : has issuing body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuingBody</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60467">rdau:P60467</a>
    /// </summary>
    let P60467 = _prefixId.prefix "P60467"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent's vocation or avocation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : professionOrOccupation</para>
    ///   <para>rdfs:label : has profession or occupation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60468">rdau:P60468</a>
    /// </summary>
    let P60468 = _prefixId.prefix "P60468"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource in an analog format that is transferred to a digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionOf</para>
    ///   <para>rdfs:label : is electronic reproduction of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60469">rdau:P60469</a>
    /// </summary>
    let P60469 = _prefixId.prefix "P60469"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an annotation providing additional information about content recorded as a resource attribute.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnResource</para>
    ///   <para>rdfs:label : has note on resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60470">rdau:P60470</a>
    /// </summary>
    let P60470 = _prefixId.prefix "P60470"
    let P60471 = _prefixId.prefix "P60471"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an arbitrary moment in time to which measurements of position for a body or orientation for an orbit are referred.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : epoch</para>
    ///   <para>rdfs:label : has epoch</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60472">rdau:P60472</a>
    /// </summary>
    let P60472 = _prefixId.prefix "P60472"
    /// <summary>
    ///   <para>rdfs:label : has landscape architect</para>
    ///   <para>skos:definition : Relates a resource to an architect responsible for creating landscape resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : landscapeArchitect</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60473">rdau:P60473</a>
    /// </summary>
    let P60473 = _prefixId.prefix "P60473"
    /// <summary>
    ///   <para>rdfs:label : is finding aid for</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidFor</para>
    ///   <para>skos:definition : Relates a resource to an archival collection that is described in a finding aid, i.e., a guide to the organization, arrangement, and contents of the collection.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60474">rdau:P60474</a>
    /// </summary>
    let P60474 = _prefixId.prefix "P60474"
    /// <summary>
    ///   <para>rdfs:label : has sculptor</para>
    ///   <para>skos:definition : Relates a resource to an artist responsible for creating a three-dimensional resource by modeling, carving, or similar technique.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sculptor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60475">rdau:P60475</a>
    /// </summary>
    let P60475 = _prefixId.prefix "P60475"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an author of a screenplay, script, or scene.</para>
    ///   <para>rdfs:label : has screenwriter</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenwriter</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60476">rdau:P60476</a>
    /// </summary>
    let P60476 = _prefixId.prefix "P60476"
    /// <summary>
    ///   <para>rdfs:label : has lyricist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lyricist</para>
    ///   <para>skos:definition : Relates a resource to an author of the words of a popular song, including a song or songs from a musical.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60477">rdau:P60477</a>
    /// </summary>
    let P60477 = _prefixId.prefix "P60477"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettist</para>
    ///   <para>rdfs:label : has librettist</para>
    ///   <para>skos:definition : Relates a resource to an author of the words of an opera or other musical stage resource or an oratorio.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60478">rdau:P60478</a>
    /// </summary>
    let P60478 = _prefixId.prefix "P60478"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacementInPartOf</para>
    ///   <para>rdfs:label : is replacement in part of</para>
    ///   <para>skos:definition : Relates a resource to an earlier resource whose content has been partially replaced by a later resource, usually because the later resource contains updated or new information that makes the earlier resource obsolete.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60479">rdau:P60479</a>
    /// </summary>
    let P60479 = _prefixId.prefix "P60479"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an earlier resource whose content has been replaced by a later resource, usually because the later resource contains updated or new information that makes the earlier resource obsolete.</para>
    ///   <para>rdfs:label : is replacement of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacementOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60480">rdau:P60480</a>
    /// </summary>
    let P60480 = _prefixId.prefix "P60480"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialPlaybackCharacteristic</para>
    ///   <para>rdfs:label : has special playback characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60481">rdau:P60481</a>
    /// </summary>
    let P60481 = _prefixId.prefix "P60481"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an institution commonly associated with an agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : associatedInstitution</para>
    ///   <para>rdfs:label : has associated institution</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60482">rdau:P60482</a>
    /// </summary>
    let P60482 = _prefixId.prefix "P60482"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an institution or faculty conferring an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grantingInstitutionOrFaculty</para>
    ///   <para>rdfs:label : has granting institution or faculty</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60483">rdau:P60483</a>
    /// </summary>
    let P60483 = _prefixId.prefix "P60483"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to biographical or historical information about the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : agentHistory</para>
    ///   <para>rdfs:label : has agent history</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60484">rdau:P60484</a>
    /// </summary>
    let P60484 = _prefixId.prefix "P60484"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to content (e.g., an index, a bibliography, an appendix) intended to supplement the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementaryContent</para>
    ///   <para>rdfs:label : has supplementary content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60485">rdau:P60485</a>
    /// </summary>
    let P60485 = _prefixId.prefix "P60485"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to content intended to illustrate the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrativeContent</para>
    ///   <para>rdfs:label : has illustrative content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60486">rdau:P60486</a>
    /// </summary>
    let P60486 = _prefixId.prefix "P60486"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to content that assists those with a sensory impairment in the greater understanding of content which their impairment prevents them fully seeing or hearing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accessibilityContent</para>
    ///   <para>rdfs:label : has accessibility content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60487">rdau:P60487</a>
    /// </summary>
    let P60487 = _prefixId.prefix "P60487"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the musical or physical layout of the content of a resource that is presented in the form of musical notation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formatOfNotatedMusic</para>
    ///   <para>rdfs:label : has format of notated music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60488">rdau:P60488</a>
    /// </summary>
    let P60488 = _prefixId.prefix "P60488"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information about a resource presented as part of the formal requirements for an academic degree.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dissertationOrThesisInformation</para>
    ///   <para>rdfs:label : has dissertation or thesis information</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60489">rdau:P60489</a>
    /// </summary>
    let P60489 = _prefixId.prefix "P60489"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information about an organization, etc., from which a resource may be obtained.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contactInformation</para>
    ///   <para>rdfs:label : has contact information</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60490">rdau:P60490</a>
    /// </summary>
    let P60490 = _prefixId.prefix "P60490"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information about the history of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : historyOfTheResource</para>
    ///   <para>rdfs:label : has history of the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60491">rdau:P60491</a>
    /// </summary>
    let P60491 = _prefixId.prefix "P60491"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information about the life or history of an agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : biographicalInformation</para>
    ///   <para>rdfs:label : has biographical information</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60492">rdau:P60492</a>
    /// </summary>
    let P60492 = _prefixId.prefix "P60492"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information that appears in conjunction with, and is subordinate to, the title proper of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformation</para>
    ///   <para>rdfs:label : has other title information</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60493">rdau:P60493</a>
    /// </summary>
    let P60493 = _prefixId.prefix "P60493"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information that appears in conjunction with, and is subordinate to, the title proper of a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSeries</para>
    ///   <para>rdfs:label : has other title information of series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60494">rdau:P60494</a>
    /// </summary>
    let P60494 = _prefixId.prefix "P60494"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to information that appears in conjunction with, and is subordinate to, the title proper of a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSubseries</para>
    ///   <para>rdfs:label : has other title information of subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60495">rdau:P60495</a>
    /// </summary>
    let P60495 = _prefixId.prefix "P60495"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to limitations placed on access to a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnAccess</para>
    ///   <para>rdfs:label : has restrictions on access</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60496">rdau:P60496</a>
    /// </summary>
    let P60496 = _prefixId.prefix "P60496"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnUse</para>
    ///   <para>rdfs:label : has restrictions on use</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60497">rdau:P60497</a>
    /// </summary>
    let P60497 = _prefixId.prefix "P60497"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to mathematical data and other features of the cartographic content of a resource not recorded in statements of scale, projection, and coordinates.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDetailsOfCartographicContent</para>
    ///   <para>rdfs:label : has other details of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60498">rdau:P60498</a>
    /// </summary>
    let P60498 = _prefixId.prefix "P60498"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60499">rdau:P60499</a>
    /// </summary>
    let P60499 = _prefixId.prefix "P60499"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60500">rdau:P60500</a>
    /// </summary>
    let P60500 = _prefixId.prefix "P60500"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has chronological designation of first issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60501">rdau:P60501</a>
    /// </summary>
    let P60501 = _prefixId.prefix "P60501"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has chronological designation of last issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60502">rdau:P60502</a>
    /// </summary>
    let P60502 = _prefixId.prefix "P60502"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : splitInto</para>
    ///   <para>skos:definition : Relates a resource to one of two or more resources resulting from the division of an earlier resource into separate resources.</para>
    ///   <para>rdfs:label : is split into</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60503">rdau:P60503</a>
    /// </summary>
    let P60503 = _prefixId.prefix "P60503"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergedToForm</para>
    ///   <para>skos:definition : Relates a resource to a resource formed from the coming together of two or more resources.</para>
    ///   <para>rdfs:label : is merged to form</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60504">rdau:P60504</a>
    /// </summary>
    let P60504 = _prefixId.prefix "P60504"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergerOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that came together with one or more other resources to form the new resource.</para>
    ///   <para>rdfs:label : is merger of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60505">rdau:P60505</a>
    /// </summary>
    let P60505 = _prefixId.prefix "P60505"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to one of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0°.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equinox</para>
    ///   <para>rdfs:label : has equinox</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60506">rdau:P60506</a>
    /// </summary>
    let P60506 = _prefixId.prefix "P60506"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to other title information in a language and/or script that differs from that recorded in the other title information element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformation</para>
    ///   <para>rdfs:label : has parallel other title information</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60507">rdau:P60507</a>
    /// </summary>
    let P60507 = _prefixId.prefix "P60507"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to other title information of a series in a language and/or script that differs from that recorded in the other title information of series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSeries</para>
    ///   <para>rdfs:label : has parallel other title information of series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60508">rdau:P60508</a>
    /// </summary>
    let P60508 = _prefixId.prefix "P60508"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to other title information of a subseries in a language and/or script that differs from that recorded in the other title information of subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSubseries</para>
    ///   <para>rdfs:label : has parallel other title information of subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60509">rdau:P60509</a>
    /// </summary>
    let P60509 = _prefixId.prefix "P60509"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to supplemental information about scale such as a statement of comparative measurements or limitation of the scale to particular parts of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : additionalScaleInformation</para>
    ///   <para>rdfs:label : has additional scale information</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60510">rdau:P60510</a>
    /// </summary>
    let P60510 = _prefixId.prefix "P60510"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the address of a remote access resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : uniformResourceLocator</para>
    ///   <para>rdfs:label : has uniform resource locator</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60511">rdau:P60511</a>
    /// </summary>
    let P60511 = _prefixId.prefix "P60511"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the address of an agent's place of residence, business, or employer, headquarters or offices, or an e-mail or internet address.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressOfTheAgent</para>
    ///   <para>rdfs:label : has address of the agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60512">rdau:P60512</a>
    /// </summary>
    let P60512 = _prefixId.prefix "P60512"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the arrangement of text, images, tactile notation, etc., in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layout</para>
    ///   <para>rdfs:label : has layout</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60513">rdau:P60513</a>
    /// </summary>
    let P60513 = _prefixId.prefix "P60513"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the calendar year in which a granting institution or faculty conferred an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : yearDegreeGranted</para>
    ///   <para>rdfs:label : has year degree granted</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60514">rdau:P60514</a>
    /// </summary>
    let P60514 = _prefixId.prefix "P60514"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the chief name of a resource (i.e., the title normally used when citing the resource).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProper</para>
    ///   <para>rdfs:label : has title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60515">rdau:P60515</a>
    /// </summary>
    let P60515 = _prefixId.prefix "P60515"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the chief name of a series (i.e., the title normally used when citing the series).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSeries</para>
    ///   <para>rdfs:label : has title proper of series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60516">rdau:P60516</a>
    /// </summary>
    let P60516 = _prefixId.prefix "P60516"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the chief name of a subseries (i.e., the title normally used when citing the subseries).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSubseries</para>
    ///   <para>rdfs:label : has title proper of subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60517">rdau:P60517</a>
    /// </summary>
    let P60517 = _prefixId.prefix "P60517"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the chronological or geographic coverage of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coverageOfTheContent</para>
    ///   <para>rdfs:label : has coverage of the content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60518">rdau:P60518</a>
    /// </summary>
    let P60518 = _prefixId.prefix "P60518"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the clarity or fineness of detail in a digital image, expressed by the measurement of the image in pixels, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : resolution</para>
    ///   <para>rdfs:label : has resolution</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60519">rdau:P60519</a>
    /// </summary>
    let P60519 = _prefixId.prefix "P60519"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the class of user for which the content of a resource is intended, or for whom the content is considered suitable.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intendedAudience</para>
    ///   <para>rdfs:label : has intended audience</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60520">rdau:P60520</a>
    /// </summary>
    let P60520 = _prefixId.prefix "P60520"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the conditions under which the publisher, distributor, etc., will normally supply a resource or the price of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : termsOfAvailability</para>
    ///   <para>rdfs:label : has terms of availability</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60521">rdau:P60521</a>
    /// </summary>
    let P60521 = _prefixId.prefix "P60521"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : trackConfiguration</para>
    ///   <para>rdfs:label : has track configuration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60522">rdau:P60522</a>
    /// </summary>
    let P60522 = _prefixId.prefix "P60522"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the country or other territorial jurisdiction from which a resource originated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfOriginOfTheResource</para>
    ///   <para>rdfs:label : has place of origin of the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60523">rdau:P60523</a>
    /// </summary>
    let P60523 = _prefixId.prefix "P60523"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the date on which an agent was established or founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfEstablishment</para>
    ///   <para>rdfs:label : has date of establishment</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60524">rdau:P60524</a>
    /// </summary>
    let P60524 = _prefixId.prefix "P60524"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the date on which an agent was terminated or dissolved.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfTermination</para>
    ///   <para>rdfs:label : has date of termination</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60525">rdau:P60525</a>
    /// </summary>
    let P60525 = _prefixId.prefix "P60525"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the date or range of dates on which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfConferenceEtc</para>
    ///   <para>rdfs:label : has date of conference, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60526">rdau:P60526</a>
    /// </summary>
    let P60526 = _prefixId.prefix "P60526"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the earliest date associated with a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfResource</para>
    ///   <para>rdfs:label : has date of resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60527">rdau:P60527</a>
    /// </summary>
    let P60527 = _prefixId.prefix "P60527"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the equipment or system required for use, playback, etc., of an analog, digital, etc., resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equipmentOrSystemRequirement</para>
    ///   <para>rdfs:label : has equipment or system requirement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60528">rdau:P60528</a>
    /// </summary>
    let P60528 = _prefixId.prefix "P60528"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the format used in the production of a projected image (e.g., Cinerama, IMAX).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presentationFormat</para>
    ///   <para>rdfs:label : has presentation format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60529">rdau:P60529</a>
    /// </summary>
    let P60529 = _prefixId.prefix "P60529"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the full form of a part of a name represented only by an initial or abbreviation in the form chosen as the preferred name, or a part of the name not included in the form chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fullerFormOfName</para>
    ///   <para>rdfs:label : has fuller form of name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60530">rdau:P60530</a>
    /// </summary>
    let P60530 = _prefixId.prefix "P60530"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the gender with which an agent identifies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : gender</para>
    ///   <para>rdfs:label : has gender</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60531">rdau:P60531</a>
    /// </summary>
    let P60531 = _prefixId.prefix "P60531"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grooveCharacteristic</para>
    ///   <para>rdfs:label : has groove characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60532">rdau:P60532</a>
    /// </summary>
    let P60532 = _prefixId.prefix "P60532"
    /// <summary>
    ///   <para>rdfs:label : has numbering of serials</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfSerials</para>
    ///   <para>skos:definition : Relates a resource to the identification of each of the issues or parts of a serial.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60533">rdau:P60533</a>
    /// </summary>
    let P60533 = _prefixId.prefix "P60533"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the identifier assigned to a series by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSeries</para>
    ///   <para>rdfs:label : has ISSN of series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60534">rdau:P60534</a>
    /// </summary>
    let P60534 = _prefixId.prefix "P60534"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the identifier assigned to a subseries by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSubseries</para>
    ///   <para>rdfs:label : has ISSN of subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60535">rdau:P60535</a>
    /// </summary>
    let P60535 = _prefixId.prefix "P60535"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the instrument, instruments, voice, voices, etc., for which a musical resource was originally conceived.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformance</para>
    ///   <para>rdfs:label : has medium of performance</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60536">rdau:P60536</a>
    /// </summary>
    let P60536 = _prefixId.prefix "P60536"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the instrument, instruments, voice, voices, etc., used (or intended to be used) for performance of musical content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformanceOfMusicalContent</para>
    ///   <para>rdfs:label : has medium of performance of musical content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60537">rdau:P60537</a>
    /// </summary>
    let P60537 = _prefixId.prefix "P60537"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the intervals at which the issues or parts of a serial or the updates to an integrating resource are issued.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : frequency</para>
    ///   <para>rdfs:label : has frequency</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60538">rdau:P60538</a>
    /// </summary>
    let P60538 = _prefixId.prefix "P60538"
    /// <summary>
    ///   <para>rdfs:label : has dimensions</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensions</para>
    ///   <para>skos:definition : Relates a resource to the measurements of the carrier or carriers and/or the container of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60539">rdau:P60539</a>
    /// </summary>
    let P60539 = _prefixId.prefix "P60539"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the measurements of the face of a map, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfMapEtc</para>
    ///   <para>rdfs:label : has dimensions of map, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60540">rdau:P60540</a>
    /// </summary>
    let P60540 = _prefixId.prefix "P60540"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the measurements of the pictorial area of a still image.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfStillImage</para>
    ///   <para>rdfs:label : has dimensions of still image</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60541">rdau:P60541</a>
    /// </summary>
    let P60541 = _prefixId.prefix "P60541"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the method or system used to represent the surface of the earth or of a celestial sphere on a plane.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionOfCartographicContent</para>
    ///   <para>rdfs:label : has projection of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60542">rdau:P60542</a>
    /// </summary>
    let P60542 = _prefixId.prefix "P60542"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the method used to encode audio content for playback (e.g., analog or digital).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfRecording</para>
    ///   <para>rdfs:label : has type of recording</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60543">rdau:P60543</a>
    /// </summary>
    let P60543 = _prefixId.prefix "P60543"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of an agent responsible for distributing a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorsName</para>
    ///   <para>rdfs:label : has distributor’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60544">rdau:P60544</a>
    /// </summary>
    let P60544 = _prefixId.prefix "P60544"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of an agent responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producersName</para>
    ///   <para>rdfs:label : has producer’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60545">rdau:P60545</a>
    /// </summary>
    let P60545 = _prefixId.prefix "P60545"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of an agent responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturersName</para>
    ///   <para>rdfs:label : has manufacturer’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60546">rdau:P60546</a>
    /// </summary>
    let P60546 = _prefixId.prefix "P60546"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name of an agent responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersName</para>
    ///   <para>rdfs:label : has publisher’s name</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60547">rdau:P60547</a>
    /// </summary>
    let P60547 = _prefixId.prefix "P60547"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the name or form of name chosen to identify a place.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForThePlace</para>
    ///   <para>rdfs:label : has preferred name for the place</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60548">rdau:P60548</a>
    /// </summary>
    let P60548 = _prefixId.prefix "P60548"
    /// <summary>
    ///   <para>rdfs:label : has preferred name for the agent</para>
    ///   <para>skos:definition : Relates a resource to the name or form of name chosen to identify the agent. it is also the basis for the authorized access point representing that body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheAgent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60549">rdau:P60549</a>
    /// </summary>
    let P60549 = _prefixId.prefix "P60549"
    /// <summary>
    ///   <para>rdfs:label : has extent</para>
    ///   <para>skos:definition : Relates a resource to the number and type of units and/or subunits making up a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60550">rdau:P60550</a>
    /// </summary>
    let P60550 = _prefixId.prefix "P60550"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the number of bytes in a digital file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileSize</para>
    ///   <para>rdfs:label : has file size</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60551">rdau:P60551</a>
    /// </summary>
    let P60551 = _prefixId.prefix "P60551"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : configurationOfPlaybackChannels</para>
    ///   <para>rdfs:label : has configuration of playback channels</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60552">rdau:P60552</a>
    /// </summary>
    let P60552 = _prefixId.prefix "P60552"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the number of tracks on an audiotape.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : tapeConfiguration</para>
    ///   <para>rdfs:label : has tape configuration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60553">rdau:P60553</a>
    /// </summary>
    let P60553 = _prefixId.prefix "P60553"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mount</para>
    ///   <para>rdfs:label : has mount</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60554">rdau:P60554</a>
    /// </summary>
    let P60554 = _prefixId.prefix "P60554"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the place and date associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAndDateOfCapture</para>
    ///   <para>rdfs:label : has place and date of capture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60555">rdau:P60555</a>
    /// </summary>
    let P60555 = _prefixId.prefix "P60555"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the place associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfCapture</para>
    ///   <para>rdfs:label : has place of capture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60556">rdau:P60556</a>
    /// </summary>
    let P60556 = _prefixId.prefix "P60556"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the playing time, running time, etc., of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : duration</para>
    ///   <para>rdfs:label : has duration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60557">rdau:P60557</a>
    /// </summary>
    let P60557 = _prefixId.prefix "P60557"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the presence of colour, tone, etc., in the content of a resource. colour content is also the specific colours, tones, etc., (including black and white) present in the content of a resource.</para>
    ///   <para>skos:altLabel : has color content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContent</para>
    ///   <para>rdfs:label : has colour content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60558">rdau:P60558</a>
    /// </summary>
    let P60558 = _prefixId.prefix "P60558"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the presence of sound in a resource other than one that consists primarily of recorded sound.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundContent</para>
    ///   <para>rdfs:label : has sound content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60559">rdau:P60559</a>
    /// </summary>
    let P60559 = _prefixId.prefix "P60559"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the process used to produce a resource.</para>
    ///   <para>rdfs:label : has production method</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethod</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60560">rdau:P60560</a>
    /// </summary>
    let P60560 = _prefixId.prefix "P60560"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForTactileResource</para>
    ///   <para>rdfs:label : has production method for tactile resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60561">rdau:P60561</a>
    /// </summary>
    let P60561 = _prefixId.prefix "P60561"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the process used to produce an original manuscript or a copy.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForManuscript</para>
    ///   <para>rdfs:label : has production method for manuscript</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60562">rdau:P60562</a>
    /// </summary>
    let P60562 = _prefixId.prefix "P60562"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the ratio of horizontal distances in the cartographic content of a resource to the actual distances they represent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : horizontalScaleOfCartographicContent</para>
    ///   <para>rdfs:label : has horizontal scale of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60563">rdau:P60563</a>
    /// </summary>
    let P60563 = _prefixId.prefix "P60563"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the ratio of the dimensions of a still image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scaleOfStillImageOrThreeDimensionalForm</para>
    ///   <para>rdfs:label : has scale of still image or three-dimensional form</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60564">rdau:P60564</a>
    /// </summary>
    let P60564 = _prefixId.prefix "P60564"
    /// <summary>
    ///   <para>rdfs:label : has scale</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scale</para>
    ///   <para>skos:definition : Relates a resource to the ratio of the dimensions of an image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60565">rdau:P60565</a>
    /// </summary>
    let P60565 = _prefixId.prefix "P60565"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the ratio of the width to the height of a moving image.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : aspectRatio</para>
    ///   <para>rdfs:label : has aspect ratio</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60566">rdau:P60566</a>
    /// </summary>
    let P60566 = _prefixId.prefix "P60566"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the relationship between an original audio carrier and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfAudioRecording</para>
    ///   <para>rdfs:label : has generation of audio recording</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60567">rdau:P60567</a>
    /// </summary>
    let P60567 = _prefixId.prefix "P60567"
    /// <summary>
    ///   <para>rdfs:label : has generation</para>
    ///   <para>skos:definition : Relates a resource to the relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60568">rdau:P60568</a>
    /// </summary>
    let P60568 = _prefixId.prefix "P60568"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfDigitalResource</para>
    ///   <para>rdfs:label : has generation of digital resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60569">rdau:P60569</a>
    /// </summary>
    let P60569 = _prefixId.prefix "P60569"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMotionPictureFilm</para>
    ///   <para>rdfs:label : has generation of motion picture film</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60570">rdau:P60570</a>
    /// </summary>
    let P60570 = _prefixId.prefix "P60570"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfVideotape</para>
    ///   <para>rdfs:label : has generation of videotape</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60571">rdau:P60571</a>
    /// </summary>
    let P60571 = _prefixId.prefix "P60571"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the relationship between an original microform carrier and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMicroform</para>
    ///   <para>rdfs:label : has generation of microform</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60572">rdau:P60572</a>
    /// </summary>
    let P60572 = _prefixId.prefix "P60572"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the relationship of the colours and tones in an image to the colours and tones of the object reproduced (e.g., positive, negative).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : polarity</para>
    ///   <para>rdfs:label : has polarity</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60573">rdau:P60573</a>
    /// </summary>
    let P60573 = _prefixId.prefix "P60573"
    /// <summary>
    ///   <para>rdfs:label : is absorption of</para>
    ///   <para>skos:definition : Relates a resource to the resource that has been incorporated into another resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorptionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60574">rdau:P60574</a>
    /// </summary>
    let P60574 = _prefixId.prefix "P60574"
    /// <summary>
    ///   <para>rdfs:label : is absorption in part of</para>
    ///   <para>skos:definition : Relates a resource to the resource that has been partially incorporated into another resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorptionInPartOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60575">rdau:P60575</a>
    /// </summary>
    let P60575 = _prefixId.prefix "P60575"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the resource that is continued by the content of a later resource under a new title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuationOf</para>
    ///   <para>rdfs:label : is continuation of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60576">rdau:P60576</a>
    /// </summary>
    let P60576 = _prefixId.prefix "P60576"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the resource whose narrative is continued by the later resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequelTo</para>
    ///   <para>rdfs:label : is sequel to</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60577">rdau:P60577</a>
    /// </summary>
    let P60577 = _prefixId.prefix "P60577"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookFormat</para>
    ///   <para>rdfs:label : has book format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60578">rdau:P60578</a>
    /// </summary>
    let P60578 = _prefixId.prefix "P60578"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the scale of elevation or vertical dimension of the cartographic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verticalScaleOfCartographicContent</para>
    ///   <para>rdfs:label : has vertical scale of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60579">rdau:P60579</a>
    /// </summary>
    let P60579 = _prefixId.prefix "P60579"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the set of pitch relationships that establishes the tonal centre, or principal tonal centre, of a musical resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : key</para>
    ///   <para>rdfs:label : has key</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60580">rdau:P60580</a>
    /// </summary>
    let P60580 = _prefixId.prefix "P60580"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reductionRatio</para>
    ///   <para>rdfs:label : has reduction ratio</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60581">rdau:P60581</a>
    /// </summary>
    let P60581 = _prefixId.prefix "P60581"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fontSize</para>
    ///   <para>rdfs:label : has font size</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60582">rdau:P60582</a>
    /// </summary>
    let P60582 = _prefixId.prefix "P60582"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the source from which the agency directly acquired a resource and the circumstances under which it was received.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : immediateSourceOfAcquisitionOfItem</para>
    ///   <para>rdfs:label : has immediate source of acquisition of resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60583">rdau:P60583</a>
    /// </summary>
    let P60583 = _prefixId.prefix "P60583"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the specific character of the primary content of a resource (e.g., legal articles, interim report).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : natureOfTheContent</para>
    ///   <para>rdfs:label : has nature of the content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60584">rdau:P60584</a>
    /// </summary>
    let P60584 = _prefixId.prefix "P60584"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionSpeed</para>
    ///   <para>rdfs:label : has projection speed</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60585">rdau:P60585</a>
    /// </summary>
    let P60585 = _prefixId.prefix "P60585"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : playingSpeed</para>
    ///   <para>rdfs:label : has playing speed</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60586">rdau:P60586</a>
    /// </summary>
    let P60586 = _prefixId.prefix "P60586"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the speed at which streaming audio, video, etc., is designed to play.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : encodedBitrate</para>
    ///   <para>rdfs:label : has encoded bitrate</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60587">rdau:P60587</a>
    /// </summary>
    let P60587 = _prefixId.prefix "P60587"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the title or form of title chosen to identify the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredTitleForTheResource</para>
    ///   <para>rdfs:label : has preferred title for the resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60588">rdau:P60588</a>
    /// </summary>
    let P60588 = _prefixId.prefix "P60588"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the title proper in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProper</para>
    ///   <para>rdfs:label : has parallel title proper</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60589">rdau:P60589</a>
    /// </summary>
    let P60589 = _prefixId.prefix "P60589"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the title proper of a series in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSeries</para>
    ///   <para>rdfs:label : has parallel title proper of series</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60590">rdau:P60590</a>
    /// </summary>
    let P60590 = _prefixId.prefix "P60590"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the title proper of a subseries in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSubseries</para>
    ///   <para>rdfs:label : has parallel title proper of subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60591">rdau:P60591</a>
    /// </summary>
    let P60591 = _prefixId.prefix "P60591"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the town, city, province, state, and/or country in which an agent died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDeath</para>
    ///   <para>rdfs:label : has place of death</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60592">rdau:P60592</a>
    /// </summary>
    let P60592 = _prefixId.prefix "P60592"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the town, city, province, state, and/or country in which an agent was born.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfBirth</para>
    ///   <para>rdfs:label : has place of birth</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60593">rdau:P60593</a>
    /// </summary>
    let P60593 = _prefixId.prefix "P60593"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingMedium</para>
    ///   <para>rdfs:label : has recording medium</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60594">rdau:P60594</a>
    /// </summary>
    let P60594 = _prefixId.prefix "P60594"
    let P60595 = _prefixId.prefix "P60595"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the underlying physical material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : baseMaterial</para>
    ///   <para>rdfs:label : has base material</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60596">rdau:P60596</a>
    /// </summary>
    let P60596 = _prefixId.prefix "P60596"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the unique name assigned to a resource by an issn registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : keyTitle</para>
    ///   <para>rdfs:label : has key title</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60597">rdau:P60597</a>
    /// </summary>
    let P60597 = _prefixId.prefix "P60597"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the year an agent died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDeath</para>
    ///   <para>rdfs:label : has date of death</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60598">rdau:P60598</a>
    /// </summary>
    let P60598 = _prefixId.prefix "P60598"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the year an agent was born.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfBirth</para>
    ///   <para>rdfs:label : has date of birth</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60599">rdau:P60599</a>
    /// </summary>
    let P60599 = _prefixId.prefix "P60599"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedLyricsOf</para>
    ///   <para>rdfs:label : is writer of added lyrics of</para>
    ///   <para>skos:definition : Relates a writer of words added to a musical resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60600">rdau:P60600</a>
    /// </summary>
    let P60600 = _prefixId.prefix "P60600"
    /// <summary>
    ///   <para>rdfs:label : is appellee of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleeOf</para>
    ///   <para>skos:definition : Relates an agent against whom an appeal is taken on the decision of a lower court recorded in a legal resource of a higher court to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60601">rdau:P60601</a>
    /// </summary>
    let P60601 = _prefixId.prefix "P60601"
    /// <summary>
    ///   <para>rdfs:label : is other agent associated with a resource of</para>
    ///   <para>skos:definition : Relates an agent other than a creator, custodian, owner, producer, publisher, distributor or manufacturer associated with a resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherAgentAssociatedWithAResourceOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60602">rdau:P60602</a>
    /// </summary>
    let P60602 = _prefixId.prefix "P60602"
    /// <summary>
    ///   <para>skos:definition : Relates an agent by whom a resource is dedicated to the resource.</para>
    ///   <para>rdfs:label : is dedicator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60603">rdau:P60603</a>
    /// </summary>
    let P60603 = _prefixId.prefix "P60603"
    /// <summary>
    ///   <para>skos:definition : Relates an agent conceiving, aggregating, and/or organizing an exhibition, collection, or other resource to the resource.</para>
    ///   <para>rdfs:label : is curator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : curatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60604">rdau:P60604</a>
    /// </summary>
    let P60604 = _prefixId.prefix "P60604"
    /// <summary>
    ///   <para>rdfs:label : is surveyor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : surveyorOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a cartographic resource by providing measurements or dimensional relationships for the geographic area represented to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60605">rdau:P60605</a>
    /// </summary>
    let P60605 = _prefixId.prefix "P60605"
    /// <summary>
    ///   <para>rdfs:label : is animator of</para>
    ///   <para>skos:definition : Relates an agent contributing to a moving image resource or computer program by giving apparent movement to inanimate objects or drawings to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : animatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60606">rdau:P60606</a>
    /// </summary>
    let P60606 = _prefixId.prefix "P60606"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a musical resource by rewriting the composition for a medium of performance different from that for which the resource was originally intended to the resource.</para>
    ///   <para>rdfs:label : is arranger of music of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangerOfMusicOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60607">rdau:P60607</a>
    /// </summary>
    let P60607 = _prefixId.prefix "P60607"
    /// <summary>
    ///   <para>rdfs:label : is writer of added text of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedTextOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a primarily non-textual resource by providing text for the non-textual resource (e.g., writing captions for photographs, descriptions of maps) to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60608">rdau:P60608</a>
    /// </summary>
    let P60608 = _prefixId.prefix "P60608"
    /// <summary>
    ///   <para>rdfs:label : is draftsman of</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by an architect, inventor, etc., by making detailed plans or drawings for buildings, ships, aircraft, machines, objects, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : draftsmanOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60609">rdau:P60609</a>
    /// </summary>
    let P60609 = _prefixId.prefix "P60609"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transcriberOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by writing down or notating previously unwritten or unnotated content, or by changing it from one system of notation to another to the resource.</para>
    ///   <para>rdfs:label : is transcriber of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60610">rdau:P60610</a>
    /// </summary>
    let P60610 = _prefixId.prefix "P60610"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalDirectorOf</para>
    ///   <para>rdfs:label : is musical director of</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by coordinating the activities of the composer, the sound editor, and sound mixers for a moving image production or for a musical or dramatic presentation or entertainment to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60611">rdau:P60611</a>
    /// </summary>
    let P60611 = _prefixId.prefix "P60611"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by designing the costumes for a moving image production or for a musical or dramatic presentation or entertainment to the resource.</para>
    ///   <para>rdfs:label : is costume designer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : costumeDesignerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60612">rdau:P60612</a>
    /// </summary>
    let P60612 = _prefixId.prefix "P60612"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by expressing the linguistic content of the resource in a language different from that of previous expressions of the original resource to the resource.</para>
    ///   <para>rdfs:label : is translator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60613">rdau:P60613</a>
    /// </summary>
    let P60613 = _prefixId.prefix "P60613"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artDirectorOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by overseeing the artists and craftspeople who build the sets for moving image productions to the resource.</para>
    ///   <para>rdfs:label : is art director of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60614">rdau:P60614</a>
    /// </summary>
    let P60614 = _prefixId.prefix "P60614"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performerOf</para>
    ///   <para>rdfs:label : is performer of</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by performing music, acting, dancing, speaking, etc., often in a musical or dramatic presentation, etc. to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60615">rdau:P60615</a>
    /// </summary>
    let P60615 = _prefixId.prefix "P60615"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by preparing a court's opinions for publication to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtReporterOf</para>
    ///   <para>rdfs:label : is court reporter of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60616">rdau:P60616</a>
    /// </summary>
    let P60616 = _prefixId.prefix "P60616"
    /// <summary>
    ///   <para>rdfs:label : is writer of introduction of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPrefaceOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing an introduction to the original resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60617">rdau:P60617</a>
    /// </summary>
    let P60617 = _prefixId.prefix "P60617"
    /// <summary>
    ///   <para>rdfs:label : is writer of added commentary of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedCommentaryOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing an interpretation or critical explanation of the original resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60618">rdau:P60618</a>
    /// </summary>
    let P60618 = _prefixId.prefix "P60618"
    /// <summary>
    ///   <para>rdfs:label : is writer of afterword of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfIntroductionOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing an afterword to the original resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60619">rdau:P60619</a>
    /// </summary>
    let P60619 = _prefixId.prefix "P60619"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing a postface to the original resource to the resource.</para>
    ///   <para>rdfs:label : is writer of postface of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfSupplementaryTextualContentOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60620">rdau:P60620</a>
    /// </summary>
    let P60620 = _prefixId.prefix "P60620"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOf</para>
    ///   <para>rdfs:label : is editor of</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by revising or clarifying the content, e.g., adding an introduction, notes, or other critical matter to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60621">rdau:P60621</a>
    /// </summary>
    let P60621 = _prefixId.prefix "P60621"
    /// <summary>
    ///   <para>rdfs:label : is abridger of</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by shortening or condensing the original resource but leaving the nature and content of the original resource substantially unchanged to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60622">rdau:P60622</a>
    /// </summary>
    let P60622 = _prefixId.prefix "P60622"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by supervising the technical aspects of a sound or video recording session to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingEngineerOf</para>
    ///   <para>rdfs:label : is recording engineer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60623">rdau:P60623</a>
    /// </summary>
    let P60623 = _prefixId.prefix "P60623"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by supplementing the primary content with drawings, diagrams, photographs, etc. to the resource.</para>
    ///   <para>rdfs:label : is illustrator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustratorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60624">rdau:P60624</a>
    /// </summary>
    let P60624 = _prefixId.prefix "P60624"
    /// <summary>
    ///   <para>rdfs:label : is recordist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordistOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by using a recording device to capture sound and/or video during a recording session, including field recordings of natural sounds, folkloric events, music, etc. to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60625">rdau:P60625</a>
    /// </summary>
    let P60625 = _prefixId.prefix "P60625"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contributorOf</para>
    ///   <para>rdfs:label : is contributor of</para>
    ///   <para>skos:definition : Relates an agent contributing to an expression to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60626">rdau:P60626</a>
    /// </summary>
    let P60626 = _prefixId.prefix "P60626"
    /// <summary>
    ///   <para>rdfs:label : is stage director of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stageDirectorOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a stage resource through the general management and supervision of a performance to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60627">rdau:P60627</a>
    /// </summary>
    let P60627 = _prefixId.prefix "P60627"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : currentOwnerOf</para>
    ///   <para>rdfs:label : is current owner of</para>
    ///   <para>skos:definition : Relates an agent currently having legal possession of a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60628">rdau:P60628</a>
    /// </summary>
    let P60628 = _prefixId.prefix "P60628"
    /// <summary>
    ///   <para>skos:definition : Relates an agent employed by the agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : employee</para>
    ///   <para>rdfs:label : has employee</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60629">rdau:P60629</a>
    /// </summary>
    let P60629 = _prefixId.prefix "P60629"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formerOwnerOf</para>
    ///   <para>skos:definition : Relates an agent formerly having legal possession of a resource to the resource.</para>
    ///   <para>rdfs:label : is former owner of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60630">rdau:P60630</a>
    /// </summary>
    let P60630 = _prefixId.prefix "P60630"
    /// <summary>
    ///   <para>skos:definition : Relates an agent having legal custody of a resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodianOf</para>
    ///   <para>rdfs:label : is custodian of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60631">rdau:P60631</a>
    /// </summary>
    let P60631 = _prefixId.prefix "P60631"
    /// <summary>
    ///   <para>skos:definition : Relates an agent having legal possession of a resource to the resource.</para>
    ///   <para>rdfs:label : is owner of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ownerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60632">rdau:P60632</a>
    /// </summary>
    let P60632 = _prefixId.prefix "P60632"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incumbent</para>
    ///   <para>rdfs:label : has incumbent</para>
    ///   <para>skos:definition : Relates an agent holding an office in the agent to the agent.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60633">rdau:P60633</a>
    /// </summary>
    let P60633 = _prefixId.prefix "P60633"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honoureeOf</para>
    ///   <para>rdfs:label : is honouree of</para>
    ///   <para>skos:definition : Relates an agent honoured by a resource (e.g., the honouree of a festschrift) to the resource.</para>
    ///   <para>skos:altLabel : is honoree of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60634">rdau:P60634</a>
    /// </summary>
    let P60634 = _prefixId.prefix "P60634"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in broadcasting a resource to an audience via radio, television, webcast, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcasterOf</para>
    ///   <para>rdfs:label : is broadcaster of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60635">rdau:P60635</a>
    /// </summary>
    let P60635 = _prefixId.prefix "P60635"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in distributing a moving image resource to theatres or other distribution channels to the resource.</para>
    ///   <para>rdfs:label : is film distributor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDistributorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60636">rdau:P60636</a>
    /// </summary>
    let P60636 = _prefixId.prefix "P60636"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used to the resource.</para>
    ///   <para>rdfs:label : is book designer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookDesignerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60637">rdau:P60637</a>
    /// </summary>
    let P60637 = _prefixId.prefix "P60637"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : engraverOf</para>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by cutting letters, figures, etc., on a surface such as a wooden or metal plate used for printing to the resource.</para>
    ///   <para>rdfs:label : is engraver of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60638">rdau:P60638</a>
    /// </summary>
    let P60638 = _prefixId.prefix "P60638"
    /// <summary>
    ///   <para>rdfs:label : is braille embosser of</para>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by embossing braille cells using a stylus, special embossing printer, or other device to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : brailleEmbosserOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60639">rdau:P60639</a>
    /// </summary>
    let P60639 = _prefixId.prefix "P60639"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by making a relief, intaglio, or planographic printing surface to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printmakerOf</para>
    ///   <para>rdfs:label : is printmaker of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60640">rdau:P60640</a>
    /// </summary>
    let P60640 = _prefixId.prefix "P60640"
    /// <summary>
    ///   <para>rdfs:label : is caster of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : casterOf</para>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by pouring a liquid or molten substance into a mold and leaving it to solidify to take the shape of the mold to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60641">rdau:P60641</a>
    /// </summary>
    let P60641 = _prefixId.prefix "P60641"
    /// <summary>
    ///   <para>rdfs:label : is lithographer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lithographerOf</para>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by preparing a stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60642">rdau:P60642</a>
    /// </summary>
    let P60642 = _prefixId.prefix "P60642"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by preparing plates used in the production of printed images and/or text to the resource.</para>
    ///   <para>rdfs:label : is platemaker of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : platemakerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60643">rdau:P60643</a>
    /// </summary>
    let P60643 = _prefixId.prefix "P60643"
    /// <summary>
    ///   <para>rdfs:label : is etcher of</para>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource by subjecting metal, glass, or some other surface used for printing, to acid or another corrosive substance to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : etcherOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60644">rdau:P60644</a>
    /// </summary>
    let P60644 = _prefixId.prefix "P60644"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource using a photomechanical process for making prints directly from a hardened film of gelatin or other colloid that has ink-receptive and ink-repellent surfaces to the resource.</para>
    ///   <para>rdfs:label : is collotyper of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collotyperOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60645">rdau:P60645</a>
    /// </summary>
    let P60645 = _prefixId.prefix "P60645"
    /// <summary>
    ///   <para>skos:definition : Relates an agent involved in manufacturing a resource of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc. to the resource.</para>
    ///   <para>rdfs:label : is printer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60646">rdau:P60646</a>
    /// </summary>
    let P60646 = _prefixId.prefix "P60646"
    /// <summary>
    ///   <para>skos:definition : Relates an agent mentioned in an "X presents" credit for moving image materials and who is probably associated with production, finance, or distribution in some way to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presenterOf</para>
    ///   <para>rdfs:label : is presenter of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60647">rdau:P60647</a>
    /// </summary>
    let P60647 = _prefixId.prefix "P60647"
    /// <summary>
    ///   <para>rdfs:label : has member of</para>
    ///   <para>skos:definition : Relates an agent of which the agent is a member to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : memberOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60648">rdau:P60648</a>
    /// </summary>
    let P60648 = _prefixId.prefix "P60648"
    /// <summary>
    ///   <para>skos:definition : Relates an agent, such as an advisor or supervisor of thesis or dissertation research, overseeing either an academic degree or thesis to the resource.</para>
    ///   <para>rdfs:label : is degree supervisor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeSupervisorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60649">rdau:P60649</a>
    /// </summary>
    let P60649 = _prefixId.prefix "P60649"
    /// <summary>
    ///   <para>rdfs:label : is illuminator of</para>
    ///   <para>skos:definition : Relates an agent providing decoration to a specific resource using precious metals or color, often with elaborate designs and motifs to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illuminatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60650">rdau:P60650</a>
    /// </summary>
    let P60650 = _prefixId.prefix "P60650"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfMovingImageResourceOf</para>
    ///   <para>rdfs:label : is editor of moving image work of</para>
    ///   <para>skos:definition : Relates an agent responsible for assembling, arranging, and trimming film, video, or other moving image formats, including both visual and audio aspects to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60651">rdau:P60651</a>
    /// </summary>
    let P60651 = _prefixId.prefix "P60651"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : programmerOf</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a computer program to the resource.</para>
    ///   <para>rdfs:label : is programmer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60652">rdau:P60652</a>
    /// </summary>
    let P60652 = _prefixId.prefix "P60652"
    /// <summary>
    ///   <para>rdfs:label : is designer of</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a design for an object to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60653">rdau:P60653</a>
    /// </summary>
    let P60653 = _prefixId.prefix "P60653"
    /// <summary>
    ///   <para>rdfs:label : is cartographer of</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a map, atlas, globe, or other cartographic resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60654">rdau:P60654</a>
    /// </summary>
    let P60654 = _prefixId.prefix "P60654"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for creating a musical resource to the resource.</para>
    ///   <para>rdfs:label : is composer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60655">rdau:P60655</a>
    /// </summary>
    let P60655 = _prefixId.prefix "P60655"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inventorOf</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a new device or process to the resource.</para>
    ///   <para>rdfs:label : is inventor of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60656">rdau:P60656</a>
    /// </summary>
    let P60656 = _prefixId.prefix "P60656"
    /// <summary>
    ///   <para>rdfs:label : is compiler of</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a new resource (e.g., a bibliography, a directory) by selecting, arranging, aggregating, and editing data, information, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : compilerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60657">rdau:P60657</a>
    /// </summary>
    let P60657 = _prefixId.prefix "P60657"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for creating a photographic resource to the resource.</para>
    ///   <para>rdfs:label : is photographer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : photographerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60658">rdau:P60658</a>
    /// </summary>
    let P60658 = _prefixId.prefix "P60658"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for creating a resource by acting as an interviewer, reporter, pollster, or some other information gathering agent to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewerOf</para>
    ///   <para>rdfs:label : is interviewer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60659">rdau:P60659</a>
    /// </summary>
    let P60659 = _prefixId.prefix "P60659"
    /// <summary>
    ///   <para>rdfs:label : is artist of</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a resource by conceiving, and often implementing, an original graphic design, drawing, painting, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60660">rdau:P60660</a>
    /// </summary>
    let P60660 = _prefixId.prefix "P60660"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for creating a resource by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent to the resource.</para>
    ///   <para>rdfs:label : is interviewee of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intervieweeOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60661">rdau:P60661</a>
    /// </summary>
    let P60661 = _prefixId.prefix "P60661"
    /// <summary>
    ///   <para>rdfs:label : is choreographer of</para>
    ///   <para>skos:definition : Relates an agent responsible for creating a resource of movement to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60662">rdau:P60662</a>
    /// </summary>
    let P60662 = _prefixId.prefix "P60662"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for creating a resource that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs) to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : authorOf</para>
    ///   <para>rdfs:label : is author of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60663">rdau:P60663</a>
    /// </summary>
    let P60663 = _prefixId.prefix "P60663"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for creating an architectural design, including a pictorial representation intended to show how a building, etc., will look when completed to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : architectOf</para>
    ///   <para>rdfs:label : is architect of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60664">rdau:P60664</a>
    /// </summary>
    let P60664 = _prefixId.prefix "P60664"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmmakerOf</para>
    ///   <para>rdfs:label : is filmmaker of</para>
    ///   <para>skos:definition : Relates an agent responsible for creating an independent or personal film to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60665">rdau:P60665</a>
    /// </summary>
    let P60665 = _prefixId.prefix "P60665"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionDesignerOf</para>
    ///   <para>skos:definition : Relates an agent responsible for designing the overall visual appearance of a moving image production to the resource.</para>
    ///   <para>rdfs:label : is production designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60666">rdau:P60666</a>
    /// </summary>
    let P60666 = _prefixId.prefix "P60666"
    /// <summary>
    ///   <para>rdfs:label : is distributor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorOf</para>
    ///   <para>skos:definition : Relates an agent responsible for distributing a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60667">rdau:P60667</a>
    /// </summary>
    let P60667 = _prefixId.prefix "P60667"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for most of the business aspects of a production for screen, sound recording, television, webcast, etc. the producer is generally responsible for fund raising, managing the production, hiring key personnel, arranging for distributors, etc. to the resource.</para>
    ///   <para>rdfs:label : is producer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60668">rdau:P60668</a>
    /// </summary>
    let P60668 = _prefixId.prefix "P60668"
    /// <summary>
    ///   <para>rdfs:label : is manufacturer of</para>
    ///   <para>skos:definition : Relates an agent responsible for printing, duplicating, casting, etc., a resource in a published form to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60669">rdau:P60669</a>
    /// </summary>
    let P60669 = _prefixId.prefix "P60669"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for publishing, releasing, or issuing a resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publisherOf</para>
    ///   <para>rdfs:label : is publisher of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60670">rdau:P60670</a>
    /// </summary>
    let P60670 = _prefixId.prefix "P60670"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : minuteTakerOf</para>
    ///   <para>rdfs:label : is minute taker of</para>
    ///   <para>skos:definition : Relates an agent responsible for recording the minutes of a meeting to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60671">rdau:P60671</a>
    /// </summary>
    let P60671 = _prefixId.prefix "P60671"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : creatorOf</para>
    ///   <para>rdfs:label : is creator of</para>
    ///   <para>skos:definition : Relates an agent responsible for the creation of a resourc to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60672">rdau:P60672</a>
    /// </summary>
    let P60672 = _prefixId.prefix "P60672"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for the general management and supervision of a filmed performance, a radio or television program, etc. to the resource.</para>
    ///   <para>rdfs:label : is director of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60673">rdau:P60673</a>
    /// </summary>
    let P60673 = _prefixId.prefix "P60673"
    /// <summary>
    ///   <para>rdfs:label : is restorationist of</para>
    ///   <para>skos:definition : Relates an agent responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of a resource by bringing it back to a state as close as possible to its original condition to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restorationistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60674">rdau:P60674</a>
    /// </summary>
    let P60674 = _prefixId.prefix "P60674"
    /// <summary>
    ///   <para>rdfs:label : is sponsoring body of</para>
    ///   <para>skos:definition : Relates an agent sponsoring some aspect of a resource, e.g., funding research, sponsoring an event to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringBodyOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60675">rdau:P60675</a>
    /// </summary>
    let P60675 = _prefixId.prefix "P60675"
    /// <summary>
    ///   <para>skos:definition : Relates an agent sponsoring the agent to the agent.</para>
    ///   <para>rdfs:label : has sponsor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60676">rdau:P60676</a>
    /// </summary>
    let P60676 = _prefixId.prefix "P60676"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that captures images, either electronically or on film or video stock, and often selects and arranges the lighting. the director of photography for a movie is also called the chief cinematographer to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOfPhotographyOf</para>
    ///   <para>rdfs:label : is director of photography of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60678">rdau:P60678</a>
    /// </summary>
    let P60678 = _prefixId.prefix "P60678"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that employs the agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : employer</para>
    ///   <para>rdfs:label : has employer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60679">rdau:P60679</a>
    /// </summary>
    let P60679 = _prefixId.prefix "P60679"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that is hierarchically superior to the other agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hierarchicalSuperior</para>
    ///   <para>rdfs:label : has hierarchical superior</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60680">rdau:P60680</a>
    /// </summary>
    let P60680 = _prefixId.prefix "P60680"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that is subordinate to the other agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hierarchicalSubordinate</para>
    ///   <para>rdfs:label : has hierarchical subordinate</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60681">rdau:P60681</a>
    /// </summary>
    let P60681 = _prefixId.prefix "P60681"
    /// <summary>
    ///   <para>skos:definition : Relates a agent that merged with the other agent to form a third to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergee</para>
    ///   <para>rdfs:label : has mergee</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60682">rdau:P60682</a>
    /// </summary>
    let P60682 = _prefixId.prefix "P60682"
    /// <summary>
    ///   <para>rdfs:label : has predecessor</para>
    ///   <para>skos:definition : Relates an agent that precedes the other agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : predecessor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60683">rdau:P60683</a>
    /// </summary>
    let P60683 = _prefixId.prefix "P60683"
    /// <summary>
    ///   <para>skos:definition : Relates a agent that resulted from a merger of two or more other agents to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productOfAMerger</para>
    ///   <para>rdfs:label : has product of merger</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60684">rdau:P60684</a>
    /// </summary>
    let P60684 = _prefixId.prefix "P60684"
    /// <summary>
    ///   <para>skos:definition : Relates a agent that resulted from a split or division of the other agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productOfASplit</para>
    ///   <para>rdfs:label : has product of split</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60685">rdau:P60685</a>
    /// </summary>
    let P60685 = _prefixId.prefix "P60685"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : successor</para>
    ///   <para>skos:definition : Relates an agent that succeeds or follows the other agent to the agent.</para>
    ///   <para>rdfs:label : has successor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60686">rdau:P60686</a>
    /// </summary>
    let P60686 = _prefixId.prefix "P60686"
    /// <summary>
    ///   <para>rdfs:label : has founded entity</para>
    ///   <para>skos:definition : Relates an agent that the agent founded to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundedEntity</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60687">rdau:P60687</a>
    /// </summary>
    let P60687 = _prefixId.prefix "P60687"
    /// <summary>
    ///   <para>rdfs:label : has sponsored entity</para>
    ///   <para>skos:definition : Relates an agent that the agent sponsors to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoredEntity</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60688">rdau:P60688</a>
    /// </summary>
    let P60688 = _prefixId.prefix "P60688"
    /// <summary>
    ///   <para>rdfs:label : is dedicatee of</para>
    ///   <para>skos:definition : Relates an agent to whom a resource is dedicated to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicateeOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60689">rdau:P60689</a>
    /// </summary>
    let P60689 = _prefixId.prefix "P60689"
    /// <summary>
    ///   <para>rdfs:label : is addressee of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addresseeOf</para>
    ///   <para>skos:definition : Relates an agent to whom a resource or part of a resource is addressed to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60690">rdau:P60690</a>
    /// </summary>
    let P60690 = _prefixId.prefix "P60690"
    /// <summary>
    ///   <para>rdfs:label : is appellant of</para>
    ///   <para>skos:definition : Relates an agent who appeals the decision of a lower court recorded in a legal resource of a higher court to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60691">rdau:P60691</a>
    /// </summary>
    let P60691 = _prefixId.prefix "P60691"
    /// <summary>
    ///   <para>rdfs:label : is binder of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : binderOf</para>
    ///   <para>skos:definition : Relates an agent who binds a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60692">rdau:P60692</a>
    /// </summary>
    let P60692 = _prefixId.prefix "P60692"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffOf</para>
    ///   <para>skos:definition : Relates an agent who brings a suit in a civil proceeding to the resource.</para>
    ///   <para>rdfs:label : is plaintiff of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60693">rdau:P60693</a>
    /// </summary>
    let P60693 = _prefixId.prefix "P60693"
    /// <summary>
    ///   <para>rdfs:label : has founder</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : founder</para>
    ///   <para>skos:definition : Relates an agent who founded the agent to the agent.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60694">rdau:P60694</a>
    /// </summary>
    let P60694 = _prefixId.prefix "P60694"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inscriberOf</para>
    ///   <para>rdfs:label : is inscriber of</para>
    ///   <para>skos:definition : Relates an agent who has written a statement of dedication or gift on a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60695">rdau:P60695</a>
    /// </summary>
    let P60695 = _prefixId.prefix "P60695"
    /// <summary>
    ///   <para>skos:definition : Relates an agent who hears and decides on legal matters in court to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : judgeOf</para>
    ///   <para>rdfs:label : is judge of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60696">rdau:P60696</a>
    /// </summary>
    let P60696 = _prefixId.prefix "P60696"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : member</para>
    ///   <para>skos:definition : Relates an agent who is a member of the agent to the agent.</para>
    ///   <para>rdfs:label : has member</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60697">rdau:P60697</a>
    /// </summary>
    let P60697 = _prefixId.prefix "P60697"
    /// <summary>
    ///   <para>rdfs:label : is defendant of</para>
    ///   <para>skos:definition : Relates an agent who is accused in a criminal proceeding or sued in a civil proceeding to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60698">rdau:P60698</a>
    /// </summary>
    let P60698 = _prefixId.prefix "P60698"
    /// <summary>
    ///   <para>rdfs:label : is praeses of</para>
    ///   <para>skos:definition : Relates an agent who is the faculty moderator of an academic disputation, normally proposing a thesis and participating in the ensuing disputation to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : praesesOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60699">rdau:P60699</a>
    /// </summary>
    let P60699 = _prefixId.prefix "P60699"
    /// <summary>
    ///   <para>rdfs:label : is annotator of</para>
    ///   <para>skos:definition : Relates an agent who makes manuscript annotations on a resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : annotatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60700">rdau:P60700</a>
    /// </summary>
    let P60700 = _prefixId.prefix "P60700"
    /// <summary>
    ///   <para>skos:definition : Relates an agent who provides consultation services, and often makes recommendations, for another person, family or corporate body that is represented as the creator of a resource to the resource.</para>
    ///   <para>rdfs:label : is consultant of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : consultantOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60701">rdau:P60701</a>
    /// </summary>
    let P60701 = _prefixId.prefix "P60701"
    /// <summary>
    ///   <para>rdfs:label : is autographer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : autographerOf</para>
    ///   <para>skos:definition : Relates an agent whose manuscript signature appears on a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60702">rdau:P60702</a>
    /// </summary>
    let P60702 = _prefixId.prefix "P60702"
    /// <summary>
    ///   <para>rdfs:label : is issuing body of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuingBodyOf</para>
    ///   <para>skos:definition : Relates an agent, family or corporate body issuing a resource, such as an official organ of the body to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60703">rdau:P60703</a>
    /// </summary>
    let P60703 = _prefixId.prefix "P60703"
    /// <summary>
    ///   <para>rdfs:label : is landscape architect of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : landscapeArchitectOf</para>
    ///   <para>skos:definition : Relates an architect responsible for creating landscape resources to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60704">rdau:P60704</a>
    /// </summary>
    let P60704 = _prefixId.prefix "P60704"
    /// <summary>
    ///   <para>skos:definition : Relates an artist responsible for creating a three-dimensional resource by modeling, carving, or similar technique to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sculptorOf</para>
    ///   <para>rdfs:label : is sculptor of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60705">rdau:P60705</a>
    /// </summary>
    let P60705 = _prefixId.prefix "P60705"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenwriterOf</para>
    ///   <para>skos:definition : Relates an author of a screenplay, script, or scene to the resource.</para>
    ///   <para>rdfs:label : is screenwriter of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60706">rdau:P60706</a>
    /// </summary>
    let P60706 = _prefixId.prefix "P60706"
    /// <summary>
    ///   <para>rdfs:label : is lyricist of</para>
    ///   <para>skos:definition : Relates an author of the words of a popular song, including a song or songs from a musical to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lyricistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60707">rdau:P60707</a>
    /// </summary>
    let P60707 = _prefixId.prefix "P60707"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettistOf</para>
    ///   <para>skos:definition : Relates an author of the words of an opera or other musical stage resource or an oratorio to the resource.</para>
    ///   <para>rdfs:label : is librettist of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60708">rdau:P60708</a>
    /// </summary>
    let P60708 = _prefixId.prefix "P60708"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingResourceRelationshipWith</para>
    ///   <para>rdfs:label : has accompanying resource relationship with</para>
    ///   <para>skos:definition : Relates a resource to a resource that is an augmentation of, or is augmented by, or is complemented by, or accompanies, or is accompanied by the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60709">rdau:P60709</a>
    /// </summary>
    let P60709 = _prefixId.prefix "P60709"
    /// <summary>
    ///   <para>rdfs:label : has derivative resource relationship with</para>
    ///   <para>skos:definition : Relates a resource to a resource that is based on or is a derivative of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeResourceRelationshipWith</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60710">rdau:P60710</a>
    /// </summary>
    let P60710 = _prefixId.prefix "P60710"
    let P60711 = _prefixId.prefix "P60711"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalentResourceRelationshipWith</para>
    ///   <para>skos:definition : Relates a resource to a resource that is equivalent to the resource.</para>
    ///   <para>rdfs:label : has equivalent resource relationship with</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60712">rdau:P60712</a>
    /// </summary>
    let P60712 = _prefixId.prefix "P60712"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that is preceded by or succeeded by the resource.</para>
    ///   <para>rdfs:label : has sequential resource relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialResourceRelationshipWith</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60713">rdau:P60713</a>
    /// </summary>
    let P60713 = _prefixId.prefix "P60713"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that is contained in or contains the resource.</para>
    ///   <para>rdfs:label : has whole-part resource relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartResourceRelationshipWith</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60714">rdau:P60714</a>
    /// </summary>
    let P60714 = _prefixId.prefix "P60714"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAfterword</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing an afterword to the original resource.</para>
    ///   <para>rdfs:label : has writer of afterword</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60715">rdau:P60715</a>
    /// </summary>
    let P60715 = _prefixId.prefix "P60715"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPostface</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing a postface to the original resource.</para>
    ///   <para>rdfs:label : has writer of postface</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60716">rdau:P60716</a>
    /// </summary>
    let P60716 = _prefixId.prefix "P60716"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing a preface to the original resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAfterwordOf</para>
    ///   <para>rdfs:label : is writer of preface of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60717">rdau:P60717</a>
    /// </summary>
    let P60717 = _prefixId.prefix "P60717"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPostfaceOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing supplementary textual content (e.g., an appendix, an introduction, a preface) to the original resource to the resource.</para>
    ///   <para>rdfs:label : is writer of supplementary textual content of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60718">rdau:P60718</a>
    /// </summary>
    let P60718 = _prefixId.prefix "P60718"
    /// <summary>
    ///   <para>rdfs:label : is musical theatre adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalTheatreAdaptationOf</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a musical theatre resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60719">rdau:P60719</a>
    /// </summary>
    let P60719 = _prefixId.prefix "P60719"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as opera.</para>
    ///   <para>rdfs:label : is opera adaptation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : operaAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60720">rdau:P60720</a>
    /// </summary>
    let P60720 = _prefixId.prefix "P60720"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsMusicalTheatre</para>
    ///   <para>skos:definition : Relates a resource to a musical theatre resource based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as musical theatre</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60721">rdau:P60721</a>
    /// </summary>
    let P60721 = _prefixId.prefix "P60721"
    /// <summary>
    ///   <para>rdfs:label : is adapted as opera</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsOpera</para>
    ///   <para>skos:definition : Relates a resource to an opera based on the source resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60722">rdau:P60722</a>
    /// </summary>
    let P60722 = _prefixId.prefix "P60722"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource that is used in a motion picture, play, television program, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : music</para>
    ///   <para>rdfs:label : is music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60723">rdau:P60723</a>
    /// </summary>
    let P60723 = _prefixId.prefix "P60723"
    /// <summary>
    ///   <para>rdfs:label : is music for</para>
    ///   <para>skos:definition : Relates a resource to a resource such as a motion picture, play, television program, etc. that uses the musical resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicFor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60724">rdau:P60724</a>
    /// </summary>
    let P60724 = _prefixId.prefix "P60724"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource that is used in a video.</para>
    ///   <para>rdfs:label : is video music</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoMusic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60725">rdau:P60725</a>
    /// </summary>
    let P60725 = _prefixId.prefix "P60725"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the musical resource in a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForVideo</para>
    ///   <para>rdfs:label : is music for video</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60726">rdau:P60726</a>
    /// </summary>
    let P60726 = _prefixId.prefix "P60726"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProgramMusic</para>
    ///   <para>skos:definition : Relates a resource to a musical resource that is used in a television program.</para>
    ///   <para>rdfs:label : is television program music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60727">rdau:P60727</a>
    /// </summary>
    let P60727 = _prefixId.prefix "P60727"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForTelevisionProgram</para>
    ///   <para>rdfs:label : is music for television program</para>
    ///   <para>skos:definition : Relates a resource to a resource that uses the musical resource in a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60728">rdau:P60728</a>
    /// </summary>
    let P60728 = _prefixId.prefix "P60728"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a musical resource that is used in a radio program.</para>
    ///   <para>rdfs:label : is radio program music</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProgramMusic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60729">rdau:P60729</a>
    /// </summary>
    let P60729 = _prefixId.prefix "P60729"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the musical resource in a radio program.</para>
    ///   <para>rdfs:label : is music for radio program</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForRadioProgram</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60730">rdau:P60730</a>
    /// </summary>
    let P60730 = _prefixId.prefix "P60730"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the musical resource in a motion picture.</para>
    ///   <para>rdfs:label : is music for motion picture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForMotionPicture</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60731">rdau:P60731</a>
    /// </summary>
    let P60731 = _prefixId.prefix "P60731"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureMusic</para>
    ///   <para>skos:definition : Relates a resource to a musical resource that is used in a motion picture.</para>
    ///   <para>rdfs:label : is motion picture music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60732">rdau:P60732</a>
    /// </summary>
    let P60732 = _prefixId.prefix "P60732"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that split or divided into the other agent to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : predecessorOfSplit</para>
    ///   <para>rdfs:label : has predecessor of split</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60733">rdau:P60733</a>
    /// </summary>
    let P60733 = _prefixId.prefix "P60733"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that formed the other agent by merging with one or more other agents to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : componentOfAMerger</para>
    ///   <para>rdfs:label : has component of a merger</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60736">rdau:P60736</a>
    /// </summary>
    let P60736 = _prefixId.prefix "P60736"
    /// <summary>
    ///   <para>skos:definition : Relates an agent in which the agent holds an office to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : officiatedAgent</para>
    ///   <para>rdfs:label : has officiated agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60737">rdau:P60737</a>
    /// </summary>
    let P60737 = _prefixId.prefix "P60737"
    /// <summary>
    ///   <para>skos:definition : Relates an agent that acts for the local affiliated agent and others at a broader organizational level to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broaderAffiliatedAgent</para>
    ///   <para>rdfs:label : has broader affiliated agent</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60738">rdau:P60738</a>
    /// </summary>
    let P60738 = _prefixId.prefix "P60738"
    /// <summary>
    ///   <para>skos:definition : Relates a local agent affiliated with the broader agent which acts for it and others at a broader organizational level to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : localAffiliate</para>
    ///   <para>rdfs:label : has local affiliate</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60739">rdau:P60739</a>
    /// </summary>
    let P60739 = _prefixId.prefix "P60739"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that provides the choreography for use in the related resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreography</para>
    ///   <para>rdfs:label : is choreography</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60740">rdau:P60740</a>
    /// </summary>
    let P60740 = _prefixId.prefix "P60740"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that uses the choreography of the related resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyFor</para>
    ///   <para>rdfs:label : is choreography for</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60741">rdau:P60741</a>
    /// </summary>
    let P60741 = _prefixId.prefix "P60741"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a graphic novel based on the source resource</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsGraphicNovel</para>
    ///   <para>rdfs:label : is adapted as graphic novel</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60742">rdau:P60742</a>
    /// </summary>
    let P60742 = _prefixId.prefix "P60742"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapated as a graphic novel.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : graphicNovelizationOf</para>
    ///   <para>rdfs:label : is graphic novelization of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60743">rdau:P60743</a>
    /// </summary>
    let P60743 = _prefixId.prefix "P60743"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to relates a resource to a video game based on the source resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsVideoGame</para>
    ///   <para>rdfs:label : is adapted as video game</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60744">rdau:P60744</a>
    /// </summary>
    let P60744 = _prefixId.prefix "P60744"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as a video game.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoGameAdaptationOf</para>
    ///   <para>rdfs:label : is video game adaptation of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60745">rdau:P60745</a>
    /// </summary>
    let P60745 = _prefixId.prefix "P60745"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for the production of paper used to manufacture a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : papermaker</para>
    ///   <para>rdfs:label : has papermaker</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60746">rdau:P60746</a>
    /// </summary>
    let P60746 = _prefixId.prefix "P60746"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for the production of paper used to manufacture a resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : papermakerOf</para>
    ///   <para>rdfs:label : is papermaker of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60747">rdau:P60747</a>
    /// </summary>
    let P60747 = _prefixId.prefix "P60747"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to an expression of a moving image resource by designing and creating post-production visual effects.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : visualEffectsProvider</para>
    ///   <para>rdfs:label : has visual effects provider</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60748">rdau:P60748</a>
    /// </summary>
    let P60748 = _prefixId.prefix "P60748"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a moving image or audio resource by designing and creating on-set special effects (on-set mechanical effects and in-camera optical effects).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialEffectsProvider</para>
    ///   <para>rdfs:label : has special effects provider</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60749">rdau:P60749</a>
    /// </summary>
    let P60749 = _prefixId.prefix "P60749"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an illustrator contributing to a comic book, graphic novel, etc., by drawing the text and graphic sound effects.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : letterer</para>
    ///   <para>rdfs:label : has letterer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60750">rdau:P60750</a>
    /// </summary>
    let P60750 = _prefixId.prefix "P60750"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an author who is appointed by an organization to report on the proceedings of its meetings.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rapporteur</para>
    ///   <para>rdfs:label : has rapporteur</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60751">rdau:P60751</a>
    /// </summary>
    let P60751 = _prefixId.prefix "P60751"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an artist responsible for creating a resource of calligraphy where the focus of interest lies in the aesthetic value of its penmanship or graphic artistry, regardless of whether the same person, etc., also authored the inscribed text.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : calligrapher</para>
    ///   <para>rdfs:label : has calligrapher</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60752">rdau:P60752</a>
    /// </summary>
    let P60752 = _prefixId.prefix "P60752"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an artist responsible for creating art resources that exploit the book form or alter its physical structure as part of the content of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookArtist</para>
    ///   <para>rdfs:label : has book artist</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60753">rdau:P60753</a>
    /// </summary>
    let P60753 = _prefixId.prefix "P60753"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to an expression of a moving image resource by designing and creating post-production visual effects to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : visualEffectsProviderOf</para>
    ///   <para>rdfs:label : is visual effects provider of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60754">rdau:P60754</a>
    /// </summary>
    let P60754 = _prefixId.prefix "P60754"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a moving image or audio resource by designing and creating on-set special effects (on-set mechanical effects and in-camera optical effects) to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialEffectsProviderOf</para>
    ///   <para>rdfs:label : is special effects provider of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60755">rdau:P60755</a>
    /// </summary>
    let P60755 = _prefixId.prefix "P60755"
    /// <summary>
    ///   <para>skos:definition : Relates an illustrator contributing to a comic book, graphic novel, etc., by drawing the text and graphic sound effects to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lettererOf</para>
    ///   <para>rdfs:label : is letterer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60756">rdau:P60756</a>
    /// </summary>
    let P60756 = _prefixId.prefix "P60756"
    /// <summary>
    ///   <para>skos:definition : Relates an author who is appointed by an organization to report on the proceedings of its meetings to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rapporteurOf</para>
    ///   <para>rdfs:label : is rapporteur of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60757">rdau:P60757</a>
    /// </summary>
    let P60757 = _prefixId.prefix "P60757"
    /// <summary>
    ///   <para>skos:definition : Relates an artist responsible for creating a resource of calligraphy where the focus of interest lies in the aesthetic value of its penmanship or graphic artistry, regardless of whether the same person, etc., also authored the inscribed text to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : calligrapherOf</para>
    ///   <para>rdfs:label : is calligrapher of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60758">rdau:P60758</a>
    /// </summary>
    let P60758 = _prefixId.prefix "P60758"
    /// <summary>
    ///   <para>skos:definition : Relates an artist responsible for creating art resources that exploit the book form or alter its physical structure as part of the content of the resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookArtistOf</para>
    ///   <para>rdfs:label : is book artist of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60759">rdau:P60759</a>
    /// </summary>
    let P60759 = _prefixId.prefix "P60759"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the ratio of the width to the height of a moving image.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfAspectRatio</para>
    ///   <para>rdfs:label : has details of aspect ratio</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60760">rdau:P60760</a>
    /// </summary>
    let P60760 = _prefixId.prefix "P60760"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the presence of colour, tone, etc., in the content of a resource, and the specific colours, tones, etc., (including black and white) present.</para>
    ///   <para>skos:altLabel : has details of color content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfColourContent</para>
    ///   <para>rdfs:label : has details of colour content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60761">rdau:P60761</a>
    /// </summary>
    let P60761 = _prefixId.prefix "P60761"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the set of characters and/or symbols used to express the musical content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFormOfMusicalNotation</para>
    ///   <para>rdfs:label : has details of form of musical notation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60762">rdau:P60762</a>
    /// </summary>
    let P60762 = _prefixId.prefix "P60762"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the set of characters and/or symbols used to express the movement content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFormOfNotatedMovement</para>
    ///   <para>rdfs:label : has details of form of notated movement</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60763">rdau:P60763</a>
    /// </summary>
    let P60763 = _prefixId.prefix "P60763"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the musical or physical layout of the content of a resource that is presented in the form of musical notation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFormatOfNotatedMusic</para>
    ///   <para>rdfs:label : has details of format of notated music</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60764">rdau:P60764</a>
    /// </summary>
    let P60764 = _prefixId.prefix "P60764"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the set of characters and/or symbols used to express the content of a resource in a form that can be perceived through touch.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFormOfTactileNotation</para>
    ///   <para>rdfs:label : has details of form of tactile notation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60765">rdau:P60765</a>
    /// </summary>
    let P60765 = _prefixId.prefix "P60765"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of set of characters and/or symbols used to express the written language content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfScript</para>
    ///   <para>rdfs:label : has details of script</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60766">rdau:P60766</a>
    /// </summary>
    let P60766 = _prefixId.prefix "P60766"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a physical or chemical substance applied to a base material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfAppliedMaterial</para>
    ///   <para>rdfs:label : has details of applied material</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60767">rdau:P60767</a>
    /// </summary>
    let P60767 = _prefixId.prefix "P60767"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the underlying physical material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfBaseMaterial</para>
    ///   <para>rdfs:label : has details of base material</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60768">rdau:P60768</a>
    /// </summary>
    let P60768 = _prefixId.prefix "P60768"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfBookFormat</para>
    ///   <para>rdfs:label : has details of book format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60769">rdau:P60769</a>
    /// </summary>
    let P60769 = _prefixId.prefix "P60769"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a system used to format a video resource for television broadcast.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfBroadcastStandard</para>
    ///   <para>rdfs:label : has details of broadcast standard</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60770">rdau:P60770</a>
    /// </summary>
    let P60770 = _prefixId.prefix "P60770"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfConfigurationOfPlaybackChannels</para>
    ///   <para>rdfs:label : has details of configuration of playback channels</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60771">rdau:P60771</a>
    /// </summary>
    let P60771 = _prefixId.prefix "P60771"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfDigitalFileCharacteristic</para>
    ///   <para>rdfs:label : has details of digital file characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60772">rdau:P60772</a>
    /// </summary>
    let P60772 = _prefixId.prefix "P60772"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the encoding of geospatial information in a cartographic resource (e.g., topology level, compression).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfDigitalRepresentationOfCartographicContent</para>
    ///   <para>rdfs:label : has details of digital representation of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60773">rdau:P60773</a>
    /// </summary>
    let P60773 = _prefixId.prefix "P60773"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfEmulsionOnMicrofilmAndMicrofiche</para>
    ///   <para>rdfs:label : has details of emulsion on microfilm and microfiche</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60774">rdau:P60774</a>
    /// </summary>
    let P60774 = _prefixId.prefix "P60774"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfEncodingFormat</para>
    ///   <para>rdfs:label : has details of encoding format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60775">rdau:P60775</a>
    /// </summary>
    let P60775 = _prefixId.prefix "P60775"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFileType</para>
    ///   <para>rdfs:label : has details of file type</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60776">rdau:P60776</a>
    /// </summary>
    let P60776 = _prefixId.prefix "P60776"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfFontSize</para>
    ///   <para>rdfs:label : has details of font size</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60777">rdau:P60777</a>
    /// </summary>
    let P60777 = _prefixId.prefix "P60777"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the relationship between an original audio carrier and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfAudioRecording</para>
    ///   <para>rdfs:label : has details of generation of audio recording</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60778">rdau:P60778</a>
    /// </summary>
    let P60778 = _prefixId.prefix "P60778"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfDigitalResource</para>
    ///   <para>rdfs:label : has details of generation of digital resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60779">rdau:P60779</a>
    /// </summary>
    let P60779 = _prefixId.prefix "P60779"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the relationship between an original microform carrier and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfMicroform</para>
    ///   <para>rdfs:label : has details of generation of microform</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60780">rdau:P60780</a>
    /// </summary>
    let P60780 = _prefixId.prefix "P60780"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfMotionPictureFilm</para>
    ///   <para>rdfs:label : has details of generation of motion picture film</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60781">rdau:P60781</a>
    /// </summary>
    let P60781 = _prefixId.prefix "P60781"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGenerationOfVideotape</para>
    ///   <para>rdfs:label : has details of generation of videotape</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60782">rdau:P60782</a>
    /// </summary>
    let P60782 = _prefixId.prefix "P60782"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGrooveCharacteristic</para>
    ///   <para>rdfs:label : has details of groove characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60783">rdau:P60783</a>
    /// </summary>
    let P60783 = _prefixId.prefix "P60783"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the arrangement of text, images, tactile notation, etc., in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfLayout</para>
    ///   <para>rdfs:label : has details of layout</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60784">rdau:P60784</a>
    /// </summary>
    let P60784 = _prefixId.prefix "P60784"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfMount</para>
    ///   <para>rdfs:label : has details of mount</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60785">rdau:P60785</a>
    /// </summary>
    let P60785 = _prefixId.prefix "P60785"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfPlayingSpeed</para>
    ///   <para>rdfs:label : has details of playing speed</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60786">rdau:P60786</a>
    /// </summary>
    let P60786 = _prefixId.prefix "P60786"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the relationship of the colours and tones in an image to the colours and tones of the object reproduced (e.g., positive, negative).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfPolarity</para>
    ///   <para>rdfs:label : has details of polarity</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60787">rdau:P60787</a>
    /// </summary>
    let P60787 = _prefixId.prefix "P60787"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the format used in the production of a projected image (e.g., cinerama, imax).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfPresentationFormat</para>
    ///   <para>rdfs:label : has details of presentation format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60788">rdau:P60788</a>
    /// </summary>
    let P60788 = _prefixId.prefix "P60788"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the process used to produce a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProductionMethod</para>
    ///   <para>rdfs:label : has details of production method</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60789">rdau:P60789</a>
    /// </summary>
    let P60789 = _prefixId.prefix "P60789"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the process used to produce an original manuscript or a copy.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProductionMethodForManuscript</para>
    ///   <para>rdfs:label : has details of production method for manuscript</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60790">rdau:P60790</a>
    /// </summary>
    let P60790 = _prefixId.prefix "P60790"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProductionMethodForTactileResource</para>
    ///   <para>rdfs:label : has details of production method for tactile resource</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60791">rdau:P60791</a>
    /// </summary>
    let P60791 = _prefixId.prefix "P60791"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a technical specification relating to the projection of a motion picture film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProjectionCharacteristicOfMotionPictureFilm</para>
    ///   <para>rdfs:label : has details of projection characteristic of motion picture film</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60792">rdau:P60792</a>
    /// </summary>
    let P60792 = _prefixId.prefix "P60792"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfProjectionSpeed</para>
    ///   <para>rdfs:label : has details of projection speed</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60793">rdau:P60793</a>
    /// </summary>
    let P60793 = _prefixId.prefix "P60793"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfRecordingMedium</para>
    ///   <para>rdfs:label : has details of recording medium</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60794">rdau:P60794</a>
    /// </summary>
    let P60794 = _prefixId.prefix "P60794"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfReductionRatio</para>
    ///   <para>rdfs:label : has details of reduction ratio</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60795">rdau:P60795</a>
    /// </summary>
    let P60795 = _prefixId.prefix "P60795"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a technical specification relating to the encoding of sound in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfSoundCharacteristic</para>
    ///   <para>rdfs:label : has details of sound characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60796">rdau:P60796</a>
    /// </summary>
    let P60796 = _prefixId.prefix "P60796"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of an equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfSpecialPlaybackCharacteristic</para>
    ///   <para>rdfs:label : has details of special playback characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60797">rdau:P60797</a>
    /// </summary>
    let P60797 = _prefixId.prefix "P60797"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the number of tracks on an audiotape.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfTapeConfiguration</para>
    ///   <para>rdfs:label : has details of tape configuration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60798">rdau:P60798</a>
    /// </summary>
    let P60798 = _prefixId.prefix "P60798"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfTrackConfiguration</para>
    ///   <para>rdfs:label : has details of track configuration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60799">rdau:P60799</a>
    /// </summary>
    let P60799 = _prefixId.prefix "P60799"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the method used to encode audio content for playback (e.g., analog or digital).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfTypeOfRecording</para>
    ///   <para>rdfs:label : has details of type of recording</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60800">rdau:P60800</a>
    /// </summary>
    let P60800 = _prefixId.prefix "P60800"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a technical specification relating to the encoding of video images in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfVideoCharacteristic</para>
    ///   <para>rdfs:label : has details of video characteristic</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60801">rdau:P60801</a>
    /// </summary>
    let P60801 = _prefixId.prefix "P60801"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of a standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfVideoFormat</para>
    ///   <para>rdfs:label : has details of video format</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60802">rdau:P60802</a>
    /// </summary>
    let P60802 = _prefixId.prefix "P60802"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfGeneration</para>
    ///   <para>skos:definition : Relates a resource to details of the relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>rdfs:label : has details of generation</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60803">rdau:P60803</a>
    /// </summary>
    let P60803 = _prefixId.prefix "P60803"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of content intended to illustrate the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfIllustrativeContent</para>
    ///   <para>rdfs:label : has details of illustrative content</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60804">rdau:P60804</a>
    /// </summary>
    let P60804 = _prefixId.prefix "P60804"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to the subject of a resource; i.e., an indication of what the resource is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subject</para>
    ///   <para>rdfs:label : has subject</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60805">rdau:P60805</a>
    /// </summary>
    let P60805 = _prefixId.prefix "P60805"
    /// <summary>
    ///   <para>skos:definition : Relates a resource  to a resource that is about the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOf</para>
    ///   <para>rdfs:label : is subject of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60806">rdau:P60806</a>
    /// </summary>
    let P60806 = _prefixId.prefix "P60806"
    /// <summary>
    ///   <para>skos:definition : Relates an agent to an agent who receives an academic degree from the granting institution or faculty.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : graduate</para>
    ///   <para>rdfs:label : has graduate</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60807">rdau:P60807</a>
    /// </summary>
    let P60807 = _prefixId.prefix "P60807"
    /// <summary>
    ///   <para>skos:definition : Relates an agent to an institution or faculty that granted an academic degree to the agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : graduateOf</para>
    ///   <para>rdfs:label : is graduate of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60808">rdau:P60808</a>
    /// </summary>
    let P60808 = _prefixId.prefix "P60808"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by providing a foreword to the original resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfForeword</para>
    ///   <para>rdfs:label : has writer of foreword</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60809">rdau:P60809</a>
    /// </summary>
    let P60809 = _prefixId.prefix "P60809"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by providing a foreword to the original resource to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfForewordOf</para>
    ///   <para>rdfs:label : is writer of foreword of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60810">rdau:P60810</a>
    /// </summary>
    let P60810 = _prefixId.prefix "P60810"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by designing and creating audio/sound components.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundDesigner</para>
    ///   <para>rdfs:label : has sound designer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60811">rdau:P60811</a>
    /// </summary>
    let P60811 = _prefixId.prefix "P60811"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by designing and creating audio/sound components to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundDesignerOf</para>
    ///   <para>rdfs:label : is sound designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60812">rdau:P60812</a>
    /// </summary>
    let P60812 = _prefixId.prefix "P60812"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by designing and creating lighting components.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lightingDesigner</para>
    ///   <para>rdfs:label : has lighting designer</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60813">rdau:P60813</a>
    /// </summary>
    let P60813 = _prefixId.prefix "P60813"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by designing and creating lighting components to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lightingDesignerOf</para>
    ///   <para>rdfs:label : is lighting designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60814">rdau:P60814</a>
    /// </summary>
    let P60814 = _prefixId.prefix "P60814"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent serving on a committee that supervises a student’s thesis or dissertation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeCommitteeMember</para>
    ///   <para>rdfs:label : has degree committee member</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60815">rdau:P60815</a>
    /// </summary>
    let P60815 = _prefixId.prefix "P60815"
    /// <summary>
    ///   <para>skos:definition : Relates an agent serving on a committee that supervises a student’s thesis or dissertation to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeCommitteeMemberOf</para>
    ///   <para>rdfs:label : is degree committee member of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60816">rdau:P60816</a>
    /// </summary>
    let P60816 = _prefixId.prefix "P60816"
    /// <summary>
    ///   <para>skos:definition : Relates an agent responsible for inscribing, fabricating, constructing, etc. to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerOfAnUnpublishedResourceOf</para>
    ///   <para>rdfs:label : is producer of an unpublished resource of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60817">rdau:P60817</a>
    /// </summary>
    let P60817 = _prefixId.prefix "P60817"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has alternative chronological designation of first issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60818">rdau:P60818</a>
    /// </summary>
    let P60818 = _prefixId.prefix "P60818"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has alternative chronological designation of last issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60819">rdau:P60819</a>
    /// </summary>
    let P60819 = _prefixId.prefix "P60819"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a second or subsequent system of numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has alternative numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60820">rdau:P60820</a>
    /// </summary>
    let P60820 = _prefixId.prefix "P60820"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a second or subsequent system of numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : has alternative numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60821">rdau:P60821</a>
    /// </summary>
    let P60821 = _prefixId.prefix "P60821"
    /// <summary>
    ///   <para>skos:definition : Relates a name to the type or form of resource associated with the name chosen as the preferred name for an agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scopeOfUsage</para>
    ///   <para>rdfs:label : has scope of usage</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60822">rdau:P60822</a>
    /// </summary>
    let P60822 = _prefixId.prefix "P60822"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to details of the playing time, running time, performance time, etc., of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : detailsOfDuration</para>
    ///   <para>rdfs:label : has details of duration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60823">rdau:P60823</a>
    /// </summary>
    let P60823 = _prefixId.prefix "P60823"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenParticipant</para>
    ///   <para>rdfs:label : has on-screen participant</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a nonfiction moving image resource by taking an active role as a participant.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60824">rdau:P60824</a>
    /// </summary>
    let P60824 = _prefixId.prefix "P60824"
    /// <summary>
    ///   <para>rdfs:label : is on-screen participant of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenParticipantOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a nonfiction moving image resource by taking an active role as a participant to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60825">rdau:P60825</a>
    /// </summary>
    let P60825 = _prefixId.prefix "P60825"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent responsible for commissioning a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commissioningBody</para>
    ///   <para>rdfs:label : has commissioning body</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60826">rdau:P60826</a>
    /// </summary>
    let P60826 = _prefixId.prefix "P60826"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commissioningBodyOf</para>
    ///   <para>rdfs:label : is commissioning body of</para>
    ///   <para>skos:definition : Relates an agent responsible for commissioning a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60827">rdau:P60827</a>
    /// </summary>
    let P60827 = _prefixId.prefix "P60827"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : softwareDeveloper</para>
    ///   <para>rdfs:label : has software developer</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by researching, designing, implementing, or testing the software.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60828">rdau:P60828</a>
    /// </summary>
    let P60828 = _prefixId.prefix "P60828"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by researching, designing, implementing, or testing the software to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : softwareDeveloperOf</para>
    ///   <para>rdfs:label : is software developer of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60829">rdau:P60829</a>
    /// </summary>
    let P60829 = _prefixId.prefix "P60829"
    /// <summary>
    ///   <para>rdfs:label : is oratorio adaptation of</para>
    ///   <para>skos:definition : Relates a resource to a resource that has been adapted as an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : oratorioAdaptationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60830">rdau:P60830</a>
    /// </summary>
    let P60830 = _prefixId.prefix "P60830"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an oratorio based on the source resource.</para>
    ///   <para>rdfs:label : is adapted as oratorio</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsOratorio</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60831">rdau:P60831</a>
    /// </summary>
    let P60831 = _prefixId.prefix "P60831"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource which serves as the inspiration for another resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inspiredBy</para>
    ///   <para>rdfs:label : is inspired by</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60832">rdau:P60832</a>
    /// </summary>
    let P60832 = _prefixId.prefix "P60832"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource which was inspired by another resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inspirationFor</para>
    ///   <para>rdfs:label : is inspiration for</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60833">rdau:P60833</a>
    /// </summary>
    let P60833 = _prefixId.prefix "P60833"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a government, international intergovernmental body, or other agent that has signed, ratified, or acceded to a treaty.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : participantInATreaty</para>
    ///   <para>rdfs:label : has participant in a treaty</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60834">rdau:P60834</a>
    /// </summary>
    let P60834 = _prefixId.prefix "P60834"
    /// <summary>
    ///   <para>skos:definition : Relates a government, international intergovernmental body, or other agent that has signed, ratified, or acceded to a treaty to the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : participantInATreatyOf</para>
    ///   <para>rdfs:label : is participant in a treaty of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60835">rdau:P60835</a>
    /// </summary>
    let P60835 = _prefixId.prefix "P60835"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent who does research in support of the creation of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : researcher</para>
    ///   <para>rdfs:label : has researcher</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60836">rdau:P60836</a>
    /// </summary>
    let P60836 = _prefixId.prefix "P60836"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : researcherOf</para>
    ///   <para>skos:definition : Relates an agent who does research in support of the creation of a resource to the resource.</para>
    ///   <para>rdfs:label : is researcher of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60837">rdau:P60837</a>
    /// </summary>
    let P60837 = _prefixId.prefix "P60837"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourist</para>
    ///   <para>rdfs:label : has colourist</para>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by applying colour to drawings, prints, photographs, maps, moving images, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60838">rdau:P60838</a>
    /// </summary>
    let P60838 = _prefixId.prefix "P60838"
    /// <summary>
    ///   <para>skos:definition : Relates an agent contributing to a resource by applying colour to drawings, prints, photographs, maps, moving images, etc. to the resource.</para>
    ///   <para>rdfs:label : is colourist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colouristOf</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60839">rdau:P60839</a>
    /// </summary>
    let P60839 = _prefixId.prefix "P60839"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to an agent contributing to a resource by applying make-up and prosthetics for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <para>rdfs:label : has make-up artist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : makeUpArtist</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60840">rdau:P60840</a>
    /// </summary>
    let P60840 = _prefixId.prefix "P60840"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : makeUpArtistOf</para>
    ///   <para>skos:definition : Relates an agent contributing to a resource by applying make-up and prosthetics for a moving image production or for a musical or dramatic presentation or entertainment to the resource.</para>
    ///   <para>rdfs:label : is make-up artist of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60841">rdau:P60841</a>
    /// </summary>
    let P60841 = _prefixId.prefix "P60841"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a conductor contributing to a musical resource by leading a choral performing group in a musical or dramatic presentation, etc.</para>
    ///   <para>rdfs:label : has choral conductor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choralConductor</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60842">rdau:P60842</a>
    /// </summary>
    let P60842 = _prefixId.prefix "P60842"
    /// <summary>
    ///   <para>rdfs:label : is choral conductor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choralConductorOf</para>
    ///   <para>skos:definition : Relates a conductor contributing to a musical resource by leading a choral performing group in a musical or dramatic presentation, etc. to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60843">rdau:P60843</a>
    /// </summary>
    let P60843 = _prefixId.prefix "P60843"
    /// <summary>
    ///   <para>rdfs:label : has instrumental conductor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalConductor</para>
    ///   <para>skos:definition : Relates a resource to a conductor contributing to a musical resource by leading an instrumental performing group in a musical or dramatic presentation, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60844">rdau:P60844</a>
    /// </summary>
    let P60844 = _prefixId.prefix "P60844"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalConductorOf</para>
    ///   <para>skos:definition : Relates a conductor contributing to a musical resource by leading an instrumental performing group in a musical or dramatic presentation, etc. to the resource</para>
    ///   <para>rdfs:label : is instrumental conductor of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60845">rdau:P60845</a>
    /// </summary>
    let P60845 = _prefixId.prefix "P60845"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource commemorated by the other resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commemoration</para>
    ///   <para>rdfs:label : has commemoration</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60846">rdau:P60846</a>
    /// </summary>
    let P60846 = _prefixId.prefix "P60846"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource created to commemorate the other resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commemorationOf</para>
    ///   <para>rdfs:label : is commemoration of</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60847">rdau:P60847</a>
    /// </summary>
    let P60847 = _prefixId.prefix "P60847"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a resource that references the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : referentialResourceRelationship</para>
    ///   <para>rdfs:label : has referential resource relationship with</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60848">rdau:P60848</a>
    /// </summary>
    let P60848 = _prefixId.prefix "P60848"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : organizer</para>
    ///   <para>rdfs:label : has organizer</para>
    ///   <para>skos:definition : Relates a resource to an agent organizing the exhibit, event, conference, etc., which gave rise to a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60849">rdau:P60849</a>
    /// </summary>
    let P60849 = _prefixId.prefix "P60849"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : organizerOf</para>
    ///   <para>rdfs:label : is organizer of</para>
    ///   <para>skos:definition : Relates an agent organizing the exhibit, event, conference, etc., which gave rise to a resource to the resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/u/P60850">rdau:P60850</a>
    /// </summary>
    let P60850 = _prefixId.prefix "P60850"
    let ``abbreviatedTitle.en`` = _prefixId.prefix "abbreviatedTitle.en"
    let ``abridgedAs.en`` = _prefixId.prefix "abridgedAs.en"
    let ``abridgementOf.en`` = _prefixId.prefix "abridgementOf.en"
    let ``abridger.en`` = _prefixId.prefix "abridger.en"
    let ``abridgerOf.en`` = _prefixId.prefix "abridgerOf.en"
    let ``absorbedBy.en`` = _prefixId.prefix "absorbedBy.en"
    let ``absorbedInPartBy.en`` = _prefixId.prefix "absorbedInPartBy.en"
    let ``absorptionInPartOf.en`` = _prefixId.prefix "absorptionInPartOf.en"
    let ``absorptionOf.en`` = _prefixId.prefix "absorptionOf.en"
    let ``abstractOf.en`` = _prefixId.prefix "abstractOf.en"
    let ``abstractedAs.en`` = _prefixId.prefix "abstractedAs.en"
    let ``abstractedIn.en`` = _prefixId.prefix "abstractedIn.en"
    let ``abstractsFor.en`` = _prefixId.prefix "abstractsFor.en"
    let ``academicDegree.en`` = _prefixId.prefix "academicDegree.en"
    let ``accessibilityContent.en`` = _prefixId.prefix "accessibilityContent.en"
    let ``accompaniedBy.en`` = _prefixId.prefix "accompaniedBy.en"

    let ``accompanyingResourceRelationshipWith.en`` =
        _prefixId.prefix "accompanyingResourceRelationshipWith.en"

    let ``actor.en`` = _prefixId.prefix "actor.en"
    let ``actorOf.en`` = _prefixId.prefix "actorOf.en"
    let ``adaptationOf.en`` = _prefixId.prefix "adaptationOf.en"
    let ``adaptedAs.en`` = _prefixId.prefix "adaptedAs.en"
    let ``adaptedAsAMotionPicture.en`` = _prefixId.prefix "adaptedAsAMotionPicture.en"

    let ``adaptedAsAMotionPictureScreenplay.en`` =
        _prefixId.prefix "adaptedAsAMotionPictureScreenplay.en"

    let ``adaptedAsARadioProgram.en`` = _prefixId.prefix "adaptedAsARadioProgram.en"
    let ``adaptedAsARadioScript.en`` = _prefixId.prefix "adaptedAsARadioScript.en"
    let ``adaptedAsAScreenplay.en`` = _prefixId.prefix "adaptedAsAScreenplay.en"

    let ``adaptedAsATelevisionProgram.en`` =
        _prefixId.prefix "adaptedAsATelevisionProgram.en"

    let ``adaptedAsATelevisionScreenplay.en`` =
        _prefixId.prefix "adaptedAsATelevisionScreenplay.en"

    let ``adaptedAsAVideo.en`` = _prefixId.prefix "adaptedAsAVideo.en"

    let ``adaptedAsAVideoScreenplay.en`` =
        _prefixId.prefix "adaptedAsAVideoScreenplay.en"

    let ``adaptedAsChoreography.en`` = _prefixId.prefix "adaptedAsChoreography.en"
    let ``adaptedAsGraphicNovel.en`` = _prefixId.prefix "adaptedAsGraphicNovel.en"
    let ``adaptedAsLibretto.en`` = _prefixId.prefix "adaptedAsLibretto.en"
    let ``adaptedAsMusicalTheatre.en`` = _prefixId.prefix "adaptedAsMusicalTheatre.en"
    let ``adaptedAsNovel.en`` = _prefixId.prefix "adaptedAsNovel.en"
    let ``adaptedAsOpera.en`` = _prefixId.prefix "adaptedAsOpera.en"
    let ``adaptedAsOratorio.en`` = _prefixId.prefix "adaptedAsOratorio.en"
    let ``adaptedAsVideoGame.en`` = _prefixId.prefix "adaptedAsVideoGame.en"
    let ``adaptedInVerseAs.en`` = _prefixId.prefix "adaptedInVerseAs.en"
    let ``addenda.en`` = _prefixId.prefix "addenda.en"
    let ``addendaTo.en`` = _prefixId.prefix "addendaTo.en"

    let ``additionalScaleInformation.en`` =
        _prefixId.prefix "additionalScaleInformation.en"

    let ``addressOfTheAgent.en`` = _prefixId.prefix "addressOfTheAgent.en"
    let ``addressee.en`` = _prefixId.prefix "addressee.en"
    let ``addresseeOf.en`` = _prefixId.prefix "addresseeOf.en"
    let ``affiliation.en`` = _prefixId.prefix "affiliation.en"
    let ``agentHistory.en`` = _prefixId.prefix "agentHistory.en"
    let ``alsoIssuedAs.en`` = _prefixId.prefix "alsoIssuedAs.en"
    let ``alternateIdentity.en`` = _prefixId.prefix "alternateIdentity.en"

    let ``alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en`` =
        _prefixId.prefix "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en"

    let ``alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en`` =
        _prefixId.prefix "alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en"

    let ``alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en`` =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en"

    let ``alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en`` =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en"

    let ``analysedIn.en`` = _prefixId.prefix "analysedIn.en"
    let ``analysisOf.en`` = _prefixId.prefix "analysisOf.en"
    let ``animator.en`` = _prefixId.prefix "animator.en"
    let ``animatorOf.en`` = _prefixId.prefix "animatorOf.en"
    let ``annotator.en`` = _prefixId.prefix "annotator.en"
    let ``annotatorOf.en`` = _prefixId.prefix "annotatorOf.en"
    let ``appellant.en`` = _prefixId.prefix "appellant.en"
    let ``appellantOf.en`` = _prefixId.prefix "appellantOf.en"
    let ``appellee.en`` = _prefixId.prefix "appellee.en"
    let ``appelleeOf.en`` = _prefixId.prefix "appelleeOf.en"
    let ``appendix.en`` = _prefixId.prefix "appendix.en"
    let ``appendixTo.en`` = _prefixId.prefix "appendixTo.en"
    let ``appliedMaterial.en`` = _prefixId.prefix "appliedMaterial.en"
    let ``architect.en`` = _prefixId.prefix "architect.en"
    let ``architectOf.en`` = _prefixId.prefix "architectOf.en"
    let ``arrangedAs.en`` = _prefixId.prefix "arrangedAs.en"
    let ``arrangementOf.en`` = _prefixId.prefix "arrangementOf.en"
    let ``arrangerOfMusic.en`` = _prefixId.prefix "arrangerOfMusic.en"
    let ``arrangerOfMusicOf.en`` = _prefixId.prefix "arrangerOfMusicOf.en"
    let ``artDirector.en`` = _prefixId.prefix "artDirector.en"
    let ``artDirectorOf.en`` = _prefixId.prefix "artDirectorOf.en"
    let ``artist.en`` = _prefixId.prefix "artist.en"
    let ``artistOf.en`` = _prefixId.prefix "artistOf.en"
    let ``aspectRatio.en`` = _prefixId.prefix "aspectRatio.en"
    let ``associatedInstitution.en`` = _prefixId.prefix "associatedInstitution.en"
    let ``augmentationOf.en`` = _prefixId.prefix "augmentationOf.en"
    let ``augmentedBy.en`` = _prefixId.prefix "augmentedBy.en"
    let ``author.en`` = _prefixId.prefix "author.en"
    let ``authorOf.en`` = _prefixId.prefix "authorOf.en"
    let ``autographer.en`` = _prefixId.prefix "autographer.en"
    let ``autographerOf.en`` = _prefixId.prefix "autographerOf.en"
    let ``award.en`` = _prefixId.prefix "award.en"
    let ``baseMaterial.en`` = _prefixId.prefix "baseMaterial.en"
    let ``basedOn.en`` = _prefixId.prefix "basedOn.en"
    let ``binder.en`` = _prefixId.prefix "binder.en"
    let ``binderOf.en`` = _prefixId.prefix "binderOf.en"
    let ``biographicalInformation.en`` = _prefixId.prefix "biographicalInformation.en"
    let ``bookArtist.en`` = _prefixId.prefix "bookArtist.en"
    let ``bookArtistOf.en`` = _prefixId.prefix "bookArtistOf.en"
    let ``bookDesigner.en`` = _prefixId.prefix "bookDesigner.en"
    let ``bookDesignerOf.en`` = _prefixId.prefix "bookDesignerOf.en"
    let ``bookFormat.en`` = _prefixId.prefix "bookFormat.en"
    let ``boundWith.en`` = _prefixId.prefix "boundWith.en"
    let ``brailleEmbosser.en`` = _prefixId.prefix "brailleEmbosser.en"
    let ``brailleEmbosserOf.en`` = _prefixId.prefix "brailleEmbosserOf.en"
    let ``broadcastStandard.en`` = _prefixId.prefix "broadcastStandard.en"
    let ``broadcaster.en`` = _prefixId.prefix "broadcaster.en"
    let ``broadcasterOf.en`` = _prefixId.prefix "broadcasterOf.en"
    let ``broaderAffiliatedAgent.en`` = _prefixId.prefix "broaderAffiliatedAgent.en"
    let ``cadenza.en`` = _prefixId.prefix "cadenza.en"
    let ``cadenzaComposedFor.en`` = _prefixId.prefix "cadenzaComposedFor.en"
    let ``calligrapher.en`` = _prefixId.prefix "calligrapher.en"
    let ``calligrapherOf.en`` = _prefixId.prefix "calligrapherOf.en"
    let ``carrierType.en`` = _prefixId.prefix "carrierType.en"
    let ``cartographer.en`` = _prefixId.prefix "cartographer.en"
    let ``cartographerOf.en`` = _prefixId.prefix "cartographerOf.en"
    let ``caster.en`` = _prefixId.prefix "caster.en"
    let ``casterOf.en`` = _prefixId.prefix "casterOf.en"
    let ``catalogue.en`` = _prefixId.prefix "catalogue.en"
    let ``catalogueOf.en`` = _prefixId.prefix "catalogueOf.en"
    let ``choralConductor.en`` = _prefixId.prefix "choralConductor.en"
    let ``choralConductorOf.en`` = _prefixId.prefix "choralConductorOf.en"
    let ``choreographer.en`` = _prefixId.prefix "choreographer.en"
    let ``choreographerOf.en`` = _prefixId.prefix "choreographerOf.en"

    let ``choreographicAdaptationOf.en`` =
        _prefixId.prefix "choreographicAdaptationOf.en"

    let ``choreography.en`` = _prefixId.prefix "choreography.en"
    let ``choreographyFor.en`` = _prefixId.prefix "choreographyFor.en"

    let ``chronologicalDesignationOfFirstIssueOrPartOfSequence.en`` =
        _prefixId.prefix "chronologicalDesignationOfFirstIssueOrPartOfSequence.en"

    let ``chronologicalDesignationOfLastIssueOrPartOfSequence.en`` =
        _prefixId.prefix "chronologicalDesignationOfLastIssueOrPartOfSequence.en"

    let ``collectionRegistrar.en`` = _prefixId.prefix "collectionRegistrar.en"
    let ``collectionRegistrarOf.en`` = _prefixId.prefix "collectionRegistrarOf.en"
    let ``collector.en`` = _prefixId.prefix "collector.en"
    let ``collectorOf.en`` = _prefixId.prefix "collectorOf.en"
    let ``collotyper.en`` = _prefixId.prefix "collotyper.en"
    let ``collotyperOf.en`` = _prefixId.prefix "collotyperOf.en"
    let ``colourContent.en`` = _prefixId.prefix "colourContent.en"
    let ``colourist.en`` = _prefixId.prefix "colourist.en"
    let ``colouristOf.en`` = _prefixId.prefix "colouristOf.en"
    let ``commemoration.en`` = _prefixId.prefix "commemoration.en"
    let ``commemorationOf.en`` = _prefixId.prefix "commemorationOf.en"
    let ``commentaryIn.en`` = _prefixId.prefix "commentaryIn.en"
    let ``commentaryOn.en`` = _prefixId.prefix "commentaryOn.en"
    let ``commentator.en`` = _prefixId.prefix "commentator.en"
    let ``commentatorOf.en`` = _prefixId.prefix "commentatorOf.en"
    let ``commissioningBody.en`` = _prefixId.prefix "commissioningBody.en"
    let ``commissioningBodyOf.en`` = _prefixId.prefix "commissioningBodyOf.en"
    let ``compiler.en`` = _prefixId.prefix "compiler.en"
    let ``compilerOf.en`` = _prefixId.prefix "compilerOf.en"
    let ``complementedBy.en`` = _prefixId.prefix "complementedBy.en"
    let ``componentOfAMerger.en`` = _prefixId.prefix "componentOfAMerger.en"
    let ``composer.en`` = _prefixId.prefix "composer.en"
    let ``composerOf.en`` = _prefixId.prefix "composerOf.en"
    let ``concordance.en`` = _prefixId.prefix "concordance.en"
    let ``concordanceTo.en`` = _prefixId.prefix "concordanceTo.en"
    let ``conductor.en`` = _prefixId.prefix "conductor.en"
    let ``conductorOf.en`` = _prefixId.prefix "conductorOf.en"

    let ``configurationOfPlaybackChannels.en`` =
        _prefixId.prefix "configurationOfPlaybackChannels.en"

    let ``consultant.en`` = _prefixId.prefix "consultant.en"
    let ``consultantOf.en`` = _prefixId.prefix "consultantOf.en"
    let ``contactInformation.en`` = _prefixId.prefix "contactInformation.en"
    let ``containedIn.en`` = _prefixId.prefix "containedIn.en"
    let ``containerOf.en`` = _prefixId.prefix "containerOf.en"
    let ``contentType.en`` = _prefixId.prefix "contentType.en"
    let ``continuationInPartOf.en`` = _prefixId.prefix "continuationInPartOf.en"
    let ``continuationOf.en`` = _prefixId.prefix "continuationOf.en"
    let ``continuedBy.en`` = _prefixId.prefix "continuedBy.en"
    let ``continuedInPartBy.en`` = _prefixId.prefix "continuedInPartBy.en"
    let ``contributor.en`` = _prefixId.prefix "contributor.en"
    let ``contributorOf.en`` = _prefixId.prefix "contributorOf.en"

    let ``coordinatesOfCartographicContent.en`` =
        _prefixId.prefix "coordinatesOfCartographicContent.en"

    let ``copyrightDate.en`` = _prefixId.prefix "copyrightDate.en"
    let ``costumeDesigner.en`` = _prefixId.prefix "costumeDesigner.en"
    let ``costumeDesignerOf.en`` = _prefixId.prefix "costumeDesignerOf.en"

    let ``countryAssociatedWithThePerson.en`` =
        _prefixId.prefix "countryAssociatedWithThePerson.en"

    let ``courtGoverned.en`` = _prefixId.prefix "courtGoverned.en"
    let ``courtGovernedOf.en`` = _prefixId.prefix "courtGovernedOf.en"
    let ``courtReporter.en`` = _prefixId.prefix "courtReporter.en"
    let ``courtReporterOf.en`` = _prefixId.prefix "courtReporterOf.en"
    let ``coverageOfTheContent.en`` = _prefixId.prefix "coverageOfTheContent.en"
    let ``creator.en`` = _prefixId.prefix "creator.en"
    let ``creatorOf.en`` = _prefixId.prefix "creatorOf.en"
    let ``critiqueOf.en`` = _prefixId.prefix "critiqueOf.en"
    let ``critiquedIn.en`` = _prefixId.prefix "critiquedIn.en"
    let ``curator.en`` = _prefixId.prefix "curator.en"
    let ``curatorOf.en`` = _prefixId.prefix "curatorOf.en"
    let ``currentOwner.en`` = _prefixId.prefix "currentOwner.en"
    let ``currentOwnerOf.en`` = _prefixId.prefix "currentOwnerOf.en"

    let ``custodialHistoryOfResource.en`` =
        _prefixId.prefix "custodialHistoryOfResource.en"

    let ``custodian.en`` = _prefixId.prefix "custodian.en"
    let ``custodianOf.en`` = _prefixId.prefix "custodianOf.en"
    let ``dancer.en`` = _prefixId.prefix "dancer.en"
    let ``dancerOf.en`` = _prefixId.prefix "dancerOf.en"

    let ``dateAssociatedWithTheAgent.en`` =
        _prefixId.prefix "dateAssociatedWithTheAgent.en"

    let ``dateOfBirth.en`` = _prefixId.prefix "dateOfBirth.en"
    let ``dateOfCapture.en`` = _prefixId.prefix "dateOfCapture.en"
    let ``dateOfConferenceEtc.en`` = _prefixId.prefix "dateOfConferenceEtc.en"
    let ``dateOfDeath.en`` = _prefixId.prefix "dateOfDeath.en"
    let ``dateOfDistribution.en`` = _prefixId.prefix "dateOfDistribution.en"
    let ``dateOfEstablishment.en`` = _prefixId.prefix "dateOfEstablishment.en"
    let ``dateOfManufacture.en`` = _prefixId.prefix "dateOfManufacture.en"
    let ``dateOfProduction.en`` = _prefixId.prefix "dateOfProduction.en"
    let ``dateOfPublication.en`` = _prefixId.prefix "dateOfPublication.en"
    let ``dateOfResource.en`` = _prefixId.prefix "dateOfResource.en"
    let ``dateOfTermination.en`` = _prefixId.prefix "dateOfTermination.en"
    let ``dateOfUsage.en`` = _prefixId.prefix "dateOfUsage.en"
    let ``dedicatee.en`` = _prefixId.prefix "dedicatee.en"
    let ``dedicateeOf.en`` = _prefixId.prefix "dedicateeOf.en"
    let ``dedicator.en`` = _prefixId.prefix "dedicator.en"
    let ``dedicatorOf.en`` = _prefixId.prefix "dedicatorOf.en"
    let ``defendant.en`` = _prefixId.prefix "defendant.en"
    let ``defendantOf.en`` = _prefixId.prefix "defendantOf.en"
    let ``degreeCommitteeMember.en`` = _prefixId.prefix "degreeCommitteeMember.en"
    let ``degreeCommitteeMemberOf.en`` = _prefixId.prefix "degreeCommitteeMemberOf.en"

    let ``degreeGrantingInstitution.en`` =
        _prefixId.prefix "degreeGrantingInstitution.en"

    let ``degreeGrantingInstitutionOf.en`` =
        _prefixId.prefix "degreeGrantingInstitutionOf.en"

    let ``degreeSupervisor.en`` = _prefixId.prefix "degreeSupervisor.en"
    let ``degreeSupervisorOf.en`` = _prefixId.prefix "degreeSupervisorOf.en"
    let ``depositor.en`` = _prefixId.prefix "depositor.en"
    let ``depositorOf.en`` = _prefixId.prefix "depositorOf.en"
    let ``derivative.en`` = _prefixId.prefix "derivative.en"

    let ``derivativeResourceRelationshipWith.en`` =
        _prefixId.prefix "derivativeResourceRelationshipWith.en"

    let ``describedIn.en`` = _prefixId.prefix "describedIn.en"
    let ``descriptionOf.en`` = _prefixId.prefix "descriptionOf.en"

    let ``designationOfANamedRevisionOfAnEdition.en`` =
        _prefixId.prefix "designationOfANamedRevisionOfAnEdition.en"

    let ``designationOfEdition.en`` = _prefixId.prefix "designationOfEdition.en"
    let ``designer.en`` = _prefixId.prefix "designer.en"
    let ``designerOf.en`` = _prefixId.prefix "designerOf.en"
    let ``detailsOfAppliedMaterial.en`` = _prefixId.prefix "detailsOfAppliedMaterial.en"
    let ``detailsOfAspectRatio.en`` = _prefixId.prefix "detailsOfAspectRatio.en"
    let ``detailsOfBaseMaterial.en`` = _prefixId.prefix "detailsOfBaseMaterial.en"
    let ``detailsOfBookFormat.en`` = _prefixId.prefix "detailsOfBookFormat.en"

    let ``detailsOfBroadcastStandard.en`` =
        _prefixId.prefix "detailsOfBroadcastStandard.en"

    let ``detailsOfColourContent.en`` = _prefixId.prefix "detailsOfColourContent.en"

    let ``detailsOfConfigurationOfPlaybackChannels.en`` =
        _prefixId.prefix "detailsOfConfigurationOfPlaybackChannels.en"

    let ``detailsOfDigitalFileCharacteristic.en`` =
        _prefixId.prefix "detailsOfDigitalFileCharacteristic.en"

    let ``detailsOfDigitalRepresentationOfCartographicContent.en`` =
        _prefixId.prefix "detailsOfDigitalRepresentationOfCartographicContent.en"

    let ``detailsOfDuration.en`` = _prefixId.prefix "detailsOfDuration.en"

    let ``detailsOfEmulsionOnMicrofilmAndMicrofiche.en`` =
        _prefixId.prefix "detailsOfEmulsionOnMicrofilmAndMicrofiche.en"

    let ``detailsOfEncodingFormat.en`` = _prefixId.prefix "detailsOfEncodingFormat.en"
    let ``detailsOfFileType.en`` = _prefixId.prefix "detailsOfFileType.en"
    let ``detailsOfFontSize.en`` = _prefixId.prefix "detailsOfFontSize.en"

    let ``detailsOfFormOfMusicalNotation.en`` =
        _prefixId.prefix "detailsOfFormOfMusicalNotation.en"

    let ``detailsOfFormOfNotatedMovement.en`` =
        _prefixId.prefix "detailsOfFormOfNotatedMovement.en"

    let ``detailsOfFormOfTactileNotation.en`` =
        _prefixId.prefix "detailsOfFormOfTactileNotation.en"

    let ``detailsOfFormatOfNotatedMusic.en`` =
        _prefixId.prefix "detailsOfFormatOfNotatedMusic.en"

    let ``detailsOfGeneration.en`` = _prefixId.prefix "detailsOfGeneration.en"

    let ``detailsOfGenerationOfAudioRecording.en`` =
        _prefixId.prefix "detailsOfGenerationOfAudioRecording.en"

    let ``detailsOfGenerationOfDigitalResource.en`` =
        _prefixId.prefix "detailsOfGenerationOfDigitalResource.en"

    let ``detailsOfGenerationOfMicroform.en`` =
        _prefixId.prefix "detailsOfGenerationOfMicroform.en"

    let ``detailsOfGenerationOfMotionPictureFilm.en`` =
        _prefixId.prefix "detailsOfGenerationOfMotionPictureFilm.en"

    let ``detailsOfGenerationOfVideotape.en`` =
        _prefixId.prefix "detailsOfGenerationOfVideotape.en"

    let ``detailsOfGrooveCharacteristic.en`` =
        _prefixId.prefix "detailsOfGrooveCharacteristic.en"

    let ``detailsOfIllustrativeContent.en`` =
        _prefixId.prefix "detailsOfIllustrativeContent.en"

    let ``detailsOfLayout.en`` = _prefixId.prefix "detailsOfLayout.en"
    let ``detailsOfMount.en`` = _prefixId.prefix "detailsOfMount.en"
    let ``detailsOfPlayingSpeed.en`` = _prefixId.prefix "detailsOfPlayingSpeed.en"
    let ``detailsOfPolarity.en`` = _prefixId.prefix "detailsOfPolarity.en"

    let ``detailsOfPresentationFormat.en`` =
        _prefixId.prefix "detailsOfPresentationFormat.en"

    let ``detailsOfProductionMethod.en`` =
        _prefixId.prefix "detailsOfProductionMethod.en"

    let ``detailsOfProductionMethodForManuscript.en`` =
        _prefixId.prefix "detailsOfProductionMethodForManuscript.en"

    let ``detailsOfProductionMethodForTactileResource.en`` =
        _prefixId.prefix "detailsOfProductionMethodForTactileResource.en"

    let ``detailsOfProjectionCharacteristicOfMotionPictureFilm.en`` =
        _prefixId.prefix "detailsOfProjectionCharacteristicOfMotionPictureFilm.en"

    let ``detailsOfProjectionSpeed.en`` = _prefixId.prefix "detailsOfProjectionSpeed.en"
    let ``detailsOfRecordingMedium.en`` = _prefixId.prefix "detailsOfRecordingMedium.en"
    let ``detailsOfReductionRatio.en`` = _prefixId.prefix "detailsOfReductionRatio.en"
    let ``detailsOfScript.en`` = _prefixId.prefix "detailsOfScript.en"

    let ``detailsOfSoundCharacteristic.en`` =
        _prefixId.prefix "detailsOfSoundCharacteristic.en"

    let ``detailsOfSpecialPlaybackCharacteristic.en`` =
        _prefixId.prefix "detailsOfSpecialPlaybackCharacteristic.en"

    let ``detailsOfTapeConfiguration.en`` =
        _prefixId.prefix "detailsOfTapeConfiguration.en"

    let ``detailsOfTrackConfiguration.en`` =
        _prefixId.prefix "detailsOfTrackConfiguration.en"

    let ``detailsOfTypeOfRecording.en`` = _prefixId.prefix "detailsOfTypeOfRecording.en"

    let ``detailsOfVideoCharacteristic.en`` =
        _prefixId.prefix "detailsOfVideoCharacteristic.en"

    let ``detailsOfVideoFormat.en`` = _prefixId.prefix "detailsOfVideoFormat.en"
    let ``digestOf.en`` = _prefixId.prefix "digestOf.en"
    let ``digestedAs.en`` = _prefixId.prefix "digestedAs.en"

    let ``digitalFileCharacteristic.en`` =
        _prefixId.prefix "digitalFileCharacteristic.en"

    let ``digitalRepresentationOfCartographicContent.en`` =
        _prefixId.prefix "digitalRepresentationOfCartographicContent.en"

    let ``digitalTransfer.en`` = _prefixId.prefix "digitalTransfer.en"
    let ``digitalTransferOf.en`` = _prefixId.prefix "digitalTransferOf.en"
    let ``dimensions.en`` = _prefixId.prefix "dimensions.en"
    let ``dimensionsOfMapEtc.en`` = _prefixId.prefix "dimensionsOfMapEtc.en"
    let ``dimensionsOfStillImage.en`` = _prefixId.prefix "dimensionsOfStillImage.en"
    let ``director.en`` = _prefixId.prefix "director.en"
    let ``directorOf.en`` = _prefixId.prefix "directorOf.en"
    let ``directorOfPhotography.en`` = _prefixId.prefix "directorOfPhotography.en"
    let ``directorOfPhotographyOf.en`` = _prefixId.prefix "directorOfPhotographyOf.en"

    let ``dissertationOrThesisInformation.en`` =
        _prefixId.prefix "dissertationOrThesisInformation.en"

    let ``distributionStatement.en`` = _prefixId.prefix "distributionStatement.en"
    let ``distributor.en`` = _prefixId.prefix "distributor.en"
    let ``distributorOf.en`` = _prefixId.prefix "distributorOf.en"
    let ``distributorsName.en`` = _prefixId.prefix "distributorsName.en"
    let ``donor.en`` = _prefixId.prefix "donor.en"
    let ``donorOf.en`` = _prefixId.prefix "donorOf.en"
    let ``draftsman.en`` = _prefixId.prefix "draftsman.en"
    let ``draftsmanOf.en`` = _prefixId.prefix "draftsmanOf.en"
    let ``dramatizationOf.en`` = _prefixId.prefix "dramatizationOf.en"
    let ``dramatizedAs.en`` = _prefixId.prefix "dramatizedAs.en"
    let ``dubbedVersion.en`` = _prefixId.prefix "dubbedVersion.en"
    let ``dubbedVersionOf.en`` = _prefixId.prefix "dubbedVersionOf.en"
    let ``duration.en`` = _prefixId.prefix "duration.en"
    let ``earlierTitleProper.en`` = _prefixId.prefix "earlierTitleProper.en"
    let ``editionStatement.en`` = _prefixId.prefix "editionStatement.en"
    let ``editor.en`` = _prefixId.prefix "editor.en"
    let ``editorOf.en`` = _prefixId.prefix "editorOf.en"

    let ``editorOfMovingImageResource.en`` =
        _prefixId.prefix "editorOfMovingImageResource.en"

    let ``editorOfMovingImageResourceOf.en`` =
        _prefixId.prefix "editorOfMovingImageResourceOf.en"

    let ``electronicReproduction.en`` = _prefixId.prefix "electronicReproduction.en"
    let ``electronicReproductionOf.en`` = _prefixId.prefix "electronicReproductionOf.en"
    let ``employee.en`` = _prefixId.prefix "employee.en"
    let ``employer.en`` = _prefixId.prefix "employer.en"

    let ``emulsionOnMicrofilmAndMicrofiche.en`` =
        _prefixId.prefix "emulsionOnMicrofilmAndMicrofiche.en"

    let ``enactingJurisdiction.en`` = _prefixId.prefix "enactingJurisdiction.en"
    let ``enactingJurisdictionOf.en`` = _prefixId.prefix "enactingJurisdictionOf.en"
    let ``encodedBitrate.en`` = _prefixId.prefix "encodedBitrate.en"
    let ``encodingFormat.en`` = _prefixId.prefix "encodingFormat.en"
    let ``engraver.en`` = _prefixId.prefix "engraver.en"
    let ``engraverOf.en`` = _prefixId.prefix "engraverOf.en"
    let ``epoch.en`` = _prefixId.prefix "epoch.en"
    let ``equinox.en`` = _prefixId.prefix "equinox.en"

    let ``equipmentOrSystemRequirement.en`` =
        _prefixId.prefix "equipmentOrSystemRequirement.en"

    let ``equivalent.en`` = _prefixId.prefix "equivalent.en"

    let ``equivalentResourceRelationshipWith.en`` =
        _prefixId.prefix "equivalentResourceRelationshipWith.en"

    let ``errata.en`` = _prefixId.prefix "errata.en"
    let ``errataTo.en`` = _prefixId.prefix "errataTo.en"
    let ``etcher.en`` = _prefixId.prefix "etcher.en"
    let ``etcherOf.en`` = _prefixId.prefix "etcherOf.en"
    let ``evaluatedIn.en`` = _prefixId.prefix "evaluatedIn.en"
    let ``evaluationOf.en`` = _prefixId.prefix "evaluationOf.en"
    let ``expandedAs.en`` = _prefixId.prefix "expandedAs.en"
    let ``expandedVersionOf.en`` = _prefixId.prefix "expandedVersionOf.en"
    let ``extent.en`` = _prefixId.prefix "extent.en"
    let ``facsimile.en`` = _prefixId.prefix "facsimile.en"
    let ``facsimileContainedIn.en`` = _prefixId.prefix "facsimileContainedIn.en"
    let ``facsimileContainerOf.en`` = _prefixId.prefix "facsimileContainerOf.en"
    let ``facsimileOf.en`` = _prefixId.prefix "facsimileOf.en"
    let ``fieldOfActivity.en`` = _prefixId.prefix "fieldOfActivity.en"
    let ``fileSize.en`` = _prefixId.prefix "fileSize.en"
    let ``fileType.en`` = _prefixId.prefix "fileType.en"
    let ``filmDirector.en`` = _prefixId.prefix "filmDirector.en"
    let ``filmDirectorOf.en`` = _prefixId.prefix "filmDirectorOf.en"
    let ``filmDistributor.en`` = _prefixId.prefix "filmDistributor.en"
    let ``filmDistributorOf.en`` = _prefixId.prefix "filmDistributorOf.en"
    let ``filmProducer.en`` = _prefixId.prefix "filmProducer.en"
    let ``filmProducerOf.en`` = _prefixId.prefix "filmProducerOf.en"
    let ``filmedWith.en`` = _prefixId.prefix "filmedWith.en"
    let ``filmmaker.en`` = _prefixId.prefix "filmmaker.en"
    let ``filmmakerOf.en`` = _prefixId.prefix "filmmakerOf.en"
    let ``findingAid.en`` = _prefixId.prefix "findingAid.en"
    let ``findingAidFor.en`` = _prefixId.prefix "findingAidFor.en"
    let ``fontSize.en`` = _prefixId.prefix "fontSize.en"
    let ``formOfMusicalNotation.en`` = _prefixId.prefix "formOfMusicalNotation.en"
    let ``formOfNotatedMovement.en`` = _prefixId.prefix "formOfNotatedMovement.en"
    let ``formOfNotation.en`` = _prefixId.prefix "formOfNotation.en"
    let ``formOfResource.en`` = _prefixId.prefix "formOfResource.en"
    let ``formOfTactileNotation.en`` = _prefixId.prefix "formOfTactileNotation.en"
    let ``formatOfNotatedMusic.en`` = _prefixId.prefix "formatOfNotatedMusic.en"
    let ``formerOwner.en`` = _prefixId.prefix "formerOwner.en"
    let ``formerOwnerOf.en`` = _prefixId.prefix "formerOwnerOf.en"
    let ``foundedEntity.en`` = _prefixId.prefix "foundedEntity.en"
    let ``founder.en`` = _prefixId.prefix "founder.en"
    let ``freeTranslationOf.en`` = _prefixId.prefix "freeTranslationOf.en"
    let ``freelyTranslatedAs.en`` = _prefixId.prefix "freelyTranslatedAs.en"
    let ``frequency.en`` = _prefixId.prefix "frequency.en"
    let ``fullerFormOfName.en`` = _prefixId.prefix "fullerFormOfName.en"
    let ``gender.en`` = _prefixId.prefix "gender.en"
    let ``generation.en`` = _prefixId.prefix "generation.en"

    let ``generationOfAudioRecording.en`` =
        _prefixId.prefix "generationOfAudioRecording.en"

    let ``generationOfDigitalResource.en`` =
        _prefixId.prefix "generationOfDigitalResource.en"

    let ``generationOfMicroform.en`` = _prefixId.prefix "generationOfMicroform.en"

    let ``generationOfMotionPictureFilm.en`` =
        _prefixId.prefix "generationOfMotionPictureFilm.en"

    let ``generationOfVideotape.en`` = _prefixId.prefix "generationOfVideotape.en"
    let ``graduate.en`` = _prefixId.prefix "graduate.en"
    let ``graduateOf.en`` = _prefixId.prefix "graduateOf.en"

    let ``grantingInstitutionOrFaculty.en`` =
        _prefixId.prefix "grantingInstitutionOrFaculty.en"

    let ``graphicNovelizationOf.en`` = _prefixId.prefix "graphicNovelizationOf.en"
    let ``grooveCharacteristic.en`` = _prefixId.prefix "grooveCharacteristic.en"
    let ``guide.en`` = _prefixId.prefix "guide.en"
    let ``guideTo.en`` = _prefixId.prefix "guideTo.en"
    let ``hereditaryTitle.en`` = _prefixId.prefix "hereditaryTitle.en"
    let ``hierarchicalSubordinate.en`` = _prefixId.prefix "hierarchicalSubordinate.en"
    let ``hierarchicalSuperior.en`` = _prefixId.prefix "hierarchicalSuperior.en"
    let ``historyOfTheResource.en`` = _prefixId.prefix "historyOfTheResource.en"
    let ``honouree.en`` = _prefixId.prefix "honouree.en"
    let ``honoureeOf.en`` = _prefixId.prefix "honoureeOf.en"

    let ``horizontalScaleOfCartographicContent.en`` =
        _prefixId.prefix "horizontalScaleOfCartographicContent.en"

    let ``host.en`` = _prefixId.prefix "host.en"
    let ``hostInstitution.en`` = _prefixId.prefix "hostInstitution.en"
    let ``hostInstitutionOf.en`` = _prefixId.prefix "hostInstitutionOf.en"
    let ``hostOf.en`` = _prefixId.prefix "hostOf.en"
    let ``identifierForTheAgent.en`` = _prefixId.prefix "identifierForTheAgent.en"
    let ``identifierForTheResource.en`` = _prefixId.prefix "identifierForTheResource.en"
    let ``illuminator.en`` = _prefixId.prefix "illuminator.en"
    let ``illuminatorOf.en`` = _prefixId.prefix "illuminatorOf.en"
    let ``illustrations.en`` = _prefixId.prefix "illustrations.en"
    let ``illustrationsFor.en`` = _prefixId.prefix "illustrationsFor.en"
    let ``illustrativeContent.en`` = _prefixId.prefix "illustrativeContent.en"
    let ``illustrator.en`` = _prefixId.prefix "illustrator.en"
    let ``illustratorOf.en`` = _prefixId.prefix "illustratorOf.en"
    let ``imitatedAs.en`` = _prefixId.prefix "imitatedAs.en"
    let ``imitationOf.en`` = _prefixId.prefix "imitationOf.en"

    let ``immediateSourceOfAcquisitionOfItem.en`` =
        _prefixId.prefix "immediateSourceOfAcquisitionOfItem.en"

    let ``inSeries.en`` = _prefixId.prefix "inSeries.en"
    let ``incidentalMusic.en`` = _prefixId.prefix "incidentalMusic.en"
    let ``incidentalMusicFor.en`` = _prefixId.prefix "incidentalMusicFor.en"
    let ``incumbent.en`` = _prefixId.prefix "incumbent.en"
    let ``index.en`` = _prefixId.prefix "index.en"
    let ``indexTo.en`` = _prefixId.prefix "indexTo.en"
    let ``indexedIn.en`` = _prefixId.prefix "indexedIn.en"
    let ``indexingFor.en`` = _prefixId.prefix "indexingFor.en"
    let ``inscriber.en`` = _prefixId.prefix "inscriber.en"
    let ``inscriberOf.en`` = _prefixId.prefix "inscriberOf.en"
    let ``insert.en`` = _prefixId.prefix "insert.en"
    let ``insertedIn.en`` = _prefixId.prefix "insertedIn.en"
    let ``inspirationFor.en`` = _prefixId.prefix "inspirationFor.en"
    let ``inspiredBy.en`` = _prefixId.prefix "inspiredBy.en"
    let ``instrumentalConductor.en`` = _prefixId.prefix "instrumentalConductor.en"
    let ``instrumentalConductorOf.en`` = _prefixId.prefix "instrumentalConductorOf.en"
    let ``instrumentalist.en`` = _prefixId.prefix "instrumentalist.en"
    let ``instrumentalistOf.en`` = _prefixId.prefix "instrumentalistOf.en"
    let ``intendedAudience.en`` = _prefixId.prefix "intendedAudience.en"
    let ``interviewee.en`` = _prefixId.prefix "interviewee.en"
    let ``intervieweeOf.en`` = _prefixId.prefix "intervieweeOf.en"
    let ``interviewer.en`` = _prefixId.prefix "interviewer.en"
    let ``interviewerOf.en`` = _prefixId.prefix "interviewerOf.en"
    let ``inventor.en`` = _prefixId.prefix "inventor.en"
    let ``inventorOf.en`` = _prefixId.prefix "inventorOf.en"
    let ``issnOfSeries.en`` = _prefixId.prefix "issnOfSeries.en"
    let ``issnOfSubseries.en`` = _prefixId.prefix "issnOfSubseries.en"
    let ``issuedWith.en`` = _prefixId.prefix "issuedWith.en"
    let ``issuingBody.en`` = _prefixId.prefix "issuingBody.en"
    let ``issuingBodyOf.en`` = _prefixId.prefix "issuingBodyOf.en"
    let ``judge.en`` = _prefixId.prefix "judge.en"
    let ``judgeOf.en`` = _prefixId.prefix "judgeOf.en"
    let ``jurisdictionGoverned.en`` = _prefixId.prefix "jurisdictionGoverned.en"
    let ``jurisdictionGovernedOf.en`` = _prefixId.prefix "jurisdictionGovernedOf.en"
    let ``key.en`` = _prefixId.prefix "key.en"
    let ``keyTitle.en`` = _prefixId.prefix "keyTitle.en"
    let ``landscapeArchitect.en`` = _prefixId.prefix "landscapeArchitect.en"
    let ``landscapeArchitectOf.en`` = _prefixId.prefix "landscapeArchitectOf.en"
    let ``languageOfTheAgent.en`` = _prefixId.prefix "languageOfTheAgent.en"
    let ``languageOfTheContent.en`` = _prefixId.prefix "languageOfTheContent.en"
    let ``laterTitleProper.en`` = _prefixId.prefix "laterTitleProper.en"
    let ``layout.en`` = _prefixId.prefix "layout.en"
    let ``letterer.en`` = _prefixId.prefix "letterer.en"
    let ``lettererOf.en`` = _prefixId.prefix "lettererOf.en"
    let ``librettist.en`` = _prefixId.prefix "librettist.en"
    let ``librettistOf.en`` = _prefixId.prefix "librettistOf.en"
    let ``libretto.en`` = _prefixId.prefix "libretto.en"
    let ``librettoBasedOn.en`` = _prefixId.prefix "librettoBasedOn.en"
    let ``librettoFor.en`` = _prefixId.prefix "librettoFor.en"
    let ``lightingDesigner.en`` = _prefixId.prefix "lightingDesigner.en"
    let ``lightingDesignerOf.en`` = _prefixId.prefix "lightingDesignerOf.en"
    let ``lithographer.en`` = _prefixId.prefix "lithographer.en"
    let ``lithographerOf.en`` = _prefixId.prefix "lithographerOf.en"
    let ``localAffiliate.en`` = _prefixId.prefix "localAffiliate.en"
    let ``locationOfConferenceEtc.en`` = _prefixId.prefix "locationOfConferenceEtc.en"
    let ``locationOfHeadquarters.en`` = _prefixId.prefix "locationOfHeadquarters.en"
    let ``longitudeAndLatitude.en`` = _prefixId.prefix "longitudeAndLatitude.en"
    let ``lyricist.en`` = _prefixId.prefix "lyricist.en"
    let ``lyricistOf.en`` = _prefixId.prefix "lyricistOf.en"
    let ``makeUpArtist.en`` = _prefixId.prefix "makeUpArtist.en"
    let ``makeUpArtistOf.en`` = _prefixId.prefix "makeUpArtistOf.en"
    let ``manufactureStatement.en`` = _prefixId.prefix "manufactureStatement.en"
    let ``manufacturer.en`` = _prefixId.prefix "manufacturer.en"
    let ``manufacturerOf.en`` = _prefixId.prefix "manufacturerOf.en"
    let ``manufacturersName.en`` = _prefixId.prefix "manufacturersName.en"
    let ``mediaType.en`` = _prefixId.prefix "mediaType.en"
    let ``medium.en`` = _prefixId.prefix "medium.en"
    let ``mediumOf.en`` = _prefixId.prefix "mediumOf.en"
    let ``mediumOfPerformance.en`` = _prefixId.prefix "mediumOfPerformance.en"

    let ``mediumOfPerformanceOfMusicalContent.en`` =
        _prefixId.prefix "mediumOfPerformanceOfMusicalContent.en"

    let ``member.en`` = _prefixId.prefix "member.en"
    let ``memberOf.en`` = _prefixId.prefix "memberOf.en"
    let ``mergedToForm.en`` = _prefixId.prefix "mergedToForm.en"
    let ``mergee.en`` = _prefixId.prefix "mergee.en"
    let ``mergerOf.en`` = _prefixId.prefix "mergerOf.en"
    let ``minuteTaker.en`` = _prefixId.prefix "minuteTaker.en"
    let ``minuteTakerOf.en`` = _prefixId.prefix "minuteTakerOf.en"
    let ``mirrorSite.en`` = _prefixId.prefix "mirrorSite.en"
    let ``modeOfIssuance.en`` = _prefixId.prefix "modeOfIssuance.en"
    let ``moderator.en`` = _prefixId.prefix "moderator.en"
    let ``moderatorOf.en`` = _prefixId.prefix "moderatorOf.en"
    let ``modifiedByVariationAs.en`` = _prefixId.prefix "modifiedByVariationAs.en"

    let ``motionPictureAdaptationOf.en`` =
        _prefixId.prefix "motionPictureAdaptationOf.en"

    let ``motionPictureMusic.en`` = _prefixId.prefix "motionPictureMusic.en"
    let ``motionPictureScreenplay.en`` = _prefixId.prefix "motionPictureScreenplay.en"

    let ``motionPictureScreenplayBasedOn.en`` =
        _prefixId.prefix "motionPictureScreenplayBasedOn.en"

    let ``mount.en`` = _prefixId.prefix "mount.en"
    let ``music.en`` = _prefixId.prefix "music.en"
    let ``musicFor.en`` = _prefixId.prefix "musicFor.en"
    let ``musicForMotionPicture.en`` = _prefixId.prefix "musicForMotionPicture.en"
    let ``musicForRadioProgram.en`` = _prefixId.prefix "musicForRadioProgram.en"

    let ``musicForTelevisionProgram.en`` =
        _prefixId.prefix "musicForTelevisionProgram.en"

    let ``musicForVideo.en`` = _prefixId.prefix "musicForVideo.en"
    let ``musicalDirector.en`` = _prefixId.prefix "musicalDirector.en"
    let ``musicalDirectorOf.en`` = _prefixId.prefix "musicalDirectorOf.en"
    let ``musicalSettingOf.en`` = _prefixId.prefix "musicalSettingOf.en"

    let ``musicalTheatreAdaptationOf.en`` =
        _prefixId.prefix "musicalTheatreAdaptationOf.en"

    let ``nameOfTheAgent.en`` = _prefixId.prefix "nameOfTheAgent.en"
    let ``nameOfThePlace.en`` = _prefixId.prefix "nameOfThePlace.en"
    let ``narrator.en`` = _prefixId.prefix "narrator.en"
    let ``narratorOf.en`` = _prefixId.prefix "narratorOf.en"
    let ``natureOfTheContent.en`` = _prefixId.prefix "natureOfTheContent.en"

    let ``noteOnChangesInCarrierCharacteristics.en`` =
        _prefixId.prefix "noteOnChangesInCarrierCharacteristics.en"

    let ``noteOnChangesInContentCharacteristics.en`` =
        _prefixId.prefix "noteOnChangesInContentCharacteristics.en"

    let ``noteOnCopyrightDate.en`` = _prefixId.prefix "noteOnCopyrightDate.en"

    let ``noteOnDimensionsOfResource.en`` =
        _prefixId.prefix "noteOnDimensionsOfResource.en"

    let ``noteOnDistributionStatement.en`` =
        _prefixId.prefix "noteOnDistributionStatement.en"

    let ``noteOnEditionStatement.en`` = _prefixId.prefix "noteOnEditionStatement.en"
    let ``noteOnExtentOfResource.en`` = _prefixId.prefix "noteOnExtentOfResource.en"
    let ``noteOnFrequency.en`` = _prefixId.prefix "noteOnFrequency.en"

    let ``noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en`` =
        _prefixId.prefix "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en"

    let ``noteOnManufactureStatement.en`` =
        _prefixId.prefix "noteOnManufactureStatement.en"

    let ``noteOnNumberingOfSerials.en`` = _prefixId.prefix "noteOnNumberingOfSerials.en"

    let ``noteOnProductionStatement.en`` =
        _prefixId.prefix "noteOnProductionStatement.en"

    let ``noteOnPublicationStatement.en`` =
        _prefixId.prefix "noteOnPublicationStatement.en"

    let ``noteOnResource.en`` = _prefixId.prefix "noteOnResource.en"

    let ``noteOnResourceSpecificCarrierCharacteristic.en`` =
        _prefixId.prefix "noteOnResourceSpecificCarrierCharacteristic.en"

    let ``noteOnSeriesStatement.en`` = _prefixId.prefix "noteOnSeriesStatement.en"

    let ``noteOnStatementOfResponsibility.en`` =
        _prefixId.prefix "noteOnStatementOfResponsibility.en"

    let ``noteOnTitle.en`` = _prefixId.prefix "noteOnTitle.en"
    let ``novelizationOf.en`` = _prefixId.prefix "novelizationOf.en"
    let ``numberOfAConferenceEtc.en`` = _prefixId.prefix "numberOfAConferenceEtc.en"
    let ``numberingOfPart.en`` = _prefixId.prefix "numberingOfPart.en"
    let ``numberingOfSerials.en`` = _prefixId.prefix "numberingOfSerials.en"
    let ``numberingWithinSeries.en`` = _prefixId.prefix "numberingWithinSeries.en"
    let ``numberingWithinSubseries.en`` = _prefixId.prefix "numberingWithinSubseries.en"

    let ``numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en`` =
        _prefixId.prefix "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en"

    let ``numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en`` =
        _prefixId.prefix "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en"

    let ``numericDesignationOfAMusicalResource.en`` =
        _prefixId.prefix "numericDesignationOfAMusicalResource.en"

    let ``officiatedAgent.en`` = _prefixId.prefix "officiatedAgent.en"
    let ``onDiscWith.en`` = _prefixId.prefix "onDiscWith.en"
    let ``onScreenParticipant.en`` = _prefixId.prefix "onScreenParticipant.en"
    let ``onScreenParticipantOf.en`` = _prefixId.prefix "onScreenParticipantOf.en"
    let ``onScreenPresenter.en`` = _prefixId.prefix "onScreenPresenter.en"
    let ``onScreenPresenterOf.en`` = _prefixId.prefix "onScreenPresenterOf.en"
    let ``operaAdaptationOf.en`` = _prefixId.prefix "operaAdaptationOf.en"
    let ``oratorioAdaptationOf.en`` = _prefixId.prefix "oratorioAdaptationOf.en"
    let ``organizer.en`` = _prefixId.prefix "organizer.en"
    let ``organizerOf.en`` = _prefixId.prefix "organizerOf.en"

    let ``otherAgentAssociatedWithAResource.en`` =
        _prefixId.prefix "otherAgentAssociatedWithAResource.en"

    let ``otherAgentAssociatedWithAResourceOf.en`` =
        _prefixId.prefix "otherAgentAssociatedWithAResourceOf.en"

    let ``otherDesignationAssociatedWithTheAgent.en`` =
        _prefixId.prefix "otherDesignationAssociatedWithTheAgent.en"

    let ``otherDetailsOfCartographicContent.en`` =
        _prefixId.prefix "otherDetailsOfCartographicContent.en"

    let ``otherDistinguishingCharacteristicOfTheResource.en`` =
        _prefixId.prefix "otherDistinguishingCharacteristicOfTheResource.en"

    let ``otherTitleInformation.en`` = _prefixId.prefix "otherTitleInformation.en"

    let ``otherTitleInformationOfSeries.en`` =
        _prefixId.prefix "otherTitleInformationOfSeries.en"

    let ``otherTitleInformationOfSubseries.en`` =
        _prefixId.prefix "otherTitleInformationOfSubseries.en"

    let ``owner.en`` = _prefixId.prefix "owner.en"
    let ``ownerOf.en`` = _prefixId.prefix "ownerOf.en"
    let ``panelist.en`` = _prefixId.prefix "panelist.en"
    let ``panelistOf.en`` = _prefixId.prefix "panelistOf.en"
    let ``papermaker.en`` = _prefixId.prefix "papermaker.en"
    let ``papermakerOf.en`` = _prefixId.prefix "papermakerOf.en"

    let ``parallelDesignationOfANamedRevisionOfAnEdition.en`` =
        _prefixId.prefix "parallelDesignationOfANamedRevisionOfAnEdition.en"

    let ``parallelDesignationOfEdition.en`` =
        _prefixId.prefix "parallelDesignationOfEdition.en"

    let ``parallelDistributorsName.en`` = _prefixId.prefix "parallelDistributorsName.en"

    let ``parallelManufacturersName.en`` =
        _prefixId.prefix "parallelManufacturersName.en"

    let ``parallelOtherTitleInformation.en`` =
        _prefixId.prefix "parallelOtherTitleInformation.en"

    let ``parallelOtherTitleInformationOfSeries.en`` =
        _prefixId.prefix "parallelOtherTitleInformationOfSeries.en"

    let ``parallelOtherTitleInformationOfSubseries.en`` =
        _prefixId.prefix "parallelOtherTitleInformationOfSubseries.en"

    let ``parallelPlaceOfDistribution.en`` =
        _prefixId.prefix "parallelPlaceOfDistribution.en"

    let ``parallelPlaceOfManufacture.en`` =
        _prefixId.prefix "parallelPlaceOfManufacture.en"

    let ``parallelPlaceOfProduction.en`` =
        _prefixId.prefix "parallelPlaceOfProduction.en"

    let ``parallelPlaceOfPublication.en`` =
        _prefixId.prefix "parallelPlaceOfPublication.en"

    let ``parallelProducersName.en`` = _prefixId.prefix "parallelProducersName.en"
    let ``parallelPublishersName.en`` = _prefixId.prefix "parallelPublishersName.en"

    let ``parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en`` =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en"

    let ``parallelStatementOfResponsibilityRelatingToSeries.en`` =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSeries.en"

    let ``parallelStatementOfResponsibilityRelatingToSubseries.en`` =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSubseries.en"

    let ``parallelStatementOfResponsibilityRelatingToTheEdition.en`` =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTheEdition.en"

    let ``parallelStatementOfResponsibilityRelatingToTitleProper.en`` =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTitleProper.en"

    let ``parallelTitleProper.en`` = _prefixId.prefix "parallelTitleProper.en"

    let ``parallelTitleProperOfSeries.en`` =
        _prefixId.prefix "parallelTitleProperOfSeries.en"

    let ``parallelTitleProperOfSubseries.en`` =
        _prefixId.prefix "parallelTitleProperOfSubseries.en"

    let ``paraphraseOf.en`` = _prefixId.prefix "paraphraseOf.en"
    let ``paraphrasedAs.en`` = _prefixId.prefix "paraphrasedAs.en"
    let ``parodiedAs.en`` = _prefixId.prefix "parodiedAs.en"
    let ``parodyOf.en`` = _prefixId.prefix "parodyOf.en"
    let ``participantInATreaty.en`` = _prefixId.prefix "participantInATreaty.en"
    let ``participantInATreatyOf.en`` = _prefixId.prefix "participantInATreatyOf.en"
    let ``performer.en`` = _prefixId.prefix "performer.en"
    let ``performerOf.en`` = _prefixId.prefix "performerOf.en"

    let ``periodOfActivityOfTheAgent.en`` =
        _prefixId.prefix "periodOfActivityOfTheAgent.en"

    let ``photographer.en`` = _prefixId.prefix "photographer.en"
    let ``photographerOf.en`` = _prefixId.prefix "photographerOf.en"
    let ``placeAndDateOfCapture.en`` = _prefixId.prefix "placeAndDateOfCapture.en"

    let ``placeAssociatedWithTheAgent.en`` =
        _prefixId.prefix "placeAssociatedWithTheAgent.en"

    let ``placeOfBirth.en`` = _prefixId.prefix "placeOfBirth.en"
    let ``placeOfCapture.en`` = _prefixId.prefix "placeOfCapture.en"
    let ``placeOfDeath.en`` = _prefixId.prefix "placeOfDeath.en"
    let ``placeOfDistribution.en`` = _prefixId.prefix "placeOfDistribution.en"
    let ``placeOfManufacture.en`` = _prefixId.prefix "placeOfManufacture.en"

    let ``placeOfOriginOfTheResource.en`` =
        _prefixId.prefix "placeOfOriginOfTheResource.en"

    let ``placeOfProduction.en`` = _prefixId.prefix "placeOfProduction.en"
    let ``placeOfPublication.en`` = _prefixId.prefix "placeOfPublication.en"
    let ``placeOfResidenceEtc.en`` = _prefixId.prefix "placeOfResidenceEtc.en"
    let ``plaintiff.en`` = _prefixId.prefix "plaintiff.en"
    let ``plaintiffOf.en`` = _prefixId.prefix "plaintiffOf.en"
    let ``plateNumberForMusic.en`` = _prefixId.prefix "plateNumberForMusic.en"
    let ``platemaker.en`` = _prefixId.prefix "platemaker.en"
    let ``platemakerOf.en`` = _prefixId.prefix "platemakerOf.en"
    let ``playingSpeed.en`` = _prefixId.prefix "playingSpeed.en"
    let ``polarity.en`` = _prefixId.prefix "polarity.en"
    let ``praeses.en`` = _prefixId.prefix "praeses.en"
    let ``praesesOf.en`` = _prefixId.prefix "praesesOf.en"
    let ``precededBy.en`` = _prefixId.prefix "precededBy.en"
    let ``predecessor.en`` = _prefixId.prefix "predecessor.en"
    let ``predecessorOfSplit.en`` = _prefixId.prefix "predecessorOfSplit.en"
    let ``preferredCitation.en`` = _prefixId.prefix "preferredCitation.en"
    let ``preferredNameForTheAgent.en`` = _prefixId.prefix "preferredNameForTheAgent.en"
    let ``preferredNameForThePlace.en`` = _prefixId.prefix "preferredNameForThePlace.en"

    let ``preferredTitleForTheResource.en`` =
        _prefixId.prefix "preferredTitleForTheResource.en"

    let ``prequel.en`` = _prefixId.prefix "prequel.en"
    let ``prequelTo.en`` = _prefixId.prefix "prequelTo.en"
    let ``presentationFormat.en`` = _prefixId.prefix "presentationFormat.en"
    let ``presenter.en`` = _prefixId.prefix "presenter.en"
    let ``presenterOf.en`` = _prefixId.prefix "presenterOf.en"
    let ``preservationFacsimile.en`` = _prefixId.prefix "preservationFacsimile.en"
    let ``preservationFacsimileOf.en`` = _prefixId.prefix "preservationFacsimileOf.en"
    let ``printer.en`` = _prefixId.prefix "printer.en"
    let ``printerOf.en`` = _prefixId.prefix "printerOf.en"
    let ``printmaker.en`` = _prefixId.prefix "printmaker.en"
    let ``printmakerOf.en`` = _prefixId.prefix "printmakerOf.en"
    let ``producer.en`` = _prefixId.prefix "producer.en"
    let ``producerOf.en`` = _prefixId.prefix "producerOf.en"

    let ``producerOfAnUnpublishedResource.en`` =
        _prefixId.prefix "producerOfAnUnpublishedResource.en"

    let ``producerOfAnUnpublishedResourceOf.en`` =
        _prefixId.prefix "producerOfAnUnpublishedResourceOf.en"

    let ``producersName.en`` = _prefixId.prefix "producersName.en"
    let ``productOfAMerger.en`` = _prefixId.prefix "productOfAMerger.en"
    let ``productOfASplit.en`` = _prefixId.prefix "productOfASplit.en"
    let ``productionCompany.en`` = _prefixId.prefix "productionCompany.en"
    let ``productionCompanyOf.en`` = _prefixId.prefix "productionCompanyOf.en"
    let ``productionDesigner.en`` = _prefixId.prefix "productionDesigner.en"
    let ``productionDesignerOf.en`` = _prefixId.prefix "productionDesignerOf.en"
    let ``productionMethod.en`` = _prefixId.prefix "productionMethod.en"

    let ``productionMethodForManuscript.en`` =
        _prefixId.prefix "productionMethodForManuscript.en"

    let ``productionMethodForTactileResource.en`` =
        _prefixId.prefix "productionMethodForTactileResource.en"

    let ``productionStatement.en`` = _prefixId.prefix "productionStatement.en"
    let ``professionOrOccupation.en`` = _prefixId.prefix "professionOrOccupation.en"
    let ``programmer.en`` = _prefixId.prefix "programmer.en"
    let ``programmerOf.en`` = _prefixId.prefix "programmerOf.en"

    let ``projectionCharacteristicOfMotionPictureFilm.en`` =
        _prefixId.prefix "projectionCharacteristicOfMotionPictureFilm.en"

    let ``projectionOfCartographicContent.en`` =
        _prefixId.prefix "projectionOfCartographicContent.en"

    let ``projectionSpeed.en`` = _prefixId.prefix "projectionSpeed.en"

    let ``prominentMemberOfTheFamily.en`` =
        _prefixId.prefix "prominentMemberOfTheFamily.en"

    let ``publicationStatement.en`` = _prefixId.prefix "publicationStatement.en"
    let ``publisher.en`` = _prefixId.prefix "publisher.en"
    let ``publisherOf.en`` = _prefixId.prefix "publisherOf.en"
    let ``publishersName.en`` = _prefixId.prefix "publishersName.en"
    let ``publishersNumberForMusic.en`` = _prefixId.prefix "publishersNumberForMusic.en"
    let ``puppeteer.en`` = _prefixId.prefix "puppeteer.en"
    let ``puppeteerOf.en`` = _prefixId.prefix "puppeteerOf.en"
    let ``radioAdaptationOf.en`` = _prefixId.prefix "radioAdaptationOf.en"
    let ``radioDirector.en`` = _prefixId.prefix "radioDirector.en"
    let ``radioDirectorOf.en`` = _prefixId.prefix "radioDirectorOf.en"
    let ``radioProducer.en`` = _prefixId.prefix "radioProducer.en"
    let ``radioProducerOf.en`` = _prefixId.prefix "radioProducerOf.en"
    let ``radioProgramMusic.en`` = _prefixId.prefix "radioProgramMusic.en"
    let ``radioScript.en`` = _prefixId.prefix "radioScript.en"
    let ``radioScriptBasedOn.en`` = _prefixId.prefix "radioScriptBasedOn.en"
    let ``rapporteur.en`` = _prefixId.prefix "rapporteur.en"
    let ``rapporteurOf.en`` = _prefixId.prefix "rapporteurOf.en"
    let ``realIdentity.en`` = _prefixId.prefix "realIdentity.en"
    let ``recordingEngineer.en`` = _prefixId.prefix "recordingEngineer.en"
    let ``recordingEngineerOf.en`` = _prefixId.prefix "recordingEngineerOf.en"
    let ``recordingMedium.en`` = _prefixId.prefix "recordingMedium.en"
    let ``recordist.en`` = _prefixId.prefix "recordist.en"
    let ``recordistOf.en`` = _prefixId.prefix "recordistOf.en"
    let ``reductionRatio.en`` = _prefixId.prefix "reductionRatio.en"

    let ``referentialResourceRelationship.en`` =
        _prefixId.prefix "referentialResourceRelationship.en"

    let ``regionalEncoding.en`` = _prefixId.prefix "regionalEncoding.en"
    let ``relatedAgent.en`` = _prefixId.prefix "relatedAgent.en"
    let ``relatedResource.en`` = _prefixId.prefix "relatedResource.en"
    let ``remadeAs.en`` = _prefixId.prefix "remadeAs.en"
    let ``remakeOf.en`` = _prefixId.prefix "remakeOf.en"
    let ``replacedBy.en`` = _prefixId.prefix "replacedBy.en"
    let ``replacedInPartBy.en`` = _prefixId.prefix "replacedInPartBy.en"
    let ``replacementInPartOf.en`` = _prefixId.prefix "replacementInPartOf.en"
    let ``replacementOf.en`` = _prefixId.prefix "replacementOf.en"
    let ``reprintOf.en`` = _prefixId.prefix "reprintOf.en"
    let ``reprintedAs.en`` = _prefixId.prefix "reprintedAs.en"
    let ``reproducedAs.en`` = _prefixId.prefix "reproducedAs.en"
    let ``reproductionOf.en`` = _prefixId.prefix "reproductionOf.en"
    let ``researchOf.en`` = _prefixId.prefix "researchOf.en"
    let ``researcher.en`` = _prefixId.prefix "researcher.en"
    let ``resolution.en`` = _prefixId.prefix "resolution.en"
    let ``respondent.en`` = _prefixId.prefix "respondent.en"
    let ``respondentOf.en`` = _prefixId.prefix "respondentOf.en"
    let ``restorationist.en`` = _prefixId.prefix "restorationist.en"
    let ``restorationistOf.en`` = _prefixId.prefix "restorationistOf.en"
    let ``restrictionsOnAccess.en`` = _prefixId.prefix "restrictionsOnAccess.en"
    let ``restrictionsOnUse.en`` = _prefixId.prefix "restrictionsOnUse.en"
    let ``reviewOf.en`` = _prefixId.prefix "reviewOf.en"
    let ``reviewedIn.en`` = _prefixId.prefix "reviewedIn.en"
    let ``revisedAs.en`` = _prefixId.prefix "revisedAs.en"
    let ``revisionOf.en`` = _prefixId.prefix "revisionOf.en"

    let ``rightAscensionAndDeclination.en`` =
        _prefixId.prefix "rightAscensionAndDeclination.en"

    let ``scale.en`` = _prefixId.prefix "scale.en"

    let ``scaleOfStillImageOrThreeDimensionalForm.en`` =
        _prefixId.prefix "scaleOfStillImageOrThreeDimensionalForm.en"

    let ``scopeOfUsage.en`` = _prefixId.prefix "scopeOfUsage.en"
    let ``screenplay.en`` = _prefixId.prefix "screenplay.en"
    let ``screenplayBasedOn.en`` = _prefixId.prefix "screenplayBasedOn.en"
    let ``screenplayFor.en`` = _prefixId.prefix "screenplayFor.en"

    let ``screenplayForTheMotionPicture.en`` =
        _prefixId.prefix "screenplayForTheMotionPicture.en"

    let ``screenplayForTheTelevisionProgram.en`` =
        _prefixId.prefix "screenplayForTheTelevisionProgram.en"

    let ``screenplayForTheVideo.en`` = _prefixId.prefix "screenplayForTheVideo.en"
    let ``screenwriter.en`` = _prefixId.prefix "screenwriter.en"
    let ``screenwriterOf.en`` = _prefixId.prefix "screenwriterOf.en"
    let ``script.en`` = _prefixId.prefix "script.en"
    let ``scriptForTheRadioProgram.en`` = _prefixId.prefix "scriptForTheRadioProgram.en"
    let ``sculptor.en`` = _prefixId.prefix "sculptor.en"
    let ``sculptorOf.en`` = _prefixId.prefix "sculptorOf.en"
    let ``seller.en`` = _prefixId.prefix "seller.en"
    let ``sellerOf.en`` = _prefixId.prefix "sellerOf.en"
    let ``separatedFrom.en`` = _prefixId.prefix "separatedFrom.en"
    let ``sequel.en`` = _prefixId.prefix "sequel.en"
    let ``sequelTo.en`` = _prefixId.prefix "sequelTo.en"

    let ``sequentialResourceRelationshipWith.en`` =
        _prefixId.prefix "sequentialResourceRelationshipWith.en"

    let ``seriesContainerOf.en`` = _prefixId.prefix "seriesContainerOf.en"
    let ``seriesStatement.en`` = _prefixId.prefix "seriesStatement.en"
    let ``setToMusicAs.en`` = _prefixId.prefix "setToMusicAs.en"
    let ``singer.en`` = _prefixId.prefix "singer.en"
    let ``singerOf.en`` = _prefixId.prefix "singerOf.en"
    let ``softwareDeveloper.en`` = _prefixId.prefix "softwareDeveloper.en"
    let ``softwareDeveloperOf.en`` = _prefixId.prefix "softwareDeveloperOf.en"
    let ``soundCharacteristic.en`` = _prefixId.prefix "soundCharacteristic.en"
    let ``soundContent.en`` = _prefixId.prefix "soundContent.en"
    let ``soundDesigner.en`` = _prefixId.prefix "soundDesigner.en"
    let ``soundDesignerOf.en`` = _prefixId.prefix "soundDesignerOf.en"
    let ``speaker.en`` = _prefixId.prefix "speaker.en"
    let ``speakerOf.en`` = _prefixId.prefix "speakerOf.en"
    let ``specialEffectsProvider.en`` = _prefixId.prefix "specialEffectsProvider.en"
    let ``specialEffectsProviderOf.en`` = _prefixId.prefix "specialEffectsProviderOf.en"
    let ``specialIssue.en`` = _prefixId.prefix "specialIssue.en"
    let ``specialIssueOf.en`` = _prefixId.prefix "specialIssueOf.en"

    let ``specialPlaybackCharacteristic.en`` =
        _prefixId.prefix "specialPlaybackCharacteristic.en"

    let ``splitInto.en`` = _prefixId.prefix "splitInto.en"
    let ``sponsor.en`` = _prefixId.prefix "sponsor.en"
    let ``sponsoredEntity.en`` = _prefixId.prefix "sponsoredEntity.en"
    let ``sponsoringBody.en`` = _prefixId.prefix "sponsoringBody.en"
    let ``sponsoringBodyOf.en`` = _prefixId.prefix "sponsoringBodyOf.en"
    let ``stageDirector.en`` = _prefixId.prefix "stageDirector.en"
    let ``stageDirectorOf.en`` = _prefixId.prefix "stageDirectorOf.en"

    let ``statementOfResponsibility.en`` =
        _prefixId.prefix "statementOfResponsibility.en"

    let ``statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en`` =
        _prefixId.prefix "statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en"

    let ``statementOfResponsibilityRelatingToSeries.en`` =
        _prefixId.prefix "statementOfResponsibilityRelatingToSeries.en"

    let ``statementOfResponsibilityRelatingToSubseries.en`` =
        _prefixId.prefix "statementOfResponsibilityRelatingToSubseries.en"

    let ``statementOfResponsibilityRelatingToTheEdition.en`` =
        _prefixId.prefix "statementOfResponsibilityRelatingToTheEdition.en"

    let ``statementOfResponsibilityRelatingToTitleProper.en`` =
        _prefixId.prefix "statementOfResponsibilityRelatingToTitleProper.en"

    let ``storyteller.en`` = _prefixId.prefix "storyteller.en"
    let ``storytellerOf.en`` = _prefixId.prefix "storytellerOf.en"
    let ``stringsOfCoordinatePairs.en`` = _prefixId.prefix "stringsOfCoordinatePairs.en"
    let ``subject.en`` = _prefixId.prefix "subject.en"
    let ``subjectOf.en`` = _prefixId.prefix "subjectOf.en"
    let ``subseries.en`` = _prefixId.prefix "subseries.en"
    let ``subseriesOf.en`` = _prefixId.prefix "subseriesOf.en"
    let ``succeededBy.en`` = _prefixId.prefix "succeededBy.en"
    let ``successor.en`` = _prefixId.prefix "successor.en"

    let ``summarizationOfTheContent.en`` =
        _prefixId.prefix "summarizationOfTheContent.en"

    let ``summarizedAs.en`` = _prefixId.prefix "summarizedAs.en"
    let ``summaryOf.en`` = _prefixId.prefix "summaryOf.en"
    let ``supplement.en`` = _prefixId.prefix "supplement.en"
    let ``supplementTo.en`` = _prefixId.prefix "supplementTo.en"
    let ``supplementaryContent.en`` = _prefixId.prefix "supplementaryContent.en"
    let ``surveyor.en`` = _prefixId.prefix "surveyor.en"
    let ``surveyorOf.en`` = _prefixId.prefix "surveyorOf.en"
    let ``systemOfOrganization.en`` = _prefixId.prefix "systemOfOrganization.en"
    let ``tapeConfiguration.en`` = _prefixId.prefix "tapeConfiguration.en"
    let ``teacher.en`` = _prefixId.prefix "teacher.en"
    let ``teacherOf.en`` = _prefixId.prefix "teacherOf.en"
    let ``televisionAdaptationOf.en`` = _prefixId.prefix "televisionAdaptationOf.en"
    let ``televisionDirector.en`` = _prefixId.prefix "televisionDirector.en"
    let ``televisionDirectorOf.en`` = _prefixId.prefix "televisionDirectorOf.en"
    let ``televisionProducer.en`` = _prefixId.prefix "televisionProducer.en"
    let ``televisionProducerOf.en`` = _prefixId.prefix "televisionProducerOf.en"
    let ``televisionProgramMusic.en`` = _prefixId.prefix "televisionProgramMusic.en"
    let ``televisionScreenplay.en`` = _prefixId.prefix "televisionScreenplay.en"

    let ``televisionScreenplayBasedOn.en`` =
        _prefixId.prefix "televisionScreenplayBasedOn.en"

    let ``termsOfAvailability.en`` = _prefixId.prefix "termsOfAvailability.en"
    let ``title.en`` = _prefixId.prefix "title.en"
    let ``titleOfTheAgent.en`` = _prefixId.prefix "titleOfTheAgent.en"
    let ``titleOfTheResource.en`` = _prefixId.prefix "titleOfTheResource.en"
    let ``titleProper.en`` = _prefixId.prefix "titleProper.en"
    let ``titleProperOfSeries.en`` = _prefixId.prefix "titleProperOfSeries.en"
    let ``titleProperOfSubseries.en`` = _prefixId.prefix "titleProperOfSubseries.en"
    let ``trackConfiguration.en`` = _prefixId.prefix "trackConfiguration.en"
    let ``transcriber.en`` = _prefixId.prefix "transcriber.en"
    let ``transcriberOf.en`` = _prefixId.prefix "transcriberOf.en"
    let ``translatedAs.en`` = _prefixId.prefix "translatedAs.en"
    let ``translationOf.en`` = _prefixId.prefix "translationOf.en"
    let ``translator.en`` = _prefixId.prefix "translator.en"
    let ``translatorOf.en`` = _prefixId.prefix "translatorOf.en"
    let ``typeOfAgent.en`` = _prefixId.prefix "typeOfAgent.en"
    let ``typeOfRecording.en`` = _prefixId.prefix "typeOfRecording.en"

    let ``undifferentiatedNameIndicator.en`` =
        _prefixId.prefix "undifferentiatedNameIndicator.en"

    let ``uniformResourceLocator.en`` = _prefixId.prefix "uniformResourceLocator.en"
    let ``variantNameForTheAgent.en`` = _prefixId.prefix "variantNameForTheAgent.en"
    let ``variantTitle.en`` = _prefixId.prefix "variantTitle.en"
    let ``variationsBasedOn.en`` = _prefixId.prefix "variationsBasedOn.en"
    let ``verseAdaptationOf.en`` = _prefixId.prefix "verseAdaptationOf.en"

    let ``verticalScaleOfCartographicContent.en`` =
        _prefixId.prefix "verticalScaleOfCartographicContent.en"

    let ``videoAdaptationOf.en`` = _prefixId.prefix "videoAdaptationOf.en"
    let ``videoCharacteristic.en`` = _prefixId.prefix "videoCharacteristic.en"
    let ``videoFormat.en`` = _prefixId.prefix "videoFormat.en"
    let ``videoGameAdaptationOf.en`` = _prefixId.prefix "videoGameAdaptationOf.en"
    let ``videoMusic.en`` = _prefixId.prefix "videoMusic.en"
    let ``videoScreenplay.en`` = _prefixId.prefix "videoScreenplay.en"
    let ``videoScreenplayBasedOn.en`` = _prefixId.prefix "videoScreenplayBasedOn.en"
    let ``visualEffectsProvider.en`` = _prefixId.prefix "visualEffectsProvider.en"
    let ``visualEffectsProviderOf.en`` = _prefixId.prefix "visualEffectsProviderOf.en"
    let ``voiceActor.en`` = _prefixId.prefix "voiceActor.en"
    let ``voiceActorOf.en`` = _prefixId.prefix "voiceActorOf.en"

    let ``wholePartResourceRelationshipWith.en`` =
        _prefixId.prefix "wholePartResourceRelationshipWith.en"

    let ``writerOfAddedCommentary.en`` = _prefixId.prefix "writerOfAddedCommentary.en"

    let ``writerOfAddedCommentaryOf.en`` =
        _prefixId.prefix "writerOfAddedCommentaryOf.en"

    let ``writerOfAddedLyrics.en`` = _prefixId.prefix "writerOfAddedLyrics.en"
    let ``writerOfAddedLyricsOf.en`` = _prefixId.prefix "writerOfAddedLyricsOf.en"
    let ``writerOfAddedText.en`` = _prefixId.prefix "writerOfAddedText.en"
    let ``writerOfAddedTextOf.en`` = _prefixId.prefix "writerOfAddedTextOf.en"
    let ``writerOfAfterword.en`` = _prefixId.prefix "writerOfAfterword.en"
    let ``writerOfAfterwordOf.en`` = _prefixId.prefix "writerOfAfterwordOf.en"
    let ``writerOfForeword.en`` = _prefixId.prefix "writerOfForeword.en"
    let ``writerOfForewordOf.en`` = _prefixId.prefix "writerOfForewordOf.en"
    let ``writerOfIntroduction.en`` = _prefixId.prefix "writerOfIntroduction.en"
    let ``writerOfIntroductionOf.en`` = _prefixId.prefix "writerOfIntroductionOf.en"
    let ``writerOfPostface.en`` = _prefixId.prefix "writerOfPostface.en"
    let ``writerOfPostfaceOf.en`` = _prefixId.prefix "writerOfPostfaceOf.en"
    let ``writerOfPreface.en`` = _prefixId.prefix "writerOfPreface.en"
    let ``writerOfPrefaceOf.en`` = _prefixId.prefix "writerOfPrefaceOf.en"

    let ``writerOfSupplementaryTextualContent.en`` =
        _prefixId.prefix "writerOfSupplementaryTextualContent.en"

    let ``writerOfSupplementaryTextualContentOf.en`` =
        _prefixId.prefix "writerOfSupplementaryTextualContentOf.en"

    let ``yearDegreeGranted.en`` = _prefixId.prefix "yearDegreeGranted.en"
