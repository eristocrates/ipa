#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ebg =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.businessgraph.io/ontology#" "ebg"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : http://www.registryagency.bg keeps the systems used by The Trade Register http://brra.bg for companies, and The Bulstat Register http://www.bulstat.bg/ for other entities^^xsd:string</para>
    ///   <para>skos:scopeNote : Some agencies/registers keep several identifier systems; this ontology doesn't distinguish between an identifier system and its register(s)^^xsd:string</para>
    ///   <para>skos:definition : A system managed by a publisher (e.g., a register or agency) that is used to issue identifiers to entities (companies, persons, etc).^^xsd:string</para>
    ///   <para>rdfs:label : Identifier System^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#IdentifierSystem">ebg:IdentifierSystem</a>
    /// </summary>
    let IdentifierSystem = _prefixId.prefix "IdentifierSystem"
    /// <summary>
    ///   <para>skos:scopeNote : This class has ebg:urlTemplate, and the same general properties as Web Resource: name, MIME type, language^^xsd:string</para>
    ///   <para>skos:definition : URL template complemented with name, language and MIME type(s) to specify what the URL is about. Substitute the identifier value into the template^^xsd:string</para>
    ///   <para>rdfs:label : Identifier Web Resource^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#IdentifierWebResource">ebg:IdentifierWebResource</a>
    /// </summary>
    let IdentifierWebResource = _prefixId.prefix "IdentifierWebResource"
    /// <summary>
    ///   <para>skos:example : LAU2 SI: Obcine^^xsd:stringskos:example : LAU2 MK: Naseleni mesta^^xsd:stringskos:example : LAU1 CH: Bezirke Districts Distretti^^xsd:stringskos:example : LAU1 DK: Kommuner^^xsd:stringskos:example : LAU1 CZ: Okresy^^xsd:stringskos:example : LAU1 TR: Ilceler^^xsd:stringskos:example : LAU1 SI: Upravne enote^^xsd:stringskos:example : LAU1 CY: Επαpχίες (Eparchies)^^xsd:stringskos:example : LAU2 TR: Köy^^xsd:stringskos:example : LAU2 SE: Kommuner^^xsd:stringskos:example : LAU1 LT: Savivaldybės^^xsd:stringskos:example : LAU1 MK: Општини (Opštini)^^xsd:stringskos:example : LAU2 IS: Sveitarfélög^^xsd:stringskos:example : LAU2 FR: Communes^^xsd:stringskos:example : LAU2 NL: Gemeenten^^xsd:stringskos:example : LAU2 AL: Bashki / Komunë^^xsd:stringskos:example : LAU2 LU: Communes^^xsd:stringskos:example : LAU1 UK: Lower tier authorities (districts) or individual unitary authorities;  Individual unitary authorities or LECs (or parts thereof); Districts^^xsd:stringskos:example : LAU1 IS: Landsvædi^^xsd:stringskos:example : LAU2 PT: Freguesias^^xsd:stringskos:example : LAU1 EE: Maakond^^xsd:stringskos:example : LAU2 LV: Republikas pilsētas, novadi^^xsd:stringskos:example : LAU1 ME: Општине (Opštine)^^xsd:stringskos:example : LAU2 SK: Obce^^xsd:stringskos:example : LAU2 EE: Linn, vald^^xsd:stringskos:example : LAU1 FR: Cantons de rattachement^^xsd:stringskos:example : LAU2 BG: Naseleni mesta^^xsd:stringskos:example : LAU2 ME: Naselja^^xsd:stringskos:example : LAU1 NO: Økonomiske regioner^^xsd:stringskos:example : LAU2 ES: Municipios^^xsd:stringskos:example : LAU2 BE: Gemeenten / Communes^^xsd:stringskos:example : LAU1 DE: Verwaltungs- gemeinschaften^^xsd:stringskos:example : LAU2 LI: Gemeinden^^xsd:stringskos:example : LAU2 FI: Kunnat / Kommuner^^xsd:stringskos:example : LAU1 BG: Общини (Obshtini)^^xsd:stringskos:example : LAU2 CY: Δήμοι, Κοινότητες (Dimoi, koinotites)^^xsd:stringskos:example : LAU2 RO: Comuni + Municipiu + Orase^^xsd:stringskos:example : LAU1 HU: Statisztikai kistérségek^^xsd:stringskos:example : LAU2 IE: Electoral Districts^^xsd:stringskos:example : LAU2 EL: Δημοτικές / Τοπικές Κοινότητες (Dimotikes / Topikes Koinotites - Municipal  / Local Communes)^^xsd:stringskos:example : LAU2 UK: Wards (or parts thereof)^^xsd:stringskos:example : LAU2 CZ: Obce^^xsd:stringskos:example : LAU1 LI: Landschaften^^xsd:stringskos:example : LAU2 DK: Sogne^^xsd:stringskos:example : LAU2 IT: Comuni^^xsd:stringskos:example : LAU1 MT: Distretti^^xsd:stringskos:example : LAU2 HR: Gradovi i općine^^xsd:stringskos:example : LAU2 LT: Seniūnijos^^xsd:stringskos:example : LAU2 CH: Gemeinden Communes Comuni^^xsd:stringskos:example : LAU1 PL: Powiaty i miasta na prawach powiatu^^xsd:stringskos:example : LAU1 LU: Cantons^^xsd:stringskos:example : LAU1 FI: Seutukunnat / Ekonomiska regioner^^xsd:stringskos:example : LAU2 AT: Gemeinden^^xsd:stringskos:example : LAU1 IE: Counties, Cities^^xsd:stringskos:example : LAU2 NO: Kommuner^^xsd:stringskos:example : LAU2 PL: Gminy^^xsd:stringskos:example : LAU2 MT: Kunsilli^^xsd:stringskos:example : LAU2 DE: Gemeinden^^xsd:stringskos:example : LAU1 EL: Δήμοι, Κοινότητες (Demoi, Koinotites)^^xsd:stringskos:example : LAU1 PT: Concelhos - Munícipios^^xsd:stringskos:example : LAU2 HU: Települések^^xsd:stringskos:example : LAU1 SK: Okresy^^xsd:string</para>
    ///   <para>rdfs:comment : Local Administrative Unit^^xsd:string</para>
    ///   <para>rdfs:label : LAU Region^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#LAURegion">ebg:LAURegion</a>
    /// </summary>
    let LAURegion = _prefixId.prefix "LAURegion"
    /// <summary>
    ///   <para>skos:definition : URL complemented with name, language and MIME type(s) to specify what the URL is about^^xsd:string</para>
    ///   <para>rdfs:label : Web Resource^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#WebResource">ebg:WebResource</a>
    /// </summary>
    let WebResource = _prefixId.prefix "WebResource"
    let adminUnit = _prefixId.prefix "adminUnit"
    /// <summary>
    ///   <para>ebg:order : 31^^xsd:integer</para>
    ///   <para>skos:example : nuts:ITC2 Valle d'Aosta/Vallée d'Aoste^^xsd:stringskos:example : nuts:ITH2 Provincia Autonoma di Trento^^xsd:string</para>
    ///   <para>skos:scopeNote : Use a valid NUTS region. Eg Trentino-Alto Adige/Sudtirol (taken from the Geonames hierarchy above) is not a NUTS region.^^xsd:string</para>
    ///   <para>skos:definition : NUTS2 (administrative region) of the address.^^xsd:string</para>
    ///   <para>rdfs:label : admin unit level 3^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#adminUnitL3">ebg:adminUnitL3</a>
    /// </summary>
    let adminUnitL3 = _prefixId.prefix "adminUnitL3"
    /// <summary>
    ///   <para>ebg:order : 32^^xsd:integer</para>
    ///   <para>skos:example : nuts:ITC20 Aosta^^xsd:stringskos:example : nuts:ITH31 Verona^^xsd:string</para>
    ///   <para>skos:definition : NUTS3 (Province) of the address.^^xsd:string</para>
    ///   <para>rdfs:label : admin unit level 4^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#adminUnitL4">ebg:adminUnitL4</a>
    /// </summary>
    let adminUnitL4 = _prefixId.prefix "adminUnitL4"
    /// <summary>
    ///   <para>ebg:order : 33^^xsd:integer</para>
    ///   <para>skos:definition : LAU1 (Municipality/Commune/Settlement) of the address.^^xsd:string</para>
    ///   <para>rdfs:label : admin unit level 5^^xsd:string</para>
    ///   <para>skos:scopeNote : Some countries (e.g. Bulgaria) use both LAU1 and LAU2 levels. Others (e.g. Italy) use only LAU2.^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#adminUnitL5">ebg:adminUnitL5</a>
    /// </summary>
    let adminUnitL5 = _prefixId.prefix "adminUnitL5"
    /// <summary>
    ///   <para>ebg:order : 34^^xsd:integer</para>
    ///   <para>skos:definition : LAU2 (Municipality/Commune/Settlement) of the address.^^xsd:string</para>
    ///   <para>skos:scopeNote : Some countries (e.g. Bulgaria) use both LAU1 and LAU2 levels. Others (e.g. Italy) use only LAU2.^^xsd:string</para>
    ///   <para>rdfs:label : admin unit level 6^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#adminUnitL6">ebg:adminUnitL6</a>
    /// </summary>
    let adminUnitL6 = _prefixId.prefix "adminUnitL6"
    /// <summary>
    ///   <para>ebg:order : 16^^xsd:integer</para>
    ///   <para>skos:scopeNote : Used for faceting.^^xsd:string</para>
    ///   <para>skos:definition : Year the organization was dissolved or deregistered, as integer.^^xsd:string</para>
    ///   <para>rdfs:label : dissolution year^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#dissolutionYear">ebg:dissolutionYear</a>
    /// </summary>
    let dissolutionYear = _prefixId.prefix "dissolutionYear"
    /// <summary>
    ///   <para>ebg:order : 108^^xsd:integer</para>
    ///   <para>rdfs:comment : Exclusion note of a NACE classification concept^^xsd:string</para>
    ///   <para>rdfs:label : exclusion note^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#exclusionNote">ebg:exclusionNote</a>
    /// </summary>
    let exclusionNote = _prefixId.prefix "exclusionNote"
    /// <summary>
    ///   <para>ebg:order : 14^^xsd:integer</para>
    ///   <para>skos:scopeNote : Used for faceting.^^xsd:string</para>
    ///   <para>skos:definition : Year the organization was created, as integer.^^xsd:string</para>
    ///   <para>rdfs:label : founding year^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#foundingYear">ebg:foundingYear</a>
    /// </summary>
    let foundingYear = _prefixId.prefix "foundingYear"
    /// <summary>
    ///   <para>ebg:order : 44^^xsd:integer</para>
    ///   <para>skos:scopeNote : Values must be mapped to the &lt;resolution/&gt; ConceptScheme (lookup list).^^xsd:stringskos:scopeNote : If geo coordinates are present, resolution must be present too, even if it's a guess. There is no default value.^^xsd:string</para>
    ///   <para>skos:definition : Resolution of a geographic coordinate location: from &lt;resolution/L0&gt; continent (least precise) to &lt;resolution/L10&gt; individual house number (most precise).^^xsd:string</para>
    ///   <para>rdfs:label : geocoordinate resolution^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#geoResolution">ebg:geoResolution</a>
    /// </summary>
    let geoResolution = _prefixId.prefix "geoResolution"
    /// <summary>
    ///   <para>skos:scopeNote : Specifies a template that can be used uniformly to build URLs for all identifiers in the system.^^xsd:string</para>
    ///   <para>skos:example : 'https://opencorporates.com/companies/{}.xml'  with MIME type 'application/xml'^^xsd:stringskos:example : 'https://opencorporates.com/companies/{}.rdf'  with MIME type 'application/rdf+xml'^^xsd:stringskos:example : 'https://opencorporates.com/companies/{}'      with MIME type 'text/html'^^xsd:stringskos:example : 'https://opencorporates.com/companies/{}.json' with MIME type 'application/json'^^xsd:string</para>
    ///   <para>ebg:order : 63^^xsd:integer</para>
    ///   <para>skos:definition : Web resource associated with an identifier system^^xsd:string</para>
    ///   <para>rdfs:label : identifier web resource^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#identifierWebResource">ebg:identifierWebResource</a>
    /// </summary>
    let identifierWebResource = _prefixId.prefix "identifierWebResource"
    /// <summary>
    ///   <para>ebg:order : 58^^xsd:integer</para>
    ///   <para>skos:example : Websites are not enumerated^^xsd:stringskos:example : Every official register is enumerated^^xsd:string</para>
    ///   <para>skos:definition : Whether the system has an Issuer and issued identifiers are kept in a database (register)^^xsd:string</para>
    ///   <para>rdfs:label : has enumerated identifiers^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isEnumerated">ebg:isEnumerated</a>
    /// </summary>
    let isEnumerated = _prefixId.prefix "isEnumerated"
    /// <summary>
    ///   <para>ebg:order : 55^^xsd:integer</para>
    ///   <para>skos:example : Some registers encode additional information within the identifier (e.g., some identifiers encode the economic sector of the company). In these cases the identifier changes when the extra information that is encoded changes (see 'Dumb vs. Intelligent Identifiers' in Section 3.1.2.5).^^xsd:string</para>
    ///   <para>skos:definition : whether identifiers can change^^xsd:string</para>
    ///   <para>rdfs:label : has immutable identifiers^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isImmutable">ebg:isImmutable</a>
    /// </summary>
    let isImmutable = _prefixId.prefix "isImmutable"
    /// <summary>
    ///   <para>skos:example : False for SDATI identifiers since the SDATI system is not official in Italy.^^xsd:stringskos:example : False for GLEI, since it is not the official register for any of the world's jurisdictions^^xsd:stringskos:example : True for UK Company House identifiers, the official register for the GB jurisdiction^^xsd:stringskos:example : False for Website, Twitter, Facebook in that they don't have any official status^^xsd:string</para>
    ///   <para>skos:definition : Whether the system is considered the official one in all jurisdictions in which it applies.^^xsd:string</para>
    ///   <para>ebg:order : 59^^xsd:integer</para>
    ///   <para>rdfs:label : is official in jurisdiction^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isOfficial">ebg:isOfficial</a>
    /// </summary>
    let isOfficial = _prefixId.prefix "isOfficial"
    /// <summary>
    ///   <para>ebg:order : 54^^xsd:integer</para>
    ///   <para>skos:scopeNote : Some registers 'remove' identifiers when the object they relate to is no longer active, whereas the best practice is to make such identifiers Obsolete.^^xsd:string</para>
    ///   <para>skos:definition : Whether identifiers can be removed from the register (e.g., when a company is dissolved): such are not persistent^^xsd:string</para>
    ///   <para>rdfs:label : has persistent identifiers^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isPersistent">ebg:isPersistent</a>
    /// </summary>
    let isPersistent = _prefixId.prefix "isPersistent"
    /// <summary>
    ///   <para>skos:definition : whether identifiers from the system are available for public use: consulting, search or download.^^xsd:string</para>
    ///   <para>skos:example : Italian (IT) company identifiers are public. Even though they are not published openly, they are available for a fee, and then can be used freely^^xsd:stringskos:example : DUNS identifiers are not public, even though there are limited lookup services (e.g., https://www.dnb.com/duns-number/lookup.html). Dun and Bradstreet does not allow their use en-masse.^^xsd:string</para>
    ///   <para>ebg:order : 56^^xsd:integer</para>
    ///   <para>skos:scopeNote : Most public systems (but not all) will have some Publishers, and preferably some web resources.^^xsd:string</para>
    ///   <para>rdfs:label : is public^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isPublic">ebg:isPublic</a>
    /// </summary>
    let isPublic = _prefixId.prefix "isPublic"
    /// <summary>
    ///   <para>ebg:order : 7^^xsd:integer</para>
    ///   <para>skos:definition : Whether the company is publicly traded (listed at a stock exchange) [ebg:].^^xsd:string</para>
    ///   <para>rdfs:label : is publicly traded^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isPubliclyTraded">ebg:isPubliclyTraded</a>
    /// </summary>
    let isPubliclyTraded = _prefixId.prefix "isPubliclyTraded"
    /// <summary>
    ///   <para>skos:definition : Whether each entity has only one identifier in the system^^xsd:string</para>
    ///   <para>skos:example : Official person names are single-valued, since each person has one official name (but that can change over time).^^xsd:stringskos:example : Company IDs are single-valued in most national registers. If two companies merge, the recessive company ID is usually deprecated.^^xsd:stringskos:example : Websites are not single-valued since a company may have several websites^^xsd:stringskos:example : Stock exchange tickers are not single-valued, since a company may have several tickers for different kinds of its stock.^^xsd:string</para>
    ///   <para>ebg:order : 53^^xsd:integer</para>
    ///   <para>rdfs:label : is single-valued^^xsd:string</para>
    ///   <para>skos:scopeNote : Similar to owl:FunctionalProperty, and Wikidata Single Value constraint^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isSingleValued">ebg:isSingleValued</a>
    /// </summary>
    let isSingleValued = _prefixId.prefix "isSingleValued"
    /// <summary>
    ///   <para>ebg:order : 5^^xsd:integer</para>
    ///   <para>skos:example : A special section of the IT Business Register http://startup.registroimprese.it/ includes pitch, sectors and business model of startups and innovative SMEs^^xsd:string</para>
    ///   <para>skos:definition : Whether the company is a startup [ebg:]^^xsd:string</para>
    ///   <para>rdfs:label : is startup^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isStartup">ebg:isStartup</a>
    /// </summary>
    let isStartup = _prefixId.prefix "isStartup"
    /// <summary>
    ///   <para>skos:example : True for the Autonomous Province of Trento (local government).^^xsd:stringskos:example : True for the Norwegian company Statkraft (Norwegian state-owned company).^^xsd:stringskos:example : False for SpazioDati (a private company).^^xsd:string</para>
    ///   <para>ebg:order : 6^^xsd:integer</para>
    ///   <para>skos:definition : Whether this organisation is owned by the government, a government agency, community, city or other public entity.^^xsd:string</para>
    ///   <para>rdfs:label : is state owned^^xsd:string</para>
    ///   <para>skos:scopeNote : In many cases it's not possible to compute this attribute without access to the shareholder register, so it may be missing.^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isStateOwned">ebg:isStateOwned</a>
    /// </summary>
    let isStateOwned = _prefixId.prefix "isStateOwned"
    /// <summary>
    ///   <para>skos:example : Person names are not unique since they are highly ambiguous^^xsd:stringskos:example : Stock exchange tickers are unique to each exchange (but a company can buy the ticker of another, i.e. the identity may change over time)^^xsd:stringskos:example : Company IDs are unique in most national registers: one ID cannot identify two companies^^xsd:stringskos:example : Websites are not unique since a website can be shared by several related companies^^xsd:string</para>
    ///   <para>skos:definition : Whether each identifier in the system relates to only one entity^^xsd:string</para>
    ///   <para>skos:scopeNote : Similar to: owl:InverseFunctionalProperty, and Wikidata Distinct Values constraint^^xsd:string</para>
    ///   <para>ebg:order : 52^^xsd:integer</para>
    ///   <para>rdfs:label : has unique identifiers^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#isUnique">ebg:isUnique</a>
    /// </summary>
    let isUnique = _prefixId.prefix "isUnique"
    /// <summary>
    ///   <para>ebg:order : 109^^xsd:integer</para>
    ///   <para>rdfs:comment : Hierarchical level of a thesaurus concept^^xsd:string</para>
    ///   <para>rdfs:label : concept level^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#level">ebg:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>skos:definition : The number of employees in the company.^^xsd:string</para>
    ///   <para>rdfs:label : number of employees^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#numberOfEmployees">ebg:numberOfEmployees</a>
    /// </summary>
    let numberOfEmployees = _prefixId.prefix "numberOfEmployees"
    /// <summary>
    ///   <para>ebg:order : 110^^xsd:integer</para>
    ///   <para>rdfs:comment : Global order of a thesaurus concept respecting the hierarchical structure (depth-first traversal)^^xsd:string</para>
    ///   <para>rdfs:label : order^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#order">ebg:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>skos:example : NACE = 72.19 Scientific research and development in the field of natural, medical, agricultural and technical sciences, without biotechnology^^xsd:stringskos:example : Free text = Development, exploration and production of opto-electronic systems for analogue and digital holographic recording, interferometric measurement of mechanical characteristics and biological objects at micro and macro level, refractometers, light-sensitive materials for holographic recording, blueprints of museum exhibits, artworks and collection surveys, production of holographic illustrations for students, albums, advertising, souvenirs and others, design and manufacture of holographic optical elements with a wide spectrum of applications, marketing and sale of holographic products, consulting, training and promotion of holographic methods and technologies, mediation, brokerage, and **any other activity not prohibited** by Bulgarian legislation.^^xsd:string</para>
    ///   <para>skos:definition : Economic activity of the organization (free text)^^xsd:string</para>
    ///   <para>skos:scopeNote : Such field is widely used in some countries (e.g. BG) and may include much richer info than rov:orgActivity^^xsd:string</para>
    ///   <para>ebg:order : 11^^xsd:integer</para>
    ///   <para>rdfs:label : economic activity text^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#orgActivityText">ebg:orgActivityText</a>
    /// </summary>
    let orgActivityText = _prefixId.prefix "orgActivityText"
    let orgActivityTransitive = _prefixId.prefix "orgActivityTransitive"
    /// <summary>
    ///   <para>skos:example : Πτώχευσηskos:example : Dissolvedskos:example : Revokedskos:example : Situation Normaleskos:example : En Liquidacionskos:example : Inactive</para>
    ///   <para>skos:definition : Company status as it comes from the original register (free text).^^xsd:string</para>
    ///   <para>ebg:order : 9^^xsd:integer</para>
    ///   <para>rdfs:label : status text^^xsd:string</para>
    ///   <para>skos:scopeNote : Include valid language tag (see [iana:] for list).^^xsd:stringskos:scopeNote : If both Status and Status Text are present, they must express compatible values (Status Text may be a finer-granularity value).^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#orgStatusText">ebg:orgStatusText</a>
    /// </summary>
    let orgStatusText = _prefixId.prefix "orgStatusText"
    /// <summary>
    ///   <para>rdfs:label : type text^^xsd:string</para>
    ///   <para>skos:scopeNote : Include valid language tag (see [iana:] for list).^^xsd:stringskos:scopeNote : Because of the difficulties of standardizing Type lookup, we include a free text field^^xsd:stringskos:scopeNote : If Type is also present, it must express the same value as Type Text.^^xsd:string</para>
    ///   <para>skos:example : Private Limited Companyskos:example : Società a responsabilità limitata</para>
    ///   <para>ebg:order : 4^^xsd:integer</para>
    ///   <para>skos:definition : Company Type (Entity Legal Form) as reported by a national company registe (free text).^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#orgTypeText">ebg:orgTypeText</a>
    /// </summary>
    let orgTypeText = _prefixId.prefix "orgTypeText"
    let probabilityOfDefault = _prefixId.prefix "probabilityOfDefault"
    /// <summary>
    ///   <para>ebg:order : 50^^xsd:integer</para>
    ///   <para>skos:scopeNote : Used only for official registers.^^xsd:string</para>
    ///   <para>skos:definition : GLEI RAL code for the identifier system.^^xsd:string</para>
    ///   <para>rdfs:label : identifier system RAL code^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#ralCode">ebg:ralCode</a>
    /// </summary>
    let ralCode = _prefixId.prefix "ralCode"
    /// <summary>
    ///   <para>ebg:order : 62^^xsd:integer</para>
    ///   <para>skos:example : "$1$2$3" can be used together with the validationRegex "(\d{2})-?(\d{3})-?(\d{4})" to extract the pure digits from a DUNS number spelled with optional dashes (e.g. "36-032-1459" -&gt; "360321459")^^xsd:string</para>
    ///   <para>skos:definition : Pattern to use together with the Validation Regex to normalise identifier values by removing optional decorations^^xsd:string</para>
    ///   <para>rdfs:label : replacement pattern^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#replacementPattern">ebg:replacementPattern</a>
    /// </summary>
    let replacementPattern = _prefixId.prefix "replacementPattern"
    /// <summary>
    ///   <para>skos:definition : The (hierarchical) position of the person within a company (in free text), e.g., director.^^xsd:string</para>
    ///   <para>rdfs:label : role text^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#rolePositionText">ebg:rolePositionText</a>
    /// </summary>
    let rolePositionText = _prefixId.prefix "rolePositionText"
    /// <summary>
    ///   <para>skos:example : For OCORP, 'https://opencorporates.com/companies/{}.rdf'  returns company data with MIME type 'application/rdf+xml'^^xsd:stringskos:example : For OCORP, 'https://opencorporates.com/companies/{}.json' returns company data with MIME type 'application/json'^^xsd:stringskos:example : 'For the EU Value Added Tax (VIES) register, 'http://ec.europa.eu/taxation_customs/vies/vatResponse.html?memberStateCode=$1&amp;number=$2' with MIME type 'text/html' shows a web page for an identifier that can be parsed with ebg:validationRegex '([A-Z]{2})/(\d+)'. Here $1 is the member state code, and $2 is the national company id'^^xsd:stringskos:example : 'For BR, 'http://data.brreg.no/enhetsregisteret/enhet/{}' with either 'application/xml' or 'application/json' returns the respective MIME type using Content Negotiation'^^xsd:stringskos:example : For OCORP, 'https://opencorporates.com/companies/{}.xml'  returns company data with MIME type 'application/xml'^^xsd:stringskos:example : 'For BE Banque-Carrefour des Entreprises, 'https://kbopub.economie.fgov.be/kbopub/toonondernemingps.html?ondernemingsnummer={}' with MIME type 'text/html' shows a web page for the company.'^^xsd:stringskos:example : For OCORP, 'https://opencorporates.com/companies/{}'      returns company data with MIME type 'text/html'^^xsd:string</para>
    ///   <para>skos:definition : URL template of an identifier web resource.
    /// If it has a placeholder {}, substitute the identifier value there.
    /// If it has placeholders like $1, $2… substitute the groups extracted by ebg:validationRegex^^xsd:string</para>
    ///   <para>ebg:order : 69^^xsd:integer</para>
    ///   <para>rdfs:label : URL template^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#urlTemplate">ebg:urlTemplate</a>
    /// </summary>
    let urlTemplate = _prefixId.prefix "urlTemplate"
    /// <summary>
    ///   <para>skos:example : "\d{9}" is a simple regex for validating DUNS numbers^^xsd:stringskos:example : "([A-Z]{2})/(\d+)" is a regex for the EU Value Added Tax (VIES) register, which consists of a member state code followed by slash and a national numeric identifier^^xsd:stringskos:example : "(\d{2})-?(\d{3})-?(\d{4})" is a regex for validating DUNS numbers that may include optional dashes in the indicated positions (e.g. "36-032-1459")^^xsd:string</para>
    ///   <para>skos:definition : Regular expression for validating identifier values within the system^^xsd:string</para>
    ///   <para>rdfs:label : validation regex^^xsd:string</para>
    ///   <para>ebg:order : 61^^xsd:integer</para>
    ///   <a href="http://data.businessgraph.io/ontology#validationRegex">ebg:validationRegex</a>
    /// </summary>
    let validationRegex = _prefixId.prefix "validationRegex"
    /// <summary>
    ///   <para>rdfs:label : validation rule^^xsd:string</para>
    ///   <para>skos:scopeNote : Can be in the form of webpage, PDF document, RDF shape, etc. Multiple values about the same validation rule are ok.^^xsd:string</para>
    ///   <para>skos:definition : URL providing human or machine-readable rule(s) for validating identifiers in the system^^xsd:string</para>
    ///   <para>skos:example : http://bsv-bg.com/ describes the BG EIK checksum algorithm in HTML^^xsd:stringskos:example : http://www.nsi.bg/sites/default/files/konkursi/RGP_OPAK_2014_Annex_6.pdf describes the BG EIK checksum algorithm in PDF. It is by an official source, but is less convenient^^xsd:string</para>
    ///   <para>ebg:order : 60^^xsd:integer</para>
    ///   <a href="http://data.businessgraph.io/ontology#validationRule">ebg:validationRule</a>
    /// </summary>
    let validationRule = _prefixId.prefix "validationRule"
    /// <summary>
    ///   <para>ebg:order : 64^^xsd:integer</para>
    ///   <para>skos:example : http://opendata.government.bg/dataset/tbprobckn-pernctbp is the open data download site for BG TR.^^xsd:stringskos:example : https://brra.bg is the homepage of BG TR.^^xsd:stringskos:example : https://kbopub.economie.fgov.be/kbopub/zoeknummerform.html is the search URL for BE Banque-Carrefour des Entreprises.^^xsd:string</para>
    ///   <para>rdfs:label : web resource^^xsd:string</para>
    ///   <para>skos:definition : Web resource associated with an identifier system.^^xsd:string</para>
    ///   <a href="http://data.businessgraph.io/ontology#webResource">ebg:webResource</a>
    /// </summary>
    let webResource = _prefixId.prefix "webResource"
