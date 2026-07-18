namespace https.w3id.org.arco.ontology.arco.slash

open DoxAletheia.Rdf_Vocabulary

module r_arco =
    let _namespace_name = "https://w3id.org/arco/ontology/arco/"

    /// <summary>
    /// This class represents a complex cultural property, when it is a series or a set.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyCollection"></see></summary>
    let CulturalPropertyCollection =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyCollection" |> NamespacedName

    /// <summary>
    /// This class represents a cartographic classification of a cultural property, referring to the cartographic representation on specific thematic levels, based on a standard or a classification defined by the cataloguing agency.
    /// <see href="https://w3id.org/arco/ontology/arco/CartographicClassification"></see></summary>
    let CartographicClassification =
        Namespaced_IRI.parse _namespace_name "CartographicClassification" |> NamespacedName

    /// <summary>
    /// This class represents a classification concerning a musical instrument, concerning the Hornbostel-Sachs classification or possibily other classifications.
    /// <see href="https://w3id.org/arco/ontology/arco/MusicalInstrumentClassification"></see></summary>
    let MusicalInstrumentClassification =
        Namespaced_IRI.parse _namespace_name "MusicalInstrumentClassification" |> NamespacedName

    /// <summary>
    /// This class represents a photographic entity's classification accorting to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.
    /// <see href="https://w3id.org/arco/ontology/arco/PhotographicHeritageClassification"></see></summary>
    let PhotographicHeritageClassification =
        Namespaced_IRI.parse _namespace_name "PhotographicHeritageClassification" |> NamespacedName

    /// <summary>
    /// This class represents a classification different from the Hornbostel-Sachs classification.
    /// <see href="https://w3id.org/arco/ontology/arco/AlternativeMusicalInstrumentClassification"></see></summary>
    let AlternativeMusicalInstrumentClassification =
        Namespaced_IRI.parse _namespace_name "AlternativeMusicalInstrumentClassification" |> NamespacedName

    /// <summary>
    /// This property represents the taxon code and the taxon definition associated to the musical instrument, according to a musical instrument classification.
    /// <see href="https://w3id.org/arco/ontology/arco/taxon"></see></summary>
    let taxon = Namespaced_IRI.parse _namespace_name "taxon" |> NamespacedName

    /// <summary>
    /// This class represents the Hornbostel-Sachs classification of a musical instrument.
    /// <see href="https://w3id.org/arco/ontology/arco/HornbostelSachsClassification"></see></summary>
    let HornbostelSachsClassification =
        Namespaced_IRI.parse _namespace_name "HornbostelSachsClassification" |> NamespacedName

    /// <summary>
    /// This class represents an archaeological material, that is a part of a lot of archaeological materials.
    /// <see href="https://w3id.org/arco/ontology/arco/ArchaeologicalMaterial"></see></summary>
    let ArchaeologicalMaterial =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalMaterial" |> NamespacedName

    /// <summary>
    /// This class represents the category of an archaeological material, that is part of a lot of archaeological materials (e.g.: ceramics, plaster, lithic materials, etc.)
    /// <see href="https://w3id.org/arco/ontology/arco/ArchaeologicalMaterialCategory"></see></summary>
    let ArchaeologicalMaterialCategory =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalMaterialCategory" |> NamespacedName

    /// <summary>
    /// This property relates the archaeological material to its category (e.g.: ceramics, plaster, lithic materials, etc.)
    /// <see href="https://w3id.org/arco/ontology/arco/hasArchaeologicalMaterialCategory"></see></summary>
    let hasArchaeologicalMaterialCategory =
        Namespaced_IRI.parse _namespace_name "hasArchaeologicalMaterialCategory" |> NamespacedName

    /// <summary>
    /// This property represents the total quantity of an archaeological material that is part of a lot of archaeological materials.
    /// <see href="https://w3id.org/arco/ontology/arco/numberOfArchaeologicalMaterials"></see></summary>
    let numberOfArchaeologicalMaterials =
        Namespaced_IRI.parse _namespace_name "numberOfArchaeologicalMaterials" |> NamespacedName

    /// <summary>
    /// This class represents a generic part of a cultural property, to which some specific information is referred.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyPart"></see></summary>
    let CulturalPropertyPart =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyPart" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has archaeological material category of".
    /// <see href="https://w3id.org/arco/ontology/arco/isArchaeologicalMaterialCategoryOf"></see></summary>
    let isArchaeologicalMaterialCategoryOf =
        Namespaced_IRI.parse _namespace_name "isArchaeologicalMaterialCategoryOf" |> NamespacedName

    /// <summary>
    /// This class represents an archaeological cultural property, consisting of archaeological complexes, archaeological monuments, anthropological materials, archaeological objects, stratigraphic records, archaeological sites, archaeological materials tables. Archaeological complexes: monumental complexes consisting of several building units (inhabited areas, fortified centers, sanctuaries, thermal complexes, etc.), catalogued regardless of their current conservation status. Archaeological monuments: single building units (a tower, a domus, a temple, etc.) catalogued regardless of their current conservation status. Anthropological materials: biological evidence related to archaeological and paleontological contexts. Archaeological objects: movable properties of archaeological origin (jewelry and jewelry, clothing, furnishings, architectural elements, paintings, archeobotanical and archeozoological objects, sculpture, tools and everyday objects, etc.). Stratigraphic records: stratigraphic sequences found in archaeological excavation contexts. Archaeological sites: portions of territory that preserve archaeological evidence. Archaeological materials tables: lots of archaeological materials.
    /// <see href="https://w3id.org/arco/ontology/arco/ArchaeologicalProperty"></see></summary>
    let ArchaeologicalProperty =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalProperty" |> NamespacedName

    /// <summary>
    /// This class represents a tangible cultural property, either immovable or movable.
    /// <see href="https://w3id.org/arco/ontology/arco/TangibleCulturalProperty"></see></summary>
    let TangibleCulturalProperty =
        Namespaced_IRI.parse _namespace_name "TangibleCulturalProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/ArchaeologicalScope"></see>
    /// </summary>
    let ArchaeologicalScope =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalScope" |> NamespacedName

    /// <summary>
    /// This class represents the MiBAC scope of protection (historical artistic, ethoanthropological, architectural landscape, archaeological) of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/MibacScopeOfProtection"></see></summary>
    let MibacScopeOfProtection =
        Namespaced_IRI.parse _namespace_name "MibacScopeOfProtection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/ArchitecturalLandscapeScope"></see>
    /// </summary>
    let ArchitecturalLandscapeScope =
        Namespaced_IRI.parse _namespace_name "ArchitecturalLandscapeScope" |> NamespacedName

    /// <summary>
    /// This class represents an architectural or landscape heritage. Architecture: monumental complexes, public and religious buildings, noble residences, fortified architectures, private buildings, rural buildings, industrial archeology buildings characterized by particular historical and artistic importance. Historical centers: urban settlement structures older than the municipal territories, characterized by particularly important historical artistic testimonies. Parks and gardens: green spaces of particular historical, artistic and environmental importance. Examples of this type of cultural heritage are gardens and parks annexed to noble properties, vegetable gardens and botanical gardens, urban parks, green areas included in archaeological sites, but also small private gardens, cloisters and courtyards, cemeteries, always if characterized by particular historical and artistic relevance.
    /// <see href="https://w3id.org/arco/ontology/arco/ArchitecturalOrLandscapeHeritage"></see></summary>
    let ArchitecturalOrLandscapeHeritage =
        Namespaced_IRI.parse _namespace_name "ArchitecturalOrLandscapeHeritage" |> NamespacedName

    /// <summary>
    /// This class represents an immovable cultural property, a property fastened and/or incorporated into the ground (buildings, monumental complexes, territorial areas, etc.) which generally has a significant spatial extent.
    /// <see href="https://w3id.org/arco/ontology/arco/ImmovableCulturalProperty"></see></summary>
    let ImmovableCulturalProperty =
        Namespaced_IRI.parse _namespace_name "ImmovableCulturalProperty" |> NamespacedName

    /// <summary>
    /// This property relates a cartographic classification of a cultural property to the thematic category.
    /// <see href="https://w3id.org/arco/ontology/arco/hasThematicCategory"></see></summary>
    let hasThematicCategory =
        Namespaced_IRI.parse _namespace_name "hasThematicCategory" |> NamespacedName

    /// <summary>
    /// This class represents the thematic category associated to a cartographic classification of a cultural property (e.g.: Architecture).
    /// <see href="https://w3id.org/arco/ontology/arco/ThematicCategory"></see></summary>
    let ThematicCategory =
        Namespaced_IRI.parse _namespace_name "ThematicCategory" |> NamespacedName

    /// <summary>
    /// This class represents the cartographic theme associated to a cartographic classification of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/CartographicTheme"></see></summary>
    let CartographicTheme =
        Namespaced_IRI.parse _namespace_name "CartographicTheme" |> NamespacedName

    /// <summary>
    /// This property relates a cartographic classification of a cultural property to the cartographic theme.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCartographicTheme"></see></summary>
    let hasCartographicTheme =
        Namespaced_IRI.parse _namespace_name "hasCartographicTheme" |> NamespacedName

    /// <summary>
    /// This class represents a cultural property, both tangible and intangible. A cultural property is the legacy, tangible or intangible, recognised as part of the national cultural heritage, since it helps know and reconstruct the history and the landscape.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalProperty"></see></summary>
    let CulturalProperty =
        Namespaced_IRI.parse _namespace_name "CulturalProperty" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cartographic classification".
    /// <see href="https://w3id.org/arco/ontology/arco/isCartographicClassificationOf"></see></summary>
    let isCartographicClassificationOf =
        Namespaced_IRI.parse _namespace_name "isCartographicClassificationOf" |> NamespacedName

    /// <summary>
    /// This class represents the symbol used to represent the cultural property on a cartographic base map, referring to the cartographic theme.
    /// <see href="https://w3id.org/arco/ontology/arco/CartographicSymbol"></see></summary>
    let CartographicSymbol =
        Namespaced_IRI.parse _namespace_name "CartographicSymbol" |> NamespacedName

    /// <summary>
    /// This property relates a cartographic classification of a cultural property to the cartographic symbol related to the theme.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCartographicSymbol"></see></summary>
    let hasCartographicSymbol =
        Namespaced_IRI.parse _namespace_name "hasCartographicSymbol" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cartographic symbol".
    /// <see href="https://w3id.org/arco/ontology/arco/isCartographicSymbolOf"></see></summary>
    let isCartographicSymbolOf =
        Namespaced_IRI.parse _namespace_name "isCartographicSymbolOf" |> NamespacedName

    /// <summary>
    /// This property represents the identifier associated to the cartographic symbol.
    /// <see href="https://w3id.org/arco/ontology/arco/cartographicSymbolIdentifier"></see></summary>
    let cartographicSymbolIdentifier =
        Namespaced_IRI.parse _namespace_name "cartographicSymbolIdentifier" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cartographic theme".
    /// <see href="https://w3id.org/arco/ontology/arco/isCartographicThemeOf"></see></summary>
    let isCartographicThemeOf =
        Namespaced_IRI.parse _namespace_name "isCartographicThemeOf" |> NamespacedName

    /// <summary>
    /// This class represents a complex cultural property, that consists of different components.
    /// <see href="https://w3id.org/arco/ontology/arco/ComplexCulturalProperty"></see></summary>
    let ComplexCulturalProperty =
        Namespaced_IRI.parse _namespace_name "ComplexCulturalProperty" |> NamespacedName

    /// <summary>
    /// This class represents a component of a complex cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyComponent"></see></summary>
    let CulturalPropertyComponent =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyComponent" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its components.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyComponent"></see></summary>
    let hasCulturalPropertyComponent =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyComponent" |> NamespacedName

    /// <summary>
    /// This property represents the unique identifier (derived as the concatenation of the region identifier, the catalogue number and the suffix) of a cultural property describey by a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/arco/uniqueIdentifier"></see></summary>
    let uniqueIdentifier =
        Namespaced_IRI.parse _namespace_name "uniqueIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the "suffix" associated to a cultural property described by a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/arco/suffix"></see></summary>
    let suffix = Namespaced_IRI.parse _namespace_name "suffix" |> NamespacedName

    /// <summary>
    /// This property represents the general catalogue number associated to a cultural property described by a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/arco/catalogueNumber"></see></summary>
    let catalogueNumber =
        Namespaced_IRI.parse _namespace_name "catalogueNumber" |> NamespacedName

    /// <summary>
    /// This property represents the number of components of a complex cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/numberOfComponents"></see></summary>
    let numberOfComponents =
        Namespaced_IRI.parse _namespace_name "numberOfComponents" |> NamespacedName

    /// <summary>
    /// This property represents the "region identifier" associated to a cultural property described by a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/arco/regionIdentifier"></see></summary>
    let regionIdentifier =
        Namespaced_IRI.parse _namespace_name "regionIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its residual.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyResidual"></see></summary>
    let hasCulturalPropertyResidual =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyResidual" |> NamespacedName

    /// <summary>
    /// This class represents the residual part of a cultural property, that is what's left of the original cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyResidual"></see></summary>
    let CulturalPropertyResidual =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyResidual" |> NamespacedName

    /// <summary>
    /// This class represents a cultural property category based on a subjective evaluation of the cataloguing agent, during the cataloguing process.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyCataloguingCategory"></see></summary>
    let CulturalPropertyCataloguingCategory =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyCataloguingCategory" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property cataloguing category of".
    /// <see href="https://w3id.org/arco/ontology/arco/isCulturalPropertyCataloguingCategoryOf"></see></summary>
    let isCulturalPropertyCataloguingCategoryOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyCataloguingCategoryOf" |> NamespacedName

    /// <summary>
    /// This class represents the category of a cultural property, which contains the information that allows us to frame the terminological identification of the properties catalogued in the context of a wider and more complex semantic structure.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyCategory"></see></summary>
    let CulturalPropertyCategory =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyCategory" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property category".
    /// <see href="https://w3id.org/arco/ontology/arco/isCulturalPropertyCategoryOf"></see></summary>
    let isCulturalPropertyCategoryOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyCategoryOf" |> NamespacedName

    /// <summary>
    /// This property represents the number of members of a cultural property that is a collection (e.g.: series)
    /// <see href="https://w3id.org/arco/ontology/arco/numberOfMembers"></see></summary>
    let numberOfMembers =
        Namespaced_IRI.parse _namespace_name "numberOfMembers" |> NamespacedName

    /// <summary>
    /// Questa proprietà, inversa a "ha componente", collega una delle parti componenti di un bene culturale complesso al bene complesso stesso.
    /// This property, inverse of "has component", relates a component of a complex cultural property to the complex cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/isCulturalPropertyComponentOf"></see></summary>
    let isCulturalPropertyComponentOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyComponentOf" |> NamespacedName

    /// <summary>
    /// This class represents a category of a numismatic property, related to a classification based on an inventory approved by the specific subject area.
    /// <see href="https://w3id.org/arco/ontology/arco/CulturalPropertyInventoryCategory"></see></summary>
    let CulturalPropertyInventoryCategory =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyInventoryCategory" |> NamespacedName

    /// <summary>
    /// This property relates a category based on a classification related to an inventory approved by the specific subject area to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/isCulturalPropertyInventoryCategoryOf"></see></summary>
    let isCulturalPropertyInventoryCategoryOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyInventoryCategoryOf" |> NamespacedName

    /// <summary>
    /// This property represents the number of specimens of the same cultural property part (es.: the number of the teeth of an anthropological material).
    /// <see href="https://w3id.org/arco/ontology/arco/numberOfCulturalPropertyParts"></see></summary>
    let numberOfCulturalPropertyParts =
        Namespaced_IRI.parse _namespace_name "numberOfCulturalPropertyParts" |> NamespacedName

    /// <summary>
    /// This property, inverse of "has residual", relates a residual of a cultural property to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/isCulturalPropertyResidualOf"></see></summary>
    let isCulturalPropertyResidualOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyResidualOf" |> NamespacedName

    /// <summary>
    /// This property represents the number of residuals (only if more than one) of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/numberOfResiduals"></see></summary>
    let numberOfResiduals =
        Namespaced_IRI.parse _namespace_name "numberOfResiduals" |> NamespacedName

    /// <summary>
    /// This class represents a demo-ethno-anthropological heritage, both tangible and intangible. The intangible demoetnoanthropological properties are cultural properties consisting of unique and unrepeatable performances, structurally connected to the territory and to socially shared custom, transmitted through orality and bodily techniques, both in Italy and in Europe and beyond Europe (non-verbal communications, dances, parties and ceremonies, games, oral letters, music, customary norms, performances and shows, knowledge, techniques). Demo-ethno-anthropological tangible properties are cultural properties whose construction and/or use are structurally associated with a socially shared custom, transmitted through orality and bodily techniques, both in the Italian and European and extra-European areas (clothing and body ornaments, furnishings and furnishings, means of transport, rituals, instruments and accessories, properties on the territory).
    /// <see href="https://w3id.org/arco/ontology/arco/DemoEthnoAnthropologicalHeritage"></see></summary>
    let DemoEthnoAnthropologicalHeritage =
        Namespaced_IRI.parse _namespace_name "DemoEthnoAnthropologicalHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/EthnoAnthropologicalScope"></see>
    /// </summary>
    let EthnoAnthropologicalScope =
        Namespaced_IRI.parse _namespace_name "EthnoAnthropologicalScope" |> NamespacedName

    /// <summary>
    /// This property represents the definition associated to a musical instrument, according to the Hornbostel-Sachs classification.
    /// <see href="https://w3id.org/arco/ontology/arco/HSDefinition"></see></summary>
    let HSDefinition =
        Namespaced_IRI.parse _namespace_name "HSDefinition" |> NamespacedName

    /// <summary>
    /// This property represents the edition Horbonstel-Sachs used for classifying a musical instrument.
    /// <see href="https://w3id.org/arco/ontology/arco/HSEdition"></see></summary>
    let HSEdition = Namespaced_IRI.parse _namespace_name "HSEdition" |> NamespacedName
    /// <summary>
    /// This property represents the numerical code associated to a musical instrument according to a specific edition of the Hornbostel-Sachs classification.
    /// <see href="https://w3id.org/arco/ontology/arco/HSNumber"></see></summary>
    let HSNumber = Namespaced_IRI.parse _namespace_name "HSNumber" |> NamespacedName

    /// <summary>
    /// This class represents an historic or artistic property: drawing, printing plate, (contemporary) artworks, print, historic and contemporary garment. Drawings: works done by hand on any support (paper, cardboard, plaster, wood, parchment, stone, silk, table, canvas, etc.) and with special tools (charcoal, chalk, ink, pencil, pastel, pen etc.) and technical specifications (watercolor, blood, etc.). Printing plates: plates of various materials (steel, wood, linoleum, brass, stone, copper zinc, etc.) on which pictorial representations are traced with particular tools (burin, steel or diamond points, punches, scrapers, etc.) and with technical specifications for etching (etching, aquatint, lithography, halftone, screen printing, silica, zincography, etc.). Artworks: movable cultural properties that are integral part of artistic and historical monuments or coming from the dismemberment of the monuments themselves, preserved in collections, museums and art galleries (weapons and armor, civil and religious furnishings, objects for worship, everyday objects, paintings, fabrics and tapestries, walls, etc.). Contemporary artworks: cultural properties representative of the new artistic currents of the centuries XX and XXI (assembly, computer art, installation, environmental installation, audio installation, video installation, interactive multimedia installation, kinetic-visual work, performance, ready-made, virtual reality, video art, etc.). Prints: specimens created through this process: equal copies of pictorial representations on paper, cardboard, leather, parchment, silk, etc. are obtained from a printing plate, with various engraving techniques (etching, aquatint, lithography, zincography, etc.). Historic and contemporary garments: clothes and costumes for men's, women's and children's clothing for civil use, connected to the main intended use and to different occasions of private and social life, according to the historical typologies of the XVIII, XIX and XX centuries (dresses, underwear, hosiery, trousers, shirts, costumes, headphones, skirts, jackets, aprons, liveries, sweaters, cloaks, shawls, scarves, veils, etc.).
    /// <see href="https://w3id.org/arco/ontology/arco/HistoricOrArtisticProperty"></see></summary>
    let HistoricOrArtisticProperty =
        Namespaced_IRI.parse _namespace_name "HistoricOrArtisticProperty" |> NamespacedName

    /// <summary>
    /// This class represents a movable cultural property, that is, an object or an artefact that can be moved in various ways. Movable cultural properties may be "immobilized by destination", i.e. incorporated firmly in the context in which they are located.
    /// <see href="https://w3id.org/arco/ontology/arco/MovableCulturalProperty"></see></summary>
    let MovableCulturalProperty =
        Namespaced_IRI.parse _namespace_name "MovableCulturalProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/HistoricalArtisticScope"></see>
    /// </summary>
    let HistoricalArtisticScope =
        Namespaced_IRI.parse _namespace_name "HistoricalArtisticScope" |> NamespacedName

    /// <summary>
    /// This class represents an intangible cultural property, that part of cultural heritage represented by ephemeral performances of traditional manifestations, techniques, knowledge (festivals, musical and dance performances, theatrical performances, craft techniques, oral literature, etc.), when they occur and of which it is possible to keep memory only through the audio-visual recording that fixes them permanently, crystallizing them.
    /// <see href="https://w3id.org/arco/ontology/arco/IntangibleCulturalProperty"></see></summary>
    let IntangibleCulturalProperty =
        Namespaced_IRI.parse _namespace_name "IntangibleCulturalProperty" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has MiBAC scope of protection".
    /// <see href="https://w3id.org/arco/ontology/arco/isMibacScopeOfProtectionOf"></see></summary>
    let isMibacScopeOfProtectionOf =
        Namespaced_IRI.parse _namespace_name "isMibacScopeOfProtectionOf" |> NamespacedName

    /// <summary>
    /// This class represents a music heritage. Musical instruments: objects created specifically to produce sounds according to different musical cultures, without space-time limits (instruments and accessories of archaeological, artistic, ethno-anthropological interest). Musical instruments-Organ: an object created to produce sounds, consisting of a series of metal rods, of different shape, length and diameter, in which a quantity of air is introduced, by means of a bellows or other mechanism, regulated by one or more keyboards and a pedal board (accompanied by accessories), characterized by specific morphological-decorative and phonic-instrumental aspects (hydraulic organ, positive organ, portative organ, electronic organ, etc.)
    /// <see href="https://w3id.org/arco/ontology/arco/MusicHeritage"></see></summary>
    let MusicHeritage =
        Namespaced_IRI.parse _namespace_name "MusicHeritage" |> NamespacedName

    /// <summary>
    /// This property connects a cultural entity to a classification through which the instrument can be coded.
    /// <see href="https://w3id.org/arco/ontology/arco/hasMusicalInstrumentClassification"></see></summary>
    let hasMusicalInstrumentClassification =
        Namespaced_IRI.parse _namespace_name "hasMusicalInstrumentClassification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/isMusicalInstrumentClassificationOf"></see>
    /// </summary>
    let isMusicalInstrumentClassificationOf =
        Namespaced_IRI.parse _namespace_name "isMusicalInstrumentClassificationOf" |> NamespacedName

    /// <summary>
    /// This class represents a natural heritage, related to botany, mineralogy, paleontology, petrology, planetary science, zoology. Botany: specimens of the plant world from botanical collections (collections of dried plants: herbaria). Mineralogy: specimens of minerals from collections of mineralogy (Augite, Goethite, box of quartz etc.). Paleontology: fossil finds (animals, plants, ichnofossils, samples and microscope preparations, etc.). Petrology: specimens of rocks from collections (Riolite, Trachiandesite etc.). Planetology: meteorites from collections (Aubrite, Ureilite, Eucrite, etc.). Zoology: specimens of the animal world from zoology collections (ustiolo, shrew, mammal, arthropod, butterfly box, elmintological collection, etc.)
    /// <see href="https://w3id.org/arco/ontology/arco/NaturalHeritage"></see></summary>
    let NaturalHeritage =
        Namespaced_IRI.parse _namespace_name "NaturalHeritage" |> NamespacedName

    /// <summary>
    /// This class represents a numismatic property, that is coins and other objects of numismatic interest (premonetal and paramonetal finds, coinage and monetary punches, weights for monetary control, seals and medals), pertinent to any age.
    /// <see href="https://w3id.org/arco/ontology/arco/NumismaticProperty"></see></summary>
    let NumismaticProperty =
        Namespaced_IRI.parse _namespace_name "NumismaticProperty" |> NamespacedName

    /// <summary>
    /// This property relates a numismatic property to one of its categories.
    /// <see href="https://w3id.org/arco/ontology/arco/hasNumismaticPropertyCategory"></see></summary>
    let hasNumismaticPropertyCategory =
        Namespaced_IRI.parse _namespace_name "hasNumismaticPropertyCategory" |> NamespacedName

    /// <summary>
    /// This class represents a functional category of a numismatic property, referring to a classification related to the function or the commission of the cultural property, according to the most common classifications.
    /// <see href="https://w3id.org/arco/ontology/arco/NumismaticPropertyCategory"></see></summary>
    let NumismaticPropertyCategory =
        Namespaced_IRI.parse _namespace_name "NumismaticPropertyCategory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/isNumismaticPropertyCategoryOf"></see>
    /// </summary>
    let isNumismaticPropertyCategoryOf =
        Namespaced_IRI.parse _namespace_name "isNumismaticPropertyCategoryOf" |> NamespacedName

    /// <summary>
    /// This class represents a photographic heritage. Photographs: negative, positive, photographic processes that give rise to unique products (daguerreotypes, ferrotypes, polaroids, chimigrams, etc.), digital photography; complex elements like albums, folders, photomontages, panoramas, porfolii. Photographic funds: conceptual entities that are characterized by the accumulation of multiple homogeneous or heterogeneous physical units from the point of view of the materials that compose them and which represent in their totality a cultural heritage.
    /// <see href="https://w3id.org/arco/ontology/arco/PhotographicHeritage"></see></summary>
    let PhotographicHeritage =
        Namespaced_IRI.parse _namespace_name "PhotographicHeritage" |> NamespacedName

    /// <summary>
    /// This property connects a photographic property to a photographic property's classification, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.
    /// <see href="https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassification"></see></summary>
    let hasPhotographicHeritageClassification =
        Namespaced_IRI.parse _namespace_name "hasPhotographicHeritageClassification" |> NamespacedName

    /// <summary>
    /// This property represents the subject of a photographic heritage as described in a photographic heritage classification other than Iconclass.
    /// <see href="https://w3id.org/arco/ontology/arco/classifiedSubject"></see></summary>
    let classifiedSubject =
        Namespaced_IRI.parse _namespace_name "classifiedSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationOf"></see>
    /// </summary>
    let isPhotographicHeritageClassificationOf =
        Namespaced_IRI.parse _namespace_name "isPhotographicHeritageClassificationOf" |> NamespacedName

    /// <summary>
    /// This class represents photographic property's classification type,, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.
    /// <see href="https://w3id.org/arco/ontology/arco/PhotographicHeritageClassificationType"></see></summary>
    let PhotographicHeritageClassificationType =
        Namespaced_IRI.parse _namespace_name "PhotographicHeritageClassificationType" |> NamespacedName

    /// <summary>
    /// This property connects a photographic property's classification to the classification type, according to to other classification systems as Iconclass. The system has to be recognised and used at national or preferably international level.
    /// <see href="https://w3id.org/arco/ontology/arco/hasPhotographicHeritageClassificationType"></see></summary>
    let hasPhotographicHeritageClassificationType =
        Namespaced_IRI.parse _namespace_name "hasPhotographicHeritageClassificationType" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has photographic heritage classification type".
    /// <see href="https://w3id.org/arco/ontology/arco/isPhotographicHeritageClassificationTypeOf"></see></summary>
    let isPhotographicHeritageClassificationTypeOf =
        Namespaced_IRI.parse _namespace_name "isPhotographicHeritageClassificationTypeOf" |> NamespacedName

    /// <summary>
    /// This class represents the radio-frequency identification (RFID).
    /// <see href="https://w3id.org/arco/ontology/arco/RFId"></see></summary>
    let RFId = Namespaced_IRI.parse _namespace_name "RFId" |> NamespacedName
    /// <summary>
    /// This property relates a radio-frequency identification (RFID) to an object.
    /// <see href="https://w3id.org/arco/ontology/arco/isRFIdOf"></see></summary>
    let isRFIdOf = Namespaced_IRI.parse _namespace_name "isRFIdOf" |> NamespacedName

    /// <summary>
    /// This class represents the reference coin legend.
    /// <see href="https://w3id.org/arco/ontology/arco/ReferenceCoinLegend"></see></summary>
    let ReferenceCoinLegend =
        Namespaced_IRI.parse _namespace_name "ReferenceCoinLegend" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "ha reference coin legend".
    /// <see href="https://w3id.org/arco/ontology/arco/isReferenceCoinLegendOf"></see></summary>
    let isReferenceCoinLegendOf =
        Namespaced_IRI.parse _namespace_name "isReferenceCoinLegendOf" |> NamespacedName

    /// <summary>
    /// This class represents a scientific and technological heritage, that is instruments of interest to the history of science and technology (astronomical, laboratory, measurement, etc.) relevant to any age and related to specific scientific disciplines (flat-mirror luminaire rotating, apparatus for the colored rings of Newton, bell of Savart, Farina clock, solar clock, pendulum, sextant, telescope, etc.); machines and machinery, means of transport, etc.
    /// <see href="https://w3id.org/arco/ontology/arco/ScientificOrTechnologicalHeritage"></see></summary>
    let ScientificOrTechnologicalHeritage =
        Namespaced_IRI.parse _namespace_name "ScientificOrTechnologicalHeritage" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has thematic category".
    /// <see href="https://w3id.org/arco/ontology/arco/isThematicCategoryOf"></see></summary>
    let isThematicCategoryOf =
        Namespaced_IRI.parse _namespace_name "isThematicCategoryOf" |> NamespacedName

    /// <summary>
    /// This property represents the archaeological site identifier.
    /// <see href="https://w3id.org/arco/ontology/arco/archaeologicalSiteIdentifier"></see></summary>
    let archaeologicalSiteIdentifier =
        Namespaced_IRI.parse _namespace_name "archaeologicalSiteIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents information on definition and position of the components of a complex cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/definitionAndPositionOfComponents"></see></summary>
    let definitionAndPositionOfComponents =
        Namespaced_IRI.parse _namespace_name "definitionAndPositionOfComponents" |> NamespacedName

    /// <summary>
    /// This property represents notes on a digital photograph.
    /// <see href="https://w3id.org/arco/ontology/arco/digitalPhotographNote"></see></summary>
    let digitalPhotographNote =
        Namespaced_IRI.parse _namespace_name "digitalPhotographNote" |> NamespacedName

    /// <summary>
    /// This property represents the end time of a time interval, according to different criteria and level of detail (century, century interval, year, yyyy/mm/dd, historical period, etc.).
    /// <see href="https://w3id.org/arco/ontology/arco/endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to a related scientific discipline, alternative to the main one.
    /// <see href="https://w3id.org/arco/ontology/arco/hasAlternativeDiscipline"></see></summary>
    let hasAlternativeDiscipline =
        Namespaced_IRI.parse _namespace_name "hasAlternativeDiscipline" |> NamespacedName

    /// <summary>
    /// This property relates a scientific discipline, alternative to the main one, related to a cultural property to that cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/isAlternativeDisciplineOf"></see></summary>
    let isAlternativeDisciplineOf =
        Namespaced_IRI.parse _namespace_name "isAlternativeDisciplineOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its cartographic classification.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCartographicClassification"></see></summary>
    let hasCartographicClassification =
        Namespaced_IRI.parse _namespace_name "hasCartographicClassification" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its cagaloguing agency. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCataloguingAgency"></see></summary>
    let hasCataloguingAgency =
        Namespaced_IRI.parse _namespace_name "hasCataloguingAgency" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to an agency that plays a role related to the cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/arco/hasRelatedAgency"></see></summary>
    let hasRelatedAgency =
        Namespaced_IRI.parse _namespace_name "hasRelatedAgency" |> NamespacedName

    /// <summary>
    /// This property relates a cagaloguing agency to the catalogued cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/arco/isCataloguingAgencyOf"></see></summary>
    let isCataloguingAgencyOf =
        Namespaced_IRI.parse _namespace_name "isCataloguingAgencyOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to a category based on a subjective evaluation of the cataloguing agent, during the cataloguing process.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyCataloguingCategory"></see></summary>
    let hasCulturalPropertyCataloguingCategory =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyCataloguingCategory" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its category.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyCategory"></see></summary>
    let hasCulturalPropertyCategory =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyCategory" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to a category based on a classification related to an inventory approved by the specific subject area.
    /// <see href="https://w3id.org/arco/ontology/arco/hasCulturalPropertyInventoryCategory"></see></summary>
    let hasCulturalPropertyInventoryCategory =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyInventoryCategory" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its heritage protection agency. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/arco/hasHeritageProtectionAgency"></see></summary>
    let hasHeritageProtectionAgency =
        Namespaced_IRI.parse _namespace_name "hasHeritageProtectionAgency" |> NamespacedName

    /// <summary>
    /// This property relates an heritage protection agency to the cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/arco/isHeritageProtectionAgencyOf"></see></summary>
    let isHeritageProtectionAgencyOf =
        Namespaced_IRI.parse _namespace_name "isHeritageProtectionAgencyOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to the main related scientific discipline.
    /// <see href="https://w3id.org/arco/ontology/arco/hasMainDiscipline"></see></summary>
    let hasMainDiscipline =
        Namespaced_IRI.parse _namespace_name "hasMainDiscipline" |> NamespacedName

    /// <summary>
    /// This property relates the main scientific discipline related to a cultural property to that cultural property.
    /// <see href="https://w3id.org/arco/ontology/arco/isMainDisciplineOf"></see></summary>
    let isMainDisciplineOf =
        Namespaced_IRI.parse _namespace_name "isMainDisciplineOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to ist MiBAC scope of protection
    /// <see href="https://w3id.org/arco/ontology/arco/hasMibacScopeOfProtection"></see></summary>
    let hasMibacScopeOfProtection =
        Namespaced_IRI.parse _namespace_name "hasMibacScopeOfProtection" |> NamespacedName

    /// <summary>
    /// This property relates an object to an RFId.
    /// <see href="https://w3id.org/arco/ontology/arco/hasRFId"></see></summary>
    let hasRFId = Namespaced_IRI.parse _namespace_name "hasRFId" |> NamespacedName

    /// <summary>
    /// This property relates a numismatic property with its reference coin legend.
    /// <see href="https://w3id.org/arco/ontology/arco/hasReferenceCoinLegend"></see></summary>
    let hasReferenceCoinLegend =
        Namespaced_IRI.parse _namespace_name "hasReferenceCoinLegend" |> NamespacedName

    /// <summary>
    /// This property, inverse of "has related agency", relates an agency that plays a role related to a cultural property to that cultural property. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.
    /// <see href="https://w3id.org/arco/ontology/arco/isRelatedAgencyOf"></see></summary>
    let isRelatedAgencyOf =
        Namespaced_IRI.parse _namespace_name "isRelatedAgencyOf" |> NamespacedName

    /// <summary>
    /// This property represents the international identifier of a scientific or technological heritage. More info can be found at https://www.isin.org/
    /// <see href="https://w3id.org/arco/ontology/arco/internationalIdentifier"></see></summary>
    let internationalIdentifier =
        Namespaced_IRI.parse _namespace_name "internationalIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents notes on a musical instrument.
    /// <see href="https://w3id.org/arco/ontology/arco/musicalInstrumentNote"></see></summary>
    let musicalInstrumentNote =
        Namespaced_IRI.parse _namespace_name "musicalInstrumentNote" |> NamespacedName

    /// <summary>
    /// This property represents the number of parts of an entity.
    /// <see href="https://w3id.org/arco/ontology/arco/numberOfParts"></see></summary>
    let numberOfParts =
        Namespaced_IRI.parse _namespace_name "numberOfParts" |> NamespacedName

    /// <summary>
    /// This property represents the start time of a time interval, according to different criteria and level of detail (century, century interval, year, yyyy/mm/dd, historical period, etc.).
    /// <see href="https://w3id.org/arco/ontology/arco/startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
