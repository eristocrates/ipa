#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdae =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/e/" "rdae"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : has content type</para>
    ///   <para>skos:scopeNote : For content expressed in the form of an image or images, content type also reflects the number of spatial dimensions in which the content is intended to be perceived and the perceived presence or absence of movement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contentType</para>
    ///   <para>skos:definition : Relates an expression to a categorization reflecting the fundamental form of communication in which the content is expressed and the human sense through which it is intended to be perceived.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20001">rdae:P20001</a>
    /// </summary>
    let P20001 = _prefixId.prefix "P20001"
    /// <summary>
    ///   <para>skos:scopeNote : The identifier serves to differentiate that expression from other expressions.</para>
    ///   <para>rdfs:label : has identifier for the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheExpression</para>
    ///   <para>skos:definition : Relates an expression to a character string uniquely associated with an expression, or with a surrogate for an expression (e.g., an authority record).</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20002">rdae:P20002</a>
    /// </summary>
    let P20002 = _prefixId.prefix "P20002"
    /// <summary>
    ///   <para>skos:scopeNote : It serves to differentiate an expression from another expression of the same work.</para>
    ///   <para>rdfs:label : has other distinguishing characteristic of the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDistinguishingCharacteristicOfTheExpression</para>
    ///   <para>skos:definition : Relates an expression to a characteristic other than content type, language of expression, or date of expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20003">rdae:P20003</a>
    /// </summary>
    let P20003 = _prefixId.prefix "P20003"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a date or range of dates associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>rdfs:label : has date of capture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfCapture</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20004">rdae:P20004</a>
    /// </summary>
    let P20004 = _prefixId.prefix "P20004"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a formal recognition of excellence, etc., given by an award- or prize-granting body, for the content of a resource.</para>
    ///   <para>rdfs:label : has award</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : award</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20005">rdae:P20005</a>
    /// </summary>
    let P20005 = _prefixId.prefix "P20005"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a language in which a work is expressed.</para>
    ///   <para>rdfs:label : has language of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20006">rdae:P20006</a>
    /// </summary>
    let P20006 = _prefixId.prefix "P20006"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a language used to express the content of a resource.</para>
    ///   <para>rdfs:label : has language of the content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20007">rdae:P20007</a>
    /// </summary>
    let P20007 = _prefixId.prefix "P20007"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a listing of persons, families, or corporate bodies making contributions to the artistic and/or technical production of a resource.</para>
    ///   <para>rdfs:label : has artistic and/or technical credit</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artisticAndOrTechnicalCredit</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20008">rdae:P20008</a>
    /// </summary>
    let P20008 = _prefixId.prefix "P20008"
    /// <summary>
    ///   <para>rdfs:label : is adapted as motion picture (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureExpression</para>
    ///   <para>skos:definition : Relates an expression to a motion picture based on the source expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20009">rdae:P20009</a>
    /// </summary>
    let P20009 = _prefixId.prefix "P20009"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnChangesInContentCharacteristics</para>
    ///   <para>rdfs:label : has note on changes in content characteristics</para>
    ///   <para>skos:definition : Relates an expression to a note on changes in content characteristics that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20010">rdae:P20010</a>
    /// </summary>
    let P20010 = _prefixId.prefix "P20010"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a musical work by leading a performing group (orchestra, chorus, opera, etc.) in a musical or dramatic presentation, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : conductor</para>
    ///   <para>rdfs:label : has conductor</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20011">rdae:P20011</a>
    /// </summary>
    let P20011 = _prefixId.prefix "P20011"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : actor</para>
    ///   <para>rdfs:label : has actor</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by acting as a cast member or player in a musical or dramatic presentation, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20012">rdae:P20012</a>
    /// </summary>
    let P20012 = _prefixId.prefix "P20012"
    /// <summary>
    ///   <para>rdfs:label : has on-screen presenter</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenPresenter</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by appearing on screen to provide contextual or background information.</para>
    ///   <para>skos:scopeNote : An on-screen presenter may appear in nonfiction moving image materials or in introductions to fiction moving image materials.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20013">rdae:P20013</a>
    /// </summary>
    let P20013 = _prefixId.prefix "P20013"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by dancing in a musical, dramatic, etc., presentation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dancer</para>
    ///   <para>rdfs:label : has dancer</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20014">rdae:P20014</a>
    /// </summary>
    let P20014 = _prefixId.prefix "P20014"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by giving instruction or providing a demonstration.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : teacher</para>
    ///   <para>rdfs:label : has teacher</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20015">rdae:P20015</a>
    /// </summary>
    let P20015 = _prefixId.prefix "P20015"
    /// <summary>
    ///   <para>rdfs:label : has host</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by leading a program (often broadcast) that includes other guests, performers, etc. (e.g., talk show host).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : host</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20016">rdae:P20016</a>
    /// </summary>
    let P20016 = _prefixId.prefix "P20016"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by leading a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.</para>
    ///   <para>rdfs:label : has moderator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : moderator</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20017">rdae:P20017</a>
    /// </summary>
    let P20017 = _prefixId.prefix "P20017"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by manipulating, controlling, or directing puppets or marionettes in a moving image production or a musical or dramatic presentation or entertainment.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : puppeteer</para>
    ///   <para>rdfs:label : has puppeteer</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20018">rdae:P20018</a>
    /// </summary>
    let P20018 = _prefixId.prefix "P20018"
    /// <summary>
    ///   <para>rdfs:label : has panelist</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by participating in a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : panelist</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20019">rdae:P20019</a>
    /// </summary>
    let P20019 = _prefixId.prefix "P20019"
    /// <summary>
    ///   <para>rdfs:label : has instrumentalist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalist</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by playing a musical instrument.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20020">rdae:P20020</a>
    /// </summary>
    let P20020 = _prefixId.prefix "P20020"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by providing interpretation, analysis, or a discussion of the subject matter on a recording, film, or other audiovisual medium.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentator</para>
    ///   <para>rdfs:label : has commentator</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20021">rdae:P20021</a>
    /// </summary>
    let P20021 = _prefixId.prefix "P20021"
    /// <summary>
    ///   <para>rdfs:label : has narrator</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by reading or speaking in order to give an account of an act, occurrence, course of events, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : narrator</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20022">rdae:P20022</a>
    /// </summary>
    let P20022 = _prefixId.prefix "P20022"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by relaying a creator’s original story with dramatic or theatrical interpretation.</para>
    ///   <para>rdfs:label : has storyteller</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : storyteller</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20023">rdae:P20023</a>
    /// </summary>
    let P20023 = _prefixId.prefix "P20023"
    /// <summary>
    ///   <para>rdfs:label : has speaker</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by speaking words, such as a lecture, speech, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : speaker</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20024">rdae:P20024</a>
    /// </summary>
    let P20024 = _prefixId.prefix "P20024"
    /// <summary>
    ///   <para>skos:scopeNote : A singer’s performance may or may not include actual words.</para>
    ///   <para>rdfs:label : has singer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : singer</para>
    ///   <para>skos:definition : Relates an expression to a performer contributing to an expression of a work by using his/her/their voice, with or without instrumental accompaniment, to produce music.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20025">rdae:P20025</a>
    /// </summary>
    let P20025 = _prefixId.prefix "P20025"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression by adding music to a work that originally lacked it, by composing new music to substitute for the original music, or by composing new music to supplement the existing music.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerExpression</para>
    ///   <para>rdfs:label : has composer (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20026">rdae:P20026</a>
    /// </summary>
    let P20026 = _prefixId.prefix "P20026"
    /// <summary>
    ///   <para>rdfs:label : has surveyor</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a cartographic work by providing measurements or dimensional relationships for the geographic area represented.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : surveyor</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20027">rdae:P20027</a>
    /// </summary>
    let P20027 = _prefixId.prefix "P20027"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a moving image work or computer program by giving apparent movement to inanimate objects or drawings.</para>
    ///   <para>rdfs:label : has animator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : animator</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20028">rdae:P20028</a>
    /// </summary>
    let P20028 = _prefixId.prefix "P20028"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangerOfMusic</para>
    ///   <para>rdfs:label : has arranger of music</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a musical work by rewriting the composition for a medium of performance different from that for which the work was originally intended.</para>
    ///   <para>skos:scopeNote : An arranger of music may also modify the work for the same medium of performance, etc., keeping the musical substance of the original composition essentially unchanged.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20029">rdae:P20029</a>
    /// </summary>
    let P20029 = _prefixId.prefix "P20029"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a primarily non-textual work by providing text for the non-textual work (e.g., writing captions for photographs, descriptions of maps).</para>
    ///   <para>rdfs:label : has writer of added text</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedText</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20030">rdae:P20030</a>
    /// </summary>
    let P20030 = _prefixId.prefix "P20030"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a stage work through the general management and supervision of a performance.</para>
    ///   <para>rdfs:label : has stage director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stageDirector</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20031">rdae:P20031</a>
    /// </summary>
    let P20031 = _prefixId.prefix "P20031"
    /// <summary>
    ///   <para>rdfs:label : has interviewer (expression)</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by acting as an interviewer, reporter, pollster, or some other information gathering agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewerExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20032">rdae:P20032</a>
    /// </summary>
    let P20032 = _prefixId.prefix "P20032"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by an architect, inventor, etc., by making detailed plans or drawings for buildings, ships, aircraft, machines, objects, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : draftsman</para>
    ///   <para>rdfs:label : has draftsman</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20033">rdae:P20033</a>
    /// </summary>
    let P20033 = _prefixId.prefix "P20033"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transcriber</para>
    ///   <para>rdfs:label : has transcriber</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by changing it from one system of notation to another.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20034">rdae:P20034</a>
    /// </summary>
    let P20034 = _prefixId.prefix "P20034"
    /// <summary>
    ///   <para>rdfs:label : has musical director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalDirector</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by coordinating the activities of the composer, the sound editor, and sound mixers for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20035">rdae:P20035</a>
    /// </summary>
    let P20035 = _prefixId.prefix "P20035"
    /// <summary>
    ///   <para>rdfs:label : has costume designer</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by designing the costumes for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : costumeDesigner</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20036">rdae:P20036</a>
    /// </summary>
    let P20036 = _prefixId.prefix "P20036"
    /// <summary>
    ///   <para>skos:scopeNote : A translator may also translate a text from an older form of a language into the modern form.</para>
    ///   <para>rdfs:label : has translator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translator</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by expressing the original text of the work in a language different from that of the original work.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20037">rdae:P20037</a>
    /// </summary>
    let P20037 = _prefixId.prefix "P20037"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artDirector</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by overseeing the artists and craftspeople who build the sets for moving image productions.</para>
    ///   <para>rdfs:label : has art director</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20038">rdae:P20038</a>
    /// </summary>
    let P20038 = _prefixId.prefix "P20038"
    /// <summary>
    ///   <para>rdfs:label : has performer</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by performing music, acting, dancing, speaking, etc., often in a musical or dramatic presentation, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performer</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20039">rdae:P20039</a>
    /// </summary>
    let P20039 = _prefixId.prefix "P20039"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by preparing a court's opinions for publication.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtReporter</para>
    ///   <para>rdfs:label : has court reporter</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20040">rdae:P20040</a>
    /// </summary>
    let P20040 = _prefixId.prefix "P20040"
    /// <summary>
    ///   <para>rdfs:label : has writer of preface</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing a preface to the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPreface</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20041">rdae:P20041</a>
    /// </summary>
    let P20041 = _prefixId.prefix "P20041"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing additional cartography, or by modifying the previous cartography.</para>
    ///   <para>rdfs:label : has cartographer (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographerExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20042">rdae:P20042</a>
    /// </summary>
    let P20042 = _prefixId.prefix "P20042"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographerExpression</para>
    ///   <para>rdfs:label : has choreographer (expression)</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing additional choreography, or by modifying the previous choreography.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20043">rdae:P20043</a>
    /// </summary>
    let P20043 = _prefixId.prefix "P20043"
    /// <summary>
    ///   <para>rdfs:label : has writer of added commentary</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing an interpretation or critical explanation of the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedCommentary</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20044">rdae:P20044</a>
    /// </summary>
    let P20044 = _prefixId.prefix "P20044"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing an introduction to the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfIntroduction</para>
    ///   <para>rdfs:label : has writer of introduction</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20045">rdae:P20045</a>
    /// </summary>
    let P20045 = _prefixId.prefix "P20045"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing supplementary textual content (e.g., an appendix, an introduction, a preface) to the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfSupplementaryTextualContent</para>
    ///   <para>rdfs:label : has writer of supplementary textual content</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20046">rdae:P20046</a>
    /// </summary>
    let P20046 = _prefixId.prefix "P20046"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intervieweeExpression</para>
    ///   <para>rdfs:label : has interviewee (expression)</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20047">rdae:P20047</a>
    /// </summary>
    let P20047 = _prefixId.prefix "P20047"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by revising or clarifying the content, e.g., adding an introduction, notes, or other critical matter.</para>
    ///   <para>skos:scopeNote : An editor may also prepare an expression of a work for production, publication, or distribution.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editor</para>
    ///   <para>rdfs:label : has editor</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20048">rdae:P20048</a>
    /// </summary>
    let P20048 = _prefixId.prefix "P20048"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridger</para>
    ///   <para>rdfs:label : has abridger</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by shortening or condensing the original work but leaving the nature and content of the original work substantially unchanged.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20049">rdae:P20049</a>
    /// </summary>
    let P20049 = _prefixId.prefix "P20049"
    /// <summary>
    ///   <para>rdfs:label : has recording engineer</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by supervising the technical aspects of a sound or video recording session.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingEngineer</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20050">rdae:P20050</a>
    /// </summary>
    let P20050 = _prefixId.prefix "P20050"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by supplementing the primary content with drawings, diagrams, photographs, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrator</para>
    ///   <para>rdfs:label : has illustrator</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20051">rdae:P20051</a>
    /// </summary>
    let P20051 = _prefixId.prefix "P20051"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by using a recording device to capture sound and/or video during a recording session, including field recordings of natural sounds, folkloric events, music, etc.</para>
    ///   <para>rdfs:label : has recordist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordist</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20052">rdae:P20052</a>
    /// </summary>
    let P20052 = _prefixId.prefix "P20052"
    /// <summary>
    ///   <para>skos:scopeNote : Contributors include editors, translators, arrangers of music, performers, etc.</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression.</para>
    ///   <para>rdfs:label : has contributor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contributor</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20053">rdae:P20053</a>
    /// </summary>
    let P20053 = _prefixId.prefix "P20053"
    /// <summary>
    ///   <para>rdfs:label : has presenter</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presenter</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body mentioned in an "X presents" credit for moving image materials and who is probably associated with production, finance, or distribution in some way.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20054">rdae:P20054</a>
    /// </summary>
    let P20054 = _prefixId.prefix "P20054"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body responsible for assembling, arranging, and trimming film, video, or other moving image formats, including both visual and audio aspects.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfMovingImageWork</para>
    ///   <para>rdfs:label : has editor of moving image work</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20055">rdae:P20055</a>
    /// </summary>
    let P20055 = _prefixId.prefix "P20055"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionDesigner</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body responsible for designing the overall visual appearance of a moving image production.</para>
    ///   <para>rdfs:label : has production designer</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20056">rdae:P20056</a>
    /// </summary>
    let P20056 = _prefixId.prefix "P20056"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body responsible for performing, narrating, and/or presenting a work.</para>
    ///   <para>rdfs:label : has performer, narrator, and/or presenter</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performerNarratorAndOrPresenter</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20057">rdae:P20057</a>
    /// </summary>
    let P20057 = _prefixId.prefix "P20057"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : minuteTaker</para>
    ///   <para>rdfs:label : has minute taker</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body, responsible for recording the minutes of a meeting.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20058">rdae:P20058</a>
    /// </summary>
    let P20058 = _prefixId.prefix "P20058"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manifestationOfExpression</para>
    ///   <para>skos:definition : Relates an expression to a physical embodiment of an expression.</para>
    ///   <para>rdfs:label : has manifestation of expression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20059">rdae:P20059</a>
    /// </summary>
    let P20059 = _prefixId.prefix "P20059"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioProgramExpression</para>
    ///   <para>rdfs:label : is adapted as radio program (expression)</para>
    ///   <para>skos:definition : Relates an expression to a radio program based on the source expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20060">rdae:P20060</a>
    /// </summary>
    let P20060 = _prefixId.prefix "P20060"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfTactileNotation</para>
    ///   <para>skos:definition : Relates an expression to a set of characters and/or symbols used to express the content of a resource in a form that can be perceived through touch.</para>
    ///   <para>rdfs:label : has form of tactile notation</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20061">rdae:P20061</a>
    /// </summary>
    let P20061 = _prefixId.prefix "P20061"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a set of characters and/or symbols used to express the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotation</para>
    ///   <para>rdfs:label : has form of notation</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20062">rdae:P20062</a>
    /// </summary>
    let P20062 = _prefixId.prefix "P20062"
    /// <summary>
    ///   <para>rdfs:label : has form of notated movement</para>
    ///   <para>skos:definition : Relates an expression to a set of characters and/or symbols used to express the movement content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotatedMovement</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20063">rdae:P20063</a>
    /// </summary>
    let P20063 = _prefixId.prefix "P20063"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a set of characters and/or symbols used to express the musical content of a resource.</para>
    ///   <para>rdfs:label : has form of musical notation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfMusicalNotation</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20064">rdae:P20064</a>
    /// </summary>
    let P20064 = _prefixId.prefix "P20064"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : script</para>
    ///   <para>skos:definition : Relates an expression to a set of characters and/or symbols used to express the written language content of a resource.</para>
    ///   <para>rdfs:label : has script</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20065">rdae:P20065</a>
    /// </summary>
    let P20065 = _prefixId.prefix "P20065"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionProgramExpression</para>
    ///   <para>skos:definition : Relates an expression to a television program based on the source expression.</para>
    ///   <para>rdfs:label : is adapted as television program (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20066">rdae:P20066</a>
    /// </summary>
    let P20066 = _prefixId.prefix "P20066"
    /// <summary>
    ///   <para>rdfs:label : is adapted as video (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoProgramExpression</para>
    ///   <para>skos:definition : Relates an expression to a video based on the source expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20067">rdae:P20067</a>
    /// </summary>
    let P20067 = _prefixId.prefix "P20067"
    /// <summary>
    ///   <para>rdfs:label : has writer of added lyrics</para>
    ///   <para>skos:definition : Relates an expression to a writer of words added to an expression of a musical work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedLyrics</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20068">rdae:P20068</a>
    /// </summary>
    let P20068 = _prefixId.prefix "P20068"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an abstract, summary, synopsis, etc., of the content of a resource.</para>
    ///   <para>rdfs:label : has summarization of the content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summarizationOfTheContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20069">rdae:P20069</a>
    /// </summary>
    let P20069 = _prefixId.prefix "P20069"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an actor contributing to an expression of a work by providing the voice for characters in radio and audio productions and for animated characters in moving image works, as well as by providing voice-overs in radio and television commercials, dubbed resources, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : voiceActor</para>
    ///   <para>rdfs:label : has voice actor</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20070">rdae:P20070</a>
    /// </summary>
    let P20070 = _prefixId.prefix "P20070"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an annotation providing additional information about content recorded as an expression attribute.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnExpression</para>
    ///   <para>rdfs:label : has note on expression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20071">rdae:P20071</a>
    /// </summary>
    let P20071 = _prefixId.prefix "P20071"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression described by an expression of a describing work.</para>
    ///   <para>rdfs:label : is description of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20072">rdae:P20072</a>
    /// </summary>
    let P20072 = _prefixId.prefix "P20072"
    /// <summary>
    ///   <para>rdfs:label : is dramatized as (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a dramatic work adapted from the source expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizedAsExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20073">rdae:P20073</a>
    /// </summary>
    let P20073 = _prefixId.prefix "P20073"
    /// <summary>
    ///   <para>rdfs:label : is contained in (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a larger work of which the expression is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20074">rdae:P20074</a>
    /// </summary>
    let P20074 = _prefixId.prefix "P20074"
    /// <summary>
    ///   <para>rdfs:label : is replaced in part by (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacedInPartByExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a later work used in part in place of the earlier expression, usually because the later work contains updated or new information that makes part of the earlier expression obsolete.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20075">rdae:P20075</a>
    /// </summary>
    let P20075 = _prefixId.prefix "P20075"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacedByExpression</para>
    ///   <para>rdfs:label : is replaced by (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a later work used in place of the earlier expression, usually because the later work contains updated or new information that makes the earlier expression obsolete.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20076">rdae:P20076</a>
    /// </summary>
    let P20076 = _prefixId.prefix "P20076"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a literary composition in verse form adapted from the source expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationExpression</para>
    ///   <para>rdfs:label : is verse adaptation (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20077">rdae:P20077</a>
    /// </summary>
    let P20077 = _prefixId.prefix "P20077"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a moving image work in which the spoken dialogue has been translated into a language different from that of the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dubbedVersionOf</para>
    ///   <para>rdfs:label : is dubbed version of</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20078">rdae:P20078</a>
    /// </summary>
    let P20078 = _prefixId.prefix "P20078"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a moving image work that translates the spoken dialogue of the original work into a different language.</para>
    ///   <para>rdfs:label : is dubbed version</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dubbedVersion</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20079">rdae:P20079</a>
    /// </summary>
    let P20079 = _prefixId.prefix "P20079"
    /// <summary>
    ///   <para>rdfs:label : is cadenza (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work consisting of an ornamental passage for a soloist, added to a musical work such as a concerto, either by the same or a different composer.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20080">rdae:P20080</a>
    /// </summary>
    let P20080 = _prefixId.prefix "P20080"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsBasedOnExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work from which melodic, thematic, or harmonic material is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>rdfs:label : is musical variations based on (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20081">rdae:P20081</a>
    /// </summary>
    let P20081 = _prefixId.prefix "P20081"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsExpression</para>
    ///   <para>rdfs:label : is musical variations (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work in which melodic, thematic, or harmonic material is taken from the source work to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20082">rdae:P20082</a>
    /// </summary>
    let P20082 = _prefixId.prefix "P20082"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaComposedForExpression</para>
    ///   <para>rdfs:label : is cadenza composed for (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work such as a concerto for which an ornamental passage for a soloist has been composed, either by the same or a different composer.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20083">rdae:P20083</a>
    /// </summary>
    let P20083 = _prefixId.prefix "P20083"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoForExpression</para>
    ///   <para>rdfs:label : is libretto for (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work such as an opera or other work for the musical stage, or an oratorio, that uses the text of the related work.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20084">rdae:P20084</a>
    /// </summary>
    let P20084 = _prefixId.prefix "P20084"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work that that provides the incidental music for a play or other spoken work for the stage.</para>
    ///   <para>rdfs:label : is incidental music (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incidentalMusicExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20085">rdae:P20085</a>
    /// </summary>
    let P20085 = _prefixId.prefix "P20085"
    /// <summary>
    ///   <para>rdfs:label : is remade as (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a new motion picture, radio program, television program, or video based on an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remadeAsExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20086">rdae:P20086</a>
    /// </summary>
    let P20086 = _prefixId.prefix "P20086"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingExpression</para>
    ///   <para>rdfs:label : is musical setting (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a non-dramatic musical work, other than an oratorio, that uses the text of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20087">rdae:P20087</a>
    /// </summary>
    let P20087 = _prefixId.prefix "P20087"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a novel adapted from the source expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationExpression</para>
    ///   <para>rdfs:label : is novelization (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20088">rdae:P20088</a>
    /// </summary>
    let P20088 = _prefixId.prefix "P20088"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixToExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a predominant work that is augmented by another work that consists of material that is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; the augmenting work can either come at the end of the content, or be issued separately.</para>
    ///   <para>rdfs:label : is appendix to (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20089">rdae:P20089</a>
    /// </summary>
    let P20089 = _prefixId.prefix "P20089"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work (an abstracting and indexing service) that abstracts the contents of a source expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedInExpression</para>
    ///   <para>rdfs:label : is abstracted in (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20090">rdae:P20090</a>
    /// </summary>
    let P20090 = _prefixId.prefix "P20090"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexedInExpression</para>
    ///   <para>rdfs:label : is indexed in (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work (an abstracting and indexing service) that indexes the contents of a source expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20091">rdae:P20091</a>
    /// </summary>
    let P20091 = _prefixId.prefix "P20091"
    /// <summary>
    ///   <para>rdfs:label : is choreography (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of dance based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20092">rdae:P20092</a>
    /// </summary>
    let P20092 = _prefixId.prefix "P20092"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataExpression</para>
    ///   <para>rdfs:label : is errata (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of errors discovered after the publication of the predominant work, with their corrections.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20093">rdae:P20093</a>
    /// </summary>
    let P20093 = _prefixId.prefix "P20093"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of pictorial content designed to explain or decorate the augmented expression.</para>
    ///   <para>rdfs:label : is illustrations (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20094">rdae:P20094</a>
    /// </summary>
    let P20094 = _prefixId.prefix "P20094"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of the screenplay for a motion picture, based on the source work.</para>
    ///   <para>rdfs:label : is adapted as motion picture screenplay (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureScreenplayExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20095">rdae:P20095</a>
    /// </summary>
    let P20095 = _prefixId.prefix "P20095"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of the screenplay for a motion picture, television program, or video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAScreenplayExpression</para>
    ///   <para>rdfs:label : is adapted as screenplay (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20096">rdae:P20096</a>
    /// </summary>
    let P20096 = _prefixId.prefix "P20096"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of the screenplay for a television program, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionScreenplayExpression</para>
    ///   <para>rdfs:label : is adapted as television screenplay (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20097">rdae:P20097</a>
    /// </summary>
    let P20097 = _prefixId.prefix "P20097"
    /// <summary>
    ///   <para>rdfs:label : is adapted as video screenplay (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of the screenplay for a video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoScreenplayExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20098">rdae:P20098</a>
    /// </summary>
    let P20098 = _prefixId.prefix "P20098"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioScriptExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work consisting of the script for a radio program, based on the source work.</para>
    ///   <para>rdfs:label : is adapted as radio script (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20099">rdae:P20099</a>
    /// </summary>
    let P20099 = _prefixId.prefix "P20099"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementedByExpression</para>
    ///   <para>rdfs:label : is complemented by (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work paired with another expression without either expression being considered to predominate.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20100">rdae:P20100</a>
    /// </summary>
    let P20100 = _prefixId.prefix "P20100"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work part of whose content separated from an earlier expression to form a new expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedInPartByExpression</para>
    ///   <para>rdfs:label : is continued in part by (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20101">rdae:P20101</a>
    /// </summary>
    let P20101 = _prefixId.prefix "P20101"
    /// <summary>
    ///   <para>rdfs:label : is screenplay for (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work such as a motion picture, television program, or video, that uses the text of the work as a screenplay.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20102">rdae:P20102</a>
    /// </summary>
    let P20102 = _prefixId.prefix "P20102"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incidentalMusicForExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work such as a play or other spoken work for the stage that uses the musical work as incidental music.</para>
    ///   <para>rdfs:label : is incidental music for (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20103">rdae:P20103</a>
    /// </summary>
    let P20103 = _prefixId.prefix "P20103"
    /// <summary>
    ///   <para>rdfs:label : is abstract (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that abbreviates the source expression in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20104">rdae:P20104</a>
    /// </summary>
    let P20104 = _prefixId.prefix "P20104"
    /// <summary>
    ///   <para>rdfs:label : is augmented by (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that adds to the content of a predominant expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentedByExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20105">rdae:P20105</a>
    /// </summary>
    let P20105 = _prefixId.prefix "P20105"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that consists of a brief recapitulation of the content of the source expression.</para>
    ///   <para>rdfs:label : is summary (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20106">rdae:P20106</a>
    /// </summary>
    let P20106 = _prefixId.prefix "P20106"
    /// <summary>
    ///   <para>rdfs:label : is catalogue (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that consists of a complete enumeration of items arranged systematically.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20107">rdae:P20107</a>
    /// </summary>
    let P20107 = _prefixId.prefix "P20107"
    /// <summary>
    ///   <para>rdfs:label : is concordance (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that consists of an index of all the words in the predominant expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20108">rdae:P20108</a>
    /// </summary>
    let P20108 = _prefixId.prefix "P20108"
    /// <summary>
    ///   <para>rdfs:label : is addenda (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that consists of brief additional material, less extensive than a supplement, but essential to the completeness of the text of the predominant work; it is usually added at the end of the content, but is sometimes issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20109">rdae:P20109</a>
    /// </summary>
    let P20109 = _prefixId.prefix "P20109"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that consists of the text of an opera or other work for the musical stage, or an oratorio, based on the source work.</para>
    ///   <para>rdfs:label : is basis for libretto (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basisForLibrettoExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20110">rdae:P20110</a>
    /// </summary>
    let P20110 = _prefixId.prefix "P20110"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that contains a brief evaluation of the described expression.</para>
    ///   <para>rdfs:label : is reviewed in (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedInExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20111">rdae:P20111</a>
    /// </summary>
    let P20111 = _prefixId.prefix "P20111"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that contains a critical evaluation of the described expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedInExpression</para>
    ///   <para>rdfs:label : is critiqued in (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20112">rdae:P20112</a>
    /// </summary>
    let P20112 = _prefixId.prefix "P20112"
    /// <summary>
    ///   <para>rdfs:label : is commentary in (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that contains a set of explanatory or critical notes on the described expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryInExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20113">rdae:P20113</a>
    /// </summary>
    let P20113 = _prefixId.prefix "P20113"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that copies the style or content of the source work.</para>
    ///   <para>rdfs:label : is imitated as (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitatedAsExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20114">rdae:P20114</a>
    /// </summary>
    let P20114 = _prefixId.prefix "P20114"
    /// <summary>
    ///   <para>rdfs:label : is expanded as (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedAsExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that enlarges upon the content of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20115">rdae:P20115</a>
    /// </summary>
    let P20115 = _prefixId.prefix "P20115"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that examines or judges the described expression.</para>
    ///   <para>rdfs:label : is evaluated in (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedInExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20116">rdae:P20116</a>
    /// </summary>
    let P20116 = _prefixId.prefix "P20116"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that examines the source expression to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedInExpression</para>
    ///   <para>rdfs:label : is analysed in (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20117">rdae:P20117</a>
    /// </summary>
    let P20117 = _prefixId.prefix "P20117"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that forms an augmenting part of another work which is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; it can be material which either comes at the end of the content of the predominant work, or is issued separately.</para>
    ///   <para>rdfs:label : is appendix (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20118">rdae:P20118</a>
    /// </summary>
    let P20118 = _prefixId.prefix "P20118"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that freely translates the text into another language, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>rdfs:label : is freely translated as (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freelyTranslatedAsExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20119">rdae:P20119</a>
    /// </summary>
    let P20119 = _prefixId.prefix "P20119"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that guides a user through the use of the predominant work, using notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideExpression</para>
    ///   <para>rdfs:label : is guide (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20120">rdae:P20120</a>
    /// </summary>
    let P20120 = _prefixId.prefix "P20120"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been abridged, i.e., shortened without changing the general meaning or manner of presentation of the source work.</para>
    ///   <para>rdfs:label : is abridgement of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgementOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20121">rdae:P20121</a>
    /// </summary>
    let P20121 = _prefixId.prefix "P20121"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been abstracted, i.e., abbreviated in a brief, objective manner.</para>
    ///   <para>rdfs:label : is abstract of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20122">rdae:P20122</a>
    /// </summary>
    let P20122 = _prefixId.prefix "P20122"
    /// <summary>
    ///   <para>rdfs:label : is dramatization of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizationOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a drama.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20123">rdae:P20123</a>
    /// </summary>
    let P20123 = _prefixId.prefix "P20123"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a literary composition in verse form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationOfExpression</para>
    ///   <para>rdfs:label : is verse adaptation of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20124">rdae:P20124</a>
    /// </summary>
    let P20124 = _prefixId.prefix "P20124"
    /// <summary>
    ///   <para>rdfs:label : is motion picture adaptation of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureAdaptationOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20125">rdae:P20125</a>
    /// </summary>
    let P20125 = _prefixId.prefix "P20125"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a novel.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationOfExpression</para>
    ///   <para>rdfs:label : is novelization of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20126">rdae:P20126</a>
    /// </summary>
    let P20126 = _prefixId.prefix "P20126"
    /// <summary>
    ///   <para>rdfs:label : is radio adaptation of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioAdaptationOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20127">rdae:P20127</a>
    /// </summary>
    let P20127 = _prefixId.prefix "P20127"
    /// <summary>
    ///   <para>rdfs:label : is television adaptation of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionAdaptationOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20128">rdae:P20128</a>
    /// </summary>
    let P20128 = _prefixId.prefix "P20128"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as the screenplay for a motion picture, television program, or video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayBasedOnExpression</para>
    ///   <para>rdfs:label : is screenplay based on (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20129">rdae:P20129</a>
    /// </summary>
    let P20129 = _prefixId.prefix "P20129"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as the screenplay for a motion picture.</para>
    ///   <para>rdfs:label : is motion picture screenplay based on (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayBasedOnExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20130">rdae:P20130</a>
    /// </summary>
    let P20130 = _prefixId.prefix "P20130"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayBasedOnExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as the screenplay for a television program.</para>
    ///   <para>rdfs:label : is television screenplay based on (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20131">rdae:P20131</a>
    /// </summary>
    let P20131 = _prefixId.prefix "P20131"
    /// <summary>
    ///   <para>rdfs:label : is video screenplay based on (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as the screenplay for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayBasedOnExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20132">rdae:P20132</a>
    /// </summary>
    let P20132 = _prefixId.prefix "P20132"
    /// <summary>
    ///   <para>rdfs:label : is radio script based on (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as the script for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptBasedOnExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20133">rdae:P20133</a>
    /// </summary>
    let P20133 = _prefixId.prefix "P20133"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted for video.</para>
    ///   <para>rdfs:label : is video adaptation of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoAdaptationOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20134">rdae:P20134</a>
    /// </summary>
    let P20134 = _prefixId.prefix "P20134"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been digested, i.e., systematically and comprehensively condensed.</para>
    ///   <para>rdfs:label : is digest of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20135">rdae:P20135</a>
    /// </summary>
    let P20135 = _prefixId.prefix "P20135"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfExpression</para>
    ///   <para>rdfs:label : is analysis of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20136">rdae:P20136</a>
    /// </summary>
    let P20136 = _prefixId.prefix "P20136"
    /// <summary>
    ///   <para>rdfs:label : is absorption of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been incorporated into another expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorptionOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20137">rdae:P20137</a>
    /// </summary>
    let P20137 = _prefixId.prefix "P20137"
    /// <summary>
    ///   <para>rdfs:label : is absorption in part of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been partially incorporated into another expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorptionInPartOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20138">rdae:P20138</a>
    /// </summary>
    let P20138 = _prefixId.prefix "P20138"
    /// <summary>
    ///   <para>rdfs:label : is musical arrangement of</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been rewritten for a medium of performance different from that for which the work was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalArrangementOf</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20139">rdae:P20139</a>
    /// </summary>
    let P20139 = _prefixId.prefix "P20139"
    /// <summary>
    ///   <para>rdfs:label : is free translation of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freeTranslationOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been translated freely, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20140">rdae:P20140</a>
    /// </summary>
    let P20140 = _prefixId.prefix "P20140"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been translated, i.e., the text expressed in a language different from that of the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translationOf</para>
    ///   <para>rdfs:label : is translation of</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20141">rdae:P20141</a>
    /// </summary>
    let P20141 = _prefixId.prefix "P20141"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodiedAsExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that imitates the style or content of the source work for comic effect.</para>
    ///   <para>rdfs:label : is parodied as (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20142">rdae:P20142</a>
    /// </summary>
    let P20142 = _prefixId.prefix "P20142"
    /// <summary>
    ///   <para>rdfs:label : is absorbed by (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that incorporates another expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedByExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20143">rdae:P20143</a>
    /// </summary>
    let P20143 = _prefixId.prefix "P20143"
    /// <summary>
    ///   <para>rdfs:label : is absorbed in part by (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartByExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that incorporates part of the content of another expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20144">rdae:P20144</a>
    /// </summary>
    let P20144 = _prefixId.prefix "P20144"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containerOfExpression</para>
    ///   <para>rdfs:label : is container of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is a discrete component of a larger expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20145">rdae:P20145</a>
    /// </summary>
    let P20145 = _prefixId.prefix "P20145"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataToExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is augmented by a list of errors in the predominant work, discovered after publication, with their corrections.</para>
    ///   <para>rdfs:label : is errata to (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20146">rdae:P20146</a>
    /// </summary>
    let P20146 = _prefixId.prefix "P20146"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is augmented by another work consisting of material to help the user of the predominant work, such as notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>rdfs:label : is guide to (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideToExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20147">rdae:P20147</a>
    /// </summary>
    let P20147 = _prefixId.prefix "P20147"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is augmented by pictorial content designed to explain or decorate it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsForExpression</para>
    ///   <para>rdfs:label : is illustrations for (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20148">rdae:P20148</a>
    /// </summary>
    let P20148 = _prefixId.prefix "P20148"
    /// <summary>
    ///   <para>rdfs:label : is continuation of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is continued by the content of an expression of a later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuationOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20149">rdae:P20149</a>
    /// </summary>
    let P20149 = _prefixId.prefix "P20149"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is examined or judged.</para>
    ///   <para>rdfs:label : is evaluation of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20150">rdae:P20150</a>
    /// </summary>
    let P20150 = _prefixId.prefix "P20150"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is updated or otherwise complemented by the augmenting expression.</para>
    ///   <para>rdfs:label : is supplement to (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementToExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20151">rdae:P20151</a>
    /// </summary>
    let P20151 = _prefixId.prefix "P20151"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that modifies the source expression for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptationOfExpression</para>
    ///   <para>rdfs:label : is adaptation of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20152">rdae:P20152</a>
    /// </summary>
    let P20152 = _prefixId.prefix "P20152"
    /// <summary>
    ///   <para>rdfs:label : is adapted as (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work based on the source expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20153">rdae:P20153</a>
    /// </summary>
    let P20153 = _prefixId.prefix "P20153"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that precedes (e.g., is earlier in time or before in narrative) the succeeding expression.</para>
    ///   <para>rdfs:label : is preceded by (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : precededByExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20154">rdae:P20154</a>
    /// </summary>
    let P20154 = _prefixId.prefix "P20154"
    /// <summary>
    ///   <para>rdfs:label : is finding aid (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides a guide to the organization, arrangement, and contents of an archival collection.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20155">rdae:P20155</a>
    /// </summary>
    let P20155 = _prefixId.prefix "P20155"
    /// <summary>
    ///   <para>rdfs:label : is index (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides a systematic, alphabetical guide to the contents of the predominant expression, usually keyed to page numbers or other reference codes.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20156">rdae:P20156</a>
    /// </summary>
    let P20156 = _prefixId.prefix "P20156"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text for a motion picture, television program or video.</para>
    ///   <para>rdfs:label : is screenplay (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20157">rdae:P20157</a>
    /// </summary>
    let P20157 = _prefixId.prefix "P20157"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text for a motion picture.</para>
    ///   <para>rdfs:label : is motion picture screenplay (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20158">rdae:P20158</a>
    /// </summary>
    let P20158 = _prefixId.prefix "P20158"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingOfExpression</para>
    ///   <para>rdfs:label : is musical setting of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text for a non-dramatic musical work, other than an oratorio.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20159">rdae:P20159</a>
    /// </summary>
    let P20159 = _prefixId.prefix "P20159"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text for a radio program.</para>
    ///   <para>rdfs:label : is radio script (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20160">rdae:P20160</a>
    /// </summary>
    let P20160 = _prefixId.prefix "P20160"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayExpression</para>
    ///   <para>rdfs:label : is television screenplay (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text for a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20161">rdae:P20161</a>
    /// </summary>
    let P20161 = _prefixId.prefix "P20161"
    /// <summary>
    ///   <para>rdfs:label : is video screenplay (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20162">rdae:P20162</a>
    /// </summary>
    let P20162 = _prefixId.prefix "P20162"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that provides the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>rdfs:label : is libretto (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20163">rdae:P20163</a>
    /// </summary>
    let P20163 = _prefixId.prefix "P20163"
    /// <summary>
    ///   <para>rdfs:label : is paraphrased as (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that restates the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphrasedAsExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20164">rdae:P20164</a>
    /// </summary>
    let P20164 = _prefixId.prefix "P20164"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that rewrites the source expression for a medium of performance different from that for which the work was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalArrangement</para>
    ///   <para>rdfs:label : is musical arrangement</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20165">rdae:P20165</a>
    /// </summary>
    let P20165 = _prefixId.prefix "P20165"
    /// <summary>
    ///   <para>rdfs:label : is abridged as (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgedAsExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that shortens the source expression without changing the general meaning or manner of presentation.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20166">rdae:P20166</a>
    /// </summary>
    let P20166 = _prefixId.prefix "P20166"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that split into two or more separate expressions with new titles.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuationInPartOfExpression</para>
    ///   <para>rdfs:label : is continuation in part of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20167">rdae:P20167</a>
    /// </summary>
    let P20167 = _prefixId.prefix "P20167"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that spun off a part of its content to form a new expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : separatedFromExpression</para>
    ///   <para>rdfs:label : is separated from (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20168">rdae:P20168</a>
    /// </summary>
    let P20168 = _prefixId.prefix "P20168"
    /// <summary>
    ///   <para>rdfs:label : is succeeded by (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : succeededByExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that succeeds (e.g., later in time or after in a narrative) the preceding expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20169">rdae:P20169</a>
    /// </summary>
    let P20169 = _prefixId.prefix "P20169"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that systematically and comprehensively condenses the source expression.</para>
    ///   <para>rdfs:label : is digest (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20170">rdae:P20170</a>
    /// </summary>
    let P20170 = _prefixId.prefix "P20170"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that translates the text of the source expression into a language different from that of the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatedAs</para>
    ///   <para>rdfs:label : is translated as</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20171">rdae:P20171</a>
    /// </summary>
    let P20171 = _prefixId.prefix "P20171"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementExpression</para>
    ///   <para>rdfs:label : is supplement (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that updates or otherwise complements the predominant expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20172">rdae:P20172</a>
    /// </summary>
    let P20172 = _prefixId.prefix "P20172"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the text as a screenplay for a motion picture.</para>
    ///   <para>rdfs:label : is screenplay for motion picture (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheMotionPictureExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20173">rdae:P20173</a>
    /// </summary>
    let P20173 = _prefixId.prefix "P20173"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheTelevisionProgramExpression</para>
    ///   <para>rdfs:label : is screenplay for television program (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the text as a screenplay for a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20174">rdae:P20174</a>
    /// </summary>
    let P20174 = _prefixId.prefix "P20174"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheVideoExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the text as a screenplay for a video.</para>
    ///   <para>rdfs:label : is screenplay for video (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20175">rdae:P20175</a>
    /// </summary>
    let P20175 = _prefixId.prefix "P20175"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the text of the source work as the script for a radio program.</para>
    ///   <para>rdfs:label : is script for radio program (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptForTheRadioProgramExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20176">rdae:P20176</a>
    /// </summary>
    let P20176 = _prefixId.prefix "P20176"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work to which is added brief additional material, less extensive than a supplement, but essential to the completeness of the content of the work; it is usually added at the end of the content but is sometimes issued separately from it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaToExpression</para>
    ///   <para>rdfs:label : is addenda to (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20177">rdae:P20177</a>
    /// </summary>
    let P20177 = _prefixId.prefix "P20177"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a brief evaluation.</para>
    ///   <para>rdfs:label : is review of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20178">rdae:P20178</a>
    /// </summary>
    let P20178 = _prefixId.prefix "P20178"
    /// <summary>
    ///   <para>rdfs:label : is summary of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a brief recapitulation of its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20179">rdae:P20179</a>
    /// </summary>
    let P20179 = _prefixId.prefix "P20179"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueOfExpression</para>
    ///   <para>rdfs:label : is catalogue of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a catalogue, i.e., a complete enumeration of items arranged systematically.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20180">rdae:P20180</a>
    /// </summary>
    let P20180 = _prefixId.prefix "P20180"
    /// <summary>
    ///   <para>rdfs:label : is concordance to (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a concordance, i.e., an index of all the words in the predominant expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceToExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20181">rdae:P20181</a>
    /// </summary>
    let P20181 = _prefixId.prefix "P20181"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a critical evaluation.</para>
    ///   <para>rdfs:label : is critique of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20182">rdae:P20182</a>
    /// </summary>
    let P20182 = _prefixId.prefix "P20182"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyForExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a derivative work consisting of dance.</para>
    ///   <para>rdfs:label : is choreography for (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20183">rdae:P20183</a>
    /// </summary>
    let P20183 = _prefixId.prefix "P20183"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedVersionOfExpression</para>
    ///   <para>rdfs:label : is expanded version of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a derivative work that enlarges upon the content of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20184">rdae:P20184</a>
    /// </summary>
    let P20184 = _prefixId.prefix "P20184"
    /// <summary>
    ///   <para>rdfs:label : is remake of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remakeOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a new motion picture, radio program, television program, or video.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20185">rdae:P20185</a>
    /// </summary>
    let P20185 = _prefixId.prefix "P20185"
    /// <summary>
    ///   <para>rdfs:label : is paraphrase of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphraseOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a paraphrase, i.e., a restating of the content of the source work in a different form.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20186">rdae:P20186</a>
    /// </summary>
    let P20186 = _prefixId.prefix "P20186"
    /// <summary>
    ///   <para>rdfs:label : is commentary on (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for a set of explanatory or critical notes.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20187">rdae:P20187</a>
    /// </summary>
    let P20187 = _prefixId.prefix "P20187"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for an index, i.e., a systematic, alphabetical guide to the contents of the predominant expression, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexToExpression</para>
    ///   <para>rdfs:label : is index to (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20188">rdae:P20188</a>
    /// </summary>
    let P20188 = _prefixId.prefix "P20188"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for an updated, corrected, or expanded version.</para>
    ///   <para>rdfs:label : is revision of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : revisionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20189">rdae:P20189</a>
    /// </summary>
    let P20189 = _prefixId.prefix "P20189"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoBasedOnExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work used as the basis for the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>rdfs:label : is libretto based on (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20190">rdae:P20190</a>
    /// </summary>
    let P20190 = _prefixId.prefix "P20190"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work whose content continues an expression of an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedByExpression</para>
    ///   <para>rdfs:label : is continued by (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20191">rdae:P20191</a>
    /// </summary>
    let P20191 = _prefixId.prefix "P20191"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work whose content is added to by another expression.</para>
    ///   <para>rdfs:label : is augmentation of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentationOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20192">rdae:P20192</a>
    /// </summary>
    let P20192 = _prefixId.prefix "P20192"
    /// <summary>
    ///   <para>rdfs:label : is abstracts for (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractsForExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work whose contents have been abstracted by an abstracting and indexing service.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20193">rdae:P20193</a>
    /// </summary>
    let P20193 = _prefixId.prefix "P20193"
    /// <summary>
    ///   <para>rdfs:label : is indexing for (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work whose contents have been indexed by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexingForExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20194">rdae:P20194</a>
    /// </summary>
    let P20194 = _prefixId.prefix "P20194"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work whose style or content is copied in a derivative work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitationOfExpression</para>
    ///   <para>rdfs:label : is imitation of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20195">rdae:P20195</a>
    /// </summary>
    let P20195 = _prefixId.prefix "P20195"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodyOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work whose style or content is imitated for comic effect.</para>
    ///   <para>rdfs:label : is parody of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20196">rdae:P20196</a>
    /// </summary>
    let P20196 = _prefixId.prefix "P20196"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of an archival collection that is described in a finding aid, i.e., a guide to the organization, arrangement, and contents of the collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidForExpression</para>
    ///   <para>rdfs:label : is finding aid for (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20197">rdae:P20197</a>
    /// </summary>
    let P20197 = _prefixId.prefix "P20197"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of an earlier work whose content has been partially replaced by a later expression, usually because the later work contains updated or new information that makes the earlier expression obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacementInPartOfExpression</para>
    ///   <para>rdfs:label : is replacement in part of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20198">rdae:P20198</a>
    /// </summary>
    let P20198 = _prefixId.prefix "P20198"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacementOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of an earlier work whose content has been replaced by a later expression, usually because the later work contains updated or new information that makes the earlier expression obsolete.</para>
    ///   <para>rdfs:label : is replacement of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20199">rdae:P20199</a>
    /// </summary>
    let P20199 = _prefixId.prefix "P20199"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : splitIntoExpression</para>
    ///   <para>rdfs:label : is split into (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of one of two or more works resulting from the division of an earlier expression into separate expressions.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20200">rdae:P20200</a>
    /// </summary>
    let P20200 = _prefixId.prefix "P20200"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergerOfExpression</para>
    ///   <para>rdfs:label : is merger of (expression)</para>
    ///   <para>skos:definition : Relates an expression to one of the expressions which come together to form the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20201">rdae:P20201</a>
    /// </summary>
    let P20201 = _prefixId.prefix "P20201"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedInExpression</para>
    ///   <para>rdfs:label : is described in (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that describes an expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20202">rdae:P20202</a>
    /// </summary>
    let P20202 = _prefixId.prefix "P20202"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression that is a modification of a source expression.</para>
    ///   <para>rdfs:label : is derivative (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20203">rdae:P20203</a>
    /// </summary>
    let P20203 = _prefixId.prefix "P20203"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression used as the basis for a derivative expression.</para>
    ///   <para>rdfs:label : is based on (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basedOnExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20204">rdae:P20204</a>
    /// </summary>
    let P20204 = _prefixId.prefix "P20204"
    /// <summary>
    ///   <para>rdfs:label : has related expression</para>
    ///   <para>skos:definition : Relates an expression to an expression, represented by an identifier, an authorized access point, or a description, that is related to the expression being described (e.g., a revised version, a translation).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20205">rdae:P20205</a>
    /// </summary>
    let P20205 = _prefixId.prefix "P20205"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to content (e.g., an index, a bibliography, an appendix) designed to supplement the primary content of a resource.</para>
    ///   <para>rdfs:label : has supplementary content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementaryContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20206">rdae:P20206</a>
    /// </summary>
    let P20206 = _prefixId.prefix "P20206"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to content designed to illustrate the primary content of a resource.</para>
    ///   <para>rdfs:label : has illustrative content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrativeContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20207">rdae:P20207</a>
    /// </summary>
    let P20207 = _prefixId.prefix "P20207"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to content that assists those with a sensory impairment in the greater understanding of content which their impairment prevents them fully seeing or hearing.</para>
    ///   <para>rdfs:label : has accessibility content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accessibilityContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20208">rdae:P20208</a>
    /// </summary>
    let P20208 = _prefixId.prefix "P20208"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to format of notated music is the musical or physical layout of the content of a resource that is presented in the form of musical notation.</para>
    ///   <para>rdfs:label : has format of notated music</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formatOfNotatedMusic</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20209">rdae:P20209</a>
    /// </summary>
    let P20209 = _prefixId.prefix "P20209"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to mathematical data and other features of the cartographic content of a resource not recorded in statements of scale, projection, and coordinates.</para>
    ///   <para>rdfs:label : has other details of cartographic content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDetailsOfCartographicContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20210">rdae:P20210</a>
    /// </summary>
    let P20210 = _prefixId.prefix "P20210"
    /// <summary>
    ///   <para>rdfs:label : is revised as</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been updated, corrected, or expanded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : revisedAs</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20211">rdae:P20211</a>
    /// </summary>
    let P20211 = _prefixId.prefix "P20211"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work which brings the expression together with another expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergedToFormExpression</para>
    ///   <para>rdfs:label : is merged to form (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20212">rdae:P20212</a>
    /// </summary>
    let P20212 = _prefixId.prefix "P20212"
    /// <summary>
    ///   <para>rdfs:label : has additional scale information</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : additionalScaleInformation</para>
    ///   <para>skos:definition : Relates an expression to supplemental information about scale such as a statement of comparative measurements or limitation of the scale to particular parts of the content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20213">rdae:P20213</a>
    /// </summary>
    let P20213 = _prefixId.prefix "P20213"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the earliest date associated with an expression.</para>
    ///   <para>rdfs:label : has date of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20214">rdae:P20214</a>
    /// </summary>
    let P20214 = _prefixId.prefix "P20214"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the instrument, instruments, voice, voices, etc., used (or intended to be used) for performance of musical content.</para>
    ///   <para>rdfs:label : has medium of performance of musical content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformanceOfMusicalContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20215">rdae:P20215</a>
    /// </summary>
    let P20215 = _prefixId.prefix "P20215"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the method or system used to represent the surface of the earth or of a celestial sphere on a plane.</para>
    ///   <para>rdfs:label : has projection of cartographic content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionOfCartographicContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20216">rdae:P20216</a>
    /// </summary>
    let P20216 = _prefixId.prefix "P20216"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the place and date associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>rdfs:label : has place and date of capture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAndDateOfCapture</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20217">rdae:P20217</a>
    /// </summary>
    let P20217 = _prefixId.prefix "P20217"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the place associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>rdfs:label : has place of capture</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfCapture</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20218">rdae:P20218</a>
    /// </summary>
    let P20218 = _prefixId.prefix "P20218"
    /// <summary>
    ///   <para>rdfs:label : has duration</para>
    ///   <para>skos:definition : Relates an expression to the playing time, running time, etc., of the content of a resource.</para>
    ///   <para>skos:scopeNote : Duration also includes performance time for a resource containing notated music or notated movement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : duration</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20219">rdae:P20219</a>
    /// </summary>
    let P20219 = _prefixId.prefix "P20219"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfMovingImage</para>
    ///   <para>skos:definition : Relates an expression to the presence of colour, tone, etc., in a moving image or images contained in a resource. colour of moving image is also the specific colours, tones, etc., (including black and white) present in a moving image or images contained in a resource.</para>
    ///   <para>rdfs:label : has colour of moving image</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20220">rdae:P20220</a>
    /// </summary>
    let P20220 = _prefixId.prefix "P20220"
    /// <summary>
    ///   <para>rdfs:label : has colour content of resource designed for persons with visual impairments</para>
    ///   <para>skos:definition : Relates an expression to the presence of colour, tone, etc., in a resource designed for persons with visual impairments. colour content of resources designed for persons with visual impairments is also the specific colours, tones, etc., (excluding black and white) present in a resource designed for persons with visual impairments.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContentOfResourceDesignedForPersonsWithVisualImpairments</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20221">rdae:P20221</a>
    /// </summary>
    let P20221 = _prefixId.prefix "P20221"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the presence of colour, tone, etc., in a still image or images contained in a resource. colour of still image is also the specific colours, tones, etc., (including black and white) present in a still image or images contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfStillImage</para>
    ///   <para>rdfs:label : has colour of still image</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20222">rdae:P20222</a>
    /// </summary>
    let P20222 = _prefixId.prefix "P20222"
    /// <summary>
    ///   <para>rdfs:label : has colour of three-dimensional form</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfThreeDimensionalForm</para>
    ///   <para>skos:definition : Relates an expression to the presence of colour, tone, etc., in a three-dimensional form or forms contained in a resource. colour of three-dimensional form is also the specific colours, tones, etc., (including black and white) present in a three-dimensional form or forms contained in a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20223">rdae:P20223</a>
    /// </summary>
    let P20223 = _prefixId.prefix "P20223"
    /// <summary>
    ///   <para>rdfs:label : has colour content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContent</para>
    ///   <para>skos:definition : Relates an expression to the presence of colour, tone, etc., in the content of a resource. colour content is also the specific colours, tones, etc., (including black and white) present in the content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20224">rdae:P20224</a>
    /// </summary>
    let P20224 = _prefixId.prefix "P20224"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the presence of sound in a resource other than one that consists primarily of recorded sound.</para>
    ///   <para>rdfs:label : has sound content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20225">rdae:P20225</a>
    /// </summary>
    let P20225 = _prefixId.prefix "P20225"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the ratio of horizontal distances in the cartographic content of a resource to the actual distances they represent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : horizontalScaleOfCartographicContent</para>
    ///   <para>rdfs:label : has horizontal scale of cartographic content</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20226">rdae:P20226</a>
    /// </summary>
    let P20226 = _prefixId.prefix "P20226"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the ratio of the dimensions of a still image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <para>rdfs:label : has scale of still image or three-dimensional form</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scaleOfStillImageOrThreeDimensionalForm</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20227">rdae:P20227</a>
    /// </summary>
    let P20227 = _prefixId.prefix "P20227"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scale</para>
    ///   <para>rdfs:label : has scale</para>
    ///   <para>skos:definition : Relates an expression to the ratio of the dimensions of an image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20228">rdae:P20228</a>
    /// </summary>
    let P20228 = _prefixId.prefix "P20228"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the ratio of the width to the height of a moving image.</para>
    ///   <para>rdfs:label : has aspect ratio</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : aspectRatio</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20229">rdae:P20229</a>
    /// </summary>
    let P20229 = _prefixId.prefix "P20229"
    /// <summary>
    ///   <para>rdfs:label : has vertical scale of cartographic content</para>
    ///   <para>skos:definition : Relates an expression to the scale of elevation or vertical dimension of the cartographic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verticalScaleOfCartographicContent</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20230">rdae:P20230</a>
    /// </summary>
    let P20230 = _prefixId.prefix "P20230"
    /// <summary>
    ///   <para>rdfs:label : has work expressed</para>
    ///   <para>skos:definition : Relates an expression to the work realized through an expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : workExpressed</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20231">rdae:P20231</a>
    /// </summary>
    let P20231 = _prefixId.prefix "P20231"
    /// <summary>
    ///   <para>rdfs:label : has accompanying expression relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingExpressionRelationship</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is an augmentation of, or is augmented by, or is complemented by the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20232">rdae:P20232</a>
    /// </summary>
    let P20232 = _prefixId.prefix "P20232"
    /// <summary>
    ///   <para>rdfs:label : has derivative expression relationship with</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is based on or is a derivative of the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeExpressionRelationship</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20233">rdae:P20233</a>
    /// </summary>
    let P20233 = _prefixId.prefix "P20233"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is described in or is a description of the expression.</para>
    ///   <para>rdfs:label : has descriptive expression relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptiveExpressionRelationship</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20234">rdae:P20234</a>
    /// </summary>
    let P20234 = _prefixId.prefix "P20234"
    /// <summary>
    ///   <para>rdfs:label : has sequential expression relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialExpressionRelationship</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that is preceded by or succeeded by the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20235">rdae:P20235</a>
    /// </summary>
    let P20235 = _prefixId.prefix "P20235"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression that is contained in or contains the expression.</para>
    ///   <para>rdfs:label : has whole-part expression relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartExpressionRelationship</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20236">rdae:P20236</a>
    /// </summary>
    let P20236 = _prefixId.prefix "P20236"
    /// <summary>
    ///   <para>rdfs:label : has writer of afterword</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAfterword</para>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing an afterword to the original work.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20237">rdae:P20237</a>
    /// </summary>
    let P20237 = _prefixId.prefix "P20237"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a person, family, or corporate body contributing to an expression of a work by providing a postface to the original work.</para>
    ///   <para>rdfs:label : has writer of postface</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPostface</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20238">rdae:P20238</a>
    /// </summary>
    let P20238 = _prefixId.prefix "P20238"
    /// <summary>
    ///   <para>rdfs:label : is musical theatre adaptation of (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as a musical theatre work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalTheatreAdaptationOfExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20239">rdae:P20239</a>
    /// </summary>
    let P20239 = _prefixId.prefix "P20239"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : operaAdaptationOfExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that has been adapted as an opera.</para>
    ///   <para>rdfs:label : is opera adaptation of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20240">rdae:P20240</a>
    /// </summary>
    let P20240 = _prefixId.prefix "P20240"
    /// <summary>
    ///   <para>rdfs:label : is adapted as musical theatre (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical theatre work based on the source expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsMusicalTheatreExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20241">rdae:P20241</a>
    /// </summary>
    let P20241 = _prefixId.prefix "P20241"
    /// <summary>
    ///   <para>rdfs:label : is adapted as opera (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of an opera based on the source expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsOperaExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20242">rdae:P20242</a>
    /// </summary>
    let P20242 = _prefixId.prefix "P20242"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work that is used in a motion picture, play, television program, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicExpression</para>
    ///   <para>rdfs:label : is music (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20243">rdae:P20243</a>
    /// </summary>
    let P20243 = _prefixId.prefix "P20243"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a work such as a motion picture, play, television program, etc. that uses the musical work.</para>
    ///   <para>rdfs:label : is music for (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20244">rdae:P20244</a>
    /// </summary>
    let P20244 = _prefixId.prefix "P20244"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work that is used in a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoMusicExpression</para>
    ///   <para>rdfs:label : is video music (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20245">rdae:P20245</a>
    /// </summary>
    let P20245 = _prefixId.prefix "P20245"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForVideoExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the musical work in a video.</para>
    ///   <para>rdfs:label : is music for video (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20246">rdae:P20246</a>
    /// </summary>
    let P20246 = _prefixId.prefix "P20246"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProgramMusicExpression</para>
    ///   <para>rdfs:label : is television program music (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work that is used in a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20247">rdae:P20247</a>
    /// </summary>
    let P20247 = _prefixId.prefix "P20247"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForTelevisionProgramExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the musical work in a television program.</para>
    ///   <para>rdfs:label : is music for television program (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20248">rdae:P20248</a>
    /// </summary>
    let P20248 = _prefixId.prefix "P20248"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work that is used in a radio program.</para>
    ///   <para>rdfs:label : is radio program music (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProgramMusicExpression</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20249">rdae:P20249</a>
    /// </summary>
    let P20249 = _prefixId.prefix "P20249"
    /// <summary>
    ///   <para>rdfs:label : is music for radio program (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForRadioProgramExpression</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the musical work in a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20250">rdae:P20250</a>
    /// </summary>
    let P20250 = _prefixId.prefix "P20250"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureMusicExpression</para>
    ///   <para>rdfs:label : is motion picture music (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a musical work that is used in a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20251">rdae:P20251</a>
    /// </summary>
    let P20251 = _prefixId.prefix "P20251"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForMotionPictureExpression</para>
    ///   <para>rdfs:label : is music for motion picture (expression)</para>
    ///   <para>skos:definition : Relates an expression to an expression of a work that uses the musical work in a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/e/P20252">rdae:P20252</a>
    /// </summary>
    let P20252 = _prefixId.prefix "P20252"
    let abridgedAsExpression = _prefixId.prefix "abridgedAsExpression"
    let abridgementOfExpression = _prefixId.prefix "abridgementOfExpression"
    let abridger = _prefixId.prefix "abridger"
    let absorbedByExpression = _prefixId.prefix "absorbedByExpression"
    let absorbedExpression = _prefixId.prefix "absorbedExpression"
    let absorbedInPartByExpression = _prefixId.prefix "absorbedInPartByExpression"
    let absorbedInPartExpression = _prefixId.prefix "absorbedInPartExpression"
    let absorptionInPartOfExpression = _prefixId.prefix "absorptionInPartOfExpression"
    let absorptionOfExpression = _prefixId.prefix "absorptionOfExpression"
    let abstractExpression = _prefixId.prefix "abstractExpression"
    let abstractOfExpression = _prefixId.prefix "abstractOfExpression"
    let abstractedInExpression = _prefixId.prefix "abstractedInExpression"
    let abstractsForExpression = _prefixId.prefix "abstractsForExpression"
    let accessibilityContent = _prefixId.prefix "accessibilityContent"

    let accompanyingExpressionRelationship = _prefixId.prefix "accompanyingExpressionRelationship"

    let actor = _prefixId.prefix "actor"
    let adaptationOfExpression = _prefixId.prefix "adaptationOfExpression"

    let adaptedAsAMotionPictureExpression = _prefixId.prefix "adaptedAsAMotionPictureExpression"

    let adaptedAsAMotionPictureScreenplayExpression = _prefixId.prefix "adaptedAsAMotionPictureScreenplayExpression"

    let adaptedAsARadioProgramExpression = _prefixId.prefix "adaptedAsARadioProgramExpression"

    let adaptedAsARadioScriptExpression = _prefixId.prefix "adaptedAsARadioScriptExpression"

    let adaptedAsAScreenplayExpression = _prefixId.prefix "adaptedAsAScreenplayExpression"

    let adaptedAsATelevisionProgramExpression = _prefixId.prefix "adaptedAsATelevisionProgramExpression"

    let adaptedAsATelevisionScreenplayExpression = _prefixId.prefix "adaptedAsATelevisionScreenplayExpression"

    let adaptedAsAVideoProgramExpression = _prefixId.prefix "adaptedAsAVideoProgramExpression"

    let adaptedAsAVideoScreenplayExpression = _prefixId.prefix "adaptedAsAVideoScreenplayExpression"

    let adaptedAsExpression = _prefixId.prefix "adaptedAsExpression"

    let adaptedAsMusicalTheatreExpression = _prefixId.prefix "adaptedAsMusicalTheatreExpression"

    let adaptedAsOperaExpression = _prefixId.prefix "adaptedAsOperaExpression"
    let addendaExpression = _prefixId.prefix "addendaExpression"
    let addendaToExpression = _prefixId.prefix "addendaToExpression"
    let additionalScaleInformation = _prefixId.prefix "additionalScaleInformation"
    let analysedInExpression = _prefixId.prefix "analysedInExpression"
    let analysisOfExpression = _prefixId.prefix "analysisOfExpression"
    let animator = _prefixId.prefix "animator"
    let appendixExpression = _prefixId.prefix "appendixExpression"
    let appendixToExpression = _prefixId.prefix "appendixToExpression"
    let arrangerOfMusic = _prefixId.prefix "arrangerOfMusic"
    let artDirector = _prefixId.prefix "artDirector"
    let artisticAndOrTechnicalCredit = _prefixId.prefix "artisticAndOrTechnicalCredit"
    let aspectRatio = _prefixId.prefix "aspectRatio"
    let augmentationOfExpression = _prefixId.prefix "augmentationOfExpression"
    let augmentedByExpression = _prefixId.prefix "augmentedByExpression"
    let award = _prefixId.prefix "award"
    let basedOnExpression = _prefixId.prefix "basedOnExpression"
    let basisForLibrettoExpression = _prefixId.prefix "basisForLibrettoExpression"
    let cadenzaComposedForExpression = _prefixId.prefix "cadenzaComposedForExpression"
    let cadenzaExpression = _prefixId.prefix "cadenzaExpression"
    let cartographerExpression = _prefixId.prefix "cartographerExpression"
    let catalogueExpression = _prefixId.prefix "catalogueExpression"
    let catalogueOfExpression = _prefixId.prefix "catalogueOfExpression"
    let choreographerExpression = _prefixId.prefix "choreographerExpression"
    let choreographyExpression = _prefixId.prefix "choreographyExpression"
    let choreographyForExpression = _prefixId.prefix "choreographyForExpression"
    let colourContent = _prefixId.prefix "colourContent"

    let colourContentOfResourceDesignedForPersonsWithVisualImpairments = _prefixId.prefix "colourContentOfResourceDesignedForPersonsWithVisualImpairments"

    let colourOfMovingImage = _prefixId.prefix "colourOfMovingImage"
    let colourOfStillImage = _prefixId.prefix "colourOfStillImage"
    let colourOfThreeDimensionalForm = _prefixId.prefix "colourOfThreeDimensionalForm"
    let commentaryInExpression = _prefixId.prefix "commentaryInExpression"
    let commentaryOnExpression = _prefixId.prefix "commentaryOnExpression"
    let commentator = _prefixId.prefix "commentator"
    let complementedByExpression = _prefixId.prefix "complementedByExpression"
    let composerExpression = _prefixId.prefix "composerExpression"
    let concordanceExpression = _prefixId.prefix "concordanceExpression"
    let concordanceToExpression = _prefixId.prefix "concordanceToExpression"
    let conductor = _prefixId.prefix "conductor"
    let containedInExpression = _prefixId.prefix "containedInExpression"
    let containerOfExpression = _prefixId.prefix "containerOfExpression"
    let containsExpression = _prefixId.prefix "containsExpression"
    let contentType = _prefixId.prefix "contentType"

    let continuationInPartOfExpression = _prefixId.prefix "continuationInPartOfExpression"

    let continuationOfExpression = _prefixId.prefix "continuationOfExpression"
    let continuedByExpression = _prefixId.prefix "continuedByExpression"
    let continuedInPartByExpression = _prefixId.prefix "continuedInPartByExpression"
    let continuesExpression = _prefixId.prefix "continuesExpression"
    let continuesInPartExpression = _prefixId.prefix "continuesInPartExpression"
    let contributor = _prefixId.prefix "contributor"
    let costumeDesigner = _prefixId.prefix "costumeDesigner"
    let courtReporter = _prefixId.prefix "courtReporter"
    let critiqueOfExpression = _prefixId.prefix "critiqueOfExpression"
    let critiquedInExpression = _prefixId.prefix "critiquedInExpression"
    let dancer = _prefixId.prefix "dancer"
    let dateOfCapture = _prefixId.prefix "dateOfCapture"
    let dateOfExpression = _prefixId.prefix "dateOfExpression"
    let derivativeExpression = _prefixId.prefix "derivativeExpression"

    let derivativeExpressionRelationship = _prefixId.prefix "derivativeExpressionRelationship"

    let describedInExpression = _prefixId.prefix "describedInExpression"
    let descriptionOfExpression = _prefixId.prefix "descriptionOfExpression"

    let descriptiveExpressionRelationship = _prefixId.prefix "descriptiveExpressionRelationship"

    let digestExpression = _prefixId.prefix "digestExpression"
    let digestOfExpression = _prefixId.prefix "digestOfExpression"
    let draftsman = _prefixId.prefix "draftsman"
    let dramatizationOfExpression = _prefixId.prefix "dramatizationOfExpression"
    let dramatizedAsExpression = _prefixId.prefix "dramatizedAsExpression"
    let dubbedVersion = _prefixId.prefix "dubbedVersion"
    let dubbedVersionOf = _prefixId.prefix "dubbedVersionOf"
    let duration = _prefixId.prefix "duration"
    let editor = _prefixId.prefix "editor"
    let editorOfMovingImageWork = _prefixId.prefix "editorOfMovingImageWork"
    let errataExpression = _prefixId.prefix "errataExpression"
    let errataToExpression = _prefixId.prefix "errataToExpression"
    let evaluatedInExpression = _prefixId.prefix "evaluatedInExpression"
    let evaluationOfExpression = _prefixId.prefix "evaluationOfExpression"
    let expandedAsExpression = _prefixId.prefix "expandedAsExpression"
    let expandedVersionOfExpression = _prefixId.prefix "expandedVersionOfExpression"
    let findingAidExpression = _prefixId.prefix "findingAidExpression"
    let findingAidForExpression = _prefixId.prefix "findingAidForExpression"
    let formOfMusicalNotation = _prefixId.prefix "formOfMusicalNotation"
    let formOfNotatedMovement = _prefixId.prefix "formOfNotatedMovement"
    let formOfNotation = _prefixId.prefix "formOfNotation"
    let formOfTactileNotation = _prefixId.prefix "formOfTactileNotation"
    let formatOfNotatedMusic = _prefixId.prefix "formatOfNotatedMusic"
    let freeTranslationOfExpression = _prefixId.prefix "freeTranslationOfExpression"
    let freelyTranslatedAsExpression = _prefixId.prefix "freelyTranslatedAsExpression"
    let guideExpression = _prefixId.prefix "guideExpression"
    let guideToExpression = _prefixId.prefix "guideToExpression"

    let horizontalScaleOfCartographicContent = _prefixId.prefix "horizontalScaleOfCartographicContent"

    let host = _prefixId.prefix "host"
    let identifierForTheExpression = _prefixId.prefix "identifierForTheExpression"
    let illustrationsExpression = _prefixId.prefix "illustrationsExpression"
    let illustrationsForExpression = _prefixId.prefix "illustrationsForExpression"
    let illustrativeContent = _prefixId.prefix "illustrativeContent"
    let illustrator = _prefixId.prefix "illustrator"
    let imitatedAsExpression = _prefixId.prefix "imitatedAsExpression"
    let imitationOfExpression = _prefixId.prefix "imitationOfExpression"
    let incidentalMusicExpression = _prefixId.prefix "incidentalMusicExpression"
    let incidentalMusicForExpression = _prefixId.prefix "incidentalMusicForExpression"
    let indexExpression = _prefixId.prefix "indexExpression"
    let indexToExpression = _prefixId.prefix "indexToExpression"
    let indexedInExpression = _prefixId.prefix "indexedInExpression"
    let indexingForExpression = _prefixId.prefix "indexingForExpression"
    let instrumentalist = _prefixId.prefix "instrumentalist"
    let intervieweeExpression = _prefixId.prefix "intervieweeExpression"
    let interviewerExpression = _prefixId.prefix "interviewerExpression"
    let languageOfExpression = _prefixId.prefix "languageOfExpression"
    let languageOfTheContent = _prefixId.prefix "languageOfTheContent"
    let librettoBasedOnExpression = _prefixId.prefix "librettoBasedOnExpression"
    let librettoExpression = _prefixId.prefix "librettoExpression"
    let librettoForExpression = _prefixId.prefix "librettoForExpression"
    let manifestationOfExpression = _prefixId.prefix "manifestationOfExpression"

    let mediumOfPerformanceOfMusicalContent = _prefixId.prefix "mediumOfPerformanceOfMusicalContent"

    let mergedToFormExpression = _prefixId.prefix "mergedToFormExpression"
    let mergerOfExpression = _prefixId.prefix "mergerOfExpression"
    let minuteTaker = _prefixId.prefix "minuteTaker"
    let moderator = _prefixId.prefix "moderator"

    let motionPictureAdaptationOfExpression = _prefixId.prefix "motionPictureAdaptationOfExpression"

    let motionPictureMusicExpression = _prefixId.prefix "motionPictureMusicExpression"

    let motionPictureScreenplayBasedOnExpression = _prefixId.prefix "motionPictureScreenplayBasedOnExpression"

    let motionPictureScreenplayExpression = _prefixId.prefix "motionPictureScreenplayExpression"

    let musicExpression = _prefixId.prefix "musicExpression"
    let musicForExpression = _prefixId.prefix "musicForExpression"

    let musicForMotionPictureExpression = _prefixId.prefix "musicForMotionPictureExpression"

    let musicForRadioProgramExpression = _prefixId.prefix "musicForRadioProgramExpression"

    let musicForTelevisionProgramExpression = _prefixId.prefix "musicForTelevisionProgramExpression"

    let musicForVideoExpression = _prefixId.prefix "musicForVideoExpression"
    let musicalArrangement = _prefixId.prefix "musicalArrangement"
    let musicalArrangementOf = _prefixId.prefix "musicalArrangementOf"
    let musicalDirector = _prefixId.prefix "musicalDirector"
    let musicalSettingExpression = _prefixId.prefix "musicalSettingExpression"
    let musicalSettingOfExpression = _prefixId.prefix "musicalSettingOfExpression"

    let musicalTheatreAdaptationOfExpression = _prefixId.prefix "musicalTheatreAdaptationOfExpression"

    let musicalVariationsBasedOnExpression = _prefixId.prefix "musicalVariationsBasedOnExpression"

    let musicalVariationsExpression = _prefixId.prefix "musicalVariationsExpression"
    let narrator = _prefixId.prefix "narrator"

    let noteOnChangesInContentCharacteristics = _prefixId.prefix "noteOnChangesInContentCharacteristics"

    let noteOnExpression = _prefixId.prefix "noteOnExpression"
    let novelizationExpression = _prefixId.prefix "novelizationExpression"
    let novelizationOfExpression = _prefixId.prefix "novelizationOfExpression"
    let onScreenPresenter = _prefixId.prefix "onScreenPresenter"
    let operaAdaptationOfExpression = _prefixId.prefix "operaAdaptationOfExpression"

    let otherDetailsOfCartographicContent = _prefixId.prefix "otherDetailsOfCartographicContent"

    let otherDistinguishingCharacteristicOfTheExpression = _prefixId.prefix "otherDistinguishingCharacteristicOfTheExpression"

    let panelist = _prefixId.prefix "panelist"
    let paraphraseOfExpression = _prefixId.prefix "paraphraseOfExpression"
    let paraphrasedAsExpression = _prefixId.prefix "paraphrasedAsExpression"
    let parodiedAsExpression = _prefixId.prefix "parodiedAsExpression"
    let parodyOfExpression = _prefixId.prefix "parodyOfExpression"
    let performer = _prefixId.prefix "performer"

    let performerNarratorAndOrPresenter = _prefixId.prefix "performerNarratorAndOrPresenter"

    let placeAndDateOfCapture = _prefixId.prefix "placeAndDateOfCapture"
    let placeOfCapture = _prefixId.prefix "placeOfCapture"
    let precededByExpression = _prefixId.prefix "precededByExpression"
    let presenter = _prefixId.prefix "presenter"
    let productionDesigner = _prefixId.prefix "productionDesigner"

    let projectionOfCartographicContent = _prefixId.prefix "projectionOfCartographicContent"

    let puppeteer = _prefixId.prefix "puppeteer"
    let radioAdaptationOfExpression = _prefixId.prefix "radioAdaptationOfExpression"
    let radioProgramMusicExpression = _prefixId.prefix "radioProgramMusicExpression"
    let radioScriptBasedOnExpression = _prefixId.prefix "radioScriptBasedOnExpression"
    let radioScriptExpression = _prefixId.prefix "radioScriptExpression"
    let recordingEngineer = _prefixId.prefix "recordingEngineer"
    let recordist = _prefixId.prefix "recordist"
    let relatedExpression = _prefixId.prefix "relatedExpression"
    let remadeAsExpression = _prefixId.prefix "remadeAsExpression"
    let remakeOfExpression = _prefixId.prefix "remakeOfExpression"
    let replacedByExpression = _prefixId.prefix "replacedByExpression"
    let replacedInPartByExpression = _prefixId.prefix "replacedInPartByExpression"
    let replacementInPartOfExpression = _prefixId.prefix "replacementInPartOfExpression"
    let replacementOfExpression = _prefixId.prefix "replacementOfExpression"
    let reviewOfExpression = _prefixId.prefix "reviewOfExpression"
    let reviewedInExpression = _prefixId.prefix "reviewedInExpression"
    let revisedAs = _prefixId.prefix "revisedAs"
    let revisionOf = _prefixId.prefix "revisionOf"
    let scale = _prefixId.prefix "scale"

    let scaleOfStillImageOrThreeDimensionalForm = _prefixId.prefix "scaleOfStillImageOrThreeDimensionalForm"

    let screenplayBasedOnExpression = _prefixId.prefix "screenplayBasedOnExpression"
    let screenplayExpression = _prefixId.prefix "screenplayExpression"
    let screenplayForExpression = _prefixId.prefix "screenplayForExpression"

    let screenplayForTheMotionPictureExpression = _prefixId.prefix "screenplayForTheMotionPictureExpression"

    let screenplayForTheTelevisionProgramExpression = _prefixId.prefix "screenplayForTheTelevisionProgramExpression"

    let screenplayForTheVideoExpression = _prefixId.prefix "screenplayForTheVideoExpression"

    let script = _prefixId.prefix "script"

    let scriptForTheRadioProgramExpression = _prefixId.prefix "scriptForTheRadioProgramExpression"

    let separatedFromExpression = _prefixId.prefix "separatedFromExpression"

    let sequentialExpressionRelationship = _prefixId.prefix "sequentialExpressionRelationship"

    let singer = _prefixId.prefix "singer"
    let soundContent = _prefixId.prefix "soundContent"
    let speaker = _prefixId.prefix "speaker"
    let splitIntoExpression = _prefixId.prefix "splitIntoExpression"
    let stageDirector = _prefixId.prefix "stageDirector"
    let storyteller = _prefixId.prefix "storyteller"
    let succeededByExpression = _prefixId.prefix "succeededByExpression"
    let summarizationOfTheContent = _prefixId.prefix "summarizationOfTheContent"
    let summaryExpression = _prefixId.prefix "summaryExpression"
    let summaryOfExpression = _prefixId.prefix "summaryOfExpression"
    let supersededByExpression = _prefixId.prefix "supersededByExpression"
    let supersededInPartByExpression = _prefixId.prefix "supersededInPartByExpression"
    let supersedesExpression = _prefixId.prefix "supersedesExpression"
    let supersedesInPartExpression = _prefixId.prefix "supersedesInPartExpression"
    let supplementExpression = _prefixId.prefix "supplementExpression"
    let supplementToExpression = _prefixId.prefix "supplementToExpression"
    let supplementaryContent = _prefixId.prefix "supplementaryContent"
    let surveyor = _prefixId.prefix "surveyor"
    let teacher = _prefixId.prefix "teacher"

    let televisionAdaptationOfExpression = _prefixId.prefix "televisionAdaptationOfExpression"

    let televisionProgramMusicExpression = _prefixId.prefix "televisionProgramMusicExpression"

    let televisionScreenplayBasedOnExpression = _prefixId.prefix "televisionScreenplayBasedOnExpression"

    let televisionScreenplayExpression = _prefixId.prefix "televisionScreenplayExpression"

    let transcriber = _prefixId.prefix "transcriber"
    let translatedAs = _prefixId.prefix "translatedAs"
    let translationOf = _prefixId.prefix "translationOf"
    let translator = _prefixId.prefix "translator"
    let verseAdaptationExpression = _prefixId.prefix "verseAdaptationExpression"
    let verseAdaptationOfExpression = _prefixId.prefix "verseAdaptationOfExpression"

    let verticalScaleOfCartographicContent = _prefixId.prefix "verticalScaleOfCartographicContent"

    let videoAdaptationOfExpression = _prefixId.prefix "videoAdaptationOfExpression"
    let videoMusicExpression = _prefixId.prefix "videoMusicExpression"

    let videoScreenplayBasedOnExpression = _prefixId.prefix "videoScreenplayBasedOnExpression"

    let videoScreenplayExpression = _prefixId.prefix "videoScreenplayExpression"
    let voiceActor = _prefixId.prefix "voiceActor"

    let wholePartExpressionRelationship = _prefixId.prefix "wholePartExpressionRelationship"

    let workExpressed = _prefixId.prefix "workExpressed"
    let writerOfAddedCommentary = _prefixId.prefix "writerOfAddedCommentary"
    let writerOfAddedLyrics = _prefixId.prefix "writerOfAddedLyrics"
    let writerOfAddedText = _prefixId.prefix "writerOfAddedText"
    let writerOfAfterword = _prefixId.prefix "writerOfAfterword"
    let writerOfIntroduction = _prefixId.prefix "writerOfIntroduction"
    let writerOfPostface = _prefixId.prefix "writerOfPostface"
    let writerOfPreface = _prefixId.prefix "writerOfPreface"

    let writerOfSupplementaryTextualContent = _prefixId.prefix "writerOfSupplementaryTextualContent"
