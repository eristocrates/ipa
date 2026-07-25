namespace https.w3id.org.arco.ontology.arco.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module r_arco =
    let _namespace_iri = Namespace_Iri r_arco |> NamespaceIRI

    /// <summary>
    ///   <para>r-arco:CulturalPropertyCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a complex cultural property, when it is a series or a set.</para>
    ///   <para>Questa classe rappresenta un bene culturale complesso, quando questo si configuri come una serie o un insieme.</para>
    /// labels<para>Cultural Property Collection</para><para>Insieme di beni culturali</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyCollection">https://w3id.org/arco/ontology/arco/CulturalPropertyCollection</seealso>
    let CulturalPropertyCollection =
        Prefixed_Name(r_arco, "CulturalPropertyCollection") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasThematicCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cartographic classification of a cultural property to the thematic category.</para>
    ///   <para>Questa proprietà collega una classificazione cartografica di un bene culturale alla categoria tematica.</para>
    /// labels<para>ha categoria tematica</para><para>has thematic category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasThematicCategory">https://w3id.org/arco/ontology/arco/hasThematicCategory</seealso>
    let hasThematicCategory =
        Prefixed_Name(r_arco, "hasThematicCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ThematicCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the thematic category associated to a cartographic classification of a cultural property (e.g.: Architecture).</para>
    ///   <para>Questa classe rappresenta la categoria tematica associata alla classificazione cartografica di un bene culturale (es.: Architetture, Emergenze Archeologiche)</para>
    /// labels<para>Categoria tematica</para><para>Thematic category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ThematicCategory">https://w3id.org/arco/ontology/arco/ThematicCategory</seealso>
    let ThematicCategory = Prefixed_Name(r_arco, "ThematicCategory") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:CulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a cultural property, both tangible and intangible. A cultural property is the legacy, tangible or intangible, recognised as part of the national cultural heritage, since it helps know and reconstruct the history and the landscape.</para>
    ///   <para>Questa classe rappresenta un bene culturale, sia materiale che immateriale. Un bene culturale è una testimonianza materiale o immateriale, riconosciuta come parte del patrimonio culturale nazionale in quanto utile alla conoscenza e alla ricostruzione della storia e del paesaggio.</para>
    /// labels<para>Cultural Property</para><para>Bene culturale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalProperty">https://w3id.org/arco/ontology/arco/CulturalProperty</seealso>
    let CulturalProperty = Prefixed_Name(r_arco, "CulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCartographicClassificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha classificazione cartografica".</para>
    ///   <para>This is the inverse property of "has cartographic classification".</para>
    /// labels<para>è classificazione cartografica di</para><para>is cartographic classification of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCartographicClassificationOf">https://w3id.org/arco/ontology/arco/isCartographicClassificationOf</seealso>
    let isCartographicClassificationOf =
        Prefixed_Name(r_arco, "isCartographicClassificationOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCulturalPropertyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene culturale alla sua categoria.</para>
    ///   <para>This property relates a cultural property to its category.</para>
    /// labels<para>has cultural property category</para><para>ha categoria</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyCategory">https://w3id.org/arco/ontology/arco/hasCulturalPropertyCategory</seealso>
    let hasCulturalPropertyCategory =
        Prefixed_Name(r_arco, "hasCulturalPropertyCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents the "suffix" associated to a cultural property described by a catalogue record.</para>
    ///   <para>Questa proprietà permette di associare il suffisso a un bene culturale descritto in una scheda catalografica.</para>
    /// labels<para>suffisso</para><para>suffix</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/suffix">https://w3id.org/arco/ontology/arco/suffix</seealso>
    let suffix = Prefixed_Name(r_arco, "suffix") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:numberOfComponents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta il numero di esemplari/oggetti/elementi componenti di un bene culturale. Nel caso di un bene complesso identificato come serie o come insieme, si usa per specificare il numero, espresso in cifre, degli esemplari o degli oggetti componenti, oppure degli elementi componenti nel caso in cui il bene sia un insieme o una serie i cui esemplari/oggetti componenti comprendono ciascuno più elementi. Il range della proprietà è rdfs:Literal perché, nei casi in cui non sia stato possibile rilevare per motivi pratici la consistenza numerica, il valore della proprietà sarà "QNR".</para>
    ///   <para>This property represents the number of components of a complex cultural property.</para>
    /// labels<para>numero di oggetti/elementi componenti</para><para>number of components</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/numberOfComponents">https://w3id.org/arco/ontology/arco/numberOfComponents</seealso>
    let numberOfComponents = Prefixed_Name(r_arco, "numberOfComponents") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:regionIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà permette di associare il codice regione a un bene culturale descritto in una scheda catalografica.</para>
    ///   <para>This property represents the "region identifier" associated to a cultural property described by a catalogue record.</para>
    /// labels<para>region identifier</para><para>codice regione</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/regionIdentifier">https://w3id.org/arco/ontology/arco/regionIdentifier</seealso>
    let regionIdentifier = Prefixed_Name(r_arco, "regionIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCulturalPropertyResidual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene culturale alla/alle sua/e parte/i residuale/i.</para>
    ///   <para>This property relates a cultural property to its residual.</para>
    /// labels<para>ha parte residuale di bene culturale</para><para>has cultural property residual</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyResidual">https://w3id.org/arco/ontology/arco/hasCulturalPropertyResidual</seealso>
    let hasCulturalPropertyResidual =
        Prefixed_Name(r_arco, "hasCulturalPropertyResidual") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CulturalPropertyResidual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the residual part of a cultural property, that is what's left of the original cultural property.</para>
    ///   <para>Questa classe rappresenta la parte residuale di un bene culturale, cioè la parte che si conserva del bene culturale originale.</para>
    /// labels<para>Parte Residuale di Bene Culturale</para><para>Cultural Property Residual</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyResidual">https://w3id.org/arco/ontology/arco/CulturalPropertyResidual</seealso>
    let CulturalPropertyResidual =
        Prefixed_Name(r_arco, "CulturalPropertyResidual") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CulturalPropertyCataloguingCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta una categoria di un bene culturale basata su una valutazione soggettiva del catalogatore durante il processo di catalogazione.</para>
    ///   <para>This class represents a cultural property category based on a subjective evaluation of the cataloguing agent, during the cataloguing process.</para>
    /// labels<para>Categoria di bene culturale basata su catalogazione</para><para>Cultural property cataloguing category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyCataloguingCategory">https://w3id.org/arco/ontology/arco/CulturalPropertyCataloguingCategory</seealso>
    let CulturalPropertyCataloguingCategory =
        Prefixed_Name(r_arco, "CulturalPropertyCataloguingCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCulturalPropertyCataloguingCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa a "ha categoria di bene culturale basata su catalogazione".</para>
    ///   <para>This is the inverse property of "has cultural property cataloguing category of".</para>
    /// labels<para>è categoria di bene culturale basata su catalogazione di</para><para>is cultural property cataloguing category of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCulturalPropertyCataloguingCategoryOf">https://w3id.org/arco/ontology/arco/isCulturalPropertyCataloguingCategoryOf</seealso>
    let isCulturalPropertyCataloguingCategoryOf =
        Prefixed_Name(r_arco, "isCulturalPropertyCataloguingCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CulturalPropertyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the category of a cultural property, which contains the information that allows us to frame the terminological identification of the properties catalogued in the context of a wider and more complex semantic structure.</para>
    ///   <para>Questa classe rappresenta la categoria di un bene culturale, che contiene le indicazioni che consentono di inquadrare l'individuazione terminologica del bene catalogato nell'ambito di una più ampia e complessa organizzazione semantica.</para>
    /// labels<para>Cultural Property Category</para><para>Categoria del bene</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyCategory">https://w3id.org/arco/ontology/arco/CulturalPropertyCategory</seealso>
    let CulturalPropertyCategory =
        Prefixed_Name(r_arco, "CulturalPropertyCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCulturalPropertyCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha categoria".</para>
    ///   <para>This is the inverse property of "has cultural property category".</para>
    /// labels<para>is cultural property category of</para><para>è categoria di bene culturale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCulturalPropertyCategoryOf">https://w3id.org/arco/ontology/arco/isCulturalPropertyCategoryOf</seealso>
    let isCulturalPropertyCategoryOf =
        Prefixed_Name(r_arco, "isCulturalPropertyCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:numberOfMembers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta il numero di membri di un bene culturale che si identifica come una collezione (es.: serie)</para>
    ///   <para>This property represents the number of members of a cultural property that is a collection (e.g.: series)</para>
    /// labels<para>number of members</para><para>numero di membri</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/numberOfMembers">https://w3id.org/arco/ontology/arco/numberOfMembers</seealso>
    let numberOfMembers = Prefixed_Name(r_arco, "numberOfMembers") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCulturalPropertyComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà, inversa a "ha componente", collega una delle parti componenti di un bene culturale complesso al bene complesso stesso.</para>
    ///   <para>This property, inverse of "has component", relates a component of a complex cultural property to the complex cultural property.</para>
    /// labels<para>è parte componente di bene culturale</para><para>is cultural property component of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCulturalPropertyComponentOf">https://w3id.org/arco/ontology/arco/isCulturalPropertyComponentOf</seealso>
    let isCulturalPropertyComponentOf =
        Prefixed_Name(r_arco, "isCulturalPropertyComponentOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CulturalPropertyInventoryCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a category of a numismatic property, related to a classification based on an inventory approved by the specific subject area.</para>
    ///   <para>Questa classe rappresenta la categoria di un bene numismatico, in riferimento a una classificazione che si basa su un repertorio riconosciuto nello specifico ambito disciplinare.</para>
    /// labels<para>Categoria di bene culturale basata su repertorio</para><para>Cultural property inventory category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyInventoryCategory">https://w3id.org/arco/ontology/arco/CulturalPropertyInventoryCategory</seealso>
    let CulturalPropertyInventoryCategory =
        Prefixed_Name(r_arco, "CulturalPropertyInventoryCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:numberOfCulturalPropertyParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta il numero di esemplari di una stessa parte di un bene culturale (es.: il numero di denti di un reperto antropologico)</para>
    ///   <para>This property represents the number of specimens of the same cultural property part (es.: the number of the teeth of an anthropological material).</para>
    /// labels<para>numero di parte di bene culturale</para><para>number of cultural property part</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/numberOfCulturalPropertyParts">https://w3id.org/arco/ontology/arco/numberOfCulturalPropertyParts</seealso>
    let numberOfCulturalPropertyParts =
        Prefixed_Name(r_arco, "numberOfCulturalPropertyParts") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCulturalPropertyResidualOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà, inversa a "ha parte residuale", collega una parte residuale di un bene culturale al bene culturale stesso.</para>
    ///   <para>This property, inverse of "has residual", relates a residual of a cultural property to the cultural property.</para>
    /// labels<para>è parte residuale di bene culturale</para><para>is cultural property residual of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCulturalPropertyResidualOf">https://w3id.org/arco/ontology/arco/isCulturalPropertyResidualOf</seealso>
    let isCulturalPropertyResidualOf =
        Prefixed_Name(r_arco, "isCulturalPropertyResidualOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:numberOfResiduals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents the number of residuals (only if more than one) of a cultural property.</para>
    ///   <para>Questa proprietà rappresenta il numero di parti residuali, nel caso in cui si stia descrivendo un bene di cui si conservano più parti residuali.</para>
    /// labels<para>numero di parti residuali di bene culturale</para><para>number of cultural property residual parts</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/numberOfResiduals">https://w3id.org/arco/ontology/arco/numberOfResiduals</seealso>
    let numberOfResiduals = Prefixed_Name(r_arco, "numberOfResiduals") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:DemoEthnoAnthropologicalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene culturale demoetnoantropologico, che può essere di tipo immateriale e materiale. I beni demoetnoantropologici immateriali sono beni consistenti in performance uniche e irrepetibili strutturalmente connesse al territorio e a prassi socialmente condivise trasmesse attraverso l’oralità e le tecniche corporali, tanto in ambito italiano quanto in ambito europeo ed extra-europeo (comunicazioni non verbali, danze, feste e cerimonie, giochi, letterature orali, musiche, norme consuetudinarie, rappresentazioni e spettacoli, saperi, tecniche). I beni demoetnoantropologici materiali sono beni la cui costruzione e/o il cui uso sono strutturalmente associati a prassi socialmente condivise, trasmesse attraverso l'oralità e le tecniche corporali, tanto in ambito italiano quanto in ambito europeo ed extra-europeo (abbigliamento e ornamenti del corpo, arredi e suppellettili, mezzi di trasporto, ritualità, strumenti e accessori, beni sul territorio).</para>
    ///   <para>This class represents a demo-ethno-anthropological heritage, both tangible and intangible. The intangible demoetnoanthropological properties are cultural properties consisting of unique and unrepeatable performances, structurally connected to the territory and to socially shared custom, transmitted through orality and bodily techniques, both in Italy and in Europe and beyond Europe (non-verbal communications, dances, parties and ceremonies, games, oral letters, music, customary norms, performances and shows, knowledge, techniques). Demo-ethno-anthropological tangible properties are cultural properties whose construction and/or use are structurally associated with a socially shared custom, transmitted through orality and bodily techniques, both in the Italian and European and extra-European areas (clothing and body ornaments, furnishings and furnishings, means of transport, rituals, instruments and accessories, properties on the territory).</para>
    /// labels<para>Demo-ethno-anthropological Heritage</para><para>Bene Demoetnoantropologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/DemoEthnoAnthropologicalHeritage">https://w3id.org/arco/ontology/arco/DemoEthnoAnthropologicalHeritage</seealso>
    let DemoEthnoAnthropologicalHeritage =
        Prefixed_Name(r_arco, "DemoEthnoAnthropologicalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:EthnoAnthropologicalScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/arco/MibacScopeOfProtection</para>
    ///
    /// labels<para>Ethno-anthropological</para><para>Etnoantropologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/EthnoAnthropologicalScope">https://w3id.org/arco/ontology/arco/EthnoAnthropologicalScope</seealso>
    let EthnoAnthropologicalScope =
        Prefixed_Name(r_arco, "EthnoAnthropologicalScope") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:HSDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta la definizione associata allo strumento musicale, secondo la classificazione Hornbostel-Sachs.</para>
    ///   <para>This property represents the definition associated to a musical instrument, according to the Hornbostel-Sachs classification.</para>
    /// labels<para>definizione Hornbostel-Sachs</para><para>Hornbostel-Sachs definition</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/HSDefinition">https://w3id.org/arco/ontology/arco/HSDefinition</seealso>
    let HSDefinition = Prefixed_Name(r_arco, "HSDefinition") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:HSEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the edition Horbonstel-Sachs used for classifying a musical instrument.</para>
    ///   <para>Questa proprietà rappresenta l'indicazione bibliografica dell'edizione Hornbostel-Sachs utilizzata per la classificazione dello strumento musicale.</para>
    /// labels<para>edizione Hornbostel-Sachs</para><para>Hornbostel-Sachs edition</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/HSEdition">https://w3id.org/arco/ontology/arco/HSEdition</seealso>
    let HSEdition = Prefixed_Name(r_arco, "HSEdition") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:HistoricOrArtisticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene culturale storico e artistico, che può essere un disegno, una matrice incisa, un'opera o oggetto d'arte (contemporanea e non), una stampa, un vestimento antico o contemporaneo. Disegni: opere fatte a mano su qualsiasi supporto (carta, cartoncino, cartone, intonaco, legno, pergamena, pietra, seta, tavola, tela ecc.) e con particolari strumenti (carboncino, gessetto, inchiostro, lapis, matita, pastello, penna ecc.) e specifiche tecniche (acquarellatura, sanguigna ecc.). Matrici incise: lastre di vario materiale (acciaio, legno, linoleum, ottone, pietra, zinco rame ecc.) su cui vengono tracciate rappresentazioni pittoriche con particolari strumenti (bulino, punte di acciaio o di diamante, punzoni, raschietti ecc.) e con specifiche tecniche di incisione (acquaforte, acquatinta, litografia, mezzatinta, serigrafia, silografia, zincografia ecc.). Opere e oggetti d'arte: beni mobili costituenti parte integrante di monumenti artistici e storici o provenienti dallo smembramento dei monumenti stessi, conservati in collezioni, musei e pinacoteche (armi ed armature, arredi civili e religiosi, oggetti per il culto, oggetti d'uso, opere di pittura, tessuti e arazzi, sulture, ecc.). Opere e oggetti d'arte contemporanea: opere rappresentative  delle nuove correnti artistiche dei secc. XX e  XXI (assemblaggio, computer art, istallazione, istallazione ambientale, istallazione audio, istallazione video, istallazione multimediale interattiva, opera cinetico-visuale, performance, ready made, realtà virtuale, video arte ecc.). Stampe: esemplari prodotti dall'operazione mediante la quale da una matrice di incisione si ottengono copie uguali di rappresentazioni pittoriche su carta, cartoncino, cuoio,  pergamena, seta ecc. con varie tecniche di incisione (acquaforte, acquatinta, litografia, zincografia ecc.). Vestimenti antichi e contemporanei: abiti e costumi riguardanti l’abbigliamento maschile, femminile e infantile ad uso civile, connessi alle principali finalità d’uso e alle diverse occasioni della vita privata e sociale,  secondo le tipologie storiche dei secoli XVIII, XIX, XX  (abiti, biancheria intima, calzetteria, calzoni, camicie, costumi, cuffie, gonne, giacche, grembiuli, livree, maglie, mantelli, scialli, sciarpe, veli ecc.).</para>
    ///   <para>This class represents an historic or artistic property: drawing, printing plate, (contemporary) artworks, print, historic and contemporary garment. Drawings: works done by hand on any support (paper, cardboard, plaster, wood, parchment, stone, silk, table, canvas, etc.) and with special tools (charcoal, chalk, ink, pencil, pastel, pen etc.) and technical specifications (watercolor, blood, etc.). Printing plates: plates of various materials (steel, wood, linoleum, brass, stone, copper zinc, etc.) on which pictorial representations are traced with particular tools (burin, steel or diamond points, punches, scrapers, etc.) and with technical specifications for etching (etching, aquatint, lithography, halftone, screen printing, silica, zincography, etc.). Artworks: movable cultural properties that are integral part of artistic and historical monuments or coming from the dismemberment of the monuments themselves, preserved in collections, museums and art galleries (weapons and armor, civil and religious furnishings, objects for worship, everyday objects, paintings, fabrics and tapestries, walls, etc.). Contemporary artworks: cultural properties representative of the new artistic currents of the centuries XX and XXI (assembly, computer art, installation, environmental installation, audio installation, video installation, interactive multimedia installation, kinetic-visual work, performance, ready-made, virtual reality, video art, etc.). Prints: specimens created through this process: equal copies of pictorial representations on paper, cardboard, leather, parchment, silk, etc. are obtained from a printing plate, with various engraving techniques (etching, aquatint, lithography, zincography, etc.). Historic and contemporary garments: clothes and costumes for men's, women's and children's clothing for civil use, connected to the main intended use and to different occasions of private and social life, according to the historical typologies of the XVIII, XIX and XX centuries (dresses, underwear, hosiery, trousers, shirts, costumes, headphones, skirts, jackets, aprons, liveries, sweaters, cloaks, shawls, scarves, veils, etc.).</para>
    /// labels<para>Historic Or Artistic Property</para><para>Bene Storico o Artistico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/HistoricOrArtisticProperty">https://w3id.org/arco/ontology/arco/HistoricOrArtisticProperty</seealso>
    let HistoricOrArtisticProperty =
        Prefixed_Name(r_arco, "HistoricOrArtisticProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:MovableCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene materiale mobile, cioè un oggetto o un manufatto che può essere movimentato in vario modo. I beni mobili possono risultare "immobilizzati per destinazione", cioè incorporati saldamente nel contesto in cui si trovano.</para>
    ///   <para>This class represents a movable cultural property, that is, an object or an artefact that can be moved in various ways. Movable cultural properties may be "immobilized by destination", i.e. incorporated firmly in the context in which they are located.</para>
    /// labels<para>Movable Cultural Property</para><para>Bene mobile</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/MovableCulturalProperty">https://w3id.org/arco/ontology/arco/MovableCulturalProperty</seealso>
    let MovableCulturalProperty =
        Prefixed_Name(r_arco, "MovableCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:HistoricalArtisticScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/arco/MibacScopeOfProtection</para>
    ///
    /// labels<para>Historical Artistic</para><para>Storico Artistico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/HistoricalArtisticScope">https://w3id.org/arco/ontology/arco/HistoricalArtisticScope</seealso>
    let HistoricalArtisticScope =
        Prefixed_Name(r_arco, "HistoricalArtisticScope") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:IntangibleCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene immateriale, cioè quella parte del patrimonio culturale rappresentata da performance effimere di manifestazioni tradizionali, tecniche, saperi (feste, esecuzioni musicali e coreutiche, rappresentazioni teatrali, tecniche artigianali, letteratura orale, ecc.), colte nel momento in cui avvengono e di cui è possibile mantenere memoria solo attraverso la ripresa audio-visiva che le fissa stabilmente, cristallizzandole.</para>
    ///   <para>This class represents an intangible cultural property, that part of cultural heritage represented by ephemeral performances of traditional manifestations, techniques, knowledge (festivals, musical and dance performances, theatrical performances, craft techniques, oral literature, etc.), when they occur and of which it is possible to keep memory only through the audio-visual recording that fixes them permanently, crystallizing them.</para>
    /// labels<para>Intangible Cultural Property</para><para>Bene immateriale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/IntangibleCulturalProperty">https://w3id.org/arco/ontology/arco/IntangibleCulturalProperty</seealso>
    let IntangibleCulturalProperty =
        Prefixed_Name(r_arco, "IntangibleCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isMibacScopeOfProtectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha ambito di tutela".</para>
    ///   <para>This is the inverse property of "has MiBAC scope of protection".</para>
    /// labels<para>is MiBAC scope of protection of</para><para>è ambito di tutela di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isMibacScopeOfProtectionOf">https://w3id.org/arco/ontology/arco/isMibacScopeOfProtectionOf</seealso>
    let isMibacScopeOfProtectionOf =
        Prefixed_Name(r_arco, "isMibacScopeOfProtectionOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:MusicHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene culturale musicale. Strumenti musicali: oggetti nati appositamente per produrre suoni organizzati secondo le diverse culture musicali, senza limiti spazio-temporali (strumenti e accessori di interesse archeologico, storico artistico, etnoantropologico). Strumenti musicali-Organo: oggetto nato per produrre suoni,  costituito da una serie di canne metalliche,  di forma, lunghezza e diametro diversi, nelle quali viene immessa, per mezzo di un mantice o altro meccanismo, una quantità d’aria regolata da una o più tastiere e da una pedaliera (corredato da accessori), caratterizzato da specifici aspetti  morfologici-decorativi e fonico-strumentali (organo idraulico, organo positivo, organo portativo, organo elettronico ecc.)</para>
    ///   <para>This class represents a music heritage. Musical instruments: objects created specifically to produce sounds according to different musical cultures, without space-time limits (instruments and accessories of archaeological, artistic, ethno-anthropological interest). Musical instruments-Organ: an object created to produce sounds, consisting of a series of metal rods, of different shape, length and diameter, in which a quantity of air is introduced, by means of a bellows or other mechanism, regulated by one or more keyboards and a pedal board (accompanied by accessories), characterized by specific morphological-decorative and phonic-instrumental aspects (hydraulic organ, positive organ, portative organ, electronic organ, etc.)</para>
    /// labels<para>Music Heritage</para><para>Bene Musicale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/MusicHeritage">https://w3id.org/arco/ontology/arco/MusicHeritage</seealso>
    let MusicHeritage = Prefixed_Name(r_arco, "MusicHeritage") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasMusicalInstrumentClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene musicale a una classificazione con cui lo strumento può essere codificato.</para>
    ///   <para>This property connects a cultural entity to a classification through which the instrument can be coded.</para>
    /// labels<para>ha classificazione di strumento musicale</para><para>has musical instrument classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasMusicalInstrumentClassification">https://w3id.org/arco/ontology/arco/hasMusicalInstrumentClassification</seealso>
    let hasMusicalInstrumentClassification =
        Prefixed_Name(r_arco, "hasMusicalInstrumentClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isMusicalInstrumentClassificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà, inversa a "ha classificazione di bene musicale", collega un una classificazione con cui uno strumento musicale può essere codificato al bene musicale.</para>
    /// labels<para>è classificazione di strumento musicale di</para><para>is musical instrument classification of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isMusicalInstrumentClassificationOf">https://w3id.org/arco/ontology/arco/isMusicalInstrumentClassificationOf</seealso>
    let isMusicalInstrumentClassificationOf =
        Prefixed_Name(r_arco, "isMusicalInstrumentClassificationOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:NaturalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a natural heritage, related to botany, mineralogy, paleontology, petrology, planetary science, zoology. Botany: specimens of the plant world from botanical collections (collections of dried plants: herbaria). Mineralogy: specimens of minerals from collections of mineralogy (Augite, Goethite, box of quartz etc.). Paleontology: fossil finds (animals, plants, ichnofossils, samples and microscope preparations, etc.). Petrology: specimens of rocks from collections (Riolite, Trachiandesite etc.). Planetology: meteorites from collections (Aubrite, Ureilite, Eucrite, etc.). Zoology: specimens of the animal world from zoology collections (ustiolo, shrew, mammal, arthropod, butterfly box, elmintological collection, etc.)</para>
    ///   <para>Questa classe rappresenta un bene culturale naturalistico, relativo ai campi della botanica, della mineralogia, della paleontologia, della petrologia, della planetologia, della zoologia. Botanica: esemplari del mondo vegetale provenienti da collezioni di botanica  (raccolte di piante essiccate: erbari). Mineralogia: esemplari di minerali provenienti da collezioni di mineralogia (Augite, Goethite, scatola di quarzi ecc. ). Paleontologia: reperti fossili (animali, vegetali, ichnofossili, campioni e preparati per microscopio, ecc.). Petrologia: esemplari di rocce provenienti da collezioni (Riolite, Trachiandesite ecc). Planetologia: esemplari di meteoriti provenienti da collezioni ( Aubrite, Ureilite, Eucrite ecc.). Zoologia: esemplari del mondo animale provenienti da collezioni di zoologia (ustiolo, toporagno, mammifero, artropode, scatola di farfalle, collezione elmintologica, ecc.)</para>
    /// labels<para>Bene Naturalistico</para><para>Natural Heritage</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/NaturalHeritage">https://w3id.org/arco/ontology/arco/NaturalHeritage</seealso>
    let NaturalHeritage = Prefixed_Name(r_arco, "NaturalHeritage") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:NumismaticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a numismatic property, that is coins and other objects of numismatic interest (premonetal and paramonetal finds, coinage and monetary punches, weights for monetary control, seals and medals), pertinent to any age.</para>
    ///   <para>Questa classe rappresenta un bene culturale numismatico, ovvero monete e altri oggetti di interesse numismatico (reperti premonetali e paramonetali, conii e punzoni monetali, pesi per il controllo monetale, sigilli e medaglie), pertinenti a  qualsiasi epoca.</para>
    /// labels<para>Numismatic Property</para><para>Bene Numismatico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/NumismaticProperty">https://w3id.org/arco/ontology/arco/NumismaticProperty</seealso>
    let NumismaticProperty = Prefixed_Name(r_arco, "NumismaticProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasNumismaticPropertyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a numismatic property to one of its categories.</para>
    ///   <para>Questa proprietà collega un bene numismatico a una sua categoria.</para>
    /// labels<para>has numismatic property category</para><para>ha categoria di bene numismatico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasNumismaticPropertyCategory">https://w3id.org/arco/ontology/arco/hasNumismaticPropertyCategory</seealso>
    let hasNumismaticPropertyCategory =
        Prefixed_Name(r_arco, "hasNumismaticPropertyCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:NumismaticPropertyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la categoria funzionale di un bene numismatico, in riferimento a una classificazione relativa alla funzione, o alla destinazione, o alla committenza del bene catalogato, secondo le classificazioni più consuete.</para>
    ///   <para>This class represents a functional category of a numismatic property, referring to a classification related to the function or the commission of the cultural property, according to the most common classifications.</para>
    /// labels<para>Classificazione di bene numismatico</para><para>Numismatic property classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/NumismaticPropertyCategory">https://w3id.org/arco/ontology/arco/NumismaticPropertyCategory</seealso>
    let NumismaticPropertyCategory =
        Prefixed_Name(r_arco, "NumismaticPropertyCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isNumismaticPropertyCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una categoria di bene numismatico al bene numismatico cui si riferisce.</para>
    /// labels<para>is numismatic property category of</para><para>è categoria di bene numismatico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isNumismaticPropertyCategoryOf">https://w3id.org/arco/ontology/arco/isNumismaticPropertyCategoryOf</seealso>
    let isNumismaticPropertyCategoryOf =
        Prefixed_Name(r_arco, "isNumismaticPropertyCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:PhotographicHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a photographic heritage. Photographs: negative, positive, photographic processes that give rise to unique products (daguerreotypes, ferrotypes, polaroids, chimigrams, etc.), digital photography; complex elements like albums, folders, photomontages, panoramas, porfolii. Photographic funds: conceptual entities that are characterized by the accumulation of multiple homogeneous or heterogeneous physical units from the point of view of the materials that compose them and which represent in their totality a cultural heritage.</para>
    ///   <para>Questa classe rappresenta un bene culturale fotografico, che può essere una fotografia o un fondo fotografico. Beni fotografici: negativi, positivi, processi fotografici che danno origine a prodotti unici (dagherrotipi, ferrotipi, polaroid, chimigrammi, ecc.), fotografia digitale; elementi complessi come album, cartelle, fotomontaggi, panorami, porfolii. Fondi fotografici: entità concettuali che si caratterizzano per l'accumulo di più unità fisiche omogenee o eterogenee dal punto di vista dei materiali che li compongono e che acquisiscono nella loro totalità valenza di bene culturale.</para>
    /// labels<para>Photographic Heritage</para><para>Bene Fotografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/PhotographicHeritage">https://w3id.org/arco/ontology/arco/PhotographicHeritage</seealso>
    let PhotographicHeritage =
        Prefixed_Name(r_arco, "PhotographicHeritage") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasPhotographicHeritageClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene fotografico a una classificazione di un bene fotografico secondo un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    ///   <para>This property connects a photographic property to a photographic property's classification, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.</para>
    /// labels<para>has photographic heritage classification</para><para>ha classificazione di bene fotografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassification">https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassification</seealso>
    let hasPhotographicHeritageClassification =
        Prefixed_Name(r_arco, "hasPhotographicHeritageClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:classifiedSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents the subject of a photographic heritage as described in a photographic heritage classification other than Iconclass.</para>
    ///   <para>Questa proprietà rappresenta la descrizione codificata del/i soggetto/i raffigurato/i nell'opera secondo il sistema di classificazione scelto dall'Ente schedatore, in alternativa e/o in aggiunta ad Iconclass.</para>
    /// labels<para>soggetto classificato</para><para>classified subject</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/classifiedSubject">https://w3id.org/arco/ontology/arco/classifiedSubject</seealso>
    let classifiedSubject = Prefixed_Name(r_arco, "classifiedSubject") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isPhotographicHeritageClassificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is photographic heritage classification of</para><para>è classificazione di bene fotografico di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationOf">https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationOf</seealso>
    let isPhotographicHeritageClassificationOf =
        Prefixed_Name(r_arco, "isPhotographicHeritageClassificationOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:PhotographicHeritageClassificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents photographic property's classification type,, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.</para>
    ///   <para>Questa classe rappresenta il tipo di classificazione di un bene fotografico, relativamente a un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    /// labels<para>Tipo di classificazione di bene fotografico</para><para>Photographic heritage classification type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/PhotographicHeritageClassificationType">https://w3id.org/arco/ontology/arco/PhotographicHeritageClassificationType</seealso>
    let PhotographicHeritageClassificationType =
        Prefixed_Name(r_arco, "PhotographicHeritageClassificationType") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasPhotographicHeritageClassificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property connects a photographic property's classification to the classification type, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.</para>
    ///   <para>Questa proprietà collega una classificazione di un bene fotografico al tipo di classificazione, relativamente a un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    /// labels<para>ha tipo di classificazione di bene fotografico</para><para>has photographic heritage classification type</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassificationType">https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassificationType</seealso>
    let hasPhotographicHeritageClassificationType =
        Prefixed_Name(r_arco, "hasPhotographicHeritageClassificationType") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isPhotographicHeritageClassificationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha tipo di classificazione di bene fotografico".</para>
    ///   <para>This is the inverse property of "has photographic heritage classification type".</para>
    /// labels<para>is photographic heritage classification type of</para><para>è tipo di classificazione di bene fotografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationTypeOf">https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationTypeOf</seealso>
    let isPhotographicHeritageClassificationTypeOf =
        Prefixed_Name(r_arco, "isPhotographicHeritageClassificationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:RFId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta l'identificatore a radiofrequenza RFId.</para>
    ///   <para>This class represents the radio-frequency identification (RFID).</para>
    /// labels<para>Identificativo RFId</para><para>RFId Identifier</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/RFId">https://w3id.org/arco/ontology/arco/RFId</seealso>
    let RFId = Prefixed_Name(r_arco, "RFId") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:isRFIdOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un identificatore a radiofrequenza RFId a un oggetto.</para>
    ///   <para>This property relates a radio-frequency identification (RFID) to an object.</para>
    /// labels<para>è identificativo RFId di</para><para>is RFId identifier of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isRFIdOf">https://w3id.org/arco/ontology/arco/isRFIdOf</seealso>
    let isRFIdOf = Prefixed_Name(r_arco, "isRFIdOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ReferenceCoinLegend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la legenda tipo di un bene numismatico, inteso come parametro di classificazione attestato nei repertori di riferimento.</para>
    ///   <para>This class represents the reference coin legend.</para>
    /// labels<para>Reference coin legend</para><para>Legenda tipo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ReferenceCoinLegend">https://w3id.org/arco/ontology/arco/ReferenceCoinLegend</seealso>
    let ReferenceCoinLegend =
        Prefixed_Name(r_arco, "ReferenceCoinLegend") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isThematicCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha categoria tematica".</para>
    ///   <para>This is the inverse property of "has thematic category".</para>
    /// labels<para>is thematic category of</para><para>è categoria tematica di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isThematicCategoryOf">https://w3id.org/arco/ontology/arco/isThematicCategoryOf</seealso>
    let isThematicCategoryOf =
        Prefixed_Name(r_arco, "isThematicCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:archaeologicalSiteIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta la sigla del saggio stratigrafico.</para>
    ///   <para>This property represents the archaeological site identifier.</para>
    /// labels<para>sigla identificativa del saggio stratigrafico</para><para>archaeological site identifier</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/archaeologicalSiteIdentifier">https://w3id.org/arco/ontology/arco/archaeologicalSiteIdentifier</seealso>
    let archaeologicalSiteIdentifier =
        Prefixed_Name(r_arco, "archaeologicalSiteIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:definitionAndPositionOfComponents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta le informazioni sulla definizione e posizione delle parti componenti di un bene culturale complesso.</para>
    ///   <para>This property represents information on definition and position of the components of a complex cultural property.</para>
    /// labels<para>definizione e posizione delle parti componenti</para><para>definition and position of components</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/definitionAndPositionOfComponents">https://w3id.org/arco/ontology/arco/definitionAndPositionOfComponents</seealso>
    let definitionAndPositionOfComponents =
        Prefixed_Name(r_arco, "definitionAndPositionOfComponents") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:digitalPhotographNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta le note relative alla fotografia digitale. Può rappresentare informazioni utili a identificare le intenzioni dell'autore in relazione alla visualizzazione o rioggettivazione della fotografia digitale, come la dimensione del quadro, la risoluzione di stampa e relativa unità di misura, altre indicazioni per la stampa (tipo stampante, correzioni cromatiche, ecc.), categoria, URL, ecc.</para>
    ///   <para>This property represents notes on a digital photograph.</para>
    /// labels<para>note sulla fotografia digitale</para><para>digital photograph note</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/digitalPhotographNote">https://w3id.org/arco/ontology/arco/digitalPhotographNote</seealso>
    let digitalPhotographNote =
        Prefixed_Name(r_arco, "digitalPhotographNote") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta la data di fine di un intervallo temporale, che può essere espressa secondo criteri diversi e a diverso livello di dettaglio (secolo, intervallo di secoli, anno, intervallo di anni, aaaa/mm/gg, periodo storico, etc.)</para>
    ///   <para>This property represents the end time of a time interval, according to different criteria and level of detail (century, century interval, year, yyyy/mm/dd, historical period, etc.).</para>
    /// labels<para>data di fine</para><para>end time</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/endTime">https://w3id.org/arco/ontology/arco/endTime</seealso>
    let endTime = Prefixed_Name(r_arco, "endTime") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasAlternativeDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cultural property to a related scientific discipline, alternative to the main one.</para>
    ///   <para>Questa proprietà permette di associare un bene culturale a discipline scientifiche, alternative a quella principale, cui fa riferimento.</para>
    /// labels<para>has alternative discipline</para><para>ha altra disciplina</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasAlternativeDiscipline">https://w3id.org/arco/ontology/arco/hasAlternativeDiscipline</seealso>
    let hasAlternativeDiscipline =
        Prefixed_Name(r_arco, "hasAlternativeDiscipline") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isAlternativeDisciplineOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà permette di associare discipline scientifiche, alternative a quella principale, cui un bene culturale fa riferimento, al bene culturale stesso.</para>
    ///   <para>This property relates a scientific discipline, alternative to the main one, related to a cultural property to that cultural property.</para>
    /// labels<para>is alternative discipline of</para><para>è altra disciplina di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isAlternativeDisciplineOf">https://w3id.org/arco/ontology/arco/isAlternativeDisciplineOf</seealso>
    let isAlternativeDisciplineOf =
        Prefixed_Name(r_arco, "isAlternativeDisciplineOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCartographicClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene culturale alla sua classificazione cartografica.</para>
    ///   <para>This property relates a cultural property to its cartographic classification.</para>
    /// labels<para>ha classificazione cartografica</para><para>has cartographic classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCartographicClassification">https://w3id.org/arco/ontology/arco/hasCartographicClassification</seealso>
    let hasCartographicClassification =
        Prefixed_Name(r_arco, "hasCartographicClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCataloguingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cultural property to its cagaloguing agency. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un bene culturale al relativo ente schedatore. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    /// labels<para>has cataloguing agency</para><para>ha ente schedatore</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCataloguingAgency">https://w3id.org/arco/ontology/arco/hasCataloguingAgency</seealso>
    let hasCataloguingAgency =
        Prefixed_Name(r_arco, "hasCataloguingAgency") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasRelatedAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un bene culturale a un ente che riveste un ruolo nei suoi confronti. La relazione tra il ruolo e l'ente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. La proprietà è specializzata per mezzo di sottoproprietà. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <para>This property relates a cultural property to an agency that plays a role related to the cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    /// labels<para>has related agency</para><para>ha ente collegato</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasRelatedAgency">https://w3id.org/arco/ontology/arco/hasRelatedAgency</seealso>
    let hasRelatedAgency = Prefixed_Name(r_arco, "hasRelatedAgency") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCataloguingAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un ente schedatore al relativo bene culturale che ha schedato. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <para>This property relates a cagaloguing agency to the catalogued cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    /// labels<para>is cataloguing agency of</para><para>è ente schedatore di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCataloguingAgencyOf">https://w3id.org/arco/ontology/arco/isCataloguingAgencyOf</seealso>
    let isCataloguingAgencyOf =
        Prefixed_Name(r_arco, "isCataloguingAgencyOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCulturalPropertyCataloguingCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cultural property to a category based on a subjective evaluation of the cataloguing agent, during the cataloguing process.</para>
    ///   <para>Questa proprietà collega un bene culturale a una categoria basata su una valutazione soggettiva del catalogatore durante il processo di catalogazione.</para>
    /// labels<para>ha categoria di bene culturale basata su catalogazione</para><para>has cultural property cataloguing category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyCataloguingCategory">https://w3id.org/arco/ontology/arco/hasCulturalPropertyCataloguingCategory</seealso>
    let hasCulturalPropertyCataloguingCategory =
        Prefixed_Name(r_arco, "hasCulturalPropertyCataloguingCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCulturalPropertyInventoryCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cultural property to a category based on a classification related to an inventory approved by the specific subject area.</para>
    ///   <para>Questa proprietà collega un bene culturale a una categoria basata su una classificazione relativa a un repertorio riconosciuto dallo specifico ambito disciplinare.</para>
    /// labels<para>has cultural property inventory category</para><para>ha categoria basata su repertorio</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyInventoryCategory">https://w3id.org/arco/ontology/arco/hasCulturalPropertyInventoryCategory</seealso>
    let hasCulturalPropertyInventoryCategory =
        Prefixed_Name(r_arco, "hasCulturalPropertyInventoryCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasHeritageProtectionAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un bene culturale al relativo ente competente per la tutela. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <para>This property relates a cultural property to its heritage protection agency. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    /// labels<para>ha ente competente per la tutela</para><para>has heritage protection agency</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasHeritageProtectionAgency">https://w3id.org/arco/ontology/arco/hasHeritageProtectionAgency</seealso>
    let hasHeritageProtectionAgency =
        Prefixed_Name(r_arco, "hasHeritageProtectionAgency") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isHeritageProtectionAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un ente competente per la tutela al relativo bene culturale della cui tutela è competente. La relazione tra il ruolo e l'ente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'ente e il suo ruolo.</para>
    ///   <para>This property relates an heritage protection agency to the cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    /// labels<para>è ente competente per la tutela di</para><para>is heritage protection agency of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isHeritageProtectionAgencyOf">https://w3id.org/arco/ontology/arco/isHeritageProtectionAgencyOf</seealso>
    let isHeritageProtectionAgencyOf =
        Prefixed_Name(r_arco, "isHeritageProtectionAgencyOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasMainDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cultural property to the main related scientific discipline.</para>
    ///   <para>Questa proprietà permette di associare un bene culturale alla disciplina scientifica più importante, o storicamente riconosciuta, cui fa riferimento.</para>
    /// labels<para>ha disciplina principale</para><para>has main discipline</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasMainDiscipline">https://w3id.org/arco/ontology/arco/hasMainDiscipline</seealso>
    let hasMainDiscipline = Prefixed_Name(r_arco, "hasMainDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:isMainDisciplineOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates the main scientific discipline related to a cultural property to that cultural property.</para>
    ///   <para>Questa proprietà permette di associare la disciplina scientifica principale, cui un bene culturale fa riferimento, al bene culturale stesso.</para>
    /// labels<para>è disciplina principale di</para><para>is main discipline of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isMainDisciplineOf">https://w3id.org/arco/ontology/arco/isMainDisciplineOf</seealso>
    let isMainDisciplineOf = Prefixed_Name(r_arco, "isMainDisciplineOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasMibacScopeOfProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà associa un bene culturale all'ambito di tutela nel quale ricade.</para>
    ///   <para>This property relates a cultural property to ist MiBAC scope of protection</para>
    /// labels<para>has MiBAC scope of protection</para><para>ha ambito di tutela</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasMibacScopeOfProtection">https://w3id.org/arco/ontology/arco/hasMibacScopeOfProtection</seealso>
    let hasMibacScopeOfProtection =
        Prefixed_Name(r_arco, "hasMibacScopeOfProtection") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasRFId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un oggetto a un identificatore a radiofrequenza RFId.</para>
    ///   <para>This property relates an object to an RFId.</para>
    /// labels<para>ha identificativo RFId</para><para>has RFId identifier</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasRFId">https://w3id.org/arco/ontology/arco/hasRFId</seealso>
    let hasRFId = Prefixed_Name(r_arco, "hasRFId") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasReferenceCoinLegend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property relates a numismatic property with its reference coin legend.</para>
    ///   <para>Questa proprietà collega un bene numismatico alla sua legenda tipo.</para>
    /// labels<para>has reference coin legend</para><para>ha legenda tipo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasReferenceCoinLegend">https://w3id.org/arco/ontology/arco/hasReferenceCoinLegend</seealso>
    let hasReferenceCoinLegend =
        Prefixed_Name(r_arco, "hasReferenceCoinLegend") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isRelatedAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property, inverse of "has related agency", relates an agency that plays a role related to a cultural property to that cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    ///   <para>Questa proprietà, inversa a "ha ente collegato", rappresenta la relazione che collega un ente che riveste un ruolo nei confronti di un bene culturale al bene culturale stesso. La relazione tra il ruolo e l'ente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. La proprietà è specializzata per mezzo di sottoproprietà. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l'ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    /// labels<para>is related agency of</para><para>è ente collegato a</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isRelatedAgencyOf">https://w3id.org/arco/ontology/arco/isRelatedAgencyOf</seealso>
    let isRelatedAgencyOf = Prefixed_Name(r_arco, "isRelatedAgencyOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:internationalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the international identifier of a scientific or technological heritage. More info can be found at https://www.isin.org/</para>
    ///   <para>Questa proprietà rappresenta il numero di codice internazionale che identifica un bene scientifico e tecnologico. All'indirizzo http://www.isin.org/ è possibile reperire tutte le specifiche per l'adesione al progetto e l'attribuzione del codice internazionale. Il Registro Online è un database che raccoglie informazioni su strumenti scientifici di interesse storico promosso dal Museum of the History of Science di Oxford in collaborazione con la Commissione Strumenti Scientifici dell'International Union of the History and Philosophy of Science.</para>
    /// labels<para>international identifier</para><para>codice internazionale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/internationalIdentifier">https://w3id.org/arco/ontology/arco/internationalIdentifier</seealso>
    let internationalIdentifier =
        Prefixed_Name(r_arco, "internationalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:musicalInstrumentNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta le note relative agli aspetti acustici di uno strumento musicale, ed eventualmente anche relative ai rilevamenti e ai criteri adottati in sede di restauro.</para>
    ///   <para>This property represents notes on a musical instrument.</para>
    /// labels<para>note sullo strumento musicale</para><para>musical instrument note</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/musicalInstrumentNote">https://w3id.org/arco/ontology/arco/musicalInstrumentNote</seealso>
    let musicalInstrumentNote =
        Prefixed_Name(r_arco, "musicalInstrumentNote") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:numberOfParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta il numero di parti di un'entità.</para>
    ///   <para>This property represents the number of parts of an entity.</para>
    /// labels<para>number of parts</para><para>numero di parti</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/numberOfParts">https://w3id.org/arco/ontology/arco/numberOfParts</seealso>
    let numberOfParts = Prefixed_Name(r_arco, "numberOfParts") |> PrefixedName
    /// <summary>
    ///   <para>r-arco:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the start time of a time interval, according to different criteria and level of detail (century, century interval, year, yyyy/mm/dd, historical period, etc.).</para>
    ///   <para>Questa proprietà rappresenta la data di inizio di un intervallo temporale, che può essere espressa secondo criteri diversi e a diverso livello di dettaglio (secolo, intervallo di secoli, anno, intervallo di anni, aaaa/mm/gg, periodo storico, etc.)</para>
    /// labels<para>data di inizio</para><para>start time</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/startTime">https://w3id.org/arco/ontology/arco/startTime</seealso>
    let startTime = Prefixed_Name(r_arco, "startTime") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CartographicClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a cartographic classification of a cultural property, referring to the cartographic representation on specific thematic levels, based on a standard or a classification defined by the cataloguing agency.</para>
    ///   <para>Questa classe rappresenta una classificazione di un bene culturale relativamente alla rappresentazione cartografica del bene su specifici livelli tematici, con riferimento a uno standard oppure a un'organizzazione logica predefinita dall'Ente responsabile dell'attività di catalogazione.</para>
    /// labels<para>Classificazione cartografica</para><para>Cartographic classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CartographicClassification">https://w3id.org/arco/ontology/arco/CartographicClassification</seealso>
    let CartographicClassification =
        Prefixed_Name(r_arco, "CartographicClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:catalogueNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà permette di associare il numero di catalogo generale a un bene culturale descritto in una scheda catalografica.</para>
    ///   <para>This property represents the general catalogue number associated to a cultural property described by a catalogue record.</para>
    /// labels<para>numero catalogo generale</para><para>catalogue number</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/catalogueNumber">https://w3id.org/arco/ontology/arco/catalogueNumber</seealso>
    let catalogueNumber = Prefixed_Name(r_arco, "catalogueNumber") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:MusicalInstrumentClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a classification concerning a musical instrument, concerning the Hornbostel-Sachs classification or possibily other classifications.</para>
    ///   <para>Questa classe rappresenta una classificazione relativa a uno strumento musicale, secondo la classificazione di Hornbostel-Sachs ed eventualmente anche secondo altre classificazioni.</para>
    /// labels<para>Classificazione di strumento musicale</para><para>Musical instrument classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/MusicalInstrumentClassification">https://w3id.org/arco/ontology/arco/MusicalInstrumentClassification</seealso>
    let MusicalInstrumentClassification =
        Prefixed_Name(r_arco, "MusicalInstrumentClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:PhotographicHeritageClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a photographic entity's classification accorting to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.</para>
    ///   <para>Questa classe rappresenta una classificazione di un bene fotografico secondo un sistema di classificazione alternativo a Iconclass, che sia comunque riconosciuto e utilizzato a livello nazionale, o preferibilmente internazionale.</para>
    /// labels<para>Photographic heritage classification</para><para>Classificazione di bene fotografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/PhotographicHeritageClassification">https://w3id.org/arco/ontology/arco/PhotographicHeritageClassification</seealso>
    let PhotographicHeritageClassification =
        Prefixed_Name(r_arco, "PhotographicHeritageClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCulturalPropertyInventoryCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una categoria basata su una classificazione relativa a un repertorio riconosciuto dallo specifico ambito disciplinare a un bene culturale.</para>
    ///   <para>This property relates a category based on a classification related to an inventory approved by the specific subject area to a cultural property.</para>
    /// labels<para>is cultural property inventory category of</para><para>è categoria basata su repertorio di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCulturalPropertyInventoryCategoryOf">https://w3id.org/arco/ontology/arco/isCulturalPropertyInventoryCategoryOf</seealso>
    let isCulturalPropertyInventoryCategoryOf =
        Prefixed_Name(r_arco, "isCulturalPropertyInventoryCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:AlternativeMusicalInstrumentClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a classification different from the Hornbostel-Sachs classification.</para>
    ///   <para>Questa classe rappresenta un sistema di classificazione diverso da quello Hornbostel-Sachs, con cui può essere codificato uno strumento musicale.</para>
    /// labels<para>Classificazione alternativa di strumento musicale</para><para>Alternative musical instrument classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/AlternativeMusicalInstrumentClassification">https://w3id.org/arco/ontology/arco/AlternativeMusicalInstrumentClassification</seealso>
    let AlternativeMusicalInstrumentClassification =
        Prefixed_Name(r_arco, "AlternativeMusicalInstrumentClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:HornbostelSachsClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la classificazione Hornbostel-Sachs di uno strumento musicale.</para>
    ///   <para>This class represents the Hornbostel-Sachs classification of a musical instrument.</para>
    /// labels<para>Classificazione Hornbostel-Sachs</para><para>Hornbostel-Sachs classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/HornbostelSachsClassification">https://w3id.org/arco/ontology/arco/HornbostelSachsClassification</seealso>
    let HornbostelSachsClassification =
        Prefixed_Name(r_arco, "HornbostelSachsClassification") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the taxon code and the taxon definition associated to the musical instrument, according to a musical instrument classification.</para>
    ///   <para>Questa proprietà rappresenta il codice tassonomico e la definizione attribuiti allo strumento musicale schedato nell'ambito del sistema di classificazione preso in considerazione.</para>
    /// labels<para>taxon</para><para>taxon</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/taxon">https://w3id.org/arco/ontology/arco/taxon</seealso>
    let taxon = Prefixed_Name(r_arco, "taxon") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasArchaeologicalMaterialCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates the archaeological material to its category (e.g.: ceramics, plaster, lithic materials, etc.)</para>
    ///   <para>Questa proprietà collega un materiale archeologico alla sua categoria (es.: ceramiche, industria litica, intonaco, legno, etc.)</para>
    /// labels<para>ha categoria di materiale archeologico</para><para>has archaeological material category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasArchaeologicalMaterialCategory">https://w3id.org/arco/ontology/arco/hasArchaeologicalMaterialCategory</seealso>
    let hasArchaeologicalMaterialCategory =
        Prefixed_Name(r_arco, "hasArchaeologicalMaterialCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CulturalPropertyPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a generic part of a cultural property, to which some specific information is referred.</para>
    ///   <para>Questa classe rappresenta, a un livello generico, una parte di un bene culturale descritto in una scheda cui si possono riferire informazioni specifiche.</para>
    /// labels<para>Parte di Bene Culturale</para><para>Cultural Property Part</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyPart">https://w3id.org/arco/ontology/arco/CulturalPropertyPart</seealso>
    let CulturalPropertyPart =
        Prefixed_Name(r_arco, "CulturalPropertyPart") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isArchaeologicalMaterialCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "has archaeological material category of".</para>
    ///   <para>Questa è la proprietà inversa di "ha categoria di materiale archeologico".</para>
    /// labels<para>is archaeological material category of</para><para>è categoria di materiale archeologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isArchaeologicalMaterialCategoryOf">https://w3id.org/arco/ontology/arco/isArchaeologicalMaterialCategoryOf</seealso>
    let isArchaeologicalMaterialCategoryOf =
        Prefixed_Name(r_arco, "isArchaeologicalMaterialCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:TangibleCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene materiale, cioè fisicamente tangibile, sia mobile che immobile.</para>
    ///   <para>This class represents a tangible cultural property, either immovable or movable.</para>
    /// labels<para>Tangible Cultural Property</para><para>Bene materiale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/TangibleCulturalProperty">https://w3id.org/arco/ontology/arco/TangibleCulturalProperty</seealso>
    let TangibleCulturalProperty =
        Prefixed_Name(r_arco, "TangibleCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:MibacScopeOfProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the MiBAC scope of protection (historical artistic, ethoanthropological, architectural landscape, archaeological) of a cultural property.</para>
    ///   <para>Questa classe rappresenta l'ambito di tutela del MiBAC (archeologico, architettonico e paesaggistico, etnoantropologico, storico artistico), nel quale ricade il bene culturale in esame.</para>
    /// labels<para>MiBAC Scope of protection</para><para>Ambito di tutela MiBAC</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/MibacScopeOfProtection">https://w3id.org/arco/ontology/arco/MibacScopeOfProtection</seealso>
    let MibacScopeOfProtection =
        Prefixed_Name(r_arco, "MibacScopeOfProtection") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ArchitecturalOrLandscapeHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un bene culturale architettonico e paesaggistico. Architettura: complessi monumentali, edifici pubblici e di culto, dimore gentilizie, architetture fortificate, edifici privati, edilizia rurale, fabbricati di archeologia industriale caratterizzati da particolare rilevanza storico artistica. Centri/nuclei storici: strutture insediative urbane più antiche dei territori comunali, caratterizzate da testimonianze storico artistiche di particolare rilevanza. Parchi e giardini: spazi verdi di particolare rilevanza  storica, artistica e ambientale. Esempi di questa tipologia di beni culturali sono i giardini e i parchi annessi alle proprietà nobiliari, gli orti e i giardini botanici, i parchi urbani, le aree verdi comprese nei siti archeologici, ma anche i piccoli giardini privati, i chiostri e i cortili, i cimiteri, sempre se caratterizzati da particolare rilevanza storico artistica.</para>
    ///   <para>This class represents an architectural or landscape heritage. Architecture: monumental complexes, public and religious buildings, noble residences, fortified architectures, private buildings, rural buildings, industrial archeology buildings characterized by particular historical and artistic importance. Historical centers: urban settlement structures older than the municipal territories, characterized by particularly important historical artistic testimonies. Parks and gardens: green spaces of particular historical, artistic and environmental importance. Examples of this type of cultural heritage are gardens and parks annexed to noble properties, vegetable gardens and botanical gardens, urban parks, green areas included in archaeological sites, but also small private gardens, cloisters and courtyards, cemeteries, always if characterized by particular historical and artistic relevance.</para>
    /// labels<para>Bene Architettonico o Paesaggistico</para><para>Architectural or Landscape Heritage</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ArchitecturalOrLandscapeHeritage">https://w3id.org/arco/ontology/arco/ArchitecturalOrLandscapeHeritage</seealso>
    let ArchitecturalOrLandscapeHeritage =
        Prefixed_Name(r_arco, "ArchitecturalOrLandscapeHeritage") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ImmovableCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an immovable cultural property, a property fastened and/or incorporated into the ground (buildings, monumental complexes, territorial areas, etc.) which generally has a significant spatial extent.</para>
    ///   <para>Questa classe rappresenta un bene materiale immobile, cioè un bene agganciato e/o incorporato al suolo (edifici, complessi monumentali, spazi territoriali, ecc.) che presentano, in genere, un consistente sviluppo spaziale. Si intende come un particolare tipo di Site (contenitore fisico), in quanto luogo fisico georeferenziato che possiede esso stesso un interesse culturale.</para>
    /// labels<para>Immovable Cultural Property</para><para>Bene immobile</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ImmovableCulturalProperty">https://w3id.org/arco/ontology/arco/ImmovableCulturalProperty</seealso>
    let ImmovableCulturalProperty =
        Prefixed_Name(r_arco, "ImmovableCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CartographicTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the cartographic theme associated to a cartographic classification of a cultural property.</para>
    ///   <para>Questa classe rappresenta il tema di riferimento associato a una classificazione cartografica di un bene culturale.</para>
    /// labels<para>Cartographic theme</para><para>Tema cartografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CartographicTheme">https://w3id.org/arco/ontology/arco/CartographicTheme</seealso>
    let CartographicTheme = Prefixed_Name(r_arco, "CartographicTheme") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCartographicTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a cartographic classification of a cultural property to the cartographic theme.</para>
    ///   <para>Questa proprietà collega una classificazione cartografica di un bene culturale al tema di riferimento.</para>
    /// labels<para>has cartographic theme</para><para>ha tema cartografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCartographicTheme">https://w3id.org/arco/ontology/arco/hasCartographicTheme</seealso>
    let hasCartographicTheme =
        Prefixed_Name(r_arco, "hasCartographicTheme") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CartographicSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta il simbolo con cui si rappresenta il bene su una base cartografica in relazione al tema di interesse.</para>
    ///   <para>This class represents the symbol used to represent the cultural property on a cartographic base map, referring to the cartographic theme.</para>
    /// labels<para>Simbolo cartografico</para><para>Cartographic symbol</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CartographicSymbol">https://w3id.org/arco/ontology/arco/CartographicSymbol</seealso>
    let CartographicSymbol = Prefixed_Name(r_arco, "CartographicSymbol") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCartographicSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega una classificazione cartografica di un bene cultural al simbolo cartografico, in riferimento al tema.</para>
    ///   <para>This property relates a cartographic classification of a cultural property to the cartographic symbol related to the theme.</para>
    /// labels<para>has cartographic symbol</para><para>ha simbolo cartografico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCartographicSymbol">https://w3id.org/arco/ontology/arco/hasCartographicSymbol</seealso>
    let hasCartographicSymbol =
        Prefixed_Name(r_arco, "hasCartographicSymbol") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCartographicSymbolOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "has cartographic symbol".</para>
    ///   <para>Questa è la proprietà inversa di "ha simbolo cartografico".</para>
    /// labels<para>è simbolo cartografico di</para><para>is cartographic symbol of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCartographicSymbolOf">https://w3id.org/arco/ontology/arco/isCartographicSymbolOf</seealso>
    let isCartographicSymbolOf =
        Prefixed_Name(r_arco, "isCartographicSymbolOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:cartographicSymbolIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the identifier associated to the cartographic symbol.</para>
    ///   <para>Questa proprietà rappresenta il codice identificativo attribuito al simbolo cartografico.</para>
    /// labels<para>identificativo del simbolo cartografico</para><para>cartographic symbol identifier</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/cartographicSymbolIdentifier">https://w3id.org/arco/ontology/arco/cartographicSymbolIdentifier</seealso>
    let cartographicSymbolIdentifier =
        Prefixed_Name(r_arco, "cartographicSymbolIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isCartographicThemeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa di "ha tema cartografico".</para>
    ///   <para>This is the inverse property of "has cartographic theme".</para>
    /// labels<para>is cartographic theme of</para><para>è tema cartografico di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isCartographicThemeOf">https://w3id.org/arco/ontology/arco/isCartographicThemeOf</seealso>
    let isCartographicThemeOf =
        Prefixed_Name(r_arco, "isCartographicThemeOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ComplexCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a complex cultural property, that consists of different components.</para>
    ///   <para>Questa classe rappresenta un bene culturale complesso, cioè costituito da più parti componenti.</para>
    /// labels<para>Complex Cultural Property</para><para>Bene Culturale Complesso</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ComplexCulturalProperty">https://w3id.org/arco/ontology/arco/ComplexCulturalProperty</seealso>
    let ComplexCulturalProperty =
        Prefixed_Name(r_arco, "ComplexCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:CulturalPropertyComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta una parte componente di un bene culturale complesso.</para>
    ///   <para>This class represents a component of a complex cultural property.</para>
    /// labels<para>Parte Componente di Bene Culturale</para><para>Cultural Property Component</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/CulturalPropertyComponent">https://w3id.org/arco/ontology/arco/CulturalPropertyComponent</seealso>
    let CulturalPropertyComponent =
        Prefixed_Name(r_arco, "CulturalPropertyComponent") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:hasCulturalPropertyComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un bene culturale complesso a una delle sue parti componenti.</para>
    ///   <para>This property relates a cultural property to its components.</para>
    /// labels<para>ha parte componente di bene culturale</para><para>has cultural property component</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyComponent">https://w3id.org/arco/ontology/arco/hasCulturalPropertyComponent</seealso>
    let hasCulturalPropertyComponent =
        Prefixed_Name(r_arco, "hasCulturalPropertyComponent") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:uniqueIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the unique identifier (derived as the concatenation of the region identifier, the catalogue number and the suffix) of a cultural property describey by a catalogue record.</para>
    ///   <para>Questa proprietà permette di associare il codice univoco (ricavato dalla concatenazione di codice regione, numero di catalogo generale ed eventuale suffisso) a un bene culturale descritto in una scheda catalografica.</para>
    /// labels<para>unique identifier</para><para>codice univoco</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/uniqueIdentifier">https://w3id.org/arco/ontology/arco/uniqueIdentifier</seealso>
    let uniqueIdentifier = Prefixed_Name(r_arco, "uniqueIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ArchaeologicalMaterialCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la categoria di materiale, parte di un lotto di materiali archeologici. (es.: ceramiche, industria litica, intonaco, legno, etc.)</para>
    ///   <para>This class represents the category of an archaeological material, that is part of a lot of archaeological materials (e.g.: ceramics, plaster, lithic materials, etc.)</para>
    /// labels<para>Categoria del materiale archeologico</para><para>Archaeological material category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ArchaeologicalMaterialCategory">https://w3id.org/arco/ontology/arco/ArchaeologicalMaterialCategory</seealso>
    let ArchaeologicalMaterialCategory =
        Prefixed_Name(r_arco, "ArchaeologicalMaterialCategory") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:numberOfArchaeologicalMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta la quantità complessiva di uno stesso materiale archeologico componente di un lotto di materiali.</para>
    ///   <para>numero di materiali archeologici componenti</para>
    ///   <para>This property represents the total quantity of an archaeological material that is part of a lot of archaeological materials.</para>
    /// labels<para>number of archeological materials</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/numberOfArchaeologicalMaterials">https://w3id.org/arco/ontology/arco/numberOfArchaeologicalMaterials</seealso>
    let numberOfArchaeologicalMaterials =
        Prefixed_Name(r_arco, "numberOfArchaeologicalMaterials") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ArchaeologicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an archaeological cultural property, consisting of archaeological complexes, archaeological monuments, anthropological materials, archaeological objects, stratigraphic records, archaeological sites, archaeological materials tables. Archaeological complexes: monumental complexes consisting of several building units (inhabited areas, fortified centers, sanctuaries, thermal complexes, etc.), catalogued regardless of their current conservation status. Archaeological monuments: single building units (a tower, a domus, a temple, etc.) catalogued regardless of their current conservation status. Anthropological materials: biological evidence related to archaeological and paleontological contexts. Archaeological objects: movable properties of archaeological origin (jewelry and jewelry, clothing, furnishings, architectural elements, paintings, archeobotanical and archeozoological objects, sculpture, tools and everyday objects, etc.). Stratigraphic records: stratigraphic sequences found in archaeological excavation contexts. Archaeological sites: portions of territory that preserve archaeological evidence. Archaeological materials tables: lots of archaeological materials.</para>
    ///   <para>Questa classe rappresenta un bene culturale archeologico, che può essere un complesso archeologico, un monumento archeologico, un reperto archeologico, un reperto antropologico, un saggio stratigrafico, un sito archeologico, o una tabella materiali archeologici. Complessi archeologici: complessi monumentali costituiti da più unità edilizie (abitati, centri fortificati, santuari, complessi termali, ecc.), catalogati a prescindere dal loro attuale stato di conservazione. Monumenti archeologici: singole unità edilizie (una torre, una domus, un tempio, ecc.) catalogate a prescindere dal loro attuale stato di conservazione. Reperti antropologici: testimonianze biologiche in relazione con contesti archeologici e paleontologici. Reperti archeologici: beni mobili di provenienza archeologica (gioielli e monili, vestimenti, arredi, elementi architettonici, opere di pittura, reperti archeobotanici e archeozoologici, scultura, strumenti e oggetti d’uso, ecc.). Saggi stratigrafici: sequenze stratigrafiche rinvenute in contesti di scavo archeologico. Siti archeologici: porzioni di territorio che conservano testimonianze archeologiche. Tabella materiali archeologici: lotti di materiali di provenienza archeologica</para>
    /// labels<para>Archaeological Property</para><para>Bene Archeologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ArchaeologicalProperty">https://w3id.org/arco/ontology/arco/ArchaeologicalProperty</seealso>
    let ArchaeologicalProperty =
        Prefixed_Name(r_arco, "ArchaeologicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ArchaeologicalMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an archaeological material, that is a part of a lot of archaeological materials.</para>
    ///   <para>Questa classe rappresenta un materiale archeologico, che è una parte di un lotto di materiali archeologici.</para>
    /// labels<para>Archaeological material</para><para>Materiale archeologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ArchaeologicalMaterial">https://w3id.org/arco/ontology/arco/ArchaeologicalMaterial</seealso>
    let ArchaeologicalMaterial =
        Prefixed_Name(r_arco, "ArchaeologicalMaterial") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:HSNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the numerical code associated to a musical instrument according to a specific edition of the Hornbostel-Sachs classification.</para>
    ///   <para>Questa proprietà rappresenta il codice numerico, secondo l'edizione specifica Hornbostel-Sachs, associato allo strumento musicale nell'ambito della classificazione Hornbostel-Sachs.</para>
    /// labels<para>Codice numerico Hornbostel-Sachs</para><para>Hornbostel-Sachs number</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/HSNumber">https://w3id.org/arco/ontology/arco/HSNumber</seealso>
    let HSNumber = Prefixed_Name(r_arco, "HSNumber") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:isReferenceCoinLegendOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "ha reference coin legend".</para>
    ///   <para>Questa è la proprietà inversa di "ha legenda tipo".</para>
    /// labels<para>is reference coin legend of</para><para>è legenda tipo di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/isReferenceCoinLegendOf">https://w3id.org/arco/ontology/arco/isReferenceCoinLegendOf</seealso>
    let isReferenceCoinLegendOf =
        Prefixed_Name(r_arco, "isReferenceCoinLegendOf") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ArchaeologicalScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/arco/MibacScopeOfProtection</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Archeaological</para><para>Archeologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ArchaeologicalScope">https://w3id.org/arco/ontology/arco/ArchaeologicalScope</seealso>
    let ArchaeologicalScope =
        Prefixed_Name(r_arco, "ArchaeologicalScope") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ScientificOrTechnologicalHeritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a scientific and technological heritage, that is instruments of interest to the history of science and technology (astronomical, laboratory, measurement, etc.) relevant to any age and related to specific scientific disciplines (flat-mirror luminaire rotating, apparatus for the colored rings of Newton, bell of Savart, Farina clock, solar clock, pendulum, sextant, telescope, etc.); machines and machinery, means of transport, etc.</para>
    ///   <para>Questa classe rappresenta un bene culturale scientifico e tecnologico, ovvero strumenti di interesse per la storia della scienza e della tecnica (strumenti astronomici, di laboratorio, di misurazione ecc.) pertinenti a qualsiasi epoca e afferenti a specifiche discipline scientifiche ( apparecchio a specchi a piani rotanti, apparecchio per gli anelli colorati di Newton, campana di Savart, orologio di Farina, orologio solare, pendola, sestante, telescopio ecc.); macchine e macchinari, mezzi di trasporto ecc.</para>
    /// labels<para>Scientific Or Technological Heritage</para><para>Bene Scientifico o Tecnologico</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ScientificOrTechnologicalHeritage">https://w3id.org/arco/ontology/arco/ScientificOrTechnologicalHeritage</seealso>
    let ScientificOrTechnologicalHeritage =
        Prefixed_Name(r_arco, "ScientificOrTechnologicalHeritage") |> PrefixedName

    /// <summary>
    ///   <para>r-arco:ArchitecturalLandscapeScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/arco/MibacScopeOfProtection</para>
    ///
    /// labels<para>Architettonico o Paesaggistico</para><para>Architectural or Landscape</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/arco/ArchitecturalLandscapeScope">https://w3id.org/arco/ontology/arco/ArchitecturalLandscapeScope</seealso>
    let ArchitecturalLandscapeScope =
        Prefixed_Name(r_arco, "ArchitecturalLandscapeScope") |> PrefixedName
