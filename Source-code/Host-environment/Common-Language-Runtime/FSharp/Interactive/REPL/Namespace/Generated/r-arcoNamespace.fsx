#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``r-arco`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/arco/" "r-arco"

    /// <summary>
    ///   <para>rdfs:comment : This class represents a classification different from the Hornbostel-Sachs classification.rdfs:comment : Questa classe rappresenta un sistema di classificazione diverso da quello Hornbostel-Sachs, con cui può essere codificato uno strumento musicale.</para>
    ///   <para>rdfs:label : Classificazione alternativa di strumento musicalerdfs:label : Alternative musical instrument classification</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL/CLA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/AlternativeMusicalInstrumentClassification">r-arco:AlternativeMusicalInstrumentClassification</a>
    /// </summary>
    let AlternativeMusicalInstrumentClassification =
        _prefixId.prefix "AlternativeMusicalInstrumentClassification"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa TMA: MA^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un materiale archeologico, che è una parte di un lotto di materiali archeologici.rdfs:comment : This class represents an archaeological material, that is a part of a lot of archaeological materials.</para>
    ///   <para>rdfs:label : Materiale archeologicordfs:label : Archaeological material</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ArchaeologicalMaterial">r-arco:ArchaeologicalMaterial</a>
    /// </summary>
    let ArchaeologicalMaterial = _prefixId.prefix "ArchaeologicalMaterial"

    /// <summary>
    ///   <para>rdfs:label : Archaeological material categoryrdfs:label : Categoria del materiale archeologico</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la categoria di materiale, parte di un lotto di materiali archeologici. (es.: ceramiche, industria litica, intonaco, legno, etc.)rdfs:comment : This class represents the category of an archaeological material, that is part of a lot of archaeological materials (e.g.: ceramics, plaster, lithic materials, etc.)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa TMA: MA/MAC/MACC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ArchaeologicalMaterialCategory">r-arco:ArchaeologicalMaterialCategory</a>
    /// </summary>
    let ArchaeologicalMaterialCategory =
        _prefixId.prefix "ArchaeologicalMaterialCategory"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Bene Archeologicordfs:label : Archaeological Property</para>
    ///   <para>rdfs:comment : This class represents an archaeological cultural property, consisting of archaeological complexes, archaeological monuments, anthropological materials, archaeological objects, stratigraphic records, archaeological sites, archaeological materials tables. Archaeological complexes: monumental complexes consisting of several building units (inhabited areas, fortified centers, sanctuaries, thermal complexes, etc.), catalogued regardless of their current conservation status. Archaeological monuments: single building units (a tower, a domus, a temple, etc.) catalogued regardless of their current conservation status. Anthropological materials: biological evidence related to archaeological and paleontological contexts. Archaeological objects: movable properties of archaeological origin (jewelry and jewelry, clothing, furnishings, architectural elements, paintings, archeobotanical and archeozoological objects, sculpture, tools and everyday objects, etc.). Stratigraphic records: stratigraphic sequences found in archaeological excavation contexts. Archaeological sites: portions of territory that preserve archaeological evidence. Archaeological materials tables: lots of archaeological materials.rdfs:comment : Questa classe rappresenta un bene culturale archeologico, che può essere un complesso archeologico, un monumento archeologico, un reperto archeologico, un reperto antropologico, un saggio stratigrafico, un sito archeologico, o una tabella materiali archeologici. Complessi archeologici: complessi monumentali costituiti da più unità edilizie (abitati, centri fortificati, santuari, complessi termali, ecc.), catalogati a prescindere dal loro attuale stato di conservazione. Monumenti archeologici: singole unità edilizie (una torre, una domus, un tempio, ecc.) catalogate a prescindere dal loro attuale stato di conservazione. Reperti antropologici: testimonianze biologiche in relazione con contesti archeologici e paleontologici. Reperti archeologici: beni mobili di provenienza archeologica (gioielli e monili, vestimenti, arredi, elementi architettonici, opere di pittura, reperti archeobotanici e archeozoologici, scultura, strumenti e oggetti d’uso, ecc.). Saggi stratigrafici: sequenze stratigrafiche rinvenute in contesti di scavo archeologico. Siti archeologici: porzioni di territorio che conservano testimonianze archeologiche. Tabella materiali archeologici: lotti di materiali di provenienza archeologica</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ArchaeologicalProperty">r-arco:ArchaeologicalProperty</a>
    /// </summary>
    let ArchaeologicalProperty = _prefixId.prefix "ArchaeologicalProperty"
    let ArchaeologicalScope = _prefixId.prefix "ArchaeologicalScope"
    let ArchitecturalLandscapeScope = _prefixId.prefix "ArchitecturalLandscapeScope"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Architectural or Landscape Heritagerdfs:label : Bene Architettonico o Paesaggistico</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale architettonico e paesaggistico. Architettura: complessi monumentali, edifici pubblici e di culto, dimore gentilizie, architetture fortificate, edifici privati, edilizia rurale, fabbricati di archeologia industriale caratterizzati da particolare rilevanza storico artistica. Centri/nuclei storici: strutture insediative urbane più antiche dei territori comunali, caratterizzate da testimonianze storico artistiche di particolare rilevanza. Parchi e giardini: spazi verdi di particolare rilevanza  storica, artistica e ambientale. Esempi di questa tipologia di beni culturali sono i giardini e i parchi annessi alle proprietà nobiliari, gli orti e i giardini botanici, i parchi urbani, le aree verdi comprese nei siti archeologici, ma anche i piccoli giardini privati, i chiostri e i cortili, i cimiteri, sempre se caratterizzati da particolare rilevanza storico artistica.rdfs:comment : This class represents an architectural or landscape heritage. Architecture: monumental complexes, public and religious buildings, noble residences, fortified architectures, private buildings, rural buildings, industrial archeology buildings characterized by particular historical and artistic importance. Historical centers: urban settlement structures older than the municipal territories, characterized by particularly important historical artistic testimonies. Parks and gardens: green spaces of particular historical, artistic and environmental importance. Examples of this type of cultural heritage are gardens and parks annexed to noble properties, vegetable gardens and botanical gardens, urban parks, green areas included in archaeological sites, but also small private gardens, cloisters and courtyards, cemeteries, always if characterized by particular historical and artistic relevance.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ArchitecturalOrLandscapeHeritage">r-arco:ArchitecturalOrLandscapeHeritage</a>
    /// </summary>
    let ArchitecturalOrLandscapeHeritage =
        _prefixId.prefix "ArchitecturalOrLandscapeHeritage"

    /// <summary>
    ///   <para>rdfs:label : Classificazione cartograficardfs:label : Cartographic classification</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a cartographic classification of a cultural property, referring to the cartographic representation on specific thematic levels, based on a standard or a classification defined by the cataloguing agency.rdfs:comment : Questa classe rappresenta una classificazione di un bene culturale relativamente alla rappresentazione cartografica del bene su specifici livelli tematici, con riferimento a uno standard oppure a un'organizzazione logica predefinita dall'Ente responsabile dell'attività di catalogazione.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: CT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CartographicClassification">r-arco:CartographicClassification</a>
    /// </summary>
    let CartographicClassification = _prefixId.prefix "CartographicClassification"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il simbolo con cui si rappresenta il bene su una base cartografica in relazione al tema di interesse.rdfs:comment : This class represents the symbol used to represent the cultural property on a cartographic base map, referring to the cartographic theme.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Cartographic symbolrdfs:label : Simbolo cartografico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CartographicSymbol">r-arco:CartographicSymbol</a>
    /// </summary>
    let CartographicSymbol = _prefixId.prefix "CartographicSymbol"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMT^^xsd:string</para>
    ///   <para>rdfs:label : Tema cartograficordfs:label : Cartographic theme</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tema di riferimento associato a una classificazione cartografica di un bene culturale.rdfs:comment : This class represents the cartographic theme associated to a cartographic classification of a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CartographicTheme">r-arco:CartographicTheme</a>
    /// </summary>
    let CartographicTheme = _prefixId.prefix "CartographicTheme"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale complesso, cioè costituito da più parti componenti.rdfs:comment : This class represents a complex cultural property, that consists of different components.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se viene valorizzato il campo OG/OGT/OGTP, i valori dei campi OGTD e OGTT si riferiscono a un bene culturale complesso, rappresentato quindi per mezzo di questa classe, di cui OGTP è parte componente.</para>
    ///   <para>rdfs:label : Bene Culturale Complessordfs:label : Complex Cultural Property</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ComplexCulturalProperty">r-arco:ComplexCulturalProperty</a>
    /// </summary>
    let ComplexCulturalProperty = _prefixId.prefix "ComplexCulturalProperty"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale, sia materiale che immateriale. Un bene culturale è una testimonianza materiale o immateriale, riconosciuta come parte del patrimonio culturale nazionale in quanto utile alla conoscenza e alla ricostruzione della storia e del paesaggio.rdfs:comment : This class represents a cultural property, both tangible and intangible. A cultural property is the legacy, tangible or intangible, recognised as part of the national cultural heritage, since it helps know and reconstruct the history and the landscape.</para>
    ///   <para>rdfs:label : Cultural Propertyrdfs:label : Bene culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalProperty">r-arco:CulturalProperty</a>
    /// </summary>
    let CulturalProperty = _prefixId.prefix "CulturalProperty"

    /// <summary>
    ///   <para>rdfs:label : Cultural property cataloguing categoryrdfs:label : Categoria di bene culturale basata su catalogazione</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una categoria di un bene culturale basata su una valutazione soggettiva del catalogatore durante il processo di catalogazione.rdfs:comment : This class represents a cultural property category based on a subjective evaluation of the cataloguing agent, during the cataloguing process.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGT/OGTV^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyCataloguingCategory">r-arco:CulturalPropertyCataloguingCategory</a>
    /// </summary>
    let CulturalPropertyCataloguingCategory =
        _prefixId.prefix "CulturalPropertyCataloguingCategory"

    /// <summary>
    ///   <para>rdfs:label : Cultural Property Categoryrdfs:label : Categoria del bene</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la categoria di un bene culturale, che contiene le indicazioni che consentono di inquadrare l'individuazione terminologica del bene catalogato nell'ambito di una più ampia e complessa organizzazione semantica.rdfs:comment : This class represents the category of a cultural property, which contains the information that allows us to frame the terminological identification of the properties catalogued in the context of a wider and more complex semantic structure.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/CTG -  Normativa AT: OG/OGT/OGTP - Normativa RA: OG/CLS - Normative CA e MA e Normativa VeAC: OG/OGT/OGTC</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyCategory">r-arco:CulturalPropertyCategory</a>
    /// </summary>
    let CulturalPropertyCategory = _prefixId.prefix "CulturalPropertyCategory"
    /// <summary>
    ///   <para>rdfs:label : Insieme di beni culturalirdfs:label : Cultural Property Collection</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents a complex cultural property, when it is a series or a set.rdfs:comment : Questa classe rappresenta un bene culturale complesso, quando questo si configuri come una serie o un insieme.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyCollection">r-arco:CulturalPropertyCollection</a>
    /// </summary>
    let CulturalPropertyCollection = _prefixId.prefix "CulturalPropertyCollection"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a component of a complex cultural property.rdfs:comment : Questa classe rappresenta una parte componente di un bene culturale complesso.</para>
    ///   <para>rdfs:label : Cultural Property Componentrdfs:label : Parte Componente di Bene Culturale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyComponent">r-arco:CulturalPropertyComponent</a>
    /// </summary>
    let CulturalPropertyComponent = _prefixId.prefix "CulturalPropertyComponent"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGT/OGTS^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a category of a numismatic property, related to a classification based on an inventory approved by the specific subject area.rdfs:comment : Questa classe rappresenta la categoria di un bene numismatico, in riferimento a una classificazione che si basa su un repertorio riconosciuto nello specifico ambito disciplinare.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Cultural property inventory categoryrdfs:label : Categoria di bene culturale basata su repertorio</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyInventoryCategory">r-arco:CulturalPropertyInventoryCategory</a>
    /// </summary>
    let CulturalPropertyInventoryCategory =
        _prefixId.prefix "CulturalPropertyInventoryCategory"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a generic part of a cultural property, to which some specific information is referred.rdfs:comment : Questa classe rappresenta, a un livello generico, una parte di un bene culturale descritto in una scheda cui si possono riferire informazioni specifiche.</para>
    ///   <para>ctlog:iccdNormTag : "Riferimento alla parte", presente in molti campi strutturati delle normative ICCD - ICCD Normativa AT 3.01: EL/ELE</para>
    ///   <para>rdfs:label : Parte di Bene Culturalerdfs:label : Cultural Property Part</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyPart">r-arco:CulturalPropertyPart</a>
    /// </summary>
    let CulturalPropertyPart = _prefixId.prefix "CulturalPropertyPart"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the residual part of a cultural property, that is what's left of the original cultural property.rdfs:comment : Questa classe rappresenta la parte residuale di un bene culturale, cioè la parte che si conserva del bene culturale originale.</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTW^^xsd:string</para>
    ///   <para>rdfs:label : Parte Residuale di Bene Culturalerdfs:label : Cultural Property Residual</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/CulturalPropertyResidual">r-arco:CulturalPropertyResidual</a>
    /// </summary>
    let CulturalPropertyResidual = _prefixId.prefix "CulturalPropertyResidual"

    /// <summary>
    ///   <para>rdfs:label : Bene Demoetnoantropologicordfs:label : Demo-ethno-anthropological Heritage</para>
    ///   <para>rdfs:comment : This class represents a demo-ethno-anthropological heritage, both tangible and intangible. The intangible demoetnoanthropological properties are cultural properties consisting of unique and unrepeatable performances, structurally connected to the territory and to socially shared custom, transmitted through orality and bodily techniques, both in Italy and in Europe and beyond Europe (non-verbal communications, dances, parties and ceremonies, games, oral letters, music, customary norms, performances and shows, knowledge, techniques). Demo-ethno-anthropological tangible properties are cultural properties whose construction and/or use are structurally associated with a socially shared custom, transmitted through orality and bodily techniques, both in the Italian and European and extra-European areas (clothing and body ornaments, furnishings and furnishings, means of transport, rituals, instruments and accessories, properties on the territory).rdfs:comment : Questa classe rappresenta un bene culturale demoetnoantropologico, che può essere di tipo immateriale e materiale. I beni demoetnoantropologici immateriali sono beni consistenti in performance uniche e irrepetibili strutturalmente connesse al territorio e a prassi socialmente condivise trasmesse attraverso l’oralità e le tecniche corporali, tanto in ambito italiano quanto in ambito europeo ed extra-europeo (comunicazioni non verbali, danze, feste e cerimonie, giochi, letterature orali, musiche, norme consuetudinarie, rappresentazioni e spettacoli, saperi, tecniche). I beni demoetnoantropologici materiali sono beni la cui costruzione e/o il cui uso sono strutturalmente associati a prassi socialmente condivise, trasmesse attraverso l'oralità e le tecniche corporali, tanto in ambito italiano quanto in ambito europeo ed extra-europeo (abbigliamento e ornamenti del corpo, arredi e suppellettili, mezzi di trasporto, ritualità, strumenti e accessori, beni sul territorio).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/DemoEthnoAnthropologicalHeritage">r-arco:DemoEthnoAnthropologicalHeritage</a>
    /// </summary>
    let DemoEthnoAnthropologicalHeritage =
        _prefixId.prefix "DemoEthnoAnthropologicalHeritage"

    let EthnoAnthropologicalScope = _prefixId.prefix "EthnoAnthropologicalScope"
    /// <summary>
    ///   <para>rdfs:label : definizione Hornbostel-Sachsrdfs:label : Hornbostel-Sachs definition</para>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL/CHS/CHSD^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents the definition associated to a musical instrument, according to the Hornbostel-Sachs classification.rdfs:comment : Questa proprietà rappresenta la definizione associata allo strumento musicale, secondo la classificazione Hornbostel-Sachs.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/HSDefinition">r-arco:HSDefinition</a>
    /// </summary>
    let HSDefinition = _prefixId.prefix "HSDefinition"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'indicazione bibliografica dell'edizione Hornbostel-Sachs utilizzata per la classificazione dello strumento musicale.rdfs:comment : This property represents the edition Horbonstel-Sachs used for classifying a musical instrument.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL/CHS/CHSE^^xsd:string</para>
    ///   <para>rdfs:label : edizione Hornbostel-Sachsrdfs:label : Hornbostel-Sachs edition</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/HSEdition">r-arco:HSEdition</a>
    /// </summary>
    let HSEdition = _prefixId.prefix "HSEdition"
    /// <summary>
    ///   <para>rdfs:label : Hornbostel-Sachs numberrdfs:label : Codice numerico Hornbostel-Sachs</para>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL/CHS/CHSN^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice numerico, secondo l'edizione specifica Hornbostel-Sachs, associato allo strumento musicale nell'ambito della classificazione Hornbostel-Sachs.rdfs:comment : This property represents the numerical code associated to a musical instrument according to a specific edition of the Hornbostel-Sachs classification.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/HSNumber">r-arco:HSNumber</a>
    /// </summary>
    let HSNumber = _prefixId.prefix "HSNumber"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale storico e artistico, che può essere un disegno, una matrice incisa, un'opera o oggetto d'arte (contemporanea e non), una stampa, un vestimento antico o contemporaneo. Disegni: opere fatte a mano su qualsiasi supporto (carta, cartoncino, cartone, intonaco, legno, pergamena, pietra, seta, tavola, tela ecc.) e con particolari strumenti (carboncino, gessetto, inchiostro, lapis, matita, pastello, penna ecc.) e specifiche tecniche (acquarellatura, sanguigna ecc.). Matrici incise: lastre di vario materiale (acciaio, legno, linoleum, ottone, pietra, zinco rame ecc.) su cui vengono tracciate rappresentazioni pittoriche con particolari strumenti (bulino, punte di acciaio o di diamante, punzoni, raschietti ecc.) e con specifiche tecniche di incisione (acquaforte, acquatinta, litografia, mezzatinta, serigrafia, silografia, zincografia ecc.). Opere e oggetti d'arte: beni mobili costituenti parte integrante di monumenti artistici e storici o provenienti dallo smembramento dei monumenti stessi, conservati in collezioni, musei e pinacoteche (armi ed armature, arredi civili e religiosi, oggetti per il culto, oggetti d'uso, opere di pittura, tessuti e arazzi, sulture, ecc.). Opere e oggetti d'arte contemporanea: opere rappresentative  delle nuove correnti artistiche dei secc. XX e  XXI (assemblaggio, computer art, istallazione, istallazione ambientale, istallazione audio, istallazione video, istallazione multimediale interattiva, opera cinetico-visuale, performance, ready made, realtà virtuale, video arte ecc.). Stampe: esemplari prodotti dall'operazione mediante la quale da una matrice di incisione si ottengono copie uguali di rappresentazioni pittoriche su carta, cartoncino, cuoio,  pergamena, seta ecc. con varie tecniche di incisione (acquaforte, acquatinta, litografia, zincografia ecc.). Vestimenti antichi e contemporanei: abiti e costumi riguardanti l’abbigliamento maschile, femminile e infantile ad uso civile, connessi alle principali finalità d’uso e alle diverse occasioni della vita privata e sociale,  secondo le tipologie storiche dei secoli XVIII, XIX, XX  (abiti, biancheria intima, calzetteria, calzoni, camicie, costumi, cuffie, gonne, giacche, grembiuli, livree, maglie, mantelli, scialli, sciarpe, veli ecc.).rdfs:comment : This class represents an historic or artistic property: drawing, printing plate, (contemporary) artworks, print, historic and contemporary garment. Drawings: works done by hand on any support (paper, cardboard, plaster, wood, parchment, stone, silk, table, canvas, etc.) and with special tools (charcoal, chalk, ink, pencil, pastel, pen etc.) and technical specifications (watercolor, blood, etc.). Printing plates: plates of various materials (steel, wood, linoleum, brass, stone, copper zinc, etc.) on which pictorial representations are traced with particular tools (burin, steel or diamond points, punches, scrapers, etc.) and with technical specifications for etching (etching, aquatint, lithography, halftone, screen printing, silica, zincography, etc.). Artworks: movable cultural properties that are integral part of artistic and historical monuments or coming from the dismemberment of the monuments themselves, preserved in collections, museums and art galleries (weapons and armor, civil and religious furnishings, objects for worship, everyday objects, paintings, fabrics and tapestries, walls, etc.). Contemporary artworks: cultural properties representative of the new artistic currents of the centuries XX and XXI (assembly, computer art, installation, environmental installation, audio installation, video installation, interactive multimedia installation, kinetic-visual work, performance, ready-made, virtual reality, video art, etc.). Prints: specimens created through this process: equal copies of pictorial representations on paper, cardboard, leather, parchment, silk, etc. are obtained from a printing plate, with various engraving techniques (etching, aquatint, lithography, zincography, etc.). Historic and contemporary garments: clothes and costumes for men's, women's and children's clothing for civil use, connected to the main intended use and to different occasions of private and social life, according to the historical typologies of the XVIII, XIX and XX centuries (dresses, underwear, hosiery, trousers, shirts, costumes, headphones, skirts, jackets, aprons, liveries, sweaters, cloaks, shawls, scarves, veils, etc.).</para>
    ///   <para>rdfs:label : Historic Or Artistic Propertyrdfs:label : Bene Storico o Artistico</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/HistoricOrArtisticProperty">r-arco:HistoricOrArtisticProperty</a>
    /// </summary>
    let HistoricOrArtisticProperty = _prefixId.prefix "HistoricOrArtisticProperty"
    let HistoricalArtisticScope = _prefixId.prefix "HistoricalArtisticScope"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Hornbostel-Sachs classificationrdfs:label : Classificazione Hornbostel-Sachs</para>
    ///   <para>rdfs:comment : This class represents the Hornbostel-Sachs classification of a musical instrument.rdfs:comment : Questa classe rappresenta la classificazione Hornbostel-Sachs di uno strumento musicale.</para>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL/CHS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/HornbostelSachsClassification">r-arco:HornbostelSachsClassification</a>
    /// </summary>
    let HornbostelSachsClassification = _prefixId.prefix "HornbostelSachsClassification"
    /// <summary>
    ///   <para>rdfs:comment : This class represents an immovable cultural property, a property fastened and/or incorporated into the ground (buildings, monumental complexes, territorial areas, etc.) which generally has a significant spatial extent.rdfs:comment : Questa classe rappresenta un bene materiale immobile, cioè un bene agganciato e/o incorporato al suolo (edifici, complessi monumentali, spazi territoriali, ecc.) che presentano, in genere, un consistente sviluppo spaziale. Si intende come un particolare tipo di Site (contenitore fisico), in quanto luogo fisico georeferenziato che possiede esso stesso un interesse culturale.</para>
    ///   <para>rdfs:label : Bene immobilerdfs:label : Immovable Cultural Property</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ImmovableCulturalProperty">r-arco:ImmovableCulturalProperty</a>
    /// </summary>
    let ImmovableCulturalProperty = _prefixId.prefix "ImmovableCulturalProperty"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene immateriale, cioè quella parte del patrimonio culturale rappresentata da performance effimere di manifestazioni tradizionali, tecniche, saperi (feste, esecuzioni musicali e coreutiche, rappresentazioni teatrali, tecniche artigianali, letteratura orale, ecc.), colte nel momento in cui avvengono e di cui è possibile mantenere memoria solo attraverso la ripresa audio-visiva che le fissa stabilmente, cristallizzandole.rdfs:comment : This class represents an intangible cultural property, that part of cultural heritage represented by ephemeral performances of traditional manifestations, techniques, knowledge (festivals, musical and dance performances, theatrical performances, craft techniques, oral literature, etc.), when they occur and of which it is possible to keep memory only through the audio-visual recording that fixes them permanently, crystallizing them.</para>
    ///   <para>rdfs:label : Intangible Cultural Propertyrdfs:label : Bene immateriale</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/IntangibleCulturalProperty">r-arco:IntangibleCulturalProperty</a>
    /// </summary>
    let IntangibleCulturalProperty = _prefixId.prefix "IntangibleCulturalProperty"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta l'ambito di tutela del MiBAC (archeologico, architettonico e paesaggistico, etnoantropologico, storico artistico), nel quale ricade il bene culturale in esame.rdfs:comment : This class represents the MiBAC scope of protection (historical artistic, ethoanthropological, architectural landscape, archaeological) of a cultural property.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : MiBAC Scope of protectionrdfs:label : Ambito di tutela MiBAC</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/MibacScopeOfProtection">r-arco:MibacScopeOfProtection</a>
    /// </summary>
    let MibacScopeOfProtection = _prefixId.prefix "MibacScopeOfProtection"
    /// <summary>
    ///   <para>rdfs:label : Movable Cultural Propertyrdfs:label : Bene mobile</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene materiale mobile, cioè un oggetto o un manufatto che può essere movimentato in vario modo. I beni mobili possono risultare "immobilizzati per destinazione", cioè incorporati saldamente nel contesto in cui si trovano.rdfs:comment : This class represents a movable cultural property, that is, an object or an artefact that can be moved in various ways. Movable cultural properties may be "immobilized by destination", i.e. incorporated firmly in the context in which they are located.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/MovableCulturalProperty">r-arco:MovableCulturalProperty</a>
    /// </summary>
    let MovableCulturalProperty = _prefixId.prefix "MovableCulturalProperty"
    /// <summary>
    ///   <para>rdfs:label : Music Heritagerdfs:label : Bene Musicale</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale musicale. Strumenti musicali: oggetti nati appositamente per produrre suoni organizzati secondo le diverse culture musicali, senza limiti spazio-temporali (strumenti e accessori di interesse archeologico, storico artistico, etnoantropologico). Strumenti musicali-Organo: oggetto nato per produrre suoni,  costituito da una serie di canne metalliche,  di forma, lunghezza e diametro diversi, nelle quali viene immessa, per mezzo di un mantice o altro meccanismo, una quantità d’aria regolata da una o più tastiere e da una pedaliera (corredato da accessori), caratterizzato da specifici aspetti  morfologici-decorativi e fonico-strumentali (organo idraulico, organo positivo, organo portativo, organo elettronico ecc.)rdfs:comment : This class represents a music heritage. Musical instruments: objects created specifically to produce sounds according to different musical cultures, without space-time limits (instruments and accessories of archaeological, artistic, ethno-anthropological interest). Musical instruments-Organ: an object created to produce sounds, consisting of a series of metal rods, of different shape, length and diameter, in which a quantity of air is introduced, by means of a bellows or other mechanism, regulated by one or more keyboards and a pedal board (accompanied by accessories), characterized by specific morphological-decorative and phonic-instrumental aspects (hydraulic organ, positive organ, portative organ, electronic organ, etc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/MusicHeritage">r-arco:MusicHeritage</a>
    /// </summary>
    let MusicHeritage = _prefixId.prefix "MusicHeritage"

    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta una classificazione relativa a uno strumento musicale, secondo la classificazione di Hornbostel-Sachs ed eventualmente anche secondo altre classificazioni.rdfs:comment : This class represents a classification concerning a musical instrument, concerning the Hornbostel-Sachs classification or possibily other classifications.</para>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Classificazione di strumento musicalerdfs:label : Musical instrument classification</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/MusicalInstrumentClassification">r-arco:MusicalInstrumentClassification</a>
    /// </summary>
    let MusicalInstrumentClassification =
        _prefixId.prefix "MusicalInstrumentClassification"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Bene Naturalisticordfs:label : Natural Heritage</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale naturalistico, relativo ai campi della botanica, della mineralogia, della paleontologia, della petrologia, della planetologia, della zoologia. Botanica: esemplari del mondo vegetale provenienti da collezioni di botanica  (raccolte di piante essiccate: erbari). Mineralogia: esemplari di minerali provenienti da collezioni di mineralogia (Augite, Goethite, scatola di quarzi ecc. ). Paleontologia: reperti fossili (animali, vegetali, ichnofossili, campioni e preparati per microscopio, ecc.). Petrologia: esemplari di rocce provenienti da collezioni (Riolite, Trachiandesite ecc). Planetologia: esemplari di meteoriti provenienti da collezioni ( Aubrite, Ureilite, Eucrite ecc.). Zoologia: esemplari del mondo animale provenienti da collezioni di zoologia (ustiolo, toporagno, mammifero, artropode, scatola di farfalle, collezione elmintologica, ecc.)rdfs:comment : This class represents a natural heritage, related to botany, mineralogy, paleontology, petrology, planetary science, zoology. Botany: specimens of the plant world from botanical collections (collections of dried plants: herbaria). Mineralogy: specimens of minerals from collections of mineralogy (Augite, Goethite, box of quartz etc.). Paleontology: fossil finds (animals, plants, ichnofossils, samples and microscope preparations, etc.). Petrology: specimens of rocks from collections (Riolite, Trachiandesite etc.). Planetology: meteorites from collections (Aubrite, Ureilite, Eucrite, etc.). Zoology: specimens of the animal world from zoology collections (ustiolo, shrew, mammal, arthropod, butterfly box, elmintological collection, etc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/NaturalHeritage">r-arco:NaturalHeritage</a>
    /// </summary>
    let NaturalHeritage = _prefixId.prefix "NaturalHeritage"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale numismatico, ovvero monete e altri oggetti di interesse numismatico (reperti premonetali e paramonetali, conii e punzoni monetali, pesi per il controllo monetale, sigilli e medaglie), pertinenti a  qualsiasi epoca.rdfs:comment : This class represents a numismatic property, that is coins and other objects of numismatic interest (premonetal and paramonetal finds, coinage and monetary punches, weights for monetary control, seals and medals), pertinent to any age.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Numismatic Propertyrdfs:label : Bene Numismatico</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/NumismaticProperty">r-arco:NumismaticProperty</a>
    /// </summary>
    let NumismaticProperty = _prefixId.prefix "NumismaticProperty"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU 4.00: OG/OGT/OGTH^^xsd:string</para>
    ///   <para>rdfs:label : Numismatic property classificationrdfs:label : Classificazione di bene numismatico</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la categoria funzionale di un bene numismatico, in riferimento a una classificazione relativa alla funzione, o alla destinazione, o alla committenza del bene catalogato, secondo le classificazioni più consuete.rdfs:comment : This class represents a functional category of a numismatic property, referring to a classification related to the function or the commission of the cultural property, according to the most common classifications.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/NumismaticPropertyCategory">r-arco:NumismaticPropertyCategory</a>
    /// </summary>
    let NumismaticPropertyCategory = _prefixId.prefix "NumismaticPropertyCategory"
    /// <summary>
    ///   <para>rdfs:label : Photographic Heritagerdfs:label : Bene Fotografico</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale fotografico, che può essere una fotografia o un fondo fotografico. Beni fotografici: negativi, positivi, processi fotografici che danno origine a prodotti unici (dagherrotipi, ferrotipi, polaroid, chimigrammi, ecc.), fotografia digitale; elementi complessi come album, cartelle, fotomontaggi, panorami, porfolii. Fondi fotografici: entità concettuali che si caratterizzano per l'accumulo di più unità fisiche omogenee o eterogenee dal punto di vista dei materiali che li compongono e che acquisiscono nella loro totalità valenza di bene culturale.rdfs:comment : This class represents a photographic heritage. Photographs: negative, positive, photographic processes that give rise to unique products (daguerreotypes, ferrotypes, polaroids, chimigrams, etc.), digital photography; complex elements like albums, folders, photomontages, panoramas, porfolii. Photographic funds: conceptual entities that are characterized by the accumulation of multiple homogeneous or heterogeneous physical units from the point of view of the materials that compose them and which represent in their totality a cultural heritage.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/PhotographicHeritage">r-arco:PhotographicHeritage</a>
    /// </summary>
    let PhotographicHeritage = _prefixId.prefix "PhotographicHeritage"

    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta una classificazione di un bene fotografico secondo un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.rdfs:comment : This class represents a photographic entity's classification accorting to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00: SG/CLF^^xsd:string</para>
    ///   <para>rdfs:label : Photographic heritage classificationrdfs:label : Classificazione di bene fotografico</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/PhotographicHeritageClassification">r-arco:PhotographicHeritageClassification</a>
    /// </summary>
    let PhotographicHeritageClassification =
        _prefixId.prefix "PhotographicHeritageClassification"

    /// <summary>
    ///   <para>rdfs:label : Photographic heritage classification typerdfs:label : Tipo di classificazione di bene fotografico</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents photographic property's classification type,, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.rdfs:comment : Questa classe rappresenta il tipo di classificazione di un bene fotografico, relativamente a un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: SG/CLF/CLFT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/PhotographicHeritageClassificationType">r-arco:PhotographicHeritageClassificationType</a>
    /// </summary>
    let PhotographicHeritageClassificationType =
        _prefixId.prefix "PhotographicHeritageClassificationType"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RF/RFI^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'identificatore a radiofrequenza RFId.rdfs:comment : This class represents the radio-frequency identification (RFID).</para>
    ///   <para>rdfs:label : Identificativo RFIdrdfs:label : RFId Identifier</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/RFId">r-arco:RFId</a>
    /// </summary>
    let RFId = _prefixId.prefix "RFId"
    /// <summary>
    ///   <para>rdfs:label : Legenda tipordfs:label : Reference coin legend</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the reference coin legend.rdfs:comment : Questa classe rappresenta la legenda tipo di un bene numismatico, inteso come parametro di classificazione attestato nei repertori di riferimento.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: OG/OGT/OGTL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ReferenceCoinLegend">r-arco:ReferenceCoinLegend</a>
    /// </summary>
    let ReferenceCoinLegend = _prefixId.prefix "ReferenceCoinLegend"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Bene Scientifico o Tecnologicordfs:label : Scientific Or Technological Heritage</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene culturale scientifico e tecnologico, ovvero strumenti di interesse per la storia della scienza e della tecnica (strumenti astronomici, di laboratorio, di misurazione ecc.) pertinenti a qualsiasi epoca e afferenti a specifiche discipline scientifiche ( apparecchio a specchi a piani rotanti, apparecchio per gli anelli colorati di Newton, campana di Savart, orologio di Farina, orologio solare, pendola, sestante, telescopio ecc.); macchine e macchinari, mezzi di trasporto ecc.rdfs:comment : This class represents a scientific and technological heritage, that is instruments of interest to the history of science and technology (astronomical, laboratory, measurement, etc.) relevant to any age and related to specific scientific disciplines (flat-mirror luminaire rotating, apparatus for the colored rings of Newton, bell of Savart, Farina clock, solar clock, pendulum, sextant, telescope, etc.); machines and machinery, means of transport, etc.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ScientificOrTechnologicalHeritage">r-arco:ScientificOrTechnologicalHeritage</a>
    /// </summary>
    let ScientificOrTechnologicalHeritage =
        _prefixId.prefix "ScientificOrTechnologicalHeritage"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Bene materialerdfs:label : Tangible Cultural Property</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un bene materiale, cioè fisicamente tangibile, sia mobile che immobile.rdfs:comment : This class represents a tangible cultural property, either immovable or movable.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/TangibleCulturalProperty">r-arco:TangibleCulturalProperty</a>
    /// </summary>
    let TangibleCulturalProperty = _prefixId.prefix "TangibleCulturalProperty"
    /// <summary>
    ///   <para>rdfs:label : Thematic categoryrdfs:label : Categoria tematica</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the thematic category associated to a cartographic classification of a cultural property (e.g.: Architecture).rdfs:comment : Questa classe rappresenta la categoria tematica associata alla classificazione cartografica di un bene culturale (es.: Architetture, Emergenze Archeologiche)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/ThematicCategory">r-arco:ThematicCategory</a>
    /// </summary>
    let ThematicCategory = _prefixId.prefix "ThematicCategory"
    /// <summary>
    ///   <para>rdfs:label : sigla identificativa del saggio stratigraficordfs:label : archaeological site identifier</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the archaeological site identifier.rdfs:comment : Questa proprietà rappresenta la sigla del saggio stratigrafico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SAS: OG/OGT/OGTI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/archaeologicalSiteIdentifier">r-arco:archaeologicalSiteIdentifier</a>
    /// </summary>
    let archaeologicalSiteIdentifier = _prefixId.prefix "archaeologicalSiteIdentifier"
    /// <summary>
    ///   <para>rdfs:label : identificativo del simbolo cartograficordfs:label : cartographic symbol identifier</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice identificativo attribuito al simbolo cartografico.rdfs:comment : This property represents the identifier associated to the cartographic symbol.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMS^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/cartographicSymbolIdentifier">r-arco:cartographicSymbolIdentifier</a>
    /// </summary>
    let cartographicSymbolIdentifier = _prefixId.prefix "cartographicSymbolIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the general catalogue number associated to a cultural property described by a catalogue record.rdfs:comment : Questa proprietà permette di associare il numero di catalogo generale a un bene culturale descritto in una scheda catalografica.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/NCT/NCTN^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : catalogue numberrdfs:label : numero catalogo generale</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/catalogueNumber">r-arco:catalogueNumber</a>
    /// </summary>
    let catalogueNumber = _prefixId.prefix "catalogueNumber"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00: SG/CLF/CLFS^^xsd:string</para>
    ///   <para>rdfs:label : classified subjectrdfs:label : soggetto classificato</para>
    ///   <para>rdfs:comment : This property represents the subject of a photographic heritage as described in a photographic heritage classification other than Iconclass.rdfs:comment : Questa proprietà rappresenta la descrizione codificata del/i soggetto/i raffigurato/i nell'opera secondo il sistema di classificazione scelto dall'Ente schedatore, in alternativa e/o in aggiunta ad Iconclass.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/classifiedSubject">r-arco:classifiedSubject</a>
    /// </summary>
    let classifiedSubject = _prefixId.prefix "classifiedSubject"

    /// <summary>
    ///   <para>rdfs:label : definizione e posizione delle parti componentirdfs:label : definition and position of components</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le informazioni sulla definizione e posizione delle parti componenti di un bene culturale complesso.rdfs:comment : This property represents information on definition and position of the components of a complex cultural property.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGC/OGCD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/definitionAndPositionOfComponents">r-arco:definitionAndPositionOfComponents</a>
    /// </summary>
    let definitionAndPositionOfComponents =
        _prefixId.prefix "definitionAndPositionOfComponents"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: MT/FVC/FVCV^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents notes on a digital photograph.rdfs:comment : Questa proprietà rappresenta le note relative alla fotografia digitale. Può rappresentare informazioni utili a identificare le intenzioni dell'autore in relazione alla visualizzazione o rioggettivazione della fotografia digitale, come la dimensione del quadro, la risoluzione di stampa e relativa unità di misura, altre indicazioni per la stampa (tipo stampante, correzioni cromatiche, ecc.), categoria, URL, ecc.</para>
    ///   <para>rdfs:label : digital photograph noterdfs:label : note sulla fotografia digitale</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/digitalPhotographNote">r-arco:digitalPhotographNote</a>
    /// </summary>
    let digitalPhotographNote = _prefixId.prefix "digitalPhotographNote"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la data di fine di un intervallo temporale, che può essere espressa secondo criteri diversi e a diverso livello di dettaglio (secolo, intervallo di secoli, anno, intervallo di anni, aaaa/mm/gg, periodo storico, etc.)rdfs:comment : This property represents the end time of a time interval, according to different criteria and level of detail (century, century interval, year, yyyy/mm/dd, historical period, etc.).</para>
    ///   <para>rdfs:label : data di finerdfs:label : end time</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/endTime">r-arco:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural property to a related scientific discipline, alternative to the main one.rdfs:comment : Questa proprietà permette di associare un bene culturale a discipline scientifiche, alternative a quella principale, cui fa riferimento.</para>
    ///   <para>rdfs:label : has alternative disciplinerdfs:label : ha altra disciplina</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa PST: CT/CTA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasAlternativeDiscipline">r-arco:hasAlternativeDiscipline</a>
    /// </summary>
    let hasAlternativeDiscipline = _prefixId.prefix "hasAlternativeDiscipline"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un materiale archeologico alla sua categoria (es.: ceramiche, industria litica, intonaco, legno, etc.)rdfs:comment : This property relates the archaeological material to its category (e.g.: ceramics, plaster, lithic materials, etc.)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has archaeological material categoryrdfs:label : ha categoria di materiale archeologico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa TMA: MA/MAC/MACC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasArchaeologicalMaterialCategory">r-arco:hasArchaeologicalMaterialCategory</a>
    /// </summary>
    let hasArchaeologicalMaterialCategory =
        _prefixId.prefix "hasArchaeologicalMaterialCategory"

    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural property to its cartographic classification.rdfs:comment : Questa proprietà collega un bene culturale alla sua classificazione cartografica.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha classificazione cartograficardfs:label : has cartographic classification</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCartographicClassification">r-arco:hasCartographicClassification</a>
    /// </summary>
    let hasCartographicClassification = _prefixId.prefix "hasCartographicClassification"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una classificazione cartografica di un bene cultural al simbolo cartografico, in riferimento al tema.rdfs:comment : This property relates a cartographic classification of a cultural property to the cartographic symbol related to the theme.</para>
    ///   <para>rdfs:label : has cartographic symbolrdfs:label : ha simbolo cartografico</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCartographicSymbol">r-arco:hasCartographicSymbol</a>
    /// </summary>
    let hasCartographicSymbol = _prefixId.prefix "hasCartographicSymbol"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha tema cartograficordfs:label : has cartographic theme</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMT^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates a cartographic classification of a cultural property to the cartographic theme.rdfs:comment : Questa proprietà collega una classificazione cartografica di un bene culturale al tema di riferimento.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCartographicTheme">r-arco:hasCartographicTheme</a>
    /// </summary>
    let hasCartographicTheme = _prefixId.prefix "hasCartographicTheme"
    /// <summary>
    ///   <para>rdfs:label : has cataloguing agencyrdfs:label : ha ente schedatore</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural property to its cagaloguing agency. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.rdfs:comment : Questa proprietà rappresenta la relazione che collega un bene culturale al relativo ente schedatore. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/ESC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCataloguingAgency">r-arco:hasCataloguingAgency</a>
    /// </summary>
    let hasCataloguingAgency = _prefixId.prefix "hasCataloguingAgency"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGT/OGTV^^xsd:string</para>
    ///   <para>rdfs:label : has cultural property cataloguing categoryrdfs:label : ha categoria di bene culturale basata su catalogazione</para>
    ///   <para>rdfs:comment : This property relates a cultural property to a category based on a subjective evaluation of the cataloguing agent, during the cataloguing process.rdfs:comment : Questa proprietà collega un bene culturale a una categoria basata su una valutazione soggettiva del catalogatore durante il processo di catalogazione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyCataloguingCategory">r-arco:hasCulturalPropertyCataloguingCategory</a>
    /// </summary>
    let hasCulturalPropertyCataloguingCategory =
        _prefixId.prefix "hasCulturalPropertyCataloguingCategory"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha categoriardfs:label : has cultural property category</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale alla sua categoria.rdfs:comment : This property relates a cultural property to its category.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyCategory">r-arco:hasCulturalPropertyCategory</a>
    /// </summary>
    let hasCulturalPropertyCategory = _prefixId.prefix "hasCulturalPropertyCategory"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale complesso a una delle sue parti componenti.rdfs:comment : This property relates a cultural property to its components.</para>
    ///   <para>rdfs:label : has cultural property componentrdfs:label : ha parte componente di bene culturale</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyComponent">r-arco:hasCulturalPropertyComponent</a>
    /// </summary>
    let hasCulturalPropertyComponent = _prefixId.prefix "hasCulturalPropertyComponent"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has cultural property inventory categoryrdfs:label : ha categoria basata su repertorio</para>
    ///   <para>rdfs:comment : This property relates a cultural property to a category based on a classification related to an inventory approved by the specific subject area.rdfs:comment : Questa proprietà collega un bene culturale a una categoria basata su una classificazione relativa a un repertorio riconosciuto dallo specifico ambito disciplinare.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGT/OGTS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyInventoryCategory">r-arco:hasCulturalPropertyInventoryCategory</a>
    /// </summary>
    let hasCulturalPropertyInventoryCategory =
        _prefixId.prefix "hasCulturalPropertyInventoryCategory"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale alla/alle sua/e parte/i residuale/i.rdfs:comment : This property relates a cultural property to its residual.</para>
    ///   <para>rdfs:label : ha parte residuale di bene culturalerdfs:label : has cultural property residual</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTW^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyResidual">r-arco:hasCulturalPropertyResidual</a>
    /// </summary>
    let hasCulturalPropertyResidual = _prefixId.prefix "hasCulturalPropertyResidual"
    /// <summary>
    ///   <para>rdfs:label : has heritage protection agencyrdfs:label : ha ente competente per la tutela</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural property to its heritage protection agency. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.rdfs:comment : Questa proprietà rappresenta la relazione che collega un bene culturale al relativo ente competente per la tutela. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/ECP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasHeritageProtectionAgency">r-arco:hasHeritageProtectionAgency</a>
    /// </summary>
    let hasHeritageProtectionAgency = _prefixId.prefix "hasHeritageProtectionAgency"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural property to the main related scientific discipline.rdfs:comment : Questa proprietà permette di associare un bene culturale alla disciplina scientifica più importante, o storicamente riconosciuta, cui fa riferimento.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa PST: CT/CTP^^xsd:string</para>
    ///   <para>rdfs:label : ha disciplina principalerdfs:label : has main discipline</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasMainDiscipline">r-arco:hasMainDiscipline</a>
    /// </summary>
    let hasMainDiscipline = _prefixId.prefix "hasMainDiscipline"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/AMB^^xsd:string</para>
    ///   <para>rdfs:label : ha ambito di tutelardfs:label : has MiBAC scope of protection</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural property to ist MiBAC scope of protectionrdfs:comment : Questa proprietà associa un bene culturale all'ambito di tutela nel quale ricade.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasMibacScopeOfProtection">r-arco:hasMibacScopeOfProtection</a>
    /// </summary>
    let hasMibacScopeOfProtection = _prefixId.prefix "hasMibacScopeOfProtection"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has musical instrument classificationrdfs:label : ha classificazione di strumento musicale</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene musicale a una classificazione con cui lo strumento può essere codificato.rdfs:comment : This property connects a cultural entity to a classification through which the instrument can be coded.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasMusicalInstrumentClassification">r-arco:hasMusicalInstrumentClassification</a>
    /// </summary>
    let hasMusicalInstrumentClassification =
        _prefixId.prefix "hasMusicalInstrumentClassification"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene numismatico a una sua categoria.rdfs:comment : This property relates a numismatic property to one of its categories.</para>
    ///   <para>rdfs:label : has numismatic property categoryrdfs:label : ha categoria di bene numismatico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU 4.00: OG/OGT/OGTH^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasNumismaticPropertyCategory">r-arco:hasNumismaticPropertyCategory</a>
    /// </summary>
    let hasNumismaticPropertyCategory = _prefixId.prefix "hasNumismaticPropertyCategory"

    /// <summary>
    ///   <para>rdfs:label : ha classificazione di bene fotograficordfs:label : has photographic heritage classification</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00: SG/CLF^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects a photographic property to a photographic property's classification, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.rdfs:comment : Questa proprietà collega un bene fotografico a una classificazione di un bene fotografico secondo un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassification">r-arco:hasPhotographicHeritageClassification</a>
    /// </summary>
    let hasPhotographicHeritageClassification =
        _prefixId.prefix "hasPhotographicHeritageClassification"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: SG/CLF/CLFT^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects a photographic property's classification to the classification type, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.rdfs:comment : Questa proprietà collega una classificazione di un bene fotografico al tipo di classificazione, relativamente a un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha tipo di classificazione di bene fotograficordfs:label : has photographic heritage classification type</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassificationType">r-arco:hasPhotographicHeritageClassificationType</a>
    /// </summary>
    let hasPhotographicHeritageClassificationType =
        _prefixId.prefix "hasPhotographicHeritageClassificationType"

    /// <summary>
    ///   <para>rdfs:label : ha identificativo RFIdrdfs:label : has RFId identifier</para>
    ///   <para>rdfs:comment : This property relates an object to an RFId.rdfs:comment : Questa proprietà collega un oggetto a un identificatore a radiofrequenza RFId.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasRFId">r-arco:hasRFId</a>
    /// </summary>
    let hasRFId = _prefixId.prefix "hasRFId"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: OG/OGT/OGTL^^xsd:string</para>
    ///   <para>rdfs:label : has reference coin legendrdfs:label : ha legenda tipo</para>
    ///   <para>rdfs:comment : This property relates a numismatic property with its reference coin legend.rdfs:comment : Questa proprietà collega un bene numismatico alla sua legenda tipo.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasReferenceCoinLegend">r-arco:hasReferenceCoinLegend</a>
    /// </summary>
    let hasReferenceCoinLegend = _prefixId.prefix "hasReferenceCoinLegend"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega un bene culturale a un ente che riveste un ruolo nei suoi confronti. La relazione tra il ruolo e l'ente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. La proprietà è specializzata per mezzo di sottoproprietà. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.rdfs:comment : This property relates a cultural property to an agency that plays a role related to the cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has related agencyrdfs:label : ha ente collegato</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasRelatedAgency">r-arco:hasRelatedAgency</a>
    /// </summary>
    let hasRelatedAgency = _prefixId.prefix "hasRelatedAgency"
    /// <summary>
    ///   <para>rdfs:label : ha categoria tematicardfs:label : has thematic category</para>
    ///   <para>rdfs:comment : Questa proprietà collega una classificazione cartografica di un bene culturale alla categoria tematica.rdfs:comment : This property relates a cartographic classification of a cultural property to the thematic category.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CT/CTM/CTMC^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/hasThematicCategory">r-arco:hasThematicCategory</a>
    /// </summary>
    let hasThematicCategory = _prefixId.prefix "hasThematicCategory"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il numero di codice internazionale che identifica un bene scientifico e tecnologico. All'indirizzo http://www.isin.org/ è possibile reperire tutte le specifiche per l'adesione al progetto e l'attribuzione del codice internazionale. Il Registro Online è un database che raccoglie informazioni su strumenti scientifici di interesse storico promosso dal Museum of the History of Science di Oxford in collaborazione con la Commissione Strumenti Scientifici dell'International Union of the History and Philosophy of Science.rdfs:comment : This property represents the international identifier of a scientific or technological heritage. More info can be found at https://www.isin.org/</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : international identifierrdfs:label : codice internazionale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa PST: AC/ACI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/internationalIdentifier">r-arco:internationalIdentifier</a>
    /// </summary>
    let internationalIdentifier = _prefixId.prefix "internationalIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a scientific discipline, alternative to the main one, related to a cultural property to that cultural property.rdfs:comment : Questa proprietà permette di associare discipline scientifiche, alternative a quella principale, cui un bene culturale fa riferimento, al bene culturale stesso.</para>
    ///   <para>rdfs:label : è altra disciplina dirdfs:label : is alternative discipline of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isAlternativeDisciplineOf">r-arco:isAlternativeDisciplineOf</a>
    /// </summary>
    let isAlternativeDisciplineOf = _prefixId.prefix "isAlternativeDisciplineOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha categoria di materiale archeologico".rdfs:comment : This is the inverse property of "has archaeological material category of".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is archaeological material category ofrdfs:label : è categoria di materiale archeologico</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isArchaeologicalMaterialCategoryOf">r-arco:isArchaeologicalMaterialCategoryOf</a>
    /// </summary>
    let isArchaeologicalMaterialCategoryOf =
        _prefixId.prefix "isArchaeologicalMaterialCategoryOf"

    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has cartographic classification".rdfs:comment : Questa è la proprietà inversa di "ha classificazione cartografica".</para>
    ///   <para>rdfs:label : è classificazione cartografica dirdfs:label : is cartographic classification of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCartographicClassificationOf">r-arco:isCartographicClassificationOf</a>
    /// </summary>
    let isCartographicClassificationOf =
        _prefixId.prefix "isCartographicClassificationOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha simbolo cartografico".rdfs:comment : This is the inverse property of "has cartographic symbol".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is cartographic symbol ofrdfs:label : è simbolo cartografico di</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCartographicSymbolOf">r-arco:isCartographicSymbolOf</a>
    /// </summary>
    let isCartographicSymbolOf = _prefixId.prefix "isCartographicSymbolOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tema cartografico".rdfs:comment : This is the inverse property of "has cartographic theme".</para>
    ///   <para>rdfs:label : è tema cartografico dirdfs:label : is cartographic theme of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCartographicThemeOf">r-arco:isCartographicThemeOf</a>
    /// </summary>
    let isCartographicThemeOf = _prefixId.prefix "isCartographicThemeOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la relazione che collega un ente schedatore al relativo bene culturale che ha schedato. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.rdfs:comment : This property relates a cagaloguing agency to the catalogued cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    ///   <para>rdfs:label : is cataloguing agency ofrdfs:label : è ente schedatore di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/ESC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCataloguingAgencyOf">r-arco:isCataloguingAgencyOf</a>
    /// </summary>
    let isCataloguingAgencyOf = _prefixId.prefix "isCataloguingAgencyOf"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is cultural property cataloguing category ofrdfs:label : è categoria di bene culturale basata su catalogazione di</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha categoria di bene culturale basata su catalogazione".rdfs:comment : This is the inverse property of "has cultural property cataloguing category of".</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCulturalPropertyCataloguingCategoryOf">r-arco:isCulturalPropertyCataloguingCategoryOf</a>
    /// </summary>
    let isCulturalPropertyCataloguingCategoryOf =
        _prefixId.prefix "isCulturalPropertyCataloguingCategoryOf"

    /// <summary>
    ///   <para>rdfs:label : è categoria di bene culturalerdfs:label : is cultural property category of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has cultural property category".rdfs:comment : Questa è la proprietà inversa di "ha categoria".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCulturalPropertyCategoryOf">r-arco:isCulturalPropertyCategoryOf</a>
    /// </summary>
    let isCulturalPropertyCategoryOf = _prefixId.prefix "isCulturalPropertyCategoryOf"
    /// <summary>
    ///   <para>rdfs:label : is cultural property component ofrdfs:label : è parte componente di bene culturale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha componente", collega una delle parti componenti di un bene culturale complesso al bene complesso stesso.rdfs:comment : This property, inverse of "has component", relates a component of a complex cultural property to the complex cultural property.</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCulturalPropertyComponentOf">r-arco:isCulturalPropertyComponentOf</a>
    /// </summary>
    let isCulturalPropertyComponentOf = _prefixId.prefix "isCulturalPropertyComponentOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGT/OGTS^^xsd:string</para>
    ///   <para>rdfs:label : is cultural property inventory category ofrdfs:label : è categoria basata su repertorio di</para>
    ///   <para>rdfs:comment : Questa proprietà collega una categoria basata su una classificazione relativa a un repertorio riconosciuto dallo specifico ambito disciplinare a un bene culturale.rdfs:comment : This property relates a category based on a classification related to an inventory approved by the specific subject area to a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCulturalPropertyInventoryCategoryOf">r-arco:isCulturalPropertyInventoryCategoryOf</a>
    /// </summary>
    let isCulturalPropertyInventoryCategoryOf =
        _prefixId.prefix "isCulturalPropertyInventoryCategoryOf"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property, inverse of "has residual", relates a residual of a cultural property to the cultural property.rdfs:comment : Questa proprietà, inversa a "ha parte residuale", collega una parte residuale di un bene culturale al bene culturale stesso.</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTW^^xsd:string</para>
    ///   <para>rdfs:label : is cultural property residual ofrdfs:label : è parte residuale di bene culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isCulturalPropertyResidualOf">r-arco:isCulturalPropertyResidualOf</a>
    /// </summary>
    let isCulturalPropertyResidualOf = _prefixId.prefix "isCulturalPropertyResidualOf"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/ECP^^xsd:string</para>
    ///   <para>rdfs:label : is heritage protection agency ofrdfs:label : è ente competente per la tutela di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an heritage protection agency to the cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.rdfs:comment : Questa proprietà rappresenta la relazione che collega un ente competente per la tutela al relativo bene culturale della cui tutela è competente. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isHeritageProtectionAgencyOf">r-arco:isHeritageProtectionAgencyOf</a>
    /// </summary>
    let isHeritageProtectionAgencyOf = _prefixId.prefix "isHeritageProtectionAgencyOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare la disciplina scientifica principale, cui un bene culturale fa riferimento, al bene culturale stesso.rdfs:comment : This property relates the main scientific discipline related to a cultural property to that cultural property.</para>
    ///   <para>rdfs:label : is main discipline ofrdfs:label : è disciplina principale di</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isMainDisciplineOf">r-arco:isMainDisciplineOf</a>
    /// </summary>
    let isMainDisciplineOf = _prefixId.prefix "isMainDisciplineOf"
    /// <summary>
    ///   <para>rdfs:label : is MiBAC scope of protection ofrdfs:label : è ambito di tutela di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has MiBAC scope of protection".rdfs:comment : Questa è la proprietà inversa di "ha ambito di tutela".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isMibacScopeOfProtectionOf">r-arco:isMibacScopeOfProtectionOf</a>
    /// </summary>
    let isMibacScopeOfProtectionOf = _prefixId.prefix "isMibacScopeOfProtectionOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha classificazione di bene musicale", collega un una classificazione con cui uno strumento musicale può essere codificato al bene musicale.</para>
    ///   <para>rdfs:label : is musical instrument classification ofrdfs:label : è classificazione di strumento musicale di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isMusicalInstrumentClassificationOf">r-arco:isMusicalInstrumentClassificationOf</a>
    /// </summary>
    let isMusicalInstrumentClassificationOf =
        _prefixId.prefix "isMusicalInstrumentClassificationOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una categoria di bene numismatico al bene numismatico cui si riferisce.</para>
    ///   <para>rdfs:label : is numismatic property category ofrdfs:label : è categoria di bene numismatico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU 4.00: OG/OGT/OGTH^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isNumismaticPropertyCategoryOf">r-arco:isNumismaticPropertyCategoryOf</a>
    /// </summary>
    let isNumismaticPropertyCategoryOf =
        _prefixId.prefix "isNumismaticPropertyCategoryOf"

    /// <summary>
    ///   <para>rdfs:label : is photographic heritage classification ofrdfs:label : è classificazione di bene fotografico di</para>
    ///   <para>owl:versionInfo : Questa proprietà, inversa a "ha classificazione di bene fotografico", collega una classificazione di un bene fotografico secondo un sistema di classificazione alternativo a Iconclass, a un bene fotografico.owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationOf">r-arco:isPhotographicHeritageClassificationOf</a>
    /// </summary>
    let isPhotographicHeritageClassificationOf =
        _prefixId.prefix "isPhotographicHeritageClassificationOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di classificazione di bene fotografico".rdfs:comment : This is the inverse property of "has photographic heritage classification type".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è tipo di classificazione di bene fotograficordfs:label : is photographic heritage classification type of</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationTypeOf">r-arco:isPhotographicHeritageClassificationTypeOf</a>
    /// </summary>
    let isPhotographicHeritageClassificationTypeOf =
        _prefixId.prefix "isPhotographicHeritageClassificationTypeOf"

    /// <summary>
    ///   <para>rdfs:label : is RFId identifier ofrdfs:label : è identificativo RFId di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a radio-frequency identification (RFID) to an object.rdfs:comment : Questa proprietà collega un identificatore a radiofrequenza RFId a un oggetto.</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isRFIdOf">r-arco:isRFIdOf</a>
    /// </summary>
    let isRFIdOf = _prefixId.prefix "isRFIdOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha legenda tipo".rdfs:comment : This is the inverse property of "ha reference coin legend".</para>
    ///   <para>rdfs:label : is reference coin legend ofrdfs:label : è legenda tipo di</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isReferenceCoinLegendOf">r-arco:isReferenceCoinLegendOf</a>
    /// </summary>
    let isReferenceCoinLegendOf = _prefixId.prefix "isReferenceCoinLegendOf"
    /// <summary>
    ///   <para>rdfs:comment : This property, inverse of "has related agency", relates an agency that plays a role related to a cultural property to that cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.rdfs:comment : Questa proprietà, inversa a "ha ente collegato", rappresenta la relazione che collega un ente che riveste un ruolo nei confronti di un bene culturale al bene culturale stesso. La relazione tra il ruolo e l'ente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. La proprietà è specializzata per mezzo di sottoproprietà. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>rdfs:label : is related agency ofrdfs:label : è ente collegato a</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isRelatedAgencyOf">r-arco:isRelatedAgencyOf</a>
    /// </summary>
    let isRelatedAgencyOf = _prefixId.prefix "isRelatedAgencyOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è categoria tematica dirdfs:label : is thematic category of</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha categoria tematica".rdfs:comment : This is the inverse property of "has thematic category".</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/isThematicCategoryOf">r-arco:isThematicCategoryOf</a>
    /// </summary>
    let isThematicCategoryOf = _prefixId.prefix "isThematicCategoryOf"
    /// <summary>
    ///   <para>rdfs:label : musical instrument noterdfs:label : note sullo strumento musicale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents notes on a musical instrument.rdfs:comment : Questa proprietà rappresenta le note relative agli aspetti acustici di uno strumento musicale, ed eventualmente anche relative ai rilevamenti e ai criteri adottati in sede di restauro.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: AA/AAS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/musicalInstrumentNote">r-arco:musicalInstrumentNote</a>
    /// </summary>
    let musicalInstrumentNote = _prefixId.prefix "musicalInstrumentNote"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : numero di materiali archeologici componentirdfs:comment : This property represents the total quantity of an archaeological material that is part of a lot of archaeological materials.rdfs:comment : Questa proprietà rappresenta la quantità complessiva di uno stesso materiale archeologico componente di un lotto di materiali.</para>
    ///   <para>rdfs:label : number of archeological materials</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa TMA: MA/MAC/MACQ^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/numberOfArchaeologicalMaterials">r-arco:numberOfArchaeologicalMaterials</a>
    /// </summary>
    let numberOfArchaeologicalMaterials =
        _prefixId.prefix "numberOfArchaeologicalMaterials"

    /// <summary>
    ///   <para>rdfs:comment : This property represents the number of components of a complex cultural property.rdfs:comment : Questa proprietà rappresenta il numero di esemplari/oggetti/elementi componenti di un bene culturale. Nel caso di un bene complesso identificato come serie o come insieme, si usa per specificare il numero, espresso in cifre, degli esemplari o degli oggetti componenti, oppure degli elementi componenti nel caso in cui il bene sia un insieme o una serie i cui esemplari/oggetti componenti comprendono ciascuno più elementi. Il range della proprietà è rdfs:Literal perché, nei casi in cui non sia stato possibile rilevare per motivi pratici la consistenza numerica, il valore della proprietà sarà "QNR".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/QNT/QNTN; OG/QNT/QNTI; OG/QNT/QNTS^^xsd:string</para>
    ///   <para>rdfs:label : number of componentsrdfs:label : numero di oggetti/elementi componenti</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/numberOfComponents">r-arco:numberOfComponents</a>
    /// </summary>
    let numberOfComponents = _prefixId.prefix "numberOfComponents"
    /// <summary>
    ///   <para>rdfs:label : numero di parte di bene culturalerdfs:label : number of cultural property part</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: EL/ELE/ELEM^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents the number of specimens of the same cultural property part (es.: the number of the teeth of an anthropological material).rdfs:comment : Questa proprietà rappresenta il numero di esemplari di una stessa parte di un bene culturale (es.: il numero di denti di un reperto antropologico)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/numberOfCulturalPropertyParts">r-arco:numberOfCulturalPropertyParts</a>
    /// </summary>
    let numberOfCulturalPropertyParts = _prefixId.prefix "numberOfCulturalPropertyParts"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the number of members of a cultural property that is a collection (e.g.: series)rdfs:comment : Questa proprietà rappresenta il numero di membri di un bene culturale che si identifica come una collezione (es.: serie)</para>
    ///   <para>rdfs:label : number of membersrdfs:label : numero di membri</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/QNT/QNTN; OG/QNT/QNTI; OG/QNT/QNTS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/numberOfMembers">r-arco:numberOfMembers</a>
    /// </summary>
    let numberOfMembers = _prefixId.prefix "numberOfMembers"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the number of parts of an entity.rdfs:comment : Questa proprietà rappresenta il numero di parti di un'entità.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : numero di partirdfs:label : number of parts</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/numberOfParts">r-arco:numberOfParts</a>
    /// </summary>
    let numberOfParts = _prefixId.prefix "numberOfParts"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il numero di parti residuali, nel caso in cui si stia descrivendo un bene di cui si conservano più parti residuali.rdfs:comment : This property represents the number of residuals (only if more than one) of a cultural property.</para>
    ///   <para>rdfs:label : number of cultural property residual partsrdfs:label : numero di parti residuali di bene culturale</para>
    ///   <para>ctlog:iccdNormTag : OG/QNT/QNTR^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/numberOfResiduals">r-arco:numberOfResiduals</a>
    /// </summary>
    let numberOfResiduals = _prefixId.prefix "numberOfResiduals"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/NCT/NCTN^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents the "region identifier" associated to a cultural property described by a catalogue record.rdfs:comment : Questa proprietà permette di associare il codice regione a un bene culturale descritto in una scheda catalografica.</para>
    ///   <para>rdfs:label : region identifierrdfs:label : codice regione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/regionIdentifier">r-arco:regionIdentifier</a>
    /// </summary>
    let regionIdentifier = _prefixId.prefix "regionIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la data di inizio di un intervallo temporale, che può essere espressa secondo criteri diversi e a diverso livello di dettaglio (secolo, intervallo di secoli, anno, intervallo di anni, aaaa/mm/gg, periodo storico, etc.)rdfs:comment : This property represents the start time of a time interval, according to different criteria and level of detail (century, century interval, year, yyyy/mm/dd, historical period, etc.).</para>
    ///   <para>rdfs:label : start timerdfs:label : data di inizio</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/startTime">r-arco:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà permette di associare il suffisso a un bene culturale descritto in una scheda catalografica.rdfs:comment : This property represents the "suffix" associated to a cultural property described by a catalogue record.</para>
    ///   <para>rdfs:label : suffixrdfs:label : suffisso</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CD/NCT/NCTS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/suffix">r-arco:suffix</a>
    /// </summary>
    let suffix = _prefixId.prefix "suffix"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : Normativa SM 4.00: CL/CLA/CLAT^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the taxon code and the taxon definition associated to the musical instrument, according to a musical instrument classification.rdfs:comment : Questa proprietà rappresenta il codice tassonomico e la definizione attribuiti allo strumento musicale schedato nell'ambito del sistema di classificazione preso in considerazione.</para>
    ///   <para>rdfs:label : taxonrdfs:label : taxon</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/taxon">r-arco:taxon</a>
    /// </summary>
    let taxon = _prefixId.prefix "taxon"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the unique identifier (derived as the concatenation of the region identifier, the catalogue number and the suffix) of a cultural property describey by a catalogue record.rdfs:comment : Questa proprietà permette di associare il codice univoco (ricavato dalla concatenazione di codice regione, numero di catalogo generale ed eventuale suffisso) a un bene culturale descritto in una scheda catalografica.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: concat(CD/NCT/NCTR + CD/NCT/NCTN + CD/NCT/NCTS)^^xsd:string</para>
    ///   <para>rdfs:label : unique identifierrdfs:label : codice univoco</para>
    ///   <a href="https://w3id.org/arco/ontology/arco/uniqueIdentifier">r-arco:uniqueIdentifier</a>
    /// </summary>
    let uniqueIdentifier = _prefixId.prefix "uniqueIdentifier"
