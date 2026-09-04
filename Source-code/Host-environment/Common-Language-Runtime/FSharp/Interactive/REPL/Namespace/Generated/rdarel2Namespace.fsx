#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdarel2 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://metadataregistry.org/uri/schema/RDARelationshipsGR2/" "rdarel2"

    /// <summary>
    ///   <para>skos:definition : A pseudonymous or other identity assumed by the person.skos:definition : Das Pseudonym bzw. die andere Identität, welche die Person annimmt.</para>
    ///   <para>rdfs:label : andere Identitätrdfs:label : Alternate identity</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternateIdentity</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/alternateIdentity">rdarel2:alternateIdentity</a>
    /// </summary>
    let alternateIdentity = _prefixId.prefix "alternateIdentity"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descendantFamily</para>
    ///   <para>rdfs:label : Abstammende Familierdfs:label : Descendant Family</para>
    ///   <para>skos:definition : Die Familie, die von der anderen Familie abstammt.skos:definition : A family descended from the other family.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/descendantFamily">rdarel2:descendantFamily</a>
    /// </summary>
    let descendantFamily = _prefixId.prefix "descendantFamily"
    /// <summary>
    ///   <para>skos:definition : A family descended from the particular person.skos:definition : Die Familie, die von der bestimmten Person abstammt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descendants</para>
    ///   <para>rdfs:label : Nachkommenrdfs:label : Descendants</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/descendants">rdarel2:descendants</a>
    /// </summary>
    let descendants = _prefixId.prefix "descendants"
    /// <summary>
    ///   <para>skos:definition : Die Person, die bei einer Körperschaft beschäftigt ist.skos:definition : A person employed by a corporate body.</para>
    ///   <para>rdfs:label : Arbeitnehmerrdfs:label : Employee</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : employee</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/employee">rdarel2:employee</a>
    /// </summary>
    let employee = _prefixId.prefix "employee"
    /// <summary>
    ///   <para>skos:definition : A corporate body that employs the person.skos:definition : Die Körperschaft, welche die Person beschäftigt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : employer</para>
    ///   <para>rdfs:label : Arbeitgeberrdfs:label : Employer</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/employer">rdarel2:employer</a>
    /// </summary>
    let employer = _prefixId.prefix "employer"
    /// <summary>
    ///   <para>skos:definition : Information elaborating on or clarifying the relationship between an entity represented by a preferred access point and/or identifier and a related entity.skos:definition : Informationen, die die Beziehung zwischen einer Entität, die durch eine Ansetzungsform des Sucheinstiegs und/oder Identifier repräsentiert wird, und einer damit in Beziehung stehenden Entität herausstellt oder erläutert. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : explanationOfRelationship</para>
    ///   <para>rdfs:label : Explanation of Relationshiprdfs:label : Erläuterung der Beziehung</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/explanationOfRelationship">rdarel2:explanationOfRelationship</a>
    /// </summary>
    let explanationOfRelationship = _prefixId.prefix "explanationOfRelationship"
    /// <summary>
    ///   <para>rdfs:label : Familienmitgliedrdfs:label : Family member</para>
    ///   <para>skos:definition : A person who is a member of the family.skos:definition : Die Person, die ein Mitglied der Familie ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : familyMember</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/familyMember">rdarel2:familyMember</a>
    /// </summary>
    let familyMember = _prefixId.prefix "familyMember"
    /// <summary>
    ///   <para>skos:definition : A corporate body that the family founded.skos:definition : Die Körperschaft, welche die Familie gründete.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundedOrganization</para>
    ///   <para>rdfs:label : Founded organizationrdfs:label : gegründete Organisation</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/foundedOrganization">rdarel2:foundedOrganization</a>
    /// </summary>
    let foundedOrganization = _prefixId.prefix "foundedOrganization"
    /// <summary>
    ///   <para>skos:definition : A person who founded the corporate body.skos:definition : Die Person, welche die Körperschaft gegründet hat.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : founder</para>
    ///   <para>rdfs:label : Founderrdfs:label : Gründer</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/founder">rdarel2:founder</a>
    /// </summary>
    let founder = _prefixId.prefix "founder"
    /// <summary>
    ///   <para>rdfs:label : Founding Familyrdfs:label : Gründerfamilie</para>
    ///   <para>skos:definition : Die Familie, welche die Körperschaft gegründet hat.skos:definition : A family that founded the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : foundingFamily</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/foundingFamily">rdarel2:foundingFamily</a>
    /// </summary>
    let foundingFamily = _prefixId.prefix "foundingFamily"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : groupMember</para>
    ///   <para>skos:definition : Die Person, die ein Mitglied der aufführenden Gruppe, einer Expedition, etc. ist.skos:definition : A person who is a member of the performing group, expedition, etc.</para>
    ///   <para>rdfs:label : Group memberrdfs:label : Gruppenmitglied</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/groupMember">rdarel2:groupMember</a>
    /// </summary>
    let groupMember = _prefixId.prefix "groupMember"
    /// <summary>
    ///   <para>skos:definition : A corporate body that is subordinate to the other corporate body (e.g., a parent body).skos:definition : Die Körperschaft, die einer anderen Körperschaft untergeordnet ist (z. B. der Muttergesellschaft).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hierarchicalSubordinate</para>
    ///   <para>rdfs:label : Hierarchical subordinaterdfs:label : untergeordnete Körperschaft</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/hierarchicalSubordinate">rdarel2:hierarchicalSubordinate</a>
    /// </summary>
    let hierarchicalSubordinate = _prefixId.prefix "hierarchicalSubordinate"
    /// <summary>
    ///   <para>skos:definition : Die Körperschaft, die einer anderen Körperschaft übergeordnet ist.skos:definition : A corporate body that is hierarchically superior to the other corporate body.</para>
    ///   <para>rdfs:label : Hierarchical superiorrdfs:label : übergeordnete Körperschaft</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hierarchicalSuperior</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/hierarchicalSuperior">rdarel2:hierarchicalSuperior</a>
    /// </summary>
    let hierarchicalSuperior = _prefixId.prefix "hierarchicalSuperior"
    /// <summary>
    ///   <para>skos:definition : Die Person, die ihren Amtssitz in der Körperschaft hat (z.B. der amtierende Präsident).skos:definition : A person holding an office in the corporate body (e.g., the incumbent president).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : incumbent</para>
    ///   <para>rdfs:label : Amtsinhaberrdfs:label : Incumbent</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/incumbent">rdarel2:incumbent</a>
    /// </summary>
    let incumbent = _prefixId.prefix "incumbent"
    /// <summary>
    ///   <para>rdfs:label : Mergeerdfs:label : fusionierte Körperschaft</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergee</para>
    ///   <para>skos:definition : Die Körperschaft, die mit der anderen Körperschaft fusioniert hat.skos:definition : A corporate body that merged with the other corporate body to form a third.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/mergee">rdarel2:mergee</a>
    /// </summary>
    let mergee = _prefixId.prefix "mergee"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : predecessor</para>
    ///   <para>rdfs:label : Predecessorrdfs:label : Vorgänger</para>
    ///   <para>skos:definition : A corporate body that precedes the other corporate body.skos:definition : Die Körperschaft, die einer anderen Körperschaft vorausgeht.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/predecessor">rdarel2:predecessor</a>
    /// </summary>
    let predecessor = _prefixId.prefix "predecessor"
    /// <summary>
    ///   <para>rdfs:label : Product of a mergerrdfs:label : Ergebnis einer Fusion</para>
    ///   <para>skos:definition : Die Körperschaft, die aus der Fusion einer oder mehrerer Körperschaften entsteht.skos:definition : A corporate body that resulted from a merger of two or more other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productOfAMerger</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/productOfAMerger">rdarel2:productOfAMerger</a>
    /// </summary>
    let productOfAMerger = _prefixId.prefix "productOfAMerger"
    /// <summary>
    ///   <para>skos:definition : Die Körperschaft, die aus einer Spaltung oder Teilung von der anderen Körperschaft entsteht.skos:definition : A corporate body that resulted from a split or division of the other corporate body.</para>
    ///   <para>rdfs:label : Ergebnis einer Teilungrdfs:label : Product of a split</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productOfASplit</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/productOfASplit">rdarel2:productOfASplit</a>
    /// </summary>
    let productOfASplit = _prefixId.prefix "productOfASplit"
    /// <summary>
    ///   <para>skos:definition : Die Person, von der die Familie abstammt.skos:definition : A person from whom the family is descended.</para>
    ///   <para>rdfs:label : Progenitorrdfs:label : Vorfahre, Stammvater</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : progenitor</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/progenitor">rdarel2:progenitor</a>
    /// </summary>
    let progenitor = _prefixId.prefix "progenitor"
    /// <summary>
    ///   <para>skos:definition : A real person who assumes the alternate identity.skos:definition : Die reale Person, die die andere Identität annimmt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : realIdentity</para>
    ///   <para>rdfs:label : wirkliche Identitätrdfs:label : Real identity</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/realIdentity">rdarel2:realIdentity</a>
    /// </summary>
    let realIdentity = _prefixId.prefix "realIdentity"
    /// <summary>
    ///   <para>skos:definition : Eine Körperschaft, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z.B. eine Musikgruppe, der eine Person angehört, eine Tochterfirma). Zu den in Beziehung stehenden  Körperschaften gehören auch Körperschaften, die der Institution, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird, als Ergebnis einer Namensänderung vorangeht oder nachfolgt. skos:definition : A corporate body that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a musical group to which a person belongs, a subsidiary company). Related corporate bodies include corporate bodies that precede or succeed the body represented by an authorized access point and/or identifier as the result of a change of name.</para>
    ///   <para>rdfs:label : Related Corporate Bodyrdfs:label : In Beziehung stehende Körperschaft </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedCorporateBody</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBody">rdarel2:relatedCorporateBody</a>
    /// </summary>
    let relatedCorporateBody = _prefixId.prefix "relatedCorporateBody"

    /// <summary>
    ///   <para>skos:definition : Eine Körperschaft, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z.B. eine Musikgruppe, der eine Person angehört, eine Tochterfirma). Zu den in Beziehung stehenden  Körperschaften gehören auch Körperschaften, die der Institution, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird, als Ergebnis einer Namensänderung vorangeht oder nachfolgt. skos:definition : A corporate body that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a
    /// musical group to which a person belongs, a subsidiary company). Related corporate bodies include corporate bodies that precede or succeed the body represented by an
    /// authorized access point and/or identifier as the result of a change of name.</para>
    ///   <para>rdfs:label : In Beziehung stehende Körperschaft (Körperschaft)rdfs:label : Related Corporate Body (Corporate Body)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedCorporateBodyCorporateBody</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyCorporateBody">rdarel2:relatedCorporateBodyCorporateBody</a>
    /// </summary>
    let relatedCorporateBodyCorporateBody =
        _prefixId.prefix "relatedCorporateBodyCorporateBody"

    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Körperschaft (Familie)rdfs:label : Related Corporate Body (Family)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedCorporateBodyFamily</para>
    ///   <para>skos:definition : Eine Körperschaft, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z.B. eine Musikgruppe, der eine Person angehört, eine Tochterfirma). Zu den in Beziehung stehenden  Körperschaften gehören auch Körperschaften, die der Institution, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird, als Ergebnis einer Namensänderung vorangeht oder nachfolgt. skos:definition : A corporate body that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a musical group to which a person belongs, a subsidiary company). Related corporate bodies include corporate bodies that precede or succeed the body represented by an authorized access point and/or identifier as the result of a change of name.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyFamily">rdarel2:relatedCorporateBodyFamily</a>
    /// </summary>
    let relatedCorporateBodyFamily = _prefixId.prefix "relatedCorporateBodyFamily"
    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Körperschaft (Person)rdfs:label : Related Corporate Body (Person)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedCorporateBodyPerson</para>
    ///   <para>skos:definition : Eine Körperschaft, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z.B. eine Musikgruppe, der eine Person angehört, eine Tochterfirma). Zu den in Beziehung stehenden  Körperschaften gehören auch Körperschaften, die der Institution, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird, als Ergebnis einer Namensänderung vorangeht oder nachfolgt. skos:definition : A corporate body that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a musical group to which a person belongs, a subsidiary company). Related corporate bodies include corporate bodies that precede or succeed the body represented by an authorized access point and/or identifier as the result of a change of name.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedCorporateBodyPerson">rdarel2:relatedCorporateBodyPerson</a>
    /// </summary>
    let relatedCorporateBodyPerson = _prefixId.prefix "relatedCorporateBodyPerson"
    /// <summary>
    ///   <para>rdfs:label : in Beziehung stehende Familierdfs:label : Related Family</para>
    ///   <para>skos:definition : Eine Familie, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z. B. die Familie einer Person, eine Familie, die die Kapitalmehrheit in einer Körperschaft hat). skos:definition : A family that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a person’s family, a family that owns the controlling interest in a corporate body).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedFamily</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamily">rdarel2:relatedFamily</a>
    /// </summary>
    let relatedFamily = _prefixId.prefix "relatedFamily"
    /// <summary>
    ///   <para>rdfs:label : in Beziehung stehende Familierdfs:label : Related Family (Corporate Body)</para>
    ///   <para>skos:definition : A family that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a person’s family, a family that owns the controlling interest in a corporate body).skos:definition : Eine Familie, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z. B. die Familie einer Person, eine Familie, die die Kapitalmehrheit in einer Körperschaft hat). </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedFamilyCorporateBody</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyCorporateBody">rdarel2:relatedFamilyCorporateBody</a>
    /// </summary>
    let relatedFamilyCorporateBody = _prefixId.prefix "relatedFamilyCorporateBody"
    /// <summary>
    ///   <para>rdfs:label : in Beziehung stehende Familie (Familie)rdfs:label : Related Family (Family)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedFamilyFamily</para>
    ///   <para>skos:definition : A family that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a person’s family, a family that owns the controlling interest in a corporate body).skos:definition : Eine Familie, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z. B. die Familie einer Person, eine Familie, die die Kapitalmehrheit in einer Körperschaft hat). </para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyFamily">rdarel2:relatedFamilyFamily</a>
    /// </summary>
    let relatedFamilyFamily = _prefixId.prefix "relatedFamilyFamily"
    /// <summary>
    ///   <para>skos:definition : A family that is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a person’s family, a family that owns the controlling interest in a corporate body).skos:definition : Eine Familie, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder einen Identifier repräsentiert wird (z. B. die Familie einer Person, eine Familie, die die Kapitalmehrheit in einer Körperschaft hat). </para>
    ///   <para>rdfs:label : in beziehung stehende Familie (Person)rdfs:label : Related Family (Person)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedFamilyPerson</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedFamilyPerson">rdarel2:relatedFamilyPerson</a>
    /// </summary>
    let relatedFamilyPerson = _prefixId.prefix "relatedFamilyPerson"
    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Personrdfs:label : Related Person</para>
    ///   <para>skos:definition : Eine Person, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder Identifier repräsentiert wird (z. B. ein Mitarbeiter, ein Familienmitglied, ein Gründer einer Körperschaft). Zu den in Beziehung stehenden Personen gehören auch getrennte Identitäten, die durch ein Individuum begründet wurden. skos:definition : A person who is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a collaborator, a member of a family, a founder of a corporate body). Related persons include separate identities established by an individual.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedPerson</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPerson">rdarel2:relatedPerson</a>
    /// </summary>
    let relatedPerson = _prefixId.prefix "relatedPerson"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedPersonCorporateBody</para>
    ///   <para>rdfs:label : Related Person (Corporate Body)rdfs:label : in Beziehung stehende Person (Körperschaft)</para>
    ///   <para>skos:definition : Eine Person, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder Identifier repräsentiert wird (z.B. ein Mitarbeiter, ein Familienmitglied, ein Gründer einer Körperschaft).Zu den in Beziehung stehenden Personen gehören auch getrennte Identitäten, die durch ein Individuum begründet wurden. skos:definition : A person who is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a collaborator, a member of a family, a founder of a corporate body). Related persons include separate identities established by an individual.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonCorporateBody">rdarel2:relatedPersonCorporateBody</a>
    /// </summary>
    let relatedPersonCorporateBody = _prefixId.prefix "relatedPersonCorporateBody"
    /// <summary>
    ///   <para>rdfs:label : Related Person (Family)rdfs:label : in Beziehung stehende Person (Familie)</para>
    ///   <para>skos:definition : Eine Person, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder Identifier repräsentiert wird (z. B. ein Mitarbeiter, ein Familienmitglied, ein Gründer einer Körperschaft).Zu den in Beziehung stehenden Personen gehören auch getrennte Identitäten, die durch ein Individuum begründet wurden. skos:definition : A person who is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a collaborator, a member of a family, a founder of a corporate body). Related persons include separate identities established by an individual.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedPersonFamily</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonFamily">rdarel2:relatedPersonFamily</a>
    /// </summary>
    let relatedPersonFamily = _prefixId.prefix "relatedPersonFamily"
    /// <summary>
    ///   <para>rdfs:label : Related Person (Person)rdfs:label : in Beziehung stehende Person (Person)</para>
    ///   <para>skos:definition : Eine Person, die mit der Person, Familie oder Körperschaft in Verbindung steht, die durch eine Ansetzungsform des Sucheinstiegs und/oder Identifier repräsentiert wird (z. B. ein Mitarbeiter, ein Familienmitglied, ein Gründer einer Körperschaft).Zu den in Beziehung stehenden Personen gehören auch getrennte Identitäten, die durch ein Individuum begründet wurden. skos:definition : A person who is associated with the person, family, or corporate body represented by a preferred access point and/or identifier (e.g., a collaborator, a member of a family, a founder of a corporate body). Related persons include separate identities established by an individual.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedPersonPerson</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/relatedPersonPerson">rdarel2:relatedPersonPerson</a>
    /// </summary>
    let relatedPersonPerson = _prefixId.prefix "relatedPersonPerson"
    /// <summary>
    ///   <para>skos:definition : A person sponsoring the corporate body.skos:definition : Die Person, welche die Körperschaft fördert.</para>
    ///   <para>rdfs:label : Sponsorrdfs:label : Sponsor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsor</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsor">rdarel2:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>skos:definition : Die Körperschaft, welche von der Familie gefördert wird.skos:definition : A corporate body that the family sponsors.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoredOrganization</para>
    ///   <para>rdfs:label : Sponsored organizationrdfs:label : geförderte Organisation</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsoredOrganization">rdarel2:sponsoredOrganization</a>
    /// </summary>
    let sponsoredOrganization = _prefixId.prefix "sponsoredOrganization"
    /// <summary>
    ///   <para>skos:definition : Die Familie, welche die Körperschaft fördert.skos:definition : A family that sponsors the corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringFamily</para>
    ///   <para>rdfs:label : Sponsorenfamilierdfs:label : Sponsoring Family</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/sponsoringFamily">rdarel2:sponsoringFamily</a>
    /// </summary>
    let sponsoringFamily = _prefixId.prefix "sponsoringFamily"
    /// <summary>
    ///   <para>rdfs:label : Nachfolgerrdfs:label : Successor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : successor</para>
    ///   <para>skos:definition : Die Körperschaft, die einer anderen Körperschaft nachfolgt oder aus ihr hervorgeht.skos:definition : A corporate body that succeeds or follows the other corporate body.</para>
    ///   <a href="http://metadataregistry.org/uri/schema/RDARelationshipsGR2/successor">rdarel2:successor</a>
    /// </summary>
    let successor = _prefixId.prefix "successor"
