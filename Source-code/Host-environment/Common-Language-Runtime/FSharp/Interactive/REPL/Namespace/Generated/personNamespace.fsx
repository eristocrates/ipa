#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module person =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/person#" "person"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An individual person who may be dead or alive, but not imaginary. It is that restriction that makes person:Person a sub class of both foaf:Person and schema:Person which both cover imaginary characters as well as real people.</para>
    ///   <para>rdfs:label : Person</para>
    ///   <para>dcterms:identifier : person:Person^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#Person">person:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : All data associated with an individual is subject to change. Names can change for a variety of reasons, either formally or informally, and new information may come to light that means that a correction or clarification can be made to an existing record. Birth names tend to be persistent however and for this reason they are recorded by some public sector information systems. There is no granularity for birth name - the full name should be recorded in a single field.</para>
    ///   <para>rdfs:label : birth name</para>
    ///   <para>dcterms:identifier : person:birthName^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#birthName">person:birthName</a>
    /// </summary>
    let birthName = _prefixId.prefix "birthName"
    /// <summary>
    ///   <para>rdfs:label : citizenship</para>
    ///   <para>rdfs:comment : The citizenship relationship links a Person to a Jurisdiction that has conferred citizenship rights on the individual such as the right to vote, to receive certain protection from the community or the issuance of a passport. Multiple citizenships are recorded as multiple instances of the citizenship relationship.</para>
    ///   <para>dcterms:identifier : person:citizenship^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#citizenship">person:citizenship</a>
    /// </summary>
    let citizenship = _prefixId.prefix "citizenship"
    /// <summary>
    ///   <para>rdfs:label : country of birth</para>
    ///   <para>rdfs:comment : The country in which a Person was born.</para>
    ///   <para>dcterms:identifier : person:countryOfBirth^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#countryOfBirth">person:countryOfBirth</a>
    /// </summary>
    let countryOfBirth = _prefixId.prefix "countryOfBirth"
    /// <summary>
    ///   <para>rdfs:label : country of death</para>
    ///   <para>rdfs:comment : The country in which a Person died.</para>
    ///   <para>dcterms:identifier : person:countryOfDeath^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#countryOfDeath">person:countryOfDeath</a>
    /// </summary>
    let countryOfDeath = _prefixId.prefix "countryOfDeath"
    /// <summary>
    ///   <para>rdfs:comment : Patronymic names are important in some countries. Iceland does not have a concept of family name in the way that many other European countries do, for example. In Bulgaria and Russia, patronymic names are in every day usage, for example, the &amp;quot;Sergeyevich&amp;quot; (Сергеевич) in &amp;quot;Mikhail Sergeyevich Gorbachev&amp;quot; (Михаил Сергеевич Горбачёв).</para>
    ///   <para>rdfs:label : patronymic name</para>
    ///   <para>dcterms:identifier : person:patronymicName^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#patronymicName">person:patronymicName</a>
    /// </summary>
    let patronymicName = _prefixId.prefix "patronymicName"
    /// <summary>
    ///   <para>rdfs:label : place of birth</para>
    ///   <para>rdfs:comment : A person's place of birth.</para>
    ///   <para>dcterms:identifier : person:placeOfBirth^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#placeOfBirth">person:placeOfBirth</a>
    /// </summary>
    let placeOfBirth = _prefixId.prefix "placeOfBirth"
    /// <summary>
    ///   <para>rdfs:label : place of death</para>
    ///   <para>rdfs:comment : A person's place of death.</para>
    ///   <para>dcterms:identifier : person:placeOfDeath^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#placeOfDeath">person:placeOfDeath</a>
    /// </summary>
    let placeOfDeath = _prefixId.prefix "placeOfDeath"
    /// <summary>
    ///   <para>rdfs:label : residency</para>
    ///   <para>rdfs:comment : Residency typically provides an individual with a subset of the rights of a citizen.</para>
    ///   <para>dcterms:identifier : person:residency^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/person#residency">person:residency</a>
    /// </summary>
    let residency = _prefixId.prefix "residency"
