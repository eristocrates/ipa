#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdaw =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/w/" "rdaw"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A candidate for a degree who defends or opposes a thesis provided by the praeses in an academic disputation.</para>
    ///   <para>skos:definition : Relates a work to a candidate for a degree who defends or opposes a thesis provided by the praeses in an academic disputation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : respondent</para>
    ///   <para>rdfs:label : has respondent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : respondent</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10001">rdaw:P10001</a>
    /// </summary>
    let P10001 = _prefixId.prefix "P10001"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a character string uniquely associated with a work, or with a surrogate for a work (e.g., an authority record).</para>
    ///   <para>skos:scopeNote : The identifier serves to differentiate that work from other works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A character string uniquely associated with a work, or with a surrogate for a work (e.g., an authority record).</para>
    ///   <para>rdfs:label : has identifier for the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : identifier for the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10002">rdaw:P10002</a>
    /// </summary>
    let P10002 = _prefixId.prefix "P10002"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a characteristic other than form of work, date of work, or place of origin of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDistinguishingCharacteristicOfTheWork</para>
    ///   <para>skos:scopeNote : It serves to differentiate a work from another work with the same title or from the name of a person, family, or corporate body.</para>
    ///   <para>rdfs:label : has other distinguishing characteristic of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A characteristic other than form of work, date of work, or place of origin of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other distinguishing characteristic of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.6^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10003">rdaw:P10003</a>
    /// </summary>
    let P10003 = _prefixId.prefix "P10003"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : form of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A class or genre to which a work belongs.</para>
    ///   <para>skos:definition : Relates a work to a class or genre to which a work belongs.</para>
    ///   <para>rdfs:label : has form of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10004">rdaw:P10004</a>
    /// </summary>
    let P10004 = _prefixId.prefix "P10004"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleeCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : has appellee corporate body</para>
    ///   <para>skos:definition : Relates a work to a corporate body against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>rdfs:label : has appellee corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10005">rdaw:P10005</a>
    /// </summary>
    let P10005 = _prefixId.prefix "P10005"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeGrantingInstitution</para>
    ///   <para>skos:definition : Relates a work to a corporate body granting an academic degree.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : degree granting institution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body granting an academic degree.</para>
    ///   <para>rdfs:label : has degree granting institution</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10006">rdaw:P10006</a>
    /// </summary>
    let P10006 = _prefixId.prefix "P10006"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostInstitution</para>
    ///   <para>rdfs:label : has host institution</para>
    ///   <para>skos:definition : Relates a work to a corporate body hosting the event, exhibit, conference, etc., which gave rise to a work, but having little or no responsibility for the content of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body hosting the event, exhibit, conference, etc., which gave rise to a work, but having little or no responsibility for the content of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : host institution</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10007">rdaw:P10007</a>
    /// </summary>
    let P10007 = _prefixId.prefix "P10007"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that is responsible for financial, technical, and organizational management of a production for stage, screen, sound recording, television, webcast, etc.</para>
    ///   <para>rdfs:label : has production company</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : production company</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionCompany</para>
    ///   <para>skos:definition : Relates a work to a corporate body that is responsible for financial, technical, and organizational management of a production for stage, screen, sound recording, television, webcast, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10008">rdaw:P10008</a>
    /// </summary>
    let P10008 = _prefixId.prefix "P10008"
    /// <summary>
    ///   <para>rdfs:label : has appellant corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body who appeals the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>skos:definition : Relates a work to a corporate body who appeals the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appellant corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantCorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10009">rdaw:P10009</a>
    /// </summary>
    let P10009 = _prefixId.prefix "P10009"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body who brings a suit in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : plaintiff corporate body</para>
    ///   <para>skos:definition : Relates a work to a corporate body who brings a suit in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffCorporateBody</para>
    ///   <para>rdfs:label : has plaintiff corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10010">rdaw:P10010</a>
    /// </summary>
    let P10010 = _prefixId.prefix "P10010"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A court governed by court rules, regardless of their official nature (e.g., laws, administrative regulations).</para>
    ///   <para>skos:definition : Relates a work to a court governed by court rules, regardless of their official nature (e.g., laws, administrative regulations).</para>
    ///   <para>rdfs:label : has court governed</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtGoverned</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : court governed</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10011">rdaw:P10011</a>
    /// </summary>
    let P10011 = _prefixId.prefix "P10011"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfPart</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 24.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A designation of the sequencing of a part or parts within a larger work.</para>
    ///   <para>rdfs:label : has numbering of part</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numbering of part</para>
    ///   <para>skos:definition : Relates a work to a designation of the sequencing of a part or parts within a larger work.</para>
    ///   <para>skos:scopeNote : Numbering of part may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10012">rdaw:P10012</a>
    /// </summary>
    let P10012 = _prefixId.prefix "P10012"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : film director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDirector</para>
    ///   <para>rdfs:label : has film director</para>
    ///   <para>skos:definition : Relates a work to a director responsible for the general management and supervision of a filmed performance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A director responsible for the general management and supervision of a filmed performance.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10013">rdaw:P10013</a>
    /// </summary>
    let P10013 = _prefixId.prefix "P10013"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : radio director</para>
    ///   <para>rdfs:label : has radio director</para>
    ///   <para>skos:definition : Relates a work to a director responsible for the general management and supervision of a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioDirector</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A director responsible for the general management and supervision of a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10014">rdaw:P10014</a>
    /// </summary>
    let P10014 = _prefixId.prefix "P10014"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : television director</para>
    ///   <para>rdfs:label : has television director</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A director responsible for the general management and supervision of a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionDirector</para>
    ///   <para>skos:definition : Relates a work to a director responsible for the general management and supervision of a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10015">rdaw:P10015</a>
    /// </summary>
    let P10015 = _prefixId.prefix "P10015"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizedAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dramatized as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A dramatic work adapted from the source work.</para>
    ///   <para>rdfs:label : is dramatized as (work)</para>
    ///   <para>skos:definition : Relates a work to a dramatic work adapted from the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10016">rdaw:P10016</a>
    /// </summary>
    let P10016 = _prefixId.prefix "P10016"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : enacting jurisdiction</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : enactingJurisdiction</para>
    ///   <para>rdfs:label : has enacting jurisdiction</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A jurisdiction enacting a law, regulation, constitution, court rule, etc.</para>
    ///   <para>skos:definition : Relates a work to a jurisdiction enacting a law, regulation, constitution, court rule, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10017">rdaw:P10017</a>
    /// </summary>
    let P10017 = _prefixId.prefix "P10017"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : jurisdictionGoverned</para>
    ///   <para>skos:definition : Relates a work to a jurisdiction governed by a law, regulation, etc., that was enacted by another jurisdiction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A jurisdiction governed by a law, regulation, etc., that was enacted by another jurisdiction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : jurisdiction governed</para>
    ///   <para>rdfs:label : has jurisdiction governed</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10018">rdaw:P10018</a>
    /// </summary>
    let P10018 = _prefixId.prefix "P10018"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a larger work of which the work is a discrete component.</para>
    ///   <para>rdfs:label : is contained in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A larger work of which the work is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : contained in (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10019">rdaw:P10019</a>
    /// </summary>
    let P10019 = _prefixId.prefix "P10019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A later work that continues the narrative of an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sequel</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequel</para>
    ///   <para>skos:definition : Relates a work to a later work that continues the narrative of an earlier work.</para>
    ///   <para>rdfs:label : is sequel</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10020">rdaw:P10020</a>
    /// </summary>
    let P10020 = _prefixId.prefix "P10020"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a later work used in part in place of an earlier work, usually because the later work contains updated or new information that makes part of the earlier work obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacedInPartByWork</para>
    ///   <para>rdfs:label : is replaced in part by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A later work used in part in place of an earlier work, usually because the later work contains updated or new information that makes part of the earlier work obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : replaced in part by (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10021">rdaw:P10021</a>
    /// </summary>
    let P10021 = _prefixId.prefix "P10021"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a later work used in place of an earlier work, usually because the later work contains updated or new information that makes the earlier work obsolete.</para>
    ///   <para>rdfs:label : is replaced by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A later work used in place of an earlier work, usually because the later work contains updated or new information that makes the earlier work obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacedByWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : replaced by (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10022">rdaw:P10022</a>
    /// </summary>
    let P10022 = _prefixId.prefix "P10022"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedInVerseAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted in verse as (work)</para>
    ///   <para>rdfs:label : is adapted in verse as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A literary composition in verse form adapted from the source work.</para>
    ///   <para>skos:definition : Relates a work to a literary composition in verse form adapted from the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10023">rdaw:P10023</a>
    /// </summary>
    let P10023 = _prefixId.prefix "P10023"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coordinatesOfCartographicContent</para>
    ///   <para>rdfs:label : has coordinates of cartographic content</para>
    ///   <para>skos:scopeNote : Coordinates may be expressed by means of longitude and latitude on the surface of planets or by the angles of right ascension and declination for celestial charts.</para>
    ///   <para>skos:definition : Relates a work to a mathematical system for identifying the area covered by the cartographic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A mathematical system for identifying the area covered by the cartographic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : coordinates of cartographic content</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10024">rdaw:P10024</a>
    /// </summary>
    let P10024 = _prefixId.prefix "P10024"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a motion picture based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A motion picture based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as motion picture (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsMotionPictureWork</para>
    ///   <para>rdfs:label : is adapted as motion picture (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10025">rdaw:P10025</a>
    /// </summary>
    let P10025 = _prefixId.prefix "P10025"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaWork</para>
    ///   <para>skos:definition : Relates a work to a musical work consisting of an ornamental passage for a soloist, added to a musical work such as a concerto, either by the same or a different composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work consisting of an ornamental passage for a soloist, added to a musical work such as a concerto, either by the same or a different composer.</para>
    ///   <para>rdfs:label : is cadenza (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : cadenza (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10026">rdaw:P10026</a>
    /// </summary>
    let P10026 = _prefixId.prefix "P10026"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work from which melodic, thematic, or harmonic material is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>rdfs:label : is variations based on (work)</para>
    ///   <para>skos:definition : Relates a work to a musical work from which melodic, thematic, or harmonic material is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : variations based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variationsBasedOnWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10027">rdaw:P10027</a>
    /// </summary>
    let P10027 = _prefixId.prefix "P10027"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work in which melodic, thematic, or harmonic material is taken from the source work to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>skos:definition : Relates a work to a musical work in which melodic, thematic, or harmonic material is taken from the source work to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modifiedByVariationAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : modified by variation as (work)</para>
    ///   <para>rdfs:label : is modified by variation as (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10028">rdaw:P10028</a>
    /// </summary>
    let P10028 = _prefixId.prefix "P10028"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : cadenza composed for (work)</para>
    ///   <para>rdfs:label : is cadenza composed for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work such as a concerto for which an ornamental passage for a soloist has been composed, either by the same or a different composer.</para>
    ///   <para>skos:definition : Relates a work to a musical work such as a concerto for which an ornamental passage for a soloist has been composed, either by the same or a different composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaComposedForWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10029">rdaw:P10029</a>
    /// </summary>
    let P10029 = _prefixId.prefix "P10029"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoForWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : libretto for (work)</para>
    ///   <para>rdfs:label : is libretto for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work such as an opera or other work for the musical stage, or an oratorio, that uses the text of the related work as a libretto.</para>
    ///   <para>skos:definition : Relates a work to a musical work such as an opera or other work for the musical stage, or an oratorio, that uses the text of the related work as a libretto.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10030">rdaw:P10030</a>
    /// </summary>
    let P10030 = _prefixId.prefix "P10030"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incidentalMusicWork</para>
    ///   <para>skos:definition : Relates a work to a musical work that provides the incidental music for a play or other spoken work for the stage.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work that provides the incidental music for a play or other spoken work for the stage.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : incidental music (work)</para>
    ///   <para>rdfs:label : is incidental music (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10031">rdaw:P10031</a>
    /// </summary>
    let P10031 = _prefixId.prefix "P10031"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : remade as (work)</para>
    ///   <para>skos:definition : Relates a work to a new motion picture, radio program, television program, or video based on an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A new motion picture, radio program, television program, or video based on an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remadeAsWork</para>
    ///   <para>rdfs:label : is remade as (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10032">rdaw:P10032</a>
    /// </summary>
    let P10032 = _prefixId.prefix "P10032"
    /// <summary>
    ///   <para>rdfs:label : is set to music as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : set to music as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A non-dramatic musical work, other than an oratorio, that uses the text of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : setToMusicAsWork</para>
    ///   <para>skos:definition : Relates a work to a non-dramatic musical work, other than an oratorio, that uses the text of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10033">rdaw:P10033</a>
    /// </summary>
    let P10033 = _prefixId.prefix "P10033"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A novel adapted from the source work.</para>
    ///   <para>rdfs:label : is adapted as novel (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsNovelWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as novel (work)</para>
    ///   <para>skos:definition : Relates a work to a novel adapted from the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10034">rdaw:P10034</a>
    /// </summary>
    let P10034 = _prefixId.prefix "P10034"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>rdfs:label : has appellee person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appellee person</para>
    ///   <para>skos:definition : Relates a work to a person against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10035">rdaw:P10035</a>
    /// </summary>
    let P10035 = _prefixId.prefix "P10035"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person held to be a channel of communication between the earthly world and a world of spirits.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : medium</para>
    ///   <para>skos:definition : Relates a work to a person held to be a channel of communication between the earthly world and a world of spirits.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : medium</para>
    ///   <para>rdfs:label : has medium</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10036">rdaw:P10036</a>
    /// </summary>
    let P10036 = _prefixId.prefix "P10036"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appellee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person or corporate body against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>skos:definition : Relates a work to a person or corporate body against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>rdfs:label : has appellee</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10037">rdaw:P10037</a>
    /// </summary>
    let P10037 = _prefixId.prefix "P10037"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person or corporate body who appeals the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>skos:definition : Relates a work to a person or corporate body who appeals the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>rdfs:label : has appellant</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellant</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appellant</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10038">rdaw:P10038</a>
    /// </summary>
    let P10038 = _prefixId.prefix "P10038"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiff</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person or corporate body who brings a suit in a civil proceeding.</para>
    ///   <para>rdfs:label : has plaintiff</para>
    ///   <para>skos:definition : Relates a work to a person or corporate body who brings a suit in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : plaintiff</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10039">rdaw:P10039</a>
    /// </summary>
    let P10039 = _prefixId.prefix "P10039"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendant</para>
    ///   <para>skos:definition : Relates a work to a person or corporate body who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : defendant</para>
    ///   <para>rdfs:label : has defendant</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person or corporate body who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10040">rdaw:P10040</a>
    /// </summary>
    let P10040 = _prefixId.prefix "P10040"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, such as an advisor or supervisor of thesis or dissertation research, overseeing either an academic degree or thesis.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : degree supervisor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeSupervisor</para>
    ///   <para>skos:definition : Relates a work to a person, such as an advisor or supervisor of thesis or dissertation research, overseeing either an academic degree or thesis.</para>
    ///   <para>rdfs:label : has degree supervisor</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10041">rdaw:P10041</a>
    /// </summary>
    let P10041 = _prefixId.prefix "P10041"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person who appeals the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantPerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appellant person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who appeals the decision of a lower court recorded in a legal work of a higher court.</para>
    ///   <para>rdfs:label : has appellant person</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10042">rdaw:P10042</a>
    /// </summary>
    let P10042 = _prefixId.prefix "P10042"
    /// <summary>
    ///   <para>rdfs:label : has plaintiff person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work to a person who brings a suit in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : plaintiff person</para>
    ///   <para>skos:definition : Relates a work to a person who brings a suit in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffPerson</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10043">rdaw:P10043</a>
    /// </summary>
    let P10043 = _prefixId.prefix "P10043"
    /// <summary>
    ///   <para>rdfs:label : has judge</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : judge</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who hears and decides on legal matters in court.</para>
    ///   <para>skos:definition : Relates a work to a person who hears and decides on legal matters in court.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : judge</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10044">rdaw:P10044</a>
    /// </summary>
    let P10044 = _prefixId.prefix "P10044"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : praeses</para>
    ///   <para>skos:definition : Relates a work to a person who is the faculty moderator of an academic disputation, normally proposing a thesis and participating in the ensuing disputation.</para>
    ///   <para>rdfs:label : has praeses</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : praeses</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who is the faculty moderator of an academic disputation, normally proposing a thesis and participating in the ensuing disputation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10045">rdaw:P10045</a>
    /// </summary>
    let P10045 = _prefixId.prefix "P10045"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body issuing a work, such as an official organ of the body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuingBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : issuing body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body issuing a work, such as an official organ of the body.</para>
    ///   <para>rdfs:label : has issuing body</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10046">rdaw:P10046</a>
    /// </summary>
    let P10046 = _prefixId.prefix "P10046"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body associated with a work other than as a creator.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body associated with a work other than as a creator.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPFCWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 19.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other person, family, or corporate body associated with a work</para>
    ///   <para>rdfs:label : has other person, family, or corporate body associated with a work</para>
    ///   <para>skos:scopeNote : Includes persons, etc., to whom correspondence is addressed, persons, etc., honoured by a festschrift, directors, cinematographers, sponsoring bodies, production companies, institutions, etc., hosting an exhibition or event, etc</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10047">rdaw:P10047</a>
    /// </summary>
    let P10047 = _prefixId.prefix "P10047"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dedicator</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body by whom a work is dedicated.</para>
    ///   <para>rdfs:label : has dedicator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body by whom a work is dedicated.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10048">rdaw:P10048</a>
    /// </summary>
    let P10048 = _prefixId.prefix "P10048"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honouree</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : honouree</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body honoured by a work (e.g., the honouree of a festschrift).</para>
    ///   <para>rdfs:label : has honouree</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body honoured by a work (e.g., the honouree of a festschrift).</para>
    ///   <para>skos:altLabel : has honoree</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10049">rdaw:P10049</a>
    /// </summary>
    let P10049 = _prefixId.prefix "P10049"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : programmer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : programmer</para>
    ///   <para>rdfs:label : has programmer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a computer program.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a computer program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10050">rdaw:P10050</a>
    /// </summary>
    let P10050 = _prefixId.prefix "P10050"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a design for an object.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : designer</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a design for an object.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designer</para>
    ///   <para>rdfs:label : has designer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10051">rdaw:P10051</a>
    /// </summary>
    let P10051 = _prefixId.prefix "P10051"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a map, atlas, globe, or other cartographic work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a map, atlas, globe, or other cartographic work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : cartographer</para>
    ///   <para>rdfs:label : has cartographer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10052">rdaw:P10052</a>
    /// </summary>
    let P10052 = _prefixId.prefix "P10052"
    /// <summary>
    ///   <para>rdfs:label : has composer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : composer</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a musical work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a musical work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10053">rdaw:P10053</a>
    /// </summary>
    let P10053 = _prefixId.prefix "P10053"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a new device or process.</para>
    ///   <para>rdfs:label : has inventor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inventor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : inventor</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a new device or process.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10054">rdaw:P10054</a>
    /// </summary>
    let P10054 = _prefixId.prefix "P10054"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a new work (e.g., a bibliography, a directory) by selecting, arranging, aggregating, and editing data, information, etc.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a new work (e.g., a bibliography, a directory) by selecting, arranging, aggregating, and editing data, information, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : compiler</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : compiler</para>
    ///   <para>rdfs:label : has compiler</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10055">rdaw:P10055</a>
    /// </summary>
    let P10055 = _prefixId.prefix "P10055"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : photographer</para>
    ///   <para>rdfs:label : has photographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : photographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a photographic work.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a photographic work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10056">rdaw:P10056</a>
    /// </summary>
    let P10056 = _prefixId.prefix "P10056"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewer</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a work by acting as an interviewer, reporter, pollster, or some other information gathering agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : interviewer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a work by acting as an interviewer, reporter, pollster, or some other information gathering agent.</para>
    ///   <para>rdfs:label : has interviewer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10057">rdaw:P10057</a>
    /// </summary>
    let P10057 = _prefixId.prefix "P10057"
    /// <summary>
    ///   <para>rdfs:label : has artist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artist</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : artist</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a work by conceiving, and often implementing, an original graphic design, drawing, painting, etc.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a work by conceiving, and often implementing, an original graphic design, drawing, painting, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10058">rdaw:P10058</a>
    /// </summary>
    let P10058 = _prefixId.prefix "P10058"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewee</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent.</para>
    ///   <para>rdfs:label : has interviewee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : interviewee</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10059">rdaw:P10059</a>
    /// </summary>
    let P10059 = _prefixId.prefix "P10059"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : choreographer</para>
    ///   <para>rdfs:label : has choreographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a work of movement.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a work of movement.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10060">rdaw:P10060</a>
    /// </summary>
    let P10060 = _prefixId.prefix "P10060"
    /// <summary>
    ///   <para>rdfs:label : has author</para>
    ///   <para>skos:scopeNote : Use also for persons, etc., creating a new work by paraphrasing, rewriting, or adapting works by another creator if the modification has substantially changed the nature and content of the original or changed the medium of expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : author</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : author</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs).</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10061">rdaw:P10061</a>
    /// </summary>
    let P10061 = _prefixId.prefix "P10061"
    /// <summary>
    ///   <para>rdfs:label : has architect</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : architect</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating an architectural design, including a pictorial representation intended to show how a building, etc., will look when completed.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating an architectural design, including a pictorial representation intended to show how a building, etc., will look when completed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : architect</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10062">rdaw:P10062</a>
    /// </summary>
    let P10062 = _prefixId.prefix "P10062"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for creating an independent or personal film.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for creating an independent or personal film.</para>
    ///   <para>rdfs:label : has filmmaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : filmmaker</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmmaker</para>
    ///   <para>skos:scopeNote : A filmmaker is individually responsible for the conception and execution of all aspects of the film.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10063">rdaw:P10063</a>
    /// </summary>
    let P10063 = _prefixId.prefix "P10063"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for most of the business aspects of a production for screen, sound recording, television, webcast, etc.</para>
    ///   <para>skos:scopeNote : The producer is generally responsible for fund raising, managing the production, hiring key personnel, arranging for distributors, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producer</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for most of the business aspects of a production for screen, sound recording, television, webcast, etc.</para>
    ///   <para>rdfs:label : has producer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10064">rdaw:P10064</a>
    /// </summary>
    let P10064 = _prefixId.prefix "P10064"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : creator</para>
    ///   <para>rdfs:label : has creator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for the creation of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : creator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 19.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for the creation of a work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10065">rdaw:P10065</a>
    /// </summary>
    let P10065 = _prefixId.prefix "P10065"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for the general management and supervision of a filmed performance, a radio or television program, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : director</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : director</para>
    ///   <para>rdfs:label : has director</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for the general management and supervision of a filmed performance, a radio or television program, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10066">rdaw:P10066</a>
    /// </summary>
    let P10066 = _prefixId.prefix "P10066"
    /// <summary>
    ///   <para>rdfs:label : has sponsoring body</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body sponsoring some aspect of a work, e.g., funding research, sponsoring an event.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body sponsoring some aspect of a work, e.g., funding research, sponsoring an event.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sponsoring body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringBody</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10067">rdaw:P10067</a>
    /// </summary>
    let P10067 = _prefixId.prefix "P10067"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body that captures images, either electronically or on film or video stock, and often selects and arranges the lighting.</para>
    ///   <para>rdfs:label : has director of photography</para>
    ///   <para>skos:scopeNote : The director of photography for a movie is also called the chief cinematographer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body that captures images, either electronically or on film or video stock, and often selects and arranges the lighting.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOfPhotography</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : director of photography</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10068">rdaw:P10068</a>
    /// </summary>
    let P10068 = _prefixId.prefix "P10068"
    /// <summary>
    ///   <para>rdfs:label : has dedicatee</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body to whom a work is dedicated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicatee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body to whom a work is dedicated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dedicatee</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10069">rdaw:P10069</a>
    /// </summary>
    let P10069 = _prefixId.prefix "P10069"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body to whom a work or part of a work is addressed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : addressee</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body to whom a work or part of a work is addressed.</para>
    ///   <para>rdfs:label : has addressee</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10070">rdaw:P10070</a>
    /// </summary>
    let P10070 = _prefixId.prefix "P10070"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body who provides consultation services, and often makes recommendations, for another person, family, or corporate body that is represented as the creator of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : consultant</para>
    ///   <para>rdfs:label : has consultant</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body who provides consultation services, and often makes recommendations, for another person, family, or corporate body that is represented as the creator of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : consultant</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10071">rdaw:P10071</a>
    /// </summary>
    let P10071 = _prefixId.prefix "P10071"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a physical embodiment of an expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : manifestation of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A physical embodiment of an expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 17.7^^xsd:string</para>
    ///   <para>rdfs:label : has manifestation of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manifestationOfWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10072">rdaw:P10072</a>
    /// </summary>
    let P10072 = _prefixId.prefix "P10072"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a producer responsible for most of the business aspects of a film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A producer responsible for most of the business aspects of a film.</para>
    ///   <para>rdfs:label : has film producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : film producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmProducer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10073">rdaw:P10073</a>
    /// </summary>
    let P10073 = _prefixId.prefix "P10073"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a producer responsible for most of the business aspects of a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A producer responsible for most of the business aspects of a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : radio producer</para>
    ///   <para>rdfs:label : has radio producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProducer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10074">rdaw:P10074</a>
    /// </summary>
    let P10074 = _prefixId.prefix "P10074"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A producer responsible for most of the business aspects of a television program.</para>
    ///   <para>rdfs:label : has television producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : television producer</para>
    ///   <para>skos:definition : Relates a work to a producer responsible for most of the business aspects of a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProducer</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10075">rdaw:P10075</a>
    /// </summary>
    let P10075 = _prefixId.prefix "P10075"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A radio program based on the source work.</para>
    ///   <para>skos:definition : Relates a work to a radio program based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as radio program (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsRadioProgramWork</para>
    ///   <para>rdfs:label : is adapted as radio program (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10076">rdaw:P10076</a>
    /// </summary>
    let P10076 = _prefixId.prefix "P10076"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a rank conferred as a guarantee of academic proficiency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A rank conferred as a guarantee of academic proficiency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : academicDegree</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.9.2^^xsd:string</para>
    ///   <para>rdfs:label : has academic degree</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : academic degree</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10077">rdaw:P10077</a>
    /// </summary>
    let P10077 = _prefixId.prefix "P10077"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : expression of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expressionOfWork</para>
    ///   <para>skos:definition : Relates a work to a realization of a work in the form of alpha-numeric, musical or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A realization of a work in the form of alpha-numeric, musical or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 17.5^^xsd:string</para>
    ///   <para>rdfs:label : has expression of work</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10078">rdaw:P10078</a>
    /// </summary>
    let P10078 = _prefixId.prefix "P10078"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericDesignationOfAMusicalWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A serial number, opus number, or thematic index number assigned to a musical work by a composer, publisher, or a musicologist.</para>
    ///   <para>rdfs:label : has numeric designation of a musical work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.16^^xsd:string</para>
    ///   <para>skos:definition : Relates a work to a serial number, opus number, or thematic index number assigned to a musical work by a composer, publisher, or a musicologist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : numeric designation of a musical work</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10079">rdaw:P10079</a>
    /// </summary>
    let P10079 = _prefixId.prefix "P10079"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subseries</para>
    ///   <para>skos:definition : Relates a work to a serial or multipart work that consistently appears in a larger work; the title of the larger work appears on all issues or parts of the subseries</para>
    ///   <para>rdfs:label : is subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A serial or multipart work that consistently appears in a larger work; the title of the larger work appears on all issues or parts of the subseries</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseries</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10080">rdaw:P10080</a>
    /// </summary>
    let P10080 = _prefixId.prefix "P10080"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : longitude and latitude</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A system for identifying the area covered by the cartographic content of a resource using longitude of the westernmost and easternmost boundaries and latitude of the northernmost and southernmost boundaries.</para>
    ///   <para>skos:definition : Relates a work to a system for identifying the area covered by the cartographic content of a resource using longitude of the westernmost and easternmost boundaries and latitude of the northernmost and southernmost boundaries.</para>
    ///   <para>rdfs:label : has longitude and latitude</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.4.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : longitudeAndLatitude</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10081">rdaw:P10081</a>
    /// </summary>
    let P10081 = _prefixId.prefix "P10081"
    /// <summary>
    ///   <para>rdfs:label : has right ascension and declination</para>
    ///   <para>skos:definition : Relates a work to a system for identifying the location of a celestial object in the sky covered by the cartographic content of a resource using the angles of right ascension and declination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rightAscensionAndDeclination</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.4.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : right ascension and declination</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A system for identifying the location of a celestial object in the sky covered by the cartographic content of a resource using the angles of right ascension and declination.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10082">rdaw:P10082</a>
    /// </summary>
    let P10082 = _prefixId.prefix "P10082"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A system for identifying the precise area covered by the cartographic content of a resource using coordinates for each vertex of a polygon.</para>
    ///   <para>skos:definition : Relates a work to a system for identifying the precise area covered by the cartographic content of a resource using coordinates for each vertex of a polygon.</para>
    ///   <para>rdfs:label : has strings of coordinate pairs</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stringsOfCoordinatePairs</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : strings of coordinate pairs</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.4.3^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10083">rdaw:P10083</a>
    /// </summary>
    let P10083 = _prefixId.prefix "P10083"
    /// <summary>
    ///   <para>rdfs:label : has system of organization</para>
    ///   <para>skos:definition : Relates a work to a system of arranging materials in an archival resource or a collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : systemOfOrganization</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A system of arranging materials in an archival resource or a collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : system of organization</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10084">rdaw:P10084</a>
    /// </summary>
    let P10084 = _prefixId.prefix "P10084"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsTelevisionProgramWork</para>
    ///   <para>rdfs:label : is adapted as television program (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A television program based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as television program (work)</para>
    ///   <para>skos:definition : Relates a work to a television program based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10085">rdaw:P10085</a>
    /// </summary>
    let P10085 = _prefixId.prefix "P10085"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTitleForTheWork</para>
    ///   <para>skos:definition : Relates a work to a title or form of title by which a work is known that differs from the title or form of title chosen as the preferred title for the work.</para>
    ///   <para>rdfs:label : has variant title for the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.2.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A title or form of title by which a work is known that differs from the title or form of title chosen as the preferred title for the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : variant title for the work</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10086">rdaw:P10086</a>
    /// </summary>
    let P10086 = _prefixId.prefix "P10086"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as video (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsVideoWork</para>
    ///   <para>skos:definition : Relates a work to a video based on the source work.</para>
    ///   <para>rdfs:label : is adapted as video (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A video based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10087">rdaw:P10087</a>
    /// </summary>
    let P10087 = _prefixId.prefix "P10087"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : title of the work</para>
    ///   <para>rdfs:label : has title of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a work to a word, character, or group of words and/or characters by which a work is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleOfTheWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character, or group of words and/or characters by which a work is known.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10088">rdaw:P10088</a>
    /// </summary>
    let P10088 = _prefixId.prefix "P10088"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work (an abstracting and indexing service) that abstracts the contents of a source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedInWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abstracted in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work (an abstracting and indexing service) that abstracts the contents of a source work.</para>
    ///   <para>rdfs:label : is abstracted in (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10089">rdaw:P10089</a>
    /// </summary>
    let P10089 = _prefixId.prefix "P10089"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexedInWork</para>
    ///   <para>rdfs:label : is indexed in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work (an abstracting and indexing service) that indexes the contents of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : indexed in (work)</para>
    ///   <para>skos:definition : Relates a work to a work (an abstracting and indexing service) that indexes the contents of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10090">rdaw:P10090</a>
    /// </summary>
    let P10090 = _prefixId.prefix "P10090"
    /// <summary>
    ///   <para>rdfs:label : is adapted as choreography (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as choreography (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of movement (e.g., dance) based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsChoreographyWork</para>
    ///   <para>skos:definition : Relates a work to a work consisting of movement (e.g., dance) based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10091">rdaw:P10091</a>
    /// </summary>
    let P10091 = _prefixId.prefix "P10091"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataWork</para>
    ///   <para>skos:definition : Relates a work to a work consisting of errors discovered after the publication of the predominant work, with their corrections.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : errata (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of errors discovered after the publication of the predominant work, with their corrections.</para>
    ///   <para>rdfs:label : is errata (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10092">rdaw:P10092</a>
    /// </summary>
    let P10092 = _prefixId.prefix "P10092"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : illustrations (work)</para>
    ///   <para>skos:definition : Relates a work to a work consisting of pictorial content designed to explain or decorate the augmented work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsWork</para>
    ///   <para>rdfs:label : is illustrations (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of pictorial content designed to explain or decorate the augmented work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10093">rdaw:P10093</a>
    /// </summary>
    let P10093 = _prefixId.prefix "P10093"
    /// <summary>
    ///   <para>rdfs:label : is adapted as motion picture screenplay (work)</para>
    ///   <para>skos:definition : Relates a work to a work consisting of the screenplay for a motion picture, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of the screenplay for a motion picture, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsMotionPictureScreenplayWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as motion picture screenplay (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10094">rdaw:P10094</a>
    /// </summary>
    let P10094 = _prefixId.prefix "P10094"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsScreenplayWork</para>
    ///   <para>skos:definition : Relates a work to a work consisting of the screenplay for a motion picture, television program, or video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as a screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of the screenplay for a motion picture, television program, or video, based on the source work.</para>
    ///   <para>rdfs:label : is adapted as screenplay (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10095">rdaw:P10095</a>
    /// </summary>
    let P10095 = _prefixId.prefix "P10095"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of the screenplay for a television program, based on the source work.</para>
    ///   <para>rdfs:label : is adapted as television screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as television screenplay (work)</para>
    ///   <para>skos:definition : Relates a work to a work consisting of the screenplay for a television program, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsTelevisionScreenplayWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10096">rdaw:P10096</a>
    /// </summary>
    let P10096 = _prefixId.prefix "P10096"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work consisting of the screenplay for a video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of the screenplay for a video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as video screenplay (work)</para>
    ///   <para>rdfs:label : is adapted as video screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsVideoScreenplayWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10097">rdaw:P10097</a>
    /// </summary>
    let P10097 = _prefixId.prefix "P10097"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of the script for a radio program, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as radio script (work)</para>
    ///   <para>rdfs:label : is adapted as radio script (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsRadioScriptWork</para>
    ///   <para>skos:definition : Relates a work to a work consisting of the script for a radio program, based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10098">rdaw:P10098</a>
    /// </summary>
    let P10098 = _prefixId.prefix "P10098"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work created by freely translating the source work into another language, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>rdfs:label : is freely translated as (work)</para>
    ///   <para>skos:definition : Relates a work to a work created by freely translating the source work into another language, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : freely translated as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freelyTranslatedAsWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10099">rdaw:P10099</a>
    /// </summary>
    let P10099 = _prefixId.prefix "P10099"
    /// <summary>
    ///   <para>rdfs:label : is description of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfWork</para>
    ///   <para>skos:definition : Relates a work to a work described by a describing work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work described by a describing work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : description of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10100">rdaw:P10100</a>
    /// </summary>
    let P10100 = _prefixId.prefix "P10100"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work in which the part consistently appears; the title of the larger work appears on all issues or parts of the subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subseries of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseriesOf</para>
    ///   <para>rdfs:label : is subseries of</para>
    ///   <para>skos:definition : Relates a work to a work in which the part consistently appears; the title of the larger work appears on all issues or parts of the subseries.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10101">rdaw:P10101</a>
    /// </summary>
    let P10101 = _prefixId.prefix "P10101"
    /// <summary>
    ///   <para>rdfs:label : is in series</para>
    ///   <para>skos:definition : Relates a work to a work in which the part has been issued; the title of the larger work appears on the part.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inSeries</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work in which the part has been issued; the title of the larger work appears on the part.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : in series</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10102">rdaw:P10102</a>
    /// </summary>
    let P10102 = _prefixId.prefix "P10102"
    /// <summary>
    ///   <para>rdfs:label : is complemented by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementedByWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : complemented by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work paired with another work without either work being considered to predominate.</para>
    ///   <para>skos:definition : Relates a work to a work paired with another work without either work being considered to predominate.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10103">rdaw:P10103</a>
    /// </summary>
    let P10103 = _prefixId.prefix "P10103"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work part of whose content separated from an earlier work to form a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work part of whose content separated from an earlier work to form a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : continued in part by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedInPartByWork</para>
    ///   <para>rdfs:label : is continued in part by (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10104">rdaw:P10104</a>
    /// </summary>
    let P10104 = _prefixId.prefix "P10104"
    /// <summary>
    ///   <para>rdfs:label : is screenplay for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work such as a motion picture, television program, or video, that uses the text of the work as a screenplay.</para>
    ///   <para>skos:definition : Relates a work to a work such as a motion picture, television program, or video, that uses the text of the work as a screenplay.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenplay for (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10105">rdaw:P10105</a>
    /// </summary>
    let P10105 = _prefixId.prefix "P10105"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : incidental music for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incidentalMusicForWork</para>
    ///   <para>skos:definition : Relates a work to a work such as a play or other spoken work for the stage that uses the musical work as incidental music.</para>
    ///   <para>rdfs:label : is incidental music for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work such as a play or other spoken work for the stage that uses the musical work as incidental music.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10106">rdaw:P10106</a>
    /// </summary>
    let P10106 = _prefixId.prefix "P10106"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abstracted as (work)</para>
    ///   <para>rdfs:label : is abstracted as (work)</para>
    ///   <para>skos:definition : Relates a work to a work that abbreviates the source work in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that abbreviates the source work in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedAsWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10107">rdaw:P10107</a>
    /// </summary>
    let P10107 = _prefixId.prefix "P10107"
    /// <summary>
    ///   <para>rdfs:label : is augmented by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : augmented by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that adds to the content of a predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentedByWork</para>
    ///   <para>skos:definition : Relates a work to a work that adds to the content of a predominant work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10108">rdaw:P10108</a>
    /// </summary>
    let P10108 = _prefixId.prefix "P10108"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that consists of a brief recapitulation of the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : summarized as (work)</para>
    ///   <para>skos:definition : Relates a work to a work that consists of a brief recapitulation of the content of the source work.</para>
    ///   <para>rdfs:label : is summarized as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summarizedAsWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10109">rdaw:P10109</a>
    /// </summary>
    let P10109 = _prefixId.prefix "P10109"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that consists of a complete enumeration of items arranged systematically.</para>
    ///   <para>rdfs:label : is catalogue (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : catalogue (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that consists of a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10110">rdaw:P10110</a>
    /// </summary>
    let P10110 = _prefixId.prefix "P10110"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : concordance (work)</para>
    ///   <para>rdfs:label : is concordance (work)</para>
    ///   <para>skos:definition : Relates a work to a work that consists of an index of all the words in the predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that consists of an index of all the words in the predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10111">rdaw:P10111</a>
    /// </summary>
    let P10111 = _prefixId.prefix "P10111"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that consists of brief additional material, less extensive than a supplement, but essential to the completeness of the text of the predominant work; it is usually added at the end of the content, but is sometimes issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : addenda (work)</para>
    ///   <para>rdfs:label : is addenda (work)</para>
    ///   <para>skos:definition : Relates a work to a work that consists of brief additional material, less extensive than a supplement, but essential to the completeness of the text of the predominant work; it is usually added at the end of the content, but is sometimes issued separately.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10112">rdaw:P10112</a>
    /// </summary>
    let P10112 = _prefixId.prefix "P10112"
    /// <summary>
    ///   <para>rdfs:label : is adapted as libretto (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work consisting of the text of an opera or other work for the musical stage, or an oratorio, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as libretto (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsLibrettoWork</para>
    ///   <para>skos:definition : Relates a work to a work consisting of the text of an opera or other work for the musical stage, or an oratorio, based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10113">rdaw:P10113</a>
    /// </summary>
    let P10113 = _prefixId.prefix "P10113"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reviewed in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a brief evaluation of the described work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedInWork</para>
    ///   <para>skos:definition : Relates a work to a work that contains a brief evaluation of the described work.</para>
    ///   <para>rdfs:label : is reviewed in (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10114">rdaw:P10114</a>
    /// </summary>
    let P10114 = _prefixId.prefix "P10114"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critiqued in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a critical evaluation of the described work.</para>
    ///   <para>skos:definition : Relates a work to a work that contains a critical evaluation of the described work.</para>
    ///   <para>rdfs:label : is critiqued in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedInWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10115">rdaw:P10115</a>
    /// </summary>
    let P10115 = _prefixId.prefix "P10115"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that contains a set of explanatory or critical notes on the described work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary in (work)</para>
    ///   <para>rdfs:label : is commentary in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a set of explanatory or critical notes on the described work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryInWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10116">rdaw:P10116</a>
    /// </summary>
    let P10116 = _prefixId.prefix "P10116"
    /// <summary>
    ///   <para>rdfs:label : is imitated as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : imitated as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that copies the style or content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitatedAsWork</para>
    ///   <para>skos:definition : Relates a work to a work that copies the style or content of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10117">rdaw:P10117</a>
    /// </summary>
    let P10117 = _prefixId.prefix "P10117"
    /// <summary>
    ///   <para>rdfs:label : is described in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : described in (work)</para>
    ///   <para>skos:definition : Relates a work to a work that describes a described work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that describes a described work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedInWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10118">rdaw:P10118</a>
    /// </summary>
    let P10118 = _prefixId.prefix "P10118"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : expanded as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that enlarges upon the content of the source work.</para>
    ///   <para>rdfs:label : is expanded as (work)</para>
    ///   <para>skos:definition : Relates a work to a work that enlarges upon the content of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10119">rdaw:P10119</a>
    /// </summary>
    let P10119 = _prefixId.prefix "P10119"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluated in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that examines or judges the described work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedInWork</para>
    ///   <para>rdfs:label : is evaluated in (work)</para>
    ///   <para>skos:definition : Relates a work to a work that examines or judges the described work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10120">rdaw:P10120</a>
    /// </summary>
    let P10120 = _prefixId.prefix "P10120"
    /// <summary>
    ///   <para>rdfs:label : is analysed in (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysed in (work)</para>
    ///   <para>skos:definition : Relates a work to a work that examines the source work to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that examines the source work to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedInWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10121">rdaw:P10121</a>
    /// </summary>
    let P10121 = _prefixId.prefix "P10121"
    /// <summary>
    ///   <para>rdfs:label : is prequel</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that extends the narrative of an earlier work backwards in time.</para>
    ///   <para>skos:definition : Relates a work to a work that extends the narrative of an earlier work backwards in time.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : prequel</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequel</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10122">rdaw:P10122</a>
    /// </summary>
    let P10122 = _prefixId.prefix "P10122"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appendix (work)</para>
    ///   <para>skos:definition : Relates a work to a work that forms an augmenting part of another work which is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; it can either be material which comes at the end of the content of the predominant work, or be issued separately.</para>
    ///   <para>rdfs:label : is appendix (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that forms an augmenting part of another work which is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; it can either be material which comes at the end of the content of the predominant work, or be issued separately.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10123">rdaw:P10123</a>
    /// </summary>
    let P10123 = _prefixId.prefix "P10123"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that guides a user through the use of the predominant work, using notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>skos:definition : Relates a work to a work that guides a user through the use of the predominant work, using notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : guide (work)</para>
    ///   <para>rdfs:label : is guide (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10124">rdaw:P10124</a>
    /// </summary>
    let P10124 = _prefixId.prefix "P10124"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been abridged, i.e., shortened without changing the general meaning or manner of presentation of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgementOfWork</para>
    ///   <para>rdfs:label : is abridgement of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that has been abridged, i.e., shortened without changing the general meaning or manner of presentation of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abridgement of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10125">rdaw:P10125</a>
    /// </summary>
    let P10125 = _prefixId.prefix "P10125"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abstract of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that has been abstracted, i.e., abbreviated in a brief, objective manner.</para>
    ///   <para>rdfs:label : is abstract of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been abstracted, i.e., abbreviated in a brief, objective manner.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10126">rdaw:P10126</a>
    /// </summary>
    let P10126 = _prefixId.prefix "P10126"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a drama.</para>
    ///   <para>rdfs:label : is dramatization of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a drama.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dramatization of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10127">rdaw:P10127</a>
    /// </summary>
    let P10127 = _prefixId.prefix "P10127"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationOfWork</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a literary composition in verse form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a literary composition in verse form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : verse adaptation of (work)</para>
    ///   <para>rdfs:label : is verse adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10128">rdaw:P10128</a>
    /// </summary>
    let P10128 = _prefixId.prefix "P10128"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a motion picture.</para>
    ///   <para>rdfs:label : is motion picture adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureAdaptationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : motion picture adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10129">rdaw:P10129</a>
    /// </summary>
    let P10129 = _prefixId.prefix "P10129"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a novel.</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a novel.</para>
    ///   <para>rdfs:label : is novelization of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : novelization of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10130">rdaw:P10130</a>
    /// </summary>
    let P10130 = _prefixId.prefix "P10130"
    /// <summary>
    ///   <para>rdfs:label : is radio adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioAdaptationOfWork</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : radio adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10131">rdaw:P10131</a>
    /// </summary>
    let P10131 = _prefixId.prefix "P10131"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : television adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a television program.</para>
    ///   <para>rdfs:label : is television adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionAdaptationOfWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10132">rdaw:P10132</a>
    /// </summary>
    let P10132 = _prefixId.prefix "P10132"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenplay based on (work)</para>
    ///   <para>rdfs:label : is screenplay based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as the screenplay for a motion picture, television program, or video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayBasedOnWork</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as the screenplay for a motion picture, television program, or video.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10133">rdaw:P10133</a>
    /// </summary>
    let P10133 = _prefixId.prefix "P10133"
    /// <summary>
    ///   <para>rdfs:label : is motion picture screenplay based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayBasedOnWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : motion picture screenplay based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as the screenplay for a motion picture.</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as the screenplay for a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10134">rdaw:P10134</a>
    /// </summary>
    let P10134 = _prefixId.prefix "P10134"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as the screenplay for a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : television screenplay based on (work)</para>
    ///   <para>rdfs:label : is television screenplay based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as the screenplay for a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayBasedOnWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10135">rdaw:P10135</a>
    /// </summary>
    let P10135 = _prefixId.prefix "P10135"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as the screenplay for a video.</para>
    ///   <para>rdfs:label : is video screenplay based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayBasedOnWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video screenplay based on (work)</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as the screenplay for a video.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10136">rdaw:P10136</a>
    /// </summary>
    let P10136 = _prefixId.prefix "P10136"
    /// <summary>
    ///   <para>rdfs:label : is radio script based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptBasedOnWork</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as the script for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : radio script based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as the script for a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10137">rdaw:P10137</a>
    /// </summary>
    let P10137 = _prefixId.prefix "P10137"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted for video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoAdaptationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video adaptation of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted for video.</para>
    ///   <para>rdfs:label : is video adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10138">rdaw:P10138</a>
    /// </summary>
    let P10138 = _prefixId.prefix "P10138"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been digested, i.e., systematically and comprehensively condensed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been digested, i.e., systematically and comprehensively condensed.</para>
    ///   <para>rdfs:label : is digest of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digest of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10139">rdaw:P10139</a>
    /// </summary>
    let P10139 = _prefixId.prefix "P10139"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfWork</para>
    ///   <para>rdfs:label : is analysis of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysis of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been examined to identify its components and their relations.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10140">rdaw:P10140</a>
    /// </summary>
    let P10140 = _prefixId.prefix "P10140"
    /// <summary>
    ///   <para>rdfs:label : is series container of</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been issued as part of a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesContainerOf</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : series container of</para>
    ///   <para>skos:definition : Relates a work to a work that has been issued as part of a series.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10141">rdaw:P10141</a>
    /// </summary>
    let P10141 = _prefixId.prefix "P10141"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been modified for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adaptation of (work)</para>
    ///   <para>skos:scopeNote : Applies to changes in form or to works completely rewritten in the same form.</para>
    ///   <para>skos:definition : Relates a work to a work that has been modified for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>rdfs:label : is adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10142">rdaw:P10142</a>
    /// </summary>
    let P10142 = _prefixId.prefix "P10142"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been translated freely, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freeTranslationOfWork</para>
    ///   <para>skos:definition : Relates a work to a work that has been translated freely, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : free translation of (work)</para>
    ///   <para>rdfs:label : is free translation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10143">rdaw:P10143</a>
    /// </summary>
    let P10143 = _prefixId.prefix "P10143"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that imitates the style or content of the source work for comic effect.</para>
    ///   <para>rdfs:label : is parodied as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodiedAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parodied as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that imitates the style or content of the source work for comic effect.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10144">rdaw:P10144</a>
    /// </summary>
    let P10144 = _prefixId.prefix "P10144"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : absorbed by (work)</para>
    ///   <para>skos:definition : Relates a work to a work that incorporates another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that incorporates another work.</para>
    ///   <para>rdfs:label : is absorbed by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedByWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10145">rdaw:P10145</a>
    /// </summary>
    let P10145 = _prefixId.prefix "P10145"
    /// <summary>
    ///   <para>rdfs:label : is absorbed in part by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartByWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : absorbed in part by (work)</para>
    ///   <para>skos:definition : Relates a work to a work that incorporates part of the content of another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that incorporates part of the content of another work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10146">rdaw:P10146</a>
    /// </summary>
    let P10146 = _prefixId.prefix "P10146"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that is a discrete component of a larger work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containerOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is a discrete component of a larger work.</para>
    ///   <para>rdfs:label : is container of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : container of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10147">rdaw:P10147</a>
    /// </summary>
    let P10147 = _prefixId.prefix "P10147"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : derivative (work)</para>
    ///   <para>rdfs:label : is derivative (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is a modification of a source work.</para>
    ///   <para>skos:definition : Relates a work to a work that is a modification of a source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10148">rdaw:P10148</a>
    /// </summary>
    let P10148 = _prefixId.prefix "P10148"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : errata to (work)</para>
    ///   <para>rdfs:label : is errata to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is augmented by a list of errors in the predominant work, discovered after publication, with their corrections.</para>
    ///   <para>skos:definition : Relates a work to a work that is augmented by a list of errors in the predominant work, discovered after publication, with their corrections.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataToWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10149">rdaw:P10149</a>
    /// </summary>
    let P10149 = _prefixId.prefix "P10149"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that is augmented by another work consisting of material to help the user of the predominant work, such as notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideToWork</para>
    ///   <para>rdfs:label : is guide to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : guide to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is augmented by another work consisting of material to help the user of the predominant work, such as notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10150">rdaw:P10150</a>
    /// </summary>
    let P10150 = _prefixId.prefix "P10150"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that is augmented by another work that consists of material that is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; the augmenting work can either come at the end of the content, or be issued separately.</para>
    ///   <para>rdfs:label : is appendix to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : appendix to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is augmented by another work that consists of material that is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; the augmenting work can either come at the end of the content, or be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixToWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10151">rdaw:P10151</a>
    /// </summary>
    let P10151 = _prefixId.prefix "P10151"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is augmented by pictorial content designed to explain or decorate it.</para>
    ///   <para>skos:definition : Relates a work to a work that is augmented by pictorial content designed to explain or decorate it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsForWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : illustrations for (work)</para>
    ///   <para>rdfs:label : is illustrations for (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10152">rdaw:P10152</a>
    /// </summary>
    let P10152 = _prefixId.prefix "P10152"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfWork</para>
    ///   <para>rdfs:label : is evaluation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluation of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that is examined or judged.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10153">rdaw:P10153</a>
    /// </summary>
    let P10153 = _prefixId.prefix "P10153"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : supplement to (work)</para>
    ///   <para>rdfs:label : is supplement to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is updated or otherwise complemented by the augmenting work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementToWork</para>
    ///   <para>skos:definition : Relates a work to a work that is updated or otherwise complemented by the augmenting work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10154">rdaw:P10154</a>
    /// </summary>
    let P10154 = _prefixId.prefix "P10154"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that modifies the source work for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that modifies the source work for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>skos:scopeNote : Applies to changes in form or to works completely rewritten in the same form.</para>
    ///   <para>rdfs:label : is adapted as (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10155">rdaw:P10155</a>
    /// </summary>
    let P10155 = _prefixId.prefix "P10155"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preceded by (work)</para>
    ///   <para>rdfs:label : is preceded by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that precedes (e.g., is earlier in time or before in a narrative) the succeeding work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : precededByWork</para>
    ///   <para>skos:definition : Relates a work to a work that precedes (e.g., is earlier in time or before in a narrative) the succeeding work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10156">rdaw:P10156</a>
    /// </summary>
    let P10156 = _prefixId.prefix "P10156"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that provides a guide to the organization, arrangement, and contents of an archival collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides a guide to the organization, arrangement, and contents of an archival collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : finding aid (work)</para>
    ///   <para>rdfs:label : is finding aid (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10157">rdaw:P10157</a>
    /// </summary>
    let P10157 = _prefixId.prefix "P10157"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that provides a systematic, alphabetical guide to the contents of the predominant work, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : index (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides a systematic, alphabetical guide to the contents of the predominant work, usually keyed to page numbers or other reference codes.</para>
    ///   <para>rdfs:label : is index (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10158">rdaw:P10158</a>
    /// </summary>
    let P10158 = _prefixId.prefix "P10158"
    /// <summary>
    ///   <para>rdfs:label : is screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text for a motion picture, television program or video.</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text for a motion picture, television program or video.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10159">rdaw:P10159</a>
    /// </summary>
    let P10159 = _prefixId.prefix "P10159"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayWork</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text for a motion picture.</para>
    ///   <para>rdfs:label : is motion picture screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : motion picture screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text for a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10160">rdaw:P10160</a>
    /// </summary>
    let P10160 = _prefixId.prefix "P10160"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text for a non-dramatic musical work, other than an oratorio.</para>
    ///   <para>rdfs:label : is musical setting of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text for a non-dramatic musical work, other than an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : musical setting of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10161">rdaw:P10161</a>
    /// </summary>
    let P10161 = _prefixId.prefix "P10161"
    /// <summary>
    ///   <para>rdfs:label : is radio script (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptWork</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : radio script (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10162">rdaw:P10162</a>
    /// </summary>
    let P10162 = _prefixId.prefix "P10162"
    /// <summary>
    ///   <para>rdfs:label : is television screenplay (work)</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text for a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : television screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text for a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10163">rdaw:P10163</a>
    /// </summary>
    let P10163 = _prefixId.prefix "P10163"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayWork</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text for a video.</para>
    ///   <para>rdfs:label : is video screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video screenplay (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text for a video.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10164">rdaw:P10164</a>
    /// </summary>
    let P10164 = _prefixId.prefix "P10164"
    /// <summary>
    ///   <para>rdfs:label : is libretto (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoWork</para>
    ///   <para>skos:definition : Relates a work to a work that provides the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : libretto (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10165">rdaw:P10165</a>
    /// </summary>
    let P10165 = _prefixId.prefix "P10165"
    /// <summary>
    ///   <para>rdfs:label : is paraphrased as (work)</para>
    ///   <para>skos:definition : Relates a work to a work that restates the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that restates the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphrasedAsWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : paraphrased as (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10166">rdaw:P10166</a>
    /// </summary>
    let P10166 = _prefixId.prefix "P10166"
    /// <summary>
    ///   <para>rdfs:label : is abridged as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that shortens the source work without changing the general meaning or manner of presentation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abridged as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgedAsWork</para>
    ///   <para>skos:definition : Relates a work to a work that shortens the source work without changing the general meaning or manner of presentation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10167">rdaw:P10167</a>
    /// </summary>
    let P10167 = _prefixId.prefix "P10167"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuationInPartOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that split into two or more separate works with new titles.</para>
    ///   <para>skos:definition : Relates a work to a work that split into two or more separate works with new titles.</para>
    ///   <para>rdfs:label : is continuation in part of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : continuation in part of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10168">rdaw:P10168</a>
    /// </summary>
    let P10168 = _prefixId.prefix "P10168"
    /// <summary>
    ///   <para>rdfs:label : is separated from (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : separated from (work)</para>
    ///   <para>skos:definition : Relates a work to a work that spun off a part of its content to form a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : separatedFromWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that spun off a part of its content to form a new work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10169">rdaw:P10169</a>
    /// </summary>
    let P10169 = _prefixId.prefix "P10169"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that succeeds (e.g., later in time or after in a narrative) the preceding work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : succeededByWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that succeeds (e.g., later in time or after in a narrative) the preceding work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : succeeded by (work)</para>
    ///   <para>rdfs:label : is succeeded by (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10170">rdaw:P10170</a>
    /// </summary>
    let P10170 = _prefixId.prefix "P10170"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digested as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestedAsWork</para>
    ///   <para>rdfs:label : is digested as (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that systematically and comprehensively condenses the source work.</para>
    ///   <para>skos:definition : Relates a work to a work that systematically and comprehensively condenses the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10171">rdaw:P10171</a>
    /// </summary>
    let P10171 = _prefixId.prefix "P10171"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that updates or otherwise complements the predominant work.</para>
    ///   <para>rdfs:label : is supplement (work)</para>
    ///   <para>skos:definition : Relates a work to a work that updates or otherwise complements the predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : supplement (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10172">rdaw:P10172</a>
    /// </summary>
    let P10172 = _prefixId.prefix "P10172"
    /// <summary>
    ///   <para>rdfs:label : is screenplay for motion picture (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheMotionPictureWork</para>
    ///   <para>skos:definition : Relates a work to a work that uses the text as a screenplay for a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenplay for motion picture (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the text as a screenplay for a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10173">rdaw:P10173</a>
    /// </summary>
    let P10173 = _prefixId.prefix "P10173"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenplay for television program (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheTelevisionProgramWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the text as a screenplay for a television program.</para>
    ///   <para>rdfs:label : is screenplay for television program (work)</para>
    ///   <para>skos:definition : Relates a work to a work that uses the text as a screenplay for a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10174">rdaw:P10174</a>
    /// </summary>
    let P10174 = _prefixId.prefix "P10174"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenplay for video (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the text as a screenplay for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheVideoWork</para>
    ///   <para>rdfs:label : is screenplay for video (work)</para>
    ///   <para>skos:definition : Relates a work to a work that uses the text as a screenplay for a video.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10175">rdaw:P10175</a>
    /// </summary>
    let P10175 = _prefixId.prefix "P10175"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptForTheRadioProgramWork</para>
    ///   <para>skos:definition : Relates a work to a work that uses the text as the script for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : script for radio program (work)</para>
    ///   <para>rdfs:label : is script for radio program (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the text as the script for a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10176">rdaw:P10176</a>
    /// </summary>
    let P10176 = _prefixId.prefix "P10176"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work to which is added brief additional material, less extensive than a supplement, but essential to the completeness of the content of the work; it is usually added at the end of the work, but is sometimes issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaToWork</para>
    ///   <para>skos:definition : Relates a work to a work to which is added brief additional material, less extensive than a supplement, but essential to the completeness of the content of the work; it is usually added at the end of the work, but is sometimes issued separately.</para>
    ///   <para>rdfs:label : is addenda to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : addenda to (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10177">rdaw:P10177</a>
    /// </summary>
    let P10177 = _prefixId.prefix "P10177"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a brief evaluation.</para>
    ///   <para>rdfs:label : is review of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a brief evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : review of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10178">rdaw:P10178</a>
    /// </summary>
    let P10178 = _prefixId.prefix "P10178"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a brief recapitulation of its content.</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a brief recapitulation of its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryOfWork</para>
    ///   <para>rdfs:label : is summary of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : summary of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10179">rdaw:P10179</a>
    /// </summary>
    let P10179 = _prefixId.prefix "P10179"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a catalogue, i.e., a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : catalogue of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a catalogue, i.e., a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueOfWork</para>
    ///   <para>rdfs:label : is catalogue of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10180">rdaw:P10180</a>
    /// </summary>
    let P10180 = _prefixId.prefix "P10180"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceToWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a concordance, i.e. an index of all the words in the predominant work.</para>
    ///   <para>rdfs:label : is concordance to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : concordance to (work)</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a concordance, i.e. an index of all the words in the predominant work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10181">rdaw:P10181</a>
    /// </summary>
    let P10181 = _prefixId.prefix "P10181"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfWork</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critique of (work)</para>
    ///   <para>rdfs:label : is critique of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a critical evaluation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10182">rdaw:P10182</a>
    /// </summary>
    let P10182 = _prefixId.prefix "P10182"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a work consisting of movement (e.g., dance).</para>
    ///   <para>rdfs:label : is choreographic adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographicAdaptationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used that has been adapted as a work consisting of movement (e.g., dance).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : choreographic adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10183">rdaw:P10183</a>
    /// </summary>
    let P10183 = _prefixId.prefix "P10183"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedVersionOfWork</para>
    ///   <para>rdfs:label : is expanded version of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a derivative work that enlarges upon the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : expanded version of (work)</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a derivative work that enlarges upon the content of the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10184">rdaw:P10184</a>
    /// </summary>
    let P10184 = _prefixId.prefix "P10184"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : remake of (work)</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a new motion picture, radio program, television program, or video.</para>
    ///   <para>rdfs:label : is remake of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a new motion picture, radio program, television program, or video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remakeOfWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10185">rdaw:P10185</a>
    /// </summary>
    let P10185 = _prefixId.prefix "P10185"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : paraphrase of (work)</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a paraphrase, i.e., a restating of the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a paraphrase, i.e., a restating of the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphraseOfWork</para>
    ///   <para>rdfs:label : is paraphrase of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10186">rdaw:P10186</a>
    /// </summary>
    let P10186 = _prefixId.prefix "P10186"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>rdfs:label : is commentary on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary on (work)</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for a set of explanatory or critical notes.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10187">rdaw:P10187</a>
    /// </summary>
    let P10187 = _prefixId.prefix "P10187"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : index to (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexToWork</para>
    ///   <para>skos:definition : Relates a work to a work used as the basis for an index, i.e., a systematic, alphabetical guide to the contents of the predominant work, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for an index, i.e., a systematic, alphabetical guide to the contents of the predominant work, usually keyed to page numbers or other reference codes.</para>
    ///   <para>rdfs:label : is index to (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10188">rdaw:P10188</a>
    /// </summary>
    let P10188 = _prefixId.prefix "P10188"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : libretto based on (work)</para>
    ///   <para>rdfs:label : is libretto based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoBasedOnWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the basis for the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10189">rdaw:P10189</a>
    /// </summary>
    let P10189 = _prefixId.prefix "P10189"
    /// <summary>
    ///   <para>rdfs:label : is based on (work)</para>
    ///   <para>skos:definition : Relates a work to a work used as the source for a derivative work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : based on (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work used as the source for a derivative work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basedOnWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10190">rdaw:P10190</a>
    /// </summary>
    let P10190 = _prefixId.prefix "P10190"
    /// <summary>
    ///   <para>rdfs:label : is continued by (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose content continues an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : continued by (work)</para>
    ///   <para>skos:definition : Relates a work to a work whose content continues an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedByWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10191">rdaw:P10191</a>
    /// </summary>
    let P10191 = _prefixId.prefix "P10191"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : augmentation of (work)</para>
    ///   <para>rdfs:label : is augmentation of (work)</para>
    ///   <para>skos:definition : Relates a work to a work whose content is added to by another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose content is added to by another work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10192">rdaw:P10192</a>
    /// </summary>
    let P10192 = _prefixId.prefix "P10192"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : abstracts for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose contents have been abstracted by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractsForWork</para>
    ///   <para>rdfs:label : is abstracts for (work)</para>
    ///   <para>skos:definition : Relates a work to a work whose contents have been abstracted by an abstracting and indexing service.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10193">rdaw:P10193</a>
    /// </summary>
    let P10193 = _prefixId.prefix "P10193"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose contents have been indexed by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexingForWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : indexing for (work)</para>
    ///   <para>skos:definition : Relates a work to a work whose contents have been indexed by an abstracting and indexing service.</para>
    ///   <para>rdfs:label : is indexing for (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10194">rdaw:P10194</a>
    /// </summary>
    let P10194 = _prefixId.prefix "P10194"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : prequel to</para>
    ///   <para>skos:definition : Relates a work to a work whose narrative is extended backwards in time by the later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequelTo</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose narrative is extended backwards in time by the later work.</para>
    ///   <para>rdfs:label : is prequel to</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10195">rdaw:P10195</a>
    /// </summary>
    let P10195 = _prefixId.prefix "P10195"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose style or content is copied in a derivative work.</para>
    ///   <para>skos:definition : Relates a work to a work whose style or content is copied in a derivative work.</para>
    ///   <para>rdfs:label : is imitation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitationOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : imitation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10196">rdaw:P10196</a>
    /// </summary>
    let P10196 = _prefixId.prefix "P10196"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work whose style or content is imitated for comic effect.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : parody of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodyOfWork</para>
    ///   <para>rdfs:label : is parody of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work whose style or content is imitated for comic effect.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10197">rdaw:P10197</a>
    /// </summary>
    let P10197 = _prefixId.prefix "P10197"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work, represented by an identifier, an authorized access point, or a description, that is related to the work being described (e.g., an adaptation, commentary, supplement, sequel, part of a larger work).</para>
    ///   <para>rdfs:label : has related work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work, represented by an identifier, an authorized access point, or a description, that is related to the work being described (e.g., an adaptation, commentary, supplement, sequel, part of a larger work).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 25.1^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10198">rdaw:P10198</a>
    /// </summary>
    let P10198 = _prefixId.prefix "P10198"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : epoch</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.6^^xsd:string</para>
    ///   <para>rdfs:label : has epoch</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An arbitrary moment in time to which measurements of position for a body or orientation for an orbit are referred.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : epoch</para>
    ///   <para>skos:definition : Relates a work to an arbitrary moment in time to which measurements of position for a body or orientation for an orbit are referred.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10199">rdaw:P10199</a>
    /// </summary>
    let P10199 = _prefixId.prefix "P10199"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : landscape architect</para>
    ///   <para>skos:definition : Relates a work to an architect responsible for creating landscape works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : landscapeArchitect</para>
    ///   <para>rdfs:label : has landscape architect</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An architect responsible for creating landscape works.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10200">rdaw:P10200</a>
    /// </summary>
    let P10200 = _prefixId.prefix "P10200"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : finding aid for (work)</para>
    ///   <para>rdfs:label : is finding aid for (work)</para>
    ///   <para>skos:definition : Relates a work to an archival collection that is described in a finding aid, i.e., a guide to the organization, arrangement, and contents of the collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An archival collection that is described in a finding aid, i.e., a guide to the organization, arrangement, and contents of the collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidForWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10201">rdaw:P10201</a>
    /// </summary>
    let P10201 = _prefixId.prefix "P10201"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an artist responsible for creating a three-dimensional work by modeling, carving, or similar technique.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sculptor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sculptor</para>
    ///   <para>rdfs:label : has sculptor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An artist responsible for creating a three-dimensional work by modeling, carving, or similar technique.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10202">rdaw:P10202</a>
    /// </summary>
    let P10202 = _prefixId.prefix "P10202"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenwriter</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An author of a screenplay, script, or scene.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : screenwriter</para>
    ///   <para>rdfs:label : has screenwriter</para>
    ///   <para>skos:definition : Relates a work to an author of a screenplay, script, or scene.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10203">rdaw:P10203</a>
    /// </summary>
    let P10203 = _prefixId.prefix "P10203"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an author of the words of a popular song, including a song or songs from a musical.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : lyricist</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An author of the words of a popular song, including a song or songs from a musical.</para>
    ///   <para>rdfs:label : has lyricist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lyricist</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10204">rdaw:P10204</a>
    /// </summary>
    let P10204 = _prefixId.prefix "P10204"
    /// <summary>
    ///   <para>rdfs:label : has librettist</para>
    ///   <para>skos:definition : Relates a work to an author of the words of an opera or other musical stage work, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : librettist</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An author of the words of an opera or other musical stage work, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettist</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10205">rdaw:P10205</a>
    /// </summary>
    let P10205 = _prefixId.prefix "P10205"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An earlier work whose content has been partially replaced by a later work, usually because the later work contains updated or new information that makes the earlier work obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacementInPartOfWork</para>
    ///   <para>skos:definition : Relates a work to an earlier work whose content has been partially replaced by a later work, usually because the later work contains updated or new information that makes the earlier work obsolete.</para>
    ///   <para>rdfs:label : is replacement in part of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : replacement in part of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10206">rdaw:P10206</a>
    /// </summary>
    let P10206 = _prefixId.prefix "P10206"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an earlier work whose content has been replaced by a later work, usually because the later work contains updated or new information that makes the earlier work obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An earlier work whose content has been replaced by a later work, usually because the later work contains updated or new information that makes the earlier work obsolete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : replacementOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : replacement of (work)</para>
    ///   <para>rdfs:label : is replacement of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10207">rdaw:P10207</a>
    /// </summary>
    let P10207 = _prefixId.prefix "P10207"
    /// <summary>
    ///   <para>rdfs:label : has granting institution or faculty</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An institution or faculty conferring an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.9.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : granting institution or faculty</para>
    ///   <para>skos:definition : Relates a work to an institution or faculty conferring an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grantingInstitutionOrFaculty</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10208">rdaw:P10208</a>
    /// </summary>
    let P10208 = _prefixId.prefix "P10208"
    /// <summary>
    ///   <para>skos:definition : Relates a work to information about a work presented as part of the formal requirements for an academic degree.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.9^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dissertationOrThesisInformation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dissertation or thesis information</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information about a work presented as part of the formal requirements for an academic degree.</para>
    ///   <para>rdfs:label : has dissertation or thesis information</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10209">rdaw:P10209</a>
    /// </summary>
    let P10209 = _prefixId.prefix "P10209"
    /// <summary>
    ///   <para>skos:definition : Relates a work to information about the history of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : historyOfTheWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : history of the work</para>
    ///   <para>rdfs:label : has history of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information about the history of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.7^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10210">rdaw:P10210</a>
    /// </summary>
    let P10210 = _prefixId.prefix "P10210"
    /// <summary>
    ///   <para>skos:definition : Relates a work to one of two or more works resulting from the division of an earlier work into separate works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : One of two or more works resulting from the division of an earlier work into separate works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : split into (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : splitIntoWork</para>
    ///   <para>rdfs:label : is split into (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10211">rdaw:P10211</a>
    /// </summary>
    let P10211 = _prefixId.prefix "P10211"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : merged to form (work)</para>
    ///   <para>skos:definition : Relates a work to a work formed from the coming together of two or more works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergedToFormWork</para>
    ///   <para>rdfs:label : is merged to form (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work formed from the coming together of two or more works.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10212">rdaw:P10212</a>
    /// </summary>
    let P10212 = _prefixId.prefix "P10212"
    /// <summary>
    ///   <para>rdfs:label : is merger of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that came together with one or more other works to form the new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that came together with one or more other works to form the new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : merger of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergerOfWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10213">rdaw:P10213</a>
    /// </summary>
    let P10213 = _prefixId.prefix "P10213"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : equinox</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equinox</para>
    ///   <para>rdfs:label : has equinox</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : One of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0�.</para>
    ///   <para>skos:definition : Relates a work to one of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0°.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10214">rdaw:P10214</a>
    /// </summary>
    let P10214 = _prefixId.prefix "P10214"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : year degree granted</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The calendar year in which a granting institution or faculty conferred an academic degree on a candidate.</para>
    ///   <para>rdfs:label : has year degree granted</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : yearDegreeGranted</para>
    ///   <para>skos:definition : Relates a work to the calendar year in which a granting institution or faculty conferred an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.9.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10215">rdaw:P10215</a>
    /// </summary>
    let P10215 = _prefixId.prefix "P10215"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The chronological or geographic coverage of the content of a resource.</para>
    ///   <para>rdfs:label : has coverage of the content</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : coverage of the content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coverageOfTheContent</para>
    ///   <para>skos:definition : Relates a work to the chronological or geographic coverage of the content of a resource.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10216">rdaw:P10216</a>
    /// </summary>
    let P10216 = _prefixId.prefix "P10216"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the class of user for which the content of a resource is intended, or for whom the content is considered suitable.</para>
    ///   <para>skos:scopeNote : The class of user is defined by age group (e.g., children, young adults, adults), educational level (e.g., primary, secondary), type of disability, or another categorization.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : intended audience</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The class of user for which the content of a resource is intended, or for whom the content is considered suitable.</para>
    ///   <para>rdfs:label : has intended audience</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intendedAudience</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10217">rdaw:P10217</a>
    /// </summary>
    let P10217 = _prefixId.prefix "P10217"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the country or other territorial jurisdiction from which a work originated.</para>
    ///   <para>rdfs:label : has place of origin of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of origin of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The country or other territorial jurisdiction from which a work originated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfOriginOfTheWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10218">rdaw:P10218</a>
    /// </summary>
    let P10218 = _prefixId.prefix "P10218"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the earliest date associated with a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The earliest date associated with a work.</para>
    ///   <para>rdfs:label : has date of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.4^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10219">rdaw:P10219</a>
    /// </summary>
    let P10219 = _prefixId.prefix "P10219"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The instrument, instruments, voice, voices, etc., for which a musical work was originally conceived.</para>
    ///   <para>skos:definition : Relates a work to the instrument, instruments, voice, voices, etc., for which a musical work was originally conceived.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformance</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : medium of performance</para>
    ///   <para>rdfs:label : has medium of performance</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.15^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10220">rdaw:P10220</a>
    /// </summary>
    let P10220 = _prefixId.prefix "P10220"
    /// <summary>
    ///   <para>skos:scopeNote : Key is indicated by its pitch name and its mode, when it is major or minor.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : key</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The set of pitch relationships that establishes the tonal centre, or principal tonal centre, of a musical work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : key</para>
    ///   <para>rdfs:label : has key</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.17^^xsd:string</para>
    ///   <para>skos:definition : Relates a work to the set of pitch relationships that establishes the tonal centre, or principal tonal centre, of a musical work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10221">rdaw:P10221</a>
    /// </summary>
    let P10221 = _prefixId.prefix "P10221"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : nature of the content</para>
    ///   <para>skos:definition : Relates a work to the specific character of the primary content of a resource (e.g., legal articles, interim report).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The specific character of the primary content of a resource (e.g., legal articles, interim report).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 7.2^^xsd:string</para>
    ///   <para>rdfs:label : has nature of the content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : natureOfTheContent</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10222">rdaw:P10222</a>
    /// </summary>
    let P10222 = _prefixId.prefix "P10222"
    /// <summary>
    ///   <para>skos:scopeNote : The preferred title is also the basis for the authorized access point representing that work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preferred title for the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 6.2.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The title or form of title chosen to identify the work.</para>
    ///   <para>rdfs:label : has preferred title for the work</para>
    ///   <para>skos:definition : Relates a work to the title or form of title chosen to identify the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredTitleForTheWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10223">rdaw:P10223</a>
    /// </summary>
    let P10223 = _prefixId.prefix "P10223"
    /// <summary>
    ///   <para>rdfs:label : is absorption of (work)</para>
    ///   <para>skos:definition : Relates a work to the work that has been incorporated into another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorptionOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : absorption of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The work that has been incorporated into another work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10224">rdaw:P10224</a>
    /// </summary>
    let P10224 = _prefixId.prefix "P10224"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the work that has been partially incorporated into another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The work that has been partially incorporated into another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorptionInPartOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : absorption in part of (work)</para>
    ///   <para>rdfs:label : is absorption in part of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10225">rdaw:P10225</a>
    /// </summary>
    let P10225 = _prefixId.prefix "P10225"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuationOfWork</para>
    ///   <para>skos:definition : Relates a work to the work that is continued by the content of a later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The work that is continued by the content of a later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : continuation of (work)</para>
    ///   <para>rdfs:label : is continuation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10226">rdaw:P10226</a>
    /// </summary>
    let P10226 = _prefixId.prefix "P10226"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequelTo</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sequel to</para>
    ///   <para>rdfs:label : is sequel to</para>
    ///   <para>skos:definition : Relates a work to the work whose narrative is continued by the later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The work whose narrative is continued by the later work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10227">rdaw:P10227</a>
    /// </summary>
    let P10227 = _prefixId.prefix "P10227"
    /// <summary>
    ///   <para>rdfs:label : has accompanying work relationship with</para>
    ///   <para>skos:definition : Relates a work to a work that is an augmentation of, or is augmented by, or is complemented by the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingWorkRelationship</para>
    ///   <para>skos:scopeNote : Accompanying works include supplements, concordances, indexes, catalogues, teacher’s guides, music for a motion picture, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : accompanying work relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is an augmentation of, or is augmented by, or is complemented by the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10228">rdaw:P10228</a>
    /// </summary>
    let P10228 = _prefixId.prefix "P10228"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that is based on or is a derivative of the work.</para>
    ///   <para>skos:scopeNote : Derivative works include summaries, abstracts, digests, adaptations, dramatizations, novelizations, screenplays, free translations, paraphrases, imitations, parodies, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeWorkRelationship</para>
    ///   <para>rdfs:label : has derivative work relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : derivative work relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is based on or is a derivative of the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10229">rdaw:P10229</a>
    /// </summary>
    let P10229 = _prefixId.prefix "P10229"
    let P10230 = _prefixId.prefix "P10230"
    /// <summary>
    ///   <para>rdfs:label : has sequential work relationship with</para>
    ///   <para>skos:definition : Relates a work to a work that is preceded by or succeeded by the work.</para>
    ///   <para>skos:scopeNote : Sequential works include sequels, prequels, continuations, superseding works, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sequential work relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialWorkRelationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is preceded by or succeeded by the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10231">rdaw:P10231</a>
    /// </summary>
    let P10231 = _prefixId.prefix "P10231"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is contained in or contains the work.</para>
    ///   <para>skos:scopeNote : Parts of works include discrete components such as subseries, and individual poems, stories, or essays in a collection or anthology.</para>
    ///   <para>skos:definition : Relates a work to a work that is contained in or contains the work.</para>
    ///   <para>rdfs:label : has whole-part work relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : whole-part work relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartWorkRelationship</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10232">rdaw:P10232</a>
    /// </summary>
    let P10232 = _prefixId.prefix "P10232"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : musical theatre adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalTheatreAdaptationOfWork</para>
    ///   <para>rdfs:label : is musical theatre adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a musical theatre work.</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a musical theatre work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10233">rdaw:P10233</a>
    /// </summary>
    let P10233 = _prefixId.prefix "P10233"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : operaAdaptationOf</para>
    ///   <para>rdfs:label : is opera adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : opera adaptation of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as opera.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as opera.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10234">rdaw:P10234</a>
    /// </summary>
    let P10234 = _prefixId.prefix "P10234"
    /// <summary>
    ///   <para>rdfs:label : is adapted as musical theatre (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as musical theatre (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical theatre work based on the source work.</para>
    ///   <para>skos:definition : Relates a work to a musical theatre work based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsMusicalTheatreWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10235">rdaw:P10235</a>
    /// </summary>
    let P10235 = _prefixId.prefix "P10235"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsOperaWork</para>
    ///   <para>rdfs:label : is adapted as opera (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An opera based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as opera (work)</para>
    ///   <para>skos:definition : Relates a work to an opera based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10236">rdaw:P10236</a>
    /// </summary>
    let P10236 = _prefixId.prefix "P10236"
    /// <summary>
    ///   <para>rdfs:label : is music (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : music (work)</para>
    ///   <para>skos:definition : Relates a work to a musical work that is used in a motion picture, play, television program, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work that is used in a motion picture, play, television program, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10237">rdaw:P10237</a>
    /// </summary>
    let P10237 = _prefixId.prefix "P10237"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work such as a motion picture, play, television program, etc. that uses the musical work.</para>
    ///   <para>rdfs:label : is music for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work such as a motion picture, play, television program, etc. that uses the musical work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : music for (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10238">rdaw:P10238</a>
    /// </summary>
    let P10238 = _prefixId.prefix "P10238"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoMusicWork</para>
    ///   <para>skos:definition : Relates a work to a musical work that is used in a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video music (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work that is used in a video.</para>
    ///   <para>rdfs:label : is video music (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10239">rdaw:P10239</a>
    /// </summary>
    let P10239 = _prefixId.prefix "P10239"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the musical work in a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : music for video (work)</para>
    ///   <para>rdfs:label : is music for video (work)</para>
    ///   <para>skos:definition : Relates a work to a work that uses the musical work in a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForVideoWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10240">rdaw:P10240</a>
    /// </summary>
    let P10240 = _prefixId.prefix "P10240"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProgramMusicWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work that is used in a television program.</para>
    ///   <para>skos:definition : Relates a work to a musical work that is used in a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : television program music (work)</para>
    ///   <para>rdfs:label : is television program music (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10241">rdaw:P10241</a>
    /// </summary>
    let P10241 = _prefixId.prefix "P10241"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForTelevisionProgramWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : music for television program (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the musical work in a television program.</para>
    ///   <para>rdfs:label : is music for television program (work)</para>
    ///   <para>skos:definition : Relates a work to a work that uses the musical work in a television program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10242">rdaw:P10242</a>
    /// </summary>
    let P10242 = _prefixId.prefix "P10242"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work that is used in a radio program.</para>
    ///   <para>skos:definition : Relates a work to a musical work that is used in a radio program.</para>
    ///   <para>rdfs:label : is radio program music (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProgramMusicWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : radio program music (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10243">rdaw:P10243</a>
    /// </summary>
    let P10243 = _prefixId.prefix "P10243"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForRadioProgramWork</para>
    ///   <para>rdfs:label : is music for radio program (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : music for radio program (work)</para>
    ///   <para>skos:definition : Relates a work to a work that uses the musical work in a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the musical work in a radio program.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10244">rdaw:P10244</a>
    /// </summary>
    let P10244 = _prefixId.prefix "P10244"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicForMotionPictureWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : music for motion picture (work)</para>
    ///   <para>rdfs:label : is music for motion picture (work)</para>
    ///   <para>skos:definition : Relates a work to a work that uses the musical work in a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the musical work in a motion picture.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10245">rdaw:P10245</a>
    /// </summary>
    let P10245 = _prefixId.prefix "P10245"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a musical work that is used in a motion picture.</para>
    ///   <para>rdfs:label : is motion picture music (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : motion picture music (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A musical work that is used in a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureMusicWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10246">rdaw:P10246</a>
    /// </summary>
    let P10246 = _prefixId.prefix "P10246"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that provides the choreography for use in the related work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyWork</para>
    ///   <para>skos:definition : Relates a work to a work that provides the choreography for use in the related work.</para>
    ///   <para>rdfs:label : is choreography (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : choreography (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10247">rdaw:P10247</a>
    /// </summary>
    let P10247 = _prefixId.prefix "P10247"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that uses the choreography of the related work.</para>
    ///   <para>skos:definition : Relates a work to a work that uses the choreography of the related work.</para>
    ///   <para>rdfs:label : is choreography for (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyForWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : choreography for (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10248">rdaw:P10248</a>
    /// </summary>
    let P10248 = _prefixId.prefix "P10248"
    /// <summary>
    ///   <para>rdfs:label : is adapted as video game (work)</para>
    ///   <para>skos:definition : Relates a work to a video game based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as video game (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A video game based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsVideoGameWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10249">rdaw:P10249</a>
    /// </summary>
    let P10249 = _prefixId.prefix "P10249"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a video game.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a video game.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoGameAdaptationOfWork</para>
    ///   <para>rdfs:label : is video game adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : video game adaptation of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10250">rdaw:P10250</a>
    /// </summary>
    let P10250 = _prefixId.prefix "P10250"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as graphic novel (work)</para>
    ///   <para>rdfs:label : is adapted as graphic novel (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A graphic novel based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsGraphicNovelWork</para>
    ///   <para>skos:definition : Relates a work to a graphic novel based on the source work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10251">rdaw:P10251</a>
    /// </summary>
    let P10251 = _prefixId.prefix "P10251"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as a graphic novel.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as a graphic novel.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : graphicNovelizationOfWork</para>
    ///   <para>rdfs:label : is graphic novelization of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : graphic novelization of (work)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10252">rdaw:P10252</a>
    /// </summary>
    let P10252 = _prefixId.prefix "P10252"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : calligrapher</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : calligrapher</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An artist responsible for creating a work of calligraphy where the focus of interest lies in the aesthetic value of its penmanship or graphic artistry, regardless of whether the same person, etc., also authored the inscribed text.</para>
    ///   <para>skos:definition : Relates a work to an artist responsible for creating a work of calligraphy where the focus of interest lies in the aesthetic value of its penmanship or graphic artistry, regardless of whether the same person, etc., also authored the inscribed text.</para>
    ///   <para>rdfs:label : has calligrapher</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10253">rdaw:P10253</a>
    /// </summary>
    let P10253 = _prefixId.prefix "P10253"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An artist responsible for creating art works that exploit the book form or alter its physical structure as part of the content of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : book artist</para>
    ///   <para>skos:definition : Relates a work to an artist responsible for creating art works that exploit the book form or alter its physical structure as part of the content of the work.</para>
    ///   <para>rdfs:label : has book artist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookArtist</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10254">rdaw:P10254</a>
    /// </summary>
    let P10254 = _prefixId.prefix "P10254"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an author who is appointed by an organization to report on the proceedings of its meetings.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rapporteur</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : rapporteur</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An author who is appointed by an organization to report on the proceedings of its meetings.</para>
    ///   <para>rdfs:label : has rapporteur</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10255">rdaw:P10255</a>
    /// </summary>
    let P10255 = _prefixId.prefix "P10255"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a term, phrase, classification number, etc., that indicates what the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectRelationship</para>
    ///   <para>rdfs:label : has subject relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The relationship between a work and an identifier, an authorized access point, and/or a description that indicates what the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 23.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject relationship</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10256">rdaw:P10256</a>
    /// </summary>
    let P10256 = _prefixId.prefix "P10256"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (work)</para>
    ///   <para>rdfs:label : has subject (work)</para>
    ///   <para>skos:definition : Relates a work to a work that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that the work is about.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10257">rdaw:P10257</a>
    /// </summary>
    let P10257 = _prefixId.prefix "P10257"
    /// <summary>
    ///   <para>rdfs:label : has subject (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectExpression</para>
    ///   <para>skos:definition : Relates a work to an expression that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10258">rdaw:P10258</a>
    /// </summary>
    let P10258 = _prefixId.prefix "P10258"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a manifestation that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectManifestation</para>
    ///   <para>rdfs:label : has subject (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work to a manifestation that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10259">rdaw:P10259</a>
    /// </summary>
    let P10259 = _prefixId.prefix "P10259"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that the work is about.</para>
    ///   <para>rdfs:label : has subject (item)</para>
    ///   <para>skos:definition : Relates a work to an item that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectItem</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10260">rdaw:P10260</a>
    /// </summary>
    let P10260 = _prefixId.prefix "P10260"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectPerson</para>
    ///   <para>rdfs:label : has subject (person)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (person)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person that the work is about.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10261">rdaw:P10261</a>
    /// </summary>
    let P10261 = _prefixId.prefix "P10261"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a family that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (family)</para>
    ///   <para>rdfs:label : has subject (family)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectFamily</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10262">rdaw:P10262</a>
    /// </summary>
    let P10262 = _prefixId.prefix "P10262"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a corporate body that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that the work is about.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject (corporate body)</para>
    ///   <para>rdfs:label : has subject (corporate body)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10263">rdaw:P10263</a>
    /// </summary>
    let P10263 = _prefixId.prefix "P10263"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOfWork</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject of (work)</para>
    ///   <para>rdfs:label : is subject of (work)</para>
    ///   <para>skos:definition : Relates a work to a work that is about the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work to a work that is about the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10264">rdaw:P10264</a>
    /// </summary>
    let P10264 = _prefixId.prefix "P10264"
    /// <summary>
    ///   <para>rdfs:label : is description of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item described by a describing work.</para>
    ///   <para>skos:definition : Relates a work to an item described by a describing work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : description of (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10265">rdaw:P10265</a>
    /// </summary>
    let P10265 = _prefixId.prefix "P10265"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an item that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysis of (item)</para>
    ///   <para>rdfs:label : is analysis of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that has been examined to identify its components and their relations.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10266">rdaw:P10266</a>
    /// </summary>
    let P10266 = _prefixId.prefix "P10266"
    /// <summary>
    ///   <para>rdfs:label : is evaluation of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is examined or judged.</para>
    ///   <para>skos:definition : Relates a work to an item that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluation of (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10267">rdaw:P10267</a>
    /// </summary>
    let P10267 = _prefixId.prefix "P10267"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item used as the basis for a brief evaluation.</para>
    ///   <para>rdfs:label : is review of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : review of (item)</para>
    ///   <para>skos:definition : Relates a work to an item used as the basis for a brief evaluation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10268">rdaw:P10268</a>
    /// </summary>
    let P10268 = _prefixId.prefix "P10268"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an item used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critique of (item)</para>
    ///   <para>rdfs:label : is critique of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfItem</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10269">rdaw:P10269</a>
    /// </summary>
    let P10269 = _prefixId.prefix "P10269"
    /// <summary>
    ///   <para>rdfs:label : is commentary on (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary on (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>skos:definition : Relates a work to an item used as the basis for a set of explanatory or critical notes.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10270">rdaw:P10270</a>
    /// </summary>
    let P10270 = _prefixId.prefix "P10270"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : description of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation described by a describing work.</para>
    ///   <para>skos:definition : Relates a work to a manifestation described by a describing work.</para>
    ///   <para>rdfs:label : is description of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10271">rdaw:P10271</a>
    /// </summary>
    let P10271 = _prefixId.prefix "P10271"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysis of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfManifestation</para>
    ///   <para>skos:definition : Relates a work to a manifestation that has been examined to identify its components and their relations.</para>
    ///   <para>rdfs:label : is analysis of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that has been examined to identify its components and their relations.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10272">rdaw:P10272</a>
    /// </summary>
    let P10272 = _prefixId.prefix "P10272"
    /// <summary>
    ///   <para>rdfs:label : is evaluation of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfManifestation</para>
    ///   <para>skos:definition : Relates a work to a manifestation that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluation of (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10273">rdaw:P10273</a>
    /// </summary>
    let P10273 = _prefixId.prefix "P10273"
    /// <summary>
    ///   <para>rdfs:label : is review of (manifestation)</para>
    ///   <para>skos:definition : Relates a work to a manifestation used as the basis for a brief evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation used as the basis for a brief evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : review of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10274">rdaw:P10274</a>
    /// </summary>
    let P10274 = _prefixId.prefix "P10274"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation used as the basis for a critical evaluation.</para>
    ///   <para>rdfs:label : is critique of (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfManifestation</para>
    ///   <para>skos:definition : Relates a work to a manifestation used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critique of (manifestation)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10275">rdaw:P10275</a>
    /// </summary>
    let P10275 = _prefixId.prefix "P10275"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A manifestation used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>skos:definition : Relates a work to a manifestation used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>rdfs:label : is commentary on (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary on (manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnManifestation</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10276">rdaw:P10276</a>
    /// </summary>
    let P10276 = _prefixId.prefix "P10276"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : description of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfExpression</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression described by a describing work.</para>
    ///   <para>skos:definition : Relates a work to an expression described by a describing work.</para>
    ///   <para>rdfs:label : is description of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10277">rdaw:P10277</a>
    /// </summary>
    let P10277 = _prefixId.prefix "P10277"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an expression that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfExpression</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysis of (expression)</para>
    ///   <para>rdfs:label : is analysis of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression that has been examined to identify its components and their relations.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10278">rdaw:P10278</a>
    /// </summary>
    let P10278 = _prefixId.prefix "P10278"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an expression that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression that is examined or judged.</para>
    ///   <para>rdfs:label : is evaluation of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfExpression</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluation of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10279">rdaw:P10279</a>
    /// </summary>
    let P10279 = _prefixId.prefix "P10279"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an expression used as the basis for a brief evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression used as the basis for a brief evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfExpression</para>
    ///   <para>rdfs:label : is review of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : review of (expression)</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10280">rdaw:P10280</a>
    /// </summary>
    let P10280 = _prefixId.prefix "P10280"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an expression used as the basis for a critical evaluation.</para>
    ///   <para>rdfs:label : is critique of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfExpression</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critique of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression used as the basis for a critical evaluation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10281">rdaw:P10281</a>
    /// </summary>
    let P10281 = _prefixId.prefix "P10281"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An expression used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary on (expression)</para>
    ///   <para>rdfs:label : is commentary on (expression)</para>
    ///   <para>skos:definition : Relates a work to an expression used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnexpression</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10282">rdaw:P10282</a>
    /// </summary>
    let P10282 = _prefixId.prefix "P10282"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOf</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject relationship of</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is about the entity.</para>
    ///   <para>skos:definition : Relates an entity to a work that is about the entity.</para>
    ///   <para>rdfs:label : is subject relationship of</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10283">rdaw:P10283</a>
    /// </summary>
    let P10283 = _prefixId.prefix "P10283"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : degree committee member</para>
    ///   <para>rdfs:label : has degree committee member</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeCommitteeMember</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person serving on a committee that supervises a student's thesis or dissertation.</para>
    ///   <para>skos:definition : Relates a work to a person serving on a committee that supervises a student's thesis or dissertation.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10284">rdaw:P10284</a>
    /// </summary>
    let P10284 = _prefixId.prefix "P10284"
    /// <summary>
    ///   <para>rdfs:label : has defendant corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : defendant corporate body</para>
    ///   <para>skos:definition : Relates a work to a corporate body who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantCorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10285">rdaw:P10285</a>
    /// </summary>
    let P10285 = _prefixId.prefix "P10285"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantPerson</para>
    ///   <para>skos:definition : Relates a work to a person who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : defendant person</para>
    ///   <para>rdfs:label : has defendant person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10286">rdaw:P10286</a>
    /// </summary>
    let P10286 = _prefixId.prefix "P10286"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body responsible for commissioning a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commissioningBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commissioning body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for commissioning a work.</para>
    ///   <para>rdfs:label : has commissioning body</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10287">rdaw:P10287</a>
    /// </summary>
    let P10287 = _prefixId.prefix "P10287"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work that has been adapted as an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : oratorio adaptation of (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : oratorioAdaptationOfWork</para>
    ///   <para>rdfs:label : is oratorio adaptation of (work)rdfs:label : is oratorio adaptation of  (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that has been adapted as an oratorio.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10288">rdaw:P10288</a>
    /// </summary>
    let P10288 = _prefixId.prefix "P10288"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : adapted as oratorio (work)</para>
    ///   <para>skos:definition : Relates a work to an oratorio based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An oratorio based on the source work.</para>
    ///   <para>rdfs:label : is adapted as oratorio (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsOratorioWork</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10289">rdaw:P10289</a>
    /// </summary>
    let P10289 = _prefixId.prefix "P10289"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a work which serves as the inspiration for another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inspiredBy</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work which serves as the inspiration for another work.</para>
    ///   <para>rdfs:label : is inspired by</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : inspired by</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10290">rdaw:P10290</a>
    /// </summary>
    let P10290 = _prefixId.prefix "P10290"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work which was inspired by another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : inspiration for</para>
    ///   <para>skos:definition : Relates a work to a work which was inspired by another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inspirationFor</para>
    ///   <para>rdfs:label : is inspiration for</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10291">rdaw:P10291</a>
    /// </summary>
    let P10291 = _prefixId.prefix "P10291"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : participant in a treaty</para>
    ///   <para>rdfs:label : has participant in a treaty</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : participantInATreaty</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A government, international intergovernmental body, or other corporate body that has signed, ratified, or acceded to a treaty.</para>
    ///   <para>skos:definition : Relates a work to a government, international intergovernmental body, or other corporate body that has signed, ratified, or acceded to a treaty.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10292">rdaw:P10292</a>
    /// </summary>
    let P10292 = _prefixId.prefix "P10292"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : researcher</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body who does research in support of the creation of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : researcher</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body who does research in support of the creation of a work.</para>
    ///   <para>rdfs:label : has researcher</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10293">rdaw:P10293</a>
    /// </summary>
    let P10293 = _prefixId.prefix "P10293"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commemoration</para>
    ///   <para>rdfs:label : has commemoration</para>
    ///   <para>skos:definition : Relates a work to a work commemorated by the other work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commemoration</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work commemorated by the other work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10294">rdaw:P10294</a>
    /// </summary>
    let P10294 = _prefixId.prefix "P10294"
    /// <summary>
    ///   <para>rdfs:label : is commemoration of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commemorationOf</para>
    ///   <para>skos:definition : Relates a work to a work created to commemorate the other work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work created to commemorate the other work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commemoration of</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10295">rdaw:P10295</a>
    /// </summary>
    let P10295 = _prefixId.prefix "P10295"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that references the work.</para>
    ///   <para>rdfs:label : has referential work relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : referentialWorkRelationship</para>
    ///   <para>skos:definition : Relates a work to a work that references the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : referential work relationship</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10296">rdaw:P10296</a>
    /// </summary>
    let P10296 = _prefixId.prefix "P10296"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : organizer</para>
    ///   <para>rdfs:label : has organizer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : organizer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body organizing the exhibit, event, conference, etc., which gave rise to a work.</para>
    ///   <para>skos:definition : Relates a work to a person, family, or corporate body organizing the exhibit, event, conference, etc., which gave rise to a work.</para>
    ///   <a href="http://rdaregistry.info/Elements/w/P10297">rdaw:P10297</a>
    /// </summary>
    let P10297 = _prefixId.prefix "P10297"
    let SubjectRelationshipOf'_period_'en = _prefixId.prefix "SubjectRelationshipOf.en"
    let abridgedAsWork = _prefixId.prefix "abridgedAsWork"
    let abridgedAsWork'_period_'en = _prefixId.prefix "abridgedAsWork.en"
    let abridgementOfWork = _prefixId.prefix "abridgementOfWork"
    let abridgementOfWork'_period_'en = _prefixId.prefix "abridgementOfWork.en"
    let absorbedByWork = _prefixId.prefix "absorbedByWork"
    let absorbedByWork'_period_'en = _prefixId.prefix "absorbedByWork.en"
    let absorbedInPartByWork = _prefixId.prefix "absorbedInPartByWork"
    let absorbedInPartByWork'_period_'en = _prefixId.prefix "absorbedInPartByWork.en"
    let absorbedInPartWork = _prefixId.prefix "absorbedInPartWork"
    let absorbedWork = _prefixId.prefix "absorbedWork"

    let absorptionInPartOfWork'_period_'en = _prefixId.prefix "absorptionInPartOfWork.en"

    let absorptionOfWork'_period_'en = _prefixId.prefix "absorptionOfWork.en"
    let abstractOfWork = _prefixId.prefix "abstractOfWork"
    let abstractOfWork'_period_'en = _prefixId.prefix "abstractOfWork.en"
    let abstractWork = _prefixId.prefix "abstractWork"
    let abstractedAsWork'_period_'en = _prefixId.prefix "abstractedAsWork.en"
    let abstractedInWork = _prefixId.prefix "abstractedInWork"
    let abstractedInWork'_period_'en = _prefixId.prefix "abstractedInWork.en"
    let abstractsForWork = _prefixId.prefix "abstractsForWork"
    let abstractsForWork'_period_'en = _prefixId.prefix "abstractsForWork.en"
    let academicDegree = _prefixId.prefix "academicDegree"
    let academicDegree'_period_'en = _prefixId.prefix "academicDegree.en"
    let accompanyingWorkRelationship = _prefixId.prefix "accompanyingWorkRelationship"

    let accompanyingWorkRelationship'_period_'en = _prefixId.prefix "accompanyingWorkRelationship.en"

    let adaptationOfWork = _prefixId.prefix "adaptationOfWork"
    let adaptationOfWork'_period_'en = _prefixId.prefix "adaptationOfWork.en"

    let adaptedAsAMotionPictureScreenplayWork = _prefixId.prefix "adaptedAsAMotionPictureScreenplayWork"

    let adaptedAsAMotionPictureWork = _prefixId.prefix "adaptedAsAMotionPictureWork"
    let adaptedAsARadioProgramWork = _prefixId.prefix "adaptedAsARadioProgramWork"
    let adaptedAsARadioScriptWork = _prefixId.prefix "adaptedAsARadioScriptWork"
    let adaptedAsAScreenplayWork = _prefixId.prefix "adaptedAsAScreenplayWork"

    let adaptedAsATelevisionProgramWork = _prefixId.prefix "adaptedAsATelevisionProgramWork"

    let adaptedAsATelevisionScreenplayWork = _prefixId.prefix "adaptedAsATelevisionScreenplayWork"

    let adaptedAsAVideoScreenplayWork = _prefixId.prefix "adaptedAsAVideoScreenplayWork"
    let adaptedAsAVideoWork = _prefixId.prefix "adaptedAsAVideoWork"

    let adaptedAsChoreographyWork'_period_'en = _prefixId.prefix "adaptedAsChoreographyWork.en"

    let adaptedAsGraphicNovelWork'_period_'en = _prefixId.prefix "adaptedAsGraphicNovelWork.en"

    let adaptedAsLibrettoWork'_period_'en = _prefixId.prefix "adaptedAsLibrettoWork.en"

    let adaptedAsMotionPictureScreenplayWork'_period_'en = _prefixId.prefix "adaptedAsMotionPictureScreenplayWork.en"

    let adaptedAsMotionPictureWork'_period_'en = _prefixId.prefix "adaptedAsMotionPictureWork.en"

    let adaptedAsMusicalTheatreWork = _prefixId.prefix "adaptedAsMusicalTheatreWork"

    let adaptedAsMusicalTheatreWork'_period_'en = _prefixId.prefix "adaptedAsMusicalTheatreWork.en"

    let adaptedAsNovelWork'_period_'en = _prefixId.prefix "adaptedAsNovelWork.en"
    let adaptedAsOperaWork = _prefixId.prefix "adaptedAsOperaWork"
    let adaptedAsOperaWork'_period_'en = _prefixId.prefix "adaptedAsOperaWork.en"
    let adaptedAsOratorioWork'_period_'en = _prefixId.prefix "adaptedAsOratorioWork.en"

    let adaptedAsRadioProgramWork'_period_'en = _prefixId.prefix "adaptedAsRadioProgramWork.en"

    let adaptedAsRadioScriptWork'_period_'en = _prefixId.prefix "adaptedAsRadioScriptWork.en"

    let adaptedAsScreenplayWork'_period_'en = _prefixId.prefix "adaptedAsScreenplayWork.en"

    let adaptedAsTelevisionProgramWork'_period_'en = _prefixId.prefix "adaptedAsTelevisionProgramWork.en"

    let adaptedAsTelevisionScreenplayWork'_period_'en = _prefixId.prefix "adaptedAsTelevisionScreenplayWork.en"

    let adaptedAsVideoGameWork'_period_'en = _prefixId.prefix "adaptedAsVideoGameWork.en"

    let adaptedAsVideoScreenplayWork'_period_'en = _prefixId.prefix "adaptedAsVideoScreenplayWork.en"

    let adaptedAsVideoWork'_period_'en = _prefixId.prefix "adaptedAsVideoWork.en"
    let adaptedAsWork = _prefixId.prefix "adaptedAsWork"
    let adaptedAsWork'_period_'en = _prefixId.prefix "adaptedAsWork.en"
    let adaptedInVerseAsWork'_period_'en = _prefixId.prefix "adaptedInVerseAsWork.en"
    let addendaToWork = _prefixId.prefix "addendaToWork"
    let addendaToWork'_period_'en = _prefixId.prefix "addendaToWork.en"
    let addendaWork = _prefixId.prefix "addendaWork"
    let addendaWork'_period_'en = _prefixId.prefix "addendaWork.en"
    let addressee = _prefixId.prefix "addressee"
    let addressee'_period_'en = _prefixId.prefix "addressee.en"
    let analysedInWork'_period_'en = _prefixId.prefix "analysedInWork.en"
    let analysisOfExpression'_period_'en = _prefixId.prefix "analysisOfExpression.en"
    let analysisOfItem'_period_'en = _prefixId.prefix "analysisOfItem.en"

    let analysisOfManifestation'_period_'en = _prefixId.prefix "analysisOfManifestation.en"

    let analysisOfWork = _prefixId.prefix "analysisOfWork"
    let analysisOfWork'_period_'en = _prefixId.prefix "analysisOfWork.en"
    let appellant = _prefixId.prefix "appellant"
    let appellant'_period_'en = _prefixId.prefix "appellant.en"
    let appellantCorporateBody = _prefixId.prefix "appellantCorporateBody"

    let appellantCorporateBody'_period_'en = _prefixId.prefix "appellantCorporateBody.en"

    let appellantPerson = _prefixId.prefix "appellantPerson"
    let appellantPerson'_period_'en = _prefixId.prefix "appellantPerson.en"
    let appellee = _prefixId.prefix "appellee"
    let appellee'_period_'en = _prefixId.prefix "appellee.en"
    let appelleeCorporateBody = _prefixId.prefix "appelleeCorporateBody"
    let appelleeCorporateBody'_period_'en = _prefixId.prefix "appelleeCorporateBody.en"
    let appelleePerson = _prefixId.prefix "appelleePerson"
    let appelleePerson'_period_'en = _prefixId.prefix "appelleePerson.en"
    let appendixToWork = _prefixId.prefix "appendixToWork"
    let appendixToWork'_period_'en = _prefixId.prefix "appendixToWork.en"
    let appendixWork = _prefixId.prefix "appendixWork"
    let appendixWork'_period_'en = _prefixId.prefix "appendixWork.en"
    let architect = _prefixId.prefix "architect"
    let architect'_period_'en = _prefixId.prefix "architect.en"
    let artist = _prefixId.prefix "artist"
    let artist'_period_'en = _prefixId.prefix "artist.en"
    let augmentationOfWork = _prefixId.prefix "augmentationOfWork"
    let augmentationOfWork'_period_'en = _prefixId.prefix "augmentationOfWork.en"
    let augmentedByWork = _prefixId.prefix "augmentedByWork"
    let augmentedByWork'_period_'en = _prefixId.prefix "augmentedByWork.en"
    let author = _prefixId.prefix "author"
    let author'_period_'en = _prefixId.prefix "author.en"
    let basedOnWork = _prefixId.prefix "basedOnWork"
    let basedOnWork'_period_'en = _prefixId.prefix "basedOnWork.en"
    let basisForLibrettoWork = _prefixId.prefix "basisForLibrettoWork"
    let bookArtist'_period_'en = _prefixId.prefix "bookArtist.en"
    let cadenzaComposedForWork = _prefixId.prefix "cadenzaComposedForWork"

    let cadenzaComposedForWork'_period_'en = _prefixId.prefix "cadenzaComposedForWork.en"

    let cadenzaWork = _prefixId.prefix "cadenzaWork"
    let cadenzaWork'_period_'en = _prefixId.prefix "cadenzaWork.en"
    let calligrapher'_period_'en = _prefixId.prefix "calligrapher.en"
    let cartographer = _prefixId.prefix "cartographer"
    let cartographer'_period_'en = _prefixId.prefix "cartographer.en"
    let catalogueOfWork = _prefixId.prefix "catalogueOfWork"
    let catalogueOfWork'_period_'en = _prefixId.prefix "catalogueOfWork.en"
    let catalogueWork = _prefixId.prefix "catalogueWork"
    let catalogueWork'_period_'en = _prefixId.prefix "catalogueWork.en"
    let choreographer = _prefixId.prefix "choreographer"
    let choreographer'_period_'en = _prefixId.prefix "choreographer.en"

    let choreographicAdaptationOfWork'_period_'en = _prefixId.prefix "choreographicAdaptationOfWork.en"

    let choreographyForWork = _prefixId.prefix "choreographyForWork"
    let choreographyForWork'_period_'en = _prefixId.prefix "choreographyForWork.en"
    let choreographyWork = _prefixId.prefix "choreographyWork"
    let choreographyWork'_period_'en = _prefixId.prefix "choreographyWork.en"
    let commemoration'_period_'en = _prefixId.prefix "commemoration.en"
    let commemorationOf'_period_'en = _prefixId.prefix "commemorationOf.en"
    let commentaryInWork = _prefixId.prefix "commentaryInWork"
    let commentaryInWork'_period_'en = _prefixId.prefix "commentaryInWork.en"

    let commentaryOnExpression'_period_'en = _prefixId.prefix "commentaryOnExpression.en"

    let commentaryOnItem'_period_'en = _prefixId.prefix "commentaryOnItem.en"

    let commentaryOnManifestation'_period_'en = _prefixId.prefix "commentaryOnManifestation.en"

    let commentaryOnWork = _prefixId.prefix "commentaryOnWork"
    let commentaryOnWork'_period_'en = _prefixId.prefix "commentaryOnWork.en"
    let commissioningBody'_period_'en = _prefixId.prefix "commissioningBody.en"
    let compiler = _prefixId.prefix "compiler"
    let compiler'_period_'en = _prefixId.prefix "compiler.en"
    let complementedByWork = _prefixId.prefix "complementedByWork"
    let complementedByWork'_period_'en = _prefixId.prefix "complementedByWork.en"
    let composer = _prefixId.prefix "composer"
    let composer'_period_'en = _prefixId.prefix "composer.en"
    let concordanceToWork = _prefixId.prefix "concordanceToWork"
    let concordanceToWork'_period_'en = _prefixId.prefix "concordanceToWork.en"
    let concordanceWork = _prefixId.prefix "concordanceWork"
    let concordanceWork'_period_'en = _prefixId.prefix "concordanceWork.en"
    let consultant = _prefixId.prefix "consultant"
    let consultant'_period_'en = _prefixId.prefix "consultant.en"
    let containedInWork = _prefixId.prefix "containedInWork"
    let containedInWork'_period_'en = _prefixId.prefix "containedInWork.en"
    let containerOfWork = _prefixId.prefix "containerOfWork"
    let containerOfWork'_period_'en = _prefixId.prefix "containerOfWork.en"
    let continuationInPartOfWork = _prefixId.prefix "continuationInPartOfWork"

    let continuationInPartOfWork'_period_'en = _prefixId.prefix "continuationInPartOfWork.en"

    let continuationOfWork'_period_'en = _prefixId.prefix "continuationOfWork.en"
    let continuedByWork = _prefixId.prefix "continuedByWork"
    let continuedByWork'_period_'en = _prefixId.prefix "continuedByWork.en"
    let continuedInPartByWork = _prefixId.prefix "continuedInPartByWork"
    let continuedInPartByWork'_period_'en = _prefixId.prefix "continuedInPartByWork.en"
    let continuesWork = _prefixId.prefix "continuesWork"

    let coordinatesOfCartographicContent = _prefixId.prefix "coordinatesOfCartographicContent"

    let coordinatesOfCartographicContent'_period_'en = _prefixId.prefix "coordinatesOfCartographicContent.en"

    let courtGoverned = _prefixId.prefix "courtGoverned"
    let courtGoverned'_period_'en = _prefixId.prefix "courtGoverned.en"
    let coverageOfTheContent = _prefixId.prefix "coverageOfTheContent"
    let coverageOfTheContent'_period_'en = _prefixId.prefix "coverageOfTheContent.en"
    let creator = _prefixId.prefix "creator"
    let creator'_period_'en = _prefixId.prefix "creator.en"
    let critiqueOfExpression'_period_'en = _prefixId.prefix "critiqueOfExpression.en"
    let critiqueOfItem'_period_'en = _prefixId.prefix "critiqueOfItem.en"

    let critiqueOfManifestation'_period_'en = _prefixId.prefix "critiqueOfManifestation.en"

    let critiqueOfWork = _prefixId.prefix "critiqueOfWork"
    let critiqueOfWork'_period_'en = _prefixId.prefix "critiqueOfWork.en"
    let critiquedInWork = _prefixId.prefix "critiquedInWork"
    let critiquedInWork'_period_'en = _prefixId.prefix "critiquedInWork.en"
    let dateOfWork = _prefixId.prefix "dateOfWork"
    let dateOfWork'_period_'en = _prefixId.prefix "dateOfWork.en"
    let dedicatee = _prefixId.prefix "dedicatee"
    let dedicatee'_period_'en = _prefixId.prefix "dedicatee.en"
    let dedicator = _prefixId.prefix "dedicator"
    let dedicator'_period_'en = _prefixId.prefix "dedicator.en"
    let defendant = _prefixId.prefix "defendant"
    let defendant'_period_'en = _prefixId.prefix "defendant.en"

    let defendantCorporateBody'_period_'en = _prefixId.prefix "defendantCorporateBody.en"

    let defendantPerson'_period_'en = _prefixId.prefix "defendantPerson.en"
    let degreeCommitteeMember'_period_'en = _prefixId.prefix "degreeCommitteeMember.en"
    let degreeGrantingInstitution = _prefixId.prefix "degreeGrantingInstitution"

    let degreeGrantingInstitution'_period_'en = _prefixId.prefix "degreeGrantingInstitution.en"

    let degreeSupervisor = _prefixId.prefix "degreeSupervisor"
    let degreeSupervisor'_period_'en = _prefixId.prefix "degreeSupervisor.en"
    let derivativeWork = _prefixId.prefix "derivativeWork"
    let derivativeWork'_period_'en = _prefixId.prefix "derivativeWork.en"
    let derivativeWorkRelationship = _prefixId.prefix "derivativeWorkRelationship"

    let derivativeWorkRelationship'_period_'en = _prefixId.prefix "derivativeWorkRelationship.en"

    let describedInWork = _prefixId.prefix "describedInWork"
    let describedInWork'_period_'en = _prefixId.prefix "describedInWork.en"

    let descriptionOfExpression'_period_'en = _prefixId.prefix "descriptionOfExpression.en"

    let descriptionOfItem'_period_'en = _prefixId.prefix "descriptionOfItem.en"

    let descriptionOfManifestation'_period_'en = _prefixId.prefix "descriptionOfManifestation.en"

    let descriptionOfWork = _prefixId.prefix "descriptionOfWork"
    let descriptionOfWork'_period_'en = _prefixId.prefix "descriptionOfWork.en"
    let designer = _prefixId.prefix "designer"
    let designer'_period_'en = _prefixId.prefix "designer.en"
    let digestOfWork = _prefixId.prefix "digestOfWork"
    let digestOfWork'_period_'en = _prefixId.prefix "digestOfWork.en"
    let digestWork = _prefixId.prefix "digestWork"
    let digestedAsWork'_period_'en = _prefixId.prefix "digestedAsWork.en"
    let director = _prefixId.prefix "director"
    let director'_period_'en = _prefixId.prefix "director.en"
    let directorOfPhotography = _prefixId.prefix "directorOfPhotography"
    let directorOfPhotography'_period_'en = _prefixId.prefix "directorOfPhotography.en"

    let dissertationOrThesisInformation = _prefixId.prefix "dissertationOrThesisInformation"

    let dissertationOrThesisInformation'_period_'en = _prefixId.prefix "dissertationOrThesisInformation.en"

    let dramatizationOfWork = _prefixId.prefix "dramatizationOfWork"
    let dramatizationOfWork'_period_'en = _prefixId.prefix "dramatizationOfWork.en"
    let dramatizedAsWork = _prefixId.prefix "dramatizedAsWork"
    let dramatizedAsWork'_period_'en = _prefixId.prefix "dramatizedAsWork.en"
    let enactingJurisdiction = _prefixId.prefix "enactingJurisdiction"
    let enactingJurisdiction'_period_'en = _prefixId.prefix "enactingJurisdiction.en"
    let epoch = _prefixId.prefix "epoch"
    let epoch'_period_'en = _prefixId.prefix "epoch.en"
    let equinox = _prefixId.prefix "equinox"
    let equinox'_period_'en = _prefixId.prefix "equinox.en"
    let errataToWork = _prefixId.prefix "errataToWork"
    let errataToWork'_period_'en = _prefixId.prefix "errataToWork.en"
    let errataWork = _prefixId.prefix "errataWork"
    let errataWork'_period_'en = _prefixId.prefix "errataWork.en"
    let evaluatedInWork = _prefixId.prefix "evaluatedInWork"
    let evaluatedInWork'_period_'en = _prefixId.prefix "evaluatedInWork.en"

    let evaluationOfExpression'_period_'en = _prefixId.prefix "evaluationOfExpression.en"

    let evaluationOfItem'_period_'en = _prefixId.prefix "evaluationOfItem.en"

    let evaluationOfManifestation'_period_'en = _prefixId.prefix "evaluationOfManifestation.en"

    let evaluationOfWork = _prefixId.prefix "evaluationOfWork"
    let evaluationOfWork'_period_'en = _prefixId.prefix "evaluationOfWork.en"
    let expandedAsWork = _prefixId.prefix "expandedAsWork"
    let expandedAsWork'_period_'en = _prefixId.prefix "expandedAsWork.en"
    let expandedVersionOfWork = _prefixId.prefix "expandedVersionOfWork"
    let expandedVersionOfWork'_period_'en = _prefixId.prefix "expandedVersionOfWork.en"
    let expressionOfWork = _prefixId.prefix "expressionOfWork"
    let expressionOfWork'_period_'en = _prefixId.prefix "expressionOfWork.en"
    let filmDirector = _prefixId.prefix "filmDirector"
    let filmDirector'_period_'en = _prefixId.prefix "filmDirector.en"
    let filmProducer = _prefixId.prefix "filmProducer"
    let filmProducer'_period_'en = _prefixId.prefix "filmProducer.en"
    let filmmaker = _prefixId.prefix "filmmaker"
    let filmmaker'_period_'en = _prefixId.prefix "filmmaker.en"
    let findingAidForWork = _prefixId.prefix "findingAidForWork"
    let findingAidForWork'_period_'en = _prefixId.prefix "findingAidForWork.en"
    let findingAidWork = _prefixId.prefix "findingAidWork"
    let findingAidWork'_period_'en = _prefixId.prefix "findingAidWork.en"
    let formOfWork = _prefixId.prefix "formOfWork"
    let formOfWork'_period_'en = _prefixId.prefix "formOfWork.en"
    let freeTranslationOfWork = _prefixId.prefix "freeTranslationOfWork"
    let freeTranslationOfWork'_period_'en = _prefixId.prefix "freeTranslationOfWork.en"
    let freelyTranslatedAsWork = _prefixId.prefix "freelyTranslatedAsWork"

    let freelyTranslatedAsWork'_period_'en = _prefixId.prefix "freelyTranslatedAsWork.en"

    let grantingInstitutionOrFaculty = _prefixId.prefix "grantingInstitutionOrFaculty"

    let grantingInstitutionOrFaculty'_period_'en = _prefixId.prefix "grantingInstitutionOrFaculty.en"

    let graphicNovelizationOfWork'_period_'en = _prefixId.prefix "graphicNovelizationOfWork.en"

    let guideToWork = _prefixId.prefix "guideToWork"
    let guideToWork'_period_'en = _prefixId.prefix "guideToWork.en"
    let guideWork = _prefixId.prefix "guideWork"
    let guideWork'_period_'en = _prefixId.prefix "guideWork.en"
    let historyOfTheWork = _prefixId.prefix "historyOfTheWork"
    let historyOfTheWork'_period_'en = _prefixId.prefix "historyOfTheWork.en"
    let honouree = _prefixId.prefix "honouree"
    let honouree'_period_'en = _prefixId.prefix "honouree.en"
    let hostInstitution = _prefixId.prefix "hostInstitution"
    let hostInstitution'_period_'en = _prefixId.prefix "hostInstitution.en"
    let identifierForTheWork = _prefixId.prefix "identifierForTheWork"
    let identifierForTheWork'_period_'en = _prefixId.prefix "identifierForTheWork.en"
    let illustrationsForWork = _prefixId.prefix "illustrationsForWork"
    let illustrationsForWork'_period_'en = _prefixId.prefix "illustrationsForWork.en"
    let illustrationsWork = _prefixId.prefix "illustrationsWork"
    let illustrationsWork'_period_'en = _prefixId.prefix "illustrationsWork.en"
    let imitatedAsWork = _prefixId.prefix "imitatedAsWork"
    let imitatedAsWork'_period_'en = _prefixId.prefix "imitatedAsWork.en"
    let imitationOfWork = _prefixId.prefix "imitationOfWork"
    let imitationOfWork'_period_'en = _prefixId.prefix "imitationOfWork.en"
    let inSeries = _prefixId.prefix "inSeries"
    let inSeries'_period_'en = _prefixId.prefix "inSeries.en"
    let incidentalMusicForWork = _prefixId.prefix "incidentalMusicForWork"

    let incidentalMusicForWork'_period_'en = _prefixId.prefix "incidentalMusicForWork.en"

    let incidentalMusicWork = _prefixId.prefix "incidentalMusicWork"
    let incidentalMusicWork'_period_'en = _prefixId.prefix "incidentalMusicWork.en"
    let indexToWork = _prefixId.prefix "indexToWork"
    let indexToWork'_period_'en = _prefixId.prefix "indexToWork.en"
    let indexWork = _prefixId.prefix "indexWork"
    let indexWork'_period_'en = _prefixId.prefix "indexWork.en"
    let indexedInWork = _prefixId.prefix "indexedInWork"
    let indexedInWork'_period_'en = _prefixId.prefix "indexedInWork.en"
    let indexingForWork = _prefixId.prefix "indexingForWork"
    let indexingForWork'_period_'en = _prefixId.prefix "indexingForWork.en"
    let inspirationFor'_period_'en = _prefixId.prefix "inspirationFor.en"
    let inspiredBy'_period_'en = _prefixId.prefix "inspiredBy.en"
    let intendedAudience = _prefixId.prefix "intendedAudience"
    let intendedAudience'_period_'en = _prefixId.prefix "intendedAudience.en"
    let interviewee = _prefixId.prefix "interviewee"
    let interviewee'_period_'en = _prefixId.prefix "interviewee.en"
    let interviewer = _prefixId.prefix "interviewer"
    let interviewer'_period_'en = _prefixId.prefix "interviewer.en"
    let inventor = _prefixId.prefix "inventor"
    let inventor'_period_'en = _prefixId.prefix "inventor.en"
    let issuingBody = _prefixId.prefix "issuingBody"
    let issuingBody'_period_'en = _prefixId.prefix "issuingBody.en"
    let judge = _prefixId.prefix "judge"
    let judge'_period_'en = _prefixId.prefix "judge.en"
    let jurisdictionGoverned = _prefixId.prefix "jurisdictionGoverned"
    let jurisdictionGoverned'_period_'en = _prefixId.prefix "jurisdictionGoverned.en"
    let key = _prefixId.prefix "key"
    let key'_period_'en = _prefixId.prefix "key.en"
    let landscapeArchitect = _prefixId.prefix "landscapeArchitect"
    let landscapeArchitect'_period_'en = _prefixId.prefix "landscapeArchitect.en"
    let librettist = _prefixId.prefix "librettist"
    let librettist'_period_'en = _prefixId.prefix "librettist.en"
    let librettoBasedOnWork = _prefixId.prefix "librettoBasedOnWork"
    let librettoBasedOnWork'_period_'en = _prefixId.prefix "librettoBasedOnWork.en"
    let librettoForWork = _prefixId.prefix "librettoForWork"
    let librettoForWork'_period_'en = _prefixId.prefix "librettoForWork.en"
    let librettoWork = _prefixId.prefix "librettoWork"
    let librettoWork'_period_'en = _prefixId.prefix "librettoWork.en"
    let longitudeAndLatitude = _prefixId.prefix "longitudeAndLatitude"
    let longitudeAndLatitude'_period_'en = _prefixId.prefix "longitudeAndLatitude.en"
    let lyricist = _prefixId.prefix "lyricist"
    let lyricist'_period_'en = _prefixId.prefix "lyricist.en"
    let manifestationOfWork = _prefixId.prefix "manifestationOfWork"
    let manifestationOfWork'_period_'en = _prefixId.prefix "manifestationOfWork.en"
    let medium = _prefixId.prefix "medium"
    let medium'_period_'en = _prefixId.prefix "medium.en"
    let mediumOfPerformance = _prefixId.prefix "mediumOfPerformance"
    let mediumOfPerformance'_period_'en = _prefixId.prefix "mediumOfPerformance.en"
    let mergedToFormWork = _prefixId.prefix "mergedToFormWork"
    let mergedToFormWork'_period_'en = _prefixId.prefix "mergedToFormWork.en"
    let mergerOfWork = _prefixId.prefix "mergerOfWork"
    let mergerOfWork'_period_'en = _prefixId.prefix "mergerOfWork.en"

    let modifiedByVariationAsWork'_period_'en = _prefixId.prefix "modifiedByVariationAsWork.en"

    let motionPictureAdaptationOfWork = _prefixId.prefix "motionPictureAdaptationOfWork"

    let motionPictureAdaptationOfWork'_period_'en = _prefixId.prefix "motionPictureAdaptationOfWork.en"

    let motionPictureMusicWork = _prefixId.prefix "motionPictureMusicWork"

    let motionPictureMusicWork'_period_'en = _prefixId.prefix "motionPictureMusicWork.en"

    let motionPictureScreenplayBasedOnWork = _prefixId.prefix "motionPictureScreenplayBasedOnWork"

    let motionPictureScreenplayBasedOnWork'_period_'en = _prefixId.prefix "motionPictureScreenplayBasedOnWork.en"

    let motionPictureScreenplayWork = _prefixId.prefix "motionPictureScreenplayWork"

    let motionPictureScreenplayWork'_period_'en = _prefixId.prefix "motionPictureScreenplayWork.en"

    let musicForMotionPictureWork = _prefixId.prefix "musicForMotionPictureWork"

    let musicForMotionPictureWork'_period_'en = _prefixId.prefix "musicForMotionPictureWork.en"

    let musicForRadioProgramWork = _prefixId.prefix "musicForRadioProgramWork"

    let musicForRadioProgramWork'_period_'en = _prefixId.prefix "musicForRadioProgramWork.en"

    let musicForTelevisionProgramWork = _prefixId.prefix "musicForTelevisionProgramWork"

    let musicForTelevisionProgramWork'_period_'en = _prefixId.prefix "musicForTelevisionProgramWork.en"

    let musicForVideoWork = _prefixId.prefix "musicForVideoWork"
    let musicForVideoWork'_period_'en = _prefixId.prefix "musicForVideoWork.en"
    let musicForWork = _prefixId.prefix "musicForWork"
    let musicForWork'_period_'en = _prefixId.prefix "musicForWork.en"
    let musicWork = _prefixId.prefix "musicWork"
    let musicWork'_period_'en = _prefixId.prefix "musicWork.en"
    let musicalSettingOfWork = _prefixId.prefix "musicalSettingOfWork"
    let musicalSettingOfWork'_period_'en = _prefixId.prefix "musicalSettingOfWork.en"
    let musicalSettingWork = _prefixId.prefix "musicalSettingWork"

    let musicalTheatreAdaptationOfWork = _prefixId.prefix "musicalTheatreAdaptationOfWork"

    let musicalTheatreAdaptationOfWork'_period_'en = _prefixId.prefix "musicalTheatreAdaptationOfWork.en"

    let musicalVariationsBasedOnWork = _prefixId.prefix "musicalVariationsBasedOnWork"
    let musicalVariationsWork = _prefixId.prefix "musicalVariationsWork"
    let natureOfTheContent = _prefixId.prefix "natureOfTheContent"
    let natureOfTheContent'_period_'en = _prefixId.prefix "natureOfTheContent.en"
    let novelizationOfWork = _prefixId.prefix "novelizationOfWork"
    let novelizationOfWork'_period_'en = _prefixId.prefix "novelizationOfWork.en"
    let novelizationWork = _prefixId.prefix "novelizationWork"
    let numberingOfPart = _prefixId.prefix "numberingOfPart"
    let numberingOfPart'_period_'en = _prefixId.prefix "numberingOfPart.en"

    let numericDesignationOfAMusicalWork = _prefixId.prefix "numericDesignationOfAMusicalWork"

    let numericDesignationOfAMusicalWork'_period_'en = _prefixId.prefix "numericDesignationOfAMusicalWork.en"

    let operaAdaptationOf = _prefixId.prefix "operaAdaptationOf"
    let operaAdaptationOf'_period_'en = _prefixId.prefix "operaAdaptationOf.en"

    let oratorioAdaptationWork'_period_'en = _prefixId.prefix "oratorioAdaptationWork.en"

    let organizer'_period_'en = _prefixId.prefix "organizer.en"

    let otherDistinguishingCharacteristicOfTheWork = _prefixId.prefix "otherDistinguishingCharacteristicOfTheWork"

    let otherDistinguishingCharacteristicOfTheWork'_period_'en = _prefixId.prefix "otherDistinguishingCharacteristicOfTheWork.en"

    let otherPFCWork = _prefixId.prefix "otherPFCWork"
    let otherPFCWork'_period_'en = _prefixId.prefix "otherPFCWork.en"
    let paraphraseOfWork = _prefixId.prefix "paraphraseOfWork"
    let paraphraseOfWork'_period_'en = _prefixId.prefix "paraphraseOfWork.en"
    let paraphrasedAsWork = _prefixId.prefix "paraphrasedAsWork"
    let paraphrasedAsWork'_period_'en = _prefixId.prefix "paraphrasedAsWork.en"
    let parodiedAsWork = _prefixId.prefix "parodiedAsWork"
    let parodiedAsWork'_period_'en = _prefixId.prefix "parodiedAsWork.en"
    let parodyOfWork = _prefixId.prefix "parodyOfWork"
    let parodyOfWork'_period_'en = _prefixId.prefix "parodyOfWork.en"
    let participantInATreaty'_period_'en = _prefixId.prefix "participantInATreaty.en"
    let photographer = _prefixId.prefix "photographer"
    let photographer'_period_'en = _prefixId.prefix "photographer.en"
    let placeOfOriginOfTheWork = _prefixId.prefix "placeOfOriginOfTheWork"

    let placeOfOriginOfTheWork'_period_'en = _prefixId.prefix "placeOfOriginOfTheWork.en"

    let plaintiff = _prefixId.prefix "plaintiff"
    let plaintiff'_period_'en = _prefixId.prefix "plaintiff.en"
    let plaintiffCorporateBody = _prefixId.prefix "plaintiffCorporateBody"

    let plaintiffCorporateBody'_period_'en = _prefixId.prefix "plaintiffCorporateBody.en"

    let plaintiffPerson = _prefixId.prefix "plaintiffPerson"
    let plaintiffPerson'_period_'en = _prefixId.prefix "plaintiffPerson.en"
    let praeses = _prefixId.prefix "praeses"
    let praeses'_period_'en = _prefixId.prefix "praeses.en"
    let precededByWork = _prefixId.prefix "precededByWork"
    let precededByWork'_period_'en = _prefixId.prefix "precededByWork.en"
    let preferredTitleForTheWork = _prefixId.prefix "preferredTitleForTheWork"

    let preferredTitleForTheWork'_period_'en = _prefixId.prefix "preferredTitleForTheWork.en"

    let prequel = _prefixId.prefix "prequel"
    let prequel'_period_'en = _prefixId.prefix "prequel.en"
    let prequelTo = _prefixId.prefix "prequelTo"
    let prequelTo'_period_'en = _prefixId.prefix "prequelTo.en"
    let producer = _prefixId.prefix "producer"
    let producer'_period_'en = _prefixId.prefix "producer.en"
    let productionCompany = _prefixId.prefix "productionCompany"
    let productionCompany'_period_'en = _prefixId.prefix "productionCompany.en"
    let programmer = _prefixId.prefix "programmer"
    let programmer'_period_'en = _prefixId.prefix "programmer.en"
    let radioAdaptationOfWork = _prefixId.prefix "radioAdaptationOfWork"
    let radioAdaptationOfWork'_period_'en = _prefixId.prefix "radioAdaptationOfWork.en"
    let radioDirector = _prefixId.prefix "radioDirector"
    let radioDirector'_period_'en = _prefixId.prefix "radioDirector.en"
    let radioProducer = _prefixId.prefix "radioProducer"
    let radioProducer'_period_'en = _prefixId.prefix "radioProducer.en"
    let radioProgramMusicWork = _prefixId.prefix "radioProgramMusicWork"
    let radioProgramMusicWork'_period_'en = _prefixId.prefix "radioProgramMusicWork.en"
    let radioScriptBasedOnWork = _prefixId.prefix "radioScriptBasedOnWork"

    let radioScriptBasedOnWork'_period_'en = _prefixId.prefix "radioScriptBasedOnWork.en"

    let radioScriptWork = _prefixId.prefix "radioScriptWork"
    let radioScriptWork'_period_'en = _prefixId.prefix "radioScriptWork.en"
    let rapporteur'_period_'en = _prefixId.prefix "rapporteur.en"

    let referentialWorkRelationship'_period_'en = _prefixId.prefix "referentialWorkRelationship.en"

    let relatedWork = _prefixId.prefix "relatedWork"
    let relatedWork'_period_'en = _prefixId.prefix "relatedWork.en"
    let remadeAsWork = _prefixId.prefix "remadeAsWork"
    let remadeAsWork'_period_'en = _prefixId.prefix "remadeAsWork.en"
    let remakeOfWork = _prefixId.prefix "remakeOfWork"
    let remakeOfWork'_period_'en = _prefixId.prefix "remakeOfWork.en"
    let replacedByWork = _prefixId.prefix "replacedByWork"
    let replacedByWork'_period_'en = _prefixId.prefix "replacedByWork.en"
    let replacedInPartByWork = _prefixId.prefix "replacedInPartByWork"
    let replacedInPartByWork'_period_'en = _prefixId.prefix "replacedInPartByWork.en"

    let replacementInPartOfWork'_period_'en = _prefixId.prefix "replacementInPartOfWork.en"

    let replacementOfWork'_period_'en = _prefixId.prefix "replacementOfWork.en"
    let researcher'_period_'en = _prefixId.prefix "researcher.en"
    let respondent = _prefixId.prefix "respondent"
    let respondent'_period_'en = _prefixId.prefix "respondent.en"
    let reviewOfExpression'_period_'en = _prefixId.prefix "reviewOfExpression.en"
    let reviewOfItem'_period_'en = _prefixId.prefix "reviewOfItem.en"
    let reviewOfManifestation'_period_'en = _prefixId.prefix "reviewOfManifestation.en"
    let reviewOfWork = _prefixId.prefix "reviewOfWork"
    let reviewOfWork'_period_'en = _prefixId.prefix "reviewOfWork.en"
    let reviewedInWork = _prefixId.prefix "reviewedInWork"
    let reviewedInWork'_period_'en = _prefixId.prefix "reviewedInWork.en"
    let rightAscensionAndDeclination = _prefixId.prefix "rightAscensionAndDeclination"

    let rightAscensionAndDeclination'_period_'en = _prefixId.prefix "rightAscensionAndDeclination.en"

    let screenplayBasedOnWork = _prefixId.prefix "screenplayBasedOnWork"
    let screenplayBasedOnWork'_period_'en = _prefixId.prefix "screenplayBasedOnWork.en"

    let screenplayForTheMotionPictureWork = _prefixId.prefix "screenplayForTheMotionPictureWork"

    let screenplayForTheMotionPictureWork'_period_'en = _prefixId.prefix "screenplayForTheMotionPictureWork.en"

    let screenplayForTheTelevisionProgramWork = _prefixId.prefix "screenplayForTheTelevisionProgramWork"

    let screenplayForTheTelevisionProgramWork'_period_'en = _prefixId.prefix "screenplayForTheTelevisionProgramWork.en"

    let screenplayForTheVideoWork = _prefixId.prefix "screenplayForTheVideoWork"

    let screenplayForTheVideoWork'_period_'en = _prefixId.prefix "screenplayForTheVideoWork.en"

    let screenplayForWork = _prefixId.prefix "screenplayForWork"
    let screenplayForWork'_period_'en = _prefixId.prefix "screenplayForWork.en"
    let screenplayWork = _prefixId.prefix "screenplayWork"
    let screenplayWork'_period_'en = _prefixId.prefix "screenplayWork.en"
    let screenwriter = _prefixId.prefix "screenwriter"
    let screenwriter'_period_'en = _prefixId.prefix "screenwriter.en"
    let scriptForTheRadioProgramWork = _prefixId.prefix "scriptForTheRadioProgramWork"

    let scriptForTheRadioProgramWork'_period_'en = _prefixId.prefix "scriptForTheRadioProgramWork.en"

    let sculptor = _prefixId.prefix "sculptor"
    let sculptor'_period_'en = _prefixId.prefix "sculptor.en"
    let separatedFromWork = _prefixId.prefix "separatedFromWork"
    let separatedFromWork'_period_'en = _prefixId.prefix "separatedFromWork.en"
    let sequel = _prefixId.prefix "sequel"
    let sequel'_period_'en = _prefixId.prefix "sequel.en"
    let sequelTo = _prefixId.prefix "sequelTo"
    let sequelTo'_period_'en = _prefixId.prefix "sequelTo.en"
    let sequentialWorkRelationship = _prefixId.prefix "sequentialWorkRelationship"

    let sequentialWorkRelationship'_period_'en = _prefixId.prefix "sequentialWorkRelationship.en"

    let seriesContainerOf'_period_'en = _prefixId.prefix "seriesContainerOf.en"
    let seriesContains = _prefixId.prefix "seriesContains"
    let setToMusicAsWork'_period_'en = _prefixId.prefix "setToMusicAsWork.en"
    let splitIntoWork = _prefixId.prefix "splitIntoWork"
    let splitIntoWork'_period_'en = _prefixId.prefix "splitIntoWork.en"
    let sponsoringBody = _prefixId.prefix "sponsoringBody"
    let sponsoringBody'_period_'en = _prefixId.prefix "sponsoringBody.en"
    let stringsOfCoordinatePairs = _prefixId.prefix "stringsOfCoordinatePairs"

    let stringsOfCoordinatePairs'_period_'en = _prefixId.prefix "stringsOfCoordinatePairs.en"

    let subjectCorporateBody'_period_'en = _prefixId.prefix "subjectCorporateBody.en"
    let subjectExpression'_period_'en = _prefixId.prefix "subjectExpression.en"
    let subjectFamily'_period_'en = _prefixId.prefix "subjectFamily.en"
    let subjectItem'_period_'en = _prefixId.prefix "subjectItem.en"
    let subjectManifestation'_period_'en = _prefixId.prefix "subjectManifestation.en"
    let subjectOfWork'_period_'en = _prefixId.prefix "subjectOfWork.en"
    let subjectPerson'_period_'en = _prefixId.prefix "subjectPerson.en"
    let subjectRelationship'_period_'en = _prefixId.prefix "subjectRelationship.en"
    let subjectWork'_period_'en = _prefixId.prefix "subjectWork.en"
    let subseries = _prefixId.prefix "subseries"
    let subseries'_period_'en = _prefixId.prefix "subseries.en"
    let subseriesOf = _prefixId.prefix "subseriesOf"
    let subseriesOf'_period_'en = _prefixId.prefix "subseriesOf.en"
    let succeededByWork = _prefixId.prefix "succeededByWork"
    let succeededByWork'_period_'en = _prefixId.prefix "succeededByWork.en"
    let summarizedAsWork'_period_'en = _prefixId.prefix "summarizedAsWork.en"
    let summaryOfWork = _prefixId.prefix "summaryOfWork"
    let summaryOfWork'_period_'en = _prefixId.prefix "summaryOfWork.en"
    let summaryWork = _prefixId.prefix "summaryWork"
    let supersedesInPartWork = _prefixId.prefix "supersedesInPartWork"
    let supersedesWork = _prefixId.prefix "supersedesWork"
    let supplementToWork = _prefixId.prefix "supplementToWork"
    let supplementToWork'_period_'en = _prefixId.prefix "supplementToWork.en"
    let supplementWork = _prefixId.prefix "supplementWork"
    let supplementWork'_period_'en = _prefixId.prefix "supplementWork.en"
    let systemOfOrganization = _prefixId.prefix "systemOfOrganization"
    let systemOfOrganization'_period_'en = _prefixId.prefix "systemOfOrganization.en"
    let televisionAdaptationOfWork = _prefixId.prefix "televisionAdaptationOfWork"

    let televisionAdaptationOfWork'_period_'en = _prefixId.prefix "televisionAdaptationOfWork.en"

    let televisionDirector = _prefixId.prefix "televisionDirector"
    let televisionDirector'_period_'en = _prefixId.prefix "televisionDirector.en"
    let televisionProducer = _prefixId.prefix "televisionProducer"
    let televisionProducer'_period_'en = _prefixId.prefix "televisionProducer.en"
    let televisionProgramMusicWork = _prefixId.prefix "televisionProgramMusicWork"

    let televisionProgramMusicWork'_period_'en = _prefixId.prefix "televisionProgramMusicWork.en"

    let televisionScreenplayBasedOnWork = _prefixId.prefix "televisionScreenplayBasedOnWork"

    let televisionScreenplayBasedOnWork'_period_'en = _prefixId.prefix "televisionScreenplayBasedOnWork.en"

    let televisionScreenplayWork = _prefixId.prefix "televisionScreenplayWork"

    let televisionScreenplayWork'_period_'en = _prefixId.prefix "televisionScreenplayWork.en"

    let titleOfTheWork = _prefixId.prefix "titleOfTheWork"
    let titleOfTheWork'_period_'en = _prefixId.prefix "titleOfTheWork.en"
    let variantTitleForTheWork = _prefixId.prefix "variantTitleForTheWork"

    let variantTitleForTheWork'_period_'en = _prefixId.prefix "variantTitleForTheWork.en"

    let variationsBasedOnWork'_period_'en = _prefixId.prefix "variationsBasedOnWork.en"
    let verseAdaptationOfWork = _prefixId.prefix "verseAdaptationOfWork"
    let verseAdaptationOfWork'_period_'en = _prefixId.prefix "verseAdaptationOfWork.en"
    let verseAdaptationWork = _prefixId.prefix "verseAdaptationWork"
    let videoAdaptationOfWork = _prefixId.prefix "videoAdaptationOfWork"
    let videoAdaptationOfWork'_period_'en = _prefixId.prefix "videoAdaptationOfWork.en"

    let videoGameAdaptationOfWork'_period_'en = _prefixId.prefix "videoGameAdaptationOfWork.en"

    let videoMusicWork = _prefixId.prefix "videoMusicWork"
    let videoMusicWork'_period_'en = _prefixId.prefix "videoMusicWork.en"
    let videoScreenplayBasedOnWork = _prefixId.prefix "videoScreenplayBasedOnWork"

    let videoScreenplayBasedOnWork'_period_'en = _prefixId.prefix "videoScreenplayBasedOnWork.en"

    let videoScreenplayWork = _prefixId.prefix "videoScreenplayWork"
    let videoScreenplayWork'_period_'en = _prefixId.prefix "videoScreenplayWork.en"
    let wholePartWorkRelationship = _prefixId.prefix "wholePartWorkRelationship"

    let wholePartWorkRelationship'_period_'en = _prefixId.prefix "wholePartWorkRelationship.en"

    let yearDegreeGranted = _prefixId.prefix "yearDegreeGranted"
    let yearDegreeGranted'_period_'en = _prefixId.prefix "yearDegreeGranted.en"
    let zxd = _prefixId.prefix "zxd"
