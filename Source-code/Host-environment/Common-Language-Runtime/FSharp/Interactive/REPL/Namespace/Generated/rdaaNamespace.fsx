#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdaa =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/a/" "rdaa"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : Relates a candidate for a degree who defends or opposes a thesis provided by the praeses in an academic disputation to the work.</para>
    ///   <para>rdfs:label : is respondent of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : respondentOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50001">rdaa:P50001</a>
    /// </summary>
    let P50001 = _prefixId.prefix "P50001"
    /// <summary>
    ///   <para>rdfs:label : is appellee corporate body of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleeCorporateBodyOf</para>
    ///   <para>skos:definition : Relates a corporate body against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50002">rdaa:P50002</a>
    /// </summary>
    let P50002 = _prefixId.prefix "P50002"
    /// <summary>
    ///   <para>rdfs:label : is degree granting institution of</para>
    ///   <para>skos:definition : Relates a corporate body granting an academic degree to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeGrantingInstitutionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50003">rdaa:P50003</a>
    /// </summary>
    let P50003 = _prefixId.prefix "P50003"
    /// <summary>
    ///   <para>rdfs:label : is host institution of</para>
    ///   <para>skos:definition : Relates a corporate body hosting the event, exhibit, conference, etc to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostInstitutionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50004">rdaa:P50004</a>
    /// </summary>
    let P50004 = _prefixId.prefix "P50004"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionCompanyOf</para>
    ///   <para>rdfs:label : is production company of</para>
    ///   <para>skos:definition : Relates a corporate body that is responsible for financial, technical, and organizational management of a production for stage, screen, sound recording, television, webcast, etc to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50005">rdaa:P50005</a>
    /// </summary>
    let P50005 = _prefixId.prefix "P50005"
    /// <summary>
    ///   <para>skos:scopeNote : The identifier serves to differentiate that corporate body from other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A character string uniquely associated with a corporate body, or with a surrogate for a corporate body (e.g., an authority record).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : identifier for the corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a character string uniquely associated with a corporate body, or with a surrogate for a corporate body (e.g., an authority record).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheCorporateBody</para>
    ///   <para>rdfs:label : has identifier for the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.12^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50006">rdaa:P50006</a>
    /// </summary>
    let P50006 = _prefixId.prefix "P50006"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundingCorporateBody</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that founded the other corporate body.</para>
    ///   <para>rdfs:label : has founding corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : founding corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that founded the other corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50007">rdaa:P50007</a>
    /// </summary>
    let P50007 = _prefixId.prefix "P50007"
    /// <summary>
    ///   <para>rdfs:label : has hierarchical superior</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hierarchicalSuperior</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that is hierarchically superior to the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : hierarchical superior</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that is hierarchically superior to the other corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50008">rdaa:P50008</a>
    /// </summary>
    let P50008 = _prefixId.prefix "P50008"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that is sponsored by the other corporate body.</para>
    ///   <para>rdfs:label : has sponsored corporate body of corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sponsored corporate body of corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoredCorporateBodyOfCorporateBody</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that is sponsored by the other corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50009">rdaa:P50009</a>
    /// </summary>
    let P50009 = _prefixId.prefix "P50009"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hierarchicalSubordinate</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that is subordinate to the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that is subordinate to the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : hierarchical subordinate</para>
    ///   <para>rdfs:label : has hierarchical subordinate</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50010">rdaa:P50010</a>
    /// </summary>
    let P50010 = _prefixId.prefix "P50010"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : mergee</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that merged with the other corporate body to form a third.</para>
    ///   <para>rdfs:label : has mergee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that merged with the other corporate body to form a third.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergee</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50011">rdaa:P50011</a>
    /// </summary>
    let P50011 = _prefixId.prefix "P50011"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that precedes the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : predecessor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : predecessor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that precedes the other corporate body.</para>
    ///   <para>rdfs:label : has predecessor</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50012">rdaa:P50012</a>
    /// </summary>
    let P50012 = _prefixId.prefix "P50012"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that resulted from a merger of two or more other corporate bodies.</para>
    ///   <para>rdfs:label : has product of merger</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that resulted from a merger of two or more other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : product of merger</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productOfAMerger</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50013">rdaa:P50013</a>
    /// </summary>
    let P50013 = _prefixId.prefix "P50013"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : product of split</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that resulted from a split or division of the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productOfASplit</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that resulted from a split or division of the other corporate body.</para>
    ///   <para>rdfs:label : has product of split</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50014">rdaa:P50014</a>
    /// </summary>
    let P50014 = _prefixId.prefix "P50014"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sponsoring corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that sponsors the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that sponsors the other corporate body.</para>
    ///   <para>rdfs:label : has sponsoring corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50015">rdaa:P50015</a>
    /// </summary>
    let P50015 = _prefixId.prefix "P50015"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : successor</para>
    ///   <para>rdfs:label : has successor</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that succeeds or follows the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that succeeds or follows the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : successor</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50016">rdaa:P50016</a>
    /// </summary>
    let P50016 = _prefixId.prefix "P50016"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that the other corporate body founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundedCorporateBodyOfCorporateBody</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that the other corporate body founded.</para>
    ///   <para>rdfs:label : has founded corporate body of corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : founded corporate body of corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50017">rdaa:P50017</a>
    /// </summary>
    let P50017 = _prefixId.prefix "P50017"
    let P50018 = _prefixId.prefix "P50018"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a designation of the sequencing of a conference, etc., within a series of conferences, etc.</para>
    ///   <para>rdfs:label : has number of a conference, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A designation of the sequencing of a conference, etc., within a series of conferences, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : number of a conference, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberOfAConferenceEtc</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.6^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50019">rdaa:P50019</a>
    /// </summary>
    let P50019 = _prefixId.prefix "P50019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family that founded the corporate body.</para>
    ///   <para>rdfs:label : has founding family</para>
    ///   <para>skos:definition : Relates a corporate body to a family that founded the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundingFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : founding family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50020">rdaa:P50020</a>
    /// </summary>
    let P50020 = _prefixId.prefix "P50020"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a family that sponsors the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family that sponsors the corporate body.</para>
    ///   <para>rdfs:label : has sponsoring family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sponsoring family</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringFamily</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50021">rdaa:P50021</a>
    /// </summary>
    let P50021 = _prefixId.prefix "P50021"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fieldOfActivityOfTheCorporateBody</para>
    ///   <para>rdfs:label : has field of activity of the corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a field of business in which a corporate body is engaged and/or the body's area of competence, responsibility, jurisdiction, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A field of business in which a corporate body is engaged and/or the body's area of competence, responsibility, jurisdiction, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : field of activity of the corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50022">rdaa:P50022</a>
    /// </summary>
    let P50022 = _prefixId.prefix "P50022"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A language a corporate body uses in its communications.</para>
    ///   <para>rdfs:label : has language of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : language of the corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a language a corporate body uses in its communications.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50023">rdaa:P50023</a>
    /// </summary>
    let P50023 = _prefixId.prefix "P50023"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : location of conference, etc.</para>
    ///   <para>rdfs:label : has location of conference, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : locationOfConferenceEtc</para>
    ///   <para>skos:definition : Relates a corporate body to a local place in which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.3.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A local place in which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50024">rdaa:P50024</a>
    /// </summary>
    let P50024 = _prefixId.prefix "P50024"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.2.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A name or form of name by which a corporate body is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : variant name for the corporate body</para>
    ///   <para>rdfs:label : has variant name for the corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a name or form of name by which a corporate body is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50025">rdaa:P50025</a>
    /// </summary>
    let P50025 = _prefixId.prefix "P50025"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a person employed by the corporate body.</para>
    ///   <para>rdfs:label : has employee</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : employee</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person employed by the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : employee</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50026">rdaa:P50026</a>
    /// </summary>
    let P50026 = _prefixId.prefix "P50026"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : incumbent</para>
    ///   <para>skos:definition : Relates a corporate body to a person holding an office in the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person holding an office in the corporate body.</para>
    ///   <para>rdfs:label : has incumbent</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incumbent</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50027">rdaa:P50027</a>
    /// </summary>
    let P50027 = _prefixId.prefix "P50027"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsor</para>
    ///   <para>rdfs:label : has sponsor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sponsor</para>
    ///   <para>skos:definition : Relates a corporate body to a person sponsoring the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person sponsoring the corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50028">rdaa:P50028</a>
    /// </summary>
    let P50028 = _prefixId.prefix "P50028"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : founder</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : founder</para>
    ///   <para>rdfs:label : has founder</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who founded the corporate body.</para>
    ///   <para>skos:definition : Relates a corporate body to a person who founded the corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50029">rdaa:P50029</a>
    /// </summary>
    let P50029 = _prefixId.prefix "P50029"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : group member</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : groupMember</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who is a member of the performing group, expedition, etc.</para>
    ///   <para>skos:definition : Relates a corporate body to a person who is a member of the performing group, expedition, etc.</para>
    ///   <para>rdfs:label : has group member</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50030">rdaa:P50030</a>
    /// </summary>
    let P50030 = _prefixId.prefix "P50030"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a significant location associated with a corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAssociatedWithTheCorporateBody</para>
    ///   <para>rdfs:label : has place associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A significant location associated with a corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50031">rdaa:P50031</a>
    /// </summary>
    let P50031 = _prefixId.prefix "P50031"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a word, character, or group of words and/or characters by which a corporate body is known.</para>
    ///   <para>rdfs:label : has name of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : name of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character, or group of words and/or characters by which a corporate body is known.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50032">rdaa:P50032</a>
    /// </summary>
    let P50032 = _prefixId.prefix "P50032"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.7^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, phrase, or abbreviation indicating incorporation or legal status of a corporate body, or any term serving to differentiate the body from other corporate bodies, persons, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDesignationAssociatedWithTheCorporateBody</para>
    ///   <para>skos:definition : Relates a corporate body to a word, phrase, or abbreviation indicating incorporation or legal status of a corporate body, or any term serving to differentiate the body from other corporate bodies, persons, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other designation associated with the corporate body</para>
    ///   <para>rdfs:label : has other designation associated with the corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50033">rdaa:P50033</a>
    /// </summary>
    let P50033 = _prefixId.prefix "P50033"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : associatedInstitution</para>
    ///   <para>rdfs:label : has associated institution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : associated institution</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An institution commonly associated with a corporate body.</para>
    ///   <para>skos:definition : Relates a corporate body to an institution commonly associated with a corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50034">rdaa:P50034</a>
    /// </summary>
    let P50034 = _prefixId.prefix "P50034"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : corporateHistory</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.11^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : corporate history</para>
    ///   <para>skos:definition : Relates a corporate body to historical information about the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Historical information about the corporate body.</para>
    ///   <para>rdfs:label : has corporate history</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50035">rdaa:P50035</a>
    /// </summary>
    let P50035 = _prefixId.prefix "P50035"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressOfTheCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.9^^xsd:string</para>
    ///   <para>skos:definition : Relates a corporate body to the address of a corporate body's headquarters or offices, or an e-mail or internet address for the body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The address of a corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : address of the corporate body</para>
    ///   <para>rdfs:label : has address of the corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50036">rdaa:P50036</a>
    /// </summary>
    let P50036 = _prefixId.prefix "P50036"
    /// <summary>
    ///   <para>rdfs:label : has date of establishment</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The date on which a corporate body was established or founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfEstablishment</para>
    ///   <para>skos:definition : Relates a corporate body to the date on which a corporate body was established or founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of establishment</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.4.3^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50037">rdaa:P50037</a>
    /// </summary>
    let P50037 = _prefixId.prefix "P50037"
    /// <summary>
    ///   <para>rdfs:label : has date of termination</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.4.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfTermination</para>
    ///   <para>skos:definition : Relates a corporate body to the date on which a corporate body was terminated or dissolved.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of termination</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The date on which a corporate body was terminated or dissolved.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50038">rdaa:P50038</a>
    /// </summary>
    let P50038 = _prefixId.prefix "P50038"
    /// <summary>
    ///   <para>rdfs:label : has date of conference, etc.</para>
    ///   <para>skos:definition : Relates a corporate body to the date or range of dates on which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of conference, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.4.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The date or range of dates on which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfConferenceEtc</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50039">rdaa:P50039</a>
    /// </summary>
    let P50039 = _prefixId.prefix "P50039"
    /// <summary>
    ///   <para>rdfs:label : has date associated with the corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a significant date associated with the history of a corporate body, including date of conference, date of establishment, date of termination, and period of activity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A significant date associated with the history of a corporate body, including date of conference, date of establishment, date of termination, and period of activity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithTheCorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50040">rdaa:P50040</a>
    /// </summary>
    let P50040 = _prefixId.prefix "P50040"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name or form of name chosen to identify the corporate body.</para>
    ///   <para>rdfs:label : has preferred name for the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preferred name for the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.2.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a corporate body to the name or form of name chosen to identify the corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50041">rdaa:P50041</a>
    /// </summary>
    let P50041 = _prefixId.prefix "P50041"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantCorporateBodyOf</para>
    ///   <para>skos:definition : Relates a corporate body who appeals the decision of a lower court recorded in a legal work of a higher court  to the work.</para>
    ///   <para>rdfs:label : is appellant corporate body of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50042">rdaa:P50042</a>
    /// </summary>
    let P50042 = _prefixId.prefix "P50042"
    /// <summary>
    ///   <para>rdfs:label : is plaintiff corporate body of</para>
    ///   <para>skos:definition : Relates a corporate body who brings a suit in a civil proceeding to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffCorporateBodyOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50043">rdaa:P50043</a>
    /// </summary>
    let P50043 = _prefixId.prefix "P50043"
    /// <summary>
    ///   <para>skos:definition : Relates a court governed by court rules, regardless of their official nature (e.g., laws, administrative regulations) to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtGovernedOf</para>
    ///   <para>rdfs:label : is court governed of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50044">rdaa:P50044</a>
    /// </summary>
    let P50044 = _prefixId.prefix "P50044"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectorOf</para>
    ///   <para>rdfs:label : is collector of</para>
    ///   <para>skos:definition : Relates a curator who brings together items from various sources that are then arranged, described, and cataloged as a collection to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50045">rdaa:P50045</a>
    /// </summary>
    let P50045 = _prefixId.prefix "P50045"
    /// <summary>
    ///   <para>rdfs:label : is collection registrar of</para>
    ///   <para>skos:definition : Relates a curator who lists or inventories the items in an aggregate work such as a collection of items or works to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectionRegistrarOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50046">rdaa:P50046</a>
    /// </summary>
    let P50046 = _prefixId.prefix "P50046"
    /// <summary>
    ///   <para>rdfs:label : is depositor of</para>
    ///   <para>skos:definition : Relates a current owner of an item who deposited the item into the custody of another person, family, or corporate body, while still retaining ownership to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : depositorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50047">rdaa:P50047</a>
    /// </summary>
    let P50047 = _prefixId.prefix "P50047"
    /// <summary>
    ///   <para>rdfs:label : is film director of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDirectorOf</para>
    ///   <para>skos:definition : Relates a director responsible for the general management and supervision of a filmed performance to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50048">rdaa:P50048</a>
    /// </summary>
    let P50048 = _prefixId.prefix "P50048"
    /// <summary>
    ///   <para>skos:definition : Relates a director responsible for the general management and supervision of a radio program to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioDirectorOf</para>
    ///   <para>rdfs:label : is radio director of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50049">rdaa:P50049</a>
    /// </summary>
    let P50049 = _prefixId.prefix "P50049"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionDirectorOf</para>
    ///   <para>rdfs:label : is television director of</para>
    ///   <para>skos:definition : Relates a director responsible for the general management and supervision of a television program to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50050">rdaa:P50050</a>
    /// </summary>
    let P50050 = _prefixId.prefix "P50050"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a categorization or generic descriptor for the type of family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A categorization or generic descriptor for the type of family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : type of family</para>
    ///   <para>rdfs:label : has type of family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.3^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50051">rdaa:P50051</a>
    /// </summary>
    let P50051 = _prefixId.prefix "P50051"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.1^^xsd:string</para>
    ///   <para>skos:scopeNote : The identifier serves to differentiate that family from other families.</para>
    ///   <para>skos:definition : Relates a family to a character string uniquely associated with a family, or with a surrogate for a family (e.g., an authority record).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : identifier for the family</para>
    ///   <para>rdfs:label : has identifier for the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A character string uniquely associated with a family, or with a surrogate for a family (e.g., an authority record).</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50052">rdaa:P50052</a>
    /// </summary>
    let P50052 = _prefixId.prefix "P50052"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a family descended from the other family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : descendant family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family descended from the other family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descendantFamily</para>
    ///   <para>rdfs:label : has descendant family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50053">rdaa:P50053</a>
    /// </summary>
    let P50053 = _prefixId.prefix "P50053"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a name or form of name by which a family is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.2.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : variant name for the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A name or form of name by which a family is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>rdfs:label : has variant name for the family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50054">rdaa:P50054</a>
    /// </summary>
    let P50054 = _prefixId.prefix "P50054"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : progenitor</para>
    ///   <para>rdfs:label : has progenitor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person from whom the family is descended.</para>
    ///   <para>skos:definition : Relates a family to a person from whom the family is descended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : progenitor</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50055">rdaa:P50055</a>
    /// </summary>
    let P50055 = _prefixId.prefix "P50055"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : familyMember</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who is a member of the family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : family member</para>
    ///   <para>skos:definition : Relates a family to a person who is a member of the family.</para>
    ///   <para>rdfs:label : has family member</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50056">rdaa:P50056</a>
    /// </summary>
    let P50056 = _prefixId.prefix "P50056"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place where a family resides or has resided or has some connection.</para>
    ///   <para>rdfs:label : has place associated with the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place associated with the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.5^^xsd:string</para>
    ///   <para>skos:definition : Relates a family to a place where a family resides or has resided or has some connection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAssociatedWithTheFamily</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50057">rdaa:P50057</a>
    /// </summary>
    let P50057 = _prefixId.prefix "P50057"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a significant date associated with a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithTheFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A significant date associated with a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date associated with the family</para>
    ///   <para>rdfs:label : has date associated with the family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50058">rdaa:P50058</a>
    /// </summary>
    let P50058 = _prefixId.prefix "P50058"
    /// <summary>
    ///   <para>rdfs:label : has hereditary title</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : hereditary title</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hereditaryTitle</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A title of nobility, etc., associated with a family.</para>
    ///   <para>skos:definition : Relates a family to a title of nobility, etc., associated with a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.7^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50059">rdaa:P50059</a>
    /// </summary>
    let P50059 = _prefixId.prefix "P50059"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a well-known individual who is a member of a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prominentMemberOfTheFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A well-known individual who is a member of a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : prominent member of the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.6^^xsd:string</para>
    ///   <para>rdfs:label : has prominent member of the family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50060">rdaa:P50060</a>
    /// </summary>
    let P50060 = _prefixId.prefix "P50060"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : name of the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a family to a word, character, or group of words and/or characters by which a family is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character, or group of words and/or characters by which a family is known.</para>
    ///   <para>rdfs:label : has name of the family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50061">rdaa:P50061</a>
    /// </summary>
    let P50061 = _prefixId.prefix "P50061"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundedCorporateBodyOfFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : founded corporate body of family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An organization that the family founded.</para>
    ///   <para>rdfs:label : has founded corporate body of family</para>
    ///   <para>skos:definition : Relates a family to an organization that the family founded.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50062">rdaa:P50062</a>
    /// </summary>
    let P50062 = _prefixId.prefix "P50062"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An organization that the family sponsors.</para>
    ///   <para>skos:definition : Relates a family to an organization that the family sponsors.</para>
    ///   <para>rdfs:label : has sponsored corporate body of family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : sponsored corporate body of family</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoredCorporateBodyOfFamily</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50063">rdaa:P50063</a>
    /// </summary>
    let P50063 = _prefixId.prefix "P50063"
    /// <summary>
    ///   <para>rdfs:label : has family history</para>
    ///   <para>skos:definition : Relates a family to biographical information about the family and/or its members.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.9^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : family history</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : familyHistory</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Biographical information about the family and/or its members.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50064">rdaa:P50064</a>
    /// </summary>
    let P50064 = _prefixId.prefix "P50064"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preferred name for the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name or form of name chosen to identify the family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheFamily</para>
    ///   <para>rdfs:label : has preferred name for the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.2.2^^xsd:string</para>
    ///   <para>skos:definition : Relates a family to the name or form of name chosen to identify the family.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50065">rdaa:P50065</a>
    /// </summary>
    let P50065 = _prefixId.prefix "P50065"
    /// <summary>
    ///   <para>rdfs:label : is donor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : donorOf</para>
    ///   <para>skos:definition : Relates a former owner of an item who donated that item to another owner to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50066">rdaa:P50066</a>
    /// </summary>
    let P50066 = _prefixId.prefix "P50066"
    /// <summary>
    ///   <para>skos:definition : Relates a former owner of an item who sold that item to another owner to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sellerOf</para>
    ///   <para>rdfs:label : is seller of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50067">rdaa:P50067</a>
    /// </summary>
    let P50067 = _prefixId.prefix "P50067"
    /// <summary>
    ///   <para>rdfs:label : is enacting jurisdiction of</para>
    ///   <para>skos:definition : Relates a jurisdiction enacting a law, regulation, constitution, court rule, etc. to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : enactingJurisdictionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50068">rdaa:P50068</a>
    /// </summary>
    let P50068 = _prefixId.prefix "P50068"
    /// <summary>
    ///   <para>rdfs:label : is jurisdiction governed of</para>
    ///   <para>skos:definition : Relates a jurisdiction governed by a law, regulation, etc., that was enacted by another jurisdiction to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : jurisdictionGovernedOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50069">rdaa:P50069</a>
    /// </summary>
    let P50069 = _prefixId.prefix "P50069"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a musical work by leading a performing group (orchestra, chorus, opera, etc.) in a musical or dramatic presentation, etc. to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : conductorOf</para>
    ///   <para>rdfs:label : is conductor of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50070">rdaa:P50070</a>
    /// </summary>
    let P50070 = _prefixId.prefix "P50070"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : actorOf</para>
    ///   <para>rdfs:label : is actor of</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by acting as a cast member or player in a musical or dramatic presentation, etc to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50071">rdaa:P50071</a>
    /// </summary>
    let P50071 = _prefixId.prefix "P50071"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenPresenterOf</para>
    ///   <para>skos:scopeNote : An on-screen presenter may appear in nonfiction moving image materials or in introductions to fiction moving image materials.</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by appearing on screen to provide contextual or background information to the expression.</para>
    ///   <para>rdfs:label : is on-screen presenter of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50072">rdaa:P50072</a>
    /// </summary>
    let P50072 = _prefixId.prefix "P50072"
    /// <summary>
    ///   <para>rdfs:label : is dancer of</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by dancing in a musical, dramatic, etc., presentation to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dancerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50073">rdaa:P50073</a>
    /// </summary>
    let P50073 = _prefixId.prefix "P50073"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by giving instruction or providing a demonstration to the expression.</para>
    ///   <para>rdfs:label : is teacher of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : teacherOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50074">rdaa:P50074</a>
    /// </summary>
    let P50074 = _prefixId.prefix "P50074"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by leading a program (often broadcast) that includes other guests, performers, etc. (e.g., talk show host) to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostOf</para>
    ///   <para>rdfs:label : is host of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50075">rdaa:P50075</a>
    /// </summary>
    let P50075 = _prefixId.prefix "P50075"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by leading a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion to the expression.</para>
    ///   <para>rdfs:label : is moderator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : moderatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50076">rdaa:P50076</a>
    /// </summary>
    let P50076 = _prefixId.prefix "P50076"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : puppeteerOf</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by manipulating, controlling, or directing puppets or marionettes in a moving image production or a musical or dramatic presentation or entertainment to the expression.</para>
    ///   <para>rdfs:label : is puppeteer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50077">rdaa:P50077</a>
    /// </summary>
    let P50077 = _prefixId.prefix "P50077"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by participating in a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion to the expression.</para>
    ///   <para>rdfs:label : is panelist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : panelistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50078">rdaa:P50078</a>
    /// </summary>
    let P50078 = _prefixId.prefix "P50078"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by playing a musical instrument to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalistOf</para>
    ///   <para>rdfs:label : is instrumentalist of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50079">rdaa:P50079</a>
    /// </summary>
    let P50079 = _prefixId.prefix "P50079"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by providing interpretation, analysis, or a discussion of the subject matter on a recording, film, or other audiovisual medium to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentatorOf</para>
    ///   <para>rdfs:label : is commentator of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50080">rdaa:P50080</a>
    /// </summary>
    let P50080 = _prefixId.prefix "P50080"
    /// <summary>
    ///   <para>rdfs:label : is narrator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : narratorOf</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by reading aloud or giving an account of an act, occurrence, course of events, etc to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50081">rdaa:P50081</a>
    /// </summary>
    let P50081 = _prefixId.prefix "P50081"
    /// <summary>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by relaying a creator's original story with dramatic or theatrical interpretation to the expression.</para>
    ///   <para>rdfs:label : is storyteller of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : storytellerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50082">rdaa:P50082</a>
    /// </summary>
    let P50082 = _prefixId.prefix "P50082"
    /// <summary>
    ///   <para>rdfs:label : is speaker of</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by speaking words, such as a lecture, speech, etc to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : speakerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50083">rdaa:P50083</a>
    /// </summary>
    let P50083 = _prefixId.prefix "P50083"
    /// <summary>
    ///   <para>rdfs:label : is singer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : singerOf</para>
    ///   <para>skos:scopeNote : A singer's performance may or may not include actual words.</para>
    ///   <para>skos:definition : Relates a performer contributing to an expression of a work by using his/her/their voice, with or without instrumental accompaniment, to produce music to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50084">rdaa:P50084</a>
    /// </summary>
    let P50084 = _prefixId.prefix "P50084"
    /// <summary>
    ///   <para>skos:definition : Relates a person against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleePersonOf</para>
    ///   <para>rdfs:label : is appellee person of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50085">rdaa:P50085</a>
    /// </summary>
    let P50085 = _prefixId.prefix "P50085"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOf</para>
    ///   <para>skos:definition : Relates a person held to be a channel of communication between the earthly world and a world of spirits to the work.</para>
    ///   <para>rdfs:label : is medium of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50086">rdaa:P50086</a>
    /// </summary>
    let P50086 = _prefixId.prefix "P50086"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleeOf</para>
    ///   <para>rdfs:label : is appellee of</para>
    ///   <para>skos:definition : Relates a person or corporate body against whom an appeal is taken on the decision of a lower court recorded in a legal work of a higher court to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50087">rdaa:P50087</a>
    /// </summary>
    let P50087 = _prefixId.prefix "P50087"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantOf</para>
    ///   <para>skos:definition : Relates a person or corporate body who appeals the decision of a lower court recorded in a legal work of a higher court  to the work.</para>
    ///   <para>rdfs:label : is appellant of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50088">rdaa:P50088</a>
    /// </summary>
    let P50088 = _prefixId.prefix "P50088"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffOf</para>
    ///   <para>rdfs:label : is plaintiff of</para>
    ///   <para>skos:definition : Relates a person or corporate body who brings a suit in a civil proceeding to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50089">rdaa:P50089</a>
    /// </summary>
    let P50089 = _prefixId.prefix "P50089"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantOf</para>
    ///   <para>skos:definition : Relates a person or corporate body who is accused in a criminal proceeding or sued in a civil proceeding to the work.</para>
    ///   <para>rdfs:label : is defendant of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50090">rdaa:P50090</a>
    /// </summary>
    let P50090 = _prefixId.prefix "P50090"
    /// <summary>
    ///   <para>skos:definition : Relates a person, such as an advisor or supervisor of thesis or dissertation research, overseeing either an academic degree or thesis to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeSupervisorOf</para>
    ///   <para>rdfs:label : is degree supervisor of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50091">rdaa:P50091</a>
    /// </summary>
    let P50091 = _prefixId.prefix "P50091"
    /// <summary>
    ///   <para>rdfs:label : is illuminator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illuminatorOf</para>
    ///   <para>skos:definition : Relates a person providing decoration to a specific item using precious metals or color, often with elaborate designs and motifs to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50092">rdaa:P50092</a>
    /// </summary>
    let P50092 = _prefixId.prefix "P50092"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : undifferentiated name indicator</para>
    ///   <para>skos:definition : Relates a person to a categorization indicating that the core elements recorded are insufficient to differentiate between two or more persons with the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A categorization indicating that the core elements recorded are insufficient to differentiate between two or more persons with the same name.</para>
    ///   <para>rdfs:label : has undifferentiated name indicator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : undifferentiatedNameIndicator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 8.11^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50093">rdaa:P50093</a>
    /// </summary>
    let P50093 = _prefixId.prefix "P50093"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.18^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : identifier for the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForThePerson</para>
    ///   <para>skos:scopeNote : The identifier serves to differentiate that person from other persons.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A character string uniquely associated with a person, or with a surrogate for a person (e.g., an authority record).</para>
    ///   <para>rdfs:label : has identifier for the person</para>
    ///   <para>skos:definition : Relates a person to a character string uniquely associated with a person, or with a surrogate for a person (e.g., an authority record).</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50094">rdaa:P50094</a>
    /// </summary>
    let P50094 = _prefixId.prefix "P50094"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : group member of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : groupMemberOf</para>
    ///   <para>skos:definition : Relates a person to a corporate body (performing group, expedition, etc.) of which the person is a member.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body (performing group, expedition, etc.) of which the person is a member.</para>
    ///   <para>rdfs:label : has group member of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50095">rdaa:P50095</a>
    /// </summary>
    let P50095 = _prefixId.prefix "P50095"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : employer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : employer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that employs the person.</para>
    ///   <para>skos:definition : Relates a person to a corporate body that employs the person.</para>
    ///   <para>rdfs:label : has employer</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50096">rdaa:P50096</a>
    /// </summary>
    let P50096 = _prefixId.prefix "P50096"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.1^^xsd:string</para>
    ///   <para>rdfs:label : has country associated with the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : countryAssociatedWithThePerson</para>
    ///   <para>skos:definition : Relates a person to a country with which a person is identified.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : country associated with the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A country with which a person is identified.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50097">rdaa:P50097</a>
    /// </summary>
    let P50097 = _prefixId.prefix "P50097"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a date or range of dates indicative of the period in which a person was active in his or her primary field of endeavour.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : periodOfActivityOfThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.3.4^^xsd:string</para>
    ///   <para>rdfs:label : has period of activity of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date or range of dates indicative of the period in which a person was active in his or her primary field of endeavour.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : period of activity of the person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50098">rdaa:P50098</a>
    /// </summary>
    let P50098 = _prefixId.prefix "P50098"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a family descended from the particular person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family descended from the particular person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : descendants</para>
    ///   <para>rdfs:label : has descendants</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descendants</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50099">rdaa:P50099</a>
    /// </summary>
    let P50099 = _prefixId.prefix "P50099"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a field of endeavour, area of expertise, etc., in which a person is engaged or was engaged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A field of endeavour, area of expertise, etc., in which a person is engaged or was engaged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fieldOfActivityOfThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.15^^xsd:string</para>
    ///   <para>rdfs:label : has field of activity of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : field of activity of the person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50100">rdaa:P50100</a>
    /// </summary>
    let P50100 = _prefixId.prefix "P50100"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : affiliation</para>
    ///   <para>rdfs:label : has affiliation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : affiliation</para>
    ///   <para>skos:definition : Relates a person to a group with which a person is affiliated or has been affiliated through employment, membership, cultural identity, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.13^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A group with which a person is affiliated or has been affiliated through employment, membership, cultural identity, etc.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50101">rdaa:P50101</a>
    /// </summary>
    let P50101 = _prefixId.prefix "P50101"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a language a person uses when writing for publication, broadcasting, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A language a person uses when writing for publication, broadcasting, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : language of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.14^^xsd:string</para>
    ///   <para>rdfs:label : has language of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfThePerson</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50102">rdaa:P50102</a>
    /// </summary>
    let P50102 = _prefixId.prefix "P50102"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : variant name for the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A name or form of name by which a person is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.2.3^^xsd:string</para>
    ///   <para>rdfs:label : has variant name for the person</para>
    ///   <para>skos:definition : Relates a person to a name or form of name by which a person is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForThePerson</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50103">rdaa:P50103</a>
    /// </summary>
    let P50103 = _prefixId.prefix "P50103"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : profession or occupation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : professionOrOccupation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.16^^xsd:string</para>
    ///   <para>skos:definition : Relates a person to a person's vocation or avocation.</para>
    ///   <para>rdfs:label : has profession or occupation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50104">rdaa:P50104</a>
    /// </summary>
    let P50104 = _prefixId.prefix "P50104"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : alternate identity</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternateIdentity</para>
    ///   <para>skos:definition : Relates a person to a pseudonymous or other identity assumed by the person.</para>
    ///   <para>rdfs:label : has alternate identity</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A pseudonymous or other identity assumed by the person.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50105">rdaa:P50105</a>
    /// </summary>
    let P50105 = _prefixId.prefix "P50105"
    /// <summary>
    ///   <para>rdfs:label : has real identity</para>
    ///   <para>skos:definition : Relates a person to a real person who assumes the alternate identity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : real identity</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : realIdentity</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A real person who assumes the alternate identity.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50106">rdaa:P50106</a>
    /// </summary>
    let P50106 = _prefixId.prefix "P50106"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date associated with the person</para>
    ///   <para>skos:definition : Relates a person to a significant date associated with a person (e.g., date of birth, date of death).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A significant date associated with a person (e.g., date of birth, date of death).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.3^^xsd:string</para>
    ///   <para>rdfs:label : has date associated with the person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50107">rdaa:P50107</a>
    /// </summary>
    let P50107 = _prefixId.prefix "P50107"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a term other than a title that is associated with a person's name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDesignationAssociatedWithThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other designation associated with the person</para>
    ///   <para>rdfs:label : has other designation associated with the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.6^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A term other than a title that is associated with a person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50108">rdaa:P50108</a>
    /// </summary>
    let P50108 = _prefixId.prefix "P50108"
    /// <summary>
    ///   <para>rdfs:label : has place of residence, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A town, city, province, state, and/or country in which a person resides or has resided, or another significant place associated with the person other than place of birth, place of death, or residence (e.g., a place where a person has worked or studied).</para>
    ///   <para>skos:definition : Relates a person to a town, city, province, state, and/or country in which a person resides or has resided, or another significant place associated with the person other than place of birth, place of death, or residence (e.g., a place where a person has worked or studied).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of residence, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfResidenceEtc</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.11^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50109">rdaa:P50109</a>
    /// </summary>
    let P50109 = _prefixId.prefix "P50109"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word or phrase indicative of royalty, nobility, ecclesiastical rank or office, or a term of address for a person of religious vocation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleOfThePerson</para>
    ///   <para>skos:scopeNote : Title of the person includes other terms indicative of rank, honour, or office, including initials and/or abbreviations representing an academic degree, or membership in an organization. Title of the person excludes terms of address that simply indicate gender or marital status (e.g., Mr., Mrs.).</para>
    ///   <para>rdfs:label : has title of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a person to a word or phrase indicative of royalty, nobility, ecclesiastical rank or office, or a term of address for a person of religious vocation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : title of the person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50110">rdaa:P50110</a>
    /// </summary>
    let P50110 = _prefixId.prefix "P50110"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a word, character, or group of words and/or characters by which a person is known.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : name of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.2^^xsd:string</para>
    ///   <para>rdfs:label : has name of the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A word, character, or group of words and/or characters by which a person is known.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50111">rdaa:P50111</a>
    /// </summary>
    let P50111 = _prefixId.prefix "P50111"
    /// <summary>
    ///   <para>skos:definition : Relates a person to an organization that the person founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An organization that the person founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundedCorporateBodyOfPerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : founded corporate body of person</para>
    ///   <para>rdfs:label : has founded corporate body of person</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50112">rdaa:P50112</a>
    /// </summary>
    let P50112 = _prefixId.prefix "P50112"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.17^^xsd:string</para>
    ///   <para>rdfs:label : has biographical information</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Information about the life or history of a person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : biographicalInformation</para>
    ///   <para>skos:definition : Relates a person to information about the life or history of a person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : biographical information</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50113">rdaa:P50113</a>
    /// </summary>
    let P50113 = _prefixId.prefix "P50113"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The address of a person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : address of the person</para>
    ///   <para>rdfs:label : has address of the person</para>
    ///   <para>skos:definition : Relates a person to the address of a person's place of residence, business, or employer, and/or an e-mail or internet address.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressOfThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.12^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50114">rdaa:P50114</a>
    /// </summary>
    let P50114 = _prefixId.prefix "P50114"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : fuller form of name</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The full form of a part of a name represented only by an initial or abbreviation in the form chosen as the preferred name, or a part of the name not included in the form chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fullerFormOfName</para>
    ///   <para>rdfs:label : has fuller form of name</para>
    ///   <para>skos:definition : Relates a person to the full form of a part of a name represented only by an initial or abbreviation in the form chosen as the preferred name, or a part of the name not included in the form chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50115">rdaa:P50115</a>
    /// </summary>
    let P50115 = _prefixId.prefix "P50115"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : gender</para>
    ///   <para>rdfs:label : has gender</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The gender with which a person identifies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : gender</para>
    ///   <para>skos:definition : Relates a person to the gender with which a person identifies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.7^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50116">rdaa:P50116</a>
    /// </summary>
    let P50116 = _prefixId.prefix "P50116"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.2.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForThePerson</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The name or form of name chosen to identify the person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preferred name for the person</para>
    ///   <para>rdfs:label : has preferred name for the person</para>
    ///   <para>skos:definition : Relates a person to the name or form of name chosen to identify the person.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50117">rdaa:P50117</a>
    /// </summary>
    let P50117 = _prefixId.prefix "P50117"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The town, city, province, state, and/or country in which a person died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDeath</para>
    ///   <para>rdfs:label : has place of death</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.9^^xsd:string</para>
    ///   <para>skos:definition : Relates a person to the town, city, province, state, and/or country in which a person died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of death</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50118">rdaa:P50118</a>
    /// </summary>
    let P50118 = _prefixId.prefix "P50118"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The town, city, province, state, and/or country in which a person was born.</para>
    ///   <para>skos:definition : Relates a person to the town, city, province, state, and/or country in which a person was born.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.8^^xsd:string</para>
    ///   <para>rdfs:label : has place of birth</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfBirth</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : place of birth</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50119">rdaa:P50119</a>
    /// </summary>
    let P50119 = _prefixId.prefix "P50119"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDeath</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.3.3^^xsd:string</para>
    ///   <para>rdfs:label : has date of death</para>
    ///   <para>skos:scopeNote : Date of death may also include the month or month and day of the person's death.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The year a person died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of death</para>
    ///   <para>skos:definition : Relates a person to the year a person died.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50120">rdaa:P50120</a>
    /// </summary>
    let P50120 = _prefixId.prefix "P50120"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the year a person was born.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The year a person was born.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 9.3.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfBirth</para>
    ///   <para>skos:scopeNote : Date of birth may also include the month or month and day of the person's birth.</para>
    ///   <para>rdfs:label : has date of birth</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : date of birth</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50121">rdaa:P50121</a>
    /// </summary>
    let P50121 = _prefixId.prefix "P50121"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantPersonOf</para>
    ///   <para>skos:definition : Relates a person who appeals the decision of a lower court recorded in a legal work of a higher court to the work.</para>
    ///   <para>rdfs:label : is appellant person of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50122">rdaa:P50122</a>
    /// </summary>
    let P50122 = _prefixId.prefix "P50122"
    /// <summary>
    ///   <para>rdfs:label : is binder of</para>
    ///   <para>skos:definition : Relates a person who binds an item to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : binderOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50123">rdaa:P50123</a>
    /// </summary>
    let P50123 = _prefixId.prefix "P50123"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffPersonOf</para>
    ///   <para>skos:definition : Relates a person who brings a suit in a civil proceeding to the work.</para>
    ///   <para>rdfs:label : is plaintiff person of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50124">rdaa:P50124</a>
    /// </summary>
    let P50124 = _prefixId.prefix "P50124"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inscriberOf</para>
    ///   <para>rdfs:label : is inscriber of</para>
    ///   <para>skos:definition : Relates a person who has written a statement of dedication or gift on an item to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50125">rdaa:P50125</a>
    /// </summary>
    let P50125 = _prefixId.prefix "P50125"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : judgeOf</para>
    ///   <para>rdfs:label : is judge of</para>
    ///   <para>skos:definition : Relates a person who hears and decides on legal matters in court to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50126">rdaa:P50126</a>
    /// </summary>
    let P50126 = _prefixId.prefix "P50126"
    /// <summary>
    ///   <para>skos:definition : Relates a person who is the faculty moderator of an academic disputation, normally proposing a thesis and participating in the ensuing disputation to the work.</para>
    ///   <para>rdfs:label : is praeses of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : praesesOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50127">rdaa:P50127</a>
    /// </summary>
    let P50127 = _prefixId.prefix "P50127"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : annotatorOf</para>
    ///   <para>skos:definition : Relates a person who makes manuscript annotations on an item to the item.</para>
    ///   <para>rdfs:label : is annotator of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50128">rdaa:P50128</a>
    /// </summary>
    let P50128 = _prefixId.prefix "P50128"
    /// <summary>
    ///   <para>skos:definition : Relates a person whose manuscript signature appears on an item to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : autographerOf</para>
    ///   <para>rdfs:label : is autographer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50129">rdaa:P50129</a>
    /// </summary>
    let P50129 = _prefixId.prefix "P50129"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body issuing a work, such as an official organ of the body to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuingBodyOf</para>
    ///   <para>rdfs:label : is issuing body of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50130">rdaa:P50130</a>
    /// </summary>
    let P50130 = _prefixId.prefix "P50130"
    /// <summary>
    ///   <para>skos:scopeNote : Includes persons, etc., to whom correspondence is addressed, persons, etc., honoured by a festschrift, directors, cinematographers, sponsoring bodies, production companies, institutions, etc., hosting an exhibition or event, etc</para>
    ///   <para>rdfs:label : is other person, family, or corporate body associated with a work of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPFCWorkOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body associated with a work other than as a creator to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50131">rdaa:P50131</a>
    /// </summary>
    let P50131 = _prefixId.prefix "P50131"
    /// <summary>
    ///   <para>rdfs:label : is dedicator of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body by whom a work is dedicated to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicatorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50132">rdaa:P50132</a>
    /// </summary>
    let P50132 = _prefixId.prefix "P50132"
    /// <summary>
    ///   <para>rdfs:label : is curator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : curatorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body conceiving, aggregating, and/or organizing an exhibition, collection, or other item to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50133">rdaa:P50133</a>
    /// </summary>
    let P50133 = _prefixId.prefix "P50133"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerExpressionOf</para>
    ///   <para>rdfs:label : is composer (expression) of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression by adding music to a work that originally lacked it, by composing new music to substitute for the original music, or by composing new music to supplement the existing music to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50134">rdaa:P50134</a>
    /// </summary>
    let P50134 = _prefixId.prefix "P50134"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a cartographic work by providing measurements or dimensional relationships for the geographic area represented to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : surveyorOf</para>
    ///   <para>rdfs:label : is surveyor of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50135">rdaa:P50135</a>
    /// </summary>
    let P50135 = _prefixId.prefix "P50135"
    /// <summary>
    ///   <para>rdfs:label : is animator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : animatorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a moving image work or computer program by giving apparent movement to inanimate objects or drawings to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50136">rdaa:P50136</a>
    /// </summary>
    let P50136 = _prefixId.prefix "P50136"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a musical work by rewriting the composition for a medium of performance different from that for which the work was originally intended to the expression.</para>
    ///   <para>skos:scopeNote : An arranger of music may also modify the work for the same medium of performance, etc., keeping the musical substance of the original composition essentially unchanged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangerOfMusicOf</para>
    ///   <para>rdfs:label : is arranger of music of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50137">rdaa:P50137</a>
    /// </summary>
    let P50137 = _prefixId.prefix "P50137"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedTextOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing supplementary textual content (e.g., an appendix, an introduction, a preface) to the original work to the expression.</para>
    ///   <para>rdfs:label : is writer of added text of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50138">rdaa:P50138</a>
    /// </summary>
    let P50138 = _prefixId.prefix "P50138"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a stage work through the general management and supervision of a performance to the expression.</para>
    ///   <para>rdfs:label : is stage director of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stageDirectorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50139">rdaa:P50139</a>
    /// </summary>
    let P50139 = _prefixId.prefix "P50139"
    /// <summary>
    ///   <para>rdfs:label : is interviewer (expression) of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewerExpressionOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by acting as an interviewer, reporter, pollster, or some other information gathering agent to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50140">rdaa:P50140</a>
    /// </summary>
    let P50140 = _prefixId.prefix "P50140"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by an architect, inventor, etc., by making detailed plans or drawings for buildings, ships, aircraft, machines, objects, etc. to the expression.</para>
    ///   <para>rdfs:label : is draftsman of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : draftsmanOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50141">rdaa:P50141</a>
    /// </summary>
    let P50141 = _prefixId.prefix "P50141"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transcriberOf</para>
    ///   <para>rdfs:label : is transcriber of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by writing down or notating previously unwritten or unnotated content, or by changing it from one system of notation to another to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50142">rdaa:P50142</a>
    /// </summary>
    let P50142 = _prefixId.prefix "P50142"
    /// <summary>
    ///   <para>rdfs:label : is musical director of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by coordinating the activities of the composer, the sound editor, and sound mixers for a moving image production or for a musical or dramatic presentation or entertainment to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalDirectorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50143">rdaa:P50143</a>
    /// </summary>
    let P50143 = _prefixId.prefix "P50143"
    /// <summary>
    ///   <para>rdfs:label : is costume designer of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by designing the costumes for a moving image production or for a musical or dramatic presentation or entertainment to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : costumeDesignerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50144">rdaa:P50144</a>
    /// </summary>
    let P50144 = _prefixId.prefix "P50144"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by expressing the linguistic content of the work in a language different from that of previous expressions of the original work to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatorOf</para>
    ///   <para>skos:scopeNote : A translator may also translate linguistic content between forms of the same language from different time periods.</para>
    ///   <para>rdfs:label : is translator of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50145">rdaa:P50145</a>
    /// </summary>
    let P50145 = _prefixId.prefix "P50145"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by overseeing the artists and craftspeople who build the sets for moving image productions to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artDirectorOf</para>
    ///   <para>rdfs:label : is art director of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50146">rdaa:P50146</a>
    /// </summary>
    let P50146 = _prefixId.prefix "P50146"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by performing music, acting, dancing, speaking, etc. to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performerOf</para>
    ///   <para>rdfs:label : is performer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50147">rdaa:P50147</a>
    /// </summary>
    let P50147 = _prefixId.prefix "P50147"
    /// <summary>
    ///   <para>rdfs:label : is court reporter of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtReporterOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by preparing a court's opinions for publication to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50148">rdaa:P50148</a>
    /// </summary>
    let P50148 = _prefixId.prefix "P50148"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing a preface to the original work to the expression.</para>
    ///   <para>rdfs:label : is writer of preface of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPrefaceOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50149">rdaa:P50149</a>
    /// </summary>
    let P50149 = _prefixId.prefix "P50149"
    /// <summary>
    ///   <para>rdfs:label : is cartographer (expression) of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographerExpressionOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing additional cartography, or by modifying the previous cartography to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50150">rdaa:P50150</a>
    /// </summary>
    let P50150 = _prefixId.prefix "P50150"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographerExpressionOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing additional choreography, or by modifying the previous choreography to the expression.</para>
    ///   <para>rdfs:label : is choreographer (expression) of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50151">rdaa:P50151</a>
    /// </summary>
    let P50151 = _prefixId.prefix "P50151"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedCommentaryOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing an interpretation or critical explanation of the original work to the expression.</para>
    ///   <para>rdfs:label : is writer of added commentary of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50152">rdaa:P50152</a>
    /// </summary>
    let P50152 = _prefixId.prefix "P50152"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing an introduction to the original work to the expression.</para>
    ///   <para>rdfs:label : is writer of introduction of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfIntroductionOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50153">rdaa:P50153</a>
    /// </summary>
    let P50153 = _prefixId.prefix "P50153"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfSupplementaryTextualContentOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing supplementary textual content (e.g., an appendix, an introduction, a preface) to the original work to the expression.</para>
    ///   <para>rdfs:label : is writer of supplementary textual content of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50154">rdaa:P50154</a>
    /// </summary>
    let P50154 = _prefixId.prefix "P50154"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intervieweeExpressionOf</para>
    ///   <para>rdfs:label : is interviewee (expression) of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50155">rdaa:P50155</a>
    /// </summary>
    let P50155 = _prefixId.prefix "P50155"
    /// <summary>
    ///   <para>rdfs:label : is editor of</para>
    ///   <para>skos:scopeNote : An editor may also prepare an expression of a work for production, publication, or distribution.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by revising or clarifying the content, , e.g., adding an introduction, notes, or other critical matter to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50156">rdaa:P50156</a>
    /// </summary>
    let P50156 = _prefixId.prefix "P50156"
    /// <summary>
    ///   <para>rdfs:label : is abridger of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by shortening or condensing the original work but leaving the nature and content of the original work substantially unchanged to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50157">rdaa:P50157</a>
    /// </summary>
    let P50157 = _prefixId.prefix "P50157"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingEngineerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by supervising the technical aspects of a sound or video recording session to the expression.</para>
    ///   <para>rdfs:label : is recording engineer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50158">rdaa:P50158</a>
    /// </summary>
    let P50158 = _prefixId.prefix "P50158"
    /// <summary>
    ///   <para>rdfs:label : is illustrator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustratorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by supplementing the primary content with drawings, diagrams, photographs, etc to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50159">rdaa:P50159</a>
    /// </summary>
    let P50159 = _prefixId.prefix "P50159"
    /// <summary>
    ///   <para>rdfs:label : is recordist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordistOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by using a recording device to capture sound and/or video during a recording session, including field recordings of natural sounds, folkloric events, music, etc to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50160">rdaa:P50160</a>
    /// </summary>
    let P50160 = _prefixId.prefix "P50160"
    /// <summary>
    ///   <para>skos:scopeNote : Contributors include editors, translators, arrangers of music, performers, etc.</para>
    ///   <para>rdfs:label : is contributor of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contributorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50161">rdaa:P50161</a>
    /// </summary>
    let P50161 = _prefixId.prefix "P50161"
    /// <summary>
    ///   <para>rdfs:label : is current owner of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : currentOwnerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body currently having legal possession of an item to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50162">rdaa:P50162</a>
    /// </summary>
    let P50162 = _prefixId.prefix "P50162"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formerOwnerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body formerly having legal possession of an item to the item.</para>
    ///   <para>rdfs:label : is former owner of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50163">rdaa:P50163</a>
    /// </summary>
    let P50163 = _prefixId.prefix "P50163"
    /// <summary>
    ///   <para>rdfs:label : is custodian of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body having legal custody of an item to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodianOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50164">rdaa:P50164</a>
    /// </summary>
    let P50164 = _prefixId.prefix "P50164"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body having legal possession of an item to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ownerOf</para>
    ///   <para>rdfs:label : is owner of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50165">rdaa:P50165</a>
    /// </summary>
    let P50165 = _prefixId.prefix "P50165"
    /// <summary>
    ///   <para>skos:altLabel : is honoree of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honoureeOf</para>
    ///   <para>rdfs:label : is honouree of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body honoured by a work (e.g., the honouree of a festschrift) to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50166">rdaa:P50166</a>
    /// </summary>
    let P50166 = _prefixId.prefix "P50166"
    /// <summary>
    ///   <para>rdfs:label : is honouree (item) of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body honoured by an item, e.g., a person to whom a copy is presented, to the item.</para>
    ///   <para>skos:altLabel : is honoree (item) of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honoureeOfItemOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50167">rdaa:P50167</a>
    /// </summary>
    let P50167 = _prefixId.prefix "P50167"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcasterOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in broadcasting a manifestation to an audience via radio, television, webcast, etc to the manifestation.</para>
    ///   <para>rdfs:label : is broadcaster of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50168">rdaa:P50168</a>
    /// </summary>
    let P50168 = _prefixId.prefix "P50168"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDistributorOf</para>
    ///   <para>rdfs:label : is film distributor of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in distributing a moving image manifestation to theatres or other distribution channels to the manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50169">rdaa:P50169</a>
    /// </summary>
    let P50169 = _prefixId.prefix "P50169"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookDesignerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used to the manifestation.</para>
    ///   <para>rdfs:label : is book designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50170">rdaa:P50170</a>
    /// </summary>
    let P50170 = _prefixId.prefix "P50170"
    /// <summary>
    ///   <para>rdfs:label : is engraver of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by cutting letters, figures, etc., on a surface such as a wooden or metal plate used for printing to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : engraverOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50171">rdaa:P50171</a>
    /// </summary>
    let P50171 = _prefixId.prefix "P50171"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by embossing braille cells using a stylus, special embossing printer, or other device to the manifestation.</para>
    ///   <para>rdfs:label : is braille embosser of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : brailleEmbosserOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50172">rdaa:P50172</a>
    /// </summary>
    let P50172 = _prefixId.prefix "P50172"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by making a relief, intaglio, or planographic printing surface to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printmakerOf</para>
    ///   <para>rdfs:label : is printmaker of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50173">rdaa:P50173</a>
    /// </summary>
    let P50173 = _prefixId.prefix "P50173"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : casterOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by pouring a liquid or molten substance into a mold and leaving it to solidify to take the shape of the mold to the manifestation.</para>
    ///   <para>rdfs:label : is caster of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50174">rdaa:P50174</a>
    /// </summary>
    let P50174 = _prefixId.prefix "P50174"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by preparing a stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lithographerOf</para>
    ///   <para>rdfs:label : is lithographer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50175">rdaa:P50175</a>
    /// </summary>
    let P50175 = _prefixId.prefix "P50175"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by preparing plates used in the production of printed images and/or text to the manifestation.</para>
    ///   <para>rdfs:label : is platemaker of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : platemakerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50176">rdaa:P50176</a>
    /// </summary>
    let P50176 = _prefixId.prefix "P50176"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation by subjecting metal, glass, or some other surface used for printing, to acid or another corrosive substance to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : etcherOf</para>
    ///   <para>rdfs:label : is etcher of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50177">rdaa:P50177</a>
    /// </summary>
    let P50177 = _prefixId.prefix "P50177"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation using a photomechanical process for making prints directly from a hardened film of gelatin or other colloid that has ink-receptive and ink-repellent surfaces to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collotyperOf</para>
    ///   <para>rdfs:label : is collotyper of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50178">rdaa:P50178</a>
    /// </summary>
    let P50178 = _prefixId.prefix "P50178"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc. to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printerOf</para>
    ///   <para>rdfs:label : is printer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50179">rdaa:P50179</a>
    /// </summary>
    let P50179 = _prefixId.prefix "P50179"
    /// <summary>
    ///   <para>rdfs:label : is presenter of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body mentioned in an "X presents" credit for moving image materials and who is probably associated with production, finance, or distribution in some way to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presenterOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50180">rdaa:P50180</a>
    /// </summary>
    let P50180 = _prefixId.prefix "P50180"
    /// <summary>
    ///   <para>skos:scopeNote : Includes book designers, platemakers, etc.</para>
    ///   <para>rdfs:label : is other person, family, or corporate body associated with a manifestation of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body other than a producer, publisher, distributor or manufacturer associated with a manifestation to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPFCManifestationOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50181">rdaa:P50181</a>
    /// </summary>
    let P50181 = _prefixId.prefix "P50181"
    /// <summary>
    ///   <para>rdfs:label : is other person, family, or corporate body associated with an item of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPFCItemOf</para>
    ///   <para>skos:scopeNote : Includes curators, binders, restorationists, etc.</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body other than an owner or custodian associated with an item to the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50182">rdaa:P50182</a>
    /// </summary>
    let P50182 = _prefixId.prefix "P50182"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfMovingImageWorkOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for assembling, arranging, and trimming film, video, or other moving image formats, including both visual and audio aspects to the expression.</para>
    ///   <para>rdfs:label : is editor of moving image work of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50183">rdaa:P50183</a>
    /// </summary>
    let P50183 = _prefixId.prefix "P50183"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : programmerOf</para>
    ///   <para>rdfs:label : is programmer of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a computer program to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50184">rdaa:P50184</a>
    /// </summary>
    let P50184 = _prefixId.prefix "P50184"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a design for an object to the work.</para>
    ///   <para>rdfs:label : is designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50185">rdaa:P50185</a>
    /// </summary>
    let P50185 = _prefixId.prefix "P50185"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a map, atlas, globe, or other cartographic work to the work.</para>
    ///   <para>rdfs:label : is cartographer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50186">rdaa:P50186</a>
    /// </summary>
    let P50186 = _prefixId.prefix "P50186"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a musical work to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOf</para>
    ///   <para>rdfs:label : is composer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50187">rdaa:P50187</a>
    /// </summary>
    let P50187 = _prefixId.prefix "P50187"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inventorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a new device or process to the work.</para>
    ///   <para>rdfs:label : is inventor of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50188">rdaa:P50188</a>
    /// </summary>
    let P50188 = _prefixId.prefix "P50188"
    /// <summary>
    ///   <para>rdfs:label : is compiler of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : compilerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a new work (e.g., a bibliography, a directory) by selecting, arranging, aggregating, and editing data, information, etc. to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50189">rdaa:P50189</a>
    /// </summary>
    let P50189 = _prefixId.prefix "P50189"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a photographic work to the work.</para>
    ///   <para>rdfs:label : is photographer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : photographerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50190">rdaa:P50190</a>
    /// </summary>
    let P50190 = _prefixId.prefix "P50190"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a work by acting as an interviewer, reporter, pollster, or some other information gathering agent to the work.</para>
    ///   <para>rdfs:label : is interviewer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50191">rdaa:P50191</a>
    /// </summary>
    let P50191 = _prefixId.prefix "P50191"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a work by conceiving, and often implementing, an original graphic design, drawing, painting, etc. to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artistOf</para>
    ///   <para>rdfs:label : is artist of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50192">rdaa:P50192</a>
    /// </summary>
    let P50192 = _prefixId.prefix "P50192"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intervieweeOf</para>
    ///   <para>rdfs:label : is interviewee of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50193">rdaa:P50193</a>
    /// </summary>
    let P50193 = _prefixId.prefix "P50193"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a work of movement to the work.</para>
    ///   <para>rdfs:label : is choreographer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50194">rdaa:P50194</a>
    /// </summary>
    let P50194 = _prefixId.prefix "P50194"
    /// <summary>
    ///   <para>rdfs:label : is author of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating a work that is primarily textual in content, regardless of media  type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs) to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : authorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50195">rdaa:P50195</a>
    /// </summary>
    let P50195 = _prefixId.prefix "P50195"
    /// <summary>
    ///   <para>rdfs:label : is architect of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : architectOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating an architectural design, including a pictorial representation intended to show how a building, etc. to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50196">rdaa:P50196</a>
    /// </summary>
    let P50196 = _prefixId.prefix "P50196"
    /// <summary>
    ///   <para>skos:scopeNote : A filmmaker is individually responsible for the conception and execution of all aspects of the film.</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for creating an independent or personal film to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmmakerOf</para>
    ///   <para>rdfs:label : is filmmaker of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50197">rdaa:P50197</a>
    /// </summary>
    let P50197 = _prefixId.prefix "P50197"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for designing the overall visual appearance of a moving image production to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionDesignerOf</para>
    ///   <para>rdfs:label : is production designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50198">rdaa:P50198</a>
    /// </summary>
    let P50198 = _prefixId.prefix "P50198"
    /// <summary>
    ///   <para>rdfs:label : is distributor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for distributing a resource to the manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50199">rdaa:P50199</a>
    /// </summary>
    let P50199 = _prefixId.prefix "P50199"
    /// <summary>
    ///   <para>rdfs:label : is producer of an unpublished resource of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for inscribing, fabricating, constructing, etc. to the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerOfAnUnpublishedResourceOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50200">rdaa:P50200</a>
    /// </summary>
    let P50200 = _prefixId.prefix "P50200"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for most of the business aspects of a production for screen, sound recording, television, webcast, etc to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerOf</para>
    ///   <para>skos:scopeNote : The producer is generally responsible for fund raising, managing the production, hiring key personnel, arranging for distributors, etc.</para>
    ///   <para>rdfs:label : is producer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50201">rdaa:P50201</a>
    /// </summary>
    let P50201 = _prefixId.prefix "P50201"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for printing, duplicating, casting, etc. to the manifestation.</para>
    ///   <para>rdfs:label : is manufacturer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturerOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50202">rdaa:P50202</a>
    /// </summary>
    let P50202 = _prefixId.prefix "P50202"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publisherOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for publishing, releasing, or issuing a resource to the manifestation.</para>
    ///   <para>rdfs:label : is publisher of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50203">rdaa:P50203</a>
    /// </summary>
    let P50203 = _prefixId.prefix "P50203"
    /// <summary>
    ///   <para>rdfs:label : is creator of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : creatorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for the creation of a work to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50204">rdaa:P50204</a>
    /// </summary>
    let P50204 = _prefixId.prefix "P50204"
    /// <summary>
    ///   <para>rdfs:label : is director of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for the general management and supervision of a filmed performance, a radio or television program, etc. to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50205">rdaa:P50205</a>
    /// </summary>
    let P50205 = _prefixId.prefix "P50205"
    /// <summary>
    ///   <para>rdfs:label : is restorationist of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restorationistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50206">rdaa:P50206</a>
    /// </summary>
    let P50206 = _prefixId.prefix "P50206"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOfPhotographyOf</para>
    ///   <para>rdfs:label : is director of photography of</para>
    ///   <para>skos:scopeNote : The director of photography for a movie is also called the chief cinematographer.</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body that captures images, either electronically or on film or video stock, and often selects and arranges the lighting to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50207">rdaa:P50207</a>
    /// </summary>
    let P50207 = _prefixId.prefix "P50207"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body to whom a work is dedicated to the work.</para>
    ///   <para>rdfs:label : is dedicatee of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicateeOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50208">rdaa:P50208</a>
    /// </summary>
    let P50208 = _prefixId.prefix "P50208"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addresseeOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body to whom a work or part of a work is addressed to the work.</para>
    ///   <para>rdfs:label : is addressee of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50209">rdaa:P50209</a>
    /// </summary>
    let P50209 = _prefixId.prefix "P50209"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body to whom an item is dedicated to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicateeOfItemOf</para>
    ///   <para>rdfs:label : is dedicatee (item) of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50210">rdaa:P50210</a>
    /// </summary>
    let P50210 = _prefixId.prefix "P50210"
    /// <summary>
    ///   <para>rdfs:label : is consultant of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body who provides consultation services, and often makes recommendations, for another person, family, or corporate body that is represented as the creator of a work to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : consultantOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50211">rdaa:P50211</a>
    /// </summary>
    let P50211 = _prefixId.prefix "P50211"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body, responsible for recording the minutes of a meeting to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : minuteTakerOf</para>
    ///   <para>rdfs:label : is minute taker of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50212">rdaa:P50212</a>
    /// </summary>
    let P50212 = _prefixId.prefix "P50212"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmProducerOf</para>
    ///   <para>skos:definition : Relates a producer responsible for most of the business aspects of a film to the work.</para>
    ///   <para>rdfs:label : is film producer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50213">rdaa:P50213</a>
    /// </summary>
    let P50213 = _prefixId.prefix "P50213"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProducerOf</para>
    ///   <para>skos:definition : Relates a producer responsible for most of the business aspects of a radio program to the work.</para>
    ///   <para>rdfs:label : is radio producer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50214">rdaa:P50214</a>
    /// </summary>
    let P50214 = _prefixId.prefix "P50214"
    /// <summary>
    ///   <para>rdfs:label : is television producer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProducerOf</para>
    ///   <para>skos:definition : Relates a producer responsible for most of the business aspects of a television program to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50215">rdaa:P50215</a>
    /// </summary>
    let P50215 = _prefixId.prefix "P50215"
    /// <summary>
    ///   <para>rdfs:label : is writer of added lyrics of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedLyricsOf</para>
    ///   <para>skos:definition : Relates a writer of words added to an expression of a musical work to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50216">rdaa:P50216</a>
    /// </summary>
    let P50216 = _prefixId.prefix "P50216"
    /// <summary>
    ///   <para>skos:definition : Relates an actor contributing to an expression of a work by providing the voice for characters in radio and audio productions and for animated characters in moving image works, as well as by providing voice-overs in radio and television commercials, dubbed resources, etc to the expression.</para>
    ///   <para>rdfs:label : is voice actor of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : voiceActorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50217">rdaa:P50217</a>
    /// </summary>
    let P50217 = _prefixId.prefix "P50217"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 32.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that is associated with the person, family, or corporate body being identified (e.g., a musical group to which a person belongs, a subsidiary company).</para>
    ///   <para>skos:definition : Relates an agent to a corporate body that is associated with the person, family, or corporate body being identified (e.g., a musical group to which a person belongs, a subsidiary company).</para>
    ///   <para>rdfs:label : has related corporate body</para>
    ///   <para>skos:scopeNote : Related corporate bodies include corporate bodies that precede or succeed the corporate body being identified as the result of a change of name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50218">rdaa:P50218</a>
    /// </summary>
    let P50218 = _prefixId.prefix "P50218"
    /// <summary>
    ///   <para>rdfs:label : has related family</para>
    ///   <para>skos:definition : Relates an agent to a family that is associated with the person, family, or corporate body being identified (e.g., a person's family, a family that owns the controlling interest in a corporate body).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 31.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family that is associated with the person, family, or corporate body being identified (e.g., a person's family, a family that owns the controlling interest in a corporate body).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedFamily</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50219">rdaa:P50219</a>
    /// </summary>
    let P50219 = _prefixId.prefix "P50219"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedPerson</para>
    ///   <para>rdfs:label : has related person</para>
    ///   <para>skos:definition : Relates an agent to a person who is associated with the person, family, or corporate body being identified (e.g., a collaborator, a member of a family, a founder of a corporate body).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related person</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 30.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who is associated with the person, family, or corporate body being identified (e.g., a collaborator, a member of a family, a founder of a corporate body).</para>
    ///   <para>skos:scopeNote : Related persons include separate identities established by an individual (either alone or in collaboration with one or more other individuals).</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50220">rdaa:P50220</a>
    /// </summary>
    let P50220 = _prefixId.prefix "P50220"
    /// <summary>
    ///   <para>skos:definition : Relates an architect responsible for creating landscape works to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : landscapeArchitectOf</para>
    ///   <para>rdfs:label : is landscape architect of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50221">rdaa:P50221</a>
    /// </summary>
    let P50221 = _prefixId.prefix "P50221"
    /// <summary>
    ///   <para>rdfs:label : is sculptor of</para>
    ///   <para>skos:definition : Relates an artist responsible for creating a three-dimensional work by modeling, carving, or similar technique to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sculptorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50222">rdaa:P50222</a>
    /// </summary>
    let P50222 = _prefixId.prefix "P50222"
    /// <summary>
    ///   <para>skos:definition : Relates an author of a screenplay, script, or scene to the work.</para>
    ///   <para>rdfs:label : is screenwriter of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenwriterOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50223">rdaa:P50223</a>
    /// </summary>
    let P50223 = _prefixId.prefix "P50223"
    /// <summary>
    ///   <para>skos:definition : Relates an author of the words of a popular song, including a song or songs from a musical to the work.</para>
    ///   <para>rdfs:label : is lyricist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lyricistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50224">rdaa:P50224</a>
    /// </summary>
    let P50224 = _prefixId.prefix "P50224"
    /// <summary>
    ///   <para>rdfs:label : is librettist of</para>
    ///   <para>skos:definition : Relates an author of the words of an opera or other musical stage work, or an oratorio to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50225">rdaa:P50225</a>
    /// </summary>
    let P50225 = _prefixId.prefix "P50225"
    /// <summary>
    ///   <para>rdfs:label : is sponsoring body of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringBodyOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body sponsoring some aspect of a work, e.g., funding research, sponsoring an event, to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50226">rdaa:P50226</a>
    /// </summary>
    let P50226 = _prefixId.prefix "P50226"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing an afterword to the original work to the expression.</para>
    ///   <para>rdfs:label : is writer of afterword of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAfterwordOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50227">rdaa:P50227</a>
    /// </summary>
    let P50227 = _prefixId.prefix "P50227"
    /// <summary>
    ///   <para>rdfs:label : is writer of postface of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing a postface to the original work to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfPostfaceOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50228">rdaa:P50228</a>
    /// </summary>
    let P50228 = _prefixId.prefix "P50228"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that split or divided into the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that split or divided into the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : predecessorOfSplit</para>
    ///   <para>rdfs:label : has predecessor of split</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : predecessor of split</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50229">rdaa:P50229</a>
    /// </summary>
    let P50229 = _prefixId.prefix "P50229"
    /// <summary>
    ///   <para>rdfs:label : has membership corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body formed from the membership of other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : membership corporate body</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body formed from the membership of other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : membershipCorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50230">rdaa:P50230</a>
    /// </summary>
    let P50230 = _prefixId.prefix "P50230"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that is a member of the other corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : corporateMember</para>
    ///   <para>rdfs:label : has corporate member</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : corporate member</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that is a member of the other corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50231">rdaa:P50231</a>
    /// </summary>
    let P50231 = _prefixId.prefix "P50231"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that formed the other corporate body by merging with one or more other corporate bodies.</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that formed the other corporate body by merging with one or more other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : component of merger</para>
    ///   <para>rdfs:label : has component of merger</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : componentOfAMerger</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50232">rdaa:P50232</a>
    /// </summary>
    let P50232 = _prefixId.prefix "P50232"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : family</para>
    ///   <para>skos:definition : Relates a person to a family to which the person belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A family to which the person belongs.</para>
    ///   <para>rdfs:label : has family</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50233">rdaa:P50233</a>
    /// </summary>
    let P50233 = _prefixId.prefix "P50233"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a corporate body in which the person holds an office.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : officiatedCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : officiated corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body in which the person holds an office.</para>
    ///   <para>rdfs:label : has officiated corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50234">rdaa:P50234</a>
    /// </summary>
    let P50234 = _prefixId.prefix "P50234"
    /// <summary>
    ///   <para>skos:definition : Relates a family to a language a family uses in its communications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheFamily</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A language a family uses in its communications.</para>
    ///   <para>rdfs:label : has language of the family</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 10.8^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : language of the family</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50235">rdaa:P50235</a>
    /// </summary>
    let P50235 = _prefixId.prefix "P50235"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.4.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : period of activity of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A date or range of dates indicative of the period in which a corporate body was active.</para>
    ///   <para>skos:definition : Relates a corporate body to a date or range of dates indicative of the period in which a corporate body was active.</para>
    ///   <para>rdfs:label : has period of activity of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : periodOfActivityOfTheCorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50236">rdaa:P50236</a>
    /// </summary>
    let P50236 = _prefixId.prefix "P50236"
    /// <summary>
    ///   <para>rdfs:label : has type of corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : type of corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.7.1.4^^xsd:string</para>
    ///   <para>skos:definition : Relates a corporate body to the type of corporate body.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50237">rdaa:P50237</a>
    /// </summary>
    let P50237 = _prefixId.prefix "P50237"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : type of jurisdiction</para>
    ///   <para>skos:definition : Relates a corporate body to the type of jurisdiction.</para>
    ///   <para>rdfs:label : has type of jurisdiction</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.7.1.5^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfJurisdiction</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50238">rdaa:P50238</a>
    /// </summary>
    let P50238 = _prefixId.prefix "P50238"
    /// <summary>
    ///   <para>rdfs:label : has other designation</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other designation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDesignation</para>
    ///   <para>skos:definition : Relates a corporate body to the other designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.7.1.6^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50239">rdaa:P50239</a>
    /// </summary>
    let P50239 = _prefixId.prefix "P50239"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : broader affiliated body</para>
    ///   <para>rdfs:label : has broader affiliated body</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A corporate body that acts for the local affiliated body and others at a broader organizational level.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broaderAffiliatedBody</para>
    ///   <para>skos:definition : Relates a corporate body to a corporate body that acts for the local affiliated body and others at a broader organizational level.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50240">rdaa:P50240</a>
    /// </summary>
    let P50240 = _prefixId.prefix "P50240"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a local corporate body affiliated with the broader body which acts for it and others at a broader organizational level.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : localAffiliate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A local corporate body affiliated with the broader body which acts for it and others at a broader organizational level.</para>
    ///   <para>rdfs:label : has local affiliate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : local affiliate</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50241">rdaa:P50241</a>
    /// </summary>
    let P50241 = _prefixId.prefix "P50241"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : papermakerOf</para>
    ///   <para>rdfs:label : is papermaker of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for the production of paper used to manufacture a manifestation to the manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50242">rdaa:P50242</a>
    /// </summary>
    let P50242 = _prefixId.prefix "P50242"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : visualEffectsProviderOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a moving image work by designing and creating post-production visual effects to the expression.</para>
    ///   <para>rdfs:label : is visual effects provider of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50243">rdaa:P50243</a>
    /// </summary>
    let P50243 = _prefixId.prefix "P50243"
    /// <summary>
    ///   <para>rdfs:label : is special effects provider of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a moving image or audio work by designing and creating on-set special effects (on-set mechanical effects and in-camera optical effects) to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialEffectsProviderOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50244">rdaa:P50244</a>
    /// </summary>
    let P50244 = _prefixId.prefix "P50244"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lettererOf</para>
    ///   <para>rdfs:label : is letterer of</para>
    ///   <para>skos:definition : Relates an illustrator contributing to an expression of a comic book, graphic novel, etc. to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50245">rdaa:P50245</a>
    /// </summary>
    let P50245 = _prefixId.prefix "P50245"
    /// <summary>
    ///   <para>rdfs:label : is calligrapher of</para>
    ///   <para>skos:definition : Relates an artist responsible for creating a work of calligraphy where the focus of interest lies in the aesthetic value of its penmanship or graphic artistry, regardless of whether the same person, etc to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : calligrapherOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50246">rdaa:P50246</a>
    /// </summary>
    let P50246 = _prefixId.prefix "P50246"
    /// <summary>
    ///   <para>rdfs:label : is book artist of</para>
    ///   <para>skos:definition : Relates an artist resonsible for creating art works that exploit the book form or alter its physical structure as part of the content of the work to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookArtistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50247">rdaa:P50247</a>
    /// </summary>
    let P50247 = _prefixId.prefix "P50247"
    /// <summary>
    ///   <para>skos:definition : Relates an author who is appointed by an organization to report on the proceedings of its meetings to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rapporteurOf</para>
    ///   <para>rdfs:label : is rapporteur of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50248">rdaa:P50248</a>
    /// </summary>
    let P50248 = _prefixId.prefix "P50248"
    /// <summary>
    ///   <para>rdfs:label : is subject of (person)</para>
    ///   <para>skos:definition : Relates a person to a work that is about the person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOfPerson</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50249">rdaa:P50249</a>
    /// </summary>
    let P50249 = _prefixId.prefix "P50249"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOfFamily</para>
    ///   <para>skos:definition : Relates a family to a work that is about the family.</para>
    ///   <para>rdfs:label : is subject of (family)</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50250">rdaa:P50250</a>
    /// </summary>
    let P50250 = _prefixId.prefix "P50250"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a work that is about the corporate body.</para>
    ///   <para>rdfs:label : is subject of (corporate body)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOfCorporateBody</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50251">rdaa:P50251</a>
    /// </summary>
    let P50251 = _prefixId.prefix "P50251"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a person who receives an academic degree from the granting institution or faculty.</para>
    ///   <para>rdfs:label : has graduate</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : graduate</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who receives an academic degree from the granting institution or faculty.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : graduate</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50252">rdaa:P50252</a>
    /// </summary>
    let P50252 = _prefixId.prefix "P50252"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : graduate of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : graduateOf</para>
    ///   <para>skos:definition : Relates a person to an institution or faculty that granted an academic degree to the person.</para>
    ///   <para>rdfs:label : is graduate of</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An institution or faculty that granted an academic degree to the person.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50253">rdaa:P50253</a>
    /// </summary>
    let P50253 = _prefixId.prefix "P50253"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by providing a foreword to the original work to an expression.</para>
    ///   <para>rdfs:label : is writer of foreword of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfForewordOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50254">rdaa:P50254</a>
    /// </summary>
    let P50254 = _prefixId.prefix "P50254"
    /// <summary>
    ///   <para>rdfs:label : is sound designer of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundDesignerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by designing and creating audio/sound components to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50255">rdaa:P50255</a>
    /// </summary>
    let P50255 = _prefixId.prefix "P50255"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lightingDesignerOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by designing and creating lighting components to the expression.</para>
    ///   <para>rdfs:label : is lighting designer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50256">rdaa:P50256</a>
    /// </summary>
    let P50256 = _prefixId.prefix "P50256"
    /// <summary>
    ///   <para>rdfs:label : is degree committee member of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeCommitteeMemberOf</para>
    ///   <para>skos:definition : Relates a person serving on a committee that supervises a student's thesis or dissertation to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50257">rdaa:P50257</a>
    /// </summary>
    let P50257 = _prefixId.prefix "P50257"
    /// <summary>
    ///   <para>rdfs:label : is defendant corporate body of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantCorporateBodyOf</para>
    ///   <para>skos:definition : Relates a corporate body who is accused in a criminal proceeding or sued in a civil proceeding to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50258">rdaa:P50258</a>
    /// </summary>
    let P50258 = _prefixId.prefix "P50258"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantPersonOf</para>
    ///   <para>rdfs:label : is defendant person of</para>
    ///   <para>skos:definition : Relates a person who is accused in a criminal proceeding or sued in a civil proceeding to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50259">rdaa:P50259</a>
    /// </summary>
    let P50259 = _prefixId.prefix "P50259"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 11.3.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPlaceAssociatedWithTheCorporateBody</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A place associated with a corporate body other than location of a conference, etc.</para>
    ///   <para>skos:definition : Relates a corporate body to a place associated with a corporate body other than location of a conference, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other place associated with the corporate body</para>
    ///   <para>rdfs:label : has other place associated with the corporate body</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50260">rdaa:P50260</a>
    /// </summary>
    let P50260 = _prefixId.prefix "P50260"
    /// <summary>
    ///   <para>rdfs:label : is on-screen participant of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onscreenParticipantOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a nonfiction moving image work by taking an active role as a participant to the expression.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50261">rdaa:P50261</a>
    /// </summary>
    let P50261 = _prefixId.prefix "P50261"
    /// <summary>
    ///   <para>rdfs:label : is commissioning body of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commissioningBodyOf</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body responsible for commissioning a work to the work.</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50262">rdaa:P50262</a>
    /// </summary>
    let P50262 = _prefixId.prefix "P50262"
    /// <summary>
    ///   <para>rdfs:label : is software developer of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by researching, designing, implementing, or testing the software to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : softwareDeveloperOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50263">rdaa:P50263</a>
    /// </summary>
    let P50263 = _prefixId.prefix "P50263"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : participantInATreatyOf</para>
    ///   <para>skos:definition : Relates a government, international intergovernmental body, or other corporate body that has signed, ratified, or acceded to a treaty to the work.</para>
    ///   <para>rdfs:label : is participant in a treaty of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50264">rdaa:P50264</a>
    /// </summary>
    let P50264 = _prefixId.prefix "P50264"
    /// <summary>
    ///   <para>rdfs:label : is researcher of</para>
    ///   <para>skos:definition : Relates a person, family, or corporate body who does research in support of the creation of a work to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : researcherOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50265">rdaa:P50265</a>
    /// </summary>
    let P50265 = _prefixId.prefix "P50265"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by applying colour to drawings, prints, photographs, maps, moving images, etc. to the expression.</para>
    ///   <para>rdfs:label : is colourist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colouristOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50266">rdaa:P50266</a>
    /// </summary>
    let P50266 = _prefixId.prefix "P50266"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body contributing to an expression of a work by applying make-up and prosthetics for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <para>rdfs:label : is make-up artist of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : makeUpArtistOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50267">rdaa:P50267</a>
    /// </summary>
    let P50267 = _prefixId.prefix "P50267"
    /// <summary>
    ///   <para>skos:definition : Relates a conductor contributing to an expression of a musical work by leading a choral performing group in a musical or dramatic presentation, etc. to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choralConductorOf</para>
    ///   <para>rdfs:label : is choral conductor of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50268">rdaa:P50268</a>
    /// </summary>
    let P50268 = _prefixId.prefix "P50268"
    /// <summary>
    ///   <para>rdfs:label : is instrumental conductor of</para>
    ///   <para>skos:definition : Relates a conductor contributing to an expression of a musical work by leading an instrumental performing group in a musical or dramatic presentation, etc. to the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalConductorOf</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50269">rdaa:P50269</a>
    /// </summary>
    let P50269 = _prefixId.prefix "P50269"
    /// <summary>
    ///   <para>skos:definition : Relates a person, family, or corporate body organizing the exhibit, event, conference, etc., which gave rise to a work to the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : organizerOf</para>
    ///   <para>rdfs:label : is organizer of</para>
    ///   <a href="http://rdaregistry.info/Elements/a/P50270">rdaa:P50270</a>
    /// </summary>
    let P50270 = _prefixId.prefix "P50270"
    let ``abridgerOf.en`` = _prefixId.prefix "abridgerOf.en"
    let ``actorOf.en`` = _prefixId.prefix "actorOf.en"

    let ``addressOfTheCorporateBody.en`` =
        _prefixId.prefix "addressOfTheCorporateBody.en"

    let ``addressOfThePerson.en`` = _prefixId.prefix "addressOfThePerson.en"
    let ``addresseeOf.en`` = _prefixId.prefix "addresseeOf.en"
    let ``affiliation.en`` = _prefixId.prefix "affiliation.en"
    let ``alternateIdentity.en`` = _prefixId.prefix "alternateIdentity.en"
    let ``animatorOf.en`` = _prefixId.prefix "animatorOf.en"
    let ``annotatorOf.en`` = _prefixId.prefix "annotatorOf.en"
    let ``appellantCorporateBodyOf.en`` = _prefixId.prefix "appellantCorporateBodyOf.en"
    let ``appellantOf.en`` = _prefixId.prefix "appellantOf.en"
    let ``appellantPersonOf.en`` = _prefixId.prefix "appellantPersonOf.en"
    let ``appelleeCorporateBodyOf.en`` = _prefixId.prefix "appelleeCorporateBodyOf.en"
    let ``appelleeOf.en`` = _prefixId.prefix "appelleeOf.en"
    let ``appelleePersonOf.en`` = _prefixId.prefix "appelleePersonOf.en"
    let ``architectOf.en`` = _prefixId.prefix "architectOf.en"
    let ``arrangerOfMusicOf.en`` = _prefixId.prefix "arrangerOfMusicOf.en"
    let ``artDirectorOf.en`` = _prefixId.prefix "artDirectorOf.en"
    let ``artistOf.en`` = _prefixId.prefix "artistOf.en"
    let ``associatedInstitution.en`` = _prefixId.prefix "associatedInstitution.en"
    let ``authorOf.en`` = _prefixId.prefix "authorOf.en"
    let ``autographerOf.en`` = _prefixId.prefix "autographerOf.en"
    let ``binderOf.en`` = _prefixId.prefix "binderOf.en"
    let ``biographicalInformation.en`` = _prefixId.prefix "biographicalInformation.en"
    let ``bookArtistOf.en`` = _prefixId.prefix "bookArtistOf.en"
    let ``bookDesignerOf.en`` = _prefixId.prefix "bookDesignerOf.en"
    let ``brailleEmbosserOf.en`` = _prefixId.prefix "brailleEmbosserOf.en"
    let ``broadcasterOf.en`` = _prefixId.prefix "broadcasterOf.en"
    let ``broaderAffiliatedBody.en`` = _prefixId.prefix "broaderAffiliatedBody.en"
    let ``calligrapherOf.en`` = _prefixId.prefix "calligrapherOf.en"
    let ``cartographerExpressionOf.en`` = _prefixId.prefix "cartographerExpressionOf.en"
    let ``cartographerOf.en`` = _prefixId.prefix "cartographerOf.en"
    let ``casterOf.en`` = _prefixId.prefix "casterOf.en"
    let ``choralConductorOf.en`` = _prefixId.prefix "choralConductorOf.en"

    let ``choreographerExpressionOf.en`` =
        _prefixId.prefix "choreographerExpressionOf.en"

    let ``choreographerOf.en`` = _prefixId.prefix "choreographerOf.en"
    let ``collectionRegistrarOf.en`` = _prefixId.prefix "collectionRegistrarOf.en"
    let ``collectorOf.en`` = _prefixId.prefix "collectorOf.en"
    let ``collotyperOf.en`` = _prefixId.prefix "collotyperOf.en"
    let ``colouristOf.en`` = _prefixId.prefix "colouristOf.en"
    let ``commentatorOf.en`` = _prefixId.prefix "commentatorOf.en"
    let ``commissioningBodyOf.en`` = _prefixId.prefix "commissioningBodyOf.en"
    let ``compilerOf.en`` = _prefixId.prefix "compilerOf.en"
    let ``componentOfMerger.en`` = _prefixId.prefix "componentOfMerger.en"
    let ``composerExpressionOf.en`` = _prefixId.prefix "composerExpressionOf.en"
    let ``composerOf.en`` = _prefixId.prefix "composerOf.en"
    let ``conductorOf.en`` = _prefixId.prefix "conductorOf.en"
    let ``consultantOf.en`` = _prefixId.prefix "consultantOf.en"
    let ``contributorOf.en`` = _prefixId.prefix "contributorOf.en"
    let ``corporateHistory.en`` = _prefixId.prefix "corporateHistory.en"
    let ``corporateMember.en`` = _prefixId.prefix "corporateMember.en"
    let ``costumeDesignerOf.en`` = _prefixId.prefix "costumeDesignerOf.en"

    let ``countryAssociatedWithThePerson.en`` =
        _prefixId.prefix "countryAssociatedWithThePerson.en"

    let ``courtGovernedOf.en`` = _prefixId.prefix "courtGovernedOf.en"
    let ``courtReporterOf.en`` = _prefixId.prefix "courtReporterOf.en"
    let ``creatorOf.en`` = _prefixId.prefix "creatorOf.en"
    let ``curatorOf.en`` = _prefixId.prefix "curatorOf.en"
    let ``currentOwnerOf.en`` = _prefixId.prefix "currentOwnerOf.en"
    let ``custodianOf.en`` = _prefixId.prefix "custodianOf.en"
    let ``dancerOf.en`` = _prefixId.prefix "dancerOf.en"

    let ``dateAssociatedWithTheCorporateBody.en`` =
        _prefixId.prefix "dateAssociatedWithTheCorporateBody.en"

    let ``dateAssociatedWithTheFamily.en`` =
        _prefixId.prefix "dateAssociatedWithTheFamily.en"

    let ``dateAssociatedWithThePerson.en`` =
        _prefixId.prefix "dateAssociatedWithThePerson.en"

    let ``dateOfBirth.en`` = _prefixId.prefix "dateOfBirth.en"
    let ``dateOfConferenceEtc.en`` = _prefixId.prefix "dateOfConferenceEtc.en"
    let ``dateOfDeath.en`` = _prefixId.prefix "dateOfDeath.en"
    let ``dateOfEstablishment.en`` = _prefixId.prefix "dateOfEstablishment.en"
    let ``dateOfTermination.en`` = _prefixId.prefix "dateOfTermination.en"
    let ``dedicateeOf.en`` = _prefixId.prefix "dedicateeOf.en"
    let ``dedicateeOfItemOf.en`` = _prefixId.prefix "dedicateeOfItemOf.en"
    let ``dedicatorOf.en`` = _prefixId.prefix "dedicatorOf.en"
    let ``defendantCorporateBodyOf.en`` = _prefixId.prefix "defendantCorporateBodyOf.en"
    let ``defendantOf.en`` = _prefixId.prefix "defendantOf.en"
    let ``defendantPersonOf.en`` = _prefixId.prefix "defendantPersonOf.en"
    let ``degreeCommitteeMemberOf.en`` = _prefixId.prefix "degreeCommitteeMemberOf.en"

    let ``degreeGrantingInstitutionOf.en`` =
        _prefixId.prefix "degreeGrantingInstitutionOf.en"

    let ``degreeSupervisorOf.en`` = _prefixId.prefix "degreeSupervisorOf.en"
    let ``depositorOf.en`` = _prefixId.prefix "depositorOf.en"
    let ``descendantFamily.en`` = _prefixId.prefix "descendantFamily.en"
    let ``descendants.en`` = _prefixId.prefix "descendants.en"
    let ``designerOf.en`` = _prefixId.prefix "designerOf.en"
    let ``directorOf.en`` = _prefixId.prefix "directorOf.en"
    let ``directorOfPhotographyOf.en`` = _prefixId.prefix "directorOfPhotographyOf.en"
    let ``distributorOf.en`` = _prefixId.prefix "distributorOf.en"
    let ``donorOf.en`` = _prefixId.prefix "donorOf.en"
    let ``draftsmanOf.en`` = _prefixId.prefix "draftsmanOf.en"
    let ``editorOf.en`` = _prefixId.prefix "editorOf.en"

    let ``editorOfMovingImageWorkOf.en`` =
        _prefixId.prefix "editorOfMovingImageWorkOf.en"

    let ``employee.en`` = _prefixId.prefix "employee.en"
    let ``employer.en`` = _prefixId.prefix "employer.en"
    let ``enactingJurisdictionOf.en`` = _prefixId.prefix "enactingJurisdictionOf.en"
    let ``engraverOf.en`` = _prefixId.prefix "engraverOf.en"
    let ``etcherOf.en`` = _prefixId.prefix "etcherOf.en"
    let ``family.en`` = _prefixId.prefix "family.en"
    let ``familyHistory.en`` = _prefixId.prefix "familyHistory.en"
    let ``familyMember.en`` = _prefixId.prefix "familyMember.en"

    let ``fieldOfActivityOfTheCorporateBody.en`` =
        _prefixId.prefix "fieldOfActivityOfTheCorporateBody.en"

    let ``fieldOfActivityOfThePerson.en`` =
        _prefixId.prefix "fieldOfActivityOfThePerson.en"

    let ``filmDirectorOf.en`` = _prefixId.prefix "filmDirectorOf.en"
    let ``filmDistributorOf.en`` = _prefixId.prefix "filmDistributorOf.en"
    let ``filmProducerOf.en`` = _prefixId.prefix "filmProducerOf.en"
    let ``filmmakerOf.en`` = _prefixId.prefix "filmmakerOf.en"
    let ``formerOwnerOf.en`` = _prefixId.prefix "formerOwnerOf.en"

    let ``foundedCorporateBodyOfCorporateBody.en`` =
        _prefixId.prefix "foundedCorporateBodyOfCorporateBody.en"

    let ``foundedCorporateBodyOfFamily.en`` =
        _prefixId.prefix "foundedCorporateBodyOfFamily.en"

    let ``foundedCorporateBodyOfPerson.en`` =
        _prefixId.prefix "foundedCorporateBodyOfPerson.en"

    let ``founder.en`` = _prefixId.prefix "founder.en"
    let ``foundingCorporateBody.en`` = _prefixId.prefix "foundingCorporateBody.en"
    let ``foundingFamily.en`` = _prefixId.prefix "foundingFamily.en"
    let ``fullerFormOfName.en`` = _prefixId.prefix "fullerFormOfName.en"
    let ``gender.en`` = _prefixId.prefix "gender.en"
    let ``graduate.en`` = _prefixId.prefix "graduate.en"
    let ``graduateOf.en`` = _prefixId.prefix "graduateOf.en"
    let ``groupMember.en`` = _prefixId.prefix "groupMember.en"
    let ``groupMemberOf.en`` = _prefixId.prefix "groupMemberOf.en"
    let ``hereditaryTitle.en`` = _prefixId.prefix "hereditaryTitle.en"
    let ``hierarchicalSubordinate.en`` = _prefixId.prefix "hierarchicalSubordinate.en"
    let ``hierarchicalSuperior.en`` = _prefixId.prefix "hierarchicalSuperior.en"
    let ``honoureeOf.en`` = _prefixId.prefix "honoureeOf.en"
    let ``honoureeOfItemOf.en`` = _prefixId.prefix "honoureeOfItemOf.en"
    let ``hostInstitutionOf.en`` = _prefixId.prefix "hostInstitutionOf.en"
    let ``hostOf.en`` = _prefixId.prefix "hostOf.en"

    let ``identifierForTheCorporateBody.en`` =
        _prefixId.prefix "identifierForTheCorporateBody.en"

    let ``identifierForTheFamily.en`` = _prefixId.prefix "identifierForTheFamily.en"
    let ``identifierForThePerson.en`` = _prefixId.prefix "identifierForThePerson.en"
    let ``illuminatorOf.en`` = _prefixId.prefix "illuminatorOf.en"
    let ``illustratorOf.en`` = _prefixId.prefix "illustratorOf.en"
    let ``incumbent.en`` = _prefixId.prefix "incumbent.en"
    let ``inscriberOf.en`` = _prefixId.prefix "inscriberOf.en"
    let ``instrumentalConductorOf.en`` = _prefixId.prefix "instrumentalConductorOf.en"
    let ``instrumentalistOf.en`` = _prefixId.prefix "instrumentalistOf.en"
    let ``intervieweeExpressionOf.en`` = _prefixId.prefix "intervieweeExpressionOf.en"
    let ``intervieweeOf.en`` = _prefixId.prefix "intervieweeOf.en"
    let ``interviewerExpressionOf.en`` = _prefixId.prefix "interviewerExpressionOf.en"
    let ``interviewerOf.en`` = _prefixId.prefix "interviewerOf.en"
    let ``inventorOf.en`` = _prefixId.prefix "inventorOf.en"
    let ``issuingBodyOf.en`` = _prefixId.prefix "issuingBodyOf.en"
    let ``judgeOf.en`` = _prefixId.prefix "judgeOf.en"
    let ``jurisdictionGovernedOf.en`` = _prefixId.prefix "jurisdictionGovernedOf.en"
    let ``landscapeArchitectOf.en`` = _prefixId.prefix "landscapeArchitectOf.en"

    let ``languageOfTheCorporateBody.en`` =
        _prefixId.prefix "languageOfTheCorporateBody.en"

    let ``languageOfTheFamily.en`` = _prefixId.prefix "languageOfTheFamily.en"
    let ``languageOfThePerson.en`` = _prefixId.prefix "languageOfThePerson.en"
    let ``lettererOf.en`` = _prefixId.prefix "lettererOf.en"
    let ``librettistOf.en`` = _prefixId.prefix "librettistOf.en"
    let ``lightingDesignerOf.en`` = _prefixId.prefix "lightingDesignerOf.en"
    let ``lithographerOf.en`` = _prefixId.prefix "lithographerOf.en"
    let ``localAffiliate.en`` = _prefixId.prefix "localAffiliate.en"
    let ``locationOfConferenceEtc.en`` = _prefixId.prefix "locationOfConferenceEtc.en"
    let ``lyricistOf.en`` = _prefixId.prefix "lyricistOf.en"
    let ``makeUpArtistOf.en`` = _prefixId.prefix "makeUpArtistOf.en"
    let ``manufacturerOf.en`` = _prefixId.prefix "manufacturerOf.en"
    let ``mediumOf.en`` = _prefixId.prefix "mediumOf.en"
    let ``membershipCorporateBody.en`` = _prefixId.prefix "membershipCorporateBody.en"
    let ``mergee.en`` = _prefixId.prefix "mergee.en"
    let ``minuteTakerOf.en`` = _prefixId.prefix "minuteTakerOf.en"
    let ``moderatorOf.en`` = _prefixId.prefix "moderatorOf.en"
    let ``musicalDirectorOf.en`` = _prefixId.prefix "musicalDirectorOf.en"
    let ``nameOfTheCorporateBody.en`` = _prefixId.prefix "nameOfTheCorporateBody.en"
    let ``nameOfTheFamily.en`` = _prefixId.prefix "nameOfTheFamily.en"
    let ``nameOfThePerson.en`` = _prefixId.prefix "nameOfThePerson.en"
    let ``narratorOf.en`` = _prefixId.prefix "narratorOf.en"
    let ``numberOfAConferenceEtc.en`` = _prefixId.prefix "numberOfAConferenceEtc.en"
    let ``officiatedCorporateBody.en`` = _prefixId.prefix "officiatedCorporateBody.en"
    let ``onScreenParticipantOf.en`` = _prefixId.prefix "onScreenParticipantOf.en"
    let ``onScreenPresenterOf.en`` = _prefixId.prefix "onScreenPresenterOf.en"
    let ``organizerOf.en`` = _prefixId.prefix "organizerOf.en"
    let ``otherDesignation.en`` = _prefixId.prefix "otherDesignation.en"

    let ``otherDesignationAssociatedWithTheCorporateBody.en`` =
        _prefixId.prefix "otherDesignationAssociatedWithTheCorporateBody.en"

    let ``otherDesignationAssociatedWithThePerson.en`` =
        _prefixId.prefix "otherDesignationAssociatedWithThePerson.en"

    let ``otherPFCItemOf.en`` = _prefixId.prefix "otherPFCItemOf.en"
    let ``otherPFCManifestationOf.en`` = _prefixId.prefix "otherPFCManifestationOf.en"
    let ``otherPFCWorkOf.en`` = _prefixId.prefix "otherPFCWorkOf.en"

    let ``otherPlaceAssociatedWithTheCorporateBody.en`` =
        _prefixId.prefix "otherPlaceAssociatedWithTheCorporateBody.en"

    let ``ownerOf.en`` = _prefixId.prefix "ownerOf.en"
    let ``panelistOf.en`` = _prefixId.prefix "panelistOf.en"
    let ``papermakerOf.en`` = _prefixId.prefix "papermakerOf.en"
    let ``participantInATreatyOf.en`` = _prefixId.prefix "participantInATreatyOf.en"
    let ``performerOf.en`` = _prefixId.prefix "performerOf.en"

    let ``periodOfActivityOfTheCorporateBody.en`` =
        _prefixId.prefix "periodOfActivityOfTheCorporateBody.en"

    let ``periodOfActivityOfThePerson.en`` =
        _prefixId.prefix "periodOfActivityOfThePerson.en"

    let ``photographerOf.en`` = _prefixId.prefix "photographerOf.en"

    let ``placeAssociatedWithTheCorporateBody.en`` =
        _prefixId.prefix "placeAssociatedWithTheCorporateBody.en"

    let ``placeAssociatedWithTheFamily.en`` =
        _prefixId.prefix "placeAssociatedWithTheFamily.en"

    let ``placeOfBirth.en`` = _prefixId.prefix "placeOfBirth.en"
    let ``placeOfDeath.en`` = _prefixId.prefix "placeOfDeath.en"
    let ``placeOfResidenceEtc.en`` = _prefixId.prefix "placeOfResidenceEtc.en"
    let ``plaintiffCorporateBodyOf.en`` = _prefixId.prefix "plaintiffCorporateBodyOf.en"
    let ``plaintiffOf.en`` = _prefixId.prefix "plaintiffOf.en"
    let ``plaintiffPersonOf.en`` = _prefixId.prefix "plaintiffPersonOf.en"
    let ``platemakerOf.en`` = _prefixId.prefix "platemakerOf.en"
    let ``praesesOf.en`` = _prefixId.prefix "praesesOf.en"
    let ``predecessor.en`` = _prefixId.prefix "predecessor.en"
    let ``predecessorOfSplit.en`` = _prefixId.prefix "predecessorOfSplit.en"

    let ``preferredNameForTheCorporateBody.en`` =
        _prefixId.prefix "preferredNameForTheCorporateBody.en"

    let ``preferredNameForTheFamily.en`` =
        _prefixId.prefix "preferredNameForTheFamily.en"

    let ``preferredNameForThePerson.en`` =
        _prefixId.prefix "preferredNameForThePerson.en"

    let ``presenterOf.en`` = _prefixId.prefix "presenterOf.en"
    let ``printerOf.en`` = _prefixId.prefix "printerOf.en"
    let ``printmakerOf.en`` = _prefixId.prefix "printmakerOf.en"
    let ``producerOf.en`` = _prefixId.prefix "producerOf.en"

    let ``producerOfAnUnpublishedResourceOf.en`` =
        _prefixId.prefix "producerOfAnUnpublishedResourceOf.en"

    let ``productOfAMerger.en`` = _prefixId.prefix "productOfAMerger.en"
    let ``productOfASplit.en`` = _prefixId.prefix "productOfASplit.en"
    let ``productionCompanyOf.en`` = _prefixId.prefix "productionCompanyOf.en"
    let ``productionDesignerOf.en`` = _prefixId.prefix "productionDesignerOf.en"
    let ``professionOrOccupation.en`` = _prefixId.prefix "professionOrOccupation.en"
    let ``progenitor.en`` = _prefixId.prefix "progenitor.en"
    let ``programmerOf.en`` = _prefixId.prefix "programmerOf.en"

    let ``prominentMemberOfTheFamily.en`` =
        _prefixId.prefix "prominentMemberOfTheFamily.en"

    let ``publisherOf.en`` = _prefixId.prefix "publisherOf.en"
    let ``puppeteerOf.en`` = _prefixId.prefix "puppeteerOf.en"
    let ``radioDirectorOf.en`` = _prefixId.prefix "radioDirectorOf.en"
    let ``radioProducerOf.en`` = _prefixId.prefix "radioProducerOf.en"
    let ``rapporteurOf.en`` = _prefixId.prefix "rapporteurOf.en"
    let ``realIdentity.en`` = _prefixId.prefix "realIdentity.en"
    let ``recordingEngineerOf.en`` = _prefixId.prefix "recordingEngineerOf.en"
    let ``recordistOf.en`` = _prefixId.prefix "recordistOf.en"
    let ``relatedCorporateBody.en`` = _prefixId.prefix "relatedCorporateBody.en"
    let ``relatedFamily.en`` = _prefixId.prefix "relatedFamily.en"
    let ``relatedPerson.en`` = _prefixId.prefix "relatedPerson.en"
    let ``researcherOf.en`` = _prefixId.prefix "researcherOf.en"
    let ``respondentOf.en`` = _prefixId.prefix "respondentOf.en"
    let ``restorationistOf.en`` = _prefixId.prefix "restorationistOf.en"
    let ``screenwriterOf.en`` = _prefixId.prefix "screenwriterOf.en"
    let ``sculptorOf.en`` = _prefixId.prefix "sculptorOf.en"
    let ``sellerOf.en`` = _prefixId.prefix "sellerOf.en"
    let ``singerOf.en`` = _prefixId.prefix "singerOf.en"
    let ``softwareDeveloperOf.en`` = _prefixId.prefix "softwareDeveloperOf.en"
    let ``soundDesignerOf.en`` = _prefixId.prefix "soundDesignerOf.en"
    let ``speakerOf.en`` = _prefixId.prefix "speakerOf.en"
    let ``specialEffectsProviderOf.en`` = _prefixId.prefix "specialEffectsProviderOf.en"
    let ``sponsor.en`` = _prefixId.prefix "sponsor.en"

    let ``sponsoredCorporateBodyOfCorporateBody.en`` =
        _prefixId.prefix "sponsoredCorporateBodyOfCorporateBody.en"

    let ``sponsoredCorporateBodyOfFamily.en`` =
        _prefixId.prefix "sponsoredCorporateBodyOfFamily.en"

    let ``sponsoringBodyOf.en`` = _prefixId.prefix "sponsoringBodyOf.en"
    let ``sponsoringCorporateBody.en`` = _prefixId.prefix "sponsoringCorporateBody.en"
    let ``sponsoringFamily.en`` = _prefixId.prefix "sponsoringFamily.en"
    let ``stageDirectorOf.en`` = _prefixId.prefix "stageDirectorOf.en"
    let ``storytellerOf.en`` = _prefixId.prefix "storytellerOf.en"
    let ``subjectOfCorporateBody.en`` = _prefixId.prefix "subjectOfCorporateBody.en"
    let ``subjectOfFamily.en`` = _prefixId.prefix "subjectOfFamily.en"
    let ``subjectOfPerson.en`` = _prefixId.prefix "subjectOfPerson.en"
    let ``successor.en`` = _prefixId.prefix "successor.en"
    let ``surveyorOf.en`` = _prefixId.prefix "surveyorOf.en"
    let ``teacherOf.en`` = _prefixId.prefix "teacherOf.en"
    let ``televisionDirectorOf.en`` = _prefixId.prefix "televisionDirectorOf.en"
    let ``televisionProducerOf.en`` = _prefixId.prefix "televisionProducerOf.en"
    let ``titleOfThePerson.en`` = _prefixId.prefix "titleOfThePerson.en"
    let ``transcriberOf.en`` = _prefixId.prefix "transcriberOf.en"
    let ``translatorOf.en`` = _prefixId.prefix "translatorOf.en"
    let ``typeOfCorporateBody.en`` = _prefixId.prefix "typeOfCorporateBody.en"
    let ``typeOfFamily.en`` = _prefixId.prefix "typeOfFamily.en"
    let ``typeOfJurisdiction.en`` = _prefixId.prefix "typeOfJurisdiction.en"

    let ``undifferentiatedNameIndicator.en`` =
        _prefixId.prefix "undifferentiatedNameIndicator.en"

    let ``variantNameForTheCorporateBody.en`` =
        _prefixId.prefix "variantNameForTheCorporateBody.en"

    let ``variantNameForTheFamily.en`` = _prefixId.prefix "variantNameForTheFamily.en"
    let ``variantNameForThePerson.en`` = _prefixId.prefix "variantNameForThePerson.en"
    let ``visualEffectsProviderOf.en`` = _prefixId.prefix "visualEffectsProviderOf.en"
    let ``voiceActorOf.en`` = _prefixId.prefix "voiceActorOf.en"

    let ``writerOfAddedCommentaryOf.en`` =
        _prefixId.prefix "writerOfAddedCommentaryOf.en"

    let ``writerOfAddedLyricsOf.en`` = _prefixId.prefix "writerOfAddedLyricsOf.en"
    let ``writerOfAddedTextOf.en`` = _prefixId.prefix "writerOfAddedTextOf.en"
    let ``writerOfAfterwordOf.en`` = _prefixId.prefix "writerOfAfterwordOf.en"
    let ``writerOfForewordOf.en`` = _prefixId.prefix "writerOfForewordOf.en"
    let ``writerOfIntroductionOf.en`` = _prefixId.prefix "writerOfIntroductionOf.en"
    let ``writerOfPostfaceOf.en`` = _prefixId.prefix "writerOfPostfaceOf.en"
    let ``writerOfPrefaceOf.en`` = _prefixId.prefix "writerOfPrefaceOf.en"

    let ``writerOfSupplementaryTextualContentOf.en`` =
        _prefixId.prefix "writerOfSupplementaryTextualContentOf.en"
